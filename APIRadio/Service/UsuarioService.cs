using APIRadio.Model;
using APIRadio.Repository;

namespace APIRadio.Service
{
    public class UsuarioService : UsuarioServiceBase
    {
        private readonly UsuarioRepository _repository;

        public UsuarioService(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Usuario>> GetAll() => _repository.GetAll();
        public Task<Usuario> GetById(int id) => _repository.GetById(id);
        public Task Add(Usuario usuario) => _repository.Add(usuario);
        public Task Delete(int id) => _repository.Delete(id);

        public override Task Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
