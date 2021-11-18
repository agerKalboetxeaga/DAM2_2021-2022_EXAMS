package padre_hijo;

import java.util.Scanner;

public final class StringTransform
{

      public static void main(String[] args)
      {
            
            try (Scanner sc= new Scanner(System.in);)
            {
                  String line = "";
                  do
                  {
                        line =sc.nextLine();
                        System.out.println(line.toUpperCase());
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
