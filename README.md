# F# Mutable Variable Bug

This example demonstrates a common misunderstanding in F# when dealing with mutable variables and function parameters.  The function `add` calculates the sum of its parameters; however, modifying the mutable variables `x` and `y` *after* calling the function does not change the result because the function works on copies of the variables' values, not direct references to the variables.

## How to Reproduce

1. Compile and run the `bug.fs` file.
2. Observe that the output is not what one might initially expect due to the way F# handles immutability by default.

## Solution

The `bugSolution.fs` file provides a corrected approach using tuples or references for modifying values and observing changes within the function. This illustrates the importance of understanding F#'s functional nature and how to achieve mutability when needed.