namespace Activity_4
{
    partial class SecondsConvertor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecondsConvertorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInputTextbox = new System.Windows.Forms.TextBox();
            this.ResultsDisplayTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecondsConvertorButton
            // 
            this.SecondsConvertorButton.Location = new System.Drawing.Point(584, 195);
            this.SecondsConvertorButton.Name = "SecondsConvertorButton";
            this.SecondsConvertorButton.Size = new System.Drawing.Size(150, 46);
            this.SecondsConvertorButton.TabIndex = 0;
            this.SecondsConvertorButton.Text = "Convert";
            this.SecondsConvertorButton.UseVisualStyleBackColor = true;
            this.SecondsConvertorButton.Click += new System.EventHandler(this.SecondsConvertorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second Convertor";
            // 
            // UserInputTextbox
            // 
            this.UserInputTextbox.Location = new System.Drawing.Point(453, 121);
            this.UserInputTextbox.Name = "UserInputTextbox";
            this.UserInputTextbox.Size = new System.Drawing.Size(200, 39);
            this.UserInputTextbox.TabIndex = 2;
            // 
            // ResultsDisplayTextbox
            // 
            this.ResultsDisplayTextbox.Location = new System.Drawing.Point(453, 279);
            this.ResultsDisplayTextbox.Name = "ResultsDisplayTextbox";
            this.ResultsDisplayTextbox.Size = new System.Drawing.Size(200, 39);
            this.ResultsDisplayTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type The Number of Second:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Result:";
            // 
            // SecondsConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultsDisplayTextbox);
            this.Controls.Add(this.UserInputTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondsConvertorButton);
            this.Name = "SecondsConvertor";
            this.Text = "secondsConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SecondsConvertorButton;
        private Label label1;
        private TextBox UserInputTextbox;
        private TextBox ResultsDisplayTextbox;
        private Label label2;
        private Label label3;
    }
}