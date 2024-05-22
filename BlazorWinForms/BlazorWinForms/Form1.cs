using HalloBlazor.Components.Pages;
using HalloBlazor.Data;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddScoped<ICarService, BogusCarService>();
            services.AddWindowsFormsBlazorWebView();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Cars>("#app");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blazorWebView1.BackColor = Color.CadetBlue;
        }
    }
}
