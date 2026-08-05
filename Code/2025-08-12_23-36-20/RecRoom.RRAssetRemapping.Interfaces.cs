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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C914C0", Offset = "0x8C902C0", VA = "0x188C914C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFOAHIEBMAB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OFACCHGGJAP(EPADPFJDNDI DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPADPFJDNDI PPEAGMPJINO(string DANFKLEPBNF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EPADPFJDNDI : IEquatable<EPADPFJDNDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MDLPHIOGMIH GLPGLCAOIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NGBEPHHOLNP MBEGAIAGHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid JPGHKDHGJKB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FEDFAKACEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FE60", Offset = "0x8C8EC60", VA = "0x188C8FE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NDNGGNLKFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FEF0", Offset = "0x8C8ECF0", VA = "0x188C8FEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8C902E0", Offset = "0x8C8F0E0", VA = "0x188C902E0")]
	public EPADPFJDNDI(EPADPFJDNDI HCANFCJAJDN, [Optional] Guid PJJIOIOLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6237CD0", Offset = "0x6236AD0", VA = "0x186237CD0")]
	public EPADPFJDNDI(MDLPHIOGMIH DCAPIGMJMIJ, NGBEPHHOLNP ACPLLOOHNOJ, [Optional] Guid PJJIOIOLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FCF0", Offset = "0x8C8EAF0", VA = "0x188C8FCF0", Slot = "4")]
	public bool Equals(EPADPFJDNDI FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FDB0", Offset = "0x8C8EBB0", VA = "0x188C8FDB0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FF20", Offset = "0x8C8ED20", VA = "0x188C8FF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FFB0", Offset = "0x8C8EDB0", VA = "0x188C8FFB0")]
	public static bool IKIADGFKNFC(EPADPFJDNDI NNEMEIEKIAF, EPADPFJDNDI JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FFE0", Offset = "0x8C8EDE0", VA = "0x188C8FFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MDLPHIOGMIH : IEquatable<MDLPHIOGMIH>, IComparable<MDLPHIOGMIH>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly MDLPHIOGMIH FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public MDLPHIOGMIH(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(MDLPHIOGMIH FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(MDLPHIOGMIH FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8C91130", Offset = "0x8C8FF30", VA = "0x188C91130", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(MDLPHIOGMIH NNEMEIEKIAF, MDLPHIOGMIH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(MDLPHIOGMIH NNEMEIEKIAF, MDLPHIOGMIH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8C911D0", Offset = "0x8C8FFD0", VA = "0x188C911D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LCJKMECGKBD : IEquatable<LCJKMECGKBD>, IComparable<LCJKMECGKBD>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly LCJKMECGKBD FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public LCJKMECGKBD(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(LCJKMECGKBD FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(LCJKMECGKBD FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8C91020", Offset = "0x8C8FE20", VA = "0x188C91020", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(LCJKMECGKBD NNEMEIEKIAF, LCJKMECGKBD JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(LCJKMECGKBD NNEMEIEKIAF, LCJKMECGKBD JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8C910C0", Offset = "0x8C8FEC0", VA = "0x188C910C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct OEOJAONNJFH : IEquatable<OEOJAONNJFH>, IComparable<OEOJAONNJFH>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly OEOJAONNJFH FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public OEOJAONNJFH(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(OEOJAONNJFH FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(OEOJAONNJFH FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8C91540", Offset = "0x8C90340", VA = "0x188C91540", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(OEOJAONNJFH NNEMEIEKIAF, OEOJAONNJFH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(OEOJAONNJFH NNEMEIEKIAF, OEOJAONNJFH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8C915E0", Offset = "0x8C903E0", VA = "0x188C915E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NGBEPHHOLNP : IEquatable<NGBEPHHOLNP>, IComparable<NGBEPHHOLNP>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly NGBEPHHOLNP FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public NGBEPHHOLNP(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8C912E0", Offset = "0x8C900E0", VA = "0x188C912E0", Slot = "4")]
	public bool Equals(NGBEPHHOLNP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8C91240", Offset = "0x8C90040", VA = "0x188C91240", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8C912E0", Offset = "0x8C900E0", VA = "0x188C912E0")]
	public static bool IKIADGFKNFC(NGBEPHHOLNP NNEMEIEKIAF, NGBEPHHOLNP JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8C91310", Offset = "0x8C90110", VA = "0x188C91310")]
	public static bool GFAFFKCBFKA(NGBEPHHOLNP NNEMEIEKIAF, NGBEPHHOLNP JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(NGBEPHHOLNP FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8C91340", Offset = "0x8C90140", VA = "0x188C91340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public NGBEPHHOLNP(KEGLPJPCCOP DNHCFKHCDDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct JGBEJPGGFBH : IEquatable<JGBEJPGGFBH>, IComparable<JGBEJPGGFBH>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly JGBEJPGGFBH FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public JGBEJPGGFBH(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(JGBEJPGGFBH FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(JGBEJPGGFBH FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8C90CA0", Offset = "0x8C8FAA0", VA = "0x188C90CA0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(JGBEJPGGFBH NNEMEIEKIAF, JGBEJPGGFBH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(JGBEJPGGFBH NNEMEIEKIAF, JGBEJPGGFBH JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8C90D40", Offset = "0x8C8FB40", VA = "0x188C90D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NJKDBAMDGPL : IEquatable<NJKDBAMDGPL>, IComparable<NJKDBAMDGPL>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly NJKDBAMDGPL FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public NJKDBAMDGPL(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(NJKDBAMDGPL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(NJKDBAMDGPL FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8C913B0", Offset = "0x8C901B0", VA = "0x188C913B0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(NJKDBAMDGPL NNEMEIEKIAF, NJKDBAMDGPL JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(NJKDBAMDGPL NNEMEIEKIAF, NJKDBAMDGPL JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C91450", Offset = "0x8C90250", VA = "0x188C91450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct INBBLDDKEIN : IEquatable<INBBLDDKEIN>, IComparable<INBBLDDKEIN>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly INBBLDDKEIN FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public INBBLDDKEIN(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(INBBLDDKEIN FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(INBBLDDKEIN FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8C90B90", Offset = "0x8C8F990", VA = "0x188C90B90", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(INBBLDDKEIN NNEMEIEKIAF, INBBLDDKEIN JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(INBBLDDKEIN NNEMEIEKIAF, INBBLDDKEIN JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8C90C30", Offset = "0x8C8FA30", VA = "0x188C90C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct HDHJBPNLPKA : IEquatable<HDHJBPNLPKA>, IComparable<HDHJBPNLPKA>, CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly HDHJBPNLPKA FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public HDHJBPNLPKA(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(HDHJBPNLPKA FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(HDHJBPNLPKA FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8C90300", Offset = "0x8C8F100", VA = "0x188C90300", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50")]
	public static bool IKIADGFKNFC(HDHJBPNLPKA NNEMEIEKIAF, HDHJBPNLPKA JOGLOLMOJGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8C903A0", Offset = "0x8C8F1A0", VA = "0x188C903A0")]
	public static bool GFAFFKCBFKA(HDHJBPNLPKA NNEMEIEKIAF, HDHJBPNLPKA JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8C903D0", Offset = "0x8C8F1D0", VA = "0x188C903D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IEEPKIHFMCL : IEquatable<IEEPKIHFMCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? PDGNBOCCBMC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C908B0", Offset = "0x8C8F6B0", VA = "0x188C908B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int GFMBEAEGLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5718870", Offset = "0x5717670", VA = "0x185718870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8C909C0", Offset = "0x8C8F7C0", VA = "0x188C909C0")]
	public IEEPKIHFMCL(string? IENBPEIGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8C90B10", Offset = "0x8C8F910", VA = "0x188C90B10")]
	public IEEPKIHFMCL(string?[] KIDNNEPOGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8C90680", Offset = "0x8C8F480", VA = "0x188C90680")]
	private static string?[]? JIHJLAMEHGN(string?[]? KIDNNEPOGEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8C908D0", Offset = "0x8C8F6D0", VA = "0x188C908D0")]
	public string PHBBEEAKMCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8C904D0", Offset = "0x8C8F2D0", VA = "0x188C904D0", Slot = "4")]
	public bool Equals(IEEPKIHFMCL FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8C90440", Offset = "0x8C8F240", VA = "0x188C90440", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8C905A0", Offset = "0x8C8F3A0", VA = "0x188C905A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C90930", Offset = "0x8C8F730", VA = "0x188C90930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KEGLPJPCCOP : IEquatable<KEGLPJPCCOP>, IComparable<KEGLPJPCCOP>, CCCADGGIHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid NMEMPCKPCOG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
	public KEGLPJPCCOP(Guid NMEMPCKPCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
	public Guid NKCNCCPGDNO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5902D50", Offset = "0x5901B50", VA = "0x185902D50", Slot = "4")]
	public bool Equals(KEGLPJPCCOP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5902B20", Offset = "0x5901920", VA = "0x185902B20", Slot = "5")]
	public int CompareTo(KEGLPJPCCOP FGAEAFBDBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8C90DB0", Offset = "0x8C8FBB0", VA = "0x188C90DB0", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5902D30", Offset = "0x5901B30", VA = "0x185902D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8C90E50", Offset = "0x8C8FC50", VA = "0x188C90E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BMGIGODMMEP<TModern> : PJPPMPOCGHE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IMCGLGDDJJI(TModern JCIBDHEKJIB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CCCADGGIHHO
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid NKCNCCPGDNO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PJPPMPOCGHE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern HLBPINBEMGO(string JCIBDHEKJIB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NHIJPMINOCB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BMGIGODMMEP<MDLPHIOGMIH> BKHILPKNAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BMGIGODMMEP<JGBEJPGGFBH> APIOCIGKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BMGIGODMMEP<HDHJBPNLPKA> CBDJJPKEAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BMGIGODMMEP<NGBEPHHOLNP> ABFPMGGDMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BMGIGODMMEP<OEOJAONNJFH> FNMCMIHIDNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BMGIGODMMEP<INBBLDDKEIN> MGOJOCENAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BMGIGODMMEP<LCJKMECGKBD> AJJHIGINOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BMGIGODMMEP<NJKDBAMDGPL> IKILKMPDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LBKANNKDDHG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] LDIPLCPFDJD;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8C90EC0", Offset = "0x8C8FCC0", VA = "0x188C90EC0")]
	public static string[] AKLEKDJJJNH(string? IENBPEIGEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8C90F60", Offset = "0x8C8FD60", VA = "0x188C90F60")]
	public static string? NACECNKJNHI(string? DCAPIGMJMIJ)
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
