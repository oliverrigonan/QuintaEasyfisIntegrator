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
        // ================
        // Global Variables
        // ================
        private static FileSystemWatcher fileWatcher = new FileSystemWatcher();
        private static Timer timer = new Timer();

        // =========
        // Main Form
        // =========
        public FormMain()
        {
            // ===============
            // Form Components
            // ===============
            InitializeComponent();

            txtTime.Text = "00:00:00 AM";
            txtTimeTrigger.Text = "02:00:00 AM";
            txtAPIURLHostSource.Text = "http://api.kloudhotels.com:8081";
            txtAPIURLHostEasyfis.Text = "http://localhost:2651";
            txtJSONDownloadPath.Text = "D:\\Innosoft\\fileWatcherPath";
            txtJSONArchivePath.Text = "D:\\Innosoft\\fileWatcherPath\\archive";

            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;

            // ============
            // File Watcher
            // ============
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
                SyncSalesData();
            }
        }

        // ===============
        // Sync Sales Data
        // ===============
        public void SyncSalesData()
        {
            try
            {
                // ===========
                // URL Filters
                // ===========
                DateTime dateTimeNow = DateTime.Now;
                String yesterdayDate = dateTimeNow.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                String todayDate = dateTimeNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                // ====================
                // Process Http Request
                // ====================
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(txtAPIURLHostSource.Text + "/api/backoffice/transjournal?hcd=QDB&tkn=WOREINSLKJNFQOEASDJKAB&pos=false&frm=" + yesterdayDate + "&tdt=" + todayDate);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                // =====================
                // Process Http Response
                // =====================
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    RootObject rootObject = (RootObject)javaScriptSerializer.Deserialize(result, typeof(RootObject));

                    List<TRN> newListTRN = new List<TRN>();
                    foreach (var TRN in rootObject.TRN)
                    {
                        List<JEN> newListJEN = new List<JEN>();
                        foreach (var JEN in TRN.JEN)
                        {
                            JEN newJEN = new JEN()
                            {
                                FTN = JEN.FTN,
                                SAR = JEN.SAR,
                                FID = JEN.FID,
                                SUF = JEN.SUF,
                                ACI = JEN.ACI,
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
                            };

                            newListJEN.Add(newJEN);
                        }

                        TRN newTRN = new TRN()
                        {
                            FTN = TRN.FTN,
                            PTN = TRN.PTN,
                            FID = TRN.FID,
                            STS = TRN.STS,
                            ADT = TRN.ADT,
                            DDT = TRN.DDT,
                            TDT = TRN.TDT,
                            TCI = TRN.TCI,
                            TCC = TRN.TCC,
                            MEM = TRN.MEM,
                            SAR = TRN.SAR,
                            SAI = TRN.SAI, // Item Code
                            SAM = TRN.SAM, // Item Description
                            ACI = TRN.ACI, // Customer Code
                            ACC = TRN.ACC, // Customer Name
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
                            JEN = TRN.JEN
                        };

                        newListTRN.Add(newTRN);
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
                    String fileName = "Transaction (" + todayDate + ")";

                    String json = new JavaScriptSerializer().Serialize(rootObjectData);
                    String jsonFileName = jsonDownloadPath + "\\" + fileName + ".json";

                    File.WriteAllText(jsonFileName, json);

                    txtActivity.Text += fileName + " JSON File Successfuly Created! \r\n\n";
                    SendSalesJsonFiles();
                }
            }
            catch (Exception e)
            {
                txtActivity.Text += e.Message + "\r\n\n";
            }
        }

        // =======================
        // Send Json Files (Sales)
        // =======================
        public void SendSalesJsonFiles()
        {
            try
            {
                // ==========
                // Read Files
                // ==========
                String apiUrlHost = txtAPIURLHostEasyfis.Text;
                String jsonDownloadPath = txtJSONDownloadPath.Text;

                List<String> files = new List<String>(Directory.EnumerateFiles(jsonDownloadPath));
                if (files.Any())
                {
                    var file = files.FirstOrDefault();

                    String json;
                    using (StreamReader streamReader = new StreamReader(file))
                    {
                        json = streamReader.ReadToEnd();
                    }

                    // ====================
                    // Process Http Request
                    // ====================
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + apiUrlHost + "/api/add/POSIntegration/salesInvoice");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";

                    // =================
                    // Process Http Data
                    // =================
                    using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                        RootObject rootObject = javaScriptSerializer.Deserialize<RootObject>(json);

                        streamWriter.Write(new JavaScriptSerializer().Serialize(rootObject));

                        txtActivity.Text += "Sending \r\n\n";
                    }

                    // =====================
                    // Process Http Response
                    // =====================
                    HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (result != null)
                        {
                            txtActivity.Text += file + " Sent Succesful! \r\n\n";
                        }
                    }
                }

                timer.Enabled = true;
            }
            catch (WebException we)
            {
                var resp = new StreamReader(we.Response.GetResponseStream()).ReadToEnd();
                txtActivity.Text += resp.Replace("\"", "") + "\r\n\n";
            }
        }
    }

    // ==========
    // Model: CON
    // ==========
    public class CON
    {
        public string DPI { get; set; }
        public string DCI { get; set; }
    }

    // ===========
    // Model: Root
    // ===========
    public class RootObject
    {
        public CON CON { get; set; }
        public List<TRN> TRN { get; set; }
    }

    // ==========
    // Model: TRN
    // ==========
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
        public string TCC { get; set; }
        public string MEM { get; set; }
        public int SAR { get; set; }
        public string SAI { get; set; }
        public string SAM { get; set; }
        public string ACI { get; set; }
        public string ACC { get; set; }
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

    // ==========
    // Model: JEN
    // ==========
    public class JEN
    {
        public int FTN { get; set; }
        public int SAR { get; set; }
        public string FID { get; set; }
        public string SUF { get; set; }
        public string ACI { get; set; }
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