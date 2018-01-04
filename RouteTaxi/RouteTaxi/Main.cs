using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteTaxi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new Size(660, 400);
            this.Text = "Menu";
            this.BackgroundImage = new Bitmap("av.jpg");
            this.Paint += new PaintEventHandler(Program_Paint);
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.DoubleBuffered = true;
            Button btn = new Button();
            btn.Click += Btn_Click;
            btn.Text = "Schedule";
            btn.BackColor = Color.Red;
            btn.Size = new Size(140, 44);
            btn.Location = new Point(260, 80);
            this.Controls.Add(btn);
            Button btn5 = new Button();
            btn5.Click += Btn5_Click;
            btn5.Text = "Return to menu";
            btn5.BackColor = Color.Red;
            btn5.Size = new Size(100, 23);
            btn5.Location = new Point(40, 320);
            this.Controls.Add(btn5);
            Button btn6 = new Button();
            btn6.Click += Btn6_Click;
            btn6.Text = "Exit";
            btn6.BackColor = Color.Red;
            btn6.Size = new Size(70, 23);
            btn6.Location = new Point(540, 320);
            this.Controls.Add(btn6);



        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Hide();
            Menu m = new Menu();
            m.ShowDialog();
            Close();

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Hide();
            Schedule s = new Schedule();
            s.ShowDialog();
            Close();

        }
        void Program_Paint(object sender, PaintEventArgs e)
        {
            string  m = "Main";
            string str = "<=";
            e.Graphics.DrawString(m, new Font("Arial", 27, FontStyle.Italic), Brushes.Red, new Point(285, 27));
            e.Graphics.DrawString(str, new Font("Arial", 25, FontStyle.Italic), Brushes.Red, new Point(1, 315));
        }


    }
}

