package dsi.g1.entidades;

import java.util.Date;

public class RespuestaDeCliente {
    private Date fechaEncuesta;
    private RespuestaPosible respuestaSeleccionada;

    public RespuestaDeCliente(Date fechaEncuesta, RespuestaPosible respuestaSeleccionada) {
        this.fechaEncuesta = fechaEncuesta;
        this.respuestaSeleccionada = respuestaSeleccionada;
    }

    public RespuestaPosible getRespuestaSeleccionada() {
        return respuestaSeleccionada;
    }
    public String getDescripcionRta(){
        return respuestaSeleccionada.getDescripcion();
    }
}
