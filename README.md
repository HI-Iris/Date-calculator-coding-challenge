# Date Difference Calculator

This is a WPF C# desktop application that calculate the difference between two dates. The application can receive standard input or from a file as developer choose.
## Description

- The application is a calculator compare the differences in days between two dates.
- Input can be from a file, or from standard input, as the developer chooses.
 
The application that can read in commands of the following form

    DD/MM/YYYY

- Validate the input data, and compute the difference between the two dates in days..
- Output of the application should be of the form
> 

    DD/MM/YYYY, DD/MM/YYY, Difference:days

- Where the first date is the earliest, the second date is the latest and the difference is the number of days.
- Input can be from a file, or from standard input, as the developer chooses.

## Example Input and Output:
    
a)

	11/10/1990
    10/10/1990
    
Click "CALCULATE"

	Output: 10/10/1990, 11/10/1990, Difference: 1


b)

	2009 9 9
	10/10/1990

Click "CALCULATE"
	
	Output: Please enter a valid date. DD/MM/YYYY

c)

	01/01/2009
	31/12/2010

Click "CALCULATE"

	Output: 01/01/2009,31/12/2010, Difference:729


## Requirements

- Implemented and tested using C#
- Make sure you have .NET Framework 4.5.2 or above installed on your computer.


##Getting started
To build the project, run DateDifference.sln in VS. The application would promote a visual window to receive the date by standard input or file.


##Author
Iris Hou [xinzhu.hou@gmail.com](xinzhu.hou@gmail.com)

