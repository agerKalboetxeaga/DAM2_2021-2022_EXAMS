package unieibar;

public class KlaseHasiera {

	public static void main(String[] args) {
		// Elkarbanatutako objetu bat
		Agurra agurra = new Agurra();
		
		// Ikasleak sortu eta abiaraziko ditugu
		String[] ikasleak = {"Jorge", 
							"Patxi", 
							"Mikel", 
							"Sergio", 
							"Hegoi", 
							"Joseba", 
							"Aritz", 
							"Pablo", 
							"Jon Lopez",
							"Mikel",
							"Anatoli",
							"Asier",
							"Markel",
							"Jon Unzalu",
							"Alvaro"};
		for (int i=0; i<ikasleak.length; i++)
		{
			Ikaslea ik = new Ikaslea(ikasleak[i], agurra);
			ik.start();
		}
		
		// Irakaslea sortu eta abiaraziko dugu
		Irakaslea irakaslea = new Irakaslea("Mikel", agurra);
		irakaslea.start();
	}
}
