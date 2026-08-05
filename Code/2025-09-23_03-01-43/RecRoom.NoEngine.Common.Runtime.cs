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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8668F80", Offset = "0x8667580", VA = "0x188668F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OMKNMBJAKDA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86696C0", Offset = "0x8667CC0", VA = "0x1886696C0")]
	public static string NDDCEMAKOME(this Encoding GLEOFOFLNJH, [In] ReadOnlySequence<byte> EIJIDGHNNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F84EA0", Offset = "0x3F834A0", VA = "0x183F84EA0")]
	private static void KOJEMGJJDCF<T>(this ReadOnlySequence<T> LAEKKNGHGBK, [Out] ReadOnlySpan<T> DAIFCDGAKIN, [Out] SequencePosition OIAKIODILPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class BBIIADKEMHA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x865D660", Offset = "0x865BC60", VA = "0x18865D660")]
	public BBIIADKEMHA(bool HHGHFICJGJH, string ONEKDAGILMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x865D730", Offset = "0x865BD30", VA = "0x18865D730")]
	public BBIIADKEMHA(bool HHGHFICJGJH, params string[] EKEICDOCGNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PCHIMBFNODE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AKJKPFNHPPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JGDEKALAIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHJBBOJEPIC(string HAELBKGFDIJ, double KOPHBHGIACG, [Optional] string? FKFCGNAGKEI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CGOBCGNDMDA : JFKKKLJEEIA, JCPHEDLHMBG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CLKLAEELPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MCFBCBLDMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double KECGAHAPFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double GAEHKCHAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double BOHMHGILLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OGMPJOEJPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double NBPEHOMOKLH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JDACAKOEFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAC5000", Offset = "0xAC3600", VA = "0x180AC5000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GGOKNBDBECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x865F550", Offset = "0x865DB50", VA = "0x18865F550", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LHFEPCDLIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A90810", Offset = "0x2A8EE10", VA = "0x182A90810", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double INHFPLJAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2AC2EA0", Offset = "0x2AC14A0", VA = "0x182AC2EA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x865F5B0", Offset = "0x865DBB0", VA = "0x18865F5B0")]
	public CGOBCGNDMDA(int GDNAAPGIKMD, double NBPEHOMOKLH = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x865F420", Offset = "0x865DA20", VA = "0x18865F420", Slot = "7")]
	public void LIPDHCDAFCH(double IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x865F3B0", Offset = "0x865D9B0", VA = "0x18865F3B0", Slot = "8")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x865F2B0", Offset = "0x865D8B0", VA = "0x18865F2B0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CEEKLAFCBGP : JFKKKLJEEIA, JCPHEDLHMBG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long LMJBLNOIBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double OKKFJGMOGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double LLLFNLFAGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double JNOJCAOPGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double BILEDJMCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double KECGAHAPFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double GAEHKCHAJDJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LHFEPCDLIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7805F60", Offset = "0x7804560", VA = "0x187805F60", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double INHFPLJAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7805F70", Offset = "0x7804570", VA = "0x187805F70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JKLKFOKPDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7805F50", Offset = "0x7804550", VA = "0x187805F50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GGOKNBDBECG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A90800", Offset = "0x2A8EE00", VA = "0x182A90800", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x865F160", Offset = "0x865D760", VA = "0x18865F160", Slot = "10")]
	public virtual void LIPDHCDAFCH(double IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x865F120", Offset = "0x865D720", VA = "0x18865F120", Slot = "11")]
	public virtual void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x865F0B0", Offset = "0x865D6B0", VA = "0x18865F0B0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x865F280", Offset = "0x865D880", VA = "0x18865F280")]
	public CEEKLAFCBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CMEIELLIBAJ : CEEKLAFCBGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double BEHCDEONIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7805F30", Offset = "0x7804530", VA = "0x187805F30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7805FA0", Offset = "0x78045A0", VA = "0x187805FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x865F8D0", Offset = "0x865DED0", VA = "0x18865F8D0", Slot = "10")]
	public override void LIPDHCDAFCH(double IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x865F890", Offset = "0x865DE90", VA = "0x18865F890", Slot = "11")]
	public override void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x865F280", Offset = "0x865D880", VA = "0x18865F280")]
	public CMEIELLIBAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JFKKKLJEEIA : JCPHEDLHMBG, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GGOKNBDBECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LHFEPCDLIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double INHFPLJAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IGGKAKDGMMH : JCPHEDLHMBG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double ICEOIEGFCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double BHKHIFCLLCB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8664DC0", Offset = "0x86633C0", VA = "0x188664DC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7245E90", Offset = "0x7244490", VA = "0x187245E90", Slot = "4")]
	public void LIPDHCDAFCH(double IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8664DB0", Offset = "0x86633B0", VA = "0x188664DB0", Slot = "5")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8664D60", Offset = "0x8663360", VA = "0x188664D60", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IGGKAKDGMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JCPHEDLHMBG : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LIPDHCDAFCH(double IKJAADLGNCL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGIFDBJEMCA();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PGIJJFMDMNL : JCPHEDLHMBG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double KOPHBHGIACG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x124C110", Offset = "0x124A710", VA = "0x18124C110")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5A5EE00", Offset = "0x5A5D400", VA = "0x185A5EE00", Slot = "4")]
	public void LIPDHCDAFCH(double IKJAADLGNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8669CD0", Offset = "0x86682D0", VA = "0x188669CD0", Slot = "5")]
	public void JGIFDBJEMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8669C80", Offset = "0x8668280", VA = "0x188669C80", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PGIJJFMDMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FNBDDBHMCLF<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> OAPBIFHJMPE(CancellationToken PJCIHHKJKBP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OJPKNFAGOMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FNBDDBHMCLF<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OAPBIFHJMPE taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x5BB4EA0", Offset = "0x5BB34A0", VA = "0x185BB4EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5BB5EF0", Offset = "0x5BB44F0", VA = "0x185BB5EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource JOPLMKCEELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? LGAGLCLIOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? CBEPFHILICF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5026B50", Offset = "0x5025150", VA = "0x185026B50")]
	[AsyncStateMachine(typeof(FNBDDBHMCLF<>.OJPKNFAGOMO))]
	public Task<TResult> CENCJNCBNJK(OAPBIFHJMPE GFDHLMCCLKC, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5026C90", Offset = "0x5025290", VA = "0x185026C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5026D00", Offset = "0x5025300", VA = "0x185026D00")]
	public FNBDDBHMCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EOEEGKPLHJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> MFANGOBKANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T CECIKJNPCJO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4B6F110", Offset = "0x4B6D710", VA = "0x184B6F110")]
	public EOEEGKPLHJJ([In] T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B6DF40", Offset = "0x4B6C540", VA = "0x184B6DF40", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E7D0", Offset = "0x4B6CDD0", VA = "0x184B6E7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6EC40", Offset = "0x4B6D240", VA = "0x184B6EC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IJPOPCBDMNB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static EOEEGKPLHJJ<T> CPNHECDILPK<T>([In] T KOPHBHGIACG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DDPODNCAEKA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8660640", Offset = "0x865EC40", VA = "0x188660640")]
	public static void IGEBAMHHHDC(this CancellationTokenSource JOPLMKCEELD, bool NMBIBPIMGJJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FJLLCDEFFIL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public FJLLCDEFFIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FIBHNJGJFGF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public FIBHNJGJFGF(string CFOKNPIDFDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GCGMJIHCCPH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8140", Offset = "0x3DD6740", VA = "0x183DD8140")]
	public static JGGLMJCBDML CAPCBMIJBJE<T>()
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8664020", Offset = "0x8662620", VA = "0x188664020")]
	public static JGGLMJCBDML OLDEDMOGDFM([CallerMemberName] string NDIENANOGEK = "")
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8410", Offset = "0x3DD6A10", VA = "0x183DD8410")]
	public static JGGLMJCBDML LFCBBKOCDLC<T>([CallerMemberName] string NDIENANOGEK = "") where T : notnull
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DD81C0", Offset = "0x3DD67C0", VA = "0x183DD81C0")]
	public static JGGLMJCBDML CAPCBMIJBJE<T>(this T APAPCLFINDP) where T : notnull
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DD8370", Offset = "0x3DD6970", VA = "0x183DD8370")]
	public static JGGLMJCBDML LFCBBKOCDLC<T>(this T JNMMMBJNOND, [CallerMemberName] string NDIENANOGEK = "") where T : notnull
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8663FA0", Offset = "0x86625A0", VA = "0x188663FA0")]
	public static JGGLMJCBDML LFCBBKOCDLC(string MNPKMKJMDKJ, [CallerMemberName] string NDIENANOGEK = "")
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8664080", Offset = "0x8662680", VA = "0x188664080")]
	public static string PKGDPIDGBJB(this object JNMMMBJNOND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool BHOBNHKMEKG();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FJLLCDEFFIL]
public delegate long JHJEGLJBCLH();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IMNDBIAFPJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IMNDBIAFPJP EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IMNDBIAFPJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DAGMJJCDILE
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static IGMOPBIMHDP GGAEHAGCEKD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static IGMOPBIMHDP FJBCLOGKOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8660030", Offset = "0x865E630", VA = "0x188660030")]
		get
		{
			return default(IGMOPBIMHDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static LCOECJGAHHI IDCFDJDBIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x865FEB0", Offset = "0x865E4B0", VA = "0x18865FEB0")]
		get
		{
			return default(LCOECJGAHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static GFEHLKJIDDP IPMDDCDPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x865FE60", Offset = "0x865E460", VA = "0x18865FE60")]
		get
		{
			return default(GFEHLKJIDDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool PADJDJEGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8660080", Offset = "0x865E680", VA = "0x188660080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x865FB70", Offset = "0x865E170", VA = "0x18865FB70")]
	public static void GLOOKLGOEDB([In] IGMOPBIMHDP NFPLEFOFAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x865FAA0", Offset = "0x865E0A0", VA = "0x18865FAA0")]
	public static void EANLMHBELEK(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x865FD20", Offset = "0x865E320", VA = "0x18865FD20")]
	public static void HNPAIDKDOLO(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CD20", Offset = "0x3C1B320", VA = "0x183C1CD20")]
	public static void HNPAIDKDOLO<T>(T CGNPMBIJPEO, ENLPBBNEAID<T> GKNICJPCIJJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x865FA00", Offset = "0x865E000", VA = "0x18865FA00")]
	public static void BDEBBALIMJB(Exception BGIFIJLJEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x865FF00", Offset = "0x865E500", VA = "0x18865FF00")]
	public static void KPEAGBMOJFE(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x86600F0", Offset = "0x865E6F0", VA = "0x1886600F0")]
	public static void NFJIBIHILIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x86601F0", Offset = "0x865E7F0", VA = "0x1886601F0")]
	public static string PKGDPIDGBJB(object MPIDDJPOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x865FDF0", Offset = "0x865E3F0", VA = "0x18865FDF0")]
	public static long JBOCAACDHME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8660150", Offset = "0x865E750", VA = "0x188660150")]
	public static bool OKNJMCBJEFD(bool MAMPOCOOMDJ, string GKNICJPCIJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x865FF60", Offset = "0x865E560", VA = "0x18865FF60")]
	public static double KPGPKGHLCNI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct IGMOPBIMHDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly LCOECJGAHHI IDCFDJDBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly GFEHLKJIDDP IPMDDCDPNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly HIKJCCBBHGG LNLMCPIFALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly JHJEGLJBCLH BGNFEMHEDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly BGLLIHEOMHC OEJALDBNMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly BHOBNHKMEKG LGPJJACBFFD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HIKJCCBBHGG JIIGEKFLBFF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly JHJEGLJBCLH KMCJCMHAGAK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BGLLIHEOMHC FDNNBGBHBNN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly BHOBNHKMEKG LLOFOCPNLMF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IGMOPBIMHDP HPOBBIFAPGN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8664E10", Offset = "0x8663410", VA = "0x188664E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x86657B0", Offset = "0x8663DB0", VA = "0x1886657B0")]
	public IGMOPBIMHDP([In] LCOECJGAHHI NKNMIOLDMLE, [In] GFEHLKJIDDP MODBPHOKHEJ, HIKJCCBBHGG GCMDEAAKADC, JHJEGLJBCLH DFIEFOJKEKI, BGLLIHEOMHC CHJABPNMCEB, BHOBNHKMEKG DGNKADOGMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8664DD0", Offset = "0x86633D0", VA = "0x188664DD0")]
	private static string DCCEGCDMIIB(object MPIDDJPOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
	private static long KCLLLBPNKCE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	private static string PDLMLPFAMAF(string DPCMOBNBPGE, string? EIDEEAHADAH, bool DLEEJOPODOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	private static bool DFMDIDLBGMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8664FB0", Offset = "0x86635B0", VA = "0x188664FB0")]
	private static IGMOPBIMHDP HNPLIFDCICO()
	{
		return default(IGMOPBIMHDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BLAHGDCIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOAOINMFEPG FEOGLHAOOCG();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MOAOINMFEPG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool INFFINLHJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHIEPMNDMBD();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ACEBGMCDHMH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCJMFDPCMLP([In] T AAGCKLPFJME);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void ILMMEMPANOB<T>([In] T CGNPMBIJPEO);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct OAJLGEIIFFE<T> : IEquatable<OAJLGEIIFFE<T>>, ACEBGMCDHMH<OAJLGEIIFFE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T CECIKJNPCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int GKFLGCDAIDH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x311BDF0", Offset = "0x311A3F0", VA = "0x18311BDF0")]
	public OAJLGEIIFFE([In] T KOPHBHGIACG, int PMIGBJGNLLP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5B908A0", Offset = "0x5B8EEA0", VA = "0x185B908A0")]
	public static bool MGLHCKHANFO([In] OAJLGEIIFFE<T> NEOIFOEJGFD, [In] OAJLGEIIFFE<T> KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5160AB0", Offset = "0x515F0B0", VA = "0x185160AB0", Slot = "4")]
	public bool Equals(OAJLGEIIFFE<T> AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x50A9FB0", Offset = "0x50A85B0", VA = "0x1850A9FB0", Slot = "0")]
	public override bool Equals(object AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5B90CF0", Offset = "0x5B8F2F0", VA = "0x185B90CF0")]
	public bool PCJMFDPCMLP([In] OAJLGEIIFFE<T> AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5B8FBD0", Offset = "0x5B8E1D0", VA = "0x185B8FBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5B90F00", Offset = "0x5B8F500", VA = "0x185B90F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5B905D0", Offset = "0x5B8EBD0", VA = "0x185B905D0")]
	public void HEAGIBMIAPN([Out] T KOPHBHGIACG, [Out] int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F590", Offset = "0x5B8DB90", VA = "0x185B8F590")]
	public (T, int) BBCKNDEDPOC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5B8F420", Offset = "0x5B8DA20", VA = "0x185B8F420", Slot = "5")]
	private bool ABGKPKFAAPJ([In] OAJLGEIIFFE<T> AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NJMNEACDDED
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FCC0", Offset = "0x3F4E2C0", VA = "0x183F4FCC0")]
	public static OAJLGEIIFFE<T> CPNHECDILPK<T>([In] T KOPHBHGIACG, int PMIGBJGNLLP) where T : notnull
	{
		return default(OAJLGEIIFFE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FKHAIPNJFFB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3640", Offset = "0x3DC1C40", VA = "0x183DC3640")]
	public static bool PCJMFDPCMLP<T, U>([In] T JNMMMBJNOND, [In] U MPIDDJPOOMJ) where T : notnull, ACEBGMCDHMH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult AJLOMAEKFCH<T, out TResult>([In] T CGNPMBIJPEO);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AOIIIIJCKKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan OGCCPKPBHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? BMDLKHKLPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLMAAMEONBL();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAOBAABIKDO();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBDDDNAIIMI();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LCOECJGAHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly INIBNJKBLBC INKPGLBCGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly FMMKJKBBOFM PBLODJOKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly INIBNJKBLBC CNHPPOCEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FMMKJKBBOFM DKJEIPHBKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly INIBNJKBLBC NKAEEIMJCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FMMKJKBBOFM AAHCNALICFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly OODIABCOFBD LMDFICGDMDK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly INIBNJKBLBC HLKKGLEIIJN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly FMMKJKBBOFM NEIJOPJNNKM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly INIBNJKBLBC PDDBKEDJAPH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly FMMKJKBBOFM PPPIEHKJADI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly INIBNJKBLBC DAGOPJNIAFB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly FMMKJKBBOFM GAGDNBKFACL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly OODIABCOFBD HBGOPKHFGFM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly LCOECJGAHHI HPOBBIFAPGN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly INIBNJKBLBC CJGJAHDKHGG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86668F0", Offset = "0x8664EF0", VA = "0x1886668F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xF29E20", Offset = "0xF28420", VA = "0x180F29E20")]
	public LCOECJGAHHI(INIBNJKBLBC JIJCCJDONEJ, FMMKJKBBOFM KKMEHMGGAJD, INIBNJKBLBC KIFIFMLEEOF, FMMKJKBBOFM OBFHNBAIEBM, INIBNJKBLBC BJEECCOHDBE, FMMKJKBBOFM NHFGLJNFNNO, OODIABCOFBD PPONOAFIDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	private static bool HOALJGEBCLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void NBGLOMGNPBN(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	private static bool HBPABCIGPGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void JFEGDKEHOIP(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	private static bool IBPMNNLNMHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void FFBKHDLLAHI(string GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void PKICPCKCAGK(Exception BGIFIJLJEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8666C40", Offset = "0x8665240", VA = "0x188666C40")]
	private static LCOECJGAHHI HNPLIFDCICO()
	{
		return default(LCOECJGAHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
	private static bool MKCPIGHPBJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x8666880", Offset = "0x8664E80", VA = "0x188666880")]
	public void EANLMHBELEK(object GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8666810", Offset = "0x8664E10", VA = "0x188666810")]
	public void AKDEJGAIMOD(object GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8666AF0", Offset = "0x86650F0", VA = "0x188666AF0")]
	public void HNPAIDKDOLO(object GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xF23CF0", Offset = "0xF222F0", VA = "0x180F23CF0")]
	public void BDEBBALIMJB(Exception BGIFIJLJEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8666B60", Offset = "0x8665160", VA = "0x188666B60")]
	public void HNPAIDKDOLO(DFPNFEOMIOL GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4E50", Offset = "0x3EB3450", VA = "0x183EB4E50")]
	public void HNPAIDKDOLO<T>(T CGNPMBIJPEO, ENLPBBNEAID<T> GKNICJPCIJJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4CD0", Offset = "0x3EB32D0", VA = "0x183EB4CD0")]
	public void EANLMHBELEK<T>([In] T CGNPMBIJPEO, IEONEGAJFIL<T> GKNICJPCIJJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4F20", Offset = "0x3EB3520", VA = "0x183EB4F20")]
	public void HNPAIDKDOLO<T>([In] T CGNPMBIJPEO, IEONEGAJFIL<T> GKNICJPCIJJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8666D80", Offset = "0x8665380", VA = "0x188666D80")]
	public bool OKNJMCBJEFD(bool MAMPOCOOMDJ, string GKNICJPCIJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct JGGLMJCBDML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string CECIKJNPCJO;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
	public JGGLMJCBDML(string KOPHBHGIACG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
	public static string HNGLNPFKABH([In] JGGLMJCBDML JNMMMBJNOND)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x14B91A0", Offset = "0x14B77A0", VA = "0x1814B91A0")]
	public static JGGLMJCBDML HNGLNPFKABH(string AAGCKLPFJME)
	{
		return default(JGGLMJCBDML);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x86661B0", Offset = "0x86647B0", VA = "0x1886661B0")]
	public string GPMPBOBEHGA(string NPKCMCHDHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x86660D0", Offset = "0x86646D0", VA = "0x1886660D0")]
	public string EJGFGHEDIBC(object PAEDANEFMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class FDOEGCJLBJJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public FDOEGCJLBJJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct IHJGGHCFJKD : IEquatable<IHJGGHCFJKD>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
	public bool Equals(IHJGGHCFJKD AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8665860", Offset = "0x8663E60", VA = "0x188665860", Slot = "0")]
	public override bool Equals(object AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x86658B0", Offset = "0x8663EB0", VA = "0x1886658B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86658C0", Offset = "0x8663EC0", VA = "0x1886658C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DGKFKBGENGO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct GAKPFAEKJAN<T> : IEquatable<GAKPFAEKJAN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T CECIKJNPCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool MOBINIOMJCB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CKNJICKNDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xBA6D70", Offset = "0xBA5370", VA = "0x180BA6D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50AC120", Offset = "0x50AA720", VA = "0x1850AC120")]
	public GAKPFAEKJAN([In] T KOPHBHGIACG, bool OCIBJICFJEG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50AB4A0", Offset = "0x50A9AA0", VA = "0x1850AB4A0")]
	public static bool MGLHCKHANFO([In] GAKPFAEKJAN<T> NEOIFOEJGFD, [In] GAKPFAEKJAN<T> KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50AA030", Offset = "0x50A8630", VA = "0x1850AA030", Slot = "4")]
	public bool Equals(GAKPFAEKJAN<T> AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x50AA680", Offset = "0x50A8C80", VA = "0x1850AA680", Slot = "0")]
	public override bool Equals(object? AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x50AAEA0", Offset = "0x50A94A0", VA = "0x1850AAEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50ABAB0", Offset = "0x50AA0B0", VA = "0x1850ABAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FNEANDFGCFG
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5260", Offset = "0x3DC3860", VA = "0x183DC5260")]
	public static GAKPFAEKJAN<T> HCFHIKCHPAB<T>([In] T KOPHBHGIACG) where T : notnull
	{
		return default(GAKPFAEKJAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DC55E0", Offset = "0x3DC3BE0", VA = "0x183DC55E0")]
	public static GAKPFAEKJAN<T?> NHDNHLMAPIE<T>()
	{
		return default(GAKPFAEKJAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5130", Offset = "0x3DC3730", VA = "0x183DC5130")]
	public static bool DKGMAGJFPCF<T>([In] this GAKPFAEKJAN<T> LJEGLDELJNE, [Out][NotNullWhen(true)] T KOPHBHGIACG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DC50C0", Offset = "0x3DC36C0", VA = "0x183DC50C0")]
	public static bool DKGMAGJFPCF<T>([In] this GAKPFAEKJAN<T> LJEGLDELJNE, [Out][NotNullWhen(true)] T KOPHBHGIACG, [Out] GAKPFAEKJAN<T> DPJDNHFKCDJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DC52F0", Offset = "0x3DC38F0", VA = "0x183DC52F0")]
	public static T? KFHHJMKCOMJ<T>([In] this GAKPFAEKJAN<T> LJEGLDELJNE, T? APJDJFMLEAP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5350", Offset = "0x3DC3950", VA = "0x183DC5350")]
	public static bool KJFDNIOHLHM<T>([In] this GAKPFAEKJAN<T> LJEGLDELJNE, T KOPHBHGIACG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NLGMAMAAAKH
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F524C0", Offset = "0x3F50AC0", VA = "0x183F524C0")]
	public static T HJBALAJGDFL<T>([In] this GAKPFAEKJAN<T> LJEGLDELJNE) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct GFEHLKJIDDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr KPEAGBMOJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr NFJIBIHILIE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr OLMKCLCFLNA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr LOGOAICNONK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GFEHLKJIDDP HPOBBIFAPGN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8664120", Offset = "0x8662720", VA = "0x188664120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	public GFEHLKJIDDP(IntPtr GFKINOMLILO, IntPtr PEALOEGJGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void FDLGFHDLEFP(string NDIENANOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void JKINBNGHODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8664200", Offset = "0x8662800", VA = "0x188664200")]
	private static GFEHLKJIDDP HNPLIFDCICO()
	{
		return default(GFEHLKJIDDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct CMBLOCBDIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr FBDOINEOKMD;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
	private CMBLOCBDIHI(IntPtr PEALOEGJGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x865F880", Offset = "0x865DE80", VA = "0x18865F880")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x865F7A0", Offset = "0x865DDA0", VA = "0x18865F7A0")]
	public static CMBLOCBDIHI CPNHECDILPK(string NDIENANOGEK)
	{
		return default(CMBLOCBDIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B53A60", Offset = "0x2B52060", VA = "0x182B53A60")]
	public static CMBLOCBDIHI CPNHECDILPK([In] GFEHLKJIDDP MODBPHOKHEJ, string NDIENANOGEK)
	{
		return default(CMBLOCBDIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B53C50", Offset = "0x2B52250", VA = "0x182B53C50")]
	public static CMBLOCBDIHI CPNHECDILPK([In] GFEHLKJIDDP MODBPHOKHEJ, Func<string> NDIENANOGEK)
	{
		return default(CMBLOCBDIHI);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HFOGJHKEMEM : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? BPNMPBIBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr JGCCDIDPEMO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool AGDKOGKOKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8664C40", Offset = "0x8663240", VA = "0x188664C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8664630", Offset = "0x8662C30", VA = "0x188664630")]
	public static SHA256 CEAHGFMKGJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x86645C0", Offset = "0x8662BC0", VA = "0x1886645C0")]
	private static extern int CDBMLFPELLH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8664BD0", Offset = "0x86631D0", VA = "0x188664BD0")]
	private static extern IntPtr LMKMGKOPJED();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8664800", Offset = "0x8662E00", VA = "0x188664800")]
	private static extern void HDJKELDHAGJ(IntPtr JGCCDIDPEMO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8664740", Offset = "0x8662D40", VA = "0x188664740")]
	private static extern void FHNCFODPGJL(IntPtr JGCCDIDPEMO, byte[] CDDIADBJAOB, int PIOCNHLFCNE, int KIGAGEHDFOD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8664880", Offset = "0x8662E80", VA = "0x188664880")]
	private static extern void HKPIADPOOMG(IntPtr JGCCDIDPEMO, byte[] ANGMPLLKPDN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8664D30", Offset = "0x8663330", VA = "0x188664D30")]
	private HFOGJHKEMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8664920", Offset = "0x8662F20", VA = "0x188664920", Slot = "18")]
	protected override void HashCore(byte[] GHKPAFFMJAO, int OPHCBNEJLPB, int MBLJEEDKJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x86649E0", Offset = "0x8662FE0", VA = "0x1886649E0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8664B10", Offset = "0x8663110", VA = "0x188664B10", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86646B0", Offset = "0x8662CB0", VA = "0x1886646B0", Slot = "13")]
	protected override void Dispose(bool GBAHAHDFBCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FDAGDKOBEBC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool HPFNCOMBIED<in TInput, TResult>(TInput ECBHOIMIBKD, [Out] TResult FAKHJBCPGHO);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class JFPINKEALBG : BLAHGDCIKIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class BDHHMJCGAGD : MOAOINMFEPG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly BDHHMJCGAGD EHBCEBDHHPE;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool INFFINLHJFI
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x865D780", Offset = "0x865BD80", VA = "0x18865D780", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x865D7E0", Offset = "0x865BDE0", VA = "0x18865D7E0", Slot = "6")]
			public void OnCompleted(Action PJCIELKLJHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			public void BHIEPMNDMBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public BDHHMJCGAGD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly JFPINKEALBG EHBCEBDHHPE;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		private JFPINKEALBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8666000", Offset = "0x8664600", VA = "0x188666000", Slot = "4")]
		public MOAOINMFEPG FEOGLHAOOCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class BNEHMADNBIG : BLAHGDCIKIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class MPIDNKNHBHO : MOAOINMFEPG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly MPIDNKNHBHO EHBCEBDHHPE;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool INFFINLHJFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8668960", Offset = "0x8666F60", VA = "0x188668960", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8668980", Offset = "0x8666F80", VA = "0x188668980", Slot = "6")]
			public void OnCompleted(Action PJCIELKLJHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			public void BHIEPMNDMBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public MPIDNKNHBHO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly BNEHMADNBIG EHBCEBDHHPE;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		private BNEHMADNBIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x865E960", Offset = "0x865CF60", VA = "0x18865E960", Slot = "4")]
		public MOAOINMFEPG FEOGLHAOOCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MLAMFIBPELC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MLAMFIBPELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B020", Offset = "0x5A19620", VA = "0x185A1B020")]
		internal void HKDIOHAAKDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PKEHLJGMIKN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public PKEHLJGMIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A73670", Offset = "0x5A71C70", VA = "0x185A73670")]
		internal void KMODJPMHGFP(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LGDGGDGPODL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8667430", Offset = "0x8665A30", VA = "0x188667430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct PHKCAADBNND : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8669CE0", Offset = "0x86682E0", VA = "0x188669CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CIMJMPJGDBH<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x6F8BBC0", Offset = "0x6F8A1C0", VA = "0x186F8BBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BD30", Offset = "0x6F8A330", VA = "0x186F8BD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DNMDCLODHBI<T> : IAsyncStateMachine where T : notnull
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
		public IPHNFELODMJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4679530", Offset = "0x4677B30", VA = "0x184679530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4679950", Offset = "0x4677F50", VA = "0x184679950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GKFFFOLDHJI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x50FAEA0", Offset = "0x50F94A0", VA = "0x1850FAEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50FB710", Offset = "0x50F9D10", VA = "0x1850FB710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NFGCNGOIMPM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8668D00", Offset = "0x8667300", VA = "0x188668D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8668F10", Offset = "0x8667510", VA = "0x188668F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class BBAIFLFJECA<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BBAIFLFJECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B020", Offset = "0x5A19620", VA = "0x185A1B020")]
		internal void LMPCCCBFNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A04540", Offset = "0x6A02B40", VA = "0x186A04540")]
		internal void OIJHFMPMEGD(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BLFHNNFGJOK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public HPFNCOMBIED<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6AFBCA0", Offset = "0x6AFA2A0", VA = "0x186AFBCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC390", Offset = "0x6AFA990", VA = "0x186AFC390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct FCKDCIOKEPB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8661370", Offset = "0x865F970", VA = "0x188661370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8661B70", Offset = "0x8660170", VA = "0x188661B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct OLHBEDLJNPB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8669110", Offset = "0x8667710", VA = "0x188669110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x8669660", Offset = "0x8667C60", VA = "0x188669660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct NDBFIPMILAK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5A75BA0", Offset = "0x5A741A0", VA = "0x185A75BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x57C3B40", Offset = "0x57C2140", VA = "0x1857C3B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class OABOBEPPJGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<IHJGGHCFJKD> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OABOBEPPJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8669000", Offset = "0x8667600", VA = "0x188669000")]
		internal void CANHCGOHGLF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CCDCBOJGPKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x865EDC0", Offset = "0x865D3C0", VA = "0x18865EDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x865F040", Offset = "0x865D640", VA = "0x18865F040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PDMGJGNLNGM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5CAEA10", Offset = "0x5CAD010", VA = "0x185CAEA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x45B0F70", Offset = "0x45AF570", VA = "0x1845B0F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct JLCKGBBFDPG<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x54EF500", Offset = "0x54EDB00", VA = "0x1854EF500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45B0020", Offset = "0x45AE620", VA = "0x1845B0020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct AGOHFIIHPPC<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x54108A0", Offset = "0x540EEA0", VA = "0x1854108A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5411760", Offset = "0x540FD60", VA = "0x185411760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MAGEPBMMCMK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8667EF0", Offset = "0x86664F0", VA = "0x188667EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x86680D0", Offset = "0x86666D0", VA = "0x1886680D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct ILOLKKHJODC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8665BB0", Offset = "0x86641B0", VA = "0x188665BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8665F20", Offset = "0x8664520", VA = "0x188665F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct LCLBGALKFBE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86664C0", Offset = "0x8664AC0", VA = "0x1886664C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x86667B0", Offset = "0x8664DB0", VA = "0x1886667B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class NDMFMKMLKCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NDMFMKMLKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8668A50", Offset = "0x8667050", VA = "0x188668A50")]
		internal Task KBAJJFLIADE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct KJHKEPOILAF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8666200", Offset = "0x8664800", VA = "0x188666200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8666460", Offset = "0x8664A60", VA = "0x188666460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct DFNKNDGLGEB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8660670", Offset = "0x865EC70", VA = "0x188660670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8660850", Offset = "0x865EE50", VA = "0x188660850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct ELDMLJPKHLD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8660FB0", Offset = "0x865F5B0", VA = "0x188660FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8661310", Offset = "0x865F910", VA = "0x188661310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct PJLEDOOCHIC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8669DF0", Offset = "0x86683F0", VA = "0x188669DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x866A0E0", Offset = "0x86686E0", VA = "0x18866A0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class AGAKKJCOCGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AGAKKJCOCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x865CF80", Offset = "0x865B580", VA = "0x18865CF80")]
		internal Task PLPJBKFJGFJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IIKNFCLBFLM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86658F0", Offset = "0x8663EF0", VA = "0x1886658F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8665B50", Offset = "0x8664150", VA = "0x188665B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct HFAFCENOGDI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86643E0", Offset = "0x86629E0", VA = "0x1886643E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8664560", Offset = "0x8662B60", VA = "0x188664560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct IICDBEGKBHN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x52842A0", Offset = "0x52828A0", VA = "0x1852842A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x52847C0", Offset = "0x5282DC0", VA = "0x1852847C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct BPMPDFLAKIA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x865EA30", Offset = "0x865D030", VA = "0x18865EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x865ED60", Offset = "0x865D360", VA = "0x18865ED60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? MIACKLINMAK;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<IHJGGHCFJKD> DJOCGBHHNCD;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task HDHAIKCDKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8663180", Offset = "0x8661780", VA = "0x188663180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8663150", Offset = "0x8661750", VA = "0x188663150")]
	public static bool HILHKPHBLNH(this Task DIAHJIAKEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DB89F0", Offset = "0x3DB6FF0", VA = "0x183DB89F0")]
	public static Task<T> KJOCIELIFEI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86623C0", Offset = "0x86609C0", VA = "0x1886623C0")]
	public static Task DJAIDLCOPJE(this Task DIAHJIAKEPB, CancellationToken INEEADCBMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5F50", Offset = "0x3DB4550", VA = "0x183DB5F50")]
	public static Task<TResult> DJAIDLCOPJE<TResult>(this Task<TResult> DIAHJIAKEPB, CancellationToken INEEADCBMPK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB4430", Offset = "0x3DB2A30", VA = "0x183DB4430")]
	public static TaskCompletionSource<TResult> DJAIDLCOPJE<TResult>(this TaskCompletionSource<TResult> OHMKJGBLDPI, CancellationToken INEEADCBMPK) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8662230", Offset = "0x8660830", VA = "0x188662230")]
	public static IDisposable? CPEOEEJJAEF(CancellationToken DACNLKMADDD, CancellationToken FIIPILJOOFE, [Out] CancellationToken LNOOJMCLODO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x86632A0", Offset = "0x86618A0", VA = "0x1886632A0")]
	[AsyncStateMachine(typeof(LGDGGDGPODL))]
	public static void JIMPOALGAMH(this Task DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8662890", Offset = "0x8660E90", VA = "0x188662890")]
	[AsyncStateMachine(typeof(PHKCAADBNND))]
	public static void DNFFAIJKCBE(this Task DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8760", Offset = "0x3DB6D60", VA = "0x183DB8760")]
	[AsyncStateMachine(typeof(CIMJMPJGDBH<>))]
	public static Task HFIMJPMECLN<TException>(this Task DHDFDKFCOJK) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8640", Offset = "0x3DB6C40", VA = "0x183DB8640")]
	[AsyncStateMachine(typeof(DNMDCLODHBI<>))]
	public static Task<T> GLKPPIJADJI<T>(this Task<T> JNMMMBJNOND, IPHNFELODMJ AMCHCCAPJNG, Func<Task<T>, string> ADECEFEBJAF, bool DCBEMAKKAMN = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8480", Offset = "0x3DB6A80", VA = "0x183DB8480")]
	[AsyncStateMachine(typeof(GKFFFOLDHJI<>))]
	public static Task<T> GLKPPIJADJI<T>(this Task<T> JNMMMBJNOND) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8663480", Offset = "0x8661A80", VA = "0x188663480")]
	[AsyncStateMachine(typeof(NFGCNGOIMPM))]
	public static Task<TaskStatus> KFDBJGLCCFI(this Task? JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8240", Offset = "0x3DB6840", VA = "0x183DB8240")]
	public static (Task<T?>?, Action<T?>?) DPGLGNIMOLA<T>([Optional] CancellationToken PJCIHHKJKBP)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8140", Offset = "0x3DB6740", VA = "0x183DB8140")]
	[AsyncStateMachine(typeof(BLFHNNFGJOK<, >))]
	public static Task<List<TResult>> DPDBIMBFCAB<TResult, TInput>(this Task<List<TInput>> DIAHJIAKEPB, HPFNCOMBIED<TInput, TResult> MINKBOFCIOC) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8663350", Offset = "0x8661950", VA = "0x188663350")]
	[AsyncStateMachine(typeof(FCKDCIOKEPB))]
	public static Task JLKEDLPGOJG(Task DHDFDKFCOJK, CancellationToken FMFKCOIOLLA, Func<CancellationToken, Task> HNCDCGOIJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x86635F0", Offset = "0x8661BF0", VA = "0x1886635F0")]
	[AsyncStateMachine(typeof(OLHBEDLJNPB))]
	public static Task LMHBIBBAKAO(Func<CancellationToken, Task> DKNOGGCGCNN, TimeSpan HLLDHAAGBHH, [Optional] CancellationToken FMFKCOIOLLA, [Optional] Action<OperationCanceledException>? GPAEKNOHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8B40", Offset = "0x3DB7140", VA = "0x183DB8B40")]
	[AsyncStateMachine(typeof(NDBFIPMILAK<>))]
	public static Task<T> LMHBIBBAKAO<T>(Func<CancellationToken, Task<T>> DKNOGGCGCNN, TimeSpan HLLDHAAGBHH, [Optional] CancellationToken FMFKCOIOLLA, [Optional] Func<OperationCanceledException, T>? GPAEKNOHFGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8663C30", Offset = "0x8662230", VA = "0x188663C30")]
	public static Task NOOCDONDAPN(params Task[] BLACKNGJAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8663770", Offset = "0x8661D70", VA = "0x188663770")]
	public static Task NOOCDONDAPN(IEnumerable<Task> BLACKNGJAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8663050", Offset = "0x8661650", VA = "0x188663050")]
	[AsyncStateMachine(typeof(CCDCBOJGPKI))]
	public static Task<IEnumerable<Task>> HHOFNOLKNED(IEnumerable<Task> BLACKNGJAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8910", Offset = "0x3DB6F10", VA = "0x183DB8910")]
	[AsyncStateMachine(typeof(PDMGJGNLNGM<>))]
	public static Task<IEnumerable<Task<T>>> HHOFNOLKNED<T>(IEnumerable<Task<T>> BLACKNGJAMD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8020", Offset = "0x3DB6620", VA = "0x183DB8020")]
	[AsyncStateMachine(typeof(JLCKGBBFDPG<, , >))]
	public static Task<(T1, T2, T3)> DKMFAEJLCFE<T1, T2, T3>(Task<T1> DAKOJPMKPKP, Task<T2> HKADKGDPIAB, Task<T3> EEONHFPCHOJ) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7D60", Offset = "0x3DB6360", VA = "0x183DB7D60")]
	[AsyncStateMachine(typeof(AGOHFIIHPPC<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> DKMFAEJLCFE<T1, T2, T3, T4, T5>(Task<T1> DAKOJPMKPKP, Task<T2> HKADKGDPIAB, Task<T3> EEONHFPCHOJ, Task<T4> LLGNIGLIIBG, Task<T5> FHEIIBJGDKA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8661CE0", Offset = "0x86602E0", VA = "0x188661CE0")]
	[AsyncStateMachine(typeof(MAGEPBMMCMK))]
	public static Task AHJCLHNDKCN(Func<bool> MAMPOCOOMDJ, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8661BD0", Offset = "0x86601D0", VA = "0x188661BD0")]
	[AsyncStateMachine(typeof(ILOLKKHJODC))]
	public static Task AHJCLHNDKCN(Func<bool> MAMPOCOOMDJ, TimeSpan ENEPFNJBCJB, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8662620", Offset = "0x8660C20", VA = "0x188662620")]
	[AsyncStateMachine(typeof(LCLBGALKFBE))]
	public static Task DKACMKJKNFG(Func<bool> MAMPOCOOMDJ, TimeSpan HLLDHAAGBHH, [Optional] CancellationToken PJCIHHKJKBP, [Optional] Action<OperationCanceledException>? GPAEKNOHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8662750", Offset = "0x8660D50", VA = "0x188662750")]
	[AsyncStateMachine(typeof(KJHKEPOILAF))]
	public static Task DKACMKJKNFG(Func<bool> MAMPOCOOMDJ, TimeSpan HLLDHAAGBHH, TimeSpan ENEPFNJBCJB, [Optional] CancellationToken PJCIHHKJKBP, [Optional] Action<OperationCanceledException>? GPAEKNOHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8661DD0", Offset = "0x86603D0", VA = "0x188661DD0")]
	[AsyncStateMachine(typeof(DFNKNDGLGEB))]
	public static Task ANNOKFMEEIH(Func<bool> MAMPOCOOMDJ, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8661EC0", Offset = "0x86604C0", VA = "0x188661EC0")]
	[AsyncStateMachine(typeof(ELDMLJPKHLD))]
	public static Task ANNOKFMEEIH(Func<bool> MAMPOCOOMDJ, TimeSpan ENEPFNJBCJB, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8662940", Offset = "0x8660F40", VA = "0x188662940")]
	[AsyncStateMachine(typeof(PJLEDOOCHIC))]
	public static Task EDJIHGHHCMN(Func<bool> MAMPOCOOMDJ, TimeSpan HLLDHAAGBHH, [Optional] CancellationToken PJCIHHKJKBP, [Optional] Action<OperationCanceledException>? GPAEKNOHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8662A70", Offset = "0x8661070", VA = "0x188662A70")]
	[AsyncStateMachine(typeof(IIKNFCLBFLM))]
	public static Task EDJIHGHHCMN(Func<bool> MAMPOCOOMDJ, TimeSpan HLLDHAAGBHH, TimeSpan ENEPFNJBCJB, [Optional] CancellationToken PJCIHHKJKBP, [Optional] Action<OperationCanceledException>? GPAEKNOHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8663DA0", Offset = "0x86623A0", VA = "0x188663DA0")]
	[Obsolete]
	[AsyncStateMachine(typeof(HFAFCENOGDI))]
	public static Task PLFALBEBPLL(this Task DIAHJIAKEPB, Action LKLEOFGGGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8DA0", Offset = "0x3DB73A0", VA = "0x183DB8DA0")]
	[Obsolete]
	[AsyncStateMachine(typeof(IICDBEGKBHN<>))]
	public static Task PLFALBEBPLL<T>(this Task<T> DIAHJIAKEPB, Action<T> LKLEOFGGGAE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x86631F0", Offset = "0x86617F0", VA = "0x1886631F0")]
	private static void JGKCNIEICKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8662C80", Offset = "0x8661280", VA = "0x188662C80")]
	public static bool GDMHHOPJOIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x86620A0", Offset = "0x86606A0", VA = "0x1886620A0")]
	private static void CDLECEJJGCP(SynchronizationContext KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8663C80", Offset = "0x8662280", VA = "0x188663C80")]
	private static void PCFPKFHCPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8661FD0", Offset = "0x86605D0", VA = "0x188661FD0")]
	public static void CBJGALMEICO([Optional] string? GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8663570", Offset = "0x8661B70", VA = "0x188663570")]
	public static void KHJFEEJLMEA([Optional] string? GKNICJPCIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8663000", Offset = "0x8661600", VA = "0x188663000")]
	public static BLAHGDCIKIH HAGDAIFLAEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8663720", Offset = "0x8661D20", VA = "0x188663720")]
	public static BLAHGDCIKIH MINHIFDLILP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8662BB0", Offset = "0x86611B0", VA = "0x188662BB0")]
	[AsyncStateMachine(typeof(BPMPDFLAKIA))]
	public static Task GAKFBKDBAEP(Func<Task> OFMFDPOLEGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OEHADFBFMEG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public OEHADFBFMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NEPDPLOGLGK
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8668BE0", Offset = "0x86671E0", VA = "0x188668BE0")]
	public static bool NGHNBIKOCIM(this NLHAHNGMGDL JPDNMCPNBME, DateTime ANGMMGNIAFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8668AC0", Offset = "0x86670C0", VA = "0x188668AC0")]
	public static TimeSpan BKOENBIKEMI(this NLHAHNGMGDL JPDNMCPNBME, DateTime ANGMMGNIAFB)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CKBOGPMCKIM : NLHAHNGMGDL
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly NLHAHNGMGDL EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime OAMDOIAHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x865F6E0", Offset = "0x865DCE0", VA = "0x18865F6E0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset DLDKLHNPJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x865F680", Offset = "0x865DC80", VA = "0x18865F680", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CKBOGPMCKIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface NLHAHNGMGDL
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime OAMDOIAHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset DLDKLHNPJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class MOALIKMAODL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long EADFOHEBJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8668210", Offset = "0x8666810", VA = "0x188668210")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long KIOFNCJCMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8668130", Offset = "0x8666730", VA = "0x188668130")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double NEEACKPBPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8668260", Offset = "0x8666860", VA = "0x188668260")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double MFCDPIIFIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86682B0", Offset = "0x86668B0", VA = "0x1886682B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double EJOEKBDHDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8668300", Offset = "0x8666900", VA = "0x188668300")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double NDMCEOOJFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8668640", Offset = "0x8666C40", VA = "0x188668640")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x86684B0", Offset = "0x8666AB0", VA = "0x1886684B0")]
	public static double LGPDDDEONHH(long NBNFPOCJBOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8668420", Offset = "0x8666A20", VA = "0x188668420")]
	public static double KPBJGBBIDJA(long NBNFPOCJBOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x86685B0", Offset = "0x8666BB0", VA = "0x1886685B0")]
	public static double NBAOGIDNPDF(double OGAKHLCKCFG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8668180", Offset = "0x8666780", VA = "0x188668180")]
	public static long CEOLBHMPDGA(long OEDPOHDPEIB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x86685A0", Offset = "0x8666BA0", VA = "0x1886685A0")]
	public static long LKNMEJACDOD(long GHIBNOGBHCD, long BBEMFPKELGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8668350", Offset = "0x8666950", VA = "0x188668350")]
	public static double GAAMNJHCKHL(long GHIBNOGBHCD, long BBEMFPKELGN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8668540", Offset = "0x8666B40", VA = "0x188668540")]
	public static double LINKFCPAHFC(long GHIBNOGBHCD, long BBEMFPKELGN)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class ELADMGBOPNN : AOIIIIJCKKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan EILBPEPKCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer PGBOBMDDLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan HLLDHAAGBHH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan OGCCPKPBHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86608B0", Offset = "0x865EEB0", VA = "0x1886608B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? BMDLKHKLPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8660F40", Offset = "0x865F540", VA = "0x188660F40")]
	[Preserve]
	public ELADMGBOPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8660CF0", Offset = "0x865F2F0", VA = "0x188660CF0")]
	public ELADMGBOPNN(TimeSpan HLLDHAAGBHH, [Optional] Action? BJEIFJPHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8660BF0", Offset = "0x865F1F0", VA = "0x188660BF0", Slot = "7")]
	public void PLMAAMEONBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8660B50", Offset = "0x865F150", VA = "0x188660B50", Slot = "8")]
	public void MAOBAABIKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8660BC0", Offset = "0x865F1C0", VA = "0x188660BC0", Slot = "9")]
	public void MBDDDNAIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x134F7B0", Offset = "0x134DDB0", VA = "0x18134F7B0")]
	private void NAODJKAAEKA(object APAPCLFINDP, ElapsedEventArgs ILMCLCDCMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8660AB0", Offset = "0x865F0B0", VA = "0x188660AB0")]
	private static void FLIPGJEGLOK(TimeSpan PGDHOFEABIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8660A10", Offset = "0x865F010", VA = "0x188660A10", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DGKFKBGENGO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? JCLFDLINOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string KIOBNCLEIFA;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x19DC5B0", Offset = "0x19DABB0", VA = "0x1819DC5B0")]
	public DGKFKBGENGO(string NGPLKKDGJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x54C01A0", Offset = "0x54BE7A0", VA = "0x1854C01A0")]
	public DGKFKBGENGO(string PEIEJMGOHLN, string NGPLKKDGJMB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct BIEIIMGPOMM : IEquatable<BIEIIMGPOMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint GOGCMHGNGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int GPBIFEFLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float DGNBAIJOAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort PHFDDBKKGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort LDFAIELJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short LNHIGHGBCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short JDOMNOGAKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char OFGKDGGJLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char CJLPAAGPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte JONOEKDGANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte IKNAIIMNHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte OHJBAKJFOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte PNIDKJBGMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool MNBIHDBJGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool KDCELMFCLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool LKJFLMLKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool ODBHLPPHBNB;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x21D6500", Offset = "0x21D4B00", VA = "0x1821D6500")]
	public static BIEIIMGPOMM AHCJOKNKPCB(uint ECPKOEEHBLO)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x21D6500", Offset = "0x21D4B00", VA = "0x1821D6500")]
	public static BIEIIMGPOMM MFPEHBACJMJ(int AKEMJGPPHCG)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x865DB60", Offset = "0x865C160", VA = "0x18865DB60")]
	public static BIEIIMGPOMM LCJHIFKIFMI(float DNAIFHPLLLJ)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x865DAC0", Offset = "0x865C0C0", VA = "0x18865DAC0")]
	public static BIEIIMGPOMM CBMHNKKPPBD(byte CHJKEGFMNOI, byte MJFOBMHODHE, byte BBGLPBDJOCB, byte EPCMILDNNCD)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x865DAC0", Offset = "0x865C0C0", VA = "0x18865DAC0")]
	public static BIEIIMGPOMM FEHBLJMFGKL(bool NHBHPECINMC, bool NLIAHKLKBFC, bool HCFJEFHBBOM, bool OECCIOKIABC)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x865DAC0", Offset = "0x865C0C0", VA = "0x18865DAC0")]
	public static BIEIIMGPOMM LCMALAPGOPB(byte MHCNEBHPJBB, byte EHDKLIBGJNA, byte HAIDMMPMPKJ, byte IGECJLKOFJE)
	{
		return default(BIEIIMGPOMM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x25282F0", Offset = "0x25268F0", VA = "0x1825282F0")]
	public static bool MGLHCKHANFO(BIEIIMGPOMM BNPLNGPMIIG, BIEIIMGPOMM DIIGMDFDOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x25282D0", Offset = "0x25268D0", VA = "0x1825282D0", Slot = "4")]
	public bool Equals(BIEIIMGPOMM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x865DAE0", Offset = "0x865C0E0", VA = "0x18865DAE0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x15FD7A0", Offset = "0x15FBDA0", VA = "0x1815FD7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x865DB70", Offset = "0x865C170", VA = "0x18865DB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct GAMJFMNGPPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong CNMIHKIKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long PBIKGHNBMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double MLJKOJHAIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint MONKMJEDDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint FNBIHNGCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int GGDHIFANOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int GPNAEPFALMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float ENJAJHKLJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float KEBMPHNCDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort PHFDDBKKGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort LDFAIELJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort IDOMKPGAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort PCFOOCPEHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short LNHIGHGBCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short JDOMNOGAKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short HFJLMPNGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short NOAILFEHBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char OFGKDGGJLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char CJLPAAGPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char PAHIJGICIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char NPHBGANEPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte JONOEKDGANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte IKNAIIMNHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte OHJBAKJFOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte PNIDKJBGMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte GHPEHKGAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte AOPEFDOGMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte DDEOCDFAKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte HAPBNCANEEI;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static GAMJFMNGPPP CPNHECDILPK(long CJJHGCMHEAJ)
	{
		return default(GAMJFMNGPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8663F50", Offset = "0x8662550", VA = "0x188663F50")]
	public static GAMJFMNGPPP CPNHECDILPK(byte CHJKEGFMNOI, byte MJFOBMHODHE, byte BBGLPBDJOCB, byte EPCMILDNNCD, byte OIEBBALGJEH, byte NCALILMOEGA, byte LOJKIPJKJHC, byte HHNDFCIMLNA)
	{
		return default(GAMJFMNGPPP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct DDOPBDOLANJ : IEquatable<DDOPBDOLANJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte CGLCBJFPKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool HBNDBEECECM;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x32B08D0", Offset = "0x32AEED0", VA = "0x1832B08D0")]
	public static DDOPBDOLANJ CBMHNKKPPBD(byte LHAJAIJJBGD)
	{
		return default(DDOPBDOLANJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x32B08D0", Offset = "0x32AEED0", VA = "0x1832B08D0")]
	public static DDOPBDOLANJ FEHBLJMFGKL(bool BAGCEIOAFAC)
	{
		return default(DDOPBDOLANJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x86603D0", Offset = "0x865E9D0", VA = "0x1886603D0")]
	public static bool MGLHCKHANFO(DDOPBDOLANJ BNPLNGPMIIG, DDOPBDOLANJ DIIGMDFDOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0C0", Offset = "0x74D96C0", VA = "0x1874DB0C0", Slot = "4")]
	public bool Equals(DDOPBDOLANJ AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8660330", Offset = "0x865E930", VA = "0x188660330", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x86603C0", Offset = "0x865E9C0", VA = "0x1886603C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x86603E0", Offset = "0x865E9E0", VA = "0x1886603E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class NGJHHEEBOJO<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T DNBCEBPDMPK;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5A818C0", Offset = "0x5A7FEC0", VA = "0x185A818C0")]
	public NGJHHEEBOJO(T KEHNNELHGKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class DDHHJDADLOB
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3C22F20", Offset = "0x3C21520", VA = "0x183C22F20")]
	public static IEnumerable<T> MPOHHIECNHB<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static T[] NNGIDJDJNLD<T>(params T[] LJNMFEDKNGP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static IEnumerable<T> DIKMEPLKFOK<T>(params T[] LJNMFEDKNGP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static HashSet<T> LNOCLPBPKHL<T>(params T[] LJNMFEDKNGP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3C22F40", Offset = "0x3C21540", VA = "0x183C22F40")]
	public static KeyValuePair<TKey, TValue> PKGMLJPGGNF<TKey, TValue>([In] TKey HAELBKGFDIJ, [In] TValue KOPHBHGIACG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static List<T> BPLEGNKJNJC<T>(IEnumerable<T> KBJJADJMHBH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MBMFJPHEJIC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string NFPMAIHKNII;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
	public MBMFJPHEJIC(string BNIHMOKPGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object IEONEGAJFIL<T>([In] T PNGANGECEEL);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object ENLPBBNEAID<T>(T PNGANGECEEL);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FJLLCDEFFIL]
public delegate string BGLLIHEOMHC(string DPCMOBNBPGE, string? EIDEEAHADAH, bool DLEEJOPODOH);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[FJLLCDEFFIL]
public delegate void FMMKJKBBOFM(string GKNICJPCIJJ);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[FJLLCDEFFIL]
public delegate void OODIABCOFBD(Exception BGIFIJLJEDG);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object DFPNFEOMIOL();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FJLLCDEFFIL]
public delegate bool INIBNJKBLBC();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[FJLLCDEFFIL]
public delegate string HIKJCCBBHGG(object MPIDDJPOOMJ);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class CDNOMKKLBGM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
	public CDNOMKKLBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class BBCFGOCENGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct LHIINAFFGGI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8667590", Offset = "0x8665B90", VA = "0x188667590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8667E80", Offset = "0x8666480", VA = "0x188667E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback JPFMEHKNBED;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> HMANENAOKCA;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x865D1B0", Offset = "0x865B7B0", VA = "0x18865D1B0")]
	public static Task<bool> JEHPPAPLEAH(int HHJOIKIFOCO, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x865D080", Offset = "0x865B680", VA = "0x18865D080")]
	[AsyncStateMachine(typeof(LHIINAFFGGI))]
	private static Task<bool> DKADKOOIIEA(int HHJOIKIFOCO, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x865D4C0", Offset = "0x865BAC0", VA = "0x18865D4C0")]
	private static void PJJBONJIDOA(object? HFPFCKAPBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x865CFF0", Offset = "0x865B5F0", VA = "0x18865CFF0")]
	private static void DAJIOJBPHEL(object? HFPFCKAPBFI)
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
