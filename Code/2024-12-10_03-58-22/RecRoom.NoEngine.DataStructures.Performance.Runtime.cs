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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D3A240", Offset = "0x6D38E40", VA = "0x186D3A240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IIOEHFHKLNC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D780", Offset = "0x2C8C380", VA = "0x182C8D780")]
	public static OPFCIIADDEC<T> PFNDMLGGAMB<T>(this T[] GMNCELIMKIF) where T : notnull
	{
		return default(OPFCIIADDEC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class HOPDIMAFELJ<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FNPOPJLMFPF<T> AEENIKHNMFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F694F0", Offset = "0x3F680F0", VA = "0x183F694F0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F69530", Offset = "0x3F68130", VA = "0x183F69530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F69640", Offset = "0x3F68240", VA = "0x183F69640")]
	public static HOPDIMAFELJ<T> LMDPPDEOAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EF69B0", Offset = "0x3EF55B0", VA = "0x183EF69B0")]
	internal HOPDIMAFELJ([In] FNPOPJLMFPF<T> GMBKDDMMMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F69570", Offset = "0x3F68170", VA = "0x183F69570", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F695B0", Offset = "0x3F681B0", VA = "0x183F695B0")]
	public void GHKMHOFCHII(int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F695F0", Offset = "0x3F681F0", VA = "0x183F695F0", Slot = "8")]
	public FNPOPJLMFPF<T>.DJCJPOAOLME GetEnumerator()
	{
		return default(FNPOPJLMFPF<T>.DJCJPOAOLME);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F69770", Offset = "0x3F68370", VA = "0x183F69770", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F69770", Offset = "0x3F68370", VA = "0x183F69770", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct EBOBOPFCECP<T, U> : IEnumerable<T>, IEnumerable where U : ECFAIHPLPAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U FLCFFIMLJNA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21204E0", Offset = "0x211F0E0", VA = "0x1821204E0")]
	internal EBOBOPFCECP([In] U LLKKIBMDGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BCB0", Offset = "0x3A5A8B0", VA = "0x183A5BCB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BCB0", Offset = "0x3A5A8B0", VA = "0x183A5BCB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EMLAONLFEAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2C873A0", Offset = "0x2C85FA0", VA = "0x182C873A0")]
	public static EBOBOPFCECP<T, U> LMDPPDEOAIA<U>([In] U GMNCELIMKIF) where U : ECFAIHPLPAC<T>
	{
		return default(EBOBOPFCECP<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JNNAAELBDFB<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U FLCFFIMLJNA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x42009D0", Offset = "0x41FF5D0", VA = "0x1842009D0")]
	internal JNNAAELBDFB([In] U LLKKIBMDGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A893A0", Offset = "0x3A87FA0", VA = "0x183A893A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4200530", Offset = "0x41FF130", VA = "0x184200530", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4200530", Offset = "0x41FF130", VA = "0x184200530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JCNFAFLOEPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C9D0", Offset = "0x2C8B5D0", VA = "0x182C8C9D0")]
	public static JNNAAELBDFB<T, U> LMDPPDEOAIA<U>([In] U GMNCELIMKIF) where U : IEnumerator<T>
	{
		return default(JNNAAELBDFB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NIGMCAMHMNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F7D5D0", Offset = "0x2F7C1D0", VA = "0x182F7D5D0")]
	public static string LDNIDPJNFPL<T>(this IEnumerable<T> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F69480", Offset = "0x2F68080", VA = "0x182F69480")]
	public static string HEAHMDCBOLN<T>(this IEnumerable<T> GMNCELIMKIF, string FLKMMBIKCFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHEFDOLJHFM
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B907D0", Offset = "0x2B8F3D0", VA = "0x182B907D0")]
	public static bool IJMJNAJIKAH<TSourceEnumerator, TSource>(this TSourceEnumerator GMNCELIMKIF, [In] TSource ANPIFEPGOLG) where TSourceEnumerator : ECFAIHPLPAC<TSource> where TSource : FGAMBIEKLBP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B90A20", Offset = "0x2B8F620", VA = "0x182B90A20")]
	public static int JCMDHMDNGPI<TSourceEnumerator, TSource>(this TSourceEnumerator GMNCELIMKIF, [In] TSource CABLCDOIFFL) where TSourceEnumerator : ECFAIHPLPAC<TSource> where TSource : FGAMBIEKLBP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B90C80", Offset = "0x2B8F880", VA = "0x182B90C80")]
	public static int PCMNIMHKJMP<TSourceEnumerator, TSource>(this TSourceEnumerator GMNCELIMKIF, [In] TSource CABLCDOIFFL) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECFAIHPLPAC<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FFEGLPIJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IKAAHDBBMFG<T> : ECFAIHPLPAC<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct MLLCLJILNNJ<T, U> : IEnumerable<T>, IEnumerable where U : IKAAHDBBMFG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U FLCFFIMLJNA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BDE0", Offset = "0x3A5A9E0", VA = "0x183A5BDE0")]
	internal MLLCLJILNNJ([In] U LLKKIBMDGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BC90", Offset = "0x3A5A890", VA = "0x183A5BC90", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BD50", Offset = "0x3A5A950", VA = "0x183A5BD50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BD50", Offset = "0x3A5A950", VA = "0x183A5BD50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HDBBFBGELBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2C873D0", Offset = "0x2C85FD0", VA = "0x182C873D0")]
	public static MLLCLJILNNJ<T, U> LMDPPDEOAIA<U>([In] U GMNCELIMKIF) where U : IKAAHDBBMFG<T>
	{
		return default(MLLCLJILNNJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct OPFCIIADDEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct KJNAIBGICJP : ECFAIHPLPAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] LNHGJDLGMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int OMPIGJLMFCI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x42CE1C0", Offset = "0x42CCDC0", VA = "0x1842CE1C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x42CDB30", Offset = "0x42CC730", VA = "0x1842CDB30", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x42CE020", Offset = "0x42CCC20", VA = "0x1842CE020", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB8550", Offset = "0x1DB7150", VA = "0x181DB8550")]
		private KJNAIBGICJP(T[] GMNCELIMKIF, int MFJLAMOCOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E20040", Offset = "0x3E1EC40", VA = "0x183E20040")]
		public static KJNAIBGICJP LMDPPDEOAIA(T[] GMNCELIMKIF)
		{
			return default(KJNAIBGICJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21621C0", Offset = "0x2160DC0", VA = "0x1821621C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2161E30", Offset = "0x2160A30", VA = "0x182161E30", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] BPGFIJBJFGF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x42FF160", Offset = "0x42FDD60", VA = "0x1842FF160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34C2DC0", Offset = "0x34C19C0", VA = "0x1834C2DC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	internal OPFCIIADDEC(T[] BFDOCKABCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47D4230", Offset = "0x47D2E30", VA = "0x1847D4230")]
	public static OPFCIIADDEC<T> EHFCNKAFHAH()
	{
		return default(OPFCIIADDEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
	public IEnumerable<T> GKKKHHMIEGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47D4380", Offset = "0x47D2F80", VA = "0x1847D4380")]
	public ReadOnlySpan<T> PIGDKOOBGOF()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47D4060", Offset = "0x47D2C60", VA = "0x1847D4060")]
	public EBOBOPFCECP<T, OPFCIIADDEC<T>.KJNAIBGICJP> ANNCPIEIHCB()
	{
		return default(EBOBOPFCECP<T, KJNAIBGICJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47D4190", Offset = "0x47D2D90", VA = "0x1847D4190")]
	public KJNAIBGICJP DMCHOHOPHIP()
	{
		return default(KJNAIBGICJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47D4300", Offset = "0x47D2F00", VA = "0x1847D4300")]
	public IEnumerator<T> NEGBLLIJCNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47D4420", Offset = "0x47D3020", VA = "0x1847D4420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JOEOLKCAIAI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C37C60", Offset = "0x2C36860", VA = "0x182C37C60")]
	public static OPFCIIADDEC<T> DOPOOKFJJKA<T>(params T[] BFDOCKABCPN) where T : notnull
	{
		return default(OPFCIIADDEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A1E0", Offset = "0x6D38DE0", VA = "0x186D3A1E0")]
	public static Stream AHFFGEFNMDL(this OPFCIIADDEC<byte> GMNCELIMKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FNPOPJLMFPF<>.CDICMAOOJBK))]
public struct FNPOPJLMFPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DJCJPOAOLME : IKAAHDBBMFG<T>, ECFAIHPLPAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] LODOEKKKDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JIKEGABBENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int OMPIGJLMFCI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5AEBEC0", Offset = "0x5AEAAC0", VA = "0x185AEBEC0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T PLJJNLLKPOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5AEB760", Offset = "0x5AEA360", VA = "0x185AEB760")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T PIIIFHFGFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5AEB500", Offset = "0x5AEA100", VA = "0x185AEB500", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5AEB990", Offset = "0x5AEA590", VA = "0x185AEB990", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5AEBC20", Offset = "0x5AEA820", VA = "0x185AEBC20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x43C7130", Offset = "0x43C5D30", VA = "0x1843C7130")]
		internal DJCJPOAOLME(T[] AIOEIPPJKAA, int KNHHBEFLJAF, int MFJLAMOCOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB640", Offset = "0x5AEA240", VA = "0x185AEB640")]
		public static DJCJPOAOLME LMDPPDEOAIA(FNPOPJLMFPF<T> GMNCELIMKIF)
		{
			return default(DJCJPOAOLME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA590", Offset = "0x3AE9190", VA = "0x183AEA590", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6D20", Offset = "0x3AE5920", VA = "0x183AE6D20", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GLAPPDNPHBP : ECFAIHPLPAC<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DJCJPOAOLME FLCFFIMLJNA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3EEDBF0", Offset = "0x3EEC7F0", VA = "0x183EEDBF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3EEDA10", Offset = "0x3EEC610", VA = "0x183EEDA10", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3EEDB60", Offset = "0x3EEC760", VA = "0x183EEDB60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21204E0", Offset = "0x211F0E0", VA = "0x1821204E0")]
		private GLAPPDNPHBP([In] DJCJPOAOLME LLKKIBMDGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3EED860", Offset = "0x3EEC460", VA = "0x183EED860")]
		public static GLAPPDNPHBP LMDPPDEOAIA([In] FNPOPJLMFPF<T> GMNCELIMKIF)
		{
			return default(GLAPPDNPHBP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3EED910", Offset = "0x3EEC510", VA = "0x183EED910", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3EED950", Offset = "0x3EEC550", VA = "0x183EED950", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3EED820", Offset = "0x3EEC420", VA = "0x183EED820", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CDICMAOOJBK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] LODOEKKKDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JIKEGABBENP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E20860", Offset = "0x3E1F460", VA = "0x183E20860")]
	public static FNPOPJLMFPF<T> LMDPPDEOAIA()
	{
		return default(FNPOPJLMFPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E207A0", Offset = "0x3E1F3A0", VA = "0x183E207A0")]
	public static FNPOPJLMFPF<T> DBHFPKDKFFA(int KPFLHEHNDFJ)
	{
		return default(FNPOPJLMFPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8550", Offset = "0x1DB7150", VA = "0x181DB8550")]
	internal FNPOPJLMFPF(T[] AIOEIPPJKAA, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E20910", Offset = "0x3E1F510", VA = "0x183E20910", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AIONGKHHODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int AJBDFGHJKJJ<TCtx, T>([In] TCtx FLMGBGGMEON, T CKONCFGMELN, T GAAMPOEMOPE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34C35E0", Offset = "0x34C21E0", VA = "0x1834C35E0")]
	public static void PAMNEBLPMKL<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34BBCC0", Offset = "0x34BA8C0", VA = "0x1834BBCC0")]
	public static string ELKKOGBHLLK<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0")]
	public static T[] MOGOHAJMLIP<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2161B90", Offset = "0x2160790", VA = "0x182161B90")]
	public static T IBIJBNAFKLE<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x34C2DC0", Offset = "0x34C19C0", VA = "0x1834C2DC0")]
	public static T LGLOAFKDEKA<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34BFC80", Offset = "0x34BE880", VA = "0x1834BFC80")]
	public static T FDHIJOCAGIG<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34BFDB0", Offset = "0x34BE9B0", VA = "0x1834BFDB0")]
	public static void GAOLHIMCFIN<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA, [In] T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34C3660", Offset = "0x34C2260", VA = "0x1834C3660")]
	public static void PEIEMPIINEC<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2161EC0", Offset = "0x2160AC0", VA = "0x182161EC0")]
	public static int GFJFLCFDNHI<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34C39E0", Offset = "0x34C25E0", VA = "0x1834C39E0")]
	public static ReadOnlySpan<T> PIGDKOOBGOF<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34B8810", Offset = "0x34B7410", VA = "0x1834B8810")]
	public static T[] ALJIHKDKAGD<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34B8AC0", Offset = "0x34B76C0", VA = "0x1834B8AC0")]
	public static T BMGOOGGMIDA<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x34B91A0", Offset = "0x34B7DA0", VA = "0x1834B91A0")]
	public static T[] BMPOHGHBPDG<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34C3440", Offset = "0x34C2040", VA = "0x1834C3440")]
	public static OPFCIIADDEC<T> NDNABCHLCMA<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(OPFCIIADDEC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34B9590", Offset = "0x34B8190", VA = "0x1834B9590")]
	public static void CMCAIIEBGOH<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, [In] T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34B8570", Offset = "0x34B7170", VA = "0x1834B8570")]
	public static void AGIBLHGMBKK<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34C2F70", Offset = "0x34C1B70", VA = "0x1834C2F70")]
	public static void JDDICHJFAAB<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int MFJLAMOCOBC, [In] T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34B9430", Offset = "0x34B8030", VA = "0x1834B9430")]
	public static void CLJBFBPAKIF<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int MFJLAMOCOBC, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x34B9250", Offset = "0x34B7E50", VA = "0x1834B9250")]
	public static void BNGHKLOOFMF<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34BFCF0", Offset = "0x34BE8F0", VA = "0x1834BFCF0")]
	public static T FDJAGDGAIFL<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x34C0490", Offset = "0x34BF090", VA = "0x1834C0490")]
	public static void GHKMHOFCHII<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34B9C50", Offset = "0x34B8850", VA = "0x1834B9C50")]
	private static void DCOOFMGIIBA<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x34B89B0", Offset = "0x34B75B0", VA = "0x1834B89B0")]
	public static void ANKOMBFBDGF<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x34C31A0", Offset = "0x34C1DA0", VA = "0x1834C31A0")]
	public static FNPOPJLMFPF<T> JNOOFNDBBED<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF, NDKGCEEOAFN<T, T> KCOIOLMHOCG)
	{
		return default(FNPOPJLMFPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34B9290", Offset = "0x34B7E90", VA = "0x1834B9290")]
	public static bool CEFMELNJEMA<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, T CABLCDOIFFL) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x34C3510", Offset = "0x34C2110", VA = "0x1834C3510")]
	public static bool ONMCFAGGDOD<T>(this FNPOPJLMFPF<T> GMNCELIMKIF, [In] T CABLCDOIFFL) where T : FGAMBIEKLBP<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2EE4750", Offset = "0x2EE3350", VA = "0x182EE4750")]
	public static bool KIIJDPHLFKB<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34BFD50", Offset = "0x34BE950", VA = "0x1834BFD50")]
	public static bool FKHENKCGONN<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF, int EKJHOCEPHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34C2CF0", Offset = "0x34C18F0", VA = "0x1834C2CF0")]
	public static void HIMFHPHPFDM<T, TCtx>(this FNPOPJLMFPF<T> GMNCELIMKIF, [In] TCtx FLMGBGGMEON, AJBDFGHJKJJ<TCtx, T> HPNEJOOMAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34B9B50", Offset = "0x34B8750", VA = "0x1834B9B50")]
	private static void DAFOMDKBGHE<T, TCtx>(FNPOPJLMFPF<T> GMNCELIMKIF, [In] TCtx FLMGBGGMEON, AJBDFGHJKJJ<TCtx, T> HPNEJOOMAFN, int DBHBKADGBLI, int FCOAAOOPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34B8B00", Offset = "0x34B7700", VA = "0x1834B8B00")]
	private static int BMKMGCFBNBA<T, TCtx>(FNPOPJLMFPF<T> GMNCELIMKIF, [In] TCtx FLMGBGGMEON, AJBDFGHJKJJ<TCtx, T> HPNEJOOMAFN, int DBHBKADGBLI, int FCOAAOOPHPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A570", Offset = "0x2E49170", VA = "0x182E4A570")]
	public static FNPOPJLMFPF<T>.GLAPPDNPHBP NEGBLLIJCNA<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(FNPOPJLMFPF<T>.GLAPPDNPHBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4A570", Offset = "0x2E49170", VA = "0x182E4A570")]
	public static FNPOPJLMFPF<T>.DJCJPOAOLME HNJEMFDBDMN<T>(this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(FNPOPJLMFPF<T>.DJCJPOAOLME);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E496D0", Offset = "0x2E482D0", VA = "0x182E496D0")]
	public static EBOBOPFCECP<T, FNPOPJLMFPF<T>.GLAPPDNPHBP> EEFEMOBJAFF<T>([In] this FNPOPJLMFPF<T> GMNCELIMKIF)
	{
		return default(EBOBOPFCECP<T, FNPOPJLMFPF<T>.GLAPPDNPHBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class JMGDNIIMHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2A70", Offset = "0x2EA1670", VA = "0x182EA2A70")]
	public static T[] DJGJMDNIOMN<T>(int OLKJNOHMJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public static void MLOONOFLEFF<T>(T[] BFDOCKABCPN)
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
