using Xunit;

namespace NoughtsAndCrosses.tests
{
    public class CheckBoardTests
    {
        [InlineData(new[]
        {
            '0',
            'x', 'x', 'x',
            '4', '5', '6',
            '7', '8', '9'
        })]
        [InlineData(new[]
        {
            
            '0',
            '1', 'o', '3',
            'x', 'x', 'x',
            '7', 'o', '9'
        })]
        [InlineData(new[]
        {
            '0',
            '1', '2', '3',
            '4', 'o', 'o',
            'x', 'x', 'x'
        })]
        [Theory]
        public void IfPlayerPlacesThreeOfHisMarksInHorizontalRows_Then_CheckBoardShouldReturnOne(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual(1, result);
        }


        [InlineData(new[]
        {
            '0',
            'x', '2', '3',
            'x', 'o', 'o',
            'x', 'o', 'x'
        })]
        [InlineData(new[]
        {
            '0',
            '1', 'o', '3',
            'x', 'o', 'o',
            'x', 'o', 'x'
        })]
        [InlineData(new[]
        {
            '0',
            '1', '2', 'o',
            'x', '5', 'o',
            'x', 'x', 'o'
        })]
        [Theory]
        public void IfPlayerPlacesThreeOfHisMarksInVerticalRows_Then_CheckBoardShouldReturnOne(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual(1, result);
        }

        [InlineData(new[]
        {
            '0',
            'x', '2', 'o',
            'o', 'x', 'o',
            '7', 'x', 'x'
        })]
        [InlineData(new[]
        {
            '0',
            '1', '2', 'o',
            '4', 'o', '6',
            'o', '8', '9'
        })]
        [Theory]
        public void IfPlayerPlacesThreeOfHisMarksInDiagonalRows_Then_CheckBoardShouldReturnOne(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual(1, result);
        }

        [InlineData(new[]
        {
            '0',
            'x', 'o', 'x',
            'o', 'x', 'x',
            'o', 'x', 'o'
        })]
        [Theory]
        public void IfTheBoardIsFullButMarksNotInWinningPattern_Then_CheckBoardShouldReturnMinusOne(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual(-1, result);
        }

        [InlineData(new[]
        {
            '0',
            '1', '2', '3',
            'o', '5', '6',
            '7', 'x', '9'
        })]
        [InlineData(new[]
        {
            '0',
            '1', '2', 'x',
            'o', '5', '6',
            'o', 'x', '9'
        })]
        [Theory]
        public void IfTheBoardNotFullButMarksNotInWinningPattern_Then_CheckBoardShouldReturnZero(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual(0, result);
        }
    }
}