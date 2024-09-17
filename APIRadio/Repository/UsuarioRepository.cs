using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // Importante para utilizar ToListAsync e FindAsync
using APIRadio.Model;
using APIRadio.Contexto;

namespace APIRadio.Repository
{
    public class UsuarioRepository
    {
        private readonly RadioContext _context;

        public UsuarioRepository(RadioContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> GetAll() => await _context.Usuarios.ToListAsync();

        public async Task<Usuario> GetById(int id) => await _context.Usuarios.FindAsync(id);

        public async Task Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }
        }
    }
}
