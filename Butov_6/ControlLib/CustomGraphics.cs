using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlLib{
    public class CustomGraphics : Control {
        Timer timer = new Timer();
        private Brush brush;
        private int interval;
        private int opacity;
        private int sum;
        private int speed;

        [Browsable(true)]
        public int AnimationSpeed {
            get { return speed; }
            set {
                if(value > 100) speed = 100;
                if(value < 1) speed = 1;
                if(value >= 1 && value <= 100) speed = value;
                interval = 105 - speed;
                timer.Interval = interval;
            }
        }

        public CustomGraphics() {
            this.Size = new Size(400, 400);
            opacity = 5;
            sum = 0;
            AnimationSpeed = 100;
            DoubleBuffered = true;
            timer.Interval = interval;
            timer.Tick += new EventHandler(ChangeOpacity);
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            brush = new SolidBrush(Color.FromArgb(255 - sum, 34, 139, 34));
            Graphics g = e.Graphics;
            g.Clear(Parent.BackColor);
            Rectangle rect;
            if(Height > Width) rect = new Rectangle(0, 0, Width, Width);
            else rect = new Rectangle(0, 0, Height, Height);
            if(this.DesignMode) {
                g.DrawString(
                    "Бутов Константин, СБС-701-О\n" +
                    "12 вариант\n" +
                    "\'Мерцающий квадрат\'\n" +
                    "Элемент управления позволяет добавить на форму исчезающий квадрат.\n" +
                    "Скорость анимации можно изменять через свойство AnimationSpeed.\n" +
                    "Чем больше значение, тем медленнее мерцание.",
                    Parent.Font, new SolidBrush(Parent.ForeColor), 0, 0);
            }
            else {
                timer.Start();
                g.FillRectangle(brush, rect);
            }
        }

        private void ChangeOpacity(object sender, EventArgs e) {
            if(sum == 255) opacity = -5;
            if(sum == 0) opacity = 5;
            sum += opacity;
            Invalidate();
        }
    }
}
