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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76EB8D0", Offset = "0x76EA0D0", VA = "0x1876EB8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FDDHAHKIEBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBGBIJFEDIC(IHDHEKBLLBJ AOJEAJGBMCP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHDHEKBLLBJ KDFBDMHOPOO(string AOJEAJGBMCP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IHDHEKBLLBJ : IEquatable<IHDHEKBLLBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MCDELACKOKB DBMCPGPBMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly HMKFGHFJBCL PIDHJMIBNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid MFPEPNKMCBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MFOABJHACNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76EB160", Offset = "0x76E9960", VA = "0x1876EB160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JNFCEBMKDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76EB130", Offset = "0x76E9930", VA = "0x1876EB130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76EB520", Offset = "0x76E9D20", VA = "0x1876EB520")]
	public IHDHEKBLLBJ(IHDHEKBLLBJ EKCPJHPGELI, [Optional] Guid MPLJBDJDGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51A1EC0", Offset = "0x51A06C0", VA = "0x1851A1EC0")]
	public IHDHEKBLLBJ(MCDELACKOKB GMIJFBCGEGE, HMKFGHFJBCL NNFHBCMJKBM, [Optional] Guid MPLJBDJDGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76EAF30", Offset = "0x76E9730", VA = "0x1876EAF30", Slot = "4")]
	public bool Equals(IHDHEKBLLBJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76EAFF0", Offset = "0x76E97F0", VA = "0x1876EAFF0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76EB0A0", Offset = "0x76E98A0", VA = "0x1876EB0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x76EB1F0", Offset = "0x76E99F0", VA = "0x1876EB1F0")]
	public static bool PCBECHOJFKF(IHDHEKBLLBJ CBNNCMPLCDK, IHDHEKBLLBJ OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76EB220", Offset = "0x76E9A20", VA = "0x1876EB220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MCDELACKOKB : IEquatable<MCDELACKOKB>, IComparable<MCDELACKOKB>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly MCDELACKOKB PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public MCDELACKOKB(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(MCDELACKOKB LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(MCDELACKOKB LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x76EB7C0", Offset = "0x76E9FC0", VA = "0x1876EB7C0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(MCDELACKOKB CBNNCMPLCDK, MCDELACKOKB OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(MCDELACKOKB CBNNCMPLCDK, MCDELACKOKB OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76EB860", Offset = "0x76EA060", VA = "0x1876EB860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FFDNFNMJGGE : IEquatable<FFDNFNMJGGE>, IComparable<FFDNFNMJGGE>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly FFDNFNMJGGE PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public FFDNFNMJGGE(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(FFDNFNMJGGE LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(FFDNFNMJGGE LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x76EABA0", Offset = "0x76E93A0", VA = "0x1876EABA0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(FFDNFNMJGGE CBNNCMPLCDK, FFDNFNMJGGE OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(FFDNFNMJGGE CBNNCMPLCDK, FFDNFNMJGGE OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x76EAC40", Offset = "0x76E9440", VA = "0x1876EAC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct DEBOPKMJAMH : IEquatable<DEBOPKMJAMH>, IComparable<DEBOPKMJAMH>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly DEBOPKMJAMH PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public DEBOPKMJAMH(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(DEBOPKMJAMH LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(DEBOPKMJAMH LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76EA980", Offset = "0x76E9180", VA = "0x1876EA980", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(DEBOPKMJAMH CBNNCMPLCDK, DEBOPKMJAMH OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(DEBOPKMJAMH CBNNCMPLCDK, DEBOPKMJAMH OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76EAA20", Offset = "0x76E9220", VA = "0x1876EAA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct HMKFGHFJBCL : IEquatable<HMKFGHFJBCL>, IComparable<HMKFGHFJBCL>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly HMKFGHFJBCL PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public HMKFGHFJBCL(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76EADF0", Offset = "0x76E95F0", VA = "0x1876EADF0", Slot = "4")]
	public bool Equals(HMKFGHFJBCL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76EAE20", Offset = "0x76E9620", VA = "0x1876EAE20", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76EADF0", Offset = "0x76E95F0", VA = "0x1876EADF0")]
	public static bool PCBECHOJFKF(HMKFGHFJBCL CBNNCMPLCDK, HMKFGHFJBCL OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76EADC0", Offset = "0x76E95C0", VA = "0x1876EADC0")]
	public static bool DJBIFFEEEPL(HMKFGHFJBCL CBNNCMPLCDK, HMKFGHFJBCL OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(HMKFGHFJBCL LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76EAEC0", Offset = "0x76E96C0", VA = "0x1876EAEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public HMKFGHFJBCL(BIDOOOJOKHK JBFIOKCOJDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FLPCDAIJLMJ : IEquatable<FLPCDAIJLMJ>, IComparable<FLPCDAIJLMJ>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly FLPCDAIJLMJ PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public FLPCDAIJLMJ(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(FLPCDAIJLMJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(FLPCDAIJLMJ LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76EACB0", Offset = "0x76E94B0", VA = "0x1876EACB0", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(FLPCDAIJLMJ CBNNCMPLCDK, FLPCDAIJLMJ OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(FLPCDAIJLMJ CBNNCMPLCDK, FLPCDAIJLMJ OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76EAD50", Offset = "0x76E9550", VA = "0x1876EAD50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct ILOBAEFMBMP : IEquatable<ILOBAEFMBMP>, IComparable<ILOBAEFMBMP>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly ILOBAEFMBMP PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public ILOBAEFMBMP(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(ILOBAEFMBMP LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(ILOBAEFMBMP LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76EB540", Offset = "0x76E9D40", VA = "0x1876EB540", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(ILOBAEFMBMP CBNNCMPLCDK, ILOBAEFMBMP OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(ILOBAEFMBMP CBNNCMPLCDK, ILOBAEFMBMP OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76EB5E0", Offset = "0x76E9DE0", VA = "0x1876EB5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CBCPFENGCGJ : IEquatable<CBCPFENGCGJ>, IComparable<CBCPFENGCGJ>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly CBCPFENGCGJ PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public CBCPFENGCGJ(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(CBCPFENGCGJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(CBCPFENGCGJ LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76EA870", Offset = "0x76E9070", VA = "0x1876EA870", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(CBCPFENGCGJ CBNNCMPLCDK, CBCPFENGCGJ OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(CBCPFENGCGJ CBNNCMPLCDK, CBCPFENGCGJ OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76EA910", Offset = "0x76E9110", VA = "0x1876EA910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct EPONLFNHFNM : IEquatable<EPONLFNHFNM>, IComparable<EPONLFNHFNM>, NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EPONLFNHFNM PNJBLIJBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public EPONLFNHFNM(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(EPONLFNHFNM LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(EPONLFNHFNM LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x76EAA90", Offset = "0x76E9290", VA = "0x1876EAA90", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80")]
	public static bool PCBECHOJFKF(EPONLFNHFNM CBNNCMPLCDK, EPONLFNHFNM OKJLFDLNFEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76EA840", Offset = "0x76E9040", VA = "0x1876EA840")]
	public static bool DJBIFFEEEPL(EPONLFNHFNM CBNNCMPLCDK, EPONLFNHFNM OKJLFDLNFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76EAB30", Offset = "0x76E9330", VA = "0x1876EAB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct PBFIHFHODOL : IEquatable<PBFIHFHODOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? AAHBCEMOKON;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KMEJBLAIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x76EBE20", Offset = "0x76EA620", VA = "0x1876EBE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int NMIHOHJCPLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x47F4CC0", Offset = "0x47F34C0", VA = "0x1847F4CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x76EBF50", Offset = "0x76EA750", VA = "0x1876EBF50")]
	public PBFIHFHODOL(string? IOFEKOEFAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76EBED0", Offset = "0x76EA6D0", VA = "0x1876EBED0")]
	public PBFIHFHODOL(string?[] IFKLMLPDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76EBBF0", Offset = "0x76EA3F0", VA = "0x1876EBBF0")]
	private static string?[]? LIJEHOMDHBL(string?[]? IFKLMLPDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76EBB90", Offset = "0x76EA390", VA = "0x1876EBB90")]
	public string LDEMJAFDPDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76EB9E0", Offset = "0x76EA1E0", VA = "0x1876EB9E0", Slot = "4")]
	public bool Equals(PBFIHFHODOL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76EB950", Offset = "0x76EA150", VA = "0x1876EB950", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x76EBAB0", Offset = "0x76EA2B0", VA = "0x1876EBAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76EBE40", Offset = "0x76EA640", VA = "0x1876EBE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BIDOOOJOKHK : IEquatable<BIDOOOJOKHK>, IComparable<BIDOOOJOKHK>, NLLKPNMALIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid PLMJELCKKDA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
	public BIDOOOJOKHK(Guid PLMJELCKKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
	public Guid HHEEMJGJJOM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4564E80", Offset = "0x4563680", VA = "0x184564E80", Slot = "4")]
	public bool Equals(BIDOOOJOKHK LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4564950", Offset = "0x4563150", VA = "0x184564950", Slot = "5")]
	public int CompareTo(BIDOOOJOKHK LIHCAHPMPHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76EA730", Offset = "0x76E8F30", VA = "0x1876EA730", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4564AC0", Offset = "0x45632C0", VA = "0x184564AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76EA7D0", Offset = "0x76E8FD0", VA = "0x1876EA7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IOIPIFNBCPB<TModern> : JCGDANJMMEE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NANLLNJLBEB(TModern CDCHKCNGEMF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NLLKPNMALIA
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HHEEMJGJJOM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JCGDANJMMEE<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern EJPNLMAGLIE(string CDCHKCNGEMF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONADJBIIBGG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	IOIPIFNBCPB<MCDELACKOKB> GIPJIMECOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IOIPIFNBCPB<FLPCDAIJLMJ> FAPNFFFMBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IOIPIFNBCPB<EPONLFNHFNM> DOGEFPBJILA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IOIPIFNBCPB<HMKFGHFJBCL> LGKBAJJJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IOIPIFNBCPB<DEBOPKMJAMH> NMCIDKEIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IOIPIFNBCPB<CBCPFENGCGJ> FDIBNELBECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IOIPIFNBCPB<FFDNFNMJGGE> OEGKHGBLHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IOIPIFNBCPB<ILOBAEFMBMP> LEGJKABBPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IMDDOKOMEJE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] MDPEPEJHBIP;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76EB650", Offset = "0x76E9E50", VA = "0x1876EB650")]
	public static string[] HFJGFBPDNFB(string? IOFEKOEFAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76EB6F0", Offset = "0x76E9EF0", VA = "0x1876EB6F0")]
	public static string? MHNPMNPDMJP(string? GMIJFBCGEGE)
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
