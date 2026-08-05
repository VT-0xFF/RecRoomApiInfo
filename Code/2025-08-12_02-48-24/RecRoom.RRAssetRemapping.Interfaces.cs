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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D83360", Offset = "0x8D81960", VA = "0x188D83360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OAGGKJEICID
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CAELEDFILEL(BDDFNOANCGH EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BDDFNOANCGH KJBCLIOBDIC(string EKNLPIEMHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BDDFNOANCGH : IEquatable<BDDFNOANCGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KFPCHIHLHJM GNBLJCPNAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PHJLLKHDGCC PMHCGIGALOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid HDOBIKLCIPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KPDHECMGFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D82160", Offset = "0x8D80760", VA = "0x188D82160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IPFJOPOGAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D821F0", Offset = "0x8D807F0", VA = "0x188D821F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8D82530", Offset = "0x8D80B30", VA = "0x188D82530")]
	public BDDFNOANCGH(BDDFNOANCGH BALAFJLKFGL, [Optional] Guid MECFNLMOEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62BF830", Offset = "0x62BDE30", VA = "0x1862BF830")]
	public BDDFNOANCGH(KFPCHIHLHJM NGIIDBPAAGG, PHJLLKHDGCC KDCFAPFANAI, [Optional] Guid MECFNLMOEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8D81FE0", Offset = "0x8D805E0", VA = "0x188D81FE0", Slot = "4")]
	public bool Equals(BDDFNOANCGH IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8D81F30", Offset = "0x8D80530", VA = "0x188D81F30", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8D820A0", Offset = "0x8D806A0", VA = "0x188D820A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8D82130", Offset = "0x8D80730", VA = "0x188D82130")]
	public static bool LMIMJGGKHMP(BDDFNOANCGH LEOAACGBJCD, BDDFNOANCGH GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8D82220", Offset = "0x8D80820", VA = "0x188D82220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KFPCHIHLHJM : IEquatable<KFPCHIHLHJM>, IComparable<KFPCHIHLHJM>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly KFPCHIHLHJM KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public KFPCHIHLHJM(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(KFPCHIHLHJM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(KFPCHIHLHJM IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8D83120", Offset = "0x8D81720", VA = "0x188D83120", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(KFPCHIHLHJM LEOAACGBJCD, KFPCHIHLHJM GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(KFPCHIHLHJM LEOAACGBJCD, KFPCHIHLHJM GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8D831D0", Offset = "0x8D817D0", VA = "0x188D831D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EKHGCOBGJHL : IEquatable<EKHGCOBGJHL>, IComparable<EKHGCOBGJHL>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly EKHGCOBGJHL KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public EKHGCOBGJHL(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(EKHGCOBGJHL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(EKHGCOBGJHL IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8D82DC0", Offset = "0x8D813C0", VA = "0x188D82DC0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(EKHGCOBGJHL LEOAACGBJCD, EKHGCOBGJHL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(EKHGCOBGJHL LEOAACGBJCD, EKHGCOBGJHL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8D82E70", Offset = "0x8D81470", VA = "0x188D82E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IDKLMMFDGOH : IEquatable<IDKLMMFDGOH>, IComparable<IDKLMMFDGOH>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly IDKLMMFDGOH KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public IDKLMMFDGOH(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(IDKLMMFDGOH IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(IDKLMMFDGOH IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8D83000", Offset = "0x8D81600", VA = "0x188D83000", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(IDKLMMFDGOH LEOAACGBJCD, IDKLMMFDGOH GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(IDKLMMFDGOH LEOAACGBJCD, IDKLMMFDGOH GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D830B0", Offset = "0x8D816B0", VA = "0x188D830B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PHJLLKHDGCC : IEquatable<PHJLLKHDGCC>, IComparable<PHJLLKHDGCC>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly PHJLLKHDGCC KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public PHJLLKHDGCC(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D83670", Offset = "0x8D81C70", VA = "0x188D83670", Slot = "4")]
	public bool Equals(PHJLLKHDGCC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D836A0", Offset = "0x8D81CA0", VA = "0x188D836A0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D83670", Offset = "0x8D81C70", VA = "0x188D83670")]
	public static bool LMIMJGGKHMP(PHJLLKHDGCC LEOAACGBJCD, PHJLLKHDGCC GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D83750", Offset = "0x8D81D50", VA = "0x188D83750")]
	public static bool PACMOMIAEBP(PHJLLKHDGCC LEOAACGBJCD, PHJLLKHDGCC GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(PHJLLKHDGCC IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D83780", Offset = "0x8D81D80", VA = "0x188D83780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public PHJLLKHDGCC(PDLCHNHKPHL ILIGFFPICHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AKEMAGKCEEL : IEquatable<AKEMAGKCEEL>, IComparable<AKEMAGKCEEL>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly AKEMAGKCEEL KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public AKEMAGKCEEL(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(AKEMAGKCEEL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(AKEMAGKCEEL IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D81DE0", Offset = "0x8D803E0", VA = "0x188D81DE0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(AKEMAGKCEEL LEOAACGBJCD, AKEMAGKCEEL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(AKEMAGKCEEL LEOAACGBJCD, AKEMAGKCEEL GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8D81EC0", Offset = "0x8D804C0", VA = "0x188D81EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GJDKJPBGNBN : IEquatable<GJDKJPBGNBN>, IComparable<GJDKJPBGNBN>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly GJDKJPBGNBN KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public GJDKJPBGNBN(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(GJDKJPBGNBN IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(GJDKJPBGNBN IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8D82EE0", Offset = "0x8D814E0", VA = "0x188D82EE0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(GJDKJPBGNBN LEOAACGBJCD, GJDKJPBGNBN GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(GJDKJPBGNBN LEOAACGBJCD, GJDKJPBGNBN GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8D82F90", Offset = "0x8D81590", VA = "0x188D82F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DELOGIONJPM : IEquatable<DELOGIONJPM>, IComparable<DELOGIONJPM>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DELOGIONJPM KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public DELOGIONJPM(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(DELOGIONJPM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(DELOGIONJPM IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8D82550", Offset = "0x8D80B50", VA = "0x188D82550", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(DELOGIONJPM LEOAACGBJCD, DELOGIONJPM GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(DELOGIONJPM LEOAACGBJCD, DELOGIONJPM GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8D82600", Offset = "0x8D80C00", VA = "0x188D82600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct LIKKIADOIJO : IEquatable<LIKKIADOIJO>, IComparable<LIKKIADOIJO>, NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LIKKIADOIJO KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public LIKKIADOIJO(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(LIKKIADOIJO IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(LIKKIADOIJO IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8D83240", Offset = "0x8D81840", VA = "0x188D83240", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630")]
	public static bool LMIMJGGKHMP(LIKKIADOIJO LEOAACGBJCD, LIKKIADOIJO GDBFOEGEGHN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8D81E90", Offset = "0x8D80490", VA = "0x188D81E90")]
	public static bool PACMOMIAEBP(LIKKIADOIJO LEOAACGBJCD, LIKKIADOIJO GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8D832F0", Offset = "0x8D818F0", VA = "0x188D832F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ECOHPDCJPMM : IEquatable<ECOHPDCJPMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? BFNGHKFMODK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D826D0", Offset = "0x8D80CD0", VA = "0x188D826D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int MNNPLPGKALO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5826C30", Offset = "0x5825230", VA = "0x185826C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D82BF0", Offset = "0x8D811F0", VA = "0x188D82BF0")]
	public ECOHPDCJPMM(string? CMELDGAAIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D82D40", Offset = "0x8D81340", VA = "0x188D82D40")]
	public ECOHPDCJPMM(string?[] HPIIPAPEOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D82930", Offset = "0x8D80F30", VA = "0x188D82930")]
	private static string?[]? HGHECDAIJHJ(string?[]? HPIIPAPEOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D82670", Offset = "0x8D80C70", VA = "0x188D82670")]
	public string BOIOAGAINHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D826F0", Offset = "0x8D80CF0", VA = "0x188D826F0", Slot = "4")]
	public bool Equals(ECOHPDCJPMM IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D827C0", Offset = "0x8D80DC0", VA = "0x188D827C0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8D82850", Offset = "0x8D80E50", VA = "0x188D82850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D82B60", Offset = "0x8D81160", VA = "0x188D82B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PDLCHNHKPHL : IEquatable<PDLCHNHKPHL>, IComparable<PDLCHNHKPHL>, NFJHEOPKPGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid CLPJLOJHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
	public PDLCHNHKPHL(Guid CLPJLOJHBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
	public Guid CKNNKMILCOF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DE3630", Offset = "0x6DE1C30", VA = "0x186DE3630", Slot = "4")]
	public bool Equals(PDLCHNHKPHL IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DE38B0", Offset = "0x6DE1EB0", VA = "0x186DE38B0", Slot = "5")]
	public int CompareTo(PDLCHNHKPHL IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D83550", Offset = "0x8D81B50", VA = "0x188D83550", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6DE39D0", Offset = "0x6DE1FD0", VA = "0x186DE39D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8D83600", Offset = "0x8D81C00", VA = "0x188D83600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HILFMOALGJN<TModern> : IIFJDIFEHDN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JNEMDGBNFDO(TModern HFDHCIGLHDO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NFJHEOPKPGK
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CKNNKMILCOF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IIFJDIFEHDN<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern CLAMKEGLGMN(string HFDHCIGLHDO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ICDMELAABPI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HILFMOALGJN<KFPCHIHLHJM> AHLDBBNBLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HILFMOALGJN<AKEMAGKCEEL> GFPDILAHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HILFMOALGJN<LIKKIADOIJO> IDBPKEDCNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HILFMOALGJN<PHJLLKHDGCC> IDFLIPKGJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HILFMOALGJN<IDKLMMFDGOH> MFJOEGMDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HILFMOALGJN<DELOGIONJPM> PHJBNEBJJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HILFMOALGJN<EKHGCOBGJHL> PGHHOCPNCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HILFMOALGJN<GJDKJPBGNBN> LBFINEJCMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OLFGIHLDJCI
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] DLLCOBBBOBE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8D83410", Offset = "0x8D81A10", VA = "0x188D83410")]
	public static string[] IBNCJIKHDKN(string? CMELDGAAIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8D833E0", Offset = "0x8D819E0", VA = "0x188D833E0")]
	public static string? DNKEAHCEFFC(string? NGIIDBPAAGG)
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
