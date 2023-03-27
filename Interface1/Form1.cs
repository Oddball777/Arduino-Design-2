using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using System.Runtime.ConstrainedExecution;

namespace Interface1
{
    public partial class Form1 : Form
    {

        private string freqVal;
        private string noteMusic;
        public string[] listeNote = new string[] {"Fa#", "Sol", "Sol#", "La", "La#" };
        public delegate void d1(string indata);
        private static int counter;
        
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 135;
            timer1.Start();

            serialPort1 = new SerialPort("COM4", 9600);


            try
            {
                serialPort1.Open();

            }

            catch 
            {
                Console.WriteLine("Unable to open COM port - check it's not in use");
            
            
            }
        }


      

        private void buttonOff_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o");
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            serialPort1.Write("O");

        }



        private void boutonH1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");
        }

        private void boutH2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }



        private void boutonModeFreq_Click(object sender, EventArgs e)
        {
            serialPort1.Write("M");
        }

        private void boutonModeMusc_Click(object sender, EventArgs e)
        {
            serialPort1.Write("m");
        }




        private void boutonInterfaceAutonome_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");
        }

        private void boutonInterfaceOrdi_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
        }

        private void FrequenceSpecifiee_Scroll(object sender, EventArgs e)
        {


            if (FrequenceSpecifiee.Value < 90)
            {
                freqVal = "S" + 90;
            }


            else if (FrequenceSpecifiee.Value >= 90)
            {
                freqVal = "S" + FrequenceSpecifiee.Value;
            }

            label2.Text = FrequenceSpecifiee.Value.ToString();


        }

        private void boutonFreqVal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(freqVal)) {
                freqVal = "S0";
            
            }

            serialPort1.Write(freqVal);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void notesMusic_Scroll(object sender, EventArgs e)
        {
            noteMusic = "N" + notesMusic.Value;
            label3.Text = listeNote[notesMusic.Value].ToString();

        }

        private void boutonNotes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(freqVal))
            {
                freqVal = "N0";

            }

            serialPort1.Write(noteMusic);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Code goes here
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            bool haveFrequence = false;
            string frequenceIN = string.Empty;
            while (!haveFrequence) {
                frequenceIN = serialPort1.ReadExisting();
                if (!string.IsNullOrEmpty(frequenceIN) )
                {

                    haveFrequence = true;
                }
            
            }

            if (haveFrequence)
            {
                textBox1.Text = "Accord?: " + frequenceIN + Environment.NewLine;

            }
        }


    }
}
