import java.util.Scanner;

/**
 * Created by Stefan on 28.05.2017.
 */
public class p03_MilesToKilometers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double kilometers = Double.parseDouble(scanner.nextLine());
        double converter = kilometers * 1.60934;

        System.out.printf("%.2f", converter);


    }
}
