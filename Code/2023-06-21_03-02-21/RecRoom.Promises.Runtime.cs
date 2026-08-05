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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1554C80", Offset = "0x1553E80", VA = "0x181554C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEAHFOOPDKA : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string HJBEFGPOLHA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1553160", Offset = "0x1552360", VA = "0x181553160")]
	public HEAHFOOPDKA(string CEOMJLPEFPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D5F0", Offset = "0x7C9F0")]
public class CCJNEOALIPM<T1, T2> : JFMAKJPJKJA<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NIAGKELNCNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D660", Offset = "0x7CA60")]
		public NHJDNADPIAN<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CCJNEOALIPM<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public NIAGKELNCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2F680D0", Offset = "0x2F672D0", VA = "0x182F680D0")]
		internal void JLAGHHAIHJM(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DJKBIPDOCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NIAGKELNCNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DJKBIPDOCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x375CAC0", Offset = "0x375BCC0", VA = "0x18375CAC0")]
		internal void EDGMKHOMBFJ(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3697B60", Offset = "0x3696D60", VA = "0x183697B60")]
	public CCJNEOALIPM(NHJDNADPIAN<T1> APOJHPCBDDH, NHJDNADPIAN<T2> JCPFHCGBPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3697890", Offset = "0x3696A90", VA = "0x183697890")]
	private void LGIFDNIKKNH(string KLEKJFJOCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D6E0", Offset = "0x7CAE0")]
public class FOFJNGIGGIP<T1, T2, T3> : JFMAKJPJKJA<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AOAIPAOPOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D750", Offset = "0x7CB50")]
		public NHJDNADPIAN<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D7B0", Offset = "0x7CBB0")]
		public NHJDNADPIAN<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public FOFJNGIGGIP<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public AOAIPAOPOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2F67FA0", Offset = "0x2F671A0", VA = "0x182F67FA0")]
		internal void JLAGHHAIHJM(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BGOFGALJJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AOAIPAOPOLH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BGOFGALJJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33ED700", Offset = "0x33EC900", VA = "0x1833ED700")]
		internal void EDGMKHOMBFJ(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MEEDICFFLMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BGOFGALJJAA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public MEEDICFFLMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x30499B0", Offset = "0x3048BB0", VA = "0x1830499B0")]
		internal void ADEGEGOKAKO(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0670", Offset = "0x3A9F870", VA = "0x183AA0670")]
	public FOFJNGIGGIP(NHJDNADPIAN<T1> APOJHPCBDDH, NHJDNADPIAN<T2> JCPFHCGBPBJ, NHJDNADPIAN<T3> OBJAGLLEIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0320", Offset = "0x3A9F520", VA = "0x183AA0320")]
	private void LGIFDNIKKNH(string KLEKJFJOCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D810", Offset = "0x7CC10")]
public class ODHHBKGDDLK<T1, T2, T3, T4, T5> : JFMAKJPJKJA<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ELPIJJFKIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D880", Offset = "0x7CC80")]
		public NHJDNADPIAN<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D8E0", Offset = "0x7CCE0")]
		public NHJDNADPIAN<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D940", Offset = "0x7CD40")]
		public NHJDNADPIAN<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7D9A0", Offset = "0x7CDA0")]
		public NHJDNADPIAN<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public ODHHBKGDDLK<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public ELPIJJFKIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2F68200", Offset = "0x2F67400", VA = "0x182F68200")]
		internal void JLAGHHAIHJM(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class PHAOFDCDLHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public ELPIJJFKIJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PHAOFDCDLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x33ED700", Offset = "0x33EC900", VA = "0x1833ED700")]
		internal void EDGMKHOMBFJ(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OMJNBALBGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public PHAOFDCDLHD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public OMJNBALBGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3244B70", Offset = "0x3243D70", VA = "0x183244B70")]
		internal void ADEGEGOKAKO(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IMPLBLCJJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OMJNBALBGDN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IMPLBLCJJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x275C730", Offset = "0x275B930", VA = "0x18275C730")]
		internal void MPPMCONNIHP(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GMKLGBOBMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IMPLBLCJJIL CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public GMKLGBOBMLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F04330", Offset = "0x3F03530", VA = "0x183F04330")]
		internal void DBOLHKBDJNC(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x356C580", Offset = "0x356B780", VA = "0x18356C580")]
	public ODHHBKGDDLK(NHJDNADPIAN<T1> APOJHPCBDDH, NHJDNADPIAN<T2> JCPFHCGBPBJ, NHJDNADPIAN<T3> OBJAGLLEIAE, NHJDNADPIAN<T4> LFGPGCKDACN, NHJDNADPIAN<T5> FKFPKGIIDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x356C510", Offset = "0x356B710", VA = "0x18356C510")]
	private void LGIFDNIKKNH(string KLEKJFJOCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DA00", Offset = "0x7CE00")]
public class CGADCLAFBIC<T> : JFMAKJPJKJA<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BKMIFPGKLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CGADCLAFBIC<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BKMIFPGKLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x476FC00", Offset = "0x476EE00", VA = "0x18476FC00")]
		internal void JLAGHHAIHJM(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DA70", Offset = "0x7CE70")]
	private readonly T[] AKFBKGGCMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int EFHHNNGEIIA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x36DD4B0", Offset = "0x36DC6B0", VA = "0x1836DD4B0")]
	public CGADCLAFBIC(List<NHJDNADPIAN<T>> KFPONPMKGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x36DCC80", Offset = "0x36DBE80", VA = "0x1836DCC80")]
	private void LGIFDNIKKNH(string KLEKJFJOCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLOMBPKEBMA : DAFGDOMLDFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int EDKJPLMKEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<OOPPNGPPPLE> KFPONPMKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> AOAKMKNOHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1553910", Offset = "0x1552B10", VA = "0x181553910")]
	public LLOMBPKEBMA(params OOPPNGPPPLE[] KFPONPMKGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1553510", Offset = "0x1552710", VA = "0x181553510")]
	public LLOMBPKEBMA(IReadOnlyList<OOPPNGPPPLE> KFPONPMKGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1553420", Offset = "0x1552620", VA = "0x181553420")]
	private void HNEIFJOCIOG(string CADCCPALFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1553480", Offset = "0x1552680", VA = "0x181553480")]
	private void LEECLDPOIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JAJNDHOBPPO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string CHFGJOPKLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F4BF0", Offset = "0x9F3DF0", VA = "0x1809F4BF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1553270", Offset = "0x1552470", VA = "0x181553270")]
	public JAJNDHOBPPO(Exception EKEFPFGKHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15531E0", Offset = "0x15523E0", VA = "0x1815531E0")]
	private static string FODIIPJMILB(Exception EKEFPFGKHCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DAFGDOMLDFF : OOPPNGPPPLE, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IFIFHKIGBOE<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DBF0", Offset = "0x7CFF0")]
		public Func<string, NHJDNADPIAN<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DC50", Offset = "0x7D050")]
		public Func<NHJDNADPIAN<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DCB0", Offset = "0x7D0B0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DD10", Offset = "0x7D110")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IFIFHKIGBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A09340", Offset = "0x2A08540", VA = "0x182A09340")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void CGCAMGHAJNA(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2A08110", Offset = "0x2A07310", VA = "0x182A08110")]
		internal void DPCNJEGGNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void GKGPJIJKKOK(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class OPGHICMIAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DD70", Offset = "0x7D170")]
		public Func<string, OOPPNGPPPLE> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public DAFGDOMLDFF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DDD0", Offset = "0x7D1D0")]
		public Func<OOPPNGPPPLE> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DE30", Offset = "0x7D230")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DE90", Offset = "0x7D290")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OPGHICMIAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1554EC0", Offset = "0x15540C0", VA = "0x181554EC0")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void CGCAMGHAJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1554D50", Offset = "0x1553F50", VA = "0x181554D50")]
		internal void DPCNJEGGNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void GKGPJIJKKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BLBLPMEJBCH<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BLBLPMEJBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2754CF0", Offset = "0x2753EF0", VA = "0x182754CF0")]
		internal void OHIHHMEMOHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x33786A0", Offset = "0x33778A0", VA = "0x1833786A0")]
		internal void BPCEHLPPHIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LLPKPAHMAKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DAFGDOMLDFF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DEF0", Offset = "0x7D2F0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LLPKPAHMAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1553920", Offset = "0x1552B20", VA = "0x181553920")]
		internal void EMINMKGAEOD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x15539A0", Offset = "0x1552BA0", VA = "0x1815539A0")]
		internal void HKKNCODBAEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string DBBIIMJIAFK = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> IGFDEJGCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> BFFMDNEAAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> ADFMHHBIDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? KLEKJFJOCHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OOPPNGPPPLE NBJBLNEDLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1552880", Offset = "0x1551A80", VA = "0x181552880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B70", Offset = "0x8D5D70", VA = "0x1808D6B70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xABB080", Offset = "0xABA280", VA = "0x180ABB080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OFDIOBPDLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1552B30", Offset = "0x1551D30", VA = "0x181552B30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MEKKMHPEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1552C90", Offset = "0x1551E90", VA = "0x181552C90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1552E50", Offset = "0x1552050", VA = "0x181552E50")]
	static DAFGDOMLDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0820", Offset = "0x2B9FA20", VA = "0x182BA0820")]
	public static NHJDNADPIAN<T> DOENFLFFJFD<T>(T GAFKIBJKPNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1552060", Offset = "0x1551260", VA = "0x181552060")]
	public static OOPPNGPPPLE BAPLAIJPOAK(string KLEKJFJOCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0820", Offset = "0x2B9FA20", VA = "0x182BA0820")]
	public static NHJDNADPIAN<T> BAPLAIJPOAK<T>(string KLEKJFJOCHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x15523B0", Offset = "0x15515B0", VA = "0x1815523B0", Slot = "8")]
	public OOPPNGPPPLE BNBIONAAEJG(Action<string> DGLOEHMKNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1552DC0", Offset = "0x1551FC0", VA = "0x181552DC0", Slot = "17")]
	public virtual OOPPNGPPPLE ONPNCEEDGCM(Action LBMGIKCJOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1552D30", Offset = "0x1551F30", VA = "0x181552D30", Slot = "7")]
	public OOPPNGPPPLE OHADHPFCHPK(Action DKEPHKCEMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF120", Offset = "0x2BFE320", VA = "0x182BFF120", Slot = "10")]
	public NHJDNADPIAN<TNew> EEKFHMGGOIG<TNew>(Func<NHJDNADPIAN<TNew>> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DB30", Offset = "0x7CF30")] Func<string, NHJDNADPIAN<TNew>> GIOOPLHFBOM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1552450", Offset = "0x1551650", VA = "0x181552450", Slot = "11")]
	public OOPPNGPPPLE EEKFHMGGOIG(Func<OOPPNGPPPLE> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DB90", Offset = "0x7CF90")] Func<string, OOPPNGPPPLE> GIOOPLHFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0BA0", Offset = "0x2B9FDA0", VA = "0x182BA0BA0", Slot = "12")]
	public NHJDNADPIAN<TNew> CMDBMJDLKGK<TNew>(Func<TNew> OIIABCMFBJG) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1552670", Offset = "0x1551870", VA = "0x181552670", Slot = "13")]
	public OOPPNGPPPLE FDMOLBBFLOL(Func<string, string> OIIABCMFBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1552E40", Offset = "0x1552040", VA = "0x181552E40", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x15528E0", Offset = "0x1551AE0", VA = "0x1815528E0")]
	public void HEEDEOJNDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x15520D0", Offset = "0x15512D0", VA = "0x1815520D0")]
	public void BNBIONAAEJG(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1552B50", Offset = "0x1551D50", VA = "0x181552B50")]
	protected Exception? LLKGHNGDMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1552CB0", Offset = "0x1551EB0", VA = "0x181552CB0", Slot = "18")]
	protected virtual void NIIPNANCJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1552EC0", Offset = "0x15520C0", VA = "0x181552EC0")]
	public DAFGDOMLDFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JFMAKJPJKJA<T> : NHJDNADPIAN<T>, OOPPNGPPPLE, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct HKAOLAGDKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E130", Offset = "0x7D530")]
		public readonly Action<T> JFFMHPNGJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? FEBEENFKOCM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1A82610", Offset = "0x1A81810", VA = "0x181A82610")]
		public HKAOLAGDKGA(Action<T> JFFMHPNGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x151C930", Offset = "0x151BB30", VA = "0x18151C930")]
		public HKAOLAGDKGA(Action FEBEENFKOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x43448D0", Offset = "0x4343AD0", VA = "0x1843448D0")]
		public void OGNFCKBDNLK(T DGLHFPEOHIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DFAIGBBAJNA<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E190", Offset = "0x7D590")]
		public Func<string, NHJDNADPIAN<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E1F0", Offset = "0x7D5F0")]
		public Func<NHJDNADPIAN<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E250", Offset = "0x7D650")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E2B0", Offset = "0x7D6B0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DFAIGBBAJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4C61E00", Offset = "0x4C61000", VA = "0x184C61E00")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void CGCAMGHAJNA(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4C5C280", Offset = "0x4C5B480", VA = "0x184C5C280")]
		internal void DPCNJEGGNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void GKGPJIJKKOK(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DIKGJDMJLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E310", Offset = "0x7D710")]
		public Func<string, OOPPNGPPPLE> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DAFGDOMLDFF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E370", Offset = "0x7D770")]
		public Func<OOPPNGPPPLE> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E3D0", Offset = "0x7D7D0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E430", Offset = "0x7D830")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DIKGJDMJLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4379C40", Offset = "0x4378E40", VA = "0x184379C40")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void CGCAMGHAJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4376380", Offset = "0x4375580", VA = "0x184376380")]
		internal void DPCNJEGGNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void GKGPJIJKKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BNGJMDDLCBD<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E490", Offset = "0x7D890")]
		public Func<string, NHJDNADPIAN<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E4F0", Offset = "0x7D8F0")]
		public Func<T, NHJDNADPIAN<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E550", Offset = "0x7D950")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E5B0", Offset = "0x7D9B0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BNGJMDDLCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4788020", Offset = "0x4787220", VA = "0x184788020")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void CGCAMGHAJNA(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4782CA0", Offset = "0x4781EA0", VA = "0x184782CA0")]
		internal void DPCNJEGGNEC(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A077A0", Offset = "0x2A069A0", VA = "0x182A077A0")]
		internal void GKGPJIJKKOK(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MBINOGEOHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E610", Offset = "0x7DA10")]
		public Func<string, OOPPNGPPPLE> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DAFGDOMLDFF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E670", Offset = "0x7DA70")]
		public Func<T, OOPPNGPPPLE> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E6D0", Offset = "0x7DAD0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E730", Offset = "0x7DB30")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public MBINOGEOHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3041A60", Offset = "0x3040C60", VA = "0x183041A60")]
		internal void LOCJNNOICIC(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void CLBDIBJAPKM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void CGCAMGHAJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x303CCC0", Offset = "0x303BEC0", VA = "0x18303CCC0")]
		internal void DPCNJEGGNEC(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1554D30", Offset = "0x1553F30", VA = "0x181554D30")]
		internal void IBHNAPLAOME(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1554D10", Offset = "0x1553F10", VA = "0x181554D10")]
		internal void GKGPJIJKKOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HIHFNDKKANF<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public HIHFNDKKANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2754CF0", Offset = "0x2753EF0", VA = "0x182754CF0")]
		internal void OHIHHMEMOHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x33786A0", Offset = "0x33778A0", VA = "0x1833786A0")]
		internal void BPCEHLPPHIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PALDFEJHCGE<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JFMAKJPJKJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E790", Offset = "0x7DB90")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PALDFEJHCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2754CF0", Offset = "0x2753EF0", VA = "0x182754CF0")]
		internal void OHIHHMEMOHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A2AA30", Offset = "0x3A29C30", VA = "0x183A2AA30")]
		internal void BPCEHLPPHIC(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NNEHNGIPNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DAFGDOMLDFF newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E7F0", Offset = "0x7DBF0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public NNEHNGIPNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4663680", Offset = "0x4662880", VA = "0x184663680")]
		internal void HCIFKHFEKFA(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x15539A0", Offset = "0x1552BA0", VA = "0x1815539A0")]
		internal void ILDCKHAMDKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HKFAPCHPPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E850", Offset = "0x7DC50")]
		public JFMAKJPJKJA<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E8B0", Offset = "0x7DCB0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public HKFAPCHPPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4345830", Offset = "0x4344A30", VA = "0x184345830")]
		internal void EMINMKGAEOD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFC80", Offset = "0x2DCEE80", VA = "0x182DCFC80")]
		internal void HKKNCODBAEI(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DF50", Offset = "0x7D350")]
	private readonly List<JFMAKJPJKJA<T>.HKAOLAGDKGA> ADFMHHBIDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> IGFDEJGCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> BFFMDNEAAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? KLEKJFJOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T GAFKIBJKPNO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0D920", Offset = "0xA0CB20", VA = "0x180A0D920", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8F0", Offset = "0xA0CAF0", VA = "0x180A0D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OFDIOBPDLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x34EFBA0", Offset = "0x34EEDA0", VA = "0x1834EFBA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MEKKMHPEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x34F0130", Offset = "0x34EF330", VA = "0x1834F0130", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34ED250", Offset = "0x34EC450", VA = "0x1834ED250")]
	public static NHJDNADPIAN<T> BAPLAIJPOAK(string CEOMJLPEFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34ED460", Offset = "0x34EC660", VA = "0x1834ED460", Slot = "6")]
	public NHJDNADPIAN<T> BNBIONAAEJG(Action<string> DGLOEHMKNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34F0790", Offset = "0x34EF990", VA = "0x1834F0790", Slot = "25")]
	public virtual NHJDNADPIAN<T> ONPNCEEDGCM(Action LBMGIKCJOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34F0360", Offset = "0x34EF560", VA = "0x1834F0360", Slot = "5")]
	public NHJDNADPIAN<T> OHADHPFCHPK(Action DKEPHKCEMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34F05F0", Offset = "0x34EF7F0", VA = "0x1834F05F0", Slot = "4")]
	public NHJDNADPIAN<T> OHADHPFCHPK(Action<T> DKEPHKCEMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2641480", Offset = "0x2640680", VA = "0x182641480", Slot = "18")]
	public NHJDNADPIAN<TNew> EEKFHMGGOIG<TNew>(Func<NHJDNADPIAN<TNew>> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7DFB0", Offset = "0x7D3B0")] Func<string, NHJDNADPIAN<TNew>> GIOOPLHFBOM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34EE830", Offset = "0x34EDA30", VA = "0x1834EE830", Slot = "19")]
	public OOPPNGPPPLE EEKFHMGGOIG(Func<OOPPNGPPPLE> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E010", Offset = "0x7D410")] Func<string, OOPPNGPPPLE> GIOOPLHFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x37598E0", Offset = "0x3758AE0", VA = "0x1837598E0", Slot = "8")]
	public NHJDNADPIAN<TNew> EEKFHMGGOIG<TNew>(Func<T, NHJDNADPIAN<TNew>> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E070", Offset = "0x7D470")] Func<string, NHJDNADPIAN<TNew>> GIOOPLHFBOM) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34EE9F0", Offset = "0x34EDBF0", VA = "0x1834EE9F0", Slot = "9")]
	public OOPPNGPPPLE EEKFHMGGOIG(Func<T, OOPPNGPPPLE> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E0D0", Offset = "0x7D4D0")] Func<string, OOPPNGPPPLE> GIOOPLHFBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2639FE0", Offset = "0x26391E0", VA = "0x182639FE0", Slot = "20")]
	public NHJDNADPIAN<TNew> CMDBMJDLKGK<TNew>(Func<TNew> OIIABCMFBJG) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3742C60", Offset = "0x3741E60", VA = "0x183742C60", Slot = "10")]
	public NHJDNADPIAN<TNew> CMDBMJDLKGK<TNew>(Func<T, TNew> OIIABCMFBJG) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34ECD10", Offset = "0x34EBF10", VA = "0x1834ECD10", Slot = "21")]
	private OOPPNGPPPLE ADAIMHBJKHN(Func<string, string> OIIABCMFBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x34EEFB0", Offset = "0x34EE1B0", VA = "0x1834EEFB0", Slot = "11")]
	public NHJDNADPIAN<T> FDMOLBBFLOL(Func<string, string> OIIABCMFBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34F08F0", Offset = "0x34EFAF0", VA = "0x1834F08F0", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34ED370", Offset = "0x34EC570", VA = "0x1834ED370", Slot = "15")]
	private OOPPNGPPPLE BDINNAOAHCE(Action DKEPHKCEMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AF50", Offset = "0x2F8A150", VA = "0x182F8AF50", Slot = "16")]
	private OOPPNGPPPLE CHMMBKODAOG(Action<string> DGLOEHMKNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34EE0C0", Offset = "0x34ED2C0", VA = "0x1834EE0C0", Slot = "17")]
	private OOPPNGPPPLE CMFAGAGKLIG(Action LBMGIKCJOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x34EF1A0", Offset = "0x34EE3A0", VA = "0x1834EF1A0")]
	public void HEEDEOJNDNP(T DGLHFPEOHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x34EFF70", Offset = "0x34EF170", VA = "0x1834EFF70")]
	protected Exception? LLKGHNGDMBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x34ED5E0", Offset = "0x34EC7E0", VA = "0x1834ED5E0")]
	public void BNBIONAAEJG(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x34F02C0", Offset = "0x34EF4C0", VA = "0x1834F02C0", Slot = "26")]
	protected virtual void NIIPNANCJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x34F0920", Offset = "0x34EFB20", VA = "0x1834F0920")]
	public JFMAKJPJKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OOPPNGPPPLE : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OFDIOBPDLOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MEKKMHPEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOPPNGPPPLE OHADHPFCHPK(Action DKEPHKCEMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOPPNGPPPLE BNBIONAAEJG(Action<string> DGLOEHMKNII);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOPPNGPPPLE ONPNCEEDGCM(Action LBMGIKCJOFM);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NHJDNADPIAN<TNew> EEKFHMGGOIG<TNew>(Func<NHJDNADPIAN<TNew>> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E910", Offset = "0x7DD10")] Func<string, NHJDNADPIAN<TNew>> GIOOPLHFBOM) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OOPPNGPPPLE EEKFHMGGOIG(Func<OOPPNGPPPLE> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E970", Offset = "0x7DD70")] Func<string, OOPPNGPPPLE> GIOOPLHFBOM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NHJDNADPIAN<TNew> CMDBMJDLKGK<TNew>(Func<TNew> OIIABCMFBJG) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OOPPNGPPPLE FDMOLBBFLOL(Func<string, string> OIIABCMFBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NHJDNADPIAN<out T> : OOPPNGPPPLE, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHJDNADPIAN<T> OHADHPFCHPK(Action<T> DKEPHKCEMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new NHJDNADPIAN<T> OHADHPFCHPK(Action DKEPHKCEMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new NHJDNADPIAN<T> BNBIONAAEJG(Action<string> DGLOEHMKNII);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new NHJDNADPIAN<T> ONPNCEEDGCM(Action LBMGIKCJOFM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NHJDNADPIAN<TNew> EEKFHMGGOIG<TNew>(Func<T, NHJDNADPIAN<TNew>> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9D0", Offset = "0x7DDD0")] Func<string, NHJDNADPIAN<TNew>> GIOOPLHFBOM) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOPPNGPPPLE EEKFHMGGOIG(Func<T, OOPPNGPPPLE> OIIABCMFBJG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EA30", Offset = "0x7DE30")] Func<string, OOPPNGPPPLE> GIOOPLHFBOM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NHJDNADPIAN<TNew> CMDBMJDLKGK<TNew>(Func<T, TNew> OIIABCMFBJG) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new NHJDNADPIAN<T> FDMOLBBFLOL(Func<string, string> OIIABCMFBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NILPFCIANDH
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum OCLBKIDKJDK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class GPOJGFGJOCJ : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x15530F0", Offset = "0x15522F0", VA = "0x1815530F0")]
		public GPOJGFGJOCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DDEHJOKEGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DDEHJOKEGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x15530A0", Offset = "0x15522A0", VA = "0x1815530A0")]
		internal void DKNNPHPJOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1552FC0", Offset = "0x15521C0", VA = "0x181552FC0")]
		internal void BIOPHBPANOK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1553050", Offset = "0x1552250", VA = "0x181553050")]
		internal void BLMMLGMOLDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CHMLMEEHNCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public MMEJLKMBIHL cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OCLBKIDKJDK unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CHMLMEEHNCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1551E80", Offset = "0x1551080", VA = "0x181551E80")]
		internal void DKNNPHPJOHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1551D50", Offset = "0x1550F50", VA = "0x181551D50")]
		internal void BIOPHBPANOK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1551DE0", Offset = "0x1550FE0", VA = "0x181551DE0")]
		internal void BLMMLGMOLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1551ED0", Offset = "0x15510D0", VA = "0x181551ED0")]
		internal void FHAPGJMKKIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MOCLMOECJLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MOCLMOECJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1554310", Offset = "0x1553510", VA = "0x181554310")]
		internal void NIDJOPJHLPC(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PBALBJFHDIE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PBALBJFHDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35CE270", Offset = "0x35CD470", VA = "0x1835CE270")]
		internal void DKNNPHPJOHE(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35CDFF0", Offset = "0x35CD1F0", VA = "0x1835CDFF0")]
		internal void BIOPHBPANOK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BD70", Offset = "0x2C7AF70", VA = "0x182C7BD70")]
		internal void BLMMLGMOLDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JDOKCCDHFJE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MMEJLKMBIHL cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public OCLBKIDKJDK unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public JDOKCCDHFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x34E78F0", Offset = "0x34E6AF0", VA = "0x1834E78F0")]
		internal void DKNNPHPJOHE(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x34E7670", Offset = "0x34E6870", VA = "0x1834E7670")]
		internal void BIOPHBPANOK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x34E77B0", Offset = "0x34E69B0", VA = "0x1834E77B0")]
		internal void BLMMLGMOLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x34E7950", Offset = "0x34E6B50", VA = "0x1834E7950")]
		internal void FHAPGJMKKIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DCMGBIKKOCP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DCMGBIKKOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1554310", Offset = "0x1553510", VA = "0x181554310")]
		internal void NIDJOPJHLPC(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JBACDMPKGHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DAFGDOMLDFF promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JBACDMPKGHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1553360", Offset = "0x1552560", VA = "0x181553360")]
		internal void MPJFIAOGINB(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DJGBLEJKBDN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public JFMAKJPJKJA<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public DJGBLEJKBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x437E040", Offset = "0x437D240", VA = "0x18437E040")]
		internal void MPJFIAOGINB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EAD0", Offset = "0x7DED0")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1554520", Offset = "0x1553720", VA = "0x181554520")]
	public static Task NHGJBJCKFEF(this OOPPNGPPPLE IPHCMLMIPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1554730", Offset = "0x1553930", VA = "0x181554730")]
	public static Task<bool> NHGJBJCKFEF(this OOPPNGPPPLE IPHCMLMIPHN, CancellationToken PLEKJLHDOLP, OCLBKIDKJDK OHJCPCKLPJE = OCLBKIDKJDK.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB2D0", Offset = "0x2FEA4D0", VA = "0x182FEB2D0")]
	public static Task<TResult> NHGJBJCKFEF<TResult>(this NHJDNADPIAN<TResult> IPHCMLMIPHN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2FEB500", Offset = "0x2FEA700", VA = "0x182FEB500")]
	public static Task<TResult> NHGJBJCKFEF<TResult>(this NHJDNADPIAN<TResult> IPHCMLMIPHN, CancellationToken PLEKJLHDOLP, OCLBKIDKJDK OHJCPCKLPJE = OCLBKIDKJDK.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x15544F0", Offset = "0x15536F0", VA = "0x1815544F0")]
	public static TaskAwaiter LBFELGIGDIH(this OOPPNGPPPLE IPHCMLMIPHN)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA400", Offset = "0x2FE9600", VA = "0x182FEA400")]
	public static TaskAwaiter<TResult> LBFELGIGDIH<TResult>(this NHJDNADPIAN<TResult> IPHCMLMIPHN) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1554320", Offset = "0x1553520", VA = "0x181554320")]
	public static OOPPNGPPPLE ELNFODFCGFG(this Task ONPFLGLLMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA0E0", Offset = "0x2FE92E0", VA = "0x182FEA0E0")]
	public static NHJDNADPIAN<TResult> ELNFODFCGFG<TResult>(this Task<TResult> ONPFLGLLMLP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1554AB0", Offset = "0x1553CB0", VA = "0x181554AB0")]
	private static string NNFNFKFGEGB(Task ONPFLGLLMLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MMEJLKMBIHL : OOPPNGPPPLE, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KHMGCEPBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KCIFHALNMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFPEABENKGO();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMEJLKMBIHL EHCHAKBBEBI(Action DPHNIJBIDDO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface DADEODBJPBG<T> : NHJDNADPIAN<T>, OOPPNGPPPLE, IEnumerator, MMEJLKMBIHL
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new DADEODBJPBG<T> EHCHAKBBEBI(Action DPHNIJBIDDO);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PIFHNGBGPBL : DAFGDOMLDFF, MMEJLKMBIHL, OOPPNGPPPLE, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> DPHNIJBIDDO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static MMEJLKMBIHL MICCLBNPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1555050", Offset = "0x1554250", VA = "0x181555050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool KHMGCEPBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x980020", Offset = "0x97F220", VA = "0x180980020", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x980010", Offset = "0x97F210", VA = "0x180980010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KCIFHALNMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1555460", Offset = "0x1554660", VA = "0x181555460", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1555470", Offset = "0x1554670", VA = "0x181555470")]
	static PIFHNGBGPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0820", Offset = "0x2B9FA20", VA = "0x182BA0820")]
	public new static DADEODBJPBG<T> DOENFLFFJFD<T>(T GAFKIBJKPNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0820", Offset = "0x2B9FA20", VA = "0x182BA0820")]
	public new static DADEODBJPBG<T> BAPLAIJPOAK<T>(string KLEKJFJOCHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1555130", Offset = "0x1554330", VA = "0x181555130", Slot = "21")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x15550B0", Offset = "0x15542B0", VA = "0x1815550B0", Slot = "22")]
	public MMEJLKMBIHL EHCHAKBBEBI(Action DBNAOEMIJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1555380", Offset = "0x1554580", VA = "0x181555380", Slot = "18")]
	protected override void NIIPNANCJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x15553D0", Offset = "0x15545D0", VA = "0x1815553D0", Slot = "17")]
	public override OOPPNGPPPLE ONPNCEEDGCM(Action LBMGIKCJOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x15555A0", Offset = "0x15547A0", VA = "0x1815555A0")]
	public PIFHNGBGPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EB30", Offset = "0x7DF30")]
public class DGFOKPNODCA<T> : JFMAKJPJKJA<T>, DADEODBJPBG<T>, NHJDNADPIAN<T>, OOPPNGPPPLE, IEnumerator, MMEJLKMBIHL where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> DPHNIJBIDDO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KHMGCEPBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA0D920", Offset = "0xA0CB20", VA = "0x180A0D920", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA0D8F0", Offset = "0xA0CAF0", VA = "0x180A0D8F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KCIFHALNMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4372430", Offset = "0x4371630", VA = "0x184372430", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4371CA0", Offset = "0x4370EA0", VA = "0x184371CA0", Slot = "30")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4371BF0", Offset = "0x4370DF0", VA = "0x184371BF0", Slot = "27")]
	public DADEODBJPBG<T> EHCHAKBBEBI(Action DBNAOEMIJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A27D60", Offset = "0x3A26F60", VA = "0x183A27D60", Slot = "31")]
	private MMEJLKMBIHL BGLEBPHIKAM(Action DBNAOEMIJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x43722C0", Offset = "0x43714C0", VA = "0x1843722C0", Slot = "26")]
	protected override void NIIPNANCJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x43723A0", Offset = "0x43715A0", VA = "0x1843723A0", Slot = "25")]
	public override NHJDNADPIAN<T> ONPNCEEDGCM(Action LBMGIKCJOFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4372550", Offset = "0x4371750", VA = "0x184372550")]
	public DGFOKPNODCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class MINFELCCDEK : LLOMBPKEBMA, MMEJLKMBIHL, OOPPNGPPPLE, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> DPHNIJBIDDO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KHMGCEPBJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x983EC0", Offset = "0x9830C0", VA = "0x180983EC0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x983B10", Offset = "0x982D10", VA = "0x180983B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KCIFHALNMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1553F20", Offset = "0x1553120", VA = "0x181553F20", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x15541F0", Offset = "0x15533F0", VA = "0x1815541F0")]
	public MINFELCCDEK(MMEJLKMBIHL IPHCMLMIPHN, MMEJLKMBIHL IHJPCEDPDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1553F30", Offset = "0x1553130", VA = "0x181553F30")]
	public MINFELCCDEK(IList<MMEJLKMBIHL> KFPONPMKGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1553A40", Offset = "0x1552C40", VA = "0x181553A40", Slot = "21")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x15539C0", Offset = "0x1552BC0", VA = "0x1815539C0", Slot = "22")]
	public MMEJLKMBIHL EHCHAKBBEBI(Action DBNAOEMIJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1553E40", Offset = "0x1553040", VA = "0x181553E40", Slot = "18")]
	protected override void NIIPNANCJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1553E90", Offset = "0x1553090", VA = "0x181553E90", Slot = "17")]
	public override OOPPNGPPPLE ONPNCEEDGCM(Action LBMGIKCJOFM)
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
