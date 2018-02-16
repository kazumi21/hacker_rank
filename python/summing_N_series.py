# HackerRank
# Summing the N series

DIVISOR = 10**9+7

def get_user_input():
    T = int(input())

    inputs = []
    for i in range(T):
        inputs.append(int(input()))
    return inputs

def modulo(dividend, divisor):
    print(dividend % divisor)
    print((dividend % divisor)*dividend)
    print (((dividend % divisor)*dividend) % divisor)
    print('\n')
    return ((dividend % divisor)*dividend) % divisor

def expression():
    inputs = get_user_input()

    for no in inputs:
        print(modulo(no, DIVISOR))

expression()
