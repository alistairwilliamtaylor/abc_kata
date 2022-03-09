﻿var letterBlocks = new List<Block>
{
    new Block('B', 'O'),
    new Block('X', 'K'),
    new Block('D', 'Q'),
    new Block('C', 'P'),
    new Block('N', 'A'),
    new Block('G', 'T'),
    new Block('R', 'E'),
    new Block('T', 'G'),
    new Block('Q', 'D'),
    new Block('F', 'S'),
    new Block('J', 'W'),
    new Block('H', 'U'),
    new Block('V', 'I'),
    new Block('A', 'N'),
    new Block('O', 'B'),
    new Block('E', 'R'),
    new Block('F', 'S'),
    new Block('L', 'Y'),
    new Block('P', 'C'),
    new Block('Z', 'M')
};

var theBlocks = new PileOfBlocks(letterBlocks);
var theWord = "CONFUSE";
System.Console.WriteLine(theBlocks.MakesWord(theWord));