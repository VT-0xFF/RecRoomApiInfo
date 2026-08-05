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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x869ED40", Offset = "0x869D940", VA = "0x18869ED40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JHHKNMPBHLE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BLPDEIDOFHH(GOFJDLJJOJL OLMHJMNEENP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GOFJDLJJOJL EBAGJKMAFHO(string OLMHJMNEENP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GOFJDLJJOJL : IEquatable<GOFJDLJJOJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LFHPPJPAHAE JPHNEDJIKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PLMOHPIJHDA BCEHNMMLOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid FDLNECPNHCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ODEFPJJGAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x869E550", Offset = "0x869D150", VA = "0x18869E550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NGOAPMCDHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x869E4F0", Offset = "0x869D0F0", VA = "0x18869E4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x869E8E0", Offset = "0x869D4E0", VA = "0x18869E8E0")]
	public GOFJDLJJOJL(GOFJDLJJOJL GGKADFBOLHI, [Optional] Guid BONHDLJDKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE3E0", Offset = "0x5DBCFE0", VA = "0x185DBE3E0")]
	public GOFJDLJJOJL(LFHPPJPAHAE EGLPIFKMHOI, PLMOHPIJHDA ADCGAKKPLCC, [Optional] Guid BONHDLJDKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x869E2F0", Offset = "0x869CEF0", VA = "0x18869E2F0", Slot = "4")]
	public bool Equals(GOFJDLJJOJL GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x869E3B0", Offset = "0x869CFB0", VA = "0x18869E3B0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x869E460", Offset = "0x869D060", VA = "0x18869E460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x869E520", Offset = "0x869D120", VA = "0x18869E520")]
	public static bool JOHLOKGLNML(GOFJDLJJOJL NAHMIIJKKEL, GOFJDLJJOJL IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x869E5E0", Offset = "0x869D1E0", VA = "0x18869E5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LFHPPJPAHAE : IEquatable<LFHPPJPAHAE>, IComparable<LFHPPJPAHAE>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly LFHPPJPAHAE LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public LFHPPJPAHAE(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(LFHPPJPAHAE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(LFHPPJPAHAE GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x869EA10", Offset = "0x869D610", VA = "0x18869EA10", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(LFHPPJPAHAE NAHMIIJKKEL, LFHPPJPAHAE IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(LFHPPJPAHAE NAHMIIJKKEL, LFHPPJPAHAE IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x869EAB0", Offset = "0x869D6B0", VA = "0x18869EAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LIEKGDGCODL : IEquatable<LIEKGDGCODL>, IComparable<LIEKGDGCODL>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly LIEKGDGCODL LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public LIEKGDGCODL(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(LIEKGDGCODL GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(LIEKGDGCODL GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x869EB20", Offset = "0x869D720", VA = "0x18869EB20", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(LIEKGDGCODL NAHMIIJKKEL, LIEKGDGCODL IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(LIEKGDGCODL NAHMIIJKKEL, LIEKGDGCODL IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x869EBC0", Offset = "0x869D7C0", VA = "0x18869EBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MIAOGILCLPA : IEquatable<MIAOGILCLPA>, IComparable<MIAOGILCLPA>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly MIAOGILCLPA LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public MIAOGILCLPA(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(MIAOGILCLPA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(MIAOGILCLPA GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x869EC30", Offset = "0x869D830", VA = "0x18869EC30", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(MIAOGILCLPA NAHMIIJKKEL, MIAOGILCLPA IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(MIAOGILCLPA NAHMIIJKKEL, MIAOGILCLPA IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x869ECD0", Offset = "0x869D8D0", VA = "0x18869ECD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PLMOHPIJHDA : IEquatable<PLMOHPIJHDA>, IComparable<PLMOHPIJHDA>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly PLMOHPIJHDA LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public PLMOHPIJHDA(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x869F030", Offset = "0x869DC30", VA = "0x18869F030", Slot = "4")]
	public bool Equals(PLMOHPIJHDA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x869F060", Offset = "0x869DC60", VA = "0x18869F060", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x869F030", Offset = "0x869DC30", VA = "0x18869F030")]
	public static bool JOHLOKGLNML(PLMOHPIJHDA NAHMIIJKKEL, PLMOHPIJHDA IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x869F100", Offset = "0x869DD00", VA = "0x18869F100")]
	public static bool FOFOJFKGMNN(PLMOHPIJHDA NAHMIIJKKEL, PLMOHPIJHDA IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(PLMOHPIJHDA GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x869F130", Offset = "0x869DD30", VA = "0x18869F130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public PLMOHPIJHDA(CDCLKPOEAAO HBBBEFNJPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OAMJPCIHGNE : IEquatable<OAMJPCIHGNE>, IComparable<OAMJPCIHGNE>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly OAMJPCIHGNE LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public OAMJPCIHGNE(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(OAMJPCIHGNE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(OAMJPCIHGNE GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x869EDC0", Offset = "0x869D9C0", VA = "0x18869EDC0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(OAMJPCIHGNE NAHMIIJKKEL, OAMJPCIHGNE IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(OAMJPCIHGNE NAHMIIJKKEL, OAMJPCIHGNE IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x869EE60", Offset = "0x869DA60", VA = "0x18869EE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DOLBAFHNJDK : IEquatable<DOLBAFHNJDK>, IComparable<DOLBAFHNJDK>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DOLBAFHNJDK LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public DOLBAFHNJDK(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(DOLBAFHNJDK GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(DOLBAFHNJDK GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x869E1E0", Offset = "0x869CDE0", VA = "0x18869E1E0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(DOLBAFHNJDK NAHMIIJKKEL, DOLBAFHNJDK IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(DOLBAFHNJDK NAHMIIJKKEL, DOLBAFHNJDK IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x869E280", Offset = "0x869CE80", VA = "0x18869E280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct ANPCAKLHJAE : IEquatable<ANPCAKLHJAE>, IComparable<ANPCAKLHJAE>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly ANPCAKLHJAE LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public ANPCAKLHJAE(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(ANPCAKLHJAE GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(ANPCAKLHJAE GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x869D840", Offset = "0x869C440", VA = "0x18869D840", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(ANPCAKLHJAE NAHMIIJKKEL, ANPCAKLHJAE IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(ANPCAKLHJAE NAHMIIJKKEL, ANPCAKLHJAE IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x869D910", Offset = "0x869C510", VA = "0x18869D910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KIGICGBMFCD : IEquatable<KIGICGBMFCD>, IComparable<KIGICGBMFCD>, BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly KIGICGBMFCD LELJIFADAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public KIGICGBMFCD(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(KIGICGBMFCD GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(KIGICGBMFCD GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x869E900", Offset = "0x869D500", VA = "0x18869E900", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10")]
	public static bool JOHLOKGLNML(KIGICGBMFCD NAHMIIJKKEL, KIGICGBMFCD IJNKBHOINCA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x869D8E0", Offset = "0x869C4E0", VA = "0x18869D8E0")]
	public static bool FOFOJFKGMNN(KIGICGBMFCD NAHMIIJKKEL, KIGICGBMFCD IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x869E9A0", Offset = "0x869D5A0", VA = "0x18869E9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct CIDEIGJIEDC : IEquatable<CIDEIGJIEDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? HFPPPGFJJEA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x869DCD0", Offset = "0x869C8D0", VA = "0x18869DCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LDMOADDNKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5376500", Offset = "0x5375100", VA = "0x185376500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x869E010", Offset = "0x869CC10", VA = "0x18869E010")]
	public CIDEIGJIEDC(string? OPNGJJGDCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x869E160", Offset = "0x869CD60", VA = "0x18869E160")]
	public CIDEIGJIEDC(string?[] KALLEFNCFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x869DD50", Offset = "0x869C950", VA = "0x18869DD50")]
	private static string?[]? IJFJGNGLIBG(string?[]? KALLEFNCFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x869DCF0", Offset = "0x869C8F0", VA = "0x18869DCF0")]
	public string HLNFNMONGHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x869DA90", Offset = "0x869C690", VA = "0x18869DA90", Slot = "4")]
	public bool Equals(CIDEIGJIEDC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x869DB60", Offset = "0x869C760", VA = "0x18869DB60", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x869DBF0", Offset = "0x869C7F0", VA = "0x18869DBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x869DF80", Offset = "0x869CB80", VA = "0x18869DF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CDCLKPOEAAO : IEquatable<CDCLKPOEAAO>, IComparable<CDCLKPOEAAO>, BFLKHIBEHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid LHECJJHBNHF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
	public CDCLKPOEAAO(Guid LHECJJHBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
	public Guid CNDLLLBCKEA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6486F10", Offset = "0x6485B10", VA = "0x186486F10", Slot = "4")]
	public bool Equals(CDCLKPOEAAO GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6486FE0", Offset = "0x6485BE0", VA = "0x186486FE0", Slot = "5")]
	public int CompareTo(CDCLKPOEAAO GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x869D980", Offset = "0x869C580", VA = "0x18869D980", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6487300", Offset = "0x6485F00", VA = "0x186487300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x869DA20", Offset = "0x869C620", VA = "0x18869DA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IINBGDLEBFP<TModern> : CEBFJKJADFE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EJIAKFINFGF(TModern HAPEPJLLHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BFLKHIBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CNDLLLBCKEA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CEBFJKJADFE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern HFBJLOKDJJF(string HAPEPJLLHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MCAHKOEDIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IINBGDLEBFP<LFHPPJPAHAE> ALDFFJCLICN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IINBGDLEBFP<OAMJPCIHGNE> KCLNIBABKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IINBGDLEBFP<KIGICGBMFCD> PGHKBHCFBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IINBGDLEBFP<PLMOHPIJHDA> CGIJDOKONCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IINBGDLEBFP<MIAOGILCLPA> INBAKAPMEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IINBGDLEBFP<ANPCAKLHJAE> OHNKKCGADHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IINBGDLEBFP<LIEKGDGCODL> JEKLHNCMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IINBGDLEBFP<DOLBAFHNJDK> EPMFBGHGKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ONLKBCDDDFA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] BFKFMONLGBN;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x869EED0", Offset = "0x869DAD0", VA = "0x18869EED0")]
	public static string[] KODENMMKNOK(string? OPNGJJGDCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x869EF70", Offset = "0x869DB70", VA = "0x18869EF70")]
	public static string? NDIPMIHBFAE(string? EGLPIFKMHOI)
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
