public class Emisor {
    public void enviar(String mensaje) {
        for (int x = 0; x < 3; x++) {

            System.out.println(x + " " + mensaje);

            try {
                Thread.sleep(1000);

            } catch (InterruptedException e) {
                System.err.println(e);
            }
        }

    }
}
