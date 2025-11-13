namespace ArithmeticSimulatorV0
{
    partial class SumDifferenceSet
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
            trackBarMinMax = new TrackBar();
            labelMinMax = new Label();
            labelCount = new Label();
            trackBarCount = new TrackBar();
            buttonStart = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)trackBarMinMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarCount).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // trackBarMinMax
            // 
            trackBarMinMax.Location = new Point(3, 65);
            trackBarMinMax.Maximum = 6;
            trackBarMinMax.Minimum = 1;
            trackBarMinMax.Name = "trackBarMinMax";
            trackBarMinMax.Size = new Size(331, 56);
            trackBarMinMax.TabIndex = 0;
            trackBarMinMax.Value = 3;
            trackBarMinMax.Scroll += trackBarMinMax_Scroll;
            // 
            // labelMinMax
            // 
            labelMinMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelMinMax.AutoSize = true;
            labelMinMax.Font = new Font("Segoe UI", 12F);
            labelMinMax.Location = new Point(3, 34);
            labelMinMax.Name = "labelMinMax";
            labelMinMax.Size = new Size(263, 28);
            labelMinMax.TabIndex = 1;
            labelMinMax.Text = "Диапазон значений: ±1000\r\n";
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
            buttonStart.Location = new Point(60, 329);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(197, 42);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Начать тренировку";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelMinMax, 0, 0);
            tableLayoutPanel1.Controls.Add(trackBarMinMax, 0, 1);
            tableLayoutPanel1.Location = new Point(60, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(337, 125);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelCount, 0, 0);
            tableLayoutPanel2.Controls.Add(trackBarCount, 0, 1);
            tableLayoutPanel2.Location = new Point(60, 170);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(337, 125);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // SumDifferenceSet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonStart);
            Name = "SumDifferenceSet";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)trackBarMinMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarCount).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TrackBar trackBarMinMax;
        private Label labelMinMax;
        private Label labelCount;
        private TrackBar trackBarCount;
        private Button buttonStart;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}