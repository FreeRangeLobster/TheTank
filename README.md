# TheTank
Electronics controller for 300lt fishtank, using KinconyA4

## Data Structure scheduler

Event structure in bits

|2bit       | 7  bit    | 4  bit            | 4  bit                |
|----------------|-------------------------------|--|-----|------------------------|
|Output |Day            |Hour              | minutes


Where 
Output = 00-11 (0-3)
Day=000-110
> Mon(000)
 Tue(001)
 Wed(010)
 Thr(011)
Fri(100)
Sat(101)
Sun(110)
		Everyday(111)

Hour= 0 - 10111 (0-23) 
> 1am= 00001
 2am= 00010
12am= 12		 
 12pm= 0

Minutes= 000000 - 11 11 00
>10m - 001010
20m - 010100
30m - 011110
40m - 101000
50m - 110010
60m - 111100
		
	

Event addressing 

|Address|   Event     |
|-------|---------|
|  0,1  | Event 0|
|  2,3  | Event 1|
|  3,4  | Event 2|

## Sample table

| Address  0,1  | Event 0| 
|-------|---------|
Output =(1) 01
Day = Tuesday 001
Hour=23 1 0111
Minute=60 11 11 00

Summary: 01 001 1 0111 11 11 00
binary 0100 1101 1111 1100 
hex 0x4DFC
Dec 19964



| Address  2,3  | Event 1| 
|-------|---------|
Output =(2) 10
Day = Tuesday 001
Hour=2 00010
Minute=10 001010

Summary: 10 001 00010 001010
binary: 1000 1000 100 01010
hex : 0x888A
Dec  : 34954

| Address 4,5  | Event 2| 
|-------|---------|
Output =(0) 00
Day = Everyday 111
Hour=23 1 0111
Minute=50d 110010

Summary: 00 111 1 0111 110010
binary: 0011 1101 1111 0010
hex 0x3DF2
Dec 15858