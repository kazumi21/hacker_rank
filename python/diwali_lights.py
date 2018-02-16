# Hacker Rank: Diwali lights
MODIFIER = 10**5

def get_user_input():
    T = int(input())

    inputs = []
    for i in range(T):
        inputs.append(int(input()))
    return inputs

def patterns_no(n):
    return (2**n-1)%MODIFIER

def expression():
    inputs = get_user_input()

    for no in inputs:
        print(patterns_no(no))
