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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7094E40", Offset = "0x7093E40", VA = "0x187094E40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LHNDICIABLH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JMNIMAIKKED(MEDGMGIADBO MIFEONEPPKP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEDGMGIADBO PPFECFLIGJE(string MIFEONEPPKP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MEDGMGIADBO : IEquatable<MEDGMGIADBO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DBLDAMEGANG POHOLOPDHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HAADOMONODM JCMFAIGBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid JKHAPLCFPBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AAGFGBNOGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7094150", Offset = "0x7093150", VA = "0x187094150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FDJHMPCHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7094110", Offset = "0x7093110", VA = "0x187094110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70945B0", Offset = "0x70935B0", VA = "0x1870945B0")]
	public MEDGMGIADBO(MEDGMGIADBO BGMDGNMKOEA, [Optional] Guid ODFDMKOEKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CE79B0", Offset = "0x4CE69B0", VA = "0x184CE79B0")]
	public MEDGMGIADBO(DBLDAMEGANG GHFPJGKCCOJ, HAADOMONODM ICBODFKDBAJ, [Optional] Guid ODFDMKOEKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7094050", Offset = "0x7093050", VA = "0x187094050", Slot = "4")]
	public bool Equals(MEDGMGIADBO ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7093FA0", Offset = "0x7092FA0", VA = "0x187093FA0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70941E0", Offset = "0x70931E0", VA = "0x1870941E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7094270", Offset = "0x7093270", VA = "0x187094270")]
	public static bool MKBCGNPIJEJ(MEDGMGIADBO OHFIHFHICKK, MEDGMGIADBO CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x70942A0", Offset = "0x70932A0", VA = "0x1870942A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DBLDAMEGANG : IEquatable<DBLDAMEGANG>, IComparable<DBLDAMEGANG>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly DBLDAMEGANG MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public DBLDAMEGANG(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(DBLDAMEGANG ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(DBLDAMEGANG ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7093950", Offset = "0x7092950", VA = "0x187093950", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(DBLDAMEGANG OHFIHFHICKK, DBLDAMEGANG CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(DBLDAMEGANG OHFIHFHICKK, DBLDAMEGANG CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7093A00", Offset = "0x7092A00", VA = "0x187093A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HDPDBHKAGDO : IEquatable<HDPDBHKAGDO>, IComparable<HDPDBHKAGDO>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly HDPDBHKAGDO MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public HDPDBHKAGDO(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(HDPDBHKAGDO ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(HDPDBHKAGDO ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7093D10", Offset = "0x7092D10", VA = "0x187093D10", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(HDPDBHKAGDO OHFIHFHICKK, HDPDBHKAGDO CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(HDPDBHKAGDO OHFIHFHICKK, HDPDBHKAGDO CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7093DC0", Offset = "0x7092DC0", VA = "0x187093DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ALFCGNBGPAB : IEquatable<ALFCGNBGPAB>, IComparable<ALFCGNBGPAB>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly ALFCGNBGPAB MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public ALFCGNBGPAB(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(ALFCGNBGPAB ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(ALFCGNBGPAB ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70936E0", Offset = "0x70926E0", VA = "0x1870936E0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(ALFCGNBGPAB OHFIHFHICKK, ALFCGNBGPAB CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(ALFCGNBGPAB OHFIHFHICKK, ALFCGNBGPAB CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70937C0", Offset = "0x70927C0", VA = "0x1870937C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HAADOMONODM : IEquatable<HAADOMONODM>, IComparable<HAADOMONODM>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly HAADOMONODM MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public HAADOMONODM(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7093B90", Offset = "0x7092B90", VA = "0x187093B90", Slot = "4")]
	public bool Equals(HAADOMONODM ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7093BC0", Offset = "0x7092BC0", VA = "0x187093BC0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7093B90", Offset = "0x7092B90", VA = "0x187093B90")]
	public static bool MKBCGNPIJEJ(HAADOMONODM OHFIHFHICKK, HAADOMONODM CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7093C70", Offset = "0x7092C70", VA = "0x187093C70")]
	public static bool KGBNGOIDAMB(HAADOMONODM OHFIHFHICKK, HAADOMONODM CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(HAADOMONODM ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7093CA0", Offset = "0x7092CA0", VA = "0x187093CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public HAADOMONODM(PHJCKKDBEEC PFNAMAHGCON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BLEINJLNGIP : IEquatable<BLEINJLNGIP>, IComparable<BLEINJLNGIP>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly BLEINJLNGIP MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public BLEINJLNGIP(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(BLEINJLNGIP ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(BLEINJLNGIP ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7093830", Offset = "0x7092830", VA = "0x187093830", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(BLEINJLNGIP OHFIHFHICKK, BLEINJLNGIP CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(BLEINJLNGIP OHFIHFHICKK, BLEINJLNGIP CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70938E0", Offset = "0x70928E0", VA = "0x1870938E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DFGLBGMNOFH : IEquatable<DFGLBGMNOFH>, IComparable<DFGLBGMNOFH>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DFGLBGMNOFH MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public DFGLBGMNOFH(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(DFGLBGMNOFH ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(DFGLBGMNOFH ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7093A70", Offset = "0x7092A70", VA = "0x187093A70", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(DFGLBGMNOFH OHFIHFHICKK, DFGLBGMNOFH CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(DFGLBGMNOFH OHFIHFHICKK, DFGLBGMNOFH CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7093B20", Offset = "0x7092B20", VA = "0x187093B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct NHJGDHBOFPL : IEquatable<NHJGDHBOFPL>, IComparable<NHJGDHBOFPL>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NHJGDHBOFPL MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public NHJGDHBOFPL(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(NHJGDHBOFPL ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(NHJGDHBOFPL ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7094D20", Offset = "0x7093D20", VA = "0x187094D20", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(NHJGDHBOFPL OHFIHFHICKK, NHJGDHBOFPL CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(NHJGDHBOFPL OHFIHFHICKK, NHJGDHBOFPL CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7094DD0", Offset = "0x7093DD0", VA = "0x187094DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OEAPDDDHGEN : IEquatable<OEAPDDDHGEN>, IComparable<OEAPDDDHGEN>, NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OEAPDDDHGEN MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public OEAPDDDHGEN(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(OEAPDDDHGEN ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(OEAPDDDHGEN ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7094EC0", Offset = "0x7093EC0", VA = "0x187094EC0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50")]
	public static bool MKBCGNPIJEJ(OEAPDDDHGEN OHFIHFHICKK, OEAPDDDHGEN CENGDJBMKEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7093790", Offset = "0x7092790", VA = "0x187093790")]
	public static bool KGBNGOIDAMB(OEAPDDDHGEN OHFIHFHICKK, OEAPDDDHGEN CENGDJBMKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7094F70", Offset = "0x7093F70", VA = "0x187094F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct NADJPEJAJKG : IEquatable<NADJPEJAJKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? CNHIPPJKOJB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7094AA0", Offset = "0x7093AA0", VA = "0x187094AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BFOBJEADKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x42B43D0", Offset = "0x42B33D0", VA = "0x1842B43D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7094BD0", Offset = "0x7093BD0", VA = "0x187094BD0")]
	public NADJPEJAJKG(string? GGDCGAJEHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7094B50", Offset = "0x7093B50", VA = "0x187094B50")]
	public NADJPEJAJKG(string?[] AFNOKLIHFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7094810", Offset = "0x7093810", VA = "0x187094810")]
	private static string?[]? IKLLNCKCKNM(string?[]? AFNOKLIHFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7094A40", Offset = "0x7093A40", VA = "0x187094A40")]
	public string JLPBOPFAAPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x70945D0", Offset = "0x70935D0", VA = "0x1870945D0", Slot = "4")]
	public bool Equals(NADJPEJAJKG ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70946A0", Offset = "0x70936A0", VA = "0x1870946A0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7094730", Offset = "0x7093730", VA = "0x187094730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7094AC0", Offset = "0x7093AC0", VA = "0x187094AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PHJCKKDBEEC : IEquatable<PHJCKKDBEEC>, IComparable<PHJCKKDBEEC>, NOOOIIHJIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid CNIMPJMOLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
	public PHJCKKDBEEC(Guid CNIMPJMOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
	public Guid IBBDNMEHGPF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B50", Offset = "0x44E5B50", VA = "0x1844E6B50", Slot = "4")]
	public bool Equals(PHJCKKDBEEC ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x44E6650", Offset = "0x44E5650", VA = "0x1844E6650", Slot = "5")]
	public int CompareTo(PHJCKKDBEEC ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7094FE0", Offset = "0x7093FE0", VA = "0x187094FE0", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x44E6760", Offset = "0x44E5760", VA = "0x1844E6760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7095090", Offset = "0x7094090", VA = "0x187095090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AGBAKLPNDKD<TModern> : HJHLPPBKBJE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BNANGAODHLJ(TModern OPBOMDNGKCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NOOOIIHJIEB
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid IBBDNMEHGPF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJHLPPBKBJE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern BPDPPFNOFOE(string OPBOMDNGKCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JKBNIMMMFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AGBAKLPNDKD<DBLDAMEGANG> ANBIKLABJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	AGBAKLPNDKD<BLEINJLNGIP> INIDJFIKMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	AGBAKLPNDKD<OEAPDDDHGEN> OBBJHMIFMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AGBAKLPNDKD<HAADOMONODM> JODLDIPMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AGBAKLPNDKD<ALFCGNBGPAB> EDFLMIMGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AGBAKLPNDKD<NHJGDHBOFPL> GBLKNGIPCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AGBAKLPNDKD<HDPDBHKAGDO> GNHFBJJEDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AGBAKLPNDKD<DFGLBGMNOFH> PPEIOINNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KLILNAMLLON
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] PDPMGOMKMDG;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7093E60", Offset = "0x7092E60", VA = "0x187093E60")]
	public static string[] EKIMIMAOCLI(string? GGDCGAJEHPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7093E30", Offset = "0x7092E30", VA = "0x187093E30")]
	public static string? CEGMEBJBJBE(string? GHFPJGKCCOJ)
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
