package padre_hijo;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.util.Scanner;

public final class ExportToFile
{

      public static void main(String[] args)
      {
            try (Scanner sc = new Scanner(System.in);
                  var bffWritter = new BufferedWriter(new FileWriter(new File("ExportText.txt"))))
            {
                  String line = "";
                  do
                  {
                        line = sc.nextLine();
                        bffWritter.write(line);
                        bffWritter.newLine();
                  }
                  while (!line.isBlank());
            }
            catch (Exception ex)
            {
                  ex.printStackTrace();
                  System.out.println(ex.getMessage());
            }
      }

}
