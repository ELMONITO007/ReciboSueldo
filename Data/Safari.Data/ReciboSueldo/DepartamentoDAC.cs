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
    public class DepartamentoDAC : DataAccessComponent, IRepository<Departamento>
    {
        public Departamento Create(Departamento entity)
        {
            const string SQL_STATEMENT = "insert into Departamento(Departamento)values(@Departamento)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Departamento", DbType.AnsiString, entity.departamento);



            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Departamento set activo=0 where id_Departamento=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Departamento Load(IDataReader dr)
        {
            Departamento departamento = new Departamento();

            departamento.Id = GetDataValue<int>(dr, "Id_departamento");
            departamento.departamento = GetDataValue<string>(dr, "departamento");

            return departamento;
        }

        public List<Departamento> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Departamento where activo=1 ";

            List<Departamento> result = new List<Departamento>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Departamento departamento = Load(dr);
                        result.Add(departamento);
                    }
                }
            }
            return result;
        }

        public Departamento ReadBy(int id)
        {

            const string SQL_STATEMENT = "SELECT * FROM Departamento where activo=1 and id_Departamento=@Id ";
            Departamento departamento = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        departamento = Load(dr);
                    }
                }
                return departamento;
            }
        }

        public Departamento ReadBy(Departamento entity)
        {
            const string SQL_STATEMENT = "SELECT * FROM Departamento where activo=1 and Departamento=@Id ";
            Departamento departamento = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.departamento);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        departamento = Load(dr);
                    }
                }
                return departamento;
            }
        }


        public void Update(Departamento entity)
        {
            const string SQL_STATEMENT = "update empresa set Departamento=@Departamento where id_Departamento=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Departamento", DbType.String, entity.departamento);
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
