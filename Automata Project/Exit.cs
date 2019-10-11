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
    public partial class Exit : Form
    {
        int currentstate = 4;
        int formno;
        int category;
        
        public Exit()
        {
            InitializeComponent();
        }

        public Exit(int form, int cat)
        {
            InitializeComponent();
            this.formno = form;
            this.category = cat;
        }

        

        private void button1_Click(object sender, EventArgs e)  //YES 
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)   //NO 
        {

            if (this.formno == 0) {

                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else if (this.formno == 1){
                if (this.category == 1) {

                    this.Hide();
                    Mathematics m = new Mathematics();
                    m.ShowDialog();
                }
                if (this.category == 2) {
                    this.Hide();
                    General_Knowledge gk = new General_Knowledge();
                    gk.ShowDialog();
                }
                if (this.category == 3) {
                    this.Hide();
                    Science sc = new Science();
                    sc.ShowDialog();
                }
                if (this.category == 4) {
                    this.Hide();
                    Computer comp = new Computer();
                    comp.ShowDialog();
                }
            
            }

            else if (this.formno == 3) {

                this.Hide();
                Play p = new Play();
                p.ShowDialog();
            }
            else if (this.formno == 2) {

                this.Hide();
                Difficulty d = new Difficulty();
                d.ShowDialog();
            }
           
  }

       /* private void button7_Click(object sender, EventArgs e)   //back 
        {
            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == 4)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
            }

            else
            {

                MessageBox.Show("You have made a mistake.");
            }

        }
        */
        private void button3_Click(object sender, EventArgs e)    //category 
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

        private void button4_Click(object sender, EventArgs e)    //difficulty
        {
            DFA dfa = new DFA(currentstate);
            int request = 1;
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {

                this.Hide();
                Difficulty d = new Difficulty();
                d.ShowDialog();

            }

            else
            {

                MessageBox.Show("You have made a mistake.");

            }
        }

        private void button6_Click(object sender, EventArgs e)    //play 
        {
            DFA dfa = new DFA(currentstate);
            int request = 2;
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                this.Hide();
                Play p = new Play();
                p.ShowDialog();
            }

            else
            {
                MessageBox.Show("You have made a mistake.");

            }

        }

        private void button8_Click(object sender, EventArgs e)   //Exit 
        {
            DFA dfa = new DFA(currentstate);
            int request = 3;
            int answer = dfa.transition(currentstate, request);

            if (answer == dfa.getfs())
            {
               this.Show();

            } 
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

    }
}
