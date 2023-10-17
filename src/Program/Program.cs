using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new Contact ("Emilia");
            dueño.Phone = ("+59899881100");
            dueño.Email = ("mariaemiliacostanian@gmail.com");

            // Crear la lista de contactos
            
            Phonebook phonebook = new Phonebook(dueño);

            // Agregar contactos a la lista

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
