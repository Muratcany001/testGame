namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private const int MatrixSize = 10;
        private const int CellSize = 100;
        private Random random;
        int counterValue = 0;
        private const int Spacing = 1;
        public List<string>? listNums {  get; set; } = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listNums = new List<string>();
            counterValue = 0;
        }
        private void FlowLayoutPanel1_Paint(object? sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Listenin oluþtuðu bölüm
            Random randomNum = new Random();
            int selectedDifficulty = Convert.ToInt32(Difficulty.SelectedItem);
            if (Difficulty.SelectedItem!=null)
            {

                //listNums.Clear();
                //List<string> listNums = new List<string>();
                for (int i = 0; i < selectedDifficulty; i++)
                {
                    int randomNumber = randomNum.Next(10, 100);
                    int ones = randomNumber % 10;
                    randomNumber -= ones;
                    randomNumber /= 10;
                    int tens = randomNumber;
                    string axis= $"{{X={ones},Y={tens}}}";
                    listNums.Add(axis);
                    
                }
                //
            }
            else
            {
                MessageBox.Show("Geçerli bir zorluk seçilmedi");
            }
            // butonlarýn oluþtuðu bölüm
            for (int i = 0; i < 10; i++)
            {
            
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.White;
                    button.Width = 100;
                    button.Height = 100;
                    button.Click += button_Click;
                    Controls.Add(button);
                    button.Tag = new Point(i, j);
                    button.Location = new Point(j * 100, i * 80);
                    if ((j + i) % 2 == 0)
                    {
                        button.BackColor = Color.Black;
                    }
                    else
                    {
                        button.BackColor = Color.White;
                        //$"{X={xCoordinate},Y={yCoordinate}}"
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e) // buton numarasýnýn alýndýðý bölüm
        {
            Button clickedButton = sender as Button;

            //Buton seçim bölümü doðru ve yanlýþ olanlarýn renklendirilmesi 
            //////////////////// Listenin karþýlaþtýrýlacaðý bölüm///////////////////////////
            
            
            if (clickedButton != null)
            {
                string tagValue = Convert.ToString(clickedButton.Tag);
                //string tagString = tagValue.ToString();
                if (listNums.Contains(tagValue))
                {
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();

                }
                else
                {
                    clickedButton.BackColor = Color.Green;
                    counterValue += 1;
                }


            }
            else
            {
                MessageBox.Show("Geçersiz iþlem");
            }
            // if (counterValue == )
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
        private void Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
