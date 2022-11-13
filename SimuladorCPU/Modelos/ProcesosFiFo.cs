using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos
{
    public class ProcesosFiFo
    {
        public string Nombre { get;  }
        public int TiempoLlegada { get;  }  
        public int TiempoSalida { get; }

        public int TiempoBloqueado { get; }
        public bool EstaBloqueado => TiempoBloqueado != 0;
        public int TiempoFinal { get; set; }
        public int TiempoRespuesta{ get; set; }
        public int TiempoEspera { get; set; }
        public int TiempoSalidaBloqueado { get; }

        public ProcesosFiFo(string nombre, int tiempoLlegada, int tiempoSalida)
        {
            Nombre = nombre; 
            TiempoLlegada = tiempoLlegada; 
            TiempoSalida = tiempoSalida;
            TiempoBloqueado = 0;
            if(tiempoSalida >= 10)
            {
                TiempoBloqueado = new Random().Next(2, 10);
            }
            //se muestra endta
            TiempoSalidaBloqueado = TiempoSalida + TiempoBloqueado;

        }
    }
}
