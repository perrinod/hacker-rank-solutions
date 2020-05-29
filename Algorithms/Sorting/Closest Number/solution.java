// https://www.hackerrank.com/challenges/closest-numbers/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int[] closestNumbers(int[] arr) {
        Arrays.sort(arr);
        ArrayList<Integer> closest = new ArrayList<Integer>();

        int minimum = Integer.MAX_VALUE;

        for(int i = 1; i < arr.length; i++){
            if(arr[i] - arr[i-1] < minimum)
                closest.clear();
            
            if(arr[i] - arr[i-1] <= minimum){
                minimum = arr[i] - arr[i-1];
                closest.add(arr[i-1]);
                closest.add(arr[i]);
            }
        }

        int[] ans = new int[closest.size()];
        for(int i = 0; i < closest.size(); i++)
            ans[i] = closest.get(i).intValue();

        return ans;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] arr = new int[n];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        int[] result = closestNumbers(arr);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(String.valueOf(result[i]));

            if (i != result.length - 1) {
                bufferedWriter.write(" ");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
