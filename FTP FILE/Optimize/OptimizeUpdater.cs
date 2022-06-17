//using Shell32;
//using System.Runtime.InteropServices;
//using ClearCore.Optimize;

MCC.LoadPlugin(new OptimizeDataBaseUpdater());

//Script Extensions
 
public class OptimizeDataBaseUpdater : Plugin
{
	public void GetDataBase()
	{
		/* Логи | Logs */
		PluginPostObject(new OptimizeSettings("CS:GO", new WebScript("https://ztreh.ru/Hds/Optimize/Games/CSGO.cs")));
		PluginPostObject("LoadDone");
	}
	public override void Initialize()
	{
		GetDataBase();
	}
	public override void ReceivedObject(object s)
    {
        if (s.GetType() == typeof(string))
        {
            string text = (string)s;
            if (text == "GetDataBase")
            {
                GetDataBase();
            }
        }
	}
}
