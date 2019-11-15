//https://www.hackerrank.com/challenges/making-anagrams/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int makingAnagrams(String s1, String s2) {
        int count = 0;

        for(char letter : s1.toCharArray()){
            int found = s2.indexOf(letter);
            if(found != -1){
                s2 = s2.substring(0, found) + s2.substring(found + 1, s2.length());
                count++;
            }
        }

        return s1.length() - count + s2.length();

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s1 = scanner.nextLine();

        String s2 = scanner.nextLine();

        int result = makingAnagrams(s1, s2);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
