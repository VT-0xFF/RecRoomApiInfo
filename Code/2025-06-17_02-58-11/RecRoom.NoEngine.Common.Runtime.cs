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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAD140", Offset = "0x7EABB40", VA = "0x187EAD140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DNCIDPAGLAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EA51F0", Offset = "0x7EA3BF0", VA = "0x187EA51F0")]
	public static string EBACJPNJKAA(this Encoding KNAIPPIADDC, [In] ReadOnlySequence<byte> OKLLDHNGOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38D62C0", Offset = "0x38D4CC0", VA = "0x1838D62C0")]
	private static void PGIELPNALNB<T>(this ReadOnlySequence<T> KFNMNKPGOMI, [Out] ReadOnlySpan<T> IKCOJNPGIDN, [Out] SequencePosition OECIMOKICEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class OHBFGBMBLKA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD5D0", Offset = "0x7EABFD0", VA = "0x187EAD5D0")]
	public OHBFGBMBLKA(bool JOFLALEPHMA, string LBDDDGJBAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD580", Offset = "0x7EABF80", VA = "0x187EAD580")]
	public OHBFGBMBLKA(bool JOFLALEPHMA, params string[] PCNPDBGLIND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FJBIGCDLCJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FPJGLLCCFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CHDKMONBLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJDIHMPBJKD(string KJNEHANBOBO, double PCDAHJCDHHF, [Optional] string? HEPDLFLFIHM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EOCHJOHDAGO : PHLKFPFLNIG, OINNELMACJI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int OMFFCBJIFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> PDBACDBFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double FABCOJIGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double EOFJEGBKIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double ODABPGCPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int DGLIOBDJPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double OPBCEFEFAOL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ILPOOCKGFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double CDOCAFBHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5F40", Offset = "0x7EA4940", VA = "0x187EA5F40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LHAGANCBAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x529D020", Offset = "0x529BA20", VA = "0x18529D020", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double JJCBMFJFJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x285F6B0", Offset = "0x285E0B0", VA = "0x18285F6B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA61D0", Offset = "0x7EA4BD0", VA = "0x187EA61D0")]
	public EOCHJOHDAGO(int CMFECLJBPAJ, double OPBCEFEFAOL = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EA60A0", Offset = "0x7EA4AA0", VA = "0x187EA60A0", Slot = "7")]
	public void GNFBOMOBCLP(double KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5ED0", Offset = "0x7EA48D0", VA = "0x187EA5ED0", Slot = "8")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5FA0", Offset = "0x7EA49A0", VA = "0x187EA5FA0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LCJAIFLDHLG : PHLKFPFLNIG, OINNELMACJI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long IMCIONKBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double AKDCGDIKCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double DGNECGADKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double OJANGFGHFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double DNGKIJEHGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double FABCOJIGKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double EOFJEGBKIJO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LHAGANCBAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x70E8E90", Offset = "0x70E7890", VA = "0x1870E8E90", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JJCBMFJFJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70E8A00", Offset = "0x70E7400", VA = "0x1870E8A00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double AHELFLNBIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70E8E50", Offset = "0x70E7850", VA = "0x1870E8E50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CDOCAFBHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8930", Offset = "0x2FA7330", VA = "0x182FA8930", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8C50", Offset = "0x7EA7650", VA = "0x187EA8C50", Slot = "10")]
	public virtual void GNFBOMOBCLP(double KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8BA0", Offset = "0x7EA75A0", VA = "0x187EA8BA0", Slot = "11")]
	public virtual void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8BE0", Offset = "0x7EA75E0", VA = "0x187EA8BE0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8D70", Offset = "0x7EA7770", VA = "0x187EA8D70")]
	public LCJAIFLDHLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LIOFGPJGMCK : LCJAIFLDHLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double EANKAKBAPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70E8A10", Offset = "0x70E7410", VA = "0x1870E8A10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70E89F0", Offset = "0x70E73F0", VA = "0x1870E89F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA130", Offset = "0x7EA8B30", VA = "0x187EAA130", Slot = "10")]
	public override void GNFBOMOBCLP(double KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA0F0", Offset = "0x7EA8AF0", VA = "0x187EAA0F0", Slot = "11")]
	public override void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8D70", Offset = "0x7EA7770", VA = "0x187EA8D70")]
	public LIOFGPJGMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHLKFPFLNIG : OINNELMACJI, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double CDOCAFBHIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LHAGANCBAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double JJCBMFJFJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EBGIHJJKDKJ : OINNELMACJI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double EBBDFFDGIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double NPJDPOKGHDC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5950", Offset = "0x7EA4350", VA = "0x187EA5950")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B3A5B0", Offset = "0x6B38FB0", VA = "0x186B3A5B0", Slot = "4")]
	public void GNFBOMOBCLP(double KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EA58F0", Offset = "0x7EA42F0", VA = "0x187EA58F0", Slot = "5")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5900", Offset = "0x7EA4300", VA = "0x187EA5900", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public EBGIHJJKDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OINNELMACJI : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNFBOMOBCLP(double KPILPFEAJHA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALHGHPCNMCL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OPLJPCDBKGF : OINNELMACJI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double PCDAHJCDHHF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4763500", Offset = "0x4761F00", VA = "0x184763500")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54DEA90", Offset = "0x54DD490", VA = "0x1854DEA90", Slot = "4")]
	public void GNFBOMOBCLP(double KPILPFEAJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7EADBC0", Offset = "0x7EAC5C0", VA = "0x187EADBC0", Slot = "5")]
	public void ALHGHPCNMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EADBD0", Offset = "0x7EAC5D0", VA = "0x187EADBD0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OPLJPCDBKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MHHNLKHGHNB<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> OOPAAOMMCGJ(CancellationToken JKPNCAGHEDI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NCGGKMMHDHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MHHNLKHGHNB<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OOPAAOMMCGJ taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x54FBC50", Offset = "0x54FA650", VA = "0x1854FBC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x54FCC20", Offset = "0x54FB620", VA = "0x1854FCC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource IFHBDAKCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? KOEJJMLHHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? OHBMENGGDMH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x547F470", Offset = "0x547DE70", VA = "0x18547F470")]
	[AsyncStateMachine(typeof(MHHNLKHGHNB<>.NCGGKMMHDHP))]
	public Task<TResult> KDHGOJBIFJL(OOPAAOMMCGJ IHDKBJMENGK, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x547F400", Offset = "0x547DE00", VA = "0x18547F400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x547F5A0", Offset = "0x547DFA0", VA = "0x18547F5A0")]
	public MHHNLKHGHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FCFNJOBEIEC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> GGJJBBPPELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T AMCECKEAKLL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4B332F0", Offset = "0x4B31CF0", VA = "0x184B332F0")]
	public FCFNJOBEIEC([In] T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B326F0", Offset = "0x4B310F0", VA = "0x184B326F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B32A10", Offset = "0x4B31410", VA = "0x184B32A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B32BE0", Offset = "0x4B315E0", VA = "0x184B32BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class FDIKCNHIHBM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static FCFNJOBEIEC<T> FMDOFBCLPJB<T>([In] T PCDAHJCDHHF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CDIHJFINGBE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3F10", Offset = "0x7EA2910", VA = "0x187EA3F10")]
	public static void OPJAIEBAEIG(this CancellationTokenSource IFHBDAKCHCL, bool JLOAHOONBFA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class BFODFIPKJBK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public BFODFIPKJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FOCICBLMCCE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public FOCICBLMCCE(string DMHJJHFJNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FFNMHFIAADE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A48D10", Offset = "0x3A47710", VA = "0x183A48D10")]
	public static IAOCAOHODDC BCKDOOOCIAJ<T>()
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EA62A0", Offset = "0x7EA4CA0", VA = "0x187EA62A0")]
	public static IAOCAOHODDC AFNPHHMMCOD([CallerMemberName] string GBCFHNGPBLM = "")
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A48EC0", Offset = "0x3A478C0", VA = "0x183A48EC0")]
	public static IAOCAOHODDC GNAECLAFCEL<T>([CallerMemberName] string GBCFHNGPBLM = "") where T : notnull
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A48C90", Offset = "0x3A47690", VA = "0x183A48C90")]
	public static IAOCAOHODDC BCKDOOOCIAJ<T>(this T FHFGMILAALL) where T : notnull
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A48B40", Offset = "0x3A47540", VA = "0x183A48B40")]
	public static IAOCAOHODDC AFNPHHMMCOD<T>(this T FHFGMILAALL, [CallerMemberName] string GBCFHNGPBLM = "") where T : notnull
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A48F50", Offset = "0x3A47950", VA = "0x183A48F50")]
	public static IAOCAOHODDC GNAECLAFCEL<T>(this T NMEFAPBBOCD, [CallerMemberName] string GBCFHNGPBLM = "") where T : notnull
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EA63A0", Offset = "0x7EA4DA0", VA = "0x187EA63A0")]
	public static IAOCAOHODDC GNAECLAFCEL(string GMPCHJNJMEE, [CallerMemberName] string GBCFHNGPBLM = "")
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6300", Offset = "0x7EA4D00", VA = "0x187EA6300")]
	public static string FFPDBGGKCKD(this object NMEFAPBBOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool OMFFOALFDLJ();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BFODFIPKJBK]
public delegate long ILNAKJICIKH();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class GMHCDPAFDKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly GMHCDPAFDKD FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GMHCDPAFDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LHEOLGJLPDN
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static LEBDJEGHDEI CJGGEDONJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static LEBDJEGHDEI BNLKCKFHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9F80", Offset = "0x7EA8980", VA = "0x187EA9F80")]
		get
		{
			return default(LEBDJEGHDEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static APAOLKMJPMG EMBCJCBDPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D90", Offset = "0x7EA8790", VA = "0x187EA9D90")]
		get
		{
			return default(APAOLKMJPMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static ACLFKCACOOJ EDDFMHGANOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9C10", Offset = "0x7EA8610", VA = "0x187EA9C10")]
		get
		{
			return default(ACLFKCACOOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool ILEMCHLBAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9AC0", Offset = "0x7EA84C0", VA = "0x187EA9AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7EA97E0", Offset = "0x7EA81E0", VA = "0x187EA97E0")]
	public static void AIJGLNHNNPD([In] LEBDJEGHDEI LAMLAHGIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9DE0", Offset = "0x7EA87E0", VA = "0x187EA9DE0")]
	public static void NLLEOCMFOCP(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9CC0", Offset = "0x7EA86C0", VA = "0x187EA9CC0")]
	public static void JKOFKEGKJJH(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B1FB30", Offset = "0x3B1E530", VA = "0x183B1FB30")]
	public static void JKOFKEGKJJH<T>(T EFPDHJCEEGP, BFAONNCALDI<T> IJOJGNJMCGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9980", Offset = "0x7EA8380", VA = "0x187EA9980")]
	public static void AKHBKGDGOFI(Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9FD0", Offset = "0x7EA89D0", VA = "0x187EA9FD0")]
	public static void PFGBOBHJPGE(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9C60", Offset = "0x7EA8660", VA = "0x187EA9C60")]
	public static void IHKABHLFAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9B30", Offset = "0x7EA8530", VA = "0x187EA9B30")]
	public static string FFPDBGGKCKD(object OJDHMKOBKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9BA0", Offset = "0x7EA85A0", VA = "0x187EA9BA0")]
	public static long GDIDBEKMHCB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9A20", Offset = "0x7EA8420", VA = "0x187EA9A20")]
	public static bool CLPLNFEMHHA(bool APOGDCILJPL, string IJOJGNJMCGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9EB0", Offset = "0x7EA88B0", VA = "0x187EA9EB0")]
	public static double OFCEFJMOPMN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct LEBDJEGHDEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly APAOLKMJPMG EMBCJCBDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ACLFKCACOOJ EDDFMHGANOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly JIKAJJBCEAF IJHBNBMDMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly ILNAKJICIKH HJGOGFPBPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly BAIKJMGGBBI OFFKFKDPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly OMFFOALFDLJ GLENIELBFOL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly JIKAJJBCEAF DAAADGFMDIM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly ILNAKJICIKH KLKNBFLCLKH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BAIKJMGGBBI FBLBCPGFGMN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly OMFFOALFDLJ ODNJMLEDMKB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly LEBDJEGHDEI BOAAIAHJNJN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8EE0", Offset = "0x7EA78E0", VA = "0x187EA8EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EA9730", Offset = "0x7EA8130", VA = "0x187EA9730")]
	public LEBDJEGHDEI([In] APAOLKMJPMG CALJFLENJJD, [In] ACLFKCACOOJ FLJMEHGJDMK, JIKAJJBCEAF BLONJMJJGKN, ILNAKJICIKH EDOFJPHMPOK, BAIKJMGGBBI NAKJIKKNCLI, OMFFOALFDLJ FMPDJLJMJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8EA0", Offset = "0x7EA78A0", VA = "0x187EA8EA0")]
	private static string IENCJAPDGJJ(object OJDHMKOBKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	private static long DDCLINLJPJL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	private static string HLIMGKJKFFF(string JDGADODOANI, string? IOFCDGOOFLO, bool NIOCGEFMEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	private static bool FHHAPHJNHDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8DA0", Offset = "0x7EA77A0", VA = "0x187EA8DA0")]
	private static LEBDJEGHDEI GLGFBGGBLDM()
	{
		return default(LEBDJEGHDEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KBNMJEOCCCO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MEJLHACDHMF KGCPCIIMFBP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MEJLHACDHMF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CMMJBHMPAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMNIGMOFGEK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FFDBOPCMCDN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MMLILOGHCPE([In] T NDNHELJMDCG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void ADAEACDIEIF<T>([In] T EFPDHJCEEGP);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct BBBOGPEJDNL<T> : IEquatable<BBBOGPEJDNL<T>>, FFDBOPCMCDN<BBBOGPEJDNL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T AMCECKEAKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int FOIACCDFCND;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2600", Offset = "0x5FA1000", VA = "0x185FA2600")]
	public BBBOGPEJDNL([In] T PCDAHJCDHHF, int MNFHMLCLFEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2240", Offset = "0x5FA0C40", VA = "0x185FA2240")]
	public static bool IDFALDDOLDN([In] BBBOGPEJDNL<T> OCPABDEGAMF, [In] BBBOGPEJDNL<T> MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4D0A780", Offset = "0x4D09180", VA = "0x184D0A780", Slot = "4")]
	public bool Equals(BBBOGPEJDNL<T> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DCE0", Offset = "0x4B4C6E0", VA = "0x184B4DCE0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2340", Offset = "0x5FA0D40", VA = "0x185FA2340")]
	public bool MMLILOGHCPE([In] BBBOGPEJDNL<T> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2080", Offset = "0x5FA0A80", VA = "0x185FA2080", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2540", Offset = "0x5FA0F40", VA = "0x185FA2540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1E30", Offset = "0x5FA0830", VA = "0x185FA1E30")]
	public void AJIECABKDHF([Out] T PCDAHJCDHHF, [Out] int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1ED0", Offset = "0x5FA08D0", VA = "0x185FA1ED0")]
	public (T, int) BMEAMFJJIEJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FA22F0", Offset = "0x5FA0CF0", VA = "0x185FA22F0", Slot = "5")]
	private bool JJANKMHMOPM([In] BBBOGPEJDNL<T> NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CAIFPCCDEFF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x384D150", Offset = "0x384BB50", VA = "0x18384D150")]
	public static BBBOGPEJDNL<T> FMDOFBCLPJB<T>([In] T PCDAHJCDHHF, int MNFHMLCLFEB) where T : notnull
	{
		return default(BBBOGPEJDNL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KHGIELAMGAD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B088B0", Offset = "0x3B072B0", VA = "0x183B088B0")]
	public static bool MMLILOGHCPE<T, U>([In] T NMEFAPBBOCD, [In] U OJDHMKOBKLD) where T : notnull, FFDBOPCMCDN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult IIKLLKAFEPM<T, out TResult>([In] T EFPDHJCEEGP);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LJHAHDLAIDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan MNFBJAEACJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? BKFMAJFMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAPJNMIFIFA();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIOAFMFNAHA();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPBACMFGIMM();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct APAOLKMJPMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly NNMDIAINNOA KDLCIJFBDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LHDAFKCNEBF GNKAADEFEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly NNMDIAINNOA ILMMNKOHLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LHDAFKCNEBF GOOFLMHJHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly NNMDIAINNOA PMMOANKPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly LHDAFKCNEBF DLKADLIHBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly NJKBCLEGLLN KMAMCPODDDF;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly NNMDIAINNOA DBMLFOCOKDN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LHDAFKCNEBF BHJIJFGAFKO;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly NNMDIAINNOA AMOLFHFGHNE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LHDAFKCNEBF LJAIDFCJOBM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly NNMDIAINNOA BAHGDMECLGD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly LHDAFKCNEBF IINBPCDKDGK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly NJKBCLEGLLN HDDLLCBDOHO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly APAOLKMJPMG BOAAIAHJNJN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly NNMDIAINNOA JLEDNAMFIJL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2660", Offset = "0x7EA1060", VA = "0x187EA2660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE07410", Offset = "0xE05E10", VA = "0x180E07410")]
	public APAOLKMJPMG(NNMDIAINNOA IJPJBHDMJFE, LHDAFKCNEBF LECNGDCMAPH, NNMDIAINNOA PDKHJBKNEBD, LHDAFKCNEBF OPJEBAKAKGI, NNMDIAINNOA NECIFFLGKIP, LHDAFKCNEBF IOKGBGANNMC, NJKBCLEGLLN EPGGKPMICCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	private static bool MKPCNACMBHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void MDBMFHKIKLM(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	private static bool NLEKLPDAKEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void ANNNLNMCDHO(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	private static bool LDJKKHHDANK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void KFJLAAILIHJ(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void LFOMICLNNLL(Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA23D0", Offset = "0x7EA0DD0", VA = "0x187EA23D0")]
	private static APAOLKMJPMG GLGFBGGBLDM()
	{
		return default(APAOLKMJPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
	private static bool JKLHGBLFKCP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2840", Offset = "0x7EA1240", VA = "0x187EA2840")]
	public void NLLEOCMFOCP(object IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7EA28B0", Offset = "0x7EA12B0", VA = "0x187EA28B0")]
	public void OICLDCNEHIK(object IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2510", Offset = "0x7EA0F10", VA = "0x187EA2510")]
	public void JKOFKEGKJJH(object IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE03590", Offset = "0xE01F90", VA = "0x180E03590")]
	public void AKHBKGDGOFI(Exception AGKNBEAOFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2580", Offset = "0x7EA0F80", VA = "0x187EA2580")]
	public void JKOFKEGKJJH(EKAGHBMGAGO IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x300B800", Offset = "0x300A200", VA = "0x18300B800")]
	public void JKOFKEGKJJH<T>(T EFPDHJCEEGP, BFAONNCALDI<T> IJOJGNJMCGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x300BB10", Offset = "0x300A510", VA = "0x18300BB10")]
	public void NLLEOCMFOCP<T>([In] T EFPDHJCEEGP, PMHGMHJMGNL<T> IJOJGNJMCGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x300B8D0", Offset = "0x300A2D0", VA = "0x18300B8D0")]
	public void JKOFKEGKJJH<T>([In] T EFPDHJCEEGP, PMHGMHJMGNL<T> IJOJGNJMCGP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2300", Offset = "0x7EA0D00", VA = "0x187EA2300")]
	public bool CLPLNFEMHHA(bool APOGDCILJPL, string IJOJGNJMCGP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct IAOCAOHODDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string AMCECKEAKLL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	public IAOCAOHODDC(string PCDAHJCDHHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60")]
	public static string HNONLACFBHP([In] IAOCAOHODDC NMEFAPBBOCD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x12F3150", Offset = "0x12F1B50", VA = "0x1812F3150")]
	public static IAOCAOHODDC HNONLACFBHP(string NDNHELJMDCG)
	{
		return default(IAOCAOHODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6E90", Offset = "0x7EA5890", VA = "0x187EA6E90")]
	public string OPNHLJPIJOL(string NDFNAFDNBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6DB0", Offset = "0x7EA57B0", VA = "0x187EA6DB0")]
	public string ECECGAMCFLD(object APBNLPNFAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class OJCMDMODADC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public OJCMDMODADC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct NOHGHNIBNOG : IEquatable<NOHGHNIBNOG>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "4")]
	public bool Equals(NOHGHNIBNOG NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD0B0", Offset = "0x7EABAB0", VA = "0x187EAD0B0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD100", Offset = "0x7EABB00", VA = "0x187EAD100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD110", Offset = "0x7EABB10", VA = "0x187EAD110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[PNLDDMBLJGN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct ADEFLNKAAIF<T> : IEquatable<ADEFLNKAAIF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T AMCECKEAKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool EHBLLDADLDD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool IIMPJLOKCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4CA6560", Offset = "0x4CA4F60", VA = "0x184CA6560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4CA6E50", Offset = "0x4CA5850", VA = "0x184CA6E50")]
	public ADEFLNKAAIF([In] T PCDAHJCDHHF, bool NFNPCLEFPFG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4CA5F90", Offset = "0x4CA4990", VA = "0x184CA5F90")]
	public static bool IDFALDDOLDN([In] ADEFLNKAAIF<T> OCPABDEGAMF, [In] ADEFLNKAAIF<T> MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4E90", Offset = "0x4CA3890", VA = "0x184CA4E90", Slot = "4")]
	public bool Equals(ADEFLNKAAIF<T> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4CA4F10", Offset = "0x4CA3910", VA = "0x184CA4F10", Slot = "0")]
	public override bool Equals(object? NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4CA5960", Offset = "0x4CA4360", VA = "0x184CA5960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4CA6AE0", Offset = "0x4CA54E0", VA = "0x184CA6AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class IIKIHNBCANG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA42D0", Offset = "0x3AA2CD0", VA = "0x183AA42D0")]
	public static ADEFLNKAAIF<T> HIIDMHKPBAM<T>([In] T PCDAHJCDHHF) where T : notnull
	{
		return default(ADEFLNKAAIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA44F0", Offset = "0x3AA2EF0", VA = "0x183AA44F0")]
	public static ADEFLNKAAIF<T?> HPIJHNBFNJO<T>()
	{
		return default(ADEFLNKAAIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4710", Offset = "0x3AA3110", VA = "0x183AA4710")]
	public static bool JMOCFMLCEKK<T>([In] this ADEFLNKAAIF<T> OHEEGJCEELI, [Out][NotNullWhen(true)] T PCDAHJCDHHF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA46A0", Offset = "0x3AA30A0", VA = "0x183AA46A0")]
	public static bool JMOCFMLCEKK<T>([In] this ADEFLNKAAIF<T> OHEEGJCEELI, [Out][NotNullWhen(true)] T PCDAHJCDHHF, [Out] ADEFLNKAAIF<T> OCDOMHCMAKG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4150", Offset = "0x3AA2B50", VA = "0x183AA4150")]
	public static T? HDLPGMCEBOI<T>([In] this ADEFLNKAAIF<T> OHEEGJCEELI, T? ALKDPGOIFPD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA45C0", Offset = "0x3AA2FC0", VA = "0x183AA45C0")]
	public static bool ILGACOAOKBM<T>([In] this ADEFLNKAAIF<T> OHEEGJCEELI, T PCDAHJCDHHF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ANAIEJIMCFK
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3007B40", Offset = "0x3006540", VA = "0x183007B40")]
	public static T KMHLOLNMOBB<T>([In] this ADEFLNKAAIF<T> OHEEGJCEELI) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct ACLFKCACOOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr PFGBOBHJPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr IHKABHLFAHL;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr BKJBJLAEBEL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr JFENGEKECPF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly ACLFKCACOOJ BOAAIAHJNJN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1150", Offset = "0x7E9FB50", VA = "0x187EA1150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	public ACLFKCACOOJ(IntPtr CJDIOLIFGEH, IntPtr EAHHFJDJNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void GLLLILCBBKF(string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	private static void FNHIIKAHNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7EA10C0", Offset = "0x7E9FAC0", VA = "0x187EA10C0")]
	private static ACLFKCACOOJ GLGFBGGBLDM()
	{
		return default(ACLFKCACOOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct OIGLOKGBPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr CPOMNIDKLLN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
	private OIGLOKGBPEF(IntPtr EAHHFJDJNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD780", Offset = "0x7EAC180", VA = "0x187EAD780")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD6B0", Offset = "0x7EAC0B0", VA = "0x187EAD6B0")]
	public static OIGLOKGBPEF FMDOFBCLPJB(string GBCFHNGPBLM)
	{
		return default(OIGLOKGBPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28EA260", Offset = "0x28E8C60", VA = "0x1828EA260")]
	public static OIGLOKGBPEF FMDOFBCLPJB([In] ACLFKCACOOJ FLJMEHGJDMK, string GBCFHNGPBLM)
	{
		return default(OIGLOKGBPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28E9D10", Offset = "0x28E8710", VA = "0x1828E9D10")]
	public static OIGLOKGBPEF FMDOFBCLPJB([In] ACLFKCACOOJ FLJMEHGJDMK, Func<string> GBCFHNGPBLM)
	{
		return default(OIGLOKGBPEF);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class AEMIEEJMBIP : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? CJCBLPIBJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr HOFLFEOHDEB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool BGJIMDBCDND
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1940", Offset = "0x7EA0340", VA = "0x187EA1940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA18C0", Offset = "0x7EA02C0", VA = "0x187EA18C0")]
	public static SHA256 JEBOFNEMEAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7EA15A0", Offset = "0x7E9FFA0", VA = "0x187EA15A0")]
	private static extern int FAPPELEONIK();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1360", Offset = "0x7E9FD60", VA = "0x187EA1360")]
	private static extern IntPtr BCIDMJKDOGK();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1460", Offset = "0x7E9FE60", VA = "0x187EA1460")]
	private static extern void EEBIIJKPOLI(IntPtr HOFLFEOHDEB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA14E0", Offset = "0x7E9FEE0", VA = "0x187EA14E0")]
	private static extern void EPBCNLILKHE(IntPtr HOFLFEOHDEB, byte[] HPGIDELCODH, int BACDJHJBLPL, int KCAEMEEJMBD);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1A30", Offset = "0x7EA0430", VA = "0x187EA1A30")]
	private static extern void PJNBHAJFMGC(IntPtr HOFLFEOHDEB, byte[] DJCFNNJAKPD);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1AD0", Offset = "0x7EA04D0", VA = "0x187EA1AD0")]
	private AEMIEEJMBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1610", Offset = "0x7EA0010", VA = "0x187EA1610", Slot = "18")]
	protected override void HashCore(byte[] KLDOGKPLNJA, int OMOPPIPNHOL, int ILKEDLKCMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EA16D0", Offset = "0x7EA00D0", VA = "0x187EA16D0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1800", Offset = "0x7EA0200", VA = "0x187EA1800", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EA13D0", Offset = "0x7E9FDD0", VA = "0x187EA13D0", Slot = "13")]
	protected override void Dispose(bool KDBPBCNACOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MAJDFODBAFI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool FOPHKOKCCHD<in TInput, TResult>(TInput OKFHNJPHDOP, [Out] TResult MGJNMKLFKCJ);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class GHACOFJEKMI : KBNMJEOCCCO
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class NFNMBBNBHKA : MEJLHACDHMF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NFNMBBNBHKA FDCAMNOGINK;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool CMMJBHMPAEK
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x7EACC10", Offset = "0x7EAB610", VA = "0x187EACC10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7EACC70", Offset = "0x7EAB670", VA = "0x187EACC70", Slot = "6")]
			public void OnCompleted(Action KHHCHOOINCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			public void JMNIGMOFGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public NFNMBBNBHKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly GHACOFJEKMI FDCAMNOGINK;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		private GHACOFJEKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6750", Offset = "0x7EA5150", VA = "0x187EA6750", Slot = "4")]
		public MEJLHACDHMF KGCPCIIMFBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class AAAPPKIAMBP : KBNMJEOCCCO
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class MGOHHIMJCFA : MEJLHACDHMF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly MGOHHIMJCFA FDCAMNOGINK;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool CMMJBHMPAEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x7EACAE0", Offset = "0x7EAB4E0", VA = "0x187EACAE0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7EACB00", Offset = "0x7EAB500", VA = "0x187EACB00", Slot = "6")]
			public void OnCompleted(Action KHHCHOOINCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			public void JMNIGMOFGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MGOHHIMJCFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly AAAPPKIAMBP FDCAMNOGINK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		private AAAPPKIAMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1000", Offset = "0x7E9FA00", VA = "0x187EA1000", Slot = "4")]
		public MEJLHACDHMF KGCPCIIMFBP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class JOFGAJBPHIJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JOFGAJBPHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4C95630", Offset = "0x4C94030", VA = "0x184C95630")]
		internal void MADJKAPMIJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EKMKMAFAJLB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EKMKMAFAJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x469E970", Offset = "0x469D370", VA = "0x18469E970")]
		internal void LBMCFGNCMEF(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DPDOIMMPOOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA5790", Offset = "0x7EA4190", VA = "0x187EA5790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HLHGOCKBHMI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA6CA0", Offset = "0x7EA56A0", VA = "0x187EA6CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EECMKMKNMHE<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x4689D10", Offset = "0x4688710", VA = "0x184689D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4689E80", Offset = "0x4688880", VA = "0x184689E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MJAHCFAGMMD<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x54817B0", Offset = "0x54801B0", VA = "0x1854817B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5481FE0", Offset = "0x54809E0", VA = "0x185481FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NHAIPMPFNAF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EACE30", Offset = "0x7EAB830", VA = "0x187EACE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD040", Offset = "0x7EABA40", VA = "0x187EAD040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class AADFFBLDJHJ<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AADFFBLDJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4C95630", Offset = "0x4C94030", VA = "0x184C95630")]
		internal void KCLFKJJNAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4C95670", Offset = "0x4C94070", VA = "0x184C95670")]
		internal void ONEDLCOAKKG(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct PJBLFCFCLAA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public FOPHKOKCCHD<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x577DD60", Offset = "0x577C760", VA = "0x18577DD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x577E410", Offset = "0x577CE10", VA = "0x18577E410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct CDGIMNGBGNM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA36B0", Offset = "0x7EA20B0", VA = "0x187EA36B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3EB0", Offset = "0x7EA28B0", VA = "0x187EA3EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct KKIFNAJIIGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA85F0", Offset = "0x7EA6FF0", VA = "0x187EA85F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8B40", Offset = "0x7EA7540", VA = "0x187EA8B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JAMBGCAEDKG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x504FFC0", Offset = "0x504E9C0", VA = "0x18504FFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50507D0", Offset = "0x504F1D0", VA = "0x1850507D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KFGGALLBABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<NOHGHNIBNOG> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KFGGALLBABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA84E0", Offset = "0x7EA6EE0", VA = "0x187EA84E0")]
		internal void DFHILJJDEHP(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct DFCCCLOFPCF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6AEBF90", Offset = "0x6AEA990", VA = "0x186AEBF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x423C9C0", Offset = "0x423B3C0", VA = "0x18423C9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NPFMGIHCJDH<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5557A60", Offset = "0x5556460", VA = "0x185557A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x423BAF0", Offset = "0x423A4F0", VA = "0x18423BAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct EIAMAKPMAHD<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x469BD40", Offset = "0x469A740", VA = "0x18469BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x469C530", Offset = "0x469AF30", VA = "0x18469C530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct CLLMINIJKKA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA4BF0", Offset = "0x7EA35F0", VA = "0x187EA4BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4DD0", Offset = "0x7EA37D0", VA = "0x187EA4DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct OBJLKOEEACC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EAD1C0", Offset = "0x7EABBC0", VA = "0x187EAD1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD520", Offset = "0x7EABF20", VA = "0x187EAD520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct CFMLCKCMPKM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA3F40", Offset = "0x7EA2940", VA = "0x187EA3F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4230", Offset = "0x7EA2C30", VA = "0x187EA4230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EHPPAIKEGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EHPPAIKEGGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5BA0", Offset = "0x7EA45A0", VA = "0x187EA5BA0")]
		internal Task PLKEKMJLGIM(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct EMGILMNHPNG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA5C10", Offset = "0x7EA4610", VA = "0x187EA5C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5E70", Offset = "0x7EA4870", VA = "0x187EA5E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct EHCHGPMMJAK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA5960", Offset = "0x7EA4360", VA = "0x187EA5960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5B40", Offset = "0x7EA4540", VA = "0x187EA5B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct DLANPCEPGLE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA4E30", Offset = "0x7EA3830", VA = "0x187EA4E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA5190", Offset = "0x7EA3B90", VA = "0x187EA5190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IILHLNJIKKK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA6EE0", Offset = "0x7EA58E0", VA = "0x187EA6EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7EA71D0", Offset = "0x7EA5BD0", VA = "0x187EA71D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GCLNAKIBADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GCLNAKIBADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7EA66E0", Offset = "0x7EA50E0", VA = "0x187EA66E0")]
		internal Task PGEBBADLPNL(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct GCGHGABHAKH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA6420", Offset = "0x7EA4E20", VA = "0x187EA6420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6680", Offset = "0x7EA5080", VA = "0x187EA6680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct GMEGHOCJCML : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA6810", Offset = "0x7EA5210", VA = "0x187EA6810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7EA6990", Offset = "0x7EA5390", VA = "0x187EA6990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct GAGAHFHBHDI<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4C30060", Offset = "0x4C2EA60", VA = "0x184C30060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4C302B0", Offset = "0x4C2ECB0", VA = "0x184C302B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct ILAKHPNHMIK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA7230", Offset = "0x7EA5C30", VA = "0x187EA7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7560", Offset = "0x7EA5F60", VA = "0x187EA7560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? DBJGACBNIIA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<NOHGHNIBNOG> BHMHCKEPCKK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task KPOPPOJDAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA260", Offset = "0x7EA8C60", VA = "0x187EAA260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA4D0", Offset = "0x7EA8ED0", VA = "0x187EAA4D0")]
	public static bool CMMAOJCNNCE(this Task HAAEKADIBMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3B38280", Offset = "0x3B36C80", VA = "0x183B38280")]
	public static Task<T> KPFILFAPEOD<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EAAE90", Offset = "0x7EA9890", VA = "0x187EAAE90")]
	public static Task GAJIMGJGNMH(this Task HAAEKADIBMM, CancellationToken BECBHDDLOHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3B36A80", Offset = "0x3B35480", VA = "0x183B36A80")]
	public static Task<TResult> GAJIMGJGNMH<TResult>(this Task<TResult> HAAEKADIBMM, CancellationToken BECBHDDLOHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3B35FC0", Offset = "0x3B349C0", VA = "0x183B35FC0")]
	public static TaskCompletionSource<TResult> GAJIMGJGNMH<TResult>(this TaskCompletionSource<TResult> LMMMGOIHAIN, CancellationToken BECBHDDLOHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA730", Offset = "0x7EA9130", VA = "0x187EAA730")]
	public static IDisposable? FFDCBMMKJOE(CancellationToken AOAKCEHAHID, CancellationToken GFLMLDJLCEJ, [Out] CancellationToken ONKBILPOOAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC150", Offset = "0x7EAAB50", VA = "0x187EAC150")]
	[AsyncStateMachine(typeof(DPDOIMMPOOO))]
	public static void PBIAOBLEJGM(this Task ANAFNAJGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EABDB0", Offset = "0x7EAA7B0", VA = "0x187EABDB0")]
	[AsyncStateMachine(typeof(HLHGOCKBHMI))]
	public static void LGBNPKLDOKN(this Task ANAFNAJGANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B38810", Offset = "0x3B37210", VA = "0x183B38810")]
	[AsyncStateMachine(typeof(EECMKMKNMHE<>))]
	public static Task LNHONADIIFC<TException>(this Task ANAFNAJGANI) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B33910", Offset = "0x3B32310", VA = "0x183B33910")]
	[AsyncStateMachine(typeof(MJAHCFAGMMD<>))]
	public static Task<T> BIJLKLEHLLH<T>(this Task<T> NMEFAPBBOCD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB360", Offset = "0x7EA9D60", VA = "0x187EAB360")]
	[AsyncStateMachine(typeof(NHAIPMPFNAF))]
	public static Task<TaskStatus> IDKEMLJFMNF(this Task? NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B38040", Offset = "0x3B36A40", VA = "0x183B38040")]
	public static (Task<T?>?, Action<T?>?) KHJCOAHKAMG<T>([Optional] CancellationToken JKPNCAGHEDI)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B33810", Offset = "0x3B32210", VA = "0x183B33810")]
	[AsyncStateMachine(typeof(PJBLFCFCLAA<, >))]
	public static Task<List<TResult>> BHNBPONDFNM<TResult, TInput>(this Task<List<TInput>> HAAEKADIBMM, FOPHKOKCCHD<TInput, TResult> BNOFGEMOODI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB230", Offset = "0x7EA9C30", VA = "0x187EAB230")]
	[AsyncStateMachine(typeof(CDGIMNGBGNM))]
	public static Task HIBNIKAKDLO(Task ANAFNAJGANI, CancellationToken IFGGPDNONLM, Func<CancellationToken, Task> BFMJMOFJIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EABC80", Offset = "0x7EAA680", VA = "0x187EABC80")]
	[AsyncStateMachine(typeof(KKIFNAJIIGH))]
	public static Task LCPHBGNKPJP(Func<CancellationToken, Task> IHKJPCPFJEA, TimeSpan PFDFCFFBOMM, [Optional] CancellationToken IFGGPDNONLM, [Optional] Action<OperationCanceledException>? FEAAHOLGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B383D0", Offset = "0x3B36DD0", VA = "0x183B383D0")]
	[AsyncStateMachine(typeof(JAMBGCAEDKG<>))]
	public static Task<T> LCPHBGNKPJP<T>(Func<CancellationToken, Task<T>> IHKJPCPFJEA, TimeSpan PFDFCFFBOMM, [Optional] CancellationToken IFGGPDNONLM, [Optional] Func<OperationCanceledException, T>? FEAAHOLGEJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB500", Offset = "0x7EA9F00", VA = "0x187EAB500")]
	public static Task KJEIHGKFCFJ(params Task[] HDMEIOBGENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB550", Offset = "0x7EA9F50", VA = "0x187EAB550")]
	public static Task KJEIHGKFCFJ(IEnumerable<Task> HDMEIOBGENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B33BB0", Offset = "0x3B325B0", VA = "0x183B33BB0")]
	[AsyncStateMachine(typeof(DFCCCLOFPCF<>))]
	public static Task<IEnumerable<Task<T>>> FEKDHEOBJDG<T>(IEnumerable<Task<T>> HDMEIOBGENF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B336F0", Offset = "0x3B320F0", VA = "0x183B336F0")]
	[AsyncStateMachine(typeof(NPFMGIHCJDH<, , >))]
	public static Task<(T1, T2, T3)> ABIMCOINBMG<T1, T2, T3>(Task<T1> FAOMHCPEDPC, Task<T2> ACJOIDODFCB, Task<T3> BIHFJHIEMLF) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B33430", Offset = "0x3B31E30", VA = "0x183B33430")]
	[AsyncStateMachine(typeof(EIAMAKPMAHD<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> ABIMCOINBMG<T1, T2, T3, T4, T5>(Task<T1> FAOMHCPEDPC, Task<T2> ACJOIDODFCB, Task<T3> BIHFJHIEMLF, Task<T4> OKPEDAFEEML, Task<T5> LGPKFNBKLMG) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA3E0", Offset = "0x7EA8DE0", VA = "0x187EAA3E0")]
	[AsyncStateMachine(typeof(CLLMINIJKKA))]
	public static Task BNEHIEJOLON(Func<bool> APOGDCILJPL, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA2D0", Offset = "0x7EA8CD0", VA = "0x187EAA2D0")]
	[AsyncStateMachine(typeof(OBJLKOEEACC))]
	public static Task BNEHIEJOLON(Func<bool> APOGDCILJPL, TimeSpan DDNICMNAMKO, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EABA10", Offset = "0x7EAA410", VA = "0x187EABA10")]
	[AsyncStateMachine(typeof(CFMLCKCMPKM))]
	public static Task KLHEFHPIBCA(Func<bool> APOGDCILJPL, TimeSpan PFDFCFFBOMM, [Optional] CancellationToken JKPNCAGHEDI, [Optional] Action<OperationCanceledException>? FEAAHOLGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EABB40", Offset = "0x7EAA540", VA = "0x187EABB40")]
	[AsyncStateMachine(typeof(EMGILMNHPNG))]
	public static Task KLHEFHPIBCA(Func<bool> APOGDCILJPL, TimeSpan PFDFCFFBOMM, TimeSpan DDNICMNAMKO, [Optional] CancellationToken JKPNCAGHEDI, [Optional] Action<OperationCanceledException>? FEAAHOLGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EABF50", Offset = "0x7EAA950", VA = "0x187EABF50")]
	[AsyncStateMachine(typeof(EHCHGPMMJAK))]
	public static Task NDHHPCEMHBM(Func<bool> APOGDCILJPL, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC040", Offset = "0x7EAAA40", VA = "0x187EAC040")]
	[AsyncStateMachine(typeof(DLANPCEPGLE))]
	public static Task NDHHPCEMHBM(Func<bool> APOGDCILJPL, TimeSpan DDNICMNAMKO, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EAAC20", Offset = "0x7EA9620", VA = "0x187EAAC20")]
	[AsyncStateMachine(typeof(IILHLNJIKKK))]
	public static Task FMBIPGIAHGC(Func<bool> APOGDCILJPL, TimeSpan PFDFCFFBOMM, [Optional] CancellationToken JKPNCAGHEDI, [Optional] Action<OperationCanceledException>? FEAAHOLGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EAAD50", Offset = "0x7EA9750", VA = "0x187EAAD50")]
	[AsyncStateMachine(typeof(GCGHGABHAKH))]
	public static Task FMBIPGIAHGC(Func<bool> APOGDCILJPL, TimeSpan PFDFCFFBOMM, TimeSpan DDNICMNAMKO, [Optional] CancellationToken JKPNCAGHEDI, [Optional] Action<OperationCanceledException>? FEAAHOLGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EABE60", Offset = "0x7EAA860", VA = "0x187EABE60")]
	[AsyncStateMachine(typeof(GMEGHOCJCML))]
	[Obsolete]
	public static Task LHPPMIMPFJE(this Task HAAEKADIBMM, Action FCFBBKDECMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3B38630", Offset = "0x3B37030", VA = "0x183B38630")]
	[AsyncStateMachine(typeof(GAGAHFHBHDI<>))]
	[Obsolete]
	public static Task LHPPMIMPFJE<T>(this Task<T> HAAEKADIBMM, Action<T> FCFBBKDECMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB450", Offset = "0x7EA9E50", VA = "0x187EAB450")]
	private static void JNOINDCCLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA8C0", Offset = "0x7EA92C0", VA = "0x187EAA8C0")]
	public static bool FJBCPGPMNAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC200", Offset = "0x7EAAC00", VA = "0x187EAC200")]
	private static void PKLPHEFHIKF(SynchronizationContext PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA550", Offset = "0x7EA8F50", VA = "0x187EAA550")]
	private static void EGCKONHGBCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA660", Offset = "0x7EA9060", VA = "0x187EAA660")]
	public static void EJECNHCGGHK([Optional] string? IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB0E0", Offset = "0x7EA9AE0", VA = "0x187EAB0E0")]
	public static void GGOHEBFINOC([Optional] string? IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA500", Offset = "0x7EA8F00", VA = "0x187EAA500")]
	public static KBNMJEOCCCO EBBBCECOLKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC380", Offset = "0x7EAAD80", VA = "0x187EAC380")]
	public static KBNMJEOCCCO PMHAOLOLLKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB160", Offset = "0x7EA9B60", VA = "0x187EAB160")]
	[AsyncStateMachine(typeof(ILAKHPNHMIK))]
	public static Task GMINOFOOFNH(Func<Task> IDNDDAFIIDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NHPBPJDIEFG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public NHPBPJDIEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class GPNJCHNIFLJ
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6A60", Offset = "0x7EA5460", VA = "0x187EA6A60")]
	public static bool DPFONGCGLME(this FBMKJPBIMJP AJJLNPMMJBK, DateTime LAINAGHGCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6B80", Offset = "0x7EA5580", VA = "0x187EA6B80")]
	public static TimeSpan NKKGGGNMGGF(this FBMKJPBIMJP AJJLNPMMJBK, DateTime LAINAGHGCNM)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OMKNPNAJBJP : FBMKJPBIMJP
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly FBMKJPBIMJP FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime HGBFAPJFIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7EADAB0", Offset = "0x7EAC4B0", VA = "0x187EADAB0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset KPDPILJKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7EADAF0", Offset = "0x7EAC4F0", VA = "0x187EADAF0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OMKNPNAJBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface FBMKJPBIMJP
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime HGBFAPJFIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset KPDPILJKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class AJILOBMAEAO
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long IHNLJJBIOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1F70", Offset = "0x7EA0970", VA = "0x187EA1F70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long GNPBHBCDJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1FC0", Offset = "0x7EA09C0", VA = "0x187EA1FC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double FCEFOLIKOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1DC0", Offset = "0x7EA07C0", VA = "0x187EA1DC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double FOJBOLAIEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1D00", Offset = "0x7EA0700", VA = "0x187EA1D00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double AEAOAIJELLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1C20", Offset = "0x7EA0620", VA = "0x187EA1C20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double MNECGHACNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2010", Offset = "0x7EA0A10", VA = "0x187EA2010")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1C70", Offset = "0x7EA0670", VA = "0x187EA1C70")]
	public static double FCLKBIOEDLN(long KGAFDOKOFJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1B90", Offset = "0x7EA0590", VA = "0x187EA1B90")]
	public static double DNKNNPBJKNL(long KGAFDOKOFJJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1EE0", Offset = "0x7EA08E0", VA = "0x187EA1EE0")]
	public static double LHIMLBGIKDJ(double EJDPCOEGOFN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1B00", Offset = "0x7EA0500", VA = "0x187EA1B00")]
	public static long APLNPDNDGJE(long CAJJAMECEFA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1DB0", Offset = "0x7EA07B0", VA = "0x187EA1DB0")]
	public static long JNFMMACEFCF(long KFFBJHONJMC, long AEKMBAIKHBP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1E10", Offset = "0x7EA0810", VA = "0x187EA1E10")]
	public static double LBACIMOAECL(long KFFBJHONJMC, long AEKMBAIKHBP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7EA1D50", Offset = "0x7EA0750", VA = "0x187EA1D50")]
	public static double IPKJGMJCOGG(long KFFBJHONJMC, long AEKMBAIKHBP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class BAICDBMNDCC : LJHAHDLAIDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan DBHCMLDMAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer JNHNJKFGOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan PFDFCFFBOMM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan MNFBJAEACJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7EA30A0", Offset = "0x7EA1AA0", VA = "0x187EA30A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? BKFMAJFMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3550", Offset = "0x7EA1F50", VA = "0x187EA3550")]
	[Preserve]
	public BAICDBMNDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3300", Offset = "0x7EA1D00", VA = "0x187EA3300")]
	public BAICDBMNDCC(TimeSpan PFDFCFFBOMM, [Optional] Action? BEFPHPILGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3200", Offset = "0x7EA1C00", VA = "0x187EA3200", Slot = "7")]
	public void OAPJNMIFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2ED0", Offset = "0x7EA18D0", VA = "0x187EA2ED0", Slot = "8")]
	public void DIOAFMFNAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2FE0", Offset = "0x7EA19E0", VA = "0x187EA2FE0", Slot = "9")]
	public void GPBACMFGIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x11DF5F0", Offset = "0x11DDFF0", VA = "0x1811DF5F0")]
	private void MEMKMDJEGDA(object FHFGMILAALL, ElapsedEventArgs CDOCPBHLDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA3010", Offset = "0x7EA1A10", VA = "0x187EA3010")]
	private static void JABCDPAPCFC(TimeSpan MHIPFJEABPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA2F40", Offset = "0x7EA1940", VA = "0x187EA2F40", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class PNLDDMBLJGN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? IOJNCMCCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string CKFNMAMOGDM;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x17F02B0", Offset = "0x17EECB0", VA = "0x1817F02B0")]
	public PNLDDMBLJGN(string NLIGMLKPGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4F7EA00", Offset = "0x4F7D400", VA = "0x184F7EA00")]
	public PNLDDMBLJGN(string GBJOGAJJMBI, string NLIGMLKPGCH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct ILCBHHHGFAE : IEquatable<ILCBHHHGFAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint AHAHLFINGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int PBIMLOAOJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float AKMFFGEKALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort DFGEJIABKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort OFAKEEMICJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short KKFAAIIMGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short FGJDJCOLMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char IOKPCIHCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char DGCBNICBGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte CAEONBGCEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte LLBEICABDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte FLHCDOPIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte BAJBKBNIFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool CGHHOCINFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool NGCHGJLPJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool LDFGICGBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool PJHGFJKHFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB340", Offset = "0x1FC9D40", VA = "0x181FCB340")]
	public static ILCBHHHGFAE OONIPAKLMEI(uint JFKLFMMMGOM)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB340", Offset = "0x1FC9D40", VA = "0x181FCB340")]
	public static ILCBHHHGFAE GMIHLIIOMME(int OLMEHPMACFF)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7EA75E0", Offset = "0x7EA5FE0", VA = "0x187EA75E0")]
	public static ILCBHHHGFAE BHOPGHPFPGH(float BHJOGGADGEO)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7EA75C0", Offset = "0x7EA5FC0", VA = "0x187EA75C0")]
	public static ILCBHHHGFAE ANOAPJBKNJA(byte MGHHDJPKHAL, byte NGJMNOGAAKE, byte HMLFILOMGHL, byte LNGFOIJGNCJ)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7EA75C0", Offset = "0x7EA5FC0", VA = "0x187EA75C0")]
	public static ILCBHHHGFAE AIBCNBHGBII(bool MJHEOGGGBHI, bool GOGFOGIBEMH, bool GEGOCOBHKJN, bool PJLNOEJBPGI)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7EA75C0", Offset = "0x7EA5FC0", VA = "0x187EA75C0")]
	public static ILCBHHHGFAE COLHHHEJPNJ(byte FMCIBODLKHN, byte BOGGAMKAPOB, byte OLDPMLGKFKJ, byte BJIIHDPCCGB)
	{
		return default(ILCBHHHGFAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x22D9F60", Offset = "0x22D8960", VA = "0x1822D9F60")]
	public static bool IDFALDDOLDN(ILCBHHHGFAE LCMCGCNDGLJ, ILCBHHHGFAE JAOCPECLJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x22D9F40", Offset = "0x22D8940", VA = "0x1822D9F40", Slot = "4")]
	public bool Equals(ILCBHHHGFAE NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7EA75F0", Offset = "0x7EA5FF0", VA = "0x187EA75F0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1425070", Offset = "0x1423A70", VA = "0x181425070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7680", Offset = "0x7EA6080", VA = "0x187EA7680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct MNBHFFHACEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong IICHAFGIOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long GHHKNOMAMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double DEPFCGHOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint LPNNAAOCLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint KADHONNCKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int PFNFDNGEMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int ACPDDIEFJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float OFGEKEJHGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float ODKPIAEKFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort DFGEJIABKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort OFAKEEMICJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort IBNLEOFJCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort FIKPHFAFLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short KKFAAIIMGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short FGJDJCOLMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short OEIHNLHHCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short HBIJPPJHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char IOKPCIHCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char DGCBNICBGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char BENBONECJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char JEEPFDHIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte CAEONBGCEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte LLBEICABDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte FLHCDOPIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte BAJBKBNIFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte CEKOKABGCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte MCEMGKCNBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte OBCHIBPFJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte KFCMOHHNOPA;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static MNBHFFHACEI FMDOFBCLPJB(long MPKGPAPEFKD)
	{
		return default(MNBHFFHACEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7EACBC0", Offset = "0x7EAB5C0", VA = "0x187EACBC0")]
	public static MNBHFFHACEI FMDOFBCLPJB(byte MGHHDJPKHAL, byte NGJMNOGAAKE, byte HMLFILOMGHL, byte LNGFOIJGNCJ, byte JOAECGLNEEN, byte ENJHGAHMDJI, byte EMBJANLCBAB, byte AJAFDKNHMHM)
	{
		return default(MNBHFFHACEI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct OIKNKGLOJHN : IEquatable<OIKNKGLOJHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte LCEFLOGJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool GNGPGDMPBPO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2FCED10", Offset = "0x2FCD710", VA = "0x182FCED10")]
	public static OIKNKGLOJHN ANOAPJBKNJA(byte IBLHGDCFNKG)
	{
		return default(OIKNKGLOJHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2FCED10", Offset = "0x2FCD710", VA = "0x182FCED10")]
	public static OIKNKGLOJHN AIBCNBHGBII(bool MHMDPCCBCNG)
	{
		return default(OIKNKGLOJHN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD830", Offset = "0x7EAC230", VA = "0x187EAD830")]
	public static bool IDFALDDOLDN(OIKNKGLOJHN LCMCGCNDGLJ, OIKNKGLOJHN JAOCPECLJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4CF0", Offset = "0x6DB36F0", VA = "0x186DB4CF0", Slot = "4")]
	public bool Equals(OIKNKGLOJHN NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD790", Offset = "0x7EAC190", VA = "0x187EAD790", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD820", Offset = "0x7EAC220", VA = "0x187EAD820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD840", Offset = "0x7EAC240", VA = "0x187EAD840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MKFOPFJJNPG<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T LPHJONFFIAP;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5497920", Offset = "0x5496320", VA = "0x185497920")]
	public MKFOPFJJNPG(T GPBGBJGOCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class LLABBLJPBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3B21540", Offset = "0x3B1FF40", VA = "0x183B21540")]
	public static IEnumerable<T> LDHMHDJFMAK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static T[] KKKEDHCFJCI<T>(params T[] DPDFKCHPLJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static IEnumerable<T> GABHMILKHGB<T>(params T[] DPDFKCHPLJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static HashSet<T> LJEAFJKLMKB<T>(params T[] DPDFKCHPLJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3B21450", Offset = "0x3B1FE50", VA = "0x183B21450")]
	public static KeyValuePair<TKey, TValue> JCHOOBAFFOG<TKey, TValue>([In] TKey KJNEHANBOBO, [In] TValue PCDAHJCDHHF) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static List<T> DJPDDFIOEDO<T>(IEnumerable<T> PCNLBIOPFBD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JJPBBEHPLCH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string EJCEAFBIPEC;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
	public JJPBBEHPLCH(string NNIEOPCEMIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object PMHGMHJMGNL<T>([In] T MPEOAHOICFG);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object BFAONNCALDI<T>(T MPEOAHOICFG);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BFODFIPKJBK]
public delegate string BAIKJMGGBBI(string JDGADODOANI, string? IOFCDGOOFLO, bool NIOCGEFMEEB);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[BFODFIPKJBK]
public delegate void LHDAFKCNEBF(string IJOJGNJMCGP);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[BFODFIPKJBK]
public delegate void NJKBCLEGLLN(Exception AGKNBEAOFAM);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object EKAGHBMGAGO();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BFODFIPKJBK]
public delegate bool NNMDIAINNOA();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BFODFIPKJBK]
public delegate string JIKAJJBCEAF(object OJDHMKOBKLD);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class IODHACNMKFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
	public IODHACNMKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class MFOAHCMENCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct CGDHBIGCEAM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7EA4290", Offset = "0x7EA2C90", VA = "0x187EA4290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4B80", Offset = "0x7EA3580", VA = "0x187EA4B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback PNDLCGBPOAO;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> KJCDIDBBCLO;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC6E0", Offset = "0x7EAB0E0", VA = "0x187EAC6E0")]
	public static Task<bool> MDMEKEOCGOI(int OCKNHBIOBIK, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC490", Offset = "0x7EAAE90", VA = "0x187EAC490")]
	[AsyncStateMachine(typeof(CGDHBIGCEAM))]
	private static Task<bool> FIGPIILGPPM(int OCKNHBIOBIK, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC650", Offset = "0x7EAB050", VA = "0x187EAC650")]
	private static void KLLIFGEKDHC(object? LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EAC5C0", Offset = "0x7EAAFC0", VA = "0x187EAC5C0")]
	private static void GFLIKLLPLCD(object? LOPOEJHIPKN)
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
