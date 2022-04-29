using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
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
                ConnectionsGet();
                StationBoardGet();
            }
        }

        private void cbo_Startstation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                StationBoardGet();
            }
        }


        private void cbo_Startstation_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                try
                {
                    var startstation = cbo_Startstation.Text;

                    var vorschlaege_Startstation = t.GetStations(cbo_Startstation.Text);
                    cbo_Startstation.Items.Clear();
                    cbo_Startstation.SelectionStart = cbo_Startstation.Text.Length + 1;

                    foreach (SwissTransport.Models.Station stations in vorschlaege_Startstation.StationList)
                    {
                        cbo_Startstation.Items.Add(stations.Name);
                    }

                    //weil immer Orte sofort automatisch ausgewählt wird.
                    if (cbo_Startstation.Text.Length >= 2)
                    {
                        cbo_Startstation.DroppedDown = true;
                        cbo_Startstation.Text = startstation;
                        cbo_Startstation.SelectionStart = cbo_Startstation.Text.Length + 1;
                    }



                }
                catch 
                {

                }
            }
        }

        private void cbo_Endstation_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                try
                {
                    var Endstation = cbo_Endstation.Text;

                    var vorschlaege_Endstation = t.GetStations(cbo_Endstation.Text);
                    cbo_Endstation.Items.Clear();
                    cbo_Endstation.SelectionStart = cbo_Endstation.Text.Length + 1;

                    foreach (SwissTransport.Models.Station stations in vorschlaege_Endstation.StationList)
                    {
                        cbo_Endstation.Items.Add(stations.Name);
                    }

                    //weil immer Orte sofort automatisch ausgewählt wird.
                    if (cbo_Endstation.Text.Length >= 2)
                    {
                        cbo_Endstation.DroppedDown = true;
                        cbo_Endstation.Text = Endstation;
                        cbo_Endstation.SelectionStart = cbo_Endstation.Text.Length + 1;
                    }



                }
                catch 
                {

                }


            }
        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            ConnectionsGet();
            StationBoardGet();
        }

        private void cbo_Startstation_TextChanged(object sender, EventArgs e)
        {
            cbo_Startstation.ForeColor = Color.Black;

        }

        private void cbo_Endstation_TextChanged(object sender, EventArgs e)
        {
            cbo_Endstation.ForeColor = Color.Black;
        }


        private void ConnectionsGet()
        {
            //Nächste Verbindungen Anzeigen
            try
            {
                string fromStation = cbo_Startstation.Text;
                string ToStation = cbo_Endstation.Text;
                DateTime date = dtp_Datum.Value;
                DateTime time = dtp_Zeit.Value;

                var Connectionlist = t.GetConnections(fromStation, ToStation, date, time);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void StationBoardGet()
        {
            try
            {


                //Abfahrtstafel
                Station station = new Station();

                station.Name = cbo_Startstation.Text;
                var s = t.GetStations(station.Name);
                string id = s.StationList[0].Id;

                var stationBoardList = t.GetStationBoard(station.Name, id);

                foreach (StationBoard stat in stationBoardList.Entries)
                {
                    dgv_Abfahrstafel.Rows.Add
                        (
                            stat.Stop.Departure,
                            stat.To,
                            stat.Category,
                            stat.Number
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

