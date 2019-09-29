//https://www.hackerrank.com/challenges/insertionsort1/problem
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
    static void print(int[] arr){
        System.out.println(Arrays.toString(arr).replace("[","").replace("]","").replace(",",""));
    }

    static void insertionSort1(int n, int[] arr) {
        int insertValue = arr[n - 1];
        int j = n - 2;

        while(j >= 0){
            if(insertValue < arr[j])
                arr[j + 1] = arr[j];
            else
                break;
            print(arr);
            j--;
        }

        arr[j + 1] = insertValue;
        print(arr);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] arr = new int[n];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        insertionSort1(n, arr);

        scanner.close();
    }
}
