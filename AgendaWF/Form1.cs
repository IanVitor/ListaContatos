using System.Data;
using System.IO.Compression;

namespace AgendaWF
{
    public partial class F_Agenda : Form
    {
        public F_Agenda()
        {
            InitializeComponent();
        }

        private void F_Agenda_Load(object sender, EventArgs e)
        {
            DALAgenda.criarBancoSQLite();
            DALAgenda.criarTabelaSQLite();
            exibirDados();
        }
        private void exibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALAgenda.getContatos();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txbId.Text);
                contato.Nome = txbNome.Text;
                contato.Email = txbEmail.Text;
                DALAgenda.Add(contato);
                exibirDados();

                txbId.Clear();
                txbNome.Clear();
                txbEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txbId.Text);
                contato.Nome = txbNome.Text;
                contato.Email = txbEmail.Text;
                DALAgenda.Update(contato);
                exibirDados();

                txbId.Clear();
                txbNome.Clear();
                txbEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                int Id = Convert.ToInt32(txbId.Text);
                DALAgenda.Delete(Id);
                exibirDados();

                txbId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string nome = txbNome.Text;
                dt = DALAgenda.getContato(nome);
                dgvDados.DataSource = dt;
                txbId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}