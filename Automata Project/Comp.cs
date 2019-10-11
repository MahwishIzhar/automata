using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Project
{
    class Comp
    {

        int difficulty;

        string[] easyquestions;
        string[] normalquestions;
        string[] hardquestions;

        string[] easyanswers;
        string[] normalanswers;
        string[] hardanswers;

         public Comp()
        {

            //EASY QUESTIONS    

            easyquestions = new string[5];
            easyquestions[0] = "In internet terminology IP means";
            easyquestions[1] = "'Do no evil' is tag line of ___________";
            easyquestions[2] = "The common name for the crime of stealing passwords is _______";
            easyquestions[3] = "__________ is the process of dividing the disk into tracks and sectors.";
            easyquestions[4] = "What type of software creates a smaller file that is faster to transfer over the Internet?";


              //NORMAL QUESTIONS

        normalquestions = new string[5];
        normalquestions[0] = "Which  company is nicknamed Big Blue ?";
        normalquestions[1] = "Full form of jpeg is";
        normalquestions[2] = "A single packet on a data link is known as";
        normalquestions[3] = "The process of communicating with a file from a terminal is";
        normalquestions[4] = "The term referring to evacuating the content of some part of the machine is known as";

            
            //HARD QUESTIONS

        hardquestions = new string[5];
        hardquestions[0] = "Layer one of the OSI model is?";
        hardquestions[1] = "____________ is the process of sorting through large data sets to identify patterns and establish relationships to solve problems through data analysis? ";
        hardquestions[2] = ": ______ is a cyber attack intended to redirect a website’s traffic to another, fake site ";
        hardquestions[3] = "What type of monitoring file is commonly used on and accepted from Internet sites?";
        hardquestions[4] = "Communication channel is shared by all the machines on the network in:";



        //EASY ANSWERS

        easyanswers = new string[5];
        easyanswers[0] = "Internet Protocol";
        easyanswers[1] = "Google";
        easyanswers[2] = "Spoofing";
        easyanswers[3] = "Crashing";
        easyanswers[4] = "Compression";

        //NORMAL ANSWERS

        normalanswers = new string[5];
        normalanswers[0] = "IBM";
        normalanswers[1] = "Joint Photographic Experts Group";
        normalanswers[2] = "Frame";
        normalanswers[3] = "Interrogation";
        normalanswers[4] = "Dump";



        //HARD ANSWERS

        hardanswers = new string[5];
        hardanswers[0] = "Physical Layer";
        hardanswers[1] = "Data Mining";
        hardanswers[2] = "Pharming";
        hardanswers[3] = "Cookies";
        hardanswers[4] = "Broadcast network";
        }

                public Comp(int diffi) {

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
