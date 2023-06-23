using AppointmentScheduler;
using AppointmentScheduler.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Resources;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedulerLoginForm
{
    public partial class SchedulerLoginForm : Form
    {
        public SchedulerLoginForm()
        {
            InitializeComponent();
        }

        ResourceManager rm;
        CultureInfo culture;
        StreamWriter sw;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;
            string timestampFormat = culture.DateTimeFormat.SortableDateTimePattern;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                switch (CultureInfo.CurrentUICulture.ToString())
                {
                    case "en-US":
                        MessageBox.Show("You must enter a username and password to continue", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "fr-CA":
                        MessageBox.Show("Vous devez entrer un nom d'utilisateur et un mot de passe pour continuer", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "es-ES":
                        MessageBox.Show("Debe ingresar un nombre de usuario y contraseña para continuar", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        MessageBox.Show("An unknown error occurred", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;
                }
            }
            else
            {
                try
                {

                    DbConn conn = new DbConn();
                    if (conn.AuthenticateUser(username, password))
                    {
                        if (File.Exists("../login.log"))
                        {
                            var fileStream = new FileStream("../login.log", FileMode.Append, FileAccess.Write);
                            using (sw = new StreamWriter(fileStream))
                            {
                                sw.WriteLine($"{DateTime.Now.ToString(timestampFormat)}   The user, {username}, has logged in successfully");
                            }
                        }
                        else
                        {
                            var fileStream = new FileStream("../login.log", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                            using (sw = new StreamWriter(fileStream))
                            {
                                sw.WriteLine($"{DateTime.Now.ToString(timestampFormat)}   The user, {username}, has logged in successfully");
                            }
                        }

                        // Fix this!
                        // this.loginStatusLabel.Visible = true;
                        // Thread.Sleep(500);


                        this.Hide();
                        LandingForm landingForm = new LandingForm();
                        landingForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        switch (CultureInfo.CurrentUICulture.ToString())
                        {
                            case "en-US":
                                MessageBox.Show("The username and/or password is incorrect.", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case "fr-CA":
                                MessageBox.Show("Le nom d'utilisateur et/ou le mot de passe sont incorrects.", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case "es-ES":
                                MessageBox.Show("El nombre de usuario y/o la contraseña son incorrectos.", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show("An unknown error occurred", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                break;
                        }
                    }
                }
                catch (InvalidCredentialException ex)
                {
                    MessageBox.Show(ex.ToString(), "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void schedulerLoginForm_Load(object sender, EventArgs e)
        {
            rm = new ResourceManager("AppointmentScheduler.Resources.Res", typeof(SchedulerLoginForm).Assembly);
            culture = CultureInfo.CurrentUICulture;
            usernameLabel.Text = rm.GetString("usernameLabel", culture);
            passwordLabel.Text = rm.GetString("passwordLabel", culture);
            loginButton.Text = rm.GetString("loginButton", culture);

        }
    }
}
