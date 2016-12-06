fred = [1..5]
barney = foldl (+) 0 fred

nums = [5, 6, 2, 35, 1, 19, 65, 40, 34]
listmax = foldl (max) 0 nums
listmin = foldl (min) 0 nums

sums = foldl (+) 0 [1..15]
fids