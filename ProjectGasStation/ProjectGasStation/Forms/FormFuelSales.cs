using ProjectGasStation.Repositories;
using Unity;

namespace ProjectGasStation.Forms
{
    public partial class FormFuelSales : Form
    {
        private readonly IUnityContainer _container;

        private readonly IFuelSaleRepository _fuelSaleRepository;

        public FormFuelSales(IUnityContainer container, IFuelSaleRepository fuelSaleRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _fuelSaleRepository = fuelSaleRepository ?? throw new ArgumentNullException(nameof(fuelSaleRepository));
        }

        private void FormFuelSales_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormFuelSale>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridViewData.DataSource = _fuelSaleRepository.ReadFuelSales();
    }
}