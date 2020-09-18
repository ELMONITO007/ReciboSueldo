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
    public class AporteJubilatorioDAC : DataAccessComponent, IRepository<AporteJubilatorio>
    {
        public AporteJubilatorio Create(AporteJubilatorio entity)
        {

            const string SQL_STATEMENT = "insert into AporteJubilatorio(Periodo,Fecha,Banco,Activo)values (@Periodo,@Fecha,@Banco,1)   insert into LegajoAporteJubilatorio (ID_AporteJubilatorio,Legajo)values((select ID_AporteJubilatorio from AporteJubilatorio where Periodo=@Periodo and Fecha=@Fecha and Banco=@Banco),@legajo)";


            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Periodo", DbType.AnsiString, entity.periodo);

                db.AddInParameter(cmd, "@Fecha", DbType.DateTime, entity.fecha);
                db.AddInParameter(cmd, "@Banco", DbType.AnsiString, entity.banco);

                db.AddInParameter(cmd, "@Legajo", DbType.AnsiString, entity.empleado.Id);

            }
            return entity;
        }

        public void Delete(int id)
        {

            const string SQL_STATEMENT = "update AporteJubilatorio set activo=0 where id_AporteJubilatorio=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }
        public void Delete(int id,int legajo)
        {

            const string SQL_STATEMENT = "update AporteJubilatorio set activo=0 where id_AporteJubilatorio=@id   delete LegajoAporteJubilatorio where ID_AporteJubilatorio=@id and Legajo=@Legajo";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.AddInParameter(cmd, "@Legajo", DbType.Int32, legajo);
                db.ExecuteNonQuery(cmd);
            }
        }
        public AporteJubilatorio Load(IDataReader dr)
        {
            AporteJubilatorio aporteJubilatorio = new AporteJubilatorio();

            aporteJubilatorio.Id = GetDataValue<int>(dr, "Id_aporteJubilatorio");
            aporteJubilatorio.banco = GetDataValue<string>(dr, "banco");
            aporteJubilatorio.empleado.Id = GetDataValue<int>(dr, "Legajo");
            aporteJubilatorio.fecha = GetDataValue<DateTime>(dr, "fecha");
            aporteJubilatorio.periodo = GetDataValue<string>(dr, "periodo");


            return aporteJubilatorio;
        }

        public List<AporteJubilatorio> Read()
        {
            throw new NotImplementedException();
        }

        public AporteJubilatorio ReadBy(int id)
        {
            throw new NotImplementedException();
        }

        public AporteJubilatorio ReadBy(AporteJubilatorio entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AporteJubilatorio entity)
        {
            throw new NotImplementedException();
        }
    }
}
