namespace ArithmeticSimulatorV0
{
    partial class ProblemPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNumber = new Label();
            buttonBack = new Button();
            buttonNext = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonFinish = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            labelProblem = new Label();
            labelDefoltText = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelRightAnswer = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.Anchor = AnchorStyles.None;
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 12F);
            labelNumber.Location = new Point(135, 21);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(56, 28);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "1 / N";
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Left;
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(3, 14);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 42);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "<<<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonNext
            // 
            buttonNext.Anchor = AnchorStyles.Right;
            buttonNext.Font = new Font("Segoe UI", 12F);
            buttonNext.Location = new Point(249, 14);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 42);
            buttonNext.TabIndex = 2;
            buttonNext.Text = ">>>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonFinish, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(60, 320);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(667, 77);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonFinish
            // 
            buttonFinish.Anchor = AnchorStyles.None;
            buttonFinish.Font = new Font("Segoe UI", 12F);
            buttonFinish.Location = new Point(422, 17);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(155, 42);
            buttonFinish.TabIndex = 5;
            buttonFinish.Text = "Завершить";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(buttonBack, 0, 0);
            tableLayoutPanel2.Controls.Add(labelNumber, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonNext, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(327, 71);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(3, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(661, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // labelProblem
            // 
            labelProblem.Anchor = AnchorStyles.Left;
            labelProblem.AutoSize = true;
            labelProblem.Font = new Font("Segoe UI", 15F);
            labelProblem.Location = new Point(3, 87);
            labelProblem.Name = "labelProblem";
            labelProblem.Size = new Size(185, 35);
            labelProblem.TabIndex = 5;
            labelProblem.Text = "Текст примера";
            labelProblem.Click += labelProblem_Click;
            // 
            // labelDefoltText
            // 
            labelDefoltText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelDefoltText.AutoSize = true;
            labelDefoltText.Font = new Font("Segoe UI", 12F);
            labelDefoltText.Location = new Point(3, 42);
            labelDefoltText.Name = "labelDefoltText";
            labelDefoltText.Size = new Size(231, 28);
            labelDefoltText.TabIndex = 6;
            labelDefoltText.Text = "Введите, чему равно (?):";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel3.Controls.Add(labelDefoltText, 0, 0);
            tableLayoutPanel3.Controls.Add(labelProblem, 0, 1);
            tableLayoutPanel3.Controls.Add(labelRightAnswer, 0, 3);
            tableLayoutPanel3.Location = new Point(60, 50);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(667, 234);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // labelRightAnswer
            // 
            labelRightAnswer.Anchor = AnchorStyles.Left;
            labelRightAnswer.AutoSize = true;
            labelRightAnswer.Font = new Font("Segoe UI", 12F);
            labelRightAnswer.Location = new Point(3, 196);
            labelRightAnswer.MinimumSize = new Size(30, 0);
            labelRightAnswer.Name = "labelRightAnswer";
            labelRightAnswer.Size = new Size(30, 28);
            labelRightAnswer.TabIndex = 7;
            // 
            // ProblemPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "ProblemPage";
            Size = new Size(800, 450);
            Load += ProblemPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNumber;
        private Button buttonBack;
        private Button buttonNext;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonFinish;
        private TextBox textBox1;
        private Label labelProblem;
        private Label labelDefoltText;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelRightAnswer;
    }
}