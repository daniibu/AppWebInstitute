using AppWebInstitut.DataAccess.Modelos;

namespace AppWebInstitut.Services
{
    public class AlumnosServices : IAlumnosServices
    {
        public Task<RespuestaService<Alumno>> Actualizar(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<Alumno>> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<bool>> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<Alumno>> Guardar(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<RespuestaService<List<Alumno>>> Listar()
        {
            throw new NotImplementedException();
        }
    }
}