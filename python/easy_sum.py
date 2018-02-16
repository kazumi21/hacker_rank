# Hacker Rank: Easy sum

def get_user_input():
    T = int(input())

    N = []
    m = []
    for i in range(T):
        line = input().split()
        N.append(int(line[0]))
        m.append(int(line[1]))
    return {'N':N,'m':m}

def calc_sum(N, m):
    return (((N/2)%m)*((N+1)%m))%m

def expression():
    inputs = get_user_input()
    dividend = inputs["N"]
    divisor= inputs["m"]

    for (N,m) in zip(dividend, divisor):
        print(calc_sum(N, m))

expression()
