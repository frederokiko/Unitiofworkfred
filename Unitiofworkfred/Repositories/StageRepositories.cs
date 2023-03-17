using System.Data.SqlClient;
using Unitiofworkfred.Entities;
using Unitiofworkfred.Interfaces;

namespace Unitiofworkfred.Repositories
{
    internal class StageRepository : IRepository<StageEntity,int>
    {
        private readonly SqlTransaction _transaction;

        public StageRepository(SqlTransaction transaction)
        {
            _transaction = transaction;

        }
        public int Add(StageEntity entity)
        {
            try
            {

                SqlCommand ocmd = new SqlCommand
                {
                    Connection = _transaction.Connection,
                    Transaction = _transaction,
                    CommandText = "insert into Stage (NomStage) OUTPUT INSERTED.Id values (@NomStage)"
                };
                ocmd.Parameters.AddWithValue("NomStage", entity.Nomstage);
               

                return (int)ocmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Add(EnfantsEntity enfantsEntity)
        {
            try
            {

                SqlCommand ocmd = new SqlCommand
                {
                    Connection = _transaction.Connection,
                    Transaction = _transaction,
                    CommandText = "insert into Enfants (Nom,Prenom,Age) OUTPUT INSERTED.Id values (@Nom,@Prenom,@Age)"
                };
                ocmd.Parameters.AddWithValue("Nom", enfantsEntity.Nom);
                ocmd.Parameters.AddWithValue("Prenom", enfantsEntity.Prenom);
                ocmd.Parameters.AddWithValue("Age", enfantsEntity.Age);


                return (int)ocmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int Add(SuitStageEntity entity)
        {
            try
            {

                SqlCommand ocmd = new SqlCommand
                {
                    Connection = _transaction.Connection,
                    Transaction = _transaction,
                    CommandText = "insert into Suit_stage (Id,Id_1) values (@Id,@Id_1)"
                };
                ocmd.Parameters.AddWithValue("Id", entity.Id);
                ocmd.Parameters.AddWithValue("Id_1", entity.Id_1);


                return (int)ocmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //public int Add(SuitStageEntity suitStageEntity)
        //{
        //    throw new NotImplementedException();
        //}

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StageEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public StageEntity GetOne(int id)
        {
           

                SqlCommand ocmd = new SqlCommand
                {
                    Connection = _transaction.Connection,
                    Transaction = _transaction,
                    CommandText = "SELECT (Id,Nom)  FROM Stage "
                };
                
               var result= ocmd.ExecuteReader();



            return new StageEntity();
          
            

        }

        public void Update(StageEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
