using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;

        // Construtor: construir o objeto que está sendo instanciado com as devidas
        // informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
            var endereco = new Endereco();
            endereco.EnderecoCompleto = "SC";
            enderecoServico.Adicionar(endereco);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EnderecoServico enderecoServico = new EnderecoServico();

        }
    }
}
