package dsi.g1.entidades;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Llamada {
    private int duracion;
    private boolean encuestaEnviada;
    private Cliente cliente;
    private List<CambioDeEstado> cambioDeEstado;
    private List<RespuestaDeCliente> respuestasDeEncuesta;
    private CambioDeEstado cambioActual;

    public Llamada(int duracion, boolean encuestaEnviada, Cliente cliente, List<CambioDeEstado> cambioDeEstado, List<RespuestaDeCliente> respuestasDeEncuesta, CambioDeEstado cambioActual) {
        this.duracion = duracion;
        this.encuestaEnviada = encuestaEnviada;
        this.cliente = cliente;
        this.cambioDeEstado = cambioDeEstado;
        this.respuestasDeEncuesta = respuestasDeEncuesta;
        this.cambioActual = cambioActual;
    }
    //metodos
    public Date getFechaLlamada() {
        CambioDeEstado cambioMasAntiguo = null;

        for (CambioDeEstado cambioEstado : cambioDeEstado) {
            if (cambioMasAntiguo == null || cambioEstado.getFechaHoraInicio().before(cambioMasAntiguo.getFechaHoraInicio())) {
                cambioMasAntiguo = cambioEstado;
            }
        }
        return cambioMasAntiguo.getFechaHoraInicio();
    }

    public boolean esDePeriodo(Date fechaInicio, Date fechaFin) {
        return getFechaLlamada().after(fechaInicio) && getFechaLlamada().before(fechaFin);
    }

    public int getDuracion() {
        return duracion;
    }
    public boolean tieneRespuestaDeCliente() {
        return !respuestasDeEncuesta.isEmpty();
    }
    public String getNombreClienteDeLlamada() {
        return cliente.getNombre();
    }


    //getRespuestas()
    public List<RespuestaDeCliente> getRespuestasDeEncuesta() {
        return respuestasDeEncuesta;
    }

    public List<String> getDescripcionRespuestaDeEncuesta() {
        List<String> descripcionRespuestas = new ArrayList<>();

        for (RespuestaDeCliente resp : respuestasDeEncuesta) {
            descripcionRespuestas.add(resp.getDescripcionRta());
        }

        return descripcionRespuestas;
        }

    }
