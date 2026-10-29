namespace ProjectGasStation.Forms
{
    partial class FormFuel
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelFuelType = new Label();
            checkedListBoxFuelType = new CheckedListBox();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(25, 25);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(150, 22);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelFuelType
            // 
            labelFuelType.AutoSize = true;
            labelFuelType.Location = new Point(25, 65);
            labelFuelType.Name = "labelFuelType";
            labelFuelType.Size = new Size(65, 15);
            labelFuelType.TabIndex = 2;
            labelFuelType.Text = "Вид ГСМ:";
            // 
            // checkedListBoxFuelType
            // 
            checkedListBoxFuelType.FormattingEnabled = true;
            checkedListBoxFuelType.Location = new Point(150, 65);
            checkedListBoxFuelType.Name = "checkedListBoxFuelType";
            checkedListBoxFuelType.Size = new Size(200, 94);
            checkedListBoxFuelType.TabIndex = 3;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(25, 180);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(40, 15);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Цена:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(150, 177);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(200, 23);
            numericUpDownPrice.TabIndex = 5;
            numericUpDownPrice.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(75, 225);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(205, 225);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormFuel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 280);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelPrice);
            Controls.Add(checkedListBoxFuelType);
            Controls.Add(labelFuelType);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormFuel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ГСМ";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelName;
        private TextBox textBoxName;
        private Label labelFuelType;
        private CheckedListBox checkedListBoxFuelType;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Button buttonSave;
        private Button buttonCancel;
    }
}