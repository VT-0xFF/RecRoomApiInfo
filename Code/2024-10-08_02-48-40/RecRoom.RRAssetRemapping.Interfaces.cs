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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AC390", Offset = "0x73AB590", VA = "0x1873AC390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPHNFBMHBNO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LMOHAAKIFFE(LGIGHIHBKAO GJDJIDOLBAE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGIGHIHBKAO GBKBNNNFJGC(string GJDJIDOLBAE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LGIGHIHBKAO : IEquatable<LGIGHIHBKAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ODIOBCFCCOG DCNINFNKNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FPAFDHKJIGP PMEHNCMGNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid ALIKILDEAPM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LNMOIILKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73ABDC0", Offset = "0x73AAFC0", VA = "0x1873ABDC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BPGIPMOJODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73ABB10", Offset = "0x73AAD10", VA = "0x1873ABB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73AC150", Offset = "0x73AB350", VA = "0x1873AC150")]
	public LGIGHIHBKAO(LGIGHIHBKAO GGLGMJGEPEG, [Optional] Guid LKJJNNCNEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3DF0", Offset = "0x4FB2FF0", VA = "0x184FB3DF0")]
	public LGIGHIHBKAO(ODIOBCFCCOG NLJPJFBHJII, FPAFDHKJIGP MHCCGDDCFLD, [Optional] Guid LKJJNNCNEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73ABC00", Offset = "0x73AAE00", VA = "0x1873ABC00", Slot = "4")]
	public bool Equals(LGIGHIHBKAO KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73ABB50", Offset = "0x73AAD50", VA = "0x1873ABB50", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73ABD00", Offset = "0x73AAF00", VA = "0x1873ABD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x73ABD90", Offset = "0x73AAF90", VA = "0x1873ABD90")]
	public static bool IELJJBKMIFI(LGIGHIHBKAO PCICJLNHPMM, LGIGHIHBKAO OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x73ABCC0", Offset = "0x73AAEC0", VA = "0x1873ABCC0")]
	public static bool FNBDEMDKLNM(LGIGHIHBKAO PCICJLNHPMM, LGIGHIHBKAO OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73ABE50", Offset = "0x73AB050", VA = "0x1873ABE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ODIOBCFCCOG : IEquatable<ODIOBCFCCOG>, IComparable<ODIOBCFCCOG>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public static readonly ODIOBCFCCOG NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public ODIOBCFCCOG(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(ODIOBCFCCOG KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(ODIOBCFCCOG KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73AC410", Offset = "0x73AB610", VA = "0x1873AC410", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(ODIOBCFCCOG PCICJLNHPMM, ODIOBCFCCOG OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(ODIOBCFCCOG PCICJLNHPMM, ODIOBCFCCOG OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73AC4B0", Offset = "0x73AB6B0", VA = "0x1873AC4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NBLMKFLHGGA : IEquatable<NBLMKFLHGGA>, IComparable<NBLMKFLHGGA>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static readonly NBLMKFLHGGA NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public NBLMKFLHGGA(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(NBLMKFLHGGA KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(NBLMKFLHGGA KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x73AC280", Offset = "0x73AB480", VA = "0x1873AC280", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(NBLMKFLHGGA PCICJLNHPMM, NBLMKFLHGGA OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(NBLMKFLHGGA PCICJLNHPMM, NBLMKFLHGGA OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73AC320", Offset = "0x73AB520", VA = "0x1873AC320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct GEBFPKLICLC : IEquatable<GEBFPKLICLC>, IComparable<GEBFPKLICLC>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public static readonly GEBFPKLICLC NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public GEBFPKLICLC(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(GEBFPKLICLC KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(GEBFPKLICLC KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73AB8A0", Offset = "0x73AAAA0", VA = "0x1873AB8A0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(GEBFPKLICLC PCICJLNHPMM, GEBFPKLICLC OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(GEBFPKLICLC PCICJLNHPMM, GEBFPKLICLC OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73AB940", Offset = "0x73AAB40", VA = "0x1873AB940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FPAFDHKJIGP : IEquatable<FPAFDHKJIGP>, IComparable<FPAFDHKJIGP>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly FPAFDHKJIGP NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public FPAFDHKJIGP(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73AB7D0", Offset = "0x73AA9D0", VA = "0x1873AB7D0", Slot = "4")]
	public bool Equals(FPAFDHKJIGP KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73AB730", Offset = "0x73AA930", VA = "0x1873AB730", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73AB7D0", Offset = "0x73AA9D0", VA = "0x1873AB7D0")]
	public static bool IELJJBKMIFI(FPAFDHKJIGP PCICJLNHPMM, FPAFDHKJIGP OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73AB800", Offset = "0x73AAA00", VA = "0x1873AB800")]
	public static bool FNBDEMDKLNM(FPAFDHKJIGP PCICJLNHPMM, FPAFDHKJIGP OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(FPAFDHKJIGP KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73AB830", Offset = "0x73AAA30", VA = "0x1873AB830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public FPAFDHKJIGP(CKOHHNJGGJB OFACKENAILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FAGOMDOIJDM : IEquatable<FAGOMDOIJDM>, IComparable<FAGOMDOIJDM>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly FAGOMDOIJDM NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public FAGOMDOIJDM(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(FAGOMDOIJDM KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(FAGOMDOIJDM KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73AB620", Offset = "0x73AA820", VA = "0x1873AB620", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(FAGOMDOIJDM PCICJLNHPMM, FAGOMDOIJDM OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(FAGOMDOIJDM PCICJLNHPMM, FAGOMDOIJDM OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73AB6C0", Offset = "0x73AA8C0", VA = "0x1873AB6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct DIAKMFLOOAA : IEquatable<DIAKMFLOOAA>, IComparable<DIAKMFLOOAA>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly DIAKMFLOOAA NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public DIAKMFLOOAA(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(DIAKMFLOOAA KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(DIAKMFLOOAA KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73AB510", Offset = "0x73AA710", VA = "0x1873AB510", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(DIAKMFLOOAA PCICJLNHPMM, DIAKMFLOOAA OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(DIAKMFLOOAA PCICJLNHPMM, DIAKMFLOOAA OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73AB5B0", Offset = "0x73AA7B0", VA = "0x1873AB5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct LHALHLNOGDB : IEquatable<LHALHLNOGDB>, IComparable<LHALHLNOGDB>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LHALHLNOGDB NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public LHALHLNOGDB(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(LHALHLNOGDB KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(LHALHLNOGDB KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73AC170", Offset = "0x73AB370", VA = "0x1873AC170", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(LHALHLNOGDB PCICJLNHPMM, LHALHLNOGDB OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(LHALHLNOGDB PCICJLNHPMM, LHALHLNOGDB OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73AC210", Offset = "0x73AB410", VA = "0x1873AC210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ADHGKFCEMKH : IEquatable<ADHGKFCEMKH>, IComparable<ADHGKFCEMKH>, LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly ADHGKFCEMKH NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public ADHGKFCEMKH(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(ADHGKFCEMKH KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(ADHGKFCEMKH KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x73AB2C0", Offset = "0x73AA4C0", VA = "0x1873AB2C0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0")]
	public static bool IELJJBKMIFI(ADHGKFCEMKH PCICJLNHPMM, ADHGKFCEMKH OIJJJJFPNNN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x73AB360", Offset = "0x73AA560", VA = "0x1873AB360")]
	public static bool FNBDEMDKLNM(ADHGKFCEMKH PCICJLNHPMM, ADHGKFCEMKH OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73AB390", Offset = "0x73AA590", VA = "0x1873AB390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct OOBMPNMLJGF : IEquatable<OOBMPNMLJGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly string?[]? GPGCNMEMANN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73AC9F0", Offset = "0x73ABBF0", VA = "0x1873AC9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BPEBADGPGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4638C50", Offset = "0x4637E50", VA = "0x184638C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73ACB20", Offset = "0x73ABD20", VA = "0x1873ACB20")]
	public OOBMPNMLJGF(string? PHCMPADBEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73ACAA0", Offset = "0x73ABCA0", VA = "0x1873ACAA0")]
	public OOBMPNMLJGF(string?[] DPNELJODLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x73AC7C0", Offset = "0x73AB9C0", VA = "0x1873AC7C0")]
	private static string?[]? JJCKJIDFLBM(string?[]? DPNELJODLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73AC520", Offset = "0x73AB720", VA = "0x1873AC520")]
	public string CPILGPCDJHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73AC610", Offset = "0x73AB810", VA = "0x1873AC610", Slot = "4")]
	public bool Equals(OOBMPNMLJGF KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x73AC580", Offset = "0x73AB780", VA = "0x1873AC580", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73AC6E0", Offset = "0x73AB8E0", VA = "0x1873AC6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73ACA10", Offset = "0x73ABC10", VA = "0x1873ACA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CKOHHNJGGJB : IEquatable<CKOHHNJGGJB>, IComparable<CKOHHNJGGJB>, LPODAIJOFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid KGBBBBHDKAF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
	public CKOHHNJGGJB(Guid KGBBBBHDKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public Guid HFODIEEOGLP()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4352AE0", Offset = "0x4351CE0", VA = "0x184352AE0", Slot = "4")]
	public bool Equals(CKOHHNJGGJB KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4352830", Offset = "0x4351A30", VA = "0x184352830", Slot = "5")]
	public int CompareTo(CKOHHNJGGJB KDHPJMADEAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73AB400", Offset = "0x73AA600", VA = "0x1873AB400", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4352910", Offset = "0x4351B10", VA = "0x184352910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73AB4A0", Offset = "0x73AA6A0", VA = "0x1873AB4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MHOPPHPACNL<TModern> : CDJAFDNENCP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IIPGMLBJBLK(TModern DABAHNBGCGM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LPODAIJOFKC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid HFODIEEOGLP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CDJAFDNENCP<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern GECKOMFJIDF(string DABAHNBGCGM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BEJANLLLKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MHOPPHPACNL<ODIOBCFCCOG> EEGJNCOIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MHOPPHPACNL<FAGOMDOIJDM> DJDIEBKNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MHOPPHPACNL<ADHGKFCEMKH> ELIAHKEHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MHOPPHPACNL<FPAFDHKJIGP> HOMHEPKEPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MHOPPHPACNL<GEBFPKLICLC> HDKJGICDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MHOPPHPACNL<LHALHLNOGDB> LLAIPJLPJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MHOPPHPACNL<NBLMKFLHGGA> FHPPCHJJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MHOPPHPACNL<DIAKMFLOOAA> CKEAKMADPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KNCFBPOKOEN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static readonly char[] LENCNAPBKFP;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73AB9B0", Offset = "0x73AABB0", VA = "0x1873AB9B0")]
	public static string[] LAGBDKNDOOJ(string? PHCMPADBEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73ABA50", Offset = "0x73AAC50", VA = "0x1873ABA50")]
	public static string? OPJIGDDCPMG(string? NLJPJFBHJII)
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
