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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E08390", Offset = "0x7E07790", VA = "0x187E08390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LIPJIIDPCCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EFGCEHNIDJN(HEFHKNJHOBF NIPDIMDKGGA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEFHKNJHOBF NHMCOOCBIHH(string NIPDIMDKGGA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HEFHKNJHOBF : IEquatable<HEFHKNJHOBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HOEDMLCMIIH INPEEKKNDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly APAOJHILPJK NKCEJPOEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid PGBNALEJMJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FMMBAOEPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E06EA0", Offset = "0x7E062A0", VA = "0x187E06EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DCKMOGIFNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E06E70", Offset = "0x7E06270", VA = "0x187E06E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E07460", Offset = "0x7E06860", VA = "0x187E07460")]
	public HEFHKNJHOBF(HEFHKNJHOBF FCGPCHMNONB, [Optional] Guid BNFNDCGCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x563AAB0", Offset = "0x5639EB0", VA = "0x18563AAB0")]
	public HEFHKNJHOBF(HOEDMLCMIIH DLBCELKPPFF, APAOJHILPJK DBFAAMDFDGP, [Optional] Guid BNFNDCGCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E06FE0", Offset = "0x7E063E0", VA = "0x187E06FE0", Slot = "4")]
	public bool Equals(HEFHKNJHOBF MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E06F30", Offset = "0x7E06330", VA = "0x187E06F30", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E070A0", Offset = "0x7E064A0", VA = "0x187E070A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E07130", Offset = "0x7E06530", VA = "0x187E07130")]
	public static bool JECEAGOPPKI(HEFHKNJHOBF BBGKOKBOEGA, HEFHKNJHOBF NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E07160", Offset = "0x7E06560", VA = "0x187E07160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HOEDMLCMIIH : IEquatable<HOEDMLCMIIH>, IComparable<HOEDMLCMIIH>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly HOEDMLCMIIH MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public HOEDMLCMIIH(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(HOEDMLCMIIH MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(HOEDMLCMIIH MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E07590", Offset = "0x7E06990", VA = "0x187E07590", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(HOEDMLCMIIH BBGKOKBOEGA, HOEDMLCMIIH NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(HOEDMLCMIIH BBGKOKBOEGA, HOEDMLCMIIH NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E07630", Offset = "0x7E06A30", VA = "0x187E07630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MBDMAMDEGNN : IEquatable<MBDMAMDEGNN>, IComparable<MBDMAMDEGNN>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly MBDMAMDEGNN MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public MBDMAMDEGNN(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(MBDMAMDEGNN MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(MBDMAMDEGNN MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E08170", Offset = "0x7E07570", VA = "0x187E08170", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(MBDMAMDEGNN BBGKOKBOEGA, MBDMAMDEGNN NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(MBDMAMDEGNN BBGKOKBOEGA, MBDMAMDEGNN NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E08210", Offset = "0x7E07610", VA = "0x187E08210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LBLHIKBBLBJ : IEquatable<LBLHIKBBLBJ>, IComparable<LBLHIKBBLBJ>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly LBLHIKBBLBJ MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public LBLHIKBBLBJ(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(LBLHIKBBLBJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(LBLHIKBBLBJ MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E07F00", Offset = "0x7E07300", VA = "0x187E07F00", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(LBLHIKBBLBJ BBGKOKBOEGA, LBLHIKBBLBJ NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(LBLHIKBBLBJ BBGKOKBOEGA, LBLHIKBBLBJ NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E07FA0", Offset = "0x7E073A0", VA = "0x187E07FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct APAOJHILPJK : IEquatable<APAOJHILPJK>, IComparable<APAOJHILPJK>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly APAOJHILPJK MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public APAOJHILPJK(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E06BF0", Offset = "0x7E05FF0", VA = "0x187E06BF0", Slot = "4")]
	public bool Equals(APAOJHILPJK MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E06C20", Offset = "0x7E06020", VA = "0x187E06C20", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E06BF0", Offset = "0x7E05FF0", VA = "0x187E06BF0")]
	public static bool JECEAGOPPKI(APAOJHILPJK BBGKOKBOEGA, APAOJHILPJK NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E06CC0", Offset = "0x7E060C0", VA = "0x187E06CC0")]
	public static bool NEBBLIKBPGD(APAOJHILPJK BBGKOKBOEGA, APAOJHILPJK NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(APAOJHILPJK MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E06CF0", Offset = "0x7E060F0", VA = "0x187E06CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public APAOJHILPJK(MHNIFPENILI LBPCIPMFHLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HMEIINLNNMC : IEquatable<HMEIINLNNMC>, IComparable<HMEIINLNNMC>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly HMEIINLNNMC MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public HMEIINLNNMC(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(HMEIINLNNMC MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(HMEIINLNNMC MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E07480", Offset = "0x7E06880", VA = "0x187E07480", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(HMEIINLNNMC BBGKOKBOEGA, HMEIINLNNMC NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(HMEIINLNNMC BBGKOKBOEGA, HMEIINLNNMC NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E07520", Offset = "0x7E06920", VA = "0x187E07520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AFEABOIFMLA : IEquatable<AFEABOIFMLA>, IComparable<AFEABOIFMLA>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly AFEABOIFMLA MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public AFEABOIFMLA(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(AFEABOIFMLA MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(AFEABOIFMLA MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E06AB0", Offset = "0x7E05EB0", VA = "0x187E06AB0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(AFEABOIFMLA BBGKOKBOEGA, AFEABOIFMLA NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(AFEABOIFMLA BBGKOKBOEGA, AFEABOIFMLA NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B80", Offset = "0x7E05F80", VA = "0x187E06B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BFMALJPIEON : IEquatable<BFMALJPIEON>, IComparable<BFMALJPIEON>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BFMALJPIEON MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public BFMALJPIEON(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(BFMALJPIEON MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(BFMALJPIEON MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E06D60", Offset = "0x7E06160", VA = "0x187E06D60", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(BFMALJPIEON BBGKOKBOEGA, BFMALJPIEON NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(BFMALJPIEON BBGKOKBOEGA, BFMALJPIEON NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E06E00", Offset = "0x7E06200", VA = "0x187E06E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LACLLNIICDF : IEquatable<LACLLNIICDF>, IComparable<LACLLNIICDF>, COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LACLLNIICDF MAEOIBKNBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public LACLLNIICDF(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(LACLLNIICDF MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(LACLLNIICDF MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E07DF0", Offset = "0x7E071F0", VA = "0x187E07DF0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520")]
	public static bool JECEAGOPPKI(LACLLNIICDF BBGKOKBOEGA, LACLLNIICDF NBNHMPFPBPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E06B50", Offset = "0x7E05F50", VA = "0x187E06B50")]
	public static bool NEBBLIKBPGD(LACLLNIICDF BBGKOKBOEGA, LACLLNIICDF NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E07E90", Offset = "0x7E07290", VA = "0x187E07E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct KKPPLOGPOPC : IEquatable<KKPPLOGPOPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? MIDPDHEFAEP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E078E0", Offset = "0x7E06CE0", VA = "0x187E078E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int FBBFJFOICJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4B12470", Offset = "0x4B11870", VA = "0x184B12470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E07C20", Offset = "0x7E07020", VA = "0x187E07C20")]
	public KKPPLOGPOPC(string? JLGFBPHJMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E07D70", Offset = "0x7E07170", VA = "0x187E07D70")]
	public KKPPLOGPOPC(string?[] AHBDDNLCLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E07960", Offset = "0x7E06D60", VA = "0x187E07960")]
	private static string?[]? PGEFOIMMNIE(string?[]? AHBDDNLCLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E07900", Offset = "0x7E06D00", VA = "0x187E07900")]
	public string OPKFDDEBDBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E076A0", Offset = "0x7E06AA0", VA = "0x187E076A0", Slot = "4")]
	public bool Equals(KKPPLOGPOPC MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E07770", Offset = "0x7E06B70", VA = "0x187E07770", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E07800", Offset = "0x7E06C00", VA = "0x187E07800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E07B90", Offset = "0x7E06F90", VA = "0x187E07B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct MHNIFPENILI : IEquatable<MHNIFPENILI>, IComparable<MHNIFPENILI>, COENILANACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
	public MHNIFPENILI(Guid BCIHOIBCNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
	public Guid CPHKICCJAMP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4813520", Offset = "0x4812920", VA = "0x184813520", Slot = "4")]
	public bool Equals(MHNIFPENILI MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4813190", Offset = "0x4812590", VA = "0x184813190", Slot = "5")]
	public int CompareTo(MHNIFPENILI MNALNBMKJLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E08280", Offset = "0x7E07680", VA = "0x187E08280", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4813500", Offset = "0x4812900", VA = "0x184813500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E08320", Offset = "0x7E07720", VA = "0x187E08320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DGEJEGPCHIG<TModern> : EGKLNLKIHID<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LMHAMOHIOIL(TModern KLAENBKEMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface COENILANACJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CPHKICCJAMP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EGKLNLKIHID<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern FLCFKDGAOCK(string KLAENBKEMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AALNDNADIPN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DGEJEGPCHIG<HOEDMLCMIIH> BDALHFGIJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DGEJEGPCHIG<HMEIINLNNMC> MGEBNMHGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DGEJEGPCHIG<LACLLNIICDF> IDFEBCMCLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DGEJEGPCHIG<APAOJHILPJK> OOMKJFHDDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DGEJEGPCHIG<LBLHIKBBLBJ> JDIBGBKBALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DGEJEGPCHIG<BFMALJPIEON> DGHDHIHMOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DGEJEGPCHIG<MBDMAMDEGNN> KDAHCOFCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DGEJEGPCHIG<AFEABOIFMLA> ELMLLFPLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LEMOJAKOIMF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] KDHPKHMDGLI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E08040", Offset = "0x7E07440", VA = "0x187E08040")]
	public static string[] MDFCLACDEOG(string? JLGFBPHJMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E08010", Offset = "0x7E07410", VA = "0x187E08010")]
	public static string? AJCACGBPNHA(string? DLBCELKPPFF)
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
