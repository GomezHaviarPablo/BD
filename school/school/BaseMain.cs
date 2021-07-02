using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
	
	class BaseMain
	{
		static void Main(string[] args)
		{
			Users users1 = new Users(1, "Pablo", "Gomez", "example@gmail.com", "1243", "02-07-2021", "02-07-2021");
			Countries countries1 = new Countries(1, "Argentina");
			States states1 = new States(1, 1, "Buenos Aires");
			Cities cities1 = new Cities(1, 1, "Mar del Plata");
			Profiles profiles1 = new Profiles(1, "Alumno", 1, 1);

			//Console.WriteLine(person.ToString());
			Console.WriteLine("Id Usuario: "+ users1.Id + ". Nombre: " + users1.Name + ". Apellido: " + users1.Lastname + ". Correo: " + users1.Email + ". Contraseña: " + users1.Password + ". Fecha de creacion: " + users1.Create_at + ". Fecha ultima actualizacion: " + users1.Update_at);
			Console.WriteLine("Id pais: "+ countries1.Id + ". Nombre del pais: " + countries1.Name);
			Console.WriteLine("Id provincia: " + states1.Id +". Id pais: " + states1.Id_countries + ". Nombre de la provincia: "+ states1.Name);
			Console.WriteLine("Id ciudad: " + cities1.Id + ". Id provincia: " + cities1.Id_countries + ". Nombre de la ciudad: " + cities1.Name);
			Console.WriteLine("Id perfil: " + profiles1.Id + ". Descripcion: " + profiles1.Description + ". Id usuario: " + profiles1.Id_users + ". Id ciudad: " + profiles1.Id_cities);

			Console.Read();
		}
	}





}