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
        private string _name;
        private char _startSymbol;
        private char _endSymbol;

        public string Name { get;set; }
        public char StartSymbol { get; set; }
        public char EndSymbol { get; set; }

        public bool ContainsSymbol(string symbol)
        {
            string ss = _startSymbol.ToString();
            string es = _endSymbol.ToString();
            string pattern = ss == es ? @ss : @"[" + ss + "-" + es + "]";
            RegexOptions option = RegexOptions.IgnoreCase;
            Regex newReg = new Regex(pattern, option);
            MatchCollection matches = newReg.Matches(symbol);
            return matches.Count > 0;
        }
    }
}
