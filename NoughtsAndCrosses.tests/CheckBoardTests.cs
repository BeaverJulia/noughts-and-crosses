using System;
using Xunit;

namespace NoughtsAndCrosses.tests
{
    public class CheckBoardTests
    {
      
        [InlineData(new char[] {
            '0', 
            'x', 'x', 'x', 
            '4', '5', '6', 
            '7', '8', '9'})]
        [InlineData(new char[] {         //horizontal
            '0',
            '1', 'o', '3',
            'x', 'x', 'x',
            '7', 'o', '9'})]
        [InlineData(new char[] {
            '0',
            '1', '2', '3',
            '4', 'o', 'o',
            'x', 'x', 'x',})]

        [InlineData(new char[] {
            '0',
            'x', '2', '3',
            'x', 'o', 'o',
            'x', 'o', 'x',})]
        [InlineData(new char[] {
            '0',
            '1', 'o', '3',
            'x', 'o', 'o',              //vertical
            'x', 'o', 'x',})]
        [InlineData(new char[] {
            '0',
            '1', '2', 'o',
            'x', '5', 'o',
            'x', 'x', 'o',})]
        [InlineData(new char[] {
            '0',
            'x', '2', 'o',
            'o', 'x', 'o',
            '7', 'x', 'x',})]
        [InlineData(new char[] {  //Diagonal
            '0',
            '1', '2', 'o',
            '4', 'o', '6',
            'o', '8', '9',})]
        [Theory]
        public void IfPlayerPlacesThreeOfHisMarksInHorizontalRow_Then_CheckBoardShouldReturnOne(char[] board)
        {
            var sut = new CheckBoard();

            var result = sut.Execute(board);

            Assert.StrictEqual( 1, result);
        }
    }
}
