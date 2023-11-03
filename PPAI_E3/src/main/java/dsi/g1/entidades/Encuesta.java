package dsi.g1.entidades;

import java.util.List;

public class Encuesta {
    //atributos
    private String descripcion;
    private List<Pregunta> pregunta;

    //constructor

    public Encuesta(String descripcion, List<Pregunta> pregunta) {
        this.descripcion = descripcion;
        this.pregunta = pregunta;
    }

    //metodos

    public String getDescripcion() {
        return descripcion;
    }


}
