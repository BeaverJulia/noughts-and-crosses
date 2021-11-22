using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NoughtsAndCrosses.tests
{
    public class DrawOnBoardTests 
    {

      
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [Theory]
        public void IfNextPlayerIsEvenNumber_Then_DrawO_InGivenRow( int nextPlayer)
        {
            char[] board = new[]
            {
                '0',
                '1', '2', '3',
                '4', '5', '6',
                '7', '8', '9'
            };
            var sut = new DrawOnBoard();
            var r = new Random();
            var randomRow = r.Next(1, 9);
            var result = sut.Execute(board, nextPlayer, randomRow);
            board[randomRow] = 'o';
            var updatedBoard = board;
            Assert.StrictEqual(updatedBoard, result);
            Assert.StrictEqual(board[randomRow], result[randomRow]);
        }

        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [Theory]
        public void IfNextPlayerIsOddNumber_Then_DrawX_InGivenRow(int nextPlayer)
        {
            char[] board = new[]
            {
                '0',
                '1', '2', '3',
                '4', '5', '6',
                '7', '8', '9'
            };
            var sut = new DrawOnBoard();
            var r = new Random();
            var randomRow = r.Next(1, 9);
            var result = sut.Execute(board, nextPlayer, randomRow);
            board[randomRow] = 'x';
            var updatedBoard = board;
            Assert.StrictEqual(updatedBoard, result);
            Assert.StrictEqual(board[randomRow], result[randomRow]);
        }
    }
}
