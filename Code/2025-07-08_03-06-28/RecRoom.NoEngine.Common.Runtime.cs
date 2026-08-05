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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x821FAB0", Offset = "0x821E8B0", VA = "0x18821FAB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DBCPCMBMGDH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8217670", Offset = "0x8216470", VA = "0x188217670")]
	public static string MEPOCCEKCCJ(this Encoding FDOFFKPLGGL, [In] ReadOnlySequence<byte> JMAPKDPGDHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39D8570", Offset = "0x39D7370", VA = "0x1839D8570")]
	private static void MKOLGLDEBNB<T>(this ReadOnlySequence<T> NNFLKJPCODF, [Out] ReadOnlySpan<T> AJHLMOOOANL, [Out] SequencePosition KJEMFGFCMLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class CKHBPEFJDAH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8216300", Offset = "0x8215100", VA = "0x188216300")]
	public CKHBPEFJDAH(bool BPBOKNAMFJP, string IGCAALLNKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82162B0", Offset = "0x82150B0", VA = "0x1882162B0")]
	public CKHBPEFJDAH(bool BPBOKNAMFJP, params string[] GCLLLAOENBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PJKNBBIONOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EDDKMBIBIGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BGFNILCJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDGKOEDDLKB(string MAHBBBBCDEL, double BNECONOIKOE, [Optional] string? LGANJJKKFGC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PLPMOKFOMDC : OGENFNFBALO, IADLDHPLKNE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int IHLDAEAAOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> AFGIDJONGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double IIEOAHPEFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double PFNOCLOHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double LMNLINADJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int KNIAPMGBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double DBBAIOFEJOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KBKBEPILLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA76750", Offset = "0xA75550", VA = "0x180A76750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HGLCPDJGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82216B0", Offset = "0x82204B0", VA = "0x1882216B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HIIMNONPCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F1D9F0", Offset = "0x4F1C7F0", VA = "0x184F1D9F0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double FDPLNGCMINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2937F10", Offset = "0x2936D10", VA = "0x182937F10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8221780", Offset = "0x8220580", VA = "0x188221780")]
	public PLPMOKFOMDC(int KAFFKPDKJNC, double DBBAIOFEJOI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8221580", Offset = "0x8220380", VA = "0x188221580", Slot = "7")]
	public void DPFMIEGBIBJ(double HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8221710", Offset = "0x8220510", VA = "0x188221710", Slot = "8")]
	public void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8221480", Offset = "0x8220280", VA = "0x188221480", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OBGPKEGDBCO : OGENFNFBALO, IADLDHPLKNE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long LJEIHABMGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double GLPDKGMAPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double GFJIGNPMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double ABPFAMLJFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double GEDPDLCCEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double IIEOAHPEFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double PFNOCLOHBOA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HIIMNONPCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7437440", Offset = "0x7436240", VA = "0x187437440", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double FDPLNGCMINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7437890", Offset = "0x7436690", VA = "0x187437890", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double NIFJPHEOPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7437910", Offset = "0x7436710", VA = "0x187437910")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HGLCPDJGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x30A2760", Offset = "0x30A1560", VA = "0x1830A2760", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8220210", Offset = "0x821F010", VA = "0x188220210", Slot = "10")]
	public virtual void DPFMIEGBIBJ(double HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8220330", Offset = "0x821F130", VA = "0x188220330", Slot = "11")]
	public virtual void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82201A0", Offset = "0x821EFA0", VA = "0x1882201A0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x821DA10", Offset = "0x821C810", VA = "0x18821DA10")]
	public OBGPKEGDBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KFEIMEKIOCK : OBGPKEGDBCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double HPOJIJFKBEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74378A0", Offset = "0x74366A0", VA = "0x1874378A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7437920", Offset = "0x7436720", VA = "0x187437920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x821D8A0", Offset = "0x821C6A0", VA = "0x18821D8A0", Slot = "10")]
	public override void DPFMIEGBIBJ(double HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x821D9D0", Offset = "0x821C7D0", VA = "0x18821D9D0", Slot = "11")]
	public override void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x821DA10", Offset = "0x821C810", VA = "0x18821DA10")]
	public KFEIMEKIOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OGENFNFBALO : IADLDHPLKNE, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HGLCPDJGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HIIMNONPCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double FDPLNGCMINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IAPDACKGOAD : IADLDHPLKNE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double PLLMAMBOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double FNFHKHIHHHG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x821C080", Offset = "0x821AE80", VA = "0x18821C080")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E86880", Offset = "0x6E85680", VA = "0x186E86880", Slot = "4")]
	public void DPFMIEGBIBJ(double HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x821C090", Offset = "0x821AE90", VA = "0x18821C090", Slot = "5")]
	public void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x821C030", Offset = "0x821AE30", VA = "0x18821C030", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public IAPDACKGOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IADLDHPLKNE : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPFMIEGBIBJ(double HBLCHHJHKAF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLDNCIPNLFL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ILHMKJOBJHK : IADLDHPLKNE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double BNECONOIKOE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HBDLGDLEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x48AF3C0", Offset = "0x48AE1C0", VA = "0x1848AF3C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56C2CF0", Offset = "0x56C1AF0", VA = "0x1856C2CF0", Slot = "4")]
	public void DPFMIEGBIBJ(double HBLCHHJHKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x821CF80", Offset = "0x821BD80", VA = "0x18821CF80", Slot = "5")]
	public void PLDNCIPNLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x821CF30", Offset = "0x821BD30", VA = "0x18821CF30", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ILHMKJOBJHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FMPDKHKKIBG<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> CAAFOJFPGFE(CancellationToken HIMDFBHMPLL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KIOECMCLIMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FMPDKHKKIBG<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CAAFOJFPGFE taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x52D96A0", Offset = "0x52D84A0", VA = "0x1852D96A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x52DA6F0", Offset = "0x52D94F0", VA = "0x1852DA6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource JJKKCMEFGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? OOOPEGOONKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? EKOBDBKIGOH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1CE0", Offset = "0x4CD0AE0", VA = "0x184CD1CE0")]
	[AsyncStateMachine(typeof(FMPDKHKKIBG<>.KIOECMCLIMH))]
	public Task<TResult> HKPCOGMICNE(CAAFOJFPGFE AAFCGMDBCKB, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1C70", Offset = "0x4CD0A70", VA = "0x184CD1C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4CD1E20", Offset = "0x4CD0C20", VA = "0x184CD1E20")]
	public FMPDKHKKIBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class NJPAPPGCDCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> INGKBCKBGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T HBDLGDLEPJD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5706E10", Offset = "0x5705C10", VA = "0x185706E10")]
	public NJPAPPGCDCG([In] T BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5705F60", Offset = "0x5704D60", VA = "0x185705F60", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5706670", Offset = "0x5705470", VA = "0x185706670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5706BC0", Offset = "0x57059C0", VA = "0x185706BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class FDBJCFCOPOM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static NJPAPPGCDCG<T> OGAKBGHEIKK<T>([In] T BNECONOIKOE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IDELPDFKFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x821C470", Offset = "0x821B270", VA = "0x18821C470")]
	public static void AHNLMOADGPG(this CancellationTokenSource JJKKCMEFGAC, bool GDDMDENNEHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class DKAMILHBBMM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public DKAMILHBBMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class FKKEMMHLABG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public FKKEMMHLABG(string GKACFPNCFLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MBBCEAMJFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DC70", Offset = "0x3C6CA70", VA = "0x183C6DC70")]
	public static MBIMFGCNGCE ILFDAHGKOCG<T>()
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x821E010", Offset = "0x821CE10", VA = "0x18821E010")]
	public static MBIMFGCNGCE BAKBLMEKEGO([CallerMemberName] string GGDFKFACHGG = "")
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DF40", Offset = "0x3C6CD40", VA = "0x183C6DF40")]
	public static MBIMFGCNGCE OHOAEDIFJAJ<T>([CallerMemberName] string GGDFKFACHGG = "") where T : notnull
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DCF0", Offset = "0x3C6CAF0", VA = "0x183C6DCF0")]
	public static MBIMFGCNGCE ILFDAHGKOCG<T>(this T FCNMCCJKGMG) where T : notnull
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DB20", Offset = "0x3C6C920", VA = "0x183C6DB20")]
	public static MBIMFGCNGCE BAKBLMEKEGO<T>(this T FCNMCCJKGMG, [CallerMemberName] string GGDFKFACHGG = "") where T : notnull
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DEA0", Offset = "0x3C6CCA0", VA = "0x183C6DEA0")]
	public static MBIMFGCNGCE OHOAEDIFJAJ<T>(this T FEOFEEGOGIO, [CallerMemberName] string GGDFKFACHGG = "") where T : notnull
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x821E110", Offset = "0x821CF10", VA = "0x18821E110")]
	public static MBIMFGCNGCE OHOAEDIFJAJ(string MANIKCCKLAL, [CallerMemberName] string GGDFKFACHGG = "")
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x821E070", Offset = "0x821CE70", VA = "0x18821E070")]
	public static string FCEJMBIIKOJ(this object FEOFEEGOGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool NOHGEEFJNDF();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DKAMILHBBMM]
public delegate long IIMDHIBEMNC();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class ALAPGPNDJHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly ALAPGPNDJHO ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ALAPGPNDJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CMPEJGJLPCN
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static IKHFFACFPLM NOJJLEPJMOD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static IKHFFACFPLM BJBGIPHGIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8216840", Offset = "0x8215640", VA = "0x188216840")]
		get
		{
			return default(IKHFFACFPLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static AOMNGHJFFHH CJLIGFCIONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82166B0", Offset = "0x82154B0", VA = "0x1882166B0")]
		get
		{
			return default(AOMNGHJFFHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KJPPOMMCDJI MIMFPEDAGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82169C0", Offset = "0x82157C0", VA = "0x1882169C0")]
		get
		{
			return default(KJPPOMMCDJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool AJLCCBJNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8216BE0", Offset = "0x82159E0", VA = "0x188216BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82163E0", Offset = "0x82151E0", VA = "0x1882163E0")]
	public static void CDCIJIAMOLF([In] IKHFFACFPLM JDFGDBIOMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8216B10", Offset = "0x8215910", VA = "0x188216B10")]
	public static void OJKKHHLLEBA(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82168F0", Offset = "0x82156F0", VA = "0x1882168F0")]
	public static void JBNCFEFNHCM(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x399CF50", Offset = "0x399BD50", VA = "0x18399CF50")]
	public static void JBNCFEFNHCM<T>(T AGJNJFMNGDN, PKIEPKHJHIB<T> IIHOFBLPONF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8216590", Offset = "0x8215390", VA = "0x188216590")]
	public static void DEPKPMLPLID(Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8216AB0", Offset = "0x82158B0", VA = "0x188216AB0")]
	public static void JMENDEMKJDC(string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8216890", Offset = "0x8215690", VA = "0x188216890")]
	public static void INDBGHKAAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8216630", Offset = "0x8215430", VA = "0x188216630")]
	public static string FCEJMBIIKOJ(object MKPNGAKJFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8216700", Offset = "0x8215500", VA = "0x188216700")]
	public static long HEPIGDNCLBB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8216A10", Offset = "0x8215810", VA = "0x188216A10")]
	public static bool JLCEAKHEPPG(bool LPCLMFMENJN, string IIHOFBLPONF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8216770", Offset = "0x8215570", VA = "0x188216770")]
	public static double IAKGLCDKECD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct IKHFFACFPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly AOMNGHJFFHH CJLIGFCIONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly KJPPOMMCDJI MIMFPEDAGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly IICAJINIGPF GNDNDFHIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly IIMDHIBEMNC GGIIMLLAMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly HACPPOMLEKP LANLJMMGOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly NOHGEEFJNDF AADEJEGMGKE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IICAJINIGPF MOCBNJHLKMN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly IIMDHIBEMNC AFPDDPLLAEG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HACPPOMLEKP EAOHPOMACGM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NOHGEEFJNDF JENOMBOIEFK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IKHFFACFPLM MMHNBCKELFI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x821C5F0", Offset = "0x821B3F0", VA = "0x18821C5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x821CE80", Offset = "0x821BC80", VA = "0x18821CE80")]
	public IKHFFACFPLM([In] AOMNGHJFFHH BJEEAIJGGBN, [In] KJPPOMMCDJI BCMDOHOMHOM, IICAJINIGPF HIAAOADDNBN, IIMDHIBEMNC EGGHBMFDAHD, HACPPOMLEKP NGIDAPHJLOC, NOHGEEFJNDF DDHKNBCKDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x821C4A0", Offset = "0x821B2A0", VA = "0x18821C4A0")]
	private static string CILNAENEONK(object MKPNGAKJFMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	private static long OBBDDLPBDDD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	private static string FHGOPENKNMB(string JFJICNCOLKA, string? LMICOICMKNA, bool JNKEJOKJMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	private static bool OGOAAGKHCBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x821C4E0", Offset = "0x821B2E0", VA = "0x18821C4E0")]
	private static IKHFFACFPLM JOBCJJPNBBG()
	{
		return default(IKHFFACFPLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BPLLAOKLPCO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGLNLLNDIOE PPFCCOKCHJK();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KGLNLLNDIOE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ABLLAPEADEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMGAFKIDEEA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JOEBIEMNHCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MBNOAEEPOAI([In] T LOKLFHKEJPC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void JILIIBIDHAM<T>([In] T AGJNJFMNGDN);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct GBPNBHEDCCM<T> : IEquatable<GBPNBHEDCCM<T>>, JOEBIEMNHCG<GBPNBHEDCCM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T HBDLGDLEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int GBFKBOHPEJM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4D74DC0", Offset = "0x4D73BC0", VA = "0x184D74DC0")]
	public GBPNBHEDCCM([In] T BNECONOIKOE, int CKFKPOAGPKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4D73D90", Offset = "0x4D72B90", VA = "0x184D73D90")]
	public static bool HAHIHKOBLPE([In] GBPNBHEDCCM<T> EIECDDIBOHA, [In] GBPNBHEDCCM<T> AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4D73780", Offset = "0x4D72580", VA = "0x184D73780", Slot = "4")]
	public bool Equals(GBPNBHEDCCM<T> LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x483A5B0", Offset = "0x48393B0", VA = "0x18483A5B0", Slot = "0")]
	public override bool Equals(object LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4D743C0", Offset = "0x4D731C0", VA = "0x184D743C0")]
	public bool MBNOAEEPOAI([In] GBPNBHEDCCM<T> LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4D73AB0", Offset = "0x4D728B0", VA = "0x184D73AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4D74AF0", Offset = "0x4D738F0", VA = "0x184D74AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4D72D90", Offset = "0x4D71B90", VA = "0x184D72D90")]
	public void DNJKCOADEJJ([Out] T BNECONOIKOE, [Out] int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4D734B0", Offset = "0x4D722B0", VA = "0x184D734B0")]
	public (T, int) EGDIBHINHGG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D74370", Offset = "0x4D73170", VA = "0x184D74370", Slot = "5")]
	private bool LLLIPLDJPGP([In] GBPNBHEDCCM<T> LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MEIMHCAKIHL
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6FD70", Offset = "0x3C6EB70", VA = "0x183C6FD70")]
	public static GBPNBHEDCCM<T> OGAKBGHEIKK<T>([In] T BNECONOIKOE, int CKFKPOAGPKN) where T : notnull
	{
		return default(GBPNBHEDCCM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PIMEIMIEJAF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D64400", Offset = "0x3D63200", VA = "0x183D64400")]
	public static bool MBNOAEEPOAI<T, U>([In] T FEOFEEGOGIO, [In] U MKPNGAKJFMP) where T : notnull, JOEBIEMNHCG<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult KKDLBMGLLEE<T, out TResult>([In] T AGJNJFMNGDN);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DPCDAKDFNGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan MJNAHIAMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? LOJGHBMIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCBLGFMJHPB();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGDLOOIJJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLFOOBGGHHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct AOMNGHJFFHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly GHNDKKEMJDH MLPPLJBONKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly LPDMMNIOJOA EAPDDBDAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly GHNDKKEMJDH KKGHBPOELNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly LPDMMNIOJOA DMMFHBEDAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly GHNDKKEMJDH NNMBFDJHLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly LPDMMNIOJOA MJDBMMGMMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly IEKGFKKIJEJ MDEJFHGKHCP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly GHNDKKEMJDH AFBBBPICIKP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly LPDMMNIOJOA EFEEHFDHKBA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly GHNDKKEMJDH LNLELFCLANL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LPDMMNIOJOA LJPBCDGHIII;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly GHNDKKEMJDH GJDHGIIEIOM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly LPDMMNIOJOA CAJHDEAJMCD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly IEKGFKKIJEJ KFILEMGMFGG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly AOMNGHJFFHH MMHNBCKELFI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly GHNDKKEMJDH MPGFKFPBBIJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8214CA0", Offset = "0x8213AA0", VA = "0x188214CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE872A0", Offset = "0xE860A0", VA = "0x180E872A0")]
	public AOMNGHJFFHH(GHNDKKEMJDH OAPNPBDBEBE, LPDMMNIOJOA PIECNNCEKLF, GHNDKKEMJDH MNECBHFEGDA, LPDMMNIOJOA ADAHKKBGBPH, GHNDKKEMJDH ANPJHCAGOHA, LPDMMNIOJOA LLNABKEEIPP, IEKGFKKIJEJ PCABANHDAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	private static bool MNONHIAKEOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void CIBJEJOHPPN(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	private static bool IDOPLMKGOFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void BAGADCKPJLD(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
	private static bool KOFEOCCFIKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void IHEEFAGCAKI(string IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void AKEOACAIIBG(Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8214AF0", Offset = "0x82138F0", VA = "0x188214AF0")]
	private static AOMNGHJFFHH JOBCJJPNBBG()
	{
		return default(AOMNGHJFFHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
	private static bool ADCCCHCBHJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8214EA0", Offset = "0x8213CA0", VA = "0x188214EA0")]
	public void OJKKHHLLEBA(object IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8214C30", Offset = "0x8213A30", VA = "0x188214C30")]
	public void MNDFPDLODBI(object IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82148D0", Offset = "0x82136D0", VA = "0x1882148D0")]
	public void JBNCFEFNHCM(object IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE83D00", Offset = "0xE82B00", VA = "0x180E83D00")]
	public void DEPKPMLPLID(Exception KHPHCONHPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8214940", Offset = "0x8213740", VA = "0x188214940")]
	public void JBNCFEFNHCM(PLBGNEAGMPE IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x31213B0", Offset = "0x31201B0", VA = "0x1831213B0")]
	public void JBNCFEFNHCM<T>(T AGJNJFMNGDN, PKIEPKHJHIB<T> IIHOFBLPONF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x31216C0", Offset = "0x31204C0", VA = "0x1831216C0")]
	public void OJKKHHLLEBA<T>([In] T AGJNJFMNGDN, EHLAFINEOGM<T> IIHOFBLPONF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3121480", Offset = "0x3120280", VA = "0x183121480")]
	public void JBNCFEFNHCM<T>([In] T AGJNJFMNGDN, EHLAFINEOGM<T> IIHOFBLPONF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8214A20", Offset = "0x8213820", VA = "0x188214A20")]
	public bool JLCEAKHEPPG(bool LPCLMFMENJN, string IIHOFBLPONF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MBIMFGCNGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string HBDLGDLEPJD;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7E0", Offset = "0xE3A5E0", VA = "0x180E3B7E0")]
	public MBIMFGCNGCE(string BNECONOIKOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
	public static string JGGBAIGHKJA([In] MBIMFGCNGCE FEOFEEGOGIO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x13D4570", Offset = "0x13D3370", VA = "0x1813D4570")]
	public static MBIMFGCNGCE JGGBAIGHKJA(string LOKLFHKEJPC)
	{
		return default(MBIMFGCNGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x821E190", Offset = "0x821CF90", VA = "0x18821E190")]
	public string LBAOMACOOFK(string OEOEEGFEKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x821E1E0", Offset = "0x821CFE0", VA = "0x18821E1E0")]
	public string MPFHIGLLIAF(object DGMJKJCCJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class JBMEBHAPLMM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public JBMEBHAPLMM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct CIEOHCAKAMM : IEquatable<CIEOHCAKAMM>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "4")]
	public bool Equals(CIEOHCAKAMM LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8216220", Offset = "0x8215020", VA = "0x188216220", Slot = "0")]
	public override bool Equals(object LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8216270", Offset = "0x8215070", VA = "0x188216270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8216280", Offset = "0x8215080", VA = "0x188216280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KNICHPAKIIM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JDAJLJFAAGF<T> : IEquatable<JDAJLJFAAGF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T HBDLGDLEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool HIDADMJIOMO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PCPLHAMGIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x518F090", Offset = "0x518DE90", VA = "0x18518F090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x518F9E0", Offset = "0x518E7E0", VA = "0x18518F9E0")]
	public JDAJLJFAAGF([In] T BNECONOIKOE, bool KBBFFJLNHAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x518EFA0", Offset = "0x518DDA0", VA = "0x18518EFA0")]
	public static bool HAHIHKOBLPE([In] JDAJLJFAAGF<T> EIECDDIBOHA, [In] JDAJLJFAAGF<T> AFKLBECCDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x518DAC0", Offset = "0x518C8C0", VA = "0x18518DAC0", Slot = "4")]
	public bool Equals(JDAJLJFAAGF<T> LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x518D830", Offset = "0x518C630", VA = "0x18518D830", Slot = "0")]
	public override bool Equals(object? LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x518E570", Offset = "0x518D370", VA = "0x18518E570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x518F420", Offset = "0x518E220", VA = "0x18518F420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EKLBHMHFMBG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CFA0", Offset = "0x3A1BDA0", VA = "0x183A1CFA0")]
	public static JDAJLJFAAGF<T> LPPMALBDEEJ<T>([In] T BNECONOIKOE) where T : notnull
	{
		return default(JDAJLJFAAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CC50", Offset = "0x3A1BA50", VA = "0x183A1CC50")]
	public static JDAJLJFAAGF<T?> CBNMCCOIINL<T>()
	{
		return default(JDAJLJFAAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D170", Offset = "0x3A1BF70", VA = "0x183A1D170")]
	public static bool OBLPJNJJALC<T>([In] this JDAJLJFAAGF<T> GCMCMJIGJPK, [Out][NotNullWhen(true)] T BNECONOIKOE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D100", Offset = "0x3A1BF00", VA = "0x183A1D100")]
	public static bool OBLPJNJJALC<T>([In] this JDAJLJFAAGF<T> GCMCMJIGJPK, [Out][NotNullWhen(true)] T BNECONOIKOE, [Out] JDAJLJFAAGF<T> KLLHEIFPGBC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D0A0", Offset = "0x3A1BEA0", VA = "0x183A1D0A0")]
	public static T? NJPFCDGNAKF<T>([In] this JDAJLJFAAGF<T> GCMCMJIGJPK, T? JILABBLHNAO)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A1CDA0", Offset = "0x3A1BBA0", VA = "0x183A1CDA0")]
	public static bool EHABBGGDGNK<T>([In] this JDAJLJFAAGF<T> GCMCMJIGJPK, T BNECONOIKOE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HALNJJKNMOO
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B99010", Offset = "0x3B97E10", VA = "0x183B99010")]
	public static T FBNPECKOHAN<T>([In] this JDAJLJFAAGF<T> GCMCMJIGJPK) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KJPPOMMCDJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr JMENDEMKJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr INDBGHKAAFI;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr DFAILGDDHLO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr LIPAOPKHLJK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly KJPPOMMCDJI MMHNBCKELFI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NPDDCPKLJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x821DAD0", Offset = "0x821C8D0", VA = "0x18821DAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	public KJPPOMMCDJI(IntPtr NGMBGIKBACL, IntPtr GDBNKPNPKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void CDBCMKHEMME(string GGDFKFACHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	private static void IPOMBKPOHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x821DA40", Offset = "0x821C840", VA = "0x18821DA40")]
	private static KJPPOMMCDJI JOBCJJPNBBG()
	{
		return default(KJPPOMMCDJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct EPDNKPDHCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr INHPCCPIMOJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
	private EPDNKPDHCCJ(IntPtr GDBNKPNPKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x821A340", Offset = "0x8219140", VA = "0x18821A340")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x821A350", Offset = "0x8219150", VA = "0x18821A350")]
	public static EPDNKPDHCCJ OGAKBGHEIKK(string GGDFKFACHGG)
	{
		return default(EPDNKPDHCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29C25A0", Offset = "0x29C13A0", VA = "0x1829C25A0")]
	public static EPDNKPDHCCJ OGAKBGHEIKK([In] KJPPOMMCDJI BCMDOHOMHOM, string GGDFKFACHGG)
	{
		return default(EPDNKPDHCCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x29C25D0", Offset = "0x29C13D0", VA = "0x1829C25D0")]
	public static EPDNKPDHCCJ OGAKBGHEIKK([In] KJPPOMMCDJI BCMDOHOMHOM, Func<string> GGDFKFACHGG)
	{
		return default(EPDNKPDHCCJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NNMOLJBHBML : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? DGECMBFAKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr FKDIJNFPOEF;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LINEEFDKBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x821F860", Offset = "0x821E660", VA = "0x18821F860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x821F7E0", Offset = "0x821E5E0", VA = "0x18821F7E0")]
	public static SHA256 LDFHHMLGJNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x821F420", Offset = "0x821E220", VA = "0x18821F420")]
	private static extern int HDOHOMKHGAB();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x821F950", Offset = "0x821E750", VA = "0x18821F950")]
	private static extern IntPtr LKEPBAHBNNH();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x821F310", Offset = "0x821E110", VA = "0x18821F310")]
	private static extern void AGLIKPKLAIO(IntPtr FKDIJNFPOEF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x821F9C0", Offset = "0x821E7C0", VA = "0x18821F9C0")]
	private static extern void MLNBPCOJLEL(IntPtr FKDIJNFPOEF, byte[] BOIPFNOKGBJ, int DOBKAGHAEBK, int GMOJBJEHAFF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x821F740", Offset = "0x821E540", VA = "0x18821F740")]
	private static extern void JPBHFHAGNJO(IntPtr FKDIJNFPOEF, byte[] FLBMDPBCBDL);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x821FA80", Offset = "0x821E880", VA = "0x18821FA80")]
	private NNMOLJBHBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x821F490", Offset = "0x821E290", VA = "0x18821F490", Slot = "18")]
	protected override void HashCore(byte[] COPOPHFGNFG, int GMFAFJMOKLE, int IGMJEFOMAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x821F550", Offset = "0x821E350", VA = "0x18821F550", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x821F680", Offset = "0x821E480", VA = "0x18821F680", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x821F390", Offset = "0x821E190", VA = "0x18821F390", Slot = "13")]
	protected override void Dispose(bool DLBGJLLIBEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DCLHEGLDCKI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool GFIJAKHGHNM<in TInput, TResult>(TInput PADDIEKMDDH, [Out] TResult OHLBIIOAJDL);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class LCNOBMMMEHJ : BPLLAOKLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class ALCOCGLFBGM : KGLNLLNDIOE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly ALCOCGLFBGM ODAOEPEFKDK;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool ABLLAPEADEI
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x8214690", Offset = "0x8213490", VA = "0x188214690", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x82146F0", Offset = "0x82134F0", VA = "0x1882146F0", Slot = "6")]
			public void OnCompleted(Action EBNDANPFIPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			public void EMGAFKIDEEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public ALCOCGLFBGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly LCNOBMMMEHJ ODAOEPEFKDK;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		private LCNOBMMMEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x821DF40", Offset = "0x821CD40", VA = "0x18821DF40", Slot = "4")]
		public KGLNLLNDIOE PPFCCOKCHJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class OPJEDGOJNGL : BPLLAOKLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class BDODNPAADDK : KGLNLLNDIOE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly BDODNPAADDK ODAOEPEFKDK;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool ABLLAPEADEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8215A90", Offset = "0x8214890", VA = "0x188215A90", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8215AB0", Offset = "0x82148B0", VA = "0x188215AB0", Slot = "6")]
			public void OnCompleted(Action EBNDANPFIPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			public void EMGAFKIDEEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public BDODNPAADDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly OPJEDGOJNGL ODAOEPEFKDK;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		private OPJEDGOJNGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8220490", Offset = "0x821F290", VA = "0x188220490", Slot = "4")]
		public KGLNLLNDIOE PPFCCOKCHJK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HICDBMFPIEJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HICDBMFPIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4E23800", Offset = "0x4E22600", VA = "0x184E23800")]
		internal void BIHGPEMKHBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KGMKMPIOCKP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KGMKMPIOCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x51A6CD0", Offset = "0x51A5AD0", VA = "0x1851A6CD0")]
		internal void DEFNFGNLEND(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JEDJFPECMPP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x821D000", Offset = "0x821BE00", VA = "0x18821D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MDFMKEELGCH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x821E2C0", Offset = "0x821D0C0", VA = "0x18821E2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CIIHBCJBKKH<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x67E6E40", Offset = "0x67E5C40", VA = "0x1867E6E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67E6FB0", Offset = "0x67E5DB0", VA = "0x1867E6FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct KBOPEBJCHJD<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x52A3930", Offset = "0x52A2730", VA = "0x1852A3930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x52A41A0", Offset = "0x52A2FA0", VA = "0x1852A41A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DBEDFOBFDBL : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8217C30", Offset = "0x8216A30", VA = "0x188217C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8217E40", Offset = "0x8216C40", VA = "0x188217E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JKACEIIAHEM<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JKACEIIAHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4E23800", Offset = "0x4E22600", VA = "0x184E23800")]
		internal void IBBJNONEMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x51ED380", Offset = "0x51EC180", VA = "0x1851ED380")]
		internal void JPJEGPEGCKP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct EFNFEGHPENB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public GFIJAKHGHNM<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4821E00", Offset = "0x4820C00", VA = "0x184821E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x48224F0", Offset = "0x48212F0", VA = "0x1848224F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FENFOJEFHPO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x821A430", Offset = "0x8219230", VA = "0x18821A430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x821AC20", Offset = "0x8219A20", VA = "0x18821AC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct APFBEFAPENI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x82154F0", Offset = "0x82142F0", VA = "0x1882154F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8215A30", Offset = "0x8214830", VA = "0x188215A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct KNHIPNAHOCG<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x52F0670", Offset = "0x52EF470", VA = "0x1852F0670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4E13D60", Offset = "0x4E12B60", VA = "0x184E13D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class EOGBKCMMDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<CIEOHCAKAMM> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EOGBKCMMDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x821A230", Offset = "0x8219030", VA = "0x18821A230")]
		internal void PLJIBIBBFOO(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct MMJIOFKCDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<Task> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x821E6F0", Offset = "0x821D4F0", VA = "0x18821E6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x821E970", Offset = "0x821D770", VA = "0x18821E970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KNMHOMBCALO<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x52F1280", Offset = "0x52F0080", VA = "0x1852F1280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x43925C0", Offset = "0x43913C0", VA = "0x1843925C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MEJPJIODBAL<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

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
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5658410", Offset = "0x5657210", VA = "0x185658410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4391670", Offset = "0x4390470", VA = "0x184391670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LMDNGKJNMBK<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x548C1D0", Offset = "0x548AFD0", VA = "0x18548C1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x548D0B0", Offset = "0x548BEB0", VA = "0x18548D0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JINFCFJLNNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x821D420", Offset = "0x821C220", VA = "0x18821D420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x821D600", Offset = "0x821C400", VA = "0x18821D600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct ICECPKIAOKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x821C0A0", Offset = "0x821AEA0", VA = "0x18821C0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x821C410", Offset = "0x821B210", VA = "0x18821C410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct CDLHMBPFJNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8215ED0", Offset = "0x8214CD0", VA = "0x188215ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x82161C0", Offset = "0x8214FC0", VA = "0x1882161C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HDNKOIJBMFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HDNKOIJBMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x821BC00", Offset = "0x821AA00", VA = "0x18821BC00")]
		internal Task HEMAIGJFLMB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct GNGDGCKDODA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x821B840", Offset = "0x821A640", VA = "0x18821B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x821BAA0", Offset = "0x821A8A0", VA = "0x18821BAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct KDEHDGLKFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x821D660", Offset = "0x821C460", VA = "0x18821D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x821D840", Offset = "0x821C640", VA = "0x18821D840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct HHEBCIEFPPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x821BC70", Offset = "0x821AA70", VA = "0x18821BC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x821BFD0", Offset = "0x821ADD0", VA = "0x18821BFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct BEJAFKENHGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8215B80", Offset = "0x8214980", VA = "0x188215B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8215E70", Offset = "0x8214C70", VA = "0x188215E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JAFHIMPAFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JAFHIMPAFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x821CF90", Offset = "0x821BD90", VA = "0x18821CF90")]
		internal Task LJOALACJKNN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct JHCLOMELCAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x821D160", Offset = "0x821BF60", VA = "0x18821D160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x821D3C0", Offset = "0x821C1C0", VA = "0x18821D3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct NFLKEDEDOKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x821E9E0", Offset = "0x821D7E0", VA = "0x18821E9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x821EB60", Offset = "0x821D960", VA = "0x18821EB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct PMDHMGFMJCK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x59CBFA0", Offset = "0x59CADA0", VA = "0x1859CBFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x59CC260", Offset = "0x59CB060", VA = "0x1859CC260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct GBAOAKFMDCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x821AC80", Offset = "0x8219A80", VA = "0x18821AC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x821AFB0", Offset = "0x8219DB0", VA = "0x18821AFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? BDOEADBLFAC;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<CIEOHCAKAMM> NFIMHDGNBCI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task OOBNPIDGEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8218DB0", Offset = "0x8217BB0", VA = "0x188218DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8218D80", Offset = "0x8217B80", VA = "0x188218D80")]
	public static bool FLFMGMBLGJP(this Task JNOGJECEFDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x39E01F0", Offset = "0x39DEFF0", VA = "0x1839E01F0")]
	public static Task<T> EDJGLMLNABI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8218240", Offset = "0x8217040", VA = "0x188218240")]
	public static Task AILHONKBFKH(this Task JNOGJECEFDN, CancellationToken OCGDLEBGIMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39DEBF0", Offset = "0x39DD9F0", VA = "0x1839DEBF0")]
	public static Task<TResult> AILHONKBFKH<TResult>(this Task<TResult> JNOGJECEFDN, CancellationToken OCGDLEBGIMO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x39DD380", Offset = "0x39DC180", VA = "0x1839DD380")]
	public static TaskCompletionSource<TResult> AILHONKBFKH<TResult>(this TaskCompletionSource<TResult> HLJEBJIJODM, CancellationToken OCGDLEBGIMO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8219600", Offset = "0x8218400", VA = "0x188219600")]
	public static IDisposable? HFBIJEHNLJP(CancellationToken KBBNGJPCABH, CancellationToken BDHMPGCIPOE, [Out] CancellationToken EIFCENFKJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8218F50", Offset = "0x8217D50", VA = "0x188218F50")]
	[AsyncStateMachine(typeof(JEDJFPECMPP))]
	public static void GMKCBIBAOPH(this Task ODOKMLFIJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8219790", Offset = "0x8218590", VA = "0x188219790")]
	[AsyncStateMachine(typeof(MDFMKEELGCH))]
	public static void IOMKCKLDGBD(this Task ODOKMLFIJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39E0340", Offset = "0x39DF140", VA = "0x1839E0340")]
	[AsyncStateMachine(typeof(CIIHBCJBKKH<>))]
	public static Task ENNLKEMCKOB<TException>(this Task ODOKMLFIJNG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x39E05F0", Offset = "0x39DF3F0", VA = "0x1839E05F0")]
	[AsyncStateMachine(typeof(KBOPEBJCHJD<>))]
	public static Task<T> HHDJAHFMICO<T>(this Task<T> FEOFEEGOGIO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8219EE0", Offset = "0x8218CE0", VA = "0x188219EE0")]
	[AsyncStateMachine(typeof(DBEDFOBFDBL))]
	public static Task<TaskStatus> MBDJKKGCDBJ(this Task? FEOFEEGOGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39E0DF0", Offset = "0x39DFBF0", VA = "0x1839E0DF0")]
	public static (Task<T?>?, Action<T?>?) MMPNCLEAEHM<T>([Optional] CancellationToken HIMDFBHMPLL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x39DBCC0", Offset = "0x39DAAC0", VA = "0x1839DBCC0")]
	[AsyncStateMachine(typeof(EFNFEGHPENB<, >))]
	public static Task<List<TResult>> ADINFBPDJGP<TResult, TInput>(this Task<List<TInput>> JNOGJECEFDN, GFIJAKHGHNM<TInput, TResult> JEALHPEOFFJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8218E20", Offset = "0x8217C20", VA = "0x188218E20")]
	[AsyncStateMachine(typeof(FENFOJEFHPO))]
	public static Task GGDABEOIPIH(Task ODOKMLFIJNG, CancellationToken FOJIDEIIGFD, Func<CancellationToken, Task> JBNPBNEPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8219C90", Offset = "0x8218A90", VA = "0x188219C90")]
	[AsyncStateMachine(typeof(APFBEFAPENI))]
	public static Task KIJNCIGKHLD(Func<CancellationToken, Task> MHGAFFIJAJC, TimeSpan DKEAKDFFACG, [Optional] CancellationToken FOJIDEIIGFD, [Optional] Action<OperationCanceledException>? FFEELEMANMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x39E0B90", Offset = "0x39DF990", VA = "0x1839E0B90")]
	[AsyncStateMachine(typeof(KNHIPNAHOCG<>))]
	public static Task<T> KIJNCIGKHLD<T>(Func<CancellationToken, Task<T>> MHGAFFIJAJC, TimeSpan DKEAKDFFACG, [Optional] CancellationToken FOJIDEIIGFD, [Optional] Func<OperationCanceledException, T>? FFEELEMANMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82195B0", Offset = "0x82183B0", VA = "0x1882195B0")]
	public static Task HFANDDAIKOC(params Task[] OODPKPICLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x82190F0", Offset = "0x8217EF0", VA = "0x1882190F0")]
	public static Task HFANDDAIKOC(IEnumerable<Task> OODPKPICLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x821A020", Offset = "0x8218E20", VA = "0x18821A020")]
	[AsyncStateMachine(typeof(MMJIOFKCDJP))]
	public static Task<IEnumerable<Task>> NBCGFBGFHGF(IEnumerable<Task> OODPKPICLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39E1110", Offset = "0x39DFF10", VA = "0x1839E1110")]
	[AsyncStateMachine(typeof(KNMHOMBCALO<>))]
	public static Task<IEnumerable<Task<T>>> NBCGFBGFHGF<T>(IEnumerable<Task<T>> OODPKPICLBC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x39E0A70", Offset = "0x39DF870", VA = "0x1839E0A70")]
	[AsyncStateMachine(typeof(MEJPJIODBAL<, , >))]
	public static Task<(T1, T2, T3)> JIAKFMLHEDE<T1, T2, T3>(Task<T1> KHCECCGAAKK, Task<T2> MFEIEDPMJNF, Task<T3> NDHAOFFNIIF) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x39E07B0", Offset = "0x39DF5B0", VA = "0x1839E07B0")]
	[AsyncStateMachine(typeof(LMDNGKJNMBK<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> JIAKFMLHEDE<T1, T2, T3, T4, T5>(Task<T1> KHCECCGAAKK, Task<T2> MFEIEDPMJNF, Task<T3> NDHAOFFNIIF, Task<T4> JFAGLLFJFLA, Task<T5> MFBCDDJAFNA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8218890", Offset = "0x8217690", VA = "0x188218890")]
	[AsyncStateMachine(typeof(JINFCFJLNNA))]
	public static Task COFIPKLFNCM(Func<bool> LPCLMFMENJN, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8218980", Offset = "0x8217780", VA = "0x188218980")]
	[AsyncStateMachine(typeof(ICECPKIAOKH))]
	public static Task COFIPKLFNCM(Func<bool> LPCLMFMENJN, TimeSpan LLAMGPCBACO, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8218BD0", Offset = "0x82179D0", VA = "0x188218BD0")]
	[AsyncStateMachine(typeof(CDLHMBPFJNN))]
	public static Task DBBJMLAHGIJ(Func<bool> LPCLMFMENJN, TimeSpan DKEAKDFFACG, [Optional] CancellationToken HIMDFBHMPLL, [Optional] Action<OperationCanceledException>? FFEELEMANMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8218A90", Offset = "0x8217890", VA = "0x188218A90")]
	[AsyncStateMachine(typeof(GNGDGCKDODA))]
	public static Task DBBJMLAHGIJ(Func<bool> LPCLMFMENJN, TimeSpan DKEAKDFFACG, TimeSpan LLAMGPCBACO, [Optional] CancellationToken HIMDFBHMPLL, [Optional] Action<OperationCanceledException>? FFEELEMANMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8218040", Offset = "0x8216E40", VA = "0x188218040")]
	[AsyncStateMachine(typeof(KDEHDGLKFHJ))]
	public static Task AFIMGIAIGEO(Func<bool> LPCLMFMENJN, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8218130", Offset = "0x8216F30", VA = "0x188218130")]
	[AsyncStateMachine(typeof(HHEBCIEFPPN))]
	public static Task AFIMGIAIGEO(Func<bool> LPCLMFMENJN, TimeSpan LLAMGPCBACO, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8218760", Offset = "0x8217560", VA = "0x188218760")]
	[AsyncStateMachine(typeof(BEJAFKENHGA))]
	public static Task CNEDKHMAKOF(Func<bool> LPCLMFMENJN, TimeSpan DKEAKDFFACG, [Optional] CancellationToken HIMDFBHMPLL, [Optional] Action<OperationCanceledException>? FFEELEMANMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8218620", Offset = "0x8217420", VA = "0x188218620")]
	[AsyncStateMachine(typeof(JHCLOMELCAM))]
	public static Task CNEDKHMAKOF(Func<bool> LPCLMFMENJN, TimeSpan DKEAKDFFACG, TimeSpan LLAMGPCBACO, [Optional] CancellationToken HIMDFBHMPLL, [Optional] Action<OperationCanceledException>? FFEELEMANMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8219000", Offset = "0x8217E00", VA = "0x188219000")]
	[Obsolete]
	[AsyncStateMachine(typeof(NFLKEDEDOKK))]
	public static Task HEMANGGDIHA(this Task JNOGJECEFDN, Action GIIELEDEJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x39E0410", Offset = "0x39DF210", VA = "0x1839E0410")]
	[AsyncStateMachine(typeof(PMDHMGFMJCK<>))]
	[Obsolete]
	public static Task HEMANGGDIHA<T>(this Task<T> JNOGJECEFDN, Action<T> GIIELEDEJPD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x82184A0", Offset = "0x82172A0", VA = "0x1882184A0")]
	private static void BKLCHFLDCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8219910", Offset = "0x8218710", VA = "0x188219910")]
	public static bool KFIEGMHPEOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8217EB0", Offset = "0x8216CB0", VA = "0x188217EB0")]
	private static void AAILGFGAJND(SynchronizationContext BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8219DC0", Offset = "0x8218BC0", VA = "0x188219DC0")]
	private static void KOEPKMOOKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8219840", Offset = "0x8218640", VA = "0x188219840")]
	public static void KCOJCKFKKPC([Optional] string? IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8218D00", Offset = "0x8217B00", VA = "0x188218D00")]
	public static void DEGFNLDAFGP([Optional] string? IIHOFBLPONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x821A120", Offset = "0x8218F20", VA = "0x18821A120")]
	public static BPLLAOKLPCO OOHFCBOKLCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8219FD0", Offset = "0x8218DD0", VA = "0x188219FD0")]
	public static BPLLAOKLPCO MGLCCOBOLJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8218550", Offset = "0x8217350", VA = "0x188218550")]
	[AsyncStateMachine(typeof(GBAOAKFMDCG))]
	public static Task CIGLMJHKJBF(Func<Task> FAMNJGOAPBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HCBEFNLCJPF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public HCBEFNLCJPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LABIICNOALO
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x821DE20", Offset = "0x821CC20", VA = "0x18821DE20")]
	public static bool PDKBJNACOBI(this JANNOHPBADH JPAGPHDNPLD, DateTime JLKIGFBAMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x821DD00", Offset = "0x821CB00", VA = "0x18821DD00")]
	public static TimeSpan DLACBBHJJCL(this JANNOHPBADH JPAGPHDNPLD, DateTime JLKIGFBAMKK)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OHNFLBKMCBP : JANNOHPBADH
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly JANNOHPBADH ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime HNDGJNNILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8220370", Offset = "0x821F170", VA = "0x188220370", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset FFHOHHINNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x82203B0", Offset = "0x821F1B0", VA = "0x1882203B0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public OHNFLBKMCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface JANNOHPBADH
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime HNDGJNNILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset FFHOHHINNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class GIBEJHHFGGF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long HCBJGFKBFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x821B020", Offset = "0x8219E20", VA = "0x18821B020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long IOHCIOHJILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x821B520", Offset = "0x821A320", VA = "0x18821B520")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double DKIJLAKGFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x821B100", Offset = "0x8219F00", VA = "0x18821B100")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double BFNAOAPOMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x821B360", Offset = "0x821A160", VA = "0x18821B360")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double IEOFMEKPBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x821B3B0", Offset = "0x821A1B0", VA = "0x18821B3B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double IDGNPANLGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x821B310", Offset = "0x821A110", VA = "0x18821B310")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x821B150", Offset = "0x8219F50", VA = "0x18821B150")]
	public static double EECGJCPJKBA(long PEINLDCNDGN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x821B400", Offset = "0x821A200", VA = "0x18821B400")]
	public static double LCFKEGDFDPN(long PEINLDCNDGN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x821B490", Offset = "0x821A290", VA = "0x18821B490")]
	public static double NDNNOIFIJDD(double HKMEBDLJNJH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x821B070", Offset = "0x8219E70", VA = "0x18821B070")]
	public static long BIIMKHGECDI(long JMOMPNOKIIJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x821B010", Offset = "0x8219E10", VA = "0x18821B010")]
	public static long AENAFPFJNCH(long HHPHOLLIBAG, long OMLCNIEPALG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x821B1E0", Offset = "0x8219FE0", VA = "0x18821B1E0")]
	public static double EHAKGNPMFKD(long HHPHOLLIBAG, long OMLCNIEPALG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x821B2B0", Offset = "0x821A0B0", VA = "0x18821B2B0")]
	public static double EPLFNDLPALO(long HHPHOLLIBAG, long OMLCNIEPALG)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class NKOGEEBPOOI : DPCDAKDFNGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly TimeSpan JABMEFLGPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly System.Timers.Timer INANPMNJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private TimeSpan DKEAKDFFACG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan MJNAHIAMOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x821ECF0", Offset = "0x821DAF0", VA = "0x18821ECF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? LOJGHBMIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x821F000", Offset = "0x821DE00", VA = "0x18821F000")]
	[Preserve]
	public NKOGEEBPOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x821F070", Offset = "0x821DE70", VA = "0x18821F070")]
	public NKOGEEBPOOI(TimeSpan DKEAKDFFACG, [Optional] Action? GOMOLFIFLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x821EBC0", Offset = "0x821D9C0", VA = "0x18821EBC0", Slot = "7")]
	public void BCBLGFMJHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x821EF20", Offset = "0x821DD20", VA = "0x18821EF20", Slot = "8")]
	public void NGDLOOIJJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x821EEF0", Offset = "0x821DCF0", VA = "0x18821EEF0", Slot = "9")]
	public void FLFOOBGGHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x128D320", Offset = "0x128C120", VA = "0x18128D320")]
	private void OHPBEMCNDGA(object FCNMCCJKGMG, ElapsedEventArgs DPGONNKCNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x821EC50", Offset = "0x821DA50", VA = "0x18821EC50")]
	private static void CHPAFEJMLHA(TimeSpan BANGGPAIHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x821EE50", Offset = "0x821DC50", VA = "0x18821EE50", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class KNICHPAKIIM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly string? IFKGNKKGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string CPNIMADMGHF;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x18AC850", Offset = "0x18AB650", VA = "0x1818AC850")]
	public KNICHPAKIIM(string BKPMFKNMLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x51847C0", Offset = "0x51835C0", VA = "0x1851847C0")]
	public KNICHPAKIIM(string PEGIKAFHCAA, string BKPMFKNMLEK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct PDLHEEOINJI : IEquatable<PDLHEEOINJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public uint PDNOCPHILIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public int BHPGFNIJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float FGCGBPMNODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public ushort IGEAHDMNMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public ushort JKMINNFMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public short BIPAMHNKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public short MLICECLPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public char LJBJHPLKFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public char DMONFPGKCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte IADCDPOAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte OBKEFPALPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte DIALJBBNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte JHKAHKGLPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool DGNHPJLMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool ONNOLJEFBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool BODKMAHAOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool IMICGBOONAN;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098510", VA = "0x182099710")]
	public static PDLHEEOINJI JNGMKEEDAPM(uint DGFCODFGFHP)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098510", VA = "0x182099710")]
	public static PDLHEEOINJI EJPHIENJFOD(int DAEDDCCGGIA)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8220610", Offset = "0x821F410", VA = "0x188220610")]
	public static PDLHEEOINJI LGHJCJLEMLL(float FGBIDJAOECG)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8220560", Offset = "0x821F360", VA = "0x188220560")]
	public static PDLHEEOINJI HCLEPPDOALB(byte LMNCOAFMGHE, byte GCOGIDNCCOB, byte DHBFLHJIAEH, byte JFLGNIFCHLK)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8220560", Offset = "0x821F360", VA = "0x188220560")]
	public static PDLHEEOINJI MMFANIONLDC(bool ECNMJEKELDK, bool KOPBAEJKJJG, bool OCGHELIJKHP, bool OKBDHAJGPAC)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8220560", Offset = "0x821F360", VA = "0x188220560")]
	public static PDLHEEOINJI DKKODAICKAD(byte BFNLNCBAHCM, byte BLOEJOPGBDC, byte BEBFODJGCNF, byte OHPPPNDLBBI)
	{
		return default(PDLHEEOINJI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x23CA4F0", Offset = "0x23C92F0", VA = "0x1823CA4F0")]
	public static bool HAHIHKOBLPE(PDLHEEOINJI PHLJLBDJNIE, PDLHEEOINJI GEOHFJAPCHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x23CA4D0", Offset = "0x23C92D0", VA = "0x1823CA4D0", Slot = "4")]
	public bool Equals(PDLHEEOINJI LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8220580", Offset = "0x821F380", VA = "0x188220580", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x14F1F20", Offset = "0x14F0D20", VA = "0x1814F1F20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8220620", Offset = "0x821F420", VA = "0x188220620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NLHCFGAKOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public ulong JPJMHJFCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public long HJCCDOMPKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public double MIGOMIGPGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public uint PJCOAFMOIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public uint FBJODCDDAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int CJIMDLLPFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public int CKEAJFOJNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public float CJDGCHJNLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float MAFBENGOPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public ushort IGEAHDMNMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public ushort JKMINNFMNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public ushort GECGLEGCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public ushort FJNMDEDHBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public short BIPAMHNKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public short MLICECLPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public short CEOCHAMBALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public short JKNDFCMEHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public char LJBJHPLKFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public char DMONFPGKCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public char BOKNHANKBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public char GKEELLOEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte IADCDPOAPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte OBKEFPALPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte DIALJBBNPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public byte JHKAHKGLPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public byte OPEFFAIBAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public byte HDEJOPJACOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public byte LMAIDIBNGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte LMKMBOIMKCL;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static NLHCFGAKOPJ OGAKBGHEIKK(long BKEDFOGAPGK)
	{
		return default(NLHCFGAKOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x821F2C0", Offset = "0x821E0C0", VA = "0x18821F2C0")]
	public static NLHCFGAKOPJ OGAKBGHEIKK(byte LMNCOAFMGHE, byte GCOGIDNCCOB, byte DHBFLHJIAEH, byte JFLGNIFCHLK, byte GJALFGNMMKH, byte LPKJLCMGPON, byte FPNGAOCFBCK, byte HKAALKCKLII)
	{
		return default(NLHCFGAKOPJ);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct MIFJNNFMFJF : IEquatable<MIFJNNFMFJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte AJBMJMJHCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool IPKDINCPMOI;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x30CD020", Offset = "0x30CBE20", VA = "0x1830CD020")]
	public static MIFJNNFMFJF HCLEPPDOALB(byte NPJOJANPOAM)
	{
		return default(MIFJNNFMFJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x30CD020", Offset = "0x30CBE20", VA = "0x1830CD020")]
	public static MIFJNNFMFJF MMFANIONLDC(bool FENAADFCEIG)
	{
		return default(MIFJNNFMFJF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x821E470", Offset = "0x821D270", VA = "0x18821E470")]
	public static bool HAHIHKOBLPE(MIFJNNFMFJF PHLJLBDJNIE, MIFJNNFMFJF GEOHFJAPCHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x71030F0", Offset = "0x7101EF0", VA = "0x1871030F0", Slot = "4")]
	public bool Equals(MIFJNNFMFJF LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x821E3D0", Offset = "0x821D1D0", VA = "0x18821E3D0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x821E460", Offset = "0x821D260", VA = "0x18821E460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x821E480", Offset = "0x821D280", VA = "0x18821E480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class KJPDEACKLBI<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public readonly T PKOIEBEMJBB;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x52E28B0", Offset = "0x52E16B0", VA = "0x1852E28B0")]
	public KJPDEACKLBI(T BIFIGGPKGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class IAPBINHMBJI
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3B9EE00", Offset = "0x3B9DC00", VA = "0x183B9EE00")]
	public static IEnumerable<T> FCHKGCDJBDG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static T[] LGNNHELNGGF<T>(params T[] GCBEDJLCPOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static IEnumerable<T> DOFJPKNMFIL<T>(params T[] GCBEDJLCPOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static HashSet<T> NLONKDPAPNE<T>(params T[] GCBEDJLCPOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBE3B0", Offset = "0x3BBD1B0", VA = "0x183BBE3B0")]
	public static KeyValuePair<TKey, TValue> FDOOBCFPPME<TKey, TValue>([In] TKey MAHBBBBCDEL, [In] TValue BNECONOIKOE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3122F60", Offset = "0x3121D60", VA = "0x183122F60")]
	public static List<T> NBIFFDBDHEJ<T>(IEnumerable<T> HPGGKMKJGLJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[AttributeUsage(AttributeTargets.All)]
public sealed class NBCEEBPNPDP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public readonly string OGDOBJFDFNO;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
	public NBCEEBPNPDP(string BHIDIDEELPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object EHLAFINEOGM<T>([In] T ENDEOBGIMGA);
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object PKIEPKHJHIB<T>(T ENDEOBGIMGA);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[DKAMILHBBMM]
public delegate string HACPPOMLEKP(string JFJICNCOLKA, string? LMICOICMKNA, bool JNKEJOKJMGE);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DKAMILHBBMM]
public delegate void LPDMMNIOJOA(string IIHOFBLPONF);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DKAMILHBBMM]
public delegate void IEKGFKKIJEJ(Exception KHPHCONHPBN);
[Cpp2IlInjected.Token(Token = "0x200006C")]
public delegate object PLBGNEAGMPE();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DKAMILHBBMM]
public delegate bool GHNDKKEMJDH();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DKAMILHBBMM]
public delegate string IICAJINIGPF(object MKPNGAKJFMP);
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AttributeUsage(AttributeTargets.Enum)]
public class GMADHCBFPON : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public GMADHCBFPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class OACNBKBMCGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct CNGDDDOLGFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8216D10", Offset = "0x8215B10", VA = "0x188216D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8217600", Offset = "0x8216400", VA = "0x188217600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly TimerCallback MNLJCACDAGP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly Action<object?> HJHJDEKLBNF;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x821FCF0", Offset = "0x821EAF0", VA = "0x18821FCF0")]
	public static Task<bool> FONECLAOIMO(int KJHHMNBIEPG, [Optional] CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x821FB30", Offset = "0x821E930", VA = "0x18821FB30")]
	[AsyncStateMachine(typeof(CNGDDDOLGFF))]
	private static Task<bool> ENGEIGLOACB(int KJHHMNBIEPG, CancellationToken HIMDFBHMPLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8220000", Offset = "0x821EE00", VA = "0x188220000")]
	private static void HNMCHKEDKEP(object? EOMNODKHFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x821FC60", Offset = "0x821EA60", VA = "0x18821FC60")]
	private static void FLKONEKDGKP(object? EOMNODKHFBK)
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
