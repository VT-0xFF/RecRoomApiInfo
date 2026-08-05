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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7B20", Offset = "0x7DB6D20", VA = "0x187DB7B20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CGPBBGHCAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE9F0", Offset = "0x7DADBF0", VA = "0x187DAE9F0")]
	public static string POIECIFKOOP(this Encoding PCEJNLIOEMM, [In] ReadOnlySequence<byte> DJMFMHNIFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37F3490", Offset = "0x37F2690", VA = "0x1837F3490")]
	private static void KKADEDDNGDL<T>(this ReadOnlySequence<T> DDBGOEIPDPI, [Out] ReadOnlySpan<T> NPLEDMFPJOA, [Out] SequencePosition EGAIMJDOJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class MLNLCBOFGDG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6EA0", Offset = "0x7DB60A0", VA = "0x187DB6EA0")]
	public MLNLCBOFGDG(bool ALBHMCMFPKA, string LMFFLBOLMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6E50", Offset = "0x7DB6050", VA = "0x187DB6E50")]
	public MLNLCBOFGDG(bool ALBHMCMFPKA, params string[] GHHOOPGDHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CIGILIBABEP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ALMABLCCJBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EHLJLLHGOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGJOKKJHJCI(string MHDODBCCAJB, double KJIOHKMJAPE, [Optional] string? MEONIOBHBAC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IIPBECKPKJP : LKKOLGHEJKJ, CIMAGHFAFFK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int COJAAOPEBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MPOMBLHCCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double FHHDCGHGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double AFOBMPBBEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double LFNOIHLKKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int ANOJHNOJEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double DIBCNFPIDMA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PJJJNFODKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double AAFGKJMKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2B50", Offset = "0x7DB1D50", VA = "0x187DB2B50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BDNMNGMDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67D0A00", Offset = "0x67CFC00", VA = "0x1867D0A00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double EJLJCFDDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2813F00", Offset = "0x2813100", VA = "0x182813F00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2BB0", Offset = "0x7DB1DB0", VA = "0x187DB2BB0")]
	public IIPBECKPKJP(int GLIPOIFLDBL, double DIBCNFPIDMA = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2A20", Offset = "0x7DB1C20", VA = "0x187DB2A20", Slot = "7")]
	public void GCIBMKKEGEL(double DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DB29B0", Offset = "0x7DB1BB0", VA = "0x187DB29B0", Slot = "8")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DB28B0", Offset = "0x7DB1AB0", VA = "0x187DB28B0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DNEMNDHLMGM : LKKOLGHEJKJ, CIMAGHFAFFK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long OCEHNHGKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double DBPGABGAGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double MGEIEPAEEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double OMOAPJEPNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double FGOIMHHKEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double FHHDCGHGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double AFOBMPBBEDH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BDNMNGMDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE2C0", Offset = "0x6FFD4C0", VA = "0x186FFE2C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EJLJCFDDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE2A0", Offset = "0x6FFD4A0", VA = "0x186FFE2A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JJEPNEDPALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE780", Offset = "0x6FFD980", VA = "0x186FFE780")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AAFGKJMKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2F46680", Offset = "0x2F45880", VA = "0x182F46680", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF490", Offset = "0x7DAE690", VA = "0x187DAF490", Slot = "10")]
	public virtual void GCIBMKKEGEL(double DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF450", Offset = "0x7DAE650", VA = "0x187DAF450", Slot = "11")]
	public virtual void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF3E0", Offset = "0x7DAE5E0", VA = "0x187DAF3E0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF5B0", Offset = "0x7DAE7B0", VA = "0x187DAF5B0")]
	public DNEMNDHLMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IAGALEJBGGJ : DNEMNDHLMGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double JDNHAJFNCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE2B0", Offset = "0x6FFD4B0", VA = "0x186FFE2B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE720", Offset = "0x6FFD920", VA = "0x186FFE720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2780", Offset = "0x7DB1980", VA = "0x187DB2780", Slot = "10")]
	public override void GCIBMKKEGEL(double DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2740", Offset = "0x7DB1940", VA = "0x187DB2740", Slot = "11")]
	public override void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DAF5B0", Offset = "0x7DAE7B0", VA = "0x187DAF5B0")]
	public IAGALEJBGGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LKKOLGHEJKJ : CIMAGHFAFFK, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double AAFGKJMKCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BDNMNGMDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double EJLJCFDDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HKKNFLEBGBN : CIMAGHFAFFK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double FEPODJLDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double NHCILBDLFOI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1DD0", Offset = "0x7DB0FD0", VA = "0x187DB1DD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A55800", Offset = "0x6A54A00", VA = "0x186A55800", Slot = "4")]
	public void GCIBMKKEGEL(double DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1DC0", Offset = "0x7DB0FC0", VA = "0x187DB1DC0", Slot = "5")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1D70", Offset = "0x7DB0F70", VA = "0x187DB1D70", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public HKKNFLEBGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CIMAGHFAFFK : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCIBMKKEGEL(double DIPIKNPCGFJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNFMCNPCKDE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PDGKIJBJNMF : CIMAGHFAFFK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double KJIOHKMJAPE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4757FB0", Offset = "0x47571B0", VA = "0x184757FB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5464B50", Offset = "0x5463D50", VA = "0x185464B50", Slot = "4")]
	public void GCIBMKKEGEL(double DIPIKNPCGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9420", Offset = "0x7DB8620", VA = "0x187DB9420", Slot = "5")]
	public void DNFMCNPCKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7DB93D0", Offset = "0x7DB85D0", VA = "0x187DB93D0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public PDGKIJBJNMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHNHOHBKMLJ<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> LICDADPEDMD(CancellationToken FHBCOAHILMJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MCGPMHEBGEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MHNHOHBKMLJ<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LICDADPEDMD taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x53EC970", Offset = "0x53EBB70", VA = "0x1853EC970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x53ED940", Offset = "0x53ECB40", VA = "0x1853ED940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource IHOFGGILNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? PPIIOMPDACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? NALGOJCGJKF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x541B3C0", Offset = "0x541A5C0", VA = "0x18541B3C0")]
	[AsyncStateMachine(typeof(MHNHOHBKMLJ<>.MCGPMHEBGEJ))]
	public Task<TResult> JPGPNECEHIA(LICDADPEDMD LFGACIJHCCI, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x541B350", Offset = "0x541A550", VA = "0x18541B350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x541B4F0", Offset = "0x541A6F0", VA = "0x18541B4F0")]
	public MHNHOHBKMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BHHCJKBLHOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> LCEOGKJHNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x467C9D0", Offset = "0x467BBD0", VA = "0x18467C9D0")]
	public BHHCJKBLHOL([In] T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61983C0", Offset = "0x61975C0", VA = "0x1861983C0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6198700", Offset = "0x6197900", VA = "0x186198700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6198B40", Offset = "0x6197D40", VA = "0x186198B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IAMALGAAELN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static BHHCJKBLHOL<T> FAHGDJGLLGD<T>([In] T KJIOHKMJAPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PIGCEBDANPM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9F50", Offset = "0x7DB9150", VA = "0x187DB9F50")]
	public static void ABOINDFDCPD(this CancellationTokenSource IHOFGGILNEH, bool CJMPJLMLEMK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FIKMFILHHDD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public FIKMFILHHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class GBIEILHEKIF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public GBIEILHEKIF(string PADEPNLFJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ANEOFPLEGJE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9BD0", Offset = "0x2FA8DD0", VA = "0x182FA9BD0")]
	public static PKHKKFEDHPF DCNBBFAFIIG<T>()
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7DADDC0", Offset = "0x7DACFC0", VA = "0x187DADDC0")]
	public static PKHKKFEDHPF PDKCADPBMGH([CallerMemberName] string GBOCGPJOEEK = "")
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9E00", Offset = "0x2FA9000", VA = "0x182FA9E00")]
	public static PKHKKFEDHPF GNMLHFHDOMM<T>([CallerMemberName] string GBOCGPJOEEK = "") where T : notnull
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9C50", Offset = "0x2FA8E50", VA = "0x182FA9C50")]
	public static PKHKKFEDHPF DCNBBFAFIIG<T>(this T LDINAKFKJDF) where T : notnull
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9F30", Offset = "0x2FA9130", VA = "0x182FA9F30")]
	public static PKHKKFEDHPF PDKCADPBMGH<T>(this T LDINAKFKJDF, [CallerMemberName] string GBOCGPJOEEK = "") where T : notnull
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9E90", Offset = "0x2FA9090", VA = "0x182FA9E90")]
	public static PKHKKFEDHPF GNMLHFHDOMM<T>(this T IPOCHJJJBCM, [CallerMemberName] string GBOCGPJOEEK = "") where T : notnull
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7DADCA0", Offset = "0x7DACEA0", VA = "0x187DADCA0")]
	public static PKHKKFEDHPF GNMLHFHDOMM(string MLONEPBKDJN, [CallerMemberName] string GBOCGPJOEEK = "")
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7DADD20", Offset = "0x7DACF20", VA = "0x187DADD20")]
	public static string ONANFIJPEBL(this object IPOCHJJJBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool HEFNDCIBJMA();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FIKMFILHHDD]
public delegate long LICPDFBPEJJ();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DPKMKBCHCMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly DPKMKBCHCMO AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DPKMKBCHCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KAEANINNCOC
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static PEPDDEMKHLE IFKGCEHOKDG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static PEPDDEMKHLE FDEPNEMMFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3340", Offset = "0x7DB2540", VA = "0x187DB3340")]
		get
		{
			return default(PEPDDEMKHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HEJGENDJICD AGOIINEKDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3630", Offset = "0x7DB2830", VA = "0x187DB3630")]
		get
		{
			return default(HEJGENDJICD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static JGANPJEMGLK FDLPCMKEDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7DB32F0", Offset = "0x7DB24F0", VA = "0x187DB32F0")]
		get
		{
			return default(JGANPJEMGLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool IBCGMFCPMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7DB36F0", Offset = "0x7DB28F0", VA = "0x187DB36F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3390", Offset = "0x7DB2590", VA = "0x187DB3390")]
	public static void HALPBKMHHGN([In] PEPDDEMKHLE NGNDJOIKGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2FE0", Offset = "0x7DB21E0", VA = "0x187DB2FE0")]
	public static void AODHEIHGBPN(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3220", Offset = "0x7DB2420", VA = "0x187DB3220")]
	public static void EMKHHFBFKOJ(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B300", Offset = "0x3A9A500", VA = "0x183A9B300")]
	public static void EMKHHFBFKOJ<T>(T BNCBJIMFGHJ, MBKHMMMBHDB<T> NPEJLHCJPAI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3530", Offset = "0x7DB2730", VA = "0x187DB3530")]
	public static void HKEJAJCCBKK(Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB35D0", Offset = "0x7DB27D0", VA = "0x187DB35D0")]
	public static void IJCNINNPGMA(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB37D0", Offset = "0x7DB29D0", VA = "0x187DB37D0")]
	public static void PBGIPKNFPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3760", Offset = "0x7DB2960", VA = "0x187DB3760")]
	public static string ONANFIJPEBL(object KFMNDOMPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3680", Offset = "0x7DB2880", VA = "0x187DB3680")]
	public static long MGFONPGFJDC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB30B0", Offset = "0x7DB22B0", VA = "0x187DB30B0")]
	public static bool EEKDMDNDHJF(bool BELLBJOFLIE, string NPEJLHCJPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3150", Offset = "0x7DB2350", VA = "0x187DB3150")]
	public static double EFNACDAFOHC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PEPDDEMKHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly HEJGENDJICD AGOIINEKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly JGANPJEMGLK FDLPCMKEDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly GCIPGAHNEOK OKAGMEHKPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly LICPDFBPEJJ OGFHPKOEGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly DDEOGPIBKKK PKAJJFIEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly HEFNDCIBJMA CBBHPAMLMIG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly GCIPGAHNEOK NMGPNLDAKME;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LICPDFBPEJJ MFLLBOHOPDG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DDEOGPIBKKK OGCEGGNBBKM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly HEFNDCIBJMA ONNEOBEHICO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly PEPDDEMKHLE BCEMEONNHIA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9430", Offset = "0x7DB8630", VA = "0x187DB9430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9DC0", Offset = "0x7DB8FC0", VA = "0x187DB9DC0")]
	public PEPDDEMKHLE([In] HEJGENDJICD CFKDFLAOMDF, [In] JGANPJEMGLK MOIBFDINFIC, GCIPGAHNEOK DAPIBLKKBOL, LICPDFBPEJJ EIEIGOOPNCL, DDEOGPIBKKK APICCJPIFEN, HEFNDCIBJMA HAANIGKILKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DB95C0", Offset = "0x7DB87C0", VA = "0x187DB95C0")]
	private static string DAGICKGKHHO(object KFMNDOMPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70")]
	private static long KBKFMJCANJJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	private static string OLLJKJANCMG(string EBPGPJLLHDI, string? FEJLOJNEDNM, bool OACFKHFEOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	private static bool HCLOOMOJKKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9600", Offset = "0x7DB8800", VA = "0x187DB9600")]
	private static PEPDDEMKHLE FLCKPKIALKF()
	{
		return default(PEPDDEMKHLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EGLBBBAJMFK
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	INIGBIMEDPP IFHDNGBNMHF();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface INIGBIMEDPP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NIFOKHJINBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFBDMEHIPDN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JNAKDKEEAGK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPGNNKCFDOA([In] T CMOCFNBHPLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void LEMBHEKDBJJ<T>([In] T BNCBJIMFGHJ);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct JHCDFNNIJMI<T> : IEquatable<JHCDFNNIJMI<T>>, JNAKDKEEAGK<JHCDFNNIJMI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T LFLEGEJLLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int IJCKDBACFFD;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50472E0", Offset = "0x50464E0", VA = "0x1850472E0")]
	public JHCDFNNIJMI([In] T KJIOHKMJAPE, int CMDFFDAPDIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5045700", Offset = "0x5044900", VA = "0x185045700")]
	public static bool EEDHALGLIEL([In] JHCDFNNIJMI<T> KEAFHNNEEAN, [In] JHCDFNNIJMI<T> FNKKBNJEBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5045A90", Offset = "0x5044C90", VA = "0x185045A90", Slot = "4")]
	public bool Equals(JHCDFNNIJMI<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B249A0", Offset = "0x4B23BA0", VA = "0x184B249A0", Slot = "0")]
	public override bool Equals(object CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5046070", Offset = "0x5045270", VA = "0x185046070")]
	public bool IPGNNKCFDOA([In] JHCDFNNIJMI<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5045C50", Offset = "0x5044E50", VA = "0x185045C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5046940", Offset = "0x5045B40", VA = "0x185046940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5046570", Offset = "0x5045770", VA = "0x185046570")]
	public void PCEFEHILDBC([Out] T KJIOHKMJAPE, [Out] int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50450A0", Offset = "0x50442A0", VA = "0x1850450A0")]
	public (T, int) CBDOGEFJFNN()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x50460F0", Offset = "0x50452F0", VA = "0x1850460F0", Slot = "5")]
	private bool JAJIOFPFMAC([In] JHCDFNNIJMI<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JHNPJMPFENG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3A65920", Offset = "0x3A64B20", VA = "0x183A65920")]
	public static JHCDFNNIJMI<T> FAHGDJGLLGD<T>([In] T KJIOHKMJAPE, int CMDFFDAPDIB) where T : notnull
	{
		return default(JHCDFNNIJMI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LEOIGFBJALA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC49F0", Offset = "0x3AC3BF0", VA = "0x183AC49F0")]
	public static bool IPGNNKCFDOA<T, U>([In] T IPOCHJJJBCM, [In] U KFMNDOMPAMC) where T : notnull, JNAKDKEEAGK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult ALMFPCDJCCJ<T, out TResult>([In] T BNCBJIMFGHJ);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CBMDPIOFABP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan HPAFLGGKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? PONNGIMKDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PDKHLGCCMGJ();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AECAICNGPDC();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPEMLMAHDBI();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HEJGENDJICD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly JNBIEBHCCJN LALFJGAGAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly CJIMCPCCDLK DLLMHIHOIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly JNBIEBHCCJN HFAPJDEJMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly CJIMCPCCDLK EGDDFGDFJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly JNBIEBHCCJN MKNJBJJKLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly CJIMCPCCDLK DLCFJCKEBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly HPFEDHKIEJK LAHNBLDCKIG;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JNBIEBHCCJN FPDADLHOBFF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly CJIMCPCCDLK JBOAJHGFFLK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly JNBIEBHCCJN KCCLOLAFNLI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly CJIMCPCCDLK PCMHMMOIGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JNBIEBHCCJN NOOPIBMKPCM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly CJIMCPCCDLK BAJAIPAMNLP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HPFEDHKIEJK APAOLFACEEF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HEJGENDJICD BCEMEONNHIA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JNBIEBHCCJN PKLNLAJIMAM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0F10", Offset = "0x7DB0110", VA = "0x187DB0F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xDD85B0", Offset = "0xDD77B0", VA = "0x180DD85B0")]
	public HEJGENDJICD(JNBIEBHCCJN PHEOBPJNDJI, CJIMCPCCDLK OOEGPIDAPLD, JNBIEBHCCJN CKOLBHPGDHM, CJIMCPCCDLK NFKHLBCNPGI, JNBIEBHCCJN CJHEJPBCJGC, CJIMCPCCDLK IKJDNOMAGHO, HPFEDHKIEJK DOJGHLLDDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	private static bool JAIPEIGOFFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void KCNDICHGMPH(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	private static bool AKKFGMILOLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void IFGJMBEFGBE(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0")]
	private static bool MFNOCAECCEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void KOMAPNHKGDH(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void MEPIOCCLLKN(Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1310", Offset = "0x7DB0510", VA = "0x187DB1310")]
	private static HEJGENDJICD FLCKPKIALKF()
	{
		return default(HEJGENDJICD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
	private static bool JHNEOKJCDMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0EA0", Offset = "0x7DB00A0", VA = "0x187DB0EA0")]
	public void AODHEIHGBPN(object NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1450", Offset = "0x7DB0650", VA = "0x187DB1450")]
	public void IMGEBDMNIGL(object NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7DB11C0", Offset = "0x7DB03C0", VA = "0x187DB11C0")]
	public void EMKHHFBFKOJ(object NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xDDB390", Offset = "0xDDA590", VA = "0x180DDB390")]
	public void HKEJAJCCBKK(Exception JNDFFCAMALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7DB1230", Offset = "0x7DB0430", VA = "0x187DB1230")]
	public void EMKHHFBFKOJ(JMAFHHMANOH NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B3E0", Offset = "0x3A1A5E0", VA = "0x183A1B3E0")]
	public void EMKHHFBFKOJ<T>(T BNCBJIMFGHJ, MBKHMMMBHDB<T> NPEJLHCJPAI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B260", Offset = "0x3A1A460", VA = "0x183A1B260")]
	public void AODHEIHGBPN<T>([In] T BNCBJIMFGHJ, ECMAGAPALEP<T> NPEJLHCJPAI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A1B4A0", Offset = "0x3A1A6A0", VA = "0x183A1B4A0")]
	public void EMKHHFBFKOJ<T>([In] T BNCBJIMFGHJ, ECMAGAPALEP<T> NPEJLHCJPAI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7DB10F0", Offset = "0x7DB02F0", VA = "0x187DB10F0")]
	public bool EEKDMDNDHJF(bool BELLBJOFLIE, string NPEJLHCJPAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct PKHKKFEDHPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string LFLEGEJLLKE;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xD91890", Offset = "0xD90A90", VA = "0x180D91890")]
	public PKHKKFEDHPF(string KJIOHKMJAPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
	public static string PDHAGBEBCNG([In] PKHKKFEDHPF IPOCHJJJBCM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x23D1A60", Offset = "0x23D0C60", VA = "0x1823D1A60")]
	public static PKHKKFEDHPF PDHAGBEBCNG(string CMOCFNBHPLJ)
	{
		return default(PKHKKFEDHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9F80", Offset = "0x7DB9180", VA = "0x187DB9F80")]
	public string KKCEBPBJLJH(string LGHGMLPIJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB9FD0", Offset = "0x7DB91D0", VA = "0x187DB9FD0")]
	public string KOOALCAEFLL(object LMFDDJEFIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class JKPCMBPLPDC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public JKPCMBPLPDC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct LMEKHMKKIDI : IEquatable<LMEKHMKKIDI>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "4")]
	public bool Equals(LMEKHMKKIDI CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3E40", Offset = "0x7DB3040", VA = "0x187DB3E40", Slot = "0")]
	public override bool Equals(object CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3E90", Offset = "0x7DB3090", VA = "0x187DB3E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3EA0", Offset = "0x7DB30A0", VA = "0x187DB3EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BCDODNINIGM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FCJIGKLFFLA<T> : IEquatable<FCJIGKLFFLA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T LFLEGEJLLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool LEACOLIGMCF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NFFEPMGAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4B23B10", Offset = "0x4B22D10", VA = "0x184B23B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B25DE0", Offset = "0x4B24FE0", VA = "0x184B25DE0")]
	public FCJIGKLFFLA([In] T KJIOHKMJAPE, bool NKJMHLHGNOB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B23D40", Offset = "0x4B22F40", VA = "0x184B23D40")]
	public static bool EEDHALGLIEL([In] FCJIGKLFFLA<T> KEAFHNNEEAN, [In] FCJIGKLFFLA<T> FNKKBNJEBAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4B241D0", Offset = "0x4B233D0", VA = "0x184B241D0", Slot = "4")]
	public bool Equals(FCJIGKLFFLA<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B247B0", Offset = "0x4B239B0", VA = "0x184B247B0", Slot = "0")]
	public override bool Equals(object? CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B24E00", Offset = "0x4B24000", VA = "0x184B24E00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B25770", Offset = "0x4B24970", VA = "0x184B25770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LNIMGJOOBMA
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDED0", Offset = "0x3ACD0D0", VA = "0x183ACDED0")]
	public static FCJIGKLFFLA<T> OPICBOKOACA<T>([In] T KJIOHKMJAPE) where T : notnull
	{
		return default(FCJIGKLFFLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDC60", Offset = "0x3ACCE60", VA = "0x183ACDC60")]
	public static FCJIGKLFFLA<T?> LFFHKDKNIEI<T>()
	{
		return default(FCJIGKLFFLA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDB30", Offset = "0x3ACCD30", VA = "0x183ACDB30")]
	public static bool JBBKMFNHELA<T>([In] this FCJIGKLFFLA<T> LKKFDLPBPLJ, [Out][NotNullWhen(true)] T KJIOHKMJAPE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDAC0", Offset = "0x3ACCCC0", VA = "0x183ACDAC0")]
	public static bool JBBKMFNHELA<T>([In] this FCJIGKLFFLA<T> LKKFDLPBPLJ, [Out][NotNullWhen(true)] T KJIOHKMJAPE, [Out] FCJIGKLFFLA<T> ELKHMJCKPAM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDDB0", Offset = "0x3ACCFB0", VA = "0x183ACDDB0")]
	public static T? MLBPDHBGHEK<T>([In] this FCJIGKLFFLA<T> LKKFDLPBPLJ, T? FEOJADDJKIL)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD9E0", Offset = "0x3ACCBE0", VA = "0x183ACD9E0")]
	public static bool BDCAIIGBHEA<T>([In] this FCJIGKLFFLA<T> LKKFDLPBPLJ, T KJIOHKMJAPE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PBFNIMEGKJF
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC3BB0", Offset = "0x3BC2DB0", VA = "0x183BC3BB0")]
	public static T MDKBOFEMLMH<T>([In] this FCJIGKLFFLA<T> LKKFDLPBPLJ) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct JGANPJEMGLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr IJCNINNPGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr PBGIPKNFPEE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr AAAKAJEACBK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr IGJJGLJOFCN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JGANPJEMGLK BCEMEONNHIA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool AEOGNGCAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2D40", Offset = "0x7DB1F40", VA = "0x187DB2D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB268B0", Offset = "0xB25AB0", VA = "0x180B268B0")]
	public JGANPJEMGLK(IntPtr IEFGPPEBNND, IntPtr EEACJFGMGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void HLKDBLOJMDO(string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void GAAHLNDAGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2E10", Offset = "0x7DB2010", VA = "0x187DB2E10")]
	private static JGANPJEMGLK FLCKPKIALKF()
	{
		return default(JGANPJEMGLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct OFDNPJBJKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr NPJMKPKOMNN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
	private OFDNPJBJKLB(IntPtr EEACJFGMGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8CA0", Offset = "0x7DB7EA0", VA = "0x187DB8CA0")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8CB0", Offset = "0x7DB7EB0", VA = "0x187DB8CB0")]
	public static OFDNPJBJKLB FAHGDJGLLGD(string GBOCGPJOEEK)
	{
		return default(OFDNPJBJKLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x289DD70", Offset = "0x289CF70", VA = "0x18289DD70")]
	public static OFDNPJBJKLB FAHGDJGLLGD([In] JGANPJEMGLK MOIBFDINFIC, string GBOCGPJOEEK)
	{
		return default(OFDNPJBJKLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x289E090", Offset = "0x289D290", VA = "0x18289E090")]
	public static OFDNPJBJKLB FAHGDJGLLGD([In] JGANPJEMGLK MOIBFDINFIC, Func<string> GBOCGPJOEEK)
	{
		return default(OFDNPJBJKLB);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class AICDMKCIMLI : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? PAGGNLMNLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr JJCMKOOFLOI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool FJDPEAAJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DADA60", Offset = "0x7DACC60", VA = "0x187DADA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD570", Offset = "0x7DAC770", VA = "0x187DAD570")]
	public static SHA256 DBJJOAFKEPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD500", Offset = "0x7DAC700", VA = "0x187DAD500")]
	private static extern int AOOLHPNMJKD();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD680", Offset = "0x7DAC880", VA = "0x187DAD680")]
	private static extern IntPtr EMAHNFFGFLM();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DADB50", Offset = "0x7DACD50", VA = "0x187DADB50")]
	private static extern void LFAKMDOHDBO(IntPtr JJCMKOOFLOI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD9A0", Offset = "0x7DACBA0", VA = "0x187DAD9A0")]
	private static extern void KCMALFGKKLA(IntPtr JJCMKOOFLOI, byte[] CAIGHLKIDBF, int GJBFKFHLHKP, int MLJPMEDBNAE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7DADBD0", Offset = "0x7DACDD0", VA = "0x187DADBD0")]
	private static extern void PHDIJHKOGNH(IntPtr JJCMKOOFLOI, byte[] GMJODFANACG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DADC70", Offset = "0x7DACE70", VA = "0x187DADC70")]
	private AICDMKCIMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD6F0", Offset = "0x7DAC8F0", VA = "0x187DAD6F0", Slot = "18")]
	protected override void HashCore(byte[] KBILCKNPAKO, int EIENLMDPNCH, int OJNCLGCJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD7B0", Offset = "0x7DAC9B0", VA = "0x187DAD7B0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD8E0", Offset = "0x7DACAE0", VA = "0x187DAD8E0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD5F0", Offset = "0x7DAC7F0", VA = "0x187DAD5F0", Slot = "13")]
	protected override void Dispose(bool DLKHEECPKFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MGMEHNLABIC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool BLIDMENAPPG<in TInput, TResult>(TInput GLMNBNPBGCG, [Out] TResult ACALKMLJJOL);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class HFJGNDPOAHD : EGLBBBAJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class KGHHHEPBEDH : INIGBIMEDPP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly KGHHHEPBEDH AIBLJDBPKAO;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool NIFOKHJINBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x7DB38F0", Offset = "0x7DB2AF0", VA = "0x187DB38F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7DB3950", Offset = "0x7DB2B50", VA = "0x187DB3950", Slot = "6")]
			public void OnCompleted(Action FHPFPMFGCMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			public void DFBDMEHIPDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public KGHHHEPBEDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly HFJGNDPOAHD AIBLJDBPKAO;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		private HFJGNDPOAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1A70", Offset = "0x7DB0C70", VA = "0x187DB1A70", Slot = "4")]
		public INIGBIMEDPP IFHDNGBNMHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class ILFNOKMGFHJ : EGLBBBAJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class PFONEJEGGCH : INIGBIMEDPP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly PFONEJEGGCH AIBLJDBPKAO;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool NIFOKHJINBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x7DB9E70", Offset = "0x7DB9070", VA = "0x187DB9E70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9E90", Offset = "0x7DB9090", VA = "0x187DB9E90", Slot = "6")]
			public void OnCompleted(Action FHPFPMFGCMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			public void DFBDMEHIPDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public PFONEJEGGCH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly ILFNOKMGFHJ AIBLJDBPKAO;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		private ILFNOKMGFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2C80", Offset = "0x7DB1E80", VA = "0x187DB2C80", Slot = "4")]
		public INIGBIMEDPP IFHDNGBNMHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BEBJMINCEAI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public BEBJMINCEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5634C40", Offset = "0x5633E40", VA = "0x185634C40")]
		internal void IDKFNJCOFDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DDNCFIAGHDA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DDNCFIAGHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4205ED0", Offset = "0x42050D0", VA = "0x184205ED0")]
		internal void CCMBLBPDIAM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BNDKCBPFIBD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAE2F0", Offset = "0x7DAD4F0", VA = "0x187DAE2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BCLCONHNIJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DADE20", Offset = "0x7DAD020", VA = "0x187DADE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA508E0", Offset = "0xA4FAE0", VA = "0x180A508E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct ALAPFIONPDH<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4F35C40", Offset = "0x4F34E40", VA = "0x184F35C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4F35DB0", Offset = "0x4F34FB0", VA = "0x184F35DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OONOKOMECAI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x56341C0", Offset = "0x56333C0", VA = "0x1856341C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x56349F0", Offset = "0x5633BF0", VA = "0x1856349F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FDEEJFDOAOA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAFE10", Offset = "0x7DAF010", VA = "0x187DAFE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0020", Offset = "0x7DAF220", VA = "0x187DB0020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OPNBGCGKNJA<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public OPNBGCGKNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5634C40", Offset = "0x5633E40", VA = "0x185634C40")]
		internal void OLICKDELKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5634BE0", Offset = "0x5633DE0", VA = "0x185634BE0")]
		internal void BHEDLKEJOKO(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct BLHKELBNCNC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public BLIDMENAPPG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6271A40", Offset = "0x6270C40", VA = "0x186271A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x62720F0", Offset = "0x62712F0", VA = "0x1862720F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NPBKJMICMEC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB72D0", Offset = "0x7DB64D0", VA = "0x187DB72D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7AC0", Offset = "0x7DB6CC0", VA = "0x187DB7AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BNLCHPMDMAP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAE450", Offset = "0x7DAD650", VA = "0x187DAE450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE990", Offset = "0x7DADB90", VA = "0x187DAE990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct ODIBGOOAGDM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x560B620", Offset = "0x560A820", VA = "0x18560B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4C9E160", Offset = "0x4C9D360", VA = "0x184C9E160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HCOCKDAJFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<LMEKHMKKIDI> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public HCOCKDAJFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0D90", Offset = "0x7DAFF90", VA = "0x187DB0D90")]
		internal void HJINGNDPACF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct ADJNFGLFPEN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E48170", Offset = "0x4E47370", VA = "0x184E48170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x41CD650", Offset = "0x41CC850", VA = "0x1841CD650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MDNKICAHPOJ<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x53F2D20", Offset = "0x53F1F20", VA = "0x1853F2D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x41CC780", Offset = "0x41CB980", VA = "0x1841CC780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PMADLADBBDA<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5706BB0", Offset = "0x5705DB0", VA = "0x185706BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x57073A0", Offset = "0x57065A0", VA = "0x1857073A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct DHKGFGBAKOC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAF090", Offset = "0x7DAE290", VA = "0x187DAF090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF270", Offset = "0x7DAE470", VA = "0x187DAF270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BFGFHHLIKOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DADF30", Offset = "0x7DAD130", VA = "0x187DADF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE290", Offset = "0x7DAD490", VA = "0x187DAE290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LODMGJODBLP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB48D0", Offset = "0x7DB3AD0", VA = "0x187DB48D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4BC0", Offset = "0x7DB3DC0", VA = "0x187DB4BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EDLLKMEKPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public EDLLKMEKPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF650", Offset = "0x7DAE850", VA = "0x187DAF650")]
		internal Task KKHHKKNNFNJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct LDEJJAANCKK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB3B10", Offset = "0x7DB2D10", VA = "0x187DB3B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3D70", Offset = "0x7DB2F70", VA = "0x187DB3D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct HJBPIFLAJDI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB1B30", Offset = "0x7DB0D30", VA = "0x187DB1B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1D10", Offset = "0x7DB0F10", VA = "0x187DB1D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct EMLMBPIBFHK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAF6C0", Offset = "0x7DAE8C0", VA = "0x187DAF6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFA20", Offset = "0x7DAEC20", VA = "0x187DAFA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct MPJGFJEGBPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB6F80", Offset = "0x7DB6180", VA = "0x187DB6F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7270", Offset = "0x7DB6470", VA = "0x187DB7270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LKPJOFDCBHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public LKPJOFDCBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3DD0", Offset = "0x7DB2FD0", VA = "0x187DB3DD0")]
		internal Task NHOMKMNPMAK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GIJIPDPOBCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB0090", Offset = "0x7DAF290", VA = "0x187DB0090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DB02F0", Offset = "0x7DAF4F0", VA = "0x187DB02F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct OEHEPKMMPEN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB8AC0", Offset = "0x7DB7CC0", VA = "0x187DB8AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8C40", Offset = "0x7DB7E40", VA = "0x187DB8C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct NGLPEFIDOII<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x548CD60", Offset = "0x548BF60", VA = "0x18548CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x548D260", Offset = "0x548C460", VA = "0x18548D260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct ENCMNMEPKKD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DAFA80", Offset = "0x7DAEC80", VA = "0x187DAFA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFDB0", Offset = "0x7DAEFB0", VA = "0x187DAFDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? PELIKOONCOF;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<LMEKHMKKIDI> BICCEHEDPFC;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task LMDOAAIMGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5330", Offset = "0x7DB4530", VA = "0x187DB5330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB51F0", Offset = "0x7DB43F0", VA = "0x187DB51F0")]
	public static bool BJJIOODIECH(this Task MKOPIIJMBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4C50", Offset = "0x3AF3E50", VA = "0x183AF4C50")]
	public static Task<T> NDDOGAMJHCD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4FA0", Offset = "0x7DB41A0", VA = "0x187DB4FA0")]
	public static Task BFCHHMPOJAM(this Task MKOPIIJMBLM, CancellationToken CCLFNPCGNED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF26E0", Offset = "0x3AF18E0", VA = "0x183AF26E0")]
	public static Task<TResult> BFCHHMPOJAM<TResult>(this Task<TResult> MKOPIIJMBLM, CancellationToken CCLFNPCGNED) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1ED0", Offset = "0x3AF10D0", VA = "0x183AF1ED0")]
	public static TaskCompletionSource<TResult> BFCHHMPOJAM<TResult>(this TaskCompletionSource<TResult> EMLEFEFPNEJ, CancellationToken CCLFNPCGNED) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5900", Offset = "0x7DB4B00", VA = "0x187DB5900")]
	public static IDisposable? DOKGBHMBLNJ(CancellationToken PKIGCPBBMBA, CancellationToken DKOKECIBDJO, [Out] CancellationToken JBIAIJLFJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB67D0", Offset = "0x7DB59D0", VA = "0x187DB67D0")]
	[AsyncStateMachine(typeof(BNDKCBPFIBD))]
	public static void PBCFGJNHIAI(this Task DACBPJEFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6550", Offset = "0x7DB5750", VA = "0x187DB6550")]
	[AsyncStateMachine(typeof(BCLCONHNIJG))]
	public static void LFMDKHJOPFF(this Task DACBPJEFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3CA0", Offset = "0x3AF2EA0", VA = "0x183AF3CA0")]
	[AsyncStateMachine(typeof(ALAPFIONPDH<>))]
	public static Task BKNNIEHPNKK<TException>(this Task DACBPJEFOKJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3D70", Offset = "0x3AF2F70", VA = "0x183AF3D70")]
	[AsyncStateMachine(typeof(OONOKOMECAI<>))]
	public static Task<T> BLDBGHDKBLE<T>(this Task<T> IPOCHJJJBCM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5A90", Offset = "0x7DB4C90", VA = "0x187DB5A90")]
	[AsyncStateMachine(typeof(FDEEJFDOAOA))]
	public static Task<TaskStatus> EAOICPACIJH(this Task? IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3F30", Offset = "0x3AF3130", VA = "0x183AF3F30")]
	public static (Task<T?>?, Action<T?>?) DIMKNKHFPDN<T>([Optional] CancellationToken FHBCOAHILMJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF48F0", Offset = "0x3AF3AF0", VA = "0x183AF48F0")]
	[AsyncStateMachine(typeof(BLHKELBNCNC<, >))]
	public static Task<List<TResult>> JNJMHKOOCED<TResult, TInput>(this Task<List<TInput>> MKOPIIJMBLM, BLIDMENAPPG<TInput, TResult> HEAJPNBMCGD) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6000", Offset = "0x7DB5200", VA = "0x187DB6000")]
	[AsyncStateMachine(typeof(NPBKJMICMEC))]
	public static Task ICAGMJMBHEI(Task DACBPJEFOKJ, CancellationToken CDMFGCJPANH, Func<CancellationToken, Task> PKBJNDICOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6420", Offset = "0x7DB5620", VA = "0x187DB6420")]
	[AsyncStateMachine(typeof(BNLCHPMDMAP))]
	public static Task LCLNMNHJDNO(Func<CancellationToken, Task> GENBMGLCFEE, TimeSpan DGJDAIGBCJB, [Optional] CancellationToken CDMFGCJPANH, [Optional] Action<OperationCanceledException>? KKAPCKBCGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AF49F0", Offset = "0x3AF3BF0", VA = "0x183AF49F0")]
	[AsyncStateMachine(typeof(ODIBGOOAGDM<>))]
	public static Task<T> LCLNMNHJDNO<T>(Func<CancellationToken, Task<T>> GENBMGLCFEE, TimeSpan DGJDAIGBCJB, [Optional] CancellationToken CDMFGCJPANH, [Optional] Func<OperationCanceledException, T>? KKAPCKBCGPI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6D40", Offset = "0x7DB5F40", VA = "0x187DB6D40")]
	public static Task PDNEMKPODEE(params Task[] PMJDJAMCDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6880", Offset = "0x7DB5A80", VA = "0x187DB6880")]
	public static Task PDNEMKPODEE(IEnumerable<Task> PMJDJAMCDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4250", Offset = "0x3AF3450", VA = "0x183AF4250")]
	[AsyncStateMachine(typeof(ADJNFGLFPEN<>))]
	public static Task<IEnumerable<Task<T>>> ECDHMJGCLGG<T>(IEnumerable<Task<T>> PMJDJAMCDCG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF47D0", Offset = "0x3AF39D0", VA = "0x183AF47D0")]
	[AsyncStateMachine(typeof(MDNKICAHPOJ<, , >))]
	public static Task<(T1, T2, T3)> HCLJCCOEDFB<T1, T2, T3>(Task<T1> AAFDALOIGAK, Task<T2> DDMOAPDFPNL, Task<T3> KDGJPOFIBPJ) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4510", Offset = "0x3AF3710", VA = "0x183AF4510")]
	[AsyncStateMachine(typeof(PMADLADBBDA<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> HCLJCCOEDFB<T1, T2, T3, T4, T5>(Task<T1> AAFDALOIGAK, Task<T2> DDMOAPDFPNL, Task<T3> KDGJPOFIBPJ, Task<T4> FPDGLGACFED, Task<T5> DEEHGGBAJEF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5810", Offset = "0x7DB4A10", VA = "0x187DB5810")]
	[AsyncStateMachine(typeof(DHKGFGBAKOC))]
	public static Task DOHLKNNBCFH(Func<bool> BELLBJOFLIE, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5700", Offset = "0x7DB4900", VA = "0x187DB5700")]
	[AsyncStateMachine(typeof(BFGFHHLIKOO))]
	public static Task DOHLKNNBCFH(Func<bool> BELLBJOFLIE, TimeSpan FDEJBONCHCK, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5B80", Offset = "0x7DB4D80", VA = "0x187DB5B80")]
	[AsyncStateMachine(typeof(LODMGJODBLP))]
	public static Task EDLNKHMMPBD(Func<bool> BELLBJOFLIE, TimeSpan DGJDAIGBCJB, [Optional] CancellationToken FHBCOAHILMJ, [Optional] Action<OperationCanceledException>? KKAPCKBCGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5CB0", Offset = "0x7DB4EB0", VA = "0x187DB5CB0")]
	[AsyncStateMachine(typeof(LDEJJAANCKK))]
	public static Task EDLNKHMMPBD(Func<bool> BELLBJOFLIE, TimeSpan DGJDAIGBCJB, TimeSpan FDEJBONCHCK, [Optional] CancellationToken FHBCOAHILMJ, [Optional] Action<OperationCanceledException>? KKAPCKBCGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4D30", Offset = "0x7DB3F30", VA = "0x187DB4D30")]
	[AsyncStateMachine(typeof(HJBPIFLAJDI))]
	public static Task AFKPJMNAAIP(Func<bool> BELLBJOFLIE, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4C20", Offset = "0x7DB3E20", VA = "0x187DB4C20")]
	[AsyncStateMachine(typeof(EMLMBPIBFHK))]
	public static Task AFKPJMNAAIP(Func<bool> BELLBJOFLIE, TimeSpan FDEJBONCHCK, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7DB61B0", Offset = "0x7DB53B0", VA = "0x187DB61B0")]
	[AsyncStateMachine(typeof(MPJGFJEGBPO))]
	public static Task KFDNFELNJOC(Func<bool> BELLBJOFLIE, TimeSpan DGJDAIGBCJB, [Optional] CancellationToken FHBCOAHILMJ, [Optional] Action<OperationCanceledException>? KKAPCKBCGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7DB62E0", Offset = "0x7DB54E0", VA = "0x187DB62E0")]
	[AsyncStateMachine(typeof(GIJIPDPOBCD))]
	public static Task KFDNFELNJOC(Func<bool> BELLBJOFLIE, TimeSpan DGJDAIGBCJB, TimeSpan FDEJBONCHCK, [Optional] CancellationToken FHBCOAHILMJ, [Optional] Action<OperationCanceledException>? KKAPCKBCGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5EC0", Offset = "0x7DB50C0", VA = "0x187DB5EC0")]
	[AsyncStateMachine(typeof(OEHEPKMMPEN))]
	[Obsolete]
	public static Task FJONOCGGLAH(this Task MKOPIIJMBLM, Action EEBMCPCEDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4330", Offset = "0x3AF3530", VA = "0x183AF4330")]
	[AsyncStateMachine(typeof(NGLPEFIDOII<>))]
	[Obsolete]
	public static Task FJONOCGGLAH<T>(this Task<T> MKOPIIJMBLM, Action<T> EEBMCPCEDCF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4EF0", Offset = "0x7DB40F0", VA = "0x187DB4EF0")]
	private static void BEKFAEJPKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7DB53A0", Offset = "0x7DB45A0", VA = "0x187DB53A0")]
	public static bool DOGMAFPFPJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6600", Offset = "0x7DB5800", VA = "0x187DB6600")]
	private static void MIHKBAGLJCG(SynchronizationContext KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5220", Offset = "0x7DB4420", VA = "0x187DB5220")]
	private static void CBKNJEBCIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5DF0", Offset = "0x7DB4FF0", VA = "0x187DB5DF0")]
	public static void FHFHHLAFPOP([Optional] string? NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6130", Offset = "0x7DB5330", VA = "0x187DB6130")]
	public static void JKAAFPAGONF([Optional] string? NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB6780", Offset = "0x7DB5980", VA = "0x187DB6780")]
	public static EGLBBBAJMFK PAAMJPAJJJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB5FB0", Offset = "0x7DB51B0", VA = "0x187DB5FB0")]
	public static EGLBBBAJMFK HIIMDOEFBEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4E20", Offset = "0x7DB4020", VA = "0x187DB4E20")]
	[AsyncStateMachine(typeof(ENCMNMEPKKD))]
	public static Task ALABMNKMEJD(Func<Task> PJBCEMJEHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CBAABKHKLJM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public CBAABKHKLJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class HANKJMMHBLF
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0B50", Offset = "0x7DAFD50", VA = "0x187DB0B50")]
	public static bool LAOEIJDMAGE(this NPOMJDLOFMO MAIKCJNFNGF, DateTime EOFGMPOEAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0C70", Offset = "0x7DAFE70", VA = "0x187DB0C70")]
	public static TimeSpan MPBELGAHLFK(this NPOMJDLOFMO MAIKCJNFNGF, DateTime EOFGMPOEAIK)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DLKLCAEAMAA : NPOMJDLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly NPOMJDLOFMO AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime GLPMLLPCAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF330", Offset = "0x7DAE530", VA = "0x187DAF330", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset ODBDBBJHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF2D0", Offset = "0x7DAE4D0", VA = "0x187DAF2D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DLKLCAEAMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface NPOMJDLOFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime GLPMLLPCAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset ODBDBBJHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HAIHLCAFLKK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long JDLBODAGDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7DB03F0", Offset = "0x7DAF5F0", VA = "0x187DB03F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long IIIBFFKAKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0350", Offset = "0x7DAF550", VA = "0x187DB0350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double MJFJAMADHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0540", Offset = "0x7DAF740", VA = "0x187DB0540")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double HJKAPOJAPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0620", Offset = "0x7DAF820", VA = "0x187DB0620")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double JBIGPOLIDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7DB03A0", Offset = "0x7DAF5A0", VA = "0x187DB03A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double OEAHADPICLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7DB07D0", Offset = "0x7DAF9D0", VA = "0x187DB07D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0740", Offset = "0x7DAF940", VA = "0x187DB0740")]
	public static double NIBIDICBADN(long DGLDDMGNCLM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0820", Offset = "0x7DAFA20", VA = "0x187DB0820")]
	public static double POFKMFAPEEP(long DGLDDMGNCLM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0440", Offset = "0x7DAF640", VA = "0x187DB0440")]
	public static double FIBBOKCKOCD(double BJKDBONLPFE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0590", Offset = "0x7DAF790", VA = "0x187DB0590")]
	public static long JEHMEHOGGDH(long GKFLGCPHKEK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0530", Offset = "0x7DAF730", VA = "0x187DB0530")]
	public static long HFNBOECHKIJ(long JOMLBGOEMHO, long ENHOEHINEOA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB0670", Offset = "0x7DAF870", VA = "0x187DB0670")]
	public static double NAICEEBLDCF(long JOMLBGOEMHO, long ENHOEHINEOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7DB04D0", Offset = "0x7DAF6D0", VA = "0x187DB04D0")]
	public static double GDNJHHEDDNE(long JOMLBGOEMHO, long ENHOEHINEOA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class LNFEOPPGADG : CBMDPIOFABP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan BPHFADJMDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer LAEALHELJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan DGJDAIGBCJB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan HPAFLGGKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4390", Offset = "0x7DB3590", VA = "0x187DB4390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? PONNGIMKDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4620", Offset = "0x7DB3820", VA = "0x187DB4620")]
	[Preserve]
	public LNFEOPPGADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4680", Offset = "0x7DB3880", VA = "0x187DB4680")]
	public LNFEOPPGADG(TimeSpan DGJDAIGBCJB, [Optional] Action? AGJLAJPBKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7DB44F0", Offset = "0x7DB36F0", VA = "0x187DB44F0", Slot = "7")]
	public void PDKHLGCCMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7DB41F0", Offset = "0x7DB33F0", VA = "0x187DB41F0", Slot = "8")]
	public void AECAICNGPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4580", Offset = "0x7DB3780", VA = "0x187DB4580", Slot = "9")]
	public void PPEMLMAHDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1175330", Offset = "0x1174530", VA = "0x181175330")]
	private void FACABJGDCEN(object LDINAKFKJDF, ElapsedEventArgs EACBCPMEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4300", Offset = "0x7DB3500", VA = "0x187DB4300")]
	private static void IGOCMAGGLCN(TimeSpan JDKPNADKFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4260", Offset = "0x7DB3460", VA = "0x187DB4260", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class BCDODNINIGM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? CEGNDFCFEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string ENNIBIAAHEM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1795C70", Offset = "0x1794E70", VA = "0x181795C70")]
	public BCDODNINIGM(string AOOEEPGFGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5020E40", Offset = "0x5020040", VA = "0x185020E40")]
	public BCDODNINIGM(string BGOPKLLOOIA, string AOOEEPGFGKK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OBLBHHNOHDI : IEquatable<OBLBHHNOHDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint OHNKMOHLCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int NHBHLNJBPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float NLIFFDKFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort GENOMLDKEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort GKOHKHOHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short KEFMJONFLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short KFFGEOGNEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char NKHGLKJFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char IDICLHDPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte KKGAICHHIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte BPGBIGBBPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte IOHBENNHCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HKGLDALPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool FFGBGKOKOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool KBKMBECENLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool ALPAEAMELGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool IMKHDMMABBC;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D1D0", Offset = "0x1F5C3D0", VA = "0x181F5D1D0")]
	public static OBLBHHNOHDI LJAKKPPOMDD(uint MDNGBOGCPOG)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D1D0", Offset = "0x1F5C3D0", VA = "0x181F5D1D0")]
	public static OBLBHHNOHDI JBONFBBFJKE(int GMMEMBEBJMD)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7C50", Offset = "0x7DB6E50", VA = "0x187DB7C50")]
	public static OBLBHHNOHDI NOMNKFBPHOH(float DBOCIIDADED)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7BA0", Offset = "0x7DB6DA0", VA = "0x187DB7BA0")]
	public static OBLBHHNOHDI LELMMFHIAJI(byte NMFKFKALCDB, byte IJGMDENKKEO, byte GCLGLGPLGOA, byte BJOKHCEOCEP)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7BA0", Offset = "0x7DB6DA0", VA = "0x187DB7BA0")]
	public static OBLBHHNOHDI PDCIAHIFHND(bool ENCBHAGKELN, bool LMGMJAIDKLD, bool MNHFOHKDPCL, bool GFFFPEHCALH)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7BA0", Offset = "0x7DB6DA0", VA = "0x187DB7BA0")]
	public static OBLBHHNOHDI EBNLHJMGEBK(byte AEOJHHNDFHM, byte CMJGFIJMAJC, byte BIEOOIHAGFI, byte MICJLHNOCIO)
	{
		return default(OBLBHHNOHDI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2273CB0", Offset = "0x2272EB0", VA = "0x182273CB0")]
	public static bool EEDHALGLIEL(OBLBHHNOHDI LNELGBOPHHN, OBLBHHNOHDI CKNMBJOIDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2273C90", Offset = "0x2272E90", VA = "0x182273C90", Slot = "4")]
	public bool Equals(OBLBHHNOHDI CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7BC0", Offset = "0x7DB6DC0", VA = "0x187DB7BC0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x13D8CD0", Offset = "0x13D7ED0", VA = "0x1813D8CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7C60", Offset = "0x7DB6E60", VA = "0x187DB7C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct ABGHMGMBKGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong ENCKOCIDLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long HADCHIJFPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double CICIHPCJNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint NMHEALEICGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint MFKDMKBDIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int OPEMILPCIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int KAMDPACACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float GNDBHLKJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float NAKLHKLPNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort GENOMLDKEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort GKOHKHOHNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort LCLBNLIIBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort APDENBLJKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short KEFMJONFLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short KFFGEOGNEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short NEDIPHBOPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short FMMOLCCIIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char NKHGLKJFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char IDICLHDPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char KCKFPBDENBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char NHEJMOCKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte KKGAICHHIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte BPGBIGBBPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte IOHBENNHCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte HKGLDALPHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte OIHELBDDHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte EDPKAGCMDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte LKAFGKNKAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte PIGMADJJPAL;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static ABGHMGMBKGC FAHGDJGLLGD(long GLEDOHBNFKK)
	{
		return default(ABGHMGMBKGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7DAD4B0", Offset = "0x7DAC6B0", VA = "0x187DAD4B0")]
	public static ABGHMGMBKGC FAHGDJGLLGD(byte NMFKFKALCDB, byte IJGMDENKKEO, byte GCLGLGPLGOA, byte BJOKHCEOCEP, byte LDDHEGEHGBN, byte GHODPHMOEHJ, byte PPCFJIKFBMI, byte MBMLFMHDBLK)
	{
		return default(ABGHMGMBKGC);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct LMNBFJHFOFB : IEquatable<LMNBFJHFOFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte DDPOIDFCBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool COOBKMMJABO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2F72600", Offset = "0x2F71800", VA = "0x182F72600")]
	public static LMNBFJHFOFB LELMMFHIAJI(byte CHPIENLLLJO)
	{
		return default(LMNBFJHFOFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2F72600", Offset = "0x2F71800", VA = "0x182F72600")]
	public static LMNBFJHFOFB PDCIAHIFHND(bool GLMEIPAHNKJ)
	{
		return default(LMNBFJHFOFB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3ED0", Offset = "0x7DB30D0", VA = "0x187DB3ED0")]
	public static bool EEDHALGLIEL(LMNBFJHFOFB LNELGBOPHHN, LMNBFJHFOFB CKNMBJOIDBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFC60", Offset = "0x6CCEE60", VA = "0x186CCFC60", Slot = "4")]
	public bool Equals(LMNBFJHFOFB CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3EE0", Offset = "0x7DB30E0", VA = "0x187DB3EE0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3F70", Offset = "0x7DB3170", VA = "0x187DB3F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3F80", Offset = "0x7DB3180", VA = "0x187DB3F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CMANDAIMCAA<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T EGBFFKEKEPD;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x67DD1A0", Offset = "0x67DC3A0", VA = "0x1867DD1A0")]
	public CMANDAIMCAA(T OMAGLFBPMHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class BPPOHBAFEIC
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3791E50", Offset = "0x3791050", VA = "0x183791E50")]
	public static IEnumerable<T> GOHAFLDKJNA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static T[] HILIDFDFKNA<T>(params T[] PEHACAAHPIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static IEnumerable<T> NHPPCLJGIJF<T>(params T[] PEHACAAHPIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static HashSet<T> OLLDFFPPENN<T>(params T[] PEHACAAHPIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3791EE0", Offset = "0x37910E0", VA = "0x183791EE0")]
	public static KeyValuePair<TKey, TValue> PMKOGEKOGOA<TKey, TValue>([In] TKey MHDODBCCAJB, [In] TValue KJIOHKMJAPE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3791E70", Offset = "0x3791070", VA = "0x183791E70")]
	public static List<T> PNLDNCHHKBC<T>(IEnumerable<T> ICAAOCBKPPE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NEFJCFDOGOE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string CPOAFNMACNG;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
	public NEFJCFDOGOE(string DIFDEOAGFLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object ECMAGAPALEP<T>([In] T CCEPNMMABPI);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object MBKHMMMBHDB<T>(T CCEPNMMABPI);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FIKMFILHHDD]
public delegate string DDEOGPIBKKK(string EBPGPJLLHDI, string? FEJLOJNEDNM, bool OACFKHFEOJH);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[FIKMFILHHDD]
public delegate void CJIMCPCCDLK(string NPEJLHCJPAI);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FIKMFILHHDD]
public delegate void HPFEDHKIEJK(Exception JNDFFCAMALC);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object JMAFHHMANOH();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[FIKMFILHHDD]
public delegate bool JNBIEBHCCJN();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FIKMFILHHDD]
public delegate string GCIPGAHNEOK(object KFMNDOMPAMC);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class AGPAJCIPFHL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public AGPAJCIPFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class OPILOJCFDIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HODNOOODPFF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7DB1DE0", Offset = "0x7DB0FE0", VA = "0x187DB1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DB26D0", Offset = "0x7DB18D0", VA = "0x187DB26D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback IKBCBDFABGC;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> NFCOGKGMJOC;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8FD0", Offset = "0x7DB81D0", VA = "0x187DB8FD0")]
	public static Task<bool> JAHNGDHGLJP(int LFNDNPIACPN, [Optional] CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8D80", Offset = "0x7DB7F80", VA = "0x187DB8D80")]
	[AsyncStateMachine(typeof(HODNOOODPFF))]
	private static Task<bool> ALAIPGEDOHD(int LFNDNPIACPN, CancellationToken FHBCOAHILMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8F40", Offset = "0x7DB8140", VA = "0x187DB8F40")]
	private static void BJIGNFMICJE(object? CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7DB8EB0", Offset = "0x7DB80B0", VA = "0x187DB8EB0")]
	private static void AOJKHHMANEI(object? CKCKEFFHJAP)
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
