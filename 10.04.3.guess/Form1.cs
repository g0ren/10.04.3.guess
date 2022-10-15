namespace _10._04._3.guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загадайте число от 1 до 2000!","Начало игры",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            int attempts = 1;
            Random r=new Random();
            while (true)
            {
                int v = r.Next() % 2000 + 1;
                DialogResult dialogResult=MessageBox.Show(String.Format("Ваше число {0}?",v), String.Format("Попытка {0}",attempts), MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    break;
                }
                attempts++;
            }
            MessageBox.Show(String.Format("Ура! Я угадал! Мне понадобилось {0} попыток.\nНажмите Start the game чтобы играть ещё раз.",attempts), String.Format("Конец игры"), MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}