fib :: Int -> Int
fib 0 = 1
fib 1 = 1
fib n = fib(n-1) + fib(n-2)

tri :: Int -> Int
tri 1 = 1
tri n = n+tri(n-1)

fac :: Int -> Int
fac 1 = 1
fac n = n*fac(n-1)

-- bin :: Int
-- bin n = do
--	if n == 0 || n == 1 then 
--		putStrLn(n)
--	else
--		bin(n/2)
--		putStrLn(mod n 2)

shitAi = do
	putStrLn("What is your name young padawan?")
	x <- getLine
	putStrLn("Hello " ++ x)

input m = do
	putStrLn(m)
	input <- getLine
	return input
--vol:: Int -> Int
--vol = do
--	w <- read input("Enter the width") :: Int
--	h <- read input("Enter the height") :: Int
--	d <- read input("Enter the depth") :: Int
--	vol <- w*h*d
--	return vol

vol2 = do
	putStrLn("width:")
	sW <- getLine
	let w :: Int
		w = read sW

	putStrLn("height:")
	sH <- getLine
	let h :: Int
		h = read sH

	putStrLn("depth:")
	sD <- getLine
	let d :: Int
		d = read sD
	vol2 <- w*h*d
	return vol2

