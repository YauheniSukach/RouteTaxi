using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;
using System.Data.OleDb;

namespace RouteTaxi
{
    public partial class Registration : Form
    {
        Broker b = new Broker();
        Button btn = new Button();
        public Registration()
        {

            InitializeComponent();
            this.Size = new Size(660, 400);
            this.Text = "Menu";
            this.BackgroundImage = new Bitmap("av.jpg");
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Program_Paint);
            btn.Click += Btn_Click;
            btn.Text = "Return to menu";
            btn.BackColor = Color.Red;
            btn.Size = new Size(100, 23);
            btn.Location = new Point(40, 320);
            this.Controls.Add(btn);

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Hide();
            Menu m = new Menu();
            m.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Qwerty Twerty\Documents\Visual Studio 2017\Projects\RouteTaxi\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
            Person p = new Person();
            command.CommandType = CommandType.Text;
            connection.Open();
            command.CommandText = "SELECT Login,Pass FROM TPersons ";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                p.Login = reader["Login"].ToString();
                p.Pass = reader["Pass"].ToString();
               

                if (txtLogin.Text == p.Login)
                {
                    MessageBox.Show("This login already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if(txtPass.Text == p.Pass)
                {
                    MessageBox.Show("This password already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        
            }
            if (txtLogin.Text != p.Login && txtPass.Text != p.Pass )
            {
                p.Login = txtLogin.Text;
                p.Pass = txtPass.Text;
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;

                b.Insert(p);
                MessageBox.Show("Registration successful completed!");
                Hide();
                Menu m = new Menu();
                m.ShowDialog();
                Close();
            }
        }
            void Program_Paint(object sender, PaintEventArgs e)
            {
                string reg = "Registration";
                e.Graphics.DrawString(reg, new Font("Arial", 23, FontStyle.Italic), Brushes.Red, new Point(220, 50));
                string str = "<=";
                e.Graphics.DrawString(str, new Font("Arial", 25, FontStyle.Italic), Brushes.Red, new Point(1, 315));
            }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
