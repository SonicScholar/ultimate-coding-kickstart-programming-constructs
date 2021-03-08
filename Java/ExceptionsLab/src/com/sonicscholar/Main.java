package com.sonicscholar;

import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
        String[] fruits = new String[] { "apple", "banana", "kiwi", "grapefruit", "orange", "pineapple" };

        try
        {
            boolean contains;
            String fruit;

            //1. this works
            fruit = "grapefruit";
            contains = ContainsString(fruits, fruit);
            FormatAndPrintMessage(fruit, contains);

            //2. this works
            fruit = "BANANA";
            contains = ContainsString(fruits, fruit);
            FormatAndPrintMessage(fruit, contains);

            //3. This doesn't work.. fix it!
            //it should print. "The list did not contain the value: lime"
            fruit = "lime";
            contains = ContainsString(fruits, fruit);
            FormatAndPrintMessage(fruit, contains);

            //4. This doesn't work.. fix it!
            //it should print, "The list did not contain the value: (null)"
            fruit = null;
            contains = ContainsString(fruits, fruit);
            FormatAndPrintMessage(fruit, contains);
        }
        catch (Exception e)
        {
            System.out.println("A bug needs to be fixed!\r\n");
            e.printStackTrace();
            throw e;
        }

        System.out.println("Congrats! The program finished without errors!");

        System.out.println("Press enter to exit...");
        Scanner scanner = new Scanner(System.in);
        scanner.nextLine();
    }

    //simple linear search algorithm. contains a bug. find and fix it!
    public static boolean ContainsString(String[] array, String value)
    {
        for (int i = 0; i <= array.length; i++)
        {
            if (array[i].toLowerCase().equals(value.toLowerCase()))
                return true;
        }
        return false;
    }

    public static void FormatAndPrintMessage(String value, boolean contains)
    {
        String s = "The list did ";
        if (!contains)
            s += "not ";

        s += "contain the value: " + value;
        System.out.println(s);
    }
}
