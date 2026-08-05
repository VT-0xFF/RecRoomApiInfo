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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F1DB10", Offset = "0x6F1CD10", VA = "0x186F1DB10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DEBBCGAGJBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BDA0", Offset = "0x6F1AFA0", VA = "0x186F1BDA0")]
	public static (float3, float3, float3) ACFEBKHGDPI(this in quaternion KPIHKJNPOFH)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DKJGKMDLHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29D3C40", Offset = "0x29D2E40", VA = "0x1829D3C40")]
	public static bool GNABIDCAAEG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFB30", Offset = "0x6AEF30")] this in ReadOnlyMemory<T> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFBA0", Offset = "0x6AEFA0")] in ReadOnlyMemory<T> JMNBIHILIIC) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29D3D60", Offset = "0x29D2F60", VA = "0x1829D3D60")]
	public static int MPHKONCPPDH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFC10", Offset = "0x6AF010")] this in ReadOnlyMemory<T?> KPIHKJNPOFH, int JCPEODFBLKC = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29D3E20", Offset = "0x29D3020", VA = "0x1829D3E20")]
	public static string PHFFNHNDOGD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFC80", Offset = "0x6AF080")] this in ReadOnlyMemory<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OPOHMOACIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34E0900", Offset = "0x34DFB00", VA = "0x1834E0900")]
	public static void HAIOOILOIBG<T>(this ICollection<T> KPIHKJNPOFH, IEnumerable<T> LPHPDIBJEMD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CPHFDLMHBMP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPNBBPDIBNP MNBEJFECGED();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CDCHOPOKJOI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NMIOGIBLHMD<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public NMIOGIBLHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D70280", Offset = "0x2D6F480", VA = "0x182D70280")]
		internal TElement GKOOFEMBIDN(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FDFAIEHJGAB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public FDFAIEHJGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1056E30", Offset = "0x1056030", VA = "0x181056E30")]
		internal int HFJCENHGHAF(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2233050", Offset = "0x2232250", VA = "0x182233050")]
	public static int MFAJIKAOLBF<T>(this IReadOnlyList<T> LMFDNLBGHBA, T NABCGCEIEGG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2234AF0", Offset = "0x2233CF0", VA = "0x182234AF0")]
	public static int OFBEIHAADBN<T>(this IReadOnlyList<T> LMFDNLBGHBA, T NABCGCEIEGG) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2232020", Offset = "0x2231220", VA = "0x182232020")]
	public static void HAIOOILOIBG<T>(this HashSet<T> PCGDJFIABMK, IEnumerable<T> LPHPDIBJEMD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22305A0", Offset = "0x222F7A0", VA = "0x1822305A0")]
	public static void FKJFCLPEIFM<T>(this IList<T> MLEOGHHEJOI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2230280", Offset = "0x222F480", VA = "0x182230280")]
	public static void FKJFCLPEIFM<T>(this IList<T> MLEOGHHEJOI, int PAMDLKDEJDG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2230190", Offset = "0x222F390", VA = "0x182230190")]
	public static List<T> FEMCNLFMEBO<T>(this List<T> CJNNEOGFKIK, Predicate<T> DDABNIBFKDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22338C0", Offset = "0x2232AC0", VA = "0x1822338C0")]
	public static int MFAJIKAOLBF<T>(this IReadOnlyList<T> MLEOGHHEJOI, Predicate<T> MCOBJMPEFEM) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2233BB0", Offset = "0x2232DB0", VA = "0x182233BB0")]
	public static bool NJBAADGFNLB<T>(this IReadOnlyList<T> MLEOGHHEJOI, Predicate<T> MCOBJMPEFEM, [AMJNMHIBJJF(true)] out List<int>? FGPMAMJJHFD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2234AA0", Offset = "0x2233CA0", VA = "0x182234AA0")]
	public static bool NOBHIKHJOLD<T>(this IReadOnlyList<T> MLEOGHHEJOI, T JJJLNAPHHCM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2234960", Offset = "0x2233B60", VA = "0x182234960")]
	public static bool NOBHIKHJOLD<T>(this IReadOnlyList<T> MLEOGHHEJOI, T JJJLNAPHHCM, EqualityComparer<T> NNHMIGOGOIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2230CB0", Offset = "0x222FEB0", VA = "0x182230CB0")]
	public static int GEEDEKMGNHB<TElement, TKey>(this IList<TElement> NDNGIEFLAFN, TKey IAMMBMHCCDF, Func<TElement, TKey> LAKLLKMHCNC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFD70", Offset = "0x6AF170")] Func<TKey, TKey, int> GCLLDGHPFIA, int NNAODBDJDNJ = 0, [Optional] int? BKHJHJOLNNF) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22309C0", Offset = "0x222FBC0", VA = "0x1822309C0")]
	public static int GEEDEKMGNHB<TElement, TKey>(Func<int, TElement> OOLFJLKHGBB, int LHDLHGCLFOO, TKey IAMMBMHCCDF, Func<TElement, TKey> LAKLLKMHCNC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFDD0", Offset = "0x6AF1D0")] Func<TKey, TKey, int> GCLLDGHPFIA, int NNAODBDJDNJ = 0, [Optional] int? BKHJHJOLNNF) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2232D90", Offset = "0x2231F90", VA = "0x182232D90")]
	public static List<T> KIMDAHBBEOO<T>(this IReadOnlyList<T> MLEOGHHEJOI, int BKHJHJOLNNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x222DBA0", Offset = "0x222CDA0", VA = "0x18222DBA0")]
	public static bool EGCGNODCMMA<T>(this List<T> MLEOGHHEJOI, T JJJLNAPHHCM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x222D830", Offset = "0x222CA30", VA = "0x18222D830")]
	public static void CFPEDBDGNGE<T>(this List<T> MLEOGHHEJOI, IEnumerable<T> CJNNEOGFKIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2232370", Offset = "0x2231570", VA = "0x182232370")]
	public static void HCICIMHFKFM<T>(this List<T> MLEOGHHEJOI, IEnumerable<T> CJNNEOGFKIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2232D30", Offset = "0x2231F30", VA = "0x182232D30")]
	public static T KENGENNECCJ<T>(this List<T> CJNNEOGFKIK, Predicate<T> DDABNIBFKDK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22329B0", Offset = "0x2231BB0", VA = "0x1822329B0")]
	public static T IJABCNONAHJ<T>(this List<T> CJNNEOGFKIK, int NNAODBDJDNJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2234D50", Offset = "0x2233F50", VA = "0x182234D50")]
	public static bool PKLOAHMGFDF<T>(this List<T> HMAGGKJELGF, List<T> DGAHHHOMDDO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x22322D0", Offset = "0x22314D0", VA = "0x1822322D0")]
	public static T HBBMOGPBNFE<T>(this IList<T> MLEOGHHEJOI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x222D770", Offset = "0x222C970", VA = "0x18222D770")]
	public static bool CAEMADLECEP<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFE30", Offset = "0x6AF230")] IReadOnlyList<T> MLEOGHHEJOI, int NNAODBDJDNJ, [DIKODGKOJKG(false)][MDIIFFDEIBC("This should be `T?` in C# 9.")] out T GAMJEJDMFJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x222F2D0", Offset = "0x222E4D0", VA = "0x18222F2D0")]
	public static bool EHKADJMLHKP<T>(IReadOnlyList<T> MLEOGHHEJOI, ICollection CJNNEOGFKIK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2232510", Offset = "0x2231710", VA = "0x182232510")]
	public static void HEONFOIPNMA<T>(IReadOnlyList<T> MLEOGHHEJOI, ref ICollection CJNNEOGFKIK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2232FF0", Offset = "0x22321F0", VA = "0x182232FF0")]
	public static bool KOBEJCLOMGG<T>(this IReadOnlyList<T> MLEOGHHEJOI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2232640", Offset = "0x2231840", VA = "0x182232640")]
	public static string HJBHGOAEGBF<T>(this IEnumerable<T> MLEOGHHEJOI, string PMAPONNHAEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2232C80", Offset = "0x2231E80", VA = "0x182232C80")]
	public static T INNKOKGBNOK<T>(this IList<T> KPIHKJNPOFH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22315C0", Offset = "0x22307C0", VA = "0x1822315C0")]
	public static T GEMKPFOPHCL<T>(this IList<T> KPIHKJNPOFH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2233B20", Offset = "0x2232D20", VA = "0x182233B20")]
	public static void MOLDFOJGPMP<T>(this IList<T> KPIHKJNPOFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x222D9F0", Offset = "0x222CBF0", VA = "0x18222D9F0")]
	public static void EFINPFIKCBI<T>(this IList<T> KPIHKJNPOFH, in T NABCGCEIEGG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2234CB0", Offset = "0x2233EB0", VA = "0x182234CB0")]
	public static T PFNOLLDCPIG<T>(this IList<T> KPIHKJNPOFH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2232820", Offset = "0x2231A20", VA = "0x182232820")]
	public static void IAKGLLIGIEE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6AFEE0", Offset = "0x6AF2E0")] this List<T> KPIHKJNPOFH) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MAHEBLKHDPN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KPCKEDMFNPB<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C10250", Offset = "0x2C0F450", VA = "0x182C10250", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
		[DebuggerHidden]
		public KPCKEDMFNPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2C10050", Offset = "0x2C0F250", VA = "0x182C10050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37D7CD0", Offset = "0x37D6ED0", VA = "0x1837D7CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2C10130", Offset = "0x2C0F330", VA = "0x182C10130", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x200B5E0", Offset = "0x200A7E0", VA = "0x18200B5E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B92810", Offset = "0x3B91A10", VA = "0x183B92810")]
	public static void PMBILEPGBFM<T>(this T APIDLMAPAPO, Action<T> EMOOAPFFNLK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B92770", Offset = "0x3B91970", VA = "0x183B92770")]
	public static V PAFHHMPBDCN<V, T>(this T APIDLMAPAPO, Func<T, V> EMOOAPFFNLK, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] V HMGHIIACOGF) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3B92560", Offset = "0x3B91760", VA = "0x183B92560")]
	public static T? EPNGEOJCCLK<T>(this T KPIHKJNPOFH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x19799D0", Offset = "0x1978BD0", VA = "0x1819799D0")]
	[IteratorStateMachine(typeof(KPCKEDMFNPB<>))]
	public static IEnumerable<T> MECGHOFLDGF<T>(this T KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B926F0", Offset = "0x3B918F0", VA = "0x183B926F0")]
	public static T[] LKDBHNJEFLL<T>(this T KPIHKJNPOFH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MDHBKPOLGGI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long GINFIMGAODK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GGKMGBADKMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MDHBKPOLGGI PINECDPMHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long LKNOBDCLLEB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C2B0", Offset = "0x6F1B4B0", VA = "0x186F1C2B0")]
	public GGKMGBADKMF(MDHBKPOLGGI JOOKLBMOOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C220", Offset = "0x6F1B420", VA = "0x186F1C220")]
	public long EOALJMLPKHE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C100", Offset = "0x6F1B300", VA = "0x186F1C100")]
	public double ALMEGILLNDA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C190", Offset = "0x6F1B390", VA = "0x186F1C190")]
	public double CLPLCBKEKFB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ELJDEEDJJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4618D10", Offset = "0x4617F10", VA = "0x184618D10")]
	public static bool KCLPFBMCAOK(this Type KPIHKJNPOFH, Type JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xF24D70", Offset = "0xF23F70", VA = "0x180F24D70")]
	public static bool KCLPFBMCAOK<T>(this Type KPIHKJNPOFH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KLJLJKNPBCL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BPFOLHNLIMK(int MJJPCAJLIED, int PCPODMLENHE);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float IDDLELLPIHM(float CMENLDKOHBG, float KNEFJDLJIOD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FCEJEPJMAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E1D0", Offset = "0x1E1D3D0", VA = "0x181E1E1D0")]
	public static void LOLPJHCGKNM<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0070", Offset = "0x6AF470")] this in KeyValuePair<TKey, TValue> KPIHKJNPOFH, out TKey JCEGKCPOPDM, out TValue NABCGCEIEGG) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E3B0", Offset = "0x1E1D5B0", VA = "0x181E1E3B0")]
	public static (TKey?, TValue?) MHNIKMPAFNO<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B00E0", Offset = "0x6AF4E0")] this in KeyValuePair<TKey?, TValue?> KPIHKJNPOFH)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E100", Offset = "0x1E1D300", VA = "0x181E1E100")]
	public static KeyValuePair<TKey?, UValue?> LJDFFMIJMOA<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0150", Offset = "0x6AF550")] this KeyValuePair<TKey?, TValue?> KPIHKJNPOFH, UValue NABCGCEIEGG)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MEMKJKGOKBK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9E350", Offset = "0x3B9D550", VA = "0x183B9E350")]
	[HCMLPCEGDDN("This should be replaced with the `is not` operator in C# 9.")]
	public static bool NKLLHOCKCLN<T>(this object KPIHKJNPOFH, [AMJNMHIBJJF(true)] out T GAMJEJDMFJF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IKCEBENCEON
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C830", Offset = "0x6F1BA30", VA = "0x186F1C830")]
	private static byte[] DGOMHKIIGOD(int FHNDOFLGIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D070", Offset = "0x6F1C270", VA = "0x186F1D070")]
	private static byte[] LEIINMMNKHJ(long MMONBDPEFON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C8B0", Offset = "0x6F1BAB0", VA = "0x186F1C8B0")]
	private static byte[] DHNNDJIEFBO(ulong MMONBDPEFON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D0F0", Offset = "0x6F1C2F0", VA = "0x186F1D0F0")]
	public static Guid MFPFOBKDBON(params Guid[] HBNKFHDGECB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CD70", Offset = "0x6F1BF70", VA = "0x186F1CD70")]
	public static Guid JKAAGGANCJG(in Guid AMHMKOMLFEE, int NNAODBDJDNJ, int KBIJDJHCEBH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CE40", Offset = "0x6F1C040", VA = "0x186F1CE40")]
	public static Guid JKAAGGANCJG(in Guid AMHMKOMLFEE, long NNAODBDJDNJ, int KBIJDJHCEBH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C930", Offset = "0x6F1BB30", VA = "0x186F1C930")]
	public static Guid JKAAGGANCJG(in Guid AMHMKOMLFEE, ulong NNAODBDJDNJ, int KBIJDJHCEBH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA00", Offset = "0x6F1BC00", VA = "0x186F1CA00")]
	public static Guid JKAAGGANCJG(in Guid AMHMKOMLFEE, in Guid ONGPOILONME, int KBIJDJHCEBH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CA70", Offset = "0x6F1BC70", VA = "0x186F1CA70")]
	private static Guid JKAAGGANCJG(in Guid AMHMKOMLFEE, byte[] PHDANKELMPJ, int KBIJDJHCEBH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CF10", Offset = "0x6F1C110", VA = "0x186F1CF10")]
	private static void KBOPPDMJIJJ(byte[] BHKAMCELBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F1CFF0", Offset = "0x6F1C1F0", VA = "0x186F1CFF0")]
	private static void KFALIPPLCCA(byte[] BHKAMCELBPN, int NPCLKEGHIKP, int NCHMBLEIGHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MIBJJDJGOHI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67138D0", Offset = "0x6712AD0", VA = "0x1867138D0")]
	public static uint NBHOGDIPCNF(this uint KPIHKJNPOFH, int BKHJHJOLNNF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x51C9AB0", Offset = "0x51C8CB0", VA = "0x1851C9AB0")]
	public static uint OJJKHFIMMMG(this uint KPIHKJNPOFH, int BKHJHJOLNNF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ENGANIMJHAC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C090", Offset = "0x6F1B290", VA = "0x186F1C090")]
	public static int MOGAAKLJEGK(this int KPIHKJNPOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C050", Offset = "0x6F1B250", VA = "0x186F1C050")]
	public static int LDHIIHDDABC(this int KPIHKJNPOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BFF0", Offset = "0x6F1B1F0", VA = "0x186F1BFF0")]
	public static int FGOHKNLAGIP(this int KPIHKJNPOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C040", Offset = "0x6F1B240", VA = "0x186F1C040")]
	public static int FJIKIEHIMPP(this int KPIHKJNPOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67138D0", Offset = "0x6712AD0", VA = "0x1867138D0")]
	public static int NBHOGDIPCNF(this int KPIHKJNPOFH, int BKHJHJOLNNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51C9AB0", Offset = "0x51C8CB0", VA = "0x1851C9AB0")]
	public static int OJJKHFIMMMG(this int KPIHKJNPOFH, int BKHJHJOLNNF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HFFONKMGNIN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E318D0", Offset = "0x1E30AD0", VA = "0x181E318D0")]
	public static bool BKKEODAJOIK<T, U>(this T KPIHKJNPOFH, in U PPNJOAJJOFF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E319E0", Offset = "0x1E30BE0", VA = "0x181E319E0")]
	public static bool LKPODHJHKNA<T>(ref T KPIHKJNPOFH, T JMNBIHILIIC) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NMMKANNMKPO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float CGLJGHHFNLN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float JHGCOADPGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool AKKDLMJEDAI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float DBFAOCJKCIG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D790", Offset = "0x6F1C990", VA = "0x186F1D790")]
	public static bool IOLFCPGMOGN(float GGFLAOCNMAP, float PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B9A0", Offset = "0x4F8ABA0", VA = "0x184F8B9A0")]
	public static float IFGIELBEGNN(float NABCGCEIEGG, float JGECELACBDE, float CBOHJJDJGAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B9C0", Offset = "0x4F8ABC0", VA = "0x184F8B9C0")]
	public static int IFGIELBEGNN(int NABCGCEIEGG, int JGECELACBDE, int CBOHJJDJGAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4F8B980", Offset = "0x4F8AB80", VA = "0x184F8B980")]
	public static float GLJEMFMNPPC(float NABCGCEIEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D950", Offset = "0x6F1CB50", VA = "0x186F1D950")]
	public static float LPLELFNKLEH(float GGFLAOCNMAP, float PIINDHALINJ, float APIDLMAPAPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D780", Offset = "0x6F1C980", VA = "0x186F1D780")]
	public static float DKLHGFMJPGL(float GGFLAOCNMAP, float PIINDHALINJ, float APIDLMAPAPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D890", Offset = "0x6F1CA90", VA = "0x186F1D890")]
	public static float JJHMDAOEOON(float GGFLAOCNMAP, float PIINDHALINJ, float NABCGCEIEGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D9F0", Offset = "0x6F1CBF0", VA = "0x186F1D9F0")]
	public static float OAGPEGMAPAM(float GGFLAOCNMAP, float PIINDHALINJ, float NABCGCEIEGG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NPBMGPNDOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x26EF0B0", Offset = "0x26EE2B0", VA = "0x1826EF0B0")]
	public static TValue IKIKAEHCFCA<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> KPIHKJNPOFH, TKey JCEGKCPOPDM) where TValue : class where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x26EED70", Offset = "0x26EDF70", VA = "0x1826EED70")]
	public static bool FGKPJBMHJEG<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> KPIHKJNPOFH, IReadOnlyDictionary<TKey, TValue> JMNBIHILIIC) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LPNBBPDIBNP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JAPNBMCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPKOFBJOIHM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HIFMLGEGPKM
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class JNNJAHNDDFB : KLJLJKNPBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random LGMGEAMHFMN;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D630", Offset = "0x6F1C830", VA = "0x186F1D630", Slot = "4")]
		public int BPFOLHNLIMK(int CMENLDKOHBG, int FOKODKMLHOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D6A0", Offset = "0x6F1C8A0", VA = "0x186F1D6A0", Slot = "5")]
		public float IDDLELLPIHM(float CMENLDKOHBG, float KNEFJDLJIOD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D660", Offset = "0x6F1C860", VA = "0x186F1D660")]
		private double FLKJILHAOKF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D710", Offset = "0x6F1C910", VA = "0x186F1D710")]
		public JNNJAHNDDFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KLJLJKNPBCL KIMDAHBBEOO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C320", Offset = "0x6F1B520", VA = "0x186F1C320")]
	public static ulong ALAPHPGDHGE()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MICLDLBKGBD
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool DPDIAOCMGPP<TArgs, T>(in TArgs LCGFCGNMPHN, T JJJLNAPHHCM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U CKPBBLMLOPJ<TArg, U>(in TArg CIKBJELAGAP);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U FLPDNMKIGKC<TArg, T, U>(in TArg CIKBJELAGAP, T GBFIIPCAAGJ);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U NFNOPAEMFMG<TArg, T, U>(in TArg CIKBJELAGAP, IEnumerable<T> FBIMPHNMCAK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U CKKJNCFEAGC<TArg, T, U>(in TArg CIKBJELAGAP, T GBFIIPCAAGJ);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct JGELPFFNHCA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2FFA560", Offset = "0x2FF9760", VA = "0x182FFA560")]
		[MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) KAOBJBKLIEP(T AAIAACOOMJF)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2FFA4F0", Offset = "0x2FF96F0", VA = "0x182FFA4F0")]
		[MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) JPKPAAPCKDE(IEnumerable<T> LBGJJIJKAMC)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BJOPFDMFMON<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
		[DebuggerHidden]
		public BJOPFDMFMON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2E57860", Offset = "0x2E56A60", VA = "0x182E57860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2E571B0", Offset = "0x2E563B0", VA = "0x182E571B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2E56A30", Offset = "0x2E55C30", VA = "0x182E56A30")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2E574A0", Offset = "0x2E566A0", VA = "0x182E574A0")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E57750", Offset = "0x2E56950", VA = "0x182E57750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2E57680", Offset = "0x2E56880", VA = "0x182E57680", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x22043F0", Offset = "0x22035F0", VA = "0x1822043F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DEHMFKBMGLH<T> : IEnumerable<(T, NODPJPPOKHP<T>)>, IEnumerable, IEnumerator<(T, NODPJPPOKHP<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, NODPJPPOKHP<T> Next) <>2__current;

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
		private (T, NODPJPPOKHP<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x21C6780", Offset = "0x21C5980", VA = "0x1821C6780", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, NODPJPPOKHP<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x21C6950", Offset = "0x21C5B50", VA = "0x1821C6950", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x21C6B20", Offset = "0x21C5D20", VA = "0x1821C6B20")]
		[DebuggerHidden]
		public DEHMFKBMGLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x21C6A00", Offset = "0x21C5C00", VA = "0x1821C6A00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x21C6100", Offset = "0x21C5300", VA = "0x1821C6100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x21C53F0", Offset = "0x21C45F0", VA = "0x1821C53F0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x21C6860", Offset = "0x21C5A60", VA = "0x1821C6860", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x21C6490", Offset = "0x21C5690", VA = "0x1821C6490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, NODPJPPOKHP<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2096BF0", Offset = "0x2095DF0", VA = "0x182096BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CEDHOGPCFIO<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0980", Offset = "0x6AFD80")]
		private Func<JGELPFFNHCA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0A70", Offset = "0x6AFE70")]
		public Func<JGELPFFNHCA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
		[DebuggerHidden]
		public CEDHOGPCFIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E51250", Offset = "0x1E50450", VA = "0x181E51250", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1E50D00", Offset = "0x1E4FF00", VA = "0x181E50D00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E50CB0", Offset = "0x1E4FEB0", VA = "0x181E50CB0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E510D0", Offset = "0x1E502D0", VA = "0x181E510D0")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E51210", Offset = "0x1E50410", VA = "0x181E51210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E51120", Offset = "0x1E50320", VA = "0x181E51120", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1E511E0", Offset = "0x1E503E0", VA = "0x181E511E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class BFMCPBLABHM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public BFMCPBLABHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2310F00", Offset = "0x2310100", VA = "0x182310F00")]
		internal bool KGEFEJBANLB(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2310EC0", Offset = "0x23100C0", VA = "0x182310EC0")]
		internal bool GBODFEPOEJK(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JIGKGHMBNPN<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Address(RVA = "0xA1FE10", Offset = "0xA1F010", VA = "0x180A1FE10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2927A70", Offset = "0x2926C70", VA = "0x182927A70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x21C6B20", Offset = "0x21C5D20", VA = "0x1821C6B20")]
		[DebuggerHidden]
		public JIGKGHMBNPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2927740", Offset = "0x2926940", VA = "0x182927740", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2927A30", Offset = "0x2926C30", VA = "0x182927A30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2927970", Offset = "0x2926B70", VA = "0x182927970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x20075F0", Offset = "0x20067F0", VA = "0x1820075F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1247B00", Offset = "0x1246D00", VA = "0x181247B00")]
	public static bool FICJDDNJLAA<T, TArgs>(this IEnumerable<T> KPIHKJNPOFH, in TArgs LCGFCGNMPHN, DPDIAOCMGPP<TArgs, T> MCOBJMPEFEM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1247410", Offset = "0x1246610", VA = "0x181247410")]
	public static U EPALAHEGPCH<U, T>(this IEnumerable<T> KPIHKJNPOFH, Func<U> GICJNODFCGH, Func<T, U> AAIAACOOMJF, Func<IEnumerable<T>, U> LBGJJIJKAMC) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1246ED0", Offset = "0x12460D0", VA = "0x181246ED0")]
	public static bool DLBOMHFMMFB<T, TArgs>(this IEnumerable<T> KPIHKJNPOFH, in TArgs LCGFCGNMPHN, DPDIAOCMGPP<TArgs, T> MCOBJMPEFEM) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1248030", Offset = "0x1247230", VA = "0x181248030")]
	public static U JNBIHJKAKOK<U, T, TArg>(this IEnumerable<T> KPIHKJNPOFH, in TArg CIKBJELAGAP, CKPBBLMLOPJ<TArg, U> GICJNODFCGH, FLPDNMKIGKC<TArg, T, U> AAIAACOOMJF, NFNOPAEMFMG<TArg, T, U> LBGJJIJKAMC) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x12483B0", Offset = "0x12475B0", VA = "0x1812483B0")]
	public static IEnumerable<U> LDHHNOCEMAB<U, T, TArg>(this IEnumerable<T> KPIHKJNPOFH, in TArg CIKBJELAGAP, CKKJNCFEAGC<TArg, T, U> MNDCACPEAPE) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1246AE0", Offset = "0x1245CE0", VA = "0x181246AE0")]
	public static IEnumerable<T> ANKOAGNBENP<T>(params IEnumerable<T>[] FNIOKCGMIPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1248C80", Offset = "0x1247E80", VA = "0x181248C80")]
	public static bool MLBPMEKEPJG<T>(this IEnumerable<T> FGIADOJFAEB, IEnumerable<T> JMNBIHILIIC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1246AE0", Offset = "0x1245CE0", VA = "0x181246AE0")]
	public static IEnumerable<(TKey?, TValue?)>? JPFHLBFLCIK<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B02A0", Offset = "0x6AF6A0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1248870", Offset = "0x1247A70", VA = "0x181248870")]
	public static IEnumerable<T> LIFDINBPMAP<T, TKey>(this IEnumerable<T> IALDCNICBMO, Func<T, TKey> AFBGKDMLNCK) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1248B20", Offset = "0x1247D20", VA = "0x181248B20")]
	[IteratorStateMachine(typeof(BJOPFDMFMON<, >))]
	public static IEnumerable<T> LOMBFLIHENN<T, U>(this IEnumerable<T> KPIHKJNPOFH, IEnumerable<U> JMNBIHILIIC, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] T BPCIBCBGCJD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1249190", Offset = "0x1248390", VA = "0x181249190")]
	public static T MNELDDDIFOD<T>(this IEnumerable<T> FGIADOJFAEB, T HMGHIIACOGF) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x12491C0", Offset = "0x12483C0", VA = "0x1812491C0")]
	public static T MNELDDDIFOD<T>(this IEnumerable<T> FGIADOJFAEB, T HMGHIIACOGF, Func<T, bool> MCOBJMPEFEM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1246840", Offset = "0x1245A40", VA = "0x181246840")]
	public static T? AMFDIBCKJJK<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0370", Offset = "0x6AF770")] this IEnumerable<T> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B03D0", Offset = "0x6AF7D0")] Func<T, bool> MCOBJMPEFEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1246E50", Offset = "0x1246050", VA = "0x181246E50")]
	[IteratorStateMachine(typeof(DEHMFKBMGLH<>))]
	public static IEnumerable<(T, NODPJPPOKHP<T>)> CFPOALIJLBI<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1247F40", Offset = "0x1247140", VA = "0x181247F40")]
	public static bool IHLONEINBPD<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1246AE0", Offset = "0x1245CE0", VA = "0x181246AE0")]
	public static IEnumerable<OBKFPJJEEAC<T>> BBOMBIMAMPK<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x12458F0", Offset = "0x1244AF0", VA = "0x1812458F0")]
	public static bool AIIPHFCAOIP<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1246CA0", Offset = "0x1245EA0", VA = "0x181246CA0")]
	public static IEnumerable<T> BFNEHLLFOCD<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1248BE0", Offset = "0x1247DE0", VA = "0x181248BE0")]
	[IteratorStateMachine(typeof(CEDHOGPCFIO<, >))]
	public static IEnumerable<U> MKODJLOBGKB<U, T>(this IEnumerable<T> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0500", Offset = "0x6AF900")] Func<JGELPFFNHCA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> FFOGCJIJHLL) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1249210", Offset = "0x1248410", VA = "0x181249210")]
	public static int MPHKONCPPDH<T>(this IEnumerable<T> KPIHKJNPOFH, int JCPEODFBLKC = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x12498B0", Offset = "0x1248AB0", VA = "0x1812498B0")]
	public static bool OEGFPLDJEDM<T>(this IEnumerable<T> KPIHKJNPOFH, IEnumerable<T> JMNBIHILIIC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1249600", Offset = "0x1248800", VA = "0x181249600")]
	public static (IEnumerable<T>, IEnumerable<T>) NAPIKLIOBDD<T>(this IEnumerable<T> KPIHKJNPOFH, Func<T, bool> ALNCLHNENDE) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1249C20", Offset = "0x1248E20", VA = "0x181249C20")]
	public static string PHFFNHNDOGD<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1248E40", Offset = "0x1248040", VA = "0x181248E40")]
	public static Dictionary<TKey?, TValue?>? MLDDDAAHHJJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B05F0", Offset = "0x6AF9F0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? FGIADOJFAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1248E40", Offset = "0x1248040", VA = "0x181248E40")]
	public static Dictionary<TKey?, TValue?>? MLDDDAAHHJJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0650", Offset = "0x6AFA50")] this IEnumerable<(TKey? Key, TValue? Value)>? FGIADOJFAEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1249EC0", Offset = "0x12490C0", VA = "0x181249EC0")]
	public static HashSet<T> PPOIHAJAAID<T>(this IEnumerable<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1249890", Offset = "0x1248A90", VA = "0x181249890")]
	public static string NIJEFJIFACH<T>(this IEnumerable<T> KPIHKJNPOFH, string JPLMPPDAJFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12487D0", Offset = "0x12479D0", VA = "0x1812487D0")]
	[IteratorStateMachine(typeof(JIGKGHMBNPN<, >))]
	public static IEnumerable<(T, U)> LHBGODLDLMK<T, U>(this IEnumerable<T> MHFLHKLCNGM, IEnumerable<U> NKPGENLIMOI) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1245BC0", Offset = "0x1244DC0", VA = "0x181245BC0")]
	public static IEnumerable<V> AJJALOHGADC<V, T, U>(this IEnumerable<T> KPIHKJNPOFH, IEnumerable<U> JMNBIHILIIC, Func<T, U, V> JBPPEFICLJH, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] T AMOBKPNOEJM, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] U EOBLGGHIKKD) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1245C50", Offset = "0x1244E50", VA = "0x181245C50")]
	public static IEnumerable<(T, U)> AJJALOHGADC<T, U>(this IEnumerable<T> KPIHKJNPOFH, IEnumerable<U> JMNBIHILIIC, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] T AMOBKPNOEJM, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] U EOBLGGHIKKD) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MBMKLOCBGKP
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D130", Offset = "0x3B9C330", VA = "0x183B9D130")]
	public static bool DFOOAGLIKAA<T>(this IReadOnlyCollection<T> KPIHKJNPOFH, int NNAODBDJDNJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BDAMGFNPBCN : MDHBKPOLGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch PINECDPMHKI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long GINFIMGAODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6F1B9C0", Offset = "0x6F1ABC0", VA = "0x186F1B9C0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8888D0", Offset = "0x887AD0", VA = "0x1808888D0")]
	private BDAMGFNPBCN(Stopwatch JOOKLBMOOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B9E0", Offset = "0x6F1ABE0", VA = "0x186F1B9E0")]
	public static BDAMGFNPBCN DDJPPBPCCKG(Stopwatch JOOKLBMOOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BA40", Offset = "0x6F1AC40", VA = "0x186F1BA40")]
	public static BDAMGFNPBCN EOEGFIBMAND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AMFLDLAKJIP
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B8F0", Offset = "0x6F1AAF0", VA = "0x186F1B8F0")]
	public static RigidTransform GPDIEJLFKLF(RigidTransform KFPBIJNAPEE, RigidTransform DLLDAKJOOOL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BFEEGMAJMON<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct JFLEMNKHODM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FF5510", Offset = "0x2FF4710", VA = "0x182FF5510", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int NPDEHGNCDCI;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static GGKMGBADKMF PMPNOPHLMGC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long GINFIMGAODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1ECEF40", Offset = "0x1ECE140", VA = "0x181ECEF40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2310D50", Offset = "0x230FF50", VA = "0x182310D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2310BB0", Offset = "0x230FDB0", VA = "0x182310BB0")]
	public static JFLEMNKHODM IPIFPLPEJKM()
	{
		return default(JFLEMNKHODM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2310A30", Offset = "0x230FC30", VA = "0x182310A30")]
	private static void HKOBECKGAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x23109D0", Offset = "0x230FBD0", VA = "0x1823109D0")]
	public static void FNKHNDBLOJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class PONAANCIEAN
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x23520B0", Offset = "0x23512B0", VA = "0x1823520B0")]
	public static bool GNABIDCAAEG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0F80", Offset = "0x6B0380")] this in ReadOnlySpan<T?> KPIHKJNPOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B0FF0", Offset = "0x6B03F0")] in ReadOnlySpan<T?> JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2352230", Offset = "0x2351430", VA = "0x182352230")]
	public static int MPHKONCPPDH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1060", Offset = "0x6B0460")] this in ReadOnlySpan<T?> KPIHKJNPOFH, int JCPEODFBLKC = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2352780", Offset = "0x2351980", VA = "0x182352780")]
	public static string PHFFNHNDOGD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B10D0", Offset = "0x6B04D0")] this in ReadOnlySpan<T> KPIHKJNPOFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2352350", Offset = "0x2351550", VA = "0x182352350")]
	public static string NIJEFJIFACH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1140", Offset = "0x6B0540")] this in ReadOnlySpan<T> KPIHKJNPOFH, string JPLMPPDAJFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EDBFJAKKAAO
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5549FD0", Offset = "0x55491D0", VA = "0x185549FD0")]
	public static bool KOBEJCLOMGG(this string? LFGPCDPDPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BEA0", Offset = "0x6F1B0A0", VA = "0x186F1BEA0")]
	public static string? BENLHABGGIA(this string? KPIHKJNPOFH, int JFAGLBDJNCF, string KANKOIBAMKB = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BF50", Offset = "0x6F1B150", VA = "0x186F1BF50")]
	public static string POCDENCPHJD(this string KPIHKJNPOFH, int JFAGLBDJNCF, string KANKOIBAMKB = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IHLDDCMLNCN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static MDHBKPOLGGI LPIMFDPGFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C6F0", Offset = "0x6F1B8F0", VA = "0x186F1C6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C660", Offset = "0x6F1B860", VA = "0x186F1C660")]
	public static double ALMEGILLNDA(this MDHBKPOLGGI KPIHKJNPOFH, long JKCMOBEIBKA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class JJBCNNPMBGM
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int MOOEHJIHFPH<T>(in T MHFLHKLCNGM, in T NKPGENLIMOI);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class PDHBINKBPHI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct EPDGAMENIGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int ILJCPGHFJPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int PHJMKIJHKPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool HAHLPLNPHBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int GGIPMGMIKKB;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x16417A0", Offset = "0x16409A0", VA = "0x1816417A0")]
			public EPDGAMENIGL(int ILJCPGHFJPN, int PHJMKIJHKPN, bool HAHLPLNPHBE)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] MJGNEBPIGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] AIOCFAKHODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly MOOEHJIHFPH<T> GCLLDGHPFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int OGLLEJHJBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> GNLDGFMKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int EJFFMJODNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1290", Offset = "0x6B0690")]
		private readonly PDHBINKBPHI<T>.EPDGAMENIGL[] GMHFDBIMILK;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2A253E0", Offset = "0x2A245E0", VA = "0x182A253E0")]
		public PDHBINKBPHI(T[] MJGNEBPIGKB, MOOEHJIHFPH<T> GCLLDGHPFIA, int OGLLEJHJBJF, Func<bool> GNLDGFMKGJB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B12F0", Offset = "0x6B06F0")] T[] AAHLGCMKJBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2A24D30", Offset = "0x2A23F30", VA = "0x182A24D30")]
		public bool JNFEDCNONBH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U JNFHEHKLNAD<T, U>(int HOCEFGAMCEO, int OCJGEMLLJHL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1350", Offset = "0x6B0750")] in ReadOnlySpan<T> IKINDAJOAJA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1B36150", Offset = "0x1B35350", VA = "0x181B36150")]
	public static T[] PMOIGGBFDPG<T>(int JPJMMBFGIEG, T BPCIBCBGCJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1B35680", Offset = "0x1B34880", VA = "0x181B35680")]
	public static void HPNPKKEDLKA<T>(this T[] HICDHKJKMMA, T BPCIBCBGCJD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1B34E90", Offset = "0x1B34090", VA = "0x181B34E90")]
	public static void CPPLGCOLCEG<T>(this T[] LMFDNLBGHBA, int LHPGLCOPMKK, int PDJKLGPIANM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1B35810", Offset = "0x1B34A10", VA = "0x181B35810")]
	private static void IJFDCFBJCNI<T>(this T[] KPIHKJNPOFH, int OGNGKEHIGFF, int DBODHGCFGGO, T[] JMNBIHILIIC, int OFPICHENDHK, int NEJCELDCLOJ, T[] GAMJEJDMFJF, int OFHOFLKBLMM, MOOEHJIHFPH<T> GCLLDGHPFIA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1B35C10", Offset = "0x1B34E10", VA = "0x181B35C10")]
	public static void OBIDOGLCAPH<T>(this T[] KPIHKJNPOFH, int ILJCPGHFJPN, int BKHJHJOLNNF, MOOEHJIHFPH<T> GCLLDGHPFIA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1B34F40", Offset = "0x1B34140", VA = "0x181B34F40")]
	public static PDHBINKBPHI<T> EBGFAAJNPEB<T>(this T[] KPIHKJNPOFH, MOOEHJIHFPH<T> GCLLDGHPFIA, int OGLLEJHJBJF, Func<bool> GNLDGFMKGJB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1230", Offset = "0x6B0630")] T[] AAHLGCMKJBC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1B34B90", Offset = "0x1B33D90", VA = "0x181B34B90")]
	public static T[] BNJEJADCLPJ<T>(this T[] LMFDNLBGHBA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1B36070", Offset = "0x1B35270", VA = "0x181B36070")]
	public static T[] OFNCKGIPECC<T>(this T[] KEIKNLAPONF, T NBNGAKEDGLD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1B34FE0", Offset = "0x1B341E0", VA = "0x181B34FE0")]
	public static T[] FKJFIHFDICM<T>(this T[] KEIKNLAPONF, int NNAODBDJDNJ, T NBNGAKEDGLD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1B355D0", Offset = "0x1B347D0", VA = "0x181B355D0")]
	public static T[] GHMODFDIGBG<T>(this T[] KEIKNLAPONF, int NNAODBDJDNJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1B34BB0", Offset = "0x1B33DB0", VA = "0x181B34BB0")]
	public static T[] BNLEKJDPGBP<T>(this T[] KEIKNLAPONF, int NNAODBDJDNJ, T NBNGAKEDGLD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1B34650", Offset = "0x1B33850", VA = "0x181B34650")]
	public static U[] BKCJNMGIBDO<U, T>(this T[] JLPNEGMFCHO, int KHGLOCNMPLP, JNFHEHKLNAD<T, U> IAEGEGCCAKA) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D450", Offset = "0x6F1C650", VA = "0x186F1D450")]
	public static byte[] GKDMOLPABBN(this byte[] KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D270", Offset = "0x6F1C470", VA = "0x186F1D270")]
	public static byte[] CPKIONJCMJM(this byte[] KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EIOEMLLBDFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xF16570", Offset = "0xF15770", VA = "0x180F16570")]
	public static void PIKCPIKKGMO<K, V>(this IDictionary<K, V> KPIHKJNPOFH, in K JCEGKCPOPDM, in V NABCGCEIEGG, Func<V, V, V> FHJJDKKLLOP) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xF14020", Offset = "0xF13220", VA = "0x180F14020")]
	public static void DDNJEPDOMBA<K, V>(this IDictionary<K, List<V>> KPIHKJNPOFH, in K JCEGKCPOPDM, in V NABCGCEIEGG) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xF14FC0", Offset = "0xF141C0", VA = "0x180F14FC0")]
	public static TVal FKNHCBBFMAG<TVal, TKey>(this IDictionary<TKey, TVal> JLHBIMEGIOJ, in TKey JCEGKCPOPDM, [Optional][MDIIFFDEIBC("`default!` shouldn't be necessary in C# 9")] TVal HMGHIIACOGF) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xF14B60", Offset = "0xF13D60", VA = "0x180F14B60")]
	public static TVal FKNHCBBFMAG<TVal, TKey>(this IDictionary<TKey, TVal> JLHBIMEGIOJ, in TKey JCEGKCPOPDM, Func<TVal> MMCLKBIMBKG) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xF15ED0", Offset = "0xF150D0", VA = "0x180F15ED0")]
	public static TValue IFCFEFCFLPA<TValue, TKey>(this IDictionary<TKey, TValue> JLHBIMEGIOJ, in TKey JCEGKCPOPDM, [Optional][MDIIFFDEIBC("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue HMGHIIACOGF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xF14590", Offset = "0xF13790", VA = "0x180F14590")]
	public static V FDBBCFCMLND<V, K>(this IDictionary<K, V> KPIHKJNPOFH, in K JCEGKCPOPDM) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xF15FA0", Offset = "0xF151A0", VA = "0x180F15FA0")]
	public static T2[] NCCCDPGJDOD<T2, T1>(this Dictionary<T1, T2>.ValueCollection AIAAEKKFPCF) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xF161B0", Offset = "0xF153B0", VA = "0x180F161B0")]
	public static bool OIGPBDDOPEF<TKey, TValue>(this IDictionary<TKey, TValue> KPIHKJNPOFH, TKey JCEGKCPOPDM, TValue NABCGCEIEGG) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CBOCGBBDBMA
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC70", Offset = "0x6F1AE70", VA = "0x186F1BC70")]
	public static float3 PHJODJKGOMI(this in RigidTransform KPIHKJNPOFH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BAE0", Offset = "0x6F1ACE0", VA = "0x186F1BAE0")]
	public static float3 EDLCFGJKJHA(this in RigidTransform KPIHKJNPOFH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xF83DA0", Offset = "0xF82FA0", VA = "0x180F83DA0")]
	public static (float3, float3, float3) PIDMGLDJIGE(this in RigidTransform KPIHKJNPOFH)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BC10", Offset = "0x6F1AE10", VA = "0x186F1BC10")]
	public static RigidTransform FNINIPDIKHN(this in RigidTransform KPIHKJNPOFH)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DLEBCALEFKK
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x29D3F50", Offset = "0x29D3150", VA = "0x1829D3F50")]
	public static bool DABKEEJNCNK<T>(this IReadOnlyList<T> KPIHKJNPOFH, int NNAODBDJDNJ, [MDIIFFDEIBC("This should be `T?` in C# 9.")][AMJNMHIBJJF(true)] out T GAMJEJDMFJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x29D4060", Offset = "0x29D3260", VA = "0x1829D4060")]
	public static bool NCOKIGNHHGF<T>(this IReadOnlyList<T> KPIHKJNPOFH, int NNAODBDJDNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B1530", Offset = "0x6B0930")] out OBKFPJJEEAC<T> GAMJEJDMFJF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x29D3FE0", Offset = "0x29D31E0", VA = "0x1829D3FE0")]
	public static T FNOMMLNCFLG<T>(this IReadOnlyList<T> KPIHKJNPOFH, int NNAODBDJDNJ, in T LKHOALJHHIM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B120", Offset = "0x1E2A320", VA = "0x181E2B120")]
	[MDIIFFDEIBC("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T IKIKAEHCFCA<T>(this IReadOnlyList<T> KPIHKJNPOFH, int NNAODBDJDNJ) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x29D4120", Offset = "0x29D3320", VA = "0x1829D4120")]
	public static T? OALEEDKKAOM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6B15E0", Offset = "0x6B09E0")] this IReadOnlyList<T> KPIHKJNPOFH, int NNAODBDJDNJ) where T : struct
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
