// https://www.hackerrank.com/challenges/3d-surface-area/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int surfaceArea(int[][] A) {
        int area = 0;

        for(int i = 0; i < A.length; i++){
            for(int j = 0; j < A[i].length; j++){
                area += 4 * A[i][j] + 2;

                if(i + 1 < A.length)
                    area -= 2 * Math.min(A[i][j], A[i + 1][j]);

                if(j + 1 < A[i].length)
                    area -= 2 * Math.min(A[i][j], A[i][j + 1]);
            }   
        }

        return area;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] HW = scanner.nextLine().split(" ");

        int H = Integer.parseInt(HW[0]);

        int W = Integer.parseInt(HW[1]);

        int[][] A = new int[H][W];

        for (int i = 0; i < H; i++) {
            String[] ARowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < W; j++) {
                int AItem = Integer.parseInt(ARowItems[j]);
                A[i][j] = AItem;
            }
        }

        int result = surfaceArea(A);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
