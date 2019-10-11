using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Project
{
    class Gk
    {
        int difficulty;

        string[] easyquestions;
        string[] normalquestions;
        string[] hardquestions;

        string[] easyanswers;
        string[] normalanswers;
        string[] hardanswers;

        public Gk()
        {

            //EASY QUESTIONS    

            easyquestions = new string[5];
            easyquestions[0] = "Intelligence agency of UK?";
            easyquestions[1] = "Which country’s capital is Ottawa?";
            easyquestions[2] = "Which planet has the feeling that sun rises in the west?";
            easyquestions[3] = "Which country has the world’s one-fourth oil reserve?";
            easyquestions[4] = "The World Largest desert is ";


              //NORMAL QUESTIONS

        normalquestions = new string[5];
        normalquestions[0] = "The device used for measuring altitudes is ";
        normalquestions[1] = "Which is the Land of the Rising Sun?  ";
        normalquestions[2] = "The largest ocean in the world is ";
        normalquestions[3] = "Which of the following countries is NOT a member of SAARC?\n Maldives, Bhutan,Malaysia, Nepal";
        normalquestions[4] = "Pink city in India is ";

            
            //HARD QUESTIONS

        hardquestions = new string[5];
        hardquestions[0] = "Which of the following is capital of Georgia?";
        hardquestions[1] = "Which of these is the largest landlocked country in the world?\n Kazakhstan, Bolivia, Paraguay,Central African Republic";
        hardquestions[2] = "Which is the national animal of Pakistan?";
        hardquestions[3] = "How many times did squash player Jahangir Khan win World Open?";
        hardquestions[4] = "How many countries in Asia?";



        //EASY ANSWERS

        easyanswers = new string[5];
        easyanswers[0] = "MI5";
        easyanswers[1] = "Canada";
        easyanswers[2] = "Venus";
        easyanswers[3] = "Saudi Arabia";
        easyanswers[4] = "Sahara";

        //NORMAL ANSWERS

        normalanswers = new string[5];
        normalanswers[0] = "Altimeter";
        normalanswers[1] = "Japan";
        normalanswers[2] = "Pacific";
        normalanswers[3] = "Malaysia";
        normalanswers[4] = "Jaipur";

        //HARD ANSWERS

        hardanswers = new string[5];
        hardanswers[0] = "Tbilisi";
        hardanswers[1] = "Kazakhstan";
        hardanswers[2] = "Markhor";
        hardanswers[3] = "Eight";
        hardanswers[4] = "48";

        }

            public Gk(int diffi) {

            this.difficulty = diffi; 
           
        }



        public String Question(int diff, int rn)
        {

            if (diff == 1)
            {

                return easyquestions[rn];

            }
            else if (diff == 2)
            {


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
