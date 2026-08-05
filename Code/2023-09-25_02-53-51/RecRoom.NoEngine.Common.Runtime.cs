using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D4CFF0", Offset = "0x5D4C3F0", VA = "0x185D4CFF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78E340", Offset = "0x78D740", VA = "0x18078E340")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class KAMKPIAKLIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B980", Offset = "0x5D4AD80", VA = "0x185D4B980")]
	public KAMKPIAKLIN(bool BGFMECGGPMC, string HKMGEEFOPAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CLHLIANFICP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> LHOGPKACDJA(CancellationToken OMFABMCIOAC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GMJIMNIDFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CLHLIANFICP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public LHOGPKACDJA taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x34A0720", Offset = "0x349FB20", VA = "0x1834A0720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34A16B0", Offset = "0x34A0AB0", VA = "0x1834A16B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource HFJACFBDGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? CIFFIPLFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? CEIAPBCEINA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A8E2E0", Offset = "0x4A8D6E0", VA = "0x184A8E2E0")]
	[AsyncStateMachine(typeof(CLHLIANFICP<>.GMJIMNIDFCO))]
	public Task<TResult> HCEPMAOJDJF(LHOGPKACDJA FFCBHCFEDBB, [Optional] CancellationToken OMFABMCIOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A8E270", Offset = "0x4A8D670", VA = "0x184A8E270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A8E420", Offset = "0x4A8D820", VA = "0x184A8E420")]
	public CLHLIANFICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NJFPNIBAMOK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> MDLCFIPPFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T OFPAGNFLHNE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF7D0", Offset = "0x3BDEBD0", VA = "0x183BDF7D0")]
	public NJFPNIBAMOK([In] T LPCGJALKADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF090", Offset = "0x3BDE490", VA = "0x183BDF090", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF290", Offset = "0x3BDE690", VA = "0x183BDF290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF660", Offset = "0x3BDEA60", VA = "0x183BDF660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class DEAGIIHFIKO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	public DEAGIIHFIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class LANJOPGFCOK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	public LANJOPGFCOK(string COGPFIAMNFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MONBEJPMKAH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2484870", Offset = "0x2483C70", VA = "0x182484870")]
	public static NAOBDIENFNN ICHNMNJDLHB<T>()
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2484AC0", Offset = "0x2483EC0", VA = "0x182484AC0")]
	public static NAOBDIENFNN PNFGIEAGKOK<T>([CallerMemberName] string DKFEAPHKBMP = "") where T : notnull
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24847F0", Offset = "0x2483BF0", VA = "0x1824847F0")]
	public static NAOBDIENFNN ICHNMNJDLHB<T>(this T JMBKGKDJDLG) where T : notnull
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24846A0", Offset = "0x2483AA0", VA = "0x1824846A0")]
	public static NAOBDIENFNN FFKOOJBNPPI<T>(this T JMBKGKDJDLG, [CallerMemberName] string DKFEAPHKBMP = "") where T : notnull
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2484A20", Offset = "0x2483E20", VA = "0x182484A20")]
	public static NAOBDIENFNN PNFGIEAGKOK<T>(this T CLFMFOEGLFG, [CallerMemberName] string DKFEAPHKBMP = "") where T : notnull
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CE40", Offset = "0x5D4C240", VA = "0x185D4CE40")]
	public static NAOBDIENFNN PNFGIEAGKOK(string GOBJAMLAEIB, [CallerMemberName] string DKFEAPHKBMP = "")
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CDA0", Offset = "0x5D4C1A0", VA = "0x185D4CDA0")]
	public static string KFKGJADCCPK(this object CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DEAGIIHFIKO]
public delegate long NEMGLHDOJAK();
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OCOJDBALDFI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IGCBIEIKEPN OHGIBCNNLGH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IGCBIEIKEPN PBBLJGOHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D200", Offset = "0x5D4C600", VA = "0x185D4D200")]
		get
		{
			return default(IGCBIEIKEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KCKNOPJBFCK ICJEHLEDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D1B0", Offset = "0x5D4C5B0", VA = "0x185D4D1B0")]
		get
		{
			return default(KCKNOPJBFCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KLKKFBIEGEM ALHOGPDLHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D610", Offset = "0x5D4CA10", VA = "0x185D4D610")]
		get
		{
			return default(KLKKFBIEGEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D2F0", Offset = "0x5D4C6F0", VA = "0x185D4D2F0")]
	public static void GAOJOOECCDK([In] IGCBIEIKEPN IHMJBIPKBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D540", Offset = "0x5D4C940", VA = "0x185D4D540")]
	public static void IJCNCIMJJJN(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D0E0", Offset = "0x5D4C4E0", VA = "0x185D4D0E0")]
	public static void DBDIOOJNOCJ(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25066C0", Offset = "0x2505AC0", VA = "0x1825066C0")]
	public static void DBDIOOJNOCJ<T>(T LIFDGOACBCI, LMAEMBFPLPI<T> LMJAPBNMKLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D6E0", Offset = "0x5D4CAE0", VA = "0x185D4D6E0")]
	public static void KHOPFOOFEEJ(Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D660", Offset = "0x5D4CA60", VA = "0x185D4D660")]
	public static string KFKGJADCCPK(object IBBNLILJNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D070", Offset = "0x5D4C470", VA = "0x185D4D070")]
	public static long AJGBMMMBKGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D250", Offset = "0x5D4C650", VA = "0x185D4D250")]
	public static bool FLMKJLBDMLG(bool GIMEOEFLEBE, string LMJAPBNMKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D470", Offset = "0x5D4C870", VA = "0x185D4D470")]
	public static double GBEOBECKFHM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IGCBIEIKEPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KCKNOPJBFCK ICJEHLEDHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KLKKFBIEGEM ALHOGPDLHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly LKGGIMFAHKB NEBEHPCAECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly NEMGLHDOJAK IKCCDGIHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly EPMKHGNABGN BENLMBOMJKL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly LKGGIMFAHKB HMCGAOJNBDK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly NEMGLHDOJAK EHAJKJAIAGG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EPMKHGNABGN CHAIHCJEBKH;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IGCBIEIKEPN KLACMHEBBPG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4B1C0", Offset = "0x5D4A5C0", VA = "0x185D4B1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B8E0", Offset = "0x5D4ACE0", VA = "0x185D4B8E0")]
	public IGCBIEIKEPN([In] KCKNOPJBFCK DECOGCMNKDJ, [In] KLKKFBIEGEM JFFADKIGGJL, LKGGIMFAHKB NHOLDOIFOPE, NEMGLHDOJAK JLBNMMLFOLP, EPMKHGNABGN OPGOELEEPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B080", Offset = "0x5D4A480", VA = "0x185D4B080")]
	private static string BAAFGBELANL(object IBBNLILJNEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220")]
	private static long AANGFOOIEMN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	private static string PCHNJCGFDME(string IDFLCGGMPNK, string? MOIJJCCLOOB, bool DNCECIPIOGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4B0C0", Offset = "0x5D4A4C0", VA = "0x185D4B0C0")]
	private static IGCBIEIKEPN DPCOJODPHFC()
	{
		return default(IGCBIEIKEPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CPLLAGIILJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ENNBNIOMBHB([In] T KEEHOGPOIFD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void FGHMIPEJKOI<T>([In] T LIFDGOACBCI);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DAKFDNIOIKB<T> : IEquatable<DAKFDNIOIKB<T>>, CPLLAGIILJJ<DAKFDNIOIKB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T OFPAGNFLHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int ICOODGEKGMA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1C2A140", Offset = "0x1C29540", VA = "0x181C2A140")]
	public DAKFDNIOIKB([In] T LPCGJALKADL, int JPEMHHILGGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4CD75D0", Offset = "0x4CD69D0", VA = "0x184CD75D0")]
	public static bool HCMKGGFOPFL([In] DAKFDNIOIKB<T> AHKCLAHHIPP, [In] DAKFDNIOIKB<T> MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3465A00", Offset = "0x3464E00", VA = "0x183465A00", Slot = "4")]
	public bool Equals(DAKFDNIOIKB<T> KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3772810", Offset = "0x3771C10", VA = "0x183772810", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7440", Offset = "0x4CD6840", VA = "0x184CD7440")]
	public bool ENNBNIOMBHB([In] DAKFDNIOIKB<T> KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4CD74D0", Offset = "0x4CD68D0", VA = "0x184CD74D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7AA0", Offset = "0x4CD6EA0", VA = "0x184CD7AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7890", Offset = "0x4CD6C90", VA = "0x184CD7890")]
	public void MJDAIICEPID([Out] T LPCGJALKADL, [Out] int JPEMHHILGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7790", Offset = "0x4CD6B90", VA = "0x184CD7790")]
	public (T, int) JKOBGGICFPH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4CD7A50", Offset = "0x4CD6E50", VA = "0x184CD7A50", Slot = "5")]
	private bool MJNIJLHPJLP([In] DAKFDNIOIKB<T> KEEHOGPOIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AHIONGFDFHJ
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29E9280", Offset = "0x29E8680", VA = "0x1829E9280")]
	public static DAKFDNIOIKB<T> CLFIPFKIGEN<T>([In] T LPCGJALKADL, int JPEMHHILGGG) where T : notnull
	{
		return default(DAKFDNIOIKB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ACLHDGIPDID
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29E6C60", Offset = "0x29E6060", VA = "0x1829E6C60")]
	public static bool ENNBNIOMBHB<T, U>([In] T CLFMFOEGLFG, [In] U IBBNLILJNEB) where T : notnull, CPLLAGIILJJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate TResult JJPGPPHEIFO<T, out TResult>([In] T LIFDGOACBCI);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult EMCGDHLEJCI<T1, T2, out TResult>([In] T1 EJAKMEJJEMG, [In] T2 KKNBFGJHBEO);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MAPANNBJLNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan MGIBLDJODAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? BPEKHKKEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAOPEKBBIFI();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPJDOHCOOKG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECBAIKIJCNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KCKNOPJBFCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly ANIPGCFLKLI GBLHDJOBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly GEGFINPHDOK NLNIKBFPPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ANIPGCFLKLI OLPAKECAJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly GEGFINPHDOK CDKKCIHMMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly ANIPGCFLKLI GMFNEBNELED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly GEGFINPHDOK BGOEOPFNPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly CJOCPKOEJNF BAMEJJFMGII;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly ANIPGCFLKLI ECHEGCJEEJC;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly GEGFINPHDOK PBBBGBDPEJP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly ANIPGCFLKLI GBECJBPBILJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly GEGFINPHDOK KMMALFGODJD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly ANIPGCFLKLI DGBDBAPONAM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GEGFINPHDOK MGCCILICGOH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly CJOCPKOEJNF BMGEPNIDIHD;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KCKNOPJBFCK KLACMHEBBPG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ANIPGCFLKLI HGADKIKKHBE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4BCE0", Offset = "0x5D4B0E0", VA = "0x185D4BCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8583C0", Offset = "0x8577C0", VA = "0x1808583C0")]
	public KCKNOPJBFCK(ANIPGCFLKLI LKGNNJCHIFF, GEGFINPHDOK AJKIIAPLBOG, ANIPGCFLKLI KJLHAAAOOKH, GEGFINPHDOK FMGEIOPJIJH, ANIPGCFLKLI EIDCKJBHHIM, GEGFINPHDOK GPKPGIJNKNC, CJOCPKOEJNF HHMMNLBEONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	private static bool FIOJDLFPPIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void OGDPHCBCBJG(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	private static bool KHOJPEMFFIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void KKJDNNJFACK(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280")]
	private static bool CPHICDEPMLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void IBEHGPPEMPJ(string LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void JHLDAPIPJAJ(Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BBA0", Offset = "0x5D4AFA0", VA = "0x185D4BBA0")]
	private static KCKNOPJBFCK DPCOJODPHFC()
	{
		return default(KCKNOPJBFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0")]
	private static bool LEPCAFHIEMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BFB0", Offset = "0x5D4B3B0", VA = "0x185D4BFB0")]
	public void IJCNCIMJJJN(object LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BB30", Offset = "0x5D4AF30", VA = "0x185D4BB30")]
	public void DBDIOOJNOCJ(object LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA670", Offset = "0x1FD9A70", VA = "0x181FDA670")]
	public void KHOPFOOFEEJ(Exception FLMBJDOBLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BA50", Offset = "0x5D4AE50", VA = "0x185D4BA50")]
	public void DBDIOOJNOCJ(KDFBOCNDJNO LMJAPBNMKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x242C1A0", Offset = "0x242B5A0", VA = "0x18242C1A0")]
	public void DBDIOOJNOCJ<T>(T LIFDGOACBCI, LMAEMBFPLPI<T> LMJAPBNMKLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x242C260", Offset = "0x242B660", VA = "0x18242C260")]
	public void IJCNCIMJJJN<T>([In] T LIFDGOACBCI, AFLEPDPCKHE<T> LMJAPBNMKLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4BEE0", Offset = "0x5D4B2E0", VA = "0x185D4BEE0")]
	public bool FLMKJLBDMLG(bool GIMEOEFLEBE, string LMJAPBNMKLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct NAOBDIENFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string OFPAGNFLHNE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3110", Offset = "0x7D2510", VA = "0x1807D3110")]
	public NAOBDIENFNN(string LPCGJALKADL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00")]
	public static string DLNOOKJDMMJ([In] NAOBDIENFNN CLFMFOEGLFG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1299AB0", Offset = "0x1298EB0", VA = "0x181299AB0")]
	public static NAOBDIENFNN DLNOOKJDMMJ(string KEEHOGPOIFD)
	{
		return default(NAOBDIENFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CFA0", Offset = "0x5D4C3A0", VA = "0x185D4CFA0")]
	public string KKCGBDJCCPA(string OMJJJMAIGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CEC0", Offset = "0x5D4C2C0", VA = "0x185D4CEC0")]
	public string EDCODCFGENM(object OMDOMKGMGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct EOKBOBHHEEM : IEquatable<EOKBOBHHEEM>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "4")]
	public bool Equals(EOKBOBHHEEM KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D49EE0", Offset = "0x5D492E0", VA = "0x185D49EE0", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D49F30", Offset = "0x5D49330", VA = "0x185D49F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D49F40", Offset = "0x5D49340", VA = "0x185D49F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HMIBGOFDLPO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GDILPCKNMEE<T> : IEquatable<GDILPCKNMEE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T OFPAGNFLHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool OOGKAADDJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OIPEPCJCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3466850", Offset = "0x3465C50", VA = "0x183466850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3466CA0", Offset = "0x34660A0", VA = "0x183466CA0")]
	public GDILPCKNMEE([In] T LPCGJALKADL, bool MMIJCIJDNPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34664E0", Offset = "0x34658E0", VA = "0x1834664E0")]
	public static bool HCMKGGFOPFL([In] GDILPCKNMEE<T> AHKCLAHHIPP, [In] GDILPCKNMEE<T> MHLPFPGAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3465A00", Offset = "0x3464E00", VA = "0x183465A00", Slot = "4")]
	public bool Equals(GDILPCKNMEE<T> KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3465D80", Offset = "0x3465180", VA = "0x183465D80", Slot = "0")]
	public override bool Equals(object KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3466310", Offset = "0x3465710", VA = "0x183466310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3466920", Offset = "0x3465D20", VA = "0x183466920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IFGBMLMKLDF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23F5EC0", Offset = "0x23F52C0", VA = "0x1823F5EC0")]
	public static GDILPCKNMEE<T> CIGELGELLGB<T>([In] T LPCGJALKADL) where T : notnull
	{
		return default(GDILPCKNMEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23F5FD0", Offset = "0x23F53D0", VA = "0x1823F5FD0")]
	public static GDILPCKNMEE<T?> KBBBKGOBAPF<T>()
	{
		return default(GDILPCKNMEE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23F6110", Offset = "0x23F5510", VA = "0x1823F6110")]
	public static bool NDOFHHLEOMC<T>([In] this GDILPCKNMEE<T> ELBJKDIKPFP, [Out][NotNullWhen(true)] T LPCGJALKADL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct KLKKFBIEGEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly HODIMDBAPKN NONOOBAPIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly BGBBJGHIAHO FHNHHJDJCGF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly HODIMDBAPKN LCEPCNGFHPM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly BGBBJGHIAHO JPJGOIIIFFN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KLKKFBIEGEM KLACMHEBBPG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NAKHODPHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D4C690", Offset = "0x5D4BA90", VA = "0x185D4C690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7CF750", Offset = "0x7CEB50", VA = "0x1807CF750")]
	public KLKKFBIEGEM(HODIMDBAPKN NPDHGHDIFMB, BGBBJGHIAHO CCOJFJNLLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void DPIICLKAGPP(string DKFEAPHKBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210")]
	private static void LCKLJGGJEON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C600", Offset = "0x5D4BA00", VA = "0x185D4C600")]
	private static KLKKFBIEGEM DPCOJODPHFC()
	{
		return default(KLKKFBIEGEM);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MKEBLLHAAAK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate bool OLLKHIOAJBD<in TInput, TResult>(TInput INCBMJFBGNP, [Out] TResult BBHPNPGLHIG);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BPOCIGCFKJI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public BPOCIGCFKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x46D0E10", Offset = "0x46D0210", VA = "0x1846D0E10")]
		internal void FLBEGEPJMGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HGHPMMLLEOM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public HGHPMMLLEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x351B3C0", Offset = "0x351A7C0", VA = "0x18351B3C0")]
		internal void GLNADOPHODF(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct BEONOLNJMBP<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public OLLKHIOAJBD<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4499E20", Offset = "0x4499220", VA = "0x184499E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x449A510", Offset = "0x4499910", VA = "0x18449A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct GBLJINKJLCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D49F70", Offset = "0x5D49370", VA = "0x185D49F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D4A170", Offset = "0x5D49570", VA = "0x185D4A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CA70", Offset = "0x5D4BE70", VA = "0x185D4CA70")]
	public static Task<TaskStatus> OIPAMHCAIDN(this Task CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x24804C0", Offset = "0x247F8C0", VA = "0x1824804C0")]
	public static Task<T> CAOOFIBCBMO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CB60", Offset = "0x5D4BF60", VA = "0x185D4CB60")]
	public static Task LHNKCPFEPBE(this Task DJNEDNIILKC, CancellationToken IBLOMPOENGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2481D80", Offset = "0x2481180", VA = "0x182481D80")]
	public static Task<TResult> LHNKCPFEPBE<TResult>(this Task<TResult> DJNEDNIILKC, CancellationToken IBLOMPOENGH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x24827A0", Offset = "0x2481BA0", VA = "0x1824827A0")]
	public static TaskCompletionSource<TResult> LHNKCPFEPBE<TResult>(this TaskCompletionSource<TResult> BPFHLDFGALC, CancellationToken IBLOMPOENGH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2480610", Offset = "0x247FA10", VA = "0x182480610")]
	[AsyncStateMachine(typeof(BEONOLNJMBP<, >))]
	public static Task<List<TResult>> HAOOFEENHKA<TResult, TInput>(this Task<List<TInput>> DJNEDNIILKC, OLLKHIOAJBD<TInput, TResult> EOOOMFHGAPL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CA70", Offset = "0x5D4BE70", VA = "0x185D4CA70")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GBLJINKJLCK))]
	internal static Task<TaskStatus> IGCDMIKKFIG(Task AKFOFPGPKID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KEIEGGJKFFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x78D520", Offset = "0x78C920", VA = "0x18078D520")]
	public KEIEGGJKFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DAMFAPPDBNO : OHKOACDHKPC
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OHKOACDHKPC OMCMBELJBID;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime PDIBMDLBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D495A0", Offset = "0x5D489A0", VA = "0x185D495A0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	public DAMFAPPDBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface OHKOACDHKPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime PDIBMDLBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DIILNEIBIJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long NELBKNGCBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D497C0", Offset = "0x5D48BC0", VA = "0x185D497C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long OGCKCICGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D49A40", Offset = "0x5D48E40", VA = "0x185D49A40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double ILAHCADBJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D49AE0", Offset = "0x5D48EE0", VA = "0x185D49AE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double JFHBDEKEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D49A90", Offset = "0x5D48E90", VA = "0x185D49A90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double ICFLJJMKMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D49810", Offset = "0x5D48C10", VA = "0x185D49810")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double FODALNDNDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D498D0", Offset = "0x5D48CD0", VA = "0x185D498D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D49B30", Offset = "0x5D48F30", VA = "0x185D49B30")]
	public static double PLDMLLBIPNL(long KEALNHKNDBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D49920", Offset = "0x5D48D20", VA = "0x185D49920")]
	public static double LJOGMHHACPG(long KEALNHKNDBJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D499B0", Offset = "0x5D48DB0", VA = "0x185D499B0")]
	public static double MGENADDMAGB(double KAJPLDIHOFN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D49660", Offset = "0x5D48A60", VA = "0x185D49660")]
	public static long DDHBBGCJNKA(long OJILNLBEDDP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D498C0", Offset = "0x5D48CC0", VA = "0x185D498C0")]
	public static long KCDEMJPPHKO(long GHBNNGGJKFL, long PADCCBMJIOF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5D496F0", Offset = "0x5D48AF0", VA = "0x185D496F0")]
	public static double DNFIONKACCF(long GHBNNGGJKFL, long PADCCBMJIOF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D49860", Offset = "0x5D48C60", VA = "0x185D49860")]
	public static double IOPIAHJMGAH(long GHBNNGGJKFL, long PADCCBMJIOF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class CNAHINIJBDG : MAPANNBJLNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan ACMFHOHFMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer LHJMFKIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan HKLLMMFEENO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan MGIBLDJODAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D49110", Offset = "0x5D48510", VA = "0x185D49110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? BPEKHKKEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x764450", Offset = "0x763850", VA = "0x180764450", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x764460", Offset = "0x763860", VA = "0x180764460", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D49530", Offset = "0x5D48930", VA = "0x185D49530")]
	[Preserve]
	public CNAHINIJBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D492E0", Offset = "0x5D486E0", VA = "0x185D492E0")]
	public CNAHINIJBDG(TimeSpan HKLLMMFEENO, [Optional] Action? HNEEEMBPGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D48F40", Offset = "0x5D48340", VA = "0x185D48F40", Slot = "7")]
	public void BAOPEKBBIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D48FD0", Offset = "0x5D483D0", VA = "0x185D48FD0", Slot = "8")]
	public void CPJDOHCOOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D490E0", Offset = "0x5D484E0", VA = "0x185D490E0", Slot = "9")]
	public void ECBAIKIJCNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xA95F10", Offset = "0xA95310", VA = "0x180A95F10")]
	private void AFJIIIPKAFH(object JMBKGKDJDLG, ElapsedEventArgs BPGJNMLAOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D48EA0", Offset = "0x5D482A0", VA = "0x185D48EA0")]
	private static void AJJCGOMFFMO(TimeSpan NPLCBDFJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D49040", Offset = "0x5D48440", VA = "0x185D49040", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HMIBGOFDLPO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string LHGCAODEADM;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
	public HMIBGOFDLPO(string PJFLKEHKFGB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HLCCBDMJDNK : IEquatable<HLCCBDMJDNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint LGKHCMGPCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int KNLKDEGIPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float OMIKFCGOHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort FLACDLBBNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort GEOAJAEHJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short NDEKGNLCNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short OCLGOLMHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char HONKDEFODIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char JKMEOKOCBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte GEMAIBGHCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte BOENDLOEMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte LKCPPLDDOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte FKBMECFOAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool KPFBANJJHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool BCJBOHFNFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool NDIFGBINDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool BDNMKKOIMMB;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static HLCCBDMJDNK CIHIGCCEPBC(uint PBAOPJJFIIK)
	{
		return default(HLCCBDMJDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBD40E0", Offset = "0xBD34E0", VA = "0x180BD40E0")]
	public static HLCCBDMJDNK HIMLHDMPKCL(int OHDLEBCPCNC)
	{
		return default(HLCCBDMJDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4A280", Offset = "0x5D49680", VA = "0x185D4A280")]
	public static HLCCBDMJDNK NLLIJJFIDOO(float GODIMCGLJIL)
	{
		return default(HLCCBDMJDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D4A260", Offset = "0x5D49660", VA = "0x185D4A260")]
	public static HLCCBDMJDNK LJCNGNPFCIO(byte LANPKBLJGLC, byte GAIIMEIKMHM, byte IJBFIOCKDMF, byte JOEJKKMCFDB)
	{
		return default(HLCCBDMJDNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D4A260", Offset = "0x5D49660", VA = "0x185D4A260")]
	public static HLCCBDMJDNK JMOOJFIJMFK(bool HACMEFBNEJO, bool ANACBFONLCF, bool MOCKCLLAJAN, bool HBGMGBCNEJF)
	{
		return default(HLCCBDMJDNK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF90", Offset = "0x15EF390", VA = "0x1815EFF90")]
	public static bool HCMKGGFOPFL(HLCCBDMJDNK IOJNHOGOOGI, HLCCBDMJDNK IODCBCAEEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x15EFF70", Offset = "0x15EF370", VA = "0x1815EFF70", Slot = "4")]
	public bool Equals(HLCCBDMJDNK KEEHOGPOIFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D4A1E0", Offset = "0x5D495E0", VA = "0x185D4A1E0", Slot = "0")]
	public override bool Equals(object IBBNLILJNEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D2F50", Offset = "0x7D2350", VA = "0x1807D2F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D4A290", Offset = "0x5D49690", VA = "0x185D4A290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EMBJPIAJECK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong FIPFDPKCNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long GALBPNCDPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double IEOBOMEAGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint LBHPJAGPCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint AMCMJCKDPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int GIOAILINGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int LFMMANKBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float AHOFBJGJPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float FOBINGLAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort FLACDLBBNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort GEOAJAEHJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort CGHGJNINOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort POMKBLCMBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short NDEKGNLCNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short OCLGOLMHIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short GDEPOANOBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short BOBPBNFMOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char HONKDEFODIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char JKMEOKOCBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char HGKIGDLEKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char JHDFIJONBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte GEMAIBGHCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte BOENDLOEMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte LKCPPLDDOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte FKBMECFOAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte BFMAINBNNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte AFFBPGMCCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte HPJJFFMLJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte FNJEAPPEMAK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D49E90", Offset = "0x5D49290", VA = "0x185D49E90")]
	public static EMBJPIAJECK CLFIPFKIGEN(byte LANPKBLJGLC, byte GAIIMEIKMHM, byte IJBFIOCKDMF, byte JOEJKKMCFDB, byte JABFBLGCHDD, byte HMFLPEJJICM, byte LCEGNNJLIJI, byte EJGIEEAGDPK)
	{
		return default(EMBJPIAJECK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GILDPGDMBNO
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x23C7680", Offset = "0x23C6A80", VA = "0x1823C7680")]
	public static IEnumerable<T> BECAOBDLLJO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static T[] KIAPHDHIDBC<T>(params T[] ABNLDJPLMIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA09C60", Offset = "0xA09060", VA = "0x180A09C60")]
	public static IEnumerable<T> CHDOJJCICGP<T>(params T[] ABNLDJPLMIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x225A120", Offset = "0x2259520", VA = "0x18225A120")]
	public static HashSet<T> EMHBKCOPLJE<T>(params T[] ABNLDJPLMIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x23C76A0", Offset = "0x23C6AA0", VA = "0x1823C76A0")]
	public static KeyValuePair<TKey, TValue> GGAHENBKBFH<TKey, TValue>([In] TKey IHHOPACLNAK, [In] TValue LPCGJALKADL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x225A120", Offset = "0x2259520", VA = "0x18225A120")]
	public static List<T> DKOOCDMFKPL<T>(IEnumerable<T> COIJKGGMHJF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.All)]
public sealed class DDMJEPCLODL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string OJJPMHGDKNF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x78E300", Offset = "0x78D700", VA = "0x18078E300")]
	public DDMJEPCLODL(string IAJADCLDFFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PMMMPEHMICL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class KBDMHKBBPJK<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> OMCMBELJBID;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int ENJCEKMGBLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool DNCECCDBGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x37E0430", Offset = "0x37DF830", VA = "0x1837E0430", Slot = "4")]
		public bool Add(T IBHHDIJNMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "6")]
		public void IntersectWith(IEnumerable<T> KEEHOGPOIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x37E05D0", Offset = "0x37DF9D0", VA = "0x1837E05D0", Slot = "5")]
		public void UnionWith(IEnumerable<T> KEEHOGPOIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x37E0510", Offset = "0x37DF910", VA = "0x1837E0510", Slot = "9")]
		void ICollection<T>.Add(T IBHHDIJNMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "11")]
		public bool Contains(T IBHHDIJNMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
		public void CopyTo(T[] FOAJABBKLPB, int MHBLGNNCLAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "13")]
		public bool Remove(T IBHHDIJNMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x37E0490", Offset = "0x37DF890", VA = "0x1837E0490", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x303D890", Offset = "0x303CC90", VA = "0x18303D890", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public KBDMHKBBPJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F0F60", Offset = "0x9F0360", VA = "0x1809F0F60")]
	public static ISet<T> OJJIFAEFBOI<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DEAGIIHFIKO]
public delegate void HODIMDBAPKN(string DKFEAPHKBMP);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DEAGIIHFIKO]
public delegate void BGBBJGHIAHO();
[Cpp2IlInjected.Token(Token = "0x2000035")]
public delegate object AFLEPDPCKHE<T>([In] T LHPGBFGMEDK);
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object LMAEMBFPLPI<T>(T LHPGBFGMEDK);
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DEAGIIHFIKO]
public delegate string EPMKHGNABGN(string IDFLCGGMPNK, string? MOIJJCCLOOB, bool DNCECIPIOGC);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DEAGIIHFIKO]
public delegate void GEGFINPHDOK(string LMJAPBNMKLG);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[DEAGIIHFIKO]
public delegate void CJOCPKOEJNF(Exception FLMBJDOBLFE);
[Cpp2IlInjected.Token(Token = "0x200003A")]
public delegate object KDFBOCNDJNO();
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DEAGIIHFIKO]
public delegate bool ANIPGCFLKLI();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DEAGIIHFIKO]
public delegate string LKGGIMFAHKB(object IBBNLILJNEB);
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
