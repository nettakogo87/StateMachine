using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/**
 * Класс класса символов. Нужен!
 * Экземпляр может проверить пренадлежность символа классу.
 */
namespace StateMachine
{
    public class ClassOfSymbol
    {
        private string _interval;

        public string Name { get; set; }

        public ClassOfSymbol(string name, string interval)
        {
            this.Name = name;
            this._interval = interval;
        }

        public bool ContainsSymbol(string symbol)
        {
            string pattern = @"[" + this._interval + "]";
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex newReg = new Regex(pattern, option);
            MatchCollection matches = newReg.Matches(symbol);
            return matches.Count > 0;
        }
    }
}
