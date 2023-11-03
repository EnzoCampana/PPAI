package dsi.g1.entidades;

import java.util.List;

public class Pregunta {
    private String pregunta;
    private List<RespuestaPosible> respuesta;

    public Pregunta(String pregunta, List<RespuestaPosible> respuesta) {
        this.pregunta = pregunta;
        this.respuesta = respuesta;
    }

    public String getPregunta() {
        return pregunta;
    }

    public List<RespuestaPosible> listarRespuestasPosibles() {
        return respuesta;
    }
    public boolean esTuRespuestaPosible(List<RespuestaDeCliente> respuestas) {
        for (RespuestaDeCliente resp : respuestas) {
            for (RespuestaPosible respPos : respuesta) {
                if (respPos.getDescripcion().equals(resp.getDescripcionRta())) {
                    return true;
                }
            }
        }
        return false;
    }

    public boolean esTuRespuestaAsociada(String resp) {
        for (RespuestaPosible respuestaPosible : respuesta) {
            if (respuestaPosible.getDescripcion().equals(resp)) {
                return true;
            }
        }
        return false;
    }

}
