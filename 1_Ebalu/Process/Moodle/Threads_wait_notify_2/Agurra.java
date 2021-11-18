package unieibar;

public class Agurra {
	private boolean klasea_hasi_da;
	
	public Agurra()
	{
		this.klasea_hasi_da = false;
	}
	
	// Irakasleak agurtu arte, ezin da klasea hasi
	// beraz, ikasle guztiek wait() batekin itxarongo dute 
	public synchronized void egunOnIrakasle(String nork_hitzegiten_du)
	{
		try
		{
			while (this.klasea_hasi_da == false)
			{
				wait();
			}
			System.out.println(nork_hitzegiten_du + ": Egun on irakasle!!!");
		}
		catch (InterruptedException ex)
		{
			ex.printStackTrace();
		}
	}

	// Irakasleak soilik deituko du metodo hau
	// notifyAll()-ekin, gainontzeko ikasle guztien wait() lerrotik irten araziko ditu
	public synchronized void egunOnIkasleMaiteok(String nork_hitzegiten_du)
	{
		System.out.println(nork_hitzegiten_du + ": Egun on ikasle maiteok!!!");
		this.klasea_hasi_da = true;
		notifyAll();
	}
}
