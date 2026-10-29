using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectGasStation
{
    partial class FormGasStation
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
            menuStripMain = new MenuStrip();
            directoriesToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            sellersToolStripMenuItem = new ToolStripMenuItem();
            fuelsToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            fuelSalesToolStripMenuItem = new ToolStripMenuItem();
            fuelSuppliesToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain";
            // 
            // directoriesToolStripMenuItem
            // 
            directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem, sellersToolStripMenuItem, fuelsToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Size = new Size(94, 20);
            directoriesToolStripMenuItem.Text = "Справочники";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(180, 22);
            suppliersToolStripMenuItem.Text = "Поставщики";
            suppliersToolStripMenuItem.Click += SuppliersToolStripMenuItem_Click;
            // 
            // sellersToolStripMenuItem
            // 
            sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            sellersToolStripMenuItem.Size = new Size(180, 22);
            sellersToolStripMenuItem.Text = "Продавцы";
            sellersToolStripMenuItem.Click += SellersToolStripMenuItem_Click;
            // 
            // fuelsToolStripMenuItem
            // 
            fuelsToolStripMenuItem.Name = "fuelsToolStripMenuItem";
            fuelsToolStripMenuItem.Size = new Size(180, 22);
            fuelsToolStripMenuItem.Text = "ГСМ";
            fuelsToolStripMenuItem.Click += FuelsToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuelSalesToolStripMenuItem, fuelSuppliesToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(75, 20);
            operationsToolStripMenuItem.Text = "Операции";
            // 
            // fuelSalesToolStripMenuItem
            // 
            fuelSalesToolStripMenuItem.Name = "fuelSalesToolStripMenuItem";
            fuelSalesToolStripMenuItem.Size = new Size(210, 22);
            fuelSalesToolStripMenuItem.Text = "Продажи ГСМ";
            fuelSalesToolStripMenuItem.Click += FuelSalesToolStripMenuItem_Click;
            // 
            // fuelSuppliesToolStripMenuItem
            // 
            fuelSuppliesToolStripMenuItem.Name = "fuelSuppliesToolStripMenuItem";
            fuelSuppliesToolStripMenuItem.Size = new Size(210, 22);
            fuelSuppliesToolStripMenuItem.Text = "Пополнения запасов ГСМ";
            fuelSuppliesToolStripMenuItem.Click += FuelSuppliesToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(60, 20);
            reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // FormGasStation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormGasStation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автозаправочная станция";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStripMain;
        private ToolStripMenuItem directoriesToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem sellersToolStripMenuItem;
        private ToolStripMenuItem fuelsToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem fuelSalesToolStripMenuItem;
        private ToolStripMenuItem fuelSuppliesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}