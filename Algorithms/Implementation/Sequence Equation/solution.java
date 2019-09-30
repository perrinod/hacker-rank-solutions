//https://www.hackerrank.com/challenges/permutation-equation/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
    
    static int indexOfIntArray(int[] p, int value){
        int returnValue = 0;

        for(int i = 0; i < p.length; i++)
            if(value == p[i]){
                returnValue = i;
                break;
            }

        return returnValue;
    }

    static int[] permutationEquation(int[] p) {
        int value = 0;
        int[] q = new int[p.length];

        for(int i = 0; i < p.length; i++){
            value = i + 1;

            value = indexOfIntArray(p, value) + 1;
            value = indexOfIntArray(p, value) + 1;
            q[i] = value;
        }

        return q;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] p = new int[n];

        String[] pItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int pItem = Integer.parseInt(pItems[i]);
            p[i] = pItem;
        }

        int[] result = permutationEquation(p);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(String.valueOf(result[i]));

            if (i != result.length - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}