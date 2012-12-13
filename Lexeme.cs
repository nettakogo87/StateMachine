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
        private string _name;
        private int _countCharToReturn;
        private int _finalState;

        public string Name{ get; set; }
        public int CountCharToReturn{ get; set; }
        public int FinalState { get; set; }

        public Lexeme(string name, int countCharToReturn, int finalState)
        {
            this._name = name;
            this._countCharToReturn = countCharToReturn;
            this._finalState = finalState;
        }
    }
}
