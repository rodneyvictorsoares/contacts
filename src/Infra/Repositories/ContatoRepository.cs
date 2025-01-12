using System;
using Domain.Models;
using Infra.Context;

namespace Infra.Repositories
{
    public class ContatoRepository : Repository<Contato>
    {
        public ContatoRepository(AppDbContext context) : base(context)
        {}

        public override Contato? GetById(int id)
        {
            var query = _context.Set<Contato>().Where(e => e.Id == id);

            if (query.Any())
            {
                return query.First();
            }
            return null;
        }

        public override IEnumerable<Contato> GetAll()
        {
            var query = _context.Set<Contato>();

            return query.Any() ? query.ToList() : new List<Contato>();
        }
    }
}
