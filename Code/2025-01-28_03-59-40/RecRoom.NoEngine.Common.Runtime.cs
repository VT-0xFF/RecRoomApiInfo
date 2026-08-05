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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x73279C0", Offset = "0x7326BC0", VA = "0x1873279C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JJDFIODLPIE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7324ED0", Offset = "0x73240D0", VA = "0x187324ED0")]
	public static string EJGAHHNBKMF(this Encoding LHIBAOIJIMM, [In] ReadOnlySequence<byte> JIGDFCPIKCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32F7D00", Offset = "0x32F6F00", VA = "0x1832F7D00")]
	private static void LEDAIPDFAHK<T>(this ReadOnlySequence<T> EKBKLDIKAHB, [Out] ReadOnlySpan<T> PNAJPLIELHI, [Out] SequencePosition FCKHEFJCHLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class CCPLDIGPIEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x731D6C0", Offset = "0x731C8C0", VA = "0x18731D6C0")]
	public CCPLDIGPIEM(bool EMMLGHHCLKF, string JKPHGPKGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x731D790", Offset = "0x731C990", VA = "0x18731D790")]
	public CCPLDIGPIEM(bool EMMLGHHCLKF, params string[] MBLAPHLGBKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OLPPPEFFHGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JBGDABDCCEP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NPLMEFEFJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJLJBIAGPNA(string OFPBICPHALF, double OMEFCJCOLII, [Optional] string? IPBKGNAHLMH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HIHBEPMAKMI : GNLOBLOEEJM, PBBFIPFMJDG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NBHCOIDNNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> NEFDIOKNKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double KKNLKEIKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double HEMGJLGOHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double COFIFDJIJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PFIDCIMFHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double OFLPAKMGBPI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MBIDLELKABL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x911450", Offset = "0x910650", VA = "0x180911450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double CBNAEJLNGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7322CE0", Offset = "0x7321EE0", VA = "0x187322CE0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JPMJKJLAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42F12D0", Offset = "0x42F04D0", VA = "0x1842F12D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double OLJJAHBNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x24B32E0", Offset = "0x24B24E0", VA = "0x1824B32E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7322DB0", Offset = "0x7321FB0", VA = "0x187322DB0")]
	public HIHBEPMAKMI(int HNGECMJIDHB, double OFLPAKMGBPI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7322BB0", Offset = "0x7321DB0", VA = "0x187322BB0", Slot = "7")]
	public void KKFGGCFBHLN(double IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7322D40", Offset = "0x7321F40", VA = "0x187322D40", Slot = "8")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7322AB0", Offset = "0x7321CB0", VA = "0x187322AB0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CDNKECENNGM : GNLOBLOEEJM, PBBFIPFMJDG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long EOKNBJLIKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double FMPPPEAGPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double ABHGPAPPPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double EOOHPKMFGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double PLOIBOJFFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double KKNLKEIKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double HEMGJLGOHMA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JPMJKJLAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6710890", Offset = "0x670FA90", VA = "0x186710890", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OLJJAHBNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6710900", Offset = "0x670FB00", VA = "0x186710900", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double NFICMABOBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6710D90", Offset = "0x670FF90", VA = "0x186710D90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CBNAEJLNGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B38E90", Offset = "0x2B38090", VA = "0x182B38E90", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x731DE00", Offset = "0x731D000", VA = "0x18731DE00", Slot = "10")]
	public virtual void KKFGGCFBHLN(double IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x731DF20", Offset = "0x731D120", VA = "0x18731DF20", Slot = "11")]
	public virtual void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x731DD90", Offset = "0x731CF90", VA = "0x18731DD90", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x731DF60", Offset = "0x731D160", VA = "0x18731DF60")]
	public CDNKECENNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DENJFEHFNII : CDNKECENNGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double DHILLHKJBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67108F0", Offset = "0x670FAF0", VA = "0x1867108F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67108E0", Offset = "0x670FAE0", VA = "0x1867108E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x731EF50", Offset = "0x731E150", VA = "0x18731EF50", Slot = "10")]
	public override void KKFGGCFBHLN(double IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x731F080", Offset = "0x731E280", VA = "0x18731F080", Slot = "11")]
	public override void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x731DF60", Offset = "0x731D160", VA = "0x18731DF60")]
	public DENJFEHFNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNLOBLOEEJM : PBBFIPFMJDG, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double CBNAEJLNGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JPMJKJLAFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double OLJJAHBNPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FMEGJAFLEAJ : PBBFIPFMJDG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double MHDPLLDKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double INHKMEEDDBB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73201C0", Offset = "0x731F3C0", VA = "0x1873201C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73201D0", Offset = "0x731F3D0", VA = "0x1873201D0", Slot = "4")]
	public void KKFGGCFBHLN(double IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73201E0", Offset = "0x731F3E0", VA = "0x1873201E0", Slot = "5")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7320170", Offset = "0x731F370", VA = "0x187320170", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public FMEGJAFLEAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PBBFIPFMJDG : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKFGGCFBHLN(double IAPIOFHOONE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKECIINHNOA();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BHGFFMBPBDF : PBBFIPFMJDG, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OMEFCJCOLII;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double ELOFPHHKCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3EC0", Offset = "0x3FC30C0", VA = "0x183FC3EC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C598F0", Offset = "0x4C58AF0", VA = "0x184C598F0", Slot = "4")]
	public void KKFGGCFBHLN(double IAPIOFHOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x731D440", Offset = "0x731C640", VA = "0x18731D440", Slot = "5")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x731D3F0", Offset = "0x731C5F0", VA = "0x18731D3F0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public BHGFFMBPBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FLMDEDBNAEK<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> OMNADMBOOMN(CancellationToken BGEKICMONBE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LPIJPHDAMCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FLMDEDBNAEK<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OMNADMBOOMN taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4A0FA60", Offset = "0x4A0EC60", VA = "0x184A0FA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4A10B20", Offset = "0x4A0FD20", VA = "0x184A10B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource BCFACPBIPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? PPHMIFEEFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? CFBGCBLGMPE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x42F33C0", Offset = "0x42F25C0", VA = "0x1842F33C0")]
	[AsyncStateMachine(typeof(FLMDEDBNAEK<>.LPIJPHDAMCN))]
	public Task<TResult> FCHCOHCPOCK(OMNADMBOOMN FACDHNGMGKD, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x42F3350", Offset = "0x42F2550", VA = "0x1842F3350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42F3500", Offset = "0x42F2700", VA = "0x1842F3500")]
	public FLMDEDBNAEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CPGCAGMIJON<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> DOMLMIGJBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T ELOFPHHKCIM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F41470", Offset = "0x4F40670", VA = "0x184F41470")]
	public CPGCAGMIJON([In] T OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x588E760", Offset = "0x588D960", VA = "0x18588E760", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x588EE60", Offset = "0x588E060", VA = "0x18588EE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x588EF30", Offset = "0x588E130", VA = "0x18588EF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BJGKGLEAFHD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static CPGCAGMIJON<T> PAJOIGLPBMN<T>([In] T OMEFCJCOLII) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BPMHGOOGACK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x731D690", Offset = "0x731C890", VA = "0x18731D690")]
	public static void PDEBNBLNABO(this CancellationTokenSource BCFACPBIPCL, bool HICEIMEEOGC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class GFJAEGEBONN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public GFJAEGEBONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class ALKCGLMHGAP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public ALKCGLMHGAP(string POMNLBGENEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IFFGLJKOIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32B20F0", Offset = "0x32B12F0", VA = "0x1832B20F0")]
	public static EMELGOKCCFD MPJMOLGBBGG<T>()
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x32B1F00", Offset = "0x32B1100", VA = "0x1832B1F00")]
	public static EMELGOKCCFD EOCAMACCCNE<T>([CallerMemberName] string LMOANCJLHKC = "") where T : notnull
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32B2170", Offset = "0x32B1370", VA = "0x1832B2170")]
	public static EMELGOKCCFD MPJMOLGBBGG<T>(this T PIEFIBOFCOC) where T : notnull
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32B1FA0", Offset = "0x32B11A0", VA = "0x1832B1FA0")]
	public static EMELGOKCCFD MFLIBBHNGHF<T>(this T PIEFIBOFCOC, [CallerMemberName] string LMOANCJLHKC = "") where T : notnull
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32B1E50", Offset = "0x32B1050", VA = "0x1832B1E50")]
	public static EMELGOKCCFD EOCAMACCCNE<T>(this T MLNFAKCEGNM, [CallerMemberName] string LMOANCJLHKC = "") where T : notnull
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73233C0", Offset = "0x73225C0", VA = "0x1873233C0")]
	public static EMELGOKCCFD EOCAMACCCNE(string HBMBHOGGFMA, [CallerMemberName] string LMOANCJLHKC = "")
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7323320", Offset = "0x7322520", VA = "0x187323320")]
	public static string ALJPJLMKBFO(this object MLNFAKCEGNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool CFLHPNJJCFA();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[GFJAEGEBONN]
public delegate long DCNGIABMCOF();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JEFDNCHNPCE
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static JHECLOAJMOO IPBKOECHDNB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JHECLOAJMOO FPMFAFCNFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7323C20", Offset = "0x7322E20", VA = "0x187323C20")]
		get
		{
			return default(JHECLOAJMOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JLKKPODDDIL HCMFIICHODP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7323810", Offset = "0x7322A10", VA = "0x187323810")]
		get
		{
			return default(JLKKPODDDIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static OMCGMIFFPIK IDLHDBCIKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7323E80", Offset = "0x7323080", VA = "0x187323E80")]
		get
		{
			return default(OMCGMIFFPIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool ELIGOHBPNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7323ED0", Offset = "0x73230D0", VA = "0x187323ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7323A70", Offset = "0x7322C70", VA = "0x187323A70")]
	public static void KNEBJHFBLJB([In] JHECLOAJMOO NOFOBPBDDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7323900", Offset = "0x7322B00", VA = "0x187323900")]
	public static void IKHOJNLBJOK(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7323CE0", Offset = "0x7322EE0", VA = "0x187323CE0")]
	public static void NDLLJOKOENK(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32F1D40", Offset = "0x32F0F40", VA = "0x1832F1D40")]
	public static void NDLLJOKOENK<T>(T CJJMPIPLCIJ, LNBKGOCCHGJ<T> CBCJFCINKPJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7323860", Offset = "0x7322A60", VA = "0x187323860")]
	public static void HJLIGKLLEID(Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7323FB0", Offset = "0x73231B0", VA = "0x187323FB0")]
	public static void PMKHAJANMLH(string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7323C70", Offset = "0x7322E70", VA = "0x187323C70")]
	public static void NCHMFBMAMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7323790", Offset = "0x7322990", VA = "0x187323790")]
	public static string ALJPJLMKBFO(object LCACGJDNDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7323F40", Offset = "0x7323140", VA = "0x187323F40")]
	public static long PGCCBLMBKEE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x73239D0", Offset = "0x7322BD0", VA = "0x1873239D0")]
	public static bool KFOPJBDHKEO(bool PBMHCOIDBNB, string CBCJFCINKPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7323DB0", Offset = "0x7322FB0", VA = "0x187323DB0")]
	public static double NDMNDGGIAIL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct JHECLOAJMOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly JLKKPODDDIL HCMFIICHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly OMCGMIFFPIK IDLHDBCIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly OMGNILIIFIH MAEBHBNBBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly DCNGIABMCOF LKOIBLFLFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly PNOHJEHALCK PCGMGJDFAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly CFLHPNJJCFA EDEPBFDOFHG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly OMGNILIIFIH PDODGNCBADM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly DCNGIABMCOF OIPNFKMDKBH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly PNOHJEHALCK FNHBINOPCDD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly CFLHPNJJCFA CPDLHENDJIL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly JHECLOAJMOO GNFCEACADKD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PHKHHDPEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7324200", Offset = "0x7323400", VA = "0x187324200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7324AD0", Offset = "0x7323CD0", VA = "0x187324AD0")]
	public JHECLOAJMOO([In] JLKKPODDDIL GLIGKEAHFDE, [In] OMCGMIFFPIK PAEDLLPCJOF, OMGNILIIFIH GHANJMLAHHC, DCNGIABMCOF BHOJMCAPIJB, PNOHJEHALCK CFJKGMDINKJ, CFLHPNJJCFA FAEPBOCJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73243A0", Offset = "0x73235A0", VA = "0x1873243A0")]
	private static string KPEAAPIMBKJ(object LCACGJDNDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90")]
	private static long HGKBFIMMGNB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	private static string JBFMPNABKOM(string JJOHJKDMMOB, string? DHKGEFAKBIG, bool DDKHPNFANIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	private static bool OOCDEFEIKEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73240F0", Offset = "0x73232F0", VA = "0x1873240F0")]
	private static JHECLOAJMOO ADBICMLDKMF()
	{
		return default(JHECLOAJMOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GJGCAJKCHDE
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPIPGFBOBNE LGLANLJPMBI();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GPIPGFBOBNE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LIOPPBMFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMCHGKBAACI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GAKMMOLOCMH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGHAOLIMNHA([In] T JAINJPLCLDO);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void MPAOJIFDEMF<T>([In] T CJJMPIPLCIJ);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct LOJCNILOOLO<T> : IEquatable<LOJCNILOOLO<T>>, GAKMMOLOCMH<LOJCNILOOLO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T ELOFPHHKCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int JDABKJNJMBH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A0ED90", Offset = "0x4A0DF90", VA = "0x184A0ED90")]
	public LOJCNILOOLO([In] T OMEFCJCOLII, int CPLNODNGKGB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A0CCE0", Offset = "0x4A0BEE0", VA = "0x184A0CCE0")]
	public static bool CCHBIHOFELC([In] LOJCNILOOLO<T> LFOFDHEGDLC, [In] LOJCNILOOLO<T> KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4A0D2E0", Offset = "0x4A0C4E0", VA = "0x184A0D2E0", Slot = "4")]
	public bool Equals(LOJCNILOOLO<T> JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x42F0E80", Offset = "0x42F0080", VA = "0x1842F0E80", Slot = "0")]
	public override bool Equals(object JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A0DCE0", Offset = "0x4A0CEE0", VA = "0x184A0DCE0")]
	public bool JGHAOLIMNHA([In] LOJCNILOOLO<T> JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A0DBB0", Offset = "0x4A0CDB0", VA = "0x184A0DBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A0E570", Offset = "0x4A0D770", VA = "0x184A0E570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A0E210", Offset = "0x4A0D410", VA = "0x184A0E210")]
	public void NLHBJIEEJHA([Out] T OMEFCJCOLII, [Out] int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A0D4D0", Offset = "0x4A0C6D0", VA = "0x184A0D4D0")]
	public (T, int) GPGAEEHDNCF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A0D370", Offset = "0x4A0C570", VA = "0x184A0D370", Slot = "5")]
	private bool FFCDJCKDDIH([In] LOJCNILOOLO<T> JAINJPLCLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FAIGJOLEGEE
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3245DD0", Offset = "0x3244FD0", VA = "0x183245DD0")]
	public static LOJCNILOOLO<T> PAJOIGLPBMN<T>([In] T OMEFCJCOLII, int CPLNODNGKGB) where T : notnull
	{
		return default(LOJCNILOOLO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JJMFMKOKEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x32F8960", Offset = "0x32F7B60", VA = "0x1832F8960")]
	public static bool JGHAOLIMNHA<T, U>([In] T MLNFAKCEGNM, [In] U LCACGJDNDHA) where T : notnull, GAKMMOLOCMH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult IMEKGNEIHJK<T, out TResult>([In] T CJJMPIPLCIJ);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HKANKPBEDCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan MMBJIABPAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? ABMPLFCCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFJDLLOGLKA();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPCBDCLKAKO();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKBPOJHGOEI();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct JLKKPODDDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IGHMEHNJCED HDKMOEPBBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DLLJAOJGHHF FOCPFBLENLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IGHMEHNJCED LGHEMJIIGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DLLJAOJGHHF NKHOHJNNEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IGHMEHNJCED PDDBCBBCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly DLLJAOJGHHF HLEJJOOMCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly DIAKDABKIIJ POCLPHFJLHI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly IGHMEHNJCED PDMKHNLHAMG;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DLLJAOJGHHF OEIBFKCEKFG;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IGHMEHNJCED NPLFNECBMMK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DLLJAOJGHHF DNHJCOKDFIG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IGHMEHNJCED CCOCJKLLANH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DLLJAOJGHHF DFLHGFMMECH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly DIAKDABKIIJ GGKBGJOPBGK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JLKKPODDDIL GNFCEACADKD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly IGHMEHNJCED PMDNOJLKAFN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PHKHHDPEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7325650", Offset = "0x7324850", VA = "0x187325650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC01090", Offset = "0xC00290", VA = "0x180C01090")]
	public JLKKPODDDIL(IGHMEHNJCED NIKODGFMPDF, DLLJAOJGHHF GPAJGHOIFPA, IGHMEHNJCED OBFGKDCAHHL, DLLJAOJGHHF AJJJCDCPDBC, IGHMEHNJCED LILDHHCCKGG, DLLJAOJGHHF DGJBIIMNNEA, DIAKDABKIIJ CFOENBPNFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	private static bool GDABEGMAGOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void HPDALGCPACF(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	private static bool OOLGJIAGBDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void LODJJBDJJHF(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0")]
	private static bool MHPDDABJBKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void MIGAEFPGFDI(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void IHNEHFGHCMM(Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73254A0", Offset = "0x73246A0", VA = "0x1873254A0")]
	private static JLKKPODDDIL ADBICMLDKMF()
	{
		return default(JLKKPODDDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
	private static bool HFHNOOHGDOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73255E0", Offset = "0x73247E0", VA = "0x1873255E0")]
	public void IKHOJNLBJOK(object CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7325920", Offset = "0x7324B20", VA = "0x187325920")]
	public void NDLLJOKOENK(object CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xBF28B0", Offset = "0xBF1AB0", VA = "0x180BF28B0")]
	public void HJLIGKLLEID(Exception ANJHEGDKNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7325990", Offset = "0x7324B90", VA = "0x187325990")]
	public void NDLLJOKOENK(JBIPFCJFOAK CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32FBFC0", Offset = "0x32FB1C0", VA = "0x1832FBFC0")]
	public void NDLLJOKOENK<T>(T CJJMPIPLCIJ, LNBKGOCCHGJ<T> CBCJFCINKPJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32FBBB0", Offset = "0x32FADB0", VA = "0x1832FBBB0")]
	public void IKHOJNLBJOK<T>([In] T CJJMPIPLCIJ, KDPCIDAFCFF<T> CBCJFCINKPJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32FBD50", Offset = "0x32FAF50", VA = "0x1832FBD50")]
	public void NDLLJOKOENK<T>([In] T CJJMPIPLCIJ, KDPCIDAFCFF<T> CBCJFCINKPJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7325850", Offset = "0x7324A50", VA = "0x187325850")]
	public bool KFOPJBDHKEO(bool PBMHCOIDBNB, string CBCJFCINKPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct EMELGOKCCFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string ELOFPHHKCIM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xBC2740", Offset = "0xBC1940", VA = "0x180BC2740")]
	public EMELGOKCCFD(string OMEFCJCOLII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0")]
	public static string KEDBNOKLEHE([In] EMELGOKCCFD MLNFAKCEGNM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xFD0C10", Offset = "0xFCFE10", VA = "0x180FD0C10")]
	public static EMELGOKCCFD KEDBNOKLEHE(string JAINJPLCLDO)
	{
		return default(EMELGOKCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7320040", Offset = "0x731F240", VA = "0x187320040")]
	public string HCKLIGDNHFD(string GHBPPOOILHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7320090", Offset = "0x731F290", VA = "0x187320090")]
	public string KCIKJIELFNN(object DPADOCJEKLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class HBDNNHBMFPN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public HBDNNHBMFPN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct HEGEDEFNLEJ : IEquatable<HEGEDEFNLEJ>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "4")]
	public bool Equals(HEGEDEFNLEJ JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7322A20", Offset = "0x7321C20", VA = "0x187322A20", Slot = "0")]
	public override bool Equals(object JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7322A70", Offset = "0x7321C70", VA = "0x187322A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7322A80", Offset = "0x7321C80", VA = "0x187322A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CKOGIBPDLCN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IIKGGOMPAPK<T> : IEquatable<IIKGGOMPAPK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T ELOFPHHKCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool OIOOBNBJNKA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NGKFDJGAIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4646400", Offset = "0x4645600", VA = "0x184646400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4647480", Offset = "0x4646680", VA = "0x184647480")]
	public IIKGGOMPAPK([In] T OMEFCJCOLII, bool ANKHFENLGCC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46451C0", Offset = "0x46443C0", VA = "0x1846451C0")]
	public static bool CCHBIHOFELC([In] IIKGGOMPAPK<T> LFOFDHEGDLC, [In] IIKGGOMPAPK<T> KMPLOMOLJCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4645820", Offset = "0x4644A20", VA = "0x184645820", Slot = "4")]
	public bool Equals(IIKGGOMPAPK<T> JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46458B0", Offset = "0x4644AB0", VA = "0x1846458B0", Slot = "0")]
	public override bool Equals(object? JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46465F0", Offset = "0x46457F0", VA = "0x1846465F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46471E0", Offset = "0x46463E0", VA = "0x1846471E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DHFHLCEALLI
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x30F3030", Offset = "0x30F2230", VA = "0x1830F3030")]
	public static IIKGGOMPAPK<T> HFFBMOIBFEA<T>([In] T OMEFCJCOLII) where T : notnull
	{
		return default(IIKGGOMPAPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30F2E20", Offset = "0x30F2020", VA = "0x1830F2E20")]
	public static IIKGGOMPAPK<T?> DFEKGJLHBKB<T>()
	{
		return default(IIKGGOMPAPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30F3200", Offset = "0x30F2400", VA = "0x1830F3200")]
	public static bool PBLLCKFFBMD<T>([In] this IIKGGOMPAPK<T> DJIIFIMJFKC, [Out][NotNullWhen(true)] T OMEFCJCOLII) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x30F3190", Offset = "0x30F2390", VA = "0x1830F3190")]
	public static bool PBLLCKFFBMD<T>([In] this IIKGGOMPAPK<T> DJIIFIMJFKC, [Out][NotNullWhen(true)] T OMEFCJCOLII, [Out] IIKGGOMPAPK<T> BHGCDCOOCBH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x30F3130", Offset = "0x30F2330", VA = "0x1830F3130")]
	public static T? LBONFCFJCAE<T>([In] this IIKGGOMPAPK<T> DJIIFIMJFKC, T? JEBHMGJFPIP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x30F2C20", Offset = "0x30F1E20", VA = "0x1830F2C20")]
	public static bool AKACHEDDPPC<T>([In] this IIKGGOMPAPK<T> DJIIFIMJFKC, T OMEFCJCOLII) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KLGHJFDEDBL
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x33300D0", Offset = "0x332F2D0", VA = "0x1833300D0")]
	public static T JFPMOMKCBJH<T>([In] this IIKGGOMPAPK<T> DJIIFIMJFKC) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct OMCGMIFFPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr PMKHAJANMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr NCHMFBMAMNP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr EPHCPKGBDJH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr BEPKFNHCEMJ;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly OMCGMIFFPIK GNFCEACADKD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PHKHHDPEMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7328330", Offset = "0x7327530", VA = "0x187328330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x982390", Offset = "0x981590", VA = "0x180982390")]
	public OMCGMIFFPIK(IntPtr EPEKIABJBOL, IntPtr NKEDKINKKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void HGAALCMDOLA(string LMOANCJLHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
	private static void CNJJCLPKMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x73282A0", Offset = "0x73274A0", VA = "0x1873282A0")]
	private static OMCGMIFFPIK ADBICMLDKMF()
	{
		return default(OMCGMIFFPIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct GGMKNKIHHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr HLLNMIKKNGI;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
	private GGMKNKIHHHH(IntPtr NKEDKINKKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7320530", Offset = "0x731F730", VA = "0x187320530")]
	public void MFBFDNDBONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7320550", Offset = "0x731F750", VA = "0x187320550")]
	public static GGMKNKIHHHH PAJOIGLPBMN(string LMOANCJLHKC)
	{
		return default(GGMKNKIHHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2516E80", Offset = "0x2516080", VA = "0x182516E80")]
	public static GGMKNKIHHHH PAJOIGLPBMN([In] OMCGMIFFPIK PAEDLLPCJOF, string LMOANCJLHKC)
	{
		return default(GGMKNKIHHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2516F30", Offset = "0x2516130", VA = "0x182516F30")]
	public static GGMKNKIHHHH PAJOIGLPBMN([In] OMCGMIFFPIK PAEDLLPCJOF, Func<string> LMOANCJLHKC)
	{
		return default(GGMKNKIHHHH);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HAAJPEJAIAK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool NBHHNFMGLON<in TInput, TResult>(TInput DFKGLBJBJGD, [Out] TResult NJFLHCEDIDN);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class DLNNBKFGKKD : GJGCAJKCHDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class MBDOPNPEFGG : GPIPGFBOBNE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly MBDOPNPEFGG CLACNPDFIIL;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool LIOPPBMFEAM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x7326620", Offset = "0x7325820", VA = "0x187326620", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7326680", Offset = "0x7325880", VA = "0x187326680", Slot = "6")]
			public void OnCompleted(Action MDMNEIJBAPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			public void EMCHGKBAACI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public MBDOPNPEFGG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly DLNNBKFGKKD CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		private DLNNBKFGKKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x731F130", Offset = "0x731E330", VA = "0x18731F130", Slot = "4")]
		public GPIPGFBOBNE LGLANLJPMBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class ALDKJKFGPJJ : GJGCAJKCHDE
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class GNBPJKMCCGF : GPIPGFBOBNE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly GNBPJKMCCGF CLACNPDFIIL;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool LIOPPBMFEAM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x73206B0", Offset = "0x731F8B0", VA = "0x1873206B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x73206D0", Offset = "0x731F8D0", VA = "0x1873206D0", Slot = "6")]
			public void OnCompleted(Action MDMNEIJBAPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			public void EMCHGKBAACI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public GNBPJKMCCGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly ALDKJKFGPJJ CLACNPDFIIL;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		private ALDKJKFGPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x731CCB0", Offset = "0x731BEB0", VA = "0x18731CCB0", Slot = "4")]
		public GPIPGFBOBNE LGLANLJPMBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FGBOJIMIGPE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FGBOJIMIGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x42E47D0", Offset = "0x42E39D0", VA = "0x1842E47D0")]
		internal void DBCKLJBDNEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class PMKFLLIAJPE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PMKFLLIAJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4925D60", Offset = "0x4924F60", VA = "0x184925D60")]
		internal void PEHGFLFFNHL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GEJGFBDLBNE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x73203D0", Offset = "0x731F5D0", VA = "0x1873203D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EDLJPNPAFME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731FF30", Offset = "0x731F130", VA = "0x18731FF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DPGMKDCJAFC<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x608AE20", Offset = "0x608A020", VA = "0x18608AE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x608AF90", Offset = "0x608A190", VA = "0x18608AF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HCFEMFAAOMF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x44C01A0", Offset = "0x44BF3A0", VA = "0x1844C01A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x44C09F0", Offset = "0x44BFBF0", VA = "0x1844C09F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NKAKPGKNKJL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7327750", Offset = "0x7326950", VA = "0x187327750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7327950", Offset = "0x7326B50", VA = "0x187327950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CMPIMDBBDPP<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CMPIMDBBDPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x42E47D0", Offset = "0x42E39D0", VA = "0x1842E47D0")]
		internal void LFLFPNNEGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5886AE0", Offset = "0x5885CE0", VA = "0x185886AE0")]
		internal void KCLLILDJPLJ(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct IMMONJDMMCB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public NBHHNFMGLON<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4653CC0", Offset = "0x4652EC0", VA = "0x184653CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x46543D0", Offset = "0x46535D0", VA = "0x1846543D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct ODDDKCKFLOG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7327A40", Offset = "0x7326C40", VA = "0x187327A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7328240", Offset = "0x7327440", VA = "0x187328240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CDGMMNDKDKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731D7E0", Offset = "0x731C9E0", VA = "0x18731D7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x731DD30", Offset = "0x731CF30", VA = "0x18731DD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HOMCEAOJMPP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x44F3F20", Offset = "0x44F3120", VA = "0x1844F3F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x44F4710", Offset = "0x44F3910", VA = "0x1844F4710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class IEENJHDHPND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<HEGEDEFNLEJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IEENJHDHPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7323210", Offset = "0x7322410", VA = "0x187323210")]
		internal void OAIPDABBOPL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct DCADNGHDHJB<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6051590", Offset = "0x6050790", VA = "0x186051590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3C222D0", Offset = "0x3C214D0", VA = "0x183C222D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct OLCNBDDGNFP<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E38B90", Offset = "0x4E37D90", VA = "0x184E38B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4E392A0", Offset = "0x4E384A0", VA = "0x184E392A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct BLPKNMOFCII : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731D450", Offset = "0x731C650", VA = "0x18731D450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x731D630", Offset = "0x731C830", VA = "0x18731D630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CKDBMFOCDOJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731E690", Offset = "0x731D890", VA = "0x18731E690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x731EA00", Offset = "0x731DC00", VA = "0x18731EA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct IONMPIOMFHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7323440", Offset = "0x7322640", VA = "0x187323440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7323730", Offset = "0x7322930", VA = "0x187323730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DLBDDBBNAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DLBDDBBNAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x731F0C0", Offset = "0x731E2C0", VA = "0x18731F0C0")]
		internal Task LDAGFFAADJN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct EALKEJOOEMI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731FC70", Offset = "0x731EE70", VA = "0x18731FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x731FED0", Offset = "0x731F0D0", VA = "0x18731FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct DMKHIDOBBOP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731F200", Offset = "0x731E400", VA = "0x18731F200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x731F3E0", Offset = "0x731E5E0", VA = "0x18731F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct CMJDIJIHPAO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x731EA60", Offset = "0x731DC60", VA = "0x18731EA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x731EDD0", Offset = "0x731DFD0", VA = "0x18731EDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JIDODMPFHOL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7324B80", Offset = "0x7323D80", VA = "0x187324B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7324E70", Offset = "0x7324070", VA = "0x187324E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GIJJFGBKLMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public GIJJFGBKLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7320640", Offset = "0x731F840", VA = "0x187320640")]
		internal Task ADCCMEFKOMK(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct LFLBEKJGOGE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7326050", Offset = "0x7325250", VA = "0x187326050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x73262B0", Offset = "0x73254B0", VA = "0x1873262B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GCHKBKHEKHL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x73201F0", Offset = "0x731F3F0", VA = "0x1873201F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7320370", Offset = "0x731F570", VA = "0x187320370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct IGLPIHOJCGN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x46444B0", Offset = "0x46436B0", VA = "0x1846444B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4644710", Offset = "0x4643910", VA = "0x184644710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct HPGPJHLBJLC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7322E80", Offset = "0x7322080", VA = "0x187322E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x73231B0", Offset = "0x73223B0", VA = "0x1873231B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? AAONFCNNFFA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<HEGEDEFNLEJ> JOGDMIJDEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task CGHBCKEFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x73222F0", Offset = "0x73214F0", VA = "0x1873222F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7320FE0", Offset = "0x73201E0", VA = "0x187320FE0")]
	public static bool BJIFMKLFEMP(this Task JPPEAAIELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x32814B0", Offset = "0x32806B0", VA = "0x1832814B0")]
	public static Task<T> DMLEDKCDPKC<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7322450", Offset = "0x7321650", VA = "0x187322450")]
	public static Task MKGOKDONAKM(this Task JPPEAAIELKB, CancellationToken BCOHKLCJCPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3284930", Offset = "0x3283B30", VA = "0x183284930")]
	public static Task<TResult> MKGOKDONAKM<TResult>(this Task<TResult> JPPEAAIELKB, CancellationToken BCOHKLCJCPM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x32858A0", Offset = "0x3284AA0", VA = "0x1832858A0")]
	public static TaskCompletionSource<TResult> MKGOKDONAKM<TResult>(this TaskCompletionSource<TResult> CKCFPDNENEM, CancellationToken BCOHKLCJCPM) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7321870", Offset = "0x7320A70", VA = "0x187321870")]
	public static IDisposable? FEODBCIBNEP(CancellationToken DCGGMGHFODL, CancellationToken ILAJGJEEGIE, [Out] CancellationToken GNIMJCIBGHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7321B80", Offset = "0x7320D80", VA = "0x187321B80")]
	[AsyncStateMachine(typeof(GEJGFBDLBNE))]
	public static void GGFFHFKOFPA(this Task EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7321AD0", Offset = "0x7320CD0", VA = "0x187321AD0")]
	[AsyncStateMachine(typeof(EDLJPNPAFME))]
	public static void GGECPGCPLJO(this Task EBJDGDIMGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3281920", Offset = "0x3280B20", VA = "0x183281920")]
	[AsyncStateMachine(typeof(DPGMKDCJAFC<>))]
	public static Task HHLDHNCLDBP<TException>(this Task EBJDGDIMGBD) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3281630", Offset = "0x3280830", VA = "0x183281630")]
	[AsyncStateMachine(typeof(HCFEMFAAOMF<>))]
	public static Task<T> EHAEJMKNLOK<T>(this Task<T> MLNFAKCEGNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7321C80", Offset = "0x7320E80", VA = "0x187321C80")]
	[AsyncStateMachine(typeof(NKAKPGKNKJL))]
	public static Task<TaskStatus> HINOCCDKPGD(this Task MLNFAKCEGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3286230", Offset = "0x3285430", VA = "0x183286230")]
	public static (Task<T?>?, Action<T?>?) PJOHHALBOAJ<T>([Optional] CancellationToken BGEKICMONBE)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3281810", Offset = "0x3280A10", VA = "0x183281810")]
	[AsyncStateMachine(typeof(IMMONJDMMCB<, >))]
	public static Task<List<TResult>> HGOGKDBJKMO<TResult, TInput>(this Task<List<TInput>> JPPEAAIELKB, NBHHNFMGLON<TInput, TResult> CFEJFIJJKMF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x73207A0", Offset = "0x731F9A0", VA = "0x1873207A0")]
	[AsyncStateMachine(typeof(ODDDKCKFLOG))]
	public static Task ABEPAPDKDGD(Task EBJDGDIMGBD, CancellationToken LHPAGMJCDIN, Func<CancellationToken, Task> BOHBFEHMJEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7321D70", Offset = "0x7320F70", VA = "0x187321D70")]
	[AsyncStateMachine(typeof(CDGMMNDKDKP))]
	public static Task HMLPMLBBFOF(Func<CancellationToken, Task> IDGNMNKCFIL, TimeSpan HLAGGOKJDLK, [Optional] CancellationToken LHPAGMJCDIN, [Optional] Action<OperationCanceledException>? OAMCKPEBLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32819F0", Offset = "0x3280BF0", VA = "0x1832819F0")]
	[AsyncStateMachine(typeof(HOMCEAOJMPP<>))]
	public static Task<T> HMLPMLBBFOF<T>(Func<CancellationToken, Task<T>> IDGNMNKCFIL, TimeSpan HLAGGOKJDLK, [Optional] CancellationToken LHPAGMJCDIN, [Optional] Func<OperationCanceledException, T>? OAMCKPEBLDA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7320F90", Offset = "0x7320190", VA = "0x187320F90")]
	public static Task BIJFLHOEHHO(params Task[] EPGHDALPKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7320AD0", Offset = "0x731FCD0", VA = "0x187320AD0")]
	public static Task BIJFLHOEHHO(IEnumerable<Task> EPGHDALPKKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32813C0", Offset = "0x32805C0", VA = "0x1832813C0")]
	[AsyncStateMachine(typeof(DCADNGHDHJB<>))]
	public static Task<IEnumerable<Task<T>>> BICGOGDAFFB<T>(IEnumerable<Task<T>> EPGHDALPKKM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3281C90", Offset = "0x3280E90", VA = "0x183281C90")]
	[AsyncStateMachine(typeof(OLCNBDDGNFP<, , , >))]
	public static Task<(T1, T2, T3, T4)> KDIDBPCBFKA<T1, T2, T3, T4>(Task<T1> MKEIJDLBGHK, Task<T2> ONAGPNJJEHJ, Task<T3> JMAFAIAJLCA, Task<T4> EIMLEMAKOCK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7321F70", Offset = "0x7321170", VA = "0x187321F70")]
	[AsyncStateMachine(typeof(BLPKNMOFCII))]
	public static Task JOFKNBPMILL(Func<bool> PBMHCOIDBNB, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7322060", Offset = "0x7321260", VA = "0x187322060")]
	[AsyncStateMachine(typeof(CKDBMFOCDOJ))]
	public static Task JOFKNBPMILL(Func<bool> PBMHCOIDBNB, TimeSpan MDCDBCNPBFJ, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7321600", Offset = "0x7320800", VA = "0x187321600")]
	[AsyncStateMachine(typeof(IONMPIOMFHE))]
	public static Task FBKJKNIEJDN(Func<bool> PBMHCOIDBNB, TimeSpan HLAGGOKJDLK, [Optional] CancellationToken BGEKICMONBE, [Optional] Action<OperationCanceledException>? OAMCKPEBLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7321730", Offset = "0x7320930", VA = "0x187321730")]
	[AsyncStateMachine(typeof(EALKEJOOEMI))]
	public static Task FBKJKNIEJDN(Func<bool> PBMHCOIDBNB, TimeSpan HLAGGOKJDLK, TimeSpan MDCDBCNPBFJ, [Optional] CancellationToken BGEKICMONBE, [Optional] Action<OperationCanceledException>? OAMCKPEBLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x73208D0", Offset = "0x731FAD0", VA = "0x1873208D0")]
	[AsyncStateMachine(typeof(DMKHIDOBBOP))]
	public static Task AHFLPAACENI(Func<bool> PBMHCOIDBNB, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x73209C0", Offset = "0x731FBC0", VA = "0x1873209C0")]
	[AsyncStateMachine(typeof(CMJDIJIHPAO))]
	public static Task AHFLPAACENI(Func<bool> PBMHCOIDBNB, TimeSpan MDCDBCNPBFJ, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7321010", Offset = "0x7320210", VA = "0x187321010")]
	[AsyncStateMachine(typeof(JIDODMPFHOL))]
	public static Task BLLFHDKEADE(Func<bool> PBMHCOIDBNB, TimeSpan HLAGGOKJDLK, [Optional] CancellationToken BGEKICMONBE, [Optional] Action<OperationCanceledException>? OAMCKPEBLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7321140", Offset = "0x7320340", VA = "0x187321140")]
	[AsyncStateMachine(typeof(LFLBEKJGOGE))]
	public static Task BLLFHDKEADE(Func<bool> PBMHCOIDBNB, TimeSpan HLAGGOKJDLK, TimeSpan MDCDBCNPBFJ, [Optional] CancellationToken BGEKICMONBE, [Optional] Action<OperationCanceledException>? OAMCKPEBLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7322360", Offset = "0x7321560", VA = "0x187322360")]
	[AsyncStateMachine(typeof(GCHKBKHEKHL))]
	[Obsolete]
	public static Task MKGODAGKFCK(this Task JPPEAAIELKB, Action LOJACKMNENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3281F50", Offset = "0x3281150", VA = "0x183281F50")]
	[AsyncStateMachine(typeof(IGLPIHOJCGN<>))]
	[Obsolete]
	public static Task MKGODAGKFCK<T>(this Task<T> JPPEAAIELKB, Action<T> LOJACKMNENI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7322170", Offset = "0x7321370", VA = "0x187322170")]
	private static void LGKIIAEPEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7321280", Offset = "0x7320480", VA = "0x187321280")]
	public static bool CDEJCCHEEBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x73227D0", Offset = "0x73219D0", VA = "0x1873227D0")]
	private static void PNEJNPENAPC(SynchronizationContext OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x73226B0", Offset = "0x73218B0", VA = "0x1873226B0")]
	private static void NECGOCOPOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7322220", Offset = "0x7321420", VA = "0x187322220")]
	public static void LHHBKKGEDCK([Optional] string? CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7321EA0", Offset = "0x73210A0", VA = "0x187321EA0")]
	public static void HPLCMNNDBIE([Optional] string? CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7321F20", Offset = "0x7321120", VA = "0x187321F20")]
	public static GJGCAJKCHDE ILBFDPLLGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7321C30", Offset = "0x7320E30", VA = "0x187321C30")]
	public static GJGCAJKCHDE HALALFMLDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7321A00", Offset = "0x7320C00", VA = "0x187321A00")]
	[AsyncStateMachine(typeof(HPGPJHLBJLC))]
	public static Task FMNJAMINAMH(Func<Task> LGBMMKDPNBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KHFOLODBECL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public KHFOLODBECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DBFHGAJFKLD : PMNBGLKENHP
{
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public static readonly PMNBGLKENHP CLACNPDFIIL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime EJKNADEALBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x731EE30", Offset = "0x731E030", VA = "0x18731EE30", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset JAPFNHFEEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x731EE70", Offset = "0x731E070", VA = "0x18731EE70", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public DBFHGAJFKLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface PMNBGLKENHP
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime EJKNADEALBK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset JAPFNHFEEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EAHLKEGFHLI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long KBCPPDEHFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x731F600", Offset = "0x731E800", VA = "0x18731F600")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long DEBLODLBBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x731F820", Offset = "0x731EA20", VA = "0x18731F820")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double AKPECIDOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x731F490", Offset = "0x731E690", VA = "0x18731F490")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double LKHOKOEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x731F5B0", Offset = "0x731E7B0", VA = "0x18731F5B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double PCENGEEKFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x731F440", Offset = "0x731E640", VA = "0x18731F440")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double DLJAKPKMMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x731F650", Offset = "0x731E850", VA = "0x18731F650")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x731F910", Offset = "0x731EB10", VA = "0x18731F910")]
	public static double PKOELGLKPJA(long BCDALGEDKKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x731F790", Offset = "0x731E990", VA = "0x18731F790")]
	public static double MMPDEJGIJNE(long BCDALGEDKKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x731F700", Offset = "0x731E900", VA = "0x18731F700")]
	public static double LIJNMHOIKAB(double ABAAKCPKPOL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x731F880", Offset = "0x731EA80", VA = "0x18731F880")]
	public static long PIOJFDGKIGN(long KIPBHBAMJHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x731F870", Offset = "0x731EA70", VA = "0x18731F870")]
	public static long NGBDEENECHF(long BHMMOONKGIO, long LEHFCNNMFAF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x731F4E0", Offset = "0x731E6E0", VA = "0x18731F4E0")]
	public static double ENIELJFIMPF(long BHMMOONKGIO, long LEHFCNNMFAF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x731F6A0", Offset = "0x731E8A0", VA = "0x18731F6A0")]
	public static double IHAHDALCDOF(long BHMMOONKGIO, long LEHFCNNMFAF)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class CICAEBHIHME : HKANKPBEDCO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly TimeSpan MALKMNNNLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly System.Timers.Timer FBHOIGDCPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private TimeSpan HLAGGOKJDLK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan MMBJIABPAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x731E0D0", Offset = "0x731D2D0", VA = "0x18731E0D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? ABMPLFCCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x731E3D0", Offset = "0x731D5D0", VA = "0x18731E3D0")]
	[Preserve]
	public CICAEBHIHME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x731E440", Offset = "0x731D640", VA = "0x18731E440")]
	public CICAEBHIHME(TimeSpan HLAGGOKJDLK, [Optional] Action? JNNIPJJBMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x731E230", Offset = "0x731D430", VA = "0x18731E230", Slot = "7")]
	public void HFJDLLOGLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x731E2C0", Offset = "0x731D4C0", VA = "0x18731E2C0", Slot = "8")]
	public void IPCBDCLKAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x731E330", Offset = "0x731D530", VA = "0x18731E330", Slot = "9")]
	public void MKBPOJHGOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xF43330", Offset = "0xF42530", VA = "0x180F43330")]
	private void JDDGCNEENJF(object PIEFIBOFCOC, ElapsedEventArgs COFAPIIPKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x731E030", Offset = "0x731D230", VA = "0x18731E030")]
	private static void GIMKBMIFNDG(TimeSpan BDDGIIJNNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x731DF90", Offset = "0x731D190", VA = "0x18731DF90", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CKOGIBPDLCN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly string? LNAJEBMMAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string KFOBCGDCHKK;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D34A10", Offset = "0x6D33C10", VA = "0x186D34A10")]
	public CKOGIBPDLCN(string MEAHMKBIOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4651700", Offset = "0x4650900", VA = "0x184651700")]
	public CKOGIBPDLCN(string ODABBBAHLHK, string MEAHMKBIOJN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct NIJFDNGGKMN : IEquatable<NIJFDNGGKMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint NHFAACGIHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int FKPNJCDONHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float EGIKICKHDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort CEFAGIAIFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort KLGOPNIALGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public short GFPOIBPGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short PBFALJPCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public char CMKBMKCNGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char EEDAJDMJOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte CDFMPECILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte ILDLNGHFACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte NOOGEPHMHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte ONNHLIDHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public bool DEFFAFEEAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool IJGDLJMIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool OLCOENEDOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool HDDKGIFJLKD;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4DA0", Offset = "0x1BC3FA0", VA = "0x181BC4DA0")]
	public static NIJFDNGGKMN MAGJHCOMLOI(uint OBJAALCEMIH)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4DA0", Offset = "0x1BC3FA0", VA = "0x181BC4DA0")]
	public static NIJFDNGGKMN JHKNOPHPHBB(int DANDJCDKNPI)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7326950", Offset = "0x7325B50", VA = "0x187326950")]
	public static NIJFDNGGKMN PNLDKDMCMNK(float CEFJIFCDDLI)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x73268B0", Offset = "0x7325AB0", VA = "0x1873268B0")]
	public static NIJFDNGGKMN CGGICOAJCGD(byte BGALEBGBMPC, byte NLENBACKMAN, byte FMDFEPNAMJH, byte FCILOGFNFCB)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x73268B0", Offset = "0x7325AB0", VA = "0x1873268B0")]
	public static NIJFDNGGKMN FEACDPFMCLB(bool KMIAHDCCCFB, bool CKGNPJOHPBI, bool ODMMPMJGLEO, bool IHNKNGJCJDA)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x73268B0", Offset = "0x7325AB0", VA = "0x1873268B0")]
	public static NIJFDNGGKMN LODIFHIPAEI(byte CCGBEBNHJDD, byte NMGEEENFGJB, byte JICIBBDBGJB, byte HKHIEMKKHJJ)
	{
		return default(NIJFDNGGKMN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF370", Offset = "0x1EAE570", VA = "0x181EAF370")]
	public static bool CCHBIHOFELC(NIJFDNGGKMN FBCBJPMNPEK, NIJFDNGGKMN HHDMEFHBCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1EAF350", Offset = "0x1EAE550", VA = "0x181EAF350", Slot = "4")]
	public bool Equals(NIJFDNGGKMN JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x73268D0", Offset = "0x7325AD0", VA = "0x1873268D0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x10E8D90", Offset = "0x10E7F90", VA = "0x1810E8D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7326960", Offset = "0x7325B60", VA = "0x187326960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct MOMDDGMOGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public ulong IKEFIOAEDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public long PABGEFINKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public double HFGAPEOPDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public uint IBALBGCOAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint OGMBHDKANNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public int KFGOOMKDCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int PBEEOBCEAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public float AMHGOJCKAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float IBHENGMOALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort CEFAGIAIFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort KLGOPNIALGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort KCHAKCOPIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort JJDOIFLHFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public short GFPOIBPGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short PBFALJPCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short NAHFBIDDGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short AFFCBIFGBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public char CMKBMKCNGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char EEDAJDMJOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char BEPABLOIAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char MLHEFFNADBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public byte CDFMPECILFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte ILDLNGHFACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte NOOGEPHMHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte ONNHLIDHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte LFKIALGFJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte ELFAEAIJEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte ELJHMDGHNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte IGMOIFFHDNJ;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static MOMDDGMOGGD PAJOIGLPBMN(long AINAPAPICIL)
	{
		return default(MOMDDGMOGGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7326860", Offset = "0x7325A60", VA = "0x187326860")]
	public static MOMDDGMOGGD PAJOIGLPBMN(byte BGALEBGBMPC, byte NLENBACKMAN, byte FMDFEPNAMJH, byte FCILOGFNFCB, byte EFECIEJFEGP, byte DCABHLDBMLL, byte MIOBAHEKLDL, byte FIMDMIPLGAM)
	{
		return default(MOMDDGMOGGD);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct LOPNDBHPBKA : IEquatable<LOPNDBHPBKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte FINHLIJKCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool EAGFPCHFHKA;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2B47720", Offset = "0x2B46920", VA = "0x182B47720")]
	public static LOPNDBHPBKA CGGICOAJCGD(byte LOCKLNMDOAA)
	{
		return default(LOPNDBHPBKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2B47720", Offset = "0x2B46920", VA = "0x182B47720")]
	public static LOPNDBHPBKA FEACDPFMCLB(bool MHGNIJHKPNB)
	{
		return default(LOPNDBHPBKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7326310", Offset = "0x7325510", VA = "0x187326310")]
	public static bool CCHBIHOFELC(LOPNDBHPBKA FBCBJPMNPEK, LOPNDBHPBKA HHDMEFHBCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x63EDD40", Offset = "0x63ECF40", VA = "0x1863EDD40", Slot = "4")]
	public bool Equals(LOPNDBHPBKA JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7326320", Offset = "0x7325520", VA = "0x187326320", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x73263B0", Offset = "0x73255B0", VA = "0x1873263B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x73263C0", Offset = "0x73255C0", VA = "0x1873263C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NBNADAHAHHP<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly T IIFEDOFLGEP;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4C68DF0", Offset = "0x4C67FF0", VA = "0x184C68DF0")]
	public NBNADAHAHHP(T HNMJDMIGFHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PEGJDCCOLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3114260", Offset = "0x3113460", VA = "0x183114260")]
	public static IEnumerable<T> BOMBNEOKBGE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static T[] FGAGCGAKFGN<T>(params T[] GGCKCCHNNCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static IEnumerable<T> MOBOIPCAKDI<T>(params T[] GGCKCCHNNCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static HashSet<T> PEMMDHELIFC<T>(params T[] GGCKCCHNNCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x34677D0", Offset = "0x34669D0", VA = "0x1834677D0")]
	public static KeyValuePair<TKey, TValue> GDHLIMDKIEI<TKey, TValue>([In] TKey OFPBICPHALF, [In] TValue OMEFCJCOLII) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x304E4D0", Offset = "0x304D6D0", VA = "0x18304E4D0")]
	public static List<T> KAOEEGAANKF<T>(IEnumerable<T> GIJCPEPCKMK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JEPHFDPHFND : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly string OHLKPJOGGHO;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
	public JEPHFDPHFND(string CMNHJIAJJEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object KDPCIDAFCFF<T>([In] T OKBEKNPNPIM);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object LNBKGOCCHGJ<T>(T OKBEKNPNPIM);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[GFJAEGEBONN]
public delegate string PNOHJEHALCK(string JJOHJKDMMOB, string? DHKGEFAKBIG, bool DDKHPNFANIG);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GFJAEGEBONN]
public delegate void DLLJAOJGHHF(string CBCJFCINKPJ);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[GFJAEGEBONN]
public delegate void DIAKDABKIIJ(Exception ANJHEGDKNFP);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object JBIPFCJFOAK();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GFJAEGEBONN]
public delegate bool IGHMEHNJCED();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GFJAEGEBONN]
public delegate string OMGNILIIFIH(object LCACGJDNDHA);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class LNCPPFJLIHG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
	public LNCPPFJLIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class BCNGEGMFFPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct PHLDFAJKAIG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7328560", Offset = "0x7327760", VA = "0x187328560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7328E50", Offset = "0x7328050", VA = "0x187328E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly TimerCallback MNGPAJLBHNN;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly Action<object?> MPAEPBLBELH;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x731CD80", Offset = "0x731BF80", VA = "0x18731CD80")]
	public static Task<bool> DCJAFODHGOP(int FDHKOGLNHIP, [Optional] CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x731D090", Offset = "0x731C290", VA = "0x18731D090")]
	[AsyncStateMachine(typeof(PHLDFAJKAIG))]
	private static Task<bool> DHOADMBFLPI(int FDHKOGLNHIP, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x731D1C0", Offset = "0x731C3C0", VA = "0x18731D1C0")]
	private static void KEECBPBNGGF(object? ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x731D250", Offset = "0x731C450", VA = "0x18731D250")]
	private static void OIHPBDACKBG(object? ONNLPKDFGPA)
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
