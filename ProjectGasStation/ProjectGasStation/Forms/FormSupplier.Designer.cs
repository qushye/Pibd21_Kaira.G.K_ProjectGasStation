namespace ProjectGasStation.Forms
{
    partial class FormSupplier
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
            labelCompanyName = new Label();
            labelContactPhone = new Label();
            textBoxCompanyName = new TextBox();
            textBoxContactPhone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(25, 30);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(105, 15);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Компания:";
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(140, 27);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(210, 23);
            textBoxCompanyName.TabIndex = 1;
            // 
            // labelContactPhone
            // 
            labelContactPhone.AutoSize = true;
            labelContactPhone.Location = new Point(25, 75);
            labelContactPhone.Name = "labelContactPhone";
            labelContactPhone.Size = new Size(60, 15);
            labelContactPhone.TabIndex = 2;
            labelContactPhone.Text = "Телефон:";
            // 
            // textBoxContactPhone
            // 
            textBoxContactPhone.Location = new Point(140, 72);
            textBoxContactPhone.Name = "textBoxContactPhone";
            textBoxContactPhone.Size = new Size(210, 23);
            textBoxContactPhone.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(75, 130);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(205, 130);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 30);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 190);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxContactPhone);
            Controls.Add(labelContactPhone);
            Controls.Add(textBoxCompanyName);
            Controls.Add(labelCompanyName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поставщик";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelCompanyName;
        private TextBox textBoxCompanyName;
        private Label labelContactPhone;
        private TextBox textBoxContactPhone;
        private Button buttonSave;
        private Button buttonCancel;
    }
}