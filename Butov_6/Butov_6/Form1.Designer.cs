namespace Butov_6 {
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
            this.customGraphics1 = new ControlLib.CustomGraphics();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customGraphics1
            // 
            this.customGraphics1.AnimationSpeed = 100;
            this.customGraphics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGraphics1.Location = new System.Drawing.Point(0, 0);
            this.customGraphics1.Name = "customGraphics1";
            this.customGraphics1.Size = new System.Drawing.Size(484, 461);
            this.customGraphics1.TabIndex = 0;
            this.customGraphics1.Text = "customGraphics1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customGraphics1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Square";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLib.CustomGraphics customGraphics1;
        private System.Windows.Forms.Button button1;
    }
}

