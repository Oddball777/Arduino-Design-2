/* PID_accord
Les angles plus grands sont vers le côté le plus court de la plaque.
Augementer l'angle diminue la fréquence.
*/


#include <Servo.h>
#include <LiquidCrystal.h>

Servo motor;

int capteurPin = A1;
int servoPin = 45;
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

LiquidCrystal LCD(8, 9, 4, 5, 6, 7);
float frequence = 120;      // frequence spécifié par utilisateur
float frequenceHarm1 = 120; // fréquence si on est en harmonique1
int boutonLCD;                    // lire valeur des boutons
float frequenceHarm2;                          // frequence si on est en deuxième harmonique
bool harmonique2 = false;   // True: deuxième harmonique, False: première harmonique
bool music = false;         // True: Mode music, False: mode fréquence
float freqMusic[5] = {92.50, 98.00, 103.83, 110.00, 116.54};  //Liste fréquence des notes
String notesMusic[5] = {"Fa#","Sol", "Sol#", "La", "La#" };   // Liste notes
int ang = 0;               // angle servo moteur
int count = 0;             // indice pour notes et fréquences du mode music  
int musique = 0;           // indice pour les char/ exposant du mode music
byte harm1[8] = {          // permet de créer exposant 1
  0b00010, 0b00110, 0b00010, 0b00010, 0b00111, 0b00000, 0b00000, 0b00000
  };
byte harm2[8] = {         // permet de créer exposant 2
  0b00110, 0b01001, 0b00010, 0b00100, 0b01111, 0b00000, 0b00000, 0b00000
  };

bool on = false;
bool interface = false;

String data;
char d1;
String x;
int freqVal;
int numeroNotes;
int pinOn = 50;


float frequenceA = 96;
float difference;
bool accord = false;
unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 5;
int buttonState;
int lastButtonState = HIGH;

void setup() {
  //myservo.attach(53);         // Pin 53 PWM du Servo-moteur
  LCD.begin(16,2);            // 2 ligne, 16 colonnes sur le LCD
  pinMode(pinOn, OUTPUT);        
  LCD.createChar(0, harm1);   // créer char pour exposant 1
  LCD.createChar(1, harm2);  // créer char pour exposant 2
  
  pinMode(servoPin, OUTPUT);
  pinMode(capteurPin, INPUT);
  motor.attach(45);
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
  int FrequenceActuelle = random(90, 120);        // fréquence mesurée par le capteur, fréquence actuelle
  boutonLCD = analogRead(0);                              // permet de lire les valeurs pour l'utilisation des boutons  
  Interface();
  LCDfunction();
  Serial.println(frequence);
  
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

void LCDfunction(){

  if (frequence < 90){
    frequence = 90;
    }
    
  if(count >= 5){                                 // pour que le code ne fuck pas lorsque l'on est a note plus aigu 
    count = 4;
    }

  if(count <= -1){                               // pour que le code ne fuck pas lorsque l'on est a note plus aigu
    count = 0;
    }
  
  if(boutonLCD>=60 && boutonLCD<200 && harmonique2 == false)       //permet d'incrémenter fréquence ou note en première harmonique
  {
    if (music){
      count = count + 1; 
      }
    
    else if (frequenceHarm1 <120){
      frequenceHarm1 += 1;
    }
  }

  if(boutonLCD>=200 && boutonLCD<400 && harmonique2 == false) //permet de diminuer fréquence ou note en première harmonique
  {
      if (music){
      count = count - 1; 
      }
    
    else if (frequenceHarm1 > 90){
      frequenceHarm1 -= 1;
    }
  }

  if(boutonLCD>= 600 && boutonLCD<800){                            // permet de changer harmonique
    harmonique2 = !harmonique2;
   }

  if (boutonLCD>=0 && boutonLCD<60){
    on = !on;

    if(on){
      digitalWrite(pinOn, HIGH);
      }
    else if (!on){
      digitalWrite(pinOn, LOW);
      }  
    }

  if (interface){
    frequenceHarm1 = freqVal;
    count = numeroNotes;
    }

  frequenceHarm2 = frequenceHarm1 * 2;             

  if(boutonLCD>=60 && boutonLCD<200 && harmonique2 == true)       // permet incrémenter fréquence ou  note en deuxième harmonique
  {
    
    if (music){
      count = count + 1; 
      }
    
    else if (frequenceHarm1 <120){
      frequenceHarm1 += 1;
    }
  }

  if(boutonLCD>=200 && boutonLCD<400 && harmonique2 == true)     // permet diminuer fréquence ou  note en deuxième harmonique
  {

    if (music){
      count = count - 1; 
      }
    
    else if (frequenceHarm1 > 90){
      frequenceHarm1 -= 1;
    }
  }

  if(harmonique2 == true){                        //affichage si on est en deuxième harmonique
    frequence = frequenceHarm2;
    LCD.setCursor(0,1);
    LCD.print("Harm: 2");
   }

  else if(harmonique2 == false){                  // affichage si on est en première harmonique
    frequence = frequenceHarm1;
    LCD.setCursor(0,1);
    LCD.print("Harm: 1");
   }


  if(boutonLCD>= 400 && boutonLCD<600){                          // changer mode fréquence ou musique
    music = !music;
   }

   
   
   if (!music){                                  // affichage si on est pas dans le mode note
      LCD.setCursor(0,0);
      LCD.print("Freq: " + String(frequence) + " Hz    ");
    }

    
   if (music){                                  // affichage si on est dans le mode musique (exposant 1 ou 2)
      if (harmonique2){
        musique = 1;
        }

      else {
        musique = 0;
        }
      
      LCD.setCursor(0,0);
      LCD.print("Note: " + notesMusic[count]);
      LCD.write((byte)musique);
      LCD.print("     ");
      frequence = freqMusic[count];
    }

    difference = frequenceA - frequence;

    if(abs(difference) <= 1.5){
      accord = true;
      LCD.setCursor(9 ,1);
      LCD.print(" Accord ");
    }

     if (abs(difference) >= 1.5){
      accord = false;
      LCD.setCursor(9 ,1);
      LCD.print(" NonAcc ");
    }

    LCD.setCursor(7,1);
    LCD.print(freqVal);

     



   
    ang = (122.33-frequence)/0.19732;
    myservo.write(ang);
    delay(125);
  }




  void Interface(){
    if (Serial.available()){
    data = Serial.readString();
    d1 = data.charAt(0);
      switch(d1){ // select action based upton first character
        case 'O':
        on = true;
        digitalWrite(pinOn, HIGH);
        break;

        case 'o':
        on = false;
        digitalWrite(pinOn, LOW);
        break;

        case 'H':   //active première harmonique
        harmonique2 = false;
        break;

        case 'h':  // active deuxième harmonique
        harmonique2 = true;
        break;

        case 'M':
        music = false;
        break;

        case 'm':
        music = true;
        break;

        case 'S':
        x = data.substring(1);
        freqVal = x.toInt();
        break;

        case 'I':
        interface = false;
        break;

        case 'i':
        interface = true;
        break;

        case 'N':
        x = data.substring(1);
        numeroNotes = x.toInt();
        break;
        }
      }
    }
