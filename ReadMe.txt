This is a little program made to solve a recruitment task. A method that solves the task is
	int solution(int numberOfGlasses, int numberOfLitres)
	in a class called "Solution".

The TASK:
You have X glasses and Y litres of water. X and Y are integers.
What is the smallest number of glasses needed to contain all the water.
The solution method must return the number of glasses needed.

Rules:
a) If you have four glasses they can contain this much water:
	- first can contain	1 litre,
	- second can contain	2 litres,
	- third can contain	3 litres,
	- fourth can contain	4 litres.
b) The glass must be either full or empty. If you have 10 glasses and 5 litres of water,
you cannot pour half a 10 litre glass but instead you must pour a full 5 litre glass.
c) If glasses cannot contain so much water, the method returns -1.
d) (I don't fully remember the original task content but I assumed
that when I have 1 glass and 0 or less litres I need 0 glasses to contain it.

Examples:
a) 5 glasses and 8 litres: you must use at least 2 glasses (5 and 3),
b) 5 glasses and 10 litres: you must use at least 3 glasses (5,4 and 1).

NOTICE!
- All helper methods in Solution class are public
to make it possible to test them in separate classes.
- I wrote this task from memory so it can differ from its original counterpart.