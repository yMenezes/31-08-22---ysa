using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class frmCadastro : Form
    {
        // Criando o objeto que representa a conexão
        SqlConnection sqlCon = null;

        //Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30
        private string strCon = "Data Source=LI02-05;Initial Catalog = aula_edson; User ID = sa; password=123456";
        //private string strCon = "Data Source=DESKTOP-AI683CG;Initial Catalog = aula_edson; User ID = sa; password=123456";
        
        private string strSql = "";

        SqlConnection objConect = null; //
        SqlCommand objCommand = null; //

        string campos;
        Produto p = new Produto();

        public frmCadastro()
        {
            InitializeComponent();
        }
        public void preencherObjeto()
        {
            p.Id = Convert.ToInt32(txtID.Text);
            p.Alimento = txtAlimento.Text;
            p.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            p.DataFabricacao = Convert.ToDateTime(txtDataFabricacao.Text);
            p.DataValidade = Convert.ToDateTime(txtDataValidade.Text);
            p.Preco = Convert.ToDouble(txtPreco.Text);

         }


        public void listaGrid() //
        {
            strSql = "Select * from alimentos where ativo = 1";
            objConect = new SqlConnection(strCon);
            objCommand = new SqlCommand(strSql, objConect);

            try
            {
                // pode armazenar varios registros
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                // possibilita jogar os registros em um datagridview
                DataTable dtLista = new DataTable();
                // carregando os registros no datatable
                objAdp.Fill(dtLista);
                dgvAlimentos.DataSource = null; // **** para atualizar o grid
                dgvAlimentos.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Erro no banco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }





        private void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aula_edsonDataSet.alimentos'. Você pode movê-la ou removê-la conforme necessário.
            //this.alimentosTableAdapter.Fill(this.aula_edsonDataSet.alimentos);
            configuraDataGridView();
            listaGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtAlimento.Text == "" || txtQuantidade.Text == "" || txtDataFabricacao.Text == "" || txtDataValidade.Text == "" || txtPreco.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos para fazer o Cadastro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }

            else
            {
                try
                {

                    int ativo = 1;
            
                    // construção da instrução sql de cadastro de registro
                    strSql = "insert into alimentos (ID_alimento, alimento, quantidade, data_fabricacao, data_validade, preco, ativo) values (@ID_alimento, @alimento, @quantidade, @data_fabricacao, @data_validade, @preco, @ativo )";
            
                    // abertura da tabela no sqlcon: objeto que representa o banco de dados
                    sqlCon = new SqlConnection(strCon);
                    // objeto que representa a instrucao sql de cadastro
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);

                    // Adiciona o conteudo do Text na variável do banco de dados
                        Produto  p = new Produto();
                    comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = p.Id;
                    comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = p.Alimento;
                    comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = p.Quantidade;
                    comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = p.DataFabricacao;
                    comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = p.DataValidade;
                    comando.Parameters.Add("@preco", SqlDbType.Real).Value = p.Preco;
                    comando.Parameters.Add("@ativo", SqlDbType.Int).Value = 1;
            
                    // está de fato abrindo a conexao
                    sqlCon.Open();
                    // executar uma instrucao simples de 1 para 1
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso");

                    listaGrid();
    
                    sqlCon.Close();
                    limparTexts();

                }

                catch
                {
                    MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor, digite o ID do produto o qual quer consultar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                try
                {

                

                    strSql = "select * from alimentos where id_alimento = @id_alimento";
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);


                    comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;

                    sqlCon.Open();
                    SqlDataReader dr = comando.ExecuteReader();
                    if(dr.HasRows == true)
                    {
                        dr.Read();
                        txtAlimento.Text = Convert.ToString(dr["alimento"]);
                        txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                        txtDataFabricacao.Text = Convert.ToString(dr["data_fabricacao"]).Substring(0, 10);
                        txtDataValidade.Text = Convert.ToString(dr["data_validade"]).Substring(0, 10);
                        txtPreco.Text = Convert.ToString(dr["preco"]);
                        txtID.Enabled = false;
                        p.Alimento = Convert.ToString(dr["alimento"]);
                        p.Quantidade = Convert.ToInt32(dr["quantidade"]);
                        p.DataFabricacao = Convert.ToDateTime(dr["data_fabricacao"]);
                        p.DataValidade = Convert.ToDateTime(dr["data_validade"]);
                        p.Preco = Convert.ToDouble(dr["preco"]);

                    }
                    else
                    {
                        MessageBox.Show("Registro nao existe");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimparTexts_Click(object sender, EventArgs e)
        {
            limparTexts();
        }

        private void limparTexts()
        {
            txtAlimento.Clear();
            txtDataFabricacao.Clear();
            txtDataValidade.Clear();
            txtID.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtID.Enabled = true;
            txtID.Focus();
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
            listaGrid();

        }

        private void configuraDataGridView()
               {
                   // Configura o cabeçalho
                   dgvAlimentos.Columns[0].HeaderText = "ID";
                   dgvAlimentos.Columns[1].HeaderText = "Alimento";
                   dgvAlimentos.Columns[2].HeaderText = "Quantidade";
                   dgvAlimentos.Columns[3].HeaderText = "Data Fabricação";
                   dgvAlimentos.Columns[4].HeaderText = "Data Validade";
                   dgvAlimentos.Columns[5].HeaderText = "Preço";
               //    dgvAlimentos.Columns[6].HeaderText = "Ativo";

                   // Configura as larguras das colunas
                   dgvAlimentos.Columns[0].Width = 50;
                   dgvAlimentos.Columns[1].Width = 200;
                   dgvAlimentos.Columns[2].Width = 80;
                   dgvAlimentos.Columns[3].Width = 80;
                   dgvAlimentos.Columns[4].Width = 80;
                   dgvAlimentos.Columns[5].Width = 80;
               //    dgvAlimentos.Columns[6].Width = 80;

        }



        private void chkID_Click(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                dgvAlimentos.Columns[0].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[0].Visible = false;

            }
        }

        private void chkAlimento_Click(object sender, EventArgs e)
        {
            if (chkAlimento.Checked)
            {
                dgvAlimentos.Columns[1].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[1].Visible = false;

            }
        }

        private void chkQuantidade_Click(object sender, EventArgs e)
        {
            if (chkQuantidade.Checked)
            {
                dgvAlimentos.Columns[2].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[2].Visible = false;

            }
        }

        private void chkDataFabricacao_Click(object sender, EventArgs e)
        {
            if (chkDataFabricacao.Checked)
            {
                dgvAlimentos.Columns[3].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[3].Visible = false;

            }
        }

        private void chkDataValidade_Click(object sender, EventArgs e)
        {
            if (chkDataValidade.Checked)
            {
                dgvAlimentos.Columns[4].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[4].Visible = false;

            }
        }

        private void chkPreco_Click(object sender, EventArgs e)
        {
            if (chkPreco.Checked)
            {
                dgvAlimentos.Columns[5].Visible = true;
            }
            else
            {
                dgvAlimentos.Columns[5].Visible = false;

            }
        }

        private void chkAtivo_Click(object sender, EventArgs e)
        {
            try
            {

                if (chkAtivo.Checked)
                {
                    dgvAlimentos.Columns[6].Visible = true;
                }
                else
                {
                    dgvAlimentos.Columns[6].Visible = false;

                }
            }

            catch
            {
                MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvAlimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

            
                string idClicado;
                //captura o código
                //MessageBox.Show(Convert.ToString(dgvAlimentos.Rows[e.RowIndex].Cells[0].Value));
                idClicado = Convert.ToString(dgvAlimentos.Rows[e.RowIndex].Cells[0].Value); //17 "17"

                strSql = "select * from alimentos where id_alimento = @id_alimento";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);


                comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = idClicado;

                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
          
                dr.Read();
                txtID.Text = Convert.ToString(dr["id_alimento"]);
                txtAlimento.Text = Convert.ToString(dr["alimento"]);
                txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
                txtDataFabricacao.Text = Convert.ToString(dr["data_fabricacao"]).Substring(0,10);
                txtDataValidade.Text = Convert.ToString(dr["data_validade"]).Substring(0,10);
                txtPreco.Text = Convert.ToString(dr["preco"]);
                txtID.Enabled = false;
                p.Alimento = Convert.ToString(dr["alimento"]);
                p.Quantidade = Convert.ToInt32(dr["quantidade"]);
                p.DataFabricacao = Convert.ToDateTime(dr["data_fabricacao"]);
                p.DataValidade = Convert.ToDateTime(dr["data_validade"]);
                p.Preco = Convert.ToDouble(dr["preco"]);

            }

            catch
            {
                MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {



                // construção da instrução sql de cadastro de registro
                strSql = "update alimentos set alimento = @alimento, quantidade = @quantidade, data_fabricacao = @data_fabricacao, data_validade = @data_validade, preco = @preco where id_alimento = @id_alimento";

                // abertura da tabela no sqlcon: objeto que representa o banco de dados
                sqlCon = new SqlConnection(strCon);
                // objeto que representa a instrucao sql de cadastro
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                // Adiciona co conteudo do Text na variável do banco de dados

                // adicionar o parametro id alimento nestra instrucao do tipo int
                Produto p = new Produto();
                comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = p.Id;
                comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = p.Alimento;
                comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = p.Quantidade;
                comando.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = p.DataFabricacao;
                comando.Parameters.Add("@data_validade", SqlDbType.Date).Value = p.DataValidade;
                comando.Parameters.Add("@preco", SqlDbType.Real).Value = p.Preco;
                comando.Parameters.Add("@ativo", SqlDbType.Int).Value = 1;

                // está de fato abrindo a conexao
                sqlCon.Open();
                // executar uma instrucao simples de 1 para 1
                comando.ExecuteNonQuery();
                //MessageBox.Show("Atualização efetuada com sucesso");
                dgvAlimentos.Refresh();
                listaGrid();
                limparTexts();
            }

            catch
            {
                MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor, selecione o campo que deseja excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // construção da instrução sql de remoção de registro
                    strSql = "delete from Alimentos where id_alimento = @id_alimento";

                    // abertura da tabela no sqlcon: objeto que representa o banco de dados
                    sqlCon = new SqlConnection(strCon);

                    // objeto que representa a instrucao sql de cadastro
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);

                    comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;

                    // está de fato abrindo a conexao
                    sqlCon.Open();
                    // executar uma instrucao simples de 1 para 1
                    comando.ExecuteNonQuery();
                    //MessageBox.Show("Atualização efetuada com sucesso");
                    dgvAlimentos.Refresh();
                    listaGrid();
                    limparTexts();

                    sqlCon.Close();
                }
            }

        }

        private void btnApagarv2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor, selecione o campo que deseja excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    strSql = "update Alimentos set ativo = 0 where id_alimento = @id_alimento";
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand comando = new SqlCommand(strSql, sqlCon);

                    sqlCon.Open();
                    comando.Parameters.Add("@id_alimento", SqlDbType.Int).Value = txtID.Text;
                    comando.ExecuteNonQuery();
                    limparTexts();
                    listaGrid();
                    sqlCon.Close();
                    MessageBox.Show("Registro excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if(txtFab.Text == "  /  /    " && txtVali.Text == "  /  /    ")
            {
                MessageBox.Show("Por favor, preencha todos os campos para fazer a consulta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                strSql = "select * from alimentos where data_fabricacao = @data_fabricacao and data_validade = @data_validade and Ativo = 1";
                objConect = new SqlConnection(strCon);
                objCommand = new SqlCommand(strSql, objConect);
                objCommand.Parameters.Add("@data_fabricacao", SqlDbType.Date).Value = txtFab.Text;
                objCommand.Parameters.Add("@data_validade", SqlDbType.Date).Value = txtVali.Text;

                try
                {
                    // pode armazenar varios registros
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                    // possibilita jogar os registros em um datagridview
                    DataTable dtLista = new DataTable();
                    // carregando os registros no datatable
                    objAdp.Fill(dtLista);
                    dgvAlimentos.DataSource = null; // **** para atualizar o grid
                    dgvAlimentos.DataSource = dtLista;
                }
                catch
                {
                    MessageBox.Show("Erro na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

      
    }
}
