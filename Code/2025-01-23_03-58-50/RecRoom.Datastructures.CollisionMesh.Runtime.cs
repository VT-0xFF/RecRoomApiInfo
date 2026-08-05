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
public struct NBIOEFDGFNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct NBMPKHNLGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int KKDGBNCIMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int EPOGKPNKHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int NALGHBNCIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int HMMMPGNCNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LEAHLKCCCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int AGLJGLNJLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 EGFJEOGDKFC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F030", Offset = "0x6F0D830", VA = "0x186F0F030")]
		public NBMPKHNLGOF(int GMIGHEOHLFB, int EHCDNPNDAPF, int NCEEBAPBKIJ, int NEHGNEFLLHB, int GDPMKFGLGIB, int AHANOFDOGLB, float3 LHHMNOGMEMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct JNIAKCBPGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int HEGKMEGMPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int BHHOCJBJHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float AMHGMCGLHCJ;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x15C8A20", Offset = "0x15C7220", VA = "0x1815C8A20")]
		public JNIAKCBPGLG(int DOCBAALINAN, int BDIKINEHFEI, float COGGIOLAEGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct PJDMBCLMHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int BHHOCJBJHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int CAFJJACLGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int DMPMLPKOCJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, NBMPKHNLGOF> DJELNEFGLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<JNIAKCBPGLG> JEOFIANIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> EKMLPCOOGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PJDMBCLMHNC> KHJHMIIPFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> COPGPNIMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int CDPNFJNAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int ECJBFFLKDPN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C720", Offset = "0x6F0AF20", VA = "0x186F0C720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DC70", Offset = "0x6F0C470", VA = "0x186F0DC70")]
	public bool NABCDPFELCF([In] NativeArray<float3> ABOGKLMNFGH, NativeList<float3> KELFIBOCKBN, NativeList<int> DOPPDPDAKDI, Allocator MOBIJPCBMOB, CancellationToken ALKEMFHOMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CD60", Offset = "0x6F0B560", VA = "0x186F0CD60")]
	private void EHFCOOMFLME([In] NativeArray<float3> ABOGKLMNFGH, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DE10", Offset = "0x6F0C610", VA = "0x186F0DE10")]
	private void PNFDEPIEMGG([In] NativeArray<float3> ABOGKLMNFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B780", Offset = "0x6F09F80", VA = "0x186F0B780")]
	private void ACCPPADKDMP([In] NativeArray<float3> ABOGKLMNFGH, [Out] int HMBKGOJPPDN, [Out] int JGGDLKKKPFL, [Out] int KALPDKFIOKM, [Out] int IIOMEKKNMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EE30", Offset = "0x6F0D630", VA = "0x186F0EE30")]
	private void PNJFBGFIHCI([In] NativeArray<float3> ABOGKLMNFGH, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BC40", Offset = "0x6F0A440", VA = "0x186F0BC40")]
	private void BGEGBGALMHE([In] NativeArray<float3> ABOGKLMNFGH, float3 KDFMPBNDHDB, int KJMHDEFPNPG, NBMPKHNLGOF FFPFLAFIDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C860", Offset = "0x6F0B060", VA = "0x186F0C860")]
	private void EDIPHJEIIKC([In] NativeArray<float3> ABOGKLMNFGH, float3 KDFMPBNDHDB, int IBKEKAGEIBB, int ECJBFFLKDPN, NBMPKHNLGOF FFPFLAFIDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C120", Offset = "0x6F0A920", VA = "0x186F0C120")]
	private void BNFOBNDBJMJ([In] NativeArray<float3> ABOGKLMNFGH, int CEAHDGACAEB, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D420", Offset = "0x6F0BC20", VA = "0x186F0D420")]
	private void LICOHJGOHHJ([In] NativeArray<float3> ABOGKLMNFGH, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D790", Offset = "0x6F0BF90", VA = "0x186F0D790")]
	private void LLJNHPDHCEE([In] NativeArray<float3> ABOGKLMNFGH, NativeList<float3> KELFIBOCKBN, NativeList<int> DOPPDPDAKDI, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D3C0", Offset = "0x6F0BBC0", VA = "0x186F0D3C0")]
	private float KNDOMBONLBL(float3 KDFMPBNDHDB, float3 JODOLNEFAGP, NBMPKHNLGOF FFPFLAFIDHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CC50", Offset = "0x6F0B450", VA = "0x186F0CC50")]
	private float3 EGFJEOGDKFC(float3 GMIGHEOHLFB, float3 EHCDNPNDAPF, float3 NCEEBAPBKIJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CF40", Offset = "0x6F0B740", VA = "0x186F0CF40")]
	private static float EKJLJHFNHDC(float3 DAOGAHJCGEC, float3 NBDADAEEFHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D360", Offset = "0x6F0BB60", VA = "0x186F0D360")]
	private static float3 GBPKLCEBPOL(float3 DAOGAHJCGEC, float3 NBDADAEEFHF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DDB0", Offset = "0x6F0C5B0", VA = "0x186F0DDB0")]
	private bool NKHDLGAIMPM(float3 DAOGAHJCGEC, float3 NBDADAEEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D290", Offset = "0x6F0BA90", VA = "0x186F0D290")]
	private bool FKHAKCGOFJF(float3 DAOGAHJCGEC, float3 NBDADAEEFHF, float3 HPEMNIMCDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CF70", Offset = "0x6F0B770", VA = "0x186F0CF70")]
	private bool EODOHFDGENB(float3 DAOGAHJCGEC, float3 NBDADAEEFHF, float3 HPEMNIMCDDO, float3 COGGIOLAEGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JAIOPFCJFOL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PCKNIIJOABM
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
	private NativeList<float3> LLFPIBOIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> AIGIJMJIFGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DLFHCPEDKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A440", Offset = "0x6F08C40", VA = "0x186F0A440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JFFCEEPLDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AC90", Offset = "0x6F09490", VA = "0x186F0AC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BJEHFDDNHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AC50", Offset = "0x6F09450", VA = "0x186F0AC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FGOAFKBHKPH CFBFOLIJPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A510", Offset = "0x6F08D10", VA = "0x186F0A510")]
		get
		{
			return default(FGOAFKBHKPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B6C0", Offset = "0x6F09EC0", VA = "0x186F0B6C0")]
	public JAIOPFCJFOL(int AJNIBFALBJI, int MJFDHGPEDFP, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B330", Offset = "0x6F09B30", VA = "0x186F0B330")]
	public JAIOPFCJFOL(FGOAFKBHKPH DNCOJCHEONI, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B1C0", Offset = "0x6F099C0", VA = "0x186F0B1C0")]
	public JAIOPFCJFOL(Mesh CGIEBOGCCKF, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B360", Offset = "0x6F09B60", VA = "0x186F0B360")]
	public JAIOPFCJFOL(JAIOPFCJFOL EBNFOODJNOB, Allocator MOBIJPCBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A480", Offset = "0x6F08C80", VA = "0x186F0A480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A7B0", Offset = "0x6F08FB0", VA = "0x186F0A7B0")]
	public void JGCMIIMCCFC([In] JAIOPFCJFOL IHDNMHOODCP, float4x4 KBJBMNDHNHM, Transform ODPMHDKHDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A660", Offset = "0x6F08E60", VA = "0x186F0A660")]
	public void IELPOBLDFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F0ACD0", Offset = "0x6F094D0", VA = "0x186F0ACD0")]
	public void NPFJKIJDPPM(float HFFBJNAMAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A240", Offset = "0x6F08A40", VA = "0x186F0A240")]
	public JAIOPFCJFOL ABIMPJKAOHC(Allocator MOBIJPCBMOB, CancellationToken ALKEMFHOMCA)
	{
		return default(JAIOPFCJFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AB30", Offset = "0x6F09330", VA = "0x186F0AB30")]
	public Mesh MIDDGMLKNBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A5C0", Offset = "0x6F08DC0", VA = "0x186F0A5C0")]
	private unsafe static float3* GHGHBIOPDIA(NativeArray<float3> GHAIAFELBIF)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A610", Offset = "0x6F08E10", VA = "0x186F0A610")]
	private unsafe static int* GHGHBIOPDIA(NativeArray<int> GHAIAFELBIF)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A590", Offset = "0x6F08D90", VA = "0x186F0A590")]
	[CompilerGenerated]
	internal static void FECLFOCOEDF(int LEMFAPLFHGG, int EEINMOHGJOA, PCKNIIJOABM P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FGOAFKBHKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DLFHCPEDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JFFCEEPLDFM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CAOILKHCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A170", Offset = "0x6F08970", VA = "0x186F0A170")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2214570", Offset = "0x2212D70", VA = "0x182214570")]
	public static FGOAFKBHKPH PPMHJPEALBG(FGOAFKBHKPH DAOGAHJCGEC, FGOAFKBHKPH NBDADAEEFHF)
	{
		return default(FGOAFKBHKPH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A180", Offset = "0x6F08980", VA = "0x186F0A180")]
	public static FGOAFKBHKPH LOGKCFGIBMI(FGOAFKBHKPH IKBDNDCFABJ, int JOADBJGEHIP)
	{
		return default(FGOAFKBHKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A0D0", Offset = "0x6F088D0", VA = "0x186F0A0D0", Slot = "0")]
	public override bool Equals(object FIOOAAHMJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A120", Offset = "0x6F08920", VA = "0x186F0A120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A1A0", Offset = "0x6F089A0", VA = "0x186F0A1A0", Slot = "3")]
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
