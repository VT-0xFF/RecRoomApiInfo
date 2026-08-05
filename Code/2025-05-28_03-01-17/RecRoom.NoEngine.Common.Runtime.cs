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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F01810", Offset = "0x7F00610", VA = "0x187F01810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ELCLJMHHCKK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8650", Offset = "0x7EF7450", VA = "0x187EF8650")]
	public static string KFPCOCNPCHK(this Encoding ENPPHAHHLDM, [In] ReadOnlySequence<byte> HNAKMABCJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x377AA10", Offset = "0x3779810", VA = "0x18377AA10")]
	private static void ELDJJLAAGDC<T>(this ReadOnlySequence<T> ABOPFECFFGC, [Out] ReadOnlySpan<T> FHCGJGBDMPL, [Out] SequencePosition GAGOCOIFLCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NAHDIPMBCDE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F00660", Offset = "0x7EFF460", VA = "0x187F00660")]
	public NAHDIPMBCDE(bool MCPKCIOJMBJ, string LADMBBDBKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F00610", Offset = "0x7EFF410", VA = "0x187F00610")]
	public NAHDIPMBCDE(bool MCPKCIOJMBJ, params string[] GNBOEKAOJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NBPFOLBIKCI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BKOPBFMLNHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FJFCIPOMCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJMIIFHFDKB(string MAKJJJECHHB, double OAIIHELJHLG, [Optional] string? MJACPLJFHFM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BNECLNEGCCB : PKGGEOPHBHE, GNDOAOEBOOF, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int GDDJGDMHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MOABKHNCFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double JJLOIPCKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double CEDDBAAAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double ABFINJINKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int HJILPILOKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double PBCMGAMFHDI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DOAEGIMONGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA276E0", Offset = "0xA264E0", VA = "0x180A276E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HIKMDELONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7210", Offset = "0x7EF6010", VA = "0x187EF7210", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double IDAODPLJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x54B0300", Offset = "0x54AF100", VA = "0x1854B0300", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double OIDHBCMABHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x279D540", Offset = "0x279C340", VA = "0x18279D540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7270", Offset = "0x7EF6070", VA = "0x187EF7270")]
	public BNECLNEGCCB(int NMAFHFNACPA, double PBCMGAMFHDI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FE0", Offset = "0x7EF5DE0", VA = "0x187EF6FE0", Slot = "7")]
	public void BKJBOJJNJFH(double AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6F70", Offset = "0x7EF5D70", VA = "0x187EF6F70", Slot = "8")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7110", Offset = "0x7EF5F10", VA = "0x187EF7110", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DJOHOGCOKMF : PKGGEOPHBHE, GNDOAOEBOOF, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long ALFGNAHPKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double CGGACFPHLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double FBBPIANDFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double PBHPBLMIKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double OJJOHHBGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double JJLOIPCKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double CEDDBAAAIGH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double IDAODPLJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x715AD30", Offset = "0x7159B30", VA = "0x18715AD30", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OIDHBCMABHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x715AD00", Offset = "0x7159B00", VA = "0x18715AD00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double PIECEBIGCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x715AD20", Offset = "0x7159B20", VA = "0x18715AD20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HIKMDELONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2EABF80", Offset = "0x2EAAD80", VA = "0x182EABF80", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8140", Offset = "0x7EF6F40", VA = "0x187EF8140", Slot = "10")]
	public virtual void BKJBOJJNJFH(double AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8100", Offset = "0x7EF6F00", VA = "0x187EF8100", Slot = "11")]
	public virtual void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8260", Offset = "0x7EF7060", VA = "0x187EF8260", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF74B0", Offset = "0x7EF62B0", VA = "0x187EF74B0")]
	public DJOHOGCOKMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BPLNFCEMCMF : DJOHOGCOKMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LIGAHNDEELM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x715ADB0", Offset = "0x7159BB0", VA = "0x18715ADB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x715ADA0", Offset = "0x7159BA0", VA = "0x18715ADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7380", Offset = "0x7EF6180", VA = "0x187EF7380", Slot = "10")]
	public override void BKJBOJJNJFH(double AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7340", Offset = "0x7EF6140", VA = "0x187EF7340", Slot = "11")]
	public override void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EF74B0", Offset = "0x7EF62B0", VA = "0x187EF74B0")]
	public BPLNFCEMCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PKGGEOPHBHE : GNDOAOEBOOF, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HIKMDELONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double IDAODPLJNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double OIDHBCMABHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PGDPCMIHEMG : GNDOAOEBOOF, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double OABPNINCLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double CPMAIFABFFE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F01E80", Offset = "0x7F00C80", VA = "0x187F01E80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF5B0", Offset = "0x6BAE3B0", VA = "0x186BAF5B0", Slot = "4")]
	public void BKJBOJJNJFH(double AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F01E20", Offset = "0x7F00C20", VA = "0x187F01E20", Slot = "5")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F01E30", Offset = "0x7F00C30", VA = "0x187F01E30", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PGDPCMIHEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GNDOAOEBOOF : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKJBOJJNJFH(double AFBDJBIOHNP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANBMJCFGCOC();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FFNPCFODJHA : GNDOAOEBOOF, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OAIIHELJHLG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x467FCE0", Offset = "0x467EAE0", VA = "0x18467FCE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x541DC30", Offset = "0x541CA30", VA = "0x18541DC30", Slot = "4")]
	public void BKJBOJJNJFH(double AFBDJBIOHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9890", Offset = "0x7EF8690", VA = "0x187EF9890", Slot = "5")]
	public void ANBMJCFGCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EF98A0", Offset = "0x7EF86A0", VA = "0x187EF98A0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public FFNPCFODJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NHBFGFCGMKL<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> IFIOFJHOJBJ(CancellationToken GHKBKDKNIOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LBHKMNCHOKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NHBFGFCGMKL<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IFIOFJHOJBJ taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x51511A0", Offset = "0x514FFA0", VA = "0x1851511A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5152260", Offset = "0x5151060", VA = "0x185152260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource FMNLCBJFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? NPHKKHGFOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? DFOEMAFANGA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x54B3590", Offset = "0x54B2390", VA = "0x1854B3590")]
	[AsyncStateMachine(typeof(NHBFGFCGMKL<>.LBHKMNCHOKO))]
	public Task<TResult> BHMAFPNFFPP(IFIOFJHOJBJ DCMBHLCHPDA, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x54B36D0", Offset = "0x54B24D0", VA = "0x1854B36D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x54B3740", Offset = "0x54B2540", VA = "0x1854B3740")]
	public NHBFGFCGMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DDJAOFPACCD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> EKKGPBLMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T COJGBJGNJFM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C22F00", Offset = "0x4C21D00", VA = "0x184C22F00")]
	public DDJAOFPACCD([In] T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDEC0", Offset = "0x6AECCC0", VA = "0x186AEDEC0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE340", Offset = "0x6AED140", VA = "0x186AEE340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE960", Offset = "0x6AED760", VA = "0x186AEE960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IFGFHLNMBII
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static DDJAOFPACCD<T> NBEICDCLFEE<T>([In] T OAIIHELJHLG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DOEAJOBEBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EF82D0", Offset = "0x7EF70D0", VA = "0x187EF82D0")]
	public static void OAMNCGNFOBN(this CancellationTokenSource FMNLCBJFAGK, bool BAGAKCPMHKI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class DJKAJHIKFKF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public DJKAJHIKFKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FBGGHAJGOHK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public FBGGHAJGOHK(string PJNIBGCJNDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class APOOIOHOPMM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x414E510", Offset = "0x414D310", VA = "0x18414E510")]
	public static OIPEJEPACHD ENNEKMBKDMM<T>()
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5E40", Offset = "0x7EF4C40", VA = "0x187EF5E40")]
	public static OIPEJEPACHD DJEKPAMLJCL([CallerMemberName] string IHGFMOMOADA = "")
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x414E2A0", Offset = "0x414D0A0", VA = "0x18414E2A0")]
	public static OIPEJEPACHD AOBEPDNLJFA<T>([CallerMemberName] string IHGFMOMOADA = "") where T : notnull
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x414E490", Offset = "0x414D290", VA = "0x18414E490")]
	public static OIPEJEPACHD ENNEKMBKDMM<T>(this T AOJFFKDCAKJ) where T : notnull
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x414E340", Offset = "0x414D140", VA = "0x18414E340")]
	public static OIPEJEPACHD DJEKPAMLJCL<T>(this T AOJFFKDCAKJ, [CallerMemberName] string IHGFMOMOADA = "") where T : notnull
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x414E1F0", Offset = "0x414CFF0", VA = "0x18414E1F0")]
	public static OIPEJEPACHD AOBEPDNLJFA<T>(this T FPFHIDBMBMI, [CallerMemberName] string IHGFMOMOADA = "") where T : notnull
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5DC0", Offset = "0x7EF4BC0", VA = "0x187EF5DC0")]
	public static OIPEJEPACHD AOBEPDNLJFA(string GFMGKIEGHAI, [CallerMemberName] string IHGFMOMOADA = "")
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5EA0", Offset = "0x7EF4CA0", VA = "0x187EF5EA0")]
	public static string KNBCJGHNNJD(this object FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool BLMPNKFAKFH();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DJKAJHIKFKF]
public delegate long LJCKIHJFDEA();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IJANLFPPCIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IJANLFPPCIO ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public IJANLFPPCIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HNPJLNJPLMK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static PLNFLJFCFIP EAPJGJGPMNI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static PLNFLJFCFIP PDGPCOLGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAC20", Offset = "0x7EF9A20", VA = "0x187EFAC20")]
		get
		{
			return default(PLNFLJFCFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static CGNBGOCAAPG IINOCKNLDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB330", Offset = "0x7EFA130", VA = "0x187EFB330")]
		get
		{
			return default(CGNBGOCAAPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KLNKCDHMJAE AGKKHOHMCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAF00", Offset = "0x7EF9D00", VA = "0x187EFAF00")]
		get
		{
			return default(KLNKCDHMJAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool MEHKAIKMLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAE20", Offset = "0x7EF9C20", VA = "0x187EFAE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAC70", Offset = "0x7EF9A70", VA = "0x187EFAC70")]
	public static void BCGDEOHOGMC([In] PLNFLJFCFIP JPOFDPIJCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB260", Offset = "0x7EFA060", VA = "0x187EFB260")]
	public static void NDLHJECGFPL(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAB50", Offset = "0x7EF9950", VA = "0x187EFAB50")]
	public static void AJDOOHBHBHH(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3927A00", Offset = "0x3926800", VA = "0x183927A00")]
	public static void AJDOOHBHBHH<T>(T EMEICEFCBEP, IIADBFBJJED<T> NJJDPBHNDPA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAF50", Offset = "0x7EF9D50", VA = "0x187EFAF50")]
	public static void HJHBCOLPIEH(Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB1E0", Offset = "0x7EF9FE0", VA = "0x187EFB1E0")]
	public static void MCNNNDHKHNK(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAE90", Offset = "0x7EF9C90", VA = "0x187EFAE90")]
	public static void ECLAFCBBOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB160", Offset = "0x7EF9F60", VA = "0x187EFB160")]
	public static string KNBCJGHNNJD(object GLEBGNJJOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAAE0", Offset = "0x7EF98E0", VA = "0x187EFAAE0")]
	public static long ADEHAIPLBBG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB0C0", Offset = "0x7EF9EC0", VA = "0x187EFB0C0")]
	public static bool IJIPFNIKMEA(bool BEHJKDNMPEJ, string NJJDPBHNDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAFF0", Offset = "0x7EF9DF0", VA = "0x187EFAFF0")]
	public static double IFAEPFLACEI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PLNFLJFCFIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly CGNBGOCAAPG IINOCKNLDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly KLNKCDHMJAE AGKKHOHMCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly FMMKNFFELGN DHJBAFFPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly LJCKIHJFDEA IFEOPGHPLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly NHNHHCLDEFO CKOMMCCPMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly BLMPNKFAKFH MAJEOBJJKBJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly FMMKNFFELGN AHCLBIFCLJM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LJCKIHJFDEA GFKPFFIBDGD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly NHNHHCLDEFO KPOFAMNHDHA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly BLMPNKFAKFH COCLIBHKCDP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly PLNFLJFCFIP LJAJAMKHAJN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F01FE0", Offset = "0x7F00DE0", VA = "0x187F01FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F02870", Offset = "0x7F01670", VA = "0x187F02870")]
	public PLNFLJFCFIP([In] CGNBGOCAAPG KANMEAMDIHA, [In] KLNKCDHMJAE HNCIDLLPPDB, FMMKNFFELGN EHFOLKIKCKJ, LJCKIHJFDEA PFHBAIFDGMN, NHNHHCLDEFO NFGFNCKGNOO, BLMPNKFAKFH IHKFKANKEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F01FA0", Offset = "0x7F00DA0", VA = "0x187F01FA0")]
	private static string DFGGBPAIBJO(object GLEBGNJJOHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	private static long CEGGNAFBGEG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	private static string AJLHFAPOLEH(string DOABHODDFNN, string? CELCCJNPBCN, bool NLHEOCIJEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private static bool CLMGBDMDKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F01E90", Offset = "0x7F00C90", VA = "0x187F01E90")]
	private static PLNFLJFCFIP CNBGDJJKGGF()
	{
		return default(PLNFLJFCFIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BAOOKPBABPO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLJNELPDBKH BCGDNIKCDKC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HLJNELPDBKH : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IGGJDLMDHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHMPPDCCHNA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EABEFDIJHGN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFHOCHHFBKJ([In] T HBLONCAMFLG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void JIONLKENICG<T>([In] T EMEICEFCBEP);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct GBCDFDAECGC<T> : IEquatable<GBCDFDAECGC<T>>, EABEFDIJHGN<GBCDFDAECGC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T COJGBJGNJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int KBDABDGGLJF;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F860", Offset = "0x4B7E660", VA = "0x184B7F860")]
	public GBCDFDAECGC([In] T OAIIHELJHLG, int GLAOLHCPLLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B7EA80", Offset = "0x4B7D880", VA = "0x184B7EA80")]
	public static bool PBEBFPKJKLO([In] GBCDFDAECGC<T> EFOOGHNHGNH, [In] GBCDFDAECGC<T> IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D610", Offset = "0x4B7C410", VA = "0x184B7D610", Slot = "4")]
	public bool Equals(GBCDFDAECGC<T> HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D580", Offset = "0x4B7C380", VA = "0x184B7D580", Slot = "0")]
	public override bool Equals(object HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D4A0", Offset = "0x4B7C2A0", VA = "0x184B7D4A0")]
	public bool BFHOCHHFBKJ([In] GBCDFDAECGC<T> HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E020", Offset = "0x4B7CE20", VA = "0x184B7E020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4B7F4D0", Offset = "0x4B7E2D0", VA = "0x184B7F4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D930", Offset = "0x4B7C730", VA = "0x184B7D930")]
	public void GOKNENBJBKI([Out] T OAIIHELJHLG, [Out] int GLAOLHCPLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4B7E490", Offset = "0x4B7D290", VA = "0x184B7E490")]
	public (T, int) NDANHNCFBKO()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4B7D530", Offset = "0x4B7C330", VA = "0x184B7D530", Slot = "5")]
	private bool DFGBJLNLJJM([In] GBCDFDAECGC<T> HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PDPJPMJDKLC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C9B0", Offset = "0x3B1B7B0", VA = "0x183B1C9B0")]
	public static GBCDFDAECGC<T> NBEICDCLFEE<T>([In] T OAIIHELJHLG, int GLAOLHCPLLG) where T : notnull
	{
		return default(GBCDFDAECGC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FJNGKHGKGGN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x38E9340", Offset = "0x38E8140", VA = "0x1838E9340")]
	public static bool BFHOCHHFBKJ<T, U>([In] T FPFHIDBMBMI, [In] U GLEBGNJJOHG) where T : notnull, EABEFDIJHGN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult BKHKNHINPMP<T, out TResult>([In] T EMEICEFCBEP);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LLHIOIFAFBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan KJBEIJFJGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? DMNOLILAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBHIJBFDGNG();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGNKEMLPFMI();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNIOHOLOONN();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct CGNBGOCAAPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly KGDCNELIJNO PBIMLOAAEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly MKKLEJOJDGL MINDJMIAKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KGDCNELIJNO FAMKKJIBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MKKLEJOJDGL CICJHAPKJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly KGDCNELIJNO OHOGIIALCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly MKKLEJOJDGL INCOACMLHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly BIJBBOIKAGD JFIJDHCMGHP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly KGDCNELIJNO JDPKKKKGHCN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly MKKLEJOJDGL CBAFNDDNILE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly KGDCNELIJNO INKHEPHFIGM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MKKLEJOJDGL JOIBIAEGAAL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly KGDCNELIJNO DEMIHKAJBLO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MKKLEJOJDGL DCOPPJCFLGG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly BIJBBOIKAGD PBNJIFCPDOA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly CGNBGOCAAPG LJAJAMKHAJN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KGDCNELIJNO ENEGMACHBJG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EF78B0", Offset = "0x7EF66B0", VA = "0x187EF78B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xD91C80", Offset = "0xD90A80", VA = "0x180D91C80")]
	public CGNBGOCAAPG(KGDCNELIJNO BIAHOODLDOI, MKKLEJOJDGL OCEDOKLGCFN, KGDCNELIJNO CFACHBKMFBC, MKKLEJOJDGL IMEFEAIBIBC, KGDCNELIJNO FAFKFDBAEKO, MKKLEJOJDGL ECEFIGJIEKM, BIJBBOIKAGD IGELCOHHKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private static bool NFBCANBFPHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void HFNFPHEACIB(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private static bool ABPEHHDBDAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void PBAHMHMGONB(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private static bool HAELJPNDPKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void GDNICMKBBPE(string NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void JOBJPKMBPPM(Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7630", Offset = "0x7EF6430", VA = "0x187EF7630")]
	private static CGNBGOCAAPG CNBGDJJKGGF()
	{
		return default(CGNBGOCAAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630")]
	private static bool GJINNJAIJKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7840", Offset = "0x7EF6640", VA = "0x187EF7840")]
	public void NDLHJECGFPL(object NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7AB0", Offset = "0x7EF68B0", VA = "0x187EF7AB0")]
	public void PJBJBOBMGNJ(object NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EF74E0", Offset = "0x7EF62E0", VA = "0x187EF74E0")]
	public void AJDOOHBHBHH(object NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xDA6AD0", Offset = "0xDA58D0", VA = "0x180DA6AD0")]
	public void HJHBCOLPIEH(Exception HELNJIPKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7550", Offset = "0x7EF6350", VA = "0x187EF7550")]
	public void AJDOOHBHBHH(FJKCFLGAFFG NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x370B290", Offset = "0x370A090", VA = "0x18370B290")]
	public void AJDOOHBHBHH<T>(T EMEICEFCBEP, IIADBFBJJED<T> NJJDPBHNDPA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x370B5D0", Offset = "0x370A3D0", VA = "0x18370B5D0")]
	public void NDLHJECGFPL<T>([In] T EMEICEFCBEP, JHFKIFGHELJ<T> NJJDPBHNDPA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x370B360", Offset = "0x370A160", VA = "0x18370B360")]
	public void AJDOOHBHBHH<T>([In] T EMEICEFCBEP, JHFKIFGHELJ<T> NJJDPBHNDPA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7770", Offset = "0x7EF6570", VA = "0x187EF7770")]
	public bool IJIPFNIKMEA(bool BEHJKDNMPEJ, string NJJDPBHNDPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct OIPEJEPACHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string COJGBJGNJFM;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	public OIPEJEPACHD(string OAIIHELJHLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
	public static string HEKJAOMNHLJ([In] OIPEJEPACHD FPFHIDBMBMI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x233EB60", Offset = "0x233D960", VA = "0x18233EB60")]
	public static OIPEJEPACHD HEKJAOMNHLJ(string HBLONCAMFLG)
	{
		return default(OIPEJEPACHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F01970", Offset = "0x7F00770", VA = "0x187F01970")]
	public string NMDEMLKELEM(string MOOAPBNCPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F01890", Offset = "0x7F00690", VA = "0x187F01890")]
	public string ELHMCAKMELN(object CEABBOIMCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class LMKBODNDMCL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public LMKBODNDMCL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NICNPLCGCEF : IEquatable<NICNPLCGCEF>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
	public bool Equals(NICNPLCGCEF HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F01040", Offset = "0x7EFFE40", VA = "0x187F01040", Slot = "0")]
	public override bool Equals(object HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F01090", Offset = "0x7EFFE90", VA = "0x187F01090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F010A0", Offset = "0x7EFFEA0", VA = "0x187F010A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CIJGJFAEBAA("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KKBEDCJNPPD<T> : IEquatable<KKBEDCJNPPD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T COJGBJGNJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool DJBDNGHKBHD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool MMGGNJHAJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x50B3300", Offset = "0x50B2100", VA = "0x1850B3300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50B55F0", Offset = "0x50B43F0", VA = "0x1850B55F0")]
	public KKBEDCJNPPD([In] T OAIIHELJHLG, bool KBOAGBNFJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50B4850", Offset = "0x50B3650", VA = "0x1850B4850")]
	public static bool PBEBFPKJKLO([In] KKBEDCJNPPD<T> EFOOGHNHGNH, [In] KKBEDCJNPPD<T> IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50B3970", Offset = "0x50B2770", VA = "0x1850B3970", Slot = "4")]
	public bool Equals(KKBEDCJNPPD<T> HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x50B3C00", Offset = "0x50B2A00", VA = "0x1850B3C00", Slot = "0")]
	public override bool Equals(object? HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50B3EE0", Offset = "0x50B2CE0", VA = "0x1850B3EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x50B5230", Offset = "0x50B4030", VA = "0x1850B5230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JHAACMCDNLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3985A90", Offset = "0x3984890", VA = "0x183985A90")]
	public static KKBEDCJNPPD<T> BGBJHIBFCJL<T>([In] T OAIIHELJHLG) where T : notnull
	{
		return default(KKBEDCJNPPD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3985880", Offset = "0x3984680", VA = "0x183985880")]
	public static KKBEDCJNPPD<T?> BAMIFPNBJDC<T>()
	{
		return default(KKBEDCJNPPD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3985D00", Offset = "0x3984B00", VA = "0x183985D00")]
	public static bool KCNAPEODPJJ<T>([In] this KKBEDCJNPPD<T> AGGPAHJEKOF, [Out][NotNullWhen(true)] T OAIIHELJHLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3985CC0", Offset = "0x3984AC0", VA = "0x183985CC0")]
	public static bool KCNAPEODPJJ<T>([In] this KKBEDCJNPPD<T> AGGPAHJEKOF, [Out][NotNullWhen(true)] T OAIIHELJHLG, [Out] KKBEDCJNPPD<T> KCCJKKAJEBM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3985D30", Offset = "0x3984B30", VA = "0x183985D30")]
	public static T? MLIKIECCAIE<T>([In] this KKBEDCJNPPD<T> AGGPAHJEKOF, T? LDGCNLHOBMI)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3985B90", Offset = "0x3984990", VA = "0x183985B90")]
	public static bool HFFEONNEFHA<T>([In] this KKBEDCJNPPD<T> AGGPAHJEKOF, T OAIIHELJHLG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BEHCMNBCCMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3697ED0", Offset = "0x3696CD0", VA = "0x183697ED0")]
	public static T OILPAODIJDK<T>([In] this KKBEDCJNPPD<T> AGGPAHJEKOF) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KLNKCDHMJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr MCNNNDHKHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr ECLAFCBBOCJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr AHHPAFNCMAK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr LHEGHDOOFAF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly KLNKCDHMJAE LJAJAMKHAJN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCC20", Offset = "0x7EFBA20", VA = "0x187EFCC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	public KLNKCDHMJAE(IntPtr PJDDFHLMKLP, IntPtr CDLLIMGPJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void MADONLJNDHG(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OANODHFOONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCB90", Offset = "0x7EFB990", VA = "0x187EFCB90")]
	private static KLNKCDHMJAE CNBGDJJKGGF()
	{
		return default(KLNKCDHMJAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct GEOFFBODCLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr CLPKHFJFFGD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
	private GEOFFBODCLB(IntPtr CDLLIMGPJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF98F0", Offset = "0x7EF86F0", VA = "0x187EF98F0")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9910", Offset = "0x7EF8710", VA = "0x187EF9910")]
	public static GEOFFBODCLB NBEICDCLFEE(string IHGFMOMOADA)
	{
		return default(GEOFFBODCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2823730", Offset = "0x2822530", VA = "0x182823730")]
	public static GEOFFBODCLB NBEICDCLFEE([In] KLNKCDHMJAE HNCIDLLPPDB, string IHGFMOMOADA)
	{
		return default(GEOFFBODCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2823970", Offset = "0x2822770", VA = "0x182823970")]
	public static GEOFFBODCLB NBEICDCLFEE([In] KLNKCDHMJAE HNCIDLLPPDB, Func<string> IHGFMOMOADA)
	{
		return default(GEOFFBODCLB);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HBGOABMFGBN : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? MIKNBHABNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr JKCPJJPEJJH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LMPEGIHENPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA160", Offset = "0x7EF8F60", VA = "0x187EFA160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9CC0", Offset = "0x7EF8AC0", VA = "0x187EF9CC0")]
	public static SHA256 BHEMCOAOOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9DD0", Offset = "0x7EF8BD0", VA = "0x187EF9DD0")]
	private static extern int FDOOAHDMKIK();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9E40", Offset = "0x7EF8C40", VA = "0x187EF9E40")]
	private static extern IntPtr HJEMIBNGEOD();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA3B0", Offset = "0x7EF91B0", VA = "0x187EFA3B0")]
	private static extern void MDIHPIJLAFF(IntPtr JKCPJJPEJJH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA2F0", Offset = "0x7EF90F0", VA = "0x187EFA2F0")]
	private static extern void LFPFICCKFCM(IntPtr JKCPJJPEJJH, byte[] FFEMKICJPKP, int PPPFIBNDOMK, int EAJDHHCDOOA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA250", Offset = "0x7EF9050", VA = "0x187EFA250")]
	private static extern void LBEFIAAGABD(IntPtr JKCPJJPEJJH, byte[] CKAGBJGKBLK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA430", Offset = "0x7EF9230", VA = "0x187EFA430")]
	private HBGOABMFGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9EB0", Offset = "0x7EF8CB0", VA = "0x187EF9EB0", Slot = "18")]
	protected override void HashCore(byte[] KNDCNOIHMGO, int EBGIKENANBF, int BHHKHHEFGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9F70", Offset = "0x7EF8D70", VA = "0x187EF9F70", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA0A0", Offset = "0x7EF8EA0", VA = "0x187EFA0A0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9D40", Offset = "0x7EF8B40", VA = "0x187EF9D40", Slot = "13")]
	protected override void Dispose(bool GJGMCGHFKNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LLPEMCEHDOG
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool ACDKBCGKAAP<in TInput, TResult>(TInput DGDLKJDMLAD, [Out] TResult BPINCJLADGC);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class EKGNGBKGMKD : BAOOKPBABPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class HMEMHMMBEPC : HLJNELPDBKH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly HMEMHMMBEPC ICOFMPPJNFC;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool IGGJDLMDHKL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x7EFA550", Offset = "0x7EF9350", VA = "0x187EFA550", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7EFA5B0", Offset = "0x7EF93B0", VA = "0x187EFA5B0", Slot = "6")]
			public void OnCompleted(Action KMLADDINOBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			public void HHMPPDCCHNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HMEMHMMBEPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly EKGNGBKGMKD ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		private EKGNGBKGMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8580", Offset = "0x7EF7380", VA = "0x187EF8580", Slot = "4")]
		public HLJNELPDBKH BCGDNIKCDKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class NJPIJGJLPOH : BAOOKPBABPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class HHHBNIICJFO : HLJNELPDBKH, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly HHHBNIICJFO ICOFMPPJNFC;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool IGGJDLMDHKL
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x7EFA460", Offset = "0x7EF9260", VA = "0x187EFA460", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7EFA480", Offset = "0x7EF9280", VA = "0x187EFA480", Slot = "6")]
			public void OnCompleted(Action KMLADDINOBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			public void HHMPPDCCHNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HHHBNIICJFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly NJPIJGJLPOH ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		private NJPIJGJLPOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F01740", Offset = "0x7F00540", VA = "0x187F01740", Slot = "4")]
		public HLJNELPDBKH BCGDNIKCDKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PFFLPMMJGLC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PFFLPMMJGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x576A470", Offset = "0x5769270", VA = "0x18576A470")]
		internal void AOFHPHJPPJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class FLNABJBKHPA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FLNABJBKHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3BE0", Offset = "0x4AD29E0", VA = "0x184AD3BE0")]
		internal void BFGMOGBOIEN(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JOOODJLHDEI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC770", Offset = "0x7EFB570", VA = "0x187EFC770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NGOBCBFLIBA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7F00E30", Offset = "0x7EFFC30", VA = "0x187F00E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct PPPEPAFALIO<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x57C39D0", Offset = "0x57C27D0", VA = "0x1857C39D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57C3B40", Offset = "0x57C2940", VA = "0x1857C3B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KLIALOKLOEM<T> : IAsyncStateMachine where T : notnull
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
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x50B6A70", Offset = "0x50B5870", VA = "0x1850B6A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x50B72C0", Offset = "0x50B60C0", VA = "0x1850B72C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EIFNPANIPEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8300", Offset = "0x7EF7100", VA = "0x187EF8300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8510", Offset = "0x7EF7310", VA = "0x187EF8510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class PBGCFMHNKBH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PBGCFMHNKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x576A470", Offset = "0x5769270", VA = "0x18576A470")]
		internal void MBNCCMIPIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x576A3F0", Offset = "0x57691F0", VA = "0x18576A3F0")]
		internal void JBMBOOFFMCB(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct HFOFPBNMGFA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ACDKBCGKAAP<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4C25E30", Offset = "0x4C24C30", VA = "0x184C25E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4C26540", Offset = "0x4C25340", VA = "0x184C26540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BDIDEOCFONO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5F40", Offset = "0x7EF4D40", VA = "0x187EF5F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6730", Offset = "0x7EF5530", VA = "0x187EF6730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BKNLJFMMFFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6790", Offset = "0x7EF5590", VA = "0x187EF6790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6CD0", Offset = "0x7EF5AD0", VA = "0x187EF6CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct KOFMPANCGBC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x50BE940", Offset = "0x50BD740", VA = "0x1850BE940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4D49270", Offset = "0x4D48070", VA = "0x184D49270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PBOJOIDGECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<NICNPLCGCEF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PBOJOIDGECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7F01D10", Offset = "0x7F00B10", VA = "0x187F01D10")]
		internal void HOEBLODOGIA(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct MAFCOIGODMD<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x538A990", Offset = "0x5389790", VA = "0x18538A990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x419B770", Offset = "0x419A570", VA = "0x18419B770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct BKJBBBPJLPH<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6093390", Offset = "0x6092190", VA = "0x186093390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x419A820", Offset = "0x4199620", VA = "0x18419A820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BNCIPINGNJB<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6173080", Offset = "0x6171E80", VA = "0x186173080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6173F80", Offset = "0x6172D80", VA = "0x186173F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BNDKCGPIDMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6D30", Offset = "0x7EF5B30", VA = "0x187EF6D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6F10", Offset = "0x7EF5D10", VA = "0x187EF6F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct ENDHHODDPDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8C20", Offset = "0x7EF7A20", VA = "0x187EF8C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8F90", Offset = "0x7EF7D90", VA = "0x187EF8F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PBJLAGGAAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F019C0", Offset = "0x7F007C0", VA = "0x187F019C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7F01CB0", Offset = "0x7F00AB0", VA = "0x187F01CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ENHHDCMLEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ENHHDCMLEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8FF0", Offset = "0x7EF7DF0", VA = "0x187EF8FF0")]
		internal Task ABFCMFEAGGB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct KBCLHELCIHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC8D0", Offset = "0x7EFB6D0", VA = "0x187EFC8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCB30", Offset = "0x7EFB930", VA = "0x187EFCB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct MFHOGMHIGNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFFC10", Offset = "0x7EFEA10", VA = "0x187EFFC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFFDF0", Offset = "0x7EFEBF0", VA = "0x187EFFDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct JHIPEJKDCOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC3B0", Offset = "0x7EFB1B0", VA = "0x187EFC3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC710", Offset = "0x7EFB510", VA = "0x187EFC710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HMNFEBFABDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA790", Offset = "0x7EF9590", VA = "0x187EFA790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAA80", Offset = "0x7EF9880", VA = "0x187EFAA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ANKHDCECHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ANKHDCECHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5D50", Offset = "0x7EF4B50", VA = "0x187EF5D50")]
		internal Task CACLEKLKKCO(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GOBIIEJBJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9A00", Offset = "0x7EF8800", VA = "0x187EF9A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9C60", Offset = "0x7EF8A60", VA = "0x187EF9C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct LEFGCODMBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD7B0", Offset = "0x7EFC5B0", VA = "0x187EFD7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD930", Offset = "0x7EFC730", VA = "0x187EFD930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct CDNIMFPCIML<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x654E110", Offset = "0x654CF10", VA = "0x18654E110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x654E370", Offset = "0x654D170", VA = "0x18654E370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct NAGOJPNPFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7F00280", Offset = "0x7EFF080", VA = "0x187F00280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F005B0", Offset = "0x7EFF3B0", VA = "0x187F005B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? GGHHEIDALAG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<NICNPLCGCEF> BEFCMOKDKOA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task EDDJKNEDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE880", Offset = "0x7EFD680", VA = "0x187EFE880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE730", Offset = "0x7EFD530", VA = "0x187EFE730")]
	public static bool HKNFDKDPGOA(this Task JDEJDGHOHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x39F2950", Offset = "0x39F1750", VA = "0x1839F2950")]
	public static Task<T> BKABAFOMIPN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE120", Offset = "0x7EFCF20", VA = "0x187EFE120")]
	public static Task DOLHHAHFKEJ(this Task JDEJDGHOHNF, CancellationToken JLFLGDNCANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39F6320", Offset = "0x39F5120", VA = "0x1839F6320")]
	public static Task<TResult> DOLHHAHFKEJ<TResult>(this Task<TResult> JDEJDGHOHNF, CancellationToken JLFLGDNCANL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x39F5330", Offset = "0x39F4130", VA = "0x1839F5330")]
	public static TaskCompletionSource<TResult> DOLHHAHFKEJ<TResult>(this TaskCompletionSource<TResult> FDNGACKNMLA, CancellationToken JLFLGDNCANL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF830", Offset = "0x7EFE630", VA = "0x187EFF830")]
	public static IDisposable? OMHEKNHGMHL(CancellationToken KCFCOFGNFFC, CancellationToken CCBHBAJMNHA, [Out] CancellationToken MEJKACJNJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF4C0", Offset = "0x7EFE2C0", VA = "0x187EFF4C0")]
	[AsyncStateMachine(typeof(JOOODJLHDEI))]
	public static void KECJIHIDLIG(this Task JIJABGNNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF660", Offset = "0x7EFE460", VA = "0x187EFF660")]
	[AsyncStateMachine(typeof(NGOBCBFLIBA))]
	public static void MIBEIKCMMDF(this Task JIJABGNNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39F7FE0", Offset = "0x39F6DE0", VA = "0x1839F7FE0")]
	[AsyncStateMachine(typeof(PPPEPAFALIO<>))]
	public static Task GBGJLDEALPG<TException>(this Task JIJABGNNHPJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x39F7E00", Offset = "0x39F6C00", VA = "0x1839F7E00")]
	[AsyncStateMachine(typeof(KLIALOKLOEM<>))]
	public static Task<T> EKDFJGINKCL<T>(this Task<T> FPFHIDBMBMI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF570", Offset = "0x7EFE370", VA = "0x187EFF570")]
	[AsyncStateMachine(typeof(EIFNPANIPEK))]
	public static Task<TaskStatus> KKEMKEJGBFP(this Task? FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39F8290", Offset = "0x39F7090", VA = "0x1839F8290")]
	public static (Task<T?>?, Action<T?>?) IOBOMJFFOOD<T>([Optional] CancellationToken GHKBKDKNIOM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x39F8920", Offset = "0x39F7720", VA = "0x1839F8920")]
	[AsyncStateMachine(typeof(HFOFPBNMGFA<, >))]
	public static Task<List<TResult>> LPHFKMAAGPL<TResult, TInput>(this Task<List<TInput>> JDEJDGHOHNF, ACDKBCGKAAP<TInput, TResult> LAKCJLJDBCE) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDD70", Offset = "0x7EFCB70", VA = "0x187EFDD70")]
	[AsyncStateMachine(typeof(BDIDEOCFONO))]
	public static Task CNDJCFEEECN(Task JIJABGNNHPJ, CancellationToken KKIGNHNCIEJ, Func<CancellationToken, Task> IGJLDAMNDFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDA40", Offset = "0x7EFC840", VA = "0x187EFDA40")]
	[AsyncStateMachine(typeof(BKNLJFMMFFG))]
	public static Task BKOJMMEHIEO(Func<CancellationToken, Task> ICKCCEIMLGH, TimeSpan LCJLIMHGKHF, [Optional] CancellationToken KKIGNHNCIEJ, [Optional] Action<OperationCanceledException>? CAGNGFGLJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x39F2AD0", Offset = "0x39F18D0", VA = "0x1839F2AD0")]
	[AsyncStateMachine(typeof(KOFMPANCGBC<>))]
	public static Task<T> BKOJMMEHIEO<T>(Func<CancellationToken, Task<T>> ICKCCEIMLGH, TimeSpan LCJLIMHGKHF, [Optional] CancellationToken KKIGNHNCIEJ, [Optional] Func<OperationCanceledException, T>? CAGNGFGLJKL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEB60", Offset = "0x7EFD960", VA = "0x187EFEB60")]
	public static Task JKEHLNKNGJK(params Task[] KHIGAIMPFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEBB0", Offset = "0x7EFD9B0", VA = "0x187EFEBB0")]
	public static Task JKEHLNKNGJK(IEnumerable<Task> KHIGAIMPFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x39F81A0", Offset = "0x39F6FA0", VA = "0x1839F81A0")]
	[AsyncStateMachine(typeof(MAFCOIGODMD<>))]
	public static Task<IEnumerable<Task<T>>> HCECBFMHBNF<T>(IEnumerable<Task<T>> KHIGAIMPFAN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39F87F0", Offset = "0x39F75F0", VA = "0x1839F87F0")]
	[AsyncStateMachine(typeof(BKJBBBPJLPH<, , >))]
	public static Task<(T1, T2, T3)> JCOHMJDOKID<T1, T2, T3>(Task<T1> KGGAJCEMGBN, Task<T2> GGOOIANPBGO, Task<T3> IEFGKKPPBFD) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x39F8510", Offset = "0x39F7310", VA = "0x1839F8510")]
	[AsyncStateMachine(typeof(BNCIPINGNJB<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> JCOHMJDOKID<T1, T2, T3, T4, T5>(Task<T1> KGGAJCEMGBN, Task<T2> GGOOIANPBGO, Task<T3> IEFGKKPPBFD, Task<T4> PCLHCGHJEDG, Task<T5> MNEBOJCDIKA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDB70", Offset = "0x7EFC970", VA = "0x187EFDB70")]
	[AsyncStateMachine(typeof(BNDKCGPIDMA))]
	public static Task CHIMHKDPHOO(Func<bool> BEHJKDNMPEJ, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDC60", Offset = "0x7EFCA60", VA = "0x187EFDC60")]
	[AsyncStateMachine(typeof(ENDHHODDPDA))]
	public static Task CHIMHKDPHOO(Func<bool> BEHJKDNMPEJ, TimeSpan INABBJECLBH, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE5B0", Offset = "0x7EFD3B0", VA = "0x187EFE5B0")]
	[AsyncStateMachine(typeof(PBJLAGGAAJB))]
	public static Task EKFAJOMNKMF(Func<bool> BEHJKDNMPEJ, TimeSpan LCJLIMHGKHF, [Optional] CancellationToken GHKBKDKNIOM, [Optional] Action<OperationCanceledException>? CAGNGFGLJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE470", Offset = "0x7EFD270", VA = "0x187EFE470")]
	[AsyncStateMachine(typeof(KBCLHELCIHD))]
	public static Task EKFAJOMNKMF(Func<bool> BEHJKDNMPEJ, TimeSpan LCJLIMHGKHF, TimeSpan INABBJECLBH, [Optional] CancellationToken GHKBKDKNIOM, [Optional] Action<OperationCanceledException>? CAGNGFGLJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDEA0", Offset = "0x7EFCCA0", VA = "0x187EFDEA0")]
	[AsyncStateMachine(typeof(MFHOGMHIGNA))]
	public static Task DDDKNMBFACM(Func<bool> BEHJKDNMPEJ, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDF90", Offset = "0x7EFCD90", VA = "0x187EFDF90")]
	[AsyncStateMachine(typeof(JHIPEJKDCOG))]
	public static Task DDDKNMBFACM(Func<bool> BEHJKDNMPEJ, TimeSpan INABBJECLBH, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEA30", Offset = "0x7EFD830", VA = "0x187EFEA30")]
	[AsyncStateMachine(typeof(HMNFEBFABDN))]
	public static Task IPOBENKBGPC(Func<bool> BEHJKDNMPEJ, TimeSpan LCJLIMHGKHF, [Optional] CancellationToken GHKBKDKNIOM, [Optional] Action<OperationCanceledException>? CAGNGFGLJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE8F0", Offset = "0x7EFD6F0", VA = "0x187EFE8F0")]
	[AsyncStateMachine(typeof(GOBIIEJBJBK))]
	public static Task IPOBENKBGPC(Func<bool> BEHJKDNMPEJ, TimeSpan LCJLIMHGKHF, TimeSpan INABBJECLBH, [Optional] CancellationToken GHKBKDKNIOM, [Optional] Action<OperationCanceledException>? CAGNGFGLJKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE380", Offset = "0x7EFD180", VA = "0x187EFE380")]
	[Obsolete]
	[AsyncStateMachine(typeof(LEFGCODMBPJ))]
	public static Task DOLMMDGACID(this Task JDEJDGHOHNF, Action GMCJIJNIOOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x39F7C20", Offset = "0x39F6A20", VA = "0x1839F7C20")]
	[AsyncStateMachine(typeof(CDNIMFPCIML<>))]
	[Obsolete]
	public static Task DOLMMDGACID<T>(this Task<T> JDEJDGHOHNF, Action<T> GMCJIJNIOOL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD990", Offset = "0x7EFC790", VA = "0x187EFD990")]
	private static void AIIAPLDILNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF070", Offset = "0x7EFDE70", VA = "0x187EFF070")]
	public static bool JLGGELBNOBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF9C0", Offset = "0x7EFE7C0", VA = "0x187EFF9C0")]
	private static void OOMLBLKHFPD(SynchronizationContext OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF710", Offset = "0x7EFE510", VA = "0x187EFF710")]
	private static void MKLEBGMDIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE760", Offset = "0x7EFD560", VA = "0x187EFE760")]
	public static void IIHHFPIGHEI([Optional] string? NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE0A0", Offset = "0x7EFCEA0", VA = "0x187EFE0A0")]
	public static void DEFMNHHDCEC([Optional] string? NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE830", Offset = "0x7EFD630", VA = "0x187EFE830")]
	public static BAOOKPBABPO IOCEBCGMIPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE6E0", Offset = "0x7EFD4E0", VA = "0x187EFE6E0")]
	public static BAOOKPBABPO FJKHOJOECMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF3F0", Offset = "0x7EFE1F0", VA = "0x187EFF3F0")]
	[AsyncStateMachine(typeof(NAGOJPNPFEA))]
	public static Task JMFBKNEOCMO(Func<Task> HPCIBKDHMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DOEGHAPPEHM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public DOEGHAPPEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class ABCAABEBOPC
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5B10", Offset = "0x7EF4910", VA = "0x187EF5B10")]
	public static bool GOOCAEAFAKH(this ENLBBEJIIBF PBJHCMBFABM, DateTime LKBMHGDLPOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5C30", Offset = "0x7EF4A30", VA = "0x187EF5C30")]
	public static TimeSpan LDKIMCMPKFG(this ENLBBEJIIBF PBJHCMBFABM, DateTime LKBMHGDLPOD)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MMPELGIEIFA : ENLBBEJIIBF
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly ENLBBEJIIBF ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime KBKEPAMOAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7F00160", Offset = "0x7EFEF60", VA = "0x187F00160", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset JDJOBFNPOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7F001A0", Offset = "0x7EFEFA0", VA = "0x187F001A0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public MMPELGIEIFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface ENLBBEJIIBF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime KBKEPAMOAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset JDJOBFNPOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FDELPKHFCCD
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long GOMEDLCGOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9240", Offset = "0x7EF8040", VA = "0x187EF9240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long PDIGMCHFDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9370", Offset = "0x7EF8170", VA = "0x187EF9370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double KAKBNOIBCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9290", Offset = "0x7EF8090", VA = "0x187EF9290")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double DMJCGDCIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9060", Offset = "0x7EF7E60", VA = "0x187EF9060")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double JCJHBLFPLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9100", Offset = "0x7EF7F00", VA = "0x187EF9100")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double FBKNKKAEHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7EF90B0", Offset = "0x7EF7EB0", VA = "0x187EF90B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF91B0", Offset = "0x7EF7FB0", VA = "0x187EF91B0")]
	public static double CCLNPLHBPGC(long BJGCBNLCAGA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF92E0", Offset = "0x7EF80E0", VA = "0x187EF92E0")]
	public static double GKMJKKLFLJM(long BJGCBNLCAGA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9520", Offset = "0x7EF8320", VA = "0x187EF9520")]
	public static double NOMPLLECGAB(double LLOCNCJMJLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9490", Offset = "0x7EF8290", VA = "0x187EF9490")]
	public static long KDIKJFDLPCH(long POHFDNBLLPJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF95B0", Offset = "0x7EF83B0", VA = "0x187EF95B0")]
	public static long OOMIBEPNIAD(long KPDHCGIFGOK, long PEOGDCLMGCL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF93C0", Offset = "0x7EF81C0", VA = "0x187EF93C0")]
	public static double IBEIBCOHJBF(long KPDHCGIFGOK, long PEOGDCLMGCL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9150", Offset = "0x7EF7F50", VA = "0x187EF9150")]
	public static double BLLGAFGHBNE(long KPDHCGIFGOK, long PEOGDCLMGCL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class NBJHANNLPFN : LLHIOIFAFBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan JPFBPONKLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer HMLAIBMJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan LCJLIMHGKHF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan KJBEIJFJGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7F009A0", Offset = "0x7EFF7A0", VA = "0x187F009A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? DMNOLILAGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F00B70", Offset = "0x7EFF970", VA = "0x187F00B70")]
	[Preserve]
	public NBJHANNLPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7F00BE0", Offset = "0x7EFF9E0", VA = "0x187F00BE0")]
	public NBJHANNLPFN(TimeSpan LCJLIMHGKHF, [Optional] Action? BDDOGLLMJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7F00730", Offset = "0x7EFF530", VA = "0x187F00730", Slot = "7")]
	public void CBHIJBFDGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7F00930", Offset = "0x7EFF730", VA = "0x187F00930", Slot = "8")]
	public void HGNKEMLPFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7F00900", Offset = "0x7EFF700", VA = "0x187F00900", Slot = "9")]
	public void GNIOHOLOONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1183490", Offset = "0x1182290", VA = "0x181183490")]
	private void GMFICPAPLKO(object AOJFFKDCAKJ, ElapsedEventArgs NIPBFDKOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7F00860", Offset = "0x7EFF660", VA = "0x187F00860")]
	private static void GCOMBODGIOC(TimeSpan KLEIANNIJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F007C0", Offset = "0x7EFF5C0", VA = "0x187F007C0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CIJGJFAEBAA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? IFIMJEFENMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string OLGOMDLLMHE;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x17088B0", Offset = "0x17076B0", VA = "0x1817088B0")]
	public CIJGJFAEBAA(string CDDMBEEGKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4DC5B80", Offset = "0x4DC4980", VA = "0x184DC5B80")]
	public CIJGJFAEBAA(string EHKJLJIDDFP, string CDDMBEEGKND)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct JGAKLEJADPA : IEquatable<JGAKLEJADPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint GCBODAGMPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int LKPHLGGDFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float DHNJFKOIILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort HJLBOELBHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort FIDNFPHOJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short GGOAKPCGOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short MNECECAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char FEAEMEGGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char FOPJDNJGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte HGJDPFKDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NCCGPODCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte GGBBKPNLBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte EMDDMOFAOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool KFNNFOMOOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool ANPBEHEJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool PKGEAEOHCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool GCHABBOBLNH;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE1B0", Offset = "0x1ECCFB0", VA = "0x181ECE1B0")]
	public static JGAKLEJADPA PMEPLCMNPNJ(uint OOCACGGOHIK)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE1B0", Offset = "0x1ECCFB0", VA = "0x181ECE1B0")]
	public static JGAKLEJADPA FGBJGAGABLK(int LAFDPDDBBCC)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB5B0", Offset = "0x7EFA3B0", VA = "0x187EFB5B0")]
	public static JGAKLEJADPA PPCFLCCCGJN(float GOMHEAJNLJI)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB590", Offset = "0x7EFA390", VA = "0x187EFB590")]
	public static JGAKLEJADPA FDGJCAEFFKG(byte EFAFGPGKPDM, byte KPCCBEGLFHD, byte OPKDPOGDPOM, byte GPDKLFNBKLK)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB590", Offset = "0x7EFA390", VA = "0x187EFB590")]
	public static JGAKLEJADPA JNLCNCAFMEI(bool JHKLPBCMPHA, bool PKOGKBNAIJI, bool LGCKDJOBPGE, bool NNGBMIKAHLC)
	{
		return default(JGAKLEJADPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB590", Offset = "0x7EFA390", VA = "0x187EFB590")]
	public static JGAKLEJADPA KGEGINBAKKD(byte JDMGNBLHMKD, byte DCCINMLNMNO, byte HJNONBAMACH, byte APDLPFNJKMM)
	{
		return default(JGAKLEJADPA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x21CB090", Offset = "0x21C9E90", VA = "0x1821CB090")]
	public static bool PBEBFPKJKLO(JGAKLEJADPA ALCLKCHJGII, JGAKLEJADPA GFJPONDOIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x21CB070", Offset = "0x21C9E70", VA = "0x1821CB070", Slot = "4")]
	public bool Equals(JGAKLEJADPA HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB510", Offset = "0x7EFA310", VA = "0x187EFB510", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1341930", Offset = "0x1340730", VA = "0x181341930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB5C0", Offset = "0x7EFA3C0", VA = "0x187EFB5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct IOPODILKGJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong NHHJDPDOLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long OMNAJLPJFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double CMEIAGIHGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint JDIPGPHLHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint DFOLHPFGBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int LJMOECEKMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int MDLAKIJOJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float MPGDENBJEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float GCJAMECOHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort HJLBOELBHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort FIDNFPHOJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort ONAKGFBCIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort BBKIEDGJIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short GGOAKPCGOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short MNECECAMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short DKOFFJOKJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short ECCGNCALIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char FEAEMEGGBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char FOPJDNJGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char IIKNBIMPEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char PLHGLCPFOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte HGJDPFKDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte NCCGPODCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte GGBBKPNLBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte EMDDMOFAOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte NNLBEDLACOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte CANAOELMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte JMJKCMODPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte MDBGELBCPFK;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static IOPODILKGJF NBEICDCLFEE(long GOIEJNLOIMK)
	{
		return default(IOPODILKGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB4C0", Offset = "0x7EFA2C0", VA = "0x187EFB4C0")]
	public static IOPODILKGJF NBEICDCLFEE(byte EFAFGPGKPDM, byte KPCCBEGLFHD, byte OPKDPOGDPOM, byte GPDKLFNBKLK, byte DLPCOFPLLIM, byte FEOIILHNBKC, byte JBBNOPGFAJL, byte KODOCLPCOKJ)
	{
		return default(IOPODILKGJF);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MGFGGDINMMD : IEquatable<MGFGGDINMMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte HFONELAEJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool DBFIMBMADPH;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5640", Offset = "0x2EC4440", VA = "0x182EC5640")]
	public static MGFGGDINMMD FDGJCAEFFKG(byte CALEMEGHBJF)
	{
		return default(MGFGGDINMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5640", Offset = "0x2EC4440", VA = "0x182EC5640")]
	public static MGFGGDINMMD JNLCNCAFMEI(bool NAPLFCKHPOA)
	{
		return default(MGFGGDINMMD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFEF0", Offset = "0x7EFECF0", VA = "0x187EFFEF0")]
	public static bool PBEBFPKJKLO(MGFGGDINMMD ALCLKCHJGII, MGFGGDINMMD GFJPONDOIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6E2ACA0", Offset = "0x6E29AA0", VA = "0x186E2ACA0", Slot = "4")]
	public bool Equals(MGFGGDINMMD HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFE50", Offset = "0x7EFEC50", VA = "0x187EFFE50", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFEE0", Offset = "0x7EFECE0", VA = "0x187EFFEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFF00", Offset = "0x7EFED00", VA = "0x187EFFF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MLCODCBHACF<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T GFEJDIMDBPA;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x53CC0E0", Offset = "0x53CAEE0", VA = "0x1853CC0E0")]
	public MLCODCBHACF(T HAGJPPBICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class AMEHBCECDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3708310", Offset = "0x3707110", VA = "0x183708310")]
	public static IEnumerable<T> ELIHMJJCHDN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static T[] PEAFNBLHOFE<T>(params T[] ICMCHLLIJEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static IEnumerable<T> EFBNMAOAPAO<T>(params T[] ICMCHLLIJEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static HashSet<T> JJPKALPBPJL<T>(params T[] ICMCHLLIJEH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x414CDA0", Offset = "0x414BBA0", VA = "0x18414CDA0")]
	public static KeyValuePair<TKey, TValue> CLLDMGKAGMB<TKey, TValue>([In] TKey MAKJJJECHHB, [In] TValue OAIIHELJHLG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static List<T> HINKLBHNDNJ<T>(IEnumerable<T> CPGOGHNJEGO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class IICOIOJKHLE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string EFLHMFJBJCG;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
	public IICOIOJKHLE(string GJCHJCHAFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object JHFKIFGHELJ<T>([In] T AOGFOJGFMAN);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object IIADBFBJJED<T>(T AOGFOJGFMAN);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DJKAJHIKFKF]
public delegate string NHNHHCLDEFO(string DOABHODDFNN, string? CELCCJNPBCN, bool NLHEOCIJEAO);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DJKAJHIKFKF]
public delegate void MKKLEJOJDGL(string NJJDPBHNDPA);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DJKAJHIKFKF]
public delegate void BIJBBOIKAGD(Exception HELNJIPKBCP);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object FJKCFLGAFFG();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DJKAJHIKFKF]
public delegate bool KGDCNELIJNO();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DJKAJHIKFKF]
public delegate string FMMKNFFELGN(object GLEBGNJJOHG);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class OHJFOAMLGNF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
	public OHJFOAMLGNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class NIFDKEPPECJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct LAMEHIOMIGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCE50", Offset = "0x7EFBC50", VA = "0x187EFCE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD740", Offset = "0x7EFC540", VA = "0x187EFD740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback JOOFCOKMFGO;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> HAAGFBBHEIM;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F01320", Offset = "0x7F00120", VA = "0x187F01320")]
	public static Task<bool> OHJJKDOPOCA(int MIBKDIALLGK, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7F010D0", Offset = "0x7EFFED0", VA = "0x187F010D0")]
	[AsyncStateMachine(typeof(LAMEHIOMIGB))]
	private static Task<bool> GDIMCLDIFGF(int MIBKDIALLGK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F01290", Offset = "0x7F00090", VA = "0x187F01290")]
	private static void MPBAADBGNKK(object? JNOIIIFBOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F01200", Offset = "0x7F00000", VA = "0x187F01200")]
	private static void GFENALDAKGL(object? JNOIIIFBOLM)
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
