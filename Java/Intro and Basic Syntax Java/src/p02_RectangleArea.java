import java.util.Scanner;

/**
 * Created by Stefan on 28.05.2017.
 */
public class p02_RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double wight = Double.parseDouble(scanner.nextLine());
        double height = Double.parseDouble(scanner.nextLine());
        double area = wight * height;

        System.out.printf("%.2f", area);


    }
}
