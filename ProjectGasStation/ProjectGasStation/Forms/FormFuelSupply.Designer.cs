namespace ProjectGasStation.Forms
{
    partial class FormFuelSupply
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelSupplier = new Label();
            comboBoxSupplier = new ComboBox();
            labelSeller = new Label();
            comboBoxSeller = new ComboBox();
            groupBoxFuels = new GroupBox();
            dataGridViewFuels = new DataGridView();
            ColumnFuel = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBoxFuels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).BeginInit();
            SuspendLayout();
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new Point(20, 20);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(70, 15);
            labelSupplier.TabIndex = 0;
            labelSupplier.Text = "Поставщик:";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(120, 17);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(250, 23);
            comboBoxSupplier.TabIndex = 1;
            // 
            // labelSeller
            // 
            labelSeller.AutoSize = true;
            labelSeller.Location = new Point(20, 55);
            labelSeller.Name = "labelSeller";
            labelSeller.Size = new Size(65, 15);
            labelSeller.TabIndex = 2;
            labelSeller.Text = "Продавец:";
            // 
            // comboBoxSeller
            // 
            comboBoxSeller.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeller.FormattingEnabled = true;
            comboBoxSeller.Location = new Point(120, 52);
            comboBoxSeller.Name = "comboBoxSeller";
            comboBoxSeller.Size = new Size(250, 23);
            comboBoxSeller.TabIndex = 3;
            // 
            // groupBoxFuels
            // 
            groupBoxFuels.Controls.Add(dataGridViewFuels);
            groupBoxFuels.Location = new Point(20, 90);
            groupBoxFuels.Name = "groupBoxFuels";
            groupBoxFuels.Size = new Size(350, 220);
            groupBoxFuels.TabIndex = 4;
            groupBoxFuels.TabStop = false;
            groupBoxFuels.Text = "Закупаемые ГСМ";
            // 
            // dataGridViewFuels
            // 
            dataGridViewFuels.AllowUserToResizeColumns = false;
            dataGridViewFuels.AllowUserToResizeRows = false;
            dataGridViewFuels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuels.Columns.AddRange(new DataGridViewColumn[] { ColumnFuel, ColumnCount });
            dataGridViewFuels.Dock = DockStyle.Fill;
            dataGridViewFuels.Location = new Point(3, 19);
            dataGridViewFuels.MultiSelect = false;
            dataGridViewFuels.Name = "dataGridViewFuels";
            dataGridViewFuels.RowHeadersVisible = false;
            dataGridViewFuels.Size = new Size(344, 198);
            dataGridViewFuels.TabIndex = 0;
            // 
            // ColumnFuel
            // 
            ColumnFuel.HeaderText = "ГСМ";
            ColumnFuel.Name = "ColumnFuel";
            // 
            // ColumnCount
            // 
            ColumnCount.HeaderText = "Количество";
            ColumnCount.Name = "ColumnCount";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(75, 325);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(215, 325);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormFuelSupply
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 375);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxFuels);
            Controls.Add(comboBoxSeller);
            Controls.Add(labelSeller);
            Controls.Add(comboBoxSupplier);
            Controls.Add(labelSupplier);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormFuelSupply";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пополнение запасов ГСМ";
            groupBoxFuels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelSupplier;
        private ComboBox comboBoxSupplier;
        private Label labelSeller;
        private ComboBox comboBoxSeller;
        private GroupBox groupBoxFuels;
        private DataGridView dataGridViewFuels;
        private DataGridViewComboBoxColumn ColumnFuel;
        private DataGridViewTextBoxColumn ColumnCount;
        private Button buttonSave;
        private Button buttonCancel;
    }
}