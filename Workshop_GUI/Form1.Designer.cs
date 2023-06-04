namespace Workshop_GUI
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
            tabControl1 = new TabControl();
            cars_tab = new TabPage();
            save_changes = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            profit_tab = new TabPage();
            incomeResult = new TextBox();
            label4 = new Label();
            EndDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            startDate = new DateTimePicker();
            calculate_profit = new Button();
            tabControl1.SuspendLayout();
            cars_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            profit_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(cars_tab);
            tabControl1.Controls.Add(profit_tab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(884, 561);
            tabControl1.TabIndex = 1;
            // 
            // cars_tab
            // 
            cars_tab.Controls.Add(save_changes);
            cars_tab.Controls.Add(label5);
            cars_tab.Controls.Add(comboBox1);
            cars_tab.Controls.Add(dataGridView1);
            cars_tab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cars_tab.Location = new Point(4, 24);
            cars_tab.Name = "cars_tab";
            cars_tab.Padding = new Padding(3);
            cars_tab.Size = new Size(876, 533);
            cars_tab.TabIndex = 0;
            cars_tab.Text = "Информация по ремонту";
            cars_tab.UseVisualStyleBackColor = true;
            // 
            // save_changes
            // 
            save_changes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            save_changes.Location = new Point(21, 363);
            save_changes.Name = "save_changes";
            save_changes.Size = new Size(98, 70);
            save_changes.TabIndex = 3;
            save_changes.Text = "Сохранить изменения";
            save_changes.UseVisualStyleBackColor = true;
            save_changes.Click += save_changes_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(21, 37);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 2;
            label5.Text = "Отобразить:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Машины", "Мастера", "Работы" });
            comboBox1.Location = new Point(21, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 29);
            comboBox1.TabIndex = 1;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(155, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(659, 396);
            dataGridView1.TabIndex = 0;
            // 
            // profit_tab
            // 
            profit_tab.Controls.Add(incomeResult);
            profit_tab.Controls.Add(label4);
            profit_tab.Controls.Add(EndDate);
            profit_tab.Controls.Add(label3);
            profit_tab.Controls.Add(label2);
            profit_tab.Controls.Add(label1);
            profit_tab.Controls.Add(startDate);
            profit_tab.Controls.Add(calculate_profit);
            profit_tab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profit_tab.Location = new Point(4, 24);
            profit_tab.Name = "profit_tab";
            profit_tab.Size = new Size(876, 533);
            profit_tab.TabIndex = 2;
            profit_tab.Text = "Доходы";
            profit_tab.UseVisualStyleBackColor = true;
            // 
            // incomeResult
            // 
            incomeResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            incomeResult.Location = new Point(537, 104);
            incomeResult.Name = "incomeResult";
            incomeResult.ReadOnly = true;
            incomeResult.Size = new Size(132, 29);
            incomeResult.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(537, 69);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 7;
            label4.Text = "Результат";
            // 
            // EndDate
            // 
            EndDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EndDate.Location = new Point(128, 204);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(213, 29);
            EndDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(128, 165);
            label3.Name = "label3";
            label3.Size = new Size(205, 21);
            label3.TabIndex = 5;
            label3.Text = "Конец расчётного периода";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(128, 69);
            label2.Name = "label2";
            label2.Size = new Size(213, 21);
            label2.TabIndex = 4;
            label2.Text = "Начало расчётного периода";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Расчет доходов";
            label1.Click += label1_Click;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startDate.Location = new Point(128, 104);
            startDate.Name = "startDate";
            startDate.Size = new Size(213, 29);
            startDate.TabIndex = 2;
            // 
            // calculate_profit
            // 
            calculate_profit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calculate_profit.Location = new Point(359, 377);
            calculate_profit.Name = "calculate_profit";
            calculate_profit.Size = new Size(148, 33);
            calculate_profit.TabIndex = 0;
            calculate_profit.Text = "Рассчитать";
            calculate_profit.UseVisualStyleBackColor = true;
            calculate_profit.Click += calculate_profit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tabControl1);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Workshop";
            tabControl1.ResumeLayout(false);
            cars_tab.ResumeLayout(false);
            cars_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            profit_tab.ResumeLayout(false);
            profit_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage cars_tab;
        private TabPage profit_tab;
        private Label label1;
        private DateTimePicker startDate;
        private Button calculate_profit;
        private DateTimePicker EndDate;
        private Label label3;
        private Label label2;
        private TextBox incomeResult;
        private Label label4;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label5;
        private Button save_changes;
    }
}