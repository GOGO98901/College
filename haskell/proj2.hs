commission :: Double -> Double
commission p = if p == 0 then 0
	else if p < 100 then 2
	else p*0.02
	
sheepTax :: Double -> Double
sheepTax n
	| n <= 25 = n*1.5
	| n <= 50 = n*1.4
	| n <= 75 = n*1.3
	| n <= 100 = n*1.25
	| otherwise = n
	
multiply :: Int -> Int -> Int
multiply a b = a*b

square :: Int -> Int
square a = a*a

powerOf :: Int -> Int -> Int
powerOf a b = a^b

areaRectangle :: Int -> Int -> Int
areaRectangle l w = multiply l w

volumeCuboid :: Int -> Int -> Int -> Int
volumeCuboid l w h = (areaRectangle l w)*h

animals = ["tiger","polar bear","lion","monkey","elephant"]

