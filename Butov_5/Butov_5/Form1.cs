using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butov_5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Recalculate() {
            double num;
            if(textBoxVarA.Text == "" || textBoxVarB.Text == "" || textBoxVarC.Text == "" || textBoxVarD.Text == "" || textBoxVarX.Text == "") {
                labelWarn.Text = "Не все поля заполнены";
                labelResult.Text = "...";
            }
            else if (!double.TryParse(textBoxVarA.Text, out num) || !double.TryParse(textBoxVarB.Text, out num) ||
                     !double.TryParse(textBoxVarC.Text, out num) || !double.TryParse(textBoxVarD.Text, out num) ||
                     !double.TryParse(textBoxVarX.Text, out num)) {
                labelWarn.Text = "Ошибка ввода. Введено не число";
                labelResult.Text = "...";
            }
            else {
                if(textBoxVarX.Text == "0") {
                    labelError.Text = "Ошибка вычисления. Нельзя делить на 0 (X = 0)";
                    labelResult.Text = "...";
                }
                else {
                    //A * X^3 + B * X^2 + C / X + (D / X) / X
                    double A = Convert.ToDouble(textBoxVarA.Text);
                    double B = Convert.ToDouble(textBoxVarB.Text);
                    double C = Convert.ToDouble(textBoxVarC.Text);
                    double D = Convert.ToDouble(textBoxVarD.Text);
                    double X = Convert.ToDouble(textBoxVarX.Text);
                    labelResult.Text = Convert.ToString(A * (Math.Pow(X, 3)) + B * (Math.Pow(X, 2)) + C / X + (D / X) / X);
                    labelError.Text = "";
                }
                labelWarn.Text = "";
            }
        }

        private void textBoxVarA_TextChanged(object sender, EventArgs e) {
            Recalculate();
        }

        private void textBoxVarB_TextChanged(object sender, EventArgs e) {
            Recalculate();
        }

        private void textBoxVarC_TextChanged(object sender, EventArgs e) {
            Recalculate();
        }

        private void textBoxVarD_TextChanged(object sender, EventArgs e) {
            Recalculate();
        }

        private void textBoxVarX_TextChanged(object sender, EventArgs e) {
            Recalculate();
        }
    }
}
