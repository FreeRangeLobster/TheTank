# TheTank
Electronics controller for 300lt fishtank, using KinconyA4

## Data Structure scheduler

Event structure in bits



|  2bit        | 3 bit     | 5  bit    |   5  bit     |   1 bit   |
|--------------|-----------|-----------|--------------|-----------|
| Output(0-3)  |  Day(0-7) | Hour(0-24)|  Min*2(0-60) | State(0-1)|

Where 
Output = 00-11 (0-3)
Day=000-110
> 	Mon(000)
	Tue(001)
	Wed(010)
	Thr(011)
	Fri(100)
	Sat(101)
	Sun(110)
Everyday(111)

Hour= 0 - 10111 (0-23) 
	1am= 00001
	2am= 00010
	12am= 12		 
	12pm= 0

Minutes= 00000 - 11 11 0 () Due to the design constrains to reduce the number of bits in memory, odd numbers are rounded eg 11m is actually 10m 
	10m - 00101 => 5*2 = 10m
	11m - 11/2 =5 => 5*2 = 10m 
	20m - 01010 => 10*2= 20m
	30m - 01111 => 15*2= 30m
	40m - 10100 => 20*2= 10m
	50m - 11001 => 25*2= 10m
	
		
	

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
Day = Monday 001
Hour=23 1 0111
Minute=58 => 58/2 = 30 = 11101
status = 0

Summary: 01 001 10111 11101 1
binary   0100110111111011
hex 0x4DFB ->  Dec 19963d
Top side: 4D = 77d
Low side: FB = 251d




| Address  2,3  | Event 1| 
|-------|---------|
Output =(2) 10
Day = Tuesday 010
Hour=2 00010
Minute=10 000101
status = 1

Summary: 10 010 00010 00101 1
binary:  1001000010001011
hex : 0x908B
Dec  : 37003
Top side: 90 = 144d
Low side: 8B = 139d


| Address 4,5  | Event 2| 
|-------|---------|
Output =(3) 11
Day = Sat 110
Hour=6 00110
Minute=30  01111
status = 1

Summary: 11 110 00110 01111 1
binary: 1111 0001 1001 1111
hex: 0xF19F
Dec:61855 
Top side: F1 = 241d
Low side: 9F = 159d



| Send  | REceive| 
|-------|---------|
|E: 0,0x4DFC /cr|ACK|
|E: 1,0x888A /cr|ACK|
|E: 2,0x3DF2 /cr|ACK|


E:004DFC
E:01888A
E:023DF2

Sample
E:003A5F	00 	00 111 01001 01111 1		output 0, AllDays, 9:30 ,  State On : 
E:017A61	01 	01 111 01001 10000 1		output 1, AllDays, 9:32 ,  State On : 
E:02BA63	02	10 111 01001 10001 1		output 2, AllDays, 9:34 ,  State On : 
E:03FA65	03	11 111 01001 10010 1		output 3, AllDays, 9:36 ,  State On : 
E:043A66	04	00 111 01001 10011 0		output 0, AllDays, 9:38 ,  State OFF : 
E:057A68	05	01 111 01001 10100 0		output 1, AllDays, 9:40 ,  State OFF : 
E:06BA6A	06	10 111 01001 10101 0		output 2, AllDays, 9:42 ,  State OFF : 
E:07FA6C	07	11 111 01001 10110 0		output 3, AllDays, 9:44 ,  State OFF : 
