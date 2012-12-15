using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс лексемы.
 */
namespace StateMachine
{
    public class Lexeme
    {
        public string Name { get; set; }

        public int CountCharToReturn { get; set; }

        public int FinalState { get; set; }

        public Lexeme(string name, int countCharToReturn, int finalState)
        {
            this.Name = name;
            this.CountCharToReturn = countCharToReturn;
            this.FinalState = finalState;
        }
    }
}
