// https://www.hackerrank.com/challenges/strong-password/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int minimumNumber(int n, String password) {
        int count = 0;

        if(!Pattern.matches(".*[a-z].*", password))
            count++;
        if(!Pattern.matches(".*[A-Z].*", password))
            count++;
        if(!Pattern.matches(".*[0-9].*", password))
            count++;
        if(Pattern.matches("^[a-zA-Z0-9]*", password))
            count++;

        return Math.max(count, 6 - n);

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String password = scanner.nextLine();

        int answer = minimumNumber(n, password);

        bufferedWriter.write(String.valueOf(answer));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
