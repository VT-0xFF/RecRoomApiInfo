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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAC00", Offset = "0x6EAA000", VA = "0x186EAAC00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCIBNALJPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8710", Offset = "0x6EA7B10", VA = "0x186EA8710")]
	public static string GEJGPAHCLKD(this Encoding BNBJNEPHHBM, [In] ReadOnlySequence<byte> FAHBHOHHIKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E360", Offset = "0x2E6D760", VA = "0x182E6E360")]
	private static void HABDGPMLOHG<T>(this ReadOnlySequence<T> JNDDGFBGMGM, [Out] ReadOnlySpan<T> BBPGEKNIACP, [Out] SequencePosition OEPHNJIEIHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NKPLKJOGGJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAB20", Offset = "0x6EA9F20", VA = "0x186EAAB20")]
	public NKPLKJOGGJO(bool DNJHDICOKMC, string EKOHICHPJCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PIODECCCBHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FCEEOEKGGFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DDOCPAGPFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOJNHPDBCNA(string OEOMDKHBDFI, double EEPLCHCGAIN, [Optional] string? PGKHKLCHAFL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OADNMONDHMA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> EPPCLBKNEEK(CancellationToken NBBCMDKGJKI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FGCOCACIOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OADNMONDHMA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public EPPCLBKNEEK taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3F37D10", Offset = "0x3F37110", VA = "0x183F37D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F38E50", Offset = "0x3F38250", VA = "0x183F38E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource INALIICJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? KJFFGNBLOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? FBFAHIIPGBB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49FD4D0", Offset = "0x49FC8D0", VA = "0x1849FD4D0")]
	[AsyncStateMachine(typeof(OADNMONDHMA<>.FGCOCACIOPL))]
	public Task<TResult> EBANIHHBIAF(EPPCLBKNEEK IMCHGMIDLKN, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49FD460", Offset = "0x49FC860", VA = "0x1849FD460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49FD620", Offset = "0x49FCA20", VA = "0x1849FD620")]
	public OADNMONDHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FIDCEOKODPB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> LNDMNECEKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T EEMLDMGPOLA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F474F0", Offset = "0x3F468F0", VA = "0x183F474F0")]
	public FIDCEOKODPB([In] T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F464E0", Offset = "0x3F458E0", VA = "0x183F464E0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F46BA0", Offset = "0x3F45FA0", VA = "0x183F46BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F46E60", Offset = "0x3F46260", VA = "0x183F46E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NGNFDFDNCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static FIDCEOKODPB<T> AHLALEPNKFA<T>([In] T EEPLCHCGAIN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FHMLFBGAEPI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6690", Offset = "0x6EA5A90", VA = "0x186EA6690")]
	public static void GOGHBMEPFMN(this CancellationTokenSource INALIICJMHK, bool OGHMLOKOOIJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class AEIHBJEKLCG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
	public AEIHBJEKLCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class BFAKOGDFABI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
	public BFAKOGDFABI(string FPFBKANDLNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class EMPHCGJAMCF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD49E0", Offset = "0x2CD3DE0", VA = "0x182CD49E0")]
	public static NKKDGOJHDPD NNBLBJFKHFC<T>()
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD47F0", Offset = "0x2CD3BF0", VA = "0x182CD47F0")]
	public static NKKDGOJHDPD HJFIGAOJMIL<T>([CallerMemberName] string DDDHPCNFCEK = "") where T : notnull
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4A60", Offset = "0x2CD3E60", VA = "0x182CD4A60")]
	public static NKKDGOJHDPD NNBLBJFKHFC<T>(this T EFCBJHHANBC) where T : notnull
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4890", Offset = "0x2CD3C90", VA = "0x182CD4890")]
	public static NKKDGOJHDPD MMGEHEKFMIF<T>(this T EFCBJHHANBC, [CallerMemberName] string DDDHPCNFCEK = "") where T : notnull
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4740", Offset = "0x2CD3B40", VA = "0x182CD4740")]
	public static NKKDGOJHDPD HJFIGAOJMIL<T>(this T MCPMOAEEEOJ, [CallerMemberName] string DDDHPCNFCEK = "") where T : notnull
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5E90", Offset = "0x6EA5290", VA = "0x186EA5E90")]
	public static NKKDGOJHDPD HJFIGAOJMIL(string ONKEPCHFHLK, [CallerMemberName] string DDDHPCNFCEK = "")
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5F10", Offset = "0x6EA5310", VA = "0x186EA5F10")]
	public static string JPLHANPIJFD(this object MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool PHJGIKJOBHO();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[AEIHBJEKLCG]
public delegate long BBABJHJLHIE();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DFFEIOLLIKE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static PIINJNDNOHK HLCPLIIEELI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PIINJNDNOHK NLKBLNBODBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EA59A0", Offset = "0x6EA4DA0", VA = "0x186EA59A0")]
		get
		{
			return default(PIINJNDNOHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GKLJAAGFCCM OEMMPLOLEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5AD0", Offset = "0x6EA4ED0", VA = "0x186EA5AD0")]
		get
		{
			return default(GKLJAAGFCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static GGEKMJMDANN BPICJOBFFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5550", Offset = "0x6EA4950", VA = "0x186EA5550")]
		get
		{
			return default(GGEKMJMDANN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool DJOOPPAIMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EA55A0", Offset = "0x6EA49A0", VA = "0x186EA55A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5690", Offset = "0x6EA4A90", VA = "0x186EA5690")]
	public static void GACNAKGIODK([In] PIINJNDNOHK ICFLMFGGGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5D00", Offset = "0x6EA5100", VA = "0x186EA5D00")]
	public static void PKELKJJEMAA(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5B20", Offset = "0x6EA4F20", VA = "0x186EA5B20")]
	public static void MLPOCEDOOEN(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1140", Offset = "0x2CA0540", VA = "0x182CA1140")]
	public static void MLPOCEDOOEN<T>(T NDJFIKMCNAE, CBNCNMOBIJL<T> MOKGCFCFCPE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5BF0", Offset = "0x6EA4FF0", VA = "0x186EA5BF0")]
	public static void NBABLAMEJFE(Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5610", Offset = "0x6EA4A10", VA = "0x186EA5610")]
	public static void FNKAHCLIPBN(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5A60", Offset = "0x6EA4E60", VA = "0x186EA5A60")]
	public static void KLEOBNBGCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EA59F0", Offset = "0x6EA4DF0", VA = "0x186EA59F0")]
	public static string JPLHANPIJFD(object FMAFBHGACNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5C90", Offset = "0x6EA5090", VA = "0x186EA5C90")]
	public static long OFCJMEBDOMA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5830", Offset = "0x6EA4C30", VA = "0x186EA5830")]
	public static bool HCKJAKDJBDG(bool LICAAPPODIG, string MOKGCFCFCPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EA58D0", Offset = "0x6EA4CD0", VA = "0x186EA58D0")]
	public static double JIEKIIADOAP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct PIINJNDNOHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GKLJAAGFCCM OEMMPLOLEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly GGEKMJMDANN BPICJOBFFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JIGPHNLFAJK KINLJBFBDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly BBABJHJLHIE JDKDHEEALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly LIDMDMMOKKB CFIJMFIHMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly PHJGIKJOBHO HCIJADGKKNF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JIGPHNLFAJK PPBHHBNOEPK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly BBABJHJLHIE GLJFNEODJAI;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly LIDMDMMOKKB FAEBBNDHKEG;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly PHJGIKJOBHO DOGBLELKDPB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly PIINJNDNOHK JFFGEEEAJID;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE280", Offset = "0x6EAD680", VA = "0x186EAE280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EAEC10", Offset = "0x6EAE010", VA = "0x186EAEC10")]
	public PIINJNDNOHK([In] GKLJAAGFCCM BMEAFGMLKNO, [In] GGEKMJMDANN HGHHMIIDFJE, JIGPHNLFAJK OPLAHDJLKMO, BBABJHJLHIE FJIHACNKPNH, LIDMDMMOKKB LNBPEFIJNGP, PHJGIKJOBHO COAPFJLJMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE410", Offset = "0x6EAD810", VA = "0x186EAE410")]
	private static string LBMNHLHFHHC(object FMAFBHGACNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	private static long PDHDEIDJIOP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	private static string AFBILJIAIPM(string CKEJEIFKOJA, string? MPHJCCJMKLK, bool DILEAJGCFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	private static bool KLDACHDEMDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE450", Offset = "0x6EAD850", VA = "0x186EAE450")]
	private static PIINJNDNOHK PGHLNKEKNEO()
	{
		return default(PIINJNDNOHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KGOPJLFKABI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMDFKEDAIGH HAJOPLDNPCH();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FMDFKEDAIGH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IFFFGLPLKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMLJHBGALAC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EPJDBDLJNML<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPEDODGCMKF([In] T KNLMODPGFOA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void CHDAJPALEBL<T>([In] T NDJFIKMCNAE);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct LJJMDOMAGEC<T> : IEquatable<LJJMDOMAGEC<T>>, EPJDBDLJNML<LJJMDOMAGEC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T EEMLDMGPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int KMIIBMECGKI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x224A240", Offset = "0x2249640", VA = "0x18224A240")]
	public LJJMDOMAGEC([In] T EEPLCHCGAIN, int HAJICDLBEKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45B9020", Offset = "0x45B8420", VA = "0x1845B9020")]
	public static bool LBFMGPFDJNL([In] LJJMDOMAGEC<T> OPJKGPJPNJJ, [In] LJJMDOMAGEC<T> EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B48D40", Offset = "0x3B48140", VA = "0x183B48D40", Slot = "4")]
	public bool Equals(LJJMDOMAGEC<T> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3FD07C0", Offset = "0x3FCFBC0", VA = "0x183FD07C0", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x45B9680", Offset = "0x45B8A80", VA = "0x1845B9680")]
	public bool LPEDODGCMKF([In] LJJMDOMAGEC<T> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x45B8570", Offset = "0x45B7970", VA = "0x1845B8570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x45BA140", Offset = "0x45B9540", VA = "0x1845BA140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x45B8AF0", Offset = "0x45B7EF0", VA = "0x1845B8AF0")]
	public void KGNAIFFBBCO([Out] T EEPLCHCGAIN, [Out] int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x45B9770", Offset = "0x45B8B70", VA = "0x1845B9770")]
	public (T, int) NBLDAPGCLHM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x45B9720", Offset = "0x45B8B20", VA = "0x1845B9720", Slot = "5")]
	private bool MCIBNPJKDKA([In] LJJMDOMAGEC<T> KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FAKJABNHMOP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A910", Offset = "0x2E29D10", VA = "0x182E2A910")]
	public static LJJMDOMAGEC<T> AHLALEPNKFA<T>([In] T EEPLCHCGAIN, int HAJICDLBEKC) where T : notnull
	{
		return default(LJJMDOMAGEC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JOJGDOOCIIP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9350", Offset = "0x2EB8750", VA = "0x182EB9350")]
	public static bool LPEDODGCMKF<T, U>([In] T MCPMOAEEEOJ, [In] U FMAFBHGACNM) where T : notnull, EPJDBDLJNML<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult JFPOPINHAOB<T, out TResult>([In] T NDJFIKMCNAE);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MOFGKKAILDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan HDLFENCGPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? PNEPAKBFFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMHCNCBOPAE();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHANAICPFCC();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNCJCAMKJIF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GKLJAAGFCCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly FKMCFCNJFBK HPJPMLNMKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly EFHFCLLCJFO FANECGAAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FKMCFCNJFBK PKHBLJMCGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly EFHFCLLCJFO IBJBJJHEJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FKMCFCNJFBK MDOIHHDLJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EFHFCLLCJFO MIAEMHKNGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly KLHDDKFKBAP IKFACCFECEJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly FKMCFCNJFBK KAJGONICINE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EFHFCLLCJFO MCLDEHNLJLM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FKMCFCNJFBK FAOMLINKCGJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly EFHFCLLCJFO IJHEGFECLHO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FKMCFCNJFBK NFNGNPNNKFC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EFHFCLLCJFO DDAKHDPILCH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KLHDDKFKBAP OKFIFFDOEHK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly GKLJAAGFCCM JFFGEEEAJID;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FKMCFCNJFBK JGHKLIOLAHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7BB0", Offset = "0x6EA6FB0", VA = "0x186EA7BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xE11960", Offset = "0xE10D60", VA = "0x180E11960")]
	public GKLJAAGFCCM(FKMCFCNJFBK JNCKAGGIJOE, EFHFCLLCJFO FEFJLBDNKKO, FKMCFCNJFBK IKPNKLMFMPK, EFHFCLLCJFO ALIEBHEHAEO, FKMCFCNJFBK OJAHCIJOAIK, EFHFCLLCJFO OPACNLPGOOJ, KLHDDKFKBAP DJDDEPPLGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	private static bool AGAIJJFIIOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void KAOCLAEGFOC(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	private static bool FLIEJFMHKCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void BCNANIKBACB(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	private static bool FIGMGDFPGFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void JNKPLNEEKKJ(string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void IBNAPJBJNBG(Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7FB0", Offset = "0x6EA73B0", VA = "0x186EA7FB0")]
	private static GKLJAAGFCCM PGHLNKEKNEO()
	{
		return default(GKLJAAGFCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
	private static bool HKLCFEMAOJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EA80F0", Offset = "0x6EA74F0", VA = "0x186EA80F0")]
	public void PKELKJJEMAA(object MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7E60", Offset = "0x6EA7260", VA = "0x186EA7E60")]
	public void MLPOCEDOOEN(object MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x20B5D80", Offset = "0x20B5180", VA = "0x1820B5D80")]
	public void NBABLAMEJFE(Exception DMFMNMKKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7ED0", Offset = "0x6EA72D0", VA = "0x186EA7ED0")]
	public void MLPOCEDOOEN(IHAOGICDGBN MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E60580", Offset = "0x2E5F980", VA = "0x182E60580")]
	public void MLPOCEDOOEN<T>(T NDJFIKMCNAE, CBNCNMOBIJL<T> MOKGCFCFCPE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E60650", Offset = "0x2E5FA50", VA = "0x182E60650")]
	public void PKELKJJEMAA<T>([In] T NDJFIKMCNAE, DKLCJBBJHIB<T> MOKGCFCFCPE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E60310", Offset = "0x2E5F710", VA = "0x182E60310")]
	public void MLPOCEDOOEN<T>([In] T NDJFIKMCNAE, DKLCJBBJHIB<T> MOKGCFCFCPE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7D90", Offset = "0x6EA7190", VA = "0x186EA7D90")]
	public bool HCKJAKDJBDG(bool LICAAPPODIG, string MOKGCFCFCPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct NKKDGOJHDPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string EEMLDMGPOLA;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public NKKDGOJHDPD(string EEPLCHCGAIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670")]
	public static string EGFECENGKHG([In] NKKDGOJHDPD MCPMOAEEEOJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC6D330", Offset = "0xC6C730", VA = "0x180C6D330")]
	public static NKKDGOJHDPD EGFECENGKHG(string KNLMODPGFOA)
	{
		return default(NKKDGOJHDPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAAD0", Offset = "0x6EA9ED0", VA = "0x186EAAAD0")]
	public string KAOFLHKBIGC(string CGPMIHKPHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA9F0", Offset = "0x6EA9DF0", VA = "0x186EAA9F0")]
	public string CJJGDJECOOK(object OKAAIGKOFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct IOADHBFKJOJ : IEquatable<IOADHBFKJOJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "4")]
	public bool Equals(IOADHBFKJOJ KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EA98B0", Offset = "0x6EA8CB0", VA = "0x186EA98B0", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9900", Offset = "0x6EA8D00", VA = "0x186EA9900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9910", Offset = "0x6EA8D10", VA = "0x186EA9910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[ALGEIKMJAHG("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct EAJEDGEMDCE<T> : IEquatable<EAJEDGEMDCE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T EEMLDMGPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool GLEPCKFMKAL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DFOHOKANKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3B48B90", Offset = "0x3B47F90", VA = "0x183B48B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AA70", Offset = "0x3B49E70", VA = "0x183B4AA70")]
	public EAJEDGEMDCE([In] T EEPLCHCGAIN, bool KNIELBDONLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B49F50", Offset = "0x3B49350", VA = "0x183B49F50")]
	public static bool LBFMGPFDJNL([In] EAJEDGEMDCE<T> OPJKGPJPNJJ, [In] EAJEDGEMDCE<T> EANFIEEELEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B48D40", Offset = "0x3B48140", VA = "0x183B48D40", Slot = "4")]
	public bool Equals(EAJEDGEMDCE<T> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B48DD0", Offset = "0x3B481D0", VA = "0x183B48DD0", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B499C0", Offset = "0x3B48DC0", VA = "0x183B499C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B4A7B0", Offset = "0x3B49BB0", VA = "0x183B4A7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BMEGEBCCDFN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5950", Offset = "0x2BF4D50", VA = "0x182BF5950")]
	public static EAJEDGEMDCE<T> MIOLNGKCBLB<T>([In] T EEPLCHCGAIN) where T : notnull
	{
		return default(EAJEDGEMDCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5730", Offset = "0x2BF4B30", VA = "0x182BF5730")]
	public static EAJEDGEMDCE<T?> EEOLOMKKOKN<T>()
	{
		return default(EAJEDGEMDCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5830", Offset = "0x2BF4C30", VA = "0x182BF5830")]
	public static bool HBBENILGLLH<T>([In] this EAJEDGEMDCE<T> BJGGKEOKHFI, [Out][NotNullWhen(true)] T EEPLCHCGAIN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5860", Offset = "0x2BF4C60", VA = "0x182BF5860")]
	public static T? LEDHPAHKMIE<T>([In] this EAJEDGEMDCE<T> BJGGKEOKHFI, T? BMLEAJPEFAD)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct GGEKMJMDANN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr FNKAHCLIPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr KLEOBNBGCIM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr BPCFJJIHDFJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr OFDANGILHKG;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly GGEKMJMDANN JFFGEEEAJID;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EA69F0", Offset = "0x6EA5DF0", VA = "0x186EA69F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public GGEKMJMDANN(IntPtr PIEICAGGMBG, IntPtr FMFCFKABKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void KMCOKJIHPAA(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void PPKBAGAKJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6AC0", Offset = "0x6EA5EC0", VA = "0x186EA6AC0")]
	private static GGEKMJMDANN PGHLNKEKNEO()
	{
		return default(GGEKMJMDANN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct DACEOCPEIOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr CJEBDMFADFM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	private DACEOCPEIOO(IntPtr FMFCFKABKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5190", Offset = "0x6EA4590", VA = "0x186EA5190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA5090", Offset = "0x6EA4490", VA = "0x186EA5090")]
	public static DACEOCPEIOO AHLALEPNKFA(string DDDHPCNFCEK)
	{
		return default(DACEOCPEIOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2223CC0", Offset = "0x22230C0", VA = "0x182223CC0")]
	public static DACEOCPEIOO AHLALEPNKFA([In] GGEKMJMDANN HGHHMIIDFJE, string DDDHPCNFCEK)
	{
		return default(DACEOCPEIOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2223D10", Offset = "0x2223110", VA = "0x182223D10")]
	public static DACEOCPEIOO AHLALEPNKFA([In] GGEKMJMDANN HGHHMIIDFJE, Func<string> DDDHPCNFCEK)
	{
		return default(DACEOCPEIOO);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class PBNKBOGLKMA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool DINNGIJNNOL<in TInput, TResult>(TInput EBJHHBADCKF, [Out] TResult IPNDOKDOGDG);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class DAHJPFKCKLJ : KGOPJLFKABI
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class PDNLBNINMAC : FMDFKEDAIGH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly PDNLBNINMAC GJPJBBHLIHD;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool IFFFGLPLKFD
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6EAD700", Offset = "0x6EACB00", VA = "0x186EAD700", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6EAD760", Offset = "0x6EACB60", VA = "0x186EAD760", Slot = "6")]
			public void OnCompleted(Action FLOCAEKKBHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
			public void EMLJHBGALAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public PDNLBNINMAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly DAHJPFKCKLJ GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		private DAHJPFKCKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA51B0", Offset = "0x6EA45B0", VA = "0x186EA51B0", Slot = "4")]
		public FMDFKEDAIGH HAJOPLDNPCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class LGBMADMOLMD : KGOPJLFKABI
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class LPLFCLGAOFB : FMDFKEDAIGH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly LPLFCLGAOFB GJPJBBHLIHD;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool IFFFGLPLKFD
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6EAA2E0", Offset = "0x6EA96E0", VA = "0x186EAA2E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EAA300", Offset = "0x6EA9700", VA = "0x186EAA300", Slot = "6")]
			public void OnCompleted(Action FLOCAEKKBHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
			public void EMLJHBGALAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public LPLFCLGAOFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly LGBMADMOLMD GJPJBBHLIHD;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		private LGBMADMOLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA0D0", Offset = "0x6EA94D0", VA = "0x186EAA0D0", Slot = "4")]
		public FMDFKEDAIGH HAJOPLDNPCH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FLEJEKFGOHN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FLEJEKFGOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F526A0", Offset = "0x3F51AA0", VA = "0x183F526A0")]
		internal void NAMDBLMOOAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KOKFDIECJJN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KOKFDIECJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x45109C0", Offset = "0x450FDC0", VA = "0x1845109C0")]
		internal void GBMLFFCAMKL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DBMONOONOAA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EA52E0", Offset = "0x6EA46E0", VA = "0x186EA52E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IPKBAIKBLCB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9940", Offset = "0x6EA8D40", VA = "0x186EA9940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x918150", Offset = "0x917550", VA = "0x180918150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EHLHGFNNDAK<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C5F0", Offset = "0x3B6B9F0", VA = "0x183B6C5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C760", Offset = "0x3B6BB60", VA = "0x183B6C760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BGJMPGAJPBB<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5239A40", Offset = "0x5238E40", VA = "0x185239A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x523A2D0", Offset = "0x52396D0", VA = "0x18523A2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MCAEMILODKJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA3C0", Offset = "0x6EA97C0", VA = "0x186EAA3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA5C0", Offset = "0x6EA99C0", VA = "0x186EAA5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MAAKJDHMNCC<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MAAKJDHMNCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F526A0", Offset = "0x3F51AA0", VA = "0x183F526A0")]
		internal void JIJAIDOJOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x47B2C40", Offset = "0x47B2040", VA = "0x1847B2C40")]
		internal void CIIEEFHPACB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct LDAAGMMHCGB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public DINNGIJNNOL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4591360", Offset = "0x4590760", VA = "0x184591360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4591AC0", Offset = "0x4590EC0", VA = "0x184591AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct PFOCIAHHAEH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD920", Offset = "0x6EACD20", VA = "0x186EAD920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE110", Offset = "0x6EAD510", VA = "0x186EAE110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AFLOGJMDFAM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EA33C0", Offset = "0x6EA27C0", VA = "0x186EA33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3900", Offset = "0x6EA2D00", VA = "0x186EA3900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MIGHMAAJIOI<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x47E4900", Offset = "0x47E3D00", VA = "0x1847E4900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4254A70", Offset = "0x4253E70", VA = "0x184254A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PIEFAOODCIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<IOADHBFKJOJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public PIEFAOODCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EAE170", Offset = "0x6EAD570", VA = "0x186EAE170")]
		internal void BBFAMFLIHBP(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MBDMGOCAIHM<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x47B5470", Offset = "0x47B4870", VA = "0x1847B5470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38768C0", Offset = "0x3875CC0", VA = "0x1838768C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EFALLJBAAFJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C480", Offset = "0x3B5B880", VA = "0x183B5C480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CBD0", Offset = "0x3B5BFD0", VA = "0x183B5CBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BLJBGIDIGEI : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4E50", Offset = "0x6EA4250", VA = "0x186EA4E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5030", Offset = "0x6EA4430", VA = "0x186EA5030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct JPKNBKDGHOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9A50", Offset = "0x6EA8E50", VA = "0x186EA9A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9DB0", Offset = "0x6EA91B0", VA = "0x186EA9DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct OEDMLCBPOEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAC80", Offset = "0x6EAA080", VA = "0x186EAAC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAF70", Offset = "0x6EAA370", VA = "0x186EAAF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DAPONHNPBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DAPONHNPBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5270", Offset = "0x6EA4670", VA = "0x186EA5270")]
		internal Task DFBFACCEDEK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct KGKHAPPICOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9E10", Offset = "0x6EA9210", VA = "0x186EA9E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA070", Offset = "0x6EA9470", VA = "0x186EAA070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ILEMIGCMNKB : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9670", Offset = "0x6EA8A70", VA = "0x186EA9670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9850", Offset = "0x6EA8C50", VA = "0x186EA9850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NHBBJNGCOPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA630", Offset = "0x6EA9A30", VA = "0x186EAA630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA990", Offset = "0x6EA9D90", VA = "0x186EAA990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HEOMDJHIPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8CD0", Offset = "0x6EA80D0", VA = "0x186EA8CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8FC0", Offset = "0x6EA83C0", VA = "0x186EA8FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FJEHCOBJHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FJEHCOBJHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6EA66C0", Offset = "0x6EA5AC0", VA = "0x186EA66C0")]
		internal Task DBDPNMAKHDK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct FPPCJLMCEFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6730", Offset = "0x6EA5B30", VA = "0x186EA6730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EA6990", Offset = "0x6EA5D90", VA = "0x186EA6990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct PAENEMOAIGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB2F0", Offset = "0x6EAA6F0", VA = "0x186EAB2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB470", Offset = "0x6EAA870", VA = "0x186EAB470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HNEOLHGOLDH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4175570", Offset = "0x4174970", VA = "0x184175570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x41757F0", Offset = "0x4174BF0", VA = "0x1841757F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BGDEIEPLDBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4160", Offset = "0x6EA3560", VA = "0x186EA4160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4490", Offset = "0x6EA3890", VA = "0x186EA4490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? GELFCBDIGHM;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<IOADHBFKJOJ> CFDHOLJOOHO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task LKHCDJLGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EACFB0", Offset = "0x6EAC3B0", VA = "0x186EACFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB4D0", Offset = "0x6EAA8D0", VA = "0x186EAB4D0")]
	public static bool AEKPDCHLJNF(this Task IALOMLEGCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3037830", Offset = "0x3036C30", VA = "0x183037830")]
	public static Task<T> AONLMNIHBFC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6EACBD0", Offset = "0x6EABFD0", VA = "0x186EACBD0")]
	public static Task LMNINHBBDHE(this Task IALOMLEGCDH, CancellationToken ABHFNNFMPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3038210", Offset = "0x3037610", VA = "0x183038210")]
	public static Task<TResult> LMNINHBBDHE<TResult>(this Task<TResult> IALOMLEGCDH, CancellationToken ABHFNNFMPHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3038830", Offset = "0x3037C30", VA = "0x183038830")]
	public static TaskCompletionSource<TResult> LMNINHBBDHE<TResult>(this TaskCompletionSource<TResult> HLBKIOANHNK, CancellationToken ABHFNNFMPHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EACE20", Offset = "0x6EAC220", VA = "0x186EACE20")]
	public static IDisposable? MJIIKGNMLMF(CancellationToken DCNGHEKJIKN, CancellationToken FKNNNOMIEJE, [Out] CancellationToken CANOMAGCHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB810", Offset = "0x6EAAC10", VA = "0x186EAB810")]
	[AsyncStateMachine(typeof(DBMONOONOAA))]
	public static void DGAFPHBPFKO(this Task KBFPLGGGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB760", Offset = "0x6EAAB60", VA = "0x186EAB760")]
	[AsyncStateMachine(typeof(IPKBAIKBLCB))]
	public static void COCCHDCNKEK(this Task KBFPLGGGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3038140", Offset = "0x3037540", VA = "0x183038140")]
	[AsyncStateMachine(typeof(EHLHGFNNDAK<>))]
	public static Task KLJAJGFMICB<TException>(this Task KBFPLGGGODF) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3037D80", Offset = "0x3037180", VA = "0x183037D80")]
	[AsyncStateMachine(typeof(BGJMPGAJPBB<>))]
	public static Task<T> EMBPKKCGBNH<T>(this Task<T> MCPMOAEEEOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD550", Offset = "0x6EAC950", VA = "0x186EAD550")]
	[AsyncStateMachine(typeof(MCAEMILODKJ))]
	public static Task<TaskStatus> OLEHICMLGOL(this Task MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x303C870", Offset = "0x303BC70", VA = "0x18303C870")]
	public static (Task<T?>?, Action<T?>?) MEDDGPIGKDA<T>([Optional] CancellationToken NBBCMDKGJKI)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30379B0", Offset = "0x3036DB0", VA = "0x1830379B0")]
	[AsyncStateMachine(typeof(LDAAGMMHCGB<, >))]
	public static Task<List<TResult>> DAJCLCJCHOH<TResult, TInput>(this Task<List<TInput>> IALOMLEGCDH, DINNGIJNNOL<TInput, TResult> OEAMDPJEJDF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB580", Offset = "0x6EAA980", VA = "0x186EAB580")]
	[AsyncStateMachine(typeof(PFOCIAHHAEH))]
	public static Task CJJMHBOPAPK(Task KBFPLGGGODF, CancellationToken DAMMAGNLMMI, Func<CancellationToken, Task> ODBCHPAMLJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD220", Offset = "0x6EAC620", VA = "0x186EAD220")]
	[AsyncStateMachine(typeof(AFLOGJMDFAM))]
	public static Task OHECKHDNKAP(Func<CancellationToken, Task> JJDNJMKEDJK, TimeSpan AGLEHEANGMN, [Optional] CancellationToken DAMMAGNLMMI, [Optional] Action<OperationCanceledException>? GGLPJJJPHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x303CBE0", Offset = "0x303BFE0", VA = "0x18303CBE0")]
	[AsyncStateMachine(typeof(MIGHMAAJIOI<>))]
	public static Task<T> OHECKHDNKAP<T>(Func<CancellationToken, Task<T>> JJDNJMKEDJK, TimeSpan AGLEHEANGMN, [Optional] CancellationToken DAMMAGNLMMI, [Optional] Func<OperationCanceledException, T>? GGLPJJJPHJM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EABF20", Offset = "0x6EAB320", VA = "0x186EABF20")]
	public static Task HHADGHBDCIN(params Task[] PMJGAHKBCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EABF70", Offset = "0x6EAB370", VA = "0x186EABF70")]
	public static Task HHADGHBDCIN(IEnumerable<Task> PMJGAHKBCOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3038050", Offset = "0x3037450", VA = "0x183038050")]
	[AsyncStateMachine(typeof(MBDMGOCAIHM<>))]
	public static Task<IEnumerable<Task<T>>> HPBCKKGHLGB<T>(IEnumerable<Task<T>> PMJGAHKBCOB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3037AC0", Offset = "0x3036EC0", VA = "0x183037AC0")]
	[AsyncStateMachine(typeof(EFALLJBAAFJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> EFNBDELHKLC<T1, T2, T3, T4>(Task<T1> IBMILLDMJAJ, Task<T2> FOMPKKHJOKA, Task<T3> PINIJKIIIEA, Task<T4> PCGGPJPDHPD) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EABD20", Offset = "0x6EAB120", VA = "0x186EABD20")]
	[AsyncStateMachine(typeof(BLJBGIDIGEI))]
	public static Task GKKNPCNFLJC(Func<bool> LICAAPPODIG, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EABE10", Offset = "0x6EAB210", VA = "0x186EABE10")]
	[AsyncStateMachine(typeof(JPKNBKDGHOP))]
	public static Task GKKNPCNFLJC(Func<bool> LICAAPPODIG, TimeSpan MJNEGEAPNJC, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB9E0", Offset = "0x6EAADE0", VA = "0x186EAB9E0")]
	[AsyncStateMachine(typeof(OEDMLCBPOEB))]
	public static Task EJBHNNJEGPA(Func<bool> LICAAPPODIG, TimeSpan AGLEHEANGMN, [Optional] CancellationToken NBBCMDKGJKI, [Optional] Action<OperationCanceledException>? GGLPJJJPHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EABB10", Offset = "0x6EAAF10", VA = "0x186EABB10")]
	[AsyncStateMachine(typeof(KGKHAPPICOF))]
	public static Task EJBHNNJEGPA(Func<bool> LICAAPPODIG, TimeSpan AGLEHEANGMN, TimeSpan MJNEGEAPNJC, [Optional] CancellationToken NBBCMDKGJKI, [Optional] Action<OperationCanceledException>? GGLPJJJPHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD460", Offset = "0x6EAC860", VA = "0x186EAD460")]
	[AsyncStateMachine(typeof(ILEMIGCMNKB))]
	public static Task OHGPBCFGDPC(Func<bool> LICAAPPODIG, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD350", Offset = "0x6EAC750", VA = "0x186EAD350")]
	[AsyncStateMachine(typeof(NHBBJNGCOPA))]
	public static Task OHGPBCFGDPC(Func<bool> LICAAPPODIG, TimeSpan MJNEGEAPNJC, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC960", Offset = "0x6EABD60", VA = "0x186EAC960")]
	[AsyncStateMachine(typeof(HEOMDJHIPMP))]
	public static Task LKDDONGLPPF(Func<bool> LICAAPPODIG, TimeSpan AGLEHEANGMN, [Optional] CancellationToken NBBCMDKGJKI, [Optional] Action<OperationCanceledException>? GGLPJJJPHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EACA90", Offset = "0x6EABE90", VA = "0x186EACA90")]
	[AsyncStateMachine(typeof(FPPCJLMCEFK))]
	public static Task LKDDONGLPPF(Func<bool> LICAAPPODIG, TimeSpan AGLEHEANGMN, TimeSpan MJNEGEAPNJC, [Optional] CancellationToken NBBCMDKGJKI, [Optional] Action<OperationCanceledException>? GGLPJJJPHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD020", Offset = "0x6EAC420", VA = "0x186EAD020")]
	[AsyncStateMachine(typeof(PAENEMOAIGK))]
	[Obsolete]
	public static Task NHDIFCLIMGK(this Task IALOMLEGCDH, Action JPFCIEIPDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x303CAF0", Offset = "0x303BEF0", VA = "0x18303CAF0")]
	[Obsolete]
	[AsyncStateMachine(typeof(HNEOLHGOLDH<>))]
	public static Task NHDIFCLIMGK<T>(this Task<T> IALOMLEGCDH, Action<T> JPFCIEIPDFI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB6B0", Offset = "0x6EAAAB0", VA = "0x186EAB6B0")]
	private static void CLGNJCBCCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC480", Offset = "0x6EAB880", VA = "0x186EAC480")]
	public static bool JJANINGOHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC7E0", Offset = "0x6EABBE0", VA = "0x186EAC7E0")]
	private static void KFPFDBEKDMG(SynchronizationContext EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD110", Offset = "0x6EAC510", VA = "0x186EAD110")]
	private static void OEJPABMEOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB8C0", Offset = "0x6EAACC0", VA = "0x186EAB8C0")]
	public static void DIEIBKKEAOM([Optional] string? MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB500", Offset = "0x6EAA900", VA = "0x186EAB500")]
	public static void BDNNPHDLGKG([Optional] string? MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EAC430", Offset = "0x6EAB830", VA = "0x186EAC430")]
	public static KGOPJLFKABI IFDODNMNAMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB990", Offset = "0x6EAAD90", VA = "0x186EAB990")]
	public static KGOPJLFKABI EDLIABNEFHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EABC50", Offset = "0x6EAB050", VA = "0x186EABC50")]
	[AsyncStateMachine(typeof(BGDEIEPLDBD))]
	public static Task GHMDBLBJBAO(Func<Task> KNNCNNMDAMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JEGDMIPNMMJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
	public JEGDMIPNMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DCPIJGLICPI : OIIGLLLMHIB
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly OIIGLLLMHIB GJPJBBHLIHD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime DGNJJCNNLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5440", Offset = "0x6EA4840", VA = "0x186EA5440", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset GPDFGNFBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5480", Offset = "0x6EA4880", VA = "0x186EA5480", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public DCPIJGLICPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface OIIGLLLMHIB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime DGNJJCNNLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset GPDFGNFBGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class AJABDFGJGMN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long FLCMCBDLNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3BB0", Offset = "0x6EA2FB0", VA = "0x186EA3BB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long MEMABKCCKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3A80", Offset = "0x6EA2E80", VA = "0x186EA3A80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double LHGDGFJEKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3A30", Offset = "0x6EA2E30", VA = "0x186EA3A30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double DDCKEBLEINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3B60", Offset = "0x6EA2F60", VA = "0x186EA3B60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double GMNEAGDIHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3C90", Offset = "0x6EA3090", VA = "0x186EA3C90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double EMJBCLHCDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3E60", Offset = "0x6EA3260", VA = "0x186EA3E60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3D40", Offset = "0x6EA3140", VA = "0x186EA3D40")]
	public static double NFBCPELGHFL(long CMNEPIPODBM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3C00", Offset = "0x6EA3000", VA = "0x186EA3C00")]
	public static double MDPOALDLBOH(long CMNEPIPODBM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3DD0", Offset = "0x6EA31D0", VA = "0x186EA3DD0")]
	public static double OAPOKFEAAEC(double GAGMBPEFDNF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3AD0", Offset = "0x6EA2ED0", VA = "0x186EA3AD0")]
	public static long GHCAJMGLHKP(long FBMABEBEKJJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3EB0", Offset = "0x6EA32B0", VA = "0x186EA3EB0")]
	public static long PCNOJMGMJMO(long KBEOFEJAGDI, long AFINABKEABL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3960", Offset = "0x6EA2D60", VA = "0x186EA3960")]
	public static double AKHBCCLAOIJ(long KBEOFEJAGDI, long AFINABKEABL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6EA3CE0", Offset = "0x6EA30E0", VA = "0x186EA3CE0")]
	public static double MKNHGJAHHOM(long KBEOFEJAGDI, long AFINABKEABL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class EPGHLLFKKHM : MOFGKKAILDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan DMPLKPCFKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer BKBOMPKPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan AGLEHEANGMN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan HDLFENCGPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6EA5FB0", Offset = "0x6EA53B0", VA = "0x186EA5FB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? PNEPAKBFFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6630", Offset = "0x6EA5A30", VA = "0x186EA6630")]
	[Preserve]
	public EPGHLLFKKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EA63E0", Offset = "0x6EA57E0", VA = "0x186EA63E0")]
	public EPGHLLFKKHM(TimeSpan AGLEHEANGMN, [Optional] Action? GFPLEDLOLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EA61E0", Offset = "0x6EA55E0", VA = "0x186EA61E0", Slot = "7")]
	public void FMHCNCBOPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6270", Offset = "0x6EA5670", VA = "0x186EA6270", Slot = "8")]
	public void IHANAICPFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6110", Offset = "0x6EA5510", VA = "0x186EA6110", Slot = "9")]
	public void DNCJCAMKJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xC00F00", Offset = "0xC00300", VA = "0x180C00F00")]
	private void AEOMMENMIFO(object EFCBJHHANBC, ElapsedEventArgs ALMMJCIGOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA62E0", Offset = "0x6EA56E0", VA = "0x186EA62E0")]
	private static void OIOJEAGLANK(TimeSpan IKOFNMGNOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6140", Offset = "0x6EA5540", VA = "0x186EA6140", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ALGEIKMJAHG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? HCCHPKLKBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string DDLACOBGPKL;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9E8580", Offset = "0x9E7980", VA = "0x1809E8580")]
	public ALGEIKMJAHG(string BCAMDINMAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3FD71F0", Offset = "0x3FD65F0", VA = "0x183FD71F0")]
	public ALGEIKMJAHG(string ICMMNOKPMGG, string BCAMDINMAHA)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GKIFKJFALJB : IEquatable<GKIFKJFALJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint EIBEMBKBNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int JLCOFGLOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float EJBHGFMCJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort ALFEHJPFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort BCBKCABLOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short LMFLPDLKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short DCPLGJILBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char CPKIFDPEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char FBOPBFIJCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte EDMBKLFECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte POAHCAIAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte JMIBPOHFEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte FPEDALKMHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool GCFNHICOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool KJJNNGJAOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool PIPKFOMPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool DJJAANKDNIN;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
	public static GKIFKJFALJB KPDJKLPAKOM(uint CKKEEGIIGKK)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
	public static GKIFKJFALJB DPFFLPDDAOG(int MLEOCLIPKMG)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6C90", Offset = "0x6EA6090", VA = "0x186EA6C90")]
	public static GKIFKJFALJB DIIKCPIBANL(float IDMOMPKHGFK)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D30", Offset = "0x6EA6130", VA = "0x186EA6D30")]
	public static GKIFKJFALJB LPDNEPKBHMM(byte JICJMNIHLLA, byte JJHEMNEEJLK, byte ICAJLFCODEE, byte ONPMHJHANGD)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D30", Offset = "0x6EA6130", VA = "0x186EA6D30")]
	public static GKIFKJFALJB IMDKNLODDOH(bool EGDBCJEBILP, bool JFKLGLDJIMD, bool IJKCBFPDGFD, bool EOENJGMGAKI)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D30", Offset = "0x6EA6130", VA = "0x186EA6D30")]
	public static GKIFKJFALJB IDHMPAFEGGM(byte MFGCAOCEEKL, byte JHBMIHCBCAG, byte FBNLIMEAEIE, byte OJHDKCGIKKJ)
	{
		return default(GKIFKJFALJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1F22AD0", Offset = "0x1F21ED0", VA = "0x181F22AD0")]
	public static bool LBFMGPFDJNL(GKIFKJFALJB JKMLNPBBJIG, GKIFKJFALJB JDJGFJGMEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xCD3550", Offset = "0xCD2950", VA = "0x180CD3550", Slot = "4")]
	public bool Equals(GKIFKJFALJB KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6CA0", Offset = "0x6EA60A0", VA = "0x186EA6CA0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xD77DD0", Offset = "0xD771D0", VA = "0x180D77DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D50", Offset = "0x6EA6150", VA = "0x186EA6D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LPIDBPCPFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong GAFKFHDOMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long JDDBCCNHFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double BHIEJKHDNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint FMJGEICFDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint LKGNONOPFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int LHGGEBLLPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int HLHKGBOKLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float MEMAJFLHINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float KNEPDIEDAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort ALFEHJPFFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort BCBKCABLOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort EBADFPPENJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort OCHICPBODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short LMFLPDLKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short DCPLGJILBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short COMKIPLPAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short CDFNJIPJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char CPKIFDPEOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char FBOPBFIJCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char AMANPHNKNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char OJFBOAHPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte EDMBKLFECMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte POAHCAIAEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte JMIBPOHFEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte FPEDALKMHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte GEGBJDDENIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte DPFOLCKNHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte MEEJKOIOOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte EAKAPGEMKAG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static LPIDBPCPFKN AHLALEPNKFA(long DKIGHGBJPJA)
	{
		return default(LPIDBPCPFKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA290", Offset = "0x6EA9690", VA = "0x186EAA290")]
	public static LPIDBPCPFKN AHLALEPNKFA(byte JICJMNIHLLA, byte JJHEMNEEJLK, byte ICAJLFCODEE, byte ONPMHJHANGD, byte ADMLDBNPOPG, byte PEPKEMHLFKA, byte DCHALKBOAKB, byte LFIGMHNFCIK)
	{
		return default(LPIDBPCPFKN);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct ONBJBPGCEMD : IEquatable<ONBJBPGCEMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte LHMDEDEPLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool JAKPEBGMNGI;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2803DC0", Offset = "0x28031C0", VA = "0x182803DC0")]
	public static ONBJBPGCEMD LPDNEPKBHMM(byte PPCKMLLFFLF)
	{
		return default(ONBJBPGCEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2803DC0", Offset = "0x28031C0", VA = "0x182803DC0")]
	public static ONBJBPGCEMD IMDKNLODDOH(bool GOIEKBAOEIL)
	{
		return default(ONBJBPGCEMD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB070", Offset = "0x6EAA470", VA = "0x186EAB070")]
	public static bool LBFMGPFDJNL(ONBJBPGCEMD JKMLNPBBJIG, ONBJBPGCEMD JDJGFJGMEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60166E0", Offset = "0x6015AE0", VA = "0x1860166E0", Slot = "4")]
	public bool Equals(ONBJBPGCEMD KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAFD0", Offset = "0x6EAA3D0", VA = "0x186EAAFD0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB060", Offset = "0x6EAA460", VA = "0x186EAB060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB080", Offset = "0x6EAA480", VA = "0x186EAB080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class KJGJABPOKCL<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T IEIEEDLOJDI;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x45094E0", Offset = "0x45088E0", VA = "0x1845094E0")]
	public KJGJABPOKCL(T JDHJDKJKNKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EHMHAACONLK
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2CCA730", Offset = "0x2CC9B30", VA = "0x182CCA730")]
	public static IEnumerable<T> NGHAIHFBGPH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static T[] MHAAJIEGGFC<T>(params T[] KGCKAGLFNFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static IEnumerable<T> GEINOJINIMF<T>(params T[] KGCKAGLFNFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static HashSet<T> MHMFACPBHLC<T>(params T[] KGCKAGLFNFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCA640", Offset = "0x2CC9A40", VA = "0x182CCA640")]
	public static KeyValuePair<TKey, TValue> BOOCGLGPKKE<TKey, TValue>([In] TKey OEOMDKHBDFI, [In] TValue EEPLCHCGAIN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static List<T> CLPGPEFCIMA<T>(IEnumerable<T> JHBKFOICCJL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class DOEMOBPLMFE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string EGJNECHDHEJ;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
	public DOEMOBPLMFE(string KNKLOPPILKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object DKLCJBBJHIB<T>([In] T CJLBFJEOAOD);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object CBNCNMOBIJL<T>(T CJLBFJEOAOD);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AEIHBJEKLCG]
public delegate string LIDMDMMOKKB(string CKEJEIFKOJA, string? MPHJCCJMKLK, bool DILEAJGCFHN);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[AEIHBJEKLCG]
public delegate void EFHFCLLCJFO(string MOKGCFCFCPE);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AEIHBJEKLCG]
public delegate void KLHDDKFKBAP(Exception DMFMNMKKLLI);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object IHAOGICDGBN();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AEIHBJEKLCG]
public delegate bool FKMCFCNJFBK();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AEIHBJEKLCG]
public delegate string JIGPHNLFAJK(object FMAFBHGACNM);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class KOMLJCGMPBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
	public KOMLJCGMPBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class HFBMBONMMNG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BHHMIBOBENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6EA44F0", Offset = "0x6EA38F0", VA = "0x186EA44F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6EA4DE0", Offset = "0x6EA41E0", VA = "0x186EA4DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback DENDIJJCNDA;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> MAJCGILLGPJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA91E0", Offset = "0x6EA85E0", VA = "0x186EA91E0")]
	public static Task<bool> LGAMEABCNOC(int NEHKFFOFGBK, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA90B0", Offset = "0x6EA84B0", VA = "0x186EA90B0")]
	[AsyncStateMachine(typeof(BHHMIBOBENJ))]
	private static Task<bool> JMAFONCFCEG(int NEHKFFOFGBK, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6EA94E0", Offset = "0x6EA88E0", VA = "0x186EA94E0")]
	private static void LIPIHNPAOEK(object? NMAIGNOENJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9020", Offset = "0x6EA8420", VA = "0x186EA9020")]
	private static void BINLOONLCJN(object? NMAIGNOENJN)
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
