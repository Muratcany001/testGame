namespace WinFormsApp2
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
            call_table = new Button();
            Difficulty = new ComboBox();
            pointTable = new Label();
            SuspendLayout();
            // 
            // call_table
            // 
            call_table.Location = new Point(1032, 172);
            call_table.Name = "call_table";
            call_table.Size = new Size(80, 80);
            call_table.TabIndex = 0;
            call_table.Tag = "";
            call_table.Text = "tahta cagir";
            call_table.UseVisualStyleBackColor = true;
            call_table.Click += button1_Click;
            // 
            // Difficulty
            // 
            Difficulty.FormattingEnabled = true;
            Difficulty.Items.AddRange(new object[] { "5", "10", "20" });
            Difficulty.Location = new Point(1032, 115);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(151, 28);
            Difficulty.TabIndex = 1;
            Difficulty.Text = "Mayın sayısı seç";
            Difficulty.SelectedIndexChanged += Difficulty_SelectedIndexChanged;
            // 
            // pointTable
            // 
            pointTable.AutoSize = true;
            pointTable.Location = new Point(1032, 42);
            pointTable.Name = "pointTable";
            pointTable.Size = new Size(81, 20);
            pointTable.TabIndex = 2;
            pointTable.Text = "Point Table";
            pointTable.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 857);
            Controls.Add(pointTable);
            Controls.Add(Difficulty);
            Controls.Add(call_table);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button call_table;
        private Button button2;
        private ComboBox Difficulty;
        private Label pointTable;
    }
}
