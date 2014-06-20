namespace USBXpress_TestPanel
{
    partial class TestPanel
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
            this.checkBox_LED1 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED2 = new System.Windows.Forms.CheckBox();
            this.groupBoxLEDs = new System.Windows.Forms.GroupBox();
            this.groupBox_Switches = new System.Windows.Forms.GroupBox();
            this.checkBox_Switch2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Switch1 = new System.Windows.Forms.CheckBox();
            this.groupBox_Port0 = new System.Windows.Forms.GroupBox();
            this.checkBox_P00 = new System.Windows.Forms.CheckBox();
            this.checkBox_P01 = new System.Windows.Forms.CheckBox();
            this.checkBox_P02 = new System.Windows.Forms.CheckBox();
            this.checkBox_P03 = new System.Windows.Forms.CheckBox();
            this.groupBox_Potentiometer = new System.Windows.Forms.GroupBox();
            this.progressBar_Pot = new System.Windows.Forms.ProgressBar();
            this.groupBox_Temperature = new System.Windows.Forms.GroupBox();
            this.checkBox_P10 = new System.Windows.Forms.CheckBox();
            this.checkBox_P11 = new System.Windows.Forms.CheckBox();
            this.checkBox_P12 = new System.Windows.Forms.CheckBox();
            this.groupBox_Port1 = new System.Windows.Forms.GroupBox();
            this.checkBox_P13 = new System.Windows.Forms.CheckBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar_Temp = new System.Windows.Forms.ProgressBar();
            this.label_Pot = new System.Windows.Forms.Label();
            this.label_Temp = new System.Windows.Forms.Label();
            this.groupBoxLEDs.SuspendLayout();
            this.groupBox_Switches.SuspendLayout();
            this.groupBox_Port0.SuspendLayout();
            this.groupBox_Potentiometer.SuspendLayout();
            this.groupBox_Temperature.SuspendLayout();
            this.groupBox_Port1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_LED1
            // 
            this.checkBox_LED1.AutoSize = true;
            this.checkBox_LED1.Location = new System.Drawing.Point(26, 19);
            this.checkBox_LED1.Name = "checkBox_LED1";
            this.checkBox_LED1.Size = new System.Drawing.Size(53, 17);
            this.checkBox_LED1.TabIndex = 0;
            this.checkBox_LED1.Text = "LED1";
            this.checkBox_LED1.UseVisualStyleBackColor = true;
            // 
            // checkBox_LED2
            // 
            this.checkBox_LED2.AutoSize = true;
            this.checkBox_LED2.Location = new System.Drawing.Point(26, 42);
            this.checkBox_LED2.Name = "checkBox_LED2";
            this.checkBox_LED2.Size = new System.Drawing.Size(53, 17);
            this.checkBox_LED2.TabIndex = 1;
            this.checkBox_LED2.Text = "LED2";
            this.checkBox_LED2.UseVisualStyleBackColor = true;
            // 
            // groupBoxLEDs
            // 
            this.groupBoxLEDs.Controls.Add(this.checkBox_LED2);
            this.groupBoxLEDs.Controls.Add(this.checkBox_LED1);
            this.groupBoxLEDs.Location = new System.Drawing.Point(139, 12);
            this.groupBoxLEDs.Name = "groupBoxLEDs";
            this.groupBoxLEDs.Size = new System.Drawing.Size(108, 73);
            this.groupBoxLEDs.TabIndex = 2;
            this.groupBoxLEDs.TabStop = false;
            this.groupBoxLEDs.Text = "LED States";
            // 
            // groupBox_Switches
            // 
            this.groupBox_Switches.Controls.Add(this.checkBox_Switch2);
            this.groupBox_Switches.Controls.Add(this.checkBox_Switch1);
            this.groupBox_Switches.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox_Switches.Location = new System.Drawing.Point(25, 12);
            this.groupBox_Switches.Name = "groupBox_Switches";
            this.groupBox_Switches.Size = new System.Drawing.Size(108, 72);
            this.groupBox_Switches.TabIndex = 3;
            this.groupBox_Switches.TabStop = false;
            this.groupBox_Switches.Text = "Switch States";
            // 
            // checkBox_Switch2
            // 
            this.checkBox_Switch2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Switch2.AutoCheck = false;
            this.checkBox_Switch2.AutoSize = true;
            this.checkBox_Switch2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_Switch2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_Switch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Switch2.Location = new System.Drawing.Point(27, 42);
            this.checkBox_Switch2.Name = "checkBox_Switch2";
            this.checkBox_Switch2.Size = new System.Drawing.Size(55, 23);
            this.checkBox_Switch2.TabIndex = 1;
            this.checkBox_Switch2.Text = "Switch2";
            this.checkBox_Switch2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Switch1
            // 
            this.checkBox_Switch1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Switch1.AutoCheck = false;
            this.checkBox_Switch1.AutoSize = true;
            this.checkBox_Switch1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_Switch1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_Switch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Switch1.Location = new System.Drawing.Point(27, 15);
            this.checkBox_Switch1.Name = "checkBox_Switch1";
            this.checkBox_Switch1.Size = new System.Drawing.Size(55, 23);
            this.checkBox_Switch1.TabIndex = 0;
            this.checkBox_Switch1.Text = "Switch1";
            this.checkBox_Switch1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Port0
            // 
            this.groupBox_Port0.Controls.Add(this.checkBox_P00);
            this.groupBox_Port0.Controls.Add(this.checkBox_P01);
            this.groupBox_Port0.Controls.Add(this.checkBox_P02);
            this.groupBox_Port0.Controls.Add(this.checkBox_P03);
            this.groupBox_Port0.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox_Port0.Location = new System.Drawing.Point(25, 91);
            this.groupBox_Port0.Name = "groupBox_Port0";
            this.groupBox_Port0.Size = new System.Drawing.Size(108, 138);
            this.groupBox_Port0.TabIndex = 4;
            this.groupBox_Port0.TabStop = false;
            this.groupBox_Port0.Text = "Port 0 (Input)";
            // 
            // checkBox_P00
            // 
            this.checkBox_P00.AutoCheck = false;
            this.checkBox_P00.AutoSize = true;
            this.checkBox_P00.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P00.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P00.Location = new System.Drawing.Point(27, 108);
            this.checkBox_P00.Name = "checkBox_P00";
            this.checkBox_P00.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P00.TabIndex = 5;
            this.checkBox_P00.Text = "P0.0";
            this.checkBox_P00.UseVisualStyleBackColor = true;
            // 
            // checkBox_P01
            // 
            this.checkBox_P01.AutoCheck = false;
            this.checkBox_P01.AutoSize = true;
            this.checkBox_P01.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P01.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P01.Location = new System.Drawing.Point(27, 79);
            this.checkBox_P01.Name = "checkBox_P01";
            this.checkBox_P01.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P01.TabIndex = 4;
            this.checkBox_P01.Text = "P0.1";
            this.checkBox_P01.UseVisualStyleBackColor = true;
            // 
            // checkBox_P02
            // 
            this.checkBox_P02.AutoCheck = false;
            this.checkBox_P02.AutoSize = true;
            this.checkBox_P02.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P02.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P02.Location = new System.Drawing.Point(27, 50);
            this.checkBox_P02.Name = "checkBox_P02";
            this.checkBox_P02.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P02.TabIndex = 3;
            this.checkBox_P02.Text = "P0.2";
            this.checkBox_P02.UseVisualStyleBackColor = true;
            // 
            // checkBox_P03
            // 
            this.checkBox_P03.AutoCheck = false;
            this.checkBox_P03.AutoSize = true;
            this.checkBox_P03.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P03.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P03.Location = new System.Drawing.Point(27, 18);
            this.checkBox_P03.Name = "checkBox_P03";
            this.checkBox_P03.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P03.TabIndex = 2;
            this.checkBox_P03.Text = "P0.3";
            this.checkBox_P03.UseVisualStyleBackColor = true;
            // 
            // groupBox_Potentiometer
            // 
            this.groupBox_Potentiometer.Controls.Add(this.label_Pot);
            this.groupBox_Potentiometer.Controls.Add(this.progressBar_Pot);
            this.groupBox_Potentiometer.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox_Potentiometer.Location = new System.Drawing.Point(253, 12);
            this.groupBox_Potentiometer.Name = "groupBox_Potentiometer";
            this.groupBox_Potentiometer.Size = new System.Drawing.Size(200, 73);
            this.groupBox_Potentiometer.TabIndex = 6;
            this.groupBox_Potentiometer.TabStop = false;
            this.groupBox_Potentiometer.Text = "Potentiometer Reading";
            // 
            // progressBar_Pot
            // 
            this.progressBar_Pot.Location = new System.Drawing.Point(6, 24);
            this.progressBar_Pot.Maximum = 255;
            this.progressBar_Pot.Name = "progressBar_Pot";
            this.progressBar_Pot.Size = new System.Drawing.Size(188, 14);
            this.progressBar_Pot.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Pot.TabIndex = 0;
            this.progressBar_Pot.Value = 128;
            // 
            // groupBox_Temperature
            // 
            this.groupBox_Temperature.Controls.Add(this.label_Temp);
            this.groupBox_Temperature.Controls.Add(this.progressBar_Temp);
            this.groupBox_Temperature.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox_Temperature.Location = new System.Drawing.Point(253, 91);
            this.groupBox_Temperature.Name = "groupBox_Temperature";
            this.groupBox_Temperature.Size = new System.Drawing.Size(200, 72);
            this.groupBox_Temperature.TabIndex = 7;
            this.groupBox_Temperature.TabStop = false;
            this.groupBox_Temperature.Text = "Temp Sensor Reading";
            // 
            // checkBox_P10
            // 
            this.checkBox_P10.AutoSize = true;
            this.checkBox_P10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P10.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P10.Location = new System.Drawing.Point(26, 108);
            this.checkBox_P10.Name = "checkBox_P10";
            this.checkBox_P10.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P10.TabIndex = 5;
            this.checkBox_P10.Text = "P1.0";
            this.checkBox_P10.UseVisualStyleBackColor = true;
            // 
            // checkBox_P11
            // 
            this.checkBox_P11.AutoSize = true;
            this.checkBox_P11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P11.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P11.Location = new System.Drawing.Point(26, 79);
            this.checkBox_P11.Name = "checkBox_P11";
            this.checkBox_P11.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P11.TabIndex = 4;
            this.checkBox_P11.Text = "P1.1";
            this.checkBox_P11.UseVisualStyleBackColor = true;
            // 
            // checkBox_P12
            // 
            this.checkBox_P12.AutoSize = true;
            this.checkBox_P12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P12.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P12.Location = new System.Drawing.Point(26, 49);
            this.checkBox_P12.Name = "checkBox_P12";
            this.checkBox_P12.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P12.TabIndex = 3;
            this.checkBox_P12.Text = "P1.2";
            this.checkBox_P12.UseVisualStyleBackColor = true;
            // 
            // groupBox_Port1
            // 
            this.groupBox_Port1.Controls.Add(this.checkBox_P10);
            this.groupBox_Port1.Controls.Add(this.checkBox_P11);
            this.groupBox_Port1.Controls.Add(this.checkBox_P12);
            this.groupBox_Port1.Controls.Add(this.checkBox_P13);
            this.groupBox_Port1.Location = new System.Drawing.Point(139, 91);
            this.groupBox_Port1.Name = "groupBox_Port1";
            this.groupBox_Port1.Size = new System.Drawing.Size(108, 138);
            this.groupBox_Port1.TabIndex = 6;
            this.groupBox_Port1.TabStop = false;
            this.groupBox_Port1.Text = "Port 1 (Output)";
            // 
            // checkBox_P13
            // 
            this.checkBox_P13.AutoSize = true;
            this.checkBox_P13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox_P13.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox_P13.Location = new System.Drawing.Point(26, 19);
            this.checkBox_P13.Name = "checkBox_P13";
            this.checkBox_P13.Size = new System.Drawing.Size(48, 17);
            this.checkBox_P13.TabIndex = 2;
            this.checkBox_P13.Text = "P1.3";
            this.checkBox_P13.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(372, 205);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar_Temp
            // 
            this.progressBar_Temp.Location = new System.Drawing.Point(6, 22);
            this.progressBar_Temp.Maximum = 255;
            this.progressBar_Temp.Name = "progressBar_Temp";
            this.progressBar_Temp.Size = new System.Drawing.Size(188, 14);
            this.progressBar_Temp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Temp.TabIndex = 1;
            this.progressBar_Temp.Value = 128;
            // 
            // label_Pot
            // 
            this.label_Pot.AutoSize = true;
            this.label_Pot.Location = new System.Drawing.Point(7, 51);
            this.label_Pot.Name = "label_Pot";
            this.label_Pot.Size = new System.Drawing.Size(25, 13);
            this.label_Pot.TabIndex = 1;
            this.label_Pot.Text = "128";
            // 
            // label_Temp
            // 
            this.label_Temp.AutoSize = true;
            this.label_Temp.Location = new System.Drawing.Point(7, 50);
            this.label_Temp.Name = "label_Temp";
            this.label_Temp.Size = new System.Drawing.Size(25, 13);
            this.label_Temp.TabIndex = 2;
            this.label_Temp.Text = "128";
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 249);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_Port1);
            this.Controls.Add(this.groupBox_Temperature);
            this.Controls.Add(this.groupBox_Potentiometer);
            this.Controls.Add(this.groupBox_Port0);
            this.Controls.Add(this.groupBox_Switches);
            this.Controls.Add(this.groupBoxLEDs);
            this.Name = "TestPanel";
            this.Text = "TestPanel";
            this.groupBoxLEDs.ResumeLayout(false);
            this.groupBoxLEDs.PerformLayout();
            this.groupBox_Switches.ResumeLayout(false);
            this.groupBox_Switches.PerformLayout();
            this.groupBox_Port0.ResumeLayout(false);
            this.groupBox_Port0.PerformLayout();
            this.groupBox_Potentiometer.ResumeLayout(false);
            this.groupBox_Potentiometer.PerformLayout();
            this.groupBox_Temperature.ResumeLayout(false);
            this.groupBox_Temperature.PerformLayout();
            this.groupBox_Port1.ResumeLayout(false);
            this.groupBox_Port1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_LED1;
        private System.Windows.Forms.CheckBox checkBox_LED2;
        private System.Windows.Forms.GroupBox groupBoxLEDs;
        private System.Windows.Forms.GroupBox groupBox_Switches;
        private System.Windows.Forms.GroupBox groupBox_Port0;
        private System.Windows.Forms.GroupBox groupBox_Potentiometer;
        private System.Windows.Forms.CheckBox checkBox_Switch1;
        private System.Windows.Forms.GroupBox groupBox_Temperature;
        private System.Windows.Forms.CheckBox checkBox_P00;
        private System.Windows.Forms.CheckBox checkBox_P01;
        private System.Windows.Forms.CheckBox checkBox_P02;
        private System.Windows.Forms.CheckBox checkBox_P03;
        private System.Windows.Forms.ProgressBar progressBar_Pot;
        private System.Windows.Forms.CheckBox checkBox_P10;
        private System.Windows.Forms.CheckBox checkBox_P11;
        private System.Windows.Forms.CheckBox checkBox_P12;
        private System.Windows.Forms.GroupBox groupBox_Port1;
        private System.Windows.Forms.CheckBox checkBox_P13;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Pot;
        private System.Windows.Forms.Label label_Temp;
        private System.Windows.Forms.ProgressBar progressBar_Temp;
        private System.Windows.Forms.CheckBox checkBox_Switch2;
    }
}