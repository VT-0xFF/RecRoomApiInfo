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
public enum POIIIBPIALB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class NIEIPOIFCDO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal delegate void OPMGOBHEIGP(MHPJIDEOAFC DIPEGDJDDLE);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FB90", Offset = "0x6C4E190", VA = "0x186C4FB90")]
	private static void KPPENDANEEL(MHPJIDEOAFC DIPEGDJDDLE, OPMGOBHEIGP OGIJMKHCDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F550", Offset = "0x6C4DB50", VA = "0x186C4F550")]
	public static bool AKGPGKHEAPJ(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F8F0", Offset = "0x6C4DEF0", VA = "0x186C4F8F0")]
	public static KKHBGIEPNEM HPCLLILDOOH(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, string FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F410", Offset = "0x6C4DA10", VA = "0x186C4F410")]
	public static KKHBGIEPNEM AHAEPOONIGO(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, int FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F7B0", Offset = "0x6C4DDB0", VA = "0x186C4F7B0")]
	public static KKHBGIEPNEM ELOIEOCIMIN(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, bool FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FA40", Offset = "0x6C4E040", VA = "0x186C4FA40")]
	public static KKHBGIEPNEM JBNICKJIACH(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, float FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F640", Offset = "0x6C4DC40", VA = "0x186C4F640")]
	public static KKHBGIEPNEM BBGKNHGKCPL(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, DateTime FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FC10", Offset = "0x6C4E210", VA = "0x186C4FC10")]
	public static KKHBGIEPNEM LGPJAINONGP(this MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, long FEBGGALLBNN, [Optional] OPMGOBHEIGP OGIJMKHCDAM)
	{
		return default(KKHBGIEPNEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KGCBKEGDODM : CFGAEKENEJE, MHPJIDEOAFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LPKDNBPOGIM ENEFCHOOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> DNDEKOOOHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> DFMFEIPHIAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> OPLDDCJIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CC80", Offset = "0x6C4B280", VA = "0x186C4CC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E270", Offset = "0x6C4C870", VA = "0x186C4E270")]
	[Preserve]
	public KGCBKEGDODM([JLPFJOFFNLM(null)] LPKDNBPOGIM ENEFCHOOGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DFE0", Offset = "0x6C4C5E0", VA = "0x186C4DFE0")]
	private DirectoryInfo JDMKJCLJEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D1A0", Offset = "0x6C4B7A0", VA = "0x186C4D1A0", Slot = "6")]
	public Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E200", Offset = "0x6C4C800", VA = "0x186C4E200", Slot = "14")]
	public float PCAHFLPCINM(string MNBFPOFIDHA, float PBAONJMDGEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CCC0", Offset = "0x6C4B2C0", VA = "0x186C4CCC0", Slot = "13")]
	public void EAJHGMCNOPA(string MNBFPOFIDHA, bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DF20", Offset = "0x6C4C520", VA = "0x186C4DF20", Slot = "12")]
	public bool IEHCBBPHHIC(string MNBFPOFIDHA, bool PBAONJMDGEK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CAE0", Offset = "0x6C4B0E0", VA = "0x186C4CAE0", Slot = "10")]
	public int ANKDODMNFGM(string MNBFPOFIDHA, int PBAONJMDGEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E0E0", Offset = "0x6C4C6E0", VA = "0x186C4E0E0", Slot = "18")]
	public DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CB50", Offset = "0x6C4B150", VA = "0x186C4CB50", Slot = "19")]
	public void CBFKIIJHEGP(string MNBFPOFIDHA, DateTime FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D130", Offset = "0x6C4B730", VA = "0x186C4D130", Slot = "15")]
	public void EJPDBLPBJGA(string MNBFPOFIDHA, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DDB0", Offset = "0x6C4C3B0", VA = "0x186C4DDB0", Slot = "11")]
	public void GNPACBLPOOD(string MNBFPOFIDHA, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CA70", Offset = "0x6C4B070", VA = "0x186C4CA70", Slot = "20")]
	public long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CA00", Offset = "0x6C4B000", VA = "0x186C4CA00", Slot = "21")]
	public void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2965170", Offset = "0x2963770", VA = "0x182965170", Slot = "22")]
	public T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2965170", Offset = "0x2963770", VA = "0x182965170", Slot = "23")]
	public void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E150", Offset = "0x6C4C750", VA = "0x186C4E150", Slot = "16")]
	public string MIJBLGOAGIO(string MNBFPOFIDHA, string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CD30", Offset = "0x6C4B330", VA = "0x186C4CD30", Slot = "17")]
	public void EEDPLOOGOIA(string MNBFPOFIDHA, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CBC0", Offset = "0x6C4B1C0", VA = "0x186C4CBC0", Slot = "24")]
	public void CLOKELGPGJK(string MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DD20", Offset = "0x6C4C320", VA = "0x186C4DD20", Slot = "9")]
	public bool GJDHACBGNJI(string MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D9F0", Offset = "0x6C4BFF0", VA = "0x186C4D9F0", Slot = "25")]
	public Task GHELIDPFNEE(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CDA0", Offset = "0x6C4B3A0", VA = "0x186C4CDA0")]
	private void EGFGKBHOPDB(DirectoryInfo OCBABOPBMIF, string BMLEPHLFLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C800", Offset = "0x6C4AE00", VA = "0x186C4C800")]
	private static string AAKFHCIFAED(string MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DE20", Offset = "0x6C4C420", VA = "0x186C4DE20")]
	private static string HGAMFPPLEGG(byte[] CNNPIMPOGKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C07650", Offset = "0x2C05C50", VA = "0x182C07650")]
	private T BJJBEHDKBAF<T>(string LOPDMJPKEBC, T PBAONJMDGEK, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C08940", Offset = "0x2C06F40", VA = "0x182C08940")]
	private void FNIGGHLNDBN<T>(string LOPDMJPKEBC, T FEBGGALLBNN, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D230", Offset = "0x6C4B830", VA = "0x186C4D230")]
	private Dictionary<string, string> FMHIPFGNCPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class GIAJGKLCDEJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B1E0", Offset = "0x6C497E0", VA = "0x186C4B1E0")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void EPFABJKOPAP(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MJBOIGEMIGB : MLKEBBPGIBL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EC40", Offset = "0x6C4D240", VA = "0x186C4EC40")]
	[Preserve]
	public MJBOIGEMIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MLKEBBPGIBL : CFGAEKENEJE, MHPJIDEOAFC, FPDMJEABCIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> BAAFIJPPOFB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EFD0", Offset = "0x6C4D5D0", VA = "0x186C4EFD0", Slot = "6")]
	public Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F0F0", Offset = "0x6C4D6F0", VA = "0x186C4F0F0", Slot = "9")]
	public bool GJDHACBGNJI(string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ED90", Offset = "0x6C4D390", VA = "0x186C4ED90", Slot = "10")]
	public int ANKDODMNFGM(string LOPDMJPKEBC, int PBAONJMDGEK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F150", Offset = "0x6C4D750", VA = "0x186C4F150", Slot = "11")]
	public void GNPACBLPOOD(string LOPDMJPKEBC, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F1B0", Offset = "0x6C4D7B0", VA = "0x186C4F1B0", Slot = "12")]
	public bool IEHCBBPHHIC(string LOPDMJPKEBC, bool PBAONJMDGEK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EEB0", Offset = "0x6C4D4B0", VA = "0x186C4EEB0", Slot = "13")]
	public void EAJHGMCNOPA(string LOPDMJPKEBC, bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F2D0", Offset = "0x6C4D8D0", VA = "0x186C4F2D0", Slot = "14")]
	public float PCAHFLPCINM(string LOPDMJPKEBC, float PBAONJMDGEK = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EF70", Offset = "0x6C4D570", VA = "0x186C4EF70", Slot = "15")]
	public void EJPDBLPBJGA(string LOPDMJPKEBC, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F270", Offset = "0x6C4D870", VA = "0x186C4F270", Slot = "16")]
	public string MIJBLGOAGIO(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EF10", Offset = "0x6C4D510", VA = "0x186C4EF10", Slot = "17")]
	public void EEDPLOOGOIA(string LOPDMJPKEBC, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F210", Offset = "0x6C4D810", VA = "0x186C4F210", Slot = "18")]
	public DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EDF0", Offset = "0x6C4D3F0", VA = "0x186C4EDF0", Slot = "19")]
	public void CBFKIIJHEGP(string LOPDMJPKEBC, DateTime FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ED30", Offset = "0x6C4D330", VA = "0x186C4ED30", Slot = "20")]
	public long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ECD0", Offset = "0x6C4D2D0", VA = "0x186C4ECD0", Slot = "21")]
	public void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C616C0", Offset = "0x2C5FCC0", VA = "0x182C616C0", Slot = "22")]
	public T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C617E0", Offset = "0x2C5FDE0", VA = "0x182C617E0", Slot = "23")]
	public void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C60990", Offset = "0x2C5EF90", VA = "0x182C60990")]
	public T BJJBEHDKBAF<T>(string LOPDMJPKEBC, T PBAONJMDGEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C611D0", Offset = "0x2C5F7D0", VA = "0x182C611D0")]
	public void FNIGGHLNDBN<T>(string LOPDMJPKEBC, T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EE50", Offset = "0x6C4D450", VA = "0x186C4EE50", Slot = "24")]
	public void CLOKELGPGJK(string LOPDMJPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F060", Offset = "0x6C4D660", VA = "0x186C4F060", Slot = "25")]
	public Task GHELIDPFNEE(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C4EC40", Offset = "0x6C4D240", VA = "0x186C4EC40")]
	public MLKEBBPGIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class JJJNKOIFCHE<TParent> where TParent : MHPJIDEOAFC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<JJJNKOIFCHE<TParent>> JHEHFOGKDGD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4064390", Offset = "0x4062990", VA = "0x184064390")]
	protected JJJNKOIFCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void KFLPEIEEDCE();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void LJKAAHGGEJO(string MNBFPOFIDHA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4063DC0", Offset = "0x40623C0", VA = "0x184063DC0")]
	public static void ADEGICHIJFE(string MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4064010", Offset = "0x4062610", VA = "0x184064010")]
	public static void CACOLNLNPJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NFAOANILGFM<TParent, TValue> : JJJNKOIFCHE<TParent> where TParent : MHPJIDEOAFC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly NFAOANILGFM<TParent, TValue> NEJLCIDCLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> FBCDCIGNMPB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4572AD0", Offset = "0x45710D0", VA = "0x184572AD0")]
	public bool NCAHNJJKPNF(string FHLBFJLDNAL, [Out] TValue OONKOLKFGIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4572940", Offset = "0x4570F40", VA = "0x184572940")]
	public void HGGGODJLKIJ(string FHLBFJLDNAL, TValue FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C7A0", Offset = "0x3B8ADA0", VA = "0x183B8C7A0", Slot = "4")]
	protected override void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC4E0", Offset = "0x3DFAAE0", VA = "0x183DFC4E0", Slot = "5")]
	protected override void LJKAAHGGEJO(string FHLBFJLDNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4572C70", Offset = "0x4571270", VA = "0x184572C70")]
	public NFAOANILGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MHPJIDEOAFC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDPOGFCDHAB();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GJDHACBGNJI(string LOPDMJPKEBC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ANKDODMNFGM(string LOPDMJPKEBC, int PBAONJMDGEK = 0);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNPACBLPOOD(string LOPDMJPKEBC, int FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IEHCBBPHHIC(string LOPDMJPKEBC, bool PBAONJMDGEK = false);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EAJHGMCNOPA(string LOPDMJPKEBC, bool FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float PCAHFLPCINM(string LOPDMJPKEBC, float PBAONJMDGEK = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EJPDBLPBJGA(string LOPDMJPKEBC, float FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string MIJBLGOAGIO(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEDPLOOGOIA(string LOPDMJPKEBC, string FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime OCBLMALMPPE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CBFKIIJHEGP(string LOPDMJPKEBC, DateTime OCBLMALMPPE);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CLOKELGPGJK(string LOPDMJPKEBC);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task GHELIDPFNEE([Optional] CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CFGAEKENEJE : MHPJIDEOAFC
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HKAFCFANAAL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FPDMJEABCIP : MHPJIDEOAFC
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KBMAEBAOIEO : CFGAEKENEJE, MHPJIDEOAFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct OHNOALOIEEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KBMAEBAOIEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FD50", Offset = "0x6C4E350", VA = "0x186C4FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FEE0", Offset = "0x6C4E4E0", VA = "0x186C4FEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IJKFBGPFCKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public KBMAEBAOIEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B330", Offset = "0x6C49930", VA = "0x186C4B330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B620", Offset = "0x6C49C20", VA = "0x186C4B620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CFGAEKENEJE BDJOCMLGLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KGCBKEGDODM EGKPCBLFNAC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C1C0", Offset = "0x6C4A7C0", VA = "0x186C4C1C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B9A0", Offset = "0x6C49FA0", VA = "0x186C4B9A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C4C220", Offset = "0x6C4A820", VA = "0x186C4C220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C6F0", Offset = "0x6C4ACF0", VA = "0x186C4C6F0")]
	[Preserve]
	public KBMAEBAOIEO([JLPFJOFFNLM(null)] LPKDNBPOGIM ENEFCHOOGFI, [JLPFJOFFNLM("Disk_Unity")] CFGAEKENEJE BDJOCMLGLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BA70", Offset = "0x6C4A070", VA = "0x186C4BA70", Slot = "8")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BF30", Offset = "0x6C4A530", VA = "0x186C4BF30", Slot = "9")]
	public bool GJDHACBGNJI(string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B850", Offset = "0x6C49E50", VA = "0x186C4B850", Slot = "10")]
	public int ANKDODMNFGM(string LOPDMJPKEBC, int PBAONJMDGEK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BFC0", Offset = "0x6C4A5C0", VA = "0x186C4BFC0", Slot = "11")]
	public void GNPACBLPOOD(string LOPDMJPKEBC, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C030", Offset = "0x6C4A630", VA = "0x186C4C030", Slot = "12")]
	public bool IEHCBBPHHIC(string LOPDMJPKEBC, bool PBAONJMDGEK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BBE0", Offset = "0x6C4A1E0", VA = "0x186C4BBE0", Slot = "13")]
	public void EAJHGMCNOPA(string LOPDMJPKEBC, bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C590", Offset = "0x6C4AB90", VA = "0x186C4C590", Slot = "14")]
	public float PCAHFLPCINM(string LOPDMJPKEBC, float PBAONJMDGEK = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BCC0", Offset = "0x6C4A2C0", VA = "0x186C4BCC0", Slot = "15")]
	public void EJPDBLPBJGA(string LOPDMJPKEBC, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C3F0", Offset = "0x6C4A9F0", VA = "0x186C4C3F0", Slot = "16")]
	public string MIJBLGOAGIO(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BC50", Offset = "0x6C4A250", VA = "0x186C4BC50", Slot = "17")]
	public void EEDPLOOGOIA(string LOPDMJPKEBC, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C290", Offset = "0x6C4A890", VA = "0x186C4C290", Slot = "18")]
	public DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BA00", Offset = "0x6C4A000", VA = "0x186C4BA00", Slot = "19")]
	public void CBFKIIJHEGP(string LOPDMJPKEBC, DateTime OCBLMALMPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B6F0", Offset = "0x6C49CF0", VA = "0x186C4B6F0", Slot = "20")]
	public long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B680", Offset = "0x6C49C80", VA = "0x186C4B680", Slot = "21")]
	public void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2C019E0", Offset = "0x2BFFFE0", VA = "0x182C019E0", Slot = "22")]
	public T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2C02170", Offset = "0x2C00770", VA = "0x182C02170", Slot = "23")]
	public void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BAD0", Offset = "0x6C4A0D0", VA = "0x186C4BAD0", Slot = "24")]
	public void CLOKELGPGJK(string LOPDMJPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BE40", Offset = "0x6C4A440", VA = "0x186C4BE40", Slot = "25")]
	[AsyncStateMachine(typeof(OHNOALOIEEE))]
	public Task GHELIDPFNEE([Optional] CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BD30", Offset = "0x6C4A330", VA = "0x186C4BD30", Slot = "6")]
	[AsyncStateMachine(typeof(IJKFBGPFCKL))]
	public Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CLHPBGAONIF : CFGAEKENEJE, MHPJIDEOAFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AJHPCDMMEAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CLHPBGAONIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C46220", Offset = "0x6C44820", VA = "0x186C46220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C465E0", Offset = "0x6C44BE0", VA = "0x186C465E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LLDPFFCIFJG : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CLHPBGAONIF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public LLDPFFCIFJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E650", Offset = "0x6C4CC50", VA = "0x186C4E650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E6C0", Offset = "0x6C4CCC0", VA = "0x186C4E6C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LPKDNBPOGIM ENEFCHOOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LDBFHFGICNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool BFGPAJGOHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PCFKKJJFCHN CGHHFMGJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private MCOHGCAFPBM GCPHBJNLJCA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C47C20", Offset = "0x6C46220", VA = "0x186C47C20")]
	[Preserve]
	public CLHPBGAONIF([JLPFJOFFNLM(null)] LPKDNBPOGIM ENEFCHOOGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C477B0", Offset = "0x6C45DB0", VA = "0x186C477B0", Slot = "6")]
	public Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x12E8F40", Offset = "0x12E7540", VA = "0x1812E8F40")]
	private static int KMHIFOCEMMF(bool FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C47930", Offset = "0x6C45F30", VA = "0x186C47930", Slot = "9")]
	public bool GJDHACBGNJI(string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C47580", Offset = "0x6C45B80", VA = "0x186C47580", Slot = "10")]
	public int ANKDODMNFGM(string LOPDMJPKEBC, int PBAONJMDGEK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C47950", Offset = "0x6C45F50", VA = "0x186C47950", Slot = "11")]
	public void GNPACBLPOOD(string LOPDMJPKEBC, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C47980", Offset = "0x6C45F80", VA = "0x186C47980", Slot = "12")]
	public bool IEHCBBPHHIC(string LOPDMJPKEBC, bool PBAONJMDGEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C47720", Offset = "0x6C45D20", VA = "0x186C47720", Slot = "13")]
	public void EAJHGMCNOPA(string LOPDMJPKEBC, bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C47B70", Offset = "0x6C46170", VA = "0x186C47B70", Slot = "14")]
	public float PCAHFLPCINM(string LOPDMJPKEBC, float PBAONJMDGEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C47780", Offset = "0x6C45D80", VA = "0x186C47780", Slot = "15")]
	public void EJPDBLPBJGA(string LOPDMJPKEBC, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C47A10", Offset = "0x6C46010", VA = "0x186C47A10", Slot = "18")]
	public DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C475B0", Offset = "0x6C45BB0", VA = "0x186C475B0", Slot = "19")]
	public void CBFKIIJHEGP(string LOPDMJPKEBC, DateTime OCBLMALMPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C474A0", Offset = "0x6C45AA0", VA = "0x186C474A0", Slot = "20")]
	public long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C47410", Offset = "0x6C45A10", VA = "0x186C47410", Slot = "21")]
	public void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2970960", Offset = "0x296EF60", VA = "0x182970960", Slot = "22")]
	public T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2970960", Offset = "0x296EF60", VA = "0x182970960", Slot = "23")]
	public void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29712F0", Offset = "0x296F8F0", VA = "0x1829712F0")]
	private T PJDOLECMINN<T>(string LOPDMJPKEBC, T PBAONJMDGEK, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2970C60", Offset = "0x296F260", VA = "0x182970C60")]
	private void OGNCCDCALJF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C47A80", Offset = "0x6C46080", VA = "0x186C47A80", Slot = "16")]
	public string MIJBLGOAGIO(string LOPDMJPKEBC, string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C47750", Offset = "0x6C45D50", VA = "0x186C47750", Slot = "17")]
	public void EEDPLOOGOIA(string LOPDMJPKEBC, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C47B50", Offset = "0x6C46150", VA = "0x186C47B50")]
	private void OOAIDJEIBHC(string LOPDMJPKEBC, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C47480", Offset = "0x6C45A80", VA = "0x186C47480")]
	private string AJJNCODBGPD(string LOPDMJPKEBC, string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C47620", Offset = "0x6C45C20", VA = "0x186C47620", Slot = "24")]
	public void CLOKELGPGJK(string LOPDMJPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C47AB0", Offset = "0x6C460B0", VA = "0x186C47AB0")]
	private string NNCFLDLIFCJ(string MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C47840", Offset = "0x6C45E40", VA = "0x186C47840", Slot = "25")]
	[AsyncStateMachine(typeof(AJHPCDMMEAP))]
	public Task GHELIDPFNEE(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C47BA0", Offset = "0x6C461A0", VA = "0x186C47BA0")]
	[IteratorStateMachine(typeof(LLDPFFCIFJG))]
	private IEnumerator<FDDBCEBEBAE> PKOJNPILOIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C479B0", Offset = "0x6C45FB0", VA = "0x186C479B0")]
	private void LAJMHNLBLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C47510", Offset = "0x6C45B10", VA = "0x186C47510")]
	private void ALLAOCMEAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C476B0", Offset = "0x6C45CB0", VA = "0x186C476B0")]
	private void DOIEDDDBICP(bool OCCHIGIDODF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CFKFKIKHIEJ : CFGAEKENEJE, MHPJIDEOAFC
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> DFMFEIPHIAK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string BFDJJLPIOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C47210", Offset = "0x6C45810", VA = "0x186C47210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> OPLDDCJIKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C468C0", Offset = "0x6C44EC0", VA = "0x186C468C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[Preserve]
	public CFKFKIKHIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C46A80", Offset = "0x6C45080", VA = "0x186C46A80", Slot = "6")]
	public Task FFDNPKCCLNB(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C473A0", Offset = "0x6C459A0", VA = "0x186C473A0", Slot = "14")]
	public float PCAHFLPCINM(string MNBFPOFIDHA, float PBAONJMDGEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C46900", Offset = "0x6C44F00", VA = "0x186C46900", Slot = "13")]
	public void EAJHGMCNOPA(string MNBFPOFIDHA, bool FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C47150", Offset = "0x6C45750", VA = "0x186C47150", Slot = "12")]
	public bool IEHCBBPHHIC(string MNBFPOFIDHA, bool PBAONJMDGEK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C46720", Offset = "0x6C44D20", VA = "0x186C46720", Slot = "10")]
	public int ANKDODMNFGM(string MNBFPOFIDHA, int PBAONJMDGEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C47280", Offset = "0x6C45880", VA = "0x186C47280", Slot = "18")]
	public DateTime MGCBDAPCKEA(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C46790", Offset = "0x6C44D90", VA = "0x186C46790", Slot = "19")]
	public void CBFKIIJHEGP(string MNBFPOFIDHA, DateTime FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C46A10", Offset = "0x6C45010", VA = "0x186C46A10", Slot = "15")]
	public void EJPDBLPBJGA(string MNBFPOFIDHA, float FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C470E0", Offset = "0x6C456E0", VA = "0x186C470E0", Slot = "11")]
	public void GNPACBLPOOD(string MNBFPOFIDHA, int FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C466B0", Offset = "0x6C44CB0", VA = "0x186C466B0", Slot = "20")]
	public long AKJHKANCMAG(string LOPDMJPKEBC, long PBAONJMDGEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C46640", Offset = "0x6C44C40", VA = "0x186C46640", Slot = "21")]
	public void AHOEAKHEJJL(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2965170", Offset = "0x2963770", VA = "0x182965170", Slot = "22")]
	public T IGMHIIIDJAH<T>(string LOPDMJPKEBC, T PBAONJMDGEK, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2965170", Offset = "0x2963770", VA = "0x182965170", Slot = "23")]
	public void JODLBCAJAKF<T>(string LOPDMJPKEBC, T FEBGGALLBNN, JAKDAECKFEL<T> LLCOOGNCAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C472F0", Offset = "0x6C458F0", VA = "0x186C472F0", Slot = "16")]
	public string MIJBLGOAGIO(string MNBFPOFIDHA, string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C46970", Offset = "0x6C44F70", VA = "0x186C46970", Slot = "17")]
	public void EEDPLOOGOIA(string MNBFPOFIDHA, string FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6C46800", Offset = "0x6C44E00", VA = "0x186C46800", Slot = "24")]
	public void CLOKELGPGJK(string MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6C47050", Offset = "0x6C45650", VA = "0x186C47050", Slot = "9")]
	public bool GJDHACBGNJI(string MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6C46DF0", Offset = "0x6C453F0", VA = "0x186C46DF0", Slot = "25")]
	public Task GHELIDPFNEE(CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2962F30", Offset = "0x2961530", VA = "0x182962F30")]
	private T BJJBEHDKBAF<T>(string LOPDMJPKEBC, T PBAONJMDGEK, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2964220", Offset = "0x2962820", VA = "0x182964220")]
	private void FNIGGHLNDBN<T>(string LOPDMJPKEBC, T FEBGGALLBNN, [Optional] JAKDAECKFEL<T> KICLBLFHLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C46B10", Offset = "0x6C45110", VA = "0x186C46B10")]
	private Dictionary<string, string> FMHIPFGNCPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KFDOLDGEEBK
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HKAFCFANAAL;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDPOGFCDHAB();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PGFLJANGBEJ(long IBDCEBDELBE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMAIJONDFIP(POIIIBPIALB EOIBHMCFCOD = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JFFDGHPIPDB(string LOPDMJPKEBC, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PECLDDJNKOO(string LOPDMJPKEBC, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string GIMHCEJPELP(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KKHBGIEPNEM BCPPLGMCGKL(string LOPDMJPKEBC, string FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int ACCEFKKIKMG(string LOPDMJPKEBC, int PBAONJMDGEK = 0, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KKHBGIEPNEM GLKOKNNKJMO(string LOPDMJPKEBC, int FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PBFECKNJABB(string LOPDMJPKEBC, bool PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KKHBGIEPNEM AHFFHIDFOOG(string LOPDMJPKEBC, bool FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float BLOCKGEJOBM(string LOPDMJPKEBC, float PBAONJMDGEK = 0f, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KKHBGIEPNEM MLFINEOOHOP(string LOPDMJPKEBC, float FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime EDFBNHIAIJH(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KKHBGIEPNEM CHJACGCOICP(string LOPDMJPKEBC, DateTime FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long GAIBDKDDNAC(string LOPDMJPKEBC, long PBAONJMDGEK = 0L, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KKHBGIEPNEM FINFHIGNKAK(string LOPDMJPKEBC, long FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T KJFJBBCDAOJ<T>(string LOPDMJPKEBC, [Optional] T PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KKHBGIEPNEM OPEOBPDBHMB<T>(string LOPDMJPKEBC, T FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JHKIFKCIPEP(string LOPDMJPKEBC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool LFLGMHMHNKB(string LOPDMJPKEBC);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string IEOEOJDCLKC(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KKHBGIEPNEM BBKGNIMENDI(string LOPDMJPKEBC, string FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int LOGGAFANMCO(string LOPDMJPKEBC, int PBAONJMDGEK = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KKHBGIEPNEM PMGIMJKNFEP(string LOPDMJPKEBC, int FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DKFBONELHIJ(string LOPDMJPKEBC, bool PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "28")]
	KKHBGIEPNEM MJAHHMDNJEC(string LOPDMJPKEBC, bool FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float LDHNICEGIAE(string LOPDMJPKEBC, float PBAONJMDGEK = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KKHBGIEPNEM CFJDJMAGAIC(string LOPDMJPKEBC, float FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime DEPFJECPDEM(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "32")]
	KKHBGIEPNEM HJJCEGPMOHO(string LOPDMJPKEBC, DateTime FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long AMPHGKDPEFL(string LOPDMJPKEBC, long PBAONJMDGEK = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "34")]
	KKHBGIEPNEM DLBFCJJCNII(string LOPDMJPKEBC, long FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DGHFKCPOIFA<T>(JAKDAECKFEL<T> LLCOOGNCAAF, [Optional] IEqualityComparer<T> JNJFJFBCDJD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void BNDJOBHMFCM<T>();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable AKBNHHIFDFN();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ALGBHHDKFKJ(float OPCFFCHKCFF);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task LAJMHNLBLKN([Optional] CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KKHBGIEPNEM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EGLFDBJKCML : KFDOLDGEEBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class EOKKFDCFECD
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected static readonly HashSet<EOKKFDCFECD> BBOMNGCDCAM;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B010", Offset = "0x6C49610", VA = "0x186C4B010")]
		public static void CACOLNLNPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KFLPEIEEDCE();

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected EOKKFDCFECD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class HPKPDKJLNCK<T> : EOKKFDCFECD
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly HPKPDKJLNCK<T> HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JAKDAECKFEL<T> GNCMNOJMDLH
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> IEPPPANMIDN
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GOOBNNIMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x37CDE40", Offset = "0x37CC440", VA = "0x1837CDE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3D587C0", Offset = "0x3D56DC0", VA = "0x183D587C0")]
		private HPKPDKJLNCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3D58440", Offset = "0x3D56A40", VA = "0x183D58440")]
		public void OOMCOBOGONK(JAKDAECKFEL<T> KICLBLFHLEK, [Optional] IEqualityComparer<T> JNJFJFBCDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3D58030", Offset = "0x3D56630", VA = "0x183D58030", Slot = "4")]
		public override void KFLPEIEEDCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ABGBALPKEJE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly EGLFDBJKCML KIJLLIDDCJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly object CHJPNIOICEP;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6C46170", Offset = "0x6C44770", VA = "0x186C46170")]
		public ABGBALPKEJE(EGLFDBJKCML KIJLLIDDCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6C46140", Offset = "0x6C44740", VA = "0x186C46140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KNPNAAMDBLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EGLFDBJKCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E310", Offset = "0x6C4C910", VA = "0x186C4E310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E5F0", Offset = "0x6C4CBF0", VA = "0x186C4E5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct DEKCFNMICKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public EGLFDBJKCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MHPJIDEOAFC backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C47D10", Offset = "0x6C46310", VA = "0x186C47D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct LPENDCBCODE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public EGLFDBJKCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E710", Offset = "0x6C4CD10", VA = "0x186C4E710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EBE0", Offset = "0x6C4D1E0", VA = "0x186C4EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NGJHKMFGKCF : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public EGLFDBJKCML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public NGJHKMFGKCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F330", Offset = "0x6C4D930", VA = "0x186C4F330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F3C0", Offset = "0x6C4D9C0", VA = "0x186C4F3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly CFGAEKENEJE MAOFPOFCJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly CFGAEKENEJE KHNOPJLHLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FPDMJEABCIP HOGCHFFMFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly PCFKKJJFCHN CGHHFMGJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NIEIPOIFCDO.OPMGOBHEIGP OGIJMKHCDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PFNCBEJNFIN BFJLCPDLNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HashSet<MHPJIDEOAFC> PMJBNMKOOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Task LPNJNGLNLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<string, string> EIAILIPLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private MCOHGCAFPBM MDLCNLOMAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly object CFAGPHLBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly object HCFNPMHKACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private long JAIINBFHPPB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool OLDJCJEMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C48640", Offset = "0x6C46C40", VA = "0x186C48640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource MCCGKLOOFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x861730", Offset = "0x85FD30", VA = "0x180861730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HKAFCFANAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C48450", Offset = "0x6C46A50", VA = "0x186C48450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C49FF0", Offset = "0x6C485F0", VA = "0x186C49FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C496E0", Offset = "0x6C47CE0", VA = "0x186C496E0")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void IPDGANODBNB(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AC40", Offset = "0x6C49240", VA = "0x186C4AC40")]
	[Preserve]
	public EGLFDBJKCML([JLPFJOFFNLM("Disk")] CFGAEKENEJE MAOFPOFCJKG, [JLPFJOFFNLM("Cloud")] CFGAEKENEJE KHNOPJLHLJN, [JLPFJOFFNLM(null)] FPDMJEABCIP HOGCHFFMFLA, [JLPFJOFFNLM(null)] PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C48DC0", Offset = "0x6C473C0", VA = "0x186C48DC0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A750", Offset = "0x6C48D50", VA = "0x186C4A750")]
	private void PAOFDCJDEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C485A0", Offset = "0x6C46BA0", VA = "0x186C485A0", Slot = "6")]
	public void CDPOGFCDHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A980", Offset = "0x6C48F80", VA = "0x186C4A980", Slot = "7")]
	public Task PGFLJANGBEJ(long IBDCEBDELBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C49560", Offset = "0x6C47B60", VA = "0x186C49560")]
	[AsyncStateMachine(typeof(KNPNAAMDBLH))]
	private Task HNLPAGNLPGO(long IBDCEBDELBE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A400", Offset = "0x6C48A00", VA = "0x186C4A400")]
	private void ODGCDEHLLCK(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C49D40", Offset = "0x6C48340", VA = "0x186C49D40")]
	private void LCHHHOFLJKG(object PNPIGCGKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C48CC0", Offset = "0x6C472C0", VA = "0x186C48CC0")]
	private string DGDGLIBEEOD(string GPLOCEAPJHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C49AB0", Offset = "0x6C480B0", VA = "0x186C49AB0")]
	private void KIIOOBGENNK(POIIIBPIALB EOIBHMCFCOD, string MNBFPOFIDHA, [Out] CFGAEKENEJE DIPEGDJDDLE, [Out] string JMJIFMBIIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A240", Offset = "0x6C48840", VA = "0x186C4A240")]
	private CFGAEKENEJE NAHDNLCOJLC(POIIIBPIALB EOIBHMCFCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AB50", Offset = "0x6C49150", VA = "0x186C4AB50", Slot = "8")]
	public bool PMAIJONDFIP(POIIIBPIALB EOIBHMCFCOD = POIIIBPIALB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C498C0", Offset = "0x6C47EC0", VA = "0x186C498C0", Slot = "9")]
	public bool JFFDGHPIPDB(string LOPDMJPKEBC, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A850", Offset = "0x6C48E50", VA = "0x186C4A850", Slot = "10")]
	public bool PECLDDJNKOO(string LOPDMJPKEBC, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C49190", Offset = "0x6C47790", VA = "0x186C49190", Slot = "11")]
	public string GIMHCEJPELP(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C482C0", Offset = "0x6C468C0", VA = "0x186C482C0", Slot = "12")]
	public KKHBGIEPNEM BCPPLGMCGKL(string LOPDMJPKEBC, string FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C47EA0", Offset = "0x6C464A0", VA = "0x186C47EA0", Slot = "13")]
	public int ACCEFKKIKMG(string LOPDMJPKEBC, int PBAONJMDGEK = 0, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C49230", Offset = "0x6C47830", VA = "0x186C49230", Slot = "14")]
	public KKHBGIEPNEM GLKOKNNKJMO(string LOPDMJPKEBC, int FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A7A0", Offset = "0x6C48DA0", VA = "0x186C4A7A0", Slot = "15")]
	public bool PBFECKNJABB(string LOPDMJPKEBC, bool PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6C47FB0", Offset = "0x6C465B0", VA = "0x186C47FB0", Slot = "16")]
	public KKHBGIEPNEM AHFFHIDFOOG(string LOPDMJPKEBC, bool FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6C484F0", Offset = "0x6C46AF0", VA = "0x186C484F0", Slot = "17")]
	public float BLOCKGEJOBM(string LOPDMJPKEBC, float PBAONJMDGEK = 0f, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A0C0", Offset = "0x6C486C0", VA = "0x186C4A0C0", Slot = "18")]
	public KKHBGIEPNEM MLFINEOOHOP(string LOPDMJPKEBC, float FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6C48E00", Offset = "0x6C47400", VA = "0x186C48E00", Slot = "19")]
	public DateTime EDFBNHIAIJH(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6C48660", Offset = "0x6C46C60", VA = "0x186C48660", Slot = "20")]
	public KKHBGIEPNEM CHJACGCOICP(string LOPDMJPKEBC, DateTime FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6C49020", Offset = "0x6C47620", VA = "0x186C49020", Slot = "21")]
	public long GAIBDKDDNAC(string LOPDMJPKEBC, long PBAONJMDGEK = 0L, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6C48EA0", Offset = "0x6C474A0", VA = "0x186C48EA0", Slot = "22")]
	public KKHBGIEPNEM FINFHIGNKAK(string LOPDMJPKEBC, long FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x29F41F0", Offset = "0x29F27F0", VA = "0x1829F41F0", Slot = "23")]
	public T KJFJBBCDAOJ<T>(string LOPDMJPKEBC, [Optional] T PBAONJMDGEK, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x29F41F0", Offset = "0x29F27F0", VA = "0x1829F41F0", Slot = "24")]
	public KKHBGIEPNEM OPEOBPDBHMB<T>(string LOPDMJPKEBC, T FEBGGALLBNN, POIIIBPIALB GHBGEJALEOI = POIIIBPIALB.CLOUD)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C49960", Offset = "0x6C47F60", VA = "0x186C49960", Slot = "25")]
	public bool JHKIFKCIPEP(string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C49E30", Offset = "0x6C48430", VA = "0x186C49E30", Slot = "26")]
	public bool LFLGMHMHNKB(string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C49670", Offset = "0x6C47C70", VA = "0x186C49670", Slot = "27")]
	public string IEOEOJDCLKC(string LOPDMJPKEBC, [Optional] string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C48290", Offset = "0x6C46890", VA = "0x186C48290", Slot = "28")]
	public KKHBGIEPNEM BBKGNIMENDI(string LOPDMJPKEBC, string FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C49F80", Offset = "0x6C48580", VA = "0x186C49F80", Slot = "29")]
	public int LOGGAFANMCO(string LOPDMJPKEBC, int PBAONJMDGEK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AC10", Offset = "0x6C49210", VA = "0x186C4AC10", Slot = "30")]
	public KKHBGIEPNEM PMGIMJKNFEP(string LOPDMJPKEBC, int FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C48D20", Offset = "0x6C47320", VA = "0x186C48D20", Slot = "31")]
	public bool DKFBONELHIJ(string LOPDMJPKEBC, bool PBAONJMDGEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A090", Offset = "0x6C48690", VA = "0x186C4A090", Slot = "32")]
	public KKHBGIEPNEM MJAHHMDNJEC(string LOPDMJPKEBC, bool FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6C49DC0", Offset = "0x6C483C0", VA = "0x186C49DC0", Slot = "33")]
	public float LDHNICEGIAE(string LOPDMJPKEBC, float PBAONJMDGEK = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6C48610", Offset = "0x6C46C10", VA = "0x186C48610", Slot = "34")]
	public KKHBGIEPNEM CFJDJMAGAIC(string LOPDMJPKEBC, float FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C48BC0", Offset = "0x6C471C0", VA = "0x186C48BC0", Slot = "35")]
	public DateTime DEPFJECPDEM(string LOPDMJPKEBC, [Optional] DateTime PBAONJMDGEK)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C49530", Offset = "0x6C47B30", VA = "0x186C49530", Slot = "36")]
	public KKHBGIEPNEM HJJCEGPMOHO(string LOPDMJPKEBC, DateTime FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C48220", Offset = "0x6C46820", VA = "0x186C48220", Slot = "37")]
	public long AMPHGKDPEFL(string LOPDMJPKEBC, long PBAONJMDGEK = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C48D90", Offset = "0x6C47390", VA = "0x186C48D90", Slot = "38")]
	public KKHBGIEPNEM DLBFCJJCNII(string LOPDMJPKEBC, long FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C47F50", Offset = "0x6C46550", VA = "0x186C47F50")]
	private bool AEHLAPAAEFE(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C499C0", Offset = "0x6C47FC0", VA = "0x186C499C0")]
	private bool KHILGAONOCG(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A420", Offset = "0x6C48A20", VA = "0x186C4A420")]
	private KKHBGIEPNEM OGICFLMPPBI(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, string FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C49E40", Offset = "0x6C48440", VA = "0x186C49E40")]
	private KKHBGIEPNEM LHAFJOFFFMD(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, int FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C48A80", Offset = "0x6C47080", VA = "0x186C48A80")]
	private KKHBGIEPNEM CNHFJPFHNBB(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, bool FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C493E0", Offset = "0x6C479E0", VA = "0x186C493E0")]
	private KKHBGIEPNEM HDFJHDLDLIG(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, float FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C49750", Offset = "0x6C47D50", VA = "0x186C49750")]
	private KKHBGIEPNEM JDHPONNGALC(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, DateTime FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A2C0", Offset = "0x6C488C0", VA = "0x186C4A2C0")]
	private KKHBGIEPNEM NOAOKCANAOK(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, long FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x29F3C90", Offset = "0x29F2290", VA = "0x1829F3C90")]
	private T JIKGGADMEPI<T>(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, T PBAONJMDGEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x29F4410", Offset = "0x29F2A10", VA = "0x1829F4410")]
	private KKHBGIEPNEM NMDDJNGGBNH<T>(MHPJIDEOAFC DIPEGDJDDLE, string LOPDMJPKEBC, T FEBGGALLBNN)
	{
		return default(KKHBGIEPNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x29F3BE0", Offset = "0x29F21E0", VA = "0x1829F3BE0", Slot = "39")]
	public void DGHFKCPOIFA<T>(JAKDAECKFEL<T> LLCOOGNCAAF, [Optional] IEqualityComparer<T> JNJFJFBCDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x29F3B60", Offset = "0x29F2160", VA = "0x1829F3B60", Slot = "40")]
	public void BNDJOBHMFCM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C490C0", Offset = "0x6C476C0", VA = "0x186C490C0")]
	[AsyncStateMachine(typeof(DEKCFNMICKE))]
	private void GHELIDPFNEE(MHPJIDEOAFC DNHJPENJEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C49C50", Offset = "0x6C48250", VA = "0x186C49C50", Slot = "43")]
	[AsyncStateMachine(typeof(LPENDCBCODE))]
	public Task LAJMHNLBLKN([Optional] CancellationToken PNPIGCGKNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C4A570", Offset = "0x6C48B70", VA = "0x186C4A570")]
	private void OHCFCHNJDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C48130", Offset = "0x6C46730", VA = "0x186C48130", Slot = "41")]
	public IDisposable AKBNHHIFDFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C48210", Offset = "0x6C46810", VA = "0x186C48210", Slot = "42")]
	public void ALGBHHDKFKJ(float OPCFFCHKCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C48800", Offset = "0x6C46E00", VA = "0x186C48800")]
	private void CLHOHCHCOAM(float CKIENAOAKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C48C30", Offset = "0x6C47230", VA = "0x186C48C30")]
	[IteratorStateMachine(typeof(NGJHKMFGKCF))]
	private IEnumerator<FDDBCEBEBAE> DFCJAHCJJFG(float OPCFFCHKCFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C493B0", Offset = "0x6C479B0", VA = "0x186C493B0")]
	[CompilerGenerated]
	private void GMAFLMCPFAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AAKGACOPMGH : KKLJAMDAKLB<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static AAKGACOPMGH HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6C46020", Offset = "0x6C44620", VA = "0x186C46020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6C45CB0", Offset = "0x6C442B0", VA = "0x186C45CB0", Slot = "9")]
	public override string ALGEABNCNAB(bool NGALCNCLJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C45DA0", Offset = "0x6C443A0", VA = "0x186C45DA0", Slot = "10")]
	protected override bool GNOPHAHAJLF(string NGALCNCLJMG, [Out] bool FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C46100", Offset = "0x6C44700", VA = "0x186C46100")]
	public AAKGACOPMGH()
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
