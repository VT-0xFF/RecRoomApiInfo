using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FD34B0", Offset = "0x6FD1EB0", VA = "0x186FD34B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FMACAGIFFFD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KJCBMOAEMAH(ONCNPAAFPAJ CGAJJAALELM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONCNPAAFPAJ FIOJCIMJMME(string CGAJJAALELM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ONCNPAAFPAJ : IEquatable<ONCNPAAFPAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBHMJLHNKHN NGGKMMEJMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OMEPBNMDOOI GCPOCDDBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid IFOAHMLBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? JEOOEKIGNKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EGPFEHJINBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FD42F0", Offset = "0x6FD2CF0", VA = "0x186FD42F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IGOFLPLMGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD4040", Offset = "0x6FD2A40", VA = "0x186FD4040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4860", Offset = "0x6FD3260", VA = "0x186FD4860")]
	public ONCNPAAFPAJ(ONCNPAAFPAJ NHFPGPAMFHJ, [Optional] Guid AFOPNMBEAOM, [Optional] RRColor? COGPPELINPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD47D0", Offset = "0x6FD31D0", VA = "0x186FD47D0")]
	public ONCNPAAFPAJ(GBHMJLHNKHN DFJBPKIEKMC, OMEPBNMDOOI FJBCICKFCNB, [Optional] Guid AFOPNMBEAOM, [Optional] RRColor? COGPPELINPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD41B0", Offset = "0x6FD2BB0", VA = "0x186FD41B0", Slot = "4")]
	public bool Equals(ONCNPAAFPAJ HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4080", Offset = "0x6FD2A80", VA = "0x186FD4080", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4260", Offset = "0x6FD2C60", VA = "0x186FD4260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD41B0", Offset = "0x6FD2BB0", VA = "0x186FD41B0")]
	public static bool IKJGJDJDJIH(ONCNPAAFPAJ FKJLOGAHGLJ, ONCNPAAFPAJ MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD43B0", Offset = "0x6FD2DB0", VA = "0x186FD43B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GBHMJLHNKHN : IEquatable<GBHMJLHNKHN>, IComparable<GBHMJLHNKHN>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly GBHMJLHNKHN EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public GBHMJLHNKHN(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(GBHMJLHNKHN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(GBHMJLHNKHN HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2E20", Offset = "0x6FD1820", VA = "0x186FD2E20", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(GBHMJLHNKHN FKJLOGAHGLJ, GBHMJLHNKHN MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(GBHMJLHNKHN FKJLOGAHGLJ, GBHMJLHNKHN MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2ED0", Offset = "0x6FD18D0", VA = "0x186FD2ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HLNCNEOFKGK : IEquatable<HLNCNEOFKGK>, IComparable<HLNCNEOFKGK>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly HLNCNEOFKGK EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public HLNCNEOFKGK(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(HLNCNEOFKGK HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(HLNCNEOFKGK HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3060", Offset = "0x6FD1A60", VA = "0x186FD3060", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(HLNCNEOFKGK FKJLOGAHGLJ, HLNCNEOFKGK MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(HLNCNEOFKGK FKJLOGAHGLJ, HLNCNEOFKGK MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3110", Offset = "0x6FD1B10", VA = "0x186FD3110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KJEDFHBBPGK : IEquatable<KJEDFHBBPGK>, IComparable<KJEDFHBBPGK>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KJEDFHBBPGK EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public KJEDFHBBPGK(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(KJEDFHBBPGK HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(KJEDFHBBPGK HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6FD32A0", Offset = "0x6FD1CA0", VA = "0x186FD32A0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(KJEDFHBBPGK FKJLOGAHGLJ, KJEDFHBBPGK MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(KJEDFHBBPGK FKJLOGAHGLJ, KJEDFHBBPGK MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3350", Offset = "0x6FD1D50", VA = "0x186FD3350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct OMEPBNMDOOI : IEquatable<OMEPBNMDOOI>, IComparable<OMEPBNMDOOI>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly OMEPBNMDOOI EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ICFGFCOCCJK IHMADDKBCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BB0", Offset = "0x8BF5B0", VA = "0x1808C0BB0")]
		[CompilerGenerated]
		get
		{
			return default(ICFGFCOCCJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ICFGFCOCCJK MDOOCFCFGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BC0", Offset = "0x8BF5C0", VA = "0x1808C0BC0")]
		[CompilerGenerated]
		get
		{
			return default(ICFGFCOCCJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ICFGFCOCCJK EEFJOGBKLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D39C0", Offset = "0x8D23C0", VA = "0x1808D39C0")]
		[CompilerGenerated]
		get
		{
			return default(ICFGFCOCCJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3FB0", Offset = "0x6FD29B0", VA = "0x186FD3FB0")]
	public OMEPBNMDOOI(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3FF0", Offset = "0x6FD29F0", VA = "0x186FD3FF0")]
	public OMEPBNMDOOI(ICFGFCOCCJK IEDCJHDHIPE, ICFGFCOCCJK JMLAGCMJMGO, ICFGFCOCCJK BEIBKBGPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3E10", Offset = "0x6FD2810", VA = "0x186FD3E10")]
	private Guid JOOCPHKKILB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3DA0", Offset = "0x6FD27A0", VA = "0x186FD3DA0", Slot = "4")]
	public bool Equals(OMEPBNMDOOI HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3CF0", Offset = "0x6FD26F0", VA = "0x186FD3CF0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3DD0", Offset = "0x6FD27D0", VA = "0x186FD3DD0")]
	public static bool IKJGJDJDJIH(OMEPBNMDOOI FKJLOGAHGLJ, OMEPBNMDOOI MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3C70", Offset = "0x6FD2670", VA = "0x186FD3C70")]
	public static bool BNNGOGJDCPO(OMEPBNMDOOI FKJLOGAHGLJ, OMEPBNMDOOI MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3CB0", Offset = "0x6FD26B0", VA = "0x186FD3CB0", Slot = "5")]
	public int CompareTo(OMEPBNMDOOI HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3F40", Offset = "0x6FD2940", VA = "0x186FD3F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PALMOAGHFKD : IEquatable<PALMOAGHFKD>, IComparable<PALMOAGHFKD>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly PALMOAGHFKD EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public PALMOAGHFKD(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(PALMOAGHFKD HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(PALMOAGHFKD HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD48F0", Offset = "0x6FD32F0", VA = "0x186FD48F0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(PALMOAGHFKD FKJLOGAHGLJ, PALMOAGHFKD MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(PALMOAGHFKD FKJLOGAHGLJ, PALMOAGHFKD MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FD49A0", Offset = "0x6FD33A0", VA = "0x186FD49A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ENFHCMKIOHI : IEquatable<ENFHCMKIOHI>, IComparable<ENFHCMKIOHI>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly ENFHCMKIOHI EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public ENFHCMKIOHI(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(ENFHCMKIOHI HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(ENFHCMKIOHI HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2D00", Offset = "0x6FD1700", VA = "0x186FD2D00", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(ENFHCMKIOHI FKJLOGAHGLJ, ENFHCMKIOHI MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(ENFHCMKIOHI FKJLOGAHGLJ, ENFHCMKIOHI MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2DB0", Offset = "0x6FD17B0", VA = "0x186FD2DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct EDPKFFIMOMC : IEquatable<EDPKFFIMOMC>, IComparable<EDPKFFIMOMC>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly EDPKFFIMOMC EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public EDPKFFIMOMC(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(EDPKFFIMOMC HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(EDPKFFIMOMC HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BE0", Offset = "0x6FD15E0", VA = "0x186FD2BE0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(EDPKFFIMOMC FKJLOGAHGLJ, EDPKFFIMOMC MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(EDPKFFIMOMC FKJLOGAHGLJ, EDPKFFIMOMC MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2C90", Offset = "0x6FD1690", VA = "0x186FD2C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GLMCIKGKCFG : IEquatable<GLMCIKGKCFG>, IComparable<GLMCIKGKCFG>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GLMCIKGKCFG EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public GLMCIKGKCFG(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(GLMCIKGKCFG HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(GLMCIKGKCFG HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2F40", Offset = "0x6FD1940", VA = "0x186FD2F40", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(GLMCIKGKCFG FKJLOGAHGLJ, GLMCIKGKCFG MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2BB0", Offset = "0x6FD15B0", VA = "0x186FD2BB0")]
	public static bool BNNGOGJDCPO(GLMCIKGKCFG FKJLOGAHGLJ, GLMCIKGKCFG MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD2FF0", Offset = "0x6FD19F0", VA = "0x186FD2FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ODBFAAJEAMN : IEquatable<ODBFAAJEAMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? GGHPIAPPLOE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DJEJGGIOHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3770", Offset = "0x6FD2170", VA = "0x186FD3770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int HIGFIALMKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x41C7D40", Offset = "0x41C6740", VA = "0x1841C7D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3AB0", Offset = "0x6FD24B0", VA = "0x186FD3AB0")]
	public ODBFAAJEAMN(string? ODBGFBLFNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3BF0", Offset = "0x6FD25F0", VA = "0x186FD3BF0")]
	public ODBFAAJEAMN(string?[] BKFOIIEIENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FD37F0", Offset = "0x6FD21F0", VA = "0x186FD37F0")]
	private static string?[]? KPGBAANLIJD(string?[]? BKFOIIEIENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3790", Offset = "0x6FD2190", VA = "0x186FD3790")]
	public string JEKFBOCKKCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FD35C0", Offset = "0x6FD1FC0", VA = "0x186FD35C0", Slot = "4")]
	public bool Equals(ODBFAAJEAMN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3530", Offset = "0x6FD1F30", VA = "0x186FD3530", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3690", Offset = "0x6FD2090", VA = "0x186FD3690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3A20", Offset = "0x6FD2420", VA = "0x186FD3A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ICFGFCOCCJK : IEquatable<ICFGFCOCCJK>, IComparable<ICFGFCOCCJK>, MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ICFGFCOCCJK EOPMNGGGOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid JCMDDLFAGEN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public ICFGFCOCCJK(Guid JCMDDLFAGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
	public Guid EOKHFMBEOJK()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670", Slot = "4")]
	public bool Equals(ICFGFCOCCJK HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41F1520", Offset = "0x41EFF20", VA = "0x1841F1520", Slot = "5")]
	public int CompareTo(ICFGFCOCCJK HENLEJBGFIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3180", Offset = "0x6FD1B80", VA = "0x186FD3180", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41F1780", Offset = "0x41F0180", VA = "0x1841F1780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41F1670", Offset = "0x41F0070", VA = "0x1841F1670")]
	public static bool IKJGJDJDJIH(ICFGFCOCCJK FKJLOGAHGLJ, ICFGFCOCCJK MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD3230", Offset = "0x6FD1C30", VA = "0x186FD3230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JJLKMNEMLLL<TModern> : OMMBGELPKNC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DJNGOEHBJAJ(TModern OHHNEMKBIOH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MIPPIMJAJNA
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid EOKHFMBEOJK();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OMMBGELPKNC<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern LKIKGOEDKPB(string OHHNEMKBIOH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BPFFNPJOOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JJLKMNEMLLL<GBHMJLHNKHN> PINDLEBOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JJLKMNEMLLL<PALMOAGHFKD> EBHBMKGLAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JJLKMNEMLLL<GLMCIKGKCFG> CELBLIHMCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JJLKMNEMLLL<OMEPBNMDOOI> MCHGDLMODKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JJLKMNEMLLL<KJEDFHBBPGK> HKDCLIEFGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JJLKMNEMLLL<EDPKFFIMOMC> LNAPCFMDJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JJLKMNEMLLL<HLNCNEOFKGK> FCGBONPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JJLKMNEMLLL<ENFHCMKIOHI> HLACIIBJNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MGCEMJAMAGD
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD33F0", Offset = "0x6FD1DF0", VA = "0x186FD33F0")]
	public static string[] LAKEFOKDMCH(string? ODBGFBLFNPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD33C0", Offset = "0x6FD1DC0", VA = "0x186FD33C0")]
	public static string? DFLEGDIGLDM(string? DFJBPKIEKMC)
	{
		return null;
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
