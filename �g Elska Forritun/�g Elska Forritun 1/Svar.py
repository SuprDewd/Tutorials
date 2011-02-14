Mem = {}

def Poss(x, y):
    if x == 100 and y == 100:
        return 1

    k = str(x) + "," + str(y) if x > y else str(y) + "," + str(x)
    if k in Mem:
        return Mem[k]

    n = 0
    if x <= 99 and y <= 99:
        n += Poss(x + 1, y + 1)
    if x <= 99:
        n += Poss(x + 1, y)
    if y <= 99:
        n += Poss(x, y + 1)

    Mem[k] = n
    return n

print(Poss(0, 0))