using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCDF0", Offset = "0x6EFBFF0", VA = "0x186EFCDF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HMIPBOPBBKH : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string JKJBOLDJDEI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EFAB80", Offset = "0x6EF9D80", VA = "0x186EFAB80")]
	public HMIPBOPBBKH(string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2500", Offset = "0x6E1900")]
public class BPMFFHNNPFK<T1, T2> : GCGDLGCIGBG<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MBHKPNGBDEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2570", Offset = "0x6E1970")]
		public OOMFLHAHLDK<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public BPMFFHNNPFK<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public MBHKPNGBDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1230", Offset = "0x2AF0430", VA = "0x182AF1230")]
		internal void EAOJLJMDMMC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KPKHIKHGLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public MBHKPNGBDEO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public KPKHIKHGLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x37DB240", Offset = "0x37DA440", VA = "0x1837DB240")]
		internal void BCIDNGHIKBL(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21FE620", Offset = "0x21FD820", VA = "0x1821FE620")]
	public BPMFFHNNPFK(OOMFLHAHLDK<T1> KCFEOCHNHPF, OOMFLHAHLDK<T2> KFDCFEMPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21FE300", Offset = "0x21FD500", VA = "0x1821FE300")]
	private void PNAPIAJDOJM(string BMNKLBFFLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E25F0", Offset = "0x6E19F0")]
public class CJKGMLMKJPI<T1, T2, T3> : GCGDLGCIGBG<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MELJEJKBHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2660", Offset = "0x6E1A60")]
		public OOMFLHAHLDK<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E26C0", Offset = "0x6E1AC0")]
		public OOMFLHAHLDK<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CJKGMLMKJPI<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public MELJEJKBHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0F90", Offset = "0x2AF0190", VA = "0x182AF0F90")]
		internal void EAOJLJMDMMC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ODCJALAOGCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MELJEJKBHEF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public ODCJALAOGCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DA1A70", Offset = "0x2DA0C70", VA = "0x182DA1A70")]
		internal void BCIDNGHIKBL(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AJDBOHHGNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ODCJALAOGCB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public AJDBOHHGNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28F96F0", Offset = "0x28F88F0", VA = "0x1828F96F0")]
		internal void KLCBDMDNNBA(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26AD050", Offset = "0x26AC250", VA = "0x1826AD050")]
	public CJKGMLMKJPI(OOMFLHAHLDK<T1> KCFEOCHNHPF, OOMFLHAHLDK<T2> KFDCFEMPFHE, OOMFLHAHLDK<T3> FNMFNPJINAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26ACFE0", Offset = "0x26AC1E0", VA = "0x1826ACFE0")]
	private void PNAPIAJDOJM(string BMNKLBFFLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2720", Offset = "0x6E1B20")]
public class EDMFHNKHHJN<T1, T2, T3, T4, T5> : GCGDLGCIGBG<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HKLJLMBKAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2790", Offset = "0x6E1B90")]
		public OOMFLHAHLDK<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E27F0", Offset = "0x6E1BF0")]
		public OOMFLHAHLDK<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2850", Offset = "0x6E1C50")]
		public OOMFLHAHLDK<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E28B0", Offset = "0x6E1CB0")]
		public OOMFLHAHLDK<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EDMFHNKHHJN<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public HKLJLMBKAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x20AB290", Offset = "0x20AA490", VA = "0x1820AB290")]
		internal void EAOJLJMDMMC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FPDHHCOJBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HKLJLMBKAOO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public FPDHHCOJBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5158CB0", Offset = "0x5157EB0", VA = "0x185158CB0")]
		internal void BCIDNGHIKBL(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PALHOLCLLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FPDHHCOJBDM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public PALHOLCLLGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A1A690", Offset = "0x2A19890", VA = "0x182A1A690")]
		internal void KLCBDMDNNBA(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BOOMCNAOLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PALHOLCLLGL CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public BOOMCNAOLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2E6B230", Offset = "0x2E6A430", VA = "0x182E6B230")]
		internal void LFDMIBELGIO(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MOLEDOIDNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BOOMCNAOLFB CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public MOLEDOIDNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x277B190", Offset = "0x277A390", VA = "0x18277B190")]
		internal void OCIGJIAHGPN(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2C2DA10", Offset = "0x2C2CC10", VA = "0x182C2DA10")]
	public EDMFHNKHHJN(OOMFLHAHLDK<T1> KCFEOCHNHPF, OOMFLHAHLDK<T2> KFDCFEMPFHE, OOMFLHAHLDK<T3> FNMFNPJINAB, OOMFLHAHLDK<T4> ILEHCNJMGMO, OOMFLHAHLDK<T5> OIECIJIEFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D9A0", Offset = "0x2C2CBA0", VA = "0x182C2D9A0")]
	private void PNAPIAJDOJM(string BMNKLBFFLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2910", Offset = "0x6E1D10")]
public class NJIDKHOLJHN<T> : GCGDLGCIGBG<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KBDCNHDDPPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NJIDKHOLJHN<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public KBDCNHDDPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22CE300", Offset = "0x22CD500", VA = "0x1822CE300")]
		internal void EAOJLJMDMMC(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2980", Offset = "0x6E1D80")]
	private readonly T[] LECAHAGKPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LODJPCPILBD;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C9E9A0", Offset = "0x2C9DBA0", VA = "0x182C9E9A0")]
	public NJIDKHOLJHN(List<OOMFLHAHLDK<T>> KPHCKAENBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D9B0", Offset = "0x2C9CBB0", VA = "0x182C9D9B0")]
	private void PNAPIAJDOJM(string BMNKLBFFLLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NOINCGAFJMH : MGJKNPFOJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int ILBELBBGDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<GIOBGNHJLID> KPHCKAENBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> LIJBENJGJKI;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC9E0", Offset = "0x6EFBBE0", VA = "0x186EFC9E0")]
	public NOINCGAFJMH(params GIOBGNHJLID[] KPHCKAENBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC9F0", Offset = "0x6EFBBF0", VA = "0x186EFC9F0")]
	public NOINCGAFJMH(IReadOnlyList<GIOBGNHJLID> KPHCKAENBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC8F0", Offset = "0x6EFBAF0", VA = "0x186EFC8F0")]
	private void DBFJHAPIJHL(string PAFNALDKPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC950", Offset = "0x6EFBB50", VA = "0x186EFC950")]
	private void HNDCJCJGLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ABNHCGLENBE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string LBPBFHFKDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBA80", Offset = "0x2CDAC80", VA = "0x182CDBA80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9690", Offset = "0x6EF8890", VA = "0x186EF9690")]
	public ABNHCGLENBE(Exception PMCFOCCCIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9600", Offset = "0x6EF8800", VA = "0x186EF9600")]
	private static string KIFLNGAIJDJ(Exception PMCFOCCCIAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MGJKNPFOJOG : GIOBGNHJLID, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class KHPCONLOGHC<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2B00", Offset = "0x6E1F00")]
		public Func<string, OOMFLHAHLDK<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2B60", Offset = "0x6E1F60")]
		public Func<OOMFLHAHLDK<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2BC0", Offset = "0x6E1FC0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2C20", Offset = "0x6E2020")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public KHPCONLOGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x229B420", Offset = "0x229A620", VA = "0x18229B420")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void GFECCALFEGC(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x229A480", Offset = "0x2299680", VA = "0x18229A480")]
		internal void EBIBBILKBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void OBGNCHDJLEL(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KGEKOAFILFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2C80", Offset = "0x6E2080")]
		public Func<string, GIOBGNHJLID> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public MGJKNPFOJOG newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2CE0", Offset = "0x6E20E0")]
		public Func<GIOBGNHJLID> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2D40", Offset = "0x6E2140")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2DA0", Offset = "0x6E21A0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public KGEKOAFILFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFADF0", Offset = "0x6EF9FF0", VA = "0x186EFADF0")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void GFECCALFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAC80", Offset = "0x6EF9E80", VA = "0x186EFAC80")]
		internal void EBIBBILKBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void OBGNCHDJLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BCGKCBNMEOE<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public BCGKCBNMEOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x12894E0", Offset = "0x12886E0", VA = "0x1812894E0")]
		internal void FGILAMCGDKJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1289340", Offset = "0x1288540", VA = "0x181289340")]
		internal void EADHBMLELNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IDLAOLMOAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MGJKNPFOJOG newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2E00", Offset = "0x6E2200")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public IDLAOLMOAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAC00", Offset = "0x6EF9E00", VA = "0x186EFAC00")]
		internal void HOACEHLBOON(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xADCE40", Offset = "0xADC040", VA = "0x180ADCE40")]
		internal void CPJABMCLIDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string GOMJMPJDLBL = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> BPADEIKNAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> JDEDKMIEONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> FHIHOLIAPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? BMNKLBFFLLF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GIOBGNHJLID EDOOJMPLEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB550", Offset = "0x6EFA750", VA = "0x186EFB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x929880", Offset = "0x928A80", VA = "0x180929880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9298C0", Offset = "0x928AC0", VA = "0x1809298C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EPJMJIDMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB830", Offset = "0x6EFAA30", VA = "0x186EFB830", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ELPDNCJOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB280", Offset = "0x6EFA480", VA = "0x186EFB280", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBE20", Offset = "0x6EFB020", VA = "0x186EFBE20")]
	static MGJKNPFOJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1244790", Offset = "0x1243990", VA = "0x181244790")]
	public static OOMFLHAHLDK<T> OBKEHNPLLOF<T>(T GAMJEJDMFJF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB7C0", Offset = "0x6EFA9C0", VA = "0x186EFB7C0")]
	public static GIOBGNHJLID MHCAPODBLID(string BMNKLBFFLLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1244790", Offset = "0x1243990", VA = "0x181244790")]
	public static OOMFLHAHLDK<T> MHCAPODBLID<T>(string BMNKLBFFLLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBAA0", Offset = "0x6EFACA0", VA = "0x186EFBAA0", Slot = "8")]
	public GIOBGNHJLID PGIDHPHLEPO(Action<string> DEIBMMIADFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB0C0", Offset = "0x6EFA2C0", VA = "0x186EFB0C0", Slot = "17")]
	public virtual GIOBGNHJLID EBDFGNEODLO(Action JACEKCOOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB2A0", Offset = "0x6EFA4A0", VA = "0x186EFB2A0", Slot = "7")]
	public GIOBGNHJLID GMJEKMCMECC(Action ENIHHNBDCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1243B70", Offset = "0x1242D70", VA = "0x181243B70", Slot = "10")]
	public OOMFLHAHLDK<TNew> HNLHJKHOEEG<TNew>(Func<OOMFLHAHLDK<TNew>> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2A40", Offset = "0x6E1E40")] Func<string, OOMFLHAHLDK<TNew>> BHCABJMMHPI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB330", Offset = "0x6EFA530", VA = "0x186EFB330", Slot = "11")]
	public GIOBGNHJLID HNLHJKHOEEG(Func<GIOBGNHJLID> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2AA0", Offset = "0x6E1EA0")] Func<string, GIOBGNHJLID> BHCABJMMHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1244190", Offset = "0x1243390", VA = "0x181244190", Slot = "12")]
	public OOMFLHAHLDK<TNew> JIMDMFMPBIG<TNew>(Func<TNew> ALFHHLHDOBI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB5B0", Offset = "0x6EFA7B0", VA = "0x186EFB5B0", Slot = "13")]
	public GIOBGNHJLID IKHPIDGJLJB(Func<string, string> ALFHHLHDOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5B8DD60", Offset = "0x5B8CF60", VA = "0x185B8DD60", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB850", Offset = "0x6EFAA50", VA = "0x186EFB850")]
	public void OJAKBINLFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBB40", Offset = "0x6EFAD40", VA = "0x186EFBB40")]
	public void PGIDHPHLEPO(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB140", Offset = "0x6EFA340", VA = "0x186EFB140")]
	protected Exception? FFNJDEJILIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EFB040", Offset = "0x6EFA240", VA = "0x186EFB040", Slot = "18")]
	protected virtual void CIPLOHDEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBE90", Offset = "0x6EFB090", VA = "0x186EFBE90")]
	public MGJKNPFOJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCGDLGCIGBG<T> : OOMFLHAHLDK<T>, GIOBGNHJLID, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct ALJKLGPFMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3040", Offset = "0x6E2440")]
		public readonly Action<T> AMEKOPCKNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? FBABMHENGLA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB29AE0", Offset = "0xB28CE0", VA = "0x180B29AE0")]
		public ALJKLGPFMJJ(Action<T> AMEKOPCKNIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB29B10", Offset = "0xB28D10", VA = "0x180B29B10")]
		public ALJKLGPFMJJ(Action FBABMHENGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2004490", Offset = "0x2003690", VA = "0x182004490")]
		public void LDFPBHJMNFE(T GJNKBDPFGGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CGGIPOAPMOC<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E30A0", Offset = "0x6E24A0")]
		public Func<string, OOMFLHAHLDK<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3100", Offset = "0x6E2500")]
		public Func<OOMFLHAHLDK<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3160", Offset = "0x6E2560")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E31C0", Offset = "0x6E25C0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public CGGIPOAPMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E80240", Offset = "0x3E7F440", VA = "0x183E80240")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void GFECCALFEGC(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E540", Offset = "0x3E6D740", VA = "0x183E6E540")]
		internal void EBIBBILKBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void OBGNCHDJLEL(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MFGEGNGBNKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3220", Offset = "0x6E2620")]
		public Func<string, GIOBGNHJLID> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MGJKNPFOJOG newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3280", Offset = "0x6E2680")]
		public Func<GIOBGNHJLID> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E32E0", Offset = "0x6E26E0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3340", Offset = "0x6E2740")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public MFGEGNGBNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFCD0", Offset = "0x2AFEED0", VA = "0x182AFFCD0")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void GFECCALFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBD50", Offset = "0x2AFAF50", VA = "0x182AFBD50")]
		internal void EBIBBILKBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void OBGNCHDJLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OEBHPCBGOGJ<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E33A0", Offset = "0x6E27A0")]
		public Func<string, OOMFLHAHLDK<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3400", Offset = "0x6E2800")]
		public Func<T, OOMFLHAHLDK<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3460", Offset = "0x6E2860")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E34C0", Offset = "0x6E28C0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public OEBHPCBGOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9350", Offset = "0x2DA8550", VA = "0x182DA9350")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void GFECCALFEGC(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2DA4EA0", Offset = "0x2DA40A0", VA = "0x182DA4EA0")]
		internal void EBIBBILKBMK(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x229A7E0", Offset = "0x22999E0", VA = "0x18229A7E0")]
		internal void OBGNCHDJLEL(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JEDFBPKJHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3520", Offset = "0x6E2920")]
		public Func<string, GIOBGNHJLID> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MGJKNPFOJOG newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3580", Offset = "0x6E2980")]
		public Func<T, GIOBGNHJLID> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E35E0", Offset = "0x6E29E0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3640", Offset = "0x6E2A40")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public JEDFBPKJHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2FEFB20", Offset = "0x2FEED20", VA = "0x182FEFB20")]
		internal void PBHADENGBNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void OBDMNANIHDC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void GFECCALFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA3A0", Offset = "0x2FE95A0", VA = "0x182FEA3A0")]
		internal void EBIBBILKBMK(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1601950", Offset = "0x1600B50", VA = "0x181601950")]
		internal void JFLKJIDEMEN(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x104EF30", Offset = "0x104E130", VA = "0x18104EF30")]
		internal void OBGNCHDJLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IGEDNNDMFCF<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public IGEDNNDMFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12894E0", Offset = "0x12886E0", VA = "0x1812894E0")]
		internal void FGILAMCGDKJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1289340", Offset = "0x1288540", VA = "0x181289340")]
		internal void EADHBMLELNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KAAGICLPNIH<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GCGDLGCIGBG<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E36A0", Offset = "0x6E2AA0")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public KAAGICLPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x12894E0", Offset = "0x12886E0", VA = "0x1812894E0")]
		internal void FGILAMCGDKJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x22CAC70", Offset = "0x22C9E70", VA = "0x1822CAC70")]
		internal void EADHBMLELNL(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EKPMFFGEHHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MGJKNPFOJOG newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3700", Offset = "0x6E2B00")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public EKPMFFGEHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x31446E0", Offset = "0x31438E0", VA = "0x1831446E0")]
		internal void NDIPFGICIEL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xADCE40", Offset = "0xADC040", VA = "0x180ADCE40")]
		internal void BIEDNBLBAOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AFOINNKMKFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3760", Offset = "0x6E2B60")]
		public GCGDLGCIGBG<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E37C0", Offset = "0x6E2BC0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public AFOINNKMKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x28EC640", Offset = "0x28EB840", VA = "0x1828EC640")]
		internal void HOACEHLBOON(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x28EB200", Offset = "0x28EA400", VA = "0x1828EB200")]
		internal void CPJABMCLIDP(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2E60", Offset = "0x6E2260")]
	private readonly List<GCGDLGCIGBG<T>.ALJKLGPFMJJ> FHIHOLIAPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> BPADEIKNAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> JDEDKMIEONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? BMNKLBFFLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T GAMJEJDMFJF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA92EC0", Offset = "0xA920C0", VA = "0x180A92EC0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x904E30", Offset = "0x904030", VA = "0x180904E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EPJMJIDMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3330610", Offset = "0x332F810", VA = "0x183330610", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ELPDNCJOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x332F070", Offset = "0x332E270", VA = "0x18332F070", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D10", Offset = "0x7E3F10", VA = "0x1807E4D10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x33304F0", Offset = "0x332F6F0", VA = "0x1833304F0")]
	public static OOMFLHAHLDK<T> MHCAPODBLID(string JPOEHOENKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3331060", Offset = "0x3330260", VA = "0x183331060", Slot = "6")]
	public OOMFLHAHLDK<T> PGIDHPHLEPO(Action<string> DEIBMMIADFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x332EA80", Offset = "0x332DC80", VA = "0x18332EA80", Slot = "25")]
	public virtual OOMFLHAHLDK<T> EBDFGNEODLO(Action JACEKCOOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x332F0C0", Offset = "0x332E2C0", VA = "0x18332F0C0", Slot = "5")]
	public OOMFLHAHLDK<T> GMJEKMCMECC(Action ENIHHNBDCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x332F360", Offset = "0x332E560", VA = "0x18332F360", Slot = "4")]
	public OOMFLHAHLDK<T> GMJEKMCMECC(Action<T> ENIHHNBDCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xF7E9A0", Offset = "0xF7DBA0", VA = "0x180F7E9A0", Slot = "18")]
	public OOMFLHAHLDK<TNew> HNLHJKHOEEG<TNew>(Func<OOMFLHAHLDK<TNew>> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2EC0", Offset = "0x6E22C0")] Func<string, OOMFLHAHLDK<TNew>> BHCABJMMHPI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x332FD60", Offset = "0x332EF60", VA = "0x18332FD60", Slot = "19")]
	public GIOBGNHJLID HNLHJKHOEEG(Func<GIOBGNHJLID> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2F20", Offset = "0x6E2320")] Func<string, GIOBGNHJLID> BHCABJMMHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2AC19F0", Offset = "0x2AC0BF0", VA = "0x182AC19F0", Slot = "8")]
	public OOMFLHAHLDK<TNew> HNLHJKHOEEG<TNew>(Func<T, OOMFLHAHLDK<TNew>> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2F80", Offset = "0x6E2380")] Func<string, OOMFLHAHLDK<TNew>> BHCABJMMHPI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x332F440", Offset = "0x332E640", VA = "0x18332F440", Slot = "9")]
	public GIOBGNHJLID HNLHJKHOEEG(Func<T, GIOBGNHJLID> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E2FE0", Offset = "0x6E23E0")] Func<string, GIOBGNHJLID> BHCABJMMHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xF82180", Offset = "0xF81380", VA = "0x180F82180", Slot = "20")]
	public OOMFLHAHLDK<TNew> JIMDMFMPBIG<TNew>(Func<TNew> ALFHHLHDOBI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE660", Offset = "0x2ACD860", VA = "0x182ACE660", Slot = "10")]
	public OOMFLHAHLDK<TNew> JIMDMFMPBIG<TNew>(Func<T, TNew> ALFHHLHDOBI) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x332E5A0", Offset = "0x332D7A0", VA = "0x18332E5A0", Slot = "21")]
	private GIOBGNHJLID DDMLLMGPAFD(Func<string, string> ALFHHLHDOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x332FF20", Offset = "0x332F120", VA = "0x18332FF20", Slot = "11")]
	public OOMFLHAHLDK<T> IKHPIDGJLJB(Func<string, string> ALFHHLHDOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3331D80", Offset = "0x3330F80", VA = "0x183331D80", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x312C250", Offset = "0x312B450", VA = "0x18312C250", Slot = "15")]
	private GIOBGNHJLID FAFDNLJIACD(Action ENIHHNBDCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2928E40", Offset = "0x2928040", VA = "0x182928E40", Slot = "16")]
	private GIOBGNHJLID NIOJCGJOKFE(Action<string> DEIBMMIADFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x332E1D0", Offset = "0x332D3D0", VA = "0x18332E1D0", Slot = "17")]
	private GIOBGNHJLID CENCAKDIEMJ(Action JACEKCOOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x52302E0", Offset = "0x522F4E0", VA = "0x1852302E0")]
	public void OJAKBINLFPA(T GJNKBDPFGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x332ECF0", Offset = "0x332DEF0", VA = "0x18332ECF0")]
	protected Exception? FFNJDEJILIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5236BF0", Offset = "0x5235DF0", VA = "0x185236BF0")]
	public void PGIDHPHLEPO(string JPOEHOENKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x332E200", Offset = "0x332D400", VA = "0x18332E200", Slot = "26")]
	protected virtual void CIPLOHDEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5239D00", Offset = "0x5238F00", VA = "0x185239D00")]
	public GCGDLGCIGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GIOBGNHJLID : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EPJMJIDMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ELPDNCJOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GIOBGNHJLID GMJEKMCMECC(Action ENIHHNBDCLM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GIOBGNHJLID PGIDHPHLEPO(Action<string> DEIBMMIADFB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GIOBGNHJLID EBDFGNEODLO(Action JACEKCOOJND);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOMFLHAHLDK<TNew> HNLHJKHOEEG<TNew>(Func<OOMFLHAHLDK<TNew>> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3820", Offset = "0x6E2C20")] Func<string, OOMFLHAHLDK<TNew>> BHCABJMMHPI) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GIOBGNHJLID HNLHJKHOEEG(Func<GIOBGNHJLID> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3880", Offset = "0x6E2C80")] Func<string, GIOBGNHJLID> BHCABJMMHPI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OOMFLHAHLDK<TNew> JIMDMFMPBIG<TNew>(Func<TNew> ALFHHLHDOBI) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GIOBGNHJLID IKHPIDGJLJB(Func<string, string> ALFHHLHDOBI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OOMFLHAHLDK<out T> : GIOBGNHJLID, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOMFLHAHLDK<T> GMJEKMCMECC(Action<T> ENIHHNBDCLM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new OOMFLHAHLDK<T> GMJEKMCMECC(Action ENIHHNBDCLM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new OOMFLHAHLDK<T> PGIDHPHLEPO(Action<string> DEIBMMIADFB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new OOMFLHAHLDK<T> EBDFGNEODLO(Action JACEKCOOJND);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOMFLHAHLDK<TNew> HNLHJKHOEEG<TNew>(Func<T, OOMFLHAHLDK<TNew>> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E38E0", Offset = "0x6E2CE0")] Func<string, OOMFLHAHLDK<TNew>> BHCABJMMHPI) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GIOBGNHJLID HNLHJKHOEEG(Func<T, GIOBGNHJLID> ALFHHLHDOBI, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3940", Offset = "0x6E2D40")] Func<string, GIOBGNHJLID> BHCABJMMHPI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOMFLHAHLDK<TNew> JIMDMFMPBIG<TNew>(Func<T, TNew> ALFHHLHDOBI) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new OOMFLHAHLDK<T> IKHPIDGJLJB(Func<string, string> ALFHHLHDOBI);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class MMPFDOJIMMK
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum ADEABGOMOBL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DHKHKLNJJNN : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA6D0", Offset = "0x6EF98D0", VA = "0x186EFA6D0")]
		public DHKHKLNJJNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DKLBKLPHMNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public DKLBKLPHMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA790", Offset = "0x6EF9990", VA = "0x186EFA790")]
		internal void GNFMIOLOGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA7E0", Offset = "0x6EF99E0", VA = "0x186EFA7E0")]
		internal void MOPNGPNOBEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA740", Offset = "0x6EF9940", VA = "0x186EFA740")]
		internal void ECFCODGJOGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FGBLMJPJCJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CICCNDFLPHA cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ADEABGOMOBL unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public FGBLMJPJCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA910", Offset = "0x6EF9B10", VA = "0x186EFA910")]
		internal void GNFMIOLOGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAAF0", Offset = "0x6EF9CF0", VA = "0x186EFAAF0")]
		internal void MOPNGPNOBEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA870", Offset = "0x6EF9A70", VA = "0x186EFA870")]
		internal void ECFCODGJOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA960", Offset = "0x6EF9B60", VA = "0x186EFA960")]
		internal void JAMNKLNOGLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LGJFOFCLKGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LGJFOFCLKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x209DE40", Offset = "0x209D040", VA = "0x18209DE40")]
		internal void KJMMLOAHAAK(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class AEBNDOGGNOJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public AEBNDOGGNOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2310F00", Offset = "0x2310100", VA = "0x182310F00")]
		internal void GNFMIOLOGPM(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x28E6B90", Offset = "0x28E5D90", VA = "0x1828E6B90")]
		internal void MOPNGPNOBEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x226B190", Offset = "0x226A390", VA = "0x18226B190")]
		internal void ECFCODGJOGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CEBCOKEIGJD<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CICCNDFLPHA cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ADEABGOMOBL unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public CEBCOKEIGJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E508B0", Offset = "0x1E4FAB0", VA = "0x181E508B0")]
		internal void GNFMIOLOGPM(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E50C10", Offset = "0x1E4FE10", VA = "0x181E50C10")]
		internal void MOPNGPNOBEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E50770", Offset = "0x1E4F970", VA = "0x181E50770")]
		internal void ECFCODGJOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E50A40", Offset = "0x1E4FC40", VA = "0x181E50A40")]
		internal void JAMNKLNOGLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HFHPIDMJINN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public HFHPIDMJINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x209DE40", Offset = "0x209D040", VA = "0x18209DE40")]
		internal void KJMMLOAHAAK(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LHGAKOLFJKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MGJKNPFOJOG promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LHGAKOLFJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EFAF80", Offset = "0x6EFA180", VA = "0x186EFAF80")]
		internal void HPDBLKBJGCG(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FAJLMDGIKJD<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GCGDLGCIGBG<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public FAJLMDGIKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1C63930", Offset = "0x1C62B30", VA = "0x181C63930")]
		internal void HPDBLKBJGCG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E39E0", Offset = "0x6E2DE0")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC6E0", Offset = "0x6EFB8E0", VA = "0x186EFC6E0")]
	public static Task PHBFEHILHCO(this GIOBGNHJLID HBNJPDHFEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC360", Offset = "0x6EFB560", VA = "0x186EFC360")]
	public static Task<bool> PHBFEHILHCO(this GIOBGNHJLID HBNJPDHFEKF, CancellationToken MELLLMEKJLC, ADEABGOMOBL DFLJOHKJEDO = ADEABGOMOBL.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x124C240", Offset = "0x124B440", VA = "0x18124C240")]
	public static Task<TResult> PHBFEHILHCO<TResult>(this OOMFLHAHLDK<TResult> HBNJPDHFEKF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x124C470", Offset = "0x124B670", VA = "0x18124C470")]
	public static Task<TResult> PHBFEHILHCO<TResult>(this OOMFLHAHLDK<TResult> HBNJPDHFEKF, CancellationToken MELLLMEKJLC, ADEABGOMOBL DFLJOHKJEDO = ADEABGOMOBL.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC330", Offset = "0x6EFB530", VA = "0x186EFC330")]
	public static TaskAwaiter MNBEJFECGED(this GIOBGNHJLID HBNJPDHFEKF)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x124B370", Offset = "0x124A570", VA = "0x18124B370")]
	public static TaskAwaiter<TResult> MNBEJFECGED<TResult>(this OOMFLHAHLDK<TResult> HBNJPDHFEKF) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EFBF90", Offset = "0x6EFB190", VA = "0x186EFBF90")]
	public static GIOBGNHJLID JJHBEGMKKFH(this Task EEILDIKJMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x124B050", Offset = "0x124A250", VA = "0x18124B050")]
	public static OOMFLHAHLDK<TResult> JJHBEGMKKFH<TResult>(this Task<TResult> EEILDIKJMBL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EFC160", Offset = "0x6EFB360", VA = "0x186EFC160")]
	private static string LJFAAAMPDIK(Task EEILDIKJMBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface CICCNDFLPHA : GIOBGNHJLID, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HJKENLBILGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KDACCCDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACJHAMOBBFB();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CICCNDFLPHA KBEHPDMKFLA(Action GABMEKJCIHL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LIOCOMLDBDP<T> : OOMFLHAHLDK<T>, GIOBGNHJLID, IEnumerator, CICCNDFLPHA
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new LIOCOMLDBDP<T> KBEHPDMKFLA(Action GABMEKJCIHL);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BOBANGGLKDD : MGJKNPFOJOG, CICCNDFLPHA, GIOBGNHJLID, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> GABMEKJCIHL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static CICCNDFLPHA NCDDPLAMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA410", Offset = "0x6EF9610", VA = "0x186EFA410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HJKENLBILGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA92EC0", Offset = "0xA920C0", VA = "0x180A92EC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x904E30", Offset = "0x904030", VA = "0x180904E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KDACCCDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA400", Offset = "0x6EF9600", VA = "0x186EFA400", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA4F0", Offset = "0x6EF96F0", VA = "0x186EFA4F0")]
	static BOBANGGLKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1244790", Offset = "0x1243990", VA = "0x181244790")]
	public new static LIOCOMLDBDP<T> OBKEHNPLLOF<T>(T GAMJEJDMFJF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1244790", Offset = "0x1243990", VA = "0x181244790")]
	public new static LIOCOMLDBDP<T> MHCAPODBLID<T>(string BMNKLBFFLLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA0D0", Offset = "0x6EF92D0", VA = "0x186EFA0D0", Slot = "21")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA470", Offset = "0x6EF9670", VA = "0x186EFA470", Slot = "22")]
	public CICCNDFLPHA KBEHPDMKFLA(Action DOKABDGBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA320", Offset = "0x6EF9520", VA = "0x186EFA320", Slot = "18")]
	protected override void CIPLOHDEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA370", Offset = "0x6EF9570", VA = "0x186EFA370", Slot = "17")]
	public override GIOBGNHJLID EBDFGNEODLO(Action JACEKCOOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA620", Offset = "0x6EF9820", VA = "0x186EFA620")]
	public BOBANGGLKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E3A40", Offset = "0x6E2E40")]
public class FIBDDEABMHC<T> : GCGDLGCIGBG<T>, LIOCOMLDBDP<T>, OOMFLHAHLDK<T>, GIOBGNHJLID, IEnumerator, CICCNDFLPHA where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> GABMEKJCIHL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HJKENLBILGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA4C060", Offset = "0xA4B260", VA = "0x180A4C060", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA4C070", Offset = "0xA4B270", VA = "0x180A4C070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KDACCCDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C10A30", Offset = "0x2C0FC30", VA = "0x182C10A30", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C102A0", Offset = "0x2C0F4A0", VA = "0x182C102A0", Slot = "30")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C10AA0", Offset = "0x2C0FCA0", VA = "0x182C10AA0", Slot = "27")]
	public LIOCOMLDBDP<T> KBEHPDMKFLA(Action DOKABDGBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1770", Offset = "0x2AF0970", VA = "0x182AF1770", Slot = "31")]
	private CICCNDFLPHA OJKNPNEMGPE(Action DOKABDGBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C10930", Offset = "0x2C0FB30", VA = "0x182C10930", Slot = "26")]
	protected override void CIPLOHDEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C109A0", Offset = "0x2C0FBA0", VA = "0x182C109A0", Slot = "25")]
	public override OOMFLHAHLDK<T> EBDFGNEODLO(Action JACEKCOOJND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C10C00", Offset = "0x2C0FE00", VA = "0x182C10C00")]
	public FIBDDEABMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ACMGMPPLACF : NOINCGAFJMH, CICCNDFLPHA, GIOBGNHJLID, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> GABMEKJCIHL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HJKENLBILGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E24E0", Offset = "0x7E16E0", VA = "0x1807E24E0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x934B20", Offset = "0x933D20", VA = "0x180934B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KDACCCDGHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6EF9C60", Offset = "0x6EF8E60", VA = "0x186EF9C60", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9CF0", Offset = "0x6EF8EF0", VA = "0x186EF9CF0")]
	public ACMGMPPLACF(CICCNDFLPHA HBNJPDHFEKF, CICCNDFLPHA FHNLGIDOPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9E10", Offset = "0x6EF9010", VA = "0x186EF9E10")]
	public ACMGMPPLACF(IList<CICCNDFLPHA> KPHCKAENBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9780", Offset = "0x6EF8980", VA = "0x186EF9780", Slot = "21")]
	public void ACJHAMOBBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9C70", Offset = "0x6EF8E70", VA = "0x186EF9C70", Slot = "22")]
	public CICCNDFLPHA KBEHPDMKFLA(Action DOKABDGBAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9B80", Offset = "0x6EF8D80", VA = "0x186EF9B80", Slot = "18")]
	protected override void CIPLOHDEGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9BD0", Offset = "0x6EF8DD0", VA = "0x186EF9BD0", Slot = "17")]
	public override GIOBGNHJLID EBDFGNEODLO(Action JACEKCOOJND)
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
