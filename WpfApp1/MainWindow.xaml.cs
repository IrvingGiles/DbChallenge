using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Procedure> ProList { set; get; }
        public List<Treatment> Treat { set; get; }
        public List<Treatment> Filters { set; get; }

        public MainWindow()
        {
            InitializeComponent();

            ProcedureF();


              
        }

        public async Task ProcedureF
            ()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://webapplication120180629013925.azurewebsites.net/api/ProcedureViews");

            string procedure = "";

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                procedure = await response.Content.ReadAsStringAsync();
            }

            ProList = JsonConvert.DeserializeObject<List<Procedure>>(procedure);

            dg3.ItemsSource = ProList;
        }

        private void dg3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Procedure selectedProcedure = (Procedure)dg3.SelectedItem;

            int PId = selectedProcedure.ProcedureId;

            TreatmentF(PId);
        }

        public async Task TreatmentF(int PId)
        {
            Filters = new List<Treatment>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://webapplication120180629013925.azurewebsites.net/api/TreatmentViews");

            string treatment = "";

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                treatment = await response.Content.ReadAsStringAsync();
            }

            Treat = JsonConvert.DeserializeObject<List<Treatment>>(treatment);

            var filtered = Treat.Where(tr => tr.ProcedureId == PId);
            foreach (var item in filtered)
            {
                Filters.Add(item);
            }

            dg4.ItemsSource = Filters;
        }
    }
}
