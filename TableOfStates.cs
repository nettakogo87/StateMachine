using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Класс который по сути и представляет собой машину состояний. 
 */
namespace StateMachine
{
    public class TableOfStates
    {
        private int _countOfStates;                   // число состояний
        private ClassOfSymbol[] _massOfClassOfSymbol; // массив классов символов
        private int[,] _states;                       // массив сосотояний
        private int _currentState;                    // текущее сосотояние
        private int _currentClassOfSymbol;            // текущий класс символов
        private int _newState;                        // новое состояние
        private string _buffer;                       // буфер для накапливания литер лексемы

        public string Buffer
        {
            get { return this._buffer; }
        }

        public TableOfStates(int[,] states, ClassOfSymbol[] massOfClassOfSymbol)
        {
            this._states = states;
            this._massOfClassOfSymbol = massOfClassOfSymbol;
            this._countOfStates = states.Length;

            this._currentState = 0;
            this._currentClassOfSymbol = 0;
            this._newState = 0;
            this._buffer = "";
        }

        public void CreateNewState(string symbol)
        {
            int indexOfClassSymbol = DefineIndexOfClassSymbol(symbol);
            this._currentState = this._newState;
            this._newState = this._states[this._currentState, indexOfClassSymbol];
            this._buffer += symbol;
        }
        
        public string ReturnLastLexeme()
        {
            this._newState = 0;
            string lastLexem = this._buffer;
            this._buffer = "";
            return lastLexem;
        }
        public bool CheckStop()
        {
            return this._currentState <= 0;
        }

        private int DefineIndexOfClassSymbol(string symbol)
        {
            for (int i = 0; i < this._massOfClassOfSymbol.Length; i++)
            {
                if (this._massOfClassOfSymbol[i].ContainsSymbol(symbol))
                {
                    return i + 1;
                }
            }
            return 0; // "Остальные" символы будут в последнем столбце
        }
    }
}
