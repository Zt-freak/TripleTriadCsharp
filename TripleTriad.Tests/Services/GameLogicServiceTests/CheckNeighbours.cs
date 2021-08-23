using Xunit;
using Moq;
using TripleTriad.Models.Entity.Interface;
using TripleTriad.Models.Services;
using System.Collections.Generic;
using System;

namespace TripleTriad.Tests.Services.GameLogicServiceTests
{
    public class CheckNeighbours
    {
        private readonly GameLogicService _service;
        private readonly Mock<IBoard> _mockBoard;
        private Mock<IField>[] _mockFields;
        private readonly Mock<IPlayer> _mockPlayer1;
        private readonly Mock<IPlayer> _mockPlayer2;

        public CheckNeighbours()
        {
            _service = new GameLogicService();
            _mockBoard = new Mock<IBoard>();
            _mockPlayer1 = new Mock<IPlayer>();
            _mockPlayer2 = new Mock<IPlayer>();

            var mockField1 = new Mock<IField>();
            var mockField2 = new Mock<IField>();
            var mockField3 = new Mock<IField>();
            var mockField4 = new Mock<IField>();
            var mockField5 = new Mock<IField>();
            var mockField6 = new Mock<IField>();
            var mockField7 = new Mock<IField>();
            var mockField8 = new Mock<IField>();
            var mockField9 = new Mock<IField>();

            _mockFields = new Mock<IField>[9]
            {
                mockField1,
                mockField2,
                mockField3,
                mockField4,
                mockField5,
                mockField6,
                mockField7,
                mockField8,
                mockField9
            };
        }

        [Theory]
        [InlineData(0, 0, 2)]
        [InlineData(1, 0, 3)]
        [InlineData(1, 1, 4)]
        public void ItShould_CheckNeighbours(int xCoord, int yCoord, int expectedNeighbourCount)
        {
            Mock<ICard> tempCard;
            for (int i = 0; i < _mockFields.GetLength(0); i++)
            {
                tempCard = new Mock<ICard>();
                tempCard.SetupGet(x => x.Owner).Returns(_mockPlayer1.Object);
                tempCard.SetupGet(x => x.Points).Returns(new int[] { 10, 10, 10, 10 });

                if (i >= 0 && i < 2)
                    tempCard.SetupGet(x => x.YCoord).Returns(0);
                else if (i >= 3 && 1 < 5)
                    tempCard.SetupGet(x => x.YCoord).Returns(1);
                else
                    tempCard.SetupGet(x => x.YCoord).Returns(2);

                if (i == 0 || i == 3 || i == 6)
                    tempCard.SetupGet(x => x.XCoord).Returns(0);
                else if (i == 1 || i == 4 || i == 7)
                    tempCard.SetupGet(x => x.XCoord).Returns(1);
                else
                    tempCard.SetupGet(x => x.XCoord).Returns(2);

                _mockFields[i].SetupGet(x => x.Occupant).Returns(tempCard.Object);

            }

            var fields = new IField[3, 3]
                {
                    {
                        _mockFields[0].Object,
                        _mockFields[1].Object,
                        _mockFields[2].Object
                    },
                    {
                        _mockFields[3].Object,
                        _mockFields[4].Object,
                        _mockFields[5].Object
                    },
                    {
                        _mockFields[6].Object,
                        _mockFields[7].Object,
                        _mockFields[8].Object
                    }
                };

            _mockBoard
                .SetupGet(x => x.Fields)
                .Returns(fields);

            ICard card = fields[xCoord, yCoord].Occupant;
            List<IField> neighbours = _service.CheckNeighbours(fields, card);

            Assert.Equal(expectedNeighbourCount, neighbours.Count);
        }
    }
}
