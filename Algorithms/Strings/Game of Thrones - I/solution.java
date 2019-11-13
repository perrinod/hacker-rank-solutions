//https://www.hackerrank.com/challenges/game-of-thrones/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String gameOfThrones(String s) {
        char[] charArray  = s.toCharArray();
        Arrays.sort(charArray);
        s = new String(charArray);

        boolean palindrome = s.length() % 2 == 0 ? true : false;

        for(int i = 0, j = 0; j < s.length(); j++){
            if(s.charAt(i) != s.charAt(j)){
                if((j - i) % 2 != 0){
                    if(palindrome)
                        return "NO";
                    palindrome = true;
                }
            
                i = j;
            }
        }

        return "YES";

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = gameOfThrones(s);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}