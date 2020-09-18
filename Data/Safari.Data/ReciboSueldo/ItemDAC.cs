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
    public class ItemDAC : DataAccessComponent, IRepository<Item>
    {
        public Item Create(Item entity)
        {
            const string SQL_STATEMENT = "insert into Item(porcentaje,item,Tipo,activo)values(@eporcentajepresa,@item,@Tipo,1)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@porcentaje", DbType.AnsiString, entity.porcentaje);

                db.AddInParameter(cmd, "@item", DbType.Int64, entity.item);
                db.AddInParameter(cmd, "@Tipo", DbType.AnsiString, entity.Tipo);

            }
            return entity;
        }

        public void Delete(int id)
        {
            const string SQL_STATEMENT = "update Item set activo=0 where id_Item=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Item Load(IDataReader dr)
        {
            Item item = new Item();

            item.Id = GetDataValue<int>(dr, "Id_Item");
            item.porcentaje = GetDataValue<int>(dr, "porcentaje");
            item.item = GetDataValue<string>(dr, "item");
            item.Tipo = GetDataValue<string>(dr, "Tipo");

            return item;
        }

        

        public List<Item> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Item where activo=1 ";

            List<Item> result = new List<Item>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Item item = Load(dr);
                        result.Add(item);
                    }
                }
            }
            return result;
        }

        public Item ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Item where activo=1 and id_Item=@Id ";
            Item item = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        item = Load(dr);
                    }
                }
                return item;
            }
        }

        public Item ReadBy(Item entity)
        {

            const string SQL_STATEMENT = "SELECT * FROM Item where activo=1 and Item=@Id ";
            Item item = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.item);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        item = Load(dr);
                    }
                }
                return item;
            }
        }
        public void Update(Item entity)
        {
            const string SQL_STATEMENT = "update Item set Item=@Item, porcentaje=@porcentaje, Tipo=@Tipo where id_Item=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@porcentaje", DbType.AnsiString, entity.porcentaje);

                db.AddInParameter(cmd, "@item", DbType.Int64, entity.item);
                db.AddInParameter(cmd, "@Tipo", DbType.AnsiString, entity.Tipo);
                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
