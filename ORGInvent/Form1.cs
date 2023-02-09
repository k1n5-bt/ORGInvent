using System;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ORGInvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LockControlValues(Control control)
        {
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).ReadOnly = true;
                    if (ctrl.GetType() == typeof(ComboBox))
                        ((ComboBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(Button))
                        ((Button)ctrl).Enabled = false;
                    if (ctrl.GetType() == typeof(DateTimePicker))
                        ((DateTimePicker)ctrl).Enabled = false;
                    if (ctrl.Controls.Count > 0)
                        LockControlValues(ctrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var errorMsg = "Логин или пароль заданы неправильно";
            using (var db = new Data.MyDbContext())
            {
                var users = db.Users.Where(p => p.Login == loginBox.Text);
                if (users.Count() == 0) {
                    MessageBox.Show(errorMsg);
                    return;
                }
                var user = users.First();
                var data = Encoding.ASCII.GetBytes("secret" + passwordBox.Text);
                data = MD5.Create().ComputeHash(data);
                var hash = Convert.ToBase64String(data);
                if (user.Password != hash) {
                    MessageBox.Show(errorMsg);
                    return;
                }
                var form = new Form2();
                if (!user.IsAdmin)
                    LockControlValues(form);
                form.Text += "<Режим только для чтения>";
                form.Show();
                this.Hide();
            }
        }
    }
}
