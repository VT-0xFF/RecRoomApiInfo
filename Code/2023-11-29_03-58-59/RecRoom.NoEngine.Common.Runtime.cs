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
		[Cpp2IlInjected.Address(RVA = "0x5E8FB20", Offset = "0x5E8EF20", VA = "0x185E8FB20")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E87AE0", Offset = "0x5E86EE0", VA = "0x185E87AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3769520", Offset = "0x3768920", VA = "0x183769520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x376A580", Offset = "0x3769980", VA = "0x18376A580", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DA8B80", Offset = "0x4DA7F80", VA = "0x184DA8B80")]
	[AsyncStateMachine(typeof(DCIPEIDHLHE<>.IOBAFGJEEME))]
	public Task<TResult> BHHNDFKNLPO(EOANGGBFNFN DGALDPCOEEA, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8CC0", Offset = "0x4DA80C0", VA = "0x184DA8CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DA8D30", Offset = "0x4DA8130", VA = "0x184DA8D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x35CFCA0", Offset = "0x35CF0A0", VA = "0x1835CFCA0")]
	public HBOBECNMIPO([In] T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x35CF2D0", Offset = "0x35CE6D0", VA = "0x1835CF2D0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x35CF7D0", Offset = "0x35CEBD0", VA = "0x1835CF7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x35CFA40", Offset = "0x35CEE40", VA = "0x1835CFA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AHAHGMDGDPC
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E87AB0", Offset = "0x5E86EB0", VA = "0x185E87AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2653450", Offset = "0x2652850", VA = "0x182653450")]
	public static DOGKEGLKIOK ELNNKCHPFKH<T>()
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26536D0", Offset = "0x2652AD0", VA = "0x1826536D0")]
	public static DOGKEGLKIOK MBMIICOGBJB<T>([CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26534D0", Offset = "0x26528D0", VA = "0x1826534D0")]
	public static DOGKEGLKIOK ELNNKCHPFKH<T>(this T FPOCHAEKMIE) where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2653550", Offset = "0x2652950", VA = "0x182653550")]
	public static DOGKEGLKIOK LEDIONDMLEB<T>(this T FPOCHAEKMIE, [CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2653760", Offset = "0x2652B60", VA = "0x182653760")]
	public static DOGKEGLKIOK MBMIICOGBJB<T>(this T EAODMOEAJOC, [CallerMemberName] string MDFAJJKMBAI = "") where T : notnull
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FC40", Offset = "0x5E8F040", VA = "0x185E8FC40")]
	public static DOGKEGLKIOK MBMIICOGBJB(string FFDLICFJEMA, [CallerMemberName] string MDFAJJKMBAI = "")
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FBA0", Offset = "0x5E8EFA0", VA = "0x185E8FBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E89DE0", Offset = "0x5E891E0", VA = "0x185E89DE0")]
		get
		{
			return default(EFHJDLIMPFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PHNOPFPKEJK KCPLKIONLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A370", Offset = "0x5E89770", VA = "0x185E8A370")]
		get
		{
			return default(PHNOPFPKEJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GCACKNEBIBM DNDFJFNFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E89FD0", Offset = "0x5E893D0", VA = "0x185E89FD0")]
		get
		{
			return default(GCACKNEBIBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A1F0", Offset = "0x5E895F0", VA = "0x185E8A1F0")]
	public static void PFNHEOJKGLA([In] EFHJDLIMPFJ IPGJILGHAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E89E30", Offset = "0x5E89230", VA = "0x185E89E30")]
	public static void FPKCBBOJANI(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F00", Offset = "0x5E89300", VA = "0x185E89F00")]
	public static void GJOFFIOBNOA(string KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23D4010", Offset = "0x23D3410", VA = "0x1823D4010")]
	public static void GJOFFIOBNOA<T>(T GKKBCNLLJNC, HNPJGBELJGB<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E89C60", Offset = "0x5E89060", VA = "0x185E89C60")]
	public static void BHHNAGAKLKD(Exception LLKMJCLKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A190", Offset = "0x5E89590", VA = "0x185E8A190")]
	public static void OJJDBFIOFAP(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E89D00", Offset = "0x5E89100", VA = "0x185E89D00")]
	public static void CLIOEDEOLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E89D60", Offset = "0x5E89160", VA = "0x185E89D60")]
	public static string EBLPALPEAKB(object ECLCDMJMICA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E89BF0", Offset = "0x5E88FF0", VA = "0x185E89BF0")]
	public static long BAPDJDENGGB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A020", Offset = "0x5E89420", VA = "0x185E8A020")]
	public static bool HBPFCAMOKIP(bool KCKDDHKPEDN, string KCFFPPIEBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A0C0", Offset = "0x5E894C0", VA = "0x185E8A0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E892F0", Offset = "0x5E886F0", VA = "0x185E892F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B50", Offset = "0x5E88F50", VA = "0x185E89B50")]
	public EFHJDLIMPFJ([In] PHNOPFPKEJK GHAPCBLDCMN, [In] GCACKNEBIBM IEPKCIOPIGL, NKGJLFIFMDG LAMCPDFBCMM, MIKFAPNCHCI OJCNIFDCPNG, FCIFHAHGINF LCKLOBFNBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E89450", Offset = "0x5E88850", VA = "0x185E89450")]
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
	[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60")]
	private static string BMPIMFNBJNE(string DFBAIJNHOKM, string? NFLINLJKKJO, bool LFIJHJMOKBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E89490", Offset = "0x5E88890", VA = "0x185E89490")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CD2D40", Offset = "0x1CD2140", VA = "0x181CD2D40")]
	public OGHCEFCMLOD([In] T NMENOOMOOJP, int DIENMHDGFGP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAF80", Offset = "0x3DFA380", VA = "0x183DFAF80")]
	public static bool FCHDBNDMOOD([In] OGHCEFCMLOD<T> OJKFAPKLEMA, [In] OGHCEFCMLOD<T> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAF00", Offset = "0x3DFA300", VA = "0x183DFAF00", Slot = "4")]
	public bool Equals(OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x353A650", Offset = "0x3539A50", VA = "0x18353A650", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB6D0", Offset = "0x3DFAAD0", VA = "0x183DFB6D0")]
	public bool LNABLLEBLCL([In] OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB3A0", Offset = "0x3DFA7A0", VA = "0x183DFB3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB830", Offset = "0x3DFAC30", VA = "0x183DFB830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAB20", Offset = "0x3DF9F20", VA = "0x183DFAB20")]
	public void EJMICJJJLNI([Out] T NMENOOMOOJP, [Out] int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB4A0", Offset = "0x3DFA8A0", VA = "0x183DFB4A0")]
	public (T, int) LGPONIONLJB()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAAD0", Offset = "0x3DF9ED0", VA = "0x183DFAAD0", Slot = "5")]
	private bool DPGKNKBALCO([In] OGHCEFCMLOD<T> LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KFMDAMFILKP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25782D0", Offset = "0x25776D0", VA = "0x1825782D0")]
	public static OGHCEFCMLOD<T> PBDMNAJCIOP<T>([In] T NMENOOMOOJP, int DIENMHDGFGP) where T : notnull
	{
		return default(OGHCEFCMLOD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ECOHBEHPGJN
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x23B7910", Offset = "0x23B6D10", VA = "0x1823B7910")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E90100", Offset = "0x5E8F500", VA = "0x185E90100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8F30C0", Offset = "0x8F24C0", VA = "0x1808F30C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E90590", Offset = "0x5E8F990", VA = "0x185E90590")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E90300", Offset = "0x5E8F700", VA = "0x185E90300")]
	public void FPKCBBOJANI(object KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90370", Offset = "0x5E8F770", VA = "0x185E90370")]
	public void GJOFFIOBNOA(object KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20DA4B0", Offset = "0x20D98B0", VA = "0x1820DA4B0")]
	public void BHHNAGAKLKD(Exception LLKMJCLKBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E903E0", Offset = "0x5E8F7E0", VA = "0x185E903E0")]
	public void GJOFFIOBNOA(CPNJBDPDKML KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x266E230", Offset = "0x266D630", VA = "0x18266E230")]
	public void GJOFFIOBNOA<T>(T GKKBCNLLJNC, HNPJGBELJGB<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x266DFF0", Offset = "0x266D3F0", VA = "0x18266DFF0")]
	public void FPKCBBOJANI<T>([In] T GKKBCNLLJNC, GFGJAEEIHPO<T> KCFFPPIEBHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E904C0", Offset = "0x5E8F8C0", VA = "0x185E904C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x871B00", Offset = "0x870F00", VA = "0x180871B00")]
	public DOGKEGLKIOK(string NMENOOMOOJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBD40", VA = "0x1807DC940")]
	public static string GOCBKKMEEIH([In] DOGKEGLKIOK EAODMOEAJOC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x13AF530", Offset = "0x13AE930", VA = "0x1813AF530")]
	public static DOGKEGLKIOK GOCBKKMEEIH(string LFMLAKDHEFO)
	{
		return default(DOGKEGLKIOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E89160", Offset = "0x5E88560", VA = "0x185E89160")]
	public string LGCBMHJEDEJ(string BCMGDCDFIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E89080", Offset = "0x5E88480", VA = "0x185E89080")]
	public string DCGGJJPBGGJ(object PPOIIGFJLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBD40", VA = "0x1807DC940", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E88150", Offset = "0x5E87550", VA = "0x185E88150", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E881A0", Offset = "0x5E875A0", VA = "0x185E881A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E881B0", Offset = "0x5E875B0", VA = "0x185E881B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EC2BD0", Offset = "0x3EC1FD0", VA = "0x183EC2BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2FF0", Offset = "0x3EC23F0", VA = "0x183EC2FF0")]
	public PDAIFMGJHAK([In] T NMENOOMOOJP, bool NFIFFLIIHGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2630", Offset = "0x3EC1A30", VA = "0x183EC2630")]
	public static bool FCHDBNDMOOD([In] PDAIFMGJHAK<T> OJKFAPKLEMA, [In] PDAIFMGJHAK<T> BBHLJNIGCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAF00", Offset = "0x3DFA300", VA = "0x183DFAF00", Slot = "4")]
	public bool Equals(PDAIFMGJHAK<T> LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1F60", Offset = "0x3EC1360", VA = "0x183EC1F60", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3EC29F0", Offset = "0x3EC1DF0", VA = "0x183EC29F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2D00", Offset = "0x3EC2100", VA = "0x183EC2D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class PMJNJGJDPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2671820", Offset = "0x2670C20", VA = "0x182671820")]
	public static PDAIFMGJHAK<T> LEJKCCHLPBK<T>([In] T NMENOOMOOJP) where T : notnull
	{
		return default(PDAIFMGJHAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2671710", Offset = "0x2670B10", VA = "0x182671710")]
	public static PDAIFMGJHAK<T?> IHCFLDDJNEN<T>()
	{
		return default(PDAIFMGJHAK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26715D0", Offset = "0x26709D0", VA = "0x1826715D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8B400", Offset = "0x5E8A800", VA = "0x185E8B400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x82CA80", Offset = "0x82BE80", VA = "0x18082CA80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E8B4E0", Offset = "0x5E8A8E0", VA = "0x185E8B4E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x871B00", Offset = "0x870F00", VA = "0x180871B00")]
	private JKHIOOJCILI(IntPtr NELIKCGGBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D7F0", Offset = "0x5E8CBF0", VA = "0x185E8D7F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D800", Offset = "0x5E8CC00", VA = "0x185E8D800")]
	public static JKHIOOJCILI PBDMNAJCIOP(string MDFAJJKMBAI)
	{
		return default(JKHIOOJCILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9A50", Offset = "0x1CC8E50", VA = "0x181CC9A50")]
	public static JKHIOOJCILI PBDMNAJCIOP([In] GCACKNEBIBM IEPKCIOPIGL, string MDFAJJKMBAI)
	{
		return default(JKHIOOJCILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9EE0", Offset = "0x1CC92E0", VA = "0x181CC9EE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E8F8E0", Offset = "0x5E8ECE0", VA = "0x185E8F8E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E8F940", Offset = "0x5E8ED40", VA = "0x185E8F940", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E90CB0", Offset = "0x5E900B0", VA = "0x185E90CB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E8A8E0", Offset = "0x5E89CE0", VA = "0x185E8A8E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A900", Offset = "0x5E89D00", VA = "0x185E8A900", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D720", Offset = "0x5E8CB20", VA = "0x185E8D720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3551100", VA = "0x183551D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E0A8F0", Offset = "0x3E09CF0", VA = "0x183E0A8F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8E600", Offset = "0x5E8DA00", VA = "0x185E8E600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E0", Offset = "0x7F5AE0", VA = "0x1807F66E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8FD30", Offset = "0x5E8F130", VA = "0x185E8FD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E0", Offset = "0x7F5AE0", VA = "0x1807F66E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4587170", Offset = "0x4586570", VA = "0x184587170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x45872E0", Offset = "0x45866E0", VA = "0x1845872E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D21FD0", Offset = "0x3D213D0", VA = "0x183D21FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D22840", Offset = "0x3D21C40", VA = "0x183D22840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8F670", Offset = "0x5E8EA70", VA = "0x185E8F670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F870", Offset = "0x5E8EC70", VA = "0x185E8F870", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3551100", VA = "0x183551D00")]
		internal void KEINDIBONOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3551D40", Offset = "0x3551140", VA = "0x183551D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE47D0", Offset = "0x4DE3BD0", VA = "0x184DE47D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4EC0", Offset = "0x4DE42C0", VA = "0x184DE4EC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A9D0", Offset = "0x5E89DD0", VA = "0x185E8A9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B1C0", Offset = "0x5E8A5C0", VA = "0x185E8B1C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E87BB0", Offset = "0x5E86FB0", VA = "0x185E87BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E880F0", Offset = "0x5E874F0", VA = "0x185E880F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3611180", Offset = "0x3610580", VA = "0x183611180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x30EB1A0", Offset = "0x30EA5A0", VA = "0x1830EB1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DCCC90", Offset = "0x4DCC090", VA = "0x184DCCC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3478120", Offset = "0x3477520", VA = "0x183478120", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E172C0", Offset = "0x3E166C0", VA = "0x183E172C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3E179C0", Offset = "0x3E16DC0", VA = "0x183E179C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8F2A0", Offset = "0x5E8E6A0", VA = "0x185E8F2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F610", Offset = "0x5E8EA10", VA = "0x185E8F610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8CF60", Offset = "0x5E8C360", VA = "0x185E8CF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D250", Offset = "0x5E8C650", VA = "0x185E8D250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E891B0", Offset = "0x5E885B0", VA = "0x185E891B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8FE40", Offset = "0x5E8F240", VA = "0x185E8FE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E900A0", Offset = "0x5E8F4A0", VA = "0x185E900A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8E3C0", Offset = "0x5E8D7C0", VA = "0x185E8E3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E5A0", Offset = "0x5E8D9A0", VA = "0x185E8E5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D8F0", Offset = "0x5E8CCF0", VA = "0x185E8D8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DC60", Offset = "0x5E8D060", VA = "0x185E8DC60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D2B0", Offset = "0x5E8C6B0", VA = "0x185E8D2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D5A0", Offset = "0x5E8C9A0", VA = "0x185E8D5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8FCC0", Offset = "0x5E8F0C0", VA = "0x185E8FCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8E760", Offset = "0x5E8DB60", VA = "0x185E8E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E9C0", Offset = "0x5E8DDC0", VA = "0x185E8E9C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8B220", Offset = "0x5E8A620", VA = "0x185E8B220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B3A0", Offset = "0x5E8A7A0", VA = "0x185E8B3A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4557B30", Offset = "0x4556F30", VA = "0x184557B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4557D90", Offset = "0x4557190", VA = "0x184557D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8A470", Offset = "0x5E89870", VA = "0x185E8A470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A880", Offset = "0x5E89C80", VA = "0x185E8A880", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8BF50", Offset = "0x5E8B350", VA = "0x185E8BF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2526CB0", Offset = "0x25260B0", VA = "0x182526CB0")]
	public static Task<T> NCCKFJKLDAN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CA80", Offset = "0x5E8BE80", VA = "0x185E8CA80")]
	public static Task NJANKFKJMDK(this Task BPGIJHHDFCF, CancellationToken NOEAHPPKHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25287C0", Offset = "0x2527BC0", VA = "0x1825287C0")]
	public static Task<TResult> NJANKFKJMDK<TResult>(this Task<TResult> BPGIJHHDFCF, CancellationToken NOEAHPPKHNC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25291E0", Offset = "0x25285E0", VA = "0x1825291E0")]
	public static TaskCompletionSource<TResult> NJANKFKJMDK<TResult>(this TaskCompletionSource<TResult> KGCILHALMAA, CancellationToken NOEAHPPKHNC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CCC0", Offset = "0x5E8C0C0", VA = "0x185E8CCC0")]
	[AsyncStateMachine(typeof(KJOFHHOHDKC))]
	public static void PHCNNCBOCEF(this Task AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C7B0", Offset = "0x5E8BBB0", VA = "0x185E8C7B0")]
	[AsyncStateMachine(typeof(PCFEAFFDAOC))]
	public static void LNIKKCGDIOB(this Task AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2526440", Offset = "0x2525840", VA = "0x182526440")]
	[AsyncStateMachine(typeof(BOOGEMMNLCK<>))]
	public static Task AIMNJDNMGLK<TException>(this Task AINBOEMJDAE) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2529640", Offset = "0x2528A40", VA = "0x182529640")]
	[AsyncStateMachine(typeof(NEFAFGFPCDP<>))]
	public static Task<T> PGIAMBCMBHL<T>(this Task<T> EAODMOEAJOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B980", Offset = "0x5E8AD80", VA = "0x185E8B980")]
	[AsyncStateMachine(typeof(LPJAPDIPFIN))]
	public static Task<TaskStatus> BFPLJIBEELD(this Task EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25267D0", Offset = "0x2525BD0", VA = "0x1825267D0")]
	public static (Task<T?>?, Action<T?>?) ICMLFKPLJOC<T>([Optional] CancellationToken EANFAKGANNH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25266D0", Offset = "0x2525AD0", VA = "0x1825266D0")]
	[AsyncStateMachine(typeof(DLNPPCBBNLO<, >))]
	public static Task<List<TResult>> HEDEEPJFINL<TResult, TInput>(this Task<List<TInput>> BPGIJHHDFCF, NHIKHGAKLJE<TInput, TResult> KBBHPJOAEDP) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CD70", Offset = "0x5E8C170", VA = "0x185E8CD70")]
	[AsyncStateMachine(typeof(FKOOAHDFDIK))]
	public static Task PJNIHMKPPGH(Task AINBOEMJDAE, CancellationToken DIGBFHNOFEL, Func<CancellationToken, Task> DONCMDMDIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C950", Offset = "0x5E8BD50", VA = "0x185E8C950")]
	[AsyncStateMachine(typeof(BMHGIDNBCCF))]
	public static Task NGIEAPIGMNN(Func<CancellationToken, Task> ONABMGAGDFG, TimeSpan GBELJBLENFG, [Optional] CancellationToken DIGBFHNOFEL, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2526EF0", Offset = "0x25262F0", VA = "0x182526EF0")]
	[AsyncStateMachine(typeof(HLNLCHLCIBH<>))]
	public static Task<T> NGIEAPIGMNN<T>(Func<CancellationToken, Task<T>> ONABMGAGDFG, TimeSpan GBELJBLENFG, [Optional] CancellationToken DIGBFHNOFEL, [Optional] Func<OperationCanceledException, T>? DFEPJCJADIN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x25265F0", Offset = "0x25259F0", VA = "0x1825265F0")]
	[AsyncStateMachine(typeof(DGABBAJMBGP<>))]
	public static Task<IEnumerable<Task<T>>> GPLNGFBCGLD<T>(IEnumerable<Task<T>> NDPMBBIPABB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2526A10", Offset = "0x2525E10", VA = "0x182526A10")]
	[AsyncStateMachine(typeof(OLDAJKBMLCJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> LLOEENACJEJ<T1, T2, T3, T4>(Task<T1> KLNHKBLAMCB, Task<T2> DKAKMFPCDHM, Task<T3> FFODODKADBL, Task<T4> HCFFKDJFHJO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BAC0", Offset = "0x5E8AEC0", VA = "0x185E8BAC0")]
	[AsyncStateMachine(typeof(LPFJEHLBDHB))]
	public static Task DAGBJNGOAKK(Func<bool> KCKDDHKPEDN, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B800", Offset = "0x5E8AC00", VA = "0x185E8B800")]
	[AsyncStateMachine(typeof(HBKLPOIONBC))]
	public static Task AFECLJNFGPB(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B6C0", Offset = "0x5E8AAC0", VA = "0x185E8B6C0")]
	[AsyncStateMachine(typeof(PENIHAJDLNM))]
	public static Task AFECLJNFGPB(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C6C0", Offset = "0x5E8BAC0", VA = "0x185E8C6C0")]
	[AsyncStateMachine(typeof(KGFANGLJBAC))]
	public static Task LIMJOMMENFE(Func<bool> KCKDDHKPEDN, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C5B0", Offset = "0x5E8B9B0", VA = "0x185E8C5B0")]
	[AsyncStateMachine(typeof(KCBNFEFGGLN))]
	public static Task LIMJOMMENFE(Func<bool> KCKDDHKPEDN, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BFC0", Offset = "0x5E8B3C0", VA = "0x185E8BFC0")]
	[AsyncStateMachine(typeof(HGHCBFHIDMH))]
	public static Task GEKLJMOFONK(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C0F0", Offset = "0x5E8B4F0", VA = "0x185E8C0F0")]
	[AsyncStateMachine(typeof(LDHHNOBLHLP))]
	public static Task GEKLJMOFONK(Func<bool> KCKDDHKPEDN, TimeSpan GBELJBLENFG, TimeSpan IIEPNKJCFFC, [Optional] CancellationToken EANFAKGANNH, [Optional] Action<OperationCanceledException>? DFEPJCJADIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C860", Offset = "0x5E8BC60", VA = "0x185E8C860")]
	[Obsolete]
	[AsyncStateMachine(typeof(GBNDDBEBBCL))]
	public static Task NGDGEMDBNHL(this Task BPGIJHHDFCF, Action KPKKHJKGEJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2526E00", Offset = "0x2526200", VA = "0x182526E00")]
	[Obsolete]
	[AsyncStateMachine(typeof(BFAMIIMHBKB<>))]
	public static Task NGDGEMDBNHL<T>(this Task<T> BPGIJHHDFCF, Action<T> KPKKHJKGEJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BBD0", Offset = "0x5E8AFD0", VA = "0x185E8BBD0")]
	public static bool DEDGJMNKOHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C420", Offset = "0x5E8B820", VA = "0x185E8C420")]
	private static void KMDPNLMDCID(SynchronizationContext NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C300", Offset = "0x5E8B700", VA = "0x185E8C300")]
	private static void HDBPBDNIHDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B930", Offset = "0x5E8AD30", VA = "0x185E8B930")]
	public static FPPJMAPDJAH ANCIHPALBPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BA70", Offset = "0x5E8AE70", VA = "0x185E8BA70")]
	public static FPPJMAPDJAH BLHJFGJEABD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C230", Offset = "0x5E8B630", VA = "0x185E8C230")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8D660", Offset = "0x5E8CA60", VA = "0x185E8D660", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset KBHFNLNIKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D600", Offset = "0x5E8CA00", VA = "0x185E8D600", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EF80", Offset = "0x5E8E380", VA = "0x185E8EF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EB70", Offset = "0x5E8DF70", VA = "0x185E8EB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EC10", Offset = "0x5E8E010", VA = "0x185E8EC10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EC60", Offset = "0x5E8E060", VA = "0x185E8EC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EBC0", Offset = "0x5E8DFC0", VA = "0x185E8EBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8EDD0", Offset = "0x5E8E1D0", VA = "0x185E8EDD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EAE0", Offset = "0x5E8DEE0", VA = "0x185E8EAE0")]
	public static double CIKANICHABI(long BLJDLLCMEJO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ECB0", Offset = "0x5E8E0B0", VA = "0x185E8ECB0")]
	public static double EGNMNCONFIH(long BLJDLLCMEJO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EE20", Offset = "0x5E8E220", VA = "0x185E8EE20")]
	public static double JOEPNMEAEPD(double MCMCAMBJKOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ED40", Offset = "0x5E8E140", VA = "0x185E8ED40")]
	public static long FBIGNHCAMPP(long IODAOFLOKJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA70", Offset = "0x5E8DE70", VA = "0x185E8EA70")]
	public static long AGDDEOFKJMB(long JKADEAPNENC, long FKMKHHJAPNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EEB0", Offset = "0x5E8E2B0", VA = "0x185E8EEB0")]
	public static double MHKDLDJMKPC(long JKADEAPNENC, long FKMKHHJAPNA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA80", Offset = "0x5E8DE80", VA = "0x185E8EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E8DD90", Offset = "0x5E8D190", VA = "0x185E8DD90", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E8E350", Offset = "0x5E8D750", VA = "0x185E8E350")]
	[Preserve]
	public KEEIBCAAIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E100", Offset = "0x5E8D500", VA = "0x185E8E100")]
	public KEEIBCAAIFC(TimeSpan GBELJBLENFG, [Optional] Action? CFDMBANNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DEF0", Offset = "0x5E8D2F0", VA = "0x185E8DEF0", Slot = "7")]
	public void MBHHAMKDCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E020", Offset = "0x5E8D420", VA = "0x185E8E020", Slot = "8")]
	public void OOMIEHBAEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DCC0", Offset = "0x5E8D0C0", VA = "0x185E8DCC0", Slot = "9")]
	public void AHNKAFMKLLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB5AFF0", Offset = "0xB5A3F0", VA = "0x180B5AFF0")]
	private void ICODKFILGEC(object FPOCHAEKMIE, ElapsedEventArgs COILLGMICHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF80", Offset = "0x5E8D380", VA = "0x185E8DF80")]
	private static void NAPJFNIMEGD(TimeSpan AEPDBMBDGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DCF0", Offset = "0x5E8D0F0", VA = "0x185E8DCF0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0xD689E0", Offset = "0xD67DE0", VA = "0x180D689E0")]
	public static DBAGLFACCCI MGILMOKHLDO(uint BAGJDFIKBAN)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD689E0", Offset = "0xD67DE0", VA = "0x180D689E0")]
	public static DBAGLFACCCI KCLIBDJCGJP(int FAOONHKAKPO)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88280", Offset = "0x5E87680", VA = "0x185E88280")]
	public static DBAGLFACCCI FICNGCCDGBH(float AHLNPPCDKFN)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E881E0", Offset = "0x5E875E0", VA = "0x185E881E0")]
	public static DBAGLFACCCI AJLOCNCPFFE(byte CMAEJDFBCDJ, byte DMCHDGOCNOE, byte MDADDALHCNA, byte OFBEPPEPCBC)
	{
		return default(DBAGLFACCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E881E0", Offset = "0x5E875E0", VA = "0x185E881E0")]
	public static DBAGLFACCCI DHDFHFHKKOJ(bool ABPJOMHCKHM, bool OEICFMNMOGA, bool PEHDNHGOOFH, bool OJLGAAKGGDN)
	{
		return default(DBAGLFACCCI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x170C8D0", Offset = "0x170BCD0", VA = "0x18170C8D0")]
	public static bool FCHDBNDMOOD(DBAGLFACCCI CGOLGFILFFA, DBAGLFACCCI EFDLLCLEIOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7E9010", Offset = "0x7E8410", VA = "0x1807E9010", Slot = "4")]
	public bool Equals(DBAGLFACCCI LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E88200", Offset = "0x5E87600", VA = "0x185E88200", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8719E0", Offset = "0x870DE0", VA = "0x1808719E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E88290", Offset = "0x5E87690", VA = "0x185E88290", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E8EA20", Offset = "0x5E8DE20", VA = "0x185E8EA20")]
	public static LJLBEPCNHFN PBDMNAJCIOP(byte CMAEJDFBCDJ, byte DMCHDGOCNOE, byte MDADDALHCNA, byte OFBEPPEPCBC, byte GOGKMNAICMJ, byte LANDGIBBPMA, byte IPHGLIABJGH, byte KJHABKAFOBE)
	{
		return default(LJLBEPCNHFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NPHMLFAKJMB
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2534220", Offset = "0x2533620", VA = "0x182534220")]
	public static IEnumerable<T> LEIIALOAJHL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60")]
	public static T[] PEPHNEGIIJP<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60")]
	public static IEnumerable<T> BHIOIKFIOKD<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x22C06C0", Offset = "0x22BFAC0", VA = "0x1822C06C0")]
	public static HashSet<T> BGHFOPCHLKD<T>(params T[] JGJMDABBKHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2634720", Offset = "0x2633B20", VA = "0x182634720")]
	public static KeyValuePair<TKey, TValue> MJHBLPOPEGF<TKey, TValue>([In] TKey MIMFBLPNKOG, [In] TValue NMENOOMOOJP) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x22C06C0", Offset = "0x22BFAC0", VA = "0x1822C06C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x39F3CC0", Offset = "0x39F30C0", VA = "0x1839F3CC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39F3E60", Offset = "0x39F3260", VA = "0x1839F3E60", Slot = "5")]
		public void UnionWith(IEnumerable<T> LFMLAKDHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x39F3DA0", Offset = "0x39F31A0", VA = "0x1839F3DA0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x39F3D20", Offset = "0x39F3120", VA = "0x1839F3D20", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x34B4B00", Offset = "0x34B3F00", VA = "0x1834B4B00", Slot = "15")]
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
	[Cpp2IlInjected.Address(RVA = "0x80FF20", Offset = "0x80F320", VA = "0x18080FF20")]
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
