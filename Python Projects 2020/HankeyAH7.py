CD_RW_PRICE = 16.50
DVD_RW_PRICE = 21.75

def main():
   
  cd_customers_counter = 0
  dvd_customers_counter = 0
  total_payment_due = 0

  print("Customer Name \tCode\tSpindle\tPayment Due")
  print('')
  
  try:
    infile = open ("/users/abbih/desktop/disks.txt",'r')

    customer_name = infile.readline()

    while customer_name != '':
      
      customer_name = customer_name.rstrip('\n')
      print(customer_name, end='\t')

      code = infile.readline()
      code = code.rstrip('\n')
      print(code, end='\t')

      spindles = infile.readline()
      spindles = int(spindles)
      print(format(spindles, '3.0f'), end='\t')

      if code == "c" or code == "C":
        payment_due = spindles * CD_RW_PRICE
        cd_customers_counter += 1
      elif code == "d" or code == "D":
        payment_due = spindles * DVD_RW_PRICE
        dvd_customers_counter += 1
      else:
        payment_due = 0

      total_payment_due += payment_due

      if payment_due == 0:
        print('invalid code')
      else:
        print('$', format(payment_due, '7,.2f'))

      customer_name = infile.readline()

    infile.close()

    print('')
    print('Total customers that purchased CD-RWs:   ', cd_customers_counter)
    print('Total number of DVD spindles sold:    ',dvd_customers_counter)
    print('')
    print('Total amounts of payment due:   ', end='')
    print('$', format(total_payment_due, ',.2f'), sep='')

  except IOError:
    print('an error occured trying to open or read disks.txt')

main()