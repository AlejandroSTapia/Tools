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
        //const priv para url del rest
        private const string Url = "https://randomapi.com/api/6de6abfedb24f889e0b5f675edc50deb?fmt=raw&sole";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<RandomApiModel> _post;

        public RandomApi()
        {
            InitializeComponent();
        }

        //metodo asyncrono
        protected override async void OnAppearing()
        {
            //Obtencion del contenido de url
            string content = await client.GetStringAsync(Url);

            //Deserializacion del cont en var post
            List<RandomApiModel> post = JsonConvert.DeserializeObject<List<RandomApiModel>>(content);

            //Se manda post en un observable y su contenido en _post para llenado del modelo
            _post = new ObservableCollection<RandomApiModel>(post);

            //llamamos al listview y llenamos su item
            RandomListV.ItemsSource = _post;
            base.OnAppearing();
        }
    }
}