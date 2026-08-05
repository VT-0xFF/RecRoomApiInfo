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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBEEA0", Offset = "0x6EBE2A0", VA = "0x186EBEEA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LEBJCBDMIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD7E0", Offset = "0x6EBCBE0", VA = "0x186EBD7E0")]
	public static string JPDNOHKAAFH(this Encoding EKIDEIBAONG, [In] ReadOnlySequence<byte> HFHEELJJDFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F0DD90", Offset = "0x2F0D190", VA = "0x182F0DD90")]
	private static void FDJGGPNMJAP<T>(this ReadOnlySequence<T> CIALNDLMFDM, [Out] ReadOnlySpan<T> EAJMKGOOGCL, [Out] SequencePosition HENKDDALBFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GKLCDEOPBNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7690", Offset = "0x6EB6A90", VA = "0x186EB7690")]
	public GKLCDEOPBNI(bool BDOEDBLMLHI, string GENPCBMGFFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OEPDKEOHPDB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JIMEGJIGJIH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ANAEPJCNPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBPOHOMKDPH(string GMJINMLEEAC, double LIHHDPOHLDK, [Optional] string? LPDIAHLJLAK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KBGAMGAJKKB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> NACCGBKNNIL(CancellationToken EEHACKMODLA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BONJJOBGGJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KBGAMGAJKKB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NACCGBKNNIL taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x5285860", Offset = "0x5284C60", VA = "0x185285860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52869A0", Offset = "0x5285DA0", VA = "0x1852869A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource INFCCFLIMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? EAJKLNNKNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? MOPHJOPDLFA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x451D7C0", Offset = "0x451CBC0", VA = "0x18451D7C0")]
	[AsyncStateMachine(typeof(KBGAMGAJKKB<>.BONJJOBGGJF))]
	public Task<TResult> EPNFPOPOPFB(NACCGBKNNIL LIGGLJMPFMF, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x451D750", Offset = "0x451CB50", VA = "0x18451D750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x451D910", Offset = "0x451CD10", VA = "0x18451D910")]
	public KBGAMGAJKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HJPGJEHOLDD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> CPIBKCCPDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T JKEIFELLNME;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40AEF70", Offset = "0x40AE370", VA = "0x1840AEF70")]
	public HJPGJEHOLDD([In] T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40AE1E0", Offset = "0x40AD5E0", VA = "0x1840AE1E0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40AE910", Offset = "0x40ADD10", VA = "0x1840AE910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40AEDF0", Offset = "0x40AE1F0", VA = "0x1840AEDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FFMFJAOEJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static HJPGJEHOLDD<T> AALKPJMFIHM<T>([In] T LIHHDPOHLDK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NCDBAAIKGHK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE310", Offset = "0x6EBD710", VA = "0x186EBE310")]
	public static void HMEAIPPLCJM(this CancellationTokenSource INFCCFLIMCN, bool OFOADGAHKHF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FEMCAFBMIJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
	public FEMCAFBMIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class JIOMAKBLFNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
	public JIOMAKBLFNI(string GJPIOAKLPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IEAAODHBCDB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E972B0", Offset = "0x2E966B0", VA = "0x182E972B0")]
	public static KJMNDBGEIFP EPMCIONFAIM<T>()
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E96FE0", Offset = "0x2E963E0", VA = "0x182E96FE0")]
	public static KJMNDBGEIFP BOCBHFCDOMM<T>([CallerMemberName] string ADANIHOIEKJ = "") where T : notnull
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E97230", Offset = "0x2E96630", VA = "0x182E97230")]
	public static KJMNDBGEIFP EPMCIONFAIM<T>(this T PAHNKMKPPCD) where T : notnull
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E97330", Offset = "0x2E96730", VA = "0x182E97330")]
	public static KJMNDBGEIFP JFJMEDFLPGE<T>(this T PAHNKMKPPCD, [CallerMemberName] string ADANIHOIEKJ = "") where T : notnull
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E97080", Offset = "0x2E96480", VA = "0x182E97080")]
	public static KJMNDBGEIFP BOCBHFCDOMM<T>(this T MBGHIKEGJAA, [CallerMemberName] string ADANIHOIEKJ = "") where T : notnull
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAB30", Offset = "0x6EB9F30", VA = "0x186EBAB30")]
	public static KJMNDBGEIFP BOCBHFCDOMM(string CNAJMJHKBAN, [CallerMemberName] string ADANIHOIEKJ = "")
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EBABB0", Offset = "0x6EB9FB0", VA = "0x186EBABB0")]
	public static string OHCMAFDJHNC(this object MBGHIKEGJAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool OFGLBDGJPNM();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FEMCAFBMIJF]
public delegate long NBPPJPINJME();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BLKJGBDPNPF
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IGOMGDFFEBG ACOLMBIBAFM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IGOMGDFFEBG BNLHJOIACKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EB47E0", Offset = "0x6EB3BE0", VA = "0x186EB47E0")]
		get
		{
			return default(IGOMGDFFEBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static NPADFMEMAMN EHGDLHNNCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EB43B0", Offset = "0x6EB37B0", VA = "0x186EB43B0")]
		get
		{
			return default(NPADFMEMAMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static AIMDGGMPEGE LAPADDIDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB4280", Offset = "0x6EB3680", VA = "0x186EB4280")]
		get
		{
			return default(AIMDGGMPEGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool ONPFGKNNCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EB4170", Offset = "0x6EB3570", VA = "0x186EB4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB44A0", Offset = "0x6EB38A0", VA = "0x186EB44A0")]
	public static void JNMEKEPMOLE([In] IGOMGDFFEBG MNONBHCCGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4640", Offset = "0x6EB3A40", VA = "0x186EB4640")]
	public static void KGPNCCLAFMC(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB48B0", Offset = "0x6EB3CB0", VA = "0x186EB48B0")]
	public static void NJHAKNOPGIO(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF07A0", Offset = "0x2BEFBA0", VA = "0x182BF07A0")]
	public static void NJHAKNOPGIO<T>(T MGBFBAKCCAP, MBJGEMHMAIJ<T> ADPAIBGIHMB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4400", Offset = "0x6EB3800", VA = "0x186EB4400")]
	public static void JKJEFNMOBEN(Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4830", Offset = "0x6EB3C30", VA = "0x186EB4830")]
	public static void MDMEFOMFKME(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EB42D0", Offset = "0x6EB36D0", VA = "0x186EB42D0")]
	public static void DOCCHLMLLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4980", Offset = "0x6EB3D80", VA = "0x186EB4980")]
	public static string OHCMAFDJHNC(object PBAACPJGKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4340", Offset = "0x6EB3740", VA = "0x186EB4340")]
	public static long FBIHPNELCCO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EB41E0", Offset = "0x6EB35E0", VA = "0x186EB41E0")]
	public static bool BFLOEIDFIEN(bool HKAOLGPCJKN, string ADPAIBGIHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4710", Offset = "0x6EB3B10", VA = "0x186EB4710")]
	public static double LALNLJMLEIO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct IGOMGDFFEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly NPADFMEMAMN EHGDLHNNCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly AIMDGGMPEGE LAPADDIDGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly KJGGEHHGBGE JGIAHOLCNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly NBPPJPINJME JMADCAFPHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly MLABIEKNIHI ALBFPPPHDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly OFGLBDGJPNM PKKLHIFABFI;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly KJGGEHHGBGE ILEPFALPDDM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NBPPJPINJME PLANHCMHADM;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly MLABIEKNIHI PMKOLMJDCEN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly OFGLBDGJPNM APGHOJFHBOB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly IGOMGDFFEBG NHLFLGLAPGF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAC50", Offset = "0x6EBA050", VA = "0x186EBAC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB5E0", Offset = "0x6EBA9E0", VA = "0x186EBB5E0")]
	public IGOMGDFFEBG([In] NPADFMEMAMN DLCNENADIMO, [In] AIMDGGMPEGE POIDEFEDMNJ, KJGGEHHGBGE CNCPJPMJDBI, NBPPJPINJME GGCDGDFAONI, MLABIEKNIHI IEGGCEJNOBJ, OFGLBDGJPNM GILOJEPECOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAEE0", Offset = "0x6EBA2E0", VA = "0x186EBAEE0")]
	private static string NGPHCDHLGDJ(object PBAACPJGKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	private static long MOBBHKDECGO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	private static string BNGBGPBAGAC(string PCMCEFKLCKL, string? BKLOOOLLNJH, bool DNJHEPMOMPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	private static bool PIIOIFPLNIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBADE0", Offset = "0x6EBA1E0", VA = "0x186EBADE0")]
	private static IGOMGDFFEBG IPCEAAGEPNK()
	{
		return default(IGOMGDFFEBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EHPLJOPADLG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPKDAONOJNO LFNEGOGFAAD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GPKDAONOJNO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EAOCHOMFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFLFAPJJJOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CLKINMENLCJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJGJEJGHIMG([In] T OCKBFCIKBEN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void ANPDBLCCPLG<T>([In] T MGBFBAKCCAP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct CLCOJBEHIHA<T> : IEquatable<CLCOJBEHIHA<T>>, CLKINMENLCJ<CLCOJBEHIHA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T JKEIFELLNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int LGPOLAJNCMC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x224E040", Offset = "0x224D440", VA = "0x18224E040")]
	public CLCOJBEHIHA([In] T LIHHDPOHLDK, int AEAHMAMPNLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x532A640", Offset = "0x5329A40", VA = "0x18532A640")]
	public static bool GBDINLJCMBD([In] CLCOJBEHIHA<T> EHOEECMJEAD, [In] CLCOJBEHIHA<T> CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4426020", Offset = "0x4425420", VA = "0x184426020", Slot = "4")]
	public bool Equals(CLCOJBEHIHA<T> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x484D570", Offset = "0x484C970", VA = "0x18484D570", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x53299F0", Offset = "0x5328DF0", VA = "0x1853299F0")]
	public bool CJGJEJGHIMG([In] CLCOJBEHIHA<T> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x532AE70", Offset = "0x532A270", VA = "0x18532AE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x532B3E0", Offset = "0x532A7E0", VA = "0x18532B3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5329F00", Offset = "0x5329300", VA = "0x185329F00")]
	public void CPFOJCEKBFH([Out] T LIHHDPOHLDK, [Out] int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x532A2C0", Offset = "0x53296C0", VA = "0x18532A2C0")]
	public (T, int) FDHKLOPEDJD()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x532AFF0", Offset = "0x532A3F0", VA = "0x18532AFF0", Slot = "5")]
	private bool JKGAMPPDEFM([In] CLCOJBEHIHA<T> OCKBFCIKBEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OCDLLHEMOBC
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2FF23E0", Offset = "0x2FF17E0", VA = "0x182FF23E0")]
	public static CLCOJBEHIHA<T> AALKPJMFIHM<T>([In] T LIHHDPOHLDK, int AEAHMAMPNLO) where T : notnull
	{
		return default(CLCOJBEHIHA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NHCHEAHECGO
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6900", Offset = "0x2FC5D00", VA = "0x182FC6900")]
	public static bool CJGJEJGHIMG<T, U>([In] T MBGHIKEGJAA, [In] U PBAACPJGKNP) where T : notnull, CLKINMENLCJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult ANGNGCIMEIB<T, out TResult>([In] T MGBFBAKCCAP);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MDIAOJBFPIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan LNDNMLDABAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? KMOMCBJPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOGIABOPHFE();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEKALHAKCFL();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJMCDLIDJPF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct NPADFMEMAMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly FFKDIIJCAIG CNJMIGJNAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly EMHHDIKONOM CMLLHNJEFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FFKDIIJCAIG DKGLMCMNDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly EMHHDIKONOM DGFFLAKNGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FFKDIIJCAIG LFOOGAHCONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EMHHDIKONOM KHHKELMGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly MLLMJGBNJNO KJKINMKEBGN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly FFKDIIJCAIG LJIDOHAPHFE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EMHHDIKONOM NEFLGOJMKOJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FFKDIIJCAIG CLFEIHDPLDC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly EMHHDIKONOM GGEMCHHFDCD;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FFKDIIJCAIG GJIGGNEPPOF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EMHHDIKONOM JPJMBOFLJGG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MLLMJGBNJNO KEDDGFDNBJA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly NPADFMEMAMN NHLFLGLAPGF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FFKDIIJCAIG ACOIHCDLOAP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE410", Offset = "0x6EBD810", VA = "0x186EBE410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x92CDD0", Offset = "0x92C1D0", VA = "0x18092CDD0")]
	public NPADFMEMAMN(FFKDIIJCAIG BLABOBNBNGB, EMHHDIKONOM EAIFLHMEOPO, FFKDIIJCAIG JHDOKHPPHEN, EMHHDIKONOM IDJBNMCIGFK, FFKDIIJCAIG DINMDAAHNAF, EMHHDIKONOM ACBMKPFHGNA, MLLMJGBNJNO AMEDACDPANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	private static bool HNIPPOKKCHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void KGKNKAKDGFI(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	private static bool KPPDBPAGHFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void JCDNFANAKJA(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	private static bool KGEIMEMMFBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void MBAIFAMLDLD(string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void EBBCAMMLLCF(Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE5F0", Offset = "0x6EBD9F0", VA = "0x186EBE5F0")]
	private static NPADFMEMAMN IPCEAAGEPNK()
	{
		return default(NPADFMEMAMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
	private static bool DDIMMFLNPEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE730", Offset = "0x6EBDB30", VA = "0x186EBE730")]
	public void KGPNCCLAFMC(object ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE7A0", Offset = "0x6EBDBA0", VA = "0x186EBE7A0")]
	public void NJHAKNOPGIO(object ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x91E460", Offset = "0x91D860", VA = "0x18091E460")]
	public void JKJEFNMOBEN(Exception JFJOELAOBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE810", Offset = "0x6EBDC10", VA = "0x186EBE810")]
	public void NJHAKNOPGIO(DEHOAJCBPJL ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9EC0", Offset = "0x2FD92C0", VA = "0x182FD9EC0")]
	public void NJHAKNOPGIO<T>(T MGBFBAKCCAP, MBJGEMHMAIJ<T> ADPAIBGIHMB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9AB0", Offset = "0x2FD8EB0", VA = "0x182FD9AB0")]
	public void KGPNCCLAFMC<T>([In] T MGBFBAKCCAP, LIEKADHLMPM<T> ADPAIBGIHMB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD9C50", Offset = "0x2FD9050", VA = "0x182FD9C50")]
	public void NJHAKNOPGIO<T>([In] T MGBFBAKCCAP, LIEKADHLMPM<T> ADPAIBGIHMB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE340", Offset = "0x6EBD740", VA = "0x186EBE340")]
	public bool BFLOEIDFIEN(bool HKAOLGPCJKN, string ADPAIBGIHMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct KJMNDBGEIFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string JKEIFELLNME;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	public KJMNDBGEIFP(string LIHHDPOHLDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0")]
	public static string ICFKEBCLOFF([In] KJMNDBGEIFP MBGHIKEGJAA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC8CD00", Offset = "0xC8C100", VA = "0x180C8CD00")]
	public static KJMNDBGEIFP ICFKEBCLOFF(string OCKBFCIKBEN)
	{
		return default(KJMNDBGEIFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD550", Offset = "0x6EBC950", VA = "0x186EBD550")]
	public string PGCMEEFDAKC(string NDBHBGLFMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EBD470", Offset = "0x6EBC870", VA = "0x186EBD470")]
	public string LALCJGMFBME(object PCFNLPAIJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct OKFEIOHLOGM : IEquatable<OKFEIOHLOGM>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "4")]
	public bool Equals(OKFEIOHLOGM OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEF90", Offset = "0x6EBE390", VA = "0x186EBEF90", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEFE0", Offset = "0x6EBE3E0", VA = "0x186EBEFE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEFF0", Offset = "0x6EBE3F0", VA = "0x186EBEFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[EAFJAFLMLNJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JEJCONLJHLG<T> : IEquatable<JEJCONLJHLG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T JKEIFELLNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool BIGJPFDLFNG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MPDNLDCIHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x44273A0", Offset = "0x44267A0", VA = "0x1844273A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4427B90", Offset = "0x4426F90", VA = "0x184427B90")]
	public JEJCONLJHLG([In] T LIHHDPOHLDK, bool JMEKEBJJABB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4426CC0", Offset = "0x44260C0", VA = "0x184426CC0")]
	public static bool GBDINLJCMBD([In] JEJCONLJHLG<T> EHOEECMJEAD, [In] JEJCONLJHLG<T> CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4426020", Offset = "0x4425420", VA = "0x184426020", Slot = "4")]
	public bool Equals(JEJCONLJHLG<T> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x44262F0", Offset = "0x44256F0", VA = "0x1844262F0", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4426EC0", Offset = "0x44262C0", VA = "0x184426EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x44278B0", Offset = "0x4426CB0", VA = "0x1844278B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class IKJJGBELIKC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6C50", Offset = "0x2EA6050", VA = "0x182EA6C50")]
	public static JEJCONLJHLG<T> CMPEODHCFDA<T>([In] T LIHHDPOHLDK) where T : notnull
	{
		return default(JEJCONLJHLG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6E30", Offset = "0x2EA6230", VA = "0x182EA6E30")]
	public static JEJCONLJHLG<T?> IPAGIILJNGJ<T>()
	{
		return default(JEJCONLJHLG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6B20", Offset = "0x2EA5F20", VA = "0x182EA6B20")]
	public static bool APPAIBLOLEG<T>([In] this JEJCONLJHLG<T> NLHAELLOPIP, [Out][NotNullWhen(true)] T LIHHDPOHLDK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6CB0", Offset = "0x2EA60B0", VA = "0x182EA6CB0")]
	public static T? IACJAAJJPOH<T>([In] this JEJCONLJHLG<T> NLHAELLOPIP, T? JGBDACMOCCC)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct AIMDGGMPEGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr MDMEFOMFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr DOCCHLMLLJH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr FDMIFCDCJLP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr GGCJEOMAION;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly AIMDGGMPEGE NHLFLGLAPGF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6EB3CE0", Offset = "0x6EB30E0", VA = "0x186EB3CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public AIMDGGMPEGE(IntPtr CBKJFEFKKAL, IntPtr IBCAEJKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void AKGLJPEBDJM(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void EAPHMJLCPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3DB0", Offset = "0x6EB31B0", VA = "0x186EB3DB0")]
	private static AIMDGGMPEGE IPCEAAGEPNK()
	{
		return default(AIMDGGMPEGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MDDPGIFAKNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr BPKJJPFKAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	private MDDPGIFAKNC(IntPtr IBCAEJKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE1F0", Offset = "0x6EBD5F0", VA = "0x186EBE1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE0F0", Offset = "0x6EBD4F0", VA = "0x186EBE0F0")]
	public static MDDPGIFAKNC AALKPJMFIHM(string ADANIHOIEKJ)
	{
		return default(MDDPGIFAKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x222AAE0", Offset = "0x2229EE0", VA = "0x18222AAE0")]
	public static MDDPGIFAKNC AALKPJMFIHM([In] AIMDGGMPEGE POIDEFEDMNJ, string ADANIHOIEKJ)
	{
		return default(MDDPGIFAKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x222AC90", Offset = "0x222A090", VA = "0x18222AC90")]
	public static MDDPGIFAKNC AALKPJMFIHM([In] AIMDGGMPEGE POIDEFEDMNJ, Func<string> ADANIHOIEKJ)
	{
		return default(MDDPGIFAKNC);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HHGMDIMKGJH
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool LPKLEOHEAHA<in TInput, TResult>(TInput GJMNBMBONPJ, [Out] TResult CIFMGKBFCHA);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class IOEPIDPGLAG : EHPLJOPADLG
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class IJOMFFBPPKG : GPKDAONOJNO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly IJOMFFBPPKG FKMJLLKHOAH;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool EAOCHOMFNBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6EBB690", Offset = "0x6EBAA90", VA = "0x186EBB690", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6EBB6F0", Offset = "0x6EBAAF0", VA = "0x186EBB6F0", Slot = "6")]
			public void OnCompleted(Action DOFOBGNCCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			public void JFLFAPJJJOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public IJOMFFBPPKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly IOEPIDPGLAG FKMJLLKHOAH;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		private IOEPIDPGLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB8B0", Offset = "0x6EBACB0", VA = "0x186EBB8B0", Slot = "4")]
		public GPKDAONOJNO LFNEGOGFAAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class APBEDDHNNAD : EHPLJOPADLG
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class BBJBEAILPAF : GPKDAONOJNO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly BBJBEAILPAF FKMJLLKHOAH;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool EAOCHOMFNBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6EB4090", Offset = "0x6EB3490", VA = "0x186EB4090", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6EB40B0", Offset = "0x6EB34B0", VA = "0x186EB40B0", Slot = "6")]
			public void OnCompleted(Action DOFOBGNCCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			public void JFLFAPJJJOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public BBJBEAILPAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly APBEDDHNNAD FKMJLLKHOAH;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		private APBEDDHNNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6EB3FD0", Offset = "0x6EB33D0", VA = "0x186EB3FD0", Slot = "4")]
		public GPKDAONOJNO LFNEGOGFAAD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NLJLEFLGKOE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NLJLEFLGKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4ED0", Offset = "0x3FA42D0", VA = "0x183FA4ED0")]
		internal void CGJAIFFDBIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ADBDPMDIEGK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ADBDPMDIEGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3B727B0", Offset = "0x3B71BB0", VA = "0x183B727B0")]
		internal void HJPLJPNHGDG(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JLOODKBNGNF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBC160", Offset = "0x6EBB560", VA = "0x186EBC160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GKCPLJGDCBB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB7580", Offset = "0x6EB6980", VA = "0x186EB7580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GPLKDMHEOOG<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4025600", Offset = "0x4024A00", VA = "0x184025600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4025770", Offset = "0x4024B70", VA = "0x184025770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CFHKNHCINHF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5312140", Offset = "0x5311540", VA = "0x185312140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5312590", Offset = "0x5311990", VA = "0x185312590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EAEPHJHBDBC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB6100", Offset = "0x6EB5500", VA = "0x186EB6100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6300", Offset = "0x6EB5700", VA = "0x186EB6300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AEKGIOPELMD<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AEKGIOPELMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4ED0", Offset = "0x3FA42D0", VA = "0x183FA4ED0")]
		internal void OLHOBIJPDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4E50", Offset = "0x3FA4250", VA = "0x183FA4E50")]
		internal void KFNAPDGOEDD(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CDCDCHNCJAA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public LPKLEOHEAHA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5308660", Offset = "0x5307A60", VA = "0x185308660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5308DC0", Offset = "0x53081C0", VA = "0x185308DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct HLEEDIDJCPG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBA0F0", Offset = "0x6EB94F0", VA = "0x186EBA0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EBA8F0", Offset = "0x6EB9CF0", VA = "0x186EBA8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JGJHONHDLAG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBBBB0", Offset = "0x6EBAFB0", VA = "0x186EBBBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC100", Offset = "0x6EBB500", VA = "0x186EBC100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MCCJHDEAMFP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4805000", Offset = "0x4804400", VA = "0x184805000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3B37CD0", Offset = "0x3B370D0", VA = "0x183B37CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KJEBJLMBPHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<OKFEIOHLOGM> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KJEBJLMBPHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD360", Offset = "0x6EBC760", VA = "0x186EBD360")]
		internal void EOLCKIJNHKL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GFDFOKMJDDA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3FDC090", Offset = "0x3FDB490", VA = "0x183FDC090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38877D0", Offset = "0x3886BD0", VA = "0x1838877D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KIEKPEJCIFL<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x453D790", Offset = "0x453CB90", VA = "0x18453D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x453DEE0", Offset = "0x453D2E0", VA = "0x18453DEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LDPDGFHBJJO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBD5A0", Offset = "0x6EBC9A0", VA = "0x186EBD5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD780", Offset = "0x6EBCB80", VA = "0x186EBD780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FJMJGPEMHJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB71C0", Offset = "0x6EB65C0", VA = "0x186EB71C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EB7520", Offset = "0x6EB6920", VA = "0x186EB7520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BNFAAFCOMKN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB4AB0", Offset = "0x6EB3EB0", VA = "0x186EB4AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EB4DA0", Offset = "0x6EB41A0", VA = "0x186EB4DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OIHEMEEPHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OIHEMEEPHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EBEF20", Offset = "0x6EBE320", VA = "0x186EBEF20")]
		internal Task FLILOLBMHFL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct DAEBLAIBKGG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB5E40", Offset = "0x6EB5240", VA = "0x186EB5E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EB60A0", Offset = "0x6EB54A0", VA = "0x186EB60A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JEIDJKOEAAK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBB970", Offset = "0x6EBAD70", VA = "0x186EBB970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBB50", Offset = "0x6EBAF50", VA = "0x186EBBB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct HCDCFGKMALH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB7B00", Offset = "0x6EB6F00", VA = "0x186EB7B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6EB7E60", Offset = "0x6EB7260", VA = "0x186EB7E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LNGLMEEGBBJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBDDA0", Offset = "0x6EBD1A0", VA = "0x186EBDDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE090", Offset = "0x6EBD490", VA = "0x186EBE090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KEDHGGDGHIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KEDHGGDGHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD1E0", Offset = "0x6EBC5E0", VA = "0x186EBD1E0")]
		internal Task JGCINHEEMFJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct AIEMODHJFCP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB3A20", Offset = "0x6EB2E20", VA = "0x186EB3A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EB3C80", Offset = "0x6EB3080", VA = "0x186EB3C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HMNIJDFCDAD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EBA950", Offset = "0x6EB9D50", VA = "0x186EBA950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAAD0", Offset = "0x6EB9ED0", VA = "0x186EBAAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct JAHLNFFOOFI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x43EB0D0", Offset = "0x43EA4D0", VA = "0x1843EB0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x43EB350", Offset = "0x43EA750", VA = "0x1843EB350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HCCCOHGIOGM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB7770", Offset = "0x6EB6B70", VA = "0x186EB7770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6EB7AA0", Offset = "0x6EB6EA0", VA = "0x186EB7AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? CIIKGGBCJKE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<OKFEIOHLOGM> IKKMMFGHFLO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task KBAPNODLMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9E40", Offset = "0x6EB9240", VA = "0x186EB9E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9E10", Offset = "0x6EB9210", VA = "0x186EB9E10")]
	public static bool MGMKCDEMAAA(this Task BIDGKFLMMBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2E85A20", Offset = "0x2E84E20", VA = "0x182E85A20")]
	public static Task<T> DAKFLODJEKD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6EB89A0", Offset = "0x6EB7DA0", VA = "0x186EB89A0")]
	public static Task AKKFHPMDGHB(this Task BIDGKFLMMBN, CancellationToken FDAIGOGAKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2E82BF0", Offset = "0x2E81FF0", VA = "0x182E82BF0")]
	public static Task<TResult> AKKFHPMDGHB<TResult>(this Task<TResult> BIDGKFLMMBN, CancellationToken FDAIGOGAKMH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2E83210", Offset = "0x2E82610", VA = "0x182E83210")]
	public static TaskCompletionSource<TResult> AKKFHPMDGHB<TResult>(this TaskCompletionSource<TResult> DEEDJNIJDCK, CancellationToken FDAIGOGAKMH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9580", Offset = "0x6EB8980", VA = "0x186EB9580")]
	public static IDisposable? ILFDIAEJJID(CancellationToken PNOOEHPKOPC, CancellationToken INEJDHFFMPF, [Out] CancellationToken KFMIHMDAEGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9820", Offset = "0x6EB8C20", VA = "0x186EB9820")]
	[AsyncStateMachine(typeof(JLOODKBNGNF))]
	public static void KENKBMNKLBN(this Task HIKBGGAGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9EB0", Offset = "0x6EB92B0", VA = "0x186EB9EB0")]
	[AsyncStateMachine(typeof(GKCPLJGDCBB))]
	public static void NLHDBLFGCLK(this Task HIKBGGAGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E85950", Offset = "0x2E84D50", VA = "0x182E85950")]
	[AsyncStateMachine(typeof(GPLKDMHEOOG<>))]
	public static Task BJGEDNICCKD<TException>(this Task HIKBGGAGLAA) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2E86760", Offset = "0x2E85B60", VA = "0x182E86760")]
	[AsyncStateMachine(typeof(CFHKNHCINHF<>))]
	public static Task<T> PNMKPAJGEKK<T>(this Task<T> MBGHIKEGJAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9020", Offset = "0x6EB8420", VA = "0x186EB9020")]
	[AsyncStateMachine(typeof(EAEPHJHBDBC))]
	public static Task<TaskStatus> FANGALDMFMM(this Task MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E85BA0", Offset = "0x2E84FA0", VA = "0x182E85BA0")]
	public static (Task<T?>?, Action<T?>?) DJPNHAKHPLA<T>([Optional] CancellationToken EEHACKMODLA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E86650", Offset = "0x2E85A50", VA = "0x182E86650")]
	[AsyncStateMachine(typeof(CDCDCHNCJAA<, >))]
	public static Task<List<TResult>> PKPCBFOCLEH<TResult, TInput>(this Task<List<TInput>> BIDGKFLMMBN, LPKLEOHEAHA<TInput, TResult> IEBOEAMAGCJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8BF0", Offset = "0x6EB7FF0", VA = "0x186EB8BF0")]
	[AsyncStateMachine(typeof(HLEEDIDJCPG))]
	public static Task BAGPKHHFMFM(Task HIKBGGAGLAA, CancellationToken COHGPHPHNKH, Func<CancellationToken, Task> DIGOALODJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9400", Offset = "0x6EB8800", VA = "0x186EB9400")]
	[AsyncStateMachine(typeof(JGJHONHDLAG))]
	public static Task HBLPFPCADAE(Func<CancellationToken, Task> AMDBOGBIGIM, TimeSpan JHOELLEDCNB, [Optional] CancellationToken COHGPHPHNKH, [Optional] Action<OperationCanceledException>? NDNBOMOJFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E85E20", Offset = "0x2E85220", VA = "0x182E85E20")]
	[AsyncStateMachine(typeof(MCCJHDEAMFP<>))]
	public static Task<T> HBLPFPCADAE<T>(Func<CancellationToken, Task<T>> AMDBOGBIGIM, TimeSpan JHOELLEDCNB, [Optional] CancellationToken COHGPHPHNKH, [Optional] Func<OperationCanceledException, T>? NDNBOMOJFPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB86E0", Offset = "0x6EB7AE0", VA = "0x186EB86E0")]
	public static Task AEKKODCNLIF(params Task[] INGCAKNBFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8220", Offset = "0x6EB7620", VA = "0x186EB8220")]
	public static Task AEKKODCNLIF(IEnumerable<Task> INGCAKNBFAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E86560", Offset = "0x2E85960", VA = "0x182E86560")]
	[AsyncStateMachine(typeof(GFDFOKMJDDA<>))]
	public static Task<IEnumerable<Task<T>>> OFIMJEJHAOL<T>(IEnumerable<Task<T>> INGCAKNBFAM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E860C0", Offset = "0x2E854C0", VA = "0x182E860C0")]
	[AsyncStateMachine(typeof(KIEKPEJCIFL<, , , >))]
	public static Task<(T1, T2, T3, T4)> INHFBMDFFCJ<T1, T2, T3, T4>(Task<T1> BAPMINCLEIB, Task<T2> LAAGCPPBJGA, Task<T3> CFEOCKBCKBB, Task<T4> BNBJGOIGMGJ) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9BC0", Offset = "0x6EB8FC0", VA = "0x186EB9BC0")]
	[AsyncStateMachine(typeof(LDPDGFHBJJO))]
	public static Task MEODBEJNMHA(Func<bool> HKAOLGPCJKN, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9CB0", Offset = "0x6EB90B0", VA = "0x186EB9CB0")]
	[AsyncStateMachine(typeof(FJMJGPEMHJI))]
	public static Task MEODBEJNMHA(Func<bool> HKAOLGPCJKN, TimeSpan CLEPFIEGJLA, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8870", Offset = "0x6EB7C70", VA = "0x186EB8870")]
	[AsyncStateMachine(typeof(BNFAAFCOMKN))]
	public static Task AKHONFFKCKC(Func<bool> HKAOLGPCJKN, TimeSpan JHOELLEDCNB, [Optional] CancellationToken EEHACKMODLA, [Optional] Action<OperationCanceledException>? NDNBOMOJFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8730", Offset = "0x6EB7B30", VA = "0x186EB8730")]
	[AsyncStateMachine(typeof(DAEBLAIBKGG))]
	public static Task AKHONFFKCKC(Func<bool> HKAOLGPCJKN, TimeSpan JHOELLEDCNB, TimeSpan CLEPFIEGJLA, [Optional] CancellationToken EEHACKMODLA, [Optional] Action<OperationCanceledException>? NDNBOMOJFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EB98D0", Offset = "0x6EB8CD0", VA = "0x186EB98D0")]
	[AsyncStateMachine(typeof(JEIDJKOEAAK))]
	public static Task LGIMCGGMEHG(Func<bool> HKAOLGPCJKN, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EB99C0", Offset = "0x6EB8DC0", VA = "0x186EB99C0")]
	[AsyncStateMachine(typeof(HCDCFGKMALH))]
	public static Task LGIMCGGMEHG(Func<bool> HKAOLGPCJKN, TimeSpan CLEPFIEGJLA, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9250", Offset = "0x6EB8650", VA = "0x186EB9250")]
	[AsyncStateMachine(typeof(LNGLMEEGBBJ))]
	public static Task FBDAODHIBLC(Func<bool> HKAOLGPCJKN, TimeSpan JHOELLEDCNB, [Optional] CancellationToken EEHACKMODLA, [Optional] Action<OperationCanceledException>? NDNBOMOJFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9110", Offset = "0x6EB8510", VA = "0x186EB9110")]
	[AsyncStateMachine(typeof(AIEMODHJFCP))]
	public static Task FBDAODHIBLC(Func<bool> HKAOLGPCJKN, TimeSpan JHOELLEDCNB, TimeSpan CLEPFIEGJLA, [Optional] CancellationToken EEHACKMODLA, [Optional] Action<OperationCanceledException>? NDNBOMOJFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9AD0", Offset = "0x6EB8ED0", VA = "0x186EB9AD0")]
	[AsyncStateMachine(typeof(HMNIJDFCDAD))]
	[Obsolete]
	public static Task MCLOMEMGDDN(this Task BIDGKFLMMBN, Action IDDLBJACINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2E86380", Offset = "0x2E85780", VA = "0x182E86380")]
	[Obsolete]
	[AsyncStateMachine(typeof(JAHLNFFOOFI<>))]
	public static Task MCLOMEMGDDN<T>(this Task<T> BIDGKFLMMBN, Action<T> IDDLBJACINC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8D20", Offset = "0x6EB8120", VA = "0x186EB8D20")]
	private static void CJDAFLJPDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7EC0", Offset = "0x6EB72C0", VA = "0x186EB7EC0")]
	public static bool ACKKFFJLAID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8DD0", Offset = "0x6EB81D0", VA = "0x186EB8DD0")]
	private static void DFDHOKBEOJL(SynchronizationContext LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9710", Offset = "0x6EB8B10", VA = "0x186EB9710")]
	private static void JDCNHMEJKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9F60", Offset = "0x6EB9360", VA = "0x186EB9F60")]
	public static void PLBBFMJDIOC([Optional] string? ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9380", Offset = "0x6EB8780", VA = "0x186EB9380")]
	public static void GGMEHBAHPIB([Optional] string? ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9530", Offset = "0x6EB8930", VA = "0x186EB9530")]
	public static EHPLJOPADLG HBMNOOKGAGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9DC0", Offset = "0x6EB91C0", VA = "0x186EB9DC0")]
	public static EHPLJOPADLG MFPGEOABJNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8F50", Offset = "0x6EB8350", VA = "0x186EB8F50")]
	[AsyncStateMachine(typeof(HCCCOHGIOGM))]
	public static Task ECFHBHAMJLL(Func<Task> HGNEAAOPDDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NFAHBLEIIKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
	public NFAHBLEIIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KFBANBMPBBC : BDAKMCMKMDO
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly BDAKMCMKMDO FKMJLLKHOAH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime NLKNADNFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD2B0", Offset = "0x6EBC6B0", VA = "0x186EBD2B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset IKLMOAJHLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD250", Offset = "0x6EBC650", VA = "0x186EBD250", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KFBANBMPBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BDAKMCMKMDO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime NLKNADNFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset IKLMOAJHLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FENKGPMEFDN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long GEGCDKIOHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6A30", Offset = "0x6EB5E30", VA = "0x186EB6A30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long OJCBBAFELFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6C40", Offset = "0x6EB6040", VA = "0x186EB6C40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double PBABAHHGEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6D20", Offset = "0x6EB6120", VA = "0x186EB6D20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double FCMHJIOACMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6B60", Offset = "0x6EB5F60", VA = "0x186EB6B60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double DJLJMKHIMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6D70", Offset = "0x6EB6170", VA = "0x186EB6D70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double KBINGOEKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6B10", Offset = "0x6EB5F10", VA = "0x186EB6B10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6A80", Offset = "0x6EB5E80", VA = "0x186EB6A80")]
	public static double DBCLDDMDOPE(long FCFIBBDCFJM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6BB0", Offset = "0x6EB5FB0", VA = "0x186EB6BB0")]
	public static double JKIKAAOBPEO(long FCFIBBDCFJM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6DC0", Offset = "0x6EB61C0", VA = "0x186EB6DC0")]
	public static double OFMOPJNKBHL(double KLLLKMOGFJD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6C90", Offset = "0x6EB6090", VA = "0x186EB6C90")]
	public static long MKBOELFCCNM(long HEJMBOHMFMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6A20", Offset = "0x6EB5E20", VA = "0x186EB6A20")]
	public static long BNENPBHJELF(long MOBBAPMBNPK, long KJKNJMFKNCD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6E50", Offset = "0x6EB6250", VA = "0x186EB6E50")]
	public static double PJBAAAACEDL(long MOBBAPMBNPK, long KJKNJMFKNCD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6EB69C0", Offset = "0x6EB5DC0", VA = "0x186EB69C0")]
	public static double ACONBCNFPPF(long MOBBAPMBNPK, long KJKNJMFKNCD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class CDPEJJEMFNE : MDIAOJBFPIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan ADLACGMGCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer GBIEPJHIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan JHOELLEDCNB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan LNDNMLDABAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6EB4F60", Offset = "0x6EB4360", VA = "0x186EB4F60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? KMOMCBJPCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5230", Offset = "0x6EB4630", VA = "0x186EB5230")]
	[Preserve]
	public CDPEJJEMFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5290", Offset = "0x6EB4690", VA = "0x186EB5290")]
	public CDPEJJEMFNE(TimeSpan JHOELLEDCNB, [Optional] Action? PKFDIHLBCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4ED0", Offset = "0x6EB42D0", VA = "0x186EB4ED0", Slot = "7")]
	public void IOGIABOPHFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EB50C0", Offset = "0x6EB44C0", VA = "0x186EB50C0", Slot = "8")]
	public void NEKALHAKCFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4EA0", Offset = "0x6EB42A0", VA = "0x186EB4EA0", Slot = "9")]
	public void EJMCDLIDJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xC3FA60", Offset = "0xC3EE60", VA = "0x180C3FA60")]
	private void HNDJNMHNNBG(object PAHNKMKPPCD, ElapsedEventArgs OPGDECLDPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5130", Offset = "0x6EB4530", VA = "0x186EB5130")]
	private static void NLJFCOFJCEL(TimeSpan PJILPPCNJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4E00", Offset = "0x6EB4200", VA = "0x186EB4E00", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class EAFJAFLMLNJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? DMLPNLILDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string NNEADDNDADI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xA2CB50", Offset = "0xA2BF50", VA = "0x180A2CB50")]
	public EAFJAFLMLNJ(string KCBLOILGJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x412FAF0", Offset = "0x412EEF0", VA = "0x18412FAF0")]
	public EAFJAFLMLNJ(string KOHHCGEDHKD, string KCBLOILGJCD)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KCFDAINDPGI : IEquatable<KCFDAINDPGI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint IAFCHDELLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int PBHPDABMKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float HJGJFHJKNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort FNLNLPCLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort MOKJEIJCNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short MNOPMIANJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short MBPHFFGJEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char NFMIINFOBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char IBANBEMLKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte CKGLEAGAHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte KBKIGFCAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte CNOCCDCIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte MBIKGPAICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool ICJKABFODEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool PKDAJOCDNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool HDIKIECGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool JAKKHCAPLDA;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x175DE00", Offset = "0x175D200", VA = "0x18175DE00")]
	public static KCFDAINDPGI BAPOHBOKLNL(uint DFHBELGHFOG)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x175DE00", Offset = "0x175D200", VA = "0x18175DE00")]
	public static KCFDAINDPGI IEOMBAPKDAC(int GMMDNCGPFHF)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC370", Offset = "0x6EBB770", VA = "0x186EBC370")]
	public static KCFDAINDPGI OPKMDJMLBIE(float EDDCEPIDMHK)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2C0", Offset = "0x6EBB6C0", VA = "0x186EBC2C0")]
	public static KCFDAINDPGI ONJBNHJODKH(byte MNKNEMANGCA, byte HLFKJEONMDI, byte FHBAOGBCCDG, byte MGIPDAPNMLD)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2C0", Offset = "0x6EBB6C0", VA = "0x186EBC2C0")]
	public static KCFDAINDPGI EDOBDDPFDAA(bool FJOLBPPNIHM, bool GJPIDJAELPE, bool HHBIPFDCLBA, bool EHAHGHNIPAC)
	{
		return default(KCFDAINDPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2C0", Offset = "0x6EBB6C0", VA = "0x186EBC2C0")]
	public static KCFDAINDPGI CJAOCFCNBPA(byte NLAPCCJIJIJ, byte PEKMFKKKIOJ, byte MAHHIMALPGH, byte DKFJNFPCNIP)
	{
		return default(KCFDAINDPGI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1F75290", Offset = "0x1F74690", VA = "0x181F75290")]
	public static bool GBDINLJCMBD(KCFDAINDPGI GIDMNJLJNOH, KCFDAINDPGI OONEKAPAHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xD16580", Offset = "0xD15980", VA = "0x180D16580", Slot = "4")]
	public bool Equals(KCFDAINDPGI OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2E0", Offset = "0x6EBB6E0", VA = "0x186EBC2E0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xDC48F0", Offset = "0xDC3CF0", VA = "0x180DC48F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC380", Offset = "0x6EBB780", VA = "0x186EBC380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct AMHEEBKJIAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong PBEAPLHJKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long PLCALLEHJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double EBOIKOHLAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint EPBNNOIMOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint JHDGINAMKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int PHCAOOIOIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int IGEGFOELCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float FBIADGNLDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float JHCMINNLOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort FNLNLPCLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort MOKJEIJCNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort EOLKFPGAJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort NENNICHCNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short MNOPMIANJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short MBPHFFGJEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short CGPILEEDBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short HCJAAEACIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char NFMIINFOBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char IBANBEMLKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char CCGDCHALKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char FMIHLICOAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte CKGLEAGAHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte KBKIGFCAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte CNOCCDCIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte MBIKGPAICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte EKJLCPBOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte CANHMKHJCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte HGHKFEBEAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte JOHGPJHKKKJ;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static AMHEEBKJIAP AALKPJMFIHM(long EDCNABJAHLJ)
	{
		return default(AMHEEBKJIAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3F80", Offset = "0x6EB3380", VA = "0x186EB3F80")]
	public static AMHEEBKJIAP AALKPJMFIHM(byte MNKNEMANGCA, byte HLFKJEONMDI, byte FHBAOGBCCDG, byte MGIPDAPNMLD, byte KMBIAKGIEPF, byte NFEADKDFGBI, byte DPDNOMDKOFE, byte NGOKMFLCEDE)
	{
		return default(AMHEEBKJIAP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct AHLONJJCIDB : IEquatable<AHLONJJCIDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte LCGCFAGKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool HDPKMDGJOLG;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x280B330", Offset = "0x280A730", VA = "0x18280B330")]
	public static AHLONJJCIDB ONJBNHJODKH(byte LJMDCMFNDFD)
	{
		return default(AHLONJJCIDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x280B330", Offset = "0x280A730", VA = "0x18280B330")]
	public static AHLONJJCIDB EDOBDDPFDAA(bool HNHJJCGDJIC)
	{
		return default(AHLONJJCIDB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3790", Offset = "0x6EB2B90", VA = "0x186EB3790")]
	public static bool GBDINLJCMBD(AHLONJJCIDB GIDMNJLJNOH, AHLONJJCIDB OONEKAPAHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6028600", Offset = "0x6027A00", VA = "0x186028600", Slot = "4")]
	public bool Equals(AHLONJJCIDB OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3700", Offset = "0x6EB2B00", VA = "0x186EB3700", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6EB37A0", Offset = "0x6EB2BA0", VA = "0x186EB37A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6EB37B0", Offset = "0x6EB2BB0", VA = "0x186EB37B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NNMDGLIHFKD<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T OBGNGMPCLHB;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x48E6640", Offset = "0x48E5A40", VA = "0x1848E6640")]
	public NNMDGLIHFKD(T FHILAOELDLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class FMPAPMMBNCC
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B640", Offset = "0x2E5AA40", VA = "0x182E5B640")]
	public static IEnumerable<T> LNLEOOBGIBC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static T[] EBDOLCNLCED<T>(params T[] KDNELAGCKKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static IEnumerable<T> OBFAIJDEKKO<T>(params T[] KDNELAGCKKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static HashSet<T> DKJBMNJPLLO<T>(params T[] KDNELAGCKKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B550", Offset = "0x2E5A950", VA = "0x182E5B550")]
	public static KeyValuePair<TKey, TValue> IHHEBPCCHHO<TKey, TValue>([In] TKey GMJINMLEEAC, [In] TValue LIHHDPOHLDK) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static List<T> BLNDFGCJFPG<T>(IEnumerable<T> AAKOLIDMFPJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NBCAKKJDAAM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string HFJEBMJPLLG;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
	public NBCAKKJDAAM(string CAPKHGDIEMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object LIEKADHLMPM<T>([In] T HJEECPNIDIG);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object MBJGEMHMAIJ<T>(T HJEECPNIDIG);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[FEMCAFBMIJF]
public delegate string MLABIEKNIHI(string PCMCEFKLCKL, string? BKLOOOLLNJH, bool DNJHEPMOMPI);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FEMCAFBMIJF]
public delegate void EMHHDIKONOM(string ADPAIBGIHMB);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FEMCAFBMIJF]
public delegate void MLLMJGBNJNO(Exception JFJOELAOBOE);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object DEHOAJCBPJL();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FEMCAFBMIJF]
public delegate bool FFKDIIJCAIG();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[FEMCAFBMIJF]
public delegate string KJGGEHHGBGE(object PBAACPJGKNP);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class DFIEGJMPEME : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
	public DFIEGJMPEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class EEOHFGMLFNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct CIHHONACHGJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EB54E0", Offset = "0x6EB48E0", VA = "0x186EB54E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5DD0", Offset = "0x6EB51D0", VA = "0x186EB5DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback LMNJEGCICPP;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> MJPEOOJKMKD;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6400", Offset = "0x6EB5800", VA = "0x186EB6400")]
	public static Task<bool> FOBFOGKOGFN(int DHMOBKMEJID, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6700", Offset = "0x6EB5B00", VA = "0x186EB6700")]
	[AsyncStateMachine(typeof(CIHHONACHGJ))]
	private static Task<bool> KIHMLABBOPB(int DHMOBKMEJID, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6830", Offset = "0x6EB5C30", VA = "0x186EB6830")]
	private static void NIAJKGNLNNJ(object? NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6370", Offset = "0x6EB5770", VA = "0x186EB6370")]
	private static void FBKOFJHGNEH(object? NOGEMBGGBHJ)
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
