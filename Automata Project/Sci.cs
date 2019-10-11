using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Project
{
    class Sci
    {
        int difficulty;

        string[] easyquestions;
        string[] normalquestions;
        string[] hardquestions;

        string[] easyanswers;
        string[] normalanswers;
        string[] hardanswers;

        public Sci() { 
        
         //EASY QUESTIONS    

        easyquestions= new string[5];
        easyquestions[0] = ": There are _____ number of muscles in human.";
        easyquestions[1] = "Celsius and Fahrenheit show the same temperature at";
        easyquestions[2] = "The device used for detecting even feeble current is called";
        easyquestions[3] = "Which is the most abundant gas in the earth's atmosphere?";
        easyquestions[4] = "What is marsh gas?";

            //NORMAL QUESTIONS

        normalquestions = new string[5];
        normalquestions[0] = "Which is the largest human cell?";
        normalquestions[1] = "The chief ore of Aluminium is ?";
        normalquestions[2] = "Which of the following is called as the brown coal?\n  Peat, Lignite,Bituminous,Anthracite";
        normalquestions[3] = "Which one of the following is the richest source of vitamin C?\n  Guava ,Pineapple, Orange  ,Tomato";
        normalquestions[4] = "Which of the following is the spectacular contribution of Scientist Pascal in Physics?\n Photo, Volta, Computer, Calculator";

             //HARD QUESTIONS

        hardquestions = new string[5];
        hardquestions[0] = "Name the process in which the membrane of a vesicle can fuse with the plasma membrane and extrude its contents to the surrounding medium?";
        hardquestions[1] = "In what way iodine can be separated from a mixture of potassium chloride and iodine?";
        hardquestions[2] = "What is Boron?";
        hardquestions[3] = "In the process of electrolysis oxidation occurs at:";
        hardquestions[4] = "Name the process in which the passage of water goes from a region of higher concentration to a region of lower concentration through a semi permeable membrane?";



        //EASY ANSWERS

        easyanswers = new string[5];
        easyanswers[0] = "639";
        easyanswers[1] = "40";
        easyanswers[2] = "Galvanoscope";
        easyanswers[3] = "Nitrogen";
        easyanswers[4] = "Methane";

        //NORMAL ANSWERS

        normalanswers = new string[5];
        normalanswers[0] = "Ovum";
        normalanswers[1] = "Bauxite";
        normalanswers[2] = "Lignite";
        normalanswers[3] = "Orange";
        normalanswers[4] = "Calculator";

        //HARD ANSWERS

        hardanswers = new string[5];
        hardanswers[0] = "Exocytosis";
        hardanswers[1] = "Sublimation";
        hardanswers[2] = "Metalloid";
        hardanswers[3] = "Anode";
        hardanswers[4] = "Osmosis";
    }



        public String Question(int diff,int rn)
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
