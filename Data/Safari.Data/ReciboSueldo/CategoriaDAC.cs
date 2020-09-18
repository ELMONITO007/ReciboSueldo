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
    public class CategoriaDAC : DataAccessComponent, IRepository<Categoria>
    {
        public Categoria Create(Categoria entity)
        {
            const string SQL_STATEMENT = "insert into Categoria(Categoria,activo)values(@Categoria,1)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Categoria", DbType.AnsiString, entity.categoria);



            }
            return entity;
        }

        public void Delete(int id)
        {

            const string SQL_STATEMENT = "update Categoria set activo=0 where id_Categoria=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Categoria Load(IDataReader dr)
        {
            Categoria categoria = new Categoria();

            categoria.Id = GetDataValue<int>(dr, "Id_categoria");
            categoria.categoria = GetDataValue<string>(dr, "categoria");

            return categoria;
        }

        public List<Categoria> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Categoria where activo=1 ";

            List<Categoria> result = new List<Categoria>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Categoria categoria = Load(dr);
                        result.Add(categoria);
                    }
                }
            }
            return result;
        }

        public Categoria ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Categoria where activo=1 and id_Categoria=@Id ";
            Categoria categoria = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        categoria = Load(dr);
                    }
                }
                return categoria;
            }
        }

        public Categoria ReadBy(Categoria entity)
        {
            const string SQL_STATEMENT = "SELECT * FROM Categoria where activo=1 and Categoria=@Id ";
            Categoria categoria = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.categoria);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        categoria = Load(dr);
                    }
                }
                return categoria;
            }
        }

        public void Update(Categoria entity)
        {
            const string SQL_STATEMENT = "update Categoria set Categoria=@Categoria where id_Categoria=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Categoria", DbType.String, entity.categoria);
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
