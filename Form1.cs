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
        private List<Lexeme> _listOfLexemes;
        private TableOfStates _myMachine;

        public Form1()
        {
            InitializeComponent();
            _listClassOfSymbol = new List<ClassOfSymbol>();
            _listOfLexemes = new List<Lexeme>();
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
            panelLexem.Visible = false;
            panelClassOfSymbol.Visible = true;
        }

        private void buttonCreateLexem_Click(object sender, EventArgs e)
        {
            string nameLexeme = textBoxEnterLexemName.Text;
            int finalState = Convert.ToInt16(textBoxFinalState.Text);
            int countCharToReturn = Convert.ToInt16(textBoxCountCharToReturn.Text);
            Lexeme newLexeme = new Lexeme(nameLexeme, countCharToReturn, finalState);
            textBoxEnterLexemName.Clear();
            textBoxFinalState.Clear();
            textBoxCountCharToReturn.Clear();
            this._listOfLexemes.Add(newLexeme);
        }

        private void buttonToTableOfState_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this._listClassOfSymbol.Count; i++ )
            {
                dataGridViewTableOfState.Columns.Add(this._listClassOfSymbol[i].Name, this._listClassOfSymbol[i].Name);
                dataGridViewTableOfState.Columns[i + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridViewTableOfState.Rows.Add();
            dataGridViewTableOfState.Rows[0].HeaderCell.Value = "S0";

            for (int i = 0; i < this._listOfLexemes.Count; i++)
            {
                dataGridViewLexemes.Rows.Add(this._listOfLexemes[i].Name, this._listOfLexemes[i].CountCharToReturn, this._listOfLexemes[i].FinalState);
                dataGridViewLexemes.Rows[i].HeaderCell.Value = i.ToString();
            }

            panelClassOfSymbol.Visible = false;
            panelLexem.Visible = false;
            panelTableOfState.Visible = true;
        }

        private void buttonAddState_Click(object sender, EventArgs e)
        {
            dataGridViewTableOfState.Rows.Add();
            int newRowIndex = dataGridViewTableOfState.Rows.Count - 1;
            dataGridViewTableOfState.Rows[newRowIndex].HeaderCell.Value = "S" + newRowIndex.ToString();
        }

        private void buttonDeleteState_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridViewTableOfState.Rows.Count - 1;
            if (0 < lastRowIndex)
            {
                dataGridViewTableOfState.Rows.Remove(dataGridViewTableOfState.Rows[lastRowIndex]);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}
