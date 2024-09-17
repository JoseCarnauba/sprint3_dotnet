using APIRadio.Contexto;

namespace APIRadio.Factory
{
    public class DbContextFactory
    {
        private static RadioContext _context;

        public static RadioContext GetContext(IServiceProvider serviceProvider)
        {
            if (_context == null)
            {
                var options = new DbContextOptionsBuilder<RadioContext>()
                    .UseOracle("Data \r\nSource=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=oracle.fiap.com.br)(PORT=1521))) \r\n(CONNECT_DATA=(SERVER=DEDICATED)" +
                    "(SID=ORCL)));User Id=<RM552367>;Password=<210683>;”");


                _context = new RadioContext(options);
            }
            return _context;
        }
    } }
    
