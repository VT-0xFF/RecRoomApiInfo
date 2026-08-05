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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x751E900", Offset = "0x751DD00", VA = "0x18751E900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BDMKBGHDDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IFDLICGNEEM(OGJHNDNNOJI EBJHHBADCKF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OGJHNDNNOJI AJCCBGLJAMD(string EBJHHBADCKF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct OGJHNDNNOJI : IEquatable<OGJHNDNNOJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KMLPKJNOABE IONAKPEMONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MHELINGPEEM BOFIKOLHFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid OBECHJDDHMG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KIHAGKGHDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x751EAA0", Offset = "0x751DEA0", VA = "0x18751EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HBGKGHFLMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x751ED70", Offset = "0x751E170", VA = "0x18751ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x751F0F0", Offset = "0x751E4F0", VA = "0x18751F0F0")]
	public OGJHNDNNOJI(OGJHNDNNOJI BDOPOIAAPNI, [Optional] Guid DFOFCJFKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5068600", Offset = "0x5067A00", VA = "0x185068600")]
	public OGJHNDNNOJI(KMLPKJNOABE PKPAINDLBBJ, MHELINGPEEM KFNDCDGPPNJ, [Optional] Guid DFOFCJFKCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x751EB70", Offset = "0x751DF70", VA = "0x18751EB70", Slot = "4")]
	public bool Equals(OGJHNDNNOJI KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x751EC30", Offset = "0x751E030", VA = "0x18751EC30", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x751ECE0", Offset = "0x751E0E0", VA = "0x18751ECE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x751EDB0", Offset = "0x751E1B0", VA = "0x18751EDB0")]
	public static bool LBFMGPFDJNL(OGJHNDNNOJI OPJKGPJPNJJ, OGJHNDNNOJI EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x751EB30", Offset = "0x751DF30", VA = "0x18751EB30")]
	public static bool CJIGOGHINMG(OGJHNDNNOJI OPJKGPJPNJJ, OGJHNDNNOJI EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x751EDE0", Offset = "0x751E1E0", VA = "0x18751EDE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KMLPKJNOABE : IEquatable<KMLPKJNOABE>, IComparable<KMLPKJNOABE>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KMLPKJNOABE JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public KMLPKJNOABE(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(KMLPKJNOABE KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(KMLPKJNOABE KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x751E500", Offset = "0x751D900", VA = "0x18751E500", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(KMLPKJNOABE OPJKGPJPNJJ, KMLPKJNOABE EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(KMLPKJNOABE OPJKGPJPNJJ, KMLPKJNOABE EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x751E5B0", Offset = "0x751D9B0", VA = "0x18751E5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FOOMCMODIOE : IEquatable<FOOMCMODIOE>, IComparable<FOOMCMODIOE>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly FOOMCMODIOE JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public FOOMCMODIOE(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(FOOMCMODIOE KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(FOOMCMODIOE KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x751E2C0", Offset = "0x751D6C0", VA = "0x18751E2C0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(FOOMCMODIOE OPJKGPJPNJJ, FOOMCMODIOE EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(FOOMCMODIOE OPJKGPJPNJJ, FOOMCMODIOE EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x751E370", Offset = "0x751D770", VA = "0x18751E370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DJNGKLBNCHI : IEquatable<DJNGKLBNCHI>, IComparable<DJNGKLBNCHI>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly DJNGKLBNCHI JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public DJNGKLBNCHI(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(DJNGKLBNCHI KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(DJNGKLBNCHI KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x751DA50", Offset = "0x751CE50", VA = "0x18751DA50", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(DJNGKLBNCHI OPJKGPJPNJJ, DJNGKLBNCHI EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(DJNGKLBNCHI OPJKGPJPNJJ, DJNGKLBNCHI EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x751DB00", Offset = "0x751CF00", VA = "0x18751DB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MHELINGPEEM : IEquatable<MHELINGPEEM>, IComparable<MHELINGPEEM>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly MHELINGPEEM JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public MHELINGPEEM(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x751E700", Offset = "0x751DB00", VA = "0x18751E700", Slot = "4")]
	public bool Equals(MHELINGPEEM KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x751E650", Offset = "0x751DA50", VA = "0x18751E650", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x751E700", Offset = "0x751DB00", VA = "0x18751E700")]
	public static bool LBFMGPFDJNL(MHELINGPEEM OPJKGPJPNJJ, MHELINGPEEM EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x751E620", Offset = "0x751DA20", VA = "0x18751E620")]
	public static bool CJIGOGHINMG(MHELINGPEEM OPJKGPJPNJJ, MHELINGPEEM EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(MHELINGPEEM KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x751E730", Offset = "0x751DB30", VA = "0x18751E730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public MHELINGPEEM(JFGBHIFLIEJ LAIKLPBEMNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct CKOBIDCKFAM : IEquatable<CKOBIDCKFAM>, IComparable<CKOBIDCKFAM>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly CKOBIDCKFAM JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public CKOBIDCKFAM(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(CKOBIDCKFAM KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(CKOBIDCKFAM KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x751D930", Offset = "0x751CD30", VA = "0x18751D930", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(CKOBIDCKFAM OPJKGPJPNJJ, CKOBIDCKFAM EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(CKOBIDCKFAM OPJKGPJPNJJ, CKOBIDCKFAM EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x751D9E0", Offset = "0x751CDE0", VA = "0x18751D9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OBBAPCJJCDJ : IEquatable<OBBAPCJJCDJ>, IComparable<OBBAPCJJCDJ>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly OBBAPCJJCDJ JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public OBBAPCJJCDJ(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(OBBAPCJJCDJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(OBBAPCJJCDJ KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x751E980", Offset = "0x751DD80", VA = "0x18751E980", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(OBBAPCJJCDJ OPJKGPJPNJJ, OBBAPCJJCDJ EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(OBBAPCJJCDJ OPJKGPJPNJJ, OBBAPCJJCDJ EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x751EA30", Offset = "0x751DE30", VA = "0x18751EA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct APNMOAFPJAL : IEquatable<APNMOAFPJAL>, IComparable<APNMOAFPJAL>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly APNMOAFPJAL JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public APNMOAFPJAL(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(APNMOAFPJAL KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(APNMOAFPJAL KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x751D810", Offset = "0x751CC10", VA = "0x18751D810", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(APNMOAFPJAL OPJKGPJPNJJ, APNMOAFPJAL EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(APNMOAFPJAL OPJKGPJPNJJ, APNMOAFPJAL EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x751D8C0", Offset = "0x751CCC0", VA = "0x18751D8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PJEMGANEAJB : IEquatable<PJEMGANEAJB>, IComparable<PJEMGANEAJB>, JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PJEMGANEAJB JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public PJEMGANEAJB(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(PJEMGANEAJB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(PJEMGANEAJB KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x751F110", Offset = "0x751E510", VA = "0x18751F110", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0")]
	public static bool LBFMGPFDJNL(PJEMGANEAJB OPJKGPJPNJJ, PJEMGANEAJB EANFIEEELEJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x751D7E0", Offset = "0x751CBE0", VA = "0x18751D7E0")]
	public static bool CJIGOGHINMG(PJEMGANEAJB OPJKGPJPNJJ, PJEMGANEAJB EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x751F1C0", Offset = "0x751E5C0", VA = "0x18751F1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ECPOMHDNIMA : IEquatable<ECPOMHDNIMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? HNMDKJIMEAG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x751DB70", Offset = "0x751CF70", VA = "0x18751DB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int PJJPBLHNEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x44B7980", Offset = "0x44B6D80", VA = "0x1844B7980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x751E170", Offset = "0x751D570", VA = "0x18751E170")]
	public ECPOMHDNIMA(string? EGCNHFCGMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x751E0F0", Offset = "0x751D4F0", VA = "0x18751E0F0")]
	public ECPOMHDNIMA(string?[] OMFJPOFAJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x751DB90", Offset = "0x751CF90", VA = "0x18751DB90")]
	private static string?[]? DKOGLFEGNOD(string?[]? OMFJPOFAJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x751DF20", Offset = "0x751D320", VA = "0x18751DF20")]
	public string GDGPCBFOEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x751DDC0", Offset = "0x751D1C0", VA = "0x18751DDC0", Slot = "4")]
	public bool Equals(ECPOMHDNIMA KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x751DE90", Offset = "0x751D290", VA = "0x18751DE90", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x751DF80", Offset = "0x751D380", VA = "0x18751DF80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x751E060", Offset = "0x751D460", VA = "0x18751E060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JFGBHIFLIEJ : IEquatable<JFGBHIFLIEJ>, IComparable<JFGBHIFLIEJ>, JEBNHHNAHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid GPJCGLBMIBA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
	public JFGBHIFLIEJ(Guid GPJCGLBMIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public Guid IHBNMPBNHCB()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A5D0", Offset = "0x4A099D0", VA = "0x184A0A5D0", Slot = "4")]
	public bool Equals(JFGBHIFLIEJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A2F0", Offset = "0x4A096F0", VA = "0x184A0A2F0", Slot = "5")]
	public int CompareTo(JFGBHIFLIEJ KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x751E3E0", Offset = "0x751D7E0", VA = "0x18751E3E0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A400", Offset = "0x4A09800", VA = "0x184A0A400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x751E490", Offset = "0x751D890", VA = "0x18751E490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IMGPDDOFEAJ<TModern> : OLMINHHLPOB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GCOLKKAPAHK(TModern HFDIDKGGCGI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JEBNHHNAHFI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid IHBNMPBNHCB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OLMINHHLPOB<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern MMKOIJHHGFI(string HFDIDKGGCGI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HBJEJEFHOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IMGPDDOFEAJ<KMLPKJNOABE> DGIJHCKLJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IMGPDDOFEAJ<CKOBIDCKFAM> ECICGHDPDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IMGPDDOFEAJ<PJEMGANEAJB> DFBOPFEKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IMGPDDOFEAJ<MHELINGPEEM> GPAJPGCDAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IMGPDDOFEAJ<DJNGKLBNCHI> IPNDHKDPADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IMGPDDOFEAJ<APNMOAFPJAL> PIIONEIOKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IMGPDDOFEAJ<FOOMCMODIOE> PABOBBPDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IMGPDDOFEAJ<OBBAPCJJCDJ> EGOMAHDCHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NOACJBGFGPP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] MJJIMNPAHBK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x751E7D0", Offset = "0x751DBD0", VA = "0x18751E7D0")]
	public static string[] IMABPOAEDGK(string? EGCNHFCGMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x751E7A0", Offset = "0x751DBA0", VA = "0x18751E7A0")]
	public static string? AJOGIJOONEL(string? PKPAINDLBBJ)
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
