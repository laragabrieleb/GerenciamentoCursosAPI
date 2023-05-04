using CursosAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursosAPI.Repositories.Utils
{
    public class Utils<T> : IUtils<T> where T : class
    {
        private readonly DataContext _dataContext;

        public Utils(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        public async Task Delete(int Id)
        {
            var entity = await GetById(Id);
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await _dataContext.Set<T>().FindAsync(Id);
        }

        public async Task Insert(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Update(int Id, T entity)
        {
            _dataContext.Set<T>().Update(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
