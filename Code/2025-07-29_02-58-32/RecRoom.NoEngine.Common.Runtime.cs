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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x846CFE0", Offset = "0x846B9E0", VA = "0x18846CFE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BGNCDJJLGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84618F0", Offset = "0x84602F0", VA = "0x1884618F0")]
	public static string GMGJFPIHJPF(this Encoding EPCBBLCPIPE, [In] ReadOnlySequence<byte> LHALFHPGBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39FD2D0", Offset = "0x39FBCD0", VA = "0x1839FD2D0")]
	private static void EODMFOKOOAH<T>(this ReadOnlySequence<T> ELPPHIEIIDB, [Out] ReadOnlySpan<T> HHIBHFKBJDA, [Out] SequencePosition EJGIIDDOBIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NPGJEFPFCLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x846CEC0", Offset = "0x846B8C0", VA = "0x18846CEC0")]
	public NPGJEFPFCLM(bool LOKELOLJBIH, string MLHFNKPOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x846CF90", Offset = "0x846B990", VA = "0x18846CF90")]
	public NPGJEFPFCLM(bool LOKELOLJBIH, params string[] IMCENHOBLDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KOCCCDHLBFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PAMBNAINJMH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGNGAAHOJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNCOCEJEIFM(string LNBCHJPEENA, double PDKJBMPOMNC, [Optional] string? KPMBKICDLDA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OKDGJMBIOFJ : AFIMFPFCGCF, MKMPFFIADMO, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int EGLGDEOBAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> LBBNELBHBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double OIMFMPLNJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double HJDOALAIPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double IDAEHLBBIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AKBOMCJPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double MOBMEGFCELI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AACKOKBBMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3B30", Offset = "0xAA2530", VA = "0x180AA3B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HHMAIHJCCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x846D310", Offset = "0x846BD10", VA = "0x18846D310", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BEHCEFPHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5059520", Offset = "0x5057F20", VA = "0x185059520", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double HGDMPFAJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x29CF600", Offset = "0x29CE000", VA = "0x1829CF600", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x846D5A0", Offset = "0x846BFA0", VA = "0x18846D5A0")]
	public OKDGJMBIOFJ(int MOHBOFHDBPD, double MOBMEGFCELI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x846D370", Offset = "0x846BD70", VA = "0x18846D370", Slot = "7")]
	public void CIDGPDFMCPH(double BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x846D2A0", Offset = "0x846BCA0", VA = "0x18846D2A0", Slot = "8")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x846D4A0", Offset = "0x846BEA0", VA = "0x18846D4A0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JHLEPDGKAMG : AFIMFPFCGCF, MKMPFFIADMO, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long CDCPIGCEABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double HIOFBMHCHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double PKHKNDEDGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BIIGDOCBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double CNMAGFEELCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double OIMFMPLNJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double HJDOALAIPGL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BEHCEFPHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x764D460", Offset = "0x764BE60", VA = "0x18764D460", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HGDMPFAJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x764D8F0", Offset = "0x764C2F0", VA = "0x18764D8F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FJGBOPAAENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x764D4A0", Offset = "0x764BEA0", VA = "0x18764D4A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HHMAIHJCCAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3174BE0", Offset = "0x31735E0", VA = "0x183174BE0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x846A070", Offset = "0x8468A70", VA = "0x18846A070", Slot = "10")]
	public virtual void CIDGPDFMCPH(double BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x846A030", Offset = "0x8468A30", VA = "0x18846A030", Slot = "11")]
	public virtual void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x846A190", Offset = "0x8468B90", VA = "0x18846A190", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x846A200", Offset = "0x8468C00", VA = "0x18846A200")]
	public JHLEPDGKAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JJILNDEGEBJ : JHLEPDGKAMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double AILOODPGIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x764D8E0", Offset = "0x764C2E0", VA = "0x18764D8E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x764D920", Offset = "0x764C320", VA = "0x18764D920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x846A270", Offset = "0x8468C70", VA = "0x18846A270", Slot = "10")]
	public override void CIDGPDFMCPH(double BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x846A230", Offset = "0x8468C30", VA = "0x18846A230", Slot = "11")]
	public override void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x846A200", Offset = "0x8468C00", VA = "0x18846A200")]
	public JJILNDEGEBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AFIMFPFCGCF : MKMPFFIADMO, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HHMAIHJCCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BEHCEFPHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double HGDMPFAJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IBKMPHGOKIL : MKMPFFIADMO, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double FPNHBACLOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double LIICIPLKEBN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8468840", Offset = "0x8467240", VA = "0x188468840")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x709E620", Offset = "0x709D020", VA = "0x18709E620", Slot = "4")]
	public void CIDGPDFMCPH(double BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8468830", Offset = "0x8467230", VA = "0x188468830", Slot = "5")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8468850", Offset = "0x8467250", VA = "0x188468850", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IBKMPHGOKIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MKMPFFIADMO : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIDGPDFMCPH(double BEAEDIJJJJI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAJENMMCLHG();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DGECEJDAIFA : MKMPFFIADMO, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double PDKJBMPOMNC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x49EDEC0", Offset = "0x49EC8C0", VA = "0x1849EDEC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5882870", Offset = "0x5881270", VA = "0x185882870", Slot = "4")]
	public void CIDGPDFMCPH(double BEAEDIJJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84630D0", Offset = "0x8461AD0", VA = "0x1884630D0", Slot = "5")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84630E0", Offset = "0x8461AE0", VA = "0x1884630E0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public DGECEJDAIFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MOMPOKJJJBC<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> FGNPJCDKMCF(CancellationToken OMJKEHOJJFF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EFFFJBFBKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MOMPOKJJJBC<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FGNPJCDKMCF taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x492C220", Offset = "0x492AC20", VA = "0x18492C220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x492D270", Offset = "0x492BC70", VA = "0x18492D270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource LNGJLPHIAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? ILNIGHDNBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? HAEBBEILBNN;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5847720", Offset = "0x5846120", VA = "0x185847720")]
	[AsyncStateMachine(typeof(MOMPOKJJJBC<>.EFFFJBFBKDF))]
	public Task<TResult> HGLHGHANEPK(FGNPJCDKMCF LHGHGNEJKKI, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x58476B0", Offset = "0x58460B0", VA = "0x1858476B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5847860", Offset = "0x5846260", VA = "0x185847860")]
	public MOMPOKJJJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HKNBNECOBJN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> FMHHDFLEEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T BHKLFFIKDPE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5054610", Offset = "0x5053010", VA = "0x185054610")]
	public HKNBNECOBJN([In] T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x50536C0", Offset = "0x50520C0", VA = "0x1850536C0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5053D60", Offset = "0x5052760", VA = "0x185053D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5054460", Offset = "0x5052E60", VA = "0x185054460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ILEHDJNALIC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static HKNBNECOBJN<T> MDDJOGPLAFO<T>([In] T PDKJBMPOMNC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NFHMLLLODIF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x846CCB0", Offset = "0x846B6B0", VA = "0x18846CCB0")]
	public static void GIFBFALGPJF(this CancellationTokenSource LNGJLPHIAOB, bool MCFJLIBNMKD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IKNKEAIJPFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public IKNKEAIJPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class JEPLGDCHKCB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public JEPLGDCHKCB(string LJHBJJBNIGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HDIBAHOAMLH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D110", Offset = "0x3C7BB10", VA = "0x183C7D110")]
	public static IIIKKNHJKJD MCECOJKMNBN<T>()
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8468360", Offset = "0x8466D60", VA = "0x188468360")]
	public static IIIKKNHJKJD GFLPCPLJBAA([CallerMemberName] string FLBFBHGDBLM = "")
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CE90", Offset = "0x3C7B890", VA = "0x183C7CE90")]
	public static IIIKKNHJKJD EPMGFCHFKLP<T>([CallerMemberName] string FLBFBHGDBLM = "") where T : notnull
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D190", Offset = "0x3C7BB90", VA = "0x183C7D190")]
	public static IIIKKNHJKJD MCECOJKMNBN<T>(this T GIGDEGEMDAC) where T : notnull
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CFC0", Offset = "0x3C7B9C0", VA = "0x183C7CFC0")]
	public static IIIKKNHJKJD GFLPCPLJBAA<T>(this T GIGDEGEMDAC, [CallerMemberName] string FLBFBHGDBLM = "") where T : notnull
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CF20", Offset = "0x3C7B920", VA = "0x183C7CF20")]
	public static IIIKKNHJKJD EPMGFCHFKLP<T>(this T NLDLHIJAJBO, [CallerMemberName] string FLBFBHGDBLM = "") where T : notnull
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84682E0", Offset = "0x8466CE0", VA = "0x1884682E0")]
	public static IIIKKNHJKJD EPMGFCHFKLP(string LHPHBMLLEBC, [CallerMemberName] string FLBFBHGDBLM = "")
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84683C0", Offset = "0x8466DC0", VA = "0x1884683C0")]
	public static string LOPDMNBOKIK(this object NLDLHIJAJBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool ANHKMKBHOMC();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IKNKEAIJPFL]
public delegate long ECJJMKODLDH();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class EDINCNEEJLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly EDINCNEEJLO NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EDINCNEEJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IPJOHHHDKNI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static EIALKMDPJEE KBPMGMDOPFE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static EIALKMDPJEE MJEPNMEEKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8469D20", Offset = "0x8468720", VA = "0x188469D20")]
		get
		{
			return default(EIALKMDPJEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static ICNNFMDNOFB IEBAGOBEOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8469760", Offset = "0x8468160", VA = "0x188469760")]
		get
		{
			return default(ICNNFMDNOFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static PMKOGEOMMNE JCAGOODKFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8469CD0", Offset = "0x84686D0", VA = "0x188469CD0")]
		get
		{
			return default(PMKOGEOMMNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool BIGLGENCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8469DF0", Offset = "0x84687F0", VA = "0x188469DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84697B0", Offset = "0x84681B0", VA = "0x1884697B0")]
	public static void BPMCBPOADPF([In] EIALKMDPJEE IBELFPEPJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8469A00", Offset = "0x8468400", VA = "0x188469A00")]
	public static void GCLDEHJKFHJ(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8469BA0", Offset = "0x84685A0", VA = "0x188469BA0")]
	public static void IJNANOIGCCM(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CDFFF0", Offset = "0x3CDE9F0", VA = "0x183CDFFF0")]
	public static void IJNANOIGCCM<T>(T GOMJJOOOEFM, EEPICLBJPOB<T> ONGDPODJNBL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8469ED0", Offset = "0x84688D0", VA = "0x188469ED0")]
	public static void PPBPIEBFMOA(Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8469C70", Offset = "0x8468670", VA = "0x188469C70")]
	public static void KHDFNJHNLGL(string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8469700", Offset = "0x8468100", VA = "0x188469700")]
	public static void BDNFHMDELMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8469D70", Offset = "0x8468770", VA = "0x188469D70")]
	public static string LOPDMNBOKIK(object CEFJEHJNIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8469E60", Offset = "0x8468860", VA = "0x188469E60")]
	public static long NIBDNNHNKME()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8469960", Offset = "0x8468360", VA = "0x188469960")]
	public static bool FHGNOPPNNKG(bool JOPBOJCEAIO, string ONGDPODJNBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8469AD0", Offset = "0x84684D0", VA = "0x188469AD0")]
	public static double GGLHEPCFPGI()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct EIALKMDPJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly ICNNFMDNOFB IEBAGOBEOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly PMKOGEOMMNE JCAGOODKFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly JJIGHNHKEEB IIBNIEENACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly ECJJMKODLDH HFIBHCPFOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly KFDPGHENDGP GCDEDCNFHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly ANHKMKBHOMC JJHFMFNMDOF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly JJIGHNHKEEB DIDJKKIEGBI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ECJJMKODLDH LMIMDFENCGO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly KFDPGHENDGP GDKGMMLLDBM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly ANHKMKBHOMC CGACBIOOCAO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly EIALKMDPJEE MFNPHNGAJMG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OFLDDHIICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8466AA0", Offset = "0x84654A0", VA = "0x188466AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8467480", Offset = "0x8465E80", VA = "0x188467480")]
	public EIALKMDPJEE([In] ICNNFMDNOFB PPGCIALOEGE, [In] PMKOGEOMMNE LJPBGPPEICC, JJIGHNHKEEB KJICDIODFMI, ECJJMKODLDH OAFKDEOPHPF, KFDPGHENDGP MNFBOCGBEBD, ANHKMKBHOMC IGDDJAALLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8466D50", Offset = "0x8465750", VA = "0x188466D50")]
	private static string PEOHLOMMDBE(object CEFJEHJNIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	private static long BJFDCAFLOND()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	private static string EBMBFOJDNPK(string OJCMLFFIJFF, string? OLLJNINDADG, bool GJIOPFNKCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	private static bool HMOPHCKFEBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8466C40", Offset = "0x8465640", VA = "0x188466C40")]
	private static EIALKMDPJEE JBEHOJILMJG()
	{
		return default(EIALKMDPJEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CCFNGOEOABH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJBMHHPPBPB LBAHCCCMDNN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OJBMHHPPBPB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CCPIHKOJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJEBOGFAOKA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CBNEFFEOLNP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGGPONMHEAK([In] T EFNHKCDKOGH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void DJBNNJPEFJH<T>([In] T GOMJJOOOEFM);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct CAAMNALIFOM<T> : IEquatable<CAAMNALIFOM<T>>, CBNEFFEOLNP<CAAMNALIFOM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T BHKLFFIKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int ODEBCJMJOPK;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2FF15C0", Offset = "0x2FEFFC0", VA = "0x182FF15C0")]
	public CAAMNALIFOM([In] T PDKJBMPOMNC, int FILGHJLFKAL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6958260", Offset = "0x6956C60", VA = "0x186958260")]
	public static bool JJNADAGGMDE([In] CAAMNALIFOM<T> OKDCNKNEMHO, [In] CAAMNALIFOM<T> AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x580B950", Offset = "0x580A350", VA = "0x18580B950", Slot = "4")]
	public bool Equals(CAAMNALIFOM<T> EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC120", Offset = "0x4FFAB20", VA = "0x184FFC120", Slot = "0")]
	public override bool Equals(object EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6956A80", Offset = "0x6955480", VA = "0x186956A80")]
	public bool BGGPONMHEAK([In] CAAMNALIFOM<T> EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6957B50", Offset = "0x6956550", VA = "0x186957B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6958B40", Offset = "0x6957540", VA = "0x186958B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6957280", Offset = "0x6955C80", VA = "0x186957280")]
	public void GNAIPCHGPNM([Out] T PDKJBMPOMNC, [Out] int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6956BE0", Offset = "0x69555E0", VA = "0x186956BE0")]
	public (T, int) FBJAEDAAIAJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6956B10", Offset = "0x6955510", VA = "0x186956B10", Slot = "5")]
	private bool EAMLHJCGLOP([In] CAAMNALIFOM<T> EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OLKJJOAIMEN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CE20", Offset = "0x3E4B820", VA = "0x183E4CE20")]
	public static CAAMNALIFOM<T> MDDJOGPLAFO<T>([In] T PDKJBMPOMNC, int FILGHJLFKAL) where T : notnull
	{
		return default(CAAMNALIFOM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FDNLCDENBGM
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3C50540", Offset = "0x3C4EF40", VA = "0x183C50540")]
	public static bool BGGPONMHEAK<T, U>([In] T NLDLHIJAJBO, [In] U CEFJEHJNIAP) where T : notnull, CBNEFFEOLNP<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult BPPLFHBGMOA<T, out TResult>([In] T GOMJJOOOEFM);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EELAOLEHAFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan IJEGPHKMIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? GKDNDPNIHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMHPCBOPLJD();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPCDMBGDLEA();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHOFHALOFLF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ICNNFMDNOFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly JPHNLBLLKBO HMOKHJDKLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IIDBHHFOGKA CAMNJECOOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly JPHNLBLLKBO OJNIHAMDGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IIDBHHFOGKA HLCMKJPODME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly JPHNLBLLKBO GIOFLPFEKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IIDBHHFOGKA OOCMPCBECKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly GDKIAKCABEL AJNGMEFIKDH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JPHNLBLLKBO AJOPOCGHIFJ;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IIDBHHFOGKA NAKJAKNILFA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly JPHNLBLLKBO EKEMAPANIHA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IIDBHHFOGKA EOJPKAIIMAE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JPHNLBLLKBO JIBNLBEHLAF;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly IIDBHHFOGKA CODMBIOCNLE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly GDKIAKCABEL DIGAPCAFNIN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly ICNNFMDNOFB MFNPHNGAJMG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JPHNLBLLKBO IFOOLNPJDCF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OFLDDHIICNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84688A0", Offset = "0x84672A0", VA = "0x1884688A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xEC0570", Offset = "0xEBEF70", VA = "0x180EC0570")]
	public ICNNFMDNOFB(JPHNLBLLKBO APEFNGNCPFB, IIDBHHFOGKA FLENOLGPKFJ, JPHNLBLLKBO LDLHAPADCJJ, IIDBHHFOGKA EKMHHFCIGEG, JPHNLBLLKBO LPMLCHCNPAH, IIDBHHFOGKA OPPCPIJAMNI, GDKIAKCABEL MPOALOKDANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	private static bool PBBDPAFLAKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void FPBJCODOGBB(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	private static bool EHMHOIDOIJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void PPLFDAEKPNP(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480")]
	private static bool GEBFPNLJPFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void KPFEIBGADJB(string ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void AEJCFDGPHCM(Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8468D30", Offset = "0x8467730", VA = "0x188468D30")]
	private static ICNNFMDNOFB JBEHOJILMJG()
	{
		return default(ICNNFMDNOFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
	private static bool LDELAPLKMDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8468B70", Offset = "0x8467570", VA = "0x188468B70")]
	public void GCLDEHJKFHJ(object ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8468E70", Offset = "0x8467870", VA = "0x188468E70")]
	public void MIAECCEGCIC(object ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8468CC0", Offset = "0x84676C0", VA = "0x188468CC0")]
	public void IJNANOIGCCM(object ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xEB4070", Offset = "0xEB2A70", VA = "0x180EB4070")]
	public void PPBPIEBFMOA(Exception HPIGFEEDBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8468BE0", Offset = "0x84675E0", VA = "0x188468BE0")]
	public void IJNANOIGCCM(IBNHAOALLDE ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CAAE10", Offset = "0x3CA9810", VA = "0x183CAAE10")]
	public void IJNANOIGCCM<T>(T GOMJJOOOEFM, EEPICLBJPOB<T> ONGDPODJNBL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CAAC90", Offset = "0x3CA9690", VA = "0x183CAAC90")]
	public void GCLDEHJKFHJ<T>([In] T GOMJJOOOEFM, LKFJPKMAOPA<T> ONGDPODJNBL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CAAEE0", Offset = "0x3CA98E0", VA = "0x183CAAEE0")]
	public void IJNANOIGCCM<T>([In] T GOMJJOOOEFM, LKFJPKMAOPA<T> ONGDPODJNBL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8468AA0", Offset = "0x84674A0", VA = "0x188468AA0")]
	public bool FHGNOPPNNKG(bool JOPBOJCEAIO, string ONGDPODJNBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct IIIKKNHJKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string BHKLFFIKDPE;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xE76700", Offset = "0xE75100", VA = "0x180E76700")]
	public IIIKKNHJKJD(string PDKJBMPOMNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0")]
	public static string LHJBCIIELME([In] IIIKKNHJKJD NLDLHIJAJBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x143A660", Offset = "0x1439060", VA = "0x18143A660")]
	public static IIIKKNHJKJD LHJBCIIELME(string EFNHKCDKOGH)
	{
		return default(IIIKKNHJKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84695D0", Offset = "0x8467FD0", VA = "0x1884695D0")]
	public string BCBENBICOJA(string NBNGFELHGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8469620", Offset = "0x8468020", VA = "0x188469620")]
	public string JHGLCCGFEFN(object GJCLCJPIKBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class NCBOHMOPOFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public NCBOHMOPOFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FAIGCFGAAKD : IEquatable<FAIGCFGAAKD>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "4")]
	public bool Equals(FAIGCFGAAKD EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8467770", Offset = "0x8466170", VA = "0x188467770", Slot = "0")]
	public override bool Equals(object EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x84677C0", Offset = "0x84661C0", VA = "0x1884677C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x84677D0", Offset = "0x84661D0", VA = "0x1884677D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JOAGOPIPNIM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct KKOBOKGIKFE<T> : IEquatable<KKOBOKGIKFE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T BHKLFFIKDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool APPDBCJEHOH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IIAPIIDGLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54F92A0", Offset = "0x54F7CA0", VA = "0x1854F92A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x54FB650", Offset = "0x54FA050", VA = "0x1854FB650")]
	public KKOBOKGIKFE([In] T PDKJBMPOMNC, bool CIIMGBCFCFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x54FA8D0", Offset = "0x54F92D0", VA = "0x1854FA8D0")]
	public static bool JJNADAGGMDE([In] KKOBOKGIKFE<T> OKDCNKNEMHO, [In] KKOBOKGIKFE<T> AAJFLFEAFBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x54F9450", Offset = "0x54F7E50", VA = "0x1854F9450", Slot = "4")]
	public bool Equals(KKOBOKGIKFE<T> EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x54F9A40", Offset = "0x54F8440", VA = "0x1854F9A40", Slot = "0")]
	public override bool Equals(object? EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x54FA430", Offset = "0x54F8E30", VA = "0x1854FA430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x54FAE00", Offset = "0x54F9800", VA = "0x1854FAE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NOLDMJNPFHP
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E19590", Offset = "0x3E17F90", VA = "0x183E19590")]
	public static KKOBOKGIKFE<T> INBEFCDPJMH<T>([In] T PDKJBMPOMNC) where T : notnull
	{
		return default(KKOBOKGIKFE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E197A0", Offset = "0x3E181A0", VA = "0x183E197A0")]
	public static KKOBOKGIKFE<T?> NGHKEPEGKBA<T>()
	{
		return default(KKOBOKGIKFE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E19920", Offset = "0x3E18320", VA = "0x183E19920")]
	public static bool PGPEHBGBGIO<T>([In] this KKOBOKGIKFE<T> CFLDKJEEBDK, [Out][NotNullWhen(true)] T PDKJBMPOMNC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E198E0", Offset = "0x3E182E0", VA = "0x183E198E0")]
	public static bool PGPEHBGBGIO<T>([In] this KKOBOKGIKFE<T> CFLDKJEEBDK, [Out][NotNullWhen(true)] T PDKJBMPOMNC, [Out] KKOBOKGIKFE<T> BLBDGDFNKKJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E19440", Offset = "0x3E17E40", VA = "0x183E19440")]
	public static T? DEFEEGPDHPG<T>([In] this KKOBOKGIKFE<T> CFLDKJEEBDK, T? KKCMINIPIBD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E19300", Offset = "0x3E17D00", VA = "0x183E19300")]
	public static bool BDCGJBAPPOM<T>([In] this KKOBOKGIKFE<T> CFLDKJEEBDK, T PDKJBMPOMNC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CAIPEOJJIGP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A602B0", Offset = "0x3A5ECB0", VA = "0x183A602B0")]
	public static T FHBMDEGBIHC<T>([In] this KKOBOKGIKFE<T> CFLDKJEEBDK) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PMKOGEOMMNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr KHDFNJHNLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr BDNFHMDELMI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr APHEALJPCFO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr LPNOBNDJAHP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly PMKOGEOMMNE MFNPHNGAJMG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool OFLDDHIICNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x846D980", Offset = "0x846C380", VA = "0x18846D980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xC12020", Offset = "0xC10A20", VA = "0x180C12020")]
	public PMKOGEOMMNE(IntPtr GOAKPKCBMIM, IntPtr IKDMLKBNJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void OKKCNABJLNA(string FLBFBHGDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private static void JGAJNFFFCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x846DA60", Offset = "0x846C460", VA = "0x18846DA60")]
	private static PMKOGEOMMNE JBEHOJILMJG()
	{
		return default(PMKOGEOMMNE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct ABMEEOGJAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr ODHFOJIKDDC;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
	private ABMEEOGJAEL(IntPtr IKDMLKBNJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8461330", Offset = "0x845FD30", VA = "0x188461330")]
	public void MEOELJAGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8461250", Offset = "0x845FC50", VA = "0x188461250")]
	public static ABMEEOGJAEL MDDJOGPLAFO(string FLBFBHGDBLM)
	{
		return default(ABMEEOGJAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A611E0", Offset = "0x2A5FBE0", VA = "0x182A611E0")]
	public static ABMEEOGJAEL MDDJOGPLAFO([In] PMKOGEOMMNE LJPBGPPEICC, string FLBFBHGDBLM)
	{
		return default(ABMEEOGJAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A61360", Offset = "0x2A5FD60", VA = "0x182A61360")]
	public static ABMEEOGJAEL MDDJOGPLAFO([In] PMKOGEOMMNE LJPBGPPEICC, Func<string> FLBFBHGDBLM)
	{
		return default(ABMEEOGJAEL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CEJPLBGKPCD : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? AEAPFNDOFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr CPHPIPJGFFN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool FDECBHFLOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8462210", Offset = "0x8460C10", VA = "0x188462210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8462670", Offset = "0x8461070", VA = "0x188462670")]
	public static SHA256 OIDBKGGJJLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8461FF0", Offset = "0x84609F0", VA = "0x188461FF0")]
	private static extern int DHOBCPPMLOJ();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8461F80", Offset = "0x8460980", VA = "0x188461F80")]
	private static extern IntPtr DALKIHEEOLN();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84620F0", Offset = "0x8460AF0", VA = "0x1884620F0")]
	private static extern void EDIGLNCGKMH(IntPtr CPHPIPJGFFN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84625B0", Offset = "0x8460FB0", VA = "0x1884625B0")]
	private static extern void MABEJEFFLJI(IntPtr CPHPIPJGFFN, byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int FKJPIBEDLDO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8462170", Offset = "0x8460B70", VA = "0x188462170")]
	private static extern void FONPDLNJDLL(IntPtr CPHPIPJGFFN, byte[] LEPKFHJAEPL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84626F0", Offset = "0x84610F0", VA = "0x1884626F0")]
	private CEJPLBGKPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8462300", Offset = "0x8460D00", VA = "0x188462300", Slot = "18")]
	protected override void HashCore(byte[] JCEJMKLBKKB, int HCKBAEFBGJG, int LMAHKGKMLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84623C0", Offset = "0x8460DC0", VA = "0x1884623C0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84624F0", Offset = "0x8460EF0", VA = "0x1884624F0", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8462060", Offset = "0x8460A60", VA = "0x188462060", Slot = "13")]
	protected override void Dispose(bool OBPCNFJNFGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DGPLKDABALO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool DDGECLHMMED<in TInput, TResult>(TInput GMLILPJAKBM, [Out] TResult AEAMJGPOBKI);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class BPJLMLIBGFB : CCFNGOEOABH
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class LHLLMAECBLJ : OJBMHHPPBPB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly LHLLMAECBLJ NDAIDGNOFDA;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool CCPIHKOJBEH
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x846AE70", Offset = "0x8469870", VA = "0x18846AE70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x846AED0", Offset = "0x84698D0", VA = "0x18846AED0", Slot = "6")]
			public void OnCompleted(Action NGPADIEHCNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			public void NJEBOGFAOKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public LHLLMAECBLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly BPJLMLIBGFB NDAIDGNOFDA;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		private BPJLMLIBGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8461EB0", Offset = "0x84608B0", VA = "0x188461EB0", Slot = "4")]
		public OJBMHHPPBPB LBAHCCCMDNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class GABCBEGIGGE : CCFNGOEOABH
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class FBMDDNJOBAH : OJBMHHPPBPB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly FBMDDNJOBAH NDAIDGNOFDA;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool CCPIHKOJBEH
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x8467800", Offset = "0x8466200", VA = "0x188467800", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8467820", Offset = "0x8466220", VA = "0x188467820", Slot = "6")]
			public void OnCompleted(Action NGPADIEHCNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			public void NJEBOGFAOKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public FBMDDNJOBAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly GABCBEGIGGE NDAIDGNOFDA;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		private GABCBEGIGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8467B30", Offset = "0x8466530", VA = "0x188467B30", Slot = "4")]
		public OJBMHHPPBPB LBAHCCCMDNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GOFMPAPIIOI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GOFMPAPIIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4FBB910", Offset = "0x4FBA310", VA = "0x184FBB910")]
		internal void LCGCKNIIPGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PINAJDPHGAO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PINAJDPHGAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4499770", Offset = "0x4498170", VA = "0x184499770")]
		internal void APLBJELGEMO(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ABEOBFCOCLC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84610F0", Offset = "0x845FAF0", VA = "0x1884610F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DAFBDCNLEDI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8462F50", Offset = "0x8461950", VA = "0x188462F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EOICMKHBOMI<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4949020", Offset = "0x4947A20", VA = "0x184949020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4949190", Offset = "0x4947B90", VA = "0x184949190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HFONOKOOGCE<T> : IAsyncStateMachine where T : notnull
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
		public MEBJEIOEDLD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5041F70", Offset = "0x5040970", VA = "0x185041F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5042390", Offset = "0x5040D90", VA = "0x185042390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct CELJEAIJEJC<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6A34CA0", Offset = "0x6A336A0", VA = "0x186A34CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A350E0", Offset = "0x6A33AE0", VA = "0x186A350E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct MKIDKDPJBFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846C260", Offset = "0x846AC60", VA = "0x18846C260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x846C470", Offset = "0x846AE70", VA = "0x18846C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KJDJGGODEIP<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KJDJGGODEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4FBB910", Offset = "0x4FBA310", VA = "0x184FBB910")]
		internal void MHHCJJNHAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x54F8EF0", Offset = "0x54F78F0", VA = "0x1854F8EF0")]
		internal void EPBBBJPEDBN(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OHJMGGEBFJE<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public DDGECLHMMED<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A03B90", Offset = "0x5A02590", VA = "0x185A03B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A04280", Offset = "0x5A02C80", VA = "0x185A04280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DOIPJCNOKMA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8465BB0", Offset = "0x84645B0", VA = "0x188465BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x84663B0", Offset = "0x8464DB0", VA = "0x1884663B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct ALECAEJOCHD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8461340", Offset = "0x845FD40", VA = "0x188461340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8461890", Offset = "0x8460290", VA = "0x188461890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct BCOKPHDEFIL<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x64B3630", Offset = "0x64B2030", VA = "0x1864B3630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5121F60", Offset = "0x5120960", VA = "0x185121F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class IGLILJKINGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<FAIGCFGAAKD> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IGLILJKINGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x84694C0", Offset = "0x8467EC0", VA = "0x1884694C0")]
		internal void LPOCNFJIANF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NAJBBNHBFPO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846C9C0", Offset = "0x846B3C0", VA = "0x18846C9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x846CC40", Offset = "0x846B640", VA = "0x18846CC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HBPIPOIKNMM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x50048D0", Offset = "0x50032D0", VA = "0x1850048D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x446EC60", Offset = "0x446D660", VA = "0x18446EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OENJLFPPGKE<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x59FF170", Offset = "0x59FDB70", VA = "0x1859FF170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x446DD10", Offset = "0x446C710", VA = "0x18446DD10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct MDMOGIPDFOP<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5812050", Offset = "0x5810A50", VA = "0x185812050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5812860", Offset = "0x5811260", VA = "0x185812860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct EJPHBONLOKH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8467530", Offset = "0x8465F30", VA = "0x188467530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8467710", Offset = "0x8466110", VA = "0x188467710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct HJFLAIPPHIL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8468460", Offset = "0x8466E60", VA = "0x188468460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x84687D0", Offset = "0x84671D0", VA = "0x1884687D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct EGMBFEKPNND : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8466750", Offset = "0x8465150", VA = "0x188466750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8466A40", Offset = "0x8465440", VA = "0x188466A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class KKODJBOJAEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KKODJBOJAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x846AE00", Offset = "0x8469800", VA = "0x18846AE00")]
		internal Task NPKKKDNPKJK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct MFNMDNCFNNL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846BFA0", Offset = "0x846A9A0", VA = "0x18846BFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x846C200", Offset = "0x846AC00", VA = "0x18846C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct OEDMBEGDGGO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846D060", Offset = "0x846BA60", VA = "0x18846D060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x846D240", Offset = "0x846BC40", VA = "0x18846D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct MLMDNFAHOBH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846C4E0", Offset = "0x846AEE0", VA = "0x18846C4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x846C840", Offset = "0x846B240", VA = "0x18846C840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GPFOCGAKNGE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8467F90", Offset = "0x8466990", VA = "0x188467F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8468280", Offset = "0x8466C80", VA = "0x188468280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DFGHOELFKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DFGHOELFKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8463060", Offset = "0x8461A60", VA = "0x188463060")]
		internal Task FNENKAFCDCF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct EAOMCOEBKAE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8466410", Offset = "0x8464E10", VA = "0x188466410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8466670", Offset = "0x8465070", VA = "0x188466670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct NKMFGJLBCNM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846CCE0", Offset = "0x846B6E0", VA = "0x18846CCE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x846CE60", Offset = "0x846B860", VA = "0x18846CE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct CKOGFGNNKPG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6A486F0", Offset = "0x6A470F0", VA = "0x186A486F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A489B0", Offset = "0x6A473B0", VA = "0x186A489B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GOLHGDINMNO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8467C00", Offset = "0x8466600", VA = "0x188467C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8467F30", Offset = "0x8466930", VA = "0x188467F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? DMBEAGNOEBH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<FAIGCFGAAKD> PNLBBMHANNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task CHLDODPGEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8463130", Offset = "0x8461B30", VA = "0x188463130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8463F00", Offset = "0x8462900", VA = "0x188463F00")]
	public static bool HCIELINOKPA(this Task AIPCFMDLKCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE3B0", Offset = "0x3ABCDB0", VA = "0x183ABE3B0")]
	public static Task<T> OBOCPAOGKPL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8464000", Offset = "0x8462A00", VA = "0x188464000")]
	public static Task IJOIHBCDJBC(this Task AIPCFMDLKCK, CancellationToken DHNMCOFINFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC300", Offset = "0x3ABAD00", VA = "0x183ABC300")]
	public static Task<TResult> IJOIHBCDJBC<TResult>(this Task<TResult> AIPCFMDLKCK, CancellationToken DHNMCOFINFM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9FD0", Offset = "0x3AB89D0", VA = "0x183AB9FD0")]
	public static TaskCompletionSource<TResult> IJOIHBCDJBC<TResult>(this TaskCompletionSource<TResult> ALJABHEDHBP, CancellationToken DHNMCOFINFM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8463C80", Offset = "0x8462680", VA = "0x188463C80")]
	public static IDisposable? ENKNAPNMGEL(CancellationToken LANKPNJPBGD, CancellationToken GJNJFJJJGEP, [Out] CancellationToken HDNNFHNGPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8463BD0", Offset = "0x84625D0", VA = "0x188463BD0")]
	[AsyncStateMachine(typeof(ABEOBFCOCLC))]
	public static void DOPPOOPFAKM(this Task JCAFCJGCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8464E80", Offset = "0x8463880", VA = "0x188464E80")]
	[AsyncStateMachine(typeof(DAFBDCNLEDI))]
	public static void OCEDJGJIFJG(this Task JCAFCJGCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8FE0", Offset = "0x3AB79E0", VA = "0x183AB8FE0")]
	[AsyncStateMachine(typeof(EOICMKHBOMI<>))]
	public static Task AMKGLCBHJAF<TException>(this Task JCAFCJGCHAJ) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE030", Offset = "0x3ABCA30", VA = "0x183ABE030")]
	[AsyncStateMachine(typeof(HFONOKOOGCE<>))]
	public static Task<T> LCDICJNHGLO<T>(this Task<T> NLDLHIJAJBO, MEBJEIOEDLD HJHMNJLNNBM, Func<Task<T>, string> HNAJCAJBOPK, bool FLFFKOIIEPL = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDE70", Offset = "0x3ABC870", VA = "0x183ABDE70")]
	[AsyncStateMachine(typeof(CELJEAIJEJC<>))]
	public static Task<T> LCDICJNHGLO<T>(this Task<T> NLDLHIJAJBO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x84631A0", Offset = "0x8461BA0", VA = "0x1884631A0")]
	[AsyncStateMachine(typeof(MKIDKDPJBFC))]
	public static Task<TaskStatus> BOLNBPIGDFH(this Task? NLDLHIJAJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB90B0", Offset = "0x3AB7AB0", VA = "0x183AB90B0")]
	public static (Task<T?>?, Action<T?>?) FFGNIBIPFGO<T>([Optional] CancellationToken OMJKEHOJJFF)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDBB0", Offset = "0x3ABC5B0", VA = "0x183ABDBB0")]
	[AsyncStateMachine(typeof(OHJMGGEBFJE<, >))]
	public static Task<List<TResult>> IMMCPAKAKLN<TResult, TInput>(this Task<List<TInput>> AIPCFMDLKCK, DDGECLHMMED<TInput, TResult> OHDIBMHJKOC) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84633B0", Offset = "0x8461DB0", VA = "0x1884633B0")]
	[AsyncStateMachine(typeof(DOIPJCNOKMA))]
	public static Task CGAAEJGIPHF(Task JCAFCJGCHAJ, CancellationToken BOJKDJLCGKE, Func<CancellationToken, Task> MIFPMKCEDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8464B50", Offset = "0x8463550", VA = "0x188464B50")]
	[AsyncStateMachine(typeof(ALECAEJOCHD))]
	public static Task NJNOCKILEIA(Func<CancellationToken, Task> JIDFLIOODEF, TimeSpan LCCCJECCOIL, [Optional] CancellationToken BOJKDJLCGKE, [Optional] Action<OperationCanceledException>? KHFLBKGMAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE150", Offset = "0x3ABCB50", VA = "0x183ABE150")]
	[AsyncStateMachine(typeof(BCOKPHDEFIL<>))]
	public static Task<T> NJNOCKILEIA<T>(Func<CancellationToken, Task<T>> JIDFLIOODEF, TimeSpan LCCCJECCOIL, [Optional] CancellationToken BOJKDJLCGKE, [Optional] Func<OperationCanceledException, T>? KHFLBKGMAAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8463B80", Offset = "0x8462580", VA = "0x188463B80")]
	public static Task DKCCLLKMGOC(params Task[] KJEFIMLGNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84636C0", Offset = "0x84620C0", VA = "0x1884636C0")]
	public static Task DKCCLLKMGOC(IEnumerable<Task> KJEFIMLGNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84646D0", Offset = "0x84630D0", VA = "0x1884646D0")]
	[AsyncStateMachine(typeof(NAJBBNHBFPO))]
	public static Task<IEnumerable<Task>> KDJACLPMGFL(IEnumerable<Task> KJEFIMLGNLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDD90", Offset = "0x3ABC790", VA = "0x183ABDD90")]
	[AsyncStateMachine(typeof(HBPIPOIKNMM<>))]
	public static Task<IEnumerable<Task<T>>> KDJACLPMGFL<T>(IEnumerable<Task<T>> KJEFIMLGNLK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE7C0", Offset = "0x3ABD1C0", VA = "0x183ABE7C0")]
	[AsyncStateMachine(typeof(OENJLFPPGKE<, , >))]
	public static Task<(T1, T2, T3)> PIFDFEJFHIL<T1, T2, T3>(Task<T1> OCLKGFBODOL, Task<T2> GCMANBFJCIM, Task<T3> OCOOBCEBFNL) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE500", Offset = "0x3ABCF00", VA = "0x183ABE500")]
	[AsyncStateMachine(typeof(MDMOGIPDFOP<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> PIFDFEJFHIL<T1, T2, T3, T4, T5>(Task<T1> OCLKGFBODOL, Task<T2> GCMANBFJCIM, Task<T3> OCOOBCEBFNL, Task<T4> LLCPBGAEHLI, Task<T5> IGEEBAPGIJI) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8464C80", Offset = "0x8463680", VA = "0x188464C80")]
	[AsyncStateMachine(typeof(EJPHBONLOKH))]
	public static Task OAFMGOLKOIJ(Func<bool> JOPBOJCEAIO, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8464D70", Offset = "0x8463770", VA = "0x188464D70")]
	[AsyncStateMachine(typeof(HJFLAIPPHIL))]
	public static Task OAFMGOLKOIJ(Func<bool> JOPBOJCEAIO, TimeSpan NDKOENOONNP, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8464460", Offset = "0x8462E60", VA = "0x188464460")]
	[AsyncStateMachine(typeof(EGMBFEKPNND))]
	public static Task JNLJDIJBBDK(Func<bool> JOPBOJCEAIO, TimeSpan LCCCJECCOIL, [Optional] CancellationToken OMJKEHOJJFF, [Optional] Action<OperationCanceledException>? KHFLBKGMAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8464590", Offset = "0x8462F90", VA = "0x188464590")]
	[AsyncStateMachine(typeof(MFNMDNCFNNL))]
	public static Task JNLJDIJBBDK(Func<bool> JOPBOJCEAIO, TimeSpan LCCCJECCOIL, TimeSpan NDKOENOONNP, [Optional] CancellationToken OMJKEHOJJFF, [Optional] Action<OperationCanceledException>? KHFLBKGMAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8464370", Offset = "0x8462D70", VA = "0x188464370")]
	[AsyncStateMachine(typeof(OEDMBEGDGGO))]
	public static Task JAMFPNBPPAP(Func<bool> JOPBOJCEAIO, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8464260", Offset = "0x8462C60", VA = "0x188464260")]
	[AsyncStateMachine(typeof(MLMDNFAHOBH))]
	public static Task JAMFPNBPPAP(Func<bool> JOPBOJCEAIO, TimeSpan NDKOENOONNP, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8464F30", Offset = "0x8463930", VA = "0x188464F30")]
	[AsyncStateMachine(typeof(GPFOCGAKNGE))]
	public static Task OOHFGCOOBEE(Func<bool> JOPBOJCEAIO, TimeSpan LCCCJECCOIL, [Optional] CancellationToken OMJKEHOJJFF, [Optional] Action<OperationCanceledException>? KHFLBKGMAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8465060", Offset = "0x8463A60", VA = "0x188465060")]
	[AsyncStateMachine(typeof(EAOMCOEBKAE))]
	public static Task OOHFGCOOBEE(Func<bool> JOPBOJCEAIO, TimeSpan LCCCJECCOIL, TimeSpan NDKOENOONNP, [Optional] CancellationToken OMJKEHOJJFF, [Optional] Action<OperationCanceledException>? KHFLBKGMAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8463E10", Offset = "0x8462810", VA = "0x188463E10")]
	[AsyncStateMachine(typeof(NKMFGJLBCNM))]
	[Obsolete]
	public static Task GFNIELGJJIP(this Task AIPCFMDLKCK, Action NOKPMNBNPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB92F0", Offset = "0x3AB7CF0", VA = "0x183AB92F0")]
	[AsyncStateMachine(typeof(CKOGFGNNKPG<>))]
	[Obsolete]
	public static Task GFNIELGJJIP<T>(this Task<T> AIPCFMDLKCK, Action<T> NOKPMNBNPGC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84651A0", Offset = "0x8463BA0", VA = "0x1884651A0")]
	private static void OPNGMGPNOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84647D0", Offset = "0x84631D0", VA = "0x1884647D0")]
	public static bool MOKCFFHAIFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8463530", Offset = "0x8461F30", VA = "0x188463530")]
	private static void DJANOANACIA(SynchronizationContext PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8463290", Offset = "0x8461C90", VA = "0x188463290")]
	private static void CAAIICPOLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8465250", Offset = "0x8463C50", VA = "0x188465250")]
	public static void PDJMCBBCPKE([Optional] string? ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8463F80", Offset = "0x8462980", VA = "0x188463F80")]
	public static void IIEEJMCBMCI([Optional] string? ONGDPODJNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8463F30", Offset = "0x8462930", VA = "0x188463F30")]
	public static CCFNGOEOABH HPCJDKIBIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84634E0", Offset = "0x8461EE0", VA = "0x1884634E0")]
	public static CCFNGOEOABH CKLCJLPONLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8465320", Offset = "0x8463D20", VA = "0x188465320")]
	[AsyncStateMachine(typeof(GOLHGDINMNO))]
	public static Task PLELGPIHBMJ(Func<Task> JENFFPGIJNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class IHCCCAONNEJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public IHCCCAONNEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FGPGJHGNAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x84678F0", Offset = "0x84662F0", VA = "0x1884678F0")]
	public static bool FDHFKNGBKEJ(this HNGFBLOEPPO JMIIDKAGFJN, DateTime DEOGIIBHKCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8467A10", Offset = "0x8466410", VA = "0x188467A10")]
	public static TimeSpan HACBGFILLOP(this HNGFBLOEPPO JMIIDKAGFJN, DateTime DEOGIIBHKCL)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MOPNOMCDDNF : HNGFBLOEPPO
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly HNGFBLOEPPO NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime DKGIFMHPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x846C8A0", Offset = "0x846B2A0", VA = "0x18846C8A0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset FBDCGJLFAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x846C8E0", Offset = "0x846B2E0", VA = "0x18846C8E0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public MOPNOMCDDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface HNGFBLOEPPO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime DKGIFMHPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset FBDCGJLFAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class CKDEPEGGPPE
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long AHHJKKJLGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8462B30", Offset = "0x8461530", VA = "0x188462B30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long ALCJIJMGPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x84627B0", Offset = "0x84611B0", VA = "0x1884627B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double GKHNEOEAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8462B80", Offset = "0x8461580", VA = "0x188462B80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double CNKGPEBFNBE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8462BD0", Offset = "0x84615D0", VA = "0x188462BD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double OEJHOEFCHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8462800", Offset = "0x8461200", VA = "0x188462800")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double JMFGIAKBMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8462850", Offset = "0x8461250", VA = "0x188462850")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x84628A0", Offset = "0x84612A0", VA = "0x1884628A0")]
	public static double IHPJGCAHKIP(long BAEJJCFEBFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8462720", Offset = "0x8461120", VA = "0x188462720")]
	public static double CBCAPDNLHEJ(long BAEJJCFEBFD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8462930", Offset = "0x8461330", VA = "0x188462930")]
	public static double IPIKCABIAHP(double PLJANBLDHJN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x84629C0", Offset = "0x84613C0", VA = "0x1884629C0")]
	public static long KNKFJKEIPLA(long NMPFLEBOLHH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8462B20", Offset = "0x8461520", VA = "0x188462B20")]
	public static long LPGPDICCBPE(long MIBHAGKGFEI, long DGJKCGMEADM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8462A50", Offset = "0x8461450", VA = "0x188462A50")]
	public static double LCJDOELOKJF(long MIBHAGKGFEI, long DGJKCGMEADM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8462C20", Offset = "0x8461620", VA = "0x188462C20")]
	public static double PKAFAEDBHFI(long MIBHAGKGFEI, long DGJKCGMEADM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class DIFMLDEEADM : EELAOLEHAFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan LLCOMPLNACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer HIBNALIEBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan LCCCJECCOIL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan IJEGPHKMIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8465580", Offset = "0x8463F80", VA = "0x188465580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? GKDNDPNIHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x84658F0", Offset = "0x84642F0", VA = "0x1884658F0")]
	[Preserve]
	public DIFMLDEEADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8465960", Offset = "0x8464360", VA = "0x188465960")]
	public DIFMLDEEADM(TimeSpan LCCCJECCOIL, [Optional] Action? JHFHHIMMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x84657F0", Offset = "0x84641F0", VA = "0x1884657F0", Slot = "7")]
	public void GMHPCBOPLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x84656E0", Offset = "0x84640E0", VA = "0x1884656E0", Slot = "8")]
	public void EPCDMBGDLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x84654B0", Offset = "0x8463EB0", VA = "0x1884654B0", Slot = "9")]
	public void AHOFHALOFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x12E6990", Offset = "0x12E5390", VA = "0x1812E6990")]
	private void JBMLOMOCCEJ(object GIGDEGEMDAC, ElapsedEventArgs MILJAGBBJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8465750", Offset = "0x8464150", VA = "0x188465750")]
	private static void GFCNKCFNELD(TimeSpan APOGFIDPDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x84654E0", Offset = "0x8463EE0", VA = "0x1884654E0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class JOAGOPIPNIM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? JADAEBBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string LHKEDLABPNK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1935330", Offset = "0x1933D30", VA = "0x181935330")]
	public JOAGOPIPNIM(string IGEOMPONAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0270", Offset = "0x4ECEC70", VA = "0x184ED0270")]
	public JOAGOPIPNIM(string FLFLJCMPPBA, string IGEOMPONAKK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LOALHEIKMIM : IEquatable<LOALHEIKMIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint CKBENBCBMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int DFPKIHMIOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float FMGHMFLDPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort CGHMACOHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort PNJLLHLMAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short JPJJHLKOBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short ODMNFNMLCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char LIALPGMOGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char EPJHMOHJIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte BMHFKEELECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte LKJNKCIFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte IFHJJMMNGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte CLKOBKLEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool PODJMBCBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool NKIHMKAJOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool GBMGAILGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool LJPNJOKBBIG;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2120A70", Offset = "0x211F470", VA = "0x182120A70")]
	public static LOALHEIKMIM KKAPMJEHDJB(uint HJEIMNKAFEP)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2120A70", Offset = "0x211F470", VA = "0x182120A70")]
	public static LOALHEIKMIM LGPMPPBNLNI(int OIIEJHDCLKL)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x846B0B0", Offset = "0x8469AB0", VA = "0x18846B0B0")]
	public static LOALHEIKMIM DBNABAGKNFG(float MEKJEIHKKAM)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x846B0C0", Offset = "0x8469AC0", VA = "0x18846B0C0")]
	public static LOALHEIKMIM DLLDJBGMPLL(byte DCOCHFEOCGD, byte GFDJNFEGFGG, byte ILNPOIGJOLB, byte AFMPGGNNBLM)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x846B0C0", Offset = "0x8469AC0", VA = "0x18846B0C0")]
	public static LOALHEIKMIM MGILCNFIOHJ(bool AJAAOKFDAPL, bool LAKOIHEBFBL, bool POJBFBCJMLM, bool BJJPGOBIFMK)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x846B0C0", Offset = "0x8469AC0", VA = "0x18846B0C0")]
	public static LOALHEIKMIM EJOOOCEBOPC(byte GFIDLNHNDIG, byte MKBCOGBKGKP, byte ECNDFCILPDN, byte IIMDGFCCJHM)
	{
		return default(LOALHEIKMIM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x245F310", Offset = "0x245DD10", VA = "0x18245F310")]
	public static bool JJNADAGGMDE(LOALHEIKMIM HEOFBNHHDGF, LOALHEIKMIM HEGCIIKIHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x245F210", Offset = "0x245DC10", VA = "0x18245F210", Slot = "4")]
	public bool Equals(LOALHEIKMIM EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x846B0E0", Offset = "0x8469AE0", VA = "0x18846B0E0", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x15654F0", Offset = "0x1563EF0", VA = "0x1815654F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x846B160", Offset = "0x8469B60", VA = "0x18846B160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct MCFHADCOEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong OAMKFKPMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long ONEHMHPLCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double PLKPCKLOFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint HOLKOPMPIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint CANMKPDFDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int CLLACHBDPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int OMMGNKNDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float JACECIEFLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float JMADNFOIGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort CGHMACOHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort PNJLLHLMAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort AIKFBGLFOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort BFFPEPDKMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short JPJJHLKOBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short ODMNFNMLCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short CEHALIGOGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short CJDABCGDNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char LIALPGMOGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char EPJHMOHJIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char MIGHGAIJIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char COEPMCBIGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte BMHFKEELECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte LKJNKCIFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte IFHJJMMNGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte CLKOBKLEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte BMJJMNKIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte BGGGPFHGLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte FBBHIIPBPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte CHDKDMDDFAI;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static MCFHADCOEHG MDDJOGPLAFO(long LPFENNHPCCI)
	{
		return default(MCFHADCOEHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x846BF50", Offset = "0x846A950", VA = "0x18846BF50")]
	public static MCFHADCOEHG MDDJOGPLAFO(byte DCOCHFEOCGD, byte GFDJNFEGFGG, byte ILNPOIGJOLB, byte AFMPGGNNBLM, byte OGCAKFGLOEE, byte CIDMEPCHKJN, byte EOGKBMCDINO, byte OEECMLCDJFN)
	{
		return default(MCFHADCOEHG);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct OOMEIKKONEO : IEquatable<OOMEIKKONEO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte GIAHNEIJPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool OPLOMCKLFEO;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x31A14A0", Offset = "0x319FEA0", VA = "0x1831A14A0")]
	public static OOMEIKKONEO DLLDJBGMPLL(byte FIFONJGBOGB)
	{
		return default(OOMEIKKONEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x31A14A0", Offset = "0x319FEA0", VA = "0x1831A14A0")]
	public static OOMEIKKONEO MGILCNFIOHJ(bool MPPIEBICBPH)
	{
		return default(OOMEIKKONEO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x846D710", Offset = "0x846C110", VA = "0x18846D710")]
	public static bool JJNADAGGMDE(OOMEIKKONEO HEOFBNHHDGF, OOMEIKKONEO HEGCIIKIHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x731A330", Offset = "0x7318D30", VA = "0x18731A330", Slot = "4")]
	public bool Equals(OOMEIKKONEO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x846D670", Offset = "0x846C070", VA = "0x18846D670", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x846D700", Offset = "0x846C100", VA = "0x18846D700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x846D720", Offset = "0x846C120", VA = "0x18846D720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class MINGBNPGHHK<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T DNEMLCNIJLH;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x582ACA0", Offset = "0x58296A0", VA = "0x18582ACA0")]
	public MINGBNPGHHK(T KNJCNNOIALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class NCILJKHKCFF
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB6790", Offset = "0x3AB5190", VA = "0x183AB6790")]
	public static IEnumerable<T> GIGHMAINBCH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static T[] EFECAHBOPHN<T>(params T[] FAIMCJGOAPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static IEnumerable<T> DNNCPGLMMNI<T>(params T[] FAIMCJGOAPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static HashSet<T> BOCEIAGINEE<T>(params T[] FAIMCJGOAPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3E10AB0", Offset = "0x3E0F4B0", VA = "0x183E10AB0")]
	public static KeyValuePair<TKey, TValue> HKAPKPFCNFG<TKey, TValue>([In] TKey LNBCHJPEENA, [In] TValue PDKJBMPOMNC) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3C75FA0", Offset = "0x3C749A0", VA = "0x183C75FA0")]
	public static List<T> MIODPEEMNOM<T>(IEnumerable<T> AKIPGEFJGDO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class EBBKLOFNCPM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string HGJBCKNHIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
	public EBBKLOFNCPM(string GHCLINPMECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object LKFJPKMAOPA<T>([In] T GACFFBLMJOF);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object EEPICLBJPOB<T>(T GACFFBLMJOF);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[IKNKEAIJPFL]
public delegate string KFDPGHENDGP(string OJCMLFFIJFF, string? OLLJNINDADG, bool GJIOPFNKCKC);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[IKNKEAIJPFL]
public delegate void IIDBHHFOGKA(string ONGDPODJNBL);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IKNKEAIJPFL]
public delegate void GDKIAKCABEL(Exception HPIGFEEDBKD);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object IBNHAOALLDE();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[IKNKEAIJPFL]
public delegate bool JPHNLBLLKBO();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[IKNKEAIJPFL]
public delegate string JJIGHNHKEEB(object CEFJEHJNIAP);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class GFAGIBNIGGE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
	public GFAGIBNIGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class AAPDHCAKHPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct KGPKBMOPOJK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x846A4A0", Offset = "0x8468EA0", VA = "0x18846A4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x846AD90", Offset = "0x8469790", VA = "0x18846AD90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback ACGKKFNBMCA;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> EHNOOIGGMEC;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8460A80", Offset = "0x845F480", VA = "0x188460A80")]
	public static Task<bool> BPFDAEPAIIN(int IHPDIEOHFLK, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8460D90", Offset = "0x845F790", VA = "0x188460D90")]
	[AsyncStateMachine(typeof(KGPKBMOPOJK))]
	private static Task<bool> GLJDPAJCPPK(int IHPDIEOHFLK, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8460EC0", Offset = "0x845F8C0", VA = "0x188460EC0")]
	private static void KAFGGLGOEFK(object? BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8460F50", Offset = "0x845F950", VA = "0x188460F50")]
	private static void LIONEIHDDHM(object? BLKFHFCBEDC)
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
