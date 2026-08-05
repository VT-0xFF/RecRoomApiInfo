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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8412220", Offset = "0x8411620", VA = "0x188412220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HAFDBMCLOEO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x840F250", Offset = "0x840E650", VA = "0x18840F250")]
	public static string PJCBHMFMFID(this Encoding MMNLHMCEEAG, [In] ReadOnlySequence<byte> FGHKEPJEKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCF60", Offset = "0x3CBC360", VA = "0x183CBCF60")]
	private static void EIHPLBHHEFP<T>(this ReadOnlySequence<T> GIAHDGILHGB, [Out] ReadOnlySpan<T> FGGIBAALDBL, [Out] SequencePosition GEGOFMKNEED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class EIAMKKEEJOK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x840D330", Offset = "0x840C730", VA = "0x18840D330")]
	public EIAMKKEEJOK(bool DCHPGKHFLGN, string MJLKMCBAOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x840D2E0", Offset = "0x840C6E0", VA = "0x18840D2E0")]
	public EIAMKKEEJOK(bool DCHPGKHFLGN, params string[] JNCBCNOKPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GCCKJBFECBM
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NEICEBPLEBA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EGDELCANAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNEMIDPDEDD(string PEENICAIFOP, double CBMEHPPMEEA, [Optional] string? LPDIMCGCLLC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HPPELJIPDNO : PPDHMCAAKHC, DBFBNNHABDB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DEDFLNPCCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> MKODHOJEFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double FELPICHHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double IDCCLFDFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double JMCGDEAELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EIFMAMIAKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double LDHLJGKDOCP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KBGDLEPPJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA8CC50", Offset = "0xA8C050", VA = "0x180A8CC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EKBHGPPFDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x840FBB0", Offset = "0x840EFB0", VA = "0x18840FBB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HFPFHNPJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57F1360", Offset = "0x57F0760", VA = "0x1857F1360", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double HCFMKONMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x29E9710", Offset = "0x29E8B10", VA = "0x1829E9710", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x840FD40", Offset = "0x840F140", VA = "0x18840FD40")]
	public HPPELJIPDNO(int ADEPCBHNPBJ, double LDHLJGKDOCP = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x840FC10", Offset = "0x840F010", VA = "0x18840FC10", Slot = "7")]
	public void JLPBGLLMLLM(double DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x840FA40", Offset = "0x840EE40", VA = "0x18840FA40", Slot = "8")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x840FAB0", Offset = "0x840EEB0", VA = "0x18840FAB0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NMFONCCDKDN : PPDHMCAAKHC, DBFBNNHABDB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long PPNAGMANAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double LACMIHMNKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double ACHDMABKOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double OJNJDDOLIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double MPIEMDFGPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double FELPICHHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double IDCCLFDFCEL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HFPFHNPJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75E8960", Offset = "0x75E7D60", VA = "0x1875E8960", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HCFMKONMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75E8E40", Offset = "0x75E8240", VA = "0x1875E8E40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HNMLNNEHKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75E8970", Offset = "0x75E7D70", VA = "0x1875E8970")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double EKBHGPPFDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x31ABB40", Offset = "0x31AAF40", VA = "0x1831ABB40", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8412100", Offset = "0x8411500", VA = "0x188412100", Slot = "10")]
	public virtual void JLPBGLLMLLM(double DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8412050", Offset = "0x8411450", VA = "0x188412050", Slot = "11")]
	public virtual void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8412090", Offset = "0x8411490", VA = "0x188412090", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84114F0", Offset = "0x84108F0", VA = "0x1884114F0")]
	public NMFONCCDKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MAMCHMNFFPB : NMFONCCDKDN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LAFAJJGICBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75E8940", Offset = "0x75E7D40", VA = "0x1875E8940")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75E8950", Offset = "0x75E7D50", VA = "0x1875E8950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84113C0", Offset = "0x84107C0", VA = "0x1884113C0", Slot = "10")]
	public override void JLPBGLLMLLM(double DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8411380", Offset = "0x8410780", VA = "0x188411380", Slot = "11")]
	public override void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84114F0", Offset = "0x84108F0", VA = "0x1884114F0")]
	public MAMCHMNFFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PPDHMCAAKHC : DBFBNNHABDB, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EKBHGPPFDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HFPFHNPJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double HCFMKONMMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PEEDHLLAPKD : DBFBNNHABDB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double EMMBKLPOKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double PPDJHBOMFFP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8413860", Offset = "0x8412C60", VA = "0x188413860")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70191F0", Offset = "0x70185F0", VA = "0x1870191F0", Slot = "4")]
	public void JLPBGLLMLLM(double DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8413800", Offset = "0x8412C00", VA = "0x188413800", Slot = "5")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8413810", Offset = "0x8412C10", VA = "0x188413810", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PEEDHLLAPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DBFBNNHABDB : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLPBGLLMLLM(double DIMKOEFIKCH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNFJEHEIBKG();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IFEGEALLAHC : DBFBNNHABDB, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double CBMEHPPMEEA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4A6E480", Offset = "0x4A6D880", VA = "0x184A6E480")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x57D8AE0", Offset = "0x57D7EE0", VA = "0x1857D8AE0", Slot = "4")]
	public void JLPBGLLMLLM(double DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x840FE10", Offset = "0x840F210", VA = "0x18840FE10", Slot = "5")]
	public void CNFJEHEIBKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x840FE20", Offset = "0x840F220", VA = "0x18840FE20", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IFEGEALLAHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OGIJMEPINHA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> NBKACKOPJIE(CancellationToken GMKBGHHNCDJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LAJIGPEEIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OGIJMEPINHA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NBKACKOPJIE taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x54E5E10", Offset = "0x54E5210", VA = "0x1854E5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x54E6D40", Offset = "0x54E6140", VA = "0x1854E6D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource HAGAAAKNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? DFHHLHEFOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? AFHNDAIELOL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x59CD110", Offset = "0x59CC510", VA = "0x1859CD110")]
	[AsyncStateMachine(typeof(OGIJMEPINHA<>.LAJIGPEEIFC))]
	public Task<TResult> GGLBDMNIGHN(NBKACKOPJIE EINMKGKBCPA, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x59CD0A0", Offset = "0x59CC4A0", VA = "0x1859CD0A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x59CD240", Offset = "0x59CC640", VA = "0x1859CD240")]
	public OGIJMEPINHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EAEJDENDJPC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> CPBMFNMKMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T JCMAOCOGHGO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x49AEC90", Offset = "0x49AE090", VA = "0x1849AEC90")]
	public EAEJDENDJPC([In] T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49ADA90", Offset = "0x49ACE90", VA = "0x1849ADA90", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x49AE3C0", Offset = "0x49AD7C0", VA = "0x1849AE3C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x49AEA00", Offset = "0x49ADE00", VA = "0x1849AEA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EMFHIEFPOJJ
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static EAEJDENDJPC<T> EJOLKNBPCJB<T>([In] T CBMEHPPMEEA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ANGBLAKEDDE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x840B6D0", Offset = "0x840AAD0", VA = "0x18840B6D0")]
	public static void FDEOEANDHGN(this CancellationTokenSource HAGAAAKNION, bool MNAPCIDJMCL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class FBJIMJNDDFF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public FBJIMJNDDFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class PNFIJEAKPLK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public PNFIJEAKPLK(string BCBFCGOPCEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MBEIBGBFLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0100", Offset = "0x3DDF500", VA = "0x183DE0100")]
	public static NFGIBMDCOOA OLDEPMBIIFB<T>()
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8411640", Offset = "0x8410A40", VA = "0x188411640")]
	public static NFGIBMDCOOA GLNFHECDPIA([CallerMemberName] string HDNPPEBJPAE = "")
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFE00", Offset = "0x3DDF200", VA = "0x183DDFE00")]
	public static NFGIBMDCOOA CFFGPEKOJKB<T>([CallerMemberName] string HDNPPEBJPAE = "") where T : notnull
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0080", Offset = "0x3DDF480", VA = "0x183DE0080")]
	public static NFGIBMDCOOA OLDEPMBIIFB<T>(this T PCKIEOGDDCF) where T : notnull
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFF30", Offset = "0x3DDF330", VA = "0x183DDFF30")]
	public static NFGIBMDCOOA GLNFHECDPIA<T>(this T PCKIEOGDDCF, [CallerMemberName] string HDNPPEBJPAE = "") where T : notnull
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DDFE90", Offset = "0x3DDF290", VA = "0x183DDFE90")]
	public static NFGIBMDCOOA CFFGPEKOJKB<T>(this T DMFKPMONDPO, [CallerMemberName] string HDNPPEBJPAE = "") where T : notnull
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8411520", Offset = "0x8410920", VA = "0x188411520")]
	public static NFGIBMDCOOA CFFGPEKOJKB(string COMDDGBEAFK, [CallerMemberName] string HDNPPEBJPAE = "")
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x84115A0", Offset = "0x84109A0", VA = "0x1884115A0")]
	public static string FLAGDIGOKCD(this object DMFKPMONDPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool AAHKDNLFLDF();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FBJIMJNDDFF]
public delegate long CDMOHOHHCHD();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class PNNGANFJGJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly PNNGANFJGJJ NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PNNGANFJGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BOKOLMALEOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static AOEELCMLLBE HAFEHMEDAAN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static AOEELCMLLBE BOLOOFMEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x840CD40", Offset = "0x840C140", VA = "0x18840CD40")]
		get
		{
			return default(AOEELCMLLBE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static FKBHHMKLPBN APLBDOCANDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x840CC20", Offset = "0x840C020", VA = "0x18840CC20")]
		get
		{
			return default(FKBHHMKLPBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static AELMFCBMNIP NDNPMJFOEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x840C7D0", Offset = "0x840BBD0", VA = "0x18840C7D0")]
		get
		{
			return default(AELMFCBMNIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool IMFABAHCDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x840CC70", Offset = "0x840C070", VA = "0x18840CC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x840CE30", Offset = "0x840C230", VA = "0x18840CE30")]
	public static void OCCJNGHOOLD([In] AOEELCMLLBE MLINFIPABCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x840CAB0", Offset = "0x840BEB0", VA = "0x18840CAB0")]
	public static void GJFBEGANDPI(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x840C8F0", Offset = "0x840BCF0", VA = "0x18840C8F0")]
	public static void DMPPDIEEMEF(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3A47C50", Offset = "0x3A47050", VA = "0x183A47C50")]
	public static void DMPPDIEEMEF<T>(T ALOONCIOJJM, LMNEGAGDIEO<T> AFDNIPHJHMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x840CD90", Offset = "0x840C190", VA = "0x18840CD90")]
	public static void MADDKIFMIGH(Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x840CCE0", Offset = "0x840C0E0", VA = "0x18840CCE0")]
	public static void JGDJOBDMLLA(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x840CFE0", Offset = "0x840C3E0", VA = "0x18840CFE0")]
	public static void PGKLMOKCIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x840CA30", Offset = "0x840BE30", VA = "0x18840CA30")]
	public static string FLAGDIGOKCD(object DEJGDIIDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x840C9C0", Offset = "0x840BDC0", VA = "0x18840C9C0")]
	public static long FHIBKEIMAIF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x840CB80", Offset = "0x840BF80", VA = "0x18840CB80")]
	public static bool GLMGLGJKPOH(bool BMOACCMKDNJ, string AFDNIPHJHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x840C820", Offset = "0x840BC20", VA = "0x18840C820")]
	public static double DDBLGNPNBJG()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct AOEELCMLLBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly FKBHHMKLPBN APLBDOCANDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly AELMFCBMNIP NDNPMJFOEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly HFLCJNLBEMM NMBEGHDLMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly CDMOHOHHCHD DPDGIFKFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly LEIAKADDLBK LKHKLIADIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly AAHKDNLFLDF HGGCDDKMLOF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly HFLCJNLBEMM PCJMEMBIIGK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly CDMOHOHHCHD COOOJJHLKKM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly LEIAKADDLBK MPIJNBMLJKE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly AAHKDNLFLDF DLAACIKLLOA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly AOEELCMLLBE BOBPMJBGCMC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x840B740", Offset = "0x840AB40", VA = "0x18840B740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x840C0D0", Offset = "0x840B4D0", VA = "0x18840C0D0")]
	public AOEELCMLLBE([In] FKBHHMKLPBN BPMOJENGMGB, [In] AELMFCBMNIP JOGPEFMKANJ, HFLCJNLBEMM IKIDEKAKMAP, CDMOHOHHCHD MNGCHALIGCA, LEIAKADDLBK OMDNMHKHAJN, AAHKDNLFLDF PPJMKCLCHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x840B700", Offset = "0x840AB00", VA = "0x18840B700")]
	private static string LILNFHFJFMF(object DEJGDIIDCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	private static long LFBNPGFCJHJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	private static string NGHEHLAGJFO(string BPHJBCALMCO, string? KOJGIHKIGBD, bool PPDDMOKIGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	private static bool JONPNNLJGHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x840B8E0", Offset = "0x840ACE0", VA = "0x18840B8E0")]
	private static AOEELCMLLBE OKGKJIFCJIG()
	{
		return default(AOEELCMLLBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EMLIIDLGJPE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBDBDMGOGMG JNHNNPMDNOI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CBDBDMGOGMG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool HBLLBEFBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLIPGIOCGJK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FFCNDHCLIDN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFNDGINANCF([In] T LHDOHAKINKP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void DIBBOKMEMIE<T>([In] T ALOONCIOJJM);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HHEMJJEFDOC<T> : IEquatable<HHEMJJEFDOC<T>>, FFCNDHCLIDN<HHEMJJEFDOC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T JCMAOCOGHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int JHGBNCFKBAP;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3021200", Offset = "0x3020600", VA = "0x183021200")]
	public HHEMJJEFDOC([In] T CBMEHPPMEEA, int NOEININIMIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4FC3220", Offset = "0x4FC2620", VA = "0x184FC3220")]
	public static bool ILMCFLMCOJH([In] HHEMJJEFDOC<T> JLJHECODIOL, [In] HHEMJJEFDOC<T> DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2880", Offset = "0x4FC1C80", VA = "0x184FC2880", Slot = "4")]
	public bool Equals(HHEMJJEFDOC<T> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4566F50", Offset = "0x4566350", VA = "0x184566F50", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2980", Offset = "0x4FC1D80", VA = "0x184FC2980")]
	public bool FFNDGINANCF([In] HHEMJJEFDOC<T> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2CE0", Offset = "0x4FC20E0", VA = "0x184FC2CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4FC3570", Offset = "0x4FC2970", VA = "0x184FC3570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2200", Offset = "0x4FC1600", VA = "0x184FC2200")]
	public void BBBPACNHLNO([Out] T CBMEHPPMEEA, [Out] int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4FC24D0", Offset = "0x4FC18D0", VA = "0x184FC24D0")]
	public (T, int) BIIHFMGKAOJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2F60", Offset = "0x4FC2360", VA = "0x184FC2F60", Slot = "5")]
	private bool HEJCBGFIHON([In] HHEMJJEFDOC<T> LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MJDFCGMPBHP
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0AD0", Offset = "0x3DEFED0", VA = "0x183DF0AD0")]
	public static HHEMJJEFDOC<T> EJOLKNBPCJB<T>([In] T CBMEHPPMEEA, int NOEININIMIL) where T : notnull
	{
		return default(HHEMJJEFDOC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EOKCPJDCNHA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B43280", Offset = "0x3B42680", VA = "0x183B43280")]
	public static bool FFNDGINANCF<T, U>([In] T DMFKPMONDPO, [In] U DEJGDIIDCDN) where T : notnull, FFCNDHCLIDN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult KPDIDCLHEDJ<T, out TResult>([In] T ALOONCIOJJM);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MCLAMGMMGNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan DBDPOFGNANA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? JGNNGHLLEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCIEBGDAIDM();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDJOKIJANJM();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODFHFAFBGGG();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FKBHHMKLPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly APMMPIEKGGG IEKPDLGEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IDPPFCNEING EBFGOGODFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly APMMPIEKGGG LGIPLJHIFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IDPPFCNEING GCPAPBKALIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly APMMPIEKGGG KDKHDCNLBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IDPPFCNEING DJAIGDLCLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly CKCGPEDIADC KJIJPNJALGN;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly APMMPIEKGGG LOHCCJGDBAF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IDPPFCNEING GOKNNJIDBPL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly APMMPIEKGGG IEDPKCMPFLK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IDPPFCNEING OLIMBAMIGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly APMMPIEKGGG LCDPMOLIDDM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly IDPPFCNEING OCCBEGOMLBE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly CKCGPEDIADC BPBMBHGCLEO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly FKBHHMKLPBN BOBPMJBGCMC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly APMMPIEKGGG OJEJPJPCJLF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x840DEE0", Offset = "0x840D2E0", VA = "0x18840DEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xEAA840", Offset = "0xEA9C40", VA = "0x180EAA840")]
	public FKBHHMKLPBN(APMMPIEKGGG MCEIAIFKFBM, IDPPFCNEING JLGCFLNPHPO, APMMPIEKGGG KMOJIPKGPCI, IDPPFCNEING PGGAFEHMBNK, APMMPIEKGGG LKMEACDOGNP, IDPPFCNEING DLIKHAAFGMJ, CKCGPEDIADC KLCNBADHGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	private static bool MFBHFJGPAGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void OOEELEEDBPL(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	private static bool AMDMDEKAEHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void PHMCCLECFNG(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	private static bool ELNKNGMAIHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void ACCKNIPMHDH(string AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void PHBKJANOEOA(Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x840E0E0", Offset = "0x840D4E0", VA = "0x18840E0E0")]
	private static FKBHHMKLPBN OKGKJIFCJIG()
	{
		return default(FKBHHMKLPBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690")]
	private static bool BMEJGIBNPPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x840DD30", Offset = "0x840D130", VA = "0x18840DD30")]
	public void GJFBEGANDPI(object AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x840DE70", Offset = "0x840D270", VA = "0x18840DE70")]
	public void HGKGDIHLCIP(object AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x840DCC0", Offset = "0x840D0C0", VA = "0x18840DCC0")]
	public void DMPPDIEEMEF(object AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xEA0DF0", Offset = "0xEA01F0", VA = "0x180EA0DF0")]
	public void MADDKIFMIGH(Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x840DBE0", Offset = "0x840CFE0", VA = "0x18840DBE0")]
	public void DMPPDIEEMEF(FFLGGJFPFJC AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ED40", Offset = "0x3C9E140", VA = "0x183C9ED40")]
	public void DMPPDIEEMEF<T>(T ALOONCIOJJM, LMNEGAGDIEO<T> AFDNIPHJHMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F050", Offset = "0x3C9E450", VA = "0x183C9F050")]
	public void GJFBEGANDPI<T>([In] T ALOONCIOJJM, CFOLAJGKKPC<T> AFDNIPHJHMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EE10", Offset = "0x3C9E210", VA = "0x183C9EE10")]
	public void DMPPDIEEMEF<T>([In] T ALOONCIOJJM, CFOLAJGKKPC<T> AFDNIPHJHMO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x840DDA0", Offset = "0x840D1A0", VA = "0x18840DDA0")]
	public bool GLMGLGJKPOH(bool BMOACCMKDNJ, string AFDNIPHJHMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NFGIBMDCOOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string JCMAOCOGHGO;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	public NFGIBMDCOOA(string CBMEHPPMEEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
	public static string GKKMDDPCKIG([In] NFGIBMDCOOA DMFKPMONDPO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x143BC50", Offset = "0x143B050", VA = "0x18143BC50")]
	public static NFGIBMDCOOA GKKMDDPCKIG(string LHDOHAKINKP)
	{
		return default(NFGIBMDCOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8411780", Offset = "0x8410B80", VA = "0x188411780")]
	public string PGBGNMHAHNM(string FHEMIGFOAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84116A0", Offset = "0x8410AA0", VA = "0x1884116A0")]
	public string BJCIMGOJGBH(object GILAAHLNHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class HKCHEMHNCJH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public HKCHEMHNCJH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct EPILOLMBDMK : IEquatable<EPILOLMBDMK>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
	public bool Equals(EPILOLMBDMK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x840DB50", Offset = "0x840CF50", VA = "0x18840DB50", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x840DBA0", Offset = "0x840CFA0", VA = "0x18840DBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x840DBB0", Offset = "0x840CFB0", VA = "0x18840DBB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NLHJBHMDBCC("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DPGCDKOEDPO<T> : IEquatable<DPGCDKOEDPO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T JCMAOCOGHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool DINDCFOGNGN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NGEOPOHJBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4566DB0", Offset = "0x45661B0", VA = "0x184566DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x45690B0", Offset = "0x45684B0", VA = "0x1845690B0")]
	public DPGCDKOEDPO([In] T CBMEHPPMEEA, bool FFOMBOPIAHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4568160", Offset = "0x4567560", VA = "0x184568160")]
	public static bool ILMCFLMCOJH([In] DPGCDKOEDPO<T> JLJHECODIOL, [In] DPGCDKOEDPO<T> DABLONGJEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x45673E0", Offset = "0x45667E0", VA = "0x1845673E0", Slot = "4")]
	public bool Equals(DPGCDKOEDPO<T> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x45675C0", Offset = "0x45669C0", VA = "0x1845675C0", Slot = "0")]
	public override bool Equals(object? LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4567C90", Offset = "0x4567090", VA = "0x184567C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4568800", Offset = "0x4567C00", VA = "0x184568800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class DLBOIONFDLD
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B11EB0", Offset = "0x3B112B0", VA = "0x183B11EB0")]
	public static DPGCDKOEDPO<T> FDHFGHAPJKC<T>([In] T CBMEHPPMEEA) where T : notnull
	{
		return default(DPGCDKOEDPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B120B0", Offset = "0x3B114B0", VA = "0x183B120B0")]
	public static DPGCDKOEDPO<T?> FDOFGDMEOHC<T>()
	{
		return default(DPGCDKOEDPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B12270", Offset = "0x3B11670", VA = "0x183B12270")]
	public static bool IFFBOGDHKLN<T>([In] this DPGCDKOEDPO<T> MMODJJKKEPO, [Out][NotNullWhen(true)] T CBMEHPPMEEA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B12200", Offset = "0x3B11600", VA = "0x183B12200")]
	public static bool IFFBOGDHKLN<T>([In] this DPGCDKOEDPO<T> MMODJJKKEPO, [Out][NotNullWhen(true)] T CBMEHPPMEEA, [Out] DPGCDKOEDPO<T> OLAHDIFANFH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B11D90", Offset = "0x3B11190", VA = "0x183B11D90")]
	public static T? DBHGIJKAGEF<T>([In] this DPGCDKOEDPO<T> MMODJJKKEPO, T? ABINAMGBLJP)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B11C50", Offset = "0x3B11050", VA = "0x183B11C50")]
	public static bool APJCHJKHAIA<T>([In] this DPGCDKOEDPO<T> MMODJJKKEPO, T CBMEHPPMEEA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OKEKLGONNOP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA1B0", Offset = "0x3EB95B0", VA = "0x183EBA1B0")]
	public static T FDIDOEOIMMM<T>([In] this DPGCDKOEDPO<T> MMODJJKKEPO) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct AELMFCBMNIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr JGDJOBDMLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr PGKLMOKCIPM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr DCLICKDLHOI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr AODOKPGOAMI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly AELMFCBMNIP BOBPMJBGCMC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool GAGDCLONJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84085E0", Offset = "0x84079E0", VA = "0x1884085E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
	public AELMFCBMNIP(IntPtr HHKDNIEBEAD, IntPtr MGJJDPEMNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void OJCMHNDMCLA(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void DGOOHFFDNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x84086C0", Offset = "0x8407AC0", VA = "0x1884086C0")]
	private static AELMFCBMNIP OKGKJIFCJIG()
	{
		return default(AELMFCBMNIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct OFDMENEOFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr CMDMOPAOKAF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
	private OFDMENEOFCP(IntPtr MGJJDPEMNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x84128D0", Offset = "0x8411CD0", VA = "0x1884128D0")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84127F0", Offset = "0x8411BF0", VA = "0x1884127F0")]
	public static OFDMENEOFCP EJOLKNBPCJB(string HDNPPEBJPAE)
	{
		return default(OFDMENEOFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D350", Offset = "0x2A7C750", VA = "0x182A7D350")]
	public static OFDMENEOFCP EJOLKNBPCJB([In] AELMFCBMNIP JOGPEFMKANJ, string HDNPPEBJPAE)
	{
		return default(OFDMENEOFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE70", Offset = "0x2A7C270", VA = "0x182A7CE70")]
	public static OFDMENEOFCP EJOLKNBPCJB([In] AELMFCBMNIP JOGPEFMKANJ, Func<string> HDNPPEBJPAE)
	{
		return default(OFDMENEOFCP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class GANGMIHMCDN : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? HHPGCMHHJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr DFMMFMKPKPE;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool OPAJEKDGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x840EAE0", Offset = "0x840DEE0", VA = "0x18840EAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x840E870", Offset = "0x840DC70", VA = "0x18840E870")]
	public static SHA256 CEOONNIFPHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x840E800", Offset = "0x840DC00", VA = "0x18840E800")]
	private static extern int CCCGAAKIJGG();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x840EF00", Offset = "0x840E300", VA = "0x18840EF00")]
	private static extern IntPtr PGGMBHEHNKA();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x840EBD0", Offset = "0x840DFD0", VA = "0x18840EBD0")]
	private static extern void HLLPDOMJOGG(IntPtr DFMMFMKPKPE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x840E990", Offset = "0x840DD90", VA = "0x18840E990")]
	private static extern void DDIPPAEIPHC(IntPtr DFMMFMKPKPE, byte[] NGIAGNLBILI, int FDIDNNCIDHK, int NJGDBLHLJJL);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x840E8F0", Offset = "0x840DCF0", VA = "0x18840E8F0")]
	private static extern void CGMNABFPCCP(IntPtr DFMMFMKPKPE, byte[] NGDNPNMKEOA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x840EF70", Offset = "0x840E370", VA = "0x18840EF70")]
	private GANGMIHMCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x840EC50", Offset = "0x840E050", VA = "0x18840EC50", Slot = "18")]
	protected override void HashCore(byte[] LMLCJEFLFMP, int OOBFBOGHICM, int HACJDEOOAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x840ED10", Offset = "0x840E110", VA = "0x18840ED10", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x840EE40", Offset = "0x840E240", VA = "0x18840EE40", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x840EA50", Offset = "0x840DE50", VA = "0x18840EA50", Slot = "13")]
	protected override void Dispose(bool GHOPBBENGHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AJDNOCCPMPH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool BNDOBNNDPOO<in TInput, TResult>(TInput MICKAKKPGLH, [Out] TResult HJBCDFKDKBA);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class DOHOGFBFMPL : EMLIIDLGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class HBJIEIEKBBG : CBDBDMGOGMG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly HBJIEIEKBBG NKAKNKMIPPI;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool HBLLBEFBBKP
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x840F960", Offset = "0x840ED60", VA = "0x18840F960", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x840F800", Offset = "0x840EC00", VA = "0x18840F800", Slot = "6")]
			public void OnCompleted(Action EPKFEJDGNAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			public void MLIPGIOCGJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public HBJIEIEKBBG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly DOHOGFBFMPL NKAKNKMIPPI;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		private DOHOGFBFMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x840D210", Offset = "0x840C610", VA = "0x18840D210", Slot = "4")]
		public CBDBDMGOGMG JNHNNPMDNOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class LBEJOOHFBHK : EMLIIDLGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class LHKHAACHBPF : CBDBDMGOGMG, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly LHKHAACHBPF NKAKNKMIPPI;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool HBLLBEFBBKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x8410A40", Offset = "0x840FE40", VA = "0x188410A40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x84109F0", Offset = "0x840FDF0", VA = "0x1884109F0", Slot = "6")]
			public void OnCompleted(Action EPKFEJDGNAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			public void MLIPGIOCGJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public LHKHAACHBPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly LBEJOOHFBHK NKAKNKMIPPI;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		private LBEJOOHFBHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8410820", Offset = "0x840FC20", VA = "0x188410820", Slot = "4")]
		public CBDBDMGOGMG JNHNNPMDNOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class LPPCFENADNO<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LPPCFENADNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49EE1A0", Offset = "0x49ED5A0", VA = "0x1849EE1A0")]
		internal void NGIOPKPNJGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JCIAIMAAFHH<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JCIAIMAAFHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x53042F0", Offset = "0x53036F0", VA = "0x1853042F0")]
		internal void BBLEKGADKBJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LALBBELJPCP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x84103A0", Offset = "0x840F7A0", VA = "0x1884103A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct CJHOKIDINFM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x840D100", Offset = "0x840C500", VA = "0x18840D100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct EGMDDPGFCGN<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x49D1430", Offset = "0x49D0830", VA = "0x1849D1430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x49D15A0", Offset = "0x49D09A0", VA = "0x1849D15A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct JFKPDOFPJLE<T> : IAsyncStateMachine where T : notnull
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
		public bool logCancellations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AKNCNLDICPO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x530CE40", Offset = "0x530C240", VA = "0x18530CE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x530D240", Offset = "0x530C640", VA = "0x18530D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FCCDLLCGDFN<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D580", Offset = "0x4E5C980", VA = "0x184E5D580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4E5D9A0", Offset = "0x4E5CDA0", VA = "0x184E5D9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct ALHFFNLNBMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x840B450", Offset = "0x840A850", VA = "0x18840B450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x840B660", Offset = "0x840AA60", VA = "0x18840B660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class EMHNCNIHNHL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EMHNCNIHNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x49EE1A0", Offset = "0x49ED5A0", VA = "0x1849EE1A0")]
		internal void PLFOGFOFGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x49EE140", Offset = "0x49ED540", VA = "0x1849EE140")]
		internal void IGFBPLBKCKD(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct LBBCJBJEGHG<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BNDOBNNDPOO<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x54E6DE0", Offset = "0x54E61E0", VA = "0x1854E6DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x54E7490", Offset = "0x54E6890", VA = "0x1854E7490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct AEINFKOJJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8407D80", Offset = "0x8407180", VA = "0x188407D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8408580", Offset = "0x8407980", VA = "0x188408580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EOJIAMENNHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x840D5A0", Offset = "0x840C9A0", VA = "0x18840D5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x840DAF0", Offset = "0x840CEF0", VA = "0x18840DAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct PGAIOEODFDO<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3C40", Offset = "0x5AC3040", VA = "0x185AC3C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4E94E90", Offset = "0x4E94290", VA = "0x184E94E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class MAFCBLCONCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<EPILOLMBDMK> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MAFCBLCONCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8411270", Offset = "0x8410670", VA = "0x188411270")]
		internal void LGPAMHFOPHO(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct NLEJFHMEGBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IEnumerable<Task> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Task[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8411B20", Offset = "0x8410F20", VA = "0x188411B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8411DA0", Offset = "0x84111A0", VA = "0x188411DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct GOENMJEKAPH<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4F66830", Offset = "0x4F65C30", VA = "0x184F66830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x44C2D30", Offset = "0x44C2130", VA = "0x1844C2D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct IPHIMOLODDF<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x511A840", Offset = "0x5119C40", VA = "0x18511A840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x44C1E60", Offset = "0x44C1260", VA = "0x1844C1E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct KIAEHGOPDGA<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x544F0C0", Offset = "0x544E4C0", VA = "0x18544F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x544FF30", Offset = "0x544F330", VA = "0x18544FF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct GEHHOPOJLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x840EFA0", Offset = "0x840E3A0", VA = "0x18840EFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x840F180", Offset = "0x840E580", VA = "0x18840F180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct LKDODEBNJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8410AE0", Offset = "0x840FEE0", VA = "0x188410AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8410E50", Offset = "0x8410250", VA = "0x188410E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct IJBHALPLOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x840FE70", Offset = "0x840F270", VA = "0x18840FE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8410160", Offset = "0x840F560", VA = "0x188410160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GOAPACBMCAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GOAPACBMCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x840F1E0", Offset = "0x840E5E0", VA = "0x18840F1E0")]
		internal Task MDNMDLFGPDN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct ODJJALLABCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x84122F0", Offset = "0x84116F0", VA = "0x1884122F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8412550", Offset = "0x8411950", VA = "0x188412550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct NLOMLOADAIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8411E10", Offset = "0x8411210", VA = "0x188411E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8411FF0", Offset = "0x84113F0", VA = "0x188411FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct LPNNIPAOGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8410EB0", Offset = "0x84102B0", VA = "0x188410EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8411210", Offset = "0x8410610", VA = "0x188411210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct NHBCBPIKFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x84117D0", Offset = "0x8410BD0", VA = "0x1884117D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8411AC0", Offset = "0x8410EC0", VA = "0x188411AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class EOEODBKDCPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EOEODBKDCPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x840D530", Offset = "0x840C930", VA = "0x18840D530")]
		internal Task LCMDAFKKHJB(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct BNGELHLICGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x840C510", Offset = "0x840B910", VA = "0x18840C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x840C770", Offset = "0x840BB70", VA = "0x18840C770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct JMFPAHAJNMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84101C0", Offset = "0x840F5C0", VA = "0x1884101C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8410340", Offset = "0x840F740", VA = "0x188410340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct HFIDHCHDINJ<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4FB4A70", Offset = "0x4FB3E70", VA = "0x184FB4A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4FB4D20", Offset = "0x4FB4120", VA = "0x184FB4D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct BBIJMCCGOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x840C180", Offset = "0x840B580", VA = "0x18840C180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x840C4B0", Offset = "0x840B8B0", VA = "0x18840C4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? NNMLNOHNLIN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<EPILOLMBDMK> OEFHNKDNHEG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task FCJMPJBLIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8409AD0", Offset = "0x8408ED0", VA = "0x188409AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x840AF60", Offset = "0x840A360", VA = "0x18840AF60")]
	public static bool NNNCPPJHEBI(this Task KDHFABGBLNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31F46F0", Offset = "0x31F3AF0", VA = "0x1831F46F0")]
	public static Task<T> GINENHLFCPE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x840AD00", Offset = "0x840A100", VA = "0x18840AD00")]
	public static Task LNNDKPIHBKC(this Task KDHFABGBLNO, CancellationToken MONGIMOHLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31F7D00", Offset = "0x31F7100", VA = "0x1831F7D00")]
	public static Task<TResult> LNNDKPIHBKC<TResult>(this Task<TResult> KDHFABGBLNO, CancellationToken MONGIMOHLAO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31F5470", Offset = "0x31F4870", VA = "0x1831F5470")]
	public static TaskCompletionSource<TResult> LNNDKPIHBKC<TResult>(this TaskCompletionSource<TResult> NACPPPLHBBA, CancellationToken MONGIMOHLAO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8409940", Offset = "0x8408D40", VA = "0x188409940")]
	public static IDisposable? EAMGEMGJLBM(CancellationToken EILPKPDOOFJ, CancellationToken MMCNOJPFIMG, [Out] CancellationToken NBIEDNGNHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8409FF0", Offset = "0x84093F0", VA = "0x188409FF0")]
	[AsyncStateMachine(typeof(LALBBELJPCP))]
	public static void GFOEBPPHKNE(this Task DBAMLJDDEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84091F0", Offset = "0x84085F0", VA = "0x1884091F0")]
	[AsyncStateMachine(typeof(CJHOKIDINFM))]
	public static void BICKNNKGMGP(this Task DBAMLJDDEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31F3D60", Offset = "0x31F3160", VA = "0x1831F3D60")]
	[AsyncStateMachine(typeof(EGMDDPGFCGN<>))]
	public static Task DKOBDDNCDFL<TException>(this Task DBAMLJDDEJL) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31F44F0", Offset = "0x31F38F0", VA = "0x1831F44F0")]
	[AsyncStateMachine(typeof(JFKPDOFPJLE<>))]
	public static Task<T> GHHEEEHMJPE<T>(this Task<T> DMFKPMONDPO, AKNCNLDICPO CCLJCJDJCOE, Func<Task<T>, string> JEMHEPPCCHN, bool PCLAMGIMLLG = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x31F4410", Offset = "0x31F3810", VA = "0x1831F4410")]
	[AsyncStateMachine(typeof(FCCDLLCGDFN<>))]
	public static Task<T> GHHEEEHMJPE<T>(this Task<T> DMFKPMONDPO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8409750", Offset = "0x8408B50", VA = "0x188409750")]
	[AsyncStateMachine(typeof(ALHFFNLNBMD))]
	public static Task<TaskStatus> CBNLCLHMAGL(this Task? DMFKPMONDPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x31F3FF0", Offset = "0x31F33F0", VA = "0x1831F3FF0")]
	public static (Task<T?>?, Action<T?>?) FDNEGMOJJEA<T>([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x31F9300", Offset = "0x31F8700", VA = "0x1831F9300")]
	[AsyncStateMachine(typeof(LBBCJBJEGHG<, >))]
	public static Task<List<TResult>> OFEGGBOJNJC<TResult, TInput>(this Task<List<TInput>> KDHFABGBLNO, BNDOBNNDPOO<TInput, TResult> BKHONFEJKBL) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x840ABD0", Offset = "0x8409FD0", VA = "0x18840ABD0")]
	[AsyncStateMachine(typeof(AEINFKOJJMH))]
	public static Task LCBLNPOIKNH(Task DBAMLJDDEJL, CancellationToken NILMHHOPMOB, Func<CancellationToken, Task> CIEKCIBCGLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8409620", Offset = "0x8408A20", VA = "0x188409620")]
	[AsyncStateMachine(typeof(EOJIAMENNHH))]
	public static Task CBDDFJJCNIM(Func<CancellationToken, Task> MEBGBNKILEM, TimeSpan BLPEEGBOENF, [Optional] CancellationToken NILMHHOPMOB, [Optional] Action<OperationCanceledException>? LAHMDLHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x31F3B00", Offset = "0x31F2F00", VA = "0x1831F3B00")]
	[AsyncStateMachine(typeof(PGAIOEODFDO<>))]
	public static Task<T> CBDDFJJCNIM<T>(Func<CancellationToken, Task<T>> MEBGBNKILEM, TimeSpan BLPEEGBOENF, [Optional] CancellationToken NILMHHOPMOB, [Optional] Func<OperationCanceledException, T>? LAHMDLHGGIO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x840A8A0", Offset = "0x8409CA0", VA = "0x18840A8A0")]
	public static Task HEPECMFLLFN(params Task[] LMDNHAKFDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x840A3E0", Offset = "0x84097E0", VA = "0x18840A3E0")]
	public static Task HEPECMFLLFN(IEnumerable<Task> LMDNHAKFDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8409840", Offset = "0x8408C40", VA = "0x188409840")]
	[AsyncStateMachine(typeof(NLEJFHMEGBO))]
	public static Task<IEnumerable<Task>> EAKAHBIMAPN(IEnumerable<Task> LMDNHAKFDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x31F3F10", Offset = "0x31F3310", VA = "0x1831F3F10")]
	[AsyncStateMachine(typeof(GOENMJEKAPH<>))]
	public static Task<IEnumerable<Task<T>>> EAKAHBIMAPN<T>(IEnumerable<Task<T>> LMDNHAKFDDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x31F4B00", Offset = "0x31F3F00", VA = "0x1831F4B00")]
	[AsyncStateMachine(typeof(IPHIMOLODDF<, , >))]
	public static Task<(T1, T2, T3)> LEIBJFFLDNA<T1, T2, T3>(Task<T1> ACGOHIDPBKJ, Task<T2> EPCALBPCOPE, Task<T3> KIDEDGBKHPC) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x31F4840", Offset = "0x31F3C40", VA = "0x1831F4840")]
	[AsyncStateMachine(typeof(KIAEHGOPDGA<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> LEIBJFFLDNA<T1, T2, T3, T4, T5>(Task<T1> ACGOHIDPBKJ, Task<T2> EPCALBPCOPE, Task<T3> KIDEDGBKHPC, Task<T4> MEOCGEMLDGA, Task<T5> BBPPCDAGMFI) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x840B0A0", Offset = "0x840A4A0", VA = "0x18840B0A0")]
	[AsyncStateMachine(typeof(GEHHOPOJLBA))]
	public static Task PCFAFAEKJNP(Func<bool> BMOACCMKDNJ, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x840AF90", Offset = "0x840A390", VA = "0x18840AF90")]
	[AsyncStateMachine(typeof(LKDODEBNJNK))]
	public static Task PCFAFAEKJNP(Func<bool> BMOACCMKDNJ, TimeSpan NOMPOPKOFBI, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x840A2B0", Offset = "0x84096B0", VA = "0x18840A2B0")]
	[AsyncStateMachine(typeof(IJBHALPLOCL))]
	public static Task GPCOLELLPFN(Func<bool> BMOACCMKDNJ, TimeSpan BLPEEGBOENF, [Optional] CancellationToken GMKBGHHNCDJ, [Optional] Action<OperationCanceledException>? LAHMDLHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x840A170", Offset = "0x8409570", VA = "0x18840A170")]
	[AsyncStateMachine(typeof(ODJJALLABCE))]
	public static Task GPCOLELLPFN(Func<bool> BMOACCMKDNJ, TimeSpan BLPEEGBOENF, TimeSpan NOMPOPKOFBI, [Optional] CancellationToken GMKBGHHNCDJ, [Optional] Action<OperationCanceledException>? LAHMDLHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x840B190", Offset = "0x840A590", VA = "0x18840B190")]
	[AsyncStateMachine(typeof(NLOMLOADAIB))]
	public static Task PJPPBANEKOM(Func<bool> BMOACCMKDNJ, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x840B280", Offset = "0x840A680", VA = "0x18840B280")]
	[AsyncStateMachine(typeof(LPNNIPAOGPK))]
	public static Task PJPPBANEKOM(Func<bool> BMOACCMKDNJ, TimeSpan NOMPOPKOFBI, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8409C80", Offset = "0x8409080", VA = "0x188409C80")]
	[AsyncStateMachine(typeof(NHBCBPIKFAE))]
	public static Task EGGJNHOHKDG(Func<bool> BMOACCMKDNJ, TimeSpan BLPEEGBOENF, [Optional] CancellationToken GMKBGHHNCDJ, [Optional] Action<OperationCanceledException>? LAHMDLHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8409B40", Offset = "0x8408F40", VA = "0x188409B40")]
	[AsyncStateMachine(typeof(BNGELHLICGK))]
	public static Task EGGJNHOHKDG(Func<bool> BMOACCMKDNJ, TimeSpan BLPEEGBOENF, TimeSpan NOMPOPKOFBI, [Optional] CancellationToken GMKBGHHNCDJ, [Optional] Action<OperationCanceledException>? LAHMDLHGGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8409E30", Offset = "0x8409230", VA = "0x188409E30")]
	[AsyncStateMachine(typeof(JMFPAHAJNMG))]
	[Obsolete]
	public static Task FMNMGMMIFCK(this Task KDHFABGBLNO, Action NMGKGKLCPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x31F4230", Offset = "0x31F3630", VA = "0x1831F4230")]
	[AsyncStateMachine(typeof(HFIDHCHDINJ<>))]
	[Obsolete]
	public static Task FMNMGMMIFCK<T>(this Task<T> KDHFABGBLNO, Action<T> NMGKGKLCPAF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x840A940", Offset = "0x8409D40", VA = "0x18840A940")]
	private static void JIIEKJAMNFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84092A0", Offset = "0x84086A0", VA = "0x1884092A0")]
	public static bool BPNNPKBGPGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x840AA40", Offset = "0x8409E40", VA = "0x18840AA40")]
	private static void LADEKBLKHAN(SynchronizationContext CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x84090D0", Offset = "0x84084D0", VA = "0x1884090D0")]
	private static void AICGONDPCJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x840A0A0", Offset = "0x84094A0", VA = "0x18840A0A0")]
	public static void GKMHDCBOODO([Optional] string? AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8409DB0", Offset = "0x84091B0", VA = "0x188409DB0")]
	public static void EKKHPFCBHJM([Optional] string? AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x840A9F0", Offset = "0x8409DF0", VA = "0x18840A9F0")]
	public static EMLIIDLGJPE KBICFDBAPGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x840A8F0", Offset = "0x8409CF0", VA = "0x18840A8F0")]
	public static EMLIIDLGJPE IONHCGNHNBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8409F20", Offset = "0x8409320", VA = "0x188409F20")]
	[AsyncStateMachine(typeof(BBIJMCCGOBN))]
	public static Task GDLBAGGJDEM(Func<Task> PEHELHMLLIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class EAFHNCFGKJO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public EAFHNCFGKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ODNGAEKHHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x84125B0", Offset = "0x84119B0", VA = "0x1884125B0")]
	public static bool ANOFEENFJLK(this FNAODHMLAAP KKPLENBLEDD, DateTime EEDHKHALDJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x84126D0", Offset = "0x8411AD0", VA = "0x1884126D0")]
	public static TimeSpan NGDPDEBDPAG(this FNAODHMLAAP KKPLENBLEDD, DateTime EEDHKHALDJD)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EJNIEEJCHGA : FNAODHMLAAP
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly FNAODHMLAAP NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime MLKIAMDNKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x840D410", Offset = "0x840C810", VA = "0x18840D410", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset ILNMALEOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x840D450", Offset = "0x840C850", VA = "0x18840D450", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public EJNIEEJCHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FNAODHMLAAP
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime MLKIAMDNKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset ILNMALEOHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class AGOOJOFNKIB
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long JPECGKKDCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8408BF0", Offset = "0x8407FF0", VA = "0x188408BF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long AAAGMNMGECI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8408B00", Offset = "0x8407F00", VA = "0x188408B00")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double PAAPHAHFLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8408BA0", Offset = "0x8407FA0", VA = "0x188408BA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double BAENKIHBAND
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x84088A0", Offset = "0x8407CA0", VA = "0x1884088A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double ADGGHNBMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8408B50", Offset = "0x8407F50", VA = "0x188408B50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double LJCOEGEACPL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84088F0", Offset = "0x8407CF0", VA = "0x1884088F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x84089E0", Offset = "0x8407DE0", VA = "0x1884089E0")]
	public static double HOLGECLAKKF(long MOMGFMAIDHO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8408940", Offset = "0x8407D40", VA = "0x188408940")]
	public static double CFNPMDMIBGD(long MOMGFMAIDHO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8408A70", Offset = "0x8407E70", VA = "0x188408A70")]
	public static double IGKANKMBNPL(double AKJEKFMCNNL)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8408D70", Offset = "0x8408170", VA = "0x188408D70")]
	public static long PCGMHOKEJBM(long OLCPEFOMCCM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x84089D0", Offset = "0x8407DD0", VA = "0x1884089D0")]
	public static long CIILBPGHACG(long CHGHOONOMFA, long BEEEKBCMMCP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8408C40", Offset = "0x8408040", VA = "0x188408C40")]
	public static double NGCBMLPMLCC(long CHGHOONOMFA, long BEEEKBCMMCP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8408D10", Offset = "0x8408110", VA = "0x188408D10")]
	public static double OFMLMADCEKB(long CHGHOONOMFA, long BEEEKBCMMCP)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class PGKLIJLLDCL : MCLAMGMMGNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan MGKDMHMFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan BLPEEGBOENF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan DBDPOFGNANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8414080", Offset = "0x8413480", VA = "0x188414080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? JGNNGHLLEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8414320", Offset = "0x8413720", VA = "0x188414320")]
	[Preserve]
	public PGKLIJLLDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8414390", Offset = "0x8413790", VA = "0x188414390")]
	public PGKLIJLLDCL(TimeSpan BLPEEGBOENF, [Optional] Action? LAEEKKGKCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8413EE0", Offset = "0x84132E0", VA = "0x188413EE0", Slot = "7")]
	public void BCIEBGDAIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8414010", Offset = "0x8413410", VA = "0x188414010", Slot = "8")]
	public void EDJOKIJANJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8414280", Offset = "0x8413680", VA = "0x188414280", Slot = "9")]
	public void ODFHFAFBGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x12CE230", Offset = "0x12CD630", VA = "0x1812CE230")]
	private void PNPLKECCEMG(object PCKIEOGDDCF, ElapsedEventArgs CEMKCNDKKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x84141E0", Offset = "0x84135E0", VA = "0x1884141E0")]
	private static void LNLFAKKJOEG(TimeSpan PBMHLGDFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8413F70", Offset = "0x8413370", VA = "0x188413F70", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class NLHJBHMDBCC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? HKDCHEDCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string GLHAEMONBHL;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x193C250", Offset = "0x193B650", VA = "0x18193C250")]
	public NLHJBHMDBCC(string GMABBLIJJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x52BF940", Offset = "0x52BED40", VA = "0x1852BF940")]
	public NLHJBHMDBCC(string HHKLKJCBFCE, string GMABBLIJJKB)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OKGEIGJJJJK : IEquatable<OKGEIGJJJJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint HFDGHCGAEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int PJKBIGAGHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float CCNPDOGCEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort OFNAPPNFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort NHFMIIBHFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short GLGFJAEOHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short BPFJMHKMHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char DALPIPAHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char OKGMNDPHFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte MIJJOOMEIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte NGIKFLJOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte IABANLDKFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte BDINBIIDPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool NNGOFKEOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool INOJPKLNBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool MKNFFFINGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool JLJFDICNONI;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126960", VA = "0x182127560")]
	public static OKGEIGJJJJK LHPEAGCFJED(uint MPDMOEEKIAK)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126960", VA = "0x182127560")]
	public static OKGEIGJJJJK LBBFIHCJHLC(int POGJGJIJNFA)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8412970", Offset = "0x8411D70", VA = "0x188412970")]
	public static OKGEIGJJJJK GEKLECHCNLD(float PCLMBHDFGOJ)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8412980", Offset = "0x8411D80", VA = "0x188412980")]
	public static OKGEIGJJJJK IGIICGCOIMD(byte EOKLOMGJLGE, byte ABGEBFNIDAE, byte GMCLBLHLHBG, byte JIHKEGIDCCA)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8412980", Offset = "0x8411D80", VA = "0x188412980")]
	public static OKGEIGJJJJK HLEPPOLLDLN(bool JBFBENDNEHK, bool BCLFNAINJKK, bool HJEHNEPCMCD, bool PCGMDJEGKOB)
	{
		return default(OKGEIGJJJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8412980", Offset = "0x8411D80", VA = "0x188412980")]
	public static OKGEIGJJJJK JAEAKDMOKNN(byte FKCHLHOCGPE, byte FNIPAJPNAFB, byte PJDBLOINBBL, byte MLINOFKKOHD)
	{
		return default(OKGEIGJJJJK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x247BA10", Offset = "0x247AE10", VA = "0x18247BA10")]
	public static bool ILMCFLMCOJH(OKGEIGJJJJK KEHFCBFJCMA, OKGEIGJJJJK KGECIONKOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x247B9F0", Offset = "0x247ADF0", VA = "0x18247B9F0", Slot = "4")]
	public bool Equals(OKGEIGJJJJK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x84128E0", Offset = "0x8411CE0", VA = "0x1884128E0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1543490", Offset = "0x1542890", VA = "0x181543490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x84129A0", Offset = "0x8411DA0", VA = "0x1884129A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct OCJDJMEJBMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong PDKMPAPANME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long AJLEOHLGNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double OBOCIGEKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint OCBBPHDCDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint MBCGFKCDBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int OJDNNNEFNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int MJIGAPHGKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float GOFBBDFCEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float EKNKAHMNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort OFNAPPNFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort NHFMIIBHFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort LNIBJCBECKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort KPFBBGLABJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short GLGFJAEOHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short BPFJMHKMHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short GMIPELKIKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short JIHHGHFEALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char DALPIPAHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char OKGMNDPHFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char AHPCGKANMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char IPBKGBEEFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte MIJJOOMEIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte NGIKFLJOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte IABANLDKFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte BDINBIIDPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte DHGBJPJHCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte CFPCGBEFAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte NOAGLMAGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte EPEKCIDHGEG;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static OCJDJMEJBMB EJOLKNBPCJB(long ECINPPMMPHO)
	{
		return default(OCJDJMEJBMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x84122A0", Offset = "0x84116A0", VA = "0x1884122A0")]
	public static OCJDJMEJBMB EJOLKNBPCJB(byte EOKLOMGJLGE, byte ABGEBFNIDAE, byte GMCLBLHLHBG, byte JIHKEGIDCCA, byte JLMNBKBILHC, byte GCBNOLHNGFK, byte BMINDINDEDJ, byte BNGCDFLKJOG)
	{
		return default(OCJDJMEJBMB);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct LBBLJHFBFGM : IEquatable<LBBLJHFBFGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte DPFAFKOIHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool DIKLCNGMHEB;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x31B4560", Offset = "0x31B3960", VA = "0x1831B4560")]
	public static LBBLJHFBFGM IGIICGCOIMD(byte EHEMEFLHMMA)
	{
		return default(LBBLJHFBFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x31B4560", Offset = "0x31B3960", VA = "0x1831B4560")]
	public static LBBLJHFBFGM HLEPPOLLDLN(bool LFCPLENDPPK)
	{
		return default(LBBLJHFBFGM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x84105A0", Offset = "0x840F9A0", VA = "0x1884105A0")]
	public static bool ILMCFLMCOJH(LBBLJHFBFGM KEHFCBFJCMA, LBBLJHFBFGM KGECIONKOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x72AFFE0", Offset = "0x72AF3E0", VA = "0x1872AFFE0", Slot = "4")]
	public bool Equals(LBBLJHFBFGM LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x8410500", Offset = "0x840F900", VA = "0x188410500", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8410590", Offset = "0x840F990", VA = "0x188410590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x84105B0", Offset = "0x840F9B0", VA = "0x1884105B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CKPBCEONPOB<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T DLNCBHFLOHF;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D81630", Offset = "0x6D80A30", VA = "0x186D81630")]
	public CKPBCEONPOB(T KKGPOJALAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class GDINACPDIMC
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0750", Offset = "0x3CAFB50", VA = "0x183CB0750")]
	public static IEnumerable<T> KJFCAFBHAMF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static T[] JCELPMJKEAH<T>(params T[] OKFDFFNHKHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static IEnumerable<T> DIGDEEFCIGH<T>(params T[] OKFDFFNHKHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static HashSet<T> MJFBMLOLFHO<T>(params T[] OKFDFFNHKHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0660", Offset = "0x3CAFA60", VA = "0x183CB0660")]
	public static KeyValuePair<TKey, TValue> FONOLGLDOEF<TKey, TValue>([In] TKey PEENICAIFOP, [In] TValue CBMEHPPMEEA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static List<T> LLCFBJPKOJF<T>(IEnumerable<T> PHCFLGCBHJB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class BGHKIGCMBGA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string LPPGNDDKLJO;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
	public BGHKIGCMBGA(string BEKKFILOPCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object CFOLAJGKKPC<T>([In] T PHAOHJHLKGO);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object LMNEGAGDIEO<T>(T PHAOHJHLKGO);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FBJIMJNDDFF]
public delegate string LEIAKADDLBK(string BPHJBCALMCO, string? KOJGIHKIGBD, bool PPDDMOKIGCD);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[FBJIMJNDDFF]
public delegate void IDPPFCNEING(string AFDNIPHJHMO);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[FBJIMJNDDFF]
public delegate void CKCGPEDIADC(Exception DGLGDFPJBDB);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object FFLGGJFPFJC();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FBJIMJNDDFF]
public delegate bool APMMPIEKGGG();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[FBJIMJNDDFF]
public delegate string HFLCJNLBEMM(object DEJGDIIDCDN);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class INBFNJOMCFE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
	public INBFNJOMCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class PENKGFMJABM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct POMNEJHJJNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8414660", Offset = "0x8413A60", VA = "0x188414660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8414F50", Offset = "0x8414350", VA = "0x188414F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback HKCLBLMHAEP;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> MEDNFKPINKG;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8413870", Offset = "0x8412C70", VA = "0x188413870")]
	public static Task<bool> CINOAGPGNDJ(int HOODCFFBCGE, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8413CA0", Offset = "0x84130A0", VA = "0x188413CA0")]
	[AsyncStateMachine(typeof(POMNEJHJJNJ))]
	private static Task<bool> JOHMKJLCMOG(int HOODCFFBCGE, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8413C10", Offset = "0x8413010", VA = "0x188413C10")]
	private static void GPPAJIKCGCE(object? JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8413B80", Offset = "0x8412F80", VA = "0x188413B80")]
	private static void GGJHIFEMJAK(object? JPDKKKJJNLC)
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
