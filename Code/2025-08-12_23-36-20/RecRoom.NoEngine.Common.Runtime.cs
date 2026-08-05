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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x84EEB40", Offset = "0x84ED940", VA = "0x1884EEB40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GBDAHIAOCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84E98E0", Offset = "0x84E86E0", VA = "0x1884E98E0")]
	public static string FKINCHBPOGG(this Encoding ILPAIKCLHHB, [In] ReadOnlySequence<byte> JICDOIHAMGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2540", Offset = "0x3CF1340", VA = "0x183CF2540")]
	private static void KFOLPDGFCBL<T>(this ReadOnlySequence<T> DLHHDNJKOCF, [Out] ReadOnlySpan<T> MIALIOKCOLC, [Out] SequencePosition JABMJNDCEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class FILIHNAGEKF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84E9810", Offset = "0x84E8610", VA = "0x1884E9810")]
	public FILIHNAGEKF(bool HKFBKILOJFP, string LBHNBILBMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84E97C0", Offset = "0x84E85C0", VA = "0x1884E97C0")]
	public FILIHNAGEKF(bool HKFBKILOJFP, params string[] BMPPLBHDGMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IAILCPAKJAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JGDFELKEIEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IIOMAPAPCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDPFJDHCILP(string OPGJHIOADCK, double HGMAIPELJHM, [Optional] string? KAPBDPBMCFB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PNBDJNFOOBF : BJPOPJFOJBH, MDLOJOCAIHB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LDMCEMNHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> HLBNDGPKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double OLBFNPPONEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double ANDCPDPHMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double JDIINIEPIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MOGOPHHOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double LOBKNCNPJNF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GDNKAPIGMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAB29F0", Offset = "0xAB17F0", VA = "0x180AB29F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EHDMNLKBPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84F0190", Offset = "0x84EEF90", VA = "0x1884F0190", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AEIPKEJBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A330", Offset = "0x2A09130", VA = "0x182A0A330", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double PNKKEKCKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2A38080", Offset = "0x2A36E80", VA = "0x182A38080", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84F0390", Offset = "0x84EF190", VA = "0x1884F0390")]
	public PNBDJNFOOBF(int GNDAFJGMPAI, double LOBKNCNPJNF = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84F0260", Offset = "0x84EF060", VA = "0x1884F0260", Slot = "7")]
	public void NJMNFPABKNB(double DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84F01F0", Offset = "0x84EEFF0", VA = "0x1884F01F0", Slot = "8")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84F0090", Offset = "0x84EEE90", VA = "0x1884F0090", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MOKEHAIFFHB : BJPOPJFOJBH, MDLOJOCAIHB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long FFKCBONKOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double MLGANBIAJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double MANGJDKLAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BNBCFNHCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double FOGJMIOJLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double OLBFNPPONEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double ANDCPDPHMGN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AEIPKEJBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76D5F80", Offset = "0x76D4D80", VA = "0x1876D5F80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double PNKKEKCKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76D63E0", Offset = "0x76D51E0", VA = "0x1876D63E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double ECIAMHCMCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76D5F90", Offset = "0x76D4D90", VA = "0x1876D5F90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double EHDMNLKBPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A0A340", Offset = "0x2A09140", VA = "0x182A0A340", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84EDFE0", Offset = "0x84ECDE0", VA = "0x1884EDFE0", Slot = "10")]
	public virtual void NJMNFPABKNB(double DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84EDFA0", Offset = "0x84ECDA0", VA = "0x1884EDFA0", Slot = "11")]
	public virtual void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84EDF30", Offset = "0x84ECD30", VA = "0x1884EDF30", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84E88A0", Offset = "0x84E76A0", VA = "0x1884E88A0")]
	public MOKEHAIFFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DLBAGJGBMLJ : MOKEHAIFFHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MALIODIMIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76D6400", Offset = "0x76D5200", VA = "0x1876D6400")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76D63D0", Offset = "0x76D51D0", VA = "0x1876D63D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84E8770", Offset = "0x84E7570", VA = "0x1884E8770", Slot = "10")]
	public override void NJMNFPABKNB(double DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84E8730", Offset = "0x84E7530", VA = "0x1884E8730", Slot = "11")]
	public override void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84E88A0", Offset = "0x84E76A0", VA = "0x1884E88A0")]
	public DLBAGJGBMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BJPOPJFOJBH : MDLOJOCAIHB, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EHDMNLKBPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double AEIPKEJBJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double PNKKEKCKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IEKPEMGHJMA : MDLOJOCAIHB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double NIEGCCDJMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double KOIKOEGJFHA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84EC3D0", Offset = "0x84EB1D0", VA = "0x1884EC3D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71128C0", Offset = "0x71116C0", VA = "0x1871128C0", Slot = "4")]
	public void NJMNFPABKNB(double DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84EC3C0", Offset = "0x84EB1C0", VA = "0x1884EC3C0", Slot = "5")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84EC370", Offset = "0x84EB170", VA = "0x1884EC370", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public IEKPEMGHJMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MDLOJOCAIHB : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJMNFPABKNB(double DOMECMGKIBN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNFHOLHMALL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BGILLKFKCPB : MDLOJOCAIHB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double HGMAIPELJHM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x11FDFC0", Offset = "0x11FCDC0", VA = "0x1811FDFC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x594D7C0", Offset = "0x594C5C0", VA = "0x18594D7C0", Slot = "4")]
	public void NJMNFPABKNB(double DOMECMGKIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84E3C90", Offset = "0x84E2A90", VA = "0x1884E3C90", Slot = "5")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84E3C40", Offset = "0x84E2A40", VA = "0x1884E3C40", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BGILLKFKCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HFJHCKEOBNO<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> KMEHCHMOJCH(CancellationToken BKHGNHANFKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DMFJLLBKEOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HFJHCKEOBNO<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KMEHCHMOJCH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x45AF8E0", Offset = "0x45AE6E0", VA = "0x1845AF8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x45B0930", Offset = "0x45AF730", VA = "0x1845B0930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource DPCAFKKKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? MNFBHGBNPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? JCGKFFCLBFH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x508B540", Offset = "0x508A340", VA = "0x18508B540")]
	[AsyncStateMachine(typeof(HFJHCKEOBNO<>.DMFJLLBKEOG))]
	public Task<TResult> GBEAEFHBBLJ(KMEHCHMOJCH LMLLOHDGODE, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x508B4D0", Offset = "0x508A2D0", VA = "0x18508B4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x508B680", Offset = "0x508A480", VA = "0x18508B680")]
	public HFJHCKEOBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FDDLJFCHPMG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> LCMAJCJMFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T DDHBFJGPDAJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE590", Offset = "0x4EFD390", VA = "0x184EFE590")]
	public FDDLJFCHPMG([In] T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD650", Offset = "0x4EFC450", VA = "0x184EFD650", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4EFDEC0", Offset = "0x4EFCCC0", VA = "0x184EFDEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4EFE070", Offset = "0x4EFCE70", VA = "0x184EFE070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BLKPOHNPNHC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static FDDLJFCHPMG<T> ELDPFIHNJDG<T>([In] T HGMAIPELJHM) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MFHJFIKNHML
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84EDB70", Offset = "0x84EC970", VA = "0x1884EDB70")]
	public static void CDKICHINDAC(this CancellationTokenSource DPCAFKKKHOA, bool CLBMDPOJFCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ALOHAELMFGA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public ALOHAELMFGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CPEHMMDJBME : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public CPEHMMDJBME(string CFINJMNCOLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DINLLPMJEKL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B593C0", Offset = "0x3B581C0", VA = "0x183B593C0")]
	public static AGDMIFDFONN HIBMLMFDMFL<T>()
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84E81F0", Offset = "0x84E6FF0", VA = "0x1884E81F0")]
	public static AGDMIFDFONN AHCCBFHBEME([CallerMemberName] string PFLDDMDPCBI = "")
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B59230", Offset = "0x3B58030", VA = "0x183B59230")]
	public static AGDMIFDFONN EJDEDBAGCIO<T>([CallerMemberName] string PFLDDMDPCBI = "") where T : notnull
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B59440", Offset = "0x3B58240", VA = "0x183B59440")]
	public static AGDMIFDFONN HIBMLMFDMFL<T>(this T OGPILIPEPKA) where T : notnull
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B59010", Offset = "0x3B57E10", VA = "0x183B59010")]
	public static AGDMIFDFONN AHCCBFHBEME<T>(this T OGPILIPEPKA, [CallerMemberName] string PFLDDMDPCBI = "") where T : notnull
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B59190", Offset = "0x3B57F90", VA = "0x183B59190")]
	public static AGDMIFDFONN EJDEDBAGCIO<T>(this T DBBEADIHLKO, [CallerMemberName] string PFLDDMDPCBI = "") where T : notnull
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84E82F0", Offset = "0x84E70F0", VA = "0x1884E82F0")]
	public static AGDMIFDFONN EJDEDBAGCIO(string HEMBHAPGOKE, [CallerMemberName] string PFLDDMDPCBI = "")
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84E8250", Offset = "0x84E7050", VA = "0x1884E8250")]
	public static string DPBFNAKCOGK(this object DBBEADIHLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool LHJMLODPBMG();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ALOHAELMFGA]
public delegate long ELDBJIJIODM();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class AOODLLCMKAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly AOODLLCMKAN MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AOODLLCMKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HDJHBHBCHON
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static CFONKMMIAGN AIMHPHFEJCK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static CFONKMMIAGN FNFAOFLAJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84EB750", Offset = "0x84EA550", VA = "0x1884EB750")]
		get
		{
			return default(CFONKMMIAGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static ONFEIKMNNCB IABEGCPEBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84EBA60", Offset = "0x84EA860", VA = "0x1884EBA60")]
		get
		{
			return default(ONFEIKMNNCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NDOHEACPGPP HADGJJOKHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84EB910", Offset = "0x84EA710", VA = "0x1884EB910")]
		get
		{
			return default(NDOHEACPGPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool JHCCIBIMIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84EB330", Offset = "0x84EA130", VA = "0x1884EB330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84EB4E0", Offset = "0x84EA2E0", VA = "0x1884EB4E0")]
	public static void GAAFGIFKMPA([In] CFONKMMIAGN PHPDHBBIIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84EB7A0", Offset = "0x84EA5A0", VA = "0x1884EB7A0")]
	public static void ICNEBIIBIEE(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84EB3A0", Offset = "0x84EA1A0", VA = "0x1884EB3A0")]
	public static void DBOKEBLPHBF(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B430", Offset = "0x3D0A230", VA = "0x183D0B430")]
	public static void DBOKEBLPHBF<T>(T EIENELGOLAB, POKCOLNKGNE<T> JDFCBBCKOGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84EB9C0", Offset = "0x84EA7C0", VA = "0x1884EB9C0")]
	public static void MPMDOAFMNCC(Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84EB2D0", Offset = "0x84EA0D0", VA = "0x1884EB2D0")]
	public static void AIFKGMNDOIA(string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84EB960", Offset = "0x84EA760", VA = "0x1884EB960")]
	public static void LGIPHBDFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84EB470", Offset = "0x84EA270", VA = "0x1884EB470")]
	public static string DPBFNAKCOGK(object ALGAKMGCCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84EB260", Offset = "0x84EA060", VA = "0x1884EB260")]
	public static long AFOECLAOFBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84EB870", Offset = "0x84EA670", VA = "0x1884EB870")]
	public static bool JGBBCNHGFJF(bool ECNHPJKBPID, string JDFCBBCKOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84EB680", Offset = "0x84EA480", VA = "0x1884EB680")]
	public static double GEBPAMBCMCF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct CFONKMMIAGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly ONFEIKMNNCB IABEGCPEBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly NDOHEACPGPP HADGJJOKHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly OKCEHHHICPI FAMICEGDAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly ELDBJIJIODM NNCHFDJMOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly IMHDCOMKJLO PEAKJHJCMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly LHJMLODPBMG CHAMNJADIKN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly OKCEHHHICPI MBLBANMOFGB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ELDBJIJIODM KMLDHGLCFCL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly IMHDCOMKJLO NCFBBIHCLIP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly LHJMLODPBMG EDLMNCIAGBK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly CFONKMMIAGN FBGBKFBLNFL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84E4A30", Offset = "0x84E3830", VA = "0x1884E4A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84E5280", Offset = "0x84E4080", VA = "0x1884E5280")]
	public CFONKMMIAGN([In] ONFEIKMNNCB MEMGIOBIAOL, [In] NDOHEACPGPP PCFGFDGJOKK, OKCEHHHICPI MADPEPDJMEK, ELDBJIJIODM LDPONPKPEJD, IMHDCOMKJLO NICNDKMHAID, LHJMLODPBMG APEALDLDAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84E48F0", Offset = "0x84E36F0", VA = "0x1884E48F0")]
	private static string CILINHBOLGP(object ALGAKMGCCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	private static long APENGLEGOCO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	private static string NIJMGHJEGOF(string PBHOCHKFEPH, string? FNEAAIJJGGG, bool BFIJNMAIFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	private static bool FBFODIPLFEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84E4930", Offset = "0x84E3730", VA = "0x1884E4930")]
	private static CFONKMMIAGN LDPNHIBAKHG()
	{
		return default(CFONKMMIAGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AMAOPJPGMBF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKPKFEOAEIE MPIMODFPFBE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EKPKFEOAEIE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FCMNOCKJCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBHLDDBJPIN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EDENICGIGJP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHIAFJJKEOB([In] T FGAEAFBDBPK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void EJAABMCJEBI<T>([In] T EIENELGOLAB);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct EHKDCEDMABE<T> : IEquatable<EHKDCEDMABE<T>>, EDENICGIGJP<EHKDCEDMABE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T DDHBFJGPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int NELPMDCEMJE;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB410", Offset = "0x2AFA210", VA = "0x182AFB410")]
	public EHKDCEDMABE([In] T HGMAIPELJHM, int JJJJBEGKNIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A58030", Offset = "0x4A56E30", VA = "0x184A58030")]
	public static bool IKIADGFKNFC([In] EHKDCEDMABE<T> NNEMEIEKIAF, [In] EHKDCEDMABE<T> JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A57950", Offset = "0x4A56750", VA = "0x184A57950", Slot = "4")]
	public bool Equals(EHKDCEDMABE<T> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A579D0", Offset = "0x4A567D0", VA = "0x184A579D0", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A58A60", Offset = "0x4A57860", VA = "0x184A58A60")]
	public bool MHIAFJJKEOB([In] EHKDCEDMABE<T> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A57A50", Offset = "0x4A56850", VA = "0x184A57A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4A59C20", Offset = "0x4A58A20", VA = "0x184A59C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A58C50", Offset = "0x4A57A50", VA = "0x184A58C50")]
	public void MLOAOPFMIPK([Out] T HGMAIPELJHM, [Out] int JJJJBEGKNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A58670", Offset = "0x4A57470", VA = "0x184A58670")]
	public (T, int) JJNAPGGLFJI()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A57FE0", Offset = "0x4A56DE0", VA = "0x184A57FE0", Slot = "5")]
	private bool ICOBEIMHDMH([In] EHKDCEDMABE<T> FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BHKPNJHPLIA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA46A0", Offset = "0x3AA34A0", VA = "0x183AA46A0")]
	public static EHKDCEDMABE<T> ELDPFIHNJDG<T>([In] T HGMAIPELJHM, int JJJJBEGKNIN) where T : notnull
	{
		return default(EHKDCEDMABE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LCJAJMBFGKN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBEBF0", Offset = "0x3DBD9F0", VA = "0x183DBEBF0")]
	public static bool MHIAFJJKEOB<T, U>([In] T DBBEADIHLKO, [In] U ALGAKMGCCLO) where T : notnull, EDENICGIGJP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult OOPHHDMNFJG<T, out TResult>([In] T EIENELGOLAB);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EJDLFJONALM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan JFJNLEABPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? DFJFEJMHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGOFKDGOMGH();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCMIHBBMDDA();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PMKEICCMJHA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ONFEIKMNNCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly AMPAGDLJJPO GJIJJCMLDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly EIHCEJGMHMF OIJEMEHEFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly AMPAGDLJJPO JGFAFHGHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly EIHCEJGMHMF ECCBHHDFOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly AMPAGDLJJPO ONGMMMIGPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EIHCEJGMHMF BHCDCCNKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly DMGNNPPONDH HMLHAHGLPFH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly AMPAGDLJJPO BICBPGODOKH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly EIHCEJGMHMF APPPOOJBDHB;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly AMPAGDLJJPO FCDNPKGLNCI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly EIHCEJGMHMF AEKEAEMEKKB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly AMPAGDLJJPO IKDFEODJICL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly EIHCEJGMHMF LFCKBMIGMIH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly DMGNNPPONDH AGCIDEKGEPG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly ONFEIKMNNCB FBGBKFBLNFL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly AMPAGDLJJPO AINFJDAEPBF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84EF220", Offset = "0x84EE020", VA = "0x1884EF220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xEFA9B0", Offset = "0xEF97B0", VA = "0x180EFA9B0")]
	public ONFEIKMNNCB(AMPAGDLJJPO OONPLBBPPMF, EIHCEJGMHMF EIIDEMNFGLJ, AMPAGDLJJPO DINCJMDJJAP, EIHCEJGMHMF DFCKPAEFCFN, AMPAGDLJJPO OLLMKMONDAG, EIHCEJGMHMF FHDMKGDCNNL, DMGNNPPONDH ENBLGOJOBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	private static bool BPFJDNBJCII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void AFOOJOHBOHA(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	private static bool NGGFEEDLIAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void HEEIKCJCEKB(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	private static bool HMKLCDIHACJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void KCJKHIJKKFK(string JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void NIEKPMIGGMO(Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x84EF0E0", Offset = "0x84EDEE0", VA = "0x1884EF0E0")]
	private static ONFEIKMNNCB LDPNHIBAKHG()
	{
		return default(ONFEIKMNNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
	private static bool IMGMEELICIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x84EEFA0", Offset = "0x84EDDA0", VA = "0x1884EEFA0")]
	public void ICNEBIIBIEE(object JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x84EEDE0", Offset = "0x84EDBE0", VA = "0x1884EEDE0")]
	public void BIIIHHMHNFD(object JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x84EEF30", Offset = "0x84EDD30", VA = "0x1884EEF30")]
	public void DBOKEBLPHBF(object JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xEFB230", Offset = "0xEFA030", VA = "0x180EFB230")]
	public void MPMDOAFMNCC(Exception AACEGADBPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x84EEE50", Offset = "0x84EDC50", VA = "0x1884EEE50")]
	public void DBOKEBLPHBF(HPLMPAMLMJD JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF710", Offset = "0x3EEE510", VA = "0x183EEF710")]
	public void DBOKEBLPHBF<T>(T EIENELGOLAB, POKCOLNKGNE<T> JDFCBBCKOGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF960", Offset = "0x3EEE760", VA = "0x183EEF960")]
	public void ICNEBIIBIEE<T>([In] T EIENELGOLAB, MNKLMGFLJMD<T> JDFCBBCKOGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EEF8A0", Offset = "0x3EEE6A0", VA = "0x183EEF8A0")]
	public void DBOKEBLPHBF<T>([In] T EIENELGOLAB, MNKLMGFLJMD<T> JDFCBBCKOGJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x84EF010", Offset = "0x84EDE10", VA = "0x1884EF010")]
	public bool JGBBCNHGFJF(bool ECNHPJKBPID, string JDFCBBCKOGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct AGDMIFDFONN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string DDHBFJGPDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	public AGDMIFDFONN(string HGMAIPELJHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0")]
	public static string MIDAFINGFAP([In] AGDMIFDFONN DBBEADIHLKO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1487920", Offset = "0x1486720", VA = "0x181487920")]
	public static AGDMIFDFONN MIDAFINGFAP(string FGAEAFBDBPK)
	{
		return default(AGDMIFDFONN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84E35E0", Offset = "0x84E23E0", VA = "0x1884E35E0")]
	public string IAOBONEADGA(string BEBMEOPHIHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84E3500", Offset = "0x84E2300", VA = "0x1884E3500")]
	public string FKEHHFDOLFF(object FFEGLLCDOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xB3C8A0", Offset = "0xB3B6A0", VA = "0x180B3C8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class ALDAICPKDJG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public ALDAICPKDJG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct GFJAPJIFDGB : IEquatable<GFJAPJIFDGB>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "4")]
	public bool Equals(GFJAPJIFDGB FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x84EA6E0", Offset = "0x84E94E0", VA = "0x1884EA6E0", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84EA730", Offset = "0x84E9530", VA = "0x1884EA730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84EA740", Offset = "0x84E9540", VA = "0x1884EA740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HAJDBGJJAAE("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KJAHANGMDME<T> : IEquatable<KJAHANGMDME<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T DDHBFJGPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool OOHNHCJCPCA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NJPMFKAFFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55E9980", Offset = "0x55E8780", VA = "0x1855E9980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x55EA350", Offset = "0x55E9150", VA = "0x1855EA350")]
	public KJAHANGMDME([In] T HGMAIPELJHM, bool NOJPLPCECFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x55E9390", Offset = "0x55E8190", VA = "0x1855E9390")]
	public static bool IKIADGFKNFC([In] KJAHANGMDME<T> NNEMEIEKIAF, [In] KJAHANGMDME<T> JOGLOLMOJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x55E7F50", Offset = "0x55E6D50", VA = "0x1855E7F50", Slot = "4")]
	public bool Equals(KJAHANGMDME<T> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x55E8270", Offset = "0x55E7070", VA = "0x1855E8270", Slot = "0")]
	public override bool Equals(object? FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x55E8E10", Offset = "0x55E7C10", VA = "0x1855E8E10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55E9F40", Offset = "0x55E8D40", VA = "0x1855E9F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HADLKKABBNL
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D09D00", Offset = "0x3D08B00", VA = "0x183D09D00")]
	public static KJAHANGMDME<T> BNNMHKGLOBH<T>([In] T HGMAIPELJHM) where T : notnull
	{
		return default(KJAHANGMDME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A150", Offset = "0x3D08F50", VA = "0x183D0A150")]
	public static KJAHANGMDME<T?> ONCCDGFJJML<T>()
	{
		return default(KJAHANGMDME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D09E40", Offset = "0x3D08C40", VA = "0x183D09E40")]
	public static bool INPICBAMBFE<T>([In] this KJAHANGMDME<T> MBONEAMOJLE, [Out][NotNullWhen(true)] T HGMAIPELJHM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D09DD0", Offset = "0x3D08BD0", VA = "0x183D09DD0")]
	public static bool INPICBAMBFE<T>([In] this KJAHANGMDME<T> MBONEAMOJLE, [Out][NotNullWhen(true)] T HGMAIPELJHM, [Out] KJAHANGMDME<T> NCJLDBCONMG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D09FB0", Offset = "0x3D08DB0", VA = "0x183D09FB0")]
	public static T? KNPBBOCDNCF<T>([In] this KJAHANGMDME<T> MBONEAMOJLE, T? PGFMONBPOJI)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D09E70", Offset = "0x3D08C70", VA = "0x183D09E70")]
	public static bool JADFFOFPMCL<T>([In] this KJAHANGMDME<T> MBONEAMOJLE, T HGMAIPELJHM) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NGABMPCPMDP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E74530", Offset = "0x3E73330", VA = "0x183E74530")]
	public static T JFDGFOHEJHI<T>([In] this KJAHANGMDME<T> MBONEAMOJLE) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NDOHEACPGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr AIFKGMNDOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr LGIPHBDFKAD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr EJNCNIGJBLH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr BGCPOKAGCFA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NDOHEACPGPP FBGBKFBLNFL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool MJLOMDJHNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84EE870", Offset = "0x84ED670", VA = "0x1884EE870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	public NDOHEACPGPP(IntPtr KBPBNPKIAJP, IntPtr NIDFBDKDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void PGLGIPEPGKC(string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void ICALOKPBHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x84EE7E0", Offset = "0x84ED5E0", VA = "0x1884EE7E0")]
	private static NDOHEACPGPP LDPNHIBAKHG()
	{
		return default(NDOHEACPGPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct LJIKKDACPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr PHJHEKOCPAJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x13D6BB0", Offset = "0x13D59B0", VA = "0x1813D6BB0")]
	private LJIKKDACPLA(IntPtr NIDFBDKDHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x84EDB60", Offset = "0x84EC960", VA = "0x1884EDB60")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84EDA90", Offset = "0x84EC890", VA = "0x1884EDA90")]
	public static LJIKKDACPLA ELDPFIHNJDG(string PFLDDMDPCBI)
	{
		return default(LJIKKDACPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD820", Offset = "0x2ACC620", VA = "0x182ACD820")]
	public static LJIKKDACPLA ELDPFIHNJDG([In] NDOHEACPGPP PCFGFDGJOKK, string PFLDDMDPCBI)
	{
		return default(LJIKKDACPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2ACD2C0", Offset = "0x2ACC0C0", VA = "0x182ACD2C0")]
	public static LJIKKDACPLA ELDPFIHNJDG([In] NDOHEACPGPP PCFGFDGJOKK, Func<string> PFLDDMDPCBI)
	{
		return default(LJIKKDACPLA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KPFLPJELIII : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? DCLHJOFPFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr EAABAHAFBAB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool CCMIODHMNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x84ED640", Offset = "0x84EC440", VA = "0x1884ED640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84ED920", Offset = "0x84EC720", VA = "0x1884ED920")]
	public static SHA256 INIHOJCCLPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x84ED2F0", Offset = "0x84EC0F0", VA = "0x1884ED2F0")]
	private static extern int BDMEHOHHLDE();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84ED540", Offset = "0x84EC340", VA = "0x1884ED540")]
	private static extern IntPtr CLDFEPMNKAM();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84ED360", Offset = "0x84EC160", VA = "0x1884ED360")]
	private static extern void BKNJNHMBAHI(IntPtr EAABAHAFBAB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84ED480", Offset = "0x84EC280", VA = "0x1884ED480")]
	private static extern void CKBMCJGDHIL(IntPtr EAABAHAFBAB, byte[] KANAIIDGHCH, int IBOFMHFOKKF, int MCDAGMKGPKP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84ED3E0", Offset = "0x84EC1E0", VA = "0x1884ED3E0")]
	private static extern void BMANGJEBKEI(IntPtr EAABAHAFBAB, byte[] EIAHDCPNNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84EDA60", Offset = "0x84EC860", VA = "0x1884EDA60")]
	private KPFLPJELIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84ED730", Offset = "0x84EC530", VA = "0x1884ED730", Slot = "18")]
	protected override void HashCore(byte[] ELLFIONNNHC, int DLKNAFCDBKC, int INKCBACEJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84ED7F0", Offset = "0x84EC5F0", VA = "0x1884ED7F0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84ED9A0", Offset = "0x84EC7A0", VA = "0x1884ED9A0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84ED5B0", Offset = "0x84EC3B0", VA = "0x1884ED5B0", Slot = "13")]
	protected override void Dispose(bool FLPNGMCKDML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CLJHDHOJMDG
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool LGPPNGGEENL<in TInput, TResult>(TInput DANFKLEPBNF, [Out] TResult MOBFLOHJOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class HADJECBCNCP : AMAOPJPGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class OAMOIJOKFNM : EKPKFEOAEIE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly OAMOIJOKFNM MOIOIMEFPHA;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool FCMNOCKJCIK
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x84EEBC0", Offset = "0x84ED9C0", VA = "0x1884EEBC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x84EEC20", Offset = "0x84EDA20", VA = "0x1884EEC20", Slot = "6")]
			public void OnCompleted(Action JGIIFIKIOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			public void PBHLDDBJPIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public OAMOIJOKFNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly HADJECBCNCP MOIOIMEFPHA;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		private HADJECBCNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84EB1A0", Offset = "0x84E9FA0", VA = "0x1884EB1A0", Slot = "4")]
		public EKPKFEOAEIE MPIMODFPFBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class NKDPJMKIPBF : AMAOPJPGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class CNLCDMOHLMM : EKPKFEOAEIE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly CNLCDMOHLMM MOIOIMEFPHA;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool FCMNOCKJCIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x84E7660", Offset = "0x84E6460", VA = "0x1884E7660", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84E7680", Offset = "0x84E6480", VA = "0x1884E7680", Slot = "6")]
			public void OnCompleted(Action JGIIFIKIOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			public void PBHLDDBJPIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public CNLCDMOHLMM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly NKDPJMKIPBF MOIOIMEFPHA;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		private NKDPJMKIPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA80", Offset = "0x84ED880", VA = "0x1884EEA80", Slot = "4")]
		public EKPKFEOAEIE MPIMODFPFBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GNABCHBCHNN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GNABCHBCHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x500D380", Offset = "0x500C180", VA = "0x18500D380")]
		internal void CCKCJLCDHMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BOBNJPHNLOM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BOBNJPHNLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5AC0150", Offset = "0x5ABEF50", VA = "0x185AC0150")]
		internal void IPHIEEFFLNM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DBCCFKFPNIH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84E7740", Offset = "0x84E6540", VA = "0x1884E7740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MOKBMMKALFA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x84EDE20", Offset = "0x84ECC20", VA = "0x1884EDE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NMOMFCFOHAI<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x59AC0C0", Offset = "0x59AAEC0", VA = "0x1859AC0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x59AC230", Offset = "0x59AB030", VA = "0x1859AC230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct LKMMBNOGKOP<T> : IAsyncStateMachine where T : notnull
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
		public ALMLLDBPKBM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x56999A0", Offset = "0x56987A0", VA = "0x1856999A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5699DC0", Offset = "0x5698BC0", VA = "0x185699DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KPBOCJBPPLC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x55FCD80", Offset = "0x55FBB80", VA = "0x1855FCD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x55FD5F0", Offset = "0x55FC3F0", VA = "0x1855FD5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MINCKDPBBLP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84EDBA0", Offset = "0x84EC9A0", VA = "0x1884EDBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x84EDDB0", Offset = "0x84ECBB0", VA = "0x1884EDDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KFHBAFLONNP<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KFHBAFLONNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x500D380", Offset = "0x500C180", VA = "0x18500D380")]
		internal void FAPIOANNAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x55D1A00", Offset = "0x55D0800", VA = "0x1855D1A00")]
		internal void JJIGOFGFKJD(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NINBIJNPGGB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public LGPPNGGEENL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5986790", Offset = "0x5985590", VA = "0x185986790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5986E80", Offset = "0x5985C80", VA = "0x185986E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GBGCGMCNOIO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x84E9E90", Offset = "0x84E8C90", VA = "0x1884E9E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84EA680", Offset = "0x84E9480", VA = "0x1884EA680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct APCKFMPNGCD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x84E36A0", Offset = "0x84E24A0", VA = "0x1884E36A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x84E3BE0", Offset = "0x84E29E0", VA = "0x1884E3BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct HPKLJEMIEHG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x513DBA0", Offset = "0x513C9A0", VA = "0x18513DBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x513EB00", Offset = "0x513D900", VA = "0x18513EB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class DCAOAGDPGDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<GFJAPJIFDGB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DCAOAGDPGDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x84E78A0", Offset = "0x84E66A0", VA = "0x1884E78A0")]
		internal void CCODCOGPBNB(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BNIOLAGOFFE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x84E3CA0", Offset = "0x84E2AA0", VA = "0x1884E3CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84E3F20", Offset = "0x84E2D20", VA = "0x1884E3F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BCBJFIODMOO<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x65FF4A0", Offset = "0x65FE2A0", VA = "0x1865FF4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x44FC510", Offset = "0x44FB310", VA = "0x1844FC510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LEENELOJGEE<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x56834F0", Offset = "0x56822F0", VA = "0x1856834F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x44FB5C0", Offset = "0x44FA3C0", VA = "0x1844FB5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct CMNMOIAOOIL<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6C777A0", Offset = "0x6C765A0", VA = "0x186C777A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C77FB0", Offset = "0x6C76DB0", VA = "0x186C77FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DGCCHOAAINO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x84E7FB0", Offset = "0x84E6DB0", VA = "0x1884E7FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84E8190", Offset = "0x84E6F90", VA = "0x1884E8190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DKCIAHLEDMJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84E8370", Offset = "0x84E7170", VA = "0x1884E8370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84E86D0", Offset = "0x84E74D0", VA = "0x1884E86D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JILADOGLHFI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x84ECBA0", Offset = "0x84EB9A0", VA = "0x1884ECBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x84ECE90", Offset = "0x84EBC90", VA = "0x1884ECE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class ILHIKJGKMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ILHIKJGKMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC3E0", Offset = "0x84EB1E0", VA = "0x1884EC3E0")]
		internal Task MIFLLBGOEAE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct ONPMNOHKMMD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x84EF9B0", Offset = "0x84EE7B0", VA = "0x1884EF9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x84EFC10", Offset = "0x84EEA10", VA = "0x1884EFC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GGNJBFCHPHH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x84EACA0", Offset = "0x84E9AA0", VA = "0x1884EACA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84EAE80", Offset = "0x84E9C80", VA = "0x1884EAE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct DFCIJDNHFJD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x84E79B0", Offset = "0x84E67B0", VA = "0x1884E79B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84E7D10", Offset = "0x84E6B10", VA = "0x1884E7D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GFKNJMOHPNL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x84EA950", Offset = "0x84E9750", VA = "0x1884EA950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x84EAC40", Offset = "0x84E9A40", VA = "0x1884EAC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JOCECHLMNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JOCECHLMNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x84ECEF0", Offset = "0x84EBCF0", VA = "0x1884ECEF0")]
		internal Task KJLPLGKKNDG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct GKKLGAGPEEP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84EAEE0", Offset = "0x84E9CE0", VA = "0x1884EAEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x84EB140", Offset = "0x84E9F40", VA = "0x1884EB140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GFKIFNFJBCA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84EA770", Offset = "0x84E9570", VA = "0x1884EA770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84EA8F0", Offset = "0x84E96F0", VA = "0x1884EA8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct FBCAAEPFGGA<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4EED050", Offset = "0x4EEBE50", VA = "0x184EED050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4EED310", Offset = "0x4EEC110", VA = "0x184EED310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct KNDGHKDFJNH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x84ECF60", Offset = "0x84EBD60", VA = "0x1884ECF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84ED290", Offset = "0x84EC090", VA = "0x1884ED290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? KOMHIGHDBFP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<GFJAPJIFDGB> KNCGJNPOCPN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task IODJHHLJMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x84E71B0", Offset = "0x84E5FB0", VA = "0x1884E71B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x84E6800", Offset = "0x84E5600", VA = "0x1884E6800")]
	public static bool KNGMJPHNCHO(this Task MGEGHBBNKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3B12BA0", Offset = "0x3B119A0", VA = "0x183B12BA0")]
	public static Task<T> NGEHHJMGMFK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84E5330", Offset = "0x84E4130", VA = "0x1884E5330")]
	public static Task AEFBAOANINK(this Task MGEGHBBNKMN, CancellationToken OBGCPOCPFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3B10510", Offset = "0x3B0F310", VA = "0x183B10510")]
	public static Task<TResult> AEFBAOANINK<TResult>(this Task<TResult> MGEGHBBNKMN, CancellationToken OBGCPOCPFIJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E200", Offset = "0x3B0D000", VA = "0x183B0E200")]
	public static TaskCompletionSource<TResult> AEFBAOANINK<TResult>(this TaskCompletionSource<TResult> CFGBMPECECB, CancellationToken OBGCPOCPFIJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84E5F90", Offset = "0x84E4D90", VA = "0x1884E5F90")]
	public static IDisposable? HDGNOINHEPO(CancellationToken DEIFKHMGICF, CancellationToken JHABPMJOGDL, [Out] CancellationToken JAHNCPKIKMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x84E7220", Offset = "0x84E6020", VA = "0x1884E7220")]
	[AsyncStateMachine(typeof(DBCCFKFPNIH))]
	public static void NHLBAEKCGCD(this Task DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84E5BD0", Offset = "0x84E49D0", VA = "0x1884E5BD0")]
	[AsyncStateMachine(typeof(MOKBMMKALFA))]
	public static void EPOAIOPIKNN(this Task DDCPKPIHIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B12250", Offset = "0x3B11050", VA = "0x183B12250")]
	[AsyncStateMachine(typeof(NMOMFCFOHAI<>))]
	public static Task HGHHEAAJBGM<TException>(this Task DDCPKPIHIOM) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B12A80", Offset = "0x3B11880", VA = "0x183B12A80")]
	[AsyncStateMachine(typeof(LKMMBNOGKOP<>))]
	public static Task<T> JBPGCNLCDIM<T>(this Task<T> DBBEADIHLKO, ALMLLDBPKBM IPEKLICENHF, Func<Task<T>, string> BEHAEONAHPD, bool PNPJIDLOCOP = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B128C0", Offset = "0x3B116C0", VA = "0x183B128C0")]
	[AsyncStateMachine(typeof(KPBOCJBPPLC<>))]
	public static Task<T> JBPGCNLCDIM<T>(this Task<T> DBBEADIHLKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84E5C80", Offset = "0x84E4A80", VA = "0x1884E5C80")]
	[AsyncStateMachine(typeof(MINCKDPBBLP))]
	public static Task<TaskStatus> GCBPLJNPNJN(this Task? DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B11D30", Offset = "0x3B10B30", VA = "0x183B11D30")]
	public static (Task<T?>?, Action<T?>?) FGOLIFIDABE<T>([Optional] CancellationToken BKHGNHANFKK)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B12150", Offset = "0x3B10F50", VA = "0x183B12150")]
	[AsyncStateMachine(typeof(NINBIJNPGGB<, >))]
	public static Task<List<TResult>> HEABFGFGKDD<TResult, TInput>(this Task<List<TInput>> MGEGHBBNKMN, LGPPNGGEENL<TInput, TResult> HGMJDFHFHEA) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84E5D70", Offset = "0x84E4B70", VA = "0x1884E5D70")]
	[AsyncStateMachine(typeof(GBGCGMCNOIO))]
	public static Task GJFNDOGOKNO(Task DDCPKPIHIOM, CancellationToken EGDCEEDDFBN, Func<CancellationToken, Task> DKFIDJHBLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84E5580", Offset = "0x84E4380", VA = "0x1884E5580")]
	[AsyncStateMachine(typeof(APCKFMPNGCD))]
	public static Task AGAPJOHKFGJ(Func<CancellationToken, Task> KAHFPEFBKKA, TimeSpan BCGOOMJHCJF, [Optional] CancellationToken EGDCEEDDFBN, [Optional] Action<OperationCanceledException>? HOIDOMNAJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B11AD0", Offset = "0x3B108D0", VA = "0x183B11AD0")]
	[AsyncStateMachine(typeof(HPKLJEMIEHG<>))]
	public static Task<T> AGAPJOHKFGJ<T>(Func<CancellationToken, Task<T>> KAHFPEFBKKA, TimeSpan BCGOOMJHCJF, [Optional] CancellationToken EGDCEEDDFBN, [Optional] Func<OperationCanceledException, T>? HOIDOMNAJIK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84E6220", Offset = "0x84E5020", VA = "0x1884E6220")]
	public static Task JFOLDIIFJCP(params Task[] IDOIFJCJKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84E6270", Offset = "0x84E5070", VA = "0x1884E6270")]
	public static Task JFOLDIIFJCP(IEnumerable<Task> IDOIFJCJKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84E6120", Offset = "0x84E4F20", VA = "0x1884E6120")]
	[AsyncStateMachine(typeof(BNIOLAGOFFE))]
	public static Task<IEnumerable<Task>> IPGEGHCJCEM(IEnumerable<Task> IDOIFJCJKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B127E0", Offset = "0x3B115E0", VA = "0x183B127E0")]
	[AsyncStateMachine(typeof(BCBJFIODMOO<>))]
	public static Task<IEnumerable<Task<T>>> IPGEGHCJCEM<T>(IEnumerable<Task<T>> IDOIFJCJKJG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B125E0", Offset = "0x3B113E0", VA = "0x183B125E0")]
	[AsyncStateMachine(typeof(LEENELOJGEE<, , >))]
	public static Task<(T1, T2, T3)> IDDFCDLJABG<T1, T2, T3>(Task<T1> GHPDKNBPOPM, Task<T2> EGLEAAPLCMD, Task<T3> AGMGPADCJNL) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B12320", Offset = "0x3B11120", VA = "0x183B12320")]
	[AsyncStateMachine(typeof(CMNMOIAOOIL<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> IDDFCDLJABG<T1, T2, T3, T4, T5>(Task<T1> GHPDKNBPOPM, Task<T2> EGLEAAPLCMD, Task<T3> AGMGPADCJNL, Task<T4> GPDEFANFODG, Task<T5> IHDGFBCDJJM) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84E6990", Offset = "0x84E5790", VA = "0x1884E6990")]
	[AsyncStateMachine(typeof(DGCCHOAAINO))]
	public static Task LKEHIEJAAGP(Func<bool> ECNHPJKBPID, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84E6880", Offset = "0x84E5680", VA = "0x1884E6880")]
	[AsyncStateMachine(typeof(DKCIAHLEDMJ))]
	public static Task LKEHIEJAAGP(Func<bool> ECNHPJKBPID, TimeSpan LOAPMICPNNO, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84E6CF0", Offset = "0x84E5AF0", VA = "0x1884E6CF0")]
	[AsyncStateMachine(typeof(JILADOGLHFI))]
	public static Task LNKNOJFODPN(Func<bool> ECNHPJKBPID, TimeSpan BCGOOMJHCJF, [Optional] CancellationToken BKHGNHANFKK, [Optional] Action<OperationCanceledException>? HOIDOMNAJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84E6E20", Offset = "0x84E5C20", VA = "0x1884E6E20")]
	[AsyncStateMachine(typeof(ONPMNOHKMMD))]
	public static Task LNKNOJFODPN(Func<bool> ECNHPJKBPID, TimeSpan BCGOOMJHCJF, TimeSpan LOAPMICPNNO, [Optional] CancellationToken BKHGNHANFKK, [Optional] Action<OperationCanceledException>? HOIDOMNAJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84E7320", Offset = "0x84E6120", VA = "0x1884E7320")]
	[AsyncStateMachine(typeof(GGNJBFCHPHH))]
	public static Task PCEGKLKKBCF(Func<bool> ECNHPJKBPID, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84E7410", Offset = "0x84E6210", VA = "0x1884E7410")]
	[AsyncStateMachine(typeof(DFCIJDNHFJD))]
	public static Task PCEGKLKKBCF(Func<bool> ECNHPJKBPID, TimeSpan LOAPMICPNNO, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84E6BC0", Offset = "0x84E59C0", VA = "0x1884E6BC0")]
	[AsyncStateMachine(typeof(GFKNJMOHPNL))]
	public static Task LKOABHACCNC(Func<bool> ECNHPJKBPID, TimeSpan BCGOOMJHCJF, [Optional] CancellationToken BKHGNHANFKK, [Optional] Action<OperationCanceledException>? HOIDOMNAJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x84E6A80", Offset = "0x84E5880", VA = "0x1884E6A80")]
	[AsyncStateMachine(typeof(GKKLGAGPEEP))]
	public static Task LKOABHACCNC(Func<bool> ECNHPJKBPID, TimeSpan BCGOOMJHCJF, TimeSpan LOAPMICPNNO, [Optional] CancellationToken BKHGNHANFKK, [Optional] Action<OperationCanceledException>? HOIDOMNAJIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84E5EA0", Offset = "0x84E4CA0", VA = "0x1884E5EA0")]
	[AsyncStateMachine(typeof(GFKIFNFJBCA))]
	[Obsolete]
	public static Task HABELCEEGCL(this Task MGEGHBBNKMN, Action DOEJOMLICNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3B11F70", Offset = "0x3B10D70", VA = "0x183B11F70")]
	[AsyncStateMachine(typeof(FBCAAEPFGGA<>))]
	[Obsolete]
	public static Task HABELCEEGCL<T>(this Task<T> MGEGHBBNKMN, Action<T> DOEJOMLICNF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84E57C0", Offset = "0x84E45C0", VA = "0x1884E57C0")]
	private static void CLHIKMACLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84E5870", Offset = "0x84E4670", VA = "0x1884E5870")]
	public static bool EIDLPDINMGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84E7030", Offset = "0x84E5E30", VA = "0x1884E7030")]
	private static void MOJGHMDBIGP(SynchronizationContext HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84E56B0", Offset = "0x84E44B0", VA = "0x1884E56B0")]
	private static void CHAMOBHLCJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x84E6F60", Offset = "0x84E5D60", VA = "0x1884E6F60")]
	public static void MMDJPAJJJED([Optional] string? JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84E7520", Offset = "0x84E6320", VA = "0x1884E7520")]
	public static void PHHGEFIGGEE([Optional] string? JDFCBBCKOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84E6830", Offset = "0x84E5630", VA = "0x1884E6830")]
	public static AMAOPJPGMBF LCHPPAMALBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84E72D0", Offset = "0x84E60D0", VA = "0x1884E72D0")]
	public static AMAOPJPGMBF NMJDFMOMGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x84E6730", Offset = "0x84E5530", VA = "0x1884E6730")]
	[AsyncStateMachine(typeof(KNDGHKDFJNH))]
	public static Task KAEMOKKMFPG(Func<Task> OHHICGADAKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CMNOLHHFBOP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public CMNOLHHFBOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DFGJFEEMEFH
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x84E7E90", Offset = "0x84E6C90", VA = "0x1884E7E90")]
	public static bool JOBPFEGCKDJ(this BKDMPJHFGEA NFKAINNHNEK, DateTime EGMNHJPGHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x84E7D70", Offset = "0x84E6B70", VA = "0x1884E7D70")]
	public static TimeSpan GGNEALKOAMC(this BKDMPJHFGEA NFKAINNHNEK, DateTime EGMNHJPGHHB)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PBIGPJHPIBH : BKDMPJHFGEA
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly BKDMPJHFGEA MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime LPKBGNGFCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84EFC70", Offset = "0x84EEA70", VA = "0x1884EFC70", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset GKKKGKEBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x84EFCB0", Offset = "0x84EEAB0", VA = "0x1884EFCB0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public PBIGPJHPIBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface BKDMPJHFGEA
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime LPKBGNGFCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset GKKKGKEBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class HKCLPMBKODK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long BDCCKNAOGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x84EBED0", Offset = "0x84EACD0", VA = "0x1884EBED0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long MCAMDPNNJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x84EBBC0", Offset = "0x84EA9C0", VA = "0x1884EBBC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double ONOAGLBPJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x84EBDE0", Offset = "0x84EABE0", VA = "0x1884EBDE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double EPBPJFEGGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84EBC10", Offset = "0x84EAA10", VA = "0x1884EBC10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double GGIMEDIIHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC080", Offset = "0x84EAE80", VA = "0x1884EC080")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double EFNNFKODENA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84EBB70", Offset = "0x84EA970", VA = "0x1884EBB70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x84EBF20", Offset = "0x84EAD20", VA = "0x1884EBF20")]
	public static double MKNIIAIEAEM(long HPHKHPIEAJC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x84EBCF0", Offset = "0x84EAAF0", VA = "0x1884EBCF0")]
	public static double GNMAHPPIOIC(long HPHKHPIEAJC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x84EBE40", Offset = "0x84EAC40", VA = "0x1884EBE40")]
	public static double LKJPHGKDCBJ(double KLKKMAIGHAC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x84EBC60", Offset = "0x84EAA60", VA = "0x1884EBC60")]
	public static long GMCEIKPLGEB(long KBODPDIPNAF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x84EBE30", Offset = "0x84EAC30", VA = "0x1884EBE30")]
	public static long KJINKFNJDON(long OMFMINPLHHE, long POOCCBJDNFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x84EBFB0", Offset = "0x84EADB0", VA = "0x1884EBFB0")]
	public static double OHGPNOLJLPM(long OMFMINPLHHE, long POOCCBJDNFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x84EBD80", Offset = "0x84EAB80", VA = "0x1884EBD80")]
	public static double IEEGHAAMHMB(long OMFMINPLHHE, long POOCCBJDNFD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class MPDHAANFGDI : EJDLFJONALM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan CELHMCGOLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer CIEPDNOLKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan BCGOOMJHCJF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan JFJNLEABPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x84EE100", Offset = "0x84ECF00", VA = "0x1884EE100", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? DFJFEJMHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x84EE530", Offset = "0x84ED330", VA = "0x1884EE530")]
	[Preserve]
	public MPDHAANFGDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x84EE590", Offset = "0x84ED390", VA = "0x1884EE590")]
	public MPDHAANFGDI(TimeSpan BCGOOMJHCJF, [Optional] Action? NMGGOJGCDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x84EE260", Offset = "0x84ED060", VA = "0x1884EE260", Slot = "7")]
	public void DGOFKDGOMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x84EE390", Offset = "0x84ED190", VA = "0x1884EE390", Slot = "8")]
	public void HCMIHBBMDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x84EE490", Offset = "0x84ED290", VA = "0x1884EE490", Slot = "9")]
	public void PMKEICCMJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x13091E0", Offset = "0x1307FE0", VA = "0x1813091E0")]
	private void MHGKNDNDLKN(object OGPILIPEPKA, ElapsedEventArgs LPALLJHCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x84EE400", Offset = "0x84ED200", VA = "0x1884EE400")]
	private static void NHFEJBMMBAL(TimeSpan FIOCPNIKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x84EE2F0", Offset = "0x84ED0F0", VA = "0x1884EE2F0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HAJDBGJJAAE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? PKAGMDJPJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string LPOBFFEBNKG;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1991BD0", Offset = "0x19909D0", VA = "0x181991BD0")]
	public HAJDBGJJAAE(string CDEPGINEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5562070", Offset = "0x5560E70", VA = "0x185562070")]
	public HAJDBGJJAAE(string MIBLFIHKNOI, string CDEPGINEGKG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct FHLAGALJACB : IEquatable<FHLAGALJACB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint GMICOBICPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int GOMKLDHPGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float MHKDBMABKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort APLBHGOPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort FJPHEHFADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short NOGGMMFHKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short LNOINPJPNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char LNEFBPHMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char EHFNMIEKPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte BDFEBKAKCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte EDJHJBMDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte ELOBBCAKFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte IMLNIFEKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool KBMMCKGKGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool IIDPMPDMEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool CECFPBFAPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool CKBPCGGKNBB;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x21697C0", Offset = "0x21685C0", VA = "0x1821697C0")]
	public static FHLAGALJACB HONLMEIHFEO(uint GMOKBGMIJNN)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x21697C0", Offset = "0x21685C0", VA = "0x1821697C0")]
	public static FHLAGALJACB NJDMLLHNJDE(int PHJFCOKPIBC)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x84E89C0", Offset = "0x84E77C0", VA = "0x1884E89C0")]
	public static FHLAGALJACB HGKMAKHOLGC(float HIOINDEMDEL)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x84E8920", Offset = "0x84E7720", VA = "0x1884E8920")]
	public static FHLAGALJACB LAOHOGKAHKI(byte AMMPFIMJPJP, byte PLHADJCIFFH, byte OFFJOHCIKNB, byte OIAKJLPIHHC)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x84E8920", Offset = "0x84E7720", VA = "0x1884E8920")]
	public static FHLAGALJACB LCLMBAACLND(bool OLIHMIMMOEL, bool ILMNDJDKFEB, bool KOIBIIPGLEI, bool AFHGMAMHGAM)
	{
		return default(FHLAGALJACB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x84E8920", Offset = "0x84E7720", VA = "0x1884E8920")]
	public static FHLAGALJACB AIBGHPFONKO(byte MHNAIBMFFKE, byte HOGJKIHBIGO, byte AEELAKAALNF, byte DJPJEJGIMFF)
	{
		return default(FHLAGALJACB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x24B4D10", Offset = "0x24B3B10", VA = "0x1824B4D10")]
	public static bool IKIADGFKNFC(FHLAGALJACB CHAEOFDBIAH, FHLAGALJACB EBEGEKLHGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C10", Offset = "0x24B3A10", VA = "0x1824B4C10", Slot = "4")]
	public bool Equals(FHLAGALJACB FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x84E8940", Offset = "0x84E7740", VA = "0x1884E8940", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x15A02B0", Offset = "0x159F0B0", VA = "0x1815A02B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x84E89D0", Offset = "0x84E77D0", VA = "0x1884E89D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FGEOEEDFJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong LMOFIOBLAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long KGGPIJEFHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double IBOLCJEGJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint PLOBICNJJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint NPEFHIHGJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int GJIBLCCENAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int EOMAIDHFDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float NIDDFKAKENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float PHINDNPOCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort APLBHGOPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort FJPHEHFADFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort GNIIHIIDDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort CMEELFHALCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short NOGGMMFHKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short LNOINPJPNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short LPNNEHHGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short EJONDPNFHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char LNEFBPHMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char EHFNMIEKPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char LEHILDHPKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char OEMECCMHIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte BDFEBKAKCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte EDJHJBMDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte ELOBBCAKFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte IMLNIFEKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte GLHEEJLMECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte EPNBOFKMIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte FFOJCGOAGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte HNEBGMAELGK;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static FGEOEEDFJGE ELDPFIHNJDG(long DLDEFLLKMOE)
	{
		return default(FGEOEEDFJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x84E88D0", Offset = "0x84E76D0", VA = "0x1884E88D0")]
	public static FGEOEEDFJGE ELDPFIHNJDG(byte AMMPFIMJPJP, byte PLHADJCIFFH, byte OFFJOHCIKNB, byte OIAKJLPIHHC, byte EFDGCPIDOPC, byte IKGILKKMJBG, byte HIPMFIOHIJJ, byte BGNLIOMIIOL)
	{
		return default(FGEOEEDFJGE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PGOPELFACKP : IEquatable<PGOPELFACKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte AMEAJPGJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool GONNGMGIDKE;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x320E0D0", Offset = "0x320CED0", VA = "0x18320E0D0")]
	public static PGOPELFACKP LAOHOGKAHKI(byte PHCKIMAPAKB)
	{
		return default(PGOPELFACKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x320E0D0", Offset = "0x320CED0", VA = "0x18320E0D0")]
	public static PGOPELFACKP LCLMBAACLND(bool IOCGGJPDOAL)
	{
		return default(PGOPELFACKP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x84EFE20", Offset = "0x84EEC20", VA = "0x1884EFE20")]
	public static bool IKIADGFKNFC(PGOPELFACKP CHAEOFDBIAH, PGOPELFACKP EBEGEKLHGJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x73A44A0", Offset = "0x73A32A0", VA = "0x1873A44A0", Slot = "4")]
	public bool Equals(PGOPELFACKP FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x84EFD80", Offset = "0x84EEB80", VA = "0x1884EFD80", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84EFE10", Offset = "0x84EEC10", VA = "0x1884EFE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x84EFE30", Offset = "0x84EEC30", VA = "0x1884EFE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JPANJAMFILH<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T FFLPIGMGMNE;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x54BD250", Offset = "0x54BC050", VA = "0x1854BD250")]
	public JPANJAMFILH(T CHOGLBHDINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class HJKOAEIHFIK
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3D28C00", Offset = "0x3D27A00", VA = "0x183D28C00")]
	public static IEnumerable<T> OADLHOAHGAO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static T[] EJJJAHOOCJK<T>(params T[] DNDDFBPHLOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static IEnumerable<T> PFCMDOJLDID<T>(params T[] DNDDFBPHLOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static HashSet<T> ONICLPGPMPN<T>(params T[] DNDDFBPHLOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3D28B10", Offset = "0x3D27910", VA = "0x183D28B10")]
	public static KeyValuePair<TKey, TValue> AIECJGOBIGA<TKey, TValue>([In] TKey OPGJHIOADCK, [In] TValue HGMAIPELJHM) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5C50", Offset = "0x3AA4A50", VA = "0x183AA5C50")]
	public static List<T> LFPIKIBCDJF<T>(IEnumerable<T> LJHCADEPBBK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MLDAJLFIAMI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string JJEEBNOEAMF;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
	public MLDAJLFIAMI(string AMOBAKBDGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object MNKLMGFLJMD<T>([In] T NPIEBNDMCBK);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object POKCOLNKGNE<T>(T NPIEBNDMCBK);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[ALOHAELMFGA]
public delegate string IMHDCOMKJLO(string PBHOCHKFEPH, string? FNEAAIJJGGG, bool BFIJNMAIFGJ);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[ALOHAELMFGA]
public delegate void EIHCEJGMHMF(string JDFCBBCKOGJ);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[ALOHAELMFGA]
public delegate void DMGNNPPONDH(Exception AACEGADBPKH);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object HPLMPAMLMJD();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[ALOHAELMFGA]
public delegate bool AMPAGDLJJPO();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[ALOHAELMFGA]
public delegate string OKCEHHHICPI(object ALGAKMGCCLO);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class MKGCOOJGDCN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
	public MKGCOOJGDCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class JCEEHBOBMAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct CFFJIBGOPHC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x84E3F90", Offset = "0x84E2D90", VA = "0x1884E3F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x84E4880", Offset = "0x84E3680", VA = "0x1884E4880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback CBKANFGKELO;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> HMLNCNHFHBG;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x84EC5E0", Offset = "0x84EB3E0", VA = "0x1884EC5E0")]
	public static Task<bool> ECGPANFLJOF(int OPPMONPODEF, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x84EC8E0", Offset = "0x84EB6E0", VA = "0x1884EC8E0")]
	[AsyncStateMachine(typeof(CFFJIBGOPHC))]
	private static Task<bool> LCNGIFAKAGI(int OPPMONPODEF, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x84EC550", Offset = "0x84EB350", VA = "0x1884EC550")]
	private static void BMBBDDFECPK(object? GKGDEKNIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x84ECA10", Offset = "0x84EB810", VA = "0x1884ECA10")]
	private static void PCNHBNKANNI(object? GKGDEKNIOCH)
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
