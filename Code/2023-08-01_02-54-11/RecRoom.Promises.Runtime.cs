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
		[Cpp2IlInjected.Address(RVA = "0x8484E0", Offset = "0x8474E0", VA = "0x1808484E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x724BE20", Offset = "0x724AE20", VA = "0x18724BE20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB36FF0", Offset = "0xB35FF0", VA = "0x180B36FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183B060", Offset = "0x183A060", VA = "0x18183B060")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JELCGAACIKH : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly string BHDDGODAIJC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x724A5A0", Offset = "0x72495A0", VA = "0x18724A5A0")]
	public JELCGAACIKH(string FANKIHBOOPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736280", Offset = "0x735680")]
public class ONOMMJCBBDI<T1, T2> : BIMBCAIOAGD<Tuple<T1, T2>> where T1 : notnull where T2 : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PNKOHLLKINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7362F0", Offset = "0x7356F0")]
		public LJAJHHFEMAM<T2> p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public ONOMMJCBBDI<T1, T2> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public PNKOHLLKINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B560", Offset = "0x1E7A560", VA = "0x181E7B560")]
		internal void AMPEBIDKAFP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KLLDDABCDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PNKOHLLKINN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public KLLDDABCDIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x35E7330", Offset = "0x35E6330", VA = "0x1835E7330")]
		internal void DFBJNOFIBEH(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D059E0", Offset = "0x2D049E0", VA = "0x182D059E0")]
	public ONOMMJCBBDI(LJAJHHFEMAM<T1> JLMLLJKBGHN, LJAJHHFEMAM<T2> ECFFNCICCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D05970", Offset = "0x2D04970", VA = "0x182D05970")]
	private void DOBHKKEKDAM(string NAFECGLLOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736370", Offset = "0x735770")]
public class CCBMKBMDABO<T1, T2, T3> : BIMBCAIOAGD<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NBNFOHMIFHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7363E0", Offset = "0x7357E0")]
		public LJAJHHFEMAM<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736440", Offset = "0x735840")]
		public LJAJHHFEMAM<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CCBMKBMDABO<T1, T2, T3> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public NBNFOHMIFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B810", Offset = "0x1E7A810", VA = "0x181E7B810")]
		internal void AMPEBIDKAFP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BDJAMKBMMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NBNFOHMIFHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public BDJAMKBMMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x245E5D0", Offset = "0x245D5D0", VA = "0x18245E5D0")]
		internal void DFBJNOFIBEH(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DHHAAPGGAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BDJAMKBMMIP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public DHHAAPGGAOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37C4E20", Offset = "0x37C3E20", VA = "0x1837C4E20")]
		internal void MCILLHEKNJJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDCBB0", Offset = "0x2CDBBB0", VA = "0x182CDCBB0")]
	public CCBMKBMDABO(LJAJHHFEMAM<T1> JLMLLJKBGHN, LJAJHHFEMAM<T2> ECFFNCICCNK, LJAJHHFEMAM<T3> LKFJKMONDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDC860", Offset = "0x2CDB860", VA = "0x182CDC860")]
	private void DOBHKKEKDAM(string NAFECGLLOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7364A0", Offset = "0x7358A0")]
public class HOPEMLFMLMC<T1, T2, T3, T4, T5> : BIMBCAIOAGD<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MABPPCGHCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736510", Offset = "0x735910")]
		public LJAJHHFEMAM<T2?>? p2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736570", Offset = "0x735970")]
		public LJAJHHFEMAM<T3?>? p3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7365D0", Offset = "0x7359D0")]
		public LJAJHHFEMAM<T4?>? p4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736630", Offset = "0x735A30")]
		public LJAJHHFEMAM<T5?>? p5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public HOPEMLFMLMC<T1, T2, T3, T4, T5> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public MABPPCGHCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B690", Offset = "0x1E7A690", VA = "0x181E7B690")]
		internal void AMPEBIDKAFP(T1 r1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class INFNIOPONBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public T1 r1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public MABPPCGHCJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public INFNIOPONBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x245E5D0", Offset = "0x245D5D0", VA = "0x18245E5D0")]
		internal void DFBJNOFIBEH(T2 r2)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EHLOIEMFJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T2 r2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public INFNIOPONBP CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public EHLOIEMFJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27CFDD0", Offset = "0x27CEDD0", VA = "0x1827CFDD0")]
		internal void MCILLHEKNJJ(T3 r3)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class CGCGDKKNNGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T3 r3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public EHLOIEMFJND CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public CGCGDKKNNGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21726C0", Offset = "0x21716C0", VA = "0x1821726C0")]
		internal void FMDBHELDEHD(T4 r4)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class HDGPLIKEJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public T4 r4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CGCGDKKNNGD CS$<>8__locals4;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public HDGPLIKEJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2CED290", Offset = "0x2CEC290", VA = "0x182CED290")]
		internal void DAEPDOMLKAL(T5 r5)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3520F60", Offset = "0x351FF60", VA = "0x183520F60")]
	public HOPEMLFMLMC(LJAJHHFEMAM<T1> JLMLLJKBGHN, LJAJHHFEMAM<T2> ECFFNCICCNK, LJAJHHFEMAM<T3> LKFJKMONDPL, LJAJHHFEMAM<T4> NPKFAGKMGHF, LJAJHHFEMAM<T5> GLDJKCOAPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3520EF0", Offset = "0x351FEF0", VA = "0x183520EF0")]
	private void DOBHKKEKDAM(string NAFECGLLOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736690", Offset = "0x735A90")]
public class HENKIIOGJCA<T> : BIMBCAIOAGD<List<T>> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DIPDNDPCIAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int promiseI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HENKIIOGJCA<T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public DIPDNDPCIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37CBC40", Offset = "0x37CAC40", VA = "0x1837CBC40")]
		internal void AMPEBIDKAFP(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736700", Offset = "0x735B00")]
	private readonly T[] OGDNOIHPLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JCFCONOGHHM;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2CF74E0", Offset = "0x2CF64E0", VA = "0x182CF74E0")]
	public HENKIIOGJCA(List<LJAJHHFEMAM<T>> JDIFAHKPKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7470", Offset = "0x2CF6470", VA = "0x182CF7470")]
	private void DOBHKKEKDAM(string NAFECGLLOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IMAEIHEHPGA : JIPDPKKGEMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int JJFDKIPDIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	protected readonly IReadOnlyList<FHJJKILLDME> JDIFAHKPKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly List<string> ECACENCOOKJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7249840", Offset = "0x7248840", VA = "0x187249840")]
	public IMAEIHEHPGA(params FHJJKILLDME[] JDIFAHKPKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7249850", Offset = "0x7248850", VA = "0x187249850")]
	public IMAEIHEHPGA(IReadOnlyList<FHJJKILLDME> JDIFAHKPKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7249750", Offset = "0x7248750", VA = "0x187249750")]
	private void NGJHNHFFPMN(string LLOHDPHNJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72497B0", Offset = "0x72487B0", VA = "0x1872497B0")]
	private void PGJJKHPFEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JOIHFGICLLC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override string EKCDKHJMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D37F40", Offset = "0x2D36F40", VA = "0x182D37F40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x724B600", Offset = "0x724A600", VA = "0x18724B600")]
	public JOIHFGICLLC(Exception LBCOELDFNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x724B570", Offset = "0x724A570", VA = "0x18724B570")]
	private static string MCNBBFMDCKE(Exception LBCOELDFNJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JIPDPKKGEMC : FHJJKILLDME, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BDBJOKELOHA<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736880", Offset = "0x735C80")]
		public Func<string, LJAJHHFEMAM<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7368E0", Offset = "0x735CE0")]
		public Func<LJAJHHFEMAM<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736940", Offset = "0x735D40")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7369A0", Offset = "0x735DA0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public BDBJOKELOHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2E40DB0", Offset = "0x2E3FDB0", VA = "0x182E40DB0")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void PJAPEFCDNOP(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2E3FFA0", Offset = "0x2E3EFA0", VA = "0x182E3FFA0")]
		internal void EFPDJHDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void DHJKPDAIFOC(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HIEHEPACPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736A00", Offset = "0x735E00")]
		public Func<string, FHJJKILLDME> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public JIPDPKKGEMC newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736A60", Offset = "0x735E60")]
		public Func<FHJJKILLDME> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736AC0", Offset = "0x735EC0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736B20", Offset = "0x735F20")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public HIEHEPACPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72492B0", Offset = "0x72482B0", VA = "0x1872492B0")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void PJAPEFCDNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7249140", Offset = "0x7248140", VA = "0x187249140")]
		internal void EFPDJHDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void DHJKPDAIFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CNPBIJLEJMO<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public CNPBIJLEJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13517D0", Offset = "0x13507D0", VA = "0x1813517D0")]
		internal void LPKLOIJJLBP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1351630", Offset = "0x1350630", VA = "0x181351630")]
		internal void IMBFACGHNLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AFLHLPNGFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JIPDPKKGEMC newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736B80", Offset = "0x735F80")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AFLHLPNGFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7248F90", Offset = "0x7247F90", VA = "0x187248F90")]
		internal void DONCGGDHEAP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xB1EE40", Offset = "0xB1DE40", VA = "0x180B1EE40")]
		internal void EPIOKLECFMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string BKIBMBHLGEP = "Cancelled";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly List<Action<string>> KDLPOAHPPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<Action> DNINMGGECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly List<Action> EBMHOHLJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private string? NAFECGLLOCD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FHJJKILLDME OLENOJLOLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x724ADD0", Offset = "0x7249DD0", VA = "0x18724ADD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030E00", VA = "0x181031E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x960870", Offset = "0x95F870", VA = "0x180960870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LFEJJFEONDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x724AD40", Offset = "0x7249D40", VA = "0x18724AD40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ICBPFLGKAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x724B3E0", Offset = "0x724A3E0", VA = "0x18724B3E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x724B400", Offset = "0x724A400", VA = "0x18724B400")]
	static JIPDPKKGEMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20B8B90", Offset = "0x20B7B90", VA = "0x1820B8B90")]
	public static LJAJHHFEMAM<T> IENJBFHJDJJ<T>(T MLAOHBBKEKK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x724AD60", Offset = "0x7249D60", VA = "0x18724AD60")]
	public static FHJJKILLDME HAKLPKIDDPL(string NAFECGLLOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20B8B90", Offset = "0x20B7B90", VA = "0x1820B8B90")]
	public static LJAJHHFEMAM<T> HAKLPKIDDPL<T>(string NAFECGLLOCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x724ACA0", Offset = "0x7249CA0", VA = "0x18724ACA0", Slot = "8")]
	public FHJJKILLDME EILBBHKJBJH(Action<string> OECAANMAGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x724A940", Offset = "0x7249940", VA = "0x18724A940", Slot = "17")]
	public virtual FHJJKILLDME EICCINPHOCB(Action ADIHNLLPAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x724A8B0", Offset = "0x72498B0", VA = "0x18724A8B0", Slot = "7")]
	public FHJJKILLDME EBJMELBFAKK(Action DEPDPNNFFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20B9570", Offset = "0x20B8570", VA = "0x1820B9570", Slot = "10")]
	public LJAJHHFEMAM<TNew> IELENHMOIGH<TNew>(Func<LJAJHHFEMAM<TNew>> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7367C0", Offset = "0x735BC0")] Func<string, LJAJHHFEMAM<TNew>> HGDEGIONDBH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x724AE30", Offset = "0x7249E30", VA = "0x18724AE30", Slot = "11")]
	public FHJJKILLDME IELENHMOIGH(Func<FHJJKILLDME> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736820", Offset = "0x735C20")] Func<string, FHJJKILLDME> HGDEGIONDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x20BA080", Offset = "0x20B9080", VA = "0x1820BA080", Slot = "12")]
	public LJAJHHFEMAM<TNew> NLACIKINHKF<TNew>(Func<TNew> DNIPIEIONDB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x724A620", Offset = "0x7249620", VA = "0x18724A620", Slot = "13")]
	public FHJJKILLDME AAHNKCGBCLJ(Func<string, string> DNIPIEIONDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62EE3A0", Offset = "0x62ED3A0", VA = "0x1862EE3A0", Slot = "14")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "16")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x724B190", Offset = "0x724A190", VA = "0x18724B190")]
	public void OHNMHKDFAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x724A9C0", Offset = "0x72499C0", VA = "0x18724A9C0")]
	public void EILBBHKJBJH(string FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x724B050", Offset = "0x724A050", VA = "0x18724B050")]
	protected Exception? MIDJOHHHMHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x724A830", Offset = "0x7249830", VA = "0x18724A830", Slot = "18")]
	protected virtual void DGNNEFBPDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x724B470", Offset = "0x724A470", VA = "0x18724B470")]
	public JIPDPKKGEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BIMBCAIOAGD<T> : LJAJHHFEMAM<T>, FHJJKILLDME, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private struct BKDJKHMJCHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736DC0", Offset = "0x7361C0")]
		public readonly Action<T> NPNCNABHINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly Action? HLGFPEOADPB;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xC0C2D0", Offset = "0xC0B2D0", VA = "0x180C0C2D0")]
		public BKDJKHMJCHG(Action<T> NPNCNABHINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xC0C9F0", Offset = "0xC0B9F0", VA = "0x180C0C9F0")]
		public BKDJKHMJCHG(Action HLGFPEOADPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x263CCD0", Offset = "0x263BCD0", VA = "0x18263CCD0")]
		public void GEHFLMKLAJC(T KPMKPNDNMBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MMJDJCPFPIL<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736E20", Offset = "0x736220")]
		public Func<string, LJAJHHFEMAM<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736E80", Offset = "0x736280")]
		public Func<LJAJHHFEMAM<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736EE0", Offset = "0x7362E0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736F40", Offset = "0x736340")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public MMJDJCPFPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x33B9190", Offset = "0x33B8190", VA = "0x1833B9190")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void PJAPEFCDNOP(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x33B5A10", Offset = "0x33B4A10", VA = "0x1833B5A10")]
		internal void EFPDJHDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void DHJKPDAIFOC(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FLIJHMDFICK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736FA0", Offset = "0x7363A0")]
		public Func<string, FHJJKILLDME> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JIPDPKKGEMC newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737000", Offset = "0x736400")]
		public Func<FHJJKILLDME> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737060", Offset = "0x736460")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7370C0", Offset = "0x7364C0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public FLIJHMDFICK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x40A2DA0", Offset = "0x40A1DA0", VA = "0x1840A2DA0")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void PJAPEFCDNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x409D700", Offset = "0x409C700", VA = "0x18409D700")]
		internal void EFPDJHDGGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void DHJKPDAIFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IIPDOBOOKOK<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737120", Offset = "0x736520")]
		public Func<string, LJAJHHFEMAM<TNew>> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737180", Offset = "0x736580")]
		public Func<T, LJAJHHFEMAM<TNew>> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7371E0", Offset = "0x7365E0")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Action<TNew> <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737240", Offset = "0x736640")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Action<TNew> <>9__5;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public IIPDOBOOKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2450F50", Offset = "0x244FF50", VA = "0x182450F50")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void PJAPEFCDNOP(TNew r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x244E960", Offset = "0x244D960", VA = "0x18244E960")]
		internal void EFPDJHDGGCI(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2454790", Offset = "0x2453790", VA = "0x182454790")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x244D010", Offset = "0x244C010", VA = "0x18244D010")]
		internal void DHJKPDAIFOC(TNew r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ALHJPDMCDJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7372A0", Offset = "0x7366A0")]
		public Func<string, FHJJKILLDME> transformErrorFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public JIPDPKKGEMC newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737300", Offset = "0x736700")]
		public Func<T, FHJJKILLDME> transformFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737360", Offset = "0x736760")]
		public Action<string> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action <>9__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7373C0", Offset = "0x7367C0")]
		public Action<string> <>9__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action <>9__5;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public ALHJPDMCDJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x35128C0", Offset = "0x35118C0", VA = "0x1835128C0")]
		internal void HAALHEFCLOF(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void OIKMCODNKCP(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void PJAPEFCDNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x350CDF0", Offset = "0x350BDF0", VA = "0x18350CDF0")]
		internal void EFPDJHDGGCI(T result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1661570", Offset = "0x1660570", VA = "0x181661570")]
		internal void PGDPPFHOHBD(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xCC2920", Offset = "0xCC1920", VA = "0x180CC2920")]
		internal void DHJKPDAIFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class ELHMBAJJFOJ<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Func<TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public ELHMBAJJFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x13517D0", Offset = "0x13507D0", VA = "0x1813517D0")]
		internal void LPKLOIJJLBP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1351630", Offset = "0x1350630", VA = "0x181351630")]
		internal void IMBFACGHNLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GOLKFDCLOPG<TNew> where TNew : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BIMBCAIOAGD<TNew> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737420", Offset = "0x736820")]
		public Func<T, TNew> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public GOLKFDCLOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x13517D0", Offset = "0x13507D0", VA = "0x1813517D0")]
		internal void LPKLOIJJLBP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x25D26C0", Offset = "0x25D16C0", VA = "0x1825D26C0")]
		internal void IMBFACGHNLP(T result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GNNEIJNOAGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JIPDPKKGEMC newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737480", Offset = "0x736880")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public GNNEIJNOAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x25CFF60", Offset = "0x25CEF60", VA = "0x1825CFF60")]
		internal void IOMALJODMOL(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB1EE40", Offset = "0xB1DE40", VA = "0x180B1EE40")]
		internal void FJGEGODFJLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class POKFLIJDHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7374E0", Offset = "0x7368E0")]
		public BIMBCAIOAGD<T> newPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737540", Offset = "0x736940")]
		public Func<string, string> transformFunc;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public POKFLIJDHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E7EFD0", Offset = "0x1E7DFD0", VA = "0x181E7EFD0")]
		internal void DONCGGDHEAP(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E2A6F0", Offset = "0x1E296F0", VA = "0x181E2A6F0")]
		internal void EPIOKLECFMD(T result)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736BE0", Offset = "0x735FE0")]
	private readonly List<BIMBCAIOAGD<T>.BKDJKHMJCHG> EBMHOHLJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<Action<string>> KDLPOAHPPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Action> DNINMGGECON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private string? NAFECGLLOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T MLAOHBBKEKK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB87710", Offset = "0xB86710", VA = "0x180B87710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB87720", Offset = "0xB86720", VA = "0x180B87720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LFEJJFEONDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3FA81E0", Offset = "0x3FA71E0", VA = "0x183FA81E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ICBPFLGKAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3FB0630", Offset = "0x3FAF630", VA = "0x183FB0630", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	object? IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8260", Offset = "0x3FA7260", VA = "0x183FA8260")]
	public static LJAJHHFEMAM<T> HAKLPKIDDPL(string FANKIHBOOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA74C0", Offset = "0x3FA64C0", VA = "0x183FA74C0", Slot = "6")]
	public LJAJHHFEMAM<T> EILBBHKJBJH(Action<string> OECAANMAGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3EE0", Offset = "0x3FA2EE0", VA = "0x183FA3EE0", Slot = "25")]
	public virtual LJAJHHFEMAM<T> EICCINPHOCB(Action ADIHNLLPAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2FB0", Offset = "0x3FA1FB0", VA = "0x183FA2FB0", Slot = "5")]
	public LJAJHHFEMAM<T> EBJMELBFAKK(Action DEPDPNNFFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3170", Offset = "0x3FA2170", VA = "0x183FA3170", Slot = "4")]
	public LJAJHHFEMAM<T> EBJMELBFAKK(Action<T> DEPDPNNFFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x25BB6A0", Offset = "0x25BA6A0", VA = "0x1825BB6A0", Slot = "18")]
	public LJAJHHFEMAM<TNew> IELENHMOIGH<TNew>(Func<LJAJHHFEMAM<TNew>> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736C40", Offset = "0x736040")] Func<string, LJAJHHFEMAM<TNew>> HGDEGIONDBH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8AC0", Offset = "0x3FA7AC0", VA = "0x183FA8AC0", Slot = "19")]
	public FHJJKILLDME IELENHMOIGH(Func<FHJJKILLDME> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736CA0", Offset = "0x7360A0")] Func<string, FHJJKILLDME> HGDEGIONDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A6A0", Offset = "0x2B296A0", VA = "0x182B2A6A0", Slot = "8")]
	public LJAJHHFEMAM<TNew> IELENHMOIGH<TNew>(Func<T, LJAJHHFEMAM<TNew>> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736D00", Offset = "0x736100")] Func<string, LJAJHHFEMAM<TNew>> HGDEGIONDBH) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8700", Offset = "0x3FA7700", VA = "0x183FA8700", Slot = "9")]
	public FHJJKILLDME IELENHMOIGH(Func<T, FHJJKILLDME> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736D60", Offset = "0x736160")] Func<string, FHJJKILLDME> HGDEGIONDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x25C5030", Offset = "0x25C4030", VA = "0x1825C5030", Slot = "20")]
	public LJAJHHFEMAM<TNew> NLACIKINHKF<TNew>(Func<TNew> DNIPIEIONDB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B36580", Offset = "0x2B35580", VA = "0x182B36580", Slot = "10")]
	public LJAJHHFEMAM<TNew> NLACIKINHKF<TNew>(Func<T, TNew> DNIPIEIONDB) where TNew : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3FB12C0", Offset = "0x3FB02C0", VA = "0x183FB12C0", Slot = "21")]
	private FHJJKILLDME PNBBJFNOHIE(Func<string, string> DNIPIEIONDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3FA14E0", Offset = "0x3FA04E0", VA = "0x183FA14E0", Slot = "11")]
	public LJAJHHFEMAM<T> AAHNKCGBCLJ(Func<string, string> DNIPIEIONDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3FB20C0", Offset = "0x3FB10C0", VA = "0x183FB20C0", Slot = "22")]
	bool IEnumerator.MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "24")]
	void IEnumerator.Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2CAEA80", Offset = "0x2CADA80", VA = "0x182CAEA80", Slot = "15")]
	private FHJJKILLDME JOOOJMDGLNJ(Action DEPDPNNFFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1857A10", Offset = "0x1856A10", VA = "0x181857A10", Slot = "16")]
	private FHJJKILLDME MCIGGINKADD(Action<string> OECAANMAGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8230", Offset = "0x3FA7230", VA = "0x183FA8230", Slot = "17")]
	private FHJJKILLDME GMJOAMAIAMI(Action ADIHNLLPAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3FAF8D0", Offset = "0x3FAE8D0", VA = "0x183FAF8D0")]
	public void OHNMHKDFAKC(T KPMKPNDNMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3FACEE0", Offset = "0x3FABEE0", VA = "0x183FACEE0")]
	protected Exception? MIDJOHHHMHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3FA5620", Offset = "0x3FA4620", VA = "0x183FA5620")]
	public void EILBBHKJBJH(string FANKIHBOOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2970", Offset = "0x3FA1970", VA = "0x183FA2970", Slot = "26")]
	protected virtual void DGNNEFBPDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FB2F30", Offset = "0x3FB1F30", VA = "0x183FB2F30")]
	public BIMBCAIOAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FHJJKILLDME : IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LFEJJFEONDK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ICBPFLGKAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FHJJKILLDME EBJMELBFAKK(Action DEPDPNNFFAB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHJJKILLDME EILBBHKJBJH(Action<string> OECAANMAGPP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHJJKILLDME EICCINPHOCB(Action ADIHNLLPAMF);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LJAJHHFEMAM<TNew> IELENHMOIGH<TNew>(Func<LJAJHHFEMAM<TNew>> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7375A0", Offset = "0x7369A0")] Func<string, LJAJHHFEMAM<TNew>> HGDEGIONDBH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FHJJKILLDME IELENHMOIGH(Func<FHJJKILLDME> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737600", Offset = "0x736A00")] Func<string, FHJJKILLDME> HGDEGIONDBH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LJAJHHFEMAM<TNew> NLACIKINHKF<TNew>(Func<TNew> DNIPIEIONDB) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FHJJKILLDME AAHNKCGBCLJ(Func<string, string> DNIPIEIONDB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LJAJHHFEMAM<out T> : FHJJKILLDME, IEnumerator where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LJAJHHFEMAM<T> EBJMELBFAKK(Action<T> DEPDPNNFFAB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	new LJAJHHFEMAM<T> EBJMELBFAKK(Action DEPDPNNFFAB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	new LJAJHHFEMAM<T> EILBBHKJBJH(Action<string> OECAANMAGPP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	new LJAJHHFEMAM<T> EICCINPHOCB(Action ADIHNLLPAMF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LJAJHHFEMAM<TNew> IELENHMOIGH<TNew>(Func<T, LJAJHHFEMAM<TNew>> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737660", Offset = "0x736A60")] Func<string, LJAJHHFEMAM<TNew>> HGDEGIONDBH) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHJJKILLDME IELENHMOIGH(Func<T, FHJJKILLDME> DNIPIEIONDB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7376C0", Offset = "0x736AC0")] Func<string, FHJJKILLDME> HGDEGIONDBH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LJAJHHFEMAM<TNew> NLACIKINHKF<TNew>(Func<T, TNew> DNIPIEIONDB) where TNew : notnull;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	new LJAJHHFEMAM<T> AAHNKCGBCLJ(Func<string, string> DNIPIEIONDB);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ACHDMAINKIA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum GJJDKCFGMCE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		CancelWithDefaultToken,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		CompleteTaskWithResultFalse,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ThrowException
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class DADCGPMGIIB : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72490D0", Offset = "0x72480D0", VA = "0x1872490D0")]
		public DADCGPMGIIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LOKGMPGNMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LOKGMPGNMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x724B780", Offset = "0x724A780", VA = "0x18724B780")]
		internal void MOPDECGDKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x724B6F0", Offset = "0x724A6F0", VA = "0x18724B6F0")]
		internal void EECBGFNICHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x724B7D0", Offset = "0x724A7D0", VA = "0x18724B7D0")]
		internal void OJLDLIGNEJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IEJAFOOKDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public BFCCHDPGONK cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GJJDKCFGMCE unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public IEJAFOOKDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7249660", Offset = "0x7248660", VA = "0x187249660")]
		internal void MOPDECGDKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7249440", Offset = "0x7248440", VA = "0x187249440")]
		internal void EECBGFNICHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72496B0", Offset = "0x72486B0", VA = "0x1872496B0")]
		internal void OJLDLIGNEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72494D0", Offset = "0x72484D0", VA = "0x1872494D0")]
		internal void GJFIENDLDIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NGDNGEEKLOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NGDNGEEKLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x232C8C0", Offset = "0x232B8C0", VA = "0x18232C8C0")]
		internal void JEGICHJMGPH(Task<bool> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MLOKCCHFDAM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public MLOKCCHFDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2695070", Offset = "0x2694070", VA = "0x182695070")]
		internal void MOPDECGDKBN(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x483AC60", Offset = "0x4839C60", VA = "0x18483AC60")]
		internal void EECBGFNICHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2341410", Offset = "0x2340410", VA = "0x182341410")]
		internal void OJLDLIGNEJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IMLEMHGBEFG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public BFCCHDPGONK cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GJJDKCFGMCE unexpectedCancellationHandleMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public IMLEMHGBEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x245DD90", Offset = "0x245CD90", VA = "0x18245DD90")]
		internal void MOPDECGDKBN(TResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x245D9F0", Offset = "0x245C9F0", VA = "0x18245D9F0")]
		internal void EECBGFNICHN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x245DE90", Offset = "0x245CE90", VA = "0x18245DE90")]
		internal void OJLDLIGNEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x245DC60", Offset = "0x245CC60", VA = "0x18245DC60")]
		internal void GJFIENDLDIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class AKGGJJODCMK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public AKGGJJODCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x232C8C0", Offset = "0x232B8C0", VA = "0x18232C8C0")]
		internal void JEGICHJMGPH(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AFPAONHKPBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JIPDPKKGEMC promise;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AFPAONHKPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7249010", Offset = "0x7248010", VA = "0x187249010")]
		internal void CNADAHDBLFE(Task t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FBIJNDFLPEO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public BIMBCAIOAGD<TResult> promise;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public FBIJNDFLPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xEE4F50", Offset = "0xEE3F50", VA = "0x180EE4F50")]
		internal void CNADAHDBLFE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737760", Offset = "0x736B60")] Task<TResult> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7248D80", Offset = "0x7247D80", VA = "0x187248D80")]
	public static Task MOKNBGJACBO(this FHJJKILLDME EPKNGPIMMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7248A00", Offset = "0x7247A00", VA = "0x187248A00")]
	public static Task<bool> MOKNBGJACBO(this FHJJKILLDME EPKNGPIMMHD, CancellationToken AOAEIGNDKPI, GJJDKCFGMCE KCGBOHDCBKE = GJJDKCFGMCE.CancelWithDefaultToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xE232A0", Offset = "0xE222A0", VA = "0x180E232A0")]
	public static Task<TResult> MOKNBGJACBO<TResult>(this LJAJHHFEMAM<TResult> EPKNGPIMMHD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A212C0", Offset = "0x2A202C0", VA = "0x182A212C0")]
	public static Task<TResult> MOKNBGJACBO<TResult>(this LJAJHHFEMAM<TResult> EPKNGPIMMHD, CancellationToken AOAEIGNDKPI, GJJDKCFGMCE KCGBOHDCBKE = GJJDKCFGMCE.CancelWithDefaultToken) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7248800", Offset = "0x7247800", VA = "0x187248800")]
	public static TaskAwaiter CLBNKIPBPIG(this FHJJKILLDME EPKNGPIMMHD)
	{
		return default(TaskAwaiter);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xE21B10", Offset = "0xE20B10", VA = "0x180E21B10")]
	public static TaskAwaiter<TResult> CLBNKIPBPIG<TResult>(this LJAJHHFEMAM<TResult> EPKNGPIMMHD) where TResult : notnull
	{
		return default(TaskAwaiter<TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7248830", Offset = "0x7247830", VA = "0x187248830")]
	public static FHJJKILLDME HAACNGGHCCK(this Task KMKKLLICGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xE21B50", Offset = "0xE20B50", VA = "0x180E21B50")]
	public static LJAJHHFEMAM<TResult> HAACNGGHCCK<TResult>(this Task<TResult> KMKKLLICGID) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7248630", Offset = "0x7247630", VA = "0x187248630")]
	private static string BCKEALCEBDI(Task KMKKLLICGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BFCCHDPGONK : FHJJKILLDME, IEnumerator
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FEAOEMNFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool MANAIKIGNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NICHPHNHEPJ();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BFCCHDPGONK FHIJADBAIFN(Action ABPFPCEIBJF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JMFMBNJIIGP<T> : LJAJHHFEMAM<T>, FHJJKILLDME, IEnumerator, BFCCHDPGONK
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new JMFMBNJIIGP<T> FHIJADBAIFN(Action ABPFPCEIBJF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NMMDBNHKACP : JIPDPKKGEMC, BFCCHDPGONK, FHJJKILLDME, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly List<Action> ABPFPCEIBJF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static BFCCHDPGONK DBPNPLDLODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x724B990", Offset = "0x724A990", VA = "0x18724B990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FEAOEMNFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xB87710", Offset = "0xB86710", VA = "0x180B87710", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xB87720", Offset = "0xB86720", VA = "0x180B87720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MANAIKIGNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x724B980", Offset = "0x724A980", VA = "0x18724B980", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x724BC40", Offset = "0x724AC40", VA = "0x18724BC40")]
	static NMMDBNHKACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20B8B90", Offset = "0x20B7B90", VA = "0x1820B8B90")]
	public new static JMFMBNJIIGP<T> IENJBFHJDJJ<T>(T MLAOHBBKEKK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20B8B90", Offset = "0x20B7B90", VA = "0x1820B8B90")]
	public new static JMFMBNJIIGP<T> HAKLPKIDDPL<T>(string NAFECGLLOCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x724B9F0", Offset = "0x724A9F0", VA = "0x18724B9F0", Slot = "21")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x724B900", Offset = "0x724A900", VA = "0x18724B900", Slot = "22")]
	public BFCCHDPGONK FHIJADBAIFN(Action IOICEDOPMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x724B820", Offset = "0x724A820", VA = "0x18724B820", Slot = "18")]
	protected override void DGNNEFBPDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x724B870", Offset = "0x724A870", VA = "0x18724B870", Slot = "17")]
	public override FHJJKILLDME EICCINPHOCB(Action ADIHNLLPAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x724BD70", Offset = "0x724AD70", VA = "0x18724BD70")]
	public NMMDBNHKACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7377C0", Offset = "0x736BC0")]
public class OIGNFCHMFGA<T> : BIMBCAIOAGD<T>, JMFMBNJIIGP<T>, LJAJHHFEMAM<T>, FHJJKILLDME, IEnumerator, BFCCHDPGONK where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly List<Action> ABPFPCEIBJF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FEAOEMNFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA85EF0", Offset = "0xA84EF0", VA = "0x180A85EF0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA85F00", Offset = "0xA84F00", VA = "0x180A85F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool MANAIKIGNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x25DAB60", Offset = "0x25D9B60", VA = "0x1825DAB60", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x25DABD0", Offset = "0x25D9BD0", VA = "0x1825DABD0", Slot = "30")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x25DA9D0", Offset = "0x25D99D0", VA = "0x1825DA9D0", Slot = "27")]
	public JMFMBNJIIGP<T> FHIJADBAIFN(Action IOICEDOPMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x25DAB30", Offset = "0x25D9B30", VA = "0x1825DAB30", Slot = "31")]
	private BFCCHDPGONK HIJPAAHICBB(Action IOICEDOPMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x25DA8D0", Offset = "0x25D98D0", VA = "0x1825DA8D0", Slot = "26")]
	protected override void DGNNEFBPDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x25DA940", Offset = "0x25D9940", VA = "0x1825DA940", Slot = "25")]
	public override LJAJHHFEMAM<T> EICCINPHOCB(Action ADIHNLLPAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x25DB2A0", Offset = "0x25DA2A0", VA = "0x1825DB2A0")]
	public OIGNFCHMFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IMIONNKNCFP : IMAEIHEHPGA, BFCCHDPGONK, FHJJKILLDME, IEnumerator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly List<Action> ABPFPCEIBJF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FEAOEMNFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x921680", Offset = "0x920680", VA = "0x180921680", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA26D50", Offset = "0xA25D50", VA = "0x180A26D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MANAIKIGNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7249DB0", Offset = "0x7248DB0", VA = "0x187249DB0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x724A1C0", Offset = "0x72491C0", VA = "0x18724A1C0")]
	public IMIONNKNCFP(BFCCHDPGONK EPKNGPIMMHD, BFCCHDPGONK FMDGJMLEMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x724A2E0", Offset = "0x72492E0", VA = "0x18724A2E0")]
	public IMIONNKNCFP(IList<BFCCHDPGONK> JDIFAHKPKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7249DC0", Offset = "0x7248DC0", VA = "0x187249DC0", Slot = "21")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7249D30", Offset = "0x7248D30", VA = "0x187249D30", Slot = "22")]
	public BFCCHDPGONK FHIJADBAIFN(Action IOICEDOPMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7249C50", Offset = "0x7248C50", VA = "0x187249C50", Slot = "18")]
	protected override void DGNNEFBPDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7249CA0", Offset = "0x7248CA0", VA = "0x187249CA0", Slot = "17")]
	public override FHJJKILLDME EICCINPHOCB(Action ADIHNLLPAMF)
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
