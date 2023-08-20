using System;
using Xunit;

    class GestionTests
    {
        [Fact]
        public void AgregarTest()
        {
            // Arrange
            var db = new AnimeContext();
            
            // Act
            Console.SetIn(new System.IO.StringReader("Nombre\nApellido\nURLFoto\nPronunciacion\n1\nDD/MM/AA\nHabilidad\nFrase\nVestimenta\n123\n1\n1\nDireccion\nLatitud\nLongitud\n"));
            Gestion.Agregar();

            // Assert
            var personajes = db.personaje.ToList();
            Assert.NotEmpty(personajes);
            
        }

        [Fact]
        public void EditarTest()
        {
            // Arrange
            var db = new AnimeContext();
            
            // Act
            Console.SetIn(new System.IO.StringReader("1\nNuevoNombre\nNuevoApellido\nNuevaFoto\nNuevaPronunciacion\n1\nDD/MM/AA\nNuevaHabilidad\nNuevaFrase\nNuevaVestimenta\n123\n1\n1\nNuevaDireccion\nNuevaLatitud\nNuevaLongitud\n"));
            Gestion.Editar();

            // Assert
            var personajeEditado = db.personaje.Find(1);
            Assert.NotNull(personajeEditado);
            Assert.Equal("NuevoNombre", personajeEditado.Nombre);
        }

        [Fact]
        public void EliminarTest()
        {
            // Arrange
            var db = new AnimeContext();
            
            // Act
            Console.SetIn(new System.IO.StringReader("1\n"));
            Gestion.Eliminar();

            // Assert
            var personajeEliminado = db.personaje.Find(1);
            Assert.Null(personajeEliminado);
        }
    }