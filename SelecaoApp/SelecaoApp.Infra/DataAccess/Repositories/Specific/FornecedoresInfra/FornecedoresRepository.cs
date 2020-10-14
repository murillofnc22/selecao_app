using SelecaoApp.Domain.Models.FornecedoresModels;
using SelecaoApp.Infra.Configuration;
using SelecaoApp.Infra.DataAccess.Repositories.Specific.Generic;
using SelecaoApp.Services.Services.FornecedoresServices;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace SelecaoApp.Infra.DataAccess.Repositories.Specific.FornecedoresInfra
{
    public class FornecedoresRepository : GenericRepository<Domain.Models.FornecedoresModels.Fornecedores>, IFornecedoresRepository
    {
        public DataTable BuscaFornecedoresADO(string busca)
        {
            using (DBEntities db = new DBEntities())
            {
                using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    try
                    {
                        string sql = @"select id, nome, cnpj, endereco, ativo from Fornecedores where nome like @busca or cnpj like @busca or endereco like @busca";
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

        public DataTable GetAllFornecedoresADO()
        {
            using (DBEntities db = new DBEntities())
            {
                using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    string sql = @"select id, nome, cnpj, endereco, ativo from Fornecedores";
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

        public int GetIdFornecedorByName(string nome)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return data.Set<Domain.Models.FornecedoresModels.Fornecedores>().AsNoTracking().ToList().Where(x => x.nome == nome).FirstOrDefault().id;
            }
                
        }

        public string GetNomeFornecedorById(int id)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return data.Set<Domain.Models.FornecedoresModels.Fornecedores>().AsNoTracking().ToList().Where(x => x.id == id).FirstOrDefault().nome;
            }
        }
    }
}
