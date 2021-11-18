package unieibar;

public class Ikaslea extends Thread{
	private String izena;
	private Agurra agurra;
	
	public Ikaslea(String izena, Agurra agurra)
	{
		this.izena = izena + " (ikaslea)";
		this.agurra = agurra;
	}

	public void run()
	{
		System.out.println(this.izena + " heldu da klasera.");
		try
		{
			Thread.sleep(1000);
			this.agurra.egunOnIrakasle(this.izena);
		}
		catch(InterruptedException ex)
		{
			System.err.println("Ikasle haria eten egin da!");
		}
	}
}
