//https://www.hackerrank.com/challenges/reduced-string/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

public class Solution {

    static String superReducedString(String s) {
        int i = 0;
        while(i < s.length() - 1){
            if(s.charAt(i) == s.charAt(i+1)){
                s = s.substring(0,i) + s.substring(i+2);
                if(i != 0)
                    i--;
            }
            else
                i++;
        }

        if(s.length() == 0)
            s = "Empty String";

        return s;

    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = bufferedReader.readLine();

        String result = superReducedString(s);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
