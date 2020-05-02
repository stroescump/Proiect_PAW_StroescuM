using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PAW_StroescuM.Properties;

namespace Proiect_PAW_StroescuM.Helpers
{
    class HelperNightMode
    {
        public HelperNightMode() { }

        public void setNightMode(bool isNight, Form parent)
        {
            if (isNight)
            {
                Settings.Default.isNightMode = true;
                Settings.Default.Save();

                for (int i = 0; i < parent.Controls.Count; i++)
                {
                    parent.Controls[i].BackColor = Color.FromArgb(parent.Controls[i].BackColor.ToArgb() ^ 0xffffff);
                    parent.Controls[i].ForeColor = Color.FromArgb(parent.Controls[i].ForeColor.ToArgb() ^ 0xffffff);
                }
                parent.BackColor = Color.FromArgb(parent.BackColor.ToArgb() ^ 0xffffff);
            }
            else
            {
                Settings.Default.isNightMode = false;
                Settings.Default.Save();

                for (int i = 0; i < parent.Controls.Count; i++)
                {
                    parent.Controls[i].BackColor = Color.FromArgb(parent.Controls[i].BackColor.ToArgb() ^ 0xffffff);
                    parent.Controls[i].ForeColor = Color.FromArgb(parent.Controls[i].ForeColor.ToArgb() ^ 0xffffff);
                }
                parent.BackColor = Color.FromArgb(parent.BackColor.ToArgb() ^ 0xffffff);
            }
        }

        public void setColorTheme(bool isNight, Form container)
        {
            if (isNight)
            {
                for (int i = 0; i < container.Controls.Count; i++)
                {
                    if (container.Controls[i] is Label && container.Controls[i].Name == "lb_nightMode")
                    {
                        container.Controls[i].Text = "**Pentru a reveni la modul de zi, apasa click dreapta pe formular";
                    }
                    container.Controls[i].ForeColor = Color.FromArgb(Color.DarkSlateGray.ToArgb() ^ 0xffffff);
                    container.Controls[i].BackColor = Color.FromArgb(Color.WhiteSmoke.ToArgb() ^ 0xffffff);
                }
                container.BackColor = Color.FromArgb(Color.WhiteSmoke.ToArgb() ^ 0xffffff);
            }
            else
            {
                for (int i = 0; i < container.Controls.Count; i++)
                {
                    if (container.Controls[i] is Label && container.Controls[i].Name == "lb_nightMode")
                    {
                        container.Controls[i].Text = "**Pentru a activa modul de noapte, apasa click dreapta pe formular";
                    }
                    container.Controls[i].ForeColor = Color.DarkSlateGray;
                    container.Controls[i].BackColor = Color.WhiteSmoke;
                }
                container.BackColor = Color.WhiteSmoke;
            }
        }
    }
}



