package dsi.g1.entidades;

public class RespuestaPosible {
    private String descripcion;
    private int valor;

    public RespuestaPosible(String descripcion, int valor) {
        this.descripcion = descripcion;
        this.valor = valor;
    }
    public String getDescripcion(){
        return descripcion;
    }
}
