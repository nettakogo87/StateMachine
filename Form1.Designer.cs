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
            this.textBoxEnterLastSymbol = new System.Windows.Forms.TextBox();
            this.labelEnterLastSymbol = new System.Windows.Forms.Label();
            this.labelTitleClassOfSymbol = new System.Windows.Forms.Label();
            this.textBoxEnterFirstSymbol = new System.Windows.Forms.TextBox();
            this.labelEnterFirstSymbol = new System.Windows.Forms.Label();
            this.labelEnterNameOfClassOfSymbol = new System.Windows.Forms.Label();
            this.textBoxEnterNameOfClassSymbol = new System.Windows.Forms.TextBox();
            this.panelLexem = new System.Windows.Forms.Panel();
            this.groupBoxCreateLexem = new System.Windows.Forms.GroupBox();
            this.buttonToCreateClassOfSymbol = new System.Windows.Forms.Button();
            this.buttonToTableOfState = new System.Windows.Forms.Button();
            this.buttonCreateLexem = new System.Windows.Forms.Button();
            this.textBoxEnterLexemName = new System.Windows.Forms.TextBox();
            this.labelEnterLexemName = new System.Windows.Forms.Label();
            this.labelCreateLexem = new System.Windows.Forms.Label();
            this.labelFinalState = new System.Windows.Forms.Label();
            this.labelCountCharToReturn = new System.Windows.Forms.Label();
            this.textBoxFinalState = new System.Windows.Forms.TextBox();
            this.textBoxCountCharToReturn = new System.Windows.Forms.TextBox();
            this.groupBoxCreateClassOfSymbol.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelClassOfSymbol.SuspendLayout();
            this.panelLexem.SuspendLayout();
            this.groupBoxCreateLexem.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(854, 25);
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
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // panelClassOfSymbol
            // 
            this.panelClassOfSymbol.Controls.Add(this.buttonCreateClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.textBoxEnterLastSymbol);
            this.panelClassOfSymbol.Controls.Add(this.labelEnterLastSymbol);
            this.panelClassOfSymbol.Controls.Add(this.labelTitleClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.textBoxEnterFirstSymbol);
            this.panelClassOfSymbol.Controls.Add(this.labelEnterFirstSymbol);
            this.panelClassOfSymbol.Controls.Add(this.labelEnterNameOfClassOfSymbol);
            this.panelClassOfSymbol.Controls.Add(this.textBoxEnterNameOfClassSymbol);
            this.panelClassOfSymbol.Controls.Add(this.groupBoxCreateClassOfSymbol);
            this.panelClassOfSymbol.Location = new System.Drawing.Point(12, 28);
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
            // textBoxEnterLastSymbol
            // 
            this.textBoxEnterLastSymbol.Location = new System.Drawing.Point(64, 201);
            this.textBoxEnterLastSymbol.Name = "textBoxEnterLastSymbol";
            this.textBoxEnterLastSymbol.Size = new System.Drawing.Size(194, 20);
            this.textBoxEnterLastSymbol.TabIndex = 6;
            // 
            // labelEnterLastSymbol
            // 
            this.labelEnterLastSymbol.AutoSize = true;
            this.labelEnterLastSymbol.Location = new System.Drawing.Point(61, 185);
            this.labelEnterLastSymbol.Name = "labelEnterLastSymbol";
            this.labelEnterLastSymbol.Size = new System.Drawing.Size(145, 13);
            this.labelEnterLastSymbol.TabIndex = 5;
            this.labelEnterLastSymbol.Text = "Введите конечный символ:";
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
            // textBoxEnterFirstSymbol
            // 
            this.textBoxEnterFirstSymbol.Location = new System.Drawing.Point(64, 133);
            this.textBoxEnterFirstSymbol.Name = "textBoxEnterFirstSymbol";
            this.textBoxEnterFirstSymbol.Size = new System.Drawing.Size(194, 20);
            this.textBoxEnterFirstSymbol.TabIndex = 3;
            // 
            // labelEnterFirstSymbol
            // 
            this.labelEnterFirstSymbol.AutoSize = true;
            this.labelEnterFirstSymbol.Location = new System.Drawing.Point(61, 117);
            this.labelEnterFirstSymbol.Name = "labelEnterFirstSymbol";
            this.labelEnterFirstSymbol.Size = new System.Drawing.Size(151, 13);
            this.labelEnterFirstSymbol.TabIndex = 2;
            this.labelEnterFirstSymbol.Text = "Введите начальный символ:";
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
            this.panelLexem.Location = new System.Drawing.Point(335, 28);
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
            // labelFinalState
            // 
            this.labelFinalState.AutoSize = true;
            this.labelFinalState.Location = new System.Drawing.Point(41, 83);
            this.labelFinalState.Name = "labelFinalState";
            this.labelFinalState.Size = new System.Drawing.Size(198, 13);
            this.labelFinalState.TabIndex = 5;
            this.labelFinalState.Text = "Введите номер конечного состояния:";
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
            // textBoxFinalState
            // 
            this.textBoxFinalState.Location = new System.Drawing.Point(44, 99);
            this.textBoxFinalState.Name = "textBoxFinalState";
            this.textBoxFinalState.Size = new System.Drawing.Size(222, 20);
            this.textBoxFinalState.TabIndex = 7;
            // 
            // textBoxCountCharToReturn
            // 
            this.textBoxCountCharToReturn.Location = new System.Drawing.Point(44, 167);
            this.textBoxCountCharToReturn.Name = "textBoxCountCharToReturn";
            this.textBoxCountCharToReturn.Size = new System.Drawing.Size(222, 20);
            this.textBoxCountCharToReturn.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 434);
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
        private System.Windows.Forms.TextBox textBoxEnterFirstSymbol;
        private System.Windows.Forms.Label labelEnterFirstSymbol;
        private System.Windows.Forms.Label labelEnterNameOfClassOfSymbol;
        private System.Windows.Forms.TextBox textBoxEnterNameOfClassSymbol;
        private System.Windows.Forms.Label labelEnterLastSymbol;
        private System.Windows.Forms.TextBox textBoxEnterLastSymbol;
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
    }
}

