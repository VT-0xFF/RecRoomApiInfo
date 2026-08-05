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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D82280", Offset = "0x7D81280", VA = "0x187D82280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KJBPMOEEKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D80A40", Offset = "0x7D7FA40", VA = "0x187D80A40")]
	public static string LEEDJCCMEMN(this Encoding FDLEBGPAJEJ, [In] ReadOnlySequence<byte> ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38EBBE0", Offset = "0x38EABE0", VA = "0x1838EBBE0")]
	private static void BCPOOADILDI<T>(this ReadOnlySequence<T> NFKNDNEHMAF, [Out] ReadOnlySpan<T> EBHJAAHLIDP, [Out] SequencePosition IACIPAIGMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LPGLPFHKCBI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D812D0", Offset = "0x7D802D0", VA = "0x187D812D0")]
	public LPGLPFHKCBI(bool CAAALHFPCAI, string AIKKFHNDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D81280", Offset = "0x7D80280", VA = "0x187D81280")]
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
		[Cpp2IlInjected.Address(RVA = "0xA0E750", Offset = "0xA0D750", VA = "0x180A0E750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double PIDJCBBHANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D80140", Offset = "0x7D7F140", VA = "0x187D80140", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OAKLBKNNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A5D0", Offset = "0x4E795D0", VA = "0x184E7A5D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double INMGPHGEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x270C3F0", Offset = "0x270B3F0", VA = "0x18270C3F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D801A0", Offset = "0x7D7F1A0", VA = "0x187D801A0")]
	public JDIBNENMGGC(int FAIHGMPNCBA, double OECEKBMHBFE = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D7FFA0", Offset = "0x7D7EFA0", VA = "0x187D7FFA0", Slot = "7")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D800D0", Offset = "0x7D7F0D0", VA = "0x187D800D0", Slot = "8")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7D7FEA0", Offset = "0x7D7EEA0", VA = "0x187D7FEA0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OAKLBKNNIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7030D40", Offset = "0x702FD40", VA = "0x187030D40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double INMGPHGEKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7030D30", Offset = "0x702FD30", VA = "0x187030D30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FHLDGDOIBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7030D50", Offset = "0x702FD50", VA = "0x187030D50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double PIDJCBBHANB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DE72B0", Offset = "0x2DE62B0", VA = "0x182DE72B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D78CE0", Offset = "0x7D77CE0", VA = "0x187D78CE0", Slot = "10")]
	public virtual void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E00", Offset = "0x7D77E00", VA = "0x187D78E00", Slot = "11")]
	public virtual void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D78C70", Offset = "0x7D77C70", VA = "0x187D78C70", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E40", Offset = "0x7D77E40", VA = "0x187D78E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7030CC0", Offset = "0x702FCC0", VA = "0x187030CC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7030CF0", Offset = "0x702FCF0", VA = "0x187030CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D813B0", Offset = "0x7D803B0", VA = "0x187D813B0", Slot = "10")]
	public override void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D814E0", Offset = "0x7D804E0", VA = "0x187D814E0", Slot = "11")]
	public override void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E40", Offset = "0x7D77E40", VA = "0x187D78E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D84F30", Offset = "0x7D83F30", VA = "0x187D84F30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CDAB20", Offset = "0x7CD9B20", VA = "0x187CDAB20", Slot = "4")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D84F40", Offset = "0x7D83F40", VA = "0x187D84F40", Slot = "5")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D84EE0", Offset = "0x7D83EE0", VA = "0x187D84EE0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x455EE70", Offset = "0x455DE70", VA = "0x18455EE70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x53913C0", Offset = "0x53903C0", VA = "0x1853913C0", Slot = "4")]
	public void IBJIMKGMFAK(double GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E650", Offset = "0x7D7D650", VA = "0x187D7E650", Slot = "5")]
	public void KGPJOLOPJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E600", Offset = "0x7D7D600", VA = "0x187D7E600", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x61AC070", Offset = "0x61AB070", VA = "0x1861AC070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61AD180", Offset = "0x61AC180", VA = "0x1861AD180", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x50B37E0", Offset = "0x50B27E0", VA = "0x1850B37E0")]
	[AsyncStateMachine(typeof(LBFDKGKNEBG<>.BCGMKJFDEDG))]
	public Task<TResult> LKIEBKPIJOF(GHBHBEPOKLL HBFHHJFANBG, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x50B3770", Offset = "0x50B2770", VA = "0x1850B3770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x50B3930", Offset = "0x50B2930", VA = "0x1850B3930")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A94420", Offset = "0x4A93420", VA = "0x184A94420")]
	public GMOLLFIOBBC([In] T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A93580", Offset = "0x4A92580", VA = "0x184A93580", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A93AD0", Offset = "0x4A92AD0", VA = "0x184A93AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A93FF0", Offset = "0x4A92FF0", VA = "0x184A93FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LLLCPPLPFDL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
	public static GMOLLFIOBBC<T> ACADPGMDEBE<T>([In] T OHLIHBDBKCE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FHKGLDHHOFF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D7DC80", Offset = "0x7D7CC80", VA = "0x187D7DC80")]
	public static void HEODPPLAKOL(this CancellationTokenSource CLDKCMPEHDC, bool NFABGGIKPKJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class JGDLMDOFCHA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public JGDLMDOFCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MAKNJFCMNJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public MAKNJFCMNJF(string OKEMKFHOKHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BGIHHGJBJJP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35C2200", Offset = "0x35C1200", VA = "0x1835C2200")]
	public static LOECJBACHMA NBLHDGPNMBH<T>()
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35C2450", Offset = "0x35C1450", VA = "0x1835C2450")]
	public static LOECJBACHMA NBMDBKABAKM<T>([CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35C2280", Offset = "0x35C1280", VA = "0x1835C2280")]
	public static LOECJBACHMA NBLHDGPNMBH<T>(this T COFBNOFIHKI) where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35C20B0", Offset = "0x35C10B0", VA = "0x1835C20B0")]
	public static LOECJBACHMA LOBKOJBGGLL<T>(this T COFBNOFIHKI, [CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35C24F0", Offset = "0x35C14F0", VA = "0x1835C24F0")]
	public static LOECJBACHMA NBMDBKABAKM<T>(this T OCACDKEJIIB, [CallerMemberName] string NFHOBPDKIPM = "") where T : notnull
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A150", Offset = "0x7D79150", VA = "0x187D7A150")]
	public static LOECJBACHMA NBMDBKABAKM(string IKGOKFOKHEB, [CallerMemberName] string NFHOBPDKIPM = "")
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A0B0", Offset = "0x7D790B0", VA = "0x187D7A0B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D84B00", Offset = "0x7D83B00", VA = "0x187D84B00")]
		get
		{
			return default(FNBCFEJPHNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EHAADHBFEAM LAMACDECCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D84940", Offset = "0x7D83940", VA = "0x187D84940")]
		get
		{
			return default(EHAADHBFEAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NEPIHMACEAF NPLDJICFOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7D84DD0", Offset = "0x7D83DD0", VA = "0x187D84DD0")]
		get
		{
			return default(NEPIHMACEAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool EKILDLGJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7D84990", Offset = "0x7D83990", VA = "0x187D84990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7D846C0", Offset = "0x7D836C0", VA = "0x187D846C0")]
	public static void BODCAGEIIMC([In] FNBCFEJPHNA LPELJKFNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D84580", Offset = "0x7D83580", VA = "0x187D84580")]
	public static void AHIMDJPCPBN(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D84870", Offset = "0x7D83870", VA = "0x187D84870")]
	public static void DHIFPOPFCLO(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x39C96B0", Offset = "0x39C86B0", VA = "0x1839C96B0")]
	public static void DHIFPOPFCLO<T>(T GIOLPIPFPPJ, MIAHIJJOJBN<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D84B50", Offset = "0x7D83B50", VA = "0x187D84B50")]
	public static void KCOJMKBBKEL(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D84A00", Offset = "0x7D83A00", VA = "0x187D84A00")]
	public static void FPDKFGADAIA(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D84BF0", Offset = "0x7D83BF0", VA = "0x187D84BF0")]
	public static void KDAGONIHHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D84A80", Offset = "0x7D83A80", VA = "0x187D84A80")]
	public static string GGDPAGAAIFJ(object BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D84650", Offset = "0x7D83650", VA = "0x187D84650")]
	public static long BAMFJDHCHAN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D84D30", Offset = "0x7D83D30", VA = "0x187D84D30")]
	public static bool NHFGNGLOMIB(bool BELPALHENKI, string NAAMEAFIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C60", Offset = "0x7D83C60", VA = "0x187D84C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7E7B0", Offset = "0x7D7D7B0", VA = "0x187D7E7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F040", Offset = "0x7D7E040", VA = "0x187D7F040")]
	public FNBCFEJPHNA([In] EHAADHBFEAM AMKBPOJJCOD, [In] NEPIHMACEAF HNLHGBPMMHG, MLOHCMBFEOP OANAGHPKPKL, DANGJHHNPGG FNDPHKNCAIN, ILJKKFDKAHE NKCFLJCLIHE, NMLIJJKMNLJ FCIBPFDBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E660", Offset = "0x7D7D660", VA = "0x187D7E660")]
	private static string FCIMHPGOEAB(object BOMDCGFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	private static long IAHCLIDADIF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	private static string APOCCMIALFI(string ANKDPLMACBD, string? MJMGMHHAAHB, bool GMEMNKBLNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	private static bool CBONBNNLOEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D7E6A0", Offset = "0x7D7D6A0", VA = "0x187D7E6A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4975260", Offset = "0x4974260", VA = "0x184975260")]
	public FKGDJNIBAEN([In] T OHLIHBDBKCE, int OHHMJGCBCKD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4973F90", Offset = "0x4972F90", VA = "0x184973F90")]
	public static bool MMJMCICIDNJ([In] FKGDJNIBAEN<T> JOOBCOFNIAM, [In] FKGDJNIBAEN<T> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4973900", Offset = "0x4972900", VA = "0x184973900", Slot = "4")]
	public bool Equals(FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4973870", Offset = "0x4972870", VA = "0x184973870", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4973740", Offset = "0x4972740", VA = "0x184973740")]
	public bool DJLLIPJENJL([In] FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4973B80", Offset = "0x4972B80", VA = "0x184973B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4974AA0", Offset = "0x4973AA0", VA = "0x184974AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4973200", Offset = "0x4972200", VA = "0x184973200")]
	public void BGDNOIMKKGE([Out] T OHLIHBDBKCE, [Out] int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4974540", Offset = "0x4973540", VA = "0x184974540")]
	public (T, int) OLNMFLOGPBC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x49744F0", Offset = "0x49734F0", VA = "0x1849744F0", Slot = "5")]
	private bool NGOHBPOGKLP([In] FKGDJNIBAEN<T> MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BEOPFBPFNPC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x35C0890", Offset = "0x35BF890", VA = "0x1835C0890")]
	public static FKGDJNIBAEN<T> ACADPGMDEBE<T>([In] T OHLIHBDBKCE, int OHHMJGCBCKD) where T : notnull
	{
		return default(FKGDJNIBAEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MPCAICHJJIN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x392A0A0", Offset = "0x39290A0", VA = "0x18392A0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7C4E0", Offset = "0x7D7B4E0", VA = "0x187D7C4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD615E0", Offset = "0xD605E0", VA = "0x180D615E0")]
	public EHAADHBFEAM(DJMDDLNHOOH OCGNPIDGBOK, IGMBFBEPAIF NAOFJPHAIMF, DJMDDLNHOOH KKFPLOBDBBH, IGMBFBEPAIF PCPOFIKIIFH, DJMDDLNHOOH LDFEGCHMAHL, IGMBFBEPAIF DAHKAIMFFFA, PHGMMJPLHDI MINGJJNFCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	private static bool HFLINEIAKBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void IAMNPCICLII(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	private static bool DDGNDOOHPID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void MBDBGDKCKDB(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820")]
	private static bool NJDHFHPMALB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BAECHLGNLIP(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void MGLDMCHIDMI(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C2D0", Offset = "0x7D7B2D0", VA = "0x187D7C2D0")]
	private static EHAADHBFEAM FGFFHJFPMHM()
	{
		return default(EHAADHBFEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
	private static bool HDEJBIJCDOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C0A0", Offset = "0x7D7B0A0", VA = "0x187D7C0A0")]
	public void AHIMDJPCPBN(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C260", Offset = "0x7D7B260", VA = "0x187D7C260")]
	public void EFJIAFKNFDE(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C110", Offset = "0x7D7B110", VA = "0x187D7C110")]
	public void DHIFPOPFCLO(object NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xD56C20", Offset = "0xD55C20", VA = "0x180D56C20")]
	public void KCOJMKBBKEL(Exception APEPCFJIAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C180", Offset = "0x7D7B180", VA = "0x187D7C180")]
	public void DHIFPOPFCLO(CDMFCCAOLJN NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x36DEA70", Offset = "0x36DDA70", VA = "0x1836DEA70")]
	public void DHIFPOPFCLO<T>(T GIOLPIPFPPJ, MIAHIJJOJBN<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x36DE660", Offset = "0x36DD660", VA = "0x1836DE660")]
	public void AHIMDJPCPBN<T>([In] T GIOLPIPFPPJ, LOKDMMKJOIC<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x36DE800", Offset = "0x36DD800", VA = "0x1836DE800")]
	public void DHIFPOPFCLO<T>([In] T GIOLPIPFPPJ, LOKDMMKJOIC<T> NAAMEAFIHJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C410", Offset = "0x7D7B410", VA = "0x187D7C410")]
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
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	public LOECJBACHMA(string OHLIHBDBKCE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9C0", Offset = "0xCFE9C0", VA = "0x180CFF9C0")]
	public static string OIFHDJNIHDL([In] LOECJBACHMA OCACDKEJIIB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2289070", Offset = "0x2288070", VA = "0x182289070")]
	public static LOECJBACHMA OIFHDJNIHDL(string MIJLJBIHDMP)
	{
		return default(LOECJBACHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7D81230", Offset = "0x7D80230", VA = "0x187D81230")]
	public string JPBKKMBKMOL(string AMDHAEEMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7D81150", Offset = "0x7D80150", VA = "0x187D81150")]
	public string BECLJNFPGEH(object JFCMAFFDJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9C0", Offset = "0xCFE9C0", VA = "0x180CFF9C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public IPFMAEIIMGH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BONGKMFJEJA : IEquatable<BONGKMFJEJA>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "4")]
	public bool Equals(BONGKMFJEJA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AC60", Offset = "0x7D79C60", VA = "0x187D7AC60", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACB0", Offset = "0x7D79CB0", VA = "0x187D7ACB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACC0", Offset = "0x7D79CC0", VA = "0x187D7ACC0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AEA080", Offset = "0x4AE9080", VA = "0x184AEA080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4AEB120", Offset = "0x4AEA120", VA = "0x184AEB120")]
	public HHIMBEIEIME([In] T OHLIHBDBKCE, bool LHPCJNJIGBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4AEA090", Offset = "0x4AE9090", VA = "0x184AEA090")]
	public static bool MMJMCICIDNJ([In] HHIMBEIEIME<T> JOOBCOFNIAM, [In] HHIMBEIEIME<T> MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8CC0", Offset = "0x4AE7CC0", VA = "0x184AE8CC0", Slot = "4")]
	public bool Equals(HHIMBEIEIME<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8EF0", Offset = "0x4AE7EF0", VA = "0x184AE8EF0", Slot = "0")]
	public override bool Equals(object? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4AE9F20", Offset = "0x4AE8F20", VA = "0x184AE9F20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4AEA7F0", Offset = "0x4AE97F0", VA = "0x184AEA7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DHNJNCDDCFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x36966E0", Offset = "0x36956E0", VA = "0x1836966E0")]
	public static HHIMBEIEIME<T> OGGBJDHCODH<T>([In] T OHLIHBDBKCE) where T : notnull
	{
		return default(HHIMBEIEIME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3696400", Offset = "0x3695400", VA = "0x183696400")]
	public static HHIMBEIEIME<T?> JAJLEBKKLPI<T>()
	{
		return default(HHIMBEIEIME<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3696200", Offset = "0x3695200", VA = "0x183696200")]
	public static bool AMJMHFCFGDN<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, [Out][NotNullWhen(true)] T OHLIHBDBKCE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3696190", Offset = "0x3695190", VA = "0x183696190")]
	public static bool AMJMHFCFGDN<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, [Out][NotNullWhen(true)] T OHLIHBDBKCE, [Out] HHIMBEIEIME<T> KEGPEOFCCOA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3696130", Offset = "0x3695130", VA = "0x183696130")]
	public static T? AJHDBFHCDIP<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, T? JMMNJNFGHEP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3696480", Offset = "0x3695480", VA = "0x183696480")]
	public static bool OFFIOFLGDKP<T>([In] this HHIMBEIEIME<T> EHBCKAPHBII, T OHLIHBDBKCE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ANAHMFEKJCN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E930", Offset = "0x3F6D930", VA = "0x183F6E930")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D81C20", Offset = "0x7D80C20", VA = "0x187D81C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
	public NEPIHMACEAF(IntPtr KJFCOANDBJF, IntPtr LBJMHDOGLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void GINCOBIOKGP(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	private static void BKHOMMMAMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7D81B90", Offset = "0x7D80B90", VA = "0x187D81B90")]
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
	[Cpp2IlInjected.Address(RVA = "0xED2680", Offset = "0xED1680", VA = "0x180ED2680")]
	private CLILDDJMALJ(IntPtr LBJMHDOGLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BF30", Offset = "0x7D7AF30", VA = "0x187D7BF30")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BE40", Offset = "0x7D7AE40", VA = "0x187D7BE40")]
	public static CLILDDJMALJ ACADPGMDEBE(string NFHOBPDKIPM)
	{
		return default(CLILDDJMALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x278EAF0", Offset = "0x278DAF0", VA = "0x18278EAF0")]
	public static CLILDDJMALJ ACADPGMDEBE([In] NEPIHMACEAF HNLHGBPMMHG, string NFHOBPDKIPM)
	{
		return default(CLILDDJMALJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x278EB40", Offset = "0x278DB40", VA = "0x18278EB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D79980", Offset = "0x7D78980", VA = "0x187D79980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7D79B80", Offset = "0x7D78B80", VA = "0x187D79B80")]
	public static SHA256 FLLMCNLHKNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7D79C00", Offset = "0x7D78C00", VA = "0x187D79C00")]
	private static extern int GOPJFDGJOPM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7D79910", Offset = "0x7D78910", VA = "0x187D79910")]
	private static extern IntPtr ABLHEEJLKEI();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7D79A70", Offset = "0x7D78A70", VA = "0x187D79A70")]
	private static extern void DLCCEKDOGNG(IntPtr LFFAAMLEIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7D79E60", Offset = "0x7D78E60", VA = "0x187D79E60")]
	private static extern void IAKBHFGLOGI(IntPtr LFFAAMLEIKA, byte[] APDBNIMCPID, int LLPAIMMACAP, int CKBLNNKJIGI);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7D79FE0", Offset = "0x7D78FE0", VA = "0x187D79FE0")]
	private static extern void POPHKODDLFK(IntPtr LFFAAMLEIKA, byte[] NFGKNNFOCJH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A080", Offset = "0x7D79080", VA = "0x187D7A080")]
	private BGDHHDHBDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D79C70", Offset = "0x7D78C70", VA = "0x187D79C70", Slot = "18")]
	protected override void HashCore(byte[] NBBLCIBNPBK, int KHOLIMNFOEH, int JEDGCPNMDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D79D30", Offset = "0x7D78D30", VA = "0x187D79D30", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7D79F20", Offset = "0x7D78F20", VA = "0x187D79F20", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D79AF0", Offset = "0x7D78AF0", VA = "0x187D79AF0", Slot = "13")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D7F920", Offset = "0x7D7E920", VA = "0x187D7F920", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F980", Offset = "0x7D7E980", VA = "0x187D7F980", Slot = "6")]
			public void OnCompleted(Action ADGINAHIKGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			public void NINCFNJEAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public IIBLEOAMCOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly KLJODIJDBPH MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		private KLJODIJDBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D81010", Offset = "0x7D80010", VA = "0x187D81010", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D80600", Offset = "0x7D7F600", VA = "0x187D80600", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7D80620", Offset = "0x7D7F620", VA = "0x187D80620", Slot = "6")]
			public void OnCompleted(Action ADGINAHIKGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
			public void NINCFNJEAPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JGEIDKIODGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly DPPBOHGEDAO MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		private DPPBOHGEDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BFD0", Offset = "0x7D7AFD0", VA = "0x187D7BFD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BEMFJEEBEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53CA090", Offset = "0x53C9090", VA = "0x1853CA090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LDMKNCGNOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x50DD6A0", Offset = "0x50DC6A0", VA = "0x1850DD6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D85130", Offset = "0x7D84130", VA = "0x187D85130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7BC10", Offset = "0x7D7AC10", VA = "0x187D7BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x44B7AB0", Offset = "0x44B6AB0", VA = "0x1844B7AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x44B7C20", Offset = "0x44B6C20", VA = "0x1844B7C20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A650D0", Offset = "0x6A640D0", VA = "0x186A650D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A65940", Offset = "0x6A64940", VA = "0x186A65940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D85290", Offset = "0x7D84290", VA = "0x187D85290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7D854A0", Offset = "0x7D844A0", VA = "0x187D854A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NHJCOANPHJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x53CA090", Offset = "0x53C9090", VA = "0x1853CA090")]
		internal void PPOIOKDEKAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x53CA010", Offset = "0x53C9010", VA = "0x1853CA010")]
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
		[Cpp2IlInjected.Address(RVA = "0x5343740", Offset = "0x5342740", VA = "0x185343740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5343E90", Offset = "0x5342E90", VA = "0x185343E90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7A1D0", Offset = "0x7D791D0", VA = "0x187D7A1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A9C0", Offset = "0x7D799C0", VA = "0x187D7A9C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D85510", Offset = "0x7D84510", VA = "0x187D85510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7D85A50", Offset = "0x7D84A50", VA = "0x187D85A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x56141D0", Offset = "0x56131D0", VA = "0x1856141D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A21420", Offset = "0x4A20420", VA = "0x184A21420", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AHPALGALCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D79100", Offset = "0x7D78100", VA = "0x187D79100")]
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
		[Cpp2IlInjected.Address(RVA = "0x67CBAF0", Offset = "0x67CAAF0", VA = "0x1867CBAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x40387B0", Offset = "0x40377B0", VA = "0x1840387B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AD2600", Offset = "0x4AD1600", VA = "0x184AD2600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4037810", Offset = "0x4036810", VA = "0x184037810", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E1FD50", Offset = "0x4E1ED50", VA = "0x184E1FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4E205B0", Offset = "0x4E1F5B0", VA = "0x184E205B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D78EC0", Offset = "0x7D77EC0", VA = "0x187D78EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7D790A0", Offset = "0x7D780A0", VA = "0x187D790A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7D8B0", Offset = "0x7D7C8B0", VA = "0x187D7D8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7D7DC20", Offset = "0x7D7CC20", VA = "0x187D7DC20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D806F0", Offset = "0x7D7F6F0", VA = "0x187D806F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7D809E0", Offset = "0x7D7F9E0", VA = "0x187D809E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public NKKEDLPNJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7D82210", Offset = "0x7D81210", VA = "0x187D82210")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7D5F0", Offset = "0x7D7C5F0", VA = "0x187D7D5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D850", Offset = "0x7D7C850", VA = "0x187D7D850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7FC60", Offset = "0x7D7EC60", VA = "0x187D7FC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FE40", Offset = "0x7D7EE40", VA = "0x187D7FE40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D81E50", Offset = "0x7D80E50", VA = "0x187D81E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7D821B0", Offset = "0x7D811B0", VA = "0x187D821B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D81840", Offset = "0x7D80840", VA = "0x187D81840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D81B30", Offset = "0x7D80B30", VA = "0x187D81B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LLBGLAGBLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D810E0", Offset = "0x7D800E0", VA = "0x187D810E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7CCC0", Offset = "0x7D7BCC0", VA = "0x187D7CCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CF20", Offset = "0x7D7BF20", VA = "0x187D7CF20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D84F50", Offset = "0x7D83F50", VA = "0x187D84F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D850D0", Offset = "0x7D840D0", VA = "0x187D850D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x44D9AF0", Offset = "0x44D8AF0", VA = "0x1844D9AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x44D9FD0", Offset = "0x44D8FD0", VA = "0x1844D9FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D80270", Offset = "0x7D7F270", VA = "0x187D80270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D805A0", Offset = "0x7D7F5A0", VA = "0x187D805A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D83A40", Offset = "0x7D82A40", VA = "0x187D83A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D83E00", Offset = "0x7D82E00", VA = "0x187D83E00")]
	public static bool JILPAEPDMCD(this Task BGKKDAHMDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x39C1CA0", Offset = "0x39C0CA0", VA = "0x1839C1CA0")]
	public static Task<T> BOLNKJGCHAP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D82F40", Offset = "0x7D81F40", VA = "0x187D82F40")]
	public static Task DLGGJCMGJPP(this Task BGKKDAHMDLM, CancellationToken EJJDDFFADPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39C5670", Offset = "0x39C4670", VA = "0x1839C5670")]
	public static Task<TResult> DLGGJCMGJPP<TResult>(this Task<TResult> BGKKDAHMDLM, CancellationToken EJJDDFFADPC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39C33A0", Offset = "0x39C23A0", VA = "0x1839C33A0")]
	public static TaskCompletionSource<TResult> DLGGJCMGJPP<TResult>(this TaskCompletionSource<TResult> LOEBJPCBENM, CancellationToken EJJDDFFADPC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D83C70", Offset = "0x7D82C70", VA = "0x187D83C70")]
	public static IDisposable? JALGNPHIKIG(CancellationToken DABJOALKGMN, CancellationToken CJHCEIJCFNK, [Out] CancellationToken MMHILHOGNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D83410", Offset = "0x7D82410", VA = "0x187D83410")]
	[AsyncStateMachine(typeof(PJIKGGBDAHI))]
	public static void EIPEOOFPCOE(this Task LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D83FB0", Offset = "0x7D82FB0", VA = "0x187D83FB0")]
	[AsyncStateMachine(typeof(CICHDLMNKGP))]
	public static void MPNMCDILIHB(this Task LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x39C74E0", Offset = "0x39C64E0", VA = "0x1839C74E0")]
	[AsyncStateMachine(typeof(EBFLLPPKGBM<>))]
	public static Task MDPPEOBALPP<TException>(this Task LEMBKBGMCDG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39C71F0", Offset = "0x39C61F0", VA = "0x1839C71F0")]
	[AsyncStateMachine(typeof(DKPFONJKFKI<>))]
	public static Task<T> IIDKJNAMBMA<T>(this Task<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7D83B80", Offset = "0x7D82B80", VA = "0x187D83B80")]
	[AsyncStateMachine(typeof(PLBKAKGMDGN))]
	public static Task<TaskStatus> IKPBHOPACBD(this Task? OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x39C6F70", Offset = "0x39C5F70", VA = "0x1839C6F70")]
	public static (Task<T?>?, Action<T?>?) GHPHEEMFOBD<T>([Optional] CancellationToken CBJPDIFOEKF)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39C73D0", Offset = "0x39C63D0", VA = "0x1839C73D0")]
	[AsyncStateMachine(typeof(MKPFADDIFPE<, >))]
	public static Task<List<TResult>> IJABJMCHJCJ<TResult, TInput>(this Task<List<TInput>> BGKKDAHMDLM, GAEOFKJACHH<TInput, TResult> NNFCJLKEOFL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D83E80", Offset = "0x7D82E80", VA = "0x187D83E80")]
	[AsyncStateMachine(typeof(BJCMFDBIABP))]
	public static Task MADKMNOENPJ(Task LEMBKBGMCDG, CancellationToken EBOFCHGLLPK, Func<CancellationToken, Task> EEAKCGIBEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D82830", Offset = "0x7D81830", VA = "0x187D82830")]
	[AsyncStateMachine(typeof(PNJFBDBHNAE))]
	public static Task CGAGLKEGKKJ(Func<CancellationToken, Task> KACLNFIKDJP, TimeSpan PKGMHLEONHK, [Optional] CancellationToken EBOFCHGLLPK, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39C1E20", Offset = "0x39C0E20", VA = "0x1839C1E20")]
	[AsyncStateMachine(typeof(PKIJECJHHBN<>))]
	public static Task<T> CGAGLKEGKKJ<T>(Func<CancellationToken, Task<T>> KACLNFIKDJP, TimeSpan PKGMHLEONHK, [Optional] CancellationToken EBOFCHGLLPK, [Optional] Func<OperationCanceledException, T>? JGAJKGLPELK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D82EF0", Offset = "0x7D81EF0", VA = "0x187D82EF0")]
	public static Task DKBOBBDGBGA(params Task[] CHFOMHMEILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D82A30", Offset = "0x7D81A30", VA = "0x187D82A30")]
	public static Task DKBOBBDGBGA(IEnumerable<Task> CHFOMHMEILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x39C7AB0", Offset = "0x39C6AB0", VA = "0x1839C7AB0")]
	[AsyncStateMachine(typeof(CEMGOIJHFHM<>))]
	public static Task<IEnumerable<Task<T>>> PFHDMJENJDL<T>(IEnumerable<Task<T>> CHFOMHMEILP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x39C7890", Offset = "0x39C6890", VA = "0x1839C7890")]
	[AsyncStateMachine(typeof(HFMMPNCNGHD<, , >))]
	public static Task<(T1, T2, T3)> NFJNLEKDGHL<T1, T2, T3>(Task<T1> JGKNLODAOEN, Task<T2> PCNNFDGHLJK, Task<T3> EIGHLKPEHOJ) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39C75B0", Offset = "0x39C65B0", VA = "0x1839C75B0")]
	[AsyncStateMachine(typeof(JALPFMOKDJD<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> NFJNLEKDGHL<T1, T2, T3, T4, T5>(Task<T1> JGKNLODAOEN, Task<T2> PCNNFDGHLJK, Task<T3> EIGHLKPEHOJ, Task<T4> NFLONHKKHJL, Task<T5> MOAHHMANFKE) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D842C0", Offset = "0x7D832C0", VA = "0x187D842C0")]
	[AsyncStateMachine(typeof(AHEGNPGKOHH))]
	public static Task PJKJEGCAIJO(Func<bool> BELPALHENKI, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7D843B0", Offset = "0x7D833B0", VA = "0x187D843B0")]
	[AsyncStateMachine(typeof(FGOPOIFFBEF))]
	public static Task PJKJEGCAIJO(Func<bool> BELPALHENKI, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7D82650", Offset = "0x7D81650", VA = "0x187D82650")]
	[AsyncStateMachine(typeof(JIJKDNBMCBI))]
	public static Task BHFAFEFMPON(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7D82510", Offset = "0x7D81510", VA = "0x187D82510")]
	[AsyncStateMachine(typeof(EMNOHBFCCCD))]
	public static Task BHFAFEFMPON(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7D835D0", Offset = "0x7D825D0", VA = "0x187D835D0")]
	[AsyncStateMachine(typeof(JBJEBKKPKIH))]
	public static Task EPLMPKODCAD(Func<bool> BELPALHENKI, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7D834C0", Offset = "0x7D824C0", VA = "0x187D834C0")]
	[AsyncStateMachine(typeof(NHAIFEBPHEJ))]
	public static Task EPLMPKODCAD(Func<bool> BELPALHENKI, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7D832E0", Offset = "0x7D822E0", VA = "0x187D832E0")]
	[AsyncStateMachine(typeof(MJCJJGJPMFA))]
	public static Task DPIJLGKACMG(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7D831A0", Offset = "0x7D821A0", VA = "0x187D831A0")]
	[AsyncStateMachine(typeof(EJOFLPIBPOA))]
	public static Task DPIJLGKACMG(Func<bool> BELPALHENKI, TimeSpan PKGMHLEONHK, TimeSpan IFGFJPDFNJA, [Optional] CancellationToken CBJPDIFOEKF, [Optional] Action<OperationCanceledException>? JGAJKGLPELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7D82300", Offset = "0x7D81300", VA = "0x187D82300")]
	[Obsolete]
	[AsyncStateMachine(typeof(PHCPJKJFBFC))]
	public static Task ACHKNOBCDCD(this Task BGKKDAHMDLM, Action GHNPMECCEPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x39C1AC0", Offset = "0x39C0AC0", VA = "0x1839C1AC0")]
	[AsyncStateMachine(typeof(EGOIAIFGCNI<>))]
	[Obsolete]
	public static Task ACHKNOBCDCD<T>(this Task<T> BGKKDAHMDLM, Action<T> GHNPMECCEPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7D82780", Offset = "0x7D81780", VA = "0x187D82780")]
	private static void BIFEMONKHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7D836C0", Offset = "0x7D826C0", VA = "0x187D836C0")]
	public static bool FBLBLAGOEEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7D84130", Offset = "0x7D83130", VA = "0x187D84130")]
	private static void NPEGJNDOOAF(SynchronizationContext OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7D823F0", Offset = "0x7D813F0", VA = "0x187D823F0")]
	private static void BDAMICJPKNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7D82960", Offset = "0x7D81960", VA = "0x187D82960")]
	public static void CJFFLGMEDPF([Optional] string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7D83AB0", Offset = "0x7D82AB0", VA = "0x187D83AB0")]
	public static void GPOCMLHECKF([Optional] string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7D83B30", Offset = "0x7D82B30", VA = "0x187D83B30")]
	public static HFMNNPMJELN HKOFLIEIBLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7D83E30", Offset = "0x7D82E30", VA = "0x187D83E30")]
	public static HFMNNPMJELN KFODGCFOLFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7D84060", Offset = "0x7D83060", VA = "0x187D84060")]
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
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public HJNCDIOGCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BNGAHNJAFII
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AB40", Offset = "0x7D79B40", VA = "0x187D7AB40")]
	public static bool LMCKOIEEEKF(this HGAOMCLAJHP POFHCGLLAAJ, DateTime MEMIBIIGPEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AA20", Offset = "0x7D79A20", VA = "0x187D7AA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7BD80", Offset = "0x7D7AD80", VA = "0x187D7BD80", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset IGHAHCNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BD20", Offset = "0x7D7AD20", VA = "0x187D7BD20", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F2B0", Offset = "0x7D7E2B0", VA = "0x187D7F2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F600", Offset = "0x7D7E600", VA = "0x187D7F600")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F140", Offset = "0x7D7E140", VA = "0x187D7F140")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F0F0", Offset = "0x7D7E0F0", VA = "0x187D7F0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F3D0", Offset = "0x7D7E3D0", VA = "0x187D7F3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7F5B0", Offset = "0x7D7E5B0", VA = "0x187D7F5B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F190", Offset = "0x7D7E190", VA = "0x187D7F190")]
	public static double ALDDPEFJMNK(long LOIBDKKEMNM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F520", Offset = "0x7D7E520", VA = "0x187D7F520")]
	public static double LCCHLCKNGEN(long LOIBDKKEMNM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F220", Offset = "0x7D7E220", VA = "0x187D7F220")]
	public static double BBNPAMKHMLO(double JCNHGMDIBDN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F420", Offset = "0x7D7E420", VA = "0x187D7F420")]
	public static long GNMIOIGPEIA(long EPOJNFBFHFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F510", Offset = "0x7D7E510", VA = "0x187D7F510")]
	public static long KHIJJNLFPMD(long PHDKCCCKAIM, long JFGBCPNGOCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F300", Offset = "0x7D7E300", VA = "0x187D7F300")]
	public static double GEOONLPHPDL(long PHDKCCCKAIM, long JFGBCPNGOCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7F4B0", Offset = "0x7D7E4B0", VA = "0x187D7F4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7D79210", Offset = "0x7D78210", VA = "0x187D79210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? BMANJEPHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7D79650", Offset = "0x7D78650", VA = "0x187D79650")]
	[Preserve]
	public ANGNBKIBCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7D796C0", Offset = "0x7D786C0", VA = "0x187D796C0")]
	public ANGNBKIBCDE(TimeSpan PKGMHLEONHK, [Optional] Action? IIMFJDOENFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7D794E0", Offset = "0x7D784E0", VA = "0x187D794E0", Slot = "7")]
	public void JDIKNMDACEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7D79570", Offset = "0x7D78570", VA = "0x187D79570", Slot = "8")]
	public void PBGFGCEPPMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7D79410", Offset = "0x7D78410", VA = "0x187D79410", Slot = "9")]
	public void EJJCFNDELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1129CA0", Offset = "0x1128CA0", VA = "0x181129CA0")]
	private void IMOCAENGPAC(object COFBNOFIHKI, ElapsedEventArgs DNODKJELHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7D79440", Offset = "0x7D78440", VA = "0x187D79440")]
	private static void EKCGJAPJJOO(TimeSpan PLKPHCDMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7D79370", Offset = "0x7D78370", VA = "0x187D79370", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x76AC840", Offset = "0x76AB840", VA = "0x1876AC840")]
	public HCCKFFEHNEM(string HHPFBMBMELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4F65A90", Offset = "0x4F64A90", VA = "0x184F65A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E45530", Offset = "0x1E44530", VA = "0x181E45530")]
	public static CDFNCNEGFME IGEJHMNIIOM(uint OIFEOJPBJLB)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1E45530", Offset = "0x1E44530", VA = "0x181E45530")]
	public static CDFNCNEGFME EJPIOPPHJJM(int GNJBJNHAKAA)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ADA0", Offset = "0x7D79DA0", VA = "0x187D7ADA0")]
	public static CDFNCNEGFME MCKEFPOLNAF(float CJBNGEDNPJC)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD80", Offset = "0x7D79D80", VA = "0x187D7AD80")]
	public static CDFNCNEGFME MJHJPKNDJDI(byte PIHFAPPNFBN, byte IOAOBLBBIFC, byte KEHIMPHGFFO, byte MIHJPIIJBBG)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD80", Offset = "0x7D79D80", VA = "0x187D7AD80")]
	public static CDFNCNEGFME NDLICFJFBAA(bool ICMHKJNHAPD, bool FPNLMJMIDFJ, bool EPJAGDCIBEL, bool GDMHFFFGDFH)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7D7AD80", Offset = "0x7D79D80", VA = "0x187D7AD80")]
	public static CDFNCNEGFME HDFHCNJMIHB(byte JBHKILEAGAI, byte IAKBFKKGBCK, byte OBLGPGKEJBE, byte LEILOMHMPPD)
	{
		return default(CDFNCNEGFME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x213A3C0", Offset = "0x21393C0", VA = "0x18213A3C0")]
	public static bool MMJMCICIDNJ(CDFNCNEGFME OBNCJFFHHLB, CDFNCNEGFME ODHPFGNCGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x213A3A0", Offset = "0x21393A0", VA = "0x18213A3A0", Slot = "4")]
	public bool Equals(CDFNCNEGFME MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ACF0", Offset = "0x7D79CF0", VA = "0x187D7ACF0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x12B3880", Offset = "0x12B2880", VA = "0x1812B3880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7D7ADB0", Offset = "0x7D79DB0", VA = "0x187D7ADB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static ACAMMOBHJAC ACADPGMDEBE(long FAFFDBLANFK)
	{
		return default(ACAMMOBHJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E70", Offset = "0x7D77E70", VA = "0x187D78E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E12400", Offset = "0x2E11400", VA = "0x182E12400")]
	public static MIHFKGDIHFA MJHJPKNDJDI(byte JMACIMHIJNG)
	{
		return default(MIHFKGDIHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2E12400", Offset = "0x2E11400", VA = "0x182E12400")]
	public static MIHFKGDIHFA NDLICFJFBAA(bool NNPIKMKLMFJ)
	{
		return default(MIHFKGDIHFA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7D815C0", Offset = "0x7D805C0", VA = "0x187D815C0")]
	public static bool MMJMCICIDNJ(MIHFKGDIHFA OBNCJFFHHLB, MIHFKGDIHFA ODHPFGNCGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D02D70", Offset = "0x6D01D70", VA = "0x186D02D70", Slot = "4")]
	public bool Equals(MIHFKGDIHFA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7D81520", Offset = "0x7D80520", VA = "0x187D81520", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7D815B0", Offset = "0x7D805B0", VA = "0x187D815B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D815D0", Offset = "0x7D805D0", VA = "0x187D815D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x535C260", Offset = "0x535B260", VA = "0x18535C260")]
	public MOKMAIBPLFE(T FHCPCMAKMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class JPPAOPHOCML
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x38B5660", Offset = "0x38B4660", VA = "0x1838B5660")]
	public static IEnumerable<T> DFDNAGCGNLC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static T[] MONOABAFCHO<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static IEnumerable<T> GICLKIABNAM<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
	public static HashSet<T> GOBPEEJPMHH<T>(params T[] JPBMCGIDAJI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x38B5690", Offset = "0x38B4690", VA = "0x1838B5690")]
	public static KeyValuePair<TKey, TValue> OKDKKMOMFEN<TKey, TValue>([In] TKey OEHHKNIGGMI, [In] TValue OHLIHBDBKCE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
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
	[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D7DCB0", Offset = "0x7D7CCB0", VA = "0x187D7DCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E590", Offset = "0x7D7D590", VA = "0x187D7E590", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7D7D010", Offset = "0x7D7C010", VA = "0x187D7D010")]
	public static Task<bool> MMMKPPMDAMN(int BKJPMDLBAAF, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D3B0", Offset = "0x7D7C3B0", VA = "0x187D7D3B0")]
	[AsyncStateMachine(typeof(FMFEJOKPOOG))]
	private static Task<bool> OCNELEKPNMO(int BKJPMDLBAAF, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7CF80", Offset = "0x7D7BF80", VA = "0x187D7CF80")]
	private static void JOKPOONDBHJ(object? IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D320", Offset = "0x7D7C320", VA = "0x187D7D320")]
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
