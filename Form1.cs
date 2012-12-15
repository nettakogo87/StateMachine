using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StateMachine
{
    public partial class Form1 : Form
    {
        private List<ClassOfSymbol> _listClassOfSymbol;
        private List<Lexeme> _listLexeme;

        public Form1()
        {
            InitializeComponent();
            _listClassOfSymbol = new List<ClassOfSymbol>();
            _listLexeme = new List<Lexeme>();
        }

        private void buttonToLexem_Click(object sender, EventArgs e)
        {
            panelClassOfSymbol.Visible = false;
            panelLexem.Visible = true;
        }

        private void textBoxEnterNameOfClassSymbol_TextChanged(object sender, EventArgs e)
        {
            textBoxEnterInterval.Text = textBoxEnterNameOfClassSymbol.Text;
        }

        private void buttonCreateClassOfSymbol_Click(object sender, EventArgs e)
        {
            string nameClassOfSymbol = textBoxEnterNameOfClassSymbol.Text;
            string interval = textBoxEnterInterval.Text;
            textBoxEnterNameOfClassSymbol.Clear();
            textBoxEnterInterval.Clear();
            switch (interval)
            {
                case "\\":
                    interval = "\\" + interval;
                    break;
                case "^":
                    interval = "\\" + interval;
                    break;
                case "$":
                    interval = "\\" + interval;
                    break;
                case ".":
                    interval = "\\" + interval;
                    break;
                case "[":
                    interval = "\\" + interval;
                    break;
                case "]":
                    interval = "\\" + interval;
                    break;
                case "|":
                    interval = "\\" + interval;
                    break;
                case "(":
                    interval = "\\" + interval;
                    break;
                case ")":
                    interval = "\\" + interval;
                    break;
                case "?":
                    interval = "\\" + interval;
                    break;
                case "*":
                    interval = "\\" + interval;
                    break;
                case "+":
                    interval = "\\" + interval;
                    break;
                case "{":
                    interval = "\\" + interval;
                    break;
                case "}":
                    interval = "\\" + interval;
                    break;
                case "\"":
                    interval = "\\" + interval;
                    break;
                case "'":
                    interval = "\\" + interval;
                    break;
                case "%":
                    interval = "\\" + interval;
                    break;
            }
            ClassOfSymbol newClassOfSymbol = new ClassOfSymbol(nameClassOfSymbol, interval);
            _listClassOfSymbol.Add(newClassOfSymbol);
        }

        private void buttonToCreateClassOfSymbol_Click(object sender, EventArgs e)
        {
            this.panelLexem.Visible = false;
            this.panelClassOfSymbol.Visible = true;
        }

        private void buttonCreateLexem_Click(object sender, EventArgs e)
        {
            string nameLexeme = this.textBoxEnterLexemName.Text;
            int finalState = Convert.ToInt16(this.textBoxFinalState.Text);
            int countCharToReturn = Convert.ToInt16(this.textBoxCountCharToReturn.Text);
            Lexeme newLexeme = new Lexeme(nameLexeme, countCharToReturn, finalState);
            this._listLexeme.Add(newLexeme);
        }

        private void buttonToTableOfState_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
