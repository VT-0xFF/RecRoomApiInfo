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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x71EB260", Offset = "0x71E9860", VA = "0x1871EB260")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GEJOCCMDMFO : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string CBFCGDCCJDI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71E8330", Offset = "0x71E6930", VA = "0x1871E8330")]
	public GEJOCCMDMFO(string JIEHBANCLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C320", Offset = "0x73B720")]
public class EMJNOMLAHCE<T1, T2> : CDOEGNNFKFF<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KBLGNFGKJHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C390", Offset = "0x73B790")]
		public LEKACFEIBBA<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public EMJNOMLAHCE<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public KBLGNFGKJHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x23331E0", Offset = "0x23317E0", VA = "0x1823331E0")]
		internal void BLEGJCHBHJP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NAJMCAPOFPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KBLGNFGKJHB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public NAJMCAPOFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6ED0", Offset = "0x24E54D0", VA = "0x1824E6ED0")]
		internal void OPNIPNLCDAC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x121DFD0", Offset = "0x121C5D0", VA = "0x18121DFD0")]
	public EMJNOMLAHCE(LEKACFEIBBA<T1> FFILMMKBDMD, LEKACFEIBBA<T2> BMHGFIPIKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x121DF60", Offset = "0x121C560", VA = "0x18121DF60")]
	private void ACLNPLMEPCL(string KAEDNDEPIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C410", Offset = "0x73B810")]
public class APAKDOGKJAG<T1, T2, T3> : CDOEGNNFKFF<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class BJMGDDGNJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C480", Offset = "0x73B880")]
		public LEKACFEIBBA<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C4E0", Offset = "0x73B8E0")]
		public LEKACFEIBBA<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public APAKDOGKJAG<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public BJMGDDGNJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2332CA0", Offset = "0x23312A0", VA = "0x182332CA0")]
		internal void BLEGJCHBHJP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NAKCBLEFLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BJMGDDGNJLO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public NAKCBLEFLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x24E6FA0", Offset = "0x24E55A0", VA = "0x1824E6FA0")]
		internal void OPNIPNLCDAC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EFKGJCGJMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NAKCBLEFLEO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public EFKGJCGJMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E9A0", Offset = "0x2A4CFA0", VA = "0x182A4E9A0")]
		internal void IFGGBDDONII(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C698E0", Offset = "0x3C67EE0", VA = "0x183C698E0")]
	public APAKDOGKJAG(LEKACFEIBBA<T1> FFILMMKBDMD, LEKACFEIBBA<T2> BMHGFIPIKHP, LEKACFEIBBA<T3> EKBNIKGEEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C69590", Offset = "0x3C67B90", VA = "0x183C69590")]
	private void ACLNPLMEPCL(string KAEDNDEPIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C540", Offset = "0x73B940")]
public class JNODPNGJNPA<T1, T2, T3, T4, T5> : CDOEGNNFKFF<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class CPFILHBJIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C5B0", Offset = "0x73B9B0")]
		public LEKACFEIBBA<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C610", Offset = "0x73BA10")]
		public LEKACFEIBBA<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C670", Offset = "0x73BA70")]
		public LEKACFEIBBA<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C6D0", Offset = "0x73BAD0")]
		public LEKACFEIBBA<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JNODPNGJNPA<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public CPFILHBJIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2332DD0", Offset = "0x23313D0", VA = "0x182332DD0")]
		internal void BLEGJCHBHJP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HELOAFFGMHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CPFILHBJIDL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public HELOAFFGMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2E536C0", Offset = "0x2E51CC0", VA = "0x182E536C0")]
		internal void OPNIPNLCDAC(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KPIBGKGLBKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HELOAFFGMHC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public KPIBGKGLBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x334E770", Offset = "0x334CD70", VA = "0x18334E770")]
		internal void IFGGBDDONII(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ECCADPIJNLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public KPIBGKGLBKC CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public ECCADPIJNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B130", Offset = "0x2A49730", VA = "0x182A4B130")]
		internal void GHEJPNHMMCG(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BDJPLHABKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ECCADPIJNLC CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public BDJPLHABKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x307D1E0", Offset = "0x307B7E0", VA = "0x18307D1E0")]
		internal void BOIBCMLFMHN(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E71DF0", Offset = "0x2E703F0", VA = "0x182E71DF0")]
	public JNODPNGJNPA(LEKACFEIBBA<T1> FFILMMKBDMD, LEKACFEIBBA<T2> BMHGFIPIKHP, LEKACFEIBBA<T3> EKBNIKGEEDL, LEKACFEIBBA<T4> NMBJDBFJLCL, LEKACFEIBBA<T5> MNGEDNLOOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E71D80", Offset = "0x2E70380", VA = "0x182E71D80")]
	private void ACLNPLMEPCL(string KAEDNDEPIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C730", Offset = "0x73BB30")]
public class OOHGEFHKMPM<T> : CDOEGNNFKFF<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JEOIDFJNEHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OOHGEFHKMPM<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public JEOIDFJNEHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A029C0", Offset = "0x2A00FC0", VA = "0x182A029C0")]
		internal void BLEGJCHBHJP(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C7A0", Offset = "0x73BBA0")]
	private readonly T[] IEPCOLGJJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int HDPBKGBFGDI;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34FA1A0", Offset = "0x34F87A0", VA = "0x1834FA1A0")]
	public OOHGEFHKMPM(List<LEKACFEIBBA<T>> EDJNKADGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x34FA130", Offset = "0x34F8730", VA = "0x1834FA130")]
	private void ACLNPLMEPCL(string KAEDNDEPIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HEAELIBOADD : MDOIJNHMNCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int ECFFKHDCLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<ADCACBFKFKM> EDJNKADGBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> BBCJJPLDDNF;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71E84A0", Offset = "0x71E6AA0", VA = "0x1871E84A0")]
	public HEAELIBOADD(params ADCACBFKFKM[] EDJNKADGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71E84B0", Offset = "0x71E6AB0", VA = "0x1871E84B0")]
	public HEAELIBOADD(IReadOnlyList<ADCACBFKFKM> EDJNKADGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71E83B0", Offset = "0x71E69B0", VA = "0x1871E83B0")]
	private void KALFBCMLOEB(string DNMNKNPAPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71E8410", Offset = "0x71E6A10", VA = "0x1871E8410")]
	private void MMFJCHBDAHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CBCGOMNLGHM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string DGBFNEBBCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2459E70", Offset = "0x2458470", VA = "0x182459E70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71E7C30", Offset = "0x71E6230", VA = "0x1871E7C30")]
	public CBCGOMNLGHM(Exception CLMDDJKOHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71E7BA0", Offset = "0x71E61A0", VA = "0x1871E7BA0")]
	private static string HOILJNANHOC(Exception CLMDDJKOHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MDOIJNHMNCN : ADCACBFKFKM, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class HPGJIOFHJDE<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C920", Offset = "0x73BD20")]
		public Func<string, LEKACFEIBBA<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C980", Offset = "0x73BD80")]
		public Func<LEKACFEIBBA<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C9E0", Offset = "0x73BDE0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CA40", Offset = "0x73BE40")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public HPGJIOFHJDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2E45C00", Offset = "0x2E44200", VA = "0x182E45C00")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void LIKMDDJIBMN(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2E44DC0", Offset = "0x2E433C0", VA = "0x182E44DC0")]
		internal void HKLHLDILLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void GBBJHAEHEPE(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DHNCAMMFEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CAA0", Offset = "0x73BEA0")]
		public Func<string, ADCACBFKFKM> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public MDOIJNHMNCN newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CB00", Offset = "0x73BF00")]
		public Func<ADCACBFKFKM> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CB60", Offset = "0x73BF60")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CBC0", Offset = "0x73BFC0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DHNCAMMFEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71E81A0", Offset = "0x71E67A0", VA = "0x1871E81A0")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void LIKMDDJIBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71E8030", Offset = "0x71E6630", VA = "0x1871E8030")]
		internal void HKLHLDILLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void GBBJHAEHEPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NJNOMEANMBH<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public NJNOMEANMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x15BD420", Offset = "0x15BBA20", VA = "0x1815BD420")]
		internal void EGKAEJDFLAA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26643D0", Offset = "0x26629D0", VA = "0x1826643D0")]
		internal void CODKMDFGLCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IKIGGMKNICE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MDOIJNHMNCN newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CC20", Offset = "0x73C020")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IKIGGMKNICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71E9340", Offset = "0x71E7940", VA = "0x1871E9340")]
		internal void BGGADADJBNC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAC8000", Offset = "0xAC6600", VA = "0x180AC8000")]
		internal void COKNOMFFLMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string CIFJDHGJLPI = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> CPJJEOAKAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> JHIAEFIMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> JGECPKLHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? KAEDNDEPIBA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ADCACBFKFKM BDJJNKEODFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71EA390", Offset = "0x71E8990", VA = "0x1871EA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9584D0", Offset = "0x956AD0", VA = "0x1809584D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x958220", Offset = "0x956820", VA = "0x180958220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool POCAEFMCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71EA3F0", Offset = "0x71E89F0", VA = "0x1871EA3F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GEEBDBJGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71EA630", Offset = "0x71E8C30", VA = "0x1871EA630", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71EB0F0", Offset = "0x71E96F0", VA = "0x1871EB0F0")]
	static MDOIJNHMNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2301C80", Offset = "0x2300280", VA = "0x182301C80")]
	public static LEKACFEIBBA<T> CMIMCOHDKEI<T>(T COGPMIAOIBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71EB080", Offset = "0x71E9680", VA = "0x1871EB080")]
	public static ADCACBFKFKM NEEFPPFOLKD(string KAEDNDEPIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2301C80", Offset = "0x2300280", VA = "0x182301C80")]
	public static LEKACFEIBBA<T> NEEFPPFOLKD<T>(string KAEDNDEPIBA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71EA650", Offset = "0x71E8C50", VA = "0x1871EA650", Slot = "8")]
	public ADCACBFKFKM JGLIBLIFPPP(Action<string> PKKHCINGAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71EAD20", Offset = "0x71E9320", VA = "0x1871EAD20", Slot = "17")]
	public virtual ADCACBFKFKM LOFECAMPIDN(Action OEHIJHLENEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71EAFF0", Offset = "0x71E95F0", VA = "0x1871EAFF0", Slot = "7")]
	public ADCACBFKFKM NAHHIAOABJF(Action CFGIBFFHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x23537B0", Offset = "0x2351DB0", VA = "0x1823537B0", Slot = "10")]
	public LEKACFEIBBA<TNew> IAPLPHMJAJF<TNew>(Func<LEKACFEIBBA<TNew>> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C860", Offset = "0x73BC60")] Func<string, LEKACFEIBBA<TNew>> IHFIBCBCLIL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71EA410", Offset = "0x71E8A10", VA = "0x1871EA410", Slot = "11")]
	public ADCACBFKFKM IAPLPHMJAJF(Func<ADCACBFKFKM> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73C8C0", Offset = "0x73BCC0")] Func<string, ADCACBFKFKM> IHFIBCBCLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2353DD0", Offset = "0x23523D0", VA = "0x182353DD0", Slot = "12")]
	public LEKACFEIBBA<TNew> LDKGJPDELDD<TNew>(Func<TNew> GIONFKKJBOC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71EAB10", Offset = "0x71E9110", VA = "0x1871EAB10", Slot = "13")]
	public ADCACBFKFKM LEOLNBJFNCL(Func<string, string> GIONFKKJBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6266950", Offset = "0x6264F50", VA = "0x186266950", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71EADA0", Offset = "0x71E93A0", VA = "0x1871EADA0")]
	public void LOJGLKLMFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71EA6F0", Offset = "0x71E8CF0", VA = "0x1871EA6F0")]
	public void JGLIBLIFPPP(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71EA9D0", Offset = "0x71E8FD0", VA = "0x1871EA9D0")]
	protected Exception? LEDBBINMLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71EA310", Offset = "0x71E8910", VA = "0x1871EA310", Slot = "18")]
	protected virtual void DAEAFKOGCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71EB160", Offset = "0x71E9760", VA = "0x1871EB160")]
	public MDOIJNHMNCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CDOEGNNFKFF<T> : LEKACFEIBBA<T>, ADCACBFKFKM, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct ADCEFNDHCEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CE60", Offset = "0x73C260")]
		public readonly Action<T> INJMGBDPOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? LHADFHEBNLM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xC82520", Offset = "0xC80B20", VA = "0x180C82520")]
		public ADCEFNDHCEA(Action<T> INJMGBDPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xC82A80", Offset = "0xC81080", VA = "0x180C82A80")]
		public ADCEFNDHCEA(Action LHADFHEBNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26D97A0", Offset = "0x26D7DA0", VA = "0x1826D97A0")]
		public void HDLCFALLNOK(T OGLJJNFALNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HFMHNIGMNHL<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CEC0", Offset = "0x73C2C0")]
		public Func<string, LEKACFEIBBA<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CF20", Offset = "0x73C320")]
		public Func<LEKACFEIBBA<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CF80", Offset = "0x73C380")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CFE0", Offset = "0x73C3E0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public HFMHNIGMNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2E62AD0", Offset = "0x2E610D0", VA = "0x182E62AD0")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void LIKMDDJIBMN(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2E5D7C0", Offset = "0x2E5BDC0", VA = "0x182E5D7C0")]
		internal void HKLHLDILLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void GBBJHAEHEPE(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GLKLKMINFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D040", Offset = "0x73C440")]
		public Func<string, ADCACBFKFKM> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MDOIJNHMNCN newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D0A0", Offset = "0x73C4A0")]
		public Func<ADCACBFKFKM> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D100", Offset = "0x73C500")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D160", Offset = "0x73C560")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GLKLKMINFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD200", Offset = "0x2DCB800", VA = "0x182DCD200")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void LIKMDDJIBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2DCCA20", Offset = "0x2DCB020", VA = "0x182DCCA20")]
		internal void HKLHLDILLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void GBBJHAEHEPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FEBHKJOMBGC<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D1C0", Offset = "0x73C5C0")]
		public Func<string, LEKACFEIBBA<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D220", Offset = "0x73C620")]
		public Func<T, LEKACFEIBBA<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D280", Offset = "0x73C680")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D2E0", Offset = "0x73C6E0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public FEBHKJOMBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x21ED390", Offset = "0x21EB990", VA = "0x1821ED390")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void LIKMDDJIBMN(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x21E9120", Offset = "0x21E7720", VA = "0x1821E9120")]
		internal void HKLHLDILLNI(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x21E8730", Offset = "0x21E6D30", VA = "0x1821E8730")]
		internal void GBBJHAEHEPE(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CMKEHMEEFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D340", Offset = "0x73C740")]
		public Func<string, ADCACBFKFKM> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MDOIJNHMNCN newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D3A0", Offset = "0x73C7A0")]
		public Func<T, ADCACBFKFKM> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D400", Offset = "0x73C800")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D460", Offset = "0x73C860")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public CMKEHMEEFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2BBDF70", Offset = "0x2BBC570", VA = "0x182BBDF70")]
		internal void JELCBPEDLHH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void MLNHGKIGAED(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void LIKMDDJIBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBDAF0", Offset = "0x2BBC0F0", VA = "0x182BBDAF0")]
		internal void HKLHLDILLNI(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13AEF40", Offset = "0x13AD540", VA = "0x1813AEF40")]
		internal void NOMABBAPHDA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x10F5C00", Offset = "0x10F4200", VA = "0x1810F5C00")]
		internal void GBBJHAEHEPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ONKJONEGLAE<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public ONKJONEGLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x15BD420", Offset = "0x15BBA20", VA = "0x1815BD420")]
		internal void EGKAEJDFLAA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x26643D0", Offset = "0x26629D0", VA = "0x1826643D0")]
		internal void CODKMDFGLCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IOIEODAEGKD<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CDOEGNNFKFF<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D4C0", Offset = "0x73C8C0")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public IOIEODAEGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x15BD420", Offset = "0x15BBA20", VA = "0x1815BD420")]
		internal void EGKAEJDFLAA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FFF6A0", Offset = "0x1FFDCA0", VA = "0x181FFF6A0")]
		internal void CODKMDFGLCB(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ILGNBIEEMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MDOIJNHMNCN newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D520", Offset = "0x73C920")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public ILGNBIEEMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5B90", Offset = "0x1FF4190", VA = "0x181FF5B90")]
		internal void JHOEKGIIKGA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAC8000", Offset = "0xAC6600", VA = "0x180AC8000")]
		internal void IJNEIENOBJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PJIPOCBNKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D580", Offset = "0x73C980")]
		public CDOEGNNFKFF<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D5E0", Offset = "0x73C9E0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public PJIPOCBNKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2C5AFA0", Offset = "0x2C595A0", VA = "0x182C5AFA0")]
		internal void BGGADADJBNC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2C5BFB0", Offset = "0x2C5A5B0", VA = "0x182C5BFB0")]
		internal void COKNOMFFLMB(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CC80", Offset = "0x73C080")]
	private readonly List<CDOEGNNFKFF<T>.ADCEFNDHCEA> JGECPKLHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> CPJJEOAKAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> JHIAEFIMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? KAEDNDEPIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T COGPMIAOIBF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAC35A0", Offset = "0xAC1BA0", VA = "0x180AC35A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xD343E0", Offset = "0xD329E0", VA = "0x180D343E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool POCAEFMCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x32F4450", Offset = "0x32F2A50", VA = "0x1832F4450", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GEEBDBJGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x32F5A20", Offset = "0x32F4020", VA = "0x1832F5A20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9149B0", Offset = "0x912FB0", VA = "0x1809149B0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x32F8D40", Offset = "0x32F7340", VA = "0x1832F8D40")]
	public static LEKACFEIBBA<T> NEEFPPFOLKD(string JIEHBANCLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x32F5F90", Offset = "0x32F4590", VA = "0x1832F5F90", Slot = "6")]
	public LEKACFEIBBA<T> JGLIBLIFPPP(Action<string> PKKHCINGAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x32F7B60", Offset = "0x32F6160", VA = "0x1832F7B60", Slot = "25")]
	public virtual LEKACFEIBBA<T> LOFECAMPIDN(Action OEHIJHLENEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x32F8B90", Offset = "0x32F7190", VA = "0x1832F8B90", Slot = "5")]
	public LEKACFEIBBA<T> NAHHIAOABJF(Action CFGIBFFHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x32F8AB0", Offset = "0x32F70B0", VA = "0x1832F8AB0", Slot = "4")]
	public LEKACFEIBBA<T> NAHHIAOABJF(Action<T> CFGIBFFHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D37760", Offset = "0x2D35D60", VA = "0x182D37760", Slot = "18")]
	public LEKACFEIBBA<TNew> IAPLPHMJAJF<TNew>(Func<LEKACFEIBBA<TNew>> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CCE0", Offset = "0x73C0E0")] Func<string, LEKACFEIBBA<TNew>> IHFIBCBCLIL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x32F52E0", Offset = "0x32F38E0", VA = "0x1832F52E0", Slot = "19")]
	public ADCACBFKFKM IAPLPHMJAJF(Func<ADCACBFKFKM> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CD40", Offset = "0x73C140")] Func<string, ADCACBFKFKM> IHFIBCBCLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C2C0", Offset = "0x2A1A8C0", VA = "0x182A1C2C0", Slot = "8")]
	public LEKACFEIBBA<TNew> IAPLPHMJAJF<TNew>(Func<T, LEKACFEIBBA<TNew>> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CDA0", Offset = "0x73C1A0")] Func<string, LEKACFEIBBA<TNew>> IHFIBCBCLIL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x32F4D80", Offset = "0x32F3380", VA = "0x1832F4D80", Slot = "9")]
	public ADCACBFKFKM IAPLPHMJAJF(Func<T, ADCACBFKFKM> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73CE00", Offset = "0x73C200")] Func<string, ADCACBFKFKM> IHFIBCBCLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D3C0D0", Offset = "0x2D3A6D0", VA = "0x182D3C0D0", Slot = "20")]
	public LEKACFEIBBA<TNew> LDKGJPDELDD<TNew>(Func<TNew> GIONFKKJBOC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A288F0", Offset = "0x2A26EF0", VA = "0x182A288F0", Slot = "10")]
	public LEKACFEIBBA<TNew> LDKGJPDELDD<TNew>(Func<T, TNew> GIONFKKJBOC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x32F4660", Offset = "0x32F2C60", VA = "0x1832F4660", Slot = "21")]
	private ADCACBFKFKM HLAOOFIBNFO(Func<string, string> GIONFKKJBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x32F78C0", Offset = "0x32F5EC0", VA = "0x1832F78C0", Slot = "11")]
	public LEKACFEIBBA<T> LEOLNBJFNCL(Func<string, string> GIONFKKJBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32F8E60", Offset = "0x32F7460", VA = "0x1832F8E60", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x32F4420", Offset = "0x32F2A20", VA = "0x1832F4420", Slot = "15")]
	private ADCACBFKFKM DNGBEBCBJCN(Action CFGIBFFHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26D8190", Offset = "0x26D6790", VA = "0x1826D8190", Slot = "16")]
	private ADCACBFKFKM BKMGBDEJMBI(Action<string> PKKHCINGAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x32F4170", Offset = "0x32F2770", VA = "0x1832F4170", Slot = "17")]
	private ADCACBFKFKM CIKECDOKHGL(Action OEHIJHLENEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x32F8750", Offset = "0x32F6D50", VA = "0x1832F8750")]
	public void LOJGLKLMFMO(T OGLJJNFALNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x32F6DB0", Offset = "0x32F53B0", VA = "0x1832F6DB0")]
	protected Exception? LEDBBINMLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x32F6050", Offset = "0x32F4650", VA = "0x1832F6050")]
	public void JGLIBLIFPPP(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x32F42E0", Offset = "0x32F28E0", VA = "0x1832F42E0", Slot = "26")]
	protected virtual void DAEAFKOGCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x32F8FE0", Offset = "0x32F75E0", VA = "0x1832F8FE0")]
	public CDOEGNNFKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ADCACBFKFKM : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool POCAEFMCOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GEEBDBJGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADCACBFKFKM NAHHIAOABJF(Action CFGIBFFHJMB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADCACBFKFKM JGLIBLIFPPP(Action<string> PKKHCINGAMB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADCACBFKFKM LOFECAMPIDN(Action OEHIJHLENEO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEKACFEIBBA<TNew> IAPLPHMJAJF<TNew>(Func<LEKACFEIBBA<TNew>> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D640", Offset = "0x73CA40")] Func<string, LEKACFEIBBA<TNew>> IHFIBCBCLIL) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ADCACBFKFKM IAPLPHMJAJF(Func<ADCACBFKFKM> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D6A0", Offset = "0x73CAA0")] Func<string, ADCACBFKFKM> IHFIBCBCLIL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LEKACFEIBBA<TNew> LDKGJPDELDD<TNew>(Func<TNew> GIONFKKJBOC) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADCACBFKFKM LEOLNBJFNCL(Func<string, string> GIONFKKJBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LEKACFEIBBA<out T> : ADCACBFKFKM, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LEKACFEIBBA<T> NAHHIAOABJF(Action<T> CFGIBFFHJMB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new LEKACFEIBBA<T> NAHHIAOABJF(Action CFGIBFFHJMB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new LEKACFEIBBA<T> JGLIBLIFPPP(Action<string> PKKHCINGAMB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new LEKACFEIBBA<T> LOFECAMPIDN(Action OEHIJHLENEO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LEKACFEIBBA<TNew> IAPLPHMJAJF<TNew>(Func<T, LEKACFEIBBA<TNew>> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D700", Offset = "0x73CB00")] Func<string, LEKACFEIBBA<TNew>> IHFIBCBCLIL) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADCACBFKFKM IAPLPHMJAJF(Func<T, ADCACBFKFKM> GIONFKKJBOC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D760", Offset = "0x73CB60")] Func<string, ADCACBFKFKM> IHFIBCBCLIL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEKACFEIBBA<TNew> LDKGJPDELDD<TNew>(Func<T, TNew> GIONFKKJBOC) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new LEKACFEIBBA<T> LEOLNBJFNCL(Func<string, string> GIONFKKJBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HKNMNBLBAPO
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum AEIMEFIJKIA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class OGAIGPOKMDJ : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x71EB2F0", Offset = "0x71E98F0", VA = "0x1871EB2F0")]
		public OGAIGPOKMDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HNPNKJPKNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public HNPNKJPKNAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71E9210", Offset = "0x71E7810", VA = "0x1871E9210")]
		internal void EGOHPHEDBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x71E9260", Offset = "0x71E7860", VA = "0x1871E9260")]
		internal void OJEHOEDLKMM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x71E92F0", Offset = "0x71E78F0", VA = "0x1871E92F0")]
		internal void OMPNBNKIPBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CNCHKMBHOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LABEIOOIHEC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AEIMEFIJKIA unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CNCHKMBHOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x71E7D20", Offset = "0x71E6320", VA = "0x1871E7D20")]
		internal void EGOHPHEDBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x71E7F00", Offset = "0x71E6500", VA = "0x1871E7F00")]
		internal void OJEHOEDLKMM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x71E7F90", Offset = "0x71E6590", VA = "0x1871E7F90")]
		internal void OMPNBNKIPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71E7D70", Offset = "0x71E6370", VA = "0x1871E7D70")]
		internal void FBCCHLFHPFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MNDPBMMFAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public MNDPBMMFAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x261F130", Offset = "0x261D730", VA = "0x18261F130")]
		internal void OBPDLMLFJAJ(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PNMGEHJHMFI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public PNMGEHJHMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x15BD450", Offset = "0x15BBA50", VA = "0x1815BD450")]
		internal void EGOHPHEDBGP(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1EEEE40", Offset = "0x1EED440", VA = "0x181EEEE40")]
		internal void OJEHOEDLKMM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x15BCDC0", Offset = "0x15BB3C0", VA = "0x1815BCDC0")]
		internal void OMPNBNKIPBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JFNOPBBMFBH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public LABEIOOIHEC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AEIMEFIJKIA unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public JFNOPBBMFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A09480", Offset = "0x2A07A80", VA = "0x182A09480")]
		internal void EGOHPHEDBGP(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A09740", Offset = "0x2A07D40", VA = "0x182A09740")]
		internal void OJEHOEDLKMM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A09920", Offset = "0x2A07F20", VA = "0x182A09920")]
		internal void OMPNBNKIPBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A09610", Offset = "0x2A07C10", VA = "0x182A09610")]
		internal void FBCCHLFHPFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FPCNACPCAPJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public FPCNACPCAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x261F130", Offset = "0x261D730", VA = "0x18261F130")]
		internal void OBPDLMLFJAJ(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PEKOCOEHEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MDOIJNHMNCN promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PEKOCOEHEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x71EB360", Offset = "0x71E9960", VA = "0x1871EB360")]
		internal void NIADOPILNKC(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class AHGCAJJHOAH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CDOEGNNFKFF<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public AHGCAJJHOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28F2570", Offset = "0x28F0B70", VA = "0x1828F2570")]
		internal void NIADOPILNKC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D800", Offset = "0x73CC00")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x71E8C80", Offset = "0x71E7280", VA = "0x1871E8C80")]
	public static Task NFMDOFHEODK(this ADCACBFKFKM GBMBJBEJAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71E8E90", Offset = "0x71E7490", VA = "0x1871E8E90")]
	public static Task<bool> NFMDOFHEODK(this ADCACBFKFKM GBMBJBEJAAE, CancellationToken OOAGLCBNIOG, AEIMEFIJKIA PFLHPEIHMOP = AEIMEFIJKIA.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8F00", Offset = "0x2AD7500", VA = "0x182AD8F00")]
	public static Task<TResult> NFMDOFHEODK<TResult>(this LEKACFEIBBA<TResult> GBMBJBEJAAE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AD8B10", Offset = "0x2AD7110", VA = "0x182AD8B10")]
	public static Task<TResult> NFMDOFHEODK<TResult>(this LEKACFEIBBA<TResult> GBMBJBEJAAE, CancellationToken OOAGLCBNIOG, AEIMEFIJKIA PFLHPEIHMOP = AEIMEFIJKIA.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x71E88B0", Offset = "0x71E6EB0", VA = "0x1871E88B0")]
	public static TaskAwaiter AHOLKDCPEHF(this ADCACBFKFKM GBMBJBEJAAE)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6CA0", Offset = "0x2AD52A0", VA = "0x182AD6CA0")]
	public static TaskAwaiter<TResult> AHOLKDCPEHF<TResult>(this LEKACFEIBBA<TResult> GBMBJBEJAAE) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x71E8AB0", Offset = "0x71E70B0", VA = "0x1871E8AB0")]
	public static ADCACBFKFKM ILFBENFJBNE(this Task DNEHMOFNGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7960", Offset = "0x2AD5F60", VA = "0x182AD7960")]
	public static LEKACFEIBBA<TResult> ILFBENFJBNE<TResult>(this Task<TResult> DNEHMOFNGIO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x71E88E0", Offset = "0x71E6EE0", VA = "0x1871E88E0")]
	private static string ELOCGKNHCKG(Task DNEHMOFNGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LABEIOOIHEC : ADCACBFKFKM, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FHMJGIEMHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool ANGKHBPNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HEJEPKMNJEJ();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LABEIOOIHEC AAFBAIFMGNC(Action BMMIHNOHPEC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MHHMKEBAHKB<T> : LEKACFEIBBA<T>, ADCACBFKFKM, IEnumerator, LABEIOOIHEC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new MHHMKEBAHKB<T> AAFBAIFMGNC(Action BMMIHNOHPEC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LAKANFGDDAI : MDOIJNHMNCN, LABEIOOIHEC, ADCACBFKFKM, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> BMMIHNOHPEC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static LABEIOOIHEC BFGHLCEPKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x71EA040", Offset = "0x71E8640", VA = "0x1871EA040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FHMJGIEMHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAC35A0", Offset = "0xAC1BA0", VA = "0x180AC35A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xD343E0", Offset = "0xD329E0", VA = "0x180D343E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ANGKHBPNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x71EA030", Offset = "0x71E8630", VA = "0x1871EA030", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x71EA130", Offset = "0x71E8730", VA = "0x1871EA130")]
	static LAKANFGDDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2301C80", Offset = "0x2300280", VA = "0x182301C80")]
	public new static MHHMKEBAHKB<T> CMIMCOHDKEI<T>(T COGPMIAOIBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2301C80", Offset = "0x2300280", VA = "0x182301C80")]
	public new static MHHMKEBAHKB<T> NEEFPPFOLKD<T>(string KAEDNDEPIBA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x71E9DE0", Offset = "0x71E83E0", VA = "0x1871E9DE0", Slot = "21")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x71E9D10", Offset = "0x71E8310", VA = "0x1871E9D10", Slot = "22")]
	public LABEIOOIHEC AAFBAIFMGNC(Action LFLPHKNBNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71E9D90", Offset = "0x71E8390", VA = "0x1871E9D90", Slot = "18")]
	protected override void DAEAFKOGCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71EA0A0", Offset = "0x71E86A0", VA = "0x1871EA0A0", Slot = "17")]
	public override ADCACBFKFKM LOFECAMPIDN(Action OEHIJHLENEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x71EA260", Offset = "0x71E8860", VA = "0x1871EA260")]
	public LAKANFGDDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x73D860", Offset = "0x73CC60")]
public class MKLGMPONLGL<T> : CDOEGNNFKFF<T>, MHHMKEBAHKB<T>, LEKACFEIBBA<T>, ADCACBFKFKM, IEnumerator, LABEIOOIHEC where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> BMMIHNOHPEC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FHMJGIEMHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA53ED0", Offset = "0xA524D0", VA = "0x180A53ED0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA53EE0", Offset = "0xA524E0", VA = "0x180A53EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool ANGKHBPNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x34874F0", Offset = "0x3485AF0", VA = "0x1834874F0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3486ED0", Offset = "0x34854D0", VA = "0x183486ED0", Slot = "30")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3486D40", Offset = "0x3485340", VA = "0x183486D40", Slot = "27")]
	public MHHMKEBAHKB<T> AAFBAIFMGNC(Action LFLPHKNBNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0B20", Offset = "0x2CEF120", VA = "0x182CF0B20", Slot = "31")]
	private LABEIOOIHEC JLAAMLMALJA(Action LFLPHKNBNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3486E60", Offset = "0x3485460", VA = "0x183486E60", Slot = "26")]
	protected override void DAEAFKOGCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3487560", Offset = "0x3485B60", VA = "0x183487560", Slot = "25")]
	public override LEKACFEIBBA<T> LOFECAMPIDN(Action OEHIJHLENEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34875F0", Offset = "0x3485BF0", VA = "0x1834875F0")]
	public MKLGMPONLGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IPGFPFPGINK : HEAELIBOADD, LABEIOOIHEC, ADCACBFKFKM, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> BMMIHNOHPEC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FHMJGIEMHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x949A90", Offset = "0x948090", VA = "0x180949A90", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xF7D5A0", Offset = "0xF7BBA0", VA = "0x180F7D5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ANGKHBPNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x71E9890", Offset = "0x71E7E90", VA = "0x1871E9890", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x71E9930", Offset = "0x71E7F30", VA = "0x1871E9930")]
	public IPGFPFPGINK(LABEIOOIHEC GBMBJBEJAAE, LABEIOOIHEC OBFNNEBDACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x71E9A50", Offset = "0x71E8050", VA = "0x1871E9A50")]
	public IPGFPFPGINK(IList<LABEIOOIHEC> EDJNKADGBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x71E9490", Offset = "0x71E7A90", VA = "0x1871E9490", Slot = "21")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x71E93C0", Offset = "0x71E79C0", VA = "0x1871E93C0", Slot = "22")]
	public LABEIOOIHEC AAFBAIFMGNC(Action LFLPHKNBNBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x71E9440", Offset = "0x71E7A40", VA = "0x1871E9440", Slot = "18")]
	protected override void DAEAFKOGCAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x71E98A0", Offset = "0x71E7EA0", VA = "0x1871E98A0", Slot = "17")]
	public override ADCACBFKFKM LOFECAMPIDN(Action OEHIJHLENEO)
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
