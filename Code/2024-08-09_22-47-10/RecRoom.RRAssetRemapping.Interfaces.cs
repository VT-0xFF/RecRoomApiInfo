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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7006470", Offset = "0x7005870", VA = "0x187006470")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BNAEJMDDEBH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KPIBKDOHBCB(CJKCONKAKEF BCPLMINPIEH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJKCONKAKEF JLCLGLEKPEG(string BCPLMINPIEH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CJKCONKAKEF : IEquatable<CJKCONKAKEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PKLEKOKBDCD OPKNKKCJAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IMNBCOOFJKJ FFGOBCJHNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid GAKNFNKCCOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MEJAOKDHNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7005780", Offset = "0x7004B80", VA = "0x187005780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BOMDJGLFMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7005740", Offset = "0x7004B40", VA = "0x187005740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7005B10", Offset = "0x7004F10", VA = "0x187005B10")]
	public CJKCONKAKEF(CJKCONKAKEF BGPGMHJOBGB, [Optional] Guid HFOAEAPGLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C570", Offset = "0x4D0B970", VA = "0x184D0C570")]
	public CJKCONKAKEF(PKLEKOKBDCD DLGHIJCLHBE, IMNBCOOFJKJ FJPOBGOLLEL, [Optional] Guid HFOAEAPGLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70055C0", Offset = "0x70049C0", VA = "0x1870055C0", Slot = "4")]
	public bool Equals(CJKCONKAKEF IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7005510", Offset = "0x7004910", VA = "0x187005510", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7005680", Offset = "0x7004A80", VA = "0x187005680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7005710", Offset = "0x7004B10", VA = "0x187005710")]
	public static bool JAICCEKEELH(CJKCONKAKEF JNFNBKNOBNN, CJKCONKAKEF CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7005810", Offset = "0x7004C10", VA = "0x187005810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PKLEKOKBDCD : IEquatable<PKLEKOKBDCD>, IComparable<PKLEKOKBDCD>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly PKLEKOKBDCD ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public PKLEKOKBDCD(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(PKLEKOKBDCD IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(PKLEKOKBDCD IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70064F0", Offset = "0x70058F0", VA = "0x1870064F0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(PKLEKOKBDCD JNFNBKNOBNN, PKLEKOKBDCD CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(PKLEKOKBDCD JNFNBKNOBNN, PKLEKOKBDCD CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7006590", Offset = "0x7005990", VA = "0x187006590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EGALLKJKHIB : IEquatable<EGALLKJKHIB>, IComparable<EGALLKJKHIB>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly EGALLKJKHIB ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public EGALLKJKHIB(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(EGALLKJKHIB IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(EGALLKJKHIB IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7005B30", Offset = "0x7004F30", VA = "0x187005B30", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(EGALLKJKHIB JNFNBKNOBNN, EGALLKJKHIB CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(EGALLKJKHIB JNFNBKNOBNN, EGALLKJKHIB CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7005BD0", Offset = "0x7004FD0", VA = "0x187005BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NBCAAFAKGMC : IEquatable<NBCAAFAKGMC>, IComparable<NBCAAFAKGMC>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly NBCAAFAKGMC ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public NBCAAFAKGMC(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(NBCAAFAKGMC IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(NBCAAFAKGMC IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7006250", Offset = "0x7005650", VA = "0x187006250", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(NBCAAFAKGMC JNFNBKNOBNN, NBCAAFAKGMC CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(NBCAAFAKGMC JNFNBKNOBNN, NBCAAFAKGMC CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70062F0", Offset = "0x70056F0", VA = "0x1870062F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IMNBCOOFJKJ : IEquatable<IMNBCOOFJKJ>, IComparable<IMNBCOOFJKJ>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly IMNBCOOFJKJ ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public IMNBCOOFJKJ(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7005E60", Offset = "0x7005260", VA = "0x187005E60", Slot = "4")]
	public bool Equals(IMNBCOOFJKJ IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7005E90", Offset = "0x7005290", VA = "0x187005E90", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7005E60", Offset = "0x7005260", VA = "0x187005E60")]
	public static bool JAICCEKEELH(IMNBCOOFJKJ JNFNBKNOBNN, IMNBCOOFJKJ CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7005F30", Offset = "0x7005330", VA = "0x187005F30")]
	public static bool HBJIFBKOLOD(IMNBCOOFJKJ JNFNBKNOBNN, IMNBCOOFJKJ CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(IMNBCOOFJKJ IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7005F60", Offset = "0x7005360", VA = "0x187005F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public IMNBCOOFJKJ(GIDLPBMPMHC LEPGFDNNHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AJPNONKCNOI : IEquatable<AJPNONKCNOI>, IComparable<AJPNONKCNOI>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly AJPNONKCNOI ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public AJPNONKCNOI(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(AJPNONKCNOI IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(AJPNONKCNOI IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70053D0", Offset = "0x70047D0", VA = "0x1870053D0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(AJPNONKCNOI JNFNBKNOBNN, AJPNONKCNOI CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(AJPNONKCNOI JNFNBKNOBNN, AJPNONKCNOI CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70054A0", Offset = "0x70048A0", VA = "0x1870054A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NNBLNMLCNGB : IEquatable<NNBLNMLCNGB>, IComparable<NNBLNMLCNGB>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly NNBLNMLCNGB ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public NNBLNMLCNGB(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(NNBLNMLCNGB IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(NNBLNMLCNGB IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7006360", Offset = "0x7005760", VA = "0x187006360", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(NNBLNMLCNGB JNFNBKNOBNN, NNBLNMLCNGB CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(NNBLNMLCNGB JNFNBKNOBNN, NNBLNMLCNGB CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7006400", Offset = "0x7005800", VA = "0x187006400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct GDOGJLLCBMG : IEquatable<GDOGJLLCBMG>, IComparable<GDOGJLLCBMG>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GDOGJLLCBMG ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public GDOGJLLCBMG(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(GDOGJLLCBMG IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(GDOGJLLCBMG IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7005C40", Offset = "0x7005040", VA = "0x187005C40", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(GDOGJLLCBMG JNFNBKNOBNN, GDOGJLLCBMG CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(GDOGJLLCBMG JNFNBKNOBNN, GDOGJLLCBMG CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7005CE0", Offset = "0x70050E0", VA = "0x187005CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LHKFMHHMHDP : IEquatable<LHKFMHHMHDP>, IComparable<LHKFMHHMHDP>, FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LHKFMHHMHDP ADMHPKLFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public LHKFMHHMHDP(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(LHKFMHHMHDP IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(LHKFMHHMHDP IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7006140", Offset = "0x7005540", VA = "0x187006140", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580")]
	public static bool JAICCEKEELH(LHKFMHHMHDP JNFNBKNOBNN, LHKFMHHMHDP CNFAHLDDGGP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7005470", Offset = "0x7004870", VA = "0x187005470")]
	public static bool HBJIFBKOLOD(LHKFMHHMHDP JNFNBKNOBNN, LHKFMHHMHDP CNFAHLDDGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70061E0", Offset = "0x70055E0", VA = "0x1870061E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ACJEOEJGGDE : IEquatable<ACJEOEJGGDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? KANBNHBJILH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OODFNLHIOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7004EC0", Offset = "0x70042C0", VA = "0x187004EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EAAKCPMHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x416F020", Offset = "0x416E420", VA = "0x18416F020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7005200", Offset = "0x7004600", VA = "0x187005200")]
	public ACJEOEJGGDE(string? GMNIIMKIDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7005350", Offset = "0x7004750", VA = "0x187005350")]
	public ACJEOEJGGDE(string?[] DBDKKAKACOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7004F40", Offset = "0x7004340", VA = "0x187004F40")]
	private static string?[]? NNNDPCGJDBF(string?[]? DBDKKAKACOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7004EE0", Offset = "0x70042E0", VA = "0x187004EE0")]
	public string NGNGKFKCGMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7004C80", Offset = "0x7004080", VA = "0x187004C80", Slot = "4")]
	public bool Equals(ACJEOEJGGDE IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7004D50", Offset = "0x7004150", VA = "0x187004D50", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7004DE0", Offset = "0x70041E0", VA = "0x187004DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7005170", Offset = "0x7004570", VA = "0x187005170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GIDLPBMPMHC : IEquatable<GIDLPBMPMHC>, IComparable<GIDLPBMPMHC>, FAOLNGHDKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid HLKHAOEDAIN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
	public GIDLPBMPMHC(Guid HLKHAOEDAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0", Slot = "6")]
	public Guid INCGPMFOIKN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C94580", Offset = "0x3C93980", VA = "0x183C94580", Slot = "4")]
	public bool Equals(GIDLPBMPMHC IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C94550", Offset = "0x3C93950", VA = "0x183C94550", Slot = "5")]
	public int CompareTo(GIDLPBMPMHC IEDCHGMDIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7005D50", Offset = "0x7005150", VA = "0x187005D50", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C94690", Offset = "0x3C93A90", VA = "0x183C94690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7005DF0", Offset = "0x70051F0", VA = "0x187005DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OCFMIHMGMHJ<TModern> : MBNJHHAADJO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KGHKPEALNFN(TModern MKGCJFFEABC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FAOLNGHDKLI
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid INCGPMFOIKN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MBNJHHAADJO<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern LMDGFFFHGKO(string MKGCJFFEABC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NEHCKIELPHC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OCFMIHMGMHJ<PKLEKOKBDCD> PJMBPGGEFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OCFMIHMGMHJ<AJPNONKCNOI> LECCLDMOFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OCFMIHMGMHJ<LHKFMHHMHDP> KBCCCCENBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OCFMIHMGMHJ<IMNBCOOFJKJ> HFMNFMGCDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OCFMIHMGMHJ<NBCAAFAKGMC> NABPGPJMMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OCFMIHMGMHJ<GDOGJLLCBMG> NHCAIKMBNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OCFMIHMGMHJ<EGALLKJKHIB> GMOANNJKINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OCFMIHMGMHJ<NNBLNMLCNGB> AFCHGCBGNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LCJFIOEDEGN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] JMHJKFJDLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7006000", Offset = "0x7005400", VA = "0x187006000")]
	public static string[] MOAAKJAJMOD(string? GMNIIMKIDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7005FD0", Offset = "0x70053D0", VA = "0x187005FD0")]
	public static string? GBIFPOEIAKI(string? DLGHIJCLHBE)
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
