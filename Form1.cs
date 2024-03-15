using ArticlesPricesWfBlazor.Components.Layout;
using ArticlesPricesWfBlazor.Components.Pages;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
using ArticlesPricesWfBlazor.Components.Pages;
using Google.Protobuf.WellKnownTypes;
using System.Text.Json;
using ERP.Backend.Models;
using ERP.Backend.gRPCCodeFirst.Interfaces;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;


namespace ArticlesPricesWfBlazor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<ArticlePages>("#app");
            //blazorWebView1.RootComponents.Add<NavMenu>("#app");
        }

        private void blazorWebView1_Click(object sender, EventArgs e)
        {

        }

        private List<int> selectedArticles = new List<int>();
        private Article currentArticle = new Article();

        private async Task GetArticlebyId(Int32Value id)
        {
            using (var channel = GrpcChannel.ForAddress("http://localhost:5198"))
            {
                var client = channel.CreateGrpcService<IArtikelDistributedService>();
                var reply = await client.GetArticleById(id);
                currentArticle = reply;
            }
        }
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string jsonDataName;
            string jsonDataBrand;
            foreach (var selectedId in selectedArticles)
            {
                Int32Value id = new Int32Value { Value = selectedId };
                await GetArticlebyId(id);
                 jsonDataName = JsonSerializer.Serialize(currentArticle.Name);
                 jsonDataBrand = JsonSerializer.Serialize(currentArticle.Brand);

                MessageBox.Show(jsonDataName + " " + jsonDataBrand);
            }
            MessageBox.Show("Je suis a la maison");
        }
    }
}
