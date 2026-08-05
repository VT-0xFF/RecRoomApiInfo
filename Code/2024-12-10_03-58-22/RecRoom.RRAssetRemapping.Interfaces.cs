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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x73ADF30", Offset = "0x73ACB30", VA = "0x1873ADF30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNCOEDHLIAA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IMPFBNFMBKJ(DMMPCDIHBGH GKMKPBACAOC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMMPCDIHBGH ICHKPGLOBMP(string GKMKPBACAOC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DMMPCDIHBGH : IEquatable<DMMPCDIHBGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CBNBPLCDNIL EDNCPNDPDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IDJGAJOPJGM AJJKHEKCJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CODBDEHDFJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FCOAAIJCNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73ACCF0", Offset = "0x73AB8F0", VA = "0x1873ACCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BPHDPCIMPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73ACBF0", Offset = "0x73AB7F0", VA = "0x1873ACBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73AD0B0", Offset = "0x73ABCB0", VA = "0x1873AD0B0")]
	public DMMPCDIHBGH(DMMPCDIHBGH DAALEEGLDHA, [Optional] Guid NDNNLJBLELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC690", Offset = "0x4EAB290", VA = "0x184EAC690")]
	public DMMPCDIHBGH(CBNBPLCDNIL KMAHLCKHOAN, IDJGAJOPJGM IJAFELPDKBH, [Optional] Guid NDNNLJBLELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73ACB30", Offset = "0x73AB730", VA = "0x1873ACB30", Slot = "4")]
	public bool Equals(DMMPCDIHBGH FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73ACA80", Offset = "0x73AB680", VA = "0x1873ACA80", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73ACC60", Offset = "0x73AB860", VA = "0x1873ACC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x73ACD80", Offset = "0x73AB980", VA = "0x1873ACD80")]
	public static bool PCHFOHOKDFG(DMMPCDIHBGH KFIDOCPNAED, DMMPCDIHBGH AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x73ACC20", Offset = "0x73AB820", VA = "0x1873ACC20")]
	public static bool GBEMIEIJNBP(DMMPCDIHBGH KFIDOCPNAED, DMMPCDIHBGH AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73ACDB0", Offset = "0x73AB9B0", VA = "0x1873ACDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CBNBPLCDNIL : IEquatable<CBNBPLCDNIL>, IComparable<CBNBPLCDNIL>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly CBNBPLCDNIL EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public CBNBPLCDNIL(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(CBNBPLCDNIL FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(CBNBPLCDNIL FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73AC970", Offset = "0x73AB570", VA = "0x1873AC970", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(CBNBPLCDNIL KFIDOCPNAED, CBNBPLCDNIL AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(CBNBPLCDNIL KFIDOCPNAED, CBNBPLCDNIL AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73ACA10", Offset = "0x73AB610", VA = "0x1873ACA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NEHAEFNHPDF : IEquatable<NEHAEFNHPDF>, IComparable<NEHAEFNHPDF>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly NEHAEFNHPDF EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public NEHAEFNHPDF(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(NEHAEFNHPDF FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(NEHAEFNHPDF FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x73ADE20", Offset = "0x73ACA20", VA = "0x1873ADE20", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(NEHAEFNHPDF KFIDOCPNAED, NEHAEFNHPDF AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(NEHAEFNHPDF KFIDOCPNAED, NEHAEFNHPDF AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73ADEC0", Offset = "0x73ACAC0", VA = "0x1873ADEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct EGLKLHOCNGC : IEquatable<EGLKLHOCNGC>, IComparable<EGLKLHOCNGC>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly EGLKLHOCNGC EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public EGLKLHOCNGC(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(EGLKLHOCNGC FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(EGLKLHOCNGC FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73AD0D0", Offset = "0x73ABCD0", VA = "0x1873AD0D0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(EGLKLHOCNGC KFIDOCPNAED, EGLKLHOCNGC AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(EGLKLHOCNGC KFIDOCPNAED, EGLKLHOCNGC AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73AD170", Offset = "0x73ABD70", VA = "0x1873AD170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct IDJGAJOPJGM : IEquatable<IDJGAJOPJGM>, IComparable<IDJGAJOPJGM>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly IDJGAJOPJGM EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public IDJGAJOPJGM(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73AD2F0", Offset = "0x73ABEF0", VA = "0x1873AD2F0", Slot = "4")]
	public bool Equals(IDJGAJOPJGM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73AD320", Offset = "0x73ABF20", VA = "0x1873AD320", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73AD2F0", Offset = "0x73ABEF0", VA = "0x1873AD2F0")]
	public static bool PCHFOHOKDFG(IDJGAJOPJGM KFIDOCPNAED, IDJGAJOPJGM AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73AD3C0", Offset = "0x73ABFC0", VA = "0x1873AD3C0")]
	public static bool GBEMIEIJNBP(IDJGAJOPJGM KFIDOCPNAED, IDJGAJOPJGM AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(IDJGAJOPJGM FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73AD3F0", Offset = "0x73ABFF0", VA = "0x1873AD3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public IDJGAJOPJGM(JGOKHBGKIBM GKDBBFMNMKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AAONFFKKDKE : IEquatable<AAONFFKKDKE>, IComparable<AAONFFKKDKE>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly AAONFFKKDKE EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public AAONFFKKDKE(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(AAONFFKKDKE FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(AAONFFKKDKE FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73AC720", Offset = "0x73AB320", VA = "0x1873AC720", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(AAONFFKKDKE KFIDOCPNAED, AAONFFKKDKE AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(AAONFFKKDKE KFIDOCPNAED, AAONFFKKDKE AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7F0", Offset = "0x73AB3F0", VA = "0x1873AC7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct OCAFLGKEFMJ : IEquatable<OCAFLGKEFMJ>, IComparable<OCAFLGKEFMJ>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly OCAFLGKEFMJ EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public OCAFLGKEFMJ(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(OCAFLGKEFMJ FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(OCAFLGKEFMJ FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73ADFB0", Offset = "0x73ACBB0", VA = "0x1873ADFB0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(OCAFLGKEFMJ KFIDOCPNAED, OCAFLGKEFMJ AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(OCAFLGKEFMJ KFIDOCPNAED, OCAFLGKEFMJ AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73AE050", Offset = "0x73ACC50", VA = "0x1873AE050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HDCHENBKBCD : IEquatable<HDCHENBKBCD>, IComparable<HDCHENBKBCD>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly HDCHENBKBCD EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public HDCHENBKBCD(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(HDCHENBKBCD FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(HDCHENBKBCD FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73AD1E0", Offset = "0x73ABDE0", VA = "0x1873AD1E0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(HDCHENBKBCD KFIDOCPNAED, HDCHENBKBCD AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(HDCHENBKBCD KFIDOCPNAED, HDCHENBKBCD AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73AD280", Offset = "0x73ABE80", VA = "0x1873AD280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BMMFMLLGCKA : IEquatable<BMMFMLLGCKA>, IComparable<BMMFMLLGCKA>, FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly BMMFMLLGCKA EHFCNKAFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public BMMFMLLGCKA(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(BMMFMLLGCKA FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(BMMFMLLGCKA FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x73AC860", Offset = "0x73AB460", VA = "0x1873AC860", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0")]
	public static bool PCHFOHOKDFG(BMMFMLLGCKA KFIDOCPNAED, BMMFMLLGCKA AMMLBECACOK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB3C0", VA = "0x1873AC7C0")]
	public static bool GBEMIEIJNBP(BMMFMLLGCKA KFIDOCPNAED, BMMFMLLGCKA AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73AC900", Offset = "0x73AB500", VA = "0x1873AC900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IKMBCIMLILF : IEquatable<IKMBCIMLILF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? EDIBOMCIIFJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PEBIHPCGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73AD700", Offset = "0x73AC300", VA = "0x1873AD700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EIEEAAPINOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4394740", Offset = "0x4393340", VA = "0x184394740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73ADA60", Offset = "0x73AC660", VA = "0x1873ADA60")]
	public IKMBCIMLILF(string? NBDLBKMKLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73AD9E0", Offset = "0x73AC5E0", VA = "0x1873AD9E0")]
	public IKMBCIMLILF(string?[] DPKGDEBMCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x73AD720", Offset = "0x73AC320", VA = "0x1873AD720")]
	private static string?[]? JAJEHOBAOPD(string?[]? DPKGDEBMCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73AD460", Offset = "0x73AC060", VA = "0x1873AD460")]
	public string ANIBBJBHANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73AD550", Offset = "0x73AC150", VA = "0x1873AD550", Slot = "4")]
	public bool Equals(IKMBCIMLILF FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x73AD4C0", Offset = "0x73AC0C0", VA = "0x1873AD4C0", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73AD620", Offset = "0x73AC220", VA = "0x1873AD620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73AD950", Offset = "0x73AC550", VA = "0x1873AD950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JGOKHBGKIBM : IEquatable<JGOKHBGKIBM>, IComparable<JGOKHBGKIBM>, FABBPMKDCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OCIHAODAEFD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
	public JGOKHBGKIBM(Guid OCIHAODAEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public Guid HJPDJNHGBPH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ABB1D0", Offset = "0x5AB9DD0", VA = "0x185ABB1D0", Slot = "4")]
	public bool Equals(JGOKHBGKIBM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAD30", Offset = "0x5AB9930", VA = "0x185ABAD30", Slot = "5")]
	public int CompareTo(JGOKHBGKIBM FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73ADD10", Offset = "0x73AC910", VA = "0x1873ADD10", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5ABAEA0", Offset = "0x5AB9AA0", VA = "0x185ABAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73ADDB0", Offset = "0x73AC9B0", VA = "0x1873ADDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JEKDCHAMNLK<TModern> : CAEFHGPOHED<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BEPIEEHOBLI(TModern FBANPKAIANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FABBPMKDCKI
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HJPDJNHGBPH();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CAEFHGPOHED<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern IDHBOEHFCLD(string FBANPKAIANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JMJDDJJLLLD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	JEKDCHAMNLK<CBNBPLCDNIL> MHMAONPKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JEKDCHAMNLK<AAONFFKKDKE> FPLFOJDAHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JEKDCHAMNLK<BMMFMLLGCKA> CCGLOCPMKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JEKDCHAMNLK<IDJGAJOPJGM> GIGNJBNCANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JEKDCHAMNLK<EGLKLHOCNGC> LFMGGAGCGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JEKDCHAMNLK<HDCHENBKBCD> AOHBBOELNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JEKDCHAMNLK<NEHAEFNHPDF> NEOAKNNGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JEKDCHAMNLK<OCAFLGKEFMJ> PLFDPCJKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JFHPEDDNFHL
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] NBBDDPPMHAG;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73ADBB0", Offset = "0x73AC7B0", VA = "0x1873ADBB0")]
	public static string[] BCDLKFNMFOM(string? NBDLBKMKLBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73ADC50", Offset = "0x73AC850", VA = "0x1873ADC50")]
	public static string? BLNBFBLADED(string? KMAHLCKHOAN)
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
