using System;
using System.Windows.Forms;

namespace CarNumberRUS {
    public class FormattedTextBox : TextBox {
        int pos;
        public FormattedTextBox() {
            this.Multiline = false;
            this.Text = "_________RUS";
            pos = -1;
            base.Enter += new EventHandler(this.BaseEntered);
            base.Click += new EventHandler(this.BaseTriggered);
        }

        public void BaseTriggered(object sender, EventArgs e) {
            base.SelectionStart = 0;
            base.SelectionLength = 0;
        }

        public void BaseEntered(object sender, EventArgs e) {
            pos++;
            base.SelectionStart = 0;
            base.SelectionLength = 0;
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            if(e.KeyCode == Keys.Right) BaseTriggered(this, new EventArgs());
            if(e.KeyCode == Keys.Left) BaseTriggered(this, new EventArgs());
            if(e.KeyCode == Keys.Delete) BaseTriggered(this, new EventArgs());
            if(e.KeyCode == Keys.Back) {
                if(pos > 0 && pos < 10) {
                    pos--;
                    this.Text = this.Text.Substring(0, pos) + "_" + this.Text.Substring(pos + 1, this.Text.Length - 1 - pos);
                    base.SelectionStart = 0;
                    base.SelectionLength = 0;
                }
            }
            e.Handled = true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            if(pos < 9 && e.KeyChar != '\b') {
                if(pos == 0 || pos == 4 || pos == 5) {
                    if(!char.IsDigit(e.KeyChar)) {
                        this.Text = this.Text.Substring(0, pos) + e.KeyChar + this.Text.Substring(pos + 1, this.Text.Length - 1 - pos);
                        BaseEntered(this, new EventArgs());
                    }
                }
                if(pos == 1 || pos == 2 || pos == 3 || pos == 6 || pos == 7 || pos == 8) {
                    if(char.IsDigit(e.KeyChar)) {
                        this.Text = this.Text.Substring(0, pos) + e.KeyChar + this.Text.Substring(pos + 1, this.Text.Length - 1 - pos);
                        BaseEntered(this, new EventArgs());
                    }
                }
            }
            e.Handled = true;
        }
    }
}
//Про трёхзначный код региона: ГОСТ Р 50577-93