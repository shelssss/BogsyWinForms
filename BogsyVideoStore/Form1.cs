using BogsyVideoStore.Helpers;

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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = userNameTxt.Text.Trim();
            var password = passwordTxt.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Customer.FirstOrDefault(c => c.Username == username);

                if (user != null && PassHash.VerifyPassword(password, user.Password))
                {
                    if (user.Role == "Admin")
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

                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
