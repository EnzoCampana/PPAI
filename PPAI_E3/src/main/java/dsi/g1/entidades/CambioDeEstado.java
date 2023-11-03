package dsi.g1.entidades;

import java.util.Date;

public class CambioDeEstado {

    // atributos
    private Date fechaHoraInicio;
    private Estado estado;

    //constructor
    public CambioDeEstado(Date fechaHoraInicio, Estado estado) {
        this.fechaHoraInicio = fechaHoraInicio;
        this.estado = estado;
    }

    // getters y setters
    public Date getFechaHoraInicio() {
        return fechaHoraInicio;
    }

    public Estado getEstado() {
        return estado;
    }

    public void esEstadoInicial(){}

    public boolean esUltimoEstado(CambioDeEstado cambioAComparar)
    {
        return this.fechaHoraInicio.after(cambioAComparar.getFechaHoraInicio());
    }
}
