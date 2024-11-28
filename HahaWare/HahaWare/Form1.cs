namespace HahaWare
{
    public partial class BunnyTech : Form
    {
        public BunnyTech()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1?.Clear();
        }

        private void KillRoblox_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
