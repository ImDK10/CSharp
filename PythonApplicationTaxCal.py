def TaxCal(salary):
    if (salary < 10000):
        print("Your Tax is 5%")
        print("Total Tax to be Paid: ", ((salary*5)//100))
    elif (salary in range(10000,100001)):
        print("Your Tax is 8%")
        print("Total Tax to be Paid: ", ((salary*8)//100))
    else:
        print("Your Tax is 8.5%")
        print("Total Tax to be Paid: ", ((salary*8.5)//100))

salary = int(input("Enter Your Salary: "))
TaxCal(salary)