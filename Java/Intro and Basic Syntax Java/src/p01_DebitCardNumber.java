import java.util.Scanner;

/**
 * Created by Stefan on 28.05.2017.
 */
public class p01_DebitCardNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int digits01 = Integer.parseInt(scanner.nextLine());
        int digits02 = Integer.parseInt(scanner.nextLine());
        int digits03 = Integer.parseInt(scanner.nextLine());
        int digits04 = Integer.parseInt(scanner.nextLine());

        System.out.printf("%04d %04d %04d %04d", digits01, digits02, digits03, digits04);

    }
}
