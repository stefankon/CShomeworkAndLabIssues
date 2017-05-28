import java.util.Scanner;

/**
 * Created by Stefan on 28.05.2017.
 */
public class p05_CharacterStats {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        int currentHealth = Integer.parseInt(scanner.nextLine());
        int maximumHealth = Integer.parseInt(scanner.nextLine());
        int currentEnergy = Integer.parseInt(scanner.nextLine());
        int maximumEnergy = Integer.parseInt(scanner.nextLine());

        String heltDots = repeatCount(".", maximumHealth - currentHealth);
        String heltPipes = repeatCount("|", currentHealth);
        String energyDots = repeatCount(".", maximumEnergy - currentEnergy);
        String energyPipes = repeatCount("|", currentEnergy);

        System.out.printf("Name: %s%n", name);
        System.out.printf("Health: |%s%s|%n", heltPipes, heltDots);
        System.out.printf("Energy: |%s%s|", energyPipes, energyDots);

    }




    public static String repeatCount(String text, int count) {
        String output = "";

        for (int i = 0; i < count; i++) {

            output = output + text;

        }
        return output;

    }
}
