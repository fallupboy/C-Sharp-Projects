namespace Password_Generator
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
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.UppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.LowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.CopyConfirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputText.Enabled = false;
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputText.Location = new System.Drawing.Point(12, 69);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(637, 41);
            this.OutputText.TabIndex = 0;
            this.OutputText.Text = "Your password should appear here...";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(609, 44);
            this.Title.TabIndex = 1;
            this.Title.Text = "Welcome to Password Generator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UppercaseCheckBox
            // 
            this.UppercaseCheckBox.AutoSize = true;
            this.UppercaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UppercaseCheckBox.Location = new System.Drawing.Point(12, 178);
            this.UppercaseCheckBox.Name = "UppercaseCheckBox";
            this.UppercaseCheckBox.Size = new System.Drawing.Size(259, 36);
            this.UppercaseCheckBox.TabIndex = 5;
            this.UppercaseCheckBox.Text = "Uppercase letters";
            this.UppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbersCheckBox.Location = new System.Drawing.Point(12, 220);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(151, 36);
            this.NumbersCheckBox.TabIndex = 6;
            this.NumbersCheckBox.Text = "Numbers";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SymbolsCheckBox
            // 
            this.SymbolsCheckBox.AutoSize = true;
            this.SymbolsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SymbolsCheckBox.Location = new System.Drawing.Point(12, 262);
            this.SymbolsCheckBox.Name = "SymbolsCheckBox";
            this.SymbolsCheckBox.Size = new System.Drawing.Size(243, 36);
            this.SymbolsCheckBox.TabIndex = 7;
            this.SymbolsCheckBox.Text = "Special symbols";
            this.SymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(474, 327);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(175, 54);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "GENERATE";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // LowercaseCheckBox
            // 
            this.LowercaseCheckBox.AutoSize = true;
            this.LowercaseCheckBox.Checked = true;
            this.LowercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowercaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowercaseCheckBox.Location = new System.Drawing.Point(12, 136);
            this.LowercaseCheckBox.Name = "LowercaseCheckBox";
            this.LowercaseCheckBox.Size = new System.Drawing.Size(259, 36);
            this.LowercaseCheckBox.TabIndex = 9;
            this.LowercaseCheckBox.Text = "Lowercase letters";
            this.LowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyButton.Location = new System.Drawing.Point(474, 254);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(175, 54);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Text = "COPY PASS";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CopyConfirmation
            // 
            this.CopyConfirmation.AutoSize = true;
            this.CopyConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyConfirmation.Location = new System.Drawing.Point(395, 220);
            this.CopyConfirmation.Name = "CopyConfirmation";
            this.CopyConfirmation.Size = new System.Drawing.Size(0, 18);
            this.CopyConfirmation.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 393);
            this.Controls.Add(this.CopyConfirmation);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.LowercaseCheckBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SymbolsCheckBox);
            this.Controls.Add(this.NumbersCheckBox);
            this.Controls.Add(this.UppercaseCheckBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OutputText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.CheckBox UppercaseCheckBox;
        private System.Windows.Forms.CheckBox NumbersCheckBox;
        private System.Windows.Forms.CheckBox SymbolsCheckBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox LowercaseCheckBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label CopyConfirmation;
    }
}

