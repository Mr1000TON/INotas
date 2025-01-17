using App_Notas.BaseDeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Notas.Servicios
{
    public interface INotaServicio
    {
        void AgregarNota(Nota nota);
        void EditarNota(Nota nota);
        void EliminarNota(Nota nota);
    }

    public class NotaServicio : INotaServicio 
    {
        public NotaServicio() 
        {
        
        }

        

        public async void AgregarNota(Nota nota)
        {
            await App.ControladorDatosNota.InsertarNotasAsync(nota);
        }

        public async void EditarNota(Nota nota)
        {
            await App.ControladorDatosNota.ActualizarNotasAsync(nota);
        }

        public async void EliminarNota(Nota nota)
        {
            await App.ControladorDatosNota.EliminarNotasAsync(nota);
        }

    }
}
