package com.sonicscholar;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        int r = 0;
        Random random = new Random();
        while(r < 5)
        {
            //pick a number between 0 and 10
            r = random.nextInt(10);
            System.out.println("random number: " + r);
        }


        String[] words = { "this", "is", "an", "array", "of", "strings" };
        System.out.println("for loop");
        for(int i=0; i<words.length; i++)
        {
            String word = words[i];
            System.out.print(word + " ");
        }
        System.out.print("\n\n"); //2 new line characters


        for (var word : words)
        {
            if(word.equals("is"))
            {
                System.out.print("definitely is ");
                continue;
            }
            else if (word.equals("array"))
            {
                System.out.print("amazing loop structure!");
                break;
            }
            System.out.print(word + " ");
        }
    }
}
