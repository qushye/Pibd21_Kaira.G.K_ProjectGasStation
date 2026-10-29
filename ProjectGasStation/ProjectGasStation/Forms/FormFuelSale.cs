using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms
{
    public partial class FormFuelSale : Form
    {
        private readonly IFuelSaleRepository _fuelSaleRepository;

        public FormFuelSale(IFuelSaleRepository fuelSaleRepository, IFuelRepository fuelRepository, ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _fuelSaleRepository = fuelSaleRepository ?? throw new ArgumentNullException(nameof(fuelSaleRepository));

            comboBoxFuel.DataSource = fuelRepository.ReadFuels();
            comboBoxFuel.DisplayMember = "Name";
            comboBoxFuel.ValueMember = "Id";

            comboBoxSeller.DataSource = sellerRepository.ReadSellers();
            comboBoxSeller.DisplayMember = "FirstName";
            comboBoxSeller.ValueMember = "Id";

            comboBoxWorkShift.DataSource = Enum.GetValues(typeof(WorkShift));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFuel.SelectedIndex < 0 ||
                    comboBoxSeller.SelectedIndex < 0 ||
                    comboBoxWorkShift.SelectedIndex < 1)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                _fuelSaleRepository.CreateFuelSale(FuelSale.CreateOperation(0,
                    (int)comboBoxFuel.SelectedValue!,
                    (int)comboBoxSeller.SelectedValue!,
                    (WorkShift)comboBoxWorkShift.SelectedItem!,
                    Convert.ToInt32(numericUpDownQuantity.Value),
                    Convert.ToDouble(numericUpDownTotalSum.Value)));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();
    }
}