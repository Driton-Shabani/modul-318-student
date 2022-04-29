namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", System.DateTime.Now, System.DateTime.Now);

            connections.Should().NotBeNull();
        }

        [Fact]
        public void StationBoardGet()
        {
            Station station = new Station();

            station.Name = "Fildern";
            var s = this.testee.GetStations(station.Name);
            string id = s.StationList[0].Id;

            var stationBoardList = this.testee.GetStationBoard(station.Name, id);

            id.Should().NotBeNull();
        }
    }
}