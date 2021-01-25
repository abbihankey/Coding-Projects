import petspgm

def main():
    #Get a list of pet objects.
    pets = make_list()

    #Display the data in the list.
    print('Here is the data you entered: ')
    display_list(pets)

#This function gets data from the user for 3 pets. It returns a list of pet
#objects containing the data.
def make_list():
    
    pet_list = []

    #Add three pet objects to the list
    print('Enter the data for 3 pets.')
    for count in range(1, 4):
        #Get the pet data
        print("Pet number " + str(count) + ":")
        pet_name = input("Enter your pet's name: ")
        pet_type = input("Enter the type of pet: ")
        pet_age = float(input("Enter the pet's age: "))
        print

        #Create a new PetData object in memory and assign it to the pet variable.
        pet = petspgm.PetData(pet_name, pet_type, pet_age)

        #Add the object to the list.
        pet_list.append(pet)

        #Return the list.
        return pet_list

#This function accepts a list containing PetData objects as an argument and 

def display_list(pet_list):
    for item in pet_list:
        print("Pet's name is: " + item.get_pet_name())
        print("Pet's type is : " + item.get_pet_type())
        print("Pet's age is : " + str (item.get_pet_age()))

main()