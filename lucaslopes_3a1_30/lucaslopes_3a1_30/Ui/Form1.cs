using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lucaslopes_3a1_30.code.BLL;
using lucaslopes_3a1_30.code.DTO;

namespace lucaslopes_3a1_30
{
    public partial class Form1 : Form
    {
        lojasredeDTO redeDTO = new lojasredeDTO();
        lojasredeBLL redeBLL = new lojasredeBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            redeDTO.Produto = txt_produto.Text;
            redeDTO.Valor = double.Parse(txt_valor.Text);

            redeBLL.Inserir(redeDTO);
            MessageBox.Show("sucesso!");
            redeBLL.Listar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            redeDTO.Codigo = int.Parse(txt_codigo.Text);
            redeDTO.Produto = txt_produto.Text;
            redeDTO.Valor = double.Parse(txt_valor.Text);

            redeBLL.Editar(redeDTO);
            MessageBox.Show("sucesso!");
            redeBLL.Listar();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            redeDTO.Codigo = int.Parse(txt_codigo.Text);
            redeBLL.Exclui(redeDTO);
            MessageBox.Show("sucesso!");
            redeBLL.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_produto.DataSource = redeBLL.Listar();
        }
    }
}
