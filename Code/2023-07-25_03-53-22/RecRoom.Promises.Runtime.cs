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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x728A640", Offset = "0x7289640", VA = "0x18728A640")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JMLAIMKMOJB : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string MEMGCECNBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7289540", Offset = "0x7288540", VA = "0x187289540")]
	public JMLAIMKMOJB(string HJJLMCEMDKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A0C0", Offset = "0x7594C0")]
public class CEKHHPFIFOJ<T1, T2> : FPHCELGDGAI<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NLENAGHCKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A130", Offset = "0x759530")]
		public IBHBGBJGJHP<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CEKHHPFIFOJ<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public NLENAGHCKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A72520", Offset = "0x2A71520", VA = "0x182A72520")]
		internal void CKJNPEBKMCD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BKCCPHHHDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NLENAGHCKLC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public BKCCPHHHDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x23BCF40", Offset = "0x23BBF40", VA = "0x1823BCF40")]
		internal void MJJEDNNJMFO(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E39970", Offset = "0x2E38970", VA = "0x182E39970")]
	public CEKHHPFIFOJ(IBHBGBJGJHP<T1> NGNBDDJEINN, IBHBGBJGJHP<T2> GGFKLJIEDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E38EE0", Offset = "0x2E37EE0", VA = "0x182E38EE0")]
	private void OOMODAOAEGP(string AOLOOCNDGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A1B0", Offset = "0x7595B0")]
public class GLCMHDHIIOP<T1, T2, T3> : FPHCELGDGAI<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GNAFNOJECDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A220", Offset = "0x759620")]
		public IBHBGBJGJHP<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A280", Offset = "0x759680")]
		public IBHBGBJGJHP<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public GLCMHDHIIOP<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public GNAFNOJECDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2A723F0", Offset = "0x2A713F0", VA = "0x182A723F0")]
		internal void CKJNPEBKMCD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HIJPLGHCNLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GNAFNOJECDG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HIJPLGHCNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2843E90", Offset = "0x2842E90", VA = "0x182843E90")]
		internal void MJJEDNNJMFO(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HBLAHPMMLPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HIJPLGHCNLE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HBLAHPMMLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x202FD90", Offset = "0x202ED90", VA = "0x18202FD90")]
		internal void ADLILJDDLPK(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AC90", Offset = "0x2A49C90", VA = "0x182A4AC90")]
	public GLCMHDHIIOP(IBHBGBJGJHP<T1> NGNBDDJEINN, IBHBGBJGJHP<T2> GGFKLJIEDPB, IBHBGBJGJHP<T3> DPPBDNBGCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4A940", Offset = "0x2A49940", VA = "0x182A4A940")]
	private void OOMODAOAEGP(string AOLOOCNDGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A2E0", Offset = "0x7596E0")]
public class JPAJELGIIEH<T1, T2, T3, T4, T5> : FPHCELGDGAI<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EAAGKAMPEKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A350", Offset = "0x759750")]
		public IBHBGBJGJHP<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A3B0", Offset = "0x7597B0")]
		public IBHBGBJGJHP<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A410", Offset = "0x759810")]
		public IBHBGBJGJHP<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A470", Offset = "0x759870")]
		public IBHBGBJGJHP<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JPAJELGIIEH<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EAAGKAMPEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2A723F0", Offset = "0x2A713F0", VA = "0x182A723F0")]
		internal void CKJNPEBKMCD(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class EBLANACJEKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public EAAGKAMPEKK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EBLANACJEKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2843E90", Offset = "0x2842E90", VA = "0x182843E90")]
		internal void MJJEDNNJMFO(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PBLBGFLBPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public EBLANACJEKE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public PBLBGFLBPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A88C10", Offset = "0x2A87C10", VA = "0x182A88C10")]
		internal void ADLILJDDLPK(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class HMKLNJJNGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PBLBGFLBPME CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HMKLNJJNGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E550", Offset = "0x2D8D550", VA = "0x182D8E550")]
		internal void JNODJANFIGN(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FBICFMKOKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HMKLNJJNGPL CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FBICFMKOKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1696500", Offset = "0x1695500", VA = "0x181696500")]
		internal void OLLNDOLJDDJ(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E052F0", Offset = "0x2E042F0", VA = "0x182E052F0")]
	public JPAJELGIIEH(IBHBGBJGJHP<T1> NGNBDDJEINN, IBHBGBJGJHP<T2> GGFKLJIEDPB, IBHBGBJGJHP<T3> DPPBDNBGCBA, IBHBGBJGJHP<T4> MODIJMEKKKK, IBHBGBJGJHP<T5> JNALMDIDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E05280", Offset = "0x2E04280", VA = "0x182E05280")]
	private void OOMODAOAEGP(string AOLOOCNDGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A4D0", Offset = "0x7598D0")]
public class KAOILEIKKOD<T> : FPHCELGDGAI<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FPNNIOCFBEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KAOILEIKKOD<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FPNNIOCFBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x31B9D90", Offset = "0x31B8D90", VA = "0x1831B9D90")]
		internal void CKJNPEBKMCD(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A540", Offset = "0x759940")]
	private readonly T[] OIEJLHFEGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int AMCNPDHOMHF;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2AA40F0", Offset = "0x2AA30F0", VA = "0x182AA40F0")]
	public KAOILEIKKOD(List<IBHBGBJGJHP<T>> NCCILFPCGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3100", Offset = "0x2AA2100", VA = "0x182AA3100")]
	private void OOMODAOAEGP(string AOLOOCNDGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BDAFCFJMLAD : NHFPGJIFDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int AFFAKNEPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<GAEMIFNLIHB> NCCILFPCGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> CIPCHGAEGKM;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7287D60", Offset = "0x7286D60", VA = "0x187287D60")]
	public BDAFCFJMLAD(params GAEMIFNLIHB[] NCCILFPCGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7287960", Offset = "0x7286960", VA = "0x187287960")]
	public BDAFCFJMLAD(IReadOnlyList<GAEMIFNLIHB> NCCILFPCGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7287900", Offset = "0x7286900", VA = "0x187287900")]
	private void NPEFHONLMJE(string OKJPHFLFJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7287870", Offset = "0x7286870", VA = "0x187287870")]
	private void CALJEBNJPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JDJJNPPFHBH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string DPAAGKFGFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3434C10", Offset = "0x3433C10", VA = "0x183434C10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7289450", Offset = "0x7288450", VA = "0x187289450")]
	public JDJJNPPFHBH(Exception MPKLHKDLKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72893C0", Offset = "0x72883C0", VA = "0x1872893C0")]
	private static string ODMOLFCILMG(Exception MPKLHKDLKCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NHFPGJIFDOB : GAEMIFNLIHB, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LHDEPJGIECC<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A6C0", Offset = "0x759AC0")]
		public Func<string, IBHBGBJGJHP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A720", Offset = "0x759B20")]
		public Func<IBHBGBJGJHP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A780", Offset = "0x759B80")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A7E0", Offset = "0x759BE0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public LHDEPJGIECC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x26913D0", Offset = "0x26903D0", VA = "0x1826913D0")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void GCDCPPCOMNJ(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2691B90", Offset = "0x2690B90", VA = "0x182691B90")]
		internal void GODPLFNGLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void KCPCMMOPCFH(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EDACMFPAJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A840", Offset = "0x759C40")]
		public Func<string, GAEMIFNLIHB> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NHFPGJIFDOB newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A8A0", Offset = "0x759CA0")]
		public Func<GAEMIFNLIHB> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A900", Offset = "0x759D00")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A960", Offset = "0x759D60")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public EDACMFPAJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7288080", Offset = "0x7287080", VA = "0x187288080")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void GCDCPPCOMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7288210", Offset = "0x7287210", VA = "0x187288210")]
		internal void GODPLFNGLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void KCPCMMOPCFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NIFGPFMLJGM<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public NIFGPFMLJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x12E4890", Offset = "0x12E3890", VA = "0x1812E4890")]
		internal void EKMOMMGHKAM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2436C80", Offset = "0x2435C80", VA = "0x182436C80")]
		internal void KEHJDFGPAHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GHHOBPNHIGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NHFPGJIFDOB newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A9C0", Offset = "0x759DC0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public GHHOBPNHIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7288380", Offset = "0x7287380", VA = "0x187288380")]
		internal void CKOJJOKNBGD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA8A3E0", Offset = "0xA893E0", VA = "0x180A8A3E0")]
		internal void DGJGIKPAKFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string JFCCKEDAFKH = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> IAOKAGNBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> NGGLMEGHCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> INGAFOPNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? AOLOOCNDGPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GAEMIFNLIHB AJMODECMFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7289A30", Offset = "0x7288A30", VA = "0x187289A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90AAA0", Offset = "0x909AA0", VA = "0x18090AAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HHEDHIJFAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x728A020", Offset = "0x7289020", VA = "0x18728A020", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AIFFKBFICBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7289EC0", Offset = "0x7288EC0", VA = "0x187289EC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x728A4D0", Offset = "0x72894D0", VA = "0x18728A4D0")]
	static NHFPGJIFDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1073900", Offset = "0x1072900", VA = "0x181073900")]
	public static IBHBGBJGJHP<T> FGKJOEHGCJM<T>(T ALIHEMGMHCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72899C0", Offset = "0x72889C0", VA = "0x1872899C0")]
	public static GAEMIFNLIHB EMCMCMNKLCI(string AOLOOCNDGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1073900", Offset = "0x1072900", VA = "0x181073900")]
	public static IBHBGBJGJHP<T> EMCMCMNKLCI<T>(string AOLOOCNDGPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x728A040", Offset = "0x7289040", VA = "0x18728A040", Slot = "8")]
	public GAEMIFNLIHB JLFNKOBPLIN(Action<string> PLCJFBIJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x728A450", Offset = "0x7289450", VA = "0x18728A450", Slot = "17")]
	public virtual GAEMIFNLIHB OFJCBLABANL(Action KAKEJCBKCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x728A3C0", Offset = "0x72893C0", VA = "0x18728A3C0", Slot = "7")]
	public GAEMIFNLIHB OEMEHKALOLF(Action ICIEOJDIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x251E900", Offset = "0x251D900", VA = "0x18251E900", Slot = "10")]
	public IBHBGBJGJHP<TNew> GLBGOPEEGMH<TNew>(Func<IBHBGBJGJHP<TNew>> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A600", Offset = "0x759A00")] Func<string, IBHBGBJGJHP<TNew>> MNLMBPHBFKB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7289A90", Offset = "0x7288A90", VA = "0x187289A90", Slot = "11")]
	public GAEMIFNLIHB GLBGOPEEGMH(Func<GAEMIFNLIHB> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75A660", Offset = "0x759A60")] Func<string, GAEMIFNLIHB> MNLMBPHBFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x251D550", Offset = "0x251C550", VA = "0x18251D550", Slot = "12")]
	public IBHBGBJGJHP<TNew> CBKKOJLNDGO<TNew>(Func<TNew> BOLPGDNMKOL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7289CB0", Offset = "0x7288CB0", VA = "0x187289CB0", Slot = "13")]
	public GAEMIFNLIHB GOPAPGGBAAI(Func<string, string> BOLPGDNMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E241B0", Offset = "0x5E231B0", VA = "0x185E241B0", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7289770", Offset = "0x7288770", VA = "0x187289770")]
	public void DGCOAPBJKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x728A0E0", Offset = "0x72890E0", VA = "0x18728A0E0")]
	public void JLFNKOBPLIN(string HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7289EE0", Offset = "0x7288EE0", VA = "0x187289EE0")]
	protected Exception? IBGPMKBLDFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72896F0", Offset = "0x72886F0", VA = "0x1872896F0", Slot = "18")]
	protected virtual void CHMLEACBKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x728A540", Offset = "0x7289540", VA = "0x18728A540")]
	public NHFPGJIFDOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FPHCELGDGAI<T> : IBHBGBJGJHP<T>, GAEMIFNLIHB, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct JDMLFODCLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AC00", Offset = "0x75A000")]
		public readonly Action<T> OKCPFPFJOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? MOEHDLIIIKL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xCA1FE0", Offset = "0xCA0FE0", VA = "0x180CA1FE0")]
		public JDMLFODCLLC(Action<T> OKCPFPFJOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xCA2590", Offset = "0xCA1590", VA = "0x180CA2590")]
		public JDMLFODCLLC(Action MOEHDLIIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x243FB50", Offset = "0x243EB50", VA = "0x18243FB50")]
		public void KAEAMPPMANC(T EMBONFDCNJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HHABPLLIPFN<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AC60", Offset = "0x75A060")]
		public Func<string, IBHBGBJGJHP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75ACC0", Offset = "0x75A0C0")]
		public Func<IBHBGBJGJHP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AD20", Offset = "0x75A120")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AD80", Offset = "0x75A180")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HHABPLLIPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x367CA00", Offset = "0x367BA00", VA = "0x18367CA00")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void GCDCPPCOMNJ(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3684530", Offset = "0x3683530", VA = "0x183684530")]
		internal void GODPLFNGLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void KCPCMMOPCFH(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IALHEDIHLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75ADE0", Offset = "0x75A1E0")]
		public Func<string, GAEMIFNLIHB> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NHFPGJIFDOB newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AE40", Offset = "0x75A240")]
		public Func<GAEMIFNLIHB> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AEA0", Offset = "0x75A2A0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AF00", Offset = "0x75A300")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public IALHEDIHLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC4280", Offset = "0x5DC3280", VA = "0x185DC4280")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void GCDCPPCOMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5DC6560", Offset = "0x5DC5560", VA = "0x185DC6560")]
		internal void GODPLFNGLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void KCPCMMOPCFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GKOCLPJAEPI<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AF60", Offset = "0x75A360")]
		public Func<string, IBHBGBJGJHP<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AFC0", Offset = "0x75A3C0")]
		public Func<T, IBHBGBJGJHP<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B020", Offset = "0x75A420")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B080", Offset = "0x75A480")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public GKOCLPJAEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2A45F90", Offset = "0x2A44F90", VA = "0x182A45F90")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void GCDCPPCOMNJ(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2A48210", Offset = "0x2A47210", VA = "0x182A48210")]
		internal void GODPLFNGLPN(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2691650", Offset = "0x2690650", VA = "0x182691650")]
		internal void KCPCMMOPCFH(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FNBFEJLANFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B0E0", Offset = "0x75A4E0")]
		public Func<string, GAEMIFNLIHB> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NHFPGJIFDOB newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B140", Offset = "0x75A540")]
		public Func<T, GAEMIFNLIHB> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B1A0", Offset = "0x75A5A0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B200", Offset = "0x75A600")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FNBFEJLANFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x32C8620", Offset = "0x32C7620", VA = "0x1832C8620")]
		internal void GBFDBNIOFBL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void CCJIPJAFDGP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void GCDCPPCOMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x32CBFC0", Offset = "0x32CAFC0", VA = "0x1832CBFC0")]
		internal void GODPLFNGLPN(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x14509A0", Offset = "0x144F9A0", VA = "0x1814509A0")]
		internal void HDLBPDHGMLP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xE658A0", Offset = "0xE648A0", VA = "0x180E658A0")]
		internal void KCPCMMOPCFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FGILBONPODB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FGILBONPODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12E4890", Offset = "0x12E3890", VA = "0x1812E4890")]
		internal void EKMOMMGHKAM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2436C80", Offset = "0x2435C80", VA = "0x182436C80")]
		internal void KEHJDFGPAHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GMHJOGINIFI<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FPHCELGDGAI<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B260", Offset = "0x75A660")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public GMHJOGINIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x12E4890", Offset = "0x12E3890", VA = "0x1812E4890")]
		internal void EKMOMMGHKAM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x322EC00", Offset = "0x322DC00", VA = "0x18322EC00")]
		internal void KEHJDFGPAHP(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KHCGHPBBHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NHFPGJIFDOB newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B2C0", Offset = "0x75A6C0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public KHCGHPBBHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3542410", Offset = "0x3541410", VA = "0x183542410")]
		internal void JLFIICMFEHO(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A3E0", Offset = "0xA893E0", VA = "0x180A8A3E0")]
		internal void MAMCOPPLLAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FNIBNMDMDDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B320", Offset = "0x75A720")]
		public FPHCELGDGAI<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B380", Offset = "0x75A780")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FNIBNMDMDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x32D04A0", Offset = "0x32CF4A0", VA = "0x1832D04A0")]
		internal void CKOJJOKNBGD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x32D1270", Offset = "0x32D0270", VA = "0x1832D1270")]
		internal void DGJGIKPAKFL(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AA20", Offset = "0x759E20")]
	private readonly List<FPHCELGDGAI<T>.JDMLFODCLLC> INGAFOPNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> IAOKAGNBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> NGGLMEGHCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? AOLOOCNDGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T ALIHEMGMHCE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC7B250", Offset = "0xC7A250", VA = "0x180C7B250", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF9A560", Offset = "0xF99560", VA = "0x180F9A560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HHEDHIJFAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x31B55C0", Offset = "0x31B45C0", VA = "0x1831B55C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool AIFFKBFICBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31B43C0", Offset = "0x31B33C0", VA = "0x1831B43C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x31B0B00", Offset = "0x31AFB00", VA = "0x1831B0B00")]
	public static IBHBGBJGJHP<T> EMCMCMNKLCI(string HJJLMCEMDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4938120", Offset = "0x4937120", VA = "0x184938120", Slot = "6")]
	public IBHBGBJGJHP<T> JLFNKOBPLIN(Action<string> PLCJFBIJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4938E40", Offset = "0x4937E40", VA = "0x184938E40", Slot = "25")]
	public virtual IBHBGBJGJHP<T> OFJCBLABANL(Action KAKEJCBKCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31B81D0", Offset = "0x31B71D0", VA = "0x1831B81D0", Slot = "5")]
	public IBHBGBJGJHP<T> OEMEHKALOLF(Action ICIEOJDIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31B82A0", Offset = "0x31B72A0", VA = "0x1831B82A0", Slot = "4")]
	public IBHBGBJGJHP<T> OEMEHKALOLF(Action<T> ICIEOJDIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F640", Offset = "0x2C1E640", VA = "0x182C1F640", Slot = "18")]
	public IBHBGBJGJHP<TNew> GLBGOPEEGMH<TNew>(Func<IBHBGBJGJHP<TNew>> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AA80", Offset = "0x759E80")] Func<string, IBHBGBJGJHP<TNew>> MNLMBPHBFKB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x49370B0", Offset = "0x49360B0", VA = "0x1849370B0", Slot = "19")]
	public GAEMIFNLIHB GLBGOPEEGMH(Func<GAEMIFNLIHB> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AAE0", Offset = "0x759EE0")] Func<string, GAEMIFNLIHB> MNLMBPHBFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B880A0", Offset = "0x2B870A0", VA = "0x182B880A0", Slot = "8")]
	public IBHBGBJGJHP<TNew> GLBGOPEEGMH<TNew>(Func<T, IBHBGBJGJHP<TNew>> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75AB40", Offset = "0x759F40")] Func<string, IBHBGBJGJHP<TNew>> MNLMBPHBFKB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4936D10", Offset = "0x4935D10", VA = "0x184936D10", Slot = "9")]
	public GAEMIFNLIHB GLBGOPEEGMH(Func<T, GAEMIFNLIHB> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75ABA0", Offset = "0x759FA0")] Func<string, GAEMIFNLIHB> MNLMBPHBFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C0B800", Offset = "0x2C0A800", VA = "0x182C0B800", Slot = "20")]
	public IBHBGBJGJHP<TNew> CBKKOJLNDGO<TNew>(Func<TNew> BOLPGDNMKOL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B735A0", Offset = "0x2B725A0", VA = "0x182B735A0", Slot = "10")]
	public IBHBGBJGJHP<TNew> CBKKOJLNDGO<TNew>(Func<T, TNew> BOLPGDNMKOL) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4935BA0", Offset = "0x4934BA0", VA = "0x184935BA0", Slot = "21")]
	private GAEMIFNLIHB ACEINHFPOMF(Func<string, string> BOLPGDNMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x49379F0", Offset = "0x49369F0", VA = "0x1849379F0", Slot = "11")]
	public IBHBGBJGJHP<T> GOPAPGGBAAI(Func<string, string> BOLPGDNMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31B8C40", Offset = "0x31B7C40", VA = "0x1831B8C40", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x244EEC0", Offset = "0x244DEC0", VA = "0x18244EEC0", Slot = "15")]
	private GAEMIFNLIHB BPNIGGADHOD(Action ICIEOJDIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x244E6B0", Offset = "0x244D6B0", VA = "0x18244E6B0", Slot = "16")]
	private GAEMIFNLIHB MMGJJDMMDNA(Action<string> PLCJFBIJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x31B5590", Offset = "0x31B4590", VA = "0x1831B5590", Slot = "17")]
	private GAEMIFNLIHB JBNIJAHHADJ(Action KAKEJCBKCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4936470", Offset = "0x4935470", VA = "0x184936470")]
	public void DGCOAPBJKNO(T EMBONFDCNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4937DA0", Offset = "0x4936DA0", VA = "0x184937DA0")]
	protected Exception? IBGPMKBLDFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4938700", Offset = "0x4937700", VA = "0x184938700")]
	public void JLFNKOBPLIN(string HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4936060", Offset = "0x4935060", VA = "0x184936060", Slot = "26")]
	protected virtual void CHMLEACBKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x49391A0", Offset = "0x49381A0", VA = "0x1849391A0")]
	public FPHCELGDGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GAEMIFNLIHB : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HHEDHIJFAGD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AIFFKBFICBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GAEMIFNLIHB OEMEHKALOLF(Action ICIEOJDIPKB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GAEMIFNLIHB JLFNKOBPLIN(Action<string> PLCJFBIJAFL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GAEMIFNLIHB OFJCBLABANL(Action KAKEJCBKCHF);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBHBGBJGJHP<TNew> GLBGOPEEGMH<TNew>(Func<IBHBGBJGJHP<TNew>> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B3E0", Offset = "0x75A7E0")] Func<string, IBHBGBJGJHP<TNew>> MNLMBPHBFKB) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GAEMIFNLIHB GLBGOPEEGMH(Func<GAEMIFNLIHB> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B440", Offset = "0x75A840")] Func<string, GAEMIFNLIHB> MNLMBPHBFKB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IBHBGBJGJHP<TNew> CBKKOJLNDGO<TNew>(Func<TNew> BOLPGDNMKOL) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GAEMIFNLIHB GOPAPGGBAAI(Func<string, string> BOLPGDNMKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IBHBGBJGJHP<out T> : GAEMIFNLIHB, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBHBGBJGJHP<T> OEMEHKALOLF(Action<T> ICIEOJDIPKB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new IBHBGBJGJHP<T> OEMEHKALOLF(Action ICIEOJDIPKB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new IBHBGBJGJHP<T> JLFNKOBPLIN(Action<string> PLCJFBIJAFL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new IBHBGBJGJHP<T> OFJCBLABANL(Action KAKEJCBKCHF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IBHBGBJGJHP<TNew> GLBGOPEEGMH<TNew>(Func<T, IBHBGBJGJHP<TNew>> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B4A0", Offset = "0x75A8A0")] Func<string, IBHBGBJGJHP<TNew>> MNLMBPHBFKB) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GAEMIFNLIHB GLBGOPEEGMH(Func<T, GAEMIFNLIHB> BOLPGDNMKOL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B500", Offset = "0x75A900")] Func<string, GAEMIFNLIHB> MNLMBPHBFKB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBHBGBJGJHP<TNew> CBKKOJLNDGO<TNew>(Func<T, TNew> BOLPGDNMKOL) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new IBHBGBJGJHP<T> GOPAPGGBAAI(Func<string, string> BOLPGDNMKOL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OCNHINBNIGA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum IHJABGOAEDD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class IKMGKOBGJIL : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7289350", Offset = "0x7288350", VA = "0x187289350")]
		public IKMGKOBGJIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NEKLAGEOFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NEKLAGEOFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7289610", Offset = "0x7288610", VA = "0x187289610")]
		internal void JANKDHIFAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7289660", Offset = "0x7288660", VA = "0x187289660")]
		internal void NHFCFLFKNNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72895C0", Offset = "0x72885C0", VA = "0x1872895C0")]
		internal void BEGNCLHKGHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DGIHAPGONFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public BEKPINHCBFC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public IHJABGOAEDD unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DGIHAPGONFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7287FA0", Offset = "0x7286FA0", VA = "0x187287FA0")]
		internal void JANKDHIFAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7287FF0", Offset = "0x7286FF0", VA = "0x187287FF0")]
		internal void NHFCFLFKNNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7287F00", Offset = "0x7286F00", VA = "0x187287F00")]
		internal void BEGNCLHKGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7287D70", Offset = "0x7286D70", VA = "0x187287D70")]
		internal void AHFPCGFCMBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BJGNNDADELA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BJGNNDADELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2976F30", Offset = "0x2975F30", VA = "0x182976F30")]
		internal void LAKPMOOBCDD(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HEFBGHOAAEP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HEFBGHOAAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x12E48C0", Offset = "0x12E38C0", VA = "0x1812E48C0")]
		internal void JANKDHIFAAH(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x203E400", Offset = "0x203D400", VA = "0x18203E400")]
		internal void NHFCFLFKNNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x12E4230", Offset = "0x12E3230", VA = "0x1812E4230")]
		internal void BEGNCLHKGHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GJPCCKGDOMI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BEKPINHCBFC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IHJABGOAEDD unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public GJPCCKGDOMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D2D0", Offset = "0x2A3C2D0", VA = "0x182A3D2D0")]
		internal void JANKDHIFAAH(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D330", Offset = "0x2A3C330", VA = "0x182A3D330")]
		internal void NHFCFLFKNNP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D190", Offset = "0x2A3C190", VA = "0x182A3D190")]
		internal void BEGNCLHKGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D060", Offset = "0x2A3C060", VA = "0x182A3D060")]
		internal void AHFPCGFCMBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NBCALPOAMJK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public NBCALPOAMJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2976F30", Offset = "0x2975F30", VA = "0x182976F30")]
		internal void LAKPMOOBCDD(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OOABKGDANJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NHFPGJIFDOB promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OOABKGDANJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x728B030", Offset = "0x728A030", VA = "0x18728B030")]
		internal void CGHKHCIFBHJ(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FHMGCNJCKBG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FPHCELGDGAI<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FHMGCNJCKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2FB21B0", Offset = "0x2FB11B0", VA = "0x182FB21B0")]
		internal void CGHKHCIFBHJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B5A0", Offset = "0x75A9A0")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x728AE20", Offset = "0x7289E20", VA = "0x18728AE20")]
	public static Task PCJBJPJPPDJ(this GAEMIFNLIHB LNFEMDDJPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x728AAA0", Offset = "0x7289AA0", VA = "0x18728AAA0")]
	public static Task<bool> PCJBJPJPPDJ(this GAEMIFNLIHB LNFEMDDJPIK, CancellationToken OAGBBBCDIGC, IHJABGOAEDD HBFKFLMJHND = IHJABGOAEDD.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E18FE0", Offset = "0x2E17FE0", VA = "0x182E18FE0")]
	public static Task<TResult> PCJBJPJPPDJ<TResult>(this IBHBGBJGJHP<TResult> LNFEMDDJPIK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E18BF0", Offset = "0x2E17BF0", VA = "0x182E18BF0")]
	public static Task<TResult> PCJBJPJPPDJ<TResult>(this IBHBGBJGJHP<TResult> LNFEMDDJPIK, CancellationToken OAGBBBCDIGC, IHJABGOAEDD HBFKFLMJHND = IHJABGOAEDD.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x728A8A0", Offset = "0x72898A0", VA = "0x18728A8A0")]
	public static TaskAwaiter KCKHOOIGOBL(this GAEMIFNLIHB LNFEMDDJPIK)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E16D80", Offset = "0x2E15D80", VA = "0x182E16D80")]
	public static TaskAwaiter<TResult> KCKHOOIGOBL<TResult>(this IBHBGBJGJHP<TResult> LNFEMDDJPIK) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x728A8D0", Offset = "0x72898D0", VA = "0x18728A8D0")]
	public static GAEMIFNLIHB NOPNPAOCDAO(this Task IJOJNMAHKLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2E17A40", Offset = "0x2E16A40", VA = "0x182E17A40")]
	public static IBHBGBJGJHP<TResult> NOPNPAOCDAO<TResult>(this Task<TResult> IJOJNMAHKLB) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x728A6D0", Offset = "0x72896D0", VA = "0x18728A6D0")]
	private static string IGEFKCILMDP(Task IJOJNMAHKLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BEKPINHCBFC : GAEMIFNLIHB, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NFDHNCDEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GLLANCEELHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKHNCGFKDLF();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BEKPINHCBFC CLHBGBHNGED(Action OFNNBJBLNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ELJHPGFEACM<T> : IBHBGBJGJHP<T>, GAEMIFNLIHB, IEnumerator, BEKPINHCBFC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new ELJHPGFEACM<T> CLHBGBHNGED(Action OFNNBJBLNPH);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HHBNBDMPFEC : NHFPGJIFDOB, BEKPINHCBFC, GAEMIFNLIHB, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> OFNNBJBLNPH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static BEKPINHCBFC DIAANFAEGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x72887C0", Offset = "0x72877C0", VA = "0x1872887C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NFDHNCDEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xC7B250", Offset = "0xC7A250", VA = "0x180C7B250", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xF9A560", Offset = "0xF99560", VA = "0x180F9A560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GLLANCEELHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7288400", Offset = "0x7287400", VA = "0x187288400", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7288820", Offset = "0x7287820", VA = "0x187288820")]
	static HHBNBDMPFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1073900", Offset = "0x1072900", VA = "0x181073900")]
	public new static ELJHPGFEACM<T> FGKJOEHGCJM<T>(T ALIHEMGMHCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1073900", Offset = "0x1072900", VA = "0x181073900")]
	public new static ELJHPGFEACM<T> EMCMCMNKLCI<T>(string AOLOOCNDGPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72884E0", Offset = "0x72874E0", VA = "0x1872884E0", Slot = "21")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7288460", Offset = "0x7287460", VA = "0x187288460", Slot = "22")]
	public BEKPINHCBFC CLHBGBHNGED(Action BLOMLFLKLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7288410", Offset = "0x7287410", VA = "0x187288410", Slot = "18")]
	protected override void CHMLEACBKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7288730", Offset = "0x7287730", VA = "0x187288730", Slot = "17")]
	public override GAEMIFNLIHB OFJCBLABANL(Action KAKEJCBKCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7288950", Offset = "0x7287950", VA = "0x187288950")]
	public HHBNBDMPFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x75B600", Offset = "0x75AA00")]
public class OPDFLKPCJBB<T> : FPHCELGDGAI<T>, ELJHPGFEACM<T>, IBHBGBJGJHP<T>, GAEMIFNLIHB, IEnumerator, BEKPINHCBFC where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> OFNNBJBLNPH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NFDHNCDEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x915880", Offset = "0x914880", VA = "0x180915880", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x915210", Offset = "0x914210", VA = "0x180915210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GLLANCEELHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3089430", Offset = "0x3088430", VA = "0x183089430", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x30899F0", Offset = "0x30889F0", VA = "0x1830899F0", Slot = "30")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3089630", Offset = "0x3088630", VA = "0x183089630", Slot = "27")]
	public ELJHPGFEACM<T> CLHBGBHNGED(Action BLOMLFLKLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x203BC10", Offset = "0x203AC10", VA = "0x18203BC10", Slot = "31")]
	private BEKPINHCBFC NNILHDIFMME(Action BLOMLFLKLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3089510", Offset = "0x3088510", VA = "0x183089510", Slot = "26")]
	protected override void CHMLEACBKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3089D00", Offset = "0x3088D00", VA = "0x183089D00", Slot = "25")]
	public override IBHBGBJGJHP<T> OFJCBLABANL(Action KAKEJCBKCHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3089E40", Offset = "0x3088E40", VA = "0x183089E40")]
	public OPDFLKPCJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HLBKDDLHDPG : BDAFCFJMLAD, BEKPINHCBFC, GAEMIFNLIHB, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> OFNNBJBLNPH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NFDHNCDEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x870740", Offset = "0x86F740", VA = "0x180870740", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xFC0D40", Offset = "0xFBFD40", VA = "0x180FC0D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GLLANCEELHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7288A00", Offset = "0x7287A00", VA = "0x187288A00", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7288F70", Offset = "0x7287F70", VA = "0x187288F70")]
	public HLBKDDLHDPG(BEKPINHCBFC LNFEMDDJPIK, BEKPINHCBFC GEOBHJLIKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7289090", Offset = "0x7288090", VA = "0x187289090")]
	public HLBKDDLHDPG(IList<BEKPINHCBFC> NCCILFPCGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7288AE0", Offset = "0x7287AE0", VA = "0x187288AE0", Slot = "21")]
	public void HKHNCGFKDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7288A60", Offset = "0x7287A60", VA = "0x187288A60", Slot = "22")]
	public BEKPINHCBFC CLHBGBHNGED(Action BLOMLFLKLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7288A10", Offset = "0x7287A10", VA = "0x187288A10", Slot = "18")]
	protected override void CHMLEACBKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7288EE0", Offset = "0x7287EE0", VA = "0x187288EE0", Slot = "17")]
	public override GAEMIFNLIHB OFJCBLABANL(Action KAKEJCBKCHF)
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
