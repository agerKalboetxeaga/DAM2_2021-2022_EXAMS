package iurretalhi;

public class KontuKorrontea {
	private int saldo;
	
	public KontuKorrontea (int saldo)
	{
		this.saldo = saldo;
	}
	
	int getSaldo()
	{
		return this.saldo;
	}
	
	void kendu(int kopurua)
	{
		this.saldo = this.saldo - kopurua;
	}
	
	public void diruaAtera(int kopurua, String nombre)
	{
		if (getSaldo() >= kopurua)
		{
			System.out.println("DIRUA ATERAKO DA KUTXAZAINETIK (ORAIN DAGOENA = " + getSaldo() + "€)");
			try
			{
				Thread.sleep(500);
			}
			catch(InterruptedException ex)
			{
				// Ez dugu ezer egiten
			}
			kendu(kopurua);
			System.out.println(nombre + "-k => " + kopurua + "€ ateratzen ditu kutxazainetik (ORAIN DAGOENA = " + getSaldo() + "€)");
		}
		else
		{
			System.out.println(nombre + "-k ezin du dirua atera, EZ DAGO BEHAR HAINA eta. Kopurua = " + getSaldo() + "€");
		}
		
		if(getSaldo() < 0)
		{
			System.out.println("SALDO NEGATIBOA => " + getSaldo());
		}
	}

}
