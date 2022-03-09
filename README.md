# ABC Kata

## Introduction
This is my first ever attempt to use C# to solve a problem, and to separate my code into classes.

## Installation
In order to run the program, you will need to have the .NET SDK installed on your computer.
If you have homebrew, you can install the .NET SDK on the command line: `brew install --cask dotnet-sdk`
Alternatively, you can download the .NET SDK [here](https://dotnet.microsoft.com/en-us/)

To run the project, enter `dotnet run` from the CLI when at the root directory of the project

## Kata Instructions
ABC Kata

You are given a collection of ABC blocks (like the ones you had when you were a kid).

There are twenty blocks with two letters on each block.

A complete alphabet is guaranteed amongst all sides of the blocks.

The sample collection of blocks:

```
(B O)
(X K)
(D Q)
(C P)
(N A)
(G T)
(R E)
(T G)
(Q D)
(F S)
(J W)
(H U)
(V I)
(A N)
(O B)
(E R)
(F S)
(L Y)
(P C)
(Z M)
```

Write a function that takes a string (word) and determines whether the word can be spelled with the given collection of blocks.

The rules are simple:

- Once a letter on a block is used that block cannot be used again
- The function should be case-insensitive
- Show the output on this page for the following 7 words in the following example

```
>>> can_make_word("A")
True
>>> can_make_word("BARK")
True
>>> can_make_word("BOOK")
False
>>> can_make_word("TREAT")
True
>>> can_make_word("COMMON")
False
>>> can_make_word("SQUAD")
True
>>> can_make_word("CONFUSE")
True
```

## Solution
I decided to pursue a recursive solution to the problem. I didn't realise that blocks always contained the same combinations of letters, and assumed that I needed to solve the problem for a set of blocks that potentially featured different combinations on different blocks. Given this scenario, a recursive solution seemed preferable to me.

I organised my code into two separate classes; a Block, and a PileOfBlocks. The vast majority of my calculations took place within methods of the PileOfBlocks class, and I am not sure if this is a preferred design. I also needed to recreate methods to access the length of the list of blocks, and to add a block to a list of blocks, within the PileOfBlocks class. I am not sure if there is another way of achieving this without rewriting those methods by wrapping them in an instance method.

## Improvements
I think it would helpful to separate out the data into a separate file (in this case, the tuples that specify the blocks that we are using). I'm not sure what the best way of doing that is, or what the appropriate file format is.

A CLI could be added, allowing users to enter words and receive feedback as to whether that word can be spelled out with the available blocks.