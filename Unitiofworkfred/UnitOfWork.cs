using System.Data.SqlClient;
using System.Diagnostics;
using Unitiofworkfred.Entities;
using Unitiofworkfred.Interfaces;
using Unitiofworkfred.Repositories;

namespace Unitiofworkfred
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private SqlConnection _conn;
        private SqlTransaction _transaction;

        public IRepository<EnfantsEntity, int> ClientRepository
        {

            get
            {


                return new EnfantsRepository(_transaction);

            }

        }

        public IRepository<StageEntity, int> StageRepository
        {
            get
            {
                return new StageRepository(_transaction);
            }
        }
        public IRepository<SuitStageEntity, int> SuitStageRepository
        {

            get
            {


                return new SuitStageRepositories(_transaction);

            }

        }

        //public IRepository<SuitStageEntity, int> SuitStageRepository => throw new NotImplementedException();

        public UnitOfWork(string connectionString)
        {
            try
            {
                _conn = new SqlConnection(connectionString);
                _conn.Open();
                _transaction = _conn.BeginTransaction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

        }

        public void Rollback()
        {

            try
            {
                _transaction.Rollback();

            }
            catch
            {
                Debug.WriteLine("error on rollback");
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _conn.BeginTransaction();
            }

        }



        public bool Commit()
        {
            bool isOk = false;
            try
            {
                _transaction.Commit();
                isOk = true;
            }
            catch
            {
                _transaction.Rollback();

            }
            finally
            {
                _transaction.Dispose();
                _transaction = _conn.BeginTransaction();
            }
            return isOk;
        }



        public void Dispose()
        {


            if (_transaction != null)
            {
                Commit();
                _transaction.Dispose();
                _transaction = null;
            }

            if (_conn != null)
            {
                _conn.Dispose();
                _conn = null;
            }
        }
    }
}
