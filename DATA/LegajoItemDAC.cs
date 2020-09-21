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
  public  class LegajoItemDAC :Data.DataAccessComponent
    {
        public LegajoItem Load(IDataReader dr)
        {
            LegajoItem legajoItem = new LegajoItem();

            legajoItem.item.Id = GetDataValue<int>(dr, "Id_Item");
            legajoItem.ReciboSueldo.Id = GetDataValue<int>(dr, "ID_ReciboSueldo");
            legajoItem.valor= GetDataValue<int>(dr, "valor");
            return legajoItem;
        }
        public bool Agregar(LegajoItem legajoItem)

        {
           
                const string SQL_STATEMENT = "insert into LegajoItem(ID_Item,ID_ReciboSueldo,valor)values (@ID_Item,@ID_ReciboSueldo,@valor)";

                var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
                using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
                {
                    db.AddInParameter(cmd, "@ID_ReciboSueldo", DbType.Int32, legajoItem.ReciboSueldo.listaReciboSueldo[0].Id);
                    db.AddInParameter(cmd, "@ID_Item", DbType.Int32, legajoItem.item.Id);
                    db.AddInParameter(cmd, "@valor", DbType.Int32, legajoItem.valor);
                    db.ExecuteNonQuery(cmd);

                }
                return true;
            }
           
        
        

        public bool Verificar(LegajoItem legajoItem)

        {
            const string SQL_STATEMENT = " ";
            LegajoItem categoria = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@ID_ReciboSueldo", DbType.Int32, legajoItem.ReciboSueldo.Id);
                db.AddInParameter(cmd, "@ID_Item", DbType.Int32, legajoItem.ReciboSueldo.Id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        categoria = Load(dr);
                    }
                }

                if (categoria is null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public List<LegajoItem> Obtener(LegajoItem legajoItem)

        {
            const string SQL_STATEMENT = "SELECT * FROM LegajoItem where ID_ReciboSueldo=@id  ";
            List<LegajoItem> result = new List<LegajoItem>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, legajoItem.ReciboSueldo.Id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        LegajoItem categoria = Load(dr);
                        result.Add(categoria);
                    }
                }
            }

            return result;


        }
    }
}
