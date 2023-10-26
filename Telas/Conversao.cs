using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Cotação.Telas
{
    public partial class Conversao : Form
    {
        private Dictionary<string, CurrencyData> conversaoData;

        public Conversao()
        {
            InitializeComponent();
            conversaoData = new Dictionary<string, CurrencyData>();
        }

        private void cboDaMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Conversao_Load(object sender, EventArgs e)
        {
            cboDaMoeda.Items.Add("EUR");
            cboDaMoeda.Items.Add("USD");
            cboDaMoeda.Items.Add("BRL");
            cboDaMoeda.Items.Add("ARS");

            cboParaMoeda.Items.Add("EUR");
            cboParaMoeda.Items.Add("USD");
            cboParaMoeda.Items.Add("BRL");
            cboParaMoeda.Items.Add("ARS");
        }

        private void cboParaMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            string strURL = $"https://economia.awesomeapi.com.br/last/{cboDaMoeda.SelectedItem}-{cboParaMoeda.SelectedItem}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(strURL);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Dictionary<string, CurrencyData>>(result);
                        
                        if (data != null)
                        {
                            string chaveMoeda = $"{cboDaMoeda.SelectedItem}{cboParaMoeda.SelectedItem}";

                            if (data.ContainsKey(chaveMoeda))
                            {
                                var currencyData = data[chaveMoeda];
                                txtEquivaleA.Text = currencyData.bid.ToString();

                                txtParaMoeda.Text = cboParaMoeda.SelectedItem.ToString();
                                txtDeMoeda.Text = cboDaMoeda.SelectedItem.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}
