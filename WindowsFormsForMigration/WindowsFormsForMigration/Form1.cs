using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsForMigration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = new Ping().Send("127.0.0.1");
            MessageBox.Show(res.Status.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(Console.Beep));
            t.Start();
            t.Abort();
        }
    }
}
