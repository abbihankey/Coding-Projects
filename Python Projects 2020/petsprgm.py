class PetData(object):
    def __init__(self, name, animal_type, age):
        self.__pet_name = pet_name
        self.__pet_type = pet_type
        self.__pet_age = pet_age

    def set_name(self, name):
        self.__pet_name = pet_name

    def set_type(self, animal_type):
        self.__pet_type = pet_type

    def set_age(self, age):
        self.__pet_age = pet_age

    def get_name(self):
        return self.__pet_name

    def get_animal_type(self):
        return self.__pet_type

    def get_age(self):
        return self.__pet_age


# The main function
def main():
    pets = Pet(name, animal_type, age)
    print('This will be added to the records. ')
    print('Here is the data you entered:')
    print('Pet Name: ', pets.get_pet_name)
    print('Animal Type: ', pets.get_pet_type)
    print('Age: ', pets.get_pet_age)

main()