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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x61CAD80", Offset = "0x61C9980", VA = "0x1861CAD80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GNCGANKIBPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61C4D50", Offset = "0x61C3950", VA = "0x1861C4D50")]
	public GNCGANKIBPP(bool HOHAJJAHFDM, string BIPBOANNKEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ILMFKMNBPMD<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> GNPPGBGCMDO(CancellationToken EJGJLLMBDIN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FFPIPGIHFPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public ILMFKMNBPMD<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GNPPGBGCMDO taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x3686DE0", Offset = "0x36859E0", VA = "0x183686DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3687E40", Offset = "0x3686A40", VA = "0x183687E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource PMGENMHPOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? FCMPMJNIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? GLBEIGDDPBI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3951790", Offset = "0x3950390", VA = "0x183951790")]
	[AsyncStateMachine(typeof(ILMFKMNBPMD<>.FFPIPGIHFPD))]
	public Task<TResult> OIBHJAEAMDP(GNPPGBGCMDO BHBKDGHCAGA, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3951720", Offset = "0x3950320", VA = "0x183951720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39518D0", Offset = "0x39504D0", VA = "0x1839518D0")]
	public ILMFKMNBPMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PCNFEBGCPGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> ELBPDEOFPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T BLAEOCKJGCA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E16950", Offset = "0x3E15550", VA = "0x183E16950")]
	public PCNFEBGCPGA([In] T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x40FA1B0", Offset = "0x40F8DB0", VA = "0x1840FA1B0", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x40FA550", Offset = "0x40F9150", VA = "0x1840FA550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x40FA920", Offset = "0x40F9520", VA = "0x1840FA920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EPNFFCAIHBD
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61C3BD0", Offset = "0x61C27D0", VA = "0x1861C3BD0")]
	public static void CLOBJHOMLGE(this CancellationTokenSource PMGENMHPOOO, bool BAIMJNEGHKD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IOJLJBFLIFN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
	public IOJLJBFLIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class DNJCBAHKMJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
	public DNJCBAHKMJF(string LOMPJMCMPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IBEABJMKDHD
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2802920", Offset = "0x2801520", VA = "0x182802920")]
	public static AMPCIMGAPEB AMPKAHDIJEK<T>()
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2802B50", Offset = "0x2801750", VA = "0x182802B50")]
	public static AMPCIMGAPEB IDOGDOHFOMG<T>([CallerMemberName] string MPGNMPAPHDB = "") where T : notnull
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28029A0", Offset = "0x28015A0", VA = "0x1828029A0")]
	public static AMPCIMGAPEB AMPKAHDIJEK<T>(this T BGBHFDMLCDN) where T : notnull
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2802C80", Offset = "0x2801880", VA = "0x182802C80")]
	public static AMPCIMGAPEB OFEMOIMNFNJ<T>(this T BGBHFDMLCDN, [CallerMemberName] string MPGNMPAPHDB = "") where T : notnull
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2802BE0", Offset = "0x28017E0", VA = "0x182802BE0")]
	public static AMPCIMGAPEB IDOGDOHFOMG<T>(this T NOLNJDLEMAA, [CallerMemberName] string MPGNMPAPHDB = "") where T : notnull
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61C6300", Offset = "0x61C4F00", VA = "0x1861C6300")]
	public static AMPCIMGAPEB IDOGDOHFOMG(string POCJOPKKHJM, [CallerMemberName] string MPGNMPAPHDB = "")
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61C6260", Offset = "0x61C4E60", VA = "0x1861C6260")]
	public static string AEOLJJOFBEI(this object NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate bool MJMDGKCOPLC();
[Cpp2IlInjected.Token(Token = "0x200000F")]
[IOJLJBFLIFN]
public delegate long MKCOOENPNGP();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MCFOOCOHEHI
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static GBIBNHLKJBE GOJNCJJKJGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GBIBNHLKJBE KBBLEOBIPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61C85C0", Offset = "0x61C71C0", VA = "0x1861C85C0")]
		get
		{
			return default(GBIBNHLKJBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KIDCFOMALKM JKPLIEEBFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61C8610", Offset = "0x61C7210", VA = "0x1861C8610")]
		get
		{
			return default(KIDCFOMALKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static GGMOLELIDOL ELNFBHAOKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x61C8080", Offset = "0x61C6C80", VA = "0x1861C8080")]
		get
		{
			return default(GGMOLELIDOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool BIGNEMDICIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61C8010", Offset = "0x61C6C10", VA = "0x1861C8010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61C80D0", Offset = "0x61C6CD0", VA = "0x1861C80D0")]
	public static void DGNBHPNAICK([In] GBIBNHLKJBE MFPDBMJALGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61C7ED0", Offset = "0x61C6AD0", VA = "0x1861C7ED0")]
	public static void AGKNLPHAFKB(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61C8450", Offset = "0x61C7050", VA = "0x1861C8450")]
	public static void FJAJDELGFHO(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2894650", Offset = "0x2893250", VA = "0x182894650")]
	public static void FJAJDELGFHO<T>(T KPLKBKJIAEI, LCBDEHPBGKG<T> COECLHOAJJF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61C8520", Offset = "0x61C7120", VA = "0x1861C8520")]
	public static void HKCKNEABHLE(Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61C8350", Offset = "0x61C6F50", VA = "0x1861C8350")]
	public static void EBNAMHDMJJJ(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61C8660", Offset = "0x61C7260", VA = "0x1861C8660")]
	public static void PLIIEMPBIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61C7E50", Offset = "0x61C6A50", VA = "0x1861C7E50")]
	public static string AEOLJJOFBEI(object OGGNGHKHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61C7FA0", Offset = "0x61C6BA0", VA = "0x1861C7FA0")]
	public static long ALPBGDKHIEC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61C83B0", Offset = "0x61C6FB0", VA = "0x1861C83B0")]
	public static bool FGNMCDPEGJL(bool HPAFCMIPNAM, string COECLHOAJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61C8280", Offset = "0x61C6E80", VA = "0x1861C8280")]
	public static double DPGOCMMLOGE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GBIBNHLKJBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KIDCFOMALKM JKPLIEEBFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly GGMOLELIDOL ELNFBHAOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly PDBKDKOPBJK AAPDBFOPNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly MKCOOENPNGP KGOBPOLONOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly NMLJCGMACMP NIPEHPHIPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly MJMDGKCOPLC DLILPFKCKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly PDBKDKOPBJK FBMJLIFMLEF;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MKCOOENPNGP DKIMAJEEDBJ;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NMLJCGMACMP MBHLDFGBAMA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly MJMDGKCOPLC OHOHCFHACJH;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly GBIBNHLKJBE ONLHDLNPPFP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PGNAFHIBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61C3D30", Offset = "0x61C2930", VA = "0x1861C3D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61C46D0", Offset = "0x61C32D0", VA = "0x1861C46D0")]
	public GBIBNHLKJBE([In] KIDCFOMALKM MDHMMNLHNOC, [In] GGMOLELIDOL JLINHDPBFPO, PDBKDKOPBJK DEBOEHOIJAK, MKCOOENPNGP ACPDCBNPCEI, NMLJCGMACMP JKBAFMALBEG, MJMDGKCOPLC GPMEBIOEEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61C3CF0", Offset = "0x61C28F0", VA = "0x1861C3CF0")]
	private static string GGFHJNIEJMM(object OGGNGHKHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210")]
	private static long NLHIJDJNHCH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	private static string CKGOCILKOCP(string KCOOFCLDKNM, string? OJMJLFJMBMB, bool DDLLIDADGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	private static bool ILDAFPNAOMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61C3ED0", Offset = "0x61C2AD0", VA = "0x1861C3ED0")]
	private static GBIBNHLKJBE MCLKAJIHGJF()
	{
		return default(GBIBNHLKJBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LEPNOMGDGHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKNLMPBIIPP FLKOPGGPIPE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IKNLMPBIIPP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LPKDIEFPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHKNCEPIEBA();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OCLFAAALHKC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DKKPGNGEHEH([In] T NAFFCAIMPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void GDGANMGKCDN<T>([In] T KPLKBKJIAEI);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct CKBMPHLAGBO<T> : IEquatable<CKBMPHLAGBO<T>>, OCLFAAALHKC<CKBMPHLAGBO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T BLAEOCKJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int KGAKPAMIIIB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C410", Offset = "0x1E0B010", VA = "0x181E0C410")]
	public CKBMPHLAGBO([In] T BLKAHBIJBJO, int PMIDLPOCCEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8160", Offset = "0x4BC6D60", VA = "0x184BC8160")]
	public static bool FKDJFADGJBA([In] CKBMPHLAGBO<T> GDDMOGHGPAF, [In] CKBMPHLAGBO<T> GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x368BEA0", Offset = "0x368AAA0", VA = "0x18368BEA0", Slot = "4")]
	public bool Equals(CKBMPHLAGBO<T> NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3323BD0", Offset = "0x33227D0", VA = "0x183323BD0", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7D50", Offset = "0x4BC6950", VA = "0x184BC7D50")]
	public bool DKKPGNGEHEH([In] CKBMPHLAGBO<T> NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8CF0", Offset = "0x4BC78F0", VA = "0x184BC8CF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BC98B0", Offset = "0x4BC84B0", VA = "0x184BC98B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8540", Offset = "0x4BC7140", VA = "0x184BC8540")]
	public void FPIGJDBABCF([Out] T BLKAHBIJBJO, [Out] int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4BC9190", Offset = "0x4BC7D90", VA = "0x184BC9190")]
	public (T, int) OLBKMLCEEHJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7DE0", Offset = "0x4BC69E0", VA = "0x184BC7DE0", Slot = "5")]
	private bool EPIPOELBMNN([In] CKBMPHLAGBO<T> NAFFCAIMPLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LNKIGDCFOPK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28850E0", Offset = "0x2883CE0", VA = "0x1828850E0")]
	public static CKBMPHLAGBO<T> CIGBOGDFGOD<T>([In] T BLKAHBIJBJO, int PMIDLPOCCEE) where T : notnull
	{
		return default(CKBMPHLAGBO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FKNMPHDKKOE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27C8670", Offset = "0x27C7270", VA = "0x1827C8670")]
	public static bool DKKPGNGEHEH<T, U>([In] T NOLNJDLEMAA, [In] U OGGNGHKHHGI) where T : notnull, OCLFAAALHKC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult ELJDCIBEBAM<T, out TResult>([In] T KPLKBKJIAEI);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OIDPKNKLGAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan IHMOKDKKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? GCCMLDKCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJNOBIEAGDP();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDKBIMIIFKL();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCPOOINKPBO();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct KIDCFOMALKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JIMPFHMJLEI DNPOJNGEBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly MKHJCNDPKJB IBKIPHECGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly JIMPFHMJLEI CFDCKKNJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MKHJCNDPKJB GAOCIBONGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly JIMPFHMJLEI EBFAJGPHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MKHJCNDPKJB MPDJPDALIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly JHKAKGDOMFM FINJAIDDKFO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly JIMPFHMJLEI JEJFMANMDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly MKHJCNDPKJB CEGGJBHMDPL;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly JIMPFHMJLEI DKDMIIIKDCA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MKHJCNDPKJB PIHOKCPKLEO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly JIMPFHMJLEI KPHOPODICJJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MKHJCNDPKJB ONMOODGKNKH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JHKAKGDOMFM GCLLBPGPDNO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly KIDCFOMALKM ONLHDLNPPFP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly JIMPFHMJLEI IJKHDNPJBCG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PGNAFHIBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61C6BF0", Offset = "0x61C57F0", VA = "0x1861C6BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9D7D30", Offset = "0x9D6930", VA = "0x1809D7D30")]
	public KIDCFOMALKM(JIMPFHMJLEI CJEMFLJPOJH, MKHJCNDPKJB MJHKMKJPDIA, JIMPFHMJLEI LDDJAONGJCK, MKHJCNDPKJB LKINPDFMJEM, JIMPFHMJLEI LIPFADHDGJH, MKHJCNDPKJB JDBGCAAPMCA, JHKAKGDOMFM AMBHLJGPEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	private static bool OKAMCBHKFNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void AHOHEFPCCGJ(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	private static bool HEEEFANIAJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void ANHOALPPCBG(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30")]
	private static bool BPEHBAACIIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void DFAIIADIPPH(string COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void MOPFMAHCCLO(Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61C6DF0", Offset = "0x61C59F0", VA = "0x1861C6DF0")]
	private static KIDCFOMALKM MCLKAJIHGJF()
	{
		return default(KIDCFOMALKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20")]
	private static bool KDJELJFNLPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61C6960", Offset = "0x61C5560", VA = "0x1861C6960")]
	public void AGKNLPHAFKB(object COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61C6B80", Offset = "0x61C5780", VA = "0x1861C6B80")]
	public void FJAJDELGFHO(object COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A010C0", Offset = "0x19FFCC0", VA = "0x181A010C0")]
	public void HKCKNEABHLE(Exception BJCOEJJDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61C6AA0", Offset = "0x61C56A0", VA = "0x1861C6AA0")]
	public void FJAJDELGFHO(POHKKEJMHEA COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28587C0", Offset = "0x28573C0", VA = "0x1828587C0")]
	public void FJAJDELGFHO<T>(T KPLKBKJIAEI, LCBDEHPBGKG<T> COECLHOAJJF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2858640", Offset = "0x2857240", VA = "0x182858640")]
	public void AGKNLPHAFKB<T>([In] T KPLKBKJIAEI, LKMPGGJOBMG<T> COECLHOAJJF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61C69D0", Offset = "0x61C55D0", VA = "0x1861C69D0")]
	public bool FGNMCDPEGJL(bool HPAFCMIPNAM, string COECLHOAJJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AMPCIMGAPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string BLAEOCKJGCA;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	public AMPCIMGAPEB(string BLKAHBIJBJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0")]
	public static string PFOIJBDHIHJ([In] AMPCIMGAPEB NOLNJDLEMAA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x14E45E0", Offset = "0x14E31E0", VA = "0x1814E45E0")]
	public static AMPCIMGAPEB PFOIJBDHIHJ(string NAFFCAIMPLI)
	{
		return default(AMPCIMGAPEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61C2520", Offset = "0x61C1120", VA = "0x1861C2520")]
	public string NKPMODDLKGJ(string LPGMAHAMBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61C2440", Offset = "0x61C1040", VA = "0x1861C2440")]
	public string DMENKHDGACE(object LJAIEPDANGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct BABPIFEMKHH : IEquatable<BABPIFEMKHH>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "4")]
	public bool Equals(BABPIFEMKHH NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61C2570", Offset = "0x61C1170", VA = "0x1861C2570", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61C25C0", Offset = "0x61C11C0", VA = "0x1861C25C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x61C25D0", Offset = "0x61C11D0", VA = "0x1861C25D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[ONOAPBNPKCD("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FJLODHFCFCH<T> : IEquatable<FJLODHFCFCH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T BLAEOCKJGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool AAAOOHOMFPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool CCPCMFGMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x368CCF0", Offset = "0x368B8F0", VA = "0x18368CCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x368D140", Offset = "0x368BD40", VA = "0x18368D140")]
	public FJLODHFCFCH([In] T BLKAHBIJBJO, bool HCFAMMFAKGF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x368C840", Offset = "0x368B440", VA = "0x18368C840")]
	public static bool FKDJFADGJBA([In] FJLODHFCFCH<T> GDDMOGHGPAF, [In] FJLODHFCFCH<T> GHPICIIHMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x368BEA0", Offset = "0x368AAA0", VA = "0x18368BEA0", Slot = "4")]
	public bool Equals(FJLODHFCFCH<T> NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x368C1F0", Offset = "0x368ADF0", VA = "0x18368C1F0", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x368CBB0", Offset = "0x368B7B0", VA = "0x18368CBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x368CE80", Offset = "0x368BA80", VA = "0x18368CE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FHKLMIPBDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27C7250", Offset = "0x27C5E50", VA = "0x1827C7250")]
	public static FJLODHFCFCH<T> HONECFAOFFE<T>([In] T BLKAHBIJBJO) where T : notnull
	{
		return default(FJLODHFCFCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27C7390", Offset = "0x27C5F90", VA = "0x1827C7390")]
	public static FJLODHFCFCH<T?> NLCFHNJEFDA<T>()
	{
		return default(FJLODHFCFCH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27C7150", Offset = "0x27C5D50", VA = "0x1827C7150")]
	public static bool GJFPFGKNAOO<T>([In] this FJLODHFCFCH<T> CFGKOGHLGIO, [Out][NotNullWhen(true)] T BLKAHBIJBJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct GGMOLELIDOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr EBNAMHDMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr PLIIEMPBIAH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr NDCBDCAEEEM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr PGEIOCJAGAL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly GGMOLELIDOL ONLHDLNPPFP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PGNAFHIBNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61C4850", Offset = "0x61C3450", VA = "0x1861C4850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x902320", Offset = "0x900F20", VA = "0x180902320")]
	public GGMOLELIDOL(IntPtr HEOLHDOCOIK, IntPtr GDHKDMHMLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void HFJJHPMEOMM(string MPGNMPAPHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	private static void LCCCDFCBKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61C4930", Offset = "0x61C3530", VA = "0x1861C4930")]
	private static GGMOLELIDOL MCLKAJIHGJF()
	{
		return default(GGMOLELIDOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct IEPINACHDLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr KKCEFKJEPLC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x93C290", Offset = "0x93AE90", VA = "0x18093C290")]
	private IEPINACHDLL(IntPtr GDHKDMHMLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x61C6470", Offset = "0x61C5070", VA = "0x1861C6470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61C6380", Offset = "0x61C4F80", VA = "0x1861C6380")]
	public static IEPINACHDLL CIGBOGDFGOD(string MPGNMPAPHDB)
	{
		return default(IEPINACHDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4C30", Offset = "0x1DF3830", VA = "0x181DF4C30")]
	public static IEPINACHDLL CIGBOGDFGOD([In] GGMOLELIDOL JLINHDPBFPO, string MPGNMPAPHDB)
	{
		return default(IEPINACHDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4340", Offset = "0x1DF2F40", VA = "0x181DF4340")]
	public static IEPINACHDLL CIGBOGDFGOD([In] GGMOLELIDOL JLINHDPBFPO, Func<string> MPGNMPAPHDB)
	{
		return default(IEPINACHDLL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MKIPDCCACPI
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool EALMKJCLNCG<in TInput, TResult>(TInput KMJAEAGEOPB, [Out] TResult MGHLKGJFBCD);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private sealed class GDPEECPMFBJ : LEPNOMGDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class PDACOCINCBN : IKNLMPBIIPP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly PDACOCINCBN EJGFFMEDDPG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool LPKDIEFPNFP
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x61CB650", Offset = "0x61CA250", VA = "0x1861CB650", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x61CB6B0", Offset = "0x61CA2B0", VA = "0x1861CB6B0", Slot = "6")]
			public void OnCompleted(Action HHNDKIHPKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			public void NHKNCEPIEBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public PDACOCINCBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly GDPEECPMFBJ EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private GDPEECPMFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61C4780", Offset = "0x61C3380", VA = "0x1861C4780", Slot = "4")]
		public IKNLMPBIIPP FLKOPGGPIPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private sealed class LDKOOBCPNNF : LEPNOMGDGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private sealed class FDDIFOIKDGP : IKNLMPBIIPP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly FDDIFOIKDGP EJGFFMEDDPG;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool LPKDIEFPNFP
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x61C3C00", Offset = "0x61C2800", VA = "0x1861C3C00", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x61C3C20", Offset = "0x61C2820", VA = "0x1861C3C20", Slot = "6")]
			public void OnCompleted(Action HHNDKIHPKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			public void NHKNCEPIEBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public FDDIFOIKDGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly LDKOOBCPNNF EJGFFMEDDPG;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private LDKOOBCPNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x61C7510", Offset = "0x61C6110", VA = "0x1861C7510", Slot = "4")]
		public IKNLMPBIIPP FLKOPGGPIPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FBPHEDFLOLN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FBPHEDFLOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x33045B0", Offset = "0x33031B0", VA = "0x1833045B0")]
		internal void PKPCJCIBGOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JIDEPCOIEJJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JIDEPCOIEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3AFD7F0", Offset = "0x3AFC3F0", VA = "0x183AFD7F0")]
		internal void CFEJFHNDOIC(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct EEIMBIOLHJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C3A70", Offset = "0x61C2670", VA = "0x1861C3A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct AKFLJNDABHA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C1F60", Offset = "0x61C0B60", VA = "0x1861C1F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x892CC0", Offset = "0x8918C0", VA = "0x180892CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PEFDDIMGHLP<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x40FE2D0", Offset = "0x40FCED0", VA = "0x1840FE2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40FE440", Offset = "0x40FD040", VA = "0x1840FE440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CCEDNJJLOCI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4AE29E0", Offset = "0x4AE15E0", VA = "0x184AE29E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2E20", Offset = "0x4AE1A20", VA = "0x184AE2E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DOKBGIFHFKD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C3430", Offset = "0x61C2030", VA = "0x1861C3430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61C3630", Offset = "0x61C2230", VA = "0x1861C3630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class EBIPCLOGNFC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EBIPCLOGNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x33045B0", Offset = "0x33031B0", VA = "0x1833045B0")]
		internal void OKNHMPHDLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3304550", Offset = "0x3303150", VA = "0x183304550")]
		internal void GMMGHIKJDKC(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CHAJEPOBCAC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public EALMKJCLNCG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4370", Offset = "0x4BB2F70", VA = "0x184BB4370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4A60", Offset = "0x4BB3660", VA = "0x184BB4A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct ONPNBCFHHCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61CAE00", Offset = "0x61C9A00", VA = "0x1861CAE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61CB5F0", Offset = "0x61CA1F0", VA = "0x1861CB5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct IBBEOOOPOGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C5CC0", Offset = "0x61C48C0", VA = "0x1861C5CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61C6200", Offset = "0x61C4E00", VA = "0x1861C6200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FAJIODLMIND<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3679600", Offset = "0x3678200", VA = "0x183679600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x367A4F0", Offset = "0x36790F0", VA = "0x18367A4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct ABFGGNCPOLG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3729D90", Offset = "0x3728990", VA = "0x183729D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x372A550", Offset = "0x3729150", VA = "0x18372A550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct CLFGKHMJAKE<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4C930B0", Offset = "0x4C91CB0", VA = "0x184C930B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4C937B0", Offset = "0x4C923B0", VA = "0x184C937B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GLEBKJMEMEN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C4B10", Offset = "0x61C3710", VA = "0x1861C4B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61C4CF0", Offset = "0x61C38F0", VA = "0x1861C4CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct AKKDGANJPHN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C2070", Offset = "0x61C0C70", VA = "0x1861C2070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61C23E0", Offset = "0x61C0FE0", VA = "0x1861C23E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct MHGAKMAICCJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C8780", Offset = "0x61C7380", VA = "0x1861C8780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61C8A70", Offset = "0x61C7670", VA = "0x1861C8A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class IMGGCAGCFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public IMGGCAGCFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x61C68F0", Offset = "0x61C54F0", VA = "0x1861C68F0")]
		internal Task MACDBCABHJC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NGJJAMMMMAH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61CA6B0", Offset = "0x61C92B0", VA = "0x1861CA6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x61CA910", Offset = "0x61C9510", VA = "0x1861CA910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BNNNNBCIAPB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C31F0", Offset = "0x61C1DF0", VA = "0x1861C31F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61C33D0", Offset = "0x61C1FD0", VA = "0x1861C33D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EBHFMKAFLNF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C36A0", Offset = "0x61C22A0", VA = "0x1861C36A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x61C3A10", Offset = "0x61C2610", VA = "0x1861C3A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BKHGMODLDPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C2600", Offset = "0x61C1200", VA = "0x1861C2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61C28F0", Offset = "0x61C14F0", VA = "0x1861C28F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BMKLDBMLHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BMKLDBMLHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61C2950", Offset = "0x61C1550", VA = "0x1861C2950")]
		internal Task DCGHKALGIBK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PDJGOAJPPHO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61CB890", Offset = "0x61CA490", VA = "0x1861CB890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x61CBAF0", Offset = "0x61CA6F0", VA = "0x1861CBAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct POMLOFMDAIB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61CBB50", Offset = "0x61CA750", VA = "0x1861CBB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x61CBCD0", Offset = "0x61CA8D0", VA = "0x1861CBCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HPJGJGNNCDM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x388C310", Offset = "0x388AF10", VA = "0x18388C310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x388C570", Offset = "0x388B170", VA = "0x18388C570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct IKDLJBGCCEI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x61C6480", Offset = "0x61C5080", VA = "0x1861C6480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x61C6890", Offset = "0x61C5490", VA = "0x1861C6890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? FFGGKPFPGBG;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<BABPIFEMKHH> CMLJBONJFDD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task BHFPKFKLKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x61CA110", Offset = "0x61C8D10", VA = "0x1861CA110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61C9030", Offset = "0x61C7C30", VA = "0x1861C9030")]
	public static bool FHHDECPJBGF(this Task BKPEJJIHAHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x28A14B0", Offset = "0x28A00B0", VA = "0x1828A14B0")]
	public static Task<T> EMBBHDKEBPB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61CA200", Offset = "0x61C8E00", VA = "0x1861CA200")]
	public static Task PGKIDFMINBK(this Task BKPEJJIHAHC, CancellationToken DGPOLLDAHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x28A39B0", Offset = "0x28A25B0", VA = "0x1828A39B0")]
	public static Task<TResult> PGKIDFMINBK<TResult>(this Task<TResult> BKPEJJIHAHC, CancellationToken DGPOLLDAHJK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28A44D0", Offset = "0x28A30D0", VA = "0x1828A44D0")]
	public static TaskCompletionSource<TResult> PGKIDFMINBK<TResult>(this TaskCompletionSource<TResult> BCAKEJEFJBJ, CancellationToken DGPOLLDAHJK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61C9B70", Offset = "0x61C8770", VA = "0x1861C9B70")]
	[AsyncStateMachine(typeof(EEIMBIOLHJG))]
	public static void LJEKDIGIFKA(this Task JIGADAOLAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x61C98A0", Offset = "0x61C84A0", VA = "0x1861C98A0")]
	[AsyncStateMachine(typeof(AKFLJNDABHA))]
	public static void JAIAKFFHCCH(this Task JIGADAOLAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x28A1B00", Offset = "0x28A0700", VA = "0x1828A1B00")]
	[AsyncStateMachine(typeof(PEFDDIMGHLP<>))]
	public static Task LDJNDJLHOEI<TException>(this Task JIGADAOLAJF) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28A1940", Offset = "0x28A0540", VA = "0x1828A1940")]
	[AsyncStateMachine(typeof(CCEDNJJLOCI<>))]
	public static Task<T> IODICDKPKOD<T>(this Task<T> NOLNJDLEMAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x61C9A80", Offset = "0x61C8680", VA = "0x1861C9A80")]
	[AsyncStateMachine(typeof(DOKBGIFHFKD))]
	public static Task<TaskStatus> KCLMBHHMPFN(this Task NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28A1600", Offset = "0x28A0200", VA = "0x1828A1600")]
	public static (Task<T?>?, Action<T?>?) FMKCNOPFOGG<T>([Optional] CancellationToken EJGJLLMBDIN)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28A1840", Offset = "0x28A0440", VA = "0x1828A1840")]
	[AsyncStateMachine(typeof(CHAJEPOBCAC<, >))]
	public static Task<List<TResult>> IJJJGNIPFJF<TResult, TInput>(this Task<List<TInput>> BKPEJJIHAHC, EALMKJCLNCG<TInput, TResult> FFFJAJHKAOI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61C9950", Offset = "0x61C8550", VA = "0x1861C9950")]
	[AsyncStateMachine(typeof(ONPNBCFHHCD))]
	public static Task JIEDOEDAEOJ(Task JIGADAOLAJF, CancellationToken NFEFCAGIEPH, Func<CancellationToken, Task> GJFOLFLIDOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61C8D40", Offset = "0x61C7940", VA = "0x1861C8D40")]
	[AsyncStateMachine(typeof(IBBEOOOPOGH))]
	public static Task BOKCOJJLJNI(Func<CancellationToken, Task> FEHDNOGINLN, TimeSpan IAJJLFLHIDC, [Optional] CancellationToken NFEFCAGIEPH, [Optional] Action<OperationCanceledException>? FIEENHJDDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28A1290", Offset = "0x289FE90", VA = "0x1828A1290")]
	[AsyncStateMachine(typeof(FAJIODLMIND<>))]
	public static Task<T> BOKCOJJLJNI<T>(Func<CancellationToken, Task<T>> FEHDNOGINLN, TimeSpan IAJJLFLHIDC, [Optional] CancellationToken NFEFCAGIEPH, [Optional] Func<OperationCanceledException, T>? FIEENHJDDFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x28A1080", Offset = "0x289FC80", VA = "0x1828A1080")]
	[AsyncStateMachine(typeof(ABFGGNCPOLG<>))]
	public static Task<IEnumerable<Task<T>>> BIICGONKEJO<T>(IEnumerable<Task<T>> FEDFDLBOJNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x28A1BD0", Offset = "0x28A07D0", VA = "0x1828A1BD0")]
	[AsyncStateMachine(typeof(CLFGKHMJAKE<, , , >))]
	public static Task<(T1, T2, T3, T4)> PBNCJOHFBBE<T1, T2, T3, T4>(Task<T1> IGCMODALAGK, Task<T2> DGJOFDKKEGG, Task<T3> PLBNJDBANPD, Task<T4> BENFIMNAONB) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61C9D30", Offset = "0x61C8930", VA = "0x1861C9D30")]
	[AsyncStateMachine(typeof(GLEBKJMEMEN))]
	public static Task MLBNCKDMIHO(Func<bool> HPAFCMIPNAM, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x61C9C20", Offset = "0x61C8820", VA = "0x1861C9C20")]
	[AsyncStateMachine(typeof(AKKDGANJPHN))]
	public static Task MLBNCKDMIHO(Func<bool> HPAFCMIPNAM, TimeSpan JKFBENEGLOC, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61C9630", Offset = "0x61C8230", VA = "0x1861C9630")]
	[AsyncStateMachine(typeof(MHGAKMAICCJ))]
	public static Task IFBOFDLELEH(Func<bool> HPAFCMIPNAM, TimeSpan IAJJLFLHIDC, [Optional] CancellationToken EJGJLLMBDIN, [Optional] Action<OperationCanceledException>? FIEENHJDDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x61C9760", Offset = "0x61C8360", VA = "0x1861C9760")]
	[AsyncStateMachine(typeof(NGJJAMMMMAH))]
	public static Task IFBOFDLELEH(Func<bool> HPAFCMIPNAM, TimeSpan IAJJLFLHIDC, TimeSpan JKFBENEGLOC, [Optional] CancellationToken EJGJLLMBDIN, [Optional] Action<OperationCanceledException>? FIEENHJDDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61C91C0", Offset = "0x61C7DC0", VA = "0x1861C91C0")]
	[AsyncStateMachine(typeof(BNNNNBCIAPB))]
	public static Task GHFCLGIEPJE(Func<bool> HPAFCMIPNAM, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x61C90B0", Offset = "0x61C7CB0", VA = "0x1861C90B0")]
	[AsyncStateMachine(typeof(EBHFMKAFLNF))]
	public static Task GHFCLGIEPJE(Func<bool> HPAFCMIPNAM, TimeSpan JKFBENEGLOC, [Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61C8AD0", Offset = "0x61C76D0", VA = "0x1861C8AD0")]
	[AsyncStateMachine(typeof(BKHGMODLDPO))]
	public static Task ADLOIAPJOCI(Func<bool> HPAFCMIPNAM, TimeSpan IAJJLFLHIDC, [Optional] CancellationToken EJGJLLMBDIN, [Optional] Action<OperationCanceledException>? FIEENHJDDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61C8C00", Offset = "0x61C7800", VA = "0x1861C8C00")]
	[AsyncStateMachine(typeof(PDJGOAJPPHO))]
	public static Task ADLOIAPJOCI(Func<bool> HPAFCMIPNAM, TimeSpan IAJJLFLHIDC, TimeSpan JKFBENEGLOC, [Optional] CancellationToken EJGJLLMBDIN, [Optional] Action<OperationCanceledException>? FIEENHJDDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x61C8F40", Offset = "0x61C7B40", VA = "0x1861C8F40")]
	[Obsolete]
	[AsyncStateMachine(typeof(POMLOFMDAIB))]
	public static Task DOMPAPNOBEB(this Task BKPEJJIHAHC, Action PNHBGEGGGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x28A13C0", Offset = "0x289FFC0", VA = "0x1828A13C0")]
	[Obsolete]
	[AsyncStateMachine(typeof(HPJGJGNNCDM<>))]
	public static Task DOMPAPNOBEB<T>(this Task<T> BKPEJJIHAHC, Action<T> PNHBGEGGGND) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61C9F40", Offset = "0x61C8B40", VA = "0x1861C9F40")]
	private static void NLHKOJMJKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61C92B0", Offset = "0x61C7EB0", VA = "0x1861C92B0")]
	public static bool IECIANAHDLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61CA460", Offset = "0x61C9060", VA = "0x1861CA460")]
	private static void PIOBPOKAAGI(SynchronizationContext BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61C9FF0", Offset = "0x61C8BF0", VA = "0x1861C9FF0")]
	private static void OFDKKENCKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61C8E70", Offset = "0x61C7A70", VA = "0x1861C8E70")]
	public static void DMKIDAFKKGM([Optional] string? COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61CA180", Offset = "0x61C8D80", VA = "0x1861CA180")]
	public static void PDHCNMAJMJL([Optional] string? COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x61C9060", Offset = "0x61C7C60", VA = "0x1861C9060")]
	public static LEPNOMGDGHJ FPPPPCDBFLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61C9E20", Offset = "0x61C8A20", VA = "0x1861C9E20")]
	public static LEPNOMGDGHJ MNJDBJHJABL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61C9E70", Offset = "0x61C8A70", VA = "0x1861C9E70")]
	[AsyncStateMachine(typeof(IKDLJBGCCEI))]
	public static Task NDLAJAJGAOO(Func<Task> HMNHGLIGALO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class JHPFJEFPNKG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
	public JHPFJEFPNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class MAKNFBOAPAO : IKBLBFDJDPI
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly IKBLBFDJDPI EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime MDIOECGNKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x61C7D90", Offset = "0x61C6990", VA = "0x1861C7D90", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset NDBKKBDKEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61C7D30", Offset = "0x61C6930", VA = "0x1861C7D30", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public MAKNFBOAPAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface IKBLBFDJDPI
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime MDIOECGNKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset NDBKKBDKEFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BNLBGCGEGDK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long PIBAOKGCONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61C2E80", Offset = "0x61C1A80", VA = "0x1861C2E80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long ODCDLIAGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61C2E30", Offset = "0x61C1A30", VA = "0x1861C2E30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double AMGNLKEAEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x61C2B00", Offset = "0x61C1700", VA = "0x1861C2B00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double BLMKOKPCJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61C2ED0", Offset = "0x61C1AD0", VA = "0x1861C2ED0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double EIJNPMNKNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x61C2A20", Offset = "0x61C1620", VA = "0x1861C2A20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double LFLLAAGGCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x61C2C70", Offset = "0x61C1870", VA = "0x1861C2C70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61C2B50", Offset = "0x61C1750", VA = "0x1861C2B50")]
	public static double HBAJNLJIKCI(long GDOJPJPEFMI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61C2BE0", Offset = "0x61C17E0", VA = "0x1861C2BE0")]
	public static double HKFILMLNBHO(long GDOJPJPEFMI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61C2CC0", Offset = "0x61C18C0", VA = "0x1861C2CC0")]
	public static double IIJHPDDKFPI(double EJELKNHNKPA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x61C2A70", Offset = "0x61C1670", VA = "0x1861C2A70")]
	public static long DFDEPLDDLKB(long OPCGAFBMLPL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x61C2E20", Offset = "0x61C1A20", VA = "0x1861C2E20")]
	public static long LNOCLOFAHKA(long GCEJKDILAOB, long GMNNNJMJIFH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61C2D50", Offset = "0x61C1950", VA = "0x1861C2D50")]
	public static double JGIANHENCEF(long GCEJKDILAOB, long GMNNNJMJIFH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x61C29C0", Offset = "0x61C15C0", VA = "0x1861C29C0")]
	public static double COAANBAJAKF(long GCEJKDILAOB, long GMNNNJMJIFH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class LICMNHFMCHD : OIDPKNKLGAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan FOBAOJIPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer KAMOOCNEONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan IAJJLFLHIDC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan IHMOKDKKDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61C78A0", Offset = "0x61C64A0", VA = "0x1861C78A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? GCCMLDKCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61C7CC0", Offset = "0x61C68C0", VA = "0x1861C7CC0")]
	[Preserve]
	public LICMNHFMCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x61C7A70", Offset = "0x61C6670", VA = "0x1861C7A70")]
	public LICMNHFMCHD(TimeSpan IAJJLFLHIDC, [Optional] Action? OIDHFJHKCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x61C7810", Offset = "0x61C6410", VA = "0x1861C7810", Slot = "7")]
	public void GJNOBIEAGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61C77A0", Offset = "0x61C63A0", VA = "0x1861C77A0", Slot = "8")]
	public void EDKBIMIIFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61C76D0", Offset = "0x61C62D0", VA = "0x1861C76D0", Slot = "9")]
	public void DCPOOINKPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xC390F0", Offset = "0xC37CF0", VA = "0x180C390F0")]
	private void NOONLCIPCAE(object BGBHFDMLCDN, ElapsedEventArgs NCDGFBNIDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x61C7630", Offset = "0x61C6230", VA = "0x1861C7630")]
	private static void BOPEAEFGKPP(TimeSpan CBCKAEBCKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x61C7700", Offset = "0x61C6300", VA = "0x1861C7700", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ONOAPBNPKCD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string OGFDOLMKKPE;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
	public ONOAPBNPKCD(string PCPJCEHFFMB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct HBBAOMAOFJK : IEquatable<HBBAOMAOFJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public uint BAGOENKPPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int OFGPFLMEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float JCCAAFAPMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public ushort KLDNHFDPFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort ICOACMBNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public short LMKGDJKPNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short LFLFLKDPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public char NFPGJDLKMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char CKKAIAHDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public byte FGOGEMDNMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte KAKAEKLGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte HHFAAOAPMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte BPIDHELHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public bool JHFOBKJKMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool HOHNIOFHNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool GHNLIMEHLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool IBMGOILKPHC;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xD8C510", Offset = "0xD8B110", VA = "0x180D8C510")]
	public static HBBAOMAOFJK CHHDNOIKJHG(uint MMPPHDPECJH)
	{
		return default(HBBAOMAOFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xD8C510", Offset = "0xD8B110", VA = "0x180D8C510")]
	public static HBBAOMAOFJK LMNBJLIKKLD(int JICDBFLPOOJ)
	{
		return default(HBBAOMAOFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x61C4EC0", Offset = "0x61C3AC0", VA = "0x1861C4EC0")]
	public static HBBAOMAOFJK NEILJBPLMBM(float BFLKNBINKGG)
	{
		return default(HBBAOMAOFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x61C4EA0", Offset = "0x61C3AA0", VA = "0x1861C4EA0")]
	public static HBBAOMAOFJK PGKOALAMLCA(byte IIGJAFHJMNN, byte GHCJCEFOHCP, byte FCAJIFDGHCP, byte KEFGGCGODIC)
	{
		return default(HBBAOMAOFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x61C4EA0", Offset = "0x61C3AA0", VA = "0x1861C4EA0")]
	public static HBBAOMAOFJK MIHFLOFJCDB(bool PEKHJPPOHLP, bool MHJLHMDLMAK, bool BGMHJAEMPGP, bool DECHABMINCK)
	{
		return default(HBBAOMAOFJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x61C4EA0", Offset = "0x61C3AA0", VA = "0x1861C4EA0")]
	public static HBBAOMAOFJK JMIFFDJGANK(byte MLCJPDLJGBI, byte KBINNGPNFLP, byte LJDLLMKIKCE, byte NJIBOBLNCBM)
	{
		return default(HBBAOMAOFJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1855B40", Offset = "0x1854740", VA = "0x181855B40")]
	public static bool FKDJFADGJBA(HBBAOMAOFJK AHIHMLDOCPC, HBBAOMAOFJK APNBCADOPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x88AD80", Offset = "0x889980", VA = "0x18088AD80", Slot = "4")]
	public bool Equals(HBBAOMAOFJK NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x61C4E20", Offset = "0x61C3A20", VA = "0x1861C4E20", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x93DDF0", Offset = "0x93C9F0", VA = "0x18093DDF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x61C4ED0", Offset = "0x61C3AD0", VA = "0x1861C4ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LIAIJNDAGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public ulong IPJAHJDDFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public long PIEMNGOADME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public double HPLLAMNFDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint JCIDPKPPGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint GGJEEOKIFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public int FIEJLBCDJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int CHBBKOKMIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public float AJBLBDHPLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float FCMCAKECAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public ushort KLDNHFDPFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort ICOACMBNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort LOPPOGFAJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort LGFMFOMLCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short LMKGDJKPNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short LFLFLKDPPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short FODKANMOHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short KBKFPAOFJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char NFPGJDLKMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char CKKAIAHDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char OHAECALANCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char NOLOFKJDNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte FGOGEMDNMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte KAKAEKLGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte HHFAAOAPMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte BPIDHELHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte AFNADIPPLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BCNIHFHJLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NPDLGMNPBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte BPJDNBALJBF;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x61C75E0", Offset = "0x61C61E0", VA = "0x1861C75E0")]
	public static LIAIJNDAGAE CIGBOGDFGOD(byte IIGJAFHJMNN, byte GHCJCEFOHCP, byte FCAJIFDGHCP, byte KEFGGCGODIC, byte JCHNNCBCFNB, byte DKINHGIKDDG, byte NHKAGMJOMKM, byte IOBHHPDPBGK)
	{
		return default(LIAIJNDAGAE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct NHDABFOJFEF : IEquatable<NHDABFOJFEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte JMGNLDHODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool IKEMLHONGDA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x22D9350", Offset = "0x22D7F50", VA = "0x1822D9350")]
	public static NHDABFOJFEF PGKOALAMLCA(byte JDCAKIHEAII)
	{
		return default(NHDABFOJFEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x22D9350", Offset = "0x22D7F50", VA = "0x1822D9350")]
	public static NHDABFOJFEF MIHFLOFJCDB(bool OHAAHLICAHJ)
	{
		return default(NHDABFOJFEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x61CAA00", Offset = "0x61C9600", VA = "0x1861CAA00")]
	public static bool FKDJFADGJBA(NHDABFOJFEF AHIHMLDOCPC, NHDABFOJFEF APNBCADOPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x541CD60", Offset = "0x541B960", VA = "0x18541CD60", Slot = "4")]
	public bool Equals(NHDABFOJFEF NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x61CA970", Offset = "0x61C9570", VA = "0x1861CA970", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x61CAA10", Offset = "0x61C9610", VA = "0x1861CAA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x61CAA20", Offset = "0x61C9620", VA = "0x1861CAA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AOGBFHCMIHO<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly T OIKHCMKDMJN;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x38E5F50", Offset = "0x38E4B50", VA = "0x1838E5F50")]
	public AOGBFHCMIHO(T FMHKHAAAFDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DLKOHMBLAFI
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2673200", Offset = "0x2671E00", VA = "0x182673200")]
	public static AOGBFHCMIHO<T> CIGBOGDFGOD<T>(T FMHKHAAAFDE) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class EKECNKNNHMM
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2690ED0", Offset = "0x268FAD0", VA = "0x182690ED0")]
	public static IEnumerable<T> DCKAIMLJEDK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static T[] CFPGEAEOBJF<T>(params T[] ANDPFHGKGBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static IEnumerable<T> AADLFCAOMLN<T>(params T[] ANDPFHGKGBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60")]
	public static HashSet<T> CHCAELFFHHB<T>(params T[] ANDPFHGKGBH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2690EF0", Offset = "0x268FAF0", VA = "0x182690EF0")]
	public static KeyValuePair<TKey, TValue> MGPBHCLOEDD<TKey, TValue>([In] TKey CGGNJKGENIH, [In] TValue BLKAHBIJBJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60")]
	public static List<T> JGMGDPPLAEL<T>(IEnumerable<T> MDLHOCLDHIN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[AttributeUsage(AttributeTargets.All)]
public sealed class DLMFKMJFFCO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly string LGHDLLHCDDH;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
	public DLMFKMJFFCO(string MCJHMJKLMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public delegate object LKMPGGJOBMG<T>([In] T PELDJLKMCIK);
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object LCBDEHPBGKG<T>(T PELDJLKMCIK);
[Cpp2IlInjected.Token(Token = "0x2000056")]
[IOJLJBFLIFN]
public delegate string NMLJCGMACMP(string KCOOFCLDKNM, string? OJMJLFJMBMB, bool DDLLIDADGPO);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[IOJLJBFLIFN]
public delegate void MKHJCNDPKJB(string COECLHOAJJF);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[IOJLJBFLIFN]
public delegate void JHKAKGDOMFM(Exception BJCOEJJDGCE);
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object POHKKEJMHEA();
[Cpp2IlInjected.Token(Token = "0x200005A")]
[IOJLJBFLIFN]
public delegate bool JIMPFHMJLEI();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[IOJLJBFLIFN]
public delegate string PDBKDKOPBJK(object OGGNGHKHHGI);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[AttributeUsage(AttributeTargets.Enum)]
public class GPGNIPIPPKK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
	public GPGNIPIPPKK()
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
