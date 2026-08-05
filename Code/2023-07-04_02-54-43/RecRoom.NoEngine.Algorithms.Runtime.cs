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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x720F8A0", Offset = "0x720DEA0", VA = "0x18720F8A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CLBOBKJFEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x720D960", Offset = "0x720BF60", VA = "0x18720D960")]
	public static (float3, float3, float3) BEIAHLKIMAB(this in quaternion PBJDHAKDMFG)
	{
		return default((float3, float3, float3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BJHEKPOJEFA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D10A00", Offset = "0x1D0F000", VA = "0x181D10A00")]
	public static bool GLGHMAHJMBI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709AC0", Offset = "0x708EC0")] this in ReadOnlyMemory<T> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709B30", Offset = "0x708F30")] in ReadOnlyMemory<T> EJECOGCICOM) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D10C10", Offset = "0x1D0F210", VA = "0x181D10C10")]
	public static int PHKMHIEHILE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709BA0", Offset = "0x708FA0")] this in ReadOnlyMemory<T?> PBJDHAKDMFG, int KPKKNNJNJKP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D10B20", Offset = "0x1D0F120", VA = "0x181D10B20")]
	public static string ILCIAMPEHGM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709C10", Offset = "0x709010")] this in ReadOnlyMemory<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CDADEOHNBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x16A06B0", Offset = "0x169ECB0", VA = "0x1816A06B0")]
	public static void LNIIODIKDBH<T>(this ICollection<T> PBJDHAKDMFG, IEnumerable<T> NBJMBPAGFHN) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FALOPOECMBC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCGEGILJABF AHOLKDCPEHF();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EGGELGKLKAA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GPMDEOLOJHL<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GPMDEOLOJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9EA10", Offset = "0x3D9D010", VA = "0x183D9EA10")]
		internal TElement PALFIAPOPLH(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KJDEGIJINJK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public System.Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public KJDEGIJINJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xEAF310", Offset = "0xEAD910", VA = "0x180EAF310")]
		internal int ILENLJEJIMO(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29532F0", Offset = "0x29518F0", VA = "0x1829532F0")]
	public static int GHCMIGHOGIJ<T>(this IReadOnlyList<T> JHKFLJIAOGC, T FEBHELIDNED) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2954000", Offset = "0x2952600", VA = "0x182954000")]
	public static int JNMOJOBFNJH<T>(this IReadOnlyList<T> JHKFLJIAOGC, T FEBHELIDNED) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2954EB0", Offset = "0x29534B0", VA = "0x182954EB0")]
	public static void LNIIODIKDBH<T>(this HashSet<T> IAHJIJDLLOL, IEnumerable<T> NBJMBPAGFHN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2955480", Offset = "0x2953A80", VA = "0x182955480")]
	public static void LPHFKNALEAK<T>(this IList<T> EKFNNDEBOAK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2955160", Offset = "0x2953760", VA = "0x182955160")]
	public static void LPHFKNALEAK<T>(this IList<T> EKFNNDEBOAK, int GBOJEKCGEOE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2951B80", Offset = "0x2950180", VA = "0x182951B80")]
	public static List<T> FLPODMGHIKN<T>(this List<T> BHEDJJBBEIH, Predicate<T> NCFEICGKGBB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2953B60", Offset = "0x2952160", VA = "0x182953B60")]
	public static int GHCMIGHOGIJ<T>(this IReadOnlyList<T> EKFNNDEBOAK, Predicate<T> DMBCKDLEKGI) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2958280", Offset = "0x2956880", VA = "0x182958280")]
	public static bool OKDBDEGBPPH<T>(this IReadOnlyList<T> EKFNNDEBOAK, Predicate<T> DMBCKDLEKGI, [CHGAFDMGLNB(true)] out List<int>? KEFLDCLCCNN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2953160", Offset = "0x2951760", VA = "0x182953160")]
	public static bool GGHKDEOPGPN<T>(this IReadOnlyList<T> EKFNNDEBOAK, T CDIFGMFCFLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29531B0", Offset = "0x29517B0", VA = "0x1829531B0")]
	public static bool GGHKDEOPGPN<T>(this IReadOnlyList<T> EKFNNDEBOAK, T CDIFGMFCFLG, EqualityComparer<T> AEBCGLJOPNE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2951F60", Offset = "0x2950560", VA = "0x182951F60")]
	public static int GCGHJHJBKFO<TElement, TKey>(this IList<TElement> JIMFGDPNLHG, TKey GJDGJCBBAGA, Func<TElement, TKey> EODDJEBLHIG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709D40", Offset = "0x709140")] Func<TKey, TKey, int> IFDJFBEDNPK, int IIOMOLKAONM = 0, [Optional] int? EGIKAKGFKPB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2951C70", Offset = "0x2950270", VA = "0x182951C70")]
	public static int GCGHJHJBKFO<TElement, TKey>(Func<int, TElement> PPPNEOBMLGO, int PHDBDPCEHGN, TKey GJDGJCBBAGA, Func<TElement, TKey> EODDJEBLHIG, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709DA0", Offset = "0x7091A0")] Func<TKey, TKey, int> IFDJFBEDNPK, int IIOMOLKAONM = 0, [Optional] int? EGIKAKGFKPB) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2955C50", Offset = "0x2954250", VA = "0x182955C50")]
	public static List<T> NCJPPHHKPDG<T>(this IReadOnlyList<T> EKFNNDEBOAK, int EGIKAKGFKPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2958930", Offset = "0x2956F30", VA = "0x182958930")]
	public static bool PNEKBMKKJLF<T>(this List<T> EKFNNDEBOAK, T CDIFGMFCFLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2954450", Offset = "0x2952A50", VA = "0x182954450")]
	public static void KFELGDEMFBP<T>(this List<T> EKFNNDEBOAK, IEnumerable<T> BHEDJJBBEIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x29519E0", Offset = "0x294FFE0", VA = "0x1829519E0")]
	public static void FAKCPBGGFBC<T>(this List<T> EKFNNDEBOAK, IEnumerable<T> BHEDJJBBEIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29541C0", Offset = "0x29527C0", VA = "0x1829541C0")]
	public static T KAKDHAAECGD<T>(this List<T> BHEDJJBBEIH, Predicate<T> NCFEICGKGBB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2954610", Offset = "0x2952C10", VA = "0x182954610")]
	public static T KIPLMGGEGEP<T>(this List<T> BHEDJJBBEIH, int IIOMOLKAONM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2952870", Offset = "0x2950E70", VA = "0x182952870")]
	public static bool GDKNMFHNIDK<T>(this List<T> PLGAOIEDMDN, List<T> CEAHMPNHJCP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x29558A0", Offset = "0x2953EA0", VA = "0x1829558A0")]
	public static T MAAKFCDFBHK<T>(this IList<T> EKFNNDEBOAK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29516C0", Offset = "0x294FCC0", VA = "0x1829516C0")]
	public static bool ABJFCGHNGML<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x709E00", Offset = "0x709200")] IReadOnlyList<T> EKFNNDEBOAK, int IIOMOLKAONM, [PFAOENEDMII("This should be `T?` in C# 9.")][FDFMICFDLIC(false)] out T COGPMIAOIBF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29570C0", Offset = "0x29556C0", VA = "0x1829570C0")]
	public static bool NHCFPAJNCLO<T>(IReadOnlyList<T> EKFNNDEBOAK, ICollection BHEDJJBBEIH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2951810", Offset = "0x294FE10", VA = "0x182951810")]
	public static void DJDIOJLLJGH<T>(IReadOnlyList<T> EKFNNDEBOAK, ref ICollection BHEDJJBBEIH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2953FA0", Offset = "0x29525A0", VA = "0x182953FA0")]
	public static bool HGNINFFJFJF<T>(this IReadOnlyList<T> EKFNNDEBOAK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2953DC0", Offset = "0x29523C0", VA = "0x182953DC0")]
	public static string GPHMGIGCJAJ<T>(this IEnumerable<T> EKFNNDEBOAK, string DNDJIBBPPNC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2955A10", Offset = "0x2954010", VA = "0x182955A10")]
	public static T MOAAPMLGLJK<T>(this IList<T> PBJDHAKDMFG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29542B0", Offset = "0x29528B0", VA = "0x1829542B0")]
	public static T KFEDJJDIPOA<T>(this IList<T> PBJDHAKDMFG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2951780", Offset = "0x294FD80", VA = "0x182951780")]
	public static void AHLLECAEJJN<T>(this IList<T> PBJDHAKDMFG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29586E0", Offset = "0x2956CE0", VA = "0x1829586E0")]
	public static void ONKNPCFILEG<T>(this IList<T> PBJDHAKDMFG, in T FEBHELIDNED) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2951940", Offset = "0x294FF40", VA = "0x182951940")]
	public static T DKPAFIIHFML<T>(this IList<T> PBJDHAKDMFG) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NLFBBOFHGNB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PPIDNFLLKAL<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1EF0DF0", Offset = "0x1EEF3F0", VA = "0x181EF0DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public PPIDNFLLKAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0BC0", Offset = "0x1EEF1C0", VA = "0x181EF0BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0D70", Offset = "0x1EEF370", VA = "0x181EF0D70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0CA0", Offset = "0x1EEF2A0", VA = "0x181EF0CA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0D40", Offset = "0x1EEF340", VA = "0x181EF0D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2719F80", Offset = "0x2718580", VA = "0x182719F80")]
	public static void KLMKKAPPIDA<T>(this T KIJLBFEDEPN, Action<T> AMGNILLMEKM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2719D00", Offset = "0x2718300", VA = "0x182719D00")]
	public static V HCDBOCFJCOI<V, T>(this T KIJLBFEDEPN, Func<T, V> AMGNILLMEKM, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] V LLDPFOJMFMC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2719E90", Offset = "0x2718490", VA = "0x182719E90")]
	public static T? INBPMPAMLJL<T>(this T PBJDHAKDMFG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x151A3D0", Offset = "0x15189D0", VA = "0x18151A3D0")]
	[IteratorStateMachine(typeof(PPIDNFLLKAL<>))]
	public static IEnumerable<T> JIEEEJBALGJ<T>(this T PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x271A020", Offset = "0x2718620", VA = "0x18271A020")]
	public static T[] NNIKBDBAKIB<T>(this T PBJDHAKDMFG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NBGMHEPFNDA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long FLHHKPDHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HBMKBJENNKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NBGMHEPFNDA IHDNBELKDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long EDBBIKBJHAN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x720E870", Offset = "0x720CE70", VA = "0x18720E870")]
	public HBMKBJENNKM(NBGMHEPFNDA ODKKIBMBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x720E750", Offset = "0x720CD50", VA = "0x18720E750")]
	public long HGCDEJNHJMM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x720E7E0", Offset = "0x720CDE0", VA = "0x18720E7E0")]
	public double JFODOEHCPCE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x720E6C0", Offset = "0x720CCC0", VA = "0x18720E6C0")]
	public double ENNJNAOLKMA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AFOALKOACNC
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48BD3E0", Offset = "0x48BB9E0", VA = "0x1848BD3E0")]
	public static bool DGFFKPDMNBE(this Type PBJDHAKDMFG, Type EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1022390", Offset = "0x1020990", VA = "0x181022390")]
	public static bool DGFFKPDMNBE<T>(this Type PBJDHAKDMFG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PFMHBFNFGOI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LAKAHLBPAGP(int BHELNELCEIE, int BNBKHCEHHDN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float MHEOLGBDJEF(float OOBNGDLLEAK, float FKBLMDHNPJA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HHGOADCEOKG
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5120", Offset = "0x2AD3720", VA = "0x182AD5120")]
	public static void LJFEBDDDADJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A020", Offset = "0x709420")] this in KeyValuePair<TKey, TValue> PBJDHAKDMFG, out TKey NAJDAPHOGEH, out TValue FEBHELIDNED) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4E90", Offset = "0x2AD3490", VA = "0x182AD4E90")]
	public static (TKey?, TValue?) INIFNNGIAAK<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A090", Offset = "0x709490")] this in KeyValuePair<TKey?, TValue?> PBJDHAKDMFG)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4DC0", Offset = "0x2AD33C0", VA = "0x182AD4DC0")]
	public static KeyValuePair<TKey?, UValue?> EDMHFIBMCOL<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A100", Offset = "0x709500")] this KeyValuePair<TKey?, TValue?> PBJDHAKDMFG, UValue FEBHELIDNED)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ANOCDBAFMPM
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1024BD0", Offset = "0x10231D0", VA = "0x181024BD0")]
	[GFNBIBHBBNO("This should be replaced with the `is not` operator in C# 9.")]
	public static bool CCCHJIIOFBL<T>(this object PBJDHAKDMFG, [CHGAFDMGLNB(true)] out T COGPMIAOIBF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KCEPMNDOIDK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x720EFE0", Offset = "0x720D5E0", VA = "0x18720EFE0")]
	private static byte[] LNDBHDKCMBI(int NAEOMFDLPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x720EEE0", Offset = "0x720D4E0", VA = "0x18720EEE0")]
	private static byte[] GEEIEBPEFLK(long OAMGKGOBBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x720EF60", Offset = "0x720D560", VA = "0x18720EF60")]
	private static byte[] JCLBGBNHOKD(ulong OAMGKGOBBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x720F060", Offset = "0x720D660", VA = "0x18720F060")]
	public static Guid MKDKNGDODPB(params Guid[] LOMEJCPMHND)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x720F4D0", Offset = "0x720DAD0", VA = "0x18720F4D0")]
	public static Guid PJDMJLOGMBM(in Guid LHILAKAPLIO, int IIOMOLKAONM, int BOBBHCFAPPK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x720F400", Offset = "0x720DA00", VA = "0x18720F400")]
	public static Guid PJDMJLOGMBM(in Guid LHILAKAPLIO, long IIOMOLKAONM, int BOBBHCFAPPK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x720F2C0", Offset = "0x720D8C0", VA = "0x18720F2C0")]
	public static Guid PJDMJLOGMBM(in Guid LHILAKAPLIO, ulong IIOMOLKAONM, int BOBBHCFAPPK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x720F390", Offset = "0x720D990", VA = "0x18720F390")]
	public static Guid PJDMJLOGMBM(in Guid LHILAKAPLIO, in Guid PBCCLPGGGJN, int BOBBHCFAPPK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x720F5A0", Offset = "0x720DBA0", VA = "0x18720F5A0")]
	private static Guid PJDMJLOGMBM(in Guid LHILAKAPLIO, byte[] PFABMOLNPPL, int BOBBHCFAPPK = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x720F1E0", Offset = "0x720D7E0", VA = "0x18720F1E0")]
	private static void PIAOIBIJEOP(byte[] IKGPBILBBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x720EE60", Offset = "0x720D460", VA = "0x18720EE60")]
	private static void DFGLPKEMJGJ(byte[] IKGPBILBBIK, int CNCLMHODMJG, int ECNLMNDOGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KLAGABINGLD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6A15460", Offset = "0x6A13A60", VA = "0x186A15460")]
	public static uint ECKEGFBBFDE(this uint PBJDHAKDMFG, int EGIKAKGFKPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x54A4C80", Offset = "0x54A3280", VA = "0x1854A4C80")]
	public static uint GOOKDEJCNJM(this uint PBJDHAKDMFG, int EGIKAKGFKPB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CGPCILNLGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x720D8F0", Offset = "0x720BEF0", VA = "0x18720D8F0")]
	public static int MPKDNFGEKFB(this int PBJDHAKDMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x720D850", Offset = "0x720BE50", VA = "0x18720D850")]
	public static int GALGOBFPNLF(this int PBJDHAKDMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x720D890", Offset = "0x720BE90", VA = "0x18720D890")]
	public static int JFAPNHAPBJK(this int PBJDHAKDMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x720D8E0", Offset = "0x720BEE0", VA = "0x18720D8E0")]
	public static int MOEAMBFNENE(this int PBJDHAKDMFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A15460", Offset = "0x6A13A60", VA = "0x186A15460")]
	public static int ECKEGFBBFDE(this int PBJDHAKDMFG, int EGIKAKGFKPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54A4C80", Offset = "0x54A3280", VA = "0x1854A4C80")]
	public static int GOOKDEJCNJM(this int PBJDHAKDMFG, int EGIKAKGFKPB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BAPGANKECEK
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D06070", Offset = "0x1D04670", VA = "0x181D06070")]
	public static bool EPMAKCCCIJE<T, U>(this T PBJDHAKDMFG, in U IAMEECMGPIF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D06260", Offset = "0x1D04860", VA = "0x181D06260")]
	public static bool IDLENBIIMKK<T>(ref T PBJDHAKDMFG, T EJECOGCICOM) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HFANBEKKEJJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float GMOMNKKMHDK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float NOJKGGHJKKB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool GBBCENJLNCF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float BPENLFHOGIE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x720EA90", Offset = "0x720D090", VA = "0x18720EA90")]
	public static bool PHCKDOBMLNM(float LLAFGJINMOA, float LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x45EBE90", Offset = "0x45EA490", VA = "0x1845EBE90")]
	public static float PGIADAHMKJD(float FEBHELIDNED, float OKHAFKCALGP, float KMEINNAJPFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x45EBEB0", Offset = "0x45EA4B0", VA = "0x1845EBEB0")]
	public static int PGIADAHMKJD(int FEBHELIDNED, int OKHAFKCALGP, int KMEINNAJPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x45EBE70", Offset = "0x45EA470", VA = "0x1845EBE70")]
	public static float KOJFGLCFHIN(float FEBHELIDNED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x720E8E0", Offset = "0x720CEE0", VA = "0x18720E8E0")]
	public static float AOKDMIAMEOH(float LLAFGJINMOA, float LKIHFBEPDMH, float KIJLBFEDEPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x720EA80", Offset = "0x720D080", VA = "0x18720EA80")]
	public static float KPMFAIOMCIJ(float LLAFGJINMOA, float LKIHFBEPDMH, float KIJLBFEDEPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x720E980", Offset = "0x720CF80", VA = "0x18720E980")]
	public static float DPIMHJDNIGF(float LLAFGJINMOA, float LKIHFBEPDMH, float FEBHELIDNED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x720EA40", Offset = "0x720D040", VA = "0x18720EA40")]
	public static float KFBHJCAOIEP(float LLAFGJINMOA, float LKIHFBEPDMH, float FEBHELIDNED)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JDDIKCBOONN
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x19F1500", Offset = "0x19EFB00", VA = "0x1819F1500")]
	public static TValue FOGFALNKAIA<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> PBJDHAKDMFG, TKey NAJDAPHOGEH) where TValue : class where TKey : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GCGEGILJABF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALBOHFGOEHA();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GBBMPOGOPHE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private sealed class EJFFOGPFCEF : PFMHBFNFGOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly System.Random ALEFPJEEMLE;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x720E120", Offset = "0x720C720", VA = "0x18720E120", Slot = "4")]
		public int LAKAHLBPAGP(int OOBNGDLLEAK, int MKOGFCMCKIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x720E150", Offset = "0x720C750", VA = "0x18720E150", Slot = "5")]
		public float MHEOLGBDJEF(float OOBNGDLLEAK, float FKBLMDHNPJA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x720E0E0", Offset = "0x720C6E0", VA = "0x18720E0E0")]
		private double IAAPMHBEEBN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x720E1C0", Offset = "0x720C7C0", VA = "0x18720E1C0")]
		public EJFFOGPFCEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly PFMHBFNFGOI NCJPPHHKPDG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x720E230", Offset = "0x720C830", VA = "0x18720E230")]
	public static ulong GLHCDFGCNNF()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CGLGLIICGGE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate bool KLFCMOCKGJP<TArgs, T>(in TArgs GDDHAFPALIL, T CDIFGMFCFLG);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U NBNACADIALH<TArg, U>(in TArg NPIEBOHJFEN);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U JCLGDHFHODC<TArg, T, U>(in TArg NPIEBOHJFEN, T BLIHMNHLENE);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate U GNHCHHAFEGO<TArg, T, U>(in TArg NPIEBOHJFEN, IEnumerable<T> CINKNDJPGAB);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate U FLHHGDMMCAG<TArg, T, U>(in TArg NPIEBOHJFEN, T BLIHMNHLENE);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct GIGMFKDCCHH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3820", Offset = "0x2DC1E20", VA = "0x182DC3820")]
		[PFAOENEDMII("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BGNNPAADIKM(T DJALIKBKJGO)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3890", Offset = "0x2DC1E90", VA = "0x182DC3890")]
		[PFAOENEDMII("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) PFAPPOANFNF(IEnumerable<T> DDKFCGOBMOD)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class KNGOONDDHPC<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public KNGOONDDHPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2627F50", Offset = "0x2626550", VA = "0x182627F50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x26275B0", Offset = "0x2625BB0", VA = "0x1826275B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2627B90", Offset = "0x2626190", VA = "0x182627B90")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x26271D0", Offset = "0x26257D0", VA = "0x1826271D0")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2627E80", Offset = "0x2626480", VA = "0x182627E80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2627C90", Offset = "0x2626290", VA = "0x182627C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x213ACC0", Offset = "0x21392C0", VA = "0x18213ACC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JIEPPFCKFGN<T> : IEnumerable<(T, JJBGMPOBLPN<T>)>, IEnumerable, IEnumerator<(T, JJBGMPOBLPN<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (T Current, JJBGMPOBLPN<T> Next) <>2__current;

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
		private (T, JJBGMPOBLPN<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x372CF90", Offset = "0x372B590", VA = "0x18372CF90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, JJBGMPOBLPN<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x372D1C0", Offset = "0x372B7C0", VA = "0x18372D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2460", Offset = "0x1FF0A60", VA = "0x181FF2460")]
		[DebuggerHidden]
		public JIEPPFCKFGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x372D210", Offset = "0x372B810", VA = "0x18372D210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x372C800", Offset = "0x372AE00", VA = "0x18372C800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x372CBE0", Offset = "0x372B1E0", VA = "0x18372CBE0")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x372CFF0", Offset = "0x372B5F0", VA = "0x18372CFF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x372CD80", Offset = "0x372B380", VA = "0x18372CD80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, JJBGMPOBLPN<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x15BEF90", Offset = "0x15BD590", VA = "0x1815BEF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class POKLNAIFIOK<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A8C0", Offset = "0x709CC0")]
		private Func<GIGMFKDCCHH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A9B0", Offset = "0x709DB0")]
		public Func<GIGMFKDCCHH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

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
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public POKLNAIFIOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFAA0", Offset = "0x1EEE0A0", VA = "0x181EEFAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF580", Offset = "0x1EEDB80", VA = "0x181EEF580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF950", Offset = "0x1EEDF50", VA = "0x181EEF950")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF530", Offset = "0x1EEDB30", VA = "0x181EEF530")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFA60", Offset = "0x1EEE060", VA = "0x181EEFA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF9A0", Offset = "0x1EEDFA0", VA = "0x181EEF9A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1ACDF90", Offset = "0x1ACC590", VA = "0x181ACDF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JCEAIKDMFIL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public JCEAIKDMFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x15BD450", Offset = "0x15BBA50", VA = "0x1815BD450")]
		internal bool DAPLAOCBMIC(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x29F99F0", Offset = "0x29F7FF0", VA = "0x1829F99F0")]
		internal bool JOKJPEHDEOD(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GFICGMGJINH<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC7E0", Offset = "0x2DBADE0", VA = "0x182DBC7E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2460", Offset = "0x1FF0A60", VA = "0x181FF2460")]
		[DebuggerHidden]
		public GFICGMGJINH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC4B0", Offset = "0x2DBAAB0", VA = "0x182DBC4B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC7A0", Offset = "0x2DBADA0", VA = "0x182DBC7A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC6E0", Offset = "0x2DBACE0", VA = "0x182DBC6E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x22D29E0", Offset = "0x22D0FE0", VA = "0x1822D29E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x16A4860", Offset = "0x16A2E60", VA = "0x1816A4860")]
	public static bool ANDHEFCCGFM<T, TArgs>(this IEnumerable<T> PBJDHAKDMFG, in TArgs GDDHAFPALIL, KLFCMOCKGJP<TArgs, T> DMBCKDLEKGI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x16A7A80", Offset = "0x16A6080", VA = "0x1816A7A80")]
	public static U INHGJFIIKGC<U, T>(this IEnumerable<T> PBJDHAKDMFG, Func<U> DPAFJOJLPFP, Func<T, U> DJALIKBKJGO, Func<IEnumerable<T>, U> DDKFCGOBMOD) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x16A5590", Offset = "0x16A3B90", VA = "0x1816A5590")]
	public static bool DDNOHBCEDCH<T, TArgs>(this IEnumerable<T> PBJDHAKDMFG, in TArgs GDDHAFPALIL, KLFCMOCKGJP<TArgs, T> DMBCKDLEKGI) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x16A4DA0", Offset = "0x16A33A0", VA = "0x1816A4DA0")]
	public static U CEDJIDJCMIC<U, T, TArg>(this IEnumerable<T> PBJDHAKDMFG, in TArg NPIEBOHJFEN, NBNACADIALH<TArg, U> DPAFJOJLPFP, JCLGDHFHODC<TArg, T, U> DJALIKBKJGO, GNHCHHAFEGO<TArg, T, U> DDKFCGOBMOD) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x16A7C30", Offset = "0x16A6230", VA = "0x1816A7C30")]
	public static IEnumerable<U> LEEMNOJOHJM<U, T, TArg>(this IEnumerable<T> PBJDHAKDMFG, in TArg NPIEBOHJFEN, FLHHGDMMCAG<TArg, T, U> OAFBJNCKOHI) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x16A7380", Offset = "0x16A5980", VA = "0x1816A7380")]
	public static IEnumerable<T> KCOBHBCMDDP<T>(params IEnumerable<T>[] HIMDCIFAJEG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x16A53B0", Offset = "0x16A39B0", VA = "0x1816A53B0")]
	public static bool CLGMJNHMBCP<T>(this IEnumerable<T> BDIPIDIIILI, IEnumerable<T> EJECOGCICOM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x16A7380", Offset = "0x16A5980", VA = "0x1816A7380")]
	public static IEnumerable<(TKey?, TValue?)>? KAGHKOCIEHN<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A210", Offset = "0x709610")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x16A6C70", Offset = "0x16A5270", VA = "0x1816A6C70")]
	public static IEnumerable<T> HNGECAKOABG<T, TKey>(this IEnumerable<T> NFKMMHCBCHK, Func<T, TKey> CFNCMODEJIC) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x14B5B60", Offset = "0x14B4160", VA = "0x1814B5B60")]
	[IteratorStateMachine(typeof(KNGOONDDHPC<, >))]
	public static IEnumerable<T> FJKNKGJNJPI<T, U>(this IEnumerable<T> PBJDHAKDMFG, IEnumerable<U> EJECOGCICOM, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] T AFOEMFCCODJ) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x151A090", Offset = "0x1518690", VA = "0x18151A090")]
	public static T PGMBFNNEJCP<T>(this IEnumerable<T> BDIPIDIIILI, T LLDPFOJMFMC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x16A8070", Offset = "0x16A6670", VA = "0x1816A8070")]
	public static T PGMBFNNEJCP<T>(this IEnumerable<T> BDIPIDIIILI, T LLDPFOJMFMC, Func<T, bool> DMBCKDLEKGI) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x16A63E0", Offset = "0x16A49E0", VA = "0x1816A63E0")]
	public static T? GHMGMCOOPHM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A2D0", Offset = "0x7096D0")] this IEnumerable<T> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A330", Offset = "0x709730")] Func<T, bool> DMBCKDLEKGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x151A920", Offset = "0x1518F20", VA = "0x18151A920")]
	[IteratorStateMachine(typeof(JIEPPFCKFGN<>))]
	public static IEnumerable<(T, JJBGMPOBLPN<T>)> BDAIDKBGHCC<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x16A6B80", Offset = "0x16A5180", VA = "0x1816A6B80")]
	public static bool GPJBJCBHMPP<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x16A7380", Offset = "0x16A5980", VA = "0x1816A7380")]
	public static IEnumerable<BBCKCHJBLNA<T>> IKGMLJIBDML<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x16A5570", Offset = "0x16A3B70", VA = "0x1816A5570")]
	public static bool DDCPNIBOGHA<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x16A42F0", Offset = "0x16A28F0", VA = "0x1816A42F0")]
	public static IEnumerable<T> AEAJEPDDOOI<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x10269C0", Offset = "0x1024FC0", VA = "0x1810269C0")]
	[IteratorStateMachine(typeof(POKLNAIFIOK<, >))]
	public static IEnumerable<U> GBJNMPGNGBL<U, T>(this IEnumerable<T> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A450", Offset = "0x709850")] Func<GIGMFKDCCHH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> LEFGFBPEKJI) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x16A80C0", Offset = "0x16A66C0", VA = "0x1816A80C0")]
	public static int PHKMHIEHILE<T>(this IEnumerable<T> PBJDHAKDMFG, int KPKKNNJNJKP = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x16A5EF0", Offset = "0x16A44F0", VA = "0x1816A5EF0")]
	public static bool FPBMEJDOIHH<T>(this IEnumerable<T> PBJDHAKDMFG, IEnumerable<T> EJECOGCICOM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x16A5120", Offset = "0x16A3720", VA = "0x1816A5120")]
	public static (IEnumerable<T>, IEnumerable<T>) CKAHCEKEFIJ<T>(this IEnumerable<T> PBJDHAKDMFG, Func<T, bool> DCDDHDJKMFD) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x16A7620", Offset = "0x16A5C20", VA = "0x1816A7620")]
	public static string ILCIAMPEHGM<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x16A5AD0", Offset = "0x16A40D0", VA = "0x1816A5AD0")]
	public static Dictionary<TKey?, TValue?>? DMHPPCCBOOJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A540", Offset = "0x709940")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? BDIPIDIIILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x16A5AD0", Offset = "0x16A40D0", VA = "0x1816A5AD0")]
	public static Dictionary<TKey?, TValue?>? DMHPPCCBOOJ<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70A5A0", Offset = "0x7099A0")] this IEnumerable<(TKey? Key, TValue? Value)>? BDIPIDIIILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0")]
	public static HashSet<T> JMCNFIABKFF<T>(this IEnumerable<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x16A8050", Offset = "0x16A6650", VA = "0x1816A8050")]
	public static string OOPIKCKJPEL<T>(this IEnumerable<T> PBJDHAKDMFG, string PLFNIICKDPE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x14B5A20", Offset = "0x14B4020", VA = "0x1814B5A20")]
	[IteratorStateMachine(typeof(GFICGMGJINH<, >))]
	public static IEnumerable<(T, U)> MENKKPKAJPK<T, U>(this IEnumerable<T> NNCBKOEDDGO, IEnumerable<U> IHJFFGMGNME) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x16A7100", Offset = "0x16A5700", VA = "0x1816A7100")]
	public static IEnumerable<V> IKBJHAADBAC<V, T, U>(this IEnumerable<T> PBJDHAKDMFG, IEnumerable<U> EJECOGCICOM, Func<T, U, V> FHCPMEHFHNE, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] T GIHDINLMDHI, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] U BFNHFMKIEJF) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x16A7190", Offset = "0x16A5790", VA = "0x1816A7190")]
	public static IEnumerable<(T, U)> IKBJHAADBAC<T, U>(this IEnumerable<T> PBJDHAKDMFG, IEnumerable<U> EJECOGCICOM, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] T GIHDINLMDHI, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] U BFNHFMKIEJF) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OLNBDPNIHCN
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1BF1970", Offset = "0x1BEFF70", VA = "0x181BF1970")]
	public static bool AIMKNGJGFJG<T>(this IReadOnlyCollection<T> PBJDHAKDMFG, int IIOMOLKAONM) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HNOGKBLFNBH : NBGMHEPFNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch IHDNBELKDKN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FLHHKPDHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x720ED70", Offset = "0x720D370", VA = "0x18720ED70", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	private HNOGKBLFNBH(Stopwatch ODKKIBMBPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x720EC70", Offset = "0x720D270", VA = "0x18720EC70")]
	public static HNOGKBLFNBH DEEPHOMMOBP(Stopwatch ODKKIBMBPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x720ECD0", Offset = "0x720D2D0", VA = "0x18720ECD0")]
	public static HNOGKBLFNBH FLEGKBNIFGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JACINDOBEPO
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x720ED90", Offset = "0x720D390", VA = "0x18720ED90")]
	public static RigidTransform JONGIHBKHPL(RigidTransform CGLHNODBBNJ, RigidTransform EMKHKNBPCHP)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class IPKNGAFJCBD<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct FFOFPPBDGHJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x21F5B00", Offset = "0x21F4100", VA = "0x1821F5B00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int OJOGGEHFMAC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static HBMKBJENNKM NEDCKMBOHOI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long FLHHKPDHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E857B0", Offset = "0x1E83DB0", VA = "0x181E857B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3008E70", Offset = "0x3007470", VA = "0x183008E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x30090B0", Offset = "0x30076B0", VA = "0x1830090B0")]
	public static FFOFPPBDGHJ JBPNIHFGKNP()
	{
		return default(FFOFPPBDGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3008F30", Offset = "0x3007530", VA = "0x183008F30")]
	private static void FHFMFDEEAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3008ED0", Offset = "0x30074D0", VA = "0x183008ED0")]
	public static void BCFKLBADKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FLAOBBEHDDE
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B6BC30", Offset = "0x1B6A230", VA = "0x181B6BC30")]
	public static bool GLGHMAHJMBI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70AE80", Offset = "0x70A280")] this in ReadOnlySpan<T?> PBJDHAKDMFG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70AEF0", Offset = "0x70A2F0")] in ReadOnlySpan<T?> EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1B6C740", Offset = "0x1B6AD40", VA = "0x181B6C740")]
	public static int PHKMHIEHILE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70AF60", Offset = "0x70A360")] this in ReadOnlySpan<T?> PBJDHAKDMFG, int KPKKNNJNJKP = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1B6BDB0", Offset = "0x1B6A3B0", VA = "0x181B6BDB0")]
	public static string ILCIAMPEHGM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70AFD0", Offset = "0x70A3D0")] this in ReadOnlySpan<T> PBJDHAKDMFG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1B6BFF0", Offset = "0x1B6A5F0", VA = "0x181B6BFF0")]
	public static string OOPIKCKJPEL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B040", Offset = "0x70A440")] this in ReadOnlySpan<T> PBJDHAKDMFG, string PLFNIICKDPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GNKNEDGJNDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x580D060", Offset = "0x580B660", VA = "0x18580D060")]
	public static bool HGNINFFJFJF(this string? ANMADMEGBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x720E610", Offset = "0x720CC10", VA = "0x18720E610")]
	public static string? PMGNPCEEDOO(this string? PBJDHAKDMFG, int FJHPIDCEGNP, string BENFAJJIAKE = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x720E570", Offset = "0x720CB70", VA = "0x18720E570")]
	public static string GDPCFCDNFMH(this string PBJDHAKDMFG, int FJHPIDCEGNP, string BENFAJJIAKE = "")
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BHEAEBICDDD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NBGMHEPFNDA CBBCCKAGEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x720D710", Offset = "0x720BD10", VA = "0x18720D710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x720D680", Offset = "0x720BC80", VA = "0x18720D680")]
	public static double JFODOEHCPCE(this NBGMHEPFNDA PBJDHAKDMFG, long NLALKCMAHPA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class DIIKHBKGCGI
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate int HJCNBHFFMIN<T>(in T NNCBKOEDDGO, in T IHJFFGMGNME);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class HOPNENOBMKB<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct IFMNCFGPIFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int DGHDJOAODLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int OMKALOFOOLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool IIGGHDCLBJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int BPADABPCJPH;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x21872F0", Offset = "0x21858F0", VA = "0x1821872F0")]
			public IFMNCFGPIFA(int DGHDJOAODLO, int OMKALOFOOLD, bool IIGGHDCLBJB)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] PHGBGLLOFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] BJFINDNJGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly HJCNBHFFMIN<T> IFDJFBEDNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int JGIKOPAFGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> NMNDNCOGNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int FNHNDOMAKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B150", Offset = "0x70A550")]
		private readonly HOPNENOBMKB<T>.IFMNCFGPIFA[] FGIPKGLIHIM;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2E43440", Offset = "0x2E41A40", VA = "0x182E43440")]
		public HOPNENOBMKB(T[] PHGBGLLOFIK, HJCNBHFFMIN<T> IFDJFBEDNPK, int JGIKOPAFGNI, Func<bool> NMNDNCOGNNJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B1B0", Offset = "0x70A5B0")] T[] BIELPFIHJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2E430D0", Offset = "0x2E416D0", VA = "0x182E430D0")]
		public bool JCDIENDPBGM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate U JBEOMJLJBOP<T, U>(int OOEGAIFODFN, int OPODGKBMHKE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B210", Offset = "0x70A610")] in ReadOnlySpan<T> HMKNCDFDEGL);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x299D4F0", Offset = "0x299BAF0", VA = "0x18299D4F0")]
	public static T[] BCMJPCAOFLO<T>(int BMEHIBKNEIE, T AFOEMFCCODJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x299D670", Offset = "0x299BC70", VA = "0x18299D670")]
	public static void BIAPJPFDKLC<T>(this T[] CGEKGBMDJOL, T AFOEMFCCODJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E68B50", Offset = "0x1E67150", VA = "0x181E68B50")]
	public static void LJGLMOJNIDC<T>(this T[] JHKFLJIAOGC, int JMCLMPHOKNG, int KDHPDIKCHGK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x299DD60", Offset = "0x299C360", VA = "0x18299DD60")]
	private static void FEFHNAMHMMA<T>(this T[] PBJDHAKDMFG, int DCDFGKLMNKJ, int EFILKHBDNNP, T[] EJECOGCICOM, int JNGPMAKFOLP, int AGPIIKEFFGJ, T[] COGPMIAOIBF, int LIDNEBNODNL, HJCNBHFFMIN<T> IFDJFBEDNPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x299E160", Offset = "0x299C760", VA = "0x18299E160")]
	public static void IHCCIGAAKIG<T>(this T[] PBJDHAKDMFG, int DGHDJOAODLO, int EGIKAKGFKPB, HJCNBHFFMIN<T> IFDJFBEDNPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x299ED40", Offset = "0x299D340", VA = "0x18299ED40")]
	public static HOPNENOBMKB<T> OFNFKFHOOMC<T>(this T[] PBJDHAKDMFG, HJCNBHFFMIN<T> IFDJFBEDNPK, int JGIKOPAFGNI, Func<bool> NMNDNCOGNNJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B0F0", Offset = "0x70A4F0")] T[] BIELPFIHJIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x299DD40", Offset = "0x299C340", VA = "0x18299DD40")]
	public static T[] FDNONIHFKFJ<T>(this T[] JHKFLJIAOGC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x299E5C0", Offset = "0x299CBC0", VA = "0x18299E5C0")]
	public static T[] JMJACPLJGNB<T>(this T[] IIPKDOJPAPK, T DOHKAGIEEJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x299E6A0", Offset = "0x299CCA0", VA = "0x18299E6A0")]
	public static T[] LHNJDEGMDOP<T>(this T[] IIPKDOJPAPK, int IIOMOLKAONM, T DOHKAGIEEJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x299EDE0", Offset = "0x299D3E0", VA = "0x18299EDE0")]
	public static T[] PKMDLLFAIAI<T>(this T[] IIPKDOJPAPK, int IIOMOLKAONM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x299D2C0", Offset = "0x299B8C0", VA = "0x18299D2C0")]
	public static T[] AIICKGLLLAG<T>(this T[] IIPKDOJPAPK, int IIOMOLKAONM, T DOHKAGIEEJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x299D800", Offset = "0x299BE00", VA = "0x18299D800")]
	public static U[] DGHBCJOJCMP<U, T>(this T[] NEGBPLHGJID, int CCIIEGOJLDD, JBEOMJLJBOP<T, U> GKGKHKLLPBA) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x720DD20", Offset = "0x720C320", VA = "0x18720DD20")]
	public static byte[] DADOIIBDKNF(this byte[] PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x720DF00", Offset = "0x720C500", VA = "0x18720DF00")]
	public static byte[] IIFFEOKHLCE(this byte[] PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KLBPPEDDMOE
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x52B4AD0", Offset = "0x52B30D0", VA = "0x1852B4AD0")]
	public static void BHFKBGIHHHJ<K, V>(this IDictionary<K, V> PBJDHAKDMFG, in K NAJDAPHOGEH, in V FEBHELIDNED, Func<V, V, V> KLHJLPBNKAE) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x52B65D0", Offset = "0x52B4BD0", VA = "0x1852B65D0")]
	public static void LHLLIBOAGNI<K, V>(this IDictionary<K, List<V>> PBJDHAKDMFG, in K NAJDAPHOGEH, in V FEBHELIDNED) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x52B5A10", Offset = "0x52B4010", VA = "0x1852B5A10")]
	public static TVal DOEKLGPAHNH<TVal, TKey>(this IDictionary<TKey, TVal> FIHDOLNBAOA, in TKey NAJDAPHOGEH, [Optional][PFAOENEDMII("`default!` shouldn't be necessary in C# 9")] TVal LLDPFOJMFMC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x52B5120", Offset = "0x52B3720", VA = "0x1852B5120")]
	public static TVal DOEKLGPAHNH<TVal, TKey>(this IDictionary<TKey, TVal> FIHDOLNBAOA, in TKey NAJDAPHOGEH, Func<TVal> MDGPNNNCKHE) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x52B7160", Offset = "0x52B5760", VA = "0x1852B7160")]
	public static TValue MCHBAPBDDIO<TValue, TKey>(this IDictionary<TKey, TValue> FIHDOLNBAOA, in TKey NAJDAPHOGEH, [Optional][PFAOENEDMII("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue LLDPFOJMFMC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x52B5F80", Offset = "0x52B4580", VA = "0x1852B5F80")]
	public static V HEDAAFJLBII<V, K>(this IDictionary<K, V> PBJDHAKDMFG, in K NAJDAPHOGEH) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x52B5D90", Offset = "0x52B4390", VA = "0x1852B5D90")]
	public static T2[] GMDJGJMHLJP<T2, T1>(this Dictionary<T1, T2>.ValueCollection MCGJDDHDCMD) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x52B7230", Offset = "0x52B5830", VA = "0x1852B7230")]
	public static bool OBNDLHFELBO<TKey, TValue>(this IDictionary<TKey, TValue> PBJDHAKDMFG, TKey NAJDAPHOGEH, TValue FEBHELIDNED) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DELDCGEICIK
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x720DA60", Offset = "0x720C060", VA = "0x18720DA60")]
	public static float3 AIGAHHPAMPH(this in RigidTransform PBJDHAKDMFG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x720DBF0", Offset = "0x720C1F0", VA = "0x18720DBF0")]
	public static float3 CMEHOEDKMKM(this in RigidTransform PBJDHAKDMFG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x17941E0", Offset = "0x17927E0", VA = "0x1817941E0")]
	public static (float3, float3, float3) NHPAPGJOPEK(this in RigidTransform PBJDHAKDMFG)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x720DB90", Offset = "0x720C190", VA = "0x18720DB90")]
	public static RigidTransform ANNFJJLDLFH(this in RigidTransform PBJDHAKDMFG)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ICCNKDMHECG
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2010C20", Offset = "0x200F220", VA = "0x182010C20")]
	public static bool DJABJOJOKLP<T>(this IReadOnlyList<T> PBJDHAKDMFG, int IIOMOLKAONM, [CHGAFDMGLNB(true)][PFAOENEDMII("This should be `T?` in C# 9.")] out T COGPMIAOIBF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2010D90", Offset = "0x200F390", VA = "0x182010D90")]
	public static bool HIMGCOLKFGO<T>(this IReadOnlyList<T> PBJDHAKDMFG, int IIOMOLKAONM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B3F0", Offset = "0x70A7F0")] out BBCKCHJBLNA<T> COGPMIAOIBF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2010E50", Offset = "0x200F450", VA = "0x182010E50")]
	public static T LEAEMIFLDJP<T>(this IReadOnlyList<T> PBJDHAKDMFG, int IIOMOLKAONM, in T KIKGNHLGKAN) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2010CB0", Offset = "0x200F2B0", VA = "0x182010CB0")]
	[PFAOENEDMII("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T FOGFALNKAIA<T>(this IReadOnlyList<T> PBJDHAKDMFG, int IIOMOLKAONM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2010CE0", Offset = "0x200F2E0", VA = "0x182010CE0")]
	public static T? GMAJFKJLAMO<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x70B490", Offset = "0x70A890")] this IReadOnlyList<T> PBJDHAKDMFG, int IIOMOLKAONM) where T : struct
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
