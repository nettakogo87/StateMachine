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

        public int CurrentClassOfSymbol
        {
            get { return this._currentClassOfSymbol; }
        }
        public int CurrentState
        {
            get { return this._currentState; }
        }
        public int NewState
        {
            get { return this._newState; }
        }
        public string Buffer
        {
            get { return this._buffer; }
        }
        public string ReturnLastSymbol(int count)
        {
            return this._buffer.Remove(0, this._buffer.Count() - count);
            return this._buffer[this._buffer.Count() - count].ToString();
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
        public void Clear()
        {
            this._currentState = 0;
            this._currentClassOfSymbol = 0;
            this._newState = 0;
            this._buffer = "";
        }

        public void CreateNewState(string symbol)
        {
            this._currentClassOfSymbol = DefineIndexOfClassSymbol(symbol);
            this._currentState = this._newState;
            this._newState = this._states[this._currentClassOfSymbol, this._currentState];
            this._buffer += symbol;

        }
        
        public string ReturnLastLexeme(int count)
        {
            return this._buffer.Remove(this._buffer.Count() - count);
        }
        public bool CheckStop()
        {
            return this._newState < 0;
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
