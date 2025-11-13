namespace ArithmeticSimulatorV0
{
    partial class CompletTraining
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
            labelProcentValue = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelProcentText = new Label();
            buttonCheck = new Button();
            buttonExit = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelProcentValue
            // 
            labelProcentValue.Anchor = AnchorStyles.None;
            labelProcentValue.AutoSize = true;
            labelProcentValue.Font = new Font("Segoe UI", 45F);
            labelProcentValue.Location = new Point(280, 152);
            labelProcentValue.Name = "labelProcentValue";
            labelProcentValue.Size = new Size(239, 100);
            labelProcentValue.TabIndex = 0;
            labelProcentValue.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelProcentValue, 0, 1);
            tableLayoutPanel1.Controls.Add(labelProcentText, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonCheck, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonExit, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // labelProcentText
            // 
            labelProcentText.Anchor = AnchorStyles.Bottom;
            labelProcentText.AutoSize = true;
            labelProcentText.Font = new Font("Segoe UI", 16F);
            labelProcentText.Location = new Point(234, 98);
            labelProcentText.Name = "labelProcentText";
            labelProcentText.Size = new Size(332, 37);
            labelProcentText.TabIndex = 1;
            labelProcentText.Text = "Процент верных ответов:";
            // 
            // buttonCheck
            // 
            buttonCheck.Anchor = AnchorStyles.Bottom;
            buttonCheck.AutoSize = true;
            buttonCheck.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCheck.Font = new Font("Segoe UI", 12F);
            buttonCheck.Location = new Point(304, 319);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(191, 38);
            buttonCheck.TabIndex = 2;
            buttonCheck.Text = "Проверить ответы";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top;
            buttonExit.AutoSize = true;
            buttonExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonExit.Font = new Font("Segoe UI", 12F);
            buttonExit.Location = new Point(267, 363);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(266, 38);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Вернуться в главное меню";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // CompletTraining
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CompletTraining";
            Size = new Size(800, 450);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelProcentValue;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelProcentText;
        private Button buttonCheck;
        private Button buttonExit;
    }
}