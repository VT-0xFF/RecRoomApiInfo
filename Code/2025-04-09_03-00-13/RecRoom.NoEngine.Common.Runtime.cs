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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79ECD10", Offset = "0x79EC110", VA = "0x1879ECD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BNKGPLEJEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79E3F30", Offset = "0x79E3330", VA = "0x1879E3F30")]
	public static string DKIEJMKIMKH(this Encoding CBAOGPOALEA, [In] ReadOnlySequence<byte> DHHEGLJJIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x339D7B0", Offset = "0x339CBB0", VA = "0x18339D7B0")]
	private static void IOJKCEBLBIK<T>(this ReadOnlySequence<T> LGAMEGCBKGI, [Out] ReadOnlySpan<T> NGDAJNLEOJF, [Out] SequencePosition POEMJFLDIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class DDHGLPDDADJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79E7AC0", Offset = "0x79E6EC0", VA = "0x1879E7AC0")]
	public DDHGLPDDADJ(bool HALGMBGJENC, string IFENPNGHNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79E7B90", Offset = "0x79E6F90", VA = "0x1879E7B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C86A0", Offset = "0x9C7AA0", VA = "0x1809C86A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double AICDMCCHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79EDF70", Offset = "0x79ED370", VA = "0x1879EDF70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KMPDGIHKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x53089B0", Offset = "0x5307DB0", VA = "0x1853089B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double CNEGDKBOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x261B0A0", Offset = "0x261A4A0", VA = "0x18261B0A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79EE170", Offset = "0x79ED570", VA = "0x1879EE170")]
	public PKKHFAKCKEL(int CHGNALBKAJL, double NAOCOKDGJCL = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79EE040", Offset = "0x79ED440", VA = "0x1879EE040", Slot = "7")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79EDFD0", Offset = "0x79ED3D0", VA = "0x1879EDFD0", Slot = "8")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79EDE70", Offset = "0x79ED270", VA = "0x1879EDE70", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KMPDGIHKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8770", Offset = "0x6CF7B70", VA = "0x186CF8770", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CNEGDKBOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8790", Offset = "0x6CF7B90", VA = "0x186CF8790", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double BBCFKGPHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CF87C0", Offset = "0x6CF7BC0", VA = "0x186CF87C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AICDMCCHFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBCB0", Offset = "0x2CBB0B0", VA = "0x182CBBCB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79E94E0", Offset = "0x79E88E0", VA = "0x1879E94E0", Slot = "10")]
	public virtual void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79E94A0", Offset = "0x79E88A0", VA = "0x1879E94A0", Slot = "11")]
	public virtual void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79E9430", Offset = "0x79E8830", VA = "0x1879E9430", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79E9600", Offset = "0x79E8A00", VA = "0x1879E9600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CF8320", Offset = "0x6CF7720", VA = "0x186CF8320")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6CF87D0", Offset = "0x6CF7BD0", VA = "0x186CF87D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79EADC0", Offset = "0x79EA1C0", VA = "0x1879EADC0", Slot = "10")]
	public override void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79EAD80", Offset = "0x79EA180", VA = "0x1879EAD80", Slot = "11")]
	public override void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x79E9600", Offset = "0x79E8A00", VA = "0x1879E9600")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EA870", Offset = "0x79E9C70", VA = "0x1879EA870")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7948D10", Offset = "0x7948110", VA = "0x187948D10", Slot = "4")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79EA880", Offset = "0x79E9C80", VA = "0x1879EA880", Slot = "5")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x79EA820", Offset = "0x79E9C20", VA = "0x1879EA820", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x436D1A0", Offset = "0x436C5A0", VA = "0x18436D1A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x50C70E0", Offset = "0x50C64E0", VA = "0x1850C70E0", Slot = "4")]
	public void GCPGPNHKDDF(double PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79ED120", Offset = "0x79EC520", VA = "0x1879ED120", Slot = "5")]
	public void GCJCJGLHJHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x79ED0D0", Offset = "0x79EC4D0", VA = "0x1879ED0D0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x50F4120", Offset = "0x50F3520", VA = "0x1850F4120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50F51E0", Offset = "0x50F45E0", VA = "0x1850F51E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D91700", Offset = "0x4D90B00", VA = "0x184D91700")]
	[AsyncStateMachine(typeof(KIFJPLNLCKP<>.NIIJBBDAOED))]
	public Task<TResult> NODIGKIAMID(CIOHNCGLFOC AFDLLEKBIKO, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D91690", Offset = "0x4D90A90", VA = "0x184D91690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D91840", Offset = "0x4D90C40", VA = "0x184D91840")]
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
	[Cpp2IlInjected.Address(RVA = "0x42FAA10", Offset = "0x42F9E10", VA = "0x1842FAA10")]
	public GLIKECAMIPF([In] T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48691B0", Offset = "0x48685B0", VA = "0x1848691B0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4869440", Offset = "0x4868840", VA = "0x184869440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x48696E0", Offset = "0x4868AE0", VA = "0x1848696E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OIOHCLGNHMG
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
	public static GLIKECAMIPF<T> HBLBJMFGHFK<T>([In] T FFOEEMKIKJO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JLDEHKFFIIH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x79EAEF0", Offset = "0x79EA2F0", VA = "0x1879EAEF0")]
	public static void ODJLNCJMKPN(this CancellationTokenSource MCOIFPENEFF, bool FLLCCAFDLPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ALHKAPCENDL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
	public ALHKAPCENDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HDBICCPCIAM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
	public HDBICCPCIAM(string OFDGGPHHJAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NMLMCNBGCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37D88F0", Offset = "0x37D7CF0", VA = "0x1837D88F0")]
	public static FNONIIDNHKM AAGDOGCABML<T>()
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37D8B40", Offset = "0x37D7F40", VA = "0x1837D8B40")]
	public static FNONIIDNHKM EPFHDNMBIPH<T>([CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37D8970", Offset = "0x37D7D70", VA = "0x1837D8970")]
	public static FNONIIDNHKM AAGDOGCABML<T>(this T FKPHPPGPLLD) where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37D8C90", Offset = "0x37D8090", VA = "0x1837D8C90")]
	public static FNONIIDNHKM HLLPFPPNHDK<T>(this T FKPHPPGPLLD, [CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37D8BE0", Offset = "0x37D7FE0", VA = "0x1837D8BE0")]
	public static FNONIIDNHKM EPFHDNMBIPH<T>(this T JOCJBPPJMJJ, [CallerMemberName] string IGEPDAOOLBO = "") where T : notnull
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79ECBF0", Offset = "0x79EBFF0", VA = "0x1879ECBF0")]
	public static FNONIIDNHKM EPFHDNMBIPH(string GKOFGDNKGHI, [CallerMemberName] string IGEPDAOOLBO = "")
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79ECC70", Offset = "0x79EC070", VA = "0x1879ECC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E9DE0", Offset = "0x79E91E0", VA = "0x1879E9DE0")]
		get
		{
			return default(DGGKKNHLAMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static LAAPMGPPMJD KCNEAIDBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79EA610", Offset = "0x79E9A10", VA = "0x1879EA610")]
		get
		{
			return default(LAAPMGPPMJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static ANPGLNMFLIK DCEANCBNCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79E9FF0", Offset = "0x79E93F0", VA = "0x1879E9FF0")]
		get
		{
			return default(ANPGLNMFLIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool ODPGJCPKLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79EA360", Offset = "0x79E9760", VA = "0x1879EA360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79EA470", Offset = "0x79E9870", VA = "0x1879EA470")]
	public static void OGADCEHHGJP([In] DGGKKNHLAMP APEHBBJFCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79EA110", Offset = "0x79E9510", VA = "0x1879EA110")]
	public static void GFDFDHMHGGA(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79E9EB0", Offset = "0x79E92B0", VA = "0x1879E9EB0")]
	public static void CIEDCJNPNEC(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3600790", Offset = "0x35FFB90", VA = "0x183600790")]
	public static void CIEDCJNPNEC<T>(T HBNMBAEKPFF, FLHLGOHBCJP<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79EA1E0", Offset = "0x79E95E0", VA = "0x1879EA1E0")]
	public static void ILKEALIOPDP(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79E9E30", Offset = "0x79E9230", VA = "0x1879E9E30")]
	public static void BGIGJFNDACH(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79EA280", Offset = "0x79E9680", VA = "0x1879EA280")]
	public static void KALAAOPMCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79EA2F0", Offset = "0x79E96F0", VA = "0x1879EA2F0")]
	public static string LCHIBOGNELL(object BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79E9F80", Offset = "0x79E9380", VA = "0x1879E9F80")]
	public static long DKFOOMPJPNO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x79EA3D0", Offset = "0x79E97D0", VA = "0x1879EA3D0")]
	public static bool MLMFGGGPBJA(bool LNDKBMLMEBB, string DAMFJFKKFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79EA040", Offset = "0x79E9440", VA = "0x1879EA040")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E7BE0", Offset = "0x79E6FE0", VA = "0x1879E7BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79E8570", Offset = "0x79E7970", VA = "0x1879E8570")]
	public DGGKKNHLAMP([In] LAAPMGPPMJD LKAKLKDLNCG, [In] ANPGLNMFLIK AGBGFLMAHIF, GNHDDKLDLAN HEJOFDJCICO, OJICBOCPDMM PLBAJOJNJJK, MAHJOLNOFEN GGEKLOBJFLP, HIACCFEGOLP MNFDDNHFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x79E7D70", Offset = "0x79E7170", VA = "0x1879E7D70")]
	private static string IIPMAPKINNI(object BLFGIKOAKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x9ACAA0", Offset = "0x9ABEA0", VA = "0x1809ACAA0")]
	private static long NKBMIJHHEJI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	private static string ENOOBBJJCLP(string IPAAOHHFILB, string? EEDLEGPLAKK, bool FKDOLJNPNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	private static bool DEEFMPBMOKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x79E7DB0", Offset = "0x79E71B0", VA = "0x1879E7DB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x42EC570", Offset = "0x42EB970", VA = "0x1842EC570")]
	public EMNKDMBIHLH([In] T FFOEEMKIKJO, int CJFNAFNJJLB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x42EB810", Offset = "0x42EAC10", VA = "0x1842EB810")]
	public static bool PEOCKCCHEIN([In] EMNKDMBIHLH<T> KGCKEJLFPJB, [In] EMNKDMBIHLH<T> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x42EA3B0", Offset = "0x42E97B0", VA = "0x1842EA3B0", Slot = "4")]
	public bool Equals(EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x42E1E60", Offset = "0x42E1260", VA = "0x1842E1E60", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42EA320", Offset = "0x42E9720", VA = "0x1842EA320")]
	public bool EHKHGLACPFM([In] EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x42EA5D0", Offset = "0x42E99D0", VA = "0x1842EA5D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42EC380", Offset = "0x42EB780", VA = "0x1842EC380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42EAD20", Offset = "0x42EA120", VA = "0x1842EAD20")]
	public void LKJBGMAPBIG([Out] T FFOEEMKIKJO, [Out] int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x42EB380", Offset = "0x42EA780", VA = "0x1842EB380")]
	public (T, int) OFPCAFDFKPJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42EA4D0", Offset = "0x42E98D0", VA = "0x1842EA4D0", Slot = "5")]
	private bool FHHHEIMKKBJ([In] EMNKDMBIHLH<T> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JFALEPNFOBM
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3685E90", Offset = "0x3685290", VA = "0x183685E90")]
	public static EMNKDMBIHLH<T> HBLBJMFGHFK<T>([In] T FFOEEMKIKJO, int CJFNAFNJJLB) where T : notnull
	{
		return default(EMNKDMBIHLH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LEKMFMCNMPB
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x36EED10", Offset = "0x36EE110", VA = "0x1836EED10")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EB5E0", Offset = "0x79EA9E0", VA = "0x1879EB5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xCB91E0", Offset = "0xCB85E0", VA = "0x180CB91E0")]
	public LAAPMGPPMJD(EIOEKGLNLIJ KGFGALBBDPI, GGJECCFMMDK EIDCIBCOMOP, EIOEKGLNLIJ GPCPBHHMBCL, GGJECCFMMDK ACPFACJOCNM, EIOEKGLNLIJ CKFGNOMBBFN, GGJECCFMMDK GGOGADLDDEB, PJHEJFHGANP ICEKCAINALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	private static bool KHBMBPNKKKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void FAPMOGFEHNL(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	private static bool NHDNCGFFJKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void OLIALOPAFMG(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
	private static bool JJABKFDFHIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void KENGOOGGMKP(string DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void INJIEOMJLBF(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x79EB830", Offset = "0x79EAC30", VA = "0x1879EB830")]
	private static LAAPMGPPMJD JOIDBKAHEAN()
	{
		return default(LAAPMGPPMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
	private static bool MGGHIMJLHIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x79EB7C0", Offset = "0x79EABC0", VA = "0x1879EB7C0")]
	public void GFDFDHMHGGA(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x79EBA40", Offset = "0x79EAE40", VA = "0x1879EBA40")]
	public void PADHHMMINIJ(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x79EB490", Offset = "0x79EA890", VA = "0x1879EB490")]
	public void CIEDCJNPNEC(object DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCAFF40", Offset = "0xCAF340", VA = "0x180CAFF40")]
	public void ILKEALIOPDP(Exception BLCFGIAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79EB500", Offset = "0x79EA900", VA = "0x1879EB500")]
	public void CIEDCJNPNEC(HMDDOKPCFHD DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36EDA80", Offset = "0x36ECE80", VA = "0x1836EDA80")]
	public void CIEDCJNPNEC<T>(T HBNMBAEKPFF, FLHLGOHBCJP<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36EDB50", Offset = "0x36ECF50", VA = "0x1836EDB50")]
	public void GFDFDHMHGGA<T>([In] T HBNMBAEKPFF, LJIHKPHOJHL<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36ED810", Offset = "0x36ECC10", VA = "0x1836ED810")]
	public void CIEDCJNPNEC<T>([In] T HBNMBAEKPFF, LJIHKPHOJHL<T> DAMFJFKKFBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x79EB970", Offset = "0x79EAD70", VA = "0x1879EB970")]
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
	[Cpp2IlInjected.Address(RVA = "0xC747D0", Offset = "0xC73BD0", VA = "0x180C747D0")]
	public FNONIIDNHKM(string FFOEEMKIKJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0")]
	public static string CLMIANKGGAM([In] FNONIIDNHKM JOCJBPPJMJJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2179AF0", Offset = "0x2178EF0", VA = "0x182179AF0")]
	public static FNONIIDNHKM CLMIANKGGAM(string KNCKFHOKGJM)
	{
		return default(FNONIIDNHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79E98F0", Offset = "0x79E8CF0", VA = "0x1879E98F0")]
	public string AECMHBOBEAO(string PELAGPNMFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x79E9940", Offset = "0x79E8D40", VA = "0x1879E9940")]
	public string NJELCHJAPDI(object OPIBNPLCMNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
	public KOHECBFFINE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct LPCAMBCOBBH : IEquatable<LPCAMBCOBBH>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "4")]
	public bool Equals(LPCAMBCOBBH KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79EC710", Offset = "0x79EBB10", VA = "0x1879EC710", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x79EC760", Offset = "0x79EBB60", VA = "0x1879EC760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x79EC770", Offset = "0x79EBB70", VA = "0x1879EC770", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x5111070", Offset = "0x5110470", VA = "0x185111070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5112060", Offset = "0x5111460", VA = "0x185112060")]
	public NPOJFHOGAHB([In] T FFOEEMKIKJO, bool LMLKBFEHCMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51112D0", Offset = "0x51106D0", VA = "0x1851112D0")]
	public static bool PEOCKCCHEIN([In] NPOJFHOGAHB<T> KGCKEJLFPJB, [In] NPOJFHOGAHB<T> HKELKGIPNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x510FEB0", Offset = "0x510F2B0", VA = "0x18510FEB0", Slot = "4")]
	public bool Equals(NPOJFHOGAHB<T> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51105A0", Offset = "0x510F9A0", VA = "0x1851105A0", Slot = "0")]
	public override bool Equals(object? KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5110A30", Offset = "0x510FE30", VA = "0x185110A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5111C30", Offset = "0x5111030", VA = "0x185111C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FINHBCLIBNM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x35D53A0", Offset = "0x35D47A0", VA = "0x1835D53A0")]
	public static NPOJFHOGAHB<T> GHLIHICBODC<T>([In] T FFOEEMKIKJO) where T : notnull
	{
		return default(NPOJFHOGAHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x35D55A0", Offset = "0x35D49A0", VA = "0x1835D55A0")]
	public static NPOJFHOGAHB<T?> NFMBBBIJCEI<T>()
	{
		return default(NPOJFHOGAHB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x35D5250", Offset = "0x35D4650", VA = "0x1835D5250")]
	public static bool DCKDEFGFKNG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, [Out][NotNullWhen(true)] T FFOEEMKIKJO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x35D5210", Offset = "0x35D4610", VA = "0x1835D5210")]
	public static bool DCKDEFGFKNG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, [Out][NotNullWhen(true)] T FFOEEMKIKJO, [Out] NPOJFHOGAHB<T> LMBIAMNEEOB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x35D5280", Offset = "0x35D4680", VA = "0x1835D5280")]
	public static T? GBBPDPCPIPG<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, T? PFCPDJEHNAP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x35D50E0", Offset = "0x35D44E0", VA = "0x1835D50E0")]
	public static bool BAMDOIHHMCB<T>([In] this NPOJFHOGAHB<T> IPOJMNNFOGL, T FFOEEMKIKJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NLFBPFAKCBN
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37D84D0", Offset = "0x37D78D0", VA = "0x1837D84D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E3380", Offset = "0x79E2780", VA = "0x1879E3380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3C6B0", VA = "0x180A3D2B0")]
	public ANPGLNMFLIK(IntPtr PNCPANBBJNA, IntPtr FPCJJJBOFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void LCNGAJLBHEH(string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void KPJNELOCFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x79E3450", Offset = "0x79E2850", VA = "0x1879E3450")]
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
	[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0")]
	private HDPBFJCBNML(IntPtr FPCJJJBOFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x79EA800", Offset = "0x79E9C00", VA = "0x1879EA800")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x79EA720", Offset = "0x79E9B20", VA = "0x1879EA720")]
	public static HDPBFJCBNML HBLBJMFGHFK(string IGEPDAOOLBO)
	{
		return default(HDPBFJCBNML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x267C450", Offset = "0x267B850", VA = "0x18267C450")]
	public static HDPBFJCBNML HBLBJMFGHFK([In] ANPGLNMFLIK AGBGFLMAHIF, string IGEPDAOOLBO)
	{
		return default(HDPBFJCBNML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x267CBB0", Offset = "0x267BFB0", VA = "0x18267CBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
				[Cpp2IlInjected.Address(RVA = "0x79E9200", Offset = "0x79E8600", VA = "0x1879E9200", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x79E90B0", Offset = "0x79E84B0", VA = "0x1879E90B0", Slot = "6")]
			public void OnCompleted(Action KLINOMADKJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			public void OFKHKGDALIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public EMMIODKDPGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly BMKKJIFPEEN DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		private BMKKJIFPEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x79E3E70", Offset = "0x79E3270", VA = "0x1879E3E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x79EAC80", Offset = "0x79EA080", VA = "0x1879EAC80", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x79EAC30", Offset = "0x79EA030", VA = "0x1879EAC30", Slot = "6")]
			public void OnCompleted(Action KLINOMADKJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			public void OFKHKGDALIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public IFMPMCEJMJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly OIDHIIKPDOE DNEPPKLGBFA;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		private OIDHIIKPDOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79ECD90", Offset = "0x79EC190", VA = "0x1879ECD90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public FFBOBHLIGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x471FE00", Offset = "0x471F200", VA = "0x18471FE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CIPJJEPAKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4847F40", Offset = "0x4847340", VA = "0x184847F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E92D0", Offset = "0x79E86D0", VA = "0x1879E92D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EA8E0", Offset = "0x79E9CE0", VA = "0x1879EA8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F24DE0", Offset = "0x5F241E0", VA = "0x185F24DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5F24F50", Offset = "0x5F24350", VA = "0x185F24F50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x42ECA20", Offset = "0x42EBE20", VA = "0x1842ECA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x42ECE50", Offset = "0x42EC250", VA = "0x1842ECE50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79ECE50", Offset = "0x79EC250", VA = "0x1879ECE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x79ED060", Offset = "0x79EC460", VA = "0x1879ED060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public HKAKMHAIAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x471FE00", Offset = "0x471F200", VA = "0x18471FE00")]
		internal void KIOGOPLHLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x491C590", Offset = "0x491B990", VA = "0x18491C590")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DA5620", Offset = "0x4DA4A20", VA = "0x184DA5620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5D30", Offset = "0x4DA5130", VA = "0x184DA5D30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E3620", Offset = "0x79E2A20", VA = "0x1879E3620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x79E3E10", Offset = "0x79E3210", VA = "0x1879E3E10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EC170", Offset = "0x79EB570", VA = "0x1879EC170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x79EC6B0", Offset = "0x79EBAB0", VA = "0x1879EC6B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5356840", Offset = "0x5355C40", VA = "0x185356840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x428A490", Offset = "0x4289890", VA = "0x18428A490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DHCDKFKEOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x79E8620", Offset = "0x79E7A20", VA = "0x1879E8620")]
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
		[Cpp2IlInjected.Address(RVA = "0x535B440", Offset = "0x535A840", VA = "0x18535B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3E94530", Offset = "0x3E93930", VA = "0x183E94530", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A1BE30", Offset = "0x4A1B230", VA = "0x184A1BE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4A1CD30", Offset = "0x4A1C130", VA = "0x184A1CD30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EA9F0", Offset = "0x79E9DF0", VA = "0x1879EA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x79EABD0", Offset = "0x79E9FD0", VA = "0x1879EABD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E2120", Offset = "0x79E1520", VA = "0x1879E2120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x79E2480", Offset = "0x79E1880", VA = "0x1879E2480", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EC8A0", Offset = "0x79EBCA0", VA = "0x1879EC8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x79ECB90", Offset = "0x79EBF90", VA = "0x1879ECB90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IJFOAGFHGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x79EAD10", Offset = "0x79EA110", VA = "0x1879EAD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E9630", Offset = "0x79E8A30", VA = "0x1879E9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x79E9890", Offset = "0x79E8C90", VA = "0x1879E9890", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E44F0", Offset = "0x79E38F0", VA = "0x1879E44F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x79E46D0", Offset = "0x79E3AD0", VA = "0x1879E46D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E9A20", Offset = "0x79E8E20", VA = "0x1879E9A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x79E9D80", Offset = "0x79E9180", VA = "0x1879E9D80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79ED130", Offset = "0x79EC530", VA = "0x1879ED130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x79ED420", Offset = "0x79EC820", VA = "0x1879ED420", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DICKHBLADBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x79E8730", Offset = "0x79E7B30", VA = "0x1879E8730")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E8DF0", Offset = "0x79E81F0", VA = "0x1879E8DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x79E9050", Offset = "0x79E8450", VA = "0x1879E9050", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EAF20", Offset = "0x79EA320", VA = "0x1879EAF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x79EB0A0", Offset = "0x79EA4A0", VA = "0x1879EB0A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E3B0C0", Offset = "0x4E3A4C0", VA = "0x184E3B0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B320", Offset = "0x4E3A720", VA = "0x184E3B320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EB100", Offset = "0x79EA500", VA = "0x1879EB100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x79EB430", Offset = "0x79EA830", VA = "0x1879EB430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E5C90", Offset = "0x79E5090", VA = "0x1879E5C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79E7070", Offset = "0x79E6470", VA = "0x1879E7070")]
	public static bool OPOOEKLOOGK(this Task NHNFPALEEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3406D00", Offset = "0x3406100", VA = "0x183406D00")]
	public static Task<T> NKLPPIFMAEJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x79E6790", Offset = "0x79E5B90", VA = "0x1879E6790")]
	public static Task MIMDGFPLJBO(this Task NHNFPALEEPM, CancellationToken HHGPJKKLNIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3405400", Offset = "0x3404800", VA = "0x183405400")]
	public static Task<TResult> MIMDGFPLJBO<TResult>(this Task<TResult> NHNFPALEEPM, CancellationToken HHGPJKKLNIG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3406370", Offset = "0x3405770", VA = "0x183406370")]
	public static TaskCompletionSource<TResult> MIMDGFPLJBO<TResult>(this TaskCompletionSource<TResult> BBMIIIIDLPN, CancellationToken HHGPJKKLNIG) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x79E6530", Offset = "0x79E5930", VA = "0x1879E6530")]
	public static IDisposable? LIKGIDICEJC(CancellationToken OIFGOIJPJJF, CancellationToken AHIPNAHFCKO, [Out] CancellationToken IPKNOIPJJCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x79E55D0", Offset = "0x79E49D0", VA = "0x1879E55D0")]
	[AsyncStateMachine(typeof(EPFBFHEAGLC))]
	public static void DDPHDFIOPJG(this Task OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x79E59E0", Offset = "0x79E4DE0", VA = "0x1879E59E0")]
	[AsyncStateMachine(typeof(IBABEAEDBMC))]
	public static void DGAOJCFJAID(this Task OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3406E80", Offset = "0x3406280", VA = "0x183406E80")]
	[AsyncStateMachine(typeof(BHOPIGBEFHE<>))]
	public static Task PNDEPDFIKEK<TException>(this Task OOLNPDLPIEB) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3402140", Offset = "0x3401540", VA = "0x183402140")]
	[AsyncStateMachine(typeof(EMOHAFPGEGO<>))]
	public static Task<T> CPDJLGOBCGB<T>(this Task<T> JOCJBPPJMJJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x79E54E0", Offset = "0x79E48E0", VA = "0x1879E54E0")]
	[AsyncStateMachine(typeof(OJACDADEIEJ))]
	public static Task<TaskStatus> CPMIONBLFOB(this Task? JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3402890", Offset = "0x3401C90", VA = "0x183402890")]
	public static (Task<T?>?, Action<T?>?) MAOOBHDIIKH<T>([Optional] CancellationToken LMNHDKIFBOH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3401D50", Offset = "0x3401150", VA = "0x183401D50")]
	[AsyncStateMachine(typeof(KLIMLPLJPKF<, >))]
	public static Task<List<TResult>> BOMCAFIAKBI<TResult, TInput>(this Task<List<TInput>> NHNFPALEEPM, HAJDLBIMCOH<TInput, TResult> AKOAOGNBOGF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79E5D00", Offset = "0x79E5100", VA = "0x1879E5D00")]
	[AsyncStateMachine(typeof(BLHDLNCKPPG))]
	public static Task FEDJJGNOBAO(Task OOLNPDLPIEB, CancellationToken BOHHBCNKHLK, Func<CancellationToken, Task> MPOKLJCJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x79E6040", Offset = "0x79E5440", VA = "0x1879E6040")]
	[AsyncStateMachine(typeof(LJHNKFEMGCN))]
	public static Task IGPODLIKIFB(Func<CancellationToken, Task> IJBCOFDMABE, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken BOHHBCNKHLK, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3402410", Offset = "0x3401810", VA = "0x183402410")]
	[AsyncStateMachine(typeof(PMKGFMJDBDC<>))]
	public static Task<T> IGPODLIKIFB<T>(Func<CancellationToken, Task<T>> IJBCOFDMABE, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken BOHHBCNKHLK, [Optional] Func<OperationCanceledException, T>? NMNCODLGAAL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x79E6B60", Offset = "0x79E5F60", VA = "0x1879E6B60")]
	public static Task OKHMPPCNOCD(params Task[] BHJKIFMNNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x79E6BB0", Offset = "0x79E5FB0", VA = "0x1879E6BB0")]
	public static Task OKHMPPCNOCD(IEnumerable<Task> BHJKIFMNNKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34027A0", Offset = "0x3401BA0", VA = "0x1834027A0")]
	[AsyncStateMachine(typeof(PPNDCLKMOID<>))]
	public static Task<IEnumerable<Task<T>>> JBCJONEPAJB<T>(IEnumerable<Task<T>> BHJKIFMNNKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3401E60", Offset = "0x3401260", VA = "0x183401E60")]
	[AsyncStateMachine(typeof(IJPIOHBOOPF<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> CKNEDHHPBHL<T1, T2, T3, T4, T5>(Task<T1> NGNAGNMICOJ, Task<T2> OHHMIELAKND, Task<T3> IAIAAPPLALC, Task<T4> KCHHLKKALPL, Task<T5> GGGCLHOEDDO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x79E5A90", Offset = "0x79E4E90", VA = "0x1879E5A90")]
	[AsyncStateMachine(typeof(IDGEGFLCPLF))]
	public static Task DJICGCLEACM(Func<bool> LNDKBMLMEBB, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79E5B80", Offset = "0x79E4F80", VA = "0x1879E5B80")]
	[AsyncStateMachine(typeof(AIKEBCPCAAN))]
	public static Task DJICGCLEACM(Func<bool> LNDKBMLMEBB, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79E5270", Offset = "0x79E4670", VA = "0x1879E5270")]
	[AsyncStateMachine(typeof(MMPDNBOHJND))]
	public static Task BLPFDCPCLOH(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79E53A0", Offset = "0x79E47A0", VA = "0x1879E53A0")]
	[AsyncStateMachine(typeof(FIAAAJLOHID))]
	public static Task BLPFDCPCLOH(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x79E6220", Offset = "0x79E5620", VA = "0x1879E6220")]
	[AsyncStateMachine(typeof(CBIOBCGNIIK))]
	public static Task LBJLBEDDCFL(Func<bool> LNDKBMLMEBB, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x79E6310", Offset = "0x79E5710", VA = "0x1879E6310")]
	[AsyncStateMachine(typeof(GOEFKNPPIKM))]
	public static Task LBJLBEDDCFL(Func<bool> LNDKBMLMEBB, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x79E5140", Offset = "0x79E4540", VA = "0x1879E5140")]
	[AsyncStateMachine(typeof(OOHMPCOOFCB))]
	public static Task BDGILFAJFCK(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x79E5000", Offset = "0x79E4400", VA = "0x1879E5000")]
	[AsyncStateMachine(typeof(EJOPAPBNAJA))]
	public static Task BDGILFAJFCK(Func<bool> LNDKBMLMEBB, TimeSpan ADEFLDLMJBI, TimeSpan EKIPHOLMFII, [Optional] CancellationToken LMNHDKIFBOH, [Optional] Action<OperationCanceledException>? NMNCODLGAAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79E5F50", Offset = "0x79E5350", VA = "0x1879E5F50")]
	[Obsolete]
	[AsyncStateMachine(typeof(KIGJGPKAKDK))]
	public static Task IENKHJLJPBM(this Task NHNFPALEEPM, Action JDHGNBFHADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3402320", Offset = "0x3401720", VA = "0x183402320")]
	[Obsolete]
	[AsyncStateMachine(typeof(LADMOBKGOHA<>))]
	public static Task IENKHJLJPBM<T>(this Task<T> NHNFPALEEPM, Action<T> JDHGNBFHADN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79E6170", Offset = "0x79E5570", VA = "0x1879E6170")]
	private static void KMNDLNIDFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x79E5680", Offset = "0x79E4A80", VA = "0x1879E5680")]
	public static bool DEAGOJPMOLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x79E69E0", Offset = "0x79E5DE0", VA = "0x1879E69E0")]
	private static void OAONEBCAHMB(SynchronizationContext FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x79E6420", Offset = "0x79E5820", VA = "0x1879E6420")]
	private static void LCPKMPPCAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x79E4F30", Offset = "0x79E4330", VA = "0x1879E4F30")]
	public static void BBAKMJLDMGL([Optional] string? DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x79E5ED0", Offset = "0x79E52D0", VA = "0x1879E5ED0")]
	public static void GBFFDCHOMAN([Optional] string? DAMFJFKKFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x79E5E80", Offset = "0x79E5280", VA = "0x1879E5E80")]
	public static NJJDJCFEJJN FPIKOHDMPFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x79E5E30", Offset = "0x79E5230", VA = "0x1879E5E30")]
	public static NJJDJCFEJJN FMGFGBBPFJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x79E66C0", Offset = "0x79E5AC0", VA = "0x1879E66C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EC060", Offset = "0x79EB460", VA = "0x1879EC060", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset OAKGJNOCDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x79EC0A0", Offset = "0x79EB4A0", VA = "0x1879EC0A0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4BF0", Offset = "0x79E3FF0", VA = "0x1879E4BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4B10", Offset = "0x79E3F10", VA = "0x1879E4B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4970", Offset = "0x79E3D70", VA = "0x1879E4970")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4C40", Offset = "0x79E4040", VA = "0x1879E4C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4800", Offset = "0x79E3C00", VA = "0x1879E4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E4A60", Offset = "0x79E3E60", VA = "0x1879E4A60")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x79E4B60", Offset = "0x79E3F60", VA = "0x1879E4B60")]
	public static double MMPJAMJPPLE(long MGGFKFDDLIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x79E48E0", Offset = "0x79E3CE0", VA = "0x1879E48E0")]
	public static double DLKMJOJMPJO(long MGGFKFDDLIF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79E49D0", Offset = "0x79E3DD0", VA = "0x1879E49D0")]
	public static double HCOBAHDBOMB(double EPLAJLCGKKF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x79E4850", Offset = "0x79E3C50", VA = "0x1879E4850")]
	public static long CKHDGKGOHOE(long PCFGHPNONAI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x79E49C0", Offset = "0x79E3DC0", VA = "0x1879E49C0")]
	public static long GHHKDJABHFH(long ACLAAMEOOPB, long OOAJPLNCGNB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x79E4730", Offset = "0x79E3B30", VA = "0x1879E4730")]
	public static double CDFALOKIBBI(long ACLAAMEOOPB, long OOAJPLNCGNB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x79E4AB0", Offset = "0x79E3EB0", VA = "0x1879E4AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x79ED980", Offset = "0x79ECD80", VA = "0x1879ED980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? DFNANGIENAN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x79EDE10", Offset = "0x79ED210", VA = "0x1879EDE10")]
	[Preserve]
	public PHLMONLMJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x79EDBC0", Offset = "0x79ECFC0", VA = "0x1879EDBC0")]
	public PHLMONLMJGG(TimeSpan ADEFLDLMJBI, [Optional] Action? HFEDDDBOMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x79ED830", Offset = "0x79ECC30", VA = "0x1879ED830", Slot = "7")]
	public void FMCLIDDFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79EDAE0", Offset = "0x79ECEE0", VA = "0x1879EDAE0", Slot = "8")]
	public void MBLPGJJGIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x79ED8C0", Offset = "0x79ECCC0", VA = "0x1879ED8C0", Slot = "9")]
	public void KGANBNOPCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x104DED0", Offset = "0x104D2D0", VA = "0x18104DED0")]
	private void CCAGHBILIBK(object FKPHPPGPLLD, ElapsedEventArgs OFEFIEHPEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x79ED8F0", Offset = "0x79ECCF0", VA = "0x1879ED8F0")]
	private static void KHBACOPMPMC(TimeSpan HEIAKNJACAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x79ED790", Offset = "0x79ECB90", VA = "0x1879ED790", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x73516B0", Offset = "0x7350AB0", VA = "0x1873516B0")]
	public DGBLOAGKOKD(string ONJHPHOODPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4A04850", Offset = "0x4A03C50", VA = "0x184A04850")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D45E10", Offset = "0x1D45210", VA = "0x181D45E10")]
	public static AKBOPDOBDEE PMGAMFEKDIM(uint CNMOFLBBPDL)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1D45E10", Offset = "0x1D45210", VA = "0x181D45E10")]
	public static AKBOPDOBDEE GGNANFDPEDC(int DJLIDNFCFDD)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x79E2580", Offset = "0x79E1980", VA = "0x1879E2580")]
	public static AKBOPDOBDEE LMNFGAKPMJG(float LHADKEGPLLL)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x79E24E0", Offset = "0x79E18E0", VA = "0x1879E24E0")]
	public static AKBOPDOBDEE NHHHPPLAIMC(byte KPCONMLKGOI, byte NFKHCNNDAKC, byte OEEDABJCECL, byte BCOAIDIJCGH)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x79E24E0", Offset = "0x79E18E0", VA = "0x1879E24E0")]
	public static AKBOPDOBDEE PEIBGEIPJFH(bool GHOPFNLOBOM, bool NIFDMAOIHLP, bool GIGNKIEJGCL, bool LKHMFILCMOA)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x79E24E0", Offset = "0x79E18E0", VA = "0x1879E24E0")]
	public static AKBOPDOBDEE DOPNHGJANFP(byte EKMLAOFMMBB, byte CLJDLIFBMKM, byte GMLDCKFHLEM, byte JAEDPENADAM)
	{
		return default(AKBOPDOBDEE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2036D70", Offset = "0x2036170", VA = "0x182036D70")]
	public static bool PEOCKCCHEIN(AKBOPDOBDEE BICHNBDCKLH, AKBOPDOBDEE CKCKMBIGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2036D50", Offset = "0x2036150", VA = "0x182036D50", Slot = "4")]
	public bool Equals(AKBOPDOBDEE KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x79E2500", Offset = "0x79E1900", VA = "0x1879E2500", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x11D76A0", Offset = "0x11D6AA0", VA = "0x1811D76A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x79E2590", Offset = "0x79E1990", VA = "0x1879E2590", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static HOOEOPFHBCL HBLBJMFGHFK(long ENMIKPFDHIK)
	{
		return default(HOOEOPFHBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79EA890", Offset = "0x79E9C90", VA = "0x1879EA890")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CCAD90", Offset = "0x2CCA190", VA = "0x182CCAD90")]
	public static PFKEJJALNEF NHHHPPLAIMC(byte MBLPLEHAOKA)
	{
		return default(PFKEJJALNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCAD90", Offset = "0x2CCA190", VA = "0x182CCAD90")]
	public static PFKEJJALNEF PEIBGEIPJFH(bool OAAFEPPONMI)
	{
		return default(PFKEJJALNEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x79ED520", Offset = "0x79EC920", VA = "0x1879ED520")]
	public static bool PEOCKCCHEIN(PFKEJJALNEF BICHNBDCKLH, PFKEJJALNEF CKCKMBIGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x69CA130", Offset = "0x69C9530", VA = "0x1869CA130", Slot = "4")]
	public bool Equals(PFKEJJALNEF KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x79ED480", Offset = "0x79EC880", VA = "0x1879ED480", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x79ED510", Offset = "0x79EC910", VA = "0x1879ED510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x79ED530", Offset = "0x79EC930", VA = "0x1879ED530", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C0CDA0", Offset = "0x4C0C1A0", VA = "0x184C0CDA0")]
	public JIGCOPPJMPF(T FNOEJJOGNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class OIOIHOCEBHL
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3655B80", Offset = "0x3654F80", VA = "0x183655B80")]
	public static IEnumerable<T> LBOIHFCCBEI<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static T[] KMKNGPIDICM<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static IEnumerable<T> DDNGGBGCCEA<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
	public static HashSet<T> JKLOPCBHIJN<T>(params T[] CICNBPPLJEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3809A50", Offset = "0x3808E50", VA = "0x183809A50")]
	public static KeyValuePair<TKey, TValue> GNNPMEAMFII<TKey, TValue>([In] TKey DJBLFBEBKGO, [In] TValue FFOEEMKIKJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3393FF0", Offset = "0x33933F0", VA = "0x183393FF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
	[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E7160", Offset = "0x79E6560", VA = "0x1879E7160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x79E7A50", Offset = "0x79E6E50", VA = "0x1879E7A50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x79E8960", Offset = "0x79E7D60", VA = "0x1879E8960")]
	public static Task<bool> PLIJGLLMAAN(int EBFEOAODHKK, [Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x79E8830", Offset = "0x79E7C30", VA = "0x1879E8830")]
	[AsyncStateMachine(typeof(DAFDFOMGCOB))]
	private static Task<bool> IDLNFBALANG(int EBFEOAODHKK, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x79E87A0", Offset = "0x79E7BA0", VA = "0x1879E87A0")]
	private static void HPMBAKNAKOF(object? DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x79E8C60", Offset = "0x79E8060", VA = "0x1879E8C60")]
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
