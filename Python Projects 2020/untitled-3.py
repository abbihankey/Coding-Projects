
def main():
    infile = open(r"C:\Users\abbih\desktop\names.txt", 'r')
    text = infile.read()
    print(text)
    name = input('Who are you looking for? (case sensitive) ')
    if name in text:
        print(name,'was found in the list')
    else:
        print(name,'was not found in the list')
    infile.close()

def input_names():
    infile = open('names.txt', 'r')
    names = infile.readline('\n')
    infile.close()
    index = 0
    while index < len(names):
        Names[index] = names[index].restrip('\n')
        index +=1
    else:
        return names 
    
def print_names(list):
    for names in list:
        print (name)
    else:
        return
    
def write_names(list):
    infile = open(r"C:\Users\abbih\desktop\writenames.txt", 'w')
    for names in list:
        outfile.write(name+'\n')
    else:
        infile.close()
    



        
    
        





main()