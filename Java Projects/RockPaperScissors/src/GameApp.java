// Abagail Hankey
// 6/13/2020
// Intro To Java: Project 2, Rock, Paper, Scissors
// This is a simple rock, paper, scissors game.

import java.util.Scanner;
import java.util.Random;

/**
 *
 * @author abbih
 */
public class GameApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        //define variables
        
        boolean playing = true;
        Scanner input = new Scanner(System.in);
       
        

        //Get user choice
        Scanner scan = new Scanner(System.in);
        System.out.println("Please choose 1 for rock, 2 for paper, or 3 for scissors.");
        String userChoice = scan.nextLine();
        System.out.println("You entered \"" + userChoice + "\".");

        //Get computer choice
        int randNum = (int) (Math.random() * 3);
        String compChoice = "";
        switch (randNum) {
            case 0:
                compChoice = "R";
                break;
            case 1:
                compChoice = "P";
                break;
            case 2:
                compChoice = "S";
                break;
        }
        System.out.println("The computer entered \"" + compChoice + "\".");

        //Determine winner
        while (playing) {
            if (compChoice.equals("R")) {
                if (userChoice.equals("3")) {
                    System.out.println("The computer wins!");
                } else if (userChoice.equals ("2")) {
                    System.out.println("You win!");
                } else {
                    System.out.println("It's a tie!");
                }
            
            } else if (compChoice.equals("P")) {
                if (userChoice.equals("1")) {
                    System.out.println("The computer wins!");
                } else if (userChoice.equals("3")) {
                    System.out.println("You win!");
                } else {
                    System.out.println("It's a tie!");
                }
            
            } else if (compChoice.equals("S")) {
                if (userChoice.equals("2")) {
                    System.out.println("The computer wins!");
                } else if (userChoice.equals("1")) {
                    System.out.println("You win!");
                } else {
                    System.out.println("It's a tie!");
                }
            }   
        break;
        }
        //Where should this go??
        System.out.println("Do you wish to play again? Y/N");
        String answer = input.nextLine();
        playing = answer.equalsIgnoreCase("y");       
    }  
}    

