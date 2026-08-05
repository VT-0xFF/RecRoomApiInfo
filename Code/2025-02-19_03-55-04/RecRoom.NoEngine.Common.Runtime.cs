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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75BA1A0", Offset = "0x75B8DA0", VA = "0x1875BA1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CMCNAELJAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75B1CD0", Offset = "0x75B08D0", VA = "0x1875B1CD0")]
	public static string GGEGGEGMACJ(this Encoding DCEKCNAEBLM, [In] ReadOnlySequence<byte> FOLLKKLPOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x316A910", Offset = "0x3169510", VA = "0x18316A910")]
	private static void MHKBHPPNGMC<T>(this ReadOnlySequence<T> FJOBJOGFMDF, [Out] ReadOnlySpan<T> IIHJCNPAMIE, [Out] SequencePosition OHOKBHAKHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class CEOPOBLKIIK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75B1BF0", Offset = "0x75B07F0", VA = "0x1875B1BF0")]
	public CEOPOBLKIIK(bool OCPNOHHMAJD, string MEGICKPIFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x172BF90", Offset = "0x172AB90", VA = "0x18172BF90")]
	public CEOPOBLKIIK(bool OCPNOHHMAJD, params string[] ANJNLKDKFLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HEEDKIFJMNC
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FKCAFEDNAOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BELJFNJDLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGGIBLDGFOE(string NKANGPLHEGE, double MPDLOLIOGJL, [Optional] string? KCLFHKOOEIM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CPKJANIAKFI : CDDMDDCHIPB, EPLMBJGGEGI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int AAPKMIBPCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> CJIOINFDNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double DMOKGKPBDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double IBGGHDAOBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double CKDKKNHJNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JCDIGCCMGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double CHMKBPFOMHJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FHKNCCHBJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9766D0", Offset = "0x9752D0", VA = "0x1809766D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EMABLNNLACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75B2530", Offset = "0x75B1130", VA = "0x1875B2530", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double CCLKNAHIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x493B8B0", Offset = "0x493A4B0", VA = "0x18493B8B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double ABNNGJBGIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x24D6BE0", Offset = "0x24D57E0", VA = "0x1824D6BE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75B2590", Offset = "0x75B1190", VA = "0x1875B2590")]
	public CPKJANIAKFI(int KKKEEDCGPDM, double CHMKBPFOMHJ = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75B2290", Offset = "0x75B0E90", VA = "0x1875B2290", Slot = "7")]
	public void APMIDCJFNFH(double ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75B24C0", Offset = "0x75B10C0", VA = "0x1875B24C0", Slot = "8")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75B23C0", Offset = "0x75B0FC0", VA = "0x1875B23C0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BINEGOCHCPC : CDDMDDCHIPB, EPLMBJGGEGI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long EBDKDADIOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double MCPFNMOBKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double MICFMABPPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double IBHBNHOFKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double BPEGAKEJOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double DMOKGKPBDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double IBGGHDAOBFM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double CCLKNAHIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69961C0", Offset = "0x6994DC0", VA = "0x1869961C0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double ABNNGJBGIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6996250", Offset = "0x6994E50", VA = "0x186996250", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FADCKBFADPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6995D70", Offset = "0x6994970", VA = "0x186995D70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double EMABLNNLACF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B60A20", Offset = "0x2B5F620", VA = "0x182B60A20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75B0960", Offset = "0x75AF560", VA = "0x1875B0960", Slot = "10")]
	public virtual void APMIDCJFNFH(double ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x75B0AF0", Offset = "0x75AF6F0", VA = "0x1875B0AF0", Slot = "11")]
	public virtual void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x75B0A80", Offset = "0x75AF680", VA = "0x1875B0A80", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75B0B30", Offset = "0x75AF730", VA = "0x1875B0B30")]
	public BINEGOCHCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FCNPONPAOOB : BINEGOCHCPC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GOPAHAEPNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6996230", Offset = "0x6994E30", VA = "0x186996230")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6995D60", Offset = "0x6994960", VA = "0x186995D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75B5D30", Offset = "0x75B4930", VA = "0x1875B5D30", Slot = "10")]
	public override void APMIDCJFNFH(double ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x75B5E60", Offset = "0x75B4A60", VA = "0x1875B5E60", Slot = "11")]
	public override void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x75B0B30", Offset = "0x75AF730", VA = "0x1875B0B30")]
	public FCNPONPAOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDDMDDCHIPB : EPLMBJGGEGI, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EMABLNNLACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double CCLKNAHIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double ABNNGJBGIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KPAFNKKDLOJ : EPLMBJGGEGI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double MPKFNDBFNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double FFLHIFPFOFD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75B8FE0", Offset = "0x75B7BE0", VA = "0x1875B8FE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75B8FD0", Offset = "0x75B7BD0", VA = "0x1875B8FD0", Slot = "4")]
	public void APMIDCJFNFH(double ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75B9040", Offset = "0x75B7C40", VA = "0x1875B9040", Slot = "5")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75B8FF0", Offset = "0x75B7BF0", VA = "0x1875B8FF0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public KPAFNKKDLOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EPLMBJGGEGI : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APMIDCJFNFH(double ODFJOPDFEGP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDPJFJHBEFN();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LMKKPICPDDJ : EPLMBJGGEGI, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double MPDLOLIOGJL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GNLOKINMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40706D0", Offset = "0x406F2D0", VA = "0x1840706D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4DD8120", Offset = "0x4DD6D20", VA = "0x184DD8120", Slot = "4")]
	public void APMIDCJFNFH(double ODFJOPDFEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x75B9320", Offset = "0x75B7F20", VA = "0x1875B9320", Slot = "5")]
	public void EDPJFJHBEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75B92D0", Offset = "0x75B7ED0", VA = "0x1875B92D0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public LMKKPICPDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKKDJEIAODO<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> CFMCPOGEHLF(CancellationToken NAOIMKEDKEJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ADLDDJJJCGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CKKDJEIAODO<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CFMCPOGEHLF taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4546CA0", Offset = "0x45458A0", VA = "0x184546CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4547DE0", Offset = "0x45469E0", VA = "0x184547DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource HGGNOAGNIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? BPKOPBKOKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? MBDGFBOGEDG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5B984C0", Offset = "0x5B970C0", VA = "0x185B984C0")]
	[AsyncStateMachine(typeof(CKKDJEIAODO<>.ADLDDJJJCGC))]
	public Task<TResult> BBLPABCKIGF(CFMCPOGEHLF GELEMJBLADG, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5B98610", Offset = "0x5B97210", VA = "0x185B98610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5B98680", Offset = "0x5B97280", VA = "0x185B98680")]
	public CKKDJEIAODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DBFKFPAPBHA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> LFNHPPJGEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T GNLOKINMAMH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4DE8D90", Offset = "0x4DE7990", VA = "0x184DE8D90")]
	public DBFKFPAPBHA([In] T MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62EF5D0", Offset = "0x62EE1D0", VA = "0x1862EF5D0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62EFD00", Offset = "0x62EE900", VA = "0x1862EFD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62F00E0", Offset = "0x62EECE0", VA = "0x1862F00E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BEAJJKCIFLM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static DBFKFPAPBHA<T> JPHABLICNHB<T>([In] T MPDLOLIOGJL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KLBLBCEAGHO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x75B83D0", Offset = "0x75B6FD0", VA = "0x1875B83D0")]
	public static void FJMAEJAOHNK(this CancellationTokenSource HGGNOAGNIMP, bool OPHOJONDCIJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FNKEIOFGMPP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public FNKEIOFGMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class ANKPNCJPHAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public ANKPNCJPHAA(string PDGPMIMOABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KPOJMIBEHOA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3445C70", Offset = "0x3444870", VA = "0x183445C70")]
	public static ALLOIHPLAKC HDFPGMGBGIK<T>()
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3445A50", Offset = "0x3444650", VA = "0x183445A50")]
	public static ALLOIHPLAKC CNNMOJKCLAK<T>([CallerMemberName] string BGKKCEGMOKH = "") where T : notnull
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3445BF0", Offset = "0x34447F0", VA = "0x183445BF0")]
	public static ALLOIHPLAKC HDFPGMGBGIK<T>(this T LOJMCGAMMAK) where T : notnull
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3445CF0", Offset = "0x34448F0", VA = "0x183445CF0")]
	public static ALLOIHPLAKC ONDOECHLLAM<T>(this T LOJMCGAMMAK, [CallerMemberName] string BGKKCEGMOKH = "") where T : notnull
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34459A0", Offset = "0x34445A0", VA = "0x1834459A0")]
	public static ALLOIHPLAKC CNNMOJKCLAK<T>(this T DKGDAEBOJKO, [CallerMemberName] string BGKKCEGMOKH = "") where T : notnull
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x75B9250", Offset = "0x75B7E50", VA = "0x1875B9250")]
	public static ALLOIHPLAKC CNNMOJKCLAK(string HEOAOJGELCL, [CallerMemberName] string BGKKCEGMOKH = "")
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75B91B0", Offset = "0x75B7DB0", VA = "0x1875B91B0")]
	public static string AKGANNHDGAI(this object DKGDAEBOJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool OIHHPICDHDE();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FNKEIOFGMPP]
public delegate long BNMAFGDOPEM();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CEAGEFLEPOG
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static EAEKAMLCFND NLMJNIPOPEN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static EAEKAMLCFND DPDPJLKJKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75B14E0", Offset = "0x75B00E0", VA = "0x1875B14E0")]
		get
		{
			return default(EAEKAMLCFND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static KLGOFGIBFIA DPOHHIEKBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x75B10E0", Offset = "0x75AFCE0", VA = "0x1875B10E0")]
		get
		{
			return default(KLGOFGIBFIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static PEJDGHKGNNJ JDNAMDEACBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x75B11A0", Offset = "0x75AFDA0", VA = "0x1875B11A0")]
		get
		{
			return default(PEJDGHKGNNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool OBLIJNMFNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x75B1130", Offset = "0x75AFD30", VA = "0x1875B1130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x75B1530", Offset = "0x75B0130", VA = "0x1875B1530")]
	public static void INAMELFIOMJ([In] EAEKAMLCFND ACILPMPFHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75B1370", Offset = "0x75AFF70", VA = "0x1875B1370")]
	public static void HBFNBGCENOB(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x75B1750", Offset = "0x75B0350", VA = "0x1875B1750")]
	public static void OCMEEKEHCCG(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3166490", Offset = "0x3165090", VA = "0x183166490")]
	public static void OCMEEKEHCCG<T>(T GJPLANLJOMM, MNKPOLALJJC<T> KBPDEFFIKOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75B1440", Offset = "0x75B0040", VA = "0x1875B1440")]
	public static void HNJGHAFKLPA(Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75B16D0", Offset = "0x75B02D0", VA = "0x1875B16D0")]
	public static void MHHBEIAFGJE(string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75B11F0", Offset = "0x75AFDF0", VA = "0x1875B11F0")]
	public static void EGHAEJLABBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x75B1070", Offset = "0x75AFC70", VA = "0x1875B1070")]
	public static string AKGANNHDGAI(object CFMCKCBBBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x75B1260", Offset = "0x75AFE60", VA = "0x1875B1260")]
	public static long FAFNJOOJBFF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x75B12D0", Offset = "0x75AFED0", VA = "0x1875B12D0")]
	public static bool FGDELHDCCGD(bool IKHACMHNJDM, string KBPDEFFIKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75B1820", Offset = "0x75B0420", VA = "0x1875B1820")]
	public static double PFKHIJGAFHC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EAEKAMLCFND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly KLGOFGIBFIA DPOHHIEKBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly PEJDGHKGNNJ JDNAMDEACBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly NHBJIJGANDA LMEAJHCONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly BNMAFGDOPEM PPPKHJNAMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly EKAHLNHHPBI BGPDPBHHEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly OIHHPICDHDE MADHHECELIE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NHBJIJGANDA ENHLKCNIHPL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BNMAFGDOPEM MOPIEHJEOLL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EKAHLNHHPBI EAHCFEDCECE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly OIHHPICDHDE IOJMDHGPCLC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EAEKAMLCFND PCKMBPNMICK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OIEJENPKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75B49D0", Offset = "0x75B35D0", VA = "0x1875B49D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75B5220", Offset = "0x75B3E20", VA = "0x1875B5220")]
	public EAEKAMLCFND([In] KLGOFGIBFIA EMALPPAIFEH, [In] PEJDGHKGNNJ ADEMNICIPAO, NHBJIJGANDA FDMMGABDCMC, BNMAFGDOPEM LIKCFBIBNFN, EKAHLNHHPBI MHPHEFFFFHG, OIHHPICDHDE PCDPCNKAAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x75B4890", Offset = "0x75B3490", VA = "0x1875B4890")]
	private static string CJHGHBOINBL(object CFMCKCBBBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0")]
	private static long LDPFDPPBMJG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	private static string LBDDNOPFBNA(string FDHHCKGHMND, string? NIIENGDOBFN, bool EHKJIOAOCFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	private static bool CNONFKGCNKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x75B48D0", Offset = "0x75B34D0", VA = "0x1875B48D0")]
	private static EAEKAMLCFND NCCAOOOBBKA()
	{
		return default(EAEKAMLCFND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LBDDOGOFLPN
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNIFCDPBAPB MADAPDACNGL();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface MNIFCDPBAPB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MCDJDPMKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEFBJMINLAK();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DEHBBIJPDMB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPLOCOJHLFI([In] T PELBNOCGOOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void EADGNLFNCPC<T>([In] T GJPLANLJOMM);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct LPJPJOKGHLD<T> : IEquatable<LPJPJOKGHLD<T>>, DEHBBIJPDMB<LPJPJOKGHLD<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T GNLOKINMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int AHDPANGFLKC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B53400", Offset = "0x4B52000", VA = "0x184B53400")]
	public LPJPJOKGHLD([In] T MPDLOLIOGJL, int BIEEMEKMINN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B520D0", Offset = "0x4B50CD0", VA = "0x184B520D0")]
	public static bool LBLECGDECIN([In] LPJPJOKGHLD<T> NFOAKNOEKCL, [In] LPJPJOKGHLD<T> AFFPJGJMKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B26FB0", Offset = "0x4B25BB0", VA = "0x184B26FB0", Slot = "4")]
	public bool Equals(LPJPJOKGHLD<T> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4419B80", Offset = "0x4418780", VA = "0x184419B80", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B51B10", Offset = "0x4B50710", VA = "0x184B51B10")]
	public bool FPLOCOJHLFI([In] LPJPJOKGHLD<T> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B51C20", Offset = "0x4B50820", VA = "0x184B51C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B52EE0", Offset = "0x4B51AE0", VA = "0x184B52EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B51240", Offset = "0x4B4FE40", VA = "0x184B51240")]
	public void EALEPKLOIDH([Out] T MPDLOLIOGJL, [Out] int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4B52AB0", Offset = "0x4B516B0", VA = "0x184B52AB0")]
	public (T, int) PGGPKLPNFLM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4B52730", Offset = "0x4B51330", VA = "0x184B52730", Slot = "5")]
	private bool OHMAAKPNCJL([In] LPJPJOKGHLD<T> PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CENNEBAKKFK
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3166620", Offset = "0x3165220", VA = "0x183166620")]
	public static LPJPJOKGHLD<T> JPHABLICNHB<T>([In] T MPDLOLIOGJL, int BIEEMEKMINN) where T : notnull
	{
		return default(LPJPJOKGHLD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PCBEKCNFMPI
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x35572D0", Offset = "0x3555ED0", VA = "0x1835572D0")]
	public static bool FPLOCOJHLFI<T, U>([In] T DKGDAEBOJKO, [In] U CFMCKCBBBKK) where T : notnull, DEHBBIJPDMB<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult OCDPDGGDABA<T, out TResult>([In] T GJPLANLJOMM);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PGEMJLKCHBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan OGKHCFHKKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? LMJDPBECNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEKDGOPFPIM();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGNMNFLGLCC();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FLFLNOAJBKH();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct KLGOFGIBFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly AHIKEIDCNDI PBPPMJFMICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly ECLOBOFEBGL EONANJIIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly AHIKEIDCNDI MIBPLCBLNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly ECLOBOFEBGL AIHPFIDKHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly AHIKEIDCNDI KFKACALIMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly ECLOBOFEBGL NEEKDECPMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly AKNEJOKCHKJ HOPHHAHKFEK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly AHIKEIDCNDI CDDCPFFEENK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly ECLOBOFEBGL GNAENGLONOG;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly AHIKEIDCNDI LKHAOPFJOJM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly ECLOBOFEBGL CBKAJGPFJPH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly AHIKEIDCNDI JKDDBCJJEEA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly ECLOBOFEBGL FPNIAHEEGKG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly AKNEJOKCHKJ LLBLDFFACOD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly KLGOFGIBFIA PCKMBPNMICK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly AHIKEIDCNDI FELDPHENPDO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OIEJENPKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75B8840", Offset = "0x75B7440", VA = "0x1875B8840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC02D10", Offset = "0xC01910", VA = "0x180C02D10")]
	public KLGOFGIBFIA(AHIKEIDCNDI KMNGNJAEOEN, ECLOBOFEBGL IDJHFBHBAMM, AHIKEIDCNDI EEIGJAIDDAM, ECLOBOFEBGL APPGMCAPIHC, AHIKEIDCNDI PLECHIHKIBP, ECLOBOFEBGL FKNIABOCMJH, AKNEJOKCHKJ HPDBNKECKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	private static bool PEJBLFDNLGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void GBOLEIOJIND(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	private static bool DAGFKHKLPKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void GJHIHIBAEJI(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	private static bool IHHGEKJPEMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void OJMGLIIFKJE(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void PEOKNGCDACG(Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75B85B0", Offset = "0x75B71B0", VA = "0x1875B85B0")]
	private static KLGOFGIBFIA NCCAOOOBBKA()
	{
		return default(KLGOFGIBFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
	private static bool LIONBMPCCPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x75B8540", Offset = "0x75B7140", VA = "0x1875B8540")]
	public void HBFNBGCENOB(object KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x75B84D0", Offset = "0x75B70D0", VA = "0x1875B84D0")]
	public void GMJMONGINMO(object KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x75B87D0", Offset = "0x75B73D0", VA = "0x1875B87D0")]
	public void OCMEEKEHCCG(object KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC019E0", VA = "0x180C02DE0")]
	public void HNJGHAFKLPA(Exception COMMOGJDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x75B86F0", Offset = "0x75B72F0", VA = "0x1875B86F0")]
	public void OCMEEKEHCCG(NCHAEFPECOC KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x343BDA0", Offset = "0x343A9A0", VA = "0x18343BDA0")]
	public void OCMEEKEHCCG<T>(T GJPLANLJOMM, MNKPOLALJJC<T> KBPDEFFIKOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x343BA60", Offset = "0x343A660", VA = "0x18343BA60")]
	public void HBFNBGCENOB<T>([In] T GJPLANLJOMM, CGOINDFHJAE<T> KBPDEFFIKOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x343BC00", Offset = "0x343A800", VA = "0x18343BC00")]
	public void OCMEEKEHCCG<T>([In] T GJPLANLJOMM, CGOINDFHJAE<T> KBPDEFFIKOJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x75B8400", Offset = "0x75B7000", VA = "0x1875B8400")]
	public bool FGDELHDCCGD(bool IKHACMHNJDM, string KBPDEFFIKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ALLOIHPLAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string GNLOKINMAMH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	public ALLOIHPLAKC(string MPDLOLIOGJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
	public static string NIBCGLOMJGK([In] ALLOIHPLAKC DKGDAEBOJKO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBCD0", Offset = "0x1FCA8D0", VA = "0x181FCBCD0")]
	public static ALLOIHPLAKC NIBCGLOMJGK(string PELBNOCGOOJ)
	{
		return default(ALLOIHPLAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x75AFDD0", Offset = "0x75AE9D0", VA = "0x1875AFDD0")]
	public string CDKEEEEGOJC(string HMADJLMCFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x75AFE20", Offset = "0x75AEA20", VA = "0x1875AFE20")]
	public string LDJDBJMFEMC(object IHAGILMLEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class FGBJJOHEICE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public FGBJJOHEICE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct BODKGJBCKHC : IEquatable<BODKGJBCKHC>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "4")]
	public bool Equals(BODKGJBCKHC PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x75B0C20", Offset = "0x75AF820", VA = "0x1875B0C20", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75B0C70", Offset = "0x75AF870", VA = "0x1875B0C70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x75B0C80", Offset = "0x75AF880", VA = "0x1875B0C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[LDOMFOOMHLM("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct AKMEDOPOELG<T> : IEquatable<AKMEDOPOELG<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T GNLOKINMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool JOAGFAIKAMJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NBFFOLPGDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4675210", Offset = "0x4673E10", VA = "0x184675210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4675A90", Offset = "0x4674690", VA = "0x184675A90")]
	public AKMEDOPOELG([In] T MPDLOLIOGJL, bool PJFEKAOLPBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4674B90", Offset = "0x4673790", VA = "0x184674B90")]
	public static bool LBLECGDECIN([In] AKMEDOPOELG<T> NFOAKNOEKCL, [In] AKMEDOPOELG<T> AFFPJGJMKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46737E0", Offset = "0x46723E0", VA = "0x1846737E0", Slot = "4")]
	public bool Equals(AKMEDOPOELG<T> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4673870", Offset = "0x4672470", VA = "0x184673870", Slot = "0")]
	public override bool Equals(object? PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46748B0", Offset = "0x46734B0", VA = "0x1846748B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4675580", Offset = "0x4674180", VA = "0x184675580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ODPILNMKPPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3548FE0", Offset = "0x3547BE0", VA = "0x183548FE0")]
	public static AKMEDOPOELG<T> AODEBKFKEKL<T>([In] T MPDLOLIOGJL) where T : notnull
	{
		return default(AKMEDOPOELG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35491F0", Offset = "0x3547DF0", VA = "0x1835491F0")]
	public static AKMEDOPOELG<T?> EKOCPMGGFFP<T>()
	{
		return default(AKMEDOPOELG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3549370", Offset = "0x3547F70", VA = "0x183549370")]
	public static bool FEIKPHLHNGD<T>([In] this AKMEDOPOELG<T> ACKOGFHHGCN, [Out][NotNullWhen(true)] T MPDLOLIOGJL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3549300", Offset = "0x3547F00", VA = "0x183549300")]
	public static bool FEIKPHLHNGD<T>([In] this AKMEDOPOELG<T> ACKOGFHHGCN, [Out][NotNullWhen(true)] T MPDLOLIOGJL, [Out] AKMEDOPOELG<T> LKMMGOJKEDM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x35493A0", Offset = "0x3547FA0", VA = "0x1835493A0")]
	public static T? NPNKMKKKLEI<T>([In] this AKMEDOPOELG<T> ACKOGFHHGCN, T? NBKBMLNEBHK)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3549400", Offset = "0x3548000", VA = "0x183549400")]
	public static bool PKNGKHMIBGE<T>([In] this AKMEDOPOELG<T> ACKOGFHHGCN, T MPDLOLIOGJL) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DJCOBOGIFGF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x31A64D0", Offset = "0x31A50D0", VA = "0x1831A64D0")]
	public static T MNHKGBBMFGB<T>([In] this AKMEDOPOELG<T> ACKOGFHHGCN) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct PEJDGHKGNNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr MHHBEIAFGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr EGHAEJLABBH;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr HHLOPGCADOD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr IPDHPHDOBLD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly PEJDGHKGNNJ PCKMBPNMICK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool OIEJENPKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75BB0B0", Offset = "0x75B9CB0", VA = "0x1875BB0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	public PEJDGHKGNNJ(IntPtr GIDHMPKKIOM, IntPtr HBHKGFMKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void MIIMNFMEBGB(string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void MABPHECNBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x75BB020", Offset = "0x75B9C20", VA = "0x1875BB020")]
	private static PEJDGHKGNNJ NCCAOOOBBKA()
	{
		return default(PEJDGHKGNNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct MMODLBMHKAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr NCHMAFOKCPP;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
	private MMODLBMHKAE(IntPtr HBHKGFMKAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x75B9A60", Offset = "0x75B8660", VA = "0x1875B9A60")]
	public void MPDBLNIHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x75B9980", Offset = "0x75B8580", VA = "0x1875B9980")]
	public static MMODLBMHKAE JPHABLICNHB(string BGKKCEGMOKH)
	{
		return default(MMODLBMHKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25381E0", Offset = "0x2536DE0", VA = "0x1825381E0")]
	public static MMODLBMHKAE JPHABLICNHB([In] PEJDGHKGNNJ ADEMNICIPAO, string BGKKCEGMOKH)
	{
		return default(MMODLBMHKAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2537BE0", Offset = "0x25367E0", VA = "0x182537BE0")]
	public static MMODLBMHKAE JPHABLICNHB([In] PEJDGHKGNNJ ADEMNICIPAO, Func<string> BGKKCEGMOKH)
	{
		return default(MMODLBMHKAE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DNLFKKBHBDD
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool OPBDFDLPFGL<in TInput, TResult>(TInput CPPOMEHPJCH, [Out] TResult HBANOBDOKBJ);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class BLJJHAEGEDF : LBDDOGOFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class AGLPHFBKEBK : MNIFCDPBAPB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly AGLPHFBKEBK FFLNCJPMHOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool MCDJDPMKNFM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x75AFBB0", Offset = "0x75AE7B0", VA = "0x1875AFBB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x75AFC10", Offset = "0x75AE810", VA = "0x1875AFC10", Slot = "6")]
			public void OnCompleted(Action AKAIBCLAGLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			public void HEFBJMINLAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AGLPHFBKEBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly BLJJHAEGEDF FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		private BLJJHAEGEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75B0B60", Offset = "0x75AF760", VA = "0x1875B0B60", Slot = "4")]
		public MNIFCDPBAPB MADAPDACNGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class BHFACDCBMJN : LBDDOGOFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class HMCOPMLNHAG : MNIFCDPBAPB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly HMCOPMLNHAG FFLNCJPMHOJ;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool MCDJDPMKNFM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x75B7780", Offset = "0x75B6380", VA = "0x1875B7780", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x75B77A0", Offset = "0x75B63A0", VA = "0x1875B77A0", Slot = "6")]
			public void OnCompleted(Action AKAIBCLAGLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			public void HEFBJMINLAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HMCOPMLNHAG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly BHFACDCBMJN FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		private BHFACDCBMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x75B01C0", Offset = "0x75AEDC0", VA = "0x1875B01C0", Slot = "4")]
		public MNIFCDPBAPB MADAPDACNGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class EHGAGHILHCO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public EHGAGHILHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB70", Offset = "0x3FCB770", VA = "0x183FCCB70")]
		internal void OLCDNNCECLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class NMJPIDCIKOA<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NMJPIDCIKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4E5EC70", Offset = "0x4E5D870", VA = "0x184E5EC70")]
		internal void IOCNLNOHKNM(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KPBDLDJNCGI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B9050", Offset = "0x75B7C50", VA = "0x1875B9050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OOMHLDMIIKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75BA6C0", Offset = "0x75B92C0", VA = "0x1875BA6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FDODADDDNEI<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x438FD50", Offset = "0x438E950", VA = "0x18438FD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x438FEC0", Offset = "0x438EAC0", VA = "0x18438FEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KOCIEPLKNOM<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4A83300", Offset = "0x4A81F00", VA = "0x184A83300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4A83750", Offset = "0x4A82350", VA = "0x184A83750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NJPBBLCILKH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B9C60", Offset = "0x75B8860", VA = "0x1875B9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x75B9E70", Offset = "0x75B8A70", VA = "0x1875B9E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IGFDFNMOCJN<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IGFDFNMOCJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB70", Offset = "0x3FCB770", VA = "0x183FCCB70")]
		internal void LHJEBMGCFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x46F3BA0", Offset = "0x46F27A0", VA = "0x1846F3BA0")]
		internal void FLEFOOJBIBI(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KBFPJHEHMJA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public OPBDFDLPFGL<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4A05D40", Offset = "0x4A04940", VA = "0x184A05D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4A064A0", Offset = "0x4A050A0", VA = "0x184A064A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct PADIHAKGGOO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75BA7D0", Offset = "0x75B93D0", VA = "0x1875BA7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x75BAFC0", Offset = "0x75B9BC0", VA = "0x1875BAFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct JLNHIPODNHP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B7DC0", Offset = "0x75B69C0", VA = "0x1875B7DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x75B8300", Offset = "0x75B6F00", VA = "0x1875B8300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IGHOGGKHPME<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x46F42B0", Offset = "0x46F2EB0", VA = "0x1846F42B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4542BD0", Offset = "0x45417D0", VA = "0x184542BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OMEKHIOJHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<BODKGJBCKHC> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OMEKHIOJHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x75BA5B0", Offset = "0x75B91B0", VA = "0x1875BA5B0")]
		internal void KCIJAMCLENL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct AGBBMEJKELP<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x46646E0", Offset = "0x46632E0", VA = "0x1846646E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB6BF0", Offset = "0x3CB57F0", VA = "0x183CB6BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CGDKGLHCEBO<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5AAD140", Offset = "0x5AABD40", VA = "0x185AAD140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5AAE0A0", Offset = "0x5AACCA0", VA = "0x185AAE0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IHFHDFPMGDM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B7B80", Offset = "0x75B6780", VA = "0x1875B7B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x75B7D60", Offset = "0x75B6960", VA = "0x1875B7D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct AGGEBCCAFEN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75AF7F0", Offset = "0x75AE3F0", VA = "0x1875AF7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x75AFB50", Offset = "0x75AE750", VA = "0x1875AFB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct POAOHMGEEGM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75BB610", Offset = "0x75BA210", VA = "0x1875BB610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x75BB900", Offset = "0x75BA500", VA = "0x1875BB900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KGAFNMIDEAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KGAFNMIDEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x75B8360", Offset = "0x75B6F60", VA = "0x1875B8360")]
		internal Task IHBNMAJHJAP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NMMMKECAMCM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B9EE0", Offset = "0x75B8AE0", VA = "0x1875B9EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x75BA140", Offset = "0x75B8D40", VA = "0x1875BA140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct CEBDGNAKCED : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B19B0", Offset = "0x75B05B0", VA = "0x1875B19B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x75B1B90", Offset = "0x75B0790", VA = "0x1875B1B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct CDCMJJFCBCL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B0CB0", Offset = "0x75AF8B0", VA = "0x1875B0CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x75B1010", Offset = "0x75AFC10", VA = "0x1875B1010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct PGMCGBDPFKD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75BB2C0", Offset = "0x75B9EC0", VA = "0x1875BB2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75BB5B0", Offset = "0x75BA1B0", VA = "0x1875BB5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GAMBLBDGNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GAMBLBDGNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x75B5EA0", Offset = "0x75B4AA0", VA = "0x1875B5EA0")]
		internal Task HOAGEFFMNME(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct BBCGBOKAELJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75AFF00", Offset = "0x75AEB00", VA = "0x1875AFF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x75B0160", Offset = "0x75AED60", VA = "0x1875B0160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct MNPNHCHLKHE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B9A80", Offset = "0x75B8680", VA = "0x1875B9A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75B9C00", Offset = "0x75B8800", VA = "0x1875B9C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct MDKPCBOLKEG<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4D3D7D0", Offset = "0x4D3C3D0", VA = "0x184D3D7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4D3DA50", Offset = "0x4D3C650", VA = "0x184D3DA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct OFBCOJBGLJD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75BA220", Offset = "0x75B8E20", VA = "0x1875BA220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x75BA550", Offset = "0x75B9150", VA = "0x1875BA550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? OKAJABABHBG;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<BODKGJBCKHC> OIADFDOAIIE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task NHIBGOECEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x75B2DC0", Offset = "0x75B19C0", VA = "0x1875B2DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x75B4150", Offset = "0x75B2D50", VA = "0x1875B4150")]
	public static bool OBLGLGNCDEC(this Task LFJIOJDNNEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x31AF430", Offset = "0x31AE030", VA = "0x1831AF430")]
	public static Task<T> OMMNBAKHNLP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x75B37A0", Offset = "0x75B23A0", VA = "0x1875B37A0")]
	public static Task KPNAODKPAIA(this Task LFJIOJDNNEN, CancellationToken IKLHDHMJFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x31AD800", Offset = "0x31AC400", VA = "0x1831AD800")]
	public static Task<TResult> KPNAODKPAIA<TResult>(this Task<TResult> LFJIOJDNNEN, CancellationToken IKLHDHMJFFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x31AEAA0", Offset = "0x31AD6A0", VA = "0x1831AEAA0")]
	public static TaskCompletionSource<TResult> KPNAODKPAIA<TResult>(this TaskCompletionSource<TResult> IDGIFCDJBBC, CancellationToken IKLHDHMJFFL) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75B2790", Offset = "0x75B1390", VA = "0x1875B2790")]
	public static IDisposable? ADAEKLEMOJO(CancellationToken BJIPAJMEDAJ, CancellationToken OJHHGNBDDJJ, [Out] CancellationToken CFPIEJAADNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x75B2C20", Offset = "0x75B1820", VA = "0x1875B2C20")]
	[AsyncStateMachine(typeof(KPBDLDJNCGI))]
	public static void CLCBODCPPGJ(this Task LDIBCOFKEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x75B36F0", Offset = "0x75B22F0", VA = "0x1875B36F0")]
	[AsyncStateMachine(typeof(OOMHLDMIIKP))]
	public static void JOODNLOLFJI(this Task LDIBCOFKEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x31AA820", Offset = "0x31A9420", VA = "0x1831AA820")]
	[AsyncStateMachine(typeof(FDODADDDNEI<>))]
	public static Task DLIAOEMKENB<TException>(this Task LDIBCOFKEDC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x31AAAD0", Offset = "0x31A96D0", VA = "0x1831AAAD0")]
	[AsyncStateMachine(typeof(KOCIEPLKNOM<>))]
	public static Task<T> GNKMEIIOJLA<T>(this Task<T> DKGDAEBOJKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x75B3600", Offset = "0x75B2200", VA = "0x1875B3600")]
	[AsyncStateMachine(typeof(NJPBBLCILKH))]
	public static Task<TaskStatus> JJPHOHBPNBD(this Task? DKGDAEBOJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x31AACB0", Offset = "0x31A98B0", VA = "0x1831AACB0")]
	public static (Task<T?>?, Action<T?>?) IHCACOGMAOM<T>([Optional] CancellationToken NAOIMKEDKEJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x31AF890", Offset = "0x31AE490", VA = "0x1831AF890")]
	[AsyncStateMachine(typeof(KBFPJHEHMJA<, >))]
	public static Task<List<TResult>> PODOCFBKEFK<TResult, TInput>(this Task<List<TInput>> LFJIOJDNNEN, OPBDFDLPFGL<TInput, TResult> CBNLPFMCNEL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x75B2660", Offset = "0x75B1260", VA = "0x1875B2660")]
	[AsyncStateMachine(typeof(PADIHAKGGOO))]
	public static Task AAEIKMFPEFH(Task LDIBCOFKEDC, CancellationToken MJJLMJBFHKM, Func<CancellationToken, Task> IOIBMCMGMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75B2AF0", Offset = "0x75B16F0", VA = "0x1875B2AF0")]
	[AsyncStateMachine(typeof(JLNHIPODNHP))]
	public static Task CEJDPHFOGEO(Func<CancellationToken, Task> FACDALAFIFJ, TimeSpan IOGIGKLDIAN, [Optional] CancellationToken MJJLMJBFHKM, [Optional] Action<OperationCanceledException>? EMEGLGPNFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31AA490", Offset = "0x31A9090", VA = "0x1831AA490")]
	[AsyncStateMachine(typeof(IGHOGGKHPME<>))]
	public static Task<T> CEJDPHFOGEO<T>(Func<CancellationToken, Task<T>> FACDALAFIFJ, TimeSpan IOGIGKLDIAN, [Optional] CancellationToken MJJLMJBFHKM, [Optional] Func<OperationCanceledException, T>? EMEGLGPNFHB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75B3F00", Offset = "0x75B2B00", VA = "0x1875B3F00")]
	public static Task MKLEONHJCCJ(params Task[] DNPCIAHNPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75B3A40", Offset = "0x75B2640", VA = "0x1875B3A40")]
	public static Task MKLEONHJCCJ(IEnumerable<Task> DNPCIAHNPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31AA9E0", Offset = "0x31A95E0", VA = "0x1831AA9E0")]
	[AsyncStateMachine(typeof(AGBBMEJKELP<>))]
	public static Task<IEnumerable<Task<T>>> FNEFHFMMJGN<T>(IEnumerable<Task<T>> DNPCIAHNPCP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31AF5B0", Offset = "0x31AE1B0", VA = "0x1831AF5B0")]
	[AsyncStateMachine(typeof(CGDKGLHCEBO<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> PDPHGMNJJOP<T1, T2, T3, T4, T5>(Task<T1> ACMHLEAHLFP, Task<T2> ALMFOCMHKJJ, Task<T3> JCOOJCOJOAE, Task<T4> CIBCPCKKIAD, Task<T5> PAAHFFJCHDH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x75B3260", Offset = "0x75B1E60", VA = "0x1875B3260")]
	[AsyncStateMachine(typeof(IHFHDFPMGDM))]
	public static Task HNOJNKNNOMP(Func<bool> IKHACMHNJDM, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75B3350", Offset = "0x75B1F50", VA = "0x1875B3350")]
	[AsyncStateMachine(typeof(AGGEBCCAFEN))]
	public static Task HNOJNKNNOMP(Func<bool> IKHACMHNJDM, TimeSpan DFKDGOMAIHJ, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x75B46A0", Offset = "0x75B32A0", VA = "0x1875B46A0")]
	[AsyncStateMachine(typeof(POAOHMGEEGM))]
	public static Task PEPDGAOAMFL(Func<bool> IKHACMHNJDM, TimeSpan IOGIGKLDIAN, [Optional] CancellationToken NAOIMKEDKEJ, [Optional] Action<OperationCanceledException>? EMEGLGPNFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75B4560", Offset = "0x75B3160", VA = "0x1875B4560")]
	[AsyncStateMachine(typeof(NMMMKECAMCM))]
	public static Task PEPDGAOAMFL(Func<bool> IKHACMHNJDM, TimeSpan IOGIGKLDIAN, TimeSpan DFKDGOMAIHJ, [Optional] CancellationToken NAOIMKEDKEJ, [Optional] Action<OperationCanceledException>? EMEGLGPNFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75B4060", Offset = "0x75B2C60", VA = "0x1875B4060")]
	[AsyncStateMachine(typeof(CEBDGNAKCED))]
	public static Task NMKJLABOHCA(Func<bool> IKHACMHNJDM, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x75B3F50", Offset = "0x75B2B50", VA = "0x1875B3F50")]
	[AsyncStateMachine(typeof(CDCMJJFCBCL))]
	public static Task NMKJLABOHCA(Func<bool> IKHACMHNJDM, TimeSpan DFKDGOMAIHJ, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75B3020", Offset = "0x75B1C20", VA = "0x1875B3020")]
	[AsyncStateMachine(typeof(PGMCGBDPFKD))]
	public static Task GDDEMOJFKCM(Func<bool> IKHACMHNJDM, TimeSpan IOGIGKLDIAN, [Optional] CancellationToken NAOIMKEDKEJ, [Optional] Action<OperationCanceledException>? EMEGLGPNFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x75B2EE0", Offset = "0x75B1AE0", VA = "0x1875B2EE0")]
	[AsyncStateMachine(typeof(BBCGBOKAELJ))]
	public static Task GDDEMOJFKCM(Func<bool> IKHACMHNJDM, TimeSpan IOGIGKLDIAN, TimeSpan DFKDGOMAIHJ, [Optional] CancellationToken NAOIMKEDKEJ, [Optional] Action<OperationCanceledException>? EMEGLGPNFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75B2CD0", Offset = "0x75B18D0", VA = "0x1875B2CD0")]
	[AsyncStateMachine(typeof(MNPNHCHLKHE))]
	[Obsolete]
	public static Task DHGNMPCOIJJ(this Task LFJIOJDNNEN, Action POFPFDAFDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x31AA730", Offset = "0x31A9330", VA = "0x1831AA730")]
	[Obsolete]
	[AsyncStateMachine(typeof(MDKPCBOLKEG<>))]
	public static Task DHGNMPCOIJJ<T>(this Task<T> LFJIOJDNNEN, Action<T> POFPFDAFDBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75B2E30", Offset = "0x75B1A30", VA = "0x1875B2E30")]
	private static void GBLDHJLLDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x75B4180", Offset = "0x75B2D80", VA = "0x1875B4180")]
	public static bool OLCKEBBMFOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75B2920", Offset = "0x75B1520", VA = "0x1875B2920")]
	private static void BHCGKKCAMEA(SynchronizationContext MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75B3150", Offset = "0x75B1D50", VA = "0x1875B3150")]
	private static void HLGEDHJILNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75B3460", Offset = "0x75B2060", VA = "0x1875B3460")]
	public static void HPENAIHAJPA([Optional] string? KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75B44E0", Offset = "0x75B30E0", VA = "0x1875B44E0")]
	public static void ONAJFPBILOJ([Optional] string? KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75B2AA0", Offset = "0x75B16A0", VA = "0x1875B2AA0")]
	public static LBDDOGOFLPN BNGOMANJICB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75B39F0", Offset = "0x75B25F0", VA = "0x1875B39F0")]
	public static LBDDOGOFLPN MDACMHJKDBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75B3530", Offset = "0x75B2130", VA = "0x1875B3530")]
	[AsyncStateMachine(typeof(OFBCOJBGLJD))]
	public static Task IKBMFLGLKGF(Func<Task> ONHFNCNDFHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HJLLPMMDIEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public HJLLPMMDIEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EOLDOJHAPON : AFOKPECFOGN
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly AFOKPECFOGN FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime MJKEOLLOFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75B5C20", Offset = "0x75B4820", VA = "0x1875B5C20", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset FHHDDCMHNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75B5C60", Offset = "0x75B4860", VA = "0x1875B5C60", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public EOLDOJHAPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AFOKPECFOGN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime MJKEOLLOFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset FHHDDCMHNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EJDJKMFKJHK
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long IFOKPKHDMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x75B5370", Offset = "0x75B3F70", VA = "0x1875B5370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long FADKEOIKOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x75B53C0", Offset = "0x75B3FC0", VA = "0x1875B53C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double JBBFDJNFKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x75B5320", Offset = "0x75B3F20", VA = "0x1875B5320")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double JNNNMMOCODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75B5460", Offset = "0x75B4060", VA = "0x1875B5460")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double GIENAPMIBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75B5830", Offset = "0x75B4430", VA = "0x1875B5830")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double ELAGNHBMLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x75B5410", Offset = "0x75B4010", VA = "0x1875B5410")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x75B54B0", Offset = "0x75B40B0", VA = "0x1875B54B0")]
	public static double JHEJJPOJFKG(long GKBEDAFNPOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x75B55D0", Offset = "0x75B41D0", VA = "0x1875B55D0")]
	public static double JMDNPFGNFDI(long GKBEDAFNPOA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x75B5540", Offset = "0x75B4140", VA = "0x1875B5540")]
	public static double JHIIPPCBPFB(double JGDFBMAFHCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x75B56C0", Offset = "0x75B42C0", VA = "0x1875B56C0")]
	public static long NGBNMMJFOBL(long NOCMKPDPIPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x75B5750", Offset = "0x75B4350", VA = "0x1875B5750")]
	public static long OBJHLFKMFJO(long KHFHJADHNEI, long EHCGIHGJFAE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x75B5760", Offset = "0x75B4360", VA = "0x1875B5760")]
	public static double PHNFEDAHLPF(long KHFHJADHNEI, long EHCGIHGJFAE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x75B5660", Offset = "0x75B4260", VA = "0x1875B5660")]
	public static double KDLICCLLJEJ(long KHFHJADHNEI, long EHCGIHGJFAE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class BHFNFOBHOAC : PGEMJLKCHBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan JIEPLBGHGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer IFHLDBMAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan IOGIGKLDIAN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan OGKHCFHKKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x75B02F0", Offset = "0x75AEEF0", VA = "0x1875B02F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? LMJDPBECNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x75B06B0", Offset = "0x75AF2B0", VA = "0x1875B06B0")]
	[Preserve]
	public BHFNFOBHOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x75B0710", Offset = "0x75AF310", VA = "0x1875B0710")]
	public BHFNFOBHOAC(TimeSpan IOGIGKLDIAN, [Optional] Action? PNAPPBNNFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x75B05B0", Offset = "0x75AF1B0", VA = "0x1875B05B0", Slot = "7")]
	public void MEKDGOPFPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x75B0280", Offset = "0x75AEE80", VA = "0x1875B0280", Slot = "8")]
	public void BGNMNFLGLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x75B0580", Offset = "0x75AF180", VA = "0x1875B0580", Slot = "9")]
	public void FLFLNOAJBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xF44100", Offset = "0xF42D00", VA = "0x180F44100")]
	private void AAELBEMAGGE(object LOJMCGAMMAK, ElapsedEventArgs GNJKHBPMBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x75B04F0", Offset = "0x75AF0F0", VA = "0x1875B04F0")]
	private static void EDPMIJMMJOL(TimeSpan APNEOKKEIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x75B0450", Offset = "0x75AF050", VA = "0x1875B0450", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class LDOMFOOMHLM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? EFKFONJEFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string HFGNBPBKNKM;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2480", Offset = "0x6FC1080", VA = "0x186FC2480")]
	public LDOMFOOMHLM(string ICDFHDIHFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4388E80", Offset = "0x4387A80", VA = "0x184388E80")]
	public LDOMFOOMHLM(string PPIKKIDENAN, string ICDFHDIHFJG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct GJKMACPKIMD : IEquatable<GJKMACPKIMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint GPHFJJMHIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int CGECBNNOHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float NKPKGJLGOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort EFKLICGEFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort GNGHHNKGDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short JNHBMNKEEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short IFECNGPNLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char JBNKCMBIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char IHNFFFDGLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte JPPKDEAEAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte CCADOPNEPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte ODJGFHKKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte OOJJCKBELBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool HECLPLMFDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool OFGNAOBNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool JAHBDACCJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool EEAKHAOENFB;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1BE03E0", Offset = "0x1BDEFE0", VA = "0x181BE03E0")]
	public static GJKMACPKIMD HACDCFHENAP(uint OMLFPDDHGIJ)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1BE03E0", Offset = "0x1BDEFE0", VA = "0x181BE03E0")]
	public static GJKMACPKIMD CBHJPOFKOGP(int FIPLCPBKKGG)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x75B6910", Offset = "0x75B5510", VA = "0x1875B6910")]
	public static GJKMACPKIMD FBIPNLCHIKI(float HKLCIHMGJFM)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x75B6860", Offset = "0x75B5460", VA = "0x1875B6860")]
	public static GJKMACPKIMD OIMCGCAKBCN(byte LKFKLEAGALD, byte DENNDFGCDEO, byte JPEJPONPJKC, byte IEKLIEKFIBI)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x75B6860", Offset = "0x75B5460", VA = "0x1875B6860")]
	public static GJKMACPKIMD BLHOGNGAFCC(bool EKAHPCJJEBA, bool IHJGHLFHHME, bool NOJGMLMPMBG, bool IKIDBEBMEOD)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x75B6860", Offset = "0x75B5460", VA = "0x1875B6860")]
	public static GJKMACPKIMD EFHFFLJGOII(byte LOFHBFBJECC, byte IMPGMEADNLA, byte MLJNJLJHFBF, byte GGKMIGIMPDB)
	{
		return default(GJKMACPKIMD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB360", Offset = "0x1EC9F60", VA = "0x181ECB360")]
	public static bool LBLECGDECIN(GJKMACPKIMD IFMENDFGFGN, GJKMACPKIMD DPEOCFNLADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB340", Offset = "0x1EC9F40", VA = "0x181ECB340", Slot = "4")]
	public bool Equals(GJKMACPKIMD PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x75B6880", Offset = "0x75B5480", VA = "0x1875B6880", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x10D73D0", Offset = "0x10D5FD0", VA = "0x1810D73D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x75B6920", Offset = "0x75B5520", VA = "0x1875B6920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct EIAOOLEPNLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong GOMKICMNGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long BKHCIEEKBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double IPGDAJKBIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint BNLGLHHKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint KDDHOGOHPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int AAFHGDOHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int FMLCGNFMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float LBEGGGOMDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float GDHPKGNNAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort EFKLICGEFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort GNGHHNKGDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort GLLFEOPJIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort HLJGGABJEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short JNHBMNKEEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short IFECNGPNLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short NKLNLGDOAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short FGAMGEGKNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char JBNKCMBIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char IHNFFFDGLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char PPBKDJKKIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char NDJBCFEKJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte JPPKDEAEAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte CCADOPNEPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte ODJGFHKKKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte OOJJCKBELBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte AAJNGJMHDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte OLEEJJGMGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte LGCNEDAMGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte IOELPPEJOEM;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static EIAOOLEPNLB JPHABLICNHB(long BNIAGCHGEMA)
	{
		return default(EIAOOLEPNLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x75B52D0", Offset = "0x75B3ED0", VA = "0x1875B52D0")]
	public static EIAOOLEPNLB JPHABLICNHB(byte LKFKLEAGALD, byte DENNDFGCDEO, byte JPEJPONPJKC, byte IEKLIEKFIBI, byte FBLNNJFJLMD, byte BCKKOPDAOPC, byte KNMLHGAANOG, byte ALKFFIJILMP)
	{
		return default(EIAOOLEPNLB);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct IGOCBHGDMFA : IEquatable<IGOCBHGDMFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte CKAHCBDIALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool BABIGOGIFFL;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2B81B50", Offset = "0x2B80750", VA = "0x182B81B50")]
	public static IGOCBHGDMFA OIMCGCAKBCN(byte CGAHDANAMPG)
	{
		return default(IGOCBHGDMFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2B81B50", Offset = "0x2B80750", VA = "0x182B81B50")]
	public static IGOCBHGDMFA BLHOGNGAFCC(bool GHNOFMLAHPB)
	{
		return default(IGOCBHGDMFA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x75B7900", Offset = "0x75B6500", VA = "0x1875B7900")]
	public static bool LBLECGDECIN(IGOCBHGDMFA IFMENDFGFGN, IGOCBHGDMFA DPEOCFNLADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x666E9D0", Offset = "0x666D5D0", VA = "0x18666E9D0", Slot = "4")]
	public bool Equals(IGOCBHGDMFA PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x75B7860", Offset = "0x75B6460", VA = "0x1875B7860", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x75B78F0", Offset = "0x75B64F0", VA = "0x1875B78F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x75B7910", Offset = "0x75B6510", VA = "0x1875B7910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class EPAJDEKJELO<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T JJMDHCOLEBG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x400A950", Offset = "0x4009550", VA = "0x18400A950")]
	public EPAJDEKJELO(T HGGBDNIOONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class IEJLMLJFDNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x33B1B70", Offset = "0x33B0770", VA = "0x1833B1B70")]
	public static IEnumerable<T> JFICMFEOOFG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static T[] FPPMHDBJAEJ<T>(params T[] FHEGLHAEDIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static IEnumerable<T> GKEDFNJLBAN<T>(params T[] FHEGLHAEDIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static HashSet<T> BIEFKFIOIHO<T>(params T[] FHEGLHAEDIF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x33B1A80", Offset = "0x33B0680", VA = "0x1833B1A80")]
	public static KeyValuePair<TKey, TValue> DAKIMGHDHFO<TKey, TValue>([In] TKey NKANGPLHEGE, [In] TValue MPDLOLIOGJL) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x30E8390", Offset = "0x30E6F90", VA = "0x1830E8390")]
	public static List<T> LCHGMAAEKAF<T>(IEnumerable<T> BIGGBEIOJHJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OMFHMOMEMHL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string IBFOMDJJHAF;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
	public OMFHMOMEMHL(string LDFAIJKGKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object CGOINDFHJAE<T>([In] T IGPONJDPFGI);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object MNKPOLALJJC<T>(T IGPONJDPFGI);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[FNKEIOFGMPP]
public delegate string EKAHLNHHPBI(string FDHHCKGHMND, string? NIIENGDOBFN, bool EHKJIOAOCFP);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[FNKEIOFGMPP]
public delegate void ECLOBOFEBGL(string KBPDEFFIKOJ);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[FNKEIOFGMPP]
public delegate void AKNEJOKCHKJ(Exception COMMOGJDAGN);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object NCHAEFPECOC();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FNKEIOFGMPP]
public delegate bool AHIKEIDCNDI();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[FNKEIOFGMPP]
public delegate string NHBJIJGANDA(object CFMCKCBBBKK);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class GEMJOBGBEKH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
	public GEMJOBGBEKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class LNCLFHJAMAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct GBCAGOKGHPL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x75B5F10", Offset = "0x75B4B10", VA = "0x1875B5F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x75B67F0", Offset = "0x75B53F0", VA = "0x1875B67F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback GLJAEHIAOCN;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> FKGCFGJPPIJ;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x75B94F0", Offset = "0x75B80F0", VA = "0x1875B94F0")]
	public static Task<bool> JNGLOKDDPGA(int DBCFLAHAONE, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x75B9330", Offset = "0x75B7F30", VA = "0x1875B9330")]
	[AsyncStateMachine(typeof(GBCAGOKGHPL))]
	private static Task<bool> HBIDFPABADB(int DBCFLAHAONE, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x75B97F0", Offset = "0x75B83F0", VA = "0x1875B97F0")]
	private static void PBPOFNDFBBC(object? CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x75B9460", Offset = "0x75B8060", VA = "0x1875B9460")]
	private static void HOLOHMFBOCO(object? CMPEMMPBPLC)
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
