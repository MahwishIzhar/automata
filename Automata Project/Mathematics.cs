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
    public partial class Mathematics : Form
    {
        int currentstate = 1;
        int category;
        int form = 1;
        int difficulty;

        public Mathematics()
        {
            InitializeComponent();
            Random rn = new Random();
            this.category = 1;
            this.difficulty = rn.Next(1,3);

        }

        private void Mathematics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)     //category
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

            else {

                MessageBox.Show("You have made any mistake.");
            }

        }

    /*    private void button3_Click(object sender, EventArgs e)    //BACK
        {

            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == 0)
            {

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();

            }

            else {

                MessageBox.Show("You have made a mistake.");
            }


        }
        */
        private void button5_Click(object sender, EventArgs e)  //DIFFICULTY 
        {
            DFA dfa = new DFA(currentstate);
            int request = 1;
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {
                //int category = 1;
                this.Hide();
                Difficulty d = new Difficulty(category);
                d.ShowDialog();

            }

            else {

                MessageBox.Show("You have made a mistake.");

            }


        }

        private void button2_Click(object sender, EventArgs e)    //Play
        {

            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {

                this.Hide();
                Play p = new Play(category,difficulty);
                p.ShowDialog();
            }

            else {
                MessageBox.Show("You have made a mistake.");
            
            }

        }

        private void button4_Click(object sender, EventArgs e)   //Exit 
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

        }

      
    }
}
