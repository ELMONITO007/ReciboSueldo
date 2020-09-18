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
    public class EmpleadoDAC : DataAccessComponent, IRepository<Empleado>
    {
        public Empleado Create(Empleado entity)
        {
            const string SQL_STATEMENT = "insert into Empleado(cuil,apellido,nombre,banco,cuenta,ID_categoria,ID_departamento,ID_division,ID_empresa,fechaIngreso,activo)values(@cuil,@apellido,@nombre,@banco,@cuenta,@ID_categoria,@ID_departamento,@ID_division,@ID_empresa,@fechaIngreso,1)";

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@cuil", DbType.String, entity.cuil);

                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@nombre", DbType.AnsiString, entity.nombre);

                db.AddInParameter(cmd, "@banco", DbType.AnsiString, entity.banco);
                db.AddInParameter(cmd, "@cuenta", DbType.String, entity.cuenta);
                db.AddInParameter(cmd, "@ID_categoria", DbType.Int64, entity.categoria.Id);

                db.AddInParameter(cmd, "@ID_departamento", DbType.Int64, entity.departamento.departamento);
                db.AddInParameter(cmd, "@ID_division", DbType.Int64, entity.division.Id);
                db.AddInParameter(cmd, "@ID_empresa", DbType.Int64, entity.empresa.Id);
                db.AddInParameter(cmd, "@fechaIngreso", DbType.DateTime, entity.fechaIngreso);

            }
            return entity;
        }

        public void Delete(int id)
        {

            const string SQL_STATEMENT = "update Empleado set activo=0 where Legajo=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, id);
                db.ExecuteNonQuery(cmd);
            }
        }

        public Empleado Load(IDataReader dr)
        {
            Empleado empleado = new Empleado();

            empleado.Id = GetDataValue<int>(dr, "Legajo");
            empleado.cuil = GetDataValue<string>(dr, "cuil");
            empleado.apellido = GetDataValue<string>(dr, "apellido");
            empleado.nombre = GetDataValue<string>(dr, "nombre");
            empleado.banco = GetDataValue<string>(dr, "banco");
            empleado.cuenta = GetDataValue<string>(dr, "cuenta");
            empleado.categoria.Id = GetDataValue<int>(dr, "ID_categoria");
            empleado.fechaIngreso = GetDataValue<DateTime>(dr, "fechaIngreso");
            empleado.departamento.Id = GetDataValue<int>(dr, "ID_departamento");
            empleado.division.Id= GetDataValue<int>(dr, "ID_division");
            empleado.empresa.Id = GetDataValue<int>(dr, "ID_empresa");
       

            return empleado;
        }

        public List<Empleado> Read()
        {
            const string SQL_STATEMENT = "SELECT * FROM Empleado where activo=1 ";

            List<Empleado> result = new List<Empleado>();
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        Empleado empleado = Load(dr);
                        result.Add(empleado);
                    }
                }
            }
            return result;
        }

        public Empleado ReadBy(int id)
        {
            const string SQL_STATEMENT = "SELECT * FROM Empleado where activo=1 and Legajo=@Id ";
            Empleado empleado = null;

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

        public Empleado ReadBy(Empleado entity)
        {
            const string SQL_STATEMENT = "SELECT * FROM Empleado where activo=1 and cuil=@Id ";
            Empleado empleado = null;

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@Id", DbType.Int32, entity.cuil);
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

        public void Update(Empleado entity)
        {
            const string SQL_STATEMENT = "update Empleado set cuil=@cuil, nombre=@nombre, apellido=@apellido, banco=@banco, cuenta=@cuenta,ID_categoria=@ID_categoria, ID_departamento=@ID_departamento, ID_division=@ID_division,ID_empresa=@ID_empresa;fechaIngreso=@fechaIngreso   where Legajo=@id ";
            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
               
                db.AddInParameter(cmd, "@id", DbType.Int32, entity.Id);
                db.AddInParameter(cmd, "@cuil", DbType.Int64, entity.empresa);

                db.AddInParameter(cmd, "@apellido", DbType.String, entity.apellido);
                db.AddInParameter(cmd, "@nombre", DbType.AnsiString, entity.nombre);

                db.AddInParameter(cmd, "@banco", DbType.AnsiString, entity.banco);
                db.AddInParameter(cmd, "@cuenta", DbType.Int64, entity.cuenta);
                db.AddInParameter(cmd, "@ID_categoria", DbType.Int64, entity.categoria.Id);

                db.AddInParameter(cmd, "@ID_departamento", DbType.Int64, entity.departamento.departamento);
                db.AddInParameter(cmd, "@ID_division", DbType.Int64, entity.division.Id);
                db.AddInParameter(cmd, "@ID_empresa", DbType.Int64, entity.empresa.Id);
                db.AddInParameter(cmd, "@fechaIngreso", DbType.DateTime, entity.fechaIngreso);

                db.ExecuteNonQuery(cmd);
            }
        }
    }
}
