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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C1BE10", Offset = "0x7C1B210", VA = "0x187C1BE10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LJHDIHCJILI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A210", Offset = "0x7C19610", VA = "0x187C1A210")]
	public static string CJAGICHEPKP(this Encoding EOINBKEEGBC, [In] ReadOnlySequence<byte> FLIFCMNPFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x379AF80", Offset = "0x379A380", VA = "0x18379AF80")]
	private static void BMIDGDALAGA<T>(this ReadOnlySequence<T> JEMDCGMNCGI, [Out] ReadOnlySpan<T> EGHECAEHOPL, [Out] SequencePosition JOAJJJIEKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GFOAIDJAOGE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C17A00", Offset = "0x7C16E00", VA = "0x187C17A00")]
	public GFOAIDJAOGE(bool DMOOEKNHEHG, string GFGHPCDCAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C179B0", Offset = "0x7C16DB0", VA = "0x187C179B0")]
	public GFOAIDJAOGE(bool DMOOEKNHEHG, params string[] MLLDLNJPJDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LKDKEAMHHND
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OFJFKFHPBMA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OEPKNPKAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGPBPLEBOML(string IICGAABOENK, double OOEMJLHLIHJ, [Optional] string? LKKMFOACBCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DKHAFMJPPMO : AFHLBJDEAEJ, KIMGPCEMKIM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HNBMALMAEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> GDEFGKKGJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double JLCBKIPFKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double CBHAMKJGEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double LNCLNNJFMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AJNMPKFOAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double OIECJIHIONF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HFADJPCKEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9E8570", Offset = "0x9E7970", VA = "0x1809E8570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double JDNIOAMLCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C14470", Offset = "0x7C13870", VA = "0x187C14470", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LKNPCGIHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5484E20", Offset = "0x5484220", VA = "0x185484E20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double FLGIKOJBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2698FC0", Offset = "0x26983C0", VA = "0x182698FC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C14540", Offset = "0x7C13940", VA = "0x187C14540")]
	public DKHAFMJPPMO(int HGBCMKNCLOE, double OIECJIHIONF = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C14340", Offset = "0x7C13740", VA = "0x187C14340", Slot = "7")]
	public void EMMHELMDNJA(double DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C144D0", Offset = "0x7C138D0", VA = "0x187C144D0", Slot = "8")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C14240", Offset = "0x7C13640", VA = "0x187C14240", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IGNIDMAOHIG : AFHLBJDEAEJ, KIMGPCEMKIM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long PCGLBCNIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double BDLPEPEJALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double DODMPMGPJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BGAKLMPCCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double PCAEOFICPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double JLCBKIPFKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double CBHAMKJGEOB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LKNPCGIHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFD10", Offset = "0x6EDF110", VA = "0x186EDFD10", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double FLGIKOJBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EDFD20", Offset = "0x6EDF120", VA = "0x186EDFD20", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MFOMKPBEFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0190", Offset = "0x6EDF590", VA = "0x186EE0190")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JDNIOAMLCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4F850", Offset = "0x2D4EC50", VA = "0x182D4F850", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C18970", Offset = "0x7C17D70", VA = "0x187C18970", Slot = "10")]
	public virtual void EMMHELMDNJA(double DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C18A90", Offset = "0x7C17E90", VA = "0x187C18A90", Slot = "11")]
	public virtual void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C18900", Offset = "0x7C17D00", VA = "0x187C18900", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C18AD0", Offset = "0x7C17ED0", VA = "0x187C18AD0")]
	public IGNIDMAOHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LPEPCMHDDOA : IGNIDMAOHIG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double BDCAJCMIFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE0170", Offset = "0x6EDF570", VA = "0x186EE0170")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EE01D0", Offset = "0x6EDF5D0", VA = "0x186EE01D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A7E0", Offset = "0x7C19BE0", VA = "0x187C1A7E0", Slot = "10")]
	public override void EMMHELMDNJA(double DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A910", Offset = "0x7C19D10", VA = "0x187C1A910", Slot = "11")]
	public override void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C18AD0", Offset = "0x7C17ED0", VA = "0x187C18AD0")]
	public LPEPCMHDDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AFHLBJDEAEJ : KIMGPCEMKIM, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double JDNIOAMLCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LKNPCGIHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double FLGIKOJBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FCEPGIONMII : KIMGPCEMKIM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double DNJPBGKNCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double PMIHODBGKBE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C14820", Offset = "0x7C13C20", VA = "0x187C14820")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B73AA0", Offset = "0x7B72EA0", VA = "0x187B73AA0", Slot = "4")]
	public void EMMHELMDNJA(double DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C14880", Offset = "0x7C13C80", VA = "0x187C14880", Slot = "5")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C14830", Offset = "0x7C13C30", VA = "0x187C14830", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FCEPGIONMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KIMGPCEMKIM : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMMHELMDNJA(double DBALGCNBEDK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICMDEPLACPK();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KKJHIABPACJ : KIMGPCEMKIM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OOEMJLHLIHJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4424600", Offset = "0x4423A00", VA = "0x184424600")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5147080", Offset = "0x5146480", VA = "0x185147080", Slot = "4")]
	public void EMMHELMDNJA(double DBALGCNBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A200", Offset = "0x7C19600", VA = "0x187C1A200", Slot = "5")]
	public void ICMDEPLACPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A1B0", Offset = "0x7C195B0", VA = "0x187C1A1B0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KKJHIABPACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GGBNLOBKPEA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> LHHIMPBLILE(CancellationToken JDDHIJBJNHP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PHFGANNAIBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GGBNLOBKPEA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LHHIMPBLILE taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x549C110", Offset = "0x549B510", VA = "0x18549C110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x549D250", Offset = "0x549C650", VA = "0x18549D250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource LOIPKDKGEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? KIIDKBJJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? OEHOCLLIDND;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48B97C0", Offset = "0x48B8BC0", VA = "0x1848B97C0")]
	[AsyncStateMachine(typeof(GGBNLOBKPEA<>.PHFGANNAIBG))]
	public Task<TResult> FAEHEMDGLJJ(LHHIMPBLILE PLGCEKMMKAA, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x48B9750", Offset = "0x48B8B50", VA = "0x1848B9750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48B9910", Offset = "0x48B8D10", VA = "0x1848B9910")]
	public GGBNLOBKPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DLCAOLEBGCL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> DBHEFDELEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T APFNDOMNAPN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4A534E0", Offset = "0x4A528E0", VA = "0x184A534E0")]
	public DLCAOLEBGCL([In] T OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68ECBB0", Offset = "0x68EBFB0", VA = "0x1868ECBB0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68ECF40", Offset = "0x68EC340", VA = "0x1868ECF40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68ED340", Offset = "0x68EC740", VA = "0x1868ED340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IIOCICBKFHO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static DLCAOLEBGCL<T> FABCCGGAHMJ<T>([In] T OOEMJLHLIHJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HHFIKIMIDBG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C188D0", Offset = "0x7C17CD0", VA = "0x187C188D0")]
	public static void CIFLPHAKEHJ(this CancellationTokenSource LOIPKDKGEPO, bool FBJBFLKIIKH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class PENHBMFEGIF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public PENHBMFEGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class KGMEPOOFPPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public KGMEPOOFPPN(string LGDAGHMLJFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GLNJMEBOLKH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x36C4BE0", Offset = "0x36C3FE0", VA = "0x1836C4BE0")]
	public static NCHPFIPPILF EJDGODNKIAD<T>()
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36C4E60", Offset = "0x36C4260", VA = "0x1836C4E60")]
	public static NCHPFIPPILF GJHJPDJPIPE<T>([CallerMemberName] string KCCMEIDBNGP = "") where T : notnull
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x36C4B60", Offset = "0x36C3F60", VA = "0x1836C4B60")]
	public static NCHPFIPPILF EJDGODNKIAD<T>(this T PLCJAHDMBHK) where T : notnull
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36C4F00", Offset = "0x36C4300", VA = "0x1836C4F00")]
	public static NCHPFIPPILF NEMDBPNBAHB<T>(this T PLCJAHDMBHK, [CallerMemberName] string KCCMEIDBNGP = "") where T : notnull
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x36C4DB0", Offset = "0x36C41B0", VA = "0x1836C4DB0")]
	public static NCHPFIPPILF GJHJPDJPIPE<T>(this T KBBJDOAJMAF, [CallerMemberName] string KCCMEIDBNGP = "") where T : notnull
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C18280", Offset = "0x7C17680", VA = "0x187C18280")]
	public static NCHPFIPPILF GJHJPDJPIPE(string EEMIGMKBBHH, [CallerMemberName] string KCCMEIDBNGP = "")
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C18300", Offset = "0x7C17700", VA = "0x187C18300")]
	public static string JKOCGHPBEOG(this object KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool FMOLPPJBGDM();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[PENHBMFEGIF]
public delegate long JBGJEHHJEIJ();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FOFOBJECFDO
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static KDDCCCDEIHN FFOLBIPNIKC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static KDDCCCDEIHN DNMMFCDJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C14EC0", Offset = "0x7C142C0", VA = "0x187C14EC0")]
		get
		{
			return default(KDDCCCDEIHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static PFJPNDJBJHP AEIFPHDDGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C15120", Offset = "0x7C14520", VA = "0x187C15120")]
		get
		{
			return default(PFJPNDJBJHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KCDBMGEGNCI JPMHECCIMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C150D0", Offset = "0x7C144D0", VA = "0x187C150D0")]
		get
		{
			return default(KCDBMGEGNCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool EKMHNNBFGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C14A80", Offset = "0x7C13E80", VA = "0x187C14A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C14D10", Offset = "0x7C14110", VA = "0x187C14D10")]
	public static void GLNMPHBEEFK([In] KDDCCCDEIHN PGDKDJCPLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C14AF0", Offset = "0x7C13EF0", VA = "0x187C14AF0")]
	public static void BKFDGJHNENK(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C14BC0", Offset = "0x7C13FC0", VA = "0x187C14BC0")]
	public static void DOIAIPJNOFC(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3694B40", Offset = "0x3693F40", VA = "0x183694B40")]
	public static void DOIAIPJNOFC<T>(T LICDMCPJILC, OCIDPAJJDNH<T> FGEBHLNNMNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C14F10", Offset = "0x7C14310", VA = "0x187C14F10")]
	public static void IOAGIOPLFGO(Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C14C90", Offset = "0x7C14090", VA = "0x187C14C90")]
	public static void FHGHPNLCKNF(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C15170", Offset = "0x7C14570", VA = "0x187C15170")]
	public static void MANJBKLNKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C15050", Offset = "0x7C14450", VA = "0x187C15050")]
	public static string JKOCGHPBEOG(object KLANNNFBLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C151E0", Offset = "0x7C145E0", VA = "0x187C151E0")]
	public static long MPNKDMKHCMA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C14FB0", Offset = "0x7C143B0", VA = "0x187C14FB0")]
	public static bool JGONPCIILBP(bool PJIKMBJAEFO, string FGEBHLNNMNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C15250", Offset = "0x7C14650", VA = "0x187C15250")]
	public static double PLPFEKPAKFG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct KDDCCCDEIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly PFJPNDJBJHP AEIFPHDDGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly KCDBMGEGNCI JPMHECCIMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly BLPHKHGIGMD IAIHBLPBHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly JBGJEHHJEIJ CLPPPPEBBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly EEMINLEIJNM BKCIGALGLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly FMOLPPJBGDM FILKOFBODBG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BLPHKHGIGMD GBGCDGBKBBC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly JBGJEHHJEIJ DEPHDFAOEOP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EEMINLEIJNM BINBBLDGDPN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly FMOLPPJBGDM BANMKOAGJPG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KDDCCCDEIHN HGNIBOKIJFN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C19720", Offset = "0x7C18B20", VA = "0x187C19720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A100", Offset = "0x7C19500", VA = "0x187C1A100")]
	public KDDCCCDEIHN([In] PFJPNDJBJHP JGGEFLOJMIH, [In] KCDBMGEGNCI ANLNFKMMJPJ, BLPHKHGIGMD BEKDCKOAOMG, JBGJEHHJEIJ LLFFDKJHDNH, EEMINLEIJNM BHNCILEOMMO, FMOLPPJBGDM HLDHHFJKDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C198C0", Offset = "0x7C18CC0", VA = "0x187C198C0")]
	private static string LICFDFINGAD(object KLANNNFBLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	private static long NKIFIEEPMOJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	private static string PCAECLANGPA(string EMIHGGEGHBP, string? PBDLCAKDPOA, bool NLBFBPINCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	private static bool JMEGPKMDCMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C19900", Offset = "0x7C18D00", VA = "0x187C19900")]
	private static KDDCCCDEIHN NADNJGGGEGD()
	{
		return default(KDDCCCDEIHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GAAAHAAIDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PJEGIPECCEP OIMEOLNNAHI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface PJEGIPECCEP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LMGILDLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNLIAAFNHJE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MOCNKDDHAGL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJLDNMDKCFF([In] T DMMBOHMLHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void HCBAKOALNMB<T>([In] T LICDMCPJILC);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct AMEFOCCBCFL<T> : IEquatable<AMEFOCCBCFL<T>>, MOCNKDDHAGL<AMEFOCCBCFL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T APFNDOMNAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int PINFDPDNIJD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0690", Offset = "0x4BCFA90", VA = "0x184BD0690")]
	public AMEFOCCBCFL([In] T OOEMJLHLIHJ, int COPLIEINKOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF090", Offset = "0x4BCE490", VA = "0x184BCF090")]
	public static bool HGJBAFCOLON([In] AMEFOCCBCFL<T> BGDONNBGCJK, [In] AMEFOCCBCFL<T> DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x48C32D0", Offset = "0x48C26D0", VA = "0x1848C32D0", Slot = "4")]
	public bool Equals(AMEFOCCBCFL<T> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x438C360", Offset = "0x438B760", VA = "0x18438C360", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BCE890", Offset = "0x4BCDC90", VA = "0x184BCE890")]
	public bool DJLDNMDKCFF([In] AMEFOCCBCFL<T> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BCEE20", Offset = "0x4BCE220", VA = "0x184BCEE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0590", Offset = "0x4BCF990", VA = "0x184BD0590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF6E0", Offset = "0x4BCEAE0", VA = "0x184BCF6E0")]
	public void JGKNJHGPNLN([Out] T OOEMJLHLIHJ, [Out] int COPLIEINKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFC00", Offset = "0x4BCF000", VA = "0x184BCFC00")]
	public (T, int) MLEFDCBMJFG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4BCE9C0", Offset = "0x4BCDDC0", VA = "0x184BCE9C0", Slot = "5")]
	private bool GAFFDBBBEHJ([In] AMEFOCCBCFL<T> DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FCNJHCBNKIM
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3685690", Offset = "0x3684A90", VA = "0x183685690")]
	public static AMEFOCCBCFL<T> FABCCGGAHMJ<T>([In] T OOEMJLHLIHJ, int COPLIEINKOF) where T : notnull
	{
		return default(AMEFOCCBCFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JHBEKFKOJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3754440", Offset = "0x3753840", VA = "0x183754440")]
	public static bool DJLDNMDKCFF<T, U>([In] T KBBJDOAJMAF, [In] U KLANNNFBLNB) where T : notnull, MOCNKDDHAGL<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult KJBALHDJMLB<T, out TResult>([In] T LICDMCPJILC);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HPOMILBADKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan KNICEGDHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? EMOCMHJDIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOFHKCJPDLE();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJNNEIEGMAE();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPIGIAJPEDM();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct PFJPNDJBJHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly DJCGOIEODOM LAPPGEKEEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly JIIOACGPHJH FMAJCJAIMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DJCGOIEODOM HMDOGLONBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly JIIOACGPHJH HCBCFKOELEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DJCGOIEODOM JDIENJGLOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly JIIOACGPHJH MHGFANFCAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HPGAIPDFEEC EOHEFOPIMLO;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly DJCGOIEODOM IGMFJHDDJCL;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JIIOACGPHJH FHFCGNNOIMH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly DJCGOIEODOM CGILLFABPDJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly JIIOACGPHJH KFLLPODHMBK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly DJCGOIEODOM GIJFHEFDEKD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JIIOACGPHJH BCIGGGIAALD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly HPGAIPDFEEC DJPPANCAJMH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly PFJPNDJBJHP HGNIBOKIJFN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly DJCGOIEODOM GJGNPGPCDOC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D3E0", Offset = "0x7C1C7E0", VA = "0x187C1D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xD383A0", Offset = "0xD377A0", VA = "0x180D383A0")]
	public PFJPNDJBJHP(DJCGOIEODOM OPCDGFNNIGM, JIIOACGPHJH KJEJFLPMHIF, DJCGOIEODOM CJBFKJINFKB, JIIOACGPHJH HCELDNHOHKL, DJCGOIEODOM LDECFJJMEMH, JIIOACGPHJH HHDDLGGGAHL, HPGAIPDFEEC MADFEKMHKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	private static bool HFBBJMIMNCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void MHAPFHEFPGJ(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	private static bool LBKNHAIAOIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void KJIIJPPPJIO(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	private static bool HFMCHJOJPBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void DKNAFCEDMID(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void PPNADJEKFOC(Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D6B0", Offset = "0x7C1CAB0", VA = "0x187C1D6B0")]
	private static PFJPNDJBJHP NADNJGGGEGD()
	{
		return default(PFJPNDJBJHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0")]
	private static bool EOIAMLCMEEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D1B0", Offset = "0x7C1C5B0", VA = "0x187C1D1B0")]
	public void BKFDGJHNENK(object FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D220", Offset = "0x7C1C620", VA = "0x187C1D220")]
	public void CMGDECGMHCB(object FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D370", Offset = "0x7C1C770", VA = "0x187C1D370")]
	public void DOIAIPJNOFC(object FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD478F0", Offset = "0xD46CF0", VA = "0x180D478F0")]
	public void IOAGIOPLFGO(Exception CCEMNOMFFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D290", Offset = "0x7C1C690", VA = "0x187C1D290")]
	public void DOIAIPJNOFC(CHIJIIMENLD FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x38C0310", Offset = "0x38BF710", VA = "0x1838C0310")]
	public void DOIAIPJNOFC<T>(T LICDMCPJILC, OCIDPAJJDNH<T> FGEBHLNNMNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x38BFFD0", Offset = "0x38BF3D0", VA = "0x1838BFFD0")]
	public void BKFDGJHNENK<T>([In] T LICDMCPJILC, JHBNIACOHMK<T> FGEBHLNNMNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38C0170", Offset = "0x38BF570", VA = "0x1838C0170")]
	public void DOIAIPJNOFC<T>([In] T LICDMCPJILC, JHBNIACOHMK<T> FGEBHLNNMNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D5E0", Offset = "0x7C1C9E0", VA = "0x187C1D5E0")]
	public bool JGONPCIILBP(bool PJIKMBJAEFO, string FGEBHLNNMNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct NCHPFIPPILF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string APFNDOMNAPN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	public NCHPFIPPILF(string OOEMJLHLIHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20")]
	public static string HIHFKEJHDAH([In] NCHPFIPPILF KBBJDOAJMAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x221E5E0", Offset = "0x221D9E0", VA = "0x18221E5E0")]
	public static NCHPFIPPILF HIHFKEJHDAH(string DMMBOHMLHLF)
	{
		return default(NCHPFIPPILF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B620", Offset = "0x7C1AA20", VA = "0x187C1B620")]
	public string OBNOCAPMKHB(string JGMOKPMKBNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B540", Offset = "0x7C1A940", VA = "0x187C1B540")]
	public string JDFKMFBNFBJ(object EMPFLIOAEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class CEMIHDOEIAC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public CEMIHDOEIAC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct FGGPIMEAIEJ : IEquatable<FGGPIMEAIEJ>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "4")]
	public bool Equals(FGGPIMEAIEJ DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C14890", Offset = "0x7C13C90", VA = "0x187C14890", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C148E0", Offset = "0x7C13CE0", VA = "0x187C148E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C148F0", Offset = "0x7C13CF0", VA = "0x187C148F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CBPMGKHNHGF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JCEPLOKMLCO<T> : IEquatable<JCEPLOKMLCO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T APFNDOMNAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool KBGDLJGJJAK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EFHMHHIFLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C813F0", Offset = "0x4C807F0", VA = "0x184C813F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4C81D60", Offset = "0x4C81160", VA = "0x184C81D60")]
	public JCEPLOKMLCO([In] T OOEMJLHLIHJ, bool EGJPGEKFIPA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4C80E90", Offset = "0x4C80290", VA = "0x184C80E90")]
	public static bool HGJBAFCOLON([In] JCEPLOKMLCO<T> BGDONNBGCJK, [In] JCEPLOKMLCO<T> DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4C7FAA0", Offset = "0x4C7EEA0", VA = "0x184C7FAA0", Slot = "4")]
	public bool Equals(JCEPLOKMLCO<T> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4C7FC40", Offset = "0x4C7F040", VA = "0x184C7FC40", Slot = "0")]
	public override bool Equals(object? DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4C806F0", Offset = "0x4C7FAF0", VA = "0x184C806F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4C81820", Offset = "0x4C80C20", VA = "0x184C81820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PCBGPBOOHJM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38BD9C0", Offset = "0x38BCDC0", VA = "0x1838BD9C0")]
	public static JCEPLOKMLCO<T> MKHAGCPDNBD<T>([In] T OOEMJLHLIHJ) where T : notnull
	{
		return default(JCEPLOKMLCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x38BD760", Offset = "0x38BCB60", VA = "0x1838BD760")]
	public static JCEPLOKMLCO<T?> GDGMJIIHNOI<T>()
	{
		return default(JCEPLOKMLCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38BD4F0", Offset = "0x38BC8F0", VA = "0x1838BD4F0")]
	public static bool APIIMPKNJEH<T>([In] this JCEPLOKMLCO<T> OBJAJMOGNOI, [Out][NotNullWhen(true)] T OOEMJLHLIHJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x38BD480", Offset = "0x38BC880", VA = "0x1838BD480")]
	public static bool APIIMPKNJEH<T>([In] this JCEPLOKMLCO<T> OBJAJMOGNOI, [Out][NotNullWhen(true)] T OOEMJLHLIHJ, [Out] JCEPLOKMLCO<T> NJBEDFDFOPC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x38BD870", Offset = "0x38BCC70", VA = "0x1838BD870")]
	public static T? KNBALLGOOFP<T>([In] this JCEPLOKMLCO<T> OBJAJMOGNOI, T? JMBBJHIBCGJ)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x38BD520", Offset = "0x38BC920", VA = "0x1838BD520")]
	public static bool ELEEGCGJIDH<T>([In] this JCEPLOKMLCO<T> OBJAJMOGNOI, T OOEMJLHLIHJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NADLNDDJIPC
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38542A0", Offset = "0x38536A0", VA = "0x1838542A0")]
	public static T HEGDABPPEJO<T>([In] this JCEPLOKMLCO<T> OBJAJMOGNOI) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KCDBMGEGNCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr FHGHPNLCKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr MANJBKLNKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr MKIDMBHGFHE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr AHBDKLOFIDL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly KCDBMGEGNCI HGNIBOKIJFN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C19460", Offset = "0x7C18860", VA = "0x187C19460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	public KCDBMGEGNCI(IntPtr PJBPIDOEBOE, IntPtr HIHHEBBLKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void PKIMBMICEGG(string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void GPDMIEMOHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7C19540", Offset = "0x7C18940", VA = "0x187C19540")]
	private static KCDBMGEGNCI NADNJGGGEGD()
	{
		return default(KCDBMGEGNCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct FBODJODGIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr HOGOHIADEGE;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0")]
	private FBODJODGIMH(IntPtr HIHHEBBLKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C14710", Offset = "0x7C13B10", VA = "0x187C14710")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C14730", Offset = "0x7C13B30", VA = "0x187C14730")]
	public static FBODJODGIMH FABCCGGAHMJ(string KCCMEIDBNGP)
	{
		return default(FBODJODGIMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26FE6F0", Offset = "0x26FDAF0", VA = "0x1826FE6F0")]
	public static FBODJODGIMH FABCCGGAHMJ([In] KCDBMGEGNCI ANLNFKMMJPJ, string KCCMEIDBNGP)
	{
		return default(FBODJODGIMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x26FE8F0", Offset = "0x26FDCF0", VA = "0x1826FE8F0")]
	public static FBODJODGIMH FABCCGGAHMJ([In] KCDBMGEGNCI ANLNFKMMJPJ, Func<string> KCCMEIDBNGP)
	{
		return default(FBODJODGIMH);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GKOPOPLAEEN : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static bool? ELLIPGFCKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IntPtr LMBAIEDPOCJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool INPPFDKKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C17C40", Offset = "0x7C17040", VA = "0x187C17C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7C17DA0", Offset = "0x7C171A0", VA = "0x187C17DA0")]
	public static SHA256 BPKMLDCMEGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C17D30", Offset = "0x7C17130", VA = "0x187C17D30")]
	private static extern int BOOJPPKKGOH();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7C18120", Offset = "0x7C17520", VA = "0x187C18120")]
	private static extern IntPtr IGBCJBGCPKF();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C17E20", Offset = "0x7C17220", VA = "0x187C17E20")]
	private static extern void DMPNKCOBNEF(IntPtr LMBAIEDPOCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C17B80", Offset = "0x7C16F80", VA = "0x187C17B80")]
	private static extern void BBEANNJLHGG(IntPtr LMBAIEDPOCJ, byte[] AOFGGGKINCN, int IALPEJIGIPD, int HHIKEDPJEDC);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C17AE0", Offset = "0x7C16EE0", VA = "0x187C17AE0")]
	private static extern void ALEFGOHNOOD(IntPtr LMBAIEDPOCJ, byte[] OKGFJDGFKLF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C18250", Offset = "0x7C17650", VA = "0x187C18250")]
	private GKOPOPLAEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C17F30", Offset = "0x7C17330", VA = "0x187C17F30", Slot = "18")]
	protected override void HashCore(byte[] IMLJIFPAFGH, int PHHBOOPBEMN, int GGIPGHPJOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C17FF0", Offset = "0x7C173F0", VA = "0x187C17FF0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C18190", Offset = "0x7C17590", VA = "0x187C18190", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C17EA0", Offset = "0x7C172A0", VA = "0x187C17EA0", Slot = "13")]
	protected override void Dispose(bool KHGHABFJAOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GDMAKDMNNOF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate bool JKALKMHKOGG<in TInput, TResult>(TInput EOMFNMMGCEC, [Out] TResult APLCGCDLEGH);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private sealed class DCFFDIIGCAC : GAAAHAAIDGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private sealed class AHDFACNNEON : PJEGIPECCEP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly AHDFACNNEON IADGMEFIGGI;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool LMGILDLJIEG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7C12510", Offset = "0x7C11910", VA = "0x187C12510", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7C12570", Offset = "0x7C11970", VA = "0x187C12570", Slot = "6")]
			public void OnCompleted(Action JMEDLEBNABB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			public void JNLIAAFNHJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public AHDFACNNEON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly DCFFDIIGCAC IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		private DCFFDIIGCAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C14170", Offset = "0x7C13570", VA = "0x187C14170", Slot = "4")]
		public PJEGIPECCEP OIMEOLNNAHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private sealed class AODOMHEMELN : GAAAHAAIDGO
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class CHNKPNKLBKI : PJEGIPECCEP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly CHNKPNKLBKI IADGMEFIGGI;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool LMGILDLJIEG
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x7C134D0", Offset = "0x7C128D0", VA = "0x187C134D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7C134F0", Offset = "0x7C128F0", VA = "0x187C134F0", Slot = "6")]
			public void OnCompleted(Action JMEDLEBNABB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			public void JNLIAAFNHJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CHNKPNKLBKI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public static readonly AODOMHEMELN IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		private AODOMHEMELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C12D00", Offset = "0x7C12100", VA = "0x187C12D00", Slot = "4")]
		public PJEGIPECCEP OIMEOLNNAHI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JAEKOJHFDDB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JAEKOJHFDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x48B76E0", Offset = "0x48B6AE0", VA = "0x1848B76E0")]
		internal void EBKAKAOCDIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OBNMPLLDKEK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OBNMPLLDKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4C7DB70", Offset = "0x4C7CF70", VA = "0x184C7DB70")]
		internal void EJEEFMPEJNK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct FLHMJAILGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C14920", Offset = "0x7C13D20", VA = "0x187C14920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct PMHODNMMIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E760", Offset = "0x7C1DB60", VA = "0x187C1E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA2AF00", Offset = "0xA2A300", VA = "0x180A2AF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct APIHDBIBCAC<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4CA4DE0", Offset = "0x4CA41E0", VA = "0x184CA4DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4CA4F50", Offset = "0x4CA4350", VA = "0x184CA4F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MBIMJKNEKNO<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x50AA120", Offset = "0x50A9520", VA = "0x1850AA120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x50AA570", Offset = "0x50A9970", VA = "0x1850AA570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct GPLAJHGJGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C18410", Offset = "0x7C17810", VA = "0x187C18410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C18620", Offset = "0x7C17A20", VA = "0x187C18620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GFGFCPGFCBB<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GFGFCPGFCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x48B76E0", Offset = "0x48B6AE0", VA = "0x1848B76E0")]
		internal void EBEBDBNOAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x48B7750", Offset = "0x48B6B50", VA = "0x1848B7750")]
		internal void NJHJILNHMGI(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MDHCECMIFAM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JKALKMHKOGG<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50B1AE0", Offset = "0x50B0EE0", VA = "0x1850B1AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50B2240", Offset = "0x50B1640", VA = "0x1850B2240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct MLGLEEEKKNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1ACF0", Offset = "0x7C1A0F0", VA = "0x187C1ACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B4E0", Offset = "0x7C1A8E0", VA = "0x187C1B4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CIEECHBFEDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7C135C0", Offset = "0x7C129C0", VA = "0x187C135C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C13B00", Offset = "0x7C12F00", VA = "0x187C13B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NJLACCBKNGK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5222330", Offset = "0x5221730", VA = "0x185222330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x439F6C0", Offset = "0x439EAC0", VA = "0x18439F6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CLIKJEJBILE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public TaskCompletionSource<FGGPIMEAIEJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public CLIKJEJBILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C13B60", Offset = "0x7C12F60", VA = "0x187C13B60")]
		internal void DHFCKJNGFCI(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct COPPPCGCPIN<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x663C9F0", Offset = "0x663BDF0", VA = "0x18663C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3F55250", Offset = "0x3F54650", VA = "0x183F55250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IHHGEMMHPCI<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4A5D3D0", Offset = "0x4A5C7D0", VA = "0x184A5D3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4A5DC40", Offset = "0x4A5D040", VA = "0x184A5DC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HEBBKJICFOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C18690", Offset = "0x7C17A90", VA = "0x187C18690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C18870", Offset = "0x7C17C70", VA = "0x187C18870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AIOPMGMFOMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C12750", Offset = "0x7C11B50", VA = "0x187C12750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C12AC0", Offset = "0x7C11EC0", VA = "0x187C12AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct FOJIABAPEAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C153E0", Offset = "0x7C147E0", VA = "0x187C153E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C156D0", Offset = "0x7C14AD0", VA = "0x187C156D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OHLHHKGCIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public OHLHHKGCIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE90", Offset = "0x7C1B290", VA = "0x187C1BE90")]
		internal Task LNENDFEMCGG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct CNCCFNOLADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C13C70", Offset = "0x7C13070", VA = "0x187C13C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C13ED0", Offset = "0x7C132D0", VA = "0x187C13ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct DBHHADOLMPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C13F30", Offset = "0x7C13330", VA = "0x187C13F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C14110", Offset = "0x7C13510", VA = "0x187C14110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NPBJIHAKHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA50", Offset = "0x7C1AE50", VA = "0x187C1BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BDB0", Offset = "0x7C1B1B0", VA = "0x187C1BDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct MLECPLOHHEJ : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A9A0", Offset = "0x7C19DA0", VA = "0x187C1A9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C1AC90", Offset = "0x7C1A090", VA = "0x187C1AC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GMOLKCJHBBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GMOLKCJHBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C183A0", Offset = "0x7C177A0", VA = "0x187C183A0")]
		internal Task NNNJADHDAJB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NNBMEOADJBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B790", Offset = "0x7C1AB90", VA = "0x187C1B790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B9F0", Offset = "0x7C1ADF0", VA = "0x187C1B9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct AJLOPFDCOKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C12B20", Offset = "0x7C11F20", VA = "0x187C12B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7C12CA0", Offset = "0x7C120A0", VA = "0x187C12CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GIJEKJCEDOK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x48BC780", Offset = "0x48BBB80", VA = "0x1848BC780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x48BCA00", Offset = "0x48BBE00", VA = "0x1848BCA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct PCGAPOPFFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CE20", Offset = "0x7C1C220", VA = "0x187C1CE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D150", Offset = "0x7C1C550", VA = "0x187C1D150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static SynchronizationContext? GGGEMPADDGP;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly TaskCompletionSource<FGGPIMEAIEJ> AACMMJAJNAM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task HLMGBJPHIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C16B70", Offset = "0x7C15F70", VA = "0x187C16B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C173E0", Offset = "0x7C167E0", VA = "0x187C173E0")]
	public static bool OCDAGNLMPJJ(this Task OOCBIOLELBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x36A4140", Offset = "0x36A3540", VA = "0x1836A4140")]
	public static Task<T> EGCGKPLGNCJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C15900", Offset = "0x7C14D00", VA = "0x187C15900")]
	public static Task CJPKKKGEDJO(this Task OOCBIOLELBN, CancellationToken PAHPIGHLKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x36A2770", Offset = "0x36A1B70", VA = "0x1836A2770")]
	public static Task<TResult> CJPKKKGEDJO<TResult>(this Task<TResult> OOCBIOLELBN, CancellationToken PAHPIGHLKFG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x369F4F0", Offset = "0x369E8F0", VA = "0x18369F4F0")]
	public static TaskCompletionSource<TResult> CJPKKKGEDJO<TResult>(this TaskCompletionSource<TResult> CHBGNALCGDK, CancellationToken PAHPIGHLKFG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C16520", Offset = "0x7C15920", VA = "0x187C16520")]
	public static IDisposable? HKIKNLMIMDB(CancellationToken LLJDHNNIKAL, CancellationToken AJGIDGBFBNK, [Out] CancellationToken FMLJNOLPLDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C16AC0", Offset = "0x7C15EC0", VA = "0x187C16AC0")]
	[AsyncStateMachine(typeof(FLHMJAILGGJ))]
	public static void LJIILMDCGHB(this Task DEEHPBDAIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C15850", Offset = "0x7C14C50", VA = "0x187C15850")]
	[AsyncStateMachine(typeof(PMHODNMMIOI))]
	public static void BJCMGJEELCB(this Task DEEHPBDAIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x36A4070", Offset = "0x36A3470", VA = "0x1836A4070")]
	[AsyncStateMachine(typeof(APIHDBIBCAC<>))]
	public static Task EDDNOBNJEIO<TException>(this Task DEEHPBDAIHI) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x369ED60", Offset = "0x369E160", VA = "0x18369ED60")]
	[AsyncStateMachine(typeof(MBIMJKNEKNO<>))]
	public static Task<T> ADOJBNKLHJA<T>(this Task<T> KBBJDOAJMAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C16780", Offset = "0x7C15B80", VA = "0x187C16780")]
	[AsyncStateMachine(typeof(GPLAJHGJGCJ))]
	public static Task<TaskStatus> ICMBLOKHPFN(this Task? KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x369EF40", Offset = "0x369E340", VA = "0x18369EF40")]
	public static (Task<T?>?, Action<T?>?) CGPJJIIGCFC<T>([Optional] CancellationToken JDDHIJBJNHP)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x36A42C0", Offset = "0x36A36C0", VA = "0x1836A42C0")]
	[AsyncStateMachine(typeof(MDHCECMIFAM<, >))]
	public static Task<List<TResult>> GHIEBFAJJPP<TResult, TInput>(this Task<List<TInput>> OOCBIOLELBN, JKALKMHKOGG<TInput, TResult> HEONOEEKJNK) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C16370", Offset = "0x7C15770", VA = "0x187C16370")]
	[AsyncStateMachine(typeof(MLGLEEEKKNL))]
	public static Task GIBCIMHODLD(Task DEEHPBDAIHI, CancellationToken EKBICDMGFBA, Func<CancellationToken, Task> IBLPADOFDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7C16990", Offset = "0x7C15D90", VA = "0x187C16990")]
	[AsyncStateMachine(typeof(CIEECHBFEDF))]
	public static Task LFHMMLBCPPA(Func<CancellationToken, Task> GDILCIHIHJE, TimeSpan MDBJPKFAGHN, [Optional] CancellationToken EKBICDMGFBA, [Optional] Action<OperationCanceledException>? EGGPAGHPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x36A46B0", Offset = "0x36A3AB0", VA = "0x1836A46B0")]
	[AsyncStateMachine(typeof(NJLACCBKNGK<>))]
	public static Task<T> LFHMMLBCPPA<T>(Func<CancellationToken, Task<T>> GDILCIHIHJE, TimeSpan MDBJPKFAGHN, [Optional] CancellationToken EKBICDMGFBA, [Optional] Func<OperationCanceledException, T>? EGGPAGHPNIC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C15E60", Offset = "0x7C15260", VA = "0x187C15E60")]
	public static Task GBFOFHBODHL(params Task[] JMMADGCFAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C15EB0", Offset = "0x7C152B0", VA = "0x187C15EB0")]
	public static Task GBFOFHBODHL(IEnumerable<Task> JMMADGCFAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x36A4B30", Offset = "0x36A3F30", VA = "0x1836A4B30")]
	[AsyncStateMachine(typeof(COPPPCGCPIN<>))]
	public static Task<IEnumerable<Task<T>>> OLGJGDHCGNO<T>(IEnumerable<Task<T>> JMMADGCFAHH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x36A43D0", Offset = "0x36A37D0", VA = "0x1836A43D0")]
	[AsyncStateMachine(typeof(IHHGEMMHPCI<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> JEABDNPDMFK<T1, T2, T3, T4, T5>(Task<T1> OKHFJNJEPBC, Task<T2> BKFOAKAKPMO, Task<T3> CDJPNEPMLCN, Task<T4> CCHPFDKOMCI, Task<T5> LLEELMNGAMN) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C16F70", Offset = "0x7C16370", VA = "0x187C16F70")]
	[AsyncStateMachine(typeof(HEBBKJICFOL))]
	public static Task NAPLKDMCNKH(Func<bool> PJIKMBJAEFO, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C16E60", Offset = "0x7C16260", VA = "0x187C16E60")]
	[AsyncStateMachine(typeof(AIOPMGMFOMC))]
	public static Task NAPLKDMCNKH(Func<bool> PJIKMBJAEFO, TimeSpan DMIDDBNLKKM, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C17550", Offset = "0x7C16950", VA = "0x187C17550")]
	[AsyncStateMachine(typeof(FOJIABAPEAF))]
	public static Task OLDNOPDKAPM(Func<bool> PJIKMBJAEFO, TimeSpan MDBJPKFAGHN, [Optional] CancellationToken JDDHIJBJNHP, [Optional] Action<OperationCanceledException>? EGGPAGHPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C17410", Offset = "0x7C16810", VA = "0x187C17410")]
	[AsyncStateMachine(typeof(CNCCFNOLADI))]
	public static Task OLDNOPDKAPM(Func<bool> PJIKMBJAEFO, TimeSpan MDBJPKFAGHN, TimeSpan DMIDDBNLKKM, [Optional] CancellationToken JDDHIJBJNHP, [Optional] Action<OperationCanceledException>? EGGPAGHPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C15D70", Offset = "0x7C15170", VA = "0x187C15D70")]
	[AsyncStateMachine(typeof(DBHHADOLMPH))]
	public static Task FNPEKMKLEHA(Func<bool> PJIKMBJAEFO, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C15C60", Offset = "0x7C15060", VA = "0x187C15C60")]
	[AsyncStateMachine(typeof(NPBJIHAKHDD))]
	public static Task FNPEKMKLEHA(Func<bool> PJIKMBJAEFO, TimeSpan DMIDDBNLKKM, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C17680", Offset = "0x7C16A80", VA = "0x187C17680")]
	[AsyncStateMachine(typeof(MLECPLOHHEJ))]
	public static Task PIFACGAACKD(Func<bool> PJIKMBJAEFO, TimeSpan MDBJPKFAGHN, [Optional] CancellationToken JDDHIJBJNHP, [Optional] Action<OperationCanceledException>? EGGPAGHPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C177B0", Offset = "0x7C16BB0", VA = "0x187C177B0")]
	[AsyncStateMachine(typeof(NNBMEOADJBJ))]
	public static Task PIFACGAACKD(Func<bool> PJIKMBJAEFO, TimeSpan MDBJPKFAGHN, TimeSpan DMIDDBNLKKM, [Optional] CancellationToken JDDHIJBJNHP, [Optional] Action<OperationCanceledException>? EGGPAGHPNIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C16D70", Offset = "0x7C16170", VA = "0x187C16D70")]
	[Obsolete]
	[AsyncStateMachine(typeof(AJLOPFDCOKO))]
	public static Task MKDIAPGKLDJ(this Task OOCBIOLELBN, Action NBGNOOFMNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36A4950", Offset = "0x36A3D50", VA = "0x1836A4950")]
	[AsyncStateMachine(typeof(GIJEKJCEDOK<>))]
	[Obsolete]
	public static Task MKDIAPGKLDJ<T>(this Task<T> OOCBIOLELBN, Action<T> NBGNOOFMNPB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C15BB0", Offset = "0x7C14FB0", VA = "0x187C15BB0")]
	private static void DKFOPGFKFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C17060", Offset = "0x7C16460", VA = "0x187C17060")]
	public static bool NPBOILEFIGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C16BE0", Offset = "0x7C15FE0", VA = "0x187C16BE0")]
	private static void MFKAFIGINOK(SynchronizationContext OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C16870", Offset = "0x7C15C70", VA = "0x187C16870")]
	private static void IMBPADKCOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C166B0", Offset = "0x7C15AB0", VA = "0x187C166B0")]
	public static void HONMAPOJNHM([Optional] string? FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C164A0", Offset = "0x7C158A0", VA = "0x187C164A0")]
	public static void GIKACIBOPEI([Optional] string? FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C15730", Offset = "0x7C14B30", VA = "0x187C15730")]
	public static GAAAHAAIDGO AGDDJHPCKKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C15B60", Offset = "0x7C14F60", VA = "0x187C15B60")]
	public static GAAAHAAIDGO DCGIIIPLNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C15780", Offset = "0x7C14B80", VA = "0x187C15780")]
	[AsyncStateMachine(typeof(PCGAPOPFFHL))]
	public static Task AMOHOEDGHJA(Func<Task> JMBBGOMJFAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IJOMDGJLMLC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public IJOMDGJLMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NGDGEIGKNNI : IHPFFPOEDNM
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public static readonly IHPFFPOEDNM IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime PHEIOMCLNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B670", Offset = "0x7C1AA70", VA = "0x187C1B670", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset JMOGJHOMAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B6B0", Offset = "0x7C1AAB0", VA = "0x187C1B6B0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NGDGEIGKNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface IHPFFPOEDNM
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime PHEIOMCLNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset JMOGJHOMAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class AFGIHFNEFDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long HNLJKIBBMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C12110", Offset = "0x7C11510", VA = "0x187C12110")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long FAEFHPEHPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C11CF0", Offset = "0x7C110F0", VA = "0x187C11CF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double EDDHMIILPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C12010", Offset = "0x7C11410", VA = "0x187C12010")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double PNGAEGIFAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C12060", Offset = "0x7C11460", VA = "0x187C12060")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double LLHBCFDLCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C121F0", Offset = "0x7C115F0", VA = "0x187C121F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double CJJHFCDKGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C11EA0", Offset = "0x7C112A0", VA = "0x187C11EA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7C11EF0", Offset = "0x7C112F0", VA = "0x187C11EF0")]
	public static double EJNEDKJCJHF(long OLEKLIEIKNB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7C11F80", Offset = "0x7C11380", VA = "0x187C11F80")]
	public static double EPHHKKJOHCB(long OLEKLIEIKNB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C12160", Offset = "0x7C11560", VA = "0x187C12160")]
	public static double MEJEKHNNPDF(double HDNGPCOMJAA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7C11E10", Offset = "0x7C11210", VA = "0x187C11E10")]
	public static long EDIIIAHBACB(long FGNAOOMAGFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7C11CE0", Offset = "0x7C110E0", VA = "0x187C11CE0")]
	public static long AECOPEAKKOJ(long KIHKGAEHNNG, long ILICJFKMNCA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C11D40", Offset = "0x7C11140", VA = "0x187C11D40")]
	public static double EDFFMKIDJAI(long KIHKGAEHNNG, long ILICJFKMNCA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C120B0", Offset = "0x7C114B0", VA = "0x187C120B0")]
	public static double JHLCJPPNAKG(long KIHKGAEHNNG, long ILICJFKMNCA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class BACCGEPOADI : HPOMILBADKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly TimeSpan GIDEGDJKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly System.Timers.Timer IHAAMEONBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private TimeSpan MDBJPKFAGHN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan KNICEGDHNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C12F00", Offset = "0x7C12300", VA = "0x187C12F00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? EMOCMHJDIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C13460", Offset = "0x7C12860", VA = "0x187C13460")]
	[Preserve]
	public BACCGEPOADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C13210", Offset = "0x7C12610", VA = "0x187C13210")]
	public BACCGEPOADI(TimeSpan MDBJPKFAGHN, [Optional] Action? HFCHBMAEGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C12DD0", Offset = "0x7C121D0", VA = "0x187C12DD0", Slot = "7")]
	public void BOFHKCJPDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C13090", Offset = "0x7C12490", VA = "0x187C13090", Slot = "8")]
	public void LJNNEIEGMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C13060", Offset = "0x7C12460", VA = "0x187C13060", Slot = "9")]
	public void KPIGIAJPEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x10BAFA0", Offset = "0x10BA3A0", VA = "0x1810BAFA0")]
	private void KBAIEBDBFGN(object PLCJAHDMBHK, ElapsedEventArgs DJELDIODANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7C13100", Offset = "0x7C12500", VA = "0x187C13100")]
	private static void MNBOMAOHHCE(TimeSpan ALNONHBEHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7C12E60", Offset = "0x7C12260", VA = "0x187C12E60", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CBPMGKHNHGF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly string? FHOJKPJGHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly string DBONIOPGFON;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x754F3B0", Offset = "0x754E7B0", VA = "0x18754F3B0")]
	public CBPMGKHNHGF(string IKFIIFEGFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x4BC1230", Offset = "0x4BC0630", VA = "0x184BC1230")]
	public CBPMGKHNHGF(string BJFHDDMNBNB, string IKFIIFEGFHM)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OOIBJIIIKPM : IEquatable<OOIBJIIIKPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint EKBJLLMCJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int HMKFGHEBFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float IAFCONNDKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort MKOPLKKMHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ushort CBBGKBGPONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short GAKCEDPDECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short ONKFHJKPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public char MHBIDNGABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char BCJJFODBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte GPNLHPACKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte PNFCDGFMGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte JMKJIEDLHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte MNAFJNKMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool FJHABOIFJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool AFNNEAKBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool MMAGNMDHICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool FMDLNAAFNPA;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DDA120", VA = "0x181DDAD20")]
	public static OOIBJIIIKPM ODJFFFFGAIE(uint EAHMLJPNIIH)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DDA120", VA = "0x181DDAD20")]
	public static OOIBJIIIKPM ILMJBCIILFI(int EJFOFLKJBHM)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BFB0", Offset = "0x7C1B3B0", VA = "0x187C1BFB0")]
	public static OOIBJIIIKPM PEIIFFGGOJB(float NLKPMFHPJPC)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF00", Offset = "0x7C1B300", VA = "0x187C1BF00")]
	public static OOIBJIIIKPM GEMMDIBCFAP(byte LMIKBLKKDCG, byte JOJADFKNGKG, byte MFJKPGNMCIA, byte PMBBIGODEOG)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF00", Offset = "0x7C1B300", VA = "0x187C1BF00")]
	public static OOIBJIIIKPM GBLJADJOGCD(bool LNGDANCIFKJ, bool BAGKBGOEGGN, bool FPJKOOPHKKM, bool OGEECNKPCPL)
	{
		return default(OOIBJIIIKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF00", Offset = "0x7C1B300", VA = "0x187C1BF00")]
	public static OOIBJIIIKPM EBJDHKJLNMI(byte HIPNEILODKM, byte OBMIKMEKHLG, byte OIEKBPNIGOE, byte PDHAAFDDKGK)
	{
		return default(OOIBJIIIKPM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x20CB800", Offset = "0x20CAC00", VA = "0x1820CB800")]
	public static bool HGJBAFCOLON(OOIBJIIIKPM PPPJAHNPKAO, OOIBJIIIKPM DFIFINAEGII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x20CB7E0", Offset = "0x20CABE0", VA = "0x1820CB7E0", Slot = "4")]
	public bool Equals(OOIBJIIIKPM DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BF20", Offset = "0x7C1B320", VA = "0x187C1BF20", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1240CC0", Offset = "0x12400C0", VA = "0x181240CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BFC0", Offset = "0x7C1B3C0", VA = "0x187C1BFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MFHJELKIKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public ulong IIBKMILMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public long KELPPIPLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public double LDDBHJBIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint LKNFGKLHPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public uint ODIFPLHDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public int ONBPJELAPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public int AELKIBFKDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public float JGLMHPCCCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public float JHLDODHEMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort MKOPLKKMHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort CBBGKBGPONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public ushort IMINHDCEPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public ushort GJOIMCGFPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short GAKCEDPDECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short ONKFHJKPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public short BICJFJKFAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public short MFMICEBFMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char MHBIDNGABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char BCJJFODBKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public char EGAFGHLMCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public char AIPCMCJJLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte GPNLHPACKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte PNFCDGFMGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte JMKJIEDLHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte MNAFJNKMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte BJCMKFNJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte LKGBGMCFKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte NEOMJGLADLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte IPFLCEJNNBG;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static MFHJELKIKOK FABCCGGAHMJ(long LPMEJDJNAJL)
	{
		return default(MFHJELKIKOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A950", Offset = "0x7C19D50", VA = "0x187C1A950")]
	public static MFHJELKIKOK FABCCGGAHMJ(byte LMIKBLKKDCG, byte JOJADFKNGKG, byte MFJKPGNMCIA, byte PMBBIGODEOG, byte CPABNECPAIP, byte LCCHPHBMFPH, byte MKEOFAINKLL, byte PDNFNBMAOMH)
	{
		return default(MFHJELKIKOK);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PKDGAHEDDEC : IEquatable<PKDGAHEDDEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte PDBPHEEBJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool LBIGNJEBKDK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2D6ABC0", Offset = "0x2D69FC0", VA = "0x182D6ABC0")]
	public static PKDGAHEDDEC GEMMDIBCFAP(byte GHLJJKKHANO)
	{
		return default(PKDGAHEDDEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2D6ABC0", Offset = "0x2D69FC0", VA = "0x182D6ABC0")]
	public static PKDGAHEDDEC GBLJADJOGCD(bool ILDNLDJLLED)
	{
		return default(PKDGAHEDDEC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E4E0", Offset = "0x7C1D8E0", VA = "0x187C1E4E0")]
	public static bool HGJBAFCOLON(PKDGAHEDDEC PPPJAHNPKAO, PKDGAHEDDEC DFIFINAEGII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0D90", Offset = "0x6BB0190", VA = "0x186BB0D90", Slot = "4")]
	public bool Equals(PKDGAHEDDEC DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E440", Offset = "0x7C1D840", VA = "0x187C1E440", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E4D0", Offset = "0x7C1D8D0", VA = "0x187C1E4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E4F0", Offset = "0x7C1D8F0", VA = "0x187C1E4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class LBDLIPCJPHP<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly T PPCBMEACGOD;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8A060", Offset = "0x4E89460", VA = "0x184E8A060")]
	public LBDLIPCJPHP(T DMDMIKIJMGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class PAKDDJMFHFI
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x37B56B0", Offset = "0x37B4AB0", VA = "0x1837B56B0")]
	public static IEnumerable<T> MIMEJEMFPFF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static T[] CPCHKODJHKD<T>(params T[] EBGHGHNPDBG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static IEnumerable<T> FALBEBJNMCN<T>(params T[] EBGHGHNPDBG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static HashSet<T> MLLDIKKDHDL<T>(params T[] EBGHGHNPDBG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x38BD300", Offset = "0x38BC700", VA = "0x1838BD300")]
	public static KeyValuePair<TKey, TValue> MHLOIOPOHGE<TKey, TValue>([In] TKey IICGAABOENK, [In] TValue OOEMJLHLIHJ) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static List<T> LFLMLPNHNCC<T>(IEnumerable<T> IMPJLIJJJPO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[AttributeUsage(AttributeTargets.All)]
public sealed class ADFLCGEAIKO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly string MOLHELEFMBL;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
	public ADFLCGEAIKO(string BJFBLFCILOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object JHBNIACOHMK<T>([In] T KBIBHMCLJNL);
[Cpp2IlInjected.Token(Token = "0x2000064")]
public delegate object OCIDPAJJDNH<T>(T KBIBHMCLJNL);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[PENHBMFEGIF]
public delegate string EEMINLEIJNM(string EMIHGGEGHBP, string? PBDLCAKDPOA, bool NLBFBPINCJN);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[PENHBMFEGIF]
public delegate void JIIOACGPHJH(string FGEBHLNNMNH);
[Cpp2IlInjected.Token(Token = "0x2000067")]
[PENHBMFEGIF]
public delegate void HPGAIPDFEEC(Exception CCEMNOMFFKG);
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object CHIJIIMENLD();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[PENHBMFEGIF]
public delegate bool DJCGOIEODOM();
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PENHBMFEGIF]
public delegate string BLPHKHGIGMD(object KLANNNFBLNB);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[AttributeUsage(AttributeTargets.Enum)]
public class ONPEJMMGCIN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
	public ONPEJMMGCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class PHFDLPGEKIB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct JBKLNLAHIKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7C18B00", Offset = "0x7C17F00", VA = "0x187C18B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7C193F0", Offset = "0x7C187F0", VA = "0x187C193F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly TimerCallback DCGKGMIEMIG;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly Action<object?> ONJHDGNIOCP;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DF90", Offset = "0x7C1D390", VA = "0x187C1DF90")]
	public static Task<bool> CHBEIBDOLEB(int HDDFGJKMGCM, [Optional] CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DE60", Offset = "0x7C1D260", VA = "0x187C1DE60")]
	[AsyncStateMachine(typeof(JBKLNLAHIKA))]
	private static Task<bool> CDPDONMCFFG(int HDDFGJKMGCM, CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C1DDD0", Offset = "0x7C1D1D0", VA = "0x187C1DDD0")]
	private static void BKMFGKALDDB(object? FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E2A0", Offset = "0x7C1D6A0", VA = "0x187C1E2A0")]
	private static void OOJKOOFKLJC(object? FGCBFMGNEPC)
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
