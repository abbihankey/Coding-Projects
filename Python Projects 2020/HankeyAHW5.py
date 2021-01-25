
def main():
    keep_going = 'y'
    number_of_salespersons = 0
    while keep_going.upper() in "Y": 
        process_salesperson()
        number_of_salespersons += 1
        keep_going = input('Are there more salespersons? (enter y for yes): ')
    print ('There were', number_of_salespersons, 'salespersons processed.')

def process_salesperson():
    name = input("What is the salesperson's name? ") 
    print ('Enter', name + "'s amount for first sale: "),
    first_sale = float(input())
        
    while first_sale < 0.01 or first_sale > 25000:
        print ("ERROR: the first sale cannot be less than 0 or greater than 25000.")
        first_sale = float(input("Please enter a correct sale amount: "))
     
    total_sales = first_sale
    lowest_sale = first_sale
    highest_sale = first_sale
        
    print ('How many sales does', name, 'have?')
    number_of_sales = int(input())

    for number in range (2, number_of_sales + 1):
        print ('Enter', name + "'s sale #" + str(number) + ':'),
        sale = float(input()) 
                
        while sale < 0.01 or sale > 25000:
            print ('ERROR: the sale amount cannot be less than 0 or greater than 25000.')
            sale = float(input("Please enter correct sale amount: "))
                        
        total_sales += sale 
                
        if sale > highest_sale:
                highest_sale = sale
                
        elif sale < lowest_sale:
                lowest_sale = sale
                        
        average_sale = float(total_sales) / number_of_sales
                
        
        print (name + "'s average sale was: $", format(average_sale, ".2f")),
        print (name + "'s highest sale was: $", format(highest_sale, ".2f")),
        print (name + "'s lowest sale was: $", format(lowest_sale, ".2f")),       
             


main()

input('Press Enter to continue')