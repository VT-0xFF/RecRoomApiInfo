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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x80B91A0", Offset = "0x80B85A0", VA = "0x1880B91A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FNKIDNDFNMM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PELCBGJOJPC(FEJKALOKOAI PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEJKALOKOAI HFAEDKNMEEN(string PJCOHHCODGF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct FEJKALOKOAI : IEquatable<FEJKALOKOAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LALAGECKOGA NJALIPJPANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PECGMKADMMG HKHBOFNLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid IHOCAHKEPON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PPFFJFFMANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80B8810", Offset = "0x80B7C10", VA = "0x1880B8810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBGKCPCFAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80B87E0", Offset = "0x80B7BE0", VA = "0x1880B87E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80B8BD0", Offset = "0x80B7FD0", VA = "0x1880B8BD0")]
	public FEJKALOKOAI(FEJKALOKOAI CMFKILLNPPC, [Optional] Guid LMGCOEEBLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58A9B80", Offset = "0x58A8F80", VA = "0x1858A9B80")]
	public FEJKALOKOAI(LALAGECKOGA FJPDHEKILDP, PECGMKADMMG IINCJCFMNPE, [Optional] Guid LMGCOEEBLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8690", Offset = "0x80B7A90", VA = "0x1880B8690", Slot = "4")]
	public bool Equals(FEJKALOKOAI KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80B85E0", Offset = "0x80B79E0", VA = "0x1880B85E0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80B8750", Offset = "0x80B7B50", VA = "0x1880B8750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x80B88A0", Offset = "0x80B7CA0", VA = "0x1880B88A0")]
	public static bool PEOCKCCHEIN(FEJKALOKOAI KGCKEJLFPJB, FEJKALOKOAI HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x80B88D0", Offset = "0x80B7CD0", VA = "0x1880B88D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LALAGECKOGA : IEquatable<LALAGECKOGA>, IComparable<LALAGECKOGA>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly LALAGECKOGA GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public LALAGECKOGA(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(LALAGECKOGA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(LALAGECKOGA KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x80B8F80", Offset = "0x80B8380", VA = "0x1880B8F80", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(LALAGECKOGA KGCKEJLFPJB, LALAGECKOGA HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(LALAGECKOGA KGCKEJLFPJB, LALAGECKOGA HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x80B9020", Offset = "0x80B8420", VA = "0x1880B9020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AOAHCJAKMBM : IEquatable<AOAHCJAKMBM>, IComparable<AOAHCJAKMBM>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly AOAHCJAKMBM GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public AOAHCJAKMBM(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(AOAHCJAKMBM KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(AOAHCJAKMBM KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80B7C40", Offset = "0x80B7040", VA = "0x1880B7C40", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(AOAHCJAKMBM KGCKEJLFPJB, AOAHCJAKMBM HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(AOAHCJAKMBM KGCKEJLFPJB, AOAHCJAKMBM HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x80B7D10", Offset = "0x80B7110", VA = "0x1880B7D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MDKOOLPNNLA : IEquatable<MDKOOLPNNLA>, IComparable<MDKOOLPNNLA>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly MDKOOLPNNLA GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public MDKOOLPNNLA(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(MDKOOLPNNLA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(MDKOOLPNNLA KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x80B9090", Offset = "0x80B8490", VA = "0x1880B9090", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(MDKOOLPNNLA KGCKEJLFPJB, MDKOOLPNNLA HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(MDKOOLPNNLA KGCKEJLFPJB, MDKOOLPNNLA HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80B9130", Offset = "0x80B8530", VA = "0x1880B9130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PECGMKADMMG : IEquatable<PECGMKADMMG>, IComparable<PECGMKADMMG>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly PECGMKADMMG GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public PECGMKADMMG(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80B93D0", Offset = "0x80B87D0", VA = "0x1880B93D0", Slot = "4")]
	public bool Equals(PECGMKADMMG KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80B9330", Offset = "0x80B8730", VA = "0x1880B9330", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80B93D0", Offset = "0x80B87D0", VA = "0x1880B93D0")]
	public static bool PEOCKCCHEIN(PECGMKADMMG KGCKEJLFPJB, PECGMKADMMG HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80B9400", Offset = "0x80B8800", VA = "0x1880B9400")]
	public static bool OGMAAAEFFPP(PECGMKADMMG KGCKEJLFPJB, PECGMKADMMG HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(PECGMKADMMG KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x80B9430", Offset = "0x80B8830", VA = "0x1880B9430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public PECGMKADMMG(PBNOFEILNDB MHANHDANDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HHJMMHNPOOC : IEquatable<HHJMMHNPOOC>, IComparable<HHJMMHNPOOC>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly HHJMMHNPOOC GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public HHJMMHNPOOC(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(HHJMMHNPOOC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(HHJMMHNPOOC KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80B8BF0", Offset = "0x80B7FF0", VA = "0x1880B8BF0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(HHJMMHNPOOC KGCKEJLFPJB, HHJMMHNPOOC HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(HHJMMHNPOOC KGCKEJLFPJB, HHJMMHNPOOC HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80B8C90", Offset = "0x80B8090", VA = "0x1880B8C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IAPKGHKBDIJ : IEquatable<IAPKGHKBDIJ>, IComparable<IAPKGHKBDIJ>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly IAPKGHKBDIJ GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public IAPKGHKBDIJ(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(IAPKGHKBDIJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(IAPKGHKBDIJ KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80B8E70", Offset = "0x80B8270", VA = "0x1880B8E70", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(IAPKGHKBDIJ KGCKEJLFPJB, IAPKGHKBDIJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(IAPKGHKBDIJ KGCKEJLFPJB, IAPKGHKBDIJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80B8F10", Offset = "0x80B8310", VA = "0x1880B8F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BBKFOPKBGOL : IEquatable<BBKFOPKBGOL>, IComparable<BBKFOPKBGOL>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BBKFOPKBGOL GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public BBKFOPKBGOL(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(BBKFOPKBGOL KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(BBKFOPKBGOL KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80B7D80", Offset = "0x80B7180", VA = "0x1880B7D80", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(BBKFOPKBGOL KGCKEJLFPJB, BBKFOPKBGOL HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(BBKFOPKBGOL KGCKEJLFPJB, BBKFOPKBGOL HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80B7E20", Offset = "0x80B7220", VA = "0x1880B7E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PKEDJEKJOIK : IEquatable<PKEDJEKJOIK>, IComparable<PKEDJEKJOIK>, OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PKEDJEKJOIK GBADJOAJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public PKEDJEKJOIK(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(PKEDJEKJOIK KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(PKEDJEKJOIK KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x80B94A0", Offset = "0x80B88A0", VA = "0x1880B94A0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950")]
	public static bool PEOCKCCHEIN(PKEDJEKJOIK KGCKEJLFPJB, PKEDJEKJOIK HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80B7CE0", Offset = "0x80B70E0", VA = "0x1880B7CE0")]
	public static bool OGMAAAEFFPP(PKEDJEKJOIK KGCKEJLFPJB, PKEDJEKJOIK HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80B9540", Offset = "0x80B8940", VA = "0x1880B9540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BLFDDICPCCB : IEquatable<BLFDDICPCCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? GMEKBBEDNPO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80B7E90", Offset = "0x80B7290", VA = "0x1880B7E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int JIPNMCJCLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB1280", Offset = "0x4DB0680", VA = "0x184DB1280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80B8410", Offset = "0x80B7810", VA = "0x1880B8410")]
	public BLFDDICPCCB(string? DFHJBLCGCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80B8560", Offset = "0x80B7960", VA = "0x1880B8560")]
	public BLFDDICPCCB(string?[] HJKDLHMCKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80B80F0", Offset = "0x80B74F0", VA = "0x1880B80F0")]
	private static string?[]? IPPHMHNEHOM(string?[]? HJKDLHMCKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80B8320", Offset = "0x80B7720", VA = "0x1880B8320")]
	public string OFJFFHPLBPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80B7EB0", Offset = "0x80B72B0", VA = "0x1880B7EB0", Slot = "4")]
	public bool Equals(BLFDDICPCCB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80B7F80", Offset = "0x80B7380", VA = "0x1880B7F80", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x80B8010", Offset = "0x80B7410", VA = "0x1880B8010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x80B8380", Offset = "0x80B7780", VA = "0x1880B8380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PBNOFEILNDB : IEquatable<PBNOFEILNDB>, IComparable<PBNOFEILNDB>, OOBOEDGJKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid KDBHLLEACIN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
	public PBNOFEILNDB(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x490F950", Offset = "0x490ED50", VA = "0x18490F950", Slot = "4")]
	public bool Equals(PBNOFEILNDB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x490F920", Offset = "0x490ED20", VA = "0x18490F920", Slot = "5")]
	public int CompareTo(PBNOFEILNDB KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x80B9220", Offset = "0x80B8620", VA = "0x1880B9220", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x490FA60", Offset = "0x490EE60", VA = "0x18490FA60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80B92C0", Offset = "0x80B86C0", VA = "0x1880B92C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CHOCLPPHKEE<TModern> : IMDHMAINHLG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ELFKGOBGGMD(TModern FEHKMADEKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OOBOEDGJKIN
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BCKHHONMOOC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IMDHMAINHLG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern AHLBDDIHAJI(string FEHKMADEKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IKKNLBGAIJE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CHOCLPPHKEE<LALAGECKOGA> EKPHPKKEOED
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CHOCLPPHKEE<HHJMMHNPOOC> CMJIIHMHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CHOCLPPHKEE<PKEDJEKJOIK> LDMBFFJFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CHOCLPPHKEE<PECGMKADMMG> JAAAIEDMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CHOCLPPHKEE<MDKOOLPNNLA> OLHEHPEENIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CHOCLPPHKEE<BBKFOPKBGOL> EPLPMJMFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CHOCLPPHKEE<AOAHCJAKMBM> COKGNPANNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CHOCLPPHKEE<IAPKGHKBDIJ> EEMKDHJIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HPJFOLKOCOC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] AMNNKJHKGGH;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x80B8D00", Offset = "0x80B8100", VA = "0x1880B8D00")]
	public static string[] AJIJPKDHHFG(string? DFHJBLCGCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x80B8DA0", Offset = "0x80B81A0", VA = "0x1880B8DA0")]
	public static string? MALJPOBIALJ(string? FJPDHEKILDP)
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
