using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewAgeApp
{
    public partial class Authorization : Form
    {
        DB db = new DB();

        //Comments in Russian
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            PanelHeaderSettings();
            this.Opacity = .90;
            PBView.Visible = false;
            TBPassword.MaxLength = 50;
            TBLogin.MaxLength = 50;
        }
        //Настройки панели заголовка
        public void PanelHeaderSettings()
        {
            headerText.Text = this.Text;
            BTExit.FlatAppearance.BorderSize = 0;
            BTExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 0, 75);
            BTExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 0, 35);
            BTMinBox.FlatAppearance.BorderSize = 0;
            BTMinBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 150, 200);
            BTMinBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 100, 175);
        }
        //Переход с поля ввода логина на поле ввода пароля по клавише Enter
        private void TBLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { TBPassword.Focus(); }
        }
        //Переход с поля пароля на кнопку ввода по клавише Enter
        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { BTEnter.Focus(); }
        }
        //Показать пароль
        private void PBView_Click(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = true;
            PBHide.Visible = true;
            PBView.Visible = false;
        }
        //Скрыть пароль
        private void PBHide_Click(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = false;
            PBHide.Visible = false;
            PBView.Visible = true;
        }
        //Кнопка Ввода
        private void BTEnter_Click(object sender, EventArgs e)
        {
            var loginUser = TBLogin.Text;
            var passUser = TBPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT ID, UserName, Password, Roles FROM UsersNA WHERE UserName = '{loginUser}' and Password = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            try
            {
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Ура, вы успешно вошли!", "Успешно.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    new MainPage().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует, либо введённый пароль и логин не верный", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка подключения", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
            //Кнопка создать аккаунт
        private void BTCreateAccount_Click(object sender, EventArgs e)   
        { new CreateAccount().ShowDialog(); }
            //Кнопка свернуть приложение
        private void BTMinBox_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
            //Кнопка закрыть приложение
        private void BTExit_Click(object sender, EventArgs e)
        { Close(); }
            /// Передвигаем окошко по экрану, при зажатой клавише мыши на верхней панели
        Point lastPoint;
        //берём местонахождение мышки и отнимаем от нее данные из переменной lastPoint
        private void penelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        //устанавливаем новые координаты в переменную lastPoin
        private void penelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Переключение темы
        bool switchTheme = false;
        private void PBTheme_Click(object sender, EventArgs e)
        {
            switchTheme = !switchTheme;
            if (switchTheme != true)
            { DarkTheme(); }
            else { LightTheme(); }
        }
        //Тёмная тема
        public void DarkTheme()
        {
            BackColor = Color.FromArgb(56, 68, 76);
            ForeColor = Color.FromArgb(240, 242, 243);
            PBHeaderLogo.Image = Properties.Resources.smoke;
            BTEnter.BackColor = Color.FromArgb(41, 50, 56);
            BTCreateAccount.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(54, 66, 74);
        }
        //Светлая тема
        public void LightTheme()
        {
            BackColor = Color.FromArgb(240, 242, 243);
            ForeColor = Color.FromArgb(56, 68, 76);
            PBHeaderLogo.Image = Properties.Resources.smokeLight;
            BTEnter.BackColor = Color.FromArgb(201, 203, 205);
            BTCreateAccount.ForeColor = Color.FromArgb(105, 114, 120);
            penelHeader.BackColor = Color.FromArgb(236, 238, 240);
        }

        

        //background:   #38444c (56, 68, 76)
        //border:       #697278 (105, 114, 120)
        //text:         #f0f2f3 (240, 242, 243)
        //base:         #293238 (41, 50, 56)
        //accent:       #ec1a62 (236, 26, 98)




    }
}

