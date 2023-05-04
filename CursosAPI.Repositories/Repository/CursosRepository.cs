using CursosAPI.Data.Context;
using CursosAPI.Domain.Entities;
using CursosAPI.Repositories.Interface;
using CursosAPI.Repositories.Utils;

namespace CursosAPI.Repositories.Repository
{
    public class CursosRepository : Utils<EntidadeCursos>, ICursos
    {
        public CursosRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
