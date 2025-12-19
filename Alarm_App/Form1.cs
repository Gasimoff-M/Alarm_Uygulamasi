namespace Alarm_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void combo()
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString("D2"));
            }

            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i.ToString("D2"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            combo();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();

            string suankiSaat = DateTime.Now.Hour.ToString();
            string SuankiDakika = DateTime.Now.Minute.ToString();
            

            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                if(comboBox1.SelectedItem.ToString() == suankiSaat && comboBox2.SelectedItem.ToString() == SuankiDakika)
                {
                    timer1.Stop();
                    MessageBox.Show("Saat Çalýyor");
                    
                }
                
            }
        }
    }
}
