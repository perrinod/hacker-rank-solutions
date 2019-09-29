//https://www.hackerrank.com/challenges/encryption/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String encryption(String s) {
        int size = s.length();
        String encrypted = "";
        int L = (int) Math.floor(Math.sqrt(size));
        int b = (L * L >= size) ? L : L + 1;
    
        for(int i = 0; i < b; i++){
            for(int j = i; j < size;){
                encrypted = encrypted + s.charAt(j);
                j = b + j;
            }
            encrypted = encrypted + " ";
        }

        return encrypted;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = encryption(s);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}