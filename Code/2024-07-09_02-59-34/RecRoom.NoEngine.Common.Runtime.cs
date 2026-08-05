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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AA1970", Offset = "0x6AA0570", VA = "0x186AA1970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FJNCFKKKPII
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A98FD0", Offset = "0x6A97BD0", VA = "0x186A98FD0")]
	public static string JNBJCJAKELJ(this Encoding OGFLOOKBGLI, [In] ReadOnlySequence<byte> GABEBEKDBIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BD20", Offset = "0x2B1A920", VA = "0x182B1BD20")]
	private static void GNELHJOBFIK<T>(this ReadOnlySequence<T> BEMAKBEIOIC, [Out] ReadOnlySpan<T> PCMMIDHNJEI, [Out] SequencePosition PKEJJHKMFCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BJPOGEIFIOC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A97D00", Offset = "0x6A96900", VA = "0x186A97D00")]
	public BJPOGEIFIOC(bool OCPPENKIJMD, string LDCJPPCEDBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ANBFNEEBOFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ABEAGMOLHPD<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate Task<TResult> KIFCDKJLMNM(CancellationToken PPKBAEMFIMG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct ENGICOEBBPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ABEAGMOLHPD<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KIFCDKJLMNM taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3855260", Offset = "0x3853E60", VA = "0x183855260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x38563A0", Offset = "0x3854FA0", VA = "0x1838563A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource GJNGFDIEBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? NHMFDJJKMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? OKBBEGOHOKD;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE53D0", Offset = "0x3CE3FD0", VA = "0x183CE53D0")]
	[AsyncStateMachine(typeof(ABEAGMOLHPD<>.ENGICOEBBPF))]
	public Task<TResult> JEINKLBFENL(KIFCDKJLMNM CPHPNOFKKGH, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5360", Offset = "0x3CE3F60", VA = "0x183CE5360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5520", Offset = "0x3CE4120", VA = "0x183CE5520")]
	public ABEAGMOLHPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class GLFACGIFOAB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> FAFDAJKKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T JCMGPEFMEMP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D60C10", Offset = "0x3D5F810", VA = "0x183D60C10")]
	public GLFACGIFOAB([In] T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D5FE60", Offset = "0x3D5EA60", VA = "0x183D5FE60", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D60300", Offset = "0x3D5EF00", VA = "0x183D60300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D608A0", Offset = "0x3D5F4A0", VA = "0x183D608A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class JFLBDMEJMEC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static GLFACGIFOAB<T> FCDPFGJNKNI<T>([In] T IIPLJLPCLBC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DDDOFEOHCIB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A98130", Offset = "0x6A96D30", VA = "0x186A98130")]
	public static void IDPHHJNICKI(this CancellationTokenSource GJNGFDIEBMK, bool FJPILAKCKCK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FAKEPOPLBLE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
	public FAKEPOPLBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class DDGBKNGOPIL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
	public DDGBKNGOPIL(string FLOILGIFHCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LJGFJKCOFFK
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C17A70", Offset = "0x2C16670", VA = "0x182C17A70")]
	public static AIEKDGCGBEF PBBJIAFKHBM<T>()
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C17880", Offset = "0x2C16480", VA = "0x182C17880")]
	public static AIEKDGCGBEF FHHJEFLCGGH<T>([CallerMemberName] string LONKACOOPGJ = "") where T : notnull
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C17AF0", Offset = "0x2C166F0", VA = "0x182C17AF0")]
	public static AIEKDGCGBEF PBBJIAFKHBM<T>(this T LDAADCAOFLJ) where T : notnull
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C17920", Offset = "0x2C16520", VA = "0x182C17920")]
	public static AIEKDGCGBEF JEKNJIEPKMB<T>(this T LDAADCAOFLJ, [CallerMemberName] string LONKACOOPGJ = "") where T : notnull
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C177D0", Offset = "0x2C163D0", VA = "0x182C177D0")]
	public static AIEKDGCGBEF FHHJEFLCGGH<T>(this T ENEDBNLKLJL, [CallerMemberName] string LONKACOOPGJ = "") where T : notnull
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D3E0", Offset = "0x6A9BFE0", VA = "0x186A9D3E0")]
	public static AIEKDGCGBEF FHHJEFLCGGH(string HGELPKILGJN, [CallerMemberName] string LONKACOOPGJ = "")
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D460", Offset = "0x6A9C060", VA = "0x186A9D460")]
	public static string MHGJPCNOAOA(this object ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate bool NLGAHFMKDEB();
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FAKEPOPLBLE]
public delegate long DPANHBFCPFP();
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GHEABHBPJIH
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GKNFOPKBCMC MAFHAPCCFFL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GKNFOPKBCMC FLNDMMAEPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AD90", Offset = "0x6A99990", VA = "0x186A9AD90")]
		get
		{
			return default(GKNFOPKBCMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GCALLIFKLKK ONCNELAKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AE80", Offset = "0x6A99A80", VA = "0x186A9AE80")]
		get
		{
			return default(GCALLIFKLKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PJIPAIPEOMG AAGCCCNGHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AAF0", Offset = "0x6A996F0", VA = "0x186A9AAF0")]
		get
		{
			return default(PJIPAIPEOMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool DGAKNDPIIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A9ABE0", Offset = "0x6A997E0", VA = "0x186A9ABE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AF50", Offset = "0x6A99B50", VA = "0x186A9AF50")]
	public static void NFMBOEOIINE([In] GKNFOPKBCMC BGPFDKGFKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AC50", Offset = "0x6A99850", VA = "0x186A9AC50")]
	public static void IOIJAALEDGI(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B2C0", Offset = "0x6A99EC0", VA = "0x186A9B2C0")]
	public static void PAHNJPDDDAB(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B311D0", Offset = "0x2B2FDD0", VA = "0x182B311D0")]
	public static void PAHNJPDDDAB<T>(T OKLJLMJMKDA, PADFELPKKKE<T> NKAJDDICLFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AB40", Offset = "0x6A99740", VA = "0x186A9AB40")]
	public static void DALJONHLFMH(Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B170", Offset = "0x6A99D70", VA = "0x186A9B170")]
	public static void OIEMIIFBKJD(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AD20", Offset = "0x6A99920", VA = "0x186A9AD20")]
	public static void JENHGMFBKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AED0", Offset = "0x6A99AD0", VA = "0x186A9AED0")]
	public static string MHGJPCNOAOA(object APKAFMDACKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B100", Offset = "0x6A99D00", VA = "0x186A9B100")]
	public static long OBEPCLEDNHG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A9ADE0", Offset = "0x6A999E0", VA = "0x186A9ADE0")]
	public static bool LAEDGFLAGKA(bool FFGGIJJLJGP, string NKAJDDICLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B1F0", Offset = "0x6A99DF0", VA = "0x186A9B1F0")]
	public static double OJCBIBBNCNK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct GKNFOPKBCMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GCALLIFKLKK ONCNELAKHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly PJIPAIPEOMG AAGCCCNGHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly HDPIHMGKADK BKHGLKGELCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly DPANHBFCPFP DLNAANFACLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly NFFFEMBCNLL BHJDFCALFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly NLGAHFMKDEB FAOGMCPAIKE;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly HDPIHMGKADK LKDBNHGFOBG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly DPANHBFCPFP DKFDHEKGOLP;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly NFFFEMBCNLL LIKBICNBPAF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly NLGAHFMKDEB HGDNGALEDLH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly GKNFOPKBCMC ECELLENMKJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B450", Offset = "0x6A9A050", VA = "0x186A9B450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BE30", Offset = "0x6A9AA30", VA = "0x186A9BE30")]
	public GKNFOPKBCMC([In] GCALLIFKLKK GIABMHOGBGE, [In] PJIPAIPEOMG NFPOPOPADII, HDPIHMGKADK FIBMBGOOCMP, DPANHBFCPFP PKPLOBJCJLK, NFFFEMBCNLL OBDMKLIOBLA, NLGAHFMKDEB KELGDAJKJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B700", Offset = "0x6A9A300", VA = "0x186A9B700")]
	private static string HENANHMADGM(object APKAFMDACKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x866B30", Offset = "0x865730", VA = "0x180866B30")]
	private static long KAICPJCEHPC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	private static string NFOOABJNECA(string GBJCJEFDEPC, string? LOLFBCCGJCN, bool OBDBGBGDKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	private static bool DHJMKNCEHMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B5F0", Offset = "0x6A9A1F0", VA = "0x186A9B5F0")]
	private static GKNFOPKBCMC GJGLMCGNGCG()
	{
		return default(GKNFOPKBCMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBHGDBGFMPE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCIEKADKHCM GBDFPBKCPFK();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NCIEKADKHCM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DLJHKCAJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEACIAHFIKF();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BLAHLINOAIB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLOLPFEAPBE([In] T HEIGABGMPLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void CDIHPPEEIOM<T>([In] T OKLJLMJMKDA);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct IKJPLMFPOOE<T> : IEquatable<IKJPLMFPOOE<T>>, BLAHLINOAIB<IKJPLMFPOOE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T JCMGPEFMEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int ICIBDGPPAOE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1750", Offset = "0x1FF0350", VA = "0x181FF1750")]
	public IKJPLMFPOOE([In] T IIPLJLPCLBC, int BAEBMIBABAE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EB01A0", Offset = "0x3EAEDA0", VA = "0x183EB01A0")]
	public static bool IGDKJEPDLHP([In] IKJPLMFPOOE<T> HDIFBMODGOB, [In] IKJPLMFPOOE<T> ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C28AD0", Offset = "0x3C276D0", VA = "0x183C28AD0", Slot = "4")]
	public bool Equals(IKJPLMFPOOE<T> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF910", Offset = "0x3EAE510", VA = "0x183EAF910", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0450", Offset = "0x3EAF050", VA = "0x183EB0450")]
	public bool JLOLPFEAPBE([In] IKJPLMFPOOE<T> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EAFA70", Offset = "0x3EAE670", VA = "0x183EAFA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1140", Offset = "0x3EAFD40", VA = "0x183EB1140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0A00", Offset = "0x3EAF600", VA = "0x183EB0A00")]
	public void LLELCMMKHDC([Out] T IIPLJLPCLBC, [Out] int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0550", Offset = "0x3EAF150", VA = "0x183EB0550")]
	public (T, int) LCDCEHFLLOI()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF830", Offset = "0x3EAE430", VA = "0x183EAF830", Slot = "5")]
	private bool EOKOAGGEJPH([In] IKJPLMFPOOE<T> HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MBPCABLPOJC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C37A70", Offset = "0x2C36670", VA = "0x182C37A70")]
	public static IKJPLMFPOOE<T> FCDPFGJNKNI<T>([In] T IIPLJLPCLBC, int BAEBMIBABAE) where T : notnull
	{
		return default(IKJPLMFPOOE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AFOMFJLOJJE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x31EBA00", Offset = "0x31EA600", VA = "0x1831EBA00")]
	public static bool JLOLPFEAPBE<T, U>([In] T ENEDBNLKLJL, [In] U APKAFMDACKK) where T : notnull, BLAHLINOAIB<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult OLHMLKNBOEC<T, out TResult>([In] T OKLJLMJMKDA);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OMCDEIKGPAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan NCDFMEFCOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? GGCOOJGHEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBAJJELMFPM();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOLLOFJFPDL();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJFADHOCDFA();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct GCALLIFKLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KHDFHFFIAGL JJJPJLHCGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly CDDCJCLGPNF OJPGPAOMLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly KHDFHFFIAGL EOCPCEEGOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly CDDCJCLGPNF ONFNGBPJBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KHDFHFFIAGL IIGCINGKHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly CDDCJCLGPNF MPDLDFKFGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly MDGCEPGAPNI HOAHECJFDKH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KHDFHFFIAGL NAGAHMDNMPG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly CDDCJCLGPNF IDIJKJMINAI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KHDFHFFIAGL JKKNOCICAMG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly CDDCJCLGPNF DOKIJLFAKNM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KHDFHFFIAGL OMNFOMJLLIJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly CDDCJCLGPNF IFPOHHEIADL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MDGCEPGAPNI KEHNJMADKKD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly GCALLIFKLKK ECELLENMKJP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KHDFHFFIAGL KGLDONEELDO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A99B70", Offset = "0x6A98770", VA = "0x186A99B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xB38110", Offset = "0xB36D10", VA = "0x180B38110")]
	public GCALLIFKLKK(KHDFHFFIAGL MPIAIBBLBFC, CDDCJCLGPNF AFJABDCOJBA, KHDFHFFIAGL EHJCKKDFPJM, CDDCJCLGPNF HIGHFLHEJPN, KHDFHFFIAGL OAEMBBLLPCM, CDDCJCLGPNF LADBMMLBCIH, MDGCEPGAPNI KOPDGHHOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	private static bool MFJIGHEPNNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void ELGGPLKHCPK(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	private static bool MJHCNPLLBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void EGEHAODFLBN(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	private static bool OMGDHDFJHAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void IFMLIJHMJBC(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void BGHCFLAIHOA(Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A99D70", Offset = "0x6A98970", VA = "0x186A99D70")]
	private static GCALLIFKLKK GJGLMCGNGCG()
	{
		return default(GCALLIFKLKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80")]
	private static bool DPDODGFBALK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A99EB0", Offset = "0x6A98AB0", VA = "0x186A99EB0")]
	public void IOIJAALEDGI(object NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A99FF0", Offset = "0x6A98BF0", VA = "0x186A99FF0")]
	public void PAHNJPDDDAB(object NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1C01FC0", Offset = "0x1C00BC0", VA = "0x181C01FC0")]
	public void DALJONHLFMH(Exception GKFNJIBGPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A060", Offset = "0x6A98C60", VA = "0x186A9A060")]
	public void PAHNJPDDDAB(OJJEHOCCNEF NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B28B80", Offset = "0x2B27780", VA = "0x182B28B80")]
	public void PAHNJPDDDAB<T>(T OKLJLMJMKDA, PADFELPKKKE<T> NKAJDDICLFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B28840", Offset = "0x2B27440", VA = "0x182B28840")]
	public void IOIJAALEDGI<T>([In] T OKLJLMJMKDA, KAFKOIGLHBO<T> NKAJDDICLFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B289E0", Offset = "0x2B275E0", VA = "0x182B289E0")]
	public void PAHNJPDDDAB<T>([In] T OKLJLMJMKDA, KAFKOIGLHBO<T> NKAJDDICLFH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A99F20", Offset = "0x6A98B20", VA = "0x186A99F20")]
	public bool LAEDGFLAGKA(bool FFGGIJJLJGP, string NKAJDDICLFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AIEKDGCGBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string JCMGPEFMEMP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	public AIEKDGCGBEF(string IIPLJLPCLBC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80")]
	public static string ANHILFPCAJJ([In] AIEKDGCGBEF ENEDBNLKLJL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x998E40", Offset = "0x997A40", VA = "0x180998E40")]
	public static AIEKDGCGBEF ANHILFPCAJJ(string HEIGABGMPLJ)
	{
		return default(AIEKDGCGBEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A97BD0", Offset = "0x6A967D0", VA = "0x186A97BD0")]
	public string GGGKDAGJAID(string HLKAGGPABAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A97C20", Offset = "0x6A96820", VA = "0x186A97C20")]
	public string GNKDGPDEKPE(object LJLIEJDMMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct HGAAMJINHPI : IEquatable<HGAAMJINHPI>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "4")]
	public bool Equals(HGAAMJINHPI HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BEE0", Offset = "0x6A9AAE0", VA = "0x186A9BEE0", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BF30", Offset = "0x6A9AB30", VA = "0x186A9BF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BF40", Offset = "0x6A9AB40", VA = "0x186A9BF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[ENAFOIIGLJJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FLLFKKECNDP<T> : IEquatable<FLLFKKECNDP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T JCMGPEFMEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool OHOIOBKNMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool EGBBCGMBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C287B0", Offset = "0x3C273B0", VA = "0x183C287B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3C299B0", Offset = "0x3C285B0", VA = "0x183C299B0")]
	public FLLFKKECNDP([In] T IIPLJLPCLBC, bool MAOOCKPMCCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3C292A0", Offset = "0x3C27EA0", VA = "0x183C292A0")]
	public static bool IGDKJEPDLHP([In] FLLFKKECNDP<T> HDIFBMODGOB, [In] FLLFKKECNDP<T> ADFEKOHGOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3C28AD0", Offset = "0x3C276D0", VA = "0x183C28AD0", Slot = "4")]
	public bool Equals(FLLFKKECNDP<T> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C28950", Offset = "0x3C27550", VA = "0x183C28950", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C29200", Offset = "0x3C27E00", VA = "0x183C29200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3C298F0", Offset = "0x3C284F0", VA = "0x183C298F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HKJFMNNEPGB
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B3A0", Offset = "0x2B59FA0", VA = "0x182B5B3A0")]
	public static FLLFKKECNDP<T> EHCLJBGJDLG<T>([In] T IIPLJLPCLBC) where T : notnull
	{
		return default(FLLFKKECNDP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B260", Offset = "0x2B59E60", VA = "0x182B5B260")]
	public static FLLFKKECNDP<T?> DDFDPFDDMDC<T>()
	{
		return default(FLLFKKECNDP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B4A0", Offset = "0x2B5A0A0", VA = "0x182B5B4A0")]
	public static bool MPCBHMHJBLP<T>([In] this FLLFKKECNDP<T> IKGJGODMIIC, [Out][NotNullWhen(true)] T IIPLJLPCLBC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct PJIPAIPEOMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr OIEMIIFBKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr JENHGMFBKLK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr MNAGGIGAAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr IALAJPLIELH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly PJIPAIPEOMG ECELLENMKJP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IEKHLJNNNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2910", Offset = "0x6AA1510", VA = "0x186AA2910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
	public PJIPAIPEOMG(IntPtr KKMHLPFPKLK, IntPtr IMEJMAHJOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void PEIJLAGAIJH(string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void DIOIIOGHGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AA29F0", Offset = "0x6AA15F0", VA = "0x186AA29F0")]
	private static PJIPAIPEOMG GJGLMCGNGCG()
	{
		return default(PJIPAIPEOMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct IOONEPNOAJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr JCKOOLFKMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9403F0", Offset = "0x93EFF0", VA = "0x1809403F0")]
	private IOONEPNOAJH(IntPtr IMEJMAHJOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C5E0", Offset = "0x6A9B1E0", VA = "0x186A9C5E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C600", Offset = "0x6A9B200", VA = "0x186A9C600")]
	public static IOONEPNOAJH FCDPFGJNKNI(string LONKACOOPGJ)
	{
		return default(IOONEPNOAJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1FD04B0", Offset = "0x1FCF0B0", VA = "0x181FD04B0")]
	public static IOONEPNOAJH FCDPFGJNKNI([In] PJIPAIPEOMG NFPOPOPADII, string LONKACOOPGJ)
	{
		return default(IOONEPNOAJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD0570", Offset = "0x1FCF170", VA = "0x181FD0570")]
	public static IOONEPNOAJH FCDPFGJNKNI([In] PJIPAIPEOMG NFPOPOPADII, Func<string> LONKACOOPGJ)
	{
		return default(IOONEPNOAJH);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LOIIDLPHPAB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate bool GMGMBALGOKE<in TInput, TResult>(TInput NGMMAKENIFG, [Out] TResult KKIOBLFFGJH);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class PPALHCKDFHM : EBHGDBGFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class DCDOAODCNOI : NCIEKADKHCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly DCDOAODCNOI NKKNEDDGFMP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool DLJHKCAJIEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6A97EF0", Offset = "0x6A96AF0", VA = "0x186A97EF0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A97F50", Offset = "0x6A96B50", VA = "0x186A97F50", Slot = "6")]
			public void OnCompleted(Action BKLNENHCFCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			public void HEACIAHFIKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public DCDOAODCNOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly PPALHCKDFHM NKKNEDDGFMP;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		private PPALHCKDFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2BD0", Offset = "0x6AA17D0", VA = "0x186AA2BD0", Slot = "4")]
		public NCIEKADKHCM GBDFPBKCPFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private sealed class NAINCIPBEDI : EBHGDBGFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class FKJIEHFILHD : NCIEKADKHCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly FKJIEHFILHD NKKNEDDGFMP;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool DLJHKCAJIEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6A995A0", Offset = "0x6A981A0", VA = "0x186A995A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6A995C0", Offset = "0x6A981C0", VA = "0x186A995C0", Slot = "6")]
			public void OnCompleted(Action BKLNENHCFCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
			public void HEACIAHFIKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public FKJIEHFILHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly NAINCIPBEDI NKKNEDDGFMP;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		private NAINCIPBEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AA10A0", Offset = "0x6A9FCA0", VA = "0x186AA10A0", Slot = "4")]
		public NCIEKADKHCM GBDFPBKCPFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DOKHIFNIMHK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public DOKHIFNIMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3856440", Offset = "0x3855040", VA = "0x183856440")]
		internal void CHCFNHHDOPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DLKFCIDKGGP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public DLKFCIDKGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D36500", Offset = "0x3D35100", VA = "0x183D36500")]
		internal void FIKEMEAEDFO(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MPFJJEIKIKJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6AA0F40", Offset = "0x6A9FB40", VA = "0x186AA0F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BKAAINMGLKM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A97DE0", Offset = "0x6A969E0", VA = "0x186A97DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HEPPAKIHDAM<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x3DB7190", Offset = "0x3DB5D90", VA = "0x183DB7190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DB7300", Offset = "0x3DB5F00", VA = "0x183DB7300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NNMODNKDJHN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4537560", Offset = "0x4536160", VA = "0x184537560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4537DF0", Offset = "0x45369F0", VA = "0x184537DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct KOFMFJGPJLH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9CEC0", Offset = "0x6A9BAC0", VA = "0x186A9CEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D0C0", Offset = "0x6A9BCC0", VA = "0x186A9D0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ENJEFIHMOLC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ENJEFIHMOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3856440", Offset = "0x3855040", VA = "0x183856440")]
		internal void DAOHDLLCKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38564B0", Offset = "0x38550B0", VA = "0x1838564B0")]
		internal void NNILAEEBKCP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct PPJGKCPPBMM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public GMGMBALGOKE<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x47AD8C0", Offset = "0x47AC4C0", VA = "0x1847AD8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x47AE030", Offset = "0x47ACC30", VA = "0x1847AE030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MOGLLDODKAM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6AA06F0", Offset = "0x6A9F2F0", VA = "0x186AA06F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0EE0", Offset = "0x6A9FAE0", VA = "0x186AA0EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct DLOPCCIFIKH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A983A0", Offset = "0x6A96FA0", VA = "0x186A983A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6A988E0", Offset = "0x6A974E0", VA = "0x186A988E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FCNMIALHFEA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3C00CD0", Offset = "0x3BFF8D0", VA = "0x183C00CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C014D0", Offset = "0x3C000D0", VA = "0x183C014D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PJHDICLDOBE<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x47977F0", Offset = "0x47963F0", VA = "0x1847977F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x357A250", Offset = "0x3578E50", VA = "0x18357A250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct AFBPOHHKPMB<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3CEEA90", Offset = "0x3CED690", VA = "0x183CEEA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF1E0", Offset = "0x3CEDDE0", VA = "0x183CEF1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DKODBIJHDAL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A98160", Offset = "0x6A96D60", VA = "0x186A98160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A98340", Offset = "0x6A96F40", VA = "0x186A98340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EGDCICHNCLP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A98C00", Offset = "0x6A97800", VA = "0x186A98C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A98F70", Offset = "0x6A97B70", VA = "0x186A98F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GANGOOAANOI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A99820", Offset = "0x6A98420", VA = "0x186A99820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A99B10", Offset = "0x6A98710", VA = "0x186A99B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FPLCALIBMBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public FPLCALIBMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A997B0", Offset = "0x6A983B0", VA = "0x186A997B0")]
		internal Task BHLNJJFAPGP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EFKHPBLFOGP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A98940", Offset = "0x6A97540", VA = "0x186A98940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A98BA0", Offset = "0x6A977A0", VA = "0x186A98BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct LANCIPCHMNJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9D1A0", Offset = "0x6A9BDA0", VA = "0x186A9D1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D380", Offset = "0x6A9BF80", VA = "0x186A9D380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GCBHDHDEOIF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9A720", Offset = "0x6A99320", VA = "0x186A9A720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AA90", Offset = "0x6A99690", VA = "0x186A9AA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MDFJBEJBMHB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9F220", Offset = "0x6A9DE20", VA = "0x186A9F220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F510", Offset = "0x6A9E110", VA = "0x186A9F510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class KPDKKFFICLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KPDKKFFICLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D130", Offset = "0x6A9BD30", VA = "0x186A9D130")]
		internal Task LOBPMKIEEKD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JOADIMFONKE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9C700", Offset = "0x6A9B300", VA = "0x186A9C700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C960", Offset = "0x6A9B560", VA = "0x186A9C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct KAOECBPFCFG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9CCE0", Offset = "0x6A9B8E0", VA = "0x186A9CCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CE60", Offset = "0x6A9BA60", VA = "0x186A9CE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BFMHIBMPNAM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E6A0A0", Offset = "0x4E68CA0", VA = "0x184E6A0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A320", Offset = "0x4E68F20", VA = "0x184E6A320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ABICOMCAGDA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A97770", Offset = "0x6A96370", VA = "0x186A97770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6A97B70", Offset = "0x6A96770", VA = "0x186A97B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? AENBGCHBMDE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<HGAAMJINHPI> JINPMLCNNEN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task AMDILHNHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EBE0", Offset = "0x6A9D7E0", VA = "0x186A9EBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E320", Offset = "0x6A9CF20", VA = "0x186A9E320")]
	public static bool HLOFMLLFGJG(this Task LJPOAIPEHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C19D20", Offset = "0x2C18920", VA = "0x182C19D20")]
	public static Task<T> GIHKMNFAAFM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E550", Offset = "0x6A9D150", VA = "0x186A9E550")]
	public static Task IILNDHGIMBB(this Task LJPOAIPEHGB, CancellationToken GBENACPKFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BA40", Offset = "0x2C1A640", VA = "0x182C1BA40")]
	public static Task<TResult> IILNDHGIMBB<TResult>(this Task<TResult> LJPOAIPEHGB, CancellationToken GBENACPKFNA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CCE0", Offset = "0x2C1B8E0", VA = "0x182C1CCE0")]
	public static TaskCompletionSource<TResult> IILNDHGIMBB<TResult>(this TaskCompletionSource<TResult> BIIFJEGEEHG, CancellationToken GBENACPKFNA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D830", Offset = "0x6A9C430", VA = "0x186A9D830")]
	public static IDisposable? DEOEBJMNGMK(CancellationToken IIBDNJICIDN, CancellationToken KFENOOPAPHB, [Out] CancellationToken MOCBGAKJHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EC50", Offset = "0x6A9D850", VA = "0x186A9EC50")]
	[AsyncStateMachine(typeof(MPFJJEIKIKJ))]
	public static void MDLCEGICHOG(this Task GLMCDBEDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A9F0B0", Offset = "0x6A9DCB0", VA = "0x186A9F0B0")]
	[AsyncStateMachine(typeof(BKAAINMGLKM))]
	public static void PPIGLHIMGIK(this Task GLMCDBEDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D760", Offset = "0x2C1C360", VA = "0x182C1D760")]
	[AsyncStateMachine(typeof(HEPPAKIHDAM<>))]
	public static Task LBCMEFLEMGO<TException>(this Task GLMCDBEDNLG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C19590", Offset = "0x2C18190", VA = "0x182C19590")]
	[AsyncStateMachine(typeof(NNMODNKDJHN<>))]
	public static Task<T> CFCCCKHCOIE<T>(this Task<T> ENEDBNLKLJL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A9ED00", Offset = "0x6A9D900", VA = "0x186A9ED00")]
	[AsyncStateMachine(typeof(KOFMFJGPJLH))]
	public static Task<TaskStatus> OFHAIOINDAN(this Task ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D830", Offset = "0x2C1C430", VA = "0x182C1D830")]
	public static (Task<T?>?, Action<T?>?) PKHDMFOLPED<T>([Optional] CancellationToken PPKBAEMFIMG)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C19C10", Offset = "0x2C18810", VA = "0x182C19C10")]
	[AsyncStateMachine(typeof(PPJGKCPPBMM<, >))]
	public static Task<List<TResult>> GBNABLCCCCP<TResult, TInput>(this Task<List<TInput>> LJPOAIPEHGB, GMGMBALGOKE<TInput, TResult> CFCJHJFMPCF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D700", Offset = "0x6A9C300", VA = "0x186A9D700")]
	[AsyncStateMachine(typeof(MOGLLDODKAM))]
	public static Task BPMOPNKGCFP(Task GLMCDBEDNLG, CancellationToken OADLPMIOAJN, Func<CancellationToken, Task> CNKCJFJBPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E350", Offset = "0x6A9CF50", VA = "0x186A9E350")]
	[AsyncStateMachine(typeof(DLOPCCIFIKH))]
	public static Task IAKLBNDHPGA(Func<CancellationToken, Task> AAKBHKDBNEK, TimeSpan PLJAGHNHKBC, [Optional] CancellationToken OADLPMIOAJN, [Optional] Action<OperationCanceledException>? IFDGFELFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2C19EA0", Offset = "0x2C18AA0", VA = "0x182C19EA0")]
	[AsyncStateMachine(typeof(FCNMIALHFEA<>))]
	public static Task<T> IAKLBNDHPGA<T>(Func<CancellationToken, Task<T>> AAKBHKDBNEK, TimeSpan PLJAGHNHKBC, [Optional] CancellationToken OADLPMIOAJN, [Optional] Func<OperationCanceledException, T>? IFDGFELFHHF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2C19860", Offset = "0x2C18460", VA = "0x182C19860")]
	[AsyncStateMachine(typeof(PJHDICLDOBE<>))]
	public static Task<IEnumerable<Task<T>>> DJHEDFLEADI<T>(IEnumerable<Task<T>> HELKBMDEOKP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2C19950", Offset = "0x2C18550", VA = "0x182C19950")]
	[AsyncStateMachine(typeof(AFBPOHHKPMB<, , , >))]
	public static Task<(T1, T2, T3, T4)> GBIOFACMINP<T1, T2, T3, T4>(Task<T1> NFHMBKLADEO, Task<T2> CMEIKJAJDFI, Task<T3> LOALFHFMJLK, Task<T4> ILLONLGLNIL) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D610", Offset = "0x6A9C210", VA = "0x186A9D610")]
	[AsyncStateMachine(typeof(DKODBIJHDAL))]
	public static Task AEIDMGAALGG(Func<bool> FFGGIJJLJGP, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D500", Offset = "0x6A9C100", VA = "0x186A9D500")]
	[AsyncStateMachine(typeof(EGDCICHNCLP))]
	public static Task AEIDMGAALGG(Func<bool> FFGGIJJLJGP, TimeSpan HJNMMLDGKKF, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E880", Offset = "0x6A9D480", VA = "0x186A9E880")]
	[AsyncStateMachine(typeof(GANGOOAANOI))]
	public static Task JGJCFHBPNOD(Func<bool> FFGGIJJLJGP, TimeSpan PLJAGHNHKBC, [Optional] CancellationToken PPKBAEMFIMG, [Optional] Action<OperationCanceledException>? IFDGFELFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E9B0", Offset = "0x6A9D5B0", VA = "0x186A9E9B0")]
	[AsyncStateMachine(typeof(EFKHPBLFOGP))]
	public static Task JGJCFHBPNOD(Func<bool> FFGGIJJLJGP, TimeSpan PLJAGHNHKBC, TimeSpan HJNMMLDGKKF, [Optional] CancellationToken PPKBAEMFIMG, [Optional] Action<OperationCanceledException>? IFDGFELFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D970", Offset = "0x6A9C570", VA = "0x186A9D970")]
	[AsyncStateMachine(typeof(LANCIPCHMNJ))]
	public static Task EFAMNPIMHNC(Func<bool> FFGGIJJLJGP, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DA60", Offset = "0x6A9C660", VA = "0x186A9DA60")]
	[AsyncStateMachine(typeof(GCBHDHDEOIF))]
	public static Task EFAMNPIMHNC(Func<bool> FFGGIJJLJGP, TimeSpan HJNMMLDGKKF, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EF80", Offset = "0x6A9DB80", VA = "0x186A9EF80")]
	[AsyncStateMachine(typeof(MDFJBEJBMHB))]
	public static Task PNIMFGBBDII(Func<bool> FFGGIJJLJGP, TimeSpan PLJAGHNHKBC, [Optional] CancellationToken PPKBAEMFIMG, [Optional] Action<OperationCanceledException>? IFDGFELFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EE40", Offset = "0x6A9DA40", VA = "0x186A9EE40")]
	[AsyncStateMachine(typeof(JOADIMFONKE))]
	public static Task PNIMFGBBDII(Func<bool> FFGGIJJLJGP, TimeSpan PLJAGHNHKBC, TimeSpan HJNMMLDGKKF, [Optional] CancellationToken PPKBAEMFIMG, [Optional] Action<OperationCanceledException>? IFDGFELFHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EAF0", Offset = "0x6A9D6F0", VA = "0x186A9EAF0")]
	[AsyncStateMachine(typeof(KAOECBPFCFG))]
	[Obsolete]
	public static Task JHFOLPJGPIC(this Task LJPOAIPEHGB, Action INMJBELNALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D670", Offset = "0x2C1C270", VA = "0x182C1D670")]
	[Obsolete]
	[AsyncStateMachine(typeof(BFMHIBMPNAM<>))]
	public static Task JHFOLPJGPIC<T>(this Task<T> LJPOAIPEHGB, Action<T> INMJBELNALG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DB70", Offset = "0x6A9C770", VA = "0x186A9DB70")]
	private static void EMKDDCHEGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DFA0", Offset = "0x6A9CBA0", VA = "0x186A9DFA0")]
	public static bool HDCAPIKFKIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DE10", Offset = "0x6A9CA10", VA = "0x186A9DE10")]
	private static void FNEPJOKPJDL(SynchronizationContext IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DCF0", Offset = "0x6A9C8F0", VA = "0x186A9DCF0")]
	private static void FMFDHPIONGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DC20", Offset = "0x6A9C820", VA = "0x186A9DC20")]
	public static void FIKCNDHACKH([Optional] string? NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E7B0", Offset = "0x6A9D3B0", VA = "0x186A9E7B0")]
	public static void JAGFGNIIJMG([Optional] string? NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A9EDF0", Offset = "0x6A9D9F0", VA = "0x186A9EDF0")]
	public static EBHGDBGFMPE OJAAMEPLLDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E830", Offset = "0x6A9D430", VA = "0x186A9E830")]
	public static EBHGDBGFMPE JCBOGKMJEHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E480", Offset = "0x6A9D080", VA = "0x186A9E480")]
	[AsyncStateMachine(typeof(ABICOMCAGDA))]
	public static Task IHAHNIBGNFL(Func<Task> FKJLAAGOMNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OCDDNNLBGPA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
	public OCDDNNLBGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class FMFEEOFGNGA : KLEGFBIPAPD
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly KLEGFBIPAPD NKKNEDDGFMP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime HJDMDNEHPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A99690", Offset = "0x6A98290", VA = "0x186A99690", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset PLNEIAEJMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A996D0", Offset = "0x6A982D0", VA = "0x186A996D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public FMFEEOFGNGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KLEGFBIPAPD
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime HJDMDNEHPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset PLNEIAEJMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class MJGOFLPEBDG
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long OBFJOHOMJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FED0", Offset = "0x6A9EAD0", VA = "0x186A9FED0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long CLFKAJLJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FF20", Offset = "0x6A9EB20", VA = "0x186A9FF20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double FFDCMKEFJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA00A0", Offset = "0x6A9ECA0", VA = "0x186AA00A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double AIBALGAHOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0000", Offset = "0x6A9EC00", VA = "0x186AA0000")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MAAKABJOBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0050", Offset = "0x6A9EC50", VA = "0x186AA0050")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double JABKAIBLPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0210", Offset = "0x6A9EE10", VA = "0x186AA0210")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6AA00F0", Offset = "0x6A9ECF0", VA = "0x186AA00F0")]
	public static double IIOOFLAJPFB(long APHDMHEHGKG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0180", Offset = "0x6A9ED80", VA = "0x186AA0180")]
	public static double LCAJJMLABKK(long APHDMHEHGKG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0260", Offset = "0x6A9EE60", VA = "0x186AA0260")]
	public static double NDBJPNEACFP(double HFLKHLIAKJA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FF70", Offset = "0x6A9EB70", VA = "0x186A9FF70")]
	public static long EBBGDDFNOID(long JACNKEDDJOJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A9FEC0", Offset = "0x6A9EAC0", VA = "0x186A9FEC0")]
	public static long BLFIAPEENCP(long NCLKGLFBOGL, long PIHDLOFFHGM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0350", Offset = "0x6A9EF50", VA = "0x186AA0350")]
	public static double PIPNBAILNMN(long NCLKGLFBOGL, long PIHDLOFFHGM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AA02F0", Offset = "0x6A9EEF0", VA = "0x186AA02F0")]
	public static double NDMNEKANCBP(long NCLKGLFBOGL, long PIHDLOFFHGM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class NGPAOLPBOOG : OMCDEIKGPAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan GICIDFKIIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer IFGCIHPEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan PLJAGHNHKBC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan NCDFMEFCOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA14E0", Offset = "0x6AA00E0", VA = "0x186AA14E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? GGCOOJGHEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA16B0", Offset = "0x6AA02B0", VA = "0x186AA16B0")]
	[Preserve]
	public NGPAOLPBOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1720", Offset = "0x6AA0320", VA = "0x186AA1720")]
	public NGPAOLPBOOG(TimeSpan PLJAGHNHKBC, [Optional] Action? HFMNNBMDFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1270", Offset = "0x6A9FE70", VA = "0x186AA1270", Slot = "7")]
	public void CBAJJELMFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1470", Offset = "0x6AA0070", VA = "0x186AA1470", Slot = "8")]
	public void IOLLOFJFPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1440", Offset = "0x6AA0040", VA = "0x186AA1440", Slot = "9")]
	public void EJFADHOCDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x94E8F0", Offset = "0x94D4F0", VA = "0x18094E8F0")]
	private void JHOPDMFAMAD(object LDAADCAOFLJ, ElapsedEventArgs IJKHNDCFNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1300", Offset = "0x6A9FF00", VA = "0x186AA1300")]
	private static void DDHJEKIBJBP(TimeSpan LKNCPKFNKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AA13A0", Offset = "0x6A9FFA0", VA = "0x186AA13A0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ENAFOIIGLJJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? KKHBCJDPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string DILEEBNHJBI;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1D23FF0", Offset = "0x1D22BF0", VA = "0x181D23FF0")]
	public ENAFOIIGLJJ(string JCKPDENNIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E380", Offset = "0x3D2CF80", VA = "0x183D2E380")]
	public ENAFOIIGLJJ(string OKKJFMBNHDK, string JCKPDENNIBJ)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OBHAAEALFBF : IEquatable<OBHAAEALFBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint PEKBJMGLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int BJBGKAFHJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float FEBHMJBBFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort MKPHPEKJLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort IKGOJGCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short PFNEECOHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short KHAIEIDNHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char MBJPAPALHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char LCKLAPGIDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte ABFOIBJNHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte ONOGNDFEEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte PKPIHKNHKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte NNDCMKMFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool GGMGNGCGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool HICICFPPLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool MNKPDLCAOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool BHMCNNAOICE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE23BB0", VA = "0x180E24FB0")]
	public static OBHAAEALFBF NLPOFMOADHJ(uint IEFIEMDAJHE)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE23BB0", VA = "0x180E24FB0")]
	public static OBHAAEALFBF AEHEOPGLIFO(int CCEKDLFPICE)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1A10", Offset = "0x6AA0610", VA = "0x186AA1A10")]
	public static OBHAAEALFBF ECFMFAPAKFH(float OBCPCFEEKNK)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA19F0", Offset = "0x6AA05F0", VA = "0x186AA19F0")]
	public static OBHAAEALFBF DMOGCGEOEND(byte EPBMCOCDDJI, byte NJCMNAGBEJM, byte DDNANOIMINM, byte ONGOAHJIHEK)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA19F0", Offset = "0x6AA05F0", VA = "0x186AA19F0")]
	public static OBHAAEALFBF BOOBGFNIONO(bool MCMCGGGDIAI, bool CDMDBNNKBMO, bool CJLBOCDLLKM, bool LFPJKIIKGHD)
	{
		return default(OBHAAEALFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA19F0", Offset = "0x6AA05F0", VA = "0x186AA19F0")]
	public static OBHAAEALFBF PDKCCLGNHHF(byte ODODEMIFPMJ, byte BOIHMOBLDML, byte DNAMKBDENEP, byte HHHIGDPCMAO)
	{
		return default(OBHAAEALFBF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1A90BD0", Offset = "0x1A8F7D0", VA = "0x181A90BD0")]
	public static bool IGDKJEPDLHP(OBHAAEALFBF HFIDNJCGLJB, OBHAAEALFBF MGPFNHKFBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA07AD0", Offset = "0xA066D0", VA = "0x180A07AD0", Slot = "4")]
	public bool Equals(OBHAAEALFBF HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1A20", Offset = "0x6AA0620", VA = "0x186AA1A20", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xAC3770", Offset = "0xAC2370", VA = "0x180AC3770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1AB0", Offset = "0x6AA06B0", VA = "0x186AA1AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct AAAMPIDPCDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong DDJPMDDMHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long MFGDLHFCLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double ICEFAONNBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint MLHOBEBGFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint CPMKKPPJIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int OIFNFGGLNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int PIOLEDFOJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float MPMNEKLGALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float AIPCNOKIJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort MKPHPEKJLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort IKGOJGCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort LMMACDOPHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort LMBGAGAIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short PFNEECOHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short KHAIEIDNHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short EAPOELFBOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short DFFLBCEJAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char MBJPAPALHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char LCKLAPGIDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char JGLNDHDINCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char HDDDIGOAIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte ABFOIBJNHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte ONOGNDFEEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte PKPIHKNHKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NNDCMKMFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte IIMDMOODGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte MCKFOFFOMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte GIOIKKAKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte NDNOGEKODCE;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A97720", Offset = "0x6A96320", VA = "0x186A97720")]
	public static AAAMPIDPCDL FCDPFGJNKNI(byte EPBMCOCDDJI, byte NJCMNAGBEJM, byte DDNANOIMINM, byte ONGOAHJIHEK, byte EGBCMOHHHMG, byte FGOBEJLKINM, byte KKLIDFMKEPK, byte FPJPKEKGAHJ)
	{
		return default(AAAMPIDPCDL);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KABAMPMIAFP : IEquatable<KABAMPMIAFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte CHDJHKMIAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool BJDBEFJNGAC;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2595AE0", Offset = "0x25946E0", VA = "0x182595AE0")]
	public static KABAMPMIAFP DMOGCGEOEND(byte BBIAOKENPOK)
	{
		return default(KABAMPMIAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2595AE0", Offset = "0x25946E0", VA = "0x182595AE0")]
	public static KABAMPMIAFP BOOBGFNIONO(bool CNBMKFDCNCM)
	{
		return default(KABAMPMIAFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA60", Offset = "0x6A9B660", VA = "0x186A9CA60")]
	public static bool IGDKJEPDLHP(KABAMPMIAFP HFIDNJCGLJB, KABAMPMIAFP MGPFNHKFBHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5C37F00", Offset = "0x5C36B00", VA = "0x185C37F00", Slot = "4")]
	public bool Equals(KABAMPMIAFP HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C9C0", Offset = "0x6A9B5C0", VA = "0x186A9C9C0", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA50", Offset = "0x6A9B650", VA = "0x186A9CA50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA70", Offset = "0x6A9B670", VA = "0x186A9CA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NKNJOIMCLNG<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T NGOGFMIDGHH;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4521830", Offset = "0x4520430", VA = "0x184521830")]
	public NKNJOIMCLNG(T NLJNPBCMHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MAFOPABGJGE
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CD70", Offset = "0x2C2B970", VA = "0x182C2CD70")]
	public static IEnumerable<T> LNPEJFEGGPN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static T[] EIDEGHEOJEL<T>(params T[] NFMGKNJCJIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static IEnumerable<T> JFHHOGKDLKE<T>(params T[] NFMGKNJCJIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static HashSet<T> KGGHHCHDCON<T>(params T[] NFMGKNJCJIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CDA0", Offset = "0x2C2B9A0", VA = "0x182C2CDA0")]
	public static KeyValuePair<TKey, TValue> MNNLNOLGAJB<TKey, TValue>([In] TKey NCMHANGAILD, [In] TValue IIPLJLPCLBC) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static List<T> AMEGNLKFJJJ<T>(IEnumerable<T> JMDINDKMKCB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.All)]
public sealed class GKMJNCLPKFM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string HPDPBGIOAFC;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
	public GKMJNCLPKFM(string BIAIEKINDGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate object KAFKOIGLHBO<T>([In] T OHIOFOHNMPI);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object PADFELPKKKE<T>(T OHIOFOHNMPI);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[FAKEPOPLBLE]
public delegate string NFFFEMBCNLL(string GBJCJEFDEPC, string? LOLFBCCGJCN, bool OBDBGBGDKMN);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[FAKEPOPLBLE]
public delegate void CDDCJCLGPNF(string NKAJDDICLFH);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[FAKEPOPLBLE]
public delegate void MDGCEPGAPNI(Exception GKFNJIBGPDM);
[Cpp2IlInjected.Token(Token = "0x200005C")]
public delegate object OJJEHOCCNEF();
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FAKEPOPLBLE]
public delegate bool KHDFHFFIAGL();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[FAKEPOPLBLE]
public delegate string HDPIHMGKADK(object APKAFMDACKK);
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.Enum)]
public class OLGEPIFFAOJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
	public OLGEPIFFAOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class IGNJPEGOOFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct MEDHKPCKILF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F570", Offset = "0x6A9E170", VA = "0x186A9F570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FE50", Offset = "0x6A9EA50", VA = "0x186A9FE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback OKIOOFGIPAC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> ENNFIOJNEDK;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C0A0", Offset = "0x6A9ACA0", VA = "0x186A9C0A0")]
	public static Task<bool> LJBPMFKPAEN(int INOGJIABCIB, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BF70", Offset = "0x6A9AB70", VA = "0x186A9BF70")]
	[AsyncStateMachine(typeof(MEDHKPCKILF))]
	private static Task<bool> AAPGCJOMNOJ(int INOGJIABCIB, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C3B0", Offset = "0x6A9AFB0", VA = "0x186A9C3B0")]
	private static void MAPLFNGDPKC(object? FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C440", Offset = "0x6A9B040", VA = "0x186A9C440")]
	private static void OKELNCJEMKB(object? FFBJIDDDHKC)
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
