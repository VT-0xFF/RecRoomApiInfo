using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6184E50", Offset = "0x6183C50", VA = "0x186184E50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class EGBDAKJKPPH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x617DC30", Offset = "0x617CA30", VA = "0x18617DC30")]
	public EGBDAKJKPPH(bool ABBIMEDHEBP, string NKALGMMDECH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EJICLLLCHGE<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> MJPAOMJIEIO(CancellationToken MBHHHCCHBAO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EKOOFCBIMEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public EJICLLLCHGE<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MJPAOMJIEIO taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x32A72F0", Offset = "0x32A60F0", VA = "0x1832A72F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x32A82A0", Offset = "0x32A70A0", VA = "0x1832A82A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource LNBKFFEFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? EANPMPNBGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? BMPCAENAPEG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x329C1F0", Offset = "0x329AFF0", VA = "0x18329C1F0")]
	[AsyncStateMachine(typeof(EJICLLLCHGE<>.EKOOFCBIMEA))]
	public Task<TResult> BCJNNMCDFPG(MJPAOMJIEIO AGIBKKMNNGA, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x329C330", Offset = "0x329B130", VA = "0x18329C330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x329C3A0", Offset = "0x329B1A0", VA = "0x18329C3A0")]
	public EJICLLLCHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CGDGPGFPFNA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> KFPAGHPFCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T CIONEDGAKHL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2650", Offset = "0x3EE1450", VA = "0x183EE2650")]
	public CGDGPGFPFNA([In] T MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C606E0", Offset = "0x4C5F4E0", VA = "0x184C606E0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4C60C40", Offset = "0x4C5FA40", VA = "0x184C60C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C60E20", Offset = "0x4C5FC20", VA = "0x184C60E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LKONPDBMKBI
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6183780", Offset = "0x6182580", VA = "0x186183780")]
	public static void GMGAKNFKJAH(this CancellationTokenSource LNBKFFEFFCN, bool BFJCPMNNPDB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class DJMCOCAEBCL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
	public DJMCOCAEBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class LMBEPMMPKGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
	public LMBEPMMPKGL(string POFOJFFDBNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BGMFEOGKCFF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25192A0", Offset = "0x25180A0", VA = "0x1825192A0")]
	public static FEJHELBEDPI OGCGJFLBEKA<T>()
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2519070", Offset = "0x2517E70", VA = "0x182519070")]
	public static FEJHELBEDPI JFAMKPPHEBB<T>([CallerMemberName] string OCCHBLONHPL = "") where T : notnull
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2519320", Offset = "0x2518120", VA = "0x182519320")]
	public static FEJHELBEDPI OGCGJFLBEKA<T>(this T FGIPEOJEGND) where T : notnull
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2518EF0", Offset = "0x2517CF0", VA = "0x182518EF0")]
	public static FEJHELBEDPI AOGINHCAING<T>(this T FGIPEOJEGND, [CallerMemberName] string OCCHBLONHPL = "") where T : notnull
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2519100", Offset = "0x2517F00", VA = "0x182519100")]
	public static FEJHELBEDPI JFAMKPPHEBB<T>(this T OELHNDCFEMO, [CallerMemberName] string OCCHBLONHPL = "") where T : notnull
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x617CBE0", Offset = "0x617B9E0", VA = "0x18617CBE0")]
	public static FEJHELBEDPI JFAMKPPHEBB(string LFBHBNOJPOO, [CallerMemberName] string OCCHBLONHPL = "")
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x617CB40", Offset = "0x617B940", VA = "0x18617CB40")]
	public static string EPKKECIKPFE(this object OELHNDCFEMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool OMCIKEMPDOE();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DJMCOCAEBCL]
public delegate long BDCAAPDLNDO();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CBIOCIEOPAF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JEALLAOMGEN ENPDPOKKKBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JEALLAOMGEN KINCAGGLJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x617D2A0", Offset = "0x617C0A0", VA = "0x18617D2A0")]
		get
		{
			return default(JEALLAOMGEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BBAEOFJIABF AMPNDJIJEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x617D250", Offset = "0x617C050", VA = "0x18617D250")]
		get
		{
			return default(BBAEOFJIABF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JMFEBOEDDND IJLIDIEDGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x617CC60", Offset = "0x617BA60", VA = "0x18617CC60")]
		get
		{
			return default(JMFEBOEDDND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool KPFFFAIFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x617D2F0", Offset = "0x617C0F0", VA = "0x18617D2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x617D0A0", Offset = "0x617BEA0", VA = "0x18617D0A0")]
	public static void KDFBEGJFPLI([In] JEALLAOMGEN NHKJNCDCGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x617CFD0", Offset = "0x617BDD0", VA = "0x18617CFD0")]
	public static void INBEFCGIFMO(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x617D360", Offset = "0x617C160", VA = "0x18617D360")]
	public static void OELCGMCOLOC(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x258A0E0", Offset = "0x2588EE0", VA = "0x18258A0E0")]
	public static void OELCGMCOLOC<T>(T ILCDOKLHIEO, JHJKPLJOAFF<T> LJCDGDONMLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x617D430", Offset = "0x617C230", VA = "0x18617D430")]
	public static void PKKPILHAEDM(Exception IAOBDGOKOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x617CF70", Offset = "0x617BD70", VA = "0x18617CF70")]
	public static void IJDIEKBIIGC(string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x617CE90", Offset = "0x617BC90", VA = "0x18617CE90")]
	public static void EJGNACEHENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x617CEF0", Offset = "0x617BCF0", VA = "0x18617CEF0")]
	public static string EPKKECIKPFE(object KDHDNCADFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x617CE20", Offset = "0x617BC20", VA = "0x18617CE20")]
	public static long CPKBNHOAODE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x617CD80", Offset = "0x617BB80", VA = "0x18617CD80")]
	public static bool CKDACGBEFJJ(bool JMNEIEPOGFE, string LJCDGDONMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x617CCB0", Offset = "0x617BAB0", VA = "0x18617CCB0")]
	public static double BDDALKENKHH()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JEALLAOMGEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly BBAEOFJIABF AMPNDJIJEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly JMFEBOEDDND IJLIDIEDGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly JCPHGJEFHOO EEKODCBBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly BDCAAPDLNDO DEGJGNEHJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly ANFBGEJMKHG KMBHJILOMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly OMCIKEMPDOE GEGGPIMKNCG;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly JCPHGJEFHOO PBHLCNGNHHG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly BDCAAPDLNDO FDEMKLEFNGP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ANFBGEJMKHG LBDJGKPGCMD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OMCIKEMPDOE OJMCDHIIMIK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JEALLAOMGEN DGHDBBJHGGP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6180550", Offset = "0x617F350", VA = "0x186180550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6180EF0", Offset = "0x617FCF0", VA = "0x186180EF0")]
	public JEALLAOMGEN([In] BBAEOFJIABF LBJOCMNOEKK, [In] JMFEBOEDDND EHGKPNPPIEM, JCPHGJEFHOO PKDHKNPGAKP, BDCAAPDLNDO JENMGMEMPKP, ANFBGEJMKHG EJAEDKFBCEF, OMCIKEMPDOE NANOEGHMDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6180510", Offset = "0x617F310", VA = "0x186180510")]
	private static string CGMEIPLNJBK(object KDHDNCADFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0")]
	private static long DNHHOCFPOKL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	private static string MABEOPMKDBA(string OMFBJPLNJIJ, string? POBAGCACOMM, bool FNOGILPPALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	private static bool AONCIKAEHIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61806F0", Offset = "0x617F4F0", VA = "0x1861806F0")]
	private static JEALLAOMGEN FDLPKCMHJBH()
	{
		return default(JEALLAOMGEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MEEKACANJDN
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHJKCPPBGCM LFGLJKELEJI();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHJKCPPBGCM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KBJHNICODFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFMAKNCCPPE();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CFGACMJPKMC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOFBAKIJPFH([In] T EDOEJIMPOFP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JGAJPGPPLBP<T>([In] T ILCDOKLHIEO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FJDMIIGNGBN<T> : IEquatable<FJDMIIGNGBN<T>>, CFGACMJPKMC<FJDMIIGNGBN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T CIONEDGAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int LNBHMBDGGMM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBF190", Offset = "0x1DBDF90", VA = "0x181DBF190")]
	public FJDMIIGNGBN([In] T MAEBFBHFPDE, int OHINPGIGDNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3611CA0", Offset = "0x3610AA0", VA = "0x183611CA0")]
	public static bool EILLJGMDDAM([In] FJDMIIGNGBN<T> LDPIALBNJEB, [In] FJDMIIGNGBN<T> HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3612830", Offset = "0x3611630", VA = "0x183612830", Slot = "4")]
	public bool Equals(FJDMIIGNGBN<T> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36127B0", Offset = "0x36115B0", VA = "0x1836127B0", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3611A70", Offset = "0x3610870", VA = "0x183611A70")]
	public bool BOFBAKIJPFH([In] FJDMIIGNGBN<T> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3612980", Offset = "0x3611780", VA = "0x183612980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3612DD0", Offset = "0x3611BD0", VA = "0x183612DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3612270", Offset = "0x3611070", VA = "0x183612270")]
	public void ELPMHLPMEKH([Out] T MAEBFBHFPDE, [Out] int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3611910", Offset = "0x3610710", VA = "0x183611910")]
	public (T, int) BLNAPIDKLNK()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3612930", Offset = "0x3611730", VA = "0x183612930", Slot = "5")]
	private bool FNJACFAAGEH([In] FJDMIIGNGBN<T> EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OMBJPFLCIPC
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28A45D0", Offset = "0x28A33D0", VA = "0x1828A45D0")]
	public static FJDMIIGNGBN<T> IKCDCJJCDKO<T>([In] T MAEBFBHFPDE, int OHINPGIGDNE) where T : notnull
	{
		return default(FJDMIIGNGBN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GFDPGLKOOHA
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x273CFE0", Offset = "0x273BDE0", VA = "0x18273CFE0")]
	public static bool BOFBAKIJPFH<T, U>([In] T OELHNDCFEMO, [In] U KDHDNCADFDJ) where T : notnull, CFGACMJPKMC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult NKFOPCDNGGF<T, out TResult>([In] T ILCDOKLHIEO);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DIGACHNLABI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan MLPJJGGLJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? MOCGGHKCPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPLLGBFFFEM();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BCCFMKHLPBC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLCNKMBDPEN();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct BBAEOFJIABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MBCCAECKELG PMMINGOPNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FMDLKALABCD GCOIFLLAPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly MBCCAECKELG EJJIMNKMDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly FMDLKALABCD BEGGBFAJIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly MBCCAECKELG MFEGKCLKNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly FMDLKALABCD ENOCDEMDKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FEEPKJOEIFC HFKPCAJOHCC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly MBCCAECKELG LDDOMIIOBLE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly FMDLKALABCD GFFOFAPABJB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly MBCCAECKELG GFGJHEBBIJK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly FMDLKALABCD GKIHMNHANJM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly MBCCAECKELG ADGEHJHJFPG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly FMDLKALABCD NFNFNEFDOAK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FEEPKJOEIFC DDHPEIJOJHN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BBAEOFJIABF DGHDBBJHGGP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MBCCAECKELG GBMMAGLKJGI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x617BCB0", Offset = "0x617AAB0", VA = "0x18617BCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9BF0E0", Offset = "0x9BDEE0", VA = "0x1809BF0E0")]
	public BBAEOFJIABF(MBCCAECKELG MIAAFJKEKKA, FMDLKALABCD KGALAHBOLOE, MBCCAECKELG EODFNADJMJA, FMDLKALABCD PDANKEDJJIC, MBCCAECKELG JGPIOAAJANB, FMDLKALABCD IIPGKMONBCN, FEEPKJOEIFC IBFHPINKFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	private static bool IDMKMABICPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void HCNDODEECLL(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	private static bool EAEHLJLANMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void OIGPBPPHNEM(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	private static bool IDKBEPLIHGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void EPAGAEOACNL(string LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void IOPGLBNPDIB(Exception IAOBDGOKOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x617BF80", Offset = "0x617AD80", VA = "0x18617BF80")]
	private static BBAEOFJIABF FDLPKCMHJBH()
	{
		return default(BBAEOFJIABF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310")]
	private static bool JLCDDFGMDNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x617C0C0", Offset = "0x617AEC0", VA = "0x18617C0C0")]
	public void INBEFCGIFMO(object LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x617C130", Offset = "0x617AF30", VA = "0x18617C130")]
	public void OELCGMCOLOC(object LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1979DD0", Offset = "0x1978BD0", VA = "0x181979DD0")]
	public void PKKPILHAEDM(Exception IAOBDGOKOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x617C1A0", Offset = "0x617AFA0", VA = "0x18617C1A0")]
	public void OELCGMCOLOC(MBHHNOAEPJI LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2508260", Offset = "0x2507060", VA = "0x182508260")]
	public void OELCGMCOLOC<T>(T ILCDOKLHIEO, JHJKPLJOAFF<T> LJCDGDONMLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x25080E0", Offset = "0x2506EE0", VA = "0x1825080E0")]
	public void INBEFCGIFMO<T>([In] T ILCDOKLHIEO, HCEIPMENKMB<T> LJCDGDONMLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x617BEB0", Offset = "0x617ACB0", VA = "0x18617BEB0")]
	public bool CKDACGBEFJJ(bool JMNEIEPOGFE, string LJCDGDONMLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FEJHELBEDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string CIONEDGAKHL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	public FEJHELBEDPI(string MAEBFBHFPDE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0")]
	public static string CCJKPBOFOJB([In] FEJHELBEDPI OELHNDCFEMO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x147DD40", Offset = "0x147CB40", VA = "0x18147DD40")]
	public static FEJHELBEDPI CCJKPBOFOJB(string EDOEJIMPOFP)
	{
		return default(FEJHELBEDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x617E030", Offset = "0x617CE30", VA = "0x18617E030")]
	public string HJAGMAGJAJL(string LOCINIADGEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x617E080", Offset = "0x617CE80", VA = "0x18617E080")]
	public string JEBKJOLEODG(object KJOKICDNNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct CFLPFJJKMFI : IEquatable<CFLPFJJKMFI>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "4")]
	public bool Equals(CFLPFJJKMFI EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x617D590", Offset = "0x617C390", VA = "0x18617D590", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x617D5E0", Offset = "0x617C3E0", VA = "0x18617D5E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x617D5F0", Offset = "0x617C3F0", VA = "0x18617D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[PMMFACMNNCA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BAAANDEIBME<T> : IEquatable<BAAANDEIBME<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T CIONEDGAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool HKFBPEGCGIE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FPFLAEIDEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4742C70", Offset = "0x4741A70", VA = "0x184742C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4743380", Offset = "0x4742180", VA = "0x184743380")]
	public BAAANDEIBME([In] T MAEBFBHFPDE, bool KPKHJPBCKJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47421C0", Offset = "0x4740FC0", VA = "0x1847421C0")]
	public static bool EILLJGMDDAM([In] BAAANDEIBME<T> LDPIALBNJEB, [In] BAAANDEIBME<T> HLCIAKLFNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3612830", Offset = "0x3611630", VA = "0x183612830", Slot = "4")]
	public bool Equals(BAAANDEIBME<T> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4742530", Offset = "0x4741330", VA = "0x184742530", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4742F00", Offset = "0x4741D00", VA = "0x184742F00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4743060", Offset = "0x4741E60", VA = "0x184743060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FPJINLNEEPM
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2737270", Offset = "0x2736070", VA = "0x182737270")]
	public static BAAANDEIBME<T> KEGAJFHKDPG<T>([In] T MAEBFBHFPDE) where T : notnull
	{
		return default(BAAANDEIBME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2737410", Offset = "0x2736210", VA = "0x182737410")]
	public static BAAANDEIBME<T?> MPPDHBIFNCP<T>()
	{
		return default(BAAANDEIBME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27372D0", Offset = "0x27360D0", VA = "0x1827372D0")]
	public static bool MHPFIHFMNMA<T>([In] this BAAANDEIBME<T> PDOHHABHFAB, [Out][NotNullWhen(true)] T MAEBFBHFPDE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JMFEBOEDDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr IJDIEKBIIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr EJGNACEHENE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr HNAHIIBFLKK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr PLMPMJDPDMG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly JMFEBOEDDND DGHDBBJHGGP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6182B80", Offset = "0x6181980", VA = "0x186182B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8F0EC0", Offset = "0x8EFCC0", VA = "0x1808F0EC0")]
	public JMFEBOEDDND(IntPtr FPBJFGLKLCG, IntPtr DGJFOBONAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void MEMBIDEOKGC(string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
	private static void MMMMFKECFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6182C60", Offset = "0x6181A60", VA = "0x186182C60")]
	private static JMFEBOEDDND FDLPKCMHJBH()
	{
		return default(JMFEBOEDDND);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct HBGJOBOPAGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr FCAHGBACDAN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9288D0", Offset = "0x9276D0", VA = "0x1809288D0")]
	private HBGJOBOPAGC(IntPtr DGJFOBONAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x617E990", Offset = "0x617D790", VA = "0x18617E990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x617E9A0", Offset = "0x617D7A0", VA = "0x18617E9A0")]
	public static HBGJOBOPAGC IKCDCJJCDKO(string OCCHBLONHPL)
	{
		return default(HBGJOBOPAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAF90", Offset = "0x1DA9D90", VA = "0x181DAAF90")]
	public static HBGJOBOPAGC IKCDCJJCDKO([In] JMFEBOEDDND EHGKPNPPIEM, string OCCHBLONHPL)
	{
		return default(HBGJOBOPAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB630", Offset = "0x1DAA430", VA = "0x181DAB630")]
	public static HBGJOBOPAGC IKCDCJJCDKO([In] JMFEBOEDDND EHGKPNPPIEM, Func<string> OCCHBLONHPL)
	{
		return default(HBGJOBOPAGC);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JGMNIHJFCCP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool BKAPOICNEDK<in TInput, TResult>(TInput PMNEDIFJMIN, [Out] TResult ELGNBNFKLLL);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class GIAPJLOOAFN : MEEKACANJDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class MKILNMMNHBC : NHJKCPPBGCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly MKILNMMNHBC ACHMAPLCKNO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool KBJHNICODFG
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x61840A0", Offset = "0x6182EA0", VA = "0x1861840A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6184100", Offset = "0x6182F00", VA = "0x186184100", Slot = "6")]
			public void OnCompleted(Action JEILKJHGDHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			public void OFMAKNCCPPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public MKILNMMNHBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GIAPJLOOAFN ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private GIAPJLOOAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x617E8C0", Offset = "0x617D6C0", VA = "0x18617E8C0", Slot = "4")]
		public NHJKCPPBGCM LFGLJKELEJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class GGLGJKCDLCE : MEEKACANJDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class OIFLHFFJDKI : NHJKCPPBGCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly OIFLHFFJDKI ACHMAPLCKNO;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool KBJHNICODFG
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6185110", Offset = "0x6183F10", VA = "0x186185110", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6185130", Offset = "0x6183F30", VA = "0x186185130", Slot = "6")]
			public void OnCompleted(Action JEILKJHGDHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			public void OFMAKNCCPPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public OIFLHFFJDKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly GGLGJKCDLCE ACHMAPLCKNO;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private GGLGJKCDLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x617E7F0", Offset = "0x617D5F0", VA = "0x18617E7F0", Slot = "4")]
		public NHJKCPPBGCM LFGLJKELEJI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class COGELEADEKC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public COGELEADEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x35F81C0", Offset = "0x35F6FC0", VA = "0x1835F81C0")]
		internal void JBIHMAEABMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JLDMJCOMOJG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public JLDMJCOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FE70", Offset = "0x3A6EC70", VA = "0x183A6FE70")]
		internal void IMLCJAOKALP(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HEFGBGCKLLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x617EA90", Offset = "0x617D890", VA = "0x18617EA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x999640", Offset = "0x998440", VA = "0x180999640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KKHAPDCNJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6182E40", Offset = "0x6181C40", VA = "0x186182E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x999640", Offset = "0x998440", VA = "0x180999640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PFJONAHNMNO<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40A24A0", Offset = "0x40A12A0", VA = "0x1840A24A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40A2610", Offset = "0x40A1410", VA = "0x1840A2610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PMIMGAMCNNG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40B99A0", Offset = "0x40B87A0", VA = "0x1840B99A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x40BA210", Offset = "0x40B9010", VA = "0x1840BA210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BDFCBBFDFJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x617C860", Offset = "0x617B660", VA = "0x18617C860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x617CA60", Offset = "0x617B860", VA = "0x18617CA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FELAHNOCMAP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public FELAHNOCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x35F81C0", Offset = "0x35F6FC0", VA = "0x1835F81C0")]
		internal void MJNMLPEPLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x35F8160", Offset = "0x35F6F60", VA = "0x1835F8160")]
		internal void DDHNEBBPCHA(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BGNHFPFKHNE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BKAPOICNEDK<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x477A650", Offset = "0x4779450", VA = "0x18477A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x477AD40", Offset = "0x4779B40", VA = "0x18477AD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct IDHDDLBEOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x617EBF0", Offset = "0x617D9F0", VA = "0x18617EBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x617F3E0", Offset = "0x617E1E0", VA = "0x18617F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LNMMKGNNGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61837B0", Offset = "0x61825B0", VA = "0x1861837B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6183CF0", Offset = "0x6182AF0", VA = "0x186183CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct OAFACKDPBEG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3FA9BF0", Offset = "0x3FA89F0", VA = "0x183FA9BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x370A3E0", Offset = "0x37091E0", VA = "0x18370A3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NOLNOCBBLDK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F01330", Offset = "0x3F00130", VA = "0x183F01330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x329BA20", Offset = "0x329A820", VA = "0x18329BA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LGKFJJNMFMI<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C00AF0", Offset = "0x3BFF8F0", VA = "0x183C00AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C017C0", Offset = "0x3C005C0", VA = "0x183C017C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DIOGPEDBOJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x617D9F0", Offset = "0x617C7F0", VA = "0x18617D9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x617DBD0", Offset = "0x617C9D0", VA = "0x18617DBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct CPNLIFMAHOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x617D620", Offset = "0x617C420", VA = "0x18617D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x617D990", Offset = "0x617C790", VA = "0x18617D990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PCBALOMHMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6185200", Offset = "0x6184000", VA = "0x186185200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61854F0", Offset = "0x61842F0", VA = "0x1861854F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EIIIACABOMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public EIIIACABOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x617DD00", Offset = "0x617CB00", VA = "0x18617DD00")]
		internal Task OPFNMEBEGIP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GBJGELBLPJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x617E160", Offset = "0x617CF60", VA = "0x18617E160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x617E3C0", Offset = "0x617D1C0", VA = "0x18617E3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OCIADLKMOCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6184ED0", Offset = "0x6183CD0", VA = "0x186184ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61850B0", Offset = "0x6183EB0", VA = "0x1861850B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GGEMAKIODNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x617E420", Offset = "0x617D220", VA = "0x18617E420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x617E790", Offset = "0x617D590", VA = "0x18617E790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MIPHPBBHJNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6183D50", Offset = "0x6182B50", VA = "0x186183D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6184040", Offset = "0x6182E40", VA = "0x186184040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BFKIOCLPKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public BFKIOCLPKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x617CAD0", Offset = "0x617B8D0", VA = "0x18617CAD0")]
		internal Task ACIJDDBJKCI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct FDDPCMLAHOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x617DD70", Offset = "0x617CB70", VA = "0x18617DD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x617DFD0", Offset = "0x617CDD0", VA = "0x18617DFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IEHDBBKNJGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x617F440", Offset = "0x617E240", VA = "0x18617F440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x617F5C0", Offset = "0x617E3C0", VA = "0x18617F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BALKNLAHPJN<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x474B640", Offset = "0x474A440", VA = "0x18474B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x474B8A0", Offset = "0x474A6A0", VA = "0x18474B8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NELKELBNJCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x61842E0", Offset = "0x61830E0", VA = "0x1861842E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61846F0", Offset = "0x61834F0", VA = "0x1861846F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? MJINGOAABCP;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<CFLPFJJKMFI> ANPDPGCCHDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task OPNBIHBFOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6181150", Offset = "0x617FF50", VA = "0x186181150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61818D0", Offset = "0x61806D0", VA = "0x1861818D0")]
	public static bool FIINHLFMJIM(this Task NPDMMHKHJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x27A6FF0", Offset = "0x27A5DF0", VA = "0x1827A6FF0")]
	public static Task<T> OIHJOCELMKD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6181EE0", Offset = "0x6180CE0", VA = "0x186181EE0")]
	public static Task JGGFDHHJPOC(this Task NPDMMHKHJDL, CancellationToken BNAJMHPOOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27A5C20", Offset = "0x27A4A20", VA = "0x1827A5C20")]
	public static Task<TResult> JGGFDHHJPOC<TResult>(this Task<TResult> NPDMMHKHJDL, CancellationToken BNAJMHPOOCG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x27A6740", Offset = "0x27A5540", VA = "0x1827A6740")]
	public static TaskCompletionSource<TResult> JGGFDHHJPOC<TResult>(this TaskCompletionSource<TResult> KKPEIDAJNKJ, CancellationToken BNAJMHPOOCG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6181B80", Offset = "0x6180980", VA = "0x186181B80")]
	[AsyncStateMachine(typeof(HEFGBGCKLLM))]
	public static void HNHNAGELFKI(this Task BHBDNAGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6181E30", Offset = "0x6180C30", VA = "0x186181E30")]
	[AsyncStateMachine(typeof(KKHAPDCNJMJ))]
	public static void IHENMCEOMOA(this Task BHBDNAGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27A3DD0", Offset = "0x27A2BD0", VA = "0x1827A3DD0")]
	[AsyncStateMachine(typeof(PFJONAHNMNO<>))]
	public static Task FJPKJBMFNBI<TException>(this Task BHBDNAGLKEL) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27A3950", Offset = "0x27A2750", VA = "0x1827A3950")]
	[AsyncStateMachine(typeof(PMIMGAMCNNG<>))]
	public static Task<T> BLGCKJFGHCI<T>(this Task<T> OELHNDCFEMO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6181A90", Offset = "0x6180890", VA = "0x186181A90")]
	[AsyncStateMachine(typeof(BDFCBBFDFJK))]
	public static Task<TaskStatus> HJPKHHPJIBL(this Task OELHNDCFEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27A3EA0", Offset = "0x27A2CA0", VA = "0x1827A3EA0")]
	public static (Task<T?>?, Action<T?>?) JBLALOLBICB<T>([Optional] CancellationToken MBHHHCCHBAO)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27A3CD0", Offset = "0x27A2AD0", VA = "0x1827A3CD0")]
	[AsyncStateMachine(typeof(BGNHFPFKHNE<, >))]
	public static Task<List<TResult>> EGGBIKJJIDN<TResult, TInput>(this Task<List<TInput>> NPDMMHKHJDL, BKAPOICNEDK<TInput, TResult> IJENIILMAFL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6180FA0", Offset = "0x617FDA0", VA = "0x186180FA0")]
	[AsyncStateMachine(typeof(IDHDDLBEOCF))]
	public static Task AEHHLDDMGMJ(Task BHBDNAGLKEL, CancellationToken HOOCIOKDKAL, Func<CancellationToken, Task> ODCMNNLLJGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6182720", Offset = "0x6181520", VA = "0x186182720")]
	[AsyncStateMachine(typeof(LNMMKGNNGPK))]
	public static Task OGICADPPFIP(Func<CancellationToken, Task> MEDDOFNOEDB, TimeSpan BPIIOFNDDAL, [Optional] CancellationToken HOOCIOKDKAL, [Optional] Action<OperationCanceledException>? KABIFBFKOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27A6EC0", Offset = "0x27A5CC0", VA = "0x1827A6EC0")]
	[AsyncStateMachine(typeof(OAFACKDPBEG<>))]
	public static Task<T> OGICADPPFIP<T>(Func<CancellationToken, Task<T>> MEDDOFNOEDB, TimeSpan BPIIOFNDDAL, [Optional] CancellationToken HOOCIOKDKAL, [Optional] Func<OperationCanceledException, T>? KABIFBFKOBL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27A3BF0", Offset = "0x27A29F0", VA = "0x1827A3BF0")]
	[AsyncStateMachine(typeof(NOLNOCBBLDK<>))]
	public static Task<IEnumerable<Task<T>>> DNFJLICMJHF<T>(IEnumerable<Task<T>> ONIDCBCFEPJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27A7140", Offset = "0x27A5F40", VA = "0x1827A7140")]
	[AsyncStateMachine(typeof(LGKFJJNMFMI<, , , >))]
	public static Task<(T1, T2, T3, T4)> OKMEOIMPFLE<T1, T2, T3, T4>(Task<T1> EMGIOOKCOCI, Task<T2> JCEKOKIHGCA, Task<T3> CJKNBNNBBMG, Task<T4> CIPBODBPHEN) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6181D40", Offset = "0x6180B40", VA = "0x186181D40")]
	[AsyncStateMachine(typeof(DIOGPEDBOJC))]
	public static Task HPNPEOBNIEK(Func<bool> JMNEIEPOGFE, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6181C30", Offset = "0x6180A30", VA = "0x186181C30")]
	[AsyncStateMachine(typeof(CPNLIFMAHOF))]
	public static Task HPNPEOBNIEK(Func<bool> JMNEIEPOGFE, TimeSpan NBJGPJACBML, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6182990", Offset = "0x6181790", VA = "0x186182990")]
	[AsyncStateMachine(typeof(PCBALOMHMOI))]
	public static Task PLGHIMKKFEM(Func<bool> JMNEIEPOGFE, TimeSpan BPIIOFNDDAL, [Optional] CancellationToken MBHHHCCHBAO, [Optional] Action<OperationCanceledException>? KABIFBFKOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6182850", Offset = "0x6181650", VA = "0x186182850")]
	[AsyncStateMachine(typeof(GBJGELBLPJI))]
	public static Task PLGHIMKKFEM(Func<bool> JMNEIEPOGFE, TimeSpan BPIIOFNDDAL, TimeSpan NBJGPJACBML, [Optional] CancellationToken MBHHHCCHBAO, [Optional] Action<OperationCanceledException>? KABIFBFKOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6181520", Offset = "0x6180320", VA = "0x186181520")]
	[AsyncStateMachine(typeof(OCIADLKMOCK))]
	public static Task DPAICCGEFHB(Func<bool> JMNEIEPOGFE, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6181410", Offset = "0x6180210", VA = "0x186181410")]
	[AsyncStateMachine(typeof(GGEMAKIODNO))]
	public static Task DPAICCGEFHB(Func<bool> JMNEIEPOGFE, TimeSpan NBJGPJACBML, [Optional] CancellationToken MBHHHCCHBAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6181660", Offset = "0x6180460", VA = "0x186181660")]
	[AsyncStateMachine(typeof(MIPHPBBHJNM))]
	public static Task FGDHJMCHAGL(Func<bool> JMNEIEPOGFE, TimeSpan BPIIOFNDDAL, [Optional] CancellationToken MBHHHCCHBAO, [Optional] Action<OperationCanceledException>? KABIFBFKOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6181790", Offset = "0x6180590", VA = "0x186181790")]
	[AsyncStateMachine(typeof(FDDPCMLAHOI))]
	public static Task FGDHJMCHAGL(Func<bool> JMNEIEPOGFE, TimeSpan BPIIOFNDDAL, TimeSpan NBJGPJACBML, [Optional] CancellationToken MBHHHCCHBAO, [Optional] Action<OperationCanceledException>? KABIFBFKOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61824C0", Offset = "0x61812C0", VA = "0x1861824C0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IEHDBBKNJGA))]
	public static Task KOGFNBEKPNA(this Task NPDMMHKHJDL, Action HADELNBNAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x27A6CA0", Offset = "0x27A5AA0", VA = "0x1827A6CA0")]
	[AsyncStateMachine(typeof(BALKNLAHPJN<>))]
	[Obsolete]
	public static Task KOGFNBEKPNA<T>(this Task<T> NPDMMHKHJDL, Action<T> HADELNBNAFK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6181360", Offset = "0x6180160", VA = "0x186181360")]
	private static void DJKGPINFMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6182140", Offset = "0x6180F40", VA = "0x186182140")]
	public static bool KIPHCLJBLEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6181900", Offset = "0x6180700", VA = "0x186181900")]
	private static void GFMNOKKDIIP(SynchronizationContext MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6182600", Offset = "0x6181400", VA = "0x186182600")]
	private static void NFOILAAMNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6181290", Offset = "0x6180090", VA = "0x186181290")]
	public static void DFDGJECJOEI([Optional] string? LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61810D0", Offset = "0x617FED0", VA = "0x1861810D0")]
	public static void BEPHHMAOJCE([Optional] string? LJCDGDONMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6181610", Offset = "0x6180410", VA = "0x186181610")]
	public static MEEKACANJDN EELLMEIBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61825B0", Offset = "0x61813B0", VA = "0x1861825B0")]
	public static MEEKACANJDN MIPMEPDFIKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61811C0", Offset = "0x617FFC0", VA = "0x1861811C0")]
	[AsyncStateMachine(typeof(NELKELBNJCI))]
	public static Task CJAFNGJPJDH(Func<Task> BKMNKOEHPLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HAGPAHMIPMA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
	public HAGPAHMIPMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PIFDHPOHKAO : JMILILIFPKG
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly JMILILIFPKG ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime ICAIIBDNOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61855B0", Offset = "0x61843B0", VA = "0x1861855B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset HAFOKIEOFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6185550", Offset = "0x6184350", VA = "0x186185550", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public PIFDHPOHKAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JMILILIFPKG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime ICAIIBDNOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset HAFOKIEOFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LAANEEPMEII
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long FGHMJIJPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6183120", Offset = "0x6181F20", VA = "0x186183120")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long LACDBECOAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6182F50", Offset = "0x6181D50", VA = "0x186182F50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double OBFKPFEFLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61831D0", Offset = "0x6181FD0", VA = "0x1861831D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double PIOPFHBBNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6182FF0", Offset = "0x6181DF0", VA = "0x186182FF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double EFOKHNGIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6183220", Offset = "0x6182020", VA = "0x186183220")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double FBFBOAPHDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6182FA0", Offset = "0x6181DA0", VA = "0x186182FA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6183270", Offset = "0x6182070", VA = "0x186183270")]
	public static double NPPAFDKKIPC(long MNEDBFNJPCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6183390", Offset = "0x6182190", VA = "0x186183390")]
	public static double OPFPIJCCFAD(long MNEDBFNJPCI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6183300", Offset = "0x6182100", VA = "0x186183300")]
	public static double OKKALAFFAOA(double PCCGHKMEINH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6183420", Offset = "0x6182220", VA = "0x186183420")]
	public static long PMLGIIMPNJL(long CDIOCCAJDIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6183040", Offset = "0x6181E40", VA = "0x186183040")]
	public static long GGPBODHNFAE(long KIKCHOKNEIH, long GGFGBLMCHAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6183050", Offset = "0x6181E50", VA = "0x186183050")]
	public static double HMILBEPJNMM(long KIKCHOKNEIH, long GGFGBLMCHAO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6183170", Offset = "0x6181F70", VA = "0x186183170")]
	public static double MHJPJJMADAK(long KIKCHOKNEIH, long GGFGBLMCHAO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class NLAKOHEIDDA : DIGACHNLABI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan AGBBGNBELKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer IMFPKCJALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan BPIIOFNDDAL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan MLPJJGGLJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61848F0", Offset = "0x61836F0", VA = "0x1861848F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? MOCGGHKCPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6184B90", Offset = "0x6183990", VA = "0x186184B90")]
	[Preserve]
	public NLAKOHEIDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6184C00", Offset = "0x6183A00", VA = "0x186184C00")]
	public NLAKOHEIDDA(TimeSpan BPIIOFNDDAL, [Optional] Action? NMMFEEMKIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6184860", Offset = "0x6183660", VA = "0x186184860", Slot = "7")]
	public void FPLLGBFFFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6184750", Offset = "0x6183550", VA = "0x186184750", Slot = "8")]
	public void BCCFMKHLPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6184A50", Offset = "0x6183850", VA = "0x186184A50", Slot = "9")]
	public void LLCNKMBDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xBFBCD0", Offset = "0xBFAAD0", VA = "0x180BFBCD0")]
	private void JJALDDKGLCM(object FGIPEOJEGND, ElapsedEventArgs NKMBBCCPKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6184A80", Offset = "0x6183880", VA = "0x186184A80")]
	private static void PAIANCBDALF(TimeSpan KHEPFIPOMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61847C0", Offset = "0x61835C0", VA = "0x1861847C0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class PMMFACMNNCA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string ILFKNLMCGEB;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
	public PMMFACMNNCA(string LOJNCNHFKNG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct IGNEGBKHMPD : IEquatable<IGNEGBKHMPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint EDELAFDHCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int BBCLKDAIBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float LAECKENGGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort CMLAGJDOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort NLNHFGLJGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short KAHBONHDNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short LAPLIFKPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char AIELPOJMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char IDIHKJDHOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte OIAKPNBGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte JAGCJDOOKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte CLPHGDPGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte FDAGFJLONDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool JIMBEPPLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool BPBDAFFGMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool APKFMNELFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool ACOMABCMCED;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static IGNEGBKHMPD BOOBILCOKKG(uint PBDBPLEPBKE)
	{
		return default(IGNEGBKHMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static IGNEGBKHMPD LDKGOOIDBKK(int AOLOOLDMKEK)
	{
		return default(IGNEGBKHMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x617F6A0", Offset = "0x617E4A0", VA = "0x18617F6A0")]
	public static IGNEGBKHMPD KJBAOAENEHL(float CFNBKMKNGMN)
	{
		return default(IGNEGBKHMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x617F6B0", Offset = "0x617E4B0", VA = "0x18617F6B0")]
	public static IGNEGBKHMPD KMNDHLHPAAE(byte PIPPJIALLMG, byte DPDDEIOFNPI, byte BBGEMHEFALD, byte ACKLECKOELK)
	{
		return default(IGNEGBKHMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x617F6B0", Offset = "0x617E4B0", VA = "0x18617F6B0")]
	public static IGNEGBKHMPD MJAMMDFAFDI(bool KPBMOAMBFKB, bool FMCBBIIIDIP, bool JMPMOMLPHFE, bool FLDCIEPOCPO)
	{
		return default(IGNEGBKHMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x617F6B0", Offset = "0x617E4B0", VA = "0x18617F6B0")]
	public static IGNEGBKHMPD KOAIMGCNPAM(byte NFIFBIDOEHP, byte LJMJCHHNBFB, byte KOHAMCLBCON, byte LLMJIIONFIL)
	{
		return default(IGNEGBKHMPD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1802CA0", Offset = "0x1801AA0", VA = "0x181802CA0")]
	public static bool EILLJGMDDAM(IGNEGBKHMPD MAJJJNOEIPE, IGNEGBKHMPD FBEFKCHGALI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x86D940", Offset = "0x86C740", VA = "0x18086D940", Slot = "4")]
	public bool Equals(IGNEGBKHMPD EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x617F620", Offset = "0x617E420", VA = "0x18617F620", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x90A050", Offset = "0x908E50", VA = "0x18090A050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x617F6D0", Offset = "0x617E4D0", VA = "0x18617F6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JCKDOJNFDAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong FGPBCPAADFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long BHPGPOMGNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double DAPMPDILBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint OJLCBHPLLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint NLCDGDIJLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int GEBFDJMDGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int CEDKNKOHJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float NBLPLDMPEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float OLHEOHPOBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort CMLAGJDOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort NLNHFGLJGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort NJIEGNHOBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JCMDBCOMJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short KAHBONHDNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short LAPLIFKPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short ADEAIKFHANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short JEDBEDKJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char AIELPOJMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char IDIHKJDHOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char HPKABPDPNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char KCEBKBKNCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte OIAKPNBGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte JAGCJDOOKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte CLPHGDPGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte FDAGFJLONDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte FCFIJFGMCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte AMAEKMHKDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte JCGGEIKHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte AAFPDNJJJON;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61804C0", Offset = "0x617F2C0", VA = "0x1861804C0")]
	public static JCKDOJNFDAI IKCDCJJCDKO(byte PIPPJIALLMG, byte DPDDEIOFNPI, byte BBGEMHEFALD, byte ACKLECKOELK, byte OOHCPEJOGBE, byte LBNIAAGNGFN, byte OHBBPMFDGBD, byte IPPFFBHGDPD)
	{
		return default(JCKDOJNFDAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class PMFAFKMLJIK<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T FIOMEGAGJKO;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x40B8590", Offset = "0x40B7390", VA = "0x1840B8590")]
	public PMFAFKMLJIK(T PKJGLAEFLOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IMJNDPDLELE
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x278ECE0", Offset = "0x278DAE0", VA = "0x18278ECE0")]
	public static PMFAFKMLJIK<T> IKCDCJJCDKO<T>(T PKJGLAEFLOC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class IMDJBHKGPNP
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x250F380", Offset = "0x250E180", VA = "0x18250F380")]
	public static IEnumerable<T> LENPPCINIMN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static T[] PNEEAOAOJGB<T>(params T[] CFBHFENOPDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static IEnumerable<T> OFCBAKJEENB<T>(params T[] CFBHFENOPDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x25947E0", Offset = "0x25935E0", VA = "0x1825947E0")]
	public static HashSet<T> MEMPIIGKDNO<T>(params T[] CFBHFENOPDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x278E360", Offset = "0x278D160", VA = "0x18278E360")]
	public static KeyValuePair<TKey, TValue> IOAIKCLDMBI<TKey, TValue>([In] TKey ONOECNHBCDA, [In] TValue MAEBFBHFPDE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x25947E0", Offset = "0x25935E0", VA = "0x1825947E0")]
	public static List<T> DFLAMLIOBEP<T>(IEnumerable<T> EGCLMNAPIFL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class LDPCCEECHII : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string MPKINIFGMHB;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
	public LDPCCEECHII(string ANDIBGAILAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object HCEIPMENKMB<T>([In] T LBACBNGIGEC);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object JHJKPLJOAFF<T>(T LBACBNGIGEC);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DJMCOCAEBCL]
public delegate string ANFBGEJMKHG(string OMFBJPLNJIJ, string? POBAGCACOMM, bool FNOGILPPALL);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DJMCOCAEBCL]
public delegate void FMDLKALABCD(string LJCDGDONMLD);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DJMCOCAEBCL]
public delegate void FEEPKJOEIFC(Exception IAOBDGOKOMA);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object MBHHNOAEPJI();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DJMCOCAEBCL]
public delegate bool MBCCAECKELG();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DJMCOCAEBCL]
public delegate string JCPHGJEFHOO(object KDHDNCADFDJ);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class FFJACIBNEJE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
	public FFJACIBNEJE()
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
