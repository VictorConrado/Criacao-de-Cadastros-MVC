using CriaçãoDeCadastros.Data;
using CriaçãoDeCadastros.Models;

namespace CriaçãoDeCadastros.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    { 
        private readonly BancoContext _Context;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
           this._Context = bancoContext;
        }

        public ContatoModel ListarporId(int id)
        {
            return _Context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
           return _Context.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _Context.Contatos.Add(contato);
            _Context.SaveChanges();
            return contato;
            throw new NotImplementedException();
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarporId(contato.Id);

            if (contatoDB == null) throw new SystemException("Houve um erro na atualização do contato");

            contatoDB.Name = contato.Name;
            contatoDB.Email = contato.Email;
            contatoDB.Numero = contato.Numero;

            _Context.Contatos.Update(contatoDB);
            _Context.SaveChanges();

            return contatoDB;
        }

        public bool Apagar(int Id)
        {
            ContatoModel contatoDB = ListarporId(Id);

            if (contatoDB == null) throw new SystemException("Houve um erro na deleção do contato.");

            _Context.Contatos.Remove(contatoDB);
            _Context.SaveChanges();
            return true;
        }
    }
}
