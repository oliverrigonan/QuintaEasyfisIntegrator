using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyfisIntegrator
{
    public partial class FormMain : Form
    {
        // ===============
        // Global Variables
        // ================
        private static FileSystemWatcher fileWatcher = new FileSystemWatcher();
        private static Timer timer = new Timer();

        // =========
        // Main Form
        // =========
        public FormMain()
        {
            InitializeComponent();

            txtTime.Text = "00:00:00 AM";
            txtTimeTrigger.Text = "02:00:00 AM";
            txtAPIURLHost.Text = "http://api.kloudhotels.com:8081";
            txtJSONDownloadPath.Text = "D:\\Innosoft\\fileWatcherPath";
            txtJSONArchivePath.Text = "D:\\Innosoft\\fileWatcherPath\\archive";

            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;

            fileWatcher.Path = txtJSONDownloadPath.Text;
            fileWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fileWatcher.Filter = "*.json";

            fileWatcher.Changed += new FileSystemEventHandler(FileWatcherOnChanged);
            fileWatcher.Created += new FileSystemEventHandler(FileWatcherOnChanged);
            fileWatcher.Deleted += new FileSystemEventHandler(FileWatcherOnChanged);
            fileWatcher.Renamed += new RenamedEventHandler(FileWatcherOnRenamed);

            fileWatcher.EnableRaisingEvents = true;
        }

        // =========================================================
        // File Watcher: On File Changed (Changed, Created, Deleted)
        // =========================================================
        public void FileWatcherOnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        // =============================
        // File Watcher: On File Renamed
        // =============================
        public void FileWatcherOnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        // ==========
        // Timer Tick
        // ==========
        public void TimerTick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            if (txtTime.Text.Equals(txtTimeTrigger.Text))
            {
                timer.Enabled = false;
                GetData();
            }
        }

        // =================
        // Get Data From API
        // =================
        public void GetData()
        {
            try
            {
                DateTime dateTimeNow = DateTime.Now;
                String yesterdayDate = dateTimeNow.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                String todayDate = dateTimeNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(txtAPIURLHost.Text + "/api/backoffice/transjournal?hcd=QDB&tkn=WOREINSLKJNFQOEASDJKAB&pos=false&frm=" + yesterdayDate + "&tdt=" + todayDate);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    RootObject rootObject = (RootObject)js.Deserialize(result, typeof(RootObject));

                    List<TRN> newListTRN = new List<TRN>();
                    foreach (var TRN in rootObject.TRN)
                    {
                        List<JEN> newListJEN = new List<JEN>();
                        foreach (var JEN in TRN.JEN)
                        {
                            newListJEN = new List<JEN>
                            {
                                new JEN()
                                {
                                        FTN = JEN.FTN,
                                        SAR = JEN.SAR,
                                        FID = JEN.FID,
                                        SUF = JEN.SUF,
                                        ACC = JEN.ACC,
                                        ACS = JEN.ACS,
                                        SAC = JEN.SAC,
                                        ADC = JEN.ADC,
                                        TDT = JEN.TDT,
                                        GLC = JEN.GLC,
                                        DBT = JEN.DBT,
                                        CRD = JEN.CRD,
                                        BNK = JEN.BNK,
                                        BNM = JEN.BNM,
                                        BOA = JEN.BOA,
                                        CTI = JEN.CTI,
                                        CNO = JEN.CNO,
                                        VNO = JEN.VNO,
                                        VDT = JEN.VDT,
                                        CHQ = JEN.CHQ
                                }
                            };
                        }

                        newListTRN = new List<TRN>
                        {
                            new TRN()
                            {
                                FTN = TRN.FTN,
                                PTN = TRN.PTN,
                                FID = TRN.FID,
                                STS = TRN.STS,
                                ADT = TRN.ADT,
                                DDT = TRN.DDT,
                                TDT = TRN.TDT,
                                TCI = TRN.TCI,
                                SAR = TRN.SAR,
                                TCC = TRN.TCC,
                                SAI = TRN.SAI,
                                ACI = TRN.ACI,
                                RNO = TRN.RNO,
                                ACS = TRN.ACS,
                                CUR = TRN.CUR,
                                DSC = TRN.DSC,
                                DSA = TRN.DSA,
                                BAM = TRN.BAM,
                                GAM = TRN.GAM,
                                NBA = TRN.NBA,
                                NAM = TRN.NAM,
                                BNK = TRN.BNK,
                                BNM = TRN.BNM,
                                BOA = TRN.BOA,
                                CTI = TRN.CTI,
                                CNO = TRN.CNO,
                                VNO = TRN.VNO,
                                VDT = TRN.VDT,
                                CHQ = TRN.CHQ,
                                RMK = TRN.RMK,
                                RMO = TRN.RMO,
                                CNT = TRN.CNT,
                                WHT = TRN.WHT,
                                MRK = TRN.MRK,
                                SRC = TRN.SRC,
                                JEN = TRN.JEN,
                            }
                        };
                    }

                    CON newCON = new CON()
                    {
                        DPI = rootObject.CON.DPI,
                        DCI = rootObject.CON.DCI,
                    };

                    RootObject rootObjectData = new RootObject()
                    {
                        CON = newCON,
                        TRN = newListTRN
                    };

                    String jsonDownloadPath = txtJSONDownloadPath.Text;
                    String fileName = "Sample";

                    String json = new JavaScriptSerializer().Serialize(rootObjectData);
                    String jsonFileName = jsonDownloadPath + "\\" + fileName + ".json";

                    File.WriteAllText(jsonFileName, json);

                    txtActivity.Text += "JSON Successfuly Downloaded! \r\n";
                    timer.Enabled = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // ============
    // Models (CON)
    // ============
    public class CON
    {
        public string DPI { get; set; }
        public string DCI { get; set; }
    }
    // ===========
    // Models Root
    // ===========
    public class RootObject
    {
        public CON CON { get; set; }
        public List<TRN> TRN { get; set; }
    }

    // ============
    // Models (TRN)
    // ============
    public class TRN
    {
        public int FTN { get; set; }
        public int PTN { get; set; }
        public string FID { get; set; }
        public string STS { get; set; }
        public string ADT { get; set; }
        public string DDT { get; set; }
        public string TDT { get; set; }
        public int TCI { get; set; }
        public int SAR { get; set; }
        public string TCC { get; set; }
        public string SAI { get; set; }
        public string ACI { get; set; }
        public string RNO { get; set; }
        public string ACS { get; set; }
        public string CUR { get; set; }
        public double DSC { get; set; }
        public double DSA { get; set; }
        public double BAM { get; set; }
        public double GAM { get; set; }
        public double NBA { get; set; }
        public double NAM { get; set; }
        public int BNK { get; set; }
        public string BNM { get; set; }
        public string BOA { get; set; }
        public string CTI { get; set; }
        public string CNO { get; set; }
        public string VNO { get; set; }
        public string VDT { get; set; }
        public string CHQ { get; set; }
        public string RMK { get; set; }
        public string RMO { get; set; }
        public string CNT { get; set; }
        public bool WHT { get; set; }
        public string MRK { get; set; }
        public string SRC { get; set; }
        public List<JEN> JEN { get; set; }
    }

    // ============
    // Models (JEN)
    // ============
    public class JEN
    {
        public int FTN { get; set; }
        public int SAR { get; set; }
        public string FID { get; set; }
        public string SUF { get; set; }
        public string ACC { get; set; }
        public string ACS { get; set; }
        public string SAC { get; set; }
        public string ADC { get; set; }
        public string TDT { get; set; }
        public string GLC { get; set; }
        public double DBT { get; set; }
        public double CRD { get; set; }
        public int BNK { get; set; }
        public string BNM { get; set; }
        public string BOA { get; set; }
        public string CTI { get; set; }
        public string CNO { get; set; }
        public string VNO { get; set; }
        public string VDT { get; set; }
        public string CHQ { get; set; }
    }
}
