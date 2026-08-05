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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x642E7D0", Offset = "0x642D5D0", VA = "0x18642E7D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JECKJANCCKP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OJBJHHLKILJ(CDEIEAKMFDI JHAPDKALKLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CDEIEAKMFDI LKNPCKIALBL(string JHAPDKALKLI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CDEIEAKMFDI : IEquatable<CDEIEAKMFDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BHKPEIJJGHP FLFIJGLGJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LOMEGCIFLKN CNNAMGLNJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid CEBCJDPOGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? LAACHEHLKCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HKLPLCJGJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x642D2F0", Offset = "0x642C0F0", VA = "0x18642D2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OJLNODJADPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x642CF60", Offset = "0x642BD60", VA = "0x18642CF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x642D840", Offset = "0x642C640", VA = "0x18642D840")]
	public CDEIEAKMFDI(CDEIEAKMFDI LANBKAGFAMN, [Optional] Guid FNMAECMJIAM, [Optional] RRColor? HBLLOHAOGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x642D7B0", Offset = "0x642C5B0", VA = "0x18642D7B0")]
	public CDEIEAKMFDI(BHKPEIJJGHP LFEOILFLDAF, LOMEGCIFLKN LBDHFOKDJJH, [Optional] Guid FNMAECMJIAM, [Optional] RRColor? HBLLOHAOGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x642CFA0", Offset = "0x642BDA0", VA = "0x18642CFA0", Slot = "4")]
	public bool Equals(CDEIEAKMFDI LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x642D0A0", Offset = "0x642BEA0", VA = "0x18642D0A0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x642D190", Offset = "0x642BF90", VA = "0x18642D190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x642D280", Offset = "0x642C080", VA = "0x18642D280")]
	public static bool HIHGGPGGFPN(CDEIEAKMFDI CJNLLBDPPAC, CDEIEAKMFDI CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x642CEF0", Offset = "0x642BCF0", VA = "0x18642CEF0")]
	public static bool CAOAIKCPFJO(CDEIEAKMFDI CJNLLBDPPAC, CDEIEAKMFDI CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x642D3B0", Offset = "0x642C1B0", VA = "0x18642D3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BHKPEIJJGHP : IEquatable<BHKPEIJJGHP>, IComparable<BHKPEIJJGHP>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly BHKPEIJJGHP EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public BHKPEIJJGHP(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(BHKPEIJJGHP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(BHKPEIJJGHP LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x642CCD0", Offset = "0x642BAD0", VA = "0x18642CCD0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(BHKPEIJJGHP CJNLLBDPPAC, BHKPEIJJGHP CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(BHKPEIJJGHP CJNLLBDPPAC, BHKPEIJJGHP CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x642CD70", Offset = "0x642BB70", VA = "0x18642CD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OBACIPLEFHE : IEquatable<OBACIPLEFHE>, IComparable<OBACIPLEFHE>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OBACIPLEFHE EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public OBACIPLEFHE(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(OBACIPLEFHE LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(OBACIPLEFHE LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x642E850", Offset = "0x642D650", VA = "0x18642E850", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(OBACIPLEFHE CJNLLBDPPAC, OBACIPLEFHE CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(OBACIPLEFHE CJNLLBDPPAC, OBACIPLEFHE CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x642E8F0", Offset = "0x642D6F0", VA = "0x18642E8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HFBKIOKHMLG : IEquatable<HFBKIOKHMLG>, IComparable<HFBKIOKHMLG>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly HFBKIOKHMLG EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public HFBKIOKHMLG(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(HFBKIOKHMLG LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(HFBKIOKHMLG LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x642E210", Offset = "0x642D010", VA = "0x18642E210", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(HFBKIOKHMLG CJNLLBDPPAC, HFBKIOKHMLG CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(HFBKIOKHMLG CJNLLBDPPAC, HFBKIOKHMLG CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x642E2B0", Offset = "0x642D0B0", VA = "0x18642E2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LOMEGCIFLKN : IEquatable<LOMEGCIFLKN>, IComparable<LOMEGCIFLKN>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly LOMEGCIFLKN EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GENMKAOMKKA DDGMHPDJHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210")]
		[CompilerGenerated]
		get
		{
			return default(GENMKAOMKKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GENMKAOMKKA OBHHNFAEHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xEC76A0", Offset = "0xEC64A0", VA = "0x180EC76A0")]
		[CompilerGenerated]
		get
		{
			return default(GENMKAOMKKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GENMKAOMKKA CBKCNFDNCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDC2620", Offset = "0xDC1420", VA = "0x180DC2620")]
		[CompilerGenerated]
		get
		{
			return default(GENMKAOMKKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x642E680", Offset = "0x642D480", VA = "0x18642E680")]
	public LOMEGCIFLKN(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x642E630", Offset = "0x642D430", VA = "0x18642E630")]
	public LOMEGCIFLKN(GENMKAOMKKA NOAPLHFGCKK, GENMKAOMKKA AHOKCGNHFJF, GENMKAOMKKA FBCNNLLGCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x642E490", Offset = "0x642D290", VA = "0x18642E490")]
	private Guid JEBCMJHIINP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550", Slot = "4")]
	public bool Equals(LOMEGCIFLKN LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x642E3A0", Offset = "0x642D1A0", VA = "0x18642E3A0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x642E450", Offset = "0x642D250", VA = "0x18642E450")]
	public static bool HIHGGPGGFPN(LOMEGCIFLKN CJNLLBDPPAC, LOMEGCIFLKN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x642E320", Offset = "0x642D120", VA = "0x18642E320")]
	public static bool CAOAIKCPFJO(LOMEGCIFLKN CJNLLBDPPAC, LOMEGCIFLKN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x642E360", Offset = "0x642D160", VA = "0x18642E360", Slot = "5")]
	public int CompareTo(LOMEGCIFLKN LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x642E5C0", Offset = "0x642D3C0", VA = "0x18642E5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NMECNMIAGHI : IEquatable<NMECNMIAGHI>, IComparable<NMECNMIAGHI>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NMECNMIAGHI EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public NMECNMIAGHI(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(NMECNMIAGHI LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(NMECNMIAGHI LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x642E6C0", Offset = "0x642D4C0", VA = "0x18642E6C0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(NMECNMIAGHI CJNLLBDPPAC, NMECNMIAGHI CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(NMECNMIAGHI CJNLLBDPPAC, NMECNMIAGHI CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x642E760", Offset = "0x642D560", VA = "0x18642E760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AEFJCPOEANN : IEquatable<AEFJCPOEANN>, IComparable<AEFJCPOEANN>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly AEFJCPOEANN EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public AEFJCPOEANN(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(AEFJCPOEANN LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(AEFJCPOEANN LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x642CAB0", Offset = "0x642B8B0", VA = "0x18642CAB0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(AEFJCPOEANN CJNLLBDPPAC, AEFJCPOEANN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(AEFJCPOEANN CJNLLBDPPAC, AEFJCPOEANN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x642CB50", Offset = "0x642B950", VA = "0x18642CB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BPEOECGLCNP : IEquatable<BPEOECGLCNP>, IComparable<BPEOECGLCNP>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly BPEOECGLCNP EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public BPEOECGLCNP(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(BPEOECGLCNP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(BPEOECGLCNP LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x642CDE0", Offset = "0x642BBE0", VA = "0x18642CDE0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(BPEOECGLCNP CJNLLBDPPAC, BPEOECGLCNP CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(BPEOECGLCNP CJNLLBDPPAC, BPEOECGLCNP CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x642CE80", Offset = "0x642BC80", VA = "0x18642CE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ANBEKNMHALN : IEquatable<ANBEKNMHALN>, IComparable<ANBEKNMHALN>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly ANBEKNMHALN EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public ANBEKNMHALN(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(ANBEKNMHALN LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(ANBEKNMHALN LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x642CBC0", Offset = "0x642B9C0", VA = "0x18642CBC0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(ANBEKNMHALN CJNLLBDPPAC, ANBEKNMHALN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x642CA80", Offset = "0x642B880", VA = "0x18642CA80")]
	public static bool CAOAIKCPFJO(ANBEKNMHALN CJNLLBDPPAC, ANBEKNMHALN CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x642CC60", Offset = "0x642BA60", VA = "0x18642CC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct CKKJHPJHOFD : IEquatable<CKKJHPJHOFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? KOOKOPJDLOH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BGJCPKHADFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x642DB10", Offset = "0x642C910", VA = "0x18642DB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int HNFEBDEGLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B42E20", Offset = "0x3B41C20", VA = "0x183B42E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x642DE50", Offset = "0x642CC50", VA = "0x18642DE50")]
	public CKKJHPJHOFD(string? NAHEJIIGFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x642DF90", Offset = "0x642CD90", VA = "0x18642DF90")]
	public CKKJHPJHOFD(string?[] KBJODJOCNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x642DB90", Offset = "0x642C990", VA = "0x18642DB90")]
	private static string?[]? OODKOPMCPFL(string?[]? KBJODJOCNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x642DB30", Offset = "0x642C930", VA = "0x18642DB30")]
	public string KEBCAMHABGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x642D960", Offset = "0x642C760", VA = "0x18642D960", Slot = "4")]
	public bool Equals(CKKJHPJHOFD LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x642D8D0", Offset = "0x642C6D0", VA = "0x18642D8D0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x642DA30", Offset = "0x642C830", VA = "0x18642DA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x642DDC0", Offset = "0x642CBC0", VA = "0x18642DDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GENMKAOMKKA : IEquatable<GENMKAOMKKA>, IComparable<GENMKAOMKKA>, EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GENMKAOMKKA EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid CHLMGBPAGHG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public GENMKAOMKKA(Guid CHLMGBPAGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
	public Guid CKHMHKEBBPA()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40", Slot = "4")]
	public bool Equals(GENMKAOMKKA LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x45629E0", Offset = "0x45617E0", VA = "0x1845629E0", Slot = "5")]
	public int CompareTo(GENMKAOMKKA LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x642E010", Offset = "0x642CE10", VA = "0x18642E010", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4562A60", Offset = "0x4561860", VA = "0x184562A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4562D40", Offset = "0x4561B40", VA = "0x184562D40")]
	public static bool HIHGGPGGFPN(GENMKAOMKKA CJNLLBDPPAC, GENMKAOMKKA CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x642E0B0", Offset = "0x642CEB0", VA = "0x18642E0B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EJEGLLLDIGN<TModern> : NDDCHCHNGLG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EMDMJNOCIML(TModern PCKLOACIILI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EJOEFEOFBCD
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid CKHMHKEBBPA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NDDCHCHNGLG<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern KLFABLMEIJH(string PCKLOACIILI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JIHNOEAIIKO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EJEGLLLDIGN<BHKPEIJJGHP> OJJCIKNCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EJEGLLLDIGN<NMECNMIAGHI> CAAGFMPALHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EJEGLLLDIGN<ANBEKNMHALN> HGOGEPNMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EJEGLLLDIGN<LOMEGCIFLKN> IDNFKIMFOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EJEGLLLDIGN<HFBKIOKHMLG> PAOFLPMMBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EJEGLLLDIGN<BPEOECGLCNP> BILPFMFBPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EJEGLLLDIGN<OBACIPLEFHE> GJJHJDOHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EJEGLLLDIGN<AEFJCPOEANN> PKPICNBMADO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GPLODNJCAJN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x642E120", Offset = "0x642CF20", VA = "0x18642E120")]
	public static string[] DKFOJCLGPDP(string? NAHEJIIGFHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x642E1E0", Offset = "0x642CFE0", VA = "0x18642E1E0")]
	public static string? OMIFMNNPMFC(string? LFEOILFLDAF)
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
