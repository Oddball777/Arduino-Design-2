namespace Interface1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.boutonInterfaceAutonome = new System.Windows.Forms.Button();
            this.FrequenceSpecifiee = new System.Windows.Forms.TrackBar();
            this.boutonFreqVal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boutonNotes = new System.Windows.Forms.Button();
            this.notesMusic = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.boutonInterfaceOrdi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonModeMusc = new System.Windows.Forms.Button();
            this.boutH2 = new System.Windows.Forms.Button();
            this.boutonModeFreq = new System.Windows.Forms.Button();
            this.boutonH1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FrequenceSpecifiee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMusic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // boutonInterfaceAutonome
            // 
            this.boutonInterfaceAutonome.Location = new System.Drawing.Point(220, 234);
            this.boutonInterfaceAutonome.Name = "boutonInterfaceAutonome";
            this.boutonInterfaceAutonome.Size = new System.Drawing.Size(200, 50);
            this.boutonInterfaceAutonome.TabIndex = 8;
            this.boutonInterfaceAutonome.Text = "LCD";
            this.boutonInterfaceAutonome.UseVisualStyleBackColor = true;
            this.boutonInterfaceAutonome.Click += new System.EventHandler(this.boutonInterfaceAutonome_Click);
            // 
            // FrequenceSpecifiee
            // 
            this.FrequenceSpecifiee.Location = new System.Drawing.Point(157, 58);
            this.FrequenceSpecifiee.Maximum = 120;
            this.FrequenceSpecifiee.Minimum = 90;
            this.FrequenceSpecifiee.Name = "FrequenceSpecifiee";
            this.FrequenceSpecifiee.Size = new System.Drawing.Size(669, 69);
            this.FrequenceSpecifiee.TabIndex = 10;
            this.FrequenceSpecifiee.Value = 90;
            this.FrequenceSpecifiee.Scroll += new System.EventHandler(this.FrequenceSpecifiee_Scroll);
            // 
            // boutonFreqVal
            // 
            this.boutonFreqVal.Location = new System.Drawing.Point(15, 58);
            this.boutonFreqVal.Name = "boutonFreqVal";
            this.boutonFreqVal.Size = new System.Drawing.Size(138, 36);
            this.boutonFreqVal.TabIndex = 11;
            this.boutonFreqVal.Text = "Envoyer";
            this.boutonFreqVal.UseVisualStyleBackColor = true;
            this.boutonFreqVal.Click += new System.EventHandler(this.boutonFreqVal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(845, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "90";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boutonNotes
            // 
            this.boutonNotes.Location = new System.Drawing.Point(15, 58);
            this.boutonNotes.Name = "boutonNotes";
            this.boutonNotes.Size = new System.Drawing.Size(138, 34);
            this.boutonNotes.TabIndex = 13;
            this.boutonNotes.Text = "Envoyer";
            this.boutonNotes.UseVisualStyleBackColor = true;
            this.boutonNotes.Click += new System.EventHandler(this.boutonNotes_Click);
            // 
            // notesMusic
            // 
            this.notesMusic.Location = new System.Drawing.Point(158, 58);
            this.notesMusic.Maximum = 4;
            this.notesMusic.Name = "notesMusic";
            this.notesMusic.Size = new System.Drawing.Size(669, 69);
            this.notesMusic.TabIndex = 14;
            this.notesMusic.Scroll += new System.EventHandler(this.notesMusic_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(845, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fa#";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // boutonInterfaceOrdi
            // 
            this.boutonInterfaceOrdi.Location = new System.Drawing.Point(10, 234);
            this.boutonInterfaceOrdi.Name = "boutonInterfaceOrdi";
            this.boutonInterfaceOrdi.Size = new System.Drawing.Size(200, 50);
            this.boutonInterfaceOrdi.TabIndex = 9;
            this.boutonInterfaceOrdi.Text = "Ordi";
            this.boutonInterfaceOrdi.UseVisualStyleBackColor = true;
            this.boutonInterfaceOrdi.Click += new System.EventHandler(this.boutonInterfaceOrdi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.boutonModeMusc);
            this.panel2.Controls.Add(this.boutH2);
            this.panel2.Controls.Add(this.boutonModeFreq);
            this.panel2.Controls.Add(this.boutonH1);
            this.panel2.Controls.Add(this.boutonInterfaceOrdi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonOn);
            this.panel2.Controls.Add(this.buttonOff);
            this.panel2.Controls.Add(this.boutonInterfaceAutonome);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 293);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Configurations";
            // 
            // boutonModeMusc
            // 
            this.boutonModeMusc.Location = new System.Drawing.Point(220, 163);
            this.boutonModeMusc.Name = "boutonModeMusc";
            this.boutonModeMusc.Size = new System.Drawing.Size(200, 50);
            this.boutonModeMusc.TabIndex = 9;
            this.boutonModeMusc.Text = "Musique";
            this.boutonModeMusc.UseVisualStyleBackColor = true;
            this.boutonModeMusc.Click += new System.EventHandler(this.boutonModeMusc_Click);
            // 
            // boutH2
            // 
            this.boutH2.Location = new System.Drawing.Point(227, 41);
            this.boutH2.Name = "boutH2";
            this.boutH2.Size = new System.Drawing.Size(200, 50);
            this.boutH2.TabIndex = 7;
            this.boutH2.Text = "Deuxième Harmonique";
            this.boutH2.UseVisualStyleBackColor = true;
            this.boutH2.Click += new System.EventHandler(this.boutH2_Click);
            // 
            // boutonModeFreq
            // 
            this.boutonModeFreq.Location = new System.Drawing.Point(10, 163);
            this.boutonModeFreq.Name = "boutonModeFreq";
            this.boutonModeFreq.Size = new System.Drawing.Size(200, 50);
            this.boutonModeFreq.TabIndex = 8;
            this.boutonModeFreq.Text = "Fréquence";
            this.boutonModeFreq.UseVisualStyleBackColor = true;
            this.boutonModeFreq.Click += new System.EventHandler(this.boutonModeFreq_Click);
            // 
            // boutonH1
            // 
            this.boutonH1.Location = new System.Drawing.Point(10, 44);
            this.boutonH1.Name = "boutonH1";
            this.boutonH1.Size = new System.Drawing.Size(200, 50);
            this.boutonH1.TabIndex = 6;
            this.boutonH1.Text = "Première Harmonique";
            this.boutonH1.UseVisualStyleBackColor = true;
            this.boutonH1.Click += new System.EventHandler(this.boutonH1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Configurations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.BackColor = System.Drawing.Color.White;
            this.buttonOn.Location = new System.Drawing.Point(10, 107);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(200, 50);
            this.buttonOn.TabIndex = 4;
            this.buttonOn.Text = "Démarrage";
            this.buttonOn.UseVisualStyleBackColor = false;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(220, 103);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(200, 50);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "Arrêt";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.boutonFreqVal);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.FrequenceSpecifiee);
            this.panel3.Location = new System.Drawing.Point(7, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 130);
            this.panel3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Modification en fréquence";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.notesMusic);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.boutonNotes);
            this.panel4.Location = new System.Drawing.Point(7, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 130);
            this.panel4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Modification en notes de musique";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 274);
            this.textBox1.TabIndex = 18;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 593);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FrequenceSpecifiee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMusic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Button boutonInterfaceAutonome;
        private System.Windows.Forms.TrackBar FrequenceSpecifiee;
        private System.Windows.Forms.Button boutonFreqVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boutonNotes;
        private System.Windows.Forms.TrackBar notesMusic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boutonInterfaceOrdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonModeMusc;
        private System.Windows.Forms.Button boutonModeFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutH2;
        private System.Windows.Forms.Button boutonH1;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

