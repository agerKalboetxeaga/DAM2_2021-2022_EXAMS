package unieibar;

public class Irakaslea extends Thread {
	private String izena;
	private Agurra agurra;
	
	public Irakaslea(String izena, Agurra agurra)
	{
		this.izena = izena;
		this.agurra = agurra;
	}

	public void run()
	{
		System.out.println(this.izena + " IRAKASLEA heldu da klasera.");
		try
		{
			Thread.sleep(3000);
			this.agurra.egunOnIkasleMaiteok(this.izena);
		}
		catch(InterruptedException ex)
		{
			System.err.println("IRAKASLE haria eten egin da!");
		}
	}
}
