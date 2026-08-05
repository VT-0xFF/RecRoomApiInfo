using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C374B0", Offset = "0x6C35AB0", VA = "0x186C374B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJNCAOBMHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C39200", Offset = "0x6C37800", VA = "0x186C39200")]
	public static string ABBOAADIAKE(this Encoding BMDHMGFAICM, [In] ReadOnlySequence<byte> CNGBPDKMHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E445B0", Offset = "0x2E42BB0", VA = "0x182E445B0")]
	private static void NMKBIKCOKKF<T>(this ReadOnlySequence<T> CPICPHKKOGA, [Out] ReadOnlySpan<T> LJNOMOOPMNL, [Out] SequencePosition NDHCCLMPCNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class ENAAEBHBKDI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C324D0", Offset = "0x6C30AD0", VA = "0x186C324D0")]
	public ENAAEBHBKDI(bool HJKPCJJPFLE, string FLLNFIAKKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DAHDHMPDNCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PLPDGNKDHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GCEGIDCLPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMCMKNEMKJJ(string LFOBGDLOPID, double KLABJGGMBGH, [Optional] string? GLIGLNAIMNH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IHIEKOCOAHN<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> BCDKMKADKHE(CancellationToken IONNNJNKLMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FJNNDAIBBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public IHIEKOCOAHN<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BCDKMKADKHE taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D27CA0", Offset = "0x3D262A0", VA = "0x183D27CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D28DE0", Offset = "0x3D273E0", VA = "0x183D28DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource ADHBHFEGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? OKLFGMPEOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? JAEEOINEGIO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC8B0", Offset = "0x3FBAEB0", VA = "0x183FBC8B0")]
	[AsyncStateMachine(typeof(IHIEKOCOAHN<>.FJNNDAIBBGP))]
	public Task<TResult> NDFJAFDOAEJ(BCDKMKADKHE JPGALEDIIAM, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FBC840", Offset = "0x3FBAE40", VA = "0x183FBC840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FBCA00", Offset = "0x3FBB000", VA = "0x183FBCA00")]
	public IHIEKOCOAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GEJMDHFDMEL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> MHNCBBKDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T PGPGCBGPPOH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4640", Offset = "0x3DE2C40", VA = "0x183DE4640")]
	public GEJMDHFDMEL([In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3850", Offset = "0x3DE1E50", VA = "0x183DE3850", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DE3DF0", Offset = "0x3DE23F0", VA = "0x183DE3DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4430", Offset = "0x3DE2A30", VA = "0x183DE4430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OCOMOHAHEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static GEJMDHFDMEL<T> GGBAHLJJLHO<T>([In] T KLABJGGMBGH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class POAIALEGDNA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C3ADD0", Offset = "0x6C393D0", VA = "0x186C3ADD0")]
	public static void AIBHHBIOMMJ(this CancellationTokenSource ADHBHFEGLBD, bool DLKMAPBFNGF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CHEACOPOONL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
	public CHEACOPOONL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CPCEDDOKEKI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
	public CPCEDDOKEKI(string CGBLGAOGIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AOCOGBCJNIM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3357440", Offset = "0x3355A40", VA = "0x183357440")]
	public static FBPLBJMCGOC BEJBFPAPGGM<T>()
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3357170", Offset = "0x3355770", VA = "0x183357170")]
	public static FBPLBJMCGOC AKEOHALHGGN<T>([CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x33573C0", Offset = "0x33559C0", VA = "0x1833573C0")]
	public static FBPLBJMCGOC BEJBFPAPGGM<T>(this T MNKBAIOBLHC) where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33574C0", Offset = "0x3355AC0", VA = "0x1833574C0")]
	public static FBPLBJMCGOC NKGBBILMKJB<T>(this T MNKBAIOBLHC, [CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3357210", Offset = "0x3355810", VA = "0x183357210")]
	public static FBPLBJMCGOC AKEOHALHGGN<T>(this T BJNJBGHPMEH, [CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C30C70", Offset = "0x6C2F270", VA = "0x186C30C70")]
	public static FBPLBJMCGOC AKEOHALHGGN(string FDPIKPMCPPF, [CallerMemberName] string KJPHMNNIMDP = "")
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C30CF0", Offset = "0x6C2F2F0", VA = "0x186C30CF0")]
	public static string HEIHMHFEGGB(this object BJNJBGHPMEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool HMAJCGBAGMO();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CHEACOPOONL]
public delegate long FIBHDIFKCIN();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JFJIJPAMLIH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FGEFFFCMDKI ALFFNFFGEPB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FGEFFFCMDKI MJOEODDKKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C34AA0", Offset = "0x6C330A0", VA = "0x186C34AA0")]
		get
		{
			return default(FGEFFFCMDKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MPCJFPCFBLE GFNGAGNEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C34BB0", Offset = "0x6C331B0", VA = "0x186C34BB0")]
		get
		{
			return default(MPCJFPCFBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HPAPGHJDOEJ MKDNAOJAIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C34B60", Offset = "0x6C33160", VA = "0x186C34B60")]
		get
		{
			return default(HPAPGHJDOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PPOFDFBEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C34D50", Offset = "0x6C33350", VA = "0x186C34D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C34830", Offset = "0x6C32E30", VA = "0x186C34830")]
	public static void EJBDNJOJABP([In] FGEFFFCMDKI GOGDNJAJCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C34C80", Offset = "0x6C33280", VA = "0x186C34C80")]
	public static void OJMFFMAGFPH(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C345E0", Offset = "0x6C32BE0", VA = "0x186C345E0")]
	public static void BAFDALIIBIE(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2D40AD0", Offset = "0x2D3F0D0", VA = "0x182D40AD0")]
	public static void BAFDALIIBIE<T>(T IOBLLEKOCNN, IGEHAJBKDGE<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C34720", Offset = "0x6C32D20", VA = "0x186C34720")]
	public static void CGGKMGOEAMC(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C34C00", Offset = "0x6C33200", VA = "0x186C34C00")]
	public static void ICKJCINIDIB(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C347C0", Offset = "0x6C32DC0", VA = "0x186C347C0")]
	public static void CJPGHLMADAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C34AF0", Offset = "0x6C330F0", VA = "0x186C34AF0")]
	public static string HEIHMHFEGGB(object GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C346B0", Offset = "0x6C32CB0", VA = "0x186C346B0")]
	public static long BKAGOLNIMBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C34DC0", Offset = "0x6C333C0", VA = "0x186C34DC0")]
	public static bool PEEPLDCGABI(bool ACJMHFFHANF, string KFAOBDLOMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C349D0", Offset = "0x6C32FD0", VA = "0x186C349D0")]
	public static double FBDKPAHPJNH()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct FGEFFFCMDKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly MPCJFPCFBLE GFNGAGNEIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HPAPGHJDOEJ MKDNAOJAIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly AIPOLFLJAAK OOGADFKGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly FIBHDIFKCIN BPNDKKPHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly MBIEIFCHNNP GJEFFFPKIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly HMAJCGBAGMO HCHGGLKPCMD;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly AIPOLFLJAAK MCKLGILLDKI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly FIBHDIFKCIN PDKPDHLCLOO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly MBIEIFCHNNP HAJOJAKHOGN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly HMAJCGBAGMO JKKPNEKEBJO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly FGEFFFCMDKI PGEMABEMKPO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C326D0", Offset = "0x6C30CD0", VA = "0x186C326D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C33060", Offset = "0x6C31660", VA = "0x186C33060")]
	public FGEFFFCMDKI([In] MPCJFPCFBLE PODGMFBDLGG, [In] HPAPGHJDOEJ GFOPEKHOEME, AIPOLFLJAAK NJFDDCEFJCF, FIBHDIFKCIN JNNCFPEAIDI, MBIEIFCHNNP PEONFOFDABH, HMAJCGBAGMO LGKFEHCEGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C32860", Offset = "0x6C30E60", VA = "0x186C32860")]
	private static string MJEENFIBOCE(object GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360")]
	private static long LANGNGGPKCA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	private static string EMOIALNHNOG(string KLNAGGGGPDK, string? BPFGNDAPKAJ, bool GCEGJLCJDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	private static bool LIKMJKKOCIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C328A0", Offset = "0x6C30EA0", VA = "0x186C328A0")]
	private static FGEFFFCMDKI NIHICLBFHCK()
	{
		return default(FGEFFFCMDKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HIEHGJINBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GACBCMNHFEC GPOPJKKIDGI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GACBCMNHFEC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EPAOBLINODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOOBGLGFFBL();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GKKHBAJDJDD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELNMFHABHNG([In] T PLNBHPCFEOK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void OFDGCCLFAJD<T>([In] T IOBLLEKOCNN);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct MGBLPJABDKK<T> : IEquatable<MGBLPJABDKK<T>>, GKKHBAJDJDD<MGBLPJABDKK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T PGPGCBGPPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int OAGDGHBELJN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x20DB650", Offset = "0x20D9C50", VA = "0x1820DB650")]
	public MGBLPJABDKK([In] T KLABJGGMBGH, int HGFDMIDEFHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4694F80", Offset = "0x4693580", VA = "0x184694F80")]
	public static bool MNAFCOICNLK([In] MGBLPJABDKK<T> NFCDCHABNCB, [In] MGBLPJABDKK<T> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4693B70", Offset = "0x4692170", VA = "0x184693B70", Slot = "4")]
	public bool Equals(MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3961AE0", Offset = "0x39600E0", VA = "0x183961AE0", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4693A40", Offset = "0x4692040", VA = "0x184693A40")]
	public bool ELNMFHABHNG([In] MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4693EA0", Offset = "0x46924A0", VA = "0x184693EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46957A0", Offset = "0x4693DA0", VA = "0x1846957A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4694670", Offset = "0x4692C70", VA = "0x184694670")]
	public void MMDHOICOGNG([Out] T KLABJGGMBGH, [Out] int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4694110", Offset = "0x4692710", VA = "0x184694110")]
	public (T, int) IHAFMFKNODA()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4695160", Offset = "0x4693760", VA = "0x184695160", Slot = "5")]
	private bool PFNDGAFMDKE([In] MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GEJJMLICAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBC20", Offset = "0x2CBA220", VA = "0x182CBBC20")]
	public static MGBLPJABDKK<T> GGBAHLJJLHO<T>([In] T KLABJGGMBGH, int HGFDMIDEFHN) where T : notnull
	{
		return default(MGBLPJABDKK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NEMGBEAPILP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E08EC0", Offset = "0x2E074C0", VA = "0x182E08EC0")]
	public static bool ELNMFHABHNG<T, U>([In] T BJNJBGHPMEH, [In] U GHMNBJIOGAM) where T : notnull, GKKHBAJDJDD<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult BPKONEHHKGI<T, out TResult>([In] T IOBLLEKOCNN);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FBOOCBJFLEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan AJMHLFOLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? NDJKCHHCBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHKIFFPBGID();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLCIBMMIOPJ();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCHFEKGILOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct MPCJFPCFBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly MDAJHGCLDJH CFJMMKLGPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly EIMGOEJJJEK EFILJKKCMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly MDAJHGCLDJH HIHALLGPEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly EIMGOEJJJEK PAJCCFMLLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly MDAJHGCLDJH IJOAOFPEDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EIMGOEJJJEK ALGFJLIDFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly KHPKOKKHEFD FINOHMNNEPN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly MDAJHGCLDJH ABBPAPECHNP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EIMGOEJJJEK EHFABFBHBOK;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly MDAJHGCLDJH MAOGEBFPEHH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly EIMGOEJJJEK HMHHAOFHNEA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MDAJHGCLDJH BALDCFEPHEF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EIMGOEJJJEK NJMFPBFPKNL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KHPKOKKHEFD ALNLECJCPBK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MPCJFPCFBLE PGEMABEMKPO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly MDAJHGCLDJH IADEICBCNHH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C35D80", Offset = "0x6C34380", VA = "0x186C35D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xCCB240", Offset = "0xCC9840", VA = "0x180CCB240")]
	public MPCJFPCFBLE(MDAJHGCLDJH LCMHIFACPDN, EIMGOEJJJEK ACFJEDKLDJL, MDAJHGCLDJH BPBIJPGKMAB, EIMGOEJJJEK HPLPBOIIFLF, MDAJHGCLDJH CKJLLJKIPEE, EIMGOEJJJEK CLCCLIDCEMC, KHPKOKKHEFD CBCBFGGIOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	private static bool BJDIIBGHHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void LIPHLKANMNN(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	private static bool ODJCDBOHDDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void EBPCAPMAPNA(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	private static bool LJMHCHNBINB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void FCNEPMAPPMI(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void ILBEAPHJIAN(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C35F60", Offset = "0x6C34560", VA = "0x186C35F60")]
	private static MPCJFPCFBLE NIHICLBFHCK()
	{
		return default(MPCJFPCFBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
	private static bool DEMDDMIOLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C360A0", Offset = "0x6C346A0", VA = "0x186C360A0")]
	public void OJMFFMAGFPH(object KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C35D10", Offset = "0x6C34310", VA = "0x186C35D10")]
	public void BAFDALIIBIE(object KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E50BF0", Offset = "0x1E4F1F0", VA = "0x181E50BF0")]
	public void CGGKMGOEAMC(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C35C30", Offset = "0x6C34230", VA = "0x186C35C30")]
	public void BAFDALIIBIE(AIOKKEDGDOG KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D2A0", Offset = "0x2D9B8A0", VA = "0x182D9D2A0")]
	public void BAFDALIIBIE<T>(T IOBLLEKOCNN, IGEHAJBKDGE<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D370", Offset = "0x2D9B970", VA = "0x182D9D370")]
	public void OJMFFMAGFPH<T>([In] T IOBLLEKOCNN, JEHELIIJAML<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D030", Offset = "0x2D9B630", VA = "0x182D9D030")]
	public void BAFDALIIBIE<T>([In] T IOBLLEKOCNN, JEHELIIJAML<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C36110", Offset = "0x6C34710", VA = "0x186C36110")]
	public bool PEEPLDCGABI(bool ACJMHFFHANF, string KFAOBDLOMDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct FBPLBJMCGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string PGPGCBGPPOH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	public FBPLBJMCGOC(string KLABJGGMBGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70")]
	public static string BIEOCAPMHCM([In] FBPLBJMCGOC BJNJBGHPMEH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB1BAD0", Offset = "0xB1A0D0", VA = "0x180B1BAD0")]
	public static FBPLBJMCGOC BIEOCAPMHCM(string PLNBHPCFEOK)
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C325A0", Offset = "0x6C30BA0", VA = "0x186C325A0")]
	public string HNFLNJBDOKM(string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C325F0", Offset = "0x6C30BF0", VA = "0x186C325F0")]
	public string POJMAMLEACN(object OADFIADCCGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA40F70", Offset = "0xA3F570", VA = "0x180A40F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct BLGMJKLPHOM : IEquatable<BLGMJKLPHOM>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "4")]
	public bool Equals(BLGMJKLPHOM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C31150", Offset = "0x6C2F750", VA = "0x186C31150", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C311A0", Offset = "0x6C2F7A0", VA = "0x186C311A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C311B0", Offset = "0x6C2F7B0", VA = "0x186C311B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EMDAHHLEKNJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct OLCEOJBLPLC<T> : IEquatable<OLCEOJBLPLC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T PGPGCBGPPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool NNBJCCJHCDD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GPGCFMENJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x482D660", Offset = "0x482BC60", VA = "0x18482D660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x482DDB0", Offset = "0x482C3B0", VA = "0x18482DDB0")]
	public OLCEOJBLPLC([In] T KLABJGGMBGH, bool JPFNBPGCEFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x482D2F0", Offset = "0x482B8F0", VA = "0x18482D2F0")]
	public static bool MNAFCOICNLK([In] OLCEOJBLPLC<T> NFCDCHABNCB, [In] OLCEOJBLPLC<T> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4693B70", Offset = "0x4692170", VA = "0x184693B70", Slot = "4")]
	public bool Equals(OLCEOJBLPLC<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x482C730", Offset = "0x482AD30", VA = "0x18482C730", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x482CB70", Offset = "0x482B170", VA = "0x18482CB70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x482DB70", Offset = "0x482C170", VA = "0x18482DB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LBLOMBHLFHG
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D6C0", Offset = "0x2D6BCC0", VA = "0x182D6D6C0")]
	public static OLCEOJBLPLC<T> IPPCPPHHJML<T>([In] T KLABJGGMBGH) where T : notnull
	{
		return default(OLCEOJBLPLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D850", Offset = "0x2D6BE50", VA = "0x182D6D850")]
	public static OLCEOJBLPLC<T?> MMLDELMJFDD<T>()
	{
		return default(OLCEOJBLPLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D5D0", Offset = "0x2D6BBD0", VA = "0x182D6D5D0")]
	public static bool ADJJFPEJKAG<T>([In] this OLCEOJBLPLC<T> LBEOMMDHIIP, [Out][NotNullWhen(true)] T KLABJGGMBGH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2D6D600", Offset = "0x2D6BC00", VA = "0x182D6D600")]
	public static T? BJOJHFEHEEI<T>([In] this OLCEOJBLPLC<T> LBEOMMDHIIP, T? MCAGMGIJFIA)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct HPAPGHJDOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr ICKJCINIDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr CJPGHLMADAH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr PGFCIOJNPOJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr NHIOKAFACDO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly HPAPGHJDOEJ PGEMABEMKPO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C33ED0", Offset = "0x6C324D0", VA = "0x186C33ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
	public HPAPGHJDOEJ(IntPtr LODJEMEPMMA, IntPtr OCPEBJLONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void EPKEPLPACPC(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void MACKOMJPHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C33FA0", Offset = "0x6C325A0", VA = "0x186C33FA0")]
	private static HPAPGHJDOEJ NIHICLBFHCK()
	{
		return default(HPAPGHJDOEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct LJBEPFFMPFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr HGEJLLCCMNL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xAB30F0", Offset = "0xAB16F0", VA = "0x180AB30F0")]
	private LJBEPFFMPFD(IntPtr OCPEBJLONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C354A0", Offset = "0x6C33AA0", VA = "0x186C354A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C354C0", Offset = "0x6C33AC0", VA = "0x186C354C0")]
	public static LJBEPFFMPFD GGBAHLJJLHO(string KJPHMNNIMDP)
	{
		return default(LJBEPFFMPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20B2CE0", Offset = "0x20B12E0", VA = "0x1820B2CE0")]
	public static LJBEPFFMPFD GGBAHLJJLHO([In] HPAPGHJDOEJ GFOPEKHOEME, string KJPHMNNIMDP)
	{
		return default(LJBEPFFMPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20B2C70", Offset = "0x20B1270", VA = "0x1820B2C70")]
	public static LJBEPFFMPFD GGBAHLJJLHO([In] HPAPGHJDOEJ GFOPEKHOEME, Func<string> KJPHMNNIMDP)
	{
		return default(LJBEPFFMPFD);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OHLDINBBDNN
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool ACMBNKOBNAM<in TInput, TResult>(TInput DIGEGMNKCOG, [Out] TResult POBDLJBBBCI);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class AIGIMJHGFBI : HIEHGJINBBC
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class HDMINPKDDFP : GACBCMNHFEC, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly HDMINPKDDFP DFEEMNKDOMA;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EPAOBLINODJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6C33CB0", Offset = "0x6C322B0", VA = "0x186C33CB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C33D10", Offset = "0x6C32310", VA = "0x186C33D10", Slot = "6")]
			public void OnCompleted(Action FHCABKEHDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			public void OOOBGLGFFBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HDMINPKDDFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly AIGIMJHGFBI DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		private AIGIMJHGFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C30BB0", Offset = "0x6C2F1B0", VA = "0x186C30BB0", Slot = "4")]
		public GACBCMNHFEC GPOPJKKIDGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class DNLLKFNEADB : HIEHGJINBBC
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class OPJLKBEIBGC : GACBCMNHFEC, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly OPJLKBEIBGC DFEEMNKDOMA;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool EPAOBLINODJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x6C39FC0", Offset = "0x6C385C0", VA = "0x186C39FC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6C39FE0", Offset = "0x6C385E0", VA = "0x186C39FE0", Slot = "6")]
			public void OnCompleted(Action FHCABKEHDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			public void OOOBGLGFFBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public OPJLKBEIBGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DNLLKFNEADB DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		private DNLLKFNEADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C32040", Offset = "0x6C30640", VA = "0x186C32040", Slot = "4")]
		public GACBCMNHFEC GPOPJKKIDGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BANJOPDBLNE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public BANJOPDBLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x41BC6C0", Offset = "0x41BACC0", VA = "0x1841BC6C0")]
		internal void GBNPCCGIOEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DOBJDJFPJDM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public DOBJDJFPJDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x47096B0", Offset = "0x4707CB0", VA = "0x1847096B0")]
		internal void HLGPEHHCLIA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LCDDDAPBIJM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6C35230", Offset = "0x6C33830", VA = "0x186C35230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LDOCLFKGBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C35390", Offset = "0x6C33990", VA = "0x186C35390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FPHIKFIFEMK<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D40E60", Offset = "0x3D3F460", VA = "0x183D40E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D40FD0", Offset = "0x3D3F5D0", VA = "0x183D40FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct EJACBFCNJNM<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3961F20", Offset = "0x3960520", VA = "0x183961F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x39627B0", Offset = "0x3960DB0", VA = "0x1839627B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CHHHOKBDCGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C31A30", Offset = "0x6C30030", VA = "0x186C31A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C31C30", Offset = "0x6C30230", VA = "0x186C31C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JGCLBJADJCC<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JGCLBJADJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x41BC6C0", Offset = "0x41BACC0", VA = "0x1841BC6C0")]
		internal void KHKHFPIINMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x41BC640", Offset = "0x41BAC40", VA = "0x1841BC640")]
		internal void CFCJJJCJAAF(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KKBEFIKJGMC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ACMBNKOBNAM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4363130", Offset = "0x4361730", VA = "0x184363130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x43638A0", Offset = "0x4361EA0", VA = "0x1843638A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BNONBNOPCLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C311E0", Offset = "0x6C2F7E0", VA = "0x186C311E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C319D0", Offset = "0x6C2FFD0", VA = "0x186C319D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HCDNLLBOHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6C334D0", Offset = "0x6C31AD0", VA = "0x186C334D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C33A10", Offset = "0x6C32010", VA = "0x186C33A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FBLOKFFBPCK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D02D00", Offset = "0x3D01300", VA = "0x183D02D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D03C50", Offset = "0x3D02250", VA = "0x183D03C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OFILNHMKPNH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x481C8E0", Offset = "0x481AEE0", VA = "0x18481C8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36A1190", Offset = "0x369F790", VA = "0x1836A1190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct HOLAFEGBOIG<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E90B40", Offset = "0x3E8F140", VA = "0x183E90B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3E91890", Offset = "0x3E8FE90", VA = "0x183E91890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HDKJDKJKNNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6C33A70", Offset = "0x6C32070", VA = "0x186C33A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C33C50", Offset = "0x6C32250", VA = "0x186C33C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BFNJJAGFOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C30D90", Offset = "0x6C2F390", VA = "0x186C30D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6C310F0", Offset = "0x6C2F6F0", VA = "0x186C310F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct NNKGFCGKEHD : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C370F0", Offset = "0x6C356F0", VA = "0x186C370F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C373E0", Offset = "0x6C359E0", VA = "0x186C373E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MAEHCOEIHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public MAEHCOEIHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C355C0", Offset = "0x6C33BC0", VA = "0x186C355C0")]
		internal Task AHCLAGKEDBD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct EBEGDBDMGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C32210", Offset = "0x6C30810", VA = "0x186C32210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C32470", Offset = "0x6C30A70", VA = "0x186C32470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MCAIFAIKGIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C359F0", Offset = "0x6C33FF0", VA = "0x186C359F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C35BD0", Offset = "0x6C341D0", VA = "0x186C35BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FLBBMKJMDPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C33110", Offset = "0x6C31710", VA = "0x186C33110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C33470", Offset = "0x6C31A70", VA = "0x186C33470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DLLGMIAJAKA : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C31CF0", Offset = "0x6C302F0", VA = "0x186C31CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C31FE0", Offset = "0x6C305E0", VA = "0x186C31FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NNPPONNMIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NNPPONNMIPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C37440", Offset = "0x6C35A40", VA = "0x186C37440")]
		internal Task DBHJLPNPNEC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct MBLPLFCHKNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C35730", Offset = "0x6C33D30", VA = "0x186C35730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C35990", Offset = "0x6C33F90", VA = "0x186C35990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct AHBOPNMEDMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6C309D0", Offset = "0x6C2EFD0", VA = "0x186C309D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C30B50", Offset = "0x6C2F150", VA = "0x186C30B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NACIAGNKMIO<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x46F9280", Offset = "0x46F7880", VA = "0x1846F9280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x46F9500", Offset = "0x46F7B00", VA = "0x1846F9500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct IFAJPGJMCFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C34170", Offset = "0x6C32770", VA = "0x186C34170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6C34580", Offset = "0x6C32B80", VA = "0x186C34580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? CLMDDMFJNDB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<BLGMJKLPHOM> AMLJKADOJIE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task AEFOLLDNIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C387A0", Offset = "0x6C36DA0", VA = "0x186C387A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C375B0", Offset = "0x6C35BB0", VA = "0x186C375B0")]
	public static bool BGINOIBJOMN(this Task KECDGIGMBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F3C0", Offset = "0x2E3D9C0", VA = "0x182E3F3C0")]
	public static Task<T> CJMJEMFLCAA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C37BF0", Offset = "0x6C361F0", VA = "0x186C37BF0")]
	public static Task DDPFJPGNADI(this Task KECDGIGMBNG, CancellationToken FLLNLBHFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2E414A0", Offset = "0x2E3FAA0", VA = "0x182E414A0")]
	public static Task<TResult> DDPFJPGNADI<TResult>(this Task<TResult> KECDGIGMBNG, CancellationToken FLLNLBHFENG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2E42430", Offset = "0x2E40A30", VA = "0x182E42430")]
	public static TaskCompletionSource<TResult> DDPFJPGNADI<TResult>(this TaskCompletionSource<TResult> NKDMIPFFBGD, CancellationToken FLLNLBHFENG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C382E0", Offset = "0x6C368E0", VA = "0x186C382E0")]
	public static IDisposable? EKCNOJCMFKB(CancellationToken GGIIHCIDCPD, CancellationToken JEOGCJFLJGK, [Out] CancellationToken HGEOJOBFIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C39090", Offset = "0x6C37690", VA = "0x186C39090")]
	[AsyncStateMachine(typeof(LCDDDAPBIJM))]
	public static void PAEGHBDLGGO(this Task KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C38230", Offset = "0x6C36830", VA = "0x186C38230")]
	[AsyncStateMachine(typeof(LDOCLFKGBKI))]
	public static void DPLMAKKPJCO(this Task KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E42DC0", Offset = "0x2E413C0", VA = "0x182E42DC0")]
	[AsyncStateMachine(typeof(FPHIKFIFEMK<>))]
	public static Task GGLDGNJEALF<TException>(this Task KGPMLIHPPAA) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2E43790", Offset = "0x2E41D90", VA = "0x182E43790")]
	[AsyncStateMachine(typeof(EJACBFCNJNM<>))]
	public static Task<T> ODNFCKLGLPM<T>(this Task<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C38810", Offset = "0x6C36E10", VA = "0x186C38810")]
	[AsyncStateMachine(typeof(CHHHOKBDCGB))]
	public static Task<TaskStatus> HIFMEBJNGNF(this Task BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E43240", Offset = "0x2E41840", VA = "0x182E43240")]
	public static (Task<T?>?, Action<T?>?) JKNPKJADCIE<T>([Optional] CancellationToken IONNNJNKLMJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E42E90", Offset = "0x2E41490", VA = "0x182E42E90")]
	[AsyncStateMachine(typeof(KKBEFIKJGMC<, >))]
	public static Task<List<TResult>> HOEMEOCNFAG<TResult, TInput>(this Task<List<TInput>> KECDGIGMBNG, ACMBNKOBNAM<TInput, TResult> BFBEGMEGHMD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C38470", Offset = "0x6C36A70", VA = "0x186C38470")]
	[AsyncStateMachine(typeof(BNONBNOPCLK))]
	public static Task GKAOIGGINPC(Task KGPMLIHPPAA, CancellationToken LBFDJGLPAMK, Func<CancellationToken, Task> CAIIFNPNIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C38900", Offset = "0x6C36F00", VA = "0x186C38900")]
	[AsyncStateMachine(typeof(HCDNLLBOHBC))]
	public static Task IBGCPNHJDIO(Func<CancellationToken, Task> POBEKJIJHNB, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken LBFDJGLPAMK, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E42FA0", Offset = "0x2E415A0", VA = "0x182E42FA0")]
	[AsyncStateMachine(typeof(FBLOKFFBPCK<>))]
	public static Task<T> IBGCPNHJDIO<T>(Func<CancellationToken, Task<T>> POBEKJIJHNB, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken LBFDJGLPAMK, [Optional] Func<OperationCanceledException, T>? HENHCAAMINC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2E436A0", Offset = "0x2E41CA0", VA = "0x182E436A0")]
	[AsyncStateMachine(typeof(OFILNHMKPNH<>))]
	public static Task<IEnumerable<Task<T>>> KAPJJLHBNGD<T>(IEnumerable<Task<T>> GCGPKEICBKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F100", Offset = "0x2E3D700", VA = "0x182E3F100")]
	[AsyncStateMachine(typeof(HOLAFEGBOIG<, , , >))]
	public static Task<(T1, T2, T3, T4)> BMMCANNHLHP<T1, T2, T3, T4>(Task<T1> BLPIIMELGPI, Task<T2> DALKNEHHFJA, Task<T3> CJGDOCAFLBK, Task<T4> ACDJJBOAALK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C375E0", Offset = "0x6C35BE0", VA = "0x186C375E0")]
	[AsyncStateMachine(typeof(HDKJDKJKNNL))]
	public static Task BLPEHMKPFBG(Func<bool> ACJMHFFHANF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C376D0", Offset = "0x6C35CD0", VA = "0x186C376D0")]
	[AsyncStateMachine(typeof(BFNJJAGFOEO))]
	public static Task BLPEHMKPFBG(Func<bool> ACJMHFFHANF, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C38100", Offset = "0x6C36700", VA = "0x186C38100")]
	[AsyncStateMachine(typeof(NNKGFCGKEHD))]
	public static Task DJHHNPDCAKB(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C37FC0", Offset = "0x6C365C0", VA = "0x186C37FC0")]
	[AsyncStateMachine(typeof(EBEGDBDMGOH))]
	public static Task DJHHNPDCAKB(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C386B0", Offset = "0x6C36CB0", VA = "0x186C386B0")]
	[AsyncStateMachine(typeof(MCAIFAIKGIJ))]
	public static Task GMEIKEKILMM(Func<bool> ACJMHFFHANF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C385A0", Offset = "0x6C36BA0", VA = "0x186C385A0")]
	[AsyncStateMachine(typeof(FLBBMKJMDPB))]
	public static Task GMEIKEKILMM(Func<bool> ACJMHFFHANF, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C38CC0", Offset = "0x6C372C0", VA = "0x186C38CC0")]
	[AsyncStateMachine(typeof(DLLGMIAJAKA))]
	public static Task LLLIEFEJEDK(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C38DF0", Offset = "0x6C373F0", VA = "0x186C38DF0")]
	[AsyncStateMachine(typeof(MBLPLFCHKNM))]
	public static Task LLLIEFEJEDK(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C38BD0", Offset = "0x6C371D0", VA = "0x186C38BD0")]
	[AsyncStateMachine(typeof(AHBOPNMEDMJ))]
	[Obsolete]
	public static Task JOCPKLFBAKJ(this Task KECDGIGMBNG, Action DJMJKLDKDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E434C0", Offset = "0x2E41AC0", VA = "0x182E434C0")]
	[AsyncStateMachine(typeof(NACIAGNKMIO<>))]
	[Obsolete]
	public static Task JOCPKLFBAKJ<T>(this Task<T> KECDGIGMBNG, Action<T> DJMJKLDKDKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C377E0", Offset = "0x6C35DE0", VA = "0x186C377E0")]
	private static void BPHFFBOEOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C37890", Offset = "0x6C35E90", VA = "0x186C37890")]
	public static bool CIGEGCNCOJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C37E40", Offset = "0x6C36440", VA = "0x186C37E40")]
	private static void DEJBDHPHNHM(SynchronizationContext KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C38F30", Offset = "0x6C37530", VA = "0x186C38F30")]
	private static void LNGDIEMKNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C38B00", Offset = "0x6C37100", VA = "0x186C38B00")]
	public static void JNLJDJNALDG([Optional] string? KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C37530", Offset = "0x6C35B30", VA = "0x186C37530")]
	public static void AMPMGJHEIFL([Optional] string? KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C38420", Offset = "0x6C36A20", VA = "0x186C38420")]
	public static HIEHGJINBBC GGCKFPIABNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C39040", Offset = "0x6C37640", VA = "0x186C39040")]
	public static HIEHGJINBBC OLIDHCNGBAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C38A30", Offset = "0x6C37030", VA = "0x186C38A30")]
	[AsyncStateMachine(typeof(IFAJPGJMCFL))]
	public static Task JAHCNOLAEKL(Func<Task> OADEFMMDNAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NHFFCNPJGMC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
	public NHFFCNPJGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DPDMMNHBPKC : OHIFAJBNMJH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly OHIFAJBNMJH DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime BADDBEOCNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6C32100", Offset = "0x6C30700", VA = "0x186C32100", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset GDNCHMKEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6C32140", Offset = "0x6C30740", VA = "0x186C32140", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public DPDMMNHBPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface OHIFAJBNMJH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime BADDBEOCNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset GDNCHMKEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ONMDJHIDOFI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long IPICNFBMMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C39A00", Offset = "0x6C38000", VA = "0x186C39A00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long PEEFPOBKKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C39BE0", Offset = "0x6C381E0", VA = "0x186C39BE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double GNINKFJAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C39B90", Offset = "0x6C38190", VA = "0x186C39B90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double ANJDDCEMAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C39890", Offset = "0x6C37E90", VA = "0x186C39890")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double BNJDHLCKKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6C39AB0", Offset = "0x6C380B0", VA = "0x186C39AB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double GOCKJAPBALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C39CD0", Offset = "0x6C382D0", VA = "0x186C39CD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C398E0", Offset = "0x6C37EE0", VA = "0x186C398E0")]
	public static double FEGBDCFODKG(long HHBFIIPPGKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C39970", Offset = "0x6C37F70", VA = "0x186C39970")]
	public static double FEHOJFKNIML(long HHBFIIPPGKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C39C40", Offset = "0x6C38240", VA = "0x186C39C40")]
	public static double OIJJGPELJNL(double OHAHDFKOMDO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C39B00", Offset = "0x6C38100", VA = "0x186C39B00")]
	public static long JGGFBMAJIKB(long GMOGAEOJHDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C39C30", Offset = "0x6C38230", VA = "0x186C39C30")]
	public static long OFEGCKLLLHH(long OMHBPMKMFPM, long GMJHNNJMKOD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C397C0", Offset = "0x6C37DC0", VA = "0x186C397C0")]
	public static double BFBNIIPDPNH(long OMHBPMKMFPM, long GMJHNNJMKOD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C39A50", Offset = "0x6C38050", VA = "0x186C39A50")]
	public static double FMPINEJDHCL(long OMHBPMKMFPM, long GMJHNNJMKOD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class PEKKJKCLOJF : FBOOCBJFLEP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan ILIFOCCDHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer LOIGOPGNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan PFFHGEAHJBE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan AJMHLFOLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C3A6F0", Offset = "0x6C38CF0", VA = "0x186C3A6F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? NDJKCHHCBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AD70", Offset = "0x6C39370", VA = "0x186C3AD70")]
	[Preserve]
	public PEKKJKCLOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AB20", Offset = "0x6C39120", VA = "0x186C3AB20")]
	public PEKKJKCLOJF(TimeSpan PFFHGEAHJBE, [Optional] Action? LJFNMGJHFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A990", Offset = "0x6C38F90", VA = "0x186C3A990", Slot = "7")]
	public void LHKIFFPBGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A920", Offset = "0x6C38F20", VA = "0x186C3A920", Slot = "8")]
	public void JLCIBMMIOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A8F0", Offset = "0x6C38EF0", VA = "0x186C3A8F0", Slot = "9")]
	public void FCHFEKGILOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xACF9C0", Offset = "0xACDFC0", VA = "0x180ACF9C0")]
	private void FAGGEBONHGD(object MNKBAIOBLHC, ElapsedEventArgs HFDNGGADMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AA20", Offset = "0x6C39020", VA = "0x186C3AA20")]
	private static void MHHFEJNIOFE(TimeSpan FECOONDAGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A850", Offset = "0x6C38E50", VA = "0x186C3A850", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class EMDAHHLEKNJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? PJLBCIMELMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string MONLPMOOGMP;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F58800", Offset = "0x1F56E00", VA = "0x181F58800")]
	public EMDAHHLEKNJ(string PADNFDKMCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3F28D10", Offset = "0x3F27310", VA = "0x183F28D10")]
	public EMDAHHLEKNJ(string BAKDDABGCNF, string PADNFDKMCHE)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct POJKEEADMGJ : IEquatable<POJKEEADMGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint HFBFCDJKHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int AKPKJFGKGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float JPNDPLIBLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort IFNPNJCJCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort FDFJBHLAMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short MCHLOFEJPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short PIBBAIOCFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char JENGOFLDKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char AJNNNGLJACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte JKFLAGDJOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte BLMDLNPJFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte BHHAFFAKGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte PBMGKEECBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool EKFIFOHIOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool FMDKFEGJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool KCJIKDLPMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool BFBFDPMIGKK;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x14125F0", Offset = "0x1410BF0", VA = "0x1814125F0")]
	public static POJKEEADMGJ ICPJEDFJEJN(uint PBHKALJHGEN)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x14125F0", Offset = "0x1410BF0", VA = "0x1814125F0")]
	public static POJKEEADMGJ CINKIIHJGNE(int NLICHAIBNKJ)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AE00", Offset = "0x6C39400", VA = "0x186C3AE00")]
	public static POJKEEADMGJ BEIOJOGEKGL(float PJODCDAILHE)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AE10", Offset = "0x6C39410", VA = "0x186C3AE10")]
	public static POJKEEADMGJ DGNDDBKJDKI(byte EHEOELKFHDI, byte EGBNPHEEIKK, byte CFMOABHEOKM, byte DNJMMHAAONO)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AE10", Offset = "0x6C39410", VA = "0x186C3AE10")]
	public static POJKEEADMGJ NEMPLKFAGFB(bool OACCMDHCEMC, bool MEMJFJLFJOP, bool CKMFLENMMHC, bool HAMPPBAAFNL)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AE10", Offset = "0x6C39410", VA = "0x186C3AE10")]
	public static POJKEEADMGJ FCHGKBCFDGN(byte PMONOHICICO, byte ILOJJMMHPDI, byte INCPABHDFEJ, byte MACCLNGPCAN)
	{
		return default(POJKEEADMGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7DE0", Offset = "0x1CB63E0", VA = "0x181CB7DE0")]
	public static bool MNAFCOICNLK(POJKEEADMGJ JDKMLCHPKLA, POJKEEADMGJ AENKMLMFBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xB94610", Offset = "0xB92C10", VA = "0x180B94610", Slot = "4")]
	public bool Equals(POJKEEADMGJ PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AE30", Offset = "0x6C39430", VA = "0x186C3AE30", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xC4C170", Offset = "0xC4A770", VA = "0x180C4C170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AEB0", Offset = "0x6C394B0", VA = "0x186C3AEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct DDKENKMOBBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong IEMEGGKKOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long GDGBEJOGDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double ICJCIJINDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint MKKEFAOKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint DMBJGPCKIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int NKEGGALCJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int EMAJOELPLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float NFKIBPBEMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float IOFONFKKKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort IFNPNJCJCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort FDFJBHLAMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort IFLEPGLOAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort HEIPBAEHBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short MCHLOFEJPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short PIBBAIOCFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short IOIGIOLMAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short LAJEINIPFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char JENGOFLDKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char AJNNNGLJACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char MBLJKBJDDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char CPIMBNFLEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte JKFLAGDJOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte BLMDLNPJFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BHHAFFAKGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte PBMGKEECBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte NHNGLJGJIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte NLJEOOLCJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte DNEOPBGABLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte CGCKPFHPNPM;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	public static DDKENKMOBBI GGBAHLJJLHO(long MIPDHKKKMGD)
	{
		return default(DDKENKMOBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C31CA0", Offset = "0x6C302A0", VA = "0x186C31CA0")]
	public static DDKENKMOBBI GGBAHLJJLHO(byte EHEOELKFHDI, byte EGBNPHEEIKK, byte CFMOABHEOKM, byte DNJMMHAAONO, byte IGMDOKDIMOF, byte EGFNBICJNCJ, byte IILOLGHLLOM, byte LEFBKAEHLJC)
	{
		return default(DDKENKMOBBI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KLAHDEMEKLF : IEquatable<KLAHDEMEKLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte AIEDDEMDIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool MJMHOPJDLDF;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x26781E0", Offset = "0x26767E0", VA = "0x1826781E0")]
	public static KLAHDEMEKLF DGNDDBKJDKI(byte LNDOGMECFLJ)
	{
		return default(KLAHDEMEKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x26781E0", Offset = "0x26767E0", VA = "0x1826781E0")]
	public static KLAHDEMEKLF NEMPLKFAGFB(bool PCGLLKCAJJA)
	{
		return default(KLAHDEMEKLF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C34FC0", Offset = "0x6C335C0", VA = "0x186C34FC0")]
	public static bool MNAFCOICNLK(KLAHDEMEKLF JDKMLCHPKLA, KLAHDEMEKLF AENKMLMFBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5220", Offset = "0x5DD3820", VA = "0x185DD5220", Slot = "4")]
	public bool Equals(KLAHDEMEKLF PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C34F20", Offset = "0x6C33520", VA = "0x186C34F20", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C34FB0", Offset = "0x6C335B0", VA = "0x186C34FB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C34FD0", Offset = "0x6C335D0", VA = "0x186C34FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LOGBELMBOKN<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T NKHINKMIIOB;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4472020", Offset = "0x4470620", VA = "0x184472020")]
	public LOGBELMBOKN(T KIAIILFIJON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BAKEJECBNEK
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BFC0", Offset = "0x2A0A5C0", VA = "0x182A0BFC0")]
	public static IEnumerable<T> GBNOCMOALPN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	public static T[] MIKMBIJJKEN<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0")]
	public static IEnumerable<T> INCMIPEBJFB<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static HashSet<T> OBBFAGHFBEG<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BED0", Offset = "0x2A0A4D0", VA = "0x182A0BED0")]
	public static KeyValuePair<TKey, TValue> DMFDFGKJEPE<TKey, TValue>([In] TKey LFOBGDLOPID, [In] TValue KLABJGGMBGH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static List<T> ACGGHLGAMEB<T>(IEnumerable<T> KCIKOPILENN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MFCNOAAHFGA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string ANMKOFLNAIK;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
	public MFCNOAAHFGA(string OHIICHJPFBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object JEHELIIJAML<T>([In] T AAAOIGBEBAB);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object IGEHAJBKDGE<T>(T AAAOIGBEBAB);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CHEACOPOONL]
public delegate string MBIEIFCHNNP(string KLNAGGGGPDK, string? BPFGNDAPKAJ, bool GCEGJLCJDCG);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[CHEACOPOONL]
public delegate void EIMGOEJJJEK(string KFAOBDLOMDC);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[CHEACOPOONL]
public delegate void KHPKOKKHEFD(Exception NJACFNFHNDN);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object AIOKKEDGDOG();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[CHEACOPOONL]
public delegate bool MDAJHGCLDJH();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[CHEACOPOONL]
public delegate string AIPOLFLJAAK(object GHMNBJIOGAM);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class JONPHOABLGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
	public JONPHOABLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PBNLIPNIMDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct NFGPCNFKLMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C36790", Offset = "0x6C34D90", VA = "0x186C36790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6C37080", Offset = "0x6C35680", VA = "0x186C37080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback LJFBFFJOAIE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> IBIKHNEFDAH;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A0A0", Offset = "0x6C386A0", VA = "0x186C3A0A0")]
	public static Task<bool> AOPMFKFJPAO(int EHKFHDPLKAL, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A3A0", Offset = "0x6C389A0", VA = "0x186C3A3A0")]
	[AsyncStateMachine(typeof(NFGPCNFKLMI))]
	private static Task<bool> BLPNECFHICA(int EHKFHDPLKAL, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A4D0", Offset = "0x6C38AD0", VA = "0x186C3A4D0")]
	private static void GKBHLKHBKIJ(object? FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3A560", Offset = "0x6C38B60", VA = "0x186C3A560")]
	private static void KFFACHAPCAG(object? FDKAGJLJMPF)
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
