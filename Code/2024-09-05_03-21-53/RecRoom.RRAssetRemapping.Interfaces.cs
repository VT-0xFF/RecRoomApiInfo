using System;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72D8600", Offset = "0x72D7000", VA = "0x1872D8600")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FOOFKICGDAD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LKLOMDOAOHF(AHDCONECEDL DKDIADEJLHP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AHDCONECEDL ILDFGHALABA(string DKDIADEJLHP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct AHDCONECEDL : IEquatable<AHDCONECEDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PPKIGHIHCHJ MLLKMOBMADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NLPKIMNBAMP BHMJFPJBNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AOEOABBBAOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CINNAKGEJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D7130", Offset = "0x72D5B30", VA = "0x1872D7130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NGGPLMMDINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D7060", Offset = "0x72D5A60", VA = "0x1872D7060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72D7500", Offset = "0x72D5F00", VA = "0x1872D7500")]
	public AHDCONECEDL(AHDCONECEDL CNEAGLEHMIF, [Optional] Guid IHILNBAGNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E87980", Offset = "0x4E86380", VA = "0x184E87980")]
	public AHDCONECEDL(PPKIGHIHCHJ JPFIIFIHDHE, NLPKIMNBAMP IEECBMNALJK, [Optional] Guid IHILNBAGNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72D6EF0", Offset = "0x72D58F0", VA = "0x1872D6EF0", Slot = "4")]
	public bool Equals(AHDCONECEDL AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72D6FB0", Offset = "0x72D59B0", VA = "0x1872D6FB0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72D70A0", Offset = "0x72D5AA0", VA = "0x1872D70A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72D71C0", Offset = "0x72D5BC0", VA = "0x1872D71C0")]
	public static bool LBPOCMFLOBH(AHDCONECEDL JHAFNHPHBBL, AHDCONECEDL GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72D6EB0", Offset = "0x72D58B0", VA = "0x1872D6EB0")]
	public static bool CIBBJNPKHCF(AHDCONECEDL JHAFNHPHBBL, AHDCONECEDL GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72D71F0", Offset = "0x72D5BF0", VA = "0x1872D71F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PPKIGHIHCHJ : IEquatable<PPKIGHIHCHJ>, IComparable<PPKIGHIHCHJ>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly PPKIGHIHCHJ MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public PPKIGHIHCHJ(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(PPKIGHIHCHJ AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(PPKIGHIHCHJ AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72D8680", Offset = "0x72D7080", VA = "0x1872D8680", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(PPKIGHIHCHJ JHAFNHPHBBL, PPKIGHIHCHJ GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(PPKIGHIHCHJ JHAFNHPHBBL, PPKIGHIHCHJ GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72D8730", Offset = "0x72D7130", VA = "0x1872D8730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IIPKPLGIMIE : IEquatable<IIPKPLGIMIE>, IComparable<IIPKPLGIMIE>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly IIPKPLGIMIE MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public IIPKPLGIMIE(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(IIPKPLGIMIE AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(IIPKPLGIMIE AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x72D78B0", Offset = "0x72D62B0", VA = "0x1872D78B0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(IIPKPLGIMIE JHAFNHPHBBL, IIPKPLGIMIE GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(IIPKPLGIMIE JHAFNHPHBBL, IIPKPLGIMIE GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x72D7960", Offset = "0x72D6360", VA = "0x1872D7960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NBKDMALLDCE : IEquatable<NBKDMALLDCE>, IComparable<NBKDMALLDCE>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly NBKDMALLDCE MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public NBKDMALLDCE(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(NBKDMALLDCE AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(NBKDMALLDCE AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72D8360", Offset = "0x72D6D60", VA = "0x1872D8360", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(NBKDMALLDCE JHAFNHPHBBL, NBKDMALLDCE GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(NBKDMALLDCE JHAFNHPHBBL, NBKDMALLDCE GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72D8410", Offset = "0x72D6E10", VA = "0x1872D8410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NLPKIMNBAMP : IEquatable<NLPKIMNBAMP>, IComparable<NLPKIMNBAMP>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly NLPKIMNBAMP MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public NLPKIMNBAMP(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72D84B0", Offset = "0x72D6EB0", VA = "0x1872D84B0", Slot = "4")]
	public bool Equals(NLPKIMNBAMP AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72D84E0", Offset = "0x72D6EE0", VA = "0x1872D84E0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72D84B0", Offset = "0x72D6EB0", VA = "0x1872D84B0")]
	public static bool LBPOCMFLOBH(NLPKIMNBAMP JHAFNHPHBBL, NLPKIMNBAMP GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x72D8480", Offset = "0x72D6E80", VA = "0x1872D8480")]
	public static bool CIBBJNPKHCF(NLPKIMNBAMP JHAFNHPHBBL, NLPKIMNBAMP GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(NLPKIMNBAMP AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72D8590", Offset = "0x72D6F90", VA = "0x1872D8590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public NLPKIMNBAMP(EKIJHGABHCH JKJOCFNHKGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KKJPNJJJKLB : IEquatable<KKJPNJJJKLB>, IComparable<KKJPNJJJKLB>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly KKJPNJJJKLB MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public KKJPNJJJKLB(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(KKJPNJJJKLB AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(KKJPNJJJKLB AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72D7AF0", Offset = "0x72D64F0", VA = "0x1872D7AF0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(KKJPNJJJKLB JHAFNHPHBBL, KKJPNJJJKLB GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(KKJPNJJJKLB JHAFNHPHBBL, KKJPNJJJKLB GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72D7BA0", Offset = "0x72D65A0", VA = "0x1872D7BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IIEBDBDHLOD : IEquatable<IIEBDBDHLOD>, IComparable<IIEBDBDHLOD>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly IIEBDBDHLOD MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public IIEBDBDHLOD(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(IIEBDBDHLOD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(IIEBDBDHLOD AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72D7790", Offset = "0x72D6190", VA = "0x1872D7790", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(IIEBDBDHLOD JHAFNHPHBBL, IIEBDBDHLOD GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(IIEBDBDHLOD JHAFNHPHBBL, IIEBDBDHLOD GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72D7840", Offset = "0x72D6240", VA = "0x1872D7840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct IFKGKDFJHGN : IEquatable<IFKGKDFJHGN>, IComparable<IFKGKDFJHGN>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly IFKGKDFJHGN MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public IFKGKDFJHGN(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(IFKGKDFJHGN AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(IFKGKDFJHGN AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72D7670", Offset = "0x72D6070", VA = "0x1872D7670", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(IFKGKDFJHGN JHAFNHPHBBL, IFKGKDFJHGN GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(IFKGKDFJHGN JHAFNHPHBBL, IFKGKDFJHGN GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72D7720", Offset = "0x72D6120", VA = "0x1872D7720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct JGBKIPHAEBD : IEquatable<JGBKIPHAEBD>, IComparable<JGBKIPHAEBD>, NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JGBKIPHAEBD MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public JGBKIPHAEBD(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(JGBKIPHAEBD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(JGBKIPHAEBD AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72D79D0", Offset = "0x72D63D0", VA = "0x1872D79D0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530")]
	public static bool LBPOCMFLOBH(JGBKIPHAEBD JHAFNHPHBBL, JGBKIPHAEBD GONHEFIHLCK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72D7640", Offset = "0x72D6040", VA = "0x1872D7640")]
	public static bool CIBBJNPKHCF(JGBKIPHAEBD JHAFNHPHBBL, JGBKIPHAEBD GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72D7A80", Offset = "0x72D6480", VA = "0x1872D7A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct MKALFOKDGKE : IEquatable<MKALFOKDGKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? IEJEPMPLOKF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x72D80E0", Offset = "0x72D6AE0", VA = "0x1872D80E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FBIKEIDFIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41412A0", Offset = "0x413FCA0", VA = "0x1841412A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72D8190", Offset = "0x72D6B90", VA = "0x1872D8190")]
	public MKALFOKDGKE(string? IPFMLBIDEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72D82E0", Offset = "0x72D6CE0", VA = "0x1872D82E0")]
	public MKALFOKDGKE(string?[] CEGOPPNFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72D7EB0", Offset = "0x72D68B0", VA = "0x1872D7EB0")]
	private static string?[]? KOMLDGEFKFL(string?[]? CEGOPPNFBBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72D7E50", Offset = "0x72D6850", VA = "0x1872D7E50")]
	public string HGEBAIPACPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72D7CA0", Offset = "0x72D66A0", VA = "0x1872D7CA0", Slot = "4")]
	public bool Equals(MKALFOKDGKE AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72D7C10", Offset = "0x72D6610", VA = "0x1872D7C10", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72D7D70", Offset = "0x72D6770", VA = "0x1872D7D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72D8100", Offset = "0x72D6B00", VA = "0x1872D8100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EKIJHGABHCH : IEquatable<EKIJHGABHCH>, IComparable<EKIJHGABHCH>, NAOFDPDFIEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid HLIKNGLOMIK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
	public EKIJHGABHCH(Guid HLIKNGLOMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
	public Guid HHLJJMOJHKE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A530", Offset = "0x5A68F30", VA = "0x185A6A530", Slot = "4")]
	public bool Equals(EKIJHGABHCH AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A250", Offset = "0x5A68C50", VA = "0x185A6A250", Slot = "5")]
	public int CompareTo(EKIJHGABHCH AIPFCMFLDKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72D7520", Offset = "0x72D5F20", VA = "0x1872D7520", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A6A2D0", Offset = "0x5A68CD0", VA = "0x185A6A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72D75D0", Offset = "0x72D5FD0", VA = "0x1872D75D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PNKMDIEINFE<TModern> : CFMMEGFKEID<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JFFNENGAKKK(TModern GAOGBEJOECO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NAOFDPDFIEP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HHLJJMOJHKE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CFMMEGFKEID<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern AMDJNPBFKEE(string GAOGBEJOECO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BDGAMALNPBH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PNKMDIEINFE<PPKIGHIHCHJ> POCKDHCIJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PNKMDIEINFE<KKJPNJJJKLB> OPJOCOMCOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PNKMDIEINFE<JGBKIPHAEBD> CMAONIKDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PNKMDIEINFE<NLPKIMNBAMP> IFCJAGJDHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PNKMDIEINFE<NBKDMALLDCE> ANPNHIIHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PNKMDIEINFE<IFKGKDFJHGN> MKJJLHEDPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PNKMDIEINFE<IIPKPLGIMIE> GBIJPEPCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PNKMDIEINFE<IIEBDBDHLOD> MCMNOLFPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ACCNCDGGPNL
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] NBPPNINOBBP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72D6D50", Offset = "0x72D5750", VA = "0x1872D6D50")]
	public static string[] IMGNIMEBCOE(string? IPFMLBIDEBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x72D6DF0", Offset = "0x72D57F0", VA = "0x1872D6DF0")]
	public static string? JNAGHBFHHCE(string? JPFIIFIHDHE)
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
