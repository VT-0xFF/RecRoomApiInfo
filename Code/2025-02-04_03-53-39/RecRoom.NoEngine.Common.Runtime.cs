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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7384DF0", Offset = "0x7383BF0", VA = "0x187384DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCGOEJLIFJM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7384E70", Offset = "0x7383C70", VA = "0x187384E70")]
	public static string IHPEODFPIEC(this Encoding FACCDKFBGHJ, [In] ReadOnlySequence<byte> MDJJEFJEKNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3482110", Offset = "0x3480F10", VA = "0x183482110")]
	private static void BGPNPEPDDCK<T>(this ReadOnlySequence<T> GBJBOGFDKGP, [Out] ReadOnlySpan<T> CFLAEICAEEM, [Out] SequencePosition LKGDMHILKON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class AHJBCDKENFK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x737C030", Offset = "0x737AE30", VA = "0x18737C030")]
	public AHJBCDKENFK(bool BIPEPBNNINL, string LHFDNPMEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x737C110", Offset = "0x737AF10", VA = "0x18737C110")]
	public AHJBCDKENFK(bool BIPEPBNNINL, params string[] APJDOGIOGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NCBIMNKIDLB
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GKLGOAPBKPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GHPABINPJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLAIAACFOLD(string FFOHLCGHDKA, double IPHILEOFJLB, [Optional] string? JBACKHNFBBH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class POFEPICAAOA : LLBFMCCGOBE, AOHLJMMBEHE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int IDLBJBHCMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> BGBCNIECAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double KGJBAAHPLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double GAMKMEIMNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double LJIBMMMGHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int CIBFLDOEOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double PCFPPGHODKD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PNNOFPBKOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x914100", Offset = "0x912F00", VA = "0x180914100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double ILLMIHGBLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7387A90", Offset = "0x7386890", VA = "0x187387A90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OKNOEDDMNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5620140", Offset = "0x561EF40", VA = "0x185620140", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double JPDAFIIPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x24D1AF0", Offset = "0x24D08F0", VA = "0x1824D1AF0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7387C90", Offset = "0x7386A90", VA = "0x187387C90")]
	public POFEPICAAOA(int AEKBNBGCGJH, double PCFPPGHODKD = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7387B60", Offset = "0x7386960", VA = "0x187387B60", Slot = "7")]
	public void HDGLFFAOJCP(double OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7387AF0", Offset = "0x73868F0", VA = "0x187387AF0", Slot = "8")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7387990", Offset = "0x7386790", VA = "0x187387990", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GDMBAMDCDDO : LLBFMCCGOBE, AOHLJMMBEHE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long BMGBDLLODJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double HGKFOBLGPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double PKGPIGLEOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double NIENOGPFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double OFMIDFJDHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double KGJBAAHPLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double GAMKMEIMNNI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OKNOEDDMNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x676F200", Offset = "0x676E000", VA = "0x18676F200", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JPDAFIIPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x676ED30", Offset = "0x676DB30", VA = "0x18676ED30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CJJOKCFNMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x676ED50", Offset = "0x676DB50", VA = "0x18676ED50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ILLMIHGBLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B9A0", Offset = "0x2B5A7A0", VA = "0x182B5B9A0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x737E330", Offset = "0x737D130", VA = "0x18737E330", Slot = "10")]
	public virtual void HDGLFFAOJCP(double OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x737E2F0", Offset = "0x737D0F0", VA = "0x18737E2F0", Slot = "11")]
	public virtual void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x737E280", Offset = "0x737D080", VA = "0x18737E280", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x737C590", Offset = "0x737B390", VA = "0x18737C590")]
	public GDMBAMDCDDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class COPMELCBLEB : GDMBAMDCDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double DGKNBEFGFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x676F210", Offset = "0x676E010", VA = "0x18676F210")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x676ED60", Offset = "0x676DB60", VA = "0x18676ED60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x737C460", Offset = "0x737B260", VA = "0x18737C460", Slot = "10")]
	public override void HDGLFFAOJCP(double OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x737C420", Offset = "0x737B220", VA = "0x18737C420", Slot = "11")]
	public override void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x737C590", Offset = "0x737B390", VA = "0x18737C590")]
	public COPMELCBLEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LLBFMCCGOBE : AOHLJMMBEHE, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double ILLMIHGBLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OKNOEDDMNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double JPDAFIIPPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ECHMGBHBKGG : AOHLJMMBEHE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double KGBEEJOPGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double IBMAEKIMGOE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x737C790", Offset = "0x737B590", VA = "0x18737C790")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x737C7B0", Offset = "0x737B5B0", VA = "0x18737C7B0", Slot = "4")]
	public void HDGLFFAOJCP(double OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x737C7A0", Offset = "0x737B5A0", VA = "0x18737C7A0", Slot = "5")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x737C740", Offset = "0x737B540", VA = "0x18737C740", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public ECHMGBHBKGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AOHLJMMBEHE : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDGLFFAOJCP(double OAJCPHOOFGC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCNCDDFOOKM();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DPMLCCALFOI : AOHLJMMBEHE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double IPHILEOFJLB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4066BC0", Offset = "0x40659C0", VA = "0x184066BC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D08E90", Offset = "0x4D07C90", VA = "0x184D08E90", Slot = "4")]
	public void HDGLFFAOJCP(double OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x737C610", Offset = "0x737B410", VA = "0x18737C610", Slot = "5")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x737C5C0", Offset = "0x737B3C0", VA = "0x18737C5C0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DPMLCCALFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FNDBDAKGNOM<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> LBIGBONHONC(CancellationToken FEHCANHDGHE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JJAKLKCFDNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FNDBDAKGNOM<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LBIGBONHONC taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x48C9920", Offset = "0x48C8720", VA = "0x1848C9920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x48CA9E0", Offset = "0x48C97E0", VA = "0x1848CA9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource PCBNIHHNEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? OMGPPHPCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? JIEHJHNOPIC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x43D0B00", Offset = "0x43CF900", VA = "0x1843D0B00")]
	[AsyncStateMachine(typeof(FNDBDAKGNOM<>.JJAKLKCFDNL))]
	public Task<TResult> ICPBINGIPBM(LBIGBONHONC LLNKNHKIEHK, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x43D0A90", Offset = "0x43CF890", VA = "0x1843D0A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43D0C40", Offset = "0x43CFA40", VA = "0x1843D0C40")]
	public FNDBDAKGNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MAIKOPDIHLF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> LLGJMGLDHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T HKHKCHJEPKB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x46CBCA0", Offset = "0x46CAAA0", VA = "0x1846CBCA0")]
	public MAIKOPDIHLF([In] T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C784F0", Offset = "0x4C772F0", VA = "0x184C784F0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C78CE0", Offset = "0x4C77AE0", VA = "0x184C78CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C791C0", Offset = "0x4C77FC0", VA = "0x184C791C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EHEOICGMGGD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static MAIKOPDIHLF<T> MKHEJJEDOII<T>([In] T IPHILEOFJLB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ECFLNEEPDCL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x737C710", Offset = "0x737B510", VA = "0x18737C710")]
	public static void AILCFBAAJME(this CancellationTokenSource PCBNIHHNEIO, bool GLKIJGCADBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class GCDAKCHJOEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public GCDAKCHJOEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class NPOJMFOGALI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public NPOJMFOGALI(string IJDPKIIIHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ILBFFOKHMOF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32F1120", Offset = "0x32EFF20", VA = "0x1832F1120")]
	public static PBMEPPMJPLG JNIJPCBGBKD<T>()
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x32F0E50", Offset = "0x32EFC50", VA = "0x1832F0E50")]
	public static PBMEPPMJPLG FJCOGDNIOCC<T>([CallerMemberName] string PPKJBGAOBJL = "") where T : notnull
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32F10A0", Offset = "0x32EFEA0", VA = "0x1832F10A0")]
	public static PBMEPPMJPLG JNIJPCBGBKD<T>(this T BHICHJIFLJC) where T : notnull
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32F0CB0", Offset = "0x32EFAB0", VA = "0x1832F0CB0")]
	public static PBMEPPMJPLG AIICEOPCEIE<T>(this T BHICHJIFLJC, [CallerMemberName] string PPKJBGAOBJL = "") where T : notnull
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32F0EF0", Offset = "0x32EFCF0", VA = "0x1832F0EF0")]
	public static PBMEPPMJPLG FJCOGDNIOCC<T>(this T DJAJDIFOIHP, [CallerMemberName] string PPKJBGAOBJL = "") where T : notnull
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7380080", Offset = "0x737EE80", VA = "0x187380080")]
	public static PBMEPPMJPLG FJCOGDNIOCC(string KMDHAFGNENP, [CallerMemberName] string PPKJBGAOBJL = "")
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7380100", Offset = "0x737EF00", VA = "0x187380100")]
	public static string NEIAGJPFFIB(this object DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool CKFGJMAGKLI();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[GCDAKCHJOEM]
public delegate long BADOENLIHPI();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KLACENDCCHM
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static IJPBGIJLOPO IKPEIEDEOPH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static IJPBGIJLOPO MIGJALBAHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x73846B0", Offset = "0x73834B0", VA = "0x1873846B0")]
		get
		{
			return default(IJPBGIJLOPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static GCFHHJINGND DJIDOFHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7384590", Offset = "0x7383390", VA = "0x187384590")]
		get
		{
			return default(GCFHHJINGND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static PBGJHPOADAE JEJDCOIAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7384A50", Offset = "0x7383850", VA = "0x187384A50")]
		get
		{
			return default(PBGJHPOADAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool JIBKACLBJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73848C0", Offset = "0x73836C0", VA = "0x1873848C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7384200", Offset = "0x7383000", VA = "0x187384200")]
	public static void AECHNGAGMPD([In] IJPBGIJLOPO ILJNAABDPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x73845E0", Offset = "0x73833E0", VA = "0x1873845E0")]
	public static void KAMAHCNLDOK(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73847F0", Offset = "0x73835F0", VA = "0x1873847F0")]
	public static void NJHBLELLPFD(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x338DC90", Offset = "0x338CA90", VA = "0x18338DC90")]
	public static void NJHBLELLPFD<T>(T BFLKHJBBCJI, NNCBFLKOAEM<T> KKBJAPCBOHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7384420", Offset = "0x7383220", VA = "0x187384420")]
	public static void HDBFLEMFMOC(Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x73849D0", Offset = "0x73837D0", VA = "0x1873849D0")]
	public static void OIHNGGLHEAA(string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7384700", Offset = "0x7383500", VA = "0x187384700")]
	public static void LOLLJJOKOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7384770", Offset = "0x7383570", VA = "0x187384770")]
	public static string NEIAGJPFFIB(object JOOHPPHJKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x73843B0", Offset = "0x73831B0", VA = "0x1873843B0")]
	public static long BFGCJDGHMNE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7384930", Offset = "0x7383730", VA = "0x187384930")]
	public static bool OECIGILDCGL(bool PKDNIKFJMDJ, string KKBJAPCBOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x73844C0", Offset = "0x73832C0", VA = "0x1873844C0")]
	public static double HKPOEDKNIPJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct IJPBGIJLOPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly GCFHHJINGND DJIDOFHIBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly PBGJHPOADAE JEJDCOIAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly CEAECOCGINC BNPEICHBMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly BADOENLIHPI DKCBFPFFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly PKIPHPNOOLD EMCKEIAGEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly CKFGJMAGKLI GJMMBENDGPL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly CEAECOCGINC FCMDBMBOLPB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BADOENLIHPI HEHCOAOHNOE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly PKIPHPNOOLD GEAMBDDFHDD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly CKFGJMAGKLI ANLDLLBJKNG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IJPBGIJLOPO JBBIPKIKKBB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HDHDIACPLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x737F740", Offset = "0x737E540", VA = "0x18737F740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x737FFD0", Offset = "0x737EDD0", VA = "0x18737FFD0")]
	public IJPBGIJLOPO([In] GCFHHJINGND CGPADECKAOC, [In] PBGJHPOADAE IKFIJLHJKJI, CEAECOCGINC FDGJLJCAMPD, BADOENLIHPI NFIHDKPBCDA, PKIPHPNOOLD LCMAAHDAPIL, CKFGJMAGKLI AGOHECBDCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x737F5F0", Offset = "0x737E3F0", VA = "0x18737F5F0")]
	private static string JODABILICIO(object JOOHPPHJKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50")]
	private static long DBHMMJOAPKL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	private static string JHDFMIFJMPP(string MBNPKKJMDHG, string? KBFABHDAKIJ, bool JLOGJLMGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	private static bool ANILGADOHAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x737F630", Offset = "0x737E430", VA = "0x18737F630")]
	private static IJPBGIJLOPO LJODFKBDHCG()
	{
		return default(IJPBGIJLOPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NFKJEPBEHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JLJLJKFBFJE JOPFHFCGHMH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface JLJLJKFBFJE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BKAEPKEPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJBMOHFPJDC();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DOBJOHBJOOL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPIKCMFBAIM([In] T LHMPMCLNOPG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void NOLEEMPKCBI<T>([In] T BFLKHJBBCJI);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct BGKDMKEAHDI<T> : IEquatable<BGKDMKEAHDI<T>>, DOBJOHBJOOL<BGKDMKEAHDI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T HKHKCHJEPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int OFCLDJHOLLK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x255A0F0", Offset = "0x2558EF0", VA = "0x18255A0F0")]
	public BGKDMKEAHDI([In] T IPHILEOFJLB, int KNCPCNBMDNF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x562FAE0", Offset = "0x562E8E0", VA = "0x18562FAE0")]
	public static bool BHDCHHANDIG([In] BGKDMKEAHDI<T> PMKFIDCMLAN, [In] BGKDMKEAHDI<T> BFOIKIBAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5630130", Offset = "0x562EF30", VA = "0x185630130", Slot = "4")]
	public bool Equals(BGKDMKEAHDI<T> LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4571510", Offset = "0x4570310", VA = "0x184571510", Slot = "0")]
	public override bool Equals(object LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56306C0", Offset = "0x562F4C0", VA = "0x1856306C0")]
	public bool KPIKCMFBAIM([In] BGKDMKEAHDI<T> LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56305E0", Offset = "0x562F3E0", VA = "0x1856305E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5631000", Offset = "0x562FE00", VA = "0x185631000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x562F2E0", Offset = "0x562E0E0", VA = "0x18562F2E0")]
	public void AHAOIMLDBFI([Out] T IPHILEOFJLB, [Out] int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x56308E0", Offset = "0x562F6E0", VA = "0x1856308E0")]
	public (T, int) OKOBEAKMIKJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5630750", Offset = "0x562F550", VA = "0x185630750", Slot = "5")]
	private bool MMILHOPIJLO([In] BGKDMKEAHDI<T> LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GCAOIDKDPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x32A4B40", Offset = "0x32A3940", VA = "0x1832A4B40")]
	public static BGKDMKEAHDI<T> MKHEJJEDOII<T>([In] T IPHILEOFJLB, int KNCPCNBMDNF) where T : notnull
	{
		return default(BGKDMKEAHDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class KDJIKAPHMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3388FB0", Offset = "0x3387DB0", VA = "0x183388FB0")]
	public static bool KPIKCMFBAIM<T, U>([In] T DJAJDIFOIHP, [In] U JOOHPPHJKMI) where T : notnull, DOBJOHBJOOL<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult JNCHFGKJAPD<T, out TResult>([In] T BFLKHJBBCJI);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OGONOFCBGBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan OKCEMPLFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? NGIOHBKPMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODCOABNFDHI();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEPIPFLKMHB();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIPLBHKIMPL();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct GCFHHJINGND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly FFIHJLDDIBC DIIPIBLKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly LAGNMEGGMBN JEPJOILEGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly FFIHJLDDIBC NJBDLEFIEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly LAGNMEGGMBN JJJPKCHDPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FFIHJLDDIBC GMOJHFDHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly LAGNMEGGMBN AFAECJKFBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly EFFJEPJBHLB KGFBOMMADJI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FFIHJLDDIBC LHMPGKJEFFA;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly LAGNMEGGMBN GFMLCJABECL;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly FFIHJLDDIBC HKAJAMDFBAJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly LAGNMEGGMBN BANJOLJPCLO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly FFIHJLDDIBC ANKFJAMGCOG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LAGNMEGGMBN DCKAALKJDKB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly EFFJEPJBHLB LCEGLCDBKGA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly GCFHHJINGND JBBIPKIKKBB;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly FFIHJLDDIBC NNABHLHPIFP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HDHDIACPLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x737D880", Offset = "0x737C680", VA = "0x18737D880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC23680", Offset = "0xC22480", VA = "0x180C23680")]
	public GCFHHJINGND(FFIHJLDDIBC PAFPOIBHDBE, LAGNMEGGMBN AHLDPNBKNMM, FFIHJLDDIBC CBPEECANCGD, LAGNMEGGMBN MEFKDNKEBCF, FFIHJLDDIBC BIFKAPOOAMK, LAGNMEGGMBN HKILBMNFHOF, EFFJEPJBHLB JBEKJNKIPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	private static bool BCBBFEHPCND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void NAOLGLNOPKB(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	private static bool EFLMHBLKEEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void PIJGHPJKLJM(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	private static bool BBKGDMJNEHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void FGJBHNFKFPL(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void PHBHJMEAFKF(Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x737D740", Offset = "0x737C540", VA = "0x18737D740")]
	private static GCFHHJINGND LJODFKBDHCG()
	{
		return default(GCFHHJINGND);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
	private static bool HAEFIHPALLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x737D6D0", Offset = "0x737C4D0", VA = "0x18737D6D0")]
	public void KAMAHCNLDOK(object KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x737DA80", Offset = "0x737C880", VA = "0x18737DA80")]
	public void NJHBLELLPFD(object KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xC21750", Offset = "0xC20550", VA = "0x180C21750")]
	public void HDBFLEMFMOC(Exception JGLOLGKKBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x737DAF0", Offset = "0x737C8F0", VA = "0x18737DAF0")]
	public void NJHBLELLPFD(OIKBCHJGEKA KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32A50A0", Offset = "0x32A3EA0", VA = "0x1832A50A0")]
	public void NJHBLELLPFD<T>(T BFLKHJBBCJI, NNCBFLKOAEM<T> KKBJAPCBOHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32A4C90", Offset = "0x32A3A90", VA = "0x1832A4C90")]
	public void KAMAHCNLDOK<T>([In] T BFLKHJBBCJI, MNPGLALFOBO<T> KKBJAPCBOHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32A4E30", Offset = "0x32A3C30", VA = "0x1832A4E30")]
	public void NJHBLELLPFD<T>([In] T BFLKHJBBCJI, MNPGLALFOBO<T> KKBJAPCBOHH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x737DBD0", Offset = "0x737C9D0", VA = "0x18737DBD0")]
	public bool OECIGILDCGL(bool PKDNIKFJMDJ, string KKBJAPCBOHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct PBMEPPMJPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string HKHKCHJEPKB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public PBMEPPMJPLG(string IPHILEOFJLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
	public static string JCHCBNMNCNP([In] PBMEPPMJPLG DJAJDIFOIHP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xFE2330", Offset = "0xFE1130", VA = "0x180FE2330")]
	public static PBMEPPMJPLG JCHCBNMNCNP(string LHMPMCLNOPG)
	{
		return default(PBMEPPMJPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73873C0", Offset = "0x73861C0", VA = "0x1873873C0")]
	public string NCCMLIHLNBH(string AOPDNDDEBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73872E0", Offset = "0x73860E0", VA = "0x1873872E0")]
	public string CKPGBBFEAMN(object BEPBOLBFNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class GIHIPDJNFPG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public GIHIPDJNFPG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct ENLEGHEGALI : IEquatable<ENLEGHEGALI>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "4")]
	public bool Equals(ENLEGHEGALI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x737C7C0", Offset = "0x737B5C0", VA = "0x18737C7C0", Slot = "0")]
	public override bool Equals(object LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x737C810", Offset = "0x737B610", VA = "0x18737C810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x737C820", Offset = "0x737B620", VA = "0x18737C820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[OLBEHBOLMGB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HHLFAFFGDEG<T> : IEquatable<HHLFAFFGDEG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T HKHKCHJEPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool DJEPJFEENPJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NIKIPENGMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4572110", Offset = "0x4570F10", VA = "0x184572110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x45730B0", Offset = "0x4571EB0", VA = "0x1845730B0")]
	public HHLFAFFGDEG([In] T IPHILEOFJLB, bool CJKOKEOGNKJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4571030", Offset = "0x456FE30", VA = "0x184571030")]
	public static bool BHDCHHANDIG([In] HHLFAFFGDEG<T> PMKFIDCMLAN, [In] HHLFAFFGDEG<T> BFOIKIBAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4571480", Offset = "0x4570280", VA = "0x184571480", Slot = "4")]
	public bool Equals(HHLFAFFGDEG<T> LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4571C10", Offset = "0x4570A10", VA = "0x184571C10", Slot = "0")]
	public override bool Equals(object? LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4572740", Offset = "0x4571540", VA = "0x184572740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4572BB0", Offset = "0x45719B0", VA = "0x184572BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LJIPPPJGACL
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x33AB4C0", Offset = "0x33AA2C0", VA = "0x1833AB4C0")]
	public static HHLFAFFGDEG<T> KLJEDLOBHMP<T>([In] T IPHILEOFJLB) where T : notnull
	{
		return default(HHLFAFFGDEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33AB6D0", Offset = "0x33AA4D0", VA = "0x1833AB6D0")]
	public static HHLFAFFGDEG<T?> LHKBKPGKDCH<T>()
	{
		return default(HHLFAFFGDEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x33AB390", Offset = "0x33AA190", VA = "0x1833AB390")]
	public static bool KGMJALOBIIC<T>([In] this HHLFAFFGDEG<T> NPIPIMEABFJ, [Out][NotNullWhen(true)] T IPHILEOFJLB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x33AB350", Offset = "0x33AA150", VA = "0x1833AB350")]
	public static bool KGMJALOBIIC<T>([In] this HHLFAFFGDEG<T> NPIPIMEABFJ, [Out][NotNullWhen(true)] T IPHILEOFJLB, [Out] HHLFAFFGDEG<T> DHPMOEBAONK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33AB2C0", Offset = "0x33AA0C0", VA = "0x1833AB2C0")]
	public static T? BJNDDLBBEKM<T>([In] this HHLFAFFGDEG<T> NPIPIMEABFJ, T? KBHDDKCAINE)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x33AB7D0", Offset = "0x33AA5D0", VA = "0x1833AB7D0")]
	public static bool LLOCKADFNBP<T>([In] this HHLFAFFGDEG<T> NPIPIMEABFJ, T IPHILEOFJLB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HLGNMBNJCMF
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x32D8BD0", Offset = "0x32D79D0", VA = "0x1832D8BD0")]
	public static T JAOCKILDHKH<T>([In] this HHLFAFFGDEG<T> NPIPIMEABFJ) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PBGJHPOADAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr OIHNGGLHEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr LOLLJJOKOII;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr FIHFPMNPLAJ;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr NFHMBDPEDEO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly PBGJHPOADAE JBBIPKIKKBB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HDHDIACPLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x73870B0", Offset = "0x7385EB0", VA = "0x1873870B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	public PBGJHPOADAE(IntPtr PCMCIDCLLBC, IntPtr AKLDHJLNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void BAJKNFIBMME(string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	private static void KHEOIFEJGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7387020", Offset = "0x7385E20", VA = "0x187387020")]
	private static PBGJHPOADAE LJODFKBDHCG()
	{
		return default(PBGJHPOADAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct NMEKABENMHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr JDONADPDNGO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
	private NMEKABENMHL(IntPtr AKLDHJLNLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7384CC0", Offset = "0x7383AC0", VA = "0x187384CC0")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7384BD0", Offset = "0x73839D0", VA = "0x187384BD0")]
	public static NMEKABENMHL MKHEJJEDOII(string PPKJBGAOBJL)
	{
		return default(NMEKABENMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2535100", Offset = "0x2533F00", VA = "0x182535100")]
	public static NMEKABENMHL MKHEJJEDOII([In] PBGJHPOADAE IKFIJLHJKJI, string PPKJBGAOBJL)
	{
		return default(NMEKABENMHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2535340", Offset = "0x2534140", VA = "0x182535340")]
	public static NMEKABENMHL MKHEJJEDOII([In] PBGJHPOADAE IKFIJLHJKJI, Func<string> PPKJBGAOBJL)
	{
		return default(NMEKABENMHL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KDDLGPAIKBH
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool PBAJAFOOPLD<in TInput, TResult>(TInput HEILFBEALON, [Out] TResult LDEANEOLAOA);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JINDEIKHLIP : NFKJEPBEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class PIEBBFKJGMA : JLJLJKFBFJE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly PIEBBFKJGMA GGJCMHODIEM;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool BKAEPKEPKGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x7387650", Offset = "0x7386450", VA = "0x187387650", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x73876B0", Offset = "0x73864B0", VA = "0x1873876B0", Slot = "6")]
			public void OnCompleted(Action EONANGMMIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			public void KJBMOHFPJDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public PIEBBFKJGMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly JINDEIKHLIP GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		private JINDEIKHLIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7380740", Offset = "0x737F540", VA = "0x187380740", Slot = "4")]
		public JLJLJKFBFJE JOPFHFCGHMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class HHDKOIFGHJL : NFKJEPBEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class DPPLKCIHBFO : JLJLJKFBFJE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly DPPLKCIHBFO GGJCMHODIEM;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool BKAEPKEPKGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x737C620", Offset = "0x737B420", VA = "0x18737C620", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x737C640", Offset = "0x737B440", VA = "0x18737C640", Slot = "6")]
			public void OnCompleted(Action EONANGMMIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			public void KJBMOHFPJDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DPPLKCIHBFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly HHDKOIFGHJL GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		private HHDKOIFGHJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x737E820", Offset = "0x737D620", VA = "0x18737E820", Slot = "4")]
		public JLJLJKFBFJE JOPFHFCGHMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FKMEAHCNDHE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FKMEAHCNDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x43CB8D0", Offset = "0x43CA6D0", VA = "0x1843CB8D0")]
		internal void JJALOBJOFMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class CJIBBHFMOFI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CJIBBHFMOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4A7AAE0", Offset = "0x4A798E0", VA = "0x184A7AAE0")]
		internal void HNKNLKIPBMH(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EOFODIEKLDP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x737C850", Offset = "0x737B650", VA = "0x18737C850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct NPLAADJKAPF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7384CE0", Offset = "0x7383AE0", VA = "0x187384CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JOONBMDHJNF<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x48F1FA0", Offset = "0x48F0DA0", VA = "0x1848F1FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x48F2110", Offset = "0x48F0F10", VA = "0x1848F2110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OFDNOJAKEFK<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4E32D70", Offset = "0x4E31B70", VA = "0x184E32D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4E335C0", Offset = "0x4E323C0", VA = "0x184E335C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct HOOEHMJPGNK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x737EB30", Offset = "0x737D930", VA = "0x18737EB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x737ED30", Offset = "0x737DB30", VA = "0x18737ED30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IFMBDDMIEAB<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IFMBDDMIEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x43CB8D0", Offset = "0x43CA6D0", VA = "0x1843CB8D0")]
		internal void KMGBHFAAEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x46DB780", Offset = "0x46DA580", VA = "0x1846DB780")]
		internal void MKFCPPBGJPC(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PMGNICGGHMI<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public PBAJAFOOPLD<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4F35A10", Offset = "0x4F34810", VA = "0x184F35A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4F36120", Offset = "0x4F34F20", VA = "0x184F36120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct IFEALIMHMGJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x737EDA0", Offset = "0x737DBA0", VA = "0x18737EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x737F590", Offset = "0x737E390", VA = "0x18737F590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct KDKEGDMMMMI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x73832A0", Offset = "0x73820A0", VA = "0x1873832A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73837E0", Offset = "0x73825E0", VA = "0x1873837E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct ANBOAAGNFGP<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x45286B0", Offset = "0x45274B0", VA = "0x1845286B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4482990", Offset = "0x4481790", VA = "0x184482990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JLNEELCMEAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<ENLEGHEGALI> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JLNEELCMEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7380810", Offset = "0x737F610", VA = "0x187380810")]
		internal void OCKNBHEEIDE(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JDILNLJFNLN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x48B93A0", Offset = "0x48B81A0", VA = "0x1848B93A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3C61B90", Offset = "0x3C60990", VA = "0x183C61B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct IGLANACGDNE<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

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
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x46DF470", Offset = "0x46DE270", VA = "0x1846DF470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x46E0180", Offset = "0x46DEF80", VA = "0x1846E0180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct PEDOFKGFMJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7387410", Offset = "0x7386210", VA = "0x187387410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x73875F0", Offset = "0x73863F0", VA = "0x1873875F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct HFAHCEPLEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x737E450", Offset = "0x737D250", VA = "0x18737E450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x737E7C0", Offset = "0x737D5C0", VA = "0x18737E7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KECFDBHOOPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7383840", Offset = "0x7382640", VA = "0x187383840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7383B30", Offset = "0x7382930", VA = "0x187383B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class JHLILFNLLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JHLILFNLLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x73806D0", Offset = "0x737F4D0", VA = "0x1873806D0")]
		internal Task ABHCGNLBOKL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct BOMLACIOFAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x737C160", Offset = "0x737AF60", VA = "0x18737C160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x737C3C0", Offset = "0x737B1C0", VA = "0x18737C3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct HLNFPDIHELP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x737E8F0", Offset = "0x737D6F0", VA = "0x18737E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x737EAD0", Offset = "0x737D8D0", VA = "0x18737EAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct FLAPPAHMBPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x737D300", Offset = "0x737C100", VA = "0x18737D300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x737D670", Offset = "0x737C470", VA = "0x18737D670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JBKGOBNIGNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7380380", Offset = "0x737F180", VA = "0x187380380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7380670", Offset = "0x737F470", VA = "0x187380670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LNMJPLGOAMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LNMJPLGOAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7384B60", Offset = "0x7383960", VA = "0x187384B60")]
		internal Task GDEPGJCGDDC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct AGODHPKMFII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x737B9E0", Offset = "0x737A7E0", VA = "0x18737B9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x737BC40", Offset = "0x737AA40", VA = "0x18737BC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IODILCEAGBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x73801A0", Offset = "0x737EFA0", VA = "0x1873801A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7380320", Offset = "0x737F120", VA = "0x187380320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HHGDNDPIGLJ<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4570A60", Offset = "0x456F860", VA = "0x184570A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4570CC0", Offset = "0x456FAC0", VA = "0x184570CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct AHBDADICFGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x737BCA0", Offset = "0x737AAA0", VA = "0x18737BCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x737BFD0", Offset = "0x737ADD0", VA = "0x18737BFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? AEPIDGHAGBI;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<ENLEGHEGALI> JOHCAAPFANB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task HFAOOBGNKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7383170", Offset = "0x7381F70", VA = "0x187383170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7381F90", Offset = "0x7380D90", VA = "0x187381F90")]
	public static bool IBJOBAFNHBP(this Task BDCCICFJHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3380940", Offset = "0x337F740", VA = "0x183380940")]
	public static Task<T> PHNIIAFIGOJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73822C0", Offset = "0x73810C0", VA = "0x1873822C0")]
	public static Task JMFHAHKJHHJ(this Task BDCCICFJHCL, CancellationToken HACFGBHNOCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x337E460", Offset = "0x337D260", VA = "0x18337E460")]
	public static Task<TResult> JMFHAHKJHHJ<TResult>(this Task<TResult> BDCCICFJHCL, CancellationToken HACFGBHNOCC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x337FA30", Offset = "0x337E830", VA = "0x18337FA30")]
	public static TaskCompletionSource<TResult> JMFHAHKJHHJ<TResult>(this TaskCompletionSource<TResult> FCHHBDBKHLJ, CancellationToken HACFGBHNOCC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7382520", Offset = "0x7381320", VA = "0x187382520")]
	public static IDisposable? KBGNLOAALNP(CancellationToken KFCNMAKKCMG, CancellationToken GKCDMMEBDNA, [Out] CancellationToken KBKMJAOLJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7381490", Offset = "0x7380290", VA = "0x187381490")]
	[AsyncStateMachine(typeof(EOFODIEKLDP))]
	public static void CEPGPGKFMJI(this Task DHJLEBFEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x73820E0", Offset = "0x7380EE0", VA = "0x1873820E0")]
	[AsyncStateMachine(typeof(NPLAADJKAPF))]
	public static void JEIFFMKELJF(this Task DHJLEBFEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x33803C0", Offset = "0x337F1C0", VA = "0x1833803C0")]
	[AsyncStateMachine(typeof(JOONBMDHJNF<>))]
	public static Task KFGFMDMLMON<TException>(this Task DHJLEBFEJME) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3380490", Offset = "0x337F290", VA = "0x183380490")]
	[AsyncStateMachine(typeof(OFDNOJAKEFK<>))]
	public static Task<T> KKOGBECJEJK<T>(this Task<T> DJAJDIFOIHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7381990", Offset = "0x7380790", VA = "0x187381990")]
	[AsyncStateMachine(typeof(HOOEHMJPGNK))]
	public static Task<TaskStatus> EBMOJKKDEHP(this Task DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x337BCB0", Offset = "0x337AAB0", VA = "0x18337BCB0")]
	public static (Task<T?>?, Action<T?>?) IKMEPOAIPPN<T>([Optional] CancellationToken FEHCANHDGHE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x337BBA0", Offset = "0x337A9A0", VA = "0x18337BBA0")]
	[AsyncStateMachine(typeof(PMGNICGGHMI<, >))]
	public static Task<List<TResult>> FNHHIKJHHFG<TResult, TInput>(this Task<List<TInput>> BDCCICFJHCL, PBAJAFOOPLD<TInput, TResult> LFKNFBPFIHB) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7381360", Offset = "0x7380160", VA = "0x187381360")]
	[AsyncStateMachine(typeof(IFEALIMHMGJ))]
	public static Task BBJKEPBGJDB(Task DHJLEBFEJME, CancellationToken JHKFKNKNOJO, Func<CancellationToken, Task> FLOIKENGODO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7382190", Offset = "0x7380F90", VA = "0x187382190")]
	[AsyncStateMachine(typeof(KDKEGDMMMMI))]
	public static Task JKLDIBDGMEG(Func<CancellationToken, Task> GGMMKCDMKPP, TimeSpan BHBDEJJKCAE, [Optional] CancellationToken JHKFKNKNOJO, [Optional] Action<OperationCanceledException>? KFLABJONKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x337BF30", Offset = "0x337AD30", VA = "0x18337BF30")]
	[AsyncStateMachine(typeof(ANBOAAGNFGP<>))]
	public static Task<T> JKLDIBDGMEG<T>(Func<CancellationToken, Task<T>> GGMMKCDMKPP, TimeSpan BHBDEJJKCAE, [Optional] CancellationToken JHKFKNKNOJO, [Optional] Func<OperationCanceledException, T>? KFLABJONKJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7381F40", Offset = "0x7380D40", VA = "0x187381F40")]
	public static Task HGHNPHFPDGB(params Task[] DHPALPBHDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7381A80", Offset = "0x7380880", VA = "0x187381A80")]
	public static Task HGHNPHFPDGB(IEnumerable<Task> DHPALPBHDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3380760", Offset = "0x337F560", VA = "0x183380760")]
	[AsyncStateMachine(typeof(JDILNLJFNLN<>))]
	public static Task<IEnumerable<Task<T>>> MKJGIKODAPG<T>(IEnumerable<Task<T>> DHPALPBHDNN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3380AC0", Offset = "0x337F8C0", VA = "0x183380AC0")]
	[AsyncStateMachine(typeof(IGLANACGDNE<, , , >))]
	public static Task<(T1, T2, T3, T4)> PNJNIHFINMF<T1, T2, T3, T4>(Task<T1> HPEDGGOAKLD, Task<T2> FHGAJKPBBAE, Task<T3> AEGDLFNOJJM, Task<T4> KJHOKFOOEIO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7382A80", Offset = "0x7381880", VA = "0x187382A80")]
	[AsyncStateMachine(typeof(PEDOFKGFMJJ))]
	public static Task MBDINAFFKJN(Func<bool> PKDNIKFJMDJ, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7382970", Offset = "0x7381770", VA = "0x187382970")]
	[AsyncStateMachine(typeof(HFAHCEPLEKE))]
	public static Task MBDINAFFKJN(Func<bool> PKDNIKFJMDJ, TimeSpan KOICGBJPOHH, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7382DF0", Offset = "0x7381BF0", VA = "0x187382DF0")]
	[AsyncStateMachine(typeof(KECFDBHOOPA))]
	public static Task PADBGCMGKBD(Func<bool> PKDNIKFJMDJ, TimeSpan BHBDEJJKCAE, [Optional] CancellationToken FEHCANHDGHE, [Optional] Action<OperationCanceledException>? KFLABJONKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7382CB0", Offset = "0x7381AB0", VA = "0x187382CB0")]
	[AsyncStateMachine(typeof(BOMLACIOFAI))]
	public static Task PADBGCMGKBD(Func<bool> PKDNIKFJMDJ, TimeSpan BHBDEJJKCAE, TimeSpan KOICGBJPOHH, [Optional] CancellationToken FEHCANHDGHE, [Optional] Action<OperationCanceledException>? KFLABJONKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7383080", Offset = "0x7381E80", VA = "0x187383080")]
	[AsyncStateMachine(typeof(HLNFPDIHELP))]
	public static Task PLMEBHPFMEP(Func<bool> PKDNIKFJMDJ, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7382F70", Offset = "0x7381D70", VA = "0x187382F70")]
	[AsyncStateMachine(typeof(FLAPPAHMBPL))]
	public static Task PLMEBHPFMEP(Func<bool> PKDNIKFJMDJ, TimeSpan KOICGBJPOHH, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7381020", Offset = "0x737FE20", VA = "0x187381020")]
	[AsyncStateMachine(typeof(JBKGOBNIGNI))]
	public static Task ALPNOHLLFOE(Func<bool> PKDNIKFJMDJ, TimeSpan BHBDEJJKCAE, [Optional] CancellationToken FEHCANHDGHE, [Optional] Action<OperationCanceledException>? KFLABJONKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7381150", Offset = "0x737FF50", VA = "0x187381150")]
	[AsyncStateMachine(typeof(AGODHPKMFII))]
	public static Task ALPNOHLLFOE(Func<bool> PKDNIKFJMDJ, TimeSpan BHBDEJJKCAE, TimeSpan KOICGBJPOHH, [Optional] CancellationToken FEHCANHDGHE, [Optional] Action<OperationCanceledException>? KFLABJONKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7382B70", Offset = "0x7381970", VA = "0x187382B70")]
	[AsyncStateMachine(typeof(IODILCEAGBL))]
	[Obsolete]
	public static Task NNAPGNBKAIJ(this Task BDCCICFJHCL, Action LAAGMOFCAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3380850", Offset = "0x337F650", VA = "0x183380850")]
	[AsyncStateMachine(typeof(HHGDNDPIGLJ<>))]
	[Obsolete]
	public static Task NNAPGNBKAIJ<T>(this Task<T> BDCCICFJHCL, Action<T> LAAGMOFCAGG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7382730", Offset = "0x7381530", VA = "0x187382730")]
	private static void KNNHPGMEIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7381610", Offset = "0x7380410", VA = "0x187381610")]
	public static bool DGNBNHLBNHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73827E0", Offset = "0x73815E0", VA = "0x1873827E0")]
	private static void LFNABCJFMCF(SynchronizationContext IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7381FC0", Offset = "0x7380DC0", VA = "0x187381FC0")]
	private static void IFHEPJKLPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7381290", Offset = "0x7380090", VA = "0x187381290")]
	public static void ANDOCKPNPDA([Optional] string? KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x73826B0", Offset = "0x73814B0", VA = "0x1873826B0")]
	public static void KHIMJKOKGIM([Optional] string? KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7382F20", Offset = "0x7381D20", VA = "0x187382F20")]
	public static NFKJEPBEHCH PJPFDMIFHON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7382C60", Offset = "0x7381A60", VA = "0x187382C60")]
	public static NFKJEPBEHCH OILBDBENAIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7381540", Offset = "0x7380340", VA = "0x187381540")]
	[AsyncStateMachine(typeof(AHBDADICFGN))]
	public static Task COJLMKJDJII(Func<Task> LLGCEMPPLIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HLDENJBKDHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public HLDENJBKDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class FDBAJJODKMH : NEJIHKJGMOP
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly NEJIHKJGMOP GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime MAFOCIJCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x737C9B0", Offset = "0x737B7B0", VA = "0x18737C9B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset DNAJONKENML
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x737C9F0", Offset = "0x737B7F0", VA = "0x18737C9F0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public FDBAJJODKMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NEJIHKJGMOP
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime MAFOCIJCAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset DNAJONKENML
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FIOBFCNDHII
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long AFFGKMGNEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x737CDC0", Offset = "0x737BBC0", VA = "0x18737CDC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long PJHBKFJPJFE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x737CF00", Offset = "0x737BD00", VA = "0x18737CF00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double JEEICEGEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x737CFE0", Offset = "0x737BDE0", VA = "0x18737CFE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double OIALKONDNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x737CC80", Offset = "0x737BA80", VA = "0x18737CC80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double LDGKJDLHGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x737CD60", Offset = "0x737BB60", VA = "0x18737CD60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double ILNPHEENPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x737CB60", Offset = "0x737B960", VA = "0x18737CB60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x737CAD0", Offset = "0x737B8D0", VA = "0x18737CAD0")]
	public static double CDCAIMIKPMD(long LMHNJACCHIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x737CE10", Offset = "0x737BC10", VA = "0x18737CE10")]
	public static double HJDKDCIMHDE(long LMHNJACCHIH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x737CF50", Offset = "0x737BD50", VA = "0x18737CF50")]
	public static double KMHJEMNJMIO(double BFLNCHEGFBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x737CCD0", Offset = "0x737BAD0", VA = "0x18737CCD0")]
	public static long EPJOHNKKFGP(long CIOLBCCFHKE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x737CDB0", Offset = "0x737BBB0", VA = "0x18737CDB0")]
	public static long GEBENNFMCIA(long HFICDOJIMIK, long ONMLBMNHDOL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x737CBB0", Offset = "0x737B9B0", VA = "0x18737CBB0")]
	public static double DOMDFIBOGHP(long HFICDOJIMIK, long ONMLBMNHDOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x737CEA0", Offset = "0x737BCA0", VA = "0x18737CEA0")]
	public static double JNJMAJOAEME(long HFICDOJIMIK, long ONMLBMNHDOL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class KALAJMEFEHO : OGONOFCBGBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly TimeSpan PHCDCFHFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly System.Timers.Timer HPEGCCHCIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private TimeSpan BHBDEJJKCAE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan OKCEMPLFFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7380950", Offset = "0x737F750", VA = "0x187380950", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? NGIOHBKPMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7380FB0", Offset = "0x737FDB0", VA = "0x187380FB0")]
	[Preserve]
	public KALAJMEFEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7380D60", Offset = "0x737FB60", VA = "0x187380D60")]
	public KALAJMEFEHO(TimeSpan BHBDEJJKCAE, [Optional] Action? HJJCMHANDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7380C60", Offset = "0x737FA60", VA = "0x187380C60", Slot = "7")]
	public void ODCOABNFDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7380BF0", Offset = "0x737F9F0", VA = "0x187380BF0", Slot = "8")]
	public void IEPIPFLKMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7380920", Offset = "0x737F720", VA = "0x187380920", Slot = "9")]
	public void BIPLBHKIMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xF909B0", Offset = "0xF8F7B0", VA = "0x180F909B0")]
	private void OHHBAFOIKEK(object BHICHJIFLJC, ElapsedEventArgs CMGCOMJILMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7380B50", Offset = "0x737F950", VA = "0x187380B50")]
	private static void EPILEPEKPAO(TimeSpan CPMFNOODINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7380AB0", Offset = "0x737F8B0", VA = "0x187380AB0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class OLBEHBOLMGB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly string? FJLHKMHMACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string FIKGLOIENEJ;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D93610", Offset = "0x6D92410", VA = "0x186D93610")]
	public OLBEHBOLMGB(string CHJIHJFAIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x45311E0", Offset = "0x452FFE0", VA = "0x1845311E0")]
	public OLBEHBOLMGB(string LCGMANEHHDK, string CHJIHJFAIKD)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OJEEBABOFGM : IEquatable<OJEEBABOFGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint JHONMEGECDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int DOCINPAPCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float IGALFHNHJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort BLJKCKHEGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort GGHOCHBGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public short NHHKBEFDPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short BIHDBJFLCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public char FGABBFDGFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char AFDCMJHAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte GFCMCLKMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte BDCDBBDLHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte APDJFBNBJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte KLFGLCDBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public bool MAEPFGCFAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool NFJNMPOKPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool CLIHENIDALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool FLPHGAHGAKK;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0020", Offset = "0x1BEEE20", VA = "0x181BF0020")]
	public static OJEEBABOFGM KAEOJFNJMEJ(uint BJINJPKBAPH)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0020", Offset = "0x1BEEE20", VA = "0x181BF0020")]
	public static OJEEBABOFGM EHJPDBJPCGJ(int CCJBCEDNBPH)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x73854F0", Offset = "0x73842F0", VA = "0x1873854F0")]
	public static OJEEBABOFGM KCDHGIJCLGF(float FMGIEJCOKGA)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7385440", Offset = "0x7384240", VA = "0x187385440")]
	public static OJEEBABOFGM DALDDGLANPA(byte OFHPNAKCDNI, byte LDBIBLBJGCI, byte KNFFCBDOLFH, byte BAMDADOJCKO)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7385440", Offset = "0x7384240", VA = "0x187385440")]
	public static OJEEBABOFGM FMNHIKNEJED(bool DOEBGKCPDME, bool MKHIBOOELFP, bool IOBLPLKBMFM, bool CAHBIHALADD)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7385440", Offset = "0x7384240", VA = "0x187385440")]
	public static OJEEBABOFGM GCMBEGFDCPI(byte OJADOCHPLFD, byte AKBDNBFBFBP, byte CGKHKPKAEID, byte JHJMKCIINJK)
	{
		return default(OJEEBABOFGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1ED9E80", Offset = "0x1ED8C80", VA = "0x181ED9E80")]
	public static bool BHDCHHANDIG(OJEEBABOFGM NMOPBJNEFKL, OJEEBABOFGM KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1ED9E60", Offset = "0x1ED8C60", VA = "0x181ED9E60", Slot = "4")]
	public bool Equals(OJEEBABOFGM LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7385460", Offset = "0x7384260", VA = "0x187385460", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x110BB30", Offset = "0x110A930", VA = "0x18110BB30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7385500", Offset = "0x7384300", VA = "0x187385500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct OKJJHPABEFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public ulong KLNMAMEGMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public long INBCCIHNGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public double OHDEGJALDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public uint HFBFDLDGPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint LBMFFKICBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int APFHDNPMBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int BLJKILEAGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public float NHOFBNMCILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float DHHGLLEDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort BLJKCKHEGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort GGHOCHBGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort GFBIGPMOPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort NNFEKGCEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public short NHHKBEFDPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short BIHDBJFLCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short PJDNPICLEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short CHLHADJCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public char FGABBFDGFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char AFDCMJHAOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char LJNIBDNKMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char GFPEMBKCDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public byte GFCMCLKMIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte BDCDBBDLHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte APDJFBNBJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte KLFGLCDBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte GFDIGGAEMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte DBKMBJPPEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte BHKJHDKJCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte AMDBGEOLOAK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static OKJJHPABEFE MKHEJJEDOII(long ABNPANIMDKN)
	{
		return default(OKJJHPABEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7386CB0", Offset = "0x7385AB0", VA = "0x187386CB0")]
	public static OKJJHPABEFE MKHEJJEDOII(byte OFHPNAKCDNI, byte LDBIBLBJGCI, byte KNFFCBDOLFH, byte BAMDADOJCKO, byte OOGAADBCMHG, byte CFEEOEOHICI, byte HALLIMOFJIM, byte BOGNPAEBBCL)
	{
		return default(OKJJHPABEFE);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PBCLHBHJAMJ : IEquatable<PBCLHBHJAMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte EHAKJGKKFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool FFOHBKFGAGD;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FA00", Offset = "0x2B7E800", VA = "0x182B7FA00")]
	public static PBCLHBHJAMJ DALDDGLANPA(byte KHHBDNOCPMO)
	{
		return default(PBCLHBHJAMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FA00", Offset = "0x2B7E800", VA = "0x182B7FA00")]
	public static PBCLHBHJAMJ FMNHIKNEJED(bool EKIDKHHJPHL)
	{
		return default(PBCLHBHJAMJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7386D00", Offset = "0x7385B00", VA = "0x187386D00")]
	public static bool BHDCHHANDIG(PBCLHBHJAMJ NMOPBJNEFKL, PBCLHBHJAMJ KCJDGOIFCIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6441B10", Offset = "0x6440910", VA = "0x186441B10", Slot = "4")]
	public bool Equals(PBCLHBHJAMJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7386D10", Offset = "0x7385B10", VA = "0x187386D10", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7386DA0", Offset = "0x7385BA0", VA = "0x187386DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7386DB0", Offset = "0x7385BB0", VA = "0x187386DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OHECCOLLAIA<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly T HHJNIFJIAOB;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4E43170", Offset = "0x4E41F70", VA = "0x184E43170")]
	public OHECCOLLAIA(T CGOECEPNFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PGFIBCHLJDE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x33B0170", Offset = "0x33AEF70", VA = "0x1833B0170")]
	public static IEnumerable<T> IGBMAMFFIGE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static T[] ONFLMAJFIEP<T>(params T[] PBFGMDLNFGL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static IEnumerable<T> ICJGOECBPAL<T>(params T[] PBFGMDLNFGL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static HashSet<T> BFEEOPOOIDP<T>(params T[] PBFGMDLNFGL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x349D9B0", Offset = "0x349C7B0", VA = "0x18349D9B0")]
	public static KeyValuePair<TKey, TValue> PIBGPCJCLFB<TKey, TValue>([In] TKey FFOHLCGHDKA, [In] TValue IPHILEOFJLB) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static List<T> PKFLJBAJOEJ<T>(IEnumerable<T> CMEOIDEONPB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JOBGNIMLPCB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly string OICEJMLIMFI;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
	public JOBGNIMLPCB(string CPMDMKKPICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object MNPGLALFOBO<T>([In] T EHEEIKICBAM);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object NNCBFLKOAEM<T>(T EHEEIKICBAM);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[GCDAKCHJOEM]
public delegate string PKIPHPNOOLD(string MBNPKKJMDHG, string? KBFABHDAKIJ, bool JLOGJLMGNJJ);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GCDAKCHJOEM]
public delegate void LAGNMEGGMBN(string KKBJAPCBOHH);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[GCDAKCHJOEM]
public delegate void EFFJEPJBHLB(Exception JGLOLGKKBMI);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object OIKBCHJGEKA();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GCDAKCHJOEM]
public delegate bool FFIHJLDDIBC();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GCDAKCHJOEM]
public delegate string CEAECOCGINC(object JOOHPPHJKMI);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class MLCHEIGEFNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public MLCHEIGEFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class KHAIMFOJIIA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct OKBAAPEOLEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7386360", Offset = "0x7385160", VA = "0x187386360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7386C40", Offset = "0x7385A40", VA = "0x187386C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly TimerCallback LIAPIJHHBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly Action<object?> DFHMJJHCMJG;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7383C20", Offset = "0x7382A20", VA = "0x187383C20")]
	public static Task<bool> JBAPENDHPJO(int ALIBPNHIGOO, [Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7383FC0", Offset = "0x7382DC0", VA = "0x187383FC0")]
	[AsyncStateMachine(typeof(OKBAAPEOLEH))]
	private static Task<bool> MMPKCLKFMBK(int ALIBPNHIGOO, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7383B90", Offset = "0x7382990", VA = "0x187383B90")]
	private static void DNGNENMMADO(object? DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7383F30", Offset = "0x7382D30", VA = "0x187383F30")]
	private static void KMIMCJBMKDO(object? DKNLFDPIIII)
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
