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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
	[Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61E7750", Offset = "0x61E6950", VA = "0x1861E7750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class FDABDDHHEFD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61E20D0", Offset = "0x61E12D0", VA = "0x1861E20D0")]
	public FDABDDHHEFD(bool MAMPLDFOGMF, string ALLPJHPBKGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CFKMKFJMLLE<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> MGHJMJACJCL(CancellationToken IOOGCHJMBIE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IMMGCFHIHOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CFKMKFJMLLE<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MGHJMJACJCL taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3A4EEA0", Offset = "0x3A4E0A0", VA = "0x183A4EEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A4FE80", Offset = "0x3A4F080", VA = "0x183A4FE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource NNJMHFBOJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? MHJHDFDPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? BPFKJLKDDBP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A1AA10", Offset = "0x4A19C10", VA = "0x184A1AA10")]
	[AsyncStateMachine(typeof(CFKMKFJMLLE<>.IMMGCFHIHOM))]
	public Task<TResult> GPNLHLEGHNB(MGHJMJACJCL OPKOLJHKILN, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A9A0", Offset = "0x4A19BA0", VA = "0x184A1A9A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A1AB40", Offset = "0x4A19D40", VA = "0x184A1AB40")]
	public CFKMKFJMLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JMDMMENCNEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> EABLDEADPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T LJLHDNLHLNB;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C050", Offset = "0x3C4B250", VA = "0x183C4C050")]
	public JMDMMENCNEC([In] T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C4B680", Offset = "0x3C4A880", VA = "0x183C4B680", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C4BB00", Offset = "0x3C4AD00", VA = "0x183C4BB00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C4BDF0", Offset = "0x3C4AFF0", VA = "0x183C4BDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OAAJCLPHPKI
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61E77D0", Offset = "0x61E69D0", VA = "0x1861E77D0")]
	public static void EIDPHFHNHLL(this CancellationTokenSource NNJMHFBOJHC, bool EKDJPCIFANI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ACPCFEDMACK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
	public ACPCFEDMACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FFHGPDJOEEK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
	public FFHGPDJOEEK(string OCOJBOBIDMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IGDDAAEMLFK
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28B95C0", Offset = "0x28B87C0", VA = "0x1828B95C0")]
	public static MFGMNPGBIHL DNGOHBNBEGM<T>()
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28B9770", Offset = "0x28B8970", VA = "0x1828B9770")]
	public static MFGMNPGBIHL NPAGFKKICLC<T>([CallerMemberName] string MPENHPFDCDK = "") where T : notnull
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28B9540", Offset = "0x28B8740", VA = "0x1828B9540")]
	public static MFGMNPGBIHL DNGOHBNBEGM<T>(this T KCEAHMBEPHE) where T : notnull
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28B98A0", Offset = "0x28B8AA0", VA = "0x1828B98A0")]
	public static MFGMNPGBIHL OOLDOGLHHFN<T>(this T KCEAHMBEPHE, [CallerMemberName] string MPENHPFDCDK = "") where T : notnull
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28B9800", Offset = "0x28B8A00", VA = "0x1828B9800")]
	public static MFGMNPGBIHL NPAGFKKICLC<T>(this T AOFIGDLFNLH, [CallerMemberName] string MPENHPFDCDK = "") where T : notnull
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61E3460", Offset = "0x61E2660", VA = "0x1861E3460")]
	public static MFGMNPGBIHL NPAGFKKICLC(string OKKJNDELHPE, [CallerMemberName] string MPENHPFDCDK = "")
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61E34E0", Offset = "0x61E26E0", VA = "0x1861E34E0")]
	public static string ODFIJNMAGDD(this object AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool IIKJOGJBJMG();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ACPCFEDMACK]
public delegate long FPBCJINOHOK();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DMPAHAICGJN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static CIIKDOKDPDM OOBKFNHLCLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CIIKDOKDPDM POJMBDFLKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61DFE40", Offset = "0x61DF040", VA = "0x1861DFE40")]
		get
		{
			return default(CIIKDOKDPDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LIBJGILCPOJ HIEFODCIJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61E00D0", Offset = "0x61DF2D0", VA = "0x1861E00D0")]
		get
		{
			return default(LIBJGILCPOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HAIGMKJOFGH KPKPPCNGHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61E02B0", Offset = "0x61DF4B0", VA = "0x1861E02B0")]
		get
		{
			return default(HAIGMKJOFGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool OPMGOIPCCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61DFCC0", Offset = "0x61DEEC0", VA = "0x1861DFCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61DFE90", Offset = "0x61DF090", VA = "0x1861DFE90")]
	public static void ELEILONJFJK([In] CIIKDOKDPDM LGAHDPGJBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61DFBF0", Offset = "0x61DEDF0", VA = "0x1861DFBF0")]
	public static void BNEKJNBCLOP(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61E0180", Offset = "0x61DF380", VA = "0x1861E0180")]
	public static void KJNBPKKLDDE(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2722010", Offset = "0x2721210", VA = "0x182722010")]
	public static void KJNBPKKLDDE<T>(T INFIIIMCAKM, COKMOMNHAFF<T> FFDOAJJEAOK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61E0030", Offset = "0x61DF230", VA = "0x1861E0030")]
	public static void FFMMJMJIEBE(Exception ABPIAOIFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61E0120", Offset = "0x61DF320", VA = "0x1861E0120")]
	public static void JAIALNPKENC(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61E0250", Offset = "0x61DF450", VA = "0x1861E0250")]
	public static void LMDEFGNGKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61E03D0", Offset = "0x61DF5D0", VA = "0x1861E03D0")]
	public static string ODFIJNMAGDD(object GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61DFD30", Offset = "0x61DEF30", VA = "0x1861DFD30")]
	public static long CCEKDPCCAOA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61DFDA0", Offset = "0x61DEFA0", VA = "0x1861DFDA0")]
	public static bool ECONBCEHBDF(bool NKMMDGAKEGM, string FFDOAJJEAOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61E0300", Offset = "0x61DF500", VA = "0x1861E0300")]
	public static double OAMGNJPMLEJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CIIKDOKDPDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly LIBJGILCPOJ HIEFODCIJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly HAIGMKJOFGH KPKPPCNGHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BHONDMFAOHE EOPGCINLHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly FPBCJINOHOK NBFBOPHFFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CPNCGGGGBDO BOLFFFAKJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly IIKJOGJBJMG HMCFCMBPNPB;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BHONDMFAOHE FNFHBGIIECG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FPBCJINOHOK HCJFEDHKLFF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CPNCGGGGBDO KHBEBMLAFEB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly IIKJOGJBJMG BJKIJNHBBCO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly CIIKDOKDPDM NONABGLHMDJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OBLLEJJIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61DEF30", Offset = "0x61DE130", VA = "0x1861DEF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61DF8C0", Offset = "0x61DEAC0", VA = "0x1861DF8C0")]
	public CIIKDOKDPDM([In] LIBJGILCPOJ IJHJFIEFIBO, [In] HAIGMKJOFGH ADLACDPLGAD, BHONDMFAOHE HGABMNEDMOL, FPBCJINOHOK OEEEHEGEGNE, CPNCGGGGBDO KKPMBMLFELM, IIKJOGJBJMG BMOBOCCOOKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61DF1C0", Offset = "0x61DE3C0", VA = "0x1861DF1C0")]
	private static string NDCEICMDBBD(object GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610")]
	private static long MJPLGOLBJNH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	private static string ODANEKAPMJD(string DMCHJABNPHL, string? EGJOOHIODFJ, bool JMAGCPAIPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	private static bool DPPIHPEOHME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61DF0C0", Offset = "0x61DE2C0", VA = "0x1861DF0C0")]
	private static CIIKDOKDPDM HCGNGAHHBKJ()
	{
		return default(CIIKDOKDPDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JHOPFACBIPP
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBOEHNPOOJA ONNEONFHIAP();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HBOEHNPOOJA : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ANGKECGLEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDJAGEBEMAF();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JHLFGBMKOFP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFGJIEPGIDK([In] T MEJMHKPOODP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void CNDEGMLNOIM<T>([In] T INFIIIMCAKM);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CCOIGCNCFCF<T> : IEquatable<CCOIGCNCFCF<T>>, JHLFGBMKOFP<CCOIGCNCFCF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T LJLHDNLHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int ABDHHHCLNNL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E22370", Offset = "0x1E21570", VA = "0x181E22370")]
	public CCOIGCNCFCF([In] T EKDDCPALANJ, int MBGANDEDPDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x49360F0", Offset = "0x49352F0", VA = "0x1849360F0")]
	public static bool FPIEKNKMEBM([In] CCOIGCNCFCF<T> EAIBKNOIIGG, [In] CCOIGCNCFCF<T> PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4935CC0", Offset = "0x4934EC0", VA = "0x184935CC0", Slot = "4")]
	public bool Equals(CCOIGCNCFCF<T> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37B2D50", Offset = "0x37B1F50", VA = "0x1837B2D50", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49367C0", Offset = "0x49359C0", VA = "0x1849367C0")]
	public bool HFGJIEPGIDK([In] CCOIGCNCFCF<T> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4936730", Offset = "0x4935930", VA = "0x184936730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4936C70", Offset = "0x4935E70", VA = "0x184936C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4935710", Offset = "0x4934910", VA = "0x184935710")]
	public void EHCLCENNOFJ([Out] T EKDDCPALANJ, [Out] int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49353D0", Offset = "0x49345D0", VA = "0x1849353D0")]
	public (T, int) DKJGBLAKLJH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4936840", Offset = "0x4935A40", VA = "0x184936840", Slot = "5")]
	private bool NCJOFEMPEIH([In] CCOIGCNCFCF<T> MEJMHKPOODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FIKLBLNPDOP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28794B0", Offset = "0x28786B0", VA = "0x1828794B0")]
	public static CCOIGCNCFCF<T> DHBNKMCPKNO<T>([In] T EKDDCPALANJ, int MBGANDEDPDN) where T : notnull
	{
		return default(CCOIGCNCFCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KCDNAHIBDFK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28FCD70", Offset = "0x28FBF70", VA = "0x1828FCD70")]
	public static bool HFGJIEPGIDK<T, U>([In] T AOFIGDLFNLH, [In] U GLMGCMELGFD) where T : notnull, JHLFGBMKOFP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult PBAGKGCCFNL<T, out TResult>([In] T INFIIIMCAKM);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KMGLOOMNAJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan LBMMHMJDGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? NKNJAGDHGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOFOFFHJEOJ();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHBABICGADC();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHPCHMBALAP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct LIBJGILCPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GKFGLJBCEIL PBFIELMIPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FKDDEJDFNPA FDMBLBPABPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GKFGLJBCEIL BEAKDFGBGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly FKDDEJDFNPA LLCNJKIAFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GKFGLJBCEIL LNMPLODMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly FKDDEJDFNPA KIDOEAPLJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly ALIKLGFOECN LCDHMPPMFIB;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GKFGLJBCEIL EIONHMPACGH;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly FKDDEJDFNPA HFAPGOJJCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GKFGLJBCEIL GOOKIOJNEKJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly FKDDEJDFNPA JOPGCEEGIAO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GKFGLJBCEIL ADJLKGMFJJC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly FKDDEJDFNPA PKNPCLEMFFN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ALIKLGFOECN KGPNPOHEMCA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly LIBJGILCPOJ NONABGLHMDJ;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GKFGLJBCEIL NFCPKOKBJFO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OBLLEJJIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61E4210", Offset = "0x61E3410", VA = "0x1861E4210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9D4520", Offset = "0x9D3720", VA = "0x1809D4520")]
	public LIBJGILCPOJ(GKFGLJBCEIL GPHHGBOAJJP, FKDDEJDFNPA MFMDCOELOMH, GKFGLJBCEIL PAPGLCEDHJL, FKDDEJDFNPA LAGCBFGCNCN, GKFGLJBCEIL EHBDFJHOMLI, FKDDEJDFNPA GEAIFPNAEBG, ALIKLGFOECN MIDMBJJOHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	private static bool BOIFHJNICCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void EALJNLFPEIJ(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	private static bool FJGAHDLJLPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void LDIOACANOAN(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	private static bool ICFDFLEGPDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void KEEJIDJKECE(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void FAFKIGCBFFB(Exception ABPIAOIFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61E4530", Offset = "0x61E3730", VA = "0x1861E4530")]
	private static LIBJGILCPOJ HCGNGAHHBKJ()
	{
		return default(LIBJGILCPOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450")]
	private static bool AIJIGEJCNNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61E43F0", Offset = "0x61E35F0", VA = "0x1861E43F0")]
	public void BNEKJNBCLOP(object FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61E4670", Offset = "0x61E3870", VA = "0x1861E4670")]
	public void KJNBPKKLDDE(object FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A06050", Offset = "0x1A05250", VA = "0x181A06050")]
	public void FFMMJMJIEBE(Exception ABPIAOIFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61E46E0", Offset = "0x61E38E0", VA = "0x1861E46E0")]
	public void KJNBPKKLDDE(IJJHHLHNEDF FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29113F0", Offset = "0x29105F0", VA = "0x1829113F0")]
	public void KJNBPKKLDDE<T>(T INFIIIMCAKM, COKMOMNHAFF<T> FFDOAJJEAOK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2911270", Offset = "0x2910470", VA = "0x182911270")]
	public void BNEKJNBCLOP<T>([In] T INFIIIMCAKM, PMFJKLCPBJO<T> FFDOAJJEAOK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61E4460", Offset = "0x61E3660", VA = "0x1861E4460")]
	public bool ECONBCEHBDF(bool NKMMDGAKEGM, string FFDOAJJEAOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MFGMNPGBIHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string LJLHDNLHLNB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	public MFGMNPGBIHL(string EKDDCPALANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public static string GEOGJCANPGE([In] MFGMNPGBIHL AOFIGDLFNLH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x835A30", Offset = "0x834C30", VA = "0x180835A30")]
	public static MFGMNPGBIHL GEOGJCANPGE(string MEJMHKPOODP)
	{
		return default(MFGMNPGBIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61E5380", Offset = "0x61E4580", VA = "0x1861E5380")]
	public string JMEGPAHCDCC(string PBPEKHGBDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61E53D0", Offset = "0x61E45D0", VA = "0x1861E53D0")]
	public string LBNBGNGHCGF(object KCFAOHEBNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct NFDBFOHCHGK : IEquatable<NFDBFOHCHGK>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "4")]
	public bool Equals(NFDBFOHCHGK MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61E5A50", Offset = "0x61E4C50", VA = "0x1861E5A50", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61E5AA0", Offset = "0x61E4CA0", VA = "0x1861E5AA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61E5AB0", Offset = "0x61E4CB0", VA = "0x1861E5AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[OGJCPCCKFOF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DIGJANEAKHC<T> : IEquatable<DIGJANEAKHC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T LJLHDNLHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool AHHOOKFMMAI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool FHKHOJNNKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x509B900", Offset = "0x509AB00", VA = "0x18509B900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x509C2B0", Offset = "0x509B4B0", VA = "0x18509C2B0")]
	public DIGJANEAKHC([In] T EKDDCPALANJ, bool CDKCGCDABFN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x509BAC0", Offset = "0x509ACC0", VA = "0x18509BAC0")]
	public static bool FPIEKNKMEBM([In] DIGJANEAKHC<T> EAIBKNOIIGG, [In] DIGJANEAKHC<T> PKGAILNKPEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4935CC0", Offset = "0x4934EC0", VA = "0x184935CC0", Slot = "4")]
	public bool Equals(DIGJANEAKHC<T> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x509B200", Offset = "0x509A400", VA = "0x18509B200", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x509BD00", Offset = "0x509AF00", VA = "0x18509BD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x509C200", Offset = "0x509B400", VA = "0x18509C200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KBFNGLIJPJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28FC5E0", Offset = "0x28FB7E0", VA = "0x1828FC5E0")]
	public static DIGJANEAKHC<T> CLBNGCFIPMB<T>([In] T EKDDCPALANJ) where T : notnull
	{
		return default(DIGJANEAKHC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6F0", Offset = "0x28FB8F0", VA = "0x1828FC6F0")]
	public static DIGJANEAKHC<T?> DPHNOHABNOH<T>()
	{
		return default(DIGJANEAKHC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28FC830", Offset = "0x28FBA30", VA = "0x1828FC830")]
	public static bool GLGFONIGLHF<T>([In] this DIGJANEAKHC<T> ADOGBKCCBCK, [Out][NotNullWhen(true)] T EKDDCPALANJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HAIGMKJOFGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr JAIALNPKENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr LMDEFGNGKOM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr MMCALDAGOON;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr PACAOFGGMAE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly HAIGMKJOFGH NONABGLHMDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OBLLEJJIIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61E2B10", Offset = "0x61E1D10", VA = "0x1861E2B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x90BB40", Offset = "0x90AD40", VA = "0x18090BB40")]
	public HAIGMKJOFGH(IntPtr LHNMIBLKHJL, IntPtr PEIKJDODAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void JHKLALKGJHH(string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	private static void OEOJNOOLCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61E2BE0", Offset = "0x61E1DE0", VA = "0x1861E2BE0")]
	private static HAIGMKJOFGH HCGNGAHHBKJ()
	{
		return default(HAIGMKJOFGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KAKKKMGFJIM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr KCDEDDIDCLP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	private KAKKKMGFJIM(IntPtr PEIKJDODAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61E38A0", Offset = "0x61E2AA0", VA = "0x1861E38A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61E37C0", Offset = "0x61E29C0", VA = "0x1861E37C0")]
	public static KAKKKMGFJIM DHBNKMCPKNO(string MPENHPFDCDK)
	{
		return default(KAKKKMGFJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E088A0", Offset = "0x1E07AA0", VA = "0x181E088A0")]
	public static KAKKKMGFJIM DHBNKMCPKNO([In] HAIGMKJOFGH ADLACDPLGAD, string MPENHPFDCDK)
	{
		return default(KAKKKMGFJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E08C10", Offset = "0x1E07E10", VA = "0x181E08C10")]
	public static KAKKKMGFJIM DHBNKMCPKNO([In] HAIGMKJOFGH ADLACDPLGAD, Func<string> MPENHPFDCDK)
	{
		return default(KAKKKMGFJIM);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NKAACCLLNIC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool GHOFCHAJBKG<in TInput, TResult>(TInput BHCBEHDFPNA, [Out] TResult IFJGEIAONPI);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class DCBBEKBCINP : JHOPFACBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class OKGBEOBBPIA : HBOEHNPOOJA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly OKGBEOBBPIA EELHBDDPCDG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool ANGKECGLEDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x61E7870", Offset = "0x61E6A70", VA = "0x1861E7870", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x61E78D0", Offset = "0x61E6AD0", VA = "0x1861E78D0", Slot = "6")]
			public void OnCompleted(Action AGOECHPGPLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			public void KDJAGEBEMAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public OKGBEOBBPIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly DCBBEKBCINP EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private DCBBEKBCINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61DFB30", Offset = "0x61DED30", VA = "0x1861DFB30", Slot = "4")]
		public HBOEHNPOOJA ONNEONFHIAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class CNLNBCEDEKB : JHOPFACBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class NMFJHNFCIHJ : HBOEHNPOOJA, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly NMFJHNFCIHJ EELHBDDPCDG;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool ANGKECGLEDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x61E7670", Offset = "0x61E6870", VA = "0x1861E7670", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x61E7690", Offset = "0x61E6890", VA = "0x1861E7690", Slot = "6")]
			public void OnCompleted(Action AGOECHPGPLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
			public void KDJAGEBEMAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public NMFJHNFCIHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CNLNBCEDEKB EELHBDDPCDG;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private CNLNBCEDEKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61DF970", Offset = "0x61DEB70", VA = "0x1861DF970", Slot = "4")]
		public HBOEHNPOOJA ONNEONFHIAP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OBFDBFIPGHC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OBFDBFIPGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C569E0", Offset = "0x3C55BE0", VA = "0x183C569E0")]
		internal void GAIBHPJCJFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IKPAMPKNPKK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public IKPAMPKNPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3974C50", Offset = "0x3973E50", VA = "0x183974C50")]
		internal void KNBAEECADOJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct EBIOINIPLEP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E08D0", Offset = "0x61DFAD0", VA = "0x1861E08D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DPINJENIHBP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E07C0", Offset = "0x61DF9C0", VA = "0x1861E07C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x893800", Offset = "0x892A00", VA = "0x180893800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct DKPNJJLMMGF<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x509FF70", Offset = "0x509F170", VA = "0x18509FF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x50A00E0", Offset = "0x509F2E0", VA = "0x1850A00E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KFBGHMEGIBH<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3CACB80", Offset = "0x3CABD80", VA = "0x183CACB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CACFA0", Offset = "0x3CAC1A0", VA = "0x183CACFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct ADLDFKPPMJA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61DE5B0", Offset = "0x61DD7B0", VA = "0x1861DE5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61DE7B0", Offset = "0x61DD9B0", VA = "0x1861DE7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JPOBGIHOGCC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public JPOBGIHOGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C569E0", Offset = "0x3C55BE0", VA = "0x183C569E0")]
		internal void CHOMDLLLBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C56A20", Offset = "0x3C55C20", VA = "0x183C56A20")]
		internal void PNKGOPGCEBM(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EEELGPCFOON<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public GHOFCHAJBKG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3405F60", Offset = "0x3405160", VA = "0x183405F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3406610", Offset = "0x3405810", VA = "0x183406610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct LBOLKEECLLN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E39C0", Offset = "0x61E2BC0", VA = "0x1861E39C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61E41B0", Offset = "0x61E33B0", VA = "0x1861E41B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LJHFOBBLFDM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E4DE0", Offset = "0x61E3FE0", VA = "0x1861E4DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61E5320", Offset = "0x61E4520", VA = "0x1861E5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct GFGPEKOEMEG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x38615C0", Offset = "0x38607C0", VA = "0x1838615C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3861D60", Offset = "0x3860F60", VA = "0x183861D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ODCPJOHHACF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x40E9670", Offset = "0x40E8870", VA = "0x1840E9670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x389FCD0", Offset = "0x389EED0", VA = "0x18389FCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NOGIECEJBCL<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4019950", Offset = "0x4018B50", VA = "0x184019950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x401A020", Offset = "0x4019220", VA = "0x18401A020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IJADCLHLCPK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E3580", Offset = "0x61E2780", VA = "0x1861E3580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61E3760", Offset = "0x61E2960", VA = "0x1861E3760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct CIAECNKNPOG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61DEB70", Offset = "0x61DDD70", VA = "0x1861DEB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61DEED0", Offset = "0x61DE0D0", VA = "0x1861DEED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AEAEOALMLKG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61DE820", Offset = "0x61DDA20", VA = "0x1861DE820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61DEB10", Offset = "0x61DDD10", VA = "0x1861DEB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LIPBGKHAKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public LIPBGKHAKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61E4D70", Offset = "0x61E3F70", VA = "0x1861E4D70")]
		internal Task IHCFHPIJKKJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DNCKEILBLFK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E0500", Offset = "0x61DF700", VA = "0x1861E0500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61E0760", Offset = "0x61DF960", VA = "0x1861E0760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GNDEMHCABBI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E28D0", Offset = "0x61E1AD0", VA = "0x1861E28D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61E2AB0", Offset = "0x61E1CB0", VA = "0x1861E2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NCHPEABAPBK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E5690", Offset = "0x61E4890", VA = "0x1861E5690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61E59F0", Offset = "0x61E4BF0", VA = "0x1861E59F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IBLABOFGHDJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E3110", Offset = "0x61E2310", VA = "0x1861E3110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61E3400", Offset = "0x61E2600", VA = "0x1861E3400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OHFAHFCHIBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public OHFAHFCHIBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61E7800", Offset = "0x61E6A00", VA = "0x1861E7800")]
		internal Task CAKBLMDAKBH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct FMMFHBINNAA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E21A0", Offset = "0x61E13A0", VA = "0x1861E21A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61E2400", Offset = "0x61E1600", VA = "0x1861E2400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MMLGJBIOFMM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E54B0", Offset = "0x61E46B0", VA = "0x1861E54B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61E5630", Offset = "0x61E4830", VA = "0x1861E5630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KGHDMNAMCHN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3CB3080", Offset = "0x3CB2280", VA = "0x183CB3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB32D0", Offset = "0x3CB24D0", VA = "0x183CB32D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GCIJJHEKGOK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61E2460", Offset = "0x61E1660", VA = "0x1861E2460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61E2870", Offset = "0x61E1A70", VA = "0x1861E2870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? EAIEMPOELEI;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<NFDBFOHCHGK> PLJFLDABOFF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task NNIDHCJGDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61E6710", Offset = "0x61E5910", VA = "0x1861E6710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61E60E0", Offset = "0x61E52E0", VA = "0x1861E60E0")]
	public static bool ECCJOAPGMMB(this Task PNJMCNKOIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x29CEEB0", Offset = "0x29CE0B0", VA = "0x1829CEEB0")]
	public static Task<T> BNLLFKNOBKC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61E6160", Offset = "0x61E5360", VA = "0x1861E6160")]
	public static Task EKFFCNHOGIL(this Task PNJMCNKOIDP, CancellationToken GMMJMENGHCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x29D1030", Offset = "0x29D0230", VA = "0x1829D1030")]
	public static Task<TResult> EKFFCNHOGIL<TResult>(this Task<TResult> PNJMCNKOIDP, CancellationToken GMMJMENGHCD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x29D1860", Offset = "0x29D0A60", VA = "0x1829D1860")]
	public static TaskCompletionSource<TResult> EKFFCNHOGIL<TResult>(this TaskCompletionSource<TResult> IEGPAPMANBF, CancellationToken GMMJMENGHCD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61E69B0", Offset = "0x61E5BB0", VA = "0x1861E69B0")]
	[AsyncStateMachine(typeof(EBIOINIPLEP))]
	public static void HMKNGJBFIBL(this Task EEEPNFLJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61E6A60", Offset = "0x61E5C60", VA = "0x1861E6A60")]
	[AsyncStateMachine(typeof(DPINJENIHBP))]
	public static void IAELPJCLHAK(this Task EEEPNFLJEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x29D24D0", Offset = "0x29D16D0", VA = "0x1829D24D0")]
	[AsyncStateMachine(typeof(DKPNJJLMMGF<>))]
	public static Task IHLBCBNFENG<TException>(this Task EEEPNFLJEFK) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x29D2690", Offset = "0x29D1890", VA = "0x1829D2690")]
	[AsyncStateMachine(typeof(KFBGHMEGIBH<>))]
	public static Task<T> LDJIIOICGIO<T>(this Task<T> AOFIGDLFNLH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7050", Offset = "0x61E6250", VA = "0x1861E7050")]
	[AsyncStateMachine(typeof(ADLDFKPPMJA))]
	public static Task<TaskStatus> NEEHPNPIHLC(this Task AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x29D2950", Offset = "0x29D1B50", VA = "0x1829D2950")]
	public static (Task<T?>?, Action<T?>?) PCLCFNFKILC<T>([Optional] CancellationToken IOOGCHJMBIE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x29D2850", Offset = "0x29D1A50", VA = "0x1829D2850")]
	[AsyncStateMachine(typeof(EEELGPCFOON<, >))]
	public static Task<List<TResult>> MJLCAJOKEBI<TResult, TInput>(this Task<List<TInput>> PNJMCNKOIDP, GHOFCHAJBKG<TInput, TResult> IONNDFNHFOE) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61E5CE0", Offset = "0x61E4EE0", VA = "0x1861E5CE0")]
	[AsyncStateMachine(typeof(LBOLKEECLLN))]
	public static Task BKBGPOCHPIH(Task EEEPNFLJEFK, CancellationToken ALPALKHHHJG, Func<CancellationToken, Task> BLLFGENBMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61E5E10", Offset = "0x61E5010", VA = "0x1861E5E10")]
	[AsyncStateMachine(typeof(LJHFOBBLFDM))]
	public static Task DHGDNEAMGKP(Func<CancellationToken, Task> FKHEPIFNNCK, TimeSpan FJBGLIDGKNL, [Optional] CancellationToken ALPALKHHHJG, [Optional] Action<OperationCanceledException>? EIMONALJHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x29CF000", Offset = "0x29CE200", VA = "0x1829CF000")]
	[AsyncStateMachine(typeof(GFGPEKOEMEG<>))]
	public static Task<T> DHGDNEAMGKP<T>(Func<CancellationToken, Task<T>> FKHEPIFNNCK, TimeSpan FJBGLIDGKNL, [Optional] CancellationToken ALPALKHHHJG, [Optional] Func<OperationCanceledException, T>? EIMONALJHBP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x29D2150", Offset = "0x29D1350", VA = "0x1829D2150")]
	[AsyncStateMachine(typeof(ODCPJOHHACF<>))]
	public static Task<IEnumerable<Task<T>>> EPOAKODPFJA<T>(IEnumerable<Task<T>> AAHHMGACCOB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x29D2230", Offset = "0x29D1430", VA = "0x1829D2230")]
	[AsyncStateMachine(typeof(NOGIECEJBCL<, , , >))]
	public static Task<(T1, T2, T3, T4)> FFNPCPKNJGM<T1, T2, T3, T4>(Task<T1> OOCGPNLGPEE, Task<T2> FMMPOAADLPM, Task<T3> DKPNGKAKJLB, Task<T4> APANDBKJPHE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61E5BF0", Offset = "0x61E4DF0", VA = "0x1861E5BF0")]
	[AsyncStateMachine(typeof(IJADCLHLCPK))]
	public static Task BCCJDDNIPLN(Func<bool> NKMMDGAKEGM, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61E5AE0", Offset = "0x61E4CE0", VA = "0x1861E5AE0")]
	[AsyncStateMachine(typeof(CIAECNKNPOG))]
	public static Task BCCJDDNIPLN(Func<bool> NKMMDGAKEGM, TimeSpan PGIHNBMGMIH, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61E7340", Offset = "0x61E6540", VA = "0x1861E7340")]
	[AsyncStateMachine(typeof(AEAEOALMLKG))]
	public static Task PKGLDLLKMPK(Func<bool> NKMMDGAKEGM, TimeSpan FJBGLIDGKNL, [Optional] CancellationToken IOOGCHJMBIE, [Optional] Action<OperationCanceledException>? EIMONALJHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61E7470", Offset = "0x61E6670", VA = "0x1861E7470")]
	[AsyncStateMachine(typeof(DNCKEILBLFK))]
	public static Task PKGLDLLKMPK(Func<bool> NKMMDGAKEGM, TimeSpan FJBGLIDGKNL, TimeSpan PGIHNBMGMIH, [Optional] CancellationToken IOOGCHJMBIE, [Optional] Action<OperationCanceledException>? EIMONALJHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7140", Offset = "0x61E6340", VA = "0x1861E7140")]
	[AsyncStateMachine(typeof(GNDEMHCABBI))]
	public static Task NEMABAOLGPK(Func<bool> NKMMDGAKEGM, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61E7230", Offset = "0x61E6430", VA = "0x1861E7230")]
	[AsyncStateMachine(typeof(NCHPEABAPBK))]
	public static Task NEMABAOLGPK(Func<bool> NKMMDGAKEGM, TimeSpan PGIHNBMGMIH, [Optional] CancellationToken IOOGCHJMBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61E6C50", Offset = "0x61E5E50", VA = "0x1861E6C50")]
	[AsyncStateMachine(typeof(IBLABOFGHDJ))]
	public static Task JAHKGBHAHGN(Func<bool> NKMMDGAKEGM, TimeSpan FJBGLIDGKNL, [Optional] CancellationToken IOOGCHJMBIE, [Optional] Action<OperationCanceledException>? EIMONALJHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61E6B10", Offset = "0x61E5D10", VA = "0x1861E6B10")]
	[AsyncStateMachine(typeof(FMMFHBINNAA))]
	public static Task JAHKGBHAHGN(Func<bool> NKMMDGAKEGM, TimeSpan FJBGLIDGKNL, TimeSpan PGIHNBMGMIH, [Optional] CancellationToken IOOGCHJMBIE, [Optional] Action<OperationCanceledException>? EIMONALJHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61E6E90", Offset = "0x61E6090", VA = "0x1861E6E90")]
	[Obsolete]
	[AsyncStateMachine(typeof(MMLGJBIOFMM))]
	public static Task KIOCLOEGHBA(this Task PNJMCNKOIDP, Action BKEFCHDBONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x29D25A0", Offset = "0x29D17A0", VA = "0x1829D25A0")]
	[Obsolete]
	[AsyncStateMachine(typeof(KGHDMNAMCHN<>))]
	public static Task KIOCLOEGHBA<T>(this Task<T> PNJMCNKOIDP, Action<T> BKEFCHDBONF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61E6780", Offset = "0x61E5980", VA = "0x1861E6780")]
	private static void GHGHIFCJCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61E63B0", Offset = "0x61E55B0", VA = "0x1861E63B0")]
	public static bool FDLKMOBMEOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61E6830", Offset = "0x61E5A30", VA = "0x1861E6830")]
	private static void GOKDBCHCJLF(SynchronizationContext EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61E6D80", Offset = "0x61E5F80", VA = "0x1861E6D80")]
	private static void JBBHFDPOBID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61E6010", Offset = "0x61E5210", VA = "0x1861E6010")]
	public static void EAHJCLGENBE([Optional] string? FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61E6FD0", Offset = "0x61E61D0", VA = "0x1861E6FD0")]
	public static void NAGECAFGBGB([Optional] string? FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61E6110", Offset = "0x61E5310", VA = "0x1861E6110")]
	public static JHOPFACBIPP EIDFKHNHGPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61E6F80", Offset = "0x61E6180", VA = "0x1861E6F80")]
	public static JHOPFACBIPP LFOFMNKMCNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61E5F40", Offset = "0x61E5140", VA = "0x1861E5F40")]
	[AsyncStateMachine(typeof(GCIJJHEKGOK))]
	public static Task DMNBLIHCDEL(Func<Task> CMJCJMMJFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PAAFOJGLPBB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
	public PAAFOJGLPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class KBFEIEBEKJO : PPKNINPFDGC
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly PPKNINPFDGC EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime AHNBDDKOHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61E38B0", Offset = "0x61E2AB0", VA = "0x1861E38B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset NMAKLDCILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61E38F0", Offset = "0x61E2AF0", VA = "0x1861E38F0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KBFEIEBEKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface PPKNINPFDGC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime AHNBDDKOHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset NMAKLDCILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class EHBBIPCLCAB
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long NDNNPJIJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61E1BD0", Offset = "0x61E0DD0", VA = "0x1861E1BD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long JPBJHFKLKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61E18D0", Offset = "0x61E0AD0", VA = "0x1861E18D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double IJKNAIFDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61E1AF0", Offset = "0x61E0CF0", VA = "0x1861E1AF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double NBMGJFNOFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61E1C20", Offset = "0x61E0E20", VA = "0x1861E1C20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double DDMAJDGMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x61E1D50", Offset = "0x61E0F50", VA = "0x1861E1D50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double IFCDJJBNFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61E1AA0", Offset = "0x61E0CA0", VA = "0x1861E1AA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61E1DA0", Offset = "0x61E0FA0", VA = "0x1861E1DA0")]
	public static double PILAAGKNNKD(long ENDGIIOLJJF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61E1A10", Offset = "0x61E0C10", VA = "0x1861E1A10")]
	public static double ECPDJIKHLHL(long ENDGIIOLJJF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61E1920", Offset = "0x61E0B20", VA = "0x1861E1920")]
	public static double CALCIMIJOGL(double NDACBFDKEPP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61E1B40", Offset = "0x61E0D40", VA = "0x1861E1B40")]
	public static long FNDEBGNCGIF(long AJKELOHAHIE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61E1C70", Offset = "0x61E0E70", VA = "0x1861E1C70")]
	public static long KLNPFJHJAGF(long KDKONOGFHAN, long IHGHCLOCECB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61E1C80", Offset = "0x61E0E80", VA = "0x1861E1C80")]
	public static double MJDAAHOKPMK(long KDKONOGFHAN, long IHGHCLOCECB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61E19B0", Offset = "0x61E0BB0", VA = "0x1861E19B0")]
	public static double CHMNMFFNIMD(long KDKONOGFHAN, long IHGHCLOCECB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class PGBEKHEBHBL : KMGLOOMNAJE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan PDFDOCDMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer LCCLFFMGBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan FJBGLIDGKNL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan LBMMHMJDGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61E7A90", Offset = "0x61E6C90", VA = "0x1861E7A90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? NKNJAGDHGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61E8110", Offset = "0x61E7310", VA = "0x1861E8110")]
	[Preserve]
	public PGBEKHEBHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61E7EC0", Offset = "0x61E70C0", VA = "0x1861E7EC0")]
	public PGBEKHEBHBL(TimeSpan FJBGLIDGKNL, [Optional] Action? IGMEHNKDNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61E7C90", Offset = "0x61E6E90", VA = "0x1861E7C90", Slot = "7")]
	public void EOFOFFHJEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DE0", Offset = "0x61E6FE0", VA = "0x1861E7DE0", Slot = "8")]
	public void KHBABICGADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61E7D20", Offset = "0x61E6F20", VA = "0x1861E7D20", Slot = "9")]
	public void IHPCHMBALAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xC31C70", Offset = "0xC30E70", VA = "0x180C31C70")]
	private void PFPHGLAPPOG(object KCEAHMBEPHE, ElapsedEventArgs GEGEICIDOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7D50", Offset = "0x61E6F50", VA = "0x1861E7D50")]
	private static void JOPDMPHPLDH(TimeSpan ADGLBGONJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7BF0", Offset = "0x61E6DF0", VA = "0x1861E7BF0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OGJCPCCKFOF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string KDOFONMEOJB;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
	public OGJCPCCKFOF(string IFOILHPJELE)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct EGJBCJMPCEF : IEquatable<EGJBCJMPCEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint BMIFFJMBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int DNBGBCEJANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float APIAPKEOGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort LJKOGGLAKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort PLAIFIEOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short PICKBHIAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short BKKKABHMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char BCBAPNFDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char GINJMJPPFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte AKDJAILBIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte NCGDHPLDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte ICNFBKLDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte BFLJJJIDDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool PLDJBMPOJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool JCBJGAEDENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool IGJKIHOOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool FFGACDIMDAG;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static EGJBCJMPCEF OAHKKDLPOID(uint IHNONGIOKKE)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static EGJBCJMPCEF NKPAJDLCLKC(int MIAMIDGGLJF)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A50", Offset = "0x61DFC50", VA = "0x1861E0A50")]
	public static EGJBCJMPCEF CCJDPJCHOBH(float GAEMOBOFAFL)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A30", Offset = "0x61DFC30", VA = "0x1861E0A30")]
	public static EGJBCJMPCEF FJKBFFAMHHN(byte AKDOGFFJNNH, byte JHGFPMAOANC, byte LGPLDMEJAAN, byte LFLMLNHFPCD)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A30", Offset = "0x61DFC30", VA = "0x1861E0A30")]
	public static EGJBCJMPCEF KKAOIIBLELK(bool FFMPJGDPNIJ, bool MFEODOALLIP, bool IFMCNHBEDIA, bool OKACDNKMFKC)
	{
		return default(EGJBCJMPCEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A30", Offset = "0x61DFC30", VA = "0x1861E0A30")]
	public static EGJBCJMPCEF BDADGODEGNG(byte DGHKCOBPFNL, byte LOFOJLGJEHP, byte AALIDNILCHB, byte KHNMCDKLOMB)
	{
		return default(EGJBCJMPCEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x18A5D90", Offset = "0x18A4F90", VA = "0x1818A5D90")]
	public static bool FPIEKNKMEBM(EGJBCJMPCEF DEHAFGPDPHM, EGJBCJMPCEF FAFKEFEMLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x88E910", Offset = "0x88DB10", VA = "0x18088E910", Slot = "4")]
	public bool Equals(EGJBCJMPCEF MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61E0A60", Offset = "0x61DFC60", VA = "0x1861E0A60", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x93E030", Offset = "0x93D230", VA = "0x18093E030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61E0AE0", Offset = "0x61DFCE0", VA = "0x1861E0AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HMFHLPCHBLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong FBHLGDGOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long NOEFONCNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double GNMMIGLBLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint BPHIHBKEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint EAELECPLMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int DMIHDCBABBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int DDDNDFMIPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float CGMNIIJJHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float KHEIOGFOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort LJKOGGLAKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort PLAIFIEOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort KMOLDMFCMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort LECAEOOGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short PICKBHIAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short BKKKABHMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short GEMMBBGLKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short AHODHKOODEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char BCBAPNFDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char GINJMJPPFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char OJKJHDGKCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char MNCDMOLCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte AKDJAILBIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte NCGDHPLDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte ICNFBKLDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte BFLJJJIDDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte DNOKKBNDHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BICHLFEDOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte PDMFCBEBHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte LOPLCFJPGDK;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61E30C0", Offset = "0x61E22C0", VA = "0x1861E30C0")]
	public static HMFHLPCHBLO DHBNKMCPKNO(byte AKDOGFFJNNH, byte JHGFPMAOANC, byte LGPLDMEJAAN, byte LFLMLNHFPCD, byte BDKOFKLAADH, byte DBJIAAMBLCJ, byte KOJHLFDDMKG, byte NLPADFDONNH)
	{
		return default(HMFHLPCHBLO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct HJKNOAMBKLP : IEquatable<HJKNOAMBKLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte ANGBFCGPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool CNAEFEDKEKJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x235CF40", Offset = "0x235C140", VA = "0x18235CF40")]
	public static HJKNOAMBKLP FJKBFFAMHHN(byte BFPHLONCIFD)
	{
		return default(HJKNOAMBKLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x235CF40", Offset = "0x235C140", VA = "0x18235CF40")]
	public static HJKNOAMBKLP KKAOIIBLELK(bool GJKNBCDINIG)
	{
		return default(HJKNOAMBKLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61E2E40", Offset = "0x61E2040", VA = "0x1861E2E40")]
	public static bool FPIEKNKMEBM(HJKNOAMBKLP DEHAFGPDPHM, HJKNOAMBKLP FAFKEFEMLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5437640", Offset = "0x5436840", VA = "0x185437640", Slot = "4")]
	public bool Equals(HJKNOAMBKLP MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61E2DB0", Offset = "0x61E1FB0", VA = "0x1861E2DB0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61E2E50", Offset = "0x61E2050", VA = "0x1861E2E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61E2E60", Offset = "0x61E2060", VA = "0x1861E2E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KAAFCGJGOJH<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly T ALFIMONHDDI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2760", Offset = "0x3CA1960", VA = "0x183CA2760")]
	public KAAFCGJGOJH(T BHFFFAMOIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FDGCPOLLNCK
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x286CA10", Offset = "0x286BC10", VA = "0x18286CA10")]
	public static KAAFCGJGOJH<T> DHBNKMCPKNO<T>(T BHFFFAMOIHO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CAKLEJMHIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x26C4E40", Offset = "0x26C4040", VA = "0x1826C4E40")]
	public static IEnumerable<T> LHAJFAFMOAB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static T[] NODKOCBCFAM<T>(params T[] CDACNCNJDFC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static IEnumerable<T> NDMPDLBJCIC<T>(params T[] CDACNCNJDFC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3FD0", VA = "0x1826C4DD0")]
	public static HashSet<T> MNKMGLHNLFI<T>(params T[] CDACNCNJDFC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x26C4E60", Offset = "0x26C4060", VA = "0x1826C4E60")]
	public static KeyValuePair<TKey, TValue> MKMBBMCJMNL<TKey, TValue>([In] TKey GHBNLDGJPCB, [In] TValue EKDDCPALANJ) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x26C4DD0", Offset = "0x26C3FD0", VA = "0x1826C4DD0")]
	public static List<T> IKCMJFCIDNG<T>(IEnumerable<T> CNMJLBIMKJD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NOKNADFMENB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly string ALGOCBFPOAC;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
	public NOKNADFMENB(string JFGPAIHHEJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object PMFJKLCPBJO<T>([In] T FJIDAJDLPID);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object COKMOMNHAFF<T>(T FJIDAJDLPID);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[ACPCFEDMACK]
public delegate string CPNCGGGGBDO(string DMCHJABNPHL, string? EGJOOHIODFJ, bool JMAGCPAIPOH);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[ACPCFEDMACK]
public delegate void FKDDEJDFNPA(string FFDOAJJEAOK);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[ACPCFEDMACK]
public delegate void ALIKLGFOECN(Exception ABPIAOIFKLH);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object IJJHHLHNEDF();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[ACPCFEDMACK]
public delegate bool GKFGLJBCEIL();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[ACPCFEDMACK]
public delegate string BHONDMFAOHE(object GLMGCMELGFD);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[AttributeUsage(AttributeTargets.Enum)]
public class GMIJIPKBKDG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
	public GMIJIPKBKDG()
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
