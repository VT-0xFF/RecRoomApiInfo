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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72AD5A0", Offset = "0x72AC5A0", VA = "0x1872AD5A0")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
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
public static class BFIDOFMAHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72ABC20", Offset = "0x72AAC20", VA = "0x1872ABC20")]
	public static (float3, float3, float3) GNOCEENJNLL(this in quaternion FKGCCPKFEDE)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class POBJGCHINDD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A33E50", Offset = "0x3A32E50", VA = "0x183A33E50")]
	public static bool IJDEDFHKOIO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7257C0", Offset = "0x724BC0")] this in ReadOnlyMemory<T> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725830", Offset = "0x724C30")] in ReadOnlyMemory<T> BKLMLPFOMCO) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A33F70", Offset = "0x3A32F70", VA = "0x183A33F70")]
	public static int MMPHCPIBKFG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7258A0", Offset = "0x724CA0")] this in ReadOnlyMemory<T?> FKGCCPKFEDE, int GPJBKCICHOG = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A34030", Offset = "0x3A33030", VA = "0x183A34030")]
	public static string OOGAAHNOAGN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725910", Offset = "0x724D10")] this in ReadOnlyMemory<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NPEBIEOEJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2526ED0", Offset = "0x2525ED0", VA = "0x182526ED0")]
	public static void CPBFHNMHJPM<T>(this ICollection<T> FKGCCPKFEDE, IEnumerable<T> EICFKDEBBKD) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CCHCCILDEJO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDNPMOJIPLO KCKHOOIGOBL();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DEDKEHDGILD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class AILCJDEAKBF<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public AILCJDEAKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37DBAB0", Offset = "0x37DAAB0", VA = "0x1837DBAB0")]
		internal TElement BLHPFGJGMEC(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FCHJPHHCLJH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FCHJPHHCLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xF58570", Offset = "0xF57570", VA = "0x180F58570")]
		internal int ODHJEHOHPIJ(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23DD530", Offset = "0x23DC530", VA = "0x1823DD530")]
	public static int KNIMGMFCFDC<T>(this IReadOnlyList<T> GJAKHOONFBO, T CKDFGEALFAK) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23DC1D0", Offset = "0x23DB1D0", VA = "0x1823DC1D0")]
	public static int HCPOEIKLECK<T>(this IReadOnlyList<T> GJAKHOONFBO, T CKDFGEALFAK) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x23DA9A0", Offset = "0x23D99A0", VA = "0x1823DA9A0")]
	public static void CPBFHNMHJPM<T>(this HashSet<T> CIKMOFJNOHB, IEnumerable<T> EICFKDEBBKD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23DB830", Offset = "0x23DA830", VA = "0x1823DB830")]
	public static void GIEANJNHJHM<T>(this IList<T> BHINNEMAJAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x23DB8B0", Offset = "0x23DA8B0", VA = "0x1823DB8B0")]
	public static void GIEANJNHJHM<T>(this IList<T> BHINNEMAJAD, int PBEEALHHBIC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x23DB620", Offset = "0x23DA620", VA = "0x1823DB620")]
	public static List<T> ECMLJIJFAIA<T>(this List<T> OMMEOPKCKHJ, Predicate<T> ANLNEGECBOC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x23DDDA0", Offset = "0x23DCDA0", VA = "0x1823DDDA0")]
	public static int KNIMGMFCFDC<T>(this IReadOnlyList<T> BHINNEMAJAD, Predicate<T> MMKCMBDLNID) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23E1710", Offset = "0x23E0710", VA = "0x1823E1710")]
	public static bool PFAEKLHNEIG<T>(this IReadOnlyList<T> BHINNEMAJAD, Predicate<T> MMKCMBDLNID, [KPJJCLIPFEK(true)] out List<int>? JLHJKOHEHCG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x23DD4E0", Offset = "0x23DC4E0", VA = "0x1823DD4E0")]
	public static bool KAKGJPJGEDI<T>(this IReadOnlyList<T> BHINNEMAJAD, T JFJFAONKKJC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23DD3A0", Offset = "0x23DC3A0", VA = "0x1823DD3A0")]
	public static bool KAKGJPJGEDI<T>(this IReadOnlyList<T> BHINNEMAJAD, T JFJFAONKKJC, EqualityComparer<T> NPNOAOCBGIP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x23E0E00", Offset = "0x23DFE00", VA = "0x1823E0E00")]
	public static int OHCOCKFNPHE<TElement, TKey>(this IList<TElement> FEGMJHAAIIB, TKey NELCBBCBGJL, Func<TElement, TKey> DDBNMLBMIGO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725A00", Offset = "0x724E00")] Func<TKey, TKey, int> MNDAJKCBFKI, int CCELBNKPBGB = 0, [Optional] int? LEOAEOJMCHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x23E0B10", Offset = "0x23DFB10", VA = "0x1823E0B10")]
	public static int OHCOCKFNPHE<TElement, TKey>(Func<int, TElement> LOAKEGBBCDD, int MLJJAAFELGB, TKey NELCBBCBGJL, Func<TElement, TKey> DDBNMLBMIGO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725A60", Offset = "0x724E60")] Func<TKey, TKey, int> MNDAJKCBFKI, int CCELBNKPBGB = 0, [Optional] int? LEOAEOJMCHD) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x23DBF70", Offset = "0x23DAF70", VA = "0x1823DBF70")]
	public static List<T> GJJIMJFFAGD<T>(this IReadOnlyList<T> BHINNEMAJAD, int LEOAEOJMCHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x23DA680", Offset = "0x23D9680", VA = "0x1823DA680")]
	public static bool AMCJJEIHFCB<T>(this List<T> BHINNEMAJAD, T JFJFAONKKJC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x23DE310", Offset = "0x23DD310", VA = "0x1823DE310")]
	public static void NJMGMJNDPBJ<T>(this List<T> BHINNEMAJAD, IEnumerable<T> OMMEOPKCKHJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x23DB480", Offset = "0x23DA480", VA = "0x1823DB480")]
	public static void DNDEJFPIDIA<T>(this List<T> BHINNEMAJAD, IEnumerable<T> OMMEOPKCKHJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x23DB7D0", Offset = "0x23DA7D0", VA = "0x1823DB7D0")]
	public static T GDPLNINMLEO<T>(this List<T> OMMEOPKCKHJ, Predicate<T> ANLNEGECBOC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x23DCAD0", Offset = "0x23DBAD0", VA = "0x1823DCAD0")]
	public static T JGDHIDGEHJL<T>(this List<T> OMMEOPKCKHJ, int CCELBNKPBGB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x23E1B70", Offset = "0x23E0B70", VA = "0x1823E1B70")]
	public static bool POGMGJLEIFG<T>(this List<T> DOFMJJBOFBM, List<T> JAEPONBDPEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x23DA8A0", Offset = "0x23D98A0", VA = "0x1823DA8A0")]
	public static T AMJLHDEEEPD<T>(this IList<T> BHINNEMAJAD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23DB710", Offset = "0x23DA710", VA = "0x1823DB710")]
	public static bool EPMFGEOBGOF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725AC0", Offset = "0x724EC0")] IReadOnlyList<T> BHINNEMAJAD, int CCELBNKPBGB, [DGJABCNADMF(false)][NOBCHKPHFNC("This should be `T?` in C# 9.")] out T ALIHEMGMHCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23DFC50", Offset = "0x23DEC50", VA = "0x1823DFC50")]
	public static bool OGAAPCAKCMC<T>(IReadOnlyList<T> BHINNEMAJAD, ICollection OMMEOPKCKHJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23DC390", Offset = "0x23DB390", VA = "0x1823DC390")]
	public static void HDBEKHPDKDI<T>(IReadOnlyList<T> BHINNEMAJAD, ref ICollection OMMEOPKCKHJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23DA940", Offset = "0x23D9940", VA = "0x1823DA940")]
	public static bool BMJOILOKNGL<T>(this IReadOnlyList<T> BHINNEMAJAD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23DE560", Offset = "0x23DD560", VA = "0x1823DE560")]
	public static string NODDJJACGEO<T>(this IEnumerable<T> BHINNEMAJAD, string KDIMBCKJMKD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x23DE260", Offset = "0x23DD260", VA = "0x1823DE260")]
	public static T MHLCBBBHDIB<T>(this IList<T> FKGCCPKFEDE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23DC5F0", Offset = "0x23DB5F0", VA = "0x1823DC5F0")]
	public static T IEPFALBBBMD<T>(this IList<T> FKGCCPKFEDE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x23DE4D0", Offset = "0x23DD4D0", VA = "0x1823DE4D0")]
	public static void NNNDFHFENGG<T>(this IList<T> FKGCCPKFEDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x23DC790", Offset = "0x23DB790", VA = "0x1823DC790")]
	public static void INAPHHPAFID<T>(this IList<T> FKGCCPKFEDE, in T CKDFGEALFAK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23DC4C0", Offset = "0x23DB4C0", VA = "0x1823DC4C0")]
	public static T ICNOIKKOHKB<T>(this IList<T> FKGCCPKFEDE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23DC940", Offset = "0x23DB940", VA = "0x1823DC940")]
	public static void IPGBKGFBIOB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725B70", Offset = "0x724F70")] this List<T> FKGCCPKFEDE) where T : struct, IEquatable<T>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JPLCENLNNLN
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AJLEDFJILJN<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A026F0", Offset = "0x2A016F0", VA = "0x182A026F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public AJLEDFJILJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A024F0", Offset = "0x2A014F0", VA = "0x182A024F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x37E5D10", Offset = "0x37E4D10", VA = "0x1837E5D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2A02520", Offset = "0x2A01520", VA = "0x182A02520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBF8270", Offset = "0xBF7270", VA = "0x180BF8270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x248E890", Offset = "0x248D890", VA = "0x18248E890")]
	public static void JLAJANPGBKF<T>(this T EBIGDBKBHOG, Action<T> EHHJLGCIJJI) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x248E680", Offset = "0x248D680", VA = "0x18248E680")]
	public static V CMDHPKDCBAH<V, T>(this T EBIGDBKBHOG, Func<T, V> EHHJLGCIJJI, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] V PNJDHPAJOAO) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x248E800", Offset = "0x248D800", VA = "0x18248E800")]
	public static T? GMDFJBGFNJO<T>(this T FKGCCPKFEDE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8B20", Offset = "0x1FF7B20", VA = "0x181FF8B20")]
	[IteratorStateMachine(typeof(AJLEDFJILJN<>))]
	public static IEnumerable<T> KNDIMMLNJNF<T>(this T FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x248E8D0", Offset = "0x248D8D0", VA = "0x18248E8D0")]
	public static T[] POBNEHIILKA<T>(this T FKGCCPKFEDE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODLDBDJGPOC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long PIGHPNJIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BMFMEGHLGCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ODLDBDJGPOC MMKGNIHDBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long BPPFJPNIOKO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72ABFA0", Offset = "0x72AAFA0", VA = "0x1872ABFA0")]
	public BMFMEGHLGCN(ODLDBDJGPOC HFJHLAPGKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72ABE80", Offset = "0x72AAE80", VA = "0x1872ABE80")]
	public long JBFFPDKIHFF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72ABF10", Offset = "0x72AAF10", VA = "0x1872ABF10")]
	public double MOHCLFMBNEH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72ABDF0", Offset = "0x72AADF0", VA = "0x1872ABDF0")]
	public double DAJKBONOJJB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DDBILLJJKNF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49745D0", Offset = "0x49735D0", VA = "0x1849745D0")]
	public static bool FEKFFDGIFKN(this Type FKGCCPKFEDE, Type BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x23D9EC0", Offset = "0x23D8EC0", VA = "0x1823D9EC0")]
	public static bool FEKFFDGIFKN<T>(this Type FKGCCPKFEDE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DBPLEBCNCPO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MIOMIFPCBNB(int INNGLEGFBCM, int EANDNNJOGMC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float KCCOFBMMIHI(float NEJPNEDDKNA, float GKNKBKJFPKH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JJCACFHFPMA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x247AB40", Offset = "0x2479B40", VA = "0x18247AB40")]
	public static void NAFMJBCNPLE<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725D00", Offset = "0x725100")] this in KeyValuePair<TKey, TValue> FKGCCPKFEDE, out TKey LOHIKDGDMPP, out TValue CKDFGEALFAK) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x247A910", Offset = "0x2479910", VA = "0x18247A910")]
	public static (TKey?, TValue?) FAFMKONKEOP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725D70", Offset = "0x725170")] this in KeyValuePair<TKey?, TValue?> FKGCCPKFEDE)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x247A7E0", Offset = "0x24797E0", VA = "0x18247A7E0")]
	public static KeyValuePair<TKey?, UValue?> EAGICADCMNF<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725DE0", Offset = "0x7251E0")] this KeyValuePair<TKey?, TValue?> FKGCCPKFEDE, UValue CKDFGEALFAK)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NBLLLAMEOMH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2D5E040", Offset = "0x2D5D040", VA = "0x182D5E040")]
	[ABAOGEMOFAA("This should be replaced with the `is not` operator in C# 9.")]
	public static bool IKCDLOHHEDM<T>(this object FKGCCPKFEDE, [KPJJCLIPFEK(true)] out T ALIHEMGMHCE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ECKBHLBMFJD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72AC520", Offset = "0x72AB520", VA = "0x1872AC520")]
	private static byte[] DKJPCAIEOPF(int CFBIGFJEBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72AC420", Offset = "0x72AB420", VA = "0x1872AC420")]
	private static byte[] BLNIDIBDICG(long IGBCGICCDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72ACC60", Offset = "0x72ABC60", VA = "0x1872ACC60")]
	private static byte[] LMGEAIPLCBJ(ulong IGBCGICCDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72ACCE0", Offset = "0x72ABCE0", VA = "0x1872ACCE0")]
	public static Guid MOABAALPKFE(params Guid[] ICGKGJHABKL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72AC9E0", Offset = "0x72AB9E0", VA = "0x1872AC9E0")]
	public static Guid HFOCJEBDOBL(in Guid HMAHOGLOEHH, int CCELBNKPBGB, int ELKCHAMAHHH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72ACAB0", Offset = "0x72ABAB0", VA = "0x1872ACAB0")]
	public static Guid HFOCJEBDOBL(in Guid HMAHOGLOEHH, long CCELBNKPBGB, int ELKCHAMAHHH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72AC910", Offset = "0x72AB910", VA = "0x1872AC910")]
	public static Guid HFOCJEBDOBL(in Guid HMAHOGLOEHH, ulong CCELBNKPBGB, int ELKCHAMAHHH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72AC5A0", Offset = "0x72AB5A0", VA = "0x1872AC5A0")]
	public static Guid HFOCJEBDOBL(in Guid HMAHOGLOEHH, in Guid EMCOEBMKJJN, int ELKCHAMAHHH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72AC610", Offset = "0x72AB610", VA = "0x1872AC610")]
	private static Guid HFOCJEBDOBL(in Guid HMAHOGLOEHH, byte[] ENCNIPBPGOI, int ELKCHAMAHHH = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72ACB80", Offset = "0x72ABB80", VA = "0x1872ACB80")]
	private static void KBJBJDPMANG(byte[] PLBICILNGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72AC4A0", Offset = "0x72AB4A0", VA = "0x1872AC4A0")]
	private static void DAPKBKLHLHN(byte[] PLBICILNGEB, int EEDCFNGAAFO, int OFBPOJFNNIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NFOBBNFCAGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A998F0", Offset = "0x6A988F0", VA = "0x186A998F0")]
	public static uint LJBJMHOEPMJ(this uint FKGCCPKFEDE, int LEOAEOJMCHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54BDEE0", Offset = "0x54BCEE0", VA = "0x1854BDEE0")]
	public static uint OBDECNAEKBC(this uint FKGCCPKFEDE, int LEOAEOJMCHD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IEOOEAMDHFG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72AD050", Offset = "0x72AC050", VA = "0x1872AD050")]
	public static int LEINKIBHCMK(this int FKGCCPKFEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72AD010", Offset = "0x72AC010", VA = "0x1872AD010")]
	public static int LDJGNKDFPBL(this int FKGCCPKFEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72ACFB0", Offset = "0x72ABFB0", VA = "0x1872ACFB0")]
	public static int DFLBJHJJHHN(this int FKGCCPKFEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72AD000", Offset = "0x72AC000", VA = "0x1872AD000")]
	public static int DHPIAEJDCLI(this int FKGCCPKFEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A998F0", Offset = "0x6A988F0", VA = "0x186A998F0")]
	public static int LJBJMHOEPMJ(this int FKGCCPKFEDE, int LEOAEOJMCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54BDEE0", Offset = "0x54BCEE0", VA = "0x1854BDEE0")]
	public static int OBDECNAEKBC(this int FKGCCPKFEDE, int LEOAEOJMCHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ADEKKGIGHEM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xF15EA0", Offset = "0xF14EA0", VA = "0x180F15EA0")]
	public static bool KKEHLMIALBH<T, U>(this T FKGCCPKFEDE, in U EOHGDDIECBJ) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xF15E10", Offset = "0xF14E10", VA = "0x180F15E10")]
	public static bool JCCPGLPJGHK<T>(ref T FKGCCPKFEDE, T BKLMLPFOMCO) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AJHACJAGFHM
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float APIPAOAFDKI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float LDOHIDKLBIF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool AJHFMABCNBB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float OPOMNPBIMMM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72AB890", Offset = "0x72AA890", VA = "0x1872AB890")]
	public static bool CGLAOAKOAEJ(float LFEMLKHNBHE, float CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x45E8F60", Offset = "0x45E7F60", VA = "0x1845E8F60")]
	public static float BJFHDPANJPE(float CKDFGEALFAK, float LMBLJACJEIN, float KHIOAKAGFFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x45E8F80", Offset = "0x45E7F80", VA = "0x1845E8F80")]
	public static int BJFHDPANJPE(int CKDFGEALFAK, int LMBLJACJEIN, int KHIOAKAGFFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x45E8F40", Offset = "0x45E7F40", VA = "0x1845E8F40")]
	public static float AIEAFIIOIEP(float CKDFGEALFAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x72ABA50", Offset = "0x72AAA50", VA = "0x1872ABA50")]
	public static float DHBCGJGKNOE(float LFEMLKHNBHE, float CNOAFMMFDKH, float EBIGDBKBHOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x72ABAF0", Offset = "0x72AAAF0", VA = "0x1872ABAF0")]
	public static float KMAGDBGPKNF(float LFEMLKHNBHE, float CNOAFMMFDKH, float EBIGDBKBHOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x72AB990", Offset = "0x72AA990", VA = "0x1872AB990")]
	public static float CMBAPBJFJMM(float LFEMLKHNBHE, float CNOAFMMFDKH, float CKDFGEALFAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x72ABB00", Offset = "0x72AAB00", VA = "0x1872ABB00")]
	public static float OFLIENANFBK(float LFEMLKHNBHE, float CNOAFMMFDKH, float CKDFGEALFAK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class MJNPDCDMBPK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x16E6C80", Offset = "0x16E5C80", VA = "0x1816E6C80")]
	public static TValue AFGHBKPKGHC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> FKGCCPKFEDE, TKey LOHIKDGDMPP) where TValue : class where TKey : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IDNPMOJIPLO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOLMMDHAAMI();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PIGKGMAOMNN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class HCHGJCJCJIL : DBPLEBCNCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random ALMNABHHFKI;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x72ACF10", Offset = "0x72ABF10", VA = "0x1872ACF10", Slot = "4")]
		public int MIOMIFPCBNB(int NEJPNEDDKNA, int GKOGNDDGJNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x72ACEA0", Offset = "0x72ABEA0", VA = "0x1872ACEA0", Slot = "5")]
		public float KCCOFBMMIHI(float NEJPNEDDKNA, float GKNKBKJFPKH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x72ACE60", Offset = "0x72ABE60", VA = "0x1872ACE60")]
		private double AJNIMLKPDCJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72ACF40", Offset = "0x72ABF40", VA = "0x1872ACF40")]
		public HCHGJCJCJIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly DBPLEBCNCPO GJJIMJFFAGD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72AD630", Offset = "0x72AC630", VA = "0x1872AD630")]
	public static ulong JBIANFEGPOE()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HAFNNFMPIED
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool ACCKBLEMLDN<TArgs, T>(in TArgs CIIMHINGMLG, T JFJFAONKKJC);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U OFEJFLCKCOC<TArg, U>(in TArg IELOEMGHLEA);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U HNGJEBBPKBN<TArg, T, U>(in TArg IELOEMGHLEA, T DJGCJCMOFFD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U EFNCIDNKENK<TArg, T, U>(in TArg IELOEMGHLEA, IEnumerable<T> DLHPGJHCOIO);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U BCNLJEGMCDK<TArg, T, U>(in TArg IELOEMGHLEA, T DJGCJCMOFFD);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct IPOPFCNAICM<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xBFF750", Offset = "0xBFE750", VA = "0x180BFF750")]
		[NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) JIBDBLNJAML(T ACBJBLCMKOH)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xBFF6E0", Offset = "0xBFE6E0", VA = "0x180BFF6E0")]
		[NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) EILLDJCIHMC(IEnumerable<T> JLAEPFPMCNJ)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HOFOACJIHGF<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public HOFOACJIHGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D93F50", Offset = "0x2D92F50", VA = "0x182D93F50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D939A0", Offset = "0x2D929A0", VA = "0x182D939A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D93280", Offset = "0x2D92280", VA = "0x182D93280")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D93120", Offset = "0x2D92120", VA = "0x182D93120")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D93E80", Offset = "0x2D92E80", VA = "0x182D93E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D93C90", Offset = "0x2D92C90", VA = "0x182D93C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2208860", Offset = "0x2207860", VA = "0x182208860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ODNEGHDEAMN<T> : IEnumerable<(T, PNKOOPAALBA<T>)>, IEnumerable, IEnumerator<(T, PNKOOPAALBA<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, PNKOOPAALBA<T> Next) <>2__current;

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
		private (T, PNKOOPAALBA<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x3275B70", Offset = "0x3274B70", VA = "0x183275B70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, PNKOOPAALBA<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3275CE0", Offset = "0x3274CE0", VA = "0x183275CE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x24485E0", Offset = "0x24475E0", VA = "0x1824485E0")]
		[DebuggerHidden]
		public ODNEGHDEAMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3275DF0", Offset = "0x3274DF0", VA = "0x183275DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3274CA0", Offset = "0x3273CA0", VA = "0x183274CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3274810", Offset = "0x3273810", VA = "0x183274810")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3275BD0", Offset = "0x3274BD0", VA = "0x183275BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3275A10", Offset = "0x3274A10", VA = "0x183275A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, PNKOOPAALBA<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x12E63C0", Offset = "0x12E53C0", VA = "0x1812E63C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PJFNLJBBMED<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7265C0", Offset = "0x7259C0")]
		private Func<IPOPFCNAICM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7266B0", Offset = "0x725AB0")]
		public Func<IPOPFCNAICM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public PJFNLJBBMED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x205FFE0", Offset = "0x205EFE0", VA = "0x18205FFE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x205FB10", Offset = "0x205EB10", VA = "0x18205FB10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x205FAC0", Offset = "0x205EAC0", VA = "0x18205FAC0")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x205FA70", Offset = "0x205EA70", VA = "0x18205FA70")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x205FFA0", Offset = "0x205EFA0", VA = "0x18205FFA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x205FEE0", Offset = "0x205EEE0", VA = "0x18205FEE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x203C510", Offset = "0x203B510", VA = "0x18203C510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class CGFDCFDAHGO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public CGFDCFDAHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x12E48C0", Offset = "0x12E38C0", VA = "0x1812E48C0")]
		internal bool OELCHKELJBB(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x217B600", Offset = "0x217A600", VA = "0x18217B600")]
		internal bool FBEPIBLCKGI(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JIBENEDMENL<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBF8100", Offset = "0xBF7100", VA = "0x180BF8100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2448590", Offset = "0x2447590", VA = "0x182448590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x24485E0", Offset = "0x24475E0", VA = "0x1824485E0")]
		[DebuggerHidden]
		public JIBENEDMENL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2448260", Offset = "0x2447260", VA = "0x182448260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2448550", Offset = "0x2447550", VA = "0x182448550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2448490", Offset = "0x2447490", VA = "0x182448490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xC025E0", Offset = "0xC015E0", VA = "0x180C025E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26E27D0", Offset = "0x26E17D0", VA = "0x1826E27D0")]
	public static bool NGIPMEBKFJH<T, TArgs>(this IEnumerable<T> FKGCCPKFEDE, in TArgs CIIMHINGMLG, ACCKBLEMLDN<TArgs, T> MMKCMBDLNID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26DFA50", Offset = "0x26DEA50", VA = "0x1826DFA50")]
	public static U BJBHLNIMNBM<U, T>(this IEnumerable<T> FKGCCPKFEDE, Func<U> DNBHCNOJOOD, Func<T, U> ACBJBLCMKOH, Func<IEnumerable<T>, U> JLAEPFPMCNJ) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26E2C10", Offset = "0x26E1C10", VA = "0x1826E2C10")]
	public static bool OENEIFGKAME<T, TArgs>(this IEnumerable<T> FKGCCPKFEDE, in TArgs CIIMHINGMLG, ACCKBLEMLDN<TArgs, T> MMKCMBDLNID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26E02E0", Offset = "0x26DF2E0", VA = "0x1826E02E0")]
	public static U EFGGLBJNLNG<U, T, TArg>(this IEnumerable<T> FKGCCPKFEDE, in TArg IELOEMGHLEA, OFEJFLCKCOC<TArg, U> DNBHCNOJOOD, HNGJEBBPKBN<TArg, T, U> ACBJBLCMKOH, EFNCIDNKENK<TArg, T, U> JLAEPFPMCNJ) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26E1E70", Offset = "0x26E0E70", VA = "0x1826E1E70")]
	public static IEnumerable<U> MPFPMPAGCGI<U, T, TArg>(this IEnumerable<T> FKGCCPKFEDE, in TArg IELOEMGHLEA, BCNLJEGMCDK<TArg, T, U> EHOLPOGLFND) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C990", Offset = "0x1A6B990", VA = "0x181A6C990")]
	public static IEnumerable<T> DNNCIIKKLDN<T>(params IEnumerable<T>[] MGBHKGBKLCJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26E1460", Offset = "0x26E0460", VA = "0x1826E1460")]
	public static bool JMONNMKCNCD<T>(this IEnumerable<T> LPNPMOOMCIB, IEnumerable<T> BKLMLPFOMCO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C990", Offset = "0x1A6B990", VA = "0x181A6C990")]
	public static IEnumerable<(TKey?, TValue?)>? POAOBHOHFBI<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725F00", Offset = "0x725300")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26E1280", Offset = "0x26E0280", VA = "0x1826E1280")]
	public static IEnumerable<T> JDOJHCPLGCI<T, TKey>(this IEnumerable<T> AOPKJFKKJAJ, Func<T, TKey> CDIKFALLFMH) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE03240", Offset = "0xE02240", VA = "0x180E03240")]
	[IteratorStateMachine(typeof(HOFOACJIHGF<, >))]
	public static IEnumerable<T> KAPLENHNHJE<T, U>(this IEnumerable<T> FKGCCPKFEDE, IEnumerable<U> BKLMLPFOMCO, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] T OENDPBOGMKH) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x16A5FE0", Offset = "0x16A4FE0", VA = "0x1816A5FE0")]
	public static T GJAPJIPAMPH<T>(this IEnumerable<T> LPNPMOOMCIB, T PNJDHPAJOAO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26E1140", Offset = "0x26E0140", VA = "0x1826E1140")]
	public static T GJAPJIPAMPH<T>(this IEnumerable<T> LPNPMOOMCIB, T PNJDHPAJOAO, Func<T, bool> MMKCMBDLNID) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26E09A0", Offset = "0x26DF9A0", VA = "0x1826E09A0")]
	public static T? GCDKBIJMHKM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x725FC0", Offset = "0x7253C0")] this IEnumerable<T> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726020", Offset = "0x725420")] Func<T, bool> MMKCMBDLNID) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x21E2C10", Offset = "0x21E1C10", VA = "0x1821E2C10")]
	[IteratorStateMachine(typeof(ODNEGHDEAMN<>))]
	public static IEnumerable<(T, PNKOOPAALBA<T>)> AILAMLOBDBP<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26E1190", Offset = "0x26E0190", VA = "0x1826E1190")]
	public static bool GLEEHPJLCCI<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C990", Offset = "0x1A6B990", VA = "0x181A6C990")]
	public static IEnumerable<BKKDJNFDCIK<T>> EODOJNLPHFB<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26E1710", Offset = "0x26E0710", VA = "0x1826E1710")]
	public static bool LBFIGGIBIMI<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26DF710", Offset = "0x26DE710", VA = "0x1826DF710")]
	public static IEnumerable<T> AIBIJCJKNHM<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xE031A0", Offset = "0xE021A0", VA = "0x180E031A0")]
	[IteratorStateMachine(typeof(PJFNLJBBMED<, >))]
	public static IEnumerable<U> ELPNMKFFDDK<U, T>(this IEnumerable<T> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726150", Offset = "0x725550")] Func<IPOPFCNAICM<U>, T, (bool Zero, U One, IEnumerable<U> Many)> CPPDPOOJHJB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26E1A80", Offset = "0x26E0A80", VA = "0x1826E1A80")]
	public static int MMPHCPIBKFG<T>(this IEnumerable<T> FKGCCPKFEDE, int GPJBKCICHOG = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26E0130", Offset = "0x26DF130", VA = "0x1826E0130")]
	public static bool DPALPNDDIAC<T>(this IEnumerable<T> FKGCCPKFEDE, IEnumerable<T> BKLMLPFOMCO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26DF7C0", Offset = "0x26DE7C0", VA = "0x1826DF7C0")]
	public static (IEnumerable<T>, IEnumerable<T>) BDKKBKMGPJI<T>(this IEnumerable<T> FKGCCPKFEDE, Func<T, bool> FFCCDAFIFHP) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26E3310", Offset = "0x26E2310", VA = "0x1826E3310")]
	public static string OOGAAHNOAGN<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26E1730", Offset = "0x26E0730", VA = "0x1826E1730")]
	public static Dictionary<TKey?, TValue?>? LPFHAEBDCKD<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726240", Offset = "0x725640")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? LPNPMOOMCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x26E1730", Offset = "0x26E0730", VA = "0x1826E1730")]
	public static Dictionary<TKey?, TValue?>? LPFHAEBDCKD<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7262A0", Offset = "0x7256A0")] this IEnumerable<(TKey? Key, TValue? Value)>? LPNPMOOMCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1074000", Offset = "0x1073000", VA = "0x181074000")]
	public static HashSet<T> LIGBJEGBHCJ<T>(this IEnumerable<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x26E16F0", Offset = "0x26E06F0", VA = "0x1826E16F0")]
	public static string KPDDIGMLMHB<T>(this IEnumerable<T> FKGCCPKFEDE, string MIKKAKKFEKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xE03100", Offset = "0xE02100", VA = "0x180E03100")]
	[IteratorStateMachine(typeof(JIBENEDMENL<, >))]
	public static IEnumerable<(T, U)> OPKHOKIMEJM<T, U>(this IEnumerable<T> JMKFPOOBMEL, IEnumerable<U> OIMIHNAHPGP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26DFEB0", Offset = "0x26DEEB0", VA = "0x1826DFEB0")]
	public static IEnumerable<V> CMJMCGGJDBB<V, T, U>(this IEnumerable<T> FKGCCPKFEDE, IEnumerable<U> BKLMLPFOMCO, Func<T, U, V> CABIAJIIJEH, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] T DJPJCGJBFIK, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] U DFJIEJNOAEM) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26DFF40", Offset = "0x26DEF40", VA = "0x1826DFF40")]
	public static IEnumerable<(T, U)> CMJMCGGJDBB<T, U>(this IEnumerable<T> FKGCCPKFEDE, IEnumerable<U> BKLMLPFOMCO, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] T DJPJCGJBFIK, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] U DFJIEJNOAEM) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AFDMEPCABFI
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0xF18DF0", Offset = "0xF17DF0", VA = "0x180F18DF0")]
	public static bool JMLOIBOBBGO<T>(this IReadOnlyCollection<T> FKGCCPKFEDE, int CCELBNKPBGB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MKDGEFODLMF : ODLDBDJGPOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch MMKGNIHDBKI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long PIGHPNJIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72AD520", Offset = "0x72AC520", VA = "0x1872AD520", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	private MKDGEFODLMF(Stopwatch HFJHLAPGKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72AD540", Offset = "0x72AC540", VA = "0x1872AD540")]
	public static MKDGEFODLMF OPKJGCHLCLN(Stopwatch HFJHLAPGKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72AD480", Offset = "0x72AC480", VA = "0x1872AD480")]
	public static MKDGEFODLMF EEBKOBNOBFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BHFOOCBIKDA
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72ABD20", Offset = "0x72AAD20", VA = "0x1872ABD20")]
	public static RigidTransform GHOOHJGFCGG(RigidTransform FBNPCGEPNJA, RigidTransform OAKHKKADNIG)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class HKEHGDCKDHC<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct NGIMLNBBFFM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2432080", Offset = "0x2431080", VA = "0x182432080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int FPEHJPAGMLB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static BMFMEGHLGCN OFJHJNHNGKC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long PIGHPNJIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F5AF40", Offset = "0x1F59F40", VA = "0x181F5AF40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x28467B0", Offset = "0x28457B0", VA = "0x1828467B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2846490", Offset = "0x2845490", VA = "0x182846490")]
	public static NGIMLNBBFFM BIGPOADDILD()
	{
		return default(NGIMLNBBFFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2846630", Offset = "0x2845630", VA = "0x182846630")]
	private static void FMBMPECGIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2846810", Offset = "0x2845810", VA = "0x182846810")]
	public static void NJJHHEGPENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OJHDLNLGHJB
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x336D9C0", Offset = "0x336C9C0", VA = "0x18336D9C0")]
	public static bool IJDEDFHKOIO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726C00", Offset = "0x726000")] this in ReadOnlySpan<T?> FKGCCPKFEDE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726C70", Offset = "0x726070")] in ReadOnlySpan<T?> BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x336E290", Offset = "0x336D290", VA = "0x18336E290")]
	public static int MMPHCPIBKFG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726CE0", Offset = "0x7260E0")] this in ReadOnlySpan<T?> FKGCCPKFEDE, int GPJBKCICHOG = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x336E3B0", Offset = "0x336D3B0", VA = "0x18336E3B0")]
	public static string OOGAAHNOAGN<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726D50", Offset = "0x726150")] this in ReadOnlySpan<T> FKGCCPKFEDE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x336DB40", Offset = "0x336CB40", VA = "0x18336DB40")]
	public static string KPDDIGMLMHB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726DC0", Offset = "0x7261C0")] this in ReadOnlySpan<T> FKGCCPKFEDE, string MIKKAKKFEKL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DPKMBPDDABC
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5864420", Offset = "0x5863420", VA = "0x185864420")]
	public static bool BMJOILOKNGL(this string? IOEEMDDJCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72AC2D0", Offset = "0x72AB2D0", VA = "0x1872AC2D0")]
	public static string? GFOHKGOIONH(this string? FKGCCPKFEDE, int HMFMJIGINKG, string MHCCGANONBD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x72AC380", Offset = "0x72AB380", VA = "0x1872AC380")]
	public static string NGBHKHHDPCH(this string FKGCCPKFEDE, int HMFMJIGINKG, string MHCCGANONBD = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AEDBKEJCFMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static ODLDBDJGPOC GCJOKFEJMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x72AB6C0", Offset = "0x72AA6C0", VA = "0x1872AB6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x72AB720", Offset = "0x72AA720", VA = "0x1872AB720")]
	public static double MOHCLFMBNEH(this ODLDBDJGPOC FKGCCPKFEDE, long GEEIJNEEKPO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class JEFKHDJBPAJ
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int KNEOABHEJOL<T>(in T JMKFPOOBMEL, in T OIMIHNAHPGP);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class JMBCCEDIJNJ<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct MMBECKEGHAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int PDAGAKEPNHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int CNBKBHMOMJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool CMJNODOPLCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int OMHAEOFOCFO;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F84C00", Offset = "0x2F83C00", VA = "0x182F84C00")]
			public MMBECKEGHAL(int PDAGAKEPNHP, int CNBKBHMOMJM, bool CMJNODOPLCK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] BFGPPDLHHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] COGLMBMCBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly KNEOABHEJOL<T> MNDAJKCBFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int LMAPCCEFEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> BAMBKOJLEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int DJEDHCHFHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726F10", Offset = "0x726310")]
		private readonly JMBCCEDIJNJ<T>.MMBECKEGHAL[] ANJLEKPNFFH;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB090", Offset = "0x2DFA090", VA = "0x182DFB090")]
		public JMBCCEDIJNJ(T[] BFGPPDLHHOO, KNEOABHEJOL<T> MNDAJKCBFKI, int LMAPCCEFEKD, Func<bool> BAMBKOJLEGM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726F70", Offset = "0x726370")] T[] EOOINDHEAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA9E0", Offset = "0x2DF99E0", VA = "0x182DFA9E0")]
		public bool NIIOEOFLBIL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U OJBAAMNOBJD<T, U>(int EKDEFAGLGIP, int IAPALNKLFBG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726FD0", Offset = "0x7263D0")] in ReadOnlySpan<T> BFELONJEEBN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x25958C0", Offset = "0x25948C0", VA = "0x1825958C0")]
	public static T[] EAJAJMIMFOF<T>(int BKMCHKCIDOC, T OENDPBOGMKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2595EA0", Offset = "0x2594EA0", VA = "0x182595EA0")]
	public static void FFGMDEPFFPE<T>(this T[] EAOJGADMNFI, T OENDPBOGMKH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x169DBC0", Offset = "0x169CBC0", VA = "0x18169DBC0")]
	public static void HANMFNPHLNL<T>(this T[] GJAKHOONFBO, int KJPGMJFNNHE, int GNDBEEGAOAG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x25954A0", Offset = "0x25944A0", VA = "0x1825954A0")]
	private static void AGFMONBOGFE<T>(this T[] FKGCCPKFEDE, int DCECMNABPLC, int IIABIPJJPBP, T[] BKLMLPFOMCO, int BMKHNJIJIKC, int EAKCCCLFLEJ, T[] ALIHEMGMHCE, int AIELDHNOPIA, KNEOABHEJOL<T> MNDAJKCBFKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2595A40", Offset = "0x2594A40", VA = "0x182595A40")]
	public static void EOFPFMKLCHF<T>(this T[] FKGCCPKFEDE, int PDAGAKEPNHP, int LEOAEOJMCHD, KNEOABHEJOL<T> MNDAJKCBFKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2596310", Offset = "0x2595310", VA = "0x182596310")]
	public static JMBCCEDIJNJ<T> NAGFOLKNJFA<T>(this T[] FKGCCPKFEDE, KNEOABHEJOL<T> MNDAJKCBFKI, int LMAPCCEFEKD, Func<bool> BAMBKOJLEGM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x726EB0", Offset = "0x7262B0")] T[] EOOINDHEAGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x25958A0", Offset = "0x25948A0", VA = "0x1825958A0")]
	public static T[] BBDJIBMOAAJ<T>(this T[] GJAKHOONFBO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2596460", Offset = "0x2595460", VA = "0x182596460")]
	public static T[] NOMBAMAEJCD<T>(this T[] IFDDIFGJFLM, T KHKEEEMOFBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2596540", Offset = "0x2595540", VA = "0x182596540")]
	public static T[] NPOIELNMBOE<T>(this T[] IFDDIFGJFLM, int CCELBNKPBGB, T KHKEEEMOFBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x25963B0", Offset = "0x25953B0", VA = "0x1825963B0")]
	public static T[] NCENKDECAHL<T>(this T[] IFDDIFGJFLM, int CCELBNKPBGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x25960E0", Offset = "0x25950E0", VA = "0x1825960E0")]
	public static T[] LEPILMIJOBH<T>(this T[] IFDDIFGJFLM, int CCELBNKPBGB, T KHKEEEMOFBF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2596B30", Offset = "0x2595B30", VA = "0x182596B30")]
	public static U[] OBMHKALHPLA<U, T>(this T[] HACMILLGFCL, int MJKOMKNDKHP, OJBAAMNOBJD<T, U> GKFFOMDAMMC) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72AD0C0", Offset = "0x72AC0C0", VA = "0x1872AD0C0")]
	public static byte[] EHDEAAAMFIK(this byte[] FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x72AD2A0", Offset = "0x72AC2A0", VA = "0x1872AD2A0")]
	public static byte[] HNDJBNLMDDG(this byte[] FKGCCPKFEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ICAINFOEMJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x107D900", Offset = "0x107C900", VA = "0x18107D900")]
	public static void NIFKCIMCMLG<K, V>(this IDictionary<K, V> FKGCCPKFEDE, in K LOHIKDGDMPP, in V CKDFGEALFAK, Func<V, V, V> ODLLMCCMOBJ) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x107E3D0", Offset = "0x107D3D0", VA = "0x18107E3D0")]
	public static void NOJICBNLKBP<K, V>(this IDictionary<K, List<V>> FKGCCPKFEDE, in K LOHIKDGDMPP, in V CKDFGEALFAK) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x107D010", Offset = "0x107C010", VA = "0x18107D010")]
	public static TVal MEAFGPINDAJ<TVal, TKey>(this IDictionary<TKey, TVal> NAHIDMOBGIL, in TKey LOHIKDGDMPP, [Optional][NOBCHKPHFNC("`default!` shouldn't be necessary in C# 9")] TVal PNJDHPAJOAO) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x107D320", Offset = "0x107C320", VA = "0x18107D320")]
	public static TVal MEAFGPINDAJ<TVal, TKey>(this IDictionary<TKey, TVal> NAHIDMOBGIL, in TKey LOHIKDGDMPP, Func<TVal> CMJAPCFEPEP) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x107BF40", Offset = "0x107AF40", VA = "0x18107BF40")]
	public static TValue EDPGOMNLFPH<TValue, TKey>(this IDictionary<TKey, TValue> NAHIDMOBGIL, in TKey LOHIKDGDMPP, [Optional][NOBCHKPHFNC("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue PNJDHPAJOAO)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x107C790", Offset = "0x107B790", VA = "0x18107C790")]
	public static V GLBKPEKMJME<V, K>(this IDictionary<K, V> FKGCCPKFEDE, in K LOHIKDGDMPP) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x107CC00", Offset = "0x107BC00", VA = "0x18107CC00")]
	public static T2[] JDDMHIOJJOG<T2, T1>(this Dictionary<T1, T2>.ValueCollection HBMKBLCICOO) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x107DF50", Offset = "0x107CF50", VA = "0x18107DF50")]
	public static bool NNGGEKFJMHE<TKey, TValue>(this IDictionary<TKey, TValue> FKGCCPKFEDE, TKey LOHIKDGDMPP, TValue CKDFGEALFAK) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DDNALJMILEH
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72AC1A0", Offset = "0x72AB1A0", VA = "0x1872AC1A0")]
	public static float3 HCMHPIFMPAL(this in RigidTransform FKGCCPKFEDE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72AC070", Offset = "0x72AB070", VA = "0x1872AC070")]
	public static float3 FMAPPKFEDAC(this in RigidTransform FKGCCPKFEDE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x10E6980", Offset = "0x10E5980", VA = "0x1810E6980")]
	public static (float3, float3, float3) FICELAHBDMO(this in RigidTransform FKGCCPKFEDE)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72AC010", Offset = "0x72AB010", VA = "0x1872AC010")]
	public static RigidTransform CGOLCFAGFNP(this in RigidTransform FKGCCPKFEDE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FCPIFPPCEBE
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1A75E10", Offset = "0x1A74E10", VA = "0x181A75E10")]
	public static bool JLLAOJKGHMF<T>(this IReadOnlyList<T> FKGCCPKFEDE, int CCELBNKPBGB, [NOBCHKPHFNC("This should be `T?` in C# 9.")][KPJJCLIPFEK(true)] out T ALIHEMGMHCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1A75F50", Offset = "0x1A74F50", VA = "0x181A75F50")]
	public static bool LFPFNNGBPPG<T>(this IReadOnlyList<T> FKGCCPKFEDE, int CCELBNKPBGB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7271F0", Offset = "0x7265F0")] out BKKDJNFDCIK<T> ALIHEMGMHCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1A75D00", Offset = "0x1A74D00", VA = "0x181A75D00")]
	public static T GDHBACAKODL<T>(this IReadOnlyList<T> FKGCCPKFEDE, int CCELBNKPBGB, in T EODBOMMFIAD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1A75CD0", Offset = "0x1A74CD0", VA = "0x181A75CD0")]
	[NOBCHKPHFNC("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T AFGHBKPKGHC<T>(this IReadOnlyList<T> FKGCCPKFEDE, int CCELBNKPBGB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1A75EA0", Offset = "0x1A74EA0", VA = "0x181A75EA0")]
	public static T? LAJEMEBABON<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7272A0", Offset = "0x7266A0")] this IReadOnlyList<T> FKGCCPKFEDE, int CCELBNKPBGB) where T : struct
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
