// https://www.hackerrank.com/challenges/grid-challenge/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String gridChallenge(String[] grid) {
        char[] string = grid[0].toCharArray();
        Arrays.sort(string);
        grid[0] = new String(string);

        for(int i = 1; i < grid.length; i++){
            string = grid[i].toCharArray();
            Arrays.sort(string);
            grid[i] = new String(string);

            for(int j = 0; j < grid[i].length(); j++){
                if(grid[i-1].charAt(j) > grid[i].charAt(j))
                    return "NO";
            }

        }

        return "YES";
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int tItr = 0; tItr < t; tItr++) {
            int n = scanner.nextInt();
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            String[] grid = new String[n];

            for (int i = 0; i < n; i++) {
                String gridItem = scanner.nextLine();
                grid[i] = gridItem;
            }

            String result = gridChallenge(grid);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
