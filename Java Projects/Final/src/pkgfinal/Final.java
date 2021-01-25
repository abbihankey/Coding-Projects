/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkgfinal;

import java.util.Scanner;
public class Final {


    public static void main(String[] args) {

        Scanner sc;

        sc = new Scanner(System.in);

        char cardType;

        boolean doMore = true;

        int totalBatter = 0;

        int totalInfield = 0;

        int totalOutfield = 0;

        do {

            System.out.print("Enter card type (B/I/O): ");

            cardType = (sc.nextLine()).charAt(0);

            switch (cardType) {

                case 'B':

                    totalBatter++;

                case 'I':

                    totalInfield++;

                case 'O':

                    totalOutfield++;

                default:

                    System.out.println("Bad Card Type ");

            }

            System.out.print("Enter another card (Y/N): ");

            cardType = (sc.nextLine()).charAt(0);

            if (cardType == 'Y') {
                doMore = true;
            } else {
                doMore = false;
            }

        } while (doMore);

    }

}
    
