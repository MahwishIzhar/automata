using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata_Project
{
    public partial class Difficulty : Form
    {
        int currentstate = 2;
        int form = 2;
        int category;
        int difficulty;
       
       

        public Difficulty(int cate)
        {
            InitializeComponent();
            this.category = cate;
        }

        public Difficulty()
        {
            InitializeComponent();
            Random rn = new Random();
             this.category = rn.Next(1,4);
             this.difficulty = rn.Next(1, 3);
        }


        private void button3_Click(object sender, EventArgs e)   //CATEGORY
        {

            DFA dfa = new DFA(currentstate);
            int request = 0;
            int answer = dfa.transition(currentstate, request);

            if (answer == 0)
            {

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();

            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }

        }

        private void button4_Click(object sender, EventArgs e)    //DIFFICULTY
        {
            DFA dfa = new DFA(currentstate);
            int request = 1;
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {
                this.Hide();
                Difficulty d = new Difficulty(category);
                d.ShowDialog();

            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }
        }

        private void button6_Click(object sender, EventArgs e)   //PLAY 
        {

            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
               this.Hide();
                Play  f = new Play(category,difficulty);
                f.ShowDialog();
          }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }
        }

       /* private void button7_Click(object sender, EventArgs e)    //BACK 
        {
            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == 1)
            {
                if (category == 1)
                {
                    this.Hide();
                    Mathematics m = new Mathematics();
                    m.ShowDialog();
                }

                else if (category == 2) {

                    this.Hide();
                    General_Knowledge g = new General_Knowledge();
                    g.ShowDialog();
                
                }

                else if (category == 3) {


                    this.Hide();
                    Science s = new Science();
                    s.ShowDialog();
                
                }

                else if (category == 4) {

                    this.Hide();
                    Computer c = new Computer();
                    c.ShowDialog();
                
                }
    }

          if (category == 0 && forno == 0)
            {

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();


            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }

        }
        */

        private void button8_Click(object sender, EventArgs e)    //EXIT 
        {

            DFA dfa = new DFA(currentstate);

            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == dfa.getfs())
            {
                this.Hide();
                Exit ex = new Exit(form ,category);
                ex.ShowDialog();

            } 

        }

        private void button1_Click(object sender, EventArgs e)   //EASY 
        {
            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                this.Hide();
                Play p = new Play(category,1);
                p.ShowDialog();
            
            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }

        }

        private void button5_Click(object sender, EventArgs e)  //NORMAL 
        {

            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                
                this.Hide();
                Play p = new Play(category,2);
                p.ShowDialog();

            }

            else
            {

                MessageBox.Show("You have made any mistake.");
            }
        }

        private void button2_Click(object sender, EventArgs e)   //HARD 
        {
            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                this.Hide();
                Play p = new Play(category,3);
                p.ShowDialog();

            }
            else
            {

                MessageBox.Show("You have made any mistake.");
            }
        }

        private void Difficulty_Load(object sender, EventArgs e)
        {

        }
    }
}
