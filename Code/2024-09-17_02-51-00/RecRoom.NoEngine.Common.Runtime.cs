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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D1DA40", Offset = "0x6D1C440", VA = "0x186D1DA40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJNCAOBMHKC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D1FB50", Offset = "0x6D1E550", VA = "0x186D1FB50")]
	public static string ABBOAADIAKE(this Encoding BMDHMGFAICM, [In] ReadOnlySequence<byte> CNGBPDKMHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F1FD20", Offset = "0x2F1E720", VA = "0x182F1FD20")]
	private static void NMKBIKCOKKF<T>(this ReadOnlySequence<T> CPICPHKKOGA, [Out] ReadOnlySpan<T> LJNOMOOPMNL, [Out] SequencePosition NDHCCLMPCNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class ENAAEBHBKDI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D18B30", Offset = "0x6D17530", VA = "0x186D18B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DFA020", Offset = "0x3DF8A20", VA = "0x183DFA020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB160", Offset = "0x3DF9B60", VA = "0x183DFB160", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x408CFE0", Offset = "0x408B9E0", VA = "0x18408CFE0")]
	[AsyncStateMachine(typeof(IHIEKOCOAHN<>.FJNNDAIBBGP))]
	public Task<TResult> NDFJAFDOAEJ(BCDKMKADKHE JPGALEDIIAM, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x408CF70", Offset = "0x408B970", VA = "0x18408CF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x408D130", Offset = "0x408BB30", VA = "0x18408D130")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EB4AD0", Offset = "0x3EB34D0", VA = "0x183EB4AD0")]
	public GEJMDHFDMEL([In] T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4290", Offset = "0x3EB2C90", VA = "0x183EB4290", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4600", Offset = "0x3EB3000", VA = "0x183EB4600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EB48F0", Offset = "0x3EB32F0", VA = "0x183EB48F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class OCOMOHAHEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
	public static GEJMDHFDMEL<T> GGBAHLJJLHO<T>([In] T KLABJGGMBGH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class POAIALEGDNA
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D21830", Offset = "0x6D20230", VA = "0x186D21830")]
	public static void AIBHHBIOMMJ(this CancellationTokenSource ADHBHFEGLBD, bool DLKMAPBFNGF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CHEACOPOONL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
	public CHEACOPOONL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CPCEDDOKEKI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
	public CPCEDDOKEKI(string CGBLGAOGIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class AOCOGBCJNIM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x344F190", Offset = "0x344DB90", VA = "0x18344F190")]
	public static FBPLBJMCGOC BEJBFPAPGGM<T>()
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x344EEC0", Offset = "0x344D8C0", VA = "0x18344EEC0")]
	public static FBPLBJMCGOC AKEOHALHGGN<T>([CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x344F110", Offset = "0x344DB10", VA = "0x18344F110")]
	public static FBPLBJMCGOC BEJBFPAPGGM<T>(this T MNKBAIOBLHC) where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x344F210", Offset = "0x344DC10", VA = "0x18344F210")]
	public static FBPLBJMCGOC NKGBBILMKJB<T>(this T MNKBAIOBLHC, [CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x344EF60", Offset = "0x344D960", VA = "0x18344EF60")]
	public static FBPLBJMCGOC AKEOHALHGGN<T>(this T BJNJBGHPMEH, [CallerMemberName] string KJPHMNNIMDP = "") where T : notnull
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D17DB0", Offset = "0x6D167B0", VA = "0x186D17DB0")]
	public static FBPLBJMCGOC AKEOHALHGGN(string FDPIKPMCPPF, [CallerMemberName] string KJPHMNNIMDP = "")
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D17E30", Offset = "0x6D16830", VA = "0x186D17E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1ADE0", Offset = "0x6D197E0", VA = "0x186D1ADE0")]
		get
		{
			return default(FGEFFFCMDKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MPCJFPCFBLE GFNGAGNEIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D1AEF0", Offset = "0x6D198F0", VA = "0x186D1AEF0")]
		get
		{
			return default(MPCJFPCFBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static HPAPGHJDOEJ MKDNAOJAIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D1AEA0", Offset = "0x6D198A0", VA = "0x186D1AEA0")]
		get
		{
			return default(HPAPGHJDOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PPOFDFBEEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B090", Offset = "0x6D19A90", VA = "0x186D1B090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AB70", Offset = "0x6D19570", VA = "0x186D1AB70")]
	public static void EJBDNJOJABP([In] FGEFFFCMDKI GOGDNJAJCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AFC0", Offset = "0x6D199C0", VA = "0x186D1AFC0")]
	public static void OJMFFMAGFPH(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A920", Offset = "0x6D19320", VA = "0x186D1A920")]
	public static void BAFDALIIBIE(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E20280", Offset = "0x2E1EC80", VA = "0x182E20280")]
	public static void BAFDALIIBIE<T>(T IOBLLEKOCNN, IGEHAJBKDGE<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AA60", Offset = "0x6D19460", VA = "0x186D1AA60")]
	public static void CGGKMGOEAMC(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AF40", Offset = "0x6D19940", VA = "0x186D1AF40")]
	public static void ICKJCINIDIB(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AB00", Offset = "0x6D19500", VA = "0x186D1AB00")]
	public static void CJPGHLMADAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AE30", Offset = "0x6D19830", VA = "0x186D1AE30")]
	public static string HEIHMHFEGGB(object GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A9F0", Offset = "0x6D193F0", VA = "0x186D1A9F0")]
	public static long BKAGOLNIMBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B100", Offset = "0x6D19B00", VA = "0x186D1B100")]
	public static bool PEEPLDCGABI(bool ACJMHFFHANF, string KFAOBDLOMDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AD10", Offset = "0x6D19710", VA = "0x186D1AD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D18D30", Offset = "0x6D17730", VA = "0x186D18D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D196C0", Offset = "0x6D180C0", VA = "0x186D196C0")]
	public FGEFFFCMDKI([In] MPCJFPCFBLE PODGMFBDLGG, [In] HPAPGHJDOEJ GFOPEKHOEME, AIPOLFLJAAK NJFDDCEFJCF, FIBHDIFKCIN JNNCFPEAIDI, MBIEIFCHNNP PEONFOFDABH, HMAJCGBAGMO LGKFEHCEGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D18EC0", Offset = "0x6D178C0", VA = "0x186D18EC0")]
	private static string MJEENFIBOCE(object GHMNBJIOGAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
	private static long LANGNGGPKCA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	private static string EMOIALNHNOG(string KLNAGGGGPDK, string? BPFGNDAPKAJ, bool GCEGJLCJDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	private static bool LIKMJKKOCIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D18F00", Offset = "0x6D17900", VA = "0x186D18F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x217CF40", Offset = "0x217B940", VA = "0x18217CF40")]
	public MGBLPJABDKK([In] T KLABJGGMBGH, int HGFDMIDEFHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x476B8D0", Offset = "0x476A2D0", VA = "0x18476B8D0")]
	public static bool MNAFCOICNLK([In] MGBLPJABDKK<T> NFCDCHABNCB, [In] MGBLPJABDKK<T> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x476A4C0", Offset = "0x4768EC0", VA = "0x18476A4C0", Slot = "4")]
	public bool Equals(MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A36D20", Offset = "0x3A35720", VA = "0x183A36D20", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x476A390", Offset = "0x4768D90", VA = "0x18476A390")]
	public bool ELNMFHABHNG([In] MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x476A7F0", Offset = "0x47691F0", VA = "0x18476A7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x476C0F0", Offset = "0x476AAF0", VA = "0x18476C0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x476AFC0", Offset = "0x47699C0", VA = "0x18476AFC0")]
	public void MMDHOICOGNG([Out] T KLABJGGMBGH, [Out] int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x476AA60", Offset = "0x4769460", VA = "0x18476AA60")]
	public (T, int) IHAFMFKNODA()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x476BAB0", Offset = "0x476A4B0", VA = "0x18476BAB0", Slot = "5")]
	private bool PFNDGAFMDKE([In] MGBLPJABDKK<T> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GEJJMLICAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3BF0", Offset = "0x2DA25F0", VA = "0x182DA3BF0")]
	public static MGBLPJABDKK<T> GGBAHLJJLHO<T>([In] T KLABJGGMBGH, int HGFDMIDEFHN) where T : notnull
	{
		return default(MGBLPJABDKK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NEMGBEAPILP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EE4600", Offset = "0x2EE3000", VA = "0x182EE4600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1C460", Offset = "0x6D1AE60", VA = "0x186D1C460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xD9D0E0", Offset = "0xD9BAE0", VA = "0x180D9D0E0")]
	public MPCJFPCFBLE(MDAJHGCLDJH LCMHIFACPDN, EIMGOEJJJEK ACFJEDKLDJL, MDAJHGCLDJH BPBIJPGKMAB, EIMGOEJJJEK HPLPBOIIFLF, MDAJHGCLDJH CKJLLJKIPEE, EIMGOEJJJEK CLCCLIDCEMC, KHPKOKKHEFD CBCBFGGIOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	private static bool BJDIIBGHHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void LIPHLKANMNN(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	private static bool ODJCDBOHDDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void EBPCAPMAPNA(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
	private static bool LJMHCHNBINB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void FCNEPMAPPMI(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void ILBEAPHJIAN(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C640", Offset = "0x6D1B040", VA = "0x186D1C640")]
	private static MPCJFPCFBLE NIHICLBFHCK()
	{
		return default(MPCJFPCFBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
	private static bool DEMDDMIOLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C780", Offset = "0x6D1B180", VA = "0x186D1C780")]
	public void OJMFFMAGFPH(object KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C3F0", Offset = "0x6D1ADF0", VA = "0x186D1C3F0")]
	public void BAFDALIIBIE(object KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E5D0", Offset = "0x1F8CFD0", VA = "0x181F8E5D0")]
	public void CGGKMGOEAMC(Exception NJACFNFHNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C310", Offset = "0x6D1AD10", VA = "0x186D1C310")]
	public void BAFDALIIBIE(AIOKKEDGDOG KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E83090", Offset = "0x2E81A90", VA = "0x182E83090")]
	public void BAFDALIIBIE<T>(T IOBLLEKOCNN, IGEHAJBKDGE<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E83160", Offset = "0x2E81B60", VA = "0x182E83160")]
	public void OJMFFMAGFPH<T>([In] T IOBLLEKOCNN, JEHELIIJAML<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E82E20", Offset = "0x2E81820", VA = "0x182E82E20")]
	public void BAFDALIIBIE<T>([In] T IOBLLEKOCNN, JEHELIIJAML<T> KFAOBDLOMDC) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C7F0", Offset = "0x6D1B1F0", VA = "0x186D1C7F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	public FBPLBJMCGOC(string KLABJGGMBGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0")]
	public static string BIEOCAPMHCM([In] FBPLBJMCGOC BJNJBGHPMEH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xBCF820", Offset = "0xBCE220", VA = "0x180BCF820")]
	public static FBPLBJMCGOC BIEOCAPMHCM(string PLNBHPCFEOK)
	{
		return default(FBPLBJMCGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D18C00", Offset = "0x6D17600", VA = "0x186D18C00")]
	public string HNFLNJBDOKM(string NFDBNIDBLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D18C50", Offset = "0x6D17650", VA = "0x186D18C50")]
	public string POJMAMLEACN(object OADFIADCCGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "4")]
	public bool Equals(BLGMJKLPHOM PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D18110", Offset = "0x6D16B10", VA = "0x186D18110", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D18160", Offset = "0x6D16B60", VA = "0x186D18160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D18170", Offset = "0x6D16B70", VA = "0x186D18170", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4901240", Offset = "0x48FFC40", VA = "0x184901240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4901990", Offset = "0x4900390", VA = "0x184901990")]
	public OLCEOJBLPLC([In] T KLABJGGMBGH, bool JPFNBPGCEFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4900ED0", Offset = "0x48FF8D0", VA = "0x184900ED0")]
	public static bool MNAFCOICNLK([In] OLCEOJBLPLC<T> NFCDCHABNCB, [In] OLCEOJBLPLC<T> BCBMNIEKAKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x476A4C0", Offset = "0x4768EC0", VA = "0x18476A4C0", Slot = "4")]
	public bool Equals(OLCEOJBLPLC<T> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4900310", Offset = "0x48FED10", VA = "0x184900310", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4900750", Offset = "0x48FF150", VA = "0x184900750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4901750", Offset = "0x4900150", VA = "0x184901750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LBLOMBHLFHG
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CE70", Offset = "0x2E4B870", VA = "0x182E4CE70")]
	public static OLCEOJBLPLC<T> IPPCPPHHJML<T>([In] T KLABJGGMBGH) where T : notnull
	{
		return default(OLCEOJBLPLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D000", Offset = "0x2E4BA00", VA = "0x182E4D000")]
	public static OLCEOJBLPLC<T?> MMLDELMJFDD<T>()
	{
		return default(OLCEOJBLPLC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CD80", Offset = "0x2E4B780", VA = "0x182E4CD80")]
	public static bool ADJJFPEJKAG<T>([In] this OLCEOJBLPLC<T> LBEOMMDHIIP, [Out][NotNullWhen(true)] T KLABJGGMBGH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2E4CDB0", Offset = "0x2E4B7B0", VA = "0x182E4CDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D19F00", Offset = "0x6D18900", VA = "0x186D19F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
	public HPAPGHJDOEJ(IntPtr LODJEMEPMMA, IntPtr OCPEBJLONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void EPKEPLPACPC(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void MACKOMJPHIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D19FD0", Offset = "0x6D189D0", VA = "0x186D19FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB66C60", Offset = "0xB65660", VA = "0x180B66C60")]
	private LJBEPFFMPFD(IntPtr OCPEBJLONNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B9E0", Offset = "0x6D1A3E0", VA = "0x186D1B9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1BA00", Offset = "0x6D1A400", VA = "0x186D1BA00")]
	public static LJBEPFFMPFD GGBAHLJJLHO(string KJPHMNNIMDP)
	{
		return default(LJBEPFFMPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2154260", Offset = "0x2152C60", VA = "0x182154260")]
	public static LJBEPFFMPFD GGBAHLJJLHO([In] HPAPGHJDOEJ GFOPEKHOEME, string KJPHMNNIMDP)
	{
		return default(LJBEPFFMPFD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x21541F0", Offset = "0x2152BF0", VA = "0x1821541F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D19C70", Offset = "0x6D18670", VA = "0x186D19C70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D19CD0", Offset = "0x6D186D0", VA = "0x186D19CD0", Slot = "6")]
			public void OnCompleted(Action FHCABKEHDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			public void OOOBGLGFFBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public HDMINPKDDFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly AIGIMJHGFBI DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		private AIGIMJHGFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D17CF0", Offset = "0x6D166F0", VA = "0x186D17CF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D20A20", Offset = "0x6D1F420", VA = "0x186D20A20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6D20A40", Offset = "0x6D1F440", VA = "0x186D20A40", Slot = "6")]
			public void OnCompleted(Action FHCABKEHDKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			public void OOOBGLGFFBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public OPJLKBEIBGC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DNLLKFNEADB DFEEMNKDOMA;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		private DNLLKFNEADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D18610", Offset = "0x6D17010", VA = "0x186D18610", Slot = "4")]
		public GACBCMNHFEC GPOPJKKIDGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EIGFJJEMFGM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EIGFJJEMFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A36BD0", Offset = "0x3A355D0", VA = "0x183A36BD0")]
		internal void GBNPCCGIOEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LOEIOEBFGNP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public LOEIOEBFGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4549EC0", Offset = "0x45488C0", VA = "0x184549EC0")]
		internal void HLGPEHHCLIA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DJBCKEACFLJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D184B0", Offset = "0x6D16EB0", VA = "0x186D184B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ONKBILKPGGP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D20110", Offset = "0x6D1EB10", VA = "0x186D20110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DKDAHIADAKI<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x5B51C40", Offset = "0x5B50640", VA = "0x185B51C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5B51DB0", Offset = "0x5B507B0", VA = "0x185B51DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PECCIMCOCAG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x49E7030", Offset = "0x49E5A30", VA = "0x1849E7030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x49E78C0", Offset = "0x49E62C0", VA = "0x1849E78C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NAIGHGDANJO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1CE70", Offset = "0x6D1B870", VA = "0x186D1CE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D070", Offset = "0x6D1BA70", VA = "0x186D1D070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GFMJKFLJCEJ<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GFMJKFLJCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A36BD0", Offset = "0x3A355D0", VA = "0x183A36BD0")]
		internal void KHKHFPIINMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4440", Offset = "0x3ED2E40", VA = "0x183ED4440")]
		internal void CFCJJJCJAAF(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct IMDAHLJNEHF<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x40B5E10", Offset = "0x40B4810", VA = "0x1840B5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x40B6580", Offset = "0x40B4F80", VA = "0x1840B6580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct POFELIJJKGL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D21860", Offset = "0x6D20260", VA = "0x186D21860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D22050", Offset = "0x6D20A50", VA = "0x186D22050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IHNIJHAIAGJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1A1A0", Offset = "0x6D18BA0", VA = "0x186D1A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A6E0", Offset = "0x6D190E0", VA = "0x186D1A6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PNJOAMLCLAP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4A1CF30", Offset = "0x4A1B930", VA = "0x184A1CF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4A1DE80", Offset = "0x4A1C880", VA = "0x184A1DE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JDBNJDOFOFP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x426FC00", Offset = "0x426E600", VA = "0x18426FC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x37663F0", Offset = "0x3764DF0", VA = "0x1837663F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BBBPPIHEPNO<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5101420", Offset = "0x50FFE20", VA = "0x185101420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5101B60", Offset = "0x5100560", VA = "0x185101B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BFNJJAGFOEO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D17ED0", Offset = "0x6D168D0", VA = "0x186D17ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D180B0", Offset = "0x6D16AB0", VA = "0x186D180B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LOKGDGPFHCP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1BB00", Offset = "0x6D1A500", VA = "0x186D1BB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D1BE60", Offset = "0x6D1A860", VA = "0x186D1BE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct EBEGDBDMGOH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D187E0", Offset = "0x6D171E0", VA = "0x186D187E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D18AD0", Offset = "0x6D174D0", VA = "0x186D18AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HMGAGLPALFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public HMGAGLPALFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D19E90", Offset = "0x6D18890", VA = "0x186D19E90")]
		internal Task AHCLAGKEDBD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct GANNGGHICOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D199B0", Offset = "0x6D183B0", VA = "0x186D199B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D19C10", Offset = "0x6D18610", VA = "0x186D19C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct FLBBMKJMDPB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D19770", Offset = "0x6D18170", VA = "0x186D19770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D19950", Offset = "0x6D18350", VA = "0x186D19950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OAIADNBLIGG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1DAC0", Offset = "0x6D1C4C0", VA = "0x186D1DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D1DE20", Offset = "0x6D1C820", VA = "0x186D1DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MBLPLFCHKNM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1BFC0", Offset = "0x6D1A9C0", VA = "0x186D1BFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C2B0", Offset = "0x6D1ACB0", VA = "0x186D1C2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AHDIBJLIOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public AHDIBJLIOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D17C80", Offset = "0x6D16680", VA = "0x186D17C80")]
		internal Task DBHJLPNPNEC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CKKIKDJDAOM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D181A0", Offset = "0x6D16BA0", VA = "0x186D181A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D18400", Offset = "0x6D16E00", VA = "0x186D18400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct JAAHGMPKHDN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1A740", Offset = "0x6D19140", VA = "0x186D1A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A8C0", Offset = "0x6D192C0", VA = "0x186D1A8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LNGKMNCIGFP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x44E6B90", Offset = "0x44E5590", VA = "0x1844E6B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x44E6E10", Offset = "0x44E5810", VA = "0x1844E6E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct LBLMBPHDHLC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6D1B570", Offset = "0x6D19F70", VA = "0x186D1B570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B980", Offset = "0x6D1A380", VA = "0x186D1B980", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1F0F0", Offset = "0x6D1DAF0", VA = "0x186D1F0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DF00", Offset = "0x6D1C900", VA = "0x186D1DF00")]
	public static bool BGINOIBJOMN(this Task KECDGIGMBNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A820", Offset = "0x2F19220", VA = "0x182F1A820")]
	public static Task<T> CJMJEMFLCAA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E540", Offset = "0x6D1CF40", VA = "0x186D1E540")]
	public static Task DDPFJPGNADI(this Task KECDGIGMBNG, CancellationToken FLLNLBHFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F1C900", Offset = "0x2F1B300", VA = "0x182F1C900")]
	public static Task<TResult> DDPFJPGNADI<TResult>(this Task<TResult> KECDGIGMBNG, CancellationToken FLLNLBHFENG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2F1DBA0", Offset = "0x2F1C5A0", VA = "0x182F1DBA0")]
	public static TaskCompletionSource<TResult> DDPFJPGNADI<TResult>(this TaskCompletionSource<TResult> NKDMIPFFBGD, CancellationToken FLLNLBHFENG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EC30", Offset = "0x6D1D630", VA = "0x186D1EC30")]
	public static IDisposable? EKCNOJCMFKB(CancellationToken GGIIHCIDCPD, CancellationToken JEOGCJFLJGK, [Out] CancellationToken HGEOJOBFIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F9E0", Offset = "0x6D1E3E0", VA = "0x186D1F9E0")]
	[AsyncStateMachine(typeof(DJBCKEACFLJ))]
	public static void PAEGHBDLGGO(this Task KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EB80", Offset = "0x6D1D580", VA = "0x186D1EB80")]
	[AsyncStateMachine(typeof(ONKBILKPGGP))]
	public static void DPLMAKKPJCO(this Task KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E530", Offset = "0x2F1CF30", VA = "0x182F1E530")]
	[AsyncStateMachine(typeof(DKDAHIADAKI<>))]
	public static Task GGLDGNJEALF<TException>(this Task KGPMLIHPPAA) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EF00", Offset = "0x2F1D900", VA = "0x182F1EF00")]
	[AsyncStateMachine(typeof(PECCIMCOCAG<>))]
	public static Task<T> ODNFCKLGLPM<T>(this Task<T> BJNJBGHPMEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F160", Offset = "0x6D1DB60", VA = "0x186D1F160")]
	[AsyncStateMachine(typeof(NAIGHGDANJO))]
	public static Task<TaskStatus> HIFMEBJNGNF(this Task BJNJBGHPMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E9B0", Offset = "0x2F1D3B0", VA = "0x182F1E9B0")]
	public static (Task<T?>?, Action<T?>?) JKNPKJADCIE<T>([Optional] CancellationToken IONNNJNKLMJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E600", Offset = "0x2F1D000", VA = "0x182F1E600")]
	[AsyncStateMachine(typeof(IMDAHLJNEHF<, >))]
	public static Task<List<TResult>> HOEMEOCNFAG<TResult, TInput>(this Task<List<TInput>> KECDGIGMBNG, ACMBNKOBNAM<TInput, TResult> BFBEGMEGHMD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EDC0", Offset = "0x6D1D7C0", VA = "0x186D1EDC0")]
	[AsyncStateMachine(typeof(POFELIJJKGL))]
	public static Task GKAOIGGINPC(Task KGPMLIHPPAA, CancellationToken LBFDJGLPAMK, Func<CancellationToken, Task> CAIIFNPNIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F250", Offset = "0x6D1DC50", VA = "0x186D1F250")]
	[AsyncStateMachine(typeof(IHNIJHAIAGJ))]
	public static Task IBGCPNHJDIO(Func<CancellationToken, Task> POBEKJIJHNB, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken LBFDJGLPAMK, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E710", Offset = "0x2F1D110", VA = "0x182F1E710")]
	[AsyncStateMachine(typeof(PNJOAMLCLAP<>))]
	public static Task<T> IBGCPNHJDIO<T>(Func<CancellationToken, Task<T>> POBEKJIJHNB, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken LBFDJGLPAMK, [Optional] Func<OperationCanceledException, T>? HENHCAAMINC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EE10", Offset = "0x2F1D810", VA = "0x182F1EE10")]
	[AsyncStateMachine(typeof(JDBNJDOFOFP<>))]
	public static Task<IEnumerable<Task<T>>> KAPJJLHBNGD<T>(IEnumerable<Task<T>> GCGPKEICBKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A560", Offset = "0x2F18F60", VA = "0x182F1A560")]
	[AsyncStateMachine(typeof(BBBPPIHEPNO<, , , >))]
	public static Task<(T1, T2, T3, T4)> BMMCANNHLHP<T1, T2, T3, T4>(Task<T1> BLPIIMELGPI, Task<T2> DALKNEHHFJA, Task<T3> CJGDOCAFLBK, Task<T4> ACDJJBOAALK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DF30", Offset = "0x6D1C930", VA = "0x186D1DF30")]
	[AsyncStateMachine(typeof(BFNJJAGFOEO))]
	public static Task BLPEHMKPFBG(Func<bool> ACJMHFFHANF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E020", Offset = "0x6D1CA20", VA = "0x186D1E020")]
	[AsyncStateMachine(typeof(LOKGDGPFHCP))]
	public static Task BLPEHMKPFBG(Func<bool> ACJMHFFHANF, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EA50", Offset = "0x6D1D450", VA = "0x186D1EA50")]
	[AsyncStateMachine(typeof(EBEGDBDMGOH))]
	public static Task DJHHNPDCAKB(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E910", Offset = "0x6D1D310", VA = "0x186D1E910")]
	[AsyncStateMachine(typeof(GANNGGHICOO))]
	public static Task DJHHNPDCAKB(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F000", Offset = "0x6D1DA00", VA = "0x186D1F000")]
	[AsyncStateMachine(typeof(FLBBMKJMDPB))]
	public static Task GMEIKEKILMM(Func<bool> ACJMHFFHANF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D1EEF0", Offset = "0x6D1D8F0", VA = "0x186D1EEF0")]
	[AsyncStateMachine(typeof(OAIADNBLIGG))]
	public static Task GMEIKEKILMM(Func<bool> ACJMHFFHANF, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F610", Offset = "0x6D1E010", VA = "0x186D1F610")]
	[AsyncStateMachine(typeof(MBLPLFCHKNM))]
	public static Task LLLIEFEJEDK(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F740", Offset = "0x6D1E140", VA = "0x186D1F740")]
	[AsyncStateMachine(typeof(CKKIKDJDAOM))]
	public static Task LLLIEFEJEDK(Func<bool> ACJMHFFHANF, TimeSpan PFFHGEAHJBE, TimeSpan BAPMFCKCGGF, [Optional] CancellationToken IONNNJNKLMJ, [Optional] Action<OperationCanceledException>? HENHCAAMINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F520", Offset = "0x6D1DF20", VA = "0x186D1F520")]
	[Obsolete]
	[AsyncStateMachine(typeof(JAAHGMPKHDN))]
	public static Task JOCPKLFBAKJ(this Task KECDGIGMBNG, Action DJMJKLDKDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F1EC30", Offset = "0x2F1D630", VA = "0x182F1EC30")]
	[AsyncStateMachine(typeof(LNGKMNCIGFP<>))]
	[Obsolete]
	public static Task JOCPKLFBAKJ<T>(this Task<T> KECDGIGMBNG, Action<T> DJMJKLDKDKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E130", Offset = "0x6D1CB30", VA = "0x186D1E130")]
	private static void BPHFFBOEOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E1E0", Offset = "0x6D1CBE0", VA = "0x186D1E1E0")]
	public static bool CIGEGCNCOJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D1E790", Offset = "0x6D1D190", VA = "0x186D1E790")]
	private static void DEJBDHPHNHM(SynchronizationContext KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F880", Offset = "0x6D1E280", VA = "0x186D1F880")]
	private static void LNGDIEMKNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F450", Offset = "0x6D1DE50", VA = "0x186D1F450")]
	public static void JNLJDJNALDG([Optional] string? KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D1DE80", Offset = "0x6D1C880", VA = "0x186D1DE80")]
	public static void AMPMGJHEIFL([Optional] string? KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D1ED70", Offset = "0x6D1D770", VA = "0x186D1ED70")]
	public static HIEHGJINBBC GGCKFPIABNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F990", Offset = "0x6D1E390", VA = "0x186D1F990")]
	public static HIEHGJINBBC OLIDHCNGBAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D1F380", Offset = "0x6D1DD80", VA = "0x186D1F380")]
	[AsyncStateMachine(typeof(LBLMBPHDHLC))]
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
	[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D186D0", Offset = "0x6D170D0", VA = "0x186D186D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset GDNCHMKEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6D18710", Offset = "0x6D17110", VA = "0x186D18710", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D20460", Offset = "0x6D1EE60", VA = "0x186D20460")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D20640", Offset = "0x6D1F040", VA = "0x186D20640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D205F0", Offset = "0x6D1EFF0", VA = "0x186D205F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D202F0", Offset = "0x6D1ECF0", VA = "0x186D202F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D20510", Offset = "0x6D1EF10", VA = "0x186D20510")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D20730", Offset = "0x6D1F130", VA = "0x186D20730")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D20340", Offset = "0x6D1ED40", VA = "0x186D20340")]
	public static double FEGBDCFODKG(long HHBFIIPPGKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D203D0", Offset = "0x6D1EDD0", VA = "0x186D203D0")]
	public static double FEHOJFKNIML(long HHBFIIPPGKM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D206A0", Offset = "0x6D1F0A0", VA = "0x186D206A0")]
	public static double OIJJGPELJNL(double OHAHDFKOMDO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D20560", Offset = "0x6D1EF60", VA = "0x186D20560")]
	public static long JGGFBMAJIKB(long GMOGAEOJHDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D20690", Offset = "0x6D1F090", VA = "0x186D20690")]
	public static long OFEGCKLLLHH(long OMHBPMKMFPM, long GMJHNNJMKOD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D20220", Offset = "0x6D1EC20", VA = "0x186D20220")]
	public static double BFBNIIPDPNH(long OMHBPMKMFPM, long GMJHNNJMKOD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D204B0", Offset = "0x6D1EEB0", VA = "0x186D204B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D21150", Offset = "0x6D1FB50", VA = "0x186D21150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? NDJKCHHCBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D217D0", Offset = "0x6D201D0", VA = "0x186D217D0")]
	[Preserve]
	public PEKKJKCLOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D21580", Offset = "0x6D1FF80", VA = "0x186D21580")]
	public PEKKJKCLOJF(TimeSpan PFFHGEAHJBE, [Optional] Action? LJFNMGJHFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D213F0", Offset = "0x6D1FDF0", VA = "0x186D213F0", Slot = "7")]
	public void LHKIFFPBGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D21380", Offset = "0x6D1FD80", VA = "0x186D21380", Slot = "8")]
	public void JLCIBMMIOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D21350", Offset = "0x6D1FD50", VA = "0x186D21350", Slot = "9")]
	public void FCHFEKGILOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xB83530", Offset = "0xB81F30", VA = "0x180B83530")]
	private void FAGGEBONHGD(object MNKBAIOBLHC, ElapsedEventArgs HFDNGGADMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D21480", Offset = "0x6D1FE80", VA = "0x186D21480")]
	private static void MHHFEJNIOFE(TimeSpan FECOONDAGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D212B0", Offset = "0x6D1FCB0", VA = "0x186D212B0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x981510", Offset = "0x97FF10", VA = "0x180981510")]
	public EMDAHHLEKNJ(string PADNFDKMCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x410E180", Offset = "0x410CB80", VA = "0x18410E180")]
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
	[Cpp2IlInjected.Address(RVA = "0x16172F0", Offset = "0x1615CF0", VA = "0x1816172F0")]
	public static POJKEEADMGJ ICPJEDFJEJN(uint PBHKALJHGEN)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x16172F0", Offset = "0x1615CF0", VA = "0x1816172F0")]
	public static POJKEEADMGJ CINKIIHJGNE(int NLICHAIBNKJ)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6D220B0", Offset = "0x6D20AB0", VA = "0x186D220B0")]
	public static POJKEEADMGJ BEIOJOGEKGL(float PJODCDAILHE)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6D220C0", Offset = "0x6D20AC0", VA = "0x186D220C0")]
	public static POJKEEADMGJ DGNDDBKJDKI(byte EHEOELKFHDI, byte EGBNPHEEIKK, byte CFMOABHEOKM, byte DNJMMHAAONO)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6D220C0", Offset = "0x6D20AC0", VA = "0x186D220C0")]
	public static POJKEEADMGJ NEMPLKFAGFB(bool OACCMDHCEMC, bool MEMJFJLFJOP, bool CKMFLENMMHC, bool HAMPPBAAFNL)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6D220C0", Offset = "0x6D20AC0", VA = "0x186D220C0")]
	public static POJKEEADMGJ FCHGKBCFDGN(byte PMONOHICICO, byte ILOJJMMHPDI, byte INCPABHDFEJ, byte MACCLNGPCAN)
	{
		return default(POJKEEADMGJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B2D0", Offset = "0x1E09CD0", VA = "0x181E0B2D0")]
	public static bool MNAFCOICNLK(POJKEEADMGJ JDKMLCHPKLA, POJKEEADMGJ AENKMLMFBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xC63B20", Offset = "0xC62520", VA = "0x180C63B20", Slot = "4")]
	public bool Equals(POJKEEADMGJ PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6D220E0", Offset = "0x6D20AE0", VA = "0x186D220E0", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xD04700", Offset = "0xD03100", VA = "0x180D04700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6D22160", Offset = "0x6D20B60", VA = "0x186D22160", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static DDKENKMOBBI GGBAHLJJLHO(long MIPDHKKKMGD)
	{
		return default(DDKENKMOBBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6D18460", Offset = "0x6D16E60", VA = "0x186D18460")]
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
	[Cpp2IlInjected.Address(RVA = "0x271F5C0", Offset = "0x271DFC0", VA = "0x18271F5C0")]
	public static KLAHDEMEKLF DGNDDBKJDKI(byte LNDOGMECFLJ)
	{
		return default(KLAHDEMEKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x271F5C0", Offset = "0x271DFC0", VA = "0x18271F5C0")]
	public static KLAHDEMEKLF NEMPLKFAGFB(bool PCGLLKCAJJA)
	{
		return default(KLAHDEMEKLF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B300", Offset = "0x6D19D00", VA = "0x186D1B300")]
	public static bool MNAFCOICNLK(KLAHDEMEKLF JDKMLCHPKLA, KLAHDEMEKLF AENKMLMFBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8960", Offset = "0x5EB7360", VA = "0x185EB8960", Slot = "4")]
	public bool Equals(KLAHDEMEKLF PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B260", Offset = "0x6D19C60", VA = "0x186D1B260", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B2F0", Offset = "0x6D19CF0", VA = "0x186D1B2F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B310", Offset = "0x6D19D10", VA = "0x186D1B310", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4549ED0", Offset = "0x45488D0", VA = "0x184549ED0")]
	public LOGBELMBOKN(T KIAIILFIJON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BAKEJECBNEK
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDBA0", Offset = "0x2ACC5A0", VA = "0x182ACDBA0")]
	public static IEnumerable<T> GBNOCMOALPN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static T[] MIKMBIJJKEN<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0")]
	public static IEnumerable<T> INCMIPEBJFB<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
	public static HashSet<T> OBBFAGHFBEG<T>(params T[] JLOKIHEKANI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDAB0", Offset = "0x2ACC4B0", VA = "0x182ACDAB0")]
	public static KeyValuePair<TKey, TValue> DMFDFGKJEPE<TKey, TValue>([In] TKey LFOBGDLOPID, [In] TValue KLABJGGMBGH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1D0E0", Offset = "0x6D1BAE0", VA = "0x186D1D0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D9D0", Offset = "0x6D1C3D0", VA = "0x186D1D9D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6D20B00", Offset = "0x6D1F500", VA = "0x186D20B00")]
	public static Task<bool> AOPMFKFJPAO(int EHKFHDPLKAL, [Optional] CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D20E00", Offset = "0x6D1F800", VA = "0x186D20E00")]
	[AsyncStateMachine(typeof(NFGPCNFKLMI))]
	private static Task<bool> BLPNECFHICA(int EHKFHDPLKAL, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D20F30", Offset = "0x6D1F930", VA = "0x186D20F30")]
	private static void GKBHLKHBKIJ(object? FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D20FC0", Offset = "0x6D1F9C0", VA = "0x186D20FC0")]
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
