using AplicacaoCarrinho.Models;

namespace AplicacaoCarrinho.Repository.Contract
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> ObterTodasCategorias();
    }
}
