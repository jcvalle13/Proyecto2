﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion.WCFServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServicio.IServicios")]
    public interface IServicios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarUsuario", ReplyAction="http://tempuri.org/IServicios/AgregarUsuarioResponse")]
        int AgregarUsuario(Entidades.Usuarios P_Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarUsuario", ReplyAction="http://tempuri.org/IServicios/AgregarUsuarioResponse")]
        System.Threading.Tasks.Task<int> AgregarUsuarioAsync(Entidades.Usuarios P_Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarUsuarioTransaccion", ReplyAction="http://tempuri.org/IServicios/AgregarUsuarioTransaccionResponse")]
        int AgregarUsuarioTransaccion(Entidades.Usuarios P_Usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarUsuarioTransaccion", ReplyAction="http://tempuri.org/IServicios/AgregarUsuarioTransaccionResponse")]
        System.Threading.Tasks.Task<int> AgregarUsuarioTransaccionAsync(Entidades.Usuarios P_Usuarios);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ModificarUsuario", ReplyAction="http://tempuri.org/IServicios/ModificarUsuarioResponse")]
        int ModificarUsuario(Entidades.Usuarios P_Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ModificarUsuario", ReplyAction="http://tempuri.org/IServicios/ModificarUsuarioResponse")]
        System.Threading.Tasks.Task<int> ModificarUsuarioAsync(Entidades.Usuarios P_Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Usuarios", ReplyAction="http://tempuri.org/IServicios/Consultar_UsuariosResponse")]
        System.Collections.Generic.List<Entidades.Usuarios> Consultar_Usuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Usuarios", ReplyAction="http://tempuri.org/IServicios/Consultar_UsuariosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Usuarios>> Consultar_UsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/VerificarUsuario", ReplyAction="http://tempuri.org/IServicios/VerificarUsuarioResponse")]
        bool VerificarUsuario(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/VerificarUsuario", ReplyAction="http://tempuri.org/IServicios/VerificarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> VerificarUsuarioAsync(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Permisos_Usuarios", ReplyAction="http://tempuri.org/IServicios/Consultar_Permisos_UsuariosResponse")]
        System.Collections.Generic.List<Entidades.Usuarios> Consultar_Permisos_Usuarios(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Permisos_Usuarios", ReplyAction="http://tempuri.org/IServicios/Consultar_Permisos_UsuariosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Usuarios>> Consultar_Permisos_UsuariosAsync(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EliminarUsuario", ReplyAction="http://tempuri.org/IServicios/EliminarUsuarioResponse")]
        int EliminarUsuario(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EliminarUsuario", ReplyAction="http://tempuri.org/IServicios/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task<int> EliminarUsuarioAsync(Entidades.Usuarios P_usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EnviarCorreoElectronico", ReplyAction="http://tempuri.org/IServicios/EnviarCorreoElectronicoResponse")]
        void EnviarCorreoElectronico(Entidades.Email P_Correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EnviarCorreoElectronico", ReplyAction="http://tempuri.org/IServicios/EnviarCorreoElectronicoResponse")]
        System.Threading.Tasks.Task EnviarCorreoElectronicoAsync(Entidades.Email P_Correo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarPerfil", ReplyAction="http://tempuri.org/IServicios/AgregarPerfilResponse")]
        int AgregarPerfil(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/AgregarPerfil", ReplyAction="http://tempuri.org/IServicios/AgregarPerfilResponse")]
        System.Threading.Tasks.Task<int> AgregarPerfilAsync(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ModificarPerfil", ReplyAction="http://tempuri.org/IServicios/ModificarPerfilResponse")]
        int ModificarPerfil(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ModificarPerfil", ReplyAction="http://tempuri.org/IServicios/ModificarPerfilResponse")]
        System.Threading.Tasks.Task<int> ModificarPerfilAsync(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EliminarPerfil", ReplyAction="http://tempuri.org/IServicios/EliminarPerfilResponse")]
        int EliminarPerfil(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/EliminarPerfil", ReplyAction="http://tempuri.org/IServicios/EliminarPerfilResponse")]
        System.Threading.Tasks.Task<int> EliminarPerfilAsync(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ConsultarPerfiles", ReplyAction="http://tempuri.org/IServicios/ConsultarPerfilesResponse")]
        System.Collections.Generic.List<Entidades.Perfiles> ConsultarPerfiles(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/ConsultarPerfiles", ReplyAction="http://tempuri.org/IServicios/ConsultarPerfilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Perfiles>> ConsultarPerfilesAsync(Entidades.Perfiles P_Perfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Clientes_Prestamos", ReplyAction="http://tempuri.org/IServicios/Consultar_Clientes_PrestamosResponse")]
        System.Collections.Generic.List<Entidades.ClientesPrestamos> Consultar_Clientes_Prestamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Clientes_Prestamos", ReplyAction="http://tempuri.org/IServicios/Consultar_Clientes_PrestamosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClientesPrestamos>> Consultar_Clientes_PrestamosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Lista_Prestamos", ReplyAction="http://tempuri.org/IServicios/Consultar_Lista_PrestamosResponse")]
        System.Collections.Generic.List<Entidades.ListaRegistroPrestamos> Consultar_Lista_Prestamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicios/Consultar_Lista_Prestamos", ReplyAction="http://tempuri.org/IServicios/Consultar_Lista_PrestamosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ListaRegistroPrestamos>> Consultar_Lista_PrestamosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosChannel : Presentacion.WCFServicio.IServicios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosClient : System.ServiceModel.ClientBase<Presentacion.WCFServicio.IServicios>, Presentacion.WCFServicio.IServicios {
        
        public ServiciosClient() {
        }
        
        public ServiciosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AgregarUsuario(Entidades.Usuarios P_Usuario) {
            return base.Channel.AgregarUsuario(P_Usuario);
        }
        
        public System.Threading.Tasks.Task<int> AgregarUsuarioAsync(Entidades.Usuarios P_Usuario) {
            return base.Channel.AgregarUsuarioAsync(P_Usuario);
        }
        
        public int AgregarUsuarioTransaccion(Entidades.Usuarios P_Usuarios) {
            return base.Channel.AgregarUsuarioTransaccion(P_Usuarios);
        }
        
        public System.Threading.Tasks.Task<int> AgregarUsuarioTransaccionAsync(Entidades.Usuarios P_Usuarios) {
            return base.Channel.AgregarUsuarioTransaccionAsync(P_Usuarios);
        }
        
        public int ModificarUsuario(Entidades.Usuarios P_Usuario) {
            return base.Channel.ModificarUsuario(P_Usuario);
        }
        
        public System.Threading.Tasks.Task<int> ModificarUsuarioAsync(Entidades.Usuarios P_Usuario) {
            return base.Channel.ModificarUsuarioAsync(P_Usuario);
        }
        
        public System.Collections.Generic.List<Entidades.Usuarios> Consultar_Usuarios() {
            return base.Channel.Consultar_Usuarios();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Usuarios>> Consultar_UsuariosAsync() {
            return base.Channel.Consultar_UsuariosAsync();
        }
        
        public bool VerificarUsuario(Entidades.Usuarios P_usuario) {
            return base.Channel.VerificarUsuario(P_usuario);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarUsuarioAsync(Entidades.Usuarios P_usuario) {
            return base.Channel.VerificarUsuarioAsync(P_usuario);
        }
        
        public System.Collections.Generic.List<Entidades.Usuarios> Consultar_Permisos_Usuarios(Entidades.Usuarios P_usuario) {
            return base.Channel.Consultar_Permisos_Usuarios(P_usuario);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Usuarios>> Consultar_Permisos_UsuariosAsync(Entidades.Usuarios P_usuario) {
            return base.Channel.Consultar_Permisos_UsuariosAsync(P_usuario);
        }
        
        public int EliminarUsuario(Entidades.Usuarios P_usuario) {
            return base.Channel.EliminarUsuario(P_usuario);
        }
        
        public System.Threading.Tasks.Task<int> EliminarUsuarioAsync(Entidades.Usuarios P_usuario) {
            return base.Channel.EliminarUsuarioAsync(P_usuario);
        }
        
        public void EnviarCorreoElectronico(Entidades.Email P_Correo) {
            base.Channel.EnviarCorreoElectronico(P_Correo);
        }
        
        public System.Threading.Tasks.Task EnviarCorreoElectronicoAsync(Entidades.Email P_Correo) {
            return base.Channel.EnviarCorreoElectronicoAsync(P_Correo);
        }
        
        public int AgregarPerfil(Entidades.Perfiles P_Perfil) {
            return base.Channel.AgregarPerfil(P_Perfil);
        }
        
        public System.Threading.Tasks.Task<int> AgregarPerfilAsync(Entidades.Perfiles P_Perfil) {
            return base.Channel.AgregarPerfilAsync(P_Perfil);
        }
        
        public int ModificarPerfil(Entidades.Perfiles P_Perfil) {
            return base.Channel.ModificarPerfil(P_Perfil);
        }
        
        public System.Threading.Tasks.Task<int> ModificarPerfilAsync(Entidades.Perfiles P_Perfil) {
            return base.Channel.ModificarPerfilAsync(P_Perfil);
        }
        
        public int EliminarPerfil(Entidades.Perfiles P_Perfil) {
            return base.Channel.EliminarPerfil(P_Perfil);
        }
        
        public System.Threading.Tasks.Task<int> EliminarPerfilAsync(Entidades.Perfiles P_Perfil) {
            return base.Channel.EliminarPerfilAsync(P_Perfil);
        }
        
        public System.Collections.Generic.List<Entidades.Perfiles> ConsultarPerfiles(Entidades.Perfiles P_Perfil) {
            return base.Channel.ConsultarPerfiles(P_Perfil);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Perfiles>> ConsultarPerfilesAsync(Entidades.Perfiles P_Perfil) {
            return base.Channel.ConsultarPerfilesAsync(P_Perfil);
        }
        
        public System.Collections.Generic.List<Entidades.ClientesPrestamos> Consultar_Clientes_Prestamos() {
            return base.Channel.Consultar_Clientes_Prestamos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ClientesPrestamos>> Consultar_Clientes_PrestamosAsync() {
            return base.Channel.Consultar_Clientes_PrestamosAsync();
        }
        
        public System.Collections.Generic.List<Entidades.ListaRegistroPrestamos> Consultar_Lista_Prestamos() {
            return base.Channel.Consultar_Lista_Prestamos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.ListaRegistroPrestamos>> Consultar_Lista_PrestamosAsync() {
            return base.Channel.Consultar_Lista_PrestamosAsync();
        }
    }
}
