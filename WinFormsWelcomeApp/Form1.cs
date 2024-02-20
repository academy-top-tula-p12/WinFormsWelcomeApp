namespace WinFormsWelcomeApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            AuthForm authForm = new AuthForm(this);
            authForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm(this);
            serviceForm.Show();
        }
    }
}
