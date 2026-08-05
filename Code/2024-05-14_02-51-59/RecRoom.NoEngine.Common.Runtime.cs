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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x63F2850", Offset = "0x63F1250", VA = "0x1863F2850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class JCMKKLIMPMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63EFA60", Offset = "0x63EE460", VA = "0x1863EFA60")]
	public JCMKKLIMPMO(bool JOMJGKGBMBD, string BPJHJACMNEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class INCIBDHAGCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ENMMKIEINCE<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> GHJMLIIHDIP(CancellationToken CFAFANOFDNJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AMMOCJDCHGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ENMMKIEINCE<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GHJMLIIHDIP taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x397BBA0", Offset = "0x397A5A0", VA = "0x18397BBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x397CB80", Offset = "0x397B580", VA = "0x18397CB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? FGDHLBCGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? ECIDHFILPJC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3522620", Offset = "0x3521020", VA = "0x183522620")]
	[AsyncStateMachine(typeof(ENMMKIEINCE<>.AMMOCJDCHGD))]
	public Task<TResult> JCOOPJOCAME(GHJMLIIHDIP OBIKEJOPOHI, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35225B0", Offset = "0x3520FB0", VA = "0x1835225B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3522750", Offset = "0x3521150", VA = "0x183522750")]
	public ENMMKIEINCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DBOAGBIKCNM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> KMGIIIABFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T DPMGLPAKGNP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x397CE60", Offset = "0x397B860", VA = "0x18397CE60")]
	public DBOAGBIKCNM([In] T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5232C60", Offset = "0x5231660", VA = "0x185232C60", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5233240", Offset = "0x5231C40", VA = "0x185233240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x52333A0", Offset = "0x5231DA0", VA = "0x1852333A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FINPHDDCKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static DBOAGBIKCNM<T> OLCPJHCMOKI<T>([In] T AEJBOLFACJC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HJCDKDILIFF
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63EF640", Offset = "0x63EE040", VA = "0x1863EF640")]
	public static void BBDENABIFME(this CancellationTokenSource NCPJPNOCKEL, bool GICHLPLJCHJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class EIGMFIPNHFB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
	public EIGMFIPNHFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CHAHDHKEFIF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
	public CHAHDHKEFIF(string ACJENKGECPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CKIMIGLFLAL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27B4260", Offset = "0x27B2C60", VA = "0x1827B4260")]
	public static CDMPGJOHKCG CAMMHMJGHNC<T>()
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27B4460", Offset = "0x27B2E60", VA = "0x1827B4460")]
	public static CDMPGJOHKCG JNBNHDANGAB<T>([CallerMemberName] string GKDOOPOCBPP = "") where T : notnull
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27B41E0", Offset = "0x27B2BE0", VA = "0x1827B41E0")]
	public static CDMPGJOHKCG CAMMHMJGHNC<T>(this T GCGDEDCNCCJ) where T : notnull
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27B42E0", Offset = "0x27B2CE0", VA = "0x1827B42E0")]
	public static CDMPGJOHKCG GNJCMNLMNGE<T>(this T GCGDEDCNCCJ, [CallerMemberName] string GKDOOPOCBPP = "") where T : notnull
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27B44F0", Offset = "0x27B2EF0", VA = "0x1827B44F0")]
	public static CDMPGJOHKCG JNBNHDANGAB<T>(this T CMJEIEIDHIK, [CallerMemberName] string GKDOOPOCBPP = "") where T : notnull
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63EBBA0", Offset = "0x63EA5A0", VA = "0x1863EBBA0")]
	public static CDMPGJOHKCG JNBNHDANGAB(string OCJIPOAEKGL, [CallerMemberName] string GKDOOPOCBPP = "")
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63EBC20", Offset = "0x63EA620", VA = "0x1863EBC20")]
	public static string LDPEEPKKGCJ(this object CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool PIFDEFNBLNL();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[EIGMFIPNHFB]
public delegate long PIOHLGFHHIP();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KLMPCJEFEBK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static KLJKOFJPLCA CDABLBCLEEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KLJKOFJPLCA AIIKOBIGPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63F0F20", Offset = "0x63EF920", VA = "0x1863F0F20")]
		get
		{
			return default(KLJKOFJPLCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GMGKGEPILHI OECDPJGAPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x63F1190", Offset = "0x63EFB90", VA = "0x1863F1190")]
		get
		{
			return default(GMGKGEPILHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KKFBPMGMLMF MPDCKOOOBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x63F0970", Offset = "0x63EF370", VA = "0x1863F0970")]
		get
		{
			return default(KKFBPMGMLMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool NACHODMEGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63F1120", Offset = "0x63EFB20", VA = "0x1863F1120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x63F0A30", Offset = "0x63EF430", VA = "0x1863F0A30")]
	public static void CNGKFIBNPPD([In] KLJKOFJPLCA KJLBNPFBDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63F0E50", Offset = "0x63EF850", VA = "0x1863F0E50")]
	public static void IGGHFJOIHIE(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63F0FD0", Offset = "0x63EF9D0", VA = "0x1863F0FD0")]
	public static void KNACHLPCOLG(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29CA5B0", Offset = "0x29C8FB0", VA = "0x1829CA5B0")]
	public static void KNACHLPCOLG<T>(T CMMMKFHDFNK, EPFHILNPILC<T> CPPFNMDMGHI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63F0CE0", Offset = "0x63EF6E0", VA = "0x1863F0CE0")]
	public static void GDFHIPEJCHD(Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63F0C80", Offset = "0x63EF680", VA = "0x1863F0C80")]
	public static void EBJKOIECKAG(string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63F0F70", Offset = "0x63EF970", VA = "0x1863F0F70")]
	public static void KIDPKMBPJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63F10A0", Offset = "0x63EFAA0", VA = "0x1863F10A0")]
	public static string LDPEEPKKGCJ(object COMOOAEHALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63F09C0", Offset = "0x63EF3C0", VA = "0x1863F09C0")]
	public static long CMFFAKBFMIH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63F0BE0", Offset = "0x63EF5E0", VA = "0x1863F0BE0")]
	public static bool DDJEMOAKOFP(bool AJBHONGPHFM, string CPPFNMDMGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63F0D80", Offset = "0x63EF780", VA = "0x1863F0D80")]
	public static double HJBIHNBPKHF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct KLJKOFJPLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GMGKGEPILHI OECDPJGAPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KKFBPMGMLMF MPDCKOOOBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly FCIMEPBCIIF HMBDIBLLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly PIOHLGFHHIP BDFPCPOIDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JBPNEDOAFDD PNLJHPGFBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly PIFDEFNBLNL BBHKBDOIIEH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly FCIMEPBCIIF LJPCICOKAHF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PIOHLGFHHIP DNLLEHOEJGP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly JBPNEDOAFDD GKHJIPNKGFH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly PIFDEFNBLNL FHDCJGCAENL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KLJKOFJPLCA ENNIKGPCCFB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MJOGKGKNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63EFFF0", Offset = "0x63EE9F0", VA = "0x1863EFFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63F08C0", Offset = "0x63EF2C0", VA = "0x1863F08C0")]
	public KLJKOFJPLCA([In] GMGKGEPILHI PEIPHCDINJM, [In] KKFBPMGMLMF JMLDDIMBPPL, FCIMEPBCIIF AMHMFNMNKLF, PIOHLGFHHIP KPEIPCFCOLP, JBPNEDOAFDD BKDOILEOHLD, PIFDEFNBLNL AGMOHOOEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63F0190", Offset = "0x63EEB90", VA = "0x1863F0190")]
	private static string MHPKAFKIOFG(object COMOOAEHALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0")]
	private static long AMPPENOMHAJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	private static string GFFKEHELBPD(string LCECEOIPEEK, string? IFNAJKAPIMA, bool PDPEBPBMFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	private static bool KAHMKPFEMOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63EFEE0", Offset = "0x63EE8E0", VA = "0x1863EFEE0")]
	private static KLJKOFJPLCA CMCEKPMJLHF()
	{
		return default(KLJKOFJPLCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KIOAPFBDBJK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICKIBJLHNAJ MKCIAKANKGF();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ICKIBJLHNAJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BMNHMNKEJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMGHOBDMBPI();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MBHFAJKBHGN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IAAOGLMFDPE([In] T HKMMPHJFKEA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void HPFLHEAINCO<T>([In] T CMMMKFHDFNK);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct GCDEDMCHNOP<T> : IEquatable<GCDEDMCHNOP<T>>, MBHFAJKBHGN<GCDEDMCHNOP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T DPMGLPAKGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int JIFJFCOEJGO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E92BD0", Offset = "0x1E915D0", VA = "0x181E92BD0")]
	public GCDEDMCHNOP([In] T AEJBOLFACJC, int ABBNIPHGMGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3955930", Offset = "0x3954330", VA = "0x183955930")]
	public static bool PIEEFOPMNNK([In] GCDEDMCHNOP<T> OLKIFIEFDII, [In] GCDEDMCHNOP<T> AEIEBLGGCGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3954990", Offset = "0x3953390", VA = "0x183954990", Slot = "4")]
	public bool Equals(GCDEDMCHNOP<T> HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3954910", Offset = "0x3953310", VA = "0x183954910", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3954ED0", Offset = "0x39538D0", VA = "0x183954ED0")]
	public bool IAAOGLMFDPE([In] GCDEDMCHNOP<T> HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3954D00", Offset = "0x3953700", VA = "0x183954D00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39561C0", Offset = "0x3954BC0", VA = "0x1839561C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3955040", Offset = "0x3953A40", VA = "0x183955040")]
	public void NKCMAJNBHJE([Out] T AEJBOLFACJC, [Out] int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3955C70", Offset = "0x3954670", VA = "0x183955C70")]
	public (T, int) PMNOOADBBCM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39548C0", Offset = "0x39532C0", VA = "0x1839548C0", Slot = "5")]
	private bool BONDDALNAII([In] GCDEDMCHNOP<T> HKMMPHJFKEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NJHJJCNGKMC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A80260", Offset = "0x2A7EC60", VA = "0x182A80260")]
	public static GCDEDMCHNOP<T> OLCPJHCMOKI<T>([In] T AEJBOLFACJC, int ABBNIPHGMGH) where T : notnull
	{
		return default(GCDEDMCHNOP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HIKNGGNKKHN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x296BE50", Offset = "0x296A850", VA = "0x18296BE50")]
	public static bool IAAOGLMFDPE<T, U>([In] T CMJEIEIDHIK, [In] U COMOOAEHALC) where T : notnull, MBHFAJKBHGN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult PODJBIOJGJG<T, out TResult>([In] T CMMMKFHDFNK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface JMEIOELHBCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan FGFCMCKPGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? NLKMAGNKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBIPAHEJJPN();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJNJKMBKPGC();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLAOOGBPCGB();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct GMGKGEPILHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EHPOCKJNDLD DPDBLBPMHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly IPHKKLLMMEK GMJBKLFPKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly EHPOCKJNDLD EOCHEKGIGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly IPHKKLLMMEK LPCOLEIFIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly EHPOCKJNDLD KMHIEKOOEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly IPHKKLLMMEK ODBMNBODJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly MFDDEOKAIGM CEIKFDNLAPM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly EHPOCKJNDLD GCMHIOCOMHL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IPHKKLLMMEK JJDILDLCEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly EHPOCKJNDLD OPMMKDHJDMD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IPHKKLLMMEK AANNBMCCPCH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly EHPOCKJNDLD EEDJHHGNOIG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IPHKKLLMMEK JALONHEJIJJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MFDDEOKAIGM NAFLKEBINEF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GMGKGEPILHI ENNIKGPCCFB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EHPOCKJNDLD NCOCPJCBBHP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MJOGKGKNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x63EE500", Offset = "0x63ECF00", VA = "0x1863EE500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9EC660", Offset = "0x9EB060", VA = "0x1809EC660")]
	public GMGKGEPILHI(EHPOCKJNDLD KBHEMDDCBLH, IPHKKLLMMEK PDIAINLCBPO, EHPOCKJNDLD AFELAMFMPEC, IPHKKLLMMEK PFMKFHONAPE, EHPOCKJNDLD FCLENKFNFDA, IPHKKLLMMEK PIOJHNOILMD, MFDDEOKAIGM AJBMAMFLIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	private static bool LFMOLAIEKMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void HPKOBCGCLFK(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	private static bool KGEGAFMFDNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void PBOEEKAGDEH(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0")]
	private static bool LNBLFJAOHJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void JFACDJPMOEL(string CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void PPDBNMMPBKK(Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63EE280", Offset = "0x63ECC80", VA = "0x1863EE280")]
	private static GMGKGEPILHI CMCEKPMJLHF()
	{
		return default(GMGKGEPILHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630")]
	private static bool LJDPLIKAJIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63EE490", Offset = "0x63ECE90", VA = "0x1863EE490")]
	public void IGGHFJOIHIE(object CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63EE7E0", Offset = "0x63ED1E0", VA = "0x1863EE7E0")]
	public void KNACHLPCOLG(object CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A70210", Offset = "0x1A6EC10", VA = "0x181A70210")]
	public void GDFHIPEJCHD(Exception PBPEDJNJMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x63EE700", Offset = "0x63ED100", VA = "0x1863EE700")]
	public void KNACHLPCOLG(HHCCMKMHDFI CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x295A910", Offset = "0x2959310", VA = "0x18295A910")]
	public void KNACHLPCOLG<T>(T CMMMKFHDFNK, EPFHILNPILC<T> CPPFNMDMGHI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x295A790", Offset = "0x2959190", VA = "0x18295A790")]
	public void IGGHFJOIHIE<T>([In] T CMMMKFHDFNK, DEHBGMHGFCP<T> CPPFNMDMGHI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x63EE3C0", Offset = "0x63ECDC0", VA = "0x1863EE3C0")]
	public bool DDJEMOAKOFP(bool AJBHONGPHFM, string CPPFNMDMGHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct CDMPGJOHKCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string DPMGLPAKGNP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	public CDMPGJOHKCG(string AEJBOLFACJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
	public static string KHGGPLGKNCG([In] CDMPGJOHKCG CMJEIEIDHIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x83EA70", Offset = "0x83D470", VA = "0x18083EA70")]
	public static CDMPGJOHKCG KHGGPLGKNCG(string HKMMPHJFKEA)
	{
		return default(CDMPGJOHKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x63EBA70", Offset = "0x63EA470", VA = "0x1863EBA70")]
	public string FIKCCDOHEGO(string BOPEIGBCEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x63EBAC0", Offset = "0x63EA4C0", VA = "0x1863EBAC0")]
	public string PMKPOEGEPCN(object OONPBOKJNDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct PHKKIFFGKBG : IEquatable<PHKKIFFGKBG>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DD630", Offset = "0x7DC030", VA = "0x1807DD630", Slot = "4")]
	public bool Equals(PHKKIFFGKBG HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x63F2D80", Offset = "0x63F1780", VA = "0x1863F2D80", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x63F2DD0", Offset = "0x63F17D0", VA = "0x1863F2DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x63F2DE0", Offset = "0x63F17E0", VA = "0x1863F2DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[OKMJKJEMLAC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GLKIBNECMOM<T> : IEquatable<GLKIBNECMOM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T DPMGLPAKGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool ENPPEOLAJOO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IKKABIACOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x39ADC60", Offset = "0x39AC660", VA = "0x1839ADC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x39AE360", Offset = "0x39ACD60", VA = "0x1839AE360")]
	public GLKIBNECMOM([In] T AEJBOLFACJC, bool JLJBPLCDMEJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x39ADE30", Offset = "0x39AC830", VA = "0x1839ADE30")]
	public static bool PIEEFOPMNNK([In] GLKIBNECMOM<T> OLKIFIEFDII, [In] GLKIBNECMOM<T> AEIEBLGGCGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3954990", Offset = "0x3953390", VA = "0x183954990", Slot = "4")]
	public bool Equals(GLKIBNECMOM<T> HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x39AD7F0", Offset = "0x39AC1F0", VA = "0x1839AD7F0", Slot = "0")]
	public override bool Equals(object HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x39AD9E0", Offset = "0x39AC3E0", VA = "0x1839AD9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x39AE250", Offset = "0x39ACC50", VA = "0x1839AE250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DGKHBODAJBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27E46C0", Offset = "0x27E30C0", VA = "0x1827E46C0")]
	public static GLKIBNECMOM<T> IKBOEAGPOEK<T>([In] T AEJBOLFACJC) where T : notnull
	{
		return default(GLKIBNECMOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27E47F0", Offset = "0x27E31F0", VA = "0x1827E47F0")]
	public static GLKIBNECMOM<T?> OEMNJLGMOOE<T>()
	{
		return default(GLKIBNECMOM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27E48B0", Offset = "0x27E32B0", VA = "0x1827E48B0")]
	public static bool PGJFHPAMEIH<T>([In] this GLKIBNECMOM<T> INIGGBOCIKL, [Out][NotNullWhen(true)] T AEJBOLFACJC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct KKFBPMGMLMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr EBJKOIECKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr KIDPKMBPJMO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr DPOIHMLLHLI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr IIFKGHFHNOE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly KKFBPMGMLMF ENNIKGPCCFB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MJOGKGKNLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63EFCB0", Offset = "0x63EE6B0", VA = "0x1863EFCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
	public KKFBPMGMLMF(IntPtr HMLHEIBIPDH, IntPtr FEPDFILPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void OJBLDBAKBBI(string GKDOOPOCBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	private static void LFJPJJJJOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63EFC20", Offset = "0x63EE620", VA = "0x1863EFC20")]
	private static KKFBPMGMLMF CMCEKPMJLHF()
	{
		return default(KKFBPMGMLMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct FCIBLDBNLHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr OBCJOOFPKAP;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	private FCIBLDBNLHP(IntPtr FEPDFILPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x63ED6B0", Offset = "0x63EC0B0", VA = "0x1863ED6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63ED6C0", Offset = "0x63EC0C0", VA = "0x1863ED6C0")]
	public static FCIBLDBNLHP OLCPJHCMOKI(string GKDOOPOCBPP)
	{
		return default(FCIBLDBNLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E731A0", Offset = "0x1E71BA0", VA = "0x181E731A0")]
	public static FCIBLDBNLHP OLCPJHCMOKI([In] KKFBPMGMLMF JMLDDIMBPPL, string GKDOOPOCBPP)
	{
		return default(FCIBLDBNLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E73150", Offset = "0x1E71B50", VA = "0x181E73150")]
	public static FCIBLDBNLHP OLCPJHCMOKI([In] KKFBPMGMLMF JMLDDIMBPPL, Func<string> GKDOOPOCBPP)
	{
		return default(FCIBLDBNLHP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BFPIAFAAEOF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool APJPAEKNJFH<in TInput, TResult>(TInput KAPFFOPPBJF, [Out] TResult LKBGEIGOHEF);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class FBLKBFNABDO : KIOAPFBDBJK
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class GBOEAAJNLKD : ICKIBJLHNAJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly GBOEAAJNLKD AINFBDJPIJL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool BMNHMNKEJDL
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x63EDF20", Offset = "0x63EC920", VA = "0x1863EDF20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x63EDF80", Offset = "0x63EC980", VA = "0x1863EDF80", Slot = "6")]
			public void OnCompleted(Action ONFBAKCODGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			public void DMGHOBDMBPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GBOEAAJNLKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly FBLKBFNABDO AINFBDJPIJL;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		private FBLKBFNABDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x63ED5E0", Offset = "0x63EBFE0", VA = "0x1863ED5E0", Slot = "4")]
		public ICKIBJLHNAJ MKCIAKANKGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class CMDFPCJNBIM : KIOAPFBDBJK
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class KJIBEAPICIG : ICKIBJLHNAJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly KJIBEAPICIG AINFBDJPIJL;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool BMNHMNKEJDL
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x63EFB30", Offset = "0x63EE530", VA = "0x1863EFB30", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x63EFB50", Offset = "0x63EE550", VA = "0x1863EFB50", Slot = "6")]
			public void OnCompleted(Action ONFBAKCODGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
			public void DMGHOBDMBPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public KJIBEAPICIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CMDFPCJNBIM AINFBDJPIJL;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		private CMDFPCJNBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x63EBCC0", Offset = "0x63EA6C0", VA = "0x1863EBCC0", Slot = "4")]
		public ICKIBJLHNAJ MKCIAKANKGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LBOMBFJKICI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LBOMBFJKICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3972AD0", Offset = "0x39714D0", VA = "0x183972AD0")]
		internal void NDIIHGFMHJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HEEKELOBEIP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HEEKELOBEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x39EC2E0", Offset = "0x39EACE0", VA = "0x1839EC2E0")]
		internal void EJHCIMBGODJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct EECJFKDGDIG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63ED480", Offset = "0x63EBE80", VA = "0x1863ED480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct IPMOODDCHFB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EF850", Offset = "0x63EE250", VA = "0x1863EF850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DPKMJIKJEEP<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x527B8D0", Offset = "0x527A2D0", VA = "0x18527B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x527BA40", Offset = "0x527A440", VA = "0x18527BA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct HJNMDIHLEII<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x39FA4E0", Offset = "0x39F8EE0", VA = "0x1839FA4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x39FAD10", Offset = "0x39F9710", VA = "0x1839FAD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PCJMJMNFNNK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63F2B10", Offset = "0x63F1510", VA = "0x1863F2B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x63F2D10", Offset = "0x63F1710", VA = "0x1863F2D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class AFIFGMKOJOO<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AFIFGMKOJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3972AD0", Offset = "0x39714D0", VA = "0x183972AD0")]
		internal void CDEIADIHOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3972B10", Offset = "0x3971510", VA = "0x183972B10")]
		internal void NMGCGKBBKID(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LFBJJPBPENP<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public APJPAEKNJFH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3E32870", Offset = "0x3E31270", VA = "0x183E32870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E32F20", Offset = "0x3E31920", VA = "0x183E32F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct DNIJNOLCLMP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63ECC30", Offset = "0x63EB630", VA = "0x1863ECC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x63ED420", Offset = "0x63EBE20", VA = "0x1863ED420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LCFMAIHAAJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63F12A0", Offset = "0x63EFCA0", VA = "0x1863F12A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x63F17E0", Offset = "0x63F01E0", VA = "0x1863F17E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MFMLPIOBPBM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4038A00", Offset = "0x4037400", VA = "0x184038A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x392D8A0", Offset = "0x392C2A0", VA = "0x18392D8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EIALBANMLOF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3510C50", Offset = "0x350F650", VA = "0x183510C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x35113D0", Offset = "0x350FDD0", VA = "0x1835113D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NMGOCNBCIAJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x40E5170", Offset = "0x40E3B70", VA = "0x1840E5170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x40E5840", Offset = "0x40E4240", VA = "0x1840E5840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct HBBHCDBFGOL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EF0F0", Offset = "0x63EDAF0", VA = "0x1863EF0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x63EF2D0", Offset = "0x63EDCD0", VA = "0x1863EF2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PNLELAOADGC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63F2E10", Offset = "0x63F1810", VA = "0x1863F2E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x63F3180", Offset = "0x63F1B80", VA = "0x1863F3180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PPNCJPPNOLM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63F31E0", Offset = "0x63F1BE0", VA = "0x1863F31E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x63F34D0", Offset = "0x63F1ED0", VA = "0x1863F34D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NKFPBBIKFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NKFPBBIKFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x63F27E0", Offset = "0x63F11E0", VA = "0x1863F27E0")]
		internal Task HGBLKPAJLPM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GPABHIJCMIF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EEE30", Offset = "0x63ED830", VA = "0x1863EEE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x63EF090", Offset = "0x63EDA90", VA = "0x1863EF090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OLJDKJEHHMN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63F28D0", Offset = "0x63F12D0", VA = "0x1863F28D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x63F2AB0", Offset = "0x63F14B0", VA = "0x1863F2AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BNNAEBBAJPJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EB6A0", Offset = "0x63EA0A0", VA = "0x1863EB6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x63EBA10", Offset = "0x63EA410", VA = "0x1863EBA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct AKHPFKMKPDL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63E9630", Offset = "0x63E8030", VA = "0x1863E9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x63E9920", Offset = "0x63E8320", VA = "0x1863E9920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class LCOHKJFJEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public LCOHKJFJEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63F1840", Offset = "0x63F0240", VA = "0x1863F1840")]
		internal Task GPCEEPEHCMJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HCNHJLPOLHG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EF380", Offset = "0x63EDD80", VA = "0x1863EF380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x63EF5E0", Offset = "0x63EDFE0", VA = "0x1863EF5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HMJGNLHPOMG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EF670", Offset = "0x63EE070", VA = "0x1863EF670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x63EF7F0", Offset = "0x63EE1F0", VA = "0x1863EF7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HHOAPBNIPJJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x39F4470", Offset = "0x39F2E70", VA = "0x1839F4470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x39F46C0", Offset = "0x39F30C0", VA = "0x1839F46C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FIFJIDFJDPF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63EDAC0", Offset = "0x63EC4C0", VA = "0x1863EDAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x63EDEC0", Offset = "0x63EC8C0", VA = "0x1863EDEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? EAKDNKEIFBF;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<PHKKIFFGKBG> OPGEADKDJNE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task MMAKKGLPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x63EA810", Offset = "0x63E9210", VA = "0x1863EA810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63EA330", Offset = "0x63E8D30", VA = "0x1863EA330")]
	public static bool FFOLPFLEBEE(this Task KPCFMNKKKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2717FE0", Offset = "0x27169E0", VA = "0x182717FE0")]
	public static Task<T> EPKCIMBHFGB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63EAA70", Offset = "0x63E9470", VA = "0x1863EAA70")]
	public static Task KKOGMEKOAOK(this Task KPCFMNKKKMJ, CancellationToken AIDIDMJCFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2719FD0", Offset = "0x27189D0", VA = "0x182719FD0")]
	public static Task<TResult> KKOGMEKOAOK<TResult>(this Task<TResult> KPCFMNKKKMJ, CancellationToken AIDIDMJCFEK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x271AAD0", Offset = "0x27194D0", VA = "0x18271AAD0")]
	public static TaskCompletionSource<TResult> KKOGMEKOAOK<TResult>(this TaskCompletionSource<TResult> GMDHFJHLOJC, CancellationToken AIDIDMJCFEK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63EA360", Offset = "0x63E8D60", VA = "0x1863EA360")]
	public static IDisposable? GLFMOKIFGFN(CancellationToken CGBLACFFEEL, CancellationToken BCFADFGCHFN, [Out] CancellationToken FLAIPCNBCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63EA760", Offset = "0x63E9160", VA = "0x1863EA760")]
	[AsyncStateMachine(typeof(EECJFKDGDIG))]
	public static void IBECBHLMJIP(this Task BIKAIHEBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63EB530", Offset = "0x63E9F30", VA = "0x1863EB530")]
	[AsyncStateMachine(typeof(IPMOODDCHFB))]
	public static void PINBEAGLMAL(this Task BIKAIHEBIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2717AF0", Offset = "0x27164F0", VA = "0x182717AF0")]
	[AsyncStateMachine(typeof(DPKMJIKJEEP<>))]
	public static Task CEGMJCCAHAO<TException>(this Task BIKAIHEBIHG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2717930", Offset = "0x2716330", VA = "0x182717930")]
	[AsyncStateMachine(typeof(HJNMDIHLEII<>))]
	public static Task<T> BPBHGPDPOED<T>(this Task<T> CMJEIEIDHIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63EB140", Offset = "0x63E9B40", VA = "0x1863EB140")]
	[AsyncStateMachine(typeof(PCJMJMNFNNK))]
	public static Task<TaskStatus> NHKMFIEDMCB(this Task CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2718130", Offset = "0x2716B30", VA = "0x182718130")]
	public static (Task<T?>?, Action<T?>?) IFAIELGJCBG<T>([Optional] CancellationToken CFAFANOFDNJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2718370", Offset = "0x2716D70", VA = "0x182718370")]
	[AsyncStateMachine(typeof(LFBJJPBPENP<, >))]
	public static Task<List<TResult>> KJDOGFFCKFH<TResult, TInput>(this Task<List<TInput>> KPCFMNKKKMJ, APJPAEKNJFH<TInput, TResult> AGCONDPFKGI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63EA200", Offset = "0x63E8C00", VA = "0x1863EA200")]
	[AsyncStateMachine(typeof(DNIJNOLCLMP))]
	public static Task EOHCAJDHLAM(Task BIKAIHEBIHG, CancellationToken GKJHCAJJFHD, Func<CancellationToken, Task> JKKCMPGBJNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63E9F00", Offset = "0x63E8900", VA = "0x1863E9F00")]
	[AsyncStateMachine(typeof(LCFMAIHAAJJ))]
	public static Task DLPLLGOCPAP(Func<CancellationToken, Task> AIHLNHANNCP, TimeSpan CBKBNMKLFNN, [Optional] CancellationToken GKJHCAJJFHD, [Optional] Action<OperationCanceledException>? HJOCHICPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2717BC0", Offset = "0x27165C0", VA = "0x182717BC0")]
	[AsyncStateMachine(typeof(MFMLPIOBPBM<>))]
	public static Task<T> DLPLLGOCPAP<T>(Func<CancellationToken, Task<T>> AIHLNHANNCP, TimeSpan CBKBNMKLFNN, [Optional] CancellationToken GKJHCAJJFHD, [Optional] Func<OperationCanceledException, T>? HJOCHICPDCM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2717F00", Offset = "0x2716900", VA = "0x182717F00")]
	[AsyncStateMachine(typeof(EIALBANMLOF<>))]
	public static Task<IEnumerable<Task<T>>> EJANLHKCECB<T>(IEnumerable<Task<T>> LPEEGGIMNJG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x271B2E0", Offset = "0x2719CE0", VA = "0x18271B2E0")]
	[AsyncStateMachine(typeof(NMGOCNBCIAJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> KNIBLDMLPJC<T1, T2, T3, T4>(Task<T1> JHJKBHEENED, Task<T2> DMALIFMIMPA, Task<T3> BCOFNGPOEEO, Task<T4> HOOIHAFFPCG) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63E9980", Offset = "0x63E8380", VA = "0x1863E9980")]
	[AsyncStateMachine(typeof(HBBHCDBFGOL))]
	public static Task AENMGIONMNJ(Func<bool> AJBHONGPHFM, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63E9A70", Offset = "0x63E8470", VA = "0x1863E9A70")]
	[AsyncStateMachine(typeof(PNLELAOADGC))]
	public static Task AENMGIONMNJ(Func<bool> AJBHONGPHFM, TimeSpan LMFHHDECPCH, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63EB010", Offset = "0x63E9A10", VA = "0x1863EB010")]
	[AsyncStateMachine(typeof(PPNCJPPNOLM))]
	public static Task NEMDICHDBOH(Func<bool> AJBHONGPHFM, TimeSpan CBKBNMKLFNN, [Optional] CancellationToken CFAFANOFDNJ, [Optional] Action<OperationCanceledException>? HJOCHICPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63EAED0", Offset = "0x63E98D0", VA = "0x1863EAED0")]
	[AsyncStateMachine(typeof(GPABHIJCMIF))]
	public static Task NEMDICHDBOH(Func<bool> AJBHONGPHFM, TimeSpan CBKBNMKLFNN, TimeSpan LMFHHDECPCH, [Optional] CancellationToken CFAFANOFDNJ, [Optional] Action<OperationCanceledException>? HJOCHICPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63EACD0", Offset = "0x63E96D0", VA = "0x1863EACD0")]
	[AsyncStateMachine(typeof(OLJDKJEHHMN))]
	public static Task MHHNFHEDFEF(Func<bool> AJBHONGPHFM, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63EADC0", Offset = "0x63E97C0", VA = "0x1863EADC0")]
	[AsyncStateMachine(typeof(BNNAEBBAJPJ))]
	public static Task MHHNFHEDFEF(Func<bool> AJBHONGPHFM, TimeSpan LMFHHDECPCH, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63EA5E0", Offset = "0x63E8FE0", VA = "0x1863EA5E0")]
	[AsyncStateMachine(typeof(AKHPFKMKPDL))]
	public static Task HAAJLLKGMDB(Func<bool> AJBHONGPHFM, TimeSpan CBKBNMKLFNN, [Optional] CancellationToken CFAFANOFDNJ, [Optional] Action<OperationCanceledException>? HJOCHICPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x63EA4A0", Offset = "0x63E8EA0", VA = "0x1863EA4A0")]
	[AsyncStateMachine(typeof(HCNHJLPOLHG))]
	public static Task HAAJLLKGMDB(Func<bool> AJBHONGPHFM, TimeSpan CBKBNMKLFNN, TimeSpan LMFHHDECPCH, [Optional] CancellationToken CFAFANOFDNJ, [Optional] Action<OperationCanceledException>? HJOCHICPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63EB440", Offset = "0x63E9E40", VA = "0x1863EB440")]
	[Obsolete]
	[AsyncStateMachine(typeof(HMJGNLHPOMG))]
	public static Task OHEPIFNKJAP(this Task KPCFMNKKKMJ, Action OGGGPFNNAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x271B580", Offset = "0x2719F80", VA = "0x18271B580")]
	[Obsolete]
	[AsyncStateMachine(typeof(HHOAPBNIPJJ<>))]
	public static Task OHEPIFNKJAP<T>(this Task<T> KPCFMNKKKMJ, Action<T> OGGGPFNNAEM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63EA150", Offset = "0x63E8B50", VA = "0x1863EA150")]
	private static void EKFFKPBCPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63E9B80", Offset = "0x63E8580", VA = "0x1863E9B80")]
	public static bool DLFEKALHJKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63EB2B0", Offset = "0x63E9CB0", VA = "0x1863EB2B0")]
	private static void OEMDPAIHDOE(SynchronizationContext AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63EA030", Offset = "0x63E8A30", VA = "0x1863EA030")]
	private static void DPBPIGCBJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x63EA8D0", Offset = "0x63E92D0", VA = "0x1863EA8D0")]
	public static void JMKKPMMDOFF([Optional] string? CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x63EB230", Offset = "0x63E9C30", VA = "0x1863EB230")]
	public static void NKPMMONJFFB([Optional] string? CPPFNMDMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63EA710", Offset = "0x63E9110", VA = "0x1863EA710")]
	public static KIOAPFBDBJK HHNKHJFBAEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63EA880", Offset = "0x63E9280", VA = "0x1863EA880")]
	public static KIOAPFBDBJK IPLBEKICECH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63EA9A0", Offset = "0x63E93A0", VA = "0x1863EA9A0")]
	[AsyncStateMachine(typeof(FIFJIDFJDPF))]
	public static Task KIHNHGCIKJC(Func<Task> KNCKABMPAIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JFFHACELPPM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
	public JFFHACELPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GHDCBPLEKGB : HMJDNPNFJLC
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly HMJDNPNFJLC AINFBDJPIJL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime JFAGAIPLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x63EE160", Offset = "0x63ECB60", VA = "0x1863EE160", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset EJOKIJBNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x63EE1A0", Offset = "0x63ECBA0", VA = "0x1863EE1A0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GHDCBPLEKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HMJDNPNFJLC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime JFAGAIPLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset EJOKIJBNJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MGBIJOBKACO
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long LKDEGALBGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x63F2270", Offset = "0x63F0C70", VA = "0x1863F2270")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long NDHDMNADKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x63F24C0", Offset = "0x63F0EC0", VA = "0x1863F24C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double HAEFMJCMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x63F2040", Offset = "0x63F0A40", VA = "0x1863F2040")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double IOJPGOFDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x63F2350", Offset = "0x63F0D50", VA = "0x1863F2350")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double HOHEFIGAPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x63F21D0", Offset = "0x63F0BD0", VA = "0x1863F21D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double HNBCJFFINBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x63F2220", Offset = "0x63F0C20", VA = "0x1863F2220")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x63F23A0", Offset = "0x63F0DA0", VA = "0x1863F23A0")]
	public static double NMILBGGLBJE(long NBBHNKPKONM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x63F1FB0", Offset = "0x63F09B0", VA = "0x1863F1FB0")]
	public static double ANJFAEKLBFP(long NBBHNKPKONM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x63F22C0", Offset = "0x63F0CC0", VA = "0x1863F22C0")]
	public static double MCNJDFBAKAE(double CBOBJNCAGCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x63F2430", Offset = "0x63F0E30", VA = "0x1863F2430")]
	public static long OBOIOKDKIMG(long BAFOADOMFEH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x63F2090", Offset = "0x63F0A90", VA = "0x1863F2090")]
	public static long BJJIHOFFOOG(long LHBJNHIOBIH, long PMCAOGFBCPI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x63F2100", Offset = "0x63F0B00", VA = "0x1863F2100")]
	public static double DGKACKLELEN(long LHBJNHIOBIH, long PMCAOGFBCPI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x63F20A0", Offset = "0x63F0AA0", VA = "0x1863F20A0")]
	public static double DGIDJHBOFGJ(long LHBJNHIOBIH, long PMCAOGFBCPI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class LNCBKCIIADI : JMEIOELHBCB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan OMODEMOMGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer MDGFMJGBLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan CBKBNMKLFNN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan FGFCMCKPGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x63F1AF0", Offset = "0x63F04F0", VA = "0x1863F1AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? NLKMAGNKAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x63F1F40", Offset = "0x63F0940", VA = "0x1863F1F40")]
	[Preserve]
	public LNCBKCIIADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x63F1CF0", Offset = "0x63F06F0", VA = "0x1863F1CF0")]
	public LNCBKCIIADI(TimeSpan CBKBNMKLFNN, [Optional] Action? OICMEAGCFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x63F1950", Offset = "0x63F0350", VA = "0x1863F1950", Slot = "7")]
	public void HBIPAHEJJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x63F1A80", Offset = "0x63F0480", VA = "0x1863F1A80", Slot = "8")]
	public void OJNJKMBKPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x63F1C50", Offset = "0x63F0650", VA = "0x1863F1C50", Slot = "9")]
	public void PLAOOGBPCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x83D8B0", Offset = "0x83C2B0", VA = "0x18083D8B0")]
	private void KAEPFNOOJKB(object GCGDEDCNCCJ, ElapsedEventArgs GAGIFMPCGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x63F19E0", Offset = "0x63F03E0", VA = "0x1863F19E0")]
	private static void IIJPOPCNOIJ(TimeSpan CKHBPBDMIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x63F18B0", Offset = "0x63F02B0", VA = "0x1863F18B0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OKMJKJEMLAC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? DBDAOHAJPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string NJKCIHKELJF;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2510", Offset = "0x5ED0F10", VA = "0x185ED2510")]
	public OKMJKJEMLAC(string PIHIABBFEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3A717E0", Offset = "0x3A701E0", VA = "0x183A717E0")]
	public OKMJKJEMLAC(string FGGJAMLKMFJ, string PIHIABBFEIL)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct DMEJEMLFNMI : IEquatable<DMEJEMLFNMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint PCFJIJDCFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int FMOAFHNPBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float JGLEGDMPFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort NKKGHCIFFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort FGLEDFMBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short CIMILJAOJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short PGNCBHEHDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char LHEJCPODIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char BCNJGIJLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte MBCEEHMPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte GKIBFKBJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte HGHMGOCCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte BLMHDDGDNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool AGCGBHEAPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool OJEGDLMDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool OMECAALPMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool FBJDAOCNBFP;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static DMEJEMLFNMI EBFNOMFJPJA(uint PKLJLHOCGDF)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static DMEJEMLFNMI IFMBEPDFLBC(int EBJLBDALNGP)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x63EBE30", Offset = "0x63EA830", VA = "0x1863EBE30")]
	public static DMEJEMLFNMI INLAEHILJDO(float BGBNICHMNBG)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x63EBE10", Offset = "0x63EA810", VA = "0x1863EBE10")]
	public static DMEJEMLFNMI OKMGEKFHHOL(byte MLEGJBINDID, byte OBHOHOFFPON, byte KDJOFOFDGMD, byte GGAFPGNAOEK)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x63EBE10", Offset = "0x63EA810", VA = "0x1863EBE10")]
	public static DMEJEMLFNMI GPDFPDCMCJC(bool OCONIEOMEIM, bool OIKCLDKDIOG, bool COKBFODCGLJ, bool PIKJCOHMADK)
	{
		return default(DMEJEMLFNMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x63EBE10", Offset = "0x63EA810", VA = "0x1863EBE10")]
	public static DMEJEMLFNMI GPIGJCHDPOL(byte FDCDAPFCHDE, byte KEFANACGGBB, byte OGBCFHOIHGP, byte CPFDDHMOFMM)
	{
		return default(DMEJEMLFNMI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x18C96F0", Offset = "0x18C80F0", VA = "0x1818C96F0")]
	public static bool PIEEFOPMNNK(DMEJEMLFNMI OOMAGBGJFDN, DMEJEMLFNMI CBOPOPHGBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB510", Offset = "0x8B9F10", VA = "0x1808BB510", Slot = "4")]
	public bool Equals(DMEJEMLFNMI HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x63EBD90", Offset = "0x63EA790", VA = "0x1863EBD90", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x95A2D0", Offset = "0x958CD0", VA = "0x18095A2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x63EBE40", Offset = "0x63EA840", VA = "0x1863EBE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HCCMLDAOPPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong PHEJGIJDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long PONFMCMDLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double LHHLNFFFJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint NOCLEHELJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint BPNIDMGEGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int KOJECHNHBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int MPNHIPKNJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float MNONKJADCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float FGMCGDPHNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort NKKGHCIFFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort FGLEDFMBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort OMCKFOENLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort IGGCGKMMPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short CIMILJAOJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short PGNCBHEHDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short BIMCIJJONJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short CCLPALLHBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char LHEJCPODIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char BCNJGIJLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char JEJINHBEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char FPICGHCKCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte MBCEEHMPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte GKIBFKBJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte HGHMGOCCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte BLMHDDGDNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte EJOLCNBFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte IHLELHDBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte KKFOEDIAJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte IJDEHMIIEBI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x63EF330", Offset = "0x63EDD30", VA = "0x1863EF330")]
	public static HCCMLDAOPPM OLCPJHCMOKI(byte MLEGJBINDID, byte OBHOHOFFPON, byte KDJOFOFDGMD, byte GGAFPGNAOEK, byte MFAMCPIIJLF, byte EKGJAIHEHAO, byte JIFIEKPOAPK, byte KONHHNIBIEF)
	{
		return default(HCCMLDAOPPM);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct FGGLDENEFMP : IEquatable<FGGLDENEFMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte DHMIJDAOODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool PBPAJEBLFHP;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x23D6230", Offset = "0x23D4C30", VA = "0x1823D6230")]
	public static FGGLDENEFMP OKMGEKFHHOL(byte HAJIMDAOAOP)
	{
		return default(FGGLDENEFMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x23D6230", Offset = "0x23D4C30", VA = "0x1823D6230")]
	public static FGGLDENEFMP GPDFPDCMCJC(bool CHFMAPCMGOI)
	{
		return default(FGGLDENEFMP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x63ED850", Offset = "0x63EC250", VA = "0x1863ED850")]
	public static bool PIEEFOPMNNK(FGGLDENEFMP OOMAGBGJFDN, FGGLDENEFMP CBOPOPHGBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55FABE0", Offset = "0x55F95E0", VA = "0x1855FABE0", Slot = "4")]
	public bool Equals(FGGLDENEFMP HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x63ED7B0", Offset = "0x63EC1B0", VA = "0x1863ED7B0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x63ED840", Offset = "0x63EC240", VA = "0x1863ED840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x63ED860", Offset = "0x63EC260", VA = "0x1863ED860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OJGDOPJNJAG<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T FJDNBLGLGIL;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4218B60", Offset = "0x4217560", VA = "0x184218B60")]
	public OJGDOPJNJAG(T KGCFOMBNAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BIHJAIPMCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x271BA50", Offset = "0x271A450", VA = "0x18271BA50")]
	public static IEnumerable<T> AOMOGDLOACF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static T[] MEOGCEBDNBI<T>(params T[] KJNCBLMLDFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static IEnumerable<T> FAJAGPAFNEF<T>(params T[] KJNCBLMLDFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static HashSet<T> OADJGECGINL<T>(params T[] KJNCBLMLDFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x271BAE0", Offset = "0x271A4E0", VA = "0x18271BAE0")]
	public static KeyValuePair<TKey, TValue> EMFBLLIOGHB<TKey, TValue>([In] TKey KLDFLAABJKH, [In] TValue AEJBOLFACJC) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x271BA70", Offset = "0x271A470", VA = "0x18271BA70")]
	public static List<T> CJIGHELKFEI<T>(IEnumerable<T> APNNJDENMKO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class IDKPDNLJBNL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string LOHFCGBKHDE;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
	public IDKPDNLJBNL(string MGANAFDPCCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object DEHBGMHGFCP<T>([In] T CADHKPGCKBL);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object EPFHILNPILC<T>(T CADHKPGCKBL);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[EIGMFIPNHFB]
public delegate string JBPNEDOAFDD(string LCECEOIPEEK, string? IFNAJKAPIMA, bool PDPEBPBMFIN);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[EIGMFIPNHFB]
public delegate void IPHKKLLMMEK(string CPPFNMDMGHI);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[EIGMFIPNHFB]
public delegate void MFDDEOKAIGM(Exception PBPEDJNJMOI);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object HHCCMKMHDFI();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[EIGMFIPNHFB]
public delegate bool EHPOCKJNDLD();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[EIGMFIPNHFB]
public delegate string FCIMEPBCIIF(object COMOOAEHALC);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class HODGPJICGKN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
	public HODGPJICGKN()
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
