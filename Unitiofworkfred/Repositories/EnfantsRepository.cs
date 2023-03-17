using System.Data.SqlClient;
using Unitiofworkfred.Entities;
using Unitiofworkfred.Interfaces;
using Unitiofworkfred.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Unitiofworkfred.Repositories
{
    internal class EnfantsRepository : IRepository<EnfantsEntity, int>
    {
        private readonly SqlTransaction _transaction;

        public EnfantsRepository(SqlTransaction transaction)
        {
            _transaction = transaction;

        }

        public int Add(EnfantsEntity entity)
        {
            try
            {
                SqlCommand ocmd = new SqlCommand();
                ocmd.Connection = _transaction.Connection;
                ocmd.Transaction = _transaction;
                ocmd.CommandText = "insert into Enfants (Nom, Prenom,Age) OUTPUT INSERTED.Id values (@Nom, @Prenom,@Age)";
                ocmd.Parameters.AddWithValue("Nom", entity.Nom);
                ocmd.Parameters.AddWithValue("Prenom", entity.Prenom);
                ocmd.Parameters.AddWithValue("Age", entity.Age);

                return(int)ocmd.ExecuteScalar();


            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int Add(SuitStageEntity suitStageEntity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EnfantsEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<EnfantsEntity> GetAll()
        //{
        //    SqlCommand ocmd = new SqlCommand();
        //    SqlDataReader reader = ocmd.ExecuteReader();
        //    ocmd.CommandText = "SELECT (Nom, Prenom,Age)values(@nom,@prenom,@Age) from Enfants";

        //    while (reader.Read())
        //    {

        //    }
        //    return ;
        //}

        public EnfantsEntity GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(EnfantsEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
