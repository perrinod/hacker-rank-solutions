//https://www.hackerrank.com/challenges/time-conversion/problem
import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

public class Solution {

    static String timeConversion(String s) {
        String meridian = s.substring(s.length() - 2, s.length());
        String ms = s.substring(2, s.length() - 2);
        int hour = Integer.parseInt(s.substring(0,2));

     hour = ((meridian.equals("AM") && hour == 12) ? 0 : (meridian.equals("PM") && hour != 12) ? (hour + 12) : hour);


        return ((hour < 12) ? ("0" + hour) : hour) + ms;

    }

    private static final Scanner scan = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bw = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scan.nextLine();

        String result = timeConversion(s);

        bw.write(result);
        bw.newLine();

        bw.close();
    }
}
