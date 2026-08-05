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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81049A0", Offset = "0x81031A0", VA = "0x1881049A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LGPOKCNONBH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8100B90", Offset = "0x80FF390", VA = "0x188100B90")]
	public static string CCOKPJIMHCN(this Encoding JMPFNOANDNO, [In] ReadOnlySequence<byte> LLNMEIMBBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6830", Offset = "0x3AA5030", VA = "0x183AA6830")]
	private static void MPNHPHECBIJ<T>(this ReadOnlySequence<T> HCNLFKBLDPE, [Out] ReadOnlySpan<T> PNLHHJGHFBI, [Out] SequencePosition JBDCBANFDGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NFLNPHMIEBN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8104370", Offset = "0x8102B70", VA = "0x188104370")]
	public NFLNPHMIEBN(bool BEOMCDIDBJC, string MHBIAJCGIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8104320", Offset = "0x8102B20", VA = "0x188104320")]
	public NFLNPHMIEBN(bool BEOMCDIDBJC, params string[] ENDGDHNHNLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FGONIOPCLOM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BBKAPFDDHGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CAEKPLKPCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPNIGNDBGNA(string MNMCNOJCKAF, double MGONBEDEDON, [Optional] string? MHJBGGNCBNM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EECJLJDLJNI : FAPKNGJKIDB, OCEBHKNJPBK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LILIOFJBHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> LKJAHAFIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double EDBIKCGPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double PIMEBNLNKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double BFHGHFNMGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int GAFNLEHKLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double MCGFDJEEKEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FIKFGNEKBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GKGMLNECCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80FA8D0", Offset = "0x80F90D0", VA = "0x1880FA8D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PGCPFGLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51C9120", Offset = "0x51C7920", VA = "0x1851C9120", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DENPJAMHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x27F9570", Offset = "0x27F7D70", VA = "0x1827F9570", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x80FA930", Offset = "0x80F9130", VA = "0x1880FA930")]
	public EECJLJDLJNI(int JCCOCLKGODK, double MCGFDJEEKEB = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80FA730", Offset = "0x80F8F30", VA = "0x1880FA730", Slot = "7")]
	public void MKMCEIJNBJC(double AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80FA860", Offset = "0x80F9060", VA = "0x1880FA860", Slot = "8")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80FA630", Offset = "0x80F8E30", VA = "0x1880FA630", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AKDBNMBKIJC : FAPKNGJKIDB, OCEBHKNJPBK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long FMGALNGIOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double BMAFGDJKJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double INGAPLFNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double DADHLEAMCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double DLPNJFKKOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double EDBIKCGPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double PIMEBNLNKIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PGCPFGLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7370D10", Offset = "0x736F510", VA = "0x187370D10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DENPJAMHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x73711C0", Offset = "0x736F9C0", VA = "0x1873711C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HBCNFPOIMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7370D60", Offset = "0x736F560", VA = "0x187370D60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GKGMLNECCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2F32540", Offset = "0x2F30D40", VA = "0x182F32540", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80F88A0", Offset = "0x80F70A0", VA = "0x1880F88A0", Slot = "10")]
	public virtual void MKMCEIJNBJC(double AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x80F89C0", Offset = "0x80F71C0", VA = "0x1880F89C0", Slot = "11")]
	public virtual void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80F8830", Offset = "0x80F7030", VA = "0x1880F8830", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A00", Offset = "0x80F7200", VA = "0x1880F8A00")]
	public AKDBNMBKIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MEAFBJCHCKK : AKDBNMBKIJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MHBFDEOFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7370CD0", Offset = "0x736F4D0", VA = "0x187370CD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73711B0", Offset = "0x736F9B0", VA = "0x1873711B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8101A00", Offset = "0x8100200", VA = "0x188101A00", Slot = "10")]
	public override void MKMCEIJNBJC(double AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8101B30", Offset = "0x8100330", VA = "0x188101B30", Slot = "11")]
	public override void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A00", Offset = "0x80F7200", VA = "0x1880F8A00")]
	public MEAFBJCHCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FAPKNGJKIDB : OCEBHKNJPBK, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GKGMLNECCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double PGCPFGLBPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DENPJAMHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AHMBEPIAJDB : OCEBHKNJPBK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double DCGNGALELPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double HANJNNHCKEE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80F8820", Offset = "0x80F7020", VA = "0x1880F8820")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6AF0", Offset = "0x6DC52F0", VA = "0x186DC6AF0", Slot = "4")]
	public void MKMCEIJNBJC(double AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x80F8810", Offset = "0x80F7010", VA = "0x1880F8810", Slot = "5")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80F87C0", Offset = "0x80F6FC0", VA = "0x1880F87C0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AHMBEPIAJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OCEBHKNJPBK : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKMCEIJNBJC(double AMJBMFFPJLL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMBGNLDGDEH();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ALIJMEBDECC : OCEBHKNJPBK, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double MGONBEDEDON;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x47C6B80", Offset = "0x47C5380", VA = "0x1847C6B80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5595D80", Offset = "0x5594580", VA = "0x185595D80", Slot = "4")]
	public void MKMCEIJNBJC(double AMJBMFFPJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A80", Offset = "0x80F7280", VA = "0x1880F8A80", Slot = "5")]
	public void MMBGNLDGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x80F8A30", Offset = "0x80F7230", VA = "0x1880F8A30", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ALIJMEBDECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BLMOODAEOCB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> JNLCNOKFMOK(CancellationToken GMEAHOBHMAD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JDCLHEEMLCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BLMOODAEOCB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public JNLCNOKFMOK taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x50A88D0", Offset = "0x50A70D0", VA = "0x1850A88D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50A9A10", Offset = "0x50A8210", VA = "0x1850A9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource JKCICFOHGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? HLKGLDKHNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? MCANNKDHHMH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x617AFD0", Offset = "0x61797D0", VA = "0x18617AFD0")]
	[AsyncStateMachine(typeof(BLMOODAEOCB<>.JDCLHEEMLCF))]
	public Task<TResult> EFCDLAJGIMF(JNLCNOKFMOK GFJFCKIKALC, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x617AF60", Offset = "0x6179760", VA = "0x18617AF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x617B120", Offset = "0x6179920", VA = "0x18617B120")]
	public BLMOODAEOCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EOOHMKBPBLA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> JJGBFEGGPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T HDAKFEADKFH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4755290", Offset = "0x4753A90", VA = "0x184755290")]
	public EOOHMKBPBLA([In] T MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47541B0", Offset = "0x47529B0", VA = "0x1847541B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4754A00", Offset = "0x4753200", VA = "0x184754A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4754F30", Offset = "0x4753730", VA = "0x184754F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ELKIPALAJOF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static EOOHMKBPBLA<T> CCPKJDCALBG<T>([In] T MGONBEDEDON) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CDFFOAJJCIH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80F9890", Offset = "0x80F8090", VA = "0x1880F9890")]
	public static void GHOFMIFDHJO(this CancellationTokenSource JKCICFOHGAG, bool HBHCLPIJFID = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class KDNEKMCOECK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public KDNEKMCOECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class IAIFEEAHNEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public IAIFEEAHNEM(string LLPAICJMOMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DFHBIKACGMM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37F8910", Offset = "0x37F7110", VA = "0x1837F8910")]
	public static MMNJMCNIGPO LDHLDBOGABI<T>()
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x80F9D30", Offset = "0x80F8530", VA = "0x1880F9D30")]
	public static MMNJMCNIGPO GKIHEJBFDFD([CallerMemberName] string HPANEBBHGAC = "")
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37F85F0", Offset = "0x37F6DF0", VA = "0x1837F85F0")]
	public static MMNJMCNIGPO GICJCKPMDNG<T>([CallerMemberName] string HPANEBBHGAC = "") where T : notnull
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37F8890", Offset = "0x37F7090", VA = "0x1837F8890")]
	public static MMNJMCNIGPO LDHLDBOGABI<T>(this T FOIMOKIBLGB) where T : notnull
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37F8740", Offset = "0x37F6F40", VA = "0x1837F8740")]
	public static MMNJMCNIGPO GKIHEJBFDFD<T>(this T FOIMOKIBLGB, [CallerMemberName] string HPANEBBHGAC = "") where T : notnull
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x37F8690", Offset = "0x37F6E90", VA = "0x1837F8690")]
	public static MMNJMCNIGPO GICJCKPMDNG<T>(this T DKBBJFIDEGB, [CallerMemberName] string HPANEBBHGAC = "") where T : notnull
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80F9CB0", Offset = "0x80F84B0", VA = "0x1880F9CB0")]
	public static MMNJMCNIGPO GICJCKPMDNG(string CCEOEILPBBD, [CallerMemberName] string HPANEBBHGAC = "")
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x80F9D90", Offset = "0x80F8590", VA = "0x1880F9D90")]
	public static string ONDAOGFBHMB(this object DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool MNOJLOOGGBB();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KDNEKMCOECK]
public delegate long FGAGIHMJHMP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class POGDHFOIKGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly POGDHFOIKGM HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public POGDHFOIKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ICOJMDDBEDM
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static FMEHFPFJPMB CFJBFOPLOLO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static FMEHFPFJPMB KCLGBBNOIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80FE430", Offset = "0x80FCC30", VA = "0x1880FE430")]
		get
		{
			return default(FMEHFPFJPMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static HBPMIAHEKPK IODMDJGCKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x80FE710", Offset = "0x80FCF10", VA = "0x1880FE710")]
		get
		{
			return default(HBPMIAHEKPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NPCLOJKLJLJ BIKLLBBHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80FE760", Offset = "0x80FCF60", VA = "0x1880FE760")]
		get
		{
			return default(NPCLOJKLJLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool LCINOIPIMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80FE7B0", Offset = "0x80FCFB0", VA = "0x1880FE7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80FE1B0", Offset = "0x80FC9B0", VA = "0x1880FE1B0")]
	public static void BACEFKEHAHD([In] FMEHFPFJPMB CDBHDNEMKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x80FE820", Offset = "0x80FD020", VA = "0x1880FE820")]
	public static void MIHGFEDHECA(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80FE480", Offset = "0x80FCC80", VA = "0x1880FE480")]
	public static void GNLEBEMCOJM(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A1AED0", Offset = "0x3A196D0", VA = "0x183A1AED0")]
	public static void GNLEBEMCOJM<T>(T OPAHMKOAAKD, MHICAAGOHOI<T> ILBALOOKKCP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x80FE670", Offset = "0x80FCE70", VA = "0x1880FE670")]
	public static void KAOAGOLGPII(Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80FE5F0", Offset = "0x80FCDF0", VA = "0x1880FE5F0")]
	public static void HPNACKEBCKN(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x80FE350", Offset = "0x80FCB50", VA = "0x1880FE350")]
	public static void CBHPFDMELFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x80FE8F0", Offset = "0x80FD0F0", VA = "0x1880FE8F0")]
	public static string ONDAOGFBHMB(object HPLLAPMNIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x80FE3C0", Offset = "0x80FCBC0", VA = "0x1880FE3C0")]
	public static long EEIPIKMCHJF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80FE550", Offset = "0x80FCD50", VA = "0x1880FE550")]
	public static bool HAGFALCKAON(bool FLPNFIDBDHL, string ILBALOOKKCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x80FE960", Offset = "0x80FD160", VA = "0x1880FE960")]
	public static double PBDLNHFOHBK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct FMEHFPFJPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly HBPMIAHEKPK IODMDJGCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly NPCLOJKLJLJ BIKLLBBHHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly NKBBEILDJFM AFIPCPAEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly FGAGIHMJHMP LHPALKDDKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly HMMOLFPKGBL BECBKFKCFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly MNOJLOOGGBB FPKNBFKAMOM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NKBBEILDJFM AEHIGJGBPPA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly FGAGIHMJHMP IHEFJAMDEOG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HMMOLFPKGBL JFJHFDOGLHM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly MNOJLOOGGBB AEDPKNEIAOM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly FMEHFPFJPMB EBKBGKJDDBM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80FBC30", Offset = "0x80FA430", VA = "0x1880FBC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x80FC480", Offset = "0x80FAC80", VA = "0x1880FC480")]
	public FMEHFPFJPMB([In] HBPMIAHEKPK JLPPFIEMJCP, [In] NPCLOJKLJLJ FHLBNAKEPLD, NKBBEILDJFM ELJFKPDOIOF, FGAGIHMJHMP KGIBMJFGINF, HMMOLFPKGBL CHPINABHOCE, MNOJLOOGGBB IAOGHAMIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x80FBBF0", Offset = "0x80FA3F0", VA = "0x1880FBBF0")]
	private static string JGKJBKBDKHA(object HPLLAPMNIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50")]
	private static long MECKAKPNOJK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	private static string IOEOLGAMHBP(string FIBFJHPJKOF, string? EKCIHMCINHA, bool OMOKJLGFEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	private static bool PEDGDCLCKAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80FBAF0", Offset = "0x80FA2F0", VA = "0x1880FBAF0")]
	private static FMEHFPFJPMB CKFHIIIMAAB()
	{
		return default(FMEHFPFJPMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DCGIPGPMHOC
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDNFKNOPOEO GAFCKONHBEH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IDNFKNOPOEO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KLEBMFMNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKEMJFANLPK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FLLPMOIALDN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGEOBDDFMIA([In] T KEKEFPAJGHD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void ENLCJDMCPMH<T>([In] T OPAHMKOAAKD);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct KBDLKOIKJND<T> : IEquatable<KBDLKOIKJND<T>>, FLLPMOIALDN<KBDLKOIKJND<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T HDAKFEADKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int PJLMPJGAPPO;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x51909B0", Offset = "0x518F1B0", VA = "0x1851909B0")]
	public KBDLKOIKJND([In] T MGONBEDEDON, int PNJCJGEIDHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x518FCA0", Offset = "0x518E4A0", VA = "0x18518FCA0")]
	public static bool NALNDDPCEFD([In] KBDLKOIKJND<T> HGBNKPCDEON, [In] KBDLKOIKJND<T> DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x518EE40", Offset = "0x518D640", VA = "0x18518EE40", Slot = "4")]
	public bool Equals(KBDLKOIKJND<T> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A670", Offset = "0x4C58E70", VA = "0x184C5A670", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x518F4F0", Offset = "0x518DCF0", VA = "0x18518F4F0")]
	public bool HGEOBDDFMIA([In] KBDLKOIKJND<T> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x518F2F0", Offset = "0x518DAF0", VA = "0x18518F2F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51907F0", Offset = "0x518EFF0", VA = "0x1851907F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x518E600", Offset = "0x518CE00", VA = "0x18518E600")]
	public void EBKFCGEKMKA([Out] T MGONBEDEDON, [Out] int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x518F760", Offset = "0x518DF60", VA = "0x18518F760")]
	public (T, int) HIIFOPLNPIJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5190040", Offset = "0x518E840", VA = "0x185190040", Slot = "5")]
	private bool NLDBAFBCFAE([In] KBDLKOIKJND<T> KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PLHLLPJJDOK
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA4480", Offset = "0x3BA2C80", VA = "0x183BA4480")]
	public static KBDLKOIKJND<T> CCPKJDCALBG<T>([In] T MGONBEDEDON, int PNJCJGEIDHG) where T : notnull
	{
		return default(KBDLKOIKJND<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OJBEFEGKONC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FD30", Offset = "0x3B7E530", VA = "0x183B7FD30")]
	public static bool HGEOBDDFMIA<T, U>([In] T DKBBJFIDEGB, [In] U HPLLAPMNIJF) where T : notnull, FLLPMOIALDN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult BCPKGKKIGOM<T, out TResult>([In] T OPAHMKOAAKD);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OJDGAKBEPBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan AGAPPNLAEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? DONLEIANCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDHAAILNKGM();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLABHHHGFFB();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKPCEGHDCEL();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HBPMIAHEKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IDJFPLFCNBI FJJLAFDLLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DEMBKMKGDNH EPPKEIMLOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly IDJFPLFCNBI EABIGHLJAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DEMBKMKGDNH GAAJNJEOPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly IDJFPLFCNBI LGEPOPPPNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly DEMBKMKGDNH KCEMBNFHIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly FHDPMINOCMH GPKDHNLKAPI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly IDJFPLFCNBI GCKHMPPAALN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly DEMBKMKGDNH IDINEHCDIGL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly IDJFPLFCNBI JJJNLJOHCCA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly DEMBKMKGDNH DHCHJLKJAHB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly IDJFPLFCNBI DNHEAAAMMPA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly DEMBKMKGDNH FICFEJINIAP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly FHDPMINOCMH JFNPJEKFKFD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HBPMIAHEKPK EBKBGKJDDBM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly IDJFPLFCNBI KJCNGIILJNJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80FD4F0", Offset = "0x80FBCF0", VA = "0x1880FD4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE01990", Offset = "0xE00190", VA = "0x180E01990")]
	public HBPMIAHEKPK(IDJFPLFCNBI JCLLEJCOHNM, DEMBKMKGDNH BMDNDDLNMFE, IDJFPLFCNBI HJLKIGBCMLD, DEMBKMKGDNH IFLCJDFOPHC, IDJFPLFCNBI ODPBFAACPCF, DEMBKMKGDNH MINAECFEPGH, FHDPMINOCMH MNEHGAJBBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	private static bool EDLPGKIJBPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void JCGBACHJECJ(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	private static bool IHHJDGDBJBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void JLANOAAEHON(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	private static bool LGPHHHOMNKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void GIFAGILPOKD(string ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void DDFHNPHEICD(Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x80FD120", Offset = "0x80FB920", VA = "0x1880FD120")]
	private static HBPMIAHEKPK CKFHIIIMAAB()
	{
		return default(HBPMIAHEKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
	private static bool BGFDFGMKHEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x80FD6D0", Offset = "0x80FBED0", VA = "0x1880FD6D0")]
	public void MIHGFEDHECA(object ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x80FD480", Offset = "0x80FBC80", VA = "0x1880FD480")]
	public void HCCDHCBKLBI(object ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x80FD260", Offset = "0x80FBA60", VA = "0x1880FD260")]
	public void GNLEBEMCOJM(object ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xDF7D50", Offset = "0xDF6550", VA = "0x180DF7D50")]
	public void KAOAGOLGPII(Exception FKONJEEEEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x80FD2D0", Offset = "0x80FBAD0", VA = "0x1880FD2D0")]
	public void GNLEBEMCOJM(LCEDLBJLHMD ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x39F2590", Offset = "0x39F0D90", VA = "0x1839F2590")]
	public void GNLEBEMCOJM<T>(T OPAHMKOAAKD, MHICAAGOHOI<T> ILBALOOKKCP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x39F2800", Offset = "0x39F1000", VA = "0x1839F2800")]
	public void MIHGFEDHECA<T>([In] T OPAHMKOAAKD, MPNAIFINAJL<T> ILBALOOKKCP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x39F24C0", Offset = "0x39F0CC0", VA = "0x1839F24C0")]
	public void GNLEBEMCOJM<T>([In] T OPAHMKOAAKD, MPNAIFINAJL<T> ILBALOOKKCP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x80FD3B0", Offset = "0x80FBBB0", VA = "0x1880FD3B0")]
	public bool HAGFALCKAON(bool FLPNFIDBDHL, string ILBALOOKKCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MMNJMCNIGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string HDAKFEADKFH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xDB8C40", Offset = "0xDB7440", VA = "0x180DB8C40")]
	public MMNJMCNIGPO(string MGONBEDEDON)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
	public static string KEINEINMKGA([In] MMNJMCNIGPO DKBBJFIDEGB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x23CE7F0", Offset = "0x23CCFF0", VA = "0x1823CE7F0")]
	public static MMNJMCNIGPO KEINEINMKGA(string KEKEFPAJGHD)
	{
		return default(MMNJMCNIGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x81041F0", Offset = "0x81029F0", VA = "0x1881041F0")]
	public string AIMOKPHOMFM(string LMNKBMBBAAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8104240", Offset = "0x8102A40", VA = "0x188104240")]
	public string LPFMCGANAAD(object DBEDDDJOMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class IHLPLPGOHPJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public IHLPLPGOHPJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KCHLBHAFJKA : IEquatable<KCHLBHAFJKA>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "4")]
	public bool Equals(KCHLBHAFJKA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x80FEDB0", Offset = "0x80FD5B0", VA = "0x1880FEDB0", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x80FEE00", Offset = "0x80FD600", VA = "0x1880FEE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80FEE10", Offset = "0x80FD610", VA = "0x1880FEE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MGEKLMJLNJO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct ABDLIOMCAFI<T> : IEquatable<ABDLIOMCAFI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T HDAKFEADKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool NOLFCOEBCEE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool AJAFHDLNOIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4C59FB0", Offset = "0x4C587B0", VA = "0x184C59FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C5C440", Offset = "0x4C5AC40", VA = "0x184C5C440")]
	public ABDLIOMCAFI([In] T MGONBEDEDON, bool KDKDIKGMGML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4C5B490", Offset = "0x4C59C90", VA = "0x184C5B490")]
	public static bool NALNDDPCEFD([In] ABDLIOMCAFI<T> HGBNKPCDEON, [In] ABDLIOMCAFI<T> DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A250", Offset = "0x4C58A50", VA = "0x184C5A250", Slot = "4")]
	public bool Equals(ABDLIOMCAFI<T> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A4F0", Offset = "0x4C58CF0", VA = "0x184C5A4F0", Slot = "0")]
	public override bool Equals(object? KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4C5B050", Offset = "0x4C59850", VA = "0x184C5B050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4C5C150", Offset = "0x4C5A950", VA = "0x184C5C150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ABODPAKBMDH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x41E1A90", Offset = "0x41E0290", VA = "0x1841E1A90")]
	public static ABDLIOMCAFI<T> JFNPONGCHDF<T>([In] T MGONBEDEDON) where T : notnull
	{
		return default(ABDLIOMCAFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x41E1790", Offset = "0x41DFF90", VA = "0x1841E1790")]
	public static ABDLIOMCAFI<T?> GNAANNMINKL<T>()
	{
		return default(ABDLIOMCAFI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x41E1C30", Offset = "0x41E0430", VA = "0x1841E1C30")]
	public static bool POAABHCEGEJ<T>([In] this ABDLIOMCAFI<T> DLPKKEPMGNJ, [Out][NotNullWhen(true)] T MGONBEDEDON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x41E1BF0", Offset = "0x41E03F0", VA = "0x1841E1BF0")]
	public static bool POAABHCEGEJ<T>([In] this ABDLIOMCAFI<T> DLPKKEPMGNJ, [Out][NotNullWhen(true)] T MGONBEDEDON, [Out] ABDLIOMCAFI<T> NPPCHDNKMKC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B60", Offset = "0x41E0360", VA = "0x1841E1B60")]
	public static T? JMFINCGEDHJ<T>([In] this ABDLIOMCAFI<T> DLPKKEPMGNJ, T? GJPLADDCFJL)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x41E18A0", Offset = "0x41E00A0", VA = "0x1841E18A0")]
	public static bool JFCMINFIKGN<T>([In] this ABDLIOMCAFI<T> DLPKKEPMGNJ, T MGONBEDEDON) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DPFIOLJDCAG
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3825B10", Offset = "0x3824310", VA = "0x183825B10")]
	public static T OADAGMKGBDM<T>([In] this ABDLIOMCAFI<T> DLPKKEPMGNJ) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NPCLOJKLJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr HPNACKEBCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr CBHPFDMELFC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr JFHPGHIJAJG;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr KICLHPEHEPF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NPCLOJKLJLJ EBKBGKJDDBM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KBMDKILMFNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8104790", Offset = "0x8102F90", VA = "0x188104790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	public NPCLOJKLJLJ(IntPtr CLHHJHFNPFD, IntPtr FAEAKIOKJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void OBPKAPGKIJJ(string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void BADFDCGEACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8104700", Offset = "0x8102F00", VA = "0x188104700")]
	private static NPCLOJKLJLJ CKFHIIIMAAB()
	{
		return default(NPCLOJKLJLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct GMAOCOLFJLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr FECOLIOAFBB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
	private GMAOCOLFJLC(IntPtr FAEAKIOKJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80FD100", Offset = "0x80FB900", VA = "0x1880FD100")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80FD020", Offset = "0x80FB820", VA = "0x1880FD020")]
	public static GMAOCOLFJLC CCPKJDCALBG(string HPANEBBHGAC)
	{
		return default(GMAOCOLFJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28810A0", Offset = "0x287F8A0", VA = "0x1828810A0")]
	public static GMAOCOLFJLC CCPKJDCALBG([In] NPCLOJKLJLJ FHLBNAKEPLD, string HPANEBBHGAC)
	{
		return default(GMAOCOLFJLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2880DF0", Offset = "0x287F5F0", VA = "0x182880DF0")]
	public static GMAOCOLFJLC CCPKJDCALBG([In] NPCLOJKLJLJ FHLBNAKEPLD, Func<string> HPANEBBHGAC)
	{
		return default(GMAOCOLFJLC);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GBAONBNMBJD : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? BMPFBHMIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr EGLCAEFBHNE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool OJPJGPNLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x80FCBB0", Offset = "0x80FB3B0", VA = "0x1880FCBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80FC990", Offset = "0x80FB190", VA = "0x1880FC990")]
	public static SHA256 INHDMBAMCNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80FCB40", Offset = "0x80FB340", VA = "0x1880FCB40")]
	private static extern int MNICKDINFDP();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80FCAD0", Offset = "0x80FB2D0", VA = "0x1880FCAD0")]
	private static extern IntPtr JNPEFBCHMJM();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80FC530", Offset = "0x80FAD30", VA = "0x1880FC530")]
	private static extern void CBMKAPNDKFL(IntPtr EGLCAEFBHNE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80FC640", Offset = "0x80FAE40", VA = "0x1880FC640")]
	private static extern void GLILHKCGMON(IntPtr EGLCAEFBHNE, byte[] IMINNNCPCJF, int BJCMHPBMOOK, int FFBACKLICIN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80FC8F0", Offset = "0x80FB0F0", VA = "0x1880FC8F0")]
	private static extern void IJDAJNAMDAJ(IntPtr EGLCAEFBHNE, byte[] MGFPOMOPFJF);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80FCCA0", Offset = "0x80FB4A0", VA = "0x1880FCCA0")]
	private GBAONBNMBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80FC700", Offset = "0x80FAF00", VA = "0x1880FC700", Slot = "18")]
	protected override void HashCore(byte[] LPBOBEPEKNH, int HJKFOMKFKPG, int CNPJGKABGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80FC7C0", Offset = "0x80FAFC0", VA = "0x1880FC7C0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80FCA10", Offset = "0x80FB210", VA = "0x1880FCA10", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80FC5B0", Offset = "0x80FADB0", VA = "0x1880FC5B0", Slot = "13")]
	protected override void Dispose(bool OMBOBNKKHMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MEIIPAECGGP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool DHMLINHPBGL<in TInput, TResult>(TInput FNFJALHKEGF, [Out] TResult KJCFPPKBAOB);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class MHHPIPNKHBE : DCGIPGPMHOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class ALJPEEHJMKK : IDNFKNOPOEO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly ALJPEEHJMKK HPECEAELCLK;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool KLEBMFMNBBH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x80F8A90", Offset = "0x80F7290", VA = "0x1880F8A90", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x80F8AF0", Offset = "0x80F72F0", VA = "0x1880F8AF0", Slot = "6")]
			public void OnCompleted(Action NPPFMKINMGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			public void AKEMJFANLPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public ALJPEEHJMKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly MHHPIPNKHBE HPECEAELCLK;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		private MHHPIPNKHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8103DA0", Offset = "0x81025A0", VA = "0x188103DA0", Slot = "4")]
		public IDNFKNOPOEO GAFCKONHBEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class ELHBIEOKGGN : DCGIPGPMHOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class LPCGLJAKGMF : IDNFKNOPOEO, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly LPCGLJAKGMF HPECEAELCLK;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool KLEBMFMNBBH
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x8101150", Offset = "0x80FF950", VA = "0x188101150", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8101170", Offset = "0x80FF970", VA = "0x188101170", Slot = "6")]
			public void OnCompleted(Action NPPFMKINMGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			public void AKEMJFANLPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public LPCGLJAKGMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly ELHBIEOKGGN HPECEAELCLK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		private ELHBIEOKGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x80FB350", Offset = "0x80F9B50", VA = "0x1880FB350", Slot = "4")]
		public IDNFKNOPOEO GAFCKONHBEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GADCHPPJKGJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GADCHPPJKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4C76540", Offset = "0x4C74D40", VA = "0x184C76540")]
		internal void CJIONEOBLKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PHCHIJDEGBH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PHCHIJDEGBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x58A8900", Offset = "0x58A7100", VA = "0x1858A8900")]
		internal void KDNBBCBEOPA(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CDNPCPLOOGA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F98C0", Offset = "0x80F80C0", VA = "0x1880F98C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MCEGMLLGMJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x81012A0", Offset = "0x80FFAA0", VA = "0x1881012A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JJJAMJOBJFJ<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x50C0EE0", Offset = "0x50BF6E0", VA = "0x1850C0EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x50C1050", Offset = "0x50BF850", VA = "0x1850C1050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GELIMONBBOJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4C841B0", Offset = "0x4C829B0", VA = "0x184C841B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4C84A40", Offset = "0x4C83240", VA = "0x184C84A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BIOHGIBNLEO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F9250", Offset = "0x80F7A50", VA = "0x1880F9250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x80F9460", Offset = "0x80F7C60", VA = "0x1880F9460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class NPIFNHILIIJ<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NPIFNHILIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4C76540", Offset = "0x4C74D40", VA = "0x184C76540")]
		internal void OJBGHLCEMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x55F6730", Offset = "0x55F4F30", VA = "0x1855F6730")]
		internal void JIFLEBGMBMO(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct ONBJKFHNONK<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public DHMLINHPBGL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5752700", Offset = "0x5750F00", VA = "0x185752700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5752E60", Offset = "0x5751660", VA = "0x185752E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KECCEIDEJBE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FEE40", Offset = "0x80FD640", VA = "0x1880FEE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80FF630", Offset = "0x80FDE30", VA = "0x1880FF630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ABOANDEDILE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F8220", Offset = "0x80F6A20", VA = "0x1880F8220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x80F8760", Offset = "0x80F6F60", VA = "0x1880F8760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IDPPLFAJCPN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E6AB40", Offset = "0x4E69340", VA = "0x184E6AB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4C8C010", Offset = "0x4C8A810", VA = "0x184C8C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PMCJEAJLGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<KCHLBHAFJKA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PMCJEAJLGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8104C60", Offset = "0x8103460", VA = "0x188104C60")]
		internal void HOBJEIAODGG(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IMLEOCFCFKI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E90B20", Offset = "0x4E8F320", VA = "0x184E90B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4238A50", Offset = "0x4237250", VA = "0x184238A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DHPOBHNBLEK<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6D07280", Offset = "0x6D05A80", VA = "0x186D07280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4237A90", Offset = "0x4236290", VA = "0x184237A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MDLLFMNINCE<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x552F9E0", Offset = "0x552E1E0", VA = "0x18552F9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5530240", Offset = "0x552EA40", VA = "0x185530240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OOJPKNPBPME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8104A20", Offset = "0x8103220", VA = "0x188104A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8104C00", Offset = "0x8103400", VA = "0x188104C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BPJKHKMCCAK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F94D0", Offset = "0x80F7CD0", VA = "0x1880F94D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x80F9830", Offset = "0x80F8030", VA = "0x1880F9830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KFNEDODOFJB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FF690", Offset = "0x80FDE90", VA = "0x1880FF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x80FF980", Offset = "0x80FE180", VA = "0x1880FF980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MAJFLOGABPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public MAJFLOGABPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8101230", Offset = "0x80FFA30", VA = "0x188101230")]
		internal Task CECNEEIMOAE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NOHNMDDNPML : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8104440", Offset = "0x8102C40", VA = "0x188104440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x81046A0", Offset = "0x8102EA0", VA = "0x1881046A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct AOOOFNNGGID : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F8E90", Offset = "0x80F7690", VA = "0x1880F8E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80F9070", Offset = "0x80F7870", VA = "0x1880F9070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct HJPBJJNLLHO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FDCF0", Offset = "0x80FC4F0", VA = "0x1880FDCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x80FE050", Offset = "0x80FC850", VA = "0x1880FE050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GHCLGMMMGIN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FCCD0", Offset = "0x80FB4D0", VA = "0x1880FCCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x80FCFC0", Offset = "0x80FB7C0", VA = "0x1880FCFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BHHLPFHHOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BHHLPFHHOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x80F91E0", Offset = "0x80F79E0", VA = "0x1880F91E0")]
		internal Task LPHOIJBJDBC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct IDJGMHMODGP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FEAF0", Offset = "0x80FD2F0", VA = "0x1880FEAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x80FED50", Offset = "0x80FD550", VA = "0x1880FED50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct ANKMPDBOKLO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80F8CB0", Offset = "0x80F74B0", VA = "0x1880F8CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E30", Offset = "0x80F7630", VA = "0x1880F8E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct MKGINLPLFGO<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5547200", Offset = "0x5545A00", VA = "0x185547200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5547700", Offset = "0x5545F00", VA = "0x185547700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MIAJFBLLGDO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8103E60", Offset = "0x8102660", VA = "0x188103E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8104190", Offset = "0x8102990", VA = "0x188104190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? INFALCKLAPF;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<KCHLBHAFJKA> MLGKFGENFPG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task GBGMAODJHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8103700", Offset = "0x8101F00", VA = "0x188103700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8102EA0", Offset = "0x81016A0", VA = "0x188102EA0")]
	public static bool LEIFIHKDHBC(this Task FEGBHCAEMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0A70", Offset = "0x3ABF270", VA = "0x183AC0A70")]
	public static Task<T> EHLFDKCLFIM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8102C50", Offset = "0x8101450", VA = "0x188102C50")]
	public static Task LDPICKOKMJK(this Task FEGBHCAEMDO, CancellationToken KAJENDFCCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4350", Offset = "0x3AC2B50", VA = "0x183AC4350")]
	public static Task<TResult> LDPICKOKMJK<TResult>(this Task<TResult> FEGBHCAEMDO, CancellationToken KAJENDFCCBJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4660", Offset = "0x3AC2E60", VA = "0x183AC4660")]
	public static TaskCompletionSource<TResult> LDPICKOKMJK<TResult>(this TaskCompletionSource<TResult> LCCIIFAAPIC, CancellationToken KAJENDFCCBJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8102140", Offset = "0x8100940", VA = "0x188102140")]
	public static IDisposable? GJAMMPMCLNB(CancellationToken OEGPJMNNHFA, CancellationToken JKNJEAFPHOM, [Out] CancellationToken KOOEMMBFGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8103650", Offset = "0x8101E50", VA = "0x188103650")]
	[AsyncStateMachine(typeof(CDNPCPLOOGA))]
	public static void LJDGKGPPGBD(this Task ODKLOJBBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8102B50", Offset = "0x8101350", VA = "0x188102B50")]
	[AsyncStateMachine(typeof(MCEGMLLGMJI))]
	public static void JFEPHGCKAAG(this Task ODKLOJBBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1480", Offset = "0x3ABFC80", VA = "0x183AC1480")]
	[AsyncStateMachine(typeof(JJJAMJOBJFJ<>))]
	public static Task JBIIKLJIDEC<TException>(this Task ODKLOJBBLOI) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AC65E0", Offset = "0x3AC4DE0", VA = "0x183AC65E0")]
	[AsyncStateMachine(typeof(GELIMONBBOJ<>))]
	public static Task<T> LGONEDHKCJE<T>(this Task<T> DKBBJFIDEGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x81037F0", Offset = "0x8101FF0", VA = "0x1881037F0")]
	[AsyncStateMachine(typeof(BIOHGIBNLEO))]
	public static Task<TaskStatus> NNEKMJNMIJK(this Task? DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AC67C0", Offset = "0x3AC4FC0", VA = "0x183AC67C0")]
	public static (Task<T?>?, Action<T?>?) OKGALJPLABP<T>([Optional] CancellationToken GMEAHOBHMAD)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6A40", Offset = "0x3AC5240", VA = "0x183AC6A40")]
	[AsyncStateMachine(typeof(ONBJKFHNONK<, >))]
	public static Task<List<TResult>> OMDFAPDHBDA<TResult, TInput>(this Task<List<TInput>> FEGBHCAEMDO, DHMLINHPBGL<TInput, TResult> NCBLPKBFNPF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81039B0", Offset = "0x81021B0", VA = "0x1881039B0")]
	[AsyncStateMachine(typeof(KECCEIDEJBE))]
	public static Task PBIBFMFOMCJ(Task ODKLOJBBLOI, CancellationToken DGACCOBPOIM, Func<CancellationToken, Task> BDMCMOBBHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x81022D0", Offset = "0x8100AD0", VA = "0x1881022D0")]
	[AsyncStateMachine(typeof(ABOANDEDILE))]
	public static Task HHGMCHMOBOG(Func<CancellationToken, Task> IPHFGIAOPLC, TimeSpan MDFBIFEKOPH, [Optional] CancellationToken DGACCOBPOIM, [Optional] Action<OperationCanceledException>? OEGOFGBCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AC11E0", Offset = "0x3ABF9E0", VA = "0x183AC11E0")]
	[AsyncStateMachine(typeof(IDPPLFAJCPN<>))]
	public static Task<T> HHGMCHMOBOG<T>(Func<CancellationToken, Task<T>> IPHFGIAOPLC, TimeSpan MDFBIFEKOPH, [Optional] CancellationToken DGACCOBPOIM, [Optional] Func<OperationCanceledException, T>? OEGOFGBCOII) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8103600", Offset = "0x8101E00", VA = "0x188103600")]
	public static Task LGBNAMICCPI(params Task[] EEPLNEMBFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8103140", Offset = "0x8101940", VA = "0x188103140")]
	public static Task LGBNAMICCPI(IEnumerable<Task> EEPLNEMBFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AC1640", Offset = "0x3ABFE40", VA = "0x183AC1640")]
	[AsyncStateMachine(typeof(IMLEOCFCFKI<>))]
	public static Task<IEnumerable<Task<T>>> KCMHIDCMCDC<T>(IEnumerable<Task<T>> EEPLNEMBFJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3AC10B0", Offset = "0x3ABF8B0", VA = "0x183AC10B0")]
	[AsyncStateMachine(typeof(DHPOBHNBLEK<, , >))]
	public static Task<(T1, T2, T3)> GICAJJAOIBI<T1, T2, T3>(Task<T1> JGBGAHKKEJK, Task<T2> GJDAGBAOIFO, Task<T3> PKDNGNGIFEL) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0DD0", Offset = "0x3ABF5D0", VA = "0x183AC0DD0")]
	[AsyncStateMachine(typeof(MDLLFMNINCE<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> GICAJJAOIBI<T1, T2, T3, T4, T5>(Task<T1> JGBGAHKKEJK, Task<T2> GJDAGBAOIFO, Task<T3> PKDNGNGIFEL, Task<T4> DEKFLKMFIOA, Task<T5> OGLJJGKADIL) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8101F40", Offset = "0x8100740", VA = "0x188101F40")]
	[AsyncStateMachine(typeof(OOJPKNPBPME))]
	public static Task FMFDEDLMFDC(Func<bool> FLPNFIDBDHL, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8101E30", Offset = "0x8100630", VA = "0x188101E30")]
	[AsyncStateMachine(typeof(BPJKHKMCCAK))]
	public static Task FMFDEDLMFDC(Func<bool> FLPNFIDBDHL, TimeSpan JFCKGPJOACN, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8102760", Offset = "0x8100F60", VA = "0x188102760")]
	[AsyncStateMachine(typeof(KFNEDODOFJB))]
	public static Task JDDNEGEOPOI(Func<bool> FLPNFIDBDHL, TimeSpan MDFBIFEKOPH, [Optional] CancellationToken GMEAHOBHMAD, [Optional] Action<OperationCanceledException>? OEGOFGBCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8102890", Offset = "0x8101090", VA = "0x188102890")]
	[AsyncStateMachine(typeof(NOHNMDDNPML))]
	public static Task JDDNEGEOPOI(Func<bool> FLPNFIDBDHL, TimeSpan MDFBIFEKOPH, TimeSpan JFCKGPJOACN, [Optional] CancellationToken GMEAHOBHMAD, [Optional] Action<OperationCanceledException>? OEGOFGBCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8103BF0", Offset = "0x81023F0", VA = "0x188103BF0")]
	[AsyncStateMachine(typeof(AOOOFNNGGID))]
	public static Task PNNECMGCLGE(Func<bool> FLPNFIDBDHL, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8103AE0", Offset = "0x81022E0", VA = "0x188103AE0")]
	[AsyncStateMachine(typeof(HJPBJJNLLHO))]
	public static Task PNNECMGCLGE(Func<bool> FLPNFIDBDHL, TimeSpan JFCKGPJOACN, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8103010", Offset = "0x8101810", VA = "0x188103010")]
	[AsyncStateMachine(typeof(GHCLGMMMGIN))]
	public static Task LENBNKLLCGC(Func<bool> FLPNFIDBDHL, TimeSpan MDFBIFEKOPH, [Optional] CancellationToken GMEAHOBHMAD, [Optional] Action<OperationCanceledException>? OEGOFGBCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8102ED0", Offset = "0x81016D0", VA = "0x188102ED0")]
	[AsyncStateMachine(typeof(IDJGMHMODGP))]
	public static Task LENBNKLLCGC(Func<bool> FLPNFIDBDHL, TimeSpan MDFBIFEKOPH, TimeSpan JFCKGPJOACN, [Optional] CancellationToken GMEAHOBHMAD, [Optional] Action<OperationCanceledException>? OEGOFGBCOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8101C70", Offset = "0x8100470", VA = "0x188101C70")]
	[AsyncStateMachine(typeof(ANKMPDBOKLO))]
	[Obsolete]
	public static Task EKGMOHJNLJL(this Task FEGBHCAEMDO, Action PNGLGFBDDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AC0BF0", Offset = "0x3ABF3F0", VA = "0x183AC0BF0")]
	[AsyncStateMachine(typeof(MKGINLPLFGO<>))]
	[Obsolete]
	public static Task EKGMOHJNLJL<T>(this Task<T> FEGBHCAEMDO, Action<T> PNGLGFBDDKI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8101B70", Offset = "0x8100370", VA = "0x188101B70")]
	private static void BAACCHENNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8102400", Offset = "0x8100C00", VA = "0x188102400")]
	public static bool HKGIHLIMIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x81029D0", Offset = "0x81011D0", VA = "0x1881029D0")]
	private static void JDMLELNIGED(SynchronizationContext MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8102030", Offset = "0x8100830", VA = "0x188102030")]
	private static void GDLKNAFNPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x81038E0", Offset = "0x81020E0", VA = "0x1881038E0")]
	public static void OHFDMEEHJBL([Optional] string? ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8103770", Offset = "0x8101F70", VA = "0x188103770")]
	public static void MLNIJFPFKDN([Optional] string? ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8102C00", Offset = "0x8101400", VA = "0x188102C00")]
	public static DCGIPGPMHOC KPLCHCMKDDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8101C20", Offset = "0x8100420", VA = "0x188101C20")]
	public static DCGIPGPMHOC BHMAJLEGPLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8101D60", Offset = "0x8100560", VA = "0x188101D60")]
	[AsyncStateMachine(typeof(MIAJFBLLGDO))]
	public static Task ELLFBNMGNKK(Func<Task> OHENIKPHLCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DIADIMJDNBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public DIADIMJDNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CJADJCIELKJ
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x80F9B90", Offset = "0x80F8390", VA = "0x1880F9B90")]
	public static bool KJKCIEOBFFB(this MGDGHCBONGK OGDNPJIHHKE, DateTime KOHPNOMDAON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x80F9A70", Offset = "0x80F8270", VA = "0x1880F9A70")]
	public static TimeSpan IMNGFGGCINF(this MGDGHCBONGK OGDNPJIHHKE, DateTime KOHPNOMDAON)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class BCKOEDMLMLE : MGDGHCBONGK
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly MGDGHCBONGK HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime INGIAOJNKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x80F90D0", Offset = "0x80F78D0", VA = "0x1880F90D0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset PACPBCDMIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x80F9110", Offset = "0x80F7910", VA = "0x1880F9110", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BCKOEDMLMLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface MGDGHCBONGK
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime INGIAOJNKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset PACPBCDMIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DFIFIEBNLKP
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long DPGPOECAIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x80F9E90", Offset = "0x80F8690", VA = "0x1880F9E90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long EOPLIBMAPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x80F9F80", Offset = "0x80F8780", VA = "0x1880F9F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double NEEBMJHCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x80F9E30", Offset = "0x80F8630", VA = "0x1880F9E30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double FOFJMOIJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x80F9FD0", Offset = "0x80F87D0", VA = "0x1880F9FD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double BKLDKHOBPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x80F9F30", Offset = "0x80F8730", VA = "0x1880F9F30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double HCDLANFDBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x80F9EE0", Offset = "0x80F86E0", VA = "0x1880F9EE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x80FA210", Offset = "0x80F8A10", VA = "0x1880FA210")]
	public static double LDEPOLCDDBG(long JMDFBHFDDAG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x80FA300", Offset = "0x80F8B00", VA = "0x1880FA300")]
	public static double PNOHMFGCPOC(long JMDFBHFDDAG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x80FA020", Offset = "0x80F8820", VA = "0x1880FA020")]
	public static double JEJOKKFBLCK(double BGDLHBIDHEH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x80FA180", Offset = "0x80F8980", VA = "0x1880FA180")]
	public static long LAMKOKDJHBP(long AFBFHAPCPPE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x80F9E80", Offset = "0x80F8680", VA = "0x1880F9E80")]
	public static long CEOEKPCBGJE(long NAMNFADMNED, long PNLFLFILNED)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x80FA0B0", Offset = "0x80F88B0", VA = "0x1880FA0B0")]
	public static double JJPKAOKNGBC(long NAMNFADMNED, long PNLFLFILNED)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x80FA2A0", Offset = "0x80F8AA0", VA = "0x1880FA2A0")]
	public static double OCLHKLANECP(long NAMNFADMNED, long PNLFLFILNED)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class FBPILHHLEEP : OJDGAKBEPBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan GDIHJHOHEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer PFLKFIDCFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan MDFBIFEKOPH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan AGAPPNLAEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x80FB670", Offset = "0x80F9E70", VA = "0x1880FB670", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? DONLEIANCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x80FBA90", Offset = "0x80FA290", VA = "0x1880FBA90")]
	[Preserve]
	public FBPILHHLEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x80FB840", Offset = "0x80FA040", VA = "0x1880FB840")]
	public FBPILHHLEEP(TimeSpan MDFBIFEKOPH, [Optional] Action? HNLEIJENJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x80FB5B0", Offset = "0x80F9DB0", VA = "0x1880FB5B0", Slot = "7")]
	public void IDHAAILNKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x80FB410", Offset = "0x80F9C10", VA = "0x1880FB410", Slot = "8")]
	public void CLABHHHGFFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x80FB640", Offset = "0x80F9E40", VA = "0x1880FB640", Slot = "9")]
	public void IKPCEGHDCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x119A3C0", Offset = "0x1198BC0", VA = "0x18119A3C0")]
	private void OGANNICMAFP(object FOIMOKIBLGB, ElapsedEventArgs IDEKDJFHEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x80FB520", Offset = "0x80F9D20", VA = "0x1880FB520")]
	private static void FOFHLACCOCK(TimeSpan LJJKKCACMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x80FB480", Offset = "0x80F9C80", VA = "0x1880FB480", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MGEKLMJLNJO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? DBKNDJMEDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string HBNKCFMFJNO;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x17A75D0", Offset = "0x17A5DD0", VA = "0x1817A75D0")]
	public MGEKLMJLNJO(string LLAMBGFCPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4F3E8B0", Offset = "0x4F3D0B0", VA = "0x184F3E8B0")]
	public MGEKLMJLNJO(string JIDPAGEBNDJ, string LLAMBGFCPPC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KGJKGFJIMIK : IEquatable<KGJKGFJIMIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint HMDEKFBFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int HOAGAOIFDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float GOAENBEMHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort MPKAAIIDBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort LBCKHDODFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short ABPHPKAAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short FANDCIJEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char HKHOFGHBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char AHJNGFDHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte ODFGJNIBGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte ACHICMCLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte HAFFLOKDFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte APNFJFHLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool JNAHCGDCEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool LIMEDKLBMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool DAIOFOLFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool BDMOHPOHPJE;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F60400", Offset = "0x1F5EC00", VA = "0x181F60400")]
	public static KGJKGFJIMIK AAJOKHNPFGK(uint MIMOIGGABKJ)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1F60400", Offset = "0x1F5EC00", VA = "0x181F60400")]
	public static KGJKGFJIMIK HOABOOBDDDF(int HBFEGOPOJLP)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x80FF9E0", Offset = "0x80FE1E0", VA = "0x1880FF9E0")]
	public static KGJKGFJIMIK DPNJBIFOCCD(float EJHLNCLKEJH)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x80FFA70", Offset = "0x80FE270", VA = "0x1880FFA70")]
	public static KGJKGFJIMIK IKEMBMFKPED(byte KLONEKKLLFD, byte BAOJIKGICIL, byte PBAJKFBBJBB, byte ELPCKBHPCLA)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x80FFA70", Offset = "0x80FE270", VA = "0x1880FFA70")]
	public static KGJKGFJIMIK IPEMGFKOPLI(bool OAFGBNEPKDD, bool HIHPLNOPMOF, bool ACMENOLDKBB, bool BOFILCHDFKA)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x80FFA70", Offset = "0x80FE270", VA = "0x1880FFA70")]
	public static KGJKGFJIMIK IGFKGMBJOMO(byte KFGBGAJHKOK, byte IMANCDPCECF, byte FGDIGJHKBNA, byte PPACLPAEGGD)
	{
		return default(KGJKGFJIMIK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22673E0", Offset = "0x2265BE0", VA = "0x1822673E0")]
	public static bool NALNDDPCEFD(KGJKGFJIMIK NOGJAHKGFJD, KGJKGFJIMIK LHMEHOJLNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x22673C0", Offset = "0x2265BC0", VA = "0x1822673C0", Slot = "4")]
	public bool Equals(KGJKGFJIMIK KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x80FF9F0", Offset = "0x80FE1F0", VA = "0x1880FF9F0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x13D3B00", Offset = "0x13D2300", VA = "0x1813D3B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x80FFA90", Offset = "0x80FE290", VA = "0x1880FFA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CEAKJMKNJCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong BOIHCALDEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long IBPFPPIBNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double NOKMLECIILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint NLAKCAKLJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint APICNKMONCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int MFNNDOMFLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int HHBIMHEIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float INGOIKOOHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float NGGMKGNKJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort MPKAAIIDBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort LBCKHDODFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort NKBHPEGGLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort NJMLPEBLFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short ABPHPKAAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short FANDCIJEBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short KICLGMCBANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short ELLCKLHKIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char HKHOFGHBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char AHJNGFDHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char LMNBKEKOLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char PPHCCEDMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte ODFGJNIBGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte ACHICMCLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte HAFFLOKDFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte APNFJFHLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte OOBKEFJBAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte HOEONMJKPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte KJPNDFLHCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte LIPGGABMDNJ;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static CEAKJMKNJCP CCPKJDCALBG(long JEALBNJOKEE)
	{
		return default(CEAKJMKNJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x80F9A20", Offset = "0x80F8220", VA = "0x1880F9A20")]
	public static CEAKJMKNJCP CCPKJDCALBG(byte KLONEKKLLFD, byte BAOJIKGICIL, byte PBAJKFBBJBB, byte ELPCKBHPCLA, byte ABEGKKCCPIB, byte PGBANFOICLI, byte DGDOCKCOFDL, byte LBENFGFKPPN)
	{
		return default(CEAKJMKNJCP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KHFHGMFPBJA : IEquatable<KHFHGMFPBJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte GKKOIJGMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool LHNOFCGIANP;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2F57C90", Offset = "0x2F56490", VA = "0x182F57C90")]
	public static KHFHGMFPBJA IKEMBMFKPED(byte BILENGGOMGJ)
	{
		return default(KHFHGMFPBJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2F57C90", Offset = "0x2F56490", VA = "0x182F57C90")]
	public static KHFHGMFPBJA IPEMGFKOPLI(bool KMMMFDJAJEJ)
	{
		return default(KHFHGMFPBJA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8100920", Offset = "0x80FF120", VA = "0x188100920")]
	public static bool NALNDDPCEFD(KHFHGMFPBJA NOGJAHKGFJD, KHFHGMFPBJA LHMEHOJLNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x703F320", Offset = "0x703DB20", VA = "0x18703F320", Slot = "4")]
	public bool Equals(KHFHGMFPBJA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8100880", Offset = "0x80FF080", VA = "0x188100880", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8100910", Offset = "0x80FF110", VA = "0x188100910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8100930", Offset = "0x80FF130", VA = "0x188100930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class BLMOJPMIGDC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T LLEPJBOPAKE;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x617AEA0", Offset = "0x61796A0", VA = "0x18617AEA0")]
	public BLMOJPMIGDC(T MOJKEOOGEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class ADLMDEPGION
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x383ED10", Offset = "0x383D510", VA = "0x18383ED10")]
	public static IEnumerable<T> KBODLGEOAEO<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static T[] OMMLEHHMPLM<T>(params T[] CPNMCIOBBGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static IEnumerable<T> BENNFAMHLHE<T>(params T[] CPNMCIOBBGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static HashSet<T> CIDMENCFEEF<T>(params T[] CPNMCIOBBGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x41E3200", Offset = "0x41E1A00", VA = "0x1841E3200")]
	public static KeyValuePair<TKey, TValue> EDBHEEGFNMJ<TKey, TValue>([In] TKey MNMCNOJCKAF, [In] TValue MGONBEDEDON) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3845120", Offset = "0x3843920", VA = "0x183845120")]
	public static List<T> CEJPIDIOEDM<T>(IEnumerable<T> DBAICDFECAB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KCCMCCPCOEL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string FOIIGHFNEEN;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
	public KCCMCCPCOEL(string OOGMCHHLIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object MPNAIFINAJL<T>([In] T JALDLFHONHH);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object MHICAAGOHOI<T>(T JALDLFHONHH);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KDNEKMCOECK]
public delegate string HMMOLFPKGBL(string FIBFJHPJKOF, string? EKCIHMCINHA, bool OMOKJLGFEIA);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[KDNEKMCOECK]
public delegate void DEMBKMKGDNH(string ILBALOOKKCP);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[KDNEKMCOECK]
public delegate void FHDPMINOCMH(Exception FKONJEEEEJA);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object LCEDLBJLHMD();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KDNEKMCOECK]
public delegate bool IDJFPLFCNBI();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[KDNEKMCOECK]
public delegate string NKBBEILDJFM(object HPLLAPMNIJF);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class NFAGDBMJFGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	public NFAGDBMJFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class MCKGONIDKBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct EEOCCDGJBHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x80FAA00", Offset = "0x80F9200", VA = "0x1880FAA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x80FB2E0", Offset = "0x80F9AE0", VA = "0x1880FB2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback BLDGMECJNIE;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> CFHDHJDHHHA;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8101440", Offset = "0x80FFC40", VA = "0x188101440")]
	public static Task<bool> CFKKJHCFJBD(int IFNDCCHDJIC, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x81017D0", Offset = "0x80FFFD0", VA = "0x1881017D0")]
	[AsyncStateMachine(typeof(EEOCCDGJBHE))]
	private static Task<bool> FJGOCJFPGFK(int IFNDCCHDJIC, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x81013B0", Offset = "0x80FFBB0", VA = "0x1881013B0")]
	private static void CBBPDOHMFNI(object? OJGLGPLNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8101740", Offset = "0x80FFF40", VA = "0x188101740")]
	private static void DCBPIFLMOFJ(object? OJGLGPLNKGO)
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
