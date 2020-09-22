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
    public class ReciboSueldoDAC : Data.DataAccessComponent, Data.IRepository<ReciboSueldo>
    {
        public ReciboSueldo Create(ReciboSueldo entity)
        {
            const string SQL_STATEMENT = "insert into ReciboSueldo(Liquidacion,Mes,Año,Sueldo,Lugar,FechaPago,Legajo,activo)values(@Liquidacion,@Mes,@Año,@Sueldo,@Lugar,@FechaPago,@Legajo,1)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Liquidacion", DbType.AnsiString, entity.liquidacion);
                db.AddInParameter(cmd, "@Mes", DbType.AnsiString, entity.mes);
                db.AddInParameter(cmd, "@Año", DbType.AnsiString, entity.año);
                db.AddInParameter(cmd, "@Sueldo", DbType.AnsiString, entity.sueldo);
                db.AddInParameter(cmd, "@Lugar", DbType.AnsiString, entity.lugar);
                db.AddInParameter(cmd, "@FechaPago", DbType.AnsiString, entity.fechaPago);
                db.AddInParameter(cmd, "@Legajo", DbType.AnsiString, entity.empleado.Id);
                entity.Id = Convert.ToInt32(db.ExecuteScalar(cmd));



            }
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ReciboSueldo Load(IDataReader dr)
        {
            ReciboSueldo reciboSueldo = new ReciboSueldo();
            reciboSueldo.Id= GetDataValue<int>(dr, "Id_ReciboSueldo");
            reciboSueldo.año = GetDataValue<int>(dr, "año");
            reciboSueldo.empleado.Id= GetDataValue<int>(dr, "Legajo");
            reciboSueldo.mes = GetDataValue<int>(dr, "mes");
            reciboSueldo.sueldo= GetDataValue<int>(dr, "sueldo");
            reciboSueldo.liquidacion = GetDataValue<string>(dr, "liquidacion");
            return reciboSueldo;
        }

        public List<ReciboSueldo> Read()
        {
            throw new NotImplementedException();
        }

        public ReciboSueldo ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM ReciboSueldo where activo=1 and Id_ReciboSueldo=@Id ";
            ReciboSueldo empleado = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        empleado = Load(dr);
                    }
                }
                return empleado;
            }
        }

        public ReciboSueldo ReadBy(ReciboSueldo entity)
        {

            const string SQL_STATEMENT = "select * from ReciboSueldo where ID_ReciboSueldo=@Id  ";
           ReciboSueldo result = new ReciboSueldo();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.Id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        result = Load(dr);
                   
                    }
                }
            }
            return result;
        }

        public List<ReciboSueldo> ReadByLegajo(int id)
        {

            const string SQL_STATEMENT = "select * from ReciboSueldo where Legajo=@Id and activo=1 ";
            List<ReciboSueldo> result = new List<ReciboSueldo>();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        ReciboSueldo categoria = Load(dr);
                        result.Add(categoria);
                    }
                }
            }
            return result;
        }
        public void Update(ReciboSueldo entity)
        {
            throw new NotImplementedException();
        }
        public void UpdateRetencion(ReciboSueldo entity)
        {

            throw new NotImplementedException();
        }


    }
}
