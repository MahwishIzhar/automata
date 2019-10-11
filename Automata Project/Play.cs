using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Automata_Project
{
    public partial class Play : Form
    {
        int currentstate = 3;
        int form = 3;
        int category;
        int difficulty;
        int i = 0;
        int score =0;

       
         string answer;
         string result;

        public Play() {

            InitializeComponent();
           
            Random rn = new Random();
            this.category = rn.Next(1, 4);
            this.difficulty = rn.Next(1, 3);
            choice();

        }

        public Play (int cate, int diffi)
        {

            InitializeComponent();
           
            this.category = cate;
            this.difficulty = diffi;
            choice();
          
        }

        public void choice()
        {

            if ((category == 1 && difficulty == 1) || (category == 1 && difficulty == 2) || (category == 1 && difficulty == 3))
            {

    /*   Random ran = new Random();
                int i = ran.Next(0, 4);        */

                if (i < 5)
                {
                    Maths m = new Maths();
                    richTextBox1.Font = new Font("Consolas", 13f, FontStyle.Regular);
                    richTextBox1.AppendText(m.Question(difficulty, i));
                    result = m.Answer(difficulty, i);
                   
  }

                 else
                {

                    MessageBox.Show("Game end");
                    DialogResult dr = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Form1 f = new Form1(score);
                        i = 0;
                        choice();

                    }

                    else
                    {

                        this.Hide();
                        Form1 f = new Form1(score);
                        f.ShowDialog();
                    }

                }

            }

            

            if ((category == 2 && difficulty == 1) || (category == 2 && difficulty == 2) || (category == 2 && difficulty == 3))
            {

              /*  Random ran = new Random();
                int i = ran.Next(0, 4);    */

                if (i < 5)
                {
                    Gk gk = new Gk();
                    richTextBox1.Font = new Font("Consolas", 13f, FontStyle.Regular);
                    richTextBox1.AppendText(gk.Question(difficulty, i));
                    result = gk.Answer(difficulty, i);
                }

                else
                {

                    MessageBox.Show("Game end");
                    DialogResult dr = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Form1 f = new Form1(score);
                        i = 0;
                        choice();

                    }

                    else
                    {

                        this.Hide();
                        Form1 f = new Form1(score);
                        f.ShowDialog();
                    }

                }


            }

            if ((category == 3 && difficulty == 1) || (category == 3 && difficulty == 2) || (category == 3 && difficulty == 3))
            {
                /*  Random ran = new Random();
                  int i = ran.Next(0, 4);     */

                if (i < 5)
                {
                    Sci sc = new Sci();
                    richTextBox1.Font = new Font("Consolas", 13f, FontStyle.Regular);
                    richTextBox1.AppendText(sc.Question(difficulty, i));
                    result = sc.Answer(difficulty, i);
                }

                else
                {

                    MessageBox.Show("Game end");
                    DialogResult dr = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Form1 f = new Form1(score);
                        i = 0;
                        choice();

                    }

                    else
                    {

                        this.Hide();
                        Form1 f = new Form1(score);
                        f.ShowDialog();
                    }
                }

            }

            if ((category == 4 && difficulty == 1) || (category == 4 && difficulty == 2) || (category == 4 && difficulty == 3))
            {
                /*        Random ran = new Random();
                        int i = ran.Next(0, 4);     */

                if (i < 5)
                {
                    Comp com = new Comp();
                    richTextBox1.Font = new Font("Consolas", 13f, FontStyle.Regular);
                    richTextBox1.AppendText(com.Question(difficulty, i));
                    result = com.Answer(difficulty, i);
                }

                else
                {

                    MessageBox.Show("Game end");
                    DialogResult dr = MessageBox.Show("Do you want to restart the game?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        Form1 f = new Form1(score);
                        i = 0;
                        choice();

                    }

                    else
                    {

                        this.Hide();
                        Form1 f = new Form1(score);
                        f.ShowDialog();
                    }

                }

            }



        }


        private void button1_Click(object sender, EventArgs e)   //CATEGORY 
        {
            DFA dfa = new DFA(currentstate);
            int request = 0;
            int answer = dfa.transition(currentstate, request);

            if (answer == 0)
            {

                this.Hide();
                Form1 f = new Form1(score);
                f.ShowDialog();

            }

            else
            {
                    MessageBox.Show("You have made any mistake.");
            }

        }

        private void button2_Click(object sender, EventArgs e)   //DIFFICULTY 
        {

            DFA dfa = new DFA(currentstate);
            int request = 1;
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {

                this.Hide();
                Difficulty f = new Difficulty(category);
                f.ShowDialog();

            }

            else
            {
                MessageBox.Show("You have made any mistake.");
            }
        }

        private void button3_Click(object sender, EventArgs e)   //PLAY 
        {

            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                this.Hide();
                Play f = new Play(category, difficulty);
                f.ShowDialog();
            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }
            
        }

      /*  private void button5_Click(object sender, EventArgs e)   //BACK 
        {
            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {
                if (formno == 2)
                {
                    this.Hide();
                    Difficulty f = new Difficulty();
                    f.ShowDialog();

                }

                if (formno == 0)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }

                if (formno == 1)
                {
                    if (category == 1)
                    {
                        this.Hide();
                        Mathematics f = new Mathematics();
                        f.ShowDialog();
                    }

                    if (category == 2) {

                        this.Hide();
                        General_Knowledge gk = new General_Knowledge();
                        gk.ShowDialog();
                    }

                    if (category == 3) {
                        this.Hide();
                        Science sc = new Science();
                        sc.ShowDialog();
                    
                    }

                    if (category == 4) {
                        this.Hide();
                        Computer cm = new Computer();
                        cm.ShowDialog();
                    
                    }

                }
            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }
        }*/

        private void button4_Click(object sender, EventArgs e)    //EXIT 
        {
            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == dfa.getfs())
            {
                this.Hide();
                Exit ex = new Exit(form,category);
                ex.ShowDialog();
            }

            else
            {
                MessageBox.Show("You have made any mistake.");
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)    //SUBMIT
        {
            
            answer = textBox2.Text;
 

            if (answer.Contains(result))
            {

                score = score + 10;
                textBox1.Clear();
                textBox1.Text = ""+score;
                //MessageBox.Show("Right answer");
                richTextBox1.Clear();
                textBox2.Clear();
                i++;
                choice();
            }

            else {
                MessageBox.Show("Wrong answer");
                textBox2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
