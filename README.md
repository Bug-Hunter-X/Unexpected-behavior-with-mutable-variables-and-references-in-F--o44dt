# F# Mutable Variable and Reference Bug

This repository demonstrates a subtle difference in how F# handles mutable variables and references, which can lead to unexpected behavior.  The example highlights the distinction between directly referencing a mutable variable using the `&` operator and creating a reference cell using `ref`. 

## Problem

The core issue lies in understanding the difference between a direct pointer to a mutable variable and a reference cell holding a copy of the value.

## Solution

The solution clarifies the correct approach depending on the intended behavior. Using `ref` ensures that modifications don't unexpectedly alter the original variable, promoting cleaner and more predictable code.  The comments in the code illustrate this behavior.