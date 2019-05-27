using API.API.BC;
using API.API.BC.Modelos;
using API.API.BW.Contratos;
using System;
using System.Collections.Generic;

namespace API.API.BW {
    public class FlujoObtenerPreguntas : IFlujoObtenerPreguntas {

        private GeneradorDePreguntas generadorDePreguntas;

        public FlujoObtenerPreguntas() {
            generadorDePreguntas = new GeneradorDePreguntas();
        }

        public List<Pregunta> ObtienePregunta() {
            List<Pregunta> preguntas = generadorDePreguntas.GeneraLasPreguntas();

            return preguntas;
        }
    }
}
