//using Shell32;
//using System.Runtime.InteropServices;
//using ClearCore.Optimize;

MCC.LoadPlugin(new CSGO());

//Script Extensions
 
public class CSGO : Plugin
{
	public void Optimize()
	{
        
		PluginPostObject("LoadDone");
	}
	public override void Initialize()
	{
		//Optimize();
	}
	public override void ReceivedObject(object s)
    {
        if (s.GetType() == typeof(string))
        {
            string text = (string)s;
            if (text == "Load")
            {
                Optimize();
            }
        }
	}
}

