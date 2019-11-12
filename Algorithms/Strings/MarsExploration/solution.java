//https://www.hackerrank.com/challenges/mars-exploration/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int marsExploration(String s) {
        int count = 0;
        String sos = "SOS";

        for(int i = 0; i < s.length(); i++){
            if(s.charAt(i) != sos.charAt(i % 3))
                count++;
        }

        return count;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        int result = marsExploration(s);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}