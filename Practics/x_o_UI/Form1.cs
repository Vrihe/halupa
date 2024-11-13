namespace x_o_UI
{
    public partial class Form1 : Form
    {
        private logic m_logic = new logic();
        private int player = 1;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Текущий ход: X";
           
        }
        public void mm_SetterAllButtons(string setter)
        {
            foreach (Control i in this.Controls)
            {
                if(i is Button)
                    i.Text = setter;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //short index = Convert.ToInt16(sender.GetType().GetProperty("Tag").GetValue(sender));
            //if (m_logic.mm_StepPlayer(m_logic.m_p1, index ))
            //{
            //}
            // m_logic.mm_StepPlayer("name",ref Buttons[index] );
            // Buttons[index].Text = "chmo";
            //sender.GetType().GetProperty("Text").SetValue(sender, "huy");
            m_logic.mm_StepPlayer(m_logic.m_p1, sender);
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            if (m_logic.mm_CheckWin(m_logic.m_p1))   {
                m_logic.m_x_Win_Count++;
                label1.Text = m_logic.m_x_Win_Count.ToString();
                MessageBox.Show( "winner: " + m_logic.m_p1); 
                foreach (Control i in this.Controls)
                {
                    if (i is Button)
                    {
                        i.Enabled = true;
                        i.Text = "";
                    }
                }
            }
            
            
        }
    }
}
