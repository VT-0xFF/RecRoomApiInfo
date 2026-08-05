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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6435240", Offset = "0x6434240", VA = "0x186435240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ODIOPKKGIJC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KJONJHMMAMK(KLCMCNOHKBP JPKFBEJOHFJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KLCMCNOHKBP AJBPOCIDFHA(string JPKFBEJOHFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KLCMCNOHKBP : IEquatable<KLCMCNOHKBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HEKELBGMIEF OCCMAIGJAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BBAHBPCJDHO IJAIEKPNGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid APMFIINJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? PLPHHKDECIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HIHOGDDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6434B50", Offset = "0x6433B50", VA = "0x186434B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AHJBNCHJEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6434940", Offset = "0x6433940", VA = "0x186434940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6435010", Offset = "0x6434010", VA = "0x186435010")]
	public KLCMCNOHKBP(KLCMCNOHKBP DDLENJLGONB, [Optional] Guid FNJMLLCMMCB, [Optional] RRColor? NGFEKFKHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64350A0", Offset = "0x64340A0", VA = "0x1864350A0")]
	public KLCMCNOHKBP(HEKELBGMIEF GJNCFMJEGMB, BBAHBPCJDHO NEJEDMMJBLB, [Optional] Guid FNJMLLCMMCB, [Optional] RRColor? NGFEKFKHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6434840", Offset = "0x6433840", VA = "0x186434840", Slot = "4")]
	public bool Equals(KLCMCNOHKBP EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6434750", Offset = "0x6433750", VA = "0x186434750", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6434980", Offset = "0x6433980", VA = "0x186434980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6434AE0", Offset = "0x6433AE0", VA = "0x186434AE0")]
	public static bool LICIMLDMCMN(KLCMCNOHKBP ANOMGKBFKJP, KLCMCNOHKBP DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6434A70", Offset = "0x6433A70", VA = "0x186434A70")]
	public static bool JNBEKHIMJBJ(KLCMCNOHKBP ANOMGKBFKJP, KLCMCNOHKBP DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6434C10", Offset = "0x6433C10", VA = "0x186434C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HEKELBGMIEF : IEquatable<HEKELBGMIEF>, IComparable<HEKELBGMIEF>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly HEKELBGMIEF FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public HEKELBGMIEF(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(HEKELBGMIEF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(HEKELBGMIEF EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6434530", Offset = "0x6433530", VA = "0x186434530", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(HEKELBGMIEF ANOMGKBFKJP, HEKELBGMIEF DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(HEKELBGMIEF ANOMGKBFKJP, HEKELBGMIEF DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64345D0", Offset = "0x64335D0", VA = "0x1864345D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PPEJMHDOJFH : IEquatable<PPEJMHDOJFH>, IComparable<PPEJMHDOJFH>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly PPEJMHDOJFH FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public PPEJMHDOJFH(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(PPEJMHDOJFH EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(PPEJMHDOJFH EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64353D0", Offset = "0x64343D0", VA = "0x1864353D0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(PPEJMHDOJFH ANOMGKBFKJP, PPEJMHDOJFH DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(PPEJMHDOJFH ANOMGKBFKJP, PPEJMHDOJFH DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6435470", Offset = "0x6434470", VA = "0x186435470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ELIBGGPFDHN : IEquatable<ELIBGGPFDHN>, IComparable<ELIBGGPFDHN>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly ELIBGGPFDHN FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public ELIBGGPFDHN(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(ELIBGGPFDHN EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(ELIBGGPFDHN EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64341F0", Offset = "0x64331F0", VA = "0x1864341F0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(ELIBGGPFDHN ANOMGKBFKJP, ELIBGGPFDHN DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(ELIBGGPFDHN ANOMGKBFKJP, ELIBGGPFDHN DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x64342C0", Offset = "0x64332C0", VA = "0x1864342C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct BBAHBPCJDHO : IEquatable<BBAHBPCJDHO>, IComparable<BBAHBPCJDHO>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BBAHBPCJDHO FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EKLPJKBADIF EFIJHMLBNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0")]
		[CompilerGenerated]
		get
		{
			return default(EKLPJKBADIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EKLPJKBADIF OMDGGNBAJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEC8640", Offset = "0xEC7640", VA = "0x180EC8640")]
		[CompilerGenerated]
		get
		{
			return default(EKLPJKBADIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EKLPJKBADIF EGNKKMGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDC27C0", Offset = "0xDC17C0", VA = "0x180DC27C0")]
		[CompilerGenerated]
		get
		{
			return default(EKLPJKBADIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6433960", Offset = "0x6432960", VA = "0x186433960")]
	public BBAHBPCJDHO(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6433910", Offset = "0x6432910", VA = "0x186433910")]
	public BBAHBPCJDHO(EKLPJKBADIF KIGCPBBNBNK, EKLPJKBADIF IFLHHPALAGF, EKLPJKBADIF LFLKOCABCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6433770", Offset = "0x6432770", VA = "0x186433770")]
	private Guid NNHEDFIDDGI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2100", Offset = "0x5EB1100", VA = "0x185EB2100", Slot = "4")]
	public bool Equals(BBAHBPCJDHO EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6433640", Offset = "0x6432640", VA = "0x186433640", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6433730", Offset = "0x6432730", VA = "0x186433730")]
	public static bool LICIMLDMCMN(BBAHBPCJDHO ANOMGKBFKJP, BBAHBPCJDHO DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x64336F0", Offset = "0x64326F0", VA = "0x1864336F0")]
	public static bool JNBEKHIMJBJ(BBAHBPCJDHO ANOMGKBFKJP, BBAHBPCJDHO DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6433600", Offset = "0x6432600", VA = "0x186433600", Slot = "5")]
	public int CompareTo(BBAHBPCJDHO EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x64338A0", Offset = "0x64328A0", VA = "0x1864338A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MEHJFGPCLAC : IEquatable<MEHJFGPCLAC>, IComparable<MEHJFGPCLAC>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly MEHJFGPCLAC FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public MEHJFGPCLAC(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(MEHJFGPCLAC EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(MEHJFGPCLAC EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6435130", Offset = "0x6434130", VA = "0x186435130", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(MEHJFGPCLAC ANOMGKBFKJP, MEHJFGPCLAC DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(MEHJFGPCLAC ANOMGKBFKJP, MEHJFGPCLAC DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x64351D0", Offset = "0x64341D0", VA = "0x1864351D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IGPCDFKKDJH : IEquatable<IGPCDFKKDJH>, IComparable<IGPCDFKKDJH>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly IGPCDFKKDJH FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public IGPCDFKKDJH(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(IGPCDFKKDJH EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(IGPCDFKKDJH EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6434640", Offset = "0x6433640", VA = "0x186434640", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(IGPCDFKKDJH ANOMGKBFKJP, IGPCDFKKDJH DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(IGPCDFKKDJH ANOMGKBFKJP, IGPCDFKKDJH DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x64346E0", Offset = "0x64336E0", VA = "0x1864346E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct PLHNKCDLCKG : IEquatable<PLHNKCDLCKG>, IComparable<PLHNKCDLCKG>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly PLHNKCDLCKG FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public PLHNKCDLCKG(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(PLHNKCDLCKG EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(PLHNKCDLCKG EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x64352C0", Offset = "0x64342C0", VA = "0x1864352C0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(PLHNKCDLCKG ANOMGKBFKJP, PLHNKCDLCKG DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(PLHNKCDLCKG ANOMGKBFKJP, PLHNKCDLCKG DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6435360", Offset = "0x6434360", VA = "0x186435360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GKBHPKIFKPA : IEquatable<GKBHPKIFKPA>, IComparable<GKBHPKIFKPA>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly GKBHPKIFKPA FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public GKBHPKIFKPA(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(GKBHPKIFKPA EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(GKBHPKIFKPA EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6434420", Offset = "0x6433420", VA = "0x186434420", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(GKBHPKIFKPA ANOMGKBFKJP, GKBHPKIFKPA DMFPEEHDAKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6434290", Offset = "0x6433290", VA = "0x186434290")]
	public static bool JNBEKHIMJBJ(GKBHPKIFKPA ANOMGKBFKJP, GKBHPKIFKPA DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64344C0", Offset = "0x64334C0", VA = "0x1864344C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DDMAIBPLLFD : IEquatable<DDMAIBPLLFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? IBCNCDLEDGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MHPEFMEANPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6433BD0", Offset = "0x6432BD0", VA = "0x186433BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int MNFBMKEMABL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3A149D0", Offset = "0x3A139D0", VA = "0x183A149D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6433FA0", Offset = "0x6432FA0", VA = "0x186433FA0")]
	public DDMAIBPLLFD(string? BDCJONHAMNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6433F20", Offset = "0x6432F20", VA = "0x186433F20")]
	public DDMAIBPLLFD(string?[] OIBJFCJDABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x64339A0", Offset = "0x64329A0", VA = "0x1864339A0")]
	private static string?[]? CBPNKHHFJHK(string?[]? OIBJFCJDABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6433BF0", Offset = "0x6432BF0", VA = "0x186433BF0")]
	public string EFLOMKBLEAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6433CE0", Offset = "0x6432CE0", VA = "0x186433CE0", Slot = "4")]
	public bool Equals(DDMAIBPLLFD EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6433C50", Offset = "0x6432C50", VA = "0x186433C50", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6433DB0", Offset = "0x6432DB0", VA = "0x186433DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6433E90", Offset = "0x6432E90", VA = "0x186433E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EKLPJKBADIF : IEquatable<EKLPJKBADIF>, IComparable<EKLPJKBADIF>, MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EKLPJKBADIF FKNBKDPNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid BCPPFHNPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CBB2C0", Offset = "0x1CBA2C0", VA = "0x181CBB2C0")]
	public EKLPJKBADIF(Guid BCPPFHNPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0", Slot = "6")]
	public Guid JPHLFHLJFLA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0", Slot = "4")]
	public bool Equals(EKLPJKBADIF EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x39DB220", Offset = "0x39DA220", VA = "0x1839DB220", Slot = "5")]
	public int CompareTo(EKLPJKBADIF EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x64340E0", Offset = "0x64330E0", VA = "0x1864340E0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39DB2A0", Offset = "0x39DA2A0", VA = "0x1839DB2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x39DB1F0", Offset = "0x39DA1F0", VA = "0x1839DB1F0")]
	public static bool LICIMLDMCMN(EKLPJKBADIF ANOMGKBFKJP, EKLPJKBADIF DMFPEEHDAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6434180", Offset = "0x6433180", VA = "0x186434180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OMEDPHKIMFI<TModern> : NKBKHFADPPF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BJCHJDNPIFN(TModern HLJIKOMPJCM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MBLMNAGKFPL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid JPHLFHLJFLA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NKBKHFADPPF<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern PAFOFNIPJEP(string HLJIKOMPJCM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FCGPNHCMHKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OMEDPHKIMFI<HEKELBGMIEF> AHKDDCLAIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OMEDPHKIMFI<MEHJFGPCLAC> PCFDKIBMPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OMEDPHKIMFI<GKBHPKIFKPA> BCNOMEKIIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OMEDPHKIMFI<BBAHBPCJDHO> NEMHNINOKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OMEDPHKIMFI<ELIBGGPFDHN> HMIJMLFODIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OMEDPHKIMFI<PLHNKCDLCKG> GLFKFGFHAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OMEDPHKIMFI<PPEJMHDOJFH> LNMANFMKMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OMEDPHKIMFI<IGPCDFKKDJH> HKCLPGDMBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FHPNECEBONM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6434360", Offset = "0x6433360", VA = "0x186434360")]
	public static string[] GNGPDMHBODP(string? BDCJONHAMNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6434330", Offset = "0x6433330", VA = "0x186434330")]
	public static string? EEHBAINFDGF(string? GJNCFMJEGMB)
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
