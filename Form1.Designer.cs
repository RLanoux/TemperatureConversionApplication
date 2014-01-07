namespace MidtermTemperatureConversionApplication
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblUnitsOfMeasure = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoF2C = new System.Windows.Forms.RadioButton();
            this.rdoC2F = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(26, 33);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(284, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the temperature you wish to convert in the box below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converts to:";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(93, 59);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(217, 23);
            this.lblOutput.TabIndex = 4;
            // 
            // lblUnitsOfMeasure
            // 
            this.lblUnitsOfMeasure.AutoSize = true;
            this.lblUnitsOfMeasure.Location = new System.Drawing.Point(316, 36);
            this.lblUnitsOfMeasure.Name = "lblUnitsOfMeasure";
            this.lblUnitsOfMeasure.Size = new System.Drawing.Size(71, 13);
            this.lblUnitsOfMeasure.TabIndex = 5;
            this.lblUnitsOfMeasure.Text = "in Fahrenheit.";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(26, 117);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(138, 44);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(26, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(284, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 44);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdoF2C
            // 
            this.rdoF2C.AutoSize = true;
            this.rdoF2C.Checked = true;
            this.rdoF2C.Location = new System.Drawing.Point(26, 94);
            this.rdoF2C.Name = "rdoF2C";
            this.rdoF2C.Size = new System.Drawing.Size(123, 17);
            this.rdoF2C.TabIndex = 9;
            this.rdoF2C.TabStop = true;
            this.rdoF2C.Text = "Fahrenheit to Celsius";
            this.rdoF2C.UseVisualStyleBackColor = true;
            this.rdoF2C.CheckedChanged += new System.EventHandler(this.rdoF2C_CheckedChanged);
            // 
            // rdoC2F
            // 
            this.rdoC2F.AutoSize = true;
            this.rdoC2F.Location = new System.Drawing.Point(187, 94);
            this.rdoC2F.Name = "rdoC2F";
            this.rdoC2F.Size = new System.Drawing.Size(123, 17);
            this.rdoC2F.TabIndex = 10;
            this.rdoC2F.TabStop = true;
            this.rdoC2F.Text = "Celsius to Fahrenheit";
            this.rdoC2F.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoC2F);
            this.groupBox1.Controls.Add(this.rdoF2C);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.lblUnitsOfMeasure);
            this.groupBox1.Controls.Add(this.lblOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 319);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(118, 17);
            this.tslStatus.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Midterm Temperature Conversion Application";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblUnitsOfMeasure;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdoF2C;
        private System.Windows.Forms.RadioButton rdoC2F;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
    }
}

