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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x625E810", Offset = "0x625DC10", VA = "0x18625E810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E85A0", Offset = "0x7E79A0", VA = "0x1807E85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OOCIEEOKEED : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x625E890", Offset = "0x625DC90", VA = "0x18625E890")]
	public OOCIEEOKEED(bool DLHPAHKIHHE, string OMAMDJGMBPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KHELEHDJFPF<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> MMGHODAMMJG(CancellationToken KNKAEBKAEBM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OCLDEMIGJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KHELEHDJFPF<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MMGHODAMMJG taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x40C68B0", Offset = "0x40C5CB0", VA = "0x1840C68B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x40C7910", Offset = "0x40C6D10", VA = "0x1840C7910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource MCEEHGKCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? CIHPBBMBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? KAIMGKGNMIP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C75BE0", Offset = "0x3C74FE0", VA = "0x183C75BE0")]
	[AsyncStateMachine(typeof(KHELEHDJFPF<>.OCLDEMIGJEH))]
	public Task<TResult> JGEFPAKCGFC(MMGHODAMMJG DJNGPLLMEEP, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C75B70", Offset = "0x3C74F70", VA = "0x183C75B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C75D20", Offset = "0x3C75120", VA = "0x183C75D20")]
	public KHELEHDJFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ONLMDBPLKPD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> PLODHAOJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T EIHNEEOMIED;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D29680", Offset = "0x3D28A80", VA = "0x183D29680")]
	public ONLMDBPLKPD([In] T PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40FC520", Offset = "0x40FB920", VA = "0x1840FC520", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40FC7F0", Offset = "0x40FBBF0", VA = "0x1840FC7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x40FCA80", Offset = "0x40FBE80", VA = "0x1840FCA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ADOFCIIGJMN
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62558A0", Offset = "0x6254CA0", VA = "0x1862558A0")]
	public static void MPMHPAPNDHG(this CancellationTokenSource MCEEHGKCGKG, bool MJJCFKBCFFA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MEFDBCCLCFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
	public MEFDBCCLCFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class KNKMEDCNICD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
	public KNKMEDCNICD(string IGHDMNGJBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AJNGJCMNIGF
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6BC0", Offset = "0x2DB5FC0", VA = "0x182DB6BC0")]
	public static FKDLAMHBNEG PBNIKMEFAJB<T>()
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6EF0", Offset = "0x2DB62F0", VA = "0x182DB6EF0")]
	public static FKDLAMHBNEG PIJHPCFAGKD<T>([CallerMemberName] string CCNKHEJHFKM = "") where T : notnull
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6D40", Offset = "0x2DB6140", VA = "0x182DB6D40")]
	public static FKDLAMHBNEG PBNIKMEFAJB<T>(this T OBMKPHNOIOK) where T : notnull
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6B70", Offset = "0x2DB5F70", VA = "0x182DB6B70")]
	public static FKDLAMHBNEG HLFBADGGEKN<T>(this T OBMKPHNOIOK, [CallerMemberName] string CCNKHEJHFKM = "") where T : notnull
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2DB6F80", Offset = "0x2DB6380", VA = "0x182DB6F80")]
	public static FKDLAMHBNEG PIJHPCFAGKD<T>(this T MEEBIDIALDO, [CallerMemberName] string CCNKHEJHFKM = "") where T : notnull
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6255D90", Offset = "0x6255190", VA = "0x186255D90")]
	public static FKDLAMHBNEG PIJHPCFAGKD(string HAALEEFDIII, [CallerMemberName] string CCNKHEJHFKM = "")
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6255CF0", Offset = "0x62550F0", VA = "0x186255CF0")]
	public static string NLEOMPJACLA(this object MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool AEAIAKPBGEE();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[MEFDBCCLCFL]
public delegate long EBGDFNDFDJI();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OPOJNKNNDBI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static CEANBEGLKPD ECJNEKNGGKO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CEANBEGLKPD DLCCEBAFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x625EFC0", Offset = "0x625E3C0", VA = "0x18625EFC0")]
		get
		{
			return default(CEANBEGLKPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NNFCNHCPPDH PCEBLOBJHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x625ED10", Offset = "0x625E110", VA = "0x18625ED10")]
		get
		{
			return default(NNFCNHCPPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EGDNMFPAKOH AIOEGKDKFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x625ED60", Offset = "0x625E160", VA = "0x18625ED60")]
		get
		{
			return default(EGDNMFPAKOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool BLBCBILLHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x625EF50", Offset = "0x625E350", VA = "0x18625EF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x625EAC0", Offset = "0x625DEC0", VA = "0x18625EAC0")]
	public static void DEHDBHFBIPM([In] CEANBEGLKPD CCIKIGBEFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x625F090", Offset = "0x625E490", VA = "0x18625F090")]
	public static void OMAIFAPDBID(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x625EE80", Offset = "0x625E280", VA = "0x18625EE80")]
	public static void HOLPICFPDNJ(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2955DB0", Offset = "0x29551B0", VA = "0x182955DB0")]
	public static void HOLPICFPDNJ<T>(T PBBNOGAMKJE, FMIEOFIIEFN<T> JEBCFBFPEMG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x625E9C0", Offset = "0x625DDC0", VA = "0x18625E9C0")]
	public static void CFDJGOBIIKC(Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x625EA60", Offset = "0x625DE60", VA = "0x18625EA60")]
	public static void DCGPAMLFIIF(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x625E960", Offset = "0x625DD60", VA = "0x18625E960")]
	public static void CAJJPEGABKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x625F010", Offset = "0x625E410", VA = "0x18625F010")]
	public static string NLEOMPJACLA(object LIKEKIACGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x625F160", Offset = "0x625E560", VA = "0x18625F160")]
	public static long PPKKIFBEBPL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x625EC70", Offset = "0x625E070", VA = "0x18625EC70")]
	public static bool DHICOMIFOLJ(bool MLIHHKGMCFH, string JEBCFBFPEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x625EDB0", Offset = "0x625E1B0", VA = "0x18625EDB0")]
	public static double GHBCMCIONLL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CEANBEGLKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly NNFCNHCPPDH PCEBLOBJHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly EGDNMFPAKOH AIOEGKDKFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly FNGFBFMFBGI CCAIJDKCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EBGDFNDFDJI LHPIKDLDCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly GFCDPCBCNIB EJBEHBAEMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly AEAIAKPBGEE FNJMOGANFDE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly FNGFBFMFBGI CEBHFLABOLG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EBGDFNDFDJI LFNMEMNJEBD;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GFCDPCBCNIB OOGMEIOAKNP;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly AEAIAKPBGEE EGNCBGPAHBA;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly CEANBEGLKPD CCDCOKAGGMA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LPBPADBNJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62564F0", Offset = "0x62558F0", VA = "0x1862564F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6256D80", Offset = "0x6256180", VA = "0x186256D80")]
	public CEANBEGLKPD([In] NNFCNHCPPDH ODCBNKNIMPB, [In] EGDNMFPAKOH KBDKKDHHOLH, FNGFBFMFBGI IDHIBFHICKG, EBGDFNDFDJI BHCJEAAHLPI, GFCDPCBCNIB NIEHFLKHLOE, AEAIAKPBGEE HNLGMNNMEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62564B0", Offset = "0x62558B0", VA = "0x1862564B0")]
	private static string HAEDGDPMPIN(object LIKEKIACGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310")]
	private static long GMMNNJJHBDB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	private static string DNHMILDCLHL(string PPPBBGPLHME, string? NPJNICJKKMK, bool LNGFHJGKCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	private static bool IMCNKDDPDFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62563A0", Offset = "0x62557A0", VA = "0x1862563A0")]
	private static CEANBEGLKPD EDHOBIAKGHC()
	{
		return default(CEANBEGLKPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FMFFNKDKBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LOALMPJLFOA IFJFKNHNFJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LOALMPJLFOA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PKCCHHIOOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKMCBKNKNCC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IJKDBAHHGHL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCIFIJKLDNM([In] T MGDPHHCBMMP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void PDEPFCNIGHH<T>([In] T PBBNOGAMKJE);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GOLDPEBMNPK<T> : IEquatable<GOLDPEBMNPK<T>>, IJKDBAHHGHL<GOLDPEBMNPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T EIHNEEOMIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int LCMFLKBKPPA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DF9C20", Offset = "0x1DF9020", VA = "0x181DF9C20")]
	public GOLDPEBMNPK([In] T PCGOHCLJAPN, int PMLKPJNGBAD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37F1C30", Offset = "0x37F1030", VA = "0x1837F1C30")]
	public static bool IDILALBKFJC([In] GOLDPEBMNPK<T> OOGPCKEGMIK, [In] GOLDPEBMNPK<T> NPEJHBIFPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37F16E0", Offset = "0x37F0AE0", VA = "0x1837F16E0", Slot = "4")]
	public bool Equals(GOLDPEBMNPK<T> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37F1660", Offset = "0x37F0A60", VA = "0x1837F1660", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37F2210", Offset = "0x37F1610", VA = "0x1837F2210")]
	public bool LCIFIJKLDNM([In] GOLDPEBMNPK<T> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37F1900", Offset = "0x37F0D00", VA = "0x1837F1900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37F2700", Offset = "0x37F1B00", VA = "0x1837F2700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37F0C60", Offset = "0x37F0060", VA = "0x1837F0C60")]
	public void BNCCPBFLAPH([Out] T PCGOHCLJAPN, [Out] int PMLKPJNGBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37F12E0", Offset = "0x37F06E0", VA = "0x1837F12E0")]
	public (T, int) COICJIAKJKE()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37F0B60", Offset = "0x37EFF60", VA = "0x1837F0B60", Slot = "5")]
	private bool BAPOENMIPLP([In] GOLDPEBMNPK<T> MGDPHHCBMMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JACCMENCOEE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x283E070", Offset = "0x283D470", VA = "0x18283E070")]
	public static GOLDPEBMNPK<T> HGJFOBLHCKL<T>([In] T PCGOHCLJAPN, int PMLKPJNGBAD) where T : notnull
	{
		return default(GOLDPEBMNPK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OILHGFJBFBP
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x293D8D0", Offset = "0x293CCD0", VA = "0x18293D8D0")]
	public static bool LCIFIJKLDNM<T, U>([In] T MEEBIDIALDO, [In] U LIKEKIACGIL) where T : notnull, IJKDBAHHGHL<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult BFHHKNBHDOM<T, out TResult>([In] T PBBNOGAMKJE);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EBPAOBBNAON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan FIECPBMOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? MCMMAMJAEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OEBPOHMGJLL();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJBMJAPHLPE();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOGMNIMOPIB();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct NNFCNHCPPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EGHMGGNEDKM AIKOJPGGIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly CNIMHKJCPBH HHHHFNJFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly EGHMGGNEDKM KGAGFDFLHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly CNIMHKJCPBH KKIKFGDEFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly EGHMGGNEDKM CKGGGEPHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly CNIMHKJCPBH NDFOJODDMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FBIPJGGLNJB LFGFFFLJCHH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly EGHMGGNEDKM DGEGAKDMGMD;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly CNIMHKJCPBH LKEHLIFBBML;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EGHMGGNEDKM AAJMKKNMPGB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly CNIMHKJCPBH IHCHKLECMGJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly EGHMGGNEDKM PLALBFJOFPL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly CNIMHKJCPBH CPDBDCLNGEM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FBIPJGGLNJB KACHNNOKPLD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NNFCNHCPPDH CCDCOKAGGMA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EGHMGGNEDKM BOBAABLLDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LPBPADBNJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x625DE60", Offset = "0x625D260", VA = "0x18625DE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9E3C90", Offset = "0x9E3090", VA = "0x1809E3C90")]
	public NNFCNHCPPDH(EGHMGGNEDKM NCGAODOFHMF, CNIMHKJCPBH KNNKEDECPKL, EGHMGGNEDKM HPMEENDHHOO, CNIMHKJCPBH GMLCGODEFEO, EGHMGGNEDKM NGGOJNLHIKO, CNIMHKJCPBH KHMNEKDFLPK, FBIPJGGLNJB LOIEDKENIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	private static bool MJLFJGPLDCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void IHKDGNGNBMK(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	private static bool IHPNEBPOBHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void GLGPDGOAKGF(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	private static bool JLJBPNAFFLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void BHAGGJHGGNM(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void DMHMMEHOLHB(Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x625DBD0", Offset = "0x625CFD0", VA = "0x18625DBD0")]
	private static NNFCNHCPPDH EDHOBIAKGHC()
	{
		return default(NNFCNHCPPDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80")]
	private static bool PIDOAOPFMKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x625E060", Offset = "0x625D460", VA = "0x18625E060")]
	public void OMAIFAPDBID(object JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x625DD10", Offset = "0x625D110", VA = "0x18625DD10")]
	public void HOLPICFPDNJ(object JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x19E0C60", Offset = "0x19E0060", VA = "0x1819E0C60")]
	public void CFDJGOBIIKC(Exception DAAIKNOAPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x625DD80", Offset = "0x625D180", VA = "0x18625DD80")]
	public void HOLPICFPDNJ(JGLLPEDJPLF JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2924720", Offset = "0x2923B20", VA = "0x182924720")]
	public void HOLPICFPDNJ<T>(T PBBNOGAMKJE, FMIEOFIIEFN<T> JEBCFBFPEMG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29247E0", Offset = "0x2923BE0", VA = "0x1829247E0")]
	public void OMAIFAPDBID<T>([In] T PBBNOGAMKJE, FIFHLFOCKGF<T> JEBCFBFPEMG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x625DB00", Offset = "0x625CF00", VA = "0x18625DB00")]
	public bool DHICOMIFOLJ(bool MLIHHKGMCFH, string JEBCFBFPEMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct FKDLAMHBNEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string EIHNEEOMIED;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	public FKDLAMHBNEG(string PCGOHCLJAPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850")]
	public static string KAHNABMFJPM([In] FKDLAMHBNEG MEEBIDIALDO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x14D6630", Offset = "0x14D5A30", VA = "0x1814D6630")]
	public static FKDLAMHBNEG KAHNABMFJPM(string MGDPHHCBMMP)
	{
		return default(FKDLAMHBNEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6258470", Offset = "0x6257870", VA = "0x186258470")]
	public string CFBDCHFBIMD(string KFCAJGFCMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62584C0", Offset = "0x62578C0", VA = "0x1862584C0")]
	public string MNCKAHOPMNF(object CFJODMPHEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct GLCFOAMDFIN : IEquatable<GLCFOAMDFIN>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "4")]
	public bool Equals(GLCFOAMDFIN MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x625A4F0", Offset = "0x62598F0", VA = "0x18625A4F0", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x625A540", Offset = "0x6259940", VA = "0x18625A540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x625A550", Offset = "0x6259950", VA = "0x18625A550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[OAKOKOJNDPP("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct LDJGEBAMNJP<T> : IEquatable<LDJGEBAMNJP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T EIHNEEOMIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool PFIIONNOOAB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool ADAJABNNPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3D114F0", Offset = "0x3D108F0", VA = "0x183D114F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3D118A0", Offset = "0x3D10CA0", VA = "0x183D118A0")]
	public LDJGEBAMNJP([In] T PCGOHCLJAPN, bool IHMNKOBMFKI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3D11340", Offset = "0x3D10740", VA = "0x183D11340")]
	public static bool IDILALBKFJC([In] LDJGEBAMNJP<T> OOGPCKEGMIK, [In] LDJGEBAMNJP<T> NPEJHBIFPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x37F16E0", Offset = "0x37F0AE0", VA = "0x1837F16E0", Slot = "4")]
	public bool Equals(LDJGEBAMNJP<T> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3D10720", Offset = "0x3D0FB20", VA = "0x183D10720", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3D10E60", Offset = "0x3D10260", VA = "0x183D10E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3D115C0", Offset = "0x3D109C0", VA = "0x183D115C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class BLGFBMFJDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25C2F00", Offset = "0x25C2300", VA = "0x1825C2F00")]
	public static LDJGEBAMNJP<T> ONJHGHFOGAI<T>([In] T PCGOHCLJAPN) where T : notnull
	{
		return default(LDJGEBAMNJP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25C2DF0", Offset = "0x25C21F0", VA = "0x1825C2DF0")]
	public static LDJGEBAMNJP<T?> LDDJNKKNHJD<T>()
	{
		return default(LDJGEBAMNJP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25C2CB0", Offset = "0x25C20B0", VA = "0x1825C2CB0")]
	public static bool DAONPJLPNPC<T>([In] this LDJGEBAMNJP<T> CBHMHCHAGHJ, [Out][NotNullWhen(true)] T PCGOHCLJAPN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct EGDNMFPAKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr DCGPAMLFIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr CAJJPEGABKF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr PGKILOIGHOE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr DALGHCAFBCK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly EGDNMFPAKOH CCDCOKAGGMA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LPBPADBNJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62579F0", Offset = "0x6256DF0", VA = "0x1862579F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x90E910", Offset = "0x90DD10", VA = "0x18090E910")]
	public EGDNMFPAKOH(IntPtr FBLJEEJPJPP, IntPtr MNJJGENAEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void IKMEMFDJFPE(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	private static void LNFBMPNLDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6257960", Offset = "0x6256D60", VA = "0x186257960")]
	private static EGDNMFPAKOH EDHOBIAKGHC()
	{
		return default(EGDNMFPAKOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct DIFPMNFFGDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr KIDJPHEKBOP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x948610", Offset = "0x947A10", VA = "0x180948610")]
	private DIFPMNFFGDA(IntPtr MNJJGENAEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62577F0", Offset = "0x6256BF0", VA = "0x1862577F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6257800", Offset = "0x6256C00", VA = "0x186257800")]
	public static DIFPMNFFGDA HGJFOBLHCKL(string CCNKHEJHFKM)
	{
		return default(DIFPMNFFGDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DDDED0", Offset = "0x1DDD2D0", VA = "0x181DDDED0")]
	public static DIFPMNFFGDA HGJFOBLHCKL([In] EGDNMFPAKOH KBDKKDHHOLH, string CCNKHEJHFKM)
	{
		return default(DIFPMNFFGDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DDE130", Offset = "0x1DDD530", VA = "0x181DDE130")]
	public static DIFPMNFFGDA HGJFOBLHCKL([In] EGDNMFPAKOH KBDKKDHHOLH, Func<string> CCNKHEJHFKM)
	{
		return default(DIFPMNFFGDA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KBGIMNGPMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool DIEIPLPDCBO<in TInput, TResult>(TInput CIBLPGDHGMJ, [Out] TResult FEADNEEPDLO);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class PBLJIOGJECA : FMFFNKDKBLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class JEFCHBODJMC : LOALMPJLFOA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly JEFCHBODJMC GDCHCCJBKDM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool PKCCHHIOOCE
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x625AB40", Offset = "0x6259F40", VA = "0x18625AB40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x625ABA0", Offset = "0x6259FA0", VA = "0x18625ABA0", Slot = "6")]
			public void OnCompleted(Action KHFCJAPPBPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			public void OKMCBKNKNCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public JEFCHBODJMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly PBLJIOGJECA GDCHCCJBKDM;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		private PBLJIOGJECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x625F290", Offset = "0x625E690", VA = "0x18625F290", Slot = "4")]
		public LOALMPJLFOA IFJFKNHNFJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class HBICEDGDDBL : FMFFNKDKBLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class LBOIODLIEFF : LOALMPJLFOA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly LBOIODLIEFF GDCHCCJBKDM;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool PKCCHHIOOCE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x625D0D0", Offset = "0x625C4D0", VA = "0x18625D0D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x625D0F0", Offset = "0x625C4F0", VA = "0x18625D0F0", Slot = "6")]
			public void OnCompleted(Action KHFCJAPPBPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			public void OKMCBKNKNCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public LBOIODLIEFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly HBICEDGDDBL GDCHCCJBKDM;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		private HBICEDGDDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x625A6A0", Offset = "0x6259AA0", VA = "0x18625A6A0", Slot = "4")]
		public LOALMPJLFOA IFJFKNHNFJJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IGFGILPCCAE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IGFGILPCCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x39ADD30", Offset = "0x39AD130", VA = "0x1839ADD30")]
		internal void OJGDONBGOFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IJBDCGKHKCH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public IJBDCGKHKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x37F03A0", Offset = "0x37EF7A0", VA = "0x1837F03A0")]
		internal void FPBILGKKMLA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NNMIKMKICPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625E6B0", Offset = "0x625DAB0", VA = "0x18625E6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NEPDLNGPOOI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625D9F0", Offset = "0x625CDF0", VA = "0x18625D9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A3110", Offset = "0x8A2510", VA = "0x1808A3110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct MIBODMFFFMC<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x3F02BA0", Offset = "0x3F01FA0", VA = "0x183F02BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F02D10", Offset = "0x3F02110", VA = "0x183F02D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PCJCFFFPJDM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4196A50", Offset = "0x4195E50", VA = "0x184196A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x41972C0", Offset = "0x41966C0", VA = "0x1841972C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KBCGBDLFMJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625AD80", Offset = "0x625A180", VA = "0x18625AD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x625AF80", Offset = "0x625A380", VA = "0x18625AF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DLACFPHCELI<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DLACFPHCELI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x39ADD30", Offset = "0x39AD130", VA = "0x1839ADD30")]
		internal void FACPHGIIPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x50F69E0", Offset = "0x50F5DE0", VA = "0x1850F69E0")]
		internal void MPPICEEIGDC(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GKNHBEBHIGK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public DIEIPLPDCBO<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x37D94C0", Offset = "0x37D88C0", VA = "0x1837D94C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x37D9BB0", Offset = "0x37D8FB0", VA = "0x1837D9BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FCNFLPAGBOP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6257C20", Offset = "0x6257020", VA = "0x186257C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6258410", Offset = "0x6257810", VA = "0x186258410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct GELKAHNIDIE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6259620", Offset = "0x6258A20", VA = "0x186259620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6259B60", Offset = "0x6258F60", VA = "0x186259B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct DNPDGGIOLKJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x50FF260", Offset = "0x50FE660", VA = "0x1850FF260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x331C5B0", Offset = "0x331B9B0", VA = "0x18331C5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FOOGOFJOAGJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3706BF0", Offset = "0x3705FF0", VA = "0x183706BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x33143B0", Offset = "0x33137B0", VA = "0x1833143B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct GIHDHDGFANL<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x37CA560", Offset = "0x37C9960", VA = "0x1837CA560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x37CAC60", Offset = "0x37CA060", VA = "0x1837CAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BEMFLGELHGP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6256160", Offset = "0x6255560", VA = "0x186256160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6256340", Offset = "0x6255740", VA = "0x186256340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IEIAHFAKDBD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625A770", Offset = "0x6259B70", VA = "0x18625A770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x625AAE0", Offset = "0x6259EE0", VA = "0x18625AAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LGKLCFOEEEO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625D1C0", Offset = "0x625C5C0", VA = "0x18625D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x625D4B0", Offset = "0x625C8B0", VA = "0x18625D4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MPNDNIIIKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MPNDNIIIKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x625D980", Offset = "0x625CD80", VA = "0x18625D980")]
		internal Task MEKEMCHFMAC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CFIJGJPHFCM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6256E30", Offset = "0x6256230", VA = "0x186256E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6257090", Offset = "0x6256490", VA = "0x186257090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KLNOGEPDJHA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625CBD0", Offset = "0x625BFD0", VA = "0x18625CBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x625CDB0", Offset = "0x625C1B0", VA = "0x18625CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AECEBAPLEBE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62558D0", Offset = "0x6254CD0", VA = "0x1862558D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6255C40", Offset = "0x6255040", VA = "0x186255C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BEFEDBOKDKA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6255E10", Offset = "0x6255210", VA = "0x186255E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6256100", Offset = "0x6255500", VA = "0x186256100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EDHCIIIMCOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EDHCIIIMCOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x62578F0", Offset = "0x6256CF0", VA = "0x1862578F0")]
		internal Task EPAABBAFEIE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct KPNDIHGKHDB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625CE10", Offset = "0x625C210", VA = "0x18625CE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x625D070", Offset = "0x625C470", VA = "0x18625D070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GEBPMMPOBBM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6259440", Offset = "0x6258840", VA = "0x186259440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x62595C0", Offset = "0x62589C0", VA = "0x1862595C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JEBDGPNJHAH<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3B5AAB0", Offset = "0x3B59EB0", VA = "0x183B5AAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AD10", Offset = "0x3B5A110", VA = "0x183B5AD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LKJFOOPCPOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x625D510", Offset = "0x625C910", VA = "0x18625D510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x625D920", Offset = "0x625CD20", VA = "0x18625D920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? MGLCJCMEIAH;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<GLCFOAMDFIN> BOHCNGJODMK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task CJKFIOMGMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x625CAA0", Offset = "0x625BEA0", VA = "0x18625CAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x625C890", Offset = "0x625BC90", VA = "0x18625C890")]
	public static bool NCOCNNLKDGJ(this Task JKFKBCIOAGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2866100", Offset = "0x2865500", VA = "0x182866100")]
	public static Task<T> JMAAGPLFFIC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x625B8A0", Offset = "0x625ACA0", VA = "0x18625B8A0")]
	public static Task FNHALLMMCHG(this Task JKFKBCIOAGB, CancellationToken ICNJFMMNIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2865250", Offset = "0x2864650", VA = "0x182865250")]
	public static Task<TResult> FNHALLMMCHG<TResult>(this Task<TResult> JKFKBCIOAGB, CancellationToken ICNJFMMNIKL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2865AA0", Offset = "0x2864EA0", VA = "0x182865AA0")]
	public static TaskCompletionSource<TResult> FNHALLMMCHG<TResult>(this TaskCompletionSource<TResult> IHMOPGFBBGH, CancellationToken ICNJFMMNIKL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x625AFF0", Offset = "0x625A3F0", VA = "0x18625AFF0")]
	[AsyncStateMachine(typeof(NNMIKMKICPO))]
	public static void AHCLGGJFNGK(this Task PLGHLMOEPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x625C9F0", Offset = "0x625BDF0", VA = "0x18625C9F0")]
	[AsyncStateMachine(typeof(NEPDLNGPOOI))]
	public static void NNJDLEMCFKP(this Task PLGHLMOEPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28666B0", Offset = "0x2865AB0", VA = "0x1828666B0")]
	[AsyncStateMachine(typeof(MIBODMFFFMC<>))]
	public static Task LCAFFNFPPKA<TException>(this Task PLGHLMOEPOB) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2863040", Offset = "0x2862440", VA = "0x182863040")]
	[AsyncStateMachine(typeof(PCJCFFFPJDM<>))]
	public static Task<T> DLIJLHGKGKC<T>(this Task<T> MEEBIDIALDO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x625C6D0", Offset = "0x625BAD0", VA = "0x18625C6D0")]
	[AsyncStateMachine(typeof(KBCGBDLFMJG))]
	public static Task<TaskStatus> KLIMJININLJ(this Task MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2863200", Offset = "0x2862600", VA = "0x182863200")]
	public static (Task<T?>?, Action<T?>?) EMDBKBDCLMN<T>([Optional] CancellationToken KNKAEBKAEBM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2866000", Offset = "0x2865400", VA = "0x182866000")]
	[AsyncStateMachine(typeof(GKNHBEBHIGK<, >))]
	public static Task<List<TResult>> IMKIFLFBNEC<TResult, TInput>(this Task<List<TInput>> JKFKBCIOAGB, DIEIPLPDCBO<TInput, TResult> FFFEDDBBHOK) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x625BC90", Offset = "0x625B090", VA = "0x18625BC90")]
	[AsyncStateMachine(typeof(FCNFLPAGBOP))]
	public static Task GOGGFFBLJCE(Task PLGHLMOEPOB, CancellationToken JKLIJNDGKKN, Func<CancellationToken, Task> JOKHMBIHEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x625C8C0", Offset = "0x625BCC0", VA = "0x18625C8C0")]
	[AsyncStateMachine(typeof(GELKAHNIDIE))]
	public static Task NNICMOELNAG(Func<CancellationToken, Task> EDAAAJMFDFC, TimeSpan KCLHELHGLEJ, [Optional] CancellationToken JKLIJNDGKKN, [Optional] Action<OperationCanceledException>? BGJOMHNCPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2866780", Offset = "0x2865B80", VA = "0x182866780")]
	[AsyncStateMachine(typeof(DNPDGGIOLKJ<>))]
	public static Task<T> NNICMOELNAG<T>(Func<CancellationToken, Task<T>> EDAAAJMFDFC, TimeSpan KCLHELHGLEJ, [Optional] CancellationToken JKLIJNDGKKN, [Optional] Func<OperationCanceledException, T>? BGJOMHNCPBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28665D0", Offset = "0x28659D0", VA = "0x1828665D0")]
	[AsyncStateMachine(typeof(FOOGOFJOAGJ<>))]
	public static Task<IEnumerable<Task<T>>> KDFHPDAAHGK<T>(IEnumerable<Task<T>> AAHIFJGLKJK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2866250", Offset = "0x2865650", VA = "0x182866250")]
	[AsyncStateMachine(typeof(GIHDHDGFANL<, , , >))]
	public static Task<(T1, T2, T3, T4)> JOJHMGBMLBP<T1, T2, T3, T4>(Task<T1> DMGOBPODDIM, Task<T2> ALPGKHJIOOK, Task<T3> NHGFOJDNFMK, Task<T4> EHDBNLBIGIP) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x625B6A0", Offset = "0x625AAA0", VA = "0x18625B6A0")]
	[AsyncStateMachine(typeof(BEMFLGELHGP))]
	public static Task FAEKEOJNKCI(Func<bool> MLIHHKGMCFH, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x625B790", Offset = "0x625AB90", VA = "0x18625B790")]
	[AsyncStateMachine(typeof(IEIAHFAKDBD))]
	public static Task FAEKEOJNKCI(Func<bool> MLIHHKGMCFH, TimeSpan OOPCMJBNNMH, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x625B190", Offset = "0x625A590", VA = "0x18625B190")]
	[AsyncStateMachine(typeof(LGKLCFOEEEO))]
	public static Task CPFDIHFBLJB(Func<bool> MLIHHKGMCFH, TimeSpan KCLHELHGLEJ, [Optional] CancellationToken KNKAEBKAEBM, [Optional] Action<OperationCanceledException>? BGJOMHNCPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x625B2C0", Offset = "0x625A6C0", VA = "0x18625B2C0")]
	[AsyncStateMachine(typeof(CFIJGJPHFCM))]
	public static Task CPFDIHFBLJB(Func<bool> MLIHHKGMCFH, TimeSpan KCLHELHGLEJ, TimeSpan OOPCMJBNNMH, [Optional] CancellationToken KNKAEBKAEBM, [Optional] Action<OperationCanceledException>? BGJOMHNCPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x625C210", Offset = "0x625B610", VA = "0x18625C210")]
	[AsyncStateMachine(typeof(KLNOGEPDJHA))]
	public static Task KFNFMHJEOLK(Func<bool> MLIHHKGMCFH, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x625C300", Offset = "0x625B700", VA = "0x18625C300")]
	[AsyncStateMachine(typeof(AECEBAPLEBE))]
	public static Task KFNFMHJEOLK(Func<bool> MLIHHKGMCFH, TimeSpan OOPCMJBNNMH, [Optional] CancellationToken KNKAEBKAEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x625C460", Offset = "0x625B860", VA = "0x18625C460")]
	[AsyncStateMachine(typeof(BEFEDBOKDKA))]
	public static Task KJKLCLLPNBD(Func<bool> MLIHHKGMCFH, TimeSpan KCLHELHGLEJ, [Optional] CancellationToken KNKAEBKAEBM, [Optional] Action<OperationCanceledException>? BGJOMHNCPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x625C590", Offset = "0x625B990", VA = "0x18625C590")]
	[AsyncStateMachine(typeof(KPNDIHGKHDB))]
	public static Task KJKLCLLPNBD(Func<bool> MLIHHKGMCFH, TimeSpan KCLHELHGLEJ, TimeSpan OOPCMJBNNMH, [Optional] CancellationToken KNKAEBKAEBM, [Optional] Action<OperationCanceledException>? BGJOMHNCPBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x625B0A0", Offset = "0x625A4A0", VA = "0x18625B0A0")]
	[AsyncStateMachine(typeof(GEBPMMPOBBM))]
	[Obsolete]
	public static Task AICIOKNKKAG(this Task JKFKBCIOAGB, Action IAIDIKJAHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2862F50", Offset = "0x2862350", VA = "0x182862F50")]
	[Obsolete]
	[AsyncStateMachine(typeof(JEBDGPNJHAH<>))]
	public static Task AICIOKNKKAG<T>(this Task<T> JKFKBCIOAGB, Action<T> IAIDIKJAHEO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x625B520", Offset = "0x625A920", VA = "0x18625B520")]
	private static void EFGKNMLFPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x625BE90", Offset = "0x625B290", VA = "0x18625BE90")]
	public static bool JOHJHKNJNMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x625BB00", Offset = "0x625AF00", VA = "0x18625BB00")]
	private static void GOCDOIIFNDL(SynchronizationContext PCGOHCLJAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x625B400", Offset = "0x625A800", VA = "0x18625B400")]
	private static void DEGDEODACAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x625B5D0", Offset = "0x625A9D0", VA = "0x18625B5D0")]
	public static void EGIDDNGLEPC([Optional] string? JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x625BE10", Offset = "0x625B210", VA = "0x18625BE10")]
	public static void JCMEIGGDPPO([Optional] string? JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x625C410", Offset = "0x625B810", VA = "0x18625C410")]
	public static FMFFNKDKBLK KJDKMFMAMMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x625BDC0", Offset = "0x625B1C0", VA = "0x18625BDC0")]
	public static FMFFNKDKBLK IBFJJPHIFML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x625C7C0", Offset = "0x625BBC0", VA = "0x18625C7C0")]
	[AsyncStateMachine(typeof(LKJFOOPCPOE))]
	public static Task LHNDNFPPPFI(Func<Task> KNFHKDLGIMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MHKHBJDHDOI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
	public MHKHBJDHDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class HAKJIFGCCND : MPLAMDAIPEG
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly MPLAMDAIPEG GDCHCCJBKDM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime DOAIIPIHONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x625A5E0", Offset = "0x62599E0", VA = "0x18625A5E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset BNCNPCLFANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x625A580", Offset = "0x6259980", VA = "0x18625A580", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HAKJIFGCCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MPLAMDAIPEG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime DOAIIPIHONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset BNCNPCLFANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GJKAMHBGNBK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long LMDBJHIIJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x625A180", Offset = "0x6259580", VA = "0x18625A180")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long NFMOJLMLCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x625A130", Offset = "0x6259530", VA = "0x18625A130")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double AKECGKKEMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x625A1D0", Offset = "0x62595D0", VA = "0x18625A1D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double GDPDACOJIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x625A080", Offset = "0x6259480", VA = "0x18625A080")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double DLFKIMEEPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6259D20", Offset = "0x6259120", VA = "0x186259D20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double NNLNMIDDKED
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6259CC0", Offset = "0x62590C0", VA = "0x186259CC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6259F60", Offset = "0x6259360", VA = "0x186259F60")]
	public static double IGCLAICEOLA(long AIKFEKHKMCE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6259ED0", Offset = "0x62592D0", VA = "0x186259ED0")]
	public static double HHJJLFCACMK(long AIKFEKHKMCE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6259E40", Offset = "0x6259240", VA = "0x186259E40")]
	public static double HHDFDFFBLCJ(double DHGAGCFNJIL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6259FF0", Offset = "0x62593F0", VA = "0x186259FF0")]
	public static long JDBGCLBONCK(long ABEDOEMHLPN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6259D10", Offset = "0x6259110", VA = "0x186259D10")]
	public static long DCLLFLIFFLF(long GNDIGFMMHHI, long NHKAOIONGMK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6259D70", Offset = "0x6259170", VA = "0x186259D70")]
	public static double DPAJNJNCDGE(long GNDIGFMMHHI, long NHKAOIONGMK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x625A0D0", Offset = "0x62594D0", VA = "0x18625A0D0")]
	public static double JFAPDOGOJCJ(long GNDIGFMMHHI, long NHKAOIONGMK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class CINKBHNJCIB : EBPAOBBNAON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan DPNABNCGDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer CBCAJLKKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan KCLHELHGLEJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan FIECPBMOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62572D0", Offset = "0x62566D0", VA = "0x1862572D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? MCMMAMJAEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6257530", Offset = "0x6256930", VA = "0x186257530")]
	[Preserve]
	public CINKBHNJCIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x62575A0", Offset = "0x62569A0", VA = "0x1862575A0")]
	public CINKBHNJCIB(TimeSpan KCLHELHGLEJ, [Optional] Action? PLFBBOODFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6257430", Offset = "0x6256830", VA = "0x186257430", Slot = "7")]
	public void OEBPOHMGJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6257120", Offset = "0x6256520", VA = "0x186257120", Slot = "8")]
	public void CJBMJAPHLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x62570F0", Offset = "0x62564F0", VA = "0x1862570F0", Slot = "9")]
	public void AOGMNIMOPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xC34350", Offset = "0xC33750", VA = "0x180C34350")]
	private void HFIBLCOABHF(object OBMKPHNOIOK, ElapsedEventArgs NIOPMEHKBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6257230", Offset = "0x6256630", VA = "0x186257230")]
	private static void HLPLCPKFHAO(TimeSpan MHEHLAEHBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6257190", Offset = "0x6256590", VA = "0x186257190", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OAKOKOJNDPP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string CPMGHEGFDPA;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
	public OAKOKOJNDPP(string INBGNCKHOAH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct FPDIDCFFANP : IEquatable<FPDIDCFFANP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint FLFDEGHODLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int GEDGAJCGDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float KHLMLBNELCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort CJEPCCMMECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort BGNFBOEHOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short BOCKGJJCFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short POFNJFCLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char FNPOOOHEIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char OJAMGBIPGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte ANPCCMIEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte OBFPOANDOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte MBHJCGADAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte IGBHMDNBNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool HKIKNAJGGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool MGBMCFIAFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool PCLPMGGGCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool JJBCNEFIHII;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD8C3C0", Offset = "0xD8B7C0", VA = "0x180D8C3C0")]
	public static FPDIDCFFANP BPBJNIAGHMA(uint IEAOACHJGNM)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD8C3C0", Offset = "0xD8B7C0", VA = "0x180D8C3C0")]
	public static FPDIDCFFANP IKHJMDCEGOO(int COBGOMDJIHE)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6258640", Offset = "0x6257A40", VA = "0x186258640")]
	public static FPDIDCFFANP JPBIEBDFHBN(float HPLOOLFFKBF)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x62585A0", Offset = "0x62579A0", VA = "0x1862585A0")]
	public static FPDIDCFFANP AJOMCGNMKND(byte LCPMCHICNDO, byte JNMLKNBGBJB, byte DDOGKOJOCMJ, byte BIOFBGOPEJC)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x62585A0", Offset = "0x62579A0", VA = "0x1862585A0")]
	public static FPDIDCFFANP GDBAFCLMMCH(bool NKENABDENFE, bool HHMENFHJPAI, bool LOGLNBADNCG, bool OJMNLPBGMDD)
	{
		return default(FPDIDCFFANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62585A0", Offset = "0x62579A0", VA = "0x1862585A0")]
	public static FPDIDCFFANP OGGDINBMJBI(byte CPMCFELKLNF, byte ANAKLINJNHI, byte IGOKJADHBLG, byte MBNAIMELCED)
	{
		return default(FPDIDCFFANP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1848700", Offset = "0x1847B00", VA = "0x181848700")]
	public static bool IDILALBKFJC(FPDIDCFFANP LCALDLBCJKP, FPDIDCFFANP JPKPFNMFEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8A6120", Offset = "0x8A5520", VA = "0x1808A6120", Slot = "4")]
	public bool Equals(FPDIDCFFANP MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62585C0", Offset = "0x62579C0", VA = "0x1862585C0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9497F0", Offset = "0x948BF0", VA = "0x1809497F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6258650", Offset = "0x6257A50", VA = "0x186258650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct AJHNPIJKHCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong HLAEKPIKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long GJDBLBGLJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double JFKDNNBFNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint DBGBMFNAKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint NILNLABJKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int BABAPNODCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int PAGMALMPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float CAGCFKCFJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float KJGFIALPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort CJEPCCMMECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort BGNFBOEHOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort AEAEJCCALIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort ADKKGCFBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short BOCKGJJCFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short POFNJFCLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short GMHCLDFPJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short GAPHONNDACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char FNPOOOHEIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char OJAMGBIPGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char OLBKOKGFIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char DINLEJKJDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte ANPCCMIEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte OBFPOANDOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte MBHJCGADAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte IGBHMDNBNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte LKKCEEMEJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte CNPLDLOFCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NLBAOMHINOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte KNMJEKMHDGP;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6255CA0", Offset = "0x62550A0", VA = "0x186255CA0")]
	public static AJHNPIJKHCK HGJFOBLHCKL(byte LCPMCHICNDO, byte JNMLKNBGBJB, byte DDOGKOJOCMJ, byte BIOFBGOPEJC, byte OGCEGMCCHBA, byte ELNBIKCPIOM, byte IEJMCNCOHJE, byte ILGPNCPIGKM)
	{
		return default(AJHNPIJKHCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NFIIMKMOEBJ<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T BJELOAEOGCE;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3FAC890", Offset = "0x3FABC90", VA = "0x183FAC890")]
	public NFIIMKMOEBJ(T BFPFBHHOEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DLEAOMBJBOA
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2665560", Offset = "0x2664960", VA = "0x182665560")]
	public static NFIIMKMOEBJ<T> HGJFOBLHCKL<T>(T BFPFBHHOEMO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FPMFPNPDPNJ
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x27DECF0", Offset = "0x27DE0F0", VA = "0x1827DECF0")]
	public static IEnumerable<T> PJFHDOJOFIK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static T[] JEDKCGAPDCL<T>(params T[] EJPPNEEBOFN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static IEnumerable<T> DBCALEMDNJH<T>(params T[] EJPPNEEBOFN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10")]
	public static HashSet<T> PGMICLCMNBO<T>(params T[] EJPPNEEBOFN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x27DEC00", Offset = "0x27DE000", VA = "0x1827DEC00")]
	public static KeyValuePair<TKey, TValue> IEOAKOMAKHI<TKey, TValue>([In] TKey NIOPCMHKLMB, [In] TValue PCGOHCLJAPN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2623F10", Offset = "0x2623310", VA = "0x182623F10")]
	public static List<T> DDLPMCCCIDP<T>(IEnumerable<T> LEFKIOOOAEA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NHGLGCEMIKK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string EOADIKCELAF;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E8560", Offset = "0x7E7960", VA = "0x1807E8560")]
	public NHGLGCEMIKK(string CMFFGOOLLIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object FIFHLFOCKGF<T>([In] T EGGAPMGLGIF);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object FMIEOFIIEFN<T>(T EGGAPMGLGIF);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[MEFDBCCLCFL]
public delegate string GFCDPCBCNIB(string PPPBBGPLHME, string? NPJNICJKKMK, bool LNGFHJGKCCF);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MEFDBCCLCFL]
public delegate void CNIMHKJCPBH(string JEBCFBFPEMG);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MEFDBCCLCFL]
public delegate void FBIPJGGLNJB(Exception DAAIKNOAPFE);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object JGLLPEDJPLF();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[MEFDBCCLCFL]
public delegate bool EGHMGGNEDKM();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[MEFDBCCLCFL]
public delegate string FNGFBFMFBGI(object LIKEKIACGIL);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class GNCDJKFEFAJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
	public GNCDJKFEFAJ()
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
