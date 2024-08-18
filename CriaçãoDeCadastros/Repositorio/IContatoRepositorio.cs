using CriaçãoDeCadastros.Models;

namespace CriaçãoDeCadastros.Repositorio
{
    public interface IContatoRepositorio
    {   
        ContatoModel ListarporId(int id); 
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Editar(ContatoModel contato);

        bool Apagar(int Id);
    }
}
