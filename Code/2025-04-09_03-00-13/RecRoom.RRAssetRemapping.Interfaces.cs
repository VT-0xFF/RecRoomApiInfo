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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8104670", Offset = "0x8103A70", VA = "0x188104670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8103CF0", Offset = "0x81030F0", VA = "0x188103CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LBGKCPCFAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8103CC0", Offset = "0x81030C0", VA = "0x188103CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81040B0", Offset = "0x81034B0", VA = "0x1881040B0")]
	public FEJKALOKOAI(FEJKALOKOAI CMFKILLNPPC, [Optional] Guid LMGCOEEBLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58EF2F0", Offset = "0x58EE6F0", VA = "0x1858EF2F0")]
	public FEJKALOKOAI(LALAGECKOGA FJPDHEKILDP, PECGMKADMMG IINCJCFMNPE, [Optional] Guid LMGCOEEBLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8103B70", Offset = "0x8102F70", VA = "0x188103B70", Slot = "4")]
	public bool Equals(FEJKALOKOAI KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8103AC0", Offset = "0x8102EC0", VA = "0x188103AC0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8103C30", Offset = "0x8103030", VA = "0x188103C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8103D80", Offset = "0x8103180", VA = "0x188103D80")]
	public static bool PEOCKCCHEIN(FEJKALOKOAI KGCKEJLFPJB, FEJKALOKOAI HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8103DB0", Offset = "0x81031B0", VA = "0x188103DB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public LALAGECKOGA(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(LALAGECKOGA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(LALAGECKOGA KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8104450", Offset = "0x8103850", VA = "0x188104450", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(LALAGECKOGA KGCKEJLFPJB, LALAGECKOGA HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(LALAGECKOGA KGCKEJLFPJB, LALAGECKOGA HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81044F0", Offset = "0x81038F0", VA = "0x1881044F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public AOAHCJAKMBM(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(AOAHCJAKMBM KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(AOAHCJAKMBM KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8103120", Offset = "0x8102520", VA = "0x188103120", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(AOAHCJAKMBM KGCKEJLFPJB, AOAHCJAKMBM HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(AOAHCJAKMBM KGCKEJLFPJB, AOAHCJAKMBM HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x81031F0", Offset = "0x81025F0", VA = "0x1881031F0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public MDKOOLPNNLA(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(MDKOOLPNNLA KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(MDKOOLPNNLA KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8104560", Offset = "0x8103960", VA = "0x188104560", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(MDKOOLPNNLA KGCKEJLFPJB, MDKOOLPNNLA HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(MDKOOLPNNLA KGCKEJLFPJB, MDKOOLPNNLA HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8104600", Offset = "0x8103A00", VA = "0x188104600", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public PECGMKADMMG(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x81048A0", Offset = "0x8103CA0", VA = "0x1881048A0", Slot = "4")]
	public bool Equals(PECGMKADMMG KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8104800", Offset = "0x8103C00", VA = "0x188104800", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81048A0", Offset = "0x8103CA0", VA = "0x1881048A0")]
	public static bool PEOCKCCHEIN(PECGMKADMMG KGCKEJLFPJB, PECGMKADMMG HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x81048D0", Offset = "0x8103CD0", VA = "0x1881048D0")]
	public static bool OGMAAAEFFPP(PECGMKADMMG KGCKEJLFPJB, PECGMKADMMG HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(PECGMKADMMG KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8104900", Offset = "0x8103D00", VA = "0x188104900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public HHJMMHNPOOC(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(HHJMMHNPOOC KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(HHJMMHNPOOC KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81040D0", Offset = "0x81034D0", VA = "0x1881040D0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(HHJMMHNPOOC KGCKEJLFPJB, HHJMMHNPOOC HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(HHJMMHNPOOC KGCKEJLFPJB, HHJMMHNPOOC HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8104170", Offset = "0x8103570", VA = "0x188104170", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public IAPKGHKBDIJ(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(IAPKGHKBDIJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(IAPKGHKBDIJ KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8104340", Offset = "0x8103740", VA = "0x188104340", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(IAPKGHKBDIJ KGCKEJLFPJB, IAPKGHKBDIJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(IAPKGHKBDIJ KGCKEJLFPJB, IAPKGHKBDIJ HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x81043E0", Offset = "0x81037E0", VA = "0x1881043E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public BBKFOPKBGOL(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(BBKFOPKBGOL KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(BBKFOPKBGOL KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8103260", Offset = "0x8102660", VA = "0x188103260", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(BBKFOPKBGOL KGCKEJLFPJB, BBKFOPKBGOL HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(BBKFOPKBGOL KGCKEJLFPJB, BBKFOPKBGOL HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8103300", Offset = "0x8102700", VA = "0x188103300", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public PKEDJEKJOIK(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(PKEDJEKJOIK KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(PKEDJEKJOIK KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8104970", Offset = "0x8103D70", VA = "0x188104970", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060")]
	public static bool PEOCKCCHEIN(PKEDJEKJOIK KGCKEJLFPJB, PKEDJEKJOIK HKELKGIPNGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x81031C0", Offset = "0x81025C0", VA = "0x1881031C0")]
	public static bool OGMAAAEFFPP(PKEDJEKJOIK KGCKEJLFPJB, PKEDJEKJOIK HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8104A10", Offset = "0x8103E10", VA = "0x188104A10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8103370", Offset = "0x8102770", VA = "0x188103370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int JIPNMCJCLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4DB1710", Offset = "0x4DB0B10", VA = "0x184DB1710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x81038F0", Offset = "0x8102CF0", VA = "0x1881038F0")]
	public BLFDDICPCCB(string? DFHJBLCGCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8103A40", Offset = "0x8102E40", VA = "0x188103A40")]
	public BLFDDICPCCB(string?[] HJKDLHMCKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x81035D0", Offset = "0x81029D0", VA = "0x1881035D0")]
	private static string?[]? IPPHMHNEHOM(string?[]? HJKDLHMCKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8103800", Offset = "0x8102C00", VA = "0x188103800")]
	public string OFJFFHPLBPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8103390", Offset = "0x8102790", VA = "0x188103390", Slot = "4")]
	public bool Equals(BLFDDICPCCB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8103460", Offset = "0x8102860", VA = "0x188103460", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x81034F0", Offset = "0x81028F0", VA = "0x1881034F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8103860", Offset = "0x8102C60", VA = "0x188103860", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
	public PBNOFEILNDB(Guid KDBHLLEACIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
	public Guid BCKHHONMOOC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4928060", Offset = "0x4927460", VA = "0x184928060", Slot = "4")]
	public bool Equals(PBNOFEILNDB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4928030", Offset = "0x4927430", VA = "0x184928030", Slot = "5")]
	public int CompareTo(PBNOFEILNDB KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81046F0", Offset = "0x8103AF0", VA = "0x1881046F0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4928170", Offset = "0x4927570", VA = "0x184928170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8104790", Offset = "0x8103B90", VA = "0x188104790", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x81041E0", Offset = "0x81035E0", VA = "0x1881041E0")]
	public static string[] AJIJPKDHHFG(string? DFHJBLCGCMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8104280", Offset = "0x8103680", VA = "0x188104280")]
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
