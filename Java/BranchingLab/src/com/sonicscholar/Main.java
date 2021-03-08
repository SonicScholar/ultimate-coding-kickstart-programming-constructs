package com.sonicscholar;

import java.util.Random;

public class Main {

    public static void main(String[] args) {
        int a = 6;
        boolean divisibleByTwo = a % 2 == 0;
        boolean divisibleByThree = a % 3 == 0;

        if(divisibleByTwo)
        {
            System.out.println(a + " is divisible by 2");
        }
        else if(divisibleByThree)
        {
            System.out.println(a + " is divisible by 3");
        }
        else
        {
            System.out.println(a + "is not divisible by 2 or 3");
        }


        //random number
        Random random = new Random();
        a = random.nextInt() % 5;
        System.out.println("Random number generated: " + a);
        switch(a)
        {
            case 0:
                System.out.println("case 0");
                break;
            case 1:
                System.out.println("case 1");
                break;
            case 2:
                System.out.println("case 2");
                break;
            default:
                System.out.println("default case");
                break;
        }
    }
}
