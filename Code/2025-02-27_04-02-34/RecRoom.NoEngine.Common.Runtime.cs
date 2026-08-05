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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7579470", Offset = "0x7578870", VA = "0x187579470")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KMBHPGNHNEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7574BD0", Offset = "0x7573FD0", VA = "0x187574BD0")]
	public static string HAPGJAEFBKP(this Encoding CJALHABHKAP, [In] ReadOnlySequence<byte> HECJPBMFJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x346D620", Offset = "0x346CA20", VA = "0x18346D620")]
	private static void KAANPLJDOJC<T>(this ReadOnlySequence<T> GGELOCEMMGP, [Out] ReadOnlySpan<T> LHILELKONHP, [Out] SequencePosition HBBIFNILMAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class GEOAIOEMOAL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7572B60", Offset = "0x7571F60", VA = "0x187572B60")]
	public GEOAIOEMOAL(bool LHMFCFEPKLH, string FIEMJMHICBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x172B1C0", Offset = "0x172A5C0", VA = "0x18172B1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x968620", Offset = "0x967A20", VA = "0x180968620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KDMPCMCOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75768E0", Offset = "0x7575CE0", VA = "0x1875768E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OJIKABAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x628DB30", Offset = "0x628CF30", VA = "0x18628DB30", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double EKLNFMGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x24F38E0", Offset = "0x24F2CE0", VA = "0x1824F38E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7576940", Offset = "0x7575D40", VA = "0x187576940")]
	public NABJBHIKGGL(int FDIMKIKLCLA, double FBCJGGFFCFE = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7576740", Offset = "0x7575B40", VA = "0x187576740", Slot = "7")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7576870", Offset = "0x7575C70", VA = "0x187576870", Slot = "8")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7576640", Offset = "0x7575A40", VA = "0x187576640", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OJIKABAEGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6915D50", Offset = "0x6915150", VA = "0x186915D50", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double EKLNFMGIGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6915CD0", Offset = "0x69150D0", VA = "0x186915CD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double EOIMGLHEIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6915CF0", Offset = "0x69150F0", VA = "0x186915CF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double KDMPCMCOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AD60", Offset = "0x2B8A160", VA = "0x182B8AD60", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7579630", Offset = "0x7578A30", VA = "0x187579630", Slot = "10")]
	public virtual void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7579750", Offset = "0x7578B50", VA = "0x187579750", Slot = "11")]
	public virtual void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75795C0", Offset = "0x75789C0", VA = "0x1875795C0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7570500", Offset = "0x756F900", VA = "0x187570500")]
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
		[Cpp2IlInjected.Address(RVA = "0x6915D00", Offset = "0x6915100", VA = "0x186915D00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6915D40", Offset = "0x6915140", VA = "0x186915D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7570390", Offset = "0x756F790", VA = "0x187570390", Slot = "10")]
	public override void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75704C0", Offset = "0x756F8C0", VA = "0x1875704C0", Slot = "11")]
	public override void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7570500", Offset = "0x756F900", VA = "0x187570500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7572900", Offset = "0x7571D00", VA = "0x187572900")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74D6920", Offset = "0x74D5D20", VA = "0x1874D6920", Slot = "4")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7572910", Offset = "0x7571D10", VA = "0x187572910", Slot = "5")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75728B0", Offset = "0x7571CB0", VA = "0x1875728B0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x408B6C0", Offset = "0x408AAC0", VA = "0x18408B6C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E123A0", Offset = "0x4E117A0", VA = "0x184E123A0", Slot = "4")]
	public void KDNNJPAODIP(double DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7574220", Offset = "0x7573620", VA = "0x187574220", Slot = "5")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75741D0", Offset = "0x75735D0", VA = "0x1875741D0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50884D0", Offset = "0x50878D0", VA = "0x1850884D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5089590", Offset = "0x5088990", VA = "0x185089590", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5A3B150", Offset = "0x5A3A550", VA = "0x185A3B150")]
	[AsyncStateMachine(typeof(CEHDFABDNPO<>.PHBMBBMNNMN))]
	public Task<TResult> ILDMDIBEJPH(DECDMGDNJDH CMKCNDOGGAI, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B0E0", Offset = "0x5A3A4E0", VA = "0x185A3B0E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A3B290", Offset = "0x5A3A690", VA = "0x185A3B290")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E8C9F0", Offset = "0x4E8BDF0", VA = "0x184E8C9F0")]
	public DMCLNNLJALJ([In] T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62BE080", Offset = "0x62BD480", VA = "0x1862BE080", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62BE710", Offset = "0x62BDB10", VA = "0x1862BE710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62BEB10", Offset = "0x62BDF10", VA = "0x1862BEB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KAEEGFMAHCL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
	public static DMCLNNLJALJ<T> FEOBEKOIKMG<T>([In] T KBGCCIOIGBD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DOJDLHPFICM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7571880", Offset = "0x7570C80", VA = "0x187571880")]
	public static void LEEAEBLPONG(this CancellationTokenSource PMAMMIAHALH, bool BFNPHKELKBM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MHDIPJANLBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public MHDIPJANLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OPICOFBLENP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public OPICOFBLENP(string JMPINPHCODP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DLLCIKOIAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x320A4B0", Offset = "0x32098B0", VA = "0x18320A4B0")]
	public static NCNGPIKHHEM GBCDHBKADDG<T>()
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x320A7B0", Offset = "0x3209BB0", VA = "0x18320A7B0")]
	public static NCNGPIKHHEM HJJENGABEAJ<T>([CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x320A530", Offset = "0x3209930", VA = "0x18320A530")]
	public static NCNGPIKHHEM GBCDHBKADDG<T>(this T MEBAFDHEDIN) where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x320A850", Offset = "0x3209C50", VA = "0x18320A850")]
	public static NCNGPIKHHEM KNCFMMMIFPF<T>(this T MEBAFDHEDIN, [CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x320A700", Offset = "0x3209B00", VA = "0x18320A700")]
	public static NCNGPIKHHEM HJJENGABEAJ<T>(this T JDCFMPOHCEA, [CallerMemberName] string OMOOEGOLALI = "") where T : notnull
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7571800", Offset = "0x7570C00", VA = "0x187571800")]
	public static NCNGPIKHHEM HJJENGABEAJ(string CMLKDGJMHLH, [CallerMemberName] string OMOOEGOLALI = "")
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7571760", Offset = "0x7570B60", VA = "0x187571760")]
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
		[Cpp2IlInjected.Address(RVA = "0x757A770", Offset = "0x7579B70", VA = "0x18757A770")]
		get
		{
			return default(ALCDHDCNBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EDNEPNABDLO IFKFDBFKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7579F20", Offset = "0x7579320", VA = "0x187579F20")]
		get
		{
			return default(EDNEPNABDLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static KDEPHDNKEJC JILMJPLOJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x757A570", Offset = "0x7579970", VA = "0x18757A570")]
		get
		{
			return default(KDEPHDNKEJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool KJKMOIKKMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x757A240", Offset = "0x7579640", VA = "0x18757A240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x757A5C0", Offset = "0x75799C0", VA = "0x18757A5C0")]
	public static void OMKOKAKLMBF([In] ALCDHDCNBPA HPALEHBJHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x757A2B0", Offset = "0x75796B0", VA = "0x18757A2B0")]
	public static void IEGNOINNOMJ(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x757A380", Offset = "0x7579780", VA = "0x18757A380")]
	public static void IOEKNDJEAJM(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35BB180", Offset = "0x35BA580", VA = "0x1835BB180")]
	public static void IOEKNDJEAJM<T>(T ICONKPKJBGN, APMNDCDCNFA<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x757A450", Offset = "0x7579850", VA = "0x18757A450")]
	public static void JEPGDHGPBEC(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x757A4F0", Offset = "0x75798F0", VA = "0x18757A4F0")]
	public static void JJOKHJDLJEK(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7579F70", Offset = "0x7579370", VA = "0x187579F70")]
	public static void CGDGEOGJDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x757A1C0", Offset = "0x75795C0", VA = "0x18757A1C0")]
	public static string FJAJAGDLKBG(object GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x757A080", Offset = "0x7579480", VA = "0x18757A080")]
	public static long EDPPHFIIKCE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7579FE0", Offset = "0x75793E0", VA = "0x187579FE0")]
	public static bool DKKAHALPLON(bool CMPFGFPGHEP, string MIALAMIFNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x757A0F0", Offset = "0x75794F0", VA = "0x18757A0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x756F570", Offset = "0x756E970", VA = "0x18756F570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x756FF50", Offset = "0x756F350", VA = "0x18756FF50")]
	public ALCDHDCNBPA([In] EDNEPNABDLO EFONOFNMJPL, [In] KDEPHDNKEJC IFMOEEEHJED, LMOMDIPIOPD AJBMAIDPDOE, BFPPOGOACKP KMIDMCJIBFA, NEGFJHMBLHO BLKKFBCCLBC, DPPOLMHPFJF ECMDPDAKAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x756F820", Offset = "0x756EC20", VA = "0x18756F820")]
	private static string IDBEKDMKDNL(object GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70")]
	private static long JDCDHEFDJPF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	private static string PJHEMKINEBO(string GIFBANFPJGI, string? JKHHHFODJFE, bool FKELGECJBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	private static bool LHJBBAOJBNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x756F710", Offset = "0x756EB10", VA = "0x18756F710")]
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
	[Cpp2IlInjected.Address(RVA = "0x4A36B70", Offset = "0x4A35F70", VA = "0x184A36B70")]
	public KAJBFJJDEPL([In] T KBGCCIOIGBD, int EAHKFAJBNDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4A34B20", Offset = "0x4A33F20", VA = "0x184A34B20")]
	public static bool BFIJCNNIIMH([In] KAJBFJJDEPL<T> HJGDMEAJFEI, [In] KAJBFJJDEPL<T> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x462F680", Offset = "0x462EA80", VA = "0x18462F680", Slot = "4")]
	public bool Equals(KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x45D1600", Offset = "0x45D0A00", VA = "0x1845D1600", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A361C0", Offset = "0x4A355C0", VA = "0x184A361C0")]
	public bool OIDJNNPGPKA([In] KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A35850", Offset = "0x4A34C50", VA = "0x184A35850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A364A0", Offset = "0x4A358A0", VA = "0x184A364A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A360D0", Offset = "0x4A354D0", VA = "0x184A360D0")]
	public void JNMBAPLKJHM([Out] T KBGCCIOIGBD, [Out] int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A35030", Offset = "0x4A34430", VA = "0x184A35030")]
	public (T, int) CAIBKNIPOOF()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A36170", Offset = "0x4A35570", VA = "0x184A36170", Slot = "5")]
	private bool KJPKMMNFKKA([In] KAJBFJJDEPL<T> OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MLPOPJNGCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x34D1450", Offset = "0x34D0850", VA = "0x1834D1450")]
	public static KAJBFJJDEPL<T> FEOBEKOIKMG<T>([In] T KBGCCIOIGBD, int EAHKFAJBNDN) where T : notnull
	{
		return default(KAJBFJJDEPL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CIPFKEACANI
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x31C2610", Offset = "0x31C1A10", VA = "0x1831C2610")]
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
		[Cpp2IlInjected.Address(RVA = "0x75718B0", Offset = "0x7570CB0", VA = "0x1875718B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xBFF930", Offset = "0xBFED30", VA = "0x180BFF930")]
	public EDNEPNABDLO(MGIIFKFODJE LOPDEMPOGAC, KLJKJDOOPMJ ODNOJKENPIE, MGIIFKFODJE MEADDGPCCCM, KLJKJDOOPMJ HEGPGBEJDEF, MGIIFKFODJE ILMNDAIJAMH, KLJKJDOOPMJ OGGDBLIKAOK, NPBCNLHCOCI AMIECGOAOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	private static bool DCHJODNINIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void EPIJBMLKJLL(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	private static bool ALCFGEKJFEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void JMIEFEBMJIE(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
	private static bool FJIKLKMOBAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void IPJLEAOHPKG(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void NKAOCBJDKON(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7571B80", Offset = "0x7570F80", VA = "0x187571B80")]
	private static EDNEPNABDLO HKBELKAOBLP()
	{
		return default(EDNEPNABDLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
	private static bool DGCNMOOPFKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7571CC0", Offset = "0x75710C0", VA = "0x187571CC0")]
	public void IEGNOINNOMJ(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7571E80", Offset = "0x7571280", VA = "0x187571E80")]
	public void KGGBDCBEFBB(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7571E10", Offset = "0x7571210", VA = "0x187571E10")]
	public void IOEKNDJEAJM(object MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC001E0", Offset = "0xBFF5E0", VA = "0x180C001E0")]
	public void JEPGDHGPBEC(Exception DADIPHEHDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7571D30", Offset = "0x7571130", VA = "0x187571D30")]
	public void IOEKNDJEAJM(BBOKNICKHPG MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3225550", Offset = "0x3224950", VA = "0x183225550")]
	public void IOEKNDJEAJM<T>(T ICONKPKJBGN, APMNDCDCNFA<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3225210", Offset = "0x3224610", VA = "0x183225210")]
	public void IEGNOINNOMJ<T>([In] T ICONKPKJBGN, MFDKDKOELJG<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32253B0", Offset = "0x32247B0", VA = "0x1832253B0")]
	public void IOEKNDJEAJM<T>([In] T ICONKPKJBGN, MFDKDKOELJG<T> MIALAMIFNLM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7571AB0", Offset = "0x7570EB0", VA = "0x187571AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0xBCD900", Offset = "0xBCCD00", VA = "0x180BCD900")]
	public NCNGPIKHHEM(string KBGCCIOIGBD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970")]
	public static string HEGJABMHLEC([In] NCNGPIKHHEM JDCFMPOHCEA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1AE0", Offset = "0x1FE0EE0", VA = "0x181FE1AE0")]
	public static NCNGPIKHHEM HEGJABMHLEC(string OKCHLIEAIJP)
	{
		return default(NCNGPIKHHEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7576AF0", Offset = "0x7575EF0", VA = "0x187576AF0")]
	public string KMKMCBJODMD(string IBMFPHICBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7576A10", Offset = "0x7575E10", VA = "0x187576A10")]
	public string GKLKOPALJLE(object LAJIGGEGODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
	public ABGINMJPEGK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct IDMEFNAINAN : IEquatable<IDMEFNAINAN>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "4")]
	public bool Equals(IDMEFNAINAN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7574390", Offset = "0x7573790", VA = "0x187574390", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75743E0", Offset = "0x75737E0", VA = "0x1875743E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75743F0", Offset = "0x75737F0", VA = "0x1875743F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x45D0D10", Offset = "0x45D0110", VA = "0x1845D0D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x45D2A10", Offset = "0x45D1E10", VA = "0x1845D2A10")]
	public HEGNJKKKIBE([In] T KBGCCIOIGBD, bool DGIKMNKDLAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x45D07A0", Offset = "0x45CFBA0", VA = "0x1845D07A0")]
	public static bool BFIJCNNIIMH([In] HEGNJKKKIBE<T> HJGDMEAJFEI, [In] HEGNJKKKIBE<T> OHAJMMPIMHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45D1030", Offset = "0x45D0430", VA = "0x1845D1030", Slot = "4")]
	public bool Equals(HEGNJKKKIBE<T> OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x45D1390", Offset = "0x45D0790", VA = "0x1845D1390", Slot = "0")]
	public override bool Equals(object? OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45D19B0", Offset = "0x45D0DB0", VA = "0x1845D19B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x45D2160", Offset = "0x45D1560", VA = "0x1845D2160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GHBAGBLDMME
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3395630", Offset = "0x3394A30", VA = "0x183395630")]
	public static HEGNJKKKIBE<T> EEOKBAINHEC<T>([In] T KBGCCIOIGBD) where T : notnull
	{
		return default(HEGNJKKKIBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x33953E0", Offset = "0x33947E0", VA = "0x1833953E0")]
	public static HEGNJKKKIBE<T?> ACOKCKGHFKJ<T>()
	{
		return default(HEGNJKKKIBE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3395730", Offset = "0x3394B30", VA = "0x183395730")]
	public static bool IHEGKFLKMDA<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, [Out][NotNullWhen(true)] T KBGCCIOIGBD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x33956F0", Offset = "0x3394AF0", VA = "0x1833956F0")]
	public static bool IHEGKFLKMDA<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, [Out][NotNullWhen(true)] T KBGCCIOIGBD, [Out] HEGNJKKKIBE<T> PNDMAMKJKEH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x33954A0", Offset = "0x33948A0", VA = "0x1833954A0")]
	public static T? AEDHDBOECFD<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, T? IDJBNLNBJCD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3395760", Offset = "0x3394B60", VA = "0x183395760")]
	public static bool KBPKJEDADLN<T>([In] this HEGNJKKKIBE<T> OABADFELBIC, T KBGCCIOIGBD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FHNMCNAACGL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x337B4D0", Offset = "0x337A8D0", VA = "0x18337B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7574650", Offset = "0x7573A50", VA = "0x187574650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
	public KDEPHDNKEJC(IntPtr DMPJJMHHPPI, IntPtr NFILIOKGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void FKPJCJKOEPF(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void IBBNLOAENBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7574730", Offset = "0x7573B30", VA = "0x187574730")]
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
	[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460")]
	private HBCFDGIDKJM(IntPtr NFILIOKGONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7574370", Offset = "0x7573770", VA = "0x187574370")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7574280", Offset = "0x7573680", VA = "0x187574280")]
	public static HBCFDGIDKJM FEOBEKOIKMG(string OMOOEGOLALI)
	{
		return default(HBCFDGIDKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25560B0", Offset = "0x25554B0", VA = "0x1825560B0")]
	public static HBCFDGIDKJM FEOBEKOIKMG([In] KDEPHDNKEJC IFMOEEEHJED, string OMOOEGOLALI)
	{
		return default(HBCFDGIDKJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25559C0", Offset = "0x2554DC0", VA = "0x1825559C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7570C20", Offset = "0x7570020", VA = "0x187570C20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7570C80", Offset = "0x7570080", VA = "0x187570C80", Slot = "6")]
			public void OnCompleted(Action KCPBOAEAJJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			public void PNMFNAONGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public CHOBLAGMFBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly DIJCLPBMJOF IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		private DIJCLPBMJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7571690", Offset = "0x7570A90", VA = "0x187571690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x756ED80", Offset = "0x756E180", VA = "0x18756ED80", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x756EDA0", Offset = "0x756E1A0", VA = "0x18756EDA0", Slot = "6")]
			public void OnCompleted(Action KCPBOAEAJJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			public void PNMFNAONGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public AANEALDOHLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly OFICBKLMNPL IMFIEPMCPDC;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		private OFICBKLMNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75794F0", Offset = "0x75788F0", VA = "0x1875794F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GGCFOLBHDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x44FAB40", Offset = "0x44F9F40", VA = "0x1844FAB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FOGJAJADPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x43DFF80", Offset = "0x43DF380", VA = "0x1843DFF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x75724D0", Offset = "0x75718D0", VA = "0x1875724D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7574420", Offset = "0x7573820", VA = "0x187574420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x43DCF90", Offset = "0x43DC390", VA = "0x1843DCF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x43DD100", Offset = "0x43DC500", VA = "0x1843DD100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4710F80", Offset = "0x4710380", VA = "0x184710F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x47117D0", Offset = "0x4710BD0", VA = "0x1847117D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7572630", Offset = "0x7571A30", VA = "0x187572630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7572840", Offset = "0x7571C40", VA = "0x187572840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OOANDGAFKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x44FAB40", Offset = "0x44F9F40", VA = "0x1844FAB40")]
		internal void KCACCMHAFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4FCBBA0", Offset = "0x4FCAFA0", VA = "0x184FCBBA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50ADC30", Offset = "0x50AD030", VA = "0x1850ADC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x50AE340", Offset = "0x50AD740", VA = "0x1850AE340", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x757A880", Offset = "0x7579C80", VA = "0x18757A880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x757B080", Offset = "0x757A480", VA = "0x18757B080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7578EC0", Offset = "0x75782C0", VA = "0x187578EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7579410", Offset = "0x7578810", VA = "0x187579410", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x493B600", Offset = "0x493AA00", VA = "0x18493B600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x448C7B0", Offset = "0x448BBB0", VA = "0x18448C7B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LDOMIHDOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7575D40", Offset = "0x7575140", VA = "0x187575D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4616B50", Offset = "0x4615F50", VA = "0x184616B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEAD30", Offset = "0x3CEA130", VA = "0x183CEAD30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F98F60", Offset = "0x4F98360", VA = "0x184F98F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4F99780", Offset = "0x4F98B80", VA = "0x184F99780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7572920", Offset = "0x7571D20", VA = "0x187572920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7572B00", Offset = "0x7571F00", VA = "0x187572B00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7579AE0", Offset = "0x7578EE0", VA = "0x187579AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7579E50", Offset = "0x7579250", VA = "0x187579E50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7579790", Offset = "0x7578B90", VA = "0x187579790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7579A80", Offset = "0x7578E80", VA = "0x187579A80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public PGLIHLGLBPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x757B0E0", Offset = "0x757A4E0", VA = "0x18757B0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75761A0", Offset = "0x75755A0", VA = "0x1875761A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7576400", Offset = "0x7575800", VA = "0x187576400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75751A0", Offset = "0x75745A0", VA = "0x1875751A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7575380", Offset = "0x7574780", VA = "0x187575380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7570850", Offset = "0x756FC50", VA = "0x187570850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7570BC0", Offset = "0x756FFC0", VA = "0x187570BC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7575E50", Offset = "0x7575250", VA = "0x187575E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7576140", Offset = "0x7575540", VA = "0x187576140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OPNHEOOFELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7579EB0", Offset = "0x75792B0", VA = "0x187579EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7574910", Offset = "0x7573D10", VA = "0x187574910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7574B70", Offset = "0x7573F70", VA = "0x187574B70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7576460", Offset = "0x7575860", VA = "0x187576460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75765E0", Offset = "0x75759E0", VA = "0x1875765E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4629100", Offset = "0x4628500", VA = "0x184629100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4629360", Offset = "0x4628760", VA = "0x184629360", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7570000", Offset = "0x756F400", VA = "0x187570000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7570330", Offset = "0x756F730", VA = "0x187570330", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7577F20", Offset = "0x7577320", VA = "0x187577F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x75772B0", Offset = "0x75766B0", VA = "0x1875772B0")]
	public static bool DBIBJDPPFPE(this Task CBPINBDBDCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3539290", Offset = "0x3538690", VA = "0x183539290")]
	public static Task<T> PCGANDNMDMF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7577C10", Offset = "0x7577010", VA = "0x187577C10")]
	public static Task FPHOEOMNHME(this Task CBPINBDBDCO, CancellationToken LAAJFAFNFCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3536FD0", Offset = "0x35363D0", VA = "0x183536FD0")]
	public static Task<TResult> FPHOEOMNHME<TResult>(this Task<TResult> CBPINBDBDCO, CancellationToken LAAJFAFNFCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3538270", Offset = "0x3537670", VA = "0x183538270")]
	public static TaskCompletionSource<TResult> FPHOEOMNHME<TResult>(this TaskCompletionSource<TResult> KDHLGIELGNK, CancellationToken LAAJFAFNFCN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7576D60", Offset = "0x7576160", VA = "0x187576D60")]
	public static IDisposable? CFOLOEADPBN(CancellationToken CEHJDOBDHNG, CancellationToken MNDKJFHOICL, [Out] CancellationToken CGNGDAKFHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7577E70", Offset = "0x7577270", VA = "0x187577E70")]
	[AsyncStateMachine(typeof(EPDIFPGAFJI))]
	public static void GGIGANLPNID(this Task CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7578AB0", Offset = "0x7577EB0", VA = "0x187578AB0")]
	[AsyncStateMachine(typeof(JHPIJABEONO))]
	public static void JBJHPEMMGFD(this Task CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3534180", Offset = "0x3533580", VA = "0x183534180")]
	[AsyncStateMachine(typeof(FMNLJPKHHLP<>))]
	public static Task DJDFKKBGIFF<TException>(this Task CHBEBLKFDBC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3534430", Offset = "0x3533830", VA = "0x183534430")]
	[AsyncStateMachine(typeof(ICHLNFHEBAJ<>))]
	public static Task<T> EPGEFLBLNHI<T>(this Task<T> JDCFMPOHCEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7576FC0", Offset = "0x75763C0", VA = "0x187576FC0")]
	[AsyncStateMachine(typeof(FGEDKHAJKJC))]
	public static Task<TaskStatus> CMDBDDMPFIE(this Task? JDCFMPOHCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3539410", Offset = "0x3538810", VA = "0x183539410")]
	public static (Task<T?>?, Action<T?>?) PGPLJKNBEME<T>([Optional] CancellationToken LAEIHJHNGEK)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3539180", Offset = "0x3538580", VA = "0x183539180")]
	[AsyncStateMachine(typeof(PMJDNAAACLG<, >))]
	public static Task<List<TResult>> JNALEAHFFGF<TResult, TInput>(this Task<List<TInput>> CBPINBDBDCO, GKECAOJNLCF<TInput, TResult> AINMLNBGFAE) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75779F0", Offset = "0x7576DF0", VA = "0x1875779F0")]
	[AsyncStateMachine(typeof(PGBOFOHPEGI))]
	public static Task EOIDPFGNCFP(Task CHBEBLKFDBC, CancellationToken DGLOFFGGICM, Func<CancellationToken, Task> NMIMACLADGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7577F90", Offset = "0x7577390", VA = "0x187577F90")]
	[AsyncStateMachine(typeof(NEOPJJKEBGG))]
	public static Task HLJDFAKADLD(Func<CancellationToken, Task> KBKNECNKOFI, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken DGLOFFGGICM, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3538EE0", Offset = "0x35382E0", VA = "0x183538EE0")]
	[AsyncStateMachine(typeof(JAHDPALLJBB<>))]
	public static Task<T> HLJDFAKADLD<T>(Func<CancellationToken, Task<T>> KBKNECNKOFI, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken DGLOFFGGICM, [Optional] Func<OperationCanceledException, T>? DKPEONIFOAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75787F0", Offset = "0x7577BF0", VA = "0x1875787F0")]
	public static Task INPBCLDIHAO(params Task[] IIBLCKMDOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7578330", Offset = "0x7577730", VA = "0x187578330")]
	public static Task INPBCLDIHAO(IEnumerable<Task> IIBLCKMDOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3534340", Offset = "0x3533740", VA = "0x183534340")]
	[AsyncStateMachine(typeof(HHMGIHFCMJH<>))]
	public static Task<IEnumerable<Task<T>>> EJOHMFNEPGP<T>(IEnumerable<Task<T>> IIBLCKMDOMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3538C00", Offset = "0x3538000", VA = "0x183538C00")]
	[AsyncStateMachine(typeof(OFKHIKDOJIL<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> HBMBEEANKOM<T1, T2, T3, T4, T5>(Task<T1> OPLEABPIPHF, Task<T2> BDBGACCFBCA, Task<T3> ILJHLODIGKP, Task<T4> NEOPIEJCHHH, Task<T5> IEOGNBNACDC) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7577770", Offset = "0x7576B70", VA = "0x187577770")]
	[AsyncStateMachine(typeof(GDHDHPOCMMJ))]
	public static Task DKIKFMCMEEE(Func<bool> CMPFGFPGHEP, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7577660", Offset = "0x7576A60", VA = "0x187577660")]
	[AsyncStateMachine(typeof(OKKBCAACPHI))]
	public static Task DKIKFMCMEEE(Func<bool> CMPFGFPGHEP, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75780C0", Offset = "0x75774C0", VA = "0x1875780C0")]
	[AsyncStateMachine(typeof(OIIIFAPDHJG))]
	public static Task HNCJBDAKFIL(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75781F0", Offset = "0x75775F0", VA = "0x1875781F0")]
	[AsyncStateMachine(typeof(LIMDHCOJHAP))]
	public static Task HNCJBDAKFIL(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75770B0", Offset = "0x75764B0", VA = "0x1875770B0")]
	[AsyncStateMachine(typeof(KOECEGBPGKL))]
	public static Task DBFDANEECPK(Func<bool> CMPFGFPGHEP, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75771A0", Offset = "0x75765A0", VA = "0x1875771A0")]
	[AsyncStateMachine(typeof(BLBBDMHAANK))]
	public static Task DBFDANEECPK(Func<bool> CMPFGFPGHEP, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7578980", Offset = "0x7577D80", VA = "0x187578980")]
	[AsyncStateMachine(typeof(LFEJCHACHIN))]
	public static Task IPDGGOOCMOJ(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7578840", Offset = "0x7577C40", VA = "0x187578840")]
	[AsyncStateMachine(typeof(KIFLNDAOHIP))]
	public static Task IPDGGOOCMOJ(Func<bool> CMPFGFPGHEP, TimeSpan GAOGFDNIHEO, TimeSpan CKIKCBDDEJE, [Optional] CancellationToken LAEIHJHNGEK, [Optional] Action<OperationCanceledException>? DKPEONIFOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7577B20", Offset = "0x7576F20", VA = "0x187577B20")]
	[AsyncStateMachine(typeof(LMNNMIFIJEH))]
	[Obsolete]
	public static Task FPHCMGIIFOC(this Task CBPINBDBDCO, Action DOENJJAPOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3534610", Offset = "0x3533A10", VA = "0x183534610")]
	[Obsolete]
	[AsyncStateMachine(typeof(HKOFIPCGGGB<>))]
	public static Task FPHCMGIIFOC<T>(this Task<T> CBPINBDBDCO, Action<T> DOENJJAPOKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7578D50", Offset = "0x7578150", VA = "0x187578D50")]
	private static void OFDDMFNGCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75772E0", Offset = "0x75766E0", VA = "0x1875772E0")]
	public static bool DFEJCAHGGOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7577860", Offset = "0x7576C60", VA = "0x187577860")]
	private static void EDIFPFLMLOK(SynchronizationContext KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7576C40", Offset = "0x7576040", VA = "0x187576C40")]
	private static void AHJCJBPABOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7578BB0", Offset = "0x7577FB0", VA = "0x187578BB0")]
	public static void LMMEMAKKGHF([Optional] string? MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7578CD0", Offset = "0x75780D0", VA = "0x187578CD0")]
	public static void NHCIGNDBOPI([Optional] string? MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7578B60", Offset = "0x7577F60", VA = "0x187578B60")]
	public static HEPMKLNOCMM JPHBHAMHOGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7578C80", Offset = "0x7578080", VA = "0x187578C80")]
	public static HEPMKLNOCMM MABCAGOLEJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7576EF0", Offset = "0x75762F0", VA = "0x187576EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7574530", Offset = "0x7573930", VA = "0x187574530", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset CGBMDOHBNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7574570", Offset = "0x7573970", VA = "0x187574570", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75711E0", Offset = "0x75705E0", VA = "0x1875711E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7571190", Offset = "0x7570590", VA = "0x187571190")]
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
		[Cpp2IlInjected.Address(RVA = "0x7571010", Offset = "0x7570410", VA = "0x187571010")]
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
		[Cpp2IlInjected.Address(RVA = "0x7571060", Offset = "0x7570460", VA = "0x187571060")]
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
		[Cpp2IlInjected.Address(RVA = "0x75710B0", Offset = "0x75704B0", VA = "0x1875710B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7571230", Offset = "0x7570630", VA = "0x187571230")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7570EF0", Offset = "0x75702F0", VA = "0x187570EF0")]
	public static double BCMMFCPIOLG(long LFMBKPMGKOG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7570E60", Offset = "0x7570260", VA = "0x187570E60")]
	public static double AJFCKPFKKLM(long LFMBKPMGKOG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7570F80", Offset = "0x7570380", VA = "0x187570F80")]
	public static double DPEBKEBKLPO(double COLOJIGPMOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7571100", Offset = "0x7570500", VA = "0x187571100")]
	public static long KCABPHHCAGE(long HKPDGGGHFLH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75713B0", Offset = "0x75707B0", VA = "0x1875713B0")]
	public static long PJHDDCBHGNL(long AMGOMNPILGK, long CFNKJPDDIBL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x75712E0", Offset = "0x75706E0", VA = "0x1875712E0")]
	public static double OGHPMOLNBGF(long AMGOMNPILGK, long CFNKJPDDIBL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7571280", Offset = "0x7570680", VA = "0x187571280")]
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
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x756EE70", Offset = "0x756E270", VA = "0x18756EE70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? FMHJFKJNACC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x756F2B0", Offset = "0x756E6B0", VA = "0x18756F2B0")]
	[Preserve]
	public AKFFMIEAANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x756F320", Offset = "0x756E720", VA = "0x18756F320")]
	public AKFFMIEAANC(TimeSpan GAOGFDNIHEO, [Optional] Action? NKLPHAMEBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x756F0A0", Offset = "0x756E4A0", VA = "0x18756F0A0", Slot = "7")]
	public void EKFPEOGCKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x756F1D0", Offset = "0x756E5D0", VA = "0x18756F1D0", Slot = "8")]
	public void NAMALBDACEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x756F070", Offset = "0x756E470", VA = "0x18756F070", Slot = "9")]
	public void EDANFFCKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xF4F410", Offset = "0xF4E810", VA = "0x180F4F410")]
	private void HKMGIIOKFFF(object MEBAFDHEDIN, ElapsedEventArgs OFKHIFOCFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x756F130", Offset = "0x756E530", VA = "0x18756F130")]
	private static void IBPLEMEDCOF(TimeSpan FINJMKGCPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x756EFD0", Offset = "0x756E3D0", VA = "0x18756EFD0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F51EF0", Offset = "0x6F512F0", VA = "0x186F51EF0")]
	public CGDEHPHFPEN(string GPFCOHGCDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4963E60", Offset = "0x4963260", VA = "0x184963E60")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BE8ED0", Offset = "0x1BE82D0", VA = "0x181BE8ED0")]
	public static GJIJKFCGDLH AIPMJCEFMJP(uint NNDPJAAGGOH)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1BE8ED0", Offset = "0x1BE82D0", VA = "0x181BE8ED0")]
	public static GJIJKFCGDLH LDMHOCFECCD(int IKNLPEMHPGP)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7573340", Offset = "0x7572740", VA = "0x187573340")]
	public static GJIJKFCGDLH GKHFHDIILBE(float FFMJPGOAJHD)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7573350", Offset = "0x7572750", VA = "0x187573350")]
	public static GJIJKFCGDLH PINKMABAHKI(byte NGLKNKHGNKN, byte FIJNKKJOHEO, byte GDCBKFMMJKE, byte DFJMJEEPPNK)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7573350", Offset = "0x7572750", VA = "0x187573350")]
	public static GJIJKFCGDLH PGMAGJKHJHM(bool OADEIDGOPOM, bool CAKKHPCINEC, bool PKNFOGGJBMN, bool EELLPBBHIJA)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7573350", Offset = "0x7572750", VA = "0x187573350")]
	public static GJIJKFCGDLH IIGLDJPIPCM(byte GPHMKDIFDJE, byte KLHCFCMCFBP, byte BILHHPDPNDO, byte IKFNCGDNKJB)
	{
		return default(GJIJKFCGDLH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1ED92F0", Offset = "0x1ED86F0", VA = "0x181ED92F0")]
	public static bool BFIJCNNIIMH(GJIJKFCGDLH CLHNCHKFPON, GJIJKFCGDLH KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1ED92D0", Offset = "0x1ED86D0", VA = "0x181ED92D0", Slot = "4")]
	public bool Equals(GJIJKFCGDLH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x75732B0", Offset = "0x75726B0", VA = "0x1875732B0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x10DA510", Offset = "0x10D9910", VA = "0x1810DA510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7573370", Offset = "0x7572770", VA = "0x187573370", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static GLPFNPEIIHN FEOBEKOIKMG(long AHJOGHGHDEG)
	{
		return default(GLPFNPEIIHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7574230", Offset = "0x7573630", VA = "0x187574230")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B95D20", Offset = "0x2B95120", VA = "0x182B95D20")]
	public static BHPPLCNANNG PINKMABAHKI(byte IDGMDIFONML)
	{
		return default(BHPPLCNANNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2B95D20", Offset = "0x2B95120", VA = "0x182B95D20")]
	public static BHPPLCNANNG PGMAGJKHJHM(bool NCBAJNLNANA)
	{
		return default(BHPPLCNANNG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7570530", Offset = "0x756F930", VA = "0x187570530")]
	public static bool BFIJCNNIIMH(BHPPLCNANNG CLHNCHKFPON, BHPPLCNANNG KMNANLEEDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x65EC4D0", Offset = "0x65EB8D0", VA = "0x1865EC4D0", Slot = "4")]
	public bool Equals(BHPPLCNANNG OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7570540", Offset = "0x756F940", VA = "0x187570540", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x75705D0", Offset = "0x756F9D0", VA = "0x1875705D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x75705E0", Offset = "0x756F9E0", VA = "0x1875705E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x45D8430", Offset = "0x45D7830", VA = "0x1845D8430")]
	public HEPNFICAOMF(T PHJPLEGILCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class GHOMAPGDOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x337FE30", Offset = "0x337F230", VA = "0x18337FE30")]
	public static IEnumerable<T> LDBJMCKLCFG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static T[] KGLCBADJGBJ<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
	public static IEnumerable<T> LKAAJFMCAPF<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
	public static HashSet<T> BOALNEJLEFJ<T>(params T[] MFOCOGLCAEP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3396B30", Offset = "0x3395F30", VA = "0x183396B30")]
	public static KeyValuePair<TKey, TValue> CPIDDLGIMOI<TKey, TValue>([In] TKey LKMGECEEGEE, [In] TValue KBGCCIOIGBD) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3152A20", Offset = "0x3151E20", VA = "0x183152A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
	[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75753E0", Offset = "0x75747E0", VA = "0x1875753E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7575CD0", Offset = "0x75750D0", VA = "0x187575CD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7572CD0", Offset = "0x75720D0", VA = "0x187572CD0")]
	public static Task<bool> CJHDAIMAKPI(int EPHEKOIBELL, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7572FE0", Offset = "0x75723E0", VA = "0x187572FE0")]
	[AsyncStateMachine(typeof(LDCGDADKIJC))]
	private static Task<bool> DGMDLJGMPMG(int EPHEKOIBELL, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7572C40", Offset = "0x7572040", VA = "0x187572C40")]
	private static void AIAHIJPFMFI(object? CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7573110", Offset = "0x7572510", VA = "0x187573110")]
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
