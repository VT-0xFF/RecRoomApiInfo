using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct PDBNHFBMOBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct DPGEKJKGDCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int DAHONAPCNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int CCBPCDMIDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int CKMNKMECCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int OCIBEIGODHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int MICICHMGPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int OGFPLOLLJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 DIGEKGMGGBK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D94F80", Offset = "0x6D94380", VA = "0x186D94F80")]
		public DPGEKJKGDCJ(int MCPOGJOKKJH, int GMKCAEDFNLA, int LHGLEEDAFOL, int LBHDEIDACNO, int FPLJEKOMNOI, int ODJINOOELDD, float3 KENGOPLODLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct MLILDANDHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int PNBCLDDAOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int LMKNDGLLMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float BIFHBNIEJMF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x14C5140", Offset = "0x14C4540", VA = "0x1814C5140")]
		public MLILDANDHGK(int KKPMNJCHLDM, int GPDPBLLNOBL, float ODLHKDJMEOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct CIPACGFJFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int LMKNDGLLMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int HJPAIJMCCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int NGGAFLMPFKE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, DPGEKJKGDCJ> JKBIHFCNKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<MLILDANDHGK> BIHPHLCJFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> CJKHDHCCIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<CIPACGFJFNA> JFHOIHDLMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> AEABNGMIEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OAGFNLPIDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int HKMFBDOHKGL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D95F00", Offset = "0x6D95300", VA = "0x186D95F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D97940", Offset = "0x6D96D40", VA = "0x186D97940")]
	public bool KDJDJFLCEFH([In] NativeArray<float3> HGOBDBHBIBI, NativeList<float3> MCLKEMPMBIF, NativeList<int> FJHCOGHKDDO, Allocator HPLNAKONHEI, CancellationToken NBBCMDKGJKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D95730", Offset = "0x6D94B30", VA = "0x186D95730")]
	private void CGCFJDLGJFP([In] NativeArray<float3> HGOBDBHBIBI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D96410", Offset = "0x6D95810", VA = "0x186D96410")]
	private void ENFECBLJICC([In] NativeArray<float3> HGOBDBHBIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D98310", Offset = "0x6D97710", VA = "0x186D98310")]
	private void PEIJKKOJLDC([In] NativeArray<float3> HGOBDBHBIBI, [Out] int PBBFCCHLOJH, [Out] int OKINCGEKKJI, [Out] int MBIJEPMPOIP, [Out] int OAFIDFDFEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D987D0", Offset = "0x6D97BD0", VA = "0x186D987D0")]
	private void PLOJOCCOFMO([In] NativeArray<float3> HGOBDBHBIBI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D95910", Offset = "0x6D94D10", VA = "0x186D95910")]
	private void CJHNAFLHPBE([In] NativeArray<float3> HGOBDBHBIBI, float3 DFIPADAPDJG, int CLGMJPEGENK, DPGEKJKGDCJ IFEDELJNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D97F20", Offset = "0x6D97320", VA = "0x186D97F20")]
	private void OJNDJOMDGIN([In] NativeArray<float3> HGOBDBHBIBI, float3 DFIPADAPDJG, int IJLOLCAKGKI, int HKMFBDOHKGL, DPGEKJKGDCJ IFEDELJNFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D95130", Offset = "0x6D94530", VA = "0x186D95130")]
	private void CEKBGEKNCDN([In] NativeArray<float3> HGOBDBHBIBI, int GPJNOFGFBCE, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D96040", Offset = "0x6D95440", VA = "0x186D96040")]
	private void EFMHPFNOBOH([In] NativeArray<float3> HGOBDBHBIBI, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D97460", Offset = "0x6D96860", VA = "0x186D97460")]
	private void HNHLPIJIDGA([In] NativeArray<float3> HGOBDBHBIBI, NativeList<float3> MCLKEMPMBIF, NativeList<int> FJHCOGHKDDO, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D963B0", Offset = "0x6D957B0", VA = "0x186D963B0")]
	private float EKHLCIDPGPH(float3 DFIPADAPDJG, float3 GOFBCKNJDFC, DPGEKJKGDCJ IFEDELJNFIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D95DF0", Offset = "0x6D951F0", VA = "0x186D95DF0")]
	private float3 DIGEKGMGGBK(float3 MCPOGJOKKJH, float3 GMKCAEDFNLA, float3 LHGLEEDAFOL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D97430", Offset = "0x6D96830", VA = "0x186D97430")]
	private static float HGGPDMONGKI(float3 NIPIGODEADI, float3 BCMPBHCEGGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D97EC0", Offset = "0x6D972C0", VA = "0x186D97EC0")]
	private static float3 OBOCCICNDJB(float3 NIPIGODEADI, float3 BCMPBHCEGGA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D97A80", Offset = "0x6D96E80", VA = "0x186D97A80")]
	private bool LCDKLPCNAMA(float3 NIPIGODEADI, float3 BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D97DF0", Offset = "0x6D971F0", VA = "0x186D97DF0")]
	private bool MPKEIBHKDJI(float3 NIPIGODEADI, float3 BCMPBHCEGGA, float3 JEGEADOBKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D97AE0", Offset = "0x6D96EE0", VA = "0x186D97AE0")]
	private bool LJFGJLGPDCB(float3 NIPIGODEADI, float3 BCMPBHCEGGA, float3 JEGEADOBKMM, float3 ODLHKDJMEOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CLECJCMLAPB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BEJFNGACKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> MPLFJAJNCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> JCINBGMKOGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D93A30", Offset = "0x6D92E30", VA = "0x186D93A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GLDBAFPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D94320", Offset = "0x6D93720", VA = "0x186D94320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDLMGHLFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D93C50", Offset = "0x6D93050", VA = "0x186D93C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HCJNEHKNDIP HPNOMHFKGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D942A0", Offset = "0x6D936A0", VA = "0x186D942A0")]
		get
		{
			return default(HCJNEHKNDIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D94D20", Offset = "0x6D94120", VA = "0x186D94D20")]
	public CLECJCMLAPB(int DIKHPMLIBDL, int FDJNCEIGIHC, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D94DE0", Offset = "0x6D941E0", VA = "0x186D94DE0")]
	public CLECJCMLAPB(HCJNEHKNDIP NMCAOJLELNH, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D94E10", Offset = "0x6D94210", VA = "0x186D94E10")]
	public CLECJCMLAPB(Mesh NJMNIJFLOJJ, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D949B0", Offset = "0x6D93DB0", VA = "0x186D949B0")]
	public CLECJCMLAPB(CLECJCMLAPB AIKOCCMKKAE, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D93A70", Offset = "0x6D92E70", VA = "0x186D93A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D94560", Offset = "0x6D93960", VA = "0x186D94560")]
	public void LEFBGNCKNFL([In] CLECJCMLAPB GHEAAGKLGOO, float4x4 PDPDNLJIBAL, Transform LEBCEFANKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D93B00", Offset = "0x6D92F00", VA = "0x186D93B00")]
	public void EHCKFPHEMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D93C90", Offset = "0x6D93090", VA = "0x186D93C90")]
	public void IMEFFEADABL(float NHDEHMAPALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D94360", Offset = "0x6D93760", VA = "0x186D94360")]
	public CLECJCMLAPB KNCAKEIJLIO(Allocator HPLNAKONHEI, CancellationToken NBBCMDKGJKI)
	{
		return default(CLECJCMLAPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D94180", Offset = "0x6D93580", VA = "0x186D94180")]
	public Mesh JGKGBHOHBEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D948E0", Offset = "0x6D93CE0", VA = "0x186D948E0")]
	private unsafe static float3* MKLGHKMPBJD(NativeArray<float3> IGGIDMIPNHL)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D94930", Offset = "0x6D93D30", VA = "0x186D94930")]
	private unsafe static int* MKLGHKMPBJD(NativeArray<int> IGGIDMIPNHL)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D94980", Offset = "0x6D93D80", VA = "0x186D94980")]
	[CompilerGenerated]
	internal static void NKLMNKMMBLH(int GPADCCIEIJM, int ACBDNEIHPPA, BEJFNGACKKF P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HCJNEHKNDIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int PGEADEKJMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int GLDBAFPOMDF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CBMEAKPBINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D95080", Offset = "0x6D94480", VA = "0x186D95080")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x211E980", Offset = "0x211DD80", VA = "0x18211E980")]
	public static HCJNEHKNDIP HPADCFAMCHC(HCJNEHKNDIP NIPIGODEADI, HCJNEHKNDIP BCMPBHCEGGA)
	{
		return default(HCJNEHKNDIP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D94FC0", Offset = "0x6D943C0", VA = "0x186D94FC0")]
	public static HCJNEHKNDIP BKMEHFIHCLP(HCJNEHKNDIP CDLMGOEMNAB, int AFMDDDNOHPC)
	{
		return default(HCJNEHKNDIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D94FE0", Offset = "0x6D943E0", VA = "0x186D94FE0", Slot = "0")]
	public override bool Equals(object DMIDLHILBAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D95030", Offset = "0x6D94430", VA = "0x186D95030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D95090", Offset = "0x6D94490", VA = "0x186D95090", Slot = "3")]
	public override string ToString()
	{
		return null;
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
