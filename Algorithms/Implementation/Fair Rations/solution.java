// https://www.hackerrank.com/challenges/fair-rations/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int fairRations(int[] B) {
        int total = Arrays.stream(B).sum();
    
        if(total % 2 != 0)
            return -1;

        int count = 0;

        for(int i = 1; i < B.length; i++){
            if(B[i-1] % 2 != 0){
                count += 2;
                B[i]++;
            }
        }

        return count;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int N = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] B = new int[N];

        String[] BItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < N; i++) {
            int BItem = Integer.parseInt(BItems[i]);
            B[i] = BItem;
        }

        int result = fairRations(B);

        if(result == -1)
            bufferedWriter.write("NO");
        else
            bufferedWriter.write(String.valueOf(result));

        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
