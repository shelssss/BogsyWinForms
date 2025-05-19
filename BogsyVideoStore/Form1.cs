using BogsyVideoStore.Helpers;
using BogsyVideoStore.Modals;

namespace BogsyVideoStore
{
    public partial class Form1 : Form
    {
        CustomerListForm CustomerListForm;
        VideosForm VideosForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = userNameTxt.Text.Trim();
            var password = passwordTxt.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(StringHelpers.emptyLoginFields);
                return;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Customer.FirstOrDefault(c => c.Username == username);

                if (user != null && PassHash.VerifyPassword(password, user.Password))
                {
                    if (user.Role == StringHelpers.adminRole)
                    {
                        var adminForm = new DashboardForm();
                        adminForm.Show();
                    }
                    else
                    {
                        var customerForm = new CustomerForm(user);
                        customerForm.Show();
                    }
                    this.Hide();
                }
                else
                {

                    MessageBox.Show(StringHelpers.invalidCrendetials);
                }
            }
        }

        private void passResetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var passwordReset = new ForgotPassword();
            passwordReset.ShowDialog();
        }
    }
}
