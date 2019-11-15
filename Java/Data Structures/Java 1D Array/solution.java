//https://www.hackerrank.com/challenges/java-1d-array-introduction/problem
import java.util.*;

public class Solution {

    public static void main(String[] args) {
	   
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int a[] = new int[n];
        for(int i = 0; i < a.length; i++){
            a[i] = scan.nextInt();
        }
        scan.close();

        for (int i = 0; i < a.length; i++) {
            System.out.println(a[i]);
        }
    }
}