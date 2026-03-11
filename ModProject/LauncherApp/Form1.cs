using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace LauncherApp
{
    public partial class Form1 : Form
    {
        private DataGridView dgvAccounts;
        private Button btnLaunchSelected;
        private Button btnLaunchAll;
        private Button btnAddRow;
        private Button btnDeleteRow;

        // Settings controls
        private CheckBox chkOptimize;
        private Label lblWidth;
        private Label lblHeight;
        private Label lblFps;
        private NumericUpDown numWidth;
        private NumericUpDown numHeight;
        private NumericUpDown numFps;
        private GroupBox grpSettings;
        private Label lblStatus;

        private string GamePath = @"..\Tái Sinh Ngọc Rồng.exe";
        private string ConfigPath = "accounts.json";

        // Bảng màu Dark Theme
        private Color bgDark = Color.FromArgb(30, 30, 46);
        private Color bgPanel = Color.FromArgb(45, 45, 65);
        private Color accentColor = Color.FromArgb(137, 180, 250);
        private Color accentHover = Color.FromArgb(116, 160, 230);
        private Color textColor = Color.FromArgb(205, 214, 244);
        private Color dangerColor = Color.FromArgb(243, 139, 168);
        private Color successColor = Color.FromArgb(166, 227, 161);
        private Color borderColor = Color.FromArgb(88, 91, 112);

        public Form1()
        {
            InitializeComponent();
            SetupUI();
            LoadAccounts();
        }

        private Button CreateStyledButton(string text, Color bgColor, int x, int y, int w, int h)
        {
            var btn = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(w, h),
                FlatStyle = FlatStyle.Flat,
                BackColor = bgColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = bgColor;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(bgColor, 0.1f);
            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(bgColor, 0.2f);
            
            // Bo tròn góc
            btn.Region = new Region(CreateRoundedRect(new Rectangle(0, 0, w, h), 8));
            return btn;
        }

        private GraphicsPath CreateRoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(bounds.Right - radius * 2, bounds.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Button btnApplySettings;

        // ...

        private void SetupUI()
        {
            this.Text = "🐉 Tái Sinh Ngọc Rồng - AutoLogin Tool v3.0";
            this.Size = new Size(700, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = bgDark;
            this.ForeColor = textColor;
            this.Font = new Font("Segoe UI", 10f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ... (Title and DataGridView setup unchanged)
            var lblTitle = new Label { Text = "🐉 TNR Auto Login Manager", Font = new Font("Segoe UI", 16f, FontStyle.Bold), ForeColor = accentColor, Location = new Point(15, 10), AutoSize = true };

            dgvAccounts = new DataGridView { Location = new Point(15, 50), Size = new Size(650, 260), ColumnCount = 2, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, AllowUserToAddRows = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect, BackgroundColor = bgPanel, GridColor = borderColor, BorderStyle = BorderStyle.None, RowHeadersVisible = false, EnableHeadersVisualStyles = false, DefaultCellStyle = new DataGridViewCellStyle { BackColor = bgPanel, ForeColor = textColor, SelectionBackColor = Color.FromArgb(60, 60, 90), SelectionForeColor = Color.White, Font = new Font("Segoe UI", 10f) }, ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(55, 55, 80), ForeColor = accentColor, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Alignment = DataGridViewContentAlignment.MiddleCenter } };
            dgvAccounts.Columns[0].Name = "Tài Khoản"; dgvAccounts.Columns[1].Name = "Mật Khẩu";

            btnAddRow = CreateStyledButton("➕ Thêm", accentColor, 15, 320, 100, 38);
            btnAddRow.Click += (s, e) => dgvAccounts.Rows.Add("", "");

            btnDeleteRow = CreateStyledButton("🗑️ Xóa", dangerColor, 125, 320, 100, 38);
            btnDeleteRow.Click += BtnDeleteRow_Click;

            btnLaunchSelected = CreateStyledButton("▶ Mở Đã Chọn", Color.FromArgb(116, 199, 236), 245, 320, 155, 38);
            btnLaunchSelected.Click += BtnLaunchSelected_Click;

            btnLaunchAll = CreateStyledButton("🚀 MỞ TẤT CẢ", successColor, 410, 320, 155, 38);
            btnLaunchAll.ForeColor = Color.FromArgb(30, 30, 46);
            btnLaunchAll.Click += BtnLaunchAll_Click;

            // === PANEL CÀI ĐẶT TỐI ƯU THỜI GIAN THỰC ===
            grpSettings = new GroupBox
            {
                Text = "⚙️  Bảng Điều Khiển Đồ Họa Động (Tất Cả Tab)",
                Location = new Point(15, 370),
                Size = new Size(650, 100),
                ForeColor = accentColor,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                BackColor = bgPanel
            };

            chkOptimize = new CheckBox
            {
                Text = "  Giảm cấu hình & thu nhỏ màn hình",
                Location = new Point(15, 30),
                AutoSize = true,
                ForeColor = textColor,
                Font = new Font("Segoe UI", 9.5f),
                Checked = true
            };
            chkOptimize.CheckedChanged += ChkOptimize_Changed;

            lblWidth = new Label { Text = "Rộng:", Location = new Point(15, 62), AutoSize = true, ForeColor = textColor, Font = new Font("Segoe UI", 9f) };
            numWidth = new NumericUpDown
            {
                Location = new Point(65, 58), Size = new Size(70, 28),
                Minimum = 100, Maximum = 1920, Value = 400,
                BackColor = bgDark, ForeColor = textColor
            };

            lblHeight = new Label { Text = "Cao:", Location = new Point(145, 62), AutoSize = true, ForeColor = textColor, Font = new Font("Segoe UI", 9f) };
            numHeight = new NumericUpDown
            {
                Location = new Point(185, 58), Size = new Size(70, 28),
                Minimum = 75, Maximum = 1080, Value = 300,
                BackColor = bgDark, ForeColor = textColor
            };

            lblFps = new Label { Text = "FPS:", Location = new Point(270, 62), AutoSize = true, ForeColor = textColor, Font = new Font("Segoe UI", 9f) };
            numFps = new NumericUpDown
            {
                Location = new Point(310, 58), Size = new Size(60, 28),
                Minimum = 5, Maximum = 60, Value = 15,
                BackColor = bgDark, ForeColor = textColor
            };

            btnApplySettings = CreateStyledButton("Áp dụng", Color.FromArgb(249, 226, 175), 380, 48, 100, 35);
            btnApplySettings.ForeColor = bgDark;
            btnApplySettings.Click += BtnApplySettings_Click;

            var lblNote2 = new Label
            {
                Text = "Click 'Áp dụng' -> Game tự đổi size!",
                Location = new Point(490, 58),
                AutoSize = true,
                ForeColor = Color.FromArgb(150, 160, 180),
                Font = new Font("Segoe UI", 8f, FontStyle.Italic)
            };

            grpSettings.Controls.AddRange(new Control[] { chkOptimize, lblWidth, numWidth, lblHeight, numHeight, lblFps, numFps, btnApplySettings, lblNote2 });

            // === STATUS BAR ===
            lblStatus = new Label
            {
                Text = "Sẵn sàng.",
                Location = new Point(15, 480),
                Size = new Size(650, 25),
                ForeColor = Color.FromArgb(150, 160, 180),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Italic)
            };

            // Add all controls
            this.Controls.AddRange(new Control[] { lblTitle, dgvAccounts, btnAddRow, btnDeleteRow, btnLaunchSelected, btnLaunchAll, grpSettings, lblStatus });
            this.FormClosing += Form1_FormClosing;
        }

        private void BtnApplySettings_Click(object sender, EventArgs e)
        {
            try
            {
                // Thư mục chứa game
                string targetPath = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(GamePath)), "Mods", "AutoLoginMod_Settings.json");
                
                var config = new Dictionary<string, object>
                {
                    { "Optimize", chkOptimize.Checked },
                    { "Width", (int)numWidth.Value },
                    { "Height", (int)numHeight.Value },
                    { "Fps", (int)numFps.Value }
                };

                File.WriteAllText(targetPath, JsonSerializer.Serialize(config));
                
                lblStatus.Text = $"✅ Đã gửi lệnh thay đổi cài đặt đến tất cả các tab! ({DateTime.Now:HH:mm:ss})";
                lblStatus.ForeColor = successColor;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "⚠️ Lỗi khi lưu cài đặt: " + ex.Message;
                lblStatus.ForeColor = dangerColor;
            }
        }

        private void ChkOptimize_Changed(object sender, EventArgs e)
        {
            bool enabled = chkOptimize.Checked;
            numWidth.Enabled = enabled;
            numHeight.Enabled = enabled;
            numFps.Enabled = enabled;
        }

        private void LoadAccounts()
        {
            if (File.Exists(ConfigPath))
            {
                try
                {
                    string json = File.ReadAllText(ConfigPath);
                    var accs = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);
                    foreach (var acc in accs)
                    {
                        dgvAccounts.Rows.Add(acc["User"], acc["Pass"]);
                    }
                }
                catch { }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var accs = new List<Dictionary<string, string>>();
            foreach (DataGridViewRow row in dgvAccounts.Rows)
            {
                if (row.IsNewRow) continue;
                var u = row.Cells[0].Value?.ToString() ?? "";
                var p = row.Cells[1].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(u))
                {
                    accs.Add(new Dictionary<string, string> { { "User", u }, { "Pass", p } });
                }
            }
            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(accs));
        }

        private void LaunchGame(string user, string pass)
        {
            if (!File.Exists(GamePath))
            {
                MessageBox.Show("Không tìm thấy file game:\n" + Path.GetFullPath(GamePath) + "\n\nHãy đảm bảo thư mục TNR_Tool nằm cạnh file game.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string arguments = $"--user \"{user}\" --pass \"{pass}\"";

                // Thêm tham số tối ưu hóa nếu được bật
                if (chkOptimize.Checked)
                {
                    arguments += $" --optimize --width {(int)numWidth.Value} --height {(int)numHeight.Value} --fps {(int)numFps.Value}";
                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = GamePath,
                    Arguments = arguments,
                    WorkingDirectory = Path.GetDirectoryName(Path.GetFullPath(GamePath))
                };
                Process.Start(startInfo);
                lblStatus.Text = $"✅ Đã mở game cho tài khoản: {user}  |  {DateTime.Now:HH:mm:ss}";
                lblStatus.ForeColor = successColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở game: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAccounts.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dgvAccounts.Rows.Remove(row);
                }
            }
        }

        private void BtnLaunchSelected_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvAccounts.SelectedRows)
            {
                var u = row.Cells[0].Value?.ToString();
                var p = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(u))
                {
                    LaunchGame(u, p);
                    count++;
                }
            }
            if (count == 0)
            {
                lblStatus.Text = "⚠️ Chưa chọn tài khoản nào.";
                lblStatus.ForeColor = Color.FromArgb(249, 226, 175);
            }
        }

        private void BtnLaunchAll_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvAccounts.Rows)
            {
                if (row.IsNewRow) continue;
                var u = row.Cells[0].Value?.ToString();
                var p = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(u))
                {
                    LaunchGame(u, p);
                    count++;
                }
            }
            lblStatus.Text = $"🚀 Đã mở {count} tài khoản  |  {DateTime.Now:HH:mm:ss}";
            lblStatus.ForeColor = successColor;
        }
    }
}
