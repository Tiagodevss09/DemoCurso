using DemoCurso.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCurso.Data
{
    public class CursoRepository
    {

        private readonly ApplicationContext _dbContext;

        public CursoRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Salvar(Curso curso)
        {
            _dbContext.Add(curso);
            return _dbContext.SaveChanges();
        }
    }
}
