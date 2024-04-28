using Datos;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioService UsuarioService = new UsuarioService();
        public String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<UsuariosActivos> ListarUsuarios()
        {
            return UsuarioService.GetUsuarios();
        }

        public void AgregarUsuario(
        string idUsuario,
        int host,
        string nombre,
        string apellido,
        int dni,
        string direccion,
        string telefono,
        string email,
        DateTime fechaNacimiento,
        string NombreUsuario,
        string Contraseña) {
            AltaUsuario altaUsuario = new AltaUsuario(
        idUsuario,
        host,
        nombre,
        apellido,
        dni,
        direccion,
        telefono,
        email,
        fechaNacimiento,
        NombreUsuario,
        Contraseña);
            UsuarioService.AgregarUsuario(altaUsuario);
        }

        public void ModificarUsuario(Guid idUsuario, string direccion, string telefono, string email)
        {
            UsuarioService.ModificarUsuario(idUsuario, direccion, telefono, email);
        }

        public void BorrarUsuario(Guid idUsuario)
        {
            UsuarioService.BorrarUsuario(idUsuario);
        }

        public string IniciarSesion(string NombreUsuario, string Contraseña)
        {
            LogIn IniciarSesion = new LogIn(NombreUsuario, Contraseña);
            string id = UsuarioService.IniciarSesion(IniciarSesion);
            return id;
        }
    }
}