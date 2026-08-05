using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LLEPBGECFHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GIBJOIPIBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 GMEGOAEDHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion KLCLCJJBMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 CLKPCNHFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int DOGHILBAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LNHOIGGNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int MIPNBOLLKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float KFPEBCJEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 LPMPKFECNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool KNCCACCIMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LKCKKNIKBKM PNKBDIKEFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 GNIFOEIJNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float ENDIEECPPMP;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LLAEMFOHIND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static GKECCAAHCDI OHHJGCGNDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<LLEPBGECFHM> OJMKOOIDNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<KEOMPOPNELF> AJIAGKCFJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<LAHOMPLFLLE> AGEOEFDPION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<KFOEBKADJGI> JEHLCMGFKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<KEOMPOPNELF> IDEOEPBOPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<DEMNKNDNJHO> IPKAFLGBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<KFOEBKADJGI>> HOGHDNAGOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<GEBHNBLDLCA> JDIHAIFPAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> KAODDJAONKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAEF100", Offset = "0xAED900", VA = "0x180AEF100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAED5D0", Offset = "0xAEBDD0", VA = "0x180AED5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAEF110", Offset = "0xAED910", VA = "0x180AEF110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAEDE80", Offset = "0xAEC680", VA = "0x180AEDE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF6F0", Offset = "0x5CEDEF0", VA = "0x185CEF6F0")]
	public LLAEMFOHIND(int LNFCDOMDELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBA0", Offset = "0x5CEC3A0", VA = "0x185CEDBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDD00", Offset = "0x5CEC500", VA = "0x185CEDD00")]
	public void FFAMFELMPDP(JobHandle LOGMOOGMKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEEE0", Offset = "0x5CED6E0", VA = "0x185CEEEE0")]
	public void JNKMMJAKCKG(LLEPBGECFHM KOIMDAJNDOD, GEBHNBLDLCA LHKIJMBFMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBC0", Offset = "0x5CEC3C0", VA = "0x185CEDBC0")]
	public void EJNOBFKDMDJ(LAHOMPLFLLE KOIMDAJNDOD, NativeArray<KFOEBKADJGI> JLMGBAGLAFL, int HDFGJAGJOEO, int PBLGJLMCPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDED0", Offset = "0x5CEC6D0", VA = "0x185CEDED0")]
	public JobHandle FMOIHGHOGCH(ANLJNALAKBD MGFDOCIILBC, JBHAINBNLGA PGNIPBBGPOA, float3 ALPEHONCJHK, quaternion DKKFCHECLPA, float DIMFOKOIDED, bool DLNDMNFECEN, int HOCLDKHIJMB = 0, int DPOLJDOHPHI = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3B0", Offset = "0x5CEDBB0", VA = "0x185CEF3B0")]
	public static JobHandle NOKGIIJJOKG(BKHAEOEBPNM HFHFAACCGGD, ANLJNALAKBD MGFDOCIILBC, LLEPBGECFHM KOIMDAJNDOD, JobHandle LOGMOOGMKPB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF100", Offset = "0x5CED900", VA = "0x185CEF100")]
	public static JobHandle MLFLPHMLGKC(DIBOPPIAHCF HFHFAACCGGD, ANLJNALAKBD MGFDOCIILBC, LAHOMPLFLLE KOIMDAJNDOD, NativeArray<KFOEBKADJGI> JLMGBAGLAFL, int HDFGJAGJOEO, int PBLGJLMCPLD, JobHandle LOGMOOGMKPB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HLLFCIONHDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 LOILIENPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 PCDALKOIBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GGDIEMDDAJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HLLFCIONHDG> LGBJLAOLMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> JOIPGBGNIOL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC090", Offset = "0x5CEA890", VA = "0x185CEC090")]
	public GGDIEMDDAJB(int FGCMOFPHLFL, int NFBMPHODCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBF50", Offset = "0x5CEA750", VA = "0x185CEBF50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBFB0", Offset = "0x5CEA7B0", VA = "0x185CEBFB0")]
	public void GAAGGFFDGKN(GGDIEMDDAJB OIDEBDGFOMF, int IOLJILLNCHD, int GELOOBNLCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BMJFCPMNKGN
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static GGDIEMDDAJB PJGOFIPONEB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<KEOMPOPNELF> JDBJGPCKBOO;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] AKNPAONOCDO;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool FIMKCKJFIKC;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, GGDIEMDDAJB> LJDFDEIEFEI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, GGDIEMDDAJB> DLCNLFLMEPL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool AGFAAGFKGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6FC0", Offset = "0x5CE57C0", VA = "0x185CE6FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<KEOMPOPNELF> NLFMPBJDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CE78E0", Offset = "0x5CE60E0", VA = "0x185CE78E0")]
		get
		{
			return default(NativeList<KEOMPOPNELF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GGDIEMDDAJB IILFFGDEKCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CE6680", Offset = "0x5CE4E80", VA = "0x185CE6680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7040", Offset = "0x5CE5840", VA = "0x185CE7040")]
	private static void PADICMGKDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6310", Offset = "0x5CE4B10", VA = "0x185CE6310")]
	public static int ABLKINEMAHG(bool CBNHLHNGICJ, int POBDLNJAKCE, bool GPGOGCECPAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6EB0", Offset = "0x5CE56B0", VA = "0x185CE6EB0")]
	private static int GPGDHNPGDGO(int POBDLNJAKCE, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE68A0", Offset = "0x5CE50A0", VA = "0x185CE68A0")]
	private static int EAPJIPNKJJN(int POBDLNJAKCE, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6F10", Offset = "0x5CE5710", VA = "0x185CE6F10")]
	public static int LNKKCAKHALD(int OLLEBMKIFPO, int POBDLNJAKCE, int IAPCAPEPNCI, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6E20", Offset = "0x5CE5620", VA = "0x185CE6E20")]
	public static int GHEEJGIDJIN(int OLLEBMKIFPO, int POBDLNJAKCE, int IAPCAPEPNCI, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6F00", Offset = "0x5CE5700", VA = "0x185CE6F00")]
	public static int LCACJKFKABF(int IAPCAPEPNCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6EF0", Offset = "0x5CE56F0", VA = "0x185CE6EF0")]
	private static int KNLODGLMPFF(int POBDLNJAKCE, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6ED0", Offset = "0x5CE56D0", VA = "0x185CE6ED0")]
	private static int IEHBBLJLGHI(int POBDLNJAKCE, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6CC0", Offset = "0x5CE54C0", VA = "0x185CE6CC0")]
	public static int EKJCIFECDBG(int OLLEBMKIFPO, int POBDLNJAKCE, int IAPCAPEPNCI, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6720", Offset = "0x5CE4F20", VA = "0x185CE6720")]
	public static int BIIHPAPHBKH(int OLLEBMKIFPO, int POBDLNJAKCE, int IAPCAPEPNCI, bool LBKMIAFCGLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6FA0", Offset = "0x5CE57A0", VA = "0x185CE6FA0")]
	public static int NCFDOGMGNHJ(int IAPCAPEPNCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CE67B0", Offset = "0x5CE4FB0", VA = "0x185CE67B0")]
	public static GGDIEMDDAJB DKKFADEOLFA(int POBDLNJAKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7650", Offset = "0x5CE5E50", VA = "0x185CE7650")]
	private static GGDIEMDDAJB PBNDPNBGBKM(int POBDLNJAKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6D30", Offset = "0x5CE5530", VA = "0x185CE6D30")]
	public static GGDIEMDDAJB FBMBJBHOLOH(int POBDLNJAKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6340", Offset = "0x5CE4B40", VA = "0x185CE6340")]
	private static GGDIEMDDAJB ACMEGJPIBGL(int POBDLNJAKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE68B0", Offset = "0x5CE50B0", VA = "0x185CE68B0")]
	public static void EGCGKCECDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LAHOMPLFLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int INMDDACLNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 GMEGOAEDHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion KLCLCJJBMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float CLKPCNHFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float LPOPALKKFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int DOGHILBAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LNHOIGGNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int MIPNBOLLKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool NMCAOMKFLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool KMANNGIKMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float KFPEBCJEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 LPMPKFECNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool CBJFJIECEJN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DEMNKNDNJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int MCFJMOKOGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int DDBFGMCDKJC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DIBOPPIAHCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<LAHOMPLFLLE> FPFECBJOFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<KFOEBKADJGI> ALKNMLJCAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<KEOMPOPNELF> BNGNNFKBPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<DEMNKNDNJHO> LFJLHGEAFOJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB3A0", Offset = "0x5CE9BA0", VA = "0x185CEB3A0")]
	public DIBOPPIAHCF(NativeArray<KFOEBKADJGI> ALKNMLJCAEL, int NBNELMONDLK = 1, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB2B0", Offset = "0x5CE9AB0", VA = "0x185CEB2B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct LPKGAKBLGHG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<HLLFCIONHDG> CLDNHIMKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> EBFKLCOKOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<KEOMPOPNELF> OLOGAFHEGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<LAHOMPLFLLE> FPFECBJOFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<KFOEBKADJGI> ALKNMLJCAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<KEOMPOPNELF> BNGNNFKBPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<DEMNKNDNJHO> LFJLHGEAFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int JIEMLFOBDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int DJMBHLONEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 EFHLBELJPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion PIHGPFBELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 BNMDNPEMPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CJKLMFBHHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OPIHINLDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CHHBPACGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EIGDBECHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DMNFMGGPEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ONHKFNKHHEO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1880", Offset = "0x5CF0080", VA = "0x185CF1880")]
	public LPKGAKBLGHG(LLAEMFOHIND GJMCCEBNNPJ, ANLJNALAKBD EBPJAJHIKOE, float3 PBLNFJMLJFG, quaternion HHBLNAKPBEN, float PNMLFADOHCJ, int HOCLDKHIJMB = 0, int DPOLJDOHPHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1B10", Offset = "0x5CF0310", VA = "0x185CF1B10")]
	public LPKGAKBLGHG(DIBOPPIAHCF GJMCCEBNNPJ, ANLJNALAKBD EBPJAJHIKOE, float3 PBLNFJMLJFG, quaternion HHBLNAKPBEN, float3 PNMLFADOHCJ, int HOCLDKHIJMB = 0, int DPOLJDOHPHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1750", Offset = "0x5CEFF50", VA = "0x185CF1750")]
	private float3 PMLIJLLMCFK(float3 JIBCHJNKFII, Matrix4x4 LGOCMMCHIIM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFA70", Offset = "0x5CEE270", VA = "0x185CEFA70")]
	private float3x3 CLIMLGEEFFB(float3x3 NLDHGIEEHGL, float3x3 BHAIGGGDGBF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0C90", Offset = "0x5CEF490", VA = "0x185CF0C90")]
	private float HOAMDMOLMNI(float CDLIHEJMBGO, float MEJINGHMCGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFAF0", Offset = "0x5CEE2F0", VA = "0x185CEFAF0", Slot = "4")]
	public void Execute(int LAJELLJMOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF900", Offset = "0x5CEE100", VA = "0x185CEF900")]
	private void CDPJPOIMKDO(int OPBEAOECPEJ, float3 OBAACBLACLC, float3 HOBKDEMPIOI, float3 BHGDJDBFMFL, float KPOEIGEKNFE, bool ANMNDIONFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CF12F0", Offset = "0x5CEFAF0", VA = "0x185CF12F0")]
	private void OABCCKLGJDC(LAHOMPLFLLE OJPDJIAABMB, float3 LHFDFHNAOOD, float3x3 CPFEILLBOLJ, float CDLIHEJMBGO, int EBEHBAMHALI, int HEHHNEFGDAO, int CHAKMDBIJCM, float KBDNNIDFEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0CA0", Offset = "0x5CEF4A0", VA = "0x185CF0CA0")]
	private void LPFAJNOIIGP(int OPBEAOECPEJ, int CMBKAIIJKEG, LAHOMPLFLLE OJPDJIAABMB, float3 LHFDFHNAOOD, float3x3 CPFEILLBOLJ, bool BNLNDMBLDEN, float CDLIHEJMBGO, int PJBILGDFOBA, int EJDNJGEPPBG, int CHAKMDBIJCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BKHAEOEBPNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<LLEPBGECFHM> JLBENPEECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<KEOMPOPNELF> EKMKKJGJGMB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6220", Offset = "0x5CE4A20", VA = "0x185CE6220")]
	public BKHAEOEBPNM(int NBNELMONDLK, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CE6180", Offset = "0x5CE4980", VA = "0x185CE6180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct BBABKDANIKL : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum IEEMAHMCMNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> CGOINCNLONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> MHFGNAPEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> KLODGBGABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> EOGIDAFECJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> HDNOKPOCPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> PKDGEKMADIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> LHAOAADOFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> LDJBKANEFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<KEOMPOPNELF> ILBIKPMFKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<LLEPBGECFHM> JLBENPEECKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<KEOMPOPNELF> EKMKKJGJGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int JIEMLFOBDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int DJMBHLONEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CJKLMFBHHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OPIHINLDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CHHBPACGFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EIGDBECHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DMNFMGGPEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ONHKFNKHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 BNMDNPEMPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion PIHGPFBELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 EFHLBELJPLK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5DA0", Offset = "0x5CE45A0", VA = "0x185CE5DA0")]
	public BBABKDANIKL(LLAEMFOHIND GJMCCEBNNPJ, ANLJNALAKBD EBPJAJHIKOE, float3 PBLNFJMLJFG, quaternion HHBLNAKPBEN, float PNMLFADOHCJ, int HOCLDKHIJMB = 0, int DPOLJDOHPHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5F90", Offset = "0x5CE4790", VA = "0x185CE5F90")]
	public BBABKDANIKL(BKHAEOEBPNM KOIMDAJNDOD, ANLJNALAKBD EBPJAJHIKOE, float3 PBLNFJMLJFG, quaternion HHBLNAKPBEN, float3 PNMLFADOHCJ, int HOCLDKHIJMB = 0, int DPOLJDOHPHI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4DD0", Offset = "0x5CE35D0", VA = "0x185CE4DD0", Slot = "4")]
	public void Execute(int LAJELLJMOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4A20", Offset = "0x5CE3220", VA = "0x185CE4A20")]
	private void EIDCCNIJAMM(float4x4 LEILKFCIMIM, int LAJELLJMOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE5D30", Offset = "0x5CE4530", VA = "0x185CE5D30")]
	private IEEMAHMCMNN LCPJPBJABDI(float3 HOBKDEMPIOI)
	{
		return default(IEEMAHMCMNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4990", Offset = "0x5CE3190", VA = "0x185CE4990")]
	private float4 CJMMCDMGGFH(IEEMAHMCMNN OHDBDANJEFP, int ADMJKDLHPCI)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE49E0", Offset = "0x5CE31E0", VA = "0x185CE49E0")]
	private float2 DPODDMJBCGE(IEEMAHMCMNN OHDBDANJEFP, float3 OBAACBLACLC)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GEBHNBLDLCA
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum OLFEMIGGKAF
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static GEBHNBLDLCA FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 MGPEIGPKABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 DCHJEDLFMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 PHCALFNEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public OLFEMIGGKAF OHBHGCLHIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 JBIMOAKCJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 IBGKJIECFIH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB860", Offset = "0x5CEA060", VA = "0x185CEB860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 OOJDEHGNOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBD10", Offset = "0x5CEA510", VA = "0x185CEBD10")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBE60", Offset = "0x5CEA660", VA = "0x185CEBE60")]
	public GEBHNBLDLCA(float3 OBAACBLACLC, quaternion AHLHKGGFBGH, float3 NBNELMONDLK, OLFEMIGGKAF BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBA20", Offset = "0x5CEA220", VA = "0x185CEBA20")]
	public float NIPPKJOILDE(float3 LHFDFHNAOOD, float DADMACBAPPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBC20", Offset = "0x5CEA420", VA = "0x185CEBC20")]
	public bool PCCJPHHNHGB(float3 HOBKDEMPIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB870", Offset = "0x5CEA070", VA = "0x185CEB870")]
	public void MPGIFIBDBNG(float3 MPONPIDAIHH, float3x3 DMOAEMKLDJD, float CBCHPENEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB760", Offset = "0x5CE9F60", VA = "0x185CEB760")]
	private void FEGNHJALMOB(float3 BFCEGFNGHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB4D0", Offset = "0x5CE9CD0", VA = "0x185CEB4D0")]
	public void ACNCCLMEDIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct IPCEMBDDBIA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<GEBHNBLDLCA> KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> POANJPHPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> MBBDMHFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KAODDJAONKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<KEOMPOPNELF> EKMKKJGJGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int MKOKMNNJFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int AKEDIGFHNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float DADMACBAPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float LIPDHMAAOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GLGNNPHCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> NJIDDLNEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NEJMDAHPNBI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CED780", Offset = "0x5CEBF80", VA = "0x185CED780")]
	public IPCEMBDDBIA(ANLJNALAKBD MPLECHMLAIA, float CIABFDDBOKJ, int GELOOBNLCJF, int EBEHBAMHALI, NativeList<GEBHNBLDLCA> KOIMDAJNDOD, NativeArray<int> KAODDJAONKA, NativeList<KEOMPOPNELF> EKMKKJGJGMB, JBHAINBNLGA PGNIPBBGPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CECF80", Offset = "0x5CEB780", VA = "0x185CECF80", Slot = "4")]
	public void Execute(int OEGFLFGOJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CED6C0", Offset = "0x5CEBEC0", VA = "0x185CED6C0")]
	private bool FDBBKAMBCOM(GEBHNBLDLCA FABNAGLLOKN, GEBHNBLDLCA FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCE0", Offset = "0x5CEB4E0", VA = "0x185CECCE0")]
	private bool EDMECIFGPEH(GEBHNBLDLCA JOBNHAOLCJM, int AFDBDOJGPCO, int MDFAADELEEE, int HKMDMCPOHHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JBHAINBNLGA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> MMLCFKGLGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> JMKGAKHLLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> JGFLBEFFNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> FIHFGFBCFLG;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CED930", Offset = "0x5CEC130", VA = "0x185CED930")]
	public void LBMECFKLJDE(int FGCMOFPHLFL, int NFBMPHODCPI, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CED820", Offset = "0x5CEC020", VA = "0x185CED820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CED840", Offset = "0x5CEC040", VA = "0x185CED840")]
	public void FFAMFELMPDP(JobHandle LOGMOOGMKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JBHAINBNLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PNPCBAOOGGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> POANJPHPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> NEGDEAKCFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> MKHFJLJKPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> BGPKEMLHJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> MBBDMHFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BNAIGHFFEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> DIJJBMNAPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> GLGNNPHCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> NJIDDLNEDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int HOCLDKHIJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int DPOLJDOHPHI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3570", Offset = "0x5CF1D70", VA = "0x185CF3570")]
	public PNPCBAOOGGM(ANLJNALAKBD MPLECHMLAIA, JBHAINBNLGA PGNIPBBGPOA, int DPOLJDOHPHI = 0, int HOCLDKHIJMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3130", Offset = "0x5CF1930", VA = "0x185CF3130", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3510", Offset = "0x5CF1D10", VA = "0x185CF3510")]
	private void OMBKDNCPCLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GJJCAAPADAH
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2382400", Offset = "0x2380C00", VA = "0x182382400")]
	public static bool HGMCDOHNFEC<T>(NativeArray<T> JMHHCKCLFBI, int NBNELMONDLK, Allocator OPPHPFNHPMG, NativeArrayOptions LCBBKAOBGLA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2382540", Offset = "0x2380D40", VA = "0x182382540")]
	public static bool HGMCDOHNFEC<T>(NativeList<T> KAEOEAACCCG, int NBNELMONDLK, Allocator OPPHPFNHPMG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JNDHJMNFEHO
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HJOLPJMNPAD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EECNLCJIOKC(JNDHJMNFEHO OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LDHNOKGHJPE(JNDHJMNFEHO OLLEBMKIFPO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPLJANHAPJI(JNDHJMNFEHO OLLEBMKIFPO, LLAEMFOHIND OECGCCLJNEK, int KFBJIKKGIHF = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ANLJNALAKBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int GMAEDKGNFIL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> OBOHIOEBBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> NPHGFEKCONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> OLJPNANCCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> AOMOKPPHHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> FHCHLLMEJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> CONFJBMENEC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3C70", Offset = "0x5CE2470", VA = "0x185CE3C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4910", Offset = "0x5CE3110", VA = "0x185CE4910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3B20", Offset = "0x5CE2320", VA = "0x185CE3B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool HLIDOPIKHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CE4950", Offset = "0x5CE3150", VA = "0x185CE4950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3B60", Offset = "0x5CE2360", VA = "0x185CE3B60", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4740", Offset = "0x5CE2F40", VA = "0x185CE4740")]
	public void LBMECFKLJDE(int FGCMOFPHLFL, int NFBMPHODCPI, Allocator OPPHPFNHPMG, bool KEALCDCOLDE, bool GMBMOFCJIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE42E0", Offset = "0x5CE2AE0", VA = "0x185CE42E0")]
	public void JBBPCDOLCOE(int FGCMOFPHLFL, int NFBMPHODCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE4360", Offset = "0x5CE2B60", VA = "0x185CE4360", Slot = "6")]
	public bool JODMLAIFOPO(Mesh MPLECHMLAIA, bool ANCDDMHDHPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3CB0", Offset = "0x5CE24B0", VA = "0x185CE3CB0")]
	public bool GEJCICAFNJA(Mesh MPLECHMLAIA, ANLJNALAKBD DDLPKJAGBLL, bool ANCDDMHDHPM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public ANLJNALAKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KIECNDCIKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDA50", Offset = "0x5CEC250", VA = "0x185CEDA50")]
	public static void EGCGKCECDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MIICBGOAHOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> OBOHIOEBBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> NPHGFEKCONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> KHOEMPAGOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> GPNNBFJLMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> CMIEKJNIALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> LJFNANOMBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> IBDPIOFOIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> CONFJBMENEC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2BE0", Offset = "0x5CF13E0", VA = "0x185CF2BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int BNMCGLMBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CF21D0", Offset = "0x5CF09D0", VA = "0x185CF21D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NLFGHALONLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2BA0", Offset = "0x5CF13A0", VA = "0x185CF2BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2C20", Offset = "0x5CF1420", VA = "0x185CF2C20")]
	public MIICBGOAHOJ(int FGCMOFPHLFL, int NFBMPHODCPI, int MPJNOAONEJG, Allocator OPPHPFNHPMG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2E40", Offset = "0x5CF1640", VA = "0x185CF2E40")]
	public MIICBGOAHOJ(Mesh MPLECHMLAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2210", Offset = "0x5CF0A10", VA = "0x185CF2210", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2320", Offset = "0x5CF0B20", VA = "0x185CF2320")]
	public void GAAGGFFDGKN(MIICBGOAHOJ MPLECHMLAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1D40", Offset = "0x5CF0540", VA = "0x185CF1D40")]
	private void AFCMABNIHMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2620", Offset = "0x5CF0E20", VA = "0x185CF2620")]
	private void GFJGHPPPLNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KEOMPOPNELF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int EMBFCLPJPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int NEOHOODKHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int NKCKOFBLOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BNMCGLMBCGL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDA30", Offset = "0x5CEC230", VA = "0x185CEDA30")]
	public KEOMPOPNELF(int EBEHBAMHALI, int HDFGJAGJOEO, int GELOOBNLCJF, int PBLGJLMCPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GKECCAAHCDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<KEOMPOPNELF> DPGPBKLENPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KEOMPOPNELF>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A5EFC0", Offset = "0x1A5D7C0", VA = "0x181A5EFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MIICBGOAHOJ CEMCJDNFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC720", Offset = "0x5CEAF20", VA = "0x185CEC720")]
	public GKECCAAHCDI(IEnumerable<MIICBGOAHOJ> MNIDFKMMDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC6B0", Offset = "0x5CEAEB0", VA = "0x185CEC6B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LKCKKNIKBKM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GGFEAEPKLBA
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> IMIOFGHAPAO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> PIJHAPEGPDK;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> LDFHKNKPLPA;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> BEHKNEHGEPD;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC150", Offset = "0x5CEA950", VA = "0x185CEC150")]
	public static void EGCGKCECDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC380", Offset = "0x5CEAB80", VA = "0x185CEC380")]
	public static NativeArray<float2> MFGEIGFFLOG(NativeArray<float2> LBOHDHOLBME, int JIHHFILKDPK, NativeArray<float2> ODLIOLPJBCB, int CMBPCBLOMDC)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC270", Offset = "0x5CEAA70", VA = "0x185CEC270")]
	public static NativeArray<float3> GHNEPLNDMPL(NativeArray<float3> LBOHDHOLBME, int JIHHFILKDPK, NativeArray<float3> ODLIOLPJBCB, int CMBPCBLOMDC)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC490", Offset = "0x5CEAC90", VA = "0x185CEC490")]
	public static NativeArray<float4> NLNKMGMNOHA(NativeArray<float4> LBOHDHOLBME, int JIHHFILKDPK, NativeArray<float4> ODLIOLPJBCB, int CMBPCBLOMDC)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC5A0", Offset = "0x5CEADA0", VA = "0x185CEC5A0")]
	public static NativeArray<int> PFECMNMFIMG(NativeArray<int> LBOHDHOLBME, int JIHHFILKDPK, NativeArray<int> ODLIOLPJBCB, int CMBPCBLOMDC)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x237BA70", Offset = "0x237A270", VA = "0x18237BA70")]
	private static void HHMKMKIIFMP<T>(NativeArray<T> JMHHCKCLFBI, int AKMLOCECGNJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x237BC70", Offset = "0x237A470", VA = "0x18237BC70")]
	private static void KBGEKFHNOMO<T>(NativeArray<T> LBOHDHOLBME, int JIHHFILKDPK, NativeArray<T> ODLIOLPJBCB, int CMBPCBLOMDC, NativeArray<T> BFNONCGEMHO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DGHCIGNMGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<HJOLPJMNPAD> GLPBOIEKHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly PJPBBBFNADB DJFCAFJNHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int HDFGJAGJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int PBLGJLMCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool CAMKELDCOBF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh CEMCJDNFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7640E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer ANDNBDDJCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int NEOHOODKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB090", Offset = "0x5CE9890", VA = "0x185CEB090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBF590", Offset = "0x1FBDD90", VA = "0x181FBF590")]
	public void NDLOLADPIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB190", Offset = "0x5CE9990", VA = "0x185CEB190")]
	public DGHCIGNMGEK(string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA660", Offset = "0x5CE8E60", VA = "0x185CEA660")]
	public void FFAMFELMPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA500", Offset = "0x5CE8D00", VA = "0x185CEA500")]
	public void AONOAHNGEEK(HJOLPJMNPAD PFBPHNHBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAE20", Offset = "0x5CE9620", VA = "0x185CEAE20")]
	private void KBPCONADOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB0B0", Offset = "0x5CE98B0", VA = "0x185CEB0B0")]
	public bool NPLGOHKMKOB(HJOLPJMNPAD PFBPHNHBEHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA3D0", Offset = "0x5CE8BD0", VA = "0x185CEA3D0")]
	public bool ADJIAADNNIO(HJOLPJMNPAD PFBPHNHBEHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB120", Offset = "0x5CE9920", VA = "0x185CEB120", Slot = "4")]
	public virtual void OECHNHHMAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA430", Offset = "0x5CE8C30", VA = "0x185CEA430")]
	public void ALFKDFCCJPO(Transform FANIIFELNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA6A0", Offset = "0x5CE8EA0", VA = "0x185CEA6A0")]
	public bool JMAMJAHPFGH(Transform FANIIFELNPL, [Out] (ANLJNALAKBD destMesh, Mesh mesh, JobHandle job) KOIMDAJNDOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA5B0", Offset = "0x5CE8DB0", VA = "0x185CEA5B0")]
	public void DMNDDOGECBA([In] (ANLJNALAKBD destMesh, Mesh mesh, JobHandle job) KOIMDAJNDOD)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker DOJGAHJBFDK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker NKBGAMCDOLK;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker NPLLDHNDCIF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int IODOCNDKNGK = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<DGHCIGNMGEK>> EJNJGHNOCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<DGHCIGNMGEK> JOICOIHBEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> EHFEDEDLENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(DGHCIGNMGEK, (ANLJNALAKBD, Mesh, JobHandle))> EDOENPDEPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool EHKJIHJJHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> GKLBGIKJFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> DBHKGGPCFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> OLKGCDFDJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> ANIBEMGAEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DGHCIGNMGEK JOLHNIHECMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material PLFBGMOMJPA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> KNODLIJGOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9370", Offset = "0x5CE7B70", VA = "0x185CE9370")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7AF0", Offset = "0x5CE62F0", VA = "0x185CE7AF0")]
		public DGHCIGNMGEK AddToBatchedMesh(HJOLPJMNPAD CHJMIBLGCJN, Material LGHJCFHBOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE95E0", Offset = "0x5CE7DE0", VA = "0x185CE95E0")]
		public void RemoveFromBatchedMesh(HJOLPJMNPAD MPLECHMLAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7DA0", Offset = "0x5CE65A0", VA = "0x185CE7DA0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9760", Offset = "0x5CE7F60", VA = "0x185CE9760")]
		public void SetMaterialProperty(int BFLLNKNNDBB, Color JFJPGCGPBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9BF0", Offset = "0x5CE83F0", VA = "0x185CE9BF0")]
		public void SetMaterialProperty(int BFLLNKNNDBB, float IFKKLLBODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9E10", Offset = "0x5CE8610", VA = "0x185CE9E10")]
		public void SetMaterialProperty(int BFLLNKNNDBB, Vector4 DPFCBBKGOMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9990", Offset = "0x5CE8190", VA = "0x185CE9990")]
		public void SetMaterialProperty(int BFLLNKNNDBB, Matrix4x4 BKACFOMALKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7F40", Offset = "0x5CE6740", VA = "0x185CE7F40")]
		private void DBFDFIBLFGD(Renderer GHDBAAFPFPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8C90", Offset = "0x5CE7490", VA = "0x185CE8C90")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8530", Offset = "0x5CE6D30", VA = "0x185CE8530")]
		private void DINDFKCDNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8A90", Offset = "0x5CE7290", VA = "0x185CE8A90")]
		private DGHCIGNMGEK EOFBEOHJOJK(HJOLPJMNPAD MPLECHMLAIA, Material LGHJCFHBOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CE7BD0", Offset = "0x5CE63D0", VA = "0x185CE7BD0")]
		private DGHCIGNMGEK BFOMOAEIJPJ(Material LGHJCFHBOJC, int DCIMGANBKIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CE8CA0", Offset = "0x5CE74A0", VA = "0x185CE8CA0")]
		private DGHCIGNMGEK IGBCKNAEHBM(Material LGHJCFHBOJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CE92E0", Offset = "0x5CE7AE0", VA = "0x185CE92E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9150", Offset = "0x5CE7950", VA = "0x185CE9150")]
		public void MarkDirty(HJOLPJMNPAD MPLECHMLAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA110", Offset = "0x5CE8910", VA = "0x185CEA110")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JPLCDIPDGHD<KeyType> : DGHCIGNMGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, HJOLPJMNPAD> NKKLFKALPPH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x38606B0", Offset = "0x385EEB0", VA = "0x1838606B0")]
	public JPLCDIPDGHD(string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3860340", Offset = "0x385EB40", VA = "0x183860340")]
	public void AONOAHNGEEK(KeyType EBICOEDOGKC, HJOLPJMNPAD PFBPHNHBEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3860390", Offset = "0x385EB90", VA = "0x183860390")]
	public bool FMLJLMJCHLG(KeyType EBICOEDOGKC, HJOLPJMNPAD LFANJHLDDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38605D0", Offset = "0x385EDD0", VA = "0x1838605D0")]
	public void NJEOAJBEKCB(KeyType EBICOEDOGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3860670", Offset = "0x385EE70", VA = "0x183860670", Slot = "4")]
	public override void OECHNHHMAGE()
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
