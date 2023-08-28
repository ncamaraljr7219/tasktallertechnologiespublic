import java.util.HashMap;

public class Main {
    public static int taskTallerTechnologies(String s) {
        int n = s.length();
        HashMap<Character, Integer> charIndex = new HashMap<>();
        int start = 0;
        int maxLength = 0;

        for (int end = 0; end < n; end++) {
            if (charIndex.containsKey(s.charAt(end)) && charIndex.get(s.charAt(end)) >= start) {
                start = charIndex.get(s.charAt(end)) + 1;
            }
            charIndex.put(s.charAt(end), end);
            maxLength = Math.max(maxLength, end - start + 1);
        }

        return maxLength;
    }

    public static void main(String[] args) {
        String inputStr = "BBBB";
        System.out.println("Length of the longest substring for BBBB: " + taskTallerTechnologies(inputStr));

        inputStr = "ABDEFGABEF";
        System.out.println("Length of the longest substring for ABDEFGABEF: " + taskTallerTechnologies(inputStr));

        inputStr = "GEEKSFORGEEKS";
        System.out.println("Length of the longest substring for GEEKSFORGEEKS: " + taskTallerTechnologies(inputStr));

        java.util.Scanner scanner = new java.util.Scanner(System.in);
        System.out.print("Enter a string: ");
        inputStr = scanner.nextLine();
        System.out.println("Length of the longest substring inserted by User: " + taskTallerTechnologies(inputStr));
    }
}
