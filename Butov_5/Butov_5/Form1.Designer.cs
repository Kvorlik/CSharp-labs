namespace Butov_5 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.textBoxVarB = new System.Windows.Forms.TextBox();
            this.textBoxVarC = new System.Windows.Forms.TextBox();
            this.textBoxVarD = new System.Windows.Forms.TextBox();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите переменные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "D:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "X:";
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(26, 40);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(58, 20);
            this.textBoxVarA.TabIndex = 6;
            this.textBoxVarA.Text = "0";
            this.textBoxVarA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVarA.TextChanged += new System.EventHandler(this.textBoxVarA_TextChanged);
            // 
            // textBoxVarB
            // 
            this.textBoxVarB.Location = new System.Drawing.Point(114, 40);
            this.textBoxVarB.Name = "textBoxVarB";
            this.textBoxVarB.Size = new System.Drawing.Size(58, 20);
            this.textBoxVarB.TabIndex = 7;
            this.textBoxVarB.Text = "0";
            this.textBoxVarB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVarB.TextChanged += new System.EventHandler(this.textBoxVarB_TextChanged);
            // 
            // textBoxVarC
            // 
            this.textBoxVarC.Location = new System.Drawing.Point(202, 40);
            this.textBoxVarC.Name = "textBoxVarC";
            this.textBoxVarC.Size = new System.Drawing.Size(58, 20);
            this.textBoxVarC.TabIndex = 8;
            this.textBoxVarC.Text = "0";
            this.textBoxVarC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVarC.TextChanged += new System.EventHandler(this.textBoxVarC_TextChanged);
            // 
            // textBoxVarD
            // 
            this.textBoxVarD.Location = new System.Drawing.Point(290, 40);
            this.textBoxVarD.Name = "textBoxVarD";
            this.textBoxVarD.Size = new System.Drawing.Size(58, 20);
            this.textBoxVarD.TabIndex = 9;
            this.textBoxVarD.Text = "0";
            this.textBoxVarD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVarD.TextChanged += new System.EventHandler(this.textBoxVarD_TextChanged);
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Location = new System.Drawing.Point(378, 40);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(58, 20);
            this.textBoxVarX.TabIndex = 10;
            this.textBoxVarX.Text = "1";
            this.textBoxVarX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxVarX.TextChanged += new System.EventHandler(this.textBoxVarX_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = " A * X^3 + B * X^2 + C / X + (D / X) / X =";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(264, 77);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(20, 17);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "...";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(64, 138);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 13;
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWarn.ForeColor = System.Drawing.Color.Teal;
            this.labelWarn.Location = new System.Drawing.Point(144, 110);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(0, 17);
            this.labelWarn.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 176);
            this.Controls.Add(this.labelWarn);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxVarX);
            this.Controls.Add(this.textBoxVarD);
            this.Controls.Add(this.textBoxVarC);
            this.Controls.Add(this.textBoxVarB);
            this.Controls.Add(this.textBoxVarA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Task 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.TextBox textBoxVarB;
        private System.Windows.Forms.TextBox textBoxVarC;
        private System.Windows.Forms.TextBox textBoxVarD;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelWarn;
    }
}

