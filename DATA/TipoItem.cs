using Entities;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class TipoItemDAC : Data.DataAccessComponent, Data.IRepository<TipoItem>
    {
        public TipoItem Create(TipoItem entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TipoItem Load(IDataReader dr)
        {
            TipoItem division = new TipoItem();

            division.Id = GetDataValue<int>(dr, "id_tipoItem");
            division.tipoItem = GetDataValue<string>(dr, "tipoItem");

            return division;
        }

        public List<TipoItem> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM TipoItem where activo=1 ";

            List<TipoItem> result = new List<TipoItem>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        TipoItem division = Load(dr);
                        result.Add(division);
                    }
                }
            }
            return result;
        }

        public TipoItem ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM TipoItem where activo=1 and id_TipoItem=@Id ";
            TipoItem division = null;

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

        public TipoItem ReadBy(TipoItem entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
