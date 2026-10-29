namespace ProjectGasStation.Forms
{
    partial class FormFuelSale
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
            labelFuel = new Label();
            comboBoxFuel = new ComboBox();
            labelSeller = new Label();
            comboBoxSeller = new ComboBox();
            labelWorkShift = new Label();
            comboBoxWorkShift = new ComboBox();
            labelQuantity = new Label();
            numericUpDownQuantity = new NumericUpDown();
            labelTotalSum = new Label();
            numericUpDownTotalSum = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalSum).BeginInit();
            SuspendLayout();
            // 
            // labelFuel
            // 
            labelFuel.AutoSize = true;
            labelFuel.Location = new Point(25, 25);
            labelFuel.Name = "labelFuel";
            labelFuel.Size = new Size(35, 15);
            labelFuel.TabIndex = 0;
            labelFuel.Text = "ГСМ:";
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Location = new Point(150, 22);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(200, 23);
            comboBoxFuel.TabIndex = 1;
            // 
            // labelSeller
            // 
            labelSeller.AutoSize = true;
            labelSeller.Location = new Point(25, 65);
            labelSeller.Name = "labelSeller";
            labelSeller.Size = new Size(65, 15);
            labelSeller.TabIndex = 2;
            labelSeller.Text = "Продавец:";
            // 
            // comboBoxSeller
            // 
            comboBoxSeller.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeller.FormattingEnabled = true;
            comboBoxSeller.Location = new Point(150, 62);
            comboBoxSeller.Name = "comboBoxSeller";
            comboBoxSeller.Size = new Size(200, 23);
            comboBoxSeller.TabIndex = 3;
            // 
            // labelWorkShift
            // 
            labelWorkShift.AutoSize = true;
            labelWorkShift.Location = new Point(25, 105);
            labelWorkShift.Name = "labelWorkShift";
            labelWorkShift.Size = new Size(46, 15);
            labelWorkShift.TabIndex = 4;
            labelWorkShift.Text = "Смена:";
            // 
            // comboBoxWorkShift
            // 
            comboBoxWorkShift.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWorkShift.FormattingEnabled = true;
            comboBoxWorkShift.Location = new Point(150, 102);
            comboBoxWorkShift.Name = "comboBoxWorkShift";
            comboBoxWorkShift.Size = new Size(200, 23);
            comboBoxWorkShift.TabIndex = 5;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(25, 145);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(75, 15);
            labelQuantity.TabIndex = 6;
            labelQuantity.Text = "Количество:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(150, 142);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(200, 23);
            numericUpDownQuantity.TabIndex = 7;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelTotalSum
            // 
            labelTotalSum.AutoSize = true;
            labelTotalSum.Location = new Point(25, 185);
            labelTotalSum.Name = "labelTotalSum";
            labelTotalSum.Size = new Size(47, 15);
            labelTotalSum.TabIndex = 8;
            labelTotalSum.Text = "Сумма:";
            // 
            // numericUpDownTotalSum
            // 
            numericUpDownTotalSum.DecimalPlaces = 2;
            numericUpDownTotalSum.Location = new Point(150, 182);
            numericUpDownTotalSum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownTotalSum.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownTotalSum.Name = "numericUpDownTotalSum";
            numericUpDownTotalSum.Size = new Size(200, 23);
            numericUpDownTotalSum.TabIndex = 9;
            numericUpDownTotalSum.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(75, 230);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(205, 230);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormFuelSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 285);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownTotalSum);
            Controls.Add(labelTotalSum);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(comboBoxWorkShift);
            Controls.Add(labelWorkShift);
            Controls.Add(comboBoxSeller);
            Controls.Add(labelSeller);
            Controls.Add(comboBoxFuel);
            Controls.Add(labelFuel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormFuelSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Продажа ГСМ";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelFuel;
        private ComboBox comboBoxFuel;
        private Label labelSeller;
        private ComboBox comboBoxSeller;
        private Label labelWorkShift;
        private ComboBox comboBoxWorkShift;
        private Label labelQuantity;
        private NumericUpDown numericUpDownQuantity;
        private Label labelTotalSum;
        private NumericUpDown numericUpDownTotalSum;
        private Button buttonSave;
        private Button buttonCancel;
    }
}