//https://www.hackerrank.com/challenges/anagram/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int anagram(String s) {
        if(s.length() % 2 != 0)
            return -1;
    
        String s1 = s.substring(0, s.length() / 2);
        String s2 = s.substring(s.length() / 2, s.length());

        int count = 0;

        for(char letter : s1.toCharArray()){
            int found = s2.indexOf(letter);
            if(found != -1)
                s2 = s2.substring(0, found) + s2.substring(found + 1, s2.length());
            else
                count++;

        }

        return count;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = anagram(s);

            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
