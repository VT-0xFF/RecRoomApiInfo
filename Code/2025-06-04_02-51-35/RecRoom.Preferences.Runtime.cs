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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8360360", Offset = "0x835EB60", VA = "0x188360360", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum ODHEHCKHAII : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class HCPALPDLKIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void JFALMAGDBNC(IJCAEAPBADN HMJLOGJJPBH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8359B30", Offset = "0x8358330", VA = "0x188359B30")]
	private static void LMMPBENKGFK(IJCAEAPBADN HMJLOGJJPBH, JFALMAGDBNC GIEPBCEMONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8359BB0", Offset = "0x83583B0", VA = "0x188359BB0")]
	public static bool MHFDDLCNICD(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8359D10", Offset = "0x8358510", VA = "0x188359D10")]
	public static KGJAEDFHDPN NJJGJIKLKMG(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, string MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8359600", Offset = "0x8357E00", VA = "0x188359600")]
	public static KGJAEDFHDPN ANLCNNHALLD(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, int MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8359880", Offset = "0x8358080", VA = "0x188359880")]
	public static KGJAEDFHDPN JIJPAODLNKB(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, bool MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8359E60", Offset = "0x8358660", VA = "0x188359E60")]
	public static KGJAEDFHDPN ODPMPFABNLJ(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, float MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83599C0", Offset = "0x83581C0", VA = "0x1883599C0")]
	public static KGJAEDFHDPN KLDKIOBGONO(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, DateTime MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8359740", Offset = "0x8357F40", VA = "0x188359740")]
	public static KGJAEDFHDPN IDCKOCJDFGB(this IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, long MGONBEDEDON, [Optional] JFALMAGDBNC GIEPBCEMONN)
	{
		return default(KGJAEDFHDPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JIICNPHHAFI : FHHNFELFONK, IJCAEAPBADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PABNFFMODFB JPCNFHFHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> PMKJHFELHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> CHAJMJDIMIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> NPJJOHIEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x835C0F0", Offset = "0x835A8F0", VA = "0x18835C0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action PEDBBALMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x835C1A0", Offset = "0x835A9A0", VA = "0x18835C1A0")]
	[UnityEngine.Scripting.Preserve]
	public JIICNPHHAFI([FAPODKMFODF(null)] PABNFFMODFB JPCNFHFHNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x835BE50", Offset = "0x835A650", VA = "0x18835BE50")]
	private DirectoryInfo LPCLNMJJJLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x835A630", Offset = "0x8358E30", VA = "0x18835A630", Slot = "6")]
	public Task AJCENEMBGAI(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x835C080", Offset = "0x835A880", VA = "0x18835C080", Slot = "14")]
	public float NBKMMHCNNGA(string MNMCNOJCKAF, float GJPLADDCFJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x835A730", Offset = "0x8358F30", VA = "0x18835A730", Slot = "13")]
	public void AOBKOKICNFH(string MNMCNOJCKAF, bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x835BFC0", Offset = "0x835A7C0", VA = "0x18835BFC0", Slot = "12")]
	public bool MGLIHAFBMBP(string MNMCNOJCKAF, bool GJPLADDCFJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x835B470", Offset = "0x8359C70", VA = "0x18835B470", Slot = "10")]
	public int IAEMHOLDODD(string MNMCNOJCKAF, int GJPLADDCFJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x835B400", Offset = "0x8359C00", VA = "0x18835B400", Slot = "18")]
	public DateTime HIEMPPIALJL(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x835BD70", Offset = "0x835A570", VA = "0x18835BD70", Slot = "19")]
	public void KODMDGKGFBO(string MNMCNOJCKAF, DateTime MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x835AD80", Offset = "0x8359580", VA = "0x18835AD80", Slot = "15")]
	public void FBGEPLKEGDO(string MNMCNOJCKAF, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x835BF50", Offset = "0x835A750", VA = "0x18835BF50", Slot = "11")]
	public void MFMODMOJDDH(string MNMCNOJCKAF, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x835C130", Offset = "0x835A930", VA = "0x18835C130", Slot = "20")]
	public long NECIIMPGFKF(string EMGNLEIBFNM, long GJPLADDCFJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x835BDE0", Offset = "0x835A5E0", VA = "0x18835BDE0", Slot = "21")]
	public void LIJNBDOAJNN(string EMGNLEIBFNM, long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F75710", Offset = "0x2F73F10", VA = "0x182F75710", Slot = "22")]
	public T JLGHJAFIBII<T>(string EMGNLEIBFNM, T GJPLADDCFJL, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F75710", Offset = "0x2F73F10", VA = "0x182F75710", Slot = "23")]
	public void IDJDBFBMEJK<T>(string EMGNLEIBFNM, T MGONBEDEDON, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x835A7A0", Offset = "0x8358FA0", VA = "0x18835A7A0", Slot = "16")]
	public string CCOKPJIMHCN(string MNMCNOJCKAF, string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x835A6C0", Offset = "0x8358EC0", VA = "0x18835A6C0", Slot = "17")]
	public void ANIKLPBNCGG(string MNMCNOJCKAF, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x835ADF0", Offset = "0x83595F0", VA = "0x18835ADF0", Slot = "24")]
	public void GFEKNHBPLEC(string MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x835B4E0", Offset = "0x8359CE0", VA = "0x18835B4E0", Slot = "9")]
	public bool IMGKELNIDNO(string MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x835AA50", Offset = "0x8359250", VA = "0x18835AA50", Slot = "25")]
	public Task EMIODLJCACK(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x835B040", Offset = "0x8359840", VA = "0x18835B040")]
	private void HEJBBMKLEJL(DirectoryInfo NJGGPGLDMAK, string NLCAEKPBICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x835A850", Offset = "0x8359050", VA = "0x18835A850")]
	private static string DGPFOPFOCNC(string MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x835AF40", Offset = "0x8359740", VA = "0x18835AF40")]
	private static string GPCAFJHMHBD(byte[] LLNMEIMBBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A60610", Offset = "0x3A5EE10", VA = "0x183A60610")]
	private T CEJDCFFPPDB<T>(string EMGNLEIBFNM, T GJPLADDCFJL, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A618E0", Offset = "0x3A600E0", VA = "0x183A618E0")]
	private void NNLOAAEAPBJ<T>(string EMGNLEIBFNM, T MGONBEDEDON, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x835B570", Offset = "0x8359D70", VA = "0x18835B570")]
	private Dictionary<string, string> JCIEMPABOLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class FGLHPMFPONE
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8358F80", Offset = "0x8357780", VA = "0x188358F80")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void BGEJLCAAPFF(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class DDHPGMNPFAL : BDAAOBHOMAA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8358900", Offset = "0x8357100", VA = "0x188358900")]
	[UnityEngine.Scripting.Preserve]
	public DDHPGMNPFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BDAAOBHOMAA : FHHNFELFONK, IJCAEAPBADN, JCBEFDPGIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> CMNNGPOPBNO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PEDBBALMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83582A0", Offset = "0x8356AA0", VA = "0x1883582A0", Slot = "6")]
	public Task AJCENEMBGAI(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8358660", Offset = "0x8356E60", VA = "0x188358660", Slot = "9")]
	public bool IMGKELNIDNO(string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8358600", Offset = "0x8356E00", VA = "0x188358600", Slot = "10")]
	public int IAEMHOLDODD(string EMGNLEIBFNM, int GJPLADDCFJL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8358780", Offset = "0x8356F80", VA = "0x188358780", Slot = "11")]
	public void MFMODMOJDDH(string EMGNLEIBFNM, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83587E0", Offset = "0x8356FE0", VA = "0x1883587E0", Slot = "12")]
	public bool MGLIHAFBMBP(string EMGNLEIBFNM, bool GJPLADDCFJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8358390", Offset = "0x8356B90", VA = "0x188358390", Slot = "13")]
	public void AOBKOKICNFH(string EMGNLEIBFNM, bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8358840", Offset = "0x8357040", VA = "0x188358840", Slot = "14")]
	public float NBKMMHCNNGA(string EMGNLEIBFNM, float GJPLADDCFJL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83584E0", Offset = "0x8356CE0", VA = "0x1883584E0", Slot = "15")]
	public void FBGEPLKEGDO(string EMGNLEIBFNM, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83583F0", Offset = "0x8356BF0", VA = "0x1883583F0", Slot = "16")]
	public string CCOKPJIMHCN(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8358330", Offset = "0x8356B30", VA = "0x188358330", Slot = "17")]
	public void ANIKLPBNCGG(string EMGNLEIBFNM, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83585A0", Offset = "0x8356DA0", VA = "0x1883585A0", Slot = "18")]
	public DateTime HIEMPPIALJL(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83586C0", Offset = "0x8356EC0", VA = "0x1883586C0", Slot = "19")]
	public void KODMDGKGFBO(string EMGNLEIBFNM, DateTime MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83588A0", Offset = "0x83570A0", VA = "0x1883588A0", Slot = "20")]
	public long NECIIMPGFKF(string EMGNLEIBFNM, long GJPLADDCFJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8358720", Offset = "0x8356F20", VA = "0x188358720", Slot = "21")]
	public void LIJNBDOAJNN(string EMGNLEIBFNM, long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x372B5E0", Offset = "0x3729DE0", VA = "0x18372B5E0", Slot = "22")]
	public T JLGHJAFIBII<T>(string EMGNLEIBFNM, T GJPLADDCFJL, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x372B500", Offset = "0x3729D00", VA = "0x18372B500", Slot = "23")]
	public void IDJDBFBMEJK<T>(string EMGNLEIBFNM, T MGONBEDEDON, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x372ACC0", Offset = "0x37294C0", VA = "0x18372ACC0")]
	public T CEJDCFFPPDB<T>(string EMGNLEIBFNM, T GJPLADDCFJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x372B700", Offset = "0x3729F00", VA = "0x18372B700")]
	public void NNLOAAEAPBJ<T>(string EMGNLEIBFNM, T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8358540", Offset = "0x8356D40", VA = "0x188358540", Slot = "24")]
	public void GFEKNHBPLEC(string EMGNLEIBFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8358450", Offset = "0x8356C50", VA = "0x188358450", Slot = "25")]
	public Task EMIODLJCACK(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8358900", Offset = "0x8357100", VA = "0x188358900")]
	public BDAAOBHOMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class OOKPHJGIOFM<TParent> where TParent : IJCAEAPBADN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<OOKPHJGIOFM<TParent>> EACLACICEGL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x57583B0", Offset = "0x5756BB0", VA = "0x1857583B0")]
	protected OOKPHJGIOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CGGBONADGHB();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IKFAPBKANPB(string MNMCNOJCKAF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5757DE0", Offset = "0x57565E0", VA = "0x185757DE0")]
	public static void DHPKCNNHHAO(string MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5758030", Offset = "0x5756830", VA = "0x185758030")]
	public static void LAGEENGFGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IOCFCGBDKLC<TParent, TValue> : OOKPHJGIOFM<TParent> where TParent : IJCAEAPBADN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IOCFCGBDKLC<TParent, TValue> JMOEBDABFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> MOFDBHNAIFP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E91CA0", Offset = "0x4E904A0", VA = "0x184E91CA0")]
	public bool PLBNMDLFKAN(string MHLEAJOKLMG, [Out] TValue PNCGFMPKAMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4E91B10", Offset = "0x4E90310", VA = "0x184E91B10")]
	public void JBCEOANFOHM(string MHLEAJOKLMG, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4C92E10", Offset = "0x4C91610", VA = "0x184C92E10", Slot = "4")]
	protected override void CGGBONADGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4DDA120", Offset = "0x4DD8920", VA = "0x184DDA120", Slot = "5")]
	protected override void IKFAPBKANPB(string MHLEAJOKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4E91E40", Offset = "0x4E90640", VA = "0x184E91E40")]
	public IOCFCGBDKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IJCAEAPBADN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFKNGLBFEKD();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IMGKELNIDNO(string EMGNLEIBFNM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IAEMHOLDODD(string EMGNLEIBFNM, int GJPLADDCFJL = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFMODMOJDDH(string EMGNLEIBFNM, int MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MGLIHAFBMBP(string EMGNLEIBFNM, bool GJPLADDCFJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AOBKOKICNFH(string EMGNLEIBFNM, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float NBKMMHCNNGA(string EMGNLEIBFNM, float GJPLADDCFJL = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBGEPLKEGDO(string EMGNLEIBFNM, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string CCOKPJIMHCN(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ANIKLPBNCGG(string EMGNLEIBFNM, string MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime HIEMPPIALJL(string EMGNLEIBFNM, [Optional] DateTime FGCHOBJOEME);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KODMDGKGFBO(string EMGNLEIBFNM, DateTime FGCHOBJOEME);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long NECIIMPGFKF(string EMGNLEIBFNM, long GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LIJNBDOAJNN(string EMGNLEIBFNM, long MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T JLGHJAFIBII<T>(string EMGNLEIBFNM, T GJPLADDCFJL, HFHEOAFFOKE<T> BIPGCABEAOM);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IDJDBFBMEJK<T>(string EMGNLEIBFNM, T MGONBEDEDON, HFHEOAFFOKE<T> BIPGCABEAOM);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GFEKNHBPLEC(string EMGNLEIBFNM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task EMIODLJCACK([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FHHNFELFONK : IJCAEAPBADN
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PEDBBALMNAE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AJCENEMBGAI(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JCBEFDPGIIB : IJCAEAPBADN
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LPPLMPFCDIG : FHHNFELFONK, IJCAEAPBADN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct INBIEHKDFCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LPPLMPFCDIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x835A070", Offset = "0x8358870", VA = "0x18835A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x835A440", Offset = "0x8358C40", VA = "0x18835A440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IFJOCIHFIDI : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LPPLMPFCDIG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public IFJOCIHFIDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8359FB0", Offset = "0x83587B0", VA = "0x188359FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x835A020", Offset = "0x8358820", VA = "0x18835A020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PABNFFMODFB JPCNFHFHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool ENGACNPACIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool DIIDHHLKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OGAAENKMMFA ACKPLKCAIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NGLIALCAJHK ECEMLJDGKGK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PEDBBALMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8360190", Offset = "0x835E990", VA = "0x188360190")]
	[UnityEngine.Scripting.Preserve]
	public LPPLMPFCDIG([FAPODKMFODF(null)] PABNFFMODFB JPCNFHFHNML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x835F980", Offset = "0x835E180", VA = "0x18835F980", Slot = "6")]
	public Task AJCENEMBGAI(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DED0", Offset = "0x1C0C6D0", VA = "0x181C0DED0")]
	private static int OJBLFAAMIGI(bool MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x835FE90", Offset = "0x835E690", VA = "0x18835FE90", Slot = "9")]
	public bool IMGKELNIDNO(string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x835FE60", Offset = "0x835E660", VA = "0x18835FE60", Slot = "10")]
	public int IAEMHOLDODD(string EMGNLEIBFNM, int GJPLADDCFJL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8360070", Offset = "0x835E870", VA = "0x188360070", Slot = "11")]
	public void MFMODMOJDDH(string EMGNLEIBFNM, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x83600A0", Offset = "0x835E8A0", VA = "0x1883600A0", Slot = "12")]
	public bool MGLIHAFBMBP(string EMGNLEIBFNM, bool GJPLADDCFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x835FA40", Offset = "0x835E240", VA = "0x18835FA40", Slot = "13")]
	public void AOBKOKICNFH(string EMGNLEIBFNM, bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x83600D0", Offset = "0x835E8D0", VA = "0x1883600D0", Slot = "14")]
	public float NBKMMHCNNGA(string EMGNLEIBFNM, float GJPLADDCFJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x835FD30", Offset = "0x835E530", VA = "0x18835FD30", Slot = "15")]
	public void FBGEPLKEGDO(string EMGNLEIBFNM, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x835FDF0", Offset = "0x835E5F0", VA = "0x18835FDF0", Slot = "18")]
	public DateTime HIEMPPIALJL(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x835FF20", Offset = "0x835E720", VA = "0x18835FF20", Slot = "19")]
	public void KODMDGKGFBO(string EMGNLEIBFNM, DateTime FGCHOBJOEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8360100", Offset = "0x835E900", VA = "0x188360100", Slot = "20")]
	public long NECIIMPGFKF(string EMGNLEIBFNM, long GJPLADDCFJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8360000", Offset = "0x835E800", VA = "0x188360000", Slot = "21")]
	public void LIJNBDOAJNN(string EMGNLEIBFNM, long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE760", Offset = "0x3AACF60", VA = "0x183AAE760", Slot = "22")]
	public T JLGHJAFIBII<T>(string EMGNLEIBFNM, T GJPLADDCFJL, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE760", Offset = "0x3AACF60", VA = "0x183AAE760", Slot = "23")]
	public void IDJDBFBMEJK<T>(string EMGNLEIBFNM, T MGONBEDEDON, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF1A0", Offset = "0x3AAD9A0", VA = "0x183AAF1A0")]
	private T MMPGNBOFMOJ<T>(string EMGNLEIBFNM, T GJPLADDCFJL, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE8F0", Offset = "0x3AAD0F0", VA = "0x183AAE8F0")]
	private void JGNGDNFOJND<T>(string EMGNLEIBFNM, T MGONBEDEDON, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x835FB10", Offset = "0x835E310", VA = "0x18835FB10", Slot = "16")]
	public string CCOKPJIMHCN(string EMGNLEIBFNM, string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x835FA10", Offset = "0x835E210", VA = "0x18835FA10", Slot = "17")]
	public void ANIKLPBNCGG(string EMGNLEIBFNM, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8360170", Offset = "0x835E970", VA = "0x188360170")]
	private void PLDJBLNNFEG(string EMGNLEIBFNM, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x835FC20", Offset = "0x835E420", VA = "0x18835FC20")]
	private string DBIPOACINEH(string EMGNLEIBFNM, string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x835FD60", Offset = "0x835E560", VA = "0x18835FD60", Slot = "24")]
	public void GFEKNHBPLEC(string EMGNLEIBFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x835FA70", Offset = "0x835E270", VA = "0x18835FA70")]
	private string CAAEJGCDJLK(string MNMCNOJCKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x835FC40", Offset = "0x835E440", VA = "0x18835FC40", Slot = "25")]
	[AsyncStateMachine(typeof(INBIEHKDFCJ))]
	public Task EMIODLJCACK(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x835FBA0", Offset = "0x835E3A0", VA = "0x18835FBA0")]
	[IteratorStateMachine(typeof(IFJOCIHFIDI))]
	private IEnumerator<ENGFNCJEKHI> CPEMGLCDJPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x835FB40", Offset = "0x835E340", VA = "0x18835FB40")]
	private void COBEBPDNNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x835FF90", Offset = "0x835E790", VA = "0x18835FF90")]
	private void LCHLHAJKCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x835FEB0", Offset = "0x835E6B0", VA = "0x18835FEB0")]
	private void JAIHLGMBGAK(bool IJKMCOHGFJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AIJLHEDLLHJ : FHHNFELFONK, IJCAEAPBADN
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Dictionary<string, string> CHAJMJDIMIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HFNFNBOGCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string DEGBBHJCEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8357FE0", Offset = "0x83567E0", VA = "0x188357FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> NPJJOHIEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83581F0", Offset = "0x83569F0", VA = "0x1883581F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action PEDBBALMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	[UnityEngine.Scripting.Preserve]
	public AIJLHEDLLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x83574D0", Offset = "0x8355CD0", VA = "0x1883574D0", Slot = "6")]
	public Task AJCENEMBGAI(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8358180", Offset = "0x8356980", VA = "0x188358180", Slot = "14")]
	public float NBKMMHCNNGA(string MNMCNOJCKAF, float GJPLADDCFJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8357600", Offset = "0x8355E00", VA = "0x188357600", Slot = "13")]
	public void AOBKOKICNFH(string MNMCNOJCKAF, bool MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x83580C0", Offset = "0x83568C0", VA = "0x1883580C0", Slot = "12")]
	public bool MGLIHAFBMBP(string MNMCNOJCKAF, bool GJPLADDCFJL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8357B20", Offset = "0x8356320", VA = "0x188357B20", Slot = "10")]
	public int IAEMHOLDODD(string MNMCNOJCKAF, int GJPLADDCFJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8357AB0", Offset = "0x83562B0", VA = "0x188357AB0", Slot = "18")]
	public DateTime HIEMPPIALJL(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8357F00", Offset = "0x8356700", VA = "0x188357F00", Slot = "19")]
	public void KODMDGKGFBO(string MNMCNOJCKAF, DateTime MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8357980", Offset = "0x8356180", VA = "0x188357980", Slot = "15")]
	public void FBGEPLKEGDO(string MNMCNOJCKAF, float MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8358050", Offset = "0x8356850", VA = "0x188358050", Slot = "11")]
	public void MFMODMOJDDH(string MNMCNOJCKAF, int MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8358230", Offset = "0x8356A30", VA = "0x188358230", Slot = "20")]
	public long NECIIMPGFKF(string EMGNLEIBFNM, long GJPLADDCFJL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8357F70", Offset = "0x8356770", VA = "0x188357F70", Slot = "21")]
	public void LIJNBDOAJNN(string EMGNLEIBFNM, long MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F75710", Offset = "0x2F73F10", VA = "0x182F75710", Slot = "22")]
	public T JLGHJAFIBII<T>(string EMGNLEIBFNM, T GJPLADDCFJL, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F75710", Offset = "0x2F73F10", VA = "0x182F75710", Slot = "23")]
	public void IDJDBFBMEJK<T>(string EMGNLEIBFNM, T MGONBEDEDON, HFHEOAFFOKE<T> BIPGCABEAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8357670", Offset = "0x8355E70", VA = "0x188357670", Slot = "16")]
	public string CCOKPJIMHCN(string MNMCNOJCKAF, string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8357560", Offset = "0x8355D60", VA = "0x188357560", Slot = "17")]
	public void ANIKLPBNCGG(string MNMCNOJCKAF, string MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x83579F0", Offset = "0x83561F0", VA = "0x1883579F0", Slot = "24")]
	public void GFEKNHBPLEC(string MNMCNOJCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8357B90", Offset = "0x8356390", VA = "0x188357B90", Slot = "9")]
	public bool IMGKELNIDNO(string MNMCNOJCKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8357720", Offset = "0x8355F20", VA = "0x188357720", Slot = "25")]
	public Task EMIODLJCACK(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x41EB9D0", Offset = "0x41EA1D0", VA = "0x1841EB9D0")]
	private T CEJDCFFPPDB<T>(string EMGNLEIBFNM, T GJPLADDCFJL, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x41ECCA0", Offset = "0x41EB4A0", VA = "0x1841ECCA0")]
	private void NNLOAAEAPBJ<T>(string EMGNLEIBFNM, T MGONBEDEDON, [Optional] HFHEOAFFOKE<T> IJOAAFCHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8357C20", Offset = "0x8356420", VA = "0x188357C20")]
	private Dictionary<string, string> JCIEMPABOLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NHOAHDCMOCH
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action PEDBBALMNAE;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFKNGLBFEKD();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task IHKNEJKDEJD(long PGMFMDDAFLG);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NEEMBMGCOJD(ODHEHCKHAII CHOBNPOJIPF = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCBKFAHADOG(string EMGNLEIBFNM, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDNJPBGOEOJ(string EMGNLEIBFNM, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string OFBCDEIMENB(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KGJAEDFHDPN FEDHDGPMOEP(string EMGNLEIBFNM, string MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int AGOCJLFAHAH(string EMGNLEIBFNM, int GJPLADDCFJL = 0, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KGJAEDFHDPN FAIFPOELADL(string EMGNLEIBFNM, int MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FKGGOFIICBL(string EMGNLEIBFNM, bool GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KGJAEDFHDPN GOOLHMDAMMI(string EMGNLEIBFNM, bool MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float BKGDOCDLMCL(string EMGNLEIBFNM, float GJPLADDCFJL = 0f, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KGJAEDFHDPN KNKLNBABEPJ(string EMGNLEIBFNM, float MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime IHKGGDCIGAI(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KGJAEDFHDPN JPMIPAGOKAA(string EMGNLEIBFNM, DateTime MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long MMGAPGJNPNB(string EMGNLEIBFNM, long GJPLADDCFJL = 0L, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KGJAEDFHDPN BFMPJNCPHMF(string EMGNLEIBFNM, long MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T LIGMEIBGHEB<T>(string EMGNLEIBFNM, [Optional] T GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KGJAEDFHDPN MKEIGIIHBDJ<T>(string EMGNLEIBFNM, T MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OCHHGIFCKKB(string EMGNLEIBFNM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KPJAFFDICFD(string EMGNLEIBFNM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string FMAKIMHMIOM(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KGJAEDFHDPN GBKFGIEFLBA(string EMGNLEIBFNM, string MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int IMJEEPMNDIO(string EMGNLEIBFNM, int GJPLADDCFJL = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	KGJAEDFHDPN EANLIDFFMKP(string EMGNLEIBFNM, int MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PALAKPBKDLM(string EMGNLEIBFNM, bool GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	KGJAEDFHDPN GHIBMIKKGHG(string EMGNLEIBFNM, bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float LJFCCANGBBB(string EMGNLEIBFNM, float GJPLADDCFJL = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	KGJAEDFHDPN BBGNCHJKEDM(string EMGNLEIBFNM, float MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime DAGMNCKHILO(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	KGJAEDFHDPN PLPIMMCFAKC(string EMGNLEIBFNM, DateTime MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long KECODDDNNGH(string EMGNLEIBFNM, long GJPLADDCFJL = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	KGJAEDFHDPN HMMCEFHMHOO(string EMGNLEIBFNM, long MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CIIEMFEKBKN<T>(HFHEOAFFOKE<T> BIPGCABEAOM, [Optional] IEqualityComparer<T> JPBEDJHBGMM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PGKMAGHNBCJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable IKOOPLMFDCO();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PGKCBEAMGOB(float AFBFHAPCPPE);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task COBEBPDNNLH([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KGJAEDFHDPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LFONMHANHFM : NHOAHDCMOCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class BIDOAJHKPLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<BIDOAJHKPLP> ADHHBCNNPIN;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8358CD0", Offset = "0x83574D0", VA = "0x188358CD0")]
		public static void LAGEENGFGBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CGGBONADGHB();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		protected BIDOAJHKPLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class MLLBEOJCCJC<T> : BIDOAJHKPLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MLLBEOJCCJC<T> HPECEAELCLK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HFHEOAFFOKE<T> BOFLFOEGILN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> EALJIPJIDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HBJHCHOLHPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4691880", Offset = "0x4690080", VA = "0x184691880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x554D7C0", Offset = "0x554BFC0", VA = "0x18554D7C0")]
		private MLLBEOJCCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x554D4C0", Offset = "0x554BCC0", VA = "0x18554D4C0")]
		public void KELFLPPCOLM(HFHEOAFFOKE<T> IJOAAFCHPBK, [Optional] IEqualityComparer<T> JPBEDJHBGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x554D0B0", Offset = "0x554B8B0", VA = "0x18554D0B0", Slot = "4")]
		public override void CGGBONADGHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class CCBEDJCNIDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly LFONMHANHFM JDCAKKGPPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object HKKIHDFPABN;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8358ED0", Offset = "0x83576D0", VA = "0x188358ED0")]
		public CCBEDJCNIDC(LFONMHANHFM JDCAKKGPPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8358EA0", Offset = "0x83576A0", VA = "0x188358EA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct BGDLFEFEOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LFONMHANHFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8358990", Offset = "0x8357190", VA = "0x188358990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8358C70", Offset = "0x8357470", VA = "0x188358C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct IOJIHOOEGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public LFONMHANHFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public IJCAEAPBADN backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x835A4A0", Offset = "0x8358CA0", VA = "0x18835A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct GNCOCLJHAAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LFONMHANHFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x83590D0", Offset = "0x83578D0", VA = "0x1883590D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x83595A0", Offset = "0x8357DA0", VA = "0x1883595A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JKCCCNEIGMH : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ENGFNCJEKHI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LFONMHANHFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public JKCCCNEIGMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x835C240", Offset = "0x835AA40", VA = "0x18835C240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x835C2D0", Offset = "0x835AAD0", VA = "0x18835C2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FHHNFELFONK OONFKMGLKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FHHNFELFONK NABPGEHMOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JCBEFDPGIIB HCNCPHIMOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OGAAENKMMFA ACKPLKCAIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HCPALPDLKIJ.JFALMAGDBNC GIEPBCEMONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BFPHHCAGGHH NIOJDPIJLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<IJCAEAPBADN> NIOOMOGBIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task OHHKFMEOMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> EHBCAGGFKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NGLIALCAJHK DPDLEPDDPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object BDIJNDCMAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object HBNBKKIHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long CHPAOBLMHLI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool MIHENFBAEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x835CEA0", Offset = "0x835B6A0", VA = "0x18835CEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource BPFDEPACKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PEDBBALMNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x835EC40", Offset = "0x835D440", VA = "0x18835EC40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x835CEC0", Offset = "0x835B6C0", VA = "0x18835CEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x835DAB0", Offset = "0x835C2B0", VA = "0x18835DAB0")]
	[NOOFMBJKOEL.LBENCLOPAFN]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x835F5B0", Offset = "0x835DDB0", VA = "0x18835F5B0")]
	[UnityEngine.Scripting.Preserve]
	public LFONMHANHFM([FAPODKMFODF("Disk")] FHHNFELFONK OONFKMGLKMB, [FAPODKMFODF("Cloud")] FHHNFELFONK NABPGEHMOCC, [FAPODKMFODF(null)] JCBEFDPGIIB HCNCPHIMOCG, [FAPODKMFODF(null)] OGAAENKMMFA ACKPLKCAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x835D150", Offset = "0x835B950", VA = "0x18835D150", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x835D4A0", Offset = "0x835BCA0", VA = "0x18835D4A0")]
	private void FCFAJEGCLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x835DE10", Offset = "0x835C610", VA = "0x18835DE10", Slot = "6")]
	public void HFKNGLBFEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x835E0F0", Offset = "0x835C8F0", VA = "0x18835E0F0", Slot = "7")]
	public Task IHKNEJKDEJD(long PGMFMDDAFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x835C9A0", Offset = "0x835B1A0", VA = "0x18835C9A0")]
	[AsyncStateMachine(typeof(BGDLFEFEOHF))]
	private Task ANIEHLDNOEJ(long PGMFMDDAFLG, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x835F210", Offset = "0x835DA10", VA = "0x18835F210")]
	private void OHHLILMBEAB(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x835E670", Offset = "0x835CE70", VA = "0x18835E670")]
	private void JMGENFBNEEL(object KAJENDFCCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x835ED80", Offset = "0x835D580", VA = "0x18835ED80")]
	private string NCJPHFNMKIO(string GJFPMGKMIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x835DE80", Offset = "0x835C680", VA = "0x18835DE80")]
	private void HHHOAJKELLA(ODHEHCKHAII CHOBNPOJIPF, string MNMCNOJCKAF, [Out] FHHNFELFONK HMJLOGJJPBH, [Out] string OCMFEKPJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x835E5F0", Offset = "0x835CDF0", VA = "0x18835E5F0")]
	private FHHNFELFONK JKEGCAKMLCN(ODHEHCKHAII CHOBNPOJIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x835EDE0", Offset = "0x835D5E0", VA = "0x18835EDE0", Slot = "8")]
	public bool NEEMBMGCOJD(ODHEHCKHAII CHOBNPOJIPF = ODHEHCKHAII.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x835D400", Offset = "0x835BC00", VA = "0x18835D400", Slot = "9")]
	public bool FCBKFAHADOG(string EMGNLEIBFNM, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x835D900", Offset = "0x835C100", VA = "0x18835D900", Slot = "10")]
	public bool GDNJPBGOEOJ(string EMGNLEIBFNM, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x835EF00", Offset = "0x835D700", VA = "0x18835EF00", Slot = "11")]
	public string OFBCDEIMENB(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x835D630", Offset = "0x835BE30", VA = "0x18835D630", Slot = "12")]
	public KGJAEDFHDPN FEDHDGPMOEP(string EMGNLEIBFNM, string MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x835C7B0", Offset = "0x835AFB0", VA = "0x18835C7B0", Slot = "13")]
	public int AGOCJLFAHAH(string EMGNLEIBFNM, int GJPLADDCFJL = 0, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x835D290", Offset = "0x835BA90", VA = "0x18835D290", Slot = "14")]
	public KGJAEDFHDPN FAIFPOELADL(string EMGNLEIBFNM, int MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x835D7B0", Offset = "0x835BFB0", VA = "0x18835D7B0", Slot = "15")]
	public bool FKGGOFIICBL(string EMGNLEIBFNM, bool GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x835DB20", Offset = "0x835C320", VA = "0x18835DB20", Slot = "16")]
	public KGJAEDFHDPN GOOLHMDAMMI(string EMGNLEIBFNM, bool MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x835CDF0", Offset = "0x835B5F0", VA = "0x18835CDF0", Slot = "17")]
	public float BKGDOCDLMCL(string EMGNLEIBFNM, float GJPLADDCFJL = 0f, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x835EA40", Offset = "0x835D240", VA = "0x18835EA40", Slot = "18")]
	public KGJAEDFHDPN KNKLNBABEPJ(string EMGNLEIBFNM, float MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x835E050", Offset = "0x835C850", VA = "0x18835E050", Slot = "19")]
	public DateTime IHKGGDCIGAI(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x835E6F0", Offset = "0x835CEF0", VA = "0x18835E6F0", Slot = "20")]
	public KGJAEDFHDPN JPMIPAGOKAA(string EMGNLEIBFNM, DateTime MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x835ECE0", Offset = "0x835D4E0", VA = "0x18835ECE0", Slot = "21")]
	public long MMGAPGJNPNB(string EMGNLEIBFNM, long GJPLADDCFJL = 0L, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x835CB40", Offset = "0x835B340", VA = "0x18835CB40", Slot = "22")]
	public KGJAEDFHDPN BFMPJNCPHMF(string EMGNLEIBFNM, long MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5DC0", Offset = "0x3AA45C0", VA = "0x183AA5DC0", Slot = "23")]
	public T LIGMEIBGHEB<T>(string EMGNLEIBFNM, [Optional] T GJPLADDCFJL, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5DC0", Offset = "0x3AA45C0", VA = "0x183AA5DC0", Slot = "24")]
	public KGJAEDFHDPN MKEIGIIHBDJ<T>(string EMGNLEIBFNM, T MGONBEDEDON, ODHEHCKHAII MIGLBNODFIA = ODHEHCKHAII.CLOUD)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x835EEA0", Offset = "0x835D6A0", VA = "0x18835EEA0", Slot = "25")]
	public bool OCHHGIFCKKB(string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x835EBC0", Offset = "0x835D3C0", VA = "0x18835EBC0", Slot = "26")]
	public bool KPJAFFDICFD(string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x835D860", Offset = "0x835C060", VA = "0x18835D860", Slot = "27")]
	public string FMAKIMHMIOM(string EMGNLEIBFNM, [Optional] string GJPLADDCFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x835D8D0", Offset = "0x835C0D0", VA = "0x18835D8D0", Slot = "28")]
	public KGJAEDFHDPN GBKFGIEFLBA(string EMGNLEIBFNM, string MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x835E3A0", Offset = "0x835CBA0", VA = "0x18835E3A0", Slot = "29")]
	public int IMJEEPMNDIO(string EMGNLEIBFNM, int GJPLADDCFJL = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x835D190", Offset = "0x835B990", VA = "0x18835D190", Slot = "30")]
	public KGJAEDFHDPN EANLIDFFMKP(string EMGNLEIBFNM, int MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x835F230", Offset = "0x835DA30", VA = "0x18835F230", Slot = "31")]
	public bool PALAKPBKDLM(string EMGNLEIBFNM, bool GJPLADDCFJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x835DA80", Offset = "0x835C280", VA = "0x18835DA80", Slot = "32")]
	public KGJAEDFHDPN GHIBMIKKGHG(string EMGNLEIBFNM, bool MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x835EBD0", Offset = "0x835D3D0", VA = "0x18835EBD0", Slot = "33")]
	public float LJFCCANGBBB(string EMGNLEIBFNM, float GJPLADDCFJL = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x835CAB0", Offset = "0x835B2B0", VA = "0x18835CAB0", Slot = "34")]
	public KGJAEDFHDPN BBGNCHJKEDM(string EMGNLEIBFNM, float MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x835D050", Offset = "0x835B850", VA = "0x18835D050", Slot = "35")]
	public DateTime DAGMNCKHILO(string EMGNLEIBFNM, [Optional] DateTime GJPLADDCFJL)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x835F580", Offset = "0x835DD80", VA = "0x18835F580", Slot = "36")]
	public KGJAEDFHDPN PLPIMMCFAKC(string EMGNLEIBFNM, DateTime MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x835E9D0", Offset = "0x835D1D0", VA = "0x18835E9D0", Slot = "37")]
	public long KECODDDNNGH(string EMGNLEIBFNM, long GJPLADDCFJL = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x835E020", Offset = "0x835C820", VA = "0x18835E020", Slot = "38")]
	public KGJAEDFHDPN HMMCEFHMHOO(string EMGNLEIBFNM, long MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x835CAE0", Offset = "0x835B2E0", VA = "0x18835CAE0")]
	private bool BDKKAOKDLIG(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x835F2A0", Offset = "0x835DAA0", VA = "0x18835F2A0")]
	private bool PGAHPJHHJGE(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x835DCC0", Offset = "0x835C4C0", VA = "0x18835DCC0")]
	private KGJAEDFHDPN HFJCAFNHNBM(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, string MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x835E890", Offset = "0x835D090", VA = "0x18835E890")]
	private KGJAEDFHDPN KAEMDBELEHB(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, int MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x835C860", Offset = "0x835B060", VA = "0x18835C860")]
	private KGJAEDFHDPN AIDPALNCHLG(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, bool MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x835D4F0", Offset = "0x835BCF0", VA = "0x18835D4F0")]
	private KGJAEDFHDPN FCJFDHCKCNM(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, float MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x835F410", Offset = "0x835DC10", VA = "0x18835F410")]
	private KGJAEDFHDPN PKJLDAOHPNJ(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, DateTime MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x835CCB0", Offset = "0x835B4B0", VA = "0x18835CCB0")]
	private KGJAEDFHDPN BHHLMALGJGF(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, long MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5860", Offset = "0x3AA4060", VA = "0x183AA5860")]
	private T FDODHCIMFKG<T>(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, T GJPLADDCFJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4C20", Offset = "0x3AA3420", VA = "0x183AA4C20")]
	private KGJAEDFHDPN APDHIBOMLCK<T>(IJCAEAPBADN HMJLOGJJPBH, string EMGNLEIBFNM, T MGONBEDEDON)
	{
		return default(KGJAEDFHDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3AA57B0", Offset = "0x3AA3FB0", VA = "0x183AA57B0", Slot = "39")]
	public void CIIEMFEKBKN<T>(HFHEOAFFOKE<T> BIPGCABEAOM, [Optional] IEqualityComparer<T> JPBEDJHBGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6120", Offset = "0x3AA4920", VA = "0x183AA6120", Slot = "40")]
	public void PGKMAGHNBCJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x835D1C0", Offset = "0x835B9C0", VA = "0x18835D1C0")]
	[AsyncStateMachine(typeof(IOJIHOOEGKL))]
	private void EMIODLJCACK(IJCAEAPBADN KDIMPBMMMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x835CF60", Offset = "0x835B760", VA = "0x18835CF60", Slot = "43")]
	[AsyncStateMachine(typeof(GNCOCLJHAAO))]
	public Task COBEBPDNNLH([Optional] CancellationToken KAJENDFCCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x835E410", Offset = "0x835CC10", VA = "0x18835E410")]
	private void JEIKCOHPFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x835E2C0", Offset = "0x835CAC0", VA = "0x18835E2C0", Slot = "41")]
	public IDisposable IKOOPLMFDCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x835F400", Offset = "0x835DC00", VA = "0x18835F400", Slot = "42")]
	public void PGKCBEAMGOB(float AFBFHAPCPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x835EFA0", Offset = "0x835D7A0", VA = "0x18835EFA0")]
	private void OGEAMHGENLF(float MIGNCGGNCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x835D0C0", Offset = "0x835B8C0", VA = "0x18835D0C0")]
	[IteratorStateMachine(typeof(JKCCCNEIGMH))]
	private IEnumerator<ENGFNCJEKHI> DEGDEDGNCPD(float AFBFHAPCPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x835DC90", Offset = "0x835C490", VA = "0x18835DC90")]
	[CompilerGenerated]
	private void HDOBOLEAOOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JLDLOAGMEBF : ENJIDLEHKLE<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JLDLOAGMEBF HPECEAELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x835C320", Offset = "0x835AB20", VA = "0x18835C320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x835C370", Offset = "0x835AB70", VA = "0x18835C370", Slot = "9")]
	public override string GJCNJFECIPF(bool FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x835C460", Offset = "0x835AC60", VA = "0x18835C460", Slot = "10")]
	protected override bool KDCGPHJJMAE(string FNFJALHKEGF, [Out] bool MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x835C770", Offset = "0x835AF70", VA = "0x18835C770")]
	public JLDLOAGMEBF()
	{
	}
}
namespace Cpp2IlInjected
{
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
}
