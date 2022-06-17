using System.ComponentModel.DataAnnotations;//.net utiliza esa libreria, para por ejemplo, en nombre
//podemos especificar el largo que tenga ese campo, que cantidad de caracteres se puede introducir
namespace AppWebInstitut.DataAccess.Modelos
{
    public class Alumno
    {
        public int AlumnoId {get;set;}

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]//Ejemplo de la libreria, se ingresan 50 caracteres
        [RegularExpression(@"([A-Z])\w+")]
        public string Nombre{get;set;} =null!;//el campo va a aceptar valores nulos
        //El signo interrogacion despues de string indica que la propiedad acepta valores nulos,
        //otra forma es para indicar una asignacion de tipo null seguida de ! a la propiedad
        //ejemplo string?
        //ejemplo public string Nombre{get;set;} =null!;
        //el coso de valores NULL puedo poner string? .. o =null!; cualquiera de estas dos formas es valida
        //si quiero la propiedad vacia le pongo Empty;

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"([A-Z])\w+")]
        public string? Apellido { get; set; }

        
        //Expresiones regulares
        //Ejemplo:holabuenosdias10@google.com
        //^[a-zA-Z0-9]+(\.{1}[a-zA-Z]+)*@[a-z]+\.{1}[a-z]{3}$
        //Ejemplo:holabuenosdias10@google.com.ar
        //^[a-zA-Z0-9]+(\.{1}[a-zA-Z]+)*@[a-z]+\.{1}[a-z]{3}(\.[a-z]{0,2}){0,1}$
        [StringLength(3,MinimumLength =3,ErrorMessage ="DNI cuenta con 8 numeros")]
        [RegularExpression(@"^[0-9]")]
        public string? NroDoc {get;set;}

        [DataType(DataType.Date)]//tambien puedo mostrar como yo quiero la fecha
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [RegularExpression(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$")]
        public DateTime FechaNac {get;set;}

        [StringLength(50,MinimumLength =10,ErrorMessage ="El largo máximo es de 50 caracteres")]
        public Domicilio? Domicilio {get;set;}//ahora creo una composicion aca.
        //Composicion era una relacion entre dos clases o dos objetos, en donde teniamos una clase y otra clase
        // en donde una propiedad de una clase, hace referencia a otra clase
        //dos tipos de relaciones, relacion debil(composicion), si yo destruyo el objeto 1, se destuye el objeto 2
        //asociacion(agregacion): el menu de un restuarante, menu del día, con lomo, papitas, helado. si al otro día
        //se borra el menú pero alguien me pide papitas, las papitas siguen existiendo
        //domicio es una composicion


        public int ProvinciaId { get; set; }//clave foranea
        public int Localidad { get; set; }
        //localidad y provincia, son agregaciones

        [StringLength(10,MinimumLength =10,ErrorMessage ="Ingrese su teléfono sin 15")]
        public string? NroTelefono { get; set; }

        [StringLength(10,MinimumLength =10,ErrorMessage ="Ingrese su teléfono sin 15")]
        public string? NroMovil { get; set; }

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z0-9]+(\.{1}[a-zA-Z0-9]+)*@(hotmail|yahoo|outlook|gmail){1}\.{1}[a-z]{3}(\.[a-z]{0,2}){0,1}$")]
        //holabuenosdias10@gmail.com.ar
        public string? EMail { get; set; }
        

        [StringLength(50,MinimumLength =3,ErrorMessage ="El largo máximo es de 50 caracteres")]
        //agregar el de lagajo
        public int Legajo { get; set; }//el legajo puede ser alfanumerico o con distintos caracteres
        //el borrado logico sirve para
        public bool Eliminado { get; set; }
        //HAY QUE TENER EN CUENTA que hay dos campos, la fecha de actualizacion de ese dato, que me registre la modificacion
        //y tambien el ID del usuario que hizo eso, porque si los datos son importantes y alguien se las manda
        //tengo que saber quuien lo hizo

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [RegularExpression(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$")]
        public DateTime DateUpdate { get; set; }

        public string FullName(){
            return Apellido + " " + Nombre;
        }//creamos una funcion, que va a retornar en apellido y nombre

        //nuevos atributos de la tabla
        [StringLength(3,MinimumLength =3,ErrorMessage ="Identifique el numero del Curso")]
        public int Curso{get;set;}

    }
}