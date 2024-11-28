namespace InterfaceDiskLab_2
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ComboBox_Count = new ToolStripComboBox();
            TableFunction = new DataGridView();
            RandomFunction = new Button();
            label1 = new Label();
            Calculate = new Button();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableFunction).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.HighlightText;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ComboBox_Count });
            menuStrip1.Location = new Point(146, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(170, 27);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ComboBox_Count
            // 
            ComboBox_Count.BackColor = SystemColors.HighlightText;
            ComboBox_Count.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Count.FlatStyle = FlatStyle.Standard;
            ComboBox_Count.Items.AddRange(new object[] { "2", "3", "4", "5" });
            ComboBox_Count.Name = "ComboBox_Count";
            ComboBox_Count.Size = new Size(160, 23);
            ComboBox_Count.SelectedIndexChanged += ComboBox_Count_SelectedIndexChanged;
            // 
            // TableFunction
            // 
            TableFunction.AllowUserToAddRows = false;
            TableFunction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TableFunction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TableFunction.BackgroundColor = SystemColors.HighlightText;
            TableFunction.BorderStyle = BorderStyle.None;
            TableFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TableFunction.Location = new Point(12, 39);
            TableFunction.Name = "TableFunction";
            TableFunction.Size = new Size(304, 399);
            TableFunction.TabIndex = 2;
            // 
            // RandomFunction
            // 
            RandomFunction.Location = new Point(608, 355);
            RandomFunction.Name = "RandomFunction";
            RandomFunction.Size = new Size(164, 40);
            RandomFunction.TabIndex = 3;
            RandomFunction.Text = "Сгенерировать значения \r\nфункций";
            RandomFunction.UseVisualStyleBackColor = true;
            RandomFunction.Click += RandomFunction_Click;
            // 
            // label1
            // 
            label1.Location = new Point(70, 6);
            label1.Name = "label1";
            label1.Size = new Size(86, 33);
            label1.TabIndex = 4;
            label1.Text = "Количество\r\nпеременных:\r\n";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(678, 401);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(94, 37);
            Calculate.TabIndex = 5;
            Calculate.Text = "Посчитать";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(Calculate);
            Controls.Add(RandomFunction);
            Controls.Add(TableFunction);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Калькулятор булевых функций";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TableFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripComboBox ComboBox_Count;
        private DataGridView TableFunction;
        private Button RandomFunction;
        private Label label1;
        private Button Calculate;
    }
}
