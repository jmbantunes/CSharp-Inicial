using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Código que queremos que ele execute quando abre o programa
        }

        private void btn_clique_Click(object sender, EventArgs e)
        {
            //Código que queremos executar ao clicar no botão

            string nome = txt_nome.Text;
            
            //Mandar mensagem para o ecrâ
            MessageBox.Show("Bem vindo " + nome, "Mensagem de Boas Vindas", MessageBoxButtons.OK , MessageBoxIcon.Information);
            //Estrutura da MessageBox -> Texto, título, botões, ícons
         
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //Código que acontece ao clicar no botão Limpar

            //Limpar Caixas de texto através do método Clear()
            txt_nome.Clear();
            txt_apelido.Clear();
            txt_idade.Clear();

            //Limpar Caixas de texto através da propriedade Text
            txt_nome.Text = "";

            //Atribuir valores a caixas de texto através da propriedade Text
            txt_nome.Text = "Alberto";
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Código executado ao clicar na LinkLabel
            System.Diagnostics.Process.Start("www.youtube.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
