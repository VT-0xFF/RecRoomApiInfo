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
		[Cpp2IlInjected.Address(RVA = "0x86E4BA0", Offset = "0x86E35A0", VA = "0x1886E4BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum LNHOIDKFLNK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal static class HGJLOBNNGMF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal delegate void HCFGDIIOFBD(OMNIELDOADL GLGOOBDBOJB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86DE120", Offset = "0x86DCB20", VA = "0x1886DE120")]
	private static void DBAHHMHINDL(OMNIELDOADL GLGOOBDBOJB, HCFGDIIOFBD LDCCODCNOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86DE6D0", Offset = "0x86DD0D0", VA = "0x1886DE6D0")]
	public static bool PLMGBONGGIJ(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86DE2F0", Offset = "0x86DCCF0", VA = "0x1886DE2F0")]
	public static CACOKDJKCJH EBMNFCIKFNL(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, string PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86DDFE0", Offset = "0x86DC9E0", VA = "0x1886DDFE0")]
	public static CACOKDJKCJH ALKFCNHGKKC(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, int PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86DE1A0", Offset = "0x86DCBA0", VA = "0x1886DE1A0")]
	public static CACOKDJKCJH DJLJHPJICFG(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, bool PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x86DE580", Offset = "0x86DCF80", VA = "0x1886DE580")]
	public static CACOKDJKCJH MKOOIIKCDCP(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, float PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86DDE70", Offset = "0x86DC870", VA = "0x1886DDE70")]
	public static CACOKDJKCJH AJHGIOMGIDN(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, DateTime PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86DE440", Offset = "0x86DCE40", VA = "0x1886DE440")]
	public static CACOKDJKCJH FPHHDIDHGMO(this OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, long PDKJBMPOMNC, [Optional] HCFGDIIOFBD LDCCODCNOAK)
	{
		return default(CACOKDJKCJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LELEOMHGDFK : FGKMLIGOOPI, OMNIELDOADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OKMKBKNBGDB PKNFGLMCONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> ELADKKFLMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> IOPIPHHCNGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> FFNPBKFFNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86DF7D0", Offset = "0x86DE1D0", VA = "0x1886DF7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GKPOPFKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86E0970", Offset = "0x86DF370", VA = "0x1886E0970")]
	[UnityEngine.Scripting.Preserve]
	public LELEOMHGDFK([LNLOHEINMEO(null)] OKMKBKNBGDB PKNFGLMCONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86DF320", Offset = "0x86DDD20", VA = "0x1886DF320")]
	private DirectoryInfo IKHPPALIFFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86DF010", Offset = "0x86DDA10", VA = "0x1886DF010", Slot = "6")]
	public Task ELDPNGEHFNF(long MCKDMADFBID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86DF220", Offset = "0x86DDC20", VA = "0x1886DF220", Slot = "14")]
	public float IBMLFBEBEJA(string LNBCHJPEENA, float KKCMINIPIBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86DF420", Offset = "0x86DDE20", VA = "0x1886DF420", Slot = "13")]
	public void JDOOPLIGEHB(string LNBCHJPEENA, bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86DF150", Offset = "0x86DDB50", VA = "0x1886DF150", Slot = "12")]
	public bool HODKOHLDACP(string LNBCHJPEENA, bool KKCMINIPIBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86E0090", Offset = "0x86DEA90", VA = "0x1886E0090", Slot = "10")]
	public int NJDDPOFMJHK(string LNBCHJPEENA, int KKCMINIPIBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86DEFA0", Offset = "0x86DD9A0", VA = "0x1886DEFA0", Slot = "18")]
	public DateTime EDKCHAKJFJI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86E0100", Offset = "0x86DEB00", VA = "0x1886E0100", Slot = "19")]
	public void NLDDGEFNEOD(string LNBCHJPEENA, DateTime PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86DEE50", Offset = "0x86DD850", VA = "0x1886DEE50", Slot = "15")]
	public void DBGDBJCAEOC(string LNBCHJPEENA, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x86DEEC0", Offset = "0x86DD8C0", VA = "0x1886DEEC0", Slot = "11")]
	public void DDDIDIJLPPL(string LNBCHJPEENA, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x86DEDE0", Offset = "0x86DD7E0", VA = "0x1886DEDE0", Slot = "20")]
	public long CEHJJBBJMNO(string GGDGFENODPM, long KKCMINIPIBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86DFC60", Offset = "0x86DE660", VA = "0x1886DFC60", Slot = "21")]
	public void MGOJPHDPNOA(string GGDGFENODPM, long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x31C7F20", Offset = "0x31C6920", VA = "0x1831C7F20", Slot = "22")]
	public T OLLJBNOPPFM<T>(string GGDGFENODPM, T KKCMINIPIBD, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x31C7250", Offset = "0x31C5C50", VA = "0x1831C7250", Slot = "23")]
	public void EJOOPBGHNFA<T>(string GGDGFENODPM, T PDKJBMPOMNC, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86DF0A0", Offset = "0x86DDAA0", VA = "0x1886DF0A0", Slot = "16")]
	public string GMGJFPIHJPF(string LNBCHJPEENA, string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86DEF30", Offset = "0x86DD930", VA = "0x1886DEF30", Slot = "17")]
	public void EAIJDGGFHLB(string LNBCHJPEENA, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86DF810", Offset = "0x86DE210", VA = "0x1886DF810", Slot = "24")]
	public void JPMFINDLAKI(string LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86DF290", Offset = "0x86DDC90", VA = "0x1886DF290", Slot = "9")]
	public bool IIFMACOKIKJ(string LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86DF490", Offset = "0x86DDE90", VA = "0x1886DF490", Slot = "25")]
	public Task JFDGFKKFPMF(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86DFCD0", Offset = "0x86DE6D0", VA = "0x1886DFCD0")]
	private void NFAKKCCGKEK(DirectoryInfo DLEOFMCALOP, string PFPJAJCNMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86DF960", Offset = "0x86DE360", VA = "0x1886DF960")]
	private static string KNEDOPAIDDK(string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86DFB60", Offset = "0x86DE560", VA = "0x1886DFB60")]
	private static string LDLKHJENCKG(byte[] LHALFHPGBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AC00", Offset = "0x3D39600", VA = "0x183D3AC00")]
	private T DHBICMHDGKM<T>(string GGDGFENODPM, T KKCMINIPIBD, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D3BD20", Offset = "0x3D3A720", VA = "0x183D3BD20")]
	private void MAAIKGLMNNO<T>(string GGDGFENODPM, T PDKJBMPOMNC, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86E0170", Offset = "0x86DEB70", VA = "0x1886E0170")]
	private Dictionary<string, string> ONFNCMKGFIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class BCANGALBNDD
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86DBC50", Offset = "0x86DA650", VA = "0x1886DBC50")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA JBOIKIICKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MJAEKCMLLCB : LOFOHEELKCK
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86E1130", Offset = "0x86DFB30", VA = "0x1886E1130")]
	[UnityEngine.Scripting.Preserve]
	public MJAEKCMLLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LOFOHEELKCK : FGKMLIGOOPI, OMNIELDOADL, JJKJDHLMKPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> IKLKOEOIFML;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GKPOPFKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86E0CB0", Offset = "0x86DF6B0", VA = "0x1886E0CB0", Slot = "6")]
	public Task ELDPNGEHFNF(long MCKDMADFBID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86E0E60", Offset = "0x86DF860", VA = "0x1886E0E60", Slot = "9")]
	public bool IIFMACOKIKJ(string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86E1070", Offset = "0x86DFA70", VA = "0x1886E1070", Slot = "10")]
	public int NJDDPOFMJHK(string GGDGFENODPM, int KKCMINIPIBD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86E0B90", Offset = "0x86DF590", VA = "0x1886E0B90", Slot = "11")]
	public void DDDIDIJLPPL(string GGDGFENODPM, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86E0DA0", Offset = "0x86DF7A0", VA = "0x1886E0DA0", Slot = "12")]
	public bool HODKOHLDACP(string GGDGFENODPM, bool KKCMINIPIBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86E0EC0", Offset = "0x86DF8C0", VA = "0x1886E0EC0", Slot = "13")]
	public void JDOOPLIGEHB(string GGDGFENODPM, bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86E0E00", Offset = "0x86DF800", VA = "0x1886E0E00", Slot = "14")]
	public float IBMLFBEBEJA(string GGDGFENODPM, float KKCMINIPIBD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86E0B30", Offset = "0x86DF530", VA = "0x1886E0B30", Slot = "15")]
	public void DBGDBJCAEOC(string GGDGFENODPM, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86E0D40", Offset = "0x86DF740", VA = "0x1886E0D40", Slot = "16")]
	public string GMGJFPIHJPF(string GGDGFENODPM, [Optional] string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x86E0BF0", Offset = "0x86DF5F0", VA = "0x1886E0BF0", Slot = "17")]
	public void EAIJDGGFHLB(string GGDGFENODPM, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86E0C50", Offset = "0x86DF650", VA = "0x1886E0C50", Slot = "18")]
	public DateTime EDKCHAKJFJI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x86E10D0", Offset = "0x86DFAD0", VA = "0x1886E10D0", Slot = "19")]
	public void NLDDGEFNEOD(string GGDGFENODPM, DateTime PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86E0AD0", Offset = "0x86DF4D0", VA = "0x1886E0AD0", Slot = "20")]
	public long CEHJJBBJMNO(string GGDGFENODPM, long KKCMINIPIBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86E1010", Offset = "0x86DFA10", VA = "0x1886E1010", Slot = "21")]
	public void MGOJPHDPNOA(string GGDGFENODPM, long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D80F50", Offset = "0x3D7F950", VA = "0x183D80F50", Slot = "22")]
	public T OLLJBNOPPFM<T>(string GGDGFENODPM, T KKCMINIPIBD, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D809C0", Offset = "0x3D7F3C0", VA = "0x183D809C0", Slot = "23")]
	public void EJOOPBGHNFA<T>(string GGDGFENODPM, T PDKJBMPOMNC, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D80180", Offset = "0x3D7EB80", VA = "0x183D80180")]
	public T DHBICMHDGKM<T>(string GGDGFENODPM, T KKCMINIPIBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D80A60", Offset = "0x3D7F460", VA = "0x183D80A60")]
	public void MAAIKGLMNNO<T>(string GGDGFENODPM, T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86E0FB0", Offset = "0x86DF9B0", VA = "0x1886E0FB0", Slot = "24")]
	public void JPMFINDLAKI(string GGDGFENODPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86E0F20", Offset = "0x86DF920", VA = "0x1886E0F20", Slot = "25")]
	public Task JFDGFKKFPMF(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86E1130", Offset = "0x86DFB30", VA = "0x1886E1130")]
	public LOFOHEELKCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class MPICKNFKHBC<TParent> where TParent : OMNIELDOADL
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<MPICKNFKHBC<TParent>> DCMKEFGIPDO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x584E0B0", Offset = "0x584CAB0", VA = "0x18584E0B0")]
	protected MPICKNFKHBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void CHLOADNGFGM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void BNNNALKHJOC(string LNBCHJPEENA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x584DB00", Offset = "0x584C500", VA = "0x18584DB00")]
	public static void BANLIDMAJJP(string LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x584DD40", Offset = "0x584C740", VA = "0x18584DD40")]
	public static void IIANDNIEBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCEHNJIMPLJ<TParent, TValue> : MPICKNFKHBC<TParent> where TParent : OMNIELDOADL
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HCEHNJIMPLJ<TParent, TValue> MDAKIDAOHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> DMPEPAECELD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50078B0", Offset = "0x50062B0", VA = "0x1850078B0")]
	public bool PKNEHCKDABA(string DPMAHEFJMND, [Out] TValue IDJLFIHEALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50077B0", Offset = "0x50061B0", VA = "0x1850077B0")]
	public void ECPENCDPMIP(string DPMAHEFJMND, TValue PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5007780", Offset = "0x5006180", VA = "0x185007780", Slot = "4")]
	protected override void CHLOADNGFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5007750", Offset = "0x5006150", VA = "0x185007750", Slot = "5")]
	protected override void BNNNALKHJOC(string DPMAHEFJMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5007A20", Offset = "0x5006420", VA = "0x185007A20")]
	public HCEHNJIMPLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OMNIELDOADL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHJNICDMMJJ();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IIFMACOKIKJ(string GGDGFENODPM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NJDDPOFMJHK(string GGDGFENODPM, int KKCMINIPIBD = 0);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDDIDIJLPPL(string GGDGFENODPM, int PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HODKOHLDACP(string GGDGFENODPM, bool KKCMINIPIBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JDOOPLIGEHB(string GGDGFENODPM, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float IBMLFBEBEJA(string GGDGFENODPM, float KKCMINIPIBD = 0f);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DBGDBJCAEOC(string GGDGFENODPM, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string GMGJFPIHJPF(string GGDGFENODPM, [Optional] string KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EAIJDGGFHLB(string GGDGFENODPM, string PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime EDKCHAKJFJI(string GGDGFENODPM, [Optional] DateTime CJMKLHDGMGL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NLDDGEFNEOD(string GGDGFENODPM, DateTime CJMKLHDGMGL);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long CEHJJBBJMNO(string GGDGFENODPM, long KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MGOJPHDPNOA(string GGDGFENODPM, long PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T OLLJBNOPPFM<T>(string GGDGFENODPM, T KKCMINIPIBD, GMOIOMKHGMM<T> MBCFLJPOGGA);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EJOOPBGHNFA<T>(string GGDGFENODPM, T PDKJBMPOMNC, GMOIOMKHGMM<T> MBCFLJPOGGA);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JPMFINDLAKI(string GGDGFENODPM);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JFDGFKKFPMF([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FGKMLIGOOPI : OMNIELDOADL
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GKPOPFKNJHO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ELDPNGEHFNF(long MCKDMADFBID, CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JJKJDHLMKPC : OMNIELDOADL
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DAGHCOKNDAE : FGKMLIGOOPI, OMNIELDOADL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CNNKLJJHMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DAGHCOKNDAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86DD060", Offset = "0x86DBA60", VA = "0x1886DD060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86DD430", Offset = "0x86DBE30", VA = "0x1886DD430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class LNDJAPHECPC : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DAGHCOKNDAE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public LNDJAPHECPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86E0A10", Offset = "0x86DF410", VA = "0x1886E0A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86E0A80", Offset = "0x86DF480", VA = "0x1886E0A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OKMKBKNBGDB PKNFGLMCONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool ADLCIOEPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private bool HNPEMDHEMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LOJPAKDCLPG PBJMOAPLPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NNFEFJFFOPD GNPEADBFCJJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GKPOPFKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x86DDCA0", Offset = "0x86DC6A0", VA = "0x1886DDCA0")]
	[UnityEngine.Scripting.Preserve]
	public DAGHCOKNDAE([LNLOHEINMEO(null)] OKMKBKNBGDB PKNFGLMCONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x86DD6D0", Offset = "0x86DC0D0", VA = "0x1886DD6D0", Slot = "6")]
	public Task ELDPNGEHFNF(long MCKDMADFBID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF580", Offset = "0x1DADF80", VA = "0x181DAF580")]
	private static int BKDCMPJPLAO(bool PDKJBMPOMNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x86DD860", Offset = "0x86DC260", VA = "0x1886DD860", Slot = "9")]
	public bool IIFMACOKIKJ(string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86DDB80", Offset = "0x86DC580", VA = "0x1886DDB80", Slot = "10")]
	public int NJDDPOFMJHK(string GGDGFENODPM, int KKCMINIPIBD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86DD600", Offset = "0x86DC000", VA = "0x1886DD600", Slot = "11")]
	public void DDDIDIJLPPL(string GGDGFENODPM, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86DD800", Offset = "0x86DC200", VA = "0x1886DD800", Slot = "12")]
	public bool HODKOHLDACP(string GGDGFENODPM, bool KKCMINIPIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86DD880", Offset = "0x86DC280", VA = "0x1886DD880", Slot = "13")]
	public void JDOOPLIGEHB(string GGDGFENODPM, bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86DD830", Offset = "0x86DC230", VA = "0x1886DD830", Slot = "14")]
	public float IBMLFBEBEJA(string GGDGFENODPM, float KKCMINIPIBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86DD5D0", Offset = "0x86DBFD0", VA = "0x1886DD5D0", Slot = "15")]
	public void DBGDBJCAEOC(string GGDGFENODPM, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86DD660", Offset = "0x86DC060", VA = "0x1886DD660", Slot = "18")]
	public DateTime EDKCHAKJFJI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86DDBB0", Offset = "0x86DC5B0", VA = "0x1886DDBB0", Slot = "19")]
	public void NLDDGEFNEOD(string GGDGFENODPM, DateTime CJMKLHDGMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86DD4F0", Offset = "0x86DBEF0", VA = "0x1886DD4F0", Slot = "20")]
	public long CEHJJBBJMNO(string GGDGFENODPM, long KKCMINIPIBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x86DDAF0", Offset = "0x86DC4F0", VA = "0x1886DDAF0", Slot = "21")]
	public void MGOJPHDPNOA(string GGDGFENODPM, long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8FB0", Offset = "0x3AA79B0", VA = "0x183AA8FB0", Slot = "22")]
	public T OLLJBNOPPFM<T>(string GGDGFENODPM, T KKCMINIPIBD, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7D80", Offset = "0x3AA6780", VA = "0x183AA7D80", Slot = "23")]
	public void EJOOPBGHNFA<T>(string GGDGFENODPM, T PDKJBMPOMNC, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8580", Offset = "0x3AA6F80", VA = "0x183AA8580")]
	private T MMKEJDIINIA<T>(string GGDGFENODPM, T KKCMINIPIBD, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7EB0", Offset = "0x3AA68B0", VA = "0x183AA7EB0")]
	private void MKNDONOBGEP<T>(string GGDGFENODPM, T PDKJBMPOMNC, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86DD7D0", Offset = "0x86DC1D0", VA = "0x1886DD7D0", Slot = "16")]
	public string GMGJFPIHJPF(string GGDGFENODPM, string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86DD630", Offset = "0x86DC030", VA = "0x1886DD630", Slot = "17")]
	public void EAIJDGGFHLB(string GGDGFENODPM, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x86DDA30", Offset = "0x86DC430", VA = "0x1886DDA30")]
	private void KAGGMOPFBJG(string GGDGFENODPM, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x86DDB60", Offset = "0x86DC560", VA = "0x1886DDB60")]
	private string MIIJLCBCNKB(string GGDGFENODPM, string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86DD9A0", Offset = "0x86DC3A0", VA = "0x1886DD9A0", Slot = "24")]
	public void JPMFINDLAKI(string GGDGFENODPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86DDA50", Offset = "0x86DC450", VA = "0x1886DDA50")]
	private string LHNIIONJJDL(string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x86DD8B0", Offset = "0x86DC2B0", VA = "0x1886DD8B0", Slot = "25")]
	[AsyncStateMachine(typeof(CNNKLJJHMOJ))]
	public Task JFDGFKKFPMF(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x86DDC20", Offset = "0x86DC620", VA = "0x1886DDC20")]
	[IteratorStateMachine(typeof(LNDJAPHECPC))]
	private IEnumerator<BHOPOIJKEJE> NLDDMLBCFHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x86DD490", Offset = "0x86DBE90", VA = "0x1886DD490")]
	private void AOPJNNAOJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x86DD560", Offset = "0x86DBF60", VA = "0x1886DD560")]
	private void CKPLHDNINLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86DD760", Offset = "0x86DC160", VA = "0x1886DD760")]
	private void EMHHCBBONHD(bool LABOHHPGCII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CNBACCHLENN : FGKMLIGOOPI, OMNIELDOADL
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
	private Dictionary<string, string> IOPIPHHCNGG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GHGHOCPHKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private string HAHGLCJCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86DC5F0", Offset = "0x86DAFF0", VA = "0x1886DC5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Dictionary<string, string> FFNPBKFFNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86DCB10", Offset = "0x86DB510", VA = "0x1886DCB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action GKPOPFKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	[UnityEngine.Scripting.Preserve]
	public CNBACCHLENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x86DC4B0", Offset = "0x86DAEB0", VA = "0x1886DC4B0", Slot = "6")]
	public Task ELDPNGEHFNF(long MCKDMADFBID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x86DC730", Offset = "0x86DB130", VA = "0x1886DC730", Slot = "14")]
	public float IBMLFBEBEJA(string LNBCHJPEENA, float KKCMINIPIBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86DC830", Offset = "0x86DB230", VA = "0x1886DC830", Slot = "13")]
	public void JDOOPLIGEHB(string LNBCHJPEENA, bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86DC660", Offset = "0x86DB060", VA = "0x1886DC660", Slot = "12")]
	public bool HODKOHLDACP(string LNBCHJPEENA, bool KKCMINIPIBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x86DCC80", Offset = "0x86DB680", VA = "0x1886DCC80", Slot = "10")]
	public int NJDDPOFMJHK(string LNBCHJPEENA, int KKCMINIPIBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x86DC440", Offset = "0x86DAE40", VA = "0x1886DC440", Slot = "18")]
	public DateTime EDKCHAKJFJI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86DCCF0", Offset = "0x86DB6F0", VA = "0x1886DCCF0", Slot = "19")]
	public void NLDDGEFNEOD(string LNBCHJPEENA, DateTime PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x86DC2C0", Offset = "0x86DACC0", VA = "0x1886DC2C0", Slot = "15")]
	public void DBGDBJCAEOC(string LNBCHJPEENA, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x86DC330", Offset = "0x86DAD30", VA = "0x1886DC330", Slot = "11")]
	public void DDDIDIJLPPL(string LNBCHJPEENA, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86DC250", Offset = "0x86DAC50", VA = "0x1886DC250", Slot = "20")]
	public long CEHJJBBJMNO(string GGDGFENODPM, long KKCMINIPIBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x86DCC10", Offset = "0x86DB610", VA = "0x1886DCC10", Slot = "21")]
	public void MGOJPHDPNOA(string GGDGFENODPM, long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x31C7F20", Offset = "0x31C6920", VA = "0x1831C7F20", Slot = "22")]
	public T OLLJBNOPPFM<T>(string GGDGFENODPM, T KKCMINIPIBD, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x31C7250", Offset = "0x31C5C50", VA = "0x1831C7250", Slot = "23")]
	public void EJOOPBGHNFA<T>(string GGDGFENODPM, T PDKJBMPOMNC, GMOIOMKHGMM<T> MBCFLJPOGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x86DC540", Offset = "0x86DAF40", VA = "0x1886DC540", Slot = "16")]
	public string GMGJFPIHJPF(string LNBCHJPEENA, string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x86DC3A0", Offset = "0x86DADA0", VA = "0x1886DC3A0", Slot = "17")]
	public void EAIJDGGFHLB(string LNBCHJPEENA, string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x86DCB50", Offset = "0x86DB550", VA = "0x1886DCB50", Slot = "24")]
	public void JPMFINDLAKI(string LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x86DC7A0", Offset = "0x86DB1A0", VA = "0x1886DC7A0", Slot = "9")]
	public bool IIFMACOKIKJ(string LNBCHJPEENA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x86DC8A0", Offset = "0x86DB2A0", VA = "0x1886DC8A0", Slot = "25")]
	public Task JFDGFKKFPMF(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BDD0", Offset = "0x3A6A7D0", VA = "0x183A6BDD0")]
	private T DHBICMHDGKM<T>(string GGDGFENODPM, T KKCMINIPIBD, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A6CEF0", Offset = "0x3A6B8F0", VA = "0x183A6CEF0")]
	private void MAAIKGLMNNO<T>(string GGDGFENODPM, T PDKJBMPOMNC, [Optional] GMOIOMKHGMM<T> NNAHCIHBEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x86DCD60", Offset = "0x86DB760", VA = "0x1886DCD60")]
	private Dictionary<string, string> ONFNCMKGFIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OEDJIHBFGCK
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action GKPOPFKNJHO;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHJNICDMMJJ();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MBFPLEMLBGE(long MCKDMADFBID);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JOBOLEHLFED(LNHOIDKFLNK AILIDFNJPLE = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PGEBGAPLNMF(string GGDGFENODPM, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JJEHFPAKJOP(string GGDGFENODPM, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string GGJMJIFOFPM(string GGDGFENODPM, [Optional] string KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CACOKDJKCJH LKJOPAEDALP(string GGDGFENODPM, string PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int KHJIJFKHODL(string GGDGFENODPM, int KKCMINIPIBD = 0, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CACOKDJKCJH KLHAGNBEOAK(string GGDGFENODPM, int PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool INGOCJNBJCL(string GGDGFENODPM, bool KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CACOKDJKCJH CIOKNPBENIN(string GGDGFENODPM, bool PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float CBFOGKKPBBJ(string GGDGFENODPM, float KKCMINIPIBD = 0f, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CACOKDJKCJH IDNDIDHBHLC(string GGDGFENODPM, float PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime MODLNNKCAAI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CACOKDJKCJH NDBOEMGLMEI(string GGDGFENODPM, DateTime PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long JIAGLAHEBMO(string GGDGFENODPM, long KKCMINIPIBD = 0L, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CACOKDJKCJH KLNABDEGAIN(string GGDGFENODPM, long PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T KLPEKAFGHOI<T>(string GGDGFENODPM, [Optional] T KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CACOKDJKCJH HMPJABOPBDP<T>(string GGDGFENODPM, T PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KHPIHNILHIJ(string GGDGFENODPM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FFCFLPGCHDE(string GGDGFENODPM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string AAOGNIOFJMD(string GGDGFENODPM, [Optional] string KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CACOKDJKCJH OIGALNOMFAL(string GGDGFENODPM, string PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int FNGFINCNMLJ(string GGDGFENODPM, int KKCMINIPIBD = 0);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CACOKDJKCJH MFIAIDHOAEM(string GGDGFENODPM, int PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool NIFBGMNACDP(string GGDGFENODPM, bool KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CACOKDJKCJH JGCOGOHMHEN(string GGDGFENODPM, bool PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float CBGIEHLLHCF(string GGDGFENODPM, float KKCMINIPIBD = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	CACOKDJKCJH KFFFJFALBFN(string GGDGFENODPM, float PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime LNNGHAGBIGN(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	CACOKDJKCJH CCKELACBHKF(string GGDGFENODPM, DateTime PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long NKMMHMDOBCG(string GGDGFENODPM, long KKCMINIPIBD = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	CACOKDJKCJH EAPFHBIBFNH(string GGDGFENODPM, long PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FHKCBOKPGBD<T>(GMOIOMKHGMM<T> MBCFLJPOGGA, [Optional] IEqualityComparer<T> MJKIOFPPIML);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void KMGGNIMEIFP<T>();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable MMIDFCLNDEM();

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void BBHNIPFHFAO(float NMPFLEBOLHH);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task AOPJNNAOJJH([Optional] CancellationToken OMJKEHOJJFF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum CACOKDJKCJH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OAKBJGCEGEA : OEDJIHBFGCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class POIDDENMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected static readonly HashSet<POIDDENMJPO> DIDFJPIPDBI;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86E48E0", Offset = "0x86E32E0", VA = "0x1886E48E0")]
		public static void IIANDNIEBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void CHLOADNGFGM();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		protected POIDDENMJPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class HHODMOFIEJF<T> : POIDDENMJPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly HHODMOFIEJF<T> NDAIDGNOFDA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public GMOIOMKHGMM<T> LIEBMIOMGKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEqualityComparer<T> CGPAPANJBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA864C0", Offset = "0xA84EC0", VA = "0x180A864C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MNBAJCCCEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x49035D0", Offset = "0x4901FD0", VA = "0x1849035D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5044D90", Offset = "0x5043790", VA = "0x185044D90")]
		private HHODMOFIEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50449F0", Offset = "0x50433F0", VA = "0x1850449F0")]
		public void MAJNBNPDEEJ(GMOIOMKHGMM<T> NNAHCIHBEEM, [Optional] IEqualityComparer<T> MJKIOFPPIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x50446C0", Offset = "0x50430C0", VA = "0x1850446C0", Slot = "4")]
		public override void CHLOADNGFGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class KPFBFDEENMC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly OAKBJGCEGEA CPJMFIMIBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly object IAFMFOJBOCE;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86DEBA0", Offset = "0x86DD5A0", VA = "0x1886DEBA0")]
		public KPFBFDEENMC(OAKBJGCEGEA CPJMFIMIBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x86DEB70", Offset = "0x86DD570", VA = "0x1886DEB70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct IDBCIIDJKLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OAKBJGCEGEA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x86DE830", Offset = "0x86DD230", VA = "0x1886DE830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86DEB10", Offset = "0x86DD510", VA = "0x1886DEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct LCGPBOKODDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public OAKBJGCEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public OMNIELDOADL backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86DEC50", Offset = "0x86DD650", VA = "0x1886DEC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MJKBBJFGAEG : IAsyncStateMachine
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
		public OAKBJGCEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x86E11C0", Offset = "0x86DFBC0", VA = "0x1886E11C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x86E1690", Offset = "0x86E0090", VA = "0x1886E1690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DIDOFFMGJCI : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private BHOPOIJKEJE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public OAKBJGCEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
		[DebuggerHidden]
		public DIDOFFMGJCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86DDD90", Offset = "0x86DC790", VA = "0x1886DDD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x86DDE20", Offset = "0x86DC820", VA = "0x1886DDE20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FGKMLIGOOPI EGIKOMKHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FGKMLIGOOPI DAADOFKDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JJKJDHLMKPC KBDDFDIDGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly LOJPAKDCLPG PBJMOAPLPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HGJLOBNNGMF.HCFGDIIOFBD LDCCODCNOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CNFJHBAFEIK ANHFCDJDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<OMNIELDOADL> HKCNJBBEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Task PJIOGEHKFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<string, string> NDBAMGCKAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NNFEFJFFOPD FHHKHJDKFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly object OIGCGDBDAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly object NJNOJBLLGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private long HDPMHFOOJLC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private bool FPJHLCPBEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x86E3710", Offset = "0x86E2110", VA = "0x1886E3710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private CancellationTokenSource HLPHNAAOEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA84220", Offset = "0xA82C20", VA = "0x180A84220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GKPOPFKNJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86E3A80", Offset = "0x86E2480", VA = "0x1886E3A80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86E2EA0", Offset = "0x86E18A0", VA = "0x1886E2EA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x86E2A60", Offset = "0x86E1460", VA = "0x1886E2A60")]
	[PPMDKOHJEBA.KMGFFEOOKKA]
	internal static void INJFIJEPFFK(CFAMNNNCHJA JBOIKIICKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x86E4510", Offset = "0x86E2F10", VA = "0x1886E4510")]
	[UnityEngine.Scripting.Preserve]
	public OAKBJGCEGEA([LNLOHEINMEO("Disk")] FGKMLIGOOPI EGIKOMKHHOJ, [LNLOHEINMEO("Cloud")] FGKMLIGOOPI DAADOFKDDII, [LNLOHEINMEO(null)] JJKJDHLMKPC KBDDFDIDGBG, [LNLOHEINMEO(null)] LOJPAKDCLPG PBJMOAPLPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x86E1DC0", Offset = "0x86E07C0", VA = "0x1886E1DC0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x86E2AD0", Offset = "0x86E14D0", VA = "0x1886E2AD0")]
	private void JEKIMAHKLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x86E25E0", Offset = "0x86E0FE0", VA = "0x1886E25E0", Slot = "6")]
	public void HHJNICDMMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x86E3B20", Offset = "0x86E2520", VA = "0x1886E3B20", Slot = "7")]
	public Task MBFPLEMLBGE(long MCKDMADFBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x86E1E30", Offset = "0x86E0830", VA = "0x1886E1E30")]
	[AsyncStateMachine(typeof(IDBCIIDJKLH))]
	private Task EBFNNPCBLNC(long MCKDMADFBID, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x86E2420", Offset = "0x86E0E20", VA = "0x1886E2420")]
	private void GOHLKMNJALG(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x86E1BA0", Offset = "0x86E05A0", VA = "0x1886E1BA0")]
	private void DEDGHMLGHDC(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x86E2580", Offset = "0x86E0F80", VA = "0x1886E2580")]
	private string HHDIBJPALLA(string IOOHKKEBNKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x86E3290", Offset = "0x86E1C90", VA = "0x1886E3290")]
	private void KKEDPANFCMN(LNHOIDKFLNK AILIDFNJPLE, string LNBCHJPEENA, [Out] FGKMLIGOOPI GLGOOBDBOJB, [Out] string EEJDDDFFNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x86E1860", Offset = "0x86E0260", VA = "0x1886E1860")]
	private FGKMLIGOOPI BPOFMMAIEEL(LNHOIDKFLNK AILIDFNJPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x86E2F40", Offset = "0x86E1940", VA = "0x1886E2F40", Slot = "8")]
	public bool JOBOLEHLFED(LNHOIDKFLNK AILIDFNJPLE = LNHOIDKFLNK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x86E4470", Offset = "0x86E2E70", VA = "0x1886E4470", Slot = "9")]
	public bool PGEBGAPLNMF(string GGDGFENODPM, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x86E2D20", Offset = "0x86E1720", VA = "0x1886E2D20", Slot = "10")]
	public bool JJEHFPAKJOP(string GGDGFENODPM, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x86E1FC0", Offset = "0x86E09C0", VA = "0x1886E1FC0", Slot = "11")]
	public string GGJMJIFOFPM(string GGDGFENODPM, [Optional] string KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x86E3890", Offset = "0x86E2290", VA = "0x1886E3890", Slot = "12")]
	public CACOKDJKCJH LKJOPAEDALP(string GGDGFENODPM, string PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x86E3180", Offset = "0x86E1B80", VA = "0x1886E3180", Slot = "13")]
	public int KHJIJFKHODL(string GGDGFENODPM, int KKCMINIPIBD = 0, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x86E3430", Offset = "0x86E1E30", VA = "0x1886E3430", Slot = "14")]
	public CACOKDJKCJH KLHAGNBEOAK(string GGDGFENODPM, int PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86E29B0", Offset = "0x86E13B0", VA = "0x1886E29B0", Slot = "15")]
	public bool INGOCJNBJCL(string GGDGFENODPM, bool KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x86E1A30", Offset = "0x86E0430", VA = "0x1886E1A30", Slot = "16")]
	public CACOKDJKCJH CIOKNPBENIN(string GGDGFENODPM, bool PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x86E18E0", Offset = "0x86E02E0", VA = "0x1886E18E0", Slot = "17")]
	public float CBFOGKKPBBJ(string GGDGFENODPM, float KKCMINIPIBD = 0f, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x86E2830", Offset = "0x86E1230", VA = "0x1886E2830", Slot = "18")]
	public CACOKDJKCJH IDNDIDHBHLC(string GGDGFENODPM, float PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x86E3E90", Offset = "0x86E2890", VA = "0x1886E3E90", Slot = "19")]
	public DateTime MODLNNKCAAI(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x86E4070", Offset = "0x86E2A70", VA = "0x1886E4070", Slot = "20")]
	public CACOKDJKCJH NDBOEMGLMEI(string GGDGFENODPM, DateTime PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x86E2C20", Offset = "0x86E1620", VA = "0x1886E2C20", Slot = "21")]
	public long JIAGLAHEBMO(string GGDGFENODPM, long KKCMINIPIBD = 0L, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x86E35A0", Offset = "0x86E1FA0", VA = "0x1886E35A0", Slot = "22")]
	public CACOKDJKCJH KLNABDEGAIN(string GGDGFENODPM, long PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3E3BEA0", Offset = "0x3E3A8A0", VA = "0x183E3BEA0", Slot = "23")]
	public T KLPEKAFGHOI<T>(string GGDGFENODPM, [Optional] T KKCMINIPIBD, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3E3BEA0", Offset = "0x3E3A8A0", VA = "0x183E3BEA0", Slot = "24")]
	public CACOKDJKCJH HMPJABOPBDP<T>(string GGDGFENODPM, T PDKJBMPOMNC, LNHOIDKFLNK NNLNAFOICAL = LNHOIDKFLNK.CLOUD)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x86E3230", Offset = "0x86E1C30", VA = "0x1886E3230", Slot = "25")]
	public bool KHPIHNILHIJ(string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x86E1F40", Offset = "0x86E0940", VA = "0x1886E1F40", Slot = "26")]
	public bool FFCFLPGCHDE(string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x86E16F0", Offset = "0x86E00F0", VA = "0x1886E16F0", Slot = "27")]
	public string AAOGNIOFJMD(string GGDGFENODPM, [Optional] string KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x86E4440", Offset = "0x86E2E40", VA = "0x1886E4440", Slot = "28")]
	public CACOKDJKCJH OIGALNOMFAL(string GGDGFENODPM, string PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x86E1F50", Offset = "0x86E0950", VA = "0x1886E1F50", Slot = "29")]
	public int FNGFINCNMLJ(string GGDGFENODPM, int KKCMINIPIBD = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x86E3CF0", Offset = "0x86E26F0", VA = "0x1886E3CF0", Slot = "30")]
	public CACOKDJKCJH MFIAIDHOAEM(string GGDGFENODPM, int PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x86E4360", Offset = "0x86E2D60", VA = "0x1886E4360", Slot = "31")]
	public bool NIFBGMNACDP(string GGDGFENODPM, bool KKCMINIPIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x86E2BF0", Offset = "0x86E15F0", VA = "0x1886E2BF0", Slot = "32")]
	public CACOKDJKCJH JGCOGOHMHEN(string GGDGFENODPM, bool PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x86E1990", Offset = "0x86E0390", VA = "0x1886E1990", Slot = "33")]
	public float CBGIEHLLHCF(string GGDGFENODPM, float KKCMINIPIBD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x86E3150", Offset = "0x86E1B50", VA = "0x1886E3150", Slot = "34")]
	public CACOKDJKCJH KFFFJFALBFN(string GGDGFENODPM, float PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x86E3A10", Offset = "0x86E2410", VA = "0x1886E3A10", Slot = "35")]
	public DateTime LNNGHAGBIGN(string GGDGFENODPM, [Optional] DateTime KKCMINIPIBD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x86E1A00", Offset = "0x86E0400", VA = "0x1886E1A00", Slot = "36")]
	public CACOKDJKCJH CCKELACBHKF(string GGDGFENODPM, DateTime PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86E43D0", Offset = "0x86E2DD0", VA = "0x1886E43D0", Slot = "37")]
	public long NKMMHMDOBCG(string GGDGFENODPM, long KKCMINIPIBD = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x86E1E00", Offset = "0x86E0800", VA = "0x1886E1E00", Slot = "38")]
	public CACOKDJKCJH EAPFHBIBFNH(string GGDGFENODPM, long PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86E2CC0", Offset = "0x86E16C0", VA = "0x1886E2CC0")]
	private bool JIEBFLBBLML(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x86E3730", Offset = "0x86E2130", VA = "0x1886E3730")]
	private bool LHHNLIMCBEP(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x86E3000", Offset = "0x86E1A00", VA = "0x1886E3000")]
	private CACOKDJKCJH KFFCKDHHHAA(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, string PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x86E3F30", Offset = "0x86E2930", VA = "0x1886E3F30")]
	private CACOKDJKCJH NADLNKNAFFL(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, int PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x86E22E0", Offset = "0x86E0CE0", VA = "0x1886E22E0")]
	private CACOKDJKCJH GLHMGMJLAOK(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, bool PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x86E4210", Offset = "0x86E2C10", VA = "0x1886E4210")]
	private CACOKDJKCJH NEKEDMNCENJ(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, float PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x86E1C50", Offset = "0x86E0650", VA = "0x1886E1C50")]
	private CACOKDJKCJH DOHADLALKBM(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, DateTime PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x86E2440", Offset = "0x86E0E40", VA = "0x1886E2440")]
	private CACOKDJKCJH HBPDGLJNMBN(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, long PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CD60", Offset = "0x3E3B760", VA = "0x183E3CD60")]
	private T PFCHLFPICJM<T>(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, T KKCMINIPIBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C040", Offset = "0x3E3AA40", VA = "0x183E3C040")]
	private CACOKDJKCJH JGKLKOJHFLI<T>(OMNIELDOADL GLGOOBDBOJB, string GGDGFENODPM, T PDKJBMPOMNC)
	{
		return default(CACOKDJKCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3E3BE00", Offset = "0x3E3A800", VA = "0x183E3BE00", Slot = "39")]
	public void FHKCBOKPGBD<T>(GMOIOMKHGMM<T> MBCFLJPOGGA, [Optional] IEqualityComparer<T> MJKIOFPPIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CCE0", Offset = "0x3E3B6E0", VA = "0x183E3CCE0", Slot = "40")]
	public void KMGGNIMEIFP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x86E2B20", Offset = "0x86E1520", VA = "0x1886E2B20")]
	[AsyncStateMachine(typeof(LCGPBOKODDD))]
	private void JFDGFKKFPMF(OMNIELDOADL FHDKCPJCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x86E1760", Offset = "0x86E0160", VA = "0x1886E1760", Slot = "43")]
	[AsyncStateMachine(typeof(MJKBBJFGAEG))]
	public Task AOPJNNAOJJH([Optional] CancellationToken DHNMCOFINFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x86E2650", Offset = "0x86E1050", VA = "0x1886E2650")]
	private void IDLIFJGMBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x86E3D20", Offset = "0x86E2720", VA = "0x1886E3D20", Slot = "41")]
	public IDisposable MMIDFCLNDEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x86E1850", Offset = "0x86E0250", VA = "0x1886E1850", Slot = "42")]
	public void BBHNIPFHFAO(float NMPFLEBOLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x86E2060", Offset = "0x86E0A60", VA = "0x1886E2060")]
	private void GJIBHCPOBPP(float DDENGIAKNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x86E3E00", Offset = "0x86E2800", VA = "0x1886E3E00")]
	[IteratorStateMachine(typeof(DIDOFFMGJCI))]
	private IEnumerator<BHOPOIJKEJE> MMMBJCNPEKF(float NMPFLEBOLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x86E1C20", Offset = "0x86E0620", VA = "0x1886E1C20")]
	[CompilerGenerated]
	private void DKCIELKCAAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BJOEDPHHFCH : LABNKHCBIEH<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static BJOEDPHHFCH NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x86DBEA0", Offset = "0x86DA8A0", VA = "0x1886DBEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x86DBDB0", Offset = "0x86DA7B0", VA = "0x1886DBDB0", Slot = "9")]
	public override string AGNKEKDJGCC(bool GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x86DBEF0", Offset = "0x86DA8F0", VA = "0x1886DBEF0", Slot = "10")]
	protected override bool NHOLMOMDPHC(string GMLILPJAKBM, [Out] bool PDKJBMPOMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x86DC210", Offset = "0x86DAC10", VA = "0x1886DC210")]
	public BJOEDPHHFCH()
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
