using Krypton;
using Krypton.Toolkit;

namespace AccountingSystemWinForms
{
    public partial class WelcomeForm : KryptonForm
    {
        //para ma access globally
        public static WelcomeForm welcomeForm;
        public WelcomeForm()
        {

            InitializeComponent();
            signUpControl.Hide();
            welcomeForm = this;
        }
        //enable window buffering  (para ma smooth ang pag render)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1344, 753); // set size again ( kay nay bug usahay )
            closeButton.Click += CloseButton_Click;
           
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
