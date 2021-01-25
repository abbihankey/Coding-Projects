PREMIUM2 = .05
PREMIUM3 = .10
PAY_PERIODS = 26

class Person:

    def __init__(self, name, id_number, city, pay_rate=None):
        self.__name = name
        self.__id_number = id_number
        self.__city = city
        self.__pay_rate = pay_rate

    def set_name(self, name):
        self.__name = name

    def set_id_number(self, id_number):
        self.__id_number = id_number

    def set_city(self, city):
        self.__city = city
        
    def set_pay_rate(self, pay_rate):
        self.__pay_rate = pay_rate

    def get_name(self):
        return self.__name

    def get_id_number(self):
        return self.__id_number

    def get_city(self):
        return self.__city
    
    def get_pay_rate(self):
        return self.__pay_rate
    
    def show_employee(self):
        print ('Employee name is', self.__name)
        print ('Employee number is', self.__id_number)
        print ('Employee city is', self.__city)
        
    def show_pay(self):
        print()
        print ('This person is an unpaid volunteer.')
        print()

class HourlyWorker(Person):

    def __init__(self, name, id_number, city, shift, pay_rate=None):
        Person.__init__(self, name, id_number, city, pay_rate)

        self.__pay_rate = pay_rate

    def show_pay(self, pay_rate, shift):
        print ('Employee shift is', self.__shift)
        if self.shift__ == '1':
            premium_rate = self.__pay_rate
        elif self.__shift == '2':
            premium_rate = (PREMIUM2 * self.__pay_rate) + self.__pay_rate
        else: premium_rate = (PREMIUM3 * self.__pay_rate) + self.__pay_rate
        print( 'Employee hourly premium pay rate is $', format(premium_rate, '.2f'))

  
class SalaryWorker(Person):

    def __init__(self, name, id_number, city, shift =None, pay_rate =None):
        Person.__init__(self, name, id_number, city, pay_rate=None)

        self.__pay_rate = pay_rate
        
    
    def show_pay(self, pay_rate):
        print ('Employee annual salary is $', format(self.__pay_rate, '.2f'))
        bi_weekly_pay = float(self.__pay_rate) / PAY_PERIODS
        print( 'Employee bi-weekly gross pay is $', format (bi_weekly_pay, '.2f'))
   