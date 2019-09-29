//https://www.hackerrank.com/challenges/bon-appetit/problem
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

    static int sum(List<Integer> bill){
        int sum = 0;
        for(int i = 0; i < bill.size(); i++)
            sum += bill.get(i);

        return sum;
    }

    static void bonAppetit(List<Integer> bill, int k, int b) {
        int total = (sum(bill) - bill.get(k)) / 2;
        String output = (total == b) ? "Bon Appetit" : (b - total) + "";

        System.out.println(output);
    }

    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        String[] nk = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        List<Integer> bill = Stream.of(bufferedReader.readLine().replaceAll("\\s+$", "").split(" "))
            .map(Integer::parseInt)
            .collect(toList());

        int b = Integer.parseInt(bufferedReader.readLine().trim());

        bonAppetit(bill, k, b);

        bufferedReader.close();
    }
}
