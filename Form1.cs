namespace randomnumber
{
    public partial class Form1 : Form
    {
        int num;
        int cehd = 0;
        public Form1()
        {
            InitializeComponent();

            axtarilanEdedTxt.Enabled = false;
            yoxlaBtn.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yenioyunBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 100);

            cehd = 0;

            axtarilanEdedTxt.Clear();
            neticeTxt.Clear();
            errorProvider.Clear();

            axtarilanEdedTxt.Enabled = true;
            yoxlaBtn.Enabled = true;

        }

        private void yoxlaBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(axtarilanEdedTxt.Text))
            {
                errorProvider.SetError(axtarilanEdedTxt, "Ədəd daxil edin!");
                return;
            }

            int daxilEdilen;

            if (!int.TryParse(axtarilanEdedTxt.Text, out daxilEdilen))
            {
                errorProvider.SetError(axtarilanEdedTxt, "Yalnız ədəd daxil edin!");
                return;
            }

            if (daxilEdilen < 0 || daxilEdilen > 100)
            {
                errorProvider.SetError(axtarilanEdedTxt, "0-100 arasında ədəd daxil edin!");
                return;
            }

            errorProvider.Clear();

            cehd++;


            if (daxilEdilen < num)
            {
                neticeTxt.AppendText("Daxil edilən ədəd yanlışdır\r\n");
                neticeTxt.AppendText("Təsadüfi ədəddən kiçikdir\r\n");
                neticeTxt.AppendText("Cəhd sayı: " + cehd + "\r\n\r\n");
            }
            else if (daxilEdilen > num)
            {
                neticeTxt.AppendText("Daxil edilən ədəd yanlışdır\r\n");
                neticeTxt.AppendText("Təsadüfi ədəddən böyükdür\r\n");
                neticeTxt.AppendText("Cəhd sayı: " + cehd + "\r\n\r\n");
            }
            else
            {
                neticeTxt.AppendText("Oyunu qazandınız\r\n");
                neticeTxt.AppendText("Cəhd sayı: " + cehd + "\r\n");

                axtarilanEdedTxt.Enabled = false;
                yoxlaBtn.Enabled = false;
            }
        }
    }
}
