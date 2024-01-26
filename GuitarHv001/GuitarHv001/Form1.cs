namespace GuitarHv001
{
    public partial class Form1 : Form
    {
        int coleta, cont = 0;
        public Form1()
        {

            InitializeComponent();
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            coleta = e.KeyValue;
            label1.Text = Convert.ToString(e.KeyValue);

            switch (coleta)
            {
                case 65:
                    picGreen.BackColor = Color.DarkGreen;
                    break;

                case 83:
                    picRed.BackColor = Color.DarkRed;
                    break;

                case 74:
                    picYellow.BackColor = Color.DarkGoldenrod;
                    break;
                case 75:
                    picBlue.BackColor = Color.DarkBlue;
                    break;
                case 76:
                    picOrange.BackColor = Color.DarkOrange;
                    break;
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    picGreen.BackColor = Color.LimeGreen;
                    break;

                case Keys.S:
                    picRed.BackColor = Color.Red;
                    break;

                case Keys.J:
                    picYellow.BackColor = Color.Yellow;
                    break;

                case Keys.K:
                    picBlue.BackColor = Color.DodgerBlue;
                    break;
                case Keys.L:
                    picOrange.BackColor = Color.OrangeRed;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int speed = 9;

            picPeca01.Top += speed;
            picPeca02.Top += speed;
            picPeca03.Top += speed;
            picPeca04.Top += speed;
            picPeca05.Top += speed;

            if (picPeca01.Location.Y > 385)
            {
                picPeca01.Location = new Point(211,0);
            }
            else if (picPeca02.Location.Y > 385)
            {
                picPeca02.Location = new Point(279, 73);
            }
            else if (picPeca03.Location.Y > 385)
            {
                picPeca03.Location = new Point(347, 184);
            }
            else if (picPeca04.Location.Y > 385)
            {
                picPeca04.Location = new Point(415, 32);
            }
            else if (picPeca05.Location.Y > 385)
            {
                picPeca05.Location = new Point(483, 143);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}