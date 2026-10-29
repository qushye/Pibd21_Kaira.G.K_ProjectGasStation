using ProjectGasStation.Entities;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms
{
    public partial class FormSupplier : Form
    {
        private readonly ISupplierRepository _supplierRepository;

        private int? _supplierId;

        public int Id
        {
            set
            {
                try
                {
                    var supplier = _supplierRepository.ReadSupplierById(value);
                    if (supplier == null)
                    {
                        throw new InvalidDataException(nameof(supplier));
                    }

                    textBoxCompanyName.Text = supplier.CompanyName;
                    textBoxContactPhone.Text = supplier.ContactPhone;
                    _supplierId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormSupplier(ISupplierRepository supplierRepository)
        {
            InitializeComponent();
            _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxContactPhone.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_supplierId.HasValue)
                {
                    _supplierRepository.UpdateSupplier(CreateSupplier(_supplierId.Value));
                }
                else
                {
                    _supplierRepository.CreateSupplier(CreateSupplier(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Supplier CreateSupplier(int id) => Supplier.CreateEntity(id, textBoxCompanyName.Text, textBoxContactPhone.Text);
    }
}