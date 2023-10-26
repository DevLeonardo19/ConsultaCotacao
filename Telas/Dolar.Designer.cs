namespace Cotação.Telas
{
    partial class Dolar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsdpReal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVariacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTotalConversaoUSD = new System.Windows.Forms.TextBox();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.txtValorDolar2 = new System.Windows.Forms.TextBox();
            this.txtValorReal = new System.Windows.Forms.TextBox();
            this.btnRealpUsd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnUsdpReal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsdpReal
            // 
            this.btnUsdpReal.Controls.Add(this.tabPage1);
            this.btnUsdpReal.Controls.Add(this.tabPage2);
            this.btnUsdpReal.Controls.Add(this.tabPage3);
            this.btnUsdpReal.Controls.Add(this.tabPage4);
            this.btnUsdpReal.Location = new System.Drawing.Point(2, 3);
            this.btnUsdpReal.Name = "btnUsdpReal";
            this.btnUsdpReal.SelectedIndex = 0;
            this.btnUsdpReal.Size = new System.Drawing.Size(480, 418);
            this.btnUsdpReal.TabIndex = 0;
            this.btnUsdpReal.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtVariacao);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtVenda);
            this.tabPage1.Controls.Add(this.txtCompra);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cotação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVariacao
            // 
            this.txtVariacao.BackColor = System.Drawing.Color.SlateGray;
            this.txtVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariacao.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVariacao.Location = new System.Drawing.Point(119, 267);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.Size = new System.Drawing.Size(310, 52);
            this.txtVariacao.TabIndex = 7;
            this.txtVariacao.Text = "0%";
            this.txtVariacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Variação: ";
            // 
            // txtVenda
            // 
            this.txtVenda.BackColor = System.Drawing.Color.SlateGray;
            this.txtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVenda.Location = new System.Drawing.Point(119, 198);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(310, 52);
            this.txtVenda.TabIndex = 5;
            this.txtVenda.Text = "0,0";
            this.txtVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCompra
            // 
            this.txtCompra.BackColor = System.Drawing.Color.SlateGray;
            this.txtCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCompra.Location = new System.Drawing.Point(119, 130);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(310, 52);
            this.txtCompra.TabIndex = 4;
            this.txtCompra.Text = "0,0";
            this.txtCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venda: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compra: ";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(352, 334);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 39);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTotalConversaoUSD);
            this.tabPage2.Controls.Add(this.txtValorDolar);
            this.tabPage2.Controls.Add(this.txtUSD);
            this.tabPage2.Controls.Add(this.btnConverter);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USD -> R$";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtTotalConversaoUSD
            // 
            this.txtTotalConversaoUSD.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalConversaoUSD.Enabled = false;
            this.txtTotalConversaoUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConversaoUSD.Location = new System.Drawing.Point(118, 270);
            this.txtTotalConversaoUSD.Name = "txtTotalConversaoUSD";
            this.txtTotalConversaoUSD.Size = new System.Drawing.Size(312, 44);
            this.txtTotalConversaoUSD.TabIndex = 18;
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDolar.Location = new System.Drawing.Point(118, 201);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(312, 44);
            this.txtValorDolar.TabIndex = 17;
            // 
            // txtUSD
            // 
            this.txtUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUSD.Location = new System.Drawing.Point(118, 133);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(312, 44);
            this.txtUSD.TabIndex = 16;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(326, 338);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(104, 39);
            this.btnConverter.TabIndex = 15;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "R$: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "USD: ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 91);
            this.label4.TabIndex = 1;
            this.label4.Text = "USD > R$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtValorConvertido);
            this.tabPage3.Controls.Add(this.txtValorDolar2);
            this.tabPage3.Controls.Add(this.txtValorReal);
            this.tabPage3.Controls.Add(this.btnRealpUsd);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(472, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "R$ -> USD";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.Enabled = false;
            this.txtValorConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorConvertido.Location = new System.Drawing.Point(124, 270);
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.Size = new System.Drawing.Size(312, 44);
            this.txtValorConvertido.TabIndex = 25;
            // 
            // txtValorDolar2
            // 
            this.txtValorDolar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDolar2.Location = new System.Drawing.Point(124, 201);
            this.txtValorDolar2.Name = "txtValorDolar2";
            this.txtValorDolar2.Size = new System.Drawing.Size(312, 44);
            this.txtValorDolar2.TabIndex = 24;
            // 
            // txtValorReal
            // 
            this.txtValorReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorReal.Location = new System.Drawing.Point(124, 133);
            this.txtValorReal.Name = "txtValorReal";
            this.txtValorReal.Size = new System.Drawing.Size(312, 44);
            this.txtValorReal.TabIndex = 23;
            // 
            // btnRealpUsd
            // 
            this.btnRealpUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealpUsd.Location = new System.Drawing.Point(332, 338);
            this.btnRealpUsd.Name = "btnRealpUsd";
            this.btnRealpUsd.Size = new System.Drawing.Size(104, 39);
            this.btnRealpUsd.TabIndex = 22;
            this.btnRealpUsd.Text = "Converter";
            this.btnRealpUsd.UseVisualStyleBackColor = true;
            this.btnRealpUsd.Click += new System.EventHandler(this.btnRealpUsd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "USD: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Valor: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(54, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "R$:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(-11, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 91);
            this.label8.TabIndex = 2;
            this.label8.Text = "R$ > USD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtMedia);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.txtMaximo);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.txtMinimo);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.btnBuscar);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtDataFinal);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtDataInicio);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(472, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Histórico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(-7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 91);
            this.label6.TabIndex = 3;
            this.label6.Text = "Histórico";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data inicial";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicio.Location = new System.Drawing.Point(85, 107);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(138, 22);
            this.txtDataInicio.TabIndex = 24;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Location = new System.Drawing.Point(318, 107);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(138, 22);
            this.txtDataFinal.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(249, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Data final";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "(YYYYMMDD)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "(YYYYMMDD)";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(190, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "Mínimo";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Enabled = false;
            this.txtMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.Location = new System.Drawing.Point(64, 250);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(69, 22);
            this.txtMinimo.TabIndex = 31;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Enabled = false;
            this.txtMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(216, 250);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(69, 22);
            this.txtMaximo.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(160, 253);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "Máximo";
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(369, 250);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(69, 22);
            this.txtMedia.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(313, 253);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 16);
            this.label20.TabIndex = 34;
            this.label20.Text = "Média";
            // 
            // Dolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 414);
            this.Controls.Add(this.btnUsdpReal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dolar";
            this.Text = "Dolar";
            this.Load += new System.EventHandler(this.Dolar_Load);
            this.btnUsdpReal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl btnUsdpReal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label txtVenda;
        private System.Windows.Forms.Label txtCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtVariacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnRealpUsd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtValorReal;
        private System.Windows.Forms.TextBox txtTotalConversaoUSD;
        private System.Windows.Forms.TextBox txtValorDolar;
        private System.Windows.Forms.TextBox txtValorDolar2;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}