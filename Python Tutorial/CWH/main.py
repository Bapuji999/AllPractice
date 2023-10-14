# print('Start')
# x = input('what is your name?\n')
# print("Hellow "+x)


# print("Enter number \n")
# n = int(input())

# print(type(n))

# print(round(4.6))

# print(abs(-50))

# print(bin(6565789541))

long_String = '''
    WOW
    O O
    ___
'''
print(long_String)

# print(int(str('100')))

# name = 'Bapuji'

# age = '23'

# print(("Hi {1} Your Age is {0}").format("Bapuji", '55'))

# string = '123456789'
# print(string[0::2])
# print(string[-1])

# import datetime
# x = int(input("what the year you born?\n"))
# today = datetime.date.today()
# year = today.year
# print(year-x)

# user_name = input("Enter user name\n")
# password = input("Enter Password\n")
# pass_len = len(password)
# s_pass = pass_len * '*'
# print(f'{user_name} your password is {s_pass} which is {pass_len} length')

# a = list(range(101))

# print(a)

# for _,char in enumerate("abcs"):
#     print(char)
def myfun(item):
    return item * 2
print(list(map(myfun, [2,5,4])))