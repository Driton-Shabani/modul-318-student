using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace MySwisstransportApp
{
    public partial class MySwisstransportApp : Form
    {
        ITransport t = new Transport();
        public MySwisstransportApp()
        {
            InitializeComponent();
        }

        

        private void tbx_Endstation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               //Nächste Verbindungen Anzeigen

               string fromStation = tbx_Startstation.Text;
               string ToStation = tbx_Endstation.Text;

               var Connectionlist = t.GetConnections(fromStation, ToStation);
               foreach (Connection c in Connectionlist.ConnectionList)
                {   
                    dgv_Verbindungen.Rows.Add
                        (
                            c.From.Departure,
                            c.To.Arrival,
                            c.From.Station.Name +
                            c.To.Station.Name,
                            c.Duration
                        );
                }
            }
        }


        private void tbx_Startstatioin_KeyDown(object sender, KeyEventArgs e)
        {
            Station station = new Station();
            
            
            if (e.KeyCode == Keys.Enter)
            {
                station.Name = tbx_Startstation.Text;

                var s = t.GetStations(station.Name);

                string id = s.StationList[0].Id;

                var stationBoardList = t.GetStationBoard(station.Name, id);

                foreach(StationBoard stat in stationBoardList.Entries)
                {
                    dgv_Abfahrstafel.Rows.Add
                        (
                            stat.Stop.Departure,
                            stat.To,
                            stat.Category
                        );
                }

             
              
               
            }
        }
    }
}
