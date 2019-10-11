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
    public partial class Form1 : Form
    {

        //MAIN PAGE 

       int currentstate = 0;
       int form = 0;
       int category ;
       int difficulty;
       int score=0;


       public Form1(int scor)
        {
            InitializeComponent();
            Random rn = new Random();
            this.category = rn.Next(1, 4);
            this.difficulty = rn.Next(1,3);

            if (scor > this.score)
            {
                this.score = scor;
            }
        }

       public Form1()
       {
           InitializeComponent();
           Random rn = new Random();
           this.category = rn.Next(1, 4);
           this.difficulty = rn.Next(1, 3);

       }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)    //CATEGORY  for mathematics
        {
           // Form1 f1 = new Form1();  
            int request = 0;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 1)
            {
                this.Hide();
                Mathematics maths = new Mathematics();
                maths.ShowDialog();
               // Console.Read();
            }
            else {

                MessageBox.Show("You have a mistake in selection.");
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)    // CATEGORY for gk
        {
             int request = 0;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 1)
            {
                this.Hide();
                General_Knowledge gk = new General_Knowledge();
                gk.ShowDialog();

            }
            else
            {

                MessageBox.Show("You have a mistake in selection.");
            }


        }

        private void button2_Click(object sender, EventArgs e)    //CATEGORY for science
        {

            int request = 0;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 1)
            {
                this.Hide();
                Science scn = new Science();
                scn.ShowDialog();
            }
            else
            {

                MessageBox.Show("You have a mistake in selection.");
            }

}

        private void button4_Click(object sender, EventArgs e)   //CATEGORY for computer
        {
             int request = 0;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 1)
            {
                this.Hide();
                Computer comp = new Computer();
                comp.ShowDialog();
            }

            else
            {

                MessageBox.Show("You have a mistake in selection.");
            }
        }

        private void button8_Click(object sender, EventArgs e)   //Difficulty

        {
            int request = 1;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 2)
            {
                this.Hide();
                Difficulty d1 = new Difficulty();
                d1.ShowDialog();

            }

            else {

                MessageBox.Show("Error");
            }

        }

        private void button9_Click(object sender, EventArgs e)    //PLAY
        {

            int request = 2;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 3)
            {
                this.Hide();
                Play p1 = new Play(category,difficulty);
                p1.ShowDialog();

}

            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button7_Click(object sender, EventArgs e)    //EXIT 
        {
            int request = 3;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 4)
            {
                this.Hide();
                Exit ex = new Exit(form,category);
                ex.ShowDialog();

            }

            else
            {

                MessageBox.Show("You have made a mistake.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Highest score is: "+ this.score);


        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Select any category and difficulty level.Press the play button.");


        }

      /*  private void button11_Click(object sender, EventArgs e)    //BACK 
        {
            int request = 3;
            DFA dfa = new DFA(currentstate);
            int answer = dfa.transition(currentstate, request);

            if (answer == 0)
            {
                 this.Show();
            }

            else
            {

                MessageBox.Show("Error");
            }
        }

        */


    }
}
