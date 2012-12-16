using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            char[] charsForLex = textBoxForLex.Text.ToCharArray();
            char currenSymbol = charsForLex[0];
            this._myMachine.CreateNewState(currenSymbol.ToString());
            textBoxCurrentLexeme.Text = this._myMachine.Buffer;
            if (this._myMachine.CheckStop())
            {
                textBoxLastLexeme.Text = this._myMachine.ReturnLastLexeme();
            }
            if ((ClassOfSymbol.STOP_SYMBOL == currenSymbol) && (1 == charsForLex.Count()))
            {
                textBoxForLex.Text = "";
                buttonStep.Enabled = false;
            }
            else
            {
                string lastTextForLex = "";
                if (1 < charsForLex.Count())
                {
                    for (int i = 1; i < charsForLex.Count(); i++)
                    {
                        lastTextForLex += charsForLex[i].ToString();
                    }
                }
                else
                {
                    lastTextForLex = ClassOfSymbol.STOP_SYMBOL.ToString();
                }
                textBoxForLex.Text = lastTextForLex;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int[,] states = new int[dataGridViewTableOfState.Columns.Count,dataGridViewTableOfState.Rows.Count];
            for (int i = 0; i < dataGridViewTableOfState.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewTableOfState.Columns.Count; j++)
                {
                    states[j, i] = Convert.ToInt32(dataGridViewTableOfState[j, i].Value);
                }
            }
            Lexeme[] lexemes = new Lexeme[dataGridViewLexemes.Rows.Count];
            for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
            {
                string name           = Convert.ToString(dataGridViewLexemes[0, i].Value);
                int countCharToReturn = Convert.ToInt32(dataGridViewLexemes[1, i].Value);
                int finalState        = Convert.ToInt32(dataGridViewLexemes[2, i].Value);
                lexemes[i] = new Lexeme(name, countCharToReturn, finalState);
            }

            this._myMachine = new TableOfStates(states, this._listClassOfSymbol.ToArray());
            
            buttonAddState.Enabled = false;
            buttonDeleteState.Enabled = false;
            buttonStart.Enabled = false;
            buttonAddLexemeInState.Enabled = false;
            buttonDeletSelectedLexemeInState.Enabled = false;

            buttonStep.Enabled = true;

            dataGridViewLexemes.ReadOnly = true;
            dataGridViewTableOfState.ReadOnly = true;
            groupBoxControlPanel.Enabled = true;

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.WriteLine("Class of symbols");
                foreach (ClassOfSymbol classOfSymbol in this._listClassOfSymbol)
                {
                    sw.WriteLine(classOfSymbol.Name + " " + classOfSymbol.Interval);
                }
                sw.WriteLine("State Machine");
                for (int i = 0; i < dataGridViewTableOfState.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewTableOfState.Columns.Count; j++)
                    {
                        sw.Write(dataGridViewTableOfState[j, i].Value.ToString() + " ");
                    }
                    sw.Write(sw.NewLine);
                }
                sw.WriteLine("Lexemes");
                for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
                {
                    string name = Convert.ToString(dataGridViewLexemes[0, i].Value);
                    string countCharToReturn = Convert.ToString(dataGridViewLexemes[1, i].Value);
                    string finalState = Convert.ToString(dataGridViewLexemes[2, i].Value);
                    sw.WriteLine(name + " " + countCharToReturn + " " + finalState);
                }
                sw.Close();
            }
        }
    }
}
