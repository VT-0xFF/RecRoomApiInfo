using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F960E0", Offset = "0x6F946E0", VA = "0x186F960E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AKJLDONJLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F94590", Offset = "0x6F92B90", VA = "0x186F94590")]
	public static (float3, float3, float3) FCELKBNJLHB(this in quaternion CDBMADFDGCE)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OEDJNHMPOAG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22F8C90", Offset = "0x22F7290", VA = "0x1822F8C90")]
	public static bool HBICBHEBFAO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7130", Offset = "0x6B6530")] this in ReadOnlyMemory<T> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B71A0", Offset = "0x6B65A0")] in ReadOnlyMemory<T> FKJGPCABBJN) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22F8BD0", Offset = "0x22F71D0", VA = "0x1822F8BD0")]
	public static int HAMGBPDKAKE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7210", Offset = "0x6B6610")] this in ReadOnlyMemory<T?> CDBMADFDGCE, int PEPEIDAIMEN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x22F8DB0", Offset = "0x22F73B0", VA = "0x1822F8DB0")]
	public static string NGCDLMDPBHA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7280", Offset = "0x6B6680")] this in ReadOnlyMemory<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NPONNAHBOIG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FC0430", Offset = "0x2FBEA30", VA = "0x182FC0430")]
	public static void KGACBIKGAOI<T>(this ICollection<T> CDBMADFDGCE, IEnumerable<T> NILANNAAGKO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BBAEHPPFIFB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHOPOAMLDBK FCNMHLHACAM();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BHMOAGIGBKI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class APECELNNOEM<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public APECELNNOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x208B430", Offset = "0x2089A30", VA = "0x18208B430")]
		internal TElement HMMILMLBLIE(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IACIINAACMB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public IACIINAACMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xCCF050", Offset = "0xCCD650", VA = "0x180CCF050")]
		internal int NADMKMDJIJE(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x19F75E0", Offset = "0x19F5BE0", VA = "0x1819F75E0")]
	public static int BEHPELLCLJG<T>(this IReadOnlyList<T> IACDCADJJAN, T MOLEJFDINLH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x19FA2D0", Offset = "0x19F88D0", VA = "0x1819FA2D0")]
	public static int JONPEDNGGOI<T>(this IReadOnlyList<T> IACDCADJJAN, T MOLEJFDINLH) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19FA490", Offset = "0x19F8A90", VA = "0x1819FA490")]
	public static void KGACBIKGAOI<T>(this HashSet<T> COHNNGFMCFH, IEnumerable<T> NILANNAAGKO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3598A80", Offset = "0x3597080", VA = "0x183598A80")]
	public static void MKGGHGOLGFG<T>(this IList<T> CKIKFMIOAHP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3598B00", Offset = "0x3597100", VA = "0x183598B00")]
	public static void MKGGHGOLGFG<T>(this IList<T> CKIKFMIOAHP, int ENKPEAKPKKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x19F80B0", Offset = "0x19F66B0", VA = "0x1819F80B0")]
	public static List<T> BFNEBMFOFGN<T>(this List<T> DGMLEAEOENE, Predicate<T> DHJCAAALDNH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x19F7E50", Offset = "0x19F6450", VA = "0x1819F7E50")]
	public static int BEHPELLCLJG<T>(this IReadOnlyList<T> CKIKFMIOAHP, Predicate<T> OIILKNGKCEE) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x359BB00", Offset = "0x359A100", VA = "0x18359BB00")]
	public static bool PEOHCNEOLEM<T>(this IReadOnlyList<T> CKIKFMIOAHP, Predicate<T> OIILKNGKCEE, [HLBOCLLKMAH(true)] out List<int>? OAKNKJJEPHP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x19F9FD0", Offset = "0x19F85D0", VA = "0x1819F9FD0")]
	public static bool JDABAMPMFDA<T>(this IReadOnlyList<T> CKIKFMIOAHP, T MDCAOIKFJBP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x19F9E90", Offset = "0x19F8490", VA = "0x1819F9E90")]
	public static bool JDABAMPMFDA<T>(this IReadOnlyList<T> CKIKFMIOAHP, T MDCAOIKFJBP, EqualityComparer<T> OHDCMCANAGL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x19F8780", Offset = "0x19F6D80", VA = "0x1819F8780")]
	public static int BMIOHBBENLD<TElement, TKey>(this IList<TElement> CAGEJNBMACL, TKey IBLDGIDJOPJ, Func<TElement, TKey> CAMIFBDNNBO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7370", Offset = "0x6B6770")] Func<TKey, TKey, int> JJIMLMCHODB, int OLGOBCPPPBB = 0, [Optional] int? FJLPCOJGEJP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x19F81A0", Offset = "0x19F67A0", VA = "0x1819F81A0")]
	public static int BMIOHBBENLD<TElement, TKey>(Func<int, TElement> MIDKHMCFJLP, int JKIKBKFMFAN, TKey IBLDGIDJOPJ, Func<TElement, TKey> CAMIFBDNNBO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B73D0", Offset = "0x6B67D0")] Func<TKey, TKey, int> JJIMLMCHODB, int OLGOBCPPPBB = 0, [Optional] int? FJLPCOJGEJP) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x359BF60", Offset = "0x359A560", VA = "0x18359BF60")]
	public static List<T> PHPHHIPJKMA<T>(this IReadOnlyList<T> CKIKFMIOAHP, int FJLPCOJGEJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x19FA0C0", Offset = "0x19F86C0", VA = "0x1819FA0C0")]
	public static bool JGKGFCFCLCK<T>(this List<T> CKIKFMIOAHP, T MDCAOIKFJBP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x359B590", Offset = "0x3599B90", VA = "0x18359B590")]
	public static void OCKDOEDCDIC<T>(this List<T> CKIKFMIOAHP, IEnumerable<T> DGMLEAEOENE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x19F8E00", Offset = "0x19F7400", VA = "0x1819F8E00")]
	public static void EIILGGCBFDG<T>(this List<T> CKIKFMIOAHP, IEnumerable<T> DGMLEAEOENE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x19F8DA0", Offset = "0x19F73A0", VA = "0x1819F8DA0")]
	public static T DENGMIMOEEM<T>(this List<T> DGMLEAEOENE, Predicate<T> DHJCAAALDNH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3598750", Offset = "0x3596D50", VA = "0x183598750")]
	public static T LIKPBAPPEJI<T>(this List<T> DGMLEAEOENE, int OLGOBCPPPBB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x19FA240", Offset = "0x19F8840", VA = "0x1819FA240")]
	public static bool JKFAAMPKMDN<T>(this List<T> CAHDOLEMANC, List<T> MNJKMPGNIBL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x19F8FA0", Offset = "0x19F75A0", VA = "0x1819F8FA0")]
	public static T FPFPOOMJMDO<T>(this IList<T> CKIKFMIOAHP) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x19F9430", Offset = "0x19F7A30", VA = "0x1819F9430")]
	public static bool IMPJKLJDDEG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7430", Offset = "0x6B6830")] IReadOnlyList<T> CKIKFMIOAHP, int OLGOBCPPPBB, [FACIHPGOEDI(false)][PGBBCIKIPBH("This should be `T?` in C# 9.")] out T NKONLKNLFIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x359A6B0", Offset = "0x3598CB0", VA = "0x18359A6B0")]
	public static bool MNDLGLFBBNM<T>(IReadOnlyList<T> CKIKFMIOAHP, ICollection DGMLEAEOENE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x19FAF70", Offset = "0x19F9570", VA = "0x1819FAF70")]
	public static void KOAPEBCMMGJ<T>(IReadOnlyList<T> CKIKFMIOAHP, ref ICollection DGMLEAEOENE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x19F9040", Offset = "0x19F7640", VA = "0x1819F9040")]
	public static bool HBOFGHDOKGE<T>(this IReadOnlyList<T> CKIKFMIOAHP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x19F7400", Offset = "0x19F5A00", VA = "0x1819F7400")]
	public static string ADGDOBGAKGD<T>(this IEnumerable<T> CKIKFMIOAHP, string EDAOEIIMHAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x359BA50", Offset = "0x359A050", VA = "0x18359BA50")]
	public static T PACBMOJOKDB<T>(this IList<T> CDBMADFDGCE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3598910", Offset = "0x3596F10", VA = "0x183598910")]
	public static T MEPDHFINHML<T>(this IList<T> CDBMADFDGCE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35989F0", Offset = "0x3596FF0", VA = "0x1835989F0")]
	public static void MEPEENJFDCP<T>(this IList<T> CDBMADFDGCE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x19F9230", Offset = "0x19F7830", VA = "0x1819F9230")]
	public static void IJIDLFAMDHJ<T>(this IList<T> CDBMADFDGCE, in T MOLEJFDINLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x359B750", Offset = "0x3599D50", VA = "0x18359B750")]
	public static T OLFOFFKDBFE<T>(this IList<T> CDBMADFDGCE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x19F90A0", Offset = "0x19F76A0", VA = "0x1819F90A0")]
	public static void IANCIFDINMF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B74E0", Offset = "0x6B68E0")] this List<T> CDBMADFDGCE) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GCCPPOKFMPD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PEJHCBLGBKA<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private T self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T <>3__self;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1F0F600", Offset = "0x1F0DC00", VA = "0x181F0F600", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
		[DebuggerHidden]
		public PEJHCBLGBKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F400", Offset = "0x1F0DA00", VA = "0x181F0F400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F580", Offset = "0x1F0DB80", VA = "0x181F0F580", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F430", Offset = "0x1F0DA30", VA = "0x181F0F430", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E718D0", Offset = "0x1E6FED0", VA = "0x181E718D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A13270", Offset = "0x1A11870", VA = "0x181A13270")]
	public static void CIOFCKLADJA<T>(this T KAIHGPIIHIB, Action<T> PCAEAAHFGKE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1A13400", Offset = "0x1A11A00", VA = "0x181A13400")]
	public static V GICEHHDCEHJ<V, T>(this T KAIHGPIIHIB, Func<T, V> PCAEAAHFGKE, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] V INIEFLCMFEE) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1A135E0", Offset = "0x1A11BE0", VA = "0x181A135E0")]
	public static T? JNBKFKGEGHN<T>(this T CDBMADFDGCE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1466940", Offset = "0x1464F40", VA = "0x181466940")]
	[IteratorStateMachine(typeof(PEJHCBLGBKA<>))]
	public static IEnumerable<T> GBEFOKLFOBF<T>(this T CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1A132B0", Offset = "0x1A118B0", VA = "0x181A132B0")]
	public static T[] DFAEBIAONOK<T>(this T CDBMADFDGCE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PBGFKANDKKP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long PDPKCPFDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GCNKGHNKDBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PBGFKANDKKP GFJFGPAOBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long GNNMABGFPPE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F94A10", Offset = "0x6F93010", VA = "0x186F94A10")]
	public GCNKGHNKDBI(PBGFKANDKKP HFOBMDAADLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F948F0", Offset = "0x6F92EF0", VA = "0x186F948F0")]
	public long IKELBMPCNJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F94980", Offset = "0x6F92F80", VA = "0x186F94980")]
	public double KFHLAHNCKNA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F94860", Offset = "0x6F92E60", VA = "0x186F94860")]
	public double BBNKMMCKPAE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class APHCEHFJHGA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4849610", Offset = "0x4847C10", VA = "0x184849610")]
	public static bool GFKDEDPMDKG(this Type CDBMADFDGCE, Type FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE19C20", VA = "0x180E1B620")]
	public static bool GFKDEDPMDKG<T>(this Type CDBMADFDGCE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NJGGALMDCGO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LEMPBCPLEBH(int MODOAKNPMEE, int DMGJJHDFOKN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float PCGDCDGMPJL(float BCFPMEAFBPM, float AMMGHEKOCCK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ODPNCIDACMC
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x22F8AA0", Offset = "0x22F70A0", VA = "0x1822F8AA0")]
	public static void MGGDHGPEKNI<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7670", Offset = "0x6B6A70")] this in KeyValuePair<TKey, TValue> CDBMADFDGCE, out TKey BOMEFJIOGGM, out TValue MOLEJFDINLH) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x22F87E0", Offset = "0x22F6DE0", VA = "0x1822F87E0")]
	public static (TKey?, TValue?) COFHIPNAFGE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B76E0", Offset = "0x6B6AE0")] this in KeyValuePair<TKey?, TValue?> CDBMADFDGCE)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x22F8980", Offset = "0x22F6F80", VA = "0x1822F8980")]
	public static KeyValuePair<TKey?, UValue?> JGCFOHNENNL<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7750", Offset = "0x6B6B50")] this KeyValuePair<TKey?, TValue?> CDBMADFDGCE, UValue MOLEJFDINLH)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PGGEJJFDMLB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2308670", Offset = "0x2306C70", VA = "0x182308670")]
	[DFIJCPAOBAF("This should be replaced with the `is not` operator in C# 9.")]
	public static bool DJCNINBPMAP<T>(this object CDBMADFDGCE, [HLBOCLLKMAH(true)] out T NKONLKNLFIB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LEJGMHHPLOL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F95460", Offset = "0x6F93A60", VA = "0x186F95460")]
	private static byte[] GFFMEAOCHJJ(int HNGNOGPHHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F95260", Offset = "0x6F93860", VA = "0x186F95260")]
	private static byte[] EJCBNPFCHIF(long CNOBIBKFMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F95B40", Offset = "0x6F94140", VA = "0x186F95B40")]
	private static byte[] IGNIBMGHKPJ(ulong CNOBIBKFMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F952E0", Offset = "0x6F938E0", VA = "0x186F952E0")]
	public static Guid FAEELABLECD(params Guid[] HIOOIDNLDFO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F956F0", Offset = "0x6F93CF0", VA = "0x186F956F0")]
	public static Guid HKLENFAPHAP(in Guid FEHABJIFFCI, int OLGOBCPPPBB, int MPNDOHBKHJO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F95620", Offset = "0x6F93C20", VA = "0x186F95620")]
	public static Guid HKLENFAPHAP(in Guid FEHABJIFFCI, long OLGOBCPPPBB, int MPNDOHBKHJO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F95550", Offset = "0x6F93B50", VA = "0x186F95550")]
	public static Guid HKLENFAPHAP(in Guid FEHABJIFFCI, ulong OLGOBCPPPBB, int MPNDOHBKHJO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F954E0", Offset = "0x6F93AE0", VA = "0x186F954E0")]
	public static Guid HKLENFAPHAP(in Guid FEHABJIFFCI, in Guid CKMJMHNKDKO, int MPNDOHBKHJO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F957C0", Offset = "0x6F93DC0", VA = "0x186F957C0")]
	private static Guid HKLENFAPHAP(in Guid FEHABJIFFCI, byte[] OKHHABNBONB, int MPNDOHBKHJO = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F95180", Offset = "0x6F93780", VA = "0x186F95180")]
	private static void CIKMFOJELDI(byte[] NAMBIBPENHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F95AC0", Offset = "0x6F940C0", VA = "0x186F95AC0")]
	private static void HMDKLMIIFIP(byte[] NAMBIBPENHK, int CBNLLBDNGLG, int FDIDEGFPCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AKHMKPJOOLI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67928B0", Offset = "0x6790EB0", VA = "0x1867928B0")]
	public static uint ODCHECNLKCN(this uint CDBMADFDGCE, int FJLPCOJGEJP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5254910", Offset = "0x5252F10", VA = "0x185254910")]
	public static uint NFOLPHAEELL(this uint CDBMADFDGCE, int FJLPCOJGEJP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MLIJBOCDLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F95D20", Offset = "0x6F94320", VA = "0x186F95D20")]
	public static int FIDGHKLLADL(this int CDBMADFDGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F95D90", Offset = "0x6F94390", VA = "0x186F95D90")]
	public static int HHDCOMECKCI(this int CDBMADFDGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F95DD0", Offset = "0x6F943D0", VA = "0x186F95DD0")]
	public static int KDJDPIJFGHL(this int CDBMADFDGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F95D10", Offset = "0x6F94310", VA = "0x186F95D10")]
	public static int ADFAOLLOODO(this int CDBMADFDGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67928B0", Offset = "0x6790EB0", VA = "0x1867928B0")]
	public static int ODCHECNLKCN(this int CDBMADFDGCE, int FJLPCOJGEJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5254910", Offset = "0x5252F10", VA = "0x185254910")]
	public static int NFOLPHAEELL(this int CDBMADFDGCE, int FJLPCOJGEJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DMPJIBFGOJE
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x553DB10", Offset = "0x553C110", VA = "0x18553DB10")]
	public static bool EBMBBOAPHCP<T, U>(this T CDBMADFDGCE, in U NKFOPKJGBEM) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x553DA80", Offset = "0x553C080", VA = "0x18553DA80")]
	public static bool CAHMEJDNIHD<T>(ref T CDBMADFDGCE, T FKJGPCABBJN) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ONAAJFKOEPM
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float FCAENBBLPJA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float BNOHELNGBBK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool JBDFACGGANE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float BFDAKDLGEGG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F96260", Offset = "0x6F94860", VA = "0x186F96260")]
	public static bool JEIDGPPFOLF(float GNJGFBLEGKK, float HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5099A60", Offset = "0x5098060", VA = "0x185099A60")]
	public static float PACHEIFOFKN(float MOLEJFDINLH, float JKJLIBLKLFB, float OEJABJDKHOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5099A80", Offset = "0x5098080", VA = "0x185099A80")]
	public static int PACHEIFOFKN(int MOLEJFDINLH, int JKJLIBLKLFB, int OEJABJDKHOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5099A40", Offset = "0x5098040", VA = "0x185099A40")]
	public static float FBBAILPEGBP(float MOLEJFDINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F961B0", Offset = "0x6F947B0", VA = "0x186F961B0")]
	public static float FBJHAALCDHK(float GNJGFBLEGKK, float HEPECHBEGLE, float KAIHGPIIHIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F96250", Offset = "0x6F94850", VA = "0x186F96250")]
	public static float FCLOMKPFBOH(float GNJGFBLEGKK, float HEPECHBEGLE, float KAIHGPIIHIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F96360", Offset = "0x6F94960", VA = "0x186F96360")]
	public static float LAFAFLDKFDH(float GNJGFBLEGKK, float HEPECHBEGLE, float MOLEJFDINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F96170", Offset = "0x6F94770", VA = "0x186F96170")]
	public static float BPNKAHHFCKP(float GNJGFBLEGKK, float HEPECHBEGLE, float MOLEJFDINLH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OLBLPCILEII
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2301BD0", Offset = "0x23001D0", VA = "0x182301BD0")]
	public static TValue JKICDLEANKB<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> CDBMADFDGCE, TKey BOMEFJIOGGM) where TValue : class where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2301E70", Offset = "0x2300470", VA = "0x182301E70")]
	public static bool LPNLLFMLIIO<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> CDBMADFDGCE, IReadOnlyDictionary<TKey, TValue> FKJGPCABBJN) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface AHOPOAMLDBK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILLGNLEGDMN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OOAICPJFGMB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class LBMHBHNNLID : NJGGALMDCGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random AMEAEHACHJM;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F95070", Offset = "0x6F93670", VA = "0x186F95070", Slot = "4")]
		public int LEMPBCPLEBH(int BCFPMEAFBPM, int PMABKANMLEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F950A0", Offset = "0x6F936A0", VA = "0x186F950A0", Slot = "5")]
		public float PCGDCDGMPJL(float BCFPMEAFBPM, float AMMGHEKOCCK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F95030", Offset = "0x6F93630", VA = "0x186F95030")]
		private double BFICOAHAMAG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F95110", Offset = "0x6F93710", VA = "0x186F95110")]
		public LBMHBHNNLID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly NJGGALMDCGO PHPHHIPJKMA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F96500", Offset = "0x6F94B00", VA = "0x186F96500")]
	public static ulong CGPECJFPCAI()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IJONLLFECEP
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool APEAHDHINMN<TArgs, T>(in TArgs CHPIMGNELOI, T MDCAOIKFJBP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U JBPJDJMHMMF<TArg, U>(in TArg JBBIKBFHPNN);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U HLFGCGCFOLD<TArg, T, U>(in TArg JBBIKBFHPNN, T CKBIKICODGK);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U JBOOOPMMIOP<TArg, T, U>(in TArg JBBIKBFHPNN, IEnumerable<T> NCBGBGGOJOG);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U DHFDGHBCIKI<TArg, T, U>(in TArg JBBIKBFHPNN, T CKBIKICODGK);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct GAMCEHAMHHO<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3534A90", Offset = "0x3533090", VA = "0x183534A90")]
		[PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CFNFCGCINCE(T PMAHEOIHGAL)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3534B00", Offset = "0x3533100", VA = "0x183534B00")]
		[PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) DKIPMOOAIIH(IEnumerable<T> DFKIKMEJBNK)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KMPKGNKHAEA<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IEnumerable<U> other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IEnumerable<U> <>3__other;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private T with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T <>3__with;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IEnumerator<T> <selfEnumerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerator<U> <otherEnumerator>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <selfDidMove>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool <otherDidMove>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
		[DebuggerHidden]
		public KMPKGNKHAEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x26693E0", Offset = "0x26679E0", VA = "0x1826693E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2668AA0", Offset = "0x26670A0", VA = "0x182668AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2668660", Offset = "0x2666C60", VA = "0x182668660")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2668710", Offset = "0x2666D10", VA = "0x182668710")]
		private void GKPOLPOJHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2669350", Offset = "0x2667950", VA = "0x182669350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2669200", Offset = "0x2667800", VA = "0x182669200", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E720A0", Offset = "0x1E706A0", VA = "0x181E720A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KMCCJAOEBLF<T> : IEnumerable<(T, PGBDAGMDGBE<T>)>, IEnumerable, IEnumerator<(T, PGBDAGMDGBE<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, PGBDAGMDGBE<T> Next) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<T> <enumerator>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private T <current>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private (T, PGBDAGMDGBE<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x2665560", Offset = "0x2663B60", VA = "0x182665560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, PGBDAGMDGBE<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2665790", Offset = "0x2663D90", VA = "0x182665790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2665840", Offset = "0x2663E40", VA = "0x182665840")]
		[DebuggerHidden]
		public KMCCJAOEBLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x26657E0", Offset = "0x2663DE0", VA = "0x1826657E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2664710", Offset = "0x2662D10", VA = "0x182664710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26641B0", Offset = "0x26627B0", VA = "0x1826641B0")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2665600", Offset = "0x2663C00", VA = "0x182665600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2665350", Offset = "0x2663950", VA = "0x182665350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PGBDAGMDGBE<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x218B370", Offset = "0x2189970", VA = "0x18218B370", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PHGLKHOBCNE<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private U <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IEnumerable<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IEnumerable<T> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7F80", Offset = "0x6B7380")]
		private Func<GAMCEHAMHHO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8070", Offset = "0x6B7470")]
		public Func<GAMCEHAMHHO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private IEnumerator<T> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private T <item>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <zero>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private U <one>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerable<U> <many>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<U> <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private U <manyItem>5__7;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x18C5790", Offset = "0x18C3D90", VA = "0x1818C5790")]
		[DebuggerHidden]
		public PHGLKHOBCNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x22AF330", Offset = "0x22AD930", VA = "0x1822AF330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x22AEE60", Offset = "0x22AD460", VA = "0x1822AEE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x22AEDC0", Offset = "0x22AD3C0", VA = "0x1822AEDC0")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x22AEE10", Offset = "0x22AD410", VA = "0x1822AEE10")]
		private void GKPOLPOJHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x22AF2F0", Offset = "0x22AD8F0", VA = "0x1822AF2F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x22AF230", Offset = "0x22AD830", VA = "0x1822AF230", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x218D150", Offset = "0x218B750", VA = "0x18218D150", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HCKGMAJENPJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HCKGMAJENPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2180720", Offset = "0x217ED20", VA = "0x182180720")]
		internal bool MEDMPJGPKDI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x21806B0", Offset = "0x217ECB0", VA = "0x1821806B0")]
		internal bool GAMMCHNCMKH(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CGMMFHEAJEJ<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private (T Lhs, U Rhs) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private IEnumerable<T> lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IEnumerable<T> <>3__lhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private IEnumerable<U> rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IEnumerable<U> <>3__rhs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IEnumerator<T> <lhsIt>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private IEnumerator<U> <rhsIt>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private (T, U) System.Collections.Generic.IEnumerator<(TLhs,URhs)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9C97A0", Offset = "0x9C7DA0", VA = "0x1809C97A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2B79F10", Offset = "0x2B78510", VA = "0x182B79F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2665840", Offset = "0x2663E40", VA = "0x182665840")]
		[DebuggerHidden]
		public CGMMFHEAJEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B79BE0", Offset = "0x2B781E0", VA = "0x182B79BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B79ED0", Offset = "0x2B784D0", VA = "0x182B79ED0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B79E10", Offset = "0x2B78410", VA = "0x182B79E10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2288970", Offset = "0x2286F70", VA = "0x182288970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x11D8CA0", Offset = "0x11D72A0", VA = "0x1811D8CA0")]
	public static bool HODBFHJPCML<T, TArgs>(this IEnumerable<T> CDBMADFDGCE, in TArgs CHPIMGNELOI, APEAHDHINMN<TArgs, T> OIILKNGKCEE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x11DA940", Offset = "0x11D8F40", VA = "0x1811DA940")]
	public static U OICKCAPKOKM<U, T>(this IEnumerable<T> CDBMADFDGCE, Func<U> DHIMPGLIHCH, Func<T, U> PMAHEOIHGAL, Func<IEnumerable<T>, U> DFKIKMEJBNK) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x11D79B0", Offset = "0x11D5FB0", VA = "0x1811D79B0")]
	public static bool FPDKMADBOBP<T, TArgs>(this IEnumerable<T> CDBMADFDGCE, in TArgs CHPIMGNELOI, APEAHDHINMN<TArgs, T> OIILKNGKCEE) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x11D81C0", Offset = "0x11D67C0", VA = "0x1811D81C0")]
	public static U HICFOPEAKIC<U, T, TArg>(this IEnumerable<T> CDBMADFDGCE, in TArg JBBIKBFHPNN, JBPJDJMHMMF<TArg, U> DHIMPGLIHCH, HLFGCGCFOLD<TArg, T, U> PMAHEOIHGAL, JBOOOPMMIOP<TArg, T, U> DFKIKMEJBNK) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x11DA0C0", Offset = "0x11D86C0", VA = "0x1811DA0C0")]
	public static IEnumerable<U> NBGGDAJHJKO<U, T, TArg>(this IEnumerable<T> CDBMADFDGCE, in TArg JBBIKBFHPNN, DHFDGHBCIKI<TArg, T, U> OHJHOGOEIKD) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x11D6BC0", Offset = "0x11D51C0", VA = "0x1811D6BC0")]
	public static IEnumerable<T> AMLKONAGIPH<T>(params IEnumerable<T>[] BAMDLBAEMIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x11D6E00", Offset = "0x11D5400", VA = "0x1811D6E00")]
	public static bool CCOGPAHDIEA<T>(this IEnumerable<T> PAKFOBAPADB, IEnumerable<T> FKJGPCABBJN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x11D6BC0", Offset = "0x11D51C0", VA = "0x1811D6BC0")]
	public static IEnumerable<(TKey?, TValue?)>? IEGJMLDIAFD<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B78A0", Offset = "0x6B6CA0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x11D70E0", Offset = "0x11D56E0", VA = "0x1811D70E0")]
	public static IEnumerable<T> DJGAJICGLKD<T, TKey>(this IEnumerable<T> KOGJJIFAJFN, Func<T, TKey> HGDMBMMICKF) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x11D9340", Offset = "0x11D7940", VA = "0x1811D9340")]
	[IteratorStateMachine(typeof(KMPKGNKHAEA<, >))]
	public static IEnumerable<T> JLCLJCKMNEE<T, U>(this IEnumerable<T> CDBMADFDGCE, IEnumerable<U> FKJGPCABBJN, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] T NLDHCNIHCDG) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x11D6D80", Offset = "0x11D5380", VA = "0x1811D6D80")]
	public static T BOHBPDFMMBH<T>(this IEnumerable<T> PAKFOBAPADB, T INIEFLCMFEE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x11D6DB0", Offset = "0x11D53B0", VA = "0x1811D6DB0")]
	public static T BOHBPDFMMBH<T>(this IEnumerable<T> PAKFOBAPADB, T INIEFLCMFEE, Func<T, bool> OIILKNGKCEE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x11D9E00", Offset = "0x11D8400", VA = "0x1811D9E00")]
	public static T? KBONFCPJGIH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7970", Offset = "0x6B6D70")] this IEnumerable<T> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B79D0", Offset = "0x6B6DD0")] Func<T, bool> OIILKNGKCEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x11DADA0", Offset = "0x11D93A0", VA = "0x1811DADA0")]
	[IteratorStateMachine(typeof(KMCCJAOEBLF<>))]
	public static IEnumerable<(T, PGBDAGMDGBE<T>)> OOBHPGKOJAH<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x11D6FC0", Offset = "0x11D55C0", VA = "0x1811D6FC0")]
	public static bool CHEPCKAAGDH<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x11D6BC0", Offset = "0x11D51C0", VA = "0x1811D6BC0")]
	public static IEnumerable<PCAAKDOPNBL<T>> FIFIFGFPIHM<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x11DA0A0", Offset = "0x11D86A0", VA = "0x1811DA0A0")]
	public static bool NAOMKKANDIK<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x11D70B0", Offset = "0x11D56B0", VA = "0x1811D70B0")]
	public static IEnumerable<T> DFMNPMDCFPO<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x11D8F40", Offset = "0x11D7540", VA = "0x1811D8F40")]
	[IteratorStateMachine(typeof(PHGLKHOBCNE<, >))]
	public static IEnumerable<U> JJPNJKDIOPF<U, T>(this IEnumerable<T> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7B00", Offset = "0x6B6F00")] Func<GAMCEHAMHHO<U>, T, (bool Zero, U One, IEnumerable<U> Many)> EPGFDPDLBCP) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x11D7D30", Offset = "0x11D6330", VA = "0x1811D7D30")]
	public static int HAMGBPDKAKE<T>(this IEnumerable<T> CDBMADFDGCE, int PEPEIDAIMEN = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x11DAAF0", Offset = "0x11D90F0", VA = "0x1811DAAF0")]
	public static bool OIFJFANAAKL<T>(this IEnumerable<T> CDBMADFDGCE, IEnumerable<T> FKJGPCABBJN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x11D8FE0", Offset = "0x11D75E0", VA = "0x1811D8FE0")]
	public static (IEnumerable<T>, IEnumerable<T>) JKEEPOBEEGL<T>(this IEnumerable<T> CDBMADFDGCE, Func<T, bool> HLJONMADHHM) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x11DA5C0", Offset = "0x11D8BC0", VA = "0x1811DA5C0")]
	public static string NGCDLMDPBHA<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x11D6870", Offset = "0x11D4E70", VA = "0x1811D6870")]
	public static Dictionary<TKey?, TValue?>? AEBDIPGFOPO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7BF0", Offset = "0x6B6FF0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PAKFOBAPADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x11D6870", Offset = "0x11D4E70", VA = "0x1811D6870")]
	public static Dictionary<TKey?, TValue?>? AEBDIPGFOPO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B7C50", Offset = "0x6B7050")] this IEnumerable<(TKey? Key, TValue? Value)>? PAKFOBAPADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x11D8EC0", Offset = "0x11D74C0", VA = "0x1811D8EC0")]
	public static HashSet<T> IPCKIOJJFJI<T>(this IEnumerable<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x11D8F20", Offset = "0x11D7520", VA = "0x1811D8F20")]
	public static string IPDFBMIIDJN<T>(this IEnumerable<T> CDBMADFDGCE, string CNALHDMMHJG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x11D8120", Offset = "0x11D6720", VA = "0x1811D8120")]
	[IteratorStateMachine(typeof(CGMMFHEAJEJ<, >))]
	public static IEnumerable<(T, U)> HEMJLPBPIKL<T, U>(this IEnumerable<T> MBOGNALMNPH, IEnumerable<U> NDCLMFPKHPF) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x11D7570", Offset = "0x11D5B70", VA = "0x1811D7570")]
	public static IEnumerable<V> FJANMEAFIPO<V, T, U>(this IEnumerable<T> CDBMADFDGCE, IEnumerable<U> FKJGPCABBJN, Func<T, U, V> ANIGMJBAIFG, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] T LAMMNIPHJNO, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] U HJAGPPIFMNK) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x11D7600", Offset = "0x11D5C00", VA = "0x1811D7600")]
	public static IEnumerable<(T, U)> FJANMEAFIPO<T, U>(this IEnumerable<T> CDBMADFDGCE, IEnumerable<U> FKJGPCABBJN, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] T LAMMNIPHJNO, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] U HJAGPPIFMNK) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NGLDHDICJID
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x20AE6B0", Offset = "0x20ACCB0", VA = "0x1820AE6B0")]
	public static bool KMPDAIINOMK<T>(this IReadOnlyCollection<T> CDBMADFDGCE, int OLGOBCPPPBB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KKGHKCEHADG : PBGFKANDKKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch GFJFGPAOBGC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long PDPKCPFDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F94EE0", Offset = "0x6F934E0", VA = "0x186F94EE0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	private KKGHKCEHADG(Stopwatch HFOBMDAADLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F94F00", Offset = "0x6F93500", VA = "0x186F94F00")]
	public static KKGHKCEHADG NMHFKHECIIO(Stopwatch HFOBMDAADLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F94E40", Offset = "0x6F93440", VA = "0x186F94E40")]
	public static KKGHKCEHADG KCKHDCFGBBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LBABDGFJJAL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F94F60", Offset = "0x6F93560", VA = "0x186F94F60")]
	public static RigidTransform LPBMKJDENEL(RigidTransform HGFHFIEJHGA, RigidTransform DBKKBEEPPHL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EDDJNMDAIGM<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct PBIEPCCGJPC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1F085E0", Offset = "0x1F06BE0", VA = "0x181F085E0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int LIMMLDEFKDG;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static GCNKGHNKDBI DDEADBMMHHH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long PDPKCPFDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x18BDBA0", Offset = "0x18BC1A0", VA = "0x1818BDBA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x23DA1A0", Offset = "0x23D87A0", VA = "0x1823DA1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x23DA000", Offset = "0x23D8600", VA = "0x1823DA000")]
	public static PBIEPCCGJPC ACGNHGIJMCC()
	{
		return default(PBIEPCCGJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x23DA200", Offset = "0x23D8800", VA = "0x1823DA200")]
	private static void JCBGIIGCNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x23DA380", Offset = "0x23D8980", VA = "0x1823DA380")]
	public static void KINBCCGCMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ECPHDFAKMOL
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1200", Offset = "0x1FAF800", VA = "0x181FB1200")]
	public static bool HBICBHEBFAO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8580", Offset = "0x6B7980")] this in ReadOnlySpan<T?> CDBMADFDGCE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B85F0", Offset = "0x6B79F0")] in ReadOnlySpan<T?> FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB10E0", Offset = "0x1FAF6E0", VA = "0x181FB10E0")]
	public static int HAMGBPDKAKE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8660", Offset = "0x6B7A60")] this in ReadOnlySpan<T?> CDBMADFDGCE, int PEPEIDAIMEN = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FB17B0", Offset = "0x1FAFDB0", VA = "0x181FB17B0")]
	public static string NGCDLMDPBHA<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B86D0", Offset = "0x6B7AD0")] this in ReadOnlySpan<T> CDBMADFDGCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1380", Offset = "0x1FAF980", VA = "0x181FB1380")]
	public static string IPDFBMIIDJN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8740", Offset = "0x6B7B40")] this in ReadOnlySpan<T> CDBMADFDGCE, string CNALHDMMHJG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MKLMFLMBGGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x557C8D0", Offset = "0x557AED0", VA = "0x18557C8D0")]
	public static bool HBOFGHDOKGE(this string? AODCBLNIDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F95BC0", Offset = "0x6F941C0", VA = "0x186F95BC0")]
	public static string? HHHAHIMGGGK(this string? CDBMADFDGCE, int FHFGMPLDCMD, string FIDFEBLJJNO = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F95C70", Offset = "0x6F94270", VA = "0x186F95C70")]
	public static string MOIBDPGAHLJ(this string CDBMADFDGCE, int FHFGMPLDCMD, string FIDFEBLJJNO = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FFGHNKODIEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static PBGFKANDKKP HFAIMDLENMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F94690", Offset = "0x6F92C90", VA = "0x186F94690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F946F0", Offset = "0x6F92CF0", VA = "0x186F946F0")]
	public static double KFHLAHNCKNA(this PBGFKANDKKP CDBMADFDGCE, long ELHENGLOKKI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ILGMFPPONCJ
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int BDCDKFBMIEK<T>(in T MBOGNALMNPH, in T NDCLMFPKHPF);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class DHGAAFKIJLM<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct NDEDPCCENPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int FJBDCKBJAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int DCPIMNCPENK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool CAEJGLEKPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int LFDKDBGGKFP;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x277F2D0", Offset = "0x277D8D0", VA = "0x18277F2D0")]
			public NDEDPCCENPC(int FJBDCKBJAGA, int DCPIMNCPENK, bool CAEJGLEKPEM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] JGENHCEEJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] MINGMNMPLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly BDCDKFBMIEK<T> JJIMLMCHODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int ENFKEDLGNNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> HODNLEGFFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int FGPOHMBGEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8890", Offset = "0x6B7C90")]
		private readonly DHGAAFKIJLM<T>.NDEDPCCENPC[] ONKFHEJKFGN;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6F80", Offset = "0x2BD5580", VA = "0x182BD6F80")]
		public DHGAAFKIJLM(T[] JGENHCEEJFN, BDCDKFBMIEK<T> JJIMLMCHODB, int ENFKEDLGNNC, Func<bool> HODNLEGFFCJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B88F0", Offset = "0x6B7CF0")] T[] FANEPOHLFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2BD68D0", Offset = "0x2BD4ED0", VA = "0x182BD68D0")]
		public bool KIFKBLHODKJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U BOJBGKFMAFN<T, U>(int BOGMMAAMAPM, int ADIHPAOMLNM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8950", Offset = "0x6B7D50")] in ReadOnlySpan<T> MPEMJKKCMEP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x11DDBA0", Offset = "0x11DC1A0", VA = "0x1811DDBA0")]
	public static T[] COHENFEBNEN<T>(int OCMPILAHMAJ, T NLDHCNIHCDG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x11DDA10", Offset = "0x11DC010", VA = "0x1811DDA10")]
	public static void CHOLNGNCLKN<T>(this T[] IIDNANHGOHF, T NLDHCNIHCDG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x11DD960", Offset = "0x11DBF60", VA = "0x1811DD960")]
	public static void AOICFKCACKJ<T>(this T[] IACDCADJJAN, int GPAKLECDLDD, int BLJHHBOPKGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x11DEC30", Offset = "0x11DD230", VA = "0x1811DEC30")]
	private static void KNJOCLPLKKA<T>(this T[] CDBMADFDGCE, int PMAKDJDJFEB, int IOGACJBCKCD, T[] FKJGPCABBJN, int ECEPOIELKJP, int PCCCJINDCCG, T[] NKONLKNLFIB, int MLHLKMDDKNA, BDCDKFBMIEK<T> JJIMLMCHODB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x11DF030", Offset = "0x11DD630", VA = "0x1811DF030")]
	public static void PIJOBODKJDO<T>(this T[] CDBMADFDGCE, int FJBDCKBJAGA, int FJLPCOJGEJP, BDCDKFBMIEK<T> JJIMLMCHODB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x11DD810", Offset = "0x11DBE10", VA = "0x1811DD810")]
	public static DHGAAFKIJLM<T> ACBBMAHBNNI<T>(this T[] CDBMADFDGCE, BDCDKFBMIEK<T> JJIMLMCHODB, int ENFKEDLGNNC, Func<bool> HODNLEGFFCJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8830", Offset = "0x6B7C30")] T[] FANEPOHLFML) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x11DEC10", Offset = "0x11DD210", VA = "0x1811DEC10")]
	public static T[] IIIHGCMEKBN<T>(this T[] IACDCADJJAN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x11DDD20", Offset = "0x11DC320", VA = "0x1811DDD20")]
	public static T[] ECMEJLEIMBM<T>(this T[] MAFHNNJIBPN, T GHBOLNENBEO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x11DE570", Offset = "0x11DCB70", VA = "0x1811DE570")]
	public static T[] FOCENDCCGEP<T>(this T[] MAFHNNJIBPN, int OLGOBCPPPBB, T GHBOLNENBEO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x11DEB60", Offset = "0x11DD160", VA = "0x1811DEB60")]
	public static T[] ICHOHEPGKOH<T>(this T[] MAFHNNJIBPN, int OLGOBCPPPBB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x11DE340", Offset = "0x11DC940", VA = "0x1811DE340")]
	public static T[] FMEBCPNEFAL<T>(this T[] MAFHNNJIBPN, int OLGOBCPPPBB, T GHBOLNENBEO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x11DDE00", Offset = "0x11DC400", VA = "0x1811DDE00")]
	public static U[] FIFAABPDGKA<U, T>(this T[] PBLKKAHMFFL, int MEIIIDCLDCN, BOJBGKFMAFN<T, U> ANMHOFBFDBE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F94C60", Offset = "0x6F93260", VA = "0x186F94C60")]
	public static byte[] PIKKIBACPJP(this byte[] CDBMADFDGCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6F94A80", Offset = "0x6F93080", VA = "0x186F94A80")]
	public static byte[] HHHKEFNHEPB(this byte[] CDBMADFDGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class PPEPBBMACLF
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2313580", Offset = "0x2311B80", VA = "0x182313580")]
	public static void DGJIAOGEBKA<K, V>(this IDictionary<K, V> CDBMADFDGCE, in K BOMEFJIOGGM, in V MOLEJFDINLH, Func<V, V, V> EPMCHDDAOEI) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2313010", Offset = "0x2311610", VA = "0x182313010")]
	public static void DFPNJFAMBFH<K, V>(this IDictionary<K, List<V>> CDBMADFDGCE, in K BOMEFJIOGGM, in V MOLEJFDINLH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x23152E0", Offset = "0x23138E0", VA = "0x1823152E0")]
	public static TVal PJMFIHKLJJB<TVal, TKey>(this IDictionary<TKey, TVal> PPGANGPLNJB, in TKey BOMEFJIOGGM, [Optional][PGBBCIKIPBH("`default!` shouldn't be necessary in C# 9")] TVal INIEFLCMFEE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x23155F0", Offset = "0x2313BF0", VA = "0x1823155F0")]
	public static TVal PJMFIHKLJJB<TVal, TKey>(this IDictionary<TKey, TVal> PPGANGPLNJB, in TKey BOMEFJIOGGM, Func<TVal> OCFNLBAPFNM) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x23147C0", Offset = "0x2312DC0", VA = "0x1823147C0")]
	public static TValue NHHIBJFEODA<TValue, TKey>(this IDictionary<TKey, TValue> PPGANGPLNJB, in TKey BOMEFJIOGGM, [Optional][PGBBCIKIPBH("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue INIEFLCMFEE)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2313D30", Offset = "0x2312330", VA = "0x182313D30")]
	public static V MNCBKENBCIK<V, K>(this IDictionary<K, V> CDBMADFDGCE, in K BOMEFJIOGGM) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2314DF0", Offset = "0x23133F0", VA = "0x182314DF0")]
	public static T2[] NPOLMGAGOGC<T2, T1>(this Dictionary<T1, T2>.ValueCollection KLFFGGIBDCB) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2314A20", Offset = "0x2313020", VA = "0x182314A20")]
	public static bool NJPHEIIBGFB<TKey, TValue>(this IDictionary<TKey, TValue> CDBMADFDGCE, TKey BOMEFJIOGGM, TValue MOLEJFDINLH) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NFCAGNNLLIL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F95F50", Offset = "0x6F94550", VA = "0x186F95F50")]
	public static float3 HLNJBCFCBGJ(this in RigidTransform CDBMADFDGCE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F95E20", Offset = "0x6F94420", VA = "0x186F95E20")]
	public static float3 AOFKOMBAJNC(this in RigidTransform CDBMADFDGCE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x9A9A20", Offset = "0x9A8020", VA = "0x1809A9A20")]
	public static (float3, float3, float3) CMADLKBOJMF(this in RigidTransform CDBMADFDGCE)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F96080", Offset = "0x6F94680", VA = "0x186F96080")]
	public static RigidTransform OGEJMAKMNDP(this in RigidTransform CDBMADFDGCE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class AADGFDKFAAN
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xE15B20", Offset = "0xE14120", VA = "0x180E15B20")]
	public static bool PFDPJLFFHJD<T>(this IReadOnlyList<T> CDBMADFDGCE, int OLGOBCPPPBB, [PGBBCIKIPBH("This should be `T?` in C# 9.")][HLBOCLLKMAH(true)] out T NKONLKNLFIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xE159D0", Offset = "0xE13FD0", VA = "0x180E159D0")]
	public static bool OILEFJCMOIN<T>(this IReadOnlyList<T> CDBMADFDGCE, int OLGOBCPPPBB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8B30", Offset = "0x6B7F30")] out PCAAKDOPNBL<T> NKONLKNLFIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xE15950", Offset = "0xE13F50", VA = "0x180E15950")]
	public static T LFCMKBIIPNO<T>(this IReadOnlyList<T> CDBMADFDGCE, int OLGOBCPPPBB, in T MMALLFFFGCN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xE15920", Offset = "0xE13F20", VA = "0x180E15920")]
	[PGBBCIKIPBH("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T JKICDLEANKB<T>(this IReadOnlyList<T> CDBMADFDGCE, int OLGOBCPPPBB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xE15870", Offset = "0xE13E70", VA = "0x180E15870")]
	public static T? CPNIEEEBFJM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B8BE0", Offset = "0x6B7FE0")] this IReadOnlyList<T> CDBMADFDGCE, int OLGOBCPPPBB) where T : struct
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
