using PluginsAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearCore.Optimize
{
    public class OptimizeManager
    {
        public OptimizeForm form;
        public OptimizeManager(OptimizeForm form)
        {
            this.form = form;
            PluginClient.OnPluginPostObject += OnPluginPost;
            PluginClient.PluginLoad(OptimizeDataBaseUpdater);
        }

        public void Optimize(OptimizeSettings optimizeSettings)
        {
            PluginClient client = new PluginClient(PluginUpdater);
            client.OnPluginPostObject += (o) =>
            {
                if (o.GetType() == typeof(string))
                {
                    string text = (string)o;
                    if (text == "LoadDone")
                    {
                        if (OptimizeDone != null)
                        {
                            OptimizeDone(optimizeSettings);
                        }
                        PluginClient.PluginUnLoad(optimizeSettings.Script);
                    }
                }
            };
            client.PluginLoad(optimizeSettings.Script);
            client.OnPluginLoad += () =>
            {
                client.PluginPostObject(optimizeSettings.Script, "Load");
            };

        }
        public void UnOptimize(OptimizeSettings optimizeSettings)
        {
            PluginClient client = new PluginClient(PluginUpdater);
            client.OnPluginPostObject += (o) =>
            {
                if (o.GetType() == typeof(string))
                {
                    string text = (string)o;
                    if (text == "LoadDone")
                    {
                        if (OptimizeDone != null)
                        {
                            OptimizeDone(optimizeSettings);
                        }
                        PluginClient.PluginUnLoad(optimizeSettings.Script);
                    }
                }
            };
            client.PluginLoad(optimizeSettings.Script);
            client.OnPluginLoad += () =>
            {
                client.PluginPostObject(optimizeSettings.Script, "UnLoad");
            };
        }
        public Action<OptimizeSettings> OptimizeDone;
        #region Работа с UI
        public List<CstBut> bts = new List<CstBut>();
        List<string> buttons_texts = new List<string>();
        public class CstBut
        {
            public string Type;
            public FlatUI.FlatCheckBox Switch;
            public Label label;
        }
        public void UpdateUI()
        {
            int offset = 0;
            foreach (CstBut butrem in bts)
            {
                form.Invoke(new Action(() => { form.Controls.Remove(butrem.Switch); }));
                form.Invoke(new Action(() => { form.Controls.Remove(butrem.label); }));
            }
            bts.Clear();
            buttons_texts.Clear();
            foreach (OptimizeSettings st in DataBase)
            {
                if (!buttons_texts.Contains(st.Type))
                {
                    buttons_texts.Add(st.Type);
                }
            }
            foreach (string cst2 in buttons_texts)
            {
                FlatUI.FlatCheckBox guna2 = new FlatUI.FlatCheckBox();
                guna2.Location = new Point(15, 27 + offset);
                guna2.Size = new Size(30, 20);
                Label text = new Label();
                text.AutoSize = true;
                text.Text = cst2;
                guna2.BackColor = Color.FromArgb(45, 47, 49);
                guna2.BaseColor = Color.FromArgb(60, 70, 73);
                text.BackColor = Color.FromArgb(45, 47, 49);
                text.ForeColor = Color.White;
                text.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                text.Location = new Point(35, 29 + offset);
                offset += 22;
                CstBut ct = new CstBut();
                ct.Type = cst2;
                ct.Switch = guna2;
                ct.label = text;
                bts.Add(ct);
                form.Invoke(new Action(() => { form.Controls.Add(text); }));
                form.Invoke(new Action(() => { form.Controls.Add(guna2); }));
            }
            form.Invoke(new Action(() => { form.button1.Location = new Point(form.button1.Location.X, 35 + offset); }));
            form.Invoke(new Action(() => { form.button1.Visible = true; }));
        }
        #endregion
        #region Работа с Базой Данных
        public void LoadCustom(Plugin plugin)
        {
            OptimizeDataBaseUpdater = plugin;
            PluginClient.PluginLoad(OptimizeDataBaseUpdater);
        }

        public static readonly string OptimizeURL = "https://ztreh.ru/Hds/Optimize/OptimizeUpdater.cs";
        public Plugin OptimizeDataBaseUpdater = new WebScript(OptimizeURL);

        private static PluginUpdater PluginUpdater = new PluginUpdater();
        private PluginClient PluginClient = new PluginClient(PluginUpdater);

        public Action OnLoadDone = null;

        public readonly List<OptimizeSettings> DataBase = new List<OptimizeSettings>();

        private void OnPluginPost(object obj)
        {
            if (obj.GetType() == typeof(OptimizeSettings))
            {
                OptimizeSettings settings = (OptimizeSettings)obj;
                DataBase.Add(settings);
            }
            else if (obj.GetType() == typeof(string))
            {
                string text = (string)obj;
                if (text == "LoadDone")
                {
                    PluginClient.PluginUnLoad(this.OptimizeDataBaseUpdater);
                    if (OnLoadDone != null)
                    {
                        OnLoadDone();
                    }
                }
            }
        }
        public List<OptimizeSettings> GetByType(string Type)
        {
            List<OptimizeSettings> temp = new List<OptimizeSettings>();
            foreach (OptimizeSettings cl in DataBase)
            {
                if (cl.Type == Type)
                {
                    temp.Add(cl);
                }
            }
            return temp;
        }
        #endregion
    }
}
