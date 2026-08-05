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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA91E0", Offset = "0x6EA79E0", VA = "0x186EA91E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LPKBKCGKAHC : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string PCIOEJGKHBA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EA90F0", Offset = "0x6EA78F0", VA = "0x186EA90F0")]
	public LPKBKCGKAHC(string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCC50", Offset = "0x6DC050")]
public class DDJEJOMEBML<T1, T2> : NBKOKFNHPDK<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FFGFEENDNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCCC0", Offset = "0x6DC0C0")]
		public JJMNNLLBAJO<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public DDJEJOMEBML<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public FFGFEENDNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x348F3D0", Offset = "0x348DBD0", VA = "0x18348F3D0")]
		internal void DCAPKAENBHC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IMFCMNDCCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public FFGFEENDNBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public IMFCMNDCCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24AB820", Offset = "0x24AA020", VA = "0x1824AB820")]
		internal void AFBKOBLJPLD(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2409140", Offset = "0x2407940", VA = "0x182409140")]
	public DDJEJOMEBML(JJMNNLLBAJO<T1> KMKINFHLKDI, JJMNNLLBAJO<T2> EGMNGKOECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2408E70", Offset = "0x2407670", VA = "0x182408E70")]
	private void LGOEBHHDDLK(string OABOGFOJNOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCD40", Offset = "0x6DC140")]
public class HNPOMGHPDOM<T1, T2, T3> : NBKOKFNHPDK<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JIILDPFGKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCDB0", Offset = "0x6DC1B0")]
		public JJMNNLLBAJO<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCE10", Offset = "0x6DC210")]
		public JJMNNLLBAJO<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HNPOMGHPDOM<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public JIILDPFGKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2C54060", Offset = "0x2C52860", VA = "0x182C54060")]
		internal void DCAPKAENBHC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class ONOFDMLOKDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public JIILDPFGKMI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ONOFDMLOKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2E9FC40", Offset = "0x2E9E440", VA = "0x182E9FC40")]
		internal void AFBKOBLJPLD(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class ADPEANOHJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ONOFDMLOKDB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ADPEANOHJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x321C260", Offset = "0x321AA60", VA = "0x18321C260")]
		internal void HLKJEHOPEEL(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A31900", Offset = "0x3A30100", VA = "0x183A31900")]
	public HNPOMGHPDOM(JJMNNLLBAJO<T1> KMKINFHLKDI, JJMNNLLBAJO<T2> EGMNGKOECHF, JJMNNLLBAJO<T3> BNCFPBHNLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A315B0", Offset = "0x3A2FDB0", VA = "0x183A315B0")]
	private void LGOEBHHDDLK(string OABOGFOJNOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCE70", Offset = "0x6DC270")]
public class AAPKIDBEIJB<T1, T2, T3, T4, T5> : NBKOKFNHPDK<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MGHAIPAGLFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCEE0", Offset = "0x6DC2E0")]
		public JJMNNLLBAJO<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCF40", Offset = "0x6DC340")]
		public JJMNNLLBAJO<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DCFA0", Offset = "0x6DC3A0")]
		public JJMNNLLBAJO<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD000", Offset = "0x6DC400")]
		public JJMNNLLBAJO<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AAPKIDBEIJB<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public MGHAIPAGLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2114890", Offset = "0x2113090", VA = "0x182114890")]
		internal void DCAPKAENBHC(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OOEBJAEEMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MGHAIPAGLFB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OOEBJAEEMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2E9FDE0", Offset = "0x2E9E5E0", VA = "0x182E9FDE0")]
		internal void AFBKOBLJPLD(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PENBPHELLEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OOEBJAEEMHA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public PENBPHELLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21A77D0", Offset = "0x21A5FD0", VA = "0x1821A77D0")]
		internal void HLKJEHOPEEL(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NODECOFMEBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PENBPHELLEO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public NODECOFMEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x331D590", Offset = "0x331BD90", VA = "0x18331D590")]
		internal void IMCHFAGMHDL(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OLOEAFNLBPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NODECOFMEBA CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OLOEAFNLBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2E9F3F0", Offset = "0x2E9DBF0", VA = "0x182E9F3F0")]
		internal void OFLDHEBLBAN(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3551040", Offset = "0x354F840", VA = "0x183551040")]
	public AAPKIDBEIJB(JJMNNLLBAJO<T1> KMKINFHLKDI, JJMNNLLBAJO<T2> EGMNGKOECHF, JJMNNLLBAJO<T3> BNCFPBHNLLA, JJMNNLLBAJO<T4> PKBMPBAPKKN, JJMNNLLBAJO<T5> POIDPNAFOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3550FD0", Offset = "0x354F7D0", VA = "0x183550FD0")]
	private void LGOEBHHDDLK(string OABOGFOJNOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD060", Offset = "0x6DC460")]
public class KGILPOOHCOE<T> : NBKOKFNHPDK<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KFFEJLAHOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KGILPOOHCOE<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public KFFEJLAHOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x227AE80", Offset = "0x2279680", VA = "0x18227AE80")]
		internal void DCAPKAENBHC(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD0D0", Offset = "0x6DC4D0")]
	private readonly T[] AKEPPMJEBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FMPBBKNODHG;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x227CFC0", Offset = "0x227B7C0", VA = "0x18227CFC0")]
	public KGILPOOHCOE(List<JJMNNLLBAJO<T>> AFKMPCFNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x227BFD0", Offset = "0x227A7D0", VA = "0x18227BFD0")]
	private void LGOEBHHDDLK(string OABOGFOJNOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EOJGPNLOGDN : ACOJIJEEGAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int NNANHIDBOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<GHJKEMFHLHG> AFKMPCFNABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> BIELGLCOEMA;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EA74C0", Offset = "0x6EA5CC0", VA = "0x186EA74C0")]
	public EOJGPNLOGDN(params GHJKEMFHLHG[] AFKMPCFNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EA74D0", Offset = "0x6EA5CD0", VA = "0x186EA74D0")]
	public EOJGPNLOGDN(IReadOnlyList<GHJKEMFHLHG> AFKMPCFNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6EA73D0", Offset = "0x6EA5BD0", VA = "0x186EA73D0")]
	private void KCLIAPKOCHC(string INOBFBCOAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7430", Offset = "0x6EA5C30", VA = "0x186EA7430")]
	private void LLCOLKHIMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FNIJABGDCAK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string PCCJBOPEDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BD10C0", Offset = "0x2BCF8C0", VA = "0x182BD10C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7C60", Offset = "0x6EA6460", VA = "0x186EA7C60")]
	public FNIJABGDCAK(Exception JAOHDAGFJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7BD0", Offset = "0x6EA63D0", VA = "0x186EA7BD0")]
	private static string JCLJMLHMDAA(Exception JAOHDAGFJEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ACOJIJEEGAO : GHJKEMFHLHG, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OABBJICMPKM<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD250", Offset = "0x6DC650")]
		public Func<string, JJMNNLLBAJO<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD2B0", Offset = "0x6DC6B0")]
		public Func<JJMNNLLBAJO<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD310", Offset = "0x6DC710")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD370", Offset = "0x6DC770")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OABBJICMPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2662450", Offset = "0x2660C50", VA = "0x182662450")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void FOJGJGAJMNM(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2661F40", Offset = "0x2660740", VA = "0x182661F40")]
		internal void ANLBAIEKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void LOEEFKOKFFA(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EONEFCKLCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD3D0", Offset = "0x6DC7D0")]
		public Func<string, GHJKEMFHLHG> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public ACOJIJEEGAO newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD430", Offset = "0x6DC830")]
		public Func<GHJKEMFHLHG> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD490", Offset = "0x6DC890")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD4F0", Offset = "0x6DC8F0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EONEFCKLCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7A40", Offset = "0x6EA6240", VA = "0x186EA7A40")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void FOJGJGAJMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA78D0", Offset = "0x6EA60D0", VA = "0x186EA78D0")]
		internal void ANLBAIEKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void LOEEFKOKFFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FKIPFPCJCEO<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public FKIPFPCJCEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA010", Offset = "0x1AA8810", VA = "0x181AAA010")]
		internal void IKMAABDMIDK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2036980", Offset = "0x2035180", VA = "0x182036980")]
		internal void KICNBEJPBIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class KNPGBIOFPOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ACOJIJEEGAO newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD550", Offset = "0x6DC950")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KNPGBIOFPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9070", Offset = "0x6EA7870", VA = "0x186EA9070")]
		internal void NAAHMDAEDJM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xB78E80", Offset = "0xB77680", VA = "0x180B78E80")]
		internal void LIEEEPACFEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string NKIFGPHPFCJ = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> GAPDKBHFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> KGLCCJIHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> OLAACLBAJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? OABOGFOJNOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GHJKEMFHLHG FALPKMMLKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6800", Offset = "0x6EA5000", VA = "0x186EA6800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HIAOCCLOHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EA68E0", Offset = "0x6EA50E0", VA = "0x186EA68E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BLJJFMPJNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6350", Offset = "0x6EA4B50", VA = "0x186EA6350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6900", Offset = "0x6EA5100", VA = "0x186EA6900")]
	static ACOJIJEEGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x11A5F90", Offset = "0x11A4790", VA = "0x1811A5F90")]
	public static JJMNNLLBAJO<T> DOKNGDCFHME<T>(T LACIMGIMLFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5F50", Offset = "0x6EA4750", VA = "0x186EA5F50")]
	public static GHJKEMFHLHG CLKFDNCHKGE(string OABOGFOJNOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x11A5F90", Offset = "0x11A4790", VA = "0x1811A5F90")]
	public static JJMNNLLBAJO<T> CLKFDNCHKGE<T>(string OABOGFOJNOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EA66D0", Offset = "0x6EA4ED0", VA = "0x186EA66D0", Slot = "8")]
	public GHJKEMFHLHG KAPHOLCDBPK(Action<string> CJLAIBCPHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6860", Offset = "0x6EA5060", VA = "0x186EA6860", Slot = "17")]
	public virtual GHJKEMFHLHG OKCHOMMDGAG(Action FEIDMPBHKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6770", Offset = "0x6EA4F70", VA = "0x186EA6770", Slot = "7")]
	public GHJKEMFHLHG MKNPKNLEPGN(Action AJJPOMCMLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x11A5C70", Offset = "0x11A4470", VA = "0x1811A5C70", Slot = "10")]
	public JJMNNLLBAJO<TNew> AOMKKOKELKN<TNew>(Func<JJMNNLLBAJO<TNew>> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD190", Offset = "0x6DC590")] Func<string, JJMNNLLBAJO<TNew>> GPNGHHCBJHP) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5B20", Offset = "0x6EA4320", VA = "0x186EA5B20", Slot = "11")]
	public GHJKEMFHLHG AOMKKOKELKN(Func<GHJKEMFHLHG> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD1F0", Offset = "0x6DC5F0")] Func<string, GHJKEMFHLHG> GPNGHHCBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x11A6800", Offset = "0x11A5000", VA = "0x1811A6800", Slot = "12")]
	public JJMNNLLBAJO<TNew> HNEEPLJLHAN<TNew>(Func<TNew> HPOOJPMDCPH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5D40", Offset = "0x6EA4540", VA = "0x186EA5D40", Slot = "13")]
	public GHJKEMFHLHG CFFEKLIJMLI(Func<string, string> HPOOJPMDCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x59AA130", Offset = "0x59A8930", VA = "0x1859AA130", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6100", Offset = "0x6EA4900", VA = "0x186EA6100")]
	public void HEIMLJKPJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA63F0", Offset = "0x6EA4BF0", VA = "0x186EA63F0")]
	public void KAPHOLCDBPK(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5FC0", Offset = "0x6EA47C0", VA = "0x186EA5FC0")]
	protected Exception? HDLDCFPECHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6370", Offset = "0x6EA4B70", VA = "0x186EA6370", Slot = "18")]
	protected virtual void JEIFENGOMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6970", Offset = "0x6EA5170", VA = "0x186EA6970")]
	public ACOJIJEEGAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NBKOKFNHPDK<T> : JJMNNLLBAJO<T>, GHJKEMFHLHG, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct MIGFIEANBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD790", Offset = "0x6DCB90")]
		public readonly Action<T> COPPLLLOGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? BIENMKCIBCF;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB4E660", Offset = "0xB4CE60", VA = "0x180B4E660")]
		public MIGFIEANBLG(Action<T> COPPLLLOGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB4E620", Offset = "0xB4CE20", VA = "0x180B4E620")]
		public MIGFIEANBLG(Action BIENMKCIBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x211C2C0", Offset = "0x211AAC0", VA = "0x18211C2C0")]
		public void MADELAMLLLM(T BKHMACKFNNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FPPOMDJLLIA<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD7F0", Offset = "0x6DCBF0")]
		public Func<string, JJMNNLLBAJO<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD850", Offset = "0x6DCC50")]
		public Func<JJMNNLLBAJO<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD8B0", Offset = "0x6DCCB0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD910", Offset = "0x6DCD10")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public FPPOMDJLLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x224E230", Offset = "0x224CA30", VA = "0x18224E230")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void FOJGJGAJMNM(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x224D210", Offset = "0x224BA10", VA = "0x18224D210")]
		internal void ANLBAIEKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void LOEEFKOKFFA(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AJOOMEPLBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD970", Offset = "0x6DCD70")]
		public Func<string, GHJKEMFHLHG> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ACOJIJEEGAO newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD9D0", Offset = "0x6DCDD0")]
		public Func<GHJKEMFHLHG> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDA30", Offset = "0x6DCE30")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDA90", Offset = "0x6DCE90")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public AJOOMEPLBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x26FB060", Offset = "0x26F9860", VA = "0x1826FB060")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void FOJGJGAJMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26F6A80", Offset = "0x26F5280", VA = "0x1826F6A80")]
		internal void ANLBAIEKBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void LOEEFKOKFFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GKDENFKHIML<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDAF0", Offset = "0x6DCEF0")]
		public Func<string, JJMNNLLBAJO<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDB50", Offset = "0x6DCF50")]
		public Func<T, JJMNNLLBAJO<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDBB0", Offset = "0x6DCFB0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDC10", Offset = "0x6DD010")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public GKDENFKHIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2085640", Offset = "0x2083E40", VA = "0x182085640")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void FOJGJGAJMNM(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x20829E0", Offset = "0x20811E0", VA = "0x1820829E0")]
		internal void ANLBAIEKBNL(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x20894A0", Offset = "0x2087CA0", VA = "0x1820894A0")]
		internal void LOEEFKOKFFA(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ICAEJAHOCOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDC70", Offset = "0x6DD070")]
		public Func<string, GHJKEMFHLHG> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ACOJIJEEGAO newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDCD0", Offset = "0x6DD0D0")]
		public Func<T, GHJKEMFHLHG> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDD30", Offset = "0x6DD130")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDD90", Offset = "0x6DD190")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ICAEJAHOCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x570FCB0", Offset = "0x570E4B0", VA = "0x18570FCB0")]
		internal void EGENHMDBLEG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void GJLHPDEEKEC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void FOJGJGAJMNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x570F4F0", Offset = "0x570DCF0", VA = "0x18570F4F0")]
		internal void ANLBAIEKBNL(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x14C9C50", Offset = "0x14C8450", VA = "0x1814C9C50")]
		internal void FGJKIABKCBH(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xCB4F50", Offset = "0xCB3750", VA = "0x180CB4F50")]
		internal void LOEEFKOKFFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OOGAPFMEGPG<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OOGAPFMEGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA010", Offset = "0x1AA8810", VA = "0x181AAA010")]
		internal void IKMAABDMIDK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2036980", Offset = "0x2035180", VA = "0x182036980")]
		internal void KICNBEJPBIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IBOLCLLJJFI<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NBKOKFNHPDK<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDDF0", Offset = "0x6DD1F0")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public IBOLCLLJJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA010", Offset = "0x1AA8810", VA = "0x181AAA010")]
		internal void IKMAABDMIDK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x570E5F0", Offset = "0x570CDF0", VA = "0x18570E5F0")]
		internal void KICNBEJPBIP(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OFAKFLEJIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ACOJIJEEGAO newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDE50", Offset = "0x6DD250")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public OFAKFLEJIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x21F5670", Offset = "0x21F3E70", VA = "0x1821F5670")]
		internal void DCJDJODCFOP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB78E80", Offset = "0xB77680", VA = "0x180B78E80")]
		internal void PFPKLPKMBDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JGHCJJECHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDEB0", Offset = "0x6DD2B0")]
		public NBKOKFNHPDK<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDF10", Offset = "0x6DD310")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public JGHCJJECHMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2225D50", Offset = "0x2224550", VA = "0x182225D50")]
		internal void NAAHMDAEDJM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x22259B0", Offset = "0x22241B0", VA = "0x1822259B0")]
		internal void LIEEEPACFEE(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD5B0", Offset = "0x6DC9B0")]
	private readonly List<NBKOKFNHPDK<T>.MIGFIEANBLG> OLAACLBAJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> GAPDKBHFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> KGLCCJIHPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? OABOGFOJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T LACIMGIMLFK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xEC6A10", Offset = "0xEC5210", VA = "0x180EC6A10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8E7450", Offset = "0x8E5C50", VA = "0x1808E7450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HIAOCCLOHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2E40980", Offset = "0x2E3F180", VA = "0x182E40980", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool BLJJFMPJNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2E3D0A0", Offset = "0x2E3B8A0", VA = "0x182E3D0A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3A1E0", Offset = "0x2E389E0", VA = "0x182E3A1E0")]
	public static JJMNNLLBAJO<T> CLKFDNCHKGE(string AKADEFDGONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DA30", Offset = "0x2E3C230", VA = "0x182E3DA30", Slot = "6")]
	public JJMNNLLBAJO<T> KAPHOLCDBPK(Action<string> CJLAIBCPHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E406C0", Offset = "0x2E3EEC0", VA = "0x182E406C0", Slot = "25")]
	public virtual JJMNNLLBAJO<T> OKCHOMMDGAG(Action FEIDMPBHKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E400A0", Offset = "0x2E3E8A0", VA = "0x182E400A0", Slot = "5")]
	public JJMNNLLBAJO<T> MKNPKNLEPGN(Action AJJPOMCMLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FFC0", Offset = "0x2E3E7C0", VA = "0x182E3FFC0", Slot = "4")]
	public JJMNNLLBAJO<T> MKNPKNLEPGN(Action<T> AJJPOMCMLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29C67A0", Offset = "0x29C4FA0", VA = "0x1829C67A0", Slot = "18")]
	public JJMNNLLBAJO<TNew> AOMKKOKELKN<TNew>(Func<JJMNNLLBAJO<TNew>> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD610", Offset = "0x6DCA10")] Func<string, JJMNNLLBAJO<TNew>> GPNGHHCBJHP) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E378A0", Offset = "0x2E360A0", VA = "0x182E378A0", Slot = "19")]
	public GHJKEMFHLHG AOMKKOKELKN(Func<GHJKEMFHLHG> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD670", Offset = "0x6DCA70")] Func<string, GHJKEMFHLHG> GPNGHHCBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A8C280", Offset = "0x2A8AA80", VA = "0x182A8C280", Slot = "8")]
	public JJMNNLLBAJO<TNew> AOMKKOKELKN<TNew>(Func<T, JJMNNLLBAJO<TNew>> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD6D0", Offset = "0x6DCAD0")] Func<string, JJMNNLLBAJO<TNew>> GPNGHHCBJHP) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E381A0", Offset = "0x2E369A0", VA = "0x182E381A0", Slot = "9")]
	public GHJKEMFHLHG AOMKKOKELKN(Func<T, GHJKEMFHLHG> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DD730", Offset = "0x6DCB30")] Func<string, GHJKEMFHLHG> GPNGHHCBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29D2050", Offset = "0x29D0850", VA = "0x1829D2050", Slot = "20")]
	public JJMNNLLBAJO<TNew> HNEEPLJLHAN<TNew>(Func<TNew> HPOOJPMDCPH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A98530", Offset = "0x2A96D30", VA = "0x182A98530", Slot = "10")]
	public JJMNNLLBAJO<TNew> HNEEPLJLHAN<TNew>(Func<T, TNew> HPOOJPMDCPH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E40D50", Offset = "0x2E3F550", VA = "0x182E40D50", Slot = "21")]
	private GHJKEMFHLHG POPLNPEPMJL(Func<string, string> HPOOJPMDCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E39830", Offset = "0x2E38030", VA = "0x182E39830", Slot = "11")]
	public JJMNNLLBAJO<T> CFFEKLIJMLI(Func<string, string> HPOOJPMDCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E41990", Offset = "0x2E40190", VA = "0x182E41990", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x243CA90", Offset = "0x243B290", VA = "0x18243CA90", Slot = "15")]
	private GHJKEMFHLHG HMCEFGAOMDM(Action AJJPOMCMLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x208D480", Offset = "0x208BC80", VA = "0x18208D480", Slot = "16")]
	private GHJKEMFHLHG KLKAMBKGBNH(Action<string> CJLAIBCPHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E39040", Offset = "0x2E37840", VA = "0x182E39040", Slot = "17")]
	private GHJKEMFHLHG BCKEJHBNFJM(Action FEIDMPBHKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3C390", Offset = "0x2E3AB90", VA = "0x182E3C390")]
	public void HEIMLJKPJJI(T BKHMACKFNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3AD80", Offset = "0x2E39580", VA = "0x182E3AD80")]
	protected Exception? HDLDCFPECHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F190", Offset = "0x2E3D990", VA = "0x182E3F190")]
	public void KAPHOLCDBPK(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D370", Offset = "0x2E3BB70", VA = "0x182E3D370", Slot = "26")]
	protected virtual void JEIFENGOMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E419C0", Offset = "0x2E401C0", VA = "0x182E419C0")]
	public NBKOKFNHPDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GHJKEMFHLHG : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HIAOCCLOHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BLJJFMPJNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHJKEMFHLHG MKNPKNLEPGN(Action AJJPOMCMLCL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHJKEMFHLHG KAPHOLCDBPK(Action<string> CJLAIBCPHEC);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GHJKEMFHLHG OKCHOMMDGAG(Action FEIDMPBHKOE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJMNNLLBAJO<TNew> AOMKKOKELKN<TNew>(Func<JJMNNLLBAJO<TNew>> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDF70", Offset = "0x6DD370")] Func<string, JJMNNLLBAJO<TNew>> GPNGHHCBJHP) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GHJKEMFHLHG AOMKKOKELKN(Func<GHJKEMFHLHG> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DDFD0", Offset = "0x6DD3D0")] Func<string, GHJKEMFHLHG> GPNGHHCBJHP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JJMNNLLBAJO<TNew> HNEEPLJLHAN<TNew>(Func<TNew> HPOOJPMDCPH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GHJKEMFHLHG CFFEKLIJMLI(Func<string, string> HPOOJPMDCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JJMNNLLBAJO<out T> : GHJKEMFHLHG, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJMNNLLBAJO<T> MKNPKNLEPGN(Action<T> AJJPOMCMLCL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new JJMNNLLBAJO<T> MKNPKNLEPGN(Action AJJPOMCMLCL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new JJMNNLLBAJO<T> KAPHOLCDBPK(Action<string> CJLAIBCPHEC);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new JJMNNLLBAJO<T> OKCHOMMDGAG(Action FEIDMPBHKOE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JJMNNLLBAJO<TNew> AOMKKOKELKN<TNew>(Func<T, JJMNNLLBAJO<TNew>> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE030", Offset = "0x6DD430")] Func<string, JJMNNLLBAJO<TNew>> GPNGHHCBJHP) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GHJKEMFHLHG AOMKKOKELKN(Func<T, GHJKEMFHLHG> HPOOJPMDCPH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE090", Offset = "0x6DD490")] Func<string, GHJKEMFHLHG> GPNGHHCBJHP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JJMNNLLBAJO<TNew> HNEEPLJLHAN<TNew>(Func<T, TNew> HPOOJPMDCPH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new JJMNNLLBAJO<T> CFFEKLIJMLI(Func<string, string> HPOOJPMDCPH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BKPNLAAFHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum DHACGEHDPOI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class NINPMCLNCBJ : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9170", Offset = "0x6EA7970", VA = "0x186EA9170")]
		public NINPMCLNCBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OBDCCFNKDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OBDCCFNKDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9350", Offset = "0x6EA7B50", VA = "0x186EA9350")]
		internal void PCCBPHJEPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EA92C0", Offset = "0x6EA7AC0", VA = "0x186EA92C0")]
		internal void MKMFHHPLFIG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9270", Offset = "0x6EA7A70", VA = "0x186EA9270")]
		internal void CKDAIFDIGMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HKNBPJOMEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KIPKMCKINOD cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public DHACGEHDPOI unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HKNBPJOMEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8010", Offset = "0x6EA6810", VA = "0x186EA8010")]
		internal void PCCBPHJEPIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7DF0", Offset = "0x6EA65F0", VA = "0x186EA7DF0")]
		internal void MKMFHHPLFIG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7D50", Offset = "0x6EA6550", VA = "0x186EA7D50")]
		internal void CKDAIFDIGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7E80", Offset = "0x6EA6680", VA = "0x186EA7E80")]
		internal void OCPHPOADIHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EBFIIABOAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public EBFIIABOAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2A58790", Offset = "0x2A56F90", VA = "0x182A58790")]
		internal void GJAOJMGKHGA(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HNCHICINOEM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public HNCHICINOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x29AA5E0", Offset = "0x29A8DE0", VA = "0x1829AA5E0")]
		internal void PCCBPHJEPIG(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A314C0", Offset = "0x3A2FCC0", VA = "0x183A314C0")]
		internal void MKMFHHPLFIG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9A50", Offset = "0x1AA8250", VA = "0x181AA9A50")]
		internal void CKDAIFDIGMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AOJKJKIEHOE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KIPKMCKINOD cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DHACGEHDPOI unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public AOJKJKIEHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2709600", Offset = "0x2707E00", VA = "0x182709600")]
		internal void PCCBPHJEPIG(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2709260", Offset = "0x2707A60", VA = "0x182709260")]
		internal void MKMFHHPLFIG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2709120", Offset = "0x2707920", VA = "0x182709120")]
		internal void CKDAIFDIGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x27093A0", Offset = "0x2707BA0", VA = "0x1827093A0")]
		internal void OCPHPOADIHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LOHHDMNHIBL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public LOHHDMNHIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A58790", Offset = "0x2A56F90", VA = "0x182A58790")]
		internal void GJAOJMGKHGA(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HNGEJHHLHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public ACOJIJEEGAO promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public HNGEJHHLHPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8060", Offset = "0x6EA6860", VA = "0x186EA8060")]
		internal void IGJDKEDKPDB(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DOKJIBFKJMM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NBKOKFNHPDK<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public DOKJIBFKJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x27F11B0", Offset = "0x27EF9B0", VA = "0x1827F11B0")]
		internal void IGJDKEDKPDB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE130", Offset = "0x6DD530")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6C70", Offset = "0x6EA5470", VA = "0x186EA6C70")]
	public static Task GANKEECJLEH(this GHJKEMFHLHG IAHNODEPOMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6E80", Offset = "0x6EA5680", VA = "0x186EA6E80")]
	public static Task<bool> GANKEECJLEH(this GHJKEMFHLHG IAHNODEPOMP, CancellationToken NNLBJPBEHPF, DHACGEHDPOI IKGAAKLMPFE = DHACGEHDPOI.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E6A2B0", Offset = "0x1E68AB0", VA = "0x181E6A2B0")]
	public static Task<TResult> GANKEECJLEH<TResult>(this JJMNNLLBAJO<TResult> IAHNODEPOMP) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1E6A4E0", Offset = "0x1E68CE0", VA = "0x181E6A4E0")]
	public static Task<TResult> GANKEECJLEH<TResult>(this JJMNNLLBAJO<TResult> IAHNODEPOMP, CancellationToken NNLBJPBEHPF, DHACGEHDPOI IKGAAKLMPFE = DHACGEHDPOI.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6A70", Offset = "0x6EA5270", VA = "0x186EA6A70")]
	public static TaskAwaiter CAGNJFBILCM(this GHJKEMFHLHG IAHNODEPOMP)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1E68440", Offset = "0x1E66C40", VA = "0x181E68440")]
	public static TaskAwaiter<TResult> CAGNJFBILCM<TResult>(this JJMNNLLBAJO<TResult> IAHNODEPOMP) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6AA0", Offset = "0x6EA52A0", VA = "0x186EA6AA0")]
	public static GHJKEMFHLHG CIGHLKEPKGM(this Task KOOMIGAFDLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E69100", Offset = "0x1E67900", VA = "0x181E69100")]
	public static JJMNNLLBAJO<TResult> CIGHLKEPKGM<TResult>(this Task<TResult> KOOMIGAFDLJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7200", Offset = "0x6EA5A00", VA = "0x186EA7200")]
	private static string NABLDDJHBJK(Task KOOMIGAFDLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KIPKMCKINOD : GHJKEMFHLHG, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EBDHHENCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PFEDGOKCJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CCPAFFLIAHM();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIPKMCKINOD GDKNLGNGAEF(Action HHGANAOOKGB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface IIOPHFANMIH<T> : JJMNNLLBAJO<T>, GHJKEMFHLHG, IEnumerator, KIPKMCKINOD
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new IIOPHFANMIH<T> GDKNLGNGAEF(Action HHGANAOOKGB);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JPFMDMMMPOO : ACOJIJEEGAO, KIPKMCKINOD, GHJKEMFHLHG, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> HHGANAOOKGB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static KIPKMCKINOD CIMEABEPBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8CD0", Offset = "0x6EA74D0", VA = "0x186EA8CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EBDHHENCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xEC6A10", Offset = "0xEC5210", VA = "0x180EC6A10", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E7450", Offset = "0x8E5C50", VA = "0x1808E7450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PFEDGOKCJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8A70", Offset = "0x6EA7270", VA = "0x186EA8A70", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8E90", Offset = "0x6EA7690", VA = "0x186EA8E90")]
	static JPFMDMMMPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x11A5F90", Offset = "0x11A4790", VA = "0x1811A5F90")]
	public new static IIOPHFANMIH<T> DOKNGDCFHME<T>(T LACIMGIMLFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x11A5F90", Offset = "0x11A4790", VA = "0x1811A5F90")]
	public new static IIOPHFANMIH<T> CLKFDNCHKGE<T>(string OABOGFOJNOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8A80", Offset = "0x6EA7280", VA = "0x186EA8A80", Slot = "21")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8D30", Offset = "0x6EA7530", VA = "0x186EA8D30", Slot = "22")]
	public KIPKMCKINOD GDKNLGNGAEF(Action LHNPKAMFCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8DB0", Offset = "0x6EA75B0", VA = "0x186EA8DB0", Slot = "18")]
	protected override void JEIFENGOMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8E00", Offset = "0x6EA7600", VA = "0x186EA8E00", Slot = "17")]
	public override GHJKEMFHLHG OKCHOMMDGAG(Action FEIDMPBHKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8FC0", Offset = "0x6EA77C0", VA = "0x186EA8FC0")]
	public JPFMDMMMPOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6DE190", Offset = "0x6DD590")]
public class MIEHPFLMFLO<T> : NBKOKFNHPDK<T>, IIOPHFANMIH<T>, JJMNNLLBAJO<T>, GHJKEMFHLHG, IEnumerator, KIPKMCKINOD where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> HHGANAOOKGB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EBDHHENCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA55970", Offset = "0xA54170", VA = "0x180A55970", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA55980", Offset = "0xA54180", VA = "0x180A55980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PFEDGOKCJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x211B720", Offset = "0x2119F20", VA = "0x18211B720", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x211BAA0", Offset = "0x211A2A0", VA = "0x18211BAA0", Slot = "30")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x211BDE0", Offset = "0x211A5E0", VA = "0x18211BDE0", Slot = "27")]
	public IIOPHFANMIH<T> GDKNLGNGAEF(Action LHNPKAMFCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x211BDB0", Offset = "0x211A5B0", VA = "0x18211BDB0", Slot = "31")]
	private KIPKMCKINOD CDKPLDLPNGI(Action LHNPKAMFCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x211BFB0", Offset = "0x211A7B0", VA = "0x18211BFB0", Slot = "26")]
	protected override void JEIFENGOMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x211C020", Offset = "0x211A820", VA = "0x18211C020", Slot = "25")]
	public override JJMNNLLBAJO<T> OKCHOMMDGAG(Action FEIDMPBHKOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x211C160", Offset = "0x211A960", VA = "0x18211C160")]
	public MIEHPFLMFLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IDLBMMGLEII : EOJGPNLOGDN, KIPKMCKINOD, GHJKEMFHLHG, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> HHGANAOOKGB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EBDHHENCEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x896C70", Offset = "0x895470", VA = "0x180896C70", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA9A960", Offset = "0xA99160", VA = "0x180A9A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PFEDGOKCJON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8120", Offset = "0x6EA6920", VA = "0x186EA8120", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8690", Offset = "0x6EA6E90", VA = "0x186EA8690")]
	public IDLBMMGLEII(KIPKMCKINOD IAHNODEPOMP, KIPKMCKINOD DOFDIEGHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA87B0", Offset = "0x6EA6FB0", VA = "0x186EA87B0")]
	public IDLBMMGLEII(IList<KIPKMCKINOD> AFKMPCFNABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8130", Offset = "0x6EA6930", VA = "0x186EA8130", Slot = "21")]
	public void CCPAFFLIAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8530", Offset = "0x6EA6D30", VA = "0x186EA8530", Slot = "22")]
	public KIPKMCKINOD GDKNLGNGAEF(Action LHNPKAMFCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA85B0", Offset = "0x6EA6DB0", VA = "0x186EA85B0", Slot = "18")]
	protected override void JEIFENGOMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8600", Offset = "0x6EA6E00", VA = "0x186EA8600", Slot = "17")]
	public override GHJKEMFHLHG OKCHOMMDGAG(Action FEIDMPBHKOE)
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
