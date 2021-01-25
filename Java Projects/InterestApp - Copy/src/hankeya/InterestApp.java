
// Abagail Hankey
// 5/28/2020
// Intro To Java: Project 1
// This app calculates 

package hankeya;

import java.util.Scanner;

public class InterestApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //Print welcome statement
        System.out.println("Hello, this app calculates the accrued amount of money in a savings account based on number of years and interest rates.");
        
        
        //Create scanner object
        Scanner input = new Scanner(System.in);
        
        //Principal Amount input
        System.out.print("Please input the principal amount: ");
        double principalAmount = input.nextDouble();
        
        //APR input
        System.out.print("Please input the APR: ");
        double annualPercentageRate = input.nextDouble();
        
        //Term input
        System.out.print("Please input the number of years: ");
        int numberOfYears = input.nextInt();
        
        //Calculate Monthly Rate
        double monthlyRate = (annualPercentageRate / 1200) +1 ;
        
        //Calculate Annual Rate
        double annualRate = Math.pow(monthlyRate, 12);
        
        //Calculate Final Term Rate
        double finalTermRate = Math.pow(annualRate, numberOfYears);
        
        //Calculate Accrued Amount
        double accruedAmount = finalTermRate * principalAmount;
        
        //Print Accrued Amount
        System.out.print(accruedAmount);
        
        
    }
    
}
