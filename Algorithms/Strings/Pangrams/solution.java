//https://www.hackerrank.com/challenges/pangrams/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String pangrams(String s) {
        HashSet<String> sentence = new HashSet<String>();

        for(char letter : s.toCharArray()){
            sentence.add(String.valueOf(Character.toLowerCase(letter)));
            if(sentence.size() == 27)
                return "pangram";
        }

        return "not pangram";

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = pangrams(s);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}