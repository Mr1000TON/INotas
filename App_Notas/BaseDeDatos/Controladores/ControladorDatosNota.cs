using App_Notas.BaseDeDatos.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_Notas.BaseDeDatos.Controladores
{
    public class ControladorDatosNota
    {

        private readonly SQLiteAsyncConnection _db;

        public ControladorDatosNota(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Modelos.Nota>().Wait();
        }

        public Task<List<Nota>> ObtenerNotasAsync()
        {
            return _db.Table<Nota>().ToListAsync();
        }

        public Task<List<Nota>> ObtenerNotasImportantesAsync()
        {
            return _db.Table<Nota>().Where(i => i.Categoria == "Importante").ToListAsync();
        }

        public Task<List<Nota>> ObtenerNotasRecordatoriosAsync()
        {
            return _db.Table<Nota>().Where(i => i.Categoria == "Recordatorio").ToListAsync();
        }

        public Task<List<Nota>> ObtenerNotasTareasAsync()
        {
            return _db.Table<Nota>().Where(i => i.Categoria == "Tarea").ToListAsync();
        }

        public Task<List<Nota>> ObtenerNotasActividadesAsync()
        {
            return _db.Table<Nota>().Where(i => i.Categoria == "Actividad").ToListAsync();
        }

        public Task<List<Nota>> ObtenerOtrasNotasAsync()
        {
            return _db.Table<Nota>().Where(i => i.Categoria == "Otra").ToListAsync();
        }

        public Task<int> InsertarNotasAsync(Nota nota)
        {
            return _db.InsertAsync(nota);
        }

        public Task<int> ActualizarNotasAsync(Nota nota)
        {
            return _db.UpdateAsync(nota);
        }

        public Task<int> EliminarNotasAsync(Nota nota)
        {
            return _db.DeleteAsync(nota);
        }

    }
}
