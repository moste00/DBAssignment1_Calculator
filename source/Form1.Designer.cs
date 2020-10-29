namespace Calculator1
{
    partial class Calculator
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
            this.FirstValue = new System.Windows.Forms.NumericUpDown();
            this.SecondValue = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.DataGridView();
            this.op = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_operations = new System.Windows.Forms.TextBox();
            this.operations_counter = new System.Windows.Forms.TextBox();
            this.HistoryToggle = new System.Windows.Forms.Button();
            this.HistoryClr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstValue
            // 
            this.FirstValue.Location = new System.Drawing.Point(181, 79);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(198, 24);
            this.FirstValue.TabIndex = 0;
            // 
            // SecondValue
            // 
            this.SecondValue.Location = new System.Drawing.Point(181, 185);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(198, 24);
            this.SecondValue.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "First Value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(89, 24);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Second Value";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(627, 79);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(184, 30);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // History
            // 
            this.History.AllowUserToAddRows = false;
            this.History.AllowUserToDeleteRows = false;
            this.History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.v1,
            this.Operation,
            this.v2,
            this.Result});
            this.History.Location = new System.Drawing.Point(181, 278);
            this.History.Name = "History";
            this.History.ReadOnly = true;
            this.History.RowHeadersWidth = 51;
            this.History.RowTemplate.Height = 26;
            this.History.Size = new System.Drawing.Size(912, 215);
            this.History.TabIndex = 5;
            this.History.Visible = false;
            // 
            // op
            // 
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-"});
            this.op.Location = new System.Drawing.Point(181, 135);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(69, 24);
            this.op.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(71, 24);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Operation";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // v1
            // 
            this.v1.HeaderText = "v1";
            this.v1.MinimumWidth = 6;
            this.v1.Name = "v1";
            this.v1.ReadOnly = true;
            this.v1.Width = 125;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "operation";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 125;
            // 
            // v2
            // 
            this.v2.HeaderText = "v2";
            this.v2.MinimumWidth = 6;
            this.v2.Name = "v2";
            this.v2.ReadOnly = true;
            this.v2.Width = 125;
            // 
            // Result
            // 
            this.Result.HeaderText = "result";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 125;
            // 
            // num_operations
            // 
            this.num_operations.Location = new System.Drawing.Point(879, 140);
            this.num_operations.Name = "num_operations";
            this.num_operations.ReadOnly = true;
            this.num_operations.Size = new System.Drawing.Size(214, 24);
            this.num_operations.TabIndex = 8;
            this.num_operations.Text = "Number of operations performed :";
            // 
            // operations_counter
            // 
            this.operations_counter.Location = new System.Drawing.Point(1143, 140);
            this.operations_counter.Name = "operations_counter";
            this.operations_counter.ReadOnly = true;
            this.operations_counter.Size = new System.Drawing.Size(100, 24);
            this.operations_counter.TabIndex = 9;
            // 
            // HistoryToggle
            // 
            this.HistoryToggle.Location = new System.Drawing.Point(627, 135);
            this.HistoryToggle.Name = "HistoryToggle";
            this.HistoryToggle.Size = new System.Drawing.Size(184, 32);
            this.HistoryToggle.TabIndex = 10;
            this.HistoryToggle.Text = "Show/Hide History";
            this.HistoryToggle.UseVisualStyleBackColor = true;
            this.HistoryToggle.Click += new System.EventHandler(this.HistoryToggle_Click);
            // 
            // HistoryClr
            // 
            this.HistoryClr.Location = new System.Drawing.Point(627, 185);
            this.HistoryClr.Name = "HistoryClr";
            this.HistoryClr.Size = new System.Drawing.Size(184, 33);
            this.HistoryClr.TabIndex = 11;
            this.HistoryClr.Text = "Clear History";
            this.HistoryClr.UseVisualStyleBackColor = true;
            this.HistoryClr.Click += new System.EventHandler(this.HistoryClr_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 505);
            this.Controls.Add(this.HistoryClr);
            this.Controls.Add(this.HistoryToggle);
            this.Controls.Add(this.operations_counter);
            this.Controls.Add(this.num_operations);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.op);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Name = "Calculator";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.FirstValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown FirstValue;
        private System.Windows.Forms.NumericUpDown SecondValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.DataGridView History;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.TextBox num_operations;
        private System.Windows.Forms.TextBox operations_counter;
        private System.Windows.Forms.Button HistoryToggle;
        private System.Windows.Forms.Button HistoryClr;
    }
}

