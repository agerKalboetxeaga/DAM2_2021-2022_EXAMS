package padre_hijo;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.charset.Charset;
import java.util.Scanner;

public class PrincipalExecutor
{

      private final static String ENTER = "\n";
      static File path = new File("C:\\Users\\kalboetxeaga.ager\\Desktop\\EClipse ACTIV\\GIT_REPOSITORY\\ProcessJavaSample\\target\\classes"); //file para escribir en
      private final static File FILE = new File("export.txt");

      public static void main(String[] args) throws IOException,InterruptedException
      {

            var processTransf = new ProcessBuilder("java","org.jeycode.pm.StringTransform").redirectErrorStream(true)
                                                                                           .directory(path) //donde quieres que se ejecute
                                                                                           .start();

            var processExp = new ProcessBuilder("java","org.jeycode.pm.ExportToFile",FILE.toString()).redirectErrorStream(true)
                                                                                                     .directory(path)
                                                                                                     .start();

            var osTransfStream = processTransf.getOutputStream();
            var inTransfStream = processTransf.getInputStream();
            var oWriteStream = processExp.getOutputStream();

            System.out.println("Introduce texto a formatear");

            try (Scanner sc = new Scanner(System.in);
                 var bffTransfReader = new BufferedReader(new InputStreamReader(inTransfStream,Charset.forName("UTF-8")))) //buffer del proceso hijo
            {
                  String line = "";

                  do
                  {
                        line = sc.nextLine();
                        osTransfStream.write((line + ENTER).getBytes()); //mandamos los datos
                        osTransfStream.flush(); //flusheamos
                        var lineTransf = bffTransfReader.readLine(); //leemos el resuldado de vuelta
                        System.out.println(lineTransf); //lo imprimimos
                        oWriteStream.write((lineTransf + ENTER).getBytes());
                        oWriteStream.flush();

                  }
                  while (!line.isBlank());

                  if (processExp.waitFor() == 0 && processTransf.waitFor() == 0)
                  {
                        System.out.println("Se terminó la ejecución");
                  }
                  else
                  {
                        System.out.println("Error");
                  }

            }

      }
}