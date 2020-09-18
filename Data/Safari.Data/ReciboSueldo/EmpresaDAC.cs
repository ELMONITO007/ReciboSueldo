using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EmpresaDAC : DataAccessComponent, IRepository<Empresa>
    {

        public Empresa Load(IDataReader dr)
        {
            Empresa empresa = new Empresa();

            empresa.Id = GetDataValue<int>(dr, "Id_Empresa");
            empresa.empresa = GetDataValue<string>(dr, "Empresa");
            empresa.cuit= GetDataValue<string>(dr, "cuit");
            empresa.direccion= GetDataValue<string>(dr, "direccion");
            return empresa;
        }

        public Empresa Create(Empresa entity)
        {
            const string SQL_STATEMENT = "insert into empresa(empresa,cuit,direccion,activo)values(@empresa,@cuit,@direccion,1)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Empresa", DbType.AnsiString, entity.empresa);

                db.AddInParameter(cmd, "@Cuit", DbType.Int64, entity.cuit);
                db.AddInParameter(cmd, "@direccion", DbType.AnsiString, entity.direccion);

            }
            return entity;
        }

        public void Delete(int id)
        {

            const string SQL_STATEMENT = "update empresa set activo=0 where id_Empresa=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

      
        public List<Empresa> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM empresa where activo=1 ";

            List<Empresa> result = new List<Empresa>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Empresa empresa = Load(dr);
                        result.Add(empresa);
                    }
                }
            }
            return result;
        }

        public Empresa ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM empresa where activo=1 and id_Empresa=@Id ";
            Empresa empresa = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        empresa = Load(dr);
                    }
                }
                return empresa;
            }
        }
        public Empresa ReadBy(Empresa entity)
        {
            const string SQL_STATEMENT = "SELECT * FROM empresa where activo=1 and Empresa=@Id ";
            Empresa empresa = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.empresa);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        empresa = Load(dr);
                    }
                }
                return empresa;
            }
        }
        public void Update(Empresa entity)
        {
            const string SQL_STATEMENT = "update empresa set empresa=@Empresa, cuit=@Cuit, direccion=@direccion where id_Empresa=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Empresa", DbType.String, entity.empresa);
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@Cuit", DbType.Int64, entity.cuit);
                db.AddInParameter(cmd, "@direccion", DbType.AnsiString, entity.direccion);
                db.ExecuteNonQuery(cmd);
            }
        }

       
    }
}
