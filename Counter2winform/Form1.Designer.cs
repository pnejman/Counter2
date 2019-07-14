namespace Counter2winform
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
            this.labelEnterNumberLabel = new System.Windows.Forms.Label();
            this.checkboxInputAsWords = new System.Windows.Forms.CheckBox();
            this.textboxInputNumber = new System.Windows.Forms.TextBox();
            this.buttonSubmitNumberOf = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.labelSetupCounter = new System.Windows.Forms.Label();
            this.textboxDelay = new System.Windows.Forms.TextBox();
            this.textboxEndValue = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelEndValue = new System.Windows.Forms.Label();
            this.buttonSubmitSetup = new System.Windows.Forms.Button();
            this.labelCurrentCounter = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.checkboxInputAsRomanNumber = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelEnterNumberLabel
            // 
            this.labelEnterNumberLabel.AutoSize = true;
            this.labelEnterNumberLabel.Location = new System.Drawing.Point(12, 12);
            this.labelEnterNumberLabel.Name = "labelEnterNumberLabel";
            this.labelEnterNumberLabel.Size = new System.Drawing.Size(138, 13);
            this.labelEnterNumberLabel.TabIndex = 0;
            this.labelEnterNumberLabel.Text = "1. Enter number of counters";
            // 
            // checkboxInputAsWords
            // 
            this.checkboxInputAsWords.AutoSize = true;
            this.checkboxInputAsWords.Location = new System.Drawing.Point(154, 35);
            this.checkboxInputAsWords.Name = "checkboxInputAsWords";
            this.checkboxInputAsWords.Size = new System.Drawing.Size(132, 17);
            this.checkboxInputAsWords.TabIndex = 1;
            this.checkboxInputAsWords.Text = "Input as English words";
            this.checkboxInputAsWords.UseVisualStyleBackColor = true;
            // 
            // textboxInputNumber
            // 
            this.textboxInputNumber.Location = new System.Drawing.Point(154, 9);
            this.textboxInputNumber.Name = "textboxInputNumber";
            this.textboxInputNumber.Size = new System.Drawing.Size(214, 20);
            this.textboxInputNumber.TabIndex = 2;
            // 
            // buttonSubmitNumberOf
            // 
            this.buttonSubmitNumberOf.Location = new System.Drawing.Point(384, 9);
            this.buttonSubmitNumberOf.Name = "buttonSubmitNumberOf";
            this.buttonSubmitNumberOf.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitNumberOf.TabIndex = 3;
            this.buttonSubmitNumberOf.Text = "Submit";
            this.buttonSubmitNumberOf.UseVisualStyleBackColor = true;
            this.buttonSubmitNumberOf.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(12, 176);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(447, 287);
            this.consoleBox.TabIndex = 4;
            // 
            // labelSetupCounter
            // 
            this.labelSetupCounter.AutoSize = true;
            this.labelSetupCounter.Enabled = false;
            this.labelSetupCounter.Location = new System.Drawing.Point(37, 79);
            this.labelSetupCounter.Name = "labelSetupCounter";
            this.labelSetupCounter.Size = new System.Drawing.Size(91, 13);
            this.labelSetupCounter.TabIndex = 5;
            this.labelSetupCounter.Text = "2. Setup counters";
            // 
            // textboxDelay
            // 
            this.textboxDelay.Enabled = false;
            this.textboxDelay.Location = new System.Drawing.Point(154, 76);
            this.textboxDelay.Name = "textboxDelay";
            this.textboxDelay.Size = new System.Drawing.Size(100, 20);
            this.textboxDelay.TabIndex = 6;
            // 
            // textboxEndValue
            // 
            this.textboxEndValue.Enabled = false;
            this.textboxEndValue.Location = new System.Drawing.Point(268, 76);
            this.textboxEndValue.Name = "textboxEndValue";
            this.textboxEndValue.Size = new System.Drawing.Size(100, 20);
            this.textboxEndValue.TabIndex = 7;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Enabled = false;
            this.labelDelay.Location = new System.Drawing.Point(175, 103);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(56, 13);
            this.labelDelay.TabIndex = 8;
            this.labelDelay.Text = "Delay (ms)";
            // 
            // labelEndValue
            // 
            this.labelEndValue.AutoSize = true;
            this.labelEndValue.Enabled = false;
            this.labelEndValue.Location = new System.Drawing.Point(287, 103);
            this.labelEndValue.Name = "labelEndValue";
            this.labelEndValue.Size = new System.Drawing.Size(55, 13);
            this.labelEndValue.TabIndex = 9;
            this.labelEndValue.Text = "End value";
            // 
            // buttonSubmitSetup
            // 
            this.buttonSubmitSetup.Enabled = false;
            this.buttonSubmitSetup.Location = new System.Drawing.Point(384, 76);
            this.buttonSubmitSetup.Name = "buttonSubmitSetup";
            this.buttonSubmitSetup.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitSetup.TabIndex = 10;
            this.buttonSubmitSetup.Text = "Submit";
            this.buttonSubmitSetup.UseVisualStyleBackColor = true;
            this.buttonSubmitSetup.Click += new System.EventHandler(this.ButtonSubmitSetup_Click);
            // 
            // labelCurrentCounter
            // 
            this.labelCurrentCounter.AutoSize = true;
            this.labelCurrentCounter.Enabled = false;
            this.labelCurrentCounter.Location = new System.Drawing.Point(75, 103);
            this.labelCurrentCounter.Name = "labelCurrentCounter";
            this.labelCurrentCounter.Size = new System.Drawing.Size(18, 13);
            this.labelCurrentCounter.TabIndex = 11;
            this.labelCurrentCounter.Text = "-/-";
            this.labelCurrentCounter.Visible = false;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Enabled = false;
            this.buttonLaunch.Location = new System.Drawing.Point(15, 134);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(135, 23);
            this.buttonLaunch.TabIndex = 13;
            this.buttonLaunch.Text = "3. Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.ButtonLaunch_Click);
            // 
            // checkboxInputAsRomanNumber
            // 
            this.checkboxInputAsRomanNumber.AutoSize = true;
            this.checkboxInputAsRomanNumber.Location = new System.Drawing.Point(293, 36);
            this.checkboxInputAsRomanNumber.Name = "checkboxInputAsRomanNumber";
            this.checkboxInputAsRomanNumber.Size = new System.Drawing.Size(141, 17);
            this.checkboxInputAsRomanNumber.TabIndex = 14;
            this.checkboxInputAsRomanNumber.Text = "Input as Roman Number";
            this.checkboxInputAsRomanNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 475);
            this.Controls.Add(this.checkboxInputAsRomanNumber);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.labelCurrentCounter);
            this.Controls.Add(this.buttonSubmitSetup);
            this.Controls.Add(this.labelEndValue);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.textboxEndValue);
            this.Controls.Add(this.textboxDelay);
            this.Controls.Add(this.labelSetupCounter);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.buttonSubmitNumberOf);
            this.Controls.Add(this.textboxInputNumber);
            this.Controls.Add(this.checkboxInputAsWords);
            this.Controls.Add(this.labelEnterNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Counter2 - WinForm Edition 2k19 Premium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterNumberLabel;
        private System.Windows.Forms.CheckBox checkboxInputAsWords;
        private System.Windows.Forms.TextBox textboxInputNumber;
        private System.Windows.Forms.Button buttonSubmitNumberOf;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Label labelSetupCounter;
        private System.Windows.Forms.TextBox textboxDelay;
        private System.Windows.Forms.TextBox textboxEndValue;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelEndValue;
        private System.Windows.Forms.Button buttonSubmitSetup;
        private System.Windows.Forms.Label labelCurrentCounter;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.CheckBox checkboxInputAsRomanNumber;
    }
}

