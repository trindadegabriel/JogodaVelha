namespace Jogo_da_Velha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery6 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column30 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression30 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table_JogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtboxJogador1 = new System.Windows.Forms.TextBox();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.txtboxJogador2 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovaRodada = new System.Windows.Forms.Button();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblPontos1 = new System.Windows.Forms.Label();
            this.lblPontos2 = new System.Windows.Forms.Label();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.btnVisualizarGrafico = new System.Windows.Forms.Button();
            this.btnArmazenar = new System.Windows.Forms.Button();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnFecharGrafico = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pontos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table_JogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // table_JogadorBindingSource
            // 
            this.table_JogadorBindingSource.DataMember = "Table_Jogador";
            this.table_JogadorBindingSource.DataSource = this.sqlDataSource2;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "localhost_DBJogodaVelha_Connection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression26.ColumnName = "ID_JOGADOR";
            table6.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"167\" />";
            table6.Name = "Table_Jogador";
            columnExpression26.Table = table6;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "NOME_JOGADOR1";
            columnExpression27.Table = table6;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "PONTOS_JOGADOR1";
            columnExpression28.Table = table6;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "NOME_JOGADOR2";
            columnExpression29.Table = table6;
            column29.Expression = columnExpression29;
            columnExpression30.ColumnName = "PONTOS_JOGADOR2";
            columnExpression30.Table = table6;
            column30.Expression = columnExpression30;
            selectQuery6.Columns.Add(column26);
            selectQuery6.Columns.Add(column27);
            selectQuery6.Columns.Add(column28);
            selectQuery6.Columns.Add(column29);
            selectQuery6.Columns.Add(column30);
            selectQuery6.Name = "Table_Jogador";
            selectQuery6.Tables.Add(table6);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery6});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 169);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(332, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 169);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(542, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 169);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(122, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 169);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(332, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 169);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(542, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 169);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(122, 421);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(204, 169);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(332, 421);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(204, 169);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(542, 421);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(204, 169);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ClicarTabuleiro);
            // 
            // txtboxJogador1
            // 
            this.txtboxJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxJogador1.Location = new System.Drawing.Point(860, 117);
            this.txtboxJogador1.Name = "txtboxJogador1";
            this.txtboxJogador1.Size = new System.Drawing.Size(204, 35);
            this.txtboxJogador1.TabIndex = 9;
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadores.Location = new System.Drawing.Point(791, 71);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(353, 29);
            this.lblJogadores.TabIndex = 10;
            this.lblJogadores.Text = "Insira o nome dos jogadores:";
            // 
            // txtboxJogador2
            // 
            this.txtboxJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxJogador2.Location = new System.Drawing.Point(860, 174);
            this.txtboxJogador2.Name = "txtboxJogador2";
            this.txtboxJogador2.Size = new System.Drawing.Size(204, 35);
            this.txtboxJogador2.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(892, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 51);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.SalvarJogadores);
            // 
            // btnNovaRodada
            // 
            this.btnNovaRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaRodada.Location = new System.Drawing.Point(122, 632);
            this.btnNovaRodada.Name = "btnNovaRodada";
            this.btnNovaRodada.Size = new System.Drawing.Size(204, 66);
            this.btnNovaRodada.TabIndex = 13;
            this.btnNovaRodada.Text = "Nova Rodada";
            this.btnNovaRodada.UseVisualStyleBackColor = true;
            this.btnNovaRodada.Click += new System.EventHandler(this.LimparTabuleiro);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.Location = new System.Drawing.Point(963, 334);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(101, 29);
            this.lblPontos.TabIndex = 14;
            this.lblPontos.Text = "Pontos:";
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(843, 386);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(146, 29);
            this.lblJogador1.TabIndex = 15;
            this.lblJogador1.Text = "Jogador 1 -";
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(843, 445);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(146, 29);
            this.lblJogador2.TabIndex = 16;
            this.lblJogador2.Text = "Jogador 2 -";
            // 
            // lblPontos1
            // 
            this.lblPontos1.AutoSize = true;
            this.lblPontos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos1.Location = new System.Drawing.Point(998, 386);
            this.lblPontos1.Name = "lblPontos1";
            this.lblPontos1.Size = new System.Drawing.Size(27, 29);
            this.lblPontos1.TabIndex = 17;
            this.lblPontos1.Text = "0";
            // 
            // lblPontos2
            // 
            this.lblPontos2.AutoSize = true;
            this.lblPontos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos2.Location = new System.Drawing.Point(998, 445);
            this.lblPontos2.Name = "lblPontos2";
            this.lblPontos2.Size = new System.Drawing.Size(27, 29);
            this.lblPontos2.TabIndex = 18;
            this.lblPontos2.Text = "0";
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(332, 632);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(204, 66);
            this.btnNovoJogo.TabIndex = 19;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.ZerarJogo);
            // 
            // btnVisualizarGrafico
            // 
            this.btnVisualizarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarGrafico.Location = new System.Drawing.Point(332, 720);
            this.btnVisualizarGrafico.Name = "btnVisualizarGrafico";
            this.btnVisualizarGrafico.Size = new System.Drawing.Size(204, 66);
            this.btnVisualizarGrafico.TabIndex = 20;
            this.btnVisualizarGrafico.Text = "Visualizar Gráfico";
            this.btnVisualizarGrafico.UseVisualStyleBackColor = true;
            this.btnVisualizarGrafico.Click += new System.EventHandler(this.ExibirGrafico);
            // 
            // btnArmazenar
            // 
            this.btnArmazenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmazenar.Location = new System.Drawing.Point(542, 632);
            this.btnArmazenar.Name = "btnArmazenar";
            this.btnArmazenar.Size = new System.Drawing.Size(204, 66);
            this.btnArmazenar.TabIndex = 21;
            this.btnArmazenar.Text = "Armazenar Resultados";
            this.btnArmazenar.UseVisualStyleBackColor = true;
            this.btnArmazenar.Click += new System.EventHandler(this.btnArmazenarResultados);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // btnFecharGrafico
            // 
            this.btnFecharGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharGrafico.Location = new System.Drawing.Point(1145, 785);
            this.btnFecharGrafico.Name = "btnFecharGrafico";
            this.btnFecharGrafico.Size = new System.Drawing.Size(204, 66);
            this.btnFecharGrafico.TabIndex = 33;
            this.btnFecharGrafico.Text = "Fechar Gráfico";
            this.btnFecharGrafico.UseVisualStyleBackColor = true;
            this.btnFecharGrafico.Visible = false;
            this.btnFecharGrafico.Click += new System.EventHandler(this.FecharGrafico);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.table_JogadorBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(848, 524);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(275, 327);
            this.gridControl1.TabIndex = 48;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nome,
            this.Pontos});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintGroupFooter = false;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.FieldName = "Nome";
            this.Nome.MinWidth = 30;
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 0;
            this.Nome.Width = 112;
            // 
            // Pontos
            // 
            this.Pontos.Caption = "Pontos";
            this.Pontos.FieldName = "Pontos";
            this.Pontos.MinWidth = 30;
            this.Pontos.Name = "Pontos";
            this.Pontos.Visible = true;
            this.Pontos.VisibleIndex = 1;
            this.Pontos.Width = 112;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.Name = "sqlDataSource3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1826, 877);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnFecharGrafico);
            this.Controls.Add(this.btnArmazenar);
            this.Controls.Add(this.btnVisualizarGrafico);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lblPontos2);
            this.Controls.Add(this.lblPontos1);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.btnNovaRodada);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtboxJogador2);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.txtboxJogador1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_JogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtboxJogador1;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.TextBox txtboxJogador2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovaRodada;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblPontos1;
        private System.Windows.Forms.Label lblPontos2;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Button btnVisualizarGrafico;
        private System.Windows.Forms.Button btnArmazenar;
        private System.Windows.Forms.BindingSource table_JogadorBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Button btnFecharGrafico;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Pontos;
    }
}

