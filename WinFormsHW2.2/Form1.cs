namespace WinFormsHW2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char c;
        private void Zero_Click(object sender, EventArgs e)
        {

            Answer.Text = Answer.Text + "0";

        }

        private void One_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "1";
            }
            else
            {
                Answer.Text = Answer.Text + "1";
            }
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "2";
            }
            else
            {
                Answer.Text = Answer.Text + "2";
            }
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "3";
            }
            else
            {
                Answer.Text = Answer.Text + "3";
            }
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "4";
            }
            else
            {
                Answer.Text = Answer.Text + "4";
            }
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "5";
            }
            else
            {
                Answer.Text = Answer.Text + "5";
            }
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "6";
            }
            else
            {
                Answer.Text = Answer.Text + "6";
            }
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "7";
            }
            else
            {
                Answer.Text = Answer.Text + "7";
            }
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "8";
            }
            else
            {
                Answer.Text = Answer.Text + "8";
            }
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (Answer.Text == "0" && Answer.Text != null)
            {
                Answer.Text = "9";
            }
            else
            {
                Answer.Text = Answer.Text + "9";
            }
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