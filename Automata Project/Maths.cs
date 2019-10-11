using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Project
{
    class Maths
    {
        int difficulty;
        

        string[] easyquestions;
        string[] normalquestions;
        string[] hardquestions;


        string[] easyanswers;
        string[] normalanswers;
        string[] hardanswers;
 
        public Play pl;

        public Maths() { 

            //EASY QUESTIONS    

        easyquestions= new string[5];
        easyquestions[0] = "15% of 750 is";
        easyquestions[1] = "What is the next number in the sequence: 3, 7, 15, 31, 63, ...?";
        easyquestions[2] = "How many sides does a quadrilateral have?";
        easyquestions[3] = "Which one of the following numbers is a prime number: 12, 15, 17, 21, 27?";
        easyquestions[4] = "-(2-5/4)/9";

            //NORMAL QUESTIONS

        normalquestions = new string[5];
        normalquestions[0] = "Find the incorrect number in the following series: 4, 9, 16, 24, 36, 49, 64, 81, 100";
        normalquestions[1] = "What is the next number in the following sequence: 2, 4, 8, 20, 40, 80, 200, 400, ***";
        normalquestions[2] = "If 8 ∙ 2x = 5(y+8), then when y = -8, x = ";
        normalquestions[3] = "A rectangle has a long side of 17cm and a short side that is 4 times smaller. What is the perimeter of the rectangle?";
        normalquestions[4] = "How many diagonals has an octagon?";

            //HARD QUESTIONS

        hardquestions = new string[5];
        hardquestions[0] = "A school committee consists of 2 teachers and 4 students. The number of different committees that can be formed from 5 teachers and 10 students is ";
        hardquestions[1] = "What MOCCCLXXXVIII stands for?";
        hardquestions[2] = "The number of ways in which four letters of the word ‘MATHEMATICS’ can be arranged is given by?";
        hardquestions[3] = "The probability that a leap year selected at random contains 53 Sundays is?";
        hardquestions[4] = "A code consists of six letters of the alphabet followed by a digit chosen from 0 to 9.The first and sixth letters must be vowels.The remaining four letters must be consonants.Repeats are not allowed.\n How many possible codes are there?";


            //EASY ANSWERS

            easyanswers = new string[5];
            easyanswers[0] = "112.5";
            easyanswers[1] = "127";
            easyanswers[2] = "4";
            easyanswers[3] = "17";
            easyanswers[4] = "-1/12";

            //NORMAL ANSWERS

            normalanswers = new string[5];
            normalanswers[0] = "24";
            normalanswers[1] = "800";
            normalanswers[2] = "0";
            normalanswers[3] = "42.5";
            normalanswers[4] = "20";

            //HARD ANSWERS

            hardanswers = new string[5];
            hardanswers[0] = "2100";
            hardanswers[1] = "1888";
            hardanswers[2] = "2454";
            hardanswers[3] = "2/7";
            hardanswers[4] = "28728000";


} 
        


        public Maths(int diffi) {

            this.difficulty = diffi;
           
        }


        public String Question(int diff, int rn) {

            if (diff == 1) {

                return easyquestions[rn]; 
            
            }
            else if (diff == 2) {


                return normalquestions[rn];
            }

            else if (diff == 3)
            {
                return hardquestions[rn];

            }

            return ("");

        }


        public String Answer(int diff, int rn)
        {

            if (diff == 1)
            {

                return easyanswers[rn];

            }
            else if (diff == 2)
            {


                return normalanswers[rn];
            }

            else if (diff == 3)
            {
                return hardanswers[rn];

            }

            return ("");

        }




    }
}
