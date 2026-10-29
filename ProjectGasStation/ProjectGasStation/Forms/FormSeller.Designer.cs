namespace ProjectGasStation.Forms
{
    partial class FormSeller
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
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelWorkShift = new Label();
            comboBoxWorkShift = new ComboBox();
            labelAllowedFuels = new Label();
            checkedListBoxAllowedFuels = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(25, 25);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(35, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(150, 22);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(25, 65);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(60, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(150, 62);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 23);
            textBoxLastName.TabIndex = 3;
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
            // labelAllowedFuels
            // 
            labelAllowedFuels.AutoSize = true;
            labelAllowedFuels.Location = new Point(25, 145);
            labelAllowedFuels.Name = "labelAllowedFuels";
            labelAllowedFuels.Size = new Size(100, 15);
            labelAllowedFuels.TabIndex = 6;
            labelAllowedFuels.Text = "Доступные ГСМ:";
            // 
            // checkedListBoxAllowedFuels
            // 
            checkedListBoxAllowedFuels.FormattingEnabled = true;
            checkedListBoxAllowedFuels.Location = new Point(150, 145);
            checkedListBoxAllowedFuels.Name = "checkedListBoxAllowedFuels";
            checkedListBoxAllowedFuels.Size = new Size(200, 94);
            checkedListBoxAllowedFuels.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(75, 260);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(205, 260);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 315);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxAllowedFuels);
            Controls.Add(labelAllowedFuels);
            Controls.Add(comboBoxWorkShift);
            Controls.Add(labelWorkShift);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormSeller";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Продавец";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelWorkShift;
        private ComboBox comboBoxWorkShift;
        private Label labelAllowedFuels;
        private CheckedListBox checkedListBoxAllowedFuels;
        private Button buttonSave;
        private Button buttonCancel;
    }
}