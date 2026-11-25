using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ChuuongTrinhQuanLyKhachSan
{
    internal static class HotelTheme
    {
        internal static readonly Color Navy = Color.FromArgb(18, 40, 44);
        internal static readonly Color NavyLight = Color.FromArgb(34, 64, 68);
        internal static readonly Color Gold = Color.FromArgb(233, 197, 130);
        internal static readonly Color Canvas = Color.FromArgb(242, 246, 246);
        internal static readonly Color Surface = Color.White;
        internal static readonly Color Ink = Color.FromArgb(23, 43, 46);
        internal static readonly Color Muted = Color.FromArgb(79, 100, 104);
        internal static readonly Color Line = Color.FromArgb(209, 222, 223);
        internal static readonly Color Accent = Color.FromArgb(0, 105, 96);
        internal static readonly Color AccentDark = Color.FromArgb(0, 82, 76);
        internal static readonly Color Selected = Color.FromArgb(219, 241, 234);
        internal static readonly Color Danger = Color.FromArgb(165, 44, 53);

        internal static readonly Font Body = new Font("Segoe UI", 10F);
        internal static readonly Font Caption = new Font("Segoe UI Semibold", 10F);
        internal static readonly Font Section = new Font("Segoe UI Semibold", 14F);
        internal static readonly Font Heading = new Font("Segoe UI Semibold", 23F);
        internal static readonly Font Brand = new Font("Georgia", 19F, FontStyle.Bold);
        internal static readonly Font SmallBrand = new Font("Georgia", 15F, FontStyle.Bold);

        internal static int Px(Control control, int value)
        {
            return (int)Math.Round(value * control.DeviceDpi / 96.0);
        }

        internal static void Title(Label label, string text)
        {
            label.Text = text;
            label.Font = Heading;
            label.ForeColor = Ink;
        }

        internal static Label Label(string text, Font font, Color color)
        {
            return new Label
            {
                Text = text, Font = font, ForeColor = color, AutoSize = true,
                BackColor = Color.Transparent, UseMnemonic = false
            };
        }

        internal static void Action(Guna2Button button, string text, bool destructive = false)
        {
            button.Text = text;
            button.Font = Caption;
            button.ForeColor = Color.White;
            button.FillColor = destructive ? Danger : Accent;
            button.HoverState.FillColor = destructive ? Color.FromArgb(135, 32, 40) : AccentDark;
            button.PressedColor = Color.Black;
            button.BorderRadius = 9;
            button.Cursor = Cursors.Hand;
        }

        internal static void Field(Control input)
        {
            input.Font = Body;
            if (input is Guna2TextBox text)
            {
                text.BorderRadius = 8;
                text.BorderColor = Line;
                text.FillColor = text.ReadOnly ? Canvas : Surface;
                text.ForeColor = Ink;
                text.PlaceholderForeColor = Muted;
                text.FocusedState.BorderColor = Accent;
                text.HoverState.BorderColor = Accent;
            }
            else if (input is Guna2ComboBox combo)
            {
                combo.BorderRadius = 8;
                combo.BorderColor = Line;
                combo.FillColor = Surface;
                combo.ForeColor = Ink;
                combo.FocusedColor = Accent;
                combo.ItemHeight = Px(combo, 36);
            }
            else if (input is Guna2DateTimePicker date)
            {
                date.BorderRadius = 8;
                date.BorderThickness = 1;
                date.BorderColor = Line;
                date.FillColor = Surface;
                date.ForeColor = Ink;
                date.CheckedState.FillColor = Surface;
            }
        }

        internal static void PlaceField(Control input, Label label, int left, int top, int width)
        {
            label.Font = Caption;
            label.ForeColor = Muted;
            label.Location = new Point(left, top);
            input.SetBounds(left, top + Px(input, 24), width, Px(input, 42));
        }

        internal static Guna2Panel Card(Control parent, params Control[] controls)
        {
            var card = new Guna2Panel
            {
                BorderRadius = 14, BorderThickness = 1, BorderColor = Line,
                FillColor = Surface, BackColor = Color.Transparent
            };
            parent.Controls.Add(card);
            card.Controls.AddRange(controls);
            return card;
        }

        internal static Panel Page(UserControl page)
        {
            var existing = new Control[page.Controls.Count];
            page.Controls.CopyTo(existing, 0);
            var content = new Panel { BackColor = Canvas, Margin = Padding.Empty };
            page.BackColor = Canvas;
            page.AutoScroll = true;
            page.Controls.Add(content);
            content.Controls.AddRange(existing);

            foreach (Control control in existing)
                Field(control);

            return content;
        }

        internal static void FitPage(UserControl page, Panel content, int minimumWidth,
            Func<int, int> minimumHeight)
        {
            int width = Math.Max(Px(page, minimumWidth), page.Width);
            int height = Px(page, minimumHeight(width));
            if (height > page.Height || width > page.Width)
            {
                width = Math.Max(Px(page, minimumWidth), page.Width - SystemInformation.VerticalScrollBarWidth);
                height = Px(page, minimumHeight(width));
            }

            int viewportHeight = page.Height - (width > page.Width ? SystemInformation.HorizontalScrollBarHeight : 0);
            content.Size = new Size(width, Math.Max(viewportHeight, height));
            page.AutoScrollMinSize = content.Size;
            page.PerformLayout();
        }

        internal static void Grid(Guna2DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Line;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersHeight = Px(grid, 42);
            grid.RowTemplate.Height = Px(grid, 38);
            grid.ColumnHeadersDefaultCellStyle.Font = Caption;
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(Px(grid, 8), 0, Px(grid, 4), 0);
            grid.ColumnHeadersDefaultCellStyle.BackColor = NavyLight;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = NavyLight;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Font = Body;
            grid.DefaultCellStyle.Padding = new Padding(Px(grid, 8), 0, Px(grid, 4), 0);
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = Ink;
            grid.DefaultCellStyle.SelectionBackColor = Selected;
            grid.DefaultCellStyle.SelectionForeColor = Ink;
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Canvas };
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DataBindingComplete += (sender, args) =>
            {
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    var header = Header(column.DataPropertyName);
                    if (header != null)
                        column.HeaderText = header;

                    column.MinimumWidth = Math.Max(Px(grid, 70),
                        TextRenderer.MeasureText(column.HeaderText, Caption).Width + Px(grid, 30));
                }
            };
        }

        private static string Header(string field)
        {
            switch (field.ToLowerInvariant())
            {
                case "roomid": return "Mã phòng";
                case "roomno": return "Số phòng";
                case "roomtype": return "Loại phòng";
                case "bed": return "Loại giường";
                case "price": return "Giá (VNĐ)";
                case "booked": return "Đã đặt";
                case "cid": return "Mã khách";
                case "cname": return "Tên khách";
                case "mobile": return "Điện thoại";
                case "nationality": return "Quốc tịch";
                case "gender": return "Giới tính";
                case "dob": return "Ngày sinh";
                case "idproof": return "Giấy tờ";
                case "address": return "Địa chỉ";
                case "checkin": return "Ngày nhận phòng";
                case "checkout": return "Ngày trả phòng";
                case "eid": return "Mã nhân viên";
                case "ename": return "Họ và tên";
                case "emailid":
                case "email": return "Email";
                case "username": return "Tên đăng nhập";
                default: return null;
            }
        }
    }
}
