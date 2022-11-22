namespace TippingPoint
{
    partial class FormTippingPoint
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
            this.BtnDetermineValue = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDetermineValue
            // 
            this.BtnDetermineValue.Location = new System.Drawing.Point(51, 71);
            this.BtnDetermineValue.Name = "BtnDetermineValue";
            this.BtnDetermineValue.Size = new System.Drawing.Size(195, 70);
            this.BtnDetermineValue.TabIndex = 0;
            this.BtnDetermineValue.Text = "Determine Top Face Value";
            this.BtnDetermineValue.UseVisualStyleBackColor = true;
            this.BtnDetermineValue.Click += new System.EventHandler(this.BtnDetermineValue_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(306, 71);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(387, 319);
            this.TxtResult.TabIndex = 1;
            // 
            // FormTippingPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDetermineValue);
            this.Name = "FormTippingPoint";
            this.Text = "Tipping Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDetermineValue;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

