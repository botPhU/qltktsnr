using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace LauncherApp
{
    public partial class Form1 : Form
    {
        // === UI COMPONENTS ===
        private Panel pnlSidebar;
        private Panel pnlMainContent;
        private Panel pnlDashboard;
        private Panel pnlAccounts;
        private Panel pnlOpti;
        private Label lblStatus;
        private DataGridView dgvAccounts;
        
        // Opti Controls
        private CheckBox chkOptimize;
        private NumericUpDown numFps;
        private ComboBox cboSize;
        
        // Navigation Buttons
        private Button btnNavDash;
        private Button btnNavAccs;
        private Button btnNavOpti;

        // === CONFIG ===
        private string GamePath = @"..\Tái Sinh Ngọc Rồng.exe";
        private string ConfigPath = "accounts.json";

        // === PREMIUM PALETTE (Catppuccin Mocha inspired) ===
        private Color clrBase = Color.FromArgb(24, 24, 37);
        private Color clrSurface0 = Color.FromArgb(49, 50, 68);
        private Color clrSurface1 = Color.FromArgb(69, 71, 90);
        private Color clrOverlay = Color.FromArgb(108, 112, 134);
        private Color clrBlue = Color.FromArgb(137, 180, 250);
        private Color clrMauve = Color.FromArgb(198, 160, 246);
        private Color clrGreen = Color.FromArgb(166, 227, 161);
        private Color clrRed = Color.FromArgb(243, 139, 168);
        private Color clrPeach = Color.FromArgb(250, 179, 135);
        private Color clrText = Color.FromArgb(205, 214, 244);
        private Color clrSubtext = Color.FromArgb(166, 173, 200);

        public Form1()
        {
            InitializeComponent();
            SetupModernUI();
            LoadAccounts();
            SwitchTab("Accounts"); // Default tab
        }

        private void SetupModernUI()
        {
            this.Text = "Dragon Manager Premium v5.0";
            this.Size = new Size(850, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = clrBase;
            this.ForeColor = clrText;
            this.Font = new Font("Segoe UI Semibold", 10f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // --- SIDEBAR ---
            pnlSidebar = new Panel { Width = 200, Dock = DockStyle.Left, BackColor = Color.FromArgb(30, 30, 46) };
            
            var lblLogo = new Label { 
                Text = "DRACO\nMANAGER", 
                Font = new Font("Segoe UI Black", 18f), 
                ForeColor = clrBlue, 
                Location = new Point(20, 20), 
                Size = new Size(160, 70),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnNavDash = CreateNavButton("📊 Dashboard", 100);
            btnNavDash.Click += (s, e) => SwitchTab("Dash");

            btnNavAccs = CreateNavButton("👥 Accounts", 150);
            btnNavAccs.Click += (s, e) => SwitchTab("Accounts");

            btnNavOpti = CreateNavButton("⚙️ Optimization", 200);
            btnNavOpti.Click += (s, e) => SwitchTab("Opti");

            var lblVersion = new Label { 
                Text = "v5.0 Premium Edition", 
                Font = new Font("Segoe UI", 8f, FontStyle.Italic), 
                ForeColor = clrOverlay, 
                Dock = DockStyle.Bottom, 
                TextAlign = ContentAlignment.MiddleCenter, 
                Height = 30 
            };

            pnlSidebar.Controls.AddRange(new Control[] { lblLogo, btnNavDash, btnNavAccs, btnNavOpti, lblVersion });

            // --- MAIN CONTENT CONTAINER ---
            pnlMainContent = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20) };
            
            lblStatus = new Label { 
                Text = "Ready.", 
                Dock = DockStyle.Bottom, 
                Height = 30, 
                ForeColor = clrSubtext, 
                Font = new Font("Segoe UI", 9f, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleLeft
            };

            SetupDashboard();
            SetupAccountsTab();
            SetupOptiTab();

            this.Controls.Add(pnlMainContent);
            this.Controls.Add(pnlSidebar);
            this.Controls.Add(lblStatus);
            this.FormClosing += (s, e) => SaveAccounts();
        }

        private void SetupDashboard()
        {
            pnlDashboard = new Panel { Dock = DockStyle.Fill, Visible = false };
            var lblTitle = new Label { Text = "DASHBOARD", Font = new Font("Segoe UI", 20f, FontStyle.Bold), ForeColor = clrPeach, Location = new Point(0, 0), AutoSize = true };
            
            var pnlStats = new Panel { Location = new Point(0, 50), Size = new Size(600, 150), BackColor = clrSurface0 };
            pnlStats.Region = new Region(CreateRoundedRect(new Rectangle(0, 0, 600, 150), 15));
            
            var lblTabCount = new Label { Text = "Tabs Active: 0", Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 12f), ForeColor = clrBlue };
            var lblRam = new Label { Text = "Managed Accounts: 0", Location = new Point(20, 50), AutoSize = true, Font = new Font("Segoe UI", 12f), ForeColor = clrMauve };
            
            pnlStats.Controls.AddRange(new Control[] { lblTabCount, lblRam });
            
            var btnQuickFix = CreateActionBtn("Quick Reset Graphics", clrRed, 0, 220, 200, 45);
            btnQuickFix.Click += (s, e) => ApplySettings(false);

            pnlDashboard.Controls.AddRange(new Control[] { lblTitle, pnlStats, btnQuickFix });
            pnlMainContent.Controls.Add(pnlDashboard);
        }

        private void SetupAccountsTab()
        {
            pnlAccounts = new Panel { Dock = DockStyle.Fill, Visible = false };
            var lblTitle = new Label { Text = "ACCOUNT MANAGER", Font = new Font("Segoe UI", 20f, FontStyle.Bold), ForeColor = clrBlue, Location = new Point(0, 0), AutoSize = true };

            dgvAccounts = new DataGridView { 
                Location = new Point(0, 50), Size = new Size(580, 320), 
                ColumnCount = 2, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, 
                AllowUserToAddRows = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, 
                BackgroundColor = clrSurface0, GridColor = clrBase, BorderStyle = BorderStyle.None,
                RowHeadersVisible = false, EnableHeadersVisualStyles = false,
                ColumnHeadersHeight = 40
            };
            dgvAccounts.Columns[0].Name = "Username";
            dgvAccounts.Columns[1].Name = "Password";
            dgvAccounts.DefaultCellStyle = new DataGridViewCellStyle { BackColor = clrSurface0, ForeColor = clrText, SelectionBackColor = clrSurface1, SelectionForeColor = Color.White };
            dgvAccounts.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = clrSurface1, ForeColor = clrBlue, Font = new Font("Segoe UI", 10f, FontStyle.Bold) };

            var btnAdd = CreateActionBtn("➕ Add", clrGreen, 0, 385, 100, 40);
            btnAdd.Click += (s, e) => dgvAccounts.Rows.Add("", "");

            var btnDel = CreateActionBtn("🗑️ Delete", clrRed, 110, 385, 100, 40);
            btnDel.Click += (s, e) => { foreach (DataGridViewRow r in dgvAccounts.SelectedRows) if (!r.IsNewRow) dgvAccounts.Rows.Remove(r); };

            var btnPlaySelect = CreateActionBtn("▶ LAUNCH SELECTED", clrBlue, 220, 385, 180, 40);
            btnPlaySelect.Click += (s, e) => { foreach (DataGridViewRow r in dgvAccounts.SelectedRows) LaunchGame(r.Cells[0].Value?.ToString(), r.Cells[1].Value?.ToString()); };

            var btnPlayAll = CreateActionBtn("🚀 LAUNCH ALL", clrMauve, 410, 385, 180, 40);
            btnPlayAll.Click += (s, e) => { foreach (DataGridViewRow r in dgvAccounts.Rows) if (!r.IsNewRow) LaunchGame(r.Cells[0].Value?.ToString(), r.Cells[1].Value?.ToString()); };

            pnlAccounts.Controls.AddRange(new Control[] { lblTitle, dgvAccounts, btnAdd, btnDel, btnPlaySelect, btnPlayAll });
            pnlMainContent.Controls.Add(pnlAccounts);
        }

        private void SetupOptiTab()
        {
            pnlOpti = new Panel { Dock = DockStyle.Fill, Visible = false };
            var lblTitle = new Label { Text = "OPTIMIZATION CENTER", Font = new Font("Segoe UI", 20f, FontStyle.Bold), ForeColor = clrMauve, Location = new Point(0, 0), AutoSize = true };

            var grp = new Panel { Location = new Point(0, 60), Size = new Size(580, 200), BackColor = clrSurface0 };
            grp.Region = new Region(CreateRoundedRect(new Rectangle(0, 0, 580, 200), 15));

            chkOptimize = new CheckBox { Text = "Ultra Low Graphics & FPS Lock", Location = new Point(30, 30), AutoSize = true, ForeColor = clrText, Checked = true };
            
            var lblS = new Label { Text = "Resolution Size:", Location = new Point(30, 80), AutoSize = true, ForeColor = clrSubtext };
            cboSize = new ComboBox { Location = new Point(160, 76), Size = new Size(150, 30), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = clrBase, ForeColor = clrText };
            cboSize.Items.AddRange(new string[] { "100x75", "200x150", "300x225", "400x300", "600x450" });
            cboSize.SelectedIndex = 3;

            var lblF = new Label { Text = "Background FPS:", Location = new Point(30, 130), AutoSize = true, ForeColor = clrSubtext };
            numFps = new NumericUpDown { Location = new Point(160, 126), Size = new Size(80, 30), Minimum = 5, Maximum = 60, Value = 15, BackColor = clrBase, ForeColor = clrText };

            grp.Controls.AddRange(new Control[] { chkOptimize, lblS, cboSize, lblF, numFps });

            var btnApply = CreateActionBtn("⚡ APPLY TO ALL TABS", clrPeach, 0, 280, 280, 50);
            btnApply.Click += (s, e) => ApplySettings(true);

            var btnReset = CreateActionBtn("🔄 RESTORE DEFAULTS", clrGreen, 300, 280, 280, 50);
            btnReset.Click += (s, e) => ApplySettings(false);

            pnlOpti.Controls.AddRange(new Control[] { lblTitle, grp, btnApply, btnReset });
            pnlMainContent.Controls.Add(pnlOpti);
        }

        // === HELPERS ===
        private Button CreateNavButton(string text, int y)
        {
            var btn = new Button {
                Text = text, Location = new Point(10, y), Size = new Size(180, 45),
                FlatStyle = FlatStyle.Flat, BackColor = Color.Transparent, ForeColor = clrSubtext,
                Font = new Font("Segoe UI Semibold", 10f), TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0), Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = clrSurface0;
            btn.FlatAppearance.MouseDownBackColor = clrSurface1;
            btn.MouseEnter += (s, e) => btn.ForeColor = clrBlue;
            btn.MouseLeave += (s, e) => { if (!((Panel)pnlMainContent.Controls.Cast<Control>().First(c => c.Visible)).Name.Contains(text.Split(' ')[1])) btn.ForeColor = clrSubtext; };
            return btn;
        }

        private Button CreateActionBtn(string text, Color clr, int x, int y, int w, int h)
        {
            var btn = new Button {
                Text = text, Location = new Point(x, y), Size = new Size(w, h),
                FlatStyle = FlatStyle.Flat, BackColor = clr, ForeColor = clrBase,
                Font = new Font("Segoe UI Bold", 9.5f), Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Region = new Region(CreateRoundedRect(new Rectangle(0, 0, w, h), 10));
            return btn;
        }

        private void SwitchTab(string tab)
        {
            pnlDashboard.Visible = (tab == "Dash");
            pnlAccounts.Visible = (tab == "Accounts");
            pnlOpti.Visible = (tab == "Opti");
            
            btnNavDash.ForeColor = (tab == "Dash") ? clrBlue : clrSubtext;
            btnNavAccs.ForeColor = (tab == "Accounts") ? clrBlue : clrSubtext;
            btnNavOpti.ForeColor = (tab == "Opti") ? clrBlue : clrSubtext;

            btnNavDash.BackColor = (tab == "Dash") ? clrSurface0 : Color.Transparent;
            btnNavAccs.BackColor = (tab == "Accounts") ? clrSurface0 : Color.Transparent;
            btnNavOpti.BackColor = (tab == "Opti") ? clrSurface0 : Color.Transparent;
        }

        private GraphicsPath CreateRoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            var d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // === LOGIC (REUSED FROM v4.0) ===
        private void LaunchGame(string u, string p)
        {
            if (string.IsNullOrEmpty(u) || !File.Exists(GamePath)) return;
            try {
                string args = $"--user \"{u}\" --pass \"{p}\"";
                if (chkOptimize.Checked) {
                    string[] s = cboSize.Text.Split('x');
                    args += $" --optimize --width {s[0]} --height {s[1]} --fps {(int)numFps.Value}";
                }
                Process.Start(new ProcessStartInfo { FileName = GamePath, Arguments = args, WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(GamePath)) });
                UpdateStatus($"Successfully launched: {u}", clrGreen);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ApplySettings(bool opti)
        {
            try {
                int w = 1024, h = 600;
                if (opti) {
                    string[] s = cboSize.Text.Split('x');
                    w = int.Parse(s[0]); h = int.Parse(s[1]);
                }
                string path = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(GamePath)), "Mods", "AutoLoginMod_Settings.json");
                var cfg = new Dictionary<string, object> {
                    { "Optimize", opti && chkOptimize.Checked }, { "Width", w }, { "Height", h },
                    { "Fps", (opti && chkOptimize.Checked) ? (int)numFps.Value : 60 }
                };
                File.WriteAllText(path, JsonSerializer.Serialize(cfg));
                UpdateStatus($"Applied {(opti ? "Optimization" : "Default")} to all tabs", opti ? clrPeach : clrGreen);
            } catch (Exception ex) { UpdateStatus("Error: " + ex.Message, clrRed); }
        }

        private void UpdateStatus(string msg, Color c) { lblStatus.Text = $"[{DateTime.Now:HH:mm:ss}] {msg}"; lblStatus.ForeColor = c; }

        private void LoadAccounts() {
            if (!File.Exists(ConfigPath)) return;
            try {
                var accs = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(ConfigPath));
                foreach (var a in accs) dgvAccounts.Rows.Add(a["User"], a["Pass"]);
            } catch { }
        }

        private void SaveAccounts() {
            var list = new List<Dictionary<string, string>>();
            foreach (DataGridViewRow r in dgvAccounts.Rows) {
                if (r.IsNewRow) continue;
                var u = r.Cells[0].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(u)) list.Add(new Dictionary<string, string> { { "User", u }, { "Pass", r.Cells[1].Value?.ToString() ?? "" } });
            }
            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(list));
        }
    }
}
