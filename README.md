INotas - Version 1.0: 
  - Gestión de notas básica

Descripcion: 
  - Prototipo de aplicación de gestión de notas. Permite crear, visualizar, editar y eliminar notas organizadas por categorías
  
Caracteristicas: 

  - Agregada base de datos local (SQLite):
      - Controlador (ControladorDatosNota.cs) :
          - Gestión completa de la base de datos (, Inserción, Actualización y Eliminación de Notas)
            
              - Obtención:
                  - Recupera todas las notas
                    
              - Inserción:
                  - Guarda nuevas notas
                    
              - Actualización:
                  - Modifica notas existentes
                    
              - Eliminación:
                  - Borra notas seleccionadas
                                     
      - Modelo (Nota.cs) :
          - Define la estructura de los datos que se guardan
            
------------

  - Servicio agregado (NotaServicio.cs)
      - Facilita el acceso a la base de datos
      - Centraliza la lógica para obtener y enviar datos
        
------------

  - Vistas agregadas
    
      - Vista Acerca de:
          - Muestra información sobre la aplicación
          - Incluye mis contactos
   
      - Vista Agregar Notas:
          - Permite insertar nuevas notas en la base de datos

      - Vista Contenido:
          - Muestra el contenido completo de una nota seleccionada
          - En esta se puede editar o eliminar la nota

      - Vistas de  Muestra:
        
          - Vista Notas:
              - Muestra en la pestaña principal todas las notas creadas
                
          - Vistas Notas por Categorias:

              - Vista Notas Actividades: Filtra y muestra solo las notas categorizadas como actividades
              - Vista Notas Importantes: Muestra las notas marcadas como importantes
              - Vista Notas Recordatorios: Presenta notas de recordatorio
              - Vista Notas Tareas: Lista las notas de tareas
              - Vista Otas notas: Filtra las notas de la categoría "Otra

------------

  - Proximos cambios:
      - Mejorar la experiencia del usuario (UI/UX)
      - Optimizar el rendimiento
      - Implementar la programacion modular entre servicios
          - Servicio dedicado a la gestion de Notas: Agregar, editar, eliminar y obtener notas.
          - Servicio dedicado a la navegacion entre vistas
