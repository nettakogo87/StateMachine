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
        private string _originalString = "";

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
            CreateColumnViewTableOfStatel();
            dataGridViewTableOfState.Rows.Add();
            dataGridViewTableOfState.Rows[0].HeaderCell.Value = "S0";
            FillViewLexemes();

            panelClassOfSymbol.Visible = false;
            panelLexem.Visible = false;
            panelTableOfState.Visible = true;
        }

        private void FillViewLexemes()
        {
            for (int i = 0; i < this._listOfLexemes.Count; i++)
            {
                dataGridViewLexemes.Rows.Add(this._listOfLexemes[i].Name, this._listOfLexemes[i].CountCharToReturn,
                                             this._listOfLexemes[i].FinalState);
                dataGridViewLexemes.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        /* нужен для создания столбцов в таблице машины состояний */
        private void CreateColumnViewTableOfStatel() 
        {
            for (int i = 0; i < this._listClassOfSymbol.Count; i++)
            {
                dataGridViewTableOfState.Columns.Add(this._listClassOfSymbol[i].Name, this._listClassOfSymbol[i].Name);
                dataGridViewTableOfState.Columns[i + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            if ("" == this._originalString) /* для возврата к введенной строке в случае чего */
            {
                this._originalString = textBoxForLex.Text;
            }

            if (this._myMachine.CheckStop())
            {
                int countCharForReturn = 0;
                for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
                {
                    if (this._myMachine.NewState == Convert.ToInt32(dataGridViewLexemes[2, i].Value))
                    {
                        dataGridViewLexemes[0, i].Style.BackColor = Color.Red;
                        countCharForReturn = Convert.ToInt32(dataGridViewLexemes[1, i].Value);
                    }
                }

                string lastSymbolForReturn = this._myMachine.ReturnLastSymbol(countCharForReturn);
                textBoxForLex.Text = lastSymbolForReturn + textBoxForLex.Text;
                textBoxLastLexeme.Text = this._myMachine.ReturnLastLexeme(countCharForReturn);

                for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
                {
                    if (dataGridViewLexemes[0, i].Value.ToString() == textBoxLastLexeme.Text && this._myMachine.NewState == Convert.ToInt32(dataGridViewLexemes[2, i].Value))
                    {
                        dataGridViewLexemes[0, i].Style.BackColor = Color.Teal;
                    }
                }

                textBoxCurrentLexeme.Clear();

                this._myMachine.Clear();
                ClearViewTableOfState();
            }
            else
            {
                ClearViewLexemes();

                string stringForLexicalAnalyzer = textBoxForLex.Text;
                string currenSymbol =" ";
                if (ClassOfSymbol.STOP_SYMBOL == textBoxForLex.Text)
                {
                    textBoxForLex.Clear();
                    textBoxCurrentLexeme.Clear();

                    ChangeViewTableOfState(currenSymbol);

                    buttonStep.Enabled = false;
                }
                if (0 < stringForLexicalAnalyzer.Length)
                {
                    currenSymbol = stringForLexicalAnalyzer.First().ToString();
                    stringForLexicalAnalyzer = stringForLexicalAnalyzer.Remove(0, 1);
                    textBoxForLex.Text = stringForLexicalAnalyzer;

                    ChangeViewTableOfState(currenSymbol);

                    textBoxCurrentLexeme.Text = this._myMachine.Buffer;
                }
                else
                {
                    textBoxForLex.Text = ClassOfSymbol.STOP_SYMBOL;
                    textBoxCurrentLexeme.Clear();

                    ChangeViewTableOfState(currenSymbol);
                }
                
            }
        }

        private void ClearViewLexemes()
        {
            for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
            {
                dataGridViewLexemes[0, i].Style.BackColor = Color.White;
            }
        }

        private void ClearViewTableOfState()
        {
            for (int i = 0; i < dataGridViewTableOfState.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewTableOfState.Columns.Count; j++)
                {
                    dataGridViewTableOfState[j, i].Style.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void ChangeViewTableOfState(string currenSymbol)
        {
            dataGridViewTableOfState[_myMachine.CurrentClassOfSymbol, _myMachine.CurrentState].Style.BackColor =
                Color.White;

            this._myMachine.CreateNewState(currenSymbol);

            dataGridViewTableOfState[_myMachine.CurrentClassOfSymbol, _myMachine.CurrentState].Style.BackColor =
                Color.Red;
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
                sw.WriteLine("Class of symbols: " + this._listClassOfSymbol.Count.ToString());
                foreach (ClassOfSymbol classOfSymbol in this._listClassOfSymbol)
                {
                    sw.WriteLine(classOfSymbol.Name + " " + classOfSymbol.Interval);
                }
                sw.WriteLine("Lexemes: " + dataGridViewLexemes.Rows.Count.ToString());
                for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
                {
                    string name = Convert.ToString(dataGridViewLexemes[0, i].Value);
                    string countCharToReturn = Convert.ToString(dataGridViewLexemes[1, i].Value);
                    string finalState = Convert.ToString(dataGridViewLexemes[2, i].Value);
                    sw.WriteLine(name + " " + countCharToReturn + " " + finalState);
                }
                sw.WriteLine("Count states of Machine: " + dataGridViewTableOfState.Rows.Count.ToString());
                for (int i = 0; i < dataGridViewTableOfState.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewTableOfState.Columns.Count; j++)
                    {
                        sw.Write(dataGridViewTableOfState[j, i].Value.ToString() + " ");
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this._listClassOfSymbol.Clear();
                    this._listOfLexemes.Clear();
                    for (int i = dataGridViewTableOfState.Columns.Count; i > 1; i--)
                    {
                        dataGridViewTableOfState.Columns.Clear();
                    }
                    dataGridViewLexemes.Rows.Clear();

                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    int countClassOfSymbols = Convert.ToInt32(sr.ReadLine().Split(new char[] {':'})[1]);
                    for (int i = 0; i < countClassOfSymbols; i++)
                    {
                        string[] blankClassOfSymbol = sr.ReadLine().Trim().Split(new char[] {' '});
                        ClassOfSymbol newClassOfSymbol = new ClassOfSymbol(blankClassOfSymbol[0], blankClassOfSymbol[1]);
                        this._listClassOfSymbol.Add(newClassOfSymbol);
                    }
                    int countLexemes = Convert.ToInt32(sr.ReadLine().Split(new char[] {':'})[1]);
                    for (int i = 0; i < countLexemes; i++)
                    {
                        string[] blankLexeme = sr.ReadLine().Trim().Split(new char[] {' '});
                        string name = blankLexeme[0];
                        int countCharToReturn = Convert.ToInt32(blankLexeme[1]);
                        int finalState = Convert.ToInt32(blankLexeme[2]);
                        Lexeme newLexeme = new Lexeme(name, countCharToReturn, finalState);
                        this._listOfLexemes.Add(newLexeme);
                    }
                    FillViewLexemes();

                    CreateColumnViewTableOfStatel();
                    int countStatesOfMachine = Convert.ToInt32(sr.ReadLine().Split(new char[] {':'})[1]);
                    for (int i = 0; i < countStatesOfMachine; i++)
                    {
                        dataGridViewTableOfState.Rows.Add();
                        dataGridViewTableOfState.Rows[i].HeaderCell.Value = "S" + i.ToString();
                        string[] massRow = sr.ReadLine().Trim().Split(new char[] {' '});
                        for (int j = 0; j < massRow.Length; j++)
                        {
                            dataGridViewTableOfState[j, i].Value = Convert.ToInt32(massRow[j]);
                        }
                    }
                    sr.Close();

                    panelClassOfSymbol.Visible = false;
                    panelLexem.Visible = false;
                    panelTableOfState.Visible = true;
                }
                catch (Exception ex)
                {
                    const string caption = "Ошибка в выражении!";
                    var result = MessageBox.Show(ex.Message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Question);
                }
            }
        }

        private void buttonToStart_Click(object sender, EventArgs e)
        {
            this._myMachine.Clear();
            ClearViewTableOfState();
            textBoxForLex.Text = this._originalString;
            textBoxLastLexeme.Text = "";
            textBoxCurrentLexeme.Text = "";
            buttonStep.Enabled = true;
        }

        private void buttonClearSteps_Click(object sender, EventArgs e)
        {
            this._myMachine.Clear();
            ClearViewTableOfState();
            this._originalString = "";
            textBoxForLex.Text = "";
            textBoxLastLexeme.Text = "";
            textBoxCurrentLexeme.Text = "";
            buttonStep.Enabled = true;
        }

        private void buttonChangeMachineOfState_Click(object sender, EventArgs e)
        {
            this._myMachine.Clear();
            this._originalString = "";
            textBoxForLex.Text = "";
            textBoxLastLexeme.Text = "";
            textBoxCurrentLexeme.Text = "";

            buttonAddState.Enabled = true;
            buttonDeleteState.Enabled = true;
            buttonStart.Enabled = true;
            buttonAddLexemeInState.Enabled = true;
            buttonDeletSelectedLexemeInState.Enabled = true;

            buttonStep.Enabled = false;

            dataGridViewLexemes.ReadOnly = false;
            dataGridViewTableOfState.ReadOnly = false;
            groupBoxControlPanel.Enabled = false;
        }

        private void buttonAddLexemeInState_Click(object sender, EventArgs e)
        {
            dataGridViewLexemes.Rows.Add();
        }

        private void buttonDeletSelectedLexemeInState_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewLexemes.Rows.Count; i++)
            {
                if (dataGridViewLexemes.Rows[i].Selected)
                {
                    dataGridViewLexemes.Rows.RemoveAt(i);
                }
            }
        }
    }
}
