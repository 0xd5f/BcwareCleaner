//using Shell32;
//using System.Runtime.InteropServices;
//using ClearCore.Cleaner;

MCC.LoadPlugin(new CleanerDataBaseUpdater());

//Script Extensions
 
public class CleanerDataBaseUpdater : Plugin
{
	public void GetDataBase()
	{
		/* Логи | Logs */
		PluginPostObject(new CleanerSettings(@"%internetcache%", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\dumps", "*.dmp", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Cache", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\CrashReportClient\Saved\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\SquirrelTemp", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\C:\Users\Herob\Searches", "*.*", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Xamarin\Logs\16.0", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Xamarin\Logs\Xamarin.Simulator", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\LocalLow\Bennett Foddy\Getting Over It", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Sony\OFXPlugins", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\$SysReset\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\$SysReset\AppxLogs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\$Windows.~WS\Sources\Panther", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\debug", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\WinREAgent", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\WindowsUpdate", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\waasmediccapsule", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\waasmedic", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\SIH", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\NetSetup", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\MoSetup", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\DPX", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\DISM", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\CBS", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Logs\CBS", "*.cab", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Panther", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Panther", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Panther\UnattendGC", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Performance\WinSAT", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\Performance\WinSAT\DataStore", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\prefetch", "*.*", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\security\logs", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\security\logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\security\logs", "*.old", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\security\database", "*.old", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\ServiceProfiles\LocalService\AppData\Local\Temp", "*.*", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\SoftwareDistribution", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\temp", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\System32\Logs", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Progress\Installer\Logs", "*.log", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\temp", "*.*", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Temp", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Microsoft\Windows\History", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\SoftwareDistribution", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Windows\SoftwareDistribution\DataStore\Logs", "*.log", "Files", "Логи"));
		    /* DriverPack */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\DRPSu\temp", "*.log", "Files", "Логи"));    
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\DRPSu\temp", "*.txt", "Files", "Логи"));   
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\DRPSu\Logs", "*.html", "Files", "Логи"));   
			/* Spotify */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Spotify\Browser\Local Storage\leveldb", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Spotify\Browser\Session Storage", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Spotify\Browser", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Spotify\public.ldb", "*.log", "Files", "Логи"));
			/* Chrome */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Google\Chrome\Application", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Google\Picasa2", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Google\GBScreensaver", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Google\Picasa3\licenses", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Google\Picasa3\cdautorun", "*.url", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Google\Picasa3\runtime", "*.html", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Google\Picasa3\runtime\geotag", "*.html", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Google\Picasa3\web", "*.*", "FullAll", "Логи"));
			/* TeamSpeek */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\TS3Client\logs", "*.log", "Files", "Логи"));	
		PluginPostObject(new CleanerSettings(@"C:\Program Files\TeamSpeak 3 Client", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\TeamSpeak 3 Client", "*.txt", "Files", "Логи"));
			/* Discord */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\VideoDecodeStats", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\Local Storage\leveldb", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Discord", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\module_data\discord_hook", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\Session Storage", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\VideoDecodeStats", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\Local Storage\leveldb", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\discord", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\discord\VideoDecodeStats", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\discord\discord\shared_proto_db\metadata", "*.log", "Files", "Логи"));
		/* WhatsApp */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\WhatsApp", "*.log", "Files", "Логи"));
			/* Riot Client */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Logs\Launcher", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Logs\Riot Client Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Logs\Riot Client UX Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Logs\RiotClient UX Renderer Logs", "*.log", "Files", "Логи"));
			/* Epic Games */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Epic Games\EOSOverlay\BrowserCache", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Epic Games\EOSOverlay", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\EpicGamesLauncher\Saved\Logs", "*.log", "Files", "Логи"));
			/* Faceit */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\FACEIT", "*.log", "Files", "Логи"));
			/* BlueStacks */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Bluestacks", "*.log", "Files", "Логи"));
			/* USOShared */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\USOShared\Logs\System", "*.etl", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\USOShared\Logs\User", "*.etl", "Files", "Логи"));
			/* Steam */
		PluginPostObject(new CleanerSettings(@"%steam%", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\logs", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Lords Mobile", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Tanki Online", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\GarrysMod", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Warface\0_1177\LogBackups", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Warface\GameCenter", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Among Us", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Unturned\Log", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Half-Life", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Half-Life 2", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Rust", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Rust", "*.txt", "Files", "Логи"));
		
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\VideoDecodeStats", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\VideoDecodeStats", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\shared_proto_db", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\shared_proto_db\metadata", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\shared_proto_db\metadata", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\Session Storage", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\Session Storage", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\Local Storage\leveldb", "*LOG*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache\Local Storage\leveldb", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\htmlcache", "*.tmp", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\widevine\win-ia32", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Steam\widevine\win-x64", "*.txt", "Files", "Логи"));
			/* Steam игры | Steam Games */
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\GarrysMod", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Half-Life", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Half-Life 2", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Among Us", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Warface\GameCenter", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Warface\0_1177\LogBackups", "*.log", "Files", "Логи"));
		    /* Furios */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\furios-launcher", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\furios-launcher\app-1.0.0", "*.log", "Files", "Логи"));
			/* DyingLight */
		PluginPostObject(new CleanerSettings(@"%user%\Documents\DyingLight\out\logs", "*.log", "Files", "Логи"));
			/* TeamViewer */
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\TeamViewer", "*.log", "Files", "Логи"));
			/* Genshin Impact */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Genshin Impact\logs", "*.log", "Files", "Логи"));
			/* NDIDIA */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\NVIDIA Corporation\GfnRuntimeSdk", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\NVIDIA", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\NVIDIA Corporation", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\NVIDIA Corporation\nvstapisvr", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\NVIDIA Corporation\nvStereoInstaller", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\\NVIDIA Corporation\NvFBCPlugin", "*.log", "Files", "Логи"));
			/* Razer */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Razer\Services\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Razer\RazerCortexManifestRepair\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C\\ProgramData\Razer\BigDataSDK\Logs", "*.log", "Files", "Логи"));
			/* System */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Progress\Installer\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\Microsoft\Windows\Recent", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Temp", "*.*", "All", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Microsoft\Windows\History", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local", "*.log", "Files", "Логи"));
			/* Minecraft */
		PluginPostObject(new CleanerSettings(@"%appdata%\.minecraft\logs", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\.minecraft", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\.minecraft", "*log*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\.vimeworld\minigames\logs", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.cristalix\launcher.log", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.cristalix\updates\Minigames\logs", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Olympus\logs", "*.*", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Olympus", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Olympus\HiTech\liteconfig", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Olympus\HiTech\journeymap", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\logs\launcher", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\offline\files\1.7\logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\offline\1.7\logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\offline\1.8\logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\offline\1.8\logs", "*.gz", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\offline\1.7\logs", "*.gz", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Programs\lunarclient", "*.html", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Programs\lunarclient", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\BadlionClient\jre", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%appdata%\.pvplounge\logs", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\PvPLounge Launcher", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\PvPLounge Launcher", "*.txt", "html", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\curseforge\minecraft\Install", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\curseforge\minecraft\Install\webcache2", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\.tlauncher\logs", "*.log", "Files", "Логи"));
			/* AnyDesk */
		PluginPostObject(new CleanerSettings(@"%appdata%\AnyDesk\chat", "*.*", "Files", "Логи"));
			/* ShareX */
		PluginPostObject(new CleanerSettings(@"%mydocs%\ShareX\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%mydocs%\ShareX\Logs", "*.txt", "Files", "Логи"));
			/* Overwolf */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Overwolf\BrowserCache", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Overwolf", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Overwolf\Log", "*.*", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Overwolf", "*.InstallLog", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Overwolf\temp", "*.txt", "Files", "Логи"));
			/* NEXTRP */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\NEXTRP Launcher", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\NEXTRP Launcher", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\NEXTRP Launcher", "*.html", "Files", "Логи"));
			/* Notepad++ */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Notepad++", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Notepad++\updater", "*.md", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Notepad++\updater", "LICENSE", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Notepad++", "LICENSE", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Notepad++", "*.txt", "Files", "Логи"));
			/* VPN Gate */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\SoftEther VPN Client\client_log", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\SoftEther VPN Client\security_log\VPNGATE", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\SoftEther VPN Client\server_log", "*.log", "Files", "Логи"));
			/* Serious Sam 3 BFE Gold Edition */
		PluginPostObject(new CleanerSettings(@"C:\Games\Serious Sam 3 BFE Gold Edition\Log", "*.log", "Files", "Логи"));
			/* Slime Rancher */
		PluginPostObject(new CleanerSettings(@"C:\GOG Games\Slime Rancher\SRMP", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\LocalLow\Monomi Park\Slime Rancher", "*.log", "FullAll", "Логи"));
			/* NEKOPARA - Catboys Paradise */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\LocalLow\NEKO WORKs\NEKOPARA - Catboys Paradise", "*.log", "FullAll", "Логи"));
			/* Raft */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\LocalLow\Redbeet Interactive\Raft", "*.log", "FullAll", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%", ".wakatime.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\plastic4\logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Unity", "*.log", "Files", "Логи"));
			/* uTorrent */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\BitTorrentHelper", "*.log", "Files", "Логи"));
			/* OBS Studio */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\obs-studio\logs", "*.txt", "Files", "Логи"));
			/* Opera */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\Opera Software\Opera GX Stable", "*.log", "Files", "Логи"));
			/* Telegram */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\Telegram Desktop", "*.txt", "Files", "Логи"));
			/* EasyAntiCheat */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\EasyAntiCheat\1", "*.log", "Files", "Логи"));
			/* Unity Hub */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\UnityHub", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Unity Hub", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Unity Hub\resources", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Unity Hub", "*.html", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Unity Hub\resources", "*.html", "Files", "Логи"));
			/* Avast */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Avast Software\Persistent Data\Avast\Logs", "*.*", "FullAll", "Логи"));
			/* OSU */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\\osu!\Logs", "*.log", "Files", "Логи"));
			/* Radmin VPN */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Famatech\Radmin VPN", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Radmin VPN", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Radmin VPN\CHATLOGS", "*.txt", "Files", "Логи"));
			/* Epic Game Launcher */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Epic\EpicOnlineServices\MainService\Logs", "*.log", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Epic Games\UnrealTournament", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Epic Games\UnrealTournament\WindowsServer", "*.txt", "Files", "Логи"));
			/* Sumlime Text */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Sublime Text", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Programs\Opera GX", "*.old", "Files", "Логи"));
			/* Azure */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Microsoft SDKs\Azure\Emulator", "License.rtf", "Files", "Логи"));
			/* Mem Reduct */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Mem Reduct", "*.sig", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\Mem Reduct", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\IIS Express", "*.txt", "Files", "Логи"));
			/* ProtonVPN*/
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Proton Technologies\ProtonVPN", "COPYING.md", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files (x86)\Proton Technologies\ProtonVPN", "LICENSE", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\ProtonVPN\Logs", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\ProtonVPN\DiagnosticLogs", "*.7z", "Files", "Логи"));
			/* Java */
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Oracle\Java\.oracle_jre_usage", "*.timestamp", "FullAll", "Логи"));
			/* CCleaner */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\CCleaner\LOG", "*.timestamp", "FullAll", "Логи"));
			/* WinRAR */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\WinRAR", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"C:\Program Files\WinRAR", "*.htm", "Files", "Логи"));
			/* 7-Zip */
		PluginPostObject(new CleanerSettings(@"C:\Program Files\7-Zip", "*.txt", "Files", "Логи"));
			/* PlariumPlay */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Plarium\PlariumPlay", "*.txt", "Files", "Логи"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Plarium\PlariumPlay\StandAloneApps\raid\244", "*.txt", "Files", "Логи"));
		
		/* Бэкапы | Backups */
		PluginPostObject(new CleanerSettings(@"%mydocs%\ShareX\Backup", "*.json", "Files", "Бэкапы"));
	
		/* Кеш | Cache */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\dnSpy", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Microsoft\Windows\INetCache\IE", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%appdata%\discord\Code Cache", "*.*", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Package Cache", "*.*", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\.cristalix\updates\Minigames\caches", "*.*", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%appdata%\.minecraft\tv-cache", "*.*", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\game-cache\blog-post-images", "*.log", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\GeometryDash", "*.mp3", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Oracle\Java\installcache", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Oracle\Java\installcache_x64", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\game-cache", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\.lunarclient\launcher-cache", "*.txt", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%steam%\appcache\httpcache", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%steam%\appcache\librarycache", "*.*", "FullAll", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%steam%\depotcache", "*.manifest", "Files", "Кеш"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\uTorrent", "*.torrent", "Files", "Кеш"));
		    /* Discord */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\Cache", "*.*", "Files", "Кеш"));
		    /* Opera GX */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\Opera Software\Opera GX Stable", "*.tmp", "Files", "Логи"));
		    /* Steam */
		PluginPostObject(new CleanerSettings(@"%steam%\appcache\stats", "*.bin", "Files", "Кеш"));
		    /* Atom */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\Atom\Cache", "*.*", "Files", "Кеш"));
	
		/* Скриншоты | ScreenShots */
		PluginPostObject(new CleanerSettings(@"%appdata%\.minecraft\screenshots", "*.*", "Files", "Скриншоты"));
		PluginPostObject(new CleanerSettings(@"%mydocs%\ShareX\Screenshots", "*.*", "FullAll", "Скриншоты"));
		PluginPostObject(new CleanerSettings(@"%mydocs%\Lightshot", "*.*", "Files", "Скриншоты"));
		PluginPostObject(new CleanerSettings(@"С:\Fraps\Screenshots", "*.*", "Files", "Скриншоты"));
		PluginPostObject(new CleanerSettings(@"%user%\Pictures\Screenshots", "*.*", "Files", "Скриншоты"));
	
		/* Видео | Videos */
		PluginPostObject(new CleanerSettings(@"%mydocs%\Bandicam", "*.*", "Files", "Видео"));
	
		/* Краши | Crashes */
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\CrashDumps", "*.dmp", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive", "*.mdmp", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\GarrysMod", "*.mdmp", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\GarrysMod\crashes", "*.mdmp", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Crashes\Riot Client", "*.lock", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Crashes\RiotClientUx", "*.lock", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Local\Riot Games\Riot Client\Crashes\RiotClientUxHelper", "*.lock", "Files", "Краши"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\discord\Crashpad\reports", "*.dmp", "Files", "Краши"));
		
		/* Настройки читов | Cheat Settings */
		PluginPostObject(new CleanerSettings(@"%user\AppData\Roaming\Furios", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user\AppData\Local\furios-launcher", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\CS Changer", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\ExLoader", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive\ot", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive\nl", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\common\Counter-Strike Global Offensive\nix", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\nixware", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%mydocs%\Osiris", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%mydocs%\PPHUD V3", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\aoshax", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\rebornhack", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\YuQu", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\YuQu", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%appdata%\NOXIS", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\weave", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\FET Loader", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\INTERIUM", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\INVENTORY", "*.*", "FullAll", "Настройки читов"));
		PluginPostObject(new CleanerSettings(@"%user%\AppData\Roaming\FLauncher", "*.*", "FullAll", "Настройки читов"));
		
		/* Загрузки */
		PluginPostObject(new CleanerSettings(@"%user%\Downloads", "*.*", "FullAll", "Загруки"));

		/* Корзина */
		PluginPostObject(new CleanerSettings(@"%user%", "*.*", "RecycleBin", "Корзина"));

		/* Steam workshop */
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\workshop", "*.txt", "Files", "Steam workshop"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\workshop", "*.*", "FullAll", "Steam workshop"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\workshop", "*.log", "Files", "Steam workshop"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\workshop", "*.acf", "Files", "Steam workshop"));
		/* Steam downloading */
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\downloading", "*.patch", "Files", "Steam downloading"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\downloading", "*.delta", "Files", "Steam downloading"));
		PluginPostObject(new CleanerSettings(@"%steam%\steamapps\downloading", "*.*", "FullAll", "Steam downloading"));

		/* Senet Enestech*/
		PluginPostObject(new CleanerSettings(@"C:\ProgramData\Enestech\Cache\", " *.*", "FullAll", "Senet Enestech"));



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