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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6921D20", Offset = "0x6920520", VA = "0x186921D20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class CJDNKEAJAAK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x691A620", Offset = "0x6918E20", VA = "0x18691A620")]
	public CJDNKEAJAAK(bool FHLNOBGFOBP, string GMNIAJIHHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FPOJOADEJPE
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ICHBPLLNLOL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> BNGEAHDKBAM(CancellationToken ODNHMAMKFFP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FMCNCJIMEEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ICHBPLLNLOL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BNGEAHDKBAM taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3B03C80", Offset = "0x3B02480", VA = "0x183B03C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B04DC0", Offset = "0x3B035C0", VA = "0x183B04DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource NPNHNCBGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? GPKOMKGCDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? INEDCMCJFBA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D64810", Offset = "0x3D63010", VA = "0x183D64810")]
	[AsyncStateMachine(typeof(ICHBPLLNLOL<>.FMCNCJIMEEK))]
	public Task<TResult> CHILBMDBECN(BNGEAHDKBAM NDPAMBHJAGN, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D64960", Offset = "0x3D63160", VA = "0x183D64960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D649D0", Offset = "0x3D631D0", VA = "0x183D649D0")]
	public ICHBPLLNLOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class ODMKEKHPNNF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> ADGJEKAPNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T JDDKPJKLOJP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB9F0", Offset = "0x3BBA1F0", VA = "0x183BBB9F0")]
	public ODMKEKHPNNF([In] T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4546580", Offset = "0x4544D80", VA = "0x184546580", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4546C40", Offset = "0x4545440", VA = "0x184546C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4546F70", Offset = "0x4545770", VA = "0x184546F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CEPCKKHBKOD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static ODMKEKHPNNF<T> OJFFIHPLODM<T>([In] T IPHHABIKCHD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BKFJFDCMDIE
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x691A330", Offset = "0x6918B30", VA = "0x18691A330")]
	public static void HAIKKHCOOCM(this CancellationTokenSource NPNHNCBGLOD, bool OFCBINGNLFN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LGFIGFGINKK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
	public LGFIGFGINKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OHBLJHFIMOK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
	public OHBLJHFIMOK(string JJHBIHDGFIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FPEMOLIFLAE
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A803B0", Offset = "0x2A7EBB0", VA = "0x182A803B0")]
	public static PFIMPLEPCIJ EKJKCMCHIIO<T>()
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A80600", Offset = "0x2A7EE00", VA = "0x182A80600")]
	public static PFIMPLEPCIJ NOOEKJMFLDB<T>([CallerMemberName] string GCDLMFGKKMH = "") where T : notnull
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A80430", Offset = "0x2A7EC30", VA = "0x182A80430")]
	public static PFIMPLEPCIJ EKJKCMCHIIO<T>(this T NOFEINPOGPG) where T : notnull
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A80750", Offset = "0x2A7EF50", VA = "0x182A80750")]
	public static PFIMPLEPCIJ ODBEDCHNFHN<T>(this T NOFEINPOGPG, [CallerMemberName] string GCDLMFGKKMH = "") where T : notnull
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A806A0", Offset = "0x2A7EEA0", VA = "0x182A806A0")]
	public static PFIMPLEPCIJ NOOEKJMFLDB<T>(this T EGJINJKGIAK, [CallerMemberName] string GCDLMFGKKMH = "") where T : notnull
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x691C470", Offset = "0x691AC70", VA = "0x18691C470")]
	public static PFIMPLEPCIJ NOOEKJMFLDB(string OFBPANPBKLB, [CallerMemberName] string GCDLMFGKKMH = "")
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x691C4F0", Offset = "0x691ACF0", VA = "0x18691C4F0")]
	public static string PBLMPBKFLMG(this object EGJINJKGIAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool JKLDEDPABKI();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[LGFIGFGINKK]
public delegate long DGNPGLJPGPP();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LNKOEANOKFF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IPMPIMMKMPN EJODCDKDIOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IPMPIMMKMPN DBAJBHAGCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x691F130", Offset = "0x691D930", VA = "0x18691F130")]
		get
		{
			return default(IPMPIMMKMPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MDAGCJDHKLK CLCPDEBFDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x691EBF0", Offset = "0x691D3F0", VA = "0x18691EBF0")]
		get
		{
			return default(MDAGCJDHKLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AHJKEBGFGJB CCBGKHBCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x691EFF0", Offset = "0x691D7F0", VA = "0x18691EFF0")]
		get
		{
			return default(AHJKEBGFGJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool KJBFGALLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x691F180", Offset = "0x691D980", VA = "0x18691F180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x691EC40", Offset = "0x691D440", VA = "0x18691EC40")]
	public static void CECBPEOGHKC([In] IPMPIMMKMPN OCIDNEMBBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x691EEB0", Offset = "0x691D6B0", VA = "0x18691EEB0")]
	public static void CPICANFMBIK(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x691EDE0", Offset = "0x691D5E0", VA = "0x18691EDE0")]
	public static void CODFCBACCFD(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B596A0", Offset = "0x2B57EA0", VA = "0x182B596A0")]
	public static void CODFCBACCFD<T>(T NIFGNHBNLFL, EMLLKBHMLEL<T> CLBGCJICGJG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x691EB50", Offset = "0x691D350", VA = "0x18691EB50")]
	public static void BDLOOEDHKPI(Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x691F0B0", Offset = "0x691D8B0", VA = "0x18691F0B0")]
	public static void JAPDMOMEEDC(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x691F040", Offset = "0x691D840", VA = "0x18691F040")]
	public static void HJGBEAEBKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x691F1F0", Offset = "0x691D9F0", VA = "0x18691F1F0")]
	public static string PBLMPBKFLMG(object GHDJADLHPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x691EF80", Offset = "0x691D780", VA = "0x18691EF80")]
	public static long DOMBBHNHBLC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x691EAB0", Offset = "0x691D2B0", VA = "0x18691EAB0")]
	public static bool AABCPFCCIDH(bool BKKMFFLBGND, string CLBGCJICGJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x691F260", Offset = "0x691DA60", VA = "0x18691F260")]
	public static double PFPLHHAGPCA()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct IPMPIMMKMPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly MDAGCJDHKLK CLCPDEBFDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly AHJKEBGFGJB CCBGKHBCLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly PENGBBJCLFE PAJFIGFGIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DGNPGLJPGPP ELHCPKEGCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly MCFCMJKNMOI HGBAFNGHKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly JKLDEDPABKI NMNJFILBBCA;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly PENGBBJCLFE NDILENGJLDB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DGNPGLJPGPP COEMELHAJEE;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly MCFCMJKNMOI CALKNGPDKCE;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly JKLDEDPABKI HDGPLEACFFL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly IPMPIMMKMPN IJLPDDOKCDN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HACFJPDLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x691DD60", Offset = "0x691C560", VA = "0x18691DD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x691E5F0", Offset = "0x691CDF0", VA = "0x18691E5F0")]
	public IPMPIMMKMPN([In] MDAGCJDHKLK LJHEICHKBFL, [In] AHJKEBGFGJB LIOHCDIBINH, PENGBBJCLFE LLHALELDGOJ, DGNPGLJPGPP DDLHPHJLGJL, MCFCMJKNMOI DOMBJDMPHLN, JKLDEDPABKI EBJDFJEGCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x691DEF0", Offset = "0x691C6F0", VA = "0x18691DEF0")]
	private static string PBLGPNDJGLC(object GHDJADLHPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540")]
	private static long KONPAHBEKCI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	private static string JCHBGLJPICJ(string KKDAHIDPNBA, string? JEOLOLCNKCP, bool FCLMPEMJNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	private static bool PGGCKHPANAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x691DC60", Offset = "0x691C460", VA = "0x18691DC60")]
	private static IPMPIMMKMPN EGBMCJLMIPA()
	{
		return default(IPMPIMMKMPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MPAMOIOIENE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJNAMCHMPDJ GBAOEGHLCNE();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MJNAMCHMPDJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EENFPKNMENE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BCJMMDGDKOB();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LDBDBADILKG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FBAIKNDMJDK([In] T OGFCKBADKBE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void INAJIKOANFM<T>([In] T NIFGNHBNLFL);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct BDEOGCGJGCI<T> : IEquatable<BDEOGCGJGCI<T>>, LDBDBADILKG<BDEOGCGJGCI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T JDDKPJKLOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int CFDBFCCMKIM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1F4E920", Offset = "0x1F4D120", VA = "0x181F4E920")]
	public BDEOGCGJGCI([In] T IPHHABIKCHD, int JBDLDJOINOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D201C0", Offset = "0x4D1E9C0", VA = "0x184D201C0")]
	public static bool JAJJILMADFD([In] BDEOGCGJGCI<T> LDKECOBJCHJ, [In] BDEOGCGJGCI<T> JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4DA0", Offset = "0x3FB35A0", VA = "0x183FB4DA0", Slot = "4")]
	public bool Equals(BDEOGCGJGCI<T> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x413DD20", Offset = "0x413C520", VA = "0x18413DD20", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FBC0", Offset = "0x4D1E3C0", VA = "0x184D1FBC0")]
	public bool FBAIKNDMJDK([In] BDEOGCGJGCI<T> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FD90", Offset = "0x4D1E590", VA = "0x184D1FD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D215A0", Offset = "0x4D1FDA0", VA = "0x184D215A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D20BB0", Offset = "0x4D1F3B0", VA = "0x184D20BB0")]
	public void LNLDOCGFLCM([Out] T IPHHABIKCHD, [Out] int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D20DE0", Offset = "0x4D1F5E0", VA = "0x184D20DE0")]
	public (T, int) NHNIDOKFLEF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D211C0", Offset = "0x4D1F9C0", VA = "0x184D211C0", Slot = "5")]
	private bool PAPNGKHODEE([In] BDEOGCGJGCI<T> OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DBLPGKLBMML
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28D96C0", Offset = "0x28D7EC0", VA = "0x1828D96C0")]
	public static BDEOGCGJGCI<T> OJFFIHPLODM<T>([In] T IPHHABIKCHD, int JBDLDJOINOF) where T : notnull
	{
		return default(BDEOGCGJGCI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KJOACEAHAOD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B2A030", Offset = "0x2B28830", VA = "0x182B2A030")]
	public static bool FBAIKNDMJDK<T, U>([In] T EGJINJKGIAK, [In] U GHDJADLHPAA) where T : notnull, LDBDBADILKG<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult CAKIGKEPBDC<T, out TResult>([In] T NIFGNHBNLFL);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface BNHFOIHPLNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan ABEDCDLABBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? MPOOMDDHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPJONGAFJGD();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNFGAFIIHFB();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPKNLNKGLCO();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct MDAGCJDHKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KKPJEPNMFHK IHGDGJLGKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AIGCACPIBBA EHILOIPCPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KKPJEPNMFHK LCAILGAAMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly AIGCACPIBBA EOEEGJOFKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly KKPJEPNMFHK EONMPOLJLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly AIGCACPIBBA KLMDEDHBEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly OPEBDMDIPPG GJPKBEJIOLA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KKPJEPNMFHK MIFAIBBEPJB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly AIGCACPIBBA KKMNDOKNCDF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KKPJEPNMFHK JFFNMAGGLKO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AIGCACPIBBA LCLPODIDCJP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KKPJEPNMFHK LIEILIMGPBF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly AIGCACPIBBA HGNKEFJBALC;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly OPEBDMDIPPG KCKFKNMALJJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MDAGCJDHKLK IJLPDDOKCDN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KKPJEPNMFHK BNAILMEEDHK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HACFJPDLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x691F8C0", Offset = "0x691E0C0", VA = "0x18691F8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAE6580", Offset = "0xAE4D80", VA = "0x180AE6580")]
	public MDAGCJDHKLK(KKPJEPNMFHK KPJLGGKFGLF, AIGCACPIBBA MBGEIKKBGCH, KKPJEPNMFHK MELAALGBGBP, AIGCACPIBBA CLKAGMGNOLD, KKPJEPNMFHK AEBCBAMBDJI, AIGCACPIBBA ONAFLDBAGDL, OPEBDMDIPPG GOILMCPLFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	private static bool JLCAJJANKGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void LBPMCIMOBBO(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	private static bool FGGBMAICKEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void FGLHOEKHNDK(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	private static bool DEDIKLFHPNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void JMNIAPAEPIH(string CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void JDILFEHCNNN(Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x691F780", Offset = "0x691DF80", VA = "0x18691F780")]
	private static MDAGCJDHKLK EGBMCJLMIPA()
	{
		return default(MDAGCJDHKLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
	private static bool AOFBLCIKIHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x691F710", Offset = "0x691DF10", VA = "0x18691F710")]
	public void CPICANFMBIK(object CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x691F6A0", Offset = "0x691DEA0", VA = "0x18691F6A0")]
	public void CODFCBACCFD(object CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B8E1A0", Offset = "0x1B8C9A0", VA = "0x181B8E1A0")]
	public void BDLOOEDHKPI(Exception BCGGAGLBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x691F5C0", Offset = "0x691DDC0", VA = "0x18691F5C0")]
	public void CODFCBACCFD(IAJGAGGFFGE CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B68D80", Offset = "0x2B67580", VA = "0x182B68D80")]
	public void CODFCBACCFD<T>(T NIFGNHBNLFL, EMLLKBHMLEL<T> CLBGCJICGJG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E50", Offset = "0x2B67650", VA = "0x182B68E50")]
	public void CPICANFMBIK<T>([In] T NIFGNHBNLFL, INCPOPMNFHG<T> CLBGCJICGJG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x691F4F0", Offset = "0x691DCF0", VA = "0x18691F4F0")]
	public bool AABCPFCCIDH(bool BKKMFFLBGND, string CLBGCJICGJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PFIMPLEPCIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string JDDKPJKLOJP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public PFIMPLEPCIJ(string IPHHABIKCHD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
	public static string IKACJOLFJPE([In] PFIMPLEPCIJ EGJINJKGIAK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x937BF0", Offset = "0x9363F0", VA = "0x180937BF0")]
	public static PFIMPLEPCIJ IKACJOLFJPE(string OGFCKBADKBE)
	{
		return default(PFIMPLEPCIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6922960", Offset = "0x6921160", VA = "0x186922960")]
	public string LEAEGPBAFOI(string OECMLGFFGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6922880", Offset = "0x6921080", VA = "0x186922880")]
	public string JBBOLDGBJBE(object LAJIOACGHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KNDENJDHONE : IEquatable<KNDENJDHONE>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "4")]
	public bool Equals(KNDENJDHONE OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x691E960", Offset = "0x691D160", VA = "0x18691E960", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x691E9B0", Offset = "0x691D1B0", VA = "0x18691E9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x691E9C0", Offset = "0x691D1C0", VA = "0x18691E9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[MJCEKHIGJMA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JPEFLPACLHE<T> : IEquatable<JPEFLPACLHE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T JDDKPJKLOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool DICPIPFEHBC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KDKKNMPHOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3FB5970", Offset = "0x3FB4170", VA = "0x183FB5970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3FB5CE0", Offset = "0x3FB44E0", VA = "0x183FB5CE0")]
	public JPEFLPACLHE([In] T IPHHABIKCHD, bool KNKOLCPPJKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3FB55C0", Offset = "0x3FB3DC0", VA = "0x183FB55C0")]
	public static bool JAJJILMADFD([In] JPEFLPACLHE<T> LDKECOBJCHJ, [In] JPEFLPACLHE<T> JFMCJHKCOJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4DA0", Offset = "0x3FB35A0", VA = "0x183FB4DA0", Slot = "4")]
	public bool Equals(JPEFLPACLHE<T> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3FB4FA0", Offset = "0x3FB37A0", VA = "0x183FB4FA0", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3FB53F0", Offset = "0x3FB3BF0", VA = "0x183FB53F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3FB5A40", Offset = "0x3FB4240", VA = "0x183FB5A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HDDGCJOADMG
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2AA95F0", Offset = "0x2AA7DF0", VA = "0x182AA95F0")]
	public static JPEFLPACLHE<T> HKKBAGPAEJO<T>([In] T IPHHABIKCHD) where T : notnull
	{
		return default(JPEFLPACLHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9710", Offset = "0x2AA7F10", VA = "0x182AA9710")]
	public static JPEFLPACLHE<T?> NPCNCPHCLFI<T>()
	{
		return default(JPEFLPACLHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9550", Offset = "0x2AA7D50", VA = "0x182AA9550")]
	public static bool EPFLAEGBJFA<T>([In] this JPEFLPACLHE<T> FKNEFAIIPBB, [Out][NotNullWhen(true)] T IPHHABIKCHD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct AHJKEBGFGJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr JAPDMOMEEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr HJGBEAEBKEP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GGJBFMMFKJH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr LOCBGLABPFM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly AHJKEBGFGJB IJLPDDOKCDN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HACFJPDLFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6919E60", Offset = "0x6918660", VA = "0x186919E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	public AHJKEBGFGJB(IntPtr IGDMKDGGGLJ, IntPtr BJNEHCCNECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void DKEGDGKBPDN(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	private static void GAFNOJGIJLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6919DD0", Offset = "0x69185D0", VA = "0x186919DD0")]
	private static AHJKEBGFGJB EGBMCJLMIPA()
	{
		return default(AHJKEBGFGJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct OCDKMCEOJGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr DEMBCLBLGAM;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	private OCDKMCEOJGF(IntPtr BJNEHCCNECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6921F00", Offset = "0x6920700", VA = "0x186921F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6921F20", Offset = "0x6920720", VA = "0x186921F20")]
	public static OCDKMCEOJGF OJFFIHPLODM(string GCDLMFGKKMH)
	{
		return default(OCDKMCEOJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F36890", Offset = "0x1F35090", VA = "0x181F36890")]
	public static OCDKMCEOJGF OJFFIHPLODM([In] AHJKEBGFGJB LIOHCDIBINH, string GCDLMFGKKMH)
	{
		return default(OCDKMCEOJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1F369B0", Offset = "0x1F351B0", VA = "0x181F369B0")]
	public static OCDKMCEOJGF OJFFIHPLODM([In] AHJKEBGFGJB LIOHCDIBINH, Func<string> GCDLMFGKKMH)
	{
		return default(OCDKMCEOJGF);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MPOEDBJDPLF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool NECAPGIFAMM<in TInput, TResult>(TInput FDJIPPJKNDH, [Out] TResult KKBKNCNBBJP);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class LIFBHOFNMKF : MPAMOIOIENE
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class IDMNNDGIANO : MJNAMCHMPDJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly IDMNNDGIANO DCEJKJKKEPJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool EENFPKNMENE
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x691DA40", Offset = "0x691C240", VA = "0x18691DA40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x691DAA0", Offset = "0x691C2A0", VA = "0x18691DAA0", Slot = "6")]
			public void OnCompleted(Action KECCIBAPIPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			public void BCJMMDGDKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IDMNNDGIANO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly LIFBHOFNMKF DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private LIFBHOFNMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x691E9F0", Offset = "0x691D1F0", VA = "0x18691E9F0", Slot = "4")]
		public MJNAMCHMPDJ GBAOEGHLCNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class AGJACGDNMGH : MPAMOIOIENE
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class OGJPDLGDCKG : MJNAMCHMPDJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly OGJPDLGDCKG DCEJKJKKEPJ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EENFPKNMENE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x69225C0", Offset = "0x6920DC0", VA = "0x1869225C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x69225E0", Offset = "0x6920DE0", VA = "0x1869225E0", Slot = "6")]
			public void OnCompleted(Action KECCIBAPIPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			public void BCJMMDGDKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public OGJPDLGDCKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly AGJACGDNMGH DCEJKJKKEPJ;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		private AGJACGDNMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6919D10", Offset = "0x6918510", VA = "0x186919D10", Slot = "4")]
		public MJNAMCHMPDJ GBAOEGHLCNE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LMGIIENBNMA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LMGIIENBNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40A4590", Offset = "0x40A2D90", VA = "0x1840A4590")]
		internal void PFPKJPELJNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IEKCBFDHLPC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public IEKCBFDHLPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3BDDC20", Offset = "0x3BDC420", VA = "0x183BDDC20")]
		internal void GOCDMLMMHOA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OBGAOFKOAEJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6921DA0", Offset = "0x69205A0", VA = "0x186921DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct DFJDEEJBAKN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x691AAC0", Offset = "0x69192C0", VA = "0x18691AAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct JEKMKMCKLLE<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E1A0", Offset = "0x3F7C9A0", VA = "0x183F7E1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F7E310", Offset = "0x3F7CB10", VA = "0x183F7E310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct AJOLHIKEAJO<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C45770", Offset = "0x3C43F70", VA = "0x183C45770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C46000", Offset = "0x3C44800", VA = "0x183C46000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KEODJJFOJHI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x691E6A0", Offset = "0x691CEA0", VA = "0x18691E6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x691E8A0", Offset = "0x691D0A0", VA = "0x18691E8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KKBPFPMOKGM<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KKBPFPMOKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x40A4590", Offset = "0x40A2D90", VA = "0x1840A4590")]
		internal void LGCLCOIICMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40A4510", Offset = "0x40A2D10", VA = "0x1840A4510")]
		internal void ELOMCACBJGC(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CPNDCENDHFH<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public NECAPGIFAMM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x50901F0", Offset = "0x508E9F0", VA = "0x1850901F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5090960", Offset = "0x508F160", VA = "0x185090960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GIEMOFBKJFI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x691C8E0", Offset = "0x691B0E0", VA = "0x18691C8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x691D0D0", Offset = "0x691B8D0", VA = "0x18691D0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct OECEDICBENO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6922020", Offset = "0x6920820", VA = "0x186922020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6922560", Offset = "0x6920D60", VA = "0x186922560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BDEBAJALFCK<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D1DC70", Offset = "0x4D1C470", VA = "0x184D1DC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x409E420", Offset = "0x409CC20", VA = "0x18409E420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct NJKMEHKAOJB<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4454C40", Offset = "0x4453440", VA = "0x184454C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x34AE390", Offset = "0x34ACB90", VA = "0x1834AE390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KJGFIJMAFIA<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x409E4C0", Offset = "0x409CCC0", VA = "0x18409E4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x409F230", Offset = "0x409DA30", VA = "0x18409F230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FFDACLJNLDD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x691C230", Offset = "0x691AA30", VA = "0x18691C230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x691C410", Offset = "0x691AC10", VA = "0x18691C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct DEKEPCIIFJI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x691A700", Offset = "0x6918F00", VA = "0x18691A700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x691AA60", Offset = "0x6919260", VA = "0x18691AA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GDJGHGHAGCB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x691C590", Offset = "0x691AD90", VA = "0x18691C590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x691C880", Offset = "0x691B080", VA = "0x18691C880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EHKONFFOAIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public EHKONFFOAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x691BE70", Offset = "0x691A670", VA = "0x18691BE70")]
		internal Task JJCKHKEEAEC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BCFBECDDKND : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x691A070", Offset = "0x6918870", VA = "0x18691A070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x691A2D0", Offset = "0x6918AD0", VA = "0x18691A2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PKDKBPCEIJC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x69229B0", Offset = "0x69211B0", VA = "0x1869229B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6922B90", Offset = "0x6921390", VA = "0x186922B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DMMDBHDELDO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x691BAB0", Offset = "0x691A2B0", VA = "0x18691BAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x691BE10", Offset = "0x691A610", VA = "0x18691BE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct EICKOBONECL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x691BEE0", Offset = "0x691A6E0", VA = "0x18691BEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x691C1D0", Offset = "0x691A9D0", VA = "0x18691C1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class GOIIHIHGJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public GOIIHIHGJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x691D560", Offset = "0x691BD60", VA = "0x18691D560")]
		internal Task OKMOENLHHHI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CBHAMEEKNGG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x691A360", Offset = "0x6918B60", VA = "0x18691A360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x691A5C0", Offset = "0x6918DC0", VA = "0x18691A5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ONMBIAGJFDC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x69226A0", Offset = "0x6920EA0", VA = "0x1869226A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6922820", Offset = "0x6921020", VA = "0x186922820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LGJLBMMMLAN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4147D40", Offset = "0x4146540", VA = "0x184147D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4147FC0", Offset = "0x41467C0", VA = "0x184147FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GPPCOFBFCJB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x691D5D0", Offset = "0x691BDD0", VA = "0x18691D5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x691D9E0", Offset = "0x691C1E0", VA = "0x18691D9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? FPCBCEGJNFK;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<KNDENJDHONE> DFMINGKBCHH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task FLMKBDPNIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6921350", Offset = "0x691FB50", VA = "0x186921350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x69202A0", Offset = "0x691EAA0", VA = "0x1869202A0")]
	public static bool AILJIFAFKFP(this Task GECIOHOBBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DFD0", Offset = "0x2B7C7D0", VA = "0x182B7DFD0")]
	public static Task<T> PDCAPPLBHJO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69209B0", Offset = "0x691F1B0", VA = "0x1869209B0")]
	public static Task HJJCCPGKCLE(this Task GECIOHOBBCH, CancellationToken OECMOOGGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C690", Offset = "0x2B7AE90", VA = "0x182B7C690")]
	public static Task<TResult> HJJCCPGKCLE<TResult>(this Task<TResult> GECIOHOBBCH, CancellationToken OECMOOGGOOF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CFE0", Offset = "0x2B7B7E0", VA = "0x182B7CFE0")]
	public static TaskCompletionSource<TResult> HJJCCPGKCLE<TResult>(this TaskCompletionSource<TResult> EIMIBCHGJKJ, CancellationToken OECMOOGGOOF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x69213C0", Offset = "0x691FBC0", VA = "0x1869213C0")]
	public static IDisposable? KPMJKDAPGNH(CancellationToken NKOACJDOMBN, CancellationToken OJPJIIECKOA, [Out] CancellationToken FAECCLDBNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6920850", Offset = "0x691F050", VA = "0x186920850")]
	[AsyncStateMachine(typeof(OBGAOFKOAEJ))]
	public static void FDLLAKKGMMO(this Task AFCJJMLHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6920900", Offset = "0x691F100", VA = "0x186920900")]
	[AsyncStateMachine(typeof(DFJDEEJBAKN))]
	public static void GAJKEBHMIIL(this Task AFCJJMLHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B79BF0", Offset = "0x2B783F0", VA = "0x182B79BF0")]
	[AsyncStateMachine(typeof(JEKMKMCKLLE<>))]
	public static Task ABANMMONIPJ<TException>(this Task AFCJJMLHKMJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DDF0", Offset = "0x2B7C5F0", VA = "0x182B7DDF0")]
	[AsyncStateMachine(typeof(AJOLHIKEAJO<>))]
	public static Task<T> NKMBHFAKKFE<T>(this Task<T> EGJINJKGIAK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6920550", Offset = "0x691ED50", VA = "0x186920550")]
	[AsyncStateMachine(typeof(KEODJJFOJHI))]
	public static Task<TaskStatus> DBBKJGHDPDL(this Task EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A180", Offset = "0x2B78980", VA = "0x182B7A180")]
	public static (Task<T?>?, Action<T?>?) GDKKAOEBFMN<T>([Optional] CancellationToken ODNHMAMKFFP)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B79F80", Offset = "0x2B78780", VA = "0x182B79F80")]
	[AsyncStateMachine(typeof(CPNDCENDHFH<, >))]
	public static Task<List<TResult>> CGMCMIGMHOJ<TResult, TInput>(this Task<List<TInput>> GECIOHOBBCH, NECAPGIFAMM<TInput, TResult> LMCPOMKMJNF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6920EC0", Offset = "0x691F6C0", VA = "0x186920EC0")]
	[AsyncStateMachine(typeof(GIEMOFBKJFI))]
	public static Task JKOIOLMHBPP(Task AFCJJMLHKMJ, CancellationToken OKNLKNIHJFM, Func<CancellationToken, Task> DAFMHLLFHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x69217B0", Offset = "0x691FFB0", VA = "0x1869217B0")]
	[AsyncStateMachine(typeof(OECEDICBENO))]
	public static Task NFCDPGHALDF(Func<CancellationToken, Task> OMPIGNKBJLB, TimeSpan GIGKLDABMPI, [Optional] CancellationToken OKNLKNIHJFM, [Optional] Action<OperationCanceledException>? IDHOOGNIAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB50", Offset = "0x2B7C350", VA = "0x182B7DB50")]
	[AsyncStateMachine(typeof(BDEBAJALFCK<>))]
	public static Task<T> NFCDPGHALDF<T>(Func<CancellationToken, Task<T>> OMPIGNKBJLB, TimeSpan GIGKLDABMPI, [Optional] CancellationToken OKNLKNIHJFM, [Optional] Func<OperationCanceledException, T>? IDHOOGNIAMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DA60", Offset = "0x2B7C260", VA = "0x182B7DA60")]
	[AsyncStateMachine(typeof(NJKMEHKAOJB<>))]
	public static Task<IEnumerable<Task<T>>> IFGCHMCMKFN<T>(IEnumerable<Task<T>> HDBGIAOLEJP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B79CC0", Offset = "0x2B784C0", VA = "0x182B79CC0")]
	[AsyncStateMachine(typeof(KJGFIJMAFIA<, , , >))]
	public static Task<(T1, T2, T3, T4)> ACAFEEBMGFL<T1, T2, T3, T4>(Task<T1> OFKGJIGCMFG, Task<T2> HBODHCNKLJM, Task<T3> JCCBBFCOJIO, Task<T4> HOFINMEKPHJ) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x69216C0", Offset = "0x691FEC0", VA = "0x1869216C0")]
	[AsyncStateMachine(typeof(FFDACLJNLDD))]
	public static Task MAKCEDFLNCF(Func<bool> BKKMFFLBGND, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x69215B0", Offset = "0x691FDB0", VA = "0x1869215B0")]
	[AsyncStateMachine(typeof(DEKEPCIIFJI))]
	public static Task MAKCEDFLNCF(Func<bool> BKKMFFLBGND, TimeSpan PPNIMLAIMGD, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6921A20", Offset = "0x6920220", VA = "0x186921A20")]
	[AsyncStateMachine(typeof(GDJGHGHAGCB))]
	public static Task NOIPBCIHGMP(Func<bool> BKKMFFLBGND, TimeSpan GIGKLDABMPI, [Optional] CancellationToken ODNHMAMKFFP, [Optional] Action<OperationCanceledException>? IDHOOGNIAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x69218E0", Offset = "0x69200E0", VA = "0x1869218E0")]
	[AsyncStateMachine(typeof(BCFBECDDKND))]
	public static Task NOIPBCIHGMP(Func<bool> BKKMFFLBGND, TimeSpan GIGKLDABMPI, TimeSpan PPNIMLAIMGD, [Optional] CancellationToken ODNHMAMKFFP, [Optional] Action<OperationCanceledException>? IDHOOGNIAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69202D0", Offset = "0x691EAD0", VA = "0x1869202D0")]
	[AsyncStateMachine(typeof(PKDKBPCEIJC))]
	public static Task CEKGAABMOGP(Func<bool> BKKMFFLBGND, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x69203C0", Offset = "0x691EBC0", VA = "0x1869203C0")]
	[AsyncStateMachine(typeof(DMMDBHDELDO))]
	public static Task CEKGAABMOGP(Func<bool> BKKMFFLBGND, TimeSpan PPNIMLAIMGD, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6920C50", Offset = "0x691F450", VA = "0x186920C50")]
	[AsyncStateMachine(typeof(EICKOBONECL))]
	public static Task JFBGODALJOJ(Func<bool> BKKMFFLBGND, TimeSpan GIGKLDABMPI, [Optional] CancellationToken ODNHMAMKFFP, [Optional] Action<OperationCanceledException>? IDHOOGNIAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6920D80", Offset = "0x691F580", VA = "0x186920D80")]
	[AsyncStateMachine(typeof(CBHAMEEKNGG))]
	public static Task JFBGODALJOJ(Func<bool> BKKMFFLBGND, TimeSpan GIGKLDABMPI, TimeSpan PPNIMLAIMGD, [Optional] CancellationToken ODNHMAMKFFP, [Optional] Action<OperationCanceledException>? IDHOOGNIAMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6920690", Offset = "0x691EE90", VA = "0x186920690")]
	[Obsolete]
	[AsyncStateMachine(typeof(ONMBIAGJFDC))]
	public static Task EMPONLCGJKA(this Task GECIOHOBBCH, Action HIIBKBNOBMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A090", Offset = "0x2B78890", VA = "0x182B7A090")]
	[Obsolete]
	[AsyncStateMachine(typeof(LGJLBMMMLAN<>))]
	public static Task EMPONLCGJKA<T>(this Task<T> GECIOHOBBCH, Action<T> HIIBKBNOBMP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6921500", Offset = "0x691FD00", VA = "0x186921500")]
	private static void LFEAFJOJAON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6920FF0", Offset = "0x691F7F0", VA = "0x186920FF0")]
	public static bool KJEEMMANPHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6920050", Offset = "0x691E850", VA = "0x186920050")]
	private static void AFJLHHDJKGP(SynchronizationContext IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6921B50", Offset = "0x6920350", VA = "0x186921B50")]
	private static void PFKAKBBHPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6920780", Offset = "0x691EF80", VA = "0x186920780")]
	public static void EPAPOJLDEBM([Optional] string? CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x69204D0", Offset = "0x691ECD0", VA = "0x1869204D0")]
	public static void DAFHDCOAIAB([Optional] string? CLBGCJICGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6920C00", Offset = "0x691F400", VA = "0x186920C00")]
	public static MPAMOIOIENE IFGBOJINMGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6920640", Offset = "0x691EE40", VA = "0x186920640")]
	public static MPAMOIOIENE EFBNNAOIDLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69201D0", Offset = "0x691E9D0", VA = "0x1869201D0")]
	[AsyncStateMachine(typeof(GPPCOFBFCJB))]
	public static Task AIHCMPACPPG(Func<Task> CPDLACEKNJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BFNFAOFCCLN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
	public BFNFAOFCCLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GLKGJLAADKA : FNGFBHPFCDF
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly FNGFBHPFCDF DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime LGADIEFHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x691D190", Offset = "0x691B990", VA = "0x18691D190", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset KPMBKFDCCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x691D130", Offset = "0x691B930", VA = "0x18691D130", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public GLKGJLAADKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface FNGFBHPFCDF
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime LGADIEFHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset KPMBKFDCCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DGGCPDBNPHA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long EOGEGCGDOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x691B000", Offset = "0x6919800", VA = "0x18691B000")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long MKPNJAMKOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x691B050", Offset = "0x6919850", VA = "0x18691B050")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double JEKMCEMCODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x691AC60", Offset = "0x6919460", VA = "0x18691AC60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double KLFAJKEHGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x691AEB0", Offset = "0x69196B0", VA = "0x18691AEB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double GMHBKCBMMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x691AFB0", Offset = "0x69197B0", VA = "0x18691AFB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LMKFEKEOKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x691AF60", Offset = "0x6919760", VA = "0x18691AF60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x691ABD0", Offset = "0x69193D0", VA = "0x18691ABD0")]
	public static double DDFJBLENGOF(long IOFDHKEIPKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x691ACB0", Offset = "0x69194B0", VA = "0x18691ACB0")]
	public static double DPADDGPJMPH(long IOFDHKEIPKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x691B0A0", Offset = "0x69198A0", VA = "0x18691B0A0")]
	public static double OLOPJGBKJCF(double IPNOIEIOICA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x691AE20", Offset = "0x6919620", VA = "0x18691AE20")]
	public static long GPLNHHALBKJ(long JCJNKLHAGJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x691AD40", Offset = "0x6919540", VA = "0x18691AD40")]
	public static long EMODGJIHCPA(long KEOFFDLFIJL, long ONPPNBMNPDC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x691AD50", Offset = "0x6919550", VA = "0x18691AD50")]
	public static double FAODEOCDOJG(long KEOFFDLFIJL, long ONPPNBMNPDC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x691AF00", Offset = "0x6919700", VA = "0x18691AF00")]
	public static double JJGKCEHBIDC(long KEOFFDLFIJL, long ONPPNBMNPDC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class DHFKICOLHCI : BNHFOIHPLNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan DCJKNKEHKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer JPMGDEGBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan GIGKLDABMPI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan ABEDCDLABBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x691B470", Offset = "0x6919C70", VA = "0x18691B470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? MPOOMDDHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x691BA50", Offset = "0x691A250", VA = "0x18691BA50")]
	[Preserve]
	public DHFKICOLHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x691B800", Offset = "0x691A000", VA = "0x18691B800")]
	public DHFKICOLHCI(TimeSpan GIGKLDABMPI, [Optional] Action? EANEGLBHOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x691B700", Offset = "0x6919F00", VA = "0x18691B700", Slot = "7")]
	public void PPJONGAFJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x691B690", Offset = "0x6919E90", VA = "0x18691B690", Slot = "8")]
	public void NNFGAFIIHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x691B5D0", Offset = "0x6919DD0", VA = "0x18691B5D0", Slot = "9")]
	public void GPKNLNKGLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8ED750", Offset = "0x8EBF50", VA = "0x1808ED750")]
	private void NBIJPJEACBL(object NOFEINPOGPG, ElapsedEventArgs ONENBDIDFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x691B600", Offset = "0x6919E00", VA = "0x18691B600")]
	private static void KJPGAEJFLHM(TimeSpan PKDADMPNFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x691B3D0", Offset = "0x6919BD0", VA = "0x18691B3D0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MJCEKHIGJMA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? AMMIMINBIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string NIHMFODCELP;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x63EF5B0", Offset = "0x63EDDB0", VA = "0x1863EF5B0")]
	public MJCEKHIGJMA(string LGOHHLIODIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3D88990", Offset = "0x3D87190", VA = "0x183D88990")]
	public MJCEKHIGJMA(string MAMHFGLGIND, string LGOHHLIODIF)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct AFFMEBCPHON : IEquatable<AFFMEBCPHON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint HKGKHPGDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int GCBKLOLMCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float NNNCNDPOCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort BAPEGBHAHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort FAJALPDPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short DCOLOEAAPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short IMCGCBPGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char KBIMHMHAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char BAJFFCPGNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte LLGAKJDOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte IFMMAJCANAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte GDOFNLJMEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte HJOJEJJAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool MNAMGOKAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool OCBMHDOOKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool ODAAHMAOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool KJAHKCAGAFN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
	public static AFFMEBCPHON NLMGJCPFOCA(uint FFPHGIOJJID)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
	public static AFFMEBCPHON EGFCLDBGJPJ(int ECEKDKBHMHI)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6918EA0", Offset = "0x69176A0", VA = "0x186918EA0")]
	public static AFFMEBCPHON MLNCBBBBHIK(float LEEHGDOFJKC)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6918DF0", Offset = "0x69175F0", VA = "0x186918DF0")]
	public static AFFMEBCPHON AFFOKDAFEPO(byte OKONDHDJMAE, byte FJCEBEEHOJN, byte PKEMMALCILB, byte PKCLAECKAOP)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6918DF0", Offset = "0x69175F0", VA = "0x186918DF0")]
	public static AFFMEBCPHON HLLBBFFCJMG(bool DJHAHAJBPNE, bool DLBGIEAPEAA, bool AONEPEBBPCK, bool AIGOGMCGANB)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6918DF0", Offset = "0x69175F0", VA = "0x186918DF0")]
	public static AFFMEBCPHON FMNNNGPKGLO(byte KKAGIJDFPNM, byte JGHAJADAPKO, byte ANDHEPKOMBF, byte EGBEKMNGHCL)
	{
		return default(AFFMEBCPHON);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E080", Offset = "0x1A0C880", VA = "0x181A0E080")]
	public static bool JAJJILMADFD(AFFMEBCPHON JOMKMIJJPCA, AFFMEBCPHON DFLDBCDDIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9A35E0", Offset = "0x9A1DE0", VA = "0x1809A35E0", Slot = "4")]
	public bool Equals(AFFMEBCPHON OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6918E10", Offset = "0x6917610", VA = "0x186918E10", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xA6A220", Offset = "0xA68A20", VA = "0x180A6A220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6918EB0", Offset = "0x69176B0", VA = "0x186918EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KKCJFOFMEHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong DGBKBIBAMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long CCNKEKNFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double JIHJBCPCCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint OKOLKDMMHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint FCJKDADMOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int LLPJJKJNHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int GLFLMLNACHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float GEEPKCKEPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float HGJDDDEKOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort BAPEGBHAHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort FAJALPDPGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort CDLNAFNBOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort HCPFMCIMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short DCOLOEAAPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short IMCGCBPGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short NCLOEDHCCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short DNBKGFFBKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char KBIMHMHAGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char BAJFFCPGNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char JEEHMMFLIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char EJFOGBLBJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte LLGAKJDOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte IFMMAJCANAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte GDOFNLJMEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte HJOJEJJAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte OBGNLNIHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte KNPCIHFMOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte LILBNABHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte EJFLGJBFJOJ;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x691E910", Offset = "0x691D110", VA = "0x18691E910")]
	public static KKCJFOFMEHE OJFFIHPLODM(byte OKONDHDJMAE, byte FJCEBEEHOJN, byte PKEMMALCILB, byte PKCLAECKAOP, byte JACMALBOKIP, byte KHOAILHCLNN, byte ANOONNKBGLE, byte PDEKCHDACBG)
	{
		return default(KKCJFOFMEHE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct GMLBGJOPJAI : IEquatable<GMLBGJOPJAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte AHEMMLGFCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool GBLJMKHEOME;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C50", Offset = "0x24B3450", VA = "0x1824B4C50")]
	public static GMLBGJOPJAI AFFOKDAFEPO(byte BDLCKHLEMOL)
	{
		return default(GMLBGJOPJAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C50", Offset = "0x24B3450", VA = "0x1824B4C50")]
	public static GMLBGJOPJAI HLLBBFFCJMG(bool EGMEKBCDLGL)
	{
		return default(GMLBGJOPJAI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x691D2E0", Offset = "0x691BAE0", VA = "0x18691D2E0")]
	public static bool JAJJILMADFD(GMLBGJOPJAI JOMKMIJJPCA, GMLBGJOPJAI DFLDBCDDIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5B22530", Offset = "0x5B20D30", VA = "0x185B22530", Slot = "4")]
	public bool Equals(GMLBGJOPJAI OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x691D240", Offset = "0x691BA40", VA = "0x18691D240", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x691D2D0", Offset = "0x691BAD0", VA = "0x18691D2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x691D2F0", Offset = "0x691BAF0", VA = "0x18691D2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class PCMNEPJCKHG<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T CLHCDPAGGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x464E960", Offset = "0x464D160", VA = "0x18464E960")]
	public PCMNEPJCKHG(T KEOPDEJEEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LAGBAKOPBMP
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2B485F0", Offset = "0x2B46DF0", VA = "0x182B485F0")]
	public static IEnumerable<T> CMHPNHKOIKE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static T[] JCKGFGCFOHB<T>(params T[] JOJGIOPECGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static IEnumerable<T> PJKGHNPPOPG<T>(params T[] JOJGIOPECGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static HashSet<T> GEJMMNNINGA<T>(params T[] JOJGIOPECGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2B48620", Offset = "0x2B46E20", VA = "0x182B48620")]
	public static KeyValuePair<TKey, TValue> FGFGJCNJMJJ<TKey, TValue>([In] TKey JOEHGGMHBAA, [In] TValue IPHHABIKCHD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static List<T> OBOHAJDAANP<T>(IEnumerable<T> BFMOHBHIKHF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KLCEBOKGMJG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string LONCGNMCPAL;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
	public KLCEBOKGMJG(string MBIIHBIIKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object INCPOPMNFHG<T>([In] T EKJLJLJONBC);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object EMLLKBHMLEL<T>(T EKJLJLJONBC);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[LGFIGFGINKK]
public delegate string MCFCMJKNMOI(string KKDAHIDPNBA, string? JEOLOLCNKCP, bool FCLMPEMJNLI);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LGFIGFGINKK]
public delegate void AIGCACPIBBA(string CLBGCJICGJG);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LGFIGFGINKK]
public delegate void OPEBDMDIPPG(Exception BCGGAGLBPHE);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object IAJGAGGFFGE();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[LGFIGFGINKK]
public delegate bool KKPJEPNMFHK();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[LGFIGFGINKK]
public delegate string PENGBBJCLFE(object GHDJADLHPAA);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class FGCANOEDBAK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
	public FGCANOEDBAK()
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
