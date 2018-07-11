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

            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;

            fileWatcher.Path = "D:\\Innosoft\\fileWatcherPath";
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
        public static void FileWatcherOnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        // =============================
        // File Watcher: On File Renamed
        // =============================
        public static void FileWatcherOnRenamed(object source, RenamedEventArgs e)
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
                Console.WriteLine("Execute");
            }
        }

        // =================
        // Get Data From API
        // =================
        private static void GetData()
        {
            try
            {
                DateTime dateTimeNow = DateTime.Now;
                String fromDate = dateTimeNow.AddDays(-1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                String toDate = dateTimeNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.kloudhotels.com:8081/api/backoffice/transjournal?hcd=QDB&tkn=WOREINSLKJNFQOEASDJKAB&pos=false&frm=" + fromDate + "&tdt=" + toDate);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    List<RootObject> rootObject = (List<RootObject>)js.Deserialize(result, typeof(List<RootObject>));

                    // TODO LIST: API Ojbects
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
