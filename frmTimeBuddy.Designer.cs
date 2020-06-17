namespace Time_Buddy
{
    partial class frmTimeBuddy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeBuddy));
            this.grpConverter = new System.Windows.Forms.GroupBox();
            this.btnConvCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpTimeShifter = new System.Windows.Forms.GroupBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.lblT2 = new System.Windows.Forms.Label();
            this.txtResultsS = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblTimeOutput = new System.Windows.Forms.Label();
            this.txtResultsHMS = new System.Windows.Forms.TextBox();
            this.grpConverter.SuspendLayout();
            this.grpTimeShifter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConverter
            // 
            this.grpConverter.Controls.Add(this.btnConvCalculate);
            this.grpConverter.Controls.Add(this.label1);
            this.grpConverter.Controls.Add(this.lblInput);
            this.grpConverter.Controls.Add(this.txtOutput);
            this.grpConverter.Controls.Add(this.txtInput);
            this.grpConverter.Location = new System.Drawing.Point(40, 25);
            this.grpConverter.Name = "grpConverter";
            this.grpConverter.Size = new System.Drawing.Size(398, 108);
            this.grpConverter.TabIndex = 0;
            this.grpConverter.TabStop = false;
            this.grpConverter.Text = "Time Converter";
            // 
            // btnConvCalculate
            // 
            this.btnConvCalculate.Location = new System.Drawing.Point(141, 69);
            this.btnConvCalculate.Name = "btnConvCalculate";
            this.btnConvCalculate.Size = new System.Drawing.Size(126, 23);
            this.btnConvCalculate.TabIndex = 4;
            this.btnConvCalculate.Text = "Convert";
            this.btnConvCalculate.UseVisualStyleBackColor = true;
            this.btnConvCalculate.Click += new System.EventHandler(this.btnConvCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(6, 35);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(57, 13);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Time Input";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(284, 31);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(69, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // grpTimeShifter
            // 
            this.grpTimeShifter.Controls.Add(this.txtResultsHMS);
            this.grpTimeShifter.Controls.Add(this.lblTimeOutput);
            this.grpTimeShifter.Controls.Add(this.btnSubtract);
            this.grpTimeShifter.Controls.Add(this.btnAdd);
            this.grpTimeShifter.Controls.Add(this.txtResultsS);
            this.grpTimeShifter.Controls.Add(this.lblT2);
            this.grpTimeShifter.Controls.Add(this.txtT2);
            this.grpTimeShifter.Controls.Add(this.lblT1);
            this.grpTimeShifter.Controls.Add(this.txtT1);
            this.grpTimeShifter.Location = new System.Drawing.Point(43, 161);
            this.grpTimeShifter.Name = "grpTimeShifter";
            this.grpTimeShifter.Size = new System.Drawing.Size(395, 228);
            this.grpTimeShifter.TabIndex = 1;
            this.grpTimeShifter.TabStop = false;
            this.grpTimeShifter.Text = "Time Shifter";
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(152, 35);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(100, 20);
            this.txtT1.TabIndex = 0;
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(107, 38);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(39, 13);
            this.lblT1.TabIndex = 1;
            this.lblT1.Text = "Time 1";
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(152, 61);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(100, 20);
            this.txtT2.TabIndex = 2;
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(107, 64);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(39, 13);
            this.lblT2.TabIndex = 3;
            this.lblT2.Text = "Time 2";
            // 
            // txtResultsS
            // 
            this.txtResultsS.Location = new System.Drawing.Point(152, 161);
            this.txtResultsS.Name = "txtResultsS";
            this.txtResultsS.Size = new System.Drawing.Size(100, 20);
            this.txtResultsS.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(110, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(213, 108);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblTimeOutput
            // 
            this.lblTimeOutput.AutoSize = true;
            this.lblTimeOutput.Location = new System.Drawing.Point(83, 164);
            this.lblTimeOutput.Name = "lblTimeOutput";
            this.lblTimeOutput.Size = new System.Drawing.Size(65, 13);
            this.lblTimeOutput.TabIndex = 7;
            this.lblTimeOutput.Text = "Time Output";
            // 
            // txtResultsHMS
            // 
            this.txtResultsHMS.Location = new System.Drawing.Point(152, 187);
            this.txtResultsHMS.Name = "txtResultsHMS";
            this.txtResultsHMS.Size = new System.Drawing.Size(100, 20);
            this.txtResultsHMS.TabIndex = 8;
            // 
            // frmTimeBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.grpTimeShifter);
            this.Controls.Add(this.grpConverter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimeBuddy";
            this.Text = "Time Buddy";
            this.grpConverter.ResumeLayout(false);
            this.grpConverter.PerformLayout();
            this.grpTimeShifter.ResumeLayout(false);
            this.grpTimeShifter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConverter;
        private System.Windows.Forms.Button btnConvCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpTimeShifter;
        private System.Windows.Forms.Label lblTimeOutput;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtResultsS;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.TextBox txtResultsHMS;
    }
}

