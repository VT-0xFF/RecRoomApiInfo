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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D73B70", Offset = "0x7D72170", VA = "0x187D73B70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KJBPMOEEKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D72390", Offset = "0x7D70990", VA = "0x187D72390")]
	public static string LEEDJCCMEMN(this Encoding FDLEBGPAJEJ, [In] ReadOnlySequence<byte> ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x390A210", Offset = "0x3908810", VA = "0x18390A210")]
	private static void BCPOOADILDI<T>(this ReadOnlySequence<T> NFKNDNEHMAF, [Out] ReadOnlySpan<T> EBHJAAHLIDP, [Out] SequencePosition IACIPAIGMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LPGLPFHKCBI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D72C00", Offset = "0x7D71200", VA = "0x187D72C00")]
	public LPGLPFHKCBI(bool CAAALHFPCAI, string AIKKFHNDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D72BB0", Offset = "0x7D711B0", VA = "0x187D72BB0")]
	public LPGLPFHKCBI(bool CAAALHFPCAI, params string[] JKKONBPIKLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KKOGCCBPMPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EJMNAGMKNIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LCEGOANCOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDLKMEHAOPC(string OEHHKNIGGMI, double OHLIHBDBKCE, [Optional] string? DANLLHJAIGM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JDIBNENMGGC : NIDIDDCCLDI, JHOOMDLCLDA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int MOBKBEMEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> FCCPDLFMFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double COJGDIKBGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double JNIBMOMFMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double CKHGHFHLFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int NKEKCMCKJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double OECEKBMHBFE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NHICNGCLEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double PIDJCBBHANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D71AA0", Offset = "0x7D700A0", VA = "0x187D71AA0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OAKLBKNNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA140", Offset = "0x4EA8740", VA = "0x184EAA140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double INMGPHGEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x270D900", Offset = "0x270BF00", VA = "0x18270D900", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D71B00", Offset = "0x7D70100", VA = "0x187D71B00")]
	public JDIBNENMGGC(int FAIHGMPNCBA, double OECEKBMHBFE = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D71900", Offset = "0x7D6FF00", VA = "0x187D71900", Slot = "7")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D71A30", Offset = "0x7D70030", VA = "0x187D71A30", Slot = "8")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D71800", Offset = "0x7D6FE00", VA = "0x187D71800", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AAFOMMBHOOJ : NIDIDDCCLDI, JHOOMDLCLDA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long JAALIADHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double JPFECOHOJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double NPECLGOCHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BBCIDNIBCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double PHMFLEIJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double COJGDIKBGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double JNIBMOMFMLL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OAKLBKNNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7007240", Offset = "0x7005840", VA = "0x187007240", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double INMGPHGEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7007230", Offset = "0x7005830", VA = "0x187007230", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FHLDGDOIBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7007250", Offset = "0x7005850", VA = "0x187007250")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double PIDJCBBHANB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7660", Offset = "0x2DE5C60", VA = "0x182DE7660", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A820", Offset = "0x7D68E20", VA = "0x187D6A820", Slot = "10")]
	public virtual void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A940", Offset = "0x7D68F40", VA = "0x187D6A940", Slot = "11")]
	public virtual void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A7B0", Offset = "0x7D68DB0", VA = "0x187D6A7B0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A980", Offset = "0x7D68F80", VA = "0x187D6A980")]
	public AAFOMMBHOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MDHHDMHOKHF : AAFOMMBHOOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double PBOCNFGNNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70071C0", Offset = "0x70057C0", VA = "0x1870071C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70071F0", Offset = "0x70057F0", VA = "0x1870071F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D72CD0", Offset = "0x7D712D0", VA = "0x187D72CD0", Slot = "10")]
	public override void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D72E00", Offset = "0x7D71400", VA = "0x187D72E00", Slot = "11")]
	public override void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A980", Offset = "0x7D68F80", VA = "0x187D6A980")]
	public MDHHDMHOKHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIDIDDCCLDI : JHOOMDLCLDA, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double PIDJCBBHANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OAKLBKNNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double INMGPHGEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OKIOOMFCKHO : JHOOMDLCLDA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double LJABNNDOGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double NFHEGDMJBHA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D767B0", Offset = "0x7D74DB0", VA = "0x187D767B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5990", Offset = "0x7CA3F90", VA = "0x187CA5990", Slot = "4")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D767C0", Offset = "0x7D74DC0", VA = "0x187D767C0", Slot = "5")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D76760", Offset = "0x7D74D60", VA = "0x187D76760", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OKIOOMFCKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JHOOMDLCLDA : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBJIMKGMFAK(double GCDAJLDGOIF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGPJOLOPJJK();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FMKLHAJHDJC : JHOOMDLCLDA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OHLIHBDBKCE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4598B80", Offset = "0x4597180", VA = "0x184598B80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53C0590", Offset = "0x53BEB90", VA = "0x1853C0590", Slot = "4")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D70050", Offset = "0x7D6E650", VA = "0x187D70050", Slot = "5")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D70000", Offset = "0x7D6E600", VA = "0x187D70000", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FMKLHAJHDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LBFDKGKNEBG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> GHBHBEPOKLL(CancellationToken CBJPDIFOEKF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BCGMKJFDEDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LBFDKGKNEBG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GHBHBEPOKLL taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x6141E80", Offset = "0x6140480", VA = "0x186141E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6142F40", Offset = "0x6141540", VA = "0x186142F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource CLDKCMPEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? EONMAMFMAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? CKEIECNONAE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50E2E80", Offset = "0x50E1480", VA = "0x1850E2E80")]
	[AsyncStateMachine(typeof(LBFDKGKNEBG<>.BCGMKJFDEDG))]
	public Task<TResult> LKIEBKPIJOF(GHBHBEPOKLL HBFHHJFANBG, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x50E2E10", Offset = "0x50E1410", VA = "0x1850E2E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x50E2FC0", Offset = "0x50E15C0", VA = "0x1850E2FC0")]
	public LBFDKGKNEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GMOLLFIOBBC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> DBFKNAFIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0A40", Offset = "0x4ACF040", VA = "0x184AD0A40")]
	public GMOLLFIOBBC([In] T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4ACFC00", Offset = "0x4ACE200", VA = "0x184ACFC00", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0120", Offset = "0x4ACE720", VA = "0x184AD0120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4AD0620", Offset = "0x4ACEC20", VA = "0x184AD0620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LLLCPPLPFDL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static GMOLLFIOBBC<T> ACADPGMDEBE<T>([In] T OHLIHBDBKCE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FHKGLDHHOFF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D6F670", Offset = "0x7D6DC70", VA = "0x187D6F670")]
	public static void HEODPPLAKOL(this CancellationTokenSource CLDKCMPEHDC, bool NFABGGIKPKJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class JGDLMDOFCHA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public JGDLMDOFCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MAKNJFCMNJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public MAKNJFCMNJF(string OKEMKFHOKHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BGIHHGJBJJP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35DF9C0", Offset = "0x35DDFC0", VA = "0x1835DF9C0")]
	public static LOECJBACHMA NBLHDGPNMBH<T>()
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35DFC10", Offset = "0x35DE210", VA = "0x1835DFC10")]
	public static LOECJBACHMA NBMDBKABAKM<T>([CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35DFA40", Offset = "0x35DE040", VA = "0x1835DFA40")]
	public static LOECJBACHMA NBLHDGPNMBH<T>(this T COFBNOFIHKI) where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35DF870", Offset = "0x35DDE70", VA = "0x1835DF870")]
	public static LOECJBACHMA LOBKOJBGGLL<T>(this T COFBNOFIHKI, [CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35DFCB0", Offset = "0x35DE2B0", VA = "0x1835DFCB0")]
	public static LOECJBACHMA NBMDBKABAKM<T>(this T OCACDKEJIIB, [CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BC70", Offset = "0x7D6A270", VA = "0x187D6BC70")]
	public static LOECJBACHMA NBMDBKABAKM(string IKGOKFOKHEB, [CallerMemberName] string NFHOBPDKIPM = "")
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BBD0", Offset = "0x7D6A1D0", VA = "0x187D6BBD0")]
	public static string GGDPAGAAIFJ(this object OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool NMLIJJKMNLJ();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[JGDLMDOFCHA]
public delegate long DANGJHHNPGG();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DJFGPKFJPCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly DJFGPKFJPCJ MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DJFGPKFJPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OBMJKJDNOHF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static FNBCFEJPHNA JONNNFPDLGH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FNBCFEJPHNA IKLHLLIPMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D76380", Offset = "0x7D74980", VA = "0x187D76380")]
		get
		{
			return default(FNBCFEJPHNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EHAADHBFEAM LAMACDECCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D761D0", Offset = "0x7D747D0", VA = "0x187D761D0")]
		get
		{
			return default(EHAADHBFEAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NEPIHMACEAF NPLDJICFOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7D76650", Offset = "0x7D74C50", VA = "0x187D76650")]
		get
		{
			return default(NEPIHMACEAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool EKILDLGJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7D76220", Offset = "0x7D74820", VA = "0x187D76220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D75F60", Offset = "0x7D74560", VA = "0x187D75F60")]
	public static void BODCAGEIIMC([In] FNBCFEJPHNA LPELJKFNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D75E20", Offset = "0x7D74420", VA = "0x187D75E20")]
	public static void AHIMDJPCPBN(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D76100", Offset = "0x7D74700", VA = "0x187D76100")]
	public static void DHIFPOPFCLO(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x39E5EC0", Offset = "0x39E44C0", VA = "0x1839E5EC0")]
	public static void DHIFPOPFCLO<T>(T GIOLPIPFPPJ, MIAHIJJOJBN<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D763D0", Offset = "0x7D749D0", VA = "0x187D763D0")]
	public static void KCOJMKBBKEL(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D76290", Offset = "0x7D74890", VA = "0x187D76290")]
	public static void FPDKFGADAIA(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D76470", Offset = "0x7D74A70", VA = "0x187D76470")]
	public static void KDAGONIHHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D76310", Offset = "0x7D74910", VA = "0x187D76310")]
	public static string GGDPAGAAIFJ(object BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D75EF0", Offset = "0x7D744F0", VA = "0x187D75EF0")]
	public static long BAMFJDHCHAN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D765B0", Offset = "0x7D74BB0", VA = "0x187D765B0")]
	public static bool NHFGNGLOMIB(bool BELPALHENKI, string NAAMEAFIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D764E0", Offset = "0x7D74AE0", VA = "0x187D764E0")]
	public static double NGDEOFBOOLD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FNBCFEJPHNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly EHAADHBFEAM LAMACDECCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly NEPIHMACEAF NPLDJICFOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly MLOHCMBFEOP JONOFBKLIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly DANGJHHNPGG JLKFCKAEGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly ILJKKFDKAHE CGBCGKIBKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly NMLIJJKMNLJ EIGLFFKCBIL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MLOHCMBFEOP HEDMDKBAJBO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly DANGJHHNPGG MDFKPLCHEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ILJKKFDKAHE DHKKJKIBFMG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NMLIJJKMNLJ OPADAKPOPCI;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly FNBCFEJPHNA KKKNNENCOAG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D701A0", Offset = "0x7D6E7A0", VA = "0x187D701A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D709F0", Offset = "0x7D6EFF0", VA = "0x187D709F0")]
	public FNBCFEJPHNA([In] EHAADHBFEAM AMKBPOJJCOD, [In] NEPIHMACEAF HNLHGBPMMHG, MLOHCMBFEOP OANAGHPKPKL, DANGJHHNPGG FNDPHKNCAIN, ILJKKFDKAHE NKCFLJCLIHE, NMLIJJKMNLJ FCIBPFDBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D70060", Offset = "0x7D6E660", VA = "0x187D70060")]
	private static string FCIMHPGOEAB(object BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	private static long IAHCLIDADIF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	private static string APOCCMIALFI(string ANKDPLMACBD, string? MJMGMHHAAHB, bool GMEMNKBLNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	private static bool CBONBNNLOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D700A0", Offset = "0x7D6E6A0", VA = "0x187D700A0")]
	private static FNBCFEJPHNA FGFFHJFPMHM()
	{
		return default(FNBCFEJPHNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HFMNNPMJELN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PFLFCOGKNAI NCACCMDALIC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PFLFCOGKNAI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MFDNMEOBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NINCFNJEAPF();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DAMNADAKDKD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJLLIPJENJL([In] T MIJLJBIHDMP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void PNELPKNHFHD<T>([In] T GIOLPIPFPPJ);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct FKGDJNIBAEN<T> : IEquatable<FKGDJNIBAEN<T>>, DAMNADAKDKD<FKGDJNIBAEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T FPGFCMMHMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int CEBFMOBHAGD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x49B3D80", Offset = "0x49B2380", VA = "0x1849B3D80")]
	public FKGDJNIBAEN([In] T OHLIHBDBKCE, int OHHMJGCBCKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x49B2AE0", Offset = "0x49B10E0", VA = "0x1849B2AE0")]
	public static bool MMJMCICIDNJ([In] FKGDJNIBAEN<T> JOOBCOFNIAM, [In] FKGDJNIBAEN<T> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x49B2450", Offset = "0x49B0A50", VA = "0x1849B2450", Slot = "4")]
	public bool Equals(FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x49B23C0", Offset = "0x49B09C0", VA = "0x1849B23C0", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x49B22A0", Offset = "0x49B08A0", VA = "0x1849B22A0")]
	public bool DJLLIPJENJL([In] FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x49B26D0", Offset = "0x49B0CD0", VA = "0x1849B26D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x49B35D0", Offset = "0x49B1BD0", VA = "0x1849B35D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x49B1D70", Offset = "0x49B0370", VA = "0x1849B1D70")]
	public void BGDNOIMKKGE([Out] T OHLIHBDBKCE, [Out] int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49B3080", Offset = "0x49B1680", VA = "0x1849B3080")]
	public (T, int) OLNMFLOGPBC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49B3030", Offset = "0x49B1630", VA = "0x1849B3030", Slot = "5")]
	private bool NGOHBPOGKLP([In] FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BEOPFBPFNPC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x35DE060", Offset = "0x35DC660", VA = "0x1835DE060")]
	public static FKGDJNIBAEN<T> ACADPGMDEBE<T>([In] T OHLIHBDBKCE, int OHHMJGCBCKD) where T : notnull
	{
		return default(FKGDJNIBAEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MPCAICHJJIN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3947930", Offset = "0x3945F30", VA = "0x183947930")]
	public static bool DJLLIPJENJL<T, U>([In] T OCACDKEJIIB, [In] U BOMDCGFKGKF) where T : notnull, DAMNADAKDKD<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult CHDNKHGPFHA<T, out TResult>([In] T GIOLPIPFPPJ);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LINJFLLHBCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan KFEHOHNPBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? BMANJEPHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDIKNMDACEI();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBGFGCEPPMD();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EJJCFNDELCF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EHAADHBFEAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DJMDDLNHOOH HAEGJLDBHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IGMBFBEPAIF BHDCDFCOLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DJMDDLNHOOH OJIPJMJBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IGMBFBEPAIF EHJLNKHDGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly DJMDDLNHOOH IDJBALKIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IGMBFBEPAIF DAMKIELJINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly PHGMMJPLHDI KMDHNMBLOPJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DJMDDLNHOOH BEBCNDAMLOB;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IGMBFBEPAIF ENGIKMKKECJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DJMDDLNHOOH LJBPABAKHHO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IGMBFBEPAIF DOFKDAPMPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DJMDDLNHOOH NCDLHGEJFIA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly IGMBFBEPAIF CNKAJPPANID;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly PHGMMJPLHDI GKFFLEBGLOC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly EHAADHBFEAM KKKNNENCOAG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DJMDDLNHOOH NLHBDCGPADG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DF50", Offset = "0x7D6C550", VA = "0x187D6DF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD74220", Offset = "0xD72820", VA = "0x180D74220")]
	public EHAADHBFEAM(DJMDDLNHOOH OCGNPIDGBOK, IGMBFBEPAIF NAOFJPHAIMF, DJMDDLNHOOH KKFPLOBDBBH, IGMBFBEPAIF PCPOFIKIIFH, DJMDDLNHOOH LDFEGCHMAHL, IGMBFBEPAIF DAHKAIMFFFA, PHGMMJPLHDI MINGJJNFCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	private static bool HFLINEIAKBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void IAMNPCICLII(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	private static bool DDGNDOOHPID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void MBDBGDKCKDB(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0")]
	private static bool NJDHFHPMALB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BAECHLGNLIP(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void MGLDMCHIDMI(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DD40", Offset = "0x7D6C340", VA = "0x187D6DD40")]
	private static EHAADHBFEAM FGFFHJFPMHM()
	{
		return default(EHAADHBFEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830")]
	private static bool HDEJBIJCDOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DB10", Offset = "0x7D6C110", VA = "0x187D6DB10")]
	public void AHIMDJPCPBN(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DCD0", Offset = "0x7D6C2D0", VA = "0x187D6DCD0")]
	public void EFJIAFKNFDE(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DB80", Offset = "0x7D6C180", VA = "0x187D6DB80")]
	public void DHIFPOPFCLO(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xD699B0", Offset = "0xD67FB0", VA = "0x180D699B0")]
	public void KCOJMKBBKEL(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DBF0", Offset = "0x7D6C1F0", VA = "0x187D6DBF0")]
	public void DHIFPOPFCLO(CDMFCCAOLJN NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x36FC5D0", Offset = "0x36FABD0", VA = "0x1836FC5D0")]
	public void DHIFPOPFCLO<T>(T GIOLPIPFPPJ, MIAHIJJOJBN<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x36FC360", Offset = "0x36FA960", VA = "0x1836FC360")]
	public void AHIMDJPCPBN<T>([In] T GIOLPIPFPPJ, LOKDMMKJOIC<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36FC500", Offset = "0x36FAB00", VA = "0x1836FC500")]
	public void DHIFPOPFCLO<T>([In] T GIOLPIPFPPJ, LOKDMMKJOIC<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7D6DE80", Offset = "0x7D6C480", VA = "0x187D6DE80")]
	public bool NHFGNGLOMIB(bool BELPALHENKI, string NAAMEAFIHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct LOECJBACHMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	public LOECJBACHMA(string OHLIHBDBKCE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00")]
	public static string OIFHDJNIHDL([In] LOECJBACHMA OCACDKEJIIB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22A2870", Offset = "0x22A0E70", VA = "0x1822A2870")]
	public static LOECJBACHMA OIFHDJNIHDL(string MIJLJBIHDMP)
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7D72B60", Offset = "0x7D71160", VA = "0x187D72B60")]
	public string JPBKKMBKMOL(string AMDHAEEMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7D72A80", Offset = "0x7D71080", VA = "0x187D72A80")]
	public string BECLJNFPGEH(object JFCMAFFDJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class IPFMAEIIMGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public IPFMAEIIMGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BONGKMFJEJA : IEquatable<BONGKMFJEJA>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "4")]
	public bool Equals(BONGKMFJEJA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C790", Offset = "0x7D6AD90", VA = "0x187D6C790", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C7E0", Offset = "0x7D6ADE0", VA = "0x187D6C7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C7F0", Offset = "0x7D6ADF0", VA = "0x187D6C7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HCCKFFEHNEM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HHIMBEIEIME<T> : IEquatable<HHIMBEIEIME<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T FPGFCMMHMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool DKGOKJOKDJI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PJBLILDKKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4B222D0", Offset = "0x4B208D0", VA = "0x184B222D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4B23320", Offset = "0x4B21920", VA = "0x184B23320")]
	public HHIMBEIEIME([In] T OHLIHBDBKCE, bool LHPCJNJIGBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4B222E0", Offset = "0x4B208E0", VA = "0x184B222E0")]
	public static bool MMJMCICIDNJ([In] HHIMBEIEIME<T> JOOBCOFNIAM, [In] HHIMBEIEIME<T> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4B20F90", Offset = "0x4B1F590", VA = "0x184B20F90", Slot = "4")]
	public bool Equals(HHIMBEIEIME<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4B211B0", Offset = "0x4B1F7B0", VA = "0x184B211B0", Slot = "0")]
	public override bool Equals(object? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B22170", Offset = "0x4B20770", VA = "0x184B22170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B22A40", Offset = "0x4B21040", VA = "0x184B22A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DHNJNCDDCFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x36B46B0", Offset = "0x36B2CB0", VA = "0x1836B46B0")]
	public static HHIMBEIEIME<T> OGGBJDHCODH<T>([In] T OHLIHBDBKCE) where T : notnull
	{
		return default(HHIMBEIEIME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x36B43D0", Offset = "0x36B29D0", VA = "0x1836B43D0")]
	public static HHIMBEIEIME<T?> JAJLEBKKLPI<T>()
	{
		return default(HHIMBEIEIME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x36B41D0", Offset = "0x36B27D0", VA = "0x1836B41D0")]
	public static bool AMJMHFCFGDN<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, [Out][NotNullWhen(true)] T OHLIHBDBKCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x36B4160", Offset = "0x36B2760", VA = "0x1836B4160")]
	public static bool AMJMHFCFGDN<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, [Out][NotNullWhen(true)] T OHLIHBDBKCE, [Out] HHIMBEIEIME<T> KEGPEOFCCOA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x36B4100", Offset = "0x36B2700", VA = "0x1836B4100")]
	public static T? AJHDBFHCDIP<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, T? JMMNJNFGHEP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x36B4450", Offset = "0x36B2A50", VA = "0x1836B4450")]
	public static bool OFFIOFLGDKP<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, T OHLIHBDBKCE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ANAHMFEKJCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FC57D0", Offset = "0x3FC3DD0", VA = "0x183FC57D0")]
	public static T GAAPEPFCECP<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NEPIHMACEAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr FPDKFGADAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr KDAGONIHHHK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr BNIGFMFGBFD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr CHJCMODLBOP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NEPIHMACEAF KKKNNENCOAG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NOJJAOAIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D73530", Offset = "0x7D71B30", VA = "0x187D73530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
	public NEPIHMACEAF(IntPtr KJFCOANDBJF, IntPtr LBJMHDOGLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void GINCOBIOKGP(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void BKHOMMMAMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D734A0", Offset = "0x7D71AA0", VA = "0x187D734A0")]
	private static NEPIHMACEAF FGFFHJFPMHM()
	{
		return default(NEPIHMACEAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct CLILDDJMALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr HJGGNGJFMHN;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
	private CLILDDJMALJ(IntPtr LBJMHDOGLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D6D9C0", Offset = "0x7D6BFC0", VA = "0x187D6D9C0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D6D8E0", Offset = "0x7D6BEE0", VA = "0x187D6D8E0")]
	public static CLILDDJMALJ ACADPGMDEBE(string NFHOBPDKIPM)
	{
		return default(CLILDDJMALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x278F920", Offset = "0x278DF20", VA = "0x18278F920")]
	public static CLILDDJMALJ ACADPGMDEBE([In] NEPIHMACEAF HNLHGBPMMHG, string NFHOBPDKIPM)
	{
		return default(CLILDDJMALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x278F970", Offset = "0x278DF70", VA = "0x18278F970")]
	public static CLILDDJMALJ ACADPGMDEBE([In] NEPIHMACEAF HNLHGBPMMHG, Func<string> NFHOBPDKIPM)
	{
		return default(CLILDDJMALJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BGDHHDHBDDO : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? EKHHDLAHIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr LFFAAMLEIKA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool PAOJMMGGIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B4A0", Offset = "0x7D69AA0", VA = "0x187D6B4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B6A0", Offset = "0x7D69CA0", VA = "0x187D6B6A0")]
	public static SHA256 FLLMCNLHKNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B720", Offset = "0x7D69D20", VA = "0x187D6B720")]
	private static extern int GOPJFDGJOPM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B430", Offset = "0x7D69A30", VA = "0x187D6B430")]
	private static extern IntPtr ABLHEEJLKEI();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B590", Offset = "0x7D69B90", VA = "0x187D6B590")]
	private static extern void DLCCEKDOGNG(IntPtr LFFAAMLEIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B980", Offset = "0x7D69F80", VA = "0x187D6B980")]
	private static extern void IAKBHFGLOGI(IntPtr LFFAAMLEIKA, byte[] APDBNIMCPID, int LLPAIMMACAP, int CKBLNNKJIGI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BB00", Offset = "0x7D6A100", VA = "0x187D6BB00")]
	private static extern void POPHKODDLFK(IntPtr LFFAAMLEIKA, byte[] NFGKNNFOCJH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BBA0", Offset = "0x7D6A1A0", VA = "0x187D6BBA0")]
	private BGDHHDHBDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B790", Offset = "0x7D69D90", VA = "0x187D6B790", Slot = "18")]
	protected override void HashCore(byte[] NBBLCIBNPBK, int KHOLIMNFOEH, int JEDGCPNMDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B850", Offset = "0x7D69E50", VA = "0x187D6B850", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D6BA40", Offset = "0x7D6A040", VA = "0x187D6BA40", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B610", Offset = "0x7D69C10", VA = "0x187D6B610", Slot = "13")]
	protected override void Dispose(bool OIDNBIJAMJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OACIKOKLBDI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool GAEOFKJACHH<in TInput, TResult>(TInput HPLMFDGMJFE, [Out] TResult OBOOAPELMPF);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class KLJODIJDBPH : HFMNNPMJELN
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class IIBLEOAMCOA : PFLFCOGKNAI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly IIBLEOAMCOA MLIJHBGBMKP;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool MFDNMEOBGFE
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7D712A0", Offset = "0x7D6F8A0", VA = "0x187D712A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7D71300", Offset = "0x7D6F900", VA = "0x187D71300", Slot = "6")]
			public void OnCompleted(Action ADGINAHIKGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			public void NINCFNJEAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public IIBLEOAMCOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly KLJODIJDBPH MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		private KLJODIJDBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D72950", Offset = "0x7D70F50", VA = "0x187D72950", Slot = "4")]
		public PFLFCOGKNAI NCACCMDALIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class DPPBOHGEDAO : HFMNNPMJELN
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class JGEIDKIODGH : PFLFCOGKNAI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly JGEIDKIODGH MLIJHBGBMKP;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool MFDNMEOBGFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x7D71F60", Offset = "0x7D70560", VA = "0x187D71F60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7D71F80", Offset = "0x7D70580", VA = "0x187D71F80", Slot = "6")]
			public void OnCompleted(Action ADGINAHIKGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			public void NINCFNJEAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JGEIDKIODGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly DPPBOHGEDAO MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		private DPPBOHGEDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DA50", Offset = "0x7D6C050", VA = "0x187D6DA50", Slot = "4")]
		public PFLFCOGKNAI NCACCMDALIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BEMFJEEBEEM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BEMFJEEBEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53F8B40", Offset = "0x53F7140", VA = "0x1853F8B40")]
		internal void KMEHMHPHIBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LDMKNCGNOLK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LDMKNCGNOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x510E570", Offset = "0x510CB70", VA = "0x18510E570")]
		internal void DOAOGLPMIGO(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PJIKGGBDAHI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7D769B0", Offset = "0x7D74FB0", VA = "0x187D769B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct CICHDLMNKGP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D6C0", Offset = "0x7D6BCC0", VA = "0x187D6D6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EBFLLPPKGBM<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x44F57A0", Offset = "0x44F3DA0", VA = "0x1844F57A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x44F5910", Offset = "0x44F3F10", VA = "0x1844F5910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct DKPFONJKFKI<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A46380", Offset = "0x6A44980", VA = "0x186A46380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A46BD0", Offset = "0x6A451D0", VA = "0x186A46BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PLBKAKGMDGN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7D76B10", Offset = "0x7D75110", VA = "0x187D76B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7D76D20", Offset = "0x7D75320", VA = "0x187D76D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NHJCOANPHJD<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NHJCOANPHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x53F8B40", Offset = "0x53F7140", VA = "0x1853F8B40")]
		internal void PPOIOKDEKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x53F8AC0", Offset = "0x53F70C0", VA = "0x1853F8AC0")]
		internal void GFGPAPNBDMM(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MKPFADDIFPE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public GAEOFKJACHH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x53670D0", Offset = "0x53656D0", VA = "0x1853670D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x53677E0", Offset = "0x5365DE0", VA = "0x1853677E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BJCMFDBIABP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BCF0", Offset = "0x7D6A2F0", VA = "0x187D6BCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C4F0", Offset = "0x7D6AAF0", VA = "0x187D6C4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PNJFBDBHNAE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7D76D90", Offset = "0x7D75390", VA = "0x187D76D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D772E0", Offset = "0x7D758E0", VA = "0x187D772E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PKIJECJHHBN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5621DA0", Offset = "0x56203A0", VA = "0x185621DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CF80", Offset = "0x4A5B580", VA = "0x184A5CF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AHPALGALCFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<BONGKMFJEJA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AHPALGALCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D6AC40", Offset = "0x7D69240", VA = "0x187D6AC40")]
		internal void KENEGFEDCEB(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct CEMGOIJHFHM<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x67A92F0", Offset = "0x67A78F0", VA = "0x1867A92F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x40792B0", Offset = "0x40778B0", VA = "0x1840792B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HFMMPNCNGHD<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4B0B220", Offset = "0x4B09820", VA = "0x184B0B220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4078360", Offset = "0x4076960", VA = "0x184078360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct JALPFMOKDJD<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4E675B0", Offset = "0x4E65BB0", VA = "0x184E675B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4E67DE0", Offset = "0x4E663E0", VA = "0x184E67DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct AHEGNPGKOHH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7D6AA00", Offset = "0x7D69000", VA = "0x187D6AA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7D6ABE0", Offset = "0x7D691E0", VA = "0x187D6ABE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct FGOPOIFFBEF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F2B0", Offset = "0x7D6D8B0", VA = "0x187D6F2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F610", Offset = "0x7D6DC10", VA = "0x187D6F610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct JIJKDNBMCBI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7D72040", Offset = "0x7D70640", VA = "0x187D72040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7D72330", Offset = "0x7D70930", VA = "0x187D72330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class NKKEDLPNJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NKKEDLPNJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7D73B00", Offset = "0x7D72100", VA = "0x187D73B00")]
		internal Task MELLADICKDC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct EMNOHBFCCCD : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EFF0", Offset = "0x7D6D5F0", VA = "0x187D6EFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F250", Offset = "0x7D6D850", VA = "0x187D6F250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct JBJEBKKPKIH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7D715C0", Offset = "0x7D6FBC0", VA = "0x187D715C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7D717A0", Offset = "0x7D6FDA0", VA = "0x187D717A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct NHAIFEBPHEJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7D73740", Offset = "0x7D71D40", VA = "0x187D73740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7D73AA0", Offset = "0x7D720A0", VA = "0x187D73AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct MJCJJGJPMFA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D73150", Offset = "0x7D71750", VA = "0x187D73150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D73440", Offset = "0x7D71A40", VA = "0x187D73440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class LLBGLAGBLMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LLBGLAGBLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D72A10", Offset = "0x7D71010", VA = "0x187D72A10")]
		internal Task CJHACEEMKDA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct EJOFLPIBPOA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E6E0", Offset = "0x7D6CCE0", VA = "0x187D6E6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E940", Offset = "0x7D6CF40", VA = "0x187D6E940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct PHCPJKJFBFC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7D767D0", Offset = "0x7D74DD0", VA = "0x187D767D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D76950", Offset = "0x7D74F50", VA = "0x187D76950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct EGOIAIFGCNI<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x451A7B0", Offset = "0x4518DB0", VA = "0x18451A7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x451AC70", Offset = "0x4519270", VA = "0x18451AC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JEEOCCJKHCJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7D71BD0", Offset = "0x7D701D0", VA = "0x187D71BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D71F00", Offset = "0x7D70500", VA = "0x187D71F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? BHGKAKNIGDC;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<BONGKMFJEJA> MEDNMFGDELE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task AGEIJMAAOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D752F0", Offset = "0x7D738F0", VA = "0x187D752F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D756B0", Offset = "0x7D73CB0", VA = "0x187D756B0")]
	public static bool JILPAEPDMCD(this Task BGKKDAHMDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x39DE4E0", Offset = "0x39DCAE0", VA = "0x1839DE4E0")]
	public static Task<T> BOLNKJGCHAP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D74820", Offset = "0x7D72E20", VA = "0x187D74820")]
	public static Task DLGGJCMGJPP(this Task BGKKDAHMDLM, CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39E1850", Offset = "0x39DFE50", VA = "0x1839E1850")]
	public static Task<TResult> DLGGJCMGJPP<TResult>(this Task<TResult> BGKKDAHMDLM, CancellationToken EJJDDFFADPC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39DF8B0", Offset = "0x39DDEB0", VA = "0x1839DF8B0")]
	public static TaskCompletionSource<TResult> DLGGJCMGJPP<TResult>(this TaskCompletionSource<TResult> LOEBJPCBENM, CancellationToken EJJDDFFADPC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D75520", Offset = "0x7D73B20", VA = "0x187D75520")]
	public static IDisposable? JALGNPHIKIG(CancellationToken DABJOALKGMN, CancellationToken CJHCEIJCFNK, [Out] CancellationToken MMHILHOGNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D74CE0", Offset = "0x7D732E0", VA = "0x187D74CE0")]
	[AsyncStateMachine(typeof(PJIKGGBDAHI))]
	public static void EIPEOOFPCOE(this Task LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D75860", Offset = "0x7D73E60", VA = "0x187D75860")]
	[AsyncStateMachine(typeof(CICHDLMNKGP))]
	public static void MPNMCDILIHB(this Task LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x39E3D20", Offset = "0x39E2320", VA = "0x1839E3D20")]
	[AsyncStateMachine(typeof(EBFLLPPKGBM<>))]
	public static Task MDPPEOBALPP<TException>(this Task LEMBKBGMCDG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39E3A30", Offset = "0x39E2030", VA = "0x1839E3A30")]
	[AsyncStateMachine(typeof(DKPFONJKFKI<>))]
	public static Task<T> IIDKJNAMBMA<T>(this Task<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D75430", Offset = "0x7D73A30", VA = "0x187D75430")]
	[AsyncStateMachine(typeof(PLBKAKGMDGN))]
	public static Task<TaskStatus> IKPBHOPACBD(this Task? OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x39E37B0", Offset = "0x39E1DB0", VA = "0x1839E37B0")]
	public static (Task<T?>?, Action<T?>?) GHPHEEMFOBD<T>([Optional] CancellationToken CBJPDIFOEKF)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39E3C10", Offset = "0x39E2210", VA = "0x1839E3C10")]
	[AsyncStateMachine(typeof(MKPFADDIFPE<, >))]
	public static Task<List<TResult>> IJABJMCHJCJ<TResult, TInput>(this Task<List<TInput>> BGKKDAHMDLM, GAEOFKJACHH<TInput, TResult> NNFCJLKEOFL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D75730", Offset = "0x7D73D30", VA = "0x187D75730")]
	[AsyncStateMachine(typeof(BJCMFDBIABP))]
	public static Task MADKMNOENPJ(Task LEMBKBGMCDG, CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task> EEAKCGIBEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D74110", Offset = "0x7D72710", VA = "0x187D74110")]
	[AsyncStateMachine(typeof(PNJFBDBHNAE))]
	public static Task CGAGLKEGKKJ(Func<CancellationToken, Task> KACLNFIKDJP, TimeSpan PKGMHLEONHK, [Optional] CancellationToken EBOFCHGLLPK, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39DE660", Offset = "0x39DCC60", VA = "0x1839DE660")]
	[AsyncStateMachine(typeof(PKIJECJHHBN<>))]
	public static Task<T> CGAGLKEGKKJ<T>(Func<CancellationToken, Task<T>> KACLNFIKDJP, TimeSpan PKGMHLEONHK, [Optional] CancellationToken EBOFCHGLLPK, [Optional] Func<OperationCanceledException, T>? JGAJKGLPELK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D747D0", Offset = "0x7D72DD0", VA = "0x187D747D0")]
	public static Task DKBOBBDGBGA(params Task[] CHFOMHMEILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D74310", Offset = "0x7D72910", VA = "0x187D74310")]
	public static Task DKBOBBDGBGA(IEnumerable<Task> CHFOMHMEILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x39E42F0", Offset = "0x39E28F0", VA = "0x1839E42F0")]
	[AsyncStateMachine(typeof(CEMGOIJHFHM<>))]
	public static Task<IEnumerable<Task<T>>> PFHDMJENJDL<T>(IEnumerable<Task<T>> CHFOMHMEILP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x39E40D0", Offset = "0x39E26D0", VA = "0x1839E40D0")]
	[AsyncStateMachine(typeof(HFMMPNCNGHD<, , >))]
	public static Task<(T1, T2, T3)> NFJNLEKDGHL<T1, T2, T3>(Task<T1> JGKNLODAOEN, Task<T2> PCNNFDGHLJK, Task<T3> EIGHLKPEHOJ) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39E3DF0", Offset = "0x39E23F0", VA = "0x1839E3DF0")]
	[AsyncStateMachine(typeof(JALPFMOKDJD<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> NFJNLEKDGHL<T1, T2, T3, T4, T5>(Task<T1> JGKNLODAOEN, Task<T2> PCNNFDGHLJK, Task<T3> EIGHLKPEHOJ, Task<T4> NFLONHKKHJL, Task<T5> MOAHHMANFKE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D75B60", Offset = "0x7D74160", VA = "0x187D75B60")]
	[AsyncStateMachine(typeof(AHEGNPGKOHH))]
	public static Task PJKJEGCAIJO(Func<bool> BELPALHENKI, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D75C50", Offset = "0x7D74250", VA = "0x187D75C50")]
	[AsyncStateMachine(typeof(FGOPOIFFBEF))]
	public static Task PJKJEGCAIJO(Func<bool> BELPALHENKI, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D73F30", Offset = "0x7D72530", VA = "0x187D73F30")]
	[AsyncStateMachine(typeof(JIJKDNBMCBI))]
	public static Task BHFAFEFMPON(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D73DF0", Offset = "0x7D723F0", VA = "0x187D73DF0")]
	[AsyncStateMachine(typeof(EMNOHBFCCCD))]
	public static Task BHFAFEFMPON(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D74EA0", Offset = "0x7D734A0", VA = "0x187D74EA0")]
	[AsyncStateMachine(typeof(JBJEBKKPKIH))]
	public static Task EPLMPKODCAD(Func<bool> BELPALHENKI, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D74D90", Offset = "0x7D73390", VA = "0x187D74D90")]
	[AsyncStateMachine(typeof(NHAIFEBPHEJ))]
	public static Task EPLMPKODCAD(Func<bool> BELPALHENKI, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D74BB0", Offset = "0x7D731B0", VA = "0x187D74BB0")]
	[AsyncStateMachine(typeof(MJCJJGJPMFA))]
	public static Task DPIJLGKACMG(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D74A70", Offset = "0x7D73070", VA = "0x187D74A70")]
	[AsyncStateMachine(typeof(EJOFLPIBPOA))]
	public static Task DPIJLGKACMG(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D73BF0", Offset = "0x7D721F0", VA = "0x187D73BF0")]
	[Obsolete]
	[AsyncStateMachine(typeof(PHCPJKJFBFC))]
	public static Task ACHKNOBCDCD(this Task BGKKDAHMDLM, Action GHNPMECCEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x39DE300", Offset = "0x39DC900", VA = "0x1839DE300")]
	[AsyncStateMachine(typeof(EGOIAIFGCNI<>))]
	[Obsolete]
	public static Task ACHKNOBCDCD<T>(this Task<T> BGKKDAHMDLM, Action<T> GHNPMECCEPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D74060", Offset = "0x7D72660", VA = "0x187D74060")]
	private static void BIFEMONKHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D74F90", Offset = "0x7D73590", VA = "0x187D74F90")]
	public static bool FBLBLAGOEEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D759E0", Offset = "0x7D73FE0", VA = "0x187D759E0")]
	private static void NPEGJNDOOAF(SynchronizationContext OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D73CE0", Offset = "0x7D722E0", VA = "0x187D73CE0")]
	private static void BDAMICJPKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D74240", Offset = "0x7D72840", VA = "0x187D74240")]
	public static void CJFFLGMEDPF([Optional] string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D75360", Offset = "0x7D73960", VA = "0x187D75360")]
	public static void GPOCMLHECKF([Optional] string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D753E0", Offset = "0x7D739E0", VA = "0x187D753E0")]
	public static HFMNNPMJELN HKOFLIEIBLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D756E0", Offset = "0x7D73CE0", VA = "0x187D756E0")]
	public static HFMNNPMJELN KFODGCFOLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D75910", Offset = "0x7D73F10", VA = "0x187D75910")]
	[AsyncStateMachine(typeof(JEEOCCJKHCJ))]
	public static Task NPBEPDIBJAF(Func<Task> NPLDOOBBCLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HJNCDIOGCJG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public HJNCDIOGCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BNGAHNJAFII
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C670", Offset = "0x7D6AC70", VA = "0x187D6C670")]
	public static bool LMCKOIEEEKF(this HGAOMCLAJHP POFHCGLLAAJ, DateTime MEMIBIIGPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C550", Offset = "0x7D6AB50", VA = "0x187D6C550")]
	public static TimeSpan JADBOOLLMAL(this HGAOMCLAJHP POFHCGLLAAJ, DateTime MEMIBIIGPEM)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CJFHAOHGIMG : HGAOMCLAJHP
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly HGAOMCLAJHP MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime JDNILLIMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D830", Offset = "0x7D6BE30", VA = "0x187D6D830", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset IGHAHCNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D7D0", Offset = "0x7D6BDD0", VA = "0x187D6D7D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public CJFHAOHGIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface HGAOMCLAJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime JDNILLIMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset IGHAHCNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HCBANHIODHP
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long LEBLFLACCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7D70C60", Offset = "0x7D6F260", VA = "0x187D70C60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long OHJCPEPIIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7D70FB0", Offset = "0x7D6F5B0", VA = "0x187D70FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double AMEFOBGKNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7D70AF0", Offset = "0x7D6F0F0", VA = "0x187D70AF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double EACENEGGCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7D70AA0", Offset = "0x7D6F0A0", VA = "0x187D70AA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double HLMBHPHPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7D70D80", Offset = "0x7D6F380", VA = "0x187D70D80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double PEGGLGJDEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7D70F60", Offset = "0x7D6F560", VA = "0x187D70F60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7D70B40", Offset = "0x7D6F140", VA = "0x187D70B40")]
	public static double ALDDPEFJMNK(long LOIBDKKEMNM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D70ED0", Offset = "0x7D6F4D0", VA = "0x187D70ED0")]
	public static double LCCHLCKNGEN(long LOIBDKKEMNM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7D70BD0", Offset = "0x7D6F1D0", VA = "0x187D70BD0")]
	public static double BBNPAMKHMLO(double JCNHGMDIBDN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7D70DD0", Offset = "0x7D6F3D0", VA = "0x187D70DD0")]
	public static long GNMIOIGPEIA(long EPOJNFBFHFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7D70EC0", Offset = "0x7D6F4C0", VA = "0x187D70EC0")]
	public static long KHIJJNLFPMD(long PHDKCCCKAIM, long JFGBCPNGOCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D70CB0", Offset = "0x7D6F2B0", VA = "0x187D70CB0")]
	public static double GEOONLPHPDL(long PHDKCCCKAIM, long JFGBCPNGOCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7D70E60", Offset = "0x7D6F460", VA = "0x187D70E60")]
	public static double KGHMEAFLDND(long PHDKCCCKAIM, long JFGBCPNGOCJ)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class ANGNBKIBCDE : LINJFLLHBCH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan MOOKKCEILAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer DCCJGOAMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan PKGMHLEONHK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan KFEHOHNPBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7D6AD50", Offset = "0x7D69350", VA = "0x187D6AD50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? BMANJEPHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B180", Offset = "0x7D69780", VA = "0x187D6B180")]
	[Preserve]
	public ANGNBKIBCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B1E0", Offset = "0x7D697E0", VA = "0x187D6B1E0")]
	public ANGNBKIBCDE(TimeSpan PKGMHLEONHK, [Optional] Action? IIMFJDOENFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B010", Offset = "0x7D69610", VA = "0x187D6B010", Slot = "7")]
	public void JDIKNMDACEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7D6B0A0", Offset = "0x7D696A0", VA = "0x187D6B0A0", Slot = "8")]
	public void PBGFGCEPPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AF50", Offset = "0x7D69550", VA = "0x187D6AF50", Slot = "9")]
	public void EJJCFNDELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x113DFD0", Offset = "0x113C5D0", VA = "0x18113DFD0")]
	private void IMOCAENGPAC(object COFBNOFIHKI, ElapsedEventArgs DNODKJELHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AF80", Offset = "0x7D69580", VA = "0x187D6AF80")]
	private static void EKCGJAPJJOO(TimeSpan PLKPHCDMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6AEB0", Offset = "0x7D694B0", VA = "0x187D6AEB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HCCKFFEHNEM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? ACJOIMALHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string BPBACGJDGJI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x168F0E0", Offset = "0x168D6E0", VA = "0x18168F0E0")]
	public HCCKFFEHNEM(string HHPFBMBMELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5066D00", Offset = "0x5065300", VA = "0x185066D00")]
	public HCCKFFEHNEM(string ALDJJJCLNOI, string HHPFBMBMELN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CDFNCNEGFME : IEquatable<CDFNCNEGFME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint LDDPDNJIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int LINDMABPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float AKDFDKADAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort EDIPKGJIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort PDLMHIGGDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short OHOFHEKFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short DPKIJMNNPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char OHJHLJDEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char LAJOKBHCGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BDPLLJHLHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte ABNIFDHOLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte AGCCBJPBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte GBHIMGOKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool BCMPCBPLDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool OLEAMOJDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool POLIODAEKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool JAIJOHKLKIF;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B780", Offset = "0x1E59D80", VA = "0x181E5B780")]
	public static CDFNCNEGFME IGEJHMNIIOM(uint OIFEOJPBJLB)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B780", Offset = "0x1E59D80", VA = "0x181E5B780")]
	public static CDFNCNEGFME EJPIOPPHJJM(int GNJBJNHAKAA)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C8C0", Offset = "0x7D6AEC0", VA = "0x187D6C8C0")]
	public static CDFNCNEGFME MCKEFPOLNAF(float CJBNGEDNPJC)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C8A0", Offset = "0x7D6AEA0", VA = "0x187D6C8A0")]
	public static CDFNCNEGFME MJHJPKNDJDI(byte PIHFAPPNFBN, byte IOAOBLBBIFC, byte KEHIMPHGFFO, byte MIHJPIIJBBG)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C8A0", Offset = "0x7D6AEA0", VA = "0x187D6C8A0")]
	public static CDFNCNEGFME NDLICFJFBAA(bool ICMHKJNHAPD, bool FPNLMJMIDFJ, bool EPJAGDCIBEL, bool GDMHFFFGDFH)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C8A0", Offset = "0x7D6AEA0", VA = "0x187D6C8A0")]
	public static CDFNCNEGFME HDFHCNJMIHB(byte JBHKILEAGAI, byte IAKBFKKGBCK, byte OBLGPGKEJBE, byte LEILOMHMPPD)
	{
		return default(CDFNCNEGFME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2151FE0", Offset = "0x21505E0", VA = "0x182151FE0")]
	public static bool MMJMCICIDNJ(CDFNCNEGFME OBNCJFFHHLB, CDFNCNEGFME ODHPFGNCGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2151FC0", Offset = "0x21505C0", VA = "0x182151FC0", Slot = "4")]
	public bool Equals(CDFNCNEGFME MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C820", Offset = "0x7D6AE20", VA = "0x187D6C820", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x12CE620", Offset = "0x12CCC20", VA = "0x1812CE620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7D6C8D0", Offset = "0x7D6AED0", VA = "0x187D6C8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct ACAMMOBHJAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong MNDDPPBLMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long FBBECJBNKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double MPCCNKLPOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint GMNGHOECMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint JFHBFIJLBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int MIHLFNHDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int KFJHBCMNHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float NHIEGFFGJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float EOKDKKACLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort EDIPKGJIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort PDLMHIGGDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort FHKFBKAJEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort IEIBICPLDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short OHOFHEKFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short DPKIJMNNPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short MPKLBFPDHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short ACEGLGFEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char OHJHLJDEGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char LAJOKBHCGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char DEKLIBAGGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char PHLIDLMGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte BDPLLJHLHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte ABNIFDHOLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte AGCCBJPBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte GBHIMGOKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte BGCIHGHOEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte PFKILKNAEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte HILOIPDOFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte LPPCAENHJEC;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static ACAMMOBHJAC ACADPGMDEBE(long FAFFDBLANFK)
	{
		return default(ACAMMOBHJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A9B0", Offset = "0x7D68FB0", VA = "0x187D6A9B0")]
	public static ACAMMOBHJAC ACADPGMDEBE(byte PIHFAPPNFBN, byte IOAOBLBBIFC, byte KEHIMPHGFFO, byte MIHJPIIJBBG, byte BBKJJGPGDAI, byte DFKJCAPACON, byte EPKGHNALJME, byte PGIFMEBPHFI)
	{
		return default(ACAMMOBHJAC);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MIHFKGDIHFA : IEquatable<MIHFKGDIHFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte JHFHLMOOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool MEJLBDICGGL;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2E12500", Offset = "0x2E10B00", VA = "0x182E12500")]
	public static MIHFKGDIHFA MJHJPKNDJDI(byte JMACIMHIJNG)
	{
		return default(MIHFKGDIHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12500", Offset = "0x2E10B00", VA = "0x182E12500")]
	public static MIHFKGDIHFA NDLICFJFBAA(bool NNPIKMKLMFJ)
	{
		return default(MIHFKGDIHFA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7D72EE0", Offset = "0x7D714E0", VA = "0x187D72EE0")]
	public static bool MMJMCICIDNJ(MIHFKGDIHFA OBNCJFFHHLB, MIHFKGDIHFA ODHPFGNCGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD2D0", Offset = "0x6CDB8D0", VA = "0x186CDD2D0", Slot = "4")]
	public bool Equals(MIHFKGDIHFA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7D72E40", Offset = "0x7D71440", VA = "0x187D72E40", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7D72ED0", Offset = "0x7D714D0", VA = "0x187D72ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D72EF0", Offset = "0x7D714F0", VA = "0x187D72EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MOKMAIBPLFE<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T CJGDBOMMJHK;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x537F550", Offset = "0x537DB50", VA = "0x18537F550")]
	public MOKMAIBPLFE(T FHCPCMAKMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class JPPAOPHOCML
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x38D38F0", Offset = "0x38D1EF0", VA = "0x1838D38F0")]
	public static IEnumerable<T> DFDNAGCGNLC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static T[] MONOABAFCHO<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static IEnumerable<T> GICLKIABNAM<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static HashSet<T> GOBPEEJPMHH<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x38D3920", Offset = "0x38D1F20", VA = "0x1838D3920")]
	public static KeyValuePair<TKey, TValue> OKDKKMOMFEN<TKey, TValue>([In] TKey OEHHKNIGGMI, [In] TValue OHLIHBDBKCE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static List<T> ILKFFMFPDIE<T>(IEnumerable<T> OLCBBPLHPLC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FCJMCJGJBOE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string PAHNCEILAHB;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
	public FCJMCJGJBOE(string FMDPDNGNNPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object LOKDMMKJOIC<T>([In] T ODJGLJIHJOP);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object MIAHIJJOJBN<T>(T ODJGLJIHJOP);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[JGDLMDOFCHA]
public delegate string ILJKKFDKAHE(string ANKDPLMACBD, string? MJMGMHHAAHB, bool GMEMNKBLNIL);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[JGDLMDOFCHA]
public delegate void IGMBFBEPAIF(string NAAMEAFIHJI);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[JGDLMDOFCHA]
public delegate void PHGMMJPLHDI(Exception APEPCFJIAMB);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object CDMFCCAOLJN();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[JGDLMDOFCHA]
public delegate bool DJMDDLNHOOH();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[JGDLMDOFCHA]
public delegate string MLOHCMBFEOP(object BOMDCGFKGKF);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class PHMCNKFFOBC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	public PHMCNKFFOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class ELKMBPMMDAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct FMFEJOKPOOG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F6A0", Offset = "0x7D6DCA0", VA = "0x187D6F6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FF90", Offset = "0x7D6E590", VA = "0x187D6FF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback MGELAOEKGOE;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> MHLBJDJPJCO;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EA30", Offset = "0x7D6D030", VA = "0x187D6EA30")]
	public static Task<bool> MMMKPPMDAMN(int BKJPMDLBAAF, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D6EDC0", Offset = "0x7D6D3C0", VA = "0x187D6EDC0")]
	[AsyncStateMachine(typeof(FMFEJOKPOOG))]
	private static Task<bool> OCNELEKPNMO(int BKJPMDLBAAF, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D6E9A0", Offset = "0x7D6CFA0", VA = "0x187D6E9A0")]
	private static void JOKPOONDBHJ(object? IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D6ED30", Offset = "0x7D6D330", VA = "0x187D6ED30")]
	private static void NAEIMINOKHE(object? IDAKFFICKHC)
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
