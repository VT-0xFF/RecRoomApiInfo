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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x792B6A0", Offset = "0x792AAA0", VA = "0x18792B6A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HPKDDKMGOHN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7927B00", Offset = "0x7926F00", VA = "0x187927B00")]
	public static string GDHEONACOIK(this Encoding BAIOMFLCBGN, [In] ReadOnlySequence<byte> FIKLNMFCLIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x363FD80", Offset = "0x363F180", VA = "0x18363FD80")]
	private static void CDMOOIJHDAL<T>(this ReadOnlySequence<T> IDLIAABJGAD, [Out] ReadOnlySpan<T> GKJLFKKJPLC, [Out] SequencePosition NAPPKJDDPAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BNPPAKJLEDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7923570", Offset = "0x7922970", VA = "0x187923570")]
	public BNPPAKJLEDM(bool KLPCHHPOKPO, string DPCIKMFLGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7923520", Offset = "0x7922920", VA = "0x187923520")]
	public BNPPAKJLEDM(bool KLPCHHPOKPO, params string[] GKAIFGIBNJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EICHCIJOOOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AMIEMCOBOFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HCJFDLPOOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJCMACEDHDF(string MCBJECJLDOM, double FIIKLGCIAGG, [Optional] string? LENBKKFEHIM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GJBMPOCOFGD : NGMOCKOGNJJ, MMNGFEBKGLC, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KKJOPEPGFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MIJOIJPKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double IPECBHNLFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double HJCBHKAGEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double FMGIIPNJDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int KKIGLOILEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double BLALKOBJMID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PANIGGDKNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF910", Offset = "0x9AED10", VA = "0x1809AF910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HODKKBOFBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79276B0", Offset = "0x7926AB0", VA = "0x1879276B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JBANPGPAABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52D01C0", Offset = "0x52CF5C0", VA = "0x1852D01C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double GIFENEBJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x25E74D0", Offset = "0x25E68D0", VA = "0x1825E74D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7927710", Offset = "0x7926B10", VA = "0x187927710")]
	public GJBMPOCOFGD(int NMJLGAKPFGE, double BLALKOBJMID = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7927580", Offset = "0x7926980", VA = "0x187927580", Slot = "7")]
	public void DBJNJHFMAEO(double NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7927410", Offset = "0x7926810", VA = "0x187927410", Slot = "8")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7927480", Offset = "0x7926880", VA = "0x187927480", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HKPEPKOLHFO : NGMOCKOGNJJ, MMNGFEBKGLC, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long PPLOBPJCNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double ADILDBPIBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double CDKMFOMFKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double IMFJMHNIFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double HNAAIDNIGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double IPECBHNLFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double HJCBHKAGEBL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JBANPGPAABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FC40", Offset = "0x6C4F040", VA = "0x186C4FC40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GIFENEBJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F7E0", Offset = "0x6C4EBE0", VA = "0x186C4F7E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double BGEIDADEBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FC70", Offset = "0x6C4F070", VA = "0x186C4FC70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HODKKBOFBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2C76880", Offset = "0x2C75C80", VA = "0x182C76880", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79279E0", Offset = "0x7926DE0", VA = "0x1879279E0", Slot = "10")]
	public virtual void DBJNJHFMAEO(double NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7927930", Offset = "0x7926D30", VA = "0x187927930", Slot = "11")]
	public virtual void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7927970", Offset = "0x7926D70", VA = "0x187927970", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79238D0", Offset = "0x7922CD0", VA = "0x1879238D0")]
	public HKPEPKOLHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CGJAAHCCEHE : HKPEPKOLHFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MMGAHBGFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FC50", Offset = "0x6C4F050", VA = "0x186C4FC50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FCC0", Offset = "0x6C4F0C0", VA = "0x186C4FCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79237A0", Offset = "0x7922BA0", VA = "0x1879237A0", Slot = "10")]
	public override void DBJNJHFMAEO(double NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7923760", Offset = "0x7922B60", VA = "0x187923760", Slot = "11")]
	public override void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79238D0", Offset = "0x7922CD0", VA = "0x1879238D0")]
	public CGJAAHCCEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NGMOCKOGNJJ : MMNGFEBKGLC, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HODKKBOFBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JBANPGPAABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double GIFENEBJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EBOKGMAPLKO : MMNGFEBKGLC, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double KCLIKBNPANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double FGBNNDOCDIB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7924DC0", Offset = "0x79241C0", VA = "0x187924DC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7889D90", Offset = "0x7889190", VA = "0x187889D90", Slot = "4")]
	public void DBJNJHFMAEO(double NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7924D60", Offset = "0x7924160", VA = "0x187924D60", Slot = "5")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7924D70", Offset = "0x7924170", VA = "0x187924D70", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public EBOKGMAPLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MMNGFEBKGLC : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBJNJHFMAEO(double NMBONOELKFM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNJFGCHCFHB();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EELOIGJAHNN : MMNGFEBKGLC, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double FIIKLGCIAGG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4325F10", Offset = "0x4325310", VA = "0x184325F10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD89A0", Offset = "0x4FD7DA0", VA = "0x184FD89A0", Slot = "4")]
	public void DBJNJHFMAEO(double NMBONOELKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7924DD0", Offset = "0x79241D0", VA = "0x187924DD0", Slot = "5")]
	public void CNJFGCHCFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7924DE0", Offset = "0x79241E0", VA = "0x187924DE0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public EELOIGJAHNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFIPKFFPGJG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> ACMJEBGBLCO(CancellationToken BLABAMPAGAH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CBHIEMIMNLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NFIPKFFPGJG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public ACMJEBGBLCO taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x6130320", Offset = "0x612F720", VA = "0x186130320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61313E0", Offset = "0x61307E0", VA = "0x1861313E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource CGAKGMDNBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? OJGCLLHMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? KGHKNKGFNKJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5018AF0", Offset = "0x5017EF0", VA = "0x185018AF0")]
	[AsyncStateMachine(typeof(NFIPKFFPGJG<>.CBHIEMIMNLM))]
	public Task<TResult> IENJMIFEKLM(ACMJEBGBLCO BNGCKEBNIJD, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5018A80", Offset = "0x5017E80", VA = "0x185018A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5018C30", Offset = "0x5018030", VA = "0x185018C30")]
	public NFIPKFFPGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EHDEDNPLBHD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> FAIPJAIOFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T HNMCNCHEPGK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x427E5D0", Offset = "0x427D9D0", VA = "0x18427E5D0")]
	public EHDEDNPLBHD([In] T FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x427D990", Offset = "0x427CD90", VA = "0x18427D990", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x427DF20", Offset = "0x427D320", VA = "0x18427DF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x427E270", Offset = "0x427D670", VA = "0x18427E270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HLPPNNMCGGE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static EHDEDNPLBHD<T> AFLKMMODJAC<T>([In] T FIIKLGCIAGG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GEHMJGKBNFL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7926BE0", Offset = "0x7925FE0", VA = "0x187926BE0")]
	public static void FKEGHMONGFK(this CancellationTokenSource CGAKGMDNBAB, bool AJOOKNFMMJK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class GILOPCIJCPA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
	public GILOPCIJCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class AMAFACFOGFD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
	public AMAFACFOGFD(string NMEDDJFBMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LMGDBPIBGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36D9B70", Offset = "0x36D8F70", VA = "0x1836D9B70")]
	public static DABELDDEOKF JLIFAEHEFAO<T>()
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36D99D0", Offset = "0x36D8DD0", VA = "0x1836D99D0")]
	public static DABELDDEOKF HHMKHNIGONE<T>([CallerMemberName] string MPGDCPPMNJN = "") where T : notnull
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36D9BF0", Offset = "0x36D8FF0", VA = "0x1836D9BF0")]
	public static DABELDDEOKF JLIFAEHEFAO<T>(this T OICAMEEFOOB) where T : notnull
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36D9780", Offset = "0x36D8B80", VA = "0x1836D9780")]
	public static DABELDDEOKF CDNHFIAINCD<T>(this T OICAMEEFOOB, [CallerMemberName] string MPGDCPPMNJN = "") where T : notnull
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36D9920", Offset = "0x36D8D20", VA = "0x1836D9920")]
	public static DABELDDEOKF HHMKHNIGONE<T>(this T CAMFIHKHJNG, [CallerMemberName] string MPGDCPPMNJN = "") where T : notnull
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7929C50", Offset = "0x7929050", VA = "0x187929C50")]
	public static DABELDDEOKF HHMKHNIGONE(string NKHGLFGEGOI, [CallerMemberName] string MPGDCPPMNJN = "")
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7929CD0", Offset = "0x79290D0", VA = "0x187929CD0")]
	public static string PIMEMJFHDPH(this object CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool FAPMIPFCDLA();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[GILOPCIJCPA]
public delegate long NGPDMPCNECN();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BHEHFHPJBNA
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static NLCKNNEHCIH BCFBCOECNJF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NLCKNNEHCIH MDOJBCMGGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x79229D0", Offset = "0x7921DD0", VA = "0x1879229D0")]
		get
		{
			return default(NLCKNNEHCIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EJLACCJGNKG BGBBJEALPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79228B0", Offset = "0x7921CB0", VA = "0x1879228B0")]
		get
		{
			return default(EJLACCJGNKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static FHMIMFDBLGE JGKDEMPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79226D0", Offset = "0x7921AD0", VA = "0x1879226D0")]
		get
		{
			return default(FHMIMFDBLGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool PAFGLEIHEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7922320", Offset = "0x7921720", VA = "0x187922320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7922460", Offset = "0x7921860", VA = "0x187922460")]
	public static void EALKMJIBGGG([In] NLCKNNEHCIH DMEBOJHBABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7922390", Offset = "0x7921790", VA = "0x187922390")]
	public static void DLBCFJLNCHA(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7922900", Offset = "0x7921D00", VA = "0x187922900")]
	public static void LMAJAPFLJFK(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x335D380", Offset = "0x335C780", VA = "0x18335D380")]
	public static void LMAJAPFLJFK<T>(T PKKPPHDAMAG, LMHLKIJDCME<T> EIGJGBPHOMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7922280", Offset = "0x7921680", VA = "0x187922280")]
	public static void BFPPKKGCBDD(Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7922830", Offset = "0x7921C30", VA = "0x187922830")]
	public static void KIICCLDKOGL(string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79227C0", Offset = "0x7921BC0", VA = "0x1879227C0")]
	public static void GMKPHPDCPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7922A90", Offset = "0x7921E90", VA = "0x187922A90")]
	public static string PIMEMJFHDPH(object HAPOBHMBDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7922A20", Offset = "0x7921E20", VA = "0x187922A20")]
	public static long OIHIAOFFGEL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7922720", Offset = "0x7921B20", VA = "0x187922720")]
	public static bool FPPEDICBAND(bool IJHHPJHHECF, string EIGJGBPHOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7922600", Offset = "0x7921A00", VA = "0x187922600")]
	public static double EOJOBBBMJJN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct NLCKNNEHCIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EJLACCJGNKG BGBBJEALPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly FHMIMFDBLGE JGKDEMPPPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly IDBNENMJBGN OJAAIBNNFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NGPDMPCNECN GDPFIKAKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly DLJIMKFLICL OMIGHOMJOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly FAPMIPFCDLA PMCGILKNIPN;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IDBNENMJBGN DPICKPFKLHC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NGPDMPCNECN KCNBCKNHNAP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DLJIMKFLICL GBAOMGEEHAI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly FAPMIPFCDLA EKGHEHNBEOA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NLCKNNEHCIH OGOLFLHIENG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKHINNGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x792A800", Offset = "0x7929C00", VA = "0x18792A800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x792B190", Offset = "0x792A590", VA = "0x18792B190")]
	public NLCKNNEHCIH([In] EJLACCJGNKG PLKMPBNGCIP, [In] FHMIMFDBLGE BEPEIHDAKAD, IDBNENMJBGN LNGMDMOIEJJ, NGPDMPCNECN BDCPKJIKNPD, DLJIMKFLICL EFHPPKBMONE, FAPMIPFCDLA DPFJMCCAOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x792A990", Offset = "0x7929D90", VA = "0x18792A990")]
	private static string HBKOHOEBNHC(object HAPOBHMBDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
	private static long NEAFAFFILLC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	private static string PANEHCBNGBP(string DBFOBELGJDB, string? KDFAHKIFEME, bool DDAAHMMOMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	private static bool LIINMOIBEPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x792A9D0", Offset = "0x7929DD0", VA = "0x18792A9D0")]
	private static NLCKNNEHCIH PMNEADMJNLA()
	{
		return default(NLCKNNEHCIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PMBAOJAOIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONFPPECLDBF JAGFCPCIBCF();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ONFPPECLDBF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OKPEPBABHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFBAOFBCOBL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HJNFDBCIDLF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCDAFEHLJPN([In] T JAPIEEBOJEA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void CLLBMJHPLID<T>([In] T PKKPPHDAMAG);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct PHEFPMPNNDP<T> : IEquatable<PHEFPMPNNDP<T>>, HJNFDBCIDLF<PHEFPMPNNDP<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T HNMCNCHEPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int BNBIOAJGDHO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x52D7A00", Offset = "0x52D6E00", VA = "0x1852D7A00")]
	public PHEFPMPNNDP([In] T FIIKLGCIAGG, int KDCAMOIGIMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52D6390", Offset = "0x52D5790", VA = "0x1852D6390")]
	public static bool IGEKHAEJGKN([In] PHEFPMPNNDP<T> AJLPPHLPDOI, [In] PHEFPMPNNDP<T> PODDNHBLFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x49B5970", Offset = "0x49B4D70", VA = "0x1849B5970", Slot = "4")]
	public bool Equals(PHEFPMPNNDP<T> JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4D95E20", Offset = "0x4D95220", VA = "0x184D95E20", Slot = "0")]
	public override bool Equals(object JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52D7150", Offset = "0x52D6550", VA = "0x1852D7150")]
	public bool PCDAFEHLJPN([In] PHEFPMPNNDP<T> JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52D60E0", Offset = "0x52D54E0", VA = "0x1852D60E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52D73E0", Offset = "0x52D67E0", VA = "0x1852D73E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x52D6900", Offset = "0x52D5D00", VA = "0x1852D6900")]
	public void KGKDCLGKMAN([Out] T FIIKLGCIAGG, [Out] int KDCAMOIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x52D59D0", Offset = "0x52D4DD0", VA = "0x1852D59D0")]
	public (T, int) CDDKDHLBGCC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x52D7100", Offset = "0x52D6500", VA = "0x1852D7100", Slot = "5")]
	private bool LDFHJCHICMF([In] PHEFPMPNNDP<T> JAPIEEBOJEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NFJAJFCJNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3798D30", Offset = "0x3798130", VA = "0x183798D30")]
	public static PHEFPMPNNDP<T> AFLKMMODJAC<T>([In] T FIIKLGCIAGG, int KDCAMOIGIMA) where T : notnull
	{
		return default(PHEFPMPNNDP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OGLAKBGAPFE
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x37CCEC0", Offset = "0x37CC2C0", VA = "0x1837CCEC0")]
	public static bool PCDAFEHLJPN<T, U>([In] T CAMFIHKHJNG, [In] U HAPOBHMBDHP) where T : notnull, HJNFDBCIDLF<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult IGEEPPCEGAG<T, out TResult>([In] T PKKPPHDAMAG);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OFEANNAAJIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan NIJJBJDJEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? AJAGPAMLNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJDEIJAKKMA();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JAFGPJHKJAD();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMMAKLHENCD();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EJLACCJGNKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly LKNFKOCDAPC KMLDPCLAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly ANJKIGNIMOG ADEFMIKDPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LKNFKOCDAPC HGHCEMLOGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly ANJKIGNIMOG IGKGLGNKPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LKNFKOCDAPC CGANPPPDCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly ANJKIGNIMOG BBPALODMMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly BPNJBDIMHAE CEALBMPGMMF;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly LKNFKOCDAPC GHOEGIKJEKH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly ANJKIGNIMOG ELJJDGHEKFP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LKNFKOCDAPC KOFAGDOMMMG;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly ANJKIGNIMOG FGICKJOJLHD;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LKNFKOCDAPC AGEPHGJPPOO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly ANJKIGNIMOG CFNMIKBOJMA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly BPNJBDIMHAE DNMGLGLNIGK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EJLACCJGNKG OGOLFLHIENG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly LKNFKOCDAPC IMAHJAKNOEM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JKHINNGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7924F70", Offset = "0x7924370", VA = "0x187924F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xCC9DD0", Offset = "0xCC91D0", VA = "0x180CC9DD0")]
	public EJLACCJGNKG(LKNFKOCDAPC EOCGHCEMMKE, ANJKIGNIMOG COHFHGLKGIJ, LKNFKOCDAPC IGIDBNNHMHF, ANJKIGNIMOG GHKHIPLLAFL, LKNFKOCDAPC BOOAJDFMGCB, ANJKIGNIMOG DKGGMENGEKE, BPNJBDIMHAE PPMCECKMLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	private static bool KLIDHCDHPBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void EMDCDEEBLGI(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	private static bool LIJLCCIGEKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void BPMHHPMADEC(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10")]
	private static bool HFGKLNEBBKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void FGLNDJMIAOE(string EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void LLFCIOAKNBJ(Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7925310", Offset = "0x7924710", VA = "0x187925310")]
	private static EJLACCJGNKG PMNEADMJNLA()
	{
		return default(EJLACCJGNKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0")]
	private static bool HLOGJMKAPHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7924E30", Offset = "0x7924230", VA = "0x187924E30")]
	public void DLBCFJLNCHA(object EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x79252A0", Offset = "0x79246A0", VA = "0x1879252A0")]
	public void NJOFMBFIEBO(object EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7925150", Offset = "0x7924550", VA = "0x187925150")]
	public void LMAJAPFLJFK(object EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCC9210", Offset = "0xCC8610", VA = "0x180CC9210")]
	public void BFPPKKGCBDD(Exception GEEGJFAONEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79251C0", Offset = "0x79245C0", VA = "0x1879251C0")]
	public void LMAJAPFLJFK(EAFPOODKGDJ EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34412D0", Offset = "0x34406D0", VA = "0x1834412D0")]
	public void LMAJAPFLJFK<T>(T PKKPPHDAMAG, LMHLKIJDCME<T> EIGJGBPHOMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3440EC0", Offset = "0x34402C0", VA = "0x183440EC0")]
	public void DLBCFJLNCHA<T>([In] T PKKPPHDAMAG, LJCLLIAOBIB<T> EIGJGBPHOMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3441060", Offset = "0x3440460", VA = "0x183441060")]
	public void LMAJAPFLJFK<T>([In] T PKKPPHDAMAG, LJCLLIAOBIB<T> EIGJGBPHOMK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7924EA0", Offset = "0x79242A0", VA = "0x187924EA0")]
	public bool FPPEDICBAND(bool IJHHPJHHECF, string EIGJGBPHOMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DABELDDEOKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string HNMCNCHEPGK;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	public DABELDDEOKF(string FIIKLGCIAGG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
	public static string MDKCMNAEKLA([In] DABELDDEOKF CAMFIHKHJNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2132EE0", Offset = "0x21322E0", VA = "0x182132EE0")]
	public static DABELDDEOKF MDKCMNAEKLA(string JAPIEEBOJEA)
	{
		return default(DABELDDEOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79242B0", Offset = "0x79236B0", VA = "0x1879242B0")]
	public string BKPHJCPLJEG(string HOBEPOHOAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7924300", Offset = "0x7923700", VA = "0x187924300")]
	public string OPGEKANMPBP(object PCJCAONBJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class PALPEKBAJGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
	public PALPEKBAJGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct DKANDHFOMPH : IEquatable<DKANDHFOMPH>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "4")]
	public bool Equals(DKANDHFOMPH JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79243E0", Offset = "0x79237E0", VA = "0x1879243E0", Slot = "0")]
	public override bool Equals(object JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7924430", Offset = "0x7923830", VA = "0x187924430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7924440", Offset = "0x7923840", VA = "0x187924440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FCLLJJAPAHC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DGLIKEIKEPL<T> : IEquatable<DGLIKEIKEPL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T HNMCNCHEPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool BHJCLHILMME;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool LNONPNAMAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x65C7B10", Offset = "0x65C6F10", VA = "0x1865C7B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65C9EA0", Offset = "0x65C92A0", VA = "0x1865C9EA0")]
	public DGLIKEIKEPL([In] T FIIKLGCIAGG, bool GOKHCHMFEEE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65C93D0", Offset = "0x65C87D0", VA = "0x1865C93D0")]
	public static bool IGEKHAEJGKN([In] DGLIKEIKEPL<T> AJLPPHLPDOI, [In] DGLIKEIKEPL<T> PODDNHBLFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65C7C30", Offset = "0x65C7030", VA = "0x1865C7C30", Slot = "4")]
	public bool Equals(DGLIKEIKEPL<T> JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x65C7EC0", Offset = "0x65C72C0", VA = "0x1865C7EC0", Slot = "0")]
	public override bool Equals(object? JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x65C8DD0", Offset = "0x65C81D0", VA = "0x1865C8DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x65C9900", Offset = "0x65C8D00", VA = "0x1865C9900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HMIMNLLGIIE
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x363CE00", Offset = "0x363C200", VA = "0x18363CE00")]
	public static DGLIKEIKEPL<T> PIPFKIHEFAN<T>([In] T FIIKLGCIAGG) where T : notnull
	{
		return default(DGLIKEIKEPL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x363CBB0", Offset = "0x363BFB0", VA = "0x18363CBB0")]
	public static DGLIKEIKEPL<T?> EHAPCDNHIML<T>()
	{
		return default(DGLIKEIKEPL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x363C8F0", Offset = "0x363BCF0", VA = "0x18363C8F0")]
	public static bool CAPINHLGKIB<T>([In] this DGLIKEIKEPL<T> KILKKIDHOHF, [Out][NotNullWhen(true)] T FIIKLGCIAGG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x363C8B0", Offset = "0x363BCB0", VA = "0x18363C8B0")]
	public static bool CAPINHLGKIB<T>([In] this DGLIKEIKEPL<T> KILKKIDHOHF, [Out][NotNullWhen(true)] T FIIKLGCIAGG, [Out] DGLIKEIKEPL<T> ILMJIEHNICP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x363CC70", Offset = "0x363C070", VA = "0x18363CC70")]
	public static T? MAKCNGOMHJP<T>([In] this DGLIKEIKEPL<T> KILKKIDHOHF, T? MBADHELIPJM)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x363C920", Offset = "0x363BD20", VA = "0x18363C920")]
	public static bool DIKMPHGCHFM<T>([In] this DGLIKEIKEPL<T> KILKKIDHOHF, T FIIKLGCIAGG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MIPCDCFMLNI
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x36FD750", Offset = "0x36FCB50", VA = "0x1836FD750")]
	public static T EJOJNFMAFAG<T>([In] this DGLIKEIKEPL<T> KILKKIDHOHF) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct FHMIMFDBLGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr KIICCLDKOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr GMKPHPDCPGN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr GBDDEDAELID;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr GCNLHGPKBBC;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly FHMIMFDBLGE OGOLFLHIENG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool JKHINNGGCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7926940", Offset = "0x7925D40", VA = "0x187926940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	public FHMIMFDBLGE(IntPtr KBNBBKGEBCB, IntPtr FFGEHMOCOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void OFBIGDBGHIL(string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void IBOJACIBJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7926A10", Offset = "0x7925E10", VA = "0x187926A10")]
	private static FHMIMFDBLGE PMNEADMJNLA()
	{
		return default(FHMIMFDBLGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct GKFHPAPJPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr KFCIFJJEDKP;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xE35E50", Offset = "0xE35250", VA = "0x180E35E50")]
	private GKFHPAPJPAM(IntPtr FFGEHMOCOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7927910", Offset = "0x7926D10", VA = "0x187927910")]
	public void JNOHBLLEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7927830", Offset = "0x7926C30", VA = "0x187927830")]
	public static GKFHPAPJPAM AFLKMMODJAC(string MPGDCPPMNJN)
	{
		return default(GKFHPAPJPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2649D10", Offset = "0x2649110", VA = "0x182649D10")]
	public static GKFHPAPJPAM AFLKMMODJAC([In] FHMIMFDBLGE BEPEIHDAKAD, string MPGDCPPMNJN)
	{
		return default(GKFHPAPJPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x264A060", Offset = "0x2649460", VA = "0x18264A060")]
	public static GKFHPAPJPAM AFLKMMODJAC([In] FHMIMFDBLGE BEPEIHDAKAD, Func<string> MPGDCPPMNJN)
	{
		return default(GKFHPAPJPAM);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PAOAEOPIINC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool OIMJOEBFCII<in TInput, TResult>(TInput BEAPIEHNNIB, [Out] TResult KGODHHBLJOE);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JGGCCBNONDF : PMBAOJAOIHB
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class EKOMAJODKPE : ONFPPECLDBF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly EKOMAJODKPE DMADMDPHOOL;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool OKPEPBABHOB
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x7925A00", Offset = "0x7924E00", VA = "0x187925A00", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7925A60", Offset = "0x7924E60", VA = "0x187925A60", Slot = "6")]
			public void OnCompleted(Action LAKFHCOEMCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			public void AFBAOFBCOBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public EKOMAJODKPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly JGGCCBNONDF DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		private JGGCCBNONDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7929290", Offset = "0x7928690", VA = "0x187929290", Slot = "4")]
		public ONFPPECLDBF JAGFCPCIBCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class NIPLJDGFLEE : PMBAOJAOIHB
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class PGKBLOOEIDI : ONFPPECLDBF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly PGKBLOOEIDI DMADMDPHOOL;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool OKPEPBABHOB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x792D950", Offset = "0x792CD50", VA = "0x18792D950", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x792D970", Offset = "0x792CD70", VA = "0x18792D970", Slot = "6")]
			public void OnCompleted(Action LAKFHCOEMCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			public void AFBAOFBCOBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PGKBLOOEIDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly NIPLJDGFLEE DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		private NIPLJDGFLEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x792A740", Offset = "0x7929B40", VA = "0x18792A740", Slot = "4")]
		public ONFPPECLDBF JAGFCPCIBCF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ICLOPBHNPNB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public ICLOPBHNPNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x46BEBD0", Offset = "0x46BDFD0", VA = "0x1846BEBD0")]
		internal void JDOOLMBOMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PIAOGEGACDF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PIAOGEGACDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x51EC200", Offset = "0x51EB600", VA = "0x1851EC200")]
		internal void PFHILNHPCBF(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct CGMHGKEECIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7923900", Offset = "0x7922D00", VA = "0x187923900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NPIAIDFMPPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x792B590", Offset = "0x792A990", VA = "0x18792B590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BMKFNOFBKGO<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D70080", Offset = "0x5D6F480", VA = "0x185D70080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D701F0", Offset = "0x5D6F5F0", VA = "0x185D701F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct NCKLHHLGNPG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4FE9E10", Offset = "0x4FE9210", VA = "0x184FE9E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA240", Offset = "0x4FE9640", VA = "0x184FEA240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FCLCIGEPEIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x79266C0", Offset = "0x7925AC0", VA = "0x1879266C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x79268D0", Offset = "0x7925CD0", VA = "0x1879268D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FBNLPMOMELN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FBNLPMOMELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x46BEBD0", Offset = "0x46BDFD0", VA = "0x1846BEBD0")]
		internal void EFJEOCHAMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x46BEC30", Offset = "0x46BE030", VA = "0x1846BEC30")]
		internal void ENJIOHEEMOP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GEMOFEGNMHN<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OIMJOEBFCII<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x48199E0", Offset = "0x4818DE0", VA = "0x1848199E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x481A0F0", Offset = "0x48194F0", VA = "0x18481A0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct CPOEKGDOOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7923A60", Offset = "0x7922E60", VA = "0x187923A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7924250", Offset = "0x7923650", VA = "0x187924250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MGBHKDCBNDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7929D70", Offset = "0x7929170", VA = "0x187929D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x792A2B0", Offset = "0x79296B0", VA = "0x18792A2B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NFELIKNFNNE<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5018240", Offset = "0x5017640", VA = "0x185018240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4824440", Offset = "0x4823840", VA = "0x184824440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class CEHEKDHPHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<DKANDHFOMPH> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CEHEKDHPHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7923650", Offset = "0x7922A50", VA = "0x187923650")]
		internal void JGDHDJPJIJB(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IDABCCFKLMF<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x49AFD80", Offset = "0x49AF180", VA = "0x1849AFD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3E603B0", Offset = "0x3E5F7B0", VA = "0x183E603B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct FFJIKHMBOJP<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x46CD440", Offset = "0x46CC840", VA = "0x1846CD440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x46CDC80", Offset = "0x46CD080", VA = "0x1846CDC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct KIHMGJMNPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7929A10", Offset = "0x7928E10", VA = "0x187929A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7929BF0", Offset = "0x7928FF0", VA = "0x187929BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ENMNFHIMEJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7925C20", Offset = "0x7925020", VA = "0x187925C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7925F80", Offset = "0x7925380", VA = "0x187925F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DOGDBBBGNNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7924570", Offset = "0x7923970", VA = "0x187924570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7924860", Offset = "0x7923C60", VA = "0x187924860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JJACCICHFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JJACCICHFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7929350", Offset = "0x7928750", VA = "0x187929350")]
		internal Task NNPCEFEKPDE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JOIBIHGPCCF : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7929750", Offset = "0x7928B50", VA = "0x187929750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x79299B0", Offset = "0x7928DB0", VA = "0x1879299B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct IACKAJAFAEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x79280C0", Offset = "0x79274C0", VA = "0x1879280C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x79282A0", Offset = "0x79276A0", VA = "0x1879282A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AOOMFGJGEDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7921EC0", Offset = "0x79212C0", VA = "0x187921EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7922220", Offset = "0x7921620", VA = "0x187922220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NMDKADFBHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x792B240", Offset = "0x792A640", VA = "0x18792B240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x792B530", Offset = "0x792A930", VA = "0x18792B530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class IDCIKKHPHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IDCIKKHPHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7928300", Offset = "0x7927700", VA = "0x187928300")]
		internal Task HLGCADCBKCF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct DOOMCKCNBHB : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x79248C0", Offset = "0x7923CC0", VA = "0x1879248C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7924B20", Offset = "0x7923F20", VA = "0x187924B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct EABBGOLFMEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7924B80", Offset = "0x7923F80", VA = "0x187924B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7924D00", Offset = "0x7924100", VA = "0x187924D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NHKGDGEOMIH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5027A90", Offset = "0x5026E90", VA = "0x185027A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5027CF0", Offset = "0x50270F0", VA = "0x185027CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct JNHCCLCHBDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x79293C0", Offset = "0x79287C0", VA = "0x1879293C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x79296F0", Offset = "0x7928AF0", VA = "0x1879296F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? HIGLCNOFONA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<DKANDHFOMPH> AOODMAEMEKN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task EJJIHEGFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x792CC80", Offset = "0x792C080", VA = "0x18792CC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x792BB50", Offset = "0x792AF50", VA = "0x18792BB50")]
	public static bool CPJMMPKDAOP(this Task ALKPEINKLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x37DE1B0", Offset = "0x37DD5B0", VA = "0x1837DE1B0")]
	public static Task<T> MFGNIGLDAPP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x792C6D0", Offset = "0x792BAD0", VA = "0x18792C6D0")]
	public static Task JKBPDKPGFCD(this Task ALKPEINKLAJ, CancellationToken HEJFDMJNIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x37DC7C0", Offset = "0x37DBBC0", VA = "0x1837DC7C0")]
	public static Task<TResult> JKBPDKPGFCD<TResult>(this Task<TResult> ALKPEINKLAJ, CancellationToken HEJFDMJNIGB) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x37DD730", Offset = "0x37DCB30", VA = "0x1837DD730")]
	public static TaskCompletionSource<TResult> JKBPDKPGFCD<TResult>(this TaskCompletionSource<TResult> BAIELHIPCKN, CancellationToken HEJFDMJNIGB) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x792D170", Offset = "0x792C570", VA = "0x18792D170")]
	public static IDisposable? OLFNMOLKFHH(CancellationToken CKOCLAKEMLJ, CancellationToken FGFCJIOAGHG, [Out] CancellationToken OKEFLBLKEEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x792C1B0", Offset = "0x792B5B0", VA = "0x18792C1B0")]
	[AsyncStateMachine(typeof(CGMHGKEECIA))]
	public static void JANGNJPPMFM(this Task CFOOONLCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x792CD40", Offset = "0x792C140", VA = "0x18792CD40")]
	[AsyncStateMachine(typeof(NPIAIDFMPPH))]
	public static void NACOPCAAIAP(this Task CFOOONLCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x37D9700", Offset = "0x37D8B00", VA = "0x1837D9700")]
	[AsyncStateMachine(typeof(BMKFNOFBKGO<>))]
	public static Task GGGMDFFMBOM<TException>(this Task CFOOONLCHLJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x37DE440", Offset = "0x37DD840", VA = "0x1837DE440")]
	[AsyncStateMachine(typeof(NCKLHHLGNPG<>))]
	public static Task<T> PEFNBHKHIHB<T>(this Task<T> CAMFIHKHJNG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x792CF00", Offset = "0x792C300", VA = "0x18792CF00")]
	[AsyncStateMachine(typeof(FCLCIGEPEIB))]
	public static Task<TaskStatus> NNDLLOMBDIM(this Task? CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x37D97D0", Offset = "0x37D8BD0", VA = "0x1837D97D0")]
	public static (Task<T?>?, Action<T?>?) GKBJGANOGEJ<T>([Optional] CancellationToken BLABAMPAGAH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x37DE330", Offset = "0x37DD730", VA = "0x1837DE330")]
	[AsyncStateMachine(typeof(GEMOFEGNMHN<, >))]
	public static Task<List<TResult>> MIOANIIALFI<TResult, TInput>(this Task<List<TInput>> ALKPEINKLAJ, OIMJOEBFCII<TInput, TResult> HMMHLPKMGLI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x792BD00", Offset = "0x792B100", VA = "0x18792BD00")]
	[AsyncStateMachine(typeof(CPOEKGDOOOH))]
	public static Task FMLEIDGGIIP(Task CFOOONLCHLJ, CancellationToken LDLCOIFGBGG, Func<CancellationToken, Task> JKDJBLKEGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x792BE30", Offset = "0x792B230", VA = "0x18792BE30")]
	[AsyncStateMachine(typeof(MGBHKDCBNDN))]
	public static Task HCJLGPMPOIM(Func<CancellationToken, Task> JENKLPHLLJG, TimeSpan DHENFBPIIKD, [Optional] CancellationToken LDLCOIFGBGG, [Optional] Action<OperationCanceledException>? APOAICGNAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37D9A50", Offset = "0x37D8E50", VA = "0x1837D9A50")]
	[AsyncStateMachine(typeof(NFELIKNFNNE<>))]
	public static Task<T> HCJLGPMPOIM<T>(Func<CancellationToken, Task<T>> JENKLPHLLJG, TimeSpan DHENFBPIIKD, [Optional] CancellationToken LDLCOIFGBGG, [Optional] Func<OperationCanceledException, T>? APOAICGNAEE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x792D380", Offset = "0x792C780", VA = "0x18792D380")]
	public static Task PGBJFCBDJAI(params Task[] DBNAGBLBPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x792D3D0", Offset = "0x792C7D0", VA = "0x18792D3D0")]
	public static Task PGBJFCBDJAI(IEnumerable<Task> DBNAGBLBPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37D9DE0", Offset = "0x37D91E0", VA = "0x1837D9DE0")]
	[AsyncStateMachine(typeof(IDABCCFKLMF<>))]
	public static Task<IEnumerable<Task<T>>> IDCLGEMIBJB<T>(IEnumerable<Task<T>> DBNAGBLBPFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37DE620", Offset = "0x37DDA20", VA = "0x1837DE620")]
	[AsyncStateMachine(typeof(FFJIKHMBOJP<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> PIIOCBCDPHD<T1, T2, T3, T4, T5>(Task<T1> FBCNPFANKHG, Task<T2> HENKHOJAPNA, Task<T3> EGIFFIBACME, Task<T4> NCKBHMBGKCM, Task<T5> CADGBHKPGIC) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x792BFB0", Offset = "0x792B3B0", VA = "0x18792BFB0")]
	[AsyncStateMachine(typeof(KIHMGJMNPPN))]
	public static Task IHHPPPEKCHE(Func<bool> IJHHPJHHECF, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x792C0A0", Offset = "0x792B4A0", VA = "0x18792C0A0")]
	[AsyncStateMachine(typeof(ENMNFHIMEJO))]
	public static Task IHHPPPEKCHE(Func<bool> IJHHPJHHECF, TimeSpan MENPDKLGAHL, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x792C3A0", Offset = "0x792B7A0", VA = "0x18792C3A0")]
	[AsyncStateMachine(typeof(DOGDBBBGNNB))]
	public static Task JDNJHMIHNLE(Func<bool> IJHHPJHHECF, TimeSpan DHENFBPIIKD, [Optional] CancellationToken BLABAMPAGAH, [Optional] Action<OperationCanceledException>? APOAICGNAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x792C260", Offset = "0x792B660", VA = "0x18792C260")]
	[AsyncStateMachine(typeof(JOIBIHGPCCF))]
	public static Task JDNJHMIHNLE(Func<bool> IJHHPJHHECF, TimeSpan DHENFBPIIKD, TimeSpan MENPDKLGAHL, [Optional] CancellationToken BLABAMPAGAH, [Optional] Action<OperationCanceledException>? APOAICGNAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x792C4D0", Offset = "0x792B8D0", VA = "0x18792C4D0")]
	[AsyncStateMachine(typeof(IACKAJAFAEP))]
	public static Task JHNIKLFEMBP(Func<bool> IJHHPJHHECF, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x792C5C0", Offset = "0x792B9C0", VA = "0x18792C5C0")]
	[AsyncStateMachine(typeof(AOOMFGJGEDI))]
	public static Task JHNIKLFEMBP(Func<bool> IJHHPJHHECF, TimeSpan MENPDKLGAHL, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x792CA60", Offset = "0x792BE60", VA = "0x18792CA60")]
	[AsyncStateMachine(typeof(NMDKADFBHEB))]
	public static Task JNMNCDLLFEB(Func<bool> IJHHPJHHECF, TimeSpan DHENFBPIIKD, [Optional] CancellationToken BLABAMPAGAH, [Optional] Action<OperationCanceledException>? APOAICGNAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x792C920", Offset = "0x792BD20", VA = "0x18792C920")]
	[AsyncStateMachine(typeof(DOOMCKCNBHB))]
	public static Task JNMNCDLLFEB(Func<bool> IJHHPJHHECF, TimeSpan DHENFBPIIKD, TimeSpan MENPDKLGAHL, [Optional] CancellationToken BLABAMPAGAH, [Optional] Action<OperationCanceledException>? APOAICGNAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x792CB90", Offset = "0x792BF90", VA = "0x18792CB90")]
	[AsyncStateMachine(typeof(EABBGOLFMEE))]
	[Obsolete]
	public static Task KCGOFFEMIIO(this Task ALKPEINKLAJ, Action LJODCJAJFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x37DE0C0", Offset = "0x37DD4C0", VA = "0x1837DE0C0")]
	[AsyncStateMachine(typeof(NHKGDGEOMIH<>))]
	[Obsolete]
	public static Task KCGOFFEMIIO<T>(this Task<T> ALKPEINKLAJ, Action<T> LJODCJAJFCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x792D0C0", Offset = "0x792C4C0", VA = "0x18792D0C0")]
	private static void OFLHCNHKICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x792B720", Offset = "0x792AB20", VA = "0x18792B720")]
	public static bool AIINJFEEKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x792BB80", Offset = "0x792AF80", VA = "0x18792BB80")]
	private static void EOOACGCAMEH(SynchronizationContext FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x792CDF0", Offset = "0x792C1F0", VA = "0x18792CDF0")]
	private static void NEECBEOCJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x792CFF0", Offset = "0x792C3F0", VA = "0x18792CFF0")]
	public static void OCHBMNBLPMG([Optional] string? EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x792D300", Offset = "0x792C700", VA = "0x18792D300")]
	public static void OOBIGMJLNKH([Optional] string? EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x792CCF0", Offset = "0x792C0F0", VA = "0x18792CCF0")]
	public static PMBAOJAOIHB LHEBFBHAPCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x792BF60", Offset = "0x792B360", VA = "0x18792BF60")]
	public static PMBAOJAOIHB IBIPPIABOBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x792BA80", Offset = "0x792AE80", VA = "0x18792BA80")]
	[AsyncStateMachine(typeof(JNHCCLCHBDE))]
	public static Task BIOBOIFLNDH(Func<Task> HGCIPPLBBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NGHELBGCMPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
	public NGHELBGCMPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MNNLCNFBDIK : DLAOPFBBEBB
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly DLAOPFBBEBB DMADMDPHOOL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime JCPACPJACFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x792A690", Offset = "0x7929A90", VA = "0x18792A690", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset BPJJOHHEOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x792A630", Offset = "0x7929A30", VA = "0x18792A630", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MNNLCNFBDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface DLAOPFBBEBB
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime JCPACPJACFI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset BPJJOHHEOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class GFAFDAOEGBE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long HOFLECJDOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7926C60", Offset = "0x7926060", VA = "0x187926C60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long BFAIGAAGCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7926EA0", Offset = "0x79262A0", VA = "0x187926EA0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double HAHJDPLHBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x79270C0", Offset = "0x79264C0", VA = "0x1879270C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double JLNNGHOPOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7926F80", Offset = "0x7926380", VA = "0x187926F80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double LDDALNPFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7927110", Offset = "0x7926510", VA = "0x187927110")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double LLEHMGALCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7926C10", Offset = "0x7926010", VA = "0x187926C10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7926D40", Offset = "0x7926140", VA = "0x187926D40")]
	public static double FHAKINHLIOL(long COMEAAGCLKK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7926CB0", Offset = "0x79260B0", VA = "0x187926CB0")]
	public static double EPLFAEGJPGE(long COMEAAGCLKK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7927030", Offset = "0x7926430", VA = "0x187927030")]
	public static double MNJLPLNGBAF(double BCCGEEOAEBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7926EF0", Offset = "0x79262F0", VA = "0x187926EF0")]
	public static long KIJKKLGHNAJ(long LLAIDEDFOJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7927160", Offset = "0x7926560", VA = "0x187927160")]
	public static long PPNKAHNBMIF(long JGKEAJIPKCP, long LPOMOPLFGJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7926DD0", Offset = "0x79261D0", VA = "0x187926DD0")]
	public static double JDHPCGIGFFB(long JGKEAJIPKCP, long LPOMOPLFGJK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7926FD0", Offset = "0x79263D0", VA = "0x187926FD0")]
	public static double MFLODEOIJEH(long JGKEAJIPKCP, long LPOMOPLFGJK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class EONBPDCNADA : OFEANNAAJIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan ILFEOBDDLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer AOBIHHLEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan DHENFBPIIKD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan NIJJBJDJEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7926110", Offset = "0x7925510", VA = "0x187926110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? AJAGPAMLNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7926660", Offset = "0x7925A60", VA = "0x187926660")]
	[Preserve]
	public EONBPDCNADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7926410", Offset = "0x7925810", VA = "0x187926410")]
	public EONBPDCNADA(TimeSpan DHENFBPIIKD, [Optional] Action? HFNEBLEGAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7926310", Offset = "0x7925710", VA = "0x187926310", Slot = "7")]
	public void OJDEIJAKKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79262A0", Offset = "0x79256A0", VA = "0x1879262A0", Slot = "8")]
	public void JAFGPJHKJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7926270", Offset = "0x7925670", VA = "0x187926270", Slot = "9")]
	public void IMMAKLHENCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1031890", Offset = "0x1030C90", VA = "0x181031890")]
	private void PDDEKPPLBAD(object OICAMEEFOOB, ElapsedEventArgs CBLLBJNHOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7926080", Offset = "0x7925480", VA = "0x187926080")]
	private static void ELPBNENFHBB(TimeSpan MNMCGMMAHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7925FE0", Offset = "0x79253E0", VA = "0x187925FE0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FCLLJJAPAHC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? FEDICNOJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string FILMNPKDNPJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x72ABB40", Offset = "0x72AAF40", VA = "0x1872ABB40")]
	public FCLLJJAPAHC(string DPHOGONECCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4B003E0", Offset = "0x4AFF7E0", VA = "0x184B003E0")]
	public FCLLJJAPAHC(string JLMMOICKAGI, string DPHOGONECCJ)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct IOFJIGKIBJE : IEquatable<IOFJIGKIBJE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint KMHIPPKCKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int ADFBPCELHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float LGBNECBBOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort EPGLGFCINEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort IMNHCKFKBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short CDONBBPLLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short EOMPJOHFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char FFCDBOPCMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char AIAMNAGHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte PNJDEMNOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte FIEIBICCEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte IKHNEICPLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte CJOCHBIBFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool IAPKEGGIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool GDPKPEPLMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool PFGHCPJCMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool BDDMBGBGODO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
	public static IOFJIGKIBJE ELNFDBBOHKN(uint JBHKBEONKAD)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1D17060", Offset = "0x1D16460", VA = "0x181D17060")]
	public static IOFJIGKIBJE LAGGKDFKPEO(int GBKMDMBKNCI)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7928420", Offset = "0x7927820", VA = "0x187928420")]
	public static IOFJIGKIBJE OGFJEEKFAAL(float AMIBMPKHKND)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7928400", Offset = "0x7927800", VA = "0x187928400")]
	public static IOFJIGKIBJE GFJOGAFKBEG(byte DLPNDBNAPGM, byte DOLGIKCDKGK, byte EGILBHAABGP, byte NEPNCNNMNLA)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7928400", Offset = "0x7927800", VA = "0x187928400")]
	public static IOFJIGKIBJE GOLECOJDOHG(bool BKPDBINIDEJ, bool FMKAALBEENG, bool DFPFNCCHCAI, bool IOKKBFHFLCE)
	{
		return default(IOFJIGKIBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7928400", Offset = "0x7927800", VA = "0x187928400")]
	public static IOFJIGKIBJE PJJOLMCEEKA(byte DNIEDIIMAIN, byte PINBMFKHGLK, byte EKDAGIHAJDL, byte IPHDMMMPAFD)
	{
		return default(IOFJIGKIBJE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4260", Offset = "0x1FF3660", VA = "0x181FF4260")]
	public static bool IGEKHAEJGKN(IOFJIGKIBJE ONMPMLDKLEL, IOFJIGKIBJE CEMDANFAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF3640", VA = "0x181FF4240", Slot = "4")]
	public bool Equals(IOFJIGKIBJE JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7928370", Offset = "0x7927770", VA = "0x187928370", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x11C1CE0", Offset = "0x11C10E0", VA = "0x1811C1CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7928430", Offset = "0x7927830", VA = "0x187928430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct GJGPLEKCNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong BKPKIPMOMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long OGEGPNMLHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double LDLOFPFIOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint FJGKKBAGFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint FHJADKEJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int ECMMGGCFJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int GJDNHJKHFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float IAMDFDEEPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float JHCBEBHBLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort EPGLGFCINEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort IMNHCKFKBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort BKOAPKBECEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort OOEKCALIOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short CDONBBPLLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short EOMPJOHFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short CHDLOLCMLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short EIEKKNLAAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char FFCDBOPCMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char AIAMNAGHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char EOMLIHHJKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char FBDCGMICCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte PNJDEMNOCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte FIEIBICCEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte IKHNEICPLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte CJOCHBIBFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte DCLHHBEPEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte POEGEJFHPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte AHKBGCEEEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte DFBMIILBPJL;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static GJGPLEKCNCF AFLKMMODJAC(long KHNHDJJOAID)
	{
		return default(GJGPLEKCNCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79277E0", Offset = "0x7926BE0", VA = "0x1879277E0")]
	public static GJGPLEKCNCF AFLKMMODJAC(byte DLPNDBNAPGM, byte DOLGIKCDKGK, byte EGILBHAABGP, byte NEPNCNNMNLA, byte BELIOANOAON, byte JPLOLGGMELE, byte EOKGHGDMOEL, byte PMNBDJKKCJE)
	{
		return default(GJGPLEKCNCF);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MJCJLNHNMOA : IEquatable<MJCJLNHNMOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte ELOHBABNKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool OOKNNCHCNKO;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB810", Offset = "0x2CAAC10", VA = "0x182CAB810")]
	public static MJCJLNHNMOA GFJOGAFKBEG(byte BMEMNECENHL)
	{
		return default(MJCJLNHNMOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2CAB810", Offset = "0x2CAAC10", VA = "0x182CAB810")]
	public static MJCJLNHNMOA GOLECOJDOHG(bool DJKBLCPLIPJ)
	{
		return default(MJCJLNHNMOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x792A3B0", Offset = "0x79297B0", VA = "0x18792A3B0")]
	public static bool IGEKHAEJGKN(MJCJLNHNMOA ONMPMLDKLEL, MJCJLNHNMOA CEMDANFAAHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6921700", Offset = "0x6920B00", VA = "0x186921700", Slot = "4")]
	public bool Equals(MJCJLNHNMOA JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x792A310", Offset = "0x7929710", VA = "0x18792A310", Slot = "0")]
	public override bool Equals(object HAPOBHMBDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x792A3A0", Offset = "0x79297A0", VA = "0x18792A3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x792A3C0", Offset = "0x79297C0", VA = "0x18792A3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CGABCCBNJND<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T ECBFJFILKLM;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x61382C0", Offset = "0x61376C0", VA = "0x1861382C0")]
	public CGABCCBNJND(T KBDENLCIJDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class LMBGHKPHHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36D9750", Offset = "0x36D8B50", VA = "0x1836D9750")]
	public static IEnumerable<T> OBLIBDFAHCB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static T[] CMBKNLGFBPD<T>(params T[] LCNGOBPAGLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static IEnumerable<T> IDDGGLFMHNC<T>(params T[] LCNGOBPAGLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static HashSet<T> NMEKMKJLFLB<T>(params T[] LCNGOBPAGLF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x36D9660", Offset = "0x36D8A60", VA = "0x1836D9660")]
	public static KeyValuePair<TKey, TValue> GNBEINGPFKC<TKey, TValue>([In] TKey MCBJECJLDOM, [In] TValue FIIKLGCIAGG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x363C7F0", Offset = "0x363BBF0", VA = "0x18363C7F0")]
	public static List<T> BFDCEKOMCPE<T>(IEnumerable<T> OLEAEELGLFO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class BHADCGLBNFD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string PGCMMMMCCOD;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
	public BHADCGLBNFD(string JAPINDHIFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object LJCLLIAOBIB<T>([In] T JOIGLCNPHIH);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object LMHLKIJDCME<T>(T JOIGLCNPHIH);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[GILOPCIJCPA]
public delegate string DLJIMKFLICL(string DBFOBELGJDB, string? KDFAHKIFEME, bool DDAAHMMOMJJ);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GILOPCIJCPA]
public delegate void ANJKIGNIMOG(string EIGJGBPHOMK);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[GILOPCIJCPA]
public delegate void BPNJBDIMHAE(Exception GEEGJFAONEJ);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object EAFPOODKGDJ();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GILOPCIJCPA]
public delegate bool LKNFKOCDAPC();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GILOPCIJCPA]
public delegate string IDBNENMJBGN(object HAPOBHMBDHP);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class JDLGGBENHGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
	public JDLGGBENHGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class PLBNHBHAMKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct BNNFFDKOHII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7922BC0", Offset = "0x7921FC0", VA = "0x187922BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x79234B0", Offset = "0x79228B0", VA = "0x1879234B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback GAKHIAJBCCE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> PMILCIMGDAO;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x792DC80", Offset = "0x792D080", VA = "0x18792DC80")]
	public static Task<bool> NHNNFJJDCCA(int NALEAHIGIBB, [Optional] CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x792DB50", Offset = "0x792CF50", VA = "0x18792DB50")]
	[AsyncStateMachine(typeof(BNNFFDKOHII))]
	private static Task<bool> DBGNAOIMBHK(int NALEAHIGIBB, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x792DAC0", Offset = "0x792CEC0", VA = "0x18792DAC0")]
	private static void BADONKALLJG(object? FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x792DA30", Offset = "0x792CE30", VA = "0x18792DA30")]
	private static void AEDIKIEIBNM(object? FBOKGPFKJCL)
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
