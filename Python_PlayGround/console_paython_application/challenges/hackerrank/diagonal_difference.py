def dimentional_difference(arr):
    total_l = 0
    total_r = 0
    r=0

    for m,elm in enumerate(arr):
        r= len(arr[0]) -1 -m
        total_l +=arr[m][m]
        total_r += arr[m][r]
    
    diff = total_l - total_r
    return diff * -1 if diff <0 else diff

# testing code
test_case = [
    [1,2,3],
    [4,5,6],
    [9,8,9]
]

print(dimentional_difference(test_case))