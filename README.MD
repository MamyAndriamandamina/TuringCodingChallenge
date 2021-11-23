This repository contains the code for finding the maximum combination of 2 values from an array and that is less than a provided constant integer K.

Example
Array=[7,15,1,5] K = 6
Array=[7,15,1,5] K = 14
Array=[7,15,1,5] K = 23


The possible combination are:
7+15=22
7+1=8
7+5=12
15+1=16
15+5=20
1+5=6

Combo = [6,8,12,16,20,22]

If K = 5 then the output is -1 because there is no value that is less than 5, all values are greater than 5
if K = 14 then the output is 12 because 12 is the maximum value from the combination and less than 14
if K = 23 then the output is -1 because there is no value that is less than 23, all values are less than 23