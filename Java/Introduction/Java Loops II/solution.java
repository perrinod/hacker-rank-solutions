//https://www.hackerrank.com/challenges/java-loops/problem
import java.util.*;
import java.io.*;

class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t=in.nextInt();
        for(int i=0;i<t;i++){

            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();
            int s = a + 1 * b;
            int c = 1;

            System.out.print(s + " ");

            for(int j = 0; j < n - 1; j++){
                c = c * 2;
                s += c * b;
                System.out.print(s + " ");
            }

            System.out.println();
        }
        in.close();
    }
}
