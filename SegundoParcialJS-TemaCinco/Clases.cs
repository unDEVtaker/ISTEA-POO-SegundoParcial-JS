using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialJS_TemaCinco
{
    // Clase Maquinista
    public class Maquinista
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public Maquinista(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }
    }
    // Clase base Maquinaria
    public abstract class Maquinaria
    {
        public int Numero { get; set; }
        public int AnioFabricacion { get; set; }
        public string Marca { get; set; }

        public virtual void ImprimirReporte()
        {
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Año de fabricacion: {AnioFabricacion}");
            Console.WriteLine($"Marca: {Marca}");
        }
    }
    // Clase vagon que hereda de Maquinaria - USO HERENCIA!
    public class Vagon : Maquinaria
    {
        public TipoMercancia TipoMercancia { get; set; }

        public override void ImprimirReporte()
        {
            base.ImprimirReporte();
            Console.WriteLine($"Tipo de mercancía: {TipoMercancia}");
        }
    }
    //ENUM para definirir entre los dos tipos de Merca
    public enum TipoMercancia
    {
        Granos,
        Encomiendas
    }
    // Clase Locomotora que hereda de Maquinaria - USO HERENCIA
    public class Locomotora : Maquinaria
    {
        public TipoMotor TipoMotor { get; set; }

        public override void ImprimirReporte()
        {
            base.ImprimirReporte();
            Console.WriteLine($"Tipo de motor: {TipoMotor}");
        }
    }
    //ENUM para definirir entre los dos tipos de motor 
    public enum TipoMotor
    {
        Diesel,
        Electrico
    }
    // Clase Tren
    public sealed class Tren
    {
        private Locomotora locomotora;
        private List<Vagon> vagones;
        private bool tieneFurgon;
        private Maquinista maquinista;

        public Tren(Locomotora locomotora, Maquinista maquinista)
        {
            this.locomotora = locomotora;
            this.maquinista = maquinista;
            vagones = new List<Vagon>();
        }
    }
}