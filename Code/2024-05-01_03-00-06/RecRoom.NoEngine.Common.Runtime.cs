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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C95D0", Offset = "0x62C83D0", VA = "0x1862C95D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class EHMCNLPNCEH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62C4280", Offset = "0x62C3080", VA = "0x1862C4280")]
	public EHMCNLPNCEH(bool EKFEMAPNOPL, string IOMGENKIEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BDGKDAPGLOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JBFJLOKBGKA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> LEOGLNDFBGE(CancellationToken KANPDHELHMD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DHJGKNCKKNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public JBFJLOKBGKA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public LEOGLNDFBGE taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x514B3E0", Offset = "0x514A1E0", VA = "0x18514B3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x514C3C0", Offset = "0x514B1C0", VA = "0x18514C3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource PGKPKKCBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? NJDMFLLJJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? JNHMCNFCJAE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C18430", Offset = "0x3C17230", VA = "0x183C18430")]
	[AsyncStateMachine(typeof(JBFJLOKBGKA<>.DHJGKNCKKNL))]
	public Task<TResult> KPBPPFNOAEB(LEOGLNDFBGE CJICDDKCAEF, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C183C0", Offset = "0x3C171C0", VA = "0x183C183C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C18560", Offset = "0x3C17360", VA = "0x183C18560")]
	public JBFJLOKBGKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class MOIAJIOLHOF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> CIOANLNFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T ACOGNAIJGCD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x38D45B0", Offset = "0x38D33B0", VA = "0x1838D45B0")]
	public MOIAJIOLHOF([In] T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FBAFC0", Offset = "0x3FB9DC0", VA = "0x183FBAFC0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB5A0", Offset = "0x3FBA3A0", VA = "0x183FBB5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FBB910", Offset = "0x3FBA710", VA = "0x183FBB910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class DOJFCBGPLOD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static MOIAJIOLHOF<T> KHDJPNLCMFA<T>([In] T DIBNBLEEFNN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ECENODCOFAP
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62C3F00", Offset = "0x62C2D00", VA = "0x1862C3F00")]
	public static void ILBHBBFHMKL(this CancellationTokenSource PGKPKKCBGGG, bool OABGDOHMELL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class BNNKMJLNIAL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	public BNNKMJLNIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class KNIGENDFPDF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	public KNIGENDFPDF(string IAGIIBGBICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEDAGHDAFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x295DE80", Offset = "0x295CC80", VA = "0x18295DE80")]
	public static HPEKHJNCCIK MCKJAEMNOFE<T>()
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x295DC70", Offset = "0x295CA70", VA = "0x18295DC70")]
	public static HPEKHJNCCIK HAJPGCMFIGA<T>([CallerMemberName] string PHEKPMAPPHM = "") where T : notnull
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x295DE00", Offset = "0x295CC00", VA = "0x18295DE00")]
	public static HPEKHJNCCIK MCKJAEMNOFE<T>(this T KDBMKOJJIJP) where T : notnull
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x295DA50", Offset = "0x295C850", VA = "0x18295DA50")]
	public static HPEKHJNCCIK GEKCELCJHBC<T>(this T KDBMKOJJIJP, [CallerMemberName] string PHEKPMAPPHM = "") where T : notnull
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x295DBD0", Offset = "0x295C9D0", VA = "0x18295DBD0")]
	public static HPEKHJNCCIK HAJPGCMFIGA<T>(this T ILACEKALGJH, [CallerMemberName] string PHEKPMAPPHM = "") where T : notnull
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62C8370", Offset = "0x62C7170", VA = "0x1862C8370")]
	public static HPEKHJNCCIK HAJPGCMFIGA(string IOJILDBHLDP, [CallerMemberName] string PHEKPMAPPHM = "")
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62C82D0", Offset = "0x62C70D0", VA = "0x1862C82D0")]
	public static string ENDOFCPFACO(this object ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool PGPMPBNIMII();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BNNKMJLNIAL]
public delegate long DMOEOANHHAF();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GHLNKDMJGIA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static DOPAJLOEFLD KAGOGEGLNCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DOPAJLOEFLD PALONEPBLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62C5B70", Offset = "0x62C4970", VA = "0x1862C5B70")]
		get
		{
			return default(DOPAJLOEFLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HDFPOPBANHO NAHHDKEOJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62C5A80", Offset = "0x62C4880", VA = "0x1862C5A80")]
		get
		{
			return default(HDFPOPBANHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NANBOFKENDO JKNNHDHCLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62C5D60", Offset = "0x62C4B60", VA = "0x1862C5D60")]
		get
		{
			return default(NANBOFKENDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool JLDFNFJFDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62C5CF0", Offset = "0x62C4AF0", VA = "0x1862C5CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62C5670", Offset = "0x62C4470", VA = "0x1862C5670")]
	public static void EGPGKPAJEKD([In] DOPAJLOEFLD FDAKIHHBNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62C5C20", Offset = "0x62C4A20", VA = "0x1862C5C20")]
	public static void OEJDKKHBHHB(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62C59B0", Offset = "0x62C47B0", VA = "0x1862C59B0")]
	public static void GIAKCKJJMPA(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28C3EF0", Offset = "0x28C2CF0", VA = "0x1828C3EF0")]
	public static void GIAKCKJJMPA<T>(T PNJHNPALLNI, BIGPKJIHBLA<T> HPJAAILCALJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62C5AD0", Offset = "0x62C48D0", VA = "0x1862C5AD0")]
	public static void KHNNEHINOKH(Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62C5BC0", Offset = "0x62C49C0", VA = "0x1862C5BC0")]
	public static void NFKDPBBOICB(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62C5880", Offset = "0x62C4680", VA = "0x1862C5880")]
	public static void FEKPEMBGLDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62C5810", Offset = "0x62C4610", VA = "0x1862C5810")]
	public static string ENDOFCPFACO(object EIFMADKIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62C5560", Offset = "0x62C4360", VA = "0x1862C5560")]
	public static long CDHFDJFKNGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62C55D0", Offset = "0x62C43D0", VA = "0x1862C55D0")]
	public static bool EEEHFMKKGND(bool CBAOJAAOCLI, string HPJAAILCALJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62C58E0", Offset = "0x62C46E0", VA = "0x1862C58E0")]
	public static double GEBJNBEDJPL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct DOPAJLOEFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HDFPOPBANHO NAHHDKEOJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly NANBOFKENDO JKNNHDHCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly FMELGGDOCGA MJIIBBJNKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DMOEOANHHAF HKOBELOGNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JFGOIDOHFOI ILOOOHGKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly PGPMPBNIMII KCCPHDKKOND;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly FMELGGDOCGA OOMHLGGOHLL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DMOEOANHHAF DGDMECIHCEM;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JFGOIDOHFOI BFLADIOMIAE;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly PGPMPBNIMII HNNLIINFCFL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly DOPAJLOEFLD CNCELEPFOGN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JODNNLIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62C3500", Offset = "0x62C2300", VA = "0x1862C3500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62C3E50", Offset = "0x62C2C50", VA = "0x1862C3E50")]
	public DOPAJLOEFLD([In] HDFPOPBANHO PJLEBNGLCGA, [In] NANBOFKENDO LEFHAPMGIGE, FMELGGDOCGA IEMHNFLPACL, DMOEOANHHAF BEAIMBPEJOC, JFGOIDOHFOI PMEHHPECIBP, PGPMPBNIMII HBNKMIMLEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62C34C0", Offset = "0x62C22C0", VA = "0x1862C34C0")]
	private static string AOOOEMAMLEH(object EIFMADKIHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0")]
	private static long FCAKFLGMEGL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	private static string FACEDLPECHG(string INOMBDBKIKO, string? NLGJAGOIBCG, bool LCDBECDGJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	private static bool NGJCNHHJHLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62C3690", Offset = "0x62C2490", VA = "0x1862C3690")]
	private static DOPAJLOEFLD OHCAEKBGMDI()
	{
		return default(DOPAJLOEFLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AOFAMNGBLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCOBGLEIPFB AGKNNCIHMJP();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MCOBGLEIPFB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IHFMGFBNHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOKGMELIOIL();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OBICLNGMMNH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGMAFNDJCNK([In] T GGINNHLAMLI);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void PKFCBGFMMCP<T>([In] T PNJHNPALLNI);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KGGLAECGFEI<T> : IEquatable<KGGLAECGFEI<T>>, OBICLNGMMNH<KGGLAECGFEI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T ACOGNAIJGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int PCBIBNEPCKE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E45280", Offset = "0x1E44080", VA = "0x181E45280")]
	public KGGLAECGFEI([In] T DIBNBLEEFNN, int AELAKOMEEDP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB510", Offset = "0x3CEA310", VA = "0x183CEB510")]
	public static bool OFKPFEHPLBH([In] KGGLAECGFEI<T> DCJCHFKPCOP, [In] KGGLAECGFEI<T> IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB1C0", Offset = "0x3CE9FC0", VA = "0x183CEB1C0", Slot = "4")]
	public bool Equals(KGGLAECGFEI<T> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x391DF10", Offset = "0x391CD10", VA = "0x18391DF10", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB3B0", Offset = "0x3CEA1B0", VA = "0x183CEB3B0")]
	public bool HGMAFNDJCNK([In] KGGLAECGFEI<T> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB240", Offset = "0x3CEA040", VA = "0x183CEB240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB950", Offset = "0x3CEA750", VA = "0x183CEB950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB6D0", Offset = "0x3CEA4D0", VA = "0x183CEB6D0")]
	public void PHDHBCEACMN([Out] T DIBNBLEEFNN, [Out] int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB000", Offset = "0x3CE9E00", VA = "0x183CEB000")]
	public (T, int) CMHIBDGAPJC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB170", Offset = "0x3CE9F70", VA = "0x183CEB170", Slot = "5")]
	private bool DEJDDKOMDAI([In] KGGLAECGFEI<T> GGINNHLAMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LCAMJPCCGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x295BA10", Offset = "0x295A810", VA = "0x18295BA10")]
	public static KGGLAECGFEI<T> KHDJPNLCMFA<T>([In] T DIBNBLEEFNN, int AELAKOMEEDP) where T : notnull
	{
		return default(KGGLAECGFEI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LLICPILJAKE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2965730", Offset = "0x2964530", VA = "0x182965730")]
	public static bool HGMAFNDJCNK<T, U>([In] T ILACEKALGJH, [In] U EIFMADKIHON) where T : notnull, OBICLNGMMNH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult JKKEMMFMAGL<T, out TResult>([In] T PNJHNPALLNI);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AHDFOAPPDFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan MOKLCGPENAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? PAKKKPJGGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIAKOELMJPA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABNGBLJBJCE();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMCOABBNLJH();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct HDFPOPBANHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GBDHGEAGKNO LEKBKLGIEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JHCPEAJEECJ FCOKLAEBNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly GBDHGEAGKNO AIFPDNEADHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly JHCPEAJEECJ FIEJIEIAEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly GBDHGEAGKNO BJPOCCEOONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly JHCPEAJEECJ LCGCIOLKJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly LKJEMAOGMPH KNAOFMCLAND;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GBDHGEAGKNO PPEOJIBAAPF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JHCPEAJEECJ IMNIJINABKP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GBDHGEAGKNO GLPKFDBIPKJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JHCPEAJEECJ EGLEFEDBFON;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GBDHGEAGKNO EFKINGJDLLH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly JHCPEAJEECJ ILGFEGBMGNG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LKJEMAOGMPH NGOJNOLFCKI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HDFPOPBANHO CNCELEPFOGN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GBDHGEAGKNO DGNOHLKEJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JODNNLIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62C5FD0", Offset = "0x62C4DD0", VA = "0x1862C5FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9C9DD0", Offset = "0x9C8BD0", VA = "0x1809C9DD0")]
	public HDFPOPBANHO(GBDHGEAGKNO MNAAOIFHGNE, JHCPEAJEECJ LDAIKOKFKDJ, GBDHGEAGKNO AOAKPPPGKIO, JHCPEAJEECJ JICKBNKODHG, GBDHGEAGKNO PPDMOIKOCCK, JHCPEAJEECJ ANLHDHFPIJI, LKJEMAOGMPH EFLCCNCADJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	private static bool BMIOEIIDPGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void PFDHENPJCEG(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	private static bool FDEAPPBJDIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void MKLMCGKOEIL(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	private static bool KLEMONBDANC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void FGFCFHGHNEA(string HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void OBEKMPAHBDF(Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62C6440", Offset = "0x62C5240", VA = "0x1862C6440")]
	private static HDFPOPBANHO OHCAEKBGMDI()
	{
		return default(HDFPOPBANHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
	private static bool MEDJBICLNLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62C63D0", Offset = "0x62C51D0", VA = "0x1862C63D0")]
	public void OEJDKKHBHHB(object HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62C6280", Offset = "0x62C5080", VA = "0x1862C6280")]
	public void GIAKCKJJMPA(object HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A21EB0", Offset = "0x1A20CB0", VA = "0x181A21EB0")]
	public void KHNNEHINOKH(Exception MCKOJGJOINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x62C62F0", Offset = "0x62C50F0", VA = "0x1862C62F0")]
	public void GIAKCKJJMPA(BCPPONHIHOL HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28E5AD0", Offset = "0x28E48D0", VA = "0x1828E5AD0")]
	public void GIAKCKJJMPA<T>(T PNJHNPALLNI, BIGPKJIHBLA<T> HPJAAILCALJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28E5B90", Offset = "0x28E4990", VA = "0x1828E5B90")]
	public void OEJDKKHBHHB<T>([In] T PNJHNPALLNI, OGPGHGDFEEI<T> HPJAAILCALJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x62C61B0", Offset = "0x62C4FB0", VA = "0x1862C61B0")]
	public bool EEEHFMKKGND(bool CBAOJAAOCLI, string HPJAAILCALJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HPEKHJNCCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string ACOGNAIJGCD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	public HPEKHJNCCIK(string DIBNBLEEFNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410")]
	public static string BPFJNEHKLMP([In] HPEKHJNCCIK ILACEKALGJH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x819E90", Offset = "0x818C90", VA = "0x180819E90")]
	public static HPEKHJNCCIK BPFJNEHKLMP(string GGINNHLAMLI)
	{
		return default(HPEKHJNCCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62C7B50", Offset = "0x62C6950", VA = "0x1862C7B50")]
	public string MLEPGKNMEKF(string FEOMCLKJGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62C7A70", Offset = "0x62C6870", VA = "0x1862C7A70")]
	public string FJMGCNICCEH(object DGENKJIDIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x881410", Offset = "0x880210", VA = "0x180881410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct CDPLPCBKJFN : IEquatable<CDPLPCBKJFN>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "4")]
	public bool Equals(CDPLPCBKJFN GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62C2250", Offset = "0x62C1050", VA = "0x1862C2250", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62C22A0", Offset = "0x62C10A0", VA = "0x1862C22A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62C22B0", Offset = "0x62C10B0", VA = "0x1862C22B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AHPJOKJFFLN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BOEJMFJFKMA<T> : IEquatable<BOEJMFJFKMA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T ACOGNAIJGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool ELOHJNLJMDG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IKDBJLFJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x488A5C0", Offset = "0x48893C0", VA = "0x18488A5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x488B6B0", Offset = "0x488A4B0", VA = "0x18488B6B0")]
	public BOEJMFJFKMA([In] T DIBNBLEEFNN, bool BMLHGMDNLHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x488B1D0", Offset = "0x4889FD0", VA = "0x18488B1D0")]
	public static bool OFKPFEHPLBH([In] BOEJMFJFKMA<T> DCJCHFKPCOP, [In] BOEJMFJFKMA<T> IKGIOHGPKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB1C0", Offset = "0x3CE9FC0", VA = "0x183CEB1C0", Slot = "4")]
	public bool Equals(BOEJMFJFKMA<T> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x488A8D0", Offset = "0x48896D0", VA = "0x18488A8D0", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x488AD10", Offset = "0x4889B10", VA = "0x18488AD10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x488B600", Offset = "0x488A400", VA = "0x18488B600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class FBIENEEEHNH
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28A13E0", Offset = "0x28A01E0", VA = "0x1828A13E0")]
	public static BOEJMFJFKMA<T> PLKMJKDBMDJ<T>([In] T DIBNBLEEFNN) where T : notnull
	{
		return default(BOEJMFJFKMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28A12B0", Offset = "0x28A00B0", VA = "0x1828A12B0")]
	public static BOEJMFJFKMA<T?> CGLHPGBLOOJ<T>()
	{
		return default(BOEJMFJFKMA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x28A1200", Offset = "0x28A0000", VA = "0x1828A1200")]
	public static bool AONDPPOGLLD<T>([In] this BOEJMFJFKMA<T> OCAJGLFBKED, [Out][NotNullWhen(true)] T DIBNBLEEFNN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NANBOFKENDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr NFKDPBBOICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr FEKPEMBGLDA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr GIBJMANJJKK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr GEAIPPAJCAH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly NANBOFKENDO CNCELEPFOGN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JODNNLIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62C9250", Offset = "0x62C8050", VA = "0x1862C9250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	public NANBOFKENDO(IntPtr EJFGCABNBBA, IntPtr CMGJDDHNKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void MECEHHAFFBE(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	private static void DIIKJGPKEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9320", Offset = "0x62C8120", VA = "0x1862C9320")]
	private static NANBOFKENDO OHCAEKBGMDI()
	{
		return default(NANBOFKENDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HGJCMHKOBFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr INNABEFMAFP;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x93C860", Offset = "0x93B660", VA = "0x18093C860")]
	private HGJCMHKOBFJ(IntPtr CMGJDDHNKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62C6D70", Offset = "0x62C5B70", VA = "0x1862C6D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62C6D80", Offset = "0x62C5B80", VA = "0x1862C6D80")]
	public static HGJCMHKOBFJ KHDJPNLCMFA(string PHEKPMAPPHM)
	{
		return default(HGJCMHKOBFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E2CC90", Offset = "0x1E2BA90", VA = "0x181E2CC90")]
	public static HGJCMHKOBFJ KHDJPNLCMFA([In] NANBOFKENDO LEFHAPMGIGE, string PHEKPMAPPHM)
	{
		return default(HGJCMHKOBFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C600", Offset = "0x1E2B400", VA = "0x181E2C600")]
	public static HGJCMHKOBFJ KHDJPNLCMFA([In] NANBOFKENDO LEFHAPMGIGE, Func<string> PHEKPMAPPHM)
	{
		return default(HGJCMHKOBFJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PADLGHCIHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool AMABPNCPBBN<in TInput, TResult>(TInput PGOKJJEIBMC, [Out] TResult FJMMLPMLLGC);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class ALAKPFHOBIC : AOFAMNGBLEE
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class EKLFNAGJDIA : MCOBGLEIPFB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly EKLFNAGJDIA LLCJIHIKEMG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool IHFMGFBNHMA
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x62C4B60", Offset = "0x62C3960", VA = "0x1862C4B60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x62C4BC0", Offset = "0x62C39C0", VA = "0x1862C4BC0", Slot = "6")]
			public void OnCompleted(Action FENNPGADFPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			public void MOKGMELIOIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public EKLFNAGJDIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ALAKPFHOBIC LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private ALAKPFHOBIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62C2190", Offset = "0x62C0F90", VA = "0x1862C2190", Slot = "4")]
		public MCOBGLEIPFB AGKNNCIHMJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class JHHGPIKHMLE : AOFAMNGBLEE
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class NBFKNHKPGGI : MCOBGLEIPFB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly NBFKNHKPGGI LLCJIHIKEMG;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool IHFMGFBNHMA
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x62C94F0", Offset = "0x62C82F0", VA = "0x1862C94F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x62C9510", Offset = "0x62C8310", VA = "0x1862C9510", Slot = "6")]
			public void OnCompleted(Action FENNPGADFPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
			public void MOKGMELIOIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public NBFKNHKPGGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly JHHGPIKHMLE LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private JHHGPIKHMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62C7CA0", Offset = "0x62C6AA0", VA = "0x1862C7CA0", Slot = "4")]
		public MCOBGLEIPFB AGKNNCIHMJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DPLFNPKIGIG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DPLFNPKIGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x39C21D0", Offset = "0x39C0FD0", VA = "0x1839C21D0")]
		internal void PBMDODPDAGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GMBIIMGDHCC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GMBIIMGDHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3950C40", Offset = "0x394FA40", VA = "0x183950C40")]
		internal void GJCNFBOADGE(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GLFPJEMCLEH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C5E70", Offset = "0x62C4C70", VA = "0x1862C5E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct AEKHHOOIJEH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C2080", Offset = "0x62C0E80", VA = "0x1862C2080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct INLCLPIJJFE<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x3A996E0", Offset = "0x3A984E0", VA = "0x183A996E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3A99850", Offset = "0x3A98650", VA = "0x183A99850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct OAONIFBJLPH<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x40FE310", Offset = "0x40FD110", VA = "0x1840FE310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x40FEB40", Offset = "0x40FD940", VA = "0x1840FEB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GEFLAIPOIIK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C52F0", Offset = "0x62C40F0", VA = "0x1862C52F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x62C54F0", Offset = "0x62C42F0", VA = "0x1862C54F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HICAIJGGCPN<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HICAIJGGCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x39C21D0", Offset = "0x39C0FD0", VA = "0x1839C21D0")]
		internal void MHDNOHPMCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x39C2170", Offset = "0x39C0F70", VA = "0x1839C2170")]
		internal void COHJPPHGEPL(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HABKJBMCICK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public AMABPNCPBBN<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x39A22C0", Offset = "0x39A10C0", VA = "0x1839A22C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x39A2970", Offset = "0x39A1770", VA = "0x1839A2970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct HLMEAKDGJJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C7220", Offset = "0x62C6020", VA = "0x1862C7220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x62C7A10", Offset = "0x62C6810", VA = "0x1862C7A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LIHBGAHBGOM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C8710", Offset = "0x62C7510", VA = "0x1862C8710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x62C8C50", Offset = "0x62C7A50", VA = "0x1862C8C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BLAADEIPKFJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x485C170", Offset = "0x485AF70", VA = "0x18485C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38DA5F0", Offset = "0x38D93F0", VA = "0x1838DA5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CNBNOLHAAAJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4DFE720", Offset = "0x4DFD520", VA = "0x184DFE720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3470F10", Offset = "0x346FD10", VA = "0x183470F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ODLHGGCLAMB<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4105B30", Offset = "0x4104930", VA = "0x184105B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x41067C0", Offset = "0x41055C0", VA = "0x1841067C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EOJGEIOABAA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C4DF0", Offset = "0x62C3BF0", VA = "0x1862C4DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x62C4FD0", Offset = "0x62C3DD0", VA = "0x1862C4FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct HKBIAJBLHON : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C6E60", Offset = "0x62C5C60", VA = "0x1862C6E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62C71C0", Offset = "0x62C5FC0", VA = "0x1862C71C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OLKDFHPJOPA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C9650", Offset = "0x62C8450", VA = "0x1862C9650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x62C9940", Offset = "0x62C8740", VA = "0x1862C9940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EOIMELJFLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EOIMELJFLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x62C4D80", Offset = "0x62C3B80", VA = "0x1862C4D80")]
		internal Task PBPNCLCJFKK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FPDNODINFDL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C5030", Offset = "0x62C3E30", VA = "0x1862C5030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x62C5290", Offset = "0x62C4090", VA = "0x1862C5290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HDMHMOIEPOD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C6B30", Offset = "0x62C5930", VA = "0x1862C6B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62C6D10", Offset = "0x62C5B10", VA = "0x1862C6D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct LIJLEINDBDD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C8CB0", Offset = "0x62C7AB0", VA = "0x1862C8CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x62C9010", Offset = "0x62C7E10", VA = "0x1862C9010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct EFIPNMAJLOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C3F30", Offset = "0x62C2D30", VA = "0x1862C3F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x62C4220", Offset = "0x62C3020", VA = "0x1862C4220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class ACINFHBFPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ACINFHBFPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x62C1930", Offset = "0x62C0730", VA = "0x1862C1930")]
		internal Task GOABGBDCHPB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CJHKCAMFLLE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C22E0", Offset = "0x62C10E0", VA = "0x1862C22E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x62C2540", Offset = "0x62C1340", VA = "0x1862C2540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct MFDIFFPODPE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C9070", Offset = "0x62C7E70", VA = "0x1862C9070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x62C91F0", Offset = "0x62C7FF0", VA = "0x1862C91F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct COGCGMIGIAG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E06020", Offset = "0x4E04E20", VA = "0x184E06020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4E06270", Offset = "0x4E05070", VA = "0x184E06270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct LBNPNDBDDGK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x62C7E70", Offset = "0x62C6C70", VA = "0x1862C7E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62C8270", Offset = "0x62C7070", VA = "0x1862C8270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? OIJNGFFDDMD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<CDPLPCBKJFN> KPGJKPINFKH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task MJCFIKJIBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62CB190", Offset = "0x62C9F90", VA = "0x1862CB190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62CB200", Offset = "0x62CA000", VA = "0x1862CB200")]
	public static bool NIGMGOKKEDG(this Task JKCFEOGKFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2A42A30", Offset = "0x2A41830", VA = "0x182A42A30")]
	public static Task<T> HDGCEMECLHD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62CB230", Offset = "0x62CA030", VA = "0x1862CB230")]
	public static Task NMGJGMJIMDP(this Task JKCFEOGKFBB, CancellationToken ADNDMAGEPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A44C50", Offset = "0x2A43A50", VA = "0x182A44C50")]
	public static Task<TResult> NMGJGMJIMDP<TResult>(this Task<TResult> JKCFEOGKFBB, CancellationToken ADNDMAGEPOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2A45740", Offset = "0x2A44540", VA = "0x182A45740")]
	public static TaskCompletionSource<TResult> NMGJGMJIMDP<TResult>(this TaskCompletionSource<TResult> FFLBEEOPLEK, CancellationToken ADNDMAGEPOK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62CAC00", Offset = "0x62C9A00", VA = "0x1862CAC00")]
	public static IDisposable? MKHBGDHFLFI(CancellationToken DNHEMNHFJNB, CancellationToken CACMGDPLKLM, [Out] CancellationToken OECKJOBNNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x62C9DA0", Offset = "0x62C8BA0", VA = "0x1862C9DA0")]
	[AsyncStateMachine(typeof(GLFPJEMCLEH))]
	public static void DMHJKKNLCIE(this Task HKJAKBPEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62CB030", Offset = "0x62C9E30", VA = "0x1862CB030")]
	[AsyncStateMachine(typeof(AEKHHOOIJEH))]
	public static void NEPHMLBDCHD(this Task HKJAKBPEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2A42960", Offset = "0x2A41760", VA = "0x182A42960")]
	[AsyncStateMachine(typeof(INLCLPIJJFE<>))]
	public static Task GJHBLGHHIAK<TException>(this Task HKJAKBPEJHH) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2A42B80", Offset = "0x2A41980", VA = "0x182A42B80")]
	[AsyncStateMachine(typeof(OAONIFBJLPH<>))]
	public static Task<T> JFELJHHCBFB<T>(this Task<T> ILACEKALGJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62CA3E0", Offset = "0x62C91E0", VA = "0x1862CA3E0")]
	[AsyncStateMachine(typeof(GEFLAIPOIIK))]
	public static Task<TaskStatus> HMMJEPFKAPJ(this Task ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2A42F00", Offset = "0x2A41D00", VA = "0x182A42F00")]
	public static (Task<T?>?, Action<T?>?) NBCNEHPNANC<T>([Optional] CancellationToken KANPDHELHMD)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2A42270", Offset = "0x2A41070", VA = "0x182A42270")]
	[AsyncStateMachine(typeof(HABKJBMCICK<, >))]
	public static Task<List<TResult>> CEKCPMBPMJF<TResult, TInput>(this Task<List<TInput>> JKCFEOGKFBB, AMABPNCPBBN<TInput, TResult> LLHPBDKEPAI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62CB480", Offset = "0x62CA280", VA = "0x1862CB480")]
	[AsyncStateMachine(typeof(HLMEAKDGJJJ))]
	public static Task OPJJHHLNDDE(Task HKJAKBPEJHH, CancellationToken DHIPGGMBELH, Func<CancellationToken, Task> FNAGHJFJKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62CA190", Offset = "0x62C8F90", VA = "0x1862CA190")]
	[AsyncStateMachine(typeof(LIHBGAHBGOM))]
	public static Task GIMOIOEPAEF(Func<CancellationToken, Task> AKAIMONCJJD, TimeSpan JODGDKECNNK, [Optional] CancellationToken DHIPGGMBELH, [Optional] Action<OperationCanceledException>? LDAONDJDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A42700", Offset = "0x2A41500", VA = "0x182A42700")]
	[AsyncStateMachine(typeof(BLAADEIPKFJ<>))]
	public static Task<T> GIMOIOEPAEF<T>(Func<CancellationToken, Task<T>> AKAIMONCJJD, TimeSpan JODGDKECNNK, [Optional] CancellationToken DHIPGGMBELH, [Optional] Func<OperationCanceledException, T>? LDAONDJDHBM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A42E20", Offset = "0x2A41C20", VA = "0x182A42E20")]
	[AsyncStateMachine(typeof(CNBNOLHAAAJ<>))]
	public static Task<IEnumerable<Task<T>>> KKBANKALFHO<T>(IEnumerable<Task<T>> IGHHNBIAHCI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2A42460", Offset = "0x2A41260", VA = "0x182A42460")]
	[AsyncStateMachine(typeof(ODLHGGCLAMB<, , , >))]
	public static Task<(T1, T2, T3, T4)> FIGKPHFGMPC<T1, T2, T3, T4>(Task<T1> INFFNGEACMP, Task<T2> LLLEGFKKLMP, Task<T3> ECONIGGCEON, Task<T4> BHNEOPHKPEI) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x62CA830", Offset = "0x62C9630", VA = "0x1862CA830")]
	[AsyncStateMachine(typeof(EOJGEIOABAA))]
	public static Task HPHANEKOPLD(Func<bool> CBAOJAAOCLI, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x62CA920", Offset = "0x62C9720", VA = "0x1862CA920")]
	[AsyncStateMachine(typeof(HKBIAJBLHON))]
	public static Task HPHANEKOPLD(Func<bool> CBAOJAAOCLI, TimeSpan BKHHNKIGFLE, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x62CAF00", Offset = "0x62C9D00", VA = "0x1862CAF00")]
	[AsyncStateMachine(typeof(OLKDFHPJOPA))]
	public static Task NBNLLEFBOKH(Func<bool> CBAOJAAOCLI, TimeSpan JODGDKECNNK, [Optional] CancellationToken KANPDHELHMD, [Optional] Action<OperationCanceledException>? LDAONDJDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x62CADC0", Offset = "0x62C9BC0", VA = "0x1862CADC0")]
	[AsyncStateMachine(typeof(FPDNODINFDL))]
	public static Task NBNLLEFBOKH(Func<bool> CBAOJAAOCLI, TimeSpan JODGDKECNNK, TimeSpan BKHHNKIGFLE, [Optional] CancellationToken KANPDHELHMD, [Optional] Action<OperationCanceledException>? LDAONDJDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62C9AB0", Offset = "0x62C88B0", VA = "0x1862C9AB0")]
	[AsyncStateMachine(typeof(HDMHMOIEPOD))]
	public static Task CKGIDMDOGOL(Func<bool> CBAOJAAOCLI, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62C9BA0", Offset = "0x62C89A0", VA = "0x1862C9BA0")]
	[AsyncStateMachine(typeof(LIJLEINDBDD))]
	public static Task CKGIDMDOGOL(Func<bool> CBAOJAAOCLI, TimeSpan BKHHNKIGFLE, [Optional] CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9F90", Offset = "0x62C8D90", VA = "0x1862C9F90")]
	[AsyncStateMachine(typeof(EFIPNMAJLOO))]
	public static Task EEIBBHODDLH(Func<bool> CBAOJAAOCLI, TimeSpan JODGDKECNNK, [Optional] CancellationToken KANPDHELHMD, [Optional] Action<OperationCanceledException>? LDAONDJDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x62C9E50", Offset = "0x62C8C50", VA = "0x1862C9E50")]
	[AsyncStateMachine(typeof(CJHKCAMFLLE))]
	public static Task EEIBBHODDLH(Func<bool> CBAOJAAOCLI, TimeSpan JODGDKECNNK, TimeSpan BKHHNKIGFLE, [Optional] CancellationToken KANPDHELHMD, [Optional] Action<OperationCanceledException>? LDAONDJDHBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x62C9CB0", Offset = "0x62C8AB0", VA = "0x1862C9CB0")]
	[Obsolete]
	[AsyncStateMachine(typeof(MFDIFFPODPE))]
	public static Task DIKBLELADBC(this Task JKCFEOGKFBB, Action NKINCPGPPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A42370", Offset = "0x2A41170", VA = "0x182A42370")]
	[Obsolete]
	[AsyncStateMachine(typeof(COGCGMIGIAG<>))]
	public static Task DIKBLELADBC<T>(this Task<T> JKCFEOGKFBB, Action<T> NKINCPGPPBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x62CB0E0", Offset = "0x62C9EE0", VA = "0x1862CB0E0")]
	private static void NFMOJCLFKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62CA4D0", Offset = "0x62C92D0", VA = "0x1862CA4D0")]
	public static bool HOLOLLHNLEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x62CAA80", Offset = "0x62C9880", VA = "0x1862CAA80")]
	private static void MBFFIPAPIIM(SynchronizationContext DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62C99A0", Offset = "0x62C87A0", VA = "0x1862C99A0")]
	private static void BAIDEFKGDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62CA0C0", Offset = "0x62C8EC0", VA = "0x1862CA0C0")]
	public static void EEOBPNEDHME([Optional] string? HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62CAD40", Offset = "0x62C9B40", VA = "0x1862CAD40")]
	public static void NBBHIOHJCPI([Optional] string? HPJAAILCALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62CAA30", Offset = "0x62C9830", VA = "0x1862CAA30")]
	public static AOFAMNGBLEE KONFLDBLMBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62CA2C0", Offset = "0x62C90C0", VA = "0x1862CA2C0")]
	public static AOFAMNGBLEE GLHLAKJPFMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62CA310", Offset = "0x62C9110", VA = "0x1862CA310")]
	[AsyncStateMachine(typeof(LBNPNDBDDGK))]
	public static Task HLMFHMFPANP(Func<Task> HAEHEOGNGAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HEFMNMOEFLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	public HEFMNMOEFLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class KMOJDNDJPIB : IOMHEJBCNDP
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly IOMHEJBCNDP LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime GPKCOIIBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62C7D60", Offset = "0x62C6B60", VA = "0x1862C7D60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset LBKJDEEAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62C7DA0", Offset = "0x62C6BA0", VA = "0x1862C7DA0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KMOJDNDJPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface IOMHEJBCNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime GPKCOIIBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset LBKJDEEAGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EJDHDKIBFAF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long PHOBEIMPEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62C4420", Offset = "0x62C3220", VA = "0x1862C4420")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long DCDNFAPFNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62C4370", Offset = "0x62C3170", VA = "0x1862C4370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double KEGNMFAEHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x62C4870", Offset = "0x62C3670", VA = "0x1862C4870")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double JDJGCFGNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62C45D0", Offset = "0x62C33D0", VA = "0x1862C45D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double MNJLLOJCADO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62C46B0", Offset = "0x62C34B0", VA = "0x1862C46B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double ONFNGCDLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62C4700", Offset = "0x62C3500", VA = "0x1862C4700")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62C4540", Offset = "0x62C3340", VA = "0x1862C4540")]
	public static double HFGNMANAAOL(long KCHNBNBHPBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62C47E0", Offset = "0x62C35E0", VA = "0x1862C47E0")]
	public static double PJNJCLKCGMF(long KCHNBNBHPBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x62C4620", Offset = "0x62C3420", VA = "0x1862C4620")]
	public static double IIOPIHLAIMF(double MEGBHEKGAMH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x62C4750", Offset = "0x62C3550", VA = "0x1862C4750")]
	public static long PJLALNHLCAC(long GKFGFCFKANC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x62C4360", Offset = "0x62C3160", VA = "0x1862C4360")]
	public static long APDIBPMFJPF(long PLKDBIDONFJ, long OIBDLFJLLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62C4470", Offset = "0x62C3270", VA = "0x1862C4470")]
	public static double GAPDNIFEAGB(long PLKDBIDONFJ, long OIBDLFJLLJB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x62C43C0", Offset = "0x62C31C0", VA = "0x1862C43C0")]
	public static double CBMFBBKIOKL(long PLKDBIDONFJ, long OIBDLFJLLJB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class AEEGCHIJBKB : AHDFOAPPDFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan JAEAOOJHJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer DPOENBOPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan JODGDKECNNK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan MOKLCGPENAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62C1A10", Offset = "0x62C0810", VA = "0x1862C1A10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? PAKKKPJGGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62C2020", Offset = "0x62C0E20", VA = "0x1862C2020")]
	[Preserve]
	public AEEGCHIJBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x62C1DD0", Offset = "0x62C0BD0", VA = "0x1862C1DD0")]
	public AEEGCHIJBKB(TimeSpan JODGDKECNNK, [Optional] Action? AKMMFGEMHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x62C1C10", Offset = "0x62C0A10", VA = "0x1862C1C10", Slot = "7")]
	public void FIAKOELMJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x62C19A0", Offset = "0x62C07A0", VA = "0x1862C19A0", Slot = "8")]
	public void ABNGBLJBJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x62C1CA0", Offset = "0x62C0AA0", VA = "0x1862C1CA0", Slot = "9")]
	public void IMCOABBNLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xC2A4C0", Offset = "0xC292C0", VA = "0x180C2A4C0")]
	private void DEKAFIDHGPF(object KDBMKOJJIJP, ElapsedEventArgs HLHEMAAFADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x62C1CD0", Offset = "0x62C0AD0", VA = "0x1862C1CD0")]
	private static void PJCCOMKGCEM(TimeSpan JIBBEHKBKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x62C1B70", Offset = "0x62C0970", VA = "0x1862C1B70", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class AHPJOKJFFLN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? IPPGHDONLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string ENDCLAAGGNP;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9AA0", Offset = "0x5DB88A0", VA = "0x185DB9AA0")]
	public AHPJOKJFFLN(string HCNOEAOOGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x385A0C0", Offset = "0x3858EC0", VA = "0x18385A0C0")]
	public AHPJOKJFFLN(string FLCDMHECMDI, string HCNOEAOOGOH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CNLMJLLGIPI : IEquatable<CNLMJLLGIPI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint LMKACBBIAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int IHBCDEJHOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float CJJDOBKHDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort PDOEPAPNNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort ICKDIHLLBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short GIDJMCJCLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short DGOKJBEBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char KHPJOLBLJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char KHAFMIPBPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte LAMLGCONKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte EHIDHOFCGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte MDFHJDOJNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte GHCDONMBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool DBBKMBCGNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool IFABFIEFELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool LLBENHOHMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool CNFIPPEECMM;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static CNLMJLLGIPI NOMEHBIFPAO(uint GKPNPMHFOHH)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD6EEB0", Offset = "0xD6DCB0", VA = "0x180D6EEB0")]
	public static CNLMJLLGIPI GMKCOGNFGIB(int FAMFGGBBGKO)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x62C25A0", Offset = "0x62C13A0", VA = "0x1862C25A0")]
	public static CNLMJLLGIPI BMFEELJCDDJ(float OBONLPCKKJA)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x62C2640", Offset = "0x62C1440", VA = "0x1862C2640")]
	public static CNLMJLLGIPI PJPICLLJFBN(byte ILNIHHLODIK, byte MICFOFNHHBK, byte KEFIBHPJLHH, byte ACAJMHLKDPD)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x62C2640", Offset = "0x62C1440", VA = "0x1862C2640")]
	public static CNLMJLLGIPI NOIBKFBLFKG(bool KMIFAEAIFCM, bool ICJEFFBFDJM, bool BDIGACPPCON, bool LIHENEPIKCO)
	{
		return default(CNLMJLLGIPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x62C2640", Offset = "0x62C1440", VA = "0x1862C2640")]
	public static CNLMJLLGIPI PHLPDEEANDK(byte CAMNAJHBBFJ, byte HNKKOCMGLHO, byte LJFECGFNANB, byte ECDCCFKGLIJ)
	{
		return default(CNLMJLLGIPI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1883660", Offset = "0x1882460", VA = "0x181883660")]
	public static bool OFKPFEHPLBH(CNLMJLLGIPI MAEINFGKCEL, CNLMJLLGIPI FLBFHNBPNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x888BC0", Offset = "0x8879C0", VA = "0x180888BC0", Slot = "4")]
	public bool Equals(CNLMJLLGIPI GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x62C25B0", Offset = "0x62C13B0", VA = "0x1862C25B0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x93C630", Offset = "0x93B430", VA = "0x18093C630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62C2660", Offset = "0x62C1460", VA = "0x1862C2660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PCNNPIAILDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong OKOMPOLBMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long ADLOPBPAHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double JAIKGIIIGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint IJMOICAKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint MGBDGMEOFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int BHEENKKDIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int OOIMMNNDIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float EMNNBKGJANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float NNDKBMHFPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort PDOEPAPNNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort ICKDIHLLBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort PLAHGGJOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort DNJNKKHIHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short GIDJMCJCLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short DGOKJBEBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short AKGOJEJEBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short GBAJMMJGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char KHPJOLBLJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char KHAFMIPBPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char ALDDHOKLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char JIDHFLAOPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte LAMLGCONKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte EHIDHOFCGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte MDFHJDOJNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte GHCDONMBGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte FCFPODCPACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte CAKGKOOGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte HAICPKGOEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HJNOKJPEOIB;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x62CB670", Offset = "0x62CA470", VA = "0x1862CB670")]
	public static PCNNPIAILDJ KHDJPNLCMFA(byte ILNIHHLODIK, byte MICFOFNHHBK, byte KEFIBHPJLHH, byte ACAJMHLKDPD, byte FFHDEICLIEC, byte FCANECMLPPM, byte FCBAMKBJEOI, byte LLGKIMOPNHO)
	{
		return default(PCNNPIAILDJ);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct LHMKDDGDBCF : IEquatable<LHMKDDGDBCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte PDHJFPNKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool KFEFKGINEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2383430", Offset = "0x2382230", VA = "0x182383430")]
	public static LHMKDDGDBCF PJPICLLJFBN(byte LDBHKFIEIKA)
	{
		return default(LHMKDDGDBCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2383430", Offset = "0x2382230", VA = "0x182383430")]
	public static LHMKDDGDBCF NOIBKFBLFKG(bool JDLHJANDINM)
	{
		return default(LHMKDDGDBCF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62C8490", Offset = "0x62C7290", VA = "0x1862C8490")]
	public static bool OFKPFEHPLBH(LHMKDDGDBCF MAEINFGKCEL, LHMKDDGDBCF FLBFHNBPNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54F6160", Offset = "0x54F4F60", VA = "0x1854F6160", Slot = "4")]
	public bool Equals(LHMKDDGDBCF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62C83F0", Offset = "0x62C71F0", VA = "0x1862C83F0", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62C8480", Offset = "0x62C7280", VA = "0x1862C8480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62C84A0", Offset = "0x62C72A0", VA = "0x1862C84A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ICMJPHIKIOK<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T JAMNLBEMNIK;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E700", Offset = "0x3A6D500", VA = "0x183A6E700")]
	public ICMJPHIKIOK(T GHODNKFGDMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EHPEFCIPLJG
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2758540", Offset = "0x2757340", VA = "0x182758540")]
	public static IEnumerable<T> IJHGBKNJIBM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static T[] AMIDFPMDOIL<T>(params T[] JJKADPHEOGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70")]
	public static IEnumerable<T> PHODLNNCPLM<T>(params T[] JJKADPHEOGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static HashSet<T> MOJHCKKLAJD<T>(params T[] JJKADPHEOGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2771410", Offset = "0x2770210", VA = "0x182771410")]
	public static KeyValuePair<TKey, TValue> FGENJABFEII<TKey, TValue>([In] TKey OBPLDLNDJLE, [In] TValue DIBNBLEEFNN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static List<T> GDMIFHDKMPB<T>(IEnumerable<T> OMJAEJKGFAD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MOLIEFDPCNH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string LABBNGLPANB;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
	public MOLIEFDPCNH(string CALLEFILHJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object OGPGHGDFEEI<T>([In] T GOFCIAANDLN);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object BIGPKJIHBLA<T>(T GOFCIAANDLN);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BNNKMJLNIAL]
public delegate string JFGOIDOHFOI(string INOMBDBKIKO, string? NLGJAGOIBCG, bool LCDBECDGJDC);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BNNKMJLNIAL]
public delegate void JHCPEAJEECJ(string HPJAAILCALJ);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[BNNKMJLNIAL]
public delegate void LKJEMAOGMPH(Exception MCKOJGJOINA);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object BCPPONHIHOL();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[BNNKMJLNIAL]
public delegate bool GBDHGEAGKNO();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[BNNKMJLNIAL]
public delegate string FMELGGDOCGA(object EIFMADKIHON);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class PEPHKFJLIBK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
	public PEPHKFJLIBK()
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
