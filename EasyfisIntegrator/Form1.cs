using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
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
        private static Boolean isStart = false;

        // =========
        // Main Form
        // =========
        public FormMain()
        {
            // ===============
            // Form Components
            // ===============
            InitializeComponent();

            String settingsPath = Application.StartupPath + @"\settings.json";

            String json;
            using (StreamReader streamReader = new StreamReader(settingsPath))
            {
                json = streamReader.ReadToEnd();
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Settings s = js.Deserialize<Settings>(json);

            txtTime.Text = "00:00:00 AM";
            txtTimeTrigger.Text = s.DefaultTimeTrigger;
            txtAPIURLHostSource.Text = s.DefaultAPIUrlHostSource;
            txtAPIURLHostEasyfis.Text = s.DefaultAPIUrlHostEasyfis;
            txtJSONDownloadPath.Text = s.JSONDownloadPath;
            txtJSONArchivePath.Text = s.JSONArchivePath;
            txtJSONReturnPath.Text = s.JSONReturnPath;

            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            timer.Enabled = true;

            CreateComboBoxTerm();
            CreateComboBoxTaxType();
            CreateComboBoxDiscount();

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

            isStart = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            txtTimeTrigger.Enabled = false;
            txtAPIURLHostSource.Enabled = false;
            txtAPIURLHostEasyfis.Enabled = false;
            txtJSONDownloadPath.Enabled = false;
            txtJSONArchivePath.Enabled = false;
            txtJSONReturnPath.Enabled = false;
            cboTerm.Enabled = false;
            cboVatInput.Enabled = false;
            cboVatOutput.Enabled = false;
            cboWTax.Enabled = false;
            cboDiscount.Enabled = false;
            btnSaveSettings.Enabled = false;
            btnEditSettings.Enabled = true;
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

            if (isStart)
            {
                if (txtTime.Text.Equals(txtTimeTrigger.Text))
                {
                    SyncSalesData();
                }
            }
        }

        // =====================
        // Create Combo Box Term
        // =====================
        public void CreateComboBoxTerm()
        {
            try
            {
                String apiUrlHost = txtAPIURLHostEasyfis.Text;

                // ====================
                // Process Http Request
                // ====================
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrlHost + "/api/quinta/integration/salesInvoice/dropdown/term/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                // =====================
                // Process Http Response
                // =====================
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<MstTerm> mstTerms = (List<MstTerm>)javaScriptSerializer.Deserialize(result, typeof(List<MstTerm>));

                    List<MstTerm> newListTerm = new List<MstTerm>();

                    var isFirstIndexSelected = false;

                    foreach (var term in mstTerms)
                    {
                        cboTerm.Items.Add(term.Term);

                        if (!isFirstIndexSelected)
                        {
                            cboTerm.SelectedItem = term.Term;
                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Application.StartupPath + @"\settings.json";

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Settings s = js.Deserialize<Settings>(settingsJson);

                    cboTerm.SelectedItem = s.DefaultTerm;
                }
            }
            catch (Exception e)
            {
                txtActivity.Text += e.Message + "\r\n\n";
            }
        }

        // =========================
        // Create Combo Box Tax Type
        // =========================
        public void CreateComboBoxTaxType()
        {
            try
            {
                String apiUrlHost = txtAPIURLHostEasyfis.Text;

                // ====================
                // Process Http Request
                // ====================
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrlHost + "/api/quinta/integration/salesInvoice/dropdown/taxType/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                // =====================
                // Process Http Response
                // =====================
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<MstTaxType> mstTaxTypes = (List<MstTaxType>)javaScriptSerializer.Deserialize(result, typeof(List<MstTaxType>));

                    List<MstTaxType> newListTaxType = new List<MstTaxType>();

                    var isFirstIndexSelected = false;

                    foreach (var taxType in mstTaxTypes)
                    {
                        cboVatOutput.Items.Add(taxType.TaxType);
                        cboVatInput.Items.Add(taxType.TaxType);
                        cboWTax.Items.Add(taxType.TaxType);

                        if (!isFirstIndexSelected)
                        {
                            cboVatOutput.SelectedItem = taxType.TaxType;
                            cboVatInput.SelectedItem = taxType.TaxType;
                            cboWTax.SelectedItem = taxType.TaxType;
                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Application.StartupPath + @"\settings.json";

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Settings s = js.Deserialize<Settings>(settingsJson);

                    cboVatOutput.SelectedItem = s.DefaultVatOutput;
                    cboVatInput.SelectedItem = s.DefaultVatInput;
                    cboWTax.SelectedItem = s.DefaultWTax;
                }
            }
            catch (Exception e)
            {
                txtActivity.Text += e.Message + "\r\n\n";
            }
        }

        // =========================
        // Create Combo Box Discount
        // =========================
        public void CreateComboBoxDiscount()
        {
            try
            {
                String apiUrlHost = txtAPIURLHostEasyfis.Text;

                // ====================
                // Process Http Request
                // ====================
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrlHost + "/api/quinta/integration/salesInvoice/dropdown/discount/list");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                // =====================
                // Process Http Response
                // =====================
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();

                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    List<MstDiscount> mstDiscounts = (List<MstDiscount>)javaScriptSerializer.Deserialize(result, typeof(List<MstDiscount>));

                    List<MstDiscount> newListDiscount = new List<MstDiscount>();

                    var isFirstIndexSelected = false;

                    foreach (var discount in mstDiscounts)
                    {
                        cboDiscount.Items.Add(discount.Discount);

                        if (!isFirstIndexSelected)
                        {
                            cboDiscount.SelectedItem = discount.Discount;
                            isFirstIndexSelected = true;
                        }
                    }

                    String settingsPath = Application.StartupPath + @"\settings.json";

                    String settingsJson;
                    using (StreamReader settingsStreamReader = new StreamReader(settingsPath))
                    {
                        settingsJson = settingsStreamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    Settings s = js.Deserialize<Settings>(settingsJson);

                    cboDiscount.SelectedItem = s.DefaultDiscount;
                }
            }
            catch (Exception e)
            {
                txtActivity.Text += e.Message + "\r\n\n";
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
                            JEN = newListJEN
                        };

                        newListTRN.Add(newTRN);
                    }

                    CON newCON = new CON()
                    {
                        DPI = rootObject.CON.DPI,
                        DCI = rootObject.CON.DCI,
                    };

                    String defaultTerm = cboTerm.Text;
                    String defaultVatOutput = cboVatOutput.Text;
                    String defaultVatInput = cboVatInput.Text;
                    String defaultWTax = cboWTax.Text;
                    String defaultDiscount = cboDiscount.Text;

                    RootObject rootObjectData = new RootObject()
                    {
                        CON = newCON,
                        TRN = newListTRN,
                        DefaultTerm = defaultTerm,
                        DefaultVatOutput = defaultVatOutput,
                        DefaultVatInput = defaultVatInput,
                        DefaultWTax = defaultWTax,
                        DefaultDiscount = defaultDiscount,
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

                    Console.WriteLine(file);

                    String json;
                    using (StreamReader streamReader = new StreamReader(file))
                    {
                        json = streamReader.ReadToEnd();
                    }

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    RootObject r = js.Deserialize<RootObject>(json);
                    Console.WriteLine(new JavaScriptSerializer().Serialize(r));

                    // ====================
                    // Process Http Request
                    // ====================
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrlHost + "/api/quinta/integration/salesInvoice/add");
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
                            Console.WriteLine(result);

                            DateTime dateTimeNow = DateTime.Now;
                            String todayDate = dateTimeNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                            String jsonReturnPath = txtJSONReturnPath.Text;
                            String fileName = "Return (" + todayDate + ")";

                            String jsonFileName = jsonReturnPath + "\\" + fileName + ".json";

                            File.WriteAllText(jsonFileName, result);

                            txtActivity.Text += Path.GetFileName(file) + " Sent Succesful! \r\n\n";

                            File.Move(file, txtJSONArchivePath.Text + "\\" + Path.GetFileName(file));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                txtActivity.Text += e.Message + "\r\n\n";
            }
        }

        // ============
        // Button Start
        // ============
        private void btnStart_Click(object sender, EventArgs e)
        {
            isStart = true;

            btnStart.Enabled = false;
            btnStop.Enabled = true;

            txtTimeTrigger.Enabled = false;
            txtAPIURLHostSource.Enabled = false;
            txtAPIURLHostEasyfis.Enabled = false;
            txtJSONDownloadPath.Enabled = false;
            txtJSONArchivePath.Enabled = false;
            txtJSONReturnPath.Enabled = false;
            cboTerm.Enabled = false;
            cboVatInput.Enabled = false;
            cboVatOutput.Enabled = false;
            cboWTax.Enabled = false;
            cboDiscount.Enabled = false;
            btnSaveSettings.Enabled = false;
            btnEditSettings.Enabled = true;
        }

        // ===========
        // Button Stop
        // ===========
        private void btnStop_Click(object sender, EventArgs e)
        {
            isStart = false;

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            txtTimeTrigger.Enabled = true;
        }

        // =============
        // Save Settings
        // =============
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;

            txtAPIURLHostSource.Enabled = false;
            txtAPIURLHostEasyfis.Enabled = false;
            txtJSONDownloadPath.Enabled = false;
            txtJSONArchivePath.Enabled = false;
            txtJSONReturnPath.Enabled = false;
            cboTerm.Enabled = false;
            cboVatInput.Enabled = false;
            cboVatOutput.Enabled = false;
            cboWTax.Enabled = false;
            cboDiscount.Enabled = false;
            btnSaveSettings.Enabled = false;
            btnEditSettings.Enabled = true;

            Settings settingsData = new Settings()
            {
                DefaultTimeTrigger = txtTimeTrigger.Text,
                DefaultAPIUrlHostSource = txtAPIURLHostSource.Text,
                DefaultAPIUrlHostEasyfis = txtAPIURLHostEasyfis.Text,
                JSONDownloadPath = txtJSONDownloadPath.Text,
                JSONArchivePath = txtJSONArchivePath.Text,
                JSONReturnPath = txtJSONReturnPath.Text,
                DefaultVatOutput = cboVatOutput.Text,
                DefaultVatInput = cboVatInput.Text,
                DefaultWTax = cboWTax.Text,
                DefaultDiscount = cboDiscount.Text,
                DefaultTerm = cboTerm.Text,
            };

            String json = new JavaScriptSerializer().Serialize(settingsData);
            String settingsPath = Application.StartupPath + @"\settings.json";

            File.WriteAllText(settingsPath, json);
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            isStart = false;

            btnStart.Enabled = false;
            btnStop.Enabled = false;

            txtTimeTrigger.Enabled = true;
            txtAPIURLHostSource.Enabled = true;
            txtAPIURLHostEasyfis.Enabled = true;
            txtJSONDownloadPath.Enabled = true;
            txtJSONArchivePath.Enabled = true;
            txtJSONReturnPath.Enabled = true;
            cboTerm.Enabled = true;
            cboVatInput.Enabled = true;
            cboVatOutput.Enabled = true;
            cboWTax.Enabled = true;
            cboDiscount.Enabled = true;
            btnSaveSettings.Enabled = true;
            btnEditSettings.Enabled = false;
        }
    }

    // ===========
    // Model: Term
    // ===========
    public class MstTerm
    {
        public string Id { get; set; }
        public string Term { get; set; }
    }

    // ===============
    // Model: Tax Type
    // ===============
    public class MstTaxType
    {
        public string Id { get; set; }
        public string TaxType { get; set; }
    }

    // ===============
    // Model: Discount
    // ===============
    public class MstDiscount
    {
        public string Id { get; set; }
        public string Discount { get; set; }
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
        public String DefaultTerm { get; set; }
        public String DefaultVatOutput { get; set; }
        public String DefaultVatInput { get; set; }
        public String DefaultWTax { get; set; }
        public String DefaultDiscount { get; set; }
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

    // ========
    // Settings
    // ========
    public class Settings
    {
        public string DefaultTimeTrigger { get; set; }
        public string DefaultAPIUrlHostSource { get; set; }
        public string DefaultAPIUrlHostEasyfis { get; set; }
        public string JSONDownloadPath { get; set; }
        public string JSONArchivePath { get; set; }
        public string JSONReturnPath { get; set; }
        public string DefaultVatOutput { get; set; }
        public string DefaultVatInput { get; set; }
        public string DefaultWTax { get; set; }
        public string DefaultDiscount { get; set; }
        public string DefaultTerm { get; set; }
    }
}