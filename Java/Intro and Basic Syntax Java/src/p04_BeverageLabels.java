import java.text.DecimalFormat;
import java.util.Scanner;

/**
 * Created by Stefan on 28.05.2017.
 */
public class p04_BeverageLabels {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        double volume = Double.parseDouble(scanner.nextLine());
        double energy = Double.parseDouble(scanner.nextLine());
        double sugar = Double.parseDouble(scanner.nextLine());

        double energyCal = (volume * energy) / 100;
        double sugarCal = ((volume * sugar) / 100);

        String energyStr = new DecimalFormat("0.####").format(energyCal);
        String sugarStr = new DecimalFormat("0.####").format(sugarCal);

        System.out.printf("%.0fml %s:%n", volume, name);
        System.out.printf("%skcal, %sg sugars", energyStr, sugarStr);

    }
}
