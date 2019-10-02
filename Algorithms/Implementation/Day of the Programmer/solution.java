//https://www.hackerrank.com/challenges/day-of-the-programmer/problem
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

    static String dayOfProgrammer(int year) {
        String s;
        if(year == 1918)
        return "26.09." + year;

        if(year < 1918){
            s = year % 4 == 0 ? "12.09." : "13.09.";
        }
        else{
            s = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? "12.09." : "13.09.";

        }

        return s + year;

    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int year = Integer.parseInt(bufferedReader.readLine().trim());

        String result = dayOfProgrammer(year);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}