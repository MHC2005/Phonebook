using System;
using System.Globalization;
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

            Contact Mateo = new Contact ("Mateo");
            Mateo.Phone = "+59892718520";
            Mateo.Email = "mhcedres@gmail.com";
            phonebook.AddContact(Mateo);

            Contact Maru = new Contact("Maru");
            Maru.Phone = "+59899543284";
            Maru.Email = "maru04.roman@gmail.com";
            phonebook.AddContact(Maru);
        
            Contact Franco = new Contact("Franco");
            Franco.Phone = "+59891250104";
            Franco.Email = "francofil03@gmail.com";
            phonebook.AddContact(Franco);

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
