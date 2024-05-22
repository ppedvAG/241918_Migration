using EfCoreDbFirst.Data;
using EfCoreDbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwndContext context = new NorthwndContext();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Products.Where(x => x.OrderDetails.Any(y => y.Order.Customer.Country == "Austria")).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Database.SqlQuery<Product>($"SELECT * FROM Products");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.AlphabeticalListOfProducts.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Database.SqlQuery<AAAA>($"exec [Ten Most Expensive Products]").ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Products.Include(x => x.Category).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value is Category cat)
            {
                e.Value = cat.CategoryName;
            }
        }
    }

    class AAAA
    {
        public string TenMostExpensiveProducts { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
