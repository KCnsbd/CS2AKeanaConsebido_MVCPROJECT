namespace CS2AKeanaConsebido_MVCPROJECT.BusLogic.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
    }
}
