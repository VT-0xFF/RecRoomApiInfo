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
		[Cpp2IlInjected.Address(RVA = "0x8CB040", Offset = "0x8CA440", VA = "0x1808CB040")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71A4570", Offset = "0x71A3970", VA = "0x1871A4570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF70", Offset = "0xA6E370", VA = "0x180A6EF70")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFA0", Offset = "0xA6E3A0", VA = "0x180A6EFA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OIHLIOOIEKJ : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string KCEFPHCGMKN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71A4600", Offset = "0x71A3A00", VA = "0x1871A4600")]
	public OIHLIOOIEKJ(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DC70", Offset = "0x71D070")]
public class MKMMGEAMFIN<T1, T2> : KLOLCAIIKNK<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PEHPGFCIOFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DCE0", Offset = "0x71D0E0")]
		public KDCMFGDLEKL<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public MKMMGEAMFIN<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public PEHPGFCIOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2C331B0", Offset = "0x2C325B0", VA = "0x182C331B0")]
		internal void GOINEOOFNLD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JKBCIMNKJKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PEHPGFCIOFA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public JKBCIMNKJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2FD4AD0", Offset = "0x2FD3ED0", VA = "0x182FD4AD0")]
		internal void OBEEBMHBCEE(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C0AD40", Offset = "0x2C0A140", VA = "0x182C0AD40")]
	public MKMMGEAMFIN(KDCMFGDLEKL<T1> IJFNACACKHL, KDCMFGDLEKL<T2> GBCBKKFPDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C0ACD0", Offset = "0x2C0A0D0", VA = "0x182C0ACD0")]
	private void POAEHDPGIFN(string FOMNCGOADBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DD60", Offset = "0x71D160")]
public class DNNLINJKAOK<T1, T2, T3> : KLOLCAIIKNK<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IMJHJEDDHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DDD0", Offset = "0x71D1D0")]
		public KDCMFGDLEKL<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DE30", Offset = "0x71D230")]
		public KDCMFGDLEKL<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DNNLINJKAOK<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public IMJHJEDDHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x29F5440", Offset = "0x29F4840", VA = "0x1829F5440")]
		internal void GOINEOOFNLD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HDBBNOEECDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public IMJHJEDDHFG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HDBBNOEECDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2076C20", Offset = "0x2076020", VA = "0x182076C20")]
		internal void OBEEBMHBCEE(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FBBDMNHHNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HDBBNOEECDH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public FBBDMNHHNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1317130", Offset = "0x1316530", VA = "0x181317130")]
		internal void NPOEGFKJKPN(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E742A0", Offset = "0x2E736A0", VA = "0x182E742A0")]
	public DNNLINJKAOK(KDCMFGDLEKL<T1> IJFNACACKHL, KDCMFGDLEKL<T2> GBCBKKFPDAJ, KDCMFGDLEKL<T3> FFONCGPMKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E73F50", Offset = "0x2E73350", VA = "0x182E73F50")]
	private void POAEHDPGIFN(string FOMNCGOADBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DE90", Offset = "0x71D290")]
public class AEJCFAFHEEA<T1, T2, T3, T4, T5> : KLOLCAIIKNK<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LDNAKIJEBEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DF00", Offset = "0x71D300")]
		public KDCMFGDLEKL<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DF60", Offset = "0x71D360")]
		public KDCMFGDLEKL<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71DFC0", Offset = "0x71D3C0")]
		public KDCMFGDLEKL<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E020", Offset = "0x71D420")]
		public KDCMFGDLEKL<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AEJCFAFHEEA<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public LDNAKIJEBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x233CF60", Offset = "0x233C360", VA = "0x18233CF60")]
		internal void GOINEOOFNLD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AHMLMHGFDPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LDNAKIJEBEE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public AHMLMHGFDPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A28E10", Offset = "0x2A28210", VA = "0x182A28E10")]
		internal void OBEEBMHBCEE(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FLHNPHAPMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AHMLMHGFDPG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public FLHNPHAPMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x380CD70", Offset = "0x380C170", VA = "0x18380CD70")]
		internal void NPOEGFKJKPN(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NLOGJIEPBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FLHNPHAPMGK CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public NLOGJIEPBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2798040", Offset = "0x2797440", VA = "0x182798040")]
		internal void NEEMCMCLDBJ(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MNKGCGADOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NLOGJIEPBFA CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public MNKGCGADOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2C10100", Offset = "0x2C0F500", VA = "0x182C10100")]
		internal void DIFAJKJOIIB(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C860", Offset = "0x2A1BC60", VA = "0x182A1C860")]
	public AEJCFAFHEEA(KDCMFGDLEKL<T1> IJFNACACKHL, KDCMFGDLEKL<T2> GBCBKKFPDAJ, KDCMFGDLEKL<T3> FFONCGPMKED, KDCMFGDLEKL<T4> MNOKKCDPKMI, KDCMFGDLEKL<T5> IDEAOCNACNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C7F0", Offset = "0x2A1BBF0", VA = "0x182A1C7F0")]
	private void POAEHDPGIFN(string FOMNCGOADBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E080", Offset = "0x71D480")]
public class NONIFICJPKH<T> : KLOLCAIIKNK<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HDEEJACIDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NONIFICJPKH<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HDEEJACIDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2077940", Offset = "0x2076D40", VA = "0x182077940")]
		internal void GOINEOOFNLD(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E0F0", Offset = "0x71D4F0")]
	private readonly T[] GLCGCLAAACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int GNPAGDKHJGI;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A360", Offset = "0x2D89760", VA = "0x182D8A360")]
	public NONIFICJPKH(List<KDCMFGDLEKL<T>> PCCBDHBIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2D89F00", Offset = "0x2D89300", VA = "0x182D89F00")]
	private void POAEHDPGIFN(string FOMNCGOADBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IICJIMCDBJL : LGAKEDCJAKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int FKBNAEOPNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<LMHNGLGIJDH> PCCBDHBIDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> PICNHCEBEFC;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71A3020", Offset = "0x71A2420", VA = "0x1871A3020")]
	public IICJIMCDBJL(params LMHNGLGIJDH[] PCCBDHBIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71A2BF0", Offset = "0x71A1FF0", VA = "0x1871A2BF0")]
	public IICJIMCDBJL(IReadOnlyList<LMHNGLGIJDH> PCCBDHBIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71A2B90", Offset = "0x71A1F90", VA = "0x1871A2B90")]
	private void LNCENECHKJI(string DODKGDPICLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71A2B00", Offset = "0x71A1F00", VA = "0x1871A2B00")]
	private void BFMPIELDLJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MPBLAMANNOL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string ENNBAAPLFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x303D9A0", Offset = "0x303CDA0", VA = "0x18303D9A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71A43C0", Offset = "0x71A37C0", VA = "0x1871A43C0")]
	public MPBLAMANNOL(Exception FMNNOJDKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71A4330", Offset = "0x71A3730", VA = "0x1871A4330")]
	private static string HGCLILJLKCL(Exception FMNNOJDKJHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class HDOPKEJLAKI
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	protected struct GKDKEHLGAPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Action? MHFGFIJFPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Action? IJCMNBIJNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E190", Offset = "0x71D590")]
		private List<Action?>? FFEGLJIDMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool EAGDIOELOIE;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71A2690", Offset = "0x71A1A90", VA = "0x1871A2690")]
		public void PDPMCCCKLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71A2520", Offset = "0x71A1920", VA = "0x1871A2520")]
		public void NNFBEGDMHOD(Action CFHFBNLLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71A22E0", Offset = "0x71A16E0", VA = "0x1871A22E0")]
		public Exception? LABHLMFNFCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct DHHGEAPJGCF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private readonly struct CAFFECPJGOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public readonly object MMFKNPJFNMK;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
			public CAFFECPJGOE(Action<T> NDPBOAHDPLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8BE820", Offset = "0x8BDC20", VA = "0x1808BE820")]
			public CAFFECPJGOE(Action NDPBOAHDPLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3490730", Offset = "0x348FB30", VA = "0x183490730")]
			public void LABHLMFNFCH(T HOJNLEBJGLH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CAFFECPJGOE? MHFGFIJFPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private CAFFECPJGOE? IJCMNBIJNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E1F0", Offset = "0x71D5F0")]
		private List<CAFFECPJGOE> FFEGLJIDMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private bool EAGDIOELOIE;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x21DE9A0", Offset = "0x21DDDA0", VA = "0x1821DE9A0")]
		public void PDPMCCCKLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32D9DF0", Offset = "0x32D91F0", VA = "0x1832D9DF0")]
		public void NNFBEGDMHOD(Action CFHFBNLLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32D91B0", Offset = "0x32D85B0", VA = "0x1832D91B0")]
		public void NNFBEGDMHOD(Action<T> CFHFBNLLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x32DA280", Offset = "0x32D9680", VA = "0x1832DA280")]
		private void NNFBEGDMHOD(CAFFECPJGOE CFHFBNLLHPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x32D1530", Offset = "0x32D0930", VA = "0x1832D1530")]
		public Exception LABHLMFNFCH(T AGLCIEKHLEE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected HDOPKEJLAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LGAKEDCJAKH : HDOPKEJLAKI, LMHNGLGIJDH, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PKCJOFLAEII<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E410", Offset = "0x71D810")]
		public Func<string, KDCMFGDLEKL<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E470", Offset = "0x71D870")]
		public Func<KDCMFGDLEKL<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E4D0", Offset = "0x71D8D0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E530", Offset = "0x71D930")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public PKCJOFLAEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3D064A0", Offset = "0x3D058A0", VA = "0x183D064A0")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void KNNDPJGALIF(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3D07130", Offset = "0x3D06530", VA = "0x183D07130")]
		internal void IPIKGKMMAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void MDDEOHNBKIJ(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GMIAPBNBHLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E590", Offset = "0x71D990")]
		public Func<string, LMHNGLGIJDH> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LGAKEDCJAKH newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E5F0", Offset = "0x71D9F0")]
		public Func<LMHNGLGIJDH> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E650", Offset = "0x71DA50")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E6B0", Offset = "0x71DAB0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GMIAPBNBHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71A26D0", Offset = "0x71A1AD0", VA = "0x1871A26D0")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void KNNDPJGALIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71A2860", Offset = "0x71A1C60", VA = "0x1871A2860")]
		internal void IPIKGKMMAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void MDDEOHNBKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GDAODPFJIJB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public GDAODPFJIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1764610", Offset = "0x1763A10", VA = "0x181764610")]
		internal void PLJFOLNAFLA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x22FC9D0", Offset = "0x22FBDD0", VA = "0x1822FC9D0")]
		internal void ODFLKOKOHJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FLIDAAOANOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public LGAKEDCJAKH newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E710", Offset = "0x71DB10")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FLIDAAOANOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71A18E0", Offset = "0x71A0CE0", VA = "0x1871A18E0")]
		internal void OFHILLMOIJA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD4B1F0", Offset = "0xD4A5F0", VA = "0x180D4B1F0")]
		internal void OBCMIKIHEMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string LFBLBABILFC = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E2D0", Offset = "0x71D6D0")]
	private DHHGEAPJGCF<string> MLAEDCLDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GKDKEHLGAPJ HPDAGJOECGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private GKDKEHLGAPJ BCIGHIDHCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private string? FOMNCGOADBK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LMHNGLGIJDH KMDKMINEGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71A30A0", Offset = "0x71A24A0", VA = "0x1871A30A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CEFOKEMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA070", Offset = "0x8C9470", VA = "0x1808CA070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8460", Offset = "0x8F7860", VA = "0x1808F8460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HALNDCBNDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71A3390", Offset = "0x71A2790", VA = "0x1871A3390", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DOFOBMNLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71A3080", Offset = "0x71A2480", VA = "0x1871A3080", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x71A3AA0", Offset = "0x71A2EA0", VA = "0x1871A3AA0")]
	static LGAKEDCJAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202B630", VA = "0x18202C230")]
	public static KDCMFGDLEKL<T> EEDJOIGGPIP<T>(T MOOEDNDCGLB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71A3300", Offset = "0x71A2700", VA = "0x1871A3300")]
	public static LMHNGLGIJDH FIMDJEGGDOP(string FOMNCGOADBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202B630", VA = "0x18202C230")]
	public static KDCMFGDLEKL<T> FIMDJEGGDOP<T>(string FOMNCGOADBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71A39F0", Offset = "0x71A2DF0", VA = "0x1871A39F0", Slot = "8")]
	public LMHNGLGIJDH MFNMALCIGGF(Action<string> IMFKEALILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71A3030", Offset = "0x71A2430", VA = "0x1871A3030", Slot = "17")]
	public virtual LMHNGLGIJDH BEBIPNIPKGK(Action LCAHJOJJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71A37D0", Offset = "0x71A2BD0", VA = "0x1871A37D0", Slot = "7")]
	public LMHNGLGIJDH MCIIKHKIMKD(Action CCKGALNABMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2386C60", Offset = "0x2386060", VA = "0x182386C60", Slot = "10")]
	public KDCMFGDLEKL<TNew> IHOIHNIPDKO<TNew>(Func<KDCMFGDLEKL<TNew>> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E350", Offset = "0x71D750")] Func<string, KDCMFGDLEKL<TNew>> MHEFOFAGGAE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x71A3470", Offset = "0x71A2870", VA = "0x1871A3470", Slot = "11")]
	public LMHNGLGIJDH IHOIHNIPDKO(Func<LMHNGLGIJDH> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E3B0", Offset = "0x71D7B0")] Func<string, LMHNGLGIJDH> MHEFOFAGGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x23858B0", Offset = "0x2384CB0", VA = "0x1823858B0", Slot = "12")]
	public KDCMFGDLEKL<TNew> BHDFDFBFOHO<TNew>(Func<TNew> GMKGDNJCGKE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x71A3100", Offset = "0x71A2500", VA = "0x1871A3100", Slot = "13")]
	public LMHNGLGIJDH FHCEPPFBHOO(Func<string, string> GMKGDNJCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x71A3A90", Offset = "0x71A2E90", VA = "0x1871A3A90", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x71A3690", Offset = "0x71A2A90", VA = "0x1871A3690")]
	public void LKEHBOFLELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x71A3830", Offset = "0x71A2C30", VA = "0x1871A3830")]
	public void MFNMALCIGGF(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x71A3460", Offset = "0x71A2860", VA = "0x1871A3460")]
	protected Exception? IFCKIHIKJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x71A33B0", Offset = "0x71A27B0", VA = "0x1871A33B0", Slot = "18")]
	protected virtual void HAGOEHICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B30", Offset = "0x71A2F30", VA = "0x1871A3B30")]
	public LGAKEDCJAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KLOLCAIIKNK<T> : HDOPKEJLAKI, KDCMFGDLEKL<T>, LMHNGLGIJDH, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JJFDIILJMLA<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E9B0", Offset = "0x71DDB0")]
		public Func<string, KDCMFGDLEKL<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EA10", Offset = "0x71DE10")]
		public Func<KDCMFGDLEKL<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EA70", Offset = "0x71DE70")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EAD0", Offset = "0x71DED0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public JJFDIILJMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3106F30", Offset = "0x3106330", VA = "0x183106F30")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void KNNDPJGALIF(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3107EC0", Offset = "0x31072C0", VA = "0x183107EC0")]
		internal void IPIKGKMMAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void MDDEOHNBKIJ(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OLAGKPJGNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EB30", Offset = "0x71DF30")]
		public Func<string, LMHNGLGIJDH> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LGAKEDCJAKH newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EB90", Offset = "0x71DF90")]
		public Func<LMHNGLGIJDH> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EBF0", Offset = "0x71DFF0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EC50", Offset = "0x71E050")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public OLAGKPJGNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2F866A0", Offset = "0x2F85AA0", VA = "0x182F866A0")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void KNNDPJGALIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2F8CCC0", Offset = "0x2F8C0C0", VA = "0x182F8CCC0")]
		internal void IPIKGKMMAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void MDDEOHNBKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KBNLDBOGDKP<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71ECB0", Offset = "0x71E0B0")]
		public Func<string, KDCMFGDLEKL<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71ED10", Offset = "0x71E110")]
		public Func<T, KDCMFGDLEKL<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71ED70", Offset = "0x71E170")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EDD0", Offset = "0x71E1D0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public KBNLDBOGDKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1CAC780", Offset = "0x1CABB80", VA = "0x181CAC780")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void KNNDPJGALIF(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CAED00", Offset = "0x1CAE100", VA = "0x181CAED00")]
		internal void IPIKGKMMAFC(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1CB0190", Offset = "0x1CAF590", VA = "0x181CB0190")]
		internal void MDDEOHNBKIJ(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JEKCEGLJIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EE30", Offset = "0x71E230")]
		public Func<string, LMHNGLGIJDH> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public LGAKEDCJAKH newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EE90", Offset = "0x71E290")]
		public Func<T, LMHNGLGIJDH> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EEF0", Offset = "0x71E2F0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EF50", Offset = "0x71E350")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public JEKCEGLJIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B94730", Offset = "0x2B93B30", VA = "0x182B94730")]
		internal void GDJGFKKAKLP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void BHBOANFFEGO(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void KNNDPJGALIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B99C00", Offset = "0x2B99000", VA = "0x182B99C00")]
		internal void IPIKGKMMAFC(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x152D3C0", Offset = "0x152C7C0", VA = "0x18152D3C0")]
		internal void AALIEMJDBEH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x17C7760", Offset = "0x17C6B60", VA = "0x1817C7760")]
		internal void MDDEOHNBKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MHKMLINKKEG<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public MHKMLINKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1764610", Offset = "0x1763A10", VA = "0x181764610")]
		internal void PLJFOLNAFLA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x22FC9D0", Offset = "0x22FBDD0", VA = "0x1822FC9D0")]
		internal void ODFLKOKOHJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HGBEJNPMEHB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KLOLCAIIKNK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71EFB0", Offset = "0x71E3B0")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HGBEJNPMEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1764610", Offset = "0x1763A10", VA = "0x181764610")]
		internal void PLJFOLNAFLA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x207B4A0", Offset = "0x207A8A0", VA = "0x18207B4A0")]
		internal void ODFLKOKOHJA(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PJDCADLDABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public LGAKEDCJAKH newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F010", Offset = "0x71E410")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public PJDCADLDABH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FA50", Offset = "0x2C4EE50", VA = "0x182C4FA50")]
		internal void GJODLIBPHKN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD4B1F0", Offset = "0xD4A5F0", VA = "0x180D4B1F0")]
		internal void EFCODJKGNDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LNOIFAFFHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F070", Offset = "0x71E470")]
		public KLOLCAIIKNK<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F0D0", Offset = "0x71E4D0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public LNOIFAFFHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x271A390", Offset = "0x2719790", VA = "0x18271A390")]
		internal void OFHILLMOIJA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x27193D0", Offset = "0x27187D0", VA = "0x1827193D0")]
		internal void OBCMIKIHEMG(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E770", Offset = "0x71DB70")]
	private DHHGEAPJGCF<T> BCIGHIDHCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E7D0", Offset = "0x71DBD0")]
	private DHHGEAPJGCF<string> MLAEDCLDEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GKDKEHLGAPJ HPDAGJOECGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private string? FOMNCGOADBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private T MOOEDNDCGLB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CEFOKEMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99C690", Offset = "0x99BA90", VA = "0x18099C690", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x997EB0", Offset = "0x9972B0", VA = "0x180997EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HALNDCBNDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3740E60", Offset = "0x3740260", VA = "0x183740E60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DOFOBMNLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x373F850", Offset = "0x373EC50", VA = "0x18373F850", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3740D40", Offset = "0x3740140", VA = "0x183740D40")]
	public static KDCMFGDLEKL<T> FIMDJEGGDOP(string FHDJIGKOLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x37465C0", Offset = "0x37459C0", VA = "0x1837465C0", Slot = "6")]
	public KDCMFGDLEKL<T> MFNMALCIGGF(Action<string> IMFKEALILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x373E4A0", Offset = "0x373D8A0", VA = "0x18373E4A0", Slot = "25")]
	public virtual KDCMFGDLEKL<T> BEBIPNIPKGK(Action LCAHJOJJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3744E70", Offset = "0x3744270", VA = "0x183744E70", Slot = "5")]
	public KDCMFGDLEKL<T> MCIIKHKIMKD(Action CCKGALNABMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x37457E0", Offset = "0x3744BE0", VA = "0x1837457E0", Slot = "4")]
	public KDCMFGDLEKL<T> MCIIKHKIMKD(Action<T> CCKGALNABMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2026410", Offset = "0x2025810", VA = "0x182026410", Slot = "18")]
	public KDCMFGDLEKL<TNew> IHOIHNIPDKO<TNew>(Func<KDCMFGDLEKL<TNew>> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E830", Offset = "0x71DC30")] Func<string, KDCMFGDLEKL<TNew>> MHEFOFAGGAE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x37439B0", Offset = "0x3742DB0", VA = "0x1837439B0", Slot = "19")]
	public LMHNGLGIJDH IHOIHNIPDKO(Func<LMHNGLGIJDH> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E890", Offset = "0x71DC90")] Func<string, LMHNGLGIJDH> MHEFOFAGGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26CD630", Offset = "0x26CCA30", VA = "0x1826CD630", Slot = "8")]
	public KDCMFGDLEKL<TNew> IHOIHNIPDKO<TNew>(Func<T, KDCMFGDLEKL<TNew>> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E8F0", Offset = "0x71DCF0")] Func<string, KDCMFGDLEKL<TNew>> MHEFOFAGGAE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3741710", Offset = "0x3740B10", VA = "0x183741710", Slot = "9")]
	public LMHNGLGIJDH IHOIHNIPDKO(Func<T, LMHNGLGIJDH> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71E950", Offset = "0x71DD50")] Func<string, LMHNGLGIJDH> MHEFOFAGGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x20204F0", Offset = "0x201F8F0", VA = "0x1820204F0", Slot = "20")]
	public KDCMFGDLEKL<TNew> BHDFDFBFOHO<TNew>(Func<TNew> GMKGDNJCGKE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26B83A0", Offset = "0x26B77A0", VA = "0x1826B83A0", Slot = "10")]
	public KDCMFGDLEKL<TNew> BHDFDFBFOHO<TNew>(Func<T, TNew> GMKGDNJCGKE) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x373F690", Offset = "0x373EA90", VA = "0x18373F690", Slot = "21")]
	private LMHNGLGIJDH BIEHONKBMJE(Func<string, string> GMKGDNJCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3740020", Offset = "0x373F420", VA = "0x183740020", Slot = "11")]
	public KDCMFGDLEKL<T> FHCEPPFBHOO(Func<string, string> GMKGDNJCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3747C70", Offset = "0x3747070", VA = "0x183747C70", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3743B70", Offset = "0x3742F70", VA = "0x183743B70", Slot = "15")]
	private LMHNGLGIJDH IJHAKHGBAPI(Action CCKGALNABMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x31E2600", Offset = "0x31E1A00", VA = "0x1831E2600", Slot = "16")]
	private LMHNGLGIJDH ICLEBBNACHB(Action<string> IMFKEALILNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3743BB0", Offset = "0x3742FB0", VA = "0x183743BB0", Slot = "17")]
	private LMHNGLGIJDH LDADCBPNCNK(Action LCAHJOJJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3744270", Offset = "0x3743670", VA = "0x183744270")]
	public void LKEHBOFLELP(T HOJNLEBJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3741380", Offset = "0x3740780", VA = "0x183741380")]
	protected Exception? IFCKIHIKJDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3745F90", Offset = "0x3745390", VA = "0x183745F90")]
	public void MFNMALCIGGF(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3740F90", Offset = "0x3740390", VA = "0x183740F90", Slot = "26")]
	protected virtual void HAGOEHICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3747D00", Offset = "0x3747100", VA = "0x183747D00")]
	public KLOLCAIIKNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LMHNGLGIJDH : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CEFOKEMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HALNDCBNDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool DOFOBMNLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMHNGLGIJDH MCIIKHKIMKD(Action CCKGALNABMO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMHNGLGIJDH MFNMALCIGGF(Action<string> IMFKEALILNG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMHNGLGIJDH BEBIPNIPKGK(Action LCAHJOJJLGP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDCMFGDLEKL<TNew> IHOIHNIPDKO<TNew>(Func<KDCMFGDLEKL<TNew>> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F130", Offset = "0x71E530")] Func<string, KDCMFGDLEKL<TNew>> MHEFOFAGGAE) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LMHNGLGIJDH IHOIHNIPDKO(Func<LMHNGLGIJDH> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F190", Offset = "0x71E590")] Func<string, LMHNGLGIJDH> MHEFOFAGGAE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KDCMFGDLEKL<TNew> BHDFDFBFOHO<TNew>(Func<TNew> GMKGDNJCGKE) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LMHNGLGIJDH FHCEPPFBHOO(Func<string, string> GMKGDNJCGKE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KDCMFGDLEKL<out T> : LMHNGLGIJDH, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KDCMFGDLEKL<T> MCIIKHKIMKD(Action<T> CCKGALNABMO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new KDCMFGDLEKL<T> MCIIKHKIMKD(Action CCKGALNABMO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new KDCMFGDLEKL<T> MFNMALCIGGF(Action<string> IMFKEALILNG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new KDCMFGDLEKL<T> BEBIPNIPKGK(Action LCAHJOJJLGP);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KDCMFGDLEKL<TNew> IHOIHNIPDKO<TNew>(Func<T, KDCMFGDLEKL<TNew>> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F1F0", Offset = "0x71E5F0")] Func<string, KDCMFGDLEKL<TNew>> MHEFOFAGGAE) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMHNGLGIJDH IHOIHNIPDKO(Func<T, LMHNGLGIJDH> GMKGDNJCGKE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F250", Offset = "0x71E650")] Func<string, LMHNGLGIJDH> MHEFOFAGGAE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDCMFGDLEKL<TNew> BHDFDFBFOHO<TNew>(Func<T, TNew> GMKGDNJCGKE) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new KDCMFGDLEKL<T> FHCEPPFBHOO(Func<string, string> GMKGDNJCGKE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class GFMLIJGMAEE
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum OILKHPBDFDP : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class DOLCBPFHNPL : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71A1870", Offset = "0x71A0C70", VA = "0x1871A1870")]
		public DOLCBPFHNPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HMNENNCDMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HMNENNCDMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71A2AB0", Offset = "0x71A1EB0", VA = "0x1871A2AB0")]
		internal void PJDJCOILBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x71A29D0", Offset = "0x71A1DD0", VA = "0x1871A29D0")]
		internal void BPBDCCJOJJH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x71A2A60", Offset = "0x71A1E60", VA = "0x1871A2A60")]
		internal void DANLFMNPGEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BOCKNJEHGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public PMFPAFFNEKC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public OILKHPBDFDP unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BOCKNJEHGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71A1820", Offset = "0x71A0C20", VA = "0x1871A1820")]
		internal void PJDJCOILBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x71A1560", Offset = "0x71A0960", VA = "0x1871A1560")]
		internal void BPBDCCJOJJH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x71A15F0", Offset = "0x71A09F0", VA = "0x1871A15F0")]
		internal void DANLFMNPGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x71A1690", Offset = "0x71A0A90", VA = "0x1871A1690")]
		internal void OOOLDMADLBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MAJHKFADIJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MAJHKFADIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24532A0", Offset = "0x24526A0", VA = "0x1824532A0")]
		internal void MFBAFNDONNO(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HAGHDHGOAON<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public HAGHDHGOAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x31B3820", Offset = "0x31B2C20", VA = "0x1831B3820")]
		internal void PJDJCOILBAD(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x31B3410", Offset = "0x31B2810", VA = "0x1831B3410")]
		internal void BPBDCCJOJJH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1764050", Offset = "0x1763450", VA = "0x181764050")]
		internal void DANLFMNPGEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CEOIAKINCFE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public PMFPAFFNEKC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public OILKHPBDFDP unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public CEOIAKINCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x309E190", Offset = "0x309D590", VA = "0x18309E190")]
		internal void PJDJCOILBAD(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x309DD50", Offset = "0x309D150", VA = "0x18309DD50")]
		internal void BPBDCCJOJJH(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x309DDF0", Offset = "0x309D1F0", VA = "0x18309DDF0")]
		internal void DANLFMNPGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x309E060", Offset = "0x309D460", VA = "0x18309E060")]
		internal void OOOLDMADLBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IJOIBGLBPOD<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public IJOIBGLBPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x24532A0", Offset = "0x24526A0", VA = "0x1824532A0")]
		internal void MFBAFNDONNO(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NKNHOKMPHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LGAKEDCJAKH promise;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NKNHOKMPHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x71A44B0", Offset = "0x71A38B0", VA = "0x1871A44B0")]
		internal void MPCGODMLMAJ(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ENOMNPAPGGC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KLOLCAIIKNK<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public ENOMNPAPGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1380D50", Offset = "0x1380150", VA = "0x181380D50")]
		internal void MPCGODMLMAJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F2F0", Offset = "0x71E6F0")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x71A1EB0", Offset = "0x71A12B0", VA = "0x1871A1EB0")]
	public static Task EDACCDHDFEI(this LMHNGLGIJDH LNIBEAPDNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x71A1B30", Offset = "0x71A0F30", VA = "0x1871A1B30")]
	public static Task<bool> EDACCDHDFEI(this LMHNGLGIJDH LNIBEAPDNEC, CancellationToken ODBDCIFDKPJ, OILKHPBDFDP GDKMLAKLJBF = OILKHPBDFDP.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x16D9530", Offset = "0x16D8930", VA = "0x1816D9530")]
	public static Task<TResult> EDACCDHDFEI<TResult>(this KDCMFGDLEKL<TResult> LNIBEAPDNEC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x16D9760", Offset = "0x16D8B60", VA = "0x1816D9760")]
	public static Task<TResult> EDACCDHDFEI<TResult>(this KDCMFGDLEKL<TResult> LNIBEAPDNEC, CancellationToken ODBDCIFDKPJ, OILKHPBDFDP GDKMLAKLJBF = OILKHPBDFDP.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x71A22B0", Offset = "0x71A16B0", VA = "0x1871A22B0")]
	public static TaskAwaiter OHPNENBCPKD(this LMHNGLGIJDH LNIBEAPDNEC)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x16DB1A0", Offset = "0x16DA5A0", VA = "0x1816DB1A0")]
	public static TaskAwaiter<TResult> OHPNENBCPKD<TResult>(this KDCMFGDLEKL<TResult> LNIBEAPDNEC) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71A20C0", Offset = "0x71A14C0", VA = "0x1871A20C0")]
	public static LMHNGLGIJDH NKCFAAPIFJN(this Task NOKNMHIKNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x16DA200", Offset = "0x16D9600", VA = "0x1816DA200")]
	public static KDCMFGDLEKL<TResult> NKCFAAPIFJN<TResult>(this Task<TResult> NOKNMHIKNGD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x71A1960", Offset = "0x71A0D60", VA = "0x1871A1960")]
	private static string DBGPDCAOIDN(Task NOKNMHIKNGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface PMFPAFFNEKC : LMHNGLGIJDH, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GFLEAGLNCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool COLLIEKGPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIFJDOAKCLM();

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMFPAFFNEKC CBAGJMOJMNK(Action JMHFGHADJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MLLKJEFEBMF<T> : KDCMFGDLEKL<T>, LMHNGLGIJDH, IEnumerator, PMFPAFFNEKC
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new MLLKJEFEBMF<T> CBAGJMOJMNK(Action JMHFGHADJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OMGHDDIPCMD : LGAKEDCJAKH, PMFPAFFNEKC, LMHNGLGIJDH, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private GKDKEHLGAPJ JMHFGHADJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static PMFPAFFNEKC AGIOANGIAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x71A4870", Offset = "0x71A3C70", VA = "0x1871A4870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GFLEAGLNCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x13DC520", Offset = "0x13DB920", VA = "0x1813DC520", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x13DC330", Offset = "0x13DB730", VA = "0x1813DC330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool COLLIEKGPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x71A4730", Offset = "0x71A3B30", VA = "0x1871A4730", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x71A4930", Offset = "0x71A3D30", VA = "0x1871A4930")]
	static OMGHDDIPCMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202B630", VA = "0x18202C230")]
	public new static MLLKJEFEBMF<T> EEDJOIGGPIP<T>(T MOOEDNDCGLB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202B630", VA = "0x18202C230")]
	public new static MLLKJEFEBMF<T> FIMDJEGGDOP<T>(string FOMNCGOADBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x71A4750", Offset = "0x71A3B50", VA = "0x1871A4750", Slot = "21")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x71A46E0", Offset = "0x71A3AE0", VA = "0x1871A46E0", Slot = "22")]
	public PMFPAFFNEKC CBAGJMOJMNK(Action NKNAJAKGHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x71A48D0", Offset = "0x71A3CD0", VA = "0x1871A48D0", Slot = "18")]
	protected override void HAGOEHICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x71A4680", Offset = "0x71A3A80", VA = "0x1871A4680", Slot = "17")]
	public override LMHNGLGIJDH BEBIPNIPKGK(Action LCAHJOJJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x71A4A40", Offset = "0x71A3E40", VA = "0x1871A4A40")]
	public OMGHDDIPCMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71F350", Offset = "0x71E750")]
public class ONGLKPNKPLL<T> : KLOLCAIIKNK<T>, MLLKJEFEBMF<T>, KDCMFGDLEKL<T>, LMHNGLGIJDH, IEnumerator, PMFPAFFNEKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GKDKEHLGAPJ JMHFGHADJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GFLEAGLNCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xD573C0", Offset = "0xD567C0", VA = "0x180D573C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x12E5DC0", Offset = "0x12E51C0", VA = "0x1812E5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool COLLIEKGPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FA40C0", Offset = "0x2FA34C0", VA = "0x182FA40C0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4130", Offset = "0x2FA3530", VA = "0x182FA4130", Slot = "30")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4050", Offset = "0x2FA3450", VA = "0x182FA4050", Slot = "27")]
	public MLLKJEFEBMF<T> CBAGJMOJMNK(Action NKNAJAKGHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x20614A0", Offset = "0x20608A0", VA = "0x1820614A0", Slot = "31")]
	private PMFPAFFNEKC KEBIOIAMECM(Action NKNAJAKGHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4450", Offset = "0x2FA3850", VA = "0x182FA4450", Slot = "26")]
	protected override void HAGOEHICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3F50", Offset = "0x2FA3350", VA = "0x182FA3F50", Slot = "25")]
	public override KDCMFGDLEKL<T> BEBIPNIPKGK(Action LCAHJOJJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4490", Offset = "0x2FA3890", VA = "0x182FA4490")]
	public ONGLKPNKPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MFFCALKICPJ : IICJIMCDBJL, PMFPAFFNEKC, LMHNGLGIJDH, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GKDKEHLGAPJ JMHFGHADJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GFLEAGLNCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD573C0", Offset = "0xD567C0", VA = "0x180D573C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x12E5DC0", Offset = "0x12E51C0", VA = "0x1812E5DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool COLLIEKGPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x71A3C10", Offset = "0x71A3010", VA = "0x1871A3C10", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x71A3F80", Offset = "0x71A3380", VA = "0x1871A3F80")]
	public MFFCALKICPJ(PMFPAFFNEKC LNIBEAPDNEC, PMFPAFFNEKC KAJPEAMELLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x71A40A0", Offset = "0x71A34A0", VA = "0x1871A40A0")]
	public MFFCALKICPJ(IList<PMFPAFFNEKC> PCCBDHBIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x71A3C30", Offset = "0x71A3030", VA = "0x1871A3C30", Slot = "21")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x71A3BC0", Offset = "0x71A2FC0", VA = "0x1871A3BC0", Slot = "22")]
	public PMFPAFFNEKC CBAGJMOJMNK(Action NKNAJAKGHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x71A3F20", Offset = "0x71A3320", VA = "0x1871A3F20", Slot = "18")]
	protected override void HAGOEHICNEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B60", Offset = "0x71A2F60", VA = "0x1871A3B60", Slot = "17")]
	public override LMHNGLGIJDH BEBIPNIPKGK(Action LCAHJOJJLGP)
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
