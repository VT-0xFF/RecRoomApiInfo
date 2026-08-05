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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8261600", Offset = "0x8260200", VA = "0x188261600")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MJHLGLAPKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x825F310", Offset = "0x825DF10", VA = "0x18825F310")]
	public static string FIHKHAPHEHN(this Encoding GEBLLHCBBFE, [In] ReadOnlySequence<byte> LNEJCNPADCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D579C0", Offset = "0x3D565C0", VA = "0x183D579C0")]
	private static void CGEAFOKGLLP<T>(this ReadOnlySequence<T> PLKGHIAJHKM, [Out] ReadOnlySpan<T> EHBDPPDNLOA, [Out] SequencePosition AKENCOPCNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class NGFNFNNBGJL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8260540", Offset = "0x825F140", VA = "0x188260540")]
	public NGFNFNNBGJL(bool GBOIPKNJAFC, string APOCMLPNBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8260620", Offset = "0x825F220", VA = "0x188260620")]
	public NGFNFNNBGJL(bool GBOIPKNJAFC, params string[] ANJPCAOPDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class INBMALPCLAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PKNPKMCIBNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JNEODNAAHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOFKIMKFGCN(string DHCHBFGMFFD, double BKMPCFIAHIG, [Optional] string? OOBJJKBBOLA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DOCBNHKAIGD : JOHHIHOPIPO, IBMPBGNLNID, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LLDBNHMGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MJFGFLKHNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double MPPPNIHIBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double ENBPGBPHHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double KACHAIKLFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JPALNMAIJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double AHGDCEPOPMO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NIIIKGEMCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA7B160", Offset = "0xA79D60", VA = "0x180A7B160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NDKNLPNPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x825A080", Offset = "0x8258C80", VA = "0x18825A080", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KNIGLBIAAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x48F5FB0", Offset = "0x48F4BB0", VA = "0x1848F5FB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DAGLADJFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x297CD60", Offset = "0x297B960", VA = "0x18297CD60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x825A0E0", Offset = "0x8258CE0", VA = "0x18825A0E0")]
	public DOCBNHKAIGD(int CNBGCBAENMF, double AHGDCEPOPMO = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8259F50", Offset = "0x8258B50", VA = "0x188259F50", Slot = "7")]
	public void IOHNMOGMMHJ(double PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8259EE0", Offset = "0x8258AE0", VA = "0x188259EE0", Slot = "8")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8259DE0", Offset = "0x82589E0", VA = "0x188259DE0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HLGNIDOBOOA : JOHHIHOPIPO, IBMPBGNLNID, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long NKGPOLKDIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double LGODIIEDKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double HAHJPMBOEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double BCNNGAFGCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double MBDNPOOOPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double MPPPNIHIBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double ENBPGBPHHMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KNIGLBIAAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7454A40", Offset = "0x7453640", VA = "0x187454A40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DAGLADJFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7454580", Offset = "0x7453180", VA = "0x187454580", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double GEEIHLDLONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7454610", Offset = "0x7453210", VA = "0x187454610")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double NDKNLPNPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x311F310", Offset = "0x311DF10", VA = "0x18311F310", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x825C330", Offset = "0x825AF30", VA = "0x18825C330", Slot = "10")]
	public virtual void IOHNMOGMMHJ(double PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x825C2F0", Offset = "0x825AEF0", VA = "0x18825C2F0", Slot = "11")]
	public virtual void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x825C280", Offset = "0x825AE80", VA = "0x18825C280", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x825C450", Offset = "0x825B050", VA = "0x18825C450")]
	public HLGNIDOBOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KNDBHHBNEKE : HLGNIDOBOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double CMPEFFJMNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7454570", Offset = "0x7453170", VA = "0x187454570")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7454A50", Offset = "0x7453650", VA = "0x187454A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x825E930", Offset = "0x825D530", VA = "0x18825E930", Slot = "10")]
	public override void IOHNMOGMMHJ(double PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x825E8F0", Offset = "0x825D4F0", VA = "0x18825E8F0", Slot = "11")]
	public override void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x825C450", Offset = "0x825B050", VA = "0x18825C450")]
	public KNDBHHBNEKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JOHHIHOPIPO : IBMPBGNLNID, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NDKNLPNPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double KNIGLBIAAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DAGLADJFGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MPGJGBIMKOB : IBMPBGNLNID, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double CIMPNBKHBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double LENAFCAMDEO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8260270", Offset = "0x825EE70", VA = "0x188260270")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9130", Offset = "0x6EA7D30", VA = "0x186EA9130", Slot = "4")]
	public void IOHNMOGMMHJ(double PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8260260", Offset = "0x825EE60", VA = "0x188260260", Slot = "5")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8260210", Offset = "0x825EE10", VA = "0x188260210", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MPGJGBIMKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBMPBGNLNID : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOHNMOGMMHJ(double PINMHDANIAH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLOPEGKIHMO();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KONMGMOMHHO : IBMPBGNLNID, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double BKMPCFIAHIG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x496B100", Offset = "0x4969D00", VA = "0x18496B100")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x56E3710", Offset = "0x56E2310", VA = "0x1856E3710", Slot = "4")]
	public void IOHNMOGMMHJ(double PINMHDANIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x825EAB0", Offset = "0x825D6B0", VA = "0x18825EAB0", Slot = "5")]
	public void HLOPEGKIHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x825EA60", Offset = "0x825D660", VA = "0x18825EA60", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KONMGMOMHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MBAICIBIBHJ<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> CKFOEPJBJAD(CancellationToken JHCOCAANJDL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct AGOPLIOLDKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public MBAICIBIBHJ<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CKFOEPJBJAD taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x5095490", Offset = "0x5094090", VA = "0x185095490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5096460", Offset = "0x5095060", VA = "0x185096460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource OFBLADCGCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? DEIDONHCJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? NEGEJHOFKJP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x564A840", Offset = "0x5649440", VA = "0x18564A840")]
	[AsyncStateMachine(typeof(MBAICIBIBHJ<>.AGOPLIOLDKD))]
	public Task<TResult> FLCFMNMKGCF(CKFOEPJBJAD PMLPFEPBKLI, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x564A7D0", Offset = "0x56493D0", VA = "0x18564A7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x564A970", Offset = "0x5649570", VA = "0x18564A970")]
	public MBAICIBIBHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PMOMOIPABMI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> KKODCJCMPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T AHLMJDKCEID;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x570C820", Offset = "0x570B420", VA = "0x18570C820")]
	public PMOMOIPABMI([In] T BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A15910", Offset = "0x5A14510", VA = "0x185A15910", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5A16010", Offset = "0x5A14C10", VA = "0x185A16010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A16650", Offset = "0x5A15250", VA = "0x185A16650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class JMBKMHELNBA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static PMOMOIPABMI<T> MJMNOIPJNFN<T>([In] T BKMPCFIAHIG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MFDPDJINJIA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x825F0A0", Offset = "0x825DCA0", VA = "0x18825F0A0")]
	public static void GNIGPFKBBDN(this CancellationTokenSource OFBLADCGCLF, bool GDCNMEBGFHH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class IHBLOHBJKLP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public IHBLOHBJKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class AFOGCKCBHFD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public AFOGCKCBHFD(string CEPGINPGGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BDGBOEOPGPB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39C2760", Offset = "0x39C1360", VA = "0x1839C2760")]
	public static EMODONDBOJP FGLJFGCEPGF<T>()
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8258D90", Offset = "0x8257990", VA = "0x188258D90")]
	public static EMODONDBOJP IGIMPMPMMMH([CallerMemberName] string BKILENEPEEB = "")
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39C29E0", Offset = "0x39C15E0", VA = "0x1839C29E0")]
	public static EMODONDBOJP JJBMHMPLDPF<T>([CallerMemberName] string BKILENEPEEB = "") where T : notnull
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39C27E0", Offset = "0x39C13E0", VA = "0x1839C27E0")]
	public static EMODONDBOJP FGLJFGCEPGF<T>(this T HPNKJCMLGMJ) where T : notnull
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39C2860", Offset = "0x39C1460", VA = "0x1839C2860")]
	public static EMODONDBOJP IGIMPMPMMMH<T>(this T HPNKJCMLGMJ, [CallerMemberName] string BKILENEPEEB = "") where T : notnull
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39C2A70", Offset = "0x39C1670", VA = "0x1839C2A70")]
	public static EMODONDBOJP JJBMHMPLDPF<T>(this T JBDFDFABHKD, [CallerMemberName] string BKILENEPEEB = "") where T : notnull
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8258DF0", Offset = "0x82579F0", VA = "0x188258DF0")]
	public static EMODONDBOJP JJBMHMPLDPF(string HFDFMPHPDCD, [CallerMemberName] string BKILENEPEEB = "")
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8258CF0", Offset = "0x82578F0", VA = "0x188258CF0")]
	public static string FOADPCLGDCE(this object JBDFDFABHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool GNPKLMMCADD();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[IHBLOHBJKLP]
public delegate long GDFANHPFKIC();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CFCKFABPECB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly CFCKFABPECB MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CFCKFABPECB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DMGPFMDGDDA
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static NIDMBLIJIAO ACIMOLOKHGH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NIDMBLIJIAO DANJPBPDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82596E0", Offset = "0x82582E0", VA = "0x1882596E0")]
		get
		{
			return default(NIDMBLIJIAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static IGBHOHAIHHI KGFFNKKMLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82594B0", Offset = "0x82580B0", VA = "0x1882594B0")]
		get
		{
			return default(IGBHOHAIHHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static NLPGDPAAOEN NEDNGJILKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8259690", Offset = "0x8258290", VA = "0x188259690")]
		get
		{
			return default(NLPGDPAAOEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool JAJOHMMLOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82595A0", Offset = "0x82581A0", VA = "0x1882595A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8259930", Offset = "0x8258530", VA = "0x188259930")]
	public static void KOKHKGAOIIJ([In] NIDMBLIJIAO FMJHCLLENOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8259AE0", Offset = "0x82586E0", VA = "0x188259AE0")]
	public static void OJAPELLDHBE(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8259860", Offset = "0x8258460", VA = "0x188259860")]
	public static void KNOCPKMAFOM(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F8E0", Offset = "0x3A9E4E0", VA = "0x183A9F8E0")]
	public static void KNOCPKMAFOM<T>(T AHGPJFFLNPG, KMCOGECJBLO<T> HLMEMBFCHLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8259500", Offset = "0x8258100", VA = "0x188259500")]
	public static void DDBOHDBBMAD(Exception EBNIDHCOLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8259800", Offset = "0x8258400", VA = "0x188259800")]
	public static void KKABGBAOLGF(string BKILENEPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8259C50", Offset = "0x8258850", VA = "0x188259C50")]
	public static void PDPDLHNKAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8259610", Offset = "0x8258210", VA = "0x188259610")]
	public static string FOADPCLGDCE(object KOJLNGLNBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8259CB0", Offset = "0x82588B0", VA = "0x188259CB0")]
	public static long PGEMNJGFEDP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8259BB0", Offset = "0x82587B0", VA = "0x188259BB0")]
	public static bool PBHODLMKOII(bool MBDNDPHCDDE, string HLMEMBFCHLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8259730", Offset = "0x8258330", VA = "0x188259730")]
	public static double IFCMJONLIFE()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NIDMBLIJIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IGBHOHAIHHI KGFFNKKMLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly NLPGDPAAOEN NEDNGJILKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly OPNJOBGHINI IIJNBDPIDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly GDFANHPFKIC HGKBLNOPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly HDCPHONKOJG GIMHKAGOPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly GNPKLMMCADD DJJDFKOKLIA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly OPNJOBGHINI FOIEJGNPBBK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GDFANHPFKIC INGGCANGDAH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HDCPHONKOJG NGHHLPIDBND;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly GNPKLMMCADD BFNECGAJPFC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly NIDMBLIJIAO LNCBONNLALO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82608F0", Offset = "0x825F4F0", VA = "0x1882608F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8261290", Offset = "0x825FE90", VA = "0x188261290")]
	public NIDMBLIJIAO([In] IGBHOHAIHHI BNGNEBJKAAO, [In] NLPGDPAAOEN JLNMJABPGLF, OPNJOBGHINI NAOADKFIECA, GDFANHPFKIC GLAJFGJNCLL, HDCPHONKOJG BKGLJGPMLFC, GNPKLMMCADD CJKCJDDFDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82608B0", Offset = "0x825F4B0", VA = "0x1882608B0")]
	private static string BIKKOCAJBKH(object KOJLNGLNBMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	private static long EFAHCBCJHBK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	private static string ECABCLMGDCF(string JIBDMFNCFIM, string? MKMPFLKICKK, bool AODNMAMJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
	private static bool MCDOGMPGNAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8260A90", Offset = "0x825F690", VA = "0x188260A90")]
	private static NIDMBLIJIAO FHMCNOPMNKM()
	{
		return default(NIDMBLIJIAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NEAIJENDILF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPOOPMGJGBM PFNJCNDHBFE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LPOOPMGJGBM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MKBJJIJHHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMIONNJCNDN();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HLJOFADDFBK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNEPHKEMLBE([In] T IIOGPDPGOLB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void CALKOJJCCGB<T>([In] T AHGPJFFLNPG);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct NLCAHHBKCIO<T> : IEquatable<NLCAHHBKCIO<T>>, HLJOFADDFBK<NLCAHHBKCIO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T AHLMJDKCEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int CLIFKJOPCGH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2F922C0", Offset = "0x2F90EC0", VA = "0x182F922C0")]
	public NLCAHHBKCIO([In] T BKMPCFIAHIG, int LCCBBMBENOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5720590", Offset = "0x571F190", VA = "0x185720590")]
	public static bool CDGFDPOPEPC([In] NLCAHHBKCIO<T> ODBANBBPCIA, [In] NLCAHHBKCIO<T> FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CFA0", Offset = "0x4E9BBA0", VA = "0x184E9CFA0", Slot = "4")]
	public bool Equals(NLCAHHBKCIO<T> IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B290", Offset = "0x4E39E90", VA = "0x184E3B290", Slot = "0")]
	public override bool Equals(object IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57215A0", Offset = "0x57201A0", VA = "0x1857215A0")]
	public bool PNEPHKEMLBE([In] NLCAHHBKCIO<T> IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5720DB0", Offset = "0x571F9B0", VA = "0x185720DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5721BF0", Offset = "0x57207F0", VA = "0x185721BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x571FFB0", Offset = "0x571EBB0", VA = "0x18571FFB0")]
	public void AEDAIPFNKDM([Out] T BKMPCFIAHIG, [Out] int LCCBBMBENOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5721180", Offset = "0x571FD80", VA = "0x185721180")]
	public (T, int) JGEIJAEMJED()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5720B50", Offset = "0x571F750", VA = "0x185720B50", Slot = "5")]
	private bool EDMFILFKJFA([In] NLCAHHBKCIO<T> IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MFKDEIEGNAB
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BFD0", Offset = "0x3D4ABD0", VA = "0x183D4BFD0")]
	public static NLCAHHBKCIO<T> MJMNOIPJNFN<T>([In] T BKMPCFIAHIG, int LCCBBMBENOH) where T : notnull
	{
		return default(NLCAHHBKCIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ELBHHDACIJJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDC40", Offset = "0x3ABC840", VA = "0x183ABDC40")]
	public static bool PNEPHKEMLBE<T, U>([In] T JBDFDFABHKD, [In] U KOJLNGLNBMH) where T : notnull, HLJOFADDFBK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult NGIHFBMKGIP<T, out TResult>([In] T AHGPJFFLNPG);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DCKJGFLKGOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan PONCELFFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? FAAHHEODBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLODMKOIAML();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AADFPNEDNGC();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKGEMMIDJHK();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct IGBHOHAIHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly GONDFGAPGNB GJPCGBMLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly CGFCEKCPKGG EPFMFLKJEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly GONDFGAPGNB FCDILKHLJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly CGFCEKCPKGG FHPIMNDCFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly GONDFGAPGNB NMBOKJEOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly CGFCEKCPKGG DDLGDPJJINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly JPNEEOPEHIL IODIOABPHHK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly GONDFGAPGNB MIBFJGNHCCJ;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly CGFCEKCPKGG NBBLFGJHGKN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly GONDFGAPGNB FEGOGCIALDH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly CGFCEKCPKGG KCBOCEJEDFP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly GONDFGAPGNB OOOLNOEANBL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly CGFCEKCPKGG GMNGIDDJPFP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JPNEEOPEHIL GLMMMCHHGKM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly IGBHOHAIHHI LNCBONNLALO;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly GONDFGAPGNB DGPBBELALMJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x825C480", Offset = "0x825B080", VA = "0x18825C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE82D60", Offset = "0xE81960", VA = "0x180E82D60")]
	public IGBHOHAIHHI(GONDFGAPGNB MGFHEBMOBGH, CGFCEKCPKGG OGMPKLACHIE, GONDFGAPGNB LGDDGGKBGNB, CGFCEKCPKGG JIHOKELGDIF, GONDFGAPGNB KPHINCOIGJO, CGFCEKCPKGG DMKAAMBONOG, JPNEEOPEHIL GLPMLJLDAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
	private static bool OCCALOLGFOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void INKPNCLPJFA(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
	private static bool OFHLMMLJIFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void IAHLKNKCGDM(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
	private static bool NFKIEBDFFKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void EJMNPCGOAJG(string HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void GMHKHPGHGDJ(Exception EBNIDHCOLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x825C680", Offset = "0x825B280", VA = "0x18825C680")]
	private static IGBHOHAIHHI FHMCNOPMNKM()
	{
		return default(IGBHOHAIHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
	private static bool GKDOHGKJEMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x825C980", Offset = "0x825B580", VA = "0x18825C980")]
	public void OJAPELLDHBE(object HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x825C7C0", Offset = "0x825B3C0", VA = "0x18825C7C0")]
	public void JIPINIIKOFC(object HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x825C830", Offset = "0x825B430", VA = "0x18825C830")]
	public void KNOCPKMAFOM(object HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE8FD40", Offset = "0xE8E940", VA = "0x180E8FD40")]
	public void DDBOHDBBMAD(Exception EBNIDHCOLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x825C8A0", Offset = "0x825B4A0", VA = "0x18825C8A0")]
	public void KNOCPKMAFOM(BOBFGDACOPD HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0290", Offset = "0x3C9EE90", VA = "0x183CA0290")]
	public void KNOCPKMAFOM<T>(T AHGPJFFLNPG, KMCOGECJBLO<T> HLMEMBFCHLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CA05A0", Offset = "0x3C9F1A0", VA = "0x183CA05A0")]
	public void OJAPELLDHBE<T>([In] T AHGPJFFLNPG, GPPIJGBGIGE<T> HLMEMBFCHLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0360", Offset = "0x3C9EF60", VA = "0x183CA0360")]
	public void KNOCPKMAFOM<T>([In] T AHGPJFFLNPG, GPPIJGBGIGE<T> HLMEMBFCHLD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x825C9F0", Offset = "0x825B5F0", VA = "0x18825C9F0")]
	public bool PBHODLMKOII(bool MBDNDPHCDDE, string HLMEMBFCHLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct EMODONDBOJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string AHLMJDKCEID;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
	public EMODONDBOJP(string BKMPCFIAHIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
	public static string KDDDGPNBGLG([In] EMODONDBOJP JBDFDFABHKD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x13F40A0", Offset = "0x13F2CA0", VA = "0x1813F40A0")]
	public static EMODONDBOJP KDDDGPNBGLG(string IIOGPDPGOLB)
	{
		return default(EMODONDBOJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x825AA30", Offset = "0x8259630", VA = "0x18825AA30")]
	public string JDAHDAPEEDM(string EHDDFGMNGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x825A950", Offset = "0x8259550", VA = "0x18825A950")]
	public string IDIGNFNOMAO(object EAEEONELOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class FHDJJLGGPOE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public FHDJJLGGPOE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct DIKEICNGGBM : IEquatable<DIKEICNGGBM>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "4")]
	public bool Equals(DIKEICNGGBM IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8259420", Offset = "0x8258020", VA = "0x188259420", Slot = "0")]
	public override bool Equals(object IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8259470", Offset = "0x8258070", VA = "0x188259470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8259480", Offset = "0x8258080", VA = "0x188259480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ABLFJIFLPNO("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MFDCCLPPFCM<T> : IEquatable<MFDCCLPPFCM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T AHLMJDKCEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool AAGKJLCBMOL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EBPEACPOHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x566F7D0", Offset = "0x566E3D0", VA = "0x18566F7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x56700C0", Offset = "0x566ECC0", VA = "0x1856700C0")]
	public MFDCCLPPFCM([In] T BKMPCFIAHIG, bool FMJNMGABEIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x566E2E0", Offset = "0x566CEE0", VA = "0x18566E2E0")]
	public static bool CDGFDPOPEPC([In] MFDCCLPPFCM<T> ODBANBBPCIA, [In] MFDCCLPPFCM<T> FMNHBACBGIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x566E5C0", Offset = "0x566D1C0", VA = "0x18566E5C0", Slot = "4")]
	public bool Equals(MFDCCLPPFCM<T> IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x566E8B0", Offset = "0x566D4B0", VA = "0x18566E8B0", Slot = "0")]
	public override bool Equals(object? IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x566F4D0", Offset = "0x566E0D0", VA = "0x18566F4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x566FEB0", Offset = "0x566EAB0", VA = "0x18566FEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EHJBIHKOCAE
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB4E0", Offset = "0x3ABA0E0", VA = "0x183ABB4E0")]
	public static MFDCCLPPFCM<T> JKCCCEDAJFN<T>([In] T BKMPCFIAHIG) where T : notnull
	{
		return default(MFDCCLPPFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB7E0", Offset = "0x3ABA3E0", VA = "0x183ABB7E0")]
	public static MFDCCLPPFCM<T?> PONIMLJMADI<T>()
	{
		return default(MFDCCLPPFCM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB6B0", Offset = "0x3ABA2B0", VA = "0x183ABB6B0")]
	public static bool OGNJHHJDMBH<T>([In] this MFDCCLPPFCM<T> MEHDFLPHHOB, [Out][NotNullWhen(true)] T BKMPCFIAHIG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB670", Offset = "0x3ABA270", VA = "0x183ABB670")]
	public static bool OGNJHHJDMBH<T>([In] this MFDCCLPPFCM<T> MEHDFLPHHOB, [Out][NotNullWhen(true)] T BKMPCFIAHIG, [Out] MFDCCLPPFCM<T> MJLMNEPGACJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB5E0", Offset = "0x3ABA1E0", VA = "0x183ABB5E0")]
	public static T? JNNBDHEBIFM<T>([In] this MFDCCLPPFCM<T> MEHDFLPHHOB, T? PLEDLJICBFM)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB2E0", Offset = "0x3AB9EE0", VA = "0x183ABB2E0")]
	public static bool AIGEDDELGPO<T>([In] this MFDCCLPPFCM<T> MEHDFLPHHOB, T BKMPCFIAHIG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OHPANBDMFLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DFACD0", Offset = "0x3DF98D0", VA = "0x183DFACD0")]
	public static T EEONPMGAHJH<T>([In] this MFDCCLPPFCM<T> MEHDFLPHHOB) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct NLPGDPAAOEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr KKABGBAOLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr PDPDLHNKAKK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr LCFNFFFBHAN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr KAAAAIMOLDC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NLPGDPAAOEN LNCBONNLALO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NNPPJEMMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8261340", Offset = "0x825FF40", VA = "0x188261340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	public NLPGDPAAOEN(IntPtr NCLJJKLINCM, IntPtr JPDIOJFEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void COBJCNFFCGH(string BKILENEPEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void HIOMFOCDOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8261420", Offset = "0x8260020", VA = "0x188261420")]
	private static NLPGDPAAOEN FHMCNOPMNKM()
	{
		return default(NLPGDPAAOEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct IJPLAMCNFIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr EGLEKGDPDMN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
	private IJPLAMCNFIL(IntPtr JPDIOJFEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x825D460", Offset = "0x825C060", VA = "0x18825D460")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x825D470", Offset = "0x825C070", VA = "0x18825D470")]
	public static IJPLAMCNFIL MJMNOIPJNFN(string BKILENEPEEB)
	{
		return default(IJPLAMCNFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A0FBA0", Offset = "0x2A0E7A0", VA = "0x182A0FBA0")]
	public static IJPLAMCNFIL MJMNOIPJNFN([In] NLPGDPAAOEN JLNMJABPGLF, string BKILENEPEEB)
	{
		return default(IJPLAMCNFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A101D0", Offset = "0x2A0EDD0", VA = "0x182A101D0")]
	public static IJPLAMCNFIL MJMNOIPJNFN([In] NLPGDPAAOEN JLNMJABPGLF, Func<string> BKILENEPEEB)
	{
		return default(IJPLAMCNFIL);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EMDMLLMENAM : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? AGONLENGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr ADHECKKIHGH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LEJKCAINAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x825A5C0", Offset = "0x82591C0", VA = "0x18825A5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x825A350", Offset = "0x8258F50", VA = "0x18825A350")]
	public static SHA256 FOGKIHKKOLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x825A7F0", Offset = "0x82593F0", VA = "0x18825A7F0")]
	private static extern int KFHPHOJPOJN();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x825A1B0", Offset = "0x8258DB0", VA = "0x18825A1B0")]
	private static extern IntPtr CHHKODCJAHF();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x825A6B0", Offset = "0x82592B0", VA = "0x18825A6B0")]
	private static extern void IJMDCAKMIMH(IntPtr ADHECKKIHGH);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x825A860", Offset = "0x8259460", VA = "0x18825A860")]
	private static extern void PFILMKABAIB(IntPtr ADHECKKIHGH, byte[] CBCNBAPLLJM, int HDEKJKJDEIC, int LJNPALGAABF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x825A2B0", Offset = "0x8258EB0", VA = "0x18825A2B0")]
	private static extern void EKCEFEPDGFJ(IntPtr ADHECKKIHGH, byte[] FODBJMDFGDB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x825A920", Offset = "0x8259520", VA = "0x18825A920")]
	private EMDMLLMENAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x825A3D0", Offset = "0x8258FD0", VA = "0x18825A3D0", Slot = "18")]
	protected override void HashCore(byte[] COJHNLDFDFB, int KANFBJGCPIC, int PKEFOKNFNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x825A490", Offset = "0x8259090", VA = "0x18825A490", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x825A730", Offset = "0x8259330", VA = "0x18825A730", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x825A220", Offset = "0x8258E20", VA = "0x18825A220", Slot = "13")]
	protected override void Dispose(bool GOKCOPIKIHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OIPJCIENMLI
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool IGLBLJMIHPL<in TInput, TResult>(TInput HOKNBAKODNG, [Out] TResult ABEFNIJCBBN);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class MBHDPNCPPGF : NEAIJENDILF
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class MJEKKCGHHBO : LPOOPMGJGBM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly MJEKKCGHHBO MFAGMJBMEEP;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool MKBJJIJHHIN
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x825F0D0", Offset = "0x825DCD0", VA = "0x18825F0D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x825F130", Offset = "0x825DD30", VA = "0x18825F130", Slot = "6")]
			public void OnCompleted(Action MLPAOOBHNAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			public void IMIONNJCNDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public MJEKKCGHHBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly MBHDPNCPPGF MFAGMJBMEEP;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		private MBHDPNCPPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x825EEE0", Offset = "0x825DAE0", VA = "0x18825EEE0", Slot = "4")]
		public LPOOPMGJGBM PFNJCNDHBFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class DBHKANLJEKO : NEAIJENDILF
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class MEPPMONNHBG : LPOOPMGJGBM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly MEPPMONNHBG MFAGMJBMEEP;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool MKBJJIJHHIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x825EFB0", Offset = "0x825DBB0", VA = "0x18825EFB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x825EFD0", Offset = "0x825DBD0", VA = "0x18825EFD0", Slot = "6")]
			public void OnCompleted(Action MLPAOOBHNAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			public void IMIONNJCNDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public MEPPMONNHBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly DBHKANLJEKO MFAGMJBMEEP;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		private DBHKANLJEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8259350", Offset = "0x8257F50", VA = "0x188259350", Slot = "4")]
		public LPOOPMGJGBM PFNJCNDHBFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class EMLJACNGGJL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EMLJACNGGJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x48E8E50", Offset = "0x48E7A50", VA = "0x1848E8E50")]
		internal void BIKGAIEFAIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class AODJMDFADNN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AODJMDFADNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5250D20", Offset = "0x524F920", VA = "0x185250D20")]
		internal void FCKABAFGJGG(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JBHLGINGHFP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825DC50", Offset = "0x825C850", VA = "0x18825DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HGFCOFBNCOF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825C170", Offset = "0x825AD70", VA = "0x18825C170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BGBLKAGHLAF<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x6340AD0", Offset = "0x633F6D0", VA = "0x186340AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6340C40", Offset = "0x633F840", VA = "0x186340C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct OOLOMOIJJHA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x588E2C0", Offset = "0x588CEC0", VA = "0x18588E2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x588EAF0", Offset = "0x588D6F0", VA = "0x18588EAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct BBBBNEOIKJJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8258A00", Offset = "0x8257600", VA = "0x188258A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8258C10", Offset = "0x8257810", VA = "0x188258C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OMJJNLDDIOP<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OMJJNLDDIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x48E8E50", Offset = "0x48E7A50", VA = "0x1848E8E50")]
		internal void CHEHLBHOANO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5885A30", Offset = "0x5884630", VA = "0x185885A30")]
		internal void JKOJLBNFAOA(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GOLMLBIJMIC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public IGLBLJMIHPL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4F28340", Offset = "0x4F26F40", VA = "0x184F28340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4F289F0", Offset = "0x4F275F0", VA = "0x184F289F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct KACEJMIJGHD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825DDB0", Offset = "0x825C9B0", VA = "0x18825DDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x825E5A0", Offset = "0x825D1A0", VA = "0x18825E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct GEEJNJHFINH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825BAD0", Offset = "0x825A6D0", VA = "0x18825BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x825C010", Offset = "0x825AC10", VA = "0x18825C010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct DCLIHEHCJEJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4459450", Offset = "0x4458050", VA = "0x184459450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x445A350", Offset = "0x4458F50", VA = "0x18445A350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CFANCLPOBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<DIKEICNGGBM> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CFANCLPOBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82591C0", Offset = "0x8257DC0", VA = "0x1882591C0")]
		internal void GICOEIJJAAG(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct KBAAFGGFBIA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825E600", Offset = "0x825D200", VA = "0x18825E600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x825E880", Offset = "0x825D480", VA = "0x18825E880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct IDGCDLILAFJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5070BC0", Offset = "0x506F7C0", VA = "0x185070BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x44216F0", Offset = "0x44202F0", VA = "0x1844216F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct PBBHAAPKONH<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x59B6EB0", Offset = "0x59B5AB0", VA = "0x1859B6EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4420820", Offset = "0x441F420", VA = "0x184420820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct NBDDNMBNHCH<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x56F24B0", Offset = "0x56F10B0", VA = "0x1856F24B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x56F2CA0", Offset = "0x56F18A0", VA = "0x1856F2CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct AHILCJPOFBL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82583C0", Offset = "0x8256FC0", VA = "0x1882583C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x82585A0", Offset = "0x82571A0", VA = "0x1882585A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KPJLHPBHAEP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825EAC0", Offset = "0x825D6C0", VA = "0x18825EAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x825EE30", Offset = "0x825DA30", VA = "0x18825EE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BIPKCLLCJHG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8258E70", Offset = "0x8257A70", VA = "0x188258E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8259160", Offset = "0x8257D60", VA = "0x188259160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BCAOPOIELKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BCAOPOIELKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8258C80", Offset = "0x8257880", VA = "0x188258C80")]
		internal Task NDPCEOGPJON(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct FLILLCGGJNE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825B5D0", Offset = "0x825A1D0", VA = "0x18825B5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x825B830", Offset = "0x825A430", VA = "0x18825B830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct NGPHLLJICNE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8260670", Offset = "0x825F270", VA = "0x188260670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8260850", Offset = "0x825F450", VA = "0x188260850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IGMKDKCAALM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825D0A0", Offset = "0x825BCA0", VA = "0x18825D0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x825D400", Offset = "0x825C000", VA = "0x18825D400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct PDIGCKHJFGJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8264250", Offset = "0x8262E50", VA = "0x188264250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8264540", Offset = "0x8263140", VA = "0x188264540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AJACJKGPABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AJACJKGPABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8258600", Offset = "0x8257200", VA = "0x188258600")]
		internal Task FIKJBBGHNLD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct NEPLIGNNIOJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8260280", Offset = "0x825EE80", VA = "0x188260280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x82604E0", Offset = "0x825F0E0", VA = "0x1882604E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct OLMMIMMJBHN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8264070", Offset = "0x8262C70", VA = "0x188264070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x82641F0", Offset = "0x8262DF0", VA = "0x1882641F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BLOMINGHCPP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x66F2080", Offset = "0x66F0C80", VA = "0x1866F2080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x66F22D0", Offset = "0x66F0ED0", VA = "0x1866F22D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct ALJFCBIHDBF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8258670", Offset = "0x8257270", VA = "0x188258670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x82589A0", Offset = "0x82575A0", VA = "0x1882589A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? BIGBEMNNKLO;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<DIKEICNGGBM> FHEBGENHBMF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task LPBNDHBLFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8262280", Offset = "0x8260E80", VA = "0x188262280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8263E90", Offset = "0x8262A90", VA = "0x188263E90")]
	public static bool OICOIKDOEON(this Task MHGNKNMAFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E00830", Offset = "0x3DFF430", VA = "0x183E00830")]
	public static Task<T> NNOLFBCPAIE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8263140", Offset = "0x8261D40", VA = "0x188263140")]
	public static Task MJBNJNANIHA(this Task MHGNKNMAFFC, CancellationToken DANCOEFIHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE5B0", Offset = "0x3DFD1B0", VA = "0x183DFE5B0")]
	public static Task<TResult> MJBNJNANIHA<TResult>(this Task<TResult> MHGNKNMAFFC, CancellationToken DANCOEFIHDF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DFEB30", Offset = "0x3DFD730", VA = "0x183DFEB30")]
	public static TaskCompletionSource<TResult> MJBNJNANIHA<TResult>(this TaskCompletionSource<TResult> FFNPFGAHDNF, CancellationToken DANCOEFIHDF) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82623F0", Offset = "0x8260FF0", VA = "0x1882623F0")]
	public static IDisposable? FMIHFOODNDD(CancellationToken PKLLJIGOLIN, CancellationToken OOJDDFCCICM, [Out] CancellationToken FCPLOIJJEFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8263D30", Offset = "0x8262930", VA = "0x188263D30")]
	[AsyncStateMachine(typeof(JBHLGINGHFP))]
	public static void NIBLONKGNIA(this Task KJCIKLJPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82622F0", Offset = "0x8260EF0", VA = "0x1882622F0")]
	[AsyncStateMachine(typeof(HGFCOFBNCOF))]
	public static void ECOCFKIHGNK(this Task KJCIKLJPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB730", Offset = "0x3DFA330", VA = "0x183DFB730")]
	[AsyncStateMachine(typeof(BGBLKAGHLAF<>))]
	public static Task ALIDFBDOMPJ<TException>(this Task KJCIKLJPCMB) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB800", Offset = "0x3DFA400", VA = "0x183DFB800")]
	[AsyncStateMachine(typeof(OOLOMOIJJHA<>))]
	public static Task<T> EHFJLEAGGCC<T>(this Task<T> JBDFDFABHKD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8262D20", Offset = "0x8261920", VA = "0x188262D20")]
	[AsyncStateMachine(typeof(BBBBNEOIKJJ))]
	public static Task<TaskStatus> KJJLLNBAJEA(this Task? JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB9C0", Offset = "0x3DFA5C0", VA = "0x183DFB9C0")]
	public static (Task<T?>?, Action<T?>?) FPGHLONGMHB<T>([Optional] CancellationToken JHCOCAANJDL)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E00980", Offset = "0x3DFF580", VA = "0x183E00980")]
	[AsyncStateMachine(typeof(GOLMLBIJMIC<, >))]
	public static Task<List<TResult>> NOHKCFGHAIL<TResult, TInput>(this Task<List<TInput>> MHGNKNMAFFC, IGLBLJMIHPL<TInput, TResult> LDBGKDCGAAK) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8262B70", Offset = "0x8261770", VA = "0x188262B70")]
	[AsyncStateMachine(typeof(KACEJMIJGHD))]
	public static Task IOABDLHPNFL(Task KJCIKLJPCMB, CancellationToken KNEMOCFJIEK, Func<CancellationToken, Task> FFPNLMDNLOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82625D0", Offset = "0x82611D0", VA = "0x1882625D0")]
	[AsyncStateMachine(typeof(GEEJNJHFINH))]
	public static Task GLOCPMGAHNH(Func<CancellationToken, Task> ENOHPFHLCJD, TimeSpan CPMCAMKMDEF, [Optional] CancellationToken KNEMOCFJIEK, [Optional] Action<OperationCanceledException>? JMLJLAJFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DFBC00", Offset = "0x3DFA800", VA = "0x183DFBC00")]
	[AsyncStateMachine(typeof(DCLIHEHCJEJ<>))]
	public static Task<T> GLOCPMGAHNH<T>(Func<CancellationToken, Task<T>> ENOHPFHLCJD, TimeSpan CPMCAMKMDEF, [Optional] CancellationToken KNEMOCFJIEK, [Optional] Func<OperationCanceledException, T>? JMLJLAJFIHD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8263CE0", Offset = "0x82628E0", VA = "0x188263CE0")]
	public static Task NEEIHPPIDJM(params Task[] JANDBNIGGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8263820", Offset = "0x8262420", VA = "0x188263820")]
	public static Task NEEIHPPIDJM(IEnumerable<Task> JANDBNIGGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x82633A0", Offset = "0x8261FA0", VA = "0x1882633A0")]
	[AsyncStateMachine(typeof(KBAAFGGFBIA))]
	public static Task<IEnumerable<Task>> MJLBLJGJIEI(IEnumerable<Task> JANDBNIGGGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E00750", Offset = "0x3DFF350", VA = "0x183E00750")]
	[AsyncStateMachine(typeof(IDGCDLILAFJ<>))]
	public static Task<IEnumerable<Task<T>>> MJLBLJGJIEI<T>(IEnumerable<Task<T>> JANDBNIGGGD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC120", Offset = "0x3DFAD20", VA = "0x183DFC120")]
	[AsyncStateMachine(typeof(PBBHAAPKONH<, , >))]
	public static Task<(T1, T2, T3)> LKCHKLCEPEF<T1, T2, T3>(Task<T1> PNHMJBPIBAI, Task<T2> DDJHPEBINJK, Task<T3> KKOFCKEELGA) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFBE60", Offset = "0x3DFAA60", VA = "0x183DFBE60")]
	[AsyncStateMachine(typeof(NBDDNMBNHCH<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> LKCHKLCEPEF<T1, T2, T3, T4, T5>(Task<T1> PNHMJBPIBAI, Task<T2> DDJHPEBINJK, Task<T3> KKOFCKEELGA, Task<T4> MELJJHACJKG, Task<T5> GJEOAFKAHDK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8261E00", Offset = "0x8260A00", VA = "0x188261E00")]
	[AsyncStateMachine(typeof(AHILCJPOFBL))]
	public static Task AIHILIBCIEH(Func<bool> MBDNDPHCDDE, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8261CF0", Offset = "0x82608F0", VA = "0x188261CF0")]
	[AsyncStateMachine(typeof(KPJLHPBHAEP))]
	public static Task AIHILIBCIEH(Func<bool> MBDNDPHCDDE, TimeSpan ACIDBLDAJNA, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8262A40", Offset = "0x8261640", VA = "0x188262A40")]
	[AsyncStateMachine(typeof(BIPKCLLCJHG))]
	public static Task IAHPIIJLGCD(Func<bool> MBDNDPHCDDE, TimeSpan CPMCAMKMDEF, [Optional] CancellationToken JHCOCAANJDL, [Optional] Action<OperationCanceledException>? JMLJLAJFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8262900", Offset = "0x8261500", VA = "0x188262900")]
	[AsyncStateMachine(typeof(FLILLCGGJNE))]
	public static Task IAHPIIJLGCD(Func<bool> MBDNDPHCDDE, TimeSpan CPMCAMKMDEF, TimeSpan ACIDBLDAJNA, [Optional] CancellationToken JHCOCAANJDL, [Optional] Action<OperationCanceledException>? JMLJLAJFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8262700", Offset = "0x8261300", VA = "0x188262700")]
	[AsyncStateMachine(typeof(NGPHLLJICNE))]
	public static Task HLBOGLMNJBK(Func<bool> MBDNDPHCDDE, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82627F0", Offset = "0x82613F0", VA = "0x1882627F0")]
	[AsyncStateMachine(typeof(IGMKDKCAALM))]
	public static Task HLBOGLMNJBK(Func<bool> MBDNDPHCDDE, TimeSpan ACIDBLDAJNA, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8262010", Offset = "0x8260C10", VA = "0x188262010")]
	[AsyncStateMachine(typeof(PDIGCKHJFGJ))]
	public static Task CJHONFOMNGL(Func<bool> MBDNDPHCDDE, TimeSpan CPMCAMKMDEF, [Optional] CancellationToken JHCOCAANJDL, [Optional] Action<OperationCanceledException>? JMLJLAJFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8262140", Offset = "0x8260D40", VA = "0x188262140")]
	[AsyncStateMachine(typeof(NEPLIGNNIOJ))]
	public static Task CJHONFOMNGL(Func<bool> MBDNDPHCDDE, TimeSpan CPMCAMKMDEF, TimeSpan ACIDBLDAJNA, [Optional] CancellationToken JHCOCAANJDL, [Optional] Action<OperationCanceledException>? JMLJLAJFIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8263EC0", Offset = "0x8262AC0", VA = "0x188263EC0")]
	[Obsolete]
	[AsyncStateMachine(typeof(OLMMIMMJBHN))]
	public static Task OPEBKKDGBJI(this Task MHGNKNMAFFC, Action BCFCADKIIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3E00A80", Offset = "0x3DFF680", VA = "0x183E00A80")]
	[AsyncStateMachine(typeof(BLOMINGHCPP<>))]
	[Obsolete]
	public static Task OPEBKKDGBJI<T>(this Task<T> MHGNKNMAFFC, Action<T> BCFCADKIIIG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8263DE0", Offset = "0x82629E0", VA = "0x188263DE0")]
	private static void NPIEGHEIPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x82634A0", Offset = "0x82620A0", VA = "0x1882634A0")]
	public static bool NDBIMGGMLFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8262EE0", Offset = "0x8261AE0", VA = "0x188262EE0")]
	private static void LCJICICIMOA(SynchronizationContext BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8261EF0", Offset = "0x8260AF0", VA = "0x188261EF0")]
	private static void BPLDMGEOOLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8262E10", Offset = "0x8261A10", VA = "0x188262E10")]
	public static void KOFPIPJFIKM([Optional] string? HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8262CA0", Offset = "0x82618A0", VA = "0x188262CA0")]
	public static void KINHMIPBGLB([Optional] string? HLMEMBFCHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x82623A0", Offset = "0x8260FA0", VA = "0x1882623A0")]
	public static NEAIJENDILF FELLBNGCCMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8262580", Offset = "0x8261180", VA = "0x188262580")]
	public static NEAIJENDILF GDBNOEEMACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8263070", Offset = "0x8261C70", VA = "0x188263070")]
	[AsyncStateMachine(typeof(ALJFCBIHDBF))]
	public static Task MEEBHNFMNDB(Func<Task> LOCAHCLFLKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GOLNKMGDHKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public GOLNKMGDHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GDJCAMBAHLP
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x825B890", Offset = "0x825A490", VA = "0x18825B890")]
	public static bool CGLODMJBFMK(this GAFEJJBMOGG BGKMCPLPIKD, DateTime EDJIINHODME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x825B9B0", Offset = "0x825A5B0", VA = "0x18825B9B0")]
	public static TimeSpan KILBJINBCKI(this GAFEJJBMOGG BGKMCPLPIKD, DateTime EDJIINHODME)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PPNBLACGGCA : GAFEJJBMOGG
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly GAFEJJBMOGG MFAGMJBMEEP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime LHNJHHDFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8264600", Offset = "0x8263200", VA = "0x188264600", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset EHENOPELLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x82645A0", Offset = "0x82631A0", VA = "0x1882645A0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PPNBLACGGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface GAFEJJBMOGG
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime LHNJHHDFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset EHENOPELLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class FLENPJCGFFB
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long AHCNCHNFJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x825B140", Offset = "0x8259D40", VA = "0x18825B140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long ABIKFGPFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x825AE00", Offset = "0x8259A00", VA = "0x18825AE00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double FJMDMMPBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x825B060", Offset = "0x8259C60", VA = "0x18825B060")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double NFKFDFMDDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x825AE50", Offset = "0x8259A50", VA = "0x18825AE50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double PPFALGNLIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x825B010", Offset = "0x8259C10", VA = "0x18825B010")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double NIGCMMADBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x825AEA0", Offset = "0x8259AA0", VA = "0x18825AEA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x825B190", Offset = "0x8259D90", VA = "0x18825B190")]
	public static double LBMEGPBCILN(long LBLFAOOPEMD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x825AEF0", Offset = "0x8259AF0", VA = "0x18825AEF0")]
	public static double FMOPONEHGCJ(long LBLFAOOPEMD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x825B0B0", Offset = "0x8259CB0", VA = "0x18825B0B0")]
	public static double JFMJPDDDDDA(double EOEKIDOMNCM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x825AF80", Offset = "0x8259B80", VA = "0x18825AF80")]
	public static long FNCOFKJMKHM(long DJMONOPAJCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x825B220", Offset = "0x8259E20", VA = "0x18825B220")]
	public static long LEIKIGALPOH(long PKKJKACFIND, long GPEJLFOIBJK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x825B230", Offset = "0x8259E30", VA = "0x18825B230")]
	public static double NNHKKMAHOGB(long PKKJKACFIND, long GPEJLFOIBJK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x825ADA0", Offset = "0x82599A0", VA = "0x18825ADA0")]
	public static double AMMHEABLKGL(long PKKJKACFIND, long GPEJLFOIBJK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class JAJGLPJKAPC : DCKJGFLKGOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly TimeSpan IJCGBJMCHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly System.Timers.Timer LFPPCCOIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private TimeSpan CPMCAMKMDEF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan PONCELFFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x825D690", Offset = "0x825C290", VA = "0x18825D690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? FAAHHEODBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x825DBE0", Offset = "0x825C7E0", VA = "0x18825DBE0")]
	[Preserve]
	public JAJGLPJKAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x825D990", Offset = "0x825C590", VA = "0x18825D990")]
	public JAJGLPJKAPC(TimeSpan CPMCAMKMDEF, [Optional] Action? ECGKPAONBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x825D890", Offset = "0x825C490", VA = "0x18825D890", Slot = "7")]
	public void JLODMKOIAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x825D550", Offset = "0x825C150", VA = "0x18825D550", Slot = "8")]
	public void AADFPNEDNGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x825D5C0", Offset = "0x825C1C0", VA = "0x18825D5C0", Slot = "9")]
	public void AKGEMMIDJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1289A70", Offset = "0x1288670", VA = "0x181289A70")]
	private void NKDCMIGDFEH(object HPNKJCMLGMJ, ElapsedEventArgs NGENHMBMKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x825D7F0", Offset = "0x825C3F0", VA = "0x18825D7F0")]
	private static void IHFCGCNHBCA(TimeSpan APOPENJNAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x825D5F0", Offset = "0x825C1F0", VA = "0x18825D5F0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ABLFJIFLPNO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly string? KHMIPOHMNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string AIPBCIKCLMO;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x18C7E30", Offset = "0x18C6A30", VA = "0x1818C7E30")]
	public ABLFJIFLPNO(string JKEAHMPNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x525B0D0", Offset = "0x5259CD0", VA = "0x18525B0D0")]
	public ABLFJIFLPNO(string GMFCELNCIOG, string JKEAHMPNEHK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct ACPCGMFEMME : IEquatable<ACPCGMFEMME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public uint CGDAEBNKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public int OHNLCLIKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float DEJIGIKAJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public ushort DIIINFLKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public ushort ACHCLCPAAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public short JIBMAFIKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public short JAEEGIBPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public char JEOFOAMKDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public char EOBCCIANEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte KPPEHPFPAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte MCNJNHPKFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte BDFJCAHCMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte NACJJBIOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool OBDJMJIBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool OKFGMCNJGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool MJGIDANCCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool LOELJMJOPOD;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
	public static ACPCGMFEMME FOLBGOKCACA(uint KOIJODOAKAJ)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
	public static ACPCGMFEMME JMEABOLDPPL(int PGECIKHBNKO)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8257550", Offset = "0x8256150", VA = "0x188257550")]
	public static ACPCGMFEMME FGAHOBNDHOJ(float NFNAMBIGHHO)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x82574A0", Offset = "0x82560A0", VA = "0x1882574A0")]
	public static ACPCGMFEMME LGOMCGLJLFM(byte DHIFLEOEKFJ, byte AIPDJAPGAPN, byte AJIGOMGLHAL, byte DIHLJKFMILE)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x82574A0", Offset = "0x82560A0", VA = "0x1882574A0")]
	public static ACPCGMFEMME AMBALFKPIIO(bool DAHKOPJNDGM, bool ICAIOPKBJNP, bool IPJHEBHNMEP, bool PPKAKCGGGOH)
	{
		return default(ACPCGMFEMME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x82574A0", Offset = "0x82560A0", VA = "0x1882574A0")]
	public static ACPCGMFEMME MIDBIPDLFFJ(byte CAKBGJAEGNH, byte EIJANKGDEBF, byte LJFEBOMAKCP, byte PDPIICOAMCJ)
	{
		return default(ACPCGMFEMME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x24065A0", Offset = "0x24051A0", VA = "0x1824065A0")]
	public static bool CDGFDPOPEPC(ACPCGMFEMME OHEOONFKODG, ACPCGMFEMME GOPANKCDGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2406580", Offset = "0x2405180", VA = "0x182406580", Slot = "4")]
	public bool Equals(ACPCGMFEMME IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x82574C0", Offset = "0x82560C0", VA = "0x1882574C0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x150B3A0", Offset = "0x1509FA0", VA = "0x18150B3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8257560", Offset = "0x8256160", VA = "0x188257560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LJDPDPMNPFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public ulong EJFOADIIHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public long KPCNMGEKCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public double PHIJCPBBDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public uint EFDKALPCMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public uint GPFKJNBADLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public int BKFBFMFLCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public int MIPHPJBKOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public float LHEJLFJHAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float NAEGJKMDOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public ushort DIIINFLKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public ushort ACHCLCPAAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public ushort KJMBOLGDBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public ushort OJEGDNHAOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public short JIBMAFIKOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public short JAEEGIBPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public short FHKJPDGCMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public short EPPFIDPAJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public char JEOFOAMKDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public char EOBCCIANEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public char GGOPGNOCNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public char FAGLFBFEHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte KPPEHPFPAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte MCNJNHPKFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte BDFJCAHCMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public byte NACJJBIOGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public byte JOMDGEEELKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public byte JDFIPNHNPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public byte OBFOPJIACOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte KNMEBOCKHNF;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static LJDPDPMNPFP MJMNOIPJNFN(long LIKFGAMANAG)
	{
		return default(LJDPDPMNPFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x825EE90", Offset = "0x825DA90", VA = "0x18825EE90")]
	public static LJDPDPMNPFP MJMNOIPJNFN(byte DHIFLEOEKFJ, byte AIPDJAPGAPN, byte AJIGOMGLHAL, byte DIHLJKFMILE, byte FPJADHFCGDL, byte NHEJCKPOKLG, byte HIBJIGNIGFO, byte IAHCGLKLMAO)
	{
		return default(LJDPDPMNPFP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct FKIDBODHNCI : IEquatable<FKIDBODHNCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte AGDOOCHPDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool DFNJOBEANJB;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x31354F0", Offset = "0x31340F0", VA = "0x1831354F0")]
	public static FKIDBODHNCI LGOMCGLJLFM(byte GGPGFDAPEAH)
	{
		return default(FKIDBODHNCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x31354F0", Offset = "0x31340F0", VA = "0x1831354F0")]
	public static FKIDBODHNCI AMBALFKPIIO(bool KDINKPBLAHA)
	{
		return default(FKIDBODHNCI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x825AA80", Offset = "0x8259680", VA = "0x18825AA80")]
	public static bool CDGFDPOPEPC(FKIDBODHNCI OHEOONFKODG, FKIDBODHNCI GOPANKCDGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7126370", Offset = "0x7124F70", VA = "0x187126370", Slot = "4")]
	public bool Equals(FKIDBODHNCI IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x825AA90", Offset = "0x8259690", VA = "0x18825AA90", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x825AB20", Offset = "0x8259720", VA = "0x18825AB20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x825AB30", Offset = "0x8259730", VA = "0x18825AB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class MDBDNKLHHIN<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public readonly T BCGDNIHJKDO;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5663BB0", Offset = "0x56627B0", VA = "0x185663BB0")]
	public MDBDNKLHHIN(T IFBMDIBNJHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class IADNFNHLMMC
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3C4FC70", Offset = "0x3C4E870", VA = "0x183C4FC70")]
	public static IEnumerable<T> GOMIIAICLDG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static T[] PIIHGJMDHAN<T>(params T[] JOAAHAFIJKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static IEnumerable<T> DFDPHFDMKLK<T>(params T[] JOAAHAFIJKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static HashSet<T> KJBEMMNCAFD<T>(params T[] JOAAHAFIJKF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3C7A710", Offset = "0x3C79310", VA = "0x183C7A710")]
	public static KeyValuePair<TKey, TValue> MFDLAKAGJNJ<TKey, TValue>([In] TKey DHCHBFGMFFD, [In] TValue BKMPCFIAHIG) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x39C4240", Offset = "0x39C2E40", VA = "0x1839C4240")]
	public static List<T> OHMAGIEMIIE<T>(IEnumerable<T> LNODOELCPNI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[AttributeUsage(AttributeTargets.All)]
public sealed class LCCLJGCDHGO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public readonly string LFGKLBBBFBF;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
	public LCCLJGCDHGO(string MMGNGPFBICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object GPPIJGBGIGE<T>([In] T AHEPAEIEJIO);
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object KMCOGECJBLO<T>(T AHEPAEIEJIO);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[IHBLOHBJKLP]
public delegate string HDCPHONKOJG(string JIBDMFNCFIM, string? MKMPFLKICKK, bool AODNMAMJCOK);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[IHBLOHBJKLP]
public delegate void CGFCEKCPKGG(string HLMEMBFCHLD);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[IHBLOHBJKLP]
public delegate void JPNEEOPEHIL(Exception EBNIDHCOLMC);
[Cpp2IlInjected.Token(Token = "0x200006C")]
public delegate object BOBFGDACOPD();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[IHBLOHBJKLP]
public delegate bool GONDFGAPGNB();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[IHBLOHBJKLP]
public delegate string OPNJOBGHINI(object KOJLNGLNBMH);
[Cpp2IlInjected.Token(Token = "0x200006F")]
[AttributeUsage(AttributeTargets.Enum)]
public class JNGMDIJOALB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
	public JNGMDIJOALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class OCAAEDECADF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct MOJHIOJJIJF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x825F8C0", Offset = "0x825E4C0", VA = "0x18825F8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x82601A0", Offset = "0x825EDA0", VA = "0x1882601A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly TimerCallback CIKMEGLOKDE;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly Action<object?> PAHEMJDALOM;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x82618D0", Offset = "0x82604D0", VA = "0x1882618D0")]
	public static Task<bool> GOCONHMHFHF(int NKMMPNPBGOB, [Optional] CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8261710", Offset = "0x8260310", VA = "0x188261710")]
	[AsyncStateMachine(typeof(MOJHIOJJIJF))]
	private static Task<bool> EKBFEMDICBJ(int NKMMPNPBGOB, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8261680", Offset = "0x8260280", VA = "0x188261680")]
	private static void BDMPIKOILIP(object? EKPDKNLBIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8261840", Offset = "0x8260440", VA = "0x188261840")]
	private static void GFLLEDFHPJG(object? EKPDKNLBIHJ)
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
