package iurretalhi;

public class PartekatutakoKontutikDiruaAtera {

	public static void main(String[] args) {
		KontuKorrontea kontua = new KontuKorrontea(40);
		DiruaAtera haria_1 = new DiruaAtera("Antxon", kontua);
		DiruaAtera haria_2 = new DiruaAtera("Maite", kontua);
		
		haria_1.start();
		haria_2.start();
	}

}
