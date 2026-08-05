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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D53A40", Offset = "0x5D52240", VA = "0x185D53A40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class KILELLKJFKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D513C0", Offset = "0x5D4FBC0", VA = "0x185D513C0")]
	public KILELLKJFKC(bool IELBACCCKDL, string AFPGEGBCOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KMFNEALMHID<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> MELJLEHCINK(CancellationToken EHCFBFBFEDH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CPIDIPKBBEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KMFNEALMHID<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MELJLEHCINK taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4B7D2C0", Offset = "0x4B7BAC0", VA = "0x184B7D2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E300", Offset = "0x4B7CB00", VA = "0x184B7E300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource PDCJAGPLKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? MLHDMGIFEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? JCOLIONIIDN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3881A40", Offset = "0x3880240", VA = "0x183881A40")]
	[AsyncStateMachine(typeof(KMFNEALMHID<>.CPIDIPKBBEB))]
	public Task<TResult> FJLNILPLFNH(MELJLEHCINK DHBKMEAHDIE, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38819D0", Offset = "0x38801D0", VA = "0x1838819D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3881B80", Offset = "0x3880380", VA = "0x183881B80")]
	public KMFNEALMHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DDODKHGFGBM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> OOPAHJKJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T PENMJFOMGMH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x355A3D0", Offset = "0x3558BD0", VA = "0x18355A3D0")]
	public DDODKHGFGBM([In] T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D124C0", Offset = "0x4D10CC0", VA = "0x184D124C0", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D12860", Offset = "0x4D11060", VA = "0x184D12860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D128C0", Offset = "0x4D110C0", VA = "0x184D128C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class PILKFHLEGFC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	public PILKFHLEGFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class NPPCPPENLBO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	public NPPCPPENLBO(string MPMMNGFJNGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class KGAPKIFELOG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	public KGAPKIFELOG(string MPMMNGFJNGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DCCKCJEKALE
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2210080", Offset = "0x220E880", VA = "0x182210080")]
	public static LDBKIJLONIH GHGCNEMFNME<T>()
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22103A0", Offset = "0x220EBA0", VA = "0x1822103A0")]
	public static LDBKIJLONIH LNGENGPDCFE<T>([CallerMemberName] string HNHMJGCODBA = "") where T : notnull
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2210100", Offset = "0x220E900", VA = "0x182210100")]
	public static LDBKIJLONIH GHGCNEMFNME<T>(this T EANKMFHELBA) where T : notnull
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2210180", Offset = "0x220E980", VA = "0x182210180")]
	public static LDBKIJLONIH KHPLMNAGGMJ<T>(this T EANKMFHELBA, [CallerMemberName] string HNHMJGCODBA = "") where T : notnull
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2210300", Offset = "0x220EB00", VA = "0x182210300")]
	public static LDBKIJLONIH LNGENGPDCFE<T>(this T AFFJMIFONEM, [CallerMemberName] string HNHMJGCODBA = "") where T : notnull
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D507C0", Offset = "0x5D4EFC0", VA = "0x185D507C0")]
	public static LDBKIJLONIH LNGENGPDCFE(string EODIHJEJFDF, [CallerMemberName] string HNHMJGCODBA = "")
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D50720", Offset = "0x5D4EF20", VA = "0x185D50720")]
	public static string CEEOFHEPFCN(this object AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PILKFHLEGFC]
public delegate long LKCFNENGEJK();
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDBPACJOAFE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static CJGJKDLDHCD CCIPJJNCCCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CJGJKDLDHCD IJIFJJLFOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D50F90", Offset = "0x5D4F790", VA = "0x185D50F90")]
		get
		{
			return default(CJGJKDLDHCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LFIBKPIGLOG CACMJOPNICB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D51230", Offset = "0x5D4FA30", VA = "0x185D51230")]
		get
		{
			return default(LFIBKPIGLOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PECMKMIIIPL BMJLEJHHMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D50EA0", Offset = "0x5D4F6A0", VA = "0x185D50EA0")]
		get
		{
			return default(PECMKMIIIPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D50FE0", Offset = "0x5D4F7E0", VA = "0x185D50FE0")]
	public static void MKKPFBKGOBB([In] CJGJKDLDHCD JCKGNGKBJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D51160", Offset = "0x5D4F960", VA = "0x185D51160")]
	public static void NOCJPHOMELN(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D50DD0", Offset = "0x5D4F5D0", VA = "0x185D50DD0")]
	public static void GDBKNPKOPNG(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x23BE920", Offset = "0x23BD120", VA = "0x1823BE920")]
	public static void GDBKNPKOPNG<T>(T OIFDKAEILPK, BJFMOKJGEOD<T> BKGEBGGPBLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D50EF0", Offset = "0x5D4F6F0", VA = "0x185D50EF0")]
	public static void KIBAIBCDKCE(Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D50C80", Offset = "0x5D4F480", VA = "0x185D50C80")]
	public static string CEEOFHEPFCN(object CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D50B70", Offset = "0x5D4F370", VA = "0x185D50B70")]
	public static long APAEECOBDPG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D50BE0", Offset = "0x5D4F3E0", VA = "0x185D50BE0")]
	public static bool BHDFPLPLFLD(bool AGJELNEAJON, string BKGEBGGPBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D50D00", Offset = "0x5D4F500", VA = "0x185D50D00")]
	public static double FGGABJKAIIB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CJGJKDLDHCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly LFIBKPIGLOG CACMJOPNICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PECMKMIIIPL BMJLEJHHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly DKGGMPFDLGE OGGHNKMKHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly LKCFNENGEJK IIPKNBBHIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly PMAODFHAAFA LLLCKMBDMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly DKGGMPFDLGE AIMAEMGNEBC;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly LKCFNENGEJK JPPEDHPBPGB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PMAODFHAAFA JOIJONJJNJG;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CJGJKDLDHCD AACEAOMGOAN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F6F0", Offset = "0x5D4DEF0", VA = "0x185D4F6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FE50", Offset = "0x5D4E650", VA = "0x185D4FE50")]
	public CJGJKDLDHCD([In] LFIBKPIGLOG BGKJNJMPIOL, [In] PECMKMIIIPL EPIPKOMLOJC, DKGGMPFDLGE BBEHOCINABM, LKCFNENGEJK HFEBALABEHM, PMAODFHAAFA GDOMJBENJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F850", Offset = "0x5D4E050", VA = "0x185D4F850")]
	private static string NMKLFBFPANC(object CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500")]
	private static long OGMGALKHHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	private static string LAICODCGANC(string OLGPFNCCCJM, string? LPBINBIAAEN, bool NFOAPEKLNKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F5F0", Offset = "0x5D4DDF0", VA = "0x185D4F5F0")]
	private static CJGJKDLDHCD BBPABFHHELL()
	{
		return default(CJGJKDLDHCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FDCKHHFPFCJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CPJJANDHEDI([In] T IFHFGCDLDEA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void AKGAEHOBKJG<T>([In] T OIFDKAEILPK);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct EKDPINCGFJN<T> : IEquatable<EKDPINCGFJN<T>>, FDCKHHFPFCJ<EKDPINCGFJN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T PENMJFOMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int NEMCGPAIDHF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C360B0", Offset = "0x1C348B0", VA = "0x181C360B0")]
	public EKDPINCGFJN([In] T FKKGMPDEPMA, int LFEFGCGCIAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3076960", Offset = "0x3075160", VA = "0x183076960")]
	public static bool BIBGNMIHGGC([In] EKDPINCGFJN<T> PEEDIPGMMHL, [In] EKDPINCGFJN<T> PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3076C70", Offset = "0x3075470", VA = "0x183076C70", Slot = "4")]
	public bool Equals(EKDPINCGFJN<T> IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3076BF0", Offset = "0x30753F0", VA = "0x183076BF0", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3076B60", Offset = "0x3075360", VA = "0x183076B60")]
	public bool CPJJANDHEDI([In] EKDPINCGFJN<T> IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30775C0", Offset = "0x3075DC0", VA = "0x1830775C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30779D0", Offset = "0x30761D0", VA = "0x1830779D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3076D70", Offset = "0x3075570", VA = "0x183076D70")]
	public void FFNFLPIKFMM([Out] T FKKGMPDEPMA, [Out] int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30761E0", Offset = "0x30749E0", VA = "0x1830761E0")]
	public (T, int) AHBCGABIBPM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3076B10", Offset = "0x3075310", VA = "0x183076B10", Slot = "5")]
	private bool COANIKKNEBA([In] EKDPINCGFJN<T> IFHFGCDLDEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HPMJCIPDHNN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2385900", Offset = "0x2384100", VA = "0x182385900")]
	public static EKDPINCGFJN<T> KKMBICLNKPK<T>([In] T FKKGMPDEPMA, int LFEFGCGCIAG) where T : notnull
	{
		return default(EKDPINCGFJN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DFCKLOEJIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2212FD0", Offset = "0x22117D0", VA = "0x182212FD0")]
	public static bool CPJJANDHEDI<T, U>([In] T AFFJMIFONEM, [In] U CBBCDNDPNHF) where T : notnull, FDCKHHFPFCJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate TResult CHLKGJMABGM<T, out TResult>([In] T OIFDKAEILPK);
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate TResult HMJIOHDPBCM<T1, T2, out TResult>([In] T1 ADHPLBKHOGB, [In] T2 JACFKAFNHJO);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NDHEKOPHNPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	TimeSpan HPAGJMPMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Action? HCNMOPBNICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IIKKOHLIEBK();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKPOCCICOHP();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LPBBLMFICPP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct LFIBKPIGLOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly OCADAOPAPHA MKDAAGDHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly KNGHKJFKCMH MAKICADCFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OCADAOPAPHA BAPIBIOHHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KNGHKJFKCMH DICICNINKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly OCADAOPAPHA OAOAGDDLDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KNGHKJFKCMH JJPCMAHGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly CELCOPCGEOI KCMEEIEKHDE;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly OCADAOPAPHA LOAGOFMEFMC;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly KNGHKJFKCMH NBJHHBMCHKK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly OCADAOPAPHA ANMJKJIJLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KNGHKJFKCMH ECDFCGGNFPG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly OCADAOPAPHA HKCODNLIPOO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KNGHKJFKCMH FBNPMIEMAEM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly CELCOPCGEOI HPPHHDCJDFM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly LFIBKPIGLOG AACEAOMGOAN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly OCADAOPAPHA NKCHMMNGONF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D51ED0", Offset = "0x5D506D0", VA = "0x185D51ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86AE50", Offset = "0x869650", VA = "0x18086AE50")]
	public LFIBKPIGLOG(OCADAOPAPHA GNMEHKCNGJO, KNGHKJFKCMH NFCJILCEJCC, OCADAOPAPHA OOPGDMECIOH, KNGHKJFKCMH KFOGPCNCLEF, OCADAOPAPHA LAOOLMGOFIH, KNGHKJFKCMH BDICOGHIGDK, CELCOPCGEOI LEKKFLNPHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	private static bool PFJDOHKNCOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void KOCFJIEMNPE(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	private static bool IEGNLGHHDPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void FIGMIKJHOKE(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	private static bool FJIALBCHIGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void FAHBMOKGNNA(string BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void BNPEGGNJLCN(Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D51CC0", Offset = "0x5D504C0", VA = "0x185D51CC0")]
	private static LFIBKPIGLOG BBPABFHHELL()
	{
		return default(LFIBKPIGLOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0")]
	private static bool ADKNPIKEMIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D52220", Offset = "0x5D50A20", VA = "0x185D52220")]
	public void NOCJPHOMELN(object BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D521B0", Offset = "0x5D509B0", VA = "0x185D521B0")]
	public void GDBKNPKOPNG(object BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEE80", Offset = "0x1FFD680", VA = "0x181FFEE80")]
	public void KIBAIBCDKCE(Exception KPCACGLGOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D520D0", Offset = "0x5D508D0", VA = "0x185D520D0")]
	public void GDBKNPKOPNG(GOLJFFCMAND BKGEBGGPBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x240EF30", Offset = "0x240D730", VA = "0x18240EF30")]
	public void GDBKNPKOPNG<T>(T OIFDKAEILPK, BJFMOKJGEOD<T> BKGEBGGPBLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x240EFF0", Offset = "0x240D7F0", VA = "0x18240EFF0")]
	public void NOCJPHOMELN<T>([In] T OIFDKAEILPK, EMFBNFBAHLA<T> BKGEBGGPBLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D51E00", Offset = "0x5D50600", VA = "0x185D51E00")]
	public bool BHDFPLPLFLD(bool AGJELNEAJON, string BKGEBGGPBLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct LDBKIJLONIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string PENMJFOMGMH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	public LDBKIJLONIH(string FKKGMPDEPMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
	public static string FEBAGKLNOCP([In] LDBKIJLONIH AFFJMIFONEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x12A4500", Offset = "0x12A2D00", VA = "0x1812A4500")]
	public static LDBKIJLONIH FEBAGKLNOCP(string IFHFGCDLDEA)
	{
		return default(LDBKIJLONIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D51C70", Offset = "0x5D50470", VA = "0x185D51C70")]
	public string HEMPNHFOMOC(string AKBBFEAHONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D51B90", Offset = "0x5D50390", VA = "0x185D51B90")]
	public string GLNDIJGBGEL(object JAOEPKAEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct JGIANJFFIJK : IEquatable<JGIANJFFIJK>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "4")]
	public bool Equals(JGIANJFFIJK IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D51330", Offset = "0x5D4FB30", VA = "0x185D51330", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D51380", Offset = "0x5D4FB80", VA = "0x185D51380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D51390", Offset = "0x5D4FB90", VA = "0x185D51390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OHFLGEFENIF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KMLMHBDHBHH<T> : IEquatable<KMLMHBDHBHH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T PENMJFOMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool JLIJAMBGEHI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CLKJNNAOKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3883F70", Offset = "0x3882770", VA = "0x183883F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3885120", Offset = "0x3883920", VA = "0x183885120")]
	public KMLMHBDHBHH([In] T FKKGMPDEPMA, bool CMBGHDNOOCK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3884140", Offset = "0x3882940", VA = "0x183884140")]
	public static bool BIBGNMIHGGC([In] KMLMHBDHBHH<T> PEEDIPGMMHL, [In] KMLMHBDHBHH<T> PEFIBHOJLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3076C70", Offset = "0x3075470", VA = "0x183076C70", Slot = "4")]
	public bool Equals(KMLMHBDHBHH<T> IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38845F0", Offset = "0x3882DF0", VA = "0x1838845F0", Slot = "0")]
	public override bool Equals(object IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3884CB0", Offset = "0x38834B0", VA = "0x183884CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3884ED0", Offset = "0x38836D0", VA = "0x183884ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ABPKJBAMENO
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2997AF0", Offset = "0x29962F0", VA = "0x182997AF0")]
	public static KMLMHBDHBHH<T> EEIELCDNPKC<T>([In] T FKKGMPDEPMA) where T : notnull
	{
		return default(KMLMHBDHBHH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2997C00", Offset = "0x2996400", VA = "0x182997C00")]
	public static KMLMHBDHBHH<T?> KKHACCEJEOD<T>()
	{
		return default(KMLMHBDHBHH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2997A90", Offset = "0x2996290", VA = "0x182997A90")]
	public static bool DJFAOPBALCL<T>([In] this KMLMHBDHBHH<T> KLPLDFNHNJN, [Out][NotNullWhen(true)] T FKKGMPDEPMA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PECMKMIIIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly KFEJKCAEBGP IKADLKOGJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly EKGGNLACDPD MDACLPGFPJN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly KFEJKCAEBGP KEIIEHHPJGP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly EKGGNLACDPD JHMKIMBFEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly PECMKMIIIPL AACEAOMGOAN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D53B50", Offset = "0x5D52350", VA = "0x185D53B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
	public PECMKMIIIPL(KFEJKCAEBGP AALJBMBPFJK, EKGGNLACDPD NKDNCPCOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void DFLHPBMOPFP(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void HENFLDLPHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D53AC0", Offset = "0x5D522C0", VA = "0x185D53AC0")]
	private static PECMKMIIIPL BBPABFHHELL()
	{
		return default(PECMKMIIIPL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NKBMDLAPCMI
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate bool PBKPFKJDJNG<in TInput, TResult>(TInput EIGOIPKAPOI, [Out] TResult KMHAEDONIKI);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BPEEDGJNFJA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BPEEDGJNFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x48981A0", Offset = "0x48969A0", VA = "0x1848981A0")]
		internal void JNEKLOKGELG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NAPAKGOKJFF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NAPAKGOKJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x34AB090", Offset = "0x34A9890", VA = "0x1834AB090")]
		internal void GMEFAAOIEMB(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct BOHCFCEBNEE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public PBKPFKJDJNG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4894EF0", Offset = "0x48936F0", VA = "0x184894EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x48955E0", Offset = "0x4893DE0", VA = "0x1848955E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct HPPPHJFMEPP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5D50840", Offset = "0x5D4F040", VA = "0x185D50840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D50A40", Offset = "0x5D4F240", VA = "0x185D50A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D53710", Offset = "0x5D51F10", VA = "0x185D53710")]
	public static Task<TaskStatus> NOHIBJJBGIL(this Task AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x24B5480", Offset = "0x24B3C80", VA = "0x1824B5480")]
	public static Task<T> HCPPNIBKKMF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D53800", Offset = "0x5D52000", VA = "0x185D53800")]
	public static Task IFIIGDJOHOE(this Task AKGEHPDFIAE, CancellationToken KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x24B6F70", Offset = "0x24B5770", VA = "0x1824B6F70")]
	public static Task<TResult> IFIIGDJOHOE<TResult>(this Task<TResult> AKGEHPDFIAE, CancellationToken KIAKEGJPMAL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x24B7760", Offset = "0x24B5F60", VA = "0x1824B7760")]
	public static TaskCompletionSource<TResult> IFIIGDJOHOE<TResult>(this TaskCompletionSource<TResult> LPGJFJPDIDO, CancellationToken KIAKEGJPMAL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x24B55D0", Offset = "0x24B3DD0", VA = "0x1824B55D0")]
	[AsyncStateMachine(typeof(BOHCFCEBNEE<, >))]
	public static Task<List<TResult>> HMELPCGMLBO<TResult, TInput>(this Task<List<TInput>> AKGEHPDFIAE, PBKPFKJDJNG<TInput, TResult> DJCOJBCLCLM) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D53710", Offset = "0x5D51F10", VA = "0x185D53710")]
	[AsyncStateMachine(typeof(HPPPHJFMEPP))]
	[CompilerGenerated]
	internal static Task<TaskStatus> DLANILKHDJM(Task AFFEJJFNAGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IJHFDBGCIOC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	public IJHFDBGCIOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JBEOMBHBFJI : LBIPAEGLLIM
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LBIPAEGLLIM FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DateTime KFILANEMLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D50AB0", Offset = "0x5D4F2B0", VA = "0x185D50AB0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JBEOMBHBFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LBIPAEGLLIM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime KFILANEMLIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DAIFFAICNDK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static long PGMGCCNKHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D50230", Offset = "0x5D4EA30", VA = "0x185D50230")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static long CKGFLEDOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D50400", Offset = "0x5D4EC00", VA = "0x185D50400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double HHPBKDJCONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D50310", Offset = "0x5D4EB10", VA = "0x185D50310")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double KJGIBMDPDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D50020", Offset = "0x5D4E820", VA = "0x185D50020")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double MGDJPJCGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FFD0", Offset = "0x5D4E7D0", VA = "0x185D4FFD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double FDCHPHKPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FEF0", Offset = "0x5D4E6F0", VA = "0x185D4FEF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D50280", Offset = "0x5D4EA80", VA = "0x185D50280")]
	public static double MEONFBECMAD(long DJEPIGJDCAM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D500D0", Offset = "0x5D4E8D0", VA = "0x185D500D0")]
	public static double JCBOLANNMCM(long DJEPIGJDCAM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D50360", Offset = "0x5D4EB60", VA = "0x185D50360")]
	public static double MHJNNMBOCDG(double CDKJJONLNHD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FF40", Offset = "0x5D4E740", VA = "0x185D4FF40")]
	public static long EJBOBJDJJEN(long HAHNMEKBEPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5D503F0", Offset = "0x5D4EBF0", VA = "0x185D503F0")]
	public static long PACEBIBCNOE(long CGGJKDELAEK, long PLMOAINKKAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D50160", Offset = "0x5D4E960", VA = "0x185D50160")]
	public static double JFBDDHJECJB(long CGGJKDELAEK, long PLMOAINKKAO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D50070", Offset = "0x5D4E870", VA = "0x185D50070")]
	public static double INOCEFCHDME(long CGGJKDELAEK, long PLMOAINKKAO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class KJPAKJLMPON : NDHEKOPHNPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly TimeSpan LMMGBEFCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly System.Timers.Timer AOGFPKDBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private TimeSpan EHHDIDGCGLB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TimeSpan HPAGJMPMPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D516D0", Offset = "0x5D4FED0", VA = "0x185D516D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Action? HCNMOPBNICG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D518D0", Offset = "0x5D500D0", VA = "0x185D518D0")]
	[Preserve]
	public KJPAKJLMPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D51940", Offset = "0x5D50140", VA = "0x185D51940")]
	public KJPAKJLMPON(TimeSpan EHHDIDGCGLB, [Optional] Action? AGJBDNIOIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D51640", Offset = "0x5D4FE40", VA = "0x185D51640", Slot = "7")]
	public void IIKKOHLIEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D515D0", Offset = "0x5D4FDD0", VA = "0x185D515D0", Slot = "8")]
	public void EKPOCCICOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D51830", Offset = "0x5D50030", VA = "0x185D51830", Slot = "9")]
	public void LPBBLMFICPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0xACECC0", Offset = "0xACD4C0", VA = "0x180ACECC0")]
	private void FJPNGKJHJKB(object EANKMFHELBA, ElapsedEventArgs FLECLMNBILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D51490", Offset = "0x5D4FC90", VA = "0x185D51490")]
	private static void AEFNHGLOGBM(TimeSpan MFJKHGIDLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D51530", Offset = "0x5D4FD30", VA = "0x185D51530", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OHFLGEFENIF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string ABLIEABFDHP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
	public OHFLGEFENIF(string DBFBABABMHC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LNPOGMHBMDA : IEquatable<LNPOGMHBMDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint ELMILNBNJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int OKOLACLOHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float BBHNEPJAGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort HIBMFMKKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort MBPPHIAFGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short KKOBAJFCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short PHNJLLCEDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char PFHBNMMPHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char LDOCKOPDIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte ELEHLBMEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte LPNCCMOKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte LJMDGLDCIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte IANGHIAHHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool INBHAJMMFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool OLBPHFHLMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool ELJNBAEKFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool JHGMAEAELAI;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBB96B0", Offset = "0xBB7EB0", VA = "0x180BB96B0")]
	public static LNPOGMHBMDA JEIMBJGLFGJ(uint BCBNJNBJJMF)
	{
		return default(LNPOGMHBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBB96B0", Offset = "0xBB7EB0", VA = "0x180BB96B0")]
	public static LNPOGMHBMDA OPHHOHHKOGF(int PLHAGGPJGJO)
	{
		return default(LNPOGMHBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D52910", Offset = "0x5D51110", VA = "0x185D52910")]
	public static LNPOGMHBMDA FLBEKMNPKNM(float KMFLCOHIDLE)
	{
		return default(LNPOGMHBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D52870", Offset = "0x5D51070", VA = "0x185D52870")]
	public static LNPOGMHBMDA DGMJLCDKPJN(byte ABGIBOABENP, byte NAENLJBDGKN, byte ENJMLJODCMF, byte IIOJEDHEMIB)
	{
		return default(LNPOGMHBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D52870", Offset = "0x5D51070", VA = "0x185D52870")]
	public static LNPOGMHBMDA FMGPOLFCBBK(bool OKHMGHDEAHC, bool EANBMGNNLKE, bool APJPBMLKFPP, bool KMBEENJDBMH)
	{
		return default(LNPOGMHBMDA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1620740", Offset = "0x161EF40", VA = "0x181620740")]
	public static bool BIBGNMIHGGC(LNPOGMHBMDA LOKIPHPAIAD, LNPOGMHBMDA CGHEAIJKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1620720", Offset = "0x161EF20", VA = "0x181620720", Slot = "4")]
	public bool Equals(LNPOGMHBMDA IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D52890", Offset = "0x5D51090", VA = "0x185D52890", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F14C0", Offset = "0x7EFCC0", VA = "0x1807F14C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D52920", Offset = "0x5D51120", VA = "0x185D52920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ALPPOGHIHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public ulong BIDOKPKJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public long BIJDDEILGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public double GKJFBDMCMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint JOFHJDCMKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint DFLPBAFPBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int MPMCDJMPLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int FIFPNFJJOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float ODNAIBHAEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float MDBANEEICAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ushort HIBMFMKKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ushort MBPPHIAFGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public ushort JKJBKEMNPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public ushort GCFDOHKNAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public short KKOBAJFCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public short PHNJLLCEDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public short HFAJOENDOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public short HCPOADBFDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public char PFHBNMMPHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public char LDOCKOPDIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public char KEHONDEAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public char EGLEELENGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public byte ELEHLBMEDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public byte LPNCCMOKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte LJMDGLDCIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public byte IANGHIAHHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte NPLGNEOMOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public byte IPNGCIIMBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte MCFIKHGAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte DNBHEPGOKJH;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F5A0", Offset = "0x5D4DDA0", VA = "0x185D4F5A0")]
	public static ALPPOGHIHCI KKMBICLNKPK(byte ABGIBOABENP, byte NAENLJBDGKN, byte ENJMLJODCMF, byte IIOJEDHEMIB, byte NCKGAFOOEHH, byte KJCEKABFOAF, byte MOHKLDJKGIF, byte FKIKNJKEJCE)
	{
		return default(ALPPOGHIHCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DKPEHIEDHOH
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2210890", Offset = "0x220F090", VA = "0x182210890")]
	public static IEnumerable<T> HHNOIIANCFL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static T[] GGPEFBIMKFJ<T>(params T[] GOOJGKDJGOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static IEnumerable<T> ONGGNHCCONA<T>(params T[] GOOJGKDJGOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2221D70", Offset = "0x2220570", VA = "0x182221D70")]
	public static HashSet<T> PEADPCOFPLF<T>(params T[] GOOJGKDJGOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2221DE0", Offset = "0x22205E0", VA = "0x182221DE0")]
	public static KeyValuePair<TKey, TValue> MMOFCGEAKFA<TKey, TValue>([In] TKey OHPCNPKOLBJ, [In] TValue FKKGMPDEPMA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2221D70", Offset = "0x2220570", VA = "0x182221D70")]
	public static List<T> IIACNLFPDPK<T>(IEnumerable<T> GINKMKLCKOH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.All)]
public sealed class BOIBKOKHMEP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly string HNBNLHBPBNA;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
	public BOIBKOKHMEP(string CAPCAEOFDEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CAECDHEAJCN
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class EBFOPHMADDI<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ISet<T> FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int HLNPNOBJJGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3030C90", Offset = "0x302F490", VA = "0x183030C90", Slot = "4")]
		public bool Add(T BBKHFDEMMEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
		public void IntersectWith(IEnumerable<T> IFHFGCDLDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3030F50", Offset = "0x302F750", VA = "0x183030F50", Slot = "5")]
		public void UnionWith(IEnumerable<T> IFHFGCDLDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3030E30", Offset = "0x302F630", VA = "0x183030E30", Slot = "9")]
		void ICollection<T>.Add(T BBKHFDEMMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "11")]
		public bool Contains(T BBKHFDEMMEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
		public void CopyTo(T[] INLAJDDNHAO, int ILBHPPPGDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
		public bool Remove(T BBKHFDEMMEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3030D50", Offset = "0x302F550", VA = "0x183030D50", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3030E90", Offset = "0x302F690", VA = "0x183030E90", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public EBFOPHMADDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public static ISet<T> FDKBBCIIGHH<T>() where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PILKFHLEGFC]
public delegate void KFEJKCAEBGP(string HNHMJGCODBA);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PILKFHLEGFC]
public delegate void EKGGNLACDPD();
[Cpp2IlInjected.Token(Token = "0x2000036")]
public delegate object EMFBNFBAHLA<T>([In] T CCBNPDAGICC);
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object BJFMOKJGEOD<T>(T CCBNPDAGICC);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PILKFHLEGFC]
public delegate string PMAODFHAAFA(string OLGPFNCCCJM, string? LPBINBIAAEN, bool NFOAPEKLNKL);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PILKFHLEGFC]
public delegate void KNGHKJFKCMH(string BKGEBGGPBLH);
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PILKFHLEGFC]
public delegate void CELCOPCGEOI(Exception KPCACGLGOPI);
[Cpp2IlInjected.Token(Token = "0x200003B")]
public delegate object GOLJFFCMAND();
[Cpp2IlInjected.Token(Token = "0x200003C")]
[PILKFHLEGFC]
public delegate bool OCADAOPAPHA();
[Cpp2IlInjected.Token(Token = "0x200003D")]
[PILKFHLEGFC]
public delegate string DKGGMPFDLGE(object CBBCDNDPNHF);
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
