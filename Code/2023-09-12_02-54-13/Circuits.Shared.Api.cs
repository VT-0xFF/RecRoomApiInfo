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
		[Cpp2IlInjected.Address(RVA = "0x721C930", Offset = "0x721BD30", VA = "0x18721C930")]
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
public readonly struct GLALEDCCPMM<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly T[] IIMEOCCLFJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7324E0", Offset = "0x7318E0")]
	public NAHKHOEBAGF<M> NPJNKCPHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x222F130", Offset = "0x222E530", VA = "0x18222F130")]
		get
		{
			return default(NAHKHOEBAGF<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15D75C0", Offset = "0x15D69C0", VA = "0x1815D75C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x15D7500", Offset = "0x15D6900", VA = "0x1815D7500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
	internal GLALEDCCPMM(T[] EACKPMFPNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x222F240", Offset = "0x222E640", VA = "0x18222F240")]
	public static GLALEDCCPMM<M, T> NAILOIKCJEC(int HBBGBOONHJE)
	{
		return default(GLALEDCCPMM<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
	public IEnumerable<T> AFGJJMJHIMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x222F2D0", Offset = "0x222E6D0", VA = "0x18222F2D0")]
	public FKHDGLBMILJ<M, T> OIFMCDHBJLK()
	{
		return default(FKHDGLBMILJ<M, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x222F1C0", Offset = "0x222E5C0", VA = "0x18222F1C0")]
	public IEnumerator<T> MHIEAIINAGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x222F340", Offset = "0x222E740", VA = "0x18222F340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PMFPJECJFLK<M>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1BD35E0", Offset = "0x1BD29E0", VA = "0x181BD35E0")]
	public static GLALEDCCPMM<M, T> JIEMPMNKCHE<T>(params T[] EACKPMFPNLH) where T : notnull
	{
		return default(GLALEDCCPMM<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DKNPGGOLLLB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x15D7580", Offset = "0x15D6980", VA = "0x1815D7580")]
	public static T? CKGLFOOKOMF<T, M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732580", Offset = "0x731980")] this ref GLALEDCCPMM<M?, T?> ODBHDBFBMOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7325E0", Offset = "0x7319E0")] NAHKHOEBAGF<M?> APEMPONKPBB)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x243B620", Offset = "0x243AA20", VA = "0x18243B620")]
	public static void AFLFAPDAOKF<M, T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732640", Offset = "0x731A40")] this ref GLALEDCCPMM<M?, T?> ODBHDBFBMOB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7326A0", Offset = "0x731AA0")] NAHKHOEBAGF<M?> APEMPONKPBB, in T AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MAFGOACLAGL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KAOOFFDEJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct COJODKLKBHB : IEquatable<COJODKLKBHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float OMHGFBADNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float PBABEPCOAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly float DCPGINMIOJA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly COJODKLKBHB ABNHDHBEEDH;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly COJODKLKBHB IKIPHIKNHLN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly COJODKLKBHB OPIMPFGPALJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly COJODKLKBHB OPAAPJIPPEN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly COJODKLKBHB KAKHPDOJLLD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly COJODKLKBHB BJGFJHDCKAB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly COJODKLKBHB LGAMJGLIKIO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly COJODKLKBHB OFFDPIACPFG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly COJODKLKBHB FJGOKDMEFMI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly COJODKLKBHB DHBAIBMHDGP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly COJODKLKBHB CHFLMBNPJDL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly COJODKLKBHB INJBPPJKNLF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly COJODKLKBHB FCICENHDDIL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly COJODKLKBHB LCECEDDKPFG;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly COJODKLKBHB GMNHMGOKOEO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly COJODKLKBHB LGGHKJOPGFN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly COJODKLKBHB MMMKKGKKPJH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x474F980", Offset = "0x474ED80", VA = "0x18474F980")]
	public COJODKLKBHB(float EOMIKPKMCAG, float PPNFDCNFKFC, float FHOGPNNDAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x721B740", Offset = "0x721AB40", VA = "0x18721B740")]
	public static COJODKLKBHB NAILOIKCJEC(float EOMIKPKMCAG, float PPNFDCNFKFC, float FHOGPNNDAKE)
	{
		return default(COJODKLKBHB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x721B760", Offset = "0x721AB60", VA = "0x18721B760")]
	public static bool PHJEMBLBEDF(in COJODKLKBHB CAOIKBDHEDK, in COJODKLKBHB ELHFHDBGEMK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x721B4D0", Offset = "0x721A8D0", VA = "0x18721B4D0")]
	public static bool AHGPMPLECPJ(in COJODKLKBHB CAOIKBDHEDK, in COJODKLKBHB ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x721B6D0", Offset = "0x721AAD0", VA = "0x18721B6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x721B560", Offset = "0x721A960", VA = "0x18721B560", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x721B790", Offset = "0x721AB90", VA = "0x18721B790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x721B640", Offset = "0x721AA40", VA = "0x18721B640", Slot = "4")]
	public bool Equals(COJODKLKBHB ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HFOJPNLDEBJ : IEquatable<HFOJPNLDEBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly MLIFGPEKEEI IABPMALGHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly COJODKLKBHB GHELJMFBFBJ;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HFOJPNLDEBJ ELKAPPPGOAG;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x721BF60", Offset = "0x721B360", VA = "0x18721BF60")]
	public HFOJPNLDEBJ(in MLIFGPEKEEI OCEJJKMFIJB, in COJODKLKBHB FGLOAKJBDBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x721BD00", Offset = "0x721B100", VA = "0x18721BD00")]
	public static bool PHJEMBLBEDF(in HFOJPNLDEBJ CAOIKBDHEDK, in HFOJPNLDEBJ ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x721BC70", Offset = "0x721B070", VA = "0x18721BC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x721BB30", Offset = "0x721AF30", VA = "0x18721BB30", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x721BDF0", Offset = "0x721B1F0", VA = "0x18721BDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x721BC00", Offset = "0x721B000", VA = "0x18721BC00", Slot = "4")]
	public bool Equals(HFOJPNLDEBJ ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NAHKHOEBAGF<TMarker> : IEquatable<NAHKHOEBAGF<TMarker>>, GMDIBMAAGEJ<NAHKHOEBAGF<TMarker>>, IComparable<NAHKHOEBAGF<TMarker>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly int CIKCGNBKBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732A50", Offset = "0x731E50")]
	public NAHKHOEBAGF<TMarker> BFFIOPALDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1D40460", Offset = "0x1D3F860", VA = "0x181D40460")]
		get
		{
			return default(NAHKHOEBAGF<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732AB0", Offset = "0x731EB0")]
	public NAHKHOEBAGF<TMarker> ODCAADABHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1D40380", Offset = "0x1D3F780", VA = "0x181D40380")]
		get
		{
			return default(NAHKHOEBAGF<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	public NAHKHOEBAGF(int AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1BC41B0", Offset = "0x1BC35B0", VA = "0x181BC41B0")]
	public NAHKHOEBAGF<TOther> HHALGPEGJHJ<TOther>() where TOther : TMarker
	{
		return default(NAHKHOEBAGF<TOther>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
	public int CJMDONJKOCN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D405A0", Offset = "0x1D3F9A0", VA = "0x181D405A0")]
	public bool FCBBFOADOJJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732730", Offset = "0x731B30")] in NAHKHOEBAGF<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D404D0", Offset = "0x1D3F8D0", VA = "0x181D404D0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7327A0", Offset = "0x731BA0")] NAHKHOEBAGF<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D40520", Offset = "0x1D3F920", VA = "0x181D40520", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D40440", Offset = "0x1D3F840", VA = "0x181D40440", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732800", Offset = "0x731C00")] NAHKHOEBAGF<TMarker> ICELKIGIKKP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D405E0", Offset = "0x1D3F9E0", VA = "0x181D405E0")]
	public static bool PHJEMBLBEDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732860", Offset = "0x731C60")] NAHKHOEBAGF<TMarker> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7328C0", Offset = "0x731CC0")] NAHKHOEBAGF<TMarker> JHJGODIMNAF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D40330", Offset = "0x1D3F730", VA = "0x181D40330")]
	public static bool AHGPMPLECPJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732920", Offset = "0x731D20")] NAHKHOEBAGF<TMarker> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732980", Offset = "0x731D80")] NAHKHOEBAGF<TMarker> JHJGODIMNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D405C0", Offset = "0x1D3F9C0", VA = "0x181D405C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D40620", Offset = "0x1D3FA20", VA = "0x181D40620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1D403F0", Offset = "0x1D3F7F0", VA = "0x181D403F0", Slot = "5")]
	private bool CBMAFOBFFNE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7329E0", Offset = "0x731DE0")] in NAHKHOEBAGF<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FNJOMHEDKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x17B42D0", Offset = "0x17B36D0", VA = "0x1817B42D0")]
	public static NAHKHOEBAGF<TMarker?> DKEBIOEAJGF<TMarker>(this int ODBHDBFBMOB)
	{
		return default(NAHKHOEBAGF<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x17B42D0", Offset = "0x17B36D0", VA = "0x1817B42D0")]
	public static NAHKHOEBAGF<TMarker?> NFMCGHNEBNB<TMarker>(this int ODBHDBFBMOB)
	{
		return default(NAHKHOEBAGF<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x17B4300", Offset = "0x17B3700", VA = "0x1817B4300")]
	public static DJGIMJFLEPO<NAHKHOEBAGF<TMarker?>, OGHHFGFDBMK<TMarker?>> HPEEGFAJEAH<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732B50", Offset = "0x731F50")] NAHKHOEBAGF<TMarker?> LMNLPJJHHIN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732BB0", Offset = "0x731FB0")] NAHKHOEBAGF<TMarker?> CHMOIONFEOA)
	{
		return default(DJGIMJFLEPO<NAHKHOEBAGF<TMarker>, OGHHFGFDBMK<TMarker>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x17B4340", Offset = "0x17B3740", VA = "0x1817B4340")]
	public static DJGIMJFLEPO<NAHKHOEBAGF<TMarker?>, OGHHFGFDBMK<TMarker?>> KCACPDBKOPN<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732C10", Offset = "0x732010")] NAHKHOEBAGF<TMarker?> CHMOIONFEOA)
	{
		return default(DJGIMJFLEPO<NAHKHOEBAGF<TMarker>, OGHHFGFDBMK<TMarker>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BNPJKHDMCCE<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2149C80", Offset = "0x2149080", VA = "0x182149C80")]
	public static NAHKHOEBAGF<TOther> IAPFJFBNJCB<TMarker>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732C70", Offset = "0x732070")] NAHKHOEBAGF<TMarker> ODBHDBFBMOB) where TMarker : TOther
	{
		return default(NAHKHOEBAGF<TOther>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDLFPPODDLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MAFGOACLAGL DHNJCPHKMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FABDAFHHDLE
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x17A4FE0", Offset = "0x17A43E0", VA = "0x1817A4FE0")]
	public static bool LKIIHOOJDEL<TSelf>(this TSelf ODBHDBFBMOB) where TSelf : notnull, HDLFPPODDLJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OGHHFGFDBMK<M> : IEnumerator<NAHKHOEBAGF<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int MABHIJJDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int GICGHDKJHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FANFGPKCDKL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732CD0", Offset = "0x7320D0")]
	public readonly NAHKHOEBAGF<M> AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x23DA120", Offset = "0x23D9520", VA = "0x1823DA120", Slot = "4")]
		get
		{
			return default(NAHKHOEBAGF<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x23DA040", Offset = "0x23D9440", VA = "0x1823DA040", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xB91F00", Offset = "0xB91300", VA = "0x180B91F00")]
	internal OGHHFGFDBMK(int PEBGFKAAJIH, int CHMOIONFEOA, int NGOMFIMAAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public readonly void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x23DA020", Offset = "0x23D9420", VA = "0x1823DA020", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x23DA030", Offset = "0x23D9430", VA = "0x1823DA030", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NDJFNFOCFDN
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2401ED0", Offset = "0x24012D0", VA = "0x182401ED0")]
	public static OGHHFGFDBMK<M?> NAILOIKCJEC<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732D90", Offset = "0x732190")] NAHKHOEBAGF<M?> LMNLPJJHHIN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732DF0", Offset = "0x7321F0")] NAHKHOEBAGF<M?> CHMOIONFEOA)
	{
		return default(OGHHFGFDBMK<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2401E50", Offset = "0x2401250", VA = "0x182401E50")]
	public static DJGIMJFLEPO<NAHKHOEBAGF<M?>, OGHHFGFDBMK<M?>> LGLCGHBLNBG<M>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732E50", Offset = "0x732250")] NAHKHOEBAGF<M?> LMNLPJJHHIN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732EB0", Offset = "0x7322B0")] NAHKHOEBAGF<M?> CHMOIONFEOA)
	{
		return default(DJGIMJFLEPO<NAHKHOEBAGF<M>, OGHHFGFDBMK<M>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PJLNOGIIJLG<M> : IEnumerator<NAHKHOEBAGF<M>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly int AFAJDIPMOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int FANFGPKCDKL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732F10", Offset = "0x732310")]
	public readonly NAHKHOEBAGF<M> AOPJILKHAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFE60", Offset = "0x3CFF260", VA = "0x183CFFE60", Slot = "4")]
		get
		{
			return default(NAHKHOEBAGF<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFDD0", Offset = "0x3CFF1D0", VA = "0x183CFFDD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	private PJLNOGIIJLG(int FJFMKNIHPDJ, int NGOMFIMAAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFD80", Offset = "0x3CFF180", VA = "0x183CFFD80")]
	public static PJLNOGIIJLG<M> FAJMEDMHCBK(int FJFMKNIHPDJ)
	{
		return default(PJLNOGIIJLG<M>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFDB0", Offset = "0x3CFF1B0", VA = "0x183CFFDB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CFFDC0", Offset = "0x3CFF1C0", VA = "0x183CFFDC0", Slot = "8")]
	public void Reset()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ACBFMAOPNEG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x721B280", Offset = "0x721A680", VA = "0x18721B280")]
	public static HPMOMKOOBHC CJMDONJKOCN(this in COJODKLKBHB ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x721B310", Offset = "0x721A710", VA = "0x18721B310")]
	public static COJODKLKBHB EFFJDOFDOEN(this HPMOMKOOBHC ODBHDBFBMOB)
	{
		return default(COJODKLKBHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x721B1A0", Offset = "0x721A5A0", VA = "0x18721B1A0")]
	public static HPMOMKOOBHC? BPCMLDPGAFG(this in COJODKLKBHB? ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x721B3D0", Offset = "0x721A7D0", VA = "0x18721B3D0")]
	public static COJODKLKBHB? HCFADFOBMLN(this HPMOMKOOBHC? ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct JDIHKGFCOHC<TMarker> : IEquatable<JDIHKGFCOHC<TMarker>>, GMDIBMAAGEJ<JDIHKGFCOHC<TMarker>>, IComparable<JDIHKGFCOHC<TMarker>> where TMarker : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Guid OAJALJJKEAP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733350", Offset = "0x732750")]
	public static JDIHKGFCOHC<TMarker> AOKDNNAFLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x22C5AE0", Offset = "0x22C4EE0", VA = "0x1822C5AE0")]
		get
		{
			return default(JDIHKGFCOHC<TMarker>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7333C0", Offset = "0x7327C0")]
	public static JDIHKGFCOHC<TMarker>? BIKIIJCJCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x22C5C90", Offset = "0x22C5090", VA = "0x1822C5C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x20CE640", Offset = "0x20CDA40", VA = "0x1820CE640")]
	public JDIHKGFCOHC(in Guid AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x22C59A0", Offset = "0x22C4DA0", VA = "0x1822C59A0")]
	public FMPMJEKLNHB? CJMDONJKOCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x22C5C60", Offset = "0x22C5060", VA = "0x1822C5C60")]
	public bool FCBBFOADOJJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x732FF0", Offset = "0x7323F0")] in JDIHKGFCOHC<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x22C5C10", Offset = "0x22C5010", VA = "0x1822C5C10", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733060", Offset = "0x732460")] JDIHKGFCOHC<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1D40520", Offset = "0x1D3F920", VA = "0x181D40520", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22C5BE0", Offset = "0x22C4FE0", VA = "0x1822C5BE0", Slot = "6")]
	public int CompareTo([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7330C0", Offset = "0x7324C0")] JDIHKGFCOHC<TMarker> ICELKIGIKKP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x22C5C10", Offset = "0x22C5010", VA = "0x1822C5C10")]
	public static bool PHJEMBLBEDF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733120", Offset = "0x732520")] in JDIHKGFCOHC<TMarker> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733190", Offset = "0x732590")] in JDIHKGFCOHC<TMarker> JHJGODIMNAF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x22C5940", Offset = "0x22C4D40", VA = "0x1822C5940")]
	public static bool AHGPMPLECPJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733200", Offset = "0x732600")] in JDIHKGFCOHC<TMarker> FINJCDHFPJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733270", Offset = "0x732670")] in JDIHKGFCOHC<TMarker> JHJGODIMNAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x22C5D90", Offset = "0x22C5190", VA = "0x1822C5D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x22C5DB0", Offset = "0x22C51B0", VA = "0x1822C5DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x22C5C10", Offset = "0x22C5010", VA = "0x1822C5C10", Slot = "5")]
	private bool IDIKHPDCMHH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7332E0", Offset = "0x7326E0")] in JDIHKGFCOHC<TMarker> ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GBFFDEMGMKF
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x16D4EC0", Offset = "0x16D42C0", VA = "0x1816D4EC0")]
	public static JDIHKGFCOHC<TMarker?> EFFJDOFDOEN<TMarker>(this FMPMJEKLNHB? ODBHDBFBMOB)
	{
		return default(JDIHKGFCOHC<TMarker>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x16D4E90", Offset = "0x16D4290", VA = "0x1816D4E90")]
	public static JDIHKGFCOHC<TMarker?> DKEBIOEAJGF<TMarker>(this in Guid ODBHDBFBMOB)
	{
		return default(JDIHKGFCOHC<TMarker>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AGLLCFHCGMN<TOther>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733470", Offset = "0x732870")]
	internal static readonly JDIHKGFCOHC<TOther> AOKDNNAFLGL;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7334D0", Offset = "0x7328D0")]
	internal static readonly JDIHKGFCOHC<TOther>? BIKIIJCJCFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public readonly struct FKHDGLBMILJ<M, T> where M : notnull where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7335A0", Offset = "0x7329A0")]
	private readonly IFCCPDFCEMF<T> IIMEOCCLFJA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7336C0", Offset = "0x732AC0")]
	public NAHKHOEBAGF<M> NPJNKCPHLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x380B550", Offset = "0x380A950", VA = "0x18380B550")]
		get
		{
			return default(NAHKHOEBAGF<M>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x380B750", Offset = "0x380AB50", VA = "0x18380B750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x380B610", Offset = "0x380AA10", VA = "0x18380B610")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7980", Offset = "0x1FE6D80", VA = "0x181FE7980")]
	internal FKHDGLBMILJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x733660", Offset = "0x732A60")] IFCCPDFCEMF<T> EACKPMFPNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x207B9F0", Offset = "0x207ADF0", VA = "0x18207B9F0")]
	public IEnumerable<T> AFGJJMJHIMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x380B790", Offset = "0x380AB90", VA = "0x18380B790")]
	public IEnumerator<T> MHIEAIINAGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x380B7D0", Offset = "0x380ABD0", VA = "0x18380B7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IIDGKEENKFF<M>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x201E080", Offset = "0x201D480", VA = "0x18201E080")]
	public static FKHDGLBMILJ<M, T> JIEMPMNKCHE<T>(params T[] EACKPMFPNLH) where T : notnull
	{
		return default(FKHDGLBMILJ<M, T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IPOEFCBEING
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x721C070", Offset = "0x721B470", VA = "0x18721C070")]
	public static JEJDEOGPLME CJMDONJKOCN(this in MLIFGPEKEEI ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x721C110", Offset = "0x721B510", VA = "0x18721C110")]
	public static MLIFGPEKEEI EFFJDOFDOEN(this JEJDEOGPLME ODBHDBFBMOB)
	{
		return default(MLIFGPEKEEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x721BF80", Offset = "0x721B380", VA = "0x18721BF80")]
	public static JEJDEOGPLME? BPCMLDPGAFG(this in MLIFGPEKEEI? ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x721C200", Offset = "0x721B600", VA = "0x18721C200")]
	public static MLIFGPEKEEI? HCFADFOBMLN(this JEJDEOGPLME? ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct MLIFGPEKEEI : IEquatable<MLIFGPEKEEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly float OMHGFBADNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly float PBABEPCOAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly float DCPGINMIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly float KPGPDHDCFPN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MLIFGPEKEEI ELKAPPPGOAG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MLIFGPEKEEI OPIMPFGPALJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MLIFGPEKEEI OPAAPJIPPEN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MLIFGPEKEEI KAKHPDOJLLD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MLIFGPEKEEI BJGFJHDCKAB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20D3980", Offset = "0x20D2D80", VA = "0x1820D3980")]
	public MLIFGPEKEEI(float EOMIKPKMCAG, float PPNFDCNFKFC, float FHOGPNNDAKE, float OPBCFGIPEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x721C610", Offset = "0x721BA10", VA = "0x18721C610")]
	public static MLIFGPEKEEI NAILOIKCJEC(float EOMIKPKMCAG, float PPNFDCNFKFC, float FHOGPNNDAKE, float OPBCFGIPEAC)
	{
		return default(MLIFGPEKEEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6009CE0", Offset = "0x60090E0", VA = "0x186009CE0")]
	public static bool PHJEMBLBEDF(in MLIFGPEKEEI CAOIKBDHEDK, in MLIFGPEKEEI ELHFHDBGEMK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x721C350", Offset = "0x721B750", VA = "0x18721C350")]
	public static bool AHGPMPLECPJ(in MLIFGPEKEEI CAOIKBDHEDK, in MLIFGPEKEEI ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x721C570", Offset = "0x721B970", VA = "0x18721C570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x721C490", Offset = "0x721B890", VA = "0x18721C490", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x721C630", Offset = "0x721BA30", VA = "0x18721C630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x721C3F0", Offset = "0x721B7F0", VA = "0x18721C3F0", Slot = "4")]
	public bool Equals(MLIFGPEKEEI ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FNMJKOMNCDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly float OJLPGGHDJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly float KDGMNFIMHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly float BBAJJCCJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly float NMODNMCADII;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly FNMJKOMNCDE DGGGNGFJCKD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly FNMJKOMNCDE FAIPHPEHNLE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20D3980", Offset = "0x20D2D80", VA = "0x1820D3980")]
	public FNMJKOMNCDE(float OEMJPJIELLC, float HIFDOICJFLH, float KBAEKPMBMFG, float NPBBJPKPNCJ)
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
