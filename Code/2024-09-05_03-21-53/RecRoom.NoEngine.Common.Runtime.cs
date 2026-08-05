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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C782E0", Offset = "0x6C76CE0", VA = "0x186C782E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMGLBDCHDAB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C72990", Offset = "0x6C71390", VA = "0x186C72990")]
	public static string BDGAIPHGANK(this Encoding BOKMLCPMMKH, [In] ReadOnlySequence<byte> OPJILLDCBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C88B40", Offset = "0x2C87540", VA = "0x182C88B40")]
	private static void NEBNIHPHLDG<T>(this ReadOnlySequence<T> LADNMCMIIGP, [Out] ReadOnlySpan<T> DDANFPODGEA, [Out] SequencePosition ECLFPLHHPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class KNOMMNHFNLH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C768A0", Offset = "0x6C752A0", VA = "0x186C768A0")]
	public KNOMMNHFNLH(bool IMHMNIIEDIB, string KDHMJAKACGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IMJLEJGFCAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CEAHGJDLCNH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JBLOMCCJDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHGCFOONICM(string JODEIIFHAPK, double CLMKDBDPNNH, [Optional] string? NIGIBFKNDEB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PBMCBNIJHHA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> DCLHEEAMGCC(CancellationToken OGJIGALEPCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EJIOMACMNKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public PBMCBNIJHHA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DCLHEEAMGCC taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3974E60", Offset = "0x3973860", VA = "0x183974E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3975FB0", Offset = "0x39749B0", VA = "0x183975FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource HKMLILDBOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? PKJMLAKEHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? FJFCCENABCA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x490A3E0", Offset = "0x4908DE0", VA = "0x18490A3E0")]
	[AsyncStateMachine(typeof(PBMCBNIJHHA<>.EJIOMACMNKK))]
	public Task<TResult> AJMANBIHIOM(DCLHEEAMGCC LHPIBEOMFAH, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x490A530", Offset = "0x4908F30", VA = "0x18490A530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x490A5A0", Offset = "0x4908FA0", VA = "0x18490A5A0")]
	public PBMCBNIJHHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class EBFLICLAJJB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> NMDPKMJLDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T GJBIHCLEEHA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3952590", Offset = "0x3950F90", VA = "0x183952590")]
	public EBFLICLAJJB([In] T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3951A60", Offset = "0x3950460", VA = "0x183951A60", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3951E60", Offset = "0x3950860", VA = "0x183951E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3952380", Offset = "0x3950D80", VA = "0x183952380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NNMELGJCANI
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static EBFLICLAJJB<T> MMKGNMBHOIH<T>([In] T CLMKDBDPNNH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EFCKLGHFJNB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C703B0", Offset = "0x6C6EDB0", VA = "0x186C703B0")]
	public static void LGGCIBHHDDM(this CancellationTokenSource HKMLILDBOFE, bool DFCKIOPNDJA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FMAFLCBOODF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
	public FMAFLCBOODF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class KEKAIFGNLLJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
	public KEKAIFGNLLJ(string CLPJBPLLKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FFJIIAECBKB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C61410", Offset = "0x2C5FE10", VA = "0x182C61410")]
	public static MMEALGJEGDN OGILNGDCIOP<T>()
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C61140", Offset = "0x2C5FB40", VA = "0x182C61140")]
	public static MMEALGJEGDN NABJBDHMPHJ<T>([CallerMemberName] string HBOONHFLONJ = "") where T : notnull
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C61390", Offset = "0x2C5FD90", VA = "0x182C61390")]
	public static MMEALGJEGDN OGILNGDCIOP<T>(this T AHPMMDKKKFB) where T : notnull
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2C60FA0", Offset = "0x2C5F9A0", VA = "0x182C60FA0")]
	public static MMEALGJEGDN DHDBKJACODD<T>(this T AHPMMDKKKFB, [CallerMemberName] string HBOONHFLONJ = "") where T : notnull
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2C611E0", Offset = "0x2C5FBE0", VA = "0x182C611E0")]
	public static MMEALGJEGDN NABJBDHMPHJ<T>(this T PECHDAFMNOO, [CallerMemberName] string HBOONHFLONJ = "") where T : notnull
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C705A0", Offset = "0x6C6EFA0", VA = "0x186C705A0")]
	public static MMEALGJEGDN NABJBDHMPHJ(string FLBDEJMAPIH, [CallerMemberName] string HBOONHFLONJ = "")
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C70500", Offset = "0x6C6EF00", VA = "0x186C70500")]
	public static string ENPICNMBNNI(this object PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool NGBBBMKHMEH();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FMAFLCBOODF]
public delegate long DALFMDOHFCC();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FFMAEMKHJED
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static OGMHHJBLJOH BCLGJLIBIOO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OGMHHJBLJOH KLLICOMIMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C70620", Offset = "0x6C6F020", VA = "0x186C70620")]
		get
		{
			return default(OGMHHJBLJOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static ONALFDNJHPD DDDLBLJKOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C70730", Offset = "0x6C6F130", VA = "0x186C70730")]
		get
		{
			return default(ONALFDNJHPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static ONOLBIFJKDJ CNBNOOLNCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C70670", Offset = "0x6C6F070", VA = "0x186C70670")]
		get
		{
			return default(ONOLBIFJKDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OAKHBJJOEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C70850", Offset = "0x6C6F250", VA = "0x186C70850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C70990", Offset = "0x6C6F390", VA = "0x186C70990")]
	public static void HONKBCLDGJK([In] OGMHHJBLJOH FOOIPOHADAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C70780", Offset = "0x6C6F180", VA = "0x186C70780")]
	public static void HBGLILHNFJH(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C708C0", Offset = "0x6C6F2C0", VA = "0x186C708C0")]
	public static void HKKPJELOGGF(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C61920", Offset = "0x2C60320", VA = "0x182C61920")]
	public static void HKKPJELOGGF<T>(T NBIHLDEPEPA, OJHKDABKGGM<T> MEBLNPKEJMN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C70C70", Offset = "0x6C6F670", VA = "0x186C70C70")]
	public static void MDGIMMNAENO(Exception PBKGKGDHMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C70D10", Offset = "0x6C6F710", VA = "0x186C70D10")]
	public static void MOMCEAOHEJB(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C70B30", Offset = "0x6C6F530", VA = "0x186C70B30")]
	public static void JIEBFOFGKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C706C0", Offset = "0x6C6F0C0", VA = "0x186C706C0")]
	public static string ENPICNMBNNI(object GIGIFGONEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C70E30", Offset = "0x6C6F830", VA = "0x186C70E30")]
	public static long PLANCHDBHFO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C70D90", Offset = "0x6C6F790", VA = "0x186C70D90")]
	public static bool OFIOHNMKJCB(bool PIIAKCKHONG, string MEBLNPKEJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C70BA0", Offset = "0x6C6F5A0", VA = "0x186C70BA0")]
	public static double MBNMPGCJCKF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct OGMHHJBLJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly ONALFDNJHPD DDDLBLJKOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly ONOLBIFJKDJ CNBNOOLNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NEHNPOJKNJM ICPCEDLAEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly DALFMDOHFCC CAALCFCBDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly PJJFOMDAMMN LGBBEAHDHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly NGBBBMKHMEH JLNBMEPLHKM;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NEHNPOJKNJM MHJLAIDPLMI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly DALFMDOHFCC KGECOEAOKIF;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly PJJFOMDAMMN BDGLAAIDBDO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly NGBBBMKHMEH EGAKFOBHHFL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly OGMHHJBLJOH MANEDJLMOBE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C78580", Offset = "0x6C76F80", VA = "0x186C78580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C78DD0", Offset = "0x6C777D0", VA = "0x186C78DD0")]
	public OGMHHJBLJOH([In] ONALFDNJHPD EIEAIBNDGIE, [In] ONOLBIFJKDJ HFPDJIGGCHN, NEHNPOJKNJM ABAAJBBCDJE, DALFMDOHFCC EAGHENDLMKL, PJJFOMDAMMN GIEFDOJFMHB, NGBBBMKHMEH GMDOOLGMGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C78540", Offset = "0x6C76F40", VA = "0x186C78540")]
	private static string JOOOGMNKFKD(object GIGIFGONEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
	private static long NKOKFKBKPPB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	private static string JENOEKLAGCL(string EEOEDIPLNFM, string? DCPDLABEFAK, bool EMEDOKNGKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	private static bool IHJKELPEFKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C78440", Offset = "0x6C76E40", VA = "0x186C78440")]
	private static OGMHHJBLJOH FJHOAKGAJHJ()
	{
		return default(OGMHHJBLJOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ELHHHFLPGPA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLKIDLLBKPF FOLONLOKBBG();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HLKIDLLBKPF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BDNJHNKEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKCAIFDBLLI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GHEOLLPMBFN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NKOHMPDMIJC([In] T AIPFCMFLDKG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void GLJBLKMKGNL<T>([In] T NBIHLDEPEPA);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct JAEMAELEHCJ<T> : IEquatable<JAEMAELEHCJ<T>>, GHEOLLPMBFN<JAEMAELEHCJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T GJBIHCLEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int MOMFAOPBBMD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x20CE150", Offset = "0x20CCB50", VA = "0x1820CE150")]
	public JAEMAELEHCJ([In] T CLMKDBDPNNH, int EBDDHAPIAHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x41F4490", Offset = "0x41F2E90", VA = "0x1841F4490")]
	public static bool LBPOCMFLOBH([In] JAEMAELEHCJ<T> JHAFNHPHBBL, [In] JAEMAELEHCJ<T> GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x41F3A30", Offset = "0x41F2430", VA = "0x1841F3A30", Slot = "4")]
	public bool Equals(JAEMAELEHCJ<T> AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3954D10", Offset = "0x3953710", VA = "0x183954D10", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x41F50B0", Offset = "0x41F3AB0", VA = "0x1841F50B0")]
	public bool NKOHMPDMIJC([In] JAEMAELEHCJ<T> AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41F40F0", Offset = "0x41F2AF0", VA = "0x1841F40F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41F51A0", Offset = "0x41F3BA0", VA = "0x1841F51A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41F4E40", Offset = "0x41F3840", VA = "0x1841F4E40")]
	public void LPCIDOHDNGA([Out] T CLMKDBDPNNH, [Out] int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41F3EC0", Offset = "0x41F28C0", VA = "0x1841F3EC0")]
	public (T, int) FENEKDDDEMH()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41F5150", Offset = "0x41F3B50", VA = "0x1841F5150", Slot = "5")]
	private bool NMPEFAHKPIF([In] JAEMAELEHCJ<T> AIPFCMFLDKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HKFFGCJGNBF
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C97CE0", Offset = "0x2C966E0", VA = "0x182C97CE0")]
	public static JAEMAELEHCJ<T> MMKGNMBHOIH<T>([In] T CLMKDBDPNNH, int EBDDHAPIAHH) where T : notnull
	{
		return default(JAEMAELEHCJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class EMJKACILLCH
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B256A0", Offset = "0x2B240A0", VA = "0x182B256A0")]
	public static bool NKOHMPDMIJC<T, U>([In] T PECHDAFMNOO, [In] U GIGIFGONEAO) where T : notnull, GHEOLLPMBFN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult AFELKDCONFE<T, out TResult>([In] T NBIHLDEPEPA);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ABONPNGBKIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan BHHGENHICKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? NBNCCOKMEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIIEGDCHIMI();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMFPIEIBEFP();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ENMEPABNHMI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ONALFDNJHPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly FLFCFELIINI JAKFFIAHBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KACPPJJKJAD KLFFHJIHODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FLFCFELIINI PGAPEIHHIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly KACPPJJKJAD FIOHFPLHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly FLFCFELIINI JGFKPMOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly KACPPJJKJAD KGLCHHOGHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly EOFAOCHGMBL BHOLIGJECDB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly FLFCFELIINI NPJKCPIEDAE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KACPPJJKJAD MPGFDJGJPNM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FLFCFELIINI FFEEEJHLFCB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KACPPJJKJAD ALHDOCNOLFA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly FLFCFELIINI IBJHEGJCLGC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KACPPJJKJAD IFCJNFMNBNN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EOFAOCHGMBL BADEKEOFBAF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ONALFDNJHPD MANEDJLMOBE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly FLFCFELIINI MMCPIABJGLM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C79720", Offset = "0x6C78120", VA = "0x186C79720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xCC23F0", Offset = "0xCC0DF0", VA = "0x180CC23F0")]
	public ONALFDNJHPD(FLFCFELIINI DFKPMIOLOAF, KACPPJJKJAD PFPIFKLPJIL, FLFCFELIINI CADHOPECBCG, KACPPJJKJAD HPDIDMLNNHD, FLFCFELIINI NEEBDCEABBL, KACPPJJKJAD KGPHPHCACFE, EOFAOCHGMBL NINPAIJKABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	private static bool AKDCPJDCDED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void MJPMCBELPKE(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	private static bool AELOIJKBAEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void CNILAHIMKKC(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0")]
	private static bool HNNFMOPHFBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void JKLLLDNMJAO(string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void BCFOACCODNP(Exception PBKGKGDHMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C79420", Offset = "0x6C77E20", VA = "0x186C79420")]
	private static ONALFDNJHPD FJHOAKGAJHJ()
	{
		return default(ONALFDNJHPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
	private static bool IHJBEEBCJDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C79560", Offset = "0x6C77F60", VA = "0x186C79560")]
	public void HBGLILHNFJH(object MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C795D0", Offset = "0x6C77FD0", VA = "0x186C795D0")]
	public void HKKPJELOGGF(object MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E3DF30", Offset = "0x1E3C930", VA = "0x181E3DF30")]
	public void MDGIMMNAENO(Exception PBKGKGDHMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C79640", Offset = "0x6C78040", VA = "0x186C79640")]
	public void HKKPJELOGGF(KJHIJALJHNP MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E23BC0", Offset = "0x2E225C0", VA = "0x182E23BC0")]
	public void HKKPJELOGGF<T>(T NBIHLDEPEPA, OJHKDABKGGM<T> MEBLNPKEJMN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E237B0", Offset = "0x2E221B0", VA = "0x182E237B0")]
	public void HBGLILHNFJH<T>([In] T NBIHLDEPEPA, FDBGKNKPEDC<T> MEBLNPKEJMN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E23950", Offset = "0x2E22350", VA = "0x182E23950")]
	public void HKKPJELOGGF<T>([In] T NBIHLDEPEPA, FDBGKNKPEDC<T> MEBLNPKEJMN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C79900", Offset = "0x6C78300", VA = "0x186C79900")]
	public bool OFIOHNMKJCB(bool PIIAKCKHONG, string MEBLNPKEJMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct MMEALGJEGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string GJBIHCLEEHA;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	public MMEALGJEGDN(string CLMKDBDPNNH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
	public static string PFMAFNCLKDD([In] MMEALGJEGDN PECHDAFMNOO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB28530", Offset = "0xB26F30", VA = "0x180B28530")]
	public static MMEALGJEGDN PFMAFNCLKDD(string AIPFCMFLDKG)
	{
		return default(MMEALGJEGDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C77E00", Offset = "0x6C76800", VA = "0x186C77E00")]
	public string KGLDGLFOPCL(string GBMMOFEFFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C77D20", Offset = "0x6C76720", VA = "0x186C77D20")]
	public string IFOCGPAEOAB(object OGMJBGPFFOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct IEPJDCHMGFO : IEquatable<IEPJDCHMGFO>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "4")]
	public bool Equals(IEPJDCHMGFO AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C72F50", Offset = "0x6C71950", VA = "0x186C72F50", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C72FA0", Offset = "0x6C719A0", VA = "0x186C72FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C72FB0", Offset = "0x6C719B0", VA = "0x186C72FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OIGNFCKIMEJ("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MKGNLHEPBHJ<T> : IEquatable<MKGNLHEPBHJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T GJBIHCLEEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool BFBGDNALBIB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KABIHLDOGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x46276D0", Offset = "0x46260D0", VA = "0x1846276D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4627E60", Offset = "0x4626860", VA = "0x184627E60")]
	public MKGNLHEPBHJ([In] T CLMKDBDPNNH, bool CCMANKGFMID)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4627410", Offset = "0x4625E10", VA = "0x184627410")]
	public static bool LBPOCMFLOBH([In] MKGNLHEPBHJ<T> JHAFNHPHBBL, [In] MKGNLHEPBHJ<T> GONHEFIHLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x41F3A30", Offset = "0x41F2430", VA = "0x1841F3A30", Slot = "4")]
	public bool Equals(MKGNLHEPBHJ<T> AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4626780", Offset = "0x4625180", VA = "0x184626780", Slot = "0")]
	public override bool Equals(object AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4626DB0", Offset = "0x46257B0", VA = "0x184626DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4627A50", Offset = "0x4626450", VA = "0x184627A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AMEFHLAPKDJ
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x336B990", Offset = "0x336A390", VA = "0x18336B990")]
	public static MKGNLHEPBHJ<T> KAMNELJMEHO<T>([In] T CLMKDBDPNNH) where T : notnull
	{
		return default(MKGNLHEPBHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x336B790", Offset = "0x336A190", VA = "0x18336B790")]
	public static MKGNLHEPBHJ<T?> JHPILCGCNBF<T>()
	{
		return default(MKGNLHEPBHJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x336B8D0", Offset = "0x336A2D0", VA = "0x18336B8D0")]
	public static bool JOMODAJKNKK<T>([In] this MKGNLHEPBHJ<T> GOMJMIHELCE, [Out][NotNullWhen(true)] T CLMKDBDPNNH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x336B6A0", Offset = "0x336A0A0", VA = "0x18336B6A0")]
	public static T? BNBIHAPCODD<T>([In] this MKGNLHEPBHJ<T> GOMJMIHELCE, T? PEMAOEALEHB)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct ONOLBIFJKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr MOMCEAOHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr JIEBFOFGKDD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr IDJJFABNKHO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr JEDKPLAFONM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly ONOLBIFJKDJ MANEDJLMOBE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C7A010", Offset = "0x6C78A10", VA = "0x186C7A010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public ONOLBIFJKDJ(IntPtr HPLNEENFIGH, IntPtr OHCIPDGJKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void JFGBAMCNFBO(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void HFAFPIGAFFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C79F80", Offset = "0x6C78980", VA = "0x186C79F80")]
	private static ONOLBIFJKDJ FJHOAKGAJHJ()
	{
		return default(ONOLBIFJKDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct EKJHKFFCPOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr NOBFFKPHMLF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	private EKJHKFFCPOP(IntPtr OHCIPDGJKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C703E0", Offset = "0x6C6EDE0", VA = "0x186C703E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C70400", Offset = "0x6C6EE00", VA = "0x186C70400")]
	public static EKJHKFFCPOP MMKGNMBHOIH(string HBOONHFLONJ)
	{
		return default(EKJHKFFCPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20ACE30", Offset = "0x20AB830", VA = "0x1820ACE30")]
	public static EKJHKFFCPOP MMKGNMBHOIH([In] ONOLBIFJKDJ HFPDJIGGCHN, string HBOONHFLONJ)
	{
		return default(EKJHKFFCPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20AD0B0", Offset = "0x20ABAB0", VA = "0x1820AD0B0")]
	public static EKJHKFFCPOP MMKGNMBHOIH([In] ONOLBIFJKDJ HFPDJIGGCHN, Func<string> HBOONHFLONJ)
	{
		return default(EKJHKFFCPOP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ILMCBBNMPLO
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool HDJHBFBFOFC<in TInput, TResult>(TInput DKDIADEJLHP, [Out] TResult DFEFBOIIPKP);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class AINGLJKAPJF : ELHHHFLPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class JDMPAPMBOMB : HLKIDLLBKPF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly JDMPAPMBOMB LPENGNKGBMO;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool BDNJHNKEMGE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x6C758F0", Offset = "0x6C742F0", VA = "0x186C758F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C757A0", Offset = "0x6C741A0", VA = "0x186C757A0", Slot = "6")]
			public void OnCompleted(Action KHCEAHCMJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			public void HKCAIFDBLLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public JDMPAPMBOMB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly AINGLJKAPJF LPENGNKGBMO;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		private AINGLJKAPJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F030", Offset = "0x6C6DA30", VA = "0x186C6F030", Slot = "4")]
		public HLKIDLLBKPF FOLONLOKBBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class NGJAPDCCOFG : ELHHHFLPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class OAEBJNGHFEE : HLKIDLLBKPF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly OAEBJNGHFEE LPENGNKGBMO;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool BDNJHNKEMGE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x6C783B0", Offset = "0x6C76DB0", VA = "0x186C783B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6C78360", Offset = "0x6C76D60", VA = "0x186C78360", Slot = "6")]
			public void OnCompleted(Action KHCEAHCMJON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			public void HKCAIFDBLLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public OAEBJNGHFEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly NGJAPDCCOFG LPENGNKGBMO;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		private NGJAPDCCOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C78110", Offset = "0x6C76B10", VA = "0x186C78110", Slot = "4")]
		public HLKIDLLBKPF FOLONLOKBBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BFOIOINPBAI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BFOIOINPBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F95A90", Offset = "0x3F94490", VA = "0x183F95A90")]
		internal void OFFPECDIKHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GFAJDIEBFGG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public GFAJDIEBFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DE00", Offset = "0x3E0C800", VA = "0x183E0DE00")]
		internal void JOJBICMDPFN(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JKBLHBJGAJH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6C75C00", Offset = "0x6C74600", VA = "0x186C75C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NNAIIGECOPJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C781D0", Offset = "0x6C76BD0", VA = "0x186C781D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct CBKPIIIOGJD<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5110C00", Offset = "0x510F600", VA = "0x185110C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5110D70", Offset = "0x510F770", VA = "0x185110D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PKOJNBBCOEN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4936100", Offset = "0x4934B00", VA = "0x184936100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4936550", Offset = "0x4934F50", VA = "0x184936550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LPPMBEGKJHF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C77150", Offset = "0x6C75B50", VA = "0x186C77150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C77350", Offset = "0x6C75D50", VA = "0x186C77350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IBCABFEBABK<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IBCABFEBABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F95A90", Offset = "0x3F94490", VA = "0x183F95A90")]
		internal void IOFLAANHDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F95A10", Offset = "0x3F94410", VA = "0x183F95A10")]
		internal void EJKFNJKKMII(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HHLBPKFBMOP<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public HDJHBFBFOFC<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4B30", Offset = "0x3EE3530", VA = "0x183EE4B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3EE52A0", Offset = "0x3EE3CA0", VA = "0x183EE52A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct FKLNBBJKCGO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C70F60", Offset = "0x6C6F960", VA = "0x186C70F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C71750", Offset = "0x6C70150", VA = "0x186C71750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OKNBLIMENFD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6C78E80", Offset = "0x6C77880", VA = "0x186C78E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C793C0", Offset = "0x6C77DC0", VA = "0x186C793C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct LFKOFFGBOKG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4421F10", Offset = "0x4420910", VA = "0x184421F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4007890", Offset = "0x4006290", VA = "0x184007890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ALKAJEJIMFK<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DE95A0", Offset = "0x3DE7FA0", VA = "0x183DE95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36B73D0", Offset = "0x36B5DD0", VA = "0x1836B73D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LMAIKJJEMMP<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4439DE0", Offset = "0x44387E0", VA = "0x184439DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x443AB50", Offset = "0x4439550", VA = "0x18443AB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DGPMLKMADGA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F620", Offset = "0x6C6E020", VA = "0x186C6F620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F800", Offset = "0x6C6E200", VA = "0x186C6F800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KAPELKBIAFH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C75D60", Offset = "0x6C74760", VA = "0x186C75D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6C760C0", Offset = "0x6C74AC0", VA = "0x186C760C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DCCHKMCIMII : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F2D0", Offset = "0x6C6DCD0", VA = "0x186C6F2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F5C0", Offset = "0x6C6DFC0", VA = "0x186C6F5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OPNJKFJDIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public OPNJKFJDIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7A220", Offset = "0x6C78C20", VA = "0x186C7A220")]
		internal Task JCKCMLPEBOO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NCMEECNKHHL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C77E50", Offset = "0x6C76850", VA = "0x186C77E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C780B0", Offset = "0x6C76AB0", VA = "0x186C780B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct JFOLFKHKBDI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C759C0", Offset = "0x6C743C0", VA = "0x186C759C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C75BA0", Offset = "0x6C745A0", VA = "0x186C75BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IFEICLFEMDP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C72FE0", Offset = "0x6C719E0", VA = "0x186C72FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C73340", Offset = "0x6C71D40", VA = "0x186C73340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DNIONDJKHGD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C70060", Offset = "0x6C6EA60", VA = "0x186C70060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C70350", Offset = "0x6C6ED50", VA = "0x186C70350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LJHHDEKICHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LJHHDEKICHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C770E0", Offset = "0x6C75AE0", VA = "0x186C770E0")]
		internal Task PJBPNIMGDMD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FMFJJOJGGCI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C717B0", Offset = "0x6C701B0", VA = "0x186C717B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C71A10", Offset = "0x6C70410", VA = "0x186C71A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BAFBPDEPJIB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F0F0", Offset = "0x6C6DAF0", VA = "0x186C6F0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F270", Offset = "0x6C6DC70", VA = "0x186C6F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DNCOGILIKDJ<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A979E0", Offset = "0x5A963E0", VA = "0x185A979E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5A97C60", Offset = "0x5A96660", VA = "0x185A97C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KMAKMBCBCHK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6C76440", Offset = "0x6C74E40", VA = "0x186C76440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6C76840", Offset = "0x6C75240", VA = "0x186C76840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? FOPAFMOGIEB;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<IEPJDCHMGFO> OEDNDNPFOCC;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task APLNPBFFNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C74680", Offset = "0x6C73080", VA = "0x186C74680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C74EF0", Offset = "0x6C738F0", VA = "0x186C74EF0")]
	public static bool MFBNKENMLCK(this Task CCAACFNOONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5BB0", Offset = "0x2CD45B0", VA = "0x182CD5BB0")]
	public static Task<T> EAALNHAIHGI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C74CA0", Offset = "0x6C736A0", VA = "0x186C74CA0")]
	public static Task LJCOHLFJAFO(this Task CCAACFNOONL, CancellationToken KLGLJKMNAIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2CD88E0", Offset = "0x2CD72E0", VA = "0x182CD88E0")]
	public static Task<TResult> LJCOHLFJAFO<TResult>(this Task<TResult> CCAACFNOONL, CancellationToken KLGLJKMNAIM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9540", Offset = "0x2CD7F40", VA = "0x182CD9540")]
	public static TaskCompletionSource<TResult> LJCOHLFJAFO<TResult>(this TaskCompletionSource<TResult> LEENFLIPNGA, CancellationToken KLGLJKMNAIM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C73CF0", Offset = "0x6C726F0", VA = "0x186C73CF0")]
	public static IDisposable? APNGBKNNMLJ(CancellationToken BEMMIDKCJIK, CancellationToken AMJLELPBFNB, [Out] CancellationToken DNFDFPBPHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C747E0", Offset = "0x6C731E0", VA = "0x186C747E0")]
	[AsyncStateMachine(typeof(JKBLHBJGAJH))]
	public static void HFANMLLNLBH(this Task LJDCGGEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C744A0", Offset = "0x6C72EA0", VA = "0x186C744A0")]
	[AsyncStateMachine(typeof(NNAIIGECOPJ))]
	public static void DKGGHNHOOJJ(this Task LJDCGGEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5840", Offset = "0x2CD4240", VA = "0x182CD5840")]
	[AsyncStateMachine(typeof(CBKPIIIOGJD<>))]
	public static Task ACFPHALENLH<TException>(this Task LJDCGGEFKLJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5FF0", Offset = "0x2CD49F0", VA = "0x182CD5FF0")]
	[AsyncStateMachine(typeof(PKOJNBBCOEN<>))]
	public static Task<T> GOLHCKIBNPL<T>(this Task<T> PECHDAFMNOO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C743B0", Offset = "0x6C72DB0", VA = "0x186C743B0")]
	[AsyncStateMachine(typeof(LPPMBEGKJHF))]
	public static Task<TaskStatus> DEJNJELDHIJ(this Task PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD62C0", Offset = "0x2CD4CC0", VA = "0x182CD62C0")]
	public static (Task<T?>?, Action<T?>?) KDOLLDMJBHB<T>([Optional] CancellationToken OGJIGALEPCA)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6540", Offset = "0x2CD4F40", VA = "0x182CD6540")]
	[AsyncStateMachine(typeof(HHLBPKFBMOP<, >))]
	public static Task<List<TResult>> LEKIABJNBBN<TResult, TInput>(this Task<List<TInput>> CCAACFNOONL, HDJHBFBFOFC<TInput, TResult> PAFHOKILCOH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C748E0", Offset = "0x6C732E0", VA = "0x186C748E0")]
	[AsyncStateMachine(typeof(FKLNBBJKCGO))]
	public static Task HLOGJGHHOMO(Task LJDCGGEFKLJ, CancellationToken OFDGBDFAIOO, Func<CancellationToken, Task> KMMKEOHFACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C74550", Offset = "0x6C72F50", VA = "0x186C74550")]
	[AsyncStateMachine(typeof(OKNBLIMENFD))]
	public static Task DOLDPNJOCDJ(Func<CancellationToken, Task> CBICBAMHFEK, TimeSpan FDABJAMIIEL, [Optional] CancellationToken OFDGBDFAIOO, [Optional] Action<OperationCanceledException>? KMABIBBKBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5910", Offset = "0x2CD4310", VA = "0x182CD5910")]
	[AsyncStateMachine(typeof(LFKOFFGBOKG<>))]
	public static Task<T> DOLDPNJOCDJ<T>(Func<CancellationToken, Task<T>> CBICBAMHFEK, TimeSpan FDABJAMIIEL, [Optional] CancellationToken OFDGBDFAIOO, [Optional] Func<OperationCanceledException, T>? KMABIBBKBIM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD9FC0", Offset = "0x2CD89C0", VA = "0x182CD9FC0")]
	[AsyncStateMachine(typeof(ALKAJEJIMFK<>))]
	public static Task<IEnumerable<Task<T>>> MHPCLMMIAOM<T>(IEnumerable<Task<T>> MIDIBGMFDGF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5D30", Offset = "0x2CD4730", VA = "0x182CD5D30")]
	[AsyncStateMachine(typeof(LMAIKJJEMMP<, , , >))]
	public static Task<(T1, T2, T3, T4)> GMLLJPFKFME<T1, T2, T3, T4>(Task<T1> IJDCOBDFGLK, Task<T2> PBJDMODKGOK, Task<T3> CHMCFKLBOIG, Task<T4> FLHOAIBCLLD) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C73E30", Offset = "0x6C72830", VA = "0x186C73E30")]
	[AsyncStateMachine(typeof(DGPMLKMADGA))]
	public static Task BDHDMKFJJEB(Func<bool> PIIAKCKHONG, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C73F20", Offset = "0x6C72920", VA = "0x186C73F20")]
	[AsyncStateMachine(typeof(KAPELKBIAFH))]
	public static Task BDHDMKFJJEB(Func<bool> PIIAKCKHONG, TimeSpan CKHELLNNNPJ, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C75420", Offset = "0x6C73E20", VA = "0x186C75420")]
	[AsyncStateMachine(typeof(DCCHKMCIMII))]
	public static Task NIAOAIJNPME(Func<bool> PIIAKCKHONG, TimeSpan FDABJAMIIEL, [Optional] CancellationToken OGJIGALEPCA, [Optional] Action<OperationCanceledException>? KMABIBBKBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C75550", Offset = "0x6C73F50", VA = "0x186C75550")]
	[AsyncStateMachine(typeof(NCMEECNKHHL))]
	public static Task NIAOAIJNPME(Func<bool> PIIAKCKHONG, TimeSpan FDABJAMIIEL, TimeSpan CKHELLNNNPJ, [Optional] CancellationToken OGJIGALEPCA, [Optional] Action<OperationCanceledException>? KMABIBBKBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C74030", Offset = "0x6C72A30", VA = "0x186C74030")]
	[AsyncStateMachine(typeof(JFOLFKHKBDI))]
	public static Task CAOJOLCHEDA(Func<bool> PIIAKCKHONG, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C74120", Offset = "0x6C72B20", VA = "0x186C74120")]
	[AsyncStateMachine(typeof(IFEICLFEMDP))]
	public static Task CAOJOLCHEDA(Func<bool> PIIAKCKHONG, TimeSpan CKHELLNNNPJ, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C73BC0", Offset = "0x6C725C0", VA = "0x186C73BC0")]
	[AsyncStateMachine(typeof(DNIONDJKHGD))]
	public static Task ACGEMJDJFCL(Func<bool> PIIAKCKHONG, TimeSpan FDABJAMIIEL, [Optional] CancellationToken OGJIGALEPCA, [Optional] Action<OperationCanceledException>? KMABIBBKBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C73A80", Offset = "0x6C72480", VA = "0x186C73A80")]
	[AsyncStateMachine(typeof(FMFJJOJGGCI))]
	public static Task ACGEMJDJFCL(Func<bool> PIIAKCKHONG, TimeSpan FDABJAMIIEL, TimeSpan CKHELLNNNPJ, [Optional] CancellationToken OGJIGALEPCA, [Optional] Action<OperationCanceledException>? KMABIBBKBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C746F0", Offset = "0x6C730F0", VA = "0x186C746F0")]
	[AsyncStateMachine(typeof(BAFBPDEPJIB))]
	[Obsolete]
	public static Task HBOEAIAELED(this Task CCAACFNOONL, Action FBMMNAKLLLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD61D0", Offset = "0x2CD4BD0", VA = "0x182CD61D0")]
	[AsyncStateMachine(typeof(DNCOGILIKDJ<>))]
	[Obsolete]
	public static Task HBOEAIAELED<T>(this Task<T> CCAACFNOONL, Action<T> FBMMNAKLLLE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C74AE0", Offset = "0x6C734E0", VA = "0x186C74AE0")]
	private static void JMCJHDCKNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C74F20", Offset = "0x6C73920", VA = "0x186C74F20")]
	public static bool MIPNAGDAEJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C74230", Offset = "0x6C72C30", VA = "0x186C74230")]
	private static void CDMOHBMDNLJ(SynchronizationContext CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C74B90", Offset = "0x6C73590", VA = "0x186C74B90")]
	private static void KGPHKOIDNEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C752D0", Offset = "0x6C73CD0", VA = "0x186C752D0")]
	public static void MMFDGABEOLB([Optional] string? MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C753A0", Offset = "0x6C73DA0", VA = "0x186C753A0")]
	public static void NIAGBCIBEEE([Optional] string? MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C75280", Offset = "0x6C73C80", VA = "0x186C75280")]
	public static ELHHHFLPGPA MKHILEALNHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C74890", Offset = "0x6C73290", VA = "0x186C74890")]
	public static ELHHHFLPGPA HGJPAMHCFAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C74A10", Offset = "0x6C73410", VA = "0x186C74A10")]
	[AsyncStateMachine(typeof(KMAKMBCBCHK))]
	public static Task IJDGCCOEALN(Func<Task> MIDOKEPAEFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PLAFBFJHEAK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
	public PLAFBFJHEAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LFABKHPGIKN : GOIJNKHANAB
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly GOIJNKHANAB LPENGNKGBMO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime JKPCGNCBJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6C76FD0", Offset = "0x6C759D0", VA = "0x186C76FD0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset LGKCANKBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6C77010", Offset = "0x6C75A10", VA = "0x186C77010", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LFABKHPGIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GOIJNKHANAB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime JKPCGNCBJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset LGKCANKBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DJLGNBPMOOI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long KMIPHBOBDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FAD0", Offset = "0x6C6E4D0", VA = "0x186C6FAD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long AMAMDCKEOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C6F860", Offset = "0x6C6E260", VA = "0x186C6F860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double JDGKHHNKEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FC50", Offset = "0x6C6E650", VA = "0x186C6FC50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double DIDAFHKCNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FA10", Offset = "0x6C6E410", VA = "0x186C6FA10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LOFNJMLDMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FBB0", Offset = "0x6C6E5B0", VA = "0x186C6FBB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double OOEKHPCOJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C6FC00", Offset = "0x6C6E600", VA = "0x186C6FC00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FB20", Offset = "0x6C6E520", VA = "0x186C6FB20")]
	public static double HJINLIEJIAN(long HHLJMAGJCME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FCA0", Offset = "0x6C6E6A0", VA = "0x186C6FCA0")]
	public static double NNAFGABCKKC(long HHLJMAGJCME)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F8B0", Offset = "0x6C6E2B0", VA = "0x186C6F8B0")]
	public static double BKEMPCLGMKG(double EENHNPNMOPD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FD30", Offset = "0x6C6E730", VA = "0x186C6FD30")]
	public static long OBHKLIEEENN(long CCMOFMGPDOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FAC0", Offset = "0x6C6E4C0", VA = "0x186C6FAC0")]
	public static long FPLJOPLFBII(long KDGELMNOLMC, long JMMHIJFAGJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6F940", Offset = "0x6C6E340", VA = "0x186C6F940")]
	public static double CGPONAOFADP(long KDGELMNOLMC, long JMMHIJFAGJK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6FA60", Offset = "0x6C6E460", VA = "0x186C6FA60")]
	public static double FEFBGNPNPHH(long KDGELMNOLMC, long JMMHIJFAGJK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class IIBEKGHKNKH : ABONPNGBKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public static readonly TimeSpan NCOCMLLKJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly System.Timers.Timer ANDGGAMNIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private TimeSpan FDABJAMIIEL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan BHHGENHICKM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73590", Offset = "0x6C71F90", VA = "0x186C73590", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? NBNCCOKMEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C73A20", Offset = "0x6C72420", VA = "0x186C73A20")]
	[Preserve]
	public IIBEKGHKNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C737D0", Offset = "0x6C721D0", VA = "0x186C737D0")]
	public IIBEKGHKNKH(TimeSpan FDABJAMIIEL, [Optional] Action? MIJIKOFKKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C734D0", Offset = "0x6C71ED0", VA = "0x186C734D0", Slot = "7")]
	public void EIIEGDCHIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C736F0", Offset = "0x6C720F0", VA = "0x186C736F0", Slot = "8")]
	public void JMFPIEIBEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C73560", Offset = "0x6C71F60", VA = "0x186C73560", Slot = "9")]
	public void ENMEPABNHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
	private void OMNBGJBBBJJ(object AHPMMDKKKFB, ElapsedEventArgs OAIHKAGMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C733A0", Offset = "0x6C71DA0", VA = "0x186C733A0")]
	private static void AEHDKNDADAO(TimeSpan EMDFPFLBJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C73430", Offset = "0x6C71E30", VA = "0x186C73430", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OIGNFCKIMEJ : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly string? MAFPAIAOLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public readonly string FDOJDMGKCMJ;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E220", Offset = "0x1F5CC20", VA = "0x181F5E220")]
	public OIGNFCKIMEJ(string OMGOMGJLFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3E51870", Offset = "0x3E50270", VA = "0x183E51870")]
	public OIGNFCKIMEJ(string HAEMEJAGICK, string OMGOMGJLFOM)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GFDAFGLFBDL : IEquatable<GFDAFGLFBDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public uint NMBNKMAMALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int HCNNOCDPJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float LBFLKEIPDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public ushort LLEKKCFFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public ushort HGPCKFFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public short IKOBAIFBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public short BMGOKDGIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public char NKIADECLHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public char LDPLJFMPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte PCNKBHHDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte AIJFPAIFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte IIICDCIAKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte GBPAANOEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool OJLECNICIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool LHJFKKHHPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool OAGFELFIEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool PLFAGBFGCAC;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x140D770", Offset = "0x140C170", VA = "0x18140D770")]
	public static GFDAFGLFBDL IMAHJCPPCBN(uint FKEOANGCOFM)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x140D770", Offset = "0x140C170", VA = "0x18140D770")]
	public static GFDAFGLFBDL PGNDIIDNCPB(int EPNBMFOFBHE)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C71A70", Offset = "0x6C70470", VA = "0x186C71A70")]
	public static GFDAFGLFBDL BHKLOOCOEOE(float CBMPLIDNMHC)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C71B10", Offset = "0x6C70510", VA = "0x186C71B10")]
	public static GFDAFGLFBDL LCMMJHLCPPM(byte LAMHOJOHLIH, byte KCDJFDLOBIE, byte MIPCMLEANHG, byte OPNOGAHABOF)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C71B10", Offset = "0x6C70510", VA = "0x186C71B10")]
	public static GFDAFGLFBDL FNDKJMGCAJN(bool BJCAPLIOOPO, bool KCHJDHJJJDK, bool AGLFFBGLEFC, bool HMMGKELMLPL)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C71B10", Offset = "0x6C70510", VA = "0x186C71B10")]
	public static GFDAFGLFBDL OLLHKGNMNMM(byte KJJEMGIKNGE, byte NHLINENLLNE, byte NEDBFEMKAOP, byte MIJFGNDNCIC)
	{
		return default(GFDAFGLFBDL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1CAAE10", Offset = "0x1CA9810", VA = "0x181CAAE10")]
	public static bool LBPOCMFLOBH(GFDAFGLFBDL CGCFANNHAMA, GFDAFGLFBDL GEGAHIEHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xB7BA80", Offset = "0xB7A480", VA = "0x180B7BA80", Slot = "4")]
	public bool Equals(GFDAFGLFBDL AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C71A80", Offset = "0x6C70480", VA = "0x186C71A80", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xC4B690", Offset = "0xC4A090", VA = "0x180C4B690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C71B30", Offset = "0x6C70530", VA = "0x186C71B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JAMGOPLJEPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ulong BAMNCAMGOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public long DBCOMKICJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public double MCHKIOFENBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint KKBGGJADPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint DIECMLCPGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int GOKHNMEIKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int ICLKEGPKNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float DGNHCCHBIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public float JLFMKHFGJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort LLEKKCFFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort HGPCKFFIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort NFHIIIECELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort CGMIDEEKIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short IKOBAIFBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short BMGOKDGIECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public short BFOOMDMBMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short IJEFPBHJDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char NKIADECLHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char LDPLJFMPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public char FJOMDNFPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char NKMOHEOHFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte PCNKBHHDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte AIJFPAIFGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte IIICDCIAKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte GBPAANOEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte KEJOHBAEDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte FONMFFNAEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte CHOJDDCNAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte GOGNEHAFBMC;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static JAMGOPLJEPC MMKGNMBHOIH(long DNHENMMFOGO)
	{
		return default(JAMGOPLJEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C75750", Offset = "0x6C74150", VA = "0x186C75750")]
	public static JAMGOPLJEPC MMKGNMBHOIH(byte LAMHOJOHLIH, byte KCDJFDLOBIE, byte MIPCMLEANHG, byte OPNOGAHABOF, byte JJKKCOJDPBN, byte JGFHJGBHPDI, byte CNJCICFMLEI, byte HAHNOGBCJFI)
	{
		return default(JAMGOPLJEPC);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KKIIDJKBPHI : IEquatable<KKIIDJKBPHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte NLGCIMLFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool GNGCFIJKKGM;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x26738D0", Offset = "0x26722D0", VA = "0x1826738D0")]
	public static KKIIDJKBPHI LCMMJHLCPPM(byte GAEOHFFLMCB)
	{
		return default(KKIIDJKBPHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x26738D0", Offset = "0x26722D0", VA = "0x1826738D0")]
	public static KKIIDJKBPHI FNDKJMGCAJN(bool GEACCNIJNLF)
	{
		return default(KKIIDJKBPHI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6C761C0", Offset = "0x6C74BC0", VA = "0x186C761C0")]
	public static bool LBPOCMFLOBH(KKIIDJKBPHI CGCFANNHAMA, KKIIDJKBPHI GEGAHIEHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A550", Offset = "0x5E08F50", VA = "0x185E0A550", Slot = "4")]
	public bool Equals(KKIIDJKBPHI AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6C76120", Offset = "0x6C74B20", VA = "0x186C76120", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C761B0", Offset = "0x6C74BB0", VA = "0x186C761B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C761D0", Offset = "0x6C74BD0", VA = "0x186C761D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ACNJLGMLBFH<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly T FNMNGGAEJLA;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1C40", Offset = "0x3DC0640", VA = "0x183DC1C40")]
	public ACNJLGMLBFH(T KPHAJKNJNJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BLGFJEAMEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2A28860", Offset = "0x2A27260", VA = "0x182A28860")]
	public static IEnumerable<T> IALLIDGINDO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static T[] EBGHAKAMHOK<T>(params T[] HFKCOBFJPMB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static IEnumerable<T> MMHEPMBAIHP<T>(params T[] HFKCOBFJPMB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static HashSet<T> DKMIHIKCFNC<T>(params T[] HFKCOBFJPMB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2A28890", Offset = "0x2A27290", VA = "0x182A28890")]
	public static KeyValuePair<TKey, TValue> JHOMMEKCOMF<TKey, TValue>([In] TKey JODEIIFHAPK, [In] TValue CLMKDBDPNNH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2A287D0", Offset = "0x2A271D0", VA = "0x182A287D0")]
	public static List<T> AILIJCCFEDP<T>(IEnumerable<T> HLHNGAOBAAJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.All)]
public sealed class PIBEOEAKMEE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly string IEDNHGEOLBK;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
	public PIBEOEAKMEE(string GPOGEIBDPAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public delegate object FDBGKNKPEDC<T>([In] T EBIJIHILGPC);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object OJHKDABKGGM<T>(T EBIJIHILGPC);
[Cpp2IlInjected.Token(Token = "0x200005A")]
[FMAFLCBOODF]
public delegate string PJJFOMDAMMN(string EEOEDIPLNFM, string? DCPDLABEFAK, bool EMEDOKNGKOO);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[FMAFLCBOODF]
public delegate void KACPPJJKJAD(string MEBLNPKEJMN);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FMAFLCBOODF]
public delegate void EOFAOCHGMBL(Exception PBKGKGDHMFI);
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate object KJHIJALJHNP();
[Cpp2IlInjected.Token(Token = "0x200005E")]
[FMAFLCBOODF]
public delegate bool FLFCFELIINI();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FMAFLCBOODF]
public delegate string NEHNPOJKNJM(object GIGIFGONEAO);
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.Enum)]
public class DKONCDJGCPG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
	public DKONCDJGCPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class KOICPAAEEGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MAILEMPKIIN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C773C0", Offset = "0x6C75DC0", VA = "0x186C773C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6C77CB0", Offset = "0x6C766B0", VA = "0x186C77CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly TimerCallback GDKEGONJFPK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Action<object?> PLDNJNICIFB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C76A10", Offset = "0x6C75410", VA = "0x186C76A10")]
	public static Task<bool> CICDGJPDJLK(int NAKFELLAOFA, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76DA0", Offset = "0x6C757A0", VA = "0x186C76DA0")]
	[AsyncStateMachine(typeof(MAILEMPKIIN))]
	private static Task<bool> IKMNHIFBLGF(int NAKFELLAOFA, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C76D10", Offset = "0x6C75710", VA = "0x186C76D10")]
	private static void DHDEBKIDGKB(object? ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C76980", Offset = "0x6C75380", VA = "0x186C76980")]
	private static void BLHLJLOPGAO(object? ACEEMNFHFMB)
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
