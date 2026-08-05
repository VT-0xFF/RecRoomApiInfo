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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A41BE0", Offset = "0x6A40BE0", VA = "0x186A41BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LCNLKMJJJIB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA20", Offset = "0x6A3CA20", VA = "0x186A3DA20")]
	public static string ILIHODLCKBO(this Encoding ILGDGKFHOJB, [In] ReadOnlySequence<byte> JFDEDKFKPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9380", Offset = "0x2BF8380", VA = "0x182BF9380")]
	private static void FJCJNPPFHGB<T>(this ReadOnlySequence<T> LEJKAHCECBB, [Out] ReadOnlySpan<T> NHODDCEMLOH, [Out] SequencePosition CBBBENFNCGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class FGCGGDHHOMB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B7B0", Offset = "0x6A3A7B0", VA = "0x186A3B7B0")]
	public FGCGGDHHOMB(bool LOPMFJCFEKO, string DOFFIPEDECO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HGOKNHIPDOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NGNJPDCMJKP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<TResult> MDJKDPDEFPO(CancellationToken DADBOHKBJNO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FLBBPJNIGOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public NGNJPDCMJKP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MDJKDPDEFPO taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C638D0", Offset = "0x3C628D0", VA = "0x183C638D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C64A10", Offset = "0x3C63A10", VA = "0x183C64A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource GKNCGENIMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? PDIJNEJJNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? BIMODGFDAFC;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4576880", Offset = "0x4575880", VA = "0x184576880")]
	[AsyncStateMachine(typeof(NGNJPDCMJKP<>.FLBBPJNIGOG))]
	public Task<TResult> OLHHLIFEBBF(MDJKDPDEFPO BBOCNPPPBOK, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4576810", Offset = "0x4575810", VA = "0x184576810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45769D0", Offset = "0x45759D0", VA = "0x1845769D0")]
	public NGNJPDCMJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class MPMMPLEFLKC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> FLGKEDNBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T BLBBIKKJHJE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE9D0", Offset = "0x3CED9D0", VA = "0x183CEE9D0")]
	public MPMMPLEFLKC([In] T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4513D20", Offset = "0x4512D20", VA = "0x184513D20", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4514170", Offset = "0x4513170", VA = "0x184514170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4514290", Offset = "0x4513290", VA = "0x184514290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PLEECENCHHG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
	public static MPMMPLEFLKC<T> HCLFOFEHDJP<T>([In] T CBAEIEAPLIH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IFMBNBOICMP
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C360", Offset = "0x6A3B360", VA = "0x186A3C360")]
	public static void EDJEHKMOLFO(this CancellationTokenSource GKNCGENIMLH, bool BJMNMFJPEKA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class JBBAGAFOGEE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
	public JBBAGAFOGEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class DMMOHDONLFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
	public DMMOHDONLFE(string IAMNMPKBEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PFAKDCEIEOB
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5030", Offset = "0x2CD4030", VA = "0x182CD5030")]
	public static IPPJMIBFJDE DPOMOCOJMKB<T>()
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD52B0", Offset = "0x2CD42B0", VA = "0x182CD52B0")]
	public static IPPJMIBFJDE EPOCILOFDDG<T>([CallerMemberName] string LCLKDNPLMED = "") where T : notnull
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4FB0", Offset = "0x2CD3FB0", VA = "0x182CD4FB0")]
	public static IPPJMIBFJDE DPOMOCOJMKB<T>(this T JLMICGLMAKN) where T : notnull
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5350", Offset = "0x2CD4350", VA = "0x182CD5350")]
	public static IPPJMIBFJDE HINHGHOFCCJ<T>(this T JLMICGLMAKN, [CallerMemberName] string LCLKDNPLMED = "") where T : notnull
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5200", Offset = "0x2CD4200", VA = "0x182CD5200")]
	public static IPPJMIBFJDE EPOCILOFDDG<T>(this T OLDDCPCBGIL, [CallerMemberName] string LCLKDNPLMED = "") where T : notnull
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A42880", Offset = "0x6A41880", VA = "0x186A42880")]
	public static IPPJMIBFJDE EPOCILOFDDG(string PIGGADNICNN, [CallerMemberName] string LCLKDNPLMED = "")
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A427E0", Offset = "0x6A417E0", VA = "0x186A427E0")]
	public static string BKKMAFECEOG(this object OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate bool EABOHIJCJCG();
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JBBAGAFOGEE]
public delegate long GAFFIIAFAHO();
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LKKFMMELCMK
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MMAIJIMMHIF KDOCIJNDEKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MMAIJIMMHIF GDFLLOEBPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A3EF50", Offset = "0x6A3DF50", VA = "0x186A3EF50")]
		get
		{
			return default(MMAIJIMMHIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LCPBKNBGEPG CCPMOCFFHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F510", Offset = "0x6A3E510", VA = "0x186A3F510")]
		get
		{
			return default(LCPBKNBGEPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HIELPLLBGID GGLLAINHGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F040", Offset = "0x6A3E040", VA = "0x186A3F040")]
		get
		{
			return default(HIELPLLBGID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool GEOFBIJALEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A3ECC0", Offset = "0x6A3DCC0", VA = "0x186A3ECC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F2F0", Offset = "0x6A3E2F0", VA = "0x186A3F2F0")]
	public static void OJIKGGHDJBA([In] MMAIJIMMHIF JBDKGBMJPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EE80", Offset = "0x6A3DE80", VA = "0x186A3EE80")]
	public static void EMMOGPNJFNP(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F130", Offset = "0x6A3E130", VA = "0x186A3F130")]
	public static void JNGKCIFJIFE(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEAC0", Offset = "0x2BFDAC0", VA = "0x182BFEAC0")]
	public static void JNGKCIFJIFE<T>(T HFLBLCMJIKA, OCAFJMIIFFL<T> NFOHONOFFAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F090", Offset = "0x6A3E090", VA = "0x186A3F090")]
	public static void HPLOLMMJCNB(Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F270", Offset = "0x6A3E270", VA = "0x186A3F270")]
	public static void KJAHGPGCOPB(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F4A0", Offset = "0x6A3E4A0", VA = "0x186A3F4A0")]
	public static void PLCMAPGKDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A3ED30", Offset = "0x6A3DD30", VA = "0x186A3ED30")]
	public static string BKKMAFECEOG(object HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F200", Offset = "0x6A3E200", VA = "0x186A3F200")]
	public static long JPKOBDNDFJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EFA0", Offset = "0x6A3DFA0", VA = "0x186A3EFA0")]
	public static bool FLCOFIJHBAO(bool HENBCPJDKPD, string NFOHONOFFAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EDB0", Offset = "0x6A3DDB0", VA = "0x186A3EDB0")]
	public static double DDILFAIIPOG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct MMAIJIMMHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly LCPBKNBGEPG CCPMOCFFHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HIELPLLBGID GGLLAINHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly IOCBGPJLEDH CKECGPBGNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly GAFFIIAFAHO HLFLNNFHNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly IBOCJCBKFDF CKNBJPGFNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly EABOHIJCJCG NBACCEADOLN;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly IOCBGPJLEDH NPFLLOMMBCO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly GAFFIIAFAHO DPECMBLGKPL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly IBOCJCBKFDF FKGAKNNIABO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EABOHIJCJCG JEDOIKHOABO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly MMAIJIMMHIF BHJAMJDAEMH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A40D10", Offset = "0x6A3FD10", VA = "0x186A40D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A416F0", Offset = "0x6A406F0", VA = "0x186A416F0")]
	public MMAIJIMMHIF([In] LCPBKNBGEPG OEGKKLCKOEC, [In] HIELPLLBGID JNDCFPIOHLP, IOCBGPJLEDH NECNHIJAMAJ, GAFFIIAFAHO LOALMELHGDN, IBOCJCBKFDF KEKLCINHFMM, EABOHIJCJCG NHEOIMFLIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A40EB0", Offset = "0x6A3FEB0", VA = "0x186A40EB0")]
	private static string FJBEKHIMPAN(object HBFCGFKGCAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	private static long KDACIJOOMDE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	private static string PDGJMEGBHAF(string KIBGJLLHGOJ, string? JNNHDMKPDLF, bool GABHAEALBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
	private static bool BCNPALICGGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A40EF0", Offset = "0x6A3FEF0", VA = "0x186A40EF0")]
	private static MMAIJIMMHIF NKMJBAODIPB()
	{
		return default(MMAIJIMMHIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LKMJALMCFAD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACDOCJGLKDD GCIDINGPBLA();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ACDOCJGLKDD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EJHJFDECFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNNMANEJCPD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KGDHAIHHNLM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IGJJOJCONLL([In] T LJAAPFIIPOF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void HAOKCEODEEO<T>([In] T HFLBLCMJIKA);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JJFNMLNAJJG<T> : IEquatable<JJFNMLNAJJG<T>>, KGDHAIHHNLM<JJFNMLNAJJG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T BLBBIKKJHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int FPNFNABMIOF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB2C0", Offset = "0x1FEA2C0", VA = "0x181FEB2C0")]
	public JJFNMLNAJJG([In] T CBAEIEAPLIH, int LLPJHIPCNFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4114320", Offset = "0x4113320", VA = "0x184114320")]
	public static bool JEKPEIKHIPM([In] JJFNMLNAJJG<T> KKEPMPAJLEA, [In] JJFNMLNAJJG<T> HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D29170", Offset = "0x3D28170", VA = "0x183D29170", Slot = "4")]
	public bool Equals(JJFNMLNAJJG<T> LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4113820", Offset = "0x4112820", VA = "0x184113820", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4113D00", Offset = "0x4112D00", VA = "0x184113D00")]
	public bool IGJJOJCONLL([In] JJFNMLNAJJG<T> LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4113960", Offset = "0x4112960", VA = "0x184113960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4114650", Offset = "0x4113650", VA = "0x184114650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4112DD0", Offset = "0x4111DD0", VA = "0x184112DD0")]
	public void CLDPEJLCOKN([Out] T CBAEIEAPLIH, [Out] int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41134A0", Offset = "0x41124A0", VA = "0x1841134A0")]
	public (T, int) ELJKDBPDAJI()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4114400", Offset = "0x4113400", VA = "0x184114400", Slot = "5")]
	private bool MICHNDLJOJC([In] JJFNMLNAJJG<T> LJAAPFIIPOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HIIDMOCAKHF
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B25890", Offset = "0x2B24890", VA = "0x182B25890")]
	public static JJFNMLNAJJG<T> HCLFOFEHDJP<T>([In] T CBAEIEAPLIH, int LLPJHIPCNFD) where T : notnull
	{
		return default(JJFNMLNAJJG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DDDCFNGIMEA
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x297CDD0", Offset = "0x297BDD0", VA = "0x18297CDD0")]
	public static bool IGJJOJCONLL<T, U>([In] T OLDDCPCBGIL, [In] U HBFCGFKGCAF) where T : notnull, KGDHAIHHNLM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult OFBBBKEOMBC<T, out TResult>([In] T HFLBLCMJIKA);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface EPKMFHPMMHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan BLKMKNNBOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? BELOPECKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKDEJNGAEPP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COBNELOEJLL();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAKANIGBLDP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct LCPBKNBGEPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly PGLKCJMLBPP HBIHKOONJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly CPMKKLAPPOH EJJBCMLCBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly PGLKCJMLBPP IOEJOGFMNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly CPMKKLAPPOH HPAPKGABJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly PGLKCJMLBPP DEGMGJJMFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly CPMKKLAPPOH BIFOKBBKDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly GEPGBAPDDAD NAGHNKFIKCF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly PGLKCJMLBPP HGCCHANHKOD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly CPMKKLAPPOH ANLICECHHAI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly PGLKCJMLBPP FJMJDAINIIK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly CPMKKLAPPOH OIBBJHNJPPB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PGLKCJMLBPP OHIDMJAFBKG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly CPMKKLAPPOH MAHFNIEOGHC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GEPGBAPDDAD BHOMJBCPOJF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly LCPBKNBGEPG BHJAMJDAEMH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly PGLKCJMLBPP IPNAHFAPGME;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A3DFF0", Offset = "0x6A3CFF0", VA = "0x186A3DFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB2CBE0", Offset = "0xB2BBE0", VA = "0x180B2CBE0")]
	public LCPBKNBGEPG(PGLKCJMLBPP ENECJLMLMBK, CPMKKLAPPOH OAGPIOMLNPM, PGLKCJMLBPP DGEODOLAMEK, CPMKKLAPPOH JEOPMAMNKJJ, PGLKCJMLBPP KBEMLNMDGLM, CPMKKLAPPOH DDCLCBAENKP, GEPGBAPDDAD OLHHDLEAICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
	private static bool NMAEIEDEPKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void EFNCEOMKLFG(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
	private static bool NAJNDOLMOGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void MBFEOCGCGCH(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0")]
	private static bool LMOMCINDMKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void HNAOKHDNKCA(string NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void GEEGPCDGMFJ(Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E480", Offset = "0x6A3D480", VA = "0x186A3E480")]
	private static LCPBKNBGEPG NKMJBAODIPB()
	{
		return default(LCPBKNBGEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530")]
	private static bool CGBCLJGPAFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E1F0", Offset = "0x6A3D1F0", VA = "0x186A3E1F0")]
	public void EMMOGPNJFNP(object NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E410", Offset = "0x6A3D410", VA = "0x186A3E410")]
	public void JNGKCIFJIFE(object NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2E60", Offset = "0x1BF1E60", VA = "0x181BF2E60")]
	public void HPLOLMMJCNB(Exception CNGGKHFOGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E330", Offset = "0x6A3D330", VA = "0x186A3E330")]
	public void JNGKCIFJIFE(PLFPAIGMAML NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9750", Offset = "0x2BF8750", VA = "0x182BF9750")]
	public void JNGKCIFJIFE<T>(T HFLBLCMJIKA, OCAFJMIIFFL<T> NFOHONOFFAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BF94E0", Offset = "0x2BF84E0", VA = "0x182BF94E0")]
	public void EMMOGPNJFNP<T>([In] T HFLBLCMJIKA, EMAAAHKMGAJ<T> NFOHONOFFAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9680", Offset = "0x2BF8680", VA = "0x182BF9680")]
	public void JNGKCIFJIFE<T>([In] T HFLBLCMJIKA, EMAAAHKMGAJ<T> NFOHONOFFAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E260", Offset = "0x6A3D260", VA = "0x186A3E260")]
	public bool FLCOFIJHBAO(bool HENBCPJDKPD, string NFOHONOFFAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct IPPJMIBFJDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string BLBBIKKJHJE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	public IPPJMIBFJDE(string CBAEIEAPLIH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0")]
	public static string CPPJIHNILOM([In] IPPJMIBFJDE OLDDCPCBGIL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x995F80", Offset = "0x994F80", VA = "0x180995F80")]
	public static IPPJMIBFJDE CPPJIHNILOM(string LJAAPFIIPOF)
	{
		return default(IPPJMIBFJDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB10", Offset = "0x6A3BB10", VA = "0x186A3CB10")]
	public string HANNIJGNKJE(string KEHAKFBOBOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A3CB60", Offset = "0x6A3BB60", VA = "0x186A3CB60")]
	public string PHNOKOCPEHF(object JCBKOPIMNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct HNKFFDNJINI : IEquatable<HNKFFDNJINI>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "4")]
	public bool Equals(HNKFFDNJINI LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C100", Offset = "0x6A3B100", VA = "0x186A3C100", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C150", Offset = "0x6A3B150", VA = "0x186A3C150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C160", Offset = "0x6A3B160", VA = "0x186A3C160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[NONNNOEJCPN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GBGJJMPMMOC<T> : IEquatable<GBGJJMPMMOC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T BLBBIKKJHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool EJKKGPPHNPE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool ALPLFMBJFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3D29CE0", Offset = "0x3D28CE0", VA = "0x183D29CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A0B0", Offset = "0x3D290B0", VA = "0x183D2A0B0")]
	public GBGJJMPMMOC([In] T CBAEIEAPLIH, bool JOIMFBFEADH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3D29930", Offset = "0x3D28930", VA = "0x183D29930")]
	public static bool JEKPEIKHIPM([In] GBGJJMPMMOC<T> KKEPMPAJLEA, [In] GBGJJMPMMOC<T> HIEMMBKCCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3D29170", Offset = "0x3D28170", VA = "0x183D29170", Slot = "4")]
	public bool Equals(GBGJJMPMMOC<T> LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D29490", Offset = "0x3D28490", VA = "0x183D29490", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D296B0", Offset = "0x3D286B0", VA = "0x183D296B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D29D50", Offset = "0x3D28D50", VA = "0x183D29D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EPMLCHGHIMD
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x29ADA00", Offset = "0x29ACA00", VA = "0x1829ADA00")]
	public static GBGJJMPMMOC<T> GKBCDEFPDLE<T>([In] T CBAEIEAPLIH) where T : notnull
	{
		return default(GBGJJMPMMOC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x29ADB20", Offset = "0x29ACB20", VA = "0x1829ADB20")]
	public static GBGJJMPMMOC<T?> LCKBDGAEMGD<T>()
	{
		return default(GBGJJMPMMOC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x29AD960", Offset = "0x29AC960", VA = "0x1829AD960")]
	public static bool COOOHOJNPIN<T>([In] this GBGJJMPMMOC<T> FFDJBNLHKBH, [Out][NotNullWhen(true)] T CBAEIEAPLIH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HIELPLLBGID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr KJAHGPGCOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr PLCMAPGKDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr KKHKDNFPIAN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr CHLGOKANEGO;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly HIELPLLBGID BHJAMJDAEMH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DFLAHLKBLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BE40", Offset = "0x6A3AE40", VA = "0x186A3BE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	public HIELPLLBGID(IntPtr DLIPNCNGONA, IntPtr NBBDKFDHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void KFJNFDHCMKM(string LCLKDNPLMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	private static void EMDPCONAJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BF20", Offset = "0x6A3AF20", VA = "0x186A3BF20")]
	private static HIELPLLBGID NKMJBAODIPB()
	{
		return default(HIELPLLBGID);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct LFIFACPPGFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr EFECKFOEJOP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	private LFIFACPPGFE(IntPtr NBBDKFDHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EBA0", Offset = "0x6A3DBA0", VA = "0x186A3EBA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EBC0", Offset = "0x6A3DBC0", VA = "0x186A3EBC0")]
	public static LFIFACPPGFE HCLFOFEHDJP(string LCLKDNPLMED)
	{
		return default(LFIFACPPGFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FC13F0", Offset = "0x1FC03F0", VA = "0x181FC13F0")]
	public static LFIFACPPGFE HCLFOFEHDJP([In] HIELPLLBGID JNDCFPIOHLP, string LCLKDNPLMED)
	{
		return default(LFIFACPPGFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FC19C0", Offset = "0x1FC09C0", VA = "0x181FC19C0")]
	public static LFIFACPPGFE HCLFOFEHDJP([In] HIELPLLBGID JNDCFPIOHLP, Func<string> LCLKDNPLMED)
	{
		return default(LFIFACPPGFE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DAILFDPIGEC
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate bool BEDDHHKNLAD<in TInput, TResult>(TInput CPEKGDIIDKL, [Out] TResult HJBJAPKPPFA);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class ECLKEKMPOCP : LKMJALMCFAD
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class DDNDFPPBPPJ : ACDOCJGLKDD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly DDNDFPPBPPJ IBMHAACFGKI;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool EJHJFDECFOB
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6A3B260", Offset = "0x6A3A260", VA = "0x186A3B260", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A3B2C0", Offset = "0x6A3A2C0", VA = "0x186A3B2C0", Slot = "6")]
			public void OnCompleted(Action HGHEBPNBGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			public void JNNMANEJCPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public DDNDFPPBPPJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly ECLKEKMPOCP IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		private ECLKEKMPOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B4A0", Offset = "0x6A3A4A0", VA = "0x186A3B4A0", Slot = "4")]
		public ACDOCJGLKDD GCIDINGPBLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class IDEKNCIHONN : LKMJALMCFAD
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class KPHADILJCHK : ACDOCJGLKDD, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly KPHADILJCHK IBMHAACFGKI;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EJHJFDECFOB
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6A3D930", Offset = "0x6A3C930", VA = "0x186A3D930", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6A3D950", Offset = "0x6A3C950", VA = "0x186A3D950", Slot = "6")]
			public void OnCompleted(Action HGHEBPNBGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			public void JNNMANEJCPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KPHADILJCHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly IDEKNCIHONN IBMHAACFGKI;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		private IDEKNCIHONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C290", Offset = "0x6A3B290", VA = "0x186A3C290", Slot = "4")]
		public ACDOCJGLKDD GCIDINGPBLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IMMFICFHCOG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public IMMFICFHCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCE60", Offset = "0x3ECBE60", VA = "0x183ECCE60")]
		internal void BHLIKCBCNNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KEEOCJFAMDK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public KEEOCJFAMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4208C10", Offset = "0x4207C10", VA = "0x184208C10")]
		internal void ADCKNKCBMNH(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BGOAAEEJGMN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6A38B40", Offset = "0x6A37B40", VA = "0x186A38B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GHBIHICFMKA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BD30", Offset = "0x6A3AD30", VA = "0x186A3BD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9FB160", Offset = "0x9FA160", VA = "0x1809FB160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EMBFMAOLPCK<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3851AA0", Offset = "0x3850AA0", VA = "0x183851AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3851C10", Offset = "0x3850C10", VA = "0x183851C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FCMOGNLJPFJ<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C36E70", Offset = "0x3C35E70", VA = "0x183C36E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C372C0", Offset = "0x3C362C0", VA = "0x183C372C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FIMFHCFFEDA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B880", Offset = "0x6A3A880", VA = "0x186A3B880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BA80", Offset = "0x6A3AA80", VA = "0x186A3BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class IHKKEMJAJFM<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public IHKKEMJAJFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCE60", Offset = "0x3ECBE60", VA = "0x183ECCE60")]
		internal void IPBOGIMJGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCED0", Offset = "0x3ECBED0", VA = "0x183ECCED0")]
		internal void OOHHMLBIIKB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FCGAPGHNLBM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public BEDDHHKNLAD<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C358A0", Offset = "0x3C348A0", VA = "0x183C358A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C36010", Offset = "0x3C35010", VA = "0x183C36010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MGOLJMKKDMG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A404C0", Offset = "0x6A3F4C0", VA = "0x186A404C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A40CB0", Offset = "0x6A3FCB0", VA = "0x186A40CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IKKCNEBACBB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C390", Offset = "0x6A3B390", VA = "0x186A3C390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C8D0", Offset = "0x6A3B8D0", VA = "0x186A3C8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DIKLOOPPODE<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x582E5B0", Offset = "0x582D5B0", VA = "0x18582E5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3EE99F0", Offset = "0x3EE89F0", VA = "0x183EE99F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct NMBHKGPCNGC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x45A89C0", Offset = "0x45A79C0", VA = "0x1845A89C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3560910", Offset = "0x355F910", VA = "0x183560910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MCKMHAKKBCO<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x44D1AF0", Offset = "0x44D0AF0", VA = "0x1844D1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x44D2840", Offset = "0x44D1840", VA = "0x1844D2840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FPMKAHDNFEL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BAF0", Offset = "0x6A3AAF0", VA = "0x186A3BAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BCD0", Offset = "0x6A3ACD0", VA = "0x186A3BCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NIACCJHKNPI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A41810", Offset = "0x6A40810", VA = "0x186A41810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A41B80", Offset = "0x6A40B80", VA = "0x186A41B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OGFGHLHFDLB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A41C60", Offset = "0x6A40C60", VA = "0x186A41C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A41F50", Offset = "0x6A40F50", VA = "0x186A41F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NCJFHGONKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public NCJFHGONKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A417A0", Offset = "0x6A407A0", VA = "0x186A417A0")]
		internal Task HFDJONFNGNB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JAFKADPEAKE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CC40", Offset = "0x6A3BC40", VA = "0x186A3CC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CEA0", Offset = "0x6A3BEA0", VA = "0x186A3CEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct FEEPIKMGHDL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B570", Offset = "0x6A3A570", VA = "0x186A3B570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A3B750", Offset = "0x6A3A750", VA = "0x186A3B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct APKGFHAIFIB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A38720", Offset = "0x6A37720", VA = "0x186A38720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A38A90", Offset = "0x6A37A90", VA = "0x186A38A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct AJMKFNCBGLO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A383D0", Offset = "0x6A373D0", VA = "0x186A383D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A386C0", Offset = "0x6A376C0", VA = "0x186A386C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JMMPBJGCDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public JMMPBJGCDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CF00", Offset = "0x6A3BF00", VA = "0x186A3CF00")]
		internal Task AJMNHFIIFOD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct KGMGPMOCEOK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CF70", Offset = "0x6A3BF70", VA = "0x186A3CF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D1D0", Offset = "0x6A3C1D0", VA = "0x186A3D1D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct ILDKDCDPFPD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C930", Offset = "0x6A3B930", VA = "0x186A3C930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A3CAB0", Offset = "0x6A3BAB0", VA = "0x186A3CAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct OCGFINOPGFC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4681530", Offset = "0x4680530", VA = "0x184681530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x46817B0", Offset = "0x46807B0", VA = "0x1846817B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BMEMHFHPICA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6A38DC0", Offset = "0x6A37DC0", VA = "0x186A38DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6A391D0", Offset = "0x6A381D0", VA = "0x186A391D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? MHPDHCNAMIB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<HNKFFDNJINI> FJMNDPOHLBM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task JNFNGMAABGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A680", Offset = "0x6A39680", VA = "0x186A3A680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A3F0", Offset = "0x6A393F0", VA = "0x186A3A3F0")]
	public static bool KMKIJKOLPEH(this Task PEBIPFJADEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x297B7C0", Offset = "0x297A7C0", VA = "0x18297B7C0")]
	public static Task<T> JEJNBLKMELF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A70", Offset = "0x6A38A70", VA = "0x186A39A70")]
	public static Task FFMGCGOGCKA(this Task PEBIPFJADEI, CancellationToken OEDJKICDDGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2979BD0", Offset = "0x2978BD0", VA = "0x182979BD0")]
	public static Task<TResult> FFMGCGOGCKA<TResult>(this Task<TResult> PEBIPFJADEI, CancellationToken OEDJKICDDGA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x297AB60", Offset = "0x2979B60", VA = "0x18297AB60")]
	public static TaskCompletionSource<TResult> FFMGCGOGCKA<TResult>(this TaskCompletionSource<TResult> JJKMKHFJDHK, CancellationToken OEDJKICDDGA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A150", Offset = "0x6A39150", VA = "0x186A3A150")]
	public static IDisposable? IOHCDLFGNOO(CancellationToken DJLEFHADOKE, CancellationToken JBMHEOKIOPC, [Out] CancellationToken BBCIPIACBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A39230", Offset = "0x6A38230", VA = "0x186A39230")]
	[AsyncStateMachine(typeof(BGOAAEEJGMN))]
	public static void BEDHIMEMHIH(this Task LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A290", Offset = "0x6A39290", VA = "0x186A3A290")]
	[AsyncStateMachine(typeof(GHBIHICFMKA))]
	public static void JHJOIFDKLDF(this Task LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x297B6F0", Offset = "0x297A6F0", VA = "0x18297B6F0")]
	[AsyncStateMachine(typeof(EMBFMAOLPCK<>))]
	public static Task IMJONOBHEAG<TException>(this Task LBKJPGMAINP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x297BBC0", Offset = "0x297ABC0", VA = "0x18297BBC0")]
	[AsyncStateMachine(typeof(FCMOGNLJPFJ<>))]
	public static Task<T> MEJOCHOLNNC<T>(this Task<T> OLDDCPCBGIL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A39850", Offset = "0x6A38850", VA = "0x186A39850")]
	[AsyncStateMachine(typeof(FIMFHCFFEDA))]
	public static Task<TaskStatus> DKICNKKFOIA(this Task OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x297B940", Offset = "0x297A940", VA = "0x18297B940")]
	public static (Task<T?>?, Action<T?>?) KIPCFPIFJID<T>([Optional] CancellationToken DADBOHKBJNO)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x297B4F0", Offset = "0x297A4F0", VA = "0x18297B4F0")]
	[AsyncStateMachine(typeof(FCGAPGHNLBM<, >))]
	public static Task<List<TResult>> FGMHPGHFNNN<TResult, TInput>(this Task<List<TInput>> PEBIPFJADEI, BEDDHHKNLAD<TInput, TResult> JIMGPDHBKDH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A39940", Offset = "0x6A38940", VA = "0x186A39940")]
	[AsyncStateMachine(typeof(MGOLJMKKDMG))]
	public static Task FAGPLEPKCIE(Task LBKJPGMAINP, CancellationToken HCOOOCBFMFM, Func<CancellationToken, Task> HAPDDEBNPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A6F0", Offset = "0x6A396F0", VA = "0x186A3A6F0")]
	[AsyncStateMachine(typeof(IKKCNEBACBB))]
	public static Task MNPFOHBDGNH(Func<CancellationToken, Task> CGMLOOJFLHN, TimeSpan MNIKPDPFHJC, [Optional] CancellationToken HCOOOCBFMFM, [Optional] Action<OperationCanceledException>? KEMGGFNPMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x297BDA0", Offset = "0x297ADA0", VA = "0x18297BDA0")]
	[AsyncStateMachine(typeof(DIKLOOPPODE<>))]
	public static Task<T> MNPFOHBDGNH<T>(Func<CancellationToken, Task<T>> CGMLOOJFLHN, TimeSpan MNIKPDPFHJC, [Optional] CancellationToken HCOOOCBFMFM, [Optional] Func<OperationCanceledException, T>? KEMGGFNPMPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2977EB0", Offset = "0x2976EB0", VA = "0x182977EB0")]
	[AsyncStateMachine(typeof(NMBHKGPCNGC<>))]
	public static Task<IEnumerable<Task<T>>> BHCGPMMHGKO<T>(IEnumerable<Task<T>> FKPGCJOIFPJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x297C040", Offset = "0x297B040", VA = "0x18297C040")]
	[AsyncStateMachine(typeof(MCKMHAKKBCO<, , , >))]
	public static Task<(T1, T2, T3, T4)> ODBGHAACAAL<T1, T2, T3, T4>(Task<T1> AGFIJOJDEMP, Task<T2> NLMFOPIILKD, Task<T3> BLAFGJBLGGE, Task<T4> CHJOKAFIIKC) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A39650", Offset = "0x6A38650", VA = "0x186A39650")]
	[AsyncStateMachine(typeof(FPMKAHDNFEL))]
	public static Task DJHDJEKPAOH(Func<bool> HENBCPJDKPD, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A39740", Offset = "0x6A38740", VA = "0x186A39740")]
	[AsyncStateMachine(typeof(NIACCJHKNPI))]
	public static Task DJHDJEKPAOH(Func<bool> HENBCPJDKPD, TimeSpan JHFNKODKIJI, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A820", Offset = "0x6A39820", VA = "0x186A3A820")]
	[AsyncStateMachine(typeof(OGFGHLHFDLB))]
	public static Task NHIMMAFNJJN(Func<bool> HENBCPJDKPD, TimeSpan MNIKPDPFHJC, [Optional] CancellationToken DADBOHKBJNO, [Optional] Action<OperationCanceledException>? KEMGGFNPMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A950", Offset = "0x6A39950", VA = "0x186A3A950")]
	[AsyncStateMachine(typeof(JAFKADPEAKE))]
	public static Task NHIMMAFNJJN(Func<bool> HENBCPJDKPD, TimeSpan MNIKPDPFHJC, TimeSpan JHFNKODKIJI, [Optional] CancellationToken DADBOHKBJNO, [Optional] Action<OperationCanceledException>? KEMGGFNPMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A393F0", Offset = "0x6A383F0", VA = "0x186A393F0")]
	[AsyncStateMachine(typeof(FEEPIKMGHDL))]
	public static Task BPBIPPOBJMA(Func<bool> HENBCPJDKPD, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A392E0", Offset = "0x6A382E0", VA = "0x186A392E0")]
	[AsyncStateMachine(typeof(APKGFHAIFIB))]
	public static Task BPBIPPOBJMA(Func<bool> HENBCPJDKPD, TimeSpan JHFNKODKIJI, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A39EE0", Offset = "0x6A38EE0", VA = "0x186A39EE0")]
	[AsyncStateMachine(typeof(AJMKFNCBGLO))]
	public static Task IFIMOFLFADP(Func<bool> HENBCPJDKPD, TimeSpan MNIKPDPFHJC, [Optional] CancellationToken DADBOHKBJNO, [Optional] Action<OperationCanceledException>? KEMGGFNPMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A010", Offset = "0x6A39010", VA = "0x186A3A010")]
	[AsyncStateMachine(typeof(KGMGPMOCEOK))]
	public static Task IFIMOFLFADP(Func<bool> HENBCPJDKPD, TimeSpan MNIKPDPFHJC, TimeSpan JHFNKODKIJI, [Optional] CancellationToken DADBOHKBJNO, [Optional] Action<OperationCanceledException>? KEMGGFNPMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A39CD0", Offset = "0x6A38CD0", VA = "0x186A39CD0")]
	[AsyncStateMachine(typeof(ILDKDCDPFPD))]
	[Obsolete]
	public static Task FKKFOOJGEAF(this Task PEBIPFJADEI, Action FDECEIMBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x297B600", Offset = "0x297A600", VA = "0x18297B600")]
	[Obsolete]
	[AsyncStateMachine(typeof(OCGFINOPGFC<>))]
	public static Task FKKFOOJGEAF<T>(this Task<T> PEBIPFJADEI, Action<T> FDECEIMBCHJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A340", Offset = "0x6A39340", VA = "0x186A3A340")]
	private static void KBHANDHNPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA90", Offset = "0x6A39A90", VA = "0x186A3AA90")]
	public static bool PJBAEMFCGFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A4F0", Offset = "0x6A394F0", VA = "0x186A3A4F0")]
	private static void LLGBDEFOIDC(SynchronizationContext CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A39DC0", Offset = "0x6A38DC0", VA = "0x186A39DC0")]
	private static void HFJDHFGOOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A420", Offset = "0x6A39420", VA = "0x186A3A420")]
	public static void LFNONIAPMIC([Optional] string? NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AE10", Offset = "0x6A39E10", VA = "0x186A3AE10")]
	public static void PNCPBLIGLGH([Optional] string? NFOHONOFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A39530", Offset = "0x6A38530", VA = "0x186A39530")]
	public static LKMJALMCFAD CFFKFHLBGLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A394E0", Offset = "0x6A384E0", VA = "0x186A394E0")]
	public static LKMJALMCFAD BPOMKFEBCIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A39580", Offset = "0x6A38580", VA = "0x186A39580")]
	[AsyncStateMachine(typeof(BMEMHFHPICA))]
	public static Task DBPGEPGEHIM(Func<Task> LHGGEBICOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LEDNJNPECJC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
	public LEDNJNPECJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class BJHMGDHMGCI : JICBKFOJJHG
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly JICBKFOJJHG IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime LJPHADFKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A38D00", Offset = "0x6A37D00", VA = "0x186A38D00", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset DFOAAEGAAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A38CA0", Offset = "0x6A37CA0", VA = "0x186A38CA0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public BJHMGDHMGCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface JICBKFOJJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime LJPHADFKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset DFOAAEGAAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OLCIMIAHBKP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long DLBKONDJCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A42190", Offset = "0x6A41190", VA = "0x186A42190")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long IBFFFHHFCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A420F0", Offset = "0x6A410F0", VA = "0x186A420F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double BEFPEPKPJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A42140", Offset = "0x6A41140", VA = "0x186A42140")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double PKPHEEMCGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A421F0", Offset = "0x6A411F0", VA = "0x186A421F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MBAOJLMAOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A423A0", Offset = "0x6A413A0", VA = "0x186A423A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double PLAJDBLOHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A41FB0", Offset = "0x6A40FB0", VA = "0x186A41FB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6A42310", Offset = "0x6A41310", VA = "0x186A42310")]
	public static double JEMEBEIIDFO(long NGCPLJGFIKH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A42000", Offset = "0x6A41000", VA = "0x186A42000")]
	public static double CICCBMEPMJM(long NGCPLJGFIKH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A42480", Offset = "0x6A41480", VA = "0x186A42480")]
	public static double PFCPPOMPKGL(double PCLKNDGANEI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A423F0", Offset = "0x6A413F0", VA = "0x186A423F0")]
	public static long NKIMBMCDOGJ(long PJKHGIHPBDF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A421E0", Offset = "0x6A411E0", VA = "0x186A421E0")]
	public static long GFNCJAJFDHD(long DFFKGOIIHDL, long KLANKACJOMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A42240", Offset = "0x6A41240", VA = "0x186A42240")]
	public static double IELJDLBMOLM(long DFFKGOIIHDL, long KLANKACJOMK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A42090", Offset = "0x6A41090", VA = "0x186A42090")]
	public static double CLCJOKKALOC(long DFFKGOIIHDL, long KLANKACJOMK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class KJBIHHGJLGN : EPKMFHPMMHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan PIMPCECPHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer OPELNCJDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan MNIKPDPFHJC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan BLKMKNNBOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D4A0", Offset = "0x6A3C4A0", VA = "0x186A3D4A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? BELOPECKIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D8C0", Offset = "0x6A3C8C0", VA = "0x186A3D8C0")]
	[Preserve]
	public KJBIHHGJLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D670", Offset = "0x6A3C670", VA = "0x186A3D670")]
	public KJBIHHGJLGN(TimeSpan MNIKPDPFHJC, [Optional] Action? MAGJBKGGLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D260", Offset = "0x6A3C260", VA = "0x186A3D260", Slot = "7")]
	public void BKDEJNGAEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D2F0", Offset = "0x6A3C2F0", VA = "0x186A3D2F0", Slot = "8")]
	public void COBNELOEJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D230", Offset = "0x6A3C230", VA = "0x186A3D230", Slot = "9")]
	public void AAKANIGBLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x939DB0", Offset = "0x938DB0", VA = "0x180939DB0")]
	private void OJGNLJANBJP(object JLMICGLMAKN, ElapsedEventArgs BGBHBJMJJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D400", Offset = "0x6A3C400", VA = "0x186A3D400")]
	private static void HOJEJAFBEAN(TimeSpan EJKFMNAGODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D360", Offset = "0x6A3C360", VA = "0x186A3D360", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class NONNNOEJCPN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? CFHELBLJIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string JJPCBIMLAAA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x64EE610", Offset = "0x64ED610", VA = "0x1864EE610")]
	public NONNNOEJCPN(string LDFBANEAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3E8CEF0", Offset = "0x3E8BEF0", VA = "0x183E8CEF0")]
	public NONNNOEJCPN(string EGOPOEBLEJP, string LDFBANEAJLN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LMMGKDHJIFE : IEquatable<LMMGKDHJIFE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint LEGPAFHLMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int CPNBKFIACOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float GOEALPBEBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort CLNKNKPHNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort JJKEABCJEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short HECPEPFABNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short BOLBNOAKAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char GKIAGMCAIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char KPHHBLICGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte JLHNFEBEHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte CAOHOPJJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte BHNIBEFFJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte JNIHFCLFBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool IJIPPNGEFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool CBFMPMCHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool KIIGCNPCMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool MNGICOOLKCK;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xE1FD00", Offset = "0xE1ED00", VA = "0x180E1FD00")]
	public static LMMGKDHJIFE IHCKJBPPKFO(uint ICALAIFNKGA)
	{
		return default(LMMGKDHJIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xE1FD00", Offset = "0xE1ED00", VA = "0x180E1FD00")]
	public static LMMGKDHJIFE OHPJJPFIFEM(int FKHFGFLDMEA)
	{
		return default(LMMGKDHJIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F620", Offset = "0x6A3E620", VA = "0x186A3F620")]
	public static LMMGKDHJIFE EPCDGNACEGL(float HLAMOKPNJLI)
	{
		return default(LMMGKDHJIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F6B0", Offset = "0x6A3E6B0", VA = "0x186A3F6B0")]
	public static LMMGKDHJIFE MPAGDLCCCHD(byte ABNACAOLINL, byte HHNGPGMBCIO, byte BLKJBOPELOC, byte JDAOOLMGFIC)
	{
		return default(LMMGKDHJIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F6B0", Offset = "0x6A3E6B0", VA = "0x186A3F6B0")]
	public static LMMGKDHJIFE HJOGHLEIJKD(bool JICLCBKDFEB, bool PPGGKPBGCML, bool KFCMLDIHIMG, bool GHCPKPLLOFK)
	{
		return default(LMMGKDHJIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F6B0", Offset = "0x6A3E6B0", VA = "0x186A3F6B0")]
	public static LMMGKDHJIFE KBJKIFEBFEL(byte OEMNBCEJJDP, byte IHPOAFFPEIA, byte OJPLGAOLHNG, byte CJGLEDHICGJ)
	{
		return default(LMMGKDHJIFE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1A7CD60", Offset = "0x1A7BD60", VA = "0x181A7CD60")]
	public static bool JEKPEIKHIPM(LMMGKDHJIFE ILBMPADICAD, LMMGKDHJIFE BEOPIALHGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9FE480", Offset = "0x9FD480", VA = "0x1809FE480", Slot = "4")]
	public bool Equals(LMMGKDHJIFE LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F630", Offset = "0x6A3E630", VA = "0x186A3F630", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xABDC80", Offset = "0xABCC80", VA = "0x180ABDC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F6D0", Offset = "0x6A3E6D0", VA = "0x186A3F6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct APKJKKCICHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong BFOOLKOFBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long DAJIJKDOEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double HMHEODEENDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint GJMBDDJIOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint MGMDJPNMAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int JLFILECEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int ABEFDAEIJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float FJLIHJNJCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float HLBLPHADNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort CLNKNKPHNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort JJKEABCJEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort MKLEBKJBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort FKGDMICHAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short HECPEPFABNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short BOLBNOAKAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short LLPHPJAELCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short INPAEKJJCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char GKIAGMCAIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char KPHHBLICGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char HGNNJIAMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char IAICELNCBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte JLHNFEBEHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte CAOHOPJJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BHNIBEFFJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte JNIHFCLFBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte HIMEEMHBGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte BCENOLILKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte IHCOOPNKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte MJKFIGOBPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A38AF0", Offset = "0x6A37AF0", VA = "0x186A38AF0")]
	public static APKJKKCICHO HCLFOFEHDJP(byte ABNACAOLINL, byte HHNGPGMBCIO, byte BLKJBOPELOC, byte JDAOOLMGFIC, byte GFOEJJOMILA, byte OAOLJADFMDJ, byte IBEJDDNOOJI, byte JNJEAHNIMHB)
	{
		return default(APKJKKCICHO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct DCEFNEACGGD : IEquatable<DCEFNEACGGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte OFBOHCCFLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool FIBEENNDHBI;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x25842F0", Offset = "0x25832F0", VA = "0x1825842F0")]
	public static DCEFNEACGGD MPAGDLCCCHD(byte ELDKIFNAPHH)
	{
		return default(DCEFNEACGGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x25842F0", Offset = "0x25832F0", VA = "0x1825842F0")]
	public static DCEFNEACGGD HJOGHLEIJKD(bool LBGKEBPPBDI)
	{
		return default(DCEFNEACGGD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AFF0", Offset = "0x6A39FF0", VA = "0x186A3AFF0")]
	public static bool JEKPEIKHIPM(DCEFNEACGGD ILBMPADICAD, DCEFNEACGGD BEOPIALHGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5BE6320", Offset = "0x5BE5320", VA = "0x185BE6320", Slot = "4")]
	public bool Equals(DCEFNEACGGD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AF50", Offset = "0x6A39F50", VA = "0x186A3AF50", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AFE0", Offset = "0x6A39FE0", VA = "0x186A3AFE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B000", Offset = "0x6A3A000", VA = "0x186A3B000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CKDEAJHKNKN<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T FKHIJPGGCNJ;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5175E80", Offset = "0x5174E80", VA = "0x185175E80")]
	public CKDEAJHKNKN(T DICJNNPBHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class NEMBOJDGLOH
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2B059B0", Offset = "0x2B049B0", VA = "0x182B059B0")]
	public static IEnumerable<T> FJEEEPOMKOE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static T[] INIPPJIHHLB<T>(params T[] JFBNLEIMLOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static IEnumerable<T> OOOFIKHEIMM<T>(params T[] JFBNLEIMLOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
	public static HashSet<T> AABKKCAMFCB<T>(params T[] JFBNLEIMLOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C834E0", Offset = "0x2C824E0", VA = "0x182C834E0")]
	public static KeyValuePair<TKey, TValue> CCMONAGBNCF<TKey, TValue>([In] TKey BHEIPBKEDLG, [In] TValue CBAEIEAPLIH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
	public static List<T> KJAFNDKAPIL<T>(IEnumerable<T> ONEIHMPFJKE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ALLMMCMLLNM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string JNNPKAJNFGE;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
	public ALLMMCMLLNM(string AFNOHMNGAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object EMAAAHKMGAJ<T>([In] T NENLABMEOHA);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object OCAFJMIIFFL<T>(T NENLABMEOHA);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[JBBAGAFOGEE]
public delegate string IBOCJCBKFDF(string KIBGJLLHGOJ, string? JNNHDMKPDLF, bool GABHAEALBKD);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[JBBAGAFOGEE]
public delegate void CPMKKLAPPOH(string NFOHONOFFAP);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[JBBAGAFOGEE]
public delegate void GEPGBAPDDAD(Exception CNGGKHFOGEI);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object PLFPAIGMAML();
[Cpp2IlInjected.Token(Token = "0x200005D")]
[JBBAGAFOGEE]
public delegate bool PGLKCJMLBPP();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[JBBAGAFOGEE]
public delegate string IOCBGPJLEDH(object HBFCGFKGCAF);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Enum)]
public class OHPOAFDJDPI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
	public OHPOAFDJDPI()
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
