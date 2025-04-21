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

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Admin Login
            if (username.ToLower() == "admin")
            {
                var adminForm = new DashboardForm();
                adminForm.Show();
                this.Hide(); 
                return;
            }

            // Customer Login
            using (var context = new AppDbContext())
            {
                var customer = context.Customer.FirstOrDefault(c => c.Username == username);

                if (customer != null)
                {
                    var customerForm = new CustomerForm(customer); 
                    customerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username not found.");
                }
            }
        }
    }
}
