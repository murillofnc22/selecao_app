using SelecaoApp.Domain.Models.Produtos;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.Produtos
{
    public class ProdutosRepository : GenericRepository<ProdutosModel>
    {
        public DataTable BuscaProdutosADO(string busca)
        {
            using (DBEntities db = new DBEntities())
            {
                using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    try
                    {
                        string sql = @"select p.nome, f.nome Fornecedor, quantidade, p.id from Produtos p inner join Fornecedores f on f.id = p.fornecedor where p.nome like @busca or f.nome like @busca";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
                        conn.Open();
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        internal DataTable GetAllProdutosADO()
        {
            using (DBEntities db = new DBEntities())
            {
                using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    string sql = @"select p.nome, f.nome Fornecedor, quantidade, p.id from Produtos p inner join Fornecedores f on f.id = p.fornecedor";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        try
                        {
                            conn.Open();
                            DataTable dt = new DataTable();
                            dt.Load(cmd.ExecuteReader());
                            return dt;
                        }
                        catch { }
                    }
                }
            }
            return null;
        }
    }
}
