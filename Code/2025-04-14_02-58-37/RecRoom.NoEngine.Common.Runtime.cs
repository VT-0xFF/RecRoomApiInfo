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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A26580", Offset = "0x7A24F80", VA = "0x187A26580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KEOJJJNCPDH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A20B90", Offset = "0x7A1F590", VA = "0x187A20B90")]
	public static string APGCIBCFEHL(this Encoding OMMPPEDOHBO, [In] ReadOnlySequence<byte> OHAFLBCBHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x370E550", Offset = "0x370CF50", VA = "0x18370E550")]
	private static void IBFNGDBJMGB<T>(this ReadOnlySequence<T> EHMCDCMCIPF, [Out] ReadOnlySpan<T> JNCCEEOHHNF, [Out] SequencePosition FGHNEGLCMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class HINGIOHFBBG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FC40", Offset = "0x7A1E640", VA = "0x187A1FC40")]
	public HINGIOHFBBG(bool HDBJMOPLPBB, string CAMJLNGHDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FD10", Offset = "0x7A1E710", VA = "0x187A1FD10")]
	public HINGIOHFBBG(bool HDBJMOPLPBB, params string[] NIEBNGHLCLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LNCMBHPHMLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KDJBHOBPKHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HLMDOGFBJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFJHIKMOLHJ(string NJBPFCDJFGD, double PPJFMHBDGNA, [Optional] string? ECLIPMGACIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LKKGGMCABKE : COKFCCGFBLK, JGIABCHHNAM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KIEEDENGFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> PDFFIBJEAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double ODPANEHCOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double AIHFEHEPHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double APEHPBDHGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MLCKEMGJEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double JBINJMPCMOP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DLENJCCKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9CB660", Offset = "0x9CA060", VA = "0x1809CB660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double ODLMHHNAJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A240C0", Offset = "0x7A22AC0", VA = "0x187A240C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BHLPOEGHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4950BE0", Offset = "0x494F5E0", VA = "0x184950BE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double FLPGJMFMIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x26390A0", Offset = "0x2637AA0", VA = "0x1826390A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A24190", Offset = "0x7A22B90", VA = "0x187A24190")]
	public LKKGGMCABKE(int EGLIEFMDHNG, double JBINJMPCMOP = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A23F90", Offset = "0x7A22990", VA = "0x187A23F90", Slot = "7")]
	public void GGBEDAAHJKN(double OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A24120", Offset = "0x7A22B20", VA = "0x187A24120", Slot = "8")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A23E90", Offset = "0x7A22890", VA = "0x187A23E90", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class EFNDMLMPIGH : COKFCCGFBLK, JGIABCHHNAM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long PGJKBFGEJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double CDBMLLCIKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double KPMNBPBINEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double PKODEKMEEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double DPDPLKILKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double ODPANEHCOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double AIHFEHEPHFF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BHLPOEGHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A2B0", Offset = "0x6D28CB0", VA = "0x186D2A2B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double FLPGJMFMIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A2C0", Offset = "0x6D28CC0", VA = "0x186D2A2C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FKNPBPOIAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A340", Offset = "0x6D28D40", VA = "0x186D2A340")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ODLMHHNAJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE8D0", Offset = "0x2CDD2D0", VA = "0x182CDE8D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D4E0", Offset = "0x7A1BEE0", VA = "0x187A1D4E0", Slot = "10")]
	public virtual void GGBEDAAHJKN(double OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D600", Offset = "0x7A1C000", VA = "0x187A1D600", Slot = "11")]
	public virtual void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D470", Offset = "0x7A1BE70", VA = "0x187A1D470", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D640", Offset = "0x7A1C040", VA = "0x187A1D640")]
	public EFNDMLMPIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FDCKLIHECFL : EFNDMLMPIGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double IDLLJEJKHKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A330", Offset = "0x6D28D30", VA = "0x186D2A330")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D29E50", Offset = "0x6D28850", VA = "0x186D29E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E240", Offset = "0x7A1CC40", VA = "0x187A1E240", Slot = "10")]
	public override void GGBEDAAHJKN(double OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E370", Offset = "0x7A1CD70", VA = "0x187A1E370", Slot = "11")]
	public override void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D640", Offset = "0x7A1C040", VA = "0x187A1D640")]
	public FDCKLIHECFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface COKFCCGFBLK : JGIABCHHNAM, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double ODLMHHNAJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BHLPOEGHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double FLPGJMFMIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MPOMALEEHDI : JGIABCHHNAM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double GBHCIPBEKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double HGDCIABDHGG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7A24D50", Offset = "0x7A23750", VA = "0x187A24D50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7981B30", Offset = "0x7980530", VA = "0x187981B30", Slot = "4")]
	public void GGBEDAAHJKN(double OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A24D60", Offset = "0x7A23760", VA = "0x187A24D60", Slot = "5")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A24D00", Offset = "0x7A23700", VA = "0x187A24D00", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MPOMALEEHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGIABCHHNAM : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGBEDAAHJKN(double OILNFPPOKDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPIOKFDHGCP();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DPFPIECLDJM : JGIABCHHNAM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double PPJFMHBDGNA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4400700", Offset = "0x43FF100", VA = "0x184400700")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5179DA0", Offset = "0x51787A0", VA = "0x185179DA0", Slot = "4")]
	public void GGBEDAAHJKN(double OILNFPPOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D460", Offset = "0x7A1BE60", VA = "0x187A1D460", Slot = "5")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D410", Offset = "0x7A1BE10", VA = "0x187A1D410", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public DPFPIECLDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FAIEGDPIBGA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> DGPANLOPBHA(CancellationToken BJEPDCCBCHJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EKDCOLEFLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FAIEGDPIBGA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DGPANLOPBHA taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x436C7B0", Offset = "0x436B1B0", VA = "0x18436C7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x436D870", Offset = "0x436C270", VA = "0x18436D870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource DBBALKKKOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? HJEOKOPHGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? KFEOEGDGONL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47A7EE0", Offset = "0x47A68E0", VA = "0x1847A7EE0")]
	[AsyncStateMachine(typeof(FAIEGDPIBGA<>.EKDCOLEFLDP))]
	public Task<TResult> BJINCAMIHJA(DGPANLOPBHA HGMHMDLMMLG, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x47A8020", Offset = "0x47A6A20", VA = "0x1847A8020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47A8090", Offset = "0x47A6A90", VA = "0x1847A8090")]
	public FAIEGDPIBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JBPMKLJFBCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> EOFPBENOABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T ABKPALEDJBA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x436E520", Offset = "0x436CF20", VA = "0x18436E520")]
	public JBPMKLJFBCN([In] T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CD40", Offset = "0x4C8B740", VA = "0x184C8CD40", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D450", Offset = "0x4C8BE50", VA = "0x184C8D450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D6A0", Offset = "0x4C8C0A0", VA = "0x184C8D6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IJCPBOJNDOO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static JBPMKLJFBCN<T> DDDHPONDPCL<T>([In] T PPJFMHBDGNA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KPGAEEODAFB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7A236B0", Offset = "0x7A220B0", VA = "0x187A236B0")]
	public static void ANFFJAIBFJJ(this CancellationTokenSource DBBALKKKOMJ, bool LFHJAOBIBPJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class AMAFNLLCELH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public AMAFNLLCELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class OJHKKHAABNM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public OJHKKHAABNM(string NBOLPJIPKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CLFMPNDAPBL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3424B30", Offset = "0x3423530", VA = "0x183424B30")]
	public static DJOAHGAECFA EOFGFLGAAJG<T>()
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3424910", Offset = "0x3423310", VA = "0x183424910")]
	public static DJOAHGAECFA DNMPBCMHOPL<T>([CallerMemberName] string EMLAIMJKHOE = "") where T : notnull
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3424AB0", Offset = "0x34234B0", VA = "0x183424AB0")]
	public static DJOAHGAECFA EOFGFLGAAJG<T>(this T FOAJJFFCIFO) where T : notnull
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3424BB0", Offset = "0x34235B0", VA = "0x183424BB0")]
	public static DJOAHGAECFA IFIFADJHGCP<T>(this T FOAJJFFCIFO, [CallerMemberName] string EMLAIMJKHOE = "") where T : notnull
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3424860", Offset = "0x3423260", VA = "0x183424860")]
	public static DJOAHGAECFA DNMPBCMHOPL<T>(this T IJPDNJELPLO, [CallerMemberName] string EMLAIMJKHOE = "") where T : notnull
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C8F0", Offset = "0x7A1B2F0", VA = "0x187A1C8F0")]
	public static DJOAHGAECFA DNMPBCMHOPL(string PEBAKOHOBMG, [CallerMemberName] string EMLAIMJKHOE = "")
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7A1C970", Offset = "0x7A1B370", VA = "0x187A1C970")]
	public static string JLMKCKMBMHK(this object IJPDNJELPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool OHCBMDKGEEM();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AMAFNLLCELH]
public delegate long HCHLHHCHCLP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AJHNMJGDJME
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static JLOJEOAILNO MDAJFNJLLME;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JLOJEOAILNO CGBEBHLOGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B010", Offset = "0x7A19A10", VA = "0x187A1B010")]
		get
		{
			return default(JLOJEOAILNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static EPPLEODGPIB DKEKLFAJDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B2B0", Offset = "0x7A19CB0", VA = "0x187A1B2B0")]
		get
		{
			return default(EPPLEODGPIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NPBBKEMMBPE JJOIELDLBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B370", Offset = "0x7A19D70", VA = "0x187A1B370")]
		get
		{
			return default(NPBBKEMMBPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool MIFBMPCDHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1B060", Offset = "0x7A19A60", VA = "0x187A1B060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7A1ADD0", Offset = "0x7A197D0", VA = "0x187A1ADD0")]
	public static void CLGAJCJPMGA([In] JLOJEOAILNO DLOJKMPINDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B0D0", Offset = "0x7A19AD0", VA = "0x187A1B0D0")]
	public static void HIMKLMLGBHH(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7A1AD00", Offset = "0x7A19700", VA = "0x187A1AD00")]
	public static void CDNOHIHAHHE(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD090", Offset = "0x3DABA90", VA = "0x183DAD090")]
	public static void CDNOHIHAHHE<T>(T JDKFBOCIIAB, KINIKDIFNPM<T> FLPDJFEEMLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7A1AF70", Offset = "0x7A19970", VA = "0x187A1AF70")]
	public static void CLPKDMBMKJM(Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A1AC80", Offset = "0x7A19680", VA = "0x187A1AC80")]
	public static void BIFFEBNDHMD(string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B300", Offset = "0x7A19D00", VA = "0x187A1B300")]
	public static void OPIHGCFGFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B240", Offset = "0x7A19C40", VA = "0x187A1B240")]
	public static string JLMKCKMBMHK(object OIIGDBLKEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7A1AB40", Offset = "0x7A19540", VA = "0x187A1AB40")]
	public static long AKKMCBCFMLA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B1A0", Offset = "0x7A19BA0", VA = "0x187A1B1A0")]
	public static bool JBKGDPBMDEB(bool GFLFPOCDIEJ, string FLPDJFEEMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1ABB0", Offset = "0x7A195B0", VA = "0x187A1ABB0")]
	public static double BAHCJJKKPNO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct JLOJEOAILNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EPPLEODGPIB DKEKLFAJDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly NPBBKEMMBPE JJOIELDLBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ILHJEINBHJG OFKAPBEFEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly HCHLHHCHCLP GBNJAADAKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly BMPEABOIONL EDFEJGFOECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly OHCBMDKGEEM MIAIKIBANEA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ILHJEINBHJG ALCHIIBKCCE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HCHLHHCHCLP EKOFKIJAAGO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BMPEABOIONL JMFNIOHKGON;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly OHCBMDKGEEM DDLNAELKGMP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly JLOJEOAILNO KPJGFDDMHFP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A20140", Offset = "0x7A1EB40", VA = "0x187A20140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A209D0", Offset = "0x7A1F3D0", VA = "0x187A209D0")]
	public JLOJEOAILNO([In] EPPLEODGPIB DMBALONODMF, [In] NPBBKEMMBPE ILBJLNOFIKM, ILHJEINBHJG JAKDLMLNJEF, HCHLHHCHCLP IHFIFPMKJGL, BMPEABOIONL HCKKPFCNDPD, OHCBMDKGEEM JCIEKECECDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7A202D0", Offset = "0x7A1ECD0", VA = "0x187A202D0")]
	private static string MFAIAHHNAMC(object OIIGDBLKEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
	private static long LOMDCDBJGFH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	private static string MLGMBECJLCH(string FHBIJDIKBHA, string? FMDFMHFHDKP, bool PHCEKMHDFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	private static bool HHALOMIDFKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7A20040", Offset = "0x7A1EA40", VA = "0x187A20040")]
	private static JLOJEOAILNO FJEGBCCJIJP()
	{
		return default(JLOJEOAILNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DNEDHILCKMI
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGKCGDOMLAG FJPAAICMOHL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EGKCGDOMLAG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PENNPAPDBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNBDOLAHJI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MIOHJJIPPAJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFIADALNOFP([In] T OLKLGHOAKNE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void GGKMHDMCCJH<T>([In] T JDKFBOCIIAB);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct JJEGHLDJHEO<T> : IEquatable<JJEGHLDJHEO<T>>, MIOHJJIPPAJ<JJEGHLDJHEO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T ABKPALEDJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int LIGNGKONFNM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x26C3230", Offset = "0x26C1C30", VA = "0x1826C3230")]
	public JJEGHLDJHEO([In] T PPJFMHBDGNA, int DOAKEFBOPIA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9F90", Offset = "0x4CC8990", VA = "0x184CC9F90")]
	public static bool HFGMMLFJJJB([In] JJEGHLDJHEO<T> AKJAPDOPIOF, [In] JJEGHLDJHEO<T> CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9410", Offset = "0x4CC7E10", VA = "0x184CC9410", Slot = "4")]
	public bool Equals(JJEGHLDJHEO<T> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9380", Offset = "0x4CC7D80", VA = "0x184CC9380", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4CCA410", Offset = "0x4CC8E10", VA = "0x184CCA410")]
	public bool NFIADALNOFP([In] JJEGHLDJHEO<T> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4CC99B0", Offset = "0x4CC83B0", VA = "0x184CC99B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4CCAA00", Offset = "0x4CC9400", VA = "0x184CCAA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4CC8E60", Offset = "0x4CC7860", VA = "0x184CC8E60")]
	public void EHJACGLEOBL([Out] T PPJFMHBDGNA, [Out] int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9620", Offset = "0x4CC8020", VA = "0x184CC9620")]
	public (T, int) FIIFLPCCFLL()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4CC8AA0", Offset = "0x4CC74A0", VA = "0x184CC8AA0", Slot = "5")]
	private bool BBIONAOBEAE([In] JJEGHLDJHEO<T> OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FCBINPABJKC
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x361CB70", Offset = "0x361B570", VA = "0x18361CB70")]
	public static JJEGHLDJHEO<T> DDDHPONDPCL<T>([In] T PPJFMHBDGNA, int DOAKEFBOPIA) where T : notnull
	{
		return default(JJEGHLDJHEO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NMGOHIDLDEG
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x37F0890", Offset = "0x37EF290", VA = "0x1837F0890")]
	public static bool NFIADALNOFP<T, U>([In] T IJPDNJELPLO, [In] U OIIGDBLKEDN) where T : notnull, MIOHJJIPPAJ<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult HHNKKJKJOPB<T, out TResult>([In] T JDKFBOCIIAB);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HIIAIILFNPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan JLPOFHPHONG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? OAGAICCLIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBHBHBLMGNA();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCMDCKGEGBE();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIEPMDDMFPH();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EPPLEODGPIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly HEKANNAPAAH JOEBEGKOHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly OCMHJCHDOCB NLPOJGNKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HEKANNAPAAH NFJGDLMEKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly OCMHJCHDOCB CBGONLEGNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HEKANNAPAAH BNJPLHPOPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly OCMHJCHDOCB OLPDMOBNOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly MOPCOJHBHOD HPKBOCMGDNI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly HEKANNAPAAH OJIPPLDDEHI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OCMHJCHDOCB GIFOKCCEMFG;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly HEKANNAPAAH BIKCBCODPGJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OCMHJCHDOCB HFNPGKNILNI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly HEKANNAPAAH OLADAIKAOGH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly OCMHJCHDOCB IGAAGBDCIFB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MOPCOJHBHOD LOEEJAAJGAK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EPPLEODGPIB KPJGFDDMHFP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HEKANNAPAAH DCDBACFODDG;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7A1DAB0", Offset = "0x7A1C4B0", VA = "0x187A1DAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xCFA240", Offset = "0xCF8C40", VA = "0x180CFA240")]
	public EPPLEODGPIB(HEKANNAPAAH NKEMKOAOBAK, OCMHJCHDOCB EIFAHJPMAEO, HEKANNAPAAH KEOKELGHCCL, OCMHJCHDOCB KKBPGHPBDNK, HEKANNAPAAH DCMOGGEIHHP, OCMHJCHDOCB DPIMIENLFCI, MOPCOJHBHOD HNCJDBOLGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	private static bool DHADJFMAFED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void KGCACBOOPBK(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	private static bool FFPALJOPMLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void PHPPDKKJICM(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	private static bool CNKCDEGBIBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void BIGOGOHLPOI(string FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void AEAOGGODAOG(Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D7C0", Offset = "0x7A1C1C0", VA = "0x187A1D7C0")]
	private static EPPLEODGPIB FJEGBCCJIJP()
	{
		return default(EPPLEODGPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
	private static bool OJOBLEDGDMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D900", Offset = "0x7A1C300", VA = "0x187A1D900")]
	public void HIMKLMLGBHH(object FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D970", Offset = "0x7A1C370", VA = "0x187A1D970")]
	public void JAOKPHPFAMM(object FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D670", Offset = "0x7A1C070", VA = "0x187A1D670")]
	public void CDNOHIHAHHE(object FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCF41F0", Offset = "0xCF2BF0", VA = "0x180CF41F0")]
	public void CLPKDMBMKJM(Exception GKNCIBMNAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D6E0", Offset = "0x7A1C0E0", VA = "0x187A1D6E0")]
	public void CDNOHIHAHHE(IFJMDKILFGB FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34D5E60", Offset = "0x34D4860", VA = "0x1834D5E60")]
	public void CDNOHIHAHHE<T>(T JDKFBOCIIAB, KINIKDIFNPM<T> FLPDJFEEMLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x34D5F30", Offset = "0x34D4930", VA = "0x1834D5F30")]
	public void HIMKLMLGBHH<T>([In] T JDKFBOCIIAB, ELDIFBAKPHP<T> FLPDJFEEMLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x34D5BF0", Offset = "0x34D45F0", VA = "0x1834D5BF0")]
	public void CDNOHIHAHHE<T>([In] T JDKFBOCIIAB, ELDIFBAKPHP<T> FLPDJFEEMLN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D9E0", Offset = "0x7A1C3E0", VA = "0x187A1D9E0")]
	public bool JBKGDPBMDEB(bool GFLFPOCDIEJ, string FLPDJFEEMLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DJOAHGAECFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string ABKPALEDJBA;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	public DJOAHGAECFA(string PPJFMHBDGNA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
	public static string MEHFEEABIDG([In] DJOAHGAECFA IJPDNJELPLO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x21B2D10", Offset = "0x21B1710", VA = "0x1821B2D10")]
	public static DJOAHGAECFA MEHFEEABIDG(string OLKLGHOAKNE)
	{
		return default(DJOAHGAECFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D020", Offset = "0x7A1BA20", VA = "0x187A1D020")]
	public string DFFCAEDGEHN(string AIGJNKAMLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7A1D070", Offset = "0x7A1BA70", VA = "0x187A1D070")]
	public string PPBBBPHGFME(object OGGGEAPKCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class PCEAOLEFKHH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public PCEAOLEFKHH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct HGCBNLHKPOI : IEquatable<HGCBNLHKPOI>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "4")]
	public bool Equals(HGCBNLHKPOI OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FBB0", Offset = "0x7A1E5B0", VA = "0x187A1FBB0", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FC00", Offset = "0x7A1E600", VA = "0x187A1FC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FC10", Offset = "0x7A1E610", VA = "0x187A1FC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DACJCFOLAGM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MAJJMDFECCC<T> : IEquatable<MAJJMDFECCC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T ABKPALEDJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool CJAADLKEMGM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool CFLBFGKJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5121D00", Offset = "0x5120700", VA = "0x185121D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51225B0", Offset = "0x5120FB0", VA = "0x1851225B0")]
	public MAJJMDFECCC([In] T PPJFMHBDGNA, bool EHIMBFBHPCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51219A0", Offset = "0x51203A0", VA = "0x1851219A0")]
	public static bool HFGMMLFJJJB([In] MAJJMDFECCC<T> AKJAPDOPIOF, [In] MAJJMDFECCC<T> CPKHJEJFIJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5120630", Offset = "0x511F030", VA = "0x185120630", Slot = "4")]
	public bool Equals(MAJJMDFECCC<T> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5120B50", Offset = "0x511F550", VA = "0x185120B50", Slot = "0")]
	public override bool Equals(object? OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5121140", Offset = "0x511FB40", VA = "0x185121140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5122320", Offset = "0x5120D20", VA = "0x185122320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NFPGCIHIPLK
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x37E2220", Offset = "0x37E0C20", VA = "0x1837E2220")]
	public static MAJJMDFECCC<T> DBMLPBEDPJK<T>([In] T PPJFMHBDGNA) where T : notnull
	{
		return default(MAJJMDFECCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x37E2620", Offset = "0x37E1020", VA = "0x1837E2620")]
	public static MAJJMDFECCC<T?> JPKNCAEPNDP<T>()
	{
		return default(MAJJMDFECCC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x37E23F0", Offset = "0x37E0DF0", VA = "0x1837E23F0")]
	public static bool FMEKCNDAPEK<T>([In] this MAJJMDFECCC<T> ACBHINPFFCB, [Out][NotNullWhen(true)] T PPJFMHBDGNA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37E2380", Offset = "0x37E0D80", VA = "0x1837E2380")]
	public static bool FMEKCNDAPEK<T>([In] this MAJJMDFECCC<T> ACBHINPFFCB, [Out][NotNullWhen(true)] T PPJFMHBDGNA, [Out] MAJJMDFECCC<T> DMBIEAFFKGC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37E2320", Offset = "0x37E0D20", VA = "0x1837E2320")]
	public static T? FHBCBHKKCDM<T>([In] this MAJJMDFECCC<T> ACBHINPFFCB, T? LPJIMLBFHAO)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37E2420", Offset = "0x37E0E20", VA = "0x1837E2420")]
	public static bool GEDFEDCMMCB<T>([In] this MAJJMDFECCC<T> ACBHINPFFCB, T PPJFMHBDGNA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HCAACDMPILI
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3673C10", Offset = "0x3672610", VA = "0x183673C10")]
	public static T IGMFDJEOJJG<T>([In] this MAJJMDFECCC<T> ACBHINPFFCB) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NPBBKEMMBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr BIFFEBNDHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr OPIHGCFGFIC;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr EJJCJFIKMFH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr IPGGLNDOMJI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly NPBBKEMMBPE KPJGFDDMHFP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool DDFCNJDHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A26370", Offset = "0x7A24D70", VA = "0x187A26370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	public NPBBKEMMBPE(IntPtr DPNPLGFPPMC, IntPtr MBLCNFNEDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void CAGIKJOPPMH(string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void KCIOPINCBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7A262E0", Offset = "0x7A24CE0", VA = "0x187A262E0")]
	private static NPBBKEMMBPE FJEGBCCJIJP()
	{
		return default(NPBBKEMMBPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct JDLGLIIMOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr HFMJGMGMEDH;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
	private JDLGLIIMOML(IntPtr MBLCNFNEDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FF40", Offset = "0x7A1E940", VA = "0x187A1FF40")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FF60", Offset = "0x7A1E960", VA = "0x187A1FF60")]
	public static JDLGLIIMOML DDDHPONDPCL(string EMLAIMJKHOE)
	{
		return default(JDLGLIIMOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x269CCA0", Offset = "0x269B6A0", VA = "0x18269CCA0")]
	public static JDLGLIIMOML DDDHPONDPCL([In] NPBBKEMMBPE ILBJLNOFIKM, string EMLAIMJKHOE)
	{
		return default(JDLGLIIMOML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x269CD20", Offset = "0x269B720", VA = "0x18269CD20")]
	public static JDLGLIIMOML DDDHPONDPCL([In] NPBBKEMMBPE ILBJLNOFIKM, Func<string> EMLAIMJKHOE)
	{
		return default(JDLGLIIMOML);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KFIMMNOFOPE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool CPNNAMBKDHE<in TInput, TResult>(TInput OBMEHBOBMDK, [Out] TResult FFBEKAFHIDB);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class FIAGHHCHBFB : DNEDHILCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class LIMNPJKPDPD : EGKCGDOMLAG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly LIMNPJKPDPD LALLOKGAEJH;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool PENNPAPDBNH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x7A23C70", Offset = "0x7A22670", VA = "0x187A23C70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7A23CD0", Offset = "0x7A226D0", VA = "0x187A23CD0", Slot = "6")]
			public void OnCompleted(Action FBBDJNOOBND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			public void DJNBDOLAHJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public LIMNPJKPDPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly FIAGHHCHBFB LALLOKGAEJH;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		private FIAGHHCHBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7A1E490", Offset = "0x7A1CE90", VA = "0x187A1E490", Slot = "4")]
		public EGKCGDOMLAG FJPAAICMOHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class NLLHAEKDNJM : DNEDHILCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class FFKBMDJGKPC : EGKCGDOMLAG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly FFKBMDJGKPC LALLOKGAEJH;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool PENNPAPDBNH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x7A1E3B0", Offset = "0x7A1CDB0", VA = "0x187A1E3B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7A1E3D0", Offset = "0x7A1CDD0", VA = "0x187A1E3D0", Slot = "6")]
			public void OnCompleted(Action FBBDJNOOBND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			public void DJNBDOLAHJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public FFKBMDJGKPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly NLLHAEKDNJM LALLOKGAEJH;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		private NLLHAEKDNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7A259D0", Offset = "0x7A243D0", VA = "0x187A259D0", Slot = "4")]
		public EGKCGDOMLAG FJPAAICMOHL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CPDGDGCINHH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CPDGDGCINHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4360D40", Offset = "0x435F740", VA = "0x184360D40")]
		internal void MCOODNAJGNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NKOAHHDCPAJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public NKOAHHDCPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x51AC660", Offset = "0x51AB060", VA = "0x1851AC660")]
		internal void LOJHOBBOJGG(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GFPGKGJDIGN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1F4B0", Offset = "0x7A1DEB0", VA = "0x187A1F4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct ONEGIOGFIHH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A26600", Offset = "0x7A25000", VA = "0x187A26600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct GPGFPNLMOEJ<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x48FE290", Offset = "0x48FCC90", VA = "0x1848FE290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x48FE400", Offset = "0x48FCE00", VA = "0x1848FE400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DNECGFAGAOK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x3F29460", Offset = "0x3F27E60", VA = "0x183F29460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F29890", Offset = "0x3F28290", VA = "0x183F29890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DEMOBNNKPLN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1CA10", Offset = "0x7A1B410", VA = "0x187A1CA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7A1CC20", Offset = "0x7A1B620", VA = "0x187A1CC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class EIAFKCEDJCC<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EIAFKCEDJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4360D40", Offset = "0x435F740", VA = "0x184360D40")]
		internal void HAICKLIDLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4360CC0", Offset = "0x435F6C0", VA = "0x184360CC0")]
		internal void BKDFFEBOPNG(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct NOCDEAFKEJL<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public CPNNAMBKDHE<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x51C4600", Offset = "0x51C3000", VA = "0x1851C4600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x51C4D10", Offset = "0x51C3710", VA = "0x1851C4D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NOGCKIGPKCC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A25A90", Offset = "0x7A24490", VA = "0x187A25A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7A26280", Offset = "0x7A24C80", VA = "0x187A26280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct HDKBHNDNHID : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1F610", Offset = "0x7A1E010", VA = "0x187A1F610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FB50", Offset = "0x7A1E550", VA = "0x187A1FB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KNBFPFGDDAG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E22480", Offset = "0x4E20E80", VA = "0x184E22480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4D1B8A0", Offset = "0x4D1A2A0", VA = "0x184D1B8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JMGBBDJMBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<HGCBNLHKPOI> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JMGBBDJMBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7A20A80", Offset = "0x7A1F480", VA = "0x187A20A80")]
		internal void CFHELGPFPBL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct BOIPLOLCMKO<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x64B6720", Offset = "0x64B5120", VA = "0x1864B6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5090", Offset = "0x3EB3A90", VA = "0x183EB5090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct NMNGELOFIPL<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x51BD1F0", Offset = "0x51BBBF0", VA = "0x1851BD1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x51BE0F0", Offset = "0x51BCAF0", VA = "0x1851BE0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct LDMJJGOFCOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A236E0", Offset = "0x7A220E0", VA = "0x187A236E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7A238C0", Offset = "0x7A222C0", VA = "0x187A238C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct MMBLBCDFBJI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A24940", Offset = "0x7A23340", VA = "0x187A24940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7A24CA0", Offset = "0x7A236A0", VA = "0x187A24CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct LGLABIFBGKI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A23920", Offset = "0x7A22320", VA = "0x187A23920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7A23C10", Offset = "0x7A22610", VA = "0x187A23C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KJCILNKDPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KJCILNKDPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7A23380", Offset = "0x7A21D80", VA = "0x187A23380")]
		internal Task JBHJIDDGGIH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct DLPOPJJJANF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1D150", Offset = "0x7A1BB50", VA = "0x187A1D150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D3B0", Offset = "0x7A1BDB0", VA = "0x187A1D3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct PDAIDJGOBEI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A26710", Offset = "0x7A25110", VA = "0x187A26710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7A268F0", Offset = "0x7A252F0", VA = "0x187A268F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BJIGICAIDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CancellationToken cancellationToken;

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
		[Cpp2IlInjected.Address(RVA = "0x7A1BAD0", Offset = "0x7A1A4D0", VA = "0x187A1BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1BE30", Offset = "0x7A1A830", VA = "0x187A1BE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NEPGBEIDPBN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A24E80", Offset = "0x7A23880", VA = "0x187A24E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7A25170", Offset = "0x7A23B70", VA = "0x187A25170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class FOJCKGKNELN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FOJCKGKNELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A1E5A0", Offset = "0x7A1CFA0", VA = "0x187A1E5A0")]
		internal Task CMCJCAJKFFC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct KMFEECOPOBH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A233F0", Offset = "0x7A21DF0", VA = "0x187A233F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7A23650", Offset = "0x7A22050", VA = "0x187A23650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IDMIDGHHEKD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1FD60", Offset = "0x7A1E760", VA = "0x187A1FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A1FEE0", Offset = "0x7A1E8E0", VA = "0x187A1FEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LFNCMHFKIMN<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4EBA390", Offset = "0x4EB8D90", VA = "0x184EBA390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA5F0", Offset = "0x4EB8FF0", VA = "0x184EBA5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct DGJFDMNGDKL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1CC90", Offset = "0x7A1B690", VA = "0x187A1CC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7A1CFC0", Offset = "0x7A1B9C0", VA = "0x187A1CFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? KFELAMDHOAI;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<HGCBNLHKPOI> GGGGBOOKDOB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task CBKJMBLDHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A21D60", Offset = "0x7A20760", VA = "0x187A21D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7A22440", Offset = "0x7A20E40", VA = "0x187A22440")]
	public static bool JMOODBKEFDO(this Task GLCABFFLNII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x370F850", Offset = "0x370E250", VA = "0x18370F850")]
	public static Task<T> JCCLBBBHJJP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A22810", Offset = "0x7A21210", VA = "0x187A22810")]
	public static Task LDCIOHBKFCP(this Task GLCABFFLNII, CancellationToken GNAAILLDOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3712C50", Offset = "0x3711650", VA = "0x183712C50")]
	public static Task<TResult> LDCIOHBKFCP<TResult>(this Task<TResult> GLCABFFLNII, CancellationToken GNAAILLDOKI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x37122C0", Offset = "0x3710CC0", VA = "0x1837122C0")]
	public static TaskCompletionSource<TResult> LDCIOHBKFCP<TResult>(this TaskCompletionSource<TResult> CLDCJIIMAAE, CancellationToken GNAAILLDOKI) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A21610", Offset = "0x7A20010", VA = "0x187A21610")]
	public static IDisposable? CEKIADFBFJH(CancellationToken PPJDHHGNHJO, CancellationToken DFOCEIMABJA, [Out] CancellationToken FIMIGLJOEKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A23090", Offset = "0x7A21A90", VA = "0x187A23090")]
	[AsyncStateMachine(typeof(GFPGKGJDIGN))]
	public static void PHCAGMEAJMO(this Task PPOLMDFNGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A21CB0", Offset = "0x7A206B0", VA = "0x187A21CB0")]
	[AsyncStateMachine(typeof(ONEGIOGFIHH))]
	public static void CJFDINHMCPJ(this Task PPOLMDFNGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x370EBA0", Offset = "0x370D5A0", VA = "0x18370EBA0")]
	[AsyncStateMachine(typeof(GPGFPNLMOEJ<>))]
	public static Task EMOBCCKGPEK<TException>(this Task PPOLMDFNGFC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x370E9C0", Offset = "0x370D3C0", VA = "0x18370E9C0")]
	[AsyncStateMachine(typeof(DNECGFAGAOK<>))]
	public static Task<T> BMJDHONCHNG<T>(this Task<T> IJPDNJELPLO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7A212D0", Offset = "0x7A1FCD0", VA = "0x187A212D0")]
	[AsyncStateMachine(typeof(DEMOBNNKPLN))]
	public static Task<TaskStatus> BFKALMMIHHP(this Task? IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x370F130", Offset = "0x370DB30", VA = "0x18370F130")]
	public static (Task<T?>?, Action<T?>?) HHGFJDMKILN<T>([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x370F650", Offset = "0x370E050", VA = "0x18370F650")]
	[AsyncStateMachine(typeof(NOCDEAFKEJL<, >))]
	public static Task<List<TResult>> IABOCMIPFJE<TResult, TInput>(this Task<List<TInput>> GLCABFFLNII, CPNNAMBKDHE<TInput, TResult> BDHFABPJEFO) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7A22470", Offset = "0x7A20E70", VA = "0x187A22470")]
	[AsyncStateMachine(typeof(NOGCKIGPKCC))]
	public static Task KBHGEHBHHAJ(Task PPOLMDFNGFC, CancellationToken OJOOKCOCPDF, Func<CancellationToken, Task> BGFGKJGNOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7A22110", Offset = "0x7A20B10", VA = "0x187A22110")]
	[AsyncStateMachine(typeof(HDKBHNDNHID))]
	public static Task HODGOLBELOK(Func<CancellationToken, Task> KLMNFDDHBMF, TimeSpan PNIMMCCMCEA, [Optional] CancellationToken OJOOKCOCPDF, [Optional] Action<OperationCanceledException>? NHNHBCECGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x370F3B0", Offset = "0x370DDB0", VA = "0x18370F3B0")]
	[AsyncStateMachine(typeof(KNBFPFGDDAG<>))]
	public static Task<T> HODGOLBELOK<T>(Func<CancellationToken, Task<T>> KLMNFDDHBMF, TimeSpan PNIMMCCMCEA, [Optional] CancellationToken OJOOKCOCPDF, [Optional] Func<OperationCanceledException, T>? NHNHBCECGFO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7A21C60", Offset = "0x7A20660", VA = "0x187A21C60")]
	public static Task CHPNHEFEHIA(params Task[] IHKNNEBGFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A217A0", Offset = "0x7A201A0", VA = "0x187A217A0")]
	public static Task CHPNHEFEHIA(IEnumerable<Task> IHKNNEBGFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x370ED60", Offset = "0x370D760", VA = "0x18370ED60")]
	[AsyncStateMachine(typeof(BOIPLOLCMKO<>))]
	public static Task<IEnumerable<Task<T>>> FNKDINPNGIO<T>(IEnumerable<Task<T>> IHKNNEBGFOJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x370EE50", Offset = "0x370D850", VA = "0x18370EE50")]
	[AsyncStateMachine(typeof(NMNGELOFIPL<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> HENMFCEAFKB<T1, T2, T3, T4, T5>(Task<T1> AFPJKGAEIBG, Task<T2> LDDEDDJOJJD, Task<T3> NAFBPDBLKLF, Task<T4> NJDACIMPECP, Task<T5> BNHODBJPJMF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7A214D0", Offset = "0x7A1FED0", VA = "0x187A214D0")]
	[AsyncStateMachine(typeof(LDMJJGOFCOE))]
	public static Task BOFDMCLHODD(Func<bool> GFLFPOCDIEJ, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7A213C0", Offset = "0x7A1FDC0", VA = "0x187A213C0")]
	[AsyncStateMachine(typeof(MMBLBCDFBJI))]
	public static Task BOFDMCLHODD(Func<bool> GFLFPOCDIEJ, TimeSpan MIBHHPAOBBE, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A21EA0", Offset = "0x7A208A0", VA = "0x187A21EA0")]
	[AsyncStateMachine(typeof(LGLABIFBGKI))]
	public static Task GDMOOKDFFDG(Func<bool> GFLFPOCDIEJ, TimeSpan PNIMMCCMCEA, [Optional] CancellationToken BJEPDCCBCHJ, [Optional] Action<OperationCanceledException>? NHNHBCECGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A21FD0", Offset = "0x7A209D0", VA = "0x187A21FD0")]
	[AsyncStateMachine(typeof(DLPOPJJJANF))]
	public static Task GDMOOKDFFDG(Func<bool> GFLFPOCDIEJ, TimeSpan PNIMMCCMCEA, TimeSpan MIBHHPAOBBE, [Optional] CancellationToken BJEPDCCBCHJ, [Optional] Action<OperationCanceledException>? NHNHBCECGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A22E10", Offset = "0x7A21810", VA = "0x187A22E10")]
	[AsyncStateMachine(typeof(PDAIDJGOBEI))]
	public static Task NKGANJBHPEE(Func<bool> GFLFPOCDIEJ, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7A22F00", Offset = "0x7A21900", VA = "0x187A22F00")]
	[AsyncStateMachine(typeof(BJIGICAIDNC))]
	public static Task NKGANJBHPEE(Func<bool> GFLFPOCDIEJ, TimeSpan MIBHHPAOBBE, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7A225A0", Offset = "0x7A20FA0", VA = "0x187A225A0")]
	[AsyncStateMachine(typeof(NEPGBEIDPBN))]
	public static Task KHCEIBOCELC(Func<bool> GFLFPOCDIEJ, TimeSpan PNIMMCCMCEA, [Optional] CancellationToken BJEPDCCBCHJ, [Optional] Action<OperationCanceledException>? NHNHBCECGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7A226D0", Offset = "0x7A210D0", VA = "0x187A226D0")]
	[AsyncStateMachine(typeof(KMFEECOPOBH))]
	public static Task KHCEIBOCELC(Func<bool> GFLFPOCDIEJ, TimeSpan PNIMMCCMCEA, TimeSpan MIBHHPAOBBE, [Optional] CancellationToken BJEPDCCBCHJ, [Optional] Action<OperationCanceledException>? NHNHBCECGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7A22240", Offset = "0x7A20C40", VA = "0x187A22240")]
	[Obsolete]
	[AsyncStateMachine(typeof(IDMIDGHHEKD))]
	public static Task IELDKGONLIA(this Task GLCABFFLNII, Action BFJIGOCPIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x370F760", Offset = "0x370E160", VA = "0x18370F760")]
	[Obsolete]
	[AsyncStateMachine(typeof(LFNCMHFKIMN<>))]
	public static Task IELDKGONLIA<T>(this Task<T> GLCABFFLNII, Action<T> BFJIGOCPIKM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7A21150", Offset = "0x7A1FB50", VA = "0x187A21150")]
	private static void ACABGCFPAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A22A60", Offset = "0x7A21460", VA = "0x187A22A60")]
	public static bool LLEIOCCBGPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7A23140", Offset = "0x7A21B40", VA = "0x187A23140")]
	private static void PKLKDGGGHAP(SynchronizationContext PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7A22330", Offset = "0x7A20D30", VA = "0x187A22330")]
	private static void IFBKCCGCKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7A21DD0", Offset = "0x7A207D0", VA = "0x187A21DD0")]
	public static void FCAAGCCIPOI([Optional] string? FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A23010", Offset = "0x7A21A10", VA = "0x187A23010")]
	public static void NKJHGIAPFGL([Optional] string? FLPDJFEEMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7A215C0", Offset = "0x7A1FFC0", VA = "0x187A215C0")]
	public static DNEDHILCKMI CCFMBAJLKAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7A22DC0", Offset = "0x7A217C0", VA = "0x187A22DC0")]
	public static DNEDHILCKMI MGMKLAPGOAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7A21200", Offset = "0x7A1FC00", VA = "0x187A21200")]
	[AsyncStateMachine(typeof(DGJFDMNGDKL))]
	public static Task BFAMCIFDDIO(Func<Task> KEEHKILKFBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OHBOADDCADD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public OHBOADDCADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class NDNBLAGAECE : CDEAGLKCDKF
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly CDEAGLKCDKF LALLOKGAEJH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime GNJAKEFIEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7A24DD0", Offset = "0x7A237D0", VA = "0x187A24DD0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset EMHLPMCMHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7A24D70", Offset = "0x7A23770", VA = "0x187A24D70", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NDNBLAGAECE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CDEAGLKCDKF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime GNJAKEFIEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset EMHLPMCMHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NKNPDPKCPAL
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long DCGKKCIFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7A256E0", Offset = "0x7A240E0", VA = "0x187A256E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long GJOLMNLJMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7A251D0", Offset = "0x7A23BD0", VA = "0x187A251D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double CLNFOBIAPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7A25460", Offset = "0x7A23E60", VA = "0x187A25460")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double ELIDPFMJGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7A254B0", Offset = "0x7A23EB0", VA = "0x187A254B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double MPNJMHCJFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7A25220", Offset = "0x7A23C20", VA = "0x187A25220")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double CMINGFJMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7A25600", Offset = "0x7A24000", VA = "0x187A25600")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7A25570", Offset = "0x7A23F70", VA = "0x187A25570")]
	public static double KAEFEAGEFAI(long FLEJBOIPMPK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7A25300", Offset = "0x7A23D00", VA = "0x187A25300")]
	public static double EFABFPBDDGK(long FLEJBOIPMPK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7A25650", Offset = "0x7A24050", VA = "0x187A25650")]
	public static double NGKJHFNHPON(double GNNPMBGHAHN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7A25270", Offset = "0x7A23C70", VA = "0x187A25270")]
	public static long DDJLOJABGHI(long KFGHOINKLDG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A25560", Offset = "0x7A23F60", VA = "0x187A25560")]
	public static long JEBADDLOJOI(long IFDCGDCNNLE, long BCJALPIKIBD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A25390", Offset = "0x7A23D90", VA = "0x187A25390")]
	public static double FCKHPKBKDOD(long IFDCGDCNNLE, long BCJALPIKIBD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7A25500", Offset = "0x7A23F00", VA = "0x187A25500")]
	public static double JAGHAADCIOE(long IFDCGDCNNLE, long BCJALPIKIBD)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class MDEHLDFIFCA : HIIAIILFNPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan EHDMNIHLAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer NDBGCDOMBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan PNIMMCCMCEA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan JLPOFHPHONG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7A243A0", Offset = "0x7A22DA0", VA = "0x187A243A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? OAGAICCLIOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7A248E0", Offset = "0x7A232E0", VA = "0x187A248E0")]
	[Preserve]
	public MDEHLDFIFCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7A24690", Offset = "0x7A23090", VA = "0x187A24690")]
	public MDEHLDFIFCA(TimeSpan PNIMMCCMCEA, [Optional] Action? OJMFGIEPKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7A24590", Offset = "0x7A22F90", VA = "0x187A24590", Slot = "7")]
	public void MBHBHBLMGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7A24330", Offset = "0x7A22D30", VA = "0x187A24330", Slot = "8")]
	public void FCMDCKGEGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7A24260", Offset = "0x7A22C60", VA = "0x187A24260", Slot = "9")]
	public void BIEPMDDMFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x106EB20", Offset = "0x106D520", VA = "0x18106EB20")]
	private void LHMIDNBCBAC(object FOAJJFFCIFO, ElapsedEventArgs MLPHAOKFJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7A24500", Offset = "0x7A22F00", VA = "0x187A24500")]
	private static void LGMNMKMBAOM(TimeSpan NOENCGBCMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7A24290", Offset = "0x7A22C90", VA = "0x187A24290", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DACJCFOLAGM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? BJBDDOOLLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string LBMDJGFBCLM;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7386AD0", Offset = "0x73854D0", VA = "0x187386AD0")]
	public DACJCFOLAGM(string NMJGNNNOHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4A782B0", Offset = "0x4A76CB0", VA = "0x184A782B0")]
	public DACJCFOLAGM(string FDBECNGFMME, string NMJGNNNOHKB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GBBLAFAAPBP : IEquatable<GBBLAFAAPBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint MIKOMOEKPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int LLFCONCFLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float JCGJDPKPCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort OPOICDGIAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort NECMIMFLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short AHLJEJJHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short NJAGPMFBFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char PAMIKNHHDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char LKDBEAIOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte PLCBMCCHCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte JOJBJNBLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte IPADDFMNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte KCBPEMGIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool IHKKGCBHFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool PBKJEGIDDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool LGHMFPGHACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool OKFBPMMDKIK;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static GBBLAFAAPBP DBOJNLBGIHF(uint LCABLHBEJAL)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static GBBLAFAAPBP CAJONINHDCB(int AMIOHDOCHMP)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E6B0", Offset = "0x7A1D0B0", VA = "0x187A1E6B0")]
	public static GBBLAFAAPBP PLGNGPNOHNK(float JAAOHBNDPBB)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E610", Offset = "0x7A1D010", VA = "0x187A1E610")]
	public static GBBLAFAAPBP JPAOIIPLBIB(byte ALNCAIFKAEH, byte DGBFCHJELJA, byte CHKFEGJAHPH, byte OJAOILFGMHC)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E610", Offset = "0x7A1D010", VA = "0x187A1E610")]
	public static GBBLAFAAPBP EIJBEGJFECH(bool KPBOBCBODJD, bool LDBCDMLCINL, bool DJCMHCKAOLI, bool JOONHMAOAFA)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E610", Offset = "0x7A1D010", VA = "0x187A1E610")]
	public static GBBLAFAAPBP NODEGBJAIGH(byte NMEODEALJIG, byte CJBINFDLEFO, byte GJKPEDLAHGE, byte MAOPKIJFCII)
	{
		return default(GBBLAFAAPBP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2064E40", Offset = "0x2063840", VA = "0x182064E40")]
	public static bool HFGMMLFJJJB(GBBLAFAAPBP HIHOACCANFP, GBBLAFAAPBP JJEIFHEKJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2064E20", Offset = "0x2063820", VA = "0x182064E20", Slot = "4")]
	public bool Equals(GBBLAFAAPBP OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E630", Offset = "0x7A1D030", VA = "0x187A1E630", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x11F8C60", Offset = "0x11F7660", VA = "0x1811F8C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E6C0", Offset = "0x7A1D0C0", VA = "0x187A1E6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FJKFHKIPJGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong MLMPFHLNDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long ILMAINGJAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double DDMCLLLLIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint JDHLPPAAHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint NIJMDOCKIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int DLDGNEEJLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int EDPHFPFEBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float DNJEIKECJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float BHMCIEEAPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort OPOICDGIAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort NECMIMFLPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort JICHGCCGFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort LEAINHNMNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short AHLJEJJHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short NJAGPMFBFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short NIEJKNDCOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short FBPIEOOFPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char PAMIKNHHDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char LKDBEAIOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char FMHBIEMNNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char GDEJFFKJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte PLCBMCCHCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte JOJBJNBLEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte IPADDFMNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte KCBPEMGIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte EGEPGLNFGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte ADPICODONIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte NPLLIKCGIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte JADFCCDJIAC;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static FJKFHKIPJGK DDDHPONDPCL(long HKBBCLOBHDJ)
	{
		return default(FJKFHKIPJGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7A1E550", Offset = "0x7A1CF50", VA = "0x187A1E550")]
	public static FJKFHKIPJGK DDDHPONDPCL(byte ALNCAIFKAEH, byte DGBFCHJELJA, byte CHKFEGJAHPH, byte OJAOILFGMHC, byte AKAFEDFHNIM, byte NHNAFEDGFPD, byte JPHGPCDJCAK, byte INDMJADBICD)
	{
		return default(FJKFHKIPJGK);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct AGNPJEFJCLP : IEquatable<AGNPJEFJCLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte BPFDCEBJFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool EMAPDPGAMGC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2D06260", Offset = "0x2D04C60", VA = "0x182D06260")]
	public static AGNPJEFJCLP JPAOIIPLBIB(byte GGPMEIBHOMK)
	{
		return default(AGNPJEFJCLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2D06260", Offset = "0x2D04C60", VA = "0x182D06260")]
	public static AGNPJEFJCLP EIJBEGJFECH(bool IKKJHJNLFID)
	{
		return default(AGNPJEFJCLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A8D0", Offset = "0x7A192D0", VA = "0x187A1A8D0")]
	public static bool HFGMMLFJJJB(AGNPJEFJCLP HIHOACCANFP, AGNPJEFJCLP JJEIFHEKJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x69F9C60", Offset = "0x69F8660", VA = "0x1869F9C60", Slot = "4")]
	public bool Equals(AGNPJEFJCLP OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A830", Offset = "0x7A19230", VA = "0x187A1A830", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A8C0", Offset = "0x7A192C0", VA = "0x187A1A8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7A1A8E0", Offset = "0x7A192E0", VA = "0x187A1A8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GFJKCHCEEGC<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T MOCLKOOAAOE;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4893C50", Offset = "0x4892650", VA = "0x184893C50")]
	public GFJKCHCEEGC(T GFOOMNLGHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class IHAHAPGKMBH
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36B7960", Offset = "0x36B6360", VA = "0x1836B7960")]
	public static IEnumerable<T> CIMAENMNLAN<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static T[] LLFINJCKKFK<T>(params T[] KMBOLOLGKNP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static IEnumerable<T> GJKPFOCGFLO<T>(params T[] KMBOLOLGKNP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static HashSet<T> EGJOBADLLOO<T>(params T[] KMBOLOLGKNP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x36B7990", Offset = "0x36B6390", VA = "0x1836B7990")]
	public static KeyValuePair<TKey, TValue> KFADFNNMLFE<TKey, TValue>([In] TKey NJBPFCDJFGD, [In] TValue PPJFMHBDGNA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x36A4440", Offset = "0x36A2E40", VA = "0x1836A4440")]
	public static List<T> ADFAKBIHDLB<T>(IEnumerable<T> NNLLAHLBLIH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class CJEOLLBMJPK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string NIPOJLHHIKO;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
	public CJEOLLBMJPK(string JCDJPNMFCEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object ELDIFBAKPHP<T>([In] T CPDOLKLJBKL);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object KINIKDIFNPM<T>(T CPDOLKLJBKL);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[AMAFNLLCELH]
public delegate string BMPEABOIONL(string FHBIJDIKBHA, string? FMDFMHFHDKP, bool PHCEKMHDFKG);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AMAFNLLCELH]
public delegate void OCMHJCHDOCB(string FLPDJFEEMLN);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[AMAFNLLCELH]
public delegate void MOPCOJHBHOD(Exception GKNCIBMNAMA);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object IFJMDKILFGB();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[AMAFNLLCELH]
public delegate bool HEKANNAPAAH();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[AMAFNLLCELH]
public delegate string ILHJEINBHJG(object OIIGDBLKEDN);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class CCOMDANECJB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
	public CCOMDANECJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AKCGICCHKME
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct BNEBPDEJOLB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7A1BF90", Offset = "0x7A1A990", VA = "0x187A1BF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7A1C880", Offset = "0x7A1B280", VA = "0x187A1C880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback BJEOKOOCEHO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> DMICEPGNIBB;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B480", Offset = "0x7A19E80", VA = "0x187A1B480")]
	public static Task<bool> BCBJFPBKOKI(int LALGILMEIAH, [Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B780", Offset = "0x7A1A180", VA = "0x187A1B780")]
	[AsyncStateMachine(typeof(BNEBPDEJOLB))]
	private static Task<bool> EHPEDLLKOKI(int LALGILMEIAH, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B8B0", Offset = "0x7A1A2B0", VA = "0x187A1B8B0")]
	private static void IIBKCJGIEEA(object? JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7A1B940", Offset = "0x7A1A340", VA = "0x187A1B940")]
	private static void JAHGNFBBDCI(object? JCFJJCIGDKC)
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
