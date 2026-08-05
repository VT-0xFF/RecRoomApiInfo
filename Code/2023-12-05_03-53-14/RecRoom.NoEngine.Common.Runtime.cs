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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8FA40", Offset = "0x5E8EE40", VA = "0x185E8FA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BKALILCJAOO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E87A00", Offset = "0x5E86E00", VA = "0x185E87A00")]
	public BKALILCJAOO(bool PENKNBCPLMO, string BAELLAPOEPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DCIPEIDHLHE<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> EOANGGBFNFN(CancellationToken EANFAKGANNH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IOBAFGJEEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DCIPEIDHLHE<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EOANGGBFNFN taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x376AAD0", Offset = "0x3769ED0", VA = "0x18376AAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x376BB30", Offset = "0x376AF30", VA = "0x18376BB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource FNCADPJKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? NBEIJBNPONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? BFBHPHIJJMI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8AA0", Offset = "0x4DA7EA0", VA = "0x184DA8AA0")]
	[AsyncStateMachine(typeof(DCIPEIDHLHE<>.IOBAFGJEEME))]
	public Task<TResult> BHHNDFKNLPO(EOANGGBFNFN DGALDPCOEEA, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8BE0", Offset = "0x4DA7FE0", VA = "0x184DA8BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8C50", Offset = "0x4DA8050", VA = "0x184DA8C50")]
	public DCIPEIDHLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HBOBECNMIPO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> LAPCFMOLJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T ILNPCEAPFCH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35D1310", Offset = "0x35D0710", VA = "0x1835D1310")]
	public HBOBECNMIPO([In] T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35D0940", Offset = "0x35CFD40", VA = "0x1835D0940", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35D0E40", Offset = "0x35D0240", VA = "0x1835D0E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35D10B0", Offset = "0x35D04B0", VA = "0x1835D10B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AHAHGMDGDPC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E879D0", Offset = "0x5E86DD0", VA = "0x185E879D0")]
	public static void PJBKHGGLPLG(this CancellationTokenSource FNCADPJKBIK, bool HHHNLLKNKKG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ACJFMPOAABG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	public ACJFMPOAABG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FHEEPLFHPDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	public FHEEPLFHPDM(string ENHOINFADLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class HBNELDDEELJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	public HBNELDDEELJ(string ENHOINFADLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OCMCEHBEBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26534E0", Offset = "0x26528E0", VA = "0x1826534E0")]
	public static DOGKEGLKIOK ELNNKCHPFKH<T>()
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2653760", Offset = "0x2652B60", VA = "0x182653760")]
	public static DOGKEGLKIOK MBMIICOGBJB<T>([CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2653560", Offset = "0x2652960", VA = "0x182653560")]
	public static DOGKEGLKIOK ELNNKCHPFKH<T>(this T FPOCHAEKMIE) where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26535E0", Offset = "0x26529E0", VA = "0x1826535E0")]
	public static DOGKEGLKIOK LEDIONDMLEB<T>(this T FPOCHAEKMIE, [CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26537F0", Offset = "0x2652BF0", VA = "0x1826537F0")]
	public static DOGKEGLKIOK MBMIICOGBJB<T>(this T EAODMOEAJOC, [CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FB60", Offset = "0x5E8EF60", VA = "0x185E8FB60")]
	public static DOGKEGLKIOK MBMIICOGBJB(string FFDLICFJEMA, [CallerMemberName] string MDFAJJKMBAI = "")
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FAC0", Offset = "0x5E8EEC0", VA = "0x185E8FAC0")]
	public static string EBLPALPEAKB(this object EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ACJFMPOAABG]
public delegate long MIKFAPNCHCI();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EIOEFFDHENL
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static EFHJDLIMPFJ BMDGEKDPGPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EFHJDLIMPFJ OOPGDNCPGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E89D00", Offset = "0x5E89100", VA = "0x185E89D00")]
		get
		{
			return default(EFHJDLIMPFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PHNOPFPKEJK KCPLKIONLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A290", Offset = "0x5E89690", VA = "0x185E8A290")]
		get
		{
			return default(PHNOPFPKEJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GCACKNEBIBM DNDFJFNFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E89EF0", Offset = "0x5E892F0", VA = "0x185E89EF0")]
		get
		{
			return default(GCACKNEBIBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A110", Offset = "0x5E89510", VA = "0x185E8A110")]
	public static void PFNHEOJKGLA([In] EFHJDLIMPFJ IPGJILGHAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E89D50", Offset = "0x5E89150", VA = "0x185E89D50")]
	public static void FPKCBBOJANI(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E89E20", Offset = "0x5E89220", VA = "0x185E89E20")]
	public static void GJOFFIOBNOA(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23D40A0", Offset = "0x23D34A0", VA = "0x1823D40A0")]
	public static void GJOFFIOBNOA<T>(T GKKBCNLLJNC, HNPJGBELJGB<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B80", Offset = "0x5E88F80", VA = "0x185E89B80")]
	public static void BHHNAGAKLKD(Exception LLKMJCLKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A0B0", Offset = "0x5E894B0", VA = "0x185E8A0B0")]
	public static void OJJDBFIOFAP(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E89C20", Offset = "0x5E89020", VA = "0x185E89C20")]
	public static void CLIOEDEOLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E89C80", Offset = "0x5E89080", VA = "0x185E89C80")]
	public static string EBLPALPEAKB(object ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B10", Offset = "0x5E88F10", VA = "0x185E89B10")]
	public static long BAPDJDENGGB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F40", Offset = "0x5E89340", VA = "0x185E89F40")]
	public static bool HBPFCAMOKIP(bool KCKDDHKPEDN, string KCFFPPIEBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E89FE0", Offset = "0x5E893E0", VA = "0x185E89FE0")]
	public static double LDDLGNICFJA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EFHJDLIMPFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PHNOPFPKEJK KCPLKIONLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly GCACKNEBIBM DNDFJFNFJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly NKGJLFIFMDG IEJFMCGDKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly MIKFAPNCHCI AGDAEJAGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly FCIFHAHGINF FDNEIOANCIF;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NKGJLFIFMDG FFDJCHGPNAF;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly MIKFAPNCHCI EKGGHDGFIGD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FCIFHAHGINF GLBGLBFKNCO;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EFHJDLIMPFJ ANKGPMLLDAN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BKHFNIBKMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E89210", Offset = "0x5E88610", VA = "0x185E89210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E89A70", Offset = "0x5E88E70", VA = "0x185E89A70")]
	public EFHJDLIMPFJ([In] PHNOPFPKEJK GHAPCBLDCMN, [In] GCACKNEBIBM IEPKCIOPIGL, NKGJLFIFMDG LAMCPDFBCMM, MIKFAPNCHCI OJCNIFDCPNG, FCIFHAHGINF LCKLOBFNBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E89370", Offset = "0x5E88770", VA = "0x185E89370")]
	private static string HBMHBKIAJGL(object ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0")]
	private static long IOJLJJEDBGM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	private static string BMPIMFNBJNE(string DFBAIJNHOKM, string? NFLINLJKKJO, bool LFIJHJMOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E893B0", Offset = "0x5E887B0", VA = "0x185E893B0")]
	private static EFHJDLIMPFJ KGCFKMMNJNE()
	{
		return default(EFHJDLIMPFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FPPJMAPDJAH
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BOCDCJBGBAG LPMEJOJAOBL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BOCDCJBGBAG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EGFKDANLCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDDFCACIGNP();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JKICDAPJCBN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNABLLEBLCL([In] T LFMLAKDHEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void DOBMJMHCIFK<T>([In] T GKKBCNLLJNC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct OGHCEFCMLOD<T> : IEquatable<OGHCEFCMLOD<T>>, JKICDAPJCBN<OGHCEFCMLOD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T ILNPCEAPFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int FFCPNJCJDLL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD2F30", Offset = "0x1CD2330", VA = "0x181CD2F30")]
	public OGHCEFCMLOD([In] T NMENOOMOOJP, int DIENMHDGFGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC880", Offset = "0x3DFBC80", VA = "0x183DFC880")]
	public static bool FCHDBNDMOOD([In] OGHCEFCMLOD<T> OJKFAPKLEMA, [In] OGHCEFCMLOD<T> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC800", Offset = "0x3DFBC00", VA = "0x183DFC800", Slot = "4")]
	public bool Equals(OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x353BD40", Offset = "0x353B140", VA = "0x18353BD40", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD690", Offset = "0x3DFCA90", VA = "0x183DFD690")]
	public bool LNABLLEBLCL([In] OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD160", Offset = "0x3DFC560", VA = "0x183DFD160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD8B0", Offset = "0x3DFCCB0", VA = "0x183DFD8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC200", Offset = "0x3DFB600", VA = "0x183DFC200")]
	public void EJMICJJJLNI([Out] T NMENOOMOOJP, [Out] int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD310", Offset = "0x3DFC710", VA = "0x183DFD310")]
	public (T, int) LGPONIONLJB()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC060", Offset = "0x3DFB460", VA = "0x183DFC060", Slot = "5")]
	private bool DPGKNKBALCO([In] OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KFMDAMFILKP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2578360", Offset = "0x2577760", VA = "0x182578360")]
	public static OGHCEFCMLOD<T> PBDMNAJCIOP<T>([In] T NMENOOMOOJP, int DIENMHDGFGP) where T : notnull
	{
		return default(OGHCEFCMLOD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ECOHBEHPGJN
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x23B79A0", Offset = "0x23B6DA0", VA = "0x1823B79A0")]
	public static bool LNABLLEBLCL<T, U>([In] T EAODMOEAJOC, [In] U ECLCDMJMICA) where T : notnull, JKICDAPJCBN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult GALBELMNCGO<T, out TResult>([In] T GKKBCNLLJNC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult LDEPBGNEOGI<T1, T2, out TResult>([In] T1 OJEMGKLPCAA, [In] T2 ACCCGLECCHK);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NELOGBOAHAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan LHBDBNIAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Action? NPOFPFLGOII
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBHHAMKDCLO();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OOMIEHBAEDA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHNKAFMKLLA();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PHNOPFPKEJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly PBJHAONILNK OMGOMLNLAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly JKLMBMIKHNJ NPOFDFGPJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly PBJHAONILNK ONIPLBGMFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JKLMBMIKHNJ FFIADCOIAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly PBJHAONILNK PABBJMOMIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly JKLMBMIKHNJ LAMBHFFMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly ABGEJAEDDCM MBKLOLPJOPO;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly PBJHAONILNK NLKEBMJDAEH;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly JKLMBMIKHNJ OPLKHCOILGO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly PBJHAONILNK EJPCOGPOBNH;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JKLMBMIKHNJ NPAKDNJBGHA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly PBJHAONILNK COGJNNKEIII;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JKLMBMIKHNJ IGKPKEDPEBF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly ABGEJAEDDCM EEKHOJPMKKN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly PHNOPFPKEJK ANKGPMLLDAN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PBJHAONILNK CJLBKLCJPFD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BKHFNIBKMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E90020", Offset = "0x5E8F420", VA = "0x185E90020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8F3170", Offset = "0x8F2570", VA = "0x1808F3170")]
	public PHNOPFPKEJK(PBJHAONILNK AJAIFDBLLLG, JKLMBMIKHNJ CFCILPNFOCL, PBJHAONILNK EECBPPHPGDB, JKLMBMIKHNJ LBCJDBHGOOL, PBJHAONILNK BNLDKEJKMFL, JKLMBMIKHNJ OMHFCKIDJMP, ABGEJAEDDCM OJDNFFHOLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
	private static bool IGKKBPABNNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void JDKLHAAGCGN(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
	private static bool HOMBAIDJBKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void GOEEDMDKNEK(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0")]
	private static bool GJLHELMIEPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void AHGLEKBBANE(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void EPLCDGAKFCN(Exception LLKMJCLKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E904B0", Offset = "0x5E8F8B0", VA = "0x185E904B0")]
	private static PHNOPFPKEJK KGCFKMMNJNE()
	{
		return default(PHNOPFPKEJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310")]
	private static bool BDKMKOMNDHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90220", Offset = "0x5E8F620", VA = "0x185E90220")]
	public void FPKCBBOJANI(object KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90290", Offset = "0x5E8F690", VA = "0x185E90290")]
	public void GJOFFIOBNOA(object KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20DA570", Offset = "0x20D9970", VA = "0x1820DA570")]
	public void BHHNAGAKLKD(Exception LLKMJCLKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E90300", Offset = "0x5E8F700", VA = "0x185E90300")]
	public void GJOFFIOBNOA(CPNJBDPDKML KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x266E2C0", Offset = "0x266D6C0", VA = "0x18266E2C0")]
	public void GJOFFIOBNOA<T>(T GKKBCNLLJNC, HNPJGBELJGB<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x266E080", Offset = "0x266D480", VA = "0x18266E080")]
	public void FPKCBBOJANI<T>([In] T GKKBCNLLJNC, GFGJAEEIHPO<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E903E0", Offset = "0x5E8F7E0", VA = "0x185E903E0")]
	public bool HBPFCAMOKIP(bool KCKDDHKPEDN, string KCFFPPIEBHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct DOGKEGLKIOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string ILNPCEAPFCH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
	public DOGKEGLKIOK(string NMENOOMOOJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910")]
	public static string GOCBKKMEEIH([In] DOGKEGLKIOK EAODMOEAJOC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x13AF5E0", Offset = "0x13AE9E0", VA = "0x1813AF5E0")]
	public static DOGKEGLKIOK GOCBKKMEEIH(string LFMLAKDHEFO)
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E89080", Offset = "0x5E88480", VA = "0x185E89080")]
	public string LGCBMHJEDEJ(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E88FA0", Offset = "0x5E883A0", VA = "0x185E88FA0")]
	public string DCGGJJPBGGJ(object PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct CPIOBHNHOJN : IEquatable<CPIOBHNHOJN>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "4")]
	public bool Equals(CPIOBHNHOJN LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88070", Offset = "0x5E87470", VA = "0x185E88070", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E880C0", Offset = "0x5E874C0", VA = "0x185E880C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E880D0", Offset = "0x5E874D0", VA = "0x185E880D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[GBPNDICKPEO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PDAIFMGJHAK<T> : IEquatable<PDAIFMGJHAK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T ILNPCEAPFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool JDBJCCJPHCH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HBGOCNPKEKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3FF0", Offset = "0x3EC33F0", VA = "0x183EC3FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4410", Offset = "0x3EC3810", VA = "0x183EC4410")]
	public PDAIFMGJHAK([In] T NMENOOMOOJP, bool NFIFFLIIHGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3A50", Offset = "0x3EC2E50", VA = "0x183EC3A50")]
	public static bool FCHDBNDMOOD([In] PDAIFMGJHAK<T> OJKFAPKLEMA, [In] PDAIFMGJHAK<T> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC800", Offset = "0x3DFBC00", VA = "0x183DFC800", Slot = "4")]
	public bool Equals(PDAIFMGJHAK<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3380", Offset = "0x3EC2780", VA = "0x183EC3380", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3E10", Offset = "0x3EC3210", VA = "0x183EC3E10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4120", Offset = "0x3EC3520", VA = "0x183EC4120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class PMJNJGJDPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26718B0", Offset = "0x2670CB0", VA = "0x1826718B0")]
	public static PDAIFMGJHAK<T> LEJKCCHLPBK<T>([In] T NMENOOMOOJP) where T : notnull
	{
		return default(PDAIFMGJHAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26717A0", Offset = "0x2670BA0", VA = "0x1826717A0")]
	public static PDAIFMGJHAK<T?> IHCFLDDJNEN<T>()
	{
		return default(PDAIFMGJHAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2671660", Offset = "0x2670A60", VA = "0x182671660")]
	public static bool BJAFPBFMKIC<T>([In] this PDAIFMGJHAK<T> JNBONFJHIMB, [Out][NotNullWhen(true)] T NMENOOMOOJP) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct GCACKNEBIBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly IntPtr OJJDBFIOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IntPtr CLIOEDEOLAG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IntPtr MLBIPALKJLK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IntPtr NILBHPDAMPL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly GCACKNEBIBM ANKGPMLLDAN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BKHFNIBKMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B320", Offset = "0x5E8A720", VA = "0x185E8B320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82CAC0", Offset = "0x82BEC0", VA = "0x18082CAC0")]
	public GCACKNEBIBM(IntPtr ONMLCOAKEIA, IntPtr NELIKCGGBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void PKLLBAKHEEG(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	private static void PGOCANMECPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B400", Offset = "0x5E8A800", VA = "0x185E8B400")]
	private static GCACKNEBIBM KGCFKMMNJNE()
	{
		return default(GCACKNEBIBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct JKHIOOJCILI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IntPtr ANEMMAHLCHA;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
	private JKHIOOJCILI(IntPtr NELIKCGGBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D710", Offset = "0x5E8CB10", VA = "0x185E8D710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D720", Offset = "0x5E8CB20", VA = "0x185E8D720")]
	public static JKHIOOJCILI PBDMNAJCIOP(string MDFAJJKMBAI)
	{
		return default(JKHIOOJCILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9C40", Offset = "0x1CC9040", VA = "0x181CC9C40")]
	public static JKHIOOJCILI PBDMNAJCIOP([In] GCACKNEBIBM IEPKCIOPIGL, string MDFAJJKMBAI)
	{
		return default(JKHIOOJCILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA0D0", Offset = "0x1CC94D0", VA = "0x181CCA0D0")]
	public static JKHIOOJCILI PBDMNAJCIOP([In] GCACKNEBIBM IEPKCIOPIGL, Func<string> MDFAJJKMBAI)
	{
		return default(JKHIOOJCILI);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GNLMPGLAMPK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool NHIKHGAKLJE<in TInput, TResult>(TInput CGOLCEEBMBE, [Out] TResult KHFCBCPBAFG);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class PNLPEAPJHOG : FPPJMAPDJAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class NBCCJEMOBJL : BOCDCJBGBAG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly NBCCJEMOBJL NMGLFNHIICP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool EGFKDANLCGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x5E8F800", Offset = "0x5E8EC00", VA = "0x185E8F800", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E8F860", Offset = "0x5E8EC60", VA = "0x185E8F860", Slot = "6")]
			public void OnCompleted(Action LMOHMBJDPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			public void LDDFCACIGNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public NBCCJEMOBJL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PNLPEAPJHOG NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private PNLPEAPJHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E90BD0", Offset = "0x5E8FFD0", VA = "0x185E90BD0", Slot = "4")]
		public BOCDCJBGBAG LPMEJOJAOBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class JEPOIGDJFIP : FPPJMAPDJAH
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class FJLJENKPGJM : BOCDCJBGBAG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly FJLJENKPGJM NMGLFNHIICP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool EGFKDANLCGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E8A800", Offset = "0x5E89C00", VA = "0x185E8A800", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A820", Offset = "0x5E89C20", VA = "0x185E8A820", Slot = "6")]
			public void OnCompleted(Action LMOHMBJDPEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			public void LDDFCACIGNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public FJLJENKPGJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly JEPOIGDJFIP NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private JEPOIGDJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D640", Offset = "0x5E8CA40", VA = "0x185E8D640", Slot = "4")]
		public BOCDCJBGBAG LPMEJOJAOBL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PJHCFOKEFKE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PJHCFOKEFKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3574150", Offset = "0x3573550", VA = "0x183574150")]
		internal void BPGCDCJBEPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OJGLAPMKAML<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OJGLAPMKAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BD40", Offset = "0x3E0B140", VA = "0x183E0BD40")]
		internal void IKMFHLJAEHC(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KJOFHHOHDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E520", Offset = "0x5E8D920", VA = "0x185E8E520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PCFEAFFDAOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FC50", Offset = "0x5E8F050", VA = "0x185E8FC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BOOGEMMNLCK<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4588590", Offset = "0x4587990", VA = "0x184588590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4588700", Offset = "0x4587B00", VA = "0x184588700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NEFAFGFPCDP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D23420", Offset = "0x3D22820", VA = "0x183D23420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D23C90", Offset = "0x3D23090", VA = "0x183D23C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LPJAPDIPFIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F590", Offset = "0x5E8E990", VA = "0x185E8F590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F790", Offset = "0x5E8EB90", VA = "0x185E8F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class GLCKCOLIMDE<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GLCKCOLIMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3574150", Offset = "0x3573550", VA = "0x183574150")]
		internal void KEINDIBONOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3574190", Offset = "0x3573590", VA = "0x183574190")]
		internal void NGDBJICJNEB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DLNPPCBBNLO<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NHIKHGAKLJE<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4DE46F0", Offset = "0x4DE3AF0", VA = "0x184DE46F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4DE0", Offset = "0x4DE41E0", VA = "0x184DE4DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FKOOAHDFDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A8F0", Offset = "0x5E89CF0", VA = "0x185E8A8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B0E0", Offset = "0x5E8A4E0", VA = "0x185E8B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BMHGIDNBCCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E87AD0", Offset = "0x5E86ED0", VA = "0x185E87AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E88010", Offset = "0x5E87410", VA = "0x185E88010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HLNLCHLCIBH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3612790", Offset = "0x3611B90", VA = "0x183612790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x30EB230", Offset = "0x30EA630", VA = "0x1830EB230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DGABBAJMBGP<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4DCABC0", Offset = "0x4DC9FC0", VA = "0x184DCABC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3479870", Offset = "0x3478C70", VA = "0x183479870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct OLDAJKBMLCJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E186E0", Offset = "0x3E17AE0", VA = "0x183E186E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E18DE0", Offset = "0x3E181E0", VA = "0x183E18DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct LPFJEHLBDHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F1C0", Offset = "0x5E8E5C0", VA = "0x185E8F1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F530", Offset = "0x5E8E930", VA = "0x185E8F530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct HBKLPOIONBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CE80", Offset = "0x5E8C280", VA = "0x185E8CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D170", Offset = "0x5E8C570", VA = "0x185E8D170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EAIOIFJDELM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public EAIOIFJDELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E890D0", Offset = "0x5E884D0", VA = "0x185E890D0")]
		internal Task JKBDAHBIKNF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PENIHAJDLNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FD60", Offset = "0x5E8F160", VA = "0x185E8FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FFC0", Offset = "0x5E8F3C0", VA = "0x185E8FFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KGFANGLJBAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E2E0", Offset = "0x5E8D6E0", VA = "0x185E8E2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E4C0", Offset = "0x5E8D8C0", VA = "0x185E8E4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KCBNFEFGGLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D810", Offset = "0x5E8CC10", VA = "0x185E8D810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DB80", Offset = "0x5E8CF80", VA = "0x185E8DB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HGHCBFHIDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D1D0", Offset = "0x5E8C5D0", VA = "0x185E8D1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D4C0", Offset = "0x5E8C8C0", VA = "0x185E8D4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OJLCILCHDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public OJLCILCHDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FBE0", Offset = "0x5E8EFE0", VA = "0x185E8FBE0")]
		internal Task JDFEAGBIGII(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LDHHNOBLHLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E680", Offset = "0x5E8DA80", VA = "0x185E8E680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E8E0", Offset = "0x5E8DCE0", VA = "0x185E8E8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GBNDDBEBBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B140", Offset = "0x5E8A540", VA = "0x185E8B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B2C0", Offset = "0x5E8A6C0", VA = "0x185E8B2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BFAMIIMHBKB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4558F50", Offset = "0x4558350", VA = "0x184558F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x45591B0", Offset = "0x45585B0", VA = "0x1845591B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FCMFBHMJIKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A390", Offset = "0x5E89790", VA = "0x185E8A390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A7A0", Offset = "0x5E89BA0", VA = "0x185E8A7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static SynchronizationContext? KLDCAKCGEOI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TaskCompletionSource<CPIOBHNHOJN> IBKDDEACDJA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static Task OOAPOIJMLAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BE70", Offset = "0x5E8B270", VA = "0x185E8BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2526D40", Offset = "0x2526140", VA = "0x182526D40")]
	public static Task<T> NCCKFJKLDAN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C9A0", Offset = "0x5E8BDA0", VA = "0x185E8C9A0")]
	public static Task NJANKFKJMDK(this Task BPGIJHHDFCF, CancellationToken NOEAHPPKHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2528850", Offset = "0x2527C50", VA = "0x182528850")]
	public static Task<TResult> NJANKFKJMDK<TResult>(this Task<TResult> BPGIJHHDFCF, CancellationToken NOEAHPPKHNC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2529270", Offset = "0x2528670", VA = "0x182529270")]
	public static TaskCompletionSource<TResult> NJANKFKJMDK<TResult>(this TaskCompletionSource<TResult> KGCILHALMAA, CancellationToken NOEAHPPKHNC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CBE0", Offset = "0x5E8BFE0", VA = "0x185E8CBE0")]
	[AsyncStateMachine(typeof(KJOFHHOHDKC))]
	public static void PHCNNCBOCEF(this Task AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C6D0", Offset = "0x5E8BAD0", VA = "0x185E8C6D0")]
	[AsyncStateMachine(typeof(PCFEAFFDAOC))]
	public static void LNIKKCGDIOB(this Task AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25264D0", Offset = "0x25258D0", VA = "0x1825264D0")]
	[AsyncStateMachine(typeof(BOOGEMMNLCK<>))]
	public static Task AIMNJDNMGLK<TException>(this Task AINBOEMJDAE) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x25296D0", Offset = "0x2528AD0", VA = "0x1825296D0")]
	[AsyncStateMachine(typeof(NEFAFGFPCDP<>))]
	public static Task<T> PGIAMBCMBHL<T>(this Task<T> EAODMOEAJOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B8A0", Offset = "0x5E8ACA0", VA = "0x185E8B8A0")]
	[AsyncStateMachine(typeof(LPJAPDIPFIN))]
	public static Task<TaskStatus> BFPLJIBEELD(this Task EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2526860", Offset = "0x2525C60", VA = "0x182526860")]
	public static (Task<T?>?, Action<T?>?) ICMLFKPLJOC<T>([Optional] CancellationToken EANFAKGANNH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2526760", Offset = "0x2525B60", VA = "0x182526760")]
	[AsyncStateMachine(typeof(DLNPPCBBNLO<, >))]
	public static Task<List<TResult>> HEDEEPJFINL<TResult, TInput>(this Task<List<TInput>> BPGIJHHDFCF, NHIKHGAKLJE<TInput, TResult> KBBHPJOAEDP) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CC90", Offset = "0x5E8C090", VA = "0x185E8CC90")]
	[AsyncStateMachine(typeof(FKOOAHDFDIK))]
	public static Task PJNIHMKPPGH(Task AINBOEMJDAE, CancellationToken DIGBFHNOFEL, Func<CancellationToken, Task> DONCMDMDIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C870", Offset = "0x5E8BC70", VA = "0x185E8C870")]
	[AsyncStateMachine(typeof(BMHGIDNBCCF))]
	public static Task NGIEAPIGMNN(Func<CancellationToken, Task> ONABMGAGDFG, TimeSpan GBELJBLENFG, [Optional] CancellationToken DIGBFHNOFEL, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2526F80", Offset = "0x2526380", VA = "0x182526F80")]
	[AsyncStateMachine(typeof(HLNLCHLCIBH<>))]
	public static Task<T> NGIEAPIGMNN<T>(Func<CancellationToken, Task<T>> ONABMGAGDFG, TimeSpan GBELJBLENFG, [Optional] CancellationToken DIGBFHNOFEL, [Optional] Func<OperationCanceledException, T>? DFEPJCJADIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2526680", Offset = "0x2525A80", VA = "0x182526680")]
	[AsyncStateMachine(typeof(DGABBAJMBGP<>))]
	public static Task<IEnumerable<Task<T>>> GPLNGFBCGLD<T>(IEnumerable<Task<T>> NDPMBBIPABB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2526AA0", Offset = "0x2525EA0", VA = "0x182526AA0")]
	[AsyncStateMachine(typeof(OLDAJKBMLCJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> LLOEENACJEJ<T1, T2, T3, T4>(Task<T1> KLNHKBLAMCB, Task<T2> DKAKMFPCDHM, Task<T3> FFODODKADBL, Task<T4> HCFFKDJFHJO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B9E0", Offset = "0x5E8ADE0", VA = "0x185E8B9E0")]
	[AsyncStateMachine(typeof(LPFJEHLBDHB))]
	public static Task DAGBJNGOAKK(Func<bool> KCKDDHKPEDN, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B720", Offset = "0x5E8AB20", VA = "0x185E8B720")]
	[AsyncStateMachine(typeof(HBKLPOIONBC))]
	public static Task AFECLJNFGPB(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B5E0", Offset = "0x5E8A9E0", VA = "0x185E8B5E0")]
	[AsyncStateMachine(typeof(PENIHAJDLNM))]
	public static Task AFECLJNFGPB(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C5E0", Offset = "0x5E8B9E0", VA = "0x185E8C5E0")]
	[AsyncStateMachine(typeof(KGFANGLJBAC))]
	public static Task LIMJOMMENFE(Func<bool> KCKDDHKPEDN, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C4D0", Offset = "0x5E8B8D0", VA = "0x185E8C4D0")]
	[AsyncStateMachine(typeof(KCBNFEFGGLN))]
	public static Task LIMJOMMENFE(Func<bool> KCKDDHKPEDN, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BEE0", Offset = "0x5E8B2E0", VA = "0x185E8BEE0")]
	[AsyncStateMachine(typeof(HGHCBFHIDMH))]
	public static Task GEKLJMOFONK(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C010", Offset = "0x5E8B410", VA = "0x185E8C010")]
	[AsyncStateMachine(typeof(LDHHNOBLHLP))]
	public static Task GEKLJMOFONK(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C780", Offset = "0x5E8BB80", VA = "0x185E8C780")]
	[Obsolete]
	[AsyncStateMachine(typeof(GBNDDBEBBCL))]
	public static Task NGDGEMDBNHL(this Task BPGIJHHDFCF, Action KPKKHJKGEJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2526E90", Offset = "0x2526290", VA = "0x182526E90")]
	[Obsolete]
	[AsyncStateMachine(typeof(BFAMIIMHBKB<>))]
	public static Task NGDGEMDBNHL<T>(this Task<T> BPGIJHHDFCF, Action<T> KPKKHJKGEJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BAF0", Offset = "0x5E8AEF0", VA = "0x185E8BAF0")]
	public static bool DEDGJMNKOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C340", Offset = "0x5E8B740", VA = "0x185E8C340")]
	private static void KMDPNLMDCID(SynchronizationContext NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C220", Offset = "0x5E8B620", VA = "0x185E8C220")]
	private static void HDBPBDNIHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B850", Offset = "0x5E8AC50", VA = "0x185E8B850")]
	public static FPPJMAPDJAH ANCIHPALBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B990", Offset = "0x5E8AD90", VA = "0x185E8B990")]
	public static FPPJMAPDJAH BLHJFGJEABD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C150", Offset = "0x5E8B550", VA = "0x185E8C150")]
	[AsyncStateMachine(typeof(FCMFBHMJIKJ))]
	public static Task GIDMLIMLJOG(Func<Task> KMOKEKJAEFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GOIFFELMODE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	public GOIFFELMODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class ILKALHIOJOO : HFJCPICEHAL
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly HFJCPICEHAL NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DateTime KCODBOPKMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D580", Offset = "0x5E8C980", VA = "0x185E8D580", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset KBHFNLNIKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D520", Offset = "0x5E8C920", VA = "0x185E8D520", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public ILKALHIOJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HFJCPICEHAL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DateTime KCODBOPKMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTimeOffset KBHFNLNIKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LMBKONGCCCL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static long JEBHNNGLPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EEA0", Offset = "0x5E8E2A0", VA = "0x185E8EEA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long ECKLPOEFEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EA90", Offset = "0x5E8DE90", VA = "0x185E8EA90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static double ONLLEMCFPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EB30", Offset = "0x5E8DF30", VA = "0x185E8EB30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double JHMIHEPOEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EB80", Offset = "0x5E8DF80", VA = "0x185E8EB80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double GDPPFOIPDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EAE0", Offset = "0x5E8DEE0", VA = "0x185E8EAE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double KEFOLOKLPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E8ECF0", Offset = "0x5E8E0F0", VA = "0x185E8ECF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA00", Offset = "0x5E8DE00", VA = "0x185E8EA00")]
	public static double CIKANICHABI(long BLJDLLCMEJO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EBD0", Offset = "0x5E8DFD0", VA = "0x185E8EBD0")]
	public static double EGNMNCONFIH(long BLJDLLCMEJO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ED40", Offset = "0x5E8E140", VA = "0x185E8ED40")]
	public static double JOEPNMEAEPD(double MCMCAMBJKOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EC60", Offset = "0x5E8E060", VA = "0x185E8EC60")]
	public static long FBIGNHCAMPP(long IODAOFLOKJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E990", Offset = "0x5E8DD90", VA = "0x185E8E990")]
	public static long AGDDEOFKJMB(long JKADEAPNENC, long FKMKHHJAPNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EDD0", Offset = "0x5E8E1D0", VA = "0x185E8EDD0")]
	public static double MHKDLDJMKPC(long JKADEAPNENC, long FKMKHHJAPNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E9A0", Offset = "0x5E8DDA0", VA = "0x185E8E9A0")]
	public static double BECIAGJNKIF(long JKADEAPNENC, long FKMKHHJAPNA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class KEEIBCAAIFC : NELOGBOAHAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly TimeSpan NHEOODANFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly System.Timers.Timer HINBFABCJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private TimeSpan GBELJBLENFG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan LHBDBNIAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DCB0", Offset = "0x5E8D0B0", VA = "0x185E8DCB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Action? NPOFPFLGOII
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E270", Offset = "0x5E8D670", VA = "0x185E8E270")]
	[Preserve]
	public KEEIBCAAIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E020", Offset = "0x5E8D420", VA = "0x185E8E020")]
	public KEEIBCAAIFC(TimeSpan GBELJBLENFG, [Optional] Action? CFDMBANNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DE10", Offset = "0x5E8D210", VA = "0x185E8DE10", Slot = "7")]
	public void MBHHAMKDCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF40", Offset = "0x5E8D340", VA = "0x185E8DF40", Slot = "8")]
	public void OOMIEHBAEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DBE0", Offset = "0x5E8CFE0", VA = "0x185E8DBE0", Slot = "9")]
	public void AHNKAFMKLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB5B0A0", Offset = "0xB5A4A0", VA = "0x180B5B0A0")]
	private void ICODKFILGEC(object FPOCHAEKMIE, ElapsedEventArgs COILLGMICHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DEA0", Offset = "0x5E8D2A0", VA = "0x185E8DEA0")]
	private static void NAPJFNIMEGD(TimeSpan AEPDBMBDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DC10", Offset = "0x5E8D010", VA = "0x185E8DC10", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class GBPNDICKPEO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string DHHAABGOONI;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
	public GBPNDICKPEO(string DACNCMKHPFB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct DBAGLFACCCI : IEquatable<DBAGLFACCCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public uint HMIJIPKIFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public int GDEEJIBCBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float AFFLNNANFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ushort HIKKGDLEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ushort PEMGKGNEHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public short BOCGEIOEJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public short DCFLHAKCGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public char CKDGEDMPPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public char HFLOLEHKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public byte ABLIDDCKAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte NPFDBBMMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public byte LAIGKBNGCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte GCJMCIMBBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool GHBEHFKBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool IDBMPMBIMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool EBBHNLGLGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool LILCMKMHKNB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xD68A90", Offset = "0xD67E90", VA = "0x180D68A90")]
	public static DBAGLFACCCI MGILMOKHLDO(uint BAGJDFIKBAN)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD68A90", Offset = "0xD67E90", VA = "0x180D68A90")]
	public static DBAGLFACCCI KCLIBDJCGJP(int FAOONHKAKPO)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E881A0", Offset = "0x5E875A0", VA = "0x185E881A0")]
	public static DBAGLFACCCI FICNGCCDGBH(float AHLNPPCDKFN)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E88100", Offset = "0x5E87500", VA = "0x185E88100")]
	public static DBAGLFACCCI AJLOCNCPFFE(byte CMAEJDFBCDJ, byte DMCHDGOCNOE, byte MDADDALHCNA, byte OFBEPPEPCBC)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E88100", Offset = "0x5E87500", VA = "0x185E88100")]
	public static DBAGLFACCCI DHDFHFHKKOJ(bool ABPJOMHCKHM, bool OEICFMNMOGA, bool PEHDNHGOOFH, bool OJLGAAKGGDN)
	{
		return default(DBAGLFACCCI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x170C980", Offset = "0x170BD80", VA = "0x18170C980")]
	public static bool FCHDBNDMOOD(DBAGLFACCCI CGOLGFILFFA, DBAGLFACCCI EFDLLCLEIOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E8FE0", Offset = "0x7E83E0", VA = "0x1807E8FE0", Slot = "4")]
	public bool Equals(DBAGLFACCCI LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E88120", Offset = "0x5E87520", VA = "0x185E88120", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x871A20", Offset = "0x870E20", VA = "0x180871A20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E881B0", Offset = "0x5E875B0", VA = "0x185E881B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LJLBEPCNHFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ulong FHJLOCKMPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public long LHDCHMGJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public double MGJIAHOKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint NPMMEAPIPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint FOGNKOCECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int OLNJDFMJOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int OJCCMMGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float NCJHECEGIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float PEILIOADMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public ushort HIKKGDLEKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ushort PEMGKGNEHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ushort PJKMFMBCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public ushort DMGPAJMJEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public short BOCGEIOEJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public short DCFLHAKCGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public short KDIDMPFBKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public short INGJEGJCIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public char CKDGEDMPPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public char HFLOLEHKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public char MFOOAONFCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public char JFJFCIICCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public byte ABLIDDCKAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte NPFDBBMMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte LAIGKBNGCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte GCJMCIMBBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte HEBECEDLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte KFIKOGLLDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte IGLFNHGALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte JNOKLDKDJJI;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E940", Offset = "0x5E8DD40", VA = "0x185E8E940")]
	public static LJLBEPCNHFN PBDMNAJCIOP(byte CMAEJDFBCDJ, byte DMCHDGOCNOE, byte MDADDALHCNA, byte OFBEPPEPCBC, byte GOGKMNAICMJ, byte LANDGIBBPMA, byte IPHGLIABJGH, byte KJHABKAFOBE)
	{
		return default(LJLBEPCNHFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NPHMLFAKJMB
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x25342B0", Offset = "0x25336B0", VA = "0x1825342B0")]
	public static IEnumerable<T> LEIIALOAJHL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static T[] PEPHNEGIIJP<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static IEnumerable<T> BHIOIKFIOKD<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x22C0780", Offset = "0x22BFB80", VA = "0x1822C0780")]
	public static HashSet<T> BGHFOPCHLKD<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26347B0", Offset = "0x2633BB0", VA = "0x1826347B0")]
	public static KeyValuePair<TKey, TValue> MJHBLPOPEGF<TKey, TValue>([In] TKey MIMFBLPNKOG, [In] TValue NMENOOMOOJP) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x22C0780", Offset = "0x22BFB80", VA = "0x1822C0780")]
	public static List<T> HMKMFMHJNOG<T>(IEnumerable<T> JAAOHPHONMJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MDILKOOKCEJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string OOENPDKMIHI;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
	public MDILKOOKCEJ(string DNLOCNBCDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate object GFGJAEEIHPO<T>([In] T IFILEFKNBLN);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object HNPJGBELJGB<T>(T IFILEFKNBLN);
[Cpp2IlInjected.Token(Token = "0x2000053")]
[ACJFMPOAABG]
public delegate string FCIFHAHGINF(string DFBAIJNHOKM, string? NFLINLJKKJO, bool LFIJHJMOKBK);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[ACJFMPOAABG]
public delegate void JKLMBMIKHNJ(string KCFFPPIEBHH);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[ACJFMPOAABG]
public delegate void ABGEJAEDDCM(Exception LLKMJCLKBJP);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object CPNJBDPDKML();
[Cpp2IlInjected.Token(Token = "0x2000057")]
[ACJFMPOAABG]
public delegate bool PBJHAONILNK();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[ACJFMPOAABG]
public delegate string NKGJLFIFMDG(object ECLCDMJMICA);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Enum)]
public class JFPLAKAHGAG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
	public JFPLAKAHGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LGDMOCMDCKK
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class KOMOMOLMGPF<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly ISet<T> NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int AEFHJLMLIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x39F5130", Offset = "0x39F4530", VA = "0x1839F5130", Slot = "4")]
		public bool Add(T EDPLJLLHNEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LFMLAKDHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x39F52D0", Offset = "0x39F46D0", VA = "0x1839F52D0", Slot = "5")]
		public void UnionWith(IEnumerable<T> LFMLAKDHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x39F5210", Offset = "0x39F4610", VA = "0x1839F5210", Slot = "9")]
		void ICollection<T>.Add(T EDPLJLLHNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "11")]
		public bool Contains(T EDPLJLLHNEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "12")]
		public void CopyTo(T[] NCABOBFFNFK, int EKDLGEADDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
		public bool Remove(T EDPLJLLHNEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x39F5190", Offset = "0x39F4590", VA = "0x1839F5190", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x34B61F0", Offset = "0x34B55F0", VA = "0x1834B61F0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KOMOMOLMGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x80FF50", Offset = "0x80F350", VA = "0x18080FF50")]
	public static ISet<T> PFHDMEPGGHH<T>() where T : notnull
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
