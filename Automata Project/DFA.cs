using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata_Project
{
    class DFA
    {
       
        int initialstate;
        int finalstate;
        int states;
        int[,] transitiontable; 
        int currentstate;

        public DFA(int currst) {

            this.initialstate = 0;
            this.finalstate = 4;
            this.states = 5;
            this.currentstate = currst ;
            this.transitiontable = new int[,] { {1,2,3,4},{0,2,3,4},{0,2,3,4},{0,2,3,4},{0,2,3,4}}  ;

        }

        public int getfs() {

            return this.finalstate;
        
        }

        public int transition(int currstate, int rqust) {

            int answer=0;

            answer = transitiontable[currstate,rqust];

            return answer;
        }

    
    }
}
