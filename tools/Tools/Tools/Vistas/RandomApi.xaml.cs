using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tools.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tools.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RandomApi : ContentPage
    {

        private const string Url = "https://randomapi.com/api/6de6abfedb24f889e0b5f675edc50deb?fmt=raw&sole";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<RandomApiModel> _post;

        public RandomApi()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<RandomApiModel> post = JsonConvert.DeserializeObject<List<RandomApiModel>>(content);
            _post = new ObservableCollection<RandomApiModel>(post);
            RandomListV.ItemsSource = _post;
            base.OnAppearing();
        }
    }
}