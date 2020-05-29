// https://www.hackerrank.com/challenges/cavity-map/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static String[] cavityMap(String[] grid) {
        for(int i = 1; i < grid.length - 1; i++){
            for(int j = 1; j < grid[i].length() - 1; j++){
                char number = grid[i].charAt(j);
                if(number > grid[i+1].charAt(j) && number > grid[i-1].charAt(j) && number > grid[i].charAt(j+1) && number > grid[i].charAt(j-1))
                    grid[i] = grid[i].substring(0, j) + 'X' + grid[i].substring(j + 1, grid[i].length());
            }
        }

        return grid;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String[] grid = new String[n];

        for (int i = 0; i < n; i++) {
            String gridItem = scanner.nextLine();
            grid[i] = gridItem;
        }

        String[] result = cavityMap(grid);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(result[i]);

            if (i != result.length - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}