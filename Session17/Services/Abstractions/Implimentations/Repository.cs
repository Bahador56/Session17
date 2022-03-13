using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Session17.Models;

namespace Session17
{
    public class Repository
    {
        public string ConnectionString => @"Data Source=DESKTOP-2SI26CC\NEWSQL2019;Initial Catalog=SEssion17;Persist Security Info=True;User ID=sa;Password=bAHADOR123";
        public StudentValidationTypes InsertStudent(StudentModel model)
        {
            StudentValidationTypes Result;
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add(nameof(model.FirstName), model.FirstName, DbType.String);
                    parameters.Add(nameof(model.LastName), model.LastName, DbType.String);
                    parameters.Add(nameof(model.BirthDate), model.BirthDate, DbType.Date);
                    parameters.Add(nameof(model.StudentNumber), model.StudentNumber, DbType.String);
                    parameters.Add(nameof(Result), null, DbType.Int32, ParameterDirection.Output);

                    connection.Execute("StudentInsert", parameters, commandTimeout: 3000, commandType: CommandType.StoredProcedure);


                    Result = (StudentValidationTypes)parameters.Get<int>(nameof(Result));



                }
            }
            catch (Exception ex)
            {
                Result = StudentValidationTypes.Error;

                Console.WriteLine(ex.Message);
            }
            return Result;

        }


        public (List<StudentModel> List, StudentValidationTypes Status) GetAll()
        {
            List<StudentModel> List = new List<StudentModel>();
            StudentValidationTypes Result;
            using (IDbConnection conn = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(nameof(Result), null, DbType.Int32, ParameterDirection.Output);
                List = conn.Query<StudentModel>("GatAllStudent",
                    parameters, commandTimeout: 3000, commandType: CommandType.StoredProcedure).ToList();

                Result = (StudentValidationTypes)parameters.Get<int>(nameof(Result));
            }
            return (List, Result);

        }

    }
}
