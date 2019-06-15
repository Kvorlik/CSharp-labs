namespace Butov_7 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.formattedTextBox1 = new CarNumberRUS.FormattedTextBox();
            this.SuspendLayout();
            // 
            // formattedTextBox1
            // 
            this.formattedTextBox1.Location = new System.Drawing.Point(73, 27);
            this.formattedTextBox1.Name = "formattedTextBox1";
            this.formattedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.formattedTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 74);
            this.Controls.Add(this.formattedTextBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Car number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarNumberRUS.FormattedTextBox formattedTextBox1;
    }
}

