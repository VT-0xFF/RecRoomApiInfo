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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7617A00", Offset = "0x7616000", VA = "0x187617A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KMBHPGNHNEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7613160", Offset = "0x7611760", VA = "0x187613160")]
	public static string HAPGJAEFBKP(this Encoding CJALHABHKAP, [In] ReadOnlySequence<byte> HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34B7EC0", Offset = "0x34B64C0", VA = "0x1834B7EC0")]
	private static void KAANPLJDOJC<T>(this ReadOnlySequence<T> GGELOCEMMGP, [Out] ReadOnlySpan<T> LHILELKONHP, [Out] SequencePosition HBBIFNILMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GEOAIOEMOAL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76110F0", Offset = "0x760F6F0", VA = "0x1876110F0")]
	public GEOAIOEMOAL(bool LHMFCFEPKLH, string FIEMJMHICBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1744590", Offset = "0x1742B90", VA = "0x181744590")]
	public GEOAIOEMOAL(bool LHMFCFEPKLH, params string[] BDMAIBFBJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FBMOJJGCJED
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MIAKGHEFOPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CCOHJJBBHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECHCFOAMCCD(string LKMGECEEGEE, double KBGCCIOIGBD, [Optional] string? ECKFEMLGPFI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NABJBHIKGGL : HFBGIBFKDBH, BCBMKOENAEA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int JJMABHLKOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MOEBBMOAKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double CDIPILBCKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double HCEBABCAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double PHCHJJDCIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int GPBMJKCNOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double FBCJGGFFCFE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KPDFKMADLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96F660", Offset = "0x96DC60", VA = "0x18096F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KDMPCMCOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7614E70", Offset = "0x7613470", VA = "0x187614E70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OJIKABAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x62F5C80", Offset = "0x62F4280", VA = "0x1862F5C80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double EKLNFMGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2526660", Offset = "0x2524C60", VA = "0x182526660", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7614ED0", Offset = "0x76134D0", VA = "0x187614ED0")]
	public NABJBHIKGGL(int FDIMKIKLCLA, double FBCJGGFFCFE = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7614CD0", Offset = "0x76132D0", VA = "0x187614CD0", Slot = "7")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7614E00", Offset = "0x7613400", VA = "0x187614E00", Slot = "8")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7614BD0", Offset = "0x76131D0", VA = "0x187614BD0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OHDDHKMALPE : HFBGIBFKDBH, BCBMKOENAEA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long BBEJNKBNMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double EKKBACPHEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double PCPPDCDBOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double POCJAOGNENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double ANIGFIJPOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double CDIPILBCKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double HCEBABCAMLE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OJIKABAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x697B350", Offset = "0x6979950", VA = "0x18697B350", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EKLNFMGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x697B2D0", Offset = "0x69798D0", VA = "0x18697B2D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double EOIMGLHEIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x697B2F0", Offset = "0x69798F0", VA = "0x18697B2F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double KDMPCMCOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0D40", Offset = "0x2BBF340", VA = "0x182BC0D40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7617BC0", Offset = "0x76161C0", VA = "0x187617BC0", Slot = "10")]
	public virtual void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7617CE0", Offset = "0x76162E0", VA = "0x187617CE0", Slot = "11")]
	public virtual void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7617B50", Offset = "0x7616150", VA = "0x187617B50", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x760EA90", Offset = "0x760D090", VA = "0x18760EA90")]
	public OHDDHKMALPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BAAELKIPEIK : OHDDHKMALPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GKGHLFEHHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x697B300", Offset = "0x6979900", VA = "0x18697B300")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x697B340", Offset = "0x6979940", VA = "0x18697B340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x760E920", Offset = "0x760CF20", VA = "0x18760E920", Slot = "10")]
	public override void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x760EA50", Offset = "0x760D050", VA = "0x18760EA50", Slot = "11")]
	public override void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x760EA90", Offset = "0x760D090", VA = "0x18760EA90")]
	public BAAELKIPEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HFBGIBFKDBH : BCBMKOENAEA, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KDMPCMCOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OJIKABAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double EKLNFMGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GBKAAOMNBGK : BCBMKOENAEA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double EPFPJPNDGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double CBADLFPOMDA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7610E90", Offset = "0x760F490", VA = "0x187610E90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7574D80", Offset = "0x7573380", VA = "0x187574D80", Slot = "4")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7610EA0", Offset = "0x760F4A0", VA = "0x187610EA0", Slot = "5")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7610E40", Offset = "0x760F440", VA = "0x187610E40", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public GBKAAOMNBGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BCBMKOENAEA : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDNNJPAODIP(double DGOEGFOLJJL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLOHADBCHCL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GKFKOPHKBGM : BCBMKOENAEA, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double KBGCCIOIGBD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40E0400", Offset = "0x40DEA00", VA = "0x1840E0400")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E70330", Offset = "0x4E6E930", VA = "0x184E70330", Slot = "4")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76127B0", Offset = "0x7610DB0", VA = "0x1876127B0", Slot = "5")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7612760", Offset = "0x7610D60", VA = "0x187612760", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public GKFKOPHKBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CEHDFABDNPO<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> DECDMGDNJDH(CancellationToken LAEIHJHNGEK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PHBMBBMNNMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CEHDFABDNPO<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DECDMGDNJDH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x50E6B80", Offset = "0x50E5180", VA = "0x1850E6B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50E7BA0", Offset = "0x50E61A0", VA = "0x1850E7BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource PMAMMIAHALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? CDEMLDKDMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? ILOMOIICNIK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A73DD0", Offset = "0x5A723D0", VA = "0x185A73DD0")]
	[AsyncStateMachine(typeof(CEHDFABDNPO<>.PHBMBBMNNMN))]
	public Task<TResult> ILDMDIBEJPH(DECDMGDNJDH CMKCNDOGGAI, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5A73D60", Offset = "0x5A72360", VA = "0x185A73D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A73F10", Offset = "0x5A72510", VA = "0x185A73F10")]
	public CEHDFABDNPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DMCLNNLJALJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> AMBJOLLANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T DEDOPNLMLPL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEAEC0", Offset = "0x4EE94C0", VA = "0x184EEAEC0")]
	public DMCLNNLJALJ([In] T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63261F0", Offset = "0x63247F0", VA = "0x1863261F0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6326880", Offset = "0x6324E80", VA = "0x186326880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6326C80", Offset = "0x6325280", VA = "0x186326C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KAEEGFMAHCL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static DMCLNNLJALJ<T> FEOBEKOIKMG<T>([In] T KBGCCIOIGBD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DOJDLHPFICM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x760FE10", Offset = "0x760E410", VA = "0x18760FE10")]
	public static void LEEAEBLPONG(this CancellationTokenSource PMAMMIAHALH, bool BFNPHKELKBM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MHDIPJANLBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public MHDIPJANLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OPICOFBLENP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public OPICOFBLENP(string JMPINPHCODP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DLLCIKOIAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3253570", Offset = "0x3251B70", VA = "0x183253570")]
	public static NCNGPIKHHEM GBCDHBKADDG<T>()
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3253870", Offset = "0x3251E70", VA = "0x183253870")]
	public static NCNGPIKHHEM HJJENGABEAJ<T>([CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x32535F0", Offset = "0x3251BF0", VA = "0x1832535F0")]
	public static NCNGPIKHHEM GBCDHBKADDG<T>(this T MEBAFDHEDIN) where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3253910", Offset = "0x3251F10", VA = "0x183253910")]
	public static NCNGPIKHHEM KNCFMMMIFPF<T>(this T MEBAFDHEDIN, [CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32537C0", Offset = "0x3251DC0", VA = "0x1832537C0")]
	public static NCNGPIKHHEM HJJENGABEAJ<T>(this T JDCFMPOHCEA, [CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x760FD90", Offset = "0x760E390", VA = "0x18760FD90")]
	public static NCNGPIKHHEM HJJENGABEAJ(string CMLKDGJMHLH, [CallerMemberName] string OMOOEGOLALI = "")
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x760FCF0", Offset = "0x760E2F0", VA = "0x18760FCF0")]
	public static string FJAJAGDLKBG(this object JDCFMPOHCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool DPPOLMHPFJF();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[MHDIPJANLBG]
public delegate long BFPPOGOACKP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PANLJGHCEPE
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static ALCDHDCNBPA DDOLBLPNLCG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static ALCDHDCNBPA MPBDCGOLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7618D00", Offset = "0x7617300", VA = "0x187618D00")]
		get
		{
			return default(ALCDHDCNBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EDNEPNABDLO IFKFDBFKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76184B0", Offset = "0x7616AB0", VA = "0x1876184B0")]
		get
		{
			return default(EDNEPNABDLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KDEPHDNKEJC JILMJPLOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7618B00", Offset = "0x7617100", VA = "0x187618B00")]
		get
		{
			return default(KDEPHDNKEJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool KJKMOIKKMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x76187D0", Offset = "0x7616DD0", VA = "0x1876187D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7618B50", Offset = "0x7617150", VA = "0x187618B50")]
	public static void OMKOKAKLMBF([In] ALCDHDCNBPA HPALEHBJHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7618840", Offset = "0x7616E40", VA = "0x187618840")]
	public static void IEGNOINNOMJ(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7618910", Offset = "0x7616F10", VA = "0x187618910")]
	public static void IOEKNDJEAJM(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35FE630", Offset = "0x35FCC30", VA = "0x1835FE630")]
	public static void IOEKNDJEAJM<T>(T ICONKPKJBGN, APMNDCDCNFA<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76189E0", Offset = "0x7616FE0", VA = "0x1876189E0")]
	public static void JEPGDHGPBEC(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7618A80", Offset = "0x7617080", VA = "0x187618A80")]
	public static void JJOKHJDLJEK(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7618500", Offset = "0x7616B00", VA = "0x187618500")]
	public static void CGDGEOGJDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7618750", Offset = "0x7616D50", VA = "0x187618750")]
	public static string FJAJAGDLKBG(object GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7618610", Offset = "0x7616C10", VA = "0x187618610")]
	public static long EDPPHFIIKCE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7618570", Offset = "0x7616B70", VA = "0x187618570")]
	public static bool DKKAHALPLON(bool CMPFGFPGHEP, string MIALAMIFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7618680", Offset = "0x7616C80", VA = "0x187618680")]
	public static double FBLHKMPEKJP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct ALCDHDCNBPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EDNEPNABDLO IFKFDBFKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly KDEPHDNKEJC JILMJPLOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly LMOMDIPIOPD NPNLNMCOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly BFPPOGOACKP PKCJHMNFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly NEGFJHMBLHO IAPOHEKNLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly DPPOLMHPFJF IPJPBPFFGNO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LMOMDIPIOPD CKEJEAGBGGE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BFPPOGOACKP JDAPDKILADM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly NEGFJHMBLHO MNPFOJLEBIC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DPPOLMHPFJF HJKMGNEBJDF;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly ALCDHDCNBPA DGEEMDAPOEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x760DB00", Offset = "0x760C100", VA = "0x18760DB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x760E4E0", Offset = "0x760CAE0", VA = "0x18760E4E0")]
	public ALCDHDCNBPA([In] EDNEPNABDLO EFONOFNMJPL, [In] KDEPHDNKEJC IFMOEEEHJED, LMOMDIPIOPD AJBMAIDPDOE, BFPPOGOACKP KMIDMCJIBFA, NEGFJHMBLHO BLKKFBCCLBC, DPPOLMHPFJF ECMDPDAKAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x760DDB0", Offset = "0x760C3B0", VA = "0x18760DDB0")]
	private static string IDBEKDMKDNL(object GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70")]
	private static long JDCDHEFDJPF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	private static string PJHEMKINEBO(string GIFBANFPJGI, string? JKHHHFODJFE, bool FKELGECJBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
	private static bool LHJBBAOJBNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x760DCA0", Offset = "0x760C2A0", VA = "0x18760DCA0")]
	private static ALCDHDCNBPA HKBELKAOBLP()
	{
		return default(ALCDHDCNBPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface HEPMKLNOCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CECHPAPPEEE CHPBIIJHJCK();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CECHPAPPEEE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool INNLJOEIPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNMFNAONGFN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ONOAGGFEAEF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIDJNNPGPKA([In] T OKCHLIEAIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void FECBFMDKEAO<T>([In] T ICONKPKJBGN);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct KAJBFJJDEPL<T> : IEquatable<KAJBFJJDEPL<T>>, ONOAGGFEAEF<KAJBFJJDEPL<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T DEDOPNLMLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int MPMCCDHNNEC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4A93D90", Offset = "0x4A92390", VA = "0x184A93D90")]
	public KAJBFJJDEPL([In] T KBGCCIOIGBD, int EAHKFAJBNDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A91D40", Offset = "0x4A90340", VA = "0x184A91D40")]
	public static bool BFIJCNNIIMH([In] KAJBFJJDEPL<T> HJGDMEAJFEI, [In] KAJBFJJDEPL<T> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4699200", Offset = "0x4697800", VA = "0x184699200", Slot = "4")]
	public bool Equals(KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x462B580", Offset = "0x4629B80", VA = "0x18462B580", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A933E0", Offset = "0x4A919E0", VA = "0x184A933E0")]
	public bool OIDJNNPGPKA([In] KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A92A70", Offset = "0x4A91070", VA = "0x184A92A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A936C0", Offset = "0x4A91CC0", VA = "0x184A936C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A932F0", Offset = "0x4A918F0", VA = "0x184A932F0")]
	public void JNMBAPLKJHM([Out] T KBGCCIOIGBD, [Out] int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A92250", Offset = "0x4A90850", VA = "0x184A92250")]
	public (T, int) CAIBKNIPOOF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A93390", Offset = "0x4A91990", VA = "0x184A93390", Slot = "5")]
	private bool KJPKMMNFKKA([In] KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MLPOPJNGCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x351BF80", Offset = "0x351A580", VA = "0x18351BF80")]
	public static KAJBFJJDEPL<T> FEOBEKOIKMG<T>([In] T KBGCCIOIGBD, int EAHKFAJBNDN) where T : notnull
	{
		return default(KAJBFJJDEPL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CIPFKEACANI
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3208F80", Offset = "0x3207580", VA = "0x183208F80")]
	public static bool OIDJNNPGPKA<T, U>([In] T JDCFMPOHCEA, [In] U GMFKPONAANG) where T : notnull, ONOAGGFEAEF<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult EJMIMAGAOLC<T, out TResult>([In] T ICONKPKJBGN);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LHINIDECIGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan LPBFLHOFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? FMHJFKJNACC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKFPEOGCKKC();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAMALBDACEC();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDANFFCKCPP();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EDNEPNABDLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly MGIIFKFODJE DCNEDLLJOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly KLJKJDOOPMJ EDBCAKDJODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly MGIIFKFODJE ICMBPIAAMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KLJKJDOOPMJ LIJEHIMPPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MGIIFKFODJE LCDCFMOFCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly KLJKJDOOPMJ HELOECLFJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly NPBCNLHCOCI GNNCDIKGINF;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly MGIIFKFODJE AAJICIANCCC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly KLJKJDOOPMJ DDFGLKDJLEI;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly MGIIFKFODJE CMDBKNJADLN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly KLJKJDOOPMJ CIEHGGGBELO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MGIIFKFODJE LDJKHHFGELC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly KLJKJDOOPMJ DMMNNNIINOK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly NPBCNLHCOCI HHIGNJPACNM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EDNEPNABDLO DGEEMDAPOEK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly MGIIFKFODJE BOLIKMOOKNG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x760FE40", Offset = "0x760E440", VA = "0x18760FE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC05B80", Offset = "0xC04180", VA = "0x180C05B80")]
	public EDNEPNABDLO(MGIIFKFODJE LOPDEMPOGAC, KLJKJDOOPMJ ODNOJKENPIE, MGIIFKFODJE MEADDGPCCCM, KLJKJDOOPMJ HEGPGBEJDEF, MGIIFKFODJE ILMNDAIJAMH, KLJKJDOOPMJ OGGDBLIKAOK, NPBCNLHCOCI AMIECGOAOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
	private static bool DCHJODNINIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void EPIJBMLKJLL(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
	private static bool ALCFGEKJFEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void JMIEFEBMJIE(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0")]
	private static bool FJIKLKMOBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void IPJLEAOHPKG(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void NKAOCBJDKON(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7610110", Offset = "0x760E710", VA = "0x187610110")]
	private static EDNEPNABDLO HKBELKAOBLP()
	{
		return default(EDNEPNABDLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
	private static bool DGCNMOOPFKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7610250", Offset = "0x760E850", VA = "0x187610250")]
	public void IEGNOINNOMJ(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7610410", Offset = "0x760EA10", VA = "0x187610410")]
	public void KGGBDCBEFBB(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76103A0", Offset = "0x760E9A0", VA = "0x1876103A0")]
	public void IOEKNDJEAJM(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC05F30", Offset = "0xC04530", VA = "0x180C05F30")]
	public void JEPGDHGPBEC(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76102C0", Offset = "0x760E8C0", VA = "0x1876102C0")]
	public void IOEKNDJEAJM(BBOKNICKHPG MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x326E6B0", Offset = "0x326CCB0", VA = "0x18326E6B0")]
	public void IOEKNDJEAJM<T>(T ICONKPKJBGN, APMNDCDCNFA<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x326E370", Offset = "0x326C970", VA = "0x18326E370")]
	public void IEGNOINNOMJ<T>([In] T ICONKPKJBGN, MFDKDKOELJG<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x326E510", Offset = "0x326CB10", VA = "0x18326E510")]
	public void IOEKNDJEAJM<T>([In] T ICONKPKJBGN, MFDKDKOELJG<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7610040", Offset = "0x760E640", VA = "0x187610040")]
	public bool DKKAHALPLON(bool CMPFGFPGHEP, string MIALAMIFNLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct NCNGPIKHHEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string DEDOPNLMLPL;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBD5420", Offset = "0xBD3A20", VA = "0x180BD5420")]
	public NCNGPIKHHEM(string KBGCCIOIGBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
	public static string HEGJABMHLEC([In] NCNGPIKHHEM JDCFMPOHCEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2010830", Offset = "0x200EE30", VA = "0x182010830")]
	public static NCNGPIKHHEM HEGJABMHLEC(string OKCHLIEAIJP)
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7615080", Offset = "0x7613680", VA = "0x187615080")]
	public string KMKMCBJODMD(string IBMFPHICBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7614FA0", Offset = "0x76135A0", VA = "0x187614FA0")]
	public string GKLKOPALJLE(object LAJIGGEGODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class ABGINMJPEGK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public ABGINMJPEGK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct IDMEFNAINAN : IEquatable<IDMEFNAINAN>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "4")]
	public bool Equals(IDMEFNAINAN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7612920", Offset = "0x7610F20", VA = "0x187612920", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7612970", Offset = "0x7610F70", VA = "0x187612970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7612980", Offset = "0x7610F80", VA = "0x187612980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CGDEHPHFPEN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct HEGNJKKKIBE<T> : IEquatable<HEGNJKKKIBE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T DEDOPNLMLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool LOPHOFFEGJP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool GBPFCFECMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x462AC90", Offset = "0x4629290", VA = "0x18462AC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x462C990", Offset = "0x462AF90", VA = "0x18462C990")]
	public HEGNJKKKIBE([In] T KBGCCIOIGBD, bool DGIKMNKDLAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x462A720", Offset = "0x4628D20", VA = "0x18462A720")]
	public static bool BFIJCNNIIMH([In] HEGNJKKKIBE<T> HJGDMEAJFEI, [In] HEGNJKKKIBE<T> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x462AFB0", Offset = "0x46295B0", VA = "0x18462AFB0", Slot = "4")]
	public bool Equals(HEGNJKKKIBE<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x462B310", Offset = "0x4629910", VA = "0x18462B310", Slot = "0")]
	public override bool Equals(object? OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x462B930", Offset = "0x4629F30", VA = "0x18462B930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x462C0E0", Offset = "0x462A6E0", VA = "0x18462C0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GHBAGBLDMME
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x33D9D50", Offset = "0x33D8350", VA = "0x1833D9D50")]
	public static HEGNJKKKIBE<T> EEOKBAINHEC<T>([In] T KBGCCIOIGBD) where T : notnull
	{
		return default(HEGNJKKKIBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x33D9B00", Offset = "0x33D8100", VA = "0x1833D9B00")]
	public static HEGNJKKKIBE<T?> ACOKCKGHFKJ<T>()
	{
		return default(HEGNJKKKIBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E50", Offset = "0x33D8450", VA = "0x1833D9E50")]
	public static bool IHEGKFLKMDA<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, [Out][NotNullWhen(true)] T KBGCCIOIGBD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E10", Offset = "0x33D8410", VA = "0x1833D9E10")]
	public static bool IHEGKFLKMDA<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, [Out][NotNullWhen(true)] T KBGCCIOIGBD, [Out] HEGNJKKKIBE<T> PNDMAMKJKEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x33D9BC0", Offset = "0x33D81C0", VA = "0x1833D9BC0")]
	public static T? AEDHDBOECFD<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, T? IDJBNLNBJCD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E80", Offset = "0x33D8480", VA = "0x1833D9E80")]
	public static bool KBPKJEDADLN<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, T KBGCCIOIGBD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FHNMCNAACGL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x33BFCA0", Offset = "0x33BE2A0", VA = "0x1833BFCA0")]
	public static T NGALJDIPJFH<T>([In] this HEGNJKKKIBE<T> OABADFELBIC) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KDEPHDNKEJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr JJOKHJDLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr CGDGEOGJDMO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr LPOJDPOPGGK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr JDPDMIBHMHL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly KDEPHDNKEJC DGEEMDAPOEK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PMLNJMJFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7612BE0", Offset = "0x76111E0", VA = "0x187612BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
	public KDEPHDNKEJC(IntPtr DMPJJMHHPPI, IntPtr NFILIOKGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void FKPJCJKOEPF(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	private static void IBBNLOAENBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7612CC0", Offset = "0x76112C0", VA = "0x187612CC0")]
	private static KDEPHDNKEJC HKBELKAOBLP()
	{
		return default(KDEPHDNKEJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct HBCFDGIDKJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr ELPFIKPMEIA;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
	private HBCFDGIDKJM(IntPtr NFILIOKGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7612900", Offset = "0x7610F00", VA = "0x187612900")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7612810", Offset = "0x7610E10", VA = "0x187612810")]
	public static HBCFDGIDKJM FEOBEKOIKMG(string OMOOEGOLALI)
	{
		return default(HBCFDGIDKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2588E30", Offset = "0x2587430", VA = "0x182588E30")]
	public static HBCFDGIDKJM FEOBEKOIKMG([In] KDEPHDNKEJC IFMOEEEHJED, string OMOOEGOLALI)
	{
		return default(HBCFDGIDKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2588740", Offset = "0x2586D40", VA = "0x182588740")]
	public static HBCFDGIDKJM FEOBEKOIKMG([In] KDEPHDNKEJC IFMOEEEHJED, Func<string> OMOOEGOLALI)
	{
		return default(HBCFDGIDKJM);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NEKBHKGANFD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool GKECAOJNLCF<in TInput, TResult>(TInput IOJLNNHDMIE, [Out] TResult BIEIOPPGBOB);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class DIJCLPBMJOF : HEPMKLNOCMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class CHOBLAGMFBD : CECHPAPPEEE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly CHOBLAGMFBD IMFIEPMCPDC;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool INNLJOEIPDH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x760F1B0", Offset = "0x760D7B0", VA = "0x18760F1B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x760F210", Offset = "0x760D810", VA = "0x18760F210", Slot = "6")]
			public void OnCompleted(Action KCPBOAEAJJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			public void PNMFNAONGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public CHOBLAGMFBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly DIJCLPBMJOF IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		private DIJCLPBMJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x760FC20", Offset = "0x760E220", VA = "0x18760FC20", Slot = "4")]
		public CECHPAPPEEE CHPBIIJHJCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class OFICBKLMNPL : HEPMKLNOCMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class AANEALDOHLN : CECHPAPPEEE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly AANEALDOHLN IMFIEPMCPDC;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool INNLJOEIPDH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x760D310", Offset = "0x760B910", VA = "0x18760D310", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x760D330", Offset = "0x760B930", VA = "0x18760D330", Slot = "6")]
			public void OnCompleted(Action KCPBOAEAJJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			public void PNMFNAONGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public AANEALDOHLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly OFICBKLMNPL IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		private OFICBKLMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7617A80", Offset = "0x7616080", VA = "0x187617A80", Slot = "4")]
		public CECHPAPPEEE CHPBIIJHJCK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GGCFOLBHDMI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GGCFOLBHDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x45541C0", Offset = "0x45527C0", VA = "0x1845541C0")]
		internal void DEJPJPBOLFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class FOGJAJADPJL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FOGJAJADPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4439B60", Offset = "0x4438160", VA = "0x184439B60")]
		internal void AAGGBIEIEGE(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EPDIFPGAFJI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7610A60", Offset = "0x760F060", VA = "0x187610A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JHPIJABEONO : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x76129B0", Offset = "0x7610FB0", VA = "0x1876129B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FMNLJPKHHLP<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4436B70", Offset = "0x4435170", VA = "0x184436B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4436CE0", Offset = "0x44352E0", VA = "0x184436CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ICHLNFHEBAJ<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x476A330", Offset = "0x4768930", VA = "0x18476A330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x476AB80", Offset = "0x4769180", VA = "0x18476AB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FGEDKHAJKJC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7610BC0", Offset = "0x760F1C0", VA = "0x187610BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7610DD0", Offset = "0x760F3D0", VA = "0x187610DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OOANDGAFKIP<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OOANDGAFKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x45541C0", Offset = "0x45527C0", VA = "0x1845541C0")]
		internal void KCACCMHAFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x502A680", Offset = "0x5028C80", VA = "0x18502A680")]
		internal void DKKNDABBCDG(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PMJDNAAACLG<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public GKECAOJNLCF<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x510C240", Offset = "0x510A840", VA = "0x18510C240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x510C950", Offset = "0x510AF50", VA = "0x18510C950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PGBOFOHPEGI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7618E10", Offset = "0x7617410", VA = "0x187618E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7619610", Offset = "0x7617C10", VA = "0x187619610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct NEOPJJKEBGG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7617450", Offset = "0x7615A50", VA = "0x187617450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76179A0", Offset = "0x7615FA0", VA = "0x1876179A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct JAHDPALLJBB<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x49AB4B0", Offset = "0x49A9AB0", VA = "0x1849AB4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x44E5E30", Offset = "0x44E4430", VA = "0x1844E5E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class LDOMIHDOAAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<IDMEFNAINAN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LDOMIHDOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x76142D0", Offset = "0x76128D0", VA = "0x1876142D0")]
		internal void ECKCNIDIELP(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct HHMGIHFCMJH<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4680840", Offset = "0x467EE40", VA = "0x184680840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3D32470", Offset = "0x3D30A70", VA = "0x183D32470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct OFKHIKDOJIL<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

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
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF79E0", Offset = "0x4FF5FE0", VA = "0x184FF79E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8200", Offset = "0x4FF6800", VA = "0x184FF8200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct GDHDHPOCMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7610EB0", Offset = "0x760F4B0", VA = "0x187610EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7611090", Offset = "0x760F690", VA = "0x187611090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OKKBCAACPHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7618070", Offset = "0x7616670", VA = "0x187618070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x76183E0", Offset = "0x76169E0", VA = "0x1876183E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct OIIIFAPDHJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7617D20", Offset = "0x7616320", VA = "0x187617D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7618010", Offset = "0x7616610", VA = "0x187618010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PGLIHLGLBPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public PGLIHLGLBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7619670", Offset = "0x7617C70", VA = "0x187619670")]
		internal Task ENGNIALCDND(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct LIMDHCOJHAP : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7614730", Offset = "0x7612D30", VA = "0x187614730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7614990", Offset = "0x7612F90", VA = "0x187614990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KOECEGBPGKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7613730", Offset = "0x7611D30", VA = "0x187613730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7613910", Offset = "0x7611F10", VA = "0x187613910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BLBBDMHAANK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x760EDE0", Offset = "0x760D3E0", VA = "0x18760EDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x760F150", Offset = "0x760D750", VA = "0x18760F150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct LFEJCHACHIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x76143E0", Offset = "0x76129E0", VA = "0x1876143E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76146D0", Offset = "0x7612CD0", VA = "0x1876146D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OPNHEOOFELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OPNHEOOFELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7618440", Offset = "0x7616A40", VA = "0x187618440")]
		internal Task IMNPAJCMIMI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct KIFLNDAOHIP : IAsyncStateMachine
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
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7612EA0", Offset = "0x76114A0", VA = "0x187612EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7613100", Offset = "0x7611700", VA = "0x187613100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct LMNNMIFIJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x76149F0", Offset = "0x7612FF0", VA = "0x1876149F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7614B70", Offset = "0x7613170", VA = "0x187614B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct HKOFIPCGGGB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4692C80", Offset = "0x4691280", VA = "0x184692C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4692EE0", Offset = "0x46914E0", VA = "0x184692EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct ALGBFGEMGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x760E590", Offset = "0x760CB90", VA = "0x18760E590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x760E8C0", Offset = "0x760CEC0", VA = "0x18760E8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? OPGKBCJHFPO;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<IDMEFNAINAN> JNJGFAOHDMC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task HENKKDABGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x76164B0", Offset = "0x7614AB0", VA = "0x1876164B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7615840", Offset = "0x7613E40", VA = "0x187615840")]
	public static bool DBIBJDPPFPE(this Task CBPINBDBDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x35B2AA0", Offset = "0x35B10A0", VA = "0x1835B2AA0")]
	public static Task<T> PCGANDNMDMF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76161A0", Offset = "0x76147A0", VA = "0x1876161A0")]
	public static Task FPHOEOMNHME(this Task CBPINBDBDCO, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x35B07E0", Offset = "0x35AEDE0", VA = "0x1835B07E0")]
	public static Task<TResult> FPHOEOMNHME<TResult>(this Task<TResult> CBPINBDBDCO, CancellationToken LAAJFAFNFCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x35B1A80", Offset = "0x35B0080", VA = "0x1835B1A80")]
	public static TaskCompletionSource<TResult> FPHOEOMNHME<TResult>(this TaskCompletionSource<TResult> KDHLGIELGNK, CancellationToken LAAJFAFNFCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76152F0", Offset = "0x76138F0", VA = "0x1876152F0")]
	public static IDisposable? CFOLOEADPBN(CancellationToken CEHJDOBDHNG, CancellationToken MNDKJFHOICL, [Out] CancellationToken CGNGDAKFHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7616400", Offset = "0x7614A00", VA = "0x187616400")]
	[AsyncStateMachine(typeof(EPDIFPGAFJI))]
	public static void GGIGANLPNID(this Task CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7617040", Offset = "0x7615640", VA = "0x187617040")]
	[AsyncStateMachine(typeof(JHPIJABEONO))]
	public static void JBJHPEMMGFD(this Task CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35AD990", Offset = "0x35ABF90", VA = "0x1835AD990")]
	[AsyncStateMachine(typeof(FMNLJPKHHLP<>))]
	public static Task DJDFKKBGIFF<TException>(this Task CHBEBLKFDBC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x35ADC40", Offset = "0x35AC240", VA = "0x1835ADC40")]
	[AsyncStateMachine(typeof(ICHLNFHEBAJ<>))]
	public static Task<T> EPGEFLBLNHI<T>(this Task<T> JDCFMPOHCEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7615550", Offset = "0x7613B50", VA = "0x187615550")]
	[AsyncStateMachine(typeof(FGEDKHAJKJC))]
	public static Task<TaskStatus> CMDBDDMPFIE(this Task? JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x35B2C20", Offset = "0x35B1220", VA = "0x1835B2C20")]
	public static (Task<T?>?, Action<T?>?) PGPLJKNBEME<T>([Optional] CancellationToken LAEIHJHNGEK)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x35B2990", Offset = "0x35B0F90", VA = "0x1835B2990")]
	[AsyncStateMachine(typeof(PMJDNAAACLG<, >))]
	public static Task<List<TResult>> JNALEAHFFGF<TResult, TInput>(this Task<List<TInput>> CBPINBDBDCO, GKECAOJNLCF<TInput, TResult> AINMLNBGFAE) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7615F80", Offset = "0x7614580", VA = "0x187615F80")]
	[AsyncStateMachine(typeof(PGBOFOHPEGI))]
	public static Task EOIDPFGNCFP(Task CHBEBLKFDBC, CancellationToken DGLOFFGGICM, Func<CancellationToken, Task> NMIMACLADGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7616520", Offset = "0x7614B20", VA = "0x187616520")]
	[AsyncStateMachine(typeof(NEOPJJKEBGG))]
	public static Task HLJDFAKADLD(Func<CancellationToken, Task> KBKNECNKOFI, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken DGLOFFGGICM, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x35B26F0", Offset = "0x35B0CF0", VA = "0x1835B26F0")]
	[AsyncStateMachine(typeof(JAHDPALLJBB<>))]
	public static Task<T> HLJDFAKADLD<T>(Func<CancellationToken, Task<T>> KBKNECNKOFI, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken DGLOFFGGICM, [Optional] Func<OperationCanceledException, T>? DKPEONIFOAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7616D80", Offset = "0x7615380", VA = "0x187616D80")]
	public static Task INPBCLDIHAO(params Task[] IIBLCKMDOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76168C0", Offset = "0x7614EC0", VA = "0x1876168C0")]
	public static Task INPBCLDIHAO(IEnumerable<Task> IIBLCKMDOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x35ADB50", Offset = "0x35AC150", VA = "0x1835ADB50")]
	[AsyncStateMachine(typeof(HHMGIHFCMJH<>))]
	public static Task<IEnumerable<Task<T>>> EJOHMFNEPGP<T>(IEnumerable<Task<T>> IIBLCKMDOMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x35B2410", Offset = "0x35B0A10", VA = "0x1835B2410")]
	[AsyncStateMachine(typeof(OFKHIKDOJIL<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> HBMBEEANKOM<T1, T2, T3, T4, T5>(Task<T1> OPLEABPIPHF, Task<T2> BDBGACCFBCA, Task<T3> ILJHLODIGKP, Task<T4> NEOPIEJCHHH, Task<T5> IEOGNBNACDC) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7615D00", Offset = "0x7614300", VA = "0x187615D00")]
	[AsyncStateMachine(typeof(GDHDHPOCMMJ))]
	public static Task DKIKFMCMEEE(Func<bool> CMPFGFPGHEP, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7615BF0", Offset = "0x76141F0", VA = "0x187615BF0")]
	[AsyncStateMachine(typeof(OKKBCAACPHI))]
	public static Task DKIKFMCMEEE(Func<bool> CMPFGFPGHEP, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7616650", Offset = "0x7614C50", VA = "0x187616650")]
	[AsyncStateMachine(typeof(OIIIFAPDHJG))]
	public static Task HNCJBDAKFIL(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7616780", Offset = "0x7614D80", VA = "0x187616780")]
	[AsyncStateMachine(typeof(LIMDHCOJHAP))]
	public static Task HNCJBDAKFIL(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7615640", Offset = "0x7613C40", VA = "0x187615640")]
	[AsyncStateMachine(typeof(KOECEGBPGKL))]
	public static Task DBFDANEECPK(Func<bool> CMPFGFPGHEP, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7615730", Offset = "0x7613D30", VA = "0x187615730")]
	[AsyncStateMachine(typeof(BLBBDMHAANK))]
	public static Task DBFDANEECPK(Func<bool> CMPFGFPGHEP, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7616F10", Offset = "0x7615510", VA = "0x187616F10")]
	[AsyncStateMachine(typeof(LFEJCHACHIN))]
	public static Task IPDGGOOCMOJ(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7616DD0", Offset = "0x76153D0", VA = "0x187616DD0")]
	[AsyncStateMachine(typeof(KIFLNDAOHIP))]
	public static Task IPDGGOOCMOJ(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76160B0", Offset = "0x76146B0", VA = "0x1876160B0")]
	[AsyncStateMachine(typeof(LMNNMIFIJEH))]
	[Obsolete]
	public static Task FPHCMGIIFOC(this Task CBPINBDBDCO, Action DOENJJAPOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x35ADE20", Offset = "0x35AC420", VA = "0x1835ADE20")]
	[Obsolete]
	[AsyncStateMachine(typeof(HKOFIPCGGGB<>))]
	public static Task FPHCMGIIFOC<T>(this Task<T> CBPINBDBDCO, Action<T> DOENJJAPOKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76172E0", Offset = "0x76158E0", VA = "0x1876172E0")]
	private static void OFDDMFNGCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7615870", Offset = "0x7613E70", VA = "0x187615870")]
	public static bool DFEJCAHGGOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7615DF0", Offset = "0x76143F0", VA = "0x187615DF0")]
	private static void EDIFPFLMLOK(SynchronizationContext KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76151D0", Offset = "0x76137D0", VA = "0x1876151D0")]
	private static void AHJCJBPABOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7617140", Offset = "0x7615740", VA = "0x187617140")]
	public static void LMMEMAKKGHF([Optional] string? MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7617260", Offset = "0x7615860", VA = "0x187617260")]
	public static void NHCIGNDBOPI([Optional] string? MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76170F0", Offset = "0x76156F0", VA = "0x1876170F0")]
	public static HEPMKLNOCMM JPHBHAMHOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7617210", Offset = "0x7615810", VA = "0x187617210")]
	public static HEPMKLNOCMM MABCAGOLEJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7615480", Offset = "0x7613A80", VA = "0x187615480")]
	[AsyncStateMachine(typeof(ALGBFGEMGPE))]
	public static Task CJGFBEOOHOK(Func<Task> BPHLLBLGCAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GAFKBMEFLIK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public GAFKBMEFLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class KBALPECFEAO : POJBELOMCGC
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly POJBELOMCGC IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime BDGOHKOCGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7612AC0", Offset = "0x76110C0", VA = "0x187612AC0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset CGBMDOHBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7612B00", Offset = "0x7611100", VA = "0x187612B00", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public KBALPECFEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface POJBELOMCGC
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime BDGOHKOCGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset CGBMDOHBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CMDFHFKNJAB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long FEILHOHIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x760F770", Offset = "0x760DD70", VA = "0x18760F770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long DIEONOMLKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x760F720", Offset = "0x760DD20", VA = "0x18760F720")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double GMACKDNAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x760F5A0", Offset = "0x760DBA0", VA = "0x18760F5A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double MHBENBLKEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x760F5F0", Offset = "0x760DBF0", VA = "0x18760F5F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double IJCFIIDBFID
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x760F640", Offset = "0x760DC40", VA = "0x18760F640")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double HJELIJONIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x760F7C0", Offset = "0x760DDC0", VA = "0x18760F7C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x760F480", Offset = "0x760DA80", VA = "0x18760F480")]
	public static double BCMMFCPIOLG(long LFMBKPMGKOG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x760F3F0", Offset = "0x760D9F0", VA = "0x18760F3F0")]
	public static double AJFCKPFKKLM(long LFMBKPMGKOG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x760F510", Offset = "0x760DB10", VA = "0x18760F510")]
	public static double DPEBKEBKLPO(double COLOJIGPMOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x760F690", Offset = "0x760DC90", VA = "0x18760F690")]
	public static long KCABPHHCAGE(long HKPDGGGHFLH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x760F940", Offset = "0x760DF40", VA = "0x18760F940")]
	public static long PJHDDCBHGNL(long AMGOMNPILGK, long CFNKJPDDIBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x760F870", Offset = "0x760DE70", VA = "0x18760F870")]
	public static double OGHPMOLNBGF(long AMGOMNPILGK, long CFNKJPDDIBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x760F810", Offset = "0x760DE10", VA = "0x18760F810")]
	public static double OEPIKLANKKI(long AMGOMNPILGK, long CFNKJPDDIBL)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class AKFFMIEAANC : LHINIDECIGG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan KKKDPELJEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer ACNLNBKGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan GAOGFDNIHEO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan LPBFLHOFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x760D400", Offset = "0x760BA00", VA = "0x18760D400", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? FMHJFKJNACC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x760D840", Offset = "0x760BE40", VA = "0x18760D840")]
	[Preserve]
	public AKFFMIEAANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x760D8B0", Offset = "0x760BEB0", VA = "0x18760D8B0")]
	public AKFFMIEAANC(TimeSpan GAOGFDNIHEO, [Optional] Action? NKLPHAMEBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x760D630", Offset = "0x760BC30", VA = "0x18760D630", Slot = "7")]
	public void EKFPEOGCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x760D760", Offset = "0x760BD60", VA = "0x18760D760", Slot = "8")]
	public void NAMALBDACEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x760D600", Offset = "0x760BC00", VA = "0x18760D600", Slot = "9")]
	public void EDANFFCKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xF61AB0", Offset = "0xF600B0", VA = "0x180F61AB0")]
	private void HKMGIIOKFFF(object MEBAFDHEDIN, ElapsedEventArgs OFKHIFOCFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x760D6C0", Offset = "0x760BCC0", VA = "0x18760D6C0")]
	private static void IBPLEMEDCOF(TimeSpan FINJMKGCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x760D560", Offset = "0x760BB60", VA = "0x18760D560", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CGDEHPHFPEN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? MFAMILMKIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string BAMOFOGPNJI;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEF00", Offset = "0x6FBD500", VA = "0x186FBEF00")]
	public CGDEHPHFPEN(string GPFCOHGCDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x49A6EC0", Offset = "0x49A54C0", VA = "0x1849A6EC0")]
	public CGDEHPHFPEN(string FHGNCBECHHF, string GPFCOHGCDPH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GJIJKFCGDLH : IEquatable<GJIJKFCGDLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint KMNFENGMNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int AFCKFMLJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float MPFJGNLGMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort OEIMNIGDAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JPFPJJCDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short LGBEJPNLEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short FIKOMOMBLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char BDNHCJOAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char LEJNABMLDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte NLHFAEIAABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte MHOEBBADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte BLPNOLAKJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte PJMGIBABNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool CDEGKPKMGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool ANFLPOCMMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool IPFGHMHLKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool NEEEJGFNIFB;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1C09260", Offset = "0x1C07860", VA = "0x181C09260")]
	public static GJIJKFCGDLH AIPMJCEFMJP(uint NNDPJAAGGOH)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1C09260", Offset = "0x1C07860", VA = "0x181C09260")]
	public static GJIJKFCGDLH LDMHOCFECCD(int IKNLPEMHPGP)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x76118D0", Offset = "0x760FED0", VA = "0x1876118D0")]
	public static GJIJKFCGDLH GKHFHDIILBE(float FFMJPGOAJHD)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x76118E0", Offset = "0x760FEE0", VA = "0x1876118E0")]
	public static GJIJKFCGDLH PINKMABAHKI(byte NGLKNKHGNKN, byte FIJNKKJOHEO, byte GDCBKFMMJKE, byte DFJMJEEPPNK)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76118E0", Offset = "0x760FEE0", VA = "0x1876118E0")]
	public static GJIJKFCGDLH PGMAGJKHJHM(bool OADEIDGOPOM, bool CAKKHPCINEC, bool PKNFOGGJBMN, bool EELLPBBHIJA)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76118E0", Offset = "0x760FEE0", VA = "0x1876118E0")]
	public static GJIJKFCGDLH IIGLDJPIPCM(byte GPHMKDIFDJE, byte KLHCFCMCFBP, byte BILHHPDPNDO, byte IKFNCGDNKJB)
	{
		return default(GJIJKFCGDLH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9B20", Offset = "0x1EF8120", VA = "0x181EF9B20")]
	public static bool BFIJCNNIIMH(GJIJKFCGDLH CLHNCHKFPON, GJIJKFCGDLH KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9B00", Offset = "0x1EF8100", VA = "0x181EF9B00", Slot = "4")]
	public bool Equals(GJIJKFCGDLH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7611840", Offset = "0x760FE40", VA = "0x187611840", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x110C3A0", Offset = "0x110A9A0", VA = "0x18110C3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7611900", Offset = "0x760FF00", VA = "0x187611900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct GLPFNPEIIHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong GFJGLAMNFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long GKANNILJCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double JFANKDKPAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint GFEGOFOPFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint AGKKFKHBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int GNMDOLJNLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int FHBHJKLFLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float FDBAGGAMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float PKNKPMNNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort OEIMNIGDAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort JPFPJJCDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort PDKPBCGBNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort KPHMCHHENCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short LGBEJPNLEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short FIKOMOMBLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short BBEHFCBGBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short FJLGHKOMHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char BDNHCJOAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char LEJNABMLDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char HHOMHNMMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char JCJDJBKGGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte NLHFAEIAABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte MHOEBBADDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte BLPNOLAKJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte PJMGIBABNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte POPENIFBPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte AMNMBNIOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte OPPJHIOJIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte AFJABKBHDEH;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static GLPFNPEIIHN FEOBEKOIKMG(long AHJOGHGHDEG)
	{
		return default(GLPFNPEIIHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76127C0", Offset = "0x7610DC0", VA = "0x1876127C0")]
	public static GLPFNPEIIHN FEOBEKOIKMG(byte NGLKNKHGNKN, byte FIJNKKJOHEO, byte GDCBKFMMJKE, byte DFJMJEEPPNK, byte GPIJGCPMECB, byte LGIAHHIOFHO, byte HIBJHFINOIF, byte APJAOABPCDN)
	{
		return default(GLPFNPEIIHN);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct BHPPLCNANNG : IEquatable<BHPPLCNANNG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte AADKCMJLOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool IDLGEINNHDI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBCF0", Offset = "0x2BCA2F0", VA = "0x182BCBCF0")]
	public static BHPPLCNANNG PINKMABAHKI(byte IDGMDIFONML)
	{
		return default(BHPPLCNANNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBCF0", Offset = "0x2BCA2F0", VA = "0x182BCBCF0")]
	public static BHPPLCNANNG PGMAGJKHJHM(bool NCBAJNLNANA)
	{
		return default(BHPPLCNANNG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x760EAC0", Offset = "0x760D0C0", VA = "0x18760EAC0")]
	public static bool BFIJCNNIIMH(BHPPLCNANNG CLHNCHKFPON, BHPPLCNANNG KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6651690", Offset = "0x664FC90", VA = "0x186651690", Slot = "4")]
	public bool Equals(BHPPLCNANNG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x760EAD0", Offset = "0x760D0D0", VA = "0x18760EAD0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x760EB60", Offset = "0x760D160", VA = "0x18760EB60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x760EB70", Offset = "0x760D170", VA = "0x18760EB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HEPNFICAOMF<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T LBKEHNKPKMH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x46323B0", Offset = "0x46309B0", VA = "0x1846323B0")]
	public HEPNFICAOMF(T PHJPLEGILCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class GHOMAPGDOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x33C4600", Offset = "0x33C2C00", VA = "0x1833C4600")]
	public static IEnumerable<T> LDBJMCKLCFG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static T[] KGLCBADJGBJ<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static IEnumerable<T> LKAAJFMCAPF<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static HashSet<T> BOALNEJLEFJ<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x33DB250", Offset = "0x33D9850", VA = "0x1833DB250")]
	public static KeyValuePair<TKey, TValue> CPIDDLGIMOI<TKey, TValue>([In] TKey LKMGECEEGEE, [In] TValue KBGCCIOIGBD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static List<T> EBDCKGLFLGD<T>(IEnumerable<T> FDMJAFAEFBP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JFFCMMKHJLF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string JFEHIEOLACJ;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
	public JFFCMMKHJLF(string DGMCFDFIOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object MFDKDKOELJG<T>([In] T JIEBKPCGKFF);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object APMNDCDCNFA<T>(T JIEBKPCGKFF);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[MHDIPJANLBG]
public delegate string NEGFJHMBLHO(string GIFBANFPJGI, string? JKHHHFODJFE, bool FKELGECJBKM);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[MHDIPJANLBG]
public delegate void KLJKJDOOPMJ(string MIALAMIFNLM);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[MHDIPJANLBG]
public delegate void NPBCNLHCOCI(Exception DADIPHEHDBH);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object BBOKNICKHPG();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[MHDIPJANLBG]
public delegate bool MGIIFKFODJE();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[MHDIPJANLBG]
public delegate string LMOMDIPIOPD(object GMFKPONAANG);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class AOPNADMNEGI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
	public AOPNADMNEGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class GIMMLEBGBJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct LDCGDADKIJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7613970", Offset = "0x7611F70", VA = "0x187613970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7614260", Offset = "0x7612860", VA = "0x187614260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback MNDMBBNCKEC;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> IODIDBLGGBF;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7611260", Offset = "0x760F860", VA = "0x187611260")]
	public static Task<bool> CJHDAIMAKPI(int EPHEKOIBELL, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7611570", Offset = "0x760FB70", VA = "0x187611570")]
	[AsyncStateMachine(typeof(LDCGDADKIJC))]
	private static Task<bool> DGMDLJGMPMG(int EPHEKOIBELL, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x76111D0", Offset = "0x760F7D0", VA = "0x1876111D0")]
	private static void AIAHIJPFMFI(object? CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x76116A0", Offset = "0x760FCA0", VA = "0x1876116A0")]
	private static void OFILKMOJLLJ(object? CEGAGHAOIDD)
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
