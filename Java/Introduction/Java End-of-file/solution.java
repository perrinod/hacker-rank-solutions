//https://www.hackerrank.com/challenges/java-end-of-file/problem
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        int i = 1;
        Scanner scan = new Scanner(System.in);
        while(scan.hasNext()){
            String s = scan.nextLine();
            System.out.println(i + " " + s);
            i++;
        }
    }
}
