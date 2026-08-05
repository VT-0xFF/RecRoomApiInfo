using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x865DFC0", Offset = "0x865C9C0", VA = "0x18865DFC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PMGDKFHFMHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x865F700", Offset = "0x865E100", VA = "0x18865F700")]
	public static string PBDJEFHBIMG(this Encoding AJGMJHLEPGJ, [In] ReadOnlySequence<byte> BNICMFHPCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F86C90", Offset = "0x3F85690", VA = "0x183F86C90")]
	private static void BNEDAODOLFG<T>(this ReadOnlySequence<T> DFJFBOBNOAP, [Out] ReadOnlySpan<T> KBMEBLOLFIC, [Out] SequencePosition LGLNBNPEKLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class IPNJLMDCLGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8658700", Offset = "0x8657100", VA = "0x188658700")]
	public IPNJLMDCLGA(bool PDJHJOGMBGP, string ADNGIBKCPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86586B0", Offset = "0x86570B0", VA = "0x1886586B0")]
	public IPNJLMDCLGA(bool PDJHJOGMBGP, params string[] OMNOEGJGGPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MDIOMINGJFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NEBIMNOOGFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ODCGEAIFENO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKHCCBNLIIJ(string HPFHOBCPNEF, double KMAFNKGMDCF, [Optional] string? DBDGEJAOHIG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CLAMFLBPKCJ : JJJFBIIDCEG, PJOPEJFCOFN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int IBEFFDNMKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> JJHNHKBBHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double EPMJNJEPCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double JOEBEKPOHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double PPGBJJMNFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int FBPEAFBBLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double DJDLLCOLKKI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BPGEEHEFLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double JFEKLDOBIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8653A80", Offset = "0x8652480", VA = "0x188653A80", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EJHPBNFICNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D10", Offset = "0x2A98710", VA = "0x182A99D10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KPLCDKLIEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AC59F0", Offset = "0x2AC43F0", VA = "0x182AC59F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8653D80", Offset = "0x8652780", VA = "0x188653D80")]
	public CLAMFLBPKCJ(int MCFNAPPFGGA, double DJDLLCOLKKI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8653BE0", Offset = "0x86525E0", VA = "0x188653BE0", Slot = "7")]
	public void JLGHEMFOPIE(double MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8653D10", Offset = "0x8652710", VA = "0x188653D10", Slot = "8")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8653AE0", Offset = "0x86524E0", VA = "0x188653AE0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MBGNLLAPMCF : JJJFBIIDCEG, PJOPEJFCOFN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long MHMCOJIKNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double KLPAFMNGMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double ELEABABOPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double JIJKGAIJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double NPDNNJNGCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double EPMJNJEPCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double JOEBEKPOHKM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EJHPBNFICNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7808C90", Offset = "0x7807690", VA = "0x187808C90", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double KPLCDKLIEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78087C0", Offset = "0x78071C0", VA = "0x1878087C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FJOOIMLGIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7808790", Offset = "0x7807190", VA = "0x187808790")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JFEKLDOBIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D20", Offset = "0x2A98720", VA = "0x182A99D20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x865CFD0", Offset = "0x865B9D0", VA = "0x18865CFD0", Slot = "10")]
	public virtual void JLGHEMFOPIE(double MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x865D0F0", Offset = "0x865BAF0", VA = "0x18865D0F0", Slot = "11")]
	public virtual void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x865CF60", Offset = "0x865B960", VA = "0x18865CF60", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8658680", Offset = "0x8657080", VA = "0x188658680")]
	public MBGNLLAPMCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IHLCDOCLDEG : MBGNLLAPMCF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double DENDMKFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7808C80", Offset = "0x7807680", VA = "0x187808C80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78087B0", Offset = "0x78071B0", VA = "0x1878087B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8658510", Offset = "0x8656F10", VA = "0x188658510", Slot = "10")]
	public override void JLGHEMFOPIE(double MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8658640", Offset = "0x8657040", VA = "0x188658640", Slot = "11")]
	public override void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8658680", Offset = "0x8657080", VA = "0x188658680")]
	public IHLCDOCLDEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJJFBIIDCEG : PJOPEJFCOFN, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double JFEKLDOBIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double EJHPBNFICNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double KPLCDKLIEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MMJEHJOFJBN : PJOPEJFCOFN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double PGNEPABAFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double DMMLBFBKOIA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x865D130", Offset = "0x865BB30", VA = "0x18865D130")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7241870", Offset = "0x7240270", VA = "0x187241870", Slot = "4")]
	public void JLGHEMFOPIE(double MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x865D190", Offset = "0x865BB90", VA = "0x18865D190", Slot = "5")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x865D140", Offset = "0x865BB40", VA = "0x18865D140", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public MMJEHJOFJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PJOPEJFCOFN : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLGHEMFOPIE(double MKDEBCJNKCE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPPCJNEPLIK();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HGBMPDGBHDC : PJOPEJFCOFN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double KMAFNKGMDCF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x125F280", Offset = "0x125DC80", VA = "0x18125F280")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5A2C330", Offset = "0x5A2AD30", VA = "0x185A2C330", Slot = "4")]
	public void JLGHEMFOPIE(double MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8658480", Offset = "0x8656E80", VA = "0x188658480", Slot = "5")]
	public void NPPCJNEPLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8658430", Offset = "0x8656E30", VA = "0x188658430", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HGBMPDGBHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MFBCOHIBPCO<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> FMBDOPNLJDH(CancellationToken AHOMALKMHKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OHHHGPNGEMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MFBCOHIBPCO<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FMBDOPNLJDH taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BADE10", Offset = "0x5BAC810", VA = "0x185BADE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BAEE50", Offset = "0x5BAD850", VA = "0x185BAEE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource CFDOKKENJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? OLICGAABNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? BNGBMOPBFJC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5941C60", Offset = "0x5940660", VA = "0x185941C60")]
	[AsyncStateMachine(typeof(MFBCOHIBPCO<>.OHHHGPNGEMO))]
	public Task<TResult> AGIIIGLEIBK(FMBDOPNLJDH CLAMIFAODHG, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5941DA0", Offset = "0x59407A0", VA = "0x185941DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5941E10", Offset = "0x5940810", VA = "0x185941E10")]
	public MFBCOHIBPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CCMPEOCEEBP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> PNGHNHHMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T AFPBILBCKEL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB1F0", Offset = "0x4AF9BF0", VA = "0x184AFB1F0")]
	public CCMPEOCEEBP([In] T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C01250", Offset = "0x6BFFC50", VA = "0x186C01250", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C01A80", Offset = "0x6C00480", VA = "0x186C01A80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C020E0", Offset = "0x6C00AE0", VA = "0x186C020E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OBKPNCMGDGP
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static CCMPEOCEEBP<T> KDBDJPAJKDJ<T>([In] T KMAFNKGMDCF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DKHGBEGPOLM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8654820", Offset = "0x8653220", VA = "0x188654820")]
	public static void FBBCKHIFBNI(this CancellationTokenSource CFDOKKENJBP, bool LMHCKHNJJJL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class KDJLEIMOPNO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public KDJLEIMOPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class IDEKGIENJJD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public IDEKGIENJJD(string BHJIDPGGJJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OPMHJLMDIFH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F5CAE0", Offset = "0x3F5B4E0", VA = "0x183F5CAE0")]
	public static NDPBDHPILEI NDCOLDNIOKJ<T>()
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x865F100", Offset = "0x865DB00", VA = "0x18865F100")]
	public static NDPBDHPILEI IFLCPPCHPGE([CallerMemberName] string IELIBBNCJAC = "")
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F5C8B0", Offset = "0x3F5B2B0", VA = "0x183F5C8B0")]
	public static NDPBDHPILEI EEBJIJMFGIF<T>([CallerMemberName] string IELIBBNCJAC = "") where T : notnull
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F5CB60", Offset = "0x3F5B560", VA = "0x183F5CB60")]
	public static NDPBDHPILEI NDCOLDNIOKJ<T>(this T HBELCFIJGKE) where T : notnull
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F5C940", Offset = "0x3F5B340", VA = "0x183F5C940")]
	public static NDPBDHPILEI EEBJIJMFGIF<T>(this T DKGBCFDLMOI, [CallerMemberName] string IELIBBNCJAC = "") where T : notnull
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x865EFE0", Offset = "0x865D9E0", VA = "0x18865EFE0")]
	public static NDPBDHPILEI EEBJIJMFGIF(string KKKDDBAJGJL, [CallerMemberName] string IELIBBNCJAC = "")
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x865F060", Offset = "0x865DA60", VA = "0x18865F060")]
	public static string GDHKOMNONJO(this object DKGBCFDLMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool KDCDMDHFFEP();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KDJLEIMOPNO]
public delegate long IDBJKDAKINE();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IABHGFFKEIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IABHGFFKEIJ FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IABHGFFKEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FCEJCLANIJD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static FFPEJOCHFGN JCKHFJLGAAC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FFPEJOCHFGN MGDPBLHIOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8655B80", Offset = "0x8654580", VA = "0x188655B80")]
		get
		{
			return default(FFPEJOCHFGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NLGCGKDKPPP NEBCBECKKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8655A00", Offset = "0x8654400", VA = "0x188655A00")]
		get
		{
			return default(NLGCGKDKPPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static CBKNPHFFHDI JMIKMMGKHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8655AD0", Offset = "0x86544D0", VA = "0x188655AD0")]
		get
		{
			return default(CBKNPHFFHDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool GJMIBOELIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86558C0", Offset = "0x86542C0", VA = "0x1886558C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8655710", Offset = "0x8654110", VA = "0x188655710")]
	public static void AGACLJEDFED([In] FFPEJOCHFGN OOFNIIEMNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8655C40", Offset = "0x8654640", VA = "0x188655C40")]
	public static void JAPFEIFECJM(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8655D70", Offset = "0x8654770", VA = "0x188655D70")]
	public static void KCFDIHIJGKF(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3D682A0", Offset = "0x3D66CA0", VA = "0x183D682A0")]
	public static void KCFDIHIJGKF<T>(T MFHBGCBJCJO, KLONFCPMABD<T> JEBOHIALEMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8655EE0", Offset = "0x86548E0", VA = "0x188655EE0")]
	public static void PCCOFEDAEJF(Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8655B20", Offset = "0x8654520", VA = "0x188655B20")]
	public static void HCHCJJNABJE(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8655D10", Offset = "0x8654710", VA = "0x188655D10")]
	public static void JNFFHIJDKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8655A50", Offset = "0x8654450", VA = "0x188655A50")]
	public static string GDHKOMNONJO(object PMNHIPACJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8655BD0", Offset = "0x86545D0", VA = "0x188655BD0")]
	public static long IHMAMBFLDFP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8655E40", Offset = "0x8654840", VA = "0x188655E40")]
	public static bool KOAGOKFONIH(bool HPFDJAAAMGI, string JEBOHIALEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8655930", Offset = "0x8654330", VA = "0x188655930")]
	public static double DAEPBEFMEFI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FFPEJOCHFGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly NLGCGKDKPPP NEBCBECKKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly CBKNPHFFHDI JMIKMMGKHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly OPPLENNIGGL OCLIJDIEODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly IDBJKDAKINE NNHMMPBFINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly OFJACPDCNLE JANIGKIJGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly KDCDMDHFFEP HAKCJGOAKBF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly OPPLENNIGGL EBILHCMJAHF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IDBJKDAKINE JFKHKOFBDLA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly OFJACPDCNLE ELDPHKJFPEO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KDCDMDHFFEP OGEPLBINKPH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly FFPEJOCHFGN BENGIKOEPPE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8656040", Offset = "0x8654A40", VA = "0x188656040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8656A20", Offset = "0x8655420", VA = "0x188656A20")]
	public FFPEJOCHFGN([In] NLGCGKDKPPP OJANKHAOPGG, [In] CBKNPHFFHDI KJAMPAGNLKK, OPPLENNIGGL AHBMFKDNFLI, IDBJKDAKINE MKIACBHNEEN, OFJACPDCNLE EIECIOEGHAD, KDCDMDHFFEP FGINIIGEPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86561E0", Offset = "0x8654BE0", VA = "0x1886561E0")]
	private static string COJHLDKHFIJ(object PMNHIPACJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	private static long GHPFLJAAENB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	private static string CLPJHMFEIDA(string KKIOLBHBACC, string? LGDIEGLPFLO, bool DLBHJBGIPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	private static bool PNPMDBDMLBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8656220", Offset = "0x8654C20", VA = "0x188656220")]
	private static FFPEJOCHFGN HKBEGBPMHPI()
	{
		return default(FFPEJOCHFGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NIAKHEFJGNG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJJGGOHCEIF CHDCJGNKGCK();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MJJGGOHCEIF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FICMBNIAFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHCLDIMMOIM();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IIHDAIFMJNA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MENPHCFDABP([In] T GOCNHGEHNFD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void LNKIPDBHOHH<T>([In] T MFHBGCBJCJO);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct GOOPDMLHGAA<T> : IEquatable<GOOPDMLHGAA<T>>, IIHDAIFMJNA<GOOPDMLHGAA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T AFPBILBCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int CIDCBGPMNFL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x312D080", Offset = "0x312BA80", VA = "0x18312D080")]
	public GOOPDMLHGAA([In] T KMAFNKGMDCF, int KABGMIEBEFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5159620", Offset = "0x5158020", VA = "0x185159620")]
	public static bool NOPNAEDOCOI([In] GOOPDMLHGAA<T> IIIICGAEODJ, [In] GOOPDMLHGAA<T> ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5158FC0", Offset = "0x51579C0", VA = "0x185158FC0", Slot = "4")]
	public bool Equals(GOOPDMLHGAA<T> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x45D2450", Offset = "0x45D0E50", VA = "0x1845D2450", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51592E0", Offset = "0x5157CE0", VA = "0x1851592E0")]
	public bool MENPHCFDABP([In] GOOPDMLHGAA<T> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5159120", Offset = "0x5157B20", VA = "0x185159120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5159C70", Offset = "0x5158670", VA = "0x185159C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5159BD0", Offset = "0x51585D0", VA = "0x185159BD0")]
	public void ODNAGOAKDMJ([Out] T KMAFNKGMDCF, [Out] int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51597E0", Offset = "0x51581E0", VA = "0x1851597E0")]
	public (T, int) ODBKGHDGNOM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5159040", Offset = "0x5157A40", VA = "0x185159040", Slot = "5")]
	private bool GINGKEDFJEO([In] GOOPDMLHGAA<T> GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class AMDLLMCJGCO
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x32DBC80", Offset = "0x32DA680", VA = "0x1832DBC80")]
	public static GOOPDMLHGAA<T> KDBDJPAJKDJ<T>([In] T KMAFNKGMDCF, int KABGMIEBEFC) where T : notnull
	{
		return default(GOOPDMLHGAA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MBGHEBKCJJF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E87630", Offset = "0x3E86030", VA = "0x183E87630")]
	public static bool MENPHCFDABP<T, U>([In] T DKGBCFDLMOI, [In] U PMNHIPACJLN) where T : notnull, IIHDAIFMJNA<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult KKKPCGOJLNC<T, out TResult>([In] T MFHBGCBJCJO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KNPAKHMHOAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan HKPLMNEEAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? MPKCFHDJDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLFALCCJJDG();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBMOBGIJHHB();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECGOBBCGDJE();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct NLGCGKDKPPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DFCCNAICMBJ EGNJNOGJLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly KAFKEBICBKM OBFACIHCEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DFCCNAICMBJ LENMPBANDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KAFKEBICBKM HBFGDCMDCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly DFCCNAICMBJ JMADOIEKJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KAFKEBICBKM ADPCPMNAMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly GLLCFNDIHNJ NNKPEOLFJOF;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DFCCNAICMBJ DLIJPLKBIIP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly KAFKEBICBKM HIEHMLMPPFM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DFCCNAICMBJ NPJNLBCEEEO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly KAFKEBICBKM EKFKKAPEPDJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DFCCNAICMBJ JDIAHGDNGPP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KAFKEBICBKM NNDCJGLOGHL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly GLLCFNDIHNJ EHEIDGKMNLF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly NLGCGKDKPPP BENGIKOEPPE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DFCCNAICMBJ IBAFHFDIELC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x865D2D0", Offset = "0x865BCD0", VA = "0x18865D2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xF277B0", Offset = "0xF261B0", VA = "0x180F277B0")]
	public NLGCGKDKPPP(DFCCNAICMBJ NIPKGGNBNOG, KAFKEBICBKM KPCPBLIKMAG, DFCCNAICMBJ JFHGNHCHBAN, KAFKEBICBKM EDPOENDMHJM, DFCCNAICMBJ GCFNOMLKHAM, KAFKEBICBKM EIJOJPKHAED, GLLCFNDIHNJ KMMDIFIGBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	private static bool DLHMCGBOAPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void LIALAMLBBBF(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	private static bool KJPBJOHOOJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void DOBGHGMHCKH(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	private static bool MICGAOLBIJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void HGEHFMLDOII(string JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void GGCGFLDGKIA(Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x865D4D0", Offset = "0x865BED0", VA = "0x18865D4D0")]
	private static NLGCGKDKPPP HKBEGBPMHPI()
	{
		return default(NLGCGKDKPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
	private static bool DDCPOBKAPMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x865D610", Offset = "0x865C010", VA = "0x18865D610")]
	public void JAPFEIFECJM(object JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x865D680", Offset = "0x865C080", VA = "0x18865D680")]
	public void KBCBEAJKCBH(object JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x865D6F0", Offset = "0x865C0F0", VA = "0x18865D6F0")]
	public void KCFDIHIJGKF(object JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xF2ED50", Offset = "0xF2D750", VA = "0x180F2ED50")]
	public void PCCOFEDAEJF(Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x865D760", Offset = "0x865C160", VA = "0x18865D760")]
	public void KCFDIHIJGKF(LCMPKAIDCOG JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F530", Offset = "0x3F0DF30", VA = "0x183F0F530")]
	public void KCFDIHIJGKF<T>(T MFHBGCBJCJO, KLONFCPMABD<T> JEBOHIALEMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F3B0", Offset = "0x3F0DDB0", VA = "0x183F0F3B0")]
	public void JAPFEIFECJM<T>([In] T MFHBGCBJCJO, JICCIGBEPML<T> JEBOHIALEMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F600", Offset = "0x3F0E000", VA = "0x183F0F600")]
	public void KCFDIHIJGKF<T>([In] T MFHBGCBJCJO, JICCIGBEPML<T> JEBOHIALEMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x865D840", Offset = "0x865C240", VA = "0x18865D840")]
	public bool KOAGOKFONIH(bool HPFDJAAAMGI, string JEBOHIALEMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NDPBDHPILEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string AFPBILBCKEL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	public NDPBDHPILEI(string KMAFNKGMDCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
	public static string HDPJNBPLGPE([In] NDPBDHPILEI DKGBCFDLMOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x14C5170", Offset = "0x14C3B70", VA = "0x1814C5170")]
	public static NDPBDHPILEI HDPJNBPLGPE(string GOCNHGEHNFD)
	{
		return default(NDPBDHPILEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x865D1A0", Offset = "0x865BBA0", VA = "0x18865D1A0")]
	public string CCMABJBJCEC(string HPKKCNLEGJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x865D1F0", Offset = "0x865BBF0", VA = "0x18865D1F0")]
	public string GIGMCJOOLIE(object LGKBNMPAIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class DGNAIFJHMLA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public DGNAIFJHMLA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct LJBIGLJNMFO : IEquatable<LJBIGLJNMFO>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "4")]
	public bool Equals(LJBIGLJNMFO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x865C680", Offset = "0x865B080", VA = "0x18865C680", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x865C6D0", Offset = "0x865B0D0", VA = "0x18865C6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x865C6E0", Offset = "0x865B0E0", VA = "0x18865C6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KHKMOONJBJE("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DBCJPOJBOOF<T> : IEquatable<DBCJPOJBOOF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T AFPBILBCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool LDMLLPFNOMA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool BCCCPOJPPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBAA150", Offset = "0xBA8B50", VA = "0x180BAA150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x45D4660", Offset = "0x45D3060", VA = "0x1845D4660")]
	public DBCJPOJBOOF([In] T KMAFNKGMDCF, bool ECOBIBNCCPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45D3900", Offset = "0x45D2300", VA = "0x1845D3900")]
	public static bool NOPNAEDOCOI([In] DBCJPOJBOOF<T> IIIICGAEODJ, [In] DBCJPOJBOOF<T> ELBIKJBAIEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x45D25E0", Offset = "0x45D0FE0", VA = "0x1845D25E0", Slot = "4")]
	public bool Equals(DBCJPOJBOOF<T> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x45D2EB0", Offset = "0x45D18B0", VA = "0x1845D2EB0", Slot = "0")]
	public override bool Equals(object? GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x45D35E0", Offset = "0x45D1FE0", VA = "0x1845D35E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x45D4520", Offset = "0x45D2F20", VA = "0x1845D4520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class OIODLCONFKC
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F4E2F0", Offset = "0x3F4CCF0", VA = "0x183F4E2F0")]
	public static DBCJPOJBOOF<T> LEIAFNBKMOO<T>([In] T KMAFNKGMDCF) where T : notnull
	{
		return default(DBCJPOJBOOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F4E0D0", Offset = "0x3F4CAD0", VA = "0x183F4E0D0")]
	public static DBCJPOJBOOF<T?> KIIHCOANHNI<T>()
	{
		return default(DBCJPOJBOOF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F4DF50", Offset = "0x3F4C950", VA = "0x183F4DF50")]
	public static bool GENPNMOHKAF<T>([In] this DBCJPOJBOOF<T> GCABCGFEECG, [Out][NotNullWhen(true)] T KMAFNKGMDCF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F4DF10", Offset = "0x3F4C910", VA = "0x183F4DF10")]
	public static bool GENPNMOHKAF<T>([In] this DBCJPOJBOOF<T> GCABCGFEECG, [Out][NotNullWhen(true)] T KMAFNKGMDCF, [Out] DBCJPOJBOOF<T> LLLIPMPKEGE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F4E190", Offset = "0x3F4CB90", VA = "0x183F4E190")]
	public static T? LDMFCJOJJPJ<T>([In] this DBCJPOJBOOF<T> GCABCGFEECG, T? KJMOBDOKFBF)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F4E380", Offset = "0x3F4CD80", VA = "0x183F4E380")]
	public static bool OKIBIFJLPPJ<T>([In] this DBCJPOJBOOF<T> GCABCGFEECG, T KMAFNKGMDCF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HBLBGDADNIH
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDDF0", Offset = "0x3DBC7F0", VA = "0x183DBDDF0")]
	public static T PHNNMILFBBO<T>([In] this DBCJPOJBOOF<T> GCABCGFEECG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CBKNPHFFHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr HCHCJJNABJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr JNFFHIJDKKL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr GFFAKCFDLOM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr IEOEBFCKGGH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly CBKNPHFFHDI BENGIKOEPPE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DGOCJDKBCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8653750", Offset = "0x8652150", VA = "0x188653750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	public CBKNPHFFHDI(IntPtr NPCDPEBBFCJ, IntPtr PAAPMCANBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void MBEGMOIFBIO(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void KHFMNJFIGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8653830", Offset = "0x8652230", VA = "0x188653830")]
	private static CBKNPHFFHDI HKBEGBPMHPI()
	{
		return default(CBKNPHFFHDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct AFLMDIAGCFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr ELMOBIMFFED;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x140A7F0", Offset = "0x14091F0", VA = "0x18140A7F0")]
	private AFLMDIAGCFO(IntPtr PAAPMCANBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8652C00", Offset = "0x8651600", VA = "0x188652C00")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8652B20", Offset = "0x8651520", VA = "0x188652B20")]
	public static AFLMDIAGCFO KDBDJPAJKDJ(string IELIBBNCJAC)
	{
		return default(AFLMDIAGCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B55AC0", Offset = "0x2B544C0", VA = "0x182B55AC0")]
	public static AFLMDIAGCFO KDBDJPAJKDJ([In] CBKNPHFFHDI KJAMPAGNLKK, string IELIBBNCJAC)
	{
		return default(AFLMDIAGCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B55640", Offset = "0x2B54040", VA = "0x182B55640")]
	public static AFLMDIAGCFO KDBDJPAJKDJ([In] CBKNPHFFHDI KJAMPAGNLKK, Func<string> IELIBBNCJAC)
	{
		return default(AFLMDIAGCFO);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JIKELDPJBDE : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? FHOKKLICJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr AOJHINEOFJM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool BGNJAAAPJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8658F10", Offset = "0x8657910", VA = "0x188658F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8659000", Offset = "0x8657A00", VA = "0x188659000")]
	public static SHA256 MLAHKGEEKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8658EA0", Offset = "0x86578A0", VA = "0x188658EA0")]
	private static extern int MHJNDJCGNLM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8658910", Offset = "0x8657310", VA = "0x188658910")]
	private static extern IntPtr ABCKNGLDDHP();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8658D60", Offset = "0x8657760", VA = "0x188658D60")]
	private static extern void IFHFLGBFHPO(IntPtr AOJHINEOFJM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8658A20", Offset = "0x8657420", VA = "0x188658A20")]
	private static extern void DKLNILHFDLL(IntPtr AOJHINEOFJM, byte[] BLPDDGCLNPE, int JBCPGNDLJHB, int FOLDIOKKGMM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8658980", Offset = "0x8657380", VA = "0x188658980")]
	private static extern void DEIAIMDILII(IntPtr AOJHINEOFJM, byte[] PJEACFMPOKN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8659080", Offset = "0x8657A80", VA = "0x188659080")]
	private JIKELDPJBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8658B70", Offset = "0x8657570", VA = "0x188658B70", Slot = "18")]
	protected override void HashCore(byte[] BHEONMJLANC, int PHACGDKBHIC, int IMGHCLNPMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8658C30", Offset = "0x8657630", VA = "0x188658C30", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8658DE0", Offset = "0x86577E0", VA = "0x188658DE0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8658AE0", Offset = "0x86574E0", VA = "0x188658AE0", Slot = "13")]
	protected override void Dispose(bool JCHDBFDPFMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KCLMPBFKEHD
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool MINELKENHHK<in TInput, TResult>(TInput GHANLDMHBLD, [Out] TResult GGIKEMCHAAA);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class CACDNMIFGDF : NIAKHEFJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class GEEHFNEABHF : MJJGGOHCEIF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly GEEHFNEABHF FLGHCDNLMND;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool FICMBNIAFOO
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8656D10", Offset = "0x8655710", VA = "0x188656D10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8656D70", Offset = "0x8655770", VA = "0x188656D70", Slot = "6")]
			public void OnCompleted(Action BKCGBGOCCHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			public void AHCLDIMMOIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public GEEHFNEABHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly CACDNMIFGDF FLGHCDNLMND;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		private CACDNMIFGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8653680", Offset = "0x8652080", VA = "0x188653680", Slot = "4")]
		public MJJGGOHCEIF CHDCJGNKGCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class NMCNNIIMDGE : NIAKHEFJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class JDNBLHIOPGP : MJJGGOHCEIF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly JDNBLHIOPGP FLGHCDNLMND;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool FICMBNIAFOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8658820", Offset = "0x8657220", VA = "0x188658820", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8658840", Offset = "0x8657240", VA = "0x188658840", Slot = "6")]
			public void OnCompleted(Action BKCGBGOCCHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			public void AHCLDIMMOIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JDNBLHIOPGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly NMCNNIIMDGE FLGHCDNLMND;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		private NMCNNIIMDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x865DEF0", Offset = "0x865C8F0", VA = "0x18865DEF0", Slot = "4")]
		public MJJGGOHCEIF CHDCJGNKGCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PPLFLCKGKEN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PPLFLCKGKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1220", Offset = "0x5BAFC20", VA = "0x185BB1220")]
		internal void JACFDBIILPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JKNGLAJNHKB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JKNGLAJNHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55472B0", Offset = "0x5545CB0", VA = "0x1855472B0")]
		internal void CDHKEIENKKM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct EBNCCNCFCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8654B10", Offset = "0x8653510", VA = "0x188654B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KFKECKGBOMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x865B5B0", Offset = "0x8659FB0", VA = "0x18865B5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct HIPBOLDABOM<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x51BC670", Offset = "0x51BB070", VA = "0x1851BC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x51BC7E0", Offset = "0x51BB1E0", VA = "0x1851BC7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KDFGIPMLNOI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool logCancellations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5649BB0", Offset = "0x56485B0", VA = "0x185649BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5407E50", Offset = "0x5406850", VA = "0x185407E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PJJDANIAPKE<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5CB2870", Offset = "0x5CB1270", VA = "0x185CB2870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5CB30E0", Offset = "0x5CB1AE0", VA = "0x185CB30E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct ELLLKLFGDDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8655490", Offset = "0x8653E90", VA = "0x188655490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86556A0", Offset = "0x86540A0", VA = "0x1886556A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OHPPBLHHKEB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OHPPBLHHKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1220", Offset = "0x5BAFC20", VA = "0x185BB1220")]
		internal void COMBCLADECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5BB1260", Offset = "0x5BAFC60", VA = "0x185BB1260")]
		internal void GHKFLIBODHJ(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IOJCJHPHNHN<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MINELKENHHK<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x53173C0", Offset = "0x5315DC0", VA = "0x1853173C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5317AA0", Offset = "0x53164A0", VA = "0x185317AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LNJELHNHOAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x865C710", Offset = "0x865B110", VA = "0x18865C710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x865CF00", Offset = "0x865B900", VA = "0x18865CF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PBLIKBIADGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x865F160", Offset = "0x865DB60", VA = "0x18865F160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x865F6A0", Offset = "0x865E0A0", VA = "0x18865F6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EPDLGOOHFHC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4B3D190", Offset = "0x4B3BB90", VA = "0x184B3D190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E0F0", Offset = "0x4B3CAF0", VA = "0x184B3E0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class KFDPCANCLHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<LJBIGLJNMFO> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KFDPCANCLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x865B4A0", Offset = "0x8659EA0", VA = "0x18865B4A0")]
		internal void EJOGGKKEFNA(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct EJMMNGDODKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IEnumerable<Task> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8654E50", Offset = "0x8653850", VA = "0x188654E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86550D0", Offset = "0x8653AD0", VA = "0x1886550D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EFNLMDJBDNM<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4B0D260", Offset = "0x4B0BC60", VA = "0x184B0D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x45A7A20", Offset = "0x45A6420", VA = "0x1845A7A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct JLNNMGFFBPD<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5548720", Offset = "0x5547120", VA = "0x185548720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45A6AE0", Offset = "0x45A54E0", VA = "0x1845A6AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JBNPKIIHFOC<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5530470", Offset = "0x552EE70", VA = "0x185530470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5530C80", Offset = "0x552F680", VA = "0x185530C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct FNOAEDDMIIL : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8656AD0", Offset = "0x86554D0", VA = "0x188656AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8656CB0", Offset = "0x86556B0", VA = "0x188656CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AJEFLHKLCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8652FA0", Offset = "0x86519A0", VA = "0x188652FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8653310", Offset = "0x8651D10", VA = "0x188653310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct ELBCCJJKPEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8655140", Offset = "0x8653B40", VA = "0x188655140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8655430", Offset = "0x8653E30", VA = "0x188655430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CFIFENCMNIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CFIFENCMNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8653A10", Offset = "0x8652410", VA = "0x188653A10")]
		internal Task HFCLFALMOIG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct DPFOJIFHKOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8654850", Offset = "0x8653250", VA = "0x188654850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8654AB0", Offset = "0x86534B0", VA = "0x188654AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LHJKKPDHAHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x865B980", Offset = "0x865A380", VA = "0x18865B980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x865BB60", Offset = "0x865A560", VA = "0x18865BB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LHPKFECEDHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x865BBC0", Offset = "0x865A5C0", VA = "0x18865BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x865BF20", Offset = "0x865A920", VA = "0x18865BF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct HENBBIPDHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x86580E0", Offset = "0x8656AE0", VA = "0x1886580E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86583D0", Offset = "0x8656DD0", VA = "0x1886583D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class KBBPCCJNODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KBBPCCJNODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x86590B0", Offset = "0x8657AB0", VA = "0x1886590B0")]
		internal Task KEENEMAGELD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct KLHFHBAHDOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x865B6C0", Offset = "0x865A0C0", VA = "0x18865B6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x865B920", Offset = "0x865A320", VA = "0x18865B920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EEPLIBDKAFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8654C70", Offset = "0x8653670", VA = "0x188654C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8654DF0", Offset = "0x86537F0", VA = "0x188654DF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct EJCLBMOIJMI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4B2A320", Offset = "0x4B28D20", VA = "0x184B2A320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4B2A7E0", Offset = "0x4B291E0", VA = "0x184B2A7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct AHOPKIMMMCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8652C10", Offset = "0x8651610", VA = "0x188652C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8652F40", Offset = "0x8651940", VA = "0x188652F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? PLBPCGLINKE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<LJBIGLJNMFO> BLFGKJHPECJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task BDKLHFKJIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8659B30", Offset = "0x8658530", VA = "0x188659B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x865A210", Offset = "0x8658C10", VA = "0x18865A210")]
	public static bool KIHJCGLHCDL(this Task FLAIIHBKGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3E52560", Offset = "0x3E50F60", VA = "0x183E52560")]
	public static Task<T> GOLNHDLKCPG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8659360", Offset = "0x8657D60", VA = "0x188659360")]
	public static Task DMEFMNIJCPI(this Task FLAIIHBKGBI, CancellationToken MFKHKDDANII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E50360", Offset = "0x3E4ED60", VA = "0x183E50360")]
	public static Task<TResult> DMEFMNIJCPI<TResult>(this Task<TResult> FLAIIHBKGBI, CancellationToken MFKHKDDANII) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E4E620", Offset = "0x3E4D020", VA = "0x183E4E620")]
	public static TaskCompletionSource<TResult> DMEFMNIJCPI<TResult>(this TaskCompletionSource<TResult> EFNJFOCDIEE, CancellationToken MFKHKDDANII) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8659D30", Offset = "0x8658730", VA = "0x188659D30")]
	public static IDisposable? IDJBLPDDMKG(CancellationToken GOBEJEOOKOD, CancellationToken NGHFGKOHLOP, [Out] CancellationToken NCAOMFAAEJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x865ADB0", Offset = "0x86597B0", VA = "0x18865ADB0")]
	[AsyncStateMachine(typeof(EBNCCNCFCMK))]
	public static void PCJHIKNLDKI(this Task GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8659EC0", Offset = "0x86588C0", VA = "0x188659EC0")]
	[AsyncStateMachine(typeof(KFKECKGBOMG))]
	public static void IEMNMNEPHAF(this Task GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E526B0", Offset = "0x3E510B0", VA = "0x183E526B0")]
	[AsyncStateMachine(typeof(HIPBOLDABOM<>))]
	public static Task OMENLMNGEAB<TException>(this Task GGMLEPFJHKP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D3A0", Offset = "0x3E4BDA0", VA = "0x183E4D3A0")]
	[AsyncStateMachine(typeof(KDFGIPMLNOI<>))]
	public static Task<T> AJKPNKAIKJI<T>(this Task<T> DKGBCFDLMOI, OLFEOKKCIEG JHGFKLHHPJD, Func<Task<T>, string> CIJHICGGILB, bool HKHJLOCHNJB = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D1E0", Offset = "0x3E4BBE0", VA = "0x183E4D1E0")]
	[AsyncStateMachine(typeof(PJJDANIAPKE<>))]
	public static Task<T> AJKPNKAIKJI<T>(this Task<T> DKGBCFDLMOI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8659270", Offset = "0x8657C70", VA = "0x188659270")]
	[AsyncStateMachine(typeof(ELLLKLFGDDM))]
	public static Task<TaskStatus> DHGABFKGIMD(this Task? DKGBCFDLMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3E52780", Offset = "0x3E51180", VA = "0x183E52780")]
	public static (Task<T?>?, Action<T?>?) PKMKMGOGPIB<T>([Optional] CancellationToken AHOMALKMHKK)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E52460", Offset = "0x3E50E60", VA = "0x183E52460")]
	[AsyncStateMachine(typeof(IOJCJHPHNHN<, >))]
	public static Task<List<TResult>> FNDFHAJAHOJ<TResult, TInput>(this Task<List<TInput>> FLAIIHBKGBI, MINELKENHHK<TInput, TResult> FBGEHJJOKJP) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x865A240", Offset = "0x8658C40", VA = "0x18865A240")]
	[AsyncStateMachine(typeof(LNJELHNHOAH))]
	public static Task LJFIKFIFKHB(Task GGMLEPFJHKP, CancellationToken ICODIHINNBH, Func<CancellationToken, Task> DGGLNOFOMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8659700", Offset = "0x8658100", VA = "0x188659700")]
	[AsyncStateMachine(typeof(PBLIKBIADGM))]
	public static Task EEFJCABPOKB(Func<CancellationToken, Task> OLGHGKJILEE, TimeSpan LPPGPMAJHFP, [Optional] CancellationToken ICODIHINNBH, [Optional] Action<OperationCanceledException>? FAOKBBPIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E52040", Offset = "0x3E50A40", VA = "0x183E52040")]
	[AsyncStateMachine(typeof(EPDLGOOHFHC<>))]
	public static Task<T> EEFJCABPOKB<T>(Func<CancellationToken, Task<T>> OLGHGKJILEE, TimeSpan LPPGPMAJHFP, [Optional] CancellationToken ICODIHINNBH, [Optional] Func<OperationCanceledException, T>? FAOKBBPIHBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x865AD60", Offset = "0x8659760", VA = "0x18865AD60")]
	public static Task OHKPBPJHIOA(params Task[] BKGFHPLBDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x865A8A0", Offset = "0x86592A0", VA = "0x18865A8A0")]
	public static Task OHKPBPJHIOA(IEnumerable<Task> BKGFHPLBDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8659A30", Offset = "0x8658430", VA = "0x188659A30")]
	[AsyncStateMachine(typeof(EJMMNGDODKP))]
	public static Task<IEnumerable<Task>> FLEHPPLKECO(IEnumerable<Task> BKGFHPLBDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E52380", Offset = "0x3E50D80", VA = "0x183E52380")]
	[AsyncStateMachine(typeof(EFNLMDJBDNM<>))]
	public static Task<IEnumerable<Task<T>>> FLEHPPLKECO<T>(IEnumerable<Task<T>> BKGFHPLBDCE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D780", Offset = "0x3E4C180", VA = "0x183E4D780")]
	[AsyncStateMachine(typeof(JLNNMGFFBPD<, , >))]
	public static Task<(T1, T2, T3)> AMHIKOBIIEI<T1, T2, T3>(Task<T1> GJAMEKLGBCG, Task<T2> JAIEAJKDBIG, Task<T3> AKLFEJALOFG) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E4D4C0", Offset = "0x3E4BEC0", VA = "0x183E4D4C0")]
	[AsyncStateMachine(typeof(JBNPKIIHFOC<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> AMHIKOBIIEI<T1, T2, T3, T4, T5>(Task<T1> GJAMEKLGBCG, Task<T2> JAIEAJKDBIG, Task<T3> AKLFEJALOFG, Task<T4> CPEBLEPDKPL, Task<T5> KONPNPMGGPP) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x865AF70", Offset = "0x8659970", VA = "0x18865AF70")]
	[AsyncStateMachine(typeof(FNOAEDDMIIL))]
	public static Task PKJHKLNIKFL(Func<bool> HPFDJAAAMGI, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x865AE60", Offset = "0x8659860", VA = "0x18865AE60")]
	[AsyncStateMachine(typeof(AJEFLHKLCFD))]
	public static Task PKJHKLNIKFL(Func<bool> HPFDJAAAMGI, TimeSpan BJMOALOCGFB, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x865A4B0", Offset = "0x8658EB0", VA = "0x18865A4B0")]
	[AsyncStateMachine(typeof(ELBCCJJKPEM))]
	public static Task MBJDOEDJNCA(Func<bool> HPFDJAAAMGI, TimeSpan LPPGPMAJHFP, [Optional] CancellationToken AHOMALKMHKK, [Optional] Action<OperationCanceledException>? FAOKBBPIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x865A370", Offset = "0x8658D70", VA = "0x18865A370")]
	[AsyncStateMachine(typeof(DPFOJIFHKOM))]
	public static Task MBJDOEDJNCA(Func<bool> HPFDJAAAMGI, TimeSpan LPPGPMAJHFP, TimeSpan BJMOALOCGFB, [Optional] CancellationToken AHOMALKMHKK, [Optional] Action<OperationCanceledException>? FAOKBBPIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8659830", Offset = "0x8658230", VA = "0x188659830")]
	[AsyncStateMachine(typeof(LHJKKPDHAHC))]
	public static Task FBAAPCJFPGO(Func<bool> HPFDJAAAMGI, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8659920", Offset = "0x8658320", VA = "0x188659920")]
	[AsyncStateMachine(typeof(LHPKFECEDHD))]
	public static Task FBAAPCJFPGO(Func<bool> HPFDJAAAMGI, TimeSpan BJMOALOCGFB, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x865A5E0", Offset = "0x8658FE0", VA = "0x18865A5E0")]
	[AsyncStateMachine(typeof(HENBBIPDHIG))]
	public static Task NDLJLJDIFOO(Func<bool> HPFDJAAAMGI, TimeSpan LPPGPMAJHFP, [Optional] CancellationToken AHOMALKMHKK, [Optional] Action<OperationCanceledException>? FAOKBBPIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x865A710", Offset = "0x8659110", VA = "0x18865A710")]
	[AsyncStateMachine(typeof(KLHFHBAHDOA))]
	public static Task NDLJLJDIFOO(Func<bool> HPFDJAAAMGI, TimeSpan LPPGPMAJHFP, TimeSpan BJMOALOCGFB, [Optional] CancellationToken AHOMALKMHKK, [Optional] Action<OperationCanceledException>? FAOKBBPIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8659610", Offset = "0x8658010", VA = "0x188659610")]
	[Obsolete]
	[AsyncStateMachine(typeof(EEPLIBDKAFE))]
	public static Task DPOALGCADBF(this Task FLAIIHBKGBI, Action LLKPOEHNGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E51E60", Offset = "0x3E50860", VA = "0x183E51E60")]
	[Obsolete]
	[AsyncStateMachine(typeof(EJCLBMOIJMI<>))]
	public static Task DPOALGCADBF<T>(this Task<T> FLAIIHBKGBI, Action<T> LLKPOEHNGJM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x865A160", Offset = "0x8658B60", VA = "0x18865A160")]
	private static void IONGNIIALKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x865B060", Offset = "0x8659A60", VA = "0x18865B060")]
	public static bool PLLFGLPDJFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8659BA0", Offset = "0x86585A0", VA = "0x188659BA0")]
	private static void HPBIIBIGOLH(SynchronizationContext KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8659F70", Offset = "0x8658970", VA = "0x188659F70")]
	private static void IFGBKMAFHKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x865A090", Offset = "0x8658A90", VA = "0x18865A090")]
	public static void ILEODCMGJNG([Optional] string? JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x86591F0", Offset = "0x8657BF0", VA = "0x1886591F0")]
	public static void CGFCDEEJAJM([Optional] string? JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x865A850", Offset = "0x8659250", VA = "0x18865A850")]
	public static NIAKHEFJGNG NHPFDFKCDCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x86595C0", Offset = "0x8657FC0", VA = "0x1886595C0")]
	public static NIAKHEFJGNG DNACBGKEOAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8659120", Offset = "0x8657B20", VA = "0x188659120")]
	[AsyncStateMachine(typeof(AHOPKIMMMCE))]
	public static Task BBFBFAFHOMA(Func<Task> DHFPPCMKNFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LDDMKMABCFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public LDDMKMABCFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DEDHNBMODPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x86544C0", Offset = "0x8652EC0", VA = "0x1886544C0")]
	public static bool KPDGNDKHPAM(this EPDJAOACKCO JJCICNHLINF, DateTime ALHIMDFCJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x86545E0", Offset = "0x8652FE0", VA = "0x1886545E0")]
	public static TimeSpan LDJEIMFHBAO(this EPDJAOACKCO JJCICNHLINF, DateTime ALHIMDFCJBF)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DENKKMPJFAL : EPDJAOACKCO
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly EPDJAOACKCO FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime GDIMIMAHELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8654760", Offset = "0x8653160", VA = "0x188654760", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset IIEIHNBMBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8654700", Offset = "0x8653100", VA = "0x188654700", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DENKKMPJFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface EPDJAOACKCO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime GDIMIMAHELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset IIEIHNBMBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class GKAGGADMGBH
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long DODFFCJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8657D10", Offset = "0x8656710", VA = "0x188657D10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long CENMGNKENGC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8657980", Offset = "0x8656380", VA = "0x188657980")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double CCNFNAHPPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8657DC0", Offset = "0x86567C0", VA = "0x188657DC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double HNECEOKLKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8657D70", Offset = "0x8656770", VA = "0x188657D70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double CHCIBOGKEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86579D0", Offset = "0x86563D0", VA = "0x1886579D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double CJFJNCFIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8657B40", Offset = "0x8656540", VA = "0x188657B40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8657B90", Offset = "0x8656590", VA = "0x188657B90")]
	public static double IBBMKHOEILF(long DALPHLDAJOC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8657C20", Offset = "0x8656620", VA = "0x188657C20")]
	public static double IFOHFDHDHBF(long DALPHLDAJOC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8657A20", Offset = "0x8656420", VA = "0x188657A20")]
	public static double HGODPCONMCJ(double GODLLMOFGBH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8657AB0", Offset = "0x86564B0", VA = "0x188657AB0")]
	public static long HJPPNJGGGPM(long JHMKMDEDCJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8657D60", Offset = "0x8656760", VA = "0x188657D60")]
	public static long KNPGCFPPMNF(long FAMFGLEDELO, long EFMNBAPLDCF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x86578B0", Offset = "0x86562B0", VA = "0x1886578B0")]
	public static double AFLKBDKLMJA(long FAMFGLEDELO, long EFMNBAPLDCF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8657CB0", Offset = "0x86566B0", VA = "0x188657CB0")]
	public static double JAOKIKHDPJO(long FAMFGLEDELO, long EFMNBAPLDCF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class LIOJIFECNNO : KNPAKHMHOAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan HHFPFPPDOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan LPPGPMAJHFP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan HKPLMNEEAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x865C1F0", Offset = "0x865ABF0", VA = "0x18865C1F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? MPKCFHDJDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x865C610", Offset = "0x865B010", VA = "0x18865C610")]
	[Preserve]
	public LIOJIFECNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x865C3C0", Offset = "0x865ADC0", VA = "0x18865C3C0")]
	public LIOJIFECNNO(TimeSpan LPPGPMAJHFP, [Optional] Action? IJKKMPPMEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x865C0F0", Offset = "0x865AAF0", VA = "0x18865C0F0", Slot = "7")]
	public void GLFALCCJJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x865C180", Offset = "0x865AB80", VA = "0x18865C180", Slot = "8")]
	public void PBMOBGIJHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x865C0C0", Offset = "0x865AAC0", VA = "0x18865C0C0", Slot = "9")]
	public void ECGOBBCGDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1366E70", Offset = "0x1365870", VA = "0x181366E70")]
	private void JEAPKHHNNDN(object HBELCFIJGKE, ElapsedEventArgs FDMKKJHCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x865BF80", Offset = "0x865A980", VA = "0x18865BF80")]
	private static void ABNGIPJAPPC(TimeSpan FMHCJFFBOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x865C020", Offset = "0x865AA20", VA = "0x18865C020", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class KHKMOONJBJE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? BFCLHODIKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string ELDLMDNPEJP;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x19F4F50", Offset = "0x19F3950", VA = "0x1819F4F50")]
	public KHKMOONJBJE(string GDFPOPIGPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x54EF1C0", Offset = "0x54EDBC0", VA = "0x1854EF1C0")]
	public KHKMOONJBJE(string CKJPANLJIKJ, string GDFPOPIGPDJ)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OMBMBLOABPD : IEquatable<OMBMBLOABPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint GFIIPGEIHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int HPLLGPNHINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float MENLPFMNKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort DDPKOFCJFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort EDIPCNEPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short AJIEKDOHMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short LMIFFHCBNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char PHDGJIPMIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char JDHDOFHLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte IKADJKOGJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte EOOJFCBLPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte PAFCCFLAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte KBHGMHGLEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool BELLOGHKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool GBPGDIEPMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool BNLHJNPFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool MIJKHCKDFLK;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x21DAFC0", Offset = "0x21D99C0", VA = "0x1821DAFC0")]
	public static OMBMBLOABPD KBPHPPGLHFA(uint OOCAOOCHEJE)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x21DAFC0", Offset = "0x21D99C0", VA = "0x1821DAFC0")]
	public static OMBMBLOABPD GLHIJAIKKFF(int KCGAKJDEOND)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x865E1E0", Offset = "0x865CBE0", VA = "0x18865E1E0")]
	public static OMBMBLOABPD FEEOCDGPGAJ(float DOFMJJABKBA)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x865E140", Offset = "0x865CB40", VA = "0x18865E140")]
	public static OMBMBLOABPD KKJECECIOOE(byte ECIBIMDDLEK, byte HOIMCCKFOCE, byte KAJOJLHIPJC, byte OPJPNLCBKIL)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x865E140", Offset = "0x865CB40", VA = "0x18865E140")]
	public static OMBMBLOABPD BBFGJKFMBOH(bool OLBBDJFCIGP, bool PMNAKDADCON, bool ELBAPFMCPEO, bool DNADCFAOCPC)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x865E140", Offset = "0x865CB40", VA = "0x18865E140")]
	public static OMBMBLOABPD IIHMJLJAPOP(byte NNCAIPOFOOK, byte NKCICFOMCGA, byte AOEGHNINKPJ, byte KEMODFJFKHA)
	{
		return default(OMBMBLOABPD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x252D280", Offset = "0x252BC80", VA = "0x18252D280")]
	public static bool NOPNAEDOCOI(OMBMBLOABPD CFAKKPGMPGD, OMBMBLOABPD KMGOFHJBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x252D260", Offset = "0x252BC60", VA = "0x18252D260", Slot = "4")]
	public bool Equals(OMBMBLOABPD GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x865E160", Offset = "0x865CB60", VA = "0x18865E160", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1605710", Offset = "0x1604110", VA = "0x181605710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x865E1F0", Offset = "0x865CBF0", VA = "0x18865E1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct IPOKDOPPOHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong DICOLKJCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long IGOHFNCDIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double HPJOBIFHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint JPJBCJEFAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint NPLGNHCGINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int AHKGILGLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int KPLBHONALCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float MAOENANLJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float FDMBLGOKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort DDPKOFCJFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort EDIPCNEPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort IFLHOAADLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort NGOEPHBOBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short AJIEKDOHMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short LMIFFHCBNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short AHHFLLCNNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short BGHPFGIDKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char PHDGJIPMIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char JDHDOFHLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char FCNONOBFAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char KGJMDDBLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte IKADJKOGJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte EOOJFCBLPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte PAFCCFLAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte KBHGMHGLEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte GIIDLEHDLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte KGIHAFMACGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte KCBMPDJCNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte NBLHDKDMHPL;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IPOKDOPPOHM KDBDJPAJKDJ(long DKAENAKGBIM)
	{
		return default(IPOKDOPPOHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x86587D0", Offset = "0x86571D0", VA = "0x1886587D0")]
	public static IPOKDOPPOHM KDBDJPAJKDJ(byte ECIBIMDDLEK, byte HOIMCCKFOCE, byte KAJOJLHIPJC, byte OPJPNLCBKIL, byte GBFFMLNDJND, byte OJJAJENGDCE, byte JIDMEMKHMAP, byte EOECJKPFLCO)
	{
		return default(IPOKDOPPOHM);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct BIMNPKFLIGM : IEquatable<BIMNPKFLIGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte EADIAGDPOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool HMFFMLDAKBB;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x32B3060", Offset = "0x32B1A60", VA = "0x1832B3060")]
	public static BIMNPKFLIGM KKJECECIOOE(byte HPINCIFIMPB)
	{
		return default(BIMNPKFLIGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x32B3060", Offset = "0x32B1A60", VA = "0x1832B3060")]
	public static BIMNPKFLIGM BBFGJKFMBOH(bool KGPKMEPIHNG)
	{
		return default(BIMNPKFLIGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8653410", Offset = "0x8651E10", VA = "0x188653410")]
	public static bool NOPNAEDOCOI(BIMNPKFLIGM CFAKKPGMPGD, BIMNPKFLIGM KMGOFHJBCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x74D5F50", Offset = "0x74D4950", VA = "0x1874D5F50", Slot = "4")]
	public bool Equals(BIMNPKFLIGM GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8653370", Offset = "0x8651D70", VA = "0x188653370", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8653400", Offset = "0x8651E00", VA = "0x188653400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8653420", Offset = "0x8651E20", VA = "0x188653420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FGICOMADDFL<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T MDMIFFMHAMP;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3F60", Offset = "0x4FF2960", VA = "0x184FF3F60")]
	public FGICOMADDFL(T MBGDDINAKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class ABGOEOHIFDF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E20", Offset = "0x32D0820", VA = "0x1832D1E20")]
	public static IEnumerable<T> ILPHPJJHHGF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static T[] EIAHCKGNKFK<T>(params T[] EJCNLLPJFPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static IEnumerable<T> ANDKKGOIGPP<T>(params T[] EJCNLLPJFPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static HashSet<T> AHFBHDOAIBA<T>(params T[] EJCNLLPJFPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x32D1D30", Offset = "0x32D0730", VA = "0x1832D1D30")]
	public static KeyValuePair<TKey, TValue> IKGNHBKMNPL<TKey, TValue>([In] TKey HPFHOBCPNEF, [In] TValue KMAFNKGMDCF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static List<T> FJDIMGAHMGB<T>(IEnumerable<T> GLPDKCPPLJM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ELPDENKFJCA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string JNCMHMCFEBB;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
	public ELPDENKFJCA(string KAHHEMPAJEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object JICCIGBEPML<T>([In] T ALHCDLPBNNA);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object KLONFCPMABD<T>(T ALHCDLPBNNA);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[KDJLEIMOPNO]
public delegate string OFJACPDCNLE(string KKIOLBHBACC, string? LGDIEGLPFLO, bool DLBHJBGIPJI);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KDJLEIMOPNO]
public delegate void KAFKEBICBKM(string JEBOHIALEMJ);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KDJLEIMOPNO]
public delegate void GLLCFNDIHNJ(Exception JOEMCJLBOIG);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object LCMPKAIDCOG();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[KDJLEIMOPNO]
public delegate bool DFCCNAICMBJ();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[KDJLEIMOPNO]
public delegate string OPPLENNIGGL(object PMNHIPACJLN);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class HEBNCPHPJCG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
	public HEBNCPHPJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class CMLLPAIAKDE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct GFPOBJDIPOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8656F50", Offset = "0x8655950", VA = "0x188656F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8657840", Offset = "0x8656240", VA = "0x188657840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback OAKFJGGFKGL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> KLJENKMEPLK;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8653E50", Offset = "0x8652850", VA = "0x188653E50")]
	public static Task<bool> DBOMENMIJJO(int CHIKNOONOAF, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x86541F0", Offset = "0x8652BF0", VA = "0x1886541F0")]
	[AsyncStateMachine(typeof(GFPOBJDIPOC))]
	private static Task<bool> NIELDOCFNEM(int CHIKNOONOAF, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8654160", Offset = "0x8652B60", VA = "0x188654160")]
	private static void FAHEPFJBDJJ(object? IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8654320", Offset = "0x8652D20", VA = "0x188654320")]
	private static void PONKEGAJEME(object? IMNBLKDCAKA)
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
