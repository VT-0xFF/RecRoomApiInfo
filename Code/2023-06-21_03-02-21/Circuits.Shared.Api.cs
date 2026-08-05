using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1599F40", Offset = "0x1599140", VA = "0x181599F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Output
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public readonly struct MABFOKNHFNG<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] OOOADBLOEJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x868E0", Offset = "0x85CE0")]
	public IECPEPBGFBA<M> DNFFBAJCDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x303ABD0", Offset = "0x3039DD0", VA = "0x18303ABD0")]
		get
		{
			return default(IECPEPBGFBA<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x13C4780", Offset = "0x13C3980", VA = "0x1813C4780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2EA3760", Offset = "0x2EA2960", VA = "0x182EA3760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	internal MABFOKNHFNG(T[] BGBPILICHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x303AB40", Offset = "0x3039D40", VA = "0x18303AB40")]
	public static MABFOKNHFNG<M, T> NMBJFIHLDEO(int CGGOJFONIPE)
	{
		return default(MABFOKNHFNG<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
	public IEnumerable<T> IIGMGCJMIEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x303AAD0", Offset = "0x3039CD0", VA = "0x18303AAD0")]
	public ELJJGBIJPJE<M, T> LLAFENBKNIA()
	{
		return default(ELJJGBIJPJE<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x303AA50", Offset = "0x3039C50", VA = "0x18303AA50")]
	public IEnumerator<T> KECFEFHENMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x303AC60", Offset = "0x3039E60", VA = "0x18303AC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NEMPDKJFENO<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FEDCD0", Offset = "0x2FECED0", VA = "0x182FEDCD0")]
	public static MABFOKNHFNG<M, T> EGFIMLPAOML<T>(params T[] BGBPILICHHA) where T : notnull
	{
		return default(MABFOKNHFNG<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OLHICKNPALN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3760", Offset = "0x2EA2960", VA = "0x182EA3760")]
	public static T? EEDIHMHDPGO<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86980", Offset = "0x85D80")] this ref MABFOKNHFNG<M?, T?> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x869E0", Offset = "0x85DE0")] IECPEPBGFBA<M?> PPKKHBJMHLB)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3710", Offset = "0x2EA2910", VA = "0x182EA3710")]
	public static void EBIKLMMGLOI<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86A40", Offset = "0x85E40")] this ref MABFOKNHFNG<M?, T?> DCMHODHEGEC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86AA0", Offset = "0x85EA0")] IECPEPBGFBA<M?> PPKKHBJMHLB, in T ACKOJNNBEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IJLDMGHCEDE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KOODFHCKAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KHHILIHMLIO : IEquatable<KHHILIHMLIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float MCHKDNFGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float DPIKPGACBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float MKGFLBBPGNB;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly KHHILIHMLIO MOIMHEMCNNJ;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KHHILIHMLIO PDAHHIKLEGK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly KHHILIHMLIO BKIDJLFGAEI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly KHHILIHMLIO AINBHOEDAOO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly KHHILIHMLIO ACMPDPBJCCK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly KHHILIHMLIO BEFKIJPJOJA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly KHHILIHMLIO KPBHNIGKJAL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly KHHILIHMLIO KNBONGEOHKP;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KHHILIHMLIO ILHIMLGJFAK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly KHHILIHMLIO FHJGJPBACDJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly KHHILIHMLIO AGKAFPMEONC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly KHHILIHMLIO JCDOCKMNDKP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KHHILIHMLIO CFIOJALEBCH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly KHHILIHMLIO HHHGPOFJACH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KHHILIHMLIO POGCOICEIJL;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly KHHILIHMLIO BJKMLCONOHK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KHHILIHMLIO IGACKPGKMFM;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1206AF0", Offset = "0x1205CF0", VA = "0x181206AF0")]
	public KHHILIHMLIO(float JNIPLDLJAIJ, float GEADFOLNEOP, float FNBPEOBHEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1599730", Offset = "0x1598930", VA = "0x181599730")]
	public static KHHILIHMLIO NMBJFIHLDEO(float JNIPLDLJAIJ, float GEADFOLNEOP, float FNBPEOBHEKB)
	{
		return default(KHHILIHMLIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1599670", Offset = "0x1598870", VA = "0x181599670")]
	public static bool JGKKLLGINAK(in KHHILIHMLIO JFHIJPMPOBA, in KHHILIHMLIO LPNFMADJDAF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x15996A0", Offset = "0x15988A0", VA = "0x1815996A0")]
	public static bool NGNNEMMJMMJ(in KHHILIHMLIO JFHIJPMPOBA, in KHHILIHMLIO LPNFMADJDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1599600", Offset = "0x1598800", VA = "0x181599600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1599520", Offset = "0x1598720", VA = "0x181599520", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1599750", Offset = "0x1598950", VA = "0x181599750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1599490", Offset = "0x1598690", VA = "0x181599490", Slot = "4")]
	public bool Equals(KHHILIHMLIO HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Obsolete]
[DefaultMember("Item")]
public ref struct AECIMNCAEFF<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86BC0", Offset = "0x85FC0")]
	private readonly ReadOnlySpan<T> OLDIFEANBCF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C71A30", Offset = "0x4C70C30", VA = "0x184C71A30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3617440", Offset = "0x3616640", VA = "0x183617440")]
	internal AECIMNCAEFF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86C80", Offset = "0x86080")] in ReadOnlySpan<T> CMNAGDFFGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C71A80", Offset = "0x4C70C80", VA = "0x184C71A80", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ODAFPFHHCNL<M>
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x24FD0E0", Offset = "0x24FC2E0", VA = "0x1824FD0E0")]
	public static AECIMNCAEFF<M?, T?> LHKPGCJIJPE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86D30", Offset = "0x86130")] in ReadOnlySpan<T?> CMNAGDFFGOG)
	{
		return default(AECIMNCAEFF<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct MCPJAFNLLKB : IEquatable<MCPJAFNLLKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly BKOELCEBLFL ALIPIPOJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly KHHILIHMLIO NHHHMBLFJFD;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly MCPJAFNLLKB HABMLNJKAHI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1599F20", Offset = "0x1599120", VA = "0x181599F20")]
	public MCPJAFNLLKB(in BKOELCEBLFL AAECNILGNMA, in KHHILIHMLIO FNDKHLEFPKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1599CC0", Offset = "0x1598EC0", VA = "0x181599CC0")]
	public static bool JGKKLLGINAK(in MCPJAFNLLKB JFHIJPMPOBA, in MCPJAFNLLKB LPNFMADJDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1599C30", Offset = "0x1598E30", VA = "0x181599C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1599B60", Offset = "0x1598D60", VA = "0x181599B60", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1599DB0", Offset = "0x1598FB0", VA = "0x181599DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1599AF0", Offset = "0x1598CF0", VA = "0x181599AF0", Slot = "4")]
	public bool Equals(MCPJAFNLLKB HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LAPEBNKEBIA<M, T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86DE0", Offset = "0x861E0")]
	private readonly ReadOnlyMemory<T?> NDNKPMJBJAH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275ADE0", VA = "0x18275BBE0")]
	internal LAPEBNKEBIA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86E40", Offset = "0x86240")] in ReadOnlyMemory<T?> NNHOBEMMLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x353AFC0", Offset = "0x353A1C0", VA = "0x18353AFC0")]
	public AECIMNCAEFF<M?, T?> GNBCMDLNMIH()
	{
		return default(AECIMNCAEFF<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x353B0A0", Offset = "0x353A2A0", VA = "0x18353B0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HMNEAHLDPIG<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26284B0", Offset = "0x26276B0", VA = "0x1826284B0")]
	public static LAPEBNKEBIA<M?, T?> OMCBANFDDKH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86EB0", Offset = "0x862B0")] in ReadOnlyMemory<T?> NNHOBEMMLAH)
	{
		return default(LAPEBNKEBIA<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IECPEPBGFBA<TMarker> : IEquatable<IECPEPBGFBA<TMarker>>, MFKMHCNJACH<IECPEPBGFBA<TMarker>>, IComparable<IECPEPBGFBA<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly int OKDOHILJKEG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87240", Offset = "0x86640")]
	public IECPEPBGFBA<TMarker> DGJHKAHKEON
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2A00240", Offset = "0x29FF440", VA = "0x182A00240")]
		get
		{
			return default(IECPEPBGFBA<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x872A0", Offset = "0x866A0")]
	public IECPEPBGFBA<TMarker> BCNBMDEJAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A00400", Offset = "0x29FF600", VA = "0x182A00400")]
		get
		{
			return default(IECPEPBGFBA<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
	public IECPEPBGFBA(int ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2635450", Offset = "0x2634650", VA = "0x182635450")]
	public IECPEPBGFBA<TOther> ACAMHKLBCDE<TOther>() where TOther : TMarker
	{
		return default(IECPEPBGFBA<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A002D0", Offset = "0x29FF4D0", VA = "0x182A002D0")]
	public bool DMPMLAKNGKG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86F20", Offset = "0x86320")] in IECPEPBGFBA<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A00370", Offset = "0x29FF570", VA = "0x182A00370", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86F90", Offset = "0x86390")] IECPEPBGFBA<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A002F0", Offset = "0x29FF4F0", VA = "0x182A002F0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A002B0", Offset = "0x29FF4B0", VA = "0x182A002B0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x86FF0", Offset = "0x863F0")] IECPEPBGFBA<TMarker> HPOECFLNEOJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A003C0", Offset = "0x29FF5C0", VA = "0x182A003C0")]
	public static bool JGKKLLGINAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87050", Offset = "0x86450")] IECPEPBGFBA<TMarker> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x870B0", Offset = "0x864B0")] IECPEPBGFBA<TMarker> KEJINCBACKA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A004C0", Offset = "0x29FF6C0", VA = "0x182A004C0")]
	public static bool NGNNEMMJMMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87110", Offset = "0x86510")] IECPEPBGFBA<TMarker> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87170", Offset = "0x86570")] IECPEPBGFBA<TMarker> KEJINCBACKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1400E70", Offset = "0x1400070", VA = "0x181400E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A00510", Offset = "0x29FF710", VA = "0x182A00510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A00470", Offset = "0x29FF670", VA = "0x182A00470", Slot = "5")]
	private bool MGNPKCFMJND([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x871D0", Offset = "0x865D0")] in IECPEPBGFBA<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AAJDNGCGAJK
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2A10", Offset = "0x2AE1C10", VA = "0x182AE2A10")]
	public static IECPEPBGFBA<TMarker?> ANFIHEHHKAO<TMarker>(this int DCMHODHEGEC)
	{
		return default(IECPEPBGFBA<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2A10", Offset = "0x2AE1C10", VA = "0x182AE2A10")]
	public static IECPEPBGFBA<TMarker?> MIMJIFFIALF<TMarker>(this int DCMHODHEGEC)
	{
		return default(IECPEPBGFBA<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2AB0", Offset = "0x2AE1CB0", VA = "0x182AE2AB0")]
	public static JNOMCIGDOCK<IECPEPBGFBA<TMarker?>, BBNPKBBLCKC<TMarker?>> LNMCHLIBOMC<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87340", Offset = "0x86740")] IECPEPBGFBA<TMarker?> KIIOHBKACPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x873A0", Offset = "0x867A0")] IECPEPBGFBA<TMarker?> EMCAHJIFNIF)
	{
		return default(JNOMCIGDOCK<IECPEPBGFBA<TMarker>, BBNPKBBLCKC<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2A40", Offset = "0x2AE1C40", VA = "0x182AE2A40")]
	public static JNOMCIGDOCK<IECPEPBGFBA<TMarker?>, BBNPKBBLCKC<TMarker?>> HGFNLJEDKIL<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87400", Offset = "0x86800")] IECPEPBGFBA<TMarker?> EMCAHJIFNIF)
	{
		return default(JNOMCIGDOCK<IECPEPBGFBA<TMarker>, BBNPKBBLCKC<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PPIEAACKNOL<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24FDBF0", Offset = "0x24FCDF0", VA = "0x1824FDBF0")]
	public static IECPEPBGFBA<TOther> EFDKGKDABPA<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87460", Offset = "0x86860")] IECPEPBGFBA<TMarker> DCMHODHEGEC) where TMarker : TOther
	{
		return default(IECPEPBGFBA<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ALFBLNMKIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IJLDMGHCEDE MIIDBGBPIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NEPLGAENOOG
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2FE64D0", Offset = "0x2FE56D0", VA = "0x182FE64D0")]
	public static bool LFCEIBJMPKD<TSelf>(this TSelf DCMHODHEGEC) where TSelf : notnull, ALFBLNMKIEI
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BBNPKBBLCKC<M> : IEnumerator<IECPEPBGFBA<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly int HJJOJNAJPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int JBPBPJMBDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int MBMDHBJPFAC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x874C0", Offset = "0x868C0")]
	public readonly IECPEPBGFBA<M> HMPLADJAFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x443D920", Offset = "0x443CB20", VA = "0x18443D920", Slot = "4")]
		get
		{
			return default(IECPEPBGFBA<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x443D840", Offset = "0x443CA40", VA = "0x18443D840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x120CB10", Offset = "0x120BD10", VA = "0x18120CB10")]
	internal BBNPKBBLCKC(int MALBBOOGFAF, int EMCAHJIFNIF, int CEBADCNCLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x443D820", Offset = "0x443CA20", VA = "0x18443D820", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x443D830", Offset = "0x443CA30", VA = "0x18443D830", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NOBEDJHGOIG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0700", Offset = "0x2FEF900", VA = "0x182FF0700")]
	public static BBNPKBBLCKC<M?> NMBJFIHLDEO<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87540", Offset = "0x86940")] IECPEPBGFBA<M?> KIIOHBKACPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x875A0", Offset = "0x869A0")] IECPEPBGFBA<M?> EMCAHJIFNIF)
	{
		return default(BBNPKBBLCKC<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0680", Offset = "0x2FEF880", VA = "0x182FF0680")]
	public static JNOMCIGDOCK<IECPEPBGFBA<M?>, BBNPKBBLCKC<M?>> BKKFEIMBBBK<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87600", Offset = "0x86A00")] IECPEPBGFBA<M?> KIIOHBKACPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87660", Offset = "0x86A60")] IECPEPBGFBA<M?> EMCAHJIFNIF)
	{
		return default(JNOMCIGDOCK<IECPEPBGFBA<M>, BBNPKBBLCKC<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OGCIBCMNGGE<M> : IEnumerator<IECPEPBGFBA<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int JCBHPHBKBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int MBMDHBJPFAC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x876C0", Offset = "0x86AC0")]
	public readonly IECPEPBGFBA<M> HMPLADJAFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A640", Offset = "0x3E29840", VA = "0x183E2A640", Slot = "4")]
		get
		{
			return default(IECPEPBGFBA<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A5B0", Offset = "0x3E297B0", VA = "0x183E2A5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86FF80", Offset = "0x86F180", VA = "0x18086FF80")]
	private OGCIBCMNGGE(int IGDJHHPIJBK, int CEBADCNCLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A560", Offset = "0x3E29760", VA = "0x183E2A560")]
	public static OGCIBCMNGGE<M> HHHAMBLKAHO(int IGDJHHPIJBK)
	{
		return default(OGCIBCMNGGE<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A590", Offset = "0x3E29790", VA = "0x183E2A590", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A5A0", Offset = "0x3E297A0", VA = "0x183E2A5A0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JEMIEGJFBCA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1599400", Offset = "0x1598600", VA = "0x181599400")]
	public static JIBHFEOABOP IOEANABOGCL(this in KHHILIHMLIO DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1599160", Offset = "0x1598360", VA = "0x181599160")]
	public static KHHILIHMLIO AKLCAJOKCCK(this JIBHFEOABOP DCMHODHEGEC)
	{
		return default(KHHILIHMLIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1599220", Offset = "0x1598420", VA = "0x181599220")]
	public static JIBHFEOABOP? EPIKOGJMMAJ(this in KHHILIHMLIO? DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1599300", Offset = "0x1598500", VA = "0x181599300")]
	public static KHHILIHMLIO? INAGHDGIMJM(this JIBHFEOABOP? DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct BEJFKHGBIOB<TMarker> : IEquatable<BEJFKHGBIOB<TMarker>>, MFKMHCNJACH<BEJFKHGBIOB<TMarker>>, IComparable<BEJFKHGBIOB<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly Guid GGGPGPPLGOF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87B00", Offset = "0x86F00")]
	public static BEJFKHGBIOB<TMarker> GKMFIPLKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4447A90", Offset = "0x4446C90", VA = "0x184447A90")]
		get
		{
			return default(BEJFKHGBIOB<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87B70", Offset = "0x86F70")]
	public static BEJFKHGBIOB<TMarker>? CFLDBFNJMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4447C60", Offset = "0x4446E60", VA = "0x184447C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869960", VA = "0x18086A760")]
	public BEJFKHGBIOB(in Guid ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4447D60", Offset = "0x4446F60", VA = "0x184447D60")]
	public GOOIBEMKOFP? IOEANABOGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4447C10", Offset = "0x4446E10", VA = "0x184447C10")]
	public bool DMPMLAKNGKG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x877A0", Offset = "0x86BA0")] in BEJFKHGBIOB<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4447BC0", Offset = "0x4446DC0", VA = "0x184447BC0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87810", Offset = "0x86C10")] BEJFKHGBIOB<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A002F0", Offset = "0x29FF4F0", VA = "0x182A002F0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4447B90", Offset = "0x4446D90", VA = "0x184447B90", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87870", Offset = "0x86C70")] BEJFKHGBIOB<TMarker> HPOECFLNEOJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4447BC0", Offset = "0x4446DC0", VA = "0x184447BC0")]
	public static bool JGKKLLGINAK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x878D0", Offset = "0x86CD0")] in BEJFKHGBIOB<TMarker> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87940", Offset = "0x86D40")] in BEJFKHGBIOB<TMarker> KEJINCBACKA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4447EA0", Offset = "0x44470A0", VA = "0x184447EA0")]
	public static bool NGNNEMMJMMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x879B0", Offset = "0x86DB0")] in BEJFKHGBIOB<TMarker> NGKKOMJDENH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87A20", Offset = "0x86E20")] in BEJFKHGBIOB<TMarker> KEJINCBACKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4447C40", Offset = "0x4446E40", VA = "0x184447C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4447F00", Offset = "0x4447100", VA = "0x184447F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4447BC0", Offset = "0x4446DC0", VA = "0x184447BC0", Slot = "5")]
	private bool DHJEJKJMGBE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87A90", Offset = "0x86E90")] in BEJFKHGBIOB<TMarker> HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LINLPILJHJG
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3343F80", Offset = "0x3343180", VA = "0x183343F80")]
	public static BEJFKHGBIOB<TMarker?> AKLCAJOKCCK<TMarker>(this GOOIBEMKOFP? DCMHODHEGEC)
	{
		return default(BEJFKHGBIOB<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3344060", Offset = "0x3343260", VA = "0x183344060")]
	public static BEJFKHGBIOB<TMarker?> ANFIHEHHKAO<TMarker>(this in Guid DCMHODHEGEC)
	{
		return default(BEJFKHGBIOB<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class ANGPNOKNIPF<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87C20", Offset = "0x87020")]
	internal static readonly BEJFKHGBIOB<TOther> GKMFIPLKNAE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87C80", Offset = "0x87080")]
	internal static readonly BEJFKHGBIOB<TOther>? CFLDBFNJMIK;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct ELJJGBIJPJE<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87D50", Offset = "0x87150")]
	private readonly GDHHFAMGGMI<T> OOOADBLOEJD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87E70", Offset = "0x87270")]
	public IECPEPBGFBA<M> DNFFBAJCDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x366C330", Offset = "0x366B530", VA = "0x18366C330")]
		get
		{
			return default(IECPEPBGFBA<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x366C1C0", Offset = "0x366B3C0", VA = "0x18366C1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x366C240", Offset = "0x366B440", VA = "0x18366C240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D783F0", Offset = "0x2D775F0", VA = "0x182D783F0")]
	internal ELJJGBIJPJE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x87E10", Offset = "0x87210")] GDHHFAMGGMI<T> BGBPILICHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x35D2C60", Offset = "0x35D1E60", VA = "0x1835D2C60")]
	public IEnumerable<T> IIGMGCJMIEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x366C200", Offset = "0x366B400", VA = "0x18366C200")]
	public IEnumerator<T> KECFEFHENMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x366C3F0", Offset = "0x366B5F0", VA = "0x18366C3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FCCHNBEPECD<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x262A1C0", Offset = "0x26293C0", VA = "0x18262A1C0")]
	public static ELJJGBIJPJE<M, T> EGFIMLPAOML<T>(params T[] BGBPILICHHA) where T : notnull
	{
		return default(ELJJGBIJPJE<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FAIICELOLNE
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x15990C0", Offset = "0x15982C0", VA = "0x1815990C0")]
	public static GPMKIOCILMM IOEANABOGCL(this in BKOELCEBLFL DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1598D90", Offset = "0x1597F90", VA = "0x181598D90")]
	public static BKOELCEBLFL AKLCAJOKCCK(this GPMKIOCILMM DCMHODHEGEC)
	{
		return default(BKOELCEBLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1598E80", Offset = "0x1598080", VA = "0x181598E80")]
	public static GPMKIOCILMM? EPIKOGJMMAJ(this in BKOELCEBLFL? DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1598F70", Offset = "0x1598170", VA = "0x181598F70")]
	public static BKOELCEBLFL? INAGHDGIMJM(this GPMKIOCILMM? DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct BKOELCEBLFL : IEquatable<BKOELCEBLFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float MCHKDNFGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float DPIKPGACBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly float MKGFLBBPGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly float PFNNGBCDPAO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BKOELCEBLFL HABMLNJKAHI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BKOELCEBLFL BKIDJLFGAEI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BKOELCEBLFL AINBHOEDAOO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly BKOELCEBLFL ACMPDPBJCCK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly BKOELCEBLFL BEFKIJPJOJA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86FAF0", Offset = "0x86ECF0", VA = "0x18086FAF0")]
	public BKOELCEBLFL(float JNIPLDLJAIJ, float GEADFOLNEOP, float FNBPEOBHEKB, float ALNKHNEGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1598A70", Offset = "0x1597C70", VA = "0x181598A70")]
	public static BKOELCEBLFL NMBJFIHLDEO(float JNIPLDLJAIJ, float GEADFOLNEOP, float FNBPEOBHEKB, float ALNKHNEGNCO)
	{
		return default(BKOELCEBLFL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1208640", Offset = "0x1207840", VA = "0x181208640")]
	public static bool JGKKLLGINAK(in BKOELCEBLFL JFHIJPMPOBA, in BKOELCEBLFL LPNFMADJDAF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x15989D0", Offset = "0x1597BD0", VA = "0x1815989D0")]
	public static bool NGNNEMMJMMJ(in BKOELCEBLFL JFHIJPMPOBA, in BKOELCEBLFL LPNFMADJDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1598930", Offset = "0x1597B30", VA = "0x181598930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1598850", Offset = "0x1597A50", VA = "0x181598850", Slot = "0")]
	public override bool Equals(object BHEOHCEHIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1598A90", Offset = "0x1597C90", VA = "0x181598A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x15987B0", Offset = "0x15979B0", VA = "0x1815987B0", Slot = "4")]
	public bool Equals(BKOELCEBLFL HPOECFLNEOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct KPMDOFPDKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float CJOGHEALAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float MJJBNOEDOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly float EAEEMEDNPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly float MELKCBMLFLD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly KPMDOFPDKFC LHODLHLFJEG;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly KPMDOFPDKFC CBIJMAGGBIE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86FAF0", Offset = "0x86ECF0", VA = "0x18086FAF0")]
	public KPMDOFPDKFC(float KDPBEOJMKOF, float ABGFFDJOHDD, float NMKMEIDKGEO, float KCJELMMMDCA)
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
