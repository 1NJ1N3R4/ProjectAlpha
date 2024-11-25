using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlpha
{
    public partial class ProjectAlpha : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_XDOWN = 0x0080;
        private const uint MOUSEEVENTF_XUP = 0x0100;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        private bool isListeningForInventoryKey = false;
        private const int HOTKEY_ID = 1;
        private bool isListeningForHotkey = false;
        private uint currentHotkeyModifiers = 0;
        private uint currentHotkey = 0;

        private bool isSelectingLocation = false;
        private string currentSelectionMode = "";
        private POINT selectedHelmetLocation, selectedChestplateLocation, selectedLeggingsLocation, selectedBootsLocation;
        private POINT selectedSwitchHelmetLocation, selectedSwitchChestplateLocation, selectedSwitchLeggingsLocation, selectedSwitchBootsLocation;

        private Form overlay;

        public ProjectAlpha()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            UnregisterGlobalHotkey();
            Environment.Exit(0);
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void selectHotkey_Click(object sender, EventArgs e)
        {
            isListeningForHotkey = true;
            selectHotkey.Text = "Press a key...";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isListeningForHotkey)
            {
                currentHotkeyModifiers = 0;

                if (e.Control) currentHotkeyModifiers |= 0x2;
                if (e.Shift) currentHotkeyModifiers |= 0x4;
                if (e.Alt) currentHotkeyModifiers |= 0x1;

                currentHotkey = (uint)e.KeyCode;

                selectHotkey.Text = $"{(e.Control ? "Ctrl + " : "")}{(e.Shift ? "Shift + " : "")}{(e.Alt ? "Alt + " : "")}{e.KeyCode}";
                isListeningForHotkey = false;

                RegisterGlobalHotkey();
            }
        }


        private void RegisterGlobalHotkey()
        {
            UnregisterGlobalHotkey();
            if (!RegisterHotKey(this.Handle, HOTKEY_ID, currentHotkeyModifiers, currentHotkey))
            {
                MessageBox.Show("Failed to register hotkey. Try a different combination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UnregisterGlobalHotkey()
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                ExecuteHotkeyAction();
            }
            base.WndProc(ref m);
        }

        private void helmetSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("Helmet");
        }

        private void chestplateSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("Chestplate");
        }

        private void legginsSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("Leggings");
        }

        private void bootsSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("Boots");
        }

        private void switchhelmetSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("SwitchHelmet");
        }

        private void switchchestplateSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("SwitchChestplate");
        }

        private void switchlegginsSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("SwitchLeggings");
        }

        private void switchbootsSelect_Click(object sender, EventArgs e)
        {
            StartLocationSelection("SwitchBoots");
        }

        private void selectInventoryKey_Click(object sender, EventArgs e)
        {
            isListeningForInventoryKey = true;
            selectInventoryKey.Text = "?";
            this.KeyDown -= Form1_KeyDown;
            this.KeyDown += selectInventoryKey_KeyDown;
        }

        private void selectInventoryKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (isListeningForInventoryKey)
            {
                if (e.Control || e.Shift || e.Alt)
                {
                    MessageBox.Show("Please press a single key without modifiers (Ctrl, Shift, Alt).", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                uint inventoryKey = (uint)e.KeyCode;
                selectInventoryKey.Text = $"{e.KeyCode}";
                isListeningForInventoryKey = false;

                this.KeyDown -= selectInventoryKey_KeyDown;
                this.KeyDown += Form1_KeyDown;
            }
        }

        private void ResetButtonColors()
        {
            helmetSelect.BackColor = SystemColors.Control;
            chestplateSelect.BackColor = SystemColors.Control;
            legginsSelect.BackColor = SystemColors.Control;
            bootsSelect.BackColor = SystemColors.Control;
            switchhelmetSelect.BackColor = SystemColors.Control;
            switchchestplateSelect.BackColor = SystemColors.Control;
            switchlegginsSelect.BackColor = SystemColors.Control;
            switchbootsSelect.BackColor = SystemColors.Control;
        }

        private void StartLocationSelection(string mode)
        {
            if (isSelectingLocation) return;
            isSelectingLocation = true;
            currentSelectionMode = mode;

            overlay = new Form
            {
                BackColor = Color.Black,
                Opacity = 0.5,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                ShowInTaskbar = false
            };

            overlay.MouseClick += Overlay_MouseClick;
            overlay.Show();
        }

        private void Overlay_MouseClick(object sender, MouseEventArgs e)
        {
            if (isSelectingLocation)
            {
                GetCursorPos(out POINT selectedLocation);
                switch (currentSelectionMode)
                {
                    case "Helmet":
                        selectedHelmetLocation = selectedLocation;
                        helmetSelect.BackColor = Color.LightGreen;
                        break;
                    case "Chestplate":
                        selectedChestplateLocation = selectedLocation;
                        chestplateSelect.BackColor = Color.LightGreen;
                        break;
                    case "Leggings":
                        selectedLeggingsLocation = selectedLocation;
                        legginsSelect.BackColor = Color.LightGreen;
                        break;
                    case "Boots":
                        selectedBootsLocation = selectedLocation;
                        bootsSelect.BackColor = Color.LightGreen;
                        break;
                    case "SwitchHelmet":
                        selectedSwitchHelmetLocation = selectedLocation;
                        switchhelmetSelect.BackColor = Color.LightGreen;
                        break;
                    case "SwitchChestplate":
                        selectedSwitchChestplateLocation = selectedLocation;
                        switchchestplateSelect.BackColor = Color.LightGreen;
                        break;
                    case "SwitchLeggings":
                        selectedSwitchLeggingsLocation = selectedLocation;
                        switchlegginsSelect.BackColor = Color.LightGreen;
                        break;
                    case "SwitchBoots":
                        selectedSwitchBootsLocation = selectedLocation;
                        switchbootsSelect.BackColor = Color.LightGreen;
                        break;
                }

                overlay.Close();
                overlay = null;
                isSelectingLocation = false;
            }
        }

        private void SaveLocations()
        {
            string filePath = "locations.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Helmet:{selectedHelmetLocation.X},{selectedHelmetLocation.Y}");
                writer.WriteLine($"Chestplate:{selectedChestplateLocation.X},{selectedChestplateLocation.Y}");
                writer.WriteLine($"Leggings:{selectedLeggingsLocation.X},{selectedLeggingsLocation.Y}");
                writer.WriteLine($"Boots:{selectedBootsLocation.X},{selectedBootsLocation.Y}");
                writer.WriteLine($"SwitchHelmet:{selectedSwitchHelmetLocation.X},{selectedSwitchHelmetLocation.Y}");
                writer.WriteLine($"SwitchChestplate:{selectedSwitchChestplateLocation.X},{selectedSwitchChestplateLocation.Y}");
                writer.WriteLine($"SwitchLeggings:{selectedSwitchLeggingsLocation.X},{selectedSwitchLeggingsLocation.Y}");
                writer.WriteLine($"SwitchBoots:{selectedSwitchBootsLocation.X},{selectedSwitchBootsLocation.Y}");

                writer.WriteLine($"Hotkey:{currentHotkeyModifiers},{currentHotkey}");
                writer.WriteLine($"InventoryKey:{selectInventoryKey.Text}");

                writer.WriteLine($"MillisecondsChange:{milisecondsChange.Value}");
            }
        }


        private POINT ParsePoint(string pointString)
        {
            string[] coordinates = pointString.Split(',');
            return new POINT
            {
                X = int.Parse(coordinates[0]),
                Y = int.Parse(coordinates[1])
            };
        }

        private void LoadLocations()
        {
            string filePath = "locations.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length != 2) continue;

                        switch (parts[0])
                        {
                            case "Helmet":
                                selectedHelmetLocation = ParsePoint(parts[1]);
                                break;
                            case "Chestplate":
                                selectedChestplateLocation = ParsePoint(parts[1]);
                                break;
                            case "Leggings":
                                selectedLeggingsLocation = ParsePoint(parts[1]);
                                break;
                            case "Boots":
                                selectedBootsLocation = ParsePoint(parts[1]);
                                break;
                            case "SwitchHelmet":
                                selectedSwitchHelmetLocation = ParsePoint(parts[1]);
                                break;
                            case "SwitchChestplate":
                                selectedSwitchChestplateLocation = ParsePoint(parts[1]);
                                break;
                            case "SwitchLeggings":
                                selectedSwitchLeggingsLocation = ParsePoint(parts[1]);
                                break;
                            case "SwitchBoots":
                                selectedSwitchBootsLocation = ParsePoint(parts[1]);
                                break;
                            case "Hotkey":
                                string[] hotkeyParts = parts[1].Split(',');
                                if (hotkeyParts.Length == 2)
                                {
                                    currentHotkeyModifiers = uint.Parse(hotkeyParts[0]);
                                    currentHotkey = uint.Parse(hotkeyParts[1]);

                                    if (currentHotkeyModifiers == 0)
                                    {
                                        selectHotkey.Text = $"{((Keys)currentHotkey).ToString()}";
                                    }
                                    else
                                    {
                                        selectHotkey.Text = $"{currentHotkeyModifiers} + {((Keys)currentHotkey).ToString()}";
                                    }

                                    RegisterGlobalHotkey();
                                }
                                break;
                            case "InventoryKey":
                                selectInventoryKey.Text = parts[1];
                                break;
                            case "MillisecondsChange":
                                milisecondsChange.Value = int.Parse(parts[1]);
                                milisecondsValue.Text = $"{milisecondsChange.Value} : MS";
                                break;
                        }
                    }
                }

                helmetSelect.BackColor = Color.LightGreen;
                chestplateSelect.BackColor = Color.LightGreen;
                legginsSelect.BackColor = Color.LightGreen;
                bootsSelect.BackColor = Color.LightGreen;
                switchhelmetSelect.BackColor = Color.LightGreen;
                switchchestplateSelect.BackColor = Color.LightGreen;
                switchlegginsSelect.BackColor = Color.LightGreen;
                switchbootsSelect.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("No saved locations or keys found.", "Load Locations", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void milisecondsChange_Scroll(object sender, EventArgs e)
        {
            milisecondsValue.Text = milisecondsChange.Value.ToString() + " : MS";
        }


        private void SimulateMouseClick(uint button)
        {
            mouse_event(button, 0, 0, 0, 0);
            mouse_event(button == MOUSEEVENTF_XDOWN ? MOUSEEVENTF_XUP : MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void MoveMouseTo(POINT location)
        {
            Cursor.Position = new Point(location.X, location.Y);
        }

        private async Task Delay(int milliseconds)
        {
            await Task.Delay(milisecondsChange.Value);
        }

        private async void ExecuteHotkeyAction()
        {
            if (currentHotkey != 0)
            {

                SendKeys.SendWait(selectInventoryKey.Text);
                await Task.Delay(milisecondsChange.Value); 

                var actions = new[]
                {
            (location: selectedSwitchHelmetLocation, key: "{4}"),
            (location: selectedSwitchChestplateLocation, key: "{5}"),
            (location: selectedSwitchLeggingsLocation, key: "{6}"),
            (location: selectedSwitchBootsLocation, key: "{7}"),

            (location: selectedHelmetLocation, key: "{4}"),
            (location: selectedChestplateLocation, key: "{5}"),
            (location: selectedLeggingsLocation, key: "{6}"),
            (location: selectedBootsLocation, key: "{7}"),

            (location: selectedSwitchHelmetLocation, key: "{4}"),
            (location: selectedSwitchChestplateLocation, key: "{5}"),
            (location: selectedSwitchLeggingsLocation, key: "{6}"),
            (location: selectedSwitchBootsLocation, key: "{7}")
        };
                foreach (var (location, key) in actions)
                {
                    if (location.X != 0 || location.Y != 0)
                    {
                        MoveMouseTo(location);
                        await Task.Delay(milisecondsChange.Value);
                        SendKeys.Send(key);
                        await Task.Delay(milisecondsChange.Value);
                    }
                }

                SendKeys.SendWait(selectInventoryKey.Text);
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveLocations();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadLocations();
        }

    }
}