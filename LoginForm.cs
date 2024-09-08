using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Width, 36);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Aquamarine;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Snow;
        }

        Point lastPont;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPont.X;
                this.Top += e.Y - lastPont.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPont = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPont.X;
                this.Top += e.Y - lastPont.Y;
            }

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPont = new Point (e.X, e.Y);    
        }
    }
}
