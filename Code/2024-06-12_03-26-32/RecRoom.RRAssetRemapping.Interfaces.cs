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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FD8E00", Offset = "0x6FD7A00", VA = "0x186FD8E00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FKICEGABKJK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PLFEAILJDFE(BBAGBHNBMOO HJNPKADFMMO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BBAGBHNBMOO EGCBEAACMHC(string HJNPKADFMMO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BBAGBHNBMOO : IEquatable<BBAGBHNBMOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LKFMAAICKAG NCHNKCDADEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KAECHKCDNJH LKAINKMPDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid LLLHNLOHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? CGJFFEKAJPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LMKHBGFFLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FD71B0", Offset = "0x6FD5DB0", VA = "0x186FD71B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IEPGDGDNCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7320", Offset = "0x6FD5F20", VA = "0x186FD7320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7780", Offset = "0x6FD6380", VA = "0x186FD7780")]
	public BBAGBHNBMOO(BBAGBHNBMOO NALCGJOFNNO, [Optional] Guid HKHHGEIPJJM, [Optional] RRColor? BFOBNFFGJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7810", Offset = "0x6FD6410", VA = "0x186FD7810")]
	public BBAGBHNBMOO(LKFMAAICKAG BGKJFLNJDKH, KAECHKCDNJH AHIAGANHOGC, [Optional] Guid HKHHGEIPJJM, [Optional] RRColor? BFOBNFFGJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6F40", Offset = "0x6FD5B40", VA = "0x186FD6F40", Slot = "4")]
	public bool Equals(BBAGBHNBMOO OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6FF0", Offset = "0x6FD5BF0", VA = "0x186FD6FF0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7120", Offset = "0x6FD5D20", VA = "0x186FD7120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6F40", Offset = "0x6FD5B40", VA = "0x186FD6F40")]
	public static bool NBAHCGFACIA(BBAGBHNBMOO HOGIDEMINCM, BBAGBHNBMOO FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7270", Offset = "0x6FD5E70", VA = "0x186FD7270")]
	public static bool OONFJEHFBJE(BBAGBHNBMOO HOGIDEMINCM, BBAGBHNBMOO FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7360", Offset = "0x6FD5F60", VA = "0x186FD7360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LKFMAAICKAG : IEquatable<LKFMAAICKAG>, IComparable<LKFMAAICKAG>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly LKFMAAICKAG BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public LKFMAAICKAG(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(LKFMAAICKAG OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(LKFMAAICKAG OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8BC0", Offset = "0x6FD77C0", VA = "0x186FD8BC0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(LKFMAAICKAG HOGIDEMINCM, LKFMAAICKAG FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(LKFMAAICKAG HOGIDEMINCM, LKFMAAICKAG FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8C70", Offset = "0x6FD7870", VA = "0x186FD8C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct CPONPOCPOHL : IEquatable<CPONPOCPOHL>, IComparable<CPONPOCPOHL>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly CPONPOCPOHL BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public CPONPOCPOHL(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(CPONPOCPOHL OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(CPONPOCPOHL OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD78A0", Offset = "0x6FD64A0", VA = "0x186FD78A0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(CPONPOCPOHL HOGIDEMINCM, CPONPOCPOHL FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(CPONPOCPOHL HOGIDEMINCM, CPONPOCPOHL FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7980", Offset = "0x6FD6580", VA = "0x186FD7980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GBBJJGFDJCC : IEquatable<GBBJJGFDJCC>, IComparable<GBBJJGFDJCC>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GBBJJGFDJCC BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public GBBJJGFDJCC(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(GBBJJGFDJCC OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(GBBJJGFDJCC OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6FD86D0", Offset = "0x6FD72D0", VA = "0x186FD86D0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(GBBJJGFDJCC HOGIDEMINCM, GBBJJGFDJCC FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(GBBJJGFDJCC HOGIDEMINCM, GBBJJGFDJCC FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8780", Offset = "0x6FD7380", VA = "0x186FD8780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KAECHKCDNJH : IEquatable<KAECHKCDNJH>, IComparable<KAECHKCDNJH>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly KAECHKCDNJH BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LOCIFEEIHIM MOJFHNDGDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		[CompilerGenerated]
		get
		{
			return default(LOCIFEEIHIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LOCIFEEIHIM HECAKKAKEND
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B92E0", Offset = "0x8B7EE0", VA = "0x1808B92E0")]
		[CompilerGenerated]
		get
		{
			return default(LOCIFEEIHIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LOCIFEEIHIM FPOHCECKLJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA8F0", Offset = "0x8C94F0", VA = "0x1808CA8F0")]
		[CompilerGenerated]
		get
		{
			return default(LOCIFEEIHIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8B80", Offset = "0x6FD7780", VA = "0x186FD8B80")]
	public KAECHKCDNJH(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8B30", Offset = "0x6FD7730", VA = "0x186FD8B30")]
	public KAECHKCDNJH(LOCIFEEIHIM BEAPKFGANLM, LOCIFEEIHIM INLMFKMBJNM, LOCIFEEIHIM CFEDMBFHHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8910", Offset = "0x6FD7510", VA = "0x186FD8910")]
	private Guid KHAFCDAIHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8830", Offset = "0x6FD7430", VA = "0x186FD8830", Slot = "4")]
	public bool Equals(KAECHKCDNJH OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8860", Offset = "0x6FD7460", VA = "0x186FD8860", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8A40", Offset = "0x6FD7640", VA = "0x186FD8A40")]
	public static bool NBAHCGFACIA(KAECHKCDNJH HOGIDEMINCM, KAECHKCDNJH FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8A80", Offset = "0x6FD7680", VA = "0x186FD8A80")]
	public static bool OONFJEHFBJE(KAECHKCDNJH HOGIDEMINCM, KAECHKCDNJH FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FD87F0", Offset = "0x6FD73F0", VA = "0x186FD87F0", Slot = "5")]
	public int CompareTo(KAECHKCDNJH OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8AC0", Offset = "0x6FD76C0", VA = "0x186FD8AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FEDPOAIINPJ : IEquatable<FEDPOAIINPJ>, IComparable<FEDPOAIINPJ>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly FEDPOAIINPJ BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public FEDPOAIINPJ(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(FEDPOAIINPJ OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(FEDPOAIINPJ OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8490", Offset = "0x6FD7090", VA = "0x186FD8490", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(FEDPOAIINPJ HOGIDEMINCM, FEDPOAIINPJ FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(FEDPOAIINPJ HOGIDEMINCM, FEDPOAIINPJ FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8540", Offset = "0x6FD7140", VA = "0x186FD8540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EPAIPDBBJOB : IEquatable<EPAIPDBBJOB>, IComparable<EPAIPDBBJOB>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EPAIPDBBJOB BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public EPAIPDBBJOB(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(EPAIPDBBJOB OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(EPAIPDBBJOB OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8370", Offset = "0x6FD6F70", VA = "0x186FD8370", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(EPAIPDBBJOB HOGIDEMINCM, EPAIPDBBJOB FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(EPAIPDBBJOB HOGIDEMINCM, EPAIPDBBJOB FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8420", Offset = "0x6FD7020", VA = "0x186FD8420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct FKGKDBCHMBL : IEquatable<FKGKDBCHMBL>, IComparable<FKGKDBCHMBL>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly FKGKDBCHMBL BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public FKGKDBCHMBL(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(FKGKDBCHMBL OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(FKGKDBCHMBL OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FD85B0", Offset = "0x6FD71B0", VA = "0x186FD85B0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(FKGKDBCHMBL HOGIDEMINCM, FKGKDBCHMBL FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(FKGKDBCHMBL HOGIDEMINCM, FKGKDBCHMBL FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8660", Offset = "0x6FD7260", VA = "0x186FD8660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DCNMLPGLGPB : IEquatable<DCNMLPGLGPB>, IComparable<DCNMLPGLGPB>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly DCNMLPGLGPB BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public DCNMLPGLGPB(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(DCNMLPGLGPB OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(DCNMLPGLGPB OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FD79F0", Offset = "0x6FD65F0", VA = "0x186FD79F0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(DCNMLPGLGPB HOGIDEMINCM, DCNMLPGLGPB FKJHDCOBNND)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7950", Offset = "0x6FD6550", VA = "0x186FD7950")]
	public static bool OONFJEHFBJE(DCNMLPGLGPB HOGIDEMINCM, DCNMLPGLGPB FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7AA0", Offset = "0x6FD66A0", VA = "0x186FD7AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DPGGOBMNMNN : IEquatable<DPGGOBMNMNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? KOKIEACBKLG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IHNECOIEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7B10", Offset = "0x6FD6710", VA = "0x186FD7B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BNJLOBHLDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x41A6400", Offset = "0x41A5000", VA = "0x1841A6400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8110", Offset = "0x6FD6D10", VA = "0x186FD8110")]
	public DPGGOBMNMNN(string? HMMAAAHIBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8090", Offset = "0x6FD6C90", VA = "0x186FD8090")]
	public DPGGOBMNMNN(string?[] CIHDNBNGAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7DD0", Offset = "0x6FD69D0", VA = "0x186FD7DD0")]
	private static string?[]? LFAMOFBLIAB(string?[]? CIHDNBNGAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7C90", Offset = "0x6FD6890", VA = "0x186FD7C90")]
	public string FIHLOGGPBNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7BC0", Offset = "0x6FD67C0", VA = "0x186FD7BC0", Slot = "4")]
	public bool Equals(DPGGOBMNMNN OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7B30", Offset = "0x6FD6730", VA = "0x186FD7B30", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7CF0", Offset = "0x6FD68F0", VA = "0x186FD7CF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8000", Offset = "0x6FD6C00", VA = "0x186FD8000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct LOCIFEEIHIM : IEquatable<LOCIFEEIHIM>, IComparable<LOCIFEEIHIM>, JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly LOCIFEEIHIM BBCAMDNMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public LOCIFEEIHIM(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(LOCIFEEIHIM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(LOCIFEEIHIM OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8CE0", Offset = "0x6FD78E0", VA = "0x186FD8CE0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20")]
	public static bool NBAHCGFACIA(LOCIFEEIHIM HOGIDEMINCM, LOCIFEEIHIM FKJHDCOBNND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8D90", Offset = "0x6FD7990", VA = "0x186FD8D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EOOFENEJDKM : IEquatable<EOOFENEJDKM>, IComparable<EOOFENEJDKM>, JJAKLHDPBME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid CICFLOBNFHG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
	public EOOFENEJDKM(Guid CICFLOBNFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public Guid BCPGKOOEMFB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x416BA20", Offset = "0x416A620", VA = "0x18416BA20", Slot = "4")]
	public bool Equals(EOOFENEJDKM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x416B820", Offset = "0x416A420", VA = "0x18416B820", Slot = "5")]
	public int CompareTo(EOOFENEJDKM OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8250", Offset = "0x6FD6E50", VA = "0x186FD8250", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x416B8E0", Offset = "0x416A4E0", VA = "0x18416B8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8300", Offset = "0x6FD6F00", VA = "0x186FD8300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKMOIHHGHAC<TModern> : EMGIHHDBHEG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ICFFCLKHPMD(TModern FJMDMAHFMII);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JJAKLHDPBME
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BCPGKOOEMFB();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EMGIHHDBHEG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern DHEFHPELALB(string FJMDMAHFMII);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IFBHIOFCNNP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JKMOIHHGHAC<LKFMAAICKAG> HKOOCGIENFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JKMOIHHGHAC<FEDPOAIINPJ> LEKNJBMFBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JKMOIHHGHAC<DCNMLPGLGPB> JMMAIGLICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JKMOIHHGHAC<KAECHKCDNJH> EPFBOIJPLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JKMOIHHGHAC<GBBJJGFDJCC> FHEKNELHEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JKMOIHHGHAC<FKGKDBCHMBL> IMCNPFBOMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JKMOIHHGHAC<CPONPOCPOHL> GJPBBNHNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JKMOIHHGHAC<EPAIPDBBJOB> DCCIFIPNEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AGHLMMHDCLC
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6E80", Offset = "0x6FD5A80", VA = "0x186FD6E80")]
	public static string[] IPFMHCJKJFL(string? HMMAAAHIBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6FD6E50", Offset = "0x6FD5A50", VA = "0x186FD6E50")]
	public static string? IIPEFPPGCDA(string? BGKJFLNJDKH)
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
