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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x8895370", Offset = "0x8893970", VA = "0x188895370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LMFLGOBIABL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LGGJGPOGIBH(KAMKFCKINLN FCHACHIDAGA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KAMKFCKINLN FJJOMODMCLM(string FCHACHIDAGA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KAMKFCKINLN : IEquatable<KAMKFCKINLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OLAHBCMDBEM MOIAGGGLILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ALBLDJNNKOA GMFCCEEPGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid BIJMOEKLIPJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MNFHFOFBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8894B70", Offset = "0x8893170", VA = "0x188894B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OIKKJMAOCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8894B40", Offset = "0x8893140", VA = "0x188894B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8895130", Offset = "0x8893730", VA = "0x188895130")]
	public KAMKFCKINLN(KAMKFCKINLN LJONCHAOFOA, [Optional] Guid BCMAFCIPNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2D90", Offset = "0x5EE1390", VA = "0x185EE2D90")]
	public KAMKFCKINLN(OLAHBCMDBEM KBPGIMIOBMD, ALBLDJNNKOA MMCBDBNCDKN, [Optional] Guid BCMAFCIPNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8894C00", Offset = "0x8893200", VA = "0x188894C00", Slot = "4")]
	public bool Equals(KAMKFCKINLN HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8894CC0", Offset = "0x88932C0", VA = "0x188894CC0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8894D70", Offset = "0x8893370", VA = "0x188894D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8894E00", Offset = "0x8893400", VA = "0x188894E00")]
	public static bool JKIBMILPCGE(KAMKFCKINLN DBDIOGELIIH, KAMKFCKINLN LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8894E30", Offset = "0x8893430", VA = "0x188894E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OLAHBCMDBEM : IEquatable<OLAHBCMDBEM>, IComparable<OLAHBCMDBEM>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly OLAHBCMDBEM PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public OLAHBCMDBEM(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(OLAHBCMDBEM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(OLAHBCMDBEM HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8895500", Offset = "0x8893B00", VA = "0x188895500", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(OLAHBCMDBEM DBDIOGELIIH, OLAHBCMDBEM LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(OLAHBCMDBEM DBDIOGELIIH, OLAHBCMDBEM LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x88955A0", Offset = "0x8893BA0", VA = "0x1888955A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KALEKLMDJOG : IEquatable<KALEKLMDJOG>, IComparable<KALEKLMDJOG>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly KALEKLMDJOG PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public KALEKLMDJOG(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(KALEKLMDJOG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(KALEKLMDJOG HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8894A30", Offset = "0x8893030", VA = "0x188894A30", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(KALEKLMDJOG DBDIOGELIIH, KALEKLMDJOG LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(KALEKLMDJOG DBDIOGELIIH, KALEKLMDJOG LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8894AD0", Offset = "0x88930D0", VA = "0x188894AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KFDECOOHAKA : IEquatable<KFDECOOHAKA>, IComparable<KFDECOOHAKA>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly KFDECOOHAKA PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public KFDECOOHAKA(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(KFDECOOHAKA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(KFDECOOHAKA HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8895150", Offset = "0x8893750", VA = "0x188895150", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(KFDECOOHAKA DBDIOGELIIH, KFDECOOHAKA LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(KFDECOOHAKA DBDIOGELIIH, KFDECOOHAKA LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88951F0", Offset = "0x88937F0", VA = "0x1888951F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct ALBLDJNNKOA : IEquatable<ALBLDJNNKOA>, IComparable<ALBLDJNNKOA>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly ALBLDJNNKOA PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public ALBLDJNNKOA(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8893CA0", Offset = "0x88922A0", VA = "0x188893CA0", Slot = "4")]
	public bool Equals(ALBLDJNNKOA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8893CD0", Offset = "0x88922D0", VA = "0x188893CD0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8893CA0", Offset = "0x88922A0", VA = "0x188893CA0")]
	public static bool JKIBMILPCGE(ALBLDJNNKOA DBDIOGELIIH, ALBLDJNNKOA LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8893D70", Offset = "0x8892370", VA = "0x188893D70")]
	public static bool FLMCEAOBGCC(ALBLDJNNKOA DBDIOGELIIH, ALBLDJNNKOA LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(ALBLDJNNKOA HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8893DA0", Offset = "0x88923A0", VA = "0x188893DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public ALBLDJNNKOA(OCELNMNLIHE LCDJNLHGEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct KKEJCONAAEL : IEquatable<KKEJCONAAEL>, IComparable<KKEJCONAAEL>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly KKEJCONAAEL PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public KKEJCONAAEL(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(KKEJCONAAEL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(KKEJCONAAEL HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8895260", Offset = "0x8893860", VA = "0x188895260", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(KKEJCONAAEL DBDIOGELIIH, KKEJCONAAEL LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(KKEJCONAAEL DBDIOGELIIH, KKEJCONAAEL LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8895300", Offset = "0x8893900", VA = "0x188895300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HBMNJKGCEPD : IEquatable<HBMNJKGCEPD>, IComparable<HBMNJKGCEPD>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly HBMNJKGCEPD PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public HBMNJKGCEPD(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(HBMNJKGCEPD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(HBMNJKGCEPD HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8894810", Offset = "0x8892E10", VA = "0x188894810", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(HBMNJKGCEPD DBDIOGELIIH, HBMNJKGCEPD LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(HBMNJKGCEPD DBDIOGELIIH, HBMNJKGCEPD LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88948B0", Offset = "0x8892EB0", VA = "0x1888948B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BNGLIJOIOAL : IEquatable<BNGLIJOIOAL>, IComparable<BNGLIJOIOAL>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BNGLIJOIOAL PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public BNGLIJOIOAL(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(BNGLIJOIOAL HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(BNGLIJOIOAL HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8893E10", Offset = "0x8892410", VA = "0x188893E10", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(BNGLIJOIOAL DBDIOGELIIH, BNGLIJOIOAL LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(BNGLIJOIOAL DBDIOGELIIH, BNGLIJOIOAL LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8893EE0", Offset = "0x88924E0", VA = "0x188893EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct JJDBFDPKIAI : IEquatable<JJDBFDPKIAI>, IComparable<JJDBFDPKIAI>, FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JJDBFDPKIAI PBMJKPJDLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public JJDBFDPKIAI(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(JJDBFDPKIAI HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(JJDBFDPKIAI HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8894920", Offset = "0x8892F20", VA = "0x188894920", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0")]
	public static bool JKIBMILPCGE(JJDBFDPKIAI DBDIOGELIIH, JJDBFDPKIAI LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8893EB0", Offset = "0x88924B0", VA = "0x188893EB0")]
	public static bool FLMCEAOBGCC(JJDBFDPKIAI DBDIOGELIIH, JJDBFDPKIAI LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x88949C0", Offset = "0x8892FC0", VA = "0x1888949C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DJFEEPGNCGI : IEquatable<DJFEEPGNCGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? OBCHFMOIBOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NGPOKKIJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8894420", Offset = "0x8892A20", VA = "0x188894420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NJAAJALGFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5317FE0", Offset = "0x53165E0", VA = "0x185317FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x88944D0", Offset = "0x8892AD0", VA = "0x1888944D0")]
	public DJFEEPGNCGI(string? ENKEHMEPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8894620", Offset = "0x8892C20", VA = "0x188894620")]
	public DJFEEPGNCGI(string?[] OAHEADDKHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88941F0", Offset = "0x88927F0", VA = "0x1888941F0")]
	private static string?[]? HPDMOFPFBFN(string?[]? OAHEADDKHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8893F50", Offset = "0x8892550", VA = "0x188893F50")]
	public string CMJLDMFIMIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8894040", Offset = "0x8892640", VA = "0x188894040", Slot = "4")]
	public bool Equals(DJFEEPGNCGI HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8893FB0", Offset = "0x88925B0", VA = "0x188893FB0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8894110", Offset = "0x8892710", VA = "0x188894110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8894440", Offset = "0x8892A40", VA = "0x188894440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OCELNMNLIHE : IEquatable<OCELNMNLIHE>, IComparable<OCELNMNLIHE>, FOAALLIHHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid PPIICOOCLEP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
	public OCELNMNLIHE(Guid PPIICOOCLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
	public Guid BOIIJAKDNPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56077B0", Offset = "0x5605DB0", VA = "0x1856077B0", Slot = "4")]
	public bool Equals(OCELNMNLIHE HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56077E0", Offset = "0x5605DE0", VA = "0x1856077E0", Slot = "5")]
	public int CompareTo(OCELNMNLIHE HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88953F0", Offset = "0x88939F0", VA = "0x1888953F0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5607B20", Offset = "0x5606120", VA = "0x185607B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8895490", Offset = "0x8893A90", VA = "0x188895490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LNCPLAGEFJB<TModern> : PBBIFILNFDK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MBDCFDHDICE(TModern LLBJLPONEAN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FOAALLIHHLC
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BOIIJAKDNPH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PBBIFILNFDK<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern CKHPDLDPCMG(string LLBJLPONEAN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LGKJIPCELAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LNCPLAGEFJB<OLAHBCMDBEM> PLGGIFKGMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LNCPLAGEFJB<KKEJCONAAEL> MDAABHGCNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LNCPLAGEFJB<JJDBFDPKIAI> LFDFGIEFOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LNCPLAGEFJB<ALBLDJNNKOA> IJHILMEKODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LNCPLAGEFJB<KFDECOOHAKA> DDNJAJMDILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LNCPLAGEFJB<BNGLIJOIOAL> HFBGFNBNGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LNCPLAGEFJB<KALEKLMDJOG> FKCKNAFEKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LNCPLAGEFJB<HBMNJKGCEPD> LBODMGANCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FJCBBHNJLMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] GOAIBKPKIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88946D0", Offset = "0x8892CD0", VA = "0x1888946D0")]
	public static string[] PEODOINILJM(string? ENKEHMEPICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x88946A0", Offset = "0x8892CA0", VA = "0x1888946A0")]
	public static string? FPEBGPDKFCE(string? KBPGIMIOBMD)
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
