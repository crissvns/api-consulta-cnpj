using api_consulta_cnpj.Data.Context;
using api_consulta_cnpj.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace api_consulta_cnpj.Data.Repository
{
    public class repository_consultacnpj
    {
        private readonly cnpjcontext _context;

        public repository_consultacnpj(cnpjcontext _context)
            => this._context = _context;

        public int Commit() => _context.SaveChanges();

        public consultacnpj GetById(string cnpj)
            => _context.Set<consultacnpj>().Where(p => p.cnpj.Equals(cnpj)).FirstOrDefault<consultacnpj>();

        public void Insert(consultacnpj register)
            => _context.Add<consultacnpj>(register);

        public void Update(consultacnpj register)
            => _context.Entry<consultacnpj>(register).State = EntityState.Modified;
    }
}