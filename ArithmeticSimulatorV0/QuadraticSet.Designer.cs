namespace ArithmeticSimulatorV0
{
    partial class QuadraticSet
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
            tableLayoutPanel2 = new TableLayoutPanel();
            labelCount = new Label();
            trackBarCount = new TrackBar();
            buttonStart = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarCount).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelCount, 0, 0);
            tableLayoutPanel2.Controls.Add(trackBarCount, 0, 1);
            tableLayoutPanel2.Location = new Point(232, 101);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(337, 125);
            tableLayoutPanel2.TabIndex = 9;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 12F);
            labelCount.Location = new Point(3, 34);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(251, 28);
            labelCount.TabIndex = 2;
            labelCount.Text = "Количество примеров: 10";
            // 
            // trackBarCount
            // 
            trackBarCount.Location = new Point(3, 65);
            trackBarCount.Maximum = 20;
            trackBarCount.Minimum = 1;
            trackBarCount.Name = "trackBarCount";
            trackBarCount.Size = new Size(331, 56);
            trackBarCount.TabIndex = 3;
            trackBarCount.Value = 10;
            trackBarCount.Scroll += trackBarCount_Scroll;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 12F);
            buttonStart.Location = new Point(289, 276);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(197, 42);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Начать тренировку";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // QuadraticSet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(buttonStart);
            Name = "QuadraticSet";
            Size = new Size(800, 450);
            Load += QuadraticSet_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label labelCount;
        private TrackBar trackBarCount;
        private Button buttonStart;
    }
}