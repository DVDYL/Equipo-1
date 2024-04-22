using Datos;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioService UsuarioService = new UsuarioService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<UsuariosActivos> ListarUsuarios()
        {
            return UsuarioService.GetUsuarios();
        }

        public void AgregarUsuario(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, "test");
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
    }
}