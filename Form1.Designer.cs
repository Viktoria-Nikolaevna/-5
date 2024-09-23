namespace ЛР5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxBurger = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheeseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letuceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picklesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cheeseDataGridViewTextBoxColumn,
            this.baconDataGridViewTextBoxColumn,
            this.letuceDataGridViewTextBoxColumn,
            this.tomatoDataGridViewTextBoxColumn,
            this.picklesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.burgerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxBurger
            // 
            this.comboBoxBurger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBurger.FormattingEnabled = true;
            this.comboBoxBurger.Items.AddRange(new object[] {
            "Бургер стандартный",
            "Бургер с беконом"});
            this.comboBoxBurger.Location = new System.Drawing.Point(27, 401);
            this.comboBoxBurger.Name = "comboBoxBurger";
            this.comboBoxBurger.Size = new System.Drawing.Size(345, 32);
            this.comboBoxBurger.TabIndex = 1;
            this.comboBoxBurger.SelectedIndexChanged += new System.EventHandler(this.comboBoxBurger_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(429, 401);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(345, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить бургер";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // cheeseDataGridViewTextBoxColumn
            // 
            this.cheeseDataGridViewTextBoxColumn.DataPropertyName = "Cheese";
            this.cheeseDataGridViewTextBoxColumn.HeaderText = "Cheese";
            this.cheeseDataGridViewTextBoxColumn.Name = "cheeseDataGridViewTextBoxColumn";
            // 
            // baconDataGridViewTextBoxColumn
            // 
            this.baconDataGridViewTextBoxColumn.DataPropertyName = "Bacon";
            this.baconDataGridViewTextBoxColumn.HeaderText = "Bacon";
            this.baconDataGridViewTextBoxColumn.Name = "baconDataGridViewTextBoxColumn";
            // 
            // letuceDataGridViewTextBoxColumn
            // 
            this.letuceDataGridViewTextBoxColumn.DataPropertyName = "Letuce";
            this.letuceDataGridViewTextBoxColumn.HeaderText = "Letuce";
            this.letuceDataGridViewTextBoxColumn.Name = "letuceDataGridViewTextBoxColumn";
            // 
            // tomatoDataGridViewTextBoxColumn
            // 
            this.tomatoDataGridViewTextBoxColumn.DataPropertyName = "Tomato";
            this.tomatoDataGridViewTextBoxColumn.HeaderText = "Tomato";
            this.tomatoDataGridViewTextBoxColumn.Name = "tomatoDataGridViewTextBoxColumn";
            // 
            // picklesDataGridViewTextBoxColumn
            // 
            this.picklesDataGridViewTextBoxColumn.DataPropertyName = "Pickles";
            this.picklesDataGridViewTextBoxColumn.HeaderText = "Pickles";
            this.picklesDataGridViewTextBoxColumn.Name = "picklesDataGridViewTextBoxColumn";
            // 
            // burgerBindingSource
            // 
            this.burgerBindingSource.DataSource = typeof(ЛР5.DBCon.Burger);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxBurger);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxBurger;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheeseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baconDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letuceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picklesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource burgerBindingSource;
    }
}

