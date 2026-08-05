using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AEOFBBCMILN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class KFJIILCCMHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF06D0", Offset = "0x5EEF4D0", VA = "0x185EF06D0")]
	private static void OCNGPGEMBBE(HDGGKHDMMKE JLGAELGALHM, Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0750", Offset = "0x5EEF550", VA = "0x185EF0750")]
	public static bool OGLBEOFOPCP(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0410", Offset = "0x5EEF210", VA = "0x185EF0410")]
	public static ICAGGLILCHD JAAMFIIKOPM(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, string GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFEF0", Offset = "0x5EEECF0", VA = "0x185EEFEF0")]
	public static ICAGGLILCHD AOLPGINGBCN(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, int GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0030", Offset = "0x5EEEE30", VA = "0x185EF0030")]
	public static ICAGGLILCHD BCOHKEIMANL(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, bool GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0180", Offset = "0x5EEEF80", VA = "0x185EF0180")]
	public static ICAGGLILCHD DHLJMKNPHFA(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, float GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0560", Offset = "0x5EEF360", VA = "0x185EF0560")]
	public static ICAGGLILCHD OCIMLOILHHK(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, DateTime GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EF02D0", Offset = "0x5EEF0D0", VA = "0x185EF02D0")]
	public static ICAGGLILCHD GJOCJKHFIHC(this HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, long GNLEHBFFNFG, [Optional] Action<HDGGKHDMMKE> JDCMDNNNKIE)
	{
		return default(ICAGGLILCHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AAOBGOPMJHO : HAHFFCEOAOM, HDGGKHDMMKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Dictionary<string, byte> AMLGAMPHFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Dictionary<string, string> CFOFAPIPCPL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> LPBKJDEAAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA990", Offset = "0x5EE9790", VA = "0x185EEA990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC330", Offset = "0x5EEB130", VA = "0x185EEC330")]
	[Preserve]
	public AAOBGOPMJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB400", Offset = "0x5EEA200", VA = "0x185EEB400")]
	private DirectoryInfo DDHHKMFJMID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBF80", Offset = "0x5EEAD80", VA = "0x185EEBF80", Slot = "6")]
	public Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB5B0", Offset = "0x5EEA3B0", VA = "0x185EEB5B0", Slot = "14")]
	public float EDDKGENCIHH(string JLDFGFPAIIN, float HEDIGKLLBHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC150", Offset = "0x5EEAF50", VA = "0x185EEC150", Slot = "13")]
	public void LFFNGFECCKB(string JLDFGFPAIIN, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC010", Offset = "0x5EEAE10", VA = "0x185EEC010", Slot = "12")]
	public bool JCMHPHGFBLK(string JLDFGFPAIIN, bool HEDIGKLLBHN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA9D0", Offset = "0x5EE97D0", VA = "0x185EEA9D0", Slot = "10")]
	public int AOEDAMLDOKJ(string JLDFGFPAIIN, int HEDIGKLLBHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC2C0", Offset = "0x5EEB0C0", VA = "0x185EEC2C0", Slot = "18")]
	public DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB540", Offset = "0x5EEA340", VA = "0x185EEB540", Slot = "19")]
	public void DINNGLFOGKL(string JLDFGFPAIIN, DateTime GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB960", Offset = "0x5EEA760", VA = "0x185EEB960", Slot = "15")]
	public void GFGNFFCFEHF(string JLDFGFPAIIN, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB4D0", Offset = "0x5EEA2D0", VA = "0x185EEB4D0", Slot = "11")]
	public void DGGNENFJEJB(string JLDFGFPAIIN, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC0E0", Offset = "0x5EEAEE0", VA = "0x185EEC0E0", Slot = "20")]
	public long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBA80", Offset = "0x5EEA880", VA = "0x185EEBA80", Slot = "21")]
	public void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x216FDE0", Offset = "0x216EBE0", VA = "0x18216FDE0", Slot = "22")]
	public T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x216EE00", Offset = "0x216DC00", VA = "0x18216EE00", Slot = "23")]
	public void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB9D0", Offset = "0x5EEA7D0", VA = "0x185EEB9D0", Slot = "16")]
	public string HCCLJPNDNIH(string JLDFGFPAIIN, string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC1C0", Offset = "0x5EEAFC0", VA = "0x185EEC1C0", Slot = "17")]
	public void LGCJINENJPF(string JLDFGFPAIIN, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA8D0", Offset = "0x5EE96D0", VA = "0x185EEA8D0", Slot = "24")]
	public void AIKGFHPMOFF(string JLDFGFPAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC230", Offset = "0x5EEB030", VA = "0x185EEC230", Slot = "9")]
	public bool LNEABFCIKJK(string JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB620", Offset = "0x5EEA420", VA = "0x185EEB620", Slot = "25")]
	public Task ELKJDPIKNGA(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBAF0", Offset = "0x5EEA8F0", VA = "0x185EEBAF0")]
	private void HLEOPGAFEFC(DirectoryInfo OFBFPNPPHLA, string NJNACDNMIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAA40", Offset = "0x5EE9840", VA = "0x185EEAA40")]
	private static string CAPGPODFPOC(string JLDFGFPAIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE80", Offset = "0x5EEAC80", VA = "0x185EEBE80")]
	private static string HOHHKGBCHCB(byte[] AFIEJCAINEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29AA620", Offset = "0x29A9420", VA = "0x1829AA620")]
	private T OMJIHOMPBMI<T>(string COPMFEAGFCB, T HEDIGKLLBHN, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29A9660", Offset = "0x29A8460", VA = "0x1829A9660")]
	private void KLJMIKDFPBF<T>(string COPMFEAGFCB, T GNLEHBFFNFG, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAC40", Offset = "0x5EE9A40", VA = "0x185EEAC40")]
	private Dictionary<string, string> DCJBJNJIFIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class LBFPKFFIHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0920", Offset = "0x5EEF720", VA = "0x185EF0920")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void NHJLANHPGEE(OILPPPCALMB NFDHIFFHPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LHHKNEIHDED : BEDOJPOLJCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EECBF0", Offset = "0x5EEB9F0", VA = "0x185EECBF0")]
	[Preserve]
	public LHHKNEIHDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BEDOJPOLJCJ : HAHFFCEOAOM, HDGGKHDMMKE, LGMGJKDFJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<string, object> KFEJDOKOONF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC920", Offset = "0x5EEB720", VA = "0x185EEC920", Slot = "6")]
	public Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EECB30", Offset = "0x5EEB930", VA = "0x185EECB30", Slot = "9")]
	public bool LNEABFCIKJK(string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC5F0", Offset = "0x5EEB3F0", VA = "0x185EEC5F0", Slot = "10")]
	public int AOEDAMLDOKJ(string COPMFEAGFCB, int HEDIGKLLBHN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC650", Offset = "0x5EEB450", VA = "0x185EEC650", Slot = "11")]
	public void DGGNENFJEJB(string COPMFEAGFCB, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC9B0", Offset = "0x5EEB7B0", VA = "0x185EEC9B0", Slot = "12")]
	public bool JCMHPHGFBLK(string COPMFEAGFCB, bool HEDIGKLLBHN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EECA70", Offset = "0x5EEB870", VA = "0x185EECA70", Slot = "13")]
	public void LFFNGFECCKB(string COPMFEAGFCB, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC710", Offset = "0x5EEB510", VA = "0x185EEC710", Slot = "14")]
	public float EDDKGENCIHH(string COPMFEAGFCB, float HEDIGKLLBHN = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC800", Offset = "0x5EEB600", VA = "0x185EEC800", Slot = "15")]
	public void GFGNFFCFEHF(string COPMFEAGFCB, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC860", Offset = "0x5EEB660", VA = "0x185EEC860", Slot = "16")]
	public string HCCLJPNDNIH(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EECAD0", Offset = "0x5EEB8D0", VA = "0x185EECAD0", Slot = "17")]
	public void LGCJINENJPF(string COPMFEAGFCB, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EECB90", Offset = "0x5EEB990", VA = "0x185EECB90", Slot = "18")]
	public DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC6B0", Offset = "0x5EEB4B0", VA = "0x185EEC6B0", Slot = "19")]
	public void DINNGLFOGKL(string COPMFEAGFCB, DateTime GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EECA10", Offset = "0x5EEB810", VA = "0x185EECA10", Slot = "20")]
	public long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC8C0", Offset = "0x5EEB6C0", VA = "0x185EEC8C0", Slot = "21")]
	public void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x216BF70", Offset = "0x216AD70", VA = "0x18216BF70", Slot = "22")]
	public T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x216B9E0", Offset = "0x216A7E0", VA = "0x18216B9E0", Slot = "23")]
	public void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x216C070", Offset = "0x216AE70", VA = "0x18216C070")]
	public T OMJIHOMPBMI<T>(string COPMFEAGFCB, T HEDIGKLLBHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x216BA80", Offset = "0x216A880", VA = "0x18216BA80")]
	public void KLJMIKDFPBF<T>(string COPMFEAGFCB, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC590", Offset = "0x5EEB390", VA = "0x185EEC590", Slot = "24")]
	public void AIKGFHPMOFF(string COPMFEAGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC770", Offset = "0x5EEB570", VA = "0x185EEC770", Slot = "25")]
	public Task ELKJDPIKNGA(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5EECBF0", Offset = "0x5EEB9F0", VA = "0x185EECBF0")]
	public BEDOJPOLJCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class FMKADKIBPBD<TParent> where TParent : HDGGKHDMMKE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly HashSet<FMKADKIBPBD<TParent>> KGCMJNFAPFK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34073C0", Offset = "0x34061C0", VA = "0x1834073C0")]
	protected FMKADKIBPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void EOCKAINKMIG();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void HPBEDKEINJJ(string JLDFGFPAIIN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3406E10", Offset = "0x3405C10", VA = "0x183406E10")]
	public static void ADJFAIGGCGL(string JLDFGFPAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3407050", Offset = "0x3405E50", VA = "0x183407050")]
	public static void PFIOMBAEGFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JGAIEPCBEDE<TParent, TValue> : FMKADKIBPBD<TParent> where TParent : HDGGKHDMMKE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly JGAIEPCBEDE<TParent, TValue> BKEFLEENBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<string, TValue> HIGDHMFOGPJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38232D0", Offset = "0x38220D0", VA = "0x1838232D0")]
	public bool PGDPBMGNNCL(string IAHPBPDECDH, [Out] TValue GOGFPLCPNDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x38231D0", Offset = "0x3821FD0", VA = "0x1838231D0")]
	public void MPMCHOPHGOO(string IAHPBPDECDH, TValue GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3458130", Offset = "0x3456F30", VA = "0x183458130", Slot = "4")]
	protected override void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x38231A0", Offset = "0x3821FA0", VA = "0x1838231A0", Slot = "5")]
	protected override void HPBEDKEINJJ(string IAHPBPDECDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3823440", Offset = "0x3822240", VA = "0x183823440")]
	public JGAIEPCBEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HDGGKHDMMKE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLCGKMJPPOG();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNEABFCIKJK(string COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AOEDAMLDOKJ(string COPMFEAGFCB, int HEDIGKLLBHN = 0);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGGNENFJEJB(string COPMFEAGFCB, int GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JCMHPHGFBLK(string COPMFEAGFCB, bool HEDIGKLLBHN = false);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LFFNGFECCKB(string COPMFEAGFCB, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float EDDKGENCIHH(string COPMFEAGFCB, float HEDIGKLLBHN = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFGNFFCFEHF(string COPMFEAGFCB, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string HCCLJPNDNIH(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGCJINENJPF(string COPMFEAGFCB, string GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime NEHNDMEMBON);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DINNGLFOGKL(string COPMFEAGFCB, DateTime NEHNDMEMBON);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AIKGFHPMOFF(string COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task ELKJDPIKNGA([Optional] CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HAHFFCEOAOM : HDGGKHDMMKE
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HBCAGPOPKOA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGMGJKDFJBN : HDGGKHDMMKE
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JGHMCBGAGFN : HAHFFCEOAOM, HDGGKHDMMKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DJDCFJGFHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JGHMCBGAGFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDC30", Offset = "0x5EECA30", VA = "0x185EEDC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDDC0", Offset = "0x5EECBC0", VA = "0x185EEDDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EMNCDEECNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JGHMCBGAGFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDE20", Offset = "0x5EECC20", VA = "0x185EEDE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE110", Offset = "0x5EECF10", VA = "0x185EEE110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HAHFFCEOAOM INIACCKKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly AAOBGOPMJHO NGDKOLOKLMN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF390", Offset = "0x5EEE190", VA = "0x185EEF390", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFDA0", Offset = "0x5EEEBA0", VA = "0x185EEFDA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFD30", Offset = "0x5EEEB30", VA = "0x185EEFD30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFE00", Offset = "0x5EEEC00", VA = "0x185EEFE00")]
	[Preserve]
	public JGHMCBGAGFN(HAHFFCEOAOM INIACCKKJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFA00", Offset = "0x5EEE800", VA = "0x185EEFA00", Slot = "8")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFB40", Offset = "0x5EEE940", VA = "0x185EEFB40", Slot = "9")]
	public bool LNEABFCIKJK(string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEEA0", Offset = "0x5EEDCA0", VA = "0x185EEEEA0", Slot = "10")]
	public int AOEDAMLDOKJ(string COPMFEAGFCB, int HEDIGKLLBHN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEFF0", Offset = "0x5EEDDF0", VA = "0x185EEEFF0", Slot = "11")]
	public void DGGNENFJEJB(string COPMFEAGFCB, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF710", Offset = "0x5EEE510", VA = "0x185EEF710", Slot = "12")]
	public bool JCMHPHGFBLK(string COPMFEAGFCB, bool HEDIGKLLBHN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFA60", Offset = "0x5EEE860", VA = "0x185EEFA60", Slot = "13")]
	public void LFFNGFECCKB(string COPMFEAGFCB, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF0D0", Offset = "0x5EEDED0", VA = "0x185EEF0D0", Slot = "14")]
	public float EDDKGENCIHH(string COPMFEAGFCB, float HEDIGKLLBHN = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF320", Offset = "0x5EEE120", VA = "0x185EEF320", Slot = "15")]
	public void GFGNFFCFEHF(string COPMFEAGFCB, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF3F0", Offset = "0x5EEE1F0", VA = "0x185EEF3F0", Slot = "16")]
	public string HCCLJPNDNIH(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFAD0", Offset = "0x5EEE8D0", VA = "0x185EEFAD0", Slot = "17")]
	public void LGCJINENJPF(string COPMFEAGFCB, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFBD0", Offset = "0x5EEE9D0", VA = "0x185EEFBD0", Slot = "18")]
	public DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF060", Offset = "0x5EEDE60", VA = "0x185EEF060", Slot = "19")]
	public void DINNGLFOGKL(string COPMFEAGFCB, DateTime NEHNDMEMBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF8A0", Offset = "0x5EEE6A0", VA = "0x185EEF8A0", Slot = "20")]
	public long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF590", Offset = "0x5EEE390", VA = "0x185EEF590", Slot = "21")]
	public void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x23BEE00", Offset = "0x23BDC00", VA = "0x1823BEE00", Slot = "22")]
	public T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x23BED30", Offset = "0x23BDB30", VA = "0x1823BED30", Slot = "23")]
	public void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EEED90", Offset = "0x5EEDB90", VA = "0x185EEED90", Slot = "24")]
	public void AIKGFHPMOFF(string COPMFEAGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF230", Offset = "0x5EEE030", VA = "0x185EEF230", Slot = "25")]
	[AsyncStateMachine(typeof(DJDCFJGFHOD))]
	public Task ELKJDPIKNGA([Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF600", Offset = "0x5EEE400", VA = "0x185EEF600", Slot = "6")]
	[AsyncStateMachine(typeof(EMNCDEECNDO))]
	public Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IOFMMKGMLIP : HAHFFCEOAOM, HDGGKHDMMKE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MNIPEOKOGIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IOFMMKGMLIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0F20", Offset = "0x5EEFD20", VA = "0x185EF0F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF12F0", Offset = "0x5EF00F0", VA = "0x185EF12F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DFDKLHGKAHL : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IOFMMKGMLIP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public DFDKLHGKAHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDB70", Offset = "0x5EEC970", VA = "0x185EEDB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDBE0", Offset = "0x5EEC9E0", VA = "0x185EEDBE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool LPKCONCFGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool GJOKBIBBFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KLFFABBGDHC HOEEDMFCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private FFHNDEGIGAM KEHEALGLNJL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE780", Offset = "0x5EED580", VA = "0x185EEE780")]
	[Preserve]
	public IOFMMKGMLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE540", Offset = "0x5EED340", VA = "0x185EEE540", Slot = "6")]
	public Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x50B7910", Offset = "0x50B6710", VA = "0x1850B7910")]
	private static int FHHIPJIMDOH(bool GNLEHBFFNFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE690", Offset = "0x5EED490", VA = "0x185EEE690", Slot = "9")]
	public bool LNEABFCIKJK(string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1FED1D0", Offset = "0x1FEBFD0", VA = "0x181FED1D0", Slot = "10")]
	public int AOEDAMLDOKJ(string COPMFEAGFCB, int HEDIGKLLBHN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FED250", Offset = "0x1FEC050", VA = "0x181FED250", Slot = "11")]
	public void DGGNENFJEJB(string COPMFEAGFCB, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE5D0", Offset = "0x5EED3D0", VA = "0x185EEE5D0", Slot = "12")]
	public bool JCMHPHGFBLK(string COPMFEAGFCB, bool HEDIGKLLBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE660", Offset = "0x5EED460", VA = "0x185EEE660", Slot = "13")]
	public void LFFNGFECCKB(string COPMFEAGFCB, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE2B0", Offset = "0x5EED0B0", VA = "0x185EEE2B0", Slot = "14")]
	public float EDDKGENCIHH(string COPMFEAGFCB, float HEDIGKLLBHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE420", Offset = "0x5EED220", VA = "0x185EEE420", Slot = "15")]
	public void GFGNFFCFEHF(string COPMFEAGFCB, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE430", Offset = "0x5EED230", VA = "0x185EEE430", Slot = "16")]
	public string HCCLJPNDNIH(string COPMFEAGFCB, string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE670", Offset = "0x5EED470", VA = "0x185EEE670", Slot = "17")]
	public void LGCJINENJPF(string COPMFEAGFCB, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE6A0", Offset = "0x5EED4A0", VA = "0x185EEE6A0", Slot = "18")]
	public DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE240", Offset = "0x5EED040", VA = "0x185EEE240", Slot = "19")]
	public void DINNGLFOGKL(string COPMFEAGFCB, DateTime NEHNDMEMBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE5F0", Offset = "0x5EED3F0", VA = "0x185EEE5F0", Slot = "20")]
	public long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE4D0", Offset = "0x5EED2D0", VA = "0x185EEE4D0", Slot = "21")]
	public void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x216FDE0", Offset = "0x216EBE0", VA = "0x18216FDE0", Slot = "22")]
	public T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x216EE00", Offset = "0x216DC00", VA = "0x18216EE00", Slot = "23")]
	public void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23AA770", Offset = "0x23A9570", VA = "0x1823AA770")]
	private T LALDMAMDPOA<T>(string COPMFEAGFCB, T HEDIGKLLBHN, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x23A9F60", Offset = "0x23A8D60", VA = "0x1823A9F60")]
	private void KAOKIECICFB<T>(string COPMFEAGFCB, T GNLEHBFFNFG, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE170", Offset = "0x5EECF70", VA = "0x185EEE170", Slot = "24")]
	public void AIKGFHPMOFF(string COPMFEAGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE330", Offset = "0x5EED130", VA = "0x185EEE330", Slot = "25")]
	[AsyncStateMachine(typeof(MNIPEOKOGIM))]
	public Task ELKJDPIKNGA(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE450", Offset = "0x5EED250", VA = "0x185EEE450")]
	[IteratorStateMachine(typeof(DFDKLHGKAHL))]
	private IEnumerator<CCMEGKBIKJP> HDLMJHPFBOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE1E0", Offset = "0x5EECFE0", VA = "0x185EEE1E0")]
	private void CLFKABNNDNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE710", Offset = "0x5EED510", VA = "0x185EEE710")]
	private void OOJAICMCOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE2C0", Offset = "0x5EED0C0", VA = "0x185EEE2C0")]
	private void EJBGFLNMABA(bool HFBOANECIOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BJMIECCGADG : HAHFFCEOAOM, HDGGKHDMMKE
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Dictionary<string, string> CFOFAPIPCPL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string LKLLBCAGKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EECDF0", Offset = "0x5EEBBF0", VA = "0x185EECDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> LPBKJDEAAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EECD40", Offset = "0x5EEBB40", VA = "0x185EECD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[Preserve]
	public BJMIECCGADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EED6B0", Offset = "0x5EEC4B0", VA = "0x185EED6B0", Slot = "6")]
	public Task JCINAEDAANG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EED240", Offset = "0x5EEC040", VA = "0x185EED240", Slot = "14")]
	public float EDDKGENCIHH(string JLDFGFPAIIN, float HEDIGKLLBHN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5EED880", Offset = "0x5EEC680", VA = "0x185EED880", Slot = "13")]
	public void LFFNGFECCKB(string JLDFGFPAIIN, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5EED740", Offset = "0x5EEC540", VA = "0x185EED740", Slot = "12")]
	public bool JCMHPHGFBLK(string JLDFGFPAIIN, bool HEDIGKLLBHN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5EECD80", Offset = "0x5EEBB80", VA = "0x185EECD80", Slot = "10")]
	public int AOEDAMLDOKJ(string JLDFGFPAIIN, int HEDIGKLLBHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDA20", Offset = "0x5EEC820", VA = "0x185EEDA20", Slot = "18")]
	public DateTime OHIELDPEOMH(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EED1D0", Offset = "0x5EEBFD0", VA = "0x185EED1D0", Slot = "19")]
	public void DINNGLFOGKL(string JLDFGFPAIIN, DateTime GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EED520", Offset = "0x5EEC320", VA = "0x185EED520", Slot = "15")]
	public void GFGNFFCFEHF(string JLDFGFPAIIN, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EED160", Offset = "0x5EEBF60", VA = "0x185EED160", Slot = "11")]
	public void DGGNENFJEJB(string JLDFGFPAIIN, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EED810", Offset = "0x5EEC610", VA = "0x185EED810", Slot = "20")]
	public long JFAEAKPBOIM(string COPMFEAGFCB, long HEDIGKLLBHN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EED640", Offset = "0x5EEC440", VA = "0x185EED640", Slot = "21")]
	public void HFIGPJBIBPD(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x216FDE0", Offset = "0x216EBE0", VA = "0x18216FDE0", Slot = "22")]
	public T LJBOHPAAHJO<T>(string COPMFEAGFCB, T HEDIGKLLBHN, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x216EE00", Offset = "0x216DC00", VA = "0x18216EE00", Slot = "23")]
	public void ABKJILIGCKP<T>(string COPMFEAGFCB, T GNLEHBFFNFG, ANNCCAEFEGH<T> HJFCKCFPHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EED590", Offset = "0x5EEC390", VA = "0x185EED590", Slot = "16")]
	public string HCCLJPNDNIH(string JLDFGFPAIIN, string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EED8F0", Offset = "0x5EEC6F0", VA = "0x185EED8F0", Slot = "17")]
	public void LGCJINENJPF(string JLDFGFPAIIN, string GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC80", Offset = "0x5EEBA80", VA = "0x185EECC80", Slot = "24")]
	public void AIKGFHPMOFF(string JLDFGFPAIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EED990", Offset = "0x5EEC790", VA = "0x185EED990", Slot = "9")]
	public bool LNEABFCIKJK(string JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EED2B0", Offset = "0x5EEC0B0", VA = "0x185EED2B0", Slot = "25")]
	public Task ELKJDPIKNGA(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x216FEF0", Offset = "0x216ECF0", VA = "0x18216FEF0")]
	private T OMJIHOMPBMI<T>(string COPMFEAGFCB, T HEDIGKLLBHN, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x216EEA0", Offset = "0x216DCA0", VA = "0x18216EEA0")]
	private void KLJMIKDFPBF<T>(string COPMFEAGFCB, T GNLEHBFFNFG, [Optional] ANNCCAEFEGH<T> KOGBNEPJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EECE60", Offset = "0x5EEBC60", VA = "0x185EECE60")]
	private Dictionary<string, string> DCJBJNJIFIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AABBEAPGIEF
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HBCAGPOPKOA;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLCGKMJPPOG();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CLEJLMLLDOA(long EIAPBBMGFKP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CABHDAFILAN(AEOFBBCMILN PODOLCJAOCJ = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CGILOMMEGHJ(string COPMFEAGFCB, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GEGOBNKMJDO(string COPMFEAGFCB, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string LNNOGAAEPGG(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICAGGLILCHD KJPGPKKICAN(string COPMFEAGFCB, string GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int LONAHCDLFOD(string COPMFEAGFCB, int HEDIGKLLBHN = 0, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ICAGGLILCHD CGDGILLEKEC(string COPMFEAGFCB, int GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JMAPJMDJCBE(string COPMFEAGFCB, bool HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ICAGGLILCHD NKANALEJCLG(string COPMFEAGFCB, bool GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float KBHMOPMKKDP(string COPMFEAGFCB, float HEDIGKLLBHN = 0f, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ICAGGLILCHD LKNFDKBBDDF(string COPMFEAGFCB, float GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime FCEFOJEFBFP(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ICAGGLILCHD LALIGFPLIBG(string COPMFEAGFCB, DateTime GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long BLCDFIOLAJN(string COPMFEAGFCB, long HEDIGKLLBHN = 0L, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ICAGGLILCHD OPKBHALPJDG(string COPMFEAGFCB, long GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T BDAJACMFCPC<T>(string COPMFEAGFCB, [Optional] T HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	ICAGGLILCHD KCBJAKHMLDA<T>(string COPMFEAGFCB, T GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LAPMBMEFELC(string COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool BAHKMNIGPKD(string COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string HAFAILGFLFP(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ICAGGLILCHD JJCHOGHIKOA(string COPMFEAGFCB, string GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int JHNLJBLCIBN(string COPMFEAGFCB, int HEDIGKLLBHN = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	ICAGGLILCHD GHCDHMKINBC(string COPMFEAGFCB, int GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MPCGMBHFDFL(string COPMFEAGFCB, bool HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	ICAGGLILCHD AEDHGGFGBPA(string COPMFEAGFCB, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float HCDELDCIHKI(string COPMFEAGFCB, float HEDIGKLLBHN = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	ICAGGLILCHD NFKGMGHGDNB(string COPMFEAGFCB, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime OCMDDFBDFKN(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ICAGGLILCHD EFNEAELFBGK(string COPMFEAGFCB, DateTime GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long KDACCCEKPCK(string COPMFEAGFCB, long HEDIGKLLBHN = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ICAGGLILCHD MDALJGAMLKE(string COPMFEAGFCB, long GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void AJJHAEFLIKE<T>(ANNCCAEFEGH<T> HJFCKCFPHNO, [Optional] IEqualityComparer<T> KBMCPEOIHOH);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GGADOIGOPFH<T>();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable KJNCCLCFGIC();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FOPFEOBLOMD(float MILPBPEIAGI);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task CLFKABNNDNJ([Optional] CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum ICAGGLILCHD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	New,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NAMOBPBIBJA : AABBEAPGIEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class BADOKKJKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected static readonly HashSet<BADOKKJKOLA> KDFEEKHAFCL;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC3C0", Offset = "0x5EEB1C0", VA = "0x185EEC3C0")]
		public static void PFIOMBAEGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void EOCKAINKMIG();

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		protected BADOKKJKOLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class KGJNBHFOOJH<T> : BADOKKJKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly KGJNBHFOOJH<T> GOPCOAILBIE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ANNCCAEFEGH<T> NHHJCIIEHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> PJIDOOIKIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PPFGLGIBIMA
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x3013130", Offset = "0x3011F30", VA = "0x183013130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3895CC0", Offset = "0x3894AC0", VA = "0x183895CC0")]
		private KGJNBHFOOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3895920", Offset = "0x3894720", VA = "0x183895920")]
		public void MCJJKKHGDCC(ANNCCAEFEGH<T> KOGBNEPJFKP, [Optional] IEqualityComparer<T> KBMCPEOIHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38955F0", Offset = "0x38943F0", VA = "0x1838955F0", Slot = "4")]
		public override void EOCKAINKMIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class KIMMGHMNEIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly NAMOBPBIBJA CGNFIOACCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly object PDNHKDKBHLD;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0870", Offset = "0x5EEF670", VA = "0x185EF0870")]
		public KIMMGHMNEIJ(NAMOBPBIBJA CGNFIOACCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0840", Offset = "0x5EEF640", VA = "0x185EF0840", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct OPHCEHHOIDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NAMOBPBIBJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5140", Offset = "0x5EF3F40", VA = "0x185EF5140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5420", Offset = "0x5EF4220", VA = "0x185EF5420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NJPGOFGHKIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public NAMOBPBIBJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public HDGGKHDMMKE backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4FB0", Offset = "0x5EF3DB0", VA = "0x185EF4FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x841FE0", Offset = "0x840DE0", VA = "0x180841FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JEHGNCDJLGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NAMOBPBIBJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE860", Offset = "0x5EED660", VA = "0x185EEE860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5EEED30", Offset = "0x5EEDB30", VA = "0x185EEED30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DEMONBNFEEP : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NAMOBPBIBJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public DEMONBNFEEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDA90", Offset = "0x5EEC890", VA = "0x185EEDA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDB20", Offset = "0x5EEC920", VA = "0x185EEDB20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HAHFFCEOAOM AAENDCDILNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HAHFFCEOAOM NKCINMPFNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LGMGJKDFJBN FEOEMANKPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly KLFFABBGDHC HOEEDMFCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IBKPFCNCMON FBDDAPCOKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<HDGGKHDMMKE> FBKOIPALFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Task POBGJGOGGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FFHNDEGIGAM LGCOJCICOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly object ADLNDMDEKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly object MBFAEBIPFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private long AKJEFNACNCG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool KOGAPJPMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xB60DD0", Offset = "0xB5FBD0", VA = "0x180B60DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource KOMCBKABGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76B170", Offset = "0x769F70", VA = "0x18076B170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HBCAGPOPKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4CB0", Offset = "0x5EF3AB0", VA = "0x185EF4CB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4930", Offset = "0x5EF3730", VA = "0x185EF4930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3E40", Offset = "0x5EF2C40", VA = "0x185EF3E40")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void LPIADHCPHKP(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4D50", Offset = "0x5EF3B50", VA = "0x185EF4D50")]
	[Preserve]
	public NAMOBPBIBJA([NMBHAKGIBHG("Disk")] HAHFFCEOAOM AAENDCDILNK, [NMBHAKGIBHG("Cloud")] HAHFFCEOAOM NKCINMPFNFO, [NMBHAKGIBHG(null)] LGMGJKDFJBN FEOEMANKPPG, [NMBHAKGIBHG(null)] KLFFABBGDHC HOEEDMFCBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1DD0", Offset = "0x5EF0BD0", VA = "0x185EF1DD0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8A0", Offset = "0x5D2D6A0", VA = "0x185D2E8A0")]
	private void PKHNKCFBHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2B70", Offset = "0x5EF1970", VA = "0x185EF2B70", Slot = "6")]
	public void JLCGKMJPPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1B30", Offset = "0x5EF0930", VA = "0x185EF1B30", Slot = "7")]
	public Task CLEJLMLLDOA(long EIAPBBMGFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3F50", Offset = "0x5EF2D50", VA = "0x185EF3F50")]
	[AsyncStateMachine(typeof(OPHCEHHOIDL))]
	private Task NAFPADCGAHG(long EIAPBBMGFKP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x15934B0", Offset = "0x15922B0", VA = "0x1815934B0")]
	private void KDKMIIHDGND(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2830", Offset = "0x5EF1630", VA = "0x185EF2830")]
	private void HHBEMOIOHMD(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EF49D0", Offset = "0x5EF37D0", VA = "0x185EF49D0")]
	private string PFPBENECGJN(string HPEAADOHNLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2730", Offset = "0x5EF1530", VA = "0x185EF2730")]
	private void HFEEDHGOBHK(AEOFBBCMILN PODOLCJAOCJ, string JLDFGFPAIIN, [Out] HAHFFCEOAOM JLGAELGALHM, [Out] string NLFDCLNNCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4500", Offset = "0x5EF3300", VA = "0x185EF4500")]
	private HAHFFCEOAOM ODDENBDNKOJ(AEOFBBCMILN PODOLCJAOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EF16B0", Offset = "0x5EF04B0", VA = "0x185EF16B0", Slot = "8")]
	public bool CABHDAFILAN(AEOFBBCMILN PODOLCJAOCJ = AEOFBBCMILN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5EF19E0", Offset = "0x5EF07E0", VA = "0x185EF19E0", Slot = "9")]
	public bool CGILOMMEGHJ(string COPMFEAGFCB, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2280", Offset = "0x5EF1080", VA = "0x185EF2280", Slot = "10")]
	public bool GEGOBNKMJDO(string COPMFEAGFCB, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3B80", Offset = "0x5EF2980", VA = "0x185EF3B80", Slot = "11")]
	public string LNNOGAAEPGG(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2FF0", Offset = "0x5EF1DF0", VA = "0x185EF2FF0", Slot = "12")]
	public ICAGGLILCHD KJPGPKKICAN(string COPMFEAGFCB, string GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3CE0", Offset = "0x5EF2AE0", VA = "0x185EF3CE0", Slot = "13")]
	public int LONAHCDLFOD(string COPMFEAGFCB, int HEDIGKLLBHN = 0, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1770", Offset = "0x5EF0570", VA = "0x185EF1770", Slot = "14")]
	public ICAGGLILCHD CGDGILLEKEC(string COPMFEAGFCB, int GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2BE0", Offset = "0x5EF19E0", VA = "0x185EF2BE0", Slot = "15")]
	public bool JMAPJMDJCBE(string COPMFEAGFCB, bool HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4090", Offset = "0x5EF2E90", VA = "0x185EF4090", Slot = "16")]
	public ICAGGLILCHD NKANALEJCLG(string COPMFEAGFCB, bool GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2D40", Offset = "0x5EF1B40", VA = "0x185EF2D40", Slot = "17")]
	public float KBHMOPMKKDP(string COPMFEAGFCB, float HEDIGKLLBHN = 0f, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3900", Offset = "0x5EF2700", VA = "0x185EF3900", Slot = "18")]
	public ICAGGLILCHD LKNFDKBBDDF(string COPMFEAGFCB, float GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2110", Offset = "0x5EF0F10", VA = "0x185EF2110", Slot = "19")]
	public DateTime FCEFOJEFBFP(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3450", Offset = "0x5EF2250", VA = "0x185EF3450", Slot = "20")]
	public ICAGGLILCHD LALIGFPLIBG(string COPMFEAGFCB, DateTime GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1550", Offset = "0x5EF0350", VA = "0x185EF1550", Slot = "21")]
	public long BLCDFIOLAJN(string COPMFEAGFCB, long HEDIGKLLBHN = 0L, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF46C0", Offset = "0x5EF34C0", VA = "0x185EF46C0", Slot = "22")]
	public ICAGGLILCHD OPKBHALPJDG(string COPMFEAGFCB, long GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x24BA970", Offset = "0x24B9770", VA = "0x1824BA970", Slot = "23")]
	public T BDAJACMFCPC<T>(string COPMFEAGFCB, [Optional] T HEDIGKLLBHN, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x24BA970", Offset = "0x24B9770", VA = "0x1824BA970", Slot = "24")]
	public ICAGGLILCHD KCBJAKHMLDA<T>(string COPMFEAGFCB, T GNLEHBFFNFG, AEOFBBCMILN PCDDBDGMILK = AEOFBBCMILN.CLOUD)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3700", Offset = "0x5EF2500", VA = "0x185EF3700", Slot = "25")]
	public bool LAPMBMEFELC(string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1380", Offset = "0x5EF0180", VA = "0x185EF1380", Slot = "26")]
	public bool BAHKMNIGPKD(string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2650", Offset = "0x5EF1450", VA = "0x185EF2650", Slot = "27")]
	public string HAFAILGFLFP(string COPMFEAGFCB, [Optional] string HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2B40", Offset = "0x5EF1940", VA = "0x185EF2B40", Slot = "28")]
	public ICAGGLILCHD JJCHOGHIKOA(string COPMFEAGFCB, string GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2AD0", Offset = "0x5EF18D0", VA = "0x185EF2AD0", Slot = "29")]
	public int JHNLJBLCIBN(string COPMFEAGFCB, int HEDIGKLLBHN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2620", Offset = "0x5EF1420", VA = "0x185EF2620", Slot = "30")]
	public ICAGGLILCHD GHCDHMKINBC(string COPMFEAGFCB, int GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3EE0", Offset = "0x5EF2CE0", VA = "0x185EF3EE0", Slot = "31")]
	public bool MPCGMBHFDFL(string COPMFEAGFCB, bool HEDIGKLLBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1350", Offset = "0x5EF0150", VA = "0x185EF1350", Slot = "32")]
	public ICAGGLILCHD AEDHGGFGBPA(string COPMFEAGFCB, bool GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EF26C0", Offset = "0x5EF14C0", VA = "0x185EF26C0", Slot = "33")]
	public float HCDELDCIHKI(string COPMFEAGFCB, float HEDIGKLLBHN = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4060", Offset = "0x5EF2E60", VA = "0x185EF4060", Slot = "34")]
	public ICAGGLILCHD NFKGMGHGDNB(string COPMFEAGFCB, float GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4490", Offset = "0x5EF3290", VA = "0x185EF4490", Slot = "35")]
	public DateTime OCMDDFBDFKN(string COPMFEAGFCB, [Optional] DateTime HEDIGKLLBHN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1E10", Offset = "0x5EF0C10", VA = "0x185EF1E10", Slot = "36")]
	public ICAGGLILCHD EFNEAELFBGK(string COPMFEAGFCB, DateTime GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2EA0", Offset = "0x5EF1CA0", VA = "0x185EF2EA0", Slot = "37")]
	public long KDACCCEKPCK(string COPMFEAGFCB, long HEDIGKLLBHN = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3EB0", Offset = "0x5EF2CB0", VA = "0x185EF3EB0", Slot = "38")]
	public ICAGGLILCHD MDALJGAMLKE(string COPMFEAGFCB, long GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF20B0", Offset = "0x5EF0EB0", VA = "0x185EF20B0")]
	private bool EPMKMLDBFGH(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4580", Offset = "0x5EF3380", VA = "0x185EF4580")]
	private bool ONHHBGMKIFJ(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3760", Offset = "0x5EF2560", VA = "0x185EF3760")]
	private ICAGGLILCHD LFOIJJPGBOP(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, string GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5EF28B0", Offset = "0x5EF16B0", VA = "0x185EF28B0")]
	private ICAGGLILCHD HPDHLNJGKJK(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, int GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1E40", Offset = "0x5EF0C40", VA = "0x185EF1E40")]
	private ICAGGLILCHD EIBGMHDMMMB(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, bool GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2480", Offset = "0x5EF1280", VA = "0x185EF2480")]
	private ICAGGLILCHD GFBOPBELPAG(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, float GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1390", Offset = "0x5EF0190", VA = "0x185EF1390")]
	private ICAGGLILCHD BDCGLEIECCP(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, DateTime GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4300", Offset = "0x5EF3100", VA = "0x185EF4300")]
	private ICAGGLILCHD OBAAALINHFA(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, long GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x24BABF0", Offset = "0x24B99F0", VA = "0x1824BABF0")]
	private T IHMDCIIFDFG<T>(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, T HEDIGKLLBHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x24BB0F0", Offset = "0x24B9EF0", VA = "0x1824BB0F0")]
	private ICAGGLILCHD JDKMAJGGIMO<T>(HDGGKHDMMKE JLGAELGALHM, string COPMFEAGFCB, T GNLEHBFFNFG)
	{
		return default(ICAGGLILCHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x24BA8D0", Offset = "0x24B96D0", VA = "0x1824BA8D0", Slot = "39")]
	public void AJJHAEFLIKE<T>(ANNCCAEFEGH<T> HJFCKCFPHNO, [Optional] IEqualityComparer<T> KBMCPEOIHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x24BAB70", Offset = "0x24B9970", VA = "0x1824BAB70", Slot = "40")]
	public void GGADOIGOPFH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1FE0", Offset = "0x5EF0DE0", VA = "0x185EF1FE0")]
	[AsyncStateMachine(typeof(NJPGOFGHKIG))]
	private void ELKJDPIKNGA(HDGGKHDMMKE JDBCKBEBALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1CE0", Offset = "0x5EF0AE0", VA = "0x185EF1CE0", Slot = "43")]
	[AsyncStateMachine(typeof(JEHGNCDJLGC))]
	public Task CLFKABNNDNJ([Optional] CancellationToken PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3270", Offset = "0x5EF2070", VA = "0x185EF3270")]
	private void KKPPCELECHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2F10", Offset = "0x5EF1D10", VA = "0x185EF2F10", Slot = "41")]
	public IDisposable KJNCCLCFGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2270", Offset = "0x5EF1070", VA = "0x185EF2270", Slot = "42")]
	public void FOPFEOBLOMD(float MILPBPEIAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4A30", Offset = "0x5EF3830", VA = "0x185EF4A30")]
	private void PLJGGJFEAIO(float JAPBFDEDBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2A40", Offset = "0x5EF1840", VA = "0x185EF2A40")]
	[IteratorStateMachine(typeof(DEMONBNFEEP))]
	private IEnumerator<CCMEGKBIKJP> JGDGMGKNJIB(float MILPBPEIAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4690", Offset = "0x5EF3490", VA = "0x185EF4690")]
	[CompilerGenerated]
	private void OPHCOMGGHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LCPPLEHHDMF : GLMJIMIONAD<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static LCPPLEHHDMF GOPCOAILBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0A80", Offset = "0x5EEF880", VA = "0x185EF0A80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0D50", Offset = "0x5EEFB50", VA = "0x185EF0D50", Slot = "9")]
	public override string GKMCGBDALGF(bool ENGEPLNNBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0AD0", Offset = "0x5EEF8D0", VA = "0x185EF0AD0", Slot = "10")]
	protected override bool FJDMAKEKAGF(string ENGEPLNNBDC, [Out] bool GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0EE0", Offset = "0x5EEFCE0", VA = "0x185EF0EE0")]
	public LCPPLEHHDMF()
	{
	}
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
