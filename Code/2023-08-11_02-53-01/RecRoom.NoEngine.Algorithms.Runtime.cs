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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ECB130", Offset = "0x6EC9930", VA = "0x186ECB130")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public static class LOEKKPHELHM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA120", Offset = "0x6EC8920", VA = "0x186ECA120")]
	public static (float3, float3, float3) AACLBLCLBFL(this in quaternion PECDBPPMOJP)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHMHKDMBIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CB5C10", Offset = "0x1CB4410", VA = "0x181CB5C10")]
	public static bool MGCOPBDNMJK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ABF50", Offset = "0x6AB350")] this in ReadOnlyMemory<T> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ABFC0", Offset = "0x6AB3C0")] in ReadOnlyMemory<T> OALEAAIPGBP) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1CB5B50", Offset = "0x1CB4350", VA = "0x181CB5B50")]
	public static int FLNHFHECMKO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC030", Offset = "0x6AB430")] this in ReadOnlyMemory<T?> PECDBPPMOJP, int LBFGPEPMMGJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1CB5AB0", Offset = "0x1CB42B0", VA = "0x181CB5AB0")]
	public static string BMAEGLAOLPG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC0A0", Offset = "0x6AB4A0")] this in ReadOnlyMemory<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DBCBOKJGHLO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3BE03A0", Offset = "0x3BDEBA0", VA = "0x183BE03A0")]
	public static void PHCLALLJMKM<T>(this ICollection<T> PECDBPPMOJP, IEnumerable<T> CJCFMILPBKA) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BPPACNHDPBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OENFDPLJBBC CAGNJFBILCM();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LDDJLEHFFFJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class ICIEBFPOFJG<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ICIEBFPOFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x19D2210", Offset = "0x19D0A10", VA = "0x1819D2210")]
		internal TElement PEPLHHONMFK(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AJPFGNLMAGK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public AJPFGNLMAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB6B6F0", Offset = "0xB69EF0", VA = "0x180B6B6F0")]
		internal int FIGDDMNOHIM(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8510", Offset = "0x1DA6D10", VA = "0x181DA8510")]
	public static int LCDFHGJPEMM<T>(this IReadOnlyList<T> DLLMPOAIBGN, T MENBIMCLIOI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DAACD0", Offset = "0x1DA94D0", VA = "0x181DAACD0")]
	public static int PPALEHIKKEI<T>(this IReadOnlyList<T> DLLMPOAIBGN, T MENBIMCLIOI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA160", Offset = "0x1DA8960", VA = "0x181DAA160")]
	public static void PHCLALLJMKM<T>(this HashSet<T> PCOEPPKNGNA, IEnumerable<T> CJCFMILPBKA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9040", Offset = "0x1DA7840", VA = "0x181DA9040")]
	public static void MDJABCEKJEL<T>(this IList<T> DFMKDLJIHMN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA90C0", Offset = "0x1DA78C0", VA = "0x181DA90C0")]
	public static void MDJABCEKJEL<T>(this IList<T> DFMKDLJIHMN, int MMBNJDONLFI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8420", Offset = "0x1DA6C20", VA = "0x181DA8420")]
	public static List<T> LBOAHFNNOEA<T>(this List<T> PJHFDJHMGDA, Predicate<T> EGMLKDOHBAG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8D80", Offset = "0x1DA7580", VA = "0x181DA8D80")]
	public static int LCDFHGJPEMM<T>(this IReadOnlyList<T> DFMKDLJIHMN, Predicate<T> PLKOLLLEBGA) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9D00", Offset = "0x1DA8500", VA = "0x181DA9D00")]
	public static bool ONCPDOHNJGN<T>(this IReadOnlyList<T> DFMKDLJIHMN, Predicate<T> PLKOLLLEBGA, [OBCNCOMAAEA(true)] out List<int>? EMCPHJIDOJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4DD0", Offset = "0x1DA35D0", VA = "0x181DA4DD0")]
	public static bool GFHBPLMLDGI<T>(this IReadOnlyList<T> DFMKDLJIHMN, T AMBKJGJJFNP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4E20", Offset = "0x1DA3620", VA = "0x181DA4E20")]
	public static bool GFHBPLMLDGI<T>(this IReadOnlyList<T> DFMKDLJIHMN, T AMBKJGJJFNP, EqualityComparer<T> HFFLNDGMJDI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7B00", Offset = "0x1DA6300", VA = "0x181DA7B00")]
	public static int IFKDBFDHDGC<TElement, TKey>(this IList<TElement> FCBHOCOKNHN, TKey JOJILGCIHBF, Func<TElement, TKey> BIPFKNIGACN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC190", Offset = "0x6AB590")] Func<TKey, TKey, int> OFONPCPMKBC, int AMOEKOMGDLG = 0, [Optional] int? JMKNAPEFDDB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DA7520", Offset = "0x1DA5D20", VA = "0x181DA7520")]
	public static int IFKDBFDHDGC<TElement, TKey>(Func<int, TElement> FFNBJCEPDHP, int DCDLPEJDJIA, TKey JOJILGCIHBF, Func<TElement, TKey> BIPFKNIGACN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC1F0", Offset = "0x6AB5F0")] Func<TKey, TKey, int> OFONPCPMKBC, int AMOEKOMGDLG = 0, [Optional] int? JMKNAPEFDDB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3B90", Offset = "0x1DA2390", VA = "0x181DA3B90")]
	public static List<T> FCPCCNBPDBB<T>(this IReadOnlyList<T> DFMKDLJIHMN, int JMKNAPEFDDB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3820", Offset = "0x1DA2020", VA = "0x181DA3820")]
	public static bool AILDMJBFDMF<T>(this List<T> DFMKDLJIHMN, T AMBKJGJJFNP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8260", Offset = "0x1DA6A60", VA = "0x181DA8260")]
	public static void KOPEIIJCEAM<T>(this List<T> DFMKDLJIHMN, IEnumerable<T> PJHFDJHMGDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3FD0", Offset = "0x1DA27D0", VA = "0x181DA3FD0")]
	public static void FNJGHMKCCPI<T>(this List<T> DFMKDLJIHMN, IEnumerable<T> PJHFDJHMGDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8FE0", Offset = "0x1DA77E0", VA = "0x181DA8FE0")]
	public static T LKNEHCOGEJJ<T>(this List<T> PJHFDJHMGDA, Predicate<T> EGMLKDOHBAG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA98B0", Offset = "0x1DA80B0", VA = "0x181DA98B0")]
	public static T NNHAKNLMCDD<T>(this List<T> PJHFDJHMGDA, int AMOEKOMGDLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3A40", Offset = "0x1DA2240", VA = "0x181DA3A40")]
	public static bool CFMNGGKIAFL<T>(this List<T> MGJKLDPAIFL, List<T> HEKIODDAIMM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8120", Offset = "0x1DA6920", VA = "0x181DA8120")]
	public static T JHEJPPBOECE<T>(this IList<T> DFMKDLJIHMN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3AD0", Offset = "0x1DA22D0", VA = "0x181DA3AD0")]
	public static bool CKJKJOLCKNM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC250", Offset = "0x6AB650")] IReadOnlyList<T> DFMKDLJIHMN, int AMOEKOMGDLG, [BLPKINHPFHO(false)][KPHHNAMNHGD("This should be `T?` in C# 9.")] out T LACIMGIMLFK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6900", Offset = "0x1DA5100", VA = "0x181DA6900")]
	public static bool HLBNACCHENA<T>(IReadOnlyList<T> DFMKDLJIHMN, ICollection PJHFDJHMGDA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9780", Offset = "0x1DA7F80", VA = "0x181DA9780")]
	public static void MKGGFLNCBMF<T>(IReadOnlyList<T> DFMKDLJIHMN, ref ICollection PJHFDJHMGDA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1DA74C0", Offset = "0x1DA5CC0", VA = "0x181DA74C0")]
	public static bool HLECLPEKMLM<T>(this IReadOnlyList<T> DFMKDLJIHMN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3DF0", Offset = "0x1DA25F0", VA = "0x181DA3DF0")]
	public static string FMGDMIJBDNC<T>(this IEnumerable<T> DFMKDLJIHMN, string GMGJFHMHEKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4240", Offset = "0x1DA2A40", VA = "0x181DA4240")]
	public static T GEEOKMJHBAD<T>(this IList<T> PECDBPPMOJP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DA99B0", Offset = "0x1DA81B0", VA = "0x181DA99B0")]
	public static T OHNOEFBHIAC<T>(this IList<T> PECDBPPMOJP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAC40", Offset = "0x1DA9440", VA = "0x181DAAC40")]
	public static void PPAINDGGIIM<T>(this IList<T> PECDBPPMOJP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9B50", Offset = "0x1DA8350", VA = "0x181DA9B50")]
	public static void OJNCMFAJINA<T>(this IList<T> PECDBPPMOJP, in T MENBIMCLIOI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DA81C0", Offset = "0x1DA69C0", VA = "0x181DA81C0")]
	public static T KJEIMMNINEF<T>(this IList<T> PECDBPPMOJP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4F60", Offset = "0x1DA3760", VA = "0x181DA4F60")]
	public static void GMGPCMDGDPO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC300", Offset = "0x6AB700")] this List<T> PECDBPPMOJP) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FHGBGCOLPGH
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BDOBIBFLAEM<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x218EC90", Offset = "0x218D490", VA = "0x18218EC90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2073B20", Offset = "0x2072320", VA = "0x182073B20")]
		[DebuggerHidden]
		public BDOBIBFLAEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x218EA10", Offset = "0x218D210", VA = "0x18218EA10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x218EC10", Offset = "0x218D410", VA = "0x18218EC10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x218EA90", Offset = "0x218D290", VA = "0x18218EA90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x218EBE0", Offset = "0x218D3E0", VA = "0x18218EBE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B86D90", Offset = "0x1B85590", VA = "0x181B86D90")]
	public static void BIDGDMLHJPB<T>(this T CIIALCPCBIG, Action<T> AKNNAECEOJP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1B86F40", Offset = "0x1B85740", VA = "0x181B86F40")]
	public static V EIDHHKJEALC<V, T>(this T CIIALCPCBIG, Func<T, V> AKNNAECEOJP, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] V GFJIAKNDNMH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B86E70", Offset = "0x1B85670", VA = "0x181B86E70")]
	public static T? DFINIEBJFAK<T>(this T PECDBPPMOJP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1061A00", Offset = "0x1060200", VA = "0x181061A00")]
	[IteratorStateMachine(typeof(BDOBIBFLAEM<>))]
	public static IEnumerable<T> AKJHBLOGHEN<T>(this T PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B87040", Offset = "0x1B85840", VA = "0x181B87040")]
	public static T[] IPKBMGBHOPF<T>(this T PECDBPPMOJP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HMODBJMJBPO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long EPGJLAAEJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CFGHDCPBGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HMODBJMJBPO BHAMIEINKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long JGJJBNCEAAC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC94D0", Offset = "0x6EC7CD0", VA = "0x186EC94D0")]
	public CFGHDCPBGCI(HMODBJMJBPO EAAMKHNFGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9440", Offset = "0x6EC7C40", VA = "0x186EC9440")]
	public long PJKNCODMLCB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EC93B0", Offset = "0x6EC7BB0", VA = "0x186EC93B0")]
	public double KCEILDKPHOF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9320", Offset = "0x6EC7B20", VA = "0x186EC9320")]
	public double FOIMEHCJKCD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FFNMFCMJGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4776EA0", Offset = "0x47756A0", VA = "0x184776EA0")]
	public static bool CGJEBEOFGKE(this Type PECDBPPMOJP, Type OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1B868F0", Offset = "0x1B850F0", VA = "0x181B868F0")]
	public static bool CGJEBEOFGKE<T>(this Type PECDBPPMOJP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JCELADLNOLA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HKNPIAMEEKA(int KHPEAIDBKOJ, int GBIIGNBIEGC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float PABBICFGBEK(float JPBGAKHJJHN, float LBNIEKDOFLB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JMKBNOAPGDB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26D9B80", Offset = "0x26D8380", VA = "0x1826D9B80")]
	public static void LCNJHOAPLCH<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC490", Offset = "0x6AB890")] this in KeyValuePair<TKey, TValue> PECDBPPMOJP, out TKey EECINICJCLK, out TValue MENBIMCLIOI) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x26D98F0", Offset = "0x26D80F0", VA = "0x1826D98F0")]
	public static (TKey?, TValue?) KJAIICLEENN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC500", Offset = "0x6AB900")] this in KeyValuePair<TKey?, TValue?> PECDBPPMOJP)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x26D9CB0", Offset = "0x26D84B0", VA = "0x1826D9CB0")]
	public static KeyValuePair<TKey?, UValue?> ODNJJFHGMPD<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC570", Offset = "0x6AB970")] this KeyValuePair<TKey?, TValue?> PECDBPPMOJP, UValue MENBIMCLIOI)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KALDGGJKLHD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x99D620", Offset = "0x99BE20", VA = "0x18099D620")]
	[MHJPGPDBDDN("This should be replaced with the `is not` operator in C# 9.")]
	public static bool KBHFDMJGKLP<T>(this object PECDBPPMOJP, [OBCNCOMAAEA(true)] out T LACIMGIMLFK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MPBJNOEBNHF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA6F0", Offset = "0x6EC8EF0", VA = "0x186ECA6F0")]
	private static byte[] AKIDFFNIPCK(int JJDPJCIHODM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA8D0", Offset = "0x6EC90D0", VA = "0x186ECA8D0")]
	private static byte[] IHCPGJPCING(long HNKJCPPFGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA850", Offset = "0x6EC9050", VA = "0x186ECA850")]
	private static byte[] GMMFLIOKEPK(ulong HNKJCPPFGPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA950", Offset = "0x6EC9150", VA = "0x186ECA950")]
	public static Guid JCAHCECMIBA(params Guid[] DEGFDLJNJPP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAF90", Offset = "0x6EC9790", VA = "0x186ECAF90")]
	public static Guid OIAKNFDBOOD(in Guid MFOGICDEGHA, int AMOEKOMGDLG, int MNJCDKNLLPF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAEC0", Offset = "0x6EC96C0", VA = "0x186ECAEC0")]
	public static Guid OIAKNFDBOOD(in Guid MFOGICDEGHA, long AMOEKOMGDLG, int MNJCDKNLLPF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB060", Offset = "0x6EC9860", VA = "0x186ECB060")]
	public static Guid OIAKNFDBOOD(in Guid MFOGICDEGHA, ulong AMOEKOMGDLG, int MNJCDKNLLPF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAB50", Offset = "0x6EC9350", VA = "0x186ECAB50")]
	public static Guid OIAKNFDBOOD(in Guid MFOGICDEGHA, in Guid EPMGFKCPNPO, int MNJCDKNLLPF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6ECABC0", Offset = "0x6EC93C0", VA = "0x186ECABC0")]
	private static Guid OIAKNFDBOOD(in Guid MFOGICDEGHA, byte[] OLJGMPHPHDI, int MNJCDKNLLPF = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA770", Offset = "0x6EC8F70", VA = "0x186ECA770")]
	private static void BCJKJDKLHCK(byte[] IBLFHKFALNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAAD0", Offset = "0x6EC92D0", VA = "0x186ECAAD0")]
	private static void KNADIBLJENA(byte[] IBLFHKFALNL, int KJDIMBCAJIJ, int EAIBHFHJJFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KBKEFHBCPAA
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x66DCA10", Offset = "0x66DB210", VA = "0x1866DCA10")]
	public static uint KMOKMPFJCOA(this uint PECDBPPMOJP, int JMKNAPEFDDB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5190590", Offset = "0x518ED90", VA = "0x185190590")]
	public static uint KINAAELMCAD(this uint PECDBPPMOJP, int JMKNAPEFDDB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MIKJKFELPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA2C0", Offset = "0x6EC8AC0", VA = "0x186ECA2C0")]
	public static int OMBIGCNJGEG(this int PECDBPPMOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA220", Offset = "0x6EC8A20", VA = "0x186ECA220")]
	public static int GDONKFAMPAJ(this int PECDBPPMOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA260", Offset = "0x6EC8A60", VA = "0x186ECA260")]
	public static int HKMHEJCPPIC(this int PECDBPPMOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA2B0", Offset = "0x6EC8AB0", VA = "0x186ECA2B0")]
	public static int NNFOMBLDLCK(this int PECDBPPMOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66DCA10", Offset = "0x66DB210", VA = "0x1866DCA10")]
	public static int KMOKMPFJCOA(this int PECDBPPMOJP, int JMKNAPEFDDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5190590", Offset = "0x518ED90", VA = "0x185190590")]
	public static int KINAAELMCAD(this int PECDBPPMOJP, int JMKNAPEFDDB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KAACBIMNEDC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x99D080", Offset = "0x99B880", VA = "0x18099D080")]
	public static bool HHDNLKOHIDG<T, U>(this T PECDBPPMOJP, in U CEPDEAHBHLF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x99D270", Offset = "0x99BA70", VA = "0x18099D270")]
	public static bool NNDHDEBGJDB<T>(ref T PECDBPPMOJP, T OALEAAIPGBP) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JLBILKLFFCD
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float PECBDAIHCGJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float EFHEAPBFKBL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool EHPHDOJLHGO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float FMFBFOGINPO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9D70", Offset = "0x6EC8570", VA = "0x186EC9D70")]
	public static bool LCBEPOAOLLH(float MBLAPCMEEGI, float NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50597F0", Offset = "0x5057FF0", VA = "0x1850597F0")]
	public static float OJKOLKJHCKI(float MENBIMCLIOI, float FFKEMABDPII, float JJHKIIGGPCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5059810", Offset = "0x5058010", VA = "0x185059810")]
	public static int OJKOLKJHCKI(int MENBIMCLIOI, int FFKEMABDPII, int JJHKIIGGPCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x50597D0", Offset = "0x5057FD0", VA = "0x1850597D0")]
	public static float NKOEHAPBIIJ(float MENBIMCLIOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9BD0", Offset = "0x6EC83D0", VA = "0x186EC9BD0")]
	public static float DIKMJBPAPLB(float MBLAPCMEEGI, float NBEGIGNBOIE, float CIIALCPCBIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9BC0", Offset = "0x6EC83C0", VA = "0x186EC9BC0")]
	public static float BPKBPKBLMAC(float MBLAPCMEEGI, float NBEGIGNBOIE, float CIIALCPCBIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9C70", Offset = "0x6EC8470", VA = "0x186EC9C70")]
	public static float ELDEDDCANPO(float MBLAPCMEEGI, float NBEGIGNBOIE, float MENBIMCLIOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9D30", Offset = "0x6EC8530", VA = "0x186EC9D30")]
	public static float IHEOFPGGJNE(float MBLAPCMEEGI, float NBEGIGNBOIE, float MENBIMCLIOI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CHDOPAEHGFP
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D870", Offset = "0x2D8C070", VA = "0x182D8D870")]
	public static TValue DJKBGBMKPAO<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> PECDBPPMOJP, TKey EECINICJCLK) where TValue : class where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DB10", Offset = "0x2D8C310", VA = "0x182D8DB10")]
	public static bool PCLCDILPILH<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> PECDBPPMOJP, IReadOnlyDictionary<TKey, TValue> OALEAAIPGBP) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OENFDPLJBBC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FJOACOHAPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMHPPOOGFGA();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FMABFNLPKDP
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class AKJDAAHFCPM : JCELADLNOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random KJKGOBKAFKB;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC91D0", Offset = "0x6EC79D0", VA = "0x186EC91D0", Slot = "4")]
		public int HKNPIAMEEKA(int JPBGAKHJJHN, int PKHOOALNBIL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9240", Offset = "0x6EC7A40", VA = "0x186EC9240", Slot = "5")]
		public float PABBICFGBEK(float JPBGAKHJJHN, float LBNIEKDOFLB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9200", Offset = "0x6EC7A00", VA = "0x186EC9200")]
		private double KILCOLLHCHD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EC92B0", Offset = "0x6EC7AB0", VA = "0x186EC92B0")]
		public AKJDAAHFCPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly JCELADLNOLA FCPCCNBPDBB;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9660", Offset = "0x6EC7E60", VA = "0x186EC9660")]
	public static ulong IPECPPGGCOG()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LNNODPDKPBE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool HAGCELPIMLP<TArgs, T>(in TArgs HPDOEALAHJH, T AMBKJGJJFNP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U EFMGEAOEOII<TArg, U>(in TArg FFIGANEHPFB);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U EKBKGDLMNPL<TArg, T, U>(in TArg FFIGANEHPFB, T MCEDLDGOIFG);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U DLCACLLCMCJ<TArg, T, U>(in TArg FFIGANEHPFB, IEnumerable<T> BODGCAEFMPH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U KDFFMFPEBPE<TArg, T, U>(in TArg FFIGANEHPFB, T MCEDLDGOIFG);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct NAAADNJHELK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2E360E0", Offset = "0x2E348E0", VA = "0x182E360E0")]
		[KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) FEMEKBLLDGK(T DGLGKIBBHCC)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2E36070", Offset = "0x2E34870", VA = "0x182E36070")]
		[KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) ELOKJAJOLBP(IEnumerable<T> APOJDLCHDHB)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AEOOHGJPELD<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2073B20", Offset = "0x2072320", VA = "0x182073B20")]
		[DebuggerHidden]
		public AEOOHGJPELD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x322A2C0", Offset = "0x3228AC0", VA = "0x18322A2C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3229490", Offset = "0x3227C90", VA = "0x183229490", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3229F00", Offset = "0x3228700", VA = "0x183229F00")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3229E00", Offset = "0x3228600", VA = "0x183229E00")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x322A1F0", Offset = "0x32289F0", VA = "0x18322A1F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x322A0E0", Offset = "0x32288E0", VA = "0x18322A0E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x21EAC50", Offset = "0x21E9450", VA = "0x1821EAC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class BAKGJGAEFGP<T> : IEnumerable<(T, IEHOCFMJKHE<T>)>, IEnumerable, IEnumerator<(T, IEHOCFMJKHE<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, IEHOCFMJKHE<T> Next) <>2__current;

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
		private (T, IEHOCFMJKHE<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x41C2940", Offset = "0x41C1140", VA = "0x1841C2940", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, IEHOCFMJKHE<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5505220", Offset = "0x5503A20", VA = "0x185505220", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2281DA0", Offset = "0x22805A0", VA = "0x182281DA0")]
		[DebuggerHidden]
		public BAKGJGAEFGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5505270", Offset = "0x5503A70", VA = "0x185505270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5504930", Offset = "0x5503130", VA = "0x185504930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5504D60", Offset = "0x5503560", VA = "0x185504D60")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5505180", Offset = "0x5503980", VA = "0x185505180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5505010", Offset = "0x5503810", VA = "0x185505010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, IEHOCFMJKHE<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB720", Offset = "0x1AA9F20", VA = "0x181AAB720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NGMBILBEGNF<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACDA0", Offset = "0x6AC1A0")]
		private Func<NAAADNJHELK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACE90", Offset = "0x6AC290")]
		public Func<NAAADNJHELK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2073B20", Offset = "0x2072320", VA = "0x182073B20")]
		[DebuggerHidden]
		public NGMBILBEGNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AB30", Offset = "0x4C29330", VA = "0x184C2AB30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A5C0", Offset = "0x4C28DC0", VA = "0x184C2A5C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A9E0", Offset = "0x4C291E0", VA = "0x184C2A9E0")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4C2A990", Offset = "0x4C29190", VA = "0x184C2A990")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AAF0", Offset = "0x4C292F0", VA = "0x184C2AAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C2AA30", Offset = "0x4C29230", VA = "0x184C2AA30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2710B50", Offset = "0x270F350", VA = "0x182710B50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HHGGMHOPKBM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public HHGGMHOPKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x29AA5E0", Offset = "0x29A8DE0", VA = "0x1829AA5E0")]
		internal bool LCKNKGAHIIH(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x29AA5A0", Offset = "0x29A8DA0", VA = "0x1829AA5A0")]
		internal bool DLMGHNMNGDG(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KKNPAPAOGGH<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xA64970", Offset = "0xA63170", VA = "0x180A64970", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2281D50", Offset = "0x2280550", VA = "0x182281D50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2281DA0", Offset = "0x22805A0", VA = "0x182281DA0")]
		[DebuggerHidden]
		public KKNPAPAOGGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2281A20", Offset = "0x2280220", VA = "0x182281A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2281D10", Offset = "0x2280510", VA = "0x182281D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2281C50", Offset = "0x2280450", VA = "0x182281C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2032050", Offset = "0x2030850", VA = "0x182032050", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1DB19C0", Offset = "0x1DB01C0", VA = "0x181DB19C0")]
	public static bool APFPFLFFKLO<T, TArgs>(this IEnumerable<T> PECDBPPMOJP, in TArgs HPDOEALAHJH, HAGCELPIMLP<TArgs, T> PLKOLLLEBGA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4400", Offset = "0x1DB2C00", VA = "0x181DB4400")]
	public static U KEJHFLCPLMG<U, T>(this IEnumerable<T> PECDBPPMOJP, Func<U> GFLIGPOFECC, Func<T, U> DGLGKIBBHCC, Func<IEnumerable<T>, U> APOJDLCHDHB) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3F90", Offset = "0x1DB2790", VA = "0x181DB3F90")]
	public static bool JFNLIPADMFB<T, TArgs>(this IEnumerable<T> PECDBPPMOJP, in TArgs HPDOEALAHJH, HAGCELPIMLP<TArgs, T> PLKOLLLEBGA) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4700", Offset = "0x1DB2F00", VA = "0x181DB4700")]
	public static U PKNGMCMNPHE<U, T, TArg>(this IEnumerable<T> PECDBPPMOJP, in TArg FFIGANEHPFB, EFMGEAOEOII<TArg, U> GFLIGPOFECC, EKBKGDLMNPL<TArg, T, U> DGLGKIBBHCC, DLCACLLCMCJ<TArg, T, U> APOJDLCHDHB) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2DD0", Offset = "0x1DB15D0", VA = "0x181DB2DD0")]
	public static IEnumerable<U> BEIFAOIAEMF<U, T, TArg>(this IEnumerable<T> PECDBPPMOJP, in TArg FFIGANEHPFB, KDFFMFPEBPE<TArg, T, U> PDGKFCFIMKC) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC6F0", Offset = "0x1CFAEF0", VA = "0x181CFC6F0")]
	public static IEnumerable<T> AEILCECLGCE<T>(params IEnumerable<T>[] BGKHHEKLIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0AA0", Offset = "0x1DAF2A0", VA = "0x181DB0AA0")]
	public static bool ACOABJILNAM<T>(this IEnumerable<T> ODHKMJMLAIP, IEnumerable<T> OALEAAIPGBP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC6F0", Offset = "0x1CFAEF0", VA = "0x181CFC6F0")]
	public static IEnumerable<(TKey?, TValue?)>? PCPJOOPGNBL<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC6C0", Offset = "0x6ABAC0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0FB0", Offset = "0x1DAF7B0", VA = "0x181DB0FB0")]
	public static IEnumerable<T> AENDOMANBOP<T, TKey>(this IEnumerable<T> GAGFOKAJOGM, Func<T, TKey> DAPGLEFGALL) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x159EBC0", Offset = "0x159D3C0", VA = "0x18159EBC0")]
	[IteratorStateMachine(typeof(AEOOHGJPELD<, >))]
	public static IEnumerable<T> AFCOHDPFMGN<T, U>(this IEnumerable<T> PECDBPPMOJP, IEnumerable<U> OALEAAIPGBP, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] T JHLHIFDPCDC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x10616E0", Offset = "0x105FEE0", VA = "0x1810616E0")]
	public static T LNPPGLNCBGD<T>(this IEnumerable<T> ODHKMJMLAIP, T GFJIAKNDNMH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB45B0", Offset = "0x1DB2DB0", VA = "0x181DB45B0")]
	public static T LNPPGLNCBGD<T>(this IEnumerable<T> ODHKMJMLAIP, T GFJIAKNDNMH, Func<T, bool> PLKOLLLEBGA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB2B30", Offset = "0x1DB1330", VA = "0x181DB2B30")]
	public static T? BDFAKAFPOOO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC790", Offset = "0x6ABB90")] this IEnumerable<T> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC7F0", Offset = "0x6ABBF0")] Func<T, bool> PLKOLLLEBGA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1061F50", Offset = "0x1060750", VA = "0x181061F50")]
	[IteratorStateMachine(typeof(BAKGJGAEFGP<>))]
	public static IEnumerable<(T, IEHOCFMJKHE<T>)> PJFMJKGHMGA<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4310", Offset = "0x1DB2B10", VA = "0x181DB4310")]
	public static bool JMFOGOBKFLL<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC6F0", Offset = "0x1CFAEF0", VA = "0x181CFC6F0")]
	public static IEnumerable<FJPNPFLKKKA<T>> JNDMMPHMODJ<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1BE0", Offset = "0x1DB03E0", VA = "0x181DB1BE0")]
	public static bool BCALMCDLPAM<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3800", Offset = "0x1DB2000", VA = "0x181DB3800")]
	public static IEnumerable<T> FKAHNHCIDEH<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x159EB20", Offset = "0x159D320", VA = "0x18159EB20")]
	[IteratorStateMachine(typeof(NGMBILBEGNF<, >))]
	public static IEnumerable<U> CFJPEHFFEBN<U, T>(this IEnumerable<T> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AC920", Offset = "0x6ABD20")] Func<NAAADNJHELK<U>, T, (bool Zero, U One, IEnumerable<U> Many)> NEOMHLGBMAE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3830", Offset = "0x1DB2030", VA = "0x181DB3830")]
	public static int FLNHFHECMKO<T>(this IEnumerable<T> PECDBPPMOJP, int LBFGPEPMMGJ = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3C20", Offset = "0x1DB2420", VA = "0x181DB3C20")]
	public static bool GIAKJPJIHFF<T>(this IEnumerable<T> PECDBPPMOJP, IEnumerable<T> OALEAAIPGBP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3570", Offset = "0x1DB1D70", VA = "0x181DB3570")]
	public static (IEnumerable<T>, IEnumerable<T>) EPGJENJAHIK<T>(this IEnumerable<T> PECDBPPMOJP, Func<T, bool> ABEOMMOFEEJ) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1DB33B0", Offset = "0x1DB1BB0", VA = "0x181DB33B0")]
	public static string BMAEGLAOLPG<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0C60", Offset = "0x1DAF460", VA = "0x181DB0C60")]
	public static Dictionary<TKey?, TValue?>? ADODMMEPODN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACA10", Offset = "0x6ABE10")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? ODHKMJMLAIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0C60", Offset = "0x1DAF460", VA = "0x181DB0C60")]
	public static Dictionary<TKey?, TValue?>? ADODMMEPODN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ACA70", Offset = "0x6ABE70")] this IEnumerable<(TKey? Key, TValue? Value)>? ODHKMJMLAIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1AEE010", Offset = "0x1AEC810", VA = "0x181AEE010")]
	public static HashSet<T> DGPIOGIKPLE<T>(this IEnumerable<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB0A80", Offset = "0x1DAF280", VA = "0x181DB0A80")]
	public static string ACMLFFMKGGC<T>(this IEnumerable<T> PECDBPPMOJP, string BLKFGEJPHCP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x159E9E0", Offset = "0x159D1E0", VA = "0x18159E9E0")]
	[IteratorStateMachine(typeof(KKNPAPAOGGH<, >))]
	public static IEnumerable<(T, U)> DCFMKINOFLF<T, U>(this IEnumerable<T> BENALFHNIOG, IEnumerable<U> EMAOEIAIOHA) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1EB0", Offset = "0x1DB06B0", VA = "0x181DB1EB0")]
	public static IEnumerable<V> BCLMOHNFNOC<V, T, U>(this IEnumerable<T> PECDBPPMOJP, IEnumerable<U> OALEAAIPGBP, Func<T, U, V> HAKOPDLBHPG, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] T DCNOBHEMBMK, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] U NJODPEFKOFP) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1F40", Offset = "0x1DB0740", VA = "0x181DB1F40")]
	public static IEnumerable<(T, U)> BCLMOHNFNOC<T, U>(this IEnumerable<T> PECDBPPMOJP, IEnumerable<U> OALEAAIPGBP, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] T DCNOBHEMBMK, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] U NJODPEFKOFP) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class GMGICAAMMPK
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1CA7740", Offset = "0x1CA5F40", VA = "0x181CA7740")]
	public static bool ICMDOFBAFGI<T>(this IReadOnlyCollection<T> PECDBPPMOJP, int AMOEKOMGDLG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CGJPCHAIBDJ : HMODBJMJBPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch BHAMIEINKMA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long EPGJLAAEJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9640", Offset = "0x6EC7E40", VA = "0x186EC9640", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	private CGJPCHAIBDJ(Stopwatch EAAMKHNFGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9540", Offset = "0x6EC7D40", VA = "0x186EC9540")]
	public static CGJPCHAIBDJ AANFABOIBEC(Stopwatch EAAMKHNFGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6EC95A0", Offset = "0x6EC7DA0", VA = "0x186EC95A0")]
	public static CGJPCHAIBDJ CDCPIICHFFE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GOLPFFKINFA
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9AF0", Offset = "0x6EC82F0", VA = "0x186EC9AF0")]
	public static RigidTransform BGDNDIAFCPC(RigidTransform ALFKLDNNNFF, RigidTransform KBKAFAHKFBO)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JJDONFFLHEA<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct MBHFABKKAHG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x210E360", Offset = "0x210CB60", VA = "0x18210E360", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int LFFJIKKBHLM;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static CFGHDCPBGCI JEHPDOCKMMJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long EPGJLAAEJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1A82ED0", Offset = "0x1A816D0", VA = "0x181A82ED0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x27C5D80", Offset = "0x27C4580", VA = "0x1827C5D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27C5B80", Offset = "0x27C4380", VA = "0x1827C5B80")]
	public static MBHFABKKAHG KNJNPBLMFBL()
	{
		return default(MBHFABKKAHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27C5A00", Offset = "0x27C4200", VA = "0x1827C5A00")]
	private static void INPILHIIPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27C5D20", Offset = "0x27C4520", VA = "0x1827C5D20")]
	public static void OGPDBFFONOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KMJNKIIEFGP
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x9AC4A0", Offset = "0x9AACA0", VA = "0x1809AC4A0")]
	public static bool MGCOPBDNMJK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD3A0", Offset = "0x6AC7A0")] this in ReadOnlySpan<T?> PECDBPPMOJP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD410", Offset = "0x6AC810")] in ReadOnlySpan<T?> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x9AC380", Offset = "0x9AAB80", VA = "0x1809AC380")]
	public static int FLNHFHECMKO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD480", Offset = "0x6AC880")] this in ReadOnlySpan<T?> PECDBPPMOJP, int LBFGPEPMMGJ = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x9AC200", Offset = "0x9AAA00", VA = "0x1809AC200")]
	public static string BMAEGLAOLPG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD4F0", Offset = "0x6AC8F0")] this in ReadOnlySpan<T> PECDBPPMOJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9ABDD0", Offset = "0x9AA5D0", VA = "0x1809ABDD0")]
	public static string ACMLFFMKGGC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD560", Offset = "0x6AC960")] this in ReadOnlySpan<T> PECDBPPMOJP, string BLKFGEJPHCP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FOCJGINMGCI
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5532790", Offset = "0x5530F90", VA = "0x185532790")]
	public static bool HLECLPEKMLM(this string? KFBMNNOPDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9A40", Offset = "0x6EC8240", VA = "0x186EC9A40")]
	public static string? HMEENIJNHGH(this string? PECDBPPMOJP, int GLAKJJLMGLI, string PLGNPKANEOC = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EC99A0", Offset = "0x6EC81A0", VA = "0x186EC99A0")]
	public static string CNKOOFLIKDJ(this string PECDBPPMOJP, int GLAKJJLMGLI, string PLGNPKANEOC = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class LLMGODCEIDK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static HMODBJMJBPO MLMNJLEKDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9F50", Offset = "0x6EC8750", VA = "0x186EC9F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9FB0", Offset = "0x6EC87B0", VA = "0x186EC9FB0")]
	public static double KCEILDKPHOF(this HMODBJMJBPO PECDBPPMOJP, long KJLPMLBEHLM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class MOLIFMOLIAK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int JJCCOEHLIAE<T>(in T BENALFHNIOG, in T EMAOEIAIOHA);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class IMLMEECGKLG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct GDACHMLDHBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int ODFELLLMBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int PDMIFOCHBHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool ONPPHJPNLCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int EJNEBBHCFDF;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x2E7CDE0", Offset = "0x2E7B5E0", VA = "0x182E7CDE0")]
			public GDACHMLDHBE(int ODFELLLMBAO, int PDMIFOCHBHB, bool ONPPHJPNLCO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] CFJMELGHCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] DKCGHMFIPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly JJCCOEHLIAE<T> OFONPCPMKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int HCMBGAJFHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> CLKINBLCDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int KNMIIEHNDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD6B0", Offset = "0x6ACAB0")]
		private readonly IMLMEECGKLG<T>.GDACHMLDHBE[] OFCMFJHKNHH;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x24AC1A0", Offset = "0x24AA9A0", VA = "0x1824AC1A0")]
		public IMLMEECGKLG(T[] CFJMELGHCLP, JJCCOEHLIAE<T> OFONPCPMKBC, int HCMBGAJFHOE, Func<bool> CLKINBLCDFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD710", Offset = "0x6ACB10")] T[] NANPMFJICJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x24ABE30", Offset = "0x24AA630", VA = "0x1824ABE30")]
		public bool ABMEOKOHMMN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U MKLCIPOAPNE<T, U>(int BNJGONEAOAD, int GIAMLLJMOHE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD770", Offset = "0x6ACB70")] in ReadOnlySpan<T> FPFPEKFFDCH);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D851E0", Offset = "0x1D839E0", VA = "0x181D851E0")]
	public static T[] FIKGOAEILKI<T>(int JIAHBEIKEJF, T JHLHIFDPCDC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D85EC0", Offset = "0x1D846C0", VA = "0x181D85EC0")]
	public static void NIAKBJOIGOH<T>(this T[] BJCKHIJAKJO, T JHLHIFDPCDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D85130", Offset = "0x1D83930", VA = "0x181D85130")]
	public static void DONECDNLGFF<T>(this T[] DLLMPOAIBGN, int NLNOELCPLOI, int HMNODDKFGDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D85AC0", Offset = "0x1D842C0", VA = "0x181D85AC0")]
	private static void NAOEBCBAJHM<T>(this T[] PECDBPPMOJP, int MIDHFABDPOD, int PPKGHJCKICI, T[] OALEAAIPGBP, int DNBGFPBJIHN, int MIJFJHEGMFP, T[] LACIMGIMLFK, int MPNDGELLDIN, JJCCOEHLIAE<T> OFONPCPMKBC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1D85660", Offset = "0x1D83E60", VA = "0x181D85660")]
	public static void JBCOFOEPGPK<T>(this T[] PECDBPPMOJP, int ODFELLLMBAO, int JMKNAPEFDDB, JJCCOEHLIAE<T> OFONPCPMKBC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1D84FE0", Offset = "0x1D837E0", VA = "0x181D84FE0")]
	public static IMLMEECGKLG<T> CAOCNPMDJEJ<T>(this T[] PECDBPPMOJP, JJCCOEHLIAE<T> OFONPCPMKBC, int HCMBGAJFHOE, Func<bool> CLKINBLCDFG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD650", Offset = "0x6ACA50")] T[] NANPMFJICJC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1D85360", Offset = "0x1D83B60", VA = "0x181D85360")]
	public static T[] FOKLKPIMOFE<T>(this T[] DLLMPOAIBGN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1D86590", Offset = "0x1D84D90", VA = "0x181D86590")]
	public static T[] OJOENEFMHMF<T>(this T[] GOGMOEDDELE, T ABHJCHDDOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1D86670", Offset = "0x1D84E70", VA = "0x181D86670")]
	public static T[] PEEGCNNAFGL<T>(this T[] GOGMOEDDELE, int AMOEKOMGDLG, T ABHJCHDDOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1D85380", Offset = "0x1D83B80", VA = "0x181D85380")]
	public static T[] GBHEEEABLON<T>(this T[] GOGMOEDDELE, int AMOEKOMGDLG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1D85430", Offset = "0x1D83C30", VA = "0x181D85430")]
	public static T[] HOIKOMEDGEP<T>(this T[] GOGMOEDDELE, int AMOEKOMGDLG, T ABHJCHDDOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1D86050", Offset = "0x1D84850", VA = "0x181D86050")]
	public static U[] NIAMPDOLPLD<U, T>(this T[] GFONPGDKJGC, int AAFFBFLDMNE, MKLCIPOAPNE<T, U> BDBBLKHFEGN) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA330", Offset = "0x6EC8B30", VA = "0x186ECA330")]
	public static byte[] MBMDOOFDOPN(this byte[] PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA510", Offset = "0x6EC8D10", VA = "0x186ECA510")]
	public static byte[] PGBKJHEBEGF(this byte[] PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ABIJKKPKELP
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x119D5E0", Offset = "0x119BDE0", VA = "0x18119D5E0")]
	public static void ELBIKBKDKDK<K, V>(this IDictionary<K, V> PECDBPPMOJP, in K EECINICJCLK, in V MENBIMCLIOI, Func<V, V, V> INGEDBEJDCL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x119DE10", Offset = "0x119C610", VA = "0x18119DE10")]
	public static void HCAHHFHFNPO<K, V>(this IDictionary<K, List<V>> PECDBPPMOJP, in K EECINICJCLK, in V MENBIMCLIOI) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x119F9D0", Offset = "0x119E1D0", VA = "0x18119F9D0")]
	public static TVal LBLGKCJONIB<TVal, TKey>(this IDictionary<TKey, TVal> DFAKGEGFEID, in TKey EECINICJCLK, [Optional][KPHHNAMNHGD("`default!` shouldn't be necessary in C# 9")] TVal GFJIAKNDNMH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x119F570", Offset = "0x119DD70", VA = "0x18119F570")]
	public static TVal LBLGKCJONIB<TVal, TKey>(this IDictionary<TKey, TVal> DFAKGEGFEID, in TKey EECINICJCLK, Func<TVal> DDANEKLKBDH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x119EB20", Offset = "0x119D320", VA = "0x18119EB20")]
	public static TValue IDJPJOBGJOA<TValue, TKey>(this IDictionary<TKey, TValue> DFAKGEGFEID, in TKey EECINICJCLK, [Optional][KPHHNAMNHGD("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue GFJIAKNDNMH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x119E4E0", Offset = "0x119CCE0", VA = "0x18119E4E0")]
	public static V HMEDKJLCHDF<V, K>(this IDictionary<K, V> PECDBPPMOJP, in K EECINICJCLK) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x11A02C0", Offset = "0x119EAC0", VA = "0x1811A02C0")]
	public static T2[] PHOBBLACAPH<T2, T1>(this Dictionary<T1, T2>.ValueCollection KKABKABJCMN) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x119F1C0", Offset = "0x119D9C0", VA = "0x18119F1C0")]
	public static bool KHFBCLPGPPL<TKey, TValue>(this IDictionary<TKey, TValue> PECDBPPMOJP, TKey EECINICJCLK, TValue MENBIMCLIOI) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PFAICEDMHKF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB350", Offset = "0x6EC9B50", VA = "0x186ECB350")]
	public static float3 LLBHBIDJPCF(this in RigidTransform PECDBPPMOJP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB220", Offset = "0x6EC9A20", VA = "0x186ECB220")]
	public static float3 GHMMJBFHEGM(this in RigidTransform PECDBPPMOJP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5BF0", Offset = "0xBA43F0", VA = "0x180BA5BF0")]
	public static (float3, float3, float3) LFKJIPFKFNB(this in RigidTransform PECDBPPMOJP)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB1C0", Offset = "0x6EC99C0", VA = "0x186ECB1C0")]
	public static RigidTransform FNIHMEJMAPG(this in RigidTransform PECDBPPMOJP)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BHAEJKKAGHC
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1E65A70", Offset = "0x1E64270", VA = "0x181E65A70")]
	public static bool CBDOACFHBEA<T>(this IReadOnlyList<T> PECDBPPMOJP, int AMOEKOMGDLG, [KPHHNAMNHGD("This should be `T?` in C# 9.")][OBCNCOMAAEA(true)] out T LACIMGIMLFK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1E65B00", Offset = "0x1E64300", VA = "0x181E65B00")]
	public static bool GLFAACGMPHA<T>(this IReadOnlyList<T> PECDBPPMOJP, int AMOEKOMGDLG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AD950", Offset = "0x6ACD50")] out FJPNPFLKKKA<T> LACIMGIMLFK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1E65C70", Offset = "0x1E64470", VA = "0x181E65C70")]
	public static T NFLCGDANHKK<T>(this IReadOnlyList<T> PECDBPPMOJP, int AMOEKOMGDLG, in T PBDJONDKMFC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x111C0E0", Offset = "0x111A8E0", VA = "0x18111C0E0")]
	[KPHHNAMNHGD("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T DJKBGBMKPAO<T>(this IReadOnlyList<T> PECDBPPMOJP, int AMOEKOMGDLG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1E65BC0", Offset = "0x1E643C0", VA = "0x181E65BC0")]
	public static T? LLLIMKINNDH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6ADA00", Offset = "0x6ACE00")] this IReadOnlyList<T> PECDBPPMOJP, int AMOEKOMGDLG) where T : struct
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
