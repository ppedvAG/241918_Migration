using System.Reflection;

namespace HalloWinForms8
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            button1_Click(null, null);
            dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add(nameof(TextBox.Text), bs, nameof(Person.Name));
            dateTimePicker1.DataBindings.Add(nameof(DateTimePicker.Value), bs, nameof(Person.GebDatum));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> data =
            [
                new() { Id = 1, Name = "Fred", GebDatum = new DateTime(2000, 2, 2) },
                new() { Id = 2, Name = "Wilma", GebDatum = new DateTime(2000, 3, 3) },
                new() { Id = 3, Name = "Barney", GebDatum = new DateTime(2000, 4, 4) }
            ];

            bs.DataSource = data;
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime GebDatum { get; set; }
    }
}
