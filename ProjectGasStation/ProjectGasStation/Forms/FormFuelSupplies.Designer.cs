namespace ProjectGasStation.Forms
{
    partial class FormFuelSupplies
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
            dataGridViewData = new DataGridView();
            panelButtons = new Panel();
            buttonAdd = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Fill;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(580, 400);
            dataGridViewData.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonDel);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(580, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(120, 400);
            panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 15);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(10, 65);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(100, 35);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += ButtonDel_Click;
            // 
            // FormFuelSupplies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(dataGridViewData);
            Controls.Add(panelButtons);
            Name = "FormFuelSupplies";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пополнения запасов ГСМ";
            Load += FormFuelSupplies_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridView dataGridViewData;
        private Panel panelButtons;
        private Button buttonAdd;
        private Button buttonDel;
    }
}