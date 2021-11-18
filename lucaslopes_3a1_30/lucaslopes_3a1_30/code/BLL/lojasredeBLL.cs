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
    class lojasredeBLL
    {
        Conexao conexao = new Conexao();
        string table = "rede";


        public void Inserir(lojasredeDTO redeDTO)
        {
            string inserir = $"insert into {table} value (null, '{redeDTO.Produto}', '{redeDTO.Valor}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(lojasredeDTO redeDTO)
        {
            string alterar = $"update {table} set produto = '{redeDTO.Produto}', valor = '{redeDTO.Valor}'," +
                $" where codigo = '{redeDTO.Codigo}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(lojasredeDTO redeDTO)
        {
            string excluir = $"delete from {table} where codigo = '{redeDTO.Codigo}'";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {table} order by codigo;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
