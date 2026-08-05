using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71D6A80", Offset = "0x71D5E80", VA = "0x1871D6A80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715D90", Offset = "0x715190")]
public class BNIBBODDFJG<TData> : KEEINLEHJCM<OICCOPMCFAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GONKJKNKAKK DGEDOBPIKCN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x206C750", Offset = "0x206BB50", VA = "0x18206C750")]
	public BNIBBODDFJG(Vector3 DLPGMMFCIIM, bool KPKKKPHDIKK, OICCOPMCFAE<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x206C6E0", Offset = "0x206BAE0", VA = "0x18206C6E0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715E00", Offset = "0x715200")]
public class OLEIOKJCIHO<TSpawnType, TSpawnInfo> : JPIPPHODFKM<DNFFFDNLJBP<TSpawnType, TSpawnInfo>, TSpawnType> where TSpawnType : notnull where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715E70", Offset = "0x715270")]
	private readonly EOLCENBCODJ<TSpawnInfo> AIEGNLJMEEC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F330", Offset = "0x2F8E730", VA = "0x182F8F330")]
	public OLEIOKJCIHO(TSpawnInfo LDPNLAFOMIA, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, float ECOCGLBAPIP, DNFFFDNLJBP<TSpawnType, TSpawnInfo> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F000", Offset = "0x2F8E400", VA = "0x182F8F000", Slot = "4")]
	public override Task<TSpawnType> NBOCHEIPFNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KONLPDCNKHN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public IEnumerable<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2E65E70", Offset = "0x2E65270", VA = "0x182E65E70")]
	public KONLPDCNKHN(IEnumerable<TData> NBEBPKPJHPA, bool BCHGIBDPMEA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KLBOIFHFKIH<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715F10", Offset = "0x715310")] in CLGEJHHCPAD<TData?> MAGOFJGEFFH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIKECNPHHNB(in PJCCMLGGJME NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MIKECNPHHNB(in HCBJEFJLPEL NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MIKECNPHHNB(in BAMIKHJMDMI NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FOHCIJCFHFI<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public TNode DKKBIDEAPIK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3612A80", Offset = "0x3611E80", VA = "0x183612A80")]
	public FOHCIJCFHFI(TNode DKKBIDEAPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CIBJGOGEGFM<TNode> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public TNode MACOBDKAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public EHKLJPEOGMC NOFIJEPPECF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3493BE0", Offset = "0x3492FE0", VA = "0x183493BE0")]
	public CIBJGOGEGFM(TNode MACOBDKAKGB, EHKLJPEOGMC NOFIJEPPECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715F80", Offset = "0x715380")]
public class DFOAJHPMCJN<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x715FF0", Offset = "0x7153F0")]
	private readonly KONLPDCNKHN<TData> LDCLNKHMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32C62B0", Offset = "0x32C56B0", VA = "0x1832C62B0")]
	public DFOAJHPMCJN(List<TData> LEJDAGMDLDH, OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NLEIMGGLKNJ<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716050", Offset = "0x715450")] in CPJPLFLOJII<TData?> LNCNKBEBCFP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7160C0", Offset = "0x7154C0")] in NLHJAPHGPCA<TData?> LNCNKBEBCFP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AKFLHMMLBHC<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IEnumerable<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public PFDECMCNJAL ELOLHJCDFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OMFCOLBDGKP OIOBCPEPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public float MLEBAKNKHOP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x30C5910", Offset = "0x30C4D10", VA = "0x1830C5910")]
	public AKFLHMMLBHC(IEnumerable<TData> NFLEONCKOFE, PFDECMCNJAL DEJOCIOKOBF, OMFCOLBDGKP NKAMKIHOODJ, float MLEBAKNKHOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class HEDIHLIPBHI
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71D6820", Offset = "0x71D5C20", VA = "0x1871D6820")]
	public static void AGJJBFPAHIE(IEnumerable CPHLKLANPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2439020", Offset = "0x2438420", VA = "0x182439020")]
	public static void AGJJBFPAHIE<T>(T[] EACKPMFPNLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x24391D0", Offset = "0x24385D0", VA = "0x1824391D0")]
	public static void AGJJBFPAHIE<T>(T HIMOPIMKOMB) where T : notnull, Enum
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JAMJLKLDKEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716130", Offset = "0x715530")] in DKHGIKFMDMG<T?> JEFPPNMIBHP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GGJCAAKEOBF<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public TData[] IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public PFDECMCNJAL[] ELOLHJCDFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public OMFCOLBDGKP[] OIOBCPEPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float[] MLEBAKNKHOP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x354BE00", Offset = "0x354B200", VA = "0x18354BE00")]
	public GGJCAAKEOBF(TData[] NFLEONCKOFE, PFDECMCNJAL[] DEJOCIOKOBF, OMFCOLBDGKP[] NKAMKIHOODJ, float[] MLEBAKNKHOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GIIJFMOHIJC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FIGFNACENCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool EBPHMPFBGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CODAHCGOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DMOCGLOMOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DFMKBKGJBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Guid COKEBJKNNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int BNOAGGNAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly Vector3 FGLOAKJBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly Quaternion OCEJJKMFIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float BJDNODMMNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly bool KPKKKPHDIKK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71D6360", Offset = "0x71D5760", VA = "0x1871D6360")]
	public DFMKBKGJBDC(Guid COKEBJKNNMP, int BNOAGGNAMKG, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, float BJDNODMMNIO, bool KPKKKPHDIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OBDOGIKDACP<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7161E0", Offset = "0x7155E0")] in EDKONJHEFEJ<TData?> MAGOFJGEFFH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIKECNPHHNB(in ABFIJGNKDEF NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IMBBONDKEDK
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	XYZ,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	X_only,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Y_only,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Z_only
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PJCCMLGGJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly float GOMMNCPNCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Vector3 JDLNDKFHHOB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x50F9140", Offset = "0x50F8540", VA = "0x1850F9140")]
	public PJCCMLGGJME(float GOMMNCPNCIM, Vector3 JDLNDKFHHOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BAMIKHJMDMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly Vector3 LNOEIDKOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly float GOMMNCPNCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly Vector3 JDLNDKFHHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool KPKKKPHDIKK;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71D60F0", Offset = "0x71D54F0", VA = "0x1871D60F0")]
	public BAMIKHJMDMI(Vector3 LNOEIDKOGAM, float GOMMNCPNCIM, Vector3 JDLNDKFHHOB, bool KPKKKPHDIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716250", Offset = "0x715650")]
public class EBLBNKOOLBA<TData> : KEEINLEHJCM<NGACKPCHHOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7162C0", Offset = "0x7156C0")]
	private readonly KOKHHJKMOBD<TData> JKDAGNCIDEG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3520720", Offset = "0x351FB20", VA = "0x183520720")]
	public EBLBNKOOLBA(IEnumerable<TData> NFLEONCKOFE, Vector3 NINOAHBEKGM, IMBBONDKEDK ELEJFHJEFHL, bool EDCBLKGBANG, NGACKPCHHOO<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15D7E80", Offset = "0x15D7280", VA = "0x1815D7E80", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FPGPCCACKPD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CGPEKPNMKEK> NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716320", Offset = "0x715720")] GPBIAFAKGPJ<TData> KOLOPONJMKI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716380", Offset = "0x715780")]
public class DADHDGHPGKD<TData> : KEEINLEHJCM<PABPJOFINHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly ENJKEFAJEAC JKDAGNCIDEG;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x257FDA0", Offset = "0x257F1A0", VA = "0x18257FDA0")]
	public DADHDGHPGKD(Vector3 EANOMANCPLC, PABPJOFINHN<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x206C6E0", Offset = "0x206BAE0", VA = "0x18206C6E0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7163F0", Offset = "0x7157F0")]
public class OBFLKMDDIJM<TData> : KEEINLEHJCM<KLBOIFHFKIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HCBJEFJLPEL JGPONLPOCFL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x23CDC30", Offset = "0x23CD030", VA = "0x1823CDC30")]
	public OBFLKMDDIJM(float BANFJCNNKDE, bool AIEKOOIANCK, Vector3 JDLNDKFHHOB, KLBOIFHFKIH<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23CDB70", Offset = "0x23CCF70", VA = "0x1823CDB70", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IOPKCNHDHCA<TData> where TData : CNKCEPOCDPO
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716460", Offset = "0x715860")] in IIJGMKIFCEP<TData> MHIOPODCAKD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7164D0", Offset = "0x7158D0")] in BGACODBFAGI<TData> MHIOPODCAKD);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MAJCBKCJEFK
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum FGMOIJIFCEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		ICreationContextObject,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Guid
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2161AF0", Offset = "0x2160EF0", VA = "0x182161AF0")]
	public static void PAACJIFMFEK<T>(T IILNPDLGJIK, FGMOIJIFCEF GANFKPHKNKH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2161C70", Offset = "0x2161070", VA = "0x182161C70")]
	public static void PAACJIFMFEK<T>(T IILNPDLGJIK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x21619D0", Offset = "0x2160DD0", VA = "0x1821619D0")]
	public static void DAIKOKOLBGE<T>(T IILNPDLGJIK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2161D00", Offset = "0x2161100", VA = "0x182161D00")]
	public static T PHGLOPEHIMO<T>(FGMOIJIFCEF GANFKPHKNKH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2161DC0", Offset = "0x21611C0", VA = "0x182161DC0")]
	public static T PHGLOPEHIMO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2161A80", Offset = "0x2160E80", VA = "0x182161A80")]
	public static bool KNODPCFCFFM<T>() where T : class
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716540", Offset = "0x715940")]
public class IHABDKKGFID<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public IHABDKKGFID(OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29E3120", Offset = "0x29E2520", VA = "0x1829E3120", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BEOJAPPCFEM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool Raycast(Vector3 CNCAEFCOEJK, Vector3 GCNKNLGIDOA, float AKODDLNKMDE, out T BGENICJHCFA, out Vector3 PLBAHBNHPCF, out Collider LHMAAFCDIKD);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int SpherecastPick(Vector3 CNCAEFCOEJK, Vector3 GCNKNLGIDOA, float IJDLCPGBBHG, float AKODDLNKMDE, T[] AIBNHOFHOGH, out Vector3 KAFOEEHACGO, out Collider BAEIPKIHCBI);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int SpherePick(Vector3 CNCAEFCOEJK, float IJDLCPGBBHG, Vector3 GFLHOCPOJPF, T[] AIBNHOFHOGH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class LBMCNHBKAGL<TReceiver, TFromExecute> where TReceiver : notnull where TFromExecute : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	protected TReceiver OAHEFOMGOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x232F630", Offset = "0x232EA30", VA = "0x18232F630")]
	public LBMCNHBKAGL(TReceiver OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TFromExecute NBOCHEIPFNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OJGHGNDIPGE
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CGPEKPNMKEK> NBOCHEIPFNJ(MIMBOJBJJHF HHBJCIJKPNE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7165B0", Offset = "0x7159B0")]
public class IOMGAFNHDBI<TData> : KEEINLEHJCM<GFFDEPPJCPC<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716620", Offset = "0x715A20")]
	private readonly HEPBPPJIGOH<TData> OHDCBKBBAMA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2868540", Offset = "0x2867940", VA = "0x182868540")]
	public IOMGAFNHDBI(IEnumerable<TData> NFLEONCKOFE, PFDECMCNJAL DEJOCIOKOBF, OMFCOLBDGKP NKAMKIHOODJ, float MLEBAKNKHOP, bool EDCBLKGBANG, GFFDEPPJCPC<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716680", Offset = "0x715A80")]
public class DKEMNHKONCB<TData> : KEEINLEHJCM<OICCOPMCFAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public DKEMNHKONCB(OICCOPMCFAE<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x21E88D0", Offset = "0x21E7CD0", VA = "0x1821E88D0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7166F0", Offset = "0x715AF0")]
public class ICCGPDNFLOD<TData> : KEEINLEHJCM<NGACKPCHHOO<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716760", Offset = "0x715B60")]
	private readonly HNPFFLBCIGN<TData> JKDAGNCIDEG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x15CE6B0", Offset = "0x15CDAB0", VA = "0x1815CE6B0")]
	public ICCGPDNFLOD(IEnumerable<TData> NFLEONCKOFE, Vector3 EANOMANCPLC, bool EDCBLKGBANG, NGACKPCHHOO<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HNPFFLBCIGN<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly Vector3 EANOMANCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D23880", Offset = "0x2D22C80", VA = "0x182D23880")]
	public HNPFFLBCIGN(IEnumerable<TData> NFLEONCKOFE, Vector3 EANOMANCPLC, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NGACKPCHHOO<TData>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7167C0", Offset = "0x715BC0")] in HNPFFLBCIGN<TData?> JKDAGNCIDEG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716830", Offset = "0x715C30")] in KOKHHJKMOBD<TData?> JKDAGNCIDEG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7168A0", Offset = "0x715CA0")]
public class OLFIOMLBKLM<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2F90220", Offset = "0x2F8F620", VA = "0x182F90220")]
	public OLFIOMLBKLM(bool EDCBLKGBANG, OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2F901B0", Offset = "0x2F8F5B0", VA = "0x182F901B0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HIDCHEJHGCC<TNode>
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716910", Offset = "0x715D10")] in FOHCIJCFHFI<TNode?> MAGOFJGEFFH);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOPKHHJMIL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716980", Offset = "0x715D80")] in CIBJGOGEGFM<TNode?> OBNMJLHHPGA);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOAEBGGGMGC();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7169F0", Offset = "0x715DF0")]
public class LMGKDBCCDHI<TNode> : KEEINLEHJCM<HIDCHEJHGCC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public LMGKDBCCDHI(HIDCHEJHGCC<TNode> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A24A40", Offset = "0x2A23E40", VA = "0x182A24A40", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OPNHGDFGOKE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716A60", Offset = "0x715E60")] in GGJCAAKEOBF<TData?> OHDCBKBBAMA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GFKBGHJEGJK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private struct LDLJHJADFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool OHENPCHNGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IFJJAPHPIAE KAOCOIFFGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IFJJAPHPIAE OCBBKHEMAIK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static LDLJHJADFJE JKMGIIFALCL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CancellationToken LAEPJJABMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71D65B0", Offset = "0x71D59B0", VA = "0x1871D65B0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal static IFJJAPHPIAE KAOCOIFFGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71D64D0", Offset = "0x71D58D0", VA = "0x1871D64D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71D6450", Offset = "0x71D5850", VA = "0x1871D6450")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x71D63A0", Offset = "0x71D57A0", VA = "0x1871D63A0")]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Room, CDFBKAGHDGH.None)]
	private static void BAPPIPJDFJJ(IFJJAPHPIAE CFNOCNNICEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71D6610", Offset = "0x71D5A10", VA = "0x1871D6610")]
	public static void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x71D6750", Offset = "0x71D5B50", VA = "0x1871D6750")]
	private static IFJJAPHPIAE IKLJBOFADML(IFJJAPHPIAE CJOBAFBBGDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GOAHBLHJGLE<TData> : BOFBCACLLPA, JFFHEGECINC<TData>, OAAOPAKPFLI<TData>, HLBGLCDILLK<TData>, GIIJFMOHIJC, BEOJAPPCFEM<TData>, HOGBPNPBJFN, ADJIADPKHGO
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CPJPLFLOJII<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly Quaternion EANOMANCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly Vector3? JDLNDKFHHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly bool JHALFPBMADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8490", Offset = "0x2AE7890", VA = "0x182AE8490")]
	public CPJPLFLOJII(IEnumerable<TData> NFLEONCKOFE, Quaternion EANOMANCPLC, Vector3? JDLNDKFHHOB, bool JHALFPBMADP, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716AF0", Offset = "0x715EF0")]
public class GCKPFMOKLBO<T> : KEEINLEHJCM<JAMJLKLDKEC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716B60", Offset = "0x715F60")]
	private readonly DKHGIKFMDMG<T> JEFPPNMIBHP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x35439D0", Offset = "0x3542DD0", VA = "0x1835439D0")]
	public GCKPFMOKLBO(T JNHEGOFDJBP, bool CJLJIBEBJFK, JAMJLKLDKEC<T> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct HEPBPPJIGOH<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public IEnumerable<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public PFDECMCNJAL ELOLHJCDFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public OMFCOLBDGKP OIOBCPEPEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float MLEBAKNKHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2078660", Offset = "0x2077A60", VA = "0x182078660")]
	public HEPBPPJIGOH(IEnumerable<TData> NFLEONCKOFE, PFDECMCNJAL DEJOCIOKOBF, OMFCOLBDGKP NKAMKIHOODJ, float MLEBAKNKHOP, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716BC0", Offset = "0x715FC0")]
public class EKLBPBINOAA<TData> : KEEINLEHJCM<KLBOIFHFKIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BAMIKHJMDMI JGPONLPOCFL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A070", Offset = "0x2B89470", VA = "0x182B8A070")]
	public EKLBPBINOAA(Vector3 LNOEIDKOGAM, float GOMMNCPNCIM, Vector3 JDLNDKFHHOB, bool ONBEFHCFIBL, KLBOIFHFKIH<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A000", Offset = "0x2B89400", VA = "0x182B8A000", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct COBFJEPPAJO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T JNHEGOFDJBP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x21E5D80", Offset = "0x21E5180", VA = "0x1821E5D80")]
	public COBFJEPPAJO(T BGIINGGPMFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HCBJEFJLPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly float BANFJCNNKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly bool AIEKOOIANCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly Vector3 JDLNDKFHHOB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71D6800", Offset = "0x71D5C00", VA = "0x1871D6800")]
	public HCBJEFJLPEL(float BANFJCNNKDE, bool AIEKOOIANCK, Vector3 JDLNDKFHHOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716C30", Offset = "0x716030")]
public class ENICNKOOKFO<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716CA0", Offset = "0x7160A0")]
	private readonly KONLPDCNKHN<TData> LDCLNKHMNPM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x137F890", Offset = "0x137EC90", VA = "0x18137F890")]
	public ENICNKOOKFO(List<TData> LEJDAGMDLDH, OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x137F740", Offset = "0x137EB40", VA = "0x18137F740", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct KPFOAPNMNOP<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly IEnumerable<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool HFNNBJNEHHP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E69650", Offset = "0x2E68A50", VA = "0x182E69650")]
	public KPFOAPNMNOP(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ADJIADPKHGO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MLPFDGHACOI ICCCAJHIFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716D40", Offset = "0x716140")]
public class HMBGGEMNCJJ<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716DB0", Offset = "0x7161B0")]
	private readonly KONLPDCNKHN<TData> LDCLNKHMNPM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x31E2150", Offset = "0x31E1550", VA = "0x1831E2150")]
	public HMBGGEMNCJJ(List<TData> LEJDAGMDLDH, bool EDCBLKGBANG, OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x15CB370", Offset = "0x15CA770", VA = "0x1815CB370", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct MIMBOJBJJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HFNNBJNEHHP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xCA7800", Offset = "0xCA6C00", VA = "0x180CA7800")]
	public MIMBOJBJJHF(bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JFFHEGECINC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RenderHoverHighlight(T HFAGBIOODHL, [Optional] KKFFAKHFGOF? EFDJMBALOBC, bool OCJLHGCNPMK = true);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderHoverHighlight(int FJFMKNIHPDJ, IEnumerable<T> CFPDJEELDFA, bool OCJLHGCNPMK = true);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderHoverHighlight(int FJFMKNIHPDJ, IEnumerable<T> CFPDJEELDFA, KKFFAKHFGOF EFDJMBALOBC, bool OCJLHGCNPMK = true);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NLHJAPHGPCA<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly Quaternion ADFAIMNCMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IMBBONDKEDK JHFJDJOKIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly Vector3? JDLNDKFHHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool JHALFPBMADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2797830", Offset = "0x2796C30", VA = "0x182797830")]
	public NLHJAPHGPCA(IEnumerable<TData> NFLEONCKOFE, Quaternion ADFAIMNCMDC, IMBBONDKEDK JHFJDJOKIFA, Vector3? JDLNDKFHHOB, bool JHALFPBMADP, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct CLGEJHHCPAD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3837940", Offset = "0x3836D40", VA = "0x183837940")]
	public CLGEJHHCPAD(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716E10", Offset = "0x716210")]
public class CBAMCLIHAOE<TData> : JPIPPHODFKM<KCODMMCOPKD<TData>, CGPEKPNMKEK> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716E80", Offset = "0x716280")]
	private readonly KPFOAPNMNOP<TData> KMCINABPKIK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3142CA0", Offset = "0x31420A0", VA = "0x183142CA0")]
	public CBAMCLIHAOE(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG, KCODMMCOPKD<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3142AE0", Offset = "0x3141EE0", VA = "0x183142AE0", Slot = "4")]
	public override Task<CGPEKPNMKEK> NBOCHEIPFNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716EE0", Offset = "0x7162E0")]
public class IGLNIABIFGL<TData> : KEEINLEHJCM<OICCOPMCFAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716F50", Offset = "0x716350")]
	private readonly JGFAIFJJOLB<TData> DGEDOBPIKCN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29DFDC0", Offset = "0x29DF1C0", VA = "0x1829DFDC0")]
	public IGLNIABIFGL(TData JNHEGOFDJBP, bool EDCBLKGBANG, OICCOPMCFAE<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JGFAIFJJOLB<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly TData JNHEGOFDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA29D0", Offset = "0x2BA1DD0", VA = "0x182BA29D0")]
	public JGFAIFJJOLB(TData JNHEGOFDJBP, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CENCHDOFLLO<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x309D950", Offset = "0x309CD50", VA = "0x18309D950")]
	public CENCHDOFLLO(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716FB0", Offset = "0x7163B0")]
public class DBBBCBCMAHI<T> : KEEINLEHJCM<MDLINKMKCNO<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public DBBBCBCMAHI(MDLINKMKCNO<T> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D32240", Offset = "0x1D31640", VA = "0x181D32240", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717020", Offset = "0x716420")]
public class LABFFFNFFFN<TData> : KEEINLEHJCM<KLBOIFHFKIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PJCCMLGGJME JGPONLPOCFL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x232E580", Offset = "0x232D980", VA = "0x18232E580")]
	public LABFFFNFFFN(float GOMMNCPNCIM, Vector3 JDLNDKFHHOB, KLBOIFHFKIH<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x206C6E0", Offset = "0x206BAE0", VA = "0x18206C6E0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717090", Offset = "0x716490")]
public class AGGOIAHCCFA<TData> : KEEINLEHJCM<OBDOGIKDACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public AGGOIAHCCFA(OBDOGIKDACP<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A24A40", Offset = "0x2A23E40", VA = "0x182A24A40", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717100", Offset = "0x716500")]
public class DMPJBFLFMKF<TData> : KEEINLEHJCM<OBDOGIKDACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717170", Offset = "0x716570")]
	private readonly EDKONJHEFEJ<TData> LNCNKBEBCFP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E6F0", Offset = "0x2E6DAF0", VA = "0x182E6E6F0")]
	public DMPJBFLFMKF(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG, OBDOGIKDACP<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7171D0", Offset = "0x7165D0")]
public class BOGGBBKGJLM<TNode> : KEEINLEHJCM<HIDCHEJHGCC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717240", Offset = "0x716640")]
	private readonly FOHCIJCFHFI<TNode> MAGOFJGEFFH;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x34D2E40", Offset = "0x34D2240", VA = "0x1834D2E40")]
	public BOGGBBKGJLM(TNode OGJGEIPEFPF, HIDCHEJHGCC<TNode> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7172A0", Offset = "0x7166A0")]
public class KHHFODPICHC<TData> : KEEINLEHJCM<PABPJOFINHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717310", Offset = "0x716710")]
	private readonly CENCHDOFLLO<TData> JKDAGNCIDEG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B81E40", Offset = "0x3B81240", VA = "0x183B81E40")]
	public KHHFODPICHC(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG, PABPJOFINHN<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EDKONJHEFEJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3A16590", Offset = "0x3A15990", VA = "0x183A16590")]
	public EDKONJHEFEJ(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717370", Offset = "0x716770")]
public class BDKHPHPPIBP<TNode> : KEEINLEHJCM<HIDCHEJHGCC<TNode>> where TNode : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7173E0", Offset = "0x7167E0")]
	private readonly CIBJGOGEGFM<TNode> OBNMJLHHPGA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x33DC9D0", Offset = "0x33DBDD0", VA = "0x1833DC9D0")]
	public BDKHPHPPIBP(TNode MACOBDKAKGB, EHKLJPEOGMC NOFIJEPPECF, HIDCHEJHGCC<TNode> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x15D7E80", Offset = "0x15D7280", VA = "0x1815D7E80", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface KCODMMCOPKD<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CGPEKPNMKEK> JPNBBEHIBMB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717440", Offset = "0x716840")] in KPFOAPNMNOP<TData> LDCLNKHMNPM, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7174B0", Offset = "0x7168B0")]
public class OPHABMFBHDD : JPIPPHODFKM<OJGHGNDIPGE, CGPEKPNMKEK>
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class BPCBAHEOICB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<CGPEKPNMKEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public OPHABMFBHDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private CGPEKPNMKEK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<CGPEKPNMKEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BPCBAHEOICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x71D6120", Offset = "0x71D5520", VA = "0x1871D6120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MIMBOJBJJHF COLKPELILKK;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71D6C60", Offset = "0x71D6060", VA = "0x1871D6C60")]
	public OPHABMFBHDD(bool EDCBLKGBANG, OJGHGNDIPGE OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71D6B10", Offset = "0x71D5F10", VA = "0x1871D6B10", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BPCBAHEOICB))]
	public override Task<CGPEKPNMKEK> NBOCHEIPFNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface OAAOPAKPFLI<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFOOJKIGKED([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717590", Offset = "0x716990")] in KONLPDCNKHN<TData> LDCLNKHMNPM);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHAHFPLFHIG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717600", Offset = "0x716A00")] in KONLPDCNKHN<TData> LDCLNKHMNPM);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLMFAHIGONP(in bool HLGGFCMHDHE);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BOJMJOABNDH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717670", Offset = "0x716A70")] in KONLPDCNKHN<TData> LDCLNKHMNPM);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GMGKGAMOKCF();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AIPOKAAPHNC(in TData ACAEHAFCBHO);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct ABFIJGNKDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Quaternion EANOMANCPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly Vector3? JDLNDKFHHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool JHALFPBMADP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x59D0850", Offset = "0x59CFC50", VA = "0x1859D0850")]
	public ABFIJGNKDEF(Quaternion EANOMANCPLC, Vector3? JDLNDKFHHOB, bool JHALFPBMADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface OICCOPMCFAE<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7176E0", Offset = "0x716AE0")] in JGFAIFJJOLB<TData?> MAGOFJGEFFH);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIKECNPHHNB(in GONKJKNKAKK NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MIKECNPHHNB(in DFMKBKGJBDC NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ENJKEFAJEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly Vector3 EANOMANCPLC;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public ENJKEFAJEAC(Vector3 EANOMANCPLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717750", Offset = "0x716B50")]
public class ALGLEJHPGJE<T> : KEEINLEHJCM<MDLINKMKCNO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7177C0", Offset = "0x716BC0")]
	private readonly COBFJEPPAJO<T> OJAALCHHLPK;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x30C5E10", Offset = "0x30C5210", VA = "0x1830C5E10")]
	public ALGLEJHPGJE(T JNHEGOFDJBP, MDLINKMKCNO<T> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717820", Offset = "0x716C20")]
public class DIKHLOIJHCB<TData> : KEEINLEHJCM<NLEIMGGLKNJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717890", Offset = "0x716C90")]
	private readonly CPJPLFLOJII<TData> LNCNKBEBCFP;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21E3B00", Offset = "0x21E2F00", VA = "0x1821E3B00")]
	public DIKHLOIJHCB(IEnumerable<TData> NFLEONCKOFE, Quaternion EANOMANCPLC, Vector3? JDLNDKFHHOB, bool JHALFPBMADP, bool EDCBLKGBANG, NLEIMGGLKNJ<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7178F0", Offset = "0x716CF0")]
public class BMFGDPEEOKA<TData> : KEEINLEHJCM<KLBOIFHFKIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public BMFGDPEEOKA(KLBOIFHFKIH<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x206C0C0", Offset = "0x206B4C0", VA = "0x18206C0C0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717960", Offset = "0x716D60")]
public class KLDADMGIABN<TData> : KEEINLEHJCM<OBDOGIKDACP<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly ABFIJGNKDEF LNCNKBEBCFP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x373BB50", Offset = "0x373AF50", VA = "0x18373BB50")]
	public KLDADMGIABN(Quaternion EANOMANCPLC, Vector3? JDLNDKFHHOB, bool JHALFPBMADP, OBDOGIKDACP<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x206C6E0", Offset = "0x206BAE0", VA = "0x18206C6E0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7179D0", Offset = "0x716DD0")]
public class PLMOGIIIPCI<TData> : KEEINLEHJCM<OPNHGDFGOKE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717A40", Offset = "0x716E40")]
	private readonly GGJCAAKEOBF<TData> OHDCBKBBAMA;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A520", Offset = "0x3D09920", VA = "0x183D0A520")]
	public PLMOGIIIPCI(TData[] NFLEONCKOFE, PFDECMCNJAL[] DEJOCIOKOBF, OMFCOLBDGKP[] NKAMKIHOODJ, float[] MLEBAKNKHOP, OPNHGDFGOKE<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35F74B0", Offset = "0x35F68B0", VA = "0x1835F74B0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717AA0", Offset = "0x716EA0")]
public class IBBAJLFDIOK<TData> : KEEINLEHJCM<IOPKCNHDHCA<TData>> where TData : notnull, CNKCEPOCDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717B10", Offset = "0x716F10")]
	private readonly BGACODBFAGI<TData> MHIOPODCAKD;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x15CB430", Offset = "0x15CA830", VA = "0x1815CB430")]
	public IBBAJLFDIOK(List<TData> NFLEONCKOFE, List<bool> ABDDGCEAIDI, IOPKCNHDHCA<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x15CB370", Offset = "0x15CA770", VA = "0x1815CB370", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717B70", Offset = "0x716F70")]
public class CBELCBMCOHD<TData> : KEEINLEHJCM<PABPJOFINHN<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public CBELCBMCOHD(PABPJOFINHN<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2A24A40", Offset = "0x2A23E40", VA = "0x182A24A40", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct GONKJKNKAKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly Vector3 DLPGMMFCIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly bool KPKKKPHDIKK;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x71D67E0", Offset = "0x71D5BE0", VA = "0x1871D67E0")]
	public GONKJKNKAKK(Vector3 DLPGMMFCIIM, bool KPKKKPHDIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct DKHGIKFMDMG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly T JNHEGOFDJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly bool AIDONOKDMGB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21E9110", Offset = "0x21E8510", VA = "0x1821E9110")]
	public DKHGIKFMDMG(T BGIINGGPMFE, bool CJLJIBEBJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MBODKENOMLI<TData>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MIKECNPHHNB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717BE0", Offset = "0x716FE0")] in AKFLHMMLBHC<TData?> OHDCBKBBAMA);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717C50", Offset = "0x717050")]
public class FIGOCALGMOB<TData> : KEEINLEHJCM<MBODKENOMLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717CC0", Offset = "0x7170C0")]
	private readonly AKFLHMMLBHC<TData> OHDCBKBBAMA;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35F7570", Offset = "0x35F6970", VA = "0x1835F7570")]
	public FIGOCALGMOB(IEnumerable<TData> NFLEONCKOFE, PFDECMCNJAL DEJOCIOKOBF, OMFCOLBDGKP NKAMKIHOODJ, float MLEBAKNKHOP, MBODKENOMLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35F74B0", Offset = "0x35F68B0", VA = "0x1835F74B0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DNFFFDNLJBP<TSpawnType, TSpawnInfo>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<TSpawnType> MKLLCCBOOOP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717D20", Offset = "0x717120")] in EOLCENBCODJ<TSpawnInfo> IHOJKPCPPDI, CancellationToken ODBDCIFDKPJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct EOLCENBCODJ<TSpawnInfo> where TSpawnInfo : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public TSpawnInfo PDIBJGOANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 FGLOAKJBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion OCEJJKMFIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float ECOCGLBAPIP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1397450", Offset = "0x1396850", VA = "0x181397450")]
	public EOLCENBCODJ(TSpawnInfo PDIBJGOANBL, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, float ECOCGLBAPIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface CNKCEPOCDPO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PGFJHDLOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717D90", Offset = "0x717190")]
public class ICBHMCAENPG<TData> : KEEINLEHJCM<OICCOPMCFAE<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly DFMKBKGJBDC DGEDOBPIKCN;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x15CD8A0", Offset = "0x15CCCA0", VA = "0x1815CD8A0")]
	public ICBHMCAENPG(Guid COKEBJKNNMP, int BNOAGGNAMKG, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, float BJDNODMMNIO, bool KPKKKPHDIKK, OICCOPMCFAE<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x15CD830", Offset = "0x15CCC30", VA = "0x1815CD830", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct GPBIAFAKGPJ<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public TData LGILFMFEGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IReadOnlyList<TData> FFGHKKAHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool HFNNBJNEHHP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C73EA0", Offset = "0x2C732A0", VA = "0x182C73EA0")]
	public GPBIAFAKGPJ(TData CHDODPBLMMO, IReadOnlyList<TData> CAMEAMDDLFB, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface JDKFPHCLDKO<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ClearHoverTarget(LKHONEOLGEM JHPPJICBIPB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool SetHoverTarget(TData JNHEGOFDJBP, Collider LHMAAFCDIKD, LKHONEOLGEM JHPPJICBIPB, [Optional] KKFFAKHFGOF? HIHCLKHGKEE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool TryGetHoverTarget(out TData JNHEGOFDJBP);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717E00", Offset = "0x717200")]
public class CKGPBLDPGMD<TData> : KEEINLEHJCM<IOPKCNHDHCA<TData>> where TData : notnull, CNKCEPOCDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717E70", Offset = "0x717270")]
	private readonly IIJGMKIFCEP<TData> MHIOPODCAKD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38356A0", Offset = "0x3834AA0", VA = "0x1838356A0")]
	public CKGPBLDPGMD(List<TData> NFLEONCKOFE, bool ODBNCDJILAD, IOPKCNHDHCA<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717ED0", Offset = "0x7172D0")]
public class NHNJADMAJGI<TData> : KEEINLEHJCM<OAAOPAKPFLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly TData ACAEHAFCBHO;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2790BE0", Offset = "0x278FFE0", VA = "0x182790BE0")]
	public NHNJADMAJGI(TData ACAEHAFCBHO, OAAOPAKPFLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2790B20", Offset = "0x278FF20", VA = "0x182790B20", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct KOKHHJKMOBD<TData> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly IEnumerable<TData> NFLEONCKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly Vector3 NINOAHBEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly IMBBONDKEDK ELEJFHJEFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly bool EDCBLKGBANG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2E656D0", Offset = "0x2E64AD0", VA = "0x182E656D0")]
	public KOKHHJKMOBD(IEnumerable<TData> NFLEONCKOFE, Vector3 NINOAHBEKGM, IMBBONDKEDK ELEJFHJEFHL, bool EDCBLKGBANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717F40", Offset = "0x717340")]
public class HNECGLNGEOJ<TData> : JPIPPHODFKM<FPGPCCACKPD<TData>, CGPEKPNMKEK> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class HNAJDKOFLOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<CGPEKPNMKEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public HNECGLNGEOJ<TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private CGPEKPNMKEK <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<CGPEKPNMKEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HNAJDKOFLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x31E3630", Offset = "0x31E2A30", VA = "0x1831E3630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x717FB0", Offset = "0x7173B0")]
	private readonly GPBIAFAKGPJ<TData> ADHHLECLCIG;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x31E46A0", Offset = "0x31E3AA0", VA = "0x1831E46A0")]
	public HNECGLNGEOJ(TData CHDODPBLMMO, IReadOnlyList<TData> CAMEAMDDLFB, bool EDCBLKGBANG, FPGPCCACKPD<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x31E4530", Offset = "0x31E3930", VA = "0x1831E4530", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HNECGLNGEOJ<>.HNAJDKOFLOD))]
	public override Task<CGPEKPNMKEK> NBOCHEIPFNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718080", Offset = "0x717480")]
public abstract class KEEINLEHJCM<TReceiver> : LBMCNHBKAGL<TReceiver, bool> where TReceiver : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public KEEINLEHJCM(TReceiver OAHEFOMGOLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface BOFBCACLLPA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Bounds LBGFMJBKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform CCBNKPMOBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Bounds DNBHGHMMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform AFCEMGBBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Vector3 GIDLGMOPBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetSelectionBoundsDirty(bool DBANMLIIOKF = true, int IMLFOHPEIAO = 0);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ShouldHideSelectionBoundsPreview(bool DPBEPPJKLOC, object AEMEEHLIDCM);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct IIJGMKIFCEP<TData> where TData : notnull, CNKCEPOCDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public IEnumerable<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool ODBNCDJILAD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x29E8C20", Offset = "0x29E8020", VA = "0x1829E8C20")]
	public IIJGMKIFCEP(IEnumerable<TData> NBEBPKPJHPA, bool EMGGADEONAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct BGACODBFAGI<TData> where TData : notnull, CNKCEPOCDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public List<TData> IKMOAPFBNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public List<bool> ABDDGCEAIDI;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x205C270", Offset = "0x205B670", VA = "0x18205C270")]
	public BGACODBFAGI(List<TData> NBEBPKPJHPA, List<bool> NFFMEAHOLOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface HLBGLCDILLK<TData> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GAGLDKHJHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int BJBCPKGLIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	IEnumerable<TData> HIDGFDFNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IsSelected(TData CFHFBNLLHPN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IsSelectable(TData CFHFBNLLHPN);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface HOGBPNPBJFN
{
	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnSelectionPickedUp();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelectionReleased();
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface PABPJOFINHN<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7180F0", Offset = "0x7174F0")] in CENCHDOFLLO<TData?> JHAHBKJMENO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MIKECNPHHNB(in ENJKEFAJEAC NFEHJCBGDKK);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718160", Offset = "0x717560")]
public class NGMILKCGIMB<TData> : KEEINLEHJCM<MBODKENOMLI<TData>> where TData : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public NGMILKCGIMB(MBODKENOMLI<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x278E7F0", Offset = "0x278DBF0", VA = "0x18278E7F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface EFAJJECIJBB : CNKCEPOCDPO
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7181D0", Offset = "0x7175D0")]
public abstract class JPIPPHODFKM<TReceiver, TFromTask> : LBMCNHBKAGL<TReceiver, Task<TFromTask>>
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1306AD0", Offset = "0x1305ED0", VA = "0x181306AD0")]
	public JPIPPHODFKM(TReceiver OAHEFOMGOLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface MDLINKMKCNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLCJBIJJDCB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718240", Offset = "0x717640")] in COBFJEPPAJO<T?> OJAALCHHLPK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHOPKHHJMIL();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7182B0", Offset = "0x7176B0")]
public class IFNFHJLFOHP<TData> : KEEINLEHJCM<NLEIMGGLKNJ<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718320", Offset = "0x717720")]
	private readonly NLHJAPHGPCA<TData> LNCNKBEBCFP;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x15D7F40", Offset = "0x15D7340", VA = "0x1815D7F40")]
	public IFNFHJLFOHP(IEnumerable<TData> NFLEONCKOFE, Quaternion ADFAIMNCMDC, IMBBONDKEDK JHFJDJOKIFA, Vector3? JDLNDKFHHOB, bool JHALFPBMADP, bool EDCBLKGBANG, NLEIMGGLKNJ<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x15D7E80", Offset = "0x15D7280", VA = "0x1815D7E80", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718380", Offset = "0x717780")]
public class GEKINICNBNO<TData> : KEEINLEHJCM<KLBOIFHFKIH<TData>> where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7183F0", Offset = "0x7177F0")]
	private readonly CLGEJHHCPAD<TData> JGPONLPOCFL;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3549780", Offset = "0x3548B80", VA = "0x183549780")]
	public GEKINICNBNO(IEnumerable<TData> NFLEONCKOFE, bool EDCBLKGBANG, KLBOIFHFKIH<TData> OAHEFOMGOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x15CE5F0", Offset = "0x15CD9F0", VA = "0x1815CE5F0", Slot = "4")]
	public override bool NBOCHEIPFNJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface GFFDEPPJCPC<TData>
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBOCHEIPFNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x718450", Offset = "0x717850")] in HEPBPPJIGOH<TData?> OHDCBKBBAMA);
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
