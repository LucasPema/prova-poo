using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lucaslopes_3a1_30.code.DAL;
using lucaslopes_3a1_30.code.DTO;


namespace lucaslopes_3a1_30.code.BLL
{
    class LoginBLL
    {
        Conexao conexao = new Conexao();
        string table = "usuarios";

        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {table} where nome = '{loginDTO.Usuario}' and senha = '{loginDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
    }
}
