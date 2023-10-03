using DevExpress.XtraCharts;
using sqoClassLibraryAI0502Biblio;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        private int jogador1Pontos = 0;
        private int jogador2Pontos = 0;
        private int jogadas = 0;
        private bool jogadorVez = true;
        private bool salvar = true;
        private string connectionString = @"Provider=SQLOLEDB.1;Password=sequor;Persist Security Info=True;User ID=sa;Initial Catalog=DBJogodaVelha;Data Source=SQO-101\SQLSERVER2019";

        ChartControl chart = new ChartControl();

        public Form1()
        {
            InitializeComponent();

            sqlDataSource2.FillAsync();
        }

        private void ClicarTabuleiro(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "" && salvar == false)
            {
                if (jogadorVez)
                {
                    btn.Text = "X";
                    jogadas++;
                    jogadorVez=false;
                    VerificarResultado(1);
                }
                else
                {
                    btn.Text = "O";
                    jogadas++;
                    jogadorVez=!jogadorVez;
                    VerificarResultado(2);
                }
            }
            else
            {
                MessageBox.Show("Insira os nomes dos jogadores primeiro!");
            }
        }

        private void VerificarResultado(int resultJogador)
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
            {
                if (resultJogador == 1)
                {
                    MessageBox.Show("O ganhador é o jogador  " + txtboxJogador1.Text.ToUpper());
                    jogador1Pontos++;
                    lblPontos1.Text = jogador1Pontos.ToString();
                }
                else
                {
                    MessageBox.Show("O ganhador é o jogador  " + txtboxJogador2.Text.ToUpper());
                    jogador2Pontos++;
                    lblPontos2.Text = jogador2Pontos.ToString();
                }
            }
            else if (jogadas == 9)
            {
                MessageBox.Show("Empate");
            }
   
        }

        private void ZerarJogo(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            txtboxJogador1.Text = "";
            txtboxJogador2.Text = "";
            lblJogador1.Text = "";
            lblJogador2.Text = "";
            lblPontos1.Text = "0";
            lblPontos2.Text = "0";
            jogadas = 0;
            jogador1Pontos = 0;
            jogador2Pontos = 0;
            salvar = true;
        }

        private void btnArmazenarResultados(object sender, EventArgs e)
        {          
            try
            {
                string query = "";

                query += System.Environment.NewLine + "INSERT INTO                         ";
                query += System.Environment.NewLine + "    Table_Jogador                   ";
                query += System.Environment.NewLine + "VALUES(                             ";
                query += System.Environment.NewLine + "    '"  + txtboxJogador1.Text   + "'";
                query += System.Environment.NewLine + "    ,"  + lblPontos1.Text            ;
                query += System.Environment.NewLine + "    ,'" + txtboxJogador2.Text   + "'";
                query += System.Environment.NewLine + "    ,"  +lblPontos2.Text        + ")";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();       
                }
                
                MessageBox.Show("Dados armazenados com sucesso!");
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao conectar no Banco de Dados, verifique os dados e tente novamente" + erro);
            }
        }

        private void FecharGrafico(object sender, EventArgs e)
        {
            gridControl1.Visible  = false;
            btnFecharGrafico.Visible = false;
            this.Controls.Remove(chart);
        }

        private void ExibirGrafico(object sender, EventArgs e)
        { 
            gridControl1.Visible = true;
            btnFecharGrafico.Visible = true;
            List<persistenciaJogodaVelha> listajogadores = GetDadosJogador();
            gridView1.RefreshData();
            gridControl1.DataSource = listajogadores;

            // Create an empty Bar series and add it to the chart.
            Series series = new Series("Series1", ViewType.Bar);
            chart.Series.Clear();
            chart.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = listajogadores;
            chart.DataSource = listajogadores;

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Nome";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Pontos" });

            // Set some properties to get a nice-looking chart.
            ((SideBySideBarSeriesView)series.View).ColorEach = true;
            ((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Dock the chart into its parent and add it to the current form.
            chart.Dock = DockStyle.Right;
            this.Controls.Add(chart);
        }

        private void SalvarJogadores(object sender, EventArgs e)
        {
            if ((txtboxJogador1.Text != "") && (txtboxJogador2.Text != ""))
            {
                string jogador1 = txtboxJogador1.Text.ToUpper();
                string jogador2 = txtboxJogador2.Text.ToUpper();
                lblJogador1.Text = jogador1;
                lblJogador2.Text = jogador2;
                salvar = false;
            }
            else
                MessageBox.Show("Insira um nome para o jogador!");
        }

        private void LimparTabuleiro(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            jogadas = 0;
            salvar = false;
        }

        private List<persistenciaJogodaVelha> GetDadosJogador()
        {
            try
            {
                OleDbConnection connection= new OleDbConnection(connectionString);

                string query = "";
                query += System.Environment.NewLine + "SELECT                           ";
                query += System.Environment.NewLine + "     NOME_JOGADOR1 AS NOME       ";
                query += System.Environment.NewLine + "    ,PONTOS_JOGADOR1 AS PONTOS   ";
                query += System.Environment.NewLine + "FROM                             ";
                query += System.Environment.NewLine + "    Table_Jogador                ";
                query += System.Environment.NewLine + "                                 ";
                query += System.Environment.NewLine + "UNION ALL                        ";
                query += System.Environment.NewLine + "                                 ";
                query += System.Environment.NewLine + "SELECT                           ";
                query += System.Environment.NewLine + "     NOME_JOGADOR2 AS NOME       ";
                query += System.Environment.NewLine + "    , PONTOS_JOGADOR2 AS PONTOS  ";
                query += System.Environment.NewLine + "FROM                             ";
                query += System.Environment.NewLine + "    Table_Jogador                ";
                query += System.Environment.NewLine + "ORDER BY                         ";
                query += System.Environment.NewLine + "                                 ";
                query += System.Environment.NewLine + "    PONTOS DESC                  ";

                connection.Open();

                List<persistenciaJogodaVelha> lista = sqoClassPersistencia.GetListaResultado<persistenciaJogodaVelha>(connection,query);
                
                connection.Close();
                
                return lista;
            }
            catch (Exception erro)
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
