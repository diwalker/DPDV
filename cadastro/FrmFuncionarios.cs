using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DPDV.cadastro
{
    public partial class FrmFuncionarios : Form
    {
        conexao con = new conexao();
        string sql;
        SQLiteCommand cmd;
        string foto;


        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }


            if (txtCpf.Text == "   ,   ,   -" || txtCpf.Text.Length < 14)
            {
                MessageBox.Show("Preencha o campo CPF", "Cadastro Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            con.AbrirConexao();
            sql = "INSERT INTO funcionarios(nome, cpf, endereco, tel, cargo, foto, data) VALUES (@nome, @cpf, @endereco, @tel, @cargo, @foto, date('now'))";

            cmd = new SQLiteCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEnd.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@cargo", cbCargo.Text);
            cmd.Parameters.AddWithValue("@foto", img());
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparFoto();
            //Listar();

            MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro de Funcinários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            Listar();
            DesabilitarCampos();
            LimparCampos();


        }



        private byte[] img()
        {
            byte[] imagem_byte = null;
            if (string.IsNullOrEmpty(foto)) // Verifica se a variável foto está vazia ou nula
            {
                return new byte[0]; // Retorna um array vazio ao invés de null
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }

        private void LimparFoto()
        {
            if (image != null) // Verifica se o objeto image é válido
            {
                image.Image = Properties.Resources.pngegg;
                foto = "img/pngegg.png";
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            Listar();

        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY nome asc";
            cmd = new SQLiteCommand(sql, con.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
            FormatarGD();

        }

        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                Image originalImage = Image.FromFile(foto);

                // Redimensionar a imagem para o tamanho do PictureBox
                Image resizedImage = originalImage.GetThumbnailImage(image.Width, image.Height, null, IntPtr.Zero);

                // Atribuir a imagem redimensionada ao PictureBox
                image.Image = resizedImage;

                // Dispose da imagem original (para liberar recursos)
                originalImage.Dispose();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtNome.Focus();
        }

        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtEnd.Enabled = true;
            txtTel.Enabled = true;
            image.Enabled = true;
            cbCargo.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEnd.Text = "";
            txtTel.Text = "";
            cbCargo.Text = "";
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEnd.Enabled = false;
            txtTel.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void FormatarGD()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Colaborador";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "Telefone";
            grid.Columns[5].HeaderText = "Imagem";
            grid.Columns[6].HeaderText = "Data";
            grid.Columns[7].HeaderText = "Cargo";

            grid.Columns[0].Width = 50;
            grid.Columns[6].Width = 50;
            grid.Columns[0].Visible = false;
            grid.Columns[7].Visible = false;
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                habilitarCampos();
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtCpf.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtEnd.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txtTel.Text = grid.CurrentRow.Cells[4].Value.ToString();
                cbCargo.Text = grid.CurrentRow.Cells[7].Value.ToString();

                if (grid.CurrentRow.Cells[5].Value != DBNull.Value)
                {
                    if (grid.CurrentRow.Cells[5].Value is byte[] imagem)
                    {
                        MemoryStream ms = new MemoryStream(imagem);
                        image.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        // Lógica para lidar com o valor não esperado da célula
                    }
                }
                else
                {
                    image.Image = Properties.Resources.pngegg;
                }



            }


        }
    } }
