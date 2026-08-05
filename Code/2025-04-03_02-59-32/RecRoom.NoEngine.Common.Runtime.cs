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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x799E3D0", Offset = "0x799D7D0", VA = "0x18799E3D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BNKGPLEJEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7995420", Offset = "0x7994820", VA = "0x187995420")]
	public static string DKIEJMKIMKH(this Encoding CBAOGPOALEA, [In] ReadOnlySequence<byte> DHHEGLJJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3387530", Offset = "0x3386930", VA = "0x183387530")]
	private static void IOJKCEBLBIK<T>(this ReadOnlySequence<T> LGAMEGCBKGI, [Out] ReadOnlySpan<T> NGDAJNLEOJF, [Out] SequencePosition POEMJFLDIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class DDHGLPDDADJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7999040", Offset = "0x7998440", VA = "0x187999040")]
	public DDHGLPDDADJ(bool HALGMBGJENC, string IFENPNGHNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7999110", Offset = "0x7998510", VA = "0x187999110")]
	public DDHGLPDDADJ(bool HALGMBGJENC, params string[] GCDJPGKOOML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JMJPHEGCBKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EJEOKNJEOAO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OHEJGFMKIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLCDPCJAIJF(string DJBLFBEBKGO, double FFOEEMKIKJO, [Optional] string? LMBADNNCEKA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PKKHFAKCKEL : MAMPBLODOKN, IBGLLIKHBND, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int GPOPECEGOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> BOJHECKLHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double GCDIMBKCOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double IPOFNNMKDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double MENAKEFILCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int CAENLHAOHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double NAOCOKDGJCL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KMHDGIMKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B27B0", Offset = "0x9B1BB0", VA = "0x1809B27B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double AICDMCCHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x799F660", Offset = "0x799EA60", VA = "0x18799F660", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KMPDGIHKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52D5020", Offset = "0x52D4420", VA = "0x1852D5020", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double CNEGDKBOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2616FA0", Offset = "0x26163A0", VA = "0x182616FA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x799F860", Offset = "0x799EC60", VA = "0x18799F860")]
	public PKKHFAKCKEL(int CHGNALBKAJL, double NAOCOKDGJCL = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x799F730", Offset = "0x799EB30", VA = "0x18799F730", Slot = "7")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x799F6C0", Offset = "0x799EAC0", VA = "0x18799F6C0", Slot = "8")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x799F560", Offset = "0x799E960", VA = "0x18799F560", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FCNPHHEMGNC : MAMPBLODOKN, IBGLLIKHBND, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long ECKHNAPCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double MPDHJCIEMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double ILIEDNAHKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double JLBHJNHGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double PKOLEBDDBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double GCDIMBKCOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double IPOFNNMKDAE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KMPDGIHKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CA01A0", Offset = "0x6C9F5A0", VA = "0x186CA01A0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CNEGDKBOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6CA01C0", Offset = "0x6C9F5C0", VA = "0x186CA01C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double BBCFKGPHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CA01F0", Offset = "0x6C9F5F0", VA = "0x186CA01F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AICDMCCHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2CC10F0", Offset = "0x2CC04F0", VA = "0x182CC10F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x799AAF0", Offset = "0x7999EF0", VA = "0x18799AAF0", Slot = "10")]
	public virtual void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x799AAB0", Offset = "0x7999EB0", VA = "0x18799AAB0", Slot = "11")]
	public virtual void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x799AA40", Offset = "0x7999E40", VA = "0x18799AA40", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x799AC10", Offset = "0x799A010", VA = "0x18799AC10")]
	public FCNPHHEMGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JJBFLLBFGNG : FCNPHHEMGNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double KPBLECPCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FD50", Offset = "0x6C9F150", VA = "0x186C9FD50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0200", Offset = "0x6C9F600", VA = "0x186CA0200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x799C410", Offset = "0x799B810", VA = "0x18799C410", Slot = "10")]
	public override void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x799C3D0", Offset = "0x799B7D0", VA = "0x18799C3D0", Slot = "11")]
	public override void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x799AC10", Offset = "0x799A010", VA = "0x18799AC10")]
	public JJBFLLBFGNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MAMPBLODOKN : IBGLLIKHBND, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double AICDMCCHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double KMPDGIHKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double CNEGDKBOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HLFHPHENEFM : IBGLLIKHBND, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double GJPLBAGDNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double CGCCPFMCHIM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x799BEB0", Offset = "0x799B2B0", VA = "0x18799BEB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x78FACA0", Offset = "0x78FA0A0", VA = "0x1878FACA0", Slot = "4")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x799BEC0", Offset = "0x799B2C0", VA = "0x18799BEC0", Slot = "5")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x799BE60", Offset = "0x799B260", VA = "0x18799BE60", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public HLFHPHENEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBGLLIKHBND : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCPGPNHKDDF(double PCJCDFNKKKE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCJCJGLHJHO();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OLKPCKFFEBG : IBGLLIKHBND, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double FFOEEMKIKJO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x434EF90", Offset = "0x434E390", VA = "0x18434EF90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x50A6120", Offset = "0x50A5520", VA = "0x1850A6120", Slot = "4")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x799E7F0", Offset = "0x799DBF0", VA = "0x18799E7F0", Slot = "5")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x799E7A0", Offset = "0x799DBA0", VA = "0x18799E7A0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public OLKPCKFFEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KIFJPLNLCKP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> CIOHNCGLFOC(CancellationToken LMNHDKIFBOH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NIIJBBDAOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KIFJPLNLCKP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CIOHNCGLFOC taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x50D3080", Offset = "0x50D2480", VA = "0x1850D3080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50D4140", Offset = "0x50D3540", VA = "0x1850D4140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource MCOIFPENEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? DIFJIEAFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? GDMCGKDMJLN;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D72F50", Offset = "0x4D72350", VA = "0x184D72F50")]
	[AsyncStateMachine(typeof(KIFJPLNLCKP<>.NIIJBBDAOED))]
	public Task<TResult> NODIGKIAMID(CIOHNCGLFOC AFDLLEKBIKO, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D72EE0", Offset = "0x4D722E0", VA = "0x184D72EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D73090", Offset = "0x4D72490", VA = "0x184D73090")]
	public KIFJPLNLCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GLIKECAMIPF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> ELBJNCNIGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T HDKOPKMNJCH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x42DBE10", Offset = "0x42DB210", VA = "0x1842DBE10")]
	public GLIKECAMIPF([In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4850D70", Offset = "0x4850170", VA = "0x184850D70", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4851000", Offset = "0x4850400", VA = "0x184851000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x48512A0", Offset = "0x48506A0", VA = "0x1848512A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OIOHCLGNHMG
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static GLIKECAMIPF<T> HBLBJMFGHFK<T>([In] T FFOEEMKIKJO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JLDEHKFFIIH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x799C540", Offset = "0x799B940", VA = "0x18799C540")]
	public static void ODJLNCJMKPN(this CancellationTokenSource MCOIFPENEFF, bool FLLCCAFDLPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ALHKAPCENDL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public ALHKAPCENDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HDBICCPCIAM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public HDBICCPCIAM(string OFDGGPHHJAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NMLMCNBGCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37C65B0", Offset = "0x37C59B0", VA = "0x1837C65B0")]
	public static FNONIIDNHKM AAGDOGCABML<T>()
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37C6800", Offset = "0x37C5C00", VA = "0x1837C6800")]
	public static FNONIIDNHKM EPFHDNMBIPH<T>([CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37C6630", Offset = "0x37C5A30", VA = "0x1837C6630")]
	public static FNONIIDNHKM AAGDOGCABML<T>(this T FKPHPPGPLLD) where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37C6950", Offset = "0x37C5D50", VA = "0x1837C6950")]
	public static FNONIIDNHKM HLLPFPPNHDK<T>(this T FKPHPPGPLLD, [CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37C68A0", Offset = "0x37C5CA0", VA = "0x1837C68A0")]
	public static FNONIIDNHKM EPFHDNMBIPH<T>(this T JOCJBPPJMJJ, [CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x799E2B0", Offset = "0x799D6B0", VA = "0x18799E2B0")]
	public static FNONIIDNHKM EPFHDNMBIPH(string GKOFGDNKGHI, [CallerMemberName] string IGEPDAOOLBO = "")
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x799E330", Offset = "0x799D730", VA = "0x18799E330")]
	public static string LCHIBOGNELL(this object JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool HIACCFEGOLP();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ALHKAPCENDL]
public delegate long OJICBOCPDMM();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HDGGPFCKPCO
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static DGGKKNHLAMP BOBOOEHCHKD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static DGGKKNHLAMP NOCPFFIEEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x799B3F0", Offset = "0x799A7F0", VA = "0x18799B3F0")]
		get
		{
			return default(DGGKKNHLAMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static LAAPMGPPMJD KCNEAIDBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x799BC40", Offset = "0x799B040", VA = "0x18799BC40")]
		get
		{
			return default(LAAPMGPPMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static ANPGLNMFLIK DCEANCBNCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x799B600", Offset = "0x799AA00", VA = "0x18799B600")]
		get
		{
			return default(ANPGLNMFLIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool ODPGJCPKLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x799B980", Offset = "0x799AD80", VA = "0x18799B980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x799BA90", Offset = "0x799AE90", VA = "0x18799BA90")]
	public static void OGADCEHHGJP([In] DGGKKNHLAMP APEHBBJFCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x799B720", Offset = "0x799AB20", VA = "0x18799B720")]
	public static void GFDFDHMHGGA(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x799B4C0", Offset = "0x799A8C0", VA = "0x18799B4C0")]
	public static void CIEDCJNPNEC(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35EA640", Offset = "0x35E9A40", VA = "0x1835EA640")]
	public static void CIEDCJNPNEC<T>(T HBNMBAEKPFF, FLHLGOHBCJP<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x799B7F0", Offset = "0x799ABF0", VA = "0x18799B7F0")]
	public static void ILKEALIOPDP(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x799B440", Offset = "0x799A840", VA = "0x18799B440")]
	public static void BGIGJFNDACH(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x799B890", Offset = "0x799AC90", VA = "0x18799B890")]
	public static void KALAAOPMCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x799B900", Offset = "0x799AD00", VA = "0x18799B900")]
	public static string LCHIBOGNELL(object BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x799B590", Offset = "0x799A990", VA = "0x18799B590")]
	public static long DKFOOMPJPNO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x799B9F0", Offset = "0x799ADF0", VA = "0x18799B9F0")]
	public static bool MLMFGGGPBJA(bool LNDKBMLMEBB, string DAMFJFKKFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x799B650", Offset = "0x799AA50", VA = "0x18799B650")]
	public static double GDLICHOMJII()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct DGGKKNHLAMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly LAAPMGPPMJD KCNEAIDBIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly ANPGLNMFLIK DCEANCBNCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly GNHDDKLDLAN KAAFDEGDNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly OJICBOCPDMM MKKLGILPFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly MAHJOLNOFEN BKEOCGMDECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly HIACCFEGOLP BEJBNJGJHMP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GNHDDKLDLAN CGPIDKBIFNA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly OJICBOCPDMM PBIFKIKJHKH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MAHJOLNOFEN DNJPDLJFCCI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HIACCFEGOLP DCDCNMLBOIE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly DGGKKNHLAMP GBADJOAJCAL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7999160", Offset = "0x7998560", VA = "0x187999160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7999B40", Offset = "0x7998F40", VA = "0x187999B40")]
	public DGGKKNHLAMP([In] LAAPMGPPMJD LKAKLKDLNCG, [In] ANPGLNMFLIK AGBGFLMAHIF, GNHDDKLDLAN HEJOFDJCICO, OJICBOCPDMM PLBAJOJNJJK, MAHJOLNOFEN GGEKLOBJFLP, HIACCFEGOLP MNFDDNHFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7999300", Offset = "0x7998700", VA = "0x187999300")]
	private static string IIPMAPKINNI(object BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0")]
	private static long NKBMIJHHEJI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	private static string ENOOBBJJCLP(string IPAAOHHFILB, string? EEDLEGPLAKK, bool FKDOLJNPNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	private static bool DEEFMPBMOKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7999340", Offset = "0x7998740", VA = "0x187999340")]
	private static DGGKKNHLAMP JOIDBKAHEAN()
	{
		return default(DGGKKNHLAMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NJJDJCFEJJN
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOBEMCDNGOP LKDLBOJCELA();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OOBEMCDNGOP : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IAEHNHFNHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFKHKGDALIM();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BDMMFIPCFEO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EHKHGLACPFM([In] T KNCKFHOKGJM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void FHNFPKKBLHK<T>([In] T HBNMBAEKPFF);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EMNKDMBIHLH<T> : IEquatable<EMNKDMBIHLH<T>>, BDMMFIPCFEO<EMNKDMBIHLH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T HDKOPKMNJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int FBMJOLKHIKJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42CD970", Offset = "0x42CCD70", VA = "0x1842CD970")]
	public EMNKDMBIHLH([In] T FFOEEMKIKJO, int CJFNAFNJJLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x42CCC10", Offset = "0x42CC010", VA = "0x1842CCC10")]
	public static bool PEOCKCCHEIN([In] EMNKDMBIHLH<T> KGCKEJLFPJB, [In] EMNKDMBIHLH<T> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x42CB7B0", Offset = "0x42CABB0", VA = "0x1842CB7B0", Slot = "4")]
	public bool Equals(EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x42C3140", Offset = "0x42C2540", VA = "0x1842C3140", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42CB720", Offset = "0x42CAB20", VA = "0x1842CB720")]
	public bool EHKHGLACPFM([In] EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x42CB9D0", Offset = "0x42CADD0", VA = "0x1842CB9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42CD780", Offset = "0x42CCB80", VA = "0x1842CD780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42CC120", Offset = "0x42CB520", VA = "0x1842CC120")]
	public void LKJBGMAPBIG([Out] T FFOEEMKIKJO, [Out] int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x42CC780", Offset = "0x42CBB80", VA = "0x1842CC780")]
	public (T, int) OFPCAFDFKPJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42CB8D0", Offset = "0x42CACD0", VA = "0x1842CB8D0", Slot = "5")]
	private bool FHHHEIMKKBJ([In] EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JFALEPNFOBM
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3672A30", Offset = "0x3671E30", VA = "0x183672A30")]
	public static EMNKDMBIHLH<T> HBLBJMFGHFK<T>([In] T FFOEEMKIKJO, int CJFNAFNJJLB) where T : notnull
	{
		return default(EMNKDMBIHLH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LEKMFMCNMPB
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x36DBC90", Offset = "0x36DB090", VA = "0x1836DBC90")]
	public static bool EHKHGLACPFM<T, U>([In] T JOCJBPPJMJJ, [In] U BLFGIKOAKOL) where T : notnull, BDMMFIPCFEO<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult DHBDAOLGCAL<T, out TResult>([In] T HBNMBAEKPFF);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DOFOAGGDJHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan MMFPFEKHKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? DFNANGIENAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMCLIDDFJAP();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBLPGJJGIFH();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KGANBNOPCHG();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct LAAPMGPPMJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly EIOEKGLNLIJ MCPENBGHJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly GGJECCFMMDK NKIDDBJJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly EIOEKGLNLIJ GDAFICLPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly GGJECCFMMDK EFPOGKJGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly EIOEKGLNLIJ LGABBJJBGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly GGJECCFMMDK EMDIABMMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly PJHEJFHGANP GEIBJMPIPAL;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly EIOEKGLNLIJ LDOPDGLDIFM;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly GGJECCFMMDK EDMJNMKNCDA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly EIOEKGLNLIJ NMJEGPKLIBG;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly GGJECCFMMDK NMOECJOIICL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly EIOEKGLNLIJ PMANJHNOPHI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly GGJECCFMMDK NCPLIADDKLN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly PJHEJFHGANP IPIGEMJNOML;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LAAPMGPPMJD GBADJOAJCAL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly EIOEKGLNLIJ PBHDEIGMNGE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x799CC30", Offset = "0x799C030", VA = "0x18799CC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xCCF360", Offset = "0xCCE760", VA = "0x180CCF360")]
	public LAAPMGPPMJD(EIOEKGLNLIJ KGFGALBBDPI, GGJECCFMMDK EIDCIBCOMOP, EIOEKGLNLIJ GPCPBHHMBCL, GGJECCFMMDK ACPFACJOCNM, EIOEKGLNLIJ CKFGNOMBBFN, GGJECCFMMDK GGOGADLDDEB, PJHEJFHGANP ICEKCAINALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	private static bool KHBMBPNKKKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void FAPMOGFEHNL(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	private static bool NHDNCGFFJKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void OLIALOPAFMG(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	private static bool JJABKFDFHIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void KENGOOGGMKP(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void INJIEOMJLBF(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x799CEA0", Offset = "0x799C2A0", VA = "0x18799CEA0")]
	private static LAAPMGPPMJD JOIDBKAHEAN()
	{
		return default(LAAPMGPPMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
	private static bool MGGHIMJLHIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x799CE30", Offset = "0x799C230", VA = "0x18799CE30")]
	public void GFDFDHMHGGA(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x799D0B0", Offset = "0x799C4B0", VA = "0x18799D0B0")]
	public void PADHHMMINIJ(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x799CAE0", Offset = "0x799BEE0", VA = "0x18799CAE0")]
	public void CIEDCJNPNEC(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCC6020", Offset = "0xCC5420", VA = "0x180CC6020")]
	public void ILKEALIOPDP(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x799CB50", Offset = "0x799BF50", VA = "0x18799CB50")]
	public void CIEDCJNPNEC(HMDDOKPCFHD DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36DAA00", Offset = "0x36D9E00", VA = "0x1836DAA00")]
	public void CIEDCJNPNEC<T>(T HBNMBAEKPFF, FLHLGOHBCJP<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36DAAD0", Offset = "0x36D9ED0", VA = "0x1836DAAD0")]
	public void GFDFDHMHGGA<T>([In] T HBNMBAEKPFF, LJIHKPHOJHL<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36DA790", Offset = "0x36D9B90", VA = "0x1836DA790")]
	public void CIEDCJNPNEC<T>([In] T HBNMBAEKPFF, LJIHKPHOJHL<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x799CFE0", Offset = "0x799C3E0", VA = "0x18799CFE0")]
	public bool MLMFGGGPBJA(bool LNDKBMLMEBB, string DAMFJFKKFBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FNONIIDNHKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string HDKOPKMNJCH;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC6E720", Offset = "0xC6DB20", VA = "0x180C6E720")]
	public FNONIIDNHKM(string FFOEEMKIKJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
	public static string CLMIANKGGAM([In] FNONIIDNHKM JOCJBPPJMJJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x216DA20", Offset = "0x216CE20", VA = "0x18216DA20")]
	public static FNONIIDNHKM CLMIANKGGAM(string KNCKFHOKGJM)
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x799AF00", Offset = "0x799A300", VA = "0x18799AF00")]
	public string AECMHBOBEAO(string PELAGPNMFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x799AF50", Offset = "0x799A350", VA = "0x18799AF50")]
	public string NJELCHJAPDI(object OPIBNPLCMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class KOHECBFFINE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public KOHECBFFINE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct LPCAMBCOBBH : IEquatable<LPCAMBCOBBH>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "4")]
	public bool Equals(LPCAMBCOBBH KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x799DDD0", Offset = "0x799D1D0", VA = "0x18799DDD0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x799DE20", Offset = "0x799D220", VA = "0x18799DE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x799DE30", Offset = "0x799D230", VA = "0x18799DE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DGBLOAGKOKD("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct NPOJFHOGAHB<T> : IEquatable<NPOJFHOGAHB<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T HDKOPKMNJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool ELMNJOAKAMI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DMPOPNEJMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x50F0070", Offset = "0x50EF470", VA = "0x1850F0070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50F1060", Offset = "0x50F0460", VA = "0x1850F1060")]
	public NPOJFHOGAHB([In] T FFOEEMKIKJO, bool LMLKBFEHCMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50F02D0", Offset = "0x50EF6D0", VA = "0x1850F02D0")]
	public static bool PEOCKCCHEIN([In] NPOJFHOGAHB<T> KGCKEJLFPJB, [In] NPOJFHOGAHB<T> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50EEEB0", Offset = "0x50EE2B0", VA = "0x1850EEEB0", Slot = "4")]
	public bool Equals(NPOJFHOGAHB<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50EF5A0", Offset = "0x50EE9A0", VA = "0x1850EF5A0", Slot = "0")]
	public override bool Equals(object? KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x50EFA30", Offset = "0x50EEE30", VA = "0x1850EFA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x50F0C30", Offset = "0x50F0030", VA = "0x1850F0C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FINHBCLIBNM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35BF0F0", Offset = "0x35BE4F0", VA = "0x1835BF0F0")]
	public static NPOJFHOGAHB<T> GHLIHICBODC<T>([In] T FFOEEMKIKJO) where T : notnull
	{
		return default(NPOJFHOGAHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35BF2F0", Offset = "0x35BE6F0", VA = "0x1835BF2F0")]
	public static NPOJFHOGAHB<T?> NFMBBBIJCEI<T>()
	{
		return default(NPOJFHOGAHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x35BEFA0", Offset = "0x35BE3A0", VA = "0x1835BEFA0")]
	public static bool DCKDEFGFKNG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, [Out][NotNullWhen(true)] T FFOEEMKIKJO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x35BEF60", Offset = "0x35BE360", VA = "0x1835BEF60")]
	public static bool DCKDEFGFKNG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, [Out][NotNullWhen(true)] T FFOEEMKIKJO, [Out] NPOJFHOGAHB<T> LMBIAMNEEOB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x35BEFD0", Offset = "0x35BE3D0", VA = "0x1835BEFD0")]
	public static T? GBBPDPCPIPG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, T? PFCPDJEHNAP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x35BEE30", Offset = "0x35BE230", VA = "0x1835BEE30")]
	public static bool BAMDOIHHMCB<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, T FFOEEMKIKJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NLFBPFAKCBN
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37C6190", Offset = "0x37C5590", VA = "0x1837C6190")]
	public static T FICJKHFJNIG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ANPGLNMFLIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr BGIGJFNDACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr KALAAOPMCOL;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr GANNMIOFFPA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr JEGJIMBCPGI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly ANPGLNMFLIK GBADJOAJCAL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KCBHPIPJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7994830", Offset = "0x7993C30", VA = "0x187994830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
	public ANPGLNMFLIK(IntPtr PNCPANBBJNA, IntPtr FPCJJJBOFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void LCNGAJLBHEH(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	private static void KPJNELOCFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7994910", Offset = "0x7993D10", VA = "0x187994910")]
	private static ANPGLNMFLIK JOIDBKAHEAN()
	{
		return default(ANPGLNMFLIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct HDPBFJCBNML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr OGOGLOACMED;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
	private HDPBFJCBNML(IntPtr FPCJJJBOFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x799BE40", Offset = "0x799B240", VA = "0x18799BE40")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x799BD50", Offset = "0x799B150", VA = "0x18799BD50")]
	public static HDPBFJCBNML HBLBJMFGHFK(string IGEPDAOOLBO)
	{
		return default(HDPBFJCBNML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2678BC0", Offset = "0x2677FC0", VA = "0x182678BC0")]
	public static HDPBFJCBNML HBLBJMFGHFK([In] ANPGLNMFLIK AGBGFLMAHIF, string IGEPDAOOLBO)
	{
		return default(HDPBFJCBNML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2679320", Offset = "0x2678720", VA = "0x182679320")]
	public static HDPBFJCBNML HBLBJMFGHFK([In] ANPGLNMFLIK AGBGFLMAHIF, Func<string> IGEPDAOOLBO)
	{
		return default(HDPBFJCBNML);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CLCHGEFFLNK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool HAJDLBIMCOH<in TInput, TResult>(TInput PJCOHHCODGF, [Out] TResult HBALBIOOGIJ);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class BMKKJIFPEEN : NJJDJCFEJJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class EMMIODKDPGL : OOBEMCDNGOP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly EMMIODKDPGL DNEPPKLGBFA;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool IAEHNHFNHAH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x799A800", Offset = "0x7999C00", VA = "0x18799A800", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x799A6A0", Offset = "0x7999AA0", VA = "0x18799A6A0", Slot = "6")]
			public void OnCompleted(Action KLINOMADKJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			public void OFKHKGDALIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public EMMIODKDPGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly BMKKJIFPEEN DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		private BMKKJIFPEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7995350", Offset = "0x7994750", VA = "0x187995350", Slot = "4")]
		public OOBEMCDNGOP LKDLBOJCELA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class OIDHIIKPDOE : NJJDJCFEJJN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class IFMPMCEJMJG : OOBEMCDNGOP, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly IFMPMCEJMJG DNEPPKLGBFA;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool IAEHNHFNHAH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x799C2C0", Offset = "0x799B6C0", VA = "0x18799C2C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x799C270", Offset = "0x799B670", VA = "0x18799C270", Slot = "6")]
			public void OnCompleted(Action KLINOMADKJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			public void OFKHKGDALIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public IFMPMCEJMJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly OIDHIIKPDOE DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		private OIDHIIKPDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x799E450", Offset = "0x799D850", VA = "0x18799E450", Slot = "4")]
		public OOBEMCDNGOP LKDLBOJCELA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FFBOBHLIGON<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public FFBOBHLIGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4706F60", Offset = "0x4706360", VA = "0x184706F60")]
		internal void GLKBPOFBHIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class CIPJJEPAKJJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CIPJJEPAKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x482FAC0", Offset = "0x482EEC0", VA = "0x18482FAC0")]
		internal void DPLABJMELHK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EPFBFHEAGLC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799A8E0", Offset = "0x7999CE0", VA = "0x18799A8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IBABEAEDBMC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799BF20", Offset = "0x799B320", VA = "0x18799BF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BHOPIGBEFHE<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x5F3F4C0", Offset = "0x5F3E8C0", VA = "0x185F3F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5F3F630", Offset = "0x5F3EA30", VA = "0x185F3F630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EMOHAFPGEGO<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x42CDE20", Offset = "0x42CD220", VA = "0x1842CDE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x42CE250", Offset = "0x42CD650", VA = "0x1842CE250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OJACDADEIEJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799E520", Offset = "0x799D920", VA = "0x18799E520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x799E730", Offset = "0x799DB30", VA = "0x18799E730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class HKAKMHAIAKL<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public HKAKMHAIAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4706F60", Offset = "0x4706360", VA = "0x184706F60")]
		internal void KIOGOPLHLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4903E10", Offset = "0x4903210", VA = "0x184903E10")]
		internal void OODFJLKIDDJ(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct KLIMLPLJPKF<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public HAJDLBIMCOH<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4D871B0", Offset = "0x4D865B0", VA = "0x184D871B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4D878C0", Offset = "0x4D86CC0", VA = "0x184D878C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct BLHDLNCKPPG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7994AF0", Offset = "0x7993EF0", VA = "0x187994AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x79952F0", Offset = "0x79946F0", VA = "0x1879952F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct LJHNKFEMGCN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799D820", Offset = "0x799CC20", VA = "0x18799D820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x799DD70", Offset = "0x799D170", VA = "0x18799DD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct PMKGFMJDBDC<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x53234E0", Offset = "0x53228E0", VA = "0x1853234E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x426B8B0", Offset = "0x426ACB0", VA = "0x18426B8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DHCDKFKEOCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<LPCAMBCOBBH> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DHCDKFKEOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7999BF0", Offset = "0x7998FF0", VA = "0x187999BF0")]
		internal void FJHFPABKJPM(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct PPNDCLKMOID<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5328020", Offset = "0x5327420", VA = "0x185328020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3E854B0", Offset = "0x3E848B0", VA = "0x183E854B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct IJPIOHBOOPF<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x49F12F0", Offset = "0x49F06F0", VA = "0x1849F12F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x49F21F0", Offset = "0x49F15F0", VA = "0x1849F21F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IDGEGFLCPLF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799C030", Offset = "0x799B430", VA = "0x18799C030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x799C210", Offset = "0x799B610", VA = "0x18799C210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct AIKEBCPCAAN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x79935C0", Offset = "0x79929C0", VA = "0x1879935C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7993930", Offset = "0x7992D30", VA = "0x187993930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MMPDNBOHJND : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799DF60", Offset = "0x799D360", VA = "0x18799DF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x799E250", Offset = "0x799D650", VA = "0x18799E250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class IJFOAGFHGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IJFOAGFHGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x799C360", Offset = "0x799B760", VA = "0x18799C360")]
		internal Task LMJMGAAENGJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct FIAAAJLOHID : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799AC40", Offset = "0x799A040", VA = "0x18799AC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x799AEA0", Offset = "0x799A2A0", VA = "0x18799AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct CBIOBCGNIIK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x79959F0", Offset = "0x7994DF0", VA = "0x1879959F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7995BD0", Offset = "0x7994FD0", VA = "0x187995BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct GOEFKNPPIKM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799B030", Offset = "0x799A430", VA = "0x18799B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x799B390", Offset = "0x799A790", VA = "0x18799B390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OOHMPCOOFCB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799E800", Offset = "0x799DC00", VA = "0x18799E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x799EAF0", Offset = "0x799DEF0", VA = "0x18799EAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class DICKHBLADBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DICKHBLADBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7999D00", Offset = "0x7999100", VA = "0x187999D00")]
		internal Task LDMKGCNAAFI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct EJOPAPBNAJA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799A3E0", Offset = "0x79997E0", VA = "0x18799A3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x799A640", Offset = "0x7999A40", VA = "0x18799A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct KIGJGPKAKDK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799C570", Offset = "0x799B970", VA = "0x18799C570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x799C6F0", Offset = "0x799BAF0", VA = "0x18799C6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LADMOBKGOHA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E15070", Offset = "0x4E14470", VA = "0x184E15070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4E152D0", Offset = "0x4E146D0", VA = "0x184E152D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct KLOCAHONDME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x799C750", Offset = "0x799BB50", VA = "0x18799C750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x799CA80", Offset = "0x799BE80", VA = "0x18799CA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? EEJAGFFINME;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<LPCAMBCOBBH> IGHBHNDCIBO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task NOELIPIJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79971E0", Offset = "0x79965E0", VA = "0x1879971E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79985F0", Offset = "0x79979F0", VA = "0x1879985F0")]
	public static bool OPOOEKLOOGK(this Task NHNFPALEEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33F2B00", Offset = "0x33F1F00", VA = "0x1833F2B00")]
	public static Task<T> NKLPPIFMAEJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7997CF0", Offset = "0x79970F0", VA = "0x187997CF0")]
	public static Task MIMDGFPLJBO(this Task NHNFPALEEPM, CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x33F1200", Offset = "0x33F0600", VA = "0x1833F1200")]
	public static Task<TResult> MIMDGFPLJBO<TResult>(this Task<TResult> NHNFPALEEPM, CancellationToken HHGPJKKLNIG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x33F2170", Offset = "0x33F1570", VA = "0x1833F2170")]
	public static TaskCompletionSource<TResult> MIMDGFPLJBO<TResult>(this TaskCompletionSource<TResult> BBMIIIIDLPN, CancellationToken HHGPJKKLNIG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7997A90", Offset = "0x7996E90", VA = "0x187997A90")]
	public static IDisposable? LIKGIDICEJC(CancellationToken OIFGOIJPJJF, CancellationToken AHIPNAHFCKO, [Out] CancellationToken IPKNOIPJJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7996B00", Offset = "0x7995F00", VA = "0x187996B00")]
	[AsyncStateMachine(typeof(EPFBFHEAGLC))]
	public static void DDPHDFIOPJG(this Task OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7996F30", Offset = "0x7996330", VA = "0x187996F30")]
	[AsyncStateMachine(typeof(IBABEAEDBMC))]
	public static void DGAOJCFJAID(this Task OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x33F2C80", Offset = "0x33F2080", VA = "0x1833F2C80")]
	[AsyncStateMachine(typeof(BHOPIGBEFHE<>))]
	public static Task PNDEPDFIKEK<TException>(this Task OOLNPDLPIEB) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x33EDF40", Offset = "0x33ED340", VA = "0x1833EDF40")]
	[AsyncStateMachine(typeof(EMOHAFPGEGO<>))]
	public static Task<T> CPDJLGOBCGB<T>(this Task<T> JOCJBPPJMJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7996A10", Offset = "0x7995E10", VA = "0x187996A10")]
	[AsyncStateMachine(typeof(OJACDADEIEJ))]
	public static Task<TaskStatus> CPMIONBLFOB(this Task? JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x33EE690", Offset = "0x33EDA90", VA = "0x1833EE690")]
	public static (Task<T?>?, Action<T?>?) MAOOBHDIIKH<T>([Optional] CancellationToken LMNHDKIFBOH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x33EDB50", Offset = "0x33ECF50", VA = "0x1833EDB50")]
	[AsyncStateMachine(typeof(KLIMLPLJPKF<, >))]
	public static Task<List<TResult>> BOMCAFIAKBI<TResult, TInput>(this Task<List<TInput>> NHNFPALEEPM, HAJDLBIMCOH<TInput, TResult> AKOAOGNBOGF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7997250", Offset = "0x7996650", VA = "0x187997250")]
	[AsyncStateMachine(typeof(BLHDLNCKPPG))]
	public static Task FEDJJGNOBAO(Task OOLNPDLPIEB, CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task> MPOKLJCJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7997590", Offset = "0x7996990", VA = "0x187997590")]
	[AsyncStateMachine(typeof(LJHNKFEMGCN))]
	public static Task IGPODLIKIFB(Func<CancellationToken, Task> IJBCOFDMABE, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken BOHHBCNKHLK, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x33EE210", Offset = "0x33ED610", VA = "0x1833EE210")]
	[AsyncStateMachine(typeof(PMKGFMJDBDC<>))]
	public static Task<T> IGPODLIKIFB<T>(Func<CancellationToken, Task<T>> IJBCOFDMABE, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken BOHHBCNKHLK, [Optional] Func<OperationCanceledException, T>? NMNCODLGAAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x79980E0", Offset = "0x79974E0", VA = "0x1879980E0")]
	public static Task OKHMPPCNOCD(params Task[] BHJKIFMNNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7998130", Offset = "0x7997530", VA = "0x187998130")]
	public static Task OKHMPPCNOCD(IEnumerable<Task> BHJKIFMNNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x33EE5A0", Offset = "0x33ED9A0", VA = "0x1833EE5A0")]
	[AsyncStateMachine(typeof(PPNDCLKMOID<>))]
	public static Task<IEnumerable<Task<T>>> JBCJONEPAJB<T>(IEnumerable<Task<T>> BHJKIFMNNKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x33EDC60", Offset = "0x33ED060", VA = "0x1833EDC60")]
	[AsyncStateMachine(typeof(IJPIOHBOOPF<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> CKNEDHHPBHL<T1, T2, T3, T4, T5>(Task<T1> NGNAGNMICOJ, Task<T2> OHHMIELAKND, Task<T3> IAIAAPPLALC, Task<T4> KCHHLKKALPL, Task<T5> GGGCLHOEDDO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7996FE0", Offset = "0x79963E0", VA = "0x187996FE0")]
	[AsyncStateMachine(typeof(IDGEGFLCPLF))]
	public static Task DJICGCLEACM(Func<bool> LNDKBMLMEBB, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79970D0", Offset = "0x79964D0", VA = "0x1879970D0")]
	[AsyncStateMachine(typeof(AIKEBCPCAAN))]
	public static Task DJICGCLEACM(Func<bool> LNDKBMLMEBB, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79967A0", Offset = "0x7995BA0", VA = "0x1879967A0")]
	[AsyncStateMachine(typeof(MMPDNBOHJND))]
	public static Task BLPFDCPCLOH(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79968D0", Offset = "0x7995CD0", VA = "0x1879968D0")]
	[AsyncStateMachine(typeof(FIAAAJLOHID))]
	public static Task BLPFDCPCLOH(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7997770", Offset = "0x7996B70", VA = "0x187997770")]
	[AsyncStateMachine(typeof(CBIOBCGNIIK))]
	public static Task LBJLBEDDCFL(Func<bool> LNDKBMLMEBB, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7997860", Offset = "0x7996C60", VA = "0x187997860")]
	[AsyncStateMachine(typeof(GOEFKNPPIKM))]
	public static Task LBJLBEDDCFL(Func<bool> LNDKBMLMEBB, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7996670", Offset = "0x7995A70", VA = "0x187996670")]
	[AsyncStateMachine(typeof(OOHMPCOOFCB))]
	public static Task BDGILFAJFCK(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7996530", Offset = "0x7995930", VA = "0x187996530")]
	[AsyncStateMachine(typeof(EJOPAPBNAJA))]
	public static Task BDGILFAJFCK(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79974A0", Offset = "0x79968A0", VA = "0x1879974A0")]
	[AsyncStateMachine(typeof(KIGJGPKAKDK))]
	[Obsolete]
	public static Task IENKHJLJPBM(this Task NHNFPALEEPM, Action JDHGNBFHADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x33EE120", Offset = "0x33ED520", VA = "0x1833EE120")]
	[AsyncStateMachine(typeof(LADMOBKGOHA<>))]
	[Obsolete]
	public static Task IENKHJLJPBM<T>(this Task<T> NHNFPALEEPM, Action<T> JDHGNBFHADN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79976C0", Offset = "0x7996AC0", VA = "0x1879976C0")]
	private static void KMNDLNIDFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7996BB0", Offset = "0x7995FB0", VA = "0x187996BB0")]
	public static bool DEAGOJPMOLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7997F50", Offset = "0x7997350", VA = "0x187997F50")]
	private static void OAONEBCAHMB(SynchronizationContext FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7997970", Offset = "0x7996D70", VA = "0x187997970")]
	private static void LCPKMPPCAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7996460", Offset = "0x7995860", VA = "0x187996460")]
	public static void BBAKMJLDMGL([Optional] string? DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7997420", Offset = "0x7996820", VA = "0x187997420")]
	public static void GBFFDCHOMAN([Optional] string? DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x79973D0", Offset = "0x79967D0", VA = "0x1879973D0")]
	public static NJJDJCFEJJN FPIKOHDMPFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7997380", Offset = "0x7996780", VA = "0x187997380")]
	public static NJJDJCFEJJN FMGFGBBPFJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7997C20", Offset = "0x7997020", VA = "0x187997C20")]
	[AsyncStateMachine(typeof(KLOCAHONDME))]
	public static Task LOHAOIKDADM(Func<Task> MOIIPMBKBLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CBAKGNGODOD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public CBAKGNGODOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class LCOONJBGLLL : EJMLPOJDKGC
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly EJMLPOJDKGC DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime LIDJDAKNBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x799D700", Offset = "0x799CB00", VA = "0x18799D700", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset OAKGJNOCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x799D740", Offset = "0x799CB40", VA = "0x18799D740", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public LCOONJBGLLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface EJMLPOJDKGC
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime LIDJDAKNBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset OAKGJNOCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CHNEFNENFPM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long LIOENBKMCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x79960F0", Offset = "0x79954F0", VA = "0x1879960F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long IJNIPDPHFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7996010", Offset = "0x7995410", VA = "0x187996010")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double HNPIMDEKMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7995E70", Offset = "0x7995270", VA = "0x187995E70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double GHNDGHGODKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7996140", Offset = "0x7995540", VA = "0x187996140")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double OMCKCHKNOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7995D00", Offset = "0x7995100", VA = "0x187995D00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double LMEOLNAOBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7995F60", Offset = "0x7995360", VA = "0x187995F60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7996060", Offset = "0x7995460", VA = "0x187996060")]
	public static double MMPJAMJPPLE(long MGGFKFDDLIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7995DE0", Offset = "0x79951E0", VA = "0x187995DE0")]
	public static double DLKMJOJMPJO(long MGGFKFDDLIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7995ED0", Offset = "0x79952D0", VA = "0x187995ED0")]
	public static double HCOBAHDBOMB(double EPLAJLCGKKF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7995D50", Offset = "0x7995150", VA = "0x187995D50")]
	public static long CKHDGKGOHOE(long PCFGHPNONAI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7995EC0", Offset = "0x79952C0", VA = "0x187995EC0")]
	public static long GHHKDJABHFH(long ACLAAMEOOPB, long OOAJPLNCGNB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7995C30", Offset = "0x7995030", VA = "0x187995C30")]
	public static double CDFALOKIBBI(long ACLAAMEOOPB, long OOAJPLNCGNB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7995FB0", Offset = "0x79953B0", VA = "0x187995FB0")]
	public static double MGNMMBLHPNH(long ACLAAMEOOPB, long OOAJPLNCGNB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class PHLMONLMJGG : DOFOAGGDJHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan IKHAGPJNELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer KINEPAABOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan ADEFLDLMJBI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan MMFPFEKHKLP
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x799F060", Offset = "0x799E460", VA = "0x18799F060", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? DFNANGIENAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x799F4F0", Offset = "0x799E8F0", VA = "0x18799F4F0")]
	[Preserve]
	public PHLMONLMJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x799F2A0", Offset = "0x799E6A0", VA = "0x18799F2A0")]
	public PHLMONLMJGG(TimeSpan ADEFLDLMJBI, [Optional] Action? HFEDDDBOMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x799EF00", Offset = "0x799E300", VA = "0x18799EF00", Slot = "7")]
	public void FMCLIDDFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x799F1C0", Offset = "0x799E5C0", VA = "0x18799F1C0", Slot = "8")]
	public void MBLPGJJGIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x799EF90", Offset = "0x799E390", VA = "0x18799EF90", Slot = "9")]
	public void KGANBNOPCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x103EC90", Offset = "0x103E090", VA = "0x18103EC90")]
	private void CCAGHBILIBK(object FKPHPPGPLLD, ElapsedEventArgs OFEFIEHPEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x799EFC0", Offset = "0x799E3C0", VA = "0x18799EFC0")]
	private static void KHBACOPMPMC(TimeSpan HEIAKNJACAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x799EE60", Offset = "0x799E260", VA = "0x18799EE60", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DGBLOAGKOKD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? HBEAMEKJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string PKJGJAKPLAO;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x73023F0", Offset = "0x73017F0", VA = "0x1873023F0")]
	public DGBLOAGKOKD(string ONJHPHOODPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x49F9DA0", Offset = "0x49F91A0", VA = "0x1849F9DA0")]
	public DGBLOAGKOKD(string AAOLLMPNAHE, string ONJHPHOODPK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct AKBOPDOBDEE : IEquatable<AKBOPDOBDEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint DDOPGLNDAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int AJFDHGEKOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float EPDMECCNAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort MJAMEFDAAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort FCAABAHPCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short GBGNBIJGMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short GFLFPGCMPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char AHFNBAJKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char DDJCILNGDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte KOEIFMGJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte CKJMBGHEOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte NBNFOEALMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte NIOPBDOBLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool MNNDBPDIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool LOAPCFPKPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool GFHDFKEEMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool EPNABKHMJJK;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1D345A0", Offset = "0x1D339A0", VA = "0x181D345A0")]
	public static AKBOPDOBDEE PMGAMFEKDIM(uint CNMOFLBBPDL)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1D345A0", Offset = "0x1D339A0", VA = "0x181D345A0")]
	public static AKBOPDOBDEE GGNANFDPEDC(int DJLIDNFCFDD)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7993A30", Offset = "0x7992E30", VA = "0x187993A30")]
	public static AKBOPDOBDEE LMNFGAKPMJG(float LHADKEGPLLL)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7993990", Offset = "0x7992D90", VA = "0x187993990")]
	public static AKBOPDOBDEE NHHHPPLAIMC(byte KPCONMLKGOI, byte NFKHCNNDAKC, byte OEEDABJCECL, byte BCOAIDIJCGH)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7993990", Offset = "0x7992D90", VA = "0x187993990")]
	public static AKBOPDOBDEE PEIBGEIPJFH(bool GHOPFNLOBOM, bool NIFDMAOIHLP, bool GIGNKIEJGCL, bool LKHMFILCMOA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7993990", Offset = "0x7992D90", VA = "0x187993990")]
	public static AKBOPDOBDEE DOPNHGJANFP(byte EKMLAOFMMBB, byte CLJDLIFBMKM, byte GMLDCKFHLEM, byte JAEDPENADAM)
	{
		return default(AKBOPDOBDEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x202FBE0", Offset = "0x202EFE0", VA = "0x18202FBE0")]
	public static bool PEOCKCCHEIN(AKBOPDOBDEE BICHNBDCKLH, AKBOPDOBDEE CKCKMBIGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x202FBC0", Offset = "0x202EFC0", VA = "0x18202FBC0", Slot = "4")]
	public bool Equals(AKBOPDOBDEE KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x79939B0", Offset = "0x7992DB0", VA = "0x1879939B0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x11D2130", Offset = "0x11D1530", VA = "0x1811D2130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7993A40", Offset = "0x7992E40", VA = "0x187993A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct HOOEOPFHBCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong LFOLGMIFFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long JPLKJBFOCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double FDKIGGCMPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint IJMNIAMLAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint HKKGEDPCKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int PJNLCEFBGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int DCGMJCCJJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float HMDOIGOFNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float LLHOCFEMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort MJAMEFDAAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort FCAABAHPCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort KKODDAIGGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort PNDEGHJDEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short GBGNBIJGMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short GFLFPGCMPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short NKDINBNPAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short OMBFDKJDIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char AHFNBAJKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char DDJCILNGDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char NLOJDHEBGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char GLPCLIDFHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte KOEIFMGJBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte CKJMBGHEOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte NBNFOEALMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte NIOPBDOBLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte LEOMMOLCEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte BCJDMCEAAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte NHEMJOLEBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte KFNOCMNPBOP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static HOOEOPFHBCL HBLBJMFGHFK(long ENMIKPFDHIK)
	{
		return default(HOOEOPFHBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x799BED0", Offset = "0x799B2D0", VA = "0x18799BED0")]
	public static HOOEOPFHBCL HBLBJMFGHFK(byte KPCONMLKGOI, byte NFKHCNNDAKC, byte OEEDABJCECL, byte BCOAIDIJCGH, byte FPLIHLOAGEO, byte OHMEHDLKEBO, byte BGKBCOIFHEO, byte HJAGHEMCGMA)
	{
		return default(HOOEOPFHBCL);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PFKEJJALNEF : IEquatable<PFKEJJALNEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte FHIPIDMIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool GFIMAKFPKHC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0350", Offset = "0x2CCF750", VA = "0x182CD0350")]
	public static PFKEJJALNEF NHHHPPLAIMC(byte MBLPLEHAOKA)
	{
		return default(PFKEJJALNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0350", Offset = "0x2CCF750", VA = "0x182CD0350")]
	public static PFKEJJALNEF PEIBGEIPJFH(bool OAAFEPPONMI)
	{
		return default(PFKEJJALNEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x799EBF0", Offset = "0x799DFF0", VA = "0x18799EBF0")]
	public static bool PEOCKCCHEIN(PFKEJJALNEF BICHNBDCKLH, PFKEJJALNEF CKCKMBIGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x696DE30", Offset = "0x696D230", VA = "0x18696DE30", Slot = "4")]
	public bool Equals(PFKEJJALNEF KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x799EB50", Offset = "0x799DF50", VA = "0x18799EB50", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x799EBE0", Offset = "0x799DFE0", VA = "0x18799EBE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x799EC00", Offset = "0x799E000", VA = "0x18799EC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JIGCOPPJMPF<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T HNHIOFDPHAD;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4BECA00", Offset = "0x4BEBE00", VA = "0x184BECA00")]
	public JIGCOPPJMPF(T FNOEJJOGNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class OIOIHOCEBHL
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3608F50", Offset = "0x3608350", VA = "0x183608F50")]
	public static IEnumerable<T> LBOIHFCCBEI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static T[] KMKNGPIDICM<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static IEnumerable<T> DDNGGBGCCEA<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static HashSet<T> JKLOPCBHIJN<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x37F6570", Offset = "0x37F5970", VA = "0x1837F6570")]
	public static KeyValuePair<TKey, TValue> GNNPMEAMFII<TKey, TValue>([In] TKey DJBLFBEBKGO, [In] TValue FFOEEMKIKJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static List<T> OBMLFLDOBOL<T>(IEnumerable<T> KKIPPMFKGPH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MOGMCIKHBCO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string IBFBIJECCOC;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
	public MOGMCIKHBCO(string DECLPGCFODA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object LJIHKPHOJHL<T>([In] T BPKDFLJLPAA);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object FLHLGOHBCJP<T>(T BPKDFLJLPAA);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[ALHKAPCENDL]
public delegate string MAHJOLNOFEN(string IPAAOHHFILB, string? EEDLEGPLAKK, bool FKDOLJNPNMC);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[ALHKAPCENDL]
public delegate void GGJECCFMMDK(string DAMFJFKKFBI);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[ALHKAPCENDL]
public delegate void PJHEJFHGANP(Exception BLCFGIAFKHH);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object HMDDOKPCFHD();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ALHKAPCENDL]
public delegate bool EIOEKGLNLIJ();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ALHKAPCENDL]
public delegate string GNHDDKLDLAN(object BLFGIKOAKOL);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class CIIGAGHPKDH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
	public CIIGAGHPKDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class EJEIEPDKAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct DAFDFOMGCOB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x79986E0", Offset = "0x7997AE0", VA = "0x1879986E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7998FD0", Offset = "0x79983D0", VA = "0x187998FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback AMCHNKAHJPB;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> NBJLLAMEOID;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7999F30", Offset = "0x7999330", VA = "0x187999F30")]
	public static Task<bool> PLIJGLLMAAN(int EBFEOAODHKK, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7999E00", Offset = "0x7999200", VA = "0x187999E00")]
	[AsyncStateMachine(typeof(DAFDFOMGCOB))]
	private static Task<bool> IDLNFBALANG(int EBFEOAODHKK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7999D70", Offset = "0x7999170", VA = "0x187999D70")]
	private static void HPMBAKNAKOF(object? DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x799A240", Offset = "0x7999640", VA = "0x18799A240")]
	private static void PNLAKIONFKM(object? DHJOIBPBMPI)
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
