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


using System.Threading;
namespace RouteTaxi
{
    public partial class Menu : Form
    {   
        Broker b = new Broker();
        TextBox txtLogin = new TextBox();
        TextBox  txtPass= new TextBox();
    
  
        public Menu()
        {
            InitializeComponent();
            this.Size = new Size(660, 400);
            this.Text = "Menu";
            this.BackgroundImage = new Bitmap("av.jpg");
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.DoubleBuffered = true;

            txtLogin.Location = new Point(275, 130);
            txtLogin.Size = new Size(120, 20);
            this.Controls.Add(txtLogin);
            txtPass.UseSystemPasswordChar = true;
            txtPass.Location = new Point(275, 180);
            txtPass.Size = new Size(120, 20);
            this.Controls.Add(txtPass);
            this.Paint += new PaintEventHandler(Program_Paint);
            Button btn = new Button();
            btn.Click += Btn_Click;
            btn.Text = "Registration!";
            btn.Size = new Size(125, 24);
            btn.Location = new Point(245, 310);
            btn.BackColor = Color.Red;
            this.Controls.Add(btn);
            Button btn1 = new Button();
            btn1.Click += Btn1_Click;
            btn1.BackColor = Color.Red;
            btn1.Text = "Log in";
            btn1.Size = new Size(70, 24);
            btn1.Location = new Point(275, 210);
            this.Controls.Add(btn1);
            Button btn2 = new Button();
            btn2.Click += Btn2_Click;
            btn2.BackColor = Color.Red;
            btn2.Text = "Exit";
            btn2.Size = new Size(70, 24);
            btn2.Location = new Point(550, 310);
            this.Controls.Add(btn2);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Close();
        }


        void Btn1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Qwerty Twerty\Documents\Visual Studio 2017\Projects\RouteTaxi\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
            Person p = new Person();
            command.CommandType = CommandType.Text;
            connection.Open();
            command.CommandText = "SELECT Login,Pass,FirstName FROM TPersons ";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                p.Login = reader["Login"].ToString();
                p.Pass = reader["Pass"].ToString();
                p.FirstName = reader["FirstName"].ToString();

                if (txtLogin.Text == p.Login && txtPass.Text == p.Pass)
                {
                    MessageBox.Show("Signed in successfully!", "Ok");
                    MessageBox.Show("Hello " + p.FirstName + "!", "");
                    Hide();
                    Main m = new Main();
                    m.ShowDialog(); 
                    Close();
                }
            }
            if (txtLogin.Text != p.Login || txtPass.Text != p.Pass)
            {
                MessageBox.Show("Wrong login or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Clear();
                txtPass.Clear();
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Hide();
            Registration r = new Registration();
            r.ShowDialog();
            Close();
        }

        void Program_Paint(object sender, PaintEventArgs e)
        {
            string login = "Login:";
            string password = "Password:";
            string akk = "You do not have account?";
            string name = "RouteTaxi";
            e.Graphics.DrawString(login, new Font("Arial", 9, FontStyle.Italic), Brushes.Red, new Point(230, 130));
            e.Graphics.DrawString(password, new Font("Arial", 9, FontStyle.Italic), Brushes.Red, new Point(210, 180));
            e.Graphics.DrawString(akk, new Font("Arial", 9, FontStyle.Italic), Brushes.Yellow, new Point(233, 295));
            e.Graphics.DrawString(name, new Font("Collibri", 30, FontStyle.Italic), Brushes.Red, new Point(220, 40));
        }

       
    }

}
