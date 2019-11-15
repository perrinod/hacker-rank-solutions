//https://www.hackerrank.com/challenges/java-string-reverse/problem
import java.io.*;
import java.util.*;

public class Solution {

    static String Palindrome(String s) {
        char[] charArray  = s.toCharArray();
        Arrays.sort(charArray);
        s = new String(charArray);

        boolean palindrome = s.length() % 2 == 0 ? true : false;

        for(int i = 0, j = 0; j < s.length(); j++){
            if(s.charAt(i) != s.charAt(j)){
                if((j - i) % 2 != 0){
                    if(palindrome)
                        return "No";
                    palindrome = true;
                }
            
                i = j;
            }
        }

        return "Yes";

    }

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        System.out.println(Palindrome(A));
        
    }
}

