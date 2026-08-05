using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5B7FAA0", Offset = "0x5B7E4A0", VA = "0x185B7FAA0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x812880", Offset = "0x811280", VA = "0x180812880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FEAABBDDLMM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D860", Offset = "0x5B7C260", VA = "0x185B7D860")]
	public static bool GJBEIFBPCIM(GGCJNIMFEND MGPIFHHJNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D4E0", Offset = "0x5B7BEE0", VA = "0x185B7D4E0")]
	private static bool GJBEIFBPCIM(IPKEJDBNDEC EOJBPKALALP, ref GGCJNIMFEND MGPIFHHJNGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MJDPGJOLLHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<DACGKLHBLIE> PIFCKJGGEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<NNPINKKKPKP> LPIMONCHGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public DOBEMAPNGKH FCDEFLMGLDL;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OOFNKEDJFKF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(PBGCDCPMMIL JIHCLPECHIB, out Dictionary<int, int> OENOPKGIBOG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KECCLNDCEEL MKIJCLJEPJN, OINPFEEGPCE HGNOALLINCG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JMPNHLMCPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DEDOFPENDPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> FKKLFCNECHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> CGNEAHKIKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676940", VA = "0x180677F40")]
	public DEDOFPENDPA(Dictionary<Guid, Guid> FKKLFCNECHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D440", Offset = "0x5B7BE40", VA = "0x185B7D440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PLGGLBPIKAH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EIIEJLEGLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OECFCBNJLAA destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public EIIEJLEGLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D490", Offset = "0x5B7BE90", VA = "0x185B7D490")]
		internal bool <InitializeCircuitsV2Remapping>b__0(MGKJIBKNGDG n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GPEJJALPFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GPEJJALPFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EED0", Offset = "0x5B7D8D0", VA = "0x185B7EED0")]
		internal void <InitializeCircuitsV2Remapping>b__1(MGKJIBKNGDG n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, IPKEJDBNDEC> EFDJMCJAHLA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> HCKEPEIHBJI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<NNPINKKKPKP> OEMADBKBJMG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<OECFCBNJLAA> ALICAKALHDB;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DDBIHBBFPMN> OBNHIGHDPGG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5B81F20", Offset = "0x5B80920", VA = "0x185B81F20")]
	public static LHHHAADIFPP ICCPJNFDPNM(MJDPGJOLLHP KMBALCOCAPJ, out HOHIDEJJGEL PHMOJEPEKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5B82CC0", Offset = "0x5B816C0", VA = "0x185B82CC0")]
	private static void KHIGJLNPLCL(LHHHAADIFPP MMCKGEKFIBI, out HOHIDEJJGEL PHMOJEPEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5B83AE0", Offset = "0x5B824E0", VA = "0x185B83AE0")]
	private static void OAMKKJONNMH(DACGKLHBLIE MCONGCCCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5B81730", Offset = "0x5B80130", VA = "0x185B81730")]
	private static void FDFCFKIIPOA(LHHHAADIFPP MMCKGEKFIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5B80B10", Offset = "0x5B7F510", VA = "0x185B80B10")]
	private static void EGEBKMKNKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5B81C10", Offset = "0x5B80610", VA = "0x185B81C10")]
	private static void HOJAMMDDOLB(ref MJDPGJOLLHP KOIHKGCGPGP, DACGKLHBLIE MCONGCCCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5B7FB30", Offset = "0x5B7E530", VA = "0x185B7FB30")]
	public static bool AHPLHHGMBOF(LHHHAADIFPP MMCKGEKFIBI, CPPOODBBIEC CCBAKEAMIGL, out DEDOFPENDPA? PINHEIAKHCP, out string? OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5B81A20", Offset = "0x5B80420", VA = "0x185B81A20")]
	private static void GEPFANKPHJM(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B809F0", Offset = "0x5B7F3F0", VA = "0x185B809F0")]
	private static void DHFIFPLJCDO(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B82400", Offset = "0x5B80E00", VA = "0x185B82400")]
	private static bool JIPLGFBGNPE(LHHHAADIFPP MMCKGEKFIBI, KECCLNDCEEL MKIJCLJEPJN, ref CPPOODBBIEC CCBAKEAMIGL, out string OOMNIJBIFDC, out Dictionary<int, int> OENOPKGIBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B83860", Offset = "0x5B82260", VA = "0x185B83860")]
	private static Dictionary<Guid, IPKEJDBNDEC> NJAPPIKCKFE(LHHHAADIFPP MMCKGEKFIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5B837E0", Offset = "0x5B821E0", VA = "0x185B837E0")]
	private static void MKAMEGMLKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B82DF0", Offset = "0x5B817F0", VA = "0x185B82DF0")]
	private static bool LEECFCKDEBB(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL, out string? OOMNIJBIFDC, out EPJFCKOCMKD? PDCEPJDAOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B80A80", Offset = "0x5B7F480", VA = "0x185B80A80")]
	private static void EBLDMIKGBON(bool PJNDPPOKLFJ, DACGKLHBLIE AEABGDOMKJP, Dictionary<Guid, Guid> BBFEIKIAHFK, EPJFCKOCMKD DCMGLLFIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5B83C70", Offset = "0x5B82670", VA = "0x185B83C70")]
	private static void OPEELJAOLKB(bool PJNDPPOKLFJ, DACGKLHBLIE AEABGDOMKJP, EPJFCKOCMKD PDCEPJDAOGI, Guid LBNOEGJEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B82A20", Offset = "0x5B81420", VA = "0x185B82A20")]
	private static void JOOCFEDNLKB(DACGKLHBLIE AEABGDOMKJP, Guid FNILFCGHGND, BAODOBOCCJB? NMAGIJJIFEH, Dictionary<Guid, IPKEJDBNDEC> PMINACKHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B81B20", Offset = "0x5B80520", VA = "0x185B81B20")]
	private static void HKBJEMKGBJD(DACGKLHBLIE AEABGDOMKJP, Dictionary<Guid, Guid> BBFEIKIAHFK, Dictionary<int, int> FIHLPDFJJLE, KECCLNDCEEL JOEKNLHMDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5B803B0", Offset = "0x5B7EDB0", VA = "0x185B803B0")]
	public static void BFHBPIICDAL(RepeatedField<DACGKLHBLIE> JEJKAFADIKJ, FAIAEMMAMKM HDCFNJINFNJ, IEnumerable<ByteString> FMJDAFAOOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5B80BF0", Offset = "0x5B7F5F0", VA = "0x185B80BF0")]
	private static void EKMBOEONCNO(RepeatedField<DACGKLHBLIE> JEJKAFADIKJ, GCJOMCHOLCP GEHKDLFJEGI, JMPNHLMCPMJ OIECBHABCNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CPPOODBBIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool PJNDPPOKLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool JPLAMJOEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BAODOBOCCJB? NMAGIJJIFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public BAODOBOCCJB? BMCLLHLKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KGBIEOPGBLP LCDKHBGLHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public JMPNHLMCPMJ OIECBHABCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public OOFNKEDJFKF GDMFBNFINNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid LBNOEGJEDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public DOBEMAPNGKH FCDEFLMGLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<DACGKLHBLIE> KCNOFJKANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> JGKPLIKEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public OOBHJMNKLGL OLFNBJEKCCL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BAODOBOCCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 EINGNKDKDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion JGCPJBFFFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float IIOOEIFOODC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 OFMMOAKMMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7CAA0", Offset = "0x5B7B4A0", VA = "0x185B7CAA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BAODOBOCCJB CLABDLEKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B7C8A0", Offset = "0x5B7B2A0", VA = "0x185B7C8A0")]
		get
		{
			return default(BAODOBOCCJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FCNJEFOKJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B7CCF0", Offset = "0x5B7B6F0", VA = "0x185B7CCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1487B60", Offset = "0x1486560", VA = "0x181487B60")]
	public BAODOBOCCJB(Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC, float IIOOEIFOODC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CF20", Offset = "0x5B7B920", VA = "0x185B7CF20")]
	public BAODOBOCCJB(HIHIBEMHLMN EMBLGEALPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CEC0", Offset = "0x5B7B8C0", VA = "0x185B7CEC0")]
	private BAODOBOCCJB(NAFEIACPJKK FEBNHMNHLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CE90", Offset = "0x5B7B890", VA = "0x185B7CE90")]
	public static BAODOBOCCJB OEKMACNCPIF(NNPINKKKPKP CINCMEGDDNK)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CBA0", Offset = "0x5B7B5A0", VA = "0x185B7CBA0")]
	public static BAODOBOCCJB HFNODMLLHDI(BAODOBOCCJB LFAIGCEGCPL, BAODOBOCCJB OHEMGHNHJNB)
	{
		return default(BAODOBOCCJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C750", Offset = "0x5B7B150", VA = "0x185B7C750")]
	public static BAODOBOCCJB DGKBAOBECFH((Vector3, Quaternion, float) JIHCLPECHIB)
	{
		return default(BAODOBOCCJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C7A0", Offset = "0x5B7B1A0", VA = "0x185B7C7A0")]
	public static BAODOBOCCJB DGKBAOBECFH(Matrix4x4 KHMHDJDEHCN)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CD00", Offset = "0x5B7B700", VA = "0x185B7CD00")]
	public BAODOBOCCJB LOLBLKECJMK(Matrix4x4 HJLACGOIJCA)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C8D0", Offset = "0x5B7B2D0", VA = "0x185B7C8D0")]
	[CompilerGenerated]
	internal static BAODOBOCCJB GKFCCINHPIK(NNPINKKKPKP ELOCLFMIMAL)
	{
		return default(BAODOBOCCJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GONABMHMLHM : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E640", Offset = "0x5B7D040", VA = "0x185B7E640", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E750", Offset = "0x5B7D150", VA = "0x185B7E750")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, LCLHGCLBOKF FBPBLOADEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E6F0", Offset = "0x5B7D0F0", VA = "0x185B7E6F0")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, FIAKLCOIGGI CAMCLBDCGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EC80", Offset = "0x5B7D680", VA = "0x185B7EC80")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, PPCNFFLNPKD HFACFEGGHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public GONABMHMLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BMOMPILCFDL : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D230", Offset = "0x5B7BC30", VA = "0x185B7D230", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public BMOMPILCFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LOFBALPMHEG : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F930", Offset = "0x5B7E330", VA = "0x185B7F930", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public LOFBALPMHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DDNECEMMAJG : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D2F0", Offset = "0x5B7BCF0", VA = "0x185B7D2F0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public DDNECEMMAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KIFNOCHKDLB : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F480", Offset = "0x5B7DE80", VA = "0x185B7F480", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public KIFNOCHKDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class LMDIEKGDOGK : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F7B0", Offset = "0x5B7E1B0", VA = "0x185B7F7B0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public LMDIEKGDOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IHBHMFFKGII : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EEF0", Offset = "0x5B7D8F0", VA = "0x185B7EEF0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public IHBHMFFKGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LIKOPCFAFIE : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F690", Offset = "0x5B7E090", VA = "0x185B7F690", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public LIKOPCFAFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class JMMIKNEEIPL : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F0E0", Offset = "0x5B7DAE0", VA = "0x185B7F0E0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public JMMIKNEEIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class KGABJMANEGO : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F2B0", Offset = "0x5B7DCB0", VA = "0x185B7F2B0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public KGABJMANEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class BCGNHMABCHI : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D040", Offset = "0x5B7BA40", VA = "0x185B7D040", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public BCGNHMABCHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class AALJNDNFLPB : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random LOLMMGJELMA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7C610", Offset = "0x5B7B010", VA = "0x185B7C610", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public AALJNDNFLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GGCJNIMFEND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KECCLNDCEEL AJGHIJIKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BMHGMDONJJK ABIEHJLLPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> FIHLPDFJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> AOGGCOBJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OOBHJMNKLGL OLFNBJEKCCL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OOBHJMNKLGL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int POCAAILBFLC, out Guid MAKCINDBLOL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GIOCPGJEFFL
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly PJDLPOOEAGH[] LHCNCJNCFBL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5B7DDF0", Offset = "0x5B7C7F0", VA = "0x185B7DDF0")]
	public static void NBCANOHHLCP(DACGKLHBLIE JIHCLPECHIB, Dictionary<Guid, Guid> MDMPNGGCMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5B7DC00", Offset = "0x5B7C600", VA = "0x185B7DC00")]
	public static void JMENOLPBNBA(DACGKLHBLIE? JIHCLPECHIB, EPJFCKOCMKD DCMGLLFIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D8A0", Offset = "0x5B7C2A0", VA = "0x185B7D8A0")]
	public static void GJBEIFBPCIM(BKAAKHLCGBH OILMHDFMDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BKAAKHLCGBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KECCLNDCEEL IOHNHPEIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public DACGKLHBLIE AEABGDOMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> FIHLPDFJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> AOGGCOBJNLD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D160", Offset = "0x5B7BB60", VA = "0x185B7D160")]
	public Guid BNCKKFONACA(Guid GDIIAHJOKME)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class PNLDGLNPKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> KPPGNLAIKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> BKEPBPBBOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> OKAKKCAJMEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> OIJBHOAJDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> JNNPNKKENCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B84430", Offset = "0x5B82E30", VA = "0x185B84430")]
	public static PNLDGLNPKLK GHLJDBKFIGJ(CIFBNNGALCD MJGIEGEMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B843C0", Offset = "0x5B82DC0", VA = "0x185B843C0")]
	public static PNLDGLNPKLK FIPMALLMLND(LHHHAADIFPP MOENFIEOJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5B84270", Offset = "0x5B82C70", VA = "0x185B84270")]
	public static PNLDGLNPKLK BOFLCAFGHJI(IEnumerable<string> KPPGNLAIKLD, IDictionary<long, int> BMLLIGLFEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B854C0", Offset = "0x5B83EC0", VA = "0x185B854C0")]
	private PNLDGLNPKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B853A0", Offset = "0x5B83DA0", VA = "0x185B853A0")]
	private PNLDGLNPKLK(IEnumerable<string> KPPGNLAIKLD, IDictionary<long, int> BMLLIGLFEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5B851E0", Offset = "0x5B83BE0", VA = "0x185B851E0")]
	private void OCJCJIPKIJP(CIFBNNGALCD MJGIEGEMGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5B85020", Offset = "0x5B83A20", VA = "0x185B85020")]
	private void OCJCJIPKIJP(LHHHAADIFPP MOENFIEOJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B846E0", Offset = "0x5B830E0", VA = "0x185B846E0")]
	private void OCJCJIPKIJP(FAIAEMMAMKM COMPFMNMPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B84EB0", Offset = "0x5B838B0", VA = "0x185B84EB0")]
	private void OCJCJIPKIJP(MGKJIBKNGDG ELOCLFMIMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5B84B00", Offset = "0x5B83500", VA = "0x185B84B00")]
	private void OCJCJIPKIJP(DACGKLHBLIE AEABGDOMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B84670", Offset = "0x5B83070", VA = "0x185B84670")]
	private void JGFDHCOHMCI(string BAMPFOAHBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B844A0", Offset = "0x5B82EA0", VA = "0x185B844A0")]
	private void HFGDHHFCHAL(MAJNHPOMHMG PGNJOMFAMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5B84580", Offset = "0x5B82F80", VA = "0x185B84580")]
	private void HFGDHHFCHAL(KOCKOCNLNMO PGNJOMFAMCP)
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
