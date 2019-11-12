//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String hackerrankInString(String s) {
        String hackerRank = "hackerrank";
        if(s.length() < hackerRank.length())
            return "NO";

        int i = 0;
        for(char c : s.toCharArray()){
            if(hackerRank.charAt(i) == c)
                i++;
        
            if(i == hackerRank.length())
                return "YES";
        }

        return "NO";

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            String result = hackerrankInString(s);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}