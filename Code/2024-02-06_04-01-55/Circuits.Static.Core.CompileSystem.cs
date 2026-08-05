using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F980", Offset = "0x1D4ED80", VA = "0x181D4F980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JIPONCCNAFE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class OIEDHANCFLD
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal DNLJCIPGMCH<OIEDHANCFLD> NADFMAPFHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal LBJJCFEPAMD<OIEDHANCFLD, object> MJBDEJGFNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal Dictionary<object, LELHOHFMKKF<OIEDHANCFLD>> LFKFACLONPO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B1B0", Offset = "0x1D4A5B0", VA = "0x181D4B1B0")]
	private JIPONCCNAFE([In] DNLJCIPGMCH<OIEDHANCFLD> HAIHHGAOCII, [In] LBJJCFEPAMD<OIEDHANCFLD, object> IKHNCNFCKNC, Dictionary<object, LELHOHFMKKF<OIEDHANCFLD>> IGGCLIDOENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D4AF90", Offset = "0x1D4A390", VA = "0x181D4AF90")]
	public static JIPONCCNAFE CPLKLKACALP()
	{
		return default(JIPONCCNAFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KNNMHDDMFNL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B310", Offset = "0x1D4A710", VA = "0x181D4B310")]
	public static void HJKKNDHGMPB(this JIPONCCNAFE LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B220", Offset = "0x1D4A620", VA = "0x181D4B220")]
	public static LELHOHFMKKF<JIPONCCNAFE.OIEDHANCFLD> ENFONJFLCDL(this JIPONCCNAFE LOMPFKEACIP, object BHPOPDOKECN)
	{
		return default(LELHOHFMKKF<JIPONCCNAFE.OIEDHANCFLD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FEDJEPCCKHP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MDMNOGPEEII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public DLJGBCHBPKA<int> LNNLFMMFGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DLJGBCHBPKA<int> GIGNIALHJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public int LDOIBPOBJOF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E5A0", Offset = "0x1D4D9A0", VA = "0x181D4E5A0")]
	private MDMNOGPEEII([In] DLJGBCHBPKA<int> PDGNJKPACAH, [In] DLJGBCHBPKA<int> GNMOPHJFPIO, int BGGAIHPPMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E510", Offset = "0x1D4D910", VA = "0x181D4E510")]
	public static MDMNOGPEEII CPLKLKACALP()
	{
		return default(MDMNOGPEEII);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LMAHOPHAHGL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B370", Offset = "0x1D4A770", VA = "0x181D4B370")]
	public static void HJKKNDHGMPB(this MDMNOGPEEII LOMPFKEACIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FFLENFIGGGB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class LBIODDIKKNE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum MMPJPAFALOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		External
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HHJDEFABOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DLJGBCHBPKA<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> LNNLFMMFGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DLJGBCHBPKA<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> GIGNIALHJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LELHOHFMKKF<ODJHIDELDPI<DGIOBIOGJFO>> NCKFNJGKLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MMPJPAFALOD JHBDNMIHDHA;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AF00", Offset = "0x1D4A300", VA = "0x181D4AF00")]
		private HHJDEFABOOA([In] DLJGBCHBPKA<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> PDGNJKPACAH, [In] DLJGBCHBPKA<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> GNMOPHJFPIO, LELHOHFMKKF<ODJHIDELDPI<DGIOBIOGJFO>> LBFNDPCIKGB, MMPJPAFALOD MLNFOPAANFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AE60", Offset = "0x1D4A260", VA = "0x181D4AE60")]
		public static HHJDEFABOOA CPLKLKACALP(MMPJPAFALOD MLNFOPAANFC)
		{
			return default(HHJDEFABOOA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal MHDMFCBHAMA<LBIODDIKKNE, HHJDEFABOOA> JHGNCDCEDPM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A830", Offset = "0x1D49C30", VA = "0x181D4A830")]
	private FFLENFIGGGB([In] MHDMFCBHAMA<LBIODDIKKNE, HHJDEFABOOA> KPAOBIHLHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A7C0", Offset = "0x1D49BC0", VA = "0x181D4A7C0")]
	public static FFLENFIGGGB CPLKLKACALP()
	{
		return default(FFLENFIGGGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ANFLKLKNLAA
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D493C0", Offset = "0x1D487C0", VA = "0x181D493C0")]
	public static void HJKKNDHGMPB(this FFLENFIGGGB.HHJDEFABOOA LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D49410", Offset = "0x1D48810", VA = "0x181D49410")]
	public static void HJKKNDHGMPB(this FFLENFIGGGB LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D49620", Offset = "0x1D48A20", VA = "0x181D49620")]
	public static DNLJCIPGMCH<FFLENFIGGGB.LBIODDIKKNE> MJOCKDGEEHM([In] this FFLENFIGGGB LOMPFKEACIP)
	{
		return default(DNLJCIPGMCH<FFLENFIGGGB.LBIODDIKKNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D492B0", Offset = "0x1D486B0", VA = "0x181D492B0")]
	public static LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> GFLLCANMGLD(this FFLENFIGGGB LOMPFKEACIP)
	{
		return default(LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D49660", Offset = "0x1D48A60", VA = "0x181D49660")]
	public static LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> PBBPENDPGOO(this FFLENFIGGGB LOMPFKEACIP)
	{
		return default(LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D495A0", Offset = "0x1D489A0", VA = "0x181D495A0")]
	public static void HOOPHLBNCJE(this FFLENFIGGGB LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FNOGEAGAPLC, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D49230", Offset = "0x1D48630", VA = "0x181D49230")]
	public static void DEIDPHHJLOD(this FFLENFIGGGB LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FNOGEAGAPLC, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DGIHNHGKHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public DLJGBCHBPKA<byte> BHDGDOCNFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public FFLENFIGGGB INLILPMLLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public DPEMNJPEKDB IDAADCEFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal JIPONCCNAFE JJLCPOCEOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LBJJCFEPAMD<JBNMDIJMNAO, DDIMHIFJAAJ?> NBMNDMCJJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DLJGBCHBPKA<LELHOHFMKKF<JBNMDIJMNAO>> EDHIAGMLKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LBJJCFEPAMD<AFPMDMCIBIC, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>>?> LIHHBIIGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DLJGBCHBPKA<(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> VariableId, LELHOHFMKKF<ODJHIDELDPI<CGOGDJCBDFI<LIHAIBJNIAK>>> ByteCodeWriteLocation)> NDEGADDPCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal DLJGBCHBPKA<(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> Target, LELHOHFMKKF<ODJHIDELDPI<ODJHIDELDPI<NOHLNGBLDAM>>> ByteCodeWriteLocation)> FIFLAGMLDDA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A130", Offset = "0x1D49530", VA = "0x181D4A130")]
	private DGIHNHGKHIJ([In] DLJGBCHBPKA<byte> HAMJDIIKPIL, [In] FFLENFIGGGB IOHEMKJCACN, [In] DPEMNJPEKDB KODONIBLMMO, [In] JIPONCCNAFE KANLLIONOLP, [In] LBJJCFEPAMD<JBNMDIJMNAO, DDIMHIFJAAJ?> FEEENKBGBPD, [In] DLJGBCHBPKA<LELHOHFMKKF<JBNMDIJMNAO>> FPMHNFJOOMH, [In] LBJJCFEPAMD<AFPMDMCIBIC, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>>?> EOGCANOAECO, [In] DLJGBCHBPKA<(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> VariableId, LELHOHFMKKF<ODJHIDELDPI<CGOGDJCBDFI<LIHAIBJNIAK>>> ByteCodeWriteLocation)> PBBLLGBDEGK, [In] DLJGBCHBPKA<(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> Target, LELHOHFMKKF<ODJHIDELDPI<ODJHIDELDPI<NOHLNGBLDAM>>> ByteCodeWriteLocation)> ALGOHCPBJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D49A00", Offset = "0x1D48E00", VA = "0x181D49A00")]
	public static DGIHNHGKHIJ CPLKLKACALP()
	{
		return default(DGIHNHGKHIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MNEPLGNEDEL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F210", Offset = "0x1D4E610", VA = "0x181D4F210")]
	public static void HJKKNDHGMPB(this DGIHNHGKHIJ LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F070", Offset = "0x1D4E470", VA = "0x181D4F070")]
	public static LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBFGMFHENFN(this DGIHNHGKHIJ LOMPFKEACIP)
	{
		return default(LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x275F490", Offset = "0x275E890", VA = "0x18275F490")]
	public static void PHCCPNEBAPA<M>(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD, LELHOHFMKKF<ODJHIDELDPI<CGOGDJCBDFI<M>>> IAMNLCEPAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F8F0", Offset = "0x1D4ECF0", VA = "0x181D4F8F0")]
	public static void POEENGCFEME(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> JILDGEDOLHB, LELHOHFMKKF<ODJHIDELDPI<ODJHIDELDPI<NOHLNGBLDAM>>> IDGMDHFGFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4ED70", Offset = "0x1D4E170", VA = "0x181D4ED70")]
	public static void CEPHKOJAMJL(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, LELHOHFMKKF<ODJHIDELDPI<DGIOBIOGJFO>> LBFNDPCIKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F590", Offset = "0x1D4E990", VA = "0x181D4F590")]
	public static void LLNNPEOBOOB(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F810", Offset = "0x1D4EC10", VA = "0x181D4F810")]
	public static void PIAHKPEIKHF(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO, [In] DDIMHIFJAAJ AGFFFBCPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EF40", Offset = "0x1D4E340", VA = "0x181D4EF40")]
	public static void ENNAPCFCADO(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO, [In] DDIMHIFJAAJ AGFFFBCPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D4ECB0", Offset = "0x1D4E0B0", VA = "0x181D4ECB0")]
	public static DDIMHIFJAAJ? BBMLJNDHDPA([In] this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x275C320", Offset = "0x275B720", VA = "0x18275C320")]
	public static DDIMHIFJAAJ BOAMICIAKIH<TDeps, TStateSys>(this DGIHNHGKHIJ LOMPFKEACIP, TDeps MLLANHDPJEE, TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC) where TDeps : AJNGLNHBNGE<TStateSys>
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F430", Offset = "0x1D4E830", VA = "0x181D4F430")]
	private static void JKMBODPACME(this DGIHNHGKHIJ LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F180", Offset = "0x1D4E580", VA = "0x181D4F180")]
	private static LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>>? GKJKICBLPJE([In] this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x275EED0", Offset = "0x275E2D0", VA = "0x18275EED0")]
	public static DLBPHLJHNIJ OEJLFIIKEFA<TDeps, TStateSys>(this DGIHNHGKHIJ LOMPFKEACIP, TDeps MLLANHDPJEE, TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO) where TDeps : AJNGLNHBNGE<TStateSys>
	{
		return default(DLBPHLJHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EDE0", Offset = "0x1D4E1E0", VA = "0x181D4EDE0")]
	public static void CGKPEJFHJJI(this DGIHNHGKHIJ LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x275CD80", Offset = "0x275C180", VA = "0x18275CD80")]
	public static int CBPAIPFOJKE<TDeps, TStateSys>(this DGIHNHGKHIJ LOMPFKEACIP, TDeps MLLANHDPJEE, TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LBJJCFEPAMD<FFLENFIGGGB.LBIODDIKKNE, MDMNOGPEEII> GPNKMGGBGLK) where TDeps : AJNGLNHBNGE<TStateSys>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F640", Offset = "0x1D4EA40", VA = "0x181D4F640")]
	public static void PAKICJDEGNH(this DGIHNHGKHIJ LOMPFKEACIP, [In] LBJJCFEPAMD<FFLENFIGGGB.LBIODDIKKNE, MDMNOGPEEII> ALCGGHFAOOG, int PGNJLBFDJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DDIMHIFJAAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CGEJANHCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Register
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct GBFNKNEKPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> ODFMEJJPGEB;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		public GBFNKNEKPFF(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> CBDMJNNLBHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FOPFLJNGMFG : IEquatable<FOPFLJNGMFG>, OOCNEMALIND<FOPFLJNGMFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ReadOnlyMemory<byte> GMLHINFPKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public MNCMOJKJMDJ HAMPOHKEFDP;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AE30", Offset = "0x1D4A230", VA = "0x181D4AE30")]
		private FOPFLJNGMFG([In] ReadOnlyMemory<byte> PIOIENDCJNH, MNCMOJKJMDJ PNBCDLIICAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AAE0", Offset = "0x1D49EE0", VA = "0x181D4AAE0")]
		public static FOPFLJNGMFG KAOIEPBCJKH(bool PPMCHNIMAJP)
		{
			return default(FOPFLJNGMFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AB40", Offset = "0x1D49F40", VA = "0x181D4AB40")]
		public static FOPFLJNGMFG OMBDOICDGEF([In] ReadOnlyMemory<byte> PIOIENDCJNH)
		{
			return default(FOPFLJNGMFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AA90", Offset = "0x1D49E90", VA = "0x181D4AA90")]
		public static FOPFLJNGMFG JEBMDCKPFBP(int BJALNEHCPKI)
		{
			return default(FOPFLJNGMFG);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A870", Offset = "0x1D49C70", VA = "0x181D4A870")]
		public static bool HOHCACPHFGD([In] FOPFLJNGMFG NNOKPENDLPE, [In] FOPFLJNGMFG OBLEBBNJEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A8E0", Offset = "0x1D49CE0", VA = "0x181D4A8E0", Slot = "4")]
		public bool Equals(FOPFLJNGMFG KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A870", Offset = "0x1D49C70", VA = "0x181D4A870")]
		public bool CKOGKAMODKI([In] FOPFLJNGMFG KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A950", Offset = "0x1D49D50", VA = "0x181D4A950", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AA30", Offset = "0x1D49E30", VA = "0x181D4AA30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AB80", Offset = "0x1D49F80", VA = "0x181D4AB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4A870", Offset = "0x1D49C70", VA = "0x181D4A870", Slot = "5")]
		private bool MFMMDDCFJDP([In] FOPFLJNGMFG KMJGEHGGFFC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct EJBDOKNCFPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FHOADFIEACM;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		public EJBDOKNCFPH(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GBFNKNEKPFF FKPMEJBHHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FOPFLJNGMFG PJACLBNOPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly EJBDOKNCFPH NLKKEGKJEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly CGEJANHCGCM GNLOEIGGPMF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D499B0", Offset = "0x1D48DB0", VA = "0x181D499B0")]
	private DDIMHIFJAAJ(GBFNKNEKPFF CNHHOCNNDBH, [In] FOPFLJNGMFG IMAEBGDPKBP, EJBDOKNCFPH HOJGMPHIEKK, CGEJANHCGCM KIBGEDPLBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D49960", Offset = "0x1D48D60", VA = "0x181D49960")]
	public static DDIMHIFJAAJ KELOAOPJECB(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> CBDMJNNLBHK)
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D498D0", Offset = "0x1D48CD0", VA = "0x181D498D0")]
	public static DDIMHIFJAAJ IFLMKBCAHGN(bool PPMCHNIMAJP)
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D497D0", Offset = "0x1D48BD0", VA = "0x181D497D0")]
	public static DDIMHIFJAAJ BLPOBBPJJFO([In] ReadOnlyMemory<byte> PIOIENDCJNH)
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D49840", Offset = "0x1D48C40", VA = "0x181D49840")]
	public static DDIMHIFJAAJ GELFJJIDLAE(int BJALNEHCPKI)
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D49770", Offset = "0x1D48B70", VA = "0x181D49770")]
	public static DDIMHIFJAAJ BHMEKAPPIFG(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> ADOLIHOBCPN)
	{
		return default(DDIMHIFJAAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KAOKAIEDEFE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910")]
	public static DLBPHLJHNIJ JAPEMIAJJMN([In] this DDIMHIFJAAJ LOMPFKEACIP)
	{
		return default(DLBPHLJHNIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DLBPHLJHNIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum BOIMGHAEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		OutNode,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Branch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly BOIMGHAEGKG GNLOEIGGPMF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
	private DLBPHLJHNIJ(BOIMGHAEGKG KIBGEDPLBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910")]
	public static DLBPHLJHNIJ KELOAOPJECB()
	{
		return default(DLBPHLJHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910")]
	public static DLBPHLJHNIJ JNGCHIAEJNF([In] DDIMHIFJAAJ OIGNJCHPDMC)
	{
		return default(DLBPHLJHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4F0", Offset = "0x7EA8F0", VA = "0x1807EB4F0")]
	public static DLBPHLJHNIJ BFHCEIMGKLA()
	{
		return default(DLBPHLJHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x89A600", Offset = "0x899A00", VA = "0x18089A600")]
	public static DLBPHLJHNIJ BGANBJGHHBN()
	{
		return default(DLBPHLJHNIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface AJNGLNHBNGE<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LELHOHFMKKF<ECOFEFAAHJD> JHJCBHMCNHG(TStateSys GAAKFGPIGNK);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DLBPHLJHNIJ MBPDJOMIPKA(TStateSys GAAKFGPIGNK, DGIHNHGKHIJ CLMBBHMMNEK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDIMHIFJAAJ OOKNJDACADD(TStateSys GAAKFGPIGNK, DGIHNHGKHIJ CLMBBHMMNEK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int AFBBFIIINFI(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LELHOHFMKKF<JBNMDIJMNAO> ELKIHPHBAHM(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC, int OLKNHMDELHK);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FEDJEPCCKHP NMJJAFKEKGC(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AOFFGJPMBPI(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int LPLJIHBNHEH(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MEIAKDLKHNA<byte> DLFAMKAGPDP(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	object HJNIKBMIMND(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<AFPMDMCIBIC> MIPIBMCBIIC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int GABABKGLKMB(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LELHOHFMKKF<AFPMDMCIBIC> FEKOFHMPFEG(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, LELHOHFMKKF<JBNMDIJMNAO> KPOALPLEIEO, int HOEENOPNIEN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int NIGEJPKIECM(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ACPMHJBEIGC(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "14")]
	int MHAKGELBIAG(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int AAHNAKKFEFL(TStateSys GAAKFGPIGNK, LELHOHFMKKF<BBFMEDFDBAF> NGLJABNBABA, int AHDNEIKOMIB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MBKALGIGELO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C730", Offset = "0x1D4BB30", VA = "0x181D4C730")]
	public static LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> ECKLKIDLCHO([In] this DGIHNHGKHIJ LOMPFKEACIP)
	{
		return default(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D010", Offset = "0x1D4C410", VA = "0x181D4D010")]
	private static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> INBAOPNKOKI(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB, int FMGGKGOEKMO)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E140", Offset = "0x1D4D540", VA = "0x181D4E140")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> PANEMDMOEIE(this DGIHNHGKHIJ LOMPFKEACIP, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CB80", Offset = "0x1D4BF80", VA = "0x181D4CB80")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> GHADIGAGLAH(this DGIHNHGKHIJ LOMPFKEACIP, int HFPFBPPBALK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B3C0", Offset = "0x1D4A7C0", VA = "0x181D4B3C0")]
	private static void AEMKKANIKFH(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C870", Offset = "0x1D4BC70", VA = "0x181D4C870")]
	public static void FCHAKHOAMDB(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD, int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BCE0", Offset = "0x1D4B0E0", VA = "0x181D4BCE0")]
	private static void DEIDPHHJLOD(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CCF0", Offset = "0x1D4C0F0", VA = "0x181D4CCF0")]
	private static void HOOPHLBNCJE(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BB00", Offset = "0x1D4AF00", VA = "0x181D4BB00")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> CEAPKOBDEMB(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, float LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CF20", Offset = "0x1D4C320", VA = "0x181D4CF20")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> IEPOIFEPCDA(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B830", Offset = "0x1D4AC30", VA = "0x181D4B830")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> BBOMFNKKALD(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B570", Offset = "0x1D4A970", VA = "0x181D4B570")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> AIEGJJKLEPG(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, int LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D150", Offset = "0x1D4C550", VA = "0x181D4D150")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> IPPMPLDIOIC(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D420", Offset = "0x1D4C820", VA = "0x181D4D420")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> JNPLLMCPNKB(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C2C0", Offset = "0x1D4B6C0", VA = "0x181D4C2C0")]
	public static void DOEOAFLLFBI(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<ECOFEFAAHJD> PKJJJPLMDJI, [In] ReadOnlySpan<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> GNMOPHJFPIO, [In] ReadOnlySpan<int> OIABGDJMCEK, [In] Span<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> BGAGJBFMHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D890", Offset = "0x1D4CC90", VA = "0x181D4D890")]
	public static void LBPHEHJDIEP(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<CFHOJMBIJKE> GBPFJLCFOIO, [In] ReadOnlySpan<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> GNMOPHJFPIO, [In] ReadOnlySpan<int> OIABGDJMCEK, [In] Span<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> BGAGJBFMHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CE60", Offset = "0x1D4C260", VA = "0x181D4CE60")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> IEJOOGLFOPL(this DGIHNHGKHIJ LOMPFKEACIP, int BJPEAGPCDMF, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E440", Offset = "0x1D4D840", VA = "0x181D4E440")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> PPELABBNBPI(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> BJPEAGPCDMF, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D4DC10", Offset = "0x1D4D010", VA = "0x181D4DC10")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> MIDOJIFIKDN(this DGIHNHGKHIJ LOMPFKEACIP, [In] ReadOnlySpan<byte> BJPEAGPCDMF, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BD60", Offset = "0x1D4B160", VA = "0x181D4BD60")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> DEIFILGNEMH(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> BJPEAGPCDMF, int HFPFBPPBALK, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C640", Offset = "0x1D4BA40", VA = "0x181D4C640")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> DPGIIHHDHEO(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, float LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D4DCF0", Offset = "0x1D4D0F0", VA = "0x181D4DCF0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> NCMOGIJHPAF(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BBF0", Offset = "0x1D4AFF0", VA = "0x181D4BBF0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> DEHCOCGEDIA(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B650", Offset = "0x1D4AA50", VA = "0x181D4B650")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> AKEMBGPPJBP(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, int LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B920", Offset = "0x1D4AD20", VA = "0x181D4B920")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> CACPEEOFIGE(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D7A0", Offset = "0x1D4CBA0", VA = "0x181D4D7A0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LAOEIEPDJGI(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E260", Offset = "0x1D4D660", VA = "0x181D4E260")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> PANPIDCPGIG(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, float LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4DDE0", Offset = "0x1D4D1E0", VA = "0x181D4DDE0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> OAECFBOKKDO(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C9B0", Offset = "0x1D4BDB0", VA = "0x181D4C9B0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FLAFLNIBBFA(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C790", Offset = "0x1D4BB90", VA = "0x181D4C790")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> ELEMNONKJDM(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, int LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D510", Offset = "0x1D4C910", VA = "0x181D4D510")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> JOOFBLAKKNP(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BA10", Offset = "0x1D4AE10", VA = "0x181D4BA10")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> CCLCLJIIPNN(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B560", Offset = "0x1D4A960", VA = "0x181D4B560")]
	public static void AHAJEBFALJE(this DGIHNHGKHIJ LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CD70", Offset = "0x1D4C170", VA = "0x181D4CD70")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> IAOALAAJDML(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, float LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E350", Offset = "0x1D4D750", VA = "0x181D4E350")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> POOMGKOBFHE(this DGIHNHGKHIJ LOMPFKEACIP, float EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CC00", Offset = "0x1D4C000", VA = "0x181D4CC00")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> HBOIMCBIPND(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D4CAA0", Offset = "0x1D4BEA0", VA = "0x181D4CAA0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FNMANONJPPP(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, int LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D330", Offset = "0x1D4C730", VA = "0x181D4D330")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> JGDLJKOBFNC(this DGIHNHGKHIJ LOMPFKEACIP, int EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D240", Offset = "0x1D4C640", VA = "0x181D4D240")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> JCKJDBMPPKC(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> EJPBCDHDKFH, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> LKNIMMJAMGL)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D4DED0", Offset = "0x1D4D2D0", VA = "0x181D4DED0")]
	public static void OHGHIPFAFIA(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<CFHOJMBIJKE> KCPEOJNECNI, [In] ReadOnlySpan<(DDIMHIFJAAJ DataBack, int Size)> FFINEOJMJJP, [In] ReadOnlySpan<int> OIABGDJMCEK, [In] Span<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> BGAGJBFMHBL, [In] Span<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>> NDHJLHBDLCA, [In] ReadOnlySpan<LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>?> FOMPDCAIOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D4BE60", Offset = "0x1D4B260", VA = "0x181D4BE60")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> DFCKIHEMHAB(this DGIHNHGKHIJ LOMPFKEACIP, [In] DDIMHIFJAAJ.FOPFLJNGMFG IMAEBGDPKBP, int HFPFBPPBALK, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D4D600", Offset = "0x1D4CA00", VA = "0x181D4D600")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KMGEBNGJCIC(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FGALBCIEAPG, int HFPFBPPBALK, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C020", Offset = "0x1D4B420", VA = "0x181D4C020")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> DMLJEMKGGDJ(this DGIHNHGKHIJ LOMPFKEACIP, [In] DDIMHIFJAAJ EODLAJCLDDD, int HFPFBPPBALK, [Optional] LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? KGJKGLPDNBK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2748D30", Offset = "0x2748130", VA = "0x182748D30")]
	private static void MPKOHCGKFGK<TStateSys, TDeps>(this DGIHNHGKHIJ LOMPFKEACIP, TStateSys GAAKFGPIGNK, TDeps MLLANHDPJEE) where TStateSys : notnull where TDeps : notnull, AJNGLNHBNGE<TStateSys>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2748C10", Offset = "0x2748010", VA = "0x182748C10")]
	public static DDIMHIFJAAJ DCODJAEHJAK<TStateSys, TDeps>(this DGIHNHGKHIJ LOMPFKEACIP, TStateSys GAAKFGPIGNK, TDeps MLLANHDPJEE) where TStateSys : notnull where TDeps : notnull, AJNGLNHBNGE<TStateSys>
	{
		return default(DDIMHIFJAAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2748D10", Offset = "0x2748110", VA = "0x182748D10")]
	public static DLBPHLJHNIJ MMBGCFLHCJD<TStateSys, TDeps>(this DGIHNHGKHIJ LOMPFKEACIP, TStateSys GAAKFGPIGNK, TDeps MLLANHDPJEE) where TStateSys : notnull where TDeps : notnull, AJNGLNHBNGE<TStateSys>
	{
		return default(DLBPHLJHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D4B730", Offset = "0x1D4AB30", VA = "0x181D4B730")]
	private static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> ANHAAFPMDHE(this DGIHNHGKHIJ LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>? FGALBCIEAPG, int HFPFBPPBALK)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FHECOMDMCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> JNCCGPMNGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> BCIPFGEMIPG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA43A60", Offset = "0xA42E60", VA = "0x180A43A60")]
	public FHECOMDMCDA(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> OJANFJMPJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A860", Offset = "0x1D49C60", VA = "0x181D4A860")]
	public static FHECOMDMCDA CPLKLKACALP(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA)
	{
		return default(FHECOMDMCDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DPEMNJPEKDB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class FKCAMPCDPBD : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct APLPDJGKBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FHJKAILHOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int BLAEHDOLMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int POAGBMGKBLI;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x18A2850", Offset = "0x18A1C50", VA = "0x1818A2850")]
		public APLPDJGKBGB(LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB, int FMGGKGOEKMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class OHKFEMCKFCK : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct AIINEOCPKMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int BLAEHDOLMPP;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		public AIINEOCPKMF(int AHDNEIKOMIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class JHNMFALMGPB : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct MIJMAIHFPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FHJKAILHOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int BLAEHDOLMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int POAGBMGKBLI;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x18A2850", Offset = "0x18A1C50", VA = "0x1818A2850")]
		public MIJMAIHFPAH(LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB, int FMGGKGOEKMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum IKMBPHMMCMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class FPLMOECEJHD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct IEJIMPAAFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public FHECOMDMCDA GOMPKABFNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IKMBPHMMCMM JHBDNMIHDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LELHOHFMKKF<PGKNFAOGAMJ> IDAMLDIIGJF;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AF80", Offset = "0x1D4A380", VA = "0x181D4AF80")]
		private IEJIMPAAFJE([In] FHECOMDMCDA MJBIMFBEGLA, IKMBPHMMCMM MLNFOPAANFC, LELHOHFMKKF<PGKNFAOGAMJ> HOCGFHFFNLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1D4AF60", Offset = "0x1D4A360", VA = "0x181D4AF60")]
		public static IEJIMPAAFJE CPLKLKACALP(LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA, IKMBPHMMCMM MLNFOPAANFC, LELHOHFMKKF<PGKNFAOGAMJ> HOCGFHFFNLL)
		{
			return default(IEJIMPAAFJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class NNDIBEINOEN : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct DPJPFGPNKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int POAGBMGKBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool BMKALGGKBNN;
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class JALHCDPILLC : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct OCPNKLFBNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int BLAEHDOLMPP;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		public OCPNKLFBNHD(int AHDNEIKOMIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class EJGNOEHCHCF : PGKNFAOGAMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct IANJPLNBPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int POAGBMGKBLI;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		public IANJPLNBPCA(int FMGGKGOEKMO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal MHDMFCBHAMA<FPLMOECEJHD, IEJIMPAAFJE> JHGNCDCEDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal MHDMFCBHAMA<EJGNOEHCHCF, IANJPLNBPCA> GIKCJFKAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MHDMFCBHAMA<NNDIBEINOEN, DPJPFGPNKKE> MPJIEHNAOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal MHDMFCBHAMA<FKCAMPCDPBD, APLPDJGKBGB> FHAGHMKGLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal MHDMFCBHAMA<JHNMFALMGPB, MIJMAIHFPAH> HEMEHPBPBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal MHDMFCBHAMA<JALHCDPILLC, OCPNKLFBNHD> ODAEEDBBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal MHDMFCBHAMA<OHKFEMCKFCK, AIINEOCPKMF> ICMBGIMAFEI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A610", Offset = "0x1D49A10", VA = "0x181D4A610")]
	private DPEMNJPEKDB([In] MHDMFCBHAMA<FPLMOECEJHD, IEJIMPAAFJE> KPAOBIHLHEE, [In] MHDMFCBHAMA<EJGNOEHCHCF, IANJPLNBPCA> FCCKDPDOCNK, [In] MHDMFCBHAMA<NNDIBEINOEN, DPJPFGPNKKE> MEKAPBJKMAP, [In] MHDMFCBHAMA<FKCAMPCDPBD, APLPDJGKBGB> HNEPGCBNMME, [In] MHDMFCBHAMA<JHNMFALMGPB, MIJMAIHFPAH> KMCIFOACHEH, [In] MHDMFCBHAMA<JALHCDPILLC, OCPNKLFBNHD> DGMFOKJCNNC, [In] MHDMFCBHAMA<OHKFEMCKFCK, AIINEOCPKMF> LKKJAFLIOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D4A360", Offset = "0x1D49760", VA = "0x181D4A360")]
	public static DPEMNJPEKDB CPLKLKACALP()
	{
		return default(DPEMNJPEKDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MJHAEHKMGMN
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EAF0", Offset = "0x1D4DEF0", VA = "0x181D4EAF0")]
	public static void HJKKNDHGMPB(this DPEMNJPEKDB LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EA30", Offset = "0x1D4DE30", VA = "0x181D4EA30")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> GHADIGAGLAH(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA, int FMGGKGOEKMO)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E5F0", Offset = "0x1D4D9F0", VA = "0x181D4E5F0")]
	public static void AEMKKANIKFH(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E800", Offset = "0x1D4DC00", VA = "0x181D4E800")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> BPGGKKNOIPB(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA, LELHOHFMKKF<FFLENFIGGGB.LBIODDIKKNE> FBDDBFEHDPD, int AHDNEIKOMIB, int FMGGKGOEKMO)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1D4EBE0", Offset = "0x1D4DFE0", VA = "0x181D4EBE0")]
	public static LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> PANEMDMOEIE(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> KKCODFFCLIA, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E8F0", Offset = "0x1D4DCF0", VA = "0x181D4E8F0")]
	public static void FCHAKHOAMDB(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> KHMKCCNIGOD, int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D4E790", Offset = "0x1D4DB90", VA = "0x181D4E790")]
	public static void AEPGFDIJFID(this DPEMNJPEKDB LOMPFKEACIP, LELHOHFMKKF<DPEMNJPEKDB.FPLMOECEJHD> FNOGEAGAPLC, LELHOHFMKKF<ODJHIDELDPI<NOHLNGBLDAM>> BKPIOOJDHLI)
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
