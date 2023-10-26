using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotação.Telas
{
    public partial class Dolar : Form
    {
        public Dolar()
        {
            InitializeComponent();
        }

        private void Dolar_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=78601ff5";

            using (HttpClient client = new HttpClient())
            {

                try
                {
                    var response = client.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;


                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        txtCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:F}", market.Currency.Compra);
                        txtVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:F}", market.Currency.Venda);
                        txtVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variacao / 100);
                    }

                    else
                    {
                        txtCompra.Text = "-";
                        txtVenda.Text = "-";
                        txtVariacao.Text = "-";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("pt-BR");
            double valorUSD = double.Parse(txtUSD.Text);
            double valorDolar = double.Parse(txtValorDolar.Text);
            double resultado = valorUSD * valorDolar;

            txtTotalConversaoUSD.Text = resultado.ToString(culture);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorDolar.Text = txtCompra.Text;
            txtValorDolar2.Text = txtCompra.Text;
        }

        private void btnRealpUsd_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.GetCultureInfo("pt-BR");
            double valorReal = double.Parse(txtValorReal.Text);
            double valorDolar = double.Parse(txtValorDolar2.Text);
            double resultado = valorReal / valorDolar;

            txtValorConvertido.Text = resultado.ToString(culture);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string strURL = $"https://economia.awesomeapi.com.br/json/daily/USD-BRL/?start_date={txtDataInicio.Text}&end_date={txtDataFinal.Text}";

            using (HttpClient client = new HttpClient())
            {

                try
                {
                    var response = client.GetAsync(strURL).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        List<Market_data> market_data = JsonConvert.DeserializeObject<List<Market_data>>(result);
                     
                                

                        if (market_data.Count > 0)
                        {
                            txtMinimo.Text = market_data[0].Minimo.ToString("N3", CultureInfo.GetCultureInfo("pt-BR"));
                            txtMaximo.Text = market_data[0].Maximo.ToString("N3", CultureInfo.GetCultureInfo("pt-BR"));
                        }
                       

                    }

                    else
                    {
                        txtMinimo.Text = "-";
                        txtMaximo.Text = "-";


                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            CultureInfo culture = CultureInfo.GetCultureInfo("pt-BR");

            double maximo = double.Parse(txtMaximo.Text);
            double minimo = double.Parse(txtMinimo.Text);           
            double media = (maximo + minimo) / 2;

            txtMedia.Text = media.ToString();
        }   
    }
}
