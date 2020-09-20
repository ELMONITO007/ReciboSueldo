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
            throw new NotImplementedException();
        }

        public List<ReciboSueldo> Read()
        {
            throw new NotImplementedException();
        }

        public ReciboSueldo ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public ReciboSueldo ReadBy(ReciboSueldo entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ReciboSueldo entity)
        {
            throw new NotImplementedException();
        }
    }
}
