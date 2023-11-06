using System.Linq.Expressions;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> Obtener(int id);

        Task<IEnumerable<T>> ObtenerTodos(
            Expression<Func<T, bool>> filtro = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string incluirPropiedades = null,
            bool isTracking = true // Bandera para saber si queremos modificar el objeto
            );

        Task<T> ObtenerPrimero(
            Expression<Func<T, bool>> filtro = null,
            string incluirPropiedades = null,
            bool isTracking = true // Bandera para saber si queremos modificar el objeto
            );

        Task Agregar(T entidad);

        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
    }
}
