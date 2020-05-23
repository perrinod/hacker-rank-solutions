// https://www.hackerrank.com/challenges/gem-stones/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static int gemstones(String[] arr) {
        Map rocks = new HashMap();

        for(int i = 0; i < arr.length; i++){
            for(int j = 0; j < arr[i].length(); j++){
                if(!rocks.containsKey(arr[i].charAt(j)))
                    rocks.put(arr[i].charAt(j), 0);
                    
                if((int)rocks.get(arr[i].charAt(j)) == i)
                    rocks.put(arr[i].charAt(j), i + 1);
            }
        }

        int count = 0;

        for(Object gem : rocks.values()){
            if((int)gem == arr.length)
                count++;
        }

        return count;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String[] arr = new String[n];

        for (int i = 0; i < n; i++) {
            String arrItem = scanner.nextLine();
            arr[i] = arrItem;
        }

        int result = gemstones(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
