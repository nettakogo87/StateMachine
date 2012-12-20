namespace StateMachine
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCreateClassOfSymbol = new System.Windows.Forms.GroupBox();
            this.buttonToLexem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelClassOfSymbol = new System.Windows.Forms.Panel();
            this.buttonCreateClassOfSymbol = new System.Windows.Forms.Button();
            this.labelTitleClassOfSymbol = new System.Windows.Forms.Label();
            this.textBoxEnterInterval = new System.Windows.Forms.TextBox();
            this.labelEnterInterval = new System.Windows.Forms.Label();
            this.labelEnterNameOfClassOfSymbol = new System.Windows.Forms.Label();
            this.textBoxEnterNameOfClassSymbol = new System.Windows.Forms.TextBox();
            this.panelLexem = new System.Windows.Forms.Panel();
            this.groupBoxCreateLexem = new System.Windows.Forms.GroupBox();
            this.textBoxCountCharToReturn = new System.Windows.Forms.TextBox();
            this.textBoxFinalState = new System.Windows.Forms.TextBox();
            this.labelCountCharToReturn = new System.Windows.Forms.Label();
            this.labelFinalState = new System.Windows.Forms.Label();
            this.buttonToCreateClassOfSymbol = new System.Windows.Forms.Button();
            this.buttonToTableOfState = new System.Windows.Forms.Button();
            this.buttonCreateLexem = new System.Windows.Forms.Button();
            this.textBoxEnterLexemName = new System.Windows.Forms.TextBox();
            this.labelEnterLexemName = new System.Windows.Forms.Label();
            this.labelCreateLexem = new System.Windows.Forms.Label();
            this.panelTableOfState = new System.Windows.Forms.Panel();
            this.labelStepThree = new System.Windows.Forms.Label();
            this.groupBoxControlPanel = new System.Windows.Forms.GroupBox();
            this.buttonChangeMachineOfState = new System.Windows.Forms.Button();
            this.buttonToStart = new System.Windows.Forms.Button();
            this.buttonClearSteps = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.labelTextForLexicalAnalysis = new System.Windows.Forms.Label();
            this.labelCurrentLexeme = new System.Windows.Forms.Label();
            this.labelLastLexeme = new System.Windows.Forms.Label();
            this.textBoxForLex = new System.Windows.Forms.TextBox();
            this.textBoxCurrentLexeme = new System.Windows.Forms.TextBox();
            this.textBoxLastLexeme = new System.Windows.Forms.TextBox();
            this.groupBoxLexemes = new System.Windows.Forms.GroupBox();
            this.buttonDeletSelectedLexemeInState = new System.Windows.Forms.Button();
            this.buttonAddLexemeInState = new System.Windows.Forms.Button();
            this.dataGridViewLexemes = new System.Windows.Forms.DataGridView();
            this.LexemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountCharToReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTableOfState = new System.Windows.Forms.GroupBox();
            this.dataGridViewTableOfState = new System.Windows.Forms.DataGridView();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddState = new System.Windows.Forms.Button();
            this.buttonDeleteState = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxCreateClassOfSymbol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelClassOfSymbol.SuspendLayout();
            this.panelLexem.SuspendLayout();
            this.groupBoxCreateLexem.SuspendLayout();
            this.panelTableOfState.SuspendLayout();
            this.groupBoxControlPanel.SuspendLayout();
            this.groupBoxLexemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemes)).BeginInit();
            this.groupBoxTableOfState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOfState)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCreateClassOfSymbol
            // 
            this.groupBoxCreateClassOfSymbol.Controls.Add(this.buttonToLexem);
            this.groupBoxCreateClassOfSymbol.Location = new System.Drawing.Point(11, 34);
            this.groupBoxCreateClassOfSymbol.Name = "groupBoxCreateClassOfSymbol";
            this.groupBoxCreateClassOfSymbol.Size = new System.Drawing.Size(302, 337);
            this.groupBoxCreateClassOfSymbol.TabIndex = 0;
            this.groupBoxCreateClassOfSymbol.TabStop = false;
            // 
            // buttonToLexem
            // 
            this.buttonToLexem.Location = new System.Drawing.Point(211, 297);
            this.buttonToLexem.Name = "buttonToLexem";
            this.buttonToLexem.Size = new System.Drawing.Size(75, 23);
            this.buttonToLexem.TabIndex = 8;
            this.buttonToLexem.Text = "Далее >>";
            this.buttonToLexem.UseVisualStyleBackColor = true;
            this.buttonToLexem.Click += new System.EventHandler(this.buttonToLexem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panelClassOfSymbol
            // 
            this.panelClassOfSymbol.Controls.Add(this.buttonCreateClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.labelTitleClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.textBoxEnterInterval);
            this.panelClassOfSymbol.Controls.Add(this.labelEnterInterval);
            this.panelClassOfSymbol.Controls.Add(this.labelEnterNameOfClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.textBoxEnterNameOfClassSymbol);
            this.panelClassOfSymbol.Controls.Add(this.groupBoxCreateClassOfSymbol);
            this.panelClassOfSymbol.Location = new System.Drawing.Point(81, 28);
            this.panelClassOfSymbol.Name = "panelClassOfSymbol";
            this.panelClassOfSymbol.Size = new System.Drawing.Size(318, 393);
            this.panelClassOfSymbol.TabIndex = 2;
            // 
            // buttonCreateClassOfSymbol
            // 
            this.buttonCreateClassOfSymbol.Location = new System.Drawing.Point(88, 250);
            this.buttonCreateClassOfSymbol.Name = "buttonCreateClassOfSymbol";
            this.buttonCreateClassOfSymbol.Size = new System.Drawing.Size(140, 23);
            this.buttonCreateClassOfSymbol.TabIndex = 7;
            this.buttonCreateClassOfSymbol.Text = "Создать клас символов";
            this.buttonCreateClassOfSymbol.UseVisualStyleBackColor = true;
            this.buttonCreateClassOfSymbol.Click += new System.EventHandler(this.buttonCreateClassOfSymbol_Click);
            // 
            // labelTitleClassOfSymbol
            // 
            this.labelTitleClassOfSymbol.AutoSize = true;
            this.labelTitleClassOfSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleClassOfSymbol.Location = new System.Drawing.Point(7, 7);
            this.labelTitleClassOfSymbol.Name = "labelTitleClassOfSymbol";
            this.labelTitleClassOfSymbol.Size = new System.Drawing.Size(306, 24);
            this.labelTitleClassOfSymbol.TabIndex = 4;
            this.labelTitleClassOfSymbol.Text = "Шаг 1. Добавте классы символов";
            // 
            // textBoxEnterInterval
            // 
            this.textBoxEnterInterval.Location = new System.Drawing.Point(64, 133);
            this.textBoxEnterInterval.Name = "textBoxEnterInterval";
            this.textBoxEnterInterval.Size = new System.Drawing.Size(194, 20);
            this.textBoxEnterInterval.TabIndex = 3;
            // 
            // labelEnterInterval
            // 
            this.labelEnterInterval.AutoSize = true;
            this.labelEnterInterval.Location = new System.Drawing.Point(61, 117);
            this.labelEnterInterval.Name = "labelEnterInterval";
            this.labelEnterInterval.Size = new System.Drawing.Size(102, 13);
            this.labelEnterInterval.TabIndex = 2;
            this.labelEnterInterval.Text = "Введите интервал:";
            // 
            // labelEnterNameOfClassOfSymbol
            // 
            this.labelEnterNameOfClassOfSymbol.AutoSize = true;
            this.labelEnterNameOfClassOfSymbol.Location = new System.Drawing.Point(61, 55);
            this.labelEnterNameOfClassOfSymbol.Name = "labelEnterNameOfClassOfSymbol";
            this.labelEnterNameOfClassOfSymbol.Size = new System.Drawing.Size(200, 13);
            this.labelEnterNameOfClassOfSymbol.TabIndex = 1;
            this.labelEnterNameOfClassOfSymbol.Text = "Введите класс имя класса символов:";
            // 
            // textBoxEnterNameOfClassSymbol
            // 
            this.textBoxEnterNameOfClassSymbol.Location = new System.Drawing.Point(64, 71);
            this.textBoxEnterNameOfClassSymbol.Name = "textBoxEnterNameOfClassSymbol";
            this.textBoxEnterNameOfClassSymbol.Size = new System.Drawing.Size(194, 20);
            this.textBoxEnterNameOfClassSymbol.TabIndex = 0;
            this.textBoxEnterNameOfClassSymbol.TextChanged += new System.EventHandler(this.textBoxEnterNameOfClassSymbol_TextChanged);
            // 
            // panelLexem
            // 
            this.panelLexem.Controls.Add(this.groupBoxCreateLexem);
            this.panelLexem.Controls.Add(this.labelCreateLexem);
            this.panelLexem.Location = new System.Drawing.Point(404, 28);
            this.panelLexem.Name = "panelLexem";
            this.panelLexem.Size = new System.Drawing.Size(310, 393);
            this.panelLexem.TabIndex = 3;
            this.panelLexem.Visible = false;
            // 
            // groupBoxCreateLexem
            // 
            this.groupBoxCreateLexem.Controls.Add(this.textBoxCountCharToReturn);
            this.groupBoxCreateLexem.Controls.Add(this.textBoxFinalState);
            this.groupBoxCreateLexem.Controls.Add(this.labelCountCharToReturn);
            this.groupBoxCreateLexem.Controls.Add(this.labelFinalState);
            this.groupBoxCreateLexem.Controls.Add(this.buttonToCreateClassOfSymbol);
            this.groupBoxCreateLexem.Controls.Add(this.buttonToTableOfState);
            this.groupBoxCreateLexem.Controls.Add(this.buttonCreateLexem);
            this.groupBoxCreateLexem.Controls.Add(this.textBoxEnterLexemName);
            this.groupBoxCreateLexem.Controls.Add(this.labelEnterLexemName);
            this.groupBoxCreateLexem.Location = new System.Drawing.Point(5, 34);
            this.groupBoxCreateLexem.Name = "groupBoxCreateLexem";
            this.groupBoxCreateLexem.Size = new System.Drawing.Size(301, 337);
            this.groupBoxCreateLexem.TabIndex = 1;
            this.groupBoxCreateLexem.TabStop = false;
            // 
            // textBoxCountCharToReturn
            // 
            this.textBoxCountCharToReturn.Location = new System.Drawing.Point(44, 167);
            this.textBoxCountCharToReturn.Name = "textBoxCountCharToReturn";
            this.textBoxCountCharToReturn.Size = new System.Drawing.Size(222, 20);
            this.textBoxCountCharToReturn.TabIndex = 8;
            // 
            // textBoxFinalState
            // 
            this.textBoxFinalState.Location = new System.Drawing.Point(44, 99);
            this.textBoxFinalState.Name = "textBoxFinalState";
            this.textBoxFinalState.Size = new System.Drawing.Size(222, 20);
            this.textBoxFinalState.TabIndex = 7;
            // 
            // labelCountCharToReturn
            // 
            this.labelCountCharToReturn.AutoSize = true;
            this.labelCountCharToReturn.Location = new System.Drawing.Point(41, 151);
            this.labelCountCharToReturn.Name = "labelCountCharToReturn";
            this.labelCountCharToReturn.Size = new System.Drawing.Size(247, 13);
            this.labelCountCharToReturn.TabIndex = 6;
            this.labelCountCharToReturn.Text = "Введите количество возвращаемых символов:";
            // 
            // labelFinalState
            // 
            this.labelFinalState.AutoSize = true;
            this.labelFinalState.Location = new System.Drawing.Point(41, 83);
            this.labelFinalState.Name = "labelFinalState";
            this.labelFinalState.Size = new System.Drawing.Size(198, 13);
            this.labelFinalState.TabIndex = 5;
            this.labelFinalState.Text = "Введите номер конечного состояния:";
            // 
            // buttonToCreateClassOfSymbol
            // 
            this.buttonToCreateClassOfSymbol.Location = new System.Drawing.Point(19, 297);
            this.buttonToCreateClassOfSymbol.Name = "buttonToCreateClassOfSymbol";
            this.buttonToCreateClassOfSymbol.Size = new System.Drawing.Size(75, 23);
            this.buttonToCreateClassOfSymbol.TabIndex = 4;
            this.buttonToCreateClassOfSymbol.Text = "<< Назад";
            this.buttonToCreateClassOfSymbol.UseVisualStyleBackColor = true;
            this.buttonToCreateClassOfSymbol.Click += new System.EventHandler(this.buttonToCreateClassOfSymbol_Click);
            // 
            // buttonToTableOfState
            // 
            this.buttonToTableOfState.Location = new System.Drawing.Point(207, 297);
            this.buttonToTableOfState.Name = "buttonToTableOfState";
            this.buttonToTableOfState.Size = new System.Drawing.Size(75, 23);
            this.buttonToTableOfState.TabIndex = 3;
            this.buttonToTableOfState.Text = "Далее >>";
            this.buttonToTableOfState.UseVisualStyleBackColor = true;
            this.buttonToTableOfState.Click += new System.EventHandler(this.buttonToTableOfState_Click);
            // 
            // buttonCreateLexem
            // 
            this.buttonCreateLexem.Location = new System.Drawing.Point(98, 216);
            this.buttonCreateLexem.Name = "buttonCreateLexem";
            this.buttonCreateLexem.Size = new System.Drawing.Size(112, 23);
            this.buttonCreateLexem.TabIndex = 2;
            this.buttonCreateLexem.Text = "Создать лексему";
            this.buttonCreateLexem.UseVisualStyleBackColor = true;
            this.buttonCreateLexem.Click += new System.EventHandler(this.buttonCreateLexem_Click);
            // 
            // textBoxEnterLexemName
            // 
            this.textBoxEnterLexemName.Location = new System.Drawing.Point(44, 37);
            this.textBoxEnterLexemName.Name = "textBoxEnterLexemName";
            this.textBoxEnterLexemName.Size = new System.Drawing.Size(222, 20);
            this.textBoxEnterLexemName.TabIndex = 1;
            // 
            // labelEnterLexemName
            // 
            this.labelEnterLexemName.AutoSize = true;
            this.labelEnterLexemName.Location = new System.Drawing.Point(41, 21);
            this.labelEnterLexemName.Name = "labelEnterLexemName";
            this.labelEnterLexemName.Size = new System.Drawing.Size(124, 13);
            this.labelEnterLexemName.TabIndex = 0;
            this.labelEnterLexemName.Text = "Введите имя лексемы:";
            // 
            // labelCreateLexem
            // 
            this.labelCreateLexem.AutoSize = true;
            this.labelCreateLexem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreateLexem.Location = new System.Drawing.Point(30, 7);
            this.labelCreateLexem.Name = "labelCreateLexem";
            this.labelCreateLexem.Size = new System.Drawing.Size(241, 24);
            this.labelCreateLexem.TabIndex = 0;
            this.labelCreateLexem.Text = "Шаг 2. Добавте лексеммы";
            // 
            // panelTableOfState
            // 
            this.panelTableOfState.Controls.Add(this.labelStepThree);
            this.panelTableOfState.Controls.Add(this.groupBoxControlPanel);
            this.panelTableOfState.Controls.Add(this.groupBoxLexemes);
            this.panelTableOfState.Controls.Add(this.groupBoxTableOfState);
            this.panelTableOfState.Location = new System.Drawing.Point(12, 28);
            this.panelTableOfState.Name = "panelTableOfState";
            this.panelTableOfState.Size = new System.Drawing.Size(1000, 524);
            this.panelTableOfState.TabIndex = 4;
            this.panelTableOfState.Visible = false;
            // 
            // labelStepThree
            // 
            this.labelStepThree.AutoSize = true;
            this.labelStepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStepThree.Location = new System.Drawing.Point(10, 11);
            this.labelStepThree.Name = "labelStepThree";
            this.labelStepThree.Size = new System.Drawing.Size(794, 24);
            this.labelStepThree.TabIndex = 5;
            this.labelStepThree.Text = "Шаг 3. После заполнения \"Машины состояний\" нужно нажать \"Готово к употреблению\"";
            // 
            // groupBoxControlPanel
            // 
            this.groupBoxControlPanel.Controls.Add(this.buttonChangeMachineOfState);
            this.groupBoxControlPanel.Controls.Add(this.buttonToStart);
            this.groupBoxControlPanel.Controls.Add(this.buttonClearSteps);
            this.groupBoxControlPanel.Controls.Add(this.buttonStep);
            this.groupBoxControlPanel.Controls.Add(this.labelTextForLexicalAnalysis);
            this.groupBoxControlPanel.Controls.Add(this.labelCurrentLexeme);
            this.groupBoxControlPanel.Controls.Add(this.labelLastLexeme);
            this.groupBoxControlPanel.Controls.Add(this.textBoxForLex);
            this.groupBoxControlPanel.Controls.Add(this.textBoxCurrentLexeme);
            this.groupBoxControlPanel.Controls.Add(this.textBoxLastLexeme);
            this.groupBoxControlPanel.Enabled = false;
            this.groupBoxControlPanel.Location = new System.Drawing.Point(3, 395);
            this.groupBoxControlPanel.Name = "groupBoxControlPanel";
            this.groupBoxControlPanel.Size = new System.Drawing.Size(984, 120);
            this.groupBoxControlPanel.TabIndex = 3;
            this.groupBoxControlPanel.TabStop = false;
            this.groupBoxControlPanel.Text = "Панель управления и меню Пуск!";
            // 
            // buttonChangeMachineOfState
            // 
            this.buttonChangeMachineOfState.Location = new System.Drawing.Point(763, 68);
            this.buttonChangeMachineOfState.Name = "buttonChangeMachineOfState";
            this.buttonChangeMachineOfState.Size = new System.Drawing.Size(129, 40);
            this.buttonChangeMachineOfState.TabIndex = 9;
            this.buttonChangeMachineOfState.Text = "Редактировать машину состояний";
            this.buttonChangeMachineOfState.UseVisualStyleBackColor = true;
            this.buttonChangeMachineOfState.Click += new System.EventHandler(this.buttonChangeMachineOfState_Click);
            // 
            // buttonToStart
            // 
            this.buttonToStart.Location = new System.Drawing.Point(628, 19);
            this.buttonToStart.Name = "buttonToStart";
            this.buttonToStart.Size = new System.Drawing.Size(128, 40);
            this.buttonToStart.TabIndex = 8;
            this.buttonToStart.Text = "В исодное состояние";
            this.buttonToStart.UseVisualStyleBackColor = true;
            this.buttonToStart.Click += new System.EventHandler(this.buttonToStart_Click);
            // 
            // buttonClearSteps
            // 
            this.buttonClearSteps.Location = new System.Drawing.Point(763, 19);
            this.buttonClearSteps.Name = "buttonClearSteps";
            this.buttonClearSteps.Size = new System.Drawing.Size(129, 40);
            this.buttonClearSteps.TabIndex = 7;
            this.buttonClearSteps.Text = "Сброс";
            this.buttonClearSteps.UseVisualStyleBackColor = true;
            this.buttonClearSteps.Click += new System.EventHandler(this.buttonClearSteps_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(628, 68);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(129, 40);
            this.buttonStep.TabIndex = 6;
            this.buttonStep.Text = "Шаг";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // labelTextForLexicalAnalysis
            // 
            this.labelTextForLexicalAnalysis.AutoSize = true;
            this.labelTextForLexicalAnalysis.Location = new System.Drawing.Point(7, 89);
            this.labelTextForLexicalAnalysis.Name = "labelTextForLexicalAnalysis";
            this.labelTextForLexicalAnalysis.Size = new System.Drawing.Size(179, 13);
            this.labelTextForLexicalAnalysis.TabIndex = 5;
            this.labelTextForLexicalAnalysis.Text = "Текст для лексического анализа:";
            // 
            // labelCurrentLexeme
            // 
            this.labelCurrentLexeme.AutoSize = true;
            this.labelCurrentLexeme.Location = new System.Drawing.Point(7, 56);
            this.labelCurrentLexeme.Name = "labelCurrentLexeme";
            this.labelCurrentLexeme.Size = new System.Drawing.Size(102, 13);
            this.labelCurrentLexeme.TabIndex = 4;
            this.labelCurrentLexeme.Text = "Текущая лексема:";
            // 
            // labelLastLexeme
            // 
            this.labelLastLexeme.AutoSize = true;
            this.labelLastLexeme.Location = new System.Drawing.Point(7, 24);
            this.labelLastLexeme.Name = "labelLastLexeme";
            this.labelLastLexeme.Size = new System.Drawing.Size(113, 13);
            this.labelLastLexeme.TabIndex = 3;
            this.labelLastLexeme.Text = "Последняя лексема:";
            // 
            // textBoxForLex
            // 
            this.textBoxForLex.Location = new System.Drawing.Point(192, 86);
            this.textBoxForLex.Name = "textBoxForLex";
            this.textBoxForLex.Size = new System.Drawing.Size(419, 20);
            this.textBoxForLex.TabIndex = 2;
            // 
            // textBoxCurrentLexeme
            // 
            this.textBoxCurrentLexeme.Location = new System.Drawing.Point(192, 53);
            this.textBoxCurrentLexeme.Name = "textBoxCurrentLexeme";
            this.textBoxCurrentLexeme.Size = new System.Drawing.Size(419, 20);
            this.textBoxCurrentLexeme.TabIndex = 1;
            // 
            // textBoxLastLexeme
            // 
            this.textBoxLastLexeme.Location = new System.Drawing.Point(192, 21);
            this.textBoxLastLexeme.Name = "textBoxLastLexeme";
            this.textBoxLastLexeme.Size = new System.Drawing.Size(419, 20);
            this.textBoxLastLexeme.TabIndex = 0;
            // 
            // groupBoxLexemes
            // 
            this.groupBoxLexemes.Controls.Add(this.buttonDeletSelectedLexemeInState);
            this.groupBoxLexemes.Controls.Add(this.buttonAddLexemeInState);
            this.groupBoxLexemes.Controls.Add(this.dataGridViewLexemes);
            this.groupBoxLexemes.Location = new System.Drawing.Point(626, 42);
            this.groupBoxLexemes.Name = "groupBoxLexemes";
            this.groupBoxLexemes.Size = new System.Drawing.Size(361, 347);
            this.groupBoxLexemes.TabIndex = 4;
            this.groupBoxLexemes.TabStop = false;
            this.groupBoxLexemes.Text = "Лексемы";
            // 
            // buttonDeletSelectedLexemeInState
            // 
            this.buttonDeletSelectedLexemeInState.Location = new System.Drawing.Point(102, 297);
            this.buttonDeletSelectedLexemeInState.Name = "buttonDeletSelectedLexemeInState";
            this.buttonDeletSelectedLexemeInState.Size = new System.Drawing.Size(89, 44);
            this.buttonDeletSelectedLexemeInState.TabIndex = 2;
            this.buttonDeletSelectedLexemeInState.Text = "Удалить выбранную лексему";
            this.buttonDeletSelectedLexemeInState.UseVisualStyleBackColor = true;
            // 
            // buttonAddLexemeInState
            // 
            this.buttonAddLexemeInState.Location = new System.Drawing.Point(7, 297);
            this.buttonAddLexemeInState.Name = "buttonAddLexemeInState";
            this.buttonAddLexemeInState.Size = new System.Drawing.Size(89, 44);
            this.buttonAddLexemeInState.TabIndex = 1;
            this.buttonAddLexemeInState.Text = "Добавить лексему";
            this.buttonAddLexemeInState.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLexemes
            // 
            this.dataGridViewLexemes.AllowUserToAddRows = false;
            this.dataGridViewLexemes.AllowUserToDeleteRows = false;
            this.dataGridViewLexemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLexemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LexemeName,
            this.CountCharToReturn,
            this.FinalState});
            this.dataGridViewLexemes.Location = new System.Drawing.Point(7, 19);
            this.dataGridViewLexemes.Name = "dataGridViewLexemes";
            this.dataGridViewLexemes.Size = new System.Drawing.Size(344, 267);
            this.dataGridViewLexemes.TabIndex = 0;
            // 
            // LexemeName
            // 
            this.LexemeName.HeaderText = "LexemeName";
            this.LexemeName.Name = "LexemeName";
            this.LexemeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CountCharToReturn
            // 
            this.CountCharToReturn.HeaderText = "CountCharToReturn";
            this.CountCharToReturn.Name = "CountCharToReturn";
            this.CountCharToReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FinalState
            // 
            this.FinalState.HeaderText = "FinalState";
            this.FinalState.Name = "FinalState";
            this.FinalState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBoxTableOfState
            // 
            this.groupBoxTableOfState.Controls.Add(this.buttonStart);
            this.groupBoxTableOfState.Controls.Add(this.dataGridViewTableOfState);
            this.groupBoxTableOfState.Controls.Add(this.buttonAddState);
            this.groupBoxTableOfState.Controls.Add(this.buttonDeleteState);
            this.groupBoxTableOfState.Location = new System.Drawing.Point(3, 42);
            this.groupBoxTableOfState.Name = "groupBoxTableOfState";
            this.groupBoxTableOfState.Size = new System.Drawing.Size(617, 347);
            this.groupBoxTableOfState.TabIndex = 3;
            this.groupBoxTableOfState.TabStop = false;
            this.groupBoxTableOfState.Text = "Машина состояний";
            // 
            // dataGridViewTableOfState
            // 
            this.dataGridViewTableOfState.AllowUserToAddRows = false;
            this.dataGridViewTableOfState.AllowUserToDeleteRows = false;
            this.dataGridViewTableOfState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableOfState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Other});
            this.dataGridViewTableOfState.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTableOfState.Name = "dataGridViewTableOfState";
            this.dataGridViewTableOfState.Size = new System.Drawing.Size(605, 267);
            this.dataGridViewTableOfState.TabIndex = 0;
            // 
            // Other
            // 
            this.Other.Frozen = true;
            this.Other.HeaderText = "Остальные";
            this.Other.Name = "Other";
            this.Other.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonAddState
            // 
            this.buttonAddState.Location = new System.Drawing.Point(6, 297);
            this.buttonAddState.Name = "buttonAddState";
            this.buttonAddState.Size = new System.Drawing.Size(114, 44);
            this.buttonAddState.TabIndex = 1;
            this.buttonAddState.Text = "Добавить состояние";
            this.buttonAddState.UseVisualStyleBackColor = true;
            this.buttonAddState.Click += new System.EventHandler(this.buttonAddState_Click);
            // 
            // buttonDeleteState
            // 
            this.buttonDeleteState.Location = new System.Drawing.Point(126, 297);
            this.buttonDeleteState.Name = "buttonDeleteState";
            this.buttonDeleteState.Size = new System.Drawing.Size(113, 44);
            this.buttonDeleteState.TabIndex = 2;
            this.buttonDeleteState.Text = "Удалить состояние";
            this.buttonDeleteState.UseVisualStyleBackColor = true;
            this.buttonDeleteState.Click += new System.EventHandler(this.buttonDeleteState_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(503, 297);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 44);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Готово к употреблению";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 564);
            this.Controls.Add(this.panelTableOfState);
            this.Controls.Add(this.panelLexem);
            this.Controls.Add(this.panelClassOfSymbol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCreateClassOfSymbol.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelClassOfSymbol.ResumeLayout(false);
            this.panelClassOfSymbol.PerformLayout();
            this.panelLexem.ResumeLayout(false);
            this.panelLexem.PerformLayout();
            this.groupBoxCreateLexem.ResumeLayout(false);
            this.groupBoxCreateLexem.PerformLayout();
            this.panelTableOfState.ResumeLayout(false);
            this.panelTableOfState.PerformLayout();
            this.groupBoxControlPanel.ResumeLayout(false);
            this.groupBoxControlPanel.PerformLayout();
            this.groupBoxLexemes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemes)).EndInit();
            this.groupBoxTableOfState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOfState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreateClassOfSymbol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Panel panelClassOfSymbol;
        private System.Windows.Forms.Label labelTitleClassOfSymbol;
        private System.Windows.Forms.TextBox textBoxEnterInterval;
        private System.Windows.Forms.Label labelEnterInterval;
        private System.Windows.Forms.Label labelEnterNameOfClassOfSymbol;
        private System.Windows.Forms.TextBox textBoxEnterNameOfClassSymbol;
        private System.Windows.Forms.Button buttonToLexem;
        private System.Windows.Forms.Button buttonCreateClassOfSymbol;
        private System.Windows.Forms.Panel panelLexem;
        private System.Windows.Forms.GroupBox groupBoxCreateLexem;
        private System.Windows.Forms.Button buttonCreateLexem;
        private System.Windows.Forms.TextBox textBoxEnterLexemName;
        private System.Windows.Forms.Label labelEnterLexemName;
        private System.Windows.Forms.Label labelCreateLexem;
        private System.Windows.Forms.Button buttonToCreateClassOfSymbol;
        private System.Windows.Forms.Button buttonToTableOfState;
        private System.Windows.Forms.TextBox textBoxCountCharToReturn;
        private System.Windows.Forms.TextBox textBoxFinalState;
        private System.Windows.Forms.Label labelCountCharToReturn;
        private System.Windows.Forms.Label labelFinalState;
        private System.Windows.Forms.Panel panelTableOfState;
        private System.Windows.Forms.DataGridView dataGridViewTableOfState;
        private System.Windows.Forms.Button buttonDeleteState;
        private System.Windows.Forms.Button buttonAddState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
        private System.Windows.Forms.GroupBox groupBoxLexemes;
        private System.Windows.Forms.GroupBox groupBoxTableOfState;
        private System.Windows.Forms.DataGridView dataGridViewLexemes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LexemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountCharToReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalState;
        private System.Windows.Forms.GroupBox groupBoxControlPanel;
        private System.Windows.Forms.Button buttonClearSteps;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Label labelTextForLexicalAnalysis;
        private System.Windows.Forms.Label labelCurrentLexeme;
        private System.Windows.Forms.Label labelLastLexeme;
        private System.Windows.Forms.TextBox textBoxForLex;
        private System.Windows.Forms.TextBox textBoxCurrentLexeme;
        private System.Windows.Forms.TextBox textBoxLastLexeme;
        private System.Windows.Forms.Button buttonToStart;
        private System.Windows.Forms.Button buttonDeletSelectedLexemeInState;
        private System.Windows.Forms.Button buttonAddLexemeInState;
        private System.Windows.Forms.Label labelStepThree;
        private System.Windows.Forms.Button buttonChangeMachineOfState;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonStart;
    }
}

