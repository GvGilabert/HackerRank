#Read an integer N. For all non-negative integers i, print i².
n = int(input())
count = 0

def printPow (b):
    global count
    if count<b:
        print(count**2)
        count += 1
        printPow(b)

printPow(n)