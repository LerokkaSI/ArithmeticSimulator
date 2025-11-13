namespace ArithmeticSimulatorV0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelHello = new Label();
            lableMotivation = new Label();
            buttonStart = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelHello
            // 
            labelHello.Anchor = AnchorStyles.Bottom;
            labelHello.AutoSize = true;
            labelHello.Font = new Font("Segoe UI", 32F);
            labelHello.Location = new Point(139, 17);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(519, 72);
            labelHello.TabIndex = 0;
            labelHello.Text = "Добро пожаловать!";
            // 
            // lableMotivation
            // 
            lableMotivation.Anchor = AnchorStyles.None;
            lableMotivation.AutoSize = true;
            lableMotivation.Font = new Font("Segoe UI", 15F);
            lableMotivation.Location = new Point(182, 116);
            lableMotivation.Name = "lableMotivation";
            lableMotivation.Size = new Size(433, 35);
            lableMotivation.TabIndex = 1;
            lableMotivation.Text = "Проверь свои знания в математике:";
            // 
            // buttonStart
            // 
            buttonStart.Anchor = AnchorStyles.Top;
            buttonStart.Font = new Font("Segoe UI", 12F);
            buttonStart.Location = new Point(330, 181);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(138, 51);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Начать";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonStart, 0, 2);
            tableLayoutPanel1.Controls.Add(labelHello, 0, 0);
            tableLayoutPanel1.Controls.Add(lableMotivation, 0, 1);
            tableLayoutPanel1.Location = new Point(1, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(798, 257);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Arithmetic simulator";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelHello;
        private Label lableMotivation;
        private Button buttonStart;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
