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
            MessageBox.Show("��������� ����� �� 1 �� 2000!","������ ����",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            int attempts = 1;
            Random r=new Random();
            while (true)
            {
                int v = r.Next() % 2000 + 1;
                DialogResult dialogResult=MessageBox.Show(String.Format("���� ����� {0}?",v), String.Format("������� {0}",attempts), MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    break;
                }
                attempts++;
            }
            MessageBox.Show(String.Format("���! � ������! ��� ������������ {0} �������.\n������� Start the game ����� ������ ��� ���.",attempts), String.Format("����� ����"), MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}