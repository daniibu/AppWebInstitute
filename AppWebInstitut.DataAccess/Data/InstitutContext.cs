using Microsoft.EntityFrameworkCore; //libreria de Microsoft
using AppWebInstitut.DataAccess.Modelos;
namespace AppWebInstitut.DataAccess.Data
{
    public class InstitutContext:DbContext
    {
        //va a permitir que mi programa sepa cual base de datos va a utilizar
        //voy a crear un constructor: debe tener el mismo nombre que la clase
        public InstitutContext(DbContextOptions<InstitutContext> options)
        :base(options)
        {

        }
            //le pongo parametros
        //la base, le digo a la dbcontext, le voy a pasar un parametro options
            //voy a instanciar una clase que luego voy a utilizar, objeto options que va a ser dbcontext
        public DbSet<Alumno>? Alumnos{get;set;}
        //especifica una tabla de la base de datos
        //DbSet establece la relación entre la tabla de la base de datos
        //y el modelo utilizado en mi programa    
        public DbSet<Domicilio>? Domicilios{get;set;}
        public DbSet<Localidad>?Localidades{get;set;}
        public DbSet<Provincia>? Provincias{get;set;}
        //se crea una relacion campo-propiedad
        //04-06-22 actualizacion!!!
        //agrego nuevas tablas a la base de datos
        public DbSet<Curso>? Curso{get;set;}
        public DbSet<AlumnoXAsignatura>? AlumnoXAsignaturas{get;set;}
        public DbSet<Asignaturas>? Asignaturas{get;set;}
        public DbSet<Cursado>? Cursado{get;set;}
        public DbSet<Docentes>? Docentes{get;set;}
        public DbSet<DocentesXAsignatura>? DocentesXAsignaturas{get;set;}
        public DbSet<Resoluciones>? Resoluciones{get;set;}
        public DbSet<TipoAsignatura>? TipoAsignaturas{get;set;}

        //EN PROGRAMACION WEB tengo que crear microservicios: se invocan cada vez que un usuario se conecta a la página web
        //la ventaja de esto, es que es facil de mantener, porque hay pequeño codigo separado, y si hago una  modificacion se a donde tengo que modificar
        //esa es la posta de la POO
        //la paginacion, tengo una base de datos con un monton de registros.
        //el servidor colapsa.
        //la paginacion, el ordenamiento se hace dentro de servicios que se llaman controladores.
        //ejecutan los metodos html contra el servidor, mediante el contexto, el contexto sabe quien es la base de datos,
        //el servicio(controlador)quiere ejecutar tal cosa, el contexto le da los resultados.

        //normalmente esta separado del acceso de datos, las API, 
        //ahora vamos a crear las API, creamos un nueva solucion en donde el codigo esta relacionado con los controaldores

        //agregar las nuevas tablas de la base de datos hecha en el miercoles
    }

}

