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
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
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
		[Cpp2IlInjected.Address(RVA = "0x62BDB20", Offset = "0x62BCF20", VA = "0x1862BDB20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
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
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CBFFNKHAJHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MFIMBGNEKOH(DIIOBOGHNAM INCBMJFBGNP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DIIOBOGHNAM HNNKJEMPCFP(string INCBMJFBGNP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DIIOBOGHNAM : IEquatable<DIIOBOGHNAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AIPCPGMFLKE DFKIEPHDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LAPHGBELHBK OEFBFNJCLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid GKNGGNHFPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? EPIIENAEFCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GJGCHKFGOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62BC3E0", Offset = "0x62BB7E0", VA = "0x1862BC3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LOGHOGMAKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62BC4A0", Offset = "0x62BB8A0", VA = "0x1862BC4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62BC970", Offset = "0x62BBD70", VA = "0x1862BC970")]
	public DIIOBOGHNAM(DIIOBOGHNAM HFMAOEGAHHB, [Optional] Guid MIAOGHKIDLA, [Optional] RRColor? KKBAHNFNJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62BC8E0", Offset = "0x62BBCE0", VA = "0x1862BC8E0")]
	public DIIOBOGHNAM(AIPCPGMFLKE PIMIGDPDFJO, LAPHGBELHBK JEJPHJJCNPB, [Optional] Guid MIAOGHKIDLA, [Optional] RRColor? KKBAHNFNJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62BC110", Offset = "0x62BB510", VA = "0x1862BC110", Slot = "4")]
	public bool Equals(DIIOBOGHNAM KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62BC020", Offset = "0x62BB420", VA = "0x1862BC020", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62BC280", Offset = "0x62BB680", VA = "0x1862BC280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62BC370", Offset = "0x62BB770", VA = "0x1862BC370")]
	public static bool HCMKGGFOPFL(DIIOBOGHNAM AHKCLAHHIPP, DIIOBOGHNAM MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62BC210", Offset = "0x62BB610", VA = "0x1862BC210")]
	public static bool GKDOMDKCOOJ(DIIOBOGHNAM AHKCLAHHIPP, DIIOBOGHNAM MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62BC4E0", Offset = "0x62BB8E0", VA = "0x1862BC4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AIPCPGMFLKE : IEquatable<AIPCPGMFLKE>, IComparable<AIPCPGMFLKE>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly AIPCPGMFLKE KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public AIPCPGMFLKE(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(AIPCPGMFLKE KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(AIPCPGMFLKE KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62BBEE0", Offset = "0x62BB2E0", VA = "0x1862BBEE0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(AIPCPGMFLKE AHKCLAHHIPP, AIPCPGMFLKE MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(AIPCPGMFLKE AHKCLAHHIPP, AIPCPGMFLKE MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62BBFB0", Offset = "0x62BB3B0", VA = "0x1862BBFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KMKCJAHNCEL : IEquatable<KMKCJAHNCEL>, IComparable<KMKCJAHNCEL>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly KMKCJAHNCEL KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public KMKCJAHNCEL(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(KMKCJAHNCEL KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(KMKCJAHNCEL KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62BD560", Offset = "0x62BC960", VA = "0x1862BD560", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(KMKCJAHNCEL AHKCLAHHIPP, KMKCJAHNCEL MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(KMKCJAHNCEL AHKCLAHHIPP, KMKCJAHNCEL MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62BD600", Offset = "0x62BCA00", VA = "0x1862BD600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct PCGHCCLLFMB : IEquatable<PCGHCCLLFMB>, IComparable<PCGHCCLLFMB>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly PCGHCCLLFMB KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public PCGHCCLLFMB(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(PCGHCCLLFMB KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(PCGHCCLLFMB KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62BDCB0", Offset = "0x62BD0B0", VA = "0x1862BDCB0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(PCGHCCLLFMB AHKCLAHHIPP, PCGHCCLLFMB MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(PCGHCCLLFMB AHKCLAHHIPP, PCGHCCLLFMB MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62BDD50", Offset = "0x62BD150", VA = "0x1862BDD50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LAPHGBELHBK : IEquatable<LAPHGBELHBK>, IComparable<LAPHGBELHBK>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly LAPHGBELHBK KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OBAOPJBDACM OMLBOGENHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA40000", Offset = "0xA3F400", VA = "0x180A40000")]
		[CompilerGenerated]
		get
		{
			return default(OBAOPJBDACM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OBAOPJBDACM IGNKHPAPFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD6E3E0", Offset = "0xD6D7E0", VA = "0x180D6E3E0")]
		[CompilerGenerated]
		get
		{
			return default(OBAOPJBDACM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OBAOPJBDACM CKBEEIFDKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD230A0", Offset = "0xD224A0", VA = "0x180D230A0")]
		[CompilerGenerated]
		get
		{
			return default(OBAOPJBDACM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x62BD9D0", Offset = "0x62BCDD0", VA = "0x1862BD9D0")]
	public LAPHGBELHBK(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62BD980", Offset = "0x62BCD80", VA = "0x1862BD980")]
	public LAPHGBELHBK(OBAOPJBDACM JJNIPHMCJKB, OBAOPJBDACM MFAAHPAFNDN, OBAOPJBDACM AGLMPEEOBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62BD670", Offset = "0x62BCA70", VA = "0x1862BD670")]
	private Guid CGCJKMOBPFF()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D8A220", Offset = "0x5D89620", VA = "0x185D8A220", Slot = "4")]
	public bool Equals(LAPHGBELHBK KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62BD7E0", Offset = "0x62BCBE0", VA = "0x1862BD7E0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62BD8D0", Offset = "0x62BCCD0", VA = "0x1862BD8D0")]
	public static bool HCMKGGFOPFL(LAPHGBELHBK AHKCLAHHIPP, LAPHGBELHBK MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62BD890", Offset = "0x62BCC90", VA = "0x1862BD890")]
	public static bool GKDOMDKCOOJ(LAPHGBELHBK AHKCLAHHIPP, LAPHGBELHBK MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62BD7A0", Offset = "0x62BCBA0", VA = "0x1862BD7A0", Slot = "5")]
	public int CompareTo(LAPHGBELHBK KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62BD910", Offset = "0x62BCD10", VA = "0x1862BD910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct GOFIAHLKMLN : IEquatable<GOFIAHLKMLN>, IComparable<GOFIAHLKMLN>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly GOFIAHLKMLN KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public GOFIAHLKMLN(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(GOFIAHLKMLN KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(GOFIAHLKMLN KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62BCAF0", Offset = "0x62BBEF0", VA = "0x1862BCAF0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(GOFIAHLKMLN AHKCLAHHIPP, GOFIAHLKMLN MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(GOFIAHLKMLN AHKCLAHHIPP, GOFIAHLKMLN MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62BCB90", Offset = "0x62BBF90", VA = "0x1862BCB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NCIPPJKBGBH : IEquatable<NCIPPJKBGBH>, IComparable<NCIPPJKBGBH>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NCIPPJKBGBH KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public NCIPPJKBGBH(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(NCIPPJKBGBH KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(NCIPPJKBGBH KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62BDA10", Offset = "0x62BCE10", VA = "0x1862BDA10", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(NCIPPJKBGBH AHKCLAHHIPP, NCIPPJKBGBH MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62BDAB0", Offset = "0x62BCEB0", VA = "0x1862BDAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct IKJPAIKAFNL : IEquatable<IKJPAIKAFNL>, IComparable<IKJPAIKAFNL>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly IKJPAIKAFNL KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public IKJPAIKAFNL(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(IKJPAIKAFNL KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(IKJPAIKAFNL KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62BCC00", Offset = "0x62BC000", VA = "0x1862BCC00", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(IKJPAIKAFNL AHKCLAHHIPP, IKJPAIKAFNL MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(IKJPAIKAFNL AHKCLAHHIPP, IKJPAIKAFNL MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62BCCA0", Offset = "0x62BC0A0", VA = "0x1862BCCA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct KIMOABIJNCB : IEquatable<KIMOABIJNCB>, IComparable<KIMOABIJNCB>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly KIMOABIJNCB KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public KIMOABIJNCB(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(KIMOABIJNCB KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(KIMOABIJNCB KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62BD450", Offset = "0x62BC850", VA = "0x1862BD450", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(KIMOABIJNCB AHKCLAHHIPP, KIMOABIJNCB MHLPFPGAPOG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB380", VA = "0x1862BBF80")]
	public static bool GKDOMDKCOOJ(KIMOABIJNCB AHKCLAHHIPP, KIMOABIJNCB MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62BD4F0", Offset = "0x62BC8F0", VA = "0x1862BD4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JAENIFIHKON : IEquatable<JAENIFIHKON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? GDMMDFMGCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62BCD10", Offset = "0x62BC110", VA = "0x1862BCD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int OBGKEKMPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3949CB0", Offset = "0x39490B0", VA = "0x183949CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62BD310", Offset = "0x62BC710", VA = "0x1862BD310")]
	public JAENIFIHKON(string? DACALDHKHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62BD290", Offset = "0x62BC690", VA = "0x1862BD290")]
	public JAENIFIHKON(string?[] GCDNIACNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62BCEF0", Offset = "0x62BC2F0", VA = "0x1862BCEF0")]
	private static string?[]? GONEHNKEEGD(string?[]? GCDNIACNNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x62BCE90", Offset = "0x62BC290", VA = "0x1862BCE90")]
	public string FLELLNCNFPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62BCDC0", Offset = "0x62BC1C0", VA = "0x1862BCDC0", Slot = "4")]
	public bool Equals(JAENIFIHKON KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62BCD30", Offset = "0x62BC130", VA = "0x1862BCD30", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x62BD120", Offset = "0x62BC520", VA = "0x1862BD120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62BD200", Offset = "0x62BC600", VA = "0x1862BD200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OBAOPJBDACM : IEquatable<OBAOPJBDACM>, IComparable<OBAOPJBDACM>, EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OBAOPJBDACM KLACMHEBBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid HILDEDLDEPK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C26850", Offset = "0x1C25C50", VA = "0x181C26850")]
	public OBAOPJBDACM(Guid HILDEDLDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA3FFF0", Offset = "0xA3F3F0", VA = "0x180A3FFF0", Slot = "6")]
	public Guid BMMNCGPKPJD()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0", Slot = "4")]
	public bool Equals(OBAOPJBDACM KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A320", Offset = "0x3B69720", VA = "0x183B6A320", Slot = "5")]
	public int CompareTo(OBAOPJBDACM KEEHOGPOIFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62BDBA0", Offset = "0x62BCFA0", VA = "0x1862BDBA0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A540", Offset = "0x3B69940", VA = "0x183B6A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3B6A3E0", Offset = "0x3B697E0", VA = "0x183B6A3E0")]
	public static bool HCMKGGFOPFL(OBAOPJBDACM AHKCLAHHIPP, OBAOPJBDACM MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62BDC40", Offset = "0x62BD040", VA = "0x1862BDC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FBDGNMINKBD<TModern> : JIFOCPAFHDH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CIGMAECBFIH(TModern NEMJNMDPMLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EILOEOPKDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid BMMNCGPKPJD();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JIFOCPAFHDH<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern MKAOHJBDIGI(string NEMJNMDPMLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PKJAFBNECPP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FBDGNMINKBD<AIPCPGMFLKE> CJEMNLBKPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FBDGNMINKBD<GOFIAHLKMLN> FEOPNHCHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FBDGNMINKBD<KIMOABIJNCB> MALMGONPHBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FBDGNMINKBD<LAPHGBELHBK> CCIJPAAMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FBDGNMINKBD<PCGHCCLLFMB> KJLNJAOFDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FBDGNMINKBD<IKJPAIKAFNL> FJCLHDKKPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FBDGNMINKBD<KMKCJAHNCEL> NKMGAEEDFBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FBDGNMINKBD<NCIPPJKBGBH> MAOLNHKDNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ENFOAPGJHDH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62BCA00", Offset = "0x62BBE00", VA = "0x1862BCA00")]
	public static string[] EGKACMFMCGK(string? DACALDHKHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x62BCAC0", Offset = "0x62BBEC0", VA = "0x1862BCAC0")]
	public static string? JBJPHCCCAKK(string? PIMIGDPDFJO)
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
