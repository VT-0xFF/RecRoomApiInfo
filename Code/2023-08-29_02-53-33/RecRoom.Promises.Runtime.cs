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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F28500", Offset = "0x6F27900", VA = "0x186F28500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class INKNAKKDLAN : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string HAFJHPAODCK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F26F70", Offset = "0x6F26370", VA = "0x186F26F70")]
	public INKNAKKDLAN(string HGJHDPGFLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E88B0", Offset = "0x6E7CB0")]
public class BMHBBHJMKJN<T1, T2> : KOGBHMMNAJA<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CAALEIKGNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8920", Offset = "0x6E7D20")]
		public MCFFIFIPNKE<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public BMHBBHJMKJN<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public CAALEIKGNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA440", Offset = "0x2CB9840", VA = "0x182CBA440")]
		internal void MNICOLMCAIE(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BFCEJENBKNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CAALEIKGNAE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public BFCEJENBKNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24C8A90", Offset = "0x24C7E90", VA = "0x1824C8A90")]
		internal void KBFMIJFPKDP(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24D3340", Offset = "0x24D2740", VA = "0x1824D3340")]
	public BMHBBHJMKJN(MCFFIFIPNKE<T1> DOOACPDOHLM, MCFFIFIPNKE<T2> NOKBKGOKJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24D2E10", Offset = "0x24D2210", VA = "0x1824D2E10")]
	private void FEIBJALBBEF(string KDPCEEMNMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E89A0", Offset = "0x6E7DA0")]
public class LOECPEMAHAB<T1, T2, T3> : KOGBHMMNAJA<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KAEKGNDFEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8A10", Offset = "0x6E7E10")]
		public MCFFIFIPNKE<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8A70", Offset = "0x6E7E70")]
		public MCFFIFIPNKE<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public LOECPEMAHAB<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public KAEKGNDFEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2102D10", Offset = "0x2102110", VA = "0x182102D10")]
		internal void MNICOLMCAIE(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KFDGIDCPBKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KAEKGNDFEGF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public KFDGIDCPBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x203B190", Offset = "0x203A590", VA = "0x18203B190")]
		internal void KBFMIJFPKDP(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HEHIMDFMMBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KFDGIDCPBKB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public HEHIMDFMMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x202AF40", Offset = "0x202A340", VA = "0x18202AF40")]
		internal void AEDLAEGMGHJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37A7560", Offset = "0x37A6960", VA = "0x1837A7560")]
	public LOECPEMAHAB(MCFFIFIPNKE<T1> DOOACPDOHLM, MCFFIFIPNKE<T2> NOKBKGOKJLM, MCFFIFIPNKE<T3> DCAKKNHJFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37A7210", Offset = "0x37A6610", VA = "0x1837A7210")]
	private void FEIBJALBBEF(string KDPCEEMNMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8AD0", Offset = "0x6E7ED0")]
public class OMGFIGLCHBC<T1, T2, T3, T4, T5> : KOGBHMMNAJA<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KJGNICJKFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8B40", Offset = "0x6E7F40")]
		public MCFFIFIPNKE<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8BA0", Offset = "0x6E7FA0")]
		public MCFFIFIPNKE<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8C00", Offset = "0x6E8000")]
		public MCFFIFIPNKE<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8C60", Offset = "0x6E8060")]
		public MCFFIFIPNKE<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OMGFIGLCHBC<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public KJGNICJKFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2102D10", Offset = "0x2102110", VA = "0x182102D10")]
		internal void MNICOLMCAIE(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LBFAGCGDKPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KJGNICJKFMK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public LBFAGCGDKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x203B190", Offset = "0x203A590", VA = "0x18203B190")]
		internal void KBFMIJFPKDP(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LKMJDPPPCBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LBFAGCGDKPH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public LKMJDPPPCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x204C570", Offset = "0x204B970", VA = "0x18204C570")]
		internal void AEDLAEGMGHJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IGOIJHIPELG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LKMJDPPPCBF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public IGOIJHIPELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xEFF9C0", Offset = "0xEFEDC0", VA = "0x180EFF9C0")]
		internal void NDMMNHJDFKE(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OGEELOBMILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public IGOIJHIPELG CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public OGEELOBMILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2F35A60", Offset = "0x2F34E60", VA = "0x182F35A60")]
		internal void DJPIDMKBMFB(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3373FF0", Offset = "0x33733F0", VA = "0x183373FF0")]
	public OMGFIGLCHBC(MCFFIFIPNKE<T1> DOOACPDOHLM, MCFFIFIPNKE<T2> NOKBKGOKJLM, MCFFIFIPNKE<T3> DCAKKNHJFAG, MCFFIFIPNKE<T4> KONNPDLABKH, MCFFIFIPNKE<T5> IMDFEHCHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3373F80", Offset = "0x3373380", VA = "0x183373F80")]
	private void FEIBJALBBEF(string KDPCEEMNMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8CC0", Offset = "0x6E80C0")]
public class KFJEJPMKLBA<T> : KOGBHMMNAJA<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BEBKJAKCDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KFJEJPMKLBA<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public BEBKJAKCDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24C6B60", Offset = "0x24C5F60", VA = "0x1824C6B60")]
		internal void MNICOLMCAIE(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8D30", Offset = "0x6E8130")]
	private readonly T[] DDENMGDIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int IJAHMLBLNKD;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x220B670", Offset = "0x220AA70", VA = "0x18220B670")]
	public KFJEJPMKLBA(List<MCFFIFIPNKE<T>> BHPBNKHMFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x220B600", Offset = "0x220AA00", VA = "0x18220B600")]
	private void FEIBJALBBEF(string KDPCEEMNMDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBDKDGEPBPE : PFDOLDLEIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int MFGLJGBNGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<CCKGNGCPCCF> BHPBNKHMFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> FEHKOELMILH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F261D0", Offset = "0x6F255D0", VA = "0x186F261D0")]
	public BBDKDGEPBPE(params CCKGNGCPCCF[] BHPBNKHMFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F25DD0", Offset = "0x6F251D0", VA = "0x186F25DD0")]
	public BBDKDGEPBPE(IReadOnlyList<CCKGNGCPCCF> BHPBNKHMFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F25CE0", Offset = "0x6F250E0", VA = "0x186F25CE0")]
	private void HIIPNOHLFKB(string AHAKHACKMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F25D40", Offset = "0x6F25140", VA = "0x186F25D40")]
	private void ICPHAKAIONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LNLKMPCCKKC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string FHNABMEBKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2E4E650", Offset = "0x2E4DA50", VA = "0x182E4E650", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F27B00", Offset = "0x6F26F00", VA = "0x186F27B00")]
	public LNLKMPCCKKC(Exception CCIFFHEDKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A70", Offset = "0x6F26E70", VA = "0x186F27A70")]
	private static string BLCPOABHOGB(Exception CCIFFHEDKNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PFDOLDLEIBA : CCKGNGCPCCF, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IENCPGPFNHF<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8EB0", Offset = "0x6E82B0")]
		public Func<string, MCFFIFIPNKE<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8F10", Offset = "0x6E8310")]
		public Func<MCFFIFIPNKE<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8F70", Offset = "0x6E8370")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8FD0", Offset = "0x6E83D0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public IENCPGPFNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xEFA200", Offset = "0xEF9600", VA = "0x180EFA200")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void LMNOCBADNHL(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEF8D80", Offset = "0xEF8180", VA = "0x180EF8D80")]
		internal void JLGBBFMDCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void MOAANNPJHIN(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GFPEELPOMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9030", Offset = "0x6E8430")]
		public Func<string, CCKGNGCPCCF> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PFDOLDLEIBA newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9090", Offset = "0x6E8490")]
		public Func<CCKGNGCPCCF> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E90F0", Offset = "0x6E84F0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9150", Offset = "0x6E8550")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GFPEELPOMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6F26DE0", Offset = "0x6F261E0", VA = "0x186F26DE0")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void LMNOCBADNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6F26C70", Offset = "0x6F26070", VA = "0x186F26C70")]
		internal void JLGBBFMDCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void MOAANNPJHIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PACAPHALIOG<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public PACAPHALIOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DA0", Offset = "0xEF11A0", VA = "0x180EF1DA0")]
		internal void OHCDPHBEEFJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x24E3F20", Offset = "0x24E3320", VA = "0x1824E3F20")]
		internal void NNGMFNNOJGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ANGBFNIGACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PFDOLDLEIBA newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E91B0", Offset = "0x6E85B0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ANGBFNIGACM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F25C60", Offset = "0x6F25060", VA = "0x186F25C60")]
		internal void BBKIKBLPNOD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA270B0", Offset = "0xA264B0", VA = "0x180A270B0")]
		internal void BFJLFKJEFIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string CCLKKGGGBLG = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> PGEJMBCBJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> HFPMLNDOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> CGOIHFKHCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? KDPCEEMNMDK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static CCKGNGCPCCF GDMFPBMGBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F28E30", Offset = "0x6F28230", VA = "0x186F28E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EPCPPDDJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FD060", Offset = "0x8FC460", VA = "0x1808FD060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FD5F0", Offset = "0x8FC9F0", VA = "0x1808FD5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MPJBGFFEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F28C50", Offset = "0x6F28050", VA = "0x186F28C50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NEIINCCHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F28590", Offset = "0x6F27990", VA = "0x186F28590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F29370", Offset = "0x6F28770", VA = "0x186F29370")]
	static PFDOLDLEIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x12D0E20", Offset = "0x12D0220", VA = "0x1812D0E20")]
	public static MCFFIFIPNKE<T> PLJINLOCHGM<T>(T OHCLGKAJOMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F287D0", Offset = "0x6F27BD0", VA = "0x186F287D0")]
	public static CCKGNGCPCCF BPMPBOJFNCD(string KDPCEEMNMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x12D0E20", Offset = "0x12D0220", VA = "0x1812D0E20")]
	public static MCFFIFIPNKE<T> BPMPBOJFNCD<T>(string KDPCEEMNMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F28B20", Offset = "0x6F27F20", VA = "0x186F28B20", Slot = "8")]
	public CCKGNGCPCCF CKIEGOCLGFD(Action<string> EKLAHCABNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F290A0", Offset = "0x6F284A0", VA = "0x186F290A0", Slot = "17")]
	public virtual CCKGNGCPCCF OCKKHGOEEJJ(Action KIPFAJLMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F28BC0", Offset = "0x6F27FC0", VA = "0x186F28BC0", Slot = "7")]
	public CCKGNGCPCCF EIAKBDPCFOD(Action MJDNFIANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x12D0B00", Offset = "0x12CFF00", VA = "0x1812D0B00", Slot = "10")]
	public MCFFIFIPNKE<TNew> BENKHBDOKLJ<TNew>(Func<MCFFIFIPNKE<TNew>> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8DF0", Offset = "0x6E81F0")] Func<string, MCFFIFIPNKE<TNew>> PGKLALGBDKC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F285B0", Offset = "0x6F279B0", VA = "0x186F285B0", Slot = "11")]
	public CCKGNGCPCCF BENKHBDOKLJ(Func<CCKGNGCPCCF> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8E50", Offset = "0x6E8250")] Func<string, CCKGNGCPCCF> PGKLALGBDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x12D11A0", Offset = "0x12D05A0", VA = "0x1812D11A0", Slot = "12")]
	public MCFFIFIPNKE<TNew> GOPDKEIBKCI<TNew>(Func<TNew> BOEPCJAIAGH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F28E90", Offset = "0x6F28290", VA = "0x186F28E90", Slot = "13")]
	public CCKGNGCPCCF NDPPGAOIOIE(Func<string, string> BOEPCJAIAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5A15BC0", Offset = "0x5A14FC0", VA = "0x185A15BC0", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F29120", Offset = "0x6F28520", VA = "0x186F29120")]
	public void OLKGFACPIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F28840", Offset = "0x6F27C40", VA = "0x186F28840")]
	public void CKIEGOCLGFD(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F28C70", Offset = "0x6F28070", VA = "0x186F28C70")]
	protected Exception? HCGMIPFBNCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F28DB0", Offset = "0x6F281B0", VA = "0x186F28DB0", Slot = "18")]
	protected virtual void KPMHFMFLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F293E0", Offset = "0x6F287E0", VA = "0x186F293E0")]
	public PFDOLDLEIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KOGBHMMNAJA<T> : MCFFIFIPNKE<T>, CCKGNGCPCCF, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct OFKOKJOEJJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E93F0", Offset = "0x6E87F0")]
		public readonly Action<T> FJBAKNFCPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? FPHGKDGKDEI;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xBE8FA0", Offset = "0xBE83A0", VA = "0x180BE8FA0")]
		public OFKOKJOEJJF(Action<T> FJBAKNFCPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xBE8F60", Offset = "0xBE8360", VA = "0x180BE8F60")]
		public OFKOKJOEJJF(Action FPHGKDGKDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2F35140", Offset = "0x2F34540", VA = "0x182F35140")]
		public void GDOLIKHHLHI(T KBLLMJIHKAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LMJPHIFNMKM<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9450", Offset = "0x6E8850")]
		public Func<string, MCFFIFIPNKE<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E94B0", Offset = "0x6E88B0")]
		public Func<MCFFIFIPNKE<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9510", Offset = "0x6E8910")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9570", Offset = "0x6E8970")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public LMJPHIFNMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3FFC1A0", Offset = "0x3FFB5A0", VA = "0x183FFC1A0")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void LMNOCBADNHL(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0CE0", Offset = "0x3FF00E0", VA = "0x183FF0CE0")]
		internal void JLGBBFMDCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void MOAANNPJHIN(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GHLCGCGKKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E95D0", Offset = "0x6E89D0")]
		public Func<string, CCKGNGCPCCF> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PFDOLDLEIBA newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9630", Offset = "0x6E8A30")]
		public Func<CCKGNGCPCCF> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9690", Offset = "0x6E8A90")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E96F0", Offset = "0x6E8AF0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public GHLCGCGKKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x21303C0", Offset = "0x212F7C0", VA = "0x1821303C0")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void LMNOCBADNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x212D1C0", Offset = "0x212C5C0", VA = "0x18212D1C0")]
		internal void JLGBBFMDCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void MOAANNPJHIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ANIJCKMOGFB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9750", Offset = "0x6E8B50")]
		public Func<string, MCFFIFIPNKE<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E97B0", Offset = "0x6E8BB0")]
		public Func<T, MCFFIFIPNKE<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9810", Offset = "0x6E8C10")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9870", Offset = "0x6E8C70")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public ANIJCKMOGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x30FB080", Offset = "0x30FA480", VA = "0x1830FB080")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void LMNOCBADNHL(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x30F7B00", Offset = "0x30F6F00", VA = "0x1830F7B00")]
		internal void JLGBBFMDCHP(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xEF9870", Offset = "0xEF8C70", VA = "0x180EF9870")]
		internal void MOAANNPJHIN(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OBDGFLNMGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E98D0", Offset = "0x6E8CD0")]
		public Func<string, CCKGNGCPCCF> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PFDOLDLEIBA newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9930", Offset = "0x6E8D30")]
		public Func<T, CCKGNGCPCCF> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9990", Offset = "0x6E8D90")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E99F0", Offset = "0x6E8DF0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public OBDGFLNMGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2705570", Offset = "0x2704970", VA = "0x182705570")]
		internal void MAKNPGBIGEK(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void LFPIKHCGAEA(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void LMNOCBADNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2703CB0", Offset = "0x27030B0", VA = "0x182703CB0")]
		internal void JLGBBFMDCHP(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13515C0", Offset = "0x13509C0", VA = "0x1813515C0")]
		internal void NPJAGEHCLCG(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xD4F530", Offset = "0xD4E930", VA = "0x180D4F530")]
		internal void MOAANNPJHIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DGHNOEFDFMP<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DGHNOEFDFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DA0", Offset = "0xEF11A0", VA = "0x180EF1DA0")]
		internal void OHCDPHBEEFJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x24E3F20", Offset = "0x24E3320", VA = "0x1824E3F20")]
		internal void NNGMFNNOJGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GMAGJJABGPB<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KOGBHMMNAJA<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9A50", Offset = "0x6E8E50")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public GMAGJJABGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DA0", Offset = "0xEF11A0", VA = "0x180EF1DA0")]
		internal void OHCDPHBEEFJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x274A680", Offset = "0x2749A80", VA = "0x18274A680")]
		internal void NNGMFNNOJGI(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class APFAAOCCCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PFDOLDLEIBA newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9AB0", Offset = "0x6E8EB0")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public APFAAOCCCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2571FD0", Offset = "0x25713D0", VA = "0x182571FD0")]
		internal void OGEMLGJKCCF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA270B0", Offset = "0xA264B0", VA = "0x180A270B0")]
		internal void EACPGBAIBHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class FGJIDMHEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9B10", Offset = "0x6E8F10")]
		public KOGBHMMNAJA<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9B70", Offset = "0x6E8F70")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FGJIDMHEHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x194ACD0", Offset = "0x194A0D0", VA = "0x18194ACD0")]
		internal void BBKIKBLPNOD(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x194B300", Offset = "0x194A700", VA = "0x18194B300")]
		internal void BFJLFKJEFIK(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9210", Offset = "0x6E8610")]
	private readonly List<KOGBHMMNAJA<T>.OFKOKJOEJJF> CGOIHFKHCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> PGEJMBCBJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> HFPMLNDOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? KDPCEEMNMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T OHCLGKAJOMN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EPCPPDDJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA2DB20", Offset = "0xA2CF20", VA = "0x180A2DB20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF07F50", Offset = "0xF07350", VA = "0x180F07F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MPJBGFFEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x221AF60", Offset = "0x221A360", VA = "0x18221AF60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NEIINCCHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x221A410", Offset = "0x2219810", VA = "0x18221A410", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x221A800", Offset = "0x2219C00", VA = "0x18221A800")]
	public static MCFFIFIPNKE<T> BPMPBOJFNCD(string HGJHDPGFLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x221A920", Offset = "0x2219D20", VA = "0x18221A920", Slot = "6")]
	public MCFFIFIPNKE<T> CKIEGOCLGFD(Action<string> EKLAHCABNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x221B620", Offset = "0x221AA20", VA = "0x18221B620", Slot = "25")]
	public virtual MCFFIFIPNKE<T> OCKKHGOEEJJ(Action KIPFAJLMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x221AD80", Offset = "0x221A180", VA = "0x18221AD80", Slot = "5")]
	public MCFFIFIPNKE<T> EIAKBDPCFOD(Action MJDNFIANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x221AE50", Offset = "0x221A250", VA = "0x18221AE50", Slot = "4")]
	public MCFFIFIPNKE<T> EIAKBDPCFOD(Action<T> MJDNFIANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x21DFE80", Offset = "0x21DF280", VA = "0x1821DFE80", Slot = "18")]
	public MCFFIFIPNKE<TNew> BENKHBDOKLJ<TNew>(Func<MCFFIFIPNKE<TNew>> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9270", Offset = "0x6E8670")] Func<string, MCFFIFIPNKE<TNew>> PGKLALGBDKC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x221A460", Offset = "0x2219860", VA = "0x18221A460", Slot = "19")]
	public CCKGNGCPCCF BENKHBDOKLJ(Func<CCKGNGCPCCF> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E92D0", Offset = "0x6E86D0")] Func<string, CCKGNGCPCCF> PGKLALGBDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28241C0", Offset = "0x28235C0", VA = "0x1828241C0", Slot = "8")]
	public MCFFIFIPNKE<TNew> BENKHBDOKLJ<TNew>(Func<T, MCFFIFIPNKE<TNew>> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9330", Offset = "0x6E8730")] Func<string, MCFFIFIPNKE<TNew>> PGKLALGBDKC) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x221A620", Offset = "0x2219A20", VA = "0x18221A620", Slot = "9")]
	public CCKGNGCPCCF BENKHBDOKLJ(Func<T, CCKGNGCPCCF> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9390", Offset = "0x6E8790")] Func<string, CCKGNGCPCCF> PGKLALGBDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x21E13D0", Offset = "0x21E07D0", VA = "0x1821E13D0", Slot = "20")]
	public MCFFIFIPNKE<TNew> GOPDKEIBKCI<TNew>(Func<TNew> BOEPCJAIAGH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x282E200", Offset = "0x282D600", VA = "0x18282E200", Slot = "10")]
	public MCFFIFIPNKE<TNew> GOPDKEIBKCI<TNew>(Func<T, TNew> BOEPCJAIAGH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x221B1A0", Offset = "0x221A5A0", VA = "0x18221B1A0", Slot = "21")]
	private CCKGNGCPCCF JGAIMAPIJAI(Func<string, string> BOEPCJAIAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x221B430", Offset = "0x221A830", VA = "0x18221B430", Slot = "11")]
	public MCFFIFIPNKE<T> NDPPGAOIOIE(Func<string, string> BOEPCJAIAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x221BA30", Offset = "0x221AE30", VA = "0x18221BA30", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x221B170", Offset = "0x221A570", VA = "0x18221B170", Slot = "15")]
	private CCKGNGCPCCF JBHANHOKKND(Action MJDNFIANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x221AF30", Offset = "0x221A330", VA = "0x18221AF30", Slot = "16")]
	private CCKGNGCPCCF FLEFKFAHMLL(Action<string> EKLAHCABNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x221B400", Offset = "0x221A800", VA = "0x18221B400", Slot = "17")]
	private CCKGNGCPCCF LPMMMECFFPB(Action KIPFAJLMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x221B6D0", Offset = "0x221AAD0", VA = "0x18221B6D0")]
	public void OLKGFACPIPC(T KBLLMJIHKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x221AFB0", Offset = "0x221A3B0", VA = "0x18221AFB0")]
	protected Exception? HCGMIPFBNCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x221A9E0", Offset = "0x2219DE0", VA = "0x18221A9E0")]
	public void CKIEGOCLGFD(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x221B360", Offset = "0x221A760", VA = "0x18221B360", Slot = "26")]
	protected virtual void KPMHFMFLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x221BA60", Offset = "0x221AE60", VA = "0x18221BA60")]
	public KOGBHMMNAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CCKGNGCPCCF : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EPCPPDDJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MPJBGFFEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NEIINCCHEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCKGNGCPCCF EIAKBDPCFOD(Action MJDNFIANGNM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCKGNGCPCCF CKIEGOCLGFD(Action<string> EKLAHCABNNP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCKGNGCPCCF OCKKHGOEEJJ(Action KIPFAJLMMPC);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCFFIFIPNKE<TNew> BENKHBDOKLJ<TNew>(Func<MCFFIFIPNKE<TNew>> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9BD0", Offset = "0x6E8FD0")] Func<string, MCFFIFIPNKE<TNew>> PGKLALGBDKC) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CCKGNGCPCCF BENKHBDOKLJ(Func<CCKGNGCPCCF> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9C30", Offset = "0x6E9030")] Func<string, CCKGNGCPCCF> PGKLALGBDKC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MCFFIFIPNKE<TNew> GOPDKEIBKCI<TNew>(Func<TNew> BOEPCJAIAGH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CCKGNGCPCCF NDPPGAOIOIE(Func<string, string> BOEPCJAIAGH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MCFFIFIPNKE<out T> : CCKGNGCPCCF, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCFFIFIPNKE<T> EIAKBDPCFOD(Action<T> MJDNFIANGNM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new MCFFIFIPNKE<T> EIAKBDPCFOD(Action MJDNFIANGNM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new MCFFIFIPNKE<T> CKIEGOCLGFD(Action<string> EKLAHCABNNP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new MCFFIFIPNKE<T> OCKKHGOEEJJ(Action KIPFAJLMMPC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCFFIFIPNKE<TNew> BENKHBDOKLJ<TNew>(Func<T, MCFFIFIPNKE<TNew>> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9C90", Offset = "0x6E9090")] Func<string, MCFFIFIPNKE<TNew>> PGKLALGBDKC) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCKGNGCPCCF BENKHBDOKLJ(Func<T, CCKGNGCPCCF> BOEPCJAIAGH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9CF0", Offset = "0x6E90F0")] Func<string, CCKGNGCPCCF> PGKLALGBDKC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCFFIFIPNKE<TNew> GOPDKEIBKCI<TNew>(Func<T, TNew> BOEPCJAIAGH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new MCFFIFIPNKE<T> NDPPGAOIOIE(Func<string, string> BOEPCJAIAGH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CDCACEDDLHI
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum JINNJEMKGMG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DDPLHKEDJEE : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F26B40", Offset = "0x6F25F40", VA = "0x186F26B40")]
		public DDPLHKEDJEE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KHMJFJCGGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KHMJFJCGGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F27990", Offset = "0x6F26D90", VA = "0x186F27990")]
		internal void JIBONKCFJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F279E0", Offset = "0x6F26DE0", VA = "0x186F279E0")]
		internal void JKMADDCNFKL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F27940", Offset = "0x6F26D40", VA = "0x186F27940")]
		internal void FFLGEIBFNOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NNPCNICFFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HPLBPNIMMDC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public JINNJEMKGMG unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public NNPCNICFFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6F28420", Offset = "0x6F27820", VA = "0x186F28420")]
		internal void JIBONKCFJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F28470", Offset = "0x6F27870", VA = "0x186F28470")]
		internal void JKMADDCNFKL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F281F0", Offset = "0x6F275F0", VA = "0x186F281F0")]
		internal void FFLGEIBFNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F28290", Offset = "0x6F27690", VA = "0x186F28290")]
		internal void JAABKEKLDJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OPOFOGNGMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OPOFOGNGMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F370", Offset = "0x2B0E770", VA = "0x182B0F370")]
		internal void LFLMHHAGAAD(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IDBFDBCEKKB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public IDBFDBCEKKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DD0", Offset = "0xEF11D0", VA = "0x180EF1DD0")]
		internal void JIBONKCFJEO(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xEF1FA0", Offset = "0xEF13A0", VA = "0x180EF1FA0")]
		internal void JKMADDCNFKL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xEF1D70", Offset = "0xEF1170", VA = "0x180EF1D70")]
		internal void FFLGEIBFNOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DNOJCOLCNKF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HPLBPNIMMDC cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public JINNJEMKGMG unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DNOJCOLCNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E2AED0", Offset = "0x2E2A2D0", VA = "0x182E2AED0")]
		internal void JIBONKCFJEO(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E2AF30", Offset = "0x2E2A330", VA = "0x182E2AF30")]
		internal void JKMADDCNFKL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E2ABD0", Offset = "0x2E29FD0", VA = "0x182E2ABD0")]
		internal void FFLGEIBFNOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E2ADA0", Offset = "0x2E2A1A0", VA = "0x182E2ADA0")]
		internal void JAABKEKLDJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OPLMBINJGKH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public OPLMBINJGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B0F370", Offset = "0x2B0E770", VA = "0x182B0F370")]
		internal void LFLMHHAGAAD(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GAKLDONLFHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PFDOLDLEIBA promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public GAKLDONLFHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F26BB0", Offset = "0x6F25FB0", VA = "0x186F26BB0")]
		internal void KIIBHNIGLGC(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FIHCEHKEJMN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public KOGBHMMNAJA<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FIHCEHKEJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3476E50", Offset = "0x3476250", VA = "0x183476E50")]
		internal void KIIBHNIGLGC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9D90", Offset = "0x6E9190")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F26210", Offset = "0x6F25610", VA = "0x186F26210")]
	public static Task JLPLAMOEOLB(this CCKGNGCPCCF NKALOFFOGPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F26420", Offset = "0x6F25820", VA = "0x186F26420")]
	public static Task<bool> JLPLAMOEOLB(this CCKGNGCPCCF NKALOFFOGPL, CancellationToken DNKHCCGNODC, JINNJEMKGMG GDLFPBHGOJJ = JINNJEMKGMG.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x515E4E0", Offset = "0x515D8E0", VA = "0x18515E4E0")]
	public static Task<TResult> JLPLAMOEOLB<TResult>(this MCFFIFIPNKE<TResult> NKALOFFOGPL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x515E710", Offset = "0x515DB10", VA = "0x18515E710")]
	public static Task<TResult> JLPLAMOEOLB<TResult>(this MCFFIFIPNKE<TResult> NKALOFFOGPL, CancellationToken DNKHCCGNODC, JINNJEMKGMG GDLFPBHGOJJ = JINNJEMKGMG.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F261E0", Offset = "0x6F255E0", VA = "0x186F261E0")]
	public static TaskAwaiter JBBJLPCKEFJ(this CCKGNGCPCCF NKALOFFOGPL)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x515D610", Offset = "0x515CA10", VA = "0x18515D610")]
	public static TaskAwaiter<TResult> JBBJLPCKEFJ<TResult>(this MCFFIFIPNKE<TResult> NKALOFFOGPL) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F26970", Offset = "0x6F25D70", VA = "0x186F26970")]
	public static CCKGNGCPCCF MKJOPEDEMGO(this Task LPNIBKGOBIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x515FCA0", Offset = "0x515F0A0", VA = "0x18515FCA0")]
	public static MCFFIFIPNKE<TResult> MKJOPEDEMGO<TResult>(this Task<TResult> LPNIBKGOBIK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F267A0", Offset = "0x6F25BA0", VA = "0x186F267A0")]
	private static string LIBHCHEOHDD(Task LPNIBKGOBIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HPLBPNIMMDC : CCKGNGCPCCF, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NGDAMAGOOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BFFFAPFPOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEEOLLFJOAH();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPLBPNIMMDC OHHDFFIEIFP(Action DAEAGMNCDJC);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JMBPHECAAHP<T> : MCFFIFIPNKE<T>, CCKGNGCPCCF, IEnumerator, HPLBPNIMMDC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new JMBPHECAAHP<T> OHHDFFIEIFP(Action DAEAGMNCDJC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MIEBJEFPCMH : PFDOLDLEIBA, HPLBPNIMMDC, CCKGNGCPCCF, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> DAEAGMNCDJC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static HPLBPNIMMDC OPAJHKMHJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6F27BF0", Offset = "0x6F26FF0", VA = "0x186F27BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NGDAMAGOOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2DB20", Offset = "0xA2CF20", VA = "0x180A2DB20", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xF07F50", Offset = "0xF07350", VA = "0x180F07F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BFFFAPFPOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6F27CA0", Offset = "0x6F270A0", VA = "0x186F27CA0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F28010", Offset = "0x6F27410", VA = "0x186F28010")]
	static MIEBJEFPCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x12D0E20", Offset = "0x12D0220", VA = "0x1812D0E20")]
	public new static JMBPHECAAHP<T> PLJINLOCHGM<T>(T OHCLGKAJOMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x12D0E20", Offset = "0x12D0220", VA = "0x1812D0E20")]
	public new static JMBPHECAAHP<T> BPMPBOJFNCD<T>(string KDPCEEMNMDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F27D40", Offset = "0x6F27140", VA = "0x186F27D40", Slot = "21")]
	public void OEEOLLFJOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F27F90", Offset = "0x6F27390", VA = "0x186F27F90", Slot = "22")]
	public HPLBPNIMMDC OHHDFFIEIFP(Action HBIAEECAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F27C50", Offset = "0x6F27050", VA = "0x186F27C50", Slot = "18")]
	protected override void KPMHFMFLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F27CB0", Offset = "0x6F270B0", VA = "0x186F27CB0", Slot = "17")]
	public override CCKGNGCPCCF OCKKHGOEEJJ(Action KIPFAJLMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F28140", Offset = "0x6F27540", VA = "0x186F28140")]
	public MIEBJEFPCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9DF0", Offset = "0x6E91F0")]
public class BIMIECDBIKB<T> : KOGBHMMNAJA<T>, JMBPHECAAHP<T>, MCFFIFIPNKE<T>, CCKGNGCPCCF, IEnumerator, HPLBPNIMMDC where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> DAEAGMNCDJC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NGDAMAGOOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA828D0", Offset = "0xA81CD0", VA = "0x180A828D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA828E0", Offset = "0xA81CE0", VA = "0x180A828E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BFFFAPFPOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x24CDD10", Offset = "0x24CD110", VA = "0x1824CDD10", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x24CE120", Offset = "0x24CD520", VA = "0x1824CE120", Slot = "30")]
	public void OEEOLLFJOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x24CE430", Offset = "0x24CD830", VA = "0x1824CE430", Slot = "27")]
	public JMBPHECAAHP<T> OHHDFFIEIFP(Action HBIAEECAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x24CE590", Offset = "0x24CD990", VA = "0x1824CE590", Slot = "31")]
	private HPLBPNIMMDC PFMFKINMFMN(Action HBIAEECAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x24CDC30", Offset = "0x24CD030", VA = "0x1824CDC30", Slot = "26")]
	protected override void KPMHFMFLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x24CDD80", Offset = "0x24CD180", VA = "0x1824CDD80", Slot = "25")]
	public override MCFFIFIPNKE<T> OCKKHGOEEJJ(Action KIPFAJLMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x24CE670", Offset = "0x24CDA70", VA = "0x1824CE670")]
	public BIMIECDBIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KAPACFKLDDP : BBDKDGEPBPE, HPLBPNIMMDC, CCKGNGCPCCF, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> DAEAGMNCDJC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NGDAMAGOOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9E8FE0", Offset = "0x9E83E0", VA = "0x1809E8FE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA111F0", Offset = "0xA105F0", VA = "0x180A111F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool BFFFAPFPOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F27040", Offset = "0x6F26440", VA = "0x186F27040", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F27560", Offset = "0x6F26960", VA = "0x186F27560")]
	public KAPACFKLDDP(HPLBPNIMMDC NKALOFFOGPL, HPLBPNIMMDC HDEHOIBDFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F27680", Offset = "0x6F26A80", VA = "0x186F27680")]
	public KAPACFKLDDP(IList<HPLBPNIMMDC> BHPBNKHMFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F270E0", Offset = "0x6F264E0", VA = "0x186F270E0", Slot = "21")]
	public void OEEOLLFJOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F274E0", Offset = "0x6F268E0", VA = "0x186F274E0", Slot = "22")]
	public HPLBPNIMMDC OHHDFFIEIFP(Action HBIAEECAOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F26FF0", Offset = "0x6F263F0", VA = "0x186F26FF0", Slot = "18")]
	protected override void KPMHFMFLNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F27050", Offset = "0x6F26450", VA = "0x186F27050", Slot = "17")]
	public override CCKGNGCPCCF OCKKHGOEEJJ(Action KIPFAJLMMPC)
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
