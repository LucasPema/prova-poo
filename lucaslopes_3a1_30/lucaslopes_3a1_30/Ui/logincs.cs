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

namespace lucaslopes_3a1_30.Ui
{
    public partial class logincs : Form
    {
        public logincs()
        {
            InitializeComponent();
        }

        LoginDTO DTO = new LoginDTO();
        LoginBLL BLL = new LoginBLL();

            private void btn_login_Click(object sender, EventArgs e)
        {
            DTO.Usuario = txt_nome.Text;
            DTO.Senha = txt_senha.Text;

            if (BLL.RealizarLogin(DTO) == true)
            {
                Form1 frmEPA = new Form1();
                frmEPA.ShowDialog();
            }



        }
    }
}
