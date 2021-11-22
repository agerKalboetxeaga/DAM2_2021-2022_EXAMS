public class Main {
    public static void main(String[] args) {
        Emisor emisor = new Emisor();

        Mensaje primer = new Mensaje("hola", emisor);
        Mensaje primer2 = new Mensaje("adios", emisor);
        primer.start();
        primer2.start();
    }
}
