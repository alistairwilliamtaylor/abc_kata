class PileOfBlocks 
{
    public PileOfBlocks(List<Block> blocks)
    {
        BlocksInPile = blocks;
    }
    private List<Block> BlocksInPile;
    public bool MakesWord(string word){
        var letters = word.ToCharArray();
        return RecursivelySearchForSuccessfulBlockCombination(letters);
    }
    private bool RecursivelySearchForSuccessfulBlockCombination(char[] letters)
    {
        if (letters.Length == 0)
        {
            return true;
        }
        var letterToFind = letters[0];
        for (var i = 0; i < NumberOfBlocks(); i++)
        {
            var letterIsOnBlock = BlocksInPile[i].HasLetter(letterToFind);
            if (letterIsOnBlock)
            {
                var newPileOfBlocksWithoutCurrentBlock = AllBlocksExceptIndex(i);
                var restOfWord = letters.Skip(1).ToArray();
                var isSuccessfulCombination = newPileOfBlocksWithoutCurrentBlock.RecursivelySearchForSuccessfulBlockCombination(restOfWord);
                if (isSuccessfulCombination)
                {
                    return true;
                } 
            }
        }
        return false;
    }
    private PileOfBlocks AllBlocksExceptIndex(int index)
    {
        var allBlocksExceptOne = new PileOfBlocks(new List<Block>());
        for (var i = 0; i < NumberOfBlocks(); i++)
        {
            if (!(i == index))
            {
                allBlocksExceptOne.AddBlock(BlocksInPile[i]);
            }
        }
        return allBlocksExceptOne;
    }

    private int NumberOfBlocks()
    {
        return BlocksInPile.Count;
    }

    private void AddBlock(Block newBlock)
    {
        BlocksInPile.Add(newBlock);
    }
};