//var sampleWord = "BARK";

var letterBlocks = new List<(char letter1, char letter2)>
{
    ('B', 'O'),
    ('X', 'K'),
    ('D', 'Q'),
    ('C', 'P'),
    ('N', 'A'),
    ('G', 'T'),
    ('R', 'E'),
    ('T', 'G'),
    ('Q', 'D'),
    ('F', 'S'),
    ('J', 'W'),
    ('H', 'U'),
    ('V', 'I'),
    ('A', 'N'),
    ('O', 'B'),
    ('E', 'R'),
    ('F', 'S'),
    ('L', 'Y'),
    ('P', 'C'),
    ('Z', 'M')
};

//findRelevantBlocks takes (sampleWord, blocks)
//var uniqueNecessaryLetters = function findUniqueLetters(sampleWord)
// var relevantBlocks = new List<blocks>();
//foreach block in blocks
//{
// bool relevant = isBlockRelevant(block, uniqueNecessaryLetters) => returns true or false
// if (relevant){
//  relevantBlocks.Add(block)
//}
//return relevantBlocks
//}

findUniqueLetters takes (sampleWord)
var everyLetterInWord = sampleWord.ToCharArray()
var uniqueLetters = new List<char>()
foreach (letter in everyLetterInWord)
{
// if (!uniqueLetters.Contains(letter))
{
    uniqueLetters.Add(letter)
}
}
return uniqueLetters

//isBlockRelevant takes (block, letters)
//var isRelevant = false;
//foreach (letter in letters)
//{
    // bool letterIsOnBlock = isLetterOnBlock(block, letter)
    // if (letterIsOnBlock)
    // {
    //     isRelevant = true;
    //     break;
    // }
//}
//return isRelevant
//

//isLetterOnBlock take (block, letter)
//if (block[0] == letter || block[1] == letter)
//{return true}
//else return false

// makesWord takes (blocks, charArray)
// {
//     if (charArray.isEmpty())
//     {
//         return true
//     }
//     var letterToFind = charArray[0];
//     foreach (var block in blocks)
//     {
//         bool letterIsOnBlock = isLetterOnBlock(block, letter);
//         if (letterIsOnBlock)
//         {
//             var blocksWithoutCurrentBlock = // copy and remove here
//             var restOfWord = // copy rest of word
//             makesWord(blocksWithoutCurrentBlock, restOfWord)
//         }
//     }
//     return false;
// }