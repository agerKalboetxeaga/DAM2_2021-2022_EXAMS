package iurretalhi;

public class DiruaAtera extends Thread {
	private KontuKorrontea kontua;
	private String izena;
	
	public DiruaAtera(String izena, KontuKorrontea kontua)
	{
		super(izena);
		this.izena = izena;
		this.kontua = kontua;
	}
	
	public void run()
	{
		for (int i=0; i<4; i++)
		{
			this.kontua.diruaAtera(10, this.izena);
		}
	}
}
