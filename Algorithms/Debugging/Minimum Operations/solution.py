# https://www.hackerrank.com/challenges/minimum-operations/problem
def min_operations(red, green, blue):
    dp = [[(1<<30) for x in range(8)] for y in range(101)]
    n = len(red)
    dp[0][0] = 0
    for i in xrange(0, n):
        for j in xrange(0, 8):
            dp[i + 1][j | 1] = min(dp[i + 1][j | 1], dp[i][j] + green[i] + blue[i])
            dp[i + 1][j | 2] = min(dp[i + 1][j | 2], dp[i][j] + red[i] + blue[i])
            dp[i + 1][j | 4] = min(dp[i + 1][j | 4], dp[i][j] + red[i] + green[i])
         
    j = 0
    for i in range(0, n):
        if green[i]:
            j |= 1
        if red[i]:
            j |= 2
        if blue[i]:
            j |= 4

    if dp[n][j] >= (1<<30):
        dp[n][j] = -1

    return dp[n][j]

n = int(raw_input())
red = []
green = []
blue = []
for i in range(n):
    r, g, b = map(int, raw_input().split())
    red.append(r)
    green.append(g)
    blue.append(b)
print min_operations(red, green, blue)


