using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62CD720", Offset = "0x62CC520", VA = "0x1862CD720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CANEHOHMINF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected CANEHOHMINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DBGDFADHGAF<T> : CANEHOHMINF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct AFAKKGKIOPB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum DLPOCDNIFPG
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DLPOCDNIFPG DDEINLAGLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T GOECALGCLOK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int LOJFJFDFMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool GCGNGKEJCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool OMEAFAKDOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? FMNCLLMEPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<AFAKKGKIOPB>? JDDBFFCELMB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GDIDJIDMMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5133690", Offset = "0x5132490", VA = "0x185133690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5133CD0", Offset = "0x5132AD0", VA = "0x185133CD0")]
	protected DBGDFADHGAF(bool OMEAFAKDOAK, bool GCGNGKEJCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5133450", Offset = "0x5132250", VA = "0x185133450")]
	protected bool AKAKFMGMCFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5133A10", Offset = "0x5132810", VA = "0x185133A10")]
	protected void IHHNBBBMPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5133B00", Offset = "0x5132900", VA = "0x185133B00")]
	protected void MJAHIEHCOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27C69F0", Offset = "0x27C57F0", VA = "0x1827C69F0")]
	private static void AKEBLONLCMA<U>(List<U>? GIJBOOPKLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51336E0", Offset = "0x51324E0", VA = "0x1851336E0", Slot = "4")]
	public void HDCMKJKDALC(T GOECALGCLOK, bool KHPIBPDNKFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51334F0", Offset = "0x51322F0", VA = "0x1851334F0", Slot = "5")]
	public void BOIJHFOIOPE(T GOECALGCLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51338A0", Offset = "0x51326A0", VA = "0x1851338A0")]
	public void HOCLBDDCDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EOAKMJKFOLH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDCMKJKDALC(Action GOECALGCLOK, bool KHPIBPDNKFB = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOIJHFOIOPE(Action GOECALGCLOK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BFNGIAHHPKE : DBGDFADHGAF<Action>, EOAKMJKFOLH
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62CC750", Offset = "0x62CB550", VA = "0x1862CC750")]
	public BFNGIAHHPKE(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62CC490", Offset = "0x62CB290", VA = "0x1862CC490")]
	public void HEPNPPEJLJB()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62CC6F0", Offset = "0x62CB4F0", VA = "0x1862CC6F0")]
	public static BFNGIAHHPKE MDKBEJFMOHK(BFNGIAHHPKE FAADFFKEDFC, Action GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62CC690", Offset = "0x62CB490", VA = "0x1862CC690")]
	public static BFNGIAHHPKE JJLLPGIMNIC(BFNGIAHHPKE FAADFFKEDFC, Action GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LKKHNCHOGML<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDCMKJKDALC(Action<T> GOECALGCLOK, bool KHPIBPDNKFB = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOIJHFOIOPE(Action<T> GOECALGCLOK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BFFNIPDAHMM<T> : DBGDFADHGAF<Action<T>>, LKKHNCHOGML<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public BFFNIPDAHMM(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x483BAD0", Offset = "0x483A8D0", VA = "0x18483BAD0")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static BFFNIPDAHMM<T> MDKBEJFMOHK(BFFNIPDAHMM<T> FAADFFKEDFC, Action<T> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static BFFNIPDAHMM<T> JJLLPGIMNIC(BFFNIPDAHMM<T> FAADFFKEDFC, Action<T> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PFKDMCFLPPP<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OCLIPKLKFLJ<T, U> : DBGDFADHGAF<Action<T, U>>, PFKDMCFLPPP<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public OCLIPKLKFLJ(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4101C60", Offset = "0x4100A60", VA = "0x184101C60")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH, U KNNPGKCNJMC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static OCLIPKLKFLJ<T, U> MDKBEJFMOHK(OCLIPKLKFLJ<T, U> FAADFFKEDFC, Action<T, U> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static OCLIPKLKFLJ<T, U> JJLLPGIMNIC(OCLIPKLKFLJ<T, U> FAADFFKEDFC, Action<T, U> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CINFAOKHFKB<T, U, V> : DBGDFADHGAF<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public CINFAOKHFKB(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4DF55F0", Offset = "0x4DF43F0", VA = "0x184DF55F0")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH, U KNNPGKCNJMC, V ALCIJOKMJPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static CINFAOKHFKB<T, U, V> MDKBEJFMOHK(CINFAOKHFKB<T, U, V> FAADFFKEDFC, Action<T, U, V> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static CINFAOKHFKB<T, U, V> JJLLPGIMNIC(CINFAOKHFKB<T, U, V> FAADFFKEDFC, Action<T, U, V> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LGCAGFEDHMN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MMCDONPFMAD<T, U, V, W> : DBGDFADHGAF<Action<T, U, V, W>>, LGCAGFEDHMN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public MMCDONPFMAD(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3FAFEA0", Offset = "0x3FAECA0", VA = "0x183FAFEA0")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH, U KNNPGKCNJMC, V ALCIJOKMJPM, W EEKLJBLGCEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static MMCDONPFMAD<T, U, V, W> MDKBEJFMOHK(MMCDONPFMAD<T, U, V, W> FAADFFKEDFC, Action<T, U, V, W> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static MMCDONPFMAD<T, U, V, W> JJLLPGIMNIC(MMCDONPFMAD<T, U, V, W> FAADFFKEDFC, Action<T, U, V, W> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ECAPJJGEEKF<T, U, V, W, X> : DBGDFADHGAF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public ECAPJJGEEKF(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3475E50", Offset = "0x3474C50", VA = "0x183475E50")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH, U KNNPGKCNJMC, V ALCIJOKMJPM, W EEKLJBLGCEC, X FCLAAGLFIOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static ECAPJJGEEKF<T, U, V, W, X> MDKBEJFMOHK(ECAPJJGEEKF<T, U, V, W, X> FAADFFKEDFC, Action<T, U, V, W, X> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static ECAPJJGEEKF<T, U, V, W, X> JJLLPGIMNIC(ECAPJJGEEKF<T, U, V, W, X> FAADFFKEDFC, Action<T, U, V, W, X> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ODBKOCIIBLK<T, U, V, W, X, Y> : DBGDFADHGAF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
	public ODBKOCIIBLK(bool OMEAFAKDOAK = false, bool GCGNGKEJCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4104B10", Offset = "0x4103910", VA = "0x184104B10")]
	public void HEPNPPEJLJB(T HKJAKBPEJHH, U KNNPGKCNJMC, V ALCIJOKMJPM, W EEKLJBLGCEC, X FCLAAGLFIOD, Y OJPNBFDBAHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475060", VA = "0x183476260")]
	public static ODBKOCIIBLK<T, U, V, W, X, Y> MDKBEJFMOHK(ODBKOCIIBLK<T, U, V, W, X, Y> FAADFFKEDFC, Action<T, U, V, W, X, Y> GOECALGCLOK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34761D0", Offset = "0x3474FD0", VA = "0x1834761D0")]
	public static ODBKOCIIBLK<T, U, V, W, X, Y> JJLLPGIMNIC(ODBKOCIIBLK<T, U, V, W, X, Y> FAADFFKEDFC, Action<T, U, V, W, X, Y> GOECALGCLOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KHHKOAIAEJL<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EMHJELMEIHN<TKey, TVal> KGJOPJEFEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NOEABBIJCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EMHJELMEIHN<TKey, TVal>.LFLDNIOEBEC? OIMNNLNFJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int CMBCAGAEDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EMHJELMEIHN<TKey, TVal>.NKOBJGMJOCC? IMDIDOHPBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int EPIHHEPIBJG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int OPOIJPDMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D08550", Offset = "0x3D07350", VA = "0x183D08550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int IIDNAHMDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B5040", Offset = "0x7B3E40", VA = "0x1807B5040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D09280", Offset = "0x3D08080", VA = "0x183D09280")]
	public KHHKOAIAEJL(int CMBCAGAEDNA, [Optional] EMHJELMEIHN<TKey, TVal>.NKOBJGMJOCC? IMDIDOHPBJN, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] EMHJELMEIHN<TKey, TVal>.LFLDNIOEBEC? OIMNNLNFJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D08EA0", Offset = "0x3D07CA0", VA = "0x183D08EA0")]
	public void KGNGLLKPINL(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN, bool KGPJJKJLAFN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3D08430", Offset = "0x3D07230", VA = "0x183D08430")]
	public bool CBLLDNHFOPC(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3D08DD0", Offset = "0x3D07BD0", VA = "0x183D08DD0")]
	public bool JJGGEGPCFME(TKey KPFCBAHENED, [Out] TVal DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D09050", Offset = "0x3D07E50", VA = "0x183D09050")]
	private void LIPGBAHEIOL(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN, int CGDBKIJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D08590", Offset = "0x3D07390", VA = "0x183D08590")]
	public bool FENDCEAKKKF(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN, bool KGPJJKJLAFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D08D70", Offset = "0x3D07B70", VA = "0x183D08D70")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D087E0", Offset = "0x3D075E0", VA = "0x183D087E0")]
	private void GKCDNICCPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D08700", Offset = "0x3D07500", VA = "0x183D08700")]
	private bool GDHMJNNOMNA(TKey OBPLDLNDJLE, JHGAMDLBKEH JNFKLJKGAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D08CA0", Offset = "0x3D07AA0", VA = "0x183D08CA0")]
	private void GKCLLCEIKNO(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN, JHGAMDLBKEH JNFKLJKGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D08310", Offset = "0x3D07110", VA = "0x183D08310")]
	private void AABNDAOKBAI(TKey OBPLDLNDJLE, TVal FLOENDBPFOD, JHGAMDLBKEH JNFKLJKGAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KJMMLBPIJNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action IJKBLOGGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool FMAGMELLPFG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public KJMMLBPIJNP(Action ANEGJLMNFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62CCD50", Offset = "0x62CBB50", VA = "0x1862CCD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26AC750", Offset = "0x26AB550", VA = "0x1826AC750")]
	public static HFMDJFNGONB<T> ANGJMEBBFOG<T>(T DIBNBLEEFNN, Action ANEGJLMNFGB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HFMDJFNGONB<T> : KJMMLBPIJNP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39BB600", Offset = "0x39BA400", VA = "0x1839BB600")]
	public HFMDJFNGONB(T DIBNBLEEFNN, Action ANEGJLMNFGB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OFLIHLAMOOO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct KFIHEFLKECH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
		public static KFIHEFLKECH KHDJPNLCMFA()
		{
			return default(KFIHEFLKECH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A20A70", Offset = "0x2A1F870", VA = "0x182A20A70")]
	public static string? OLEIBLCMGNH<T>([Optional] string? JPCPNAKLECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A209F0", Offset = "0x2A1F7F0", VA = "0x182A209F0")]
	public static string? KLPIOFECEFL<T>([Optional] string? HIDIDEHACEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	public static OFLIHLAMOOO LMFLNJNPHGE(string JPCPNAKLECF, string? HIDIDEHACEF)
	{
		return default(OFLIHLAMOOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OKBDKGKGGJB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool MEFKPECMKCF(string PNDDMHLGLDE, OKBDKGKGGJB ODPILPOOCPB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public int GOCCBDNGINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public string IOHIIDODDEI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62CDB60", Offset = "0x62CC960", VA = "0x1862CDB60")]
	public static Dictionary<string, OKBDKGKGGJB> GMMDPFPCHAN(Type FCPNIIFMLJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62CD7A0", Offset = "0x62CC5A0", VA = "0x1862CD7A0")]
	public static Dictionary<string, OKBDKGKGGJB> AJHLMDLAMAD(Type FCPNIIFMLJJ, MEFKPECMKCF CEJFHKJKDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x62CDE90", Offset = "0x62CCC90", VA = "0x1862CDE90")]
	public static Dictionary<int, string> IMCKGPCPGDA(Dictionary<string, OKBDKGKGGJB> PFNKIIMPMKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PCJEOFJNKHC : KFOBAHPPIAN
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool PNFLPKFKFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string? JEDDKKPILNC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual KFOBAHPPIAN? IBNHAPMOIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62CE6F0", Offset = "0x62CD4F0", VA = "0x1862CE6F0")]
	protected PCJEOFJNKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string AGPNECGLHAF();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62CE2B0", Offset = "0x62CD0B0", VA = "0x1862CE2B0", Slot = "8")]
	public virtual string NMJPNDMJLDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62CE450", Offset = "0x62CD250", VA = "0x1862CE450", Slot = "9")]
	public void OJKIDMAGLPF(StringBuilder GKBILPPEBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62CE050", Offset = "0x62CCE50", VA = "0x1862CE050", Slot = "10")]
	public void AAOMIHJJFDO(StringBuilder GKBILPPEBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62CE330", Offset = "0x62CD130", VA = "0x1862CE330", Slot = "11")]
	public void OFCNIHHIBOL(StringBuilder GKBILPPEBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62CE150", Offset = "0x62CCF50", VA = "0x1862CE150", Slot = "12")]
	public void FLFIHGJEAED(StringBuilder GKBILPPEBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62CE0B0", Offset = "0x62CCEB0", VA = "0x1862CE0B0")]
	public static void DNIOPAMNPAO(StringBuilder GKBILPPEBAF, string LBELDANHHBD, string EBPPCILAJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5517440", Offset = "0x5516240", VA = "0x185517440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FOEKDFGHDEM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x62CC9B0", Offset = "0x62CB7B0", VA = "0x1862CC9B0")]
	public FOEKDFGHDEM(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IBMLFDMMCLB<TErr> : FOEKDFGHDEM where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TErr JELNDOOKBJP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BBA0", Offset = "0x3A6A9A0", VA = "0x183A6BBA0")]
	private IBMLFDMMCLB([In] TErr HCNIFIAELPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BAE0", Offset = "0x3A6A8E0", VA = "0x183A6BAE0")]
	public static IBMLFDMMCLB<TErr> KHDJPNLCMFA([In] TErr HCNIFIAELPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KFOBAHPPIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NMJPNDMJLDB();

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AGPNECGLHAF();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JJDPBFABAGA<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HOKNIKEGCOM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DEKHAGFHDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GAJKHOICNPK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62CCA10", Offset = "0x62CB810", VA = "0x1862CCA10")]
	public GAJKHOICNPK(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KAMGHDHAACG<TOk> : GAJKHOICNPK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly TOk IMBOAPNHEMO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA5A0", Offset = "0x3CD93A0", VA = "0x183CDA5A0")]
	private KAMGHDHAACG([In] TOk HOFJALBPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3924100", Offset = "0x3922F00", VA = "0x183924100")]
	public static KAMGHDHAACG<TOk> KHDJPNLCMFA([In] TOk HOFJALBPLAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct PJPNKGNAEHO<TOk, TErr> : IEquatable<PJPNKGNAEHO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly EqualityComparer<TErr> CIOANLNFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TErr JELNDOOKBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal readonly TOk IMBOAPNHEMO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CGMFIANPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x41D2CE0", Offset = "0x41D1AE0", VA = "0x1841D2CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GDEPMMCCDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x41D0FE0", Offset = "0x41CFDE0", VA = "0x1841D0FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x41D7900", Offset = "0x41D6700", VA = "0x1841D7900")]
	internal PJPNKGNAEHO([In] TErr HCNIFIAELPI, [In] TOk HOFJALBPLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x41D4DB0", Offset = "0x41D3BB0", VA = "0x1841D4DB0")]
	public static PJPNKGNAEHO<TOk, TErr> PGNPAIMMOND([In] TErr HCNIFIAELPI)
	{
		return default(PJPNKGNAEHO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x41D1340", Offset = "0x41D0140", VA = "0x1841D1340")]
	public static PJPNKGNAEHO<TOk, TErr> GIIGPJKEGDG([In] TOk HOFJALBPLAG)
	{
		return default(PJPNKGNAEHO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2886CB0", Offset = "0x2885AB0", VA = "0x182886CB0")]
	public PJPNKGNAEHO<TOk?, UErr?> JJJHJEILJLD<UErr>()
	{
		return default(PJPNKGNAEHO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2886980", Offset = "0x2885780", VA = "0x182886980")]
	public PJPNKGNAEHO<UOk?, TErr?> GAIPJKIHOEB<UOk>()
	{
		return default(PJPNKGNAEHO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2887C20", Offset = "0x2886A20", VA = "0x182887C20")]
	public PJPNKGNAEHO<UOk?, TErr?> PNHFJCEDNDL<UOk>()
	{
		return default(PJPNKGNAEHO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2886430", Offset = "0x2885230", VA = "0x182886430")]
	public PJPNKGNAEHO<TOk?, UErr?> BEDCFGLKNDO<UErr>()
	{
		return default(PJPNKGNAEHO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x41D45B0", Offset = "0x41D33B0", VA = "0x1841D45B0")]
	public PJPNKGNAEHO<CDPLPCBKJFN, TErr> ONJIKOENEHK()
	{
		return default(PJPNKGNAEHO<CDPLPCBKJFN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x41D34D0", Offset = "0x41D22D0", VA = "0x1841D34D0")]
	public static bool OFKPFEHPLBH([In] PJPNKGNAEHO<TOk, TErr> DCJCHFKPCOP, [In] PJPNKGNAEHO<TOk, TErr> IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x41CFFA0", Offset = "0x41CEDA0", VA = "0x1841CFFA0", Slot = "4")]
	public bool Equals(PJPNKGNAEHO<TOk, TErr> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x41D02A0", Offset = "0x41CF0A0", VA = "0x1841D02A0", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41D1ED0", Offset = "0x41D0CD0", VA = "0x1841D1ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x41D7290", Offset = "0x41D6090", VA = "0x1841D7290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FHEDILAKIJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct PPDLLFCOAJG<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Task<PJPNKGNAEHO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PJPNKGNAEHO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4240830", Offset = "0x423F630", VA = "0x184240830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4240B30", Offset = "0x423F930", VA = "0x184240B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x28B1930", Offset = "0x28B0730", VA = "0x1828B1930")]
	public static PJPNKGNAEHO<TOk?, TErr?> IMBOAPNHEMO<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [In] TOk HOFJALBPLAG)
	{
		return default(PJPNKGNAEHO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28B1A40", Offset = "0x28B0840", VA = "0x1828B1A40")]
	public static PJPNKGNAEHO<CDPLPCBKJFN, TErr?> IMBOAPNHEMO<TErr>([In] this PJPNKGNAEHO<CDPLPCBKJFN, TErr> ILACEKALGJH)
	{
		return default(PJPNKGNAEHO<CDPLPCBKJFN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x28B1930", Offset = "0x28B0730", VA = "0x1828B1930")]
	public static PJPNKGNAEHO<TOk?, TErr?> JELNDOOKBJP<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [In] TErr HCNIFIAELPI)
	{
		return default(PJPNKGNAEHO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x28B1380", Offset = "0x28B0180", VA = "0x1828B1380")]
	public static TOk? GNKJDGLFAMK<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x28B2350", Offset = "0x28B1150", VA = "0x1828B2350")]
	[AsyncStateMachine(typeof(PPDLLFCOAJG<, >))]
	public static Task<TOk?>? OLHCICDACKK<TOk, TErr>(this Task<PJPNKGNAEHO<TOk, TErr>> ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x28B1C60", Offset = "0x28B0A60", VA = "0x1828B1C60")]
	public static TErr? KCDBDCHCNHB<TErr, TOk>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28AFD40", Offset = "0x28AEB40", VA = "0x1828AFD40")]
	public static bool AONDPPOGLLD<TOk, TErr, UErr, UOk>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out] PJPNKGNAEHO<UOk, UErr> JHIHMMMFHNF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28B0DE0", Offset = "0x28AFBE0", VA = "0x1828B0DE0")]
	public static bool CLBKLGLLGIA<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TOk HOFJALBPLAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28B2650", Offset = "0x28B1450", VA = "0x1828B2650")]
	public static bool OLMBPMBJHGI<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TErr HCNIFIAELPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28B1290", Offset = "0x28B0090", VA = "0x1828B1290")]
	public static bool GLFEOMDKCHB<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TOk HOFJALBPLAG, [Out][NotNullWhen(false)] TErr HCNIFIAELPI) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x28B1190", Offset = "0x28AFF90", VA = "0x1828B1190")]
	public static bool EALMPPNDFNP<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TOk HOFJALBPLAG, [Out] PJPNKGNAEHO<TOk, TErr> JHIHMMMFHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x28AFFC0", Offset = "0x28AEDC0", VA = "0x1828AFFC0")]
	public static bool AONDPPOGLLD<TOk, TErr, UErr, UOk>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TOk HOFJALBPLAG, [Out] PJPNKGNAEHO<UOk, UErr> JHIHMMMFHNF) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x28B1FF0", Offset = "0x28B0DF0", VA = "0x1828B1FF0")]
	public static bool LLMKCHNMCDD<TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [Out][NotNullWhen(true)] TOk HOFJALBPLAG, [Out] PJPNKGNAEHO<CDPLPCBKJFN, TErr> JHIHMMMFHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x28AFA10", Offset = "0x28AE810", VA = "0x1828AFA10")]
	public static PJPNKGNAEHO<UOk, UErr> AFJLCOBDBDB<UOk, UErr, TOk, TErr>([In] this PJPNKGNAEHO<TOk, TErr> ILACEKALGJH, [In] PJPNKGNAEHO<UOk, UErr> KDBMKOJJIJP) where TOk : UOk where TErr : UErr
	{
		return default(PJPNKGNAEHO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x28B0E50", Offset = "0x28AFC50", VA = "0x1828B0E50")]
	public static PJPNKGNAEHO<TOk?[]?, TErr?> DPCJJFLGOFF<TOk, TErr>(this IEnumerable<PJPNKGNAEHO<TOk, TErr>> ILACEKALGJH)
	{
		return default(PJPNKGNAEHO<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class APNAKEBCIBJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23AD250", Offset = "0x23AC050", VA = "0x1823AD250")]
	public static PJPNKGNAEHO<TOk, T> IMBOAPNHEMO<TOk>([In] TOk HOFJALBPLAG) where TOk : notnull
	{
		return default(PJPNKGNAEHO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3925710", Offset = "0x3924510", VA = "0x183925710")]
	public static PJPNKGNAEHO<CDPLPCBKJFN, T> IMBOAPNHEMO()
	{
		return default(PJPNKGNAEHO<CDPLPCBKJFN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x23AD250", Offset = "0x23AC050", VA = "0x1823AD250")]
	public static PJPNKGNAEHO<T, TErr> JELNDOOKBJP<TErr>([In] TErr HCNIFIAELPI) where TErr : notnull
	{
		return default(PJPNKGNAEHO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class CICJIDOEHHG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct CEMLICKDGON : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CICJIDOEHHG<T> HIBKNIHOKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly int GDIMCDMLPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly bool FIOBMGHDHFL;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D34300", Offset = "0x1D33100", VA = "0x181D34300")]
		public CEMLICKDGON(CICJIDOEHHG<T> LFPEHEIJNLK, int IABGEHJDNJN, bool BFBPKGOIJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F2A0", Offset = "0x4C4E0A0", VA = "0x184C4F2A0")]
		public CICJIDOEHHG<T>.CNHAFHAPJNG CNEJODDGPIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F380", Offset = "0x4C4E180", VA = "0x184C4F380", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F380", Offset = "0x4C4E180", VA = "0x184C4F380", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class CNHAFHAPJNG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly CICJIDOEHHG<T> HIBKNIHOKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly int CGKIIJPOELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int BHJJIECEHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly bool FIOBMGHDHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool MKHOHNNCLKK;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4E00790", Offset = "0x4DFF590", VA = "0x184E00790")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4E008E0", Offset = "0x4DFF6E0", VA = "0x184E008E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x4E00A10", Offset = "0x4DFF810", VA = "0x184E00A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4E00C60", Offset = "0x4DFFA60", VA = "0x184E00C60")]
		public CNHAFHAPJNG(CICJIDOEHHG<T> LFPEHEIJNLK, int IABGEHJDNJN, bool BFBPKGOIJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4E00810", Offset = "0x4DFF610", VA = "0x184E00810", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4E00890", Offset = "0x4DFF690", VA = "0x184E00890", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BLBPHJIMBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BLBPHJIMBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x485CE20", Offset = "0x485BC20", VA = "0x18485CE20")]
		internal T BINFDPDIDCH(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly T[] CNPGJOJBGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int BHJJIECEHDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JINPHGIIOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4D22700", Offset = "0x4D21500", VA = "0x184D22700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T HKCIIOLPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3802310", Offset = "0x3801110", VA = "0x183802310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T HFBNPFMLIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4D226D0", Offset = "0x4D214D0", VA = "0x184D226D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4D227E0", Offset = "0x4D215E0", VA = "0x184D227E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x172E440", Offset = "0x172D240", VA = "0x18172E440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xFE6B50", Offset = "0xFE5950", VA = "0x180FE6B50")]
	private static int LLCANGLOPHL(int AELAKOMEEDP, int PDCHCFIOJCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D22910", Offset = "0x4D21710", VA = "0x184D22910")]
	public CICJIDOEHHG(int CGDBKIJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D22A20", Offset = "0x4D21820", VA = "0x184D22A20")]
	public CICJIDOEHHG(int CGDBKIJPKOF, Func<T> KANFBJDEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D22870", Offset = "0x4D21670", VA = "0x184D22870")]
	public CICJIDOEHHG(T[] OMJAEJKGFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D22840", Offset = "0x4D21640", VA = "0x184D22840")]
	public void OODAEFEKOOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D22610", Offset = "0x4D21410", VA = "0x184D22610")]
	public IEnumerable<T> COPHBMIBJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4D22590", Offset = "0x4D21390", VA = "0x184D22590")]
	public CICJIDOEHHG<T>.CNHAFHAPJNG CNEJODDGPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38BBDE0", Offset = "0x38BABE0", VA = "0x1838BBDE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38BBDE0", Offset = "0x38BABE0", VA = "0x1838BBDE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class JHDDMAJKFDF
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x292DE20", Offset = "0x292CC20", VA = "0x18292DE20")]
	public static CICJIDOEHHG<T> KHDJPNLCMFA<T>(int CGDBKIJPKOF, Func<T> KANFBJDEKAM) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E22B50", Offset = "0x1E21950", VA = "0x181E22B50")]
		public RRColor(float HFJACMIAHKE, float HKANOMPBPHC, float CJOKOOBKDLJ, float CGAHKNIFIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62CEA40", Offset = "0x62CD840", VA = "0x1862CEA40", Slot = "4")]
		public bool Equals(RRColor GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62CEAC0", Offset = "0x62CD8C0", VA = "0x1862CEAC0", Slot = "0")]
		public override bool Equals(object GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62CEBC0", Offset = "0x62CD9C0", VA = "0x1862CEBC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62CEC40", Offset = "0x62CDA40", VA = "0x1862CEC40", Slot = "5")]
		public string ToString(string FFCCHAGPLED, IFormatProvider FNHBIDALEAJ)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class CBHHKBKCFAM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct IMJKCHKHAPC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CBHHKBKCFAM<T> ACODECILLCL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3A91A70", Offset = "0x3A90870", VA = "0x183A91A70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A91A40", Offset = "0x3A90840", VA = "0x183A91A40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
		public IMJKCHKHAPC(CBHHKBKCFAM<T> ACODECILLCL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IDBHJMGDMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<IMJKCHKHAPC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CBHHKBKCFAM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A6EA90", Offset = "0x3A6D890", VA = "0x183A6EA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3274820", Offset = "0x3273620", VA = "0x183274820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim BCBAAEAFJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T OABALNFGLCN;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F130", Offset = "0x4C3DF30", VA = "0x184C3F130")]
	public CBHHKBKCFAM([In] T OABALNFGLCN, int OGHMDNIAHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F110", Offset = "0x4C3DF10", VA = "0x184C3F110")]
	public CBHHKBKCFAM([In] T OABALNFGLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F090", Offset = "0x4C3DE90", VA = "0x184C3F090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F0D0", Offset = "0x4C3DED0", VA = "0x184C3F0D0")]
	public IMJKCHKHAPC FHEGPIBBEGI()
	{
		return default(IMJKCHKHAPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C3ED40", Offset = "0x4C3DB40", VA = "0x184C3ED40")]
	[AsyncStateMachine(typeof(CBHHKBKCFAM<>.IDBHJMGDMOK))]
	public Task<CBHHKBKCFAM<T>.IMJKCHKHAPC> AHJGPGODIIG(CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C3F070", Offset = "0x4C3DE70", VA = "0x184C3F070")]
	public void DGOKBFAKMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BAIKLALGGPL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x62CBAF0", Offset = "0x62CA8F0", VA = "0x1862CBAF0")]
	public static CBHHKBKCFAM<CDPLPCBKJFN> KHDJPNLCMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static CBHHKBKCFAM<T> KHDJPNLCMFA<T>([In] T OABALNFGLCN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class MCBIBCPDKBM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct IKHLFLPIKED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly MCBIBCPDKBM<T> IGMMHMPHBKH;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x3A88A30", Offset = "0x3A87830", VA = "0x183A88A30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3A887B0", Offset = "0x3A875B0", VA = "0x183A887B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
		internal IKHLFLPIKED(MCBIBCPDKBM<T> ACODECILLCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct PHBFBDLMPCE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly MCBIBCPDKBM<T> IGMMHMPHBKH;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3A88A30", Offset = "0x3A87830", VA = "0x183A88A30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x41CD8B0", Offset = "0x41CC6B0", VA = "0x1841CD8B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
		internal PHBFBDLMPCE(MCBIBCPDKBM<T> ACODECILLCL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DPLNECKFHLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<PHBFBDLMPCE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public MCBIBCPDKBM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private CBHHKBKCFAM<CDPLPCBKJFN>.IMJKCHKHAPC <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskAwaiter<CBHHKBKCFAM<CDPLPCBKJFN>.IMJKCHKHAPC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5177460", Offset = "0x5176260", VA = "0x185177460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3274820", Offset = "0x3273620", VA = "0x183274820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CBHHKBKCFAM<int> GOKPEFEBJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly CBHHKBKCFAM<CDPLPCBKJFN> NCLFFNJLDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CBHHKBKCFAM<CDPLPCBKJFN> GCOCLIKCHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T LHFFOKHAENP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F761E0", Offset = "0x3F74FE0", VA = "0x183F761E0")]
	internal MCBIBCPDKBM(CBHHKBKCFAM<int> JNEEFNIOFMJ, CBHHKBKCFAM<CDPLPCBKJFN> OBIJIDENFIF, CBHHKBKCFAM<CDPLPCBKJFN> DEECBKBNGOL, [In] T OABALNFGLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F759B0", Offset = "0x3F747B0", VA = "0x183F759B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3F753F0", Offset = "0x3F741F0", VA = "0x183F753F0")]
	public IKHLFLPIKED DHCDCJJKPAK()
	{
		return default(IKHLFLPIKED);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3F75BA0", Offset = "0x3F749A0", VA = "0x183F75BA0")]
	public PHBFBDLMPCE JHIMPLGLBKB()
	{
		return default(PHBFBDLMPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3F75EA0", Offset = "0x3F74CA0", VA = "0x183F75EA0")]
	[AsyncStateMachine(typeof(MCBIBCPDKBM<>.DPLNECKFHLN))]
	public Task<MCBIBCPDKBM<T>.PHBFBDLMPCE> NICACHGBIKN(CancellationToken KANPDHELHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DAKPKDGOAHH
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62CC7B0", Offset = "0x62CB5B0", VA = "0x1862CC7B0")]
	public static MCBIBCPDKBM<CDPLPCBKJFN> KHDJPNLCMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x273FB00", Offset = "0x273E900", VA = "0x18273FB00")]
	public static MCBIBCPDKBM<T> KHDJPNLCMFA<T>([In] T OABALNFGLCN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class AHEGDDONNPI<TData> : PCJEOFJNKHC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string NNEKJCMAIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly TData OJPNFDCEOJE;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
	public override string AGPNECGLHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x390D9E0", Offset = "0x390C7E0", VA = "0x18390D9E0")]
	internal AHEGDDONNPI(string HPJAAILCALJ, [In] TData LHODDAGAJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LBJHHBLEGEB
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x62CCE30", Offset = "0x62CBC30", VA = "0x1862CCE30")]
	public static AHEGDDONNPI<CDPLPCBKJFN> KHDJPNLCMFA(string HPJAAILCALJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26AC750", Offset = "0x26AB550", VA = "0x1826AC750")]
	public static AHEGDDONNPI<TData> KHDJPNLCMFA<TData>(string HPJAAILCALJ, [In] TData LHODDAGAJKC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class NBKOMHGOKLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly Dictionary<object, float> BHHBJAICHNE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MDKIHMPBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x938680", Offset = "0x937480", VA = "0x180938680")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x938720", Offset = "0x937520", VA = "0x180938720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x62CD430", Offset = "0x62CC230", VA = "0x1862CD430")]
	public void HJOOJPBLNDO(float DIBNBLEEFNN, object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x62CD4A0", Offset = "0x62CC2A0", VA = "0x1862CD4A0")]
	public void HPJCIBMLEPI(object ADNDMAGEPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62CD510", Offset = "0x62CC310", VA = "0x1862CD510")]
	private void KAJFAGOECCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62CD640", Offset = "0x62CC440", VA = "0x1862CD640")]
	public NBKOMHGOKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OGIFIJNJLEH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JBNJFNMPEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JBNJFNMPEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C185E0", Offset = "0x3C173E0", VA = "0x183C185E0")]
		internal int MCBPLGPJAAF(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HashSet<T>? CJBMHKOKFFA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> FPPMCEAONBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4106C90", Offset = "0x4105A90", VA = "0x184106C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LJNMEKGNKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4106CC0", Offset = "0x4105AC0", VA = "0x184106CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BAD50", VA = "0x1807BBF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4106B40", Offset = "0x4105940", VA = "0x184106B40")]
	public bool HDCMKJKDALC(T ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41069F0", Offset = "0x41057F0", VA = "0x1841069F0")]
	public bool BOIJHFOIOPE(T ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4106B00", Offset = "0x4105900", VA = "0x184106B00")]
	public bool FLKCGLEENDL(T ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4106CF0", Offset = "0x4105AF0", VA = "0x184106CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OGIFIJNJLEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class NNMEDCEFICD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly string DADFKOEKIBB;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public NNMEDCEFICD(string DADFKOEKIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62CD6D0", Offset = "0x62CC4D0", VA = "0x1862CD6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MJAHGDHMCCG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class IIDDOMLELFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public IIDDOMLELFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x62CCCA0", Offset = "0x62CBAA0", VA = "0x1862CCCA0")]
		internal int MCBPLGPJAAF(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<object>? CJBMHKOKFFA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> FPPMCEAONBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x62CD100", Offset = "0x62CBF00", VA = "0x1862CD100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LJNMEKGNKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x62CD190", Offset = "0x62CBF90", VA = "0x1862CD190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BAD50", VA = "0x1807BBF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x62CD020", Offset = "0x62CBE20", VA = "0x1862CD020")]
	public bool HDCMKJKDALC(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x62CCEB0", Offset = "0x62CBCB0", VA = "0x1862CCEB0")]
	public bool BOIJHFOIOPE(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62CCFC0", Offset = "0x62CBDC0", VA = "0x1862CCFC0")]
	public bool FLKCGLEENDL(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x62CCF50", Offset = "0x62CBD50", VA = "0x1862CCF50")]
	public void CBADDPENDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x62CD1A0", Offset = "0x62CBFA0", VA = "0x1862CD1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MJAHGDHMCCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DFBBOHICGKE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct LEMGOKEFIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float HHKFCJPEKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public T ACOGNAIJGCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly Dictionary<object, LEMGOKEFIEJ> BHHBJAICHNE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T NMOHNJBANKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xF0FD10", Offset = "0xF0EB10", VA = "0x180F0FD10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xF0F300", Offset = "0xF0E100", VA = "0x180F0F300", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? KEHDNMPJOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HDADAKMDAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5139CF0", Offset = "0x5138AF0", VA = "0x185139CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x51399D0", Offset = "0x51387D0", VA = "0x1851399D0")]
	public bool HJOOJPBLNDO(T DIBNBLEEFNN, object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x391D560", Offset = "0x391C360", VA = "0x18391D560")]
	public bool HPJCIBMLEPI(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5139D30", Offset = "0x5138B30", VA = "0x185139D30")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5139EB0", Offset = "0x5138CB0", VA = "0x185139EB0")]
	public bool JJGGEGPCFME(object ADNDMAGEPOK, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x513A620", Offset = "0x5139420", VA = "0x18513A620")]
	[KNIGENDFPDF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool PNMJGIBPLIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x513B5A0", Offset = "0x513A3A0", VA = "0x18513B5A0")]
	public DFBBOHICGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PNNOEIFPDFF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DOELIBPJNPB EAHCNALPKDL;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BFFFHIMMFJB : PNNOEIFPDFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct PDJHOBJGOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float FIAKOELMJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public readonly float KOHIIJEKJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		internal readonly bool GOBGLGCFBCN;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float EDOPLBKMBBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x62CE760", Offset = "0x62CD560", VA = "0x1862CE760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x62CE8E0", Offset = "0x62CD6E0", VA = "0x1862CE8E0")]
		public PDJHOBJGOFH(float GJACDHHHCDB, float NFJLMFFPDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x62CE770", Offset = "0x62CD570", VA = "0x1862CE770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KKIHNGAOHOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BFFFHIMMFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KKIHNGAOHOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x62CCD90", Offset = "0x62CBB90", VA = "0x1862CCD90")]
		internal void KJBPDCCFABH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly int GIOLCDOMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int LPBGCJBMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PNNOEIFPDFF[] KBHNLEDODMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly DOELIBPJNPB[] EEEILKJFPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PDJHOBJGOFH[] OKBMAHCGJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private PDJHOBJGOFH FHBPDBMJPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IHGOAOGGGHG DJOBNFHCMFE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event DOELIBPJNPB EAHCNALPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62CC180", Offset = "0x62CAF80", VA = "0x1862CC180", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62CC240", Offset = "0x62CB040", VA = "0x1862CC240", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x62CC300", Offset = "0x62CB100", VA = "0x1862CC300")]
	public BFFFHIMMFJB(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x62CBC70", Offset = "0x62CAA70", VA = "0x1862CBC70")]
	public IHGOAOGGGHG GBPPLIMLBMK(PDJHOBJGOFH LONOJKBEIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x62CBD00", Offset = "0x62CAB00", VA = "0x1862CBD00")]
	public void HJBMOMMEHML(PNNOEIFPDFF DFNCLEANMNK, [Optional] PDJHOBJGOFH FIIOFMAGIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x62CBB60", Offset = "0x62CA960", VA = "0x1862CBB60", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void DOELIBPJNPB(float OEDPFJODJIM);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class EOCKPJHDHPF
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class MLFPAOCFPFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly PNNOEIFPDFF DGFBEJKNMFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly DOELIBPJNPB KPIAINDMMOB;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62CD3A0", Offset = "0x62CC1A0", VA = "0x1862CD3A0")]
		public MLFPAOCFPFL(PNNOEIFPDFF DGFBEJKNMFA, DOELIBPJNPB KPIAINDMMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62CD350", Offset = "0x62CC150", VA = "0x1862CD350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x62CC880", Offset = "0x62CB680", VA = "0x1862CC880")]
	internal static bool COLPMODMNLL(float CGAHKNIFIAB, float CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62BD4B0", Offset = "0x62BC2B0", VA = "0x1862BD4B0")]
	internal static float HBOJBDIEDMC(float CGAHKNIFIAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x62CC8F0", Offset = "0x62CB6F0", VA = "0x1862CC8F0")]
	public static IDisposable MMNAAACINLP(this PNNOEIFPDFF DGFBEJKNMFA, DOELIBPJNPB KPIAINDMMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IHGOAOGGGHG : PNNOEIFPDFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float OEDPFJODJIM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float GENLFNEHGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62CCA70", Offset = "0x62CB870", VA = "0x1862CCA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event DOELIBPJNPB? EAHCNALPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62CCB60", Offset = "0x62CB960", VA = "0x1862CCB60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62CCC00", Offset = "0x62CBA00", VA = "0x1862CCC00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public IHGOAOGGGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CNGNBCNNLAG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E380", Offset = "0x5D8D180", VA = "0x185D8E380")]
	public CNGNBCNNLAG(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class APNKEMDAMBG<TKey, TValue> : FCBKIFIOJEL<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, BMLACNEJBIK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KEKNEPGMBBM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public APNKEMDAMBG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xF0FD10", Offset = "0xF0EB10", VA = "0x180F0FD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3CE62F0", Offset = "0x3CE50F0", VA = "0x183CE62F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public KEKNEPGMBBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x37E3E60", Offset = "0x37E2C60", VA = "0x1837E3E60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5940", Offset = "0x3CE4740", VA = "0x183CE5940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5310", Offset = "0x3CE4110", VA = "0x183CE5310")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5400", Offset = "0x3CE4200", VA = "0x183CE5400")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6250", Offset = "0x3CE5050", VA = "0x183CE6250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FCBKIFIOJEL<TKey, TValue> KDJELKNMBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IDictionary<TKey, TValue> IBLOLFOJOJO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3928230", Offset = "0x3927030", VA = "0x183928230", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool LIIHEFGBOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x39283F0", Offset = "0x39271F0", VA = "0x1839283F0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3928650", Offset = "0x3927450", VA = "0x183928650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> LIOGCBENAED
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3928430", Offset = "0x3927230", VA = "0x183928430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> EDOJOOOMFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3928530", Offset = "0x3927330", VA = "0x183928530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3928180", Offset = "0x3926F80", VA = "0x183928180")]
	public APNKEMDAMBG(FCBKIFIOJEL<TKey, TValue> KDJELKNMBLL, [Optional] IDictionary<TKey, TValue>? IBLOLFOJOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3926000", Offset = "0x3924E00", VA = "0x183926000", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3926600", Offset = "0x3925400", VA = "0x183926600")]
	public void ENPHCNNBGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3925C90", Offset = "0x3924A90", VA = "0x183925C90", Slot = "9")]
	public void Add(TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3926C40", Offset = "0x3925A40", VA = "0x183926C40")]
	public void ODIGHOJKCKC(TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3926DD0", Offset = "0x3925BD0", VA = "0x183926DD0")]
	public void OINKIPLMEON(TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3927030", Offset = "0x3925E30", VA = "0x183927030")]
	public void PBJIDMLIIPF(TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3926A30", Offset = "0x3925830", VA = "0x183926A30")]
	public void MGEHGPHNPMC(TKey OBPLDLNDJLE, TValue DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x39277F0", Offset = "0x39265F0", VA = "0x1839277F0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x39279C0", Offset = "0x39267C0", VA = "0x1839279C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3927D20", Offset = "0x3926B20", VA = "0x183927D20", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3926070", Offset = "0x3924E70", VA = "0x183926070", Slot = "8")]
	public bool ContainsKey(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3926770", Offset = "0x3925570", VA = "0x183926770")]
	public bool IJJFKDEJNJO(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3926890", Offset = "0x3925690", VA = "0x183926890")]
	public bool KEHNCMCCEEB(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3927630", Offset = "0x3926430", VA = "0x183927630", Slot = "10")]
	public bool Remove(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3927FE0", Offset = "0x3926DE0", VA = "0x183927FE0", Slot = "11")]
	public bool TryGetValue(TKey OBPLDLNDJLE, [Out] TValue DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39263D0", Offset = "0x39251D0", VA = "0x1839263D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] OKLABKDOFAF, int GKAEDFLMLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3927EE0", Offset = "0x3926CE0", VA = "0x183927EE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x39266E0", Offset = "0x39254E0", VA = "0x1839266E0", Slot = "19")]
	[IteratorStateMachine(typeof(APNKEMDAMBG<, >.KEKNEPGMBBM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3926B20", Offset = "0x3925920", VA = "0x183926B20", Slot = "21")]
	public bool NPLOBFFMNPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x39273A0", Offset = "0x39261A0", VA = "0x1839273A0")]
	private TValue PDMBJDHGCJE(TKey OBPLDLNDJLE)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface BMLACNEJBIK
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPLOBFFMNPI();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface FCBKIFIOJEL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BMLACNEJBIK
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class EMHJELMEIHN<TKey, TVal> : FCBKIFIOJEL<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, BMLACNEJBIK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int NKOBJGMJOCC(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate void LFLDNIOEBEC(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN, JHGAMDLBKEH JNFKLJKGAMI);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BMKCFCHGKEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey AAPIPDGMADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal ACOGNAIJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9592C0", Offset = "0x9580C0", VA = "0x1809592C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int EDOPLBKMBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7EF360", Offset = "0x7EE160", VA = "0x1807EF360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7EEE30", Offset = "0x7EDC30", VA = "0x1807EEE30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset BEMGLMKHNBO
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAD5E00", Offset = "0xAD4C00", VA = "0x180AD5E00")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x13689C0", Offset = "0x13677C0", VA = "0x1813689C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4883770", Offset = "0x4882570", VA = "0x184883770")]
		public BMKCFCHGKEE(TKey OBPLDLNDJLE, TVal FLOENDBPFOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JHHLHELGMCL : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public EMHJELMEIHN<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LinkedList<BMKCFCHGKEE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xF0FD10", Offset = "0xF0EB10", VA = "0x180F0FD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x37E7130", Offset = "0x37E5F30", VA = "0x1837E7130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public JHHLHELGMCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x37DEC10", Offset = "0x37DDA10", VA = "0x1837DEC10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C350", Offset = "0x3C2B150", VA = "0x183C2C350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B3B0", Offset = "0x3C2A1B0", VA = "0x183C2B3B0")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C2C760", Offset = "0x3C2B560", VA = "0x183C2C760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public const int INELCLDCBAI = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<TKey, LinkedListNode<BMKCFCHGKEE>> MHKDBGMDAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LinkedList<BMKCFCHGKEE> ONGHBGGEFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NKOBJGMJOCC? IMDIDOHPBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly TimeSpan OHPLBPNPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly LFLDNIOEBEC? OIMNNLNFJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IOMHEJBCNDP GEGIPJPNAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool CLBCLIDFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly List<TKey> JEEBCIGPMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly List<TVal> KIGBDJKPGCO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int IIDNAHMDCFB
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF240", Offset = "0x7BE040", VA = "0x1807BF240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int OPOIJPDMGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDC0", Offset = "0x9ADBC0", VA = "0x1809AEDC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE740", Offset = "0x9AD540", VA = "0x1809AE740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x34ADA00", Offset = "0x34AC800", VA = "0x1834ADA00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int FLPOLBMBKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x34A71C0", Offset = "0x34A5FC0", VA = "0x1834A71C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> EDOJOOOMFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x34ADBA0", Offset = "0x34AC9A0", VA = "0x1834ADBA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.IPFHDINODEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x34AA350", Offset = "0x34A9150", VA = "0x1834AA350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LIIHEFGBOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x34ADA80", Offset = "0x34AC880", VA = "0x1834ADA80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x34ADCB0", Offset = "0x34ACAB0", VA = "0x1834ADCB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x34A8FE0", Offset = "0x34A7DE0", VA = "0x1834A8FE0")]
	private bool NGMHBOHJHNL(int GIOLCDOMFDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34A5F10", Offset = "0x34A4D10", VA = "0x1834A5F10")]
	private void LKMPEEOMGLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34ABC60", Offset = "0x34AAA60", VA = "0x1834ABC60")]
	public EMHJELMEIHN(int GIOLCDOMFDF, [Optional] NKOBJGMJOCC? IMDIDOHPBJN, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] LFLDNIOEBEC? OIMNNLNFJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x34AB760", Offset = "0x34AA560", VA = "0x1834AB760")]
	public EMHJELMEIHN(TimeSpan OHPLBPNPMHH, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] LFLDNIOEBEC? OIMNNLNFJDA, [Optional] IOMHEJBCNDP? GEGIPJPNAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x34AB320", Offset = "0x34AA120", VA = "0x1834AB320")]
	public EMHJELMEIHN(int GIOLCDOMFDF, TimeSpan OHPLBPNPMHH, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] LFLDNIOEBEC? OIMNNLNFJDA, [Optional] IOMHEJBCNDP? GEGIPJPNAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x34ACA70", Offset = "0x34AB870", VA = "0x1834ACA70")]
	public EMHJELMEIHN(int GIOLCDOMFDF, NKOBJGMJOCC? IMDIDOHPBJN, TimeSpan OHPLBPNPMHH, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] LFLDNIOEBEC? OIMNNLNFJDA, [Optional] IOMHEJBCNDP? GEGIPJPNAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x34A9030", Offset = "0x34A7E30", VA = "0x1834A9030", Slot = "21")]
	public bool NPLOBFFMNPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x34A49E0", Offset = "0x34A37E0", VA = "0x1834A49E0", Slot = "22")]
	public bool KGOGAJCNODG(int CGDBKIJPKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x34A1E80", Offset = "0x34A0C80", VA = "0x1834A1E80")]
	private bool JGPONKKKDGF(int CGDBKIJPKOF, JHGAMDLBKEH JNFKLJKGAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x34A5100", Offset = "0x34A3F00", VA = "0x1834A5100")]
	public void KNPAMBFMNAD(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x349C540", Offset = "0x349B340", VA = "0x18349C540", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x349C400", Offset = "0x349B200", VA = "0x18349C400", Slot = "9")]
	public void Add(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x349C810", Offset = "0x349B610", VA = "0x18349C810", Slot = "8")]
	public bool ContainsKey(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x34A98C0", Offset = "0x34A86C0", VA = "0x1834A98C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34A9160", Offset = "0x34A7F60", VA = "0x1834A9160", Slot = "10")]
	public bool Remove(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34A9FE0", Offset = "0x34A8DE0", VA = "0x1834A9FE0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x34A6DC0", Offset = "0x34A5BC0", VA = "0x1834A6DC0")]
	private bool MPPBNJCBNPJ(TKey OBPLDLNDJLE, [Out] TVal DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x349E670", Offset = "0x349D470", VA = "0x18349E670")]
	private TVal DJGCEJBDGHO(TKey KPFCBAHENED)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x34AAA60", Offset = "0x34A9860", VA = "0x1834AAA60", Slot = "11")]
	public bool TryGetValue(TKey KPFCBAHENED, [Out] TVal DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x349C570", Offset = "0x349B370", VA = "0x18349C570", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x349DC10", Offset = "0x349CA10", VA = "0x18349DC10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OKLABKDOFAF, int GKAEDFLMLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x349B140", Offset = "0x3499F40", VA = "0x18349B140")]
	private void AABNDAOKBAI(TKey OBPLDLNDJLE, TVal FLOENDBPFOD, JHGAMDLBKEH JNFKLJKGAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34A5DB0", Offset = "0x34A4BB0", VA = "0x1834A5DB0")]
	private bool KPLLPKLPIIN(BMKCFCHGKEE IJHLDIAPDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x34A8940", Offset = "0x34A7740", VA = "0x1834A8940")]
	private void NGFJNFFJNHH(LinkedListNode<BMKCFCHGKEE> KJKMAJHOIAI, TVal BHCBINIFLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x349F8F0", Offset = "0x349E6F0", VA = "0x18349F8F0")]
	private void HJOOJPBLNDO(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x34A36C0", Offset = "0x34A24C0", VA = "0x1834A36C0")]
	private void JOOLMBGCLBG(BMKCFCHGKEE IJHLDIAPDEP, TVal BHCBINIFLAJ, int BHALBPKOEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x349EE70", Offset = "0x349DC70", VA = "0x18349EE70", Slot = "19")]
	[IteratorStateMachine(typeof(EMHJELMEIHN<, >.JHHLHELGMCL))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x34AA380", Offset = "0x34A9180", VA = "0x1834AA380", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum JHGAMDLBKEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	RemovedViaClear
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NDEHLJNPJML<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly TKey LNAIKCFJCFA;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x40144B0", Offset = "0x40132B0", VA = "0x1840144B0")]
	public NDEHLJNPJML(TKey KFOIEDPOHBK, Exception KDFDHMLGGAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HFIDEHOPJIF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5684760", Offset = "0x5683560", VA = "0x185684760")]
	public HFIDEHOPJIF(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class CGIJGMAGLPL<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class MMPGMMACFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CGIJGMAGLPL<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MMPGMMACFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3FB1DF0", Offset = "0x3FB0BF0", VA = "0x183FB1DF0")]
		internal Task<TResource> FIAHHLBNDAH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct OABFMJEJMOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CGIJGMAGLPL<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x40FC710", Offset = "0x40FB510", VA = "0x1840FC710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x40FD010", Offset = "0x40FBE10", VA = "0x1840FD010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct NKGOOFIKMOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4034430", Offset = "0x4033230", VA = "0x184034430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4034E20", Offset = "0x4033C20", VA = "0x184034E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly MKHMCMICFNN<TId, Task<TResource>> NEJNHEAENJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ODDFBPNLIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? BOIIAJFFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Action<TResource>? CMNCDNAPCGB;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4D21470", Offset = "0x4D20270", VA = "0x184D21470")]
	public CGIJGMAGLPL(int PMLCCAFBPDO = 0, [Optional] IEqualityComparer<TId>? HFIDAMLJFEO, [Optional] Func<TId, CancellationToken, Task<TResource>>? PDKFAPDDAHJ, [Optional] Action<TResource>? BFBJJADOKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4D20470", Offset = "0x4D1F270", VA = "0x184D20470")]
	public HFMDJFNGONB<Task<TResource>> CADCEJNBBBA(TId NLFEJIHGBIC, [Optional] Func<TId, CancellationToken, Task<TResource>>? PDKFAPDDAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4D20F80", Offset = "0x4D1FD80", VA = "0x184D20F80")]
	private void NIPEBFMDMLH(Task<TResource> JKCFEOGKFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4D20AF0", Offset = "0x4D1F8F0", VA = "0x184D20AF0")]
	[AsyncStateMachine(typeof(CGIJGMAGLPL<, >.OABFMJEJMOF))]
	private Task JFOBCLNGIGI(Task<TResource> JKCFEOGKFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4D21280", Offset = "0x4D20080", VA = "0x184D21280")]
	public void PIGLAFBMEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4D20880", Offset = "0x4D1F680", VA = "0x184D20880")]
	public MKHMCMICFNN<TId, Task<TResource>>.LAALIIJOAOL CNEJODDGPIM()
	{
		return default(MKHMCMICFNN<TId, Task<TResource>>.LAALIIJOAOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4D212B0", Offset = "0x4D200B0", VA = "0x184D212B0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4D212B0", Offset = "0x4D200B0", VA = "0x184D212B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4D20E50", Offset = "0x4D1FC50", VA = "0x184D20E50")]
	[AsyncStateMachine(typeof(CGIJGMAGLPL<, >.NKGOOFIKMOK))]
	[CompilerGenerated]
	internal static Task KJKKIABCPED(Task<TResource> JKCFEOGKFBB, CancellationTokenSource MMJAPDGAMND, Dictionary<Task<TResource>, CancellationTokenSource> KOEEHLNCCHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MKHMCMICFNN<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class HGHKPIIJIFA : IEquatable<HGHKPIIJIFA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TValue ACOGNAIJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int KPMAMBIMOLH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1CEDB50", Offset = "0x1CEC950", VA = "0x181CEDB50")]
		public HGHKPIIJIFA(TValue DIBNBLEEFNN, int ALACMBGAEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39C15F0", Offset = "0x39C03F0", VA = "0x1839C15F0", Slot = "4")]
		public bool Equals(HGHKPIIJIFA? GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39C1560", Offset = "0x39C0360", VA = "0x1839C1560", Slot = "0")]
		public override bool Equals(object? EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39C1670", Offset = "0x39C0470", VA = "0x1839C1670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct LAALIIJOAOL : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<TKey, HGHKPIIJIFA>.Enumerator BPOOJNNIAMC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3DA50C0", Offset = "0x3DA3EC0", VA = "0x183DA50C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3DA54C0", Offset = "0x3DA42C0", VA = "0x183DA54C0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3DA52E0", Offset = "0x3DA40E0", VA = "0x183DA52E0")]
		public LAALIIJOAOL(MKHMCMICFNN<TKey, TValue> BHHBJAICHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4C70", Offset = "0x3DA3A70", VA = "0x183DA4C70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4D30", Offset = "0x3DA3B30", VA = "0x183DA4D30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4E20", Offset = "0x3DA3C20", VA = "0x183DA4E20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CDALLKEFIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public MKHMCMICFNN<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HGHKPIIJIFA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CDALLKEFIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4C45620", Offset = "0x4C44420", VA = "0x184C45620")]
		internal void FIAHHLBNDAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, HGHKPIIJIFA> CENLLGKDDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Func<TKey, TValue>? KBNAFIOCPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Action<TValue>? BIGHOEFEDKM;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA95E0", Offset = "0x3FA83E0", VA = "0x183FA95E0")]
	public MKHMCMICFNN(int PMLCCAFBPDO = 0, [Optional] IEqualityComparer<TKey>? GLAMLAFOEAH, [Optional] Func<TKey, TValue>? OGHIKAFLHBC, [Optional] Action<TValue>? AHDALFOBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA85A0", Offset = "0x3FA73A0", VA = "0x183FA85A0")]
	public HFMDJFNGONB<TValue> CADCEJNBBBA(TKey OBPLDLNDJLE, [Optional] Func<TKey, TValue>? HGJPAFCBHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8DB0", Offset = "0x3FA7BB0", VA = "0x183FA8DB0")]
	private void IHAHIMEKHEN(TKey OBPLDLNDJLE, HGHKPIIJIFA KENJEBGAJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9250", Offset = "0x3FA8050", VA = "0x183FA9250")]
	public void PIGLAFBMEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA8BA0", Offset = "0x3FA79A0", VA = "0x183FA8BA0")]
	public LAALIIJOAOL CNEJODDGPIM()
	{
		return default(LAALIIJOAOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9420", Offset = "0x3FA8220", VA = "0x183FA9420", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3FA9420", Offset = "0x3FA8220", VA = "0x183FA9420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
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
