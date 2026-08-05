using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EAF460", Offset = "0x6EAE860", VA = "0x186EAF460")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MFLICMKBFDF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4140", Offset = "0x2CA3540", VA = "0x182CA4140")]
	public static ODADIOPEEKI<T> FFIDJLHNONP<T>(this T[] MCPMOAEEEOJ) where T : notnull
	{
		return default(ODADIOPEEKI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class KEMCFGFAFEA<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OCJDOODMLMI<T> BAIKAGNNDHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4500D10", Offset = "0x4500110", VA = "0x184500D10", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4500D50", Offset = "0x4500150", VA = "0x184500D50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4500AF0", Offset = "0x44FFEF0", VA = "0x184500AF0")]
	public static KEMCFGFAFEA<T> AHLALEPNKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F474F0", Offset = "0x3F468F0", VA = "0x183F474F0")]
	internal KEMCFGFAFEA([In] OCJDOODMLMI<T> JPNNGBEFPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4500C30", Offset = "0x4500030", VA = "0x184500C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4500C70", Offset = "0x4500070", VA = "0x184500C70")]
	public void ELHHBEOCNEP(int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4500CB0", Offset = "0x45000B0", VA = "0x184500CB0", Slot = "8")]
	public OCJDOODMLMI<T>.BNECBIPLLHC GetEnumerator()
	{
		return default(OCJDOODMLMI<T>.BNECBIPLLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4500D90", Offset = "0x4500190", VA = "0x184500D90", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4500D90", Offset = "0x4500190", VA = "0x184500D90", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BLCANMHGPBP<T, U> : IEnumerable<T>, IEnumerable where U : LFHDHADKFJP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U ELMPNGIJBEK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
	internal BLCANMHGPBP([In] U ADGILLNPFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x442C870", Offset = "0x442BC70", VA = "0x18442C870", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x442C870", Offset = "0x442BC70", VA = "0x18442C870", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BPIHOLHGCFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2CF78A0", Offset = "0x2CF6CA0", VA = "0x182CF78A0")]
	public static BLCANMHGPBP<T, U> AHLALEPNKFA<U>([In] U MCPMOAEEEOJ) where U : LFHDHADKFJP<T>
	{
		return default(BLCANMHGPBP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JNMOIDIJNBK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U ELMPNGIJBEK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B78780", Offset = "0x3B77B80", VA = "0x183B78780")]
	internal JNMOIDIJNBK([In] U ADGILLNPFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD42FF0", Offset = "0xD423F0", VA = "0x180D42FF0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x442C6D0", Offset = "0x442BAD0", VA = "0x18442C6D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x442C6D0", Offset = "0x442BAD0", VA = "0x18442C6D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EKMAPCMPDGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2D82620", Offset = "0x2D81A20", VA = "0x182D82620")]
	public static JNMOIDIJNBK<T, U> AHLALEPNKFA<U>([In] U MCPMOAEEEOJ) where U : IEnumerator<T>
	{
		return default(JNMOIDIJNBK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class FDJEFAKMBJI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F770", Offset = "0x2E2EB70", VA = "0x182E2F770")]
	public static string FBININKGAIA<T>(this IEnumerable<T> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E36990", Offset = "0x2E35D90", VA = "0x182E36990")]
	public static string IDIMDMKLKDA<T>(this IEnumerable<T> MCPMOAEEEOJ, string HADEHDFMALH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GCPGFLIIHJN
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E599C0", Offset = "0x2E58DC0", VA = "0x182E599C0")]
	public static bool NAMDLKMGAFA<TSourceEnumerator, TSource>(this TSourceEnumerator MCPMOAEEEOJ, [In] TSource HHDONFMCNBA) where TSourceEnumerator : LFHDHADKFJP<TSource> where TSource : EPJDBDLJNML<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E594F0", Offset = "0x2E588F0", VA = "0x182E594F0")]
	public static int CLDOJIDKFCI<TSourceEnumerator, TSource>(this TSourceEnumerator MCPMOAEEEOJ, [In] TSource EEPLCHCGAIN) where TSourceEnumerator : LFHDHADKFJP<TSource> where TSource : EPJDBDLJNML<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E59750", Offset = "0x2E58B50", VA = "0x182E59750")]
	public static int HDHAKBOPCEI<TSourceEnumerator, TSource>(this TSourceEnumerator MCPMOAEEEOJ, [In] TSource EEPLCHCGAIN) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LFHDHADKFJP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GKCMOMIKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NDKOGGEKOPD<T> : LFHDHADKFJP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct KEEGLPILICM<T, U> : IEnumerable<T>, IEnumerable where U : NDKOGGEKOPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U ELMPNGIJBEK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x442CB70", Offset = "0x442BF70", VA = "0x18442CB70")]
	internal KEEGLPILICM([In] U ADGILLNPFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C54D00", Offset = "0x3C54100", VA = "0x183C54D00", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x442C750", Offset = "0x442BB50", VA = "0x18442C750", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x442C750", Offset = "0x442BB50", VA = "0x18442C750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JJJNEPDHAPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CF78D0", Offset = "0x2CF6CD0", VA = "0x182CF78D0")]
	public static KEEGLPILICM<T, U> AHLALEPNKFA<U>([In] U MCPMOAEEEOJ) where U : NDKOGGEKOPD<T>
	{
		return default(KEEGLPILICM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct ODADIOPEEKI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BOBMAAEOFFI : LFHDHADKFJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] MMEEBHEMCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int FCILIKFJDIG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5287180", Offset = "0x5286580", VA = "0x185287180", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5286AF0", Offset = "0x5285EF0", VA = "0x185286AF0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5286F00", Offset = "0x5286300", VA = "0x185286F00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C2B0", Offset = "0x1F6B6B0", VA = "0x181F6C2B0")]
		private BOBMAAEOFFI(T[] MCPMOAEEEOJ, int HAJICDLBEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5286AA0", Offset = "0x5285EA0", VA = "0x185286AA0")]
		public static BOBMAAEOFFI AHLALEPNKFA(T[] MCPMOAEEEOJ)
		{
			return default(BOBMAAEOFFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2224320", Offset = "0x2223720", VA = "0x182224320", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2224350", Offset = "0x2223750", VA = "0x182224350", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] PEFIJPIJAGB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AEFILNEPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x43D5A60", Offset = "0x43D4E60", VA = "0x1843D5A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2F49360", Offset = "0x2F48760", VA = "0x182F49360")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	internal ODADIOPEEKI(T[] IGGIDMIPNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A790", Offset = "0x4A09B90", VA = "0x184A0A790")]
	public static ODADIOPEEKI<T> JFFGEEEAJID()
	{
		return default(ODADIOPEEKI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
	public IEnumerable<T> MFINPFHCJOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AA30", Offset = "0x4A09E30", VA = "0x184A0AA30")]
	public ReadOnlySpan<T> MJEMPIHBNNA()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A8F0", Offset = "0x4A09CF0", VA = "0x184A0A8F0")]
	public BLCANMHGPBP<T, ODADIOPEEKI<T>.BOBMAAEOFFI> LOAGDNLPNKF()
	{
		return default(BLCANMHGPBP<T, BOBMAAEOFFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A6F0", Offset = "0x4A09AF0", VA = "0x184A0A6F0")]
	public BOBMAAEOFFI HEEPBANCGOF()
	{
		return default(BOBMAAEOFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A870", Offset = "0x4A09C70", VA = "0x184A0A870")]
	public IEnumerator<T> JLDAKMOMDIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A0AAD0", Offset = "0x4A09ED0", VA = "0x184A0AAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HBBLICGNEFN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7870", Offset = "0x2CF6C70", VA = "0x182CF7870")]
	public static ODADIOPEEKI<T> NNBCNOBPEFB<T>(params T[] IGGIDMIPNHL) where T : notnull
	{
		return default(ODADIOPEEKI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF400", Offset = "0x6EAE800", VA = "0x186EAF400")]
	public static Stream JGIFHLFFPNP(this ODADIOPEEKI<byte> MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(OCJDOODMLMI<>.KJOAGGIGHNI))]
public struct OCJDOODMLMI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BNECBIPLLHC : NDKOGGEKOPD<T>, LFHDHADKFJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] OJBECKNLKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int IBGDFIIIELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int FCILIKFJDIG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5286580", Offset = "0x5285980", VA = "0x185286580", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T KNHDHFPNOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5285BA0", Offset = "0x5284FA0", VA = "0x185285BA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T OINBJGPFAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5285C70", Offset = "0x5285070", VA = "0x185285C70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5285E50", Offset = "0x5285250", VA = "0x185285E50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5286410", Offset = "0x5285810", VA = "0x185286410", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4188DD0", Offset = "0x41881D0", VA = "0x184188DD0")]
		internal BNECBIPLLHC(T[] JHBKFOICCJL, int HMELIAGANNM, int HAJICDLBEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5285A60", Offset = "0x5284E60", VA = "0x185285A60")]
		public static BNECBIPLLHC AHLALEPNKFA(OCJDOODMLMI<T> MCPMOAEEEOJ)
		{
			return default(BNECBIPLLHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C14B40", Offset = "0x3C13F40", VA = "0x183C14B40", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F260", Offset = "0x3C0E660", VA = "0x183C0F260", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct EFDICIGBBBE : LFHDHADKFJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BNECBIPLLHC ELMPNGIJBEK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3B5E060", Offset = "0x3B5D460", VA = "0x183B5E060", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3B5DE00", Offset = "0x3B5D200", VA = "0x183B5DE00", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3B5DFC0", Offset = "0x3B5D3C0", VA = "0x183B5DFC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
		private EFDICIGBBBE([In] BNECBIPLLHC ADGILLNPFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DC50", Offset = "0x3B5D050", VA = "0x183B5DC50")]
		public static EFDICIGBBBE AHLALEPNKFA([In] OCJDOODMLMI<T> MCPMOAEEEOJ)
		{
			return default(EFDICIGBBBE);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DD40", Offset = "0x3B5D140", VA = "0x183B5DD40", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DD80", Offset = "0x3B5D180", VA = "0x183B5DD80", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5DD00", Offset = "0x3B5D100", VA = "0x183B5DD00", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class KJOAGGIGHNI
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] OJBECKNLKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int IBGDFIIIELM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A09E90", Offset = "0x4A09290", VA = "0x184A09E90")]
	public static OCJDOODMLMI<T> AHLALEPNKFA()
	{
		return default(OCJDOODMLMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A09F40", Offset = "0x4A09340", VA = "0x184A09F40")]
	public static OCJDOODMLMI<T> FDFIGNPDPPB(int BIMLHBENMHO)
	{
		return default(OCJDOODMLMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C2B0", Offset = "0x1F6B6B0", VA = "0x181F6C2B0")]
	internal OCJDOODMLMI(T[] JHBKFOICCJL, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A000", Offset = "0x4A09400", VA = "0x184A0A000", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MPFKODDKLFA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int IDAJBAPKFJL<TCtx, T>([In] TCtx GMBKOAJKCLF, T JKMLNPBBJIG, T JDJGFJGMEAK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CD20", Offset = "0x2F4C120", VA = "0x182F4CD20")]
	public static void KJDEEDGEPIJ<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2F45500", Offset = "0x2F44900", VA = "0x182F45500")]
	public static string AKEKJNHEIJG<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
	public static T[] AGOEDGCDOFE<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F492E0", Offset = "0x2F486E0", VA = "0x182F492E0")]
	public static T CADKKGPFCDD<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F49360", Offset = "0x2F48760", VA = "0x182F49360")]
	public static T KIDEOJHCBAM<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2F49CE0", Offset = "0x2F490E0", VA = "0x182F49CE0")]
	public static T DMBFPOMHFCG<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D7F0", Offset = "0x2F4CBF0", VA = "0x182F4D7F0")]
	public static void MCAKFOHFDBM<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA, [In] T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F495D0", Offset = "0x2F489D0", VA = "0x182F495D0")]
	public static void CFPJDAIMOLH<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2224730", Offset = "0x2223B30", VA = "0x182224730")]
	public static int CAPJDDIEEJI<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D890", Offset = "0x2F4CC90", VA = "0x182F4D890")]
	public static ReadOnlySpan<T> MJEMPIHBNNA<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A090", Offset = "0x2F49490", VA = "0x182F4A090")]
	public static T[] EKHIENEJCGD<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CA70", Offset = "0x2F4BE70", VA = "0x182F4CA70")]
	public static T FNENJFGNNFP<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2F49EA0", Offset = "0x2F492A0", VA = "0x182F49EA0")]
	public static T[] EKCKOBCLKKE<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2F49BE0", Offset = "0x2F48FE0", VA = "0x182F49BE0")]
	public static ODADIOPEEKI<T> DDKBHJDCCGP<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(ODADIOPEEKI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CFC0", Offset = "0x2F4C3C0", VA = "0x182F4CFC0")]
	public static void LEFBGNCKNFL<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, [In] T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F4FCE0", Offset = "0x2F4F0E0", VA = "0x182F4FCE0")]
	public static void PFBLBHPNKKL<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4FB00", Offset = "0x2F4EF00", VA = "0x182F4FB00")]
	public static void OPILHCAGHCE<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int HAJICDLBEKC, [In] T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F447A0", Offset = "0x2F43BA0", VA = "0x182F447A0")]
	public static void ACDGFDECIMJ<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int HAJICDLBEKC, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F4FA00", Offset = "0x2F4EE00", VA = "0x182F4FA00")]
	public static void NFGGCLAOHHC<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D830", Offset = "0x2F4CC30", VA = "0x182F4D830")]
	public static T MEHDJGEHFMM<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2F4B5C0", Offset = "0x2F4A9C0", VA = "0x182F4B5C0")]
	public static void ELHHBEOCNEP<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D990", Offset = "0x2F4CD90", VA = "0x182F4D990")]
	private static void MLEPPMNLAOM<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CE10", Offset = "0x2F4C210", VA = "0x182F4CE10")]
	public static void KMNEPMPOIBK<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2F48800", Offset = "0x2F47C00", VA = "0x182F48800")]
	public static OCJDOODMLMI<T> ANLGIKBMHBN<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ, JFPOPINHAOB<T, T> PEICLBCECOH)
	{
		return default(OCJDOODMLMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2F49100", Offset = "0x2F48500", VA = "0x182F49100")]
	public static bool BJFEGIDGDBE<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, T EEPLCHCGAIN) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CB10", Offset = "0x2F4BF10", VA = "0x182F4CB10")]
	public static bool JCIACPJGGDN<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ, [In] T EEPLCHCGAIN) where T : EPJDBDLJNML<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2EE7D60", Offset = "0x2EE7160", VA = "0x182EE7D60")]
	public static bool ANJBFCDOFPB<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CAB0", Offset = "0x2F4BEB0", VA = "0x182F4CAB0")]
	public static bool ICJMIFHHPPC<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ, int PGOOPNPHNCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CA20", Offset = "0x2F4BE20", VA = "0x182F4CA20")]
	public static void FCNLACDCBOM<T, TCtx>(this OCJDOODMLMI<T> MCPMOAEEEOJ, [In] TCtx GMBKOAJKCLF, IDAJBAPKFJL<TCtx, T> PIBNJHECOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CBE0", Offset = "0x2F4BFE0", VA = "0x182F4CBE0")]
	private static void JLDAKDAEGGN<T, TCtx>(OCJDOODMLMI<T> MCPMOAEEEOJ, [In] TCtx GMBKOAJKCLF, IDAJBAPKFJL<TCtx, T> PIBNJHECOAH, int FIKOLBKGALF, int IILDCDHKMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F48A60", Offset = "0x2F47E60", VA = "0x182F48A60")]
	private static int APJCDPLJFDB<T, TCtx>(OCJDOODMLMI<T> MCPMOAEEEOJ, [In] TCtx GMBKOAJKCLF, IDAJBAPKFJL<TCtx, T> PIBNJHECOAH, int FIKOLBKGALF, int IILDCDHKMJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E7A320", Offset = "0x2E79720", VA = "0x182E7A320")]
	public static OCJDOODMLMI<T>.EFDICIGBBBE JLDAKMOMDIF<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(OCJDOODMLMI<T>.EFDICIGBBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E7A320", Offset = "0x2E79720", VA = "0x182E7A320")]
	public static OCJDOODMLMI<T>.BNECBIPLLHC MIKHMLAIHDA<T>(this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(OCJDOODMLMI<T>.BNECBIPLLHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E7A1F0", Offset = "0x2E795F0", VA = "0x182E7A1F0")]
	public static BLCANMHGPBP<T, OCJDOODMLMI<T>.EFDICIGBBBE> FIOLMGEPDPE<T>([In] this OCJDOODMLMI<T> MCPMOAEEEOJ)
	{
		return default(BLCANMHGPBP<T, OCJDOODMLMI<T>.EFDICIGBBBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class KIGMOLIOPLA
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2EE8CD0", Offset = "0x2EE80D0", VA = "0x182EE8CD0")]
	public static T[] AJGIALPPCIG<T>(int IKJKAFPPDBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public static void PKNCBOHBBOD<T>(T[] IGGIDMIPNHL)
	{
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
