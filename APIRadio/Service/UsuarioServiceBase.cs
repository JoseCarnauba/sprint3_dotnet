using APIRadio.Model;
using System.Threading.Tasks;

namespace APIRadio.Service
{
    public abstract class UsuarioServiceBase
    {
        // Declaração do método como abstract
        public abstract Task Update(Usuario usuario);
    }
}
