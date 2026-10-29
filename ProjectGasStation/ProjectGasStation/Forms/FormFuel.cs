using ProjectGasStation.Entities;
using ProjectGasStation.Entities.Enums;
using ProjectGasStation.Repositories;

namespace ProjectGasStation.Forms
{
    public partial class FormFuel : Form
    {
        private readonly IFuelRepository _fuelRepository;

        private int? _fuelId;

        public int Id
        {
            set
            {
                try
                {
                    var fuel = _fuelRepository.ReadFuelById(value);
                    if (fuel == null)
                    {
                        throw new InvalidDataException(nameof(fuel));
                    }

                    foreach (FuelType elem in Enum.GetValues(typeof(FuelType)))
                    {
                        if ((elem & fuel.FuelType) != 0)
                        {
                            checkedListBoxFuelType.SetItemChecked(checkedListBoxFuelType.Items.IndexOf(elem), true);
                        }
                    }

                    textBoxName.Text = fuel.Name;
                    numericUpDownPrice.Value = (decimal)fuel.Price;
                    _fuelId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormFuel(IFuelRepository fuelRepository)
        {
            InitializeComponent();
            _fuelRepository = fuelRepository ?? throw new ArgumentNullException(nameof(fuelRepository));

            foreach (var elem in Enum.GetValues(typeof(FuelType)))
            {
                checkedListBoxFuelType.Items.Add(elem);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    checkedListBoxFuelType.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }

                if (_fuelId.HasValue)
                {
                    _fuelRepository.UpdateFuel(CreateFuel(_fuelId.Value));
                }
                else
                {
                    _fuelRepository.CreateFuel(CreateFuel(0));
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Fuel CreateFuel(int id)
        {
            FuelType fuelType = FuelType.None;
            foreach (var elem in checkedListBoxFuelType.CheckedItems)
            {
                fuelType |= (FuelType)elem;
            }

            return Fuel.CreateEntity(id, textBoxName.Text, fuelType, Convert.ToDouble(numericUpDownPrice.Value));
        }
    }
}