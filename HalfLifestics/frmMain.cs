using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HalfLifestics
{
    public partial class frmMain : Form
    {
        string ArchiveFolder = "";
        string CurrentLogFilePath = "";

        List<string> AllPlayers = new List<string>();
        List<string> PlayersA = new List<string>();
        List<string> PlayersB = new List<string>();

        Dictionary<string, List<string>> Killers = new Dictionary<string, List<string>>();

        Dictionary<string, string> Guns = new Dictionary<string, string>();
        Dictionary<string, decimal> GunsPointModifiers = new Dictionary<string, decimal>();

        DataTable DataSource = new DataTable();

        private void LoadArchive(string pFilePath)
        {
            this.CurrentLogFilePath = pFilePath;

            lblLog.Text = Path.GetFileName(pFilePath);
            txtLog.Text = File.ReadAllText(pFilePath);
            btnNewSave.Text = "New";
            txtLog.ReadOnly = true;

            #region Load Data
            if (!string.IsNullOrWhiteSpace(txtLog.Text))
            {
                this.DataSource = new DataTable();
                this.AllPlayers = new List<string>();

                this.PlayersA.Clear();
                this.PlayersB.Clear();

                this.DataSource.Columns.Add("Order", typeof(int));
                this.DataSource.Columns.Add("Killer", typeof(string));
                this.DataSource.Columns.Add("Killed", typeof(string));
                this.DataSource.Columns.Add("Gun", typeof(string));
                this.DataSource.Columns.Add("GunTR", typeof(string));

                DataRow dr;

                string line = "";

                for (int i = 0; i < txtLog.Lines.Length; i++)
                {
                    line = txtLog.Lines[i];

                    if (line.Contains("killed"))
                    {
                        dr = this.DataSource.NewRow();

                        dr["Order"] = this.DataSource.Rows.Count + 1;
                        dr["Killer"] = line.Split(new string[] { "killed" }, StringSplitOptions.None)[0].Trim();
                        dr["Killed"] = line.Split(new string[] { "killed" }, StringSplitOptions.None)[1].Trim().Split(new string[] { "with" }, StringSplitOptions.None)[0].Trim();
                        dr["Gun"] = line.Split(new string[] { "killed" }, StringSplitOptions.None)[1].Trim().Split(new string[] { "with" }, StringSplitOptions.None)[1].Trim();
                        dr["GunTR"] = Guns[dr["Gun"].ToString()];

                        this.DataSource.Rows.Add(dr);

                        if (!this.AllPlayers.Contains(dr["Killer"].ToString()))
                        {
                            this.AllPlayers.Add(dr["Killer"].ToString());
                        }
                    }
                }
            }
            #endregion

            this.Killers = new Dictionary<string, List<string>>();

            for (int i = 0; i < this.DataSource.Rows.Count; i++)
            {
                if (!this.Killers.ContainsKey(this.DataSource.Rows[i]["Killer"].ToString()))
                {
                    this.Killers.Add(this.DataSource.Rows[i]["Killer"].ToString(), new List<string>());
                }

                //self'i elemek için
                if (this.AllPlayers.Contains(this.DataSource.Rows[i]["Killed"].ToString()))
                {
                    if (!this.Killers[this.DataSource.Rows[i]["Killer"].ToString()].Contains(this.DataSource.Rows[i]["Killed"].ToString()))
                    {
                        this.Killers[this.DataSource.Rows[i]["Killer"].ToString()].Add(this.DataSource.Rows[i]["Killed"].ToString());
                    }
                }
            }

            bool everybodyIsEnemy = false;

            foreach (KeyValuePair<string, List<string>> item in this.Killers)
            {
                if (item.Value.Count == this.AllPlayers.Count - 1)
                {
                    everybodyIsEnemy = true;
                    break;
                }
            }

            if (everybodyIsEnemy)
            {
                lbxGroupA.Items.Clear();
                lbxGroupB.Items.Clear();

                for (int i = 0; i < this.AllPlayers.Count; i++)
                {
                    this.PlayersA.Add(this.AllPlayers[i]);
                }
            }
            else
            {
                for (int i = 0; i < this.AllPlayers.Count; i++)
                {
                    for (int j = 0; j < this.AllPlayers.Count; j++)
                    {
                        if (this.AllPlayers[i] == this.AllPlayers[j])
                        {
                            continue;
                        }

                        if (!this.DataSource.AsEnumerable().Any(row => (this.AllPlayers[i] == row.Field<String>("Killer") && this.AllPlayers[j] == row.Field<String>("Killed"))
                                                                                            || this.AllPlayers[i] == row.Field<String>("Killed") && this.AllPlayers[j] == row.Field<String>("Killer")))
                        {
                            bool theyAreEnemies = false;

                            for (int t = 0; t < this.PlayersA.Count; t++)
                            {
                                if (this.DataSource.AsEnumerable().Any(row => (this.PlayersA[t] == row.Field<String>("Killer") && this.AllPlayers[i] == row.Field<String>("Killed"))
                                                                                                    || this.PlayersA[t] == row.Field<String>("Killed") && this.AllPlayers[i] == row.Field<String>("Killer"))
                                    ||
                                    this.DataSource.AsEnumerable().Any(row => (this.PlayersA[t] == row.Field<String>("Killer") && this.AllPlayers[j] == row.Field<String>("Killed"))
                                                                                                    || this.PlayersA[t] == row.Field<String>("Killed") && this.AllPlayers[j] == row.Field<String>("Killer"))
                                    )
                                {
                                    theyAreEnemies = true;
                                    break;
                                }
                            }

                            if (!theyAreEnemies)
                            {
                                if (!this.PlayersA.Contains(this.AllPlayers[i]))
                                {
                                    this.PlayersA.Add(this.AllPlayers[i]);
                                }

                                if (!this.PlayersA.Contains(this.AllPlayers[j]))
                                {
                                    this.PlayersA.Add(this.AllPlayers[j]);
                                }
                            }
                            else
                            {
                                if (!this.PlayersB.Contains(this.AllPlayers[i]))
                                {
                                    this.PlayersB.Add(this.AllPlayers[i]);
                                }

                                if (!this.PlayersB.Contains(this.AllPlayers[j]))
                                {
                                    this.PlayersB.Add(this.AllPlayers[j]);
                                }
                            }
                        }
                        else
                        {
                            if (!this.PlayersA.Contains(this.AllPlayers[i]))
                            {
                                this.PlayersA.Add(this.AllPlayers[i]);
                            }

                            if (!this.PlayersB.Contains(this.AllPlayers[j]))
                            {
                                this.PlayersB.Add(this.AllPlayers[j]);
                            }
                        }
                    }

                    if (this.PlayersA.Count + this.PlayersB.Count == this.AllPlayers.Count)
                    {
                        break;
                    }
                }
            }
            this.BindPlayers();

            this.BindScoreBoard();

            this.BindStatistics();

            this.ShowActions();
        }

        private void BindScoreBoard()
        {
            trkBar_ScoreBoard.Minimum = 1;
            trkBar_ScoreBoard.Maximum = this.DataSource.Rows.Count;

            prgBar_ScoreBoard.Minimum = 0;
            prgBar_ScoreBoard.Maximum = this.DataSource.Rows.Count;


            int maxPoint = 0;

            List<KeyValuePair<string, int>> players = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < this.PlayersA.Count; i++)
            {
                int point = this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() == "self").Count();

                if (point > maxPoint)
                {
                    maxPoint = point;
                }
            }

            for (int i = 0; i < this.PlayersB.Count; i++)
            {
                int point = this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() == "self").Count();

                if (point > maxPoint)
                {
                    maxPoint = point;
                }
            }

            chtScoreGroup1.ChartAreas[0].AxisY.Minimum = 0;
            chtScoreGroup1.ChartAreas[0].AxisY.Maximum = maxPoint;

            chtScoreGroup2.ChartAreas[0].AxisY.Minimum = 0;
            chtScoreGroup2.ChartAreas[0].AxisY.Maximum = maxPoint;
        }

        private void BindStatistics()
        {
            Dictionary<string, int> serialKillers = new Dictionary<string, int>();
            Dictionary<string, int> killedsAfterJustBirth = new Dictionary<string, int>();
            Dictionary<string, int> serialKilleds = new Dictionary<string, int>();
            List<string> serialKilledWasKiller = new List<string>();

            int lastOrder = -1;

            for (int i = 0; i < this.DataSource.Rows.Count; i++)
            {
                if (!serialKilledWasKiller.Contains(this.DataSource.Rows[i]["Killer"].ToString()))
                {
                    serialKilledWasKiller.Add(this.DataSource.Rows[i]["Killer"].ToString());
                }

                if (!serialKillers.ContainsKey(this.DataSource.Rows[i]["Killer"].ToString()))
                {
                    serialKillers[this.DataSource.Rows[i]["Killer"].ToString()] = 0;
                }

                if (!killedsAfterJustBirth.ContainsKey(this.DataSource.Rows[i]["Killed"].ToString()))
                {
                    if (!this.DataSource.Rows[i]["Killed"].ToString().Equals("self"))
                    {
                        killedsAfterJustBirth[this.DataSource.Rows[i]["Killed"].ToString()] = 0;
                    }
                }

                if (!serialKilleds.ContainsKey(this.DataSource.Rows[i]["Killed"].ToString()))
                {
                    if (!this.DataSource.Rows[i]["Killed"].ToString().Equals("self"))
                    {
                        serialKilleds[this.DataSource.Rows[i]["Killed"].ToString()] = 0;
                    }
                }

                if (i > 0)
                {
                    if (this.DataSource.Rows[i - 1]["Killer"].ToString() == this.DataSource.Rows[i]["Killer"].ToString()
                        && this.DataSource.Rows[i - 1]["Killed"].ToString() != "self"
                        && this.DataSource.Rows[i]["Killed"].ToString() != "self")
                    {
                        lastOrder = Convert.ToInt32(this.DataSource.Rows[i]["Order"]);

                        serialKillers[this.DataSource.Rows[i]["Killer"].ToString()]++;

                        serialKilledWasKiller.Remove(this.DataSource.Rows[i]["Killer"].ToString());
                    }

                    if (this.DataSource.Rows[i - 1]["Killed"].ToString() == this.DataSource.Rows[i]["Killed"].ToString()
                        && this.DataSource.Rows[i]["Killed"].ToString() != "self")
                    {
                        killedsAfterJustBirth[this.DataSource.Rows[i]["Killed"].ToString()]++;
                    }

                    if (this.DataSource.Rows[i]["Killed"].ToString() != "self")
                    {
                        if (!serialKilledWasKiller.Contains(this.DataSource.Rows[i]["Killed"].ToString()))
                        {
                            serialKilleds[this.DataSource.Rows[i]["Killed"].ToString()]++;
                        }
                        else
                        {
                            serialKilledWasKiller.Remove(this.DataSource.Rows[i]["Killed"].ToString());
                        }
                    }
                }
            }


            grdSerialKillers.Columns.Clear();
            grdSerialKillers.Columns.Add("Key", "KEY");
            grdSerialKillers.Columns.Add("Values", "VALUES");

            foreach (KeyValuePair<string, int> item in serialKillers)
            {
                grdSerialKillers.Rows.Add(item.Key, item.Value);
            }

            grdSerialKillers.Sort(grdSerialKillers.Columns["Values"], ListSortDirection.Descending);



            grdSerialKilleds.Columns.Clear();
            grdSerialKilleds.Columns.Add("Key", "KEY");
            grdSerialKilleds.Columns.Add("Values", "VALUES");

            foreach (KeyValuePair<string, int> item in killedsAfterJustBirth)
            {
                grdSerialKilleds.Rows.Add(item.Key, item.Value);
            }

            grdSerialKilleds.Sort(grdSerialKilleds.Columns["Values"], ListSortDirection.Descending);



            grdUnluckyPlayers.Columns.Clear();
            grdUnluckyPlayers.Columns.Add("Key", "KEY");
            grdUnluckyPlayers.Columns.Add("Values", "VALUES");

            foreach (KeyValuePair<string, int> item in serialKilleds)
            {
                grdUnluckyPlayers.Rows.Add(item.Key, item.Value);
            }

            grdUnluckyPlayers.Sort(grdUnluckyPlayers.Columns["Values"], ListSortDirection.Descending);
        }

        private void BindPlayers()
        {
            #region Players Lists
            lbxGroupA.Items.Clear();
            lbxGroupB.Items.Clear();

            List<KeyValuePair<string, int>> players = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < this.PlayersA.Count; i++)
            {
                int point = this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() == "self").Count();
                players.Add(new KeyValuePair<string, int>(this.PlayersA[i], point));
            }

            players = players.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            for (int i = 0; i < players.Count; i++)
            {
                //lbxGroupA.Items.Add(string.Format("{0} #{1}", players[i].Key, players[i].Value));
                lbxGroupA.Items.Add(string.Format("{0}", players[i].Key));
            }


            players = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < this.PlayersB.Count; i++)
            {
                int point = this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() == "self").Count();
                players.Add(new KeyValuePair<string, int>(this.PlayersB[i], point));
            }

            players = players.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            for (int i = 0; i < players.Count; i++)
            {
                //lbxGroupB.Items.Add(string.Format("{0} #{1}", players[i].Key, players[i].Value));
                lbxGroupB.Items.Add(string.Format("{0}", players[i].Key));
            }
            #endregion

            #region Players For Performance
            cmbPlayersForPerformance.Items.Clear();

            for (int i = 0; i < this.PlayersA.Count; i++)
            {
                cmbPlayersForPerformance.Items.Add(this.PlayersA[i]);
            }

            for (int i = 0; i < this.PlayersB.Count; i++)
            {
                cmbPlayersForPerformance.Items.Add(this.PlayersB[i]);
            }

            trkBar_PlayerPerformancePartSize.Minimum = 1;
            trkBar_PlayerPerformancePartSize.Value = trkBar_PlayerPerformancePartSize.Minimum;
            trkBar_PlayerPerformancePartSize.Maximum = Math.Min(50, this.DataSource.Rows.Count);
            #endregion
        }

        private void ShowActions()
        {
            Dictionary<string, decimal> points = new Dictionary<string, decimal>();
            Dictionary<string, decimal> pointsByFormula = new Dictionary<string, decimal>();

            #region Actions
            int groupACount = 0, groupBCount = 0;

            DataTable pointDataSource = new DataTable();

            pointDataSource.Columns.Add("Order", typeof(int));
            pointDataSource.Columns.Add("Killer", typeof(string));
            pointDataSource.Columns.Add("KillerWithPoint", typeof(string));
            pointDataSource.Columns.Add("Killed", typeof(string));
            pointDataSource.Columns.Add("KilledWithPoint", typeof(string));
            pointDataSource.Columns.Add("Gun", typeof(string));
            pointDataSource.Columns.Add("GunTR", typeof(string));
            pointDataSource.Columns.Add("APoint", typeof(int));
            pointDataSource.Columns.Add("BPoint", typeof(int));
            pointDataSource.Columns.Add("Diff", typeof(string));

            Dictionary<string, bool> killerFound = new Dictionary<string, bool>();

            for (int i = 0; i < this.DataSource.Rows.Count; i++)
            {
                DataRow dr;

                dr = pointDataSource.NewRow();

                dr["Order"] = this.DataSource.Rows[i]["Order"];
                dr["Killer"] = this.DataSource.Rows[i]["Killer"];
                dr["KillerWithPoint"] = this.DataSource.Rows[i]["Killer"];
                dr["Killed"] = this.DataSource.Rows[i]["Killed"];
                dr["KilledWithPoint"] = this.DataSource.Rows[i]["Killed"];
                dr["Gun"] = this.DataSource.Rows[i]["Gun"];
                dr["GunTR"] = this.DataSource.Rows[i]["GunTR"];

                if (this.PlayersA.Contains(this.DataSource.Rows[i]["Killer"]))
                {
                    if (this.DataSource.Rows[i]["Killed"].Equals("self"))
                    {
                        groupACount--;
                    }
                    else
                    {
                        groupACount++;
                    }
                }

                if (this.PlayersB.Contains(this.DataSource.Rows[i]["Killer"]))
                {
                    if (this.DataSource.Rows[i]["Killed"].Equals("self"))
                    {
                        groupBCount--;
                    }
                    else
                    {
                        groupBCount++;
                    }
                }

                //Killer Points = Killer Points + (Victim Points / Killer Points) × Weapon Modifier × 5
                //Victim Points = Victim Points - (Victim Points / Killer Points) × Weapon Modifier × 5

                if (!points.ContainsKey(this.DataSource.Rows[i]["Killer"].ToString()))
                {
                    points.Add(this.DataSource.Rows[i]["Killer"].ToString(), 0);
                }
                if (!points.ContainsKey(this.DataSource.Rows[i]["Killed"].ToString()))
                {
                    points.Add(this.DataSource.Rows[i]["Killed"].ToString(), 0);
                }

                if (!pointsByFormula.ContainsKey(this.DataSource.Rows[i]["Killer"].ToString()))
                {
                    pointsByFormula.Add(this.DataSource.Rows[i]["Killer"].ToString(), 1);
                }
                if (!pointsByFormula.ContainsKey(this.DataSource.Rows[i]["Killed"].ToString()))
                {
                    pointsByFormula.Add(this.DataSource.Rows[i]["Killed"].ToString(), 1);
                }

                if (this.DataSource.Rows[i]["Killed"].Equals("self"))
                {
                    points[this.DataSource.Rows[i]["Killer"].ToString()]--;
                    pointsByFormula[this.DataSource.Rows[i]["Killer"].ToString()]--;
                }
                else
                {
                    points[this.DataSource.Rows[i]["Killer"].ToString()]++;
                    //pointsByFormula[this.DataSource.Rows[i]["Killer"].ToString()] += (pointsByFormula[this.DataSource.Rows[i]["Killed"].ToString()] / pointsByFormula[this.DataSource.Rows[i]["Killer"].ToString()]) * GunsPointModifiers[this.DataSource.Rows[i]["Gun"].ToString()] * 5;
                    //pointsByFormula[this.DataSource.Rows[i]["Killed"].ToString()] -= (pointsByFormula[this.DataSource.Rows[i]["Killed"].ToString()] / pointsByFormula[this.DataSource.Rows[i]["Killer"].ToString()]) * GunsPointModifiers[this.DataSource.Rows[i]["Gun"].ToString()] * 5;
                }

                dr["APoint"] = groupACount;
                dr["BPoint"] = groupBCount;

                int left = 0;
                int right = 0;
                string leftChar = "";
                string rightChar = "";

                string empty = "░", more = "▁", point = "█";

                if (groupACount > groupBCount)
                {
                    left = groupACount - groupBCount;

                    for (int j = 0; j < left; j++)
                    {
                        if (j > 10)
                        {
                            leftChar = more + leftChar;
                            rightChar = rightChar + empty;

                            break;
                        }

                        leftChar += point;
                        rightChar += empty;
                    }
                }

                if (groupBCount > groupACount)
                {
                    right = groupBCount - groupACount;

                    for (int j = 0; j < right; j++)
                    {
                        if (j > 10)
                        {
                            rightChar = rightChar + more;
                            leftChar = empty + leftChar;

                            break;
                        }

                        rightChar += point;
                        leftChar += empty;
                    }
                }

                dr["Diff"] = leftChar + " " + left + " | " + right + " " + rightChar;

                bool first = false;

                dr["KillerWithPoint"] = string.Format("{0} [{1}]", dr["Killer"], Math.Round(points[dr["Killer"].ToString()], 2));

                if (!killerFound.ContainsKey(dr["Killer"].ToString()))
                {
                    killerFound.Add(dr["Killer"].ToString(), true);
                    first = true;
                }

                if (dr["Killed"].ToString() != "self")
                {
                    if (!killerFound.ContainsKey(dr["Killed"].ToString()))
                    {
                        killerFound.Add(dr["Killed"].ToString(), false);
                        first = true;
                    }

                    string sign = "";
                    if (!killerFound[dr["Killed"].ToString()] && !first)
                    {
                        sign = "*";
                    }

                    dr["KilledWithPoint"] = string.Format("{0} [{1}] {2}", dr["Killed"], Math.Round(points[dr["Killed"].ToString()], 2), sign);

                    killerFound[dr["Killer"].ToString()] = true;
                    killerFound[dr["Killed"].ToString()] = false;
                }

                pointDataSource.Rows.Add(dr);
            }

            grd_Actions.DataSource = pointDataSource;
            #endregion

            DataTable chartDS = new DataTable();
            chartDS.Columns.Add("APoint", typeof(int));
            chartDS.Columns.Add("BPoint", typeof(int));

            for (int i = 0; i < pointDataSource.Rows.Count; i++)
            {
                DataRow dr;

                dr = chartDS.NewRow();

                dr["APoint"] = pointDataSource.Rows[i]["APoint"];
                dr["BPoint"] = pointDataSource.Rows[i]["BPoint"];

                chartDS.Rows.Add(dr);
            }

            chtActions.DataSource = chartDS;
            chtActions.DataBind();

            chtActions.Series["A"].LegendText = string.Format("A ({0})", pointDataSource.Rows[pointDataSource.Rows.Count - 1]["APoint"]);
            chtActions.Series["B"].LegendText = string.Format("B ({0})", pointDataSource.Rows[pointDataSource.Rows.Count - 1]["BPoint"]);

            grd_Log.DataSource = this.DataSource;
        }

        private void ShowPlayerPerformanceOnChart(string pPlayer)
        {
            int partSize = this.DataSource.Rows.Count / trkBar_PlayerPerformancePartSize.Value;
            int loop = this.DataSource.Rows.Count / partSize;
            int diff = this.DataSource.Rows.Count % trkBar_PlayerPerformancePartSize.Value;

            DataTable chartPlayersForPerformanceDS = new DataTable();
            chartPlayersForPerformanceDS.Columns.Add("Part", typeof(int));
            chartPlayersForPerformanceDS.Columns.Add("Killer", typeof(int));
            chartPlayersForPerformanceDS.Columns.Add("KillerTotal", typeof(int));
            chartPlayersForPerformanceDS.Columns.Add("KillerGunSummary", typeof(string));
            chartPlayersForPerformanceDS.Columns.Add("Killed", typeof(int));
            chartPlayersForPerformanceDS.Columns.Add("KilledTotal", typeof(int));
            chartPlayersForPerformanceDS.Columns.Add("KilledByGunSummary", typeof(string));

            DataRow dr;

            int partSizeOrg = partSize;

            for (int i = 0; i < loop; i++)
            {
                if (diff > 0)
                {
                    partSize = partSizeOrg + 1;
                    diff--;
                }
                else
                {
                    partSize = partSizeOrg;
                }

                dr = chartPlayersForPerformanceDS.NewRow();

                int killer = this.DataSource.AsEnumerable().Skip(i * partSize).Take(partSize).Where(row => row.Field<String>("Killer") == pPlayer && row.Field<String>("Killed") != "self").Count();

                Dictionary<string, int> guns = new Dictionary<string, int>();

                this.DataSource.AsEnumerable()
                    .Skip(i * partSize)
                    .Take(partSize).Where(row => row.Field<String>("Killer") == pPlayer && row.Field<String>("Killed") != "self")
                    .ToList()
                    .ForEach(row =>
                    {
                        if (!guns.ContainsKey(row.Field<String>("Gun")))
                        {
                            guns.Add(row.Field<String>("Gun"), 0);
                        }

                        guns[row.Field<String>("Gun")]++;
                    });

                string killerGunSummary = string.Empty;

                foreach (KeyValuePair<string, int> item in guns.OrderByDescending(x => x.Value))
                {
                    killerGunSummary += string.Format("{0} [{1}]\r\n", this.Guns[item.Key], item.Value);
                }

                killerGunSummary = killer + Environment.NewLine + killerGunSummary;

                int killed = this.DataSource.AsEnumerable().Skip(i * partSize).Take(partSize).Where(row => row.Field<String>("Killed") == pPlayer || (row.Field<String>("Killer") == pPlayer && row.Field<String>("Killed") == "self")).Count();

                guns = new Dictionary<string, int>();
                this.DataSource.AsEnumerable()
                    .Skip(i * partSize)
                    .Take(partSize).Where(row => row.Field<String>("Killed") == pPlayer)
                    .ToList()
                    .ForEach(row =>
                    {
                        if (!guns.ContainsKey(row.Field<String>("Gun")))
                        {
                            guns.Add(row.Field<String>("Gun"), 0);
                        }

                        guns[row.Field<String>("Gun")]++;
                    });

                string killedByGunSummary = string.Empty;

                foreach (KeyValuePair<string, int> item in guns.OrderByDescending(x => x.Value))
                {
                    killedByGunSummary += string.Format("{0} [{1}]\r\n", this.Guns[item.Key], item.Value);
                }

                killedByGunSummary = killed + Environment.NewLine + killedByGunSummary;

                dr["Part"] = i + 1;
                dr["Killer"] = killer;
                dr["KillerTotal"] = killer;
                dr["KillerGunSummary"] = killerGunSummary;
                dr["Killed"] = -1 * killed;
                dr["KilledTotal"] = -1 * killed;
                dr["KilledByGunSummary"] = killedByGunSummary;

                chartPlayersForPerformanceDS.Rows.Add(dr);
            }

            chtPlayerPerformance.DataSource = chartPlayersForPerformanceDS;
            chtPlayerPerformance.DataBind();

            for (int i = 0; i < chtPlayerPerformance.Series[0].Points.Count; i++)
            {
                if (chtPlayerPerformance.Series[0].Points.Count < 20)
                {
                    chtPlayerPerformance.Series[0].Points[i].Label = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<string>("KilledByGunSummary")).FirstOrDefault();
                    chtPlayerPerformance.Series[0].Points[i].ToolTip = chtPlayerPerformance.Series[0].Points[i].Label;
                }
                else
                {
                    chtPlayerPerformance.Series[0].Points[i].Label = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<int>("Killed")).FirstOrDefault().ToString();
                    chtPlayerPerformance.Series[0].Points[i].ToolTip = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<string>("KilledByGunSummary")).FirstOrDefault();
                }
            }

            for (int i = 0; i < chtPlayerPerformance.Series[1].Points.Count; i++)
            {
                if (chtPlayerPerformance.Series[1].Points.Count < 20)
                {
                    chtPlayerPerformance.Series[1].Points[i].Label = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<string>("KillerGunSummary")).FirstOrDefault();
                    chtPlayerPerformance.Series[1].Points[i].ToolTip = chtPlayerPerformance.Series[1].Points[i].Label;
                }
                else
                {
                    chtPlayerPerformance.Series[1].Points[i].Label = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<int>("Killer")).FirstOrDefault().ToString();
                    chtPlayerPerformance.Series[1].Points[i].ToolTip = chartPlayersForPerformanceDS.AsEnumerable().Where(row => row.Field<int>("Part") == i + 1).Select(row => row.Field<string>("KillerGunSummary")).FirstOrDefault();
                }
            }
        }


        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Guns.Add("crowbar", "Levye");
            Guns.Add("snark", "Böcek");
            Guns.Add("bolt", "Ok");
            Guns.Add("tripmine", "Sensörlü C4");
            Guns.Add("357", "Baba Yadigarı");
            Guns.Add("satchel", "C4");
            Guns.Add("9mmhandgun", "Su Tabancası");
            Guns.Add("crossbow", "Ok");
            Guns.Add("hornet", "Sinek");
            Guns.Add("shotgun", "Pompalı");
            Guns.Add("tau cannon", "Işın Silahı");
            Guns.Add("rpg_rocket", "Bazuka");
            Guns.Add("grenade", "Bomba");
            Guns.Add("gluon gun", "Süpürge");
            Guns.Add("9mmAR", "Taramalı");
            Guns.Add("worldspawn", "Düşerek");
            Guns.Add("trigger_hurt", "Nükleer");
            Guns.Add("env_explosion", "Nükleer Kule Silahı");

            GunsPointModifiers.Add("crowbar", 1.9M);
            GunsPointModifiers.Add("snark", 1.8M);
            GunsPointModifiers.Add("bolt", 1.7M);
            GunsPointModifiers.Add("tripmine", 1.6M);
            GunsPointModifiers.Add("357", 1.6M);
            GunsPointModifiers.Add("satchel", 1.5M);
            GunsPointModifiers.Add("9mmhandgun", 1.5M);
            GunsPointModifiers.Add("crossbow", 1.7M);
            GunsPointModifiers.Add("hornet", 1.3M);
            GunsPointModifiers.Add("shotgun", 1.2M);
            GunsPointModifiers.Add("tau cannon", 1);
            GunsPointModifiers.Add("rpg_rocket", 1);
            GunsPointModifiers.Add("grenade", 1);
            GunsPointModifiers.Add("gluon gun", 1);
            GunsPointModifiers.Add("9mmAR", 1);
            GunsPointModifiers.Add("worldspawn", 1);
            GunsPointModifiers.Add("trigger_hurt", 1);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Text Files (*.txt)|*.txt;";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = false;

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                LoadFilesFromDirectory(Path.GetDirectoryName(ofd.FileName));

                LoadArchive(ofd.FileName);
            }
        }

        private void LoadFilesFromDirectory(string pDirectory)
        {
            this.ArchiveFolder = pDirectory;

            string[] files = Directory.GetFiles(this.ArchiveFolder);

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".txt"))
                {
                    lbxArchive.Items.Add(Path.GetFileNameWithoutExtension(files[i]));
                }
            }
        }

        private void btnCalculatePoint_Click(object sender, EventArgs e)
        {
            this.ShowActions();
        }


        private void lbxGroupA_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbxGroupA.SelectedIndex > -1)
            {
                this.PlayersB.Add(lbxGroupA.SelectedItem.ToString());
                this.PlayersA.Remove(lbxGroupA.SelectedItem.ToString());

                this.BindPlayers();
                this.ShowActions();
            }
        }

        private void lbxGroupB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbxGroupB.SelectedIndex > -1)
            {
                this.PlayersA.Add(lbxGroupB.SelectedItem.ToString());
                this.PlayersB.Remove(lbxGroupB.SelectedItem.ToString());

                this.BindPlayers();
                this.ShowActions();
            }
        }

        private void lbxArchive_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbxArchive.SelectedIndex > -1)
            {
                this.LoadArchive(string.Format("{0}\\{1}.txt", this.ArchiveFolder, lbxArchive.SelectedItem));

                this.ShowActions();
            }
        }

        private void cmbPlayersForPerformance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlayersForPerformance.SelectedIndex > -1)
            {
                this.ShowPlayerPerformanceOnChart(cmbPlayersForPerformance.SelectedItem.ToString());
            }
        }

        private void trkBar_PlayerPerformancePartSize_Scroll(object sender, EventArgs e)
        {
            if (cmbPlayersForPerformance.SelectedIndex > -1)
            {
                lblPlayerPerformancePartSize.Text = Convert.ToString(this.DataSource.Rows.Count / trkBar_PlayerPerformancePartSize.Value);
                this.ShowPlayerPerformanceOnChart(cmbPlayersForPerformance.SelectedItem.ToString());
            }
        }

        private void trkBar_ScoreBoard_Scroll(object sender, EventArgs e)
        {
            int sumA = 0, sumB = 0;

            prgBar_ScoreBoard.Value = prgBar_ScoreBoard.Maximum - trkBar_ScoreBoard.Value;

            DataTable scoreBoard_A_DS = new DataTable();

            scoreBoard_A_DS.Columns.Add("Player", typeof(string));
            scoreBoard_A_DS.Columns.Add("Point", typeof(int));

            DataRow dr;

            for (int i = 0; i < this.PlayersA.Count; i++)
            {
                dr = scoreBoard_A_DS.NewRow();

                dr["Player"] = this.PlayersA[i];
                dr["Point"] = this.DataSource.AsEnumerable().Take(trkBar_ScoreBoard.Value).Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Take(trkBar_ScoreBoard.Value).Where(x => x["Killer"].ToString() == this.PlayersA[i] && x["Killed"].ToString() == "self").Count();

                scoreBoard_A_DS.Rows.Add(dr);

                sumA += Convert.ToInt32(dr["Point"]);
            }

            DataTable scoreBoard_B_DS = new DataTable();

            scoreBoard_B_DS.Columns.Add("Player", typeof(string));
            scoreBoard_B_DS.Columns.Add("Point", typeof(int));

            for (int i = 0; i < this.PlayersB.Count; i++)
            {
                dr = scoreBoard_B_DS.NewRow();

                dr["Player"] = this.PlayersB[i];
                dr["Point"] = this.DataSource.AsEnumerable().Take(trkBar_ScoreBoard.Value).Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() != "self").Count() - this.DataSource.AsEnumerable().Take(trkBar_ScoreBoard.Value).Where(x => x["Killer"].ToString() == this.PlayersB[i] && x["Killed"].ToString() == "self").Count();

                scoreBoard_B_DS.Rows.Add(dr);

                sumB += Convert.ToInt32(dr["Point"]);
            }

            SeriesChartType ct = SeriesChartType.RangeBar;

            if (chkScoreBoardKeepPosition.Checked || sumA > sumB)
            {
                lblScoreGroup1.Text = string.Format("A ({0})", sumA);
                lblScoreGroup2.Text = string.Format("B ({0})", sumB);

                grdScoreGroup1.BackgroundColor = System.Drawing.Color.Olive;
                grdScoreGroup1.DataSource = scoreBoard_A_DS.AsEnumerable()
                   .OrderByDescending(r => r.Field<int>("Point"))
                   .ThenBy(r => r.Field<string>("Player"))
                   .CopyToDataTable();

                grdScoreGroup2.BackgroundColor = System.Drawing.Color.Orange;
                grdScoreGroup2.DataSource = scoreBoard_B_DS.AsEnumerable()
                    .OrderByDescending(r => r.Field<int>("Point"))
                    .ThenBy(r => r.Field<string>("Player"))
                    .CopyToDataTable();


                chtScoreGroup1.Series.Clear();

                for (int i = 0; i < this.PlayersA.Count; i++)
                {
                    this.chtScoreGroup1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Player" + i,
                        Color = grdScoreGroup1.BackgroundColor,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        XValueMember = "Player",
                        YValueMembers = "Point",
                        ChartType = ct
                    });
                }

                chtScoreGroup1.DataSource = scoreBoard_A_DS.AsEnumerable()
                   .OrderByDescending(r => r.Field<string>("Player"))
                   .CopyToDataTable();


                chtScoreGroup2.Series.Clear();

                for (int i = 0; i < this.PlayersB.Count; i++)
                {
                    this.chtScoreGroup2.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Player" + i,
                        Color = grdScoreGroup2.BackgroundColor,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        XValueMember = "Player",
                        YValueMembers = "Point",
                        ChartType = ct
                    });
                }

                chtScoreGroup2.DataSource = scoreBoard_B_DS.AsEnumerable()
                    .OrderByDescending(r => r.Field<string>("Player"))
                    .CopyToDataTable();
            }
            else if (sumA < sumB)
            {
                lblScoreGroup1.Text = string.Format("B ({0})", sumB);
                lblScoreGroup2.Text = string.Format("A ({0})", sumA);

                grdScoreGroup1.BackgroundColor = System.Drawing.Color.Orange;
                grdScoreGroup1.DataSource = scoreBoard_B_DS.AsEnumerable()
                    .OrderByDescending(r => r.Field<int>("Point"))
                    .ThenBy(r => r.Field<string>("Player"))
                    .CopyToDataTable();

                grdScoreGroup2.BackgroundColor = System.Drawing.Color.Olive;
                grdScoreGroup2.DataSource = scoreBoard_A_DS.AsEnumerable()
                   .OrderByDescending(r => r.Field<int>("Point"))
                   .ThenBy(r => r.Field<string>("Player"))
                   .CopyToDataTable();



                chtScoreGroup1.Series.Clear();

                for (int i = 0; i < this.PlayersB.Count; i++)
                {
                    this.chtScoreGroup1.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Player" + i,
                        Color = grdScoreGroup1.BackgroundColor,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        XValueMember = "Player",
                        YValueMembers = "Point",
                        ChartType = ct
                    });
                }

                chtScoreGroup1.DataSource = scoreBoard_B_DS.AsEnumerable()
                   .OrderByDescending(r => r.Field<string>("Player"))
                   .CopyToDataTable(); ;


                chtScoreGroup2.Series.Clear();

                for (int i = 0; i < this.PlayersA.Count; i++)
                {
                    this.chtScoreGroup2.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Player" + i,
                        Color = grdScoreGroup2.BackgroundColor,
                        IsVisibleInLegend = false,
                        IsXValueIndexed = false,
                        XValueMember = "Player",
                        YValueMembers = "Point",
                        ChartType = ct
                    });
                }

                chtScoreGroup2.DataSource = scoreBoard_A_DS.AsEnumerable()
                    .OrderByDescending(r => r.Field<string>("Player"))
                    .CopyToDataTable(); ;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = Path.GetDirectoryName(this.CurrentLogFilePath);

                grd_Actions_View.ExportToPdf(folder + "\\Actions.pdf");
                grd_Actions_View.ExportToXlsx(folder + "\\Actions.xlsx");

                if (Directory.Exists(folder))
                {
                    System.Diagnostics.Process.Start(folder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            //New
            if (txtLog.ReadOnly)
            {
                btnNewSave.Text = "Save";

                txtLog.Text = string.Empty;
                txtLog.ReadOnly = false;
            }
            //Save
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Application.StartupPath;
                sfd.Filter = "Text Files (*.txt)|*.txt;";
                sfd.FilterIndex = 2;
                sfd.FileName = String.Format("{0}{1:0#}{2:0#}{3:0#}{4:0#}", DateTime.Now.Year.ToString().Substring(2, 2), DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute);
                sfd.RestoreDirectory = false;

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        if (Path.GetExtension(sfd.FileName) != ".txt")
                        {
                            sfd.FileName += ".txt";
                        }

                        File.WriteAllText(sfd.FileName, txtLog.Text);

                        btnNewSave.Text = "New";

                        txtLog.Text = string.Empty;
                        txtLog.ReadOnly = true;

                        this.LoadFilesFromDirectory(Path.GetDirectoryName(sfd.FileName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}