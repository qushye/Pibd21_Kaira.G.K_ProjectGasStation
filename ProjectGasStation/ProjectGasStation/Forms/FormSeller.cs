using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms
{
    public partial class FormSeller : Form
    {
        private readonly ISellerRepository _sellerRepository;

        private int? _sellerId;

        public int Id
        {
            set
            {
                try
                {
                    var seller = _sellerRepository.ReadSellerById(value);
                    if (seller == null)
                    {
                        throw new InvalidDataException(nameof(seller));
                    }

                    textBoxFirstName.Text = seller.FirstName;
                    textBoxLastName.Text = seller.LastName;
                    comboBoxWorkShift.SelectedItem = seller.WorkShift;

                    foreach (FuelType elem in Enum.GetValues(typeof(FuelType)))
                    {
                        if ((elem & seller.AllowedFuelTypes) != 0)
                        {
                            checkedListBoxAllowedFuels.SetItemChecked(checkedListBoxAllowedFuels.Items.IndexOf(elem), true);
                        }
                    }

                    _sellerId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormSeller(ISellerRepository sellerRepository)
        {
            InitializeComponent();
            _sellerRepository = sellerRepository ?? throw new ArgumentNullException(nameof(sellerRepository));

            comboBoxWorkShift.DataSource = Enum.GetValues(typeof(WorkShift));
            foreach (var elem in Enum.GetValues(typeof(FuelType)))
            {
                checkedListBoxAllowedFuels.Items.Add(elem);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                    comboBoxWorkShift.SelectedIndex < 1 ||
                    checkedListBoxAllowedFuels.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_sellerId.HasValue)
                {
                    _sellerRepository.UpdateSeller(CreateSeller(_sellerId.Value));
                }
                else
                {
                    _sellerRepository.CreateSeller(CreateSeller(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Seller CreateSeller(int id)
        {
            FuelType allowedFuelTypes = FuelType.None;
            foreach (var elem in checkedListBoxAllowedFuels.CheckedItems)
            {
                allowedFuelTypes |= (FuelType)elem;
            }

            return Seller.CreateEntity(id, textBoxFirstName.Text, textBoxLastName.Text, (WorkShift)comboBoxWorkShift.SelectedItem!, allowedFuelTypes);
        }
    }
}