/* PID_accord
Les angles plus grands sont vers le côté le plus court de la plaque.
Augementer l'angle diminue la fréquence.
*/


#include <Servo.h>

Servo motor;

int capteurPin = A1;
int servoPin = 3;
float pTerm;
float iTerm;
float dTerm;
float pWeight;
float iWeight;
float dWeight;
float errorWeight;
float targetFreq;
float minAngle;
float maxAngle;
float zeroError;
long duration;
long curFreq;
float prevFreq;
float prevvFreq;
float aveFreq;
float prevAveFreq;
float error;
float curAngle;
float curTimer;
float prevTimer;

void setup() {
  pinMode(servoPin, OUTPUT);
  pinMode(capteurPin, INPUT);
  motor.attach(3);
  Serial.begin(9600);
  
  pTerm = 0;
  iTerm = 0;
  dTerm = 0;

  pWeight = 1.5; //4
  iWeight = 0; //0.005
  dWeight = 0; // 10
  errorWeight = -1;

  targetFreq = 105;
  minAngle = 0;
  maxAngle = 165;
  zeroError = 0.005;

  curFreq = getCurFreq();
  prevFreq = curFreq;
  prevvFreq = curFreq;
  curTimer = 0;
  prevTimer = 0;
}

void loop() {
  // get input and smoothing
  prevFreq = curFreq;
  prevvFreq = prevFreq;
  curFreq = getCurFreq();
  // Serial.println(curFreq);
  prevTimer = curTimer;
  curTimer = millis();
  float deltaT = curTimer - prevTimer;
  prevAveFreq = aveFreq;
  aveFreq = (curFreq + prevFreq + prevvFreq)/3; // replace with weighted sum ?

  // term calculating
  pTerm = targetFreq - aveFreq;
  dTerm = (aveFreq - prevAveFreq) / deltaT;
  iTerm += pTerm;

  // error calc
  error = ((pTerm * pWeight) + (iTerm * iWeight) + (dTerm * dWeight)) * errorWeight;
  if ((error > -zeroError) and (error < zeroError)) {
    error = 0;
  }

  Serial.println("Pterm : " + String(pTerm));
  Serial.println("Error precalc : " + String(error));
  curAngle += error;
  Serial.println("CurAngle calc : " + String(curAngle));
  if (curAngle > maxAngle) {
    curAngle = maxAngle;
  } else if (curAngle < minAngle) {
    curAngle = minAngle;
  }
  // set angle
  motor.write(curAngle);
  Serial.println("Current angle : " + String(curAngle));
  // Serial.println("Current error : " + String(error));
}

long getCurFreq() {
  //Code permettant de mesurer fréquence de la corde

  // Mesure la durée de l'impulsion haute (timeout par défaut de 1s)
  noInterrupts();
  unsigned long etat_High = pulseIn(capteurPin, HIGH);
  interrupts();
  
  noInterrupts();
  unsigned long etat_Low = pulseIn(capteurPin, LOW);
  interrupts();

  long periode = (etat_High + etat_Low);

  delay(100);
  long frequence_corde = (1/ (periode*0.000001));
  Serial.println("Fréquence de la corde : " + String(frequence_corde) + " Hz");
  Serial.println("");
  delay(100);
   
  return frequence_corde;
}
