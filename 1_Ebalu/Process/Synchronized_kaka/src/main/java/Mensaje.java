public class Mensaje extends Thread {
    private String mensaje;
    private Emisor emisor;

    public Mensaje(String mensaje, Emisor emisor) {
        this.mensaje = mensaje;
        this.emisor = emisor;
    }

    @Override
    public  void run() {
        synchronized(Main.class){       //Se puede sincroinizar en base a la clase que crea el hilo
                                        //o segun el metodo peligroso que se este ejecutando
            emisor.enviar(mensaje);
        }

    }
}
