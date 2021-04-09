using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class frmCompromisso : Form {
        public frmCompromisso() {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                Compromissos compromisso = new Compromissos();
                compromisso.Data = txtData.Value;
                compromisso.Hora = TimeSpan.Parse(txtHora.Text);
                compromisso.Descricao = txtDescricao.Text;

                compromisso.Gravar();

                MessageBox.Show("Compromisso agendado com sucesso!",
                                "Informação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch {
                MessageBox.Show("Erro ao salvar compromisso!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
#pragma warning disable CS1022 // Definição de namespace ou tipo, ou final do arquivo esperado
#pragma warning disable CS1022 // Definição de namespace ou tipo, ou final do arquivo esperado
    }
}
#pragma warning restore CS1022 // Definição de namespace ou tipo, ou final do arquivo esperado
#pragma warning restore CS1022 // Definição de namespace ou tipo, ou final do arquivo esperado