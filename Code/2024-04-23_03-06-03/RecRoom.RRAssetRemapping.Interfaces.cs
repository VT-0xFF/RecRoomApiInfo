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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945190", Offset = "0x6944190", VA = "0x186945190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KINIOCIKLJM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AFIENNPCBKD(HJDNHIMMBMD BJGIJFLPNGG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HJDNHIMMBMD OMCMMHECHCJ(string BJGIJFLPNGG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HJDNHIMMBMD : IEquatable<HJDNHIMMBMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ENHNLAAGEAI BDHGLDIHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MGKJIIAIDFC CEOJOBKPKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid KIKJNAGPCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LMEAHGHNPHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JHNHEHMGNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6944490", Offset = "0x6943490", VA = "0x186944490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AONAIKPFKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6944600", Offset = "0x6943600", VA = "0x186944600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6944A60", Offset = "0x6943A60", VA = "0x186944A60")]
	public HJDNHIMMBMD(HJDNHIMMBMD EGHJHIGIDKI, [Optional] Guid CGEKLGOFNLF, [Optional] RRColor? IODHIPGGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6944AF0", Offset = "0x6943AF0", VA = "0x186944AF0")]
	public HJDNHIMMBMD(ENHNLAAGEAI CAAMEMGNIDH, MGKJIIAIDFC KJHCGLDIMFN, [Optional] Guid CGEKLGOFNLF, [Optional] RRColor? IODHIPGGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6944220", Offset = "0x6943220", VA = "0x186944220", Slot = "4")]
	public bool Equals(HJDNHIMMBMD JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69442D0", Offset = "0x69432D0", VA = "0x1869442D0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6944400", Offset = "0x6943400", VA = "0x186944400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6944220", Offset = "0x6943220", VA = "0x186944220")]
	public static bool JPKEALLKLNK(HJDNHIMMBMD LHPJOLLNMHI, HJDNHIMMBMD MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6944550", Offset = "0x6943550", VA = "0x186944550")]
	public static bool OECHKCIMKIG(HJDNHIMMBMD LHPJOLLNMHI, HJDNHIMMBMD MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6944640", Offset = "0x6943640", VA = "0x186944640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ENHNLAAGEAI : IEquatable<ENHNLAAGEAI>, IComparable<ENHNLAAGEAI>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly ENHNLAAGEAI LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public ENHNLAAGEAI(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(ENHNLAAGEAI JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(ENHNLAAGEAI JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6943300", Offset = "0x6942300", VA = "0x186943300", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(ENHNLAAGEAI LHPJOLLNMHI, ENHNLAAGEAI MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(ENHNLAAGEAI LHPJOLLNMHI, ENHNLAAGEAI MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69433E0", Offset = "0x69423E0", VA = "0x1869433E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OOPDGGIOCLF : IEquatable<OOPDGGIOCLF>, IComparable<OOPDGGIOCLF>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OOPDGGIOCLF LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public OOPDGGIOCLF(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(OOPDGGIOCLF JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(OOPDGGIOCLF JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6945210", Offset = "0x6944210", VA = "0x186945210", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(OOPDGGIOCLF LHPJOLLNMHI, OOPDGGIOCLF MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(OOPDGGIOCLF LHPJOLLNMHI, OOPDGGIOCLF MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69452C0", Offset = "0x69442C0", VA = "0x1869452C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ENMELFEIEBP : IEquatable<ENMELFEIEBP>, IComparable<ENMELFEIEBP>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly ENMELFEIEBP LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public ENMELFEIEBP(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(ENMELFEIEBP JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(ENMELFEIEBP JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6943450", Offset = "0x6942450", VA = "0x186943450", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(ENMELFEIEBP LHPJOLLNMHI, ENMELFEIEBP MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(ENMELFEIEBP LHPJOLLNMHI, ENMELFEIEBP MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6943500", Offset = "0x6942500", VA = "0x186943500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MGKJIIAIDFC : IEquatable<MGKJIIAIDFC>, IComparable<MGKJIIAIDFC>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MGKJIIAIDFC LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GHIBCAMDGFA NJDCFKNGMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0")]
		[CompilerGenerated]
		get
		{
			return default(GHIBCAMDGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GHIBCAMDGFA IKKNGJJKOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x105F1C0", Offset = "0x105E1C0", VA = "0x18105F1C0")]
		[CompilerGenerated]
		get
		{
			return default(GHIBCAMDGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHIBCAMDGFA DNLCMCHBAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF223C0", Offset = "0xF213C0", VA = "0x180F223C0")]
		[CompilerGenerated]
		get
		{
			return default(GHIBCAMDGFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6945150", Offset = "0x6944150", VA = "0x186945150")]
	public MGKJIIAIDFC(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6945100", Offset = "0x6944100", VA = "0x186945100")]
	public MGKJIIAIDFC(GHIBCAMDGFA HLMNBNALBOG, GHIBCAMDGFA COGCEEMDBJM, GHIBCAMDGFA MOLDABDNIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6944EE0", Offset = "0x6943EE0", VA = "0x186944EE0")]
	private Guid GGJIAJDFDDN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6944E00", Offset = "0x6943E00", VA = "0x186944E00", Slot = "4")]
	public bool Equals(MGKJIIAIDFC JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6944E30", Offset = "0x6943E30", VA = "0x186944E30", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6945010", Offset = "0x6944010", VA = "0x186945010")]
	public static bool JPKEALLKLNK(MGKJIIAIDFC LHPJOLLNMHI, MGKJIIAIDFC MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6945050", Offset = "0x6944050", VA = "0x186945050")]
	public static bool OECHKCIMKIG(MGKJIIAIDFC LHPJOLLNMHI, MGKJIIAIDFC MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6944DC0", Offset = "0x6943DC0", VA = "0x186944DC0", Slot = "5")]
	public int CompareTo(MGKJIIAIDFC JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6945090", Offset = "0x6944090", VA = "0x186945090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LMLHJGFFAPN : IEquatable<LMLHJGFFAPN>, IComparable<LMLHJGFFAPN>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LMLHJGFFAPN LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public LMLHJGFFAPN(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(LMLHJGFFAPN JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(LMLHJGFFAPN JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6944B80", Offset = "0x6943B80", VA = "0x186944B80", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(LMLHJGFFAPN LHPJOLLNMHI, LMLHJGFFAPN MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(LMLHJGFFAPN LHPJOLLNMHI, LMLHJGFFAPN MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6944C30", Offset = "0x6943C30", VA = "0x186944C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FHLAPGIAMKK : IEquatable<FHLAPGIAMKK>, IComparable<FHLAPGIAMKK>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FHLAPGIAMKK LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public FHLAPGIAMKK(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(FHLAPGIAMKK JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(FHLAPGIAMKK JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6943CB0", Offset = "0x6942CB0", VA = "0x186943CB0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(FHLAPGIAMKK LHPJOLLNMHI, FHLAPGIAMKK MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(FHLAPGIAMKK LHPJOLLNMHI, FHLAPGIAMKK MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6943D60", Offset = "0x6942D60", VA = "0x186943D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HBMKPAAGLIC : IEquatable<HBMKPAAGLIC>, IComparable<HBMKPAAGLIC>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly HBMKPAAGLIC LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public HBMKPAAGLIC(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(HBMKPAAGLIC JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(HBMKPAAGLIC JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6944100", Offset = "0x6943100", VA = "0x186944100", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(HBMKPAAGLIC LHPJOLLNMHI, HBMKPAAGLIC MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(HBMKPAAGLIC LHPJOLLNMHI, HBMKPAAGLIC MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69441B0", Offset = "0x69431B0", VA = "0x1869441B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LOACGBAGCFM : IEquatable<LOACGBAGCFM>, IComparable<LOACGBAGCFM>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly LOACGBAGCFM LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public LOACGBAGCFM(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(LOACGBAGCFM JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(LOACGBAGCFM JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6944CA0", Offset = "0x6943CA0", VA = "0x186944CA0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(LOACGBAGCFM LHPJOLLNMHI, LOACGBAGCFM MGIFPMANJFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public static bool OECHKCIMKIG(LOACGBAGCFM LHPJOLLNMHI, LOACGBAGCFM MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6944D50", Offset = "0x6943D50", VA = "0x186944D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FFGEBEJJBKI : IEquatable<FFGEBEJJBKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? MNMCJMDGJLF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JEAENFCBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6943A40", Offset = "0x6942A40", VA = "0x186943A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int FHOKIKMOJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3E97C70", Offset = "0x3E96C70", VA = "0x183E97C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6943AF0", Offset = "0x6942AF0", VA = "0x186943AF0")]
	public FFGEBEJJBKI(string? DKECNFNFIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6943C30", Offset = "0x6942C30", VA = "0x186943C30")]
	public FFGEBEJJBKI(string?[] LNBBBHBFMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6943810", Offset = "0x6942810", VA = "0x186943810")]
	private static string?[]? LFMJBBCJLOA(string?[]? LNBBBHBFMPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69437B0", Offset = "0x69427B0", VA = "0x1869437B0")]
	public string HJCDLPALAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6943570", Offset = "0x6942570", VA = "0x186943570", Slot = "4")]
	public bool Equals(FFGEBEJJBKI JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6943640", Offset = "0x6942640", VA = "0x186943640", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69436D0", Offset = "0x69426D0", VA = "0x1869436D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6943A60", Offset = "0x6942A60", VA = "0x186943A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GHIBCAMDGFA : IEquatable<GHIBCAMDGFA>, IComparable<GHIBCAMDGFA>, FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GHIBCAMDGFA LGJIMEKOCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public GHIBCAMDGFA(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(GHIBCAMDGFA JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(GHIBCAMDGFA JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6943FE0", Offset = "0x6942FE0", VA = "0x186943FE0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0")]
	public static bool JPKEALLKLNK(GHIBCAMDGFA LHPJOLLNMHI, GHIBCAMDGFA MGIFPMANJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6944090", Offset = "0x6943090", VA = "0x186944090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FKHMEKGJKEJ : IEquatable<FKHMEKGJKEJ>, IComparable<FKHMEKGJKEJ>, FAGMIOINPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly Guid KAABLCGOLKG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
	public FKHMEKGJKEJ(Guid KAABLCGOLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0", Slot = "6")]
	public Guid OFNCEDGHBEH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3A109B0", Offset = "0x3A0F9B0", VA = "0x183A109B0", Slot = "4")]
	public bool Equals(FKHMEKGJKEJ JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A10980", Offset = "0x3A0F980", VA = "0x183A10980", Slot = "5")]
	public int CompareTo(FKHMEKGJKEJ JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6943DD0", Offset = "0x6942DD0", VA = "0x186943DD0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A10B80", Offset = "0x3A0FB80", VA = "0x183A10B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6943E80", Offset = "0x6942E80", VA = "0x186943E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NBKDMDCJHBM<TModern> : LFJGLFJNFFJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MBKELIFOLND(TModern MPDJJOLMPAE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FAGMIOINPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid OFNCEDGHBEH();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LFJGLFJNFFJ<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KKEFJENBKOL(string MPDJJOLMPAE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MDFGOJDKIDF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NBKDMDCJHBM<ENHNLAAGEAI> NKMCGODDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NBKDMDCJHBM<LMLHJGFFAPN> MMLFHIMIJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NBKDMDCJHBM<LOACGBAGCFM> LLMPJCNICOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NBKDMDCJHBM<MGKJIIAIDFC> ALJKMEIJENC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NBKDMDCJHBM<ENMELFEIEBP> OINKJGFJKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NBKDMDCJHBM<HBMKPAAGLIC> FDNPDMBEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NBKDMDCJHBM<OOPDGGIOCLF> NDAKENELCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NBKDMDCJHBM<FHLAPGIAMKK> MGACIFICKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FLKEMMKJFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6943EF0", Offset = "0x6942EF0", VA = "0x186943EF0")]
	public static string[] OCIPLCINPKO(string? DKECNFNFIPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6943FB0", Offset = "0x6942FB0", VA = "0x186943FB0")]
	public static string? OKPKBEGAMBI(string? CAAMEMGNIDH)
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
