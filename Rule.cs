using System;
using System.Collections.Generic;
using System.Text;

namespace TurningNPDAtoCFG
{
    public class Rule
    {
        public bool HaveFirstState;
        public bool HaveFinalState;
        public string FromState;
        public string ToState;
        public string FirstInput;
        public string SecondInput;
        public string Output;
        public Rule(string str)
        {
            string[] strArr = str.Split(',');
            if (strArr[0][0] == '-')
            {
                HaveFirstState = true;
                FromState = strArr[0].Substring(2);
            }
            else
            {
                HaveFirstState = false;
                FromState = strArr[0];
            }
            FirstInput = strArr[1];
            SecondInput = strArr[2];
            Output = strArr[3];
            if (strArr[4][0] == '*')
            {
                HaveFinalState = true;
                ToState = strArr[4].Substring(1);
            }
            else
            {
                HaveFinalState = false;
                ToState = strArr[4];
            }

        }
        public string RuternGrammer(LinkedList<String> States)
        {
            if (this.Output == "_")
            {
                return "(" + this.FromState + this.SecondInput + this.ToState + ")" + "->" + this.FirstInput;
            }
            string returnStr = "";
            foreach (var x in States)
            {
                string str = "";
                foreach (var y in States)
                {
                    str += "(" + this.FromState + this.SecondInput + x + ")" + "->" + this.FirstInput + "(" + this.ToState + this.Output[0] + y + ")" + "(" + y + this.Output[1] + x + ")";
                    str += "|";
                }
                str = str.Substring(0, str.Length - 1);
                returnStr += str + "\n";
            }
            returnStr = returnStr.Substring(0, returnStr.Length - 1);
            return returnStr;
        }
    }
}
