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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB1F0", Offset = "0x5CF9FF0", VA = "0x185CFB1F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class MJKPHOPMILM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAD00", Offset = "0x5CF9B00", VA = "0x185CFAD00")]
	public MJKPHOPMILM(bool GCFOIJMINIG, string KOJDOEOOJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ANNIBLKGKOF<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> MAGGMKNKPDJ(CancellationToken BCCDJHNACKO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IBKAHEEMHHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ANNIBLKGKOF<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MAGGMKNKPDJ taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x366CB50", Offset = "0x366B950", VA = "0x18366CB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x366DB90", Offset = "0x366C990", VA = "0x18366DB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource AJBHEMPONAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? EMCEAFOIIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? LJKMAOHODBK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36E8AB0", Offset = "0x36E78B0", VA = "0x1836E8AB0")]
	[AsyncStateMachine(typeof(ANNIBLKGKOF<>.IBKAHEEMHHP))]
	public Task<TResult> CKDBDMKICFN(MAGGMKNKPDJ AFHLHFCMKNO, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36E8BF0", Offset = "0x36E79F0", VA = "0x1836E8BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36E8C60", Offset = "0x36E7A60", VA = "0x1836E8C60")]
	public ANNIBLKGKOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DGMFICKLLHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> FLNPEEHKALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T CAGIMKNDHKH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35267C0", Offset = "0x35255C0", VA = "0x1835267C0")]
	public DGMFICKLLHN([In] T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C62B00", Offset = "0x4C61900", VA = "0x184C62B00", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C62C90", Offset = "0x4C61A90", VA = "0x184C62C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C62E30", Offset = "0x4C61C30", VA = "0x184C62E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LJIIBFNPIKB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	public LJIIBFNPIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class KBDIGOEEBHG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	public KBDIGOEEBHG(string AMJJJIEFIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class OGLMAGPBGIP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	public OGLMAGPBGIP(string AMJJJIEFIFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NPCHLPCEEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24EAD70", Offset = "0x24E9B70", VA = "0x1824EAD70")]
	public static LKJHNEGLGDH KDNJOKOIFJA<T>()
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24EABE0", Offset = "0x24E99E0", VA = "0x1824EABE0")]
	public static LKJHNEGLGDH JDIIKIOPKIK<T>([CallerMemberName] string MEBBBIMBIJO = "") where T : notnull
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24EADF0", Offset = "0x24E9BF0", VA = "0x1824EADF0")]
	public static LKJHNEGLGDH KDNJOKOIFJA<T>(this T KNIBDNLMNEE) where T : notnull
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x24EA9C0", Offset = "0x24E97C0", VA = "0x1824EA9C0")]
	public static LKJHNEGLGDH GKAMGNONNOB<T>(this T KNIBDNLMNEE, [CallerMemberName] string MEBBBIMBIJO = "") where T : notnull
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x24EAB40", Offset = "0x24E9940", VA = "0x1824EAB40")]
	public static LKJHNEGLGDH JDIIKIOPKIK<T>(this T PECKHAMCEFO, [CallerMemberName] string MEBBBIMBIJO = "") where T : notnull
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAE60", Offset = "0x5CF9C60", VA = "0x185CFAE60")]
	public static LKJHNEGLGDH JDIIKIOPKIK(string POEFKHMGDKP, [CallerMemberName] string MEBBBIMBIJO = "")
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAEE0", Offset = "0x5CF9CE0", VA = "0x185CFAEE0")]
	public static string KHPEALBHLBD(this object PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LJIIBFNPIKB]
public delegate long BHFMCIPEFBP();
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EDMMMPFEFPM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KHFFLPANGIN HJEHNIFIJGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KHFFLPANGIN LEINLJCPIDP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF83F0", Offset = "0x5CF71F0", VA = "0x185CF83F0")]
		get
		{
			return default(KHFFLPANGIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KBBDNOBKBGA BHOHLHAFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF88C0", Offset = "0x5CF76C0", VA = "0x185CF88C0")]
		get
		{
			return default(KBBDNOBKBGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JHHNBNGKADN HGCMAGLMACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8760", Offset = "0x5CF7560", VA = "0x185CF8760")]
		get
		{
			return default(JHHNBNGKADN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8440", Offset = "0x5CF7240", VA = "0x185CF8440")]
	public static void BLEPBLKDMDF([In] KHFFLPANGIN GDOFMPAMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8690", Offset = "0x5CF7490", VA = "0x185CF8690")]
	public static void BPAIBICBBJL(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CF85C0", Offset = "0x5CF73C0", VA = "0x185CF85C0")]
	public static void BNJKOEGGPFA(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2248860", Offset = "0x2247660", VA = "0x182248860")]
	public static void BNJKOEGGPFA<T>(T GIMGFOJNMGL, GGDNIKAAKOL<T> BLAOEBOMGGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8990", Offset = "0x5CF7790", VA = "0x185CF8990")]
	public static void LPIFGLLPDKC(Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8910", Offset = "0x5CF7710", VA = "0x185CF8910")]
	public static string KHPEALBHLBD(object DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8850", Offset = "0x5CF7650", VA = "0x185CF8850")]
	public static long HIDHKHHOBPB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CF87B0", Offset = "0x5CF75B0", VA = "0x185CF87B0")]
	public static bool DBFDEKBGBNE(bool FAKFOJBAANF, string BLAOEBOMGGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8A30", Offset = "0x5CF7830", VA = "0x185CF8A30")]
	public static double NLMPDIFANAJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KHFFLPANGIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KBBDNOBKBGA BHOHLHAFBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly JHHNBNGKADN HGCMAGLMACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly PDMDANOIFLH CLEDJLHFDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly BHFMCIPEFBP NHPCFOOAOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JOALPAJANDL CLDIBJOAJFD;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly PDMDANOIFLH HHAGLICIFDG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BHFMCIPEFBP EDBOBEHCBOH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JOALPAJANDL IEKGIPMLKJL;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly KHFFLPANGIN HGIJALJPANA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA310", Offset = "0x5CF9110", VA = "0x185CFA310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAB30", Offset = "0x5CF9930", VA = "0x185CFAB30")]
	public KHFFLPANGIN([In] KBBDNOBKBGA OBGHJMCIPCF, [In] JHHNBNGKADN PMPAEBNGDPA, PDMDANOIFLH KMMKPJDDKFE, BHFMCIPEFBP KPDHOPHBCPL, JOALPAJANDL MLNMHAIGHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA2D0", Offset = "0x5CF90D0", VA = "0x185CFA2D0")]
	private static string BECFEAEJFBC(object DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40")]
	private static long HBGMPKAODFJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	private static string LEAHONDCHNJ(string MNCMCPLICPL, string? KMMHDHGBEMH, bool OODOFCFFLPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA470", Offset = "0x5CF9270", VA = "0x185CFA470")]
	private static KHFFLPANGIN ENBPJEOAOCL()
	{
		return default(KHFFLPANGIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GFDHPEOAJOD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CADGIGJDELB([In] T LKMMHIOOCMN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void NDIHCAGPPIH<T>([In] T GIMGFOJNMGL);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct LHIABNLFMJE<T> : IEquatable<LHIABNLFMJE<T>>, GFDHPEOAJOD<LHIABNLFMJE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T CAGIMKNDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int FCFMLMDMJIH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C6C2E0", Offset = "0x1C6B0E0", VA = "0x181C6C2E0")]
	public LHIABNLFMJE([In] T POACLGOFKAJ, int OCMJNDDMDAL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3988990", Offset = "0x3987790", VA = "0x183988990")]
	public static bool PNFEPLLEJJK([In] LHIABNLFMJE<T> NLBDNIEIKMB, [In] LHIABNLFMJE<T> NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3892D10", Offset = "0x3891B10", VA = "0x183892D10", Slot = "4")]
	public bool Equals(LHIABNLFMJE<T> LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3987EB0", Offset = "0x3986CB0", VA = "0x183987EB0", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3987E20", Offset = "0x3986C20", VA = "0x183987E20")]
	public bool CADGIGJDELB([In] LHIABNLFMJE<T> LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3987FB0", Offset = "0x3986DB0", VA = "0x183987FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3989220", Offset = "0x3988020", VA = "0x183989220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3987C60", Offset = "0x3986A60", VA = "0x183987C60")]
	public void BLKEKIPLEEN([Out] T POACLGOFKAJ, [Out] int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3988460", Offset = "0x3987260", VA = "0x183988460")]
	public (T, int) NOCCMJLIOME()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3987700", Offset = "0x3986500", VA = "0x183987700", Slot = "5")]
	private bool BEMIDAODKBP([In] LHIABNLFMJE<T> LKMMHIOOCMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ECGJMLOFNCC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2248770", Offset = "0x2247570", VA = "0x182248770")]
	public static LHIABNLFMJE<T> IGHHFGMBDIH<T>([In] T POACLGOFKAJ, int OCMJNDDMDAL) where T : notnull
	{
		return default(LHIABNLFMJE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MHDKODFJIDP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x247E530", Offset = "0x247D330", VA = "0x18247E530")]
	public static bool CADGIGJDELB<T, U>([In] T PECKHAMCEFO, [In] U DGPHOMINFCK) where T : notnull, GFDHPEOAJOD<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult AEDMKADKKOH<T, out TResult>([In] T GIMGFOJNMGL);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate TResult CHNCMIMCKJP<T1, T2, out TResult>([In] T1 FHIOFJHPLJP, [In] T2 EDECMJEMFGA);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CNPFPLFJHGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan CPBEGICJHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? AKPDBBGAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAOEPALFJFL();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAHDDFBEPKL();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HIBINMOMJCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KBBDNOBKBGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly HMGOECLLDCG KCCBHGHFGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly CCCDCHGJCKH OJJODIMGNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly HMGOECLLDCG AJIFCNKKMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly CCCDCHGJCKH BLCHANAGCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly HMGOECLLDCG BHFPMLMFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly CCCDCHGJCKH HNGJNJDDBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IIDJBEECHCF HENIACNPCAH;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly HMGOECLLDCG FFDCEJAMAPC;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly CCCDCHGJCKH GBJOKFODABI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly HMGOECLLDCG NMPMNPGEMLF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CCCDCHGJCKH LINJIBHOIEN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly HMGOECLLDCG PMBDLJOBJFG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly CCCDCHGJCKH INKBHKHPFLO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IIDJBEECHCF LJMPHCCBHAH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KBBDNOBKBGA HGIJALJPANA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly HMGOECLLDCG EHMOFGAFAIK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF99B0", Offset = "0x5CF87B0", VA = "0x185CF99B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x865440", Offset = "0x864240", VA = "0x180865440")]
	public KBBDNOBKBGA(HMGOECLLDCG HNEDDLMEDIJ, CCCDCHGJCKH PIMPCCOHHBG, HMGOECLLDCG GMJCDGHEAIB, CCCDCHGJCKH FDPNFGBNHPD, HMGOECLLDCG BECLNCPBCBE, CCCDCHGJCKH GIALFNGLGJG, IIDJBEECHCF PDPKOPNKEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	private static bool ONJDNCFNMKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void PENMDFBOIJL(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	private static bool AFDJGOLDIMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void MHBMKNCDBJF(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	private static bool JBAMDOLDDMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void AMDPDOJMPBE(string BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void MKJNGNFLIDL(Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9BB0", Offset = "0x5CF89B0", VA = "0x185CF9BB0")]
	private static KBBDNOBKBGA ENBPJEOAOCL()
	{
		return default(KBBDNOBKBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310")]
	private static bool OMJJJLBMBCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9870", Offset = "0x5CF8670", VA = "0x185CF9870")]
	public void BPAIBICBBJL(object BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9720", Offset = "0x5CF8520", VA = "0x185CF9720")]
	public void BNJKOEGGPFA(object BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2044790", Offset = "0x2043590", VA = "0x182044790")]
	public void LPIFGLLPDKC(Exception GLNCBNFNGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9790", Offset = "0x5CF8590", VA = "0x185CF9790")]
	public void BNJKOEGGPFA(GGFDCIFAMKC BLAOEBOMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2421FD0", Offset = "0x2420DD0", VA = "0x182421FD0")]
	public void BNJKOEGGPFA<T>(T GIMGFOJNMGL, GGDNIKAAKOL<T> BLAOEBOMGGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2422090", Offset = "0x2420E90", VA = "0x182422090")]
	public void BPAIBICBBJL<T>([In] T GIMGFOJNMGL, FKIAJLDABJO<T> BLAOEBOMGGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF98E0", Offset = "0x5CF86E0", VA = "0x185CF98E0")]
	public bool DBFDEKBGBNE(bool FAKFOJBAANF, string BLAOEBOMGGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct LKJHNEGLGDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string CAGIMKNDHKH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	public LKJHNEGLGDH(string POACLGOFKAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00")]
	public static string KFCNDMGKJHB([In] LKJHNEGLGDH PECKHAMCEFO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12DD5A0", Offset = "0x12DC3A0", VA = "0x1812DD5A0")]
	public static LKJHNEGLGDH KFCNDMGKJHB(string LKMMHIOOCMN)
	{
		return default(LKJHNEGLGDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CFACB0", Offset = "0x5CF9AB0", VA = "0x185CFACB0")]
	public string OGDCPFBPIHC(string LKLGJOPBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CFABD0", Offset = "0x5CF99D0", VA = "0x185CFABD0")]
	public string CDLECKANOKK(object HLEOIHDHEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct NENNLMOAGAP : IEquatable<NENNLMOAGAP>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "4")]
	public bool Equals(NENNLMOAGAP LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CFADD0", Offset = "0x5CF9BD0", VA = "0x185CFADD0", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAE20", Offset = "0x5CF9C20", VA = "0x185CFAE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAE30", Offset = "0x5CF9C30", VA = "0x185CFAE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[NAFHHGBIDNI("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KBGKJDMAFMA<T> : IEquatable<KBGKJDMAFMA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T CAGIMKNDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool JJMGFPCANHM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JOEBBLIBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3892D00", Offset = "0x3891B00", VA = "0x183892D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3893EC0", Offset = "0x3892CC0", VA = "0x183893EC0")]
	public KBGKJDMAFMA([In] T POACLGOFKAJ, bool EHHHLLKBKEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x38938E0", Offset = "0x38926E0", VA = "0x1838938E0")]
	public static bool PNFEPLLEJJK([In] KBGKJDMAFMA<T> NLBDNIEIKMB, [In] KBGKJDMAFMA<T> NFFCMKPCJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3892D10", Offset = "0x3891B10", VA = "0x183892D10", Slot = "4")]
	public bool Equals(KBGKJDMAFMA<T> LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38931F0", Offset = "0x3891FF0", VA = "0x1838931F0", Slot = "0")]
	public override bool Equals(object LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3893580", Offset = "0x3892380", VA = "0x183893580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3893D40", Offset = "0x3892B40", VA = "0x183893D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IPLNGGHJFHG
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23ECA60", Offset = "0x23EB860", VA = "0x1823ECA60")]
	public static KBGKJDMAFMA<T> GMNCDAKOIHN<T>([In] T POACLGOFKAJ) where T : notnull
	{
		return default(KBGKJDMAFMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x23EC940", Offset = "0x23EB740", VA = "0x1823EC940")]
	public static KBGKJDMAFMA<T?> GBCCBCNKGFE<T>()
	{
		return default(KBGKJDMAFMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23EC840", Offset = "0x23EB640", VA = "0x1823EC840")]
	public static bool ADPLLBOPDAG<T>([In] this KBGKJDMAFMA<T> BDMPKJMMJKA, [Out][NotNullWhen(true)] T POACLGOFKAJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JHHNBNGKADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly OLNHDDDLCOG PAPPJFHDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly DPDGEPNKLHF PFNKFGBPCDO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OLNHDDDLCOG FJDGNLNBPHK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly DPDGEPNKLHF DCOCLFBGBBJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly JHHNBNGKADN HGIJALJPANA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5CF92B0", Offset = "0x5CF80B0", VA = "0x185CF92B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
	public JHHNBNGKADN(OLNHDDDLCOG LBPIGLIHFJB, DPDGEPNKLHF OHHAMBMIIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void KBOEHMMDJLP(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void APMMBJMFJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9370", Offset = "0x5CF8170", VA = "0x185CF9370")]
	private static JHHNBNGKADN ENBPJEOAOCL()
	{
		return default(JHHNBNGKADN);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class CPCJPJJFKND
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate bool EGMLKMNACCE<in TInput, TResult>(TInput KHNEEJJPNNH, [Out] TResult CGIMAKAECOA);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IBNEPDONABI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IBNEPDONABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x366DDF0", Offset = "0x366CBF0", VA = "0x18366DDF0")]
		internal void PBIHHNMHIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KAGBPMCGFOJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KAGBPMCGFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x388EFC0", Offset = "0x388DDC0", VA = "0x18388EFC0")]
		internal void PMAEEEKJEBJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct GCOOHKHNPKE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public EGMLKMNACCE<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x347C8B0", Offset = "0x347B6B0", VA = "0x18347C8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x347CFA0", Offset = "0x347BDA0", VA = "0x18347CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct NPJKMKHIGIH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CFAF80", Offset = "0x5CF9D80", VA = "0x185CFAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB180", Offset = "0x5CF9F80", VA = "0x185CFB180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7840", Offset = "0x5CF6640", VA = "0x185CF7840")]
	public static Task<TaskStatus> LHLLLDEAOJB(this Task PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x21F3F90", Offset = "0x21F2D90", VA = "0x1821F3F90")]
	public static Task<T> KLKBOHHIIMH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7930", Offset = "0x5CF6730", VA = "0x185CF7930")]
	public static Task MFPKNCMCDCH(this Task DPNKBPFBJPJ, CancellationToken EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x21F5980", Offset = "0x21F4780", VA = "0x1821F5980")]
	public static Task<TResult> MFPKNCMCDCH<TResult>(this Task<TResult> DPNKBPFBJPJ, CancellationToken EKDHBKMFLGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21F6170", Offset = "0x21F4F70", VA = "0x1821F6170")]
	public static TaskCompletionSource<TResult> MFPKNCMCDCH<TResult>(this TaskCompletionSource<TResult> AIJCFMOLNKB, CancellationToken EKDHBKMFLGI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x21F3E90", Offset = "0x21F2C90", VA = "0x1821F3E90")]
	[AsyncStateMachine(typeof(GCOOHKHNPKE<, >))]
	public static Task<List<TResult>> CBONEEOAGFJ<TResult, TInput>(this Task<List<TInput>> DPNKBPFBJPJ, EGMLKMNACCE<TInput, TResult> NLBNAPAMPOI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7840", Offset = "0x5CF6640", VA = "0x185CF7840")]
	[AsyncStateMachine(typeof(NPJKMKHIGIH))]
	[CompilerGenerated]
	internal static Task<TaskStatus> KPIMNJGDALC(Task LJFCFECDDJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IGPIEAGMJHM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	public IGPIEAGMJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ONCDIJIBJNG : LHBCOENPGKH
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LHBCOENPGKH IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime LDOLDFOLGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC110", Offset = "0x5CFAF10", VA = "0x185CFC110", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ONCDIJIBJNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LHBCOENPGKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime LDOLDFOLGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class ECHOLKCCPLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long OGLIBBDAEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8080", Offset = "0x5CF6E80", VA = "0x185CF8080")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long BJPDNHIMKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7CF0", Offset = "0x5CF6AF0", VA = "0x185CF7CF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double FLNOGGAHHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CF80D0", Offset = "0x5CF6ED0", VA = "0x185CF80D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double HHIHFAOLDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7CA0", Offset = "0x5CF6AA0", VA = "0x185CF7CA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double DGMKEGGLECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7DD0", Offset = "0x5CF6BD0", VA = "0x185CF7DD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double AMMBGBIKICH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7C50", Offset = "0x5CF6A50", VA = "0x185CF7C50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7E30", Offset = "0x5CF6C30", VA = "0x185CF7E30")]
	public static double JAFMNKALJIJ(long PCGGBKFBKNP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7D40", Offset = "0x5CF6B40", VA = "0x185CF7D40")]
	public static double GGPKLJCBPLE(long PCGGBKFBKNP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7FF0", Offset = "0x5CF6DF0", VA = "0x185CF7FF0")]
	public static double MEKCKCOHBDE(double ILGLALOBIPJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7BC0", Offset = "0x5CF69C0", VA = "0x185CF7BC0")]
	public static long AAANBFDIBCH(long NNDFFBJHCAM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7E20", Offset = "0x5CF6C20", VA = "0x185CF7E20")]
	public static long IMCNKLGKOLA(long BKPODOLEDDL, long DHPJEODEBFK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7F20", Offset = "0x5CF6D20", VA = "0x185CF7F20")]
	public static double LJMGGDKJGBN(long BKPODOLEDDL, long DHPJEODEBFK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7EC0", Offset = "0x5CF6CC0", VA = "0x185CF7EC0")]
	public static double JLONLPGFMLD(long BKPODOLEDDL, long DHPJEODEBFK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class ICDAJNDFNDC : CNPFPLFJHGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan PMHLCFJHKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer DNLFOGHCHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan PNDCNOOMJCC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan CPBEGICJHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8E20", Offset = "0x5CF7C20", VA = "0x185CF8E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? AKPDBBGAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9240", Offset = "0x5CF8040", VA = "0x185CF9240")]
	[Preserve]
	public ICDAJNDFNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8FF0", Offset = "0x5CF7DF0", VA = "0x185CF8FF0")]
	public ICDAJNDFNDC(TimeSpan PNDCNOOMJCC, [Optional] Action? EKBJKPLBBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8BB0", Offset = "0x5CF79B0", VA = "0x185CF8BB0", Slot = "7")]
	public void BAOEPALFJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8C40", Offset = "0x5CF7A40", VA = "0x185CF8C40", Slot = "8")]
	public void DAHDDFBEPKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8D50", Offset = "0x5CF7B50", VA = "0x185CF8D50", Slot = "9")]
	public void HIBINMOMJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xADE100", Offset = "0xADCF00", VA = "0x180ADE100")]
	private void BGGHDHABLKD(object KNIBDNLMNEE, ElapsedEventArgs FHDJOPONGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8D80", Offset = "0x5CF7B80", VA = "0x185CF8D80")]
	private static void IIGHBMJGNGN(TimeSpan GBDFPJALKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8CB0", Offset = "0x5CF7AB0", VA = "0x185CF8CB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class NAFHHGBIDNI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string PCFBCHGDHAN;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
	public NAFHHGBIDNI(string DCLCBHADCLP)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OEGJNBDIOLB : IEquatable<OEGJNBDIOLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint IOCDJBPLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int DOOBKAJGFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float KDHDMHJOJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort KHGOKOLNKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort IONIDCBFPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short EILJPKCIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short FNFLHHAAHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char IJINDDEFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char GBMIGMHFHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte JMNEKKNCIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte OFAEGENAJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte PHABIINCIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte ADDAKPANAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool BFLOCBMOHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool CFFLJHNODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool NLCBIICLPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool ICDDJOAIPNH;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBCA080", Offset = "0xBC8E80", VA = "0x180BCA080")]
	public static OEGJNBDIOLB CPBECFHNKFM(uint GDJOJKFPDNG)
	{
		return default(OEGJNBDIOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBCA080", Offset = "0xBC8E80", VA = "0x180BCA080")]
	public static OEGJNBDIOLB MBGPKFBCNPG(int LENBHEDBEKE)
	{
		return default(OEGJNBDIOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB310", Offset = "0x5CFA110", VA = "0x185CFB310")]
	public static OEGJNBDIOLB GEMGNGJICAD(float JCNONBCFIMI)
	{
		return default(OEGJNBDIOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB270", Offset = "0x5CFA070", VA = "0x185CFB270")]
	public static OEGJNBDIOLB IPIAPDIMJKG(byte GONIPDLJCMJ, byte PCBFEJFFOMJ, byte AAEPJNGFBCH, byte OCLAKKKIJGG)
	{
		return default(OEGJNBDIOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB270", Offset = "0x5CFA070", VA = "0x185CFB270")]
	public static OEGJNBDIOLB DIJKNJFCMFP(bool LMGFCBJGAJE, bool EBGOJDMLLLA, bool IDFGMPDMFDE, bool NAMNCNDDEKI)
	{
		return default(OEGJNBDIOLB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1643830", Offset = "0x1642630", VA = "0x181643830")]
	public static bool PNFEPLLEJJK(OEGJNBDIOLB MNLOCDHFJKE, OEGJNBDIOLB CHEKOKJNNFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1643810", Offset = "0x1642610", VA = "0x181643810", Slot = "4")]
	public bool Equals(OEGJNBDIOLB LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB290", Offset = "0x5CFA090", VA = "0x185CFB290", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAF0", Offset = "0x7EE8F0", VA = "0x1807EFAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB320", Offset = "0x5CFA120", VA = "0x185CFB320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DOAJFPFECOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong JGBCOIDPPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long GFFEMPJGHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double KJMEAOABIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint EIPJKMPPFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint HGKECAFCPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int CDKILGMADDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int JOIGKONLNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float GICOFFGIICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float GMAOAKBBEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort KHGOKOLNKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort IONIDCBFPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort CPEBLMNAFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort DJFLDEOMIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short EILJPKCIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short FNFLHHAAHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short FDENOOHBNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short BMPIDHPOJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char IJINDDEFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char GBMIGMHFHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char NIAEKDAHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char NCCDAOIHGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte JMNEKKNCIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte OFAEGENAJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PHABIINCIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte ADDAKPANAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte CEDCIDJLBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte MPGBEEAJJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte JOLIEKHBCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte PDLEADPNOIL;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7B70", Offset = "0x5CF6970", VA = "0x185CF7B70")]
	public static DOAJFPFECOM IGHHFGMBDIH(byte GONIPDLJCMJ, byte PCBFEJFFOMJ, byte AAEPJNGFBCH, byte OCLAKKKIJGG, byte EBEDFFFDFEA, byte JLOKCFOIHIA, byte GNBCOPLHKFI, byte HLKINJODIAH)
	{
		return default(DOAJFPFECOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MBFPLGELJAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2459690", Offset = "0x2458490", VA = "0x182459690")]
	public static IEnumerable<T> OJEAKPFJHJC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static T[] KJODLDIFIBA<T>(params T[] COFDACJCGKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static IEnumerable<T> KHMNJLLKMPE<T>(params T[] COFDACJCGKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x21EE400", Offset = "0x21ED200", VA = "0x1821EE400")]
	public static HashSet<T> GJFLCBPIBBI<T>(params T[] COFDACJCGKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x246C580", Offset = "0x246B380", VA = "0x18246C580")]
	public static KeyValuePair<TKey, TValue> GBBBBNPGPDJ<TKey, TValue>([In] TKey GMOPMNAPKBE, [In] TValue POACLGOFKAJ) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x21EE400", Offset = "0x21ED200", VA = "0x1821EE400")]
	public static List<T> FKJHFOIICOK<T>(IEnumerable<T> DNHCBADCFIB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.All)]
public sealed class IFHOCEFKBAP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string KBIIAOGPLOK;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
	public IFHOCEFKBAP(string NCEKPMLHDJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HEAHJNLDHCB
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class IAGOFKEPHAK<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int GJPDNICHPHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3667880", Offset = "0x3666680", VA = "0x183667880", Slot = "4")]
		public bool Add(T LCDPCJGMPFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LKMMHIOOCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3667A20", Offset = "0x3666820", VA = "0x183667A20", Slot = "5")]
		public void UnionWith(IEnumerable<T> LKMMHIOOCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x36679C0", Offset = "0x36667C0", VA = "0x1836679C0", Slot = "9")]
		void ICollection<T>.Add(T LCDPCJGMPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "11")]
		public bool Contains(T LCDPCJGMPFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "12")]
		public void CopyTo(T[] OBEMKDLNKLE, int EMKJLDKBBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
		public bool Remove(T LCDPCJGMPFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x36678E0", Offset = "0x36666E0", VA = "0x1836678E0", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3404470", Offset = "0x3403270", VA = "0x183404470", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IAGOFKEPHAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8320", VA = "0x1807C9520")]
	public static ISet<T> PJEFIELFGNE<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LJIIBFNPIKB]
public delegate void OLNHDDDLCOG(string MEBBBIMBIJO);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[LJIIBFNPIKB]
public delegate void DPDGEPNKLHF();
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object FKIAJLDABJO<T>([In] T MEALCFKPKME);
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object GGDNIKAAKOL<T>(T MEALCFKPKME);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[LJIIBFNPIKB]
public delegate string JOALPAJANDL(string MNCMCPLICPL, string? KMMHDHGBEMH, bool OODOFCFFLPB);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[LJIIBFNPIKB]
public delegate void CCCDCHGJCKH(string BLAOEBOMGGP);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[LJIIBFNPIKB]
public delegate void IIDJBEECHCF(Exception GLNCBNFNGKL);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate object GGFDCIFAMKC();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[LJIIBFNPIKB]
public delegate bool HMGOECLLDCG();
[Cpp2IlInjected.Token(Token = "0x200003D")]
[LJIIBFNPIKB]
public delegate string PDMDANOIFLH(object DGPHOMINFCK);
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
