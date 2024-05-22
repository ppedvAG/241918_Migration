namespace HalloEfCore
{
    public partial class Form1 : Form
    {
        EfContext context = new EfContext();

        public Form1()
        {
            InitializeComponent();

            context.Database.EnsureCreated();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Cars.Where(x => x.KW > 5).ToList();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            var newCar = new Car() { Model = "NEU", Manufacturer = "NEW", KW = 200 };
            context.Cars.Add(newCar);
            context.SaveChanges();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }


    }
}
