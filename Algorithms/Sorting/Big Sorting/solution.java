//https://www.hackerrank.com/challenges/big-sorting/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class sortFunction implements Comparator<String>{
    @Override
    public int compare(String a, String b){
        if(a.length() == b.length())
            return a.compareTo(b);

        return a.length() - b.length();
    }
}

public class Solution {

    static String[] bigSorting(String[] unsorted) {
        Arrays.sort(unsorted, new sortFunction());
        return unsorted;
    }

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

        StringTokenizer st = new StringTokenizer(bufferedReader.readLine());

        int n = Integer.parseInt(st.nextToken());

        String[] unsorted = new String[n];

        for (int i = 0; i < n; i++) {
            String unsortedItem = bufferedReader.readLine();
            unsorted[i] = unsortedItem;
        }

        String[] result = bigSorting(unsorted);

        for (int i = 0; i < result.length; i++) {
            bufferedWriter.write(result[i]);

            if (i != result.length - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedWriter.close();
    }
}