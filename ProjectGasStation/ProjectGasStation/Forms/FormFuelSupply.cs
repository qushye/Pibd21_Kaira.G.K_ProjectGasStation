using ProjectGasStation.Entities;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms
{
    public partial class FormFuelSupply : Form
    {
        private readonly IFuelSupplyRepository _fuelSupplyRepository;

        public FormFuelSupply(IFuelSupplyRepository fuelSupplyRepository, ISupplierRepository supplierRepository, ISellerRepository sellerRepository, IFuelRepository fuelRepository)
        {
            InitializeComponent();
            _fuelSupplyRepository = fuelSupplyRepository ?? throw new ArgumentNullException(nameof(fuelSupplyRepository));

            comboBoxSupplier.DataSource = supplierRepository.ReadSuppliers();
            comboBoxSupplier.DisplayMember = "CompanyName";
            comboBoxSupplier.ValueMember = "Id";

            comboBoxSeller.DataSource = sellerRepository.ReadSellers();
            comboBoxSeller.DisplayMember = "FirstName";
            comboBoxSeller.ValueMember = "Id";

            ColumnFuel.DataSource = fuelRepository.ReadFuels();
            ColumnFuel.DisplayMember = "Name";
            ColumnFuel.ValueMember = "Id";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFuels.RowCount < 1 ||
                    comboBoxSupplier.SelectedIndex < 0 ||
                    comboBoxSeller.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                _fuelSupplyRepository.CreateFuelSupply(FuelSupply.CreateOperation(0,
                    (int)comboBoxSupplier.SelectedValue!,
                    (int)comboBoxSeller.SelectedValue!,
                    CreateListFuelSupplyFuelsFromDataGrid()));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private List<FuelSupplyFuel> CreateListFuelSupplyFuelsFromDataGrid()
        {
            var list = new List<FuelSupplyFuel>();
            foreach (DataGridViewRow row in dataGridViewFuels.Rows)
            {
                if (row.Cells["ColumnFuel"].Value == null || row.Cells["ColumnCount"].Value == null)
                {
                    continue;
                }

                list.Add(FuelSupplyFuel.CreateElement(0,
                    Convert.ToInt32(row.Cells["ColumnFuel"].Value),
                    Convert.ToInt32(row.Cells["ColumnCount"].Value)));
            }

            return list;
        }
    }
}