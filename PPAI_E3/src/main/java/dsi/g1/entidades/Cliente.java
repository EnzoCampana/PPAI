package dsi.g1.entidades;

public class Cliente {
    //atributos
    private int dni;
    private String nombreCompleto;
    private int nroCelular;
    //constructor

    public Cliente(int dni, String nombreCompleto, int nroCelular) {
        this.dni = dni;
        this.nombreCompleto = nombreCompleto;
        this.nroCelular = nroCelular;
    }
    // metodos

    public String getNombre() {
        return nombreCompleto;
    }
}
