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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61F4380", Offset = "0x61F3580", VA = "0x1861F4380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class ODOGCDBKLKN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61F4750", Offset = "0x61F3950", VA = "0x1861F4750")]
	public ODOGCDBKLKN(bool MPHKMGIIJJI, string NCDNMLGOJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DLCIDDHBCKA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> IPAHLAIMICF(CancellationToken OBNOJDAGGOE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GEHMGMIOACC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public DLCIDDHBCKA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public IPAHLAIMICF taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x37395D0", Offset = "0x37387D0", VA = "0x1837395D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x373A630", Offset = "0x3739830", VA = "0x18373A630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource OHBKFBPCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? HDFLNHDHIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? FAJNOOCKDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5080780", Offset = "0x507F980", VA = "0x185080780")]
	[AsyncStateMachine(typeof(DLCIDDHBCKA<>.GEHMGMIOACC))]
	public Task<TResult> FPMPMEBIAOG(IPAHLAIMICF IEEJCKJCOMH, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5080710", Offset = "0x507F910", VA = "0x185080710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50808C0", Offset = "0x507FAC0", VA = "0x1850808C0")]
	public DLCIDDHBCKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KDEAHAKEJHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> JMOECLMLKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T FMINBKHGIKA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37A05E0", Offset = "0x379F7E0", VA = "0x1837A05E0")]
	public KDEAHAKEJHN([In] T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B49060", Offset = "0x3B48260", VA = "0x183B49060", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B495C0", Offset = "0x3B487C0", VA = "0x183B495C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3B498C0", Offset = "0x3B48AC0", VA = "0x183B498C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CAMMDHJJGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61EB1F0", Offset = "0x61EA3F0", VA = "0x1861EB1F0")]
	public static void EMLMEBIPCML(this CancellationTokenSource OHBKFBPCNAN, bool FKFBLCPMNLO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class HNOBELDNGHL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
	public HNOBELDNGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class AMIJKAOLDJP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
	public AMIJKAOLDJP(string CONCCDNCDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MHDBELCDBAN
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x284FAF0", Offset = "0x284ECF0", VA = "0x18284FAF0")]
	public static IPBGBFEOHFI JMNFINGIJDK<T>()
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x284FD40", Offset = "0x284EF40", VA = "0x18284FD40")]
	public static IPBGBFEOHFI LDDKJPMAAON<T>([CallerMemberName] string NLBAJPAADNH = "") where T : notnull
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x284FA70", Offset = "0x284EC70", VA = "0x18284FA70")]
	public static IPBGBFEOHFI JMNFINGIJDK<T>(this T BBEDKDLIKBI) where T : notnull
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x284FDD0", Offset = "0x284EFD0", VA = "0x18284FDD0")]
	public static IPBGBFEOHFI MGDOJHCOEJM<T>(this T BBEDKDLIKBI, [CallerMemberName] string NLBAJPAADNH = "") where T : notnull
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x284FCA0", Offset = "0x284EEA0", VA = "0x18284FCA0")]
	public static IPBGBFEOHFI LDDKJPMAAON<T>(this T KPBGCHDNDLM, [CallerMemberName] string NLBAJPAADNH = "") where T : notnull
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61F3D00", Offset = "0x61F2F00", VA = "0x1861F3D00")]
	public static IPBGBFEOHFI LDDKJPMAAON(string LDLLLDDMFPM, [CallerMemberName] string NLBAJPAADNH = "")
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61F3C60", Offset = "0x61F2E60", VA = "0x1861F3C60")]
	public static string AFGJAMBBPLI(this object KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool BHLLCFOHPDN();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[HNOBELDNGHL]
public delegate long EHIBKHKOAAN();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KNIBAAAFLFM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static GFFGHLDKJJM LEILLDGCKAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GFFGHLDKJJM CMDOFGELHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61F28C0", Offset = "0x61F1AC0", VA = "0x1861F28C0")]
		get
		{
			return default(GFFGHLDKJJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FDOGGMPFLCF GEFIHEDLHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61F2BC0", Offset = "0x61F1DC0", VA = "0x1861F2BC0")]
		get
		{
			return default(FDOGGMPFLCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static CFPBIKPJLDP OEGNMLBKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61F27D0", Offset = "0x61F19D0", VA = "0x1861F27D0")]
		get
		{
			return default(CFPBIKPJLDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool JDAMCIDHPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61F2C10", Offset = "0x61F1E10", VA = "0x1861F2C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61F29B0", Offset = "0x61F1BB0", VA = "0x1861F29B0")]
	public static void JGKKGEAKLMB([In] GFFGHLDKJJM HOHIIDAEKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61F2630", Offset = "0x61F1830", VA = "0x1861F2630")]
	public static void BHODMEFJDOG(string LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61F2700", Offset = "0x61F1900", VA = "0x1861F2700")]
	public static void EAPGJLNFPHM(string LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x281E840", Offset = "0x281DA40", VA = "0x18281E840")]
	public static void EAPGJLNFPHM<T>(T CIENKKNJAIC, BDPADBAOGPK<T> LFMFEFFGFLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61F2910", Offset = "0x61F1B10", VA = "0x1861F2910")]
	public static void IKKICMNGMPF(Exception PHKDDEHKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61F2CF0", Offset = "0x61F1EF0", VA = "0x1861F2CF0")]
	public static void NNOELHJCHDJ(string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61F2B60", Offset = "0x61F1D60", VA = "0x1861F2B60")]
	public static void JNGDPKOGDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61F24E0", Offset = "0x61F16E0", VA = "0x1861F24E0")]
	public static string AFGJAMBBPLI(object MFLACBLODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61F2C80", Offset = "0x61F1E80", VA = "0x1861F2C80")]
	public static long MAIMHOJLOJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61F2820", Offset = "0x61F1A20", VA = "0x1861F2820")]
	public static bool GKHKPEMMHEG(bool MELPJNMAJNF, string LFMFEFFGFLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61F2560", Offset = "0x61F1760", VA = "0x1861F2560")]
	public static double AGJBPOGOJHM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GFFGHLDKJJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly FDOGGMPFLCF GEFIHEDLHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly CFPBIKPJLDP OEGNMLBKKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly OHEBDAMDCDD FJLPIGAKBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EHIBKHKOAAN HPHDKCOJLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly INCDDFOJKBG CONHPNHPMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly BHLLCFOHPDN MEJDHBBKBLO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly OHEBDAMDCDD BCMMCIOHJAM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EHIBKHKOAAN DNGMKALAKMB;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly INCDDFOJKBG AFCPPPDHALN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly BHLLCFOHPDN DFAPACONNKI;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GFFGHLDKJJM LNBIPJDBGMB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IOBGPOINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61F0840", Offset = "0x61EFA40", VA = "0x1861F0840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61F1110", Offset = "0x61F0310", VA = "0x1861F1110")]
	public GFFGHLDKJJM([In] FDOGGMPFLCF MAKKPKKNNFD, [In] CFPBIKPJLDP HJDFJGOJCDB, OHEBDAMDCDD ANFLBGGEMDA, EHIBKHKOAAN LENKECKNEIB, INCDDFOJKBG IAAPOOFKNBB, BHLLCFOHPDN OEIEMJONNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61F09E0", Offset = "0x61EFBE0", VA = "0x1861F09E0")]
	private static string DMOJHEMINMD(object MFLACBLODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0")]
	private static long JJAPBCCCMBD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	private static string DJJGIAGLAJE(string CPJNFDEECBG, string? IMAIGADBGGK, bool BPHMMAIIKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	private static bool OLANCHIIGMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61F0730", Offset = "0x61EF930", VA = "0x1861F0730")]
	private static GFFGHLDKJJM AOOEDMOJELJ()
	{
		return default(GFFGHLDKJJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HGIMGCKDAIA
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMGIACOHLMI FKOAGECFAHE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IMGIACOHLMI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MJPGAACCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBDGAHLJJIK();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IOADHLEGEJM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMFILHONGAG([In] T NFMPGFPPFKH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void AAIDEPPIDJG<T>([In] T CIENKKNJAIC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct JPDAAFFALJF<T> : IEquatable<JPDAAFFALJF<T>>, IOADHLEGEJM<JPDAAFFALJF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T FMINBKHGIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int ANPNOFMCDKC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1DD1660", Offset = "0x1DD0860", VA = "0x181DD1660")]
	public JPDAAFFALJF([In] T AFCGKMGKPEF, int ILNNGHKJMBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBF00", Offset = "0x3ACB100", VA = "0x183ACBF00")]
	public static bool CDBCKLPENDN([In] JPDAAFFALJF<T> GNBALBEAIKA, [In] JPDAAFFALJF<T> ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC530", Offset = "0x3ACB730", VA = "0x183ACC530", Slot = "4")]
	public bool Equals(JPDAAFFALJF<T> NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38AD8E0", Offset = "0x38ACAE0", VA = "0x1838AD8E0", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD150", Offset = "0x3ACC350", VA = "0x183ACD150")]
	public bool MMFILHONGAG([In] JPDAAFFALJF<T> NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC920", Offset = "0x3ACBB20", VA = "0x183ACC920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD680", Offset = "0x3ACC880", VA = "0x183ACD680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3ACCE40", Offset = "0x3ACC040", VA = "0x183ACCE40")]
	public void LMOHFPHIABH([Out] T AFCGKMGKPEF, [Out] int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD3D0", Offset = "0x3ACC5D0", VA = "0x183ACD3D0")]
	public (T, int) PCKOHCCPLAH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC4E0", Offset = "0x3ACB6E0", VA = "0x183ACC4E0", Slot = "5")]
	private bool CFHONCFOILD([In] JPDAAFFALJF<T> NFMPGFPPFKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ECHPJBCAMAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2636A40", Offset = "0x2635C40", VA = "0x182636A40")]
	public static JPDAAFFALJF<T> GOMGEEBODDD<T>([In] T AFCGKMGKPEF, int ILNNGHKJMBD) where T : notnull
	{
		return default(JPDAAFFALJF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HJLMFKFMCAF
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x279C550", Offset = "0x279B750", VA = "0x18279C550")]
	public static bool MMFILHONGAG<T, U>([In] T KPBGCHDNDLM, [In] U MFLACBLODGN) where T : notnull, IOADHLEGEJM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult GDMFDBPAHPO<T, out TResult>([In] T CIENKKNJAIC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OLOKNOCMLBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan KHAIKLIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? KNECMKLCIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDALJGFIKBD();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMHEBIBCLJA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKJAHBMHFGD();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct FDOGGMPFLCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly AHEAMPJHLOI NMBPIKJNEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly NPGAEFKDBEH OAODFIHILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly AHEAMPJHLOI NNAJKKODCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly NPGAEFKDBEH BCJECLJLMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly AHEAMPJHLOI EABGFEOELIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly NPGAEFKDBEH LLEKIOBGIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly OPEDOKOGOKB NHFFNBBMLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly AHEAMPJHLOI KNEDDFGKKKJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly NPGAEFKDBEH CFCOFHDMOGA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly AHEAMPJHLOI NMBOAOOKAFF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NPGAEFKDBEH CKIOAFKNOJP;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly AHEAMPJHLOI ODGMFLPLEDJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly NPGAEFKDBEH GGNKLGJOJEG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly OPEDOKOGOKB HIGMEFKMLNF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly FDOGGMPFLCF LNBIPJDBGMB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly AHEAMPJHLOI IKJBHAKEKJH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IOBGPOINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61EEA50", Offset = "0x61EDC50", VA = "0x1861EEA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9DB860", Offset = "0x9DAA60", VA = "0x1809DB860")]
	public FDOGGMPFLCF(AHEAMPJHLOI GGFMEANCLGB, NPGAEFKDBEH MFAGDIEJJGJ, AHEAMPJHLOI BEHIHPLPEPE, NPGAEFKDBEH PHHADAINOGE, AHEAMPJHLOI MAGEKJFPIDO, NPGAEFKDBEH JALIEFAAJPG, OPEDOKOGOKB GMIMBNIFLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	private static bool DFMOHICEKGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void EOOKOMBPNPA(string LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	private static bool NGLKKGGOGKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void MPCKPBOLJHI(string LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0")]
	private static bool PBLIGIFOIGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void FOMOHAAIHFF(string LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void KJKKGEEACAE(Exception PHKDDEHKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61EE910", Offset = "0x61EDB10", VA = "0x1861EE910")]
	private static FDOGGMPFLCF AOOEDMOJELJ()
	{
		return default(FDOGGMPFLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300")]
	private static bool NFPHGGHKKPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61EEC50", Offset = "0x61EDE50", VA = "0x1861EEC50")]
	public void BHODMEFJDOG(object LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61EECC0", Offset = "0x61EDEC0", VA = "0x1861EECC0")]
	public void EAPGJLNFPHM(object LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x19CE400", Offset = "0x19CD600", VA = "0x1819CE400")]
	public void IKKICMNGMPF(Exception PHKDDEHKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61EED30", Offset = "0x61EDF30", VA = "0x1861EED30")]
	public void EAPGJLNFPHM(GIFDFIAFLEO LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2746F80", Offset = "0x2746180", VA = "0x182746F80")]
	public void EAPGJLNFPHM<T>(T CIENKKNJAIC, BDPADBAOGPK<T> LFMFEFFGFLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2746E00", Offset = "0x2746000", VA = "0x182746E00")]
	public void BHODMEFJDOG<T>([In] T CIENKKNJAIC, CNMKEKOHKLF<T> LFMFEFFGFLH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61EEE10", Offset = "0x61EE010", VA = "0x1861EEE10")]
	public bool GKHKPEMMHEG(bool MELPJNMAJNF, string LFMFEFFGFLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct IPBGBFEOHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string FMINBKHGIKA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	public IPBGBFEOHFI(string AFCGKMGKPEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0")]
	public static string MLCODHGANFM([In] IPBGBFEOHFI KPBGCHDNDLM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x14C41C0", Offset = "0x14C33C0", VA = "0x1814C41C0")]
	public static IPBGBFEOHFI MLCODHGANFM(string NFMPGFPPFKH)
	{
		return default(IPBGBFEOHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61F1B90", Offset = "0x61F0D90", VA = "0x1861F1B90")]
	public string KAGDJOHODFC(string NALJFJHKPGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61F1AB0", Offset = "0x61F0CB0", VA = "0x1861F1AB0")]
	public string DFJAKABKMDD(object BHCBHFHAIBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct PGENBOHGKNI : IEquatable<PGENBOHGKNI>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "4")]
	public bool Equals(PGENBOHGKNI NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61F4C20", Offset = "0x61F3E20", VA = "0x1861F4C20", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61F4C70", Offset = "0x61F3E70", VA = "0x1861F4C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61F4C80", Offset = "0x61F3E80", VA = "0x1861F4C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[MNMOIINOFAC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CKBGFGHPBIC<T> : IEquatable<CKBGFGHPBIC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T FMINBKHGIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool KLENNMFKFEL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LPIALJJEKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4AB8D50", Offset = "0x4AB7F50", VA = "0x184AB8D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4AB90C0", Offset = "0x4AB82C0", VA = "0x184AB90C0")]
	public CKBGFGHPBIC([In] T AFCGKMGKPEF, bool FDFJKLOJJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8230", Offset = "0x4AB7430", VA = "0x184AB8230")]
	public static bool CDBCKLPENDN([In] CKBGFGHPBIC<T> GNBALBEAIKA, [In] CKBGFGHPBIC<T> ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC530", Offset = "0x3ACB730", VA = "0x183ACC530", Slot = "4")]
	public bool Equals(CKBGFGHPBIC<T> NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4AB82F0", Offset = "0x4AB74F0", VA = "0x184AB82F0", Slot = "0")]
	public override bool Equals(object NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8A30", Offset = "0x4AB7C30", VA = "0x184AB8A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4AB8D60", Offset = "0x4AB7F60", VA = "0x184AB8D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class ODPFKPBMEHE
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x28CF340", Offset = "0x28CE540", VA = "0x1828CF340")]
	public static CKBGFGHPBIC<T> OPHIFHLFMAA<T>([In] T AFCGKMGKPEF) where T : notnull
	{
		return default(CKBGFGHPBIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x28CF460", Offset = "0x28CE660", VA = "0x1828CF460")]
	public static CKBGFGHPBIC<T?> PHAFMAJJPJB<T>()
	{
		return default(CKBGFGHPBIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28CF2A0", Offset = "0x28CE4A0", VA = "0x1828CF2A0")]
	public static bool HKCLHCINBLC<T>([In] this CKBGFGHPBIC<T> CENGOBEONGL, [Out][NotNullWhen(true)] T AFCGKMGKPEF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct CFPBIKPJLDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr NNOELHJCHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr JNGDPKOGDCL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr MMGBLJAKDDF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr KAOCADDBNPK;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CFPBIKPJLDP LNBIPJDBGMB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IOBGPOINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61EB2B0", Offset = "0x61EA4B0", VA = "0x1861EB2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x90CFA0", Offset = "0x90C1A0", VA = "0x18090CFA0")]
	public CFPBIKPJLDP(IntPtr EHLBPPEDAMC, IntPtr BGEHMKOHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void JEEMGNLLBOM(string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	private static void EGHLHGHEFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61EB220", Offset = "0x61EA420", VA = "0x1861EB220")]
	private static CFPBIKPJLDP AOOEDMOJELJ()
	{
		return default(CFPBIKPJLDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct NMMPCOFBJJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr GBDJJFHPNCP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	private NMMPCOFBJJG(IntPtr BGEHMKOHNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61F4280", Offset = "0x61F3480", VA = "0x1861F4280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61F4290", Offset = "0x61F3490", VA = "0x1861F4290")]
	public static NMMPCOFBJJG GOMGEEBODDD(string NLBAJPAADNH)
	{
		return default(NMMPCOFBJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDE00", Offset = "0x1DBD000", VA = "0x181DBDE00")]
	public static NMMPCOFBJJG GOMGEEBODDD([In] CFPBIKPJLDP HJDFJGOJCDB, string NLBAJPAADNH)
	{
		return default(NMMPCOFBJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DBDE40", Offset = "0x1DBD040", VA = "0x181DBDE40")]
	public static NMMPCOFBJJG GOMGEEBODDD([In] CFPBIKPJLDP HJDFJGOJCDB, Func<string> NLBAJPAADNH)
	{
		return default(NMMPCOFBJJG);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EEOEHELKIGP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool NCBNFICHAFB<in TInput, TResult>(TInput NKIKIMMJFMI, [Out] TResult JKJJELABMHK);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class KNBBAIGGGDL : HGIMGCKDAIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class NIANKGGBEKA : IMGIACOHLMI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly NIANKGGBEKA MJANIPKLNPJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool MJPGAACCKIN
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x61F4040", Offset = "0x61F3240", VA = "0x1861F4040", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x61F40A0", Offset = "0x61F32A0", VA = "0x1861F40A0", Slot = "6")]
			public void OnCompleted(Action BPECPPAADCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
			public void CBDGAHLJJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public NIANKGGBEKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly KNBBAIGGGDL MJANIPKLNPJ;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		private KNBBAIGGGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61F2410", Offset = "0x61F1610", VA = "0x1861F2410", Slot = "4")]
		public IMGIACOHLMI FKOAGECFAHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class HFKPGHKLJAA : HGIMGCKDAIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class PAEKFFCMOKP : IMGIACOHLMI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly PAEKFFCMOKP MJANIPKLNPJ;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool MJPGAACCKIN
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x61F4870", Offset = "0x61F3A70", VA = "0x1861F4870", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x61F4890", Offset = "0x61F3A90", VA = "0x1861F4890", Slot = "6")]
			public void OnCompleted(Action BPECPPAADCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
			public void CBDGAHLJJIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public PAEKFFCMOKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly HFKPGHKLJAA MJANIPKLNPJ;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		private HFKPGHKLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61F11C0", Offset = "0x61F03C0", VA = "0x1861F11C0", Slot = "4")]
		public IMGIACOHLMI FKOAGECFAHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LAHHNLENLIE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public LAHHNLENLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C04EA0", Offset = "0x3C040A0", VA = "0x183C04EA0")]
		internal void CKECEPELHDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ONPJHMAJJOK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ONPJHMAJJOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4085FB0", Offset = "0x40851B0", VA = "0x184085FB0")]
		internal void AALFIPGMMLC(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KGCJLKIDPIB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F1CF0", Offset = "0x61F0EF0", VA = "0x1861F1CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x89C0E0", Offset = "0x89B2E0", VA = "0x18089C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JHOLCIPEIKO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F1BE0", Offset = "0x61F0DE0", VA = "0x1861F1BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x89C0E0", Offset = "0x89B2E0", VA = "0x18089C0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GDHAENNNOCB<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x37302D0", Offset = "0x372F4D0", VA = "0x1837302D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3730440", Offset = "0x372F640", VA = "0x183730440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GPPILJJIFLH<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3768F30", Offset = "0x3768130", VA = "0x183768F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3769370", Offset = "0x3768570", VA = "0x183769370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KMDNBCCPFNG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F21A0", Offset = "0x61F13A0", VA = "0x1861F21A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61F23A0", Offset = "0x61F15A0", VA = "0x1861F23A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NMIJIJMEAHC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public NMIJIJMEAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C04EA0", Offset = "0x3C040A0", VA = "0x183C04EA0")]
		internal void MFHCFFJNLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F78270", Offset = "0x3F77470", VA = "0x183F78270")]
		internal void HEBNOGIJCKP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KLFGCAJAJAM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public NCBNFICHAFB<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B900D0", Offset = "0x3B8F2D0", VA = "0x183B900D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B907C0", Offset = "0x3B8F9C0", VA = "0x183B907C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EGLCNIOGNLM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61EDE80", Offset = "0x61ED080", VA = "0x1861EDE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61EE670", Offset = "0x61ED870", VA = "0x1861EE670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CPIOJECHFEC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61EB4E0", Offset = "0x61EA6E0", VA = "0x1861EB4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61EBA20", Offset = "0x61EAC20", VA = "0x1861EBA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct NJHEFDHAOHG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3F5B9D0", Offset = "0x3F5ABD0", VA = "0x183F5B9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x370C660", Offset = "0x370B860", VA = "0x18370C660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct JJAIFAABIEN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3AAEC30", Offset = "0x3AADE30", VA = "0x183AAEC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3616400", Offset = "0x3615600", VA = "0x183616400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NEIIENNLNAO<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3F1B860", Offset = "0x3F1AA60", VA = "0x183F1B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C530", Offset = "0x3F1B730", VA = "0x183F1C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IHKECFBNNKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F1770", Offset = "0x61F0970", VA = "0x1861F1770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61F1950", Offset = "0x61F0B50", VA = "0x1861F1950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MGALBPOKIIE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F3890", Offset = "0x61F2A90", VA = "0x1861F3890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61F3C00", Offset = "0x61F2E00", VA = "0x1861F3C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KKEBIJBMIMC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F1E50", Offset = "0x61F1050", VA = "0x1861F1E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61F2140", Offset = "0x61F1340", VA = "0x1861F2140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class MBMABNOJFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MBMABNOJFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61F3820", Offset = "0x61F2A20", VA = "0x1861F3820")]
		internal Task ABNPJMIKLEI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MOJKHOBCKON : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F3D80", Offset = "0x61F2F80", VA = "0x1861F3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61F3FE0", Offset = "0x61F31E0", VA = "0x1861F3FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct FAHLHMNMAHJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61EE6D0", Offset = "0x61ED8D0", VA = "0x1861EE6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61EE8B0", Offset = "0x61EDAB0", VA = "0x1861EE8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FHJGAPKOKDB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61EF4C0", Offset = "0x61EE6C0", VA = "0x1861EF4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61EF830", Offset = "0x61EEA30", VA = "0x1861EF830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OBKCBFNJPDP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F4400", Offset = "0x61F3600", VA = "0x1861F4400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61F46F0", Offset = "0x61F38F0", VA = "0x1861F46F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HLFALCPLIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public HLFALCPLIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61F1700", Offset = "0x61F0900", VA = "0x1861F1700")]
		internal Task CLJAOLKLPDF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PDJFCBFAPIE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F4960", Offset = "0x61F3B60", VA = "0x1861F4960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61F4BC0", Offset = "0x61F3DC0", VA = "0x1861F4BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct LJEIMHODEPJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F3640", Offset = "0x61F2840", VA = "0x1861F3640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61F37C0", Offset = "0x61F29C0", VA = "0x1861F37C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BGNMJBBFOMP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x47981F0", Offset = "0x47973F0", VA = "0x1847981F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4798450", Offset = "0x4797650", VA = "0x184798450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HJEIAEIJLPL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61F1290", Offset = "0x61F0490", VA = "0x1861F1290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61F16A0", Offset = "0x61F08A0", VA = "0x1861F16A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? GGKAHLPBBAM;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<PGENBOHGKNI> LJOMPJIPKDF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task EEOJGPNGKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61ED240", Offset = "0x61EC440", VA = "0x1861ED240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61ECF30", Offset = "0x61EC130", VA = "0x1861ECF30")]
	public static bool JNGJMOFJFAC(this Task GMIPPGJENPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x263B5C0", Offset = "0x263A7C0", VA = "0x18263B5C0")]
	public static Task<T> KJIEAPNPJIO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61ECF60", Offset = "0x61EC160", VA = "0x1861ECF60")]
	public static Task KGFDIKKPIGC(this Task GMIPPGJENPH, CancellationToken COAGHPOILPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2638A00", Offset = "0x2637C00", VA = "0x182638A00")]
	public static Task<TResult> KGFDIKKPIGC<TResult>(this Task<TResult> GMIPPGJENPH, CancellationToken COAGHPOILPB) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2638CD0", Offset = "0x2637ED0", VA = "0x182638CD0")]
	public static TaskCompletionSource<TResult> KGFDIKKPIGC<TResult>(this TaskCompletionSource<TResult> IAIONEHGECN, CancellationToken COAGHPOILPB) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61EC5B0", Offset = "0x61EB7B0", VA = "0x1861EC5B0")]
	[AsyncStateMachine(typeof(KGCJLKIDPIB))]
	public static void DKJHJDIBBGD(this Task LFCIAEJOMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61EC2A0", Offset = "0x61EB4A0", VA = "0x1861EC2A0")]
	[AsyncStateMachine(typeof(JHOLCIPEIKO))]
	public static void AFONJDELELF(this Task LFCIAEJOMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x263B9D0", Offset = "0x263ABD0", VA = "0x18263B9D0")]
	[AsyncStateMachine(typeof(GDHAENNNOCB<>))]
	public static Task MIELHJDEMLM<TException>(this Task LFCIAEJOMBP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26385A0", Offset = "0x26377A0", VA = "0x1826385A0")]
	[AsyncStateMachine(typeof(GPPILJJIFLH<>))]
	public static Task<T> BPCIKIHALFM<T>(this Task<T> KPBGCHDNDLM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61ED2B0", Offset = "0x61EC4B0", VA = "0x1861ED2B0")]
	[AsyncStateMachine(typeof(KMDNBCCPFNG))]
	public static Task<TaskStatus> MEGJIAEBDKE(this Task KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x263BD00", Offset = "0x263AF00", VA = "0x18263BD00")]
	public static (Task<T?>?, Action<T?>?) OFPFBPJGKEG<T>([Optional] CancellationToken OBNOJDAGGOE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x263B710", Offset = "0x263A910", VA = "0x18263B710")]
	[AsyncStateMachine(typeof(KLFGCAJAJAM<, >))]
	public static Task<List<TResult>> MDFIOLHFHOI<TResult, TInput>(this Task<List<TInput>> GMIPPGJENPH, NCBNFICHAFB<TInput, TResult> JGINFODENEP) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61ED4D0", Offset = "0x61EC6D0", VA = "0x1861ED4D0")]
	[AsyncStateMachine(typeof(EGLCNIOGNLM))]
	public static Task NEBKIPNDODI(Task LFCIAEJOMBP, CancellationToken EINMEJNIPAA, Func<CancellationToken, Task> ADMNCLKGCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61ED3A0", Offset = "0x61EC5A0", VA = "0x1861ED3A0")]
	[AsyncStateMachine(typeof(CPIOJECHFEC))]
	public static Task NCKDIOKIMMA(Func<CancellationToken, Task> PKHKECIMGMA, TimeSpan KNCILFNLHDH, [Optional] CancellationToken EINMEJNIPAA, [Optional] Action<OperationCanceledException>? CHFCHDEBLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x263BAA0", Offset = "0x263ACA0", VA = "0x18263BAA0")]
	[AsyncStateMachine(typeof(NJHEFDHAOHG<>))]
	public static Task<T> NCKDIOKIMMA<T>(Func<CancellationToken, Task<T>> PKHKECIMGMA, TimeSpan KNCILFNLHDH, [Optional] CancellationToken EINMEJNIPAA, [Optional] Func<OperationCanceledException, T>? CHFCHDEBLDF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x263B8F0", Offset = "0x263AAF0", VA = "0x18263B8F0")]
	[AsyncStateMachine(typeof(JJAIFAABIEN<>))]
	public static Task<IEnumerable<Task<T>>> MDPBDLFOCEA<T>(IEnumerable<Task<T>> PKJICJHGNDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2638760", Offset = "0x2637960", VA = "0x182638760")]
	[AsyncStateMachine(typeof(NEIIENNLNAO<, , , >))]
	public static Task<(T1, T2, T3, T4)> GJFCMPDHHGN<T1, T2, T3, T4>(Task<T1> DKHGBLBEKKB, Task<T2> KIJDHJPKNDP, Task<T3> EAHHIMDFLEF, Task<T4> CEBGOAPJBKA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA10", Offset = "0x61EBC10", VA = "0x1861ECA10")]
	[AsyncStateMachine(typeof(IHKECFBNNKP))]
	public static Task HDHBHOKMFGB(Func<bool> MELPJNMAJNF, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61EC900", Offset = "0x61EBB00", VA = "0x1861EC900")]
	[AsyncStateMachine(typeof(MGALBPOKIIE))]
	public static Task HDHBHOKMFGB(Func<bool> MELPJNMAJNF, TimeSpan BFPJIPKFMML, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61ED930", Offset = "0x61ECB30", VA = "0x1861ED930")]
	[AsyncStateMachine(typeof(KKEBIJBMIMC))]
	public static Task ODMICKFLBID(Func<bool> MELPJNMAJNF, TimeSpan KNCILFNLHDH, [Optional] CancellationToken OBNOJDAGGOE, [Optional] Action<OperationCanceledException>? CHFCHDEBLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61ED7F0", Offset = "0x61EC9F0", VA = "0x1861ED7F0")]
	[AsyncStateMachine(typeof(MOJKHOBCKON))]
	public static Task ODMICKFLBID(Func<bool> MELPJNMAJNF, TimeSpan KNCILFNLHDH, TimeSpan BFPJIPKFMML, [Optional] CancellationToken OBNOJDAGGOE, [Optional] Action<OperationCanceledException>? CHFCHDEBLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61EC7C0", Offset = "0x61EB9C0", VA = "0x1861EC7C0")]
	[AsyncStateMachine(typeof(FAHLHMNMAHJ))]
	public static Task FBPGBKCCKCK(Func<bool> MELPJNMAJNF, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61EC6B0", Offset = "0x61EB8B0", VA = "0x1861EC6B0")]
	[AsyncStateMachine(typeof(FHJGAPKOKDB))]
	public static Task FBPGBKCCKCK(Func<bool> MELPJNMAJNF, TimeSpan BFPJIPKFMML, [Optional] CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61EDC90", Offset = "0x61ECE90", VA = "0x1861EDC90")]
	[AsyncStateMachine(typeof(OBKCBFNJPDP))]
	public static Task OLGJJAGAEPL(Func<bool> MELPJNMAJNF, TimeSpan KNCILFNLHDH, [Optional] CancellationToken OBNOJDAGGOE, [Optional] Action<OperationCanceledException>? CHFCHDEBLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61EDB50", Offset = "0x61ECD50", VA = "0x1861EDB50")]
	[AsyncStateMachine(typeof(PDJFCBFAPIE))]
	public static Task OLGJJAGAEPL(Func<bool> MELPJNMAJNF, TimeSpan KNCILFNLHDH, TimeSpan BFPJIPKFMML, [Optional] CancellationToken OBNOJDAGGOE, [Optional] Action<OperationCanceledException>? CHFCHDEBLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61EDA60", Offset = "0x61ECC60", VA = "0x1861EDA60")]
	[Obsolete]
	[AsyncStateMachine(typeof(LJEIMHODEPJ))]
	public static Task OGIFIANNOLD(this Task GMIPPGJENPH, Action JINGBLBKCPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x263BF40", Offset = "0x263B140", VA = "0x18263BF40")]
	[AsyncStateMachine(typeof(BGNMJBBFOMP<>))]
	[Obsolete]
	public static Task OGIFIANNOLD<T>(this Task<T> GMIPPGJENPH, Action<T> JINGBLBKCPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61ECE80", Offset = "0x61EC080", VA = "0x1861ECE80")]
	private static void JLHBPMNEEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61ECB00", Offset = "0x61EBD00", VA = "0x1861ECB00")]
	public static bool IALJIACEPHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61EC350", Offset = "0x61EB550", VA = "0x1861EC350")]
	private static void BDJFHBJKJCP(SynchronizationContext AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61ED600", Offset = "0x61EC800", VA = "0x1861ED600")]
	private static void NJMJMFKDNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61EC4E0", Offset = "0x61EB6E0", VA = "0x1861EC4E0")]
	public static void COECJAOJHFK([Optional] string? LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61ED1C0", Offset = "0x61EC3C0", VA = "0x1861ED1C0")]
	public static void KKKJFEPCFDH([Optional] string? LFMFEFFGFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61EC8B0", Offset = "0x61EBAB0", VA = "0x1861EC8B0")]
	public static HGIMGCKDAIA FOJMIPHNOGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61EC660", Offset = "0x61EB860", VA = "0x1861EC660")]
	public static HGIMGCKDAIA ELGJDAGAHIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61ED720", Offset = "0x61EC920", VA = "0x1861ED720")]
	[AsyncStateMachine(typeof(HJEIAEIJLPL))]
	public static Task ODMHFOBJNKM(Func<Task> PFGMNDNOGDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CMGJJOIKLEE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
	public CMGJJOIKLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DIKFNFEOJKJ : JLLGJGJFGAL
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly JLLGJGJFGAL MJANIPKLNPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime JCABIIIDNFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61EC1E0", Offset = "0x61EB3E0", VA = "0x1861EC1E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset JOANEPEHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61EC180", Offset = "0x61EB380", VA = "0x1861EC180", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DIKFNFEOJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JLLGJGJFGAL
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime JCABIIIDNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset JOANEPEHLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LFOEFMKDJGA
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long MGHLCEHGDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61F2E10", Offset = "0x61F2010", VA = "0x1861F2E10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long AEKBBFFBDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61F3020", Offset = "0x61F2220", VA = "0x1861F3020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double BBJLNAJOJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61F3220", Offset = "0x61F2420", VA = "0x1861F3220")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double PJCPMCABFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61F32C0", Offset = "0x61F24C0", VA = "0x1861F32C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double AKDLAIPHPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x61F3270", Offset = "0x61F2470", VA = "0x1861F3270")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double AHJKJAPCPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61F3320", Offset = "0x61F2520", VA = "0x1861F3320")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61F2E60", Offset = "0x61F2060", VA = "0x1861F2E60")]
	public static double CECKAFPEIAK(long GIIGKANHLJB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61F3070", Offset = "0x61F2270", VA = "0x1861F3070")]
	public static double DNJEBFHLBOE(long GIIGKANHLJB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61F3190", Offset = "0x61F2390", VA = "0x1861F3190")]
	public static double JFDHICLAICH(double KJONEMAHFIN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61F3100", Offset = "0x61F2300", VA = "0x1861F3100")]
	public static long EGCDDPFMOOH(long NCFLLHLBEIG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61F3310", Offset = "0x61F2510", VA = "0x1861F3310")]
	public static long MINNOFLBGIH(long HMKAJEKNKBO, long LCFAKNLPKGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61F2EF0", Offset = "0x61F20F0", VA = "0x1861F2EF0")]
	public static double CHACELLLPKN(long HMKAJEKNKBO, long LCFAKNLPKGO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61F2FC0", Offset = "0x61F21C0", VA = "0x1861F2FC0")]
	public static double CNIHFAGHCPB(long HMKAJEKNKBO, long LCFAKNLPKGO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class DGLJEFAKONJ : OLOKNOCMLBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan LOIBPBJEOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer JLNOKHENILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan KNCILFNLHDH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan KHAIKLIJNIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61EBCF0", Offset = "0x61EAEF0", VA = "0x1861EBCF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? KNECMKLCIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61EC110", Offset = "0x61EB310", VA = "0x1861EC110")]
	[Preserve]
	public DGLJEFAKONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61EBEC0", Offset = "0x61EB0C0", VA = "0x1861EBEC0")]
	public DGLJEFAKONJ(TimeSpan KNCILFNLHDH, [Optional] Action? LNCJADCAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA80", Offset = "0x61EAC80", VA = "0x1861EBA80", Slot = "7")]
	public void DDALJGFIKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61EBBB0", Offset = "0x61EADB0", VA = "0x1861EBBB0", Slot = "8")]
	public void FMHEBIBCLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC20", Offset = "0x61EAE20", VA = "0x1861EBC20", Slot = "9")]
	public void GKJAHBMHFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xC34D00", Offset = "0xC33F00", VA = "0x180C34D00")]
	private void DNNMDHCBILJ(object BBEDKDLIKBI, ElapsedEventArgs MHMPBAACAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC50", Offset = "0x61EAE50", VA = "0x1861EBC50")]
	private static void JKPMEICAIOO(TimeSpan CBAPJMAFEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61EBB10", Offset = "0x61EAD10", VA = "0x1861EBB10", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MNMOIINOFAC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string FLBKLLDNKPA;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
	public MNMOIINOFAC(string MJGEABCNLKP)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct FJAGDKHDPHN : IEquatable<FJAGDKHDPHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint ACADLDFKOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int JMNGOCMEFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float LMHGDKLAFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort FJMFNLCCFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort PGKIDNEHNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short FNAKGKKIIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short BKJKBKILDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char EFFMDABBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char DGDPGECEIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte CAPPNHONMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte FKAJAFJKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte JCPAIPFFKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte KDBEAMIPDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool FMLENNOGFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool EFAPGNEOINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool NBLDGAGLLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool DKJJCMPNEPD;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD867E0", Offset = "0xD859E0", VA = "0x180D867E0")]
	public static FJAGDKHDPHN CBGGMEMBGPM(uint HCMIBOONDPB)
	{
		return default(FJAGDKHDPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD867E0", Offset = "0xD859E0", VA = "0x180D867E0")]
	public static FJAGDKHDPHN FBBJABOMCBL(int BAKKMCBKPDL)
	{
		return default(FJAGDKHDPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61EF910", Offset = "0x61EEB10", VA = "0x1861EF910")]
	public static FJAGDKHDPHN GBBJANOEPLD(float PEBOHMFOPEI)
	{
		return default(FJAGDKHDPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61EF920", Offset = "0x61EEB20", VA = "0x1861EF920")]
	public static FJAGDKHDPHN PJJAOJFMIMN(byte DKBFOIEGJLB, byte FNOHOAPIPMA, byte DFAFECNCFBA, byte JJNOEDEOAJN)
	{
		return default(FJAGDKHDPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61EF920", Offset = "0x61EEB20", VA = "0x1861EF920")]
	public static FJAGDKHDPHN MGFJMIFBEGL(bool OCOLPFOMIFL, bool FCIPDLICHLC, bool CCGKIJEHONE, bool MDKLPNBNCAB)
	{
		return default(FJAGDKHDPHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61EF920", Offset = "0x61EEB20", VA = "0x1861EF920")]
	public static FJAGDKHDPHN IIMLIMMLLJE(byte BDDMGIAEAPB, byte JNDDOEFNCCH, byte LPDHHDGGFGA, byte BHFLLCHAJNC)
	{
		return default(FJAGDKHDPHN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x182E6B0", Offset = "0x182D8B0", VA = "0x18182E6B0")]
	public static bool CDBCKLPENDN(FJAGDKHDPHN KGLNCFAJNGP, FJAGDKHDPHN KINCGEJJBNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8A4590", Offset = "0x8A3790", VA = "0x1808A4590", Slot = "4")]
	public bool Equals(FJAGDKHDPHN NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61EF890", Offset = "0x61EEA90", VA = "0x1861EF890", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x949770", Offset = "0x948970", VA = "0x180949770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61EF940", Offset = "0x61EEB40", VA = "0x1861EF940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OHDBIPMDCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong KABGLAPKNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long FPDPDPELCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double NLFAILLDAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint GNOGOMECANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint HPNGABFEOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int PGOFCLIIMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int LEPOPCKGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float BOBCMAOEHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float KIMAAFMJJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort FJMFNLCCFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort PGKIDNEHNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort BBDLNFEIJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JOINOOENMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short FNAKGKKIIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short BKJKBKILDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short GKNKHDBBKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short KDIEJANEDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char EFFMDABBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char DGDPGECEIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char KKBGPEPPHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char PPBOOJNNDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte CAPPNHONMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte FKAJAFJKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte JCPAIPFFKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte KDBEAMIPDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte DIBMPJFDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte EIFCJKAMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NHMDMBDKCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte OKPJBHFJFHO;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61F4820", Offset = "0x61F3A20", VA = "0x1861F4820")]
	public static OHDBIPMDCBJ GOMGEEBODDD(byte DKBFOIEGJLB, byte FNOHOAPIPMA, byte DFAFECNCFBA, byte JJNOEDEOAJN, byte IDEAHKLDCPN, byte OACDCPNNEHK, byte MOJFMFGMKPH, byte OJNONJHNAJE)
	{
		return default(OHDBIPMDCBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ANNDMPPGLOP<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly T GHLEEIMPACO;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x37AF0E0", Offset = "0x37AE2E0", VA = "0x1837AF0E0")]
	public ANNDMPPGLOP(T KDHINJAMPGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class MKLJENAHMHH
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x28548C0", Offset = "0x2853AC0", VA = "0x1828548C0")]
	public static ANNDMPPGLOP<T> GOMGEEBODDD<T>(T KDHINJAMPGF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PBINKGLNAAF
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x27689F0", Offset = "0x2767BF0", VA = "0x1827689F0")]
	public static IEnumerable<T> JCIEEJPEIIC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static T[] IGNDFFFNFCP<T>(params T[] BNDKGMCFHID) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static IEnumerable<T> HONCMBFLPJH<T>(params T[] BNDKGMCFHID) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x263C560", Offset = "0x263B760", VA = "0x18263C560")]
	public static HashSet<T> APFOAJHLNCP<T>(params T[] BNDKGMCFHID) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x28DF280", Offset = "0x28DE480", VA = "0x1828DF280")]
	public static KeyValuePair<TKey, TValue> OPOICOMBAAO<TKey, TValue>([In] TKey HKNPGHOCJDO, [In] TValue AFCGKMGKPEF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x263C560", Offset = "0x263B760", VA = "0x18263C560")]
	public static List<T> OKCIBHJOLCM<T>(IEnumerable<T> CDNFLDEAOKG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OLCPCAGCGFL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly string EMHKPDHKDFH;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
	public OLCPCAGCGFL(string HDDBKHCJMKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate object CNMKEKOHKLF<T>([In] T KFIENCBOEKJ);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object BDPADBAOGPK<T>(T KFIENCBOEKJ);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[HNOBELDNGHL]
public delegate string INCDDFOJKBG(string CPJNFDEECBG, string? IMAIGADBGGK, bool BPHMMAIIKFF);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[HNOBELDNGHL]
public delegate void NPGAEFKDBEH(string LFMFEFFGFLH);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[HNOBELDNGHL]
public delegate void OPEDOKOGOKB(Exception PHKDDEHKOGJ);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object GIFDFIAFLEO();
[Cpp2IlInjected.Token(Token = "0x2000059")]
[HNOBELDNGHL]
public delegate bool AHEAMPJHLOI();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HNOBELDNGHL]
public delegate string OHEBDAMDCDD(object MFLACBLODGN);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Enum)]
public class IPPGOKMKNGG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
	public IPPGOKMKNGG()
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
