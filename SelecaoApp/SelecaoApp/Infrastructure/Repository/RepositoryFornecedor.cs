﻿using SelecaoApp.Domain.Interfaces.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SelecaoApp.Infrastructure.Repository.Generic
{
    //public class RepositoryFornecedor : RepositoryGeneric<Fornecedores>, IGeneric<Fornecedores>
    //{
    //    public DataTable BuscaFornecedoresADO(string busca)
    //    {
    //        using (DBEntities db = new DBEntities())
    //        {
    //            using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
    //            {
    //                try
    //                {
    //                    string sql = @"select id, nome, cnpj, endereco, ativo from Fornecedores where nome like @busca or cnpj like @busca or endereco like @busca";
    //                    SqlCommand cmd = new SqlCommand(sql, conn);
    //                    cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
    //                    conn.Open();
    //                    DataTable dt = new DataTable();
    //                    dt.Load(cmd.ExecuteReader());
    //                    return dt;
    //                }
    //                catch (Exception e)
    //                {
    //                    throw e;
    //                }
    //            }
    //        }
    //    }

    //    internal DataTable GetAllFornecedoresADO()
    //    {
    //        using (DBEntities db = new DBEntities())
    //        {
    //            using (SqlConnection conn = new SqlConnection(db.Database.Connection.ConnectionString))
    //            {
    //                string sql = @"select id, nome, cnpj, endereco, ativo from Fornecedores";
    //                using (SqlCommand cmd = new SqlCommand(sql, conn))
    //                {
    //                    try
    //                    {
    //                        conn.Open();
    //                        DataTable dt = new DataTable();
    //                        dt.Load(cmd.ExecuteReader());
    //                        return dt;
    //                    }
    //                    catch { }
    //                }
    //            }
    //        }
    //        return null;
    //    }
    //}
}