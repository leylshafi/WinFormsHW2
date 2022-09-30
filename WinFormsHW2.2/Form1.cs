namespace WinFormsHW2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char c;
        private void btnN_Click(object sender, EventArgs e)
        {
            if (!((sender as Button)?.Text == "." && Answer.Text.Length == 0))
                Answer.Text += (sender as Button)?.Text;
            else
                Answer.Text += "0.";
        }

        

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case '+':
                    Answer.Text =(int.Parse(Answer.Text)+int.Parse(fullAnswer.Text)).ToString();
                    break;
                case '-':
                    int s = (int.Parse(Answer.Text) - int.Parse(fullAnswer.Text));
                    s *= -1;
                    Answer.Text = s.ToString();
                    break;
                case 'x':
                    Answer.Text = (int.Parse(Answer.Text) * int.Parse(fullAnswer.Text)).ToString();
                    break;
                case '/':
                    if (int.Parse(Answer.Text) == 0)
                    {
                        MessageBox.Show("Divide by zero error", "Error");
                        return;
                    }
                    Answer.Text = (int.Parse(fullAnswer.Text) / int.Parse(Answer.Text)).ToString();
                    break;
                default:
                    break;
            }
        }



        private void Add_Click(object sender, EventArgs e)
        {
            fullAnswer.Text=Answer.Text;
            c = '+';
            Answer.Text = null;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Answer.Text = null;
            fullAnswer.Text = null;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            fullAnswer.Text = Answer.Text;
            c = '-';
            Answer.Text = null;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            fullAnswer.Text = Answer.Text;
            c = 'x';
            Answer.Text = null;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            fullAnswer.Text = Answer.Text;
            c = '/';
            Answer.Text = null;
        }
    }
}