using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorCPU.Modelos
{
    public class PlanificadorFiFo : IEnumerable<ProcesosFiFo>
    {
        private List<ProcesosFiFo> procesos;
        public bool Finalizado { get; private set; } = false;
        public PlanificadorFiFo()
        {
            procesos = new List<ProcesosFiFo>();
        }

        public void Add(ProcesosFiFo p) {

            if (Finalizado)
            {
                return;
            }
            procesos.Add(p);
            procesos = this.OrderBy(p => p.TiempoLlegada).ToList();
        }
        public IEnumerator<ProcesosFiFo> GetEnumerator()
        {
            return ((IEnumerable<ProcesosFiFo>)procesos).GetEnumerator();
        }
        public void Clear()
        {
            procesos.Clear();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)procesos).GetEnumerator();
        }
        public void Finalizar()
        {
            if (!this.Any())
            {
                return;
            }
            Finalizado = true;
            var primero = this.First();
            primero.TiempoFinal = primero.TiempoSalida;
            primero.TiempoEspera = 0;
            primero.TiempoRespuesta = primero.TiempoSalida;
            
            for(int i = 1; i < procesos.Count; i++)
            {
                procesos[i].TiempoFinal = procesos[i].TiempoSalida + procesos[i - 1].TiempoFinal;
                procesos[i].TiempoEspera = procesos[i - 1].TiempoRespuesta - procesos[i].TiempoLlegada;
                procesos[i].TiempoRespuesta = procesos[i].TiempoSalida + procesos[i - 1].TiempoRespuesta;
            }
                
            
        }
    }
}
