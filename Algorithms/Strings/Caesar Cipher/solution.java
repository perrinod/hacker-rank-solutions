// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String caesarCipher(String s, int k) {
        StringBuilder encryptedString = new StringBuilder(s);

        for(int i = 0; i < s.length(); i++){
            if(Character.isLetter(s.charAt(i))){
                char a = Character.isUpperCase(s.charAt(i)) ? 'A' : 'a';
                encryptedString.setCharAt(i, (char)(a + (s.charAt(i) - a + k) % 26));
            }
        }

        return encryptedString.toString();

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String s = scanner.nextLine();

        int k = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String result = caesarCipher(s, k);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}