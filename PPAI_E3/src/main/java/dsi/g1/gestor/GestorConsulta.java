package dsi.g1.gestor;

import dsi.g1.entidades.Encuesta;
import dsi.g1.entidades.Llamada;
import dsi.g1.entidades.RespuestaDeCliente;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class GestorConsulta {
    // Atributos
    public List<Llamada> llamadas;
    public List<Encuesta> encuestas;
    private PantallaConsulta pantalla;

    private Date fechaInicioPeriodo;
    private Date fechaFinPeriodo;
    public List<Llamada> llamadasEncontradas = new ArrayList<>();
    public Llamada llamadaSeleccionada;

    public String nombreClienteSeleccionado;
    public float duracionLlamadaSelec;
    public String estadoActualLlamadaSelec;

    public List<RespuestaDeCliente> respuestasLlamadaSelec;
    public Encuesta encuestaDeCliente;
    public String descripcionEncuesta;
    public List<String> descripcionesRtas;

    public List<String> encuestaArmada;

    // Constructor
    public GestorConsulta(List<Llamada> llamadas, List<Encuesta> encuestas) {
        this.llamadas = llamadas;
        this.encuestas = encuestas;
    }

    // Métodos
    public void setPantalla(PantallaConsulta value) {  // Relaciona al gestor con la pantalla
        this.pantalla = value;
    }

    public void nuevaConsulta() {
        pantalla.solicitarPeriodo();
    }

    public void tomarFechaInicioPeriodo(Date fechaInicio) {
        fechaInicioPeriodo = fechaInicio;
    }

    public void tomarFechaFinPeriodo(Date fechaFin) {
        fechaFinPeriodo = fechaFin;
    }

    public void buscarLlamadas() {
        llamadasEncontradas.clear();

        for (Llamada llamada : llamadas) {
            if (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPeriodo) && llamada.tieneRespuestaDeCliente()) {
                llamadasEncontradas.add(llamada);
            }
        }

        pantalla.solicitarSeleccionLlamada(llamadasEncontradas);
    }

    public void tomarSeleccionLlamada(Date llamadaSeleccion) {
        for (Llamada llamada : llamadasEncontradas) {
            if (llamada.getFechaLlamada().equals(llamadaSeleccion)) {
                llamadaSeleccionada = llamada;
            }
        }

        buscarDatosLlamadaSeleccionada(llamadaSeleccionada);
    }

    public void buscarDatosLlamadaSeleccionada(Llamada llamadaSeleccion) {
        nombreClienteSeleccionado = llamadaSeleccion.getNombreClienteDeLlamada();
        duracionLlamadaSelec = llamadaSeleccion.getDuracion();
        estadoActualLlamadaSelec = llamadaSeleccion.getEstadoActual();

        buscarEncuestaDeLlamada(llamadaSeleccion);
    }

    private void buscarEncuestaDeLlamada(Llamada llamadaSeleccion) {
        respuestasLlamadaSelec = llamadaSeleccion.getRespuestas();

        for (Encuesta encuesta : encuestas) {
            if (encuesta.esEncuestaDeCliente(respuestasLlamadaSelec)) {
                encuestaDeCliente = encuesta;
                break;
            }
        }

        descripcionEncuesta = encuestaDeCliente.getDescripcionEncuesta();
        descripcionesRtas = buscarDescripciónRespuestas(llamadaSeleccion);
        encuestaArmada = encuestaDeCliente.armarEncuesta(descripcionesRtas);
        pantalla.solicitarMetodoImpresion(nombreClienteSeleccionado, duracionLlamadaSelec, estadoActualLlamadaSelec, descripcionEncuesta, descripcionesRtas, encuestaArmada);
    }

    public List<String> buscarDescripciónRespuestas(Llamada llamadaSeleccion) {
        return llamadaSeleccion.getDescripcionRespuestaDeEncuesta();
    }

    public void tomarSeleccionImpresion(int valorImpresion) {
        // Los métodos imprimir e imprimirCSV están vacíos en Java.
    }

    public void imprimir() {
        // Método vacío en Java
    }

    public void imprimirCSV() {
        // Método vacío en Java
    }

    public void finCU() {
        // Método vacío en Java
    }
}
