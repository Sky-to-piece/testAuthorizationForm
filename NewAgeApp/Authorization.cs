using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewAgeApp
{
    public partial class Authorization : Form
    {
        Point moveStart; // точка для перемещения

        public Authorization()
        {
            InitializeComponent();

            this.Load += Authorization_Load;
            this.MouseDown += penelHeader_MouseDown;
            this.MouseMove += penelHeader_MouseMove;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            headerText.Text = this.Text;
        }

        private void TBLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TBPassword.Focus();
            }
        }

        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTEnter.Focus();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTMinBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTCreateAccount_Click(object sender, EventArgs e)
        {
            new CreateAccount().ShowDialog();
        }

        private void BTEnter_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void penelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void penelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }

        }











        //--color-background: #38444c;
        //--color-border: #697278;
        //--color-text-default: #f0f2f3;
        //--color-base: #293238;
        //--color-accent: #ec1a62;
    }
}
