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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BC9BF0", Offset = "0x8BC8FF0", VA = "0x188BC9BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IDLEGOLOPCF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string COFPFOKABJF(PBBHALCOHCB MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PBBHALCOHCB DGFNGGGAAON(string MICKAKKPGLH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct PBBHALCOHCB : IEquatable<PBBHALCOHCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PPDJPCBBHNI EEKLKEKCBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KHANOMCGPKB CENJOCIOHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CDAPHDPIEII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CLHNCAJMCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9F50", Offset = "0x8BC9350", VA = "0x188BC9F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HEOENLMPCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA0A0", Offset = "0x8BC94A0", VA = "0x188BCA0A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA3E0", Offset = "0x8BC97E0", VA = "0x188BCA3E0")]
	public PBBHALCOHCB(PBBHALCOHCB DLCKMJAFEBI, [Optional] Guid NPMPEIAPAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6111A40", Offset = "0x6110E40", VA = "0x186111A40")]
	public PBBHALCOHCB(PPDJPCBBHNI JCGHBPGKAOE, KHANOMCGPKB IPHNMFDKPCP, [Optional] Guid NPMPEIAPAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9E90", Offset = "0x8BC9290", VA = "0x188BC9E90", Slot = "4")]
	public bool Equals(PBBHALCOHCB LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9DE0", Offset = "0x8BC91E0", VA = "0x188BC9DE0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9FE0", Offset = "0x8BC93E0", VA = "0x188BC9FE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA070", Offset = "0x8BC9470", VA = "0x188BCA070")]
	public static bool ILMCFLMCOJH(PBBHALCOHCB JLJHECODIOL, PBBHALCOHCB DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA0D0", Offset = "0x8BC94D0", VA = "0x188BCA0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PPDJPCBBHNI : IEquatable<PPDJPCBBHNI>, IComparable<PPDJPCBBHNI>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly PPDJPCBBHNI BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public PPDJPCBBHNI(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(PPDJPCBBHNI LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(PPDJPCBBHNI LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA400", Offset = "0x8BC9800", VA = "0x188BCA400", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(PPDJPCBBHNI JLJHECODIOL, PPDJPCBBHNI DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(PPDJPCBBHNI JLJHECODIOL, PPDJPCBBHNI DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA4B0", Offset = "0x8BC98B0", VA = "0x188BCA4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ELOAIAIFLPJ : IEquatable<ELOAIAIFLPJ>, IComparable<ELOAIAIFLPJ>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly ELOAIAIFLPJ BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public ELOAIAIFLPJ(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(ELOAIAIFLPJ LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(ELOAIAIFLPJ LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC95F0", Offset = "0x8BC89F0", VA = "0x188BC95F0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(ELOAIAIFLPJ JLJHECODIOL, ELOAIAIFLPJ DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(ELOAIAIFLPJ JLJHECODIOL, ELOAIAIFLPJ DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8BC96A0", Offset = "0x8BC8AA0", VA = "0x188BC96A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FGBKOBFMFHG : IEquatable<FGBKOBFMFHG>, IComparable<FGBKOBFMFHG>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly FGBKOBFMFHG BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public FGBKOBFMFHG(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(FGBKOBFMFHG LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(FGBKOBFMFHG LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9710", Offset = "0x8BC8B10", VA = "0x188BC9710", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(FGBKOBFMFHG JLJHECODIOL, FGBKOBFMFHG DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(FGBKOBFMFHG JLJHECODIOL, FGBKOBFMFHG DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC97C0", Offset = "0x8BC8BC0", VA = "0x188BC97C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KHANOMCGPKB : IEquatable<KHANOMCGPKB>, IComparable<KHANOMCGPKB>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly KHANOMCGPKB BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public KHANOMCGPKB(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9AA0", Offset = "0x8BC8EA0", VA = "0x188BC9AA0", Slot = "4")]
	public bool Equals(KHANOMCGPKB LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9AD0", Offset = "0x8BC8ED0", VA = "0x188BC9AD0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9AA0", Offset = "0x8BC8EA0", VA = "0x188BC9AA0")]
	public static bool ILMCFLMCOJH(KHANOMCGPKB JLJHECODIOL, KHANOMCGPKB DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9A70", Offset = "0x8BC8E70", VA = "0x188BC9A70")]
	public static bool AMDBHCBNEEF(KHANOMCGPKB JLJHECODIOL, KHANOMCGPKB DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(KHANOMCGPKB LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9B80", Offset = "0x8BC8F80", VA = "0x188BC9B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public KHANOMCGPKB(DIBBJJPBDGI HPMPNEBHMDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CKPKAPIIDCF : IEquatable<CKPKAPIIDCF>, IComparable<CKPKAPIIDCF>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly CKPKAPIIDCF BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public CKPKAPIIDCF(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(CKPKAPIIDCF LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(CKPKAPIIDCF LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B40", Offset = "0x8BC7F40", VA = "0x188BC8B40", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(CKPKAPIIDCF JLJHECODIOL, CKPKAPIIDCF DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(CKPKAPIIDCF JLJHECODIOL, CKPKAPIIDCF DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8BF0", Offset = "0x8BC7FF0", VA = "0x188BC8BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct KDMFEBNOJJL : IEquatable<KDMFEBNOJJL>, IComparable<KDMFEBNOJJL>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly KDMFEBNOJJL BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public KDMFEBNOJJL(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(KDMFEBNOJJL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(KDMFEBNOJJL LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9950", Offset = "0x8BC8D50", VA = "0x188BC9950", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(KDMFEBNOJJL JLJHECODIOL, KDMFEBNOJJL DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(KDMFEBNOJJL JLJHECODIOL, KDMFEBNOJJL DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9A00", Offset = "0x8BC8E00", VA = "0x188BC9A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CNJONJMPBMP : IEquatable<CNJONJMPBMP>, IComparable<CNJONJMPBMP>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CNJONJMPBMP BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public CNJONJMPBMP(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(CNJONJMPBMP LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(CNJONJMPBMP LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8C60", Offset = "0x8BC8060", VA = "0x188BC8C60", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(CNJONJMPBMP JLJHECODIOL, CNJONJMPBMP DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(CNJONJMPBMP JLJHECODIOL, CNJONJMPBMP DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8D10", Offset = "0x8BC8110", VA = "0x188BC8D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct JBEEOLANKLN : IEquatable<JBEEOLANKLN>, IComparable<JBEEOLANKLN>, PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JBEEOLANKLN BOBPMJBGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public JBEEOLANKLN(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(JBEEOLANKLN LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(JBEEOLANKLN LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9830", Offset = "0x8BC8C30", VA = "0x188BC9830", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810")]
	public static bool ILMCFLMCOJH(JBEEOLANKLN JLJHECODIOL, JBEEOLANKLN DABLONGJEGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8B10", Offset = "0x8BC7F10", VA = "0x188BC8B10")]
	public static bool AMDBHCBNEEF(JBEEOLANKLN JLJHECODIOL, JBEEOLANKLN DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BC98E0", Offset = "0x8BC8CE0", VA = "0x188BC98E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DPHDNJLDDAD : IEquatable<DPHDNJLDDAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? FEJLBLBMLNJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9370", Offset = "0x8BC8770", VA = "0x188BC9370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BFMKAJFHHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5604CB0", Offset = "0x56040B0", VA = "0x185604CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC94A0", Offset = "0x8BC88A0", VA = "0x188BC94A0")]
	public DPHDNJLDDAD(string? BPIGGLKGOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9420", Offset = "0x8BC8820", VA = "0x188BC9420")]
	public DPHDNJLDDAD(string?[] AOFKKBPIOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8EA0", Offset = "0x8BC82A0", VA = "0x188BC8EA0")]
	private static string?[]? BLOLKNCMAJF(string?[]? AOFKKBPIOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC90D0", Offset = "0x8BC84D0", VA = "0x188BC90D0")]
	public string CCMIDHFPNEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC91C0", Offset = "0x8BC85C0", VA = "0x188BC91C0", Slot = "4")]
	public bool Equals(DPHDNJLDDAD LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9130", Offset = "0x8BC8530", VA = "0x188BC9130", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9290", Offset = "0x8BC8690", VA = "0x188BC9290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9390", Offset = "0x8BC8790", VA = "0x188BC9390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DIBBJJPBDGI : IEquatable<DIBBJJPBDGI>, IComparable<DIBBJJPBDGI>, PIKPFPHMMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OOOANFDGEED;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
	public DIBBJJPBDGI(Guid OOOANFDGEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
	public Guid MADBNACIMLN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x530E810", Offset = "0x530DC10", VA = "0x18530E810", Slot = "4")]
	public bool Equals(DIBBJJPBDGI LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530DBE0", VA = "0x18530E7E0", Slot = "5")]
	public int CompareTo(DIBBJJPBDGI LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8D80", Offset = "0x8BC8180", VA = "0x188BC8D80", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x530E840", Offset = "0x530DC40", VA = "0x18530E840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8E30", Offset = "0x8BC8230", VA = "0x188BC8E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FHLIDKIAKPK<TModern> : FEFGPEEHFDA<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LECOIFNLDEE(TModern AKKPBENJCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PIKPFPHMMFH
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid MADBNACIMLN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FEFGPEEHFDA<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern FABNFCIJIDM(string AKKPBENJCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PNAAMOOFGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FHLIDKIAKPK<PPDJPCBBHNI> JBMCDPGLGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FHLIDKIAKPK<CKPKAPIIDCF> GCHKIODJDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FHLIDKIAKPK<JBEEOLANKLN> BPCPEMGALHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FHLIDKIAKPK<KHANOMCGPKB> MIOIEGMKILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FHLIDKIAKPK<FGBKOBFMFHG> AJLNAENPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FHLIDKIAKPK<CNJONJMPBMP> GGACDDIKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FHLIDKIAKPK<ELOAIAIFLPJ> JOHPHKOMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FHLIDKIAKPK<KDMFEBNOJJL> KMEOHIJMCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFLPNOMPOJB
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] HDKGAMKPAAF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9CA0", Offset = "0x8BC90A0", VA = "0x188BC9CA0")]
	public static string[] ENHGFJEBGNC(string? BPIGGLKGOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9C70", Offset = "0x8BC9070", VA = "0x188BC9C70")]
	public static string? EGHPCDFBCME(string? JCGHBPGKAOE)
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
