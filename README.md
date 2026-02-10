# Winter 2026 Assignment 01 - Arithmetic Expressions
__Weight:__ 5% of final mark

__Submission requirements:__ On or before the deadline, commit a Visual Studio 2022 project to the GitHub repository. __You must commit and push to the classroom repository supplied for the assignment__; do not create your own repository. It is your responsibility to ensure that your work is in the correct repository. ___Work not in the repository will not be graded___.

## Future Value of Money
Your friend is in the final rounds of a contest with a cash prize as large as $5,000. Since your friend knows you are studying software development, they have asked you to create a program to calculate what their prize will be worth if they invest it in a savings account. As you've just learned about programming arithmetic expressions, you agree to help them.


### Requirements
Your program will need to prompt the user for several inputs, namely:

- Initial winnings: the amount available to invest
- Interest rate: the annual rate of return as a percentage (e.g. 5% would be entered as 5, not 0.05)
- Number of years to invest: the number of years that the initial investment will remain invested (whole numbers only; investments will not be held for half or quarter years).

The program will produce and display the future value amount for the initial investment. You may assume the user only enters valid input.

### Formula

__FV = I x (1 + R)<sup>T</sup>__

Where: 
- FV = Future value 
- I = Initial investment amount 
- R = Monthly interest rate 
- T = Number of months

So, for example, imagine you have a $2,000 initial investment that will be held for 3 years at 7% interest paid annually. Using the provided formula, you would calculate the future value of your $2,000 as follows:

__FV__ = 2000 x \[1 + (0.07 / 12)]<sup>(3 x 12)</sup> = __$2,465.85__

_NOTE: as our inputs are in years but the formula requires months, the interest rate was converted from annual to monthly (divided by 12), and the number of years was converted to the number of months (multiplied by 12)._

### Sample Run
The following GIF demonstrates the functionality of the program for one set of inputs:
![assign1](images/assign1-sample-run.gif)

## Submission
Commit and push your solution to your GitHub classroom assignment repository before the deadline. Ensure that your solution follows the best coding and style practices as your instructor has shown you in class. Failed adherence to the prescribed style guidelines may result in lost marks. __Your program must compile; a program that fails to compile will not be graded.__

_NOTE: push early and often to your repository to receive feedback from your instructor prior to the deadline. Your instructor will not be providing feedback for every commit every day. However, the earlier and more often you commit, the greater the chances of your instructor reviewing your work and providing constructive feedback that you can act on before the deadline._

## Rubric
| Mark | Description |
|---|---|
| 5  | **Excellent**: program passes all test cases and coding follows best practices and class standards, including appropriate data type choices. |
| 4  | **Very Good**: program passes all test cases, but coding does not follow best practices and class standards |
| 3  | **Acceptable**: coded most the requirements and program produces the expected results for some of the test cases |
| 2  | **Needs Work**: coded some the requirements but program fails to produce expected results |
| 1  | **Unsatisfactory**: code does not meet any of the requirements |
| 0  | **Not done**: code was not submitted by the due date or does not compile |
