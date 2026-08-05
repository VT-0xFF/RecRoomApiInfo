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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C841A0", Offset = "0x7C835A0", VA = "0x187C841A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EKLILNCOKGK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IMJDHHAECMF(HAHPCGIIIOL IOJLNNHDMIE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HAHPCGIIIOL GFOCOOKFNLL(string IOJLNNHDMIE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HAHPCGIIIOL : IEquatable<HAHPCGIIIOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FFPOHEDMPPG BAOMACLNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MCCAPFKCCCM JAEELMDPMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid AKGBOGELEHD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IJEJEBMEKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C83080", Offset = "0x7C82480", VA = "0x187C83080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HBCPLILBCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C83050", Offset = "0x7C82450", VA = "0x187C83050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C83620", Offset = "0x7C82A20", VA = "0x187C83620")]
	public HAHPCGIIIOL(HAHPCGIIIOL JMOBAAANIHL, [Optional] Guid PJNPLPPKBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x561DFE0", Offset = "0x561D3E0", VA = "0x18561DFE0")]
	public HAHPCGIIIOL(FFPOHEDMPPG FMILLEPBLNC, MCCAPFKCCCM BANBLAOJLHI, [Optional] Guid PJNPLPPKBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C831C0", Offset = "0x7C825C0", VA = "0x187C831C0", Slot = "4")]
	public bool Equals(HAHPCGIIIOL OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C83110", Offset = "0x7C82510", VA = "0x187C83110", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83280", Offset = "0x7C82680", VA = "0x187C83280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83020", Offset = "0x7C82420", VA = "0x187C83020")]
	public static bool BFIJCNNIIMH(HAHPCGIIIOL HJGDMEAJFEI, HAHPCGIIIOL OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83310", Offset = "0x7C82710", VA = "0x187C83310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FFPOHEDMPPG : IEquatable<FFPOHEDMPPG>, IComparable<FFPOHEDMPPG>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly FFPOHEDMPPG DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public FFPOHEDMPPG(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(FFPOHEDMPPG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(FFPOHEDMPPG OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C82F00", Offset = "0x7C82300", VA = "0x187C82F00", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(FFPOHEDMPPG HJGDMEAJFEI, FFPOHEDMPPG OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(FFPOHEDMPPG HJGDMEAJFEI, FFPOHEDMPPG OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C82FB0", Offset = "0x7C823B0", VA = "0x187C82FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BLMLNFKIBJD : IEquatable<BLMLNFKIBJD>, IComparable<BLMLNFKIBJD>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly BLMLNFKIBJD DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public BLMLNFKIBJD(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(BLMLNFKIBJD OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(BLMLNFKIBJD OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C82A80", Offset = "0x7C81E80", VA = "0x187C82A80", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(BLMLNFKIBJD HJGDMEAJFEI, BLMLNFKIBJD OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(BLMLNFKIBJD HJGDMEAJFEI, BLMLNFKIBJD OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C82B30", Offset = "0x7C81F30", VA = "0x187C82B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct OIJBGBIBLJK : IEquatable<OIJBGBIBLJK>, IComparable<OIJBGBIBLJK>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly OIJBGBIBLJK DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public OIJBGBIBLJK(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(OIJBGBIBLJK OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(OIJBGBIBLJK OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C84220", Offset = "0x7C83620", VA = "0x187C84220", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(OIJBGBIBLJK HJGDMEAJFEI, OIJBGBIBLJK OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(OIJBGBIBLJK HJGDMEAJFEI, OIJBGBIBLJK OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C842D0", Offset = "0x7C836D0", VA = "0x187C842D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MCCAPFKCCCM : IEquatable<MCCAPFKCCCM>, IComparable<MCCAPFKCCCM>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly MCCAPFKCCCM DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public MCCAPFKCCCM(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C84020", Offset = "0x7C83420", VA = "0x187C84020", Slot = "4")]
	public bool Equals(MCCAPFKCCCM OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C84050", Offset = "0x7C83450", VA = "0x187C84050", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C84020", Offset = "0x7C83420", VA = "0x187C84020")]
	public static bool BFIJCNNIIMH(MCCAPFKCCCM HJGDMEAJFEI, MCCAPFKCCCM OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C84100", Offset = "0x7C83500", VA = "0x187C84100")]
	public static bool HKDAGECLGLD(MCCAPFKCCCM HJGDMEAJFEI, MCCAPFKCCCM OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(MCCAPFKCCCM OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C84130", Offset = "0x7C83530", VA = "0x187C84130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public MCCAPFKCCCM(EPLPMCOHIDD KANJCAGIGJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FAKGGEAKAGO : IEquatable<FAKGGEAKAGO>, IComparable<FAKGGEAKAGO>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly FAKGGEAKAGO DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public FAKGGEAKAGO(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(FAKGGEAKAGO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(FAKGGEAKAGO OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C82DE0", Offset = "0x7C821E0", VA = "0x187C82DE0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(FAKGGEAKAGO HJGDMEAJFEI, FAKGGEAKAGO OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(FAKGGEAKAGO HJGDMEAJFEI, FAKGGEAKAGO OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C82E90", Offset = "0x7C82290", VA = "0x187C82E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct EJPJNNNFMKK : IEquatable<EJPJNNNFMKK>, IComparable<EJPJNNNFMKK>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly EJPJNNNFMKK DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public EJPJNNNFMKK(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(EJPJNNNFMKK OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(EJPJNNNFMKK OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C82BA0", Offset = "0x7C81FA0", VA = "0x187C82BA0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(EJPJNNNFMKK HJGDMEAJFEI, EJPJNNNFMKK OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(EJPJNNNFMKK HJGDMEAJFEI, EJPJNNNFMKK OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C82C50", Offset = "0x7C82050", VA = "0x187C82C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct BFBNNFENAIB : IEquatable<BFBNNFENAIB>, IComparable<BFBNNFENAIB>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BFBNNFENAIB DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public BFBNNFENAIB(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(BFBNNFENAIB OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(BFBNNFENAIB OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C82930", Offset = "0x7C81D30", VA = "0x187C82930", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(BFBNNFENAIB HJGDMEAJFEI, BFBNNFENAIB OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(BFBNNFENAIB HJGDMEAJFEI, BFBNNFENAIB OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C82A10", Offset = "0x7C81E10", VA = "0x187C82A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ICPMIFBJODI : IEquatable<ICPMIFBJODI>, IComparable<ICPMIFBJODI>, IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly ICPMIFBJODI DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public ICPMIFBJODI(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(ICPMIFBJODI OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(ICPMIFBJODI OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C83640", Offset = "0x7C82A40", VA = "0x187C83640", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40")]
	public static bool BFIJCNNIIMH(ICPMIFBJODI HJGDMEAJFEI, ICPMIFBJODI OHAJMMPIMHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C829E0", Offset = "0x7C81DE0", VA = "0x187C829E0")]
	public static bool HKDAGECLGLD(ICPMIFBJODI HJGDMEAJFEI, ICPMIFBJODI OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C836F0", Offset = "0x7C82AF0", VA = "0x187C836F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JECAOCDPOGB : IEquatable<JECAOCDPOGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? LLOAMPBAGAE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C838D0", Offset = "0x7C82CD0", VA = "0x187C838D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NACCGAHFEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4BF5B80", Offset = "0x4BF4F80", VA = "0x184BF5B80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83E50", Offset = "0x7C83250", VA = "0x187C83E50")]
	public JECAOCDPOGB(string? HCLPLFMMKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C83FA0", Offset = "0x7C833A0", VA = "0x187C83FA0")]
	public JECAOCDPOGB(string?[] OBBNKCEMAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C838F0", Offset = "0x7C82CF0", VA = "0x187C838F0")]
	private static string?[]? DFNACBECBEB(string?[]? OBBNKCEMAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C83D60", Offset = "0x7C83160", VA = "0x187C83D60")]
	public string LAGKJOELOGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83B20", Offset = "0x7C82F20", VA = "0x187C83B20", Slot = "4")]
	public bool Equals(JECAOCDPOGB OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C83BF0", Offset = "0x7C82FF0", VA = "0x187C83BF0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C83C80", Offset = "0x7C83080", VA = "0x187C83C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C83DC0", Offset = "0x7C831C0", VA = "0x187C83DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EPLPMCOHIDD : IEquatable<EPLPMCOHIDD>, IComparable<EPLPMCOHIDD>, IFCLNAHLMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid JINNLDEOCMO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
	public EPLPMCOHIDD(Guid JINNLDEOCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
	public Guid OPOKBIINDAM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x462FC40", Offset = "0x462F040", VA = "0x18462FC40", Slot = "4")]
	public bool Equals(EPLPMCOHIDD OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x462F5A0", Offset = "0x462E9A0", VA = "0x18462F5A0", Slot = "5")]
	public int CompareTo(EPLPMCOHIDD OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C82CC0", Offset = "0x7C820C0", VA = "0x187C82CC0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462EB10", VA = "0x18462F710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C82D70", Offset = "0x7C82170", VA = "0x187C82D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BMLBHIEMCPF<TModern> : KPAPMGFPBPM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IFCAOIHFKDD(TModern ICADNHAJGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IFCLNAHLMPM
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid OPOKBIINDAM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KPAPMGFPBPM<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern PEFELHAFJKK(string ICADNHAJGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OPIFMDAOECG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BMLBHIEMCPF<FFPOHEDMPPG> FCFBMHGAJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BMLBHIEMCPF<FAKGGEAKAGO> CMPPFDNBECL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BMLBHIEMCPF<ICPMIFBJODI> GPLLECHHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BMLBHIEMCPF<MCCAPFKCCCM> ALBCKHHIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BMLBHIEMCPF<OIJBGBIBLJK> NMEAFJINMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BMLBHIEMCPF<BFBNNFENAIB> PJHLIAMAMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BMLBHIEMCPF<BLMLNFKIBJD> GJBFOMEHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BMLBHIEMCPF<EJPJNNNFMKK> PJDJIANCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IOGFLFCDOED
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] PPODDLDIAOA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C83790", Offset = "0x7C82B90", VA = "0x187C83790")]
	public static string[] NDIHFNKJFFD(string? HCLPLFMMKLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C83760", Offset = "0x7C82B60", VA = "0x187C83760")]
	public static string? FOFGLPKNLAL(string? FMILLEPBLNC)
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
