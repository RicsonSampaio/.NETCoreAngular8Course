using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Repository
{
    public interface IProdutoRepository
    {
        int Add(Produto produto);
        Task<List<Produto>> GetProdutos();
        Produto Get(int id);
        int Edit(Produto produto);
        int Delete(int id);
    }
}
