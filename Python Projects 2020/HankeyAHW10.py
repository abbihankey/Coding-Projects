import worker

def main():

    workers = make_list()
    print ('\nHere are the workers, their ID numbers, city, shift, and pay.')
    print ("-----------------------------------------------------")
    
    display_list(workers)
    
def make_list():
    worker_list = []
    
    print ('Create a volunteer worker object')
    name = input('\nWhat what is the employee name? ' )
    id_number = input("What is the employee's ID? " )
    city = input("What is the employee's city? " )
    pay_rate = 0
    volunteerworker = worker.Person(name, id_number, city, pay_rate)
    worker_list.append(volunteerworker)
    
    print ('Create 3 hourly worker objects')
    for hourlyworkers in range(1, 4):
        name + input('\nNow enter employee ' + str(hourlyworkers + 1) + "'s info")
        name = input('\nWhat what is the employee name? ' )
        id_number = input("What is the employee's ID? " )
        city = input("What is the employee's city? " )
        shift = input("What is the employee's shift? ")
        while shift != '1' and shift !='2' and shift != '3':
            print( 'ERROR: the shift can only be 1, 2, or 3.')
            shift = input('Please enter correct shift.')
        pay_rate = float(input("What is the employee's hourly pay rate? "))
        hourlyworker = worker.HourlyWorker(name, id_number, city, pay_rate)
        worker_list.append(hourlyworker) 
              
    print ('Create a salary worker object')
    name = input("\nWhat is the salaried employee's name? ")
    id_number = input("What is the employee's ID? " )
    city = input("What is the employee's city? " )
    pay_rate = float(input("What is the employee's annual salary? "))
    salaryworker = worker.SalaryWorker(name, id_number, city, pay_rate)
    worker_list.append(salaryworker)
                     
        
    worker_list.append('\nThis is an invalid object')
        
    return worker_list
    
def display_list(worker_list):
    for person in worker_list:
        if isinstance(person, worker.Person):
            person.show_employee()
            person.show_pay()
            print()
        else:
            print()
            
main()
    

input("Press ENTER to continue") 
            
        
        
        
        
        
    