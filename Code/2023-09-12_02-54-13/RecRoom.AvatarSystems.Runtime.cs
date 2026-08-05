using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
using RecRoom.NoEngine.Common;
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DF89A0", Offset = "0x6DF7DA0", VA = "0x186DF89A0")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
public interface CPJALCLJMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCJOCJNCING(NDCIKJDHDKC MMFHHHHBNLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7293E0", Offset = "0x7287E0")] IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCJOCJNCING(FPFBGEIGHBC LPNMKHOMEOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729440", Offset = "0x728840")] IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NPECACBIKJK]
internal class EPMOGFFGOCM : CPJALCLJMFL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void IEKGDEPLEDO<in TData>(TData MMFHHHHBNLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7296C0", Offset = "0x728AC0")] IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HHFMPAFKPJI KJBKDCEDPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FHPGBOJECFJ OJMEENEKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7294E0", Offset = "0x7288E0")]
	private readonly IEKGDEPLEDO<NDCIKJDHDKC>[] MMPFAHPPCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729540", Offset = "0x728940")]
	private readonly IEKGDEPLEDO<FPFBGEIGHBC>[] LEFNHHHDCNA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DF10D0", Offset = "0x6DF04D0", VA = "0x186DF10D0")]
	[UsedImplicitly]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Root, CDFBKAGHDGH.GameOnly)]
	private static void FMODBFPJEJN(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DF1EF0", Offset = "0x6DF12F0", VA = "0x186DF1EF0")]
	[Preserve]
	internal EPMOGFFGOCM([JLJFOFICIEA(null)] HHFMPAFKPJI KJBKDCEDPDB, [JLJFOFICIEA(null)] FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DF1DC0", Offset = "0x6DF11C0", VA = "0x186DF1DC0", Slot = "4")]
	public bool MCJOCJNCING(NDCIKJDHDKC MMFHHHHBNLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7295A0", Offset = "0x7289A0")] IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF1BF0", Offset = "0x6DF0FF0", VA = "0x186DF1BF0", Slot = "5")]
	public bool MCJOCJNCING(FPFBGEIGHBC LPNMKHOMEOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729600", Offset = "0x728A00")] IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF1140", Offset = "0x6DF0540", VA = "0x186DF1140")]
	private void KEJAAOBNIEP(NDCIKJDHDKC MMFHHHHBNLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729660", Offset = "0x728A60")] IReadOnlyList<MDFEGFGPAHN> PIALDONBLBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NPECACBIKJK]
internal class JIJPLADDOLJ : DEGCLHMNLNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CPJALCLJMFL MMPFAHPPCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ICKGKIFLHLN KLDGNMEEMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HHFMPAFKPJI KJBKDCEDPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KIHKKABKCPJ GOMMMIJEKBI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5C80", Offset = "0x6DF5080", VA = "0x186DF5C80")]
	[UsedImplicitly]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Root, CDFBKAGHDGH.GameOnly)]
	private static void FMODBFPJEJN(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7370", Offset = "0x6DF6770", VA = "0x186DF7370")]
	[Preserve]
	internal JIJPLADDOLJ([JLJFOFICIEA(null)] CPJALCLJMFL MMPFAHPPCKO, [JLJFOFICIEA(null)] ICKGKIFLHLN KLDGNMEEMPM, [JLJFOFICIEA(null)] HHFMPAFKPJI KJBKDCEDPDB, [JLJFOFICIEA(null)] KIHKKABKCPJ GOMMMIJEKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6BC0", Offset = "0x6DF5FC0", VA = "0x186DF6BC0", Slot = "5")]
	public NDCIKJDHDKC OMEMHFGOKGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6080", Offset = "0x6DF5480", VA = "0x186DF6080", Slot = "4")]
	public NDCIKJDHDKC NMBLMKDMJJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5F80", Offset = "0x6DF5380", VA = "0x186DF5F80", Slot = "6")]
	public FMLIPOPOKDJ NDLKIKAFJDM(NDCIKJDHDKC CLCAIFLMLCJ, int GEPLMNAFKJA, string? GDKOBCHHFLB, string? PPEDKJIBEEA, LILCONHACAJ AIBOPONHKNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729800", Offset = "0x728C00")] List<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5BF0", Offset = "0x6DF4FF0", VA = "0x186DF5BF0", Slot = "7")]
	public bool EMKAGLMDGDO(NFLIJKOGOLE LPNMKHOMEOB, out NDCIKJDHDKC? MMFHHHHBNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5CF0", Offset = "0x6DF50F0", VA = "0x186DF5CF0", Slot = "8")]
	public bool GDAADHAHBOB(FMLIPOPOKDJ LFCGPMGAEOI, out NDCIKJDHDKC? MMFHHHHBNLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DF72E0", Offset = "0x6DF66E0", VA = "0x186DF72E0", Slot = "9")]
	public bool POHHJMGFIBL(FMLIPOPOKDJ LFCGPMGAEOI, out FPFBGEIGHBC? LPNMKHOMEOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1640620", Offset = "0x163FA20", VA = "0x181640620")]
	private bool NOPAIGMPDFJ<TInput, TOutput>(TInput MNNPDPNIFNM, EIMKELAIHEK<TInput, TOutput> IGFGJEKCMLK, out TOutput? MOOEDNDCGLB) where TInput : notnull where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5DE0", Offset = "0x6DF51E0", VA = "0x186DF5DE0")]
	[CompilerGenerated]
	private EOALOMCEFGC GJGHINENFJB(FaceFeatureType GBLMBGFHEIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF6940", Offset = "0x6DF5D40", VA = "0x186DF6940")]
	[CompilerGenerated]
	private EOALOMCEFGC OLLIOHGDJDP(FaceFeatureType GBLMBGFHEIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NFLKEPINKAL
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8660", Offset = "0x6DF7A60", VA = "0x186DF8660")]
	public static MONOMKJHJJP EFFJDOFDOEN(this BIBAOLIFLFK CLCAIFLMLCJ)
	{
		return default(MONOMKJHJJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF84A0", Offset = "0x6DF78A0", VA = "0x186DF84A0")]
	public static BIBAOLIFLFK CJMDONJKOCN(this MONOMKJHJJP APAAFACFMDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Preserve]
internal class KLJBBOIMGGD : DFEIIKPEAJH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2370410", Offset = "0x236F810", VA = "0x182370410", Slot = "4")]
	public string ANMNNKPAIGO<T>(T HFAGBIOODHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2370560", Offset = "0x236F960", VA = "0x182370560", Slot = "5")]
	public T PMNPPFNFHJJ<T>(string AGLCIEKHLEE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public KLJBBOIMGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ICKGKIFLHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EIMKELAIHEK<NFLIJKOGOLE, NDCIKJDHDKC> GKPAKKKFFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EIMKELAIHEK<FMLIPOPOKDJ, FPFBGEIGHBC> OAFCPOAOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BLNICJNOJEJ MDAKGJJJLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EFLGLMOJMME
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEPHEDCJLBD CJMDONJKOCN(NDCIKJDHDKC CLCAIFLMLCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BLNICJNOJEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMLIPOPOKDJ CJMDONJKOCN(NDCIKJDHDKC CLCAIFLMLCJ, int GEPLMNAFKJA, string? GDKOBCHHFLB, string? PPEDKJIBEEA, LILCONHACAJ AIBOPONHKNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7298A0", Offset = "0x728CA0")] List<MDFEGFGPAHN> EBFABPAEHHM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class FJHCFFMHHFB : ICKGKIFLHLN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EIMKELAIHEK<NFLIJKOGOLE, NDCIKJDHDKC> GKPAKKKFFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EIMKELAIHEK<FMLIPOPOKDJ, FPFBGEIGHBC> HJBOHPJDPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EIMKELAIHEK<FMLIPOPOKDJ, FPFBGEIGHBC> OAFCPOAOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BLNICJNOJEJ MDAKGJJJLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EFLGLMOJMME GPEBMGDAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2120", Offset = "0x6DF1520", VA = "0x186DF2120")]
	[UsedImplicitly]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Root, CDFBKAGHDGH.GameOnly)]
	private static void FMODBFPJEJN(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2190", Offset = "0x6DF1590", VA = "0x186DF2190")]
	[Preserve]
	internal FJHCFFMHHFB([JLJFOFICIEA("UnitySerialization")] DFEIIKPEAJH ILFEEDOPCNA, [JLJFOFICIEA(null)] DPPDOHIIFOI JKJBHKOGOOF, [JLJFOFICIEA(null)] FHPGBOJECFJ OJMEENEKFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal abstract class FABCFIJAFOI<TInput, TOutput> : EIMKELAIHEK<TInput, TOutput> where TInput : notnull where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly FHPGBOJECFJ OJMEENEKFNI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1315D20", Offset = "0x1315120", VA = "0x181315D20")]
	protected FABCFIJAFOI(FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput EFFJDOFDOEN(TInput MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7299B0", Offset = "0x728DB0")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1315C70", Offset = "0x1315070", VA = "0x181315C70", Slot = "5")]
	public bool NOPAIGMPDFJ(TInput MNNPDPNIFNM, out TOutput? MOOEDNDCGLB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729A10", Offset = "0x728E10")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EIMKELAIHEK<in TInput, TOutput> where TInput : notnull where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput EFFJDOFDOEN(TInput MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729A70", Offset = "0x728E70")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOPAIGMPDFJ(TInput MNNPDPNIFNM, out TOutput? MOOEDNDCGLB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729AD0", Offset = "0x728ED0")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[NPECACBIKJK]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729B30", Offset = "0x728F30")]
internal class JPHFMDBIJJJ : FABCFIJAFOI<NFLIJKOGOLE, NDCIKJDHDKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DPPDOHIIFOI JKJBHKOGOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IIMHOCPBALA GLIIDJGFNKD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7880", Offset = "0x6DF6C80", VA = "0x186DF7880")]
	public JPHFMDBIJJJ(DFEIIKPEAJH ILFEEDOPCNA, DPPDOHIIFOI JKJBHKOGOOF, FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7540", Offset = "0x6DF6940", VA = "0x186DF7540", Slot = "6")]
	public override NDCIKJDHDKC EFFJDOFDOEN(NFLIJKOGOLE MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729BB0", Offset = "0x728FB0")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[NPECACBIKJK]
public static class LDCCMCDAKJG
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly Regex MMMBGLEMMEE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DF80C0", Offset = "0x6DF74C0", VA = "0x186DF80C0")]
	public static AGLCNMBLMLO INOALBEMPOO(OKKHNOAMHFC JKBKECCMLMK, MFHLJNIJHGK NFIEOEPLEJG, Guid? PPDMLPDDCKA, Color? FHBHPPKPKEM, LINLIEGLBCE EKHHAIPAMDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x23750A0", Offset = "0x23744A0", VA = "0x1823750A0")]
	internal static TModern? EFKIJBBGAOP<TModern>(string? MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729C50", Offset = "0x729050")] LMHHEANJMDP<TModern> HJGANFHENKI, FHPGBOJECFJ OJMEENEKFNI, KOHBHCKOMOM DLIMFNHHENA, TModern GEAMEBMNIAF) where TModern : struct, HGMCICIEMNE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2377390", Offset = "0x2376790", VA = "0x182377390")]
	internal static BNGEEOAJAFI KEJOMOCCKNL<TModern>(string? MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729CB0", Offset = "0x7290B0")] LMHHEANJMDP<TModern> HJGANFHENKI, FHPGBOJECFJ OJMEENEKFNI, KOHBHCKOMOM DLIMFNHHENA, TModern GEAMEBMNIAF) where TModern : struct, HGMCICIEMNE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DF82D0", Offset = "0x6DF76D0", VA = "0x186DF82D0")]
	internal static List<MDFEGFGPAHN> JDAACELIKPN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729D10", Offset = "0x729110")] IEnumerable<PFBJPHJEFKG> BOGOIOCOAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x23765E0", Offset = "0x23759E0", VA = "0x1823765E0")]
	internal static string GJHLPGFHLCI<TModern>(TModern MNNPDPNIFNM, LMHHEANJMDP<TModern> HJGANFHENKI, FHPGBOJECFJ OJMEENEKFNI) where TModern : notnull, HGMCICIEMNE
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NPECACBIKJK]
internal class KGGMEFPFIGI : BLNICJNOJEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly DFEIIKPEAJH ILFEEDOPCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EFLGLMOJMME ODIFIGHHMIH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7DC0", Offset = "0x6DF71C0", VA = "0x186DF7DC0")]
	public KGGMEFPFIGI(EFLGLMOJMME ODIFIGHHMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7A30", Offset = "0x6DF6E30", VA = "0x186DF7A30", Slot = "4")]
	public FMLIPOPOKDJ CJMDONJKOCN(NDCIKJDHDKC CLCAIFLMLCJ, int GEPLMNAFKJA, string? GDKOBCHHFLB, string? PPEDKJIBEEA, LILCONHACAJ AIBOPONHKNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729D90", Offset = "0x729190")] List<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NPECACBIKJK]
internal class PNPEKPDIDCO : BBHCFEGAMFP, EFLGLMOJMME
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D20", Offset = "0x6DF0120", VA = "0x186DF0D20")]
	public PNPEKPDIDCO(DFEIIKPEAJH ILFEEDOPCNA, DPPDOHIIFOI JKJBHKOGOOF, FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8A30", Offset = "0x6DF7E30", VA = "0x186DF8A30", Slot = "4")]
	public OEPHEDCJLBD CJMDONJKOCN(NDCIKJDHDKC CLCAIFLMLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8EB0", Offset = "0x6DF82B0", VA = "0x186DF8EB0")]
	private string GLBHBGCFDCM(NDCIKJDHDKC MMFHHHHBNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8FD0", Offset = "0x6DF83D0", VA = "0x186DF8FD0")]
	private string INJNCIBGKMK(AGLCNMBLMLO NKKJPODIBJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NPECACBIKJK]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729DF0", Offset = "0x7291F0")]
internal class IIMHOCPBALA : FABCFIJAFOI<FMLIPOPOKDJ, FPFBGEIGHBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly DFEIIKPEAJH ILFEEDOPCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DPPDOHIIFOI JKJBHKOGOOF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5AC0", Offset = "0x6DF4EC0", VA = "0x186DF5AC0")]
	public IIMHOCPBALA(DFEIIKPEAJH ILFEEDOPCNA, DPPDOHIIFOI JKJBHKOGOOF, FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4040", Offset = "0x6DF3440", VA = "0x186DF4040", Slot = "6")]
	public override FPFBGEIGHBC EFFJDOFDOEN(FMLIPOPOKDJ MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729E70", Offset = "0x729270")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4700", Offset = "0x6DF3B00", VA = "0x186DF4700")]
	internal void HNFEFNMCCNN(string LBGFCHBCGLO, NDCIKJDHDKC MMFHHHHBNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5590", Offset = "0x6DF4990", VA = "0x186DF5590")]
	public IEnumerable<AGLCNMBLMLO> KNJHMIHGCNA(string GPAKIIAPIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DF5680", Offset = "0x6DF4A80", VA = "0x186DF5680")]
	private IEnumerable<AGLCNMBLMLO> LGMEAFLHDON(string GPAKIIAPIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3B70", Offset = "0x6DF2F70", VA = "0x186DF3B70")]
	internal IEnumerable<AGLCNMBLMLO> EBNDCOCLOFI(string GPAKIIAPIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3180", Offset = "0x6DF2580", VA = "0x186DF3180")]
	private AGLCNMBLMLO AHMOHDFOCHC(AvatarOutfitSelectionData GFGHIOELLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4B50", Offset = "0x6DF3F50", VA = "0x186DF4B50")]
	private void JBDBNFIHFPC(AvatarCustomizationSettingsData FFBECJOKKNI, NDCIKJDHDKC MMFHHHHBNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF35E0", Offset = "0x6DF29E0", VA = "0x186DF35E0")]
	private AGLCNMBLMLO AHMOHDFOCHC(string JMGEDKDEIEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF4840", Offset = "0x6DF3C40", VA = "0x186DF4840")]
	internal static (LINLIEGLBCE, string, string) IGNJHMFJLIJ(string JMGEDKDEIEL, FHPGBOJECFJ OJMEENEKFNI)
	{
		return default((LINLIEGLBCE, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DF44F0", Offset = "0x6DF38F0", VA = "0x186DF44F0")]
	private EOALOMCEFGC? FCBMEPMJLJD(string? DDJMKPCJBFO, Vector2 IHJPPPNFCFB, float BBNEKBEFOCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3990", Offset = "0x6DF2D90", VA = "0x186DF3990")]
	private static IPALEFGGLBM CKJOPGNBMOC(AvatarCustomizationSettingsData.AnchorParams MDDMGCOGEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal enum KOHBHCKOMOM
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class KLKCIJHKOAL : DFEIIKPEAJH
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729ED0", Offset = "0x7292D0")]
	private class BJGAGPOHPPP : JsonConverter<BNGEEOAJAFI>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0FE0", Offset = "0x6DF03E0", VA = "0x186DF0FE0", Slot = "9")]
		public override void WriteJson(JsonWriter OMPJFFNAHDO, BNGEEOAJAFI? AGLCIEKHLEE, JsonSerializer BIMCFGLAOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0E90", Offset = "0x6DF0290", VA = "0x186DF0E90", Slot = "10")]
		public override BNGEEOAJAFI ReadJson(JsonReader BFNPCLOLNAF, Type FPMOMLONBEI, BNGEEOAJAFI? KHEPONBELHD, bool AEIPIPBOAMA, JsonSerializer BIMCFGLAOAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF1090", Offset = "0x6DF0490", VA = "0x186DF1090")]
		public BJGAGPOHPPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class FMKDBKNEHFJ : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool LCHJBBHAJLH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2AB0", Offset = "0x6DF1EB0", VA = "0x186DF2AB0", Slot = "5")]
		public override object ReadJson(JsonReader BFNPCLOLNAF, Type FPMOMLONBEI, object? KHEPONBELHD, JsonSerializer BIMCFGLAOAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DF26B0", Offset = "0x6DF1AB0", VA = "0x186DF26B0", Slot = "6")]
		public override bool CanConvert(Type FPMOMLONBEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2B00", Offset = "0x6DF1F00", VA = "0x186DF2B00", Slot = "4")]
		public override void WriteJson(JsonWriter OMPJFFNAHDO, object? AGLCIEKHLEE, JsonSerializer BIMCFGLAOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6DF28D0", Offset = "0x6DF1CD0", VA = "0x186DF28D0")]
		private static bool JOIJNPCNEFD(object AGLCIEKHLEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public FMKDBKNEHFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JsonSerializerSettings KHIAIPDLLBL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7F70", Offset = "0x6DF7370", VA = "0x186DF7F70")]
	internal KLKCIJHKOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2370B40", Offset = "0x236FF40", VA = "0x182370B40", Slot = "4")]
	public string ANMNNKPAIGO<T>(T HFAGBIOODHL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2370CB0", Offset = "0x23700B0", VA = "0x182370CB0", Slot = "5")]
	public T PMNPPFNFHJJ<T>(string AGLCIEKHLEE) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal abstract class BBHCFEGAMFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly DFEIIKPEAJH ILFEEDOPCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly DPPDOHIIFOI JKJBHKOGOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly FHPGBOJECFJ OJMEENEKFNI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D20", Offset = "0x6DF0120", VA = "0x186DF0D20")]
	protected BBHCFEGAMFP(DFEIIKPEAJH ILFEEDOPCNA, DPPDOHIIFOI JKJBHKOGOOF, FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF880", Offset = "0x6DEEC80", VA = "0x186DEF880")]
	protected string OKDMEDMNACA(NDCIKJDHDKC MMFHHHHBNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF140", Offset = "0x6DEE540", VA = "0x186DEF140")]
	protected string BIKJNKOFEFL(NDCIKJDHDKC MMFHHHHBNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF340", Offset = "0x6DEE740", VA = "0x186DEF340")]
	private AvatarOutfitSelectionData INOALBEMPOO(AGLCNMBLMLO NKKJPODIBJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF730", Offset = "0x6DEEB30", VA = "0x186DEF730")]
	private static AvatarCustomizationSettingsData.AnchorParams LPIAEAMNMDC(IPALEFGGLBM? EPLJFIEGDKC)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[NPECACBIKJK]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729F30", Offset = "0x729330")]
internal class HPOKDCNNHCJ : FABCFIJAFOI<FMLIPOPOKDJ, FPFBGEIGHBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly DFEIIKPEAJH ILFEEDOPCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly EIMKELAIHEK<FMLIPOPOKDJ, FPFBGEIGHBC> LEGNBPECJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3080", Offset = "0x6DF2480", VA = "0x186DF3080")]
	public HPOKDCNNHCJ(EIMKELAIHEK<FMLIPOPOKDJ, FPFBGEIGHBC> LEGNBPECJMJ, FHPGBOJECFJ OJMEENEKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2BF0", Offset = "0x6DF1FF0", VA = "0x186DF2BF0", Slot = "6")]
	public override FPFBGEIGHBC EFFJDOFDOEN(FMLIPOPOKDJ MNNPDPNIFNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x729FB0", Offset = "0x7293B0")] out IReadOnlyList<MDFEGFGPAHN> EBFABPAEHHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DMKLDNAKDBH
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KJAEADPFLLJ : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7EA0", Offset = "0x6DF72A0", VA = "0x186DF7EA0")]
	public KJAEADPFLLJ(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7F40", Offset = "0x6DF7340", VA = "0x186DF7F40")]
	public KJAEADPFLLJ(string FHDJIGKOLJM, Exception FMNNOJDKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7F10", Offset = "0x6DF7310", VA = "0x186DF7F10")]
	public KJAEADPFLLJ(DMKLDNAKDBH BLBLLAALJCA, string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7ED0", Offset = "0x6DF72D0", VA = "0x186DF7ED0")]
	public KJAEADPFLLJ(DMKLDNAKDBH BLBLLAALJCA, string FHDJIGKOLJM, Exception FMNNOJDKJHA)
	{
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x72A010", Offset = "0x729410")]
		public AvatarOutfitSelectionData[] selections;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AvatarUgcOutfitData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6DEED50", Offset = "0x6DEE150", VA = "0x186DEED50")]
			public AnchorParams(Vector2 HNIJCGLDNFD, Vector3 LIGOCNGOPGK, Vector3 FMKJNECBPBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6DEECA0", Offset = "0x6DEE0A0", VA = "0x186DEECA0")]
			internal IPALEFGGLBM CJMDONJKOCN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private LFMICKBGFGF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF040", Offset = "0x6DEE440", VA = "0x186DEF040")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2580700", Offset = "0x257FB00", VA = "0x182580700")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xF8A9E0", Offset = "0xF89DE0", VA = "0x180F8A9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB7E560", Offset = "0xB7D960", VA = "0x180B7E560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3A940D0", Offset = "0x3A934D0", VA = "0x183A940D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA7CE00", Offset = "0xA7C200", VA = "0x180A7CE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8CC080", Offset = "0x8CB480", VA = "0x1808CC080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC4D0", Offset = "0x8CB8D0", VA = "0x1808CC4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF0D0", Offset = "0x6DEE4D0", VA = "0x186DEF0D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA7C440", Offset = "0xA7B840", VA = "0x180A7C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xC2F770", Offset = "0xC2EB70", VA = "0x180C2F770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x1367790", Offset = "0x1366B90", VA = "0x181367790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8F8760", Offset = "0x8F7B60", VA = "0x1808F8760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8CB0F0", Offset = "0x8CA4F0", VA = "0x1808CB0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9D4E0", VA = "0x180B9E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8CA060", Offset = "0x8C9460", VA = "0x1808CA060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8F8480", Offset = "0x8F7880", VA = "0x1808F8480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x822D70", Offset = "0x822170", VA = "0x180822D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5E0", Offset = "0x8BD9E0", VA = "0x1808BE5E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8BE5F0", Offset = "0x8BD9F0", VA = "0x1808BE5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public LFMICKBGFGF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xECB0A0", Offset = "0xECA4A0", VA = "0x180ECB0A0")]
			get
			{
				return default(LFMICKBGFGF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x57B73E0", Offset = "0x57B67E0", VA = "0x1857B73E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x99C690", Offset = "0x99BA90", VA = "0x18099C690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x997EB0", Offset = "0x9972B0", VA = "0x180997EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF0B0", Offset = "0x6DEE4B0", VA = "0x186DEF0B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF0F0", Offset = "0x6DEE4F0", VA = "0x186DEF0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEED80", Offset = "0x6DEE180", VA = "0x186DEED80")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public LINLIEGLBCE BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private PJOBPGBABLP? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF110", Offset = "0x6DEE510", VA = "0x186DEF110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AvatarOutfitSelectionData()
		{
		}
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
