#------------------------------------------------------------
#Program:          ATM Program
#Programmer:       Abbi Hankey
#Date:             02/06/2020
#Abstract:         This programs processes deposits,
#                    withdrawals, and invalid transaction
#                    codes, and provides a current balance.
#------------------------------------------------------------

def main():
    Name = input("What is your name? ")
    Account_ID = input("What is your account ID? ")
    Transaction_Code = input("Press W or w for withdrawal, Press D or d for Deposit ")
    Previous_Balance = float(input("What is your previous balance? "))
    Transaction_Amount = float(input("How much is the transaction? ")
    
if Transaction_Code == 'W' or Transaction_Code == 'w'
                Withdrawal_Process (Previous_Balance, Transaction_Amount)
    
elif (Transaction_Code == 'D' or Transaction_Code == 'd'):
                Deposit_Process(Previous_Balance, Transaction_Amount)
    else:
                Process_Invalid_Code(Previous_Balance)

#The invalid code function definition
def Process_Invalid_Code(Previous_Balance) :
    New_Balance = Previous_Balance
    print ("Invalid Transaction code: ")
    print ("Please type W or w for withdrawal")
    print ("or type D or d for Deposit")
    print_Function(New_Balance)
    
#Defines the Deposit Process
def Deposit_Process(Previous_Balance, Transaction_Amount):
    New_Balance = Transaction_Amount + Previous_Balance
    print_Function(New_Balance)
    
#Defines the Withdrawal Process
def Withdrawal_Process(Previous_Balance, Transaction_Amount):
    if Previous_Balance >= Transaction_Amount:
        New_Balance = Previous_Balance - Transaction_Amount
        print_Function(New_Balance)
    else:
        print("Invalid Transaction: Not Sufficent Funds")
        New_Balance = Previous_Balance
        print_Function(New_Balance)
        
#defines print function
def print_Function(New_Balance):
    print ('Your balance is now $', format(New_Balance, '.2f'))
    
    
#Call the main function
main()

input('Press Enter to continue')