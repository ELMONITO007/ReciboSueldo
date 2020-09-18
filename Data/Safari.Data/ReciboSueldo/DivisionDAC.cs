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
    public class DivisionDAC : DataAccessComponent, IRepository<Division>
    {
        public Division Create(Division entity)
        {
            const string SQL_STATEMENT = "insert into Division(Division)values(@Division)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Division", DbType.AnsiString, entity.division);

              

            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Division set activo=0 where id_Division=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Division Load(IDataReader dr)
        {
            Division division = new Division();

            division.Id = GetDataValue<int>(dr, "Id_Empresa");
            division.division = GetDataValue<string>(dr, "division");
 
            return division;
        }

        public List<Division> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM division where activo=1 ";

            List<Division> result = new List<Division>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Division division = Load(dr);
                        result.Add(division);
                    }
                }
            }
            return result;
        }

        public Division ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Division where activo=1 and id_Division=@Id ";
            Division division = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        division = Load(dr);
                    }
                }
                return division;
            }
        }


        public Division ReadBy(Division entity)
        {
            const string SQL_STATEMENT = "SELECT * FROM Division where activo=1 and Division=@Id ";
            Division division = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.division);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        division = Load(dr);
                    }
                }
                return division;
            }
        }

        public void Update(Division entity)
        {
            const string SQL_STATEMENT = "update empresa set Division=@Division where id_Empresa=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Empresa", DbType.String, entity.division);
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
               
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
